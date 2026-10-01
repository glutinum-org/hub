module Hub.Binding

open System
open System.IO
open System.Text.Json
open System.Text.Json.Serialization

[<RequireQualifiedAccess>]
type Tests =
    | Node
    | Browser

    member this.Text =
        match this with
        | Node -> "node"
        | Browser -> "browser"

    static member Parse(text: string) =
        match text with
        | "node" -> Node
        | "browser" -> Browser
        | _ -> failwithf "Unknown test kind '%s', expected 'node' or 'browser'" text

/// `binding.json`, the source of truth of a binding
type Config =
    {
        /// The npm package the binding is generated from
        Package: string
        /// A line of the README and of the NuGet package
        Description: string
        /// The inputs given to Glutinum: the package and its subpaths
        Inputs: string list
        /// Bindings of the hub referenced instead of generated, by name
        Externals: string list
        Tests: Tests option
        /// The overloads a signature gets at most from its union parameters, the CLI default when absent
        MaxOverloads: int option
    }

type Binding =
    {
        /// `Glutinum.DateFns`, the NuGet package id and the directory
        Name: string
        Dir: string
        Config: Config
    }

    /// `DateFns`, the module under `Glutinum`
    member this.ModuleName = this.Name.Substring("Glutinum.".Length)

    member this.ConfigFile = Path.Combine(this.Dir, "binding.json")
    member this.ProjectFile = Path.Combine(this.Dir, this.Name + ".fsproj")
    member this.GeneratedFile = Path.Combine(this.Dir, this.Name + ".fs")
    /// Hand-written helpers shipped with the binding, compiled after the generated file
    member this.ExtensionsFile = Path.Combine(this.Dir, this.Name + ".Extensions.fs")
    member this.PackageJson = Path.Combine(this.Dir, "package.json")
    member this.Changelog = Path.Combine(this.Dir, "CHANGELOG.md")
    member this.TestsDir = Path.Combine(this.Dir, "tests")
    member this.HasTests = Directory.Exists this.TestsDir

/// The module Glutinum derives from a package name, `date-fns` gives `DateFns`
let moduleNameForPackage (packageName: string) =
    packageName.Split([| '@'; '/'; '-'; '.'; '_' |], StringSplitOptions.RemoveEmptyEntries)
    |> Array.map (fun part -> string (Char.ToUpper part.[0]) + part.Substring(1))
    |> String.concat ""

/// The runtime name of `@types/leaflet` is `leaflet`
let runtimeName (packageName: string) =
    if packageName.StartsWith "@types/" then
        packageName.Substring("@types/".Length)
    else
        packageName

type ConfigDto() =
    member val package: string = "" with get, set
    member val description: string = "" with get, set
    member val inputs: string array = [||] with get, set
    member val externals: string array = [||] with get, set
    member val tests: string = null with get, set
    member val maxOverloads: Nullable<int> = Nullable() with get, set

let private jsonOptions =
    JsonSerializerOptions(
        WriteIndented = true,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
    )

let private toDto (config: Config) =
    ConfigDto(
        package = config.Package,
        description = config.Description,
        inputs = List.toArray config.Inputs,
        externals = List.toArray config.Externals,
        tests =
            (match config.Tests with
             | Some tests -> tests.Text
             | None -> null),
        maxOverloads = Option.toNullable config.MaxOverloads
    )

let private ofDto (dto: ConfigDto) : Config =
    {
        Package = dto.package
        Description = dto.description
        Inputs = Array.toList dto.inputs
        Externals = Array.toList dto.externals
        Tests = dto.tests |> Option.ofObj |> Option.map Tests.Parse
        MaxOverloads = Option.ofNullable dto.maxOverloads
    }

let save (binding: Binding) =
    File.WriteAllText(
        binding.ConfigFile,
        JsonSerializer.Serialize(toDto binding.Config, jsonOptions) + "\n"
    )

let load (dir: string) : Binding =
    let configFile = Path.Combine(dir, "binding.json")

    if not (File.Exists configFile) then
        failwithf "%s is not a binding, it has no binding.json" dir

    let dto =
        JsonSerializer.Deserialize<ConfigDto>(File.ReadAllText configFile, jsonOptions)

    {
        Name = Path.GetFileName dir
        Dir = dir
        Config = ofDto dto
    }

let all () : Binding list =
    if Directory.Exists Workspace.bindingsDir then
        Directory.GetDirectories Workspace.bindingsDir
        |> Array.filter (fun dir -> File.Exists(Path.Combine(dir, "binding.json")))
        |> Array.sort
        |> Array.toList
        |> List.map load
    else
        []

/// `DateFns`, `Glutinum.DateFns` and `date-fns` name the same binding
let find (name: string) : Binding =
    let bindings = all ()

    bindings
    |> List.tryFind (fun binding ->
        binding.Name = name
        || binding.ModuleName = name
        || binding.Config.Package = name
        || Workspace.relative binding.Dir = name.TrimEnd('/')
    )
    |> Option.defaultWith (fun () ->
        failwithf
            "No binding named '%s', the bindings are: %s"
            name
            (bindings |> List.map _.Name |> String.concat ", ")
    )

/// The bindings a binding references, first
let dependencyOrder (bindings: Binding list) : Binding list =
    let byName =
        bindings |> List.map (fun binding -> binding.Name, binding) |> Map.ofList

    let ordered = Collections.Generic.List<Binding>()
    let visiting = Collections.Generic.HashSet<string>()

    let rec visit (binding: Binding) =
        if not (ordered.Exists(fun other -> other.Name = binding.Name)) then
            if not (visiting.Add binding.Name) then
                failwithf "The bindings reference each other in a cycle through %s" binding.Name

            for external in binding.Config.Externals do
                match Map.tryFind external byName with
                | Some dependency -> visit dependency
                | None -> ()

            ordered.Add binding

    bindings |> List.iter visit
    List.ofSeq ordered

/// The bindings referencing one of `names`, transitively
let dependents (bindings: Binding list) (names: Set<string>) : Set<string> =
    let rec grow (names: Set<string>) =
        let next =
            bindings
            |> List.filter (fun binding -> binding.Config.Externals |> List.exists names.Contains)
            |> List.map _.Name
            |> Set.ofList
            |> Set.union names

        if next = names then
            names
        else
            grow next

    grow names

/// The bindings touched since the base branch, and the ones referencing them; every binding when the tooling changed
let changed (bindings: Binding list) : Binding list =
    let baseRef =
        match Environment.GetEnvironmentVariable "GITHUB_BASE_REF" with
        | null
        | "" -> "origin/main"
        | baseRef -> "origin/" + baseRef

    let output: string =
        Utils.Shell.read
            "git"
            (BlackFox.CommandLine.CmdLine.empty
             |> BlackFox.CommandLine.CmdLine.appendRaw "diff"
             |> BlackFox.CommandLine.CmdLine.appendRaw "--name-only"
             |> BlackFox.CommandLine.CmdLine.appendRaw (baseRef + "...HEAD"))
            Workspace.root

    let files =
        output.Split('\n', StringSplitOptions.RemoveEmptyEntries) |> Array.toList

    let toolingChanged =
        files |> List.exists (fun (file: string) -> not (file.StartsWith "bindings/"))

    if toolingChanged then
        bindings
    else
        let touched =
            bindings
            |> List.filter (fun binding ->
                let prefix = Workspace.relative binding.Dir + "/"
                files |> List.exists (fun (file: string) -> file.StartsWith prefix)
            )
            |> List.map _.Name
            |> Set.ofList

        let names = dependents bindings touched

        bindings |> List.filter (fun binding -> names.Contains binding.Name)
