module Hub.Commands.List

open Spectre.Console
open Spectre.Console.Cli
open Hub.Binding

type ListSettings() =
    inherit CommandSettings()

type ListCommand() =
    inherit Command<ListSettings>()

    override _.Execute(_, _) =
        let table = Table()

        table.AddColumns("Binding", "Package", "Version", "Inputs", "Externals", "Tests")
        |> ignore

        for binding in all () do
            table.AddRow(
                binding.Name,
                binding.Config.Package,
                Hub.Glutinum.pinnedVersion binding,
                String.concat " " binding.Config.Inputs,
                String.concat " " binding.Config.Externals,
                (match binding.Config.Tests with
                 | Some tests -> tests.Text
                 | None -> "-")
            )
            |> ignore

        AnsiConsole.Write table
        0
