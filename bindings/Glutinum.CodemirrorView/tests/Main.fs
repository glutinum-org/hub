module Glutinum.CodemirrorView.Tests.Main

open Fable.Core
open Scriptorium.Nib.Browser

open type Scriptorium.Nib.Browser.UserEvents
open type Scriptorium.Nib.Browser.BrowserTest
open type Scriptorium.Quill.Runner
open type Scriptorium.Quill.Test

[<Import("readFileSync", "node:fs")>]
let private readFileSync (path: string, encoding: string) : string = jsNative

// The page built by `./build.sh test CodemirrorView` from `page/Page.fs` exercises the binding in Chromium.
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
                "Glutinum.CodemirrorView",
                [
                    testPageText "an EditorView shows its document" "#content" "onetwothree"
                    testPageText "lineNumbers adds a gutter" "#gutter" "4 line numbers"
                    testPageText
                        "updateListener sees the transaction"
                        "#changed"
                        "1 change, 4 lines"
                    testPageText "EditorView.theme styles the content" "#theme" "rgb(255, 0, 0)"
                    testPageText "placeholder shows in an empty editor" "#placeholder" "Type here"
                    testPageText "destroy removes the editor" "#destroyed" "placeholders in page: 0"
                    testPageText "the page runs the binding" "#loaded" "ok"
                ]
            )
        ]
