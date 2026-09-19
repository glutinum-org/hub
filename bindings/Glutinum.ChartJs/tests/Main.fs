module Glutinum.ChartJs.Tests.Main

open Fable.Core
open Scriptorium.Nib.Browser

open type Scriptorium.Nib.Browser.UserEvents
open type Scriptorium.Nib.Browser.BrowserTest
open type Scriptorium.Quill.Runner
open type Scriptorium.Quill.Test

[<Import("readFileSync", "node:fs")>]
let private readFileSync (path: string, encoding: string) : string = jsNative

// The page built by `./build.sh test ChartJs` from `page/Page.fs` exercises the binding in Chromium.
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
                "Glutinum.ChartJs",
                [
                    testPageText
                        "a bar chart is created from a typed configuration"
                        "#config"
                        "type bar, 1 dataset, 3 labels"
                    testPageText
                        "the chart knows its canvas and datasets"
                        "#canvas"
                        "canvas chart, visible: true"
                    testPageText "update takes the new data" "#updated" "4 points, 4 bars"
                    testPageText "toBase64Image gives a PNG" "#image" "data:image/png;base64,"
                    testPageText
                        "a chart is destroyed"
                        "#line"
                        "line chart destroyed, bar chart still has 1 dataset"
                    testPageText "the page runs the binding" "#loaded" "ok"
                ]
            )
        ]
