namespace rec Glutinum

open Fable.Core
open Fable.Core.JsInterop
open System

// You need to add Glutinum.Types NuGet package to your project
open Glutinum.Types.TypeScript

// You need to add Glutinum.Web NuGet package to your project

// You need to add Glutinum.Geojson NuGet package to your project

module Leaflet =

    [<AbstractClass>]
    [<Erase>]
    type Exports =
        /// <summary>
        /// A constant that represents the Leaflet version in use.
        /// </summary>
        [<Import("version", "leaflet")>]
        static member inline version: string = nativeOnly
        /// <summary>
        /// Instantiates a Transformation object with the given coefficients.
        /// </summary>
        [<Import("transformation", "leaflet")>]
        static member transformation (a: float, b: float, c: float, d: float) : Leaflet.Transformation = nativeOnly
        /// <summary>
        /// Expects an coefficients array of the form <c>[a: Number, b: Number, c: Number, d: Number]</c>.
        /// </summary>
        [<Import("transformation", "leaflet")>]
        static member transformation (coefficients: (float * float * float * float)) : Leaflet.Transformation = nativeOnly
        [<Import("latLng", "leaflet")>]
        static member latLng (latitude: float, longitude: float, ?altitude: float) : Leaflet.LatLng = nativeOnly
        [<Import("latLng", "leaflet")>]
        static member latLng (coords: Leaflet.LatLngTuple) : Leaflet.LatLng = nativeOnly
        [<Import("latLng", "leaflet")>]
        static member latLng (coords: (float * float * float)) : Leaflet.LatLng = nativeOnly
        [<Import("latLng", "leaflet")>]
        static member latLng (coords: Leaflet.LatLngLiteral) : Leaflet.LatLng = nativeOnly
        [<Import("latLng", "leaflet")>]
        static member latLng (coords: Exports.latLng__.coords) : Leaflet.LatLng = nativeOnly
        [<Import("latLng", "leaflet")>]
        static member latLng (coords: U4<Leaflet.LatLngTuple, float * float * float, Leaflet.LatLngLiteral, Exports.latLng__.coords>) : Leaflet.LatLng = nativeOnly
        [<Import("latLngBounds", "leaflet")>]
        static member latLngBounds (southWest: Leaflet.LatLng, northEast: Leaflet.LatLng) : Leaflet.LatLngBounds = nativeOnly
        [<Import("latLngBounds", "leaflet")>]
        static member latLngBounds (southWest: Leaflet.LatLng, northEast: Leaflet.LatLngLiteral) : Leaflet.LatLngBounds = nativeOnly
        [<Import("latLngBounds", "leaflet")>]
        static member latLngBounds (southWest: Leaflet.LatLng, northEast: Leaflet.LatLngTuple) : Leaflet.LatLngBounds = nativeOnly
        [<Import("latLngBounds", "leaflet")>]
        static member latLngBounds (southWest: Leaflet.LatLngLiteral, northEast: Leaflet.LatLng) : Leaflet.LatLngBounds = nativeOnly
        [<Import("latLngBounds", "leaflet")>]
        static member latLngBounds (southWest: Leaflet.LatLngLiteral, northEast: Leaflet.LatLngLiteral) : Leaflet.LatLngBounds = nativeOnly
        [<Import("latLngBounds", "leaflet")>]
        static member latLngBounds (southWest: Leaflet.LatLngLiteral, northEast: Leaflet.LatLngTuple) : Leaflet.LatLngBounds = nativeOnly
        [<Import("latLngBounds", "leaflet")>]
        static member latLngBounds (southWest: Leaflet.LatLngTuple, northEast: Leaflet.LatLng) : Leaflet.LatLngBounds = nativeOnly
        [<Import("latLngBounds", "leaflet")>]
        static member latLngBounds (southWest: Leaflet.LatLngTuple, northEast: Leaflet.LatLngLiteral) : Leaflet.LatLngBounds = nativeOnly
        [<Import("latLngBounds", "leaflet")>]
        static member latLngBounds (southWest: Leaflet.LatLngTuple, northEast: Leaflet.LatLngTuple) : Leaflet.LatLngBounds = nativeOnly
        [<Import("latLngBounds", "leaflet")>]
        static member latLngBounds (southWest: Leaflet.LatLngExpression, northEast: Leaflet.LatLngExpression) : Leaflet.LatLngBounds = nativeOnly
        [<Import("latLngBounds", "leaflet")>]
        static member latLngBounds (latlngs: ResizeArray<Leaflet.LatLngExpression>) : Leaflet.LatLngBounds = nativeOnly
        [<Import("point", "leaflet")>]
        static member point (x: float, y: float, ?round: bool) : Leaflet.Point = nativeOnly
        [<Import("point", "leaflet")>]
        static member point (coords: Leaflet.PointTuple) : Leaflet.Point = nativeOnly
        [<Import("point", "leaflet")>]
        static member point (coords: Exports.point__.coords) : Leaflet.Point = nativeOnly
        [<Import("point", "leaflet")>]
        static member point (coords: U2<Leaflet.PointTuple, Exports.point__.coords>) : Leaflet.Point = nativeOnly
        [<Import("bounds", "leaflet")>]
        static member bounds (topLeft: Leaflet.Point, bottomRight: Leaflet.Point) : Leaflet.Bounds = nativeOnly
        [<Import("bounds", "leaflet")>]
        static member bounds (topLeft: Leaflet.Point, bottomRight: Leaflet.PointTuple) : Leaflet.Bounds = nativeOnly
        [<Import("bounds", "leaflet")>]
        static member bounds (topLeft: Leaflet.PointTuple, bottomRight: Leaflet.Point) : Leaflet.Bounds = nativeOnly
        [<Import("bounds", "leaflet")>]
        static member bounds (topLeft: Leaflet.PointTuple, bottomRight: Leaflet.PointTuple) : Leaflet.Bounds = nativeOnly
        [<Import("bounds", "leaflet")>]
        static member bounds (topLeft: Leaflet.PointExpression, bottomRight: Leaflet.PointExpression) : Leaflet.Bounds = nativeOnly
        [<Import("bounds", "leaflet")>]
        static member bounds (points: ResizeArray<Leaflet.Point>) : Leaflet.Bounds = nativeOnly
        [<Import("bounds", "leaflet")>]
        static member bounds (points: Leaflet.BoundsLiteral) : Leaflet.Bounds = nativeOnly
        [<Import("bounds", "leaflet")>]
        static member bounds (points: U2<ResizeArray<Leaflet.Point>, Leaflet.BoundsLiteral>) : Leaflet.Bounds = nativeOnly
        [<Import("Mixin", "leaflet")>]
        static member inline Mixin: Leaflet.MixinType = nativeOnly
        [<Import("gridLayer", "leaflet")>]
        static member gridLayer (?options: Leaflet.GridLayerOptions) : Leaflet.GridLayer = nativeOnly
        [<Import("tileLayer", "leaflet")>]
        static member tileLayer (urlTemplate: string, ?options: Leaflet.TileLayerOptions) : Leaflet.TileLayer = nativeOnly
        [<Import("imageOverlay", "leaflet")>]
        static member imageOverlay (imageUrl: string, bounds: Leaflet.LatLngBounds, ?options: Leaflet.ImageOverlayOptions) : Leaflet.ImageOverlay = nativeOnly
        [<Import("imageOverlay", "leaflet")>]
        static member imageOverlay (imageUrl: string, bounds: Leaflet.LatLngBoundsLiteral, ?options: Leaflet.ImageOverlayOptions) : Leaflet.ImageOverlay = nativeOnly
        [<Import("imageOverlay", "leaflet")>]
        static member imageOverlay (imageUrl: string, bounds: Leaflet.LatLngBoundsExpression, ?options: Leaflet.ImageOverlayOptions) : Leaflet.ImageOverlay = nativeOnly
        [<Import("svgOverlay", "leaflet")>]
        static member svgOverlay (svgImage: string, bounds: Leaflet.LatLngBounds, ?options: Leaflet.ImageOverlayOptions) : Leaflet.SVGOverlay = nativeOnly
        [<Import("svgOverlay", "leaflet")>]
        static member svgOverlay (svgImage: string, bounds: Leaflet.LatLngBoundsLiteral, ?options: Leaflet.ImageOverlayOptions) : Leaflet.SVGOverlay = nativeOnly
        [<Import("svgOverlay", "leaflet")>]
        static member svgOverlay (svgImage: Glutinum.Web.SVGElement, bounds: Leaflet.LatLngBounds, ?options: Leaflet.ImageOverlayOptions) : Leaflet.SVGOverlay = nativeOnly
        [<Import("svgOverlay", "leaflet")>]
        static member svgOverlay (svgImage: Glutinum.Web.SVGElement, bounds: Leaflet.LatLngBoundsLiteral, ?options: Leaflet.ImageOverlayOptions) : Leaflet.SVGOverlay = nativeOnly
        [<Import("svgOverlay", "leaflet")>]
        static member svgOverlay (svgImage: U2<string, Glutinum.Web.SVGElement>, bounds: Leaflet.LatLngBoundsExpression, ?options: Leaflet.ImageOverlayOptions) : Leaflet.SVGOverlay = nativeOnly
        [<Import("videoOverlay", "leaflet")>]
        static member videoOverlay (video: string, bounds: Leaflet.LatLngBounds, ?options: Leaflet.VideoOverlayOptions) : Leaflet.VideoOverlay = nativeOnly
        [<Import("videoOverlay", "leaflet")>]
        static member videoOverlay (video: string, bounds: Leaflet.LatLngBoundsLiteral, ?options: Leaflet.VideoOverlayOptions) : Leaflet.VideoOverlay = nativeOnly
        [<Import("videoOverlay", "leaflet")>]
        static member videoOverlay (video: ResizeArray<string>, bounds: Leaflet.LatLngBounds, ?options: Leaflet.VideoOverlayOptions) : Leaflet.VideoOverlay = nativeOnly
        [<Import("videoOverlay", "leaflet")>]
        static member videoOverlay (video: ResizeArray<string>, bounds: Leaflet.LatLngBoundsLiteral, ?options: Leaflet.VideoOverlayOptions) : Leaflet.VideoOverlay = nativeOnly
        [<Import("videoOverlay", "leaflet")>]
        static member videoOverlay (video: Glutinum.Web.HTMLVideoElement, bounds: Leaflet.LatLngBounds, ?options: Leaflet.VideoOverlayOptions) : Leaflet.VideoOverlay = nativeOnly
        [<Import("videoOverlay", "leaflet")>]
        static member videoOverlay (video: Glutinum.Web.HTMLVideoElement, bounds: Leaflet.LatLngBoundsLiteral, ?options: Leaflet.VideoOverlayOptions) : Leaflet.VideoOverlay = nativeOnly
        [<Import("videoOverlay", "leaflet")>]
        static member videoOverlay (video: U3<string, ResizeArray<string>, Glutinum.Web.HTMLVideoElement>, bounds: Leaflet.LatLngBoundsExpression, ?options: Leaflet.VideoOverlayOptions) : Leaflet.VideoOverlay = nativeOnly
        [<Import("polyline", "leaflet")>]
        static member polyline<'T, 'P> (latlngs: ResizeArray<Leaflet.LatLngExpression>, ?options: Leaflet.PolylineOptions) : Leaflet.Polyline<'T, 'P> = nativeOnly
        [<Import("polyline", "leaflet")>]
        static member polyline<'T, 'P> (latlngs: ResizeArray<ResizeArray<Leaflet.LatLngExpression>>, ?options: Leaflet.PolylineOptions) : Leaflet.Polyline<'T, 'P> = nativeOnly
        [<Import("polyline", "leaflet")>]
        static member polyline<'T, 'P> (latlngs: U2<ResizeArray<Leaflet.LatLngExpression>, ResizeArray<ResizeArray<Leaflet.LatLngExpression>>>, ?options: Leaflet.PolylineOptions) : Leaflet.Polyline<'T, 'P> = nativeOnly
        [<Import("polyline", "leaflet")>]
        static member polyline (latlngs: ResizeArray<Leaflet.LatLngExpression>, ?options: Leaflet.PolylineOptions) : Leaflet.Polyline<U2<Glutinum.Geojson.LineString, Glutinum.Geojson.MultiLineString>, obj> = nativeOnly
        [<Import("polyline", "leaflet")>]
        static member polyline (latlngs: ResizeArray<ResizeArray<Leaflet.LatLngExpression>>, ?options: Leaflet.PolylineOptions) : Leaflet.Polyline<U2<Glutinum.Geojson.LineString, Glutinum.Geojson.MultiLineString>, obj> = nativeOnly
        [<Import("polyline", "leaflet")>]
        static member polyline (latlngs: U2<ResizeArray<Leaflet.LatLngExpression>, ResizeArray<ResizeArray<Leaflet.LatLngExpression>>>, ?options: Leaflet.PolylineOptions) : Leaflet.Polyline<U2<Glutinum.Geojson.LineString, Glutinum.Geojson.MultiLineString>, obj> = nativeOnly
        [<Import("polygon", "leaflet")>]
        static member polygon<'P> (latlngs: ResizeArray<Leaflet.LatLngExpression>, ?options: Leaflet.PolylineOptions) : Leaflet.Polygon<'P> = nativeOnly
        [<Import("polygon", "leaflet")>]
        static member polygon<'P> (latlngs: ResizeArray<ResizeArray<Leaflet.LatLngExpression>>, ?options: Leaflet.PolylineOptions) : Leaflet.Polygon<'P> = nativeOnly
        [<Import("polygon", "leaflet")>]
        static member polygon<'P> (latlngs: ResizeArray<ResizeArray<ResizeArray<Leaflet.LatLngExpression>>>, ?options: Leaflet.PolylineOptions) : Leaflet.Polygon<'P> = nativeOnly
        [<Import("polygon", "leaflet")>]
        static member polygon<'P> (latlngs: U3<ResizeArray<Leaflet.LatLngExpression>, ResizeArray<ResizeArray<Leaflet.LatLngExpression>>, ResizeArray<ResizeArray<ResizeArray<Leaflet.LatLngExpression>>>>, ?options: Leaflet.PolylineOptions) : Leaflet.Polygon<'P> = nativeOnly
        [<Import("polygon", "leaflet")>]
        static member polygon (latlngs: ResizeArray<Leaflet.LatLngExpression>, ?options: Leaflet.PolylineOptions) : Leaflet.Polygon<obj> = nativeOnly
        [<Import("polygon", "leaflet")>]
        static member polygon (latlngs: ResizeArray<ResizeArray<Leaflet.LatLngExpression>>, ?options: Leaflet.PolylineOptions) : Leaflet.Polygon<obj> = nativeOnly
        [<Import("polygon", "leaflet")>]
        static member polygon (latlngs: ResizeArray<ResizeArray<ResizeArray<Leaflet.LatLngExpression>>>, ?options: Leaflet.PolylineOptions) : Leaflet.Polygon<obj> = nativeOnly
        [<Import("polygon", "leaflet")>]
        static member polygon (latlngs: U3<ResizeArray<Leaflet.LatLngExpression>, ResizeArray<ResizeArray<Leaflet.LatLngExpression>>, ResizeArray<ResizeArray<ResizeArray<Leaflet.LatLngExpression>>>>, ?options: Leaflet.PolylineOptions) : Leaflet.Polygon<obj> = nativeOnly
        [<Import("rectangle", "leaflet")>]
        static member rectangle<'P> (latLngBounds: Leaflet.LatLngBounds, ?options: Leaflet.PolylineOptions) : Leaflet.Rectangle<'P> = nativeOnly
        [<Import("rectangle", "leaflet")>]
        static member rectangle<'P> (latLngBounds: Leaflet.LatLngBoundsLiteral, ?options: Leaflet.PolylineOptions) : Leaflet.Rectangle<'P> = nativeOnly
        [<Import("rectangle", "leaflet")>]
        static member rectangle<'P> (latLngBounds: Leaflet.LatLngBoundsExpression, ?options: Leaflet.PolylineOptions) : Leaflet.Rectangle<'P> = nativeOnly
        [<Import("rectangle", "leaflet")>]
        static member rectangle (latLngBounds: Leaflet.LatLngBounds, ?options: Leaflet.PolylineOptions) : Leaflet.Rectangle<obj> = nativeOnly
        [<Import("rectangle", "leaflet")>]
        static member rectangle (latLngBounds: Leaflet.LatLngBoundsLiteral, ?options: Leaflet.PolylineOptions) : Leaflet.Rectangle<obj> = nativeOnly
        [<Import("rectangle", "leaflet")>]
        static member rectangle (latLngBounds: Leaflet.LatLngBoundsExpression, ?options: Leaflet.PolylineOptions) : Leaflet.Rectangle<obj> = nativeOnly
        [<Import("circleMarker", "leaflet")>]
        static member circleMarker<'P> (latlng: Leaflet.LatLng, ?options: Leaflet.CircleMarkerOptions) : Leaflet.CircleMarker<'P> = nativeOnly
        [<Import("circleMarker", "leaflet")>]
        static member circleMarker<'P> (latlng: Leaflet.LatLngLiteral, ?options: Leaflet.CircleMarkerOptions) : Leaflet.CircleMarker<'P> = nativeOnly
        [<Import("circleMarker", "leaflet")>]
        static member circleMarker<'P> (latlng: Leaflet.LatLngTuple, ?options: Leaflet.CircleMarkerOptions) : Leaflet.CircleMarker<'P> = nativeOnly
        [<Import("circleMarker", "leaflet")>]
        static member circleMarker<'P> (latlng: Leaflet.LatLngExpression, ?options: Leaflet.CircleMarkerOptions) : Leaflet.CircleMarker<'P> = nativeOnly
        [<Import("circleMarker", "leaflet")>]
        static member circleMarker (latlng: Leaflet.LatLng, ?options: Leaflet.CircleMarkerOptions) : Leaflet.CircleMarker<obj> = nativeOnly
        [<Import("circleMarker", "leaflet")>]
        static member circleMarker (latlng: Leaflet.LatLngLiteral, ?options: Leaflet.CircleMarkerOptions) : Leaflet.CircleMarker<obj> = nativeOnly
        [<Import("circleMarker", "leaflet")>]
        static member circleMarker (latlng: Leaflet.LatLngTuple, ?options: Leaflet.CircleMarkerOptions) : Leaflet.CircleMarker<obj> = nativeOnly
        [<Import("circleMarker", "leaflet")>]
        static member circleMarker (latlng: Leaflet.LatLngExpression, ?options: Leaflet.CircleMarkerOptions) : Leaflet.CircleMarker<obj> = nativeOnly
        [<Import("circle", "leaflet")>]
        static member circle<'P> (latlng: Leaflet.LatLng, options: Leaflet.CircleMarkerOptions) : Leaflet.Circle<'P> = nativeOnly
        [<Import("circle", "leaflet")>]
        static member circle<'P> (latlng: Leaflet.LatLngLiteral, options: Leaflet.CircleMarkerOptions) : Leaflet.Circle<'P> = nativeOnly
        [<Import("circle", "leaflet")>]
        static member circle<'P> (latlng: Leaflet.LatLngTuple, options: Leaflet.CircleMarkerOptions) : Leaflet.Circle<'P> = nativeOnly
        [<Import("circle", "leaflet")>]
        static member circle<'P> (latlng: Leaflet.LatLngExpression, options: Leaflet.CircleMarkerOptions) : Leaflet.Circle<'P> = nativeOnly
        [<Import("circle", "leaflet")>]
        static member circle (latlng: Leaflet.LatLng, options: Leaflet.CircleMarkerOptions) : Leaflet.Circle<obj> = nativeOnly
        [<Import("circle", "leaflet")>]
        static member circle (latlng: Leaflet.LatLngLiteral, options: Leaflet.CircleMarkerOptions) : Leaflet.Circle<obj> = nativeOnly
        [<Import("circle", "leaflet")>]
        static member circle (latlng: Leaflet.LatLngTuple, options: Leaflet.CircleMarkerOptions) : Leaflet.Circle<obj> = nativeOnly
        [<Import("circle", "leaflet")>]
        static member circle (latlng: Leaflet.LatLngExpression, options: Leaflet.CircleMarkerOptions) : Leaflet.Circle<obj> = nativeOnly
        [<Import("circle", "leaflet"); Obsolete("Passing the radius outside the options is deperecated. Use {@link circle :1} instead.")>]
        static member circle<'P> (latlng: Leaflet.LatLng, radius: float, ?options: Leaflet.CircleMarkerOptions) : Leaflet.Circle<'P> = nativeOnly
        [<Import("circle", "leaflet"); Obsolete("Passing the radius outside the options is deperecated. Use {@link circle :1} instead.")>]
        static member circle<'P> (latlng: Leaflet.LatLngLiteral, radius: float, ?options: Leaflet.CircleMarkerOptions) : Leaflet.Circle<'P> = nativeOnly
        [<Import("circle", "leaflet"); Obsolete("Passing the radius outside the options is deperecated. Use {@link circle :1} instead.")>]
        static member circle<'P> (latlng: Leaflet.LatLngTuple, radius: float, ?options: Leaflet.CircleMarkerOptions) : Leaflet.Circle<'P> = nativeOnly
        [<Import("circle", "leaflet"); Obsolete("Passing the radius outside the options is deperecated. Use {@link circle :1} instead.")>]
        static member circle<'P> (latlng: Leaflet.LatLngExpression, radius: float, ?options: Leaflet.CircleMarkerOptions) : Leaflet.Circle<'P> = nativeOnly
        [<Import("circle", "leaflet"); Obsolete("Passing the radius outside the options is deperecated. Use {@link circle :1} instead.")>]
        static member circle (latlng: Leaflet.LatLng, radius: float, ?options: Leaflet.CircleMarkerOptions) : Leaflet.Circle<obj> = nativeOnly
        [<Import("circle", "leaflet"); Obsolete("Passing the radius outside the options is deperecated. Use {@link circle :1} instead.")>]
        static member circle (latlng: Leaflet.LatLngLiteral, radius: float, ?options: Leaflet.CircleMarkerOptions) : Leaflet.Circle<obj> = nativeOnly
        [<Import("circle", "leaflet"); Obsolete("Passing the radius outside the options is deperecated. Use {@link circle :1} instead.")>]
        static member circle (latlng: Leaflet.LatLngTuple, radius: float, ?options: Leaflet.CircleMarkerOptions) : Leaflet.Circle<obj> = nativeOnly
        [<Import("circle", "leaflet"); Obsolete("Passing the radius outside the options is deperecated. Use {@link circle :1} instead.")>]
        static member circle (latlng: Leaflet.LatLngExpression, radius: float, ?options: Leaflet.CircleMarkerOptions) : Leaflet.Circle<obj> = nativeOnly
        [<Import("svg", "leaflet")>]
        static member svg (?options: Leaflet.RendererOptions) : Leaflet.SVG = nativeOnly
        [<Import("canvas", "leaflet")>]
        static member canvas (?options: Leaflet.RendererOptions) : Leaflet.Canvas = nativeOnly
        /// <summary>
        /// Create a layer group, optionally given an initial set of layers and an <c>options</c> object.
        /// </summary>
        [<Import("layerGroup", "leaflet")>]
        static member layerGroup<'P> (?layers: ResizeArray<Leaflet.Layer>, ?options: Leaflet.LayerOptions) : Leaflet.LayerGroup<'P> = nativeOnly
        /// <summary>
        /// Create a layer group, optionally given an initial set of layers and an <c>options</c> object.
        /// </summary>
        [<Import("layerGroup", "leaflet")>]
        static member layerGroup (?layers: ResizeArray<Leaflet.Layer>, ?options: Leaflet.LayerOptions) : Leaflet.LayerGroup<obj> = nativeOnly
        /// <summary>
        /// Create a layer group, optionally given an initial set of layers and an <c>options</c> object.
        /// </summary>
        [<Import("layerGroup", "leaflet")>]
        static member layerGroup () : Leaflet.LayerGroup<obj> = nativeOnly
        /// <summary>
        /// Create a feature group, optionally given an initial set of layers.
        /// </summary>
        [<Import("featureGroup", "leaflet")>]
        static member featureGroup<'P> (?layers: ResizeArray<Leaflet.Layer>, ?options: Leaflet.LayerOptions) : Leaflet.FeatureGroup<'P> = nativeOnly
        /// <summary>
        /// Create a feature group, optionally given an initial set of layers.
        /// </summary>
        [<Import("featureGroup", "leaflet")>]
        static member featureGroup (?layers: ResizeArray<Leaflet.Layer>, ?options: Leaflet.LayerOptions) : Leaflet.FeatureGroup<obj> = nativeOnly
        /// <summary>
        /// Create a feature group, optionally given an initial set of layers.
        /// </summary>
        [<Import("featureGroup", "leaflet")>]
        static member featureGroup () : Leaflet.FeatureGroup<obj> = nativeOnly
        /// <summary>
        /// Creates a GeoJSON layer.
        ///
        /// Optionally accepts an object in GeoJSON format to display on the
        /// map (you can alternatively add it later with addData method) and
        /// an options object.
        /// </summary>
        [<Import("geoJSON", "leaflet")>]
        static member geoJSON<'P, 'G> () : Leaflet.GeoJSON<'P, 'G> = nativeOnly
        /// <summary>
        /// Creates a GeoJSON layer.
        ///
        /// Optionally accepts an object in GeoJSON format to display on the
        /// map (you can alternatively add it later with addData method) and
        /// an options object.
        /// </summary>
        [<Import("geoJSON", "leaflet")>]
        static member geoJSON<'P, 'G> (geojson: Glutinum.Geojson.GeoJsonObject, ?options: Leaflet.GeoJSONOptions<'P, 'G>) : Leaflet.GeoJSON<'P, 'G> = nativeOnly
        /// <summary>
        /// Creates a GeoJSON layer.
        ///
        /// Optionally accepts an object in GeoJSON format to display on the
        /// map (you can alternatively add it later with addData method) and
        /// an options object.
        /// </summary>
        [<Import("geoJSON", "leaflet")>]
        static member geoJSON<'P, 'G> (geojson: ResizeArray<Glutinum.Geojson.GeoJsonObject>, ?options: Leaflet.GeoJSONOptions<'P, 'G>) : Leaflet.GeoJSON<'P, 'G> = nativeOnly
        /// <summary>
        /// Creates a GeoJSON layer.
        ///
        /// Optionally accepts an object in GeoJSON format to display on the
        /// map (you can alternatively add it later with addData method) and
        /// an options object.
        /// </summary>
        [<Import("geoJSON", "leaflet")>]
        static member geoJSON () : Leaflet.GeoJSON<obj, Glutinum.Geojson.GeometryObject> = nativeOnly
        /// <summary>
        /// Creates a GeoJSON layer.
        ///
        /// Optionally accepts an object in GeoJSON format to display on the
        /// map (you can alternatively add it later with addData method) and
        /// an options object.
        /// </summary>
        [<Import("geoJSON", "leaflet")>]
        static member geoJSON (geojson: Glutinum.Geojson.GeoJsonObject, ?options: Leaflet.GeoJSONOptions<obj, Glutinum.Geojson.GeometryObject>) : Leaflet.GeoJSON<obj, Glutinum.Geojson.GeometryObject> = nativeOnly
        /// <summary>
        /// Creates a GeoJSON layer.
        ///
        /// Optionally accepts an object in GeoJSON format to display on the
        /// map (you can alternatively add it later with addData method) and
        /// an options object.
        /// </summary>
        [<Import("geoJSON", "leaflet")>]
        static member geoJSON (geojson: ResizeArray<Glutinum.Geojson.GeoJsonObject>, ?options: Leaflet.GeoJSONOptions<obj, Glutinum.Geojson.GeometryObject>) : Leaflet.GeoJSON<obj, Glutinum.Geojson.GeometryObject> = nativeOnly
        [<Import("geoJson", "leaflet")>]
        static member geoJson<'P, 'G> () : Leaflet.GeoJSON<'P, 'G> = nativeOnly
        [<Import("geoJson", "leaflet")>]
        static member geoJson<'P, 'G> (geojson: Glutinum.Geojson.GeoJsonObject, ?options: Leaflet.GeoJSONOptions<'P, 'G>) : Leaflet.GeoJSON<'P, 'G> = nativeOnly
        [<Import("geoJson", "leaflet")>]
        static member geoJson<'P, 'G> (geojson: ResizeArray<Glutinum.Geojson.GeoJsonObject>, ?options: Leaflet.GeoJSONOptions<'P, 'G>) : Leaflet.GeoJSON<'P, 'G> = nativeOnly
        [<Import("geoJson", "leaflet")>]
        static member geoJson () : Leaflet.GeoJSON<obj, Glutinum.Geojson.GeometryObject> = nativeOnly
        [<Import("geoJson", "leaflet")>]
        static member geoJson (geojson: Glutinum.Geojson.GeoJsonObject, ?options: Leaflet.GeoJSONOptions<obj, Glutinum.Geojson.GeometryObject>) : Leaflet.GeoJSON<obj, Glutinum.Geojson.GeometryObject> = nativeOnly
        [<Import("geoJson", "leaflet")>]
        static member geoJson (geojson: ResizeArray<Glutinum.Geojson.GeoJsonObject>, ?options: Leaflet.GeoJSONOptions<obj, Glutinum.Geojson.GeometryObject>) : Leaflet.GeoJSON<obj, Glutinum.Geojson.GeometryObject> = nativeOnly
        [<Import("popup", "leaflet")>]
        static member popup (latlng: Leaflet.LatLng, ?options: Leaflet.PopupOptions) : Leaflet.Popup = nativeOnly
        [<Import("popup", "leaflet")>]
        static member popup (latlng: Leaflet.LatLngLiteral, ?options: Leaflet.PopupOptions) : Leaflet.Popup = nativeOnly
        [<Import("popup", "leaflet")>]
        static member popup (latlng: Leaflet.LatLngTuple, ?options: Leaflet.PopupOptions) : Leaflet.Popup = nativeOnly
        [<Import("popup", "leaflet")>]
        static member popup (latlng: Leaflet.LatLngExpression, ?options: Leaflet.PopupOptions) : Leaflet.Popup = nativeOnly
        [<Import("popup", "leaflet")>]
        static member popup (?options: Leaflet.PopupOptions, ?source: Leaflet.Layer) : Leaflet.Popup = nativeOnly
        [<Import("tooltip", "leaflet")>]
        static member tooltip (latlng: Leaflet.LatLng, ?options: Leaflet.TooltipOptions) : Leaflet.Tooltip = nativeOnly
        [<Import("tooltip", "leaflet")>]
        static member tooltip (latlng: Leaflet.LatLngLiteral, ?options: Leaflet.TooltipOptions) : Leaflet.Tooltip = nativeOnly
        [<Import("tooltip", "leaflet")>]
        static member tooltip (latlng: Leaflet.LatLngTuple, ?options: Leaflet.TooltipOptions) : Leaflet.Tooltip = nativeOnly
        [<Import("tooltip", "leaflet")>]
        static member tooltip (latlng: Leaflet.LatLngExpression, ?options: Leaflet.TooltipOptions) : Leaflet.Tooltip = nativeOnly
        [<Import("tooltip", "leaflet")>]
        static member tooltip (?options: Leaflet.TooltipOptions, ?source: Leaflet.Layer) : Leaflet.Tooltip = nativeOnly
        /// <summary>
        /// ID of a HTML-Element as string or the HTML-ELement itself
        /// </summary>
        [<Import("map", "leaflet")>]
        static member map (element: string, ?options: Leaflet.MapOptions) : Leaflet.Map = nativeOnly
        /// <summary>
        /// ID of a HTML-Element as string or the HTML-ELement itself
        /// </summary>
        [<Import("map", "leaflet")>]
        static member map (element: Glutinum.Web.HTMLElement, ?options: Leaflet.MapOptions) : Leaflet.Map = nativeOnly
        /// <summary>
        /// ID of a HTML-Element as string or the HTML-ELement itself
        /// </summary>
        [<Import("map", "leaflet")>]
        static member map (element: U2<string, Glutinum.Web.HTMLElement>, ?options: Leaflet.MapOptions) : Leaflet.Map = nativeOnly
        [<Import("icon", "leaflet")>]
        static member icon (options: Leaflet.IconOptions) : Leaflet.Icon = nativeOnly
        [<Import("divIcon", "leaflet")>]
        static member divIcon (?options: Leaflet.DivIconOptions) : Leaflet.DivIcon = nativeOnly
        [<Import("marker", "leaflet")>]
        static member marker<'P> (latlng: Leaflet.LatLng, ?options: Leaflet.MarkerOptions) : Leaflet.Marker<'P> = nativeOnly
        [<Import("marker", "leaflet")>]
        static member marker<'P> (latlng: Leaflet.LatLngLiteral, ?options: Leaflet.MarkerOptions) : Leaflet.Marker<'P> = nativeOnly
        [<Import("marker", "leaflet")>]
        static member marker<'P> (latlng: Leaflet.LatLngTuple, ?options: Leaflet.MarkerOptions) : Leaflet.Marker<'P> = nativeOnly
        [<Import("marker", "leaflet")>]
        static member marker<'P> (latlng: Leaflet.LatLngExpression, ?options: Leaflet.MarkerOptions) : Leaflet.Marker<'P> = nativeOnly
        [<Import("marker", "leaflet")>]
        static member marker (latlng: Leaflet.LatLng, ?options: Leaflet.MarkerOptions) : Leaflet.Marker<obj> = nativeOnly
        [<Import("marker", "leaflet")>]
        static member marker (latlng: Leaflet.LatLngLiteral, ?options: Leaflet.MarkerOptions) : Leaflet.Marker<obj> = nativeOnly
        [<Import("marker", "leaflet")>]
        static member marker (latlng: Leaflet.LatLngTuple, ?options: Leaflet.MarkerOptions) : Leaflet.Marker<obj> = nativeOnly
        [<Import("marker", "leaflet")>]
        static member marker (latlng: Leaflet.LatLngExpression, ?options: Leaflet.MarkerOptions) : Leaflet.Marker<obj> = nativeOnly
        [<Import("extend", "leaflet")>]
        static member inline extend: Exports.extend__.Type = nativeOnly
        [<Import("bind", "leaflet")>]
        static member inline bind: Exports.bind__.Type = nativeOnly
        [<Import("stamp", "leaflet")>]
        static member inline stamp: (obj -> float) = nativeOnly
        [<Import("setOptions", "leaflet")>]
        static member inline setOptions: Exports.setOptions__.Type = nativeOnly
        [<Import("noConflict", "leaflet")>]
        static member noConflict () : obj = nativeOnly
        [<Import("Class", "leaflet"); EmitConstructor>]
        static member Class () : Class = nativeOnly
        [<Import("Transformation", "leaflet"); EmitConstructor>]
        static member Transformation (a: float, b: float, c: float, d: float) : Transformation = nativeOnly
        [<Import("PosAnimation", "leaflet"); EmitConstructor>]
        static member PosAnimation () : PosAnimation = nativeOnly
        [<Import("LatLng", "leaflet"); EmitConstructor>]
        static member LatLng (latitude: float, longitude: float, ?altitude: float) : LatLng = nativeOnly
        [<Import("LatLngBounds", "leaflet"); EmitConstructor>]
        static member LatLngBounds (southWest: Leaflet.LatLng, northEast: Leaflet.LatLng) : LatLngBounds = nativeOnly
        [<Import("LatLngBounds", "leaflet"); EmitConstructor>]
        static member LatLngBounds (southWest: Leaflet.LatLng, northEast: Leaflet.LatLngLiteral) : LatLngBounds = nativeOnly
        [<Import("LatLngBounds", "leaflet"); EmitConstructor>]
        static member LatLngBounds (southWest: Leaflet.LatLng, northEast: Leaflet.LatLngTuple) : LatLngBounds = nativeOnly
        [<Import("LatLngBounds", "leaflet"); EmitConstructor>]
        static member LatLngBounds (southWest: Leaflet.LatLngLiteral, northEast: Leaflet.LatLng) : LatLngBounds = nativeOnly
        [<Import("LatLngBounds", "leaflet"); EmitConstructor>]
        static member LatLngBounds (southWest: Leaflet.LatLngLiteral, northEast: Leaflet.LatLngLiteral) : LatLngBounds = nativeOnly
        [<Import("LatLngBounds", "leaflet"); EmitConstructor>]
        static member LatLngBounds (southWest: Leaflet.LatLngLiteral, northEast: Leaflet.LatLngTuple) : LatLngBounds = nativeOnly
        [<Import("LatLngBounds", "leaflet"); EmitConstructor>]
        static member LatLngBounds (southWest: Leaflet.LatLngTuple, northEast: Leaflet.LatLng) : LatLngBounds = nativeOnly
        [<Import("LatLngBounds", "leaflet"); EmitConstructor>]
        static member LatLngBounds (southWest: Leaflet.LatLngTuple, northEast: Leaflet.LatLngLiteral) : LatLngBounds = nativeOnly
        [<Import("LatLngBounds", "leaflet"); EmitConstructor>]
        static member LatLngBounds (southWest: Leaflet.LatLngTuple, northEast: Leaflet.LatLngTuple) : LatLngBounds = nativeOnly
        [<Import("LatLngBounds", "leaflet"); EmitConstructor>]
        static member LatLngBounds (southWest: Leaflet.LatLngExpression, northEast: Leaflet.LatLngExpression) : LatLngBounds = nativeOnly
        [<Import("LatLngBounds", "leaflet"); EmitConstructor>]
        static member LatLngBounds (latlngs: ResizeArray<Leaflet.LatLngExpression>) : LatLngBounds = nativeOnly
        [<Import("Point", "leaflet"); EmitConstructor>]
        static member Point (x: float, y: float, ?round: bool) : Point = nativeOnly
        [<Import("Bounds", "leaflet"); EmitConstructor>]
        static member Bounds (topLeft: Leaflet.Point, bottomRight: Leaflet.Point) : Bounds = nativeOnly
        [<Import("Bounds", "leaflet"); EmitConstructor>]
        static member Bounds (topLeft: Leaflet.Point, bottomRight: Leaflet.PointTuple) : Bounds = nativeOnly
        [<Import("Bounds", "leaflet"); EmitConstructor>]
        static member Bounds (topLeft: Leaflet.PointTuple, bottomRight: Leaflet.Point) : Bounds = nativeOnly
        [<Import("Bounds", "leaflet"); EmitConstructor>]
        static member Bounds (topLeft: Leaflet.PointTuple, bottomRight: Leaflet.PointTuple) : Bounds = nativeOnly
        [<Import("Bounds", "leaflet"); EmitConstructor>]
        static member Bounds (topLeft: Leaflet.PointExpression, bottomRight: Leaflet.PointExpression) : Bounds = nativeOnly
        [<Import("Bounds", "leaflet"); EmitConstructor>]
        static member Bounds () : Bounds = nativeOnly
        [<Import("Bounds", "leaflet"); EmitConstructor>]
        static member Bounds (points: ResizeArray<Leaflet.Point>) : Bounds = nativeOnly
        [<Import("Bounds", "leaflet"); EmitConstructor>]
        static member Bounds (points: Leaflet.BoundsLiteral) : Bounds = nativeOnly
        [<Import("Evented", "leaflet"); EmitConstructor>]
        static member Evented () : Evented = nativeOnly
        [<Import("Draggable", "leaflet"); EmitConstructor>]
        static member Draggable (element: Glutinum.Web.HTMLElement, ?dragStartTarget: Glutinum.Web.HTMLElement, ?preventOutline: bool, ?options: Leaflet.DraggableOptions) : Draggable = nativeOnly
        [<Import("Layer", "leaflet"); EmitConstructor>]
        static member Layer (?options: Leaflet.LayerOptions) : Layer = nativeOnly
        [<Import("GridLayer", "leaflet"); EmitConstructor>]
        static member GridLayer (?options: Leaflet.GridLayerOptions) : GridLayer = nativeOnly
        [<Import("TileLayer", "leaflet"); EmitConstructor>]
        static member TileLayer (urlTemplate: string, ?options: Leaflet.TileLayerOptions) : TileLayer = nativeOnly
        [<Import("ImageOverlay", "leaflet"); EmitConstructor>]
        static member ImageOverlay (imageUrl: string, bounds: Leaflet.LatLngBounds, ?options: Leaflet.ImageOverlayOptions) : ImageOverlay = nativeOnly
        [<Import("ImageOverlay", "leaflet"); EmitConstructor>]
        static member ImageOverlay (imageUrl: string, bounds: Leaflet.LatLngBoundsLiteral, ?options: Leaflet.ImageOverlayOptions) : ImageOverlay = nativeOnly
        [<Import("ImageOverlay", "leaflet"); EmitConstructor>]
        static member ImageOverlay (imageUrl: string, bounds: Leaflet.LatLngBoundsExpression, ?options: Leaflet.ImageOverlayOptions) : ImageOverlay = nativeOnly
        /// <summary>
        /// SVGOverlay doesn't extend ImageOverlay because SVGOverlay.getElement returns SVGElement
        /// </summary>
        [<Import("SVGOverlay", "leaflet"); EmitConstructor>]
        static member SVGOverlay (svgImage: string, bounds: Leaflet.LatLngBounds, ?options: Leaflet.ImageOverlayOptions) : SVGOverlay = nativeOnly
        /// <summary>
        /// SVGOverlay doesn't extend ImageOverlay because SVGOverlay.getElement returns SVGElement
        /// </summary>
        [<Import("SVGOverlay", "leaflet"); EmitConstructor>]
        static member SVGOverlay (svgImage: string, bounds: Leaflet.LatLngBoundsLiteral, ?options: Leaflet.ImageOverlayOptions) : SVGOverlay = nativeOnly
        /// <summary>
        /// SVGOverlay doesn't extend ImageOverlay because SVGOverlay.getElement returns SVGElement
        /// </summary>
        [<Import("SVGOverlay", "leaflet"); EmitConstructor>]
        static member SVGOverlay (svgImage: Glutinum.Web.SVGElement, bounds: Leaflet.LatLngBounds, ?options: Leaflet.ImageOverlayOptions) : SVGOverlay = nativeOnly
        /// <summary>
        /// SVGOverlay doesn't extend ImageOverlay because SVGOverlay.getElement returns SVGElement
        /// </summary>
        [<Import("SVGOverlay", "leaflet"); EmitConstructor>]
        static member SVGOverlay (svgImage: Glutinum.Web.SVGElement, bounds: Leaflet.LatLngBoundsLiteral, ?options: Leaflet.ImageOverlayOptions) : SVGOverlay = nativeOnly
        /// <summary>
        /// SVGOverlay doesn't extend ImageOverlay because SVGOverlay.getElement returns SVGElement
        /// </summary>
        [<Import("SVGOverlay", "leaflet"); EmitConstructor>]
        static member SVGOverlay (svgImage: U2<string, Glutinum.Web.SVGElement>, bounds: Leaflet.LatLngBoundsExpression, ?options: Leaflet.ImageOverlayOptions) : SVGOverlay = nativeOnly
        /// <summary>
        /// VideoOverlay doesn't extend ImageOverlay because VideoOverlay.getElement returns HTMLImageElement
        /// </summary>
        [<Import("VideoOverlay", "leaflet"); EmitConstructor>]
        static member VideoOverlay (video: string, bounds: Leaflet.LatLngBounds, ?options: Leaflet.VideoOverlayOptions) : VideoOverlay = nativeOnly
        /// <summary>
        /// VideoOverlay doesn't extend ImageOverlay because VideoOverlay.getElement returns HTMLImageElement
        /// </summary>
        [<Import("VideoOverlay", "leaflet"); EmitConstructor>]
        static member VideoOverlay (video: string, bounds: Leaflet.LatLngBoundsLiteral, ?options: Leaflet.VideoOverlayOptions) : VideoOverlay = nativeOnly
        /// <summary>
        /// VideoOverlay doesn't extend ImageOverlay because VideoOverlay.getElement returns HTMLImageElement
        /// </summary>
        [<Import("VideoOverlay", "leaflet"); EmitConstructor>]
        static member VideoOverlay (video: ResizeArray<string>, bounds: Leaflet.LatLngBounds, ?options: Leaflet.VideoOverlayOptions) : VideoOverlay = nativeOnly
        /// <summary>
        /// VideoOverlay doesn't extend ImageOverlay because VideoOverlay.getElement returns HTMLImageElement
        /// </summary>
        [<Import("VideoOverlay", "leaflet"); EmitConstructor>]
        static member VideoOverlay (video: ResizeArray<string>, bounds: Leaflet.LatLngBoundsLiteral, ?options: Leaflet.VideoOverlayOptions) : VideoOverlay = nativeOnly
        /// <summary>
        /// VideoOverlay doesn't extend ImageOverlay because VideoOverlay.getElement returns HTMLImageElement
        /// </summary>
        [<Import("VideoOverlay", "leaflet"); EmitConstructor>]
        static member VideoOverlay (video: Glutinum.Web.HTMLVideoElement, bounds: Leaflet.LatLngBounds, ?options: Leaflet.VideoOverlayOptions) : VideoOverlay = nativeOnly
        /// <summary>
        /// VideoOverlay doesn't extend ImageOverlay because VideoOverlay.getElement returns HTMLImageElement
        /// </summary>
        [<Import("VideoOverlay", "leaflet"); EmitConstructor>]
        static member VideoOverlay (video: Glutinum.Web.HTMLVideoElement, bounds: Leaflet.LatLngBoundsLiteral, ?options: Leaflet.VideoOverlayOptions) : VideoOverlay = nativeOnly
        /// <summary>
        /// VideoOverlay doesn't extend ImageOverlay because VideoOverlay.getElement returns HTMLImageElement
        /// </summary>
        [<Import("VideoOverlay", "leaflet"); EmitConstructor>]
        static member VideoOverlay (video: U3<string, ResizeArray<string>, Glutinum.Web.HTMLVideoElement>, bounds: Leaflet.LatLngBoundsExpression, ?options: Leaflet.VideoOverlayOptions) : VideoOverlay = nativeOnly
        [<Import("Path", "leaflet"); EmitConstructor>]
        static member Path () : Path = nativeOnly
        [<Import("Polyline", "leaflet"); EmitConstructor>]
        static member Polyline<'T, 'P> (latlngs: ResizeArray<Leaflet.LatLngExpression>, ?options: Leaflet.PolylineOptions) : Polyline<'T, 'P> = nativeOnly
        [<Import("Polyline", "leaflet"); EmitConstructor>]
        static member Polyline<'T, 'P> (latlngs: ResizeArray<ResizeArray<Leaflet.LatLngExpression>>, ?options: Leaflet.PolylineOptions) : Polyline<'T, 'P> = nativeOnly
        [<Import("Polyline", "leaflet"); EmitConstructor>]
        static member Polyline<'T, 'P> (latlngs: U2<ResizeArray<Leaflet.LatLngExpression>, ResizeArray<ResizeArray<Leaflet.LatLngExpression>>>, ?options: Leaflet.PolylineOptions) : Polyline<'T, 'P> = nativeOnly
        [<Import("Polygon", "leaflet"); EmitConstructor>]
        static member Polygon<'P> (latlngs: ResizeArray<Leaflet.LatLngExpression>, ?options: Leaflet.PolylineOptions) : Polygon<'P> = nativeOnly
        [<Import("Polygon", "leaflet"); EmitConstructor>]
        static member Polygon<'P> (latlngs: ResizeArray<ResizeArray<Leaflet.LatLngExpression>>, ?options: Leaflet.PolylineOptions) : Polygon<'P> = nativeOnly
        [<Import("Polygon", "leaflet"); EmitConstructor>]
        static member Polygon<'P> (latlngs: ResizeArray<ResizeArray<ResizeArray<Leaflet.LatLngExpression>>>, ?options: Leaflet.PolylineOptions) : Polygon<'P> = nativeOnly
        [<Import("Polygon", "leaflet"); EmitConstructor>]
        static member Polygon<'P> (latlngs: U3<ResizeArray<Leaflet.LatLngExpression>, ResizeArray<ResizeArray<Leaflet.LatLngExpression>>, ResizeArray<ResizeArray<ResizeArray<Leaflet.LatLngExpression>>>>, ?options: Leaflet.PolylineOptions) : Polygon<'P> = nativeOnly
        [<Import("Rectangle", "leaflet"); EmitConstructor>]
        static member Rectangle<'P> (latLngBounds: Leaflet.LatLngBounds, ?options: Leaflet.PolylineOptions) : Rectangle<'P> = nativeOnly
        [<Import("Rectangle", "leaflet"); EmitConstructor>]
        static member Rectangle<'P> (latLngBounds: Leaflet.LatLngBoundsLiteral, ?options: Leaflet.PolylineOptions) : Rectangle<'P> = nativeOnly
        [<Import("Rectangle", "leaflet"); EmitConstructor>]
        static member Rectangle<'P> (latLngBounds: Leaflet.LatLngBoundsExpression, ?options: Leaflet.PolylineOptions) : Rectangle<'P> = nativeOnly
        [<Import("CircleMarker", "leaflet"); EmitConstructor>]
        static member CircleMarker<'P> (latlng: Leaflet.LatLng, options: Leaflet.CircleMarkerOptions) : CircleMarker<'P> = nativeOnly
        [<Import("CircleMarker", "leaflet"); EmitConstructor>]
        static member CircleMarker<'P> (latlng: Leaflet.LatLngLiteral, options: Leaflet.CircleMarkerOptions) : CircleMarker<'P> = nativeOnly
        [<Import("CircleMarker", "leaflet"); EmitConstructor>]
        static member CircleMarker<'P> (latlng: Leaflet.LatLngTuple, options: Leaflet.CircleMarkerOptions) : CircleMarker<'P> = nativeOnly
        [<Import("CircleMarker", "leaflet"); EmitConstructor>]
        static member CircleMarker<'P> (latlng: Leaflet.LatLngExpression, options: Leaflet.CircleMarkerOptions) : CircleMarker<'P> = nativeOnly
        [<Import("Circle", "leaflet"); EmitConstructor>]
        static member Circle<'P> (latlng: Leaflet.LatLng, options: Leaflet.CircleOptions) : Circle<'P> = nativeOnly
        [<Import("Circle", "leaflet"); EmitConstructor>]
        static member Circle<'P> (latlng: Leaflet.LatLngLiteral, options: Leaflet.CircleOptions) : Circle<'P> = nativeOnly
        [<Import("Circle", "leaflet"); EmitConstructor>]
        static member Circle<'P> (latlng: Leaflet.LatLngTuple, options: Leaflet.CircleOptions) : Circle<'P> = nativeOnly
        [<Import("Circle", "leaflet"); EmitConstructor>]
        static member Circle<'P> (latlng: Leaflet.LatLngExpression, options: Leaflet.CircleOptions) : Circle<'P> = nativeOnly
        [<Import("Circle", "leaflet"); EmitConstructor>]
        static member Circle<'P> (latlng: Leaflet.LatLng, radius: float, ?options: Leaflet.CircleOptions) : Circle<'P> = nativeOnly
        [<Import("Circle", "leaflet"); EmitConstructor>]
        static member Circle<'P> (latlng: Leaflet.LatLngLiteral, radius: float, ?options: Leaflet.CircleOptions) : Circle<'P> = nativeOnly
        [<Import("Circle", "leaflet"); EmitConstructor>]
        static member Circle<'P> (latlng: Leaflet.LatLngTuple, radius: float, ?options: Leaflet.CircleOptions) : Circle<'P> = nativeOnly
        [<Import("Circle", "leaflet"); EmitConstructor>]
        static member Circle<'P> (latlng: Leaflet.LatLngExpression, radius: float, ?options: Leaflet.CircleOptions) : Circle<'P> = nativeOnly
        [<Import("Renderer", "leaflet"); EmitConstructor>]
        static member Renderer (?options: Leaflet.RendererOptions) : Renderer = nativeOnly
        [<Import("SVG", "leaflet"); EmitConstructor>]
        static member SVG () : SVG = nativeOnly
        [<Import("Canvas", "leaflet"); EmitConstructor>]
        static member Canvas () : Canvas = nativeOnly
        [<Import("LayerGroup", "leaflet"); EmitConstructor>]
        static member LayerGroup<'P> (?layers: ResizeArray<Leaflet.Layer>, ?options: Leaflet.LayerOptions) : LayerGroup<'P> = nativeOnly
        [<Import("FeatureGroup", "leaflet"); EmitConstructor>]
        static member FeatureGroup<'P> () : FeatureGroup<'P> = nativeOnly
        [<Import("GeoJSON", "leaflet"); EmitConstructor>]
        static member GeoJSON<'P, 'G> (?geojson: Glutinum.Geojson.GeoJsonObject, ?options: Leaflet.GeoJSONOptions<'P, 'G>) : GeoJSON<'P, 'G> = nativeOnly
        [<Import("Control", "leaflet"); EmitConstructor>]
        static member Control<'Options> (?options: 'Options) : Control<'Options> = nativeOnly
        [<Import("DivOverlay", "leaflet"); EmitConstructor>]
        static member DivOverlay (latlng: Leaflet.LatLng, ?options: Leaflet.TooltipOptions) : DivOverlay = nativeOnly
        [<Import("DivOverlay", "leaflet"); EmitConstructor>]
        static member DivOverlay (latlng: Leaflet.LatLngLiteral, ?options: Leaflet.TooltipOptions) : DivOverlay = nativeOnly
        [<Import("DivOverlay", "leaflet"); EmitConstructor>]
        static member DivOverlay (latlng: Leaflet.LatLngTuple, ?options: Leaflet.TooltipOptions) : DivOverlay = nativeOnly
        [<Import("DivOverlay", "leaflet"); EmitConstructor>]
        static member DivOverlay (latlng: Leaflet.LatLngExpression, ?options: Leaflet.TooltipOptions) : DivOverlay = nativeOnly
        [<Import("DivOverlay", "leaflet"); EmitConstructor>]
        static member DivOverlay (?options: Leaflet.DivOverlayOptions, ?source: Leaflet.Layer) : DivOverlay = nativeOnly
        [<Import("Popup", "leaflet"); EmitConstructor>]
        static member Popup (latlng: Leaflet.LatLng, ?options: Leaflet.TooltipOptions) : Popup = nativeOnly
        [<Import("Popup", "leaflet"); EmitConstructor>]
        static member Popup (latlng: Leaflet.LatLngLiteral, ?options: Leaflet.TooltipOptions) : Popup = nativeOnly
        [<Import("Popup", "leaflet"); EmitConstructor>]
        static member Popup (latlng: Leaflet.LatLngTuple, ?options: Leaflet.TooltipOptions) : Popup = nativeOnly
        [<Import("Popup", "leaflet"); EmitConstructor>]
        static member Popup (latlng: Leaflet.LatLngExpression, ?options: Leaflet.TooltipOptions) : Popup = nativeOnly
        [<Import("Popup", "leaflet"); EmitConstructor>]
        static member Popup (?options: Leaflet.PopupOptions, ?source: Leaflet.Layer) : Popup = nativeOnly
        [<Import("Tooltip", "leaflet"); EmitConstructor>]
        static member Tooltip (latlng: Leaflet.LatLng, ?options: Leaflet.TooltipOptions) : Tooltip = nativeOnly
        [<Import("Tooltip", "leaflet"); EmitConstructor>]
        static member Tooltip (latlng: Leaflet.LatLngLiteral, ?options: Leaflet.TooltipOptions) : Tooltip = nativeOnly
        [<Import("Tooltip", "leaflet"); EmitConstructor>]
        static member Tooltip (latlng: Leaflet.LatLngTuple, ?options: Leaflet.TooltipOptions) : Tooltip = nativeOnly
        [<Import("Tooltip", "leaflet"); EmitConstructor>]
        static member Tooltip (latlng: Leaflet.LatLngExpression, ?options: Leaflet.TooltipOptions) : Tooltip = nativeOnly
        [<Import("Tooltip", "leaflet"); EmitConstructor>]
        static member Tooltip (?options: Leaflet.TooltipOptions, ?source: Leaflet.Layer) : Tooltip = nativeOnly
        [<Import("Handler", "leaflet"); EmitConstructor>]
        static member Handler (map: Leaflet.Map) : Handler = nativeOnly
        [<Import("Map", "leaflet"); EmitConstructor>]
        static member Map (element: string, ?options: Leaflet.MapOptions) : Map = nativeOnly
        [<Import("Map", "leaflet"); EmitConstructor>]
        static member Map (element: Glutinum.Web.HTMLElement, ?options: Leaflet.MapOptions) : Map = nativeOnly
        [<Import("Map", "leaflet"); EmitConstructor>]
        static member Map (element: U2<string, Glutinum.Web.HTMLElement>, ?options: Leaflet.MapOptions) : Map = nativeOnly
        [<Import("Icon", "leaflet"); EmitConstructor>]
        static member Icon<'T> (options: 'T) : Icon<'T> = nativeOnly
        [<Import("DivIcon", "leaflet"); EmitConstructor>]
        static member DivIcon (?options: Leaflet.DivIconOptions) : DivIcon = nativeOnly
        [<Import("Marker", "leaflet"); EmitConstructor>]
        static member Marker<'P> (latlng: Leaflet.LatLng, ?options: Leaflet.MarkerOptions) : Marker<'P> = nativeOnly
        [<Import("Marker", "leaflet"); EmitConstructor>]
        static member Marker<'P> (latlng: Leaflet.LatLngLiteral, ?options: Leaflet.MarkerOptions) : Marker<'P> = nativeOnly
        [<Import("Marker", "leaflet"); EmitConstructor>]
        static member Marker<'P> (latlng: Leaflet.LatLngTuple, ?options: Leaflet.MarkerOptions) : Marker<'P> = nativeOnly
        [<Import("Marker", "leaflet"); EmitConstructor>]
        static member Marker<'P> (latlng: Leaflet.LatLngExpression, ?options: Leaflet.MarkerOptions) : Marker<'P> = nativeOnly
        [<ImportAll("leaflet")>]
        static member inline LineUtil
            with get () : LineUtil_.Exports =
                nativeOnly
        [<ImportAll("leaflet")>]
        static member inline PolyUtil
            with get () : PolyUtil_.Exports =
                nativeOnly
        [<ImportAll("leaflet")>]
        static member inline DomUtil
            with get () : DomUtil_.Exports =
                nativeOnly
        [<ImportAll("leaflet")>]
        static member inline CRS
            with get () : CRS_.Exports =
                nativeOnly
        [<ImportAll("leaflet")>]
        static member inline Projection
            with get () : Projection_.Exports =
                nativeOnly
        [<ImportAll("leaflet")>]
        static member inline TileLayer_
            with get () : TileLayer_.Exports =
                nativeOnly
        [<ImportAll("leaflet")>]
        static member inline tileLayer_
            with get () : tileLayer_.Exports =
                nativeOnly
        [<ImportAll("leaflet")>]
        static member inline SVG_
            with get () : SVG_.Exports =
                nativeOnly
        [<ImportAll("leaflet")>]
        static member inline Control_
            with get () : Control_.Exports =
                nativeOnly
        [<ImportAll("leaflet")>]
        static member inline control
            with get () : control_.Exports =
                nativeOnly
        [<ImportAll("leaflet")>]
        static member inline DomEvent
            with get () : DomEvent_.Exports =
                nativeOnly
        [<ImportAll("leaflet")>]
        static member inline Icon_
            with get () : Icon_.Exports =
                nativeOnly
        [<ImportAll("leaflet")>]
        static member inline Browser
            with get () : Browser_.Exports =
                nativeOnly
        [<ImportAll("leaflet")>]
        static member inline Util
            with get () : Util_.Exports =
                nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type Class =
        [<Emit("""import { Class } from "leaflet";
Class.extend($0)""")>]
        static member inline extend (props: obj): obj = nativeOnly
        [<Emit("""import { Class } from "leaflet";
Class.include($0)""")>]
        static member inline ``include`` (props: obj): obj = nativeOnly
        [<Emit("""import { Class } from "leaflet";
Class.mergeOptions($0)""")>]
        static member inline mergeOptions (props: obj): obj = nativeOnly
        [<Emit("""import { Class } from "leaflet";
Class.addInitHook($0)""")>]
        static member inline addInitHook (initHookFn: (unit -> unit)): obj = nativeOnly
        [<Emit("""import { Class } from "leaflet";
Class.addInitHook($0, $1)""")>]
        static member inline addInitHook (methodName: string, [<ParamArray>] args: obj []): obj = nativeOnly
        [<Emit("""import { Class } from "leaflet";
Class.callInitHooks()""")>]
        static member inline callInitHooks () : unit = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type Transformation =
        abstract member transform: point: Leaflet.Point * ?scale: float -> Leaflet.Point
        abstract member untransform: point: Leaflet.Point * ?scale: float -> Leaflet.Point

    module LineUtil_ =

        [<AbstractClass>]
        [<Erase>]
        type Exports =
            [<Emit("$0.simplify($1...)")>]
            abstract member simplify: points: ResizeArray<Leaflet.Point> * tolerance: float -> ResizeArray<Leaflet.Point>
            [<Emit("$0.pointToSegmentDistance($1...)")>]
            abstract member pointToSegmentDistance: p: Leaflet.Point * p1: Leaflet.Point * p2: Leaflet.Point -> float
            [<Emit("$0.closestPointOnSegment($1...)")>]
            abstract member closestPointOnSegment: p: Leaflet.Point * p1: Leaflet.Point * p2: Leaflet.Point -> Leaflet.Point
            [<Emit("$0.isFlat($1...)")>]
            abstract member isFlat: latlngs: ResizeArray<Leaflet.LatLngExpression> -> bool
            [<Emit("$0.clipSegment($1...)")>]
            abstract member clipSegment: a: Leaflet.Point * b: Leaflet.Point * bounds: Leaflet.Bounds * ?useLastCode: bool * ?round: bool -> U2<Leaflet.Point * Leaflet.Point, bool>
            [<Emit("$0.polylineCenter($1...)")>]
            abstract member polylineCenter: latlngs: ResizeArray<Leaflet.LatLngExpression> * crs: Leaflet.CRS -> Leaflet.LatLng

    module PolyUtil_ =

        [<AbstractClass>]
        [<Erase>]
        type Exports =
            [<Emit("$0.clipPolygon($1...)")>]
            abstract member clipPolygon: points: ResizeArray<Leaflet.Point> * bounds: Leaflet.Bounds * ?round: bool -> ResizeArray<Leaflet.Point>
            [<Emit("$0.clipPolygon($1...)")>]
            abstract member clipPolygon: points: ResizeArray<Leaflet.Point> * bounds: Leaflet.BoundsLiteral * ?round: bool -> ResizeArray<Leaflet.Point>
            [<Emit("$0.clipPolygon($1...)")>]
            abstract member clipPolygon: points: ResizeArray<Leaflet.Point> * bounds: Leaflet.BoundsExpression * ?round: bool -> ResizeArray<Leaflet.Point>
            [<Emit("$0.polygonCenter($1...)")>]
            abstract member polygonCenter: latlngs: ResizeArray<Leaflet.LatLngExpression> * crs: Leaflet.CRS -> Leaflet.LatLng

    module DomUtil_ =

        [<AbstractClass>]
        [<Erase>]
        type Exports =
            /// <summary>
            /// Get Element by its ID or with the given HTML-Element
            /// </summary>
            [<Emit("$0.get($1...)")>]
            abstract member get: element: string -> Glutinum.Web.HTMLElement option
            /// <summary>
            /// Get Element by its ID or with the given HTML-Element
            /// </summary>
            [<Emit("$0.get($1...)")>]
            abstract member get: element: Glutinum.Web.HTMLElement -> Glutinum.Web.HTMLElement option
            /// <summary>
            /// Get Element by its ID or with the given HTML-Element
            /// </summary>
            [<Emit("$0.get($1...)")>]
            abstract member get: element: U2<string, Glutinum.Web.HTMLElement> -> Glutinum.Web.HTMLElement option
            [<Emit("$0.getStyle($1...)")>]
            abstract member getStyle: el: Glutinum.Web.HTMLElement * styleAttrib: string -> string option
            /// <summary>
            /// Creates an HTML element with <c>tagName</c>, sets its class to <c>className</c>, and optionally appends it to <c>container</c> element.
            /// </summary>
            /// <param name="tagName">
            /// The name of the tag to create (for example: <c>div</c> or <c>canvas</c>).
            /// </param>
            /// <param name="className">
            /// The class to set on the created element.
            /// </param>
            /// <param name="container">
            /// The container to append the created element to.
            /// </param>
            [<Emit("$0.create($1...)")>]
            abstract member create<'T>: tagName: Glutinum.Web.HTMLElementTagNameMap.Key<'T> * ?className: string * ?container: Glutinum.Web.HTMLElement -> 'T
            [<Emit("$0.create($1...)")>]
            abstract member create: tagName: string * ?className: string * ?container: Glutinum.Web.HTMLElement -> Glutinum.Web.HTMLElement
            [<Emit("$0.remove($1...)")>]
            abstract member remove: el: Glutinum.Web.HTMLElement -> unit
            [<Emit("$0.empty($1...)")>]
            abstract member empty: el: Glutinum.Web.HTMLElement -> unit
            [<Emit("$0.toFront($1...)")>]
            abstract member toFront: el: Glutinum.Web.HTMLElement -> unit
            [<Emit("$0.toBack($1...)")>]
            abstract member toBack: el: Glutinum.Web.HTMLElement -> unit
            [<Emit("$0.hasClass($1...)")>]
            abstract member hasClass: el: Glutinum.Web.HTMLElement * name: string -> bool
            [<Emit("$0.addClass($1...)")>]
            abstract member addClass: el: Glutinum.Web.HTMLElement * name: string -> unit
            [<Emit("$0.removeClass($1...)")>]
            abstract member removeClass: el: Glutinum.Web.HTMLElement * name: string -> unit
            [<Emit("$0.setClass($1...)")>]
            abstract member setClass: el: Glutinum.Web.HTMLElement * name: string -> unit
            [<Emit("$0.getClass($1...)")>]
            abstract member getClass: el: Glutinum.Web.HTMLElement -> string
            [<Emit("$0.setOpacity($1...)")>]
            abstract member setOpacity: el: Glutinum.Web.HTMLElement * opacity: float -> unit
            [<Emit("$0.testProp($1...)")>]
            abstract member testProp: props: ResizeArray<string> -> U2<string, bool>
            [<Emit("$0.setTransform($1...)")>]
            abstract member setTransform: el: Glutinum.Web.HTMLElement * offset: Leaflet.Point * ?scale: float -> unit
            [<Emit("$0.setPosition($1...)")>]
            abstract member setPosition: el: Glutinum.Web.HTMLElement * position: Leaflet.Point -> unit
            [<Emit("$0.getPosition($1...)")>]
            abstract member getPosition: el: Glutinum.Web.HTMLElement -> Leaflet.Point
            [<Emit("$0.getScale($1...)")>]
            abstract member getScale: el: Glutinum.Web.HTMLElement -> Exports.getScale
            [<Emit("$0.getSizedParentNode($1...)")>]
            abstract member getSizedParentNode: el: Glutinum.Web.HTMLElement -> Glutinum.Web.HTMLElement
            [<Emit("$0.disableTextSelection($1...)")>]
            abstract member disableTextSelection: unit -> unit
            [<Emit("$0.enableTextSelection($1...)")>]
            abstract member enableTextSelection: unit -> unit
            [<Emit("$0.disableImageDrag($1...)")>]
            abstract member disableImageDrag: unit -> unit
            [<Emit("$0.enableImageDrag($1...)")>]
            abstract member enableImageDrag: unit -> unit
            [<Emit("$0.preventOutline($1...)")>]
            abstract member preventOutline: el: Glutinum.Web.HTMLElement -> unit
            [<Emit("$0.restoreOutline($1...)")>]
            abstract member restoreOutline: unit -> unit
            [<Emit("$0.TRANSFORM")>]
            abstract member TRANSFORM: string
            [<Emit("$0.TRANSITION")>]
            abstract member TRANSITION: string
            [<Emit("$0.TRANSITION_END")>]
            abstract member TRANSITION_END: string

        module Exports =

            [<AllowNullLiteral>]
            [<Interface>]
            type getScale =
                abstract member x: float with get, set
                abstract member y: float with get, set
                abstract member boundingClientRect: Glutinum.Web.DOMRect with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (x: float, y: float, boundingClientRect: Glutinum.Web.DOMRect) : getScale = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type PosAnimation =
        inherit Leaflet.Evented
        abstract member run: el: Glutinum.Web.HTMLElement * newPos: Leaflet.Point * ?duration: float * ?easeLinearity: float -> unit
        abstract member stop: unit -> unit

    [<AllowNullLiteral>]
    [<Interface>]
    type CRS =
        abstract member latLngToPoint: latlng: Leaflet.LatLng * zoom: float -> Leaflet.Point
        abstract member latLngToPoint: latlng: Leaflet.LatLngLiteral * zoom: float -> Leaflet.Point
        abstract member latLngToPoint: latlng: Leaflet.LatLngTuple * zoom: float -> Leaflet.Point
        abstract member latLngToPoint: latlng: Leaflet.LatLngExpression * zoom: float -> Leaflet.Point
        abstract member pointToLatLng: point: Leaflet.Point * zoom: float -> Leaflet.LatLng
        abstract member pointToLatLng: point: Leaflet.PointTuple * zoom: float -> Leaflet.LatLng
        abstract member pointToLatLng: point: Leaflet.PointExpression * zoom: float -> Leaflet.LatLng
        abstract member project: latlng: Leaflet.LatLng -> Leaflet.Point
        abstract member project: latlng: Leaflet.LatLngLiteral -> Leaflet.Point
        abstract member project: latlng: U2<Leaflet.LatLng, Leaflet.LatLngLiteral> -> Leaflet.Point
        abstract member unproject: point: Leaflet.Point -> Leaflet.LatLng
        abstract member unproject: point: Leaflet.PointTuple -> Leaflet.LatLng
        abstract member unproject: point: Leaflet.PointExpression -> Leaflet.LatLng
        abstract member scale: zoom: float -> float
        abstract member zoom: scale: float -> float
        abstract member getProjectedBounds: zoom: float -> Leaflet.Bounds
        abstract member distance: latlng1: Leaflet.LatLng * latlng2: Leaflet.LatLng -> float
        abstract member distance: latlng1: Leaflet.LatLng * latlng2: Leaflet.LatLngLiteral -> float
        abstract member distance: latlng1: Leaflet.LatLng * latlng2: Leaflet.LatLngTuple -> float
        abstract member distance: latlng1: Leaflet.LatLngLiteral * latlng2: Leaflet.LatLng -> float
        abstract member distance: latlng1: Leaflet.LatLngLiteral * latlng2: Leaflet.LatLngLiteral -> float
        abstract member distance: latlng1: Leaflet.LatLngLiteral * latlng2: Leaflet.LatLngTuple -> float
        abstract member distance: latlng1: Leaflet.LatLngTuple * latlng2: Leaflet.LatLng -> float
        abstract member distance: latlng1: Leaflet.LatLngTuple * latlng2: Leaflet.LatLngLiteral -> float
        abstract member distance: latlng1: Leaflet.LatLngTuple * latlng2: Leaflet.LatLngTuple -> float
        abstract member distance: latlng1: Leaflet.LatLngExpression * latlng2: Leaflet.LatLngExpression -> float
        abstract member wrapLatLng: latlng: Leaflet.LatLng -> Leaflet.LatLng
        abstract member wrapLatLng: latlng: Leaflet.LatLngLiteral -> Leaflet.LatLng
        abstract member wrapLatLng: latlng: U2<Leaflet.LatLng, Leaflet.LatLngLiteral> -> Leaflet.LatLng
        abstract member code: string option with get, set
        abstract member wrapLng: float * float option with get, set
        abstract member wrapLat: float * float option with get, set
        abstract member infinite: bool with get, set

    module CRS_ =

        [<AbstractClass>]
        [<Erase>]
        type Exports =
            [<Emit("$0.EPSG3395")>]
            abstract member EPSG3395: Leaflet.CRS
            [<Emit("$0.EPSG3857")>]
            abstract member EPSG3857: Leaflet.CRS
            [<Emit("$0.EPSG4326")>]
            abstract member EPSG4326: Leaflet.CRS
            [<Emit("$0.EPSG900913")>]
            abstract member EPSG900913: Leaflet.CRS
            [<Emit("$0.Earth")>]
            abstract member Earth: Leaflet.CRS
            [<Emit("$0.Simple")>]
            abstract member Simple: Leaflet.CRS

    [<AllowNullLiteral>]
    [<Interface>]
    type Projection =
        abstract member project: latlng: Leaflet.LatLng -> Leaflet.Point
        abstract member project: latlng: Leaflet.LatLngLiteral -> Leaflet.Point
        abstract member project: latlng: U2<Leaflet.LatLng, Leaflet.LatLngLiteral> -> Leaflet.Point
        abstract member unproject: point: Leaflet.Point -> Leaflet.LatLng
        abstract member unproject: point: Leaflet.PointTuple -> Leaflet.LatLng
        abstract member unproject: point: Leaflet.PointExpression -> Leaflet.LatLng
        abstract member bounds: Leaflet.Bounds with get, set

    module Projection_ =

        [<AbstractClass>]
        [<Erase>]
        type Exports =
            [<Emit("$0.LonLat")>]
            abstract member LonLat: Leaflet.Projection
            [<Emit("$0.Mercator")>]
            abstract member Mercator: Leaflet.Projection
            [<Emit("$0.SphericalMercator")>]
            abstract member SphericalMercator: Leaflet.Projection

    [<AllowNullLiteral>]
    [<Interface>]
    type LatLng =
        abstract member equals: otherLatLng: Leaflet.LatLng * ?maxMargin: float -> bool
        abstract member equals: otherLatLng: Leaflet.LatLngLiteral * ?maxMargin: float -> bool
        abstract member equals: otherLatLng: Leaflet.LatLngTuple * ?maxMargin: float -> bool
        abstract member equals: otherLatLng: Leaflet.LatLngExpression * ?maxMargin: float -> bool
        abstract member toString: unit -> string
        abstract member distanceTo: otherLatLng: Leaflet.LatLng -> float
        abstract member distanceTo: otherLatLng: Leaflet.LatLngLiteral -> float
        abstract member distanceTo: otherLatLng: Leaflet.LatLngTuple -> float
        abstract member distanceTo: otherLatLng: Leaflet.LatLngExpression -> float
        abstract member wrap: unit -> Leaflet.LatLng
        abstract member toBounds: sizeInMeters: float -> Leaflet.LatLngBounds
        abstract member clone: unit -> Leaflet.LatLng
        abstract member lat: float with get, set
        abstract member lng: float with get, set
        abstract member alt: float option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type LatLngLiteral =
        abstract member lat: float with get, set
        abstract member lng: float with get, set
        abstract member alt: float option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (lat: float, lng: float, ?alt: float) : LatLngLiteral = nativeOnly

    type LatLngTuple =
        float * float * float option

    type LatLngExpression =
        U3<Leaflet.LatLng, Leaflet.LatLngLiteral, Leaflet.LatLngTuple>

    [<AllowNullLiteral>]
    [<Interface>]
    type LatLngBounds =
        abstract member extend: latlngOrBounds: Leaflet.LatLng -> LatLngBounds
        abstract member extend: latlngOrBounds: Leaflet.LatLngLiteral -> LatLngBounds
        abstract member extend: latlngOrBounds: Leaflet.LatLngTuple -> LatLngBounds
        abstract member extend: latlngOrBounds: Leaflet.LatLngBounds -> LatLngBounds
        abstract member extend: latlngOrBounds: Leaflet.LatLngBoundsLiteral -> LatLngBounds
        abstract member extend: latlngOrBounds: U2<Leaflet.LatLngExpression, Leaflet.LatLngBoundsExpression> -> LatLngBounds
        abstract member pad: bufferRatio: float -> Leaflet.LatLngBounds
        abstract member getCenter: unit -> Leaflet.LatLng
        abstract member getSouthWest: unit -> Leaflet.LatLng
        abstract member getNorthEast: unit -> Leaflet.LatLng
        abstract member getNorthWest: unit -> Leaflet.LatLng
        abstract member getSouthEast: unit -> Leaflet.LatLng
        abstract member getWest: unit -> float
        abstract member getSouth: unit -> float
        abstract member getEast: unit -> float
        abstract member getNorth: unit -> float
        abstract member contains: otherBoundsOrLatLng: Leaflet.LatLngBounds -> bool
        abstract member contains: otherBoundsOrLatLng: Leaflet.LatLngBoundsLiteral -> bool
        abstract member contains: otherBoundsOrLatLng: Leaflet.LatLng -> bool
        abstract member contains: otherBoundsOrLatLng: Leaflet.LatLngLiteral -> bool
        abstract member contains: otherBoundsOrLatLng: Leaflet.LatLngTuple -> bool
        abstract member contains: otherBoundsOrLatLng: U2<Leaflet.LatLngBoundsExpression, Leaflet.LatLngExpression> -> bool
        abstract member intersects: otherBounds: Leaflet.LatLngBounds -> bool
        abstract member intersects: otherBounds: Leaflet.LatLngBoundsLiteral -> bool
        abstract member intersects: otherBounds: Leaflet.LatLngBoundsExpression -> bool
        abstract member overlaps: otherBounds: Leaflet.LatLngBounds -> bool
        abstract member overlaps: otherBounds: Leaflet.LatLngBoundsLiteral -> bool
        abstract member overlaps: otherBounds: Leaflet.LatLngBoundsExpression -> bool
        abstract member toBBoxString: unit -> string
        abstract member equals: otherBounds: Leaflet.LatLngBounds * ?maxMargin: float -> bool
        abstract member equals: otherBounds: Leaflet.LatLngBoundsLiteral * ?maxMargin: float -> bool
        abstract member equals: otherBounds: Leaflet.LatLngBoundsExpression * ?maxMargin: float -> bool
        abstract member isValid: unit -> bool

    type LatLngBoundsLiteral =
        ResizeArray<Leaflet.LatLngTuple>

    type LatLngBoundsExpression =
        U2<Leaflet.LatLngBounds, Leaflet.LatLngBoundsLiteral>

    type PointTuple =
        float * float

    [<AllowNullLiteral>]
    [<Interface>]
    type Point =
        abstract member clone: unit -> Leaflet.Point
        abstract member add: otherPoint: Leaflet.Point -> Leaflet.Point
        abstract member add: otherPoint: Leaflet.PointTuple -> Leaflet.Point
        abstract member add: otherPoint: Leaflet.PointExpression -> Leaflet.Point
        abstract member subtract: otherPoint: Leaflet.Point -> Leaflet.Point
        abstract member subtract: otherPoint: Leaflet.PointTuple -> Leaflet.Point
        abstract member subtract: otherPoint: Leaflet.PointExpression -> Leaflet.Point
        abstract member divideBy: num: float -> Leaflet.Point
        abstract member multiplyBy: num: float -> Leaflet.Point
        abstract member scaleBy: scale: Leaflet.Point -> Leaflet.Point
        abstract member scaleBy: scale: Leaflet.PointTuple -> Leaflet.Point
        abstract member scaleBy: scale: Leaflet.PointExpression -> Leaflet.Point
        abstract member unscaleBy: scale: Leaflet.Point -> Leaflet.Point
        abstract member unscaleBy: scale: Leaflet.PointTuple -> Leaflet.Point
        abstract member unscaleBy: scale: Leaflet.PointExpression -> Leaflet.Point
        abstract member round: unit -> Leaflet.Point
        abstract member floor: unit -> Leaflet.Point
        abstract member ceil: unit -> Leaflet.Point
        abstract member trunc: unit -> Leaflet.Point
        abstract member distanceTo: otherPoint: Leaflet.Point -> float
        abstract member distanceTo: otherPoint: Leaflet.PointTuple -> float
        abstract member distanceTo: otherPoint: Leaflet.PointExpression -> float
        abstract member equals: otherPoint: Leaflet.Point -> bool
        abstract member equals: otherPoint: Leaflet.PointTuple -> bool
        abstract member equals: otherPoint: Leaflet.PointExpression -> bool
        abstract member contains: otherPoint: Leaflet.Point -> bool
        abstract member contains: otherPoint: Leaflet.PointTuple -> bool
        abstract member contains: otherPoint: Leaflet.PointExpression -> bool
        abstract member toString: unit -> string
        abstract member x: float with get, set
        abstract member y: float with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type Coords =
        inherit Leaflet.Point
        abstract member z: float with get, set

    type PointExpression =
        U2<Leaflet.Point, Leaflet.PointTuple>

    type BoundsLiteral =
        Leaflet.PointTuple * Leaflet.PointTuple

    [<AllowNullLiteral>]
    [<Interface>]
    type Bounds =
        abstract member extend: point: Leaflet.Point -> Bounds
        abstract member extend: point: Leaflet.PointTuple -> Bounds
        abstract member extend: point: Leaflet.PointExpression -> Bounds
        abstract member extend: otherBounds: Leaflet.Bounds -> Bounds
        abstract member extend: otherBounds: Leaflet.BoundsLiteral -> Bounds
        abstract member extend: otherBounds: Leaflet.BoundsExpression -> Bounds
        abstract member getCenter: ?round: bool -> Leaflet.Point
        abstract member getBottomLeft: unit -> Leaflet.Point
        abstract member getBottomRight: unit -> Leaflet.Point
        abstract member getTopLeft: unit -> Leaflet.Point
        abstract member getTopRight: unit -> Leaflet.Point
        abstract member getSize: unit -> Leaflet.Point
        abstract member contains: pointOrBounds: Leaflet.Bounds -> bool
        abstract member contains: pointOrBounds: Leaflet.BoundsLiteral -> bool
        abstract member contains: pointOrBounds: Leaflet.Point -> bool
        abstract member contains: pointOrBounds: Leaflet.PointTuple -> bool
        abstract member contains: pointOrBounds: U2<Leaflet.BoundsExpression, Leaflet.PointExpression> -> bool
        abstract member intersects: otherBounds: Leaflet.Bounds -> bool
        abstract member intersects: otherBounds: Leaflet.BoundsLiteral -> bool
        abstract member intersects: otherBounds: Leaflet.BoundsExpression -> bool
        abstract member overlaps: otherBounds: Leaflet.Bounds -> bool
        abstract member overlaps: otherBounds: Leaflet.BoundsLiteral -> bool
        abstract member overlaps: otherBounds: Leaflet.BoundsExpression -> bool
        abstract member isValid: unit -> bool
        abstract member pad: bufferRatio: float -> Leaflet.Bounds
        abstract member equals: otherBounds: Leaflet.Bounds -> bool
        abstract member equals: otherBounds: Leaflet.BoundsLiteral -> bool
        abstract member equals: otherBounds: Leaflet.BoundsExpression -> bool
        abstract member min: Leaflet.Point option with get, set
        abstract member max: Leaflet.Point option with get, set

    type BoundsExpression =
        U2<Leaflet.Bounds, Leaflet.BoundsLiteral>

    type LeafletEventHandlerFn =
        delegate of event: Leaflet.LeafletEvent -> unit

    type LayersControlEventHandlerFn =
        delegate of event: Leaflet.LayersControlEvent -> unit

    type LayerEventHandlerFn =
        delegate of event: Leaflet.LayerEvent -> unit

    type ResizeEventHandlerFn =
        delegate of event: Leaflet.ResizeEvent -> unit

    type PopupEventHandlerFn =
        delegate of event: Leaflet.PopupEvent -> unit

    type TooltipEventHandlerFn =
        delegate of event: Leaflet.TooltipEvent -> unit

    type ErrorEventHandlerFn =
        delegate of event: Leaflet.ErrorEvent -> unit

    type LocationEventHandlerFn =
        delegate of event: Leaflet.LocationEvent -> unit

    type LeafletMouseEventHandlerFn =
        delegate of event: Leaflet.LeafletMouseEvent -> unit

    type LeafletKeyboardEventHandlerFn =
        delegate of event: Leaflet.LeafletKeyboardEvent -> unit

    type ZoomAnimEventHandlerFn =
        delegate of event: Leaflet.ZoomAnimEvent -> unit

    type DragEndEventHandlerFn =
        delegate of event: Leaflet.DragEndEvent -> unit

    type TileEventHandlerFn =
        delegate of event: Leaflet.TileEvent -> unit

    type TileErrorEventHandlerFn =
        delegate of event: Leaflet.TileErrorEvent -> unit

    [<AllowNullLiteral>]
    [<Interface>]
    type LeafletEventHandlerFnMap =
        abstract member baselayerchange: Leaflet.LayersControlEventHandlerFn option with get, set
        abstract member overlayadd: Leaflet.LayersControlEventHandlerFn option with get, set
        abstract member overlayremove: Leaflet.LayersControlEventHandlerFn option with get, set
        abstract member layeradd: Leaflet.LayerEventHandlerFn option with get, set
        abstract member layerremove: Leaflet.LayerEventHandlerFn option with get, set
        abstract member zoomlevelschange: Leaflet.LeafletEventHandlerFn option with get, set
        abstract member unload: Leaflet.LeafletEventHandlerFn option with get, set
        abstract member viewreset: Leaflet.LeafletEventHandlerFn option with get, set
        abstract member load: Leaflet.LeafletEventHandlerFn option with get, set
        abstract member zoomstart: Leaflet.LeafletEventHandlerFn option with get, set
        abstract member movestart: Leaflet.LeafletEventHandlerFn option with get, set
        abstract member zoom: Leaflet.LeafletEventHandlerFn option with get, set
        abstract member move: Leaflet.LeafletEventHandlerFn option with get, set
        abstract member zoomend: Leaflet.LeafletEventHandlerFn option with get, set
        abstract member moveend: Leaflet.LeafletEventHandlerFn option with get, set
        abstract member autopanstart: Leaflet.LeafletEventHandlerFn option with get, set
        abstract member dragstart: Leaflet.LeafletEventHandlerFn option with get, set
        abstract member drag: Leaflet.LeafletEventHandlerFn option with get, set
        abstract member add: Leaflet.LeafletEventHandlerFn option with get, set
        abstract member remove: Leaflet.LeafletEventHandlerFn option with get, set
        abstract member loading: Leaflet.LeafletEventHandlerFn option with get, set
        abstract member error: Leaflet.LeafletEventHandlerFn option with get, set
        abstract member update: Leaflet.LeafletEventHandlerFn option with get, set
        abstract member down: Leaflet.LeafletEventHandlerFn option with get, set
        abstract member predrag: Leaflet.LeafletEventHandlerFn option with get, set
        abstract member resize: Leaflet.ResizeEventHandlerFn option with get, set
        abstract member popupopen: Leaflet.PopupEventHandlerFn option with get, set
        abstract member popupclose: Leaflet.PopupEventHandlerFn option with get, set
        abstract member tooltipopen: Leaflet.TooltipEventHandlerFn option with get, set
        abstract member tooltipclose: Leaflet.TooltipEventHandlerFn option with get, set
        abstract member locationerror: Leaflet.ErrorEventHandlerFn option with get, set
        abstract member locationfound: Leaflet.LocationEventHandlerFn option with get, set
        abstract member click: Leaflet.LeafletMouseEventHandlerFn option with get, set
        abstract member dblclick: Leaflet.LeafletMouseEventHandlerFn option with get, set
        abstract member mousedown: Leaflet.LeafletMouseEventHandlerFn option with get, set
        abstract member mouseup: Leaflet.LeafletMouseEventHandlerFn option with get, set
        abstract member mouseover: Leaflet.LeafletMouseEventHandlerFn option with get, set
        abstract member mouseout: Leaflet.LeafletMouseEventHandlerFn option with get, set
        abstract member mousemove: Leaflet.LeafletMouseEventHandlerFn option with get, set
        abstract member contextmenu: Leaflet.LeafletMouseEventHandlerFn option with get, set
        abstract member preclick: Leaflet.LeafletMouseEventHandlerFn option with get, set
        abstract member keypress: Leaflet.LeafletKeyboardEventHandlerFn option with get, set
        abstract member keydown: Leaflet.LeafletKeyboardEventHandlerFn option with get, set
        abstract member keyup: Leaflet.LeafletKeyboardEventHandlerFn option with get, set
        abstract member zoomanim: Leaflet.ZoomAnimEventHandlerFn option with get, set
        abstract member dragend: Leaflet.DragEndEventHandlerFn option with get, set
        abstract member tileunload: Leaflet.TileEventHandlerFn option with get, set
        abstract member tileloadstart: Leaflet.TileEventHandlerFn option with get, set
        abstract member tileload: Leaflet.TileEventHandlerFn option with get, set
        abstract member tileabort: Leaflet.TileEventHandlerFn option with get, set
        abstract member tileerror: Leaflet.TileErrorEventHandlerFn option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?baselayerchange: Leaflet.LayersControlEventHandlerFn, ?overlayadd: Leaflet.LayersControlEventHandlerFn, ?overlayremove: Leaflet.LayersControlEventHandlerFn, ?layeradd: Leaflet.LayerEventHandlerFn, ?layerremove: Leaflet.LayerEventHandlerFn, ?zoomlevelschange: Leaflet.LeafletEventHandlerFn, ?unload: Leaflet.LeafletEventHandlerFn, ?viewreset: Leaflet.LeafletEventHandlerFn, ?load: Leaflet.LeafletEventHandlerFn, ?zoomstart: Leaflet.LeafletEventHandlerFn, ?movestart: Leaflet.LeafletEventHandlerFn, ?zoom: Leaflet.LeafletEventHandlerFn, ?move: Leaflet.LeafletEventHandlerFn, ?zoomend: Leaflet.LeafletEventHandlerFn, ?moveend: Leaflet.LeafletEventHandlerFn, ?autopanstart: Leaflet.LeafletEventHandlerFn, ?dragstart: Leaflet.LeafletEventHandlerFn, ?drag: Leaflet.LeafletEventHandlerFn, ?add: Leaflet.LeafletEventHandlerFn, ?remove: Leaflet.LeafletEventHandlerFn, ?loading: Leaflet.LeafletEventHandlerFn, ?error: Leaflet.LeafletEventHandlerFn, ?update: Leaflet.LeafletEventHandlerFn, ?down: Leaflet.LeafletEventHandlerFn, ?predrag: Leaflet.LeafletEventHandlerFn, ?resize: Leaflet.ResizeEventHandlerFn, ?popupopen: Leaflet.PopupEventHandlerFn, ?popupclose: Leaflet.PopupEventHandlerFn, ?tooltipopen: Leaflet.TooltipEventHandlerFn, ?tooltipclose: Leaflet.TooltipEventHandlerFn, ?locationerror: Leaflet.ErrorEventHandlerFn, ?locationfound: Leaflet.LocationEventHandlerFn, ?click: Leaflet.LeafletMouseEventHandlerFn, ?dblclick: Leaflet.LeafletMouseEventHandlerFn, ?mousedown: Leaflet.LeafletMouseEventHandlerFn, ?mouseup: Leaflet.LeafletMouseEventHandlerFn, ?mouseover: Leaflet.LeafletMouseEventHandlerFn, ?mouseout: Leaflet.LeafletMouseEventHandlerFn, ?mousemove: Leaflet.LeafletMouseEventHandlerFn, ?contextmenu: Leaflet.LeafletMouseEventHandlerFn, ?preclick: Leaflet.LeafletMouseEventHandlerFn, ?keypress: Leaflet.LeafletKeyboardEventHandlerFn, ?keydown: Leaflet.LeafletKeyboardEventHandlerFn, ?keyup: Leaflet.LeafletKeyboardEventHandlerFn, ?zoomanim: Leaflet.ZoomAnimEventHandlerFn, ?dragend: Leaflet.DragEndEventHandlerFn, ?tileunload: Leaflet.TileEventHandlerFn, ?tileloadstart: Leaflet.TileEventHandlerFn, ?tileload: Leaflet.TileEventHandlerFn, ?tileabort: Leaflet.TileEventHandlerFn, ?tileerror: Leaflet.TileErrorEventHandlerFn) : LeafletEventHandlerFnMap = nativeOnly

    /// <summary>
    /// A set of methods shared between event-powered classes (like Map and Marker).
    /// Generally, events allow you to execute some function when something happens
    /// with an object (e.g. the user clicks on the map, causing the map to fire
    /// 'click' event).
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type Events =
        /// <summary>
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        abstract member on: ``type``: Events.on.``type`` * fn: Leaflet.LayersControlEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        abstract member on: ``type``: Events.on.``type_1`` * fn: Leaflet.LayerEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        abstract member on: ``type``: Events.on.``type_2`` * fn: Leaflet.LeafletEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        [<Emit("$0.on('resize',$1...)")>]
        abstract member on_resize: fn: Leaflet.ResizeEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        abstract member on: ``type``: Events.on.``type_3`` * fn: Leaflet.PopupEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        abstract member on: ``type``: Events.on.``type_4`` * fn: Leaflet.TooltipEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        [<Emit("$0.on('locationerror',$1...)")>]
        abstract member on_locationerror: fn: Leaflet.ErrorEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        [<Emit("$0.on('locationfound',$1...)")>]
        abstract member on_locationfound: fn: Leaflet.LocationEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        abstract member on: ``type``: Events.on.``type_5`` * fn: Leaflet.LeafletMouseEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        abstract member on: ``type``: Events.on.``type_6`` * fn: Leaflet.LeafletKeyboardEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        [<Emit("$0.on('zoomanim',$1...)")>]
        abstract member on_zoomanim: fn: Leaflet.ZoomAnimEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        [<Emit("$0.on('dragend',$1...)")>]
        abstract member on_dragend: fn: Leaflet.DragEndEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        abstract member on: ``type``: Events.on.``type_7`` * fn: Leaflet.TileEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        [<Emit("$0.on('tileerror',$1...)")>]
        abstract member on_tileerror: fn: Leaflet.TileErrorEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        abstract member on: ``type``: string * fn: Leaflet.LeafletEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        abstract member on: eventMap: Leaflet.LeafletEventHandlerFnMap -> Events
        /// <summary>
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Removes a set of type/listener pairs.
        /// Removes all listeners to all events on the object.
        /// </summary>
        abstract member off: ``type``: Events.off.``type`` * ?fn: Leaflet.LayersControlEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Removes a set of type/listener pairs.
        /// Removes all listeners to all events on the object.
        /// </summary>
        abstract member off: ``type``: Events.off.``type_1`` * ?fn: Leaflet.LayerEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Removes a set of type/listener pairs.
        /// Removes all listeners to all events on the object.
        /// </summary>
        abstract member off: ``type``: Events.off.``type_2`` * ?fn: Leaflet.LeafletEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Removes a set of type/listener pairs.
        /// Removes all listeners to all events on the object.
        /// </summary>
        [<Emit("$0.off('resize',$1...)")>]
        abstract member off_resize: ?fn: Leaflet.ResizeEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Removes a set of type/listener pairs.
        /// Removes all listeners to all events on the object.
        /// </summary>
        abstract member off: ``type``: Events.off.``type_3`` * ?fn: Leaflet.PopupEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Removes a set of type/listener pairs.
        /// Removes all listeners to all events on the object.
        /// </summary>
        abstract member off: ``type``: Events.off.``type_4`` * ?fn: Leaflet.TooltipEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Removes a set of type/listener pairs.
        /// Removes all listeners to all events on the object.
        /// </summary>
        [<Emit("$0.off('locationerror',$1...)")>]
        abstract member off_locationerror: ?fn: Leaflet.ErrorEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Removes a set of type/listener pairs.
        /// Removes all listeners to all events on the object.
        /// </summary>
        [<Emit("$0.off('locationfound',$1...)")>]
        abstract member off_locationfound: ?fn: Leaflet.LocationEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Removes a set of type/listener pairs.
        /// Removes all listeners to all events on the object.
        /// </summary>
        abstract member off: ``type``: Events.off.``type_5`` * ?fn: Leaflet.LeafletMouseEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Removes a set of type/listener pairs.
        /// Removes all listeners to all events on the object.
        /// </summary>
        abstract member off: ``type``: Events.off.``type_6`` * ?fn: Leaflet.LeafletKeyboardEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Removes a set of type/listener pairs.
        /// Removes all listeners to all events on the object.
        /// </summary>
        [<Emit("$0.off('zoomanim',$1...)")>]
        abstract member off_zoomanim: ?fn: Leaflet.ZoomAnimEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Removes a set of type/listener pairs.
        /// Removes all listeners to all events on the object.
        /// </summary>
        [<Emit("$0.off('dragend',$1...)")>]
        abstract member off_dragend: ?fn: Leaflet.DragEndEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Removes a set of type/listener pairs.
        /// Removes all listeners to all events on the object.
        /// </summary>
        abstract member off: ``type``: Events.off.``type_7`` * ?fn: Leaflet.TileEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Removes a set of type/listener pairs.
        /// Removes all listeners to all events on the object.
        /// </summary>
        [<Emit("$0.off('tileerror',$1...)")>]
        abstract member off_tileerror: ?fn: Leaflet.TileErrorEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Removes a set of type/listener pairs.
        /// Removes all listeners to all events on the object.
        /// </summary>
        abstract member off: ``type``: string * ?fn: Leaflet.LeafletEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Removes a set of type/listener pairs.
        /// Removes all listeners to all events on the object.
        /// </summary>
        abstract member off: eventMap: Leaflet.LeafletEventHandlerFnMap -> Events
        /// <summary>
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Removes a set of type/listener pairs.
        /// Removes all listeners to all events on the object.
        /// </summary>
        abstract member off: unit -> Events
        /// <summary>
        /// Fires an event of the specified type. You can optionally provide a data
        /// object — the first argument of the listener function will contain its properties.
        /// The event might can optionally be propagated to event parents.
        /// </summary>
        abstract member fire: ``type``: string * ?data: obj * ?propagate: bool -> Events
        /// <summary>
        /// Returns true if a particular event type has any listeners attached to it.
        /// </summary>
        abstract member listens: ``type``: Events.listens.``type`` * ?propagate: bool -> bool
        /// <summary>
        /// Returns true if a particular event type has any listeners attached to it.
        /// </summary>
        abstract member listens: ``type``: Events.listens.``type_1`` * fn: Leaflet.LayersControlEventHandlerFn * ?context: obj * ?propagate: bool -> bool
        /// <summary>
        /// Returns true if a particular event type has any listeners attached to it.
        /// </summary>
        abstract member listens: ``type``: Events.listens.``type_2`` * fn: Leaflet.LayerEventHandlerFn * ?context: obj * ?propagate: bool -> bool
        /// <summary>
        /// Returns true if a particular event type has any listeners attached to it.
        /// </summary>
        abstract member listens: ``type``: Events.listens.``type_3`` * fn: Leaflet.LeafletEventHandlerFn * ?context: obj * ?propagate: bool -> bool
        /// <summary>
        /// Returns true if a particular event type has any listeners attached to it.
        /// </summary>
        [<Emit("$0.listens('resize',$1...)")>]
        abstract member listens_resize: fn: Leaflet.ResizeEventHandlerFn * ?context: obj * ?propagate: bool -> bool
        /// <summary>
        /// Returns true if a particular event type has any listeners attached to it.
        /// </summary>
        abstract member listens: ``type``: Events.listens.``type_4`` * fn: Leaflet.PopupEventHandlerFn * ?context: obj * ?propagate: bool -> bool
        /// <summary>
        /// Returns true if a particular event type has any listeners attached to it.
        /// </summary>
        abstract member listens: ``type``: Events.listens.``type_5`` * fn: Leaflet.TooltipEventHandlerFn * ?context: obj * ?propagate: bool -> bool
        /// <summary>
        /// Returns true if a particular event type has any listeners attached to it.
        /// </summary>
        [<Emit("$0.listens('locationerror',$1...)")>]
        abstract member listens_locationerror: fn: Leaflet.ErrorEventHandlerFn * ?context: obj * ?propagate: bool -> bool
        /// <summary>
        /// Returns true if a particular event type has any listeners attached to it.
        /// </summary>
        [<Emit("$0.listens('locationfound',$1...)")>]
        abstract member listens_locationfound: fn: Leaflet.LocationEventHandlerFn * ?context: obj * ?propagate: bool -> bool
        /// <summary>
        /// Returns true if a particular event type has any listeners attached to it.
        /// </summary>
        abstract member listens: ``type``: Events.listens.``type_6`` * fn: Leaflet.LeafletMouseEventHandlerFn * ?context: obj * ?propagate: bool -> bool
        /// <summary>
        /// Returns true if a particular event type has any listeners attached to it.
        /// </summary>
        abstract member listens: ``type``: Events.listens.``type_7`` * fn: Leaflet.LeafletKeyboardEventHandlerFn * ?context: obj * ?propagate: bool -> bool
        /// <summary>
        /// Returns true if a particular event type has any listeners attached to it.
        /// </summary>
        [<Emit("$0.listens('zoomanim',$1...)")>]
        abstract member listens_zoomanim: fn: Leaflet.ZoomAnimEventHandlerFn * ?context: obj * ?propagate: bool -> bool
        /// <summary>
        /// Returns true if a particular event type has any listeners attached to it.
        /// </summary>
        [<Emit("$0.listens('dragend',$1...)")>]
        abstract member listens_dragend: fn: Leaflet.DragEndEventHandlerFn * ?context: obj * ?propagate: bool -> bool
        /// <summary>
        /// Returns true if a particular event type has any listeners attached to it.
        /// </summary>
        abstract member listens: ``type``: Events.listens.``type_8`` * fn: Leaflet.TileEventHandlerFn * ?context: obj * ?propagate: bool -> bool
        /// <summary>
        /// Returns true if a particular event type has any listeners attached to it.
        /// </summary>
        [<Emit("$0.listens('tileerror',$1...)")>]
        abstract member listens_tileerror: fn: Leaflet.TileEventHandlerFn * ?context: obj * ?propagate: bool -> bool
        /// <summary>
        /// Returns true if a particular event type has any listeners attached to it.
        /// </summary>
        abstract member listens: ``type``: string * fn: Leaflet.LeafletEventHandlerFn * ?context: obj * ?propagate: bool -> bool
        /// <summary>
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        abstract member once: ``type``: Events.once.``type`` * fn: Leaflet.LayersControlEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        abstract member once: ``type``: Events.once.``type_1`` * fn: Leaflet.LayerEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        abstract member once: ``type``: Events.once.``type_2`` * fn: Leaflet.LeafletEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        [<Emit("$0.once('resize',$1...)")>]
        abstract member once_resize: fn: Leaflet.ResizeEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        abstract member once: ``type``: Events.once.``type_3`` * fn: Leaflet.PopupEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        abstract member once: ``type``: Events.once.``type_4`` * fn: Leaflet.TooltipEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        [<Emit("$0.once('locationerror',$1...)")>]
        abstract member once_locationerror: fn: Leaflet.ErrorEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        [<Emit("$0.once('locationfound',$1...)")>]
        abstract member once_locationfound: fn: Leaflet.LocationEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        abstract member once: ``type``: Events.once.``type_5`` * fn: Leaflet.LeafletMouseEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        abstract member once: ``type``: Events.once.``type_6`` * fn: Leaflet.LeafletKeyboardEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        [<Emit("$0.once('zoomanim',$1...)")>]
        abstract member once_zoomanim: fn: Leaflet.ZoomAnimEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        [<Emit("$0.once('dragend',$1...)")>]
        abstract member once_dragend: fn: Leaflet.DragEndEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        abstract member once: ``type``: Events.once.``type_7`` * fn: Leaflet.TileEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        [<Emit("$0.once('tileerror',$1...)")>]
        abstract member once_tileerror: fn: Leaflet.TileEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        abstract member once: ``type``: string * fn: Leaflet.LeafletEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        abstract member once: eventMap: Leaflet.LeafletEventHandlerFnMap -> Events
        /// <summary>
        /// Adds an event parent - an Evented that will receive propagated events
        /// </summary>
        abstract member addEventParent: obj: Leaflet.Evented -> Events
        /// <summary>
        /// Removes an event parent, so it will stop receiving propagated events
        /// </summary>
        abstract member removeEventParent: obj: Leaflet.Evented -> Events
        /// <summary>
        /// Alias for on(...)
        ///
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Alias for on(...)
        ///
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        abstract member addEventListener: ``type``: Events.addEventListener.``type`` * fn: Leaflet.LayersControlEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Alias for on(...)
        ///
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Alias for on(...)
        ///
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        abstract member addEventListener: ``type``: Events.addEventListener.``type_1`` * fn: Leaflet.LayerEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Alias for on(...)
        ///
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Alias for on(...)
        ///
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        abstract member addEventListener: ``type``: Events.addEventListener.``type_2`` * fn: Leaflet.LeafletEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Alias for on(...)
        ///
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Alias for on(...)
        ///
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        [<Emit("$0.addEventListener('resize',$1...)")>]
        abstract member addEventListener_resize: fn: Leaflet.ResizeEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Alias for on(...)
        ///
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Alias for on(...)
        ///
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        abstract member addEventListener: ``type``: Events.addEventListener.``type_3`` * fn: Leaflet.PopupEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Alias for on(...)
        ///
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Alias for on(...)
        ///
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        abstract member addEventListener: ``type``: Events.addEventListener.``type_4`` * fn: Leaflet.TooltipEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Alias for on(...)
        ///
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Alias for on(...)
        ///
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        [<Emit("$0.addEventListener('locationerror',$1...)")>]
        abstract member addEventListener_locationerror: fn: Leaflet.ErrorEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Alias for on(...)
        ///
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Alias for on(...)
        ///
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        [<Emit("$0.addEventListener('locationfound',$1...)")>]
        abstract member addEventListener_locationfound: fn: Leaflet.LocationEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Alias for on(...)
        ///
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Alias for on(...)
        ///
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        abstract member addEventListener: ``type``: Events.addEventListener.``type_5`` * fn: Leaflet.LeafletMouseEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Alias for on(...)
        ///
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Alias for on(...)
        ///
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        abstract member addEventListener: ``type``: Events.addEventListener.``type_6`` * fn: Leaflet.LeafletKeyboardEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Alias for on(...)
        ///
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Alias for on(...)
        ///
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        [<Emit("$0.addEventListener('zoomanim',$1...)")>]
        abstract member addEventListener_zoomanim: fn: Leaflet.ZoomAnimEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Alias for on(...)
        ///
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Alias for on(...)
        ///
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        [<Emit("$0.addEventListener('dragend',$1...)")>]
        abstract member addEventListener_dragend: fn: Leaflet.DragEndEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Alias for on(...)
        ///
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Alias for on(...)
        ///
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        abstract member addEventListener: ``type``: Events.addEventListener.``type_7`` * fn: Leaflet.TileEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Alias for on(...)
        ///
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Alias for on(...)
        ///
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        [<Emit("$0.addEventListener('tileerror',$1...)")>]
        abstract member addEventListener_tileerror: fn: Leaflet.TileErrorEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Alias for on(...)
        ///
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Alias for on(...)
        ///
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        abstract member addEventListener: ``type``: string * fn: Leaflet.LeafletEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Alias for on(...)
        ///
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Alias for on(...)
        ///
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        abstract member addEventListener: eventMap: Leaflet.LeafletEventHandlerFnMap -> Events
        /// <summary>
        /// Alias for off(...)
        ///
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Alias for off(...)
        ///
        /// Removes a set of type/listener pairs.
        /// </summary>
        abstract member removeEventListener: ``type``: Events.removeEventListener.``type`` * ?fn: Leaflet.LayersControlEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Alias for off(...)
        ///
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Alias for off(...)
        ///
        /// Removes a set of type/listener pairs.
        /// </summary>
        abstract member removeEventListener: ``type``: Events.removeEventListener.``type_1`` * ?fn: Leaflet.LayerEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Alias for off(...)
        ///
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Alias for off(...)
        ///
        /// Removes a set of type/listener pairs.
        /// </summary>
        abstract member removeEventListener: ``type``: Events.removeEventListener.``type_2`` * ?fn: Leaflet.LeafletEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Alias for off(...)
        ///
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Alias for off(...)
        ///
        /// Removes a set of type/listener pairs.
        /// </summary>
        [<Emit("$0.removeEventListener('resize',$1...)")>]
        abstract member removeEventListener_resize: ?fn: Leaflet.ResizeEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Alias for off(...)
        ///
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Alias for off(...)
        ///
        /// Removes a set of type/listener pairs.
        /// </summary>
        abstract member removeEventListener: ``type``: Events.removeEventListener.``type_3`` * ?fn: Leaflet.PopupEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Alias for off(...)
        ///
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Alias for off(...)
        ///
        /// Removes a set of type/listener pairs.
        /// </summary>
        abstract member removeEventListener: ``type``: Events.removeEventListener.``type_4`` * ?fn: Leaflet.TooltipEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Alias for off(...)
        ///
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Alias for off(...)
        ///
        /// Removes a set of type/listener pairs.
        /// </summary>
        [<Emit("$0.removeEventListener('locationerror',$1...)")>]
        abstract member removeEventListener_locationerror: ?fn: Leaflet.ErrorEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Alias for off(...)
        ///
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Alias for off(...)
        ///
        /// Removes a set of type/listener pairs.
        /// </summary>
        [<Emit("$0.removeEventListener('locationfound',$1...)")>]
        abstract member removeEventListener_locationfound: ?fn: Leaflet.LocationEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Alias for off(...)
        ///
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Alias for off(...)
        ///
        /// Removes a set of type/listener pairs.
        /// </summary>
        abstract member removeEventListener: ``type``: Events.removeEventListener.``type_5`` * ?fn: Leaflet.LeafletMouseEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Alias for off(...)
        ///
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Alias for off(...)
        ///
        /// Removes a set of type/listener pairs.
        /// </summary>
        abstract member removeEventListener: ``type``: Events.removeEventListener.``type_6`` * ?fn: Leaflet.LeafletKeyboardEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Alias for off(...)
        ///
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Alias for off(...)
        ///
        /// Removes a set of type/listener pairs.
        /// </summary>
        [<Emit("$0.removeEventListener('zoomanim',$1...)")>]
        abstract member removeEventListener_zoomanim: ?fn: Leaflet.ZoomAnimEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Alias for off(...)
        ///
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Alias for off(...)
        ///
        /// Removes a set of type/listener pairs.
        /// </summary>
        [<Emit("$0.removeEventListener('dragend',$1...)")>]
        abstract member removeEventListener_dragend: ?fn: Leaflet.DragEndEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Alias for off(...)
        ///
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Alias for off(...)
        ///
        /// Removes a set of type/listener pairs.
        /// </summary>
        abstract member removeEventListener: ``type``: Events.removeEventListener.``type_7`` * ?fn: Leaflet.TileEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Alias for off(...)
        ///
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Alias for off(...)
        ///
        /// Removes a set of type/listener pairs.
        /// </summary>
        [<Emit("$0.removeEventListener('tileerror',$1...)")>]
        abstract member removeEventListener_tileerror: ?fn: Leaflet.TileErrorEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Alias for off(...)
        ///
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Alias for off(...)
        ///
        /// Removes a set of type/listener pairs.
        /// </summary>
        abstract member removeEventListener: ``type``: string * ?fn: Leaflet.LeafletEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Alias for off(...)
        ///
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Alias for off(...)
        ///
        /// Removes a set of type/listener pairs.
        /// </summary>
        abstract member removeEventListener: eventMap: Leaflet.LeafletEventHandlerFnMap -> Events
        /// <summary>
        /// Alias for off()
        ///
        /// Removes all listeners to all events on the object.
        /// </summary>
        abstract member clearAllEventListeners: unit -> Events
        /// <summary>
        /// Alias for once(...)
        ///
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        abstract member addOneTimeEventListener: ``type``: Events.addOneTimeEventListener.``type`` * fn: Leaflet.LayersControlEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Alias for once(...)
        ///
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        abstract member addOneTimeEventListener: ``type``: Events.addOneTimeEventListener.``type_1`` * fn: Leaflet.LayerEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Alias for once(...)
        ///
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        abstract member addOneTimeEventListener: ``type``: Events.addOneTimeEventListener.``type_2`` * fn: Leaflet.LeafletEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Alias for once(...)
        ///
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        [<Emit("$0.addOneTimeEventListener('resize',$1...)")>]
        abstract member addOneTimeEventListener_resize: fn: Leaflet.ResizeEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Alias for once(...)
        ///
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        abstract member addOneTimeEventListener: ``type``: Events.addOneTimeEventListener.``type_3`` * fn: Leaflet.PopupEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Alias for once(...)
        ///
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        abstract member addOneTimeEventListener: ``type``: Events.addOneTimeEventListener.``type_4`` * fn: Leaflet.TooltipEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Alias for once(...)
        ///
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        [<Emit("$0.addOneTimeEventListener('locationerror',$1...)")>]
        abstract member addOneTimeEventListener_locationerror: fn: Leaflet.ErrorEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Alias for once(...)
        ///
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        [<Emit("$0.addOneTimeEventListener('locationfound',$1...)")>]
        abstract member addOneTimeEventListener_locationfound: fn: Leaflet.LocationEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Alias for once(...)
        ///
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        abstract member addOneTimeEventListener: ``type``: Events.addOneTimeEventListener.``type_5`` * fn: Leaflet.LeafletMouseEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Alias for once(...)
        ///
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        abstract member addOneTimeEventListener: ``type``: Events.addOneTimeEventListener.``type_6`` * fn: Leaflet.LeafletKeyboardEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Alias for once(...)
        ///
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        [<Emit("$0.addOneTimeEventListener('zoomanim',$1...)")>]
        abstract member addOneTimeEventListener_zoomanim: fn: Leaflet.ZoomAnimEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Alias for once(...)
        ///
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        [<Emit("$0.addOneTimeEventListener('dragend',$1...)")>]
        abstract member addOneTimeEventListener_dragend: fn: Leaflet.DragEndEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Alias for once(...)
        ///
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        abstract member addOneTimeEventListener: ``type``: Events.addOneTimeEventListener.``type_7`` * fn: Leaflet.TileEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Alias for once(...)
        ///
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        [<Emit("$0.addOneTimeEventListener('tileerror',$1...)")>]
        abstract member addOneTimeEventListener_tileerror: fn: Leaflet.TileErrorEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Alias for once(...)
        ///
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        abstract member addOneTimeEventListener: ``type``: string * fn: Leaflet.LeafletEventHandlerFn * ?context: obj -> Events
        /// <summary>
        /// Alias for once(...)
        ///
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        abstract member addOneTimeEventListener: eventMap: Leaflet.LeafletEventHandlerFnMap -> Events
        /// <summary>
        /// Alias for fire(...)
        ///
        /// Fires an event of the specified type. You can optionally provide a data
        /// object — the first argument of the listener function will contain its properties.
        /// The event might can optionally be propagated to event parents.
        /// </summary>
        abstract member fireEvent: ``type``: string * ?data: obj * ?propagate: bool -> Events
        /// <summary>
        /// Alias for listens(...)
        ///
        /// Returns true if a particular event type has any listeners attached to it.
        /// </summary>
        abstract member hasEventListeners: ``type``: string -> bool

    [<AllowNullLiteral>]
    [<Interface>]
    type MixinType =
        abstract member Events: Leaflet.Events with get, set

    /// <summary>
    /// Base class of Leaflet classes supporting events
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type Evented =
        inherit Leaflet.Class
        /// <summary>
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        abstract member on: ``type``: Evented.on.``type`` * fn: Leaflet.LayersControlEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        abstract member on: ``type``: Evented.on.``type_1`` * fn: Leaflet.LayerEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        abstract member on: ``type``: Evented.on.``type_2`` * fn: Leaflet.LeafletEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        [<Emit("$0.on('resize',$1...)")>]
        abstract member on_resize: fn: Leaflet.ResizeEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        abstract member on: ``type``: Evented.on.``type_3`` * fn: Leaflet.PopupEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        abstract member on: ``type``: Evented.on.``type_4`` * fn: Leaflet.TooltipEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        [<Emit("$0.on('locationerror',$1...)")>]
        abstract member on_locationerror: fn: Leaflet.ErrorEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        [<Emit("$0.on('locationfound',$1...)")>]
        abstract member on_locationfound: fn: Leaflet.LocationEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        abstract member on: ``type``: Evented.on.``type_5`` * fn: Leaflet.LeafletMouseEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        abstract member on: ``type``: Evented.on.``type_6`` * fn: Leaflet.LeafletKeyboardEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        [<Emit("$0.on('zoomanim',$1...)")>]
        abstract member on_zoomanim: fn: Leaflet.ZoomAnimEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        [<Emit("$0.on('dragend',$1...)")>]
        abstract member on_dragend: fn: Leaflet.DragEndEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        abstract member on: ``type``: Evented.on.``type_7`` * fn: Leaflet.TileEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        [<Emit("$0.on('tileerror',$1...)")>]
        abstract member on_tileerror: fn: Leaflet.TileErrorEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        abstract member on: ``type``: string * fn: Leaflet.LeafletEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        abstract member on: eventMap: Leaflet.LeafletEventHandlerFnMap -> Evented
        /// <summary>
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Removes a set of type/listener pairs.
        /// Removes all listeners to all events on the object.
        /// </summary>
        abstract member off: ``type``: Evented.off.``type`` * ?fn: Leaflet.LayersControlEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Removes a set of type/listener pairs.
        /// Removes all listeners to all events on the object.
        /// </summary>
        abstract member off: ``type``: Evented.off.``type_1`` * ?fn: Leaflet.LayerEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Removes a set of type/listener pairs.
        /// Removes all listeners to all events on the object.
        /// </summary>
        abstract member off: ``type``: Evented.off.``type_2`` * ?fn: Leaflet.LeafletEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Removes a set of type/listener pairs.
        /// Removes all listeners to all events on the object.
        /// </summary>
        [<Emit("$0.off('resize',$1...)")>]
        abstract member off_resize: ?fn: Leaflet.ResizeEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Removes a set of type/listener pairs.
        /// Removes all listeners to all events on the object.
        /// </summary>
        abstract member off: ``type``: Evented.off.``type_3`` * ?fn: Leaflet.PopupEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Removes a set of type/listener pairs.
        /// Removes all listeners to all events on the object.
        /// </summary>
        abstract member off: ``type``: Evented.off.``type_4`` * ?fn: Leaflet.TooltipEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Removes a set of type/listener pairs.
        /// Removes all listeners to all events on the object.
        /// </summary>
        [<Emit("$0.off('locationerror',$1...)")>]
        abstract member off_locationerror: ?fn: Leaflet.ErrorEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Removes a set of type/listener pairs.
        /// Removes all listeners to all events on the object.
        /// </summary>
        [<Emit("$0.off('locationfound',$1...)")>]
        abstract member off_locationfound: ?fn: Leaflet.LocationEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Removes a set of type/listener pairs.
        /// Removes all listeners to all events on the object.
        /// </summary>
        abstract member off: ``type``: Evented.off.``type_5`` * ?fn: Leaflet.LeafletMouseEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Removes a set of type/listener pairs.
        /// Removes all listeners to all events on the object.
        /// </summary>
        abstract member off: ``type``: Evented.off.``type_6`` * ?fn: Leaflet.LeafletKeyboardEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Removes a set of type/listener pairs.
        /// Removes all listeners to all events on the object.
        /// </summary>
        [<Emit("$0.off('zoomanim',$1...)")>]
        abstract member off_zoomanim: ?fn: Leaflet.ZoomAnimEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Removes a set of type/listener pairs.
        /// Removes all listeners to all events on the object.
        /// </summary>
        [<Emit("$0.off('dragend',$1...)")>]
        abstract member off_dragend: ?fn: Leaflet.DragEndEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Removes a set of type/listener pairs.
        /// Removes all listeners to all events on the object.
        /// </summary>
        abstract member off: ``type``: Evented.off.``type_7`` * ?fn: Leaflet.TileEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Removes a set of type/listener pairs.
        /// Removes all listeners to all events on the object.
        /// </summary>
        [<Emit("$0.off('tileerror',$1...)")>]
        abstract member off_tileerror: ?fn: Leaflet.TileErrorEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Removes a set of type/listener pairs.
        /// Removes all listeners to all events on the object.
        /// </summary>
        abstract member off: ``type``: string * ?fn: Leaflet.LeafletEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Removes a set of type/listener pairs.
        /// Removes all listeners to all events on the object.
        /// </summary>
        abstract member off: eventMap: Leaflet.LeafletEventHandlerFnMap -> Evented
        /// <summary>
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Removes a set of type/listener pairs.
        /// Removes all listeners to all events on the object.
        /// </summary>
        abstract member off: unit -> Evented
        /// <summary>
        /// Fires an event of the specified type. You can optionally provide a data
        /// object — the first argument of the listener function will contain its properties.
        /// The event might can optionally be propagated to event parents.
        /// </summary>
        abstract member fire: ``type``: string * ?data: obj * ?propagate: bool -> Evented
        /// <summary>
        /// Returns true if a particular event type has any listeners attached to it.
        /// </summary>
        abstract member listens: ``type``: Evented.listens.``type`` * ?propagate: bool -> bool
        /// <summary>
        /// Returns true if a particular event type has any listeners attached to it.
        /// </summary>
        abstract member listens: ``type``: Evented.listens.``type_1`` * fn: Leaflet.LayersControlEventHandlerFn * ?context: obj * ?propagate: bool -> bool
        /// <summary>
        /// Returns true if a particular event type has any listeners attached to it.
        /// </summary>
        abstract member listens: ``type``: Evented.listens.``type_2`` * fn: Leaflet.LayerEventHandlerFn * ?context: obj * ?propagate: bool -> bool
        /// <summary>
        /// Returns true if a particular event type has any listeners attached to it.
        /// </summary>
        abstract member listens: ``type``: Evented.listens.``type_3`` * fn: Leaflet.LeafletEventHandlerFn * ?context: obj * ?propagate: bool -> bool
        /// <summary>
        /// Returns true if a particular event type has any listeners attached to it.
        /// </summary>
        [<Emit("$0.listens('resize',$1...)")>]
        abstract member listens_resize: fn: Leaflet.ResizeEventHandlerFn * ?context: obj * ?propagate: bool -> bool
        /// <summary>
        /// Returns true if a particular event type has any listeners attached to it.
        /// </summary>
        abstract member listens: ``type``: Evented.listens.``type_4`` * fn: Leaflet.PopupEventHandlerFn * ?context: obj * ?propagate: bool -> bool
        /// <summary>
        /// Returns true if a particular event type has any listeners attached to it.
        /// </summary>
        abstract member listens: ``type``: Evented.listens.``type_5`` * fn: Leaflet.TooltipEventHandlerFn * ?context: obj * ?propagate: bool -> bool
        /// <summary>
        /// Returns true if a particular event type has any listeners attached to it.
        /// </summary>
        [<Emit("$0.listens('locationerror',$1...)")>]
        abstract member listens_locationerror: fn: Leaflet.ErrorEventHandlerFn * ?context: obj * ?propagate: bool -> bool
        /// <summary>
        /// Returns true if a particular event type has any listeners attached to it.
        /// </summary>
        [<Emit("$0.listens('locationfound',$1...)")>]
        abstract member listens_locationfound: fn: Leaflet.LocationEventHandlerFn * ?context: obj * ?propagate: bool -> bool
        /// <summary>
        /// Returns true if a particular event type has any listeners attached to it.
        /// </summary>
        abstract member listens: ``type``: Evented.listens.``type_6`` * fn: Leaflet.LeafletMouseEventHandlerFn * ?context: obj * ?propagate: bool -> bool
        /// <summary>
        /// Returns true if a particular event type has any listeners attached to it.
        /// </summary>
        abstract member listens: ``type``: Evented.listens.``type_7`` * fn: Leaflet.LeafletKeyboardEventHandlerFn * ?context: obj * ?propagate: bool -> bool
        /// <summary>
        /// Returns true if a particular event type has any listeners attached to it.
        /// </summary>
        [<Emit("$0.listens('zoomanim',$1...)")>]
        abstract member listens_zoomanim: fn: Leaflet.ZoomAnimEventHandlerFn * ?context: obj * ?propagate: bool -> bool
        /// <summary>
        /// Returns true if a particular event type has any listeners attached to it.
        /// </summary>
        [<Emit("$0.listens('dragend',$1...)")>]
        abstract member listens_dragend: fn: Leaflet.DragEndEventHandlerFn * ?context: obj * ?propagate: bool -> bool
        /// <summary>
        /// Returns true if a particular event type has any listeners attached to it.
        /// </summary>
        abstract member listens: ``type``: Evented.listens.``type_8`` * fn: Leaflet.TileEventHandlerFn * ?context: obj * ?propagate: bool -> bool
        /// <summary>
        /// Returns true if a particular event type has any listeners attached to it.
        /// </summary>
        [<Emit("$0.listens('tileerror',$1...)")>]
        abstract member listens_tileerror: fn: Leaflet.TileEventHandlerFn * ?context: obj * ?propagate: bool -> bool
        /// <summary>
        /// Returns true if a particular event type has any listeners attached to it.
        /// </summary>
        abstract member listens: ``type``: string * fn: Leaflet.LeafletEventHandlerFn * ?context: obj * ?propagate: bool -> bool
        /// <summary>
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        abstract member once: ``type``: Evented.once.``type`` * fn: Leaflet.LayersControlEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        abstract member once: ``type``: Evented.once.``type_1`` * fn: Leaflet.LayerEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        abstract member once: ``type``: Evented.once.``type_2`` * fn: Leaflet.LeafletEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        [<Emit("$0.once('resize',$1...)")>]
        abstract member once_resize: fn: Leaflet.ResizeEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        abstract member once: ``type``: Evented.once.``type_3`` * fn: Leaflet.PopupEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        abstract member once: ``type``: Evented.once.``type_4`` * fn: Leaflet.TooltipEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        [<Emit("$0.once('locationerror',$1...)")>]
        abstract member once_locationerror: fn: Leaflet.ErrorEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        [<Emit("$0.once('locationfound',$1...)")>]
        abstract member once_locationfound: fn: Leaflet.LocationEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        abstract member once: ``type``: Evented.once.``type_5`` * fn: Leaflet.LeafletMouseEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        abstract member once: ``type``: Evented.once.``type_6`` * fn: Leaflet.LeafletKeyboardEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        [<Emit("$0.once('zoomanim',$1...)")>]
        abstract member once_zoomanim: fn: Leaflet.ZoomAnimEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        [<Emit("$0.once('dragend',$1...)")>]
        abstract member once_dragend: fn: Leaflet.DragEndEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        abstract member once: ``type``: Evented.once.``type_7`` * fn: Leaflet.TileEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        [<Emit("$0.once('tileerror',$1...)")>]
        abstract member once_tileerror: fn: Leaflet.TileEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        abstract member once: ``type``: string * fn: Leaflet.LeafletEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        abstract member once: eventMap: Leaflet.LeafletEventHandlerFnMap -> Evented
        /// <summary>
        /// Adds an event parent - an Evented that will receive propagated events
        /// </summary>
        abstract member addEventParent: obj: Leaflet.Evented -> Evented
        /// <summary>
        /// Removes an event parent, so it will stop receiving propagated events
        /// </summary>
        abstract member removeEventParent: obj: Leaflet.Evented -> Evented
        /// <summary>
        /// Alias for on(...)
        ///
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Alias for on(...)
        ///
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        abstract member addEventListener: ``type``: Evented.addEventListener.``type`` * fn: Leaflet.LayersControlEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Alias for on(...)
        ///
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Alias for on(...)
        ///
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        abstract member addEventListener: ``type``: Evented.addEventListener.``type_1`` * fn: Leaflet.LayerEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Alias for on(...)
        ///
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Alias for on(...)
        ///
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        abstract member addEventListener: ``type``: Evented.addEventListener.``type_2`` * fn: Leaflet.LeafletEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Alias for on(...)
        ///
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Alias for on(...)
        ///
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        [<Emit("$0.addEventListener('resize',$1...)")>]
        abstract member addEventListener_resize: fn: Leaflet.ResizeEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Alias for on(...)
        ///
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Alias for on(...)
        ///
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        abstract member addEventListener: ``type``: Evented.addEventListener.``type_3`` * fn: Leaflet.PopupEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Alias for on(...)
        ///
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Alias for on(...)
        ///
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        abstract member addEventListener: ``type``: Evented.addEventListener.``type_4`` * fn: Leaflet.TooltipEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Alias for on(...)
        ///
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Alias for on(...)
        ///
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        [<Emit("$0.addEventListener('locationerror',$1...)")>]
        abstract member addEventListener_locationerror: fn: Leaflet.ErrorEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Alias for on(...)
        ///
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Alias for on(...)
        ///
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        [<Emit("$0.addEventListener('locationfound',$1...)")>]
        abstract member addEventListener_locationfound: fn: Leaflet.LocationEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Alias for on(...)
        ///
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Alias for on(...)
        ///
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        abstract member addEventListener: ``type``: Evented.addEventListener.``type_5`` * fn: Leaflet.LeafletMouseEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Alias for on(...)
        ///
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Alias for on(...)
        ///
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        abstract member addEventListener: ``type``: Evented.addEventListener.``type_6`` * fn: Leaflet.LeafletKeyboardEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Alias for on(...)
        ///
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Alias for on(...)
        ///
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        [<Emit("$0.addEventListener('zoomanim',$1...)")>]
        abstract member addEventListener_zoomanim: fn: Leaflet.ZoomAnimEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Alias for on(...)
        ///
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Alias for on(...)
        ///
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        [<Emit("$0.addEventListener('dragend',$1...)")>]
        abstract member addEventListener_dragend: fn: Leaflet.DragEndEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Alias for on(...)
        ///
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Alias for on(...)
        ///
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        abstract member addEventListener: ``type``: Evented.addEventListener.``type_7`` * fn: Leaflet.TileEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Alias for on(...)
        ///
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Alias for on(...)
        ///
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        [<Emit("$0.addEventListener('tileerror',$1...)")>]
        abstract member addEventListener_tileerror: fn: Leaflet.TileErrorEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Alias for on(...)
        ///
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Alias for on(...)
        ///
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        abstract member addEventListener: ``type``: string * fn: Leaflet.LeafletEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Alias for on(...)
        ///
        /// Adds a listener function (fn) to a particular event type of the object.
        /// You can optionally specify the context of the listener (object the this
        /// keyword will point to). You can also pass several space-separated types
        /// (e.g. 'click dblclick').
        /// Alias for on(...)
        ///
        /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
        /// </summary>
        abstract member addEventListener: eventMap: Leaflet.LeafletEventHandlerFnMap -> Evented
        /// <summary>
        /// Alias for off(...)
        ///
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Alias for off(...)
        ///
        /// Removes a set of type/listener pairs.
        /// </summary>
        abstract member removeEventListener: ``type``: Evented.removeEventListener.``type`` * ?fn: Leaflet.LayersControlEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Alias for off(...)
        ///
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Alias for off(...)
        ///
        /// Removes a set of type/listener pairs.
        /// </summary>
        abstract member removeEventListener: ``type``: Evented.removeEventListener.``type_1`` * ?fn: Leaflet.LayerEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Alias for off(...)
        ///
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Alias for off(...)
        ///
        /// Removes a set of type/listener pairs.
        /// </summary>
        abstract member removeEventListener: ``type``: Evented.removeEventListener.``type_2`` * ?fn: Leaflet.LeafletEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Alias for off(...)
        ///
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Alias for off(...)
        ///
        /// Removes a set of type/listener pairs.
        /// </summary>
        [<Emit("$0.removeEventListener('resize',$1...)")>]
        abstract member removeEventListener_resize: ?fn: Leaflet.ResizeEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Alias for off(...)
        ///
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Alias for off(...)
        ///
        /// Removes a set of type/listener pairs.
        /// </summary>
        abstract member removeEventListener: ``type``: Evented.removeEventListener.``type_3`` * ?fn: Leaflet.PopupEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Alias for off(...)
        ///
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Alias for off(...)
        ///
        /// Removes a set of type/listener pairs.
        /// </summary>
        abstract member removeEventListener: ``type``: Evented.removeEventListener.``type_4`` * ?fn: Leaflet.TooltipEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Alias for off(...)
        ///
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Alias for off(...)
        ///
        /// Removes a set of type/listener pairs.
        /// </summary>
        [<Emit("$0.removeEventListener('locationerror',$1...)")>]
        abstract member removeEventListener_locationerror: ?fn: Leaflet.ErrorEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Alias for off(...)
        ///
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Alias for off(...)
        ///
        /// Removes a set of type/listener pairs.
        /// </summary>
        [<Emit("$0.removeEventListener('locationfound',$1...)")>]
        abstract member removeEventListener_locationfound: ?fn: Leaflet.LocationEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Alias for off(...)
        ///
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Alias for off(...)
        ///
        /// Removes a set of type/listener pairs.
        /// </summary>
        abstract member removeEventListener: ``type``: Evented.removeEventListener.``type_5`` * ?fn: Leaflet.LeafletMouseEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Alias for off(...)
        ///
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Alias for off(...)
        ///
        /// Removes a set of type/listener pairs.
        /// </summary>
        abstract member removeEventListener: ``type``: Evented.removeEventListener.``type_6`` * ?fn: Leaflet.LeafletKeyboardEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Alias for off(...)
        ///
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Alias for off(...)
        ///
        /// Removes a set of type/listener pairs.
        /// </summary>
        [<Emit("$0.removeEventListener('zoomanim',$1...)")>]
        abstract member removeEventListener_zoomanim: ?fn: Leaflet.ZoomAnimEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Alias for off(...)
        ///
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Alias for off(...)
        ///
        /// Removes a set of type/listener pairs.
        /// </summary>
        [<Emit("$0.removeEventListener('dragend',$1...)")>]
        abstract member removeEventListener_dragend: ?fn: Leaflet.DragEndEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Alias for off(...)
        ///
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Alias for off(...)
        ///
        /// Removes a set of type/listener pairs.
        /// </summary>
        abstract member removeEventListener: ``type``: Evented.removeEventListener.``type_7`` * ?fn: Leaflet.TileEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Alias for off(...)
        ///
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Alias for off(...)
        ///
        /// Removes a set of type/listener pairs.
        /// </summary>
        [<Emit("$0.removeEventListener('tileerror',$1...)")>]
        abstract member removeEventListener_tileerror: ?fn: Leaflet.TileErrorEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Alias for off(...)
        ///
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Alias for off(...)
        ///
        /// Removes a set of type/listener pairs.
        /// </summary>
        abstract member removeEventListener: ``type``: string * ?fn: Leaflet.LeafletEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Alias for off(...)
        ///
        /// Removes a previously added listener function. If no function is specified,
        /// it will remove all the listeners of that particular event from the object.
        /// Note that if you passed a custom context to on, you must pass the same context
        /// to off in order to remove the listener.
        /// Alias for off(...)
        ///
        /// Removes a set of type/listener pairs.
        /// </summary>
        abstract member removeEventListener: eventMap: Leaflet.LeafletEventHandlerFnMap -> Evented
        /// <summary>
        /// Alias for off()
        ///
        /// Removes all listeners to all events on the object.
        /// </summary>
        abstract member clearAllEventListeners: unit -> Evented
        /// <summary>
        /// Alias for once(...)
        ///
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        abstract member addOneTimeEventListener: ``type``: Evented.addOneTimeEventListener.``type`` * fn: Leaflet.LayersControlEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Alias for once(...)
        ///
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        abstract member addOneTimeEventListener: ``type``: Evented.addOneTimeEventListener.``type_1`` * fn: Leaflet.LayerEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Alias for once(...)
        ///
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        abstract member addOneTimeEventListener: ``type``: Evented.addOneTimeEventListener.``type_2`` * fn: Leaflet.LeafletEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Alias for once(...)
        ///
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        [<Emit("$0.addOneTimeEventListener('resize',$1...)")>]
        abstract member addOneTimeEventListener_resize: fn: Leaflet.ResizeEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Alias for once(...)
        ///
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        abstract member addOneTimeEventListener: ``type``: Evented.addOneTimeEventListener.``type_3`` * fn: Leaflet.PopupEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Alias for once(...)
        ///
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        abstract member addOneTimeEventListener: ``type``: Evented.addOneTimeEventListener.``type_4`` * fn: Leaflet.TooltipEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Alias for once(...)
        ///
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        [<Emit("$0.addOneTimeEventListener('locationerror',$1...)")>]
        abstract member addOneTimeEventListener_locationerror: fn: Leaflet.ErrorEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Alias for once(...)
        ///
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        [<Emit("$0.addOneTimeEventListener('locationfound',$1...)")>]
        abstract member addOneTimeEventListener_locationfound: fn: Leaflet.LocationEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Alias for once(...)
        ///
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        abstract member addOneTimeEventListener: ``type``: Evented.addOneTimeEventListener.``type_5`` * fn: Leaflet.LeafletMouseEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Alias for once(...)
        ///
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        abstract member addOneTimeEventListener: ``type``: Evented.addOneTimeEventListener.``type_6`` * fn: Leaflet.LeafletKeyboardEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Alias for once(...)
        ///
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        [<Emit("$0.addOneTimeEventListener('zoomanim',$1...)")>]
        abstract member addOneTimeEventListener_zoomanim: fn: Leaflet.ZoomAnimEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Alias for once(...)
        ///
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        [<Emit("$0.addOneTimeEventListener('dragend',$1...)")>]
        abstract member addOneTimeEventListener_dragend: fn: Leaflet.DragEndEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Alias for once(...)
        ///
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        abstract member addOneTimeEventListener: ``type``: Evented.addOneTimeEventListener.``type_7`` * fn: Leaflet.TileEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Alias for once(...)
        ///
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        [<Emit("$0.addOneTimeEventListener('tileerror',$1...)")>]
        abstract member addOneTimeEventListener_tileerror: fn: Leaflet.TileErrorEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Alias for once(...)
        ///
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        abstract member addOneTimeEventListener: ``type``: string * fn: Leaflet.LeafletEventHandlerFn * ?context: obj -> Evented
        /// <summary>
        /// Alias for once(...)
        ///
        /// Behaves as on(...), except the listener will only get fired once and then removed.
        /// </summary>
        abstract member addOneTimeEventListener: eventMap: Leaflet.LeafletEventHandlerFnMap -> Evented
        /// <summary>
        /// Alias for fire(...)
        ///
        /// Fires an event of the specified type. You can optionally provide a data
        /// object — the first argument of the listener function will contain its properties.
        /// The event might can optionally be propagated to event parents.
        /// </summary>
        abstract member fireEvent: ``type``: string * ?data: obj * ?propagate: bool -> Evented
        /// <summary>
        /// Alias for listens(...)
        ///
        /// Returns true if a particular event type has any listeners attached to it.
        /// </summary>
        abstract member hasEventListeners: ``type``: string -> bool

    [<AllowNullLiteral>]
    [<Interface>]
    type DraggableOptions =
        /// <summary>
        /// The max number of pixels a user can shift the mouse pointer during a click
        /// for it to be considered a valid click (as opposed to a mouse drag).
        /// </summary>
        abstract member clickTolerance: float with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (clickTolerance: float) : DraggableOptions = nativeOnly

    /// <summary>
    /// A class for making DOM elements draggable (including touch support).
    /// Used internally for map and marker dragging. Only works for elements
    /// that were positioned with [<c>L.DomUtil.setPosition</c>](#domutil-setposition).
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type Draggable =
        inherit Leaflet.Evented
        abstract member enable: unit -> unit
        abstract member disable: unit -> unit
        abstract member finishDrag: unit -> unit

    [<AllowNullLiteral>]
    [<Interface>]
    type LayerOptions =
        abstract member pane: string option with get, set
        abstract member attribution: string option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?pane: string, ?attribution: string) : LayerOptions = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type InteractiveLayerOptions =
        inherit Leaflet.LayerOptions
        abstract member interactive: bool option with get, set
        abstract member bubblingMouseEvents: bool option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type Layer =
        inherit Leaflet.Evented
        abstract member addTo: map: Leaflet.Map -> Layer
        abstract member addTo: map: Leaflet.LayerGroup -> Layer
        abstract member addTo: map: U2<Leaflet.Map, Leaflet.LayerGroup> -> Layer
        abstract member remove: unit -> Layer
        abstract member removeFrom: map: Leaflet.Map -> Layer
        abstract member getPane: ?name: string -> Glutinum.Web.HTMLElement option
        abstract member addInteractiveTarget: targetEl: Glutinum.Web.HTMLElement -> Layer
        abstract member removeInteractiveTarget: targetEl: Glutinum.Web.HTMLElement -> Layer
        abstract member bindPopup: content: (Leaflet.Layer -> Leaflet.Content) * ?options: Leaflet.PopupOptions -> Layer
        abstract member bindPopup: content: string * ?options: Leaflet.PopupOptions -> Layer
        abstract member bindPopup: content: Glutinum.Web.HTMLElement * ?options: Leaflet.PopupOptions -> Layer
        abstract member bindPopup: content: Leaflet.Popup * ?options: Leaflet.PopupOptions -> Layer
        abstract member bindPopup: content: U3<(Leaflet.Layer -> Leaflet.Content), Leaflet.Content, Leaflet.Popup> * ?options: Leaflet.PopupOptions -> Layer
        abstract member unbindPopup: unit -> Layer
        abstract member openPopup: unit -> Layer
        abstract member openPopup: latlng: Leaflet.LatLng -> Layer
        abstract member openPopup: latlng: Leaflet.LatLngLiteral -> Layer
        abstract member openPopup: latlng: Leaflet.LatLngTuple -> Layer
        abstract member closePopup: unit -> Layer
        abstract member togglePopup: unit -> Layer
        abstract member isPopupOpen: unit -> bool
        abstract member setPopupContent: content: string -> Layer
        abstract member setPopupContent: content: Glutinum.Web.HTMLElement -> Layer
        abstract member setPopupContent: content: Leaflet.Popup -> Layer
        abstract member setPopupContent: content: U2<Leaflet.Content, Leaflet.Popup> -> Layer
        abstract member getPopup: unit -> Leaflet.Popup option
        abstract member bindTooltip: content: (Leaflet.Layer -> Leaflet.Content) * ?options: Leaflet.TooltipOptions -> Layer
        abstract member bindTooltip: content: Leaflet.Tooltip * ?options: Leaflet.TooltipOptions -> Layer
        abstract member bindTooltip: content: string * ?options: Leaflet.TooltipOptions -> Layer
        abstract member bindTooltip: content: Glutinum.Web.HTMLElement * ?options: Leaflet.TooltipOptions -> Layer
        abstract member bindTooltip: content: U3<(Leaflet.Layer -> Leaflet.Content), Leaflet.Tooltip, Leaflet.Content> * ?options: Leaflet.TooltipOptions -> Layer
        abstract member unbindTooltip: unit -> Layer
        abstract member openTooltip: unit -> Layer
        abstract member openTooltip: latlng: Leaflet.LatLng -> Layer
        abstract member openTooltip: latlng: Leaflet.LatLngLiteral -> Layer
        abstract member openTooltip: latlng: Leaflet.LatLngTuple -> Layer
        abstract member closeTooltip: unit -> Layer
        abstract member toggleTooltip: unit -> Layer
        abstract member isTooltipOpen: unit -> bool
        abstract member setTooltipContent: content: string -> Layer
        abstract member setTooltipContent: content: Glutinum.Web.HTMLElement -> Layer
        abstract member setTooltipContent: content: Leaflet.Tooltip -> Layer
        abstract member setTooltipContent: content: U2<Leaflet.Content, Leaflet.Tooltip> -> Layer
        abstract member getTooltip: unit -> Leaflet.Tooltip option
        abstract member onAdd: map: Leaflet.Map -> Layer
        abstract member onRemove: map: Leaflet.Map -> Layer
        abstract member getEvents: unit -> Layer.getEvents
        abstract member getAttribution: unit -> string option
        abstract member beforeAdd: map: Leaflet.Map -> Layer
        abstract member options: Leaflet.LayerOptions with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type GridLayerOptions =
        inherit Leaflet.LayerOptions
        abstract member tileSize: U2<float, Leaflet.Point> option with get, set
        abstract member opacity: float option with get, set
        abstract member updateWhenIdle: bool option with get, set
        abstract member updateWhenZooming: bool option with get, set
        abstract member updateInterval: float option with get, set
        abstract member zIndex: float option with get, set
        abstract member bounds: Leaflet.LatLngBoundsExpression option with get, set
        abstract member minZoom: float option with get, set
        abstract member maxZoom: float option with get, set
        /// <summary>
        /// Maximum zoom number the tile source has available. If it is specified, the tiles on all zoom levels higher than
        /// <c>maxNativeZoom</c> will be loaded from <c>maxNativeZoom</c> level and auto-scaled.
        /// </summary>
        abstract member maxNativeZoom: float option with get, set
        /// <summary>
        /// Minimum zoom number the tile source has available. If it is specified, the tiles on all zoom levels lower than
        /// <c>minNativeZoom</c> will be loaded from <c>minNativeZoom</c> level and auto-scaled.
        /// </summary>
        abstract member minNativeZoom: float option with get, set
        abstract member noWrap: bool option with get, set
        abstract member pane: string option with get, set
        abstract member className: string option with get, set
        abstract member keepBuffer: float option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?attribution: string, ?opacity: float, ?updateWhenIdle: bool, ?updateWhenZooming: bool, ?updateInterval: float, ?zIndex: float, ?bounds: Leaflet.LatLngBoundsExpression, ?minZoom: float, ?maxZoom: float, ?maxNativeZoom: float, ?minNativeZoom: float, ?noWrap: bool, ?pane: string, ?className: string, ?keepBuffer: float) : GridLayerOptions = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (tileSize: float, ?attribution: string, ?opacity: float, ?updateWhenIdle: bool, ?updateWhenZooming: bool, ?updateInterval: float, ?zIndex: float, ?bounds: Leaflet.LatLngBoundsExpression, ?minZoom: float, ?maxZoom: float, ?maxNativeZoom: float, ?minNativeZoom: float, ?noWrap: bool, ?pane: string, ?className: string, ?keepBuffer: float) : GridLayerOptions = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (tileSize: Leaflet.Point, ?attribution: string, ?opacity: float, ?updateWhenIdle: bool, ?updateWhenZooming: bool, ?updateInterval: float, ?zIndex: float, ?bounds: Leaflet.LatLngBoundsExpression, ?minZoom: float, ?maxZoom: float, ?maxNativeZoom: float, ?minNativeZoom: float, ?noWrap: bool, ?pane: string, ?className: string, ?keepBuffer: float) : GridLayerOptions = nativeOnly

    type DoneCallback =
        delegate of ?error: Exception * ?tile: Glutinum.Web.HTMLElement -> unit

    [<AllowNullLiteral>]
    [<Interface>]
    type InternalTiles =
        [<EmitIndexer>]
        abstract member Item: key: string -> InternalTiles.Item with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type GridLayer =
        inherit Leaflet.Layer
        abstract member bringToFront: unit -> GridLayer
        abstract member bringToBack: unit -> GridLayer
        abstract member getContainer: unit -> Glutinum.Web.HTMLElement option
        abstract member setOpacity: opacity: float -> GridLayer
        abstract member setZIndex: zIndex: float -> GridLayer
        abstract member isLoading: unit -> bool
        abstract member redraw: unit -> GridLayer
        abstract member getTileSize: unit -> Leaflet.Point

    [<AllowNullLiteral>]
    [<Interface>]
    type TileLayerOptions =
        inherit Leaflet.GridLayerOptions
        abstract member id: string option with get, set
        abstract member subdomains: U2<string, ResizeArray<string>> option with get, set
        abstract member errorTileUrl: string option with get, set
        abstract member zoomOffset: float option with get, set
        abstract member tms: bool option with get, set
        abstract member zoomReverse: bool option with get, set
        abstract member detectRetina: bool option with get, set
        abstract member crossOrigin: TileLayerOptions.crossOrigin option with get, set
        abstract member referrerPolicy: TileLayerOptions.referrerPolicy option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?attribution: string, ?opacity: float, ?updateWhenIdle: bool, ?updateWhenZooming: bool, ?updateInterval: float, ?zIndex: float, ?bounds: Leaflet.LatLngBoundsExpression, ?minZoom: float, ?maxZoom: float, ?maxNativeZoom: float, ?minNativeZoom: float, ?noWrap: bool, ?pane: string, ?className: string, ?keepBuffer: float, ?id: string, ?errorTileUrl: string, ?zoomOffset: float, ?tms: bool, ?zoomReverse: bool, ?detectRetina: bool, ?crossOrigin: TileLayerOptions.crossOrigin, ?referrerPolicy: TileLayerOptions.referrerPolicy) : TileLayerOptions = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (subdomains: string, ?attribution: string, ?opacity: float, ?updateWhenIdle: bool, ?updateWhenZooming: bool, ?updateInterval: float, ?zIndex: float, ?bounds: Leaflet.LatLngBoundsExpression, ?minZoom: float, ?maxZoom: float, ?maxNativeZoom: float, ?minNativeZoom: float, ?noWrap: bool, ?pane: string, ?className: string, ?keepBuffer: float, ?id: string, ?errorTileUrl: string, ?zoomOffset: float, ?tms: bool, ?zoomReverse: bool, ?detectRetina: bool, ?crossOrigin: TileLayerOptions.crossOrigin, ?referrerPolicy: TileLayerOptions.referrerPolicy) : TileLayerOptions = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (subdomains: ResizeArray<string>, ?attribution: string, ?opacity: float, ?updateWhenIdle: bool, ?updateWhenZooming: bool, ?updateInterval: float, ?zIndex: float, ?bounds: Leaflet.LatLngBoundsExpression, ?minZoom: float, ?maxZoom: float, ?maxNativeZoom: float, ?minNativeZoom: float, ?noWrap: bool, ?pane: string, ?className: string, ?keepBuffer: float, ?id: string, ?errorTileUrl: string, ?zoomOffset: float, ?tms: bool, ?zoomReverse: bool, ?detectRetina: bool, ?crossOrigin: TileLayerOptions.crossOrigin, ?referrerPolicy: TileLayerOptions.referrerPolicy) : TileLayerOptions = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (tileSize: float, ?attribution: string, ?opacity: float, ?updateWhenIdle: bool, ?updateWhenZooming: bool, ?updateInterval: float, ?zIndex: float, ?bounds: Leaflet.LatLngBoundsExpression, ?minZoom: float, ?maxZoom: float, ?maxNativeZoom: float, ?minNativeZoom: float, ?noWrap: bool, ?pane: string, ?className: string, ?keepBuffer: float, ?id: string, ?errorTileUrl: string, ?zoomOffset: float, ?tms: bool, ?zoomReverse: bool, ?detectRetina: bool, ?crossOrigin: TileLayerOptions.crossOrigin, ?referrerPolicy: TileLayerOptions.referrerPolicy) : TileLayerOptions = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (tileSize: float, subdomains: string, ?attribution: string, ?opacity: float, ?updateWhenIdle: bool, ?updateWhenZooming: bool, ?updateInterval: float, ?zIndex: float, ?bounds: Leaflet.LatLngBoundsExpression, ?minZoom: float, ?maxZoom: float, ?maxNativeZoom: float, ?minNativeZoom: float, ?noWrap: bool, ?pane: string, ?className: string, ?keepBuffer: float, ?id: string, ?errorTileUrl: string, ?zoomOffset: float, ?tms: bool, ?zoomReverse: bool, ?detectRetina: bool, ?crossOrigin: TileLayerOptions.crossOrigin, ?referrerPolicy: TileLayerOptions.referrerPolicy) : TileLayerOptions = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (tileSize: float, subdomains: ResizeArray<string>, ?attribution: string, ?opacity: float, ?updateWhenIdle: bool, ?updateWhenZooming: bool, ?updateInterval: float, ?zIndex: float, ?bounds: Leaflet.LatLngBoundsExpression, ?minZoom: float, ?maxZoom: float, ?maxNativeZoom: float, ?minNativeZoom: float, ?noWrap: bool, ?pane: string, ?className: string, ?keepBuffer: float, ?id: string, ?errorTileUrl: string, ?zoomOffset: float, ?tms: bool, ?zoomReverse: bool, ?detectRetina: bool, ?crossOrigin: TileLayerOptions.crossOrigin, ?referrerPolicy: TileLayerOptions.referrerPolicy) : TileLayerOptions = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (tileSize: Leaflet.Point, ?attribution: string, ?opacity: float, ?updateWhenIdle: bool, ?updateWhenZooming: bool, ?updateInterval: float, ?zIndex: float, ?bounds: Leaflet.LatLngBoundsExpression, ?minZoom: float, ?maxZoom: float, ?maxNativeZoom: float, ?minNativeZoom: float, ?noWrap: bool, ?pane: string, ?className: string, ?keepBuffer: float, ?id: string, ?errorTileUrl: string, ?zoomOffset: float, ?tms: bool, ?zoomReverse: bool, ?detectRetina: bool, ?crossOrigin: TileLayerOptions.crossOrigin, ?referrerPolicy: TileLayerOptions.referrerPolicy) : TileLayerOptions = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (tileSize: Leaflet.Point, subdomains: string, ?attribution: string, ?opacity: float, ?updateWhenIdle: bool, ?updateWhenZooming: bool, ?updateInterval: float, ?zIndex: float, ?bounds: Leaflet.LatLngBoundsExpression, ?minZoom: float, ?maxZoom: float, ?maxNativeZoom: float, ?minNativeZoom: float, ?noWrap: bool, ?pane: string, ?className: string, ?keepBuffer: float, ?id: string, ?errorTileUrl: string, ?zoomOffset: float, ?tms: bool, ?zoomReverse: bool, ?detectRetina: bool, ?crossOrigin: TileLayerOptions.crossOrigin, ?referrerPolicy: TileLayerOptions.referrerPolicy) : TileLayerOptions = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (tileSize: Leaflet.Point, subdomains: ResizeArray<string>, ?attribution: string, ?opacity: float, ?updateWhenIdle: bool, ?updateWhenZooming: bool, ?updateInterval: float, ?zIndex: float, ?bounds: Leaflet.LatLngBoundsExpression, ?minZoom: float, ?maxZoom: float, ?maxNativeZoom: float, ?minNativeZoom: float, ?noWrap: bool, ?pane: string, ?className: string, ?keepBuffer: float, ?id: string, ?errorTileUrl: string, ?zoomOffset: float, ?tms: bool, ?zoomReverse: bool, ?detectRetina: bool, ?crossOrigin: TileLayerOptions.crossOrigin, ?referrerPolicy: TileLayerOptions.referrerPolicy) : TileLayerOptions = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type TileLayer =
        inherit Leaflet.GridLayer
        abstract member setUrl: url: string * ?noRedraw: bool -> TileLayer
        abstract member getTileUrl: coords: Leaflet.Coords -> string

    module TileLayer_ =

        [<AbstractClass>]
        [<Erase>]
        type Exports =
            [<Emit("new $0.WMS($1...)")>]
            abstract member WMS: baseUrl: string * options: Leaflet.WMSOptions -> WMS

        [<AllowNullLiteral>]
        [<Interface>]
        type WMS =
            inherit Leaflet.TileLayer
            abstract member setParams: ``params``: Leaflet.WMSParams * ?noRedraw: bool -> WMS
            abstract member wmsParams: Leaflet.WMSParams with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type WMSOptions =
        inherit Leaflet.TileLayerOptions
        abstract member layers: string option with get, set
        abstract member styles: string option with get, set
        abstract member format: string option with get, set
        abstract member transparent: bool option with get, set
        abstract member version: string option with get, set
        abstract member crs: Leaflet.CRS option with get, set
        abstract member uppercase: bool option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?attribution: string, ?opacity: float, ?updateWhenIdle: bool, ?updateWhenZooming: bool, ?updateInterval: float, ?zIndex: float, ?bounds: Leaflet.LatLngBoundsExpression, ?minZoom: float, ?maxZoom: float, ?maxNativeZoom: float, ?minNativeZoom: float, ?noWrap: bool, ?pane: string, ?className: string, ?keepBuffer: float, ?id: string, ?errorTileUrl: string, ?zoomOffset: float, ?tms: bool, ?zoomReverse: bool, ?detectRetina: bool, ?crossOrigin: WMSOptions.crossOrigin, ?referrerPolicy: WMSOptions.referrerPolicy, ?layers: string, ?styles: string, ?format: string, ?transparent: bool, ?version: string, ?crs: Leaflet.CRS, ?uppercase: bool) : WMSOptions = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (subdomains: string, ?attribution: string, ?opacity: float, ?updateWhenIdle: bool, ?updateWhenZooming: bool, ?updateInterval: float, ?zIndex: float, ?bounds: Leaflet.LatLngBoundsExpression, ?minZoom: float, ?maxZoom: float, ?maxNativeZoom: float, ?minNativeZoom: float, ?noWrap: bool, ?pane: string, ?className: string, ?keepBuffer: float, ?id: string, ?errorTileUrl: string, ?zoomOffset: float, ?tms: bool, ?zoomReverse: bool, ?detectRetina: bool, ?crossOrigin: WMSOptions.crossOrigin, ?referrerPolicy: WMSOptions.referrerPolicy, ?layers: string, ?styles: string, ?format: string, ?transparent: bool, ?version: string, ?crs: Leaflet.CRS, ?uppercase: bool) : WMSOptions = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (subdomains: ResizeArray<string>, ?attribution: string, ?opacity: float, ?updateWhenIdle: bool, ?updateWhenZooming: bool, ?updateInterval: float, ?zIndex: float, ?bounds: Leaflet.LatLngBoundsExpression, ?minZoom: float, ?maxZoom: float, ?maxNativeZoom: float, ?minNativeZoom: float, ?noWrap: bool, ?pane: string, ?className: string, ?keepBuffer: float, ?id: string, ?errorTileUrl: string, ?zoomOffset: float, ?tms: bool, ?zoomReverse: bool, ?detectRetina: bool, ?crossOrigin: WMSOptions.crossOrigin, ?referrerPolicy: WMSOptions.referrerPolicy, ?layers: string, ?styles: string, ?format: string, ?transparent: bool, ?version: string, ?crs: Leaflet.CRS, ?uppercase: bool) : WMSOptions = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (tileSize: float, ?attribution: string, ?opacity: float, ?updateWhenIdle: bool, ?updateWhenZooming: bool, ?updateInterval: float, ?zIndex: float, ?bounds: Leaflet.LatLngBoundsExpression, ?minZoom: float, ?maxZoom: float, ?maxNativeZoom: float, ?minNativeZoom: float, ?noWrap: bool, ?pane: string, ?className: string, ?keepBuffer: float, ?id: string, ?errorTileUrl: string, ?zoomOffset: float, ?tms: bool, ?zoomReverse: bool, ?detectRetina: bool, ?crossOrigin: WMSOptions.crossOrigin, ?referrerPolicy: WMSOptions.referrerPolicy, ?layers: string, ?styles: string, ?format: string, ?transparent: bool, ?version: string, ?crs: Leaflet.CRS, ?uppercase: bool) : WMSOptions = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (tileSize: float, subdomains: string, ?attribution: string, ?opacity: float, ?updateWhenIdle: bool, ?updateWhenZooming: bool, ?updateInterval: float, ?zIndex: float, ?bounds: Leaflet.LatLngBoundsExpression, ?minZoom: float, ?maxZoom: float, ?maxNativeZoom: float, ?minNativeZoom: float, ?noWrap: bool, ?pane: string, ?className: string, ?keepBuffer: float, ?id: string, ?errorTileUrl: string, ?zoomOffset: float, ?tms: bool, ?zoomReverse: bool, ?detectRetina: bool, ?crossOrigin: WMSOptions.crossOrigin, ?referrerPolicy: WMSOptions.referrerPolicy, ?layers: string, ?styles: string, ?format: string, ?transparent: bool, ?version: string, ?crs: Leaflet.CRS, ?uppercase: bool) : WMSOptions = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (tileSize: float, subdomains: ResizeArray<string>, ?attribution: string, ?opacity: float, ?updateWhenIdle: bool, ?updateWhenZooming: bool, ?updateInterval: float, ?zIndex: float, ?bounds: Leaflet.LatLngBoundsExpression, ?minZoom: float, ?maxZoom: float, ?maxNativeZoom: float, ?minNativeZoom: float, ?noWrap: bool, ?pane: string, ?className: string, ?keepBuffer: float, ?id: string, ?errorTileUrl: string, ?zoomOffset: float, ?tms: bool, ?zoomReverse: bool, ?detectRetina: bool, ?crossOrigin: WMSOptions.crossOrigin, ?referrerPolicy: WMSOptions.referrerPolicy, ?layers: string, ?styles: string, ?format: string, ?transparent: bool, ?version: string, ?crs: Leaflet.CRS, ?uppercase: bool) : WMSOptions = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (tileSize: Leaflet.Point, ?attribution: string, ?opacity: float, ?updateWhenIdle: bool, ?updateWhenZooming: bool, ?updateInterval: float, ?zIndex: float, ?bounds: Leaflet.LatLngBoundsExpression, ?minZoom: float, ?maxZoom: float, ?maxNativeZoom: float, ?minNativeZoom: float, ?noWrap: bool, ?pane: string, ?className: string, ?keepBuffer: float, ?id: string, ?errorTileUrl: string, ?zoomOffset: float, ?tms: bool, ?zoomReverse: bool, ?detectRetina: bool, ?crossOrigin: WMSOptions.crossOrigin, ?referrerPolicy: WMSOptions.referrerPolicy, ?layers: string, ?styles: string, ?format: string, ?transparent: bool, ?version: string, ?crs: Leaflet.CRS, ?uppercase: bool) : WMSOptions = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (tileSize: Leaflet.Point, subdomains: string, ?attribution: string, ?opacity: float, ?updateWhenIdle: bool, ?updateWhenZooming: bool, ?updateInterval: float, ?zIndex: float, ?bounds: Leaflet.LatLngBoundsExpression, ?minZoom: float, ?maxZoom: float, ?maxNativeZoom: float, ?minNativeZoom: float, ?noWrap: bool, ?pane: string, ?className: string, ?keepBuffer: float, ?id: string, ?errorTileUrl: string, ?zoomOffset: float, ?tms: bool, ?zoomReverse: bool, ?detectRetina: bool, ?crossOrigin: WMSOptions.crossOrigin, ?referrerPolicy: WMSOptions.referrerPolicy, ?layers: string, ?styles: string, ?format: string, ?transparent: bool, ?version: string, ?crs: Leaflet.CRS, ?uppercase: bool) : WMSOptions = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (tileSize: Leaflet.Point, subdomains: ResizeArray<string>, ?attribution: string, ?opacity: float, ?updateWhenIdle: bool, ?updateWhenZooming: bool, ?updateInterval: float, ?zIndex: float, ?bounds: Leaflet.LatLngBoundsExpression, ?minZoom: float, ?maxZoom: float, ?maxNativeZoom: float, ?minNativeZoom: float, ?noWrap: bool, ?pane: string, ?className: string, ?keepBuffer: float, ?id: string, ?errorTileUrl: string, ?zoomOffset: float, ?tms: bool, ?zoomReverse: bool, ?detectRetina: bool, ?crossOrigin: WMSOptions.crossOrigin, ?referrerPolicy: WMSOptions.referrerPolicy, ?layers: string, ?styles: string, ?format: string, ?transparent: bool, ?version: string, ?crs: Leaflet.CRS, ?uppercase: bool) : WMSOptions = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type WMSParams =
        abstract member format: string option with get, set
        abstract member layers: string with get, set
        abstract member request: string option with get, set
        abstract member service: string option with get, set
        abstract member styles: string option with get, set
        abstract member version: string option with get, set
        abstract member transparent: bool option with get, set
        abstract member width: float option with get, set
        abstract member height: float option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (layers: string, ?format: string, ?request: string, ?service: string, ?styles: string, ?version: string, ?transparent: bool, ?width: float, ?height: float) : WMSParams = nativeOnly

    module tileLayer_ =

        [<AbstractClass>]
        [<Erase>]
        type Exports =
            [<Emit("$0.wms($1...)")>]
            abstract member wms: baseUrl: string * ?options: Leaflet.WMSOptions -> Leaflet.TileLayer_.WMS

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type CrossOrigin =
        | anonymous
        | ``use-credentials``
        | [<CompiledName("")>] _EMPTY_

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type ReferrerPolicy =
        | ``no-referrer``
        | ``no-referrer-when-downgrade``
        | origin
        | ``origin-when-cross-origin``
        | ``same-origin``
        | ``strict-origin``
        | ``strict-origin-when-cross-origin``
        | ``unsafe-url``

    [<AllowNullLiteral>]
    [<Interface>]
    type ImageOverlayOptions =
        inherit Leaflet.InteractiveLayerOptions
        abstract member opacity: float option with get, set
        abstract member alt: string option with get, set
        abstract member interactive: bool option with get, set
        abstract member crossOrigin: ImageOverlayOptions.crossOrigin option with get, set
        abstract member errorOverlayUrl: string option with get, set
        abstract member zIndex: float option with get, set
        abstract member className: string option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?pane: string, ?attribution: string, ?bubblingMouseEvents: bool, ?opacity: float, ?alt: string, ?interactive: bool, ?crossOrigin: ImageOverlayOptions.crossOrigin, ?errorOverlayUrl: string, ?zIndex: float, ?className: string) : ImageOverlayOptions = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type ImageOverlayStyleOptions =
        abstract member opacity: float option with get, set
        [<EmitIndexer>]
        abstract member Item: name: string -> obj with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?opacity: float) : ImageOverlayStyleOptions = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type ImageOverlay =
        inherit Leaflet.Layer
        abstract member bringToFront: unit -> ImageOverlay
        abstract member bringToBack: unit -> ImageOverlay
        abstract member setUrl: url: string -> ImageOverlay
        /// <summary>
        /// Update the bounds that this ImageOverlay covers
        /// </summary>
        abstract member setBounds: bounds: Leaflet.LatLngBounds -> ImageOverlay
        /// <summary>
        /// Changes the zIndex of the image overlay
        /// </summary>
        abstract member setZIndex: value: float -> ImageOverlay
        /// <summary>
        /// Changes the opacity of the image element
        /// </summary>
        abstract member setOpacity: opacity: float -> ImageOverlay
        /// <summary>
        /// Changes the style of the image element. As of 1.8, only the opacity is changed
        /// </summary>
        abstract member setStyle: styleOpts: Leaflet.ImageOverlayStyleOptions -> ImageOverlay
        /// <summary>
        /// Get the bounds that this ImageOverlay covers
        /// </summary>
        abstract member getBounds: unit -> Leaflet.LatLngBounds
        /// <summary>
        /// Get the center of the bounds this ImageOverlay covers
        /// </summary>
        abstract member getCenter: unit -> Leaflet.LatLng
        /// <summary>
        /// Get the img element that represents the ImageOverlay on the map
        /// </summary>
        abstract member getElement: unit -> Glutinum.Web.HTMLImageElement option

    type SVGOverlayStyleOptions =
        Leaflet.ImageOverlayStyleOptions

    [<AllowNullLiteral>]
    [<Interface>]
    type SVGOverlay =
        inherit Leaflet.Layer
        abstract member bringToFront: unit -> SVGOverlay
        abstract member bringToBack: unit -> SVGOverlay
        abstract member setUrl: url: string -> SVGOverlay
        /// <summary>
        /// Update the bounds that this SVGOverlay covers
        /// </summary>
        abstract member setBounds: bounds: Leaflet.LatLngBounds -> SVGOverlay
        /// <summary>
        /// Changes the zIndex of the image overlay
        /// </summary>
        abstract member setZIndex: value: float -> SVGOverlay
        /// <summary>
        /// Changes the opacity of the image element
        /// </summary>
        abstract member setOpacity: opacity: float -> SVGOverlay
        /// <summary>
        /// Changes the style of the image element. As of 1.8, only the opacity is changed
        /// </summary>
        abstract member setStyle: styleOpts: Leaflet.SVGOverlayStyleOptions -> SVGOverlay
        /// <summary>
        /// Get the bounds that this SVGOverlay covers
        /// </summary>
        abstract member getBounds: unit -> Leaflet.LatLngBounds
        /// <summary>
        /// Get the center of the bounds this ImageOverlay covers
        /// </summary>
        abstract member getCenter: unit -> Leaflet.LatLng
        /// <summary>
        /// Get the img element that represents the SVGOverlay on the map
        /// </summary>
        abstract member getElement: unit -> Glutinum.Web.SVGElement option

    [<AllowNullLiteral>]
    [<Interface>]
    type VideoOverlayOptions =
        inherit Leaflet.ImageOverlayOptions
        /// <summary>
        /// Whether the video starts playing automatically when loaded.
        /// </summary>
        abstract member autoplay: bool option with get, set
        /// <summary>
        /// Whether the video will loop back to the beginning when played.
        /// </summary>
        abstract member loop: bool option with get, set
        /// <summary>
        /// Whether the video will save aspect ratio after the projection. Relevant for supported browsers. See
        /// [browser compatibility](https://developer.mozilla.org/en-US/docs/Web/CSS/object-fit)
        /// </summary>
        abstract member keepAspectRatio: bool option with get, set
        /// <summary>
        /// Whether the video starts on mute when loaded.
        /// </summary>
        abstract member muted: bool option with get, set
        abstract member playsInline: bool option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?pane: string, ?attribution: string, ?bubblingMouseEvents: bool, ?opacity: float, ?alt: string, ?interactive: bool, ?crossOrigin: VideoOverlayOptions.crossOrigin, ?errorOverlayUrl: string, ?zIndex: float, ?className: string, ?autoplay: bool, ?loop: bool, ?keepAspectRatio: bool, ?muted: bool, ?playsInline: bool) : VideoOverlayOptions = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type VideoOverlay =
        inherit Leaflet.Layer
        abstract member bringToFront: unit -> VideoOverlay
        abstract member bringToBack: unit -> VideoOverlay
        abstract member setUrl: url: string -> VideoOverlay
        /// <summary>
        /// Update the bounds that this VideoOverlay covers
        /// </summary>
        abstract member setBounds: bounds: Leaflet.LatLngBounds -> VideoOverlay
        /// <summary>
        /// Changes the zIndex of the image overlay
        /// </summary>
        abstract member setZIndex: value: float -> VideoOverlay
        /// <summary>
        /// Changes the opacity of the image element
        /// </summary>
        abstract member setOpacity: opacity: float -> VideoOverlay
        /// <summary>
        /// Changes the style of the image element. As of 1.8, only the opacity is changed
        /// </summary>
        abstract member setStyle: styleOpts: Leaflet.SVGOverlayStyleOptions -> VideoOverlay
        /// <summary>
        /// Get the bounds that this VideoOverlay covers
        /// </summary>
        abstract member getBounds: unit -> Leaflet.LatLngBounds
        /// <summary>
        /// Get the center of the bounds this ImageOverlay covers
        /// </summary>
        abstract member getCenter: unit -> Leaflet.LatLng
        /// <summary>
        /// Get the video element that represents the VideoOverlay on the map
        /// </summary>
        abstract member getElement: unit -> Glutinum.Web.HTMLVideoElement option

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type LineCapShape =
        | butt
        | round
        | square
        | ``inherit``

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type LineJoinShape =
        | miter
        | round
        | bevel
        | ``inherit``

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type FillRule =
        | nonzero
        | evenodd
        | ``inherit``

    [<AllowNullLiteral>]
    [<Interface>]
    type PathOptions =
        inherit Leaflet.InteractiveLayerOptions
        abstract member stroke: bool option with get, set
        abstract member color: string option with get, set
        abstract member weight: float option with get, set
        abstract member opacity: float option with get, set
        abstract member lineCap: Leaflet.LineCapShape option with get, set
        abstract member lineJoin: Leaflet.LineJoinShape option with get, set
        abstract member dashArray: U2<string, ResizeArray<float>> option with get, set
        abstract member dashOffset: string option with get, set
        abstract member fill: bool option with get, set
        abstract member fillColor: string option with get, set
        abstract member fillOpacity: float option with get, set
        abstract member fillRule: Leaflet.FillRule option with get, set
        abstract member renderer: Leaflet.Renderer option with get, set
        abstract member className: string option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?pane: string, ?attribution: string, ?interactive: bool, ?bubblingMouseEvents: bool, ?stroke: bool, ?color: string, ?weight: float, ?opacity: float, ?lineCap: Leaflet.LineCapShape, ?lineJoin: Leaflet.LineJoinShape, ?dashOffset: string, ?fill: bool, ?fillColor: string, ?fillOpacity: float, ?fillRule: Leaflet.FillRule, ?renderer: Leaflet.Renderer, ?className: string) : PathOptions = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (dashArray: string, ?pane: string, ?attribution: string, ?interactive: bool, ?bubblingMouseEvents: bool, ?stroke: bool, ?color: string, ?weight: float, ?opacity: float, ?lineCap: Leaflet.LineCapShape, ?lineJoin: Leaflet.LineJoinShape, ?dashOffset: string, ?fill: bool, ?fillColor: string, ?fillOpacity: float, ?fillRule: Leaflet.FillRule, ?renderer: Leaflet.Renderer, ?className: string) : PathOptions = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (dashArray: ResizeArray<float>, ?pane: string, ?attribution: string, ?interactive: bool, ?bubblingMouseEvents: bool, ?stroke: bool, ?color: string, ?weight: float, ?opacity: float, ?lineCap: Leaflet.LineCapShape, ?lineJoin: Leaflet.LineJoinShape, ?dashOffset: string, ?fill: bool, ?fillColor: string, ?fillOpacity: float, ?fillRule: Leaflet.FillRule, ?renderer: Leaflet.Renderer, ?className: string) : PathOptions = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type Path =
        inherit Leaflet.Layer
        abstract member redraw: unit -> Path
        abstract member setStyle: style: Leaflet.PathOptions -> Path
        abstract member bringToFront: unit -> Path
        abstract member bringToBack: unit -> Path
        abstract member getElement: unit -> Glutinum.Web.Element option

    [<AllowNullLiteral>]
    [<Interface>]
    type PolylineOptions =
        inherit Leaflet.PathOptions
        abstract member smoothFactor: float option with get, set
        abstract member noClip: bool option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?pane: string, ?attribution: string, ?interactive: bool, ?bubblingMouseEvents: bool, ?stroke: bool, ?color: string, ?weight: float, ?opacity: float, ?lineCap: Leaflet.LineCapShape, ?lineJoin: Leaflet.LineJoinShape, ?dashOffset: string, ?fill: bool, ?fillColor: string, ?fillOpacity: float, ?fillRule: Leaflet.FillRule, ?renderer: Leaflet.Renderer, ?className: string, ?smoothFactor: float, ?noClip: bool) : PolylineOptions = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (dashArray: string, ?pane: string, ?attribution: string, ?interactive: bool, ?bubblingMouseEvents: bool, ?stroke: bool, ?color: string, ?weight: float, ?opacity: float, ?lineCap: Leaflet.LineCapShape, ?lineJoin: Leaflet.LineJoinShape, ?dashOffset: string, ?fill: bool, ?fillColor: string, ?fillOpacity: float, ?fillRule: Leaflet.FillRule, ?renderer: Leaflet.Renderer, ?className: string, ?smoothFactor: float, ?noClip: bool) : PolylineOptions = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (dashArray: ResizeArray<float>, ?pane: string, ?attribution: string, ?interactive: bool, ?bubblingMouseEvents: bool, ?stroke: bool, ?color: string, ?weight: float, ?opacity: float, ?lineCap: Leaflet.LineCapShape, ?lineJoin: Leaflet.LineJoinShape, ?dashOffset: string, ?fill: bool, ?fillColor: string, ?fillOpacity: float, ?fillRule: Leaflet.FillRule, ?renderer: Leaflet.Renderer, ?className: string, ?smoothFactor: float, ?noClip: bool) : PolylineOptions = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type Polyline<'T, 'P> =
        inherit Leaflet.Path
        abstract member toGeoJSON: ?precision: U2<float, bool> -> Glutinum.Geojson.Feature<'T, 'P>
        abstract member getLatLngs: unit -> U3<ResizeArray<Leaflet.LatLng>, ResizeArray<ResizeArray<Leaflet.LatLng>>, ResizeArray<ResizeArray<ResizeArray<Leaflet.LatLng>>>>
        abstract member setLatLngs: latlngs: ResizeArray<Leaflet.LatLngExpression> -> Polyline<'T, 'P>
        abstract member setLatLngs: latlngs: ResizeArray<ResizeArray<Leaflet.LatLngExpression>> -> Polyline<'T, 'P>
        abstract member setLatLngs: latlngs: ResizeArray<ResizeArray<ResizeArray<Leaflet.LatLngExpression>>> -> Polyline<'T, 'P>
        abstract member setLatLngs: latlngs: U3<ResizeArray<Leaflet.LatLngExpression>, ResizeArray<ResizeArray<Leaflet.LatLngExpression>>, ResizeArray<ResizeArray<ResizeArray<Leaflet.LatLngExpression>>>> -> Polyline<'T, 'P>
        abstract member isEmpty: unit -> bool
        abstract member getCenter: unit -> Leaflet.LatLng
        abstract member getBounds: unit -> Leaflet.LatLngBounds
        abstract member addLatLng: latlng: Leaflet.LatLng * ?latlngs: ResizeArray<Leaflet.LatLng> -> Polyline<'T, 'P>
        abstract member addLatLng: latlng: Leaflet.LatLngLiteral * ?latlngs: ResizeArray<Leaflet.LatLng> -> Polyline<'T, 'P>
        abstract member addLatLng: latlng: Leaflet.LatLngTuple * ?latlngs: ResizeArray<Leaflet.LatLng> -> Polyline<'T, 'P>
        abstract member addLatLng: latlng: ResizeArray<Leaflet.LatLngExpression> * ?latlngs: ResizeArray<Leaflet.LatLng> -> Polyline<'T, 'P>
        abstract member addLatLng: latlng: U2<Leaflet.LatLngExpression, ResizeArray<Leaflet.LatLngExpression>> * ?latlngs: ResizeArray<Leaflet.LatLng> -> Polyline<'T, 'P>
        abstract member closestLayerPoint: p: Leaflet.Point -> Leaflet.Point
        abstract member feature: Glutinum.Geojson.Feature<'T, 'P> option with get, set

    type Polyline<'T> =
        Polyline<'T, obj>

    type Polyline =
        Polyline<U2<Glutinum.Geojson.LineString, Glutinum.Geojson.MultiLineString>, obj>

    [<AllowNullLiteral>]
    [<Interface>]
    type Polygon<'P> =
        inherit Leaflet.Polyline<U2<Glutinum.Geojson.Polygon, Glutinum.Geojson.MultiPolygon>, 'P>

    type Polygon =
        Polygon<obj>

    [<AllowNullLiteral>]
    [<Interface>]
    type Rectangle<'P> =
        inherit Leaflet.Polygon<'P>
        abstract member setBounds: latLngBounds: Leaflet.LatLngBounds -> Rectangle<'P>
        abstract member setBounds: latLngBounds: Leaflet.LatLngBoundsLiteral -> Rectangle<'P>
        abstract member setBounds: latLngBounds: Leaflet.LatLngBoundsExpression -> Rectangle<'P>

    type Rectangle =
        Rectangle<obj>

    [<AllowNullLiteral>]
    [<Interface>]
    type CircleMarkerOptions =
        inherit Leaflet.PathOptions
        abstract member radius: float option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?pane: string, ?attribution: string, ?interactive: bool, ?bubblingMouseEvents: bool, ?stroke: bool, ?color: string, ?weight: float, ?opacity: float, ?lineCap: Leaflet.LineCapShape, ?lineJoin: Leaflet.LineJoinShape, ?dashOffset: string, ?fill: bool, ?fillColor: string, ?fillOpacity: float, ?fillRule: Leaflet.FillRule, ?renderer: Leaflet.Renderer, ?className: string, ?radius: float) : CircleMarkerOptions = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (dashArray: string, ?pane: string, ?attribution: string, ?interactive: bool, ?bubblingMouseEvents: bool, ?stroke: bool, ?color: string, ?weight: float, ?opacity: float, ?lineCap: Leaflet.LineCapShape, ?lineJoin: Leaflet.LineJoinShape, ?dashOffset: string, ?fill: bool, ?fillColor: string, ?fillOpacity: float, ?fillRule: Leaflet.FillRule, ?renderer: Leaflet.Renderer, ?className: string, ?radius: float) : CircleMarkerOptions = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (dashArray: ResizeArray<float>, ?pane: string, ?attribution: string, ?interactive: bool, ?bubblingMouseEvents: bool, ?stroke: bool, ?color: string, ?weight: float, ?opacity: float, ?lineCap: Leaflet.LineCapShape, ?lineJoin: Leaflet.LineJoinShape, ?dashOffset: string, ?fill: bool, ?fillColor: string, ?fillOpacity: float, ?fillRule: Leaflet.FillRule, ?renderer: Leaflet.Renderer, ?className: string, ?radius: float) : CircleMarkerOptions = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type CircleMarker<'P> =
        inherit Leaflet.Path
        abstract member toGeoJSON: ?precision: U2<float, bool> -> Glutinum.Geojson.Feature<Glutinum.Geojson.Point, 'P>
        abstract member setLatLng: latLng: Leaflet.LatLng -> CircleMarker<'P>
        abstract member setLatLng: latLng: Leaflet.LatLngLiteral -> CircleMarker<'P>
        abstract member setLatLng: latLng: Leaflet.LatLngTuple -> CircleMarker<'P>
        abstract member setLatLng: latLng: Leaflet.LatLngExpression -> CircleMarker<'P>
        abstract member getLatLng: unit -> Leaflet.LatLng
        abstract member setRadius: radius: float -> CircleMarker<'P>
        abstract member getRadius: unit -> float
        abstract member setStyle: options: CircleMarker.setStyle.options -> CircleMarker<'P>
        abstract member feature: Glutinum.Geojson.Feature<Glutinum.Geojson.Point, 'P> option with get, set

    type CircleMarker =
        CircleMarker<obj>

    type CircleOptions =
        Leaflet.CircleMarkerOptions

    [<AllowNullLiteral>]
    [<Interface>]
    type Circle<'P> =
        inherit Leaflet.CircleMarker<'P>
        abstract member toGeoJSON: ?precision: U2<float, bool> -> obj
        abstract member getBounds: unit -> Leaflet.LatLngBounds
        abstract member setRadius: radius: float -> Circle<'P>
        abstract member getRadius: unit -> float
        abstract member setStyle: style: Leaflet.PathOptions -> Circle<'P>

    type Circle =
        Circle<obj>

    [<AllowNullLiteral>]
    [<Interface>]
    type RendererOptions =
        inherit Leaflet.LayerOptions
        abstract member padding: float option with get, set
        abstract member tolerance: float option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?pane: string, ?attribution: string, ?padding: float, ?tolerance: float) : RendererOptions = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type Renderer =
        inherit Leaflet.Layer

    [<AllowNullLiteral>]
    [<Interface>]
    type SVG =
        inherit Leaflet.Renderer

    module SVG_ =

        [<AbstractClass>]
        [<Erase>]
        type Exports =
            [<Emit("$0.create($1...)")>]
            abstract member create<'K>: name: Glutinum.Web.SVGElementTagNameMap.Key<'K> -> 'K
            [<Emit("$0.create($1...)")>]
            abstract member create: name: string -> Glutinum.Web.SVGElement
            [<Emit("$0.pointsToPath($1...)")>]
            abstract member pointsToPath: rings: ResizeArray<Leaflet.PointExpression> * closed: bool -> string

    [<AllowNullLiteral>]
    [<Interface>]
    type Canvas =
        inherit Leaflet.Renderer

    /// <summary>
    /// Used to group several layers and handle them as one.
    /// If you add it to the map, any layers added or removed from the group will be
    /// added/removed on the map as well. Extends Layer.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type LayerGroup<'P> =
        inherit Leaflet.Layer
        abstract member toMultiPoint: ?precision: float -> Glutinum.Geojson.Feature<Glutinum.Geojson.MultiPoint, 'P>
        /// <summary>
        /// Returns a GeoJSON representation of the layer group (as a GeoJSON GeometryCollection, GeoJSONFeatureCollection or Multipoint).
        /// </summary>
        abstract member toGeoJSON: ?precision: U2<float, bool> -> U3<Glutinum.Geojson.FeatureCollection<Glutinum.Geojson.GeometryObject, 'P>, Glutinum.Geojson.Feature<Glutinum.Geojson.MultiPoint, 'P>, Glutinum.Geojson.GeometryCollection>
        /// <summary>
        /// Adds the given layer to the group.
        /// </summary>
        abstract member addLayer: layer: Leaflet.Layer -> LayerGroup<'P>
        /// <summary>
        /// Removes the layer with the given internal ID or the given layer from the group.
        /// </summary>
        abstract member removeLayer: layer: float -> LayerGroup<'P>
        /// <summary>
        /// Removes the layer with the given internal ID or the given layer from the group.
        /// </summary>
        abstract member removeLayer: layer: Leaflet.Layer -> LayerGroup<'P>
        /// <summary>
        /// Removes the layer with the given internal ID or the given layer from the group.
        /// </summary>
        abstract member removeLayer: layer: U2<float, Leaflet.Layer> -> LayerGroup<'P>
        /// <summary>
        /// Returns true if the given layer is currently added to the group.
        /// </summary>
        abstract member hasLayer: layer: Leaflet.Layer -> bool
        /// <summary>
        /// Removes all the layers from the group.
        /// </summary>
        abstract member clearLayers: unit -> LayerGroup<'P>
        /// <summary>
        /// Calls methodName on every layer contained in this group, passing any additional parameters.
        /// Has no effect if the layers contained do not implement methodName.
        /// </summary>
        abstract member invoke: methodName: string * [<ParamArray>] ``params``: obj [] -> LayerGroup<'P>
        /// <summary>
        /// Iterates over the layers of the group,
        /// optionally specifying context of the iterator function.
        /// </summary>
        abstract member eachLayer: fn: (Leaflet.Layer -> unit) * ?context: obj -> LayerGroup<'P>
        /// <summary>
        /// Returns the layer with the given internal ID.
        /// </summary>
        abstract member getLayer: id: float -> Leaflet.Layer option
        /// <summary>
        /// Returns an array of all the layers added to the group.
        /// </summary>
        abstract member getLayers: unit -> ResizeArray<Leaflet.Layer>
        /// <summary>
        /// Calls setZIndex on every layer contained in this group, passing the z-index.
        /// </summary>
        abstract member setZIndex: zIndex: float -> LayerGroup<'P>
        /// <summary>
        /// Returns the internal ID for a layer
        /// </summary>
        abstract member getLayerId: layer: Leaflet.Layer -> float
        abstract member feature: U3<Glutinum.Geojson.FeatureCollection<Glutinum.Geojson.GeometryObject, 'P>, Glutinum.Geojson.Feature<Glutinum.Geojson.MultiPoint, 'P>, Glutinum.Geojson.GeometryCollection> option with get, set

    type LayerGroup =
        LayerGroup<obj>

    /// <summary>
    /// Extended LayerGroup that also has mouse events (propagated from
    /// members of the group) and a shared bindPopup method.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type FeatureGroup<'P> =
        inherit Leaflet.LayerGroup<'P>
        /// <summary>
        /// Adds the given layer to the group.
        /// </summary>
        abstract member addLayer: layer: Leaflet.Layer -> FeatureGroup<'P>
        /// <summary>
        /// Removes the layer with the given internal ID or the given layer from the group.
        /// </summary>
        abstract member removeLayer: layer: float -> FeatureGroup<'P>
        /// <summary>
        /// Removes the layer with the given internal ID or the given layer from the group.
        /// </summary>
        abstract member removeLayer: layer: Leaflet.Layer -> FeatureGroup<'P>
        /// <summary>
        /// Removes the layer with the given internal ID or the given layer from the group.
        /// </summary>
        abstract member removeLayer: layer: U2<float, Leaflet.Layer> -> FeatureGroup<'P>
        /// <summary>
        /// Sets the given path options to each layer of the group that has a setStyle method.
        /// </summary>
        abstract member setStyle: style: Leaflet.PathOptions -> FeatureGroup<'P>
        /// <summary>
        /// Brings the layer group to the top of all other layers
        /// </summary>
        abstract member bringToFront: unit -> FeatureGroup<'P>
        /// <summary>
        /// Brings the layer group to the top [sic] of all other layers
        /// </summary>
        abstract member bringToBack: unit -> FeatureGroup<'P>
        /// <summary>
        /// Returns the LatLngBounds of the Feature Group (created from
        /// bounds and coordinates of its children).
        /// </summary>
        abstract member getBounds: unit -> Leaflet.LatLngBounds

    type FeatureGroup =
        FeatureGroup<obj>

    type StyleFunction<'P> =
        delegate of ?feature: Glutinum.Geojson.Feature<Glutinum.Geojson.GeometryObject, 'P> -> Leaflet.PathOptions

    [<AllowNullLiteral>]
    [<Interface>]
    type GeoJSONOptions<'P, 'G> =
        inherit Leaflet.InteractiveLayerOptions
        /// <summary>
        /// A Function defining how GeoJSON points spawn Leaflet layers.
        /// It is internally called when data is added, passing the GeoJSON point
        /// feature and its LatLng.
        ///
        /// The default is to spawn a default Marker:
        ///
        /// <code>
        /// function(geoJsonPoint, latlng) {
        ///     return L.marker(latlng);
        /// }
        /// </code>
        /// </summary>
        abstract member pointToLayer: GeoJSONOptions.pointToLayer option with get, set
        /// <summary>
        /// PathOptions or a Function defining the Path options for styling GeoJSON lines and polygons,
        /// called internally when data is added.
        ///
        /// The default value is to not override any defaults:
        ///
        /// <code>
        /// function (geoJsonFeature) {
        ///     return {}
        /// }
        /// </code>
        /// </summary>
        abstract member style: U2<Leaflet.PathOptions, Leaflet.StyleFunction<'P>> option with get, set
        /// <summary>
        /// A Function that will be called once for each created Feature, after it
        /// has been created and styled. Useful for attaching events and popups to features.
        ///
        /// The default is to do nothing with the newly created layers:
        ///
        /// <code>
        /// function (feature, layer) {}
        /// </code>
        /// </summary>
        abstract member onEachFeature: GeoJSONOptions.onEachFeature option with get, set
        /// <summary>
        /// A Function that will be used to decide whether to show a feature or not.
        ///
        /// The default is to show all features:
        ///
        /// <code>
        /// function (geoJsonFeature) {
        ///     return true;
        /// }
        /// </code>
        /// </summary>
        abstract member filter: (Glutinum.Geojson.Feature<'G, 'P> -> bool) option with get, set
        /// <summary>
        /// A Function that will be used for converting GeoJSON coordinates to LatLngs.
        /// The default is the coordsToLatLng static method.
        /// </summary>
        abstract member coordsToLatLng: (float * float -> Leaflet.LatLng) option with get, set
        /// <summary>
        /// Whether default Markers for "Point" type Features inherit from group options.
        /// </summary>
        abstract member markersInheritOptions: bool option with get, set

    /// <summary>
    /// Represents a GeoJSON object or an array of GeoJSON objects.
    /// Allows you to parse GeoJSON data and display it on the map. Extends FeatureGroup.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type GeoJSON<'P, 'G> =
        inherit Leaflet.FeatureGroup<'P>
        /// <summary>
        /// Convert layer into GeoJSON feature
        /// </summary>
        [<Emit("""import { GeoJSON } from "leaflet";
GeoJSON.getFeature($0, $1)""")>]
        static member inline getFeature (layer: Leaflet.Layer, newGeometry: Glutinum.Geojson.Feature<'G, 'P>): Glutinum.Geojson.Feature<'G, 'P> = nativeOnly
        /// <summary>
        /// Convert layer into GeoJSON feature
        /// </summary>
        [<Emit("""import { GeoJSON } from "leaflet";
GeoJSON.getFeature($0, $1)""")>]
        static member inline getFeature (layer: Leaflet.Layer, newGeometry: 'G): Glutinum.Geojson.Feature<'G, 'P> = nativeOnly
        /// <summary>
        /// Convert layer into GeoJSON feature
        /// </summary>
        [<Emit("""import { GeoJSON } from "leaflet";
GeoJSON.getFeature($0, $1)""")>]
        static member inline getFeature (layer: Leaflet.Layer, newGeometry: U2<Glutinum.Geojson.Feature<'G, 'P>, 'G>): Glutinum.Geojson.Feature<'G, 'P> = nativeOnly
        /// <summary>
        /// Convert layer into GeoJSON feature
        /// </summary>
        [<Emit("""import { GeoJSON } from "leaflet";
GeoJSON.getFeature($0, $1)""")>]
        static member inline getFeature (layer: Leaflet.Layer, newGeometry: Glutinum.Geojson.Feature<Glutinum.Geojson.GeometryObject, obj>): Glutinum.Geojson.Feature<Glutinum.Geojson.GeometryObject, obj> = nativeOnly
        /// <summary>
        /// Convert layer into GeoJSON feature
        /// </summary>
        [<Emit("""import { GeoJSON } from "leaflet";
GeoJSON.getFeature($0, $1)""")>]
        static member inline getFeature (layer: Leaflet.Layer, newGeometry: Glutinum.Geojson.GeometryObject): Glutinum.Geojson.Feature<Glutinum.Geojson.GeometryObject, obj> = nativeOnly
        /// <summary>
        /// Convert layer into GeoJSON feature
        /// </summary>
        [<Emit("""import { GeoJSON } from "leaflet";
GeoJSON.getFeature($0, $1)""")>]
        static member inline getFeature (layer: Leaflet.Layer, newGeometry: U2<Glutinum.Geojson.Feature<Glutinum.Geojson.GeometryObject, obj>, Glutinum.Geojson.GeometryObject>): Glutinum.Geojson.Feature<Glutinum.Geojson.GeometryObject, obj> = nativeOnly
        /// <summary>
        /// Creates a Layer from a given GeoJSON feature. Can use a custom pointToLayer
        /// and/or coordsToLatLng functions if provided as options.
        /// </summary>
        [<Emit("""import { GeoJSON } from "leaflet";
GeoJSON.geometryToLayer($0, $1)""")>]
        static member inline geometryToLayer (featureData: Glutinum.Geojson.Feature<'G, 'P>, ?options: Leaflet.GeoJSONOptions<'P, 'G>): Leaflet.Layer = nativeOnly
        /// <summary>
        /// Creates a Layer from a given GeoJSON feature. Can use a custom pointToLayer
        /// and/or coordsToLatLng functions if provided as options.
        /// </summary>
        [<Emit("""import { GeoJSON } from "leaflet";
GeoJSON.geometryToLayer($0, $1)""")>]
        static member inline geometryToLayer (featureData: Glutinum.Geojson.Feature<Glutinum.Geojson.GeometryObject, obj>, ?options: Leaflet.GeoJSONOptions<obj, Glutinum.Geojson.GeometryObject>): Leaflet.Layer = nativeOnly
        /// <summary>
        /// Creates a LatLng object from an array of 2 numbers (longitude, latitude) or
        /// 3 numbers (longitude, latitude, altitude) used in GeoJSON for points.
        /// </summary>
        [<Emit("""import { GeoJSON } from "leaflet";
GeoJSON.coordsToLatLng($0)""")>]
        static member inline coordsToLatLng (coords: (float * float)): Leaflet.LatLng = nativeOnly
        /// <summary>
        /// Creates a LatLng object from an array of 2 numbers (longitude, latitude) or
        /// 3 numbers (longitude, latitude, altitude) used in GeoJSON for points.
        /// </summary>
        [<Emit("""import { GeoJSON } from "leaflet";
GeoJSON.coordsToLatLng($0)""")>]
        static member inline coordsToLatLng (coords: (float * float * float)): Leaflet.LatLng = nativeOnly
        /// <summary>
        /// Creates a LatLng object from an array of 2 numbers (longitude, latitude) or
        /// 3 numbers (longitude, latitude, altitude) used in GeoJSON for points.
        /// </summary>
        [<Emit("""import { GeoJSON } from "leaflet";
GeoJSON.coordsToLatLng($0)""")>]
        static member inline coordsToLatLng (coords: U2<float * float, float * float * float>): Leaflet.LatLng = nativeOnly
        /// <summary>
        /// Creates a multidimensional array of LatLngs from a GeoJSON coordinates array.
        /// levelsDeep specifies the nesting level (0 is for an array of points, 1 for an array of
        /// arrays of points, etc., 0 by default).
        /// Can use a custom coordsToLatLng function.
        /// </summary>
        [<Emit("""import { GeoJSON } from "leaflet";
GeoJSON.coordsToLatLngs($0, $1, $2)""")>]
        static member inline coordsToLatLngs (coords: ResizeArray<obj>, ?levelsDeep: float, ?coordsToLatLng: (U2<float * float, float * float * float> -> Leaflet.LatLng)): ResizeArray<obj> = nativeOnly
        /// <summary>
        /// Reverse of coordsToLatLng
        /// </summary>
        [<Emit("""import { GeoJSON } from "leaflet";
GeoJSON.latLngToCoords($0)""")>]
        static member inline latLngToCoords (latlng: Leaflet.LatLng): U2<float * float, float * float * float> = nativeOnly
        /// <summary>
        /// Reverse of coordsToLatLngs closed determines whether the first point should be
        /// appended to the end of the array to close the feature, only used when levelsDeep is 0.
        /// False by default.
        /// </summary>
        [<Emit("""import { GeoJSON } from "leaflet";
GeoJSON.latLngsToCoords($0, $1, $2)""")>]
        static member inline latLngsToCoords (latlngs: ResizeArray<obj>, ?levelsDeep: float, ?closed: bool): ResizeArray<obj> = nativeOnly
        /// <summary>
        /// Normalize GeoJSON geometries/features into GeoJSON features.
        /// </summary>
        [<Emit("""import { GeoJSON } from "leaflet";
GeoJSON.asFeature($0)""")>]
        static member inline asFeature (geojson: Glutinum.Geojson.Feature<'G, 'P>): Glutinum.Geojson.Feature<'G, 'P> = nativeOnly
        /// <summary>
        /// Normalize GeoJSON geometries/features into GeoJSON features.
        /// </summary>
        [<Emit("""import { GeoJSON } from "leaflet";
GeoJSON.asFeature($0)""")>]
        static member inline asFeature (geojson: 'G): Glutinum.Geojson.Feature<'G, 'P> = nativeOnly
        /// <summary>
        /// Normalize GeoJSON geometries/features into GeoJSON features.
        /// </summary>
        [<Emit("""import { GeoJSON } from "leaflet";
GeoJSON.asFeature($0)""")>]
        static member inline asFeature (geojson: U2<Glutinum.Geojson.Feature<'G, 'P>, 'G>): Glutinum.Geojson.Feature<'G, 'P> = nativeOnly
        /// <summary>
        /// Normalize GeoJSON geometries/features into GeoJSON features.
        /// </summary>
        [<Emit("""import { GeoJSON } from "leaflet";
GeoJSON.asFeature($0)""")>]
        static member inline asFeature (geojson: Glutinum.Geojson.Feature<Glutinum.Geojson.GeometryObject, obj>): Glutinum.Geojson.Feature<Glutinum.Geojson.GeometryObject, obj> = nativeOnly
        /// <summary>
        /// Normalize GeoJSON geometries/features into GeoJSON features.
        /// </summary>
        [<Emit("""import { GeoJSON } from "leaflet";
GeoJSON.asFeature($0)""")>]
        static member inline asFeature (geojson: Glutinum.Geojson.GeometryObject): Glutinum.Geojson.Feature<Glutinum.Geojson.GeometryObject, obj> = nativeOnly
        /// <summary>
        /// Normalize GeoJSON geometries/features into GeoJSON features.
        /// </summary>
        [<Emit("""import { GeoJSON } from "leaflet";
GeoJSON.asFeature($0)""")>]
        static member inline asFeature (geojson: U2<Glutinum.Geojson.Feature<Glutinum.Geojson.GeometryObject, obj>, Glutinum.Geojson.GeometryObject>): Glutinum.Geojson.Feature<Glutinum.Geojson.GeometryObject, obj> = nativeOnly
        /// <summary>
        /// Adds a GeoJSON object to the layer.
        /// </summary>
        abstract member addData: data: Glutinum.Geojson.GeoJsonObject -> GeoJSON<'P, 'G>
        /// <summary>
        /// Resets the given vector layer's style to the original GeoJSON style,
        /// useful for resetting style after hover events.
        /// </summary>
        abstract member resetStyle: ?layer: Leaflet.Layer -> GeoJSON<'P, 'G>
        /// <summary>
        /// Same as FeatureGroup's setStyle method, but style-functions are also
        /// allowed here to set the style according to the feature.
        /// </summary>
        abstract member setStyle: style: Leaflet.PathOptions -> GeoJSON<'P, 'G>
        /// <summary>
        /// Same as FeatureGroup's setStyle method, but style-functions are also
        /// allowed here to set the style according to the feature.
        /// </summary>
        abstract member setStyle: style: Leaflet.StyleFunction<'P> -> GeoJSON<'P, 'G>
        /// <summary>
        /// Same as FeatureGroup's setStyle method, but style-functions are also
        /// allowed here to set the style according to the feature.
        /// </summary>
        abstract member setStyle: style: U2<Leaflet.PathOptions, Leaflet.StyleFunction<'P>> -> GeoJSON<'P, 'G>

    type GeoJSON<'P> =
        GeoJSON<'P, Glutinum.Geojson.GeometryObject>

    type GeoJSON =
        GeoJSON<obj, Glutinum.Geojson.GeometryObject>

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type Zoom =
        | [<CompiledValue(true)>] True
        | [<CompiledValue(false)>] False
        | center

    [<AllowNullLiteral>]
    [<Interface>]
    type MapOptions =
        abstract member preferCanvas: bool option with get, set
        abstract member attributionControl: bool option with get, set
        abstract member zoomControl: bool option with get, set
        abstract member closePopupOnClick: bool option with get, set
        abstract member zoomSnap: float option with get, set
        abstract member zoomDelta: float option with get, set
        abstract member trackResize: bool option with get, set
        abstract member boxZoom: bool option with get, set
        abstract member doubleClickZoom: Leaflet.Zoom option with get, set
        abstract member dragging: bool option with get, set
        abstract member crs: Leaflet.CRS option with get, set
        abstract member center: Leaflet.LatLngExpression option with get, set
        abstract member zoom: float option with get, set
        abstract member minZoom: float option with get, set
        abstract member maxZoom: float option with get, set
        abstract member layers: ResizeArray<Leaflet.Layer> option with get, set
        abstract member maxBounds: Leaflet.LatLngBoundsExpression option with get, set
        abstract member renderer: Leaflet.Renderer option with get, set
        abstract member fadeAnimation: bool option with get, set
        abstract member markerZoomAnimation: bool option with get, set
        abstract member transform3DLimit: float option with get, set
        abstract member zoomAnimation: bool option with get, set
        abstract member zoomAnimationThreshold: float option with get, set
        abstract member inertia: bool option with get, set
        abstract member inertiaDeceleration: float option with get, set
        abstract member inertiaMaxSpeed: float option with get, set
        abstract member easeLinearity: float option with get, set
        abstract member worldCopyJump: bool option with get, set
        abstract member maxBoundsViscosity: float option with get, set
        abstract member keyboard: bool option with get, set
        abstract member keyboardPanDelta: float option with get, set
        abstract member scrollWheelZoom: Leaflet.Zoom option with get, set
        abstract member wheelDebounceTime: float option with get, set
        abstract member wheelPxPerZoomLevel: float option with get, set
        abstract member tapHold: bool option with get, set
        abstract member tapTolerance: float option with get, set
        abstract member touchZoom: Leaflet.Zoom option with get, set
        abstract member bounceAtZoomLimits: bool option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?preferCanvas: bool, ?attributionControl: bool, ?zoomControl: bool, ?closePopupOnClick: bool, ?zoomSnap: float, ?zoomDelta: float, ?trackResize: bool, ?boxZoom: bool, ?doubleClickZoom: Leaflet.Zoom, ?dragging: bool, ?crs: Leaflet.CRS, ?center: Leaflet.LatLngExpression, ?zoom: float, ?minZoom: float, ?maxZoom: float, ?layers: ResizeArray<Leaflet.Layer>, ?maxBounds: Leaflet.LatLngBoundsExpression, ?renderer: Leaflet.Renderer, ?fadeAnimation: bool, ?markerZoomAnimation: bool, ?transform3DLimit: float, ?zoomAnimation: bool, ?zoomAnimationThreshold: float, ?inertia: bool, ?inertiaDeceleration: float, ?inertiaMaxSpeed: float, ?easeLinearity: float, ?worldCopyJump: bool, ?maxBoundsViscosity: float, ?keyboard: bool, ?keyboardPanDelta: float, ?scrollWheelZoom: Leaflet.Zoom, ?wheelDebounceTime: float, ?wheelPxPerZoomLevel: float, ?tapHold: bool, ?tapTolerance: float, ?touchZoom: Leaflet.Zoom, ?bounceAtZoomLimits: bool) : MapOptions = nativeOnly

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type ControlPosition =
        | topleft
        | topright
        | bottomleft
        | bottomright

    [<AllowNullLiteral>]
    [<Interface>]
    type ControlOptions =
        abstract member position: Leaflet.ControlPosition option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type Control<'Options> =
        inherit Leaflet.Class
        [<Emit("""import { Control } from "leaflet";
Control.extend($0)""")>]
        static member inline extend (props: 'T): obj = nativeOnly
        abstract member getPosition: unit -> Leaflet.ControlPosition
        abstract member setPosition: position: Leaflet.ControlPosition -> Control<'Options>
        abstract member getContainer: unit -> Glutinum.Web.HTMLElement option
        abstract member addTo: map: Leaflet.Map -> Control<'Options>
        abstract member remove: unit -> Control<'Options>
        abstract member onAdd: map: Leaflet.Map -> Glutinum.Web.HTMLElement
        abstract member onRemove: map: Leaflet.Map -> unit
        abstract member options: 'Options with get, set

    type Control =
        Control<Leaflet.ControlOptions>

    module Control_ =

        [<AbstractClass>]
        [<Erase>]
        type Exports =
            [<Emit("new $0.Zoom($1...)")>]
            abstract member Zoom: ?options: Leaflet.Control_.ZoomOptions -> Zoom
            [<Emit("new $0.Attribution($1...)")>]
            abstract member Attribution: ?options: Leaflet.Control_.AttributionOptions -> Attribution
            [<Emit("new $0.Layers($1...)")>]
            abstract member Layers: ?baseLayers: Leaflet.Control_.LayersObject * ?overlays: Leaflet.Control_.LayersObject * ?options: Leaflet.Control_.LayersOptions -> Layers
            [<Emit("new $0.Scale($1...)")>]
            abstract member Scale: ?options: Leaflet.Control_.ScaleOptions -> Scale

        [<AllowNullLiteral>]
        [<Interface>]
        type ZoomOptions =
            inherit Leaflet.ControlOptions
            abstract member zoomInText: string option with get, set
            abstract member zoomInTitle: string option with get, set
            abstract member zoomOutText: string option with get, set
            abstract member zoomOutTitle: string option with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (?position: Leaflet.ControlPosition, ?zoomInText: string, ?zoomInTitle: string, ?zoomOutText: string, ?zoomOutTitle: string) : ZoomOptions = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type Zoom =
            inherit Leaflet.Control

        [<AllowNullLiteral>]
        [<Interface>]
        type AttributionOptions =
            inherit Leaflet.ControlOptions
            abstract member prefix: U2<string, bool> option with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (?position: Leaflet.ControlPosition) : AttributionOptions = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (prefix: string, ?position: Leaflet.ControlPosition) : AttributionOptions = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (prefix: bool, ?position: Leaflet.ControlPosition) : AttributionOptions = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type Attribution =
            inherit Leaflet.Control
            abstract member setPrefix: prefix: U2<string, bool> -> Attribution
            abstract member addAttribution: text: string -> Attribution
            abstract member removeAttribution: text: string -> Attribution

        [<AllowNullLiteral>]
        [<Interface>]
        type LayersOptions =
            inherit Leaflet.ControlOptions
            abstract member collapsed: bool option with get, set
            abstract member autoZIndex: bool option with get, set
            abstract member hideSingleBase: bool option with get, set
            /// <summary>
            /// Whether to sort the layers. When <c>false</c>, layers will keep the order in which they were added to the control.
            /// </summary>
            abstract member sortLayers: bool option with get, set
            /// <summary>
            /// A [compare function](https://developer.mozilla.org/docs/Web/JavaScript/Reference/Global_Objects/Array/sort)
            /// that will be used for sorting the layers, when <c>sortLayers</c> is <c>true</c>. The function receives both the
            /// [<c>L.Layer</c>](https://leafletjs.com/reference.html#layer) instances and their names, as in
            /// <c>sortFunction(layerA, layerB, nameA, nameB)</c>. By default, it sorts layers alphabetically by their name.
            /// </summary>
            abstract member sortFunction: LayersOptions.sortFunction option with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (?position: Leaflet.ControlPosition, ?collapsed: bool, ?autoZIndex: bool, ?hideSingleBase: bool, ?sortLayers: bool, ?sortFunction: LayersOptions.sortFunction) : LayersOptions = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type LayersObject =
            [<EmitIndexer>]
            abstract member Item: name: string -> Leaflet.Layer with get, set

        [<AllowNullLiteral>]
        [<Interface>]
        type Layers =
            inherit Leaflet.Control
            abstract member addBaseLayer: layer: Leaflet.Layer * name: string -> Layers
            abstract member addOverlay: layer: Leaflet.Layer * name: string -> Layers
            abstract member removeLayer: layer: Leaflet.Layer -> Layers
            abstract member expand: unit -> Layers
            abstract member collapse: unit -> Layers

        [<AllowNullLiteral>]
        [<Interface>]
        type ScaleOptions =
            inherit Leaflet.ControlOptions
            abstract member maxWidth: float option with get, set
            abstract member metric: bool option with get, set
            abstract member imperial: bool option with get, set
            abstract member updateWhenIdle: bool option with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (?position: Leaflet.ControlPosition, ?maxWidth: float, ?metric: bool, ?imperial: bool, ?updateWhenIdle: bool) : ScaleOptions = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type Scale =
            inherit Leaflet.Control

        module LayersOptions =

            type sortFunction =
                delegate of layerA: Leaflet.Layer * layerB: Leaflet.Layer * nameA: string * nameB: string -> float

    module control_ =

        [<AbstractClass>]
        [<Erase>]
        type Exports =
            [<Emit("$0.zoom($1...)")>]
            abstract member zoom: ?options: Leaflet.Control_.ZoomOptions -> Leaflet.Control_.Zoom
            [<Emit("$0.attribution($1...)")>]
            abstract member attribution: ?options: Leaflet.Control_.AttributionOptions -> Leaflet.Control_.Attribution
            [<Emit("$0.layers($1...)")>]
            abstract member layers: ?baseLayers: Leaflet.Control_.LayersObject * ?overlays: Leaflet.Control_.LayersObject * ?options: Leaflet.Control_.LayersOptions -> Leaflet.Control_.Layers
            [<Emit("$0.scale($1...)")>]
            abstract member scale: ?options: Leaflet.Control_.ScaleOptions -> Leaflet.Control_.Scale

    [<AllowNullLiteral>]
    [<Interface>]
    type DivOverlayOptions =
        abstract member offset: Leaflet.PointExpression option with get, set
        abstract member className: string option with get, set
        abstract member pane: string option with get, set
        abstract member interactive: bool option with get, set
        abstract member content: U4<string, Glutinum.Web.HTMLElement, (Leaflet.Layer -> string), (Leaflet.Layer -> Glutinum.Web.HTMLElement)> option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?offset: Leaflet.PointExpression, ?className: string, ?pane: string, ?interactive: bool) : DivOverlayOptions = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (content: string, ?offset: Leaflet.PointExpression, ?className: string, ?pane: string, ?interactive: bool) : DivOverlayOptions = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (content: Glutinum.Web.HTMLElement, ?offset: Leaflet.PointExpression, ?className: string, ?pane: string, ?interactive: bool) : DivOverlayOptions = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (content: (Leaflet.Layer -> string), ?offset: Leaflet.PointExpression, ?className: string, ?pane: string, ?interactive: bool) : DivOverlayOptions = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (content: (Leaflet.Layer -> Glutinum.Web.HTMLElement), ?offset: Leaflet.PointExpression, ?className: string, ?pane: string, ?interactive: bool) : DivOverlayOptions = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type DivOverlay =
        inherit Leaflet.Layer
        abstract member getLatLng: unit -> Leaflet.LatLng option
        abstract member setLatLng: latlng: Leaflet.LatLng -> DivOverlay
        abstract member setLatLng: latlng: Leaflet.LatLngLiteral -> DivOverlay
        abstract member setLatLng: latlng: Leaflet.LatLngTuple -> DivOverlay
        abstract member setLatLng: latlng: Leaflet.LatLngExpression -> DivOverlay
        abstract member getContent: unit -> U2<Leaflet.Content, (Leaflet.Layer -> Leaflet.Content)> option
        abstract member setContent: htmlContent: (Leaflet.Layer -> Leaflet.Content) -> DivOverlay
        abstract member setContent: htmlContent: string -> DivOverlay
        abstract member setContent: htmlContent: Glutinum.Web.HTMLElement -> DivOverlay
        abstract member setContent: htmlContent: U2<(Leaflet.Layer -> Leaflet.Content), Leaflet.Content> -> DivOverlay
        abstract member getElement: unit -> Glutinum.Web.HTMLElement option
        abstract member update: unit -> unit
        abstract member isOpen: unit -> bool
        abstract member bringToFront: unit -> DivOverlay
        abstract member bringToBack: unit -> DivOverlay
        abstract member openOn: map: Leaflet.Map -> DivOverlay
        abstract member toggle: ?layer: Leaflet.Layer -> DivOverlay
        abstract member close: unit -> DivOverlay

    [<AllowNullLiteral>]
    [<Interface>]
    type PopupOptions =
        inherit Leaflet.DivOverlayOptions
        abstract member maxWidth: float option with get, set
        abstract member minWidth: float option with get, set
        abstract member maxHeight: float option with get, set
        abstract member keepInView: bool option with get, set
        abstract member closeButton: bool option with get, set
        abstract member autoPan: bool option with get, set
        abstract member autoPanPaddingTopLeft: Leaflet.PointExpression option with get, set
        abstract member autoPanPaddingBottomRight: Leaflet.PointExpression option with get, set
        abstract member autoPanPadding: Leaflet.PointExpression option with get, set
        abstract member autoClose: bool option with get, set
        abstract member closeOnClick: bool option with get, set
        abstract member closeOnEscapeKey: bool option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?offset: Leaflet.PointExpression, ?className: string, ?pane: string, ?interactive: bool, ?maxWidth: float, ?minWidth: float, ?maxHeight: float, ?keepInView: bool, ?closeButton: bool, ?autoPan: bool, ?autoPanPaddingTopLeft: Leaflet.PointExpression, ?autoPanPaddingBottomRight: Leaflet.PointExpression, ?autoPanPadding: Leaflet.PointExpression, ?autoClose: bool, ?closeOnClick: bool, ?closeOnEscapeKey: bool) : PopupOptions = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (content: string, ?offset: Leaflet.PointExpression, ?className: string, ?pane: string, ?interactive: bool, ?maxWidth: float, ?minWidth: float, ?maxHeight: float, ?keepInView: bool, ?closeButton: bool, ?autoPan: bool, ?autoPanPaddingTopLeft: Leaflet.PointExpression, ?autoPanPaddingBottomRight: Leaflet.PointExpression, ?autoPanPadding: Leaflet.PointExpression, ?autoClose: bool, ?closeOnClick: bool, ?closeOnEscapeKey: bool) : PopupOptions = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (content: Glutinum.Web.HTMLElement, ?offset: Leaflet.PointExpression, ?className: string, ?pane: string, ?interactive: bool, ?maxWidth: float, ?minWidth: float, ?maxHeight: float, ?keepInView: bool, ?closeButton: bool, ?autoPan: bool, ?autoPanPaddingTopLeft: Leaflet.PointExpression, ?autoPanPaddingBottomRight: Leaflet.PointExpression, ?autoPanPadding: Leaflet.PointExpression, ?autoClose: bool, ?closeOnClick: bool, ?closeOnEscapeKey: bool) : PopupOptions = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (content: (Leaflet.Layer -> string), ?offset: Leaflet.PointExpression, ?className: string, ?pane: string, ?interactive: bool, ?maxWidth: float, ?minWidth: float, ?maxHeight: float, ?keepInView: bool, ?closeButton: bool, ?autoPan: bool, ?autoPanPaddingTopLeft: Leaflet.PointExpression, ?autoPanPaddingBottomRight: Leaflet.PointExpression, ?autoPanPadding: Leaflet.PointExpression, ?autoClose: bool, ?closeOnClick: bool, ?closeOnEscapeKey: bool) : PopupOptions = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (content: (Leaflet.Layer -> Glutinum.Web.HTMLElement), ?offset: Leaflet.PointExpression, ?className: string, ?pane: string, ?interactive: bool, ?maxWidth: float, ?minWidth: float, ?maxHeight: float, ?keepInView: bool, ?closeButton: bool, ?autoPan: bool, ?autoPanPaddingTopLeft: Leaflet.PointExpression, ?autoPanPaddingBottomRight: Leaflet.PointExpression, ?autoPanPadding: Leaflet.PointExpression, ?autoClose: bool, ?closeOnClick: bool, ?closeOnEscapeKey: bool) : PopupOptions = nativeOnly

    type Content =
        U2<string, Glutinum.Web.HTMLElement>

    [<AllowNullLiteral>]
    [<Interface>]
    type Popup =
        inherit Leaflet.DivOverlay
        abstract member openOn: map: Leaflet.Map -> Popup

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type Direction =
        | right
        | left
        | top
        | bottom
        | center
        | auto

    [<AllowNullLiteral>]
    [<Interface>]
    type TooltipOptions =
        inherit Leaflet.DivOverlayOptions
        abstract member pane: string option with get, set
        abstract member offset: Leaflet.PointExpression option with get, set
        abstract member direction: Leaflet.Direction option with get, set
        abstract member permanent: bool option with get, set
        abstract member sticky: bool option with get, set
        abstract member opacity: float option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?className: string, ?interactive: bool, ?pane: string, ?offset: Leaflet.PointExpression, ?direction: Leaflet.Direction, ?permanent: bool, ?sticky: bool, ?opacity: float) : TooltipOptions = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (content: string, ?className: string, ?interactive: bool, ?pane: string, ?offset: Leaflet.PointExpression, ?direction: Leaflet.Direction, ?permanent: bool, ?sticky: bool, ?opacity: float) : TooltipOptions = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (content: Glutinum.Web.HTMLElement, ?className: string, ?interactive: bool, ?pane: string, ?offset: Leaflet.PointExpression, ?direction: Leaflet.Direction, ?permanent: bool, ?sticky: bool, ?opacity: float) : TooltipOptions = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (content: (Leaflet.Layer -> string), ?className: string, ?interactive: bool, ?pane: string, ?offset: Leaflet.PointExpression, ?direction: Leaflet.Direction, ?permanent: bool, ?sticky: bool, ?opacity: float) : TooltipOptions = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (content: (Leaflet.Layer -> Glutinum.Web.HTMLElement), ?className: string, ?interactive: bool, ?pane: string, ?offset: Leaflet.PointExpression, ?direction: Leaflet.Direction, ?permanent: bool, ?sticky: bool, ?opacity: float) : TooltipOptions = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type Tooltip =
        inherit Leaflet.DivOverlay
        abstract member setOpacity: ``val``: float -> unit

    [<AllowNullLiteral>]
    [<Interface>]
    type ZoomOptions =
        abstract member animate: bool option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?animate: bool) : ZoomOptions = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type PanOptions =
        abstract member animate: bool option with get, set
        abstract member duration: float option with get, set
        abstract member easeLinearity: float option with get, set
        abstract member noMoveStart: bool option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?animate: bool, ?duration: float, ?easeLinearity: float, ?noMoveStart: bool) : PanOptions = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type ZoomPanOptions =
        inherit Leaflet.ZoomOptions
        inherit Leaflet.PanOptions
        [<ParamObject; Emit("$0")>]
        static member Create (?animate: bool, ?duration: float, ?easeLinearity: float, ?noMoveStart: bool) : ZoomPanOptions = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type InvalidateSizeOptions =
        inherit Leaflet.ZoomPanOptions
        abstract member debounceMoveend: bool option with get, set
        abstract member pan: bool option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?animate: bool, ?duration: float, ?easeLinearity: float, ?noMoveStart: bool, ?debounceMoveend: bool, ?pan: bool) : InvalidateSizeOptions = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type FitBoundsOptions =
        inherit Leaflet.ZoomOptions
        inherit Leaflet.PanOptions
        abstract member paddingTopLeft: Leaflet.PointExpression option with get, set
        abstract member paddingBottomRight: Leaflet.PointExpression option with get, set
        abstract member padding: Leaflet.PointExpression option with get, set
        abstract member maxZoom: float option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?animate: bool, ?duration: float, ?easeLinearity: float, ?noMoveStart: bool, ?paddingTopLeft: Leaflet.PointExpression, ?paddingBottomRight: Leaflet.PointExpression, ?padding: Leaflet.PointExpression, ?maxZoom: float) : FitBoundsOptions = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type PanInsideOptions =
        inherit Leaflet.PanOptions
        abstract member paddingTopLeft: Leaflet.PointExpression option with get, set
        abstract member paddingBottomRight: Leaflet.PointExpression option with get, set
        abstract member padding: Leaflet.PointExpression option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?animate: bool, ?duration: float, ?easeLinearity: float, ?noMoveStart: bool, ?paddingTopLeft: Leaflet.PointExpression, ?paddingBottomRight: Leaflet.PointExpression, ?padding: Leaflet.PointExpression) : PanInsideOptions = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type LocateOptions =
        abstract member watch: bool option with get, set
        abstract member setView: bool option with get, set
        abstract member maxZoom: float option with get, set
        abstract member timeout: float option with get, set
        abstract member maximumAge: float option with get, set
        abstract member enableHighAccuracy: bool option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?watch: bool, ?setView: bool, ?maxZoom: float, ?timeout: float, ?maximumAge: float, ?enableHighAccuracy: bool) : LocateOptions = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type Handler =
        inherit Leaflet.Class
        abstract member enable: unit -> Handler
        abstract member disable: unit -> Handler
        abstract member enabled: unit -> bool
        abstract member addHooks: unit -> unit
        abstract member removeHooks: unit -> unit

    [<AllowNullLiteral>]
    [<Interface>]
    type LeafletEvent =
        abstract member ``type``: string with get, set
        abstract member popup: obj with get, set
        abstract member target: obj with get, set
        abstract member sourceTarget: obj with get, set
        abstract member propagatedFrom: obj with get, set
        [<Obsolete("The same as {@link LeafletEvent.propagatedFrom propagatedFrom}.")>]
        abstract member layer: obj with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (``type``: string, popup: obj, target: obj, sourceTarget: obj, propagatedFrom: obj, layer: obj) : LeafletEvent = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type LeafletMouseEvent =
        inherit Leaflet.LeafletEvent
        abstract member latlng: Leaflet.LatLng with get, set
        abstract member layerPoint: Leaflet.Point with get, set
        abstract member containerPoint: Leaflet.Point with get, set
        abstract member originalEvent: Glutinum.Web.MouseEvent with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (``type``: string, popup: obj, target: obj, sourceTarget: obj, propagatedFrom: obj, layer: obj, latlng: Leaflet.LatLng, layerPoint: Leaflet.Point, containerPoint: Leaflet.Point, originalEvent: Glutinum.Web.MouseEvent) : LeafletMouseEvent = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type LeafletKeyboardEvent =
        inherit Leaflet.LeafletEvent
        abstract member originalEvent: Glutinum.Web.KeyboardEvent with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (``type``: string, popup: obj, target: obj, sourceTarget: obj, propagatedFrom: obj, layer: obj, originalEvent: Glutinum.Web.KeyboardEvent) : LeafletKeyboardEvent = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type LocationEvent =
        inherit Leaflet.LeafletEvent
        abstract member latlng: Leaflet.LatLng with get, set
        abstract member bounds: Leaflet.LatLngBounds with get, set
        abstract member accuracy: float with get, set
        abstract member altitude: float with get, set
        abstract member altitudeAccuracy: float with get, set
        abstract member heading: float with get, set
        abstract member speed: float with get, set
        abstract member timestamp: float with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (``type``: string, popup: obj, target: obj, sourceTarget: obj, propagatedFrom: obj, layer: obj, latlng: Leaflet.LatLng, bounds: Leaflet.LatLngBounds, accuracy: float, altitude: float, altitudeAccuracy: float, heading: float, speed: float, timestamp: float) : LocationEvent = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type ErrorEvent =
        inherit Leaflet.LeafletEvent
        abstract member message: string with get, set
        abstract member code: float with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (``type``: string, popup: obj, target: obj, sourceTarget: obj, propagatedFrom: obj, layer: obj, message: string, code: float) : ErrorEvent = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type LayerEvent =
        inherit Leaflet.LeafletEvent
        abstract member layer: Leaflet.Layer with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (``type``: string, popup: obj, target: obj, sourceTarget: obj, propagatedFrom: obj, layer: Leaflet.Layer) : LayerEvent = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type LayersControlEvent =
        inherit Leaflet.LayerEvent
        abstract member name: string with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (``type``: string, popup: obj, target: obj, sourceTarget: obj, propagatedFrom: obj, layer: Leaflet.Layer, name: string) : LayersControlEvent = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type TileEvent =
        inherit Leaflet.LeafletEvent
        abstract member tile: Glutinum.Web.HTMLImageElement with get, set
        abstract member coords: Leaflet.Coords with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (``type``: string, popup: obj, target: obj, sourceTarget: obj, propagatedFrom: obj, layer: obj, tile: Glutinum.Web.HTMLImageElement, coords: Leaflet.Coords) : TileEvent = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type TileErrorEvent =
        inherit Leaflet.TileEvent
        abstract member error: Exception with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (``type``: string, popup: obj, target: obj, sourceTarget: obj, propagatedFrom: obj, layer: obj, tile: Glutinum.Web.HTMLImageElement, coords: Leaflet.Coords, error: Exception) : TileErrorEvent = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type ResizeEvent =
        inherit Leaflet.LeafletEvent
        abstract member oldSize: Leaflet.Point with get, set
        abstract member newSize: Leaflet.Point with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (``type``: string, popup: obj, target: obj, sourceTarget: obj, propagatedFrom: obj, layer: obj, oldSize: Leaflet.Point, newSize: Leaflet.Point) : ResizeEvent = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type GeoJSONEvent =
        inherit Leaflet.LeafletEvent
        abstract member layer: Leaflet.Layer with get, set
        abstract member properties: obj with get, set
        abstract member geometryType: string with get, set
        abstract member id: string with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type PopupEvent =
        inherit Leaflet.LeafletEvent
        abstract member popup: Leaflet.Popup with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (``type``: string, target: obj, sourceTarget: obj, propagatedFrom: obj, layer: obj, popup: Leaflet.Popup) : PopupEvent = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type TooltipEvent =
        inherit Leaflet.LeafletEvent
        abstract member tooltip: Leaflet.Tooltip with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (``type``: string, popup: obj, target: obj, sourceTarget: obj, propagatedFrom: obj, layer: obj, tooltip: Leaflet.Tooltip) : TooltipEvent = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type DragEndEvent =
        inherit Leaflet.LeafletEvent
        abstract member distance: float with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (``type``: string, popup: obj, target: obj, sourceTarget: obj, propagatedFrom: obj, layer: obj, distance: float) : DragEndEvent = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type ZoomAnimEvent =
        inherit Leaflet.LeafletEvent
        abstract member center: Leaflet.LatLng with get, set
        abstract member zoom: float with get, set
        abstract member noUpdate: bool with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (``type``: string, popup: obj, target: obj, sourceTarget: obj, propagatedFrom: obj, layer: obj, center: Leaflet.LatLng, zoom: float, noUpdate: bool) : ZoomAnimEvent = nativeOnly

    module DomEvent_ =

        [<AbstractClass>]
        [<Erase>]
        type Exports =
            [<Emit("$0.on($1...)")>]
            abstract member on: el: Glutinum.Web.HTMLElement * types: string * fn: Leaflet.DomEvent_.EventHandlerFn * ?context: obj -> Leaflet.DomEvent_.Exports
            [<Emit("$0.on($1...)")>]
            abstract member on: el: Glutinum.Web.HTMLElement * eventMap: Exports.on.eventMap * ?context: obj -> Leaflet.DomEvent_.Exports
            [<Emit("$0.off($1...)")>]
            abstract member off: el: Glutinum.Web.HTMLElement -> Leaflet.DomEvent_.Exports
            [<Emit("$0.off($1...)")>]
            abstract member off: el: Glutinum.Web.HTMLElement * types: string * fn: Leaflet.DomEvent_.EventHandlerFn * ?context: obj -> Leaflet.DomEvent_.Exports
            [<Emit("$0.off($1...)")>]
            abstract member off: el: Glutinum.Web.HTMLElement * eventMap: Exports.off.eventMap * ?context: obj -> Leaflet.DomEvent_.Exports
            [<Emit("$0.stopPropagation($1...)")>]
            abstract member stopPropagation: ev: Leaflet.LeafletMouseEvent -> Leaflet.DomEvent_.Exports
            [<Emit("$0.stopPropagation($1...)")>]
            abstract member stopPropagation: ev: Leaflet.LeafletKeyboardEvent -> Leaflet.DomEvent_.Exports
            [<Emit("$0.stopPropagation($1...)")>]
            abstract member stopPropagation: ev: Leaflet.LeafletEvent -> Leaflet.DomEvent_.Exports
            [<Emit("$0.stopPropagation($1...)")>]
            abstract member stopPropagation: ev: Glutinum.Web.Event -> Leaflet.DomEvent_.Exports
            [<Emit("$0.stopPropagation($1...)")>]
            abstract member stopPropagation: ev: Leaflet.DomEvent_.PropagableEvent -> Leaflet.DomEvent_.Exports
            [<Emit("$0.disableScrollPropagation($1...)")>]
            abstract member disableScrollPropagation: el: Glutinum.Web.HTMLElement -> Leaflet.DomEvent_.Exports
            [<Emit("$0.disableClickPropagation($1...)")>]
            abstract member disableClickPropagation: el: Glutinum.Web.HTMLElement -> Leaflet.DomEvent_.Exports
            [<Emit("$0.preventDefault($1...)")>]
            abstract member preventDefault: ev: Glutinum.Web.Event -> Leaflet.DomEvent_.Exports
            [<Emit("$0.stop($1...)")>]
            abstract member stop: ev: Leaflet.LeafletMouseEvent -> Leaflet.DomEvent_.Exports
            [<Emit("$0.stop($1...)")>]
            abstract member stop: ev: Leaflet.LeafletKeyboardEvent -> Leaflet.DomEvent_.Exports
            [<Emit("$0.stop($1...)")>]
            abstract member stop: ev: Leaflet.LeafletEvent -> Leaflet.DomEvent_.Exports
            [<Emit("$0.stop($1...)")>]
            abstract member stop: ev: Glutinum.Web.Event -> Leaflet.DomEvent_.Exports
            [<Emit("$0.stop($1...)")>]
            abstract member stop: ev: Leaflet.DomEvent_.PropagableEvent -> Leaflet.DomEvent_.Exports
            [<Emit("$0.getMousePosition($1...)")>]
            abstract member getMousePosition: ev: Glutinum.Web.MouseEvent * ?container: Glutinum.Web.HTMLElement -> Leaflet.Point
            [<Emit("$0.getWheelDelta($1...)")>]
            abstract member getWheelDelta: ev: Glutinum.Web.Event -> float
            [<Emit("$0.addListener($1...)")>]
            abstract member addListener: el: Glutinum.Web.HTMLElement * types: string * fn: Leaflet.DomEvent_.EventHandlerFn * ?context: obj -> Leaflet.DomEvent_.Exports
            [<Emit("$0.addListener($1...)")>]
            abstract member addListener: el: Glutinum.Web.HTMLElement * eventMap: Exports.addListener.eventMap * ?context: obj -> Leaflet.DomEvent_.Exports
            [<Emit("$0.removeListener($1...)")>]
            abstract member removeListener: el: Glutinum.Web.HTMLElement * types: string * fn: Leaflet.DomEvent_.EventHandlerFn * ?context: obj -> Leaflet.DomEvent_.Exports
            [<Emit("$0.removeListener($1...)")>]
            abstract member removeListener: el: Glutinum.Web.HTMLElement * eventMap: Exports.removeListener.eventMap * ?context: obj -> Leaflet.DomEvent_.Exports
            [<Emit("$0.getPropagationPath($1...)")>]
            abstract member getPropagationPath: ev: Glutinum.Web.Event -> ResizeArray<Glutinum.Web.HTMLElement>

        type EventHandlerFn =
            delegate of event: Glutinum.Web.Event -> unit

        type PropagableEvent =
            U4<Leaflet.LeafletMouseEvent, Leaflet.LeafletKeyboardEvent, Leaflet.LeafletEvent, Glutinum.Web.Event>

        module Exports =

            module on =

                [<AllowNullLiteral>]
                [<Interface>]
                type eventMap =
                    [<EmitIndexer>]
                    abstract member Item: eventName: string -> Leaflet.DomEvent_.EventHandlerFn with get, set

            module off =

                [<AllowNullLiteral>]
                [<Interface>]
                type eventMap =
                    [<EmitIndexer>]
                    abstract member Item: eventName: string -> Leaflet.DomEvent_.EventHandlerFn with get, set

            module addListener =

                [<AllowNullLiteral>]
                [<Interface>]
                type eventMap =
                    [<EmitIndexer>]
                    abstract member Item: eventName: string -> Leaflet.DomEvent_.EventHandlerFn with get, set

            module removeListener =

                [<AllowNullLiteral>]
                [<Interface>]
                type eventMap =
                    [<EmitIndexer>]
                    abstract member Item: eventName: string -> Leaflet.DomEvent_.EventHandlerFn with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type DefaultMapPanes =
        abstract member mapPane: Glutinum.Web.HTMLElement with get, set
        abstract member tilePane: Glutinum.Web.HTMLElement with get, set
        abstract member overlayPane: Glutinum.Web.HTMLElement with get, set
        abstract member shadowPane: Glutinum.Web.HTMLElement with get, set
        abstract member markerPane: Glutinum.Web.HTMLElement with get, set
        abstract member tooltipPane: Glutinum.Web.HTMLElement with get, set
        abstract member popupPane: Glutinum.Web.HTMLElement with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type Map =
        inherit Leaflet.Evented
        abstract member getRenderer: layer: Leaflet.Path -> Leaflet.Renderer
        abstract member addControl: control: Leaflet.Control -> Map
        abstract member removeControl: control: Leaflet.Control -> Map
        abstract member addLayer: layer: Leaflet.Layer -> Map
        abstract member removeLayer: layer: Leaflet.Layer -> Map
        abstract member hasLayer: layer: Leaflet.Layer -> bool
        abstract member eachLayer: fn: (Leaflet.Layer -> unit) * ?context: obj -> Map
        abstract member openPopup: popup: Leaflet.Popup -> Map
        abstract member openPopup: content: string * latlng: Leaflet.LatLng * ?options: Leaflet.PopupOptions -> Map
        abstract member openPopup: content: string * latlng: Leaflet.LatLngLiteral * ?options: Leaflet.PopupOptions -> Map
        abstract member openPopup: content: string * latlng: Leaflet.LatLngTuple * ?options: Leaflet.PopupOptions -> Map
        abstract member openPopup: content: Glutinum.Web.HTMLElement * latlng: Leaflet.LatLng * ?options: Leaflet.PopupOptions -> Map
        abstract member openPopup: content: Glutinum.Web.HTMLElement * latlng: Leaflet.LatLngLiteral * ?options: Leaflet.PopupOptions -> Map
        abstract member openPopup: content: Glutinum.Web.HTMLElement * latlng: Leaflet.LatLngTuple * ?options: Leaflet.PopupOptions -> Map
        abstract member openPopup: content: Leaflet.Content * latlng: Leaflet.LatLngExpression * ?options: Leaflet.PopupOptions -> Map
        abstract member closePopup: ?popup: Leaflet.Popup -> Map
        abstract member openTooltip: tooltip: Leaflet.Tooltip -> Map
        abstract member openTooltip: content: string * latlng: Leaflet.LatLng * ?options: Leaflet.TooltipOptions -> Map
        abstract member openTooltip: content: string * latlng: Leaflet.LatLngLiteral * ?options: Leaflet.TooltipOptions -> Map
        abstract member openTooltip: content: string * latlng: Leaflet.LatLngTuple * ?options: Leaflet.TooltipOptions -> Map
        abstract member openTooltip: content: Glutinum.Web.HTMLElement * latlng: Leaflet.LatLng * ?options: Leaflet.TooltipOptions -> Map
        abstract member openTooltip: content: Glutinum.Web.HTMLElement * latlng: Leaflet.LatLngLiteral * ?options: Leaflet.TooltipOptions -> Map
        abstract member openTooltip: content: Glutinum.Web.HTMLElement * latlng: Leaflet.LatLngTuple * ?options: Leaflet.TooltipOptions -> Map
        abstract member openTooltip: content: Leaflet.Content * latlng: Leaflet.LatLngExpression * ?options: Leaflet.TooltipOptions -> Map
        abstract member closeTooltip: ?tooltip: Leaflet.Tooltip -> Map
        abstract member setView: center: Leaflet.LatLng * ?zoom: float * ?options: Leaflet.ZoomPanOptions -> Map
        abstract member setView: center: Leaflet.LatLngLiteral * ?zoom: float * ?options: Leaflet.ZoomPanOptions -> Map
        abstract member setView: center: Leaflet.LatLngTuple * ?zoom: float * ?options: Leaflet.ZoomPanOptions -> Map
        abstract member setView: center: Leaflet.LatLngExpression * ?zoom: float * ?options: Leaflet.ZoomPanOptions -> Map
        abstract member setZoom: zoom: float * ?options: Leaflet.ZoomPanOptions -> Map
        abstract member zoomIn: ?delta: float * ?options: Leaflet.ZoomOptions -> Map
        abstract member zoomOut: ?delta: float * ?options: Leaflet.ZoomOptions -> Map
        abstract member setZoomAround: position: Leaflet.Point * zoom: float * ?options: Leaflet.ZoomOptions -> Map
        abstract member setZoomAround: position: Leaflet.LatLng * zoom: float * ?options: Leaflet.ZoomOptions -> Map
        abstract member setZoomAround: position: Leaflet.LatLngLiteral * zoom: float * ?options: Leaflet.ZoomOptions -> Map
        abstract member setZoomAround: position: Leaflet.LatLngTuple * zoom: float * ?options: Leaflet.ZoomOptions -> Map
        abstract member setZoomAround: position: U2<Leaflet.Point, Leaflet.LatLngExpression> * zoom: float * ?options: Leaflet.ZoomOptions -> Map
        abstract member fitBounds: bounds: Leaflet.LatLngBounds * ?options: Leaflet.FitBoundsOptions -> Map
        abstract member fitBounds: bounds: Leaflet.LatLngBoundsLiteral * ?options: Leaflet.FitBoundsOptions -> Map
        abstract member fitBounds: bounds: Leaflet.LatLngBoundsExpression * ?options: Leaflet.FitBoundsOptions -> Map
        abstract member fitWorld: ?options: Leaflet.FitBoundsOptions -> Map
        abstract member panTo: latlng: Leaflet.LatLng * ?options: Leaflet.PanOptions -> Map
        abstract member panTo: latlng: Leaflet.LatLngLiteral * ?options: Leaflet.PanOptions -> Map
        abstract member panTo: latlng: Leaflet.LatLngTuple * ?options: Leaflet.PanOptions -> Map
        abstract member panTo: latlng: Leaflet.LatLngExpression * ?options: Leaflet.PanOptions -> Map
        abstract member panBy: offset: Leaflet.Point * ?options: Leaflet.PanOptions -> Map
        abstract member panBy: offset: Leaflet.PointTuple * ?options: Leaflet.PanOptions -> Map
        abstract member panBy: offset: Leaflet.PointExpression * ?options: Leaflet.PanOptions -> Map
        abstract member setMaxBounds: unit -> Map
        abstract member setMaxBounds: bounds: Leaflet.LatLngBounds -> Map
        abstract member setMaxBounds: bounds: Leaflet.LatLngBoundsLiteral -> Map
        abstract member setMinZoom: zoom: float -> Map
        abstract member setMaxZoom: zoom: float -> Map
        abstract member panInside: latLng: Leaflet.LatLng * ?options: Leaflet.PanInsideOptions -> Map
        abstract member panInside: latLng: Leaflet.LatLngLiteral * ?options: Leaflet.PanInsideOptions -> Map
        abstract member panInside: latLng: Leaflet.LatLngTuple * ?options: Leaflet.PanInsideOptions -> Map
        abstract member panInside: latLng: Leaflet.LatLngExpression * ?options: Leaflet.PanInsideOptions -> Map
        abstract member panInsideBounds: bounds: Leaflet.LatLngBounds * ?options: Leaflet.PanOptions -> Map
        abstract member panInsideBounds: bounds: Leaflet.LatLngBoundsLiteral * ?options: Leaflet.PanOptions -> Map
        abstract member panInsideBounds: bounds: Leaflet.LatLngBoundsExpression * ?options: Leaflet.PanOptions -> Map
        /// <summary>
        /// Boolean for animate or advanced ZoomPanOptions
        /// </summary>
        abstract member invalidateSize: unit -> Map
        /// <summary>
        /// Boolean for animate or advanced ZoomPanOptions
        /// </summary>
        abstract member invalidateSize: options: bool -> Map
        /// <summary>
        /// Boolean for animate or advanced ZoomPanOptions
        /// </summary>
        abstract member invalidateSize: options: Leaflet.InvalidateSizeOptions -> Map
        abstract member stop: unit -> Map
        abstract member flyTo: latlng: Leaflet.LatLng * ?zoom: float * ?options: Leaflet.ZoomPanOptions -> Map
        abstract member flyTo: latlng: Leaflet.LatLngLiteral * ?zoom: float * ?options: Leaflet.ZoomPanOptions -> Map
        abstract member flyTo: latlng: Leaflet.LatLngTuple * ?zoom: float * ?options: Leaflet.ZoomPanOptions -> Map
        abstract member flyTo: latlng: Leaflet.LatLngExpression * ?zoom: float * ?options: Leaflet.ZoomPanOptions -> Map
        abstract member flyToBounds: bounds: Leaflet.LatLngBounds * ?options: Leaflet.FitBoundsOptions -> Map
        abstract member flyToBounds: bounds: Leaflet.LatLngBoundsLiteral * ?options: Leaflet.FitBoundsOptions -> Map
        abstract member flyToBounds: bounds: Leaflet.LatLngBoundsExpression * ?options: Leaflet.FitBoundsOptions -> Map
        abstract member addHandler: name: string * HandlerClass: Leaflet.Handler -> Map
        abstract member remove: unit -> Map
        abstract member createPane: name: string * ?container: Glutinum.Web.HTMLElement -> Glutinum.Web.HTMLElement
        /// <summary>
        /// Name of the pane or the pane as HTML-Element
        /// </summary>
        abstract member getPane: pane: string -> Glutinum.Web.HTMLElement option
        /// <summary>
        /// Name of the pane or the pane as HTML-Element
        /// </summary>
        abstract member getPane: pane: Glutinum.Web.HTMLElement -> Glutinum.Web.HTMLElement option
        /// <summary>
        /// Name of the pane or the pane as HTML-Element
        /// </summary>
        abstract member getPane: pane: U2<string, Glutinum.Web.HTMLElement> -> Glutinum.Web.HTMLElement option
        abstract member getPanes: unit -> Map.getPanes
        abstract member getContainer: unit -> Glutinum.Web.HTMLElement
        abstract member whenReady: fn: (Map.whenReady.fn.event -> unit) * ?context: obj -> Map
        abstract member getCenter: unit -> Leaflet.LatLng
        abstract member getZoom: unit -> float
        abstract member getBounds: unit -> Leaflet.LatLngBounds
        abstract member getMinZoom: unit -> float
        abstract member getMaxZoom: unit -> float
        abstract member getBoundsZoom: bounds: Leaflet.LatLngBounds * ?inside: bool * ?padding: Leaflet.Point -> float
        abstract member getBoundsZoom: bounds: Leaflet.LatLngBoundsLiteral * ?inside: bool * ?padding: Leaflet.Point -> float
        abstract member getBoundsZoom: bounds: Leaflet.LatLngBoundsExpression * ?inside: bool * ?padding: Leaflet.Point -> float
        abstract member getSize: unit -> Leaflet.Point
        abstract member getPixelBounds: unit -> Leaflet.Bounds
        abstract member getPixelOrigin: unit -> Leaflet.Point
        abstract member getPixelWorldBounds: ?zoom: float -> Leaflet.Bounds
        abstract member getZoomScale: toZoom: float * ?fromZoom: float -> float
        abstract member getScaleZoom: scale: float * ?fromZoom: float -> float
        abstract member project: latlng: Leaflet.LatLng * ?zoom: float -> Leaflet.Point
        abstract member project: latlng: Leaflet.LatLngLiteral * ?zoom: float -> Leaflet.Point
        abstract member project: latlng: Leaflet.LatLngTuple * ?zoom: float -> Leaflet.Point
        abstract member project: latlng: Leaflet.LatLngExpression * ?zoom: float -> Leaflet.Point
        abstract member unproject: point: Leaflet.Point * ?zoom: float -> Leaflet.LatLng
        abstract member unproject: point: Leaflet.PointTuple * ?zoom: float -> Leaflet.LatLng
        abstract member unproject: point: Leaflet.PointExpression * ?zoom: float -> Leaflet.LatLng
        abstract member layerPointToLatLng: point: Leaflet.Point -> Leaflet.LatLng
        abstract member layerPointToLatLng: point: Leaflet.PointTuple -> Leaflet.LatLng
        abstract member layerPointToLatLng: point: Leaflet.PointExpression -> Leaflet.LatLng
        abstract member latLngToLayerPoint: latlng: Leaflet.LatLng -> Leaflet.Point
        abstract member latLngToLayerPoint: latlng: Leaflet.LatLngLiteral -> Leaflet.Point
        abstract member latLngToLayerPoint: latlng: Leaflet.LatLngTuple -> Leaflet.Point
        abstract member latLngToLayerPoint: latlng: Leaflet.LatLngExpression -> Leaflet.Point
        abstract member wrapLatLng: latlng: Leaflet.LatLng -> Leaflet.LatLng
        abstract member wrapLatLng: latlng: Leaflet.LatLngLiteral -> Leaflet.LatLng
        abstract member wrapLatLng: latlng: Leaflet.LatLngTuple -> Leaflet.LatLng
        abstract member wrapLatLng: latlng: Leaflet.LatLngExpression -> Leaflet.LatLng
        abstract member wrapLatLngBounds: bounds: Leaflet.LatLngBounds -> Leaflet.LatLngBounds
        abstract member distance: latlng1: Leaflet.LatLng * latlng2: Leaflet.LatLng -> float
        abstract member distance: latlng1: Leaflet.LatLng * latlng2: Leaflet.LatLngLiteral -> float
        abstract member distance: latlng1: Leaflet.LatLng * latlng2: Leaflet.LatLngTuple -> float
        abstract member distance: latlng1: Leaflet.LatLngLiteral * latlng2: Leaflet.LatLng -> float
        abstract member distance: latlng1: Leaflet.LatLngLiteral * latlng2: Leaflet.LatLngLiteral -> float
        abstract member distance: latlng1: Leaflet.LatLngLiteral * latlng2: Leaflet.LatLngTuple -> float
        abstract member distance: latlng1: Leaflet.LatLngTuple * latlng2: Leaflet.LatLng -> float
        abstract member distance: latlng1: Leaflet.LatLngTuple * latlng2: Leaflet.LatLngLiteral -> float
        abstract member distance: latlng1: Leaflet.LatLngTuple * latlng2: Leaflet.LatLngTuple -> float
        abstract member distance: latlng1: Leaflet.LatLngExpression * latlng2: Leaflet.LatLngExpression -> float
        abstract member containerPointToLayerPoint: point: Leaflet.Point -> Leaflet.Point
        abstract member containerPointToLayerPoint: point: Leaflet.PointTuple -> Leaflet.Point
        abstract member containerPointToLayerPoint: point: Leaflet.PointExpression -> Leaflet.Point
        abstract member containerPointToLatLng: point: Leaflet.Point -> Leaflet.LatLng
        abstract member containerPointToLatLng: point: Leaflet.PointTuple -> Leaflet.LatLng
        abstract member containerPointToLatLng: point: Leaflet.PointExpression -> Leaflet.LatLng
        abstract member layerPointToContainerPoint: point: Leaflet.Point -> Leaflet.Point
        abstract member layerPointToContainerPoint: point: Leaflet.PointTuple -> Leaflet.Point
        abstract member layerPointToContainerPoint: point: Leaflet.PointExpression -> Leaflet.Point
        abstract member latLngToContainerPoint: latlng: Leaflet.LatLng -> Leaflet.Point
        abstract member latLngToContainerPoint: latlng: Leaflet.LatLngLiteral -> Leaflet.Point
        abstract member latLngToContainerPoint: latlng: Leaflet.LatLngTuple -> Leaflet.Point
        abstract member latLngToContainerPoint: latlng: Leaflet.LatLngExpression -> Leaflet.Point
        abstract member mouseEventToContainerPoint: ev: Glutinum.Web.MouseEvent -> Leaflet.Point
        abstract member mouseEventToLayerPoint: ev: Glutinum.Web.MouseEvent -> Leaflet.Point
        abstract member mouseEventToLatLng: ev: Glutinum.Web.MouseEvent -> Leaflet.LatLng
        abstract member locate: ?options: Leaflet.LocateOptions -> Map
        abstract member stopLocate: unit -> Map
        abstract member attributionControl: Leaflet.Control_.Attribution with get, set
        abstract member boxZoom: Leaflet.Handler with get, set
        abstract member doubleClickZoom: Leaflet.Handler with get, set
        abstract member dragging: Leaflet.Handler with get, set
        abstract member keyboard: Leaflet.Handler with get, set
        abstract member scrollWheelZoom: Leaflet.Handler with get, set
        abstract member tapHold: Leaflet.Handler option with get, set
        abstract member touchZoom: Leaflet.Handler with get, set
        abstract member zoomControl: Leaflet.Control_.Zoom with get, set
        abstract member options: Leaflet.MapOptions with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type BaseIconOptions =
        inherit Leaflet.LayerOptions
        abstract member iconUrl: string option with get, set
        abstract member iconRetinaUrl: string option with get, set
        abstract member iconSize: Leaflet.PointExpression option with get, set
        abstract member iconAnchor: Leaflet.PointExpression option with get, set
        abstract member popupAnchor: Leaflet.PointExpression option with get, set
        abstract member tooltipAnchor: Leaflet.PointExpression option with get, set
        abstract member shadowUrl: string option with get, set
        abstract member shadowRetinaUrl: string option with get, set
        abstract member shadowSize: Leaflet.PointExpression option with get, set
        abstract member shadowAnchor: Leaflet.PointExpression option with get, set
        abstract member className: string option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type IconOptions =
        inherit Leaflet.BaseIconOptions
        abstract member iconUrl: string with get, set
        abstract member crossOrigin: IconOptions.crossOrigin option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (iconUrl: string, ?pane: string, ?attribution: string, ?iconRetinaUrl: string, ?iconSize: Leaflet.PointExpression, ?iconAnchor: Leaflet.PointExpression, ?popupAnchor: Leaflet.PointExpression, ?tooltipAnchor: Leaflet.PointExpression, ?shadowUrl: string, ?shadowRetinaUrl: string, ?shadowSize: Leaflet.PointExpression, ?shadowAnchor: Leaflet.PointExpression, ?className: string, ?crossOrigin: IconOptions.crossOrigin) : IconOptions = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type Icon<'T> =
        inherit Leaflet.Layer
        abstract member createIcon: ?oldIcon: Glutinum.Web.HTMLElement -> Glutinum.Web.HTMLElement
        abstract member createShadow: ?oldIcon: Glutinum.Web.HTMLElement -> Glutinum.Web.HTMLElement

    type Icon =
        Icon<Leaflet.IconOptions>

    module Icon_ =

        [<AbstractClass>]
        [<Erase>]
        type Exports =
            [<Emit("new $0.Default($1...)")>]
            abstract member Default: ?options: Leaflet.Icon_.DefaultIconOptions -> Default

        [<AllowNullLiteral>]
        [<Interface>]
        type DefaultIconOptions =
            inherit Leaflet.BaseIconOptions
            abstract member imagePath: string option with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (?pane: string, ?attribution: string, ?iconUrl: string, ?iconRetinaUrl: string, ?iconSize: Leaflet.PointExpression, ?iconAnchor: Leaflet.PointExpression, ?popupAnchor: Leaflet.PointExpression, ?tooltipAnchor: Leaflet.PointExpression, ?shadowUrl: string, ?shadowRetinaUrl: string, ?shadowSize: Leaflet.PointExpression, ?shadowAnchor: Leaflet.PointExpression, ?className: string, ?imagePath: string) : DefaultIconOptions = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type Default =
            inherit Leaflet.Icon<Leaflet.Icon_.DefaultIconOptions>
            [<Emit("""import { Default } from "leaflet";
Default.imagePath{{=$0}}""")>]
            static member inline imagePath
                with get () : string =
                    nativeOnly
                and set (value: string) =
                    nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type DivIconOptions =
        inherit Leaflet.BaseIconOptions
        abstract member html: U3<string, Glutinum.Web.Element, bool> option with get, set
        abstract member bgPos: Leaflet.PointExpression option with get, set
        abstract member iconSize: Leaflet.PointExpression option with get, set
        abstract member iconAnchor: Leaflet.PointExpression option with get, set
        abstract member popupAnchor: Leaflet.PointExpression option with get, set
        abstract member className: string option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?pane: string, ?attribution: string, ?iconUrl: string, ?iconRetinaUrl: string, ?tooltipAnchor: Leaflet.PointExpression, ?shadowUrl: string, ?shadowRetinaUrl: string, ?shadowSize: Leaflet.PointExpression, ?shadowAnchor: Leaflet.PointExpression, ?bgPos: Leaflet.PointExpression, ?iconSize: Leaflet.PointExpression, ?iconAnchor: Leaflet.PointExpression, ?popupAnchor: Leaflet.PointExpression, ?className: string) : DivIconOptions = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (html: string, ?pane: string, ?attribution: string, ?iconUrl: string, ?iconRetinaUrl: string, ?tooltipAnchor: Leaflet.PointExpression, ?shadowUrl: string, ?shadowRetinaUrl: string, ?shadowSize: Leaflet.PointExpression, ?shadowAnchor: Leaflet.PointExpression, ?bgPos: Leaflet.PointExpression, ?iconSize: Leaflet.PointExpression, ?iconAnchor: Leaflet.PointExpression, ?popupAnchor: Leaflet.PointExpression, ?className: string) : DivIconOptions = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (html: Glutinum.Web.Element, ?pane: string, ?attribution: string, ?iconUrl: string, ?iconRetinaUrl: string, ?tooltipAnchor: Leaflet.PointExpression, ?shadowUrl: string, ?shadowRetinaUrl: string, ?shadowSize: Leaflet.PointExpression, ?shadowAnchor: Leaflet.PointExpression, ?bgPos: Leaflet.PointExpression, ?iconSize: Leaflet.PointExpression, ?iconAnchor: Leaflet.PointExpression, ?popupAnchor: Leaflet.PointExpression, ?className: string) : DivIconOptions = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (html: bool, ?pane: string, ?attribution: string, ?iconUrl: string, ?iconRetinaUrl: string, ?tooltipAnchor: Leaflet.PointExpression, ?shadowUrl: string, ?shadowRetinaUrl: string, ?shadowSize: Leaflet.PointExpression, ?shadowAnchor: Leaflet.PointExpression, ?bgPos: Leaflet.PointExpression, ?iconSize: Leaflet.PointExpression, ?iconAnchor: Leaflet.PointExpression, ?popupAnchor: Leaflet.PointExpression, ?className: string) : DivIconOptions = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type DivIcon =
        inherit Leaflet.Icon<Leaflet.DivIconOptions>

    [<AllowNullLiteral>]
    [<Interface>]
    type MarkerOptions =
        inherit Leaflet.InteractiveLayerOptions
        abstract member icon: U2<Leaflet.Icon, Leaflet.DivIcon> option with get, set
        /// <summary>
        /// Whether the marker is draggable with mouse/touch or not.
        /// </summary>
        abstract member draggable: bool option with get, set
        /// <summary>
        /// Whether the marker can be tabbed to with a keyboard and clicked by pressing enter.
        /// </summary>
        abstract member keyboard: bool option with get, set
        /// <summary>
        /// Text for the browser tooltip that appear on marker hover (no tooltip by default).
        /// </summary>
        abstract member title: string option with get, set
        /// <summary>
        /// Text for the <c>alt</c> attribute of the icon image (useful for accessibility).
        /// </summary>
        abstract member alt: string option with get, set
        /// <summary>
        /// Option for putting the marker on top of all others (or below).
        /// </summary>
        abstract member zIndexOffset: float option with get, set
        /// <summary>
        /// The opacity of the marker.
        /// </summary>
        abstract member opacity: float option with get, set
        /// <summary>
        /// If <c>true</c>, the marker will get on top of others when you hover the mouse over it.
        /// </summary>
        abstract member riseOnHover: bool option with get, set
        /// <summary>
        /// The z-index offset used for the <c>riseOnHover</c> feature.
        /// </summary>
        abstract member riseOffset: float option with get, set
        /// <summary>
        /// <c>Map pane</c> where the markers shadow will be added.
        /// </summary>
        abstract member shadowPane: string option with get, set
        /// <summary>
        /// Whether to pan the map when dragging this marker near its edge or not.
        /// </summary>
        abstract member autoPan: bool option with get, set
        /// <summary>
        /// Distance (in pixels to the left/right and to the top/bottom) of the map edge to start panning the map.
        /// </summary>
        abstract member autoPanPadding: Leaflet.PointExpression option with get, set
        /// <summary>
        /// Number of pixels the map should pan by.
        /// </summary>
        abstract member autoPanSpeed: float option with get, set
        abstract member autoPanOnFocus: bool option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?pane: string, ?attribution: string, ?interactive: bool, ?bubblingMouseEvents: bool, ?draggable: bool, ?keyboard: bool, ?title: string, ?alt: string, ?zIndexOffset: float, ?opacity: float, ?riseOnHover: bool, ?riseOffset: float, ?shadowPane: string, ?autoPan: bool, ?autoPanPadding: Leaflet.PointExpression, ?autoPanSpeed: float, ?autoPanOnFocus: bool) : MarkerOptions = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (icon: Leaflet.Icon, ?pane: string, ?attribution: string, ?interactive: bool, ?bubblingMouseEvents: bool, ?draggable: bool, ?keyboard: bool, ?title: string, ?alt: string, ?zIndexOffset: float, ?opacity: float, ?riseOnHover: bool, ?riseOffset: float, ?shadowPane: string, ?autoPan: bool, ?autoPanPadding: Leaflet.PointExpression, ?autoPanSpeed: float, ?autoPanOnFocus: bool) : MarkerOptions = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (icon: Leaflet.DivIcon, ?pane: string, ?attribution: string, ?interactive: bool, ?bubblingMouseEvents: bool, ?draggable: bool, ?keyboard: bool, ?title: string, ?alt: string, ?zIndexOffset: float, ?opacity: float, ?riseOnHover: bool, ?riseOffset: float, ?shadowPane: string, ?autoPan: bool, ?autoPanPadding: Leaflet.PointExpression, ?autoPanSpeed: float, ?autoPanOnFocus: bool) : MarkerOptions = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type Marker<'P> =
        inherit Leaflet.Layer
        abstract member toGeoJSON: ?precision: U2<float, bool> -> Glutinum.Geojson.Feature<Glutinum.Geojson.Point, 'P>
        abstract member getLatLng: unit -> Leaflet.LatLng
        abstract member setLatLng: latlng: Leaflet.LatLng -> Marker<'P>
        abstract member setLatLng: latlng: Leaflet.LatLngLiteral -> Marker<'P>
        abstract member setLatLng: latlng: Leaflet.LatLngTuple -> Marker<'P>
        abstract member setLatLng: latlng: Leaflet.LatLngExpression -> Marker<'P>
        abstract member setZIndexOffset: offset: float -> Marker<'P>
        abstract member getIcon: unit -> U2<Leaflet.Icon, Leaflet.DivIcon>
        abstract member setIcon: icon: Leaflet.Icon -> Marker<'P>
        abstract member setIcon: icon: Leaflet.DivIcon -> Marker<'P>
        abstract member setIcon: icon: U2<Leaflet.Icon, Leaflet.DivIcon> -> Marker<'P>
        abstract member setOpacity: opacity: float -> Marker<'P>
        abstract member getElement: unit -> Glutinum.Web.HTMLElement option
        abstract member dragging: Leaflet.Handler option with get, set
        abstract member feature: Glutinum.Geojson.Feature<Glutinum.Geojson.Point, 'P> option with get, set

    type Marker =
        Marker<obj>

    module Browser_ =

        [<AbstractClass>]
        [<Erase>]
        type Exports =
            [<Emit("$0.ie")>]
            abstract member ie: bool
            [<Emit("$0.ielt9")>]
            abstract member ielt9: bool
            [<Emit("$0.edge")>]
            abstract member edge: bool
            [<Emit("$0.webkit")>]
            abstract member webkit: bool
            [<Emit("$0.android")>]
            abstract member android: bool
            [<Emit("$0.android23")>]
            abstract member android23: bool
            [<Emit("$0.androidStock")>]
            abstract member androidStock: bool
            [<Emit("$0.opera")>]
            abstract member opera: bool
            [<Emit("$0.chrome")>]
            abstract member chrome: bool
            [<Emit("$0.gecko")>]
            abstract member gecko: bool
            [<Emit("$0.safari")>]
            abstract member safari: bool
            [<Emit("$0.opera12")>]
            abstract member opera12: bool
            [<Emit("$0.win")>]
            abstract member win: bool
            [<Emit("$0.ie3d")>]
            abstract member ie3d: bool
            [<Emit("$0.webkit3d")>]
            abstract member webkit3d: bool
            [<Emit("$0.gecko3d")>]
            abstract member gecko3d: bool
            [<Emit("$0.any3d")>]
            abstract member any3d: bool
            [<Emit("$0.mobile")>]
            abstract member mobile: bool
            [<Emit("$0.mobileWebkit")>]
            abstract member mobileWebkit: bool
            [<Emit("$0.mobileWebkit3d")>]
            abstract member mobileWebkit3d: bool
            [<Emit("$0.msPointer")>]
            abstract member msPointer: bool
            [<Emit("$0.pointer")>]
            abstract member pointer: bool
            [<Emit("$0.touch")>]
            abstract member touch: bool
            [<Emit("$0.mobileOpera")>]
            abstract member mobileOpera: bool
            [<Emit("$0.mobileGecko")>]
            abstract member mobileGecko: bool
            [<Emit("$0.retina")>]
            abstract member retina: bool
            [<Emit("$0.canvas")>]
            abstract member canvas: bool
            [<Emit("$0.svg")>]
            abstract member svg: bool
            [<Emit("$0.vml")>]
            abstract member vml: bool

    module Util_ =

        [<AbstractClass>]
        [<Erase>]
        type Exports =
            [<Emit("$0.extend($1...)")>]
            abstract member extend: dest: obj * ?src: obj -> obj
            [<Emit("$0.extend($1...)")>]
            abstract member extend: dest: obj * src1: obj * src2: obj -> obj
            [<Emit("$0.extend($1...)")>]
            abstract member extend: dest: obj * src1: obj * src2: obj * src3: obj -> obj
            [<Emit("$0.create($1...)")>]
            abstract member create: proto: obj option * ?properties: obj -> obj
            [<Emit("$0.bind($1...)")>]
            abstract member bind: fn: System.Delegate * [<ParamArray>] obj: obj [] -> (unit -> unit)
            [<Emit("$0.stamp($1...)")>]
            abstract member stamp: obj: obj -> float
            [<Emit("$0.throttle($1...)")>]
            abstract member throttle: fn: (unit -> unit) * time: float * context: obj -> (unit -> unit)
            [<Emit("$0.wrapNum($1...)")>]
            abstract member wrapNum: num: float * range: ResizeArray<float> * ?includeMax: bool -> float
            [<Emit("$0.falseFn($1...)")>]
            abstract member falseFn: unit -> bool
            [<Emit("$0.formatNum($1...)")>]
            abstract member formatNum: num: float * ?digits: U2<float, bool> -> float
            [<Emit("$0.trim($1...)")>]
            abstract member trim: str: string -> string
            [<Emit("$0.splitWords($1...)")>]
            abstract member splitWords: str: string -> ResizeArray<string>
            [<Emit("$0.setOptions($1...)")>]
            abstract member setOptions: obj: obj * options: obj -> obj
            [<Emit("$0.getParamString($1...)")>]
            abstract member getParamString: obj: obj * ?existingUrl: string * ?uppercase: bool -> string
            [<Emit("$0.template($1...)")>]
            abstract member template: str: string * data: obj -> string
            [<Emit("$0.isArray($1...)")>]
            abstract member isArray: obj: obj -> bool
            [<Emit("$0.indexOf($1...)")>]
            abstract member indexOf: array: ResizeArray<obj> * el: obj -> float
            [<Emit("$0.requestAnimFrame($1...)")>]
            abstract member requestAnimFrame: fn: (float -> unit) * ?context: obj * ?immediate: bool -> float
            [<Emit("$0.cancelAnimFrame($1...)")>]
            abstract member cancelAnimFrame: id: float -> unit
            [<Emit("$0.lastId")>]
            abstract member lastId: float
            [<Emit("$0.emptyImageUrl")>]
            abstract member emptyImageUrl: string

    type StyleFunction =
        StyleFunction<obj>

    type GeoJSONOptions<'P> =
        GeoJSONOptions<'P, Glutinum.Geojson.GeometryObject>

    type GeoJSONOptions =
        GeoJSONOptions<obj, Glutinum.Geojson.GeometryObject>

    module Events =

        module on =

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type`` =
                | baselayerchange
                | overlayadd
                | overlayremove

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_1`` =
                | layeradd
                | layerremove

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_2`` =
                | zoomlevelschange
                | unload
                | viewreset
                | load
                | zoomstart
                | movestart
                | zoom
                | move
                | zoomend
                | moveend
                | autopanstart
                | dragstart
                | drag
                | add
                | remove
                | loading
                | error
                | update
                | down
                | predrag

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_3`` =
                | popupopen
                | popupclose

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_4`` =
                | tooltipopen
                | tooltipclose

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_5`` =
                | click
                | dblclick
                | mousedown
                | mouseup
                | mouseover
                | mouseout
                | mousemove
                | contextmenu
                | preclick

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_6`` =
                | keypress
                | keydown
                | keyup

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_7`` =
                | tileunload
                | tileloadstart
                | tileload
                | tileabort

        module off =

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type`` =
                | baselayerchange
                | overlayadd
                | overlayremove

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_1`` =
                | layeradd
                | layerremove

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_2`` =
                | zoomlevelschange
                | unload
                | viewreset
                | load
                | zoomstart
                | movestart
                | zoom
                | move
                | zoomend
                | moveend
                | autopanstart
                | dragstart
                | drag
                | add
                | remove
                | loading
                | error
                | update
                | down
                | predrag

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_3`` =
                | popupopen
                | popupclose

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_4`` =
                | tooltipopen
                | tooltipclose

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_5`` =
                | click
                | dblclick
                | mousedown
                | mouseup
                | mouseover
                | mouseout
                | mousemove
                | contextmenu
                | preclick

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_6`` =
                | keypress
                | keydown
                | keyup

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_7`` =
                | tileunload
                | tileloadstart
                | tileload
                | tileabort

        module listens =

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type`` =
                | baselayerchange
                | overlayadd
                | overlayremove
                | layeradd
                | layerremove
                | zoomlevelschange
                | unload
                | viewreset
                | load
                | zoomstart
                | movestart
                | zoom
                | move
                | zoomend
                | moveend
                | autopanstart
                | dragstart
                | drag
                | add
                | remove
                | loading
                | error
                | update
                | down
                | predrag
                | resize
                | popupopen
                | tooltipopen
                | tooltipclose
                | locationerror
                | locationfound
                | click
                | dblclick
                | mousedown
                | mouseup
                | mouseover
                | mouseout
                | mousemove
                | contextmenu
                | preclick
                | keypress
                | keydown
                | keyup
                | zoomanim
                | dragend
                | tileunload
                | tileloadstart
                | tileload
                | tileabort
                | tileerror

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_1`` =
                | baselayerchange
                | overlayadd
                | overlayremove

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_2`` =
                | layeradd
                | layerremove

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_3`` =
                | zoomlevelschange
                | unload
                | viewreset
                | load
                | zoomstart
                | movestart
                | zoom
                | move
                | zoomend
                | moveend
                | autopanstart
                | dragstart
                | drag
                | add
                | remove
                | loading
                | error
                | update
                | down
                | predrag

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_4`` =
                | popupopen
                | popupclose

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_5`` =
                | tooltipopen
                | tooltipclose

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_6`` =
                | click
                | dblclick
                | mousedown
                | mouseup
                | mouseover
                | mouseout
                | mousemove
                | contextmenu
                | preclick

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_7`` =
                | keypress
                | keydown
                | keyup

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_8`` =
                | tileunload
                | tileloadstart
                | tileload
                | tileabort

        module once =

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type`` =
                | baselayerchange
                | overlayadd
                | overlayremove

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_1`` =
                | layeradd
                | layerremove

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_2`` =
                | zoomlevelschange
                | unload
                | viewreset
                | load
                | zoomstart
                | movestart
                | zoom
                | move
                | zoomend
                | moveend
                | autopanstart
                | dragstart
                | drag
                | add
                | remove
                | loading
                | error
                | update
                | down
                | predrag

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_3`` =
                | popupopen
                | popupclose

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_4`` =
                | tooltipopen
                | tooltipclose

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_5`` =
                | click
                | dblclick
                | mousedown
                | mouseup
                | mouseover
                | mouseout
                | mousemove
                | contextmenu
                | preclick

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_6`` =
                | keypress
                | keydown
                | keyup

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_7`` =
                | tileunload
                | tileloadstart
                | tileload
                | tileabort

        module addEventListener =

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type`` =
                | baselayerchange
                | overlayadd
                | overlayremove

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_1`` =
                | layeradd
                | layerremove

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_2`` =
                | zoomlevelschange
                | unload
                | viewreset
                | load
                | zoomstart
                | movestart
                | zoom
                | move
                | zoomend
                | moveend
                | autopanstart
                | dragstart
                | drag
                | add
                | remove
                | loading
                | error
                | update
                | down
                | predrag

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_3`` =
                | popupopen
                | popupclose

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_4`` =
                | tooltipopen
                | tooltipclose

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_5`` =
                | click
                | dblclick
                | mousedown
                | mouseup
                | mouseover
                | mouseout
                | mousemove
                | contextmenu
                | preclick

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_6`` =
                | keypress
                | keydown
                | keyup

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_7`` =
                | tileunload
                | tileloadstart
                | tileload
                | tileabort

        module removeEventListener =

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type`` =
                | baselayerchange
                | overlayadd
                | overlayremove

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_1`` =
                | layeradd
                | layerremove

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_2`` =
                | zoomlevelschange
                | unload
                | viewreset
                | load
                | zoomstart
                | movestart
                | zoom
                | move
                | zoomend
                | moveend
                | autopanstart
                | dragstart
                | drag
                | add
                | remove
                | loading
                | error
                | update
                | down
                | predrag

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_3`` =
                | popupopen
                | popupclose

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_4`` =
                | tooltipopen
                | tooltipclose

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_5`` =
                | click
                | dblclick
                | mousedown
                | mouseup
                | mouseover
                | mouseout
                | mousemove
                | contextmenu
                | preclick

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_6`` =
                | keypress
                | keydown
                | keyup

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_7`` =
                | tileunload
                | tileloadstart
                | tileload
                | tileabort

        module addOneTimeEventListener =

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type`` =
                | baselayerchange
                | overlayadd
                | overlayremove

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_1`` =
                | layeradd
                | layerremove

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_2`` =
                | zoomlevelschange
                | unload
                | viewreset
                | load
                | zoomstart
                | movestart
                | zoom
                | move
                | zoomend
                | moveend
                | autopanstart
                | dragstart
                | drag
                | add
                | remove
                | loading
                | error
                | update
                | down
                | predrag

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_3`` =
                | popupopen
                | popupclose

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_4`` =
                | tooltipopen
                | tooltipclose

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_5`` =
                | click
                | dblclick
                | mousedown
                | mouseup
                | mouseover
                | mouseout
                | mousemove
                | contextmenu
                | preclick

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_6`` =
                | keypress
                | keydown
                | keyup

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_7`` =
                | tileunload
                | tileloadstart
                | tileload
                | tileabort

    module Evented =

        module on =

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type`` =
                | baselayerchange
                | overlayadd
                | overlayremove

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_1`` =
                | layeradd
                | layerremove

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_2`` =
                | zoomlevelschange
                | unload
                | viewreset
                | load
                | zoomstart
                | movestart
                | zoom
                | move
                | zoomend
                | moveend
                | autopanstart
                | dragstart
                | drag
                | add
                | remove
                | loading
                | error
                | update
                | down
                | predrag

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_3`` =
                | popupopen
                | popupclose

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_4`` =
                | tooltipopen
                | tooltipclose

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_5`` =
                | click
                | dblclick
                | mousedown
                | mouseup
                | mouseover
                | mouseout
                | mousemove
                | contextmenu
                | preclick

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_6`` =
                | keypress
                | keydown
                | keyup

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_7`` =
                | tileunload
                | tileloadstart
                | tileload
                | tileabort

        module off =

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type`` =
                | baselayerchange
                | overlayadd
                | overlayremove

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_1`` =
                | layeradd
                | layerremove

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_2`` =
                | zoomlevelschange
                | unload
                | viewreset
                | load
                | zoomstart
                | movestart
                | zoom
                | move
                | zoomend
                | moveend
                | autopanstart
                | dragstart
                | drag
                | add
                | remove
                | loading
                | error
                | update
                | down
                | predrag

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_3`` =
                | popupopen
                | popupclose

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_4`` =
                | tooltipopen
                | tooltipclose

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_5`` =
                | click
                | dblclick
                | mousedown
                | mouseup
                | mouseover
                | mouseout
                | mousemove
                | contextmenu
                | preclick

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_6`` =
                | keypress
                | keydown
                | keyup

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_7`` =
                | tileunload
                | tileloadstart
                | tileload
                | tileabort

        module listens =

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type`` =
                | baselayerchange
                | overlayadd
                | overlayremove
                | layeradd
                | layerremove
                | zoomlevelschange
                | unload
                | viewreset
                | load
                | zoomstart
                | movestart
                | zoom
                | move
                | zoomend
                | moveend
                | autopanstart
                | dragstart
                | drag
                | add
                | remove
                | loading
                | error
                | update
                | down
                | predrag
                | resize
                | popupopen
                | tooltipopen
                | tooltipclose
                | locationerror
                | locationfound
                | click
                | dblclick
                | mousedown
                | mouseup
                | mouseover
                | mouseout
                | mousemove
                | contextmenu
                | preclick
                | keypress
                | keydown
                | keyup
                | zoomanim
                | dragend
                | tileunload
                | tileloadstart
                | tileload
                | tileabort
                | tileerror

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_1`` =
                | baselayerchange
                | overlayadd
                | overlayremove

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_2`` =
                | layeradd
                | layerremove

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_3`` =
                | zoomlevelschange
                | unload
                | viewreset
                | load
                | zoomstart
                | movestart
                | zoom
                | move
                | zoomend
                | moveend
                | autopanstart
                | dragstart
                | drag
                | add
                | remove
                | loading
                | error
                | update
                | down
                | predrag

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_4`` =
                | popupopen
                | popupclose

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_5`` =
                | tooltipopen
                | tooltipclose

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_6`` =
                | click
                | dblclick
                | mousedown
                | mouseup
                | mouseover
                | mouseout
                | mousemove
                | contextmenu
                | preclick

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_7`` =
                | keypress
                | keydown
                | keyup

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_8`` =
                | tileunload
                | tileloadstart
                | tileload
                | tileabort

        module once =

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type`` =
                | baselayerchange
                | overlayadd
                | overlayremove

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_1`` =
                | layeradd
                | layerremove

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_2`` =
                | zoomlevelschange
                | unload
                | viewreset
                | load
                | zoomstart
                | movestart
                | zoom
                | move
                | zoomend
                | moveend
                | autopanstart
                | dragstart
                | drag
                | add
                | remove
                | loading
                | error
                | update
                | down
                | predrag

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_3`` =
                | popupopen
                | popupclose

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_4`` =
                | tooltipopen
                | tooltipclose

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_5`` =
                | click
                | dblclick
                | mousedown
                | mouseup
                | mouseover
                | mouseout
                | mousemove
                | contextmenu
                | preclick

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_6`` =
                | keypress
                | keydown
                | keyup

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_7`` =
                | tileunload
                | tileloadstart
                | tileload
                | tileabort

        module addEventListener =

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type`` =
                | baselayerchange
                | overlayadd
                | overlayremove

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_1`` =
                | layeradd
                | layerremove

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_2`` =
                | zoomlevelschange
                | unload
                | viewreset
                | load
                | zoomstart
                | movestart
                | zoom
                | move
                | zoomend
                | moveend
                | autopanstart
                | dragstart
                | drag
                | add
                | remove
                | loading
                | error
                | update
                | down
                | predrag

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_3`` =
                | popupopen
                | popupclose

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_4`` =
                | tooltipopen
                | tooltipclose

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_5`` =
                | click
                | dblclick
                | mousedown
                | mouseup
                | mouseover
                | mouseout
                | mousemove
                | contextmenu
                | preclick

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_6`` =
                | keypress
                | keydown
                | keyup

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_7`` =
                | tileunload
                | tileloadstart
                | tileload
                | tileabort

        module removeEventListener =

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type`` =
                | baselayerchange
                | overlayadd
                | overlayremove

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_1`` =
                | layeradd
                | layerremove

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_2`` =
                | zoomlevelschange
                | unload
                | viewreset
                | load
                | zoomstart
                | movestart
                | zoom
                | move
                | zoomend
                | moveend
                | autopanstart
                | dragstart
                | drag
                | add
                | remove
                | loading
                | error
                | update
                | down
                | predrag

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_3`` =
                | popupopen
                | popupclose

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_4`` =
                | tooltipopen
                | tooltipclose

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_5`` =
                | click
                | dblclick
                | mousedown
                | mouseup
                | mouseover
                | mouseout
                | mousemove
                | contextmenu
                | preclick

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_6`` =
                | keypress
                | keydown
                | keyup

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_7`` =
                | tileunload
                | tileloadstart
                | tileload
                | tileabort

        module addOneTimeEventListener =

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type`` =
                | baselayerchange
                | overlayadd
                | overlayremove

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_1`` =
                | layeradd
                | layerremove

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_2`` =
                | zoomlevelschange
                | unload
                | viewreset
                | load
                | zoomstart
                | movestart
                | zoom
                | move
                | zoomend
                | moveend
                | autopanstart
                | dragstart
                | drag
                | add
                | remove
                | loading
                | error
                | update
                | down
                | predrag

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_3`` =
                | popupopen
                | popupclose

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_4`` =
                | tooltipopen
                | tooltipclose

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_5`` =
                | click
                | dblclick
                | mousedown
                | mouseup
                | mouseover
                | mouseout
                | mousemove
                | contextmenu
                | preclick

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_6`` =
                | keypress
                | keydown
                | keyup

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_7`` =
                | tileunload
                | tileloadstart
                | tileload
                | tileabort

    module Layer =

        [<AllowNullLiteral>]
        [<Interface>]
        type getEvents =
            [<EmitIndexer>]
            abstract member Item: name: string -> Leaflet.LeafletEventHandlerFn with get, set

    module InternalTiles =

        [<AllowNullLiteral>]
        [<Interface>]
        type Item =
            abstract member active: bool option with get, set
            abstract member coords: Leaflet.Coords with get, set
            abstract member current: bool with get, set
            abstract member el: Glutinum.Web.HTMLElement with get, set
            abstract member loaded: Date option with get, set
            abstract member retain: bool option with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (coords: Leaflet.Coords, current: bool, el: Glutinum.Web.HTMLElement, ?active: bool, ?loaded: Date, ?retain: bool) : Item = nativeOnly

    module TileLayerOptions =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type crossOrigin =
            | anonymous
            | ``use-credentials``
            | [<CompiledName("")>] _EMPTY_
            | [<CompiledValue(true)>] True
            | [<CompiledValue(false)>] False

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type referrerPolicy =
            | ``no-referrer``
            | ``no-referrer-when-downgrade``
            | origin
            | ``origin-when-cross-origin``
            | ``same-origin``
            | ``strict-origin``
            | ``strict-origin-when-cross-origin``
            | ``unsafe-url``
            | [<CompiledValue(true)>] True
            | [<CompiledValue(false)>] False

    module WMSOptions =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type crossOrigin =
            | anonymous
            | ``use-credentials``
            | [<CompiledName("")>] _EMPTY_
            | [<CompiledValue(true)>] True
            | [<CompiledValue(false)>] False

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type referrerPolicy =
            | ``no-referrer``
            | ``no-referrer-when-downgrade``
            | origin
            | ``origin-when-cross-origin``
            | ``same-origin``
            | ``strict-origin``
            | ``strict-origin-when-cross-origin``
            | ``unsafe-url``
            | [<CompiledValue(true)>] True
            | [<CompiledValue(false)>] False

    module ImageOverlayOptions =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type crossOrigin =
            | anonymous
            | ``use-credentials``
            | [<CompiledName("")>] _EMPTY_
            | [<CompiledValue(true)>] True
            | [<CompiledValue(false)>] False

    module VideoOverlayOptions =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type crossOrigin =
            | anonymous
            | ``use-credentials``
            | [<CompiledName("")>] _EMPTY_
            | [<CompiledValue(true)>] True
            | [<CompiledValue(false)>] False

    module CircleMarker =

        module setStyle =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member radius: float option with get, set
                abstract member stroke: bool option with get, set
                abstract member color: string option with get, set
                abstract member weight: float option with get, set
                abstract member opacity: float option with get, set
                abstract member lineCap: Leaflet.LineCapShape option with get, set
                abstract member lineJoin: Leaflet.LineJoinShape option with get, set
                abstract member dashArray: U2<string, ResizeArray<float>> option with get, set
                abstract member dashOffset: string option with get, set
                abstract member fill: bool option with get, set
                abstract member fillColor: string option with get, set
                abstract member fillOpacity: float option with get, set
                abstract member fillRule: Leaflet.FillRule option with get, set
                abstract member renderer: Leaflet.Renderer option with get, set
                abstract member className: string option with get, set
                abstract member interactive: bool option with get, set
                abstract member bubblingMouseEvents: bool option with get, set
                abstract member pane: string option with get, set
                abstract member attribution: string option with get, set

    module GeoJSONOptions =

        type pointToLayer =
            delegate of geoJsonPoint: Glutinum.Geojson.Feature<Glutinum.Geojson.Point, obj> * latlng: Leaflet.LatLng -> Leaflet.Layer

        type onEachFeature =
            delegate of feature: Glutinum.Geojson.Feature<obj, obj> * layer: Leaflet.Layer -> unit

    module Map =

        [<AllowNullLiteral>]
        [<Interface>]
        type getPanes =
            abstract member mapPane: Glutinum.Web.HTMLElement with get, set
            abstract member tilePane: Glutinum.Web.HTMLElement with get, set
            abstract member overlayPane: Glutinum.Web.HTMLElement with get, set
            abstract member shadowPane: Glutinum.Web.HTMLElement with get, set
            abstract member markerPane: Glutinum.Web.HTMLElement with get, set
            abstract member tooltipPane: Glutinum.Web.HTMLElement with get, set
            abstract member popupPane: Glutinum.Web.HTMLElement with get, set
            [<EmitIndexer>]
            abstract member Item: name: string -> Glutinum.Web.HTMLElement with get, set

        module whenReady =

            module fn =

                [<AllowNullLiteral>]
                [<Interface>]
                type event =
                    abstract member target: Leaflet.Map with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (target: Leaflet.Map) : event = nativeOnly

    module IconOptions =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type crossOrigin =
            | anonymous
            | ``use-credentials``
            | [<CompiledName("")>] _EMPTY_
            | [<CompiledValue(true)>] True
            | [<CompiledValue(false)>] False

    module Exports =

        module latLng__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type coords =
                abstract member lat: float with get, set
                abstract member lng: float with get, set
                abstract member alt: float option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (lat: float, lng: float, ?alt: float) : coords = nativeOnly

        module point__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type coords =
                abstract member x: float with get, set
                abstract member y: float with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (x: float, y: float) : coords = nativeOnly

        module extend__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type Type =
                [<Emit("$0($1...)")>]
                abstract member Invoke<'D, 'S1>: dest: 'D * ?src: 'S1 -> obj
                [<Emit("$0($1...)")>]
                abstract member Invoke<'D, 'S1, 'S2>: dest: 'D * src1: 'S1 * src2: 'S2 -> obj
                [<Emit("$0($1...)")>]
                abstract member Invoke<'D, 'S1, 'S2, 'S3>: dest: 'D * src1: 'S1 * src2: 'S2 * src3: 'S3 -> obj

        module bind__ =

            type Type =
                delegate of fn: System.Delegate * [<ParamArray>] obj: obj [] -> (unit -> unit)

        module setOptions__ =

            type Type =
                delegate of obj: obj * options: obj -> unit
