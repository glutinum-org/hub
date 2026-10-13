module Glutinum.LezerHighlight.Tests.Main

open Fable.Core
open Fable.Core.JsInterop
open Scriptorium.Nib.Assertion
open Glutinum
open Glutinum.LezerCommon
open Glutinum.LezerHighlight

open type Scriptorium.Quill.Runner
open type Scriptorium.Quill.Test

type Highlight = LezerHighlight.Exports
type Lezer = LezerCommon.Exports

let private tags = Highlight.tags

let private styles =
    let spec = createEmpty<Exports.styleTags__.spec>
    spec.["Keyword"] <- tags.keyword
    spec.["Name"] <- tags.standard tags.variableName
    Highlight.styleTags spec

let private nodeType (id: float) (name: string) =
    NodeType.define (
        NodeType.define__.spec.Create(
            id = id,
            name = name,
            top = (id = 0.),
            props = ResizeArray [ U2.Case2 styles ]
        )
    )

/// "let x" with a `Keyword` node and a `Name` node
let private tree =
    let leaf (node: NodeType) (length: float) =
        U2.Case1(Lezer.Tree(node, ResizeArray(), ResizeArray(), length))

    Lezer.Tree(
        nodeType 0. "Document",
        ResizeArray [ leaf (nodeType 1. "Keyword") 3.; leaf (nodeType 2. "Name") 1. ],
        ResizeArray [ 0.; 4. ],
        5.
    )

let private highlighted (highlighter: Highlighter) =
    let spans = ResizeArray()

    Highlight.highlightTree (
        tree,
        highlighter,
        fun from ``to`` classes -> spans.Add $"{from}-{``to``}:{classes}"
    )

    List.ofSeq spans

[<EntryPoint>]
let main _ =
    runTests
        [
            testList (
                "Glutinum.LezerHighlight",
                [
                    test (
                        "a modifier derives a tag from its base",
                        fun _ ->
                            let standardName = tags.standard tags.variableName

                            assertThat (standardName = tags.variableName) (isFalse)
                            assertThat (standardName.set.Contains tags.variableName) (isTrue)
                    )

                    test (
                        "Tag.define creates a sub tag",
                        fun _ ->
                            let important = Tag.define ("important", tags.keyword)

                            assertThat (important.set.Contains tags.keyword) (isTrue)
                    )

                    test (
                        "classHighlighter gives the tok- classes",
                        fun _ ->
                            assertThat
                                (Highlight.classHighlighter.style (ResizeArray [ tags.keyword ]))
                                (isEqualTo (Some "tok-keyword"))
                    )

                    test (
                        "tagHighlighter maps tags to classes",
                        fun _ ->
                            let highlighter =
                                Highlight.tagHighlighter (
                                    ResizeArray
                                        [
                                            Exports.tagHighlighter__.tags.Item.Create(
                                                tag = tags.keyword,
                                                ``class`` = "kw"
                                            )
                                            Exports.tagHighlighter__.tags.Item.Create(
                                                tag = tags.variableName,
                                                ``class`` = "var"
                                            )
                                        ]
                                )

                            assertThat
                                (highlighter.style (ResizeArray [ tags.keyword ]))
                                (isEqualTo (Some "kw"))

                            assertThat
                                (highlighter.style (ResizeArray [ tags.number ]))
                                (isEqualTo None)
                    )

                    test (
                        "highlightTree styles the nodes tagged by styleTags",
                        fun _ ->
                            assertThat
                                (highlighted Highlight.classHighlighter)
                                (isEqualTo [ "0-3:tok-keyword"; "4-5:tok-variableName" ])
                    )
                ]
            )
        ]
