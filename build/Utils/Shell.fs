module Hub.Utils.Shell

open SimpleExec
open BlackFox.CommandLine

let run (name: string) (args: CmdLine) (workingDirectory: string) =
    Command.Run(name, CmdLine.toString args, workingDirectory = workingDirectory)

let read (name: string) (args: CmdLine) (workingDirectory: string) : string =
    let struct (stdout, _) =
        Command.ReadAsync(name, CmdLine.toString args, workingDirectory = workingDirectory)
        |> Async.AwaitTask
        |> Async.RunSynchronously

    stdout.Trim()

let pnpmInstall () =
    Command.Run("pnpm", "install", workingDirectory = Hub.Workspace.root)

let fable (workingDirectory: string) (args: string list) =
    run
        "dotnet"
        (CmdLine.empty
         |> CmdLine.appendRaw "fable"
         |> CmdLine.appendRaw (String.concat " " args))
        workingDirectory
