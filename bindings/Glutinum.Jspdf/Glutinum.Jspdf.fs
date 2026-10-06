namespace rec Glutinum

open Fable.Core
open Fable.Core.JsInterop
open System

// You need to add Glutinum.Types NuGet package to your project
open Glutinum.Types.TypeScript

// You need to add Glutinum.Web NuGet package to your project

module Jspdf =

    [<AbstractClass>]
    [<Erase>]
    type Exports =
        [<Import("AcroFormField", "jspdf"); EmitConstructor>]
        static member AcroFormField () : AcroFormField = nativeOnly
        [<Import("AcroFormChoiceField", "jspdf"); EmitConstructor>]
        static member AcroFormChoiceField () : AcroFormChoiceField = nativeOnly
        [<Import("AcroFormListBox", "jspdf"); EmitConstructor>]
        static member AcroFormListBox () : AcroFormListBox = nativeOnly
        [<Import("AcroFormComboBox", "jspdf"); EmitConstructor>]
        static member AcroFormComboBox () : AcroFormComboBox = nativeOnly
        [<Import("AcroFormEditBox", "jspdf"); EmitConstructor>]
        static member AcroFormEditBox () : AcroFormEditBox = nativeOnly
        [<Import("AcroFormButton", "jspdf"); EmitConstructor>]
        static member AcroFormButton () : AcroFormButton = nativeOnly
        [<Import("AcroFormPushButton", "jspdf"); EmitConstructor>]
        static member AcroFormPushButton () : AcroFormPushButton = nativeOnly
        [<Import("AcroFormChildClass", "jspdf"); EmitConstructor>]
        static member AcroFormChildClass () : AcroFormChildClass = nativeOnly
        [<Import("AcroFormRadioButton", "jspdf"); EmitConstructor>]
        static member AcroFormRadioButton () : AcroFormRadioButton = nativeOnly
        [<Import("AcroFormCheckBox", "jspdf"); EmitConstructor>]
        static member AcroFormCheckBox () : AcroFormCheckBox = nativeOnly
        [<Import("AcroFormTextField", "jspdf"); EmitConstructor>]
        static member AcroFormTextField () : AcroFormTextField = nativeOnly
        [<Import("AcroFormPasswordField", "jspdf"); EmitConstructor>]
        static member AcroFormPasswordField () : AcroFormPasswordField = nativeOnly
        [<ImportDefault("jspdf"); EmitConstructor>]
        static member jsPDF (?options: Jspdf.jsPDFOptions) : jsPDF = nativeOnly
        [<ImportDefault("jspdf"); EmitConstructor>]
        static member jsPDF () : jsPDF = nativeOnly
        [<ImportDefault("jspdf"); EmitConstructor>]
        static member jsPDF (orientation: Exports.jsPDF.orientation, ?unit: Exports.jsPDF.unit, ?format: U2<string, ResizeArray<float>>, ?compressPdf: bool) : jsPDF = nativeOnly
        [<Import("GState", "jspdf"); EmitConstructor>]
        static member GState (parameters: Jspdf.GState) : GState = nativeOnly
        [<Import("ShadingPattern", "jspdf"); EmitConstructor>]
        static member ShadingPattern (``type``: Jspdf.ShadingPatternType, coords: ResizeArray<float>, colors: ResizeArray<Jspdf.ShadingPatterStop>, ?gState: Jspdf.GState, ?matrix: Jspdf.Matrix) : ShadingPattern = nativeOnly
        [<Import("TilingPattern", "jspdf"); EmitConstructor>]
        static member TilingPattern (boundingBox: ResizeArray<float>, xStep: float, yStep: float, ?gState: Jspdf.GState, ?matrix: Jspdf.Matrix) : TilingPattern = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type Annotation =
        abstract member ``type``: Annotation.``type`` with get, set
        abstract member title: string option with get, set
        abstract member bounds: Annotation.bounds with get, set
        abstract member contents: string with get, set
        abstract member ``open``: bool option with get, set
        abstract member color: string option with get, set
        abstract member name: string option with get, set
        abstract member top: float option with get, set
        abstract member pageNumber: float option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (``type``: Annotation.``type``, bounds: Annotation.bounds, contents: string, ?title: string, ?``open``: bool, ?color: string, ?name: string, ?top: float, ?pageNumber: float) : Annotation = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type TextWithLinkOptions =
        abstract member pageNumber: float option with get, set
        abstract member magFactor: TextWithLinkOptions.magFactor option with get, set
        abstract member zoom: float option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type AutoPrintInput =
        abstract member variant: AutoPrintInput.variant with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (variant: AutoPrintInput.variant) : AutoPrintInput = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type Html2CanvasOptions =
        /// <summary>
        /// Whether to parse and render the element asynchronously
        /// </summary>
        abstract member async: bool option with get, set
        /// <summary>
        /// Whether to allow cross-origin images to taint the canvas
        /// </summary>
        abstract member allowTaint: bool option with get, set
        /// <summary>
        /// Canvas background color, if none is specified in DOM. Set null for transparent
        /// </summary>
        abstract member backgroundColor: string option with get, set
        /// <summary>
        /// Existing canvas element to use as a base for drawing on
        /// </summary>
        abstract member canvas: obj option with get, set
        /// <summary>
        /// Whether to use ForeignObject rendering if the browser supports it
        /// </summary>
        abstract member foreignObjectRendering: bool option with get, set
        /// <summary>
        /// Predicate function which removes the matching elements from the render.
        /// </summary>
        abstract member ignoreElements: (Glutinum.Web.HTMLElement -> bool) option with get, set
        /// <summary>
        /// Timeout for loading images, in milliseconds. Setting it to 0 will result in no timeout.
        /// </summary>
        abstract member imageTimeout: float option with get, set
        /// <summary>
        /// Whether to render each letter seperately. Necessary if letter-spacing is used.
        /// </summary>
        abstract member letterRendering: bool option with get, set
        /// <summary>
        /// Whether to log events in the console.
        /// </summary>
        abstract member logging: bool option with get, set
        /// <summary>
        /// Callback function which is called when the Document has been cloned for rendering, can be used to modify the contents that will be rendered without affecting the original source document.
        /// </summary>
        abstract member onclone: Html2CanvasOptions.onclone option with get, set
        /// <summary>
        /// Url to the proxy which is to be used for loading cross-origin images. If left empty, cross-origin images won't be loaded.
        /// </summary>
        abstract member proxy: string option with get, set
        /// <summary>
        /// Whether to cleanup the cloned DOM elements html2canvas creates temporarily
        /// </summary>
        abstract member removeContainer: bool option with get, set
        /// <summary>
        /// The scale to use for rendering. Defaults to the browsers device pixel ratio.
        /// </summary>
        abstract member scale: float option with get, set
        /// <summary>
        /// Use svg powered rendering where available (FF11+).
        /// </summary>
        abstract member svgRendering: bool option with get, set
        /// <summary>
        /// Whether to test each image if it taints the canvas before drawing them
        /// </summary>
        abstract member taintTest: bool option with get, set
        /// <summary>
        /// Whether to attempt to load cross-origin images as CORS served, before reverting back to proxy.
        /// </summary>
        abstract member useCORS: bool option with get, set
        /// <summary>
        /// Define the width of the canvas in pixels. If null, renders with full width of the window.
        /// </summary>
        abstract member width: float option with get, set
        /// <summary>
        /// Define the heigt of the canvas in pixels. If null, renders with full height of the window.
        /// </summary>
        abstract member height: float option with get, set
        /// <summary>
        /// Crop canvas x-coordinate
        /// </summary>
        abstract member x: float option with get, set
        /// <summary>
        /// Crop canvas y-coordinate
        /// </summary>
        abstract member y: float option with get, set
        /// <summary>
        /// The x-scroll position to used when rendering element, (for example if the Element uses position: fixed )
        /// </summary>
        abstract member scrollX: float option with get, set
        /// <summary>
        /// The y-scroll position to used when rendering element, (for example if the Element uses position: fixed )
        /// </summary>
        abstract member scrollY: float option with get, set
        /// <summary>
        /// Window width to use when rendering Element, which may affect things like Media queries
        /// </summary>
        abstract member windowWidth: float option with get, set
        /// <summary>
        /// Window height to use when rendering Element, which may affect things like Media queries
        /// </summary>
        abstract member windowHeight: float option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?async: bool, ?allowTaint: bool, ?backgroundColor: string, ?canvas: obj, ?foreignObjectRendering: bool, ?ignoreElements: (Glutinum.Web.HTMLElement -> bool), ?imageTimeout: float, ?letterRendering: bool, ?logging: bool, ?onclone: Html2CanvasOptions.onclone, ?proxy: string, ?removeContainer: bool, ?scale: float, ?svgRendering: bool, ?taintTest: bool, ?useCORS: bool, ?width: float, ?height: float, ?x: float, ?y: float, ?scrollX: float, ?scrollY: float, ?windowWidth: float, ?windowHeight: float) : Html2CanvasOptions = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type HTMLWorkerProgress =
        abstract member ``val``: float with get, set
        abstract member n: float with get, set
        abstract member ratio: float with get, set
        abstract member state: obj with get, set
        abstract member stack: ResizeArray<Action> with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type HTMLWorker =
        abstract member from: src: Glutinum.Web.HTMLElement * ``type``: HTMLWorker.from.``type`` -> Jspdf.HTMLWorker
        abstract member from: src: string * ``type``: HTMLWorker.from.``type`` -> Jspdf.HTMLWorker
        abstract member from: src: U2<Glutinum.Web.HTMLElement, string> * ``type``: HTMLWorker.from.``type`` -> Jspdf.HTMLWorker
        abstract member progress: Jspdf.HTMLWorkerProgress with get, set
        abstract member error: msg: string -> unit
        abstract member save: filename: string -> JS.Promise<unit>
        abstract member set: opt: Jspdf.HTMLOptions -> Jspdf.HTMLWorker
        [<Emit("$0.get('string')")>]
        abstract member get_string: unit -> Jspdf.HTMLWorker
        [<Emit("$0.get('string',$1...)")>]
        abstract member get_string: cbk: (string -> unit) -> string
        abstract member doCallback: unit -> JS.Promise<unit>
        abstract member outputImg: ``type``: HTMLWorker.outputImg.``type`` -> JS.Promise<string>
        abstract member outputPdf: HTMLWorker.outputPdf with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type HTMLOptionImage =
        abstract member ``type``: HTMLOptionImage.``type`` with get, set
        abstract member quality: float with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (``type``: HTMLOptionImage.``type``, quality: float) : HTMLOptionImage = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type HTMLFontFace =
        abstract member family: string with get, set
        abstract member style: HTMLFontFace.style option with get, set
        abstract member stretch: HTMLFontFace.stretch option with get, set
        abstract member weight: HTMLFontFace.weight option with get, set
        abstract member src: ResizeArray<HTMLFontFace.src> with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (family: string, src: ResizeArray<HTMLFontFace.src>, ?style: HTMLFontFace.style, ?stretch: HTMLFontFace.stretch, ?weight: HTMLFontFace.weight) : HTMLFontFace = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type HTMLOptions =
        abstract member callback: (Jspdf.jsPDF -> unit) option with get, set
        abstract member margin: U2<float, ResizeArray<float>> option with get, set
        abstract member autoPaging: HTMLOptions.autoPaging option with get, set
        abstract member filename: string option with get, set
        abstract member image: Jspdf.HTMLOptionImage option with get, set
        abstract member html2canvas: Jspdf.Html2CanvasOptions option with get, set
        abstract member jsPDF: Jspdf.jsPDF option with get, set
        abstract member x: float option with get, set
        abstract member y: float option with get, set
        abstract member width: float option with get, set
        abstract member windowWidth: float option with get, set
        abstract member fontFaces: ResizeArray<Jspdf.HTMLFontFace> option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?callback: (Jspdf.jsPDF -> unit), ?autoPaging: HTMLOptions.autoPaging, ?filename: string, ?image: Jspdf.HTMLOptionImage, ?html2canvas: Jspdf.Html2CanvasOptions, ?jsPDF: Jspdf.jsPDF, ?x: float, ?y: float, ?width: float, ?windowWidth: float, ?fontFaces: ResizeArray<Jspdf.HTMLFontFace>) : HTMLOptions = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (margin: float, ?callback: (Jspdf.jsPDF -> unit), ?autoPaging: HTMLOptions.autoPaging, ?filename: string, ?image: Jspdf.HTMLOptionImage, ?html2canvas: Jspdf.Html2CanvasOptions, ?jsPDF: Jspdf.jsPDF, ?x: float, ?y: float, ?width: float, ?windowWidth: float, ?fontFaces: ResizeArray<Jspdf.HTMLFontFace>) : HTMLOptions = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (margin: ResizeArray<float>, ?callback: (Jspdf.jsPDF -> unit), ?autoPaging: HTMLOptions.autoPaging, ?filename: string, ?image: Jspdf.HTMLOptionImage, ?html2canvas: Jspdf.Html2CanvasOptions, ?jsPDF: Jspdf.jsPDF, ?x: float, ?y: float, ?width: float, ?windowWidth: float, ?fontFaces: ResizeArray<Jspdf.HTMLFontFace>) : HTMLOptions = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type ViewerPreferencesInput =
        abstract member HideToolbar: bool option with get, set
        abstract member HideMenubar: bool option with get, set
        abstract member HideWindowUI: bool option with get, set
        abstract member FitWindow: bool option with get, set
        abstract member CenterWindow: bool option with get, set
        abstract member DisplayDocTitle: bool option with get, set
        abstract member NonFullScreenPageMode: ViewerPreferencesInput.NonFullScreenPageMode option with get, set
        abstract member Direction: ViewerPreferencesInput.Direction option with get, set
        abstract member ViewArea: ViewerPreferencesInput.ViewArea option with get, set
        abstract member ViewClip: ViewerPreferencesInput.ViewClip option with get, set
        abstract member PrintArea: ViewerPreferencesInput.PrintArea option with get, set
        abstract member PrintClip: ViewerPreferencesInput.PrintClip option with get, set
        abstract member PrintScaling: ViewerPreferencesInput.PrintScaling option with get, set
        abstract member Duplex: ViewerPreferencesInput.Duplex option with get, set
        abstract member PickTrayByPDFSize: bool option with get, set
        abstract member PrintPageRange: ResizeArray<ResizeArray<float>> option with get, set
        abstract member NumCopies: float option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?HideToolbar: bool, ?HideMenubar: bool, ?HideWindowUI: bool, ?FitWindow: bool, ?CenterWindow: bool, ?DisplayDocTitle: bool, ?NonFullScreenPageMode: ViewerPreferencesInput.NonFullScreenPageMode, ?Direction: ViewerPreferencesInput.Direction, ?ViewArea: ViewerPreferencesInput.ViewArea, ?ViewClip: ViewerPreferencesInput.ViewClip, ?PrintArea: ViewerPreferencesInput.PrintArea, ?PrintClip: ViewerPreferencesInput.PrintClip, ?PrintScaling: ViewerPreferencesInput.PrintScaling, ?Duplex: ViewerPreferencesInput.Duplex, ?PickTrayByPDFSize: bool, ?PrintPageRange: ResizeArray<ResizeArray<float>>, ?NumCopies: float) : ViewerPreferencesInput = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type Outline =
        abstract member add: parent: obj * title: string * options: Jspdf.OutlineOptions -> Jspdf.OutlineItem

    [<AllowNullLiteral>]
    [<Interface>]
    type OutlineItem =
        abstract member title: string with get, set
        abstract member options: obj with get, set
        abstract member children: ResizeArray<obj> with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type OutlineOptions =
        abstract member pageNumber: float with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (pageNumber: float) : OutlineOptions = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type AcroFormField =
        abstract member ``constructor``: unit -> Jspdf.AcroFormField
        abstract member showWhenPrinted: bool with get, set
        abstract member x: float with get, set
        abstract member y: float with get, set
        abstract member width: float with get, set
        abstract member height: float with get, set
        abstract member fieldName: string with get, set
        abstract member fontName: string with get, set
        abstract member fontStyle: string with get, set
        abstract member fontSize: float with get, set
        abstract member maxFontSize: float with get, set
        abstract member color: string with get, set
        abstract member defaultValue: string with get, set
        abstract member value: string with get, set
        abstract member hasAnnotation: bool with get, set
        abstract member readOnly: bool with get, set
        abstract member required: bool with get, set
        abstract member noExport: bool with get, set
        abstract member textAlign: AcroFormField.textAlign with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type AcroFormChoiceField =
        inherit Jspdf.AcroFormField
        abstract member topIndex: float with get, set
        abstract member getOptions: unit -> ResizeArray<string>
        abstract member setOptions: value: ResizeArray<string> -> unit
        abstract member addOption: value: string -> unit
        abstract member removeOption: value: string * allEntries: bool -> unit
        abstract member combo: bool with get, set
        abstract member edit: bool with get, set
        abstract member sort: bool with get, set
        abstract member multiSelect: bool with get, set
        abstract member doNotSpellCheck: bool with get, set
        abstract member commitOnSelChange: bool with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type AcroFormListBox =
        inherit Jspdf.AcroFormChoiceField

    [<AllowNullLiteral>]
    [<Interface>]
    type AcroFormComboBox =
        inherit Jspdf.AcroFormListBox

    [<AllowNullLiteral>]
    [<Interface>]
    type AcroFormEditBox =
        inherit Jspdf.AcroFormComboBox

    [<AllowNullLiteral>]
    [<Interface>]
    type AcroFormButton =
        inherit Jspdf.AcroFormField
        abstract member noToggleToOff: bool with get, set
        abstract member radio: bool with get, set
        abstract member pushButton: bool with get, set
        abstract member radioIsUnison: bool with get, set
        abstract member caption: string with get, set
        abstract member appearanceState: obj with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type AcroFormPushButton =
        inherit Jspdf.AcroFormButton

    [<AllowNullLiteral>]
    [<Interface>]
    type AcroFormChildClass =
        inherit Jspdf.AcroFormField
        abstract member Parent: obj with get, set
        abstract member optionName: string with get, set
        abstract member caption: string with get, set
        abstract member appearanceState: AcroFormChildClass.appearanceState with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type AcroFormRadioButton =
        inherit Jspdf.AcroFormButton
        abstract member setAppearance: appearance: string -> unit
        abstract member createOption: name: string -> Jspdf.AcroFormChildClass

    [<AllowNullLiteral>]
    [<Interface>]
    type AcroFormCheckBox =
        inherit Jspdf.AcroFormButton
        abstract member appearanceState: AcroFormCheckBox.appearanceState with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type AcroFormTextField =
        inherit Jspdf.AcroFormField
        abstract member multiline: bool with get, set
        abstract member fileSelect: bool with get, set
        abstract member doNotSpellCheck: bool with get, set
        abstract member doNotScroll: bool with get, set
        abstract member comb: bool with get, set
        abstract member richText: bool with get, set
        abstract member maxLength: float with get, set
        abstract member hasAppearanceStream: bool with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type AcroFormPasswordField =
        inherit Jspdf.AcroFormTextField

    [<AllowNullLiteral>]
    [<Interface>]
    type Gradient =
        abstract member addColorStop: position: float * color: string -> unit
        abstract member getColor: unit -> string

    [<AllowNullLiteral>]
    [<Interface>]
    type Context2d =
        abstract member autoPaging: bool with get, set
        abstract member margin: ResizeArray<float> with get, set
        abstract member fillStyle: U2<string, Jspdf.Gradient> with get, set
        abstract member filter: string with get, set
        abstract member font: string with get, set
        abstract member globalAlpha: float with get, set
        abstract member globalCompositeOperation: string with get, set
        abstract member imageSmoothingEnabled: bool with get, set
        abstract member imageSmoothingQuality: Context2d.imageSmoothingQuality with get, set
        abstract member ignoreClearRect: bool with get, set
        abstract member lastBreak: float with get, set
        abstract member lineCap: Context2d.lineCap with get, set
        abstract member lineDashOffset: float with get, set
        abstract member lineJoin: Context2d.lineJoin with get, set
        abstract member lineWidth: float with get, set
        abstract member miterLimit: float with get, set
        abstract member pageBreaks: ResizeArray<float> with get, set
        abstract member pageWrapXEnabled: bool with get, set
        abstract member pageWrapYEnabled: bool with get, set
        abstract member posX: float with get, set
        abstract member posY: float with get, set
        abstract member shadowBlur: float with get, set
        abstract member shadowColor: string with get, set
        abstract member shadowOffsetX: float with get, set
        abstract member shadowOffsetY: float with get, set
        abstract member strokeStyle: U2<string, Jspdf.Gradient> with get, set
        abstract member textAlign: Context2d.textAlign with get, set
        abstract member textBaseline: Context2d.textBaseline with get, set
        abstract member arc: x: float * y: float * radius: float * startAngle: float * endAngle: float * counterclockwise: bool -> unit
        abstract member arcTo: x1: float * y1: float * x2: float * y2: float * radius: float -> unit
        abstract member beginPath: unit -> unit
        abstract member bezierCurveTo: cp1x: float * cp1y: float * cp2x: float * cp2y: float * x: float * y: float -> unit
        abstract member clearRect: x: float * y: float * w: float * h: float -> unit
        abstract member clip: unit -> Jspdf.jsPDF
        abstract member clipEvenOdd: unit -> Jspdf.jsPDF
        abstract member closePath: unit -> unit
        abstract member createLinearGradient: x0: float * y0: float * x1: float * y1: float -> Jspdf.Gradient
        abstract member createPattern: unit -> Jspdf.Gradient
        abstract member createRadialGradient: unit -> Jspdf.Gradient
        abstract member drawImage: img: string * x: float * y: float * width: float * height: float -> unit
        abstract member drawImage: img: string * sx: float * sy: float * swidth: float * sheight: float * x: float * y: float * width: float * height: float -> unit
        abstract member fill: unit -> unit
        abstract member fillRect: x: float * y: float * w: float * h: float -> unit
        abstract member fillText: text: string * x: float * y: float * ?maxWidth: float -> unit
        abstract member lineTo: x: float * y: float -> unit
        abstract member measureText: text: string -> float
        abstract member moveTo: x: float * y: float -> unit
        abstract member quadraticCurveTo: cpx: float * cpy: float * x: float * y: float -> unit
        abstract member rect: x: float * y: float * w: float * h: float -> unit
        abstract member restore: unit -> unit
        abstract member rotate: angle: float -> unit
        abstract member save: unit -> unit
        abstract member scale: scalewidth: float * scaleheight: float -> unit
        abstract member setTransform: a: float * b: float * c: float * d: float * e: float * f: float -> unit
        abstract member stroke: unit -> unit
        abstract member strokeRect: x: float * y: float * w: float * h: float -> unit
        abstract member strokeText: text: string * x: float * y: float * ?maxWidth: float -> unit
        abstract member transform: a: float * b: float * c: float * d: float * e: float * f: float -> unit
        abstract member translate: x: float * y: float -> unit

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type ImageCompression =
        | NONE
        | FAST
        | MEDIUM
        | SLOW

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type ColorSpace =
        | DeviceRGB
        | DeviceGray
        | DeviceCMYK
        | CalGray
        | CalRGB
        | Lab
        | ICCBased
        | Indexed
        | Pattern
        | Separation
        | DeviceN

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type ImageFormat =
        | RGBA
        | UNKNOWN
        | PNG
        | TIFF
        | JPG
        | JPEG
        | JPEG2000
        | GIF87a
        | GIF89a
        | WEBP
        | BMP

    [<AllowNullLiteral>]
    [<Interface>]
    type ImageOptions =
        abstract member imageData: U5<string, Glutinum.Web.HTMLImageElement, Glutinum.Web.HTMLCanvasElement, JS.Uint8Array, Jspdf.RGBAData> with get, set
        abstract member x: float with get, set
        abstract member y: float with get, set
        abstract member width: float with get, set
        abstract member height: float with get, set
        abstract member alias: string option with get, set
        abstract member compression: Jspdf.ImageCompression option with get, set
        abstract member rotation: float option with get, set
        abstract member format: Jspdf.ImageFormat option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (imageData: string, x: float, y: float, width: float, height: float, ?alias: string, ?compression: Jspdf.ImageCompression, ?rotation: float, ?format: Jspdf.ImageFormat) : ImageOptions = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (imageData: Glutinum.Web.HTMLImageElement, x: float, y: float, width: float, height: float, ?alias: string, ?compression: Jspdf.ImageCompression, ?rotation: float, ?format: Jspdf.ImageFormat) : ImageOptions = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (imageData: Glutinum.Web.HTMLCanvasElement, x: float, y: float, width: float, height: float, ?alias: string, ?compression: Jspdf.ImageCompression, ?rotation: float, ?format: Jspdf.ImageFormat) : ImageOptions = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (imageData: JS.Uint8Array, x: float, y: float, width: float, height: float, ?alias: string, ?compression: Jspdf.ImageCompression, ?rotation: float, ?format: Jspdf.ImageFormat) : ImageOptions = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (imageData: Jspdf.RGBAData, x: float, y: float, width: float, height: float, ?alias: string, ?compression: Jspdf.ImageCompression, ?rotation: float, ?format: Jspdf.ImageFormat) : ImageOptions = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type ImageProperties =
        abstract member alias: float with get, set
        abstract member width: float with get, set
        abstract member height: float with get, set
        abstract member colorSpace: Jspdf.ColorSpace with get, set
        abstract member bitsPerComponent: float with get, set
        abstract member filter: string with get, set
        abstract member decodeParameters: string option with get, set
        abstract member transparency: obj option with get, set
        abstract member palette: obj option with get, set
        abstract member sMask: obj option with get, set
        abstract member predictor: float option with get, set
        abstract member index: float with get, set
        abstract member data: string with get, set
        abstract member fileType: Jspdf.ImageFormat with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type TextOptionsLight =
        abstract member align: TextOptionsLight.align option with get, set
        abstract member angle: U2<float, Jspdf.Matrix> option with get, set
        abstract member baseline: TextOptionsLight.baseline option with get, set
        abstract member flags: TextOptionsLight.flags option with get, set
        abstract member rotationDirection: TextOptionsLight.rotationDirection option with get, set
        abstract member charSpace: float option with get, set
        abstract member horizontalScale: float option with get, set
        abstract member lineHeightFactor: float option with get, set
        abstract member maxWidth: float option with get, set
        abstract member renderingMode: TextOptionsLight.renderingMode option with get, set
        abstract member isInputVisual: bool option with get, set
        abstract member isOutputVisual: bool option with get, set
        abstract member isInputRtl: bool option with get, set
        abstract member isOutputRtl: bool option with get, set
        abstract member isSymmetricSwapping: bool option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?align: TextOptionsLight.align, ?baseline: TextOptionsLight.baseline, ?flags: TextOptionsLight.flags, ?rotationDirection: TextOptionsLight.rotationDirection, ?charSpace: float, ?horizontalScale: float, ?lineHeightFactor: float, ?maxWidth: float, ?renderingMode: TextOptionsLight.renderingMode, ?isInputVisual: bool, ?isOutputVisual: bool, ?isInputRtl: bool, ?isOutputRtl: bool, ?isSymmetricSwapping: bool) : TextOptionsLight = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (angle: float, ?align: TextOptionsLight.align, ?baseline: TextOptionsLight.baseline, ?flags: TextOptionsLight.flags, ?rotationDirection: TextOptionsLight.rotationDirection, ?charSpace: float, ?horizontalScale: float, ?lineHeightFactor: float, ?maxWidth: float, ?renderingMode: TextOptionsLight.renderingMode, ?isInputVisual: bool, ?isOutputVisual: bool, ?isInputRtl: bool, ?isOutputRtl: bool, ?isSymmetricSwapping: bool) : TextOptionsLight = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (angle: Jspdf.Matrix, ?align: TextOptionsLight.align, ?baseline: TextOptionsLight.baseline, ?flags: TextOptionsLight.flags, ?rotationDirection: TextOptionsLight.rotationDirection, ?charSpace: float, ?horizontalScale: float, ?lineHeightFactor: float, ?maxWidth: float, ?renderingMode: TextOptionsLight.renderingMode, ?isInputVisual: bool, ?isOutputVisual: bool, ?isInputRtl: bool, ?isOutputRtl: bool, ?isSymmetricSwapping: bool) : TextOptionsLight = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type TextOptions =
        inherit Jspdf.TextOptionsLight
        abstract member text: U2<string, ResizeArray<string>> with get, set
        abstract member x: float with get, set
        abstract member y: float with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type TableRowData =
        abstract member row: float option with get, set
        abstract member data: ResizeArray<obj> option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type TableCellData =
        abstract member row: float option with get, set
        abstract member col: float option with get, set
        abstract member data: obj option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type TableConfig =
        abstract member printHeaders: bool option with get, set
        abstract member autoSize: bool option with get, set
        abstract member margins: TableConfig.margins option with get, set
        abstract member fontSize: float option with get, set
        abstract member padding: float option with get, set
        abstract member headerBackgroundColor: string option with get, set
        abstract member headerTextColor: string option with get, set
        abstract member rowStart: TableConfig.rowStart option with get, set
        abstract member cellStart: TableConfig.cellStart option with get, set
        abstract member css: TableConfig.css option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?printHeaders: bool, ?autoSize: bool, ?margins: TableConfig.margins, ?fontSize: float, ?padding: float, ?headerBackgroundColor: string, ?headerTextColor: string, ?rowStart: TableConfig.rowStart, ?cellStart: TableConfig.cellStart, ?css: TableConfig.css) : TableConfig = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type CellConfig =
        abstract member name: string with get, set
        abstract member prompt: string with get, set
        abstract member align: CellConfig.align with get, set
        abstract member padding: float with get, set
        abstract member width: float with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type EncryptionOptions =
        abstract member userPassword: string option with get, set
        abstract member ownerPassword: string option with get, set
        abstract member userPermissions: ResizeArray<EncryptionOptions.userPermissions.Item> option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?userPassword: string, ?ownerPassword: string, ?userPermissions: ResizeArray<EncryptionOptions.userPermissions.Item>) : EncryptionOptions = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type jsPDFOptions =
        abstract member orientation: jsPDFOptions.orientation option with get, set
        abstract member unit: jsPDFOptions.unit option with get, set
        abstract member format: U2<string, ResizeArray<float>> option with get, set
        abstract member compress: bool option with get, set
        abstract member precision: float option with get, set
        abstract member filters: ResizeArray<string> option with get, set
        abstract member userUnit: float option with get, set
        abstract member encryption: Jspdf.EncryptionOptions option with get, set
        abstract member putOnlyUsedFonts: bool option with get, set
        abstract member hotfixes: ResizeArray<string> option with get, set
        abstract member floatPrecision: jsPDFOptions.floatPrecision option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?orientation: jsPDFOptions.orientation, ?unit: jsPDFOptions.unit, ?compress: bool, ?precision: float, ?filters: ResizeArray<string>, ?userUnit: float, ?encryption: Jspdf.EncryptionOptions, ?putOnlyUsedFonts: bool, ?hotfixes: ResizeArray<string>, ?floatPrecision: jsPDFOptions.floatPrecision) : jsPDFOptions = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (format: string, ?orientation: jsPDFOptions.orientation, ?unit: jsPDFOptions.unit, ?compress: bool, ?precision: float, ?filters: ResizeArray<string>, ?userUnit: float, ?encryption: Jspdf.EncryptionOptions, ?putOnlyUsedFonts: bool, ?hotfixes: ResizeArray<string>, ?floatPrecision: jsPDFOptions.floatPrecision) : jsPDFOptions = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (format: ResizeArray<float>, ?orientation: jsPDFOptions.orientation, ?unit: jsPDFOptions.unit, ?compress: bool, ?precision: float, ?filters: ResizeArray<string>, ?userUnit: float, ?encryption: Jspdf.EncryptionOptions, ?putOnlyUsedFonts: bool, ?hotfixes: ResizeArray<string>, ?floatPrecision: jsPDFOptions.floatPrecision) : jsPDFOptions = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type Point =
        abstract member x: float with get, set
        abstract member y: float with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (x: float, y: float) : Point = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type Rectangle =
        inherit Jspdf.Point
        abstract member w: float with get, set
        abstract member h: float with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (x: float, y: float, w: float, h: float) : Rectangle = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type PageInfo =
        abstract member objId: float with get, set
        abstract member pageNumber: float with get, set
        abstract member pageContext: obj with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type Font =
        abstract member id: float with get, set
        abstract member encoding: string with get, set
        abstract member fontName: string with get, set
        abstract member fontStyle: string with get, set
        abstract member isStandardFont: bool with get, set
        abstract member metadata: obj with get, set
        abstract member objectNumber: float with get, set
        abstract member postScriptName: string with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type DocumentProperties =
        abstract member title: string option with get, set
        abstract member subject: string option with get, set
        abstract member author: string option with get, set
        abstract member keywords: string option with get, set
        abstract member creator: string option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?title: string, ?subject: string, ?author: string, ?keywords: string, ?creator: string) : DocumentProperties = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type PatternData =
        abstract member key: string with get, set
        abstract member matrix: Jspdf.Matrix option with get, set
        abstract member boundingBox: ResizeArray<float> option with get, set
        abstract member xStep: float option with get, set
        abstract member yStep: float option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (key: string, ?matrix: Jspdf.Matrix, ?boundingBox: ResizeArray<float>, ?xStep: float, ?yStep: float) : PatternData = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type RGBAData =
        abstract member data: JS.Uint8ClampedArray with get, set
        abstract member width: float with get, set
        abstract member height: float with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (data: JS.Uint8ClampedArray, width: float, height: float) : RGBAData = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type PubSub =
        abstract member subscribe<'A>: topic: string * callback: ('A -> unit) * ?once: bool -> string
        abstract member subscribe<'A, 'B>: topic: string * callback: ('A -> 'B -> unit) * ?once: bool -> string
        abstract member subscribe<'A, 'B, 'C>: topic: string * callback: ('A -> 'B -> 'C -> unit) * ?once: bool -> string
        abstract member subscribe: topic: string * callback: System.Delegate * ?once: bool -> string
        abstract member unsubscribe: token: string -> bool
        abstract member publish: topic: string * [<ParamArray>] args: obj [] -> unit
        abstract member getTopics: unit -> PubSub.getTopics

    [<AllowNullLiteral>]
    [<Interface>]
    type jsPDF =
        abstract member CapJoinStyles: obj with get, set
        abstract member version: string with get, set
        abstract member compatAPI: ?body: (Jspdf.jsPDF -> unit) -> unit
        abstract member advancedAPI: ?body: (Jspdf.jsPDF -> unit) -> unit
        abstract member isAdvancedAPI: unit -> bool
        abstract member addFont: postScriptName: string * id: string * fontStyle: string -> string
        abstract member addFont: postScriptName: string * id: string * fontStyle: string * fontWeight: string * ?encoding: jsPDF.addFont.encoding * ?isStandardFont: bool -> string
        abstract member addFont: postScriptName: string * id: string * fontStyle: string * fontWeight: float * ?encoding: jsPDF.addFont.encoding * ?isStandardFont: bool -> string
        abstract member addFont: url: Glutinum.Web.URL * id: string * fontStyle: string -> string
        abstract member addFont: url: Glutinum.Web.URL * id: string * fontStyle: string * fontWeight: string * ?encoding: jsPDF.addFont.encoding -> string
        abstract member addFont: url: Glutinum.Web.URL * id: string * fontStyle: string * fontWeight: float * ?encoding: jsPDF.addFont.encoding -> string
        abstract member addGState: key: string * gState: Jspdf.GState -> Jspdf.jsPDF
        abstract member addPage: unit -> Jspdf.jsPDF
        abstract member addPage: format: string * ?orientation: jsPDF.addPage.orientation -> Jspdf.jsPDF
        abstract member addPage: format: ResizeArray<float> * ?orientation: jsPDF.addPage.orientation -> Jspdf.jsPDF
        abstract member beginFormObject: x: float * y: float * width: float * height: float * matrix: obj -> Jspdf.jsPDF
        abstract member circle: x: float * y: float * r: float * ?style: string -> Jspdf.jsPDF
        [<Emit("$0.clip('evenodd')")>]
        abstract member clip_evenodd: unit -> Jspdf.jsPDF
        abstract member discardPath: unit -> Jspdf.jsPDF
        abstract member deletePage: targetPage: float -> Jspdf.jsPDF
        abstract member doFormObject: key: obj * matrix: obj -> Jspdf.jsPDF
        abstract member ellipse: x: float * y: float * rx: float * ry: float * ?style: string -> Jspdf.jsPDF
        abstract member endFormObject: key: obj -> Jspdf.jsPDF
        abstract member f2: number: float -> string
        abstract member f3: number: float -> string
        abstract member getCharSpace: unit -> float
        abstract member getCreationDate: ``type``: string -> Date
        abstract member getCurrentPageInfo: unit -> Jspdf.PageInfo
        abstract member getDrawColor: unit -> string
        abstract member getFileId: unit -> string
        abstract member getFillColor: unit -> string
        abstract member getFont: unit -> Jspdf.Font
        abstract member getFontList: unit -> jsPDF.getFontList
        abstract member getFontSize: unit -> float
        abstract member getFormObject: key: obj -> obj
        abstract member getLineHeight: unit -> float
        abstract member getLineHeightFactor: unit -> float
        abstract member getLineWidth: unit -> float
        abstract member getNumberOfPages: unit -> float
        abstract member getPageInfo: pageNumberOneBased: float -> Jspdf.PageInfo
        abstract member getR2L: unit -> bool
        abstract member getStyle: style: string -> string
        abstract member getTextColor: unit -> string
        abstract member insertPage: beforePage: float -> Jspdf.jsPDF
        abstract member line: x1: float * y1: float * x2: float * y2: float * ?style: string -> Jspdf.jsPDF
        abstract member lines: lines: ResizeArray<obj> * x: obj * y: obj * ?scale: obj * ?style: string * ?closed: bool -> Jspdf.jsPDF
        abstract member clipEvenOdd: unit -> Jspdf.jsPDF
        abstract member close: unit -> Jspdf.jsPDF
        abstract member stroke: unit -> Jspdf.jsPDF
        abstract member fill: ?pattern: Jspdf.PatternData -> Jspdf.jsPDF
        abstract member fillEvenOdd: ?pattern: Jspdf.PatternData -> Jspdf.jsPDF
        abstract member fillStroke: ?pattern: Jspdf.PatternData -> Jspdf.jsPDF
        abstract member fillStrokeEvenOdd: ?pattern: Jspdf.PatternData -> Jspdf.jsPDF
        abstract member moveTo: x: float * y: float -> Jspdf.jsPDF
        abstract member lineTo: x: float * y: float -> Jspdf.jsPDF
        abstract member curveTo: x1: float * y1: float * x2: float * y2: float * x3: float * y3: float -> Jspdf.jsPDF
        abstract member movePage: targetPage: float * beforePage: float -> Jspdf.jsPDF
        abstract member output: unit -> string
        [<Emit("$0.output('arraybuffer')")>]
        abstract member output_arraybuffer: unit -> obj
        [<Emit("$0.output('blob')")>]
        abstract member output_blob: unit -> Glutinum.Web.Blob
        abstract member output: ``type``: jsPDF.output.``type`` -> Glutinum.Web.URL
        abstract member output: ``type``: jsPDF.output.``type_1`` * ?options: jsPDF.output.options -> string
        abstract member output: ``type``: jsPDF.output.``type_2`` * ?options: jsPDF.output.options -> Glutinum.Web.Window
        abstract member output: ``type``: jsPDF.output.``type_3`` * ?options: jsPDF.output.options -> bool
        abstract member pdfEscape: text: string * flags: obj -> string
        abstract member path: ?lines: ResizeArray<obj> * ?style: string -> Jspdf.jsPDF
        abstract member rect: x: float * y: float * w: float * h: float * ?style: string -> Jspdf.jsPDF
        abstract member restoreGraphicsState: unit -> Jspdf.jsPDF
        abstract member roundedRect: x: float * y: float * w: float * h: float * rx: float * ry: float * ?style: string -> Jspdf.jsPDF
        abstract member save: filename: string * options: jsPDF.save.options -> JS.Promise<unit>
        abstract member save: ?filename: string -> Jspdf.jsPDF
        abstract member saveGraphicsState: unit -> Jspdf.jsPDF
        abstract member setCharSpace: charSpace: float -> Jspdf.jsPDF
        abstract member setCreationDate: unit -> Jspdf.jsPDF
        abstract member setCreationDate: date: Date -> Jspdf.jsPDF
        abstract member setCreationDate: date: string -> Jspdf.jsPDF
        abstract member setCurrentTransformationMatrix: matrix: Jspdf.Matrix -> Jspdf.jsPDF
        abstract member setDisplayMode: zoom: jsPDF.setDisplayMode.zoom * ?layout: jsPDF.setDisplayMode.layout * ?pmode: jsPDF.setDisplayMode.pmode -> Jspdf.jsPDF
        abstract member setDocumentProperties: properties: Jspdf.DocumentProperties -> Jspdf.jsPDF
        abstract member setProperties: properties: Jspdf.DocumentProperties -> Jspdf.jsPDF
        abstract member setDrawColor: ch1: string -> Jspdf.jsPDF
        abstract member setDrawColor: ch1: float -> Jspdf.jsPDF
        abstract member setDrawColor: ch1: float * ch2: float * ch3: float * ?ch4: float -> Jspdf.jsPDF
        abstract member setFileId: value: string -> Jspdf.jsPDF
        abstract member setFillColor: ch1: string -> Jspdf.jsPDF
        abstract member setFillColor: ch1: float * ch2: float * ch3: float * ?ch4: float -> Jspdf.jsPDF
        abstract member setFont: fontName: string * ?fontStyle: string * ?fontWeight: U2<string, float> -> Jspdf.jsPDF
        abstract member setFontSize: size: float -> Jspdf.jsPDF
        abstract member setGState: gState: obj -> Jspdf.jsPDF
        abstract member setLineCap: style: string -> Jspdf.jsPDF
        abstract member setLineCap: style: float -> Jspdf.jsPDF
        abstract member setLineCap: style: U2<string, float> -> Jspdf.jsPDF
        abstract member setLineDashPattern: dashArray: ResizeArray<float> * dashPhase: float -> Jspdf.jsPDF
        abstract member setLineHeightFactor: value: float -> Jspdf.jsPDF
        abstract member setLineJoin: style: string -> Jspdf.jsPDF
        abstract member setLineJoin: style: float -> Jspdf.jsPDF
        abstract member setLineJoin: style: U2<string, float> -> Jspdf.jsPDF
        abstract member setLineMiterLimit: length: float -> Jspdf.jsPDF
        abstract member setLineWidth: width: float -> Jspdf.jsPDF
        abstract member setPage: pageNumber: float -> Jspdf.jsPDF
        abstract member setR2L: value: bool -> Jspdf.jsPDF
        abstract member setTextColor: ch1: string -> Jspdf.jsPDF
        abstract member setTextColor: ch1: float -> Jspdf.jsPDF
        abstract member setTextColor: ch1: float * ch2: float * ch3: float * ?ch4: float -> Jspdf.jsPDF
        abstract member text: text: string * x: float * y: float * ?options: Jspdf.TextOptionsLight * ?transform: U2<float, obj> -> Jspdf.jsPDF
        abstract member text: text: ResizeArray<string> * x: float * y: float * ?options: Jspdf.TextOptionsLight * ?transform: U2<float, obj> -> Jspdf.jsPDF
        abstract member text: text: U2<string, ResizeArray<string>> * x: float * y: float * ?options: Jspdf.TextOptionsLight * ?transform: U2<float, obj> -> Jspdf.jsPDF
        abstract member triangle: x1: float * y1: float * x2: float * y2: float * x3: float * y3: float * ?style: string -> Jspdf.jsPDF
        abstract member getHorizontalCoordinateString: value: float -> float
        abstract member getVerticalCoordinateString: value: float -> float
        abstract member ``internal``: jsPDF.``internal`` with get, set
        /// <summary>
        /// jsPDF plugins below:
        ///
        ///  - AcroForm
        ///  - AddImage
        ///  - Annotations
        ///  - AutoPrint
        ///  - Canvas
        ///  - Cell
        ///  - Context2D
        ///  - fileloading
        ///  - html
        ///  - JavaScript
        ///  - split_text_to_size
        ///  - SVG
        ///  - total_pages
        ///  - utf8
        ///  - vfs
        ///  - xmp_metadata
        /// </summary>
        abstract member addImage: imageData: string * format: string * x: float * y: float * w: float * h: float * ?alias: string * ?compression: Jspdf.ImageCompression * ?rotation: float -> Jspdf.jsPDF
        /// <summary>
        /// jsPDF plugins below:
        ///
        ///  - AcroForm
        ///  - AddImage
        ///  - Annotations
        ///  - AutoPrint
        ///  - Canvas
        ///  - Cell
        ///  - Context2D
        ///  - fileloading
        ///  - html
        ///  - JavaScript
        ///  - split_text_to_size
        ///  - SVG
        ///  - total_pages
        ///  - utf8
        ///  - vfs
        ///  - xmp_metadata
        /// </summary>
        abstract member addImage: imageData: Glutinum.Web.HTMLImageElement * format: string * x: float * y: float * w: float * h: float * ?alias: string * ?compression: Jspdf.ImageCompression * ?rotation: float -> Jspdf.jsPDF
        /// <summary>
        /// jsPDF plugins below:
        ///
        ///  - AcroForm
        ///  - AddImage
        ///  - Annotations
        ///  - AutoPrint
        ///  - Canvas
        ///  - Cell
        ///  - Context2D
        ///  - fileloading
        ///  - html
        ///  - JavaScript
        ///  - split_text_to_size
        ///  - SVG
        ///  - total_pages
        ///  - utf8
        ///  - vfs
        ///  - xmp_metadata
        /// </summary>
        abstract member addImage: imageData: Glutinum.Web.HTMLCanvasElement * format: string * x: float * y: float * w: float * h: float * ?alias: string * ?compression: Jspdf.ImageCompression * ?rotation: float -> Jspdf.jsPDF
        /// <summary>
        /// jsPDF plugins below:
        ///
        ///  - AcroForm
        ///  - AddImage
        ///  - Annotations
        ///  - AutoPrint
        ///  - Canvas
        ///  - Cell
        ///  - Context2D
        ///  - fileloading
        ///  - html
        ///  - JavaScript
        ///  - split_text_to_size
        ///  - SVG
        ///  - total_pages
        ///  - utf8
        ///  - vfs
        ///  - xmp_metadata
        /// </summary>
        abstract member addImage: imageData: JS.Uint8Array * format: string * x: float * y: float * w: float * h: float * ?alias: string * ?compression: Jspdf.ImageCompression * ?rotation: float -> Jspdf.jsPDF
        /// <summary>
        /// jsPDF plugins below:
        ///
        ///  - AcroForm
        ///  - AddImage
        ///  - Annotations
        ///  - AutoPrint
        ///  - Canvas
        ///  - Cell
        ///  - Context2D
        ///  - fileloading
        ///  - html
        ///  - JavaScript
        ///  - split_text_to_size
        ///  - SVG
        ///  - total_pages
        ///  - utf8
        ///  - vfs
        ///  - xmp_metadata
        /// </summary>
        abstract member addImage: imageData: Jspdf.RGBAData * format: string * x: float * y: float * w: float * h: float * ?alias: string * ?compression: Jspdf.ImageCompression * ?rotation: float -> Jspdf.jsPDF
        /// <summary>
        /// jsPDF plugins below:
        ///
        ///  - AcroForm
        ///  - AddImage
        ///  - Annotations
        ///  - AutoPrint
        ///  - Canvas
        ///  - Cell
        ///  - Context2D
        ///  - fileloading
        ///  - html
        ///  - JavaScript
        ///  - split_text_to_size
        ///  - SVG
        ///  - total_pages
        ///  - utf8
        ///  - vfs
        ///  - xmp_metadata
        /// </summary>
        abstract member addImage: imageData: U5<string, Glutinum.Web.HTMLImageElement, Glutinum.Web.HTMLCanvasElement, JS.Uint8Array, Jspdf.RGBAData> * format: string * x: float * y: float * w: float * h: float * ?alias: string * ?compression: Jspdf.ImageCompression * ?rotation: float -> Jspdf.jsPDF
        /// <summary>
        /// jsPDF plugins below:
        ///
        ///  - AcroForm
        ///  - AddImage
        ///  - Annotations
        ///  - AutoPrint
        ///  - Canvas
        ///  - Cell
        ///  - Context2D
        ///  - fileloading
        ///  - html
        ///  - JavaScript
        ///  - split_text_to_size
        ///  - SVG
        ///  - total_pages
        ///  - utf8
        ///  - vfs
        ///  - xmp_metadata
        /// </summary>
        abstract member addImage: imageData: string * x: float * y: float * w: float * h: float * ?alias: string * ?compression: Jspdf.ImageCompression * ?rotation: float -> Jspdf.jsPDF
        /// <summary>
        /// jsPDF plugins below:
        ///
        ///  - AcroForm
        ///  - AddImage
        ///  - Annotations
        ///  - AutoPrint
        ///  - Canvas
        ///  - Cell
        ///  - Context2D
        ///  - fileloading
        ///  - html
        ///  - JavaScript
        ///  - split_text_to_size
        ///  - SVG
        ///  - total_pages
        ///  - utf8
        ///  - vfs
        ///  - xmp_metadata
        /// </summary>
        abstract member addImage: imageData: Glutinum.Web.HTMLImageElement * x: float * y: float * w: float * h: float * ?alias: string * ?compression: Jspdf.ImageCompression * ?rotation: float -> Jspdf.jsPDF
        /// <summary>
        /// jsPDF plugins below:
        ///
        ///  - AcroForm
        ///  - AddImage
        ///  - Annotations
        ///  - AutoPrint
        ///  - Canvas
        ///  - Cell
        ///  - Context2D
        ///  - fileloading
        ///  - html
        ///  - JavaScript
        ///  - split_text_to_size
        ///  - SVG
        ///  - total_pages
        ///  - utf8
        ///  - vfs
        ///  - xmp_metadata
        /// </summary>
        abstract member addImage: imageData: Glutinum.Web.HTMLCanvasElement * x: float * y: float * w: float * h: float * ?alias: string * ?compression: Jspdf.ImageCompression * ?rotation: float -> Jspdf.jsPDF
        /// <summary>
        /// jsPDF plugins below:
        ///
        ///  - AcroForm
        ///  - AddImage
        ///  - Annotations
        ///  - AutoPrint
        ///  - Canvas
        ///  - Cell
        ///  - Context2D
        ///  - fileloading
        ///  - html
        ///  - JavaScript
        ///  - split_text_to_size
        ///  - SVG
        ///  - total_pages
        ///  - utf8
        ///  - vfs
        ///  - xmp_metadata
        /// </summary>
        abstract member addImage: imageData: JS.Uint8Array * x: float * y: float * w: float * h: float * ?alias: string * ?compression: Jspdf.ImageCompression * ?rotation: float -> Jspdf.jsPDF
        /// <summary>
        /// jsPDF plugins below:
        ///
        ///  - AcroForm
        ///  - AddImage
        ///  - Annotations
        ///  - AutoPrint
        ///  - Canvas
        ///  - Cell
        ///  - Context2D
        ///  - fileloading
        ///  - html
        ///  - JavaScript
        ///  - split_text_to_size
        ///  - SVG
        ///  - total_pages
        ///  - utf8
        ///  - vfs
        ///  - xmp_metadata
        /// </summary>
        abstract member addImage: imageData: Jspdf.RGBAData * x: float * y: float * w: float * h: float * ?alias: string * ?compression: Jspdf.ImageCompression * ?rotation: float -> Jspdf.jsPDF
        /// <summary>
        /// jsPDF plugins below:
        ///
        ///  - AcroForm
        ///  - AddImage
        ///  - Annotations
        ///  - AutoPrint
        ///  - Canvas
        ///  - Cell
        ///  - Context2D
        ///  - fileloading
        ///  - html
        ///  - JavaScript
        ///  - split_text_to_size
        ///  - SVG
        ///  - total_pages
        ///  - utf8
        ///  - vfs
        ///  - xmp_metadata
        /// </summary>
        abstract member addImage: imageData: U5<string, Glutinum.Web.HTMLImageElement, Glutinum.Web.HTMLCanvasElement, JS.Uint8Array, Jspdf.RGBAData> * x: float * y: float * w: float * h: float * ?alias: string * ?compression: Jspdf.ImageCompression * ?rotation: float -> Jspdf.jsPDF
        /// <summary>
        /// jsPDF plugins below:
        ///
        ///  - AcroForm
        ///  - AddImage
        ///  - Annotations
        ///  - AutoPrint
        ///  - Canvas
        ///  - Cell
        ///  - Context2D
        ///  - fileloading
        ///  - html
        ///  - JavaScript
        ///  - split_text_to_size
        ///  - SVG
        ///  - total_pages
        ///  - utf8
        ///  - vfs
        ///  - xmp_metadata
        /// </summary>
        abstract member addImage: options: Jspdf.ImageOptions -> Jspdf.jsPDF
        abstract member getImageProperties: imageData: string -> Jspdf.ImageProperties
        abstract member getImageProperties: imageData: Glutinum.Web.HTMLImageElement -> Jspdf.ImageProperties
        abstract member getImageProperties: imageData: Glutinum.Web.HTMLCanvasElement -> Jspdf.ImageProperties
        abstract member getImageProperties: imageData: JS.Uint8Array -> Jspdf.ImageProperties
        abstract member getImageProperties: imageData: U4<string, Glutinum.Web.HTMLImageElement, Glutinum.Web.HTMLCanvasElement, JS.Uint8Array> -> Jspdf.ImageProperties
        abstract member processArabic: text: string -> string
        abstract member createAnnotation: options: Jspdf.Annotation -> unit
        abstract member link: x: float * y: float * w: float * h: float * options: obj -> unit
        abstract member textWithLink: text: string * x: float * y: float * options: obj -> float
        abstract member getTextWidth: text: string -> float
        abstract member autoPrint: ?options: Jspdf.AutoPrintInput -> Jspdf.jsPDF
        abstract member addField: field: Jspdf.AcroFormField -> Jspdf.jsPDF
        abstract member AcroForm: jsPDF.AcroForm with get, set
        abstract member canvas: jsPDF.canvas with get, set
        abstract member setHeaderFunction: func: jsPDF.setHeaderFunction.func -> Jspdf.jsPDF
        abstract member getTextDimensions: text: string * ?options: jsPDF.getTextDimensions.options -> jsPDF.getTextDimensions
        abstract member cellAddPage: unit -> Jspdf.jsPDF
        abstract member cell: x: float * y: float * w: float * h: float * txt: string * ln: float * align: string -> Jspdf.jsPDF
        abstract member table: x: float * y: float * data: ResizeArray<jsPDF.table.data.Item> * headers: ResizeArray<string> * config: Jspdf.TableConfig -> Jspdf.jsPDF
        abstract member table: x: float * y: float * data: ResizeArray<jsPDF.table.data.Item> * headers: ResizeArray<Jspdf.CellConfig> * config: Jspdf.TableConfig -> Jspdf.jsPDF
        abstract member table: x: float * y: float * data: ResizeArray<jsPDF.table.data.Item> * headers: U2<ResizeArray<string>, ResizeArray<Jspdf.CellConfig>> * config: Jspdf.TableConfig -> Jspdf.jsPDF
        abstract member calculateLineHeight: headerNames: ResizeArray<string> * columnWidths: ResizeArray<float> * model: ResizeArray<obj> -> float
        abstract member setTableHeaderRow: config: ResizeArray<Jspdf.CellConfig> -> unit
        abstract member printHeaderRow: lineNumber: float * ?new_page: bool -> unit
        abstract member context2d: Jspdf.Context2d with get, set
        abstract member outline: Jspdf.Outline with get, set
        abstract member loadFile: url: string * ?sync: bool -> string
        abstract member loadFile: url: string * sync: bool * callback: (string -> string) -> unit
        abstract member allowFsRead: ResizeArray<string> option with get, set
        abstract member html: src: string * ?options: Jspdf.HTMLOptions -> Jspdf.HTMLWorker
        abstract member html: src: Glutinum.Web.HTMLElement * ?options: Jspdf.HTMLOptions -> Jspdf.HTMLWorker
        abstract member html: src: U2<string, Glutinum.Web.HTMLElement> * ?options: Jspdf.HTMLOptions -> Jspdf.HTMLWorker
        abstract member addJS: javascript: string -> Jspdf.jsPDF
        abstract member getCharWidthsArray: text: string * ?options: obj -> ResizeArray<obj>
        abstract member getStringUnitWidth: text: string * ?options: obj -> float
        abstract member splitTextToSize: text: string * maxlen: float * ?options: obj -> obj
        abstract member addSvgAsImage: svg: string * x: float * y: float * w: float * h: float * ?alias: string * ?compression: bool * ?rotation: float -> Jspdf.jsPDF
        abstract member setLanguage: langCode: jsPDF.setLanguage.langCode -> Jspdf.jsPDF
        abstract member putTotalPages: pageExpression: string -> Jspdf.jsPDF
        abstract member viewerPreferences: options: Jspdf.ViewerPreferencesInput * ?doReset: bool -> Jspdf.jsPDF
        [<Emit("$0.viewerPreferences('reset')")>]
        abstract member viewerPreferences_reset: unit -> Jspdf.jsPDF
        abstract member existsFileInVFS: filename: string -> bool
        abstract member addFileToVFS: filename: string * filecontent: string -> Jspdf.jsPDF
        abstract member getFileFromVFS: filename: string -> string
        /// <summary>
        /// WARNING: Passing raw XML is potentially insecure! Always sanitize user input before passing it to this function!
        /// </summary>
        abstract member addMetadata: metadata: string * ?namespaceUri: string -> Jspdf.jsPDF
        /// <summary>
        /// WARNING: Passing raw XML is potentially insecure! Always sanitize user input before passing it to this function!
        /// </summary>
        abstract member addMetadata: metadata: string * rawXml: bool -> Jspdf.jsPDF
        abstract member Matrix: a: float * b: float * c: float * d: float * e: float * f: float -> Jspdf.Matrix
        abstract member matrixMult: m1: Jspdf.Matrix * m2: Jspdf.Matrix -> Jspdf.Matrix
        abstract member unitMatrix: Jspdf.Matrix with get, set
        abstract member GState: parameters: Jspdf.GState -> Jspdf.GState
        abstract member ShadingPattern: ``type``: Jspdf.ShadingPatternType * coords: ResizeArray<float> * colors: ResizeArray<Jspdf.ShadingPatterStop> * ?gState: Jspdf.GState * ?matrix: Jspdf.Matrix -> Jspdf.ShadingPattern
        abstract member TilingPattern: boundingBox: ResizeArray<float> * xStep: float * yStep: float * ?gState: Jspdf.GState * ?matrix: Jspdf.Matrix -> Jspdf.TilingPattern
        abstract member addShadingPattern: key: string * pattern: Jspdf.ShadingPattern -> Jspdf.jsPDF
        abstract member beginTilingPattern: pattern: Jspdf.TilingPattern -> unit
        abstract member endTilingPattern: key: string * pattern: Jspdf.TilingPattern -> unit
        [<Emit("""import { jsPDF } from "jspdf";
jsPDF.API{{=$0}}""")>]
        static member inline API
            with get () : Jspdf.jsPDFAPI =
                nativeOnly
            and set (value: Jspdf.jsPDFAPI) =
                nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type GState =
        abstract member opacity: float option with get, set
        abstract member ``stroke-opacity``: float option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?opacity: float, ?``stroke-opacity``: float) : GState = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type Matrix =
        abstract member a: float with get, set
        abstract member b: float with get, set
        abstract member c: float with get, set
        abstract member d: float with get, set
        abstract member e: float with get, set
        abstract member f: float with get, set
        abstract member sx: float with get, set
        abstract member shy: float with get, set
        abstract member shx: float with get, set
        abstract member sy: float with get, set
        abstract member tx: float with get, set
        abstract member ty: float with get, set
        abstract member join: ?separator: string -> string
        abstract member multiply: matrix: Jspdf.Matrix -> Jspdf.Matrix
        abstract member decompose: unit -> Matrix.decompose
        abstract member toString: unit -> string
        abstract member inversed: unit -> Jspdf.Matrix
        abstract member applyToPoint: point: Jspdf.Point -> Jspdf.Point
        abstract member applyToRectangle: rect: Jspdf.Rectangle -> Jspdf.Rectangle
        abstract member clone: unit -> Jspdf.Matrix

    [<AllowNullLiteral>]
    [<Interface>]
    type Pattern =
        abstract member gState: Jspdf.GState option with get, set
        abstract member matrix: Jspdf.Matrix option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type ShadingPatterStop =
        abstract member offset: float with get, set
        abstract member color: ResizeArray<float> with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (offset: float, color: ResizeArray<float>) : ShadingPatterStop = nativeOnly

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type ShadingPatternType =
        | axial
        | radial

    [<AllowNullLiteral>]
    [<Interface>]
    type ShadingPattern =
        inherit Jspdf.Pattern
        abstract member coords: ResizeArray<float> with get, set
        abstract member colors: ResizeArray<Jspdf.ShadingPatterStop> with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (coords: ResizeArray<float>, colors: ResizeArray<Jspdf.ShadingPatterStop>, ?gState: Jspdf.GState, ?matrix: Jspdf.Matrix) : ShadingPattern = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type TilingPattern =
        inherit Jspdf.Pattern
        abstract member boundingBox: ResizeArray<float> with get, set
        abstract member xStep: float with get, set
        abstract member yStep: float with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (boundingBox: ResizeArray<float>, xStep: float, yStep: float, ?gState: Jspdf.GState, ?matrix: Jspdf.Matrix) : TilingPattern = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type jsPDFAPI =
        abstract member events: ResizeArray<obj> with get, set

    module Annotation =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type ``type`` =
            | text
            | freetext
            | link

        [<AllowNullLiteral>]
        [<Interface>]
        type bounds =
            abstract member x: float with get, set
            abstract member y: float with get, set
            abstract member w: float with get, set
            abstract member h: float with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (x: float, y: float, w: float, h: float) : bounds = nativeOnly

    module TextWithLinkOptions =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type magFactor =
            | Fit
            | FitH
            | FitV
            | XYZ

    module AutoPrintInput =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type variant =
            | ``non-conform``
            | javascript

    module Html2CanvasOptions =

        [<AllowNullLiteral>]
        [<Interface>]
        type onclone =
            [<Emit("$0($1...)")>]
            abstract member Invoke: doc: Glutinum.Web.HTMLDocument -> unit

    module HTMLWorker =

        [<AllowNullLiteral>]
        [<Interface>]
        type outputPdf =
            [<Emit("$0($1...)")>]
            abstract member Invoke: unit -> string
            [<Emit("$0($1...)")>]
            abstract member Invoke: ``type``: string -> obj
            [<Emit("$0($1...)")>]
            abstract member Invoke: ``type``: HTMLWorker.outputPdf.Invoke.``type`` -> Glutinum.Web.URL
            [<Emit("$0($1...)")>]
            abstract member Invoke: ``type``: HTMLWorker.outputPdf.Invoke.``type_1`` * ?options: HTMLWorker.outputPdf.Invoke.options -> string
            [<Emit("$0($1...)")>]
            abstract member Invoke: ``type``: HTMLWorker.outputPdf.Invoke.``type_2`` * ?options: HTMLWorker.outputPdf.Invoke.options -> Glutinum.Web.Window
            [<Emit("$0($1...)")>]
            abstract member Invoke: ``type``: HTMLWorker.outputPdf.Invoke.``type_3`` * ?options: HTMLWorker.outputPdf.Invoke.options -> bool

        module from =

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type`` =
                | container
                | canvas
                | img
                | pdf
                | context2d

        module outputImg =

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type`` =
                | img
                | datauristring
                | dataurlstring
                | datauri
                | dataurl

        module outputPdf =

            module Invoke =

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type ``type`` =
                    | bloburi
                    | bloburl

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type ``type_1`` =
                    | datauristring
                    | dataurlstring

                [<AllowNullLiteral>]
                [<Interface>]
                type options =
                    abstract member filename: string option with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (?filename: string) : options = nativeOnly

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type ``type_2`` =
                    | pdfobjectnewwindow
                    | pdfjsnewwindow
                    | dataurlnewwindow

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type ``type_3`` =
                    | dataurl
                    | datauri

    module HTMLOptionImage =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type ``type`` =
            | jpeg
            | png
            | webp

    module HTMLFontFace =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type style =
            | italic
            | oblique
            | normal

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type stretch =
            | ``ultra-condensed``
            | ``extra-condensed``
            | condensed
            | ``semi-condensed``
            | normal
            | ``semi-expanded``
            | expanded
            | ``extra-expanded``
            | ``ultra-expanded``

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type weight =
            | normal
            | bold
            | [<CompiledValue(100)>] ``100``
            | [<CompiledValue(200)>] ``200``
            | [<CompiledValue(300)>] ``300``
            | [<CompiledValue(400)>] ``400``
            | [<CompiledValue(500)>] ``500``
            | [<CompiledValue(600)>] ``600``
            | [<CompiledValue(700)>] ``700``
            | [<CompiledValue(800)>] ``800``
            | [<CompiledValue(900)>] ``900``
            | [<CompiledName("100")>] ``100_1``
            | [<CompiledName("200")>] ``200_1``
            | [<CompiledName("300")>] ``300_1``
            | [<CompiledName("400")>] ``400_1``
            | [<CompiledName("500")>] ``500_1``
            | [<CompiledName("600")>] ``600_1``
            | [<CompiledName("700")>] ``700_1``
            | [<CompiledName("800")>] ``800_1``
            | [<CompiledName("900")>] ``900_1``

        [<AllowNullLiteral>]
        [<Interface>]
        type src =
            abstract member url: string with get, set
            abstract member format: string with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (url: string, format: string) : src = nativeOnly

    module HTMLOptions =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type autoPaging =
            | [<CompiledValue(true)>] True
            | [<CompiledValue(false)>] False
            | slice
            | text

    module ViewerPreferencesInput =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type NonFullScreenPageMode =
            | UseNone
            | UseOutlines
            | UseThumbs
            | UseOC

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type Direction =
            | L2R
            | R2L

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type ViewArea =
            | MediaBox
            | CropBox
            | TrimBox
            | BleedBox
            | ArtBox

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type ViewClip =
            | MediaBox
            | CropBox
            | TrimBox
            | BleedBox
            | ArtBox

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type PrintArea =
            | MediaBox
            | CropBox
            | TrimBox
            | BleedBox
            | ArtBox

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type PrintClip =
            | MediaBox
            | CropBox
            | TrimBox
            | BleedBox
            | ArtBox

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type PrintScaling =
            | AppDefault
            | None

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type Duplex =
            | Simplex
            | DuplexFlipShortEdge
            | DuplexFlipLongEdge
            | none

    module AcroFormField =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type textAlign =
            | left
            | center
            | right

    module AcroFormChildClass =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type appearanceState =
            | On
            | Off

    module AcroFormCheckBox =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type appearanceState =
            | On
            | Off

    module Context2d =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type imageSmoothingQuality =
            | low
            | high

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type lineCap =
            | butt
            | round
            | square

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type lineJoin =
            | bevel
            | round
            | miter

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type textAlign =
            | right
            | ``end``
            | center
            | left
            | start

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type textBaseline =
            | alphabetic
            | bottom
            | top
            | hanging
            | middle
            | ideographic

    module TextOptionsLight =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type align =
            | left
            | center
            | right
            | justify

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type baseline =
            | alphabetic
            | ideographic
            | bottom
            | top
            | middle
            | hanging

        [<AllowNullLiteral>]
        [<Interface>]
        type flags =
            abstract member noBOM: bool with get, set
            abstract member autoencode: bool with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (noBOM: bool, autoencode: bool) : flags = nativeOnly

        [<RequireQualifiedAccess>]
        type rotationDirection =
            | ``0`` = 0
            | ``1`` = 1

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type renderingMode =
            | fill
            | stroke
            | fillThenStroke
            | invisible
            | fillAndAddForClipping
            | strokeAndAddPathForClipping
            | fillThenStrokeAndAddToPathForClipping
            | addToPathForClipping

    module TableConfig =

        [<AllowNullLiteral>]
        [<Interface>]
        type margins =
            abstract member top: float with get, set
            abstract member bottom: float with get, set
            abstract member left: float with get, set
            abstract member width: float with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (top: float, bottom: float, left: float, width: float) : margins = nativeOnly

        type rowStart =
            delegate of e: Jspdf.TableRowData * doc: Jspdf.jsPDF -> unit

        type cellStart =
            delegate of e: Jspdf.TableCellData * doc: Jspdf.jsPDF -> unit

        [<AllowNullLiteral>]
        [<Interface>]
        type css =
            abstract member ``font-size``: float with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (``font-size``: float) : css = nativeOnly

    module CellConfig =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type align =
            | left
            | center
            | right

    module EncryptionOptions =

        module userPermissions =

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type Item =
                | print
                | modify
                | copy
                | ``annot-forms``

    module jsPDFOptions =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type orientation =
            | p
            | portrait
            | l
            | landscape

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type unit =
            | pt
            | px
            | ``in``
            | mm
            | cm
            | ex
            | em
            | pc

        [<RequireQualifiedAccess>]
        [<Erase(CaseRules.None)>]
        type floatPrecision =
            | smart
            | Case1 of float

            [<Emit("$0")>]
            static member op_Implicit(value: float) : floatPrecision = nativeOnly

            [<Emit("$0")>]
            static member op_ErasedCast(value: float) : floatPrecision = nativeOnly

    module PubSub =

        [<AllowNullLiteral>]
        [<Interface>]
        type getTopics =
            [<EmitIndexer>]
            abstract member Item: key: string -> PubSub.getTopics.getTopics with get, set

        module getTopics =

            [<AllowNullLiteral>]
            [<Interface>]
            type getTopics =
                [<EmitIndexer>]
                abstract member Item: key: string -> System.Delegate * bool with get, set

    module jsPDF =

        [<AllowNullLiteral>]
        [<Interface>]
        type getFontList =
            [<EmitIndexer>]
            abstract member Item: key: string -> ResizeArray<string> with get, set

        [<AllowNullLiteral>]
        [<Interface>]
        type ``internal`` =
            abstract member events: Jspdf.PubSub with get, set
            abstract member scaleFactor: float with get, set
            abstract member pageSize: jsPDF.``internal``.pageSize with get, set
            abstract member pages: ResizeArray<float> with get, set
            abstract member getEncryptor: objectId: float -> (string -> string)
            [<ParamObject; Emit("$0")>]
            static member Create (events: Jspdf.PubSub, scaleFactor: float, pageSize: jsPDF.``internal``.pageSize, pages: ResizeArray<float>, getEncryptor: (float -> (string -> string))) : ``internal`` = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type AcroForm =
            abstract member ChoiceField: unit -> Jspdf.AcroFormChoiceField
            abstract member ListBox: unit -> Jspdf.AcroFormListBox
            abstract member ComboBox: unit -> Jspdf.AcroFormComboBox
            abstract member EditBox: unit -> Jspdf.AcroFormEditBox
            abstract member Button: unit -> Jspdf.AcroFormButton
            abstract member PushButton: unit -> Jspdf.AcroFormPushButton
            abstract member RadioButton: unit -> Jspdf.AcroFormRadioButton
            abstract member CheckBox: unit -> Jspdf.AcroFormCheckBox
            abstract member TextField: unit -> Jspdf.AcroFormTextField
            abstract member PasswordField: unit -> Jspdf.AcroFormPasswordField
            abstract member Appearance: unit -> obj
            [<ParamObject; Emit("$0")>]
            static member Create (ChoiceField: (unit -> Jspdf.AcroFormChoiceField), ListBox: (unit -> Jspdf.AcroFormListBox), ComboBox: (unit -> Jspdf.AcroFormComboBox), EditBox: (unit -> Jspdf.AcroFormEditBox), Button: (unit -> Jspdf.AcroFormButton), PushButton: (unit -> Jspdf.AcroFormPushButton), RadioButton: (unit -> Jspdf.AcroFormRadioButton), CheckBox: (unit -> Jspdf.AcroFormCheckBox), TextField: (unit -> Jspdf.AcroFormTextField), PasswordField: (unit -> Jspdf.AcroFormPasswordField), Appearance: (unit -> unit)) : AcroForm = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type canvas =
            abstract member pdf: Jspdf.jsPDF with get, set
            abstract member width: float with get, set
            abstract member height: float with get, set
            abstract member getContext: ?``type``: string -> Jspdf.Context2d
            abstract member style: obj with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (pdf: Jspdf.jsPDF, width: float, height: float, getContext: (string option -> Jspdf.Context2d), style: obj) : canvas = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type getTextDimensions =
            abstract member w: float with get, set
            abstract member h: float with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (w: float, h: float) : getTextDimensions = nativeOnly

        module addFont =

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type encoding =
                | StandardEncoding
                | MacRomanEncoding
                | ``Identity-H``
                | WinAnsiEncoding

        module addPage =

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type orientation =
                | p
                | portrait
                | l
                | landscape

        module output =

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type`` =
                | bloburi
                | bloburl

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_1`` =
                | datauristring
                | dataurlstring

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member filename: string option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?filename: string) : options = nativeOnly

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_2`` =
                | pdfobjectnewwindow
                | pdfjsnewwindow
                | dataurlnewwindow

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type_3`` =
                | dataurl
                | datauri

        module save =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member returnPromise: bool with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (returnPromise: bool) : options = nativeOnly

        module setDisplayMode =

            [<RequireQualifiedAccess>]
            [<Erase(CaseRules.None)>]
            type zoom =
                | fullheight
                | fullwidth
                | fullpage
                | original
                | Case1 of float
                | Case2 of string

                [<Emit("$0")>]
                static member op_Implicit(value: float) : zoom = nativeOnly

                [<Emit("$0")>]
                static member op_ErasedCast(value: float) : zoom = nativeOnly

                [<Emit("$0")>]
                static member op_Implicit(value: string) : zoom = nativeOnly

                [<Emit("$0")>]
                static member op_ErasedCast(value: string) : zoom = nativeOnly

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type layout =
                | continuous
                | single
                | twoleft
                | tworight
                | two

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type pmode =
                | UseOutlines
                | UseThumbs
                | FullScreen

        module ``internal`` =

            [<AllowNullLiteral>]
            [<Interface>]
            type pageSize =
                abstract member width: float with get, set
                abstract member getWidth: (unit -> float) with get, set
                abstract member height: float with get, set
                abstract member getHeight: (unit -> float) with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (width: float, getWidth: (unit -> float), height: float, getHeight: (unit -> float)) : pageSize = nativeOnly

        module setHeaderFunction =

            type func =
                delegate of jsPDFInstance: Jspdf.jsPDF * pages: float -> ResizeArray<float>

        module getTextDimensions =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member font: string option with get, set
                abstract member fontSize: float option with get, set
                abstract member maxWidth: float option with get, set
                abstract member scaleFactor: float option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?font: string, ?fontSize: float, ?maxWidth: float, ?scaleFactor: float) : options = nativeOnly

        module table =

            module data =

                [<AllowNullLiteral>]
                [<Interface>]
                type Item =
                    [<EmitIndexer>]
                    abstract member Item: key: string -> string with get, set

        module setLanguage =

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type langCode =
                | af
                | sq
                | ar
                | ``ar-DZ``
                | ``ar-BH``
                | ``ar-EG``
                | ``ar-IQ``
                | ``ar-JO``
                | ``ar-KW``
                | ``ar-LB``
                | ``ar-LY``
                | ``ar-MA``
                | ``ar-OM``
                | ``ar-QA``
                | ``ar-SA``
                | ``ar-SY``
                | ``ar-TN``
                | ``ar-AE``
                | ``ar-YE``
                | an
                | hy
                | ``as``
                | ast
                | az
                | eu
                | be
                | bn
                | bs
                | br
                | bg
                | my
                | ca
                | ch
                | ce
                | zh
                | ``zh-HK``
                | ``zh-CN``
                | ``zh-SG``
                | ``zh-TW``
                | cv
                | co
                | cr
                | hr
                | cs
                | da
                | nl
                | ``nl-BE``
                | en
                | ``en-AU``
                | ``en-BZ``
                | ``en-CA``
                | ``en-IE``
                | ``en-JM``
                | ``en-NZ``
                | ``en-PH``
                | ``en-ZA``
                | ``en-TT``
                | ``en-GB``
                | ``en-US``
                | ``en-ZW``
                | eo
                | et
                | fo
                | fj
                | fi
                | fr
                | ``fr-BE``
                | ``fr-CA``
                | ``fr-FR``
                | ``fr-LU``
                | ``fr-MC``
                | ``fr-CH``
                | fy
                | fur
                | gd
                | ``gd-IE``
                | gl
                | ka
                | de
                | ``de-AT``
                | ``de-DE``
                | ``de-LI``
                | ``de-LU``
                | ``de-CH``
                | el
                | gu
                | ht
                | he
                | hi
                | hu
                | is
                | id
                | iu
                | ga
                | it
                | ``it-CH``
                | ja
                | kn
                | ks
                | kk
                | km
                | ky
                | tlh
                | ko
                | ``ko-KP``
                | ``ko-KR``
                | la
                | lv
                | lt
                | lb
                | mk
                | ms
                | ml
                | mt
                | mi
                | mr
                | mo
                | nv
                | ng
                | ne
                | no
                | nb
                | nn
                | oc
                | ``or``
                | om
                | fa
                | ``fa-IR``
                | pl
                | pt
                | ``pt-BR``
                | pa
                | ``pa-IN``
                | ``pa-PK``
                | qu
                | rm
                | ro
                | ``ro-MO``
                | ru
                | ``ru-MO``
                | sz
                | sg
                | sa
                | sc
                | sd
                | si
                | sr
                | sk
                | sl
                | so
                | sb
                | es
                | ``es-AR``
                | ``es-BO``
                | ``es-CL``
                | ``es-CO``
                | ``es-CR``
                | ``es-DO``
                | ``es-EC``
                | ``es-SV``
                | ``es-GT``
                | ``es-HN``
                | ``es-MX``
                | ``es-NI``
                | ``es-PA``
                | ``es-PY``
                | ``es-PE``
                | ``es-PR``
                | ``es-ES``
                | ``es-UY``
                | ``es-VE``
                | sx
                | sw
                | sv
                | ``sv-FI``
                | ``sv-SV``
                | ta
                | tt
                | te
                | th
                | tig
                | ts
                | tn
                | tr
                | tk
                | uk
                | hsb
                | ur
                | ve
                | vi
                | vo
                | wa
                | cy
                | xh
                | ji
                | zu

    module Matrix =

        [<AllowNullLiteral>]
        [<Interface>]
        type decompose =
            abstract member scale: Jspdf.Matrix with get, set
            abstract member translate: Jspdf.Matrix with get, set
            abstract member rotate: Jspdf.Matrix with get, set
            abstract member skew: Jspdf.Matrix with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (scale: Jspdf.Matrix, translate: Jspdf.Matrix, rotate: Jspdf.Matrix, skew: Jspdf.Matrix) : decompose = nativeOnly

    module Exports =

        module jsPDF =

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type orientation =
                | p
                | portrait
                | l
                | landscape

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type unit =
                | pt
                | px
                | ``in``
                | mm
                | cm
                | ex
                | em
                | pc
