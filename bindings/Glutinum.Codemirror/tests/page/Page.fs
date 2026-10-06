module Glutinum.Codemirror.Tests.Page

open Fable.Core
open Fable.Core.JsInterop
open Glutinum

open type Glutinum.Web.Exports

// The page exercises the binding in a real browser, the tests read the results in the DOM
let private report (id: string) (text: string) =
    let element = document.createElement "p"
    element.id <- id
    element.textContent <- text
    document.body.appendChild element |> ignore

let host = document.createElement Web.HTMLElementTagNameMap.Keys.div
host.id <- "editor"
document.body.appendChild host |> ignore

// The option object is a typed class
let view =
    Codemirror.Exports.EditorView(
        CodemirrorView.EditorViewConfig.Create(
            doc = U2.Case1 "let answer = 42",
            extensions = Codemirror.Exports.basicSetup,
            parent = U2.Case1 host
        )
    )

report "doc" (view.state.doc.toString ())
let mounted = view.dom.classList.contains "cm-editor"
report "dom" $"cm-editor: {mounted}"

// A transaction inserts text at the end of the document
let length = view.state.doc.length

view.dispatch (
    jsOptions<CodemirrorState.TransactionSpec> (fun spec ->
        spec.changes <-
            Some(
                U3.Case1(
                    CodemirrorState.ChangeSpec.U3.Case1.Create(
                        from = length,
                        insert = "\nlet other = 1"
                    )
                )
            )
    )
)

report
    "inserted"
    $"{view.state.doc.lines} lines, last: {view.state.doc.lineAt(view.state.doc.length).text}"

// A state can be created without a view
let state =
    CodemirrorState.EditorState.create (
        CodemirrorState.EditorStateConfig.Create(
            doc = "abc\ndef",
            extensions = Codemirror.Exports.minimalSetup
        )
    )

report
    "state"
    $"{state.doc.lines} lines, {state.doc.sliceString (0, 3)}, selection at {state.selection.main.from}"

view.destroy ()
let stillInPage = host.querySelector ".cm-editor" |> Option.isSome
report "destroyed" $"editor in page: {stillInPage}"
report "loaded" "ok"
