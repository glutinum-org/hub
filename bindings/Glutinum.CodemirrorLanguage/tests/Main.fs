module Glutinum.CodemirrorLanguage.Tests.Main

open Fable.Core.JsInterop
open Scriptorium.Nib.Assertion
open Glutinum
open Glutinum.CodemirrorLanguage
open Glutinum.CodemirrorState

open type Scriptorium.Quill.Runner
open type Scriptorium.Quill.Test

type Helpers = CodemirrorLanguage.Exports

let private tags = LezerHighlight.Exports.tags

let private tagStyle (tag: LezerHighlight.Tag) (color: string) =
    let style = TagStyle.Create(tag = tag)
    style.["color"] <- color
    style

let private highlightStyle =
    HighlightStyle.define (
        ResizeArray
            [
                tagStyle tags.keyword "var(--syntax-keyword)"
                tagStyle tags.``string`` "var(--syntax-string)"
                tagStyle (tags.standard tags.variableName) "var(--syntax-type)"
            ]
    )

let private fSharpMode: StreamParser<obj> =
    import "fSharp" "@codemirror/legacy-modes/mode/mllike"

let private fSharpLanguage = StreamLanguage.define fSharpMode

let private stateWith (extension: Extension) =
    EditorState.create (EditorStateConfig.Create(doc = "let x = 1", extensions = extension))

[<EntryPoint>]
let main _ =
    runTests
        [
            testList (
                "Glutinum.CodemirrorLanguage",
                [
                    test (
                        "HighlightStyle.define keeps the tag styles",
                        fun _ ->
                            assertThat highlightStyle.specs.length (isEqualTo 3.)

                            assertThat
                                (highlightStyle.style (ResizeArray [ tags.keyword ])).IsSome
                                (isTrue)

                            assertThat
                                (highlightStyle.style (ResizeArray [ tags.number ]))
                                (isEqualTo None)
                    )

                    test (
                        "syntaxHighlighting installs the highlight style",
                        fun _ ->
                            let state = stateWith (Helpers.syntaxHighlighting highlightStyle)

                            assertThat
                                (Helpers.highlightingFor (state, ResizeArray [ tags.keyword ]))
                                (isEqualTo (highlightStyle.style (ResizeArray [ tags.keyword ])))
                    )

                    test (
                        "StreamLanguage parses the document with a CodeMirror 5 mode",
                        fun _ ->
                            let state = stateWith fSharpLanguage.extension

                            let tree =
                                (Helpers.ensureSyntaxTree (state, state.doc.length, 1000.)).Value

                            let spans = ResizeArray()

                            LezerHighlight.Exports.highlightTree (
                                tree,
                                LezerHighlight.Exports.classHighlighter,
                                fun from ``to`` classes -> spans.Add $"{from}-{``to``}:{classes}"
                            )

                            assertThat (fSharpLanguage.isActiveAt (state, 0.)) (isTrue)
                            assertThat tree.length (isEqualTo 9.)
                            assertThat (spans.Contains "0-3:tok-keyword") (isTrue)
                            assertThat (spans.Contains "8-9:tok-number") (isTrue)
                    )

                    test (
                        "indentUnit sets the indentation of the state",
                        fun _ ->
                            let state = stateWith (Helpers.indentUnit.``of`` "    ")

                            assertThat (Helpers.getIndentUnit state) (isEqualTo 4.)
                            assertThat (Helpers.indentString (state, 6.)) (isEqualTo "      ")
                    )

                    test (
                        "a state without a language has an empty syntax tree",
                        fun _ ->
                            let tree =
                                Helpers.syntaxTree (stateWith (Helpers.indentUnit.``of`` "  "))

                            assertThat tree.length (isEqualTo 0.)
                    )

                    test (
                        "LanguageDescription.matchFilename finds a language by extension",
                        fun _ ->
                            let fsharp =
                                LanguageDescription.``of`` (
                                    LanguageDescription.of__.spec.Create(
                                        name = "F#",
                                        extensions = ResizeArray [ "fs"; "fsx" ],
                                        load = fun () -> failwith "not loaded by this test"
                                    )
                                )

                            let descriptions = ResizeArray [ fsharp ]

                            assertThat
                                (LanguageDescription
                                    .matchFilename(descriptions, "Main.fs")
                                    .Value.name)
                                (isEqualTo "F#")

                            assertThat
                                (LanguageDescription.matchFilename (descriptions, "Main.ts"))
                                (isEqualTo None)
                    )
                ]
            )
        ]
