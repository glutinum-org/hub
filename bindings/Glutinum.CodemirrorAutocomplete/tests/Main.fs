module Glutinum.CodemirrorAutocomplete.Tests.Main

open Fable.Core
open Scriptorium.Nib.Assertion
open Glutinum
open Glutinum.CodemirrorAutocomplete
open Glutinum.CodemirrorState
open Glutinum.Types.UnionCases

open type Scriptorium.Quill.Runner
open type Scriptorium.Quill.Test

type Autocomplete = CodemirrorAutocomplete.Exports

let private stateOf (doc: string) (extensions: ResizeArray<Extension>) =
    EditorState.create (
        EditorStateConfig.Create(
            doc = doc,
            selection = EditorSelection.single doc.Length,
            extensions = extensions
        )
    )

let private contextAtEnd (state: EditorState) =
    Autocomplete.CompletionContext(state, state.doc.length, true)

let private keywords =
    Autocomplete.completeFromList (
        ResizeArray
            [
                U2.Case1 "let"
                U2.Case2(Completion.Create(label = "match", ``type`` = "keyword", detail = "with"))
            ]
    )

[<EntryPoint>]
let main _ =
    runTests
        [
            testList (
                "Glutinum.CodemirrorAutocomplete",
                [
                    test (
                        "matchBefore reads the word before the cursor",
                        fun _ ->
                            let context = contextAtEnd (stateOf "let ma" (ResizeArray []))
                            let word = (context.matchBefore (RegExp @"\w*")).Value

                            assertThat word.text (isEqualTo "ma")
                            assertThat word.from (isEqualTo 4.)
                    )

                    test (
                        "completeFromList completes from the start of the word",
                        fun _ ->
                            let context = contextAtEnd (stateOf "let ma" (ResizeArray []))
                            let result = (keywords context).Value.AsCase1
                            let labels = result.options |> Seq.map (fun option -> option.label)

                            assertThat result.from (isEqualTo 4.)
                            assertThat (List.ofSeq labels) (isEqualTo [ "let"; "match" ])
                            assertThat result.options.[1].detail (isEqualTo (Some "with"))
                    )

                    test (
                        "a CompletionSource written in F# gives a CompletionResult",
                        fun _ ->
                            let source: CompletionSource =
                                fun context ->
                                    context.matchBefore (RegExp @"\w+")
                                    |> Option.map (fun word ->
                                        U2.Case1(
                                            CompletionResult.Create(
                                                from = word.from,
                                                options =
                                                    ResizeArray
                                                        [
                                                            Completion.Create(
                                                                label = word.text + "!"
                                                            )
                                                        ]
                                            )
                                        )
                                    )

                            let context = contextAtEnd (stateOf "let ma" (ResizeArray []))

                            assertThat
                                (source context).Value.AsCase1.options.[0].label
                                (isEqualTo "ma!")

                            let empty = contextAtEnd (stateOf "let " (ResizeArray []))

                            assertThat (source empty) (isEqualTo None)
                    )

                    test (
                        "insertCompletionText replaces the word",
                        fun _ ->
                            let state = stateOf "let ma" (ResizeArray [])
                            let spec = Autocomplete.insertCompletionText (state, "match", 4., 6.)
                            let next = state.update(spec).state

                            assertThat (next.doc.toString ()) (isEqualTo "let match")
                            assertThat next.selection.main.head (isEqualTo 9.)
                    )

                    test (
                        "snippet inserts the template and selects the first field",
                        fun _ ->
                            let mutable state = stateOf "" (ResizeArray [])

                            let editor =
                                Exports.snippet__.editor.Create(
                                    state = state,
                                    dispatch = fun transaction -> state <- transaction.state
                                )

                            let apply = Autocomplete.snippet "match ${value} with"
                            apply.Invoke(editor, None, 0., 0.)

                            let main = state.selection.main

                            assertThat (state.doc.toString ()) (isEqualTo "match value with")
                            assertThat (state.sliceDoc (main.from, main.``to``)) (isEqualTo "value")
                    )

                    test (
                        "insertBracket closes the bracket with closeBrackets",
                        fun _ ->
                            let state = stateOf "" (ResizeArray [ Autocomplete.closeBrackets () ])
                            let next = (Autocomplete.insertBracket (state, "(")).Value.state

                            assertThat (next.doc.toString ()) (isEqualTo "()")
                            assertThat next.selection.main.head (isEqualTo 1.)
                    )

                    test (
                        "autocompletion starts without completions",
                        fun _ ->
                            let config =
                                CompletionConfig.Create(``override`` = ResizeArray [ keywords ])

                            let state =
                                stateOf "let" (ResizeArray [ Autocomplete.autocompletion config ])

                            assertThat (Autocomplete.currentCompletions state).length (isEqualTo 0.)
                            assertThat (Autocomplete.selectedCompletion state) (isEqualTo None)
                    )
                ]
            )
        ]
