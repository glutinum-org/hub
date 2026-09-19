module Hub.Commands.Release

open System
open System.IO
open BlackFox.CommandLine
open Spectre.Console.Cli
open Hub
open Hub.Binding
open Hub.Utils

type ReleaseSettings() =
    inherit CommandSettings()

/// Pack every binding and push the versions nuget.org doesn't have, a binding after the ones it references
type ReleaseCommand() =
    inherit Command<ReleaseSettings>()

    override _.Execute(_, _) =
        let apiKey = Environment.GetEnvironmentVariable "NUGET_KEY"

        if String.IsNullOrWhiteSpace apiKey then
            printfn "NUGET_KEY is not set"
            1
        else
            let output = Path.Combine(Workspace.root, "nupkgs")

            for binding in dependencyOrder (all ()) do
                Shell.run
                    "dotnet"
                    (CmdLine.empty
                     |> CmdLine.appendRaw "pack"
                     |> CmdLine.appendRaw binding.ProjectFile
                     |> CmdLine.appendPrefix "-c" "Release"
                     |> CmdLine.appendPrefix "-o" output)
                    Workspace.root

                for nupkg in Directory.GetFiles(output, $"{binding.Name}.*.nupkg") do
                    Shell.run
                        "dotnet"
                        (CmdLine.empty
                         |> CmdLine.appendRaw "nuget"
                         |> CmdLine.appendRaw "push"
                         |> CmdLine.appendRaw nupkg
                         |> CmdLine.appendPrefix "--api-key" apiKey
                         |> CmdLine.appendPrefix "--source" "https://api.nuget.org/v3/index.json"
                         |> CmdLine.appendRaw "--skip-duplicate")
                        Workspace.root

            0
