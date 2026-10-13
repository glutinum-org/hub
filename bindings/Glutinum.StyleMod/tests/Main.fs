module Glutinum.StyleMod.Tests.Main

open Fable.Core
open Fable.Core.JsInterop
open Scriptorium.Nib.Assertion
open Glutinum
open Glutinum.StyleMod

open type Scriptorium.Quill.Runner
open type Scriptorium.Quill.Test

type StyleModExports = StyleMod.Exports

let private styleSpec (properties: (string * U3<string, float, StyleSpec>) list) =
    let spec = createEmpty<StyleSpec>

    for name, value in properties do
        spec.[name] <- Some value

    spec

[<EntryPoint>]
let main _ =
    runTests
        [
            testList (
                "Glutinum.StyleMod",
                [
                    test (
                        "getRules writes the CSS of the module",
                        fun _ ->
                            let spec = createEmpty<Exports.StyleModule.spec>

                            spec.[".title"] <-
                                styleSpec [ "color", U3.Case1 "red"; "fontWeight", U3.Case2 700. ]

                            let styleModule = StyleModExports.StyleModule spec

                            assertThat
                                (styleModule.getRules ())
                                (isEqualTo ".title {color: red; font-weight: 700;}")
                    )

                    test (
                        "a nested selector gets its own rule",
                        fun _ ->
                            let spec = createEmpty<Exports.StyleModule.spec>

                            spec.[".link"] <-
                                styleSpec
                                    [
                                        "color", U3.Case1 "blue"
                                        "&:hover", U3.Case3(styleSpec [ "color", U3.Case1 "navy" ])
                                    ]

                            let rules = (StyleModExports.StyleModule spec).getRules ()

                            assertThat
                                rules
                                (isEqualTo ".link:hover {color: navy;}\n.link {color: blue;}")
                    )

                    test (
                        "newName gives a new class name on each call",
                        fun _ ->
                            let first = StyleModule.newName ()
                            let second = StyleModule.newName ()

                            assertThat (first = second) (isFalse)
                            assertThat (first.StartsWith "ͼ") (isTrue)
                    )
                ]
            )
        ]
