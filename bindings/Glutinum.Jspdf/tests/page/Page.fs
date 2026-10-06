module Glutinum.Jspdf.Tests.Page

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

// `jsPDF ()` is ambiguous between the overloads with optional parameters only
let doc = Jspdf.Exports.jsPDF (Jspdf.jsPDFOptions.Create())

doc.text ("Hello from Fable", 10, 10) |> ignore
doc.addPage () |> ignore

report "pages" $"{doc.getNumberOfPages ()} pages"
report "output" (doc.output().Substring(0, 5))

// Fonts and colors, the setters chain
doc.setFontSize(20).setTextColor (255, 0, 0) |> ignore
report "font" $"size {doc.getFontSize ()}, color {doc.getTextColor ()}"

// Shapes
doc.rect(10, 20, 50, 30, "S").line (10, 60, 60, 60) |> ignore
report "page" $"page {doc.getCurrentPageInfo().pageNumber}"

doc.setPage 1 |> ignore
report "setPage" $"page {doc.getCurrentPageInfo().pageNumber}"

let fonts = doc.getFontList ()
let hasHelvetica = fonts.["helvetica"].Count > 0
report "fonts" $"helvetica: {hasHelvetica}"

doc.setProperties (Jspdf.DocumentProperties.Create(title = "Fable report"))
|> ignore

let hasTitle = doc.output().Contains "Fable report"
report "title" $"{hasTitle}"
report "loaded" "ok"
