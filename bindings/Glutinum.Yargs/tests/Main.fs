module Glutinum.Yargs.Tests.Main

open Fable.Core
open Fable.Core.JsInterop
open Scriptorium.Nib.Assertion
open Glutinum

open type Scriptorium.Quill.Runner
open type Scriptorium.Quill.Test

// `yargs (argv)` parses the arguments given instead of the ones of the process
let private parser (args: string list) =
    Yargs.Exports.yargs(ResizeArray args).exitProcess false

[<EntryPoint>]
let main _ =
    runTests
        [
            testList (
                "Glutinum.Yargs",
                [
                    test (
                        "options are parsed by name",
                        fun _ ->
                            let result = (parser [ "--name"; "Ada"; "--count"; "3" ]).parseSync ()
                            assertThat (unbox<string> result.["name"]) (isEqualTo "Ada")
                            assertThat (unbox<float> result.["count"]) (isEqualTo 3)
                    )

                    test (
                        "an option is declared with its type and an alias",
                        fun _ ->
                            let result =
                                (parser [ "-n"; "Ada" ])
                                    .option(
                                        "name",
                                        Yargs.Options.Create(
                                            alias = U2.Case1 "n",
                                            string = true,
                                            describe = "Who to greet"
                                        )
                                    )
                                    .parseSync ()

                            assertThat (unbox<string> result.["name"]) (isEqualTo "Ada")
                    )

                    test (
                        "boolean flags",
                        fun _ ->
                            let result = (parser [ "--verbose" ]).boolean("verbose").parseSync ()
                            assertThat (unbox<bool> result.["verbose"]) (isTrue)
                    )

                    test (
                        "positional arguments are in _",
                        fun _ ->
                            let result = (parser [ "build"; "src" ]).parseSync ()
                            let positional: ResizeArray<string> = unbox result.["_"]
                            assertThat (positional |> List.ofSeq) (isEqualTo [ "build"; "src" ])
                    )

                    test (
                        "a missing required option fails",
                        fun _ ->
                            let failed =
                                try
                                    (parser []).demandOption("name").parseSync () |> ignore
                                    false
                                with _ ->
                                    true

                            assertThat failed (isTrue)
                    )

                    test (
                        "scriptName sets $0",
                        fun _ ->
                            let result = (parser []).scriptName("app").parseSync ()
                            assertThat (unbox<string> result.["$0"]) (isEqualTo "app")
                    )

                    test (
                        "a command runs its handler",
                        fun _ ->
                            let mutable greeted = ""

                            // The builder and the handler are typed, so that the overload taking an options object is not a candidate
                            let builder: Yargs.Argv<obj> -> unit = fun _ -> ()

                            // The positional of the command is a key of the arguments
                            let handler: Yargs.ArgumentsCamelCase<obj> -> U2<unit, JS.Promise<unit>> =
                                fun args ->
                                    greeted <- args?who
                                    U2.Case1()

                            (parser [ "greet"; "Ada" ])
                                .command("greet <who>", "Greets someone", builder, handler)
                                .parseSync ()
                            |> ignore

                            assertThat greeted (isEqualTo "Ada")
                    )
                    test (
                        "a default value is applied",
                        fun _ ->
                            let result = (parser []).``default``("port", 8080.0).parseSync ()
                            assertThat (unbox<float> result.["port"]) (isEqualTo 8080)
                    )
                    test (
                        "a number option is parsed as a number",
                        fun _ ->
                            let result = (parser [ "--count"; "3" ]).number("count").parseSync ()
                            assertThat (unbox<float> result.["count"]) (isEqualTo 3)
                    )
                    test (
                        "a value outside the choices is rejected",
                        fun _ ->
                            let choices = ResizeArray [ "dev"; "prod" ]

                            let ok =
                                (parser [ "--env"; "dev" ]).choices("env", choices).parseSync ()

                            assertThat (unbox<string> ok.["env"]) (isEqualTo "dev")

                            let rejected =
                                try
                                    (parser [ "--env"; "test" ])
                                        .choices("env", choices)
                                        .parseSync ()
                                    |> ignore

                                    false
                                with _ ->
                                    true

                            assertThat rejected (isTrue)
                    )
                    test (
                        "a count option counts its occurrences",
                        fun _ ->
                            let result =
                                (parser [ "--verbose"; "--verbose" ]).count("verbose").parseSync ()

                            assertThat (unbox<float> result.["verbose"]) (isEqualTo 2)
                    )
                    test (
                        "an array option collects the values",
                        fun _ ->
                            let result = (parser [ "--tags"; "a"; "b" ]).array("tags").parseSync ()
                            let tags: ResizeArray<string> = unbox result.["tags"]
                            assertThat (tags |> List.ofSeq) (isEqualTo [ "a"; "b" ])
                    )
                    test (
                        "an alias maps the short name to the long one",
                        fun _ ->
                            let result = (parser [ "-n"; "Ada" ]).alias("n", "name").parseSync ()
                            assertThat (unbox<string> result.["name"]) (isEqualTo "Ada")
                    )
                    test (
                        "coerce transforms the parsed value",
                        fun _ ->
                            let result =
                                (parser [ "--port"; "21" ])
                                    .coerce("port", (fun (value: obj) -> unbox<float> value * 2.0))
                                    .parseSync ()

                            assertThat (unbox<float> result.["port"]) (isEqualTo 42)
                    )
                    testAsync (
                        "parseAsync resolves the arguments",
                        fun _ ->
                            async {
                                let! result =
                                    Async.AwaitPromise((parser [ "--name"; "Ada" ]).parseAsync ())

                                assertThat (unbox<string> result.["name"]) (isEqualTo "Ada")
                            }
                    )
                    testAsync (
                        "getHelp renders the usage",
                        fun _ ->
                            async {
                                let! help =
                                    Async.AwaitPromise(
                                        (parser []).usage("Usage: app <command>").getHelp ()
                                    )

                                assertThat (help.Contains "Usage: app <command>") (isTrue)
                            }
                    )
                    test (
                        "an option is declared with Options.Create",
                        fun _ ->
                            let result =
                                (parser [ "-n"; "Ada" ])
                                    .option(
                                        "name",
                                        Yargs.Options.Create(
                                            alias = U2.Case1 "n",
                                            string = true,
                                            describe = "Who to greet"
                                        )
                                    )
                                    .parseSync ()

                            assertThat (unbox<string> result.["name"]) (isEqualTo "Ada")
                    )
                    test (
                        "the positional arguments and the script name are typed",
                        fun _ ->
                            // `parseSync` gives `Arguments`, `_` and `$0` need no unbox
                            let result = (parser [ "build"; "src" ]).scriptName("app").parseSync ()
                            let positional: ResizeArray<U2<string, float>> = result.``_``
                            assertThat (positional.Count) (isEqualTo 2)
                            assertThat (result.``$0``) (isEqualTo "app")
                    )
                    test (
                        "Get and TryGet type an option without unbox",
                        fun _ ->
                            let result = (parser [ "--name"; "Ada" ]).parseSync ()
                            assertThat (result.Get<string> "name") (isEqualTo "Ada")
                            assertThat (result.TryGet<string> "name") (isEqualTo (Some "Ada"))
                            assertThat (result.TryGet<string> "missing") (isEqualTo None)
                    )
                    test (
                        "Command takes a plain handler",
                        fun _ ->
                            let mutable greeted = ""

                            (parser [ "greet"; "Ada" ])
                                .Command(
                                    "greet <who>",
                                    "Greets someone",
                                    fun args -> greeted <- args?who
                                )
                                .parseSync ()
                            |> ignore

                            assertThat greeted (isEqualTo "Ada")
                    )
                ]
            )
        ]
