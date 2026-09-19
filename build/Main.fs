module Hub.Main

open SimpleExec
open Spectre.Console.Cli
open Hub.Commands

[<EntryPoint>]
let main args =
    if System.Environment.GetEnvironmentVariable "ACT" = null then
        Command.Run("dotnet", "husky install")

    let app = CommandApp()

    app.Configure(fun config ->
        config.Settings.ApplicationName <- "./build.sh"

        config
            .AddCommand<List.ListCommand>("list")
            .WithDescription("List the bindings of the hub")
        |> ignore

        config
            .AddCommand<New.NewCommand>("new")
            .WithDescription(
                """Scaffold a binding for an npm package and generate it

./build.sh new date-fns --input date-fns/locale --tests node
./build.sh new @types/leaflet --external Glutinum.Geojson"""
            )
        |> ignore

        config
            .AddCommand<AddTests.AddTestsCommand>("add-tests")
            .WithDescription(
                "Scaffold the tests of an existing binding, in Node or in Chromium with --browser"
            )
        |> ignore

        config
            .AddCommand<Generate.GenerateCommand>("generate")
            .WithDescription(
                """Regenerate the bindings with the Glutinum CLI of package.json, or the one GLUTINUM_CLI points to

`--check` fails when the committed files are out of date"""
            )
        |> ignore

        config
            .AddCommand<Test.TestCommand>("test")
            .WithDescription("Build the bindings and run their tests")
        |> ignore

        config
            .AddCommand<Upgrade.UpgradeCommand>("upgrade")
            .WithDescription(
                "Pin a newer version of the npm package of a binding and regenerate it"
            )
        |> ignore

        config
            .AddCommand<Release.ReleaseCommand>("release")
            .WithDescription("Pack the bindings and push the new versions to nuget.org")
        |> ignore

        config
            .AddCommand<Lint.LintCommand>("lint")
            .WithDescription("Check the formatting of the build and the tests")
        |> ignore

        config
            .AddCommand<Format.FormatCommand>("format")
            .WithDescription("Format the build and the tests")
        |> ignore
    )

    app.Run(args)
