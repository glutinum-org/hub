module Glutinum.CodemirrorCommands.Tests.Main

open Fable.Core
open Scriptorium.Nib.Assertion
open Glutinum
open Glutinum.CodemirrorState

open type Scriptorium.Quill.Runner
open type Scriptorium.Quill.Test

type Commands = CodemirrorCommands.Exports

let private stateOf (doc: string) (selection: EditorSelection) (extensions: Extension option) =
    EditorState.create (EditorStateConfig.Create(doc, selection, ?extensions = extensions))

let private run (command: StateCommand) (state: EditorState) =
    let mutable next = state

    let handled =
        command (StateCommand.target.Create(state, (fun transaction -> next <- transaction.state)))

    handled, next

[<EntryPoint>]
let main _ =
    runTests
        [
            testList (
                "Glutinum.CodemirrorCommands",
                [
                    test (
                        "selectAll selects the whole document",
                        fun _ ->
                            let handled, state =
                                run
                                    Commands.selectAll
                                    (stateOf "one\ntwo" (EditorSelection.single 0.) None)

                            assertThat handled (isTrue)
                            assertThat state.selection.main.from (isEqualTo 0.)
                            assertThat state.selection.main.``to`` (isEqualTo 7.)
                    )

                    test (
                        "cursorDocEnd moves the cursor to the end of the document",
                        fun _ ->
                            let _, state =
                                run
                                    Commands.cursorDocEnd
                                    (stateOf "one\ntwo" (EditorSelection.single 0.) None)

                            assertThat state.selection.main.head (isEqualTo 7.)
                    )

                    test (
                        "moveLineDown swaps the line with the next one",
                        fun _ ->
                            let _, state =
                                run
                                    Commands.moveLineDown
                                    (stateOf "one\ntwo" (EditorSelection.single 0.) None)

                            assertThat (state.doc.toString ()) (isEqualTo "two\none")
                    )

                    test (
                        "indentMore indents the selected lines",
                        fun _ ->
                            let _, state =
                                run
                                    Commands.indentMore
                                    (stateOf "one\ntwo" (EditorSelection.single (0., 7.)) None)

                            assertThat (state.doc.toString ()) (isEqualTo "  one\n  two")
                    )

                    test (
                        "deleteTrailingWhitespace trims the lines",
                        fun _ ->
                            let _, state =
                                run
                                    Commands.deleteTrailingWhitespace
                                    (stateOf "one  \ntwo\t" (EditorSelection.single 0.) None)

                            assertThat (state.doc.toString ()) (isEqualTo "one\ntwo")
                    )

                    test (
                        "undo reverts a change recorded by the history",
                        fun _ ->
                            let initial =
                                stateOf
                                    "hello"
                                    (EditorSelection.single 5.)
                                    (Some(Commands.history ()))

                            let changed = initial.update(initial.replaceSelection "!").state

                            assertThat (Commands.undoDepth changed) (isEqualTo 1.)

                            let handled, undone = run Commands.undo changed

                            assertThat handled (isTrue)
                            assertThat (undone.doc.toString ()) (isEqualTo "hello")
                            assertThat (Commands.redoDepth undone) (isEqualTo 1.)
                    )

                    test (
                        "undo does nothing without a history",
                        fun _ ->
                            let handled, _ =
                                run Commands.undo (stateOf "hello" (EditorSelection.single 0.) None)

                            assertThat handled (isEqualTo false)
                    )
                ]
            )
        ]
