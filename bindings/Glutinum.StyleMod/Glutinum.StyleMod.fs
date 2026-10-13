namespace rec Glutinum

open Fable.Core
open Fable.Core.JsInterop
open System

// You need to add Glutinum.Web NuGet package to your project

module StyleMod =

    [<AbstractClass>]
    [<Erase>]
    type Exports =
        [<Import("StyleModule", "style-mod"); EmitConstructor>]
        static member StyleModule (spec: Exports.StyleModule.spec, ?options: Exports.StyleModule.options) : StyleModule = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("StyleModule", "style-mod")>]
    type StyleModule =
        abstract member getRules: unit -> string
        [<Emit("""import { StyleModule } from "style-mod";
StyleModule.mount($0, $1, $2)""")>]
        static member inline mount (root: Glutinum.Web.Document, ``module``: StyleMod.StyleModule, ?options: StyleModule.mount__.options): unit = nativeOnly
        [<Emit("""import { StyleModule } from "style-mod";
StyleModule.mount($0, $1, $2)""")>]
        static member inline mount (root: Glutinum.Web.Document, ``module``: ResizeArray<StyleMod.StyleModule>, ?options: StyleModule.mount__.options): unit = nativeOnly
        [<Emit("""import { StyleModule } from "style-mod";
StyleModule.mount($0, $1, $2)""")>]
        static member inline mount (root: Glutinum.Web.ShadowRoot, ``module``: StyleMod.StyleModule, ?options: StyleModule.mount__.options): unit = nativeOnly
        [<Emit("""import { StyleModule } from "style-mod";
StyleModule.mount($0, $1, $2)""")>]
        static member inline mount (root: Glutinum.Web.ShadowRoot, ``module``: ResizeArray<StyleMod.StyleModule>, ?options: StyleModule.mount__.options): unit = nativeOnly
        [<Emit("""import { StyleModule } from "style-mod";
StyleModule.mount($0, $1, $2)""")>]
        static member inline mount (root: Glutinum.Web.DocumentOrShadowRoot, ``module``: StyleMod.StyleModule, ?options: StyleModule.mount__.options): unit = nativeOnly
        [<Emit("""import { StyleModule } from "style-mod";
StyleModule.mount($0, $1, $2)""")>]
        static member inline mount (root: Glutinum.Web.DocumentOrShadowRoot, ``module``: ResizeArray<StyleMod.StyleModule>, ?options: StyleModule.mount__.options): unit = nativeOnly
        [<Emit("""import { StyleModule } from "style-mod";
StyleModule.newName()""")>]
        static member inline newName () : string = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type StyleSpec =
        [<EmitIndexer>]
        abstract member Item: propOrSelector: string -> U3<string, float, StyleMod.StyleSpec> option with get, set

    module StyleModule =

        module mount__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member nonce: string option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?nonce: string) : options = nativeOnly

    module Exports =

        module StyleModule =

            [<AllowNullLiteral>]
            [<Interface>]
            type spec =
                [<EmitIndexer>]
                abstract member Item: selector: string -> StyleMod.StyleSpec with get, set

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member finish: (string -> string) option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?finish: (string -> string)) : options = nativeOnly
