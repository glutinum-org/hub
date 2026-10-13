module Glutinum.CodemirrorView.Tests.Page

open Fable.Core
open Fable.Core.JsInterop
open Glutinum
open Glutinum.CodemirrorView

open type Glutinum.Web.Exports

type View = CodemirrorView.Exports

// The page exercises the binding in a real browser, the tests read the results in the DOM
let private report (id: string) (text: string) =
    let element = document.createElement "p"
    element.id <- id
    element.textContent <- text
    document.body.appendChild element |> ignore

let private mount (doc: string) (extensions: CodemirrorState.Extension) =
    let host = document.createElement Web.HTMLElementTagNameMap.Keys.div
    document.body.appendChild host |> ignore

    View.EditorView(
        EditorViewConfig.Create(doc = doc, extensions = extensions, parent = U2.Case1 host)
    )

let private count (selector: string) =
    document.querySelectorAll(selector).length

let mutable private changes = 0

let private theme =
    let colors = createEmpty<StyleMod.StyleSpec>
    colors.["color"] <- Some(U3.Case1 "rgb(255, 0, 0)")

    let spec = createEmpty<EditorView.theme__.spec>
    spec.[".cm-content"] <- colors
    EditorView.theme spec

let private extensions =
    ResizeArray
        [
            View.lineNumbers ()
            EditorView.updateListener.``of`` (fun update ->
                if update.docChanged then
                    changes <- changes + 1
            )
            theme
        ]

let private view = mount "one\ntwo\nthree" extensions

report "content" view.contentDOM.textContent
let private lineNumbers = count ".cm-lineNumbers .cm-gutterElement"
report "gutter" $"{lineNumbers} line numbers"

view.dispatch (
    CodemirrorState.TransactionSpec.Create(
        changes = CodemirrorState.ChangeSpec.Cases.Case1.Create(from = 0., insert = "zero\n")
    )
)

report "changed" $"{changes} change, {view.state.doc.lines} lines"

let private contentColor = window.getComputedStyle(view.contentDOM).color
report "theme" contentColor

let private empty = mount "" (View.placeholder "Type here")

report "placeholder" (document.querySelector(".cm-placeholder").Value.textContent)

empty.destroy ()
let private placeholders = count ".cm-placeholder"
report "destroyed" $"placeholders in page: {placeholders}"

report "loaded" "ok"
