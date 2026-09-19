module Glutinum.Leaflet.Tests.Main

open Fable.Core
open Scriptorium.Nib.Browser

open type Scriptorium.Nib.Browser.UserEvents
open type Scriptorium.Nib.Browser.BrowserTest
open type Scriptorium.Quill.Runner
open type Scriptorium.Quill.Test

[<Import("readFileSync", "node:fs")>]
let private readFileSync (path: string, encoding: string) : string = jsNative

// The page built by `./build.sh test Leaflet` from `page/Page.fs` exercises the binding in Chromium.
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
                "Glutinum.Leaflet",
                [
                    testPageText
                        "a map is created in a container"
                        "#container"
                        "leaflet-container leaflet-touch leaflet-fade-anim leaflet-grab leaflet-touch-drag leaflet-touch-zoom"
                    testPageText "setView, getCenter and getZoom" "#center" "48.85 2.35 zoom 13"
                    testPageText
                        "a GeoJSON feature of Glutinum.Geojson makes a layer"
                        "#layers"
                        "1 layer, on the map: true"
                    testPageText "distanceTo" "#distance" "340 km"
                    testPageText "latLngBounds contains" "#bounds" "paris: true, london: false"
                    testPageText
                        "a circle marker with a popup"
                        "#popup"
                        "radius 12, open before: false, after: true"
                    testPageText "a layer group" "#group" "1 then 0"
                    testPageText "setZoom" "#zoom" "zoom 5"
                    testPageText "the page runs the binding" "#loaded" "ok"
                ]
            )
        ]
