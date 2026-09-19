module Hub.Commands.Format

open SimpleExec
open Spectre.Console.Cli

type FormatSettings() =
    inherit CommandSettings()

type FormatCommand() =
    inherit Command<FormatSettings>()

    override _.Execute(_, _) =
        Command.Run("dotnet", "fantomas build bindings")
        0
