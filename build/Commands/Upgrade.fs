module Hub.Commands.Upgrade

open System.ComponentModel
open System.IO
open BlackFox.CommandLine
open Spectre.Console.Cli
open Hub
open Hub.Binding
open Hub.Utils

type UpgradeSettings() =
    inherit CommandSettings()

    [<CommandArgument(0, "<binding>")>]
    member val Binding: string = "" with get, set

    [<CommandArgument(1, "[version]")>]
    [<Description("The version of the npm package to pin, the latest otherwise")>]
    member val Version: string = null with get, set

type UpgradeCommand() =
    inherit Command<UpgradeSettings>()

    override _.Execute(_, settings) =
        let binding = find settings.Binding
        let current = Hub.Glutinum.pinnedVersion binding

        let version =
            match settings.Version with
            | null
            | "" ->
                Shell.read
                    "npm"
                    (CmdLine.empty
                     |> CmdLine.appendRaw "view"
                     |> CmdLine.appendRaw binding.Config.Package
                     |> CmdLine.appendRaw "version")
                    Workspace.root
            | version -> version

        if version = current then
            printfn $"{binding.Name} already pins {binding.Config.Package} {version}"
            0
        else
            File.WriteAllText(binding.PackageJson, Templates.packageJson binding version)
            Generate.generateAll [ binding ]

            Shell.run
                "git"
                (CmdLine.empty
                 |> CmdLine.appendRaw "diff"
                 |> CmdLine.appendRaw "--stat"
                 |> CmdLine.appendRaw "--"
                 |> CmdLine.appendRaw (Workspace.relative binding.Dir))
                Workspace.root

            printfn
                $"{binding.Name}: {binding.Config.Package} {current} -> {version}, review the diff then run `./build.sh test {binding.ModuleName}`"

            0
