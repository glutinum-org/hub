module Glutinum.ChartJs.Tests.Page

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
canvas.id <- "chart"
document.body.appendChild canvas |> ignore

// The configuration and the datasets are typed
let config =
    jsOptions<ChartJs.ChartConfiguration<string, ResizeArray<float>, string>> (fun config ->
        config.``type`` <- "bar"

        config.data <-
            jsOptions<ChartJs.ChartData<string, ResizeArray<float>, string>> (fun data ->
                data.labels <- Some(ResizeArray [ "a"; "b"; "c" ])

                data.datasets <-
                    ResizeArray
                        [
                            jsOptions<ChartJs.ChartDataset<string, ResizeArray<float>>> (fun
                                                                                             dataset ->
                                dataset.label <- Some "demo"
                                dataset.data <- ResizeArray [ 1.0; 2.0; 3.0 ]
                            )
                        ]
            )
    )

// `chart.js/auto` registers every controller, scale and element
let chart = ChartJs.auto.Exports.Chart(canvas.getContext_2d().Value, config)

report
    "config"
    $"type {config.``type``}, {chart.data.datasets.Count} dataset, {chart.data.labels.Value.Count} labels"

report "canvas" $"canvas {chart.canvas.id}, visible: {chart.isDatasetVisible 0}"

// The data is updated in place
let step = ref "labels"

try
    chart.data.labels.Value.Add "d"
    step.Value <- "data"
    chart.data.datasets.[0].data.Add 4.0
    step.Value <- "update"
    chart.update ()
    step.Value <- "count"
    let points = chart.data.datasets.[0].data.Count
    step.Value <- "meta"
    let bars = chart.getDatasetMeta(0).data.Count
    report "updated" $"{points} points, {bars} bars"
    step.Value <- "image"
    report "image" (chart.toBase64Image().Substring(0, 22))
with ex ->
    report "updated" $"error at {step.Value}: {ex.Message}"

// A second chart of another type on its own canvas
let lineCanvas = document.createElement Web.HTMLElementTagNameMap.Keys.canvas
document.body.appendChild lineCanvas |> ignore

let line =
    ChartJs.auto.Exports.Chart(
        lineCanvas,
        jsOptions<ChartJs.ChartConfiguration<string, ResizeArray<float>, string>> (fun config ->
            config.``type`` <- "line"

            config.data <-
                jsOptions<ChartJs.ChartData<string, ResizeArray<float>, string>> (fun data ->
                    data.labels <- Some(ResizeArray [ "x"; "y" ])

                    data.datasets <-
                        ResizeArray
                            [
                                jsOptions<ChartJs.ChartDataset<string, ResizeArray<float>>> (fun
                                                                                                 dataset ->
                                    dataset.data <- ResizeArray [ 5.0; 6.0 ]
                                )
                            ]
                )
        )
    )

line.destroy ()
report "line" $"line chart destroyed, bar chart still has {chart.data.datasets.Count} dataset"
report "loaded" "ok"
