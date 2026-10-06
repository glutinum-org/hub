module Glutinum.Leaflet.Tests.Page

open Fable.Core
open Fable.Core.JsInterop
open Glutinum

open type Glutinum.Web.Exports

type L = Leaflet.Exports

// The page exercises the binding in a real browser, the tests read the results in the DOM
let private report (id: string) (text: string) =
    let element = document.createElement "p"
    element.id <- id
    element.textContent <- text
    document.body.appendChild element |> ignore

let container = document.createElement "div"
container.id <- "map"
container.style.width <- "400px"
container.style.height <- "300px"
document.body.appendChild container |> ignore

let paris = L.latLng (48.85, 2.35)
let map = L.map(container).setView (paris, 13)

report "container" (map.getContainer().className)
report "center" $"{map.getCenter().lat} {map.getCenter().lng} zoom {map.getZoom ()}"

// A GeoJSON feature typed by the Glutinum.Geojson binding, referenced by this one
let parisFeature =
    jsOptions<Geojson.Feature<Geojson.Point, obj>> (fun feature ->
        feature.``type`` <- "Feature"

        feature.geometry <-
            jsOptions<Geojson.Point> (fun point ->
                point.``type`` <- "Point"
                point.coordinates <- ResizeArray [ 2.35; 48.85 ]
            )

        feature.properties <- {| name = "Paris" |}
    )

let layer = L.geoJSON parisFeature
layer.addTo map |> ignore

report "layers" $"{layer.getLayers().Count} layer, on the map: {map.hasLayer layer}"

// Distances and bounds
let london = L.latLng (51.5, -0.12)
let kilometers = int (paris.distanceTo london / 1000.0)
report "distance" $"{kilometers / 10 * 10} km"

let bounds = L.latLngBounds (L.latLng (48.0, 2.0), L.latLng (49.0, 3.0))
report "bounds" $"paris: {bounds.contains paris}, london: {bounds.contains london}"

// A circle marker with a popup
let marker = L.circleMarker (paris, Leaflet.CircleMarkerOptions.Create(radius = 12))

marker.bindPopup("Paris").addTo map |> ignore
let wasOpen = marker.isPopupOpen ()
marker.openPopup () |> ignore

report
    "popup"
    $"radius {marker.getRadius ()}, open before: {wasOpen}, after: {marker.isPopupOpen ()}"

// A layer group
let group = L.layerGroup ()
group.addLayer marker |> ignore
let countBefore = group.getLayers().Count
group.clearLayers () |> ignore
report "group" $"{countBefore} then {group.getLayers().Count}"

// Zoom
map.setZoom 5 |> ignore
report "zoom" $"zoom {map.getZoom ()}"

report "loaded" "ok"
