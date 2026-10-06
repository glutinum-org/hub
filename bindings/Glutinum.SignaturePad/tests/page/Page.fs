module Glutinum.SignaturePad.Tests.Page

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

let canvas = document.createElement Web.HTMLElementTagNameMap.Keys.canvas
canvas.width <- 300
canvas.height <- 150
document.body.appendChild canvas |> ignore

let pad =
    SignaturePad.Exports.SignaturePad(
        canvas,
        SignaturePad.Options.Create(penColor = "rgb(0, 0, 255)", minWidth = 1.0)
    )

report "empty" $"empty: {pad.isEmpty ()}"
report "options" $"pen {pad.penColor}, min width {pad.minWidth}"

// A stroke of two points, as `toData` gives it
let stroke =
    jsOptions<SignaturePad.PointGroup> (fun group ->
        group.penColor <- "black"
        group.dotSize <- 0
        group.minWidth <- 0.5
        group.maxWidth <- 2.5
        group.velocityFilterWeight <- 0.7
        group.compositeOperation <- Web.GlobalCompositeOperation.``source-over``

        group.points <-
            ResizeArray
                [
                    for (x, y, time) in [ 10.0, 10.0, 0.0; 100.0, 60.0, 50.0 ] do
                        SignaturePad.BasicPoint.Create(x = x, y = y, pressure = 0.5, time = time)
                ]
    )

pad.fromData (ResizeArray [ stroke ])

report "drawn" $"empty: {pad.isEmpty ()}, {pad.toData().Count} stroke"
report "image" (pad.toDataURL().Substring(0, 22))

// The data round-trips
let data = pad.toData ()

report
    "roundtrip"
    $"{data.[0].points.Count} points, pen {data.[0].penColor}, first x {data.[0].points.[0].x}"

let svg = pad.toSVG ()
report "svg" (svg.Substring(0, 4))

pad.clear ()
report "cleared" $"empty: {pad.isEmpty ()}"

// Loading an image back
let image = pad.toDataURL ()

promise {
    pad.fromData (ResizeArray [ stroke ])
    let drawn = pad.toDataURL ()
    pad.clear ()
    do! pad.fromDataURL drawn
    report "fromDataURL" $"empty: {pad.isEmpty ()}"
    report "loaded" "ok"
}
|> Promise.start
