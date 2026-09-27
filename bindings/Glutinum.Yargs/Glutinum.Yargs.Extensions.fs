namespace Glutinum

open Fable.Core
open Fable.Core.JsInterop
open Glutinum.Yargs

/// Hand-written helpers for the yargs binding
[<AutoOpen>]
module YargsExtensions =

    type yargs_.Arguments<'T> with

        /// The value of a declared option, `parseSync` only types `_` and `$0`
        member inline this.Get<'V>(key: string) : 'V = unbox<'V> this.[key]

        /// The value of a declared option, `None` when it was not given
        member inline this.TryGet<'V>(key: string) : 'V option =
            let value = this.[key]

            if isNull value || jsTypeof value = "undefined" then
                None
            else
                Some(unbox<'V> value)

    type yargs_.Argv<'T> with

        /// A command with a handler and no builder
        member inline this.Command
            (command: string, description: string, handler: yargs_.ArgumentsCamelCase<'T> -> unit)
            : yargs_.Argv<'T>
            =
            this.command (
                command,
                description,
                (fun (_: yargs_.Argv<'T>) -> ()),
                (fun (arguments: yargs_.ArgumentsCamelCase<'T>) ->
                    handler arguments
                    U2.Case1())
            )
