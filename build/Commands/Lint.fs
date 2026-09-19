module Hub.Commands.Lint

open SimpleExec
open Spectre.Console.Cli

type LintSettings() =
    inherit CommandSettings()

type LintCommand() =
    inherit Command<LintSettings>()

    override _.Execute(_, _) =
        Command.Run("dotnet", "fantomas --check build bindings")
        0
