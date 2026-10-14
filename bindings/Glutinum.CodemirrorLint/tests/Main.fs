module Glutinum.CodemirrorLint.Tests.Main

open Scriptorium.Nib.Assertion
open Glutinum
open Glutinum.CodemirrorLint
open Glutinum.CodemirrorState

open type Scriptorium.Quill.Runner
open type Scriptorium.Quill.Test

type Lint = CodemirrorLint.Exports

let private stateOf (extensions: ResizeArray<Extension>) =
    EditorState.create (EditorStateConfig.Create(doc = "let x = 1", extensions = extensions))

let private diagnostics =
    ResizeArray
        [
            Diagnostic.Create(
                from = 4.,
                ``to`` = 5.,
                severity = Severity.warning,
                message = "unused value",
                source = "fsharp"
            )
            Diagnostic.Create(
                from = 8.,
                ``to`` = 9.,
                severity = Severity.error,
                message = "type error"
            )
        ]

let private withDiagnostics (state: EditorState) =
    state.update(Lint.setDiagnostics (state, diagnostics)).state

let private collect (state: EditorState) =
    let found = ResizeArray()

    Lint.forEachDiagnostic (
        state,
        fun diagnostic from ``to`` ->
            found.Add $"{from}-{``to``} {diagnostic.severity}: {diagnostic.message}"
    )

    List.ofSeq found

[<EntryPoint>]
let main _ =
    runTests
        [
            testList (
                "Glutinum.CodemirrorLint",
                [
                    test (
                        "a state without diagnostics counts none",
                        fun _ ->
                            assertThat
                                (Lint.diagnosticCount (stateOf (ResizeArray [])))
                                (isEqualTo 0.)
                    )

                    test (
                        "setDiagnostics stores the diagnostics in the state",
                        fun _ ->
                            let state = withDiagnostics (stateOf (ResizeArray []))

                            assertThat (Lint.diagnosticCount state) (isEqualTo 2.)
                    )

                    test (
                        "forEachDiagnostic gives the diagnostics with their range",
                        fun _ ->
                            assertThat
                                (collect (withDiagnostics (stateOf (ResizeArray []))))
                                (isEqualTo [ "4-5 warning: unused value"; "8-9 error: type error" ])
                    )

                    test (
                        "the diagnostics follow the changes of the document",
                        fun _ ->
                            let state = withDiagnostics (stateOf (ResizeArray []))

                            let next =
                                state
                                    .update(
                                        TransactionSpec.Create(
                                            changes =
                                                ChangeSpec.Cases.Case1.Create(
                                                    from = 0.,
                                                    insert = "  "
                                                )
                                        )
                                    )
                                    .state

                            assertThat
                                (collect next)
                                (isEqualTo
                                    [ "6-7 warning: unused value"; "10-11 error: type error" ])
                    )

                    test (
                        "linter and lintGutter are extensions of the state",
                        fun _ ->
                            let state =
                                stateOf (
                                    ResizeArray
                                        [
                                            Lint.linter (None, LintConfig.Create(delay = 100.))
                                            Lint.lintGutter ()
                                        ]
                                )

                            assertThat (Lint.diagnosticCount (withDiagnostics state)) (isEqualTo 2.)
                    )

                    test (
                        "lintKeymap opens the panel with Mod-Shift-m",
                        fun _ ->
                            let keys = Lint.lintKeymap |> Seq.choose (fun binding -> binding.key)

                            assertThat (Seq.contains "Mod-Shift-m" keys) (isTrue)
                    )
                ]
            )
        ]
