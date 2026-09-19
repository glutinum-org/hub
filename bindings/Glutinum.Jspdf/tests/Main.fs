module Glutinum.Jspdf.Tests.Main

open Fable.Core
open Scriptorium.Nib.Browser

open type Scriptorium.Nib.Browser.UserEvents
open type Scriptorium.Nib.Browser.BrowserTest
open type Scriptorium.Quill.Runner
open type Scriptorium.Quill.Test

[<Import("readFileSync", "node:fs")>]
let private readFileSync (path: string, encoding: string) : string = jsNative

// The page built by `./build.sh test Jspdf` from `page/Page.fs` exercises the binding in Chromium.
// Chromium refuses a module script of a `file://` page, so the bundle is inlined in the content.
let private pageContent =
    let html = readFileSync ("page/dist/index.html", "utf8")

    let script =
        System.Text.RegularExpressions.Regex.Match(html, "assets/[^\"]+\\.js").Value

    let bundle = readFileSync ("page/dist/" + script, "utf8")

    $"<!doctype html><html><head><meta charset=\"utf-8\"></head><body><script type=\"module\">{bundle}</script></body></html>"

let private testPageText (name: string) (selector: string) (expected: string) =
    testPage (
        name,
        fun page ->
            promise {
                do! page.setContent pageContent
                do! assertLocator (page.locator selector) (haveText expected)
            }
    )

[<EntryPoint>]
let main _ =
    runTests
        [
            testList (
                "Glutinum.Jspdf",
                [
                    testPageText "text and addPage build a document" "#pages" "2 pages"
                    testPageText "output is a PDF" "#output" "%PDF-"
                    testPageText "font size and text color" "#font" "size 20, color #ff0000"
                    testPageText "shapes and the current page" "#page" "page 2"
                    testPageText "setPage" "#setPage" "page 1"
                    testPageText "getFontList" "#fonts" "helvetica: true"
                    testPageText "setProperties writes the title" "#title" "true"
                    testPageText "the page runs the binding" "#loaded" "ok"
                ]
            )
        ]
