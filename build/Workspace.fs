module Hub.Workspace

open System
open System.IO

// `./build.sh` runs from the root of the repository
let root = Environment.CurrentDirectory

let bindingsDir = Path.Combine(root, "bindings")

let relative (path: string) =
    Path.GetRelativePath(root, path).Replace('\\', '/')
