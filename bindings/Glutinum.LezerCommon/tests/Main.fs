module Glutinum.LezerCommon.Tests.Main

open Fable.Core
open Scriptorium.Nib.Assertion
open Glutinum
open Glutinum.LezerCommon

open type Scriptorium.Quill.Runner
open type Scriptorium.Quill.Test

type Lezer = LezerCommon.Exports

let private document =
    NodeType.define (NodeType.define__.spec.Create(id = 0., name = "Document", top = true))

let private word =
    NodeType.define (NodeType.define__.spec.Create(id = 1., name = "Word"))

let private nodeSet = Lezer.NodeSet(ResizeArray [ document; word ])

/// "one two" with a `Word` node on each word
let private tree =
    Lezer.Tree(
        document,
        ResizeArray
            [
                U2.Case1(Lezer.Tree(word, ResizeArray(), ResizeArray(), 3.))
                U2.Case1(Lezer.Tree(word, ResizeArray(), ResizeArray(), 3.))
            ],
        ResizeArray [ 0.; 4. ],
        7.
    )

[<EntryPoint>]
let main _ =
    runTests
        [
            testList (
                "Glutinum.LezerCommon",
                [
                    test (
                        "NodeType.define names the node type",
                        fun _ ->
                            assertThat document.name (isEqualTo "Document")
                            assertThat document.isTop (isTrue)
                            assertThat (word.is "Word") (isTrue)
                            assertThat nodeSet.types.length (isEqualTo 2)
                    )

                    test (
                        "the top node spans the tree",
                        fun _ ->
                            let top = tree.topNode

                            assertThat top.name (isEqualTo "Document")
                            assertThat top.``to`` (isEqualTo 7.)
                            assertThat top.firstChild.Value.``to`` (isEqualTo 3.)
                            assertThat top.lastChild.Value.from (isEqualTo 4.)
                    )

                    test (
                        "resolve finds the innermost node at a position",
                        fun _ ->
                            let node = tree.resolve (5., Tree.resolve.side.``1``)

                            assertThat node.name (isEqualTo "Word")
                            assertThat node.from (isEqualTo 4.)
                    )

                    test (
                        "iterate visits every node in order",
                        fun _ ->
                            let names = ResizeArray()

                            tree.iterate (
                                Tree.iterate.spec.Create(
                                    enter =
                                        fun node ->
                                            names.Add $"{node.name}@{node.from}"
                                            U2.Case2()
                                )
                            )

                            assertThat
                                (List.ofSeq names)
                                (isEqualTo [ "Document@0"; "Word@0"; "Word@4" ])
                    )

                    test (
                        "a cursor moves through the children",
                        fun _ ->
                            let cursor = tree.cursor ()

                            assertThat (cursor.firstChild ()) (isTrue)
                            assertThat cursor.``to`` (isEqualTo 3.)
                            assertThat (cursor.nextSibling ()) (isTrue)
                            assertThat cursor.from (isEqualTo 4.)
                            assertThat (cursor.nextSibling ()) (isFalse)
                    )
                ]
            )
        ]
