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

    [<AllowNullLiteral>]
    [<Interface>]
    type SignatureEvent =
        abstract member event: U3<Glutinum.Web.MouseEvent, Glutinum.Web.TouchEvent, Glutinum.Web.PointerEvent> with get, set
        abstract member ``type``: string with get, set
        abstract member x: float with get, set
        abstract member y: float with get, set
        abstract member pressure: float with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type FromDataOptions =
        abstract member clear: bool option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?clear: bool) : FromDataOptions = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type FromDataUrlOptions =
        abstract member ratio: float option with get, set
        abstract member width: float option with get, set
        abstract member height: float option with get, set
        abstract member xOffset: float option with get, set
        abstract member yOffset: float option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?ratio: float, ?width: float, ?height: float, ?xOffset: float, ?yOffset: float) : FromDataUrlOptions = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type ToSVGOptions =
        abstract member includeBackgroundColor: bool option with get, set
        abstract member includeDataUrl: bool option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?includeBackgroundColor: bool, ?includeDataUrl: bool) : ToSVGOptions = nativeOnly

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

    [<AllowNullLiteral>]
    [<Interface>]
    type Options =
        abstract member minDistance: float option with get, set
        abstract member backgroundColor: string option with get, set
        abstract member throttle: float option with get, set
        abstract member canvasContextOptions: Glutinum.Web.CanvasRenderingContext2DSettings option with get, set
        abstract member dotSize: float option with get, set
        abstract member minWidth: float option with get, set
        abstract member maxWidth: float option with get, set
        abstract member penColor: string option with get, set
        abstract member velocityFilterWeight: float option with get, set
        /// <summary>
        /// This is the globalCompositeOperation for the line.
        /// *default: 'source-over'*
        /// </summary>
        abstract member compositeOperation: Glutinum.Web.GlobalCompositeOperation option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?dotSize: float, ?minWidth: float, ?maxWidth: float, ?penColor: string, ?velocityFilterWeight: float, ?compositeOperation: Glutinum.Web.GlobalCompositeOperation, ?minDistance: float, ?backgroundColor: string, ?throttle: float, ?canvasContextOptions: Glutinum.Web.CanvasRenderingContext2DSettings) : Options = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type PointGroup =
        inherit SignaturePad.PointGroupOptions
        abstract member points: ResizeArray<SignaturePad.BasicPoint> with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type SignaturePad =
        inherit SignaturePad.SignatureEventTarget
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

    [<AllowNullLiteral>]
    [<Interface>]
    type BasicPoint =
        abstract member x: float with get, set
        abstract member y: float with get, set
        abstract member pressure: float with get, set
        abstract member time: float with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (x: float, y: float, pressure: float, time: float) : BasicPoint = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type Point =
        inherit SignaturePad.BasicPoint
        abstract member x: float with get, set
        abstract member y: float with get, set
        abstract member pressure: float with get, set
        abstract member time: float with get, set
        abstract member distanceTo: start: SignaturePad.BasicPoint -> float
        abstract member equals: other: SignaturePad.BasicPoint -> bool
        abstract member velocityFrom: start: SignaturePad.BasicPoint -> float

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
