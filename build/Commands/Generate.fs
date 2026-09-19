module Hub.Commands.Generate

open System.ComponentModel
open BlackFox.CommandLine
open SimpleExec
open Spectre.Console.Cli
open Hub
open Hub.Binding
open Hub.Utils

type GenerateSettings() =
    inherit CommandSettings()

    [<CommandArgument(0, "[binding]")>]
    [<Description("The binding to generate, every binding when omitted")>]
    member val Binding: string = null with get, set

    [<CommandOption("--changed")>]
    [<Description("Only the bindings touched since the base branch, and the ones referencing them")>]
    member val IsChanged: bool = false with get, set

    [<CommandOption("--check")>]
    [<Description("Fail when the generated files differ from the committed ones")>]
    member val IsCheck: bool = false with get, set

/// The bindings a command works on, in dependency order
let select (name: string) (isChanged: bool) =
    let bindings = all ()

    let selected =
        match name with
        | null
        | "" ->
            if isChanged then
                changed bindings
            else
                bindings
        | name -> [ find name ]

    dependencyOrder selected

let generateAll (bindings: Binding list) =
    Shell.pnpmInstall ()

    for binding in bindings do
        printfn $"Generating {binding.Name}"
        Hub.Glutinum.generate (all ()) binding

type GenerateCommand() =
    inherit Command<GenerateSettings>()

    override _.Execute(_, settings) =
        let bindings = select settings.Binding settings.IsChanged

        generateAll bindings

        if settings.IsCheck && not bindings.IsEmpty then
            let files =
                bindings
                |> List.collect (fun binding ->
                    [
                        Workspace.relative binding.GeneratedFile
                        Workspace.relative binding.ProjectFile
                    ]
                )

            try
                Shell.run
                    "git"
                    (CmdLine.empty
                     |> CmdLine.appendRaw "diff"
                     |> CmdLine.appendRaw "--exit-code"
                     |> CmdLine.appendRaw "--stat"
                     |> CmdLine.appendRaw "--"
                     |> CmdLine.appendSeq files)
                    Workspace.root

                0
            with :? ExitCodeException ->
                printfn
                    "The bindings are out of date, run `./build.sh generate` and commit the result"

                1
        else
            0
