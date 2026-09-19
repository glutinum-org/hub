module Glutinum.Geojson.Tests.Main

open Fable.Core
open Fable.Core.JsInterop
open Scriptorium.Nib.Assertion
open Glutinum

open type Scriptorium.Quill.Runner
open type Scriptorium.Quill.Test

// GeoJSON is a data format, the binding is the shape of its objects
let private position (x: float) (y: float) : Geojson.Position = ResizeArray [ x; y ]

let private point (x: float) (y: float) =
    jsOptions<Geojson.Point> (fun point ->
        point.``type`` <- "Point"
        point.coordinates <- position x y
    )

[<EntryPoint>]
let main _ =
    runTests
        [
            testList (
                "Glutinum.Geojson",
                [
                    test (
                        "a Point serializes to GeoJSON",
                        fun _ ->
                            assertThat
                                (JS.JSON.stringify (point 2.35 48.85))
                                (isEqualTo """{"type":"Point","coordinates":[2.35,48.85]}""")
                    )

                    test (
                        "a Feature carries its geometry and properties",
                        fun _ ->
                            let feature =
                                jsOptions<Geojson.Feature<Geojson.Point, obj>> (fun feature ->
                                    feature.``type`` <- "Feature"
                                    feature.geometry <- point 2.35 48.85
                                    feature.properties <- createObj [ "name" ==> "Paris" ]
                                )

                            assertThat feature.geometry.coordinates.[1] (isEqualTo 48.85)
                            assertThat (feature.properties?name: string) (isEqualTo "Paris")
                    )

                    test (
                        "a FeatureCollection lists its features",
                        fun _ ->
                            let collection =
                                jsOptions<Geojson.FeatureCollection<Geojson.Point, obj>> (fun
                                                                                              collection ->
                                    collection.``type`` <- "FeatureCollection"

                                    collection.features <-
                                        ResizeArray
                                            [
                                                jsOptions<Geojson.Feature<Geojson.Point, obj>> (fun
                                                                                                    feature ->
                                                    feature.``type`` <- "Feature"
                                                    feature.geometry <- point 0 0
                                                    feature.properties <- createObj []
                                                )
                                            ]
                                )

                            assertThat collection.features.Count (isEqualTo 1)
                            assertThat collection.features.[0].geometry.``type`` (isEqualTo "Point")
                    )

                    test (
                        "a LineString is a list of positions",
                        fun _ ->
                            let line =
                                jsOptions<Geojson.LineString> (fun line ->
                                    line.``type`` <- "LineString"

                                    line.coordinates <-
                                        ResizeArray [ position 0 0; position 1 1; position 2 0 ]
                                )

                            assertThat line.coordinates.Count (isEqualTo 3)
                            assertThat line.coordinates.[2].[0] (isEqualTo 2)
                    )

                    test (
                        "a Polygon is a list of rings",
                        fun _ ->
                            let polygon =
                                jsOptions<Geojson.Polygon> (fun polygon ->
                                    polygon.``type`` <- "Polygon"

                                    polygon.coordinates <-
                                        ResizeArray
                                            [
                                                ResizeArray
                                                    [
                                                        position 0 0
                                                        position 1 0
                                                        position 1 1
                                                        position 0 1
                                                        position 0 0
                                                    ]
                                            ]
                                )

                            assertThat polygon.coordinates.[0].Count (isEqualTo 5)
                    )

                    test (
                        "a GeometryCollection holds geometries",
                        fun _ ->
                            let collection =
                                jsOptions<Geojson.GeometryCollection<Geojson.Point>> (fun collection ->
                                    collection.``type`` <- "GeometryCollection"
                                    collection.geometries <- ResizeArray [ point 1 2; point 3 4 ]
                                )

                            assertThat collection.geometries.Count (isEqualTo 2)
                            assertThat collection.geometries.[1].coordinates.[0] (isEqualTo 3)
                    )

                    test (
                        "parsed JSON is read through the binding",
                        fun _ ->
                            let json =
                                """{"type":"FeatureCollection","features":[{"type":"Feature","geometry":{"type":"Point","coordinates":[2.35,48.85]},"properties":{"name":"Paris"}}]}"""

                            let collection: Geojson.FeatureCollection<Geojson.Point, obj> =
                                unbox (JS.JSON.parse json)

                            let feature = collection.features.[0]
                            assertThat collection.``type`` (isEqualTo "FeatureCollection")
                            assertThat feature.geometry.coordinates.[0] (isEqualTo 2.35)
                            assertThat (feature.properties?name: string) (isEqualTo "Paris")
                    )
                ]
            )
        ]
