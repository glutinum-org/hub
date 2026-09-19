module Glutinum.SignaturePad.Tests.Main

open Fable.Core
open Scriptorium.Nib.Browser

open type Scriptorium.Nib.Browser.UserEvents
open type Scriptorium.Nib.Browser.BrowserTest
open type Scriptorium.Quill.Runner
open type Scriptorium.Quill.Test

[<Import("readFileSync", "node:fs")>]
let private readFileSync (path: string, encoding: string) : string = jsNative

// The page built by `./build.sh test SignaturePad` from `page/Page.fs` exercises the binding in Chromium.
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
                "Glutinum.SignaturePad",
                [
                    testPageText "a new pad is empty" "#empty" "empty: true"
                    testPageText "options are applied" "#options" "pen rgb(0, 0, 255), min width 1"
                    testPageText "fromData draws a stroke" "#drawn" "empty: false, 1 stroke"
                    testPageText "toDataURL gives a PNG" "#image" "data:image/png;base64,"
                    testPageText "toData round-trips" "#roundtrip" "2 points, pen black, first x 10"
                    testPageText "toSVG" "#svg" "<svg"
                    testPageText "clear" "#cleared" "empty: true"
                    testPageText "fromDataURL loads an image" "#fromDataURL" "empty: false"
                    testPageText "the page runs the binding" "#loaded" "ok"
                ]
            )
        ]
