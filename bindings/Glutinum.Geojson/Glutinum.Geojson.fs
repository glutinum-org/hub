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

    [<RequireQualifiedAccess>]
    [<Erase>]
    type BBox =
        | Case1 of float * float * float * float
        | Case2 of float * float * float * float * float * float

        [<Emit("$0")>]
        static member op_Implicit(value: float * float * float * float) : BBox = nativeOnly

        [<Emit("$0")>]
        static member op_ErasedCast(value: float * float * float * float) : BBox = nativeOnly

        [<Emit("$0")>]
        static member op_Implicit(value: float * float * float * float * float * float) : BBox = nativeOnly

        [<Emit("$0")>]
        static member op_ErasedCast(value: float * float * float * float * float * float) : BBox = nativeOnly

        /// Unchecked, the value as <c>Case1</c> whatever case it holds
        [<Emit("$0")>]
        member _.AsCase1: float * float * float * float = nativeOnly

        /// Unchecked, the value as <c>Case2</c> whatever case it holds
        [<Emit("$0")>]
        member _.AsCase2: float * float * float * float * float * float = nativeOnly

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

    [<RequireQualifiedAccess>]
    [<Erase>]
    type GeoJSON<'G, 'P> =
        | G of 'G
        | Feature of Geojson.Feature<'G, 'P>
        | FeatureCollection of Geojson.FeatureCollection<'G, 'P>

        [<Emit("$0")>]
        static member op_Implicit(value: 'G) : GeoJSON<'G, 'P> = nativeOnly

        [<Emit("$0")>]
        static member op_ErasedCast(value: 'G) : GeoJSON<'G, 'P> = nativeOnly

        [<Emit("$0")>]
        static member op_Implicit(value: Geojson.Feature<'G, 'P>) : GeoJSON<'G, 'P> = nativeOnly

        [<Emit("$0")>]
        static member op_ErasedCast(value: Geojson.Feature<'G, 'P>) : GeoJSON<'G, 'P> = nativeOnly

        [<Emit("$0")>]
        static member op_Implicit(value: Geojson.FeatureCollection<'G, 'P>) : GeoJSON<'G, 'P> = nativeOnly

        [<Emit("$0")>]
        static member op_ErasedCast(value: Geojson.FeatureCollection<'G, 'P>) : GeoJSON<'G, 'P> = nativeOnly

        /// Unchecked, the value as <c>G</c> whatever case it holds
        [<Emit("$0")>]
        member _.AsG: 'G = nativeOnly

        /// Unchecked, the value as <c>Feature</c> whatever case it holds
        [<Emit("$0")>]
        member _.AsFeature: Geojson.Feature<'G, 'P> = nativeOnly

        /// Unchecked, the value as <c>FeatureCollection</c> whatever case it holds
        [<Emit("$0")>]
        member _.AsFeatureCollection: Geojson.FeatureCollection<'G, 'P> = nativeOnly

    [<RequireQualifiedAccess>]
    [<Erase>]
    type Geometry =
        | Point of Geojson.Point
        | MultiPoint of Geojson.MultiPoint
        | LineString of Geojson.LineString
        | MultiLineString of Geojson.MultiLineString
        | Polygon of Geojson.Polygon
        | MultiPolygon of Geojson.MultiPolygon
        | GeometryCollection of Geojson.GeometryCollection

        [<Emit("$0")>]
        static member op_Implicit(value: Geojson.Point) : Geometry = nativeOnly

        [<Emit("$0")>]
        static member op_ErasedCast(value: Geojson.Point) : Geometry = nativeOnly

        [<Emit("$0")>]
        static member op_Implicit(value: Geojson.MultiPoint) : Geometry = nativeOnly

        [<Emit("$0")>]
        static member op_ErasedCast(value: Geojson.MultiPoint) : Geometry = nativeOnly

        [<Emit("$0")>]
        static member op_Implicit(value: Geojson.LineString) : Geometry = nativeOnly

        [<Emit("$0")>]
        static member op_ErasedCast(value: Geojson.LineString) : Geometry = nativeOnly

        [<Emit("$0")>]
        static member op_Implicit(value: Geojson.MultiLineString) : Geometry = nativeOnly

        [<Emit("$0")>]
        static member op_ErasedCast(value: Geojson.MultiLineString) : Geometry = nativeOnly

        [<Emit("$0")>]
        static member op_Implicit(value: Geojson.Polygon) : Geometry = nativeOnly

        [<Emit("$0")>]
        static member op_ErasedCast(value: Geojson.Polygon) : Geometry = nativeOnly

        [<Emit("$0")>]
        static member op_Implicit(value: Geojson.MultiPolygon) : Geometry = nativeOnly

        [<Emit("$0")>]
        static member op_ErasedCast(value: Geojson.MultiPolygon) : Geometry = nativeOnly

        [<Emit("$0")>]
        static member op_Implicit(value: Geojson.GeometryCollection) : Geometry = nativeOnly

        [<Emit("$0")>]
        static member op_ErasedCast(value: Geojson.GeometryCollection) : Geometry = nativeOnly

        /// Unchecked, the value as <c>Point</c> whatever case it holds
        [<Emit("$0")>]
        member _.AsPoint: Geojson.Point = nativeOnly

        /// Unchecked, the value as <c>MultiPoint</c> whatever case it holds
        [<Emit("$0")>]
        member _.AsMultiPoint: Geojson.MultiPoint = nativeOnly

        /// Unchecked, the value as <c>LineString</c> whatever case it holds
        [<Emit("$0")>]
        member _.AsLineString: Geojson.LineString = nativeOnly

        /// Unchecked, the value as <c>MultiLineString</c> whatever case it holds
        [<Emit("$0")>]
        member _.AsMultiLineString: Geojson.MultiLineString = nativeOnly

        /// Unchecked, the value as <c>Polygon</c> whatever case it holds
        [<Emit("$0")>]
        member _.AsPolygon: Geojson.Polygon = nativeOnly

        /// Unchecked, the value as <c>MultiPolygon</c> whatever case it holds
        [<Emit("$0")>]
        member _.AsMultiPolygon: Geojson.MultiPolygon = nativeOnly

        /// Unchecked, the value as <c>GeometryCollection</c> whatever case it holds
        [<Emit("$0")>]
        member _.AsGeometryCollection: Geojson.GeometryCollection = nativeOnly

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
        GeometryCollection<Geojson.Geometry>

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
