module Glutinum.Webmidi.Tests.Main

open Fable.Core
open Scriptorium.Nib.Browser

open type Scriptorium.Nib.Browser.UserEvents
open type Scriptorium.Nib.Browser.BrowserTest
open type Scriptorium.Quill.Runner
open type Scriptorium.Quill.Test

[<Import("readFileSync", "node:fs")>]
let private readFileSync (path: string, encoding: string) : string = jsNative

// The page built by `./build.sh test Webmidi` from `page/Page.fs` exercises the binding in Chromium.
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
                "Glutinum.Webmidi",
                [
                    // The page reports in the DOM, the tests read it
                    testPageText "nothing is enabled before enable" "#enabled-before" "false"
                    testPageText "a note is parsed from its identifier" "#note" "C# C#4 500"
                    testPageText "the utilities convert notes" "#utilities" "69 C4"
                    testPageText "a raw message is decoded" "#message" "9 1 60 100"
                    // The Chromium of Playwright has no Web MIDI, a browser with it reports `enabled`
                    testPageText "enable reports the outcome" "#enable" "unsupported"
                ]
            )
        ]
