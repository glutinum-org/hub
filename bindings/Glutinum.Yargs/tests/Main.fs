module Glutinum.Yargs.Tests.Main

open Fable.Core
open Fable.Core.JsInterop
open Scriptorium.Nib.Assertion
open Glutinum

open type Scriptorium.Quill.Runner
open type Scriptorium.Quill.Test

// `yargs (argv)` parses the arguments given instead of the ones of the process
let private parser (args: string list) =
    Yargs.Exports.yargs(U2.Case1(ResizeArray args)).exitProcess false

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
                                        jsOptions<Yargs.yargs_.Options> (fun options ->
                                            options.alias <- Some(U2.Case1 "n")
                                            options.string <- Some true
                                            options.describe <- Some "Who to greet"
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
                            let builder: Yargs.yargs_.Argv<obj> -> unit = fun _ -> ()

                            // The positional of the command is a key of the arguments
                            let handler
                                : Yargs.yargs_.ArgumentsCamelCase<obj> -> U2<unit, JS.Promise<unit>> =
                                fun args ->
                                    greeted <- args?who
                                    U2.Case1()

                            (parser [ "greet"; "Ada" ])
                                .command("greet <who>", "Greets someone", builder, handler)
                                .parseSync ()
                            |> ignore

                            assertThat greeted (isEqualTo "Ada")
                    )
                ]
            )
        ]
