module Hub.Commands.AddTests

open System.ComponentModel
open System.IO
open Spectre.Console.Cli
open Hub
open Hub.Binding

type AddTestsSettings() =
    inherit CommandSettings()

    [<CommandArgument(0, "<binding>")>]
    member val Binding: string = "" with get, set

    [<CommandOption("--browser")>]
    [<Description("The tests drive a page in Chromium, they run in Node otherwise")>]
    member val IsBrowser: bool = false with get, set

/// Write the test project of a binding and record it in binding.json
let scaffold (binding: Binding) (tests: Tests) =
    if binding.HasTests then
        failwithf "%s already has tests in %s" binding.Name (Workspace.relative binding.TestsDir)

    Directory.CreateDirectory binding.TestsDir |> ignore

    File.WriteAllText(
        Path.Combine(binding.TestsDir, "Tests.fsproj"),
        Templates.testsProject binding tests
    )

    match tests with
    | Tests.Node ->
        File.WriteAllText(Path.Combine(binding.TestsDir, "Main.fs"), Templates.nodeTests binding)
    | Tests.Browser ->
        File.WriteAllText(Path.Combine(binding.TestsDir, "Main.fs"), Templates.browserTests binding)

        let page = Path.Combine(binding.TestsDir, "page")
        Directory.CreateDirectory page |> ignore
        File.WriteAllText(Path.Combine(page, "Page.fsproj"), Templates.pageProject binding)
        File.WriteAllText(Path.Combine(page, "Page.fs"), Templates.pageSource binding)
        File.WriteAllText(Path.Combine(page, "index.html"), Templates.pageHtml binding)
        File.WriteAllText(Path.Combine(page, "vite.config.ts"), Templates.pageViteConfig)

    let binding =
        { binding with
            Config =
                { binding.Config with
                    Tests = Some tests
                }
        }

    save binding

    printfn
        $"Tests written in {Workspace.relative binding.TestsDir}, run them with `./build.sh test {binding.ModuleName}`"

type AddTestsCommand() =
    inherit Command<AddTestsSettings>()

    override _.Execute(_, settings) =
        let binding = find settings.Binding

        scaffold
            binding
            (if settings.IsBrowser then
                 Tests.Browser
             else
                 Tests.Node)

        0
