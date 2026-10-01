module Hub.Glutinum

open System
open System.IO
open System.Text.Json
open System.Text.RegularExpressions
open BlackFox.CommandLine
open Hub.Binding
open Hub.Utils

/// `GLUTINUM_CLI` points to the `cli.js` of a checkout, else the package of the root `package.json`
let cli () =
    match Environment.GetEnvironmentVariable "GLUTINUM_CLI" with
    | null
    | "" ->
        let installed =
            Path.Combine(Workspace.root, "node_modules", "@glutinum", "cli", "cli.js")

        if File.Exists installed then
            installed
        else
            failwith
                "The Glutinum CLI is not installed, run `pnpm install` or set GLUTINUM_CLI to the cli.js of a checkout"
    | cli -> Path.GetFullPath cli

/// The version pinned in the `package.json` of the binding
let pinnedVersion (binding: Binding) =
    use document = JsonDocument.Parse(File.ReadAllText binding.PackageJson)

    document.RootElement
        .GetProperty("devDependencies")
        .GetProperty(binding.Config.Package)
        .GetString()

/// The npm package a consumer installs and the version the tests run against, a types-only
/// package has none
let npmDependency (binding: Binding) =
    let runtime = runtimeName binding.Config.Package
    use document = JsonDocument.Parse(File.ReadAllText binding.PackageJson)

    match document.RootElement.GetProperty("devDependencies").TryGetProperty runtime with
    | true, version -> Some(runtime, version.GetString())
    | _ -> None

/// The bindings of the hub a binding references
let externalsOf (bindings: Binding list) (binding: Binding) =
    binding.Config.Externals
    |> List.map (fun name ->
        bindings
        |> List.tryFind (fun other -> other.Name = name)
        |> Option.defaultWith (fun () ->
            failwithf "%s references the binding %s which is not in the hub" binding.Name name
        )
    )

/// Glutinum asks for the packages a generated file needs with a comment above the opens
let private neededPackages (content: string) =
    Regex.Matches(
        content,
        @"^// You need to add (\S+) NuGet package to your project\r?$",
        RegexOptions.Multiline
    )
    |> Seq.map (fun m -> m.Groups[1].Value)
    |> Seq.distinct
    |> Seq.sort
    |> List.ofSeq

/// Rewrite the project file from binding.json and the generated code
let writeProject (bindings: Binding list) (binding: Binding) =
    let content = File.ReadAllText binding.GeneratedFile

    // A binding of the hub is referenced as a project, not as a package
    let packages =
        neededPackages content
        |> List.filter (fun name -> bindings |> List.forall (fun other -> other.Name <> name))

    let project =
        Templates.project
            binding
            (npmDependency binding)
            packages
            (externalsOf bindings binding)
            (File.Exists binding.ExtensionsFile)

    File.WriteAllText(binding.ProjectFile, project)

let generate (bindings: Binding list) (binding: Binding) =
    let args =
        CmdLine.empty
        |> CmdLine.appendRaw "--stack-size=8000"
        |> CmdLine.appendRaw (cli ())
        |> CmdLine.appendSeq binding.Config.Inputs

    let args =
        externalsOf bindings binding
        |> List.fold
            (fun args external ->
                args
                |> CmdLine.appendPrefix
                    "--external"
                    $"{external.Config.Package}={external.ModuleName}"
            )
            args

    let args =
        match binding.Config.MaxOverloads with
        | Some maxOverloads -> args |> CmdLine.appendPrefix "--max-overloads" (string maxOverloads)
        | None -> args

    // The CLI wants `--out-file` last
    let args = args |> CmdLine.appendPrefix "--out-file" (binding.Name + ".fs")

    Shell.run "node" args binding.Dir
    writeProject bindings binding
