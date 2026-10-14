module Glutinum.CodemirrorState.Tests.Main

open Fable.Core
open Scriptorium.Nib.Assertion
open Glutinum
open Glutinum.CodemirrorState

open type Scriptorium.Quill.Runner
open type Scriptorium.Quill.Test

type Helpers = CodemirrorState.Exports

let private insert (from: float) (text: string) =
    ChangeSpec.Cases.Case1.Create(from, insert = text)

let private stateOf (doc: string) =
    EditorState.create (EditorStateConfig.Create(doc = doc))

[<EntryPoint>]
let main _ =
    runTests
        [
            testList (
                "Glutinum.CodemirrorState",
                [
                    test (
                        "Text.of splits the document in lines",
                        fun _ ->
                            let text = Text.``of`` (ResizeArray [ "one"; "two" ])

                            assertThat text.lines (isEqualTo 2.)
                            assertThat text.length (isEqualTo 7.)
                            assertThat (text.line(2.).text) (isEqualTo "two")
                            assertThat (text.sliceString (2., 5.)) (isEqualTo "e\nt")
                    )

                    test (
                        "a ChangeSet applies to a document of its length",
                        fun _ ->
                            let doc = Text.``of`` (ResizeArray [ "abc" ])
                            let changes = ChangeSet.``of`` (insert 1 "X", doc.length)

                            assertThat (changes.apply(doc).toString ()) (isEqualTo "aXbc")
                            assertThat changes.newLength (isEqualTo 4.)
                    )

                    test (
                        "EditorState.create reads the document and the selection",
                        fun _ ->
                            let state =
                                EditorState.create (
                                    EditorStateConfig.Create(
                                        doc = "hello world",
                                        selection = EditorSelection.single (6., 11.)
                                    )
                                )

                            let main = state.selection.main

                            assertThat state.doc.length (isEqualTo 11.)
                            assertThat (state.sliceDoc (main.from, main.``to``)) (isEqualTo "world")
                    )

                    test (
                        "EditorSelection.create sorts the ranges and keeps the main one",
                        fun _ ->
                            let selection =
                                EditorSelection.create (
                                    ResizeArray
                                        [
                                            EditorSelection.range (6., 11.)
                                            EditorSelection.cursor 2.
                                        ],
                                    0.
                                )

                            assertThat selection.ranges.length (isEqualTo 2.)
                            assertThat selection.ranges.[0].empty (isTrue)
                            assertThat selection.main.from (isEqualTo 6.)
                            assertThat selection.mainIndex (isEqualTo 1.)
                    )

                    test (
                        "a transaction changes the document",
                        fun _ ->
                            let state = stateOf "hello"

                            let transaction =
                                state.update (TransactionSpec.Create(changes = insert 5. "!"))

                            assertThat transaction.docChanged (isTrue)
                            assertThat (transaction.state.doc.toString ()) (isEqualTo "hello!")
                            assertThat (state.doc.toString ()) (isEqualTo "hello")
                    )

                    test (
                        "replaceSelection replaces the selected range",
                        fun _ ->
                            let state =
                                EditorState.create (
                                    EditorStateConfig.Create(
                                        doc = "hello world",
                                        selection = EditorSelection.single (0., 5.)
                                    )
                                )

                            let next = state.update(state.replaceSelection "goodbye").state

                            assertThat (next.doc.toString ()) (isEqualTo "goodbye world")
                    )

                    test (
                        "a StateField counts the document changes",
                        fun _ ->
                            let changeCount =
                                StateField.define (
                                    StateFieldSpec.Create(
                                        create = (fun _ -> 0.),
                                        update =
                                            fun count (transaction: Transaction) ->
                                                if transaction.docChanged then
                                                    count + 1.
                                                else
                                                    count
                                    )
                                )

                            let state =
                                EditorState.create (
                                    EditorStateConfig.Create(
                                        doc = "",
                                        extensions = changeCount.extension
                                    )
                                )

                            let next =
                                state
                                    .update(TransactionSpec.Create(changes = insert 0. "a"))
                                    .state.update(TransactionSpec.Create(changes = insert 1. "b"))
                                    .state

                            assertThat (next.field changeCount) (isEqualTo 2.)
                    )

                    test (
                        "a Facet combines the values of its extensions",
                        fun _ ->
                            let total =
                                Facet<_, _>
                                    .define (
                                        FacetConfig.Create(combine = fun values -> Seq.sum values)
                                    )

                            let extensions = ResizeArray [ total.``of`` 1.; total.``of`` 2. ]

                            let state =
                                EditorState.create (
                                    EditorStateConfig.Create(extensions = extensions)
                                )

                            assertThat (state.facet total) (isEqualTo 3.)
                    )

                    test (
                        "countColumn expands the tabs",
                        fun _ -> assertThat (Helpers.countColumn ("\tab", 4.)) (isEqualTo 6.)
                    )
                ]
            )
        ]
