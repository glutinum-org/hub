namespace rec Glutinum

open Fable.Core
open Fable.Core.JsInterop
open System

module Geojson =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type GeoJsonGeometryTypes =
        | Point
        | MultiPoint
        | LineString
        | MultiLineString
        | Polygon
        | MultiPolygon
        | GeometryCollection

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type GeoJsonTypes =
        | Point
        | MultiPoint
        | LineString
        | MultiLineString
        | Polygon
        | MultiPolygon
        | GeometryCollection
        | Feature
        | FeatureCollection

    /// <summary>
    /// Bounding box
    /// https://tools.ietf.org/html/rfc7946#section-5
    /// </summary>
    type BBox =
        U2<float * float * float * float, float * float * float * float * float * float>

    /// <summary>
    /// A Position is an array of coordinates.
    /// https://tools.ietf.org/html/rfc7946#section-3.1.1
    /// Array should contain between two and three elements.
    /// The previous GeoJSON specification allowed more elements (e.g., which could be used to represent M values),
    /// but the current specification only allows X, Y, and (optionally) Z to be defined.
    ///
    /// Note: the type will not be narrowed down to <c>[number, number] | [number, number, number]</c> due to
    /// marginal benefits and the large impact of breaking change.
    ///
    /// See previous discussions on the type narrowing:
    /// - <see href="https://github.com/DefinitelyTyped/DefinitelyTyped/pull/21590">Nov 2017</see>
    /// - <see href="https://github.com/DefinitelyTyped/DefinitelyTyped/discussions/67773">Dec 2023</see>
    /// - <see href="https://github.com/DefinitelyTyped/DefinitelyTyped/discussions/71441">Dec 2024</see>
    ///
    /// One can use a
    /// <see href="https://www.typescriptlang.org/docs/handbook/2/narrowing.html#using-type-predicates">user-defined type guard that returns a type predicate</see>
    /// to determine if a position is a 2D or 3D position.
    /// </summary>
    /// <example>
    /// import type { Position } from 'geojson';
    ///
    /// type StrictPosition = [x: number, y: number] | [x: number, y: number, z: number]
    ///
    /// function isStrictPosition(position: Position): position is StrictPosition {
    ///   return position.length === 2 || position.length === 3
    /// };
    ///
    /// let position: Position = [-116.91, 45.54];
    ///
    /// let x: number;
    /// let y: number;
    /// let z: number | undefined;
    ///
    /// if (isStrictPosition(position)) {
    ///   // <c>tsc</c> would throw an error if we tried to destructure a fourth parameter
    /// 	 [x, y, z] = position;
    /// } else {
    /// 	 throw new TypeError("Position is not a 2D or 3D point");
    /// }
    /// </example>
    type Position =
        ResizeArray<float>

    /// <summary>
    /// The base GeoJSON object.
    /// https://tools.ietf.org/html/rfc7946#section-3
    /// The GeoJSON specification also allows foreign members
    /// (https://tools.ietf.org/html/rfc7946#section-6.1)
    /// Developers should use "&" type in TypeScript or extend the interface
    /// to add these foreign members.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type GeoJsonObject =
        /// <summary>
        /// Specifies the type of GeoJSON object.
        /// </summary>
        abstract member ``type``: Geojson.GeoJsonTypes with get, set
        /// <summary>
        /// Bounding box of the coordinate range of the object's Geometries, Features, or Feature Collections.
        /// The value of the bbox member is an array of length 2*n where n is the number of dimensions
        /// represented in the contained geometries, with all axes of the most southwesterly point
        /// followed by all axes of the more northeasterly point.
        /// The axes order of a bbox follows the axes order of geometries.
        /// https://tools.ietf.org/html/rfc7946#section-5
        /// </summary>
        abstract member bbox: Geojson.BBox option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (``type``: Geojson.GeoJsonTypes, ?bbox: Geojson.BBox) : GeoJsonObject = nativeOnly

    /// <summary>
    /// Union of GeoJSON objects.
    /// </summary>
    type GeoJSON<'G, 'P> =
        U3<'G, Geojson.Feature<'G, 'P>, Geojson.FeatureCollection<'G, 'P>>

    /// <summary>
    /// Geometry object.
    /// https://tools.ietf.org/html/rfc7946#section-3
    /// </summary>
    type Geometry =
        U7<Geojson.Point, Geojson.MultiPoint, Geojson.LineString, Geojson.MultiLineString, Geojson.Polygon, Geojson.MultiPolygon, Geojson.GeometryCollection>

    type GeometryObject =
        Geojson.Geometry

    /// <summary>
    /// Point geometry object.
    /// https://tools.ietf.org/html/rfc7946#section-3.1.2
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type Point =
        inherit Geojson.GeoJsonObject
        /// <summary>
        /// Specifies the type of GeoJSON object.
        /// </summary>
        abstract member ``type``: string with get, set
        abstract member coordinates: Geojson.Position with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (``type``: string, coordinates: Geojson.Position, ?bbox: Geojson.BBox) : Point = nativeOnly

    /// <summary>
    /// MultiPoint geometry object.
    ///  https://tools.ietf.org/html/rfc7946#section-3.1.3
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type MultiPoint =
        inherit Geojson.GeoJsonObject
        /// <summary>
        /// Specifies the type of GeoJSON object.
        /// </summary>
        abstract member ``type``: string with get, set
        abstract member coordinates: ResizeArray<Geojson.Position> with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (``type``: string, coordinates: ResizeArray<Geojson.Position>, ?bbox: Geojson.BBox) : MultiPoint = nativeOnly

    /// <summary>
    /// LineString geometry object.
    /// https://tools.ietf.org/html/rfc7946#section-3.1.4
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type LineString =
        inherit Geojson.GeoJsonObject
        /// <summary>
        /// Specifies the type of GeoJSON object.
        /// </summary>
        abstract member ``type``: string with get, set
        abstract member coordinates: ResizeArray<Geojson.Position> with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (``type``: string, coordinates: ResizeArray<Geojson.Position>, ?bbox: Geojson.BBox) : LineString = nativeOnly

    /// <summary>
    /// MultiLineString geometry object.
    /// https://tools.ietf.org/html/rfc7946#section-3.1.5
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type MultiLineString =
        inherit Geojson.GeoJsonObject
        /// <summary>
        /// Specifies the type of GeoJSON object.
        /// </summary>
        abstract member ``type``: string with get, set
        abstract member coordinates: ResizeArray<ResizeArray<Geojson.Position>> with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (``type``: string, coordinates: ResizeArray<ResizeArray<Geojson.Position>>, ?bbox: Geojson.BBox) : MultiLineString = nativeOnly

    /// <summary>
    /// Polygon geometry object.
    /// https://tools.ietf.org/html/rfc7946#section-3.1.6
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type Polygon =
        inherit Geojson.GeoJsonObject
        /// <summary>
        /// Specifies the type of GeoJSON object.
        /// </summary>
        abstract member ``type``: string with get, set
        abstract member coordinates: ResizeArray<ResizeArray<Geojson.Position>> with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (``type``: string, coordinates: ResizeArray<ResizeArray<Geojson.Position>>, ?bbox: Geojson.BBox) : Polygon = nativeOnly

    /// <summary>
    /// MultiPolygon geometry object.
    /// https://tools.ietf.org/html/rfc7946#section-3.1.7
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type MultiPolygon =
        inherit Geojson.GeoJsonObject
        /// <summary>
        /// Specifies the type of GeoJSON object.
        /// </summary>
        abstract member ``type``: string with get, set
        abstract member coordinates: ResizeArray<ResizeArray<ResizeArray<Geojson.Position>>> with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (``type``: string, coordinates: ResizeArray<ResizeArray<ResizeArray<Geojson.Position>>>, ?bbox: Geojson.BBox) : MultiPolygon = nativeOnly

    /// <summary>
    /// Geometry Collection
    /// https://tools.ietf.org/html/rfc7946#section-3.1.8
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type GeometryCollection<'G> =
        inherit Geojson.GeoJsonObject
        /// <summary>
        /// Specifies the type of GeoJSON object.
        /// </summary>
        abstract member ``type``: string with get, set
        abstract member geometries: ResizeArray<'G> with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (``type``: string, geometries: ResizeArray<'G>, ?bbox: Geojson.BBox) : GeometryCollection<'G> = nativeOnly

    type GeoJsonProperties =
        GeoJsonProperties.Value option

    /// <summary>
    /// A feature object which contains a geometry and associated properties.
    /// https://tools.ietf.org/html/rfc7946#section-3.2
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type Feature<'G, 'P> =
        inherit Geojson.GeoJsonObject
        /// <summary>
        /// Specifies the type of GeoJSON object.
        /// </summary>
        abstract member ``type``: string with get, set
        /// <summary>
        /// The feature's geometry
        /// </summary>
        abstract member geometry: 'G with get, set
        /// <summary>
        /// A value that uniquely identifies this feature in a
        /// https://tools.ietf.org/html/rfc7946#section-3.2.
        /// </summary>
        abstract member id: U2<string, float> option with get, set
        /// <summary>
        /// Properties associated with this feature.
        /// </summary>
        abstract member properties: 'P with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (``type``: string, geometry: 'G, properties: 'P, ?bbox: Geojson.BBox) : Feature<'G, 'P> = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (``type``: string, geometry: 'G, properties: 'P, id: string, ?bbox: Geojson.BBox) : Feature<'G, 'P> = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (``type``: string, geometry: 'G, properties: 'P, id: float, ?bbox: Geojson.BBox) : Feature<'G, 'P> = nativeOnly

    /// <summary>
    /// A collection of feature objects.
    ///  https://tools.ietf.org/html/rfc7946#section-3.3
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type FeatureCollection<'G, 'P> =
        inherit Geojson.GeoJsonObject
        /// <summary>
        /// Specifies the type of GeoJSON object.
        /// </summary>
        abstract member ``type``: string with get, set
        abstract member features: ResizeArray<Geojson.Feature<'G, 'P>> with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (``type``: string, features: ResizeArray<Geojson.Feature<'G, 'P>>, ?bbox: Geojson.BBox) : FeatureCollection<'G, 'P> = nativeOnly

    type GeoJSON<'G> =
        GeoJSON<'G, Geojson.GeoJsonProperties>

    type GeoJSON =
        GeoJSON<Geojson.Geometry, Geojson.GeoJsonProperties>

    type GeometryCollection =
        GeometryCollection<obj>

    type Feature<'G> =
        Feature<'G, Geojson.GeoJsonProperties>

    type Feature =
        Feature<Geojson.Geometry, Geojson.GeoJsonProperties>

    type FeatureCollection<'G> =
        FeatureCollection<'G, Geojson.GeoJsonProperties>

    type FeatureCollection =
        FeatureCollection<Geojson.Geometry, Geojson.GeoJsonProperties>

    module GeoJsonProperties =

        [<AllowNullLiteral>]
        [<Interface>]
        type Value =
            [<EmitIndexer>]
            abstract member Item: name: string -> obj with get, set
