module Hub.Commands.Test

open System.ComponentModel
open BlackFox.CommandLine
open Spectre.Console.Cli
open Hub
open Hub.Binding
open Hub.Utils

type TestSettings() =
    inherit CommandSettings()

    [<CommandArgument(0, "[binding]")>]
    [<Description("The binding to test, every binding when omitted")>]
    member val Binding: string = null with get, set

    [<CommandOption("--changed")>]
    [<Description("Only the bindings touched since the base branch, and the ones referencing them")>]
    member val IsChanged: bool = false with get, set

    [<CommandOption("--noCache")>]
    [<Description("Forwarded to Fable, recompiles every file instead of reusing the cache")>]
    member val IsNoCache: bool = false with get, set

/// A binding without tests is built, the others run in Node or through a page in Chromium
let run (noCache: bool) (binding: Binding) =
    let fableOptions =
        [
            if noCache then
                "--noCache"
        ]

    match binding.Config.Tests with
    | None ->
        printfn $"Building {binding.Name}"

        Shell.run
            "dotnet"
            (CmdLine.empty
             |> CmdLine.appendRaw "build"
             |> CmdLine.appendRaw binding.ProjectFile
             |> CmdLine.appendPrefix "-c" "Release")
            Workspace.root
    | Some Tests.Node ->
        printfn $"Testing {binding.Name} in Node"
        Shell.fable binding.TestsDir (fableOptions @ [ "--runScript" ])
    | Some Tests.Browser ->
        printfn $"Testing {binding.Name} in Chromium"
        Shell.fable (binding.TestsDir + "/page") (fableOptions @ [ "--outDir"; "build" ])

        Shell.run
            "npx"
            (CmdLine.empty |> CmdLine.appendRaw "vite build")
            (binding.TestsDir + "/page")

        Shell.fable binding.TestsDir (fableOptions @ [ "--runScript" ])

type TestCommand() =
    inherit Command<TestSettings>()

    override _.Execute(_, settings) =
        let bindings = Generate.select settings.Binding settings.IsChanged

        Shell.pnpmInstall ()

        for binding in bindings do
            run settings.IsNoCache binding

        0
