namespace rec Glutinum

open Fable.Core
open Fable.Core.JsInterop
open System

// You need to add Glutinum.Web NuGet package to your project

module SignaturePad =

    [<AbstractClass>]
    [<Erase>]
    type Exports =
        [<ImportDefault("signature_pad"); EmitConstructor>]
        static member SignaturePad (canvas: Glutinum.Web.HTMLCanvasElement, ?options: SignaturePad.Options) : SignaturePad = nativeOnly

    type BasicPoint =
        SignaturePad.dist_types_point.BasicPoint

    [<AllowNullLiteral>]
    [<Interface>]
    type SignatureEvent =
        abstract member event: U3<Glutinum.Web.MouseEvent, Glutinum.Web.TouchEvent, Glutinum.Web.PointerEvent> with get, set
        abstract member ``type``: string with get, set
        abstract member x: float with get, set
        abstract member y: float with get, set
        abstract member pressure: float with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type FromDataOptions
        [<ParamObject; Emit("$0")>]
        (
            ?clear: bool
        ) =

        member val clear : bool option = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type FromDataUrlOptions
        [<ParamObject; Emit("$0")>]
        (
            ?ratio: float,
            ?width: float,
            ?height: float,
            ?xOffset: float,
            ?yOffset: float
        ) =

        member val ratio : float option = nativeOnly with get, set
        member val width : float option = nativeOnly with get, set
        member val height : float option = nativeOnly with get, set
        member val xOffset : float option = nativeOnly with get, set
        member val yOffset : float option = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type ToSVGOptions
        [<ParamObject; Emit("$0")>]
        (
            ?includeBackgroundColor: bool,
            ?includeDataUrl: bool
        ) =

        member val includeBackgroundColor : bool option = nativeOnly with get, set
        member val includeDataUrl : bool option = nativeOnly with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type PointGroupOptions =
        abstract member dotSize: float with get, set
        abstract member minWidth: float with get, set
        abstract member maxWidth: float with get, set
        abstract member penColor: string with get, set
        abstract member velocityFilterWeight: float with get, set
        /// <summary>
        /// This is the globalCompositeOperation for the line.
        /// *default: 'source-over'*
        /// </summary>
        abstract member compositeOperation: Glutinum.Web.GlobalCompositeOperation with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type Options
        [<ParamObject; Emit("$0")>]
        (
            ?dotSize: float,
            ?minWidth: float,
            ?maxWidth: float,
            ?penColor: string,
            ?velocityFilterWeight: float,
            ?compositeOperation: Glutinum.Web.GlobalCompositeOperation,
            ?minDistance: float,
            ?backgroundColor: string,
            ?throttle: float,
            ?canvasContextOptions: Glutinum.Web.CanvasRenderingContext2DSettings
        ) =

        member val dotSize : float option = nativeOnly with get, set
        member val minWidth : float option = nativeOnly with get, set
        member val maxWidth : float option = nativeOnly with get, set
        member val penColor : string option = nativeOnly with get, set
        member val velocityFilterWeight : float option = nativeOnly with get, set
        /// <summary>
        /// This is the globalCompositeOperation for the line.
        /// *default: 'source-over'*
        /// </summary>
        member val compositeOperation : Glutinum.Web.GlobalCompositeOperation option = nativeOnly with get, set
        member val minDistance : float option = nativeOnly with get, set
        member val backgroundColor : string option = nativeOnly with get, set
        member val throttle : float option = nativeOnly with get, set
        member val canvasContextOptions : Glutinum.Web.CanvasRenderingContext2DSettings option = nativeOnly with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type PointGroup =
        inherit SignaturePad.PointGroupOptions
        abstract member points: ResizeArray<SignaturePad.dist_types_point.BasicPoint> with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type SignaturePad =
        inherit SignaturePad.dist_types_signature_event_target.SignatureEventTarget
        abstract member dotSize: float with get, set
        abstract member minWidth: float with get, set
        abstract member maxWidth: float with get, set
        abstract member penColor: string with get, set
        abstract member minDistance: float with get, set
        abstract member velocityFilterWeight: float with get, set
        abstract member compositeOperation: Glutinum.Web.GlobalCompositeOperation with get, set
        abstract member backgroundColor: string with get, set
        abstract member throttle: float with get, set
        abstract member canvasContextOptions: Glutinum.Web.CanvasRenderingContext2DSettings with get, set
        abstract member clear: unit -> unit
        abstract member redraw: unit -> unit
        abstract member fromDataURL: dataUrl: string * ?options: SignaturePad.FromDataUrlOptions -> JS.Promise<unit>
        [<Emit("$0.toDataURL('image/svg+xml',$1...)")>]
        abstract member ``toDataURL_image/svg_PLUS_xml``: ?encoderOptions: SignaturePad.ToSVGOptions -> string
        abstract member toDataURL: ?``type``: string * ?encoderOptions: float -> string
        abstract member on: unit -> unit
        abstract member off: unit -> unit
        abstract member isEmpty: unit -> bool
        abstract member fromData: pointGroups: ResizeArray<SignaturePad.PointGroup> * ?arg1: SignaturePad.FromDataOptions -> unit
        abstract member toData: unit -> ResizeArray<SignaturePad.PointGroup>
        abstract member toSVG: ?arg0: SignaturePad.ToSVGOptions -> string

    module dist_types_point =

        [<AbstractClass>]
        [<Erase>]
        type Exports =
            [<Import("Point", "signature_pad/dist/types/point.js"); EmitConstructor>]
            static member Point (x: float, y: float, ?pressure: float, ?time: float) : Point = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type BasicPoint =
            abstract member x: float with get, set
            abstract member y: float with get, set
            abstract member pressure: float with get, set
            abstract member time: float with get, set

        [<AllowNullLiteral>]
        [<Interface>]
        type Point =
            inherit SignaturePad.dist_types_point.BasicPoint
            abstract member x: float with get, set
            abstract member y: float with get, set
            abstract member pressure: float with get, set
            abstract member time: float with get, set
            abstract member distanceTo: start: SignaturePad.dist_types_point.BasicPoint -> float
            abstract member equals: other: SignaturePad.dist_types_point.BasicPoint -> bool
            abstract member velocityFrom: start: SignaturePad.dist_types_point.BasicPoint -> float

    module dist_types_signature_event_target =

        [<AbstractClass>]
        [<Erase>]
        type Exports =
            [<Import("SignatureEventTarget", "signature_pad/dist/types/signature_event_target.js"); EmitConstructor>]
            static member SignatureEventTarget () : SignatureEventTarget = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type SignatureEventTarget =
            abstract member addEventListener: ``type``: string * listener: Glutinum.Web.EventListenerOrEventListenerObject option -> unit
            abstract member addEventListener: ``type``: string * listener: Glutinum.Web.EventListenerOrEventListenerObject option * options: bool -> unit
            abstract member addEventListener: ``type``: string * listener: Glutinum.Web.EventListenerOrEventListenerObject option * options: Glutinum.Web.AddEventListenerOptions -> unit
            abstract member dispatchEvent: event: Glutinum.Web.Event -> bool
            abstract member removeEventListener: ``type``: string * callback: Glutinum.Web.EventListenerOrEventListenerObject option -> unit
            abstract member removeEventListener: ``type``: string * callback: Glutinum.Web.EventListenerOrEventListenerObject option * options: bool -> unit
            abstract member removeEventListener: ``type``: string * callback: Glutinum.Web.EventListenerOrEventListenerObject option * options: Glutinum.Web.EventListenerOptions -> unit
