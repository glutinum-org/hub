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
        static member jsPDF (?orientation: Exports.jsPDF.orientation, ?unit: Exports.jsPDF.unit, ?format: U2<string, ResizeArray<float>>, ?compressPdf: bool) : jsPDF = nativeOnly
        [<Import("GState", "jspdf"); EmitConstructor>]
        static member GState (parameters: Jspdf.GState) : GState = nativeOnly
        [<Import("ShadingPattern", "jspdf"); EmitConstructor>]
        static member ShadingPattern (``type``: Jspdf.ShadingPatternType, coords: ResizeArray<float>, colors: ResizeArray<Jspdf.ShadingPatterStop>, ?gState: Jspdf.GState, ?matrix: Jspdf.Matrix) : ShadingPattern = nativeOnly
        [<Import("TilingPattern", "jspdf"); EmitConstructor>]
        static member TilingPattern (boundingBox: ResizeArray<float>, xStep: float, yStep: float, ?gState: Jspdf.GState, ?matrix: Jspdf.Matrix) : TilingPattern = nativeOnly

    [<Global>]
    [<AllowNullLiteral>]
    type Annotation
        [<ParamObject; Emit("$0")>]
        (
            ``type``: Annotation.``type``,
            bounds: Annotation.bounds,
            contents: string,
            ?title: string,
            ?``open``: bool,
            ?color: string,
            ?name: string,
            ?top: float,
            ?pageNumber: float
        ) =

        member val ``type`` : Annotation.``type`` = nativeOnly with get, set
        member val bounds : Annotation.bounds = nativeOnly with get, set
        member val contents : string = nativeOnly with get, set
        member val title : string option = nativeOnly with get, set
        member val ``open`` : bool option = nativeOnly with get, set
        member val color : string option = nativeOnly with get, set
        member val name : string option = nativeOnly with get, set
        member val top : float option = nativeOnly with get, set
        member val pageNumber : float option = nativeOnly with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type TextWithLinkOptions =
        abstract member pageNumber: float option with get, set
        abstract member magFactor: TextWithLinkOptions.magFactor option with get, set
        abstract member zoom: float option with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type AutoPrintInput
        [<ParamObject; Emit("$0")>]
        (
            variant: AutoPrintInput.variant
        ) =

        member val variant : AutoPrintInput.variant = nativeOnly with get, set

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

    [<AllowNullLiteral>]
    [<Interface>]
    type HTMLFontFace =
        abstract member family: string with get, set
        abstract member style: HTMLFontFace.style option with get, set
        abstract member stretch: HTMLFontFace.stretch option with get, set
        abstract member weight: obj option with get, set
        abstract member src: ResizeArray<HTMLFontFace.src> with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type HTMLOptions
        private () =

        [<ParamObject; Emit("$0")>]
        new (?callback: (Jspdf.jsPDF -> unit), ?autoPaging: HTMLOptions.autoPaging, ?filename: string, ?image: Jspdf.HTMLOptionImage, ?html2canvas: Jspdf.Html2CanvasOptions, ?jsPDF: Jspdf.jsPDF, ?x: float, ?y: float, ?width: float, ?windowWidth: float, ?fontFaces: ResizeArray<Jspdf.HTMLFontFace>) =
            HTMLOptions()

        [<ParamObject; Emit("$0")>]
        new (margin: float, ?callback: (Jspdf.jsPDF -> unit), ?autoPaging: HTMLOptions.autoPaging, ?filename: string, ?image: Jspdf.HTMLOptionImage, ?html2canvas: Jspdf.Html2CanvasOptions, ?jsPDF: Jspdf.jsPDF, ?x: float, ?y: float, ?width: float, ?windowWidth: float, ?fontFaces: ResizeArray<Jspdf.HTMLFontFace>) =
            HTMLOptions()

        [<ParamObject; Emit("$0")>]
        new (margin: ResizeArray<float>, ?callback: (Jspdf.jsPDF -> unit), ?autoPaging: HTMLOptions.autoPaging, ?filename: string, ?image: Jspdf.HTMLOptionImage, ?html2canvas: Jspdf.Html2CanvasOptions, ?jsPDF: Jspdf.jsPDF, ?x: float, ?y: float, ?width: float, ?windowWidth: float, ?fontFaces: ResizeArray<Jspdf.HTMLFontFace>) =
            HTMLOptions()

        member val callback : (Jspdf.jsPDF -> unit) option = nativeOnly with get, set
        member val margin : U2<float, ResizeArray<float>> option = nativeOnly with get, set
        member val autoPaging : HTMLOptions.autoPaging option = nativeOnly with get, set
        member val filename : string option = nativeOnly with get, set
        member val image : Jspdf.HTMLOptionImage option = nativeOnly with get, set
        member val html2canvas : Jspdf.Html2CanvasOptions option = nativeOnly with get, set
        member val jsPDF : Jspdf.jsPDF option = nativeOnly with get, set
        member val x : float option = nativeOnly with get, set
        member val y : float option = nativeOnly with get, set
        member val width : float option = nativeOnly with get, set
        member val windowWidth : float option = nativeOnly with get, set
        member val fontFaces : ResizeArray<Jspdf.HTMLFontFace> option = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type ViewerPreferencesInput
        [<ParamObject; Emit("$0")>]
        (
            ?HideToolbar: bool,
            ?HideMenubar: bool,
            ?HideWindowUI: bool,
            ?FitWindow: bool,
            ?CenterWindow: bool,
            ?DisplayDocTitle: bool,
            ?NonFullScreenPageMode: ViewerPreferencesInput.NonFullScreenPageMode,
            ?Direction: ViewerPreferencesInput.Direction,
            ?ViewArea: ViewerPreferencesInput.ViewArea,
            ?ViewClip: ViewerPreferencesInput.ViewClip,
            ?PrintArea: ViewerPreferencesInput.PrintArea,
            ?PrintClip: ViewerPreferencesInput.PrintClip,
            ?PrintScaling: ViewerPreferencesInput.PrintScaling,
            ?Duplex: ViewerPreferencesInput.Duplex,
            ?PickTrayByPDFSize: bool,
            ?PrintPageRange: ResizeArray<ResizeArray<float>>,
            ?NumCopies: float
        ) =

        member val HideToolbar : bool option = nativeOnly with get, set
        member val HideMenubar : bool option = nativeOnly with get, set
        member val HideWindowUI : bool option = nativeOnly with get, set
        member val FitWindow : bool option = nativeOnly with get, set
        member val CenterWindow : bool option = nativeOnly with get, set
        member val DisplayDocTitle : bool option = nativeOnly with get, set
        member val NonFullScreenPageMode : ViewerPreferencesInput.NonFullScreenPageMode option = nativeOnly with get, set
        member val Direction : ViewerPreferencesInput.Direction option = nativeOnly with get, set
        member val ViewArea : ViewerPreferencesInput.ViewArea option = nativeOnly with get, set
        member val ViewClip : ViewerPreferencesInput.ViewClip option = nativeOnly with get, set
        member val PrintArea : ViewerPreferencesInput.PrintArea option = nativeOnly with get, set
        member val PrintClip : ViewerPreferencesInput.PrintClip option = nativeOnly with get, set
        member val PrintScaling : ViewerPreferencesInput.PrintScaling option = nativeOnly with get, set
        member val Duplex : ViewerPreferencesInput.Duplex option = nativeOnly with get, set
        member val PickTrayByPDFSize : bool option = nativeOnly with get, set
        member val PrintPageRange : ResizeArray<ResizeArray<float>> option = nativeOnly with get, set
        member val NumCopies : float option = nativeOnly with get, set

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

    [<Global>]
    [<AllowNullLiteral>]
    type OutlineOptions
        [<ParamObject; Emit("$0")>]
        (
            pageNumber: float
        ) =

        member val pageNumber : float = nativeOnly with get, set

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

    [<Global>]
    [<AllowNullLiteral>]
    type ImageOptions
        private () =

        [<ParamObject; Emit("$0")>]
        new (imageData: string, x: float, y: float, width: float, height: float, ?alias: string, ?compression: Jspdf.ImageCompression, ?rotation: float, ?format: Jspdf.ImageFormat) =
            ImageOptions()

        [<ParamObject; Emit("$0")>]
        new (imageData: Glutinum.Web.HTMLImageElement, x: float, y: float, width: float, height: float, ?alias: string, ?compression: Jspdf.ImageCompression, ?rotation: float, ?format: Jspdf.ImageFormat) =
            ImageOptions()

        [<ParamObject; Emit("$0")>]
        new (imageData: Glutinum.Web.HTMLCanvasElement, x: float, y: float, width: float, height: float, ?alias: string, ?compression: Jspdf.ImageCompression, ?rotation: float, ?format: Jspdf.ImageFormat) =
            ImageOptions()

        [<ParamObject; Emit("$0")>]
        new (imageData: JS.Uint8Array, x: float, y: float, width: float, height: float, ?alias: string, ?compression: Jspdf.ImageCompression, ?rotation: float, ?format: Jspdf.ImageFormat) =
            ImageOptions()

        [<ParamObject; Emit("$0")>]
        new (imageData: Jspdf.RGBAData, x: float, y: float, width: float, height: float, ?alias: string, ?compression: Jspdf.ImageCompression, ?rotation: float, ?format: Jspdf.ImageFormat) =
            ImageOptions()

        member val imageData : U5<string, Glutinum.Web.HTMLImageElement, Glutinum.Web.HTMLCanvasElement, JS.Uint8Array, Jspdf.RGBAData> = nativeOnly with get, set
        member val x : float = nativeOnly with get, set
        member val y : float = nativeOnly with get, set
        member val width : float = nativeOnly with get, set
        member val height : float = nativeOnly with get, set
        member val alias : string option = nativeOnly with get, set
        member val compression : Jspdf.ImageCompression option = nativeOnly with get, set
        member val rotation : float option = nativeOnly with get, set
        member val format : Jspdf.ImageFormat option = nativeOnly with get, set

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

    [<Global>]
    [<AllowNullLiteral>]
    type TableConfig
        [<ParamObject; Emit("$0")>]
        (
            ?printHeaders: bool,
            ?autoSize: bool,
            ?margins: TableConfig.margins,
            ?fontSize: float,
            ?padding: float,
            ?headerBackgroundColor: string,
            ?headerTextColor: string,
            ?rowStart: TableConfig.rowStart,
            ?cellStart: TableConfig.cellStart,
            ?css: TableConfig.css
        ) =

        member val printHeaders : bool option = nativeOnly with get, set
        member val autoSize : bool option = nativeOnly with get, set
        member val margins : TableConfig.margins option = nativeOnly with get, set
        member val fontSize : float option = nativeOnly with get, set
        member val padding : float option = nativeOnly with get, set
        member val headerBackgroundColor : string option = nativeOnly with get, set
        member val headerTextColor : string option = nativeOnly with get, set
        member val rowStart : TableConfig.rowStart option = nativeOnly with get, set
        member val cellStart : TableConfig.cellStart option = nativeOnly with get, set
        member val css : TableConfig.css option = nativeOnly with get, set

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
        abstract member userPermissions: ResizeArray<EncryptionOptions.userPermissions> option with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type jsPDFOptions
        private () =

        [<ParamObject; Emit("$0")>]
        new (?orientation: jsPDFOptions.orientation, ?unit: jsPDFOptions.unit, ?compress: bool, ?precision: float, ?filters: ResizeArray<string>, ?userUnit: float, ?encryption: Jspdf.EncryptionOptions, ?putOnlyUsedFonts: bool, ?hotfixes: ResizeArray<string>, ?floatPrecision: jsPDFOptions.floatPrecision) =
            jsPDFOptions()

        [<ParamObject; Emit("$0")>]
        new (format: string, ?orientation: jsPDFOptions.orientation, ?unit: jsPDFOptions.unit, ?compress: bool, ?precision: float, ?filters: ResizeArray<string>, ?userUnit: float, ?encryption: Jspdf.EncryptionOptions, ?putOnlyUsedFonts: bool, ?hotfixes: ResizeArray<string>, ?floatPrecision: jsPDFOptions.floatPrecision) =
            jsPDFOptions()

        [<ParamObject; Emit("$0")>]
        new (format: ResizeArray<float>, ?orientation: jsPDFOptions.orientation, ?unit: jsPDFOptions.unit, ?compress: bool, ?precision: float, ?filters: ResizeArray<string>, ?userUnit: float, ?encryption: Jspdf.EncryptionOptions, ?putOnlyUsedFonts: bool, ?hotfixes: ResizeArray<string>, ?floatPrecision: jsPDFOptions.floatPrecision) =
            jsPDFOptions()

        member val orientation : jsPDFOptions.orientation option = nativeOnly with get, set
        member val unit : jsPDFOptions.unit option = nativeOnly with get, set
        member val format : U2<string, ResizeArray<float>> option = nativeOnly with get, set
        member val compress : bool option = nativeOnly with get, set
        member val precision : float option = nativeOnly with get, set
        member val filters : ResizeArray<string> option = nativeOnly with get, set
        member val userUnit : float option = nativeOnly with get, set
        member val encryption : Jspdf.EncryptionOptions option = nativeOnly with get, set
        member val putOnlyUsedFonts : bool option = nativeOnly with get, set
        member val hotfixes : ResizeArray<string> option = nativeOnly with get, set
        member val floatPrecision : jsPDFOptions.floatPrecision option = nativeOnly with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type Point =
        abstract member x: float with get, set
        abstract member y: float with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type Rectangle =
        inherit Jspdf.Point
        abstract member w: float with get, set
        abstract member h: float with get, set

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

    [<Global>]
    [<AllowNullLiteral>]
    type DocumentProperties
        [<ParamObject; Emit("$0")>]
        (
            ?title: string,
            ?subject: string,
            ?author: string,
            ?keywords: string,
            ?creator: string
        ) =

        member val title : string option = nativeOnly with get, set
        member val subject : string option = nativeOnly with get, set
        member val author : string option = nativeOnly with get, set
        member val keywords : string option = nativeOnly with get, set
        member val creator : string option = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type PatternData
        [<ParamObject; Emit("$0")>]
        (
            key: string,
            ?matrix: Jspdf.Matrix,
            ?boundingBox: ResizeArray<float>,
            ?xStep: float,
            ?yStep: float
        ) =

        member val key : string = nativeOnly with get, set
        member val matrix : Jspdf.Matrix option = nativeOnly with get, set
        member val boundingBox : ResizeArray<float> option = nativeOnly with get, set
        member val xStep : float option = nativeOnly with get, set
        member val yStep : float option = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type RGBAData
        [<ParamObject; Emit("$0")>]
        (
            data: JS.Uint8ClampedArray,
            width: float,
            height: float
        ) =

        member val data : JS.Uint8ClampedArray = nativeOnly with get, set
        member val width : float = nativeOnly with get, set
        member val height : float = nativeOnly with get, set

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
        abstract member setLineDashPattern: dashArray: ResizeArray<float> * dashPhase: float -> Jspdf.jsPDF
        abstract member setLineHeightFactor: value: float -> Jspdf.jsPDF
        abstract member setLineJoin: style: string -> Jspdf.jsPDF
        abstract member setLineJoin: style: float -> Jspdf.jsPDF
        abstract member setLineMiterLimit: length: float -> Jspdf.jsPDF
        abstract member setLineWidth: width: float -> Jspdf.jsPDF
        abstract member setPage: pageNumber: float -> Jspdf.jsPDF
        abstract member setR2L: value: bool -> Jspdf.jsPDF
        abstract member setTextColor: ch1: string -> Jspdf.jsPDF
        abstract member setTextColor: ch1: float -> Jspdf.jsPDF
        abstract member setTextColor: ch1: float * ch2: float * ch3: float * ?ch4: float -> Jspdf.jsPDF
        abstract member text: text: string * x: float * y: float * ?options: Jspdf.TextOptionsLight * ?transform: U2<float, obj> -> Jspdf.jsPDF
        abstract member text: text: ResizeArray<string> * x: float * y: float * ?options: Jspdf.TextOptionsLight * ?transform: U2<float, obj> -> Jspdf.jsPDF
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
        abstract member addImage: options: Jspdf.ImageOptions -> Jspdf.jsPDF
        abstract member getImageProperties: imageData: string -> Jspdf.ImageProperties
        abstract member getImageProperties: imageData: Glutinum.Web.HTMLImageElement -> Jspdf.ImageProperties
        abstract member getImageProperties: imageData: Glutinum.Web.HTMLCanvasElement -> Jspdf.ImageProperties
        abstract member getImageProperties: imageData: JS.Uint8Array -> Jspdf.ImageProperties
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
        abstract member table: x: float * y: float * data: ResizeArray<jsPDF.table.data> * headers: ResizeArray<string> * config: Jspdf.TableConfig -> Jspdf.jsPDF
        abstract member table: x: float * y: float * data: ResizeArray<jsPDF.table.data> * headers: ResizeArray<Jspdf.CellConfig> * config: Jspdf.TableConfig -> Jspdf.jsPDF
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
        abstract member addJS: javascript: string -> Jspdf.jsPDF
        abstract member getCharWidthsArray: text: string * ?options: obj -> ResizeArray<obj>
        abstract member getStringUnitWidth: text: string * ?options: obj -> float
        abstract member splitTextToSize: text: string * maxlen: float * ?options: obj -> obj
        abstract member addSvgAsImage: svg: string * x: float * y: float * w: float * h: float * ?alias: string * ?compression: bool * ?rotation: float -> Jspdf.jsPDF
        abstract member setLanguage: langCode: obj -> Jspdf.jsPDF
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
        abstract member addMetadata: metadata: string * ?rawXml: bool -> Jspdf.jsPDF
        abstract member Matrix: a: float * b: float * c: float * d: float * e: float * f: float -> Jspdf.Matrix
        abstract member matrixMult: m1: Jspdf.Matrix * m2: Jspdf.Matrix -> Jspdf.Matrix
        abstract member unitMatrix: Jspdf.Matrix with get, set
        abstract member GState: parameters: Jspdf.GState -> Jspdf.GState
        abstract member ShadingPattern: ``type``: Jspdf.ShadingPatternType * coords: ResizeArray<float> * colors: ResizeArray<Jspdf.ShadingPatterStop> * ?gState: Jspdf.GState * ?matrix: Jspdf.Matrix -> Jspdf.ShadingPattern
        abstract member TilingPattern: boundingBox: ResizeArray<float> * xStep: float * yStep: float * ?gState: Jspdf.GState * ?matrix: Jspdf.Matrix -> Jspdf.TilingPattern
        abstract member addShadingPattern: key: string * pattern: Jspdf.ShadingPattern -> Jspdf.jsPDF
        abstract member beginTilingPattern: pattern: Jspdf.TilingPattern -> unit
        abstract member endTilingPattern: key: string * pattern: Jspdf.TilingPattern -> unit
        static member inline API
            with get () : Jspdf.jsPDFAPI =
                emitJsExpr () $$"""
import { jsPDF } from "jspdf";
jsPDF.API"""
            and set (value: Jspdf.jsPDFAPI) =
                emitJsExpr (value) $$"""
import { jsPDF } from "jspdf";
jsPDF.API = $0"""

    [<AllowNullLiteral>]
    [<Interface>]
    type GState =
        abstract member opacity: float option with get, set
        abstract member ``stroke-opacity``: float option with get, set

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

    [<AllowNullLiteral>]
    [<Interface>]
    type TilingPattern =
        inherit Jspdf.Pattern
        abstract member boundingBox: ResizeArray<float> with get, set
        abstract member xStep: float with get, set
        abstract member yStep: float with get, set

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

        [<Global>]
        [<AllowNullLiteral>]
        type bounds
            [<ParamObject; Emit("$0")>]
            (
                x: float,
                y: float,
                w: float,
                h: float
            ) =

            member val x : float = nativeOnly with get, set
            member val y : float = nativeOnly with get, set
            member val w : float = nativeOnly with get, set
            member val h : float = nativeOnly with get, set

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

                [<Global>]
                [<AllowNullLiteral>]
                type options
                    [<ParamObject; Emit("$0")>]
                    (
                        ?filename: string
                    ) =

                    member val filename : string option = nativeOnly with get, set

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

        [<Global>]
        [<AllowNullLiteral>]
        type src
            [<ParamObject; Emit("$0")>]
            (
                url: string,
                format: string
            ) =

            member val url : string = nativeOnly with get, set
            member val format : string = nativeOnly with get, set

    module HTMLOptions =

        [<RequireQualifiedAccess>]
        [<Erase(CaseRules.None)>]
        type autoPaging =
            | slice
            | text
            | Case1 of bool

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

        [<Global>]
        [<AllowNullLiteral>]
        type flags
            [<ParamObject; Emit("$0")>]
            (
                noBOM: bool,
                autoencode: bool
            ) =

            member val noBOM : bool = nativeOnly with get, set
            member val autoencode : bool = nativeOnly with get, set

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

        [<Global>]
        [<AllowNullLiteral>]
        type margins
            [<ParamObject; Emit("$0")>]
            (
                top: float,
                bottom: float,
                left: float,
                width: float
            ) =

            member val top : float = nativeOnly with get, set
            member val bottom : float = nativeOnly with get, set
            member val left : float = nativeOnly with get, set
            member val width : float = nativeOnly with get, set

        type rowStart =
            delegate of e: Jspdf.TableRowData * doc: Jspdf.jsPDF -> unit

        type cellStart =
            delegate of e: Jspdf.TableCellData * doc: Jspdf.jsPDF -> unit

        [<Global>]
        [<AllowNullLiteral>]
        type css
            [<ParamObject; Emit("$0")>]
            (
                ``font-size``: float
            ) =

            member val ``font-size`` : float = nativeOnly with get, set

    module CellConfig =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type align =
            | left
            | center
            | right

    module EncryptionOptions =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type userPermissions =
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

        [<Global>]
        [<AllowNullLiteral>]
        type ``internal``
            [<ParamObject; Emit("$0")>]
            (
                events: Jspdf.PubSub,
                scaleFactor: float,
                pageSize: jsPDF.``internal``.pageSize,
                pages: ResizeArray<float>,
                getEncryptor: (string -> string)
            ) =

            member val events : Jspdf.PubSub = nativeOnly with get, set
            member val scaleFactor : float = nativeOnly with get, set
            member val pageSize : jsPDF.``internal``.pageSize = nativeOnly with get, set
            member val pages : ResizeArray<float> = nativeOnly with get, set
            member val getEncryptor : (string -> string) = nativeOnly

        [<Global>]
        [<AllowNullLiteral>]
        type AcroForm
            [<ParamObject; Emit("$0")>]
            (
                ChoiceField: Jspdf.AcroFormChoiceField,
                ListBox: Jspdf.AcroFormListBox,
                ComboBox: Jspdf.AcroFormComboBox,
                EditBox: Jspdf.AcroFormEditBox,
                Button: Jspdf.AcroFormButton,
                PushButton: Jspdf.AcroFormPushButton,
                RadioButton: Jspdf.AcroFormRadioButton,
                CheckBox: Jspdf.AcroFormCheckBox,
                TextField: Jspdf.AcroFormTextField,
                PasswordField: Jspdf.AcroFormPasswordField,
                Appearance: obj
            ) =

            member val ChoiceField : Jspdf.AcroFormChoiceField = nativeOnly
            member val ListBox : Jspdf.AcroFormListBox = nativeOnly
            member val ComboBox : Jspdf.AcroFormComboBox = nativeOnly
            member val EditBox : Jspdf.AcroFormEditBox = nativeOnly
            member val Button : Jspdf.AcroFormButton = nativeOnly
            member val PushButton : Jspdf.AcroFormPushButton = nativeOnly
            member val RadioButton : Jspdf.AcroFormRadioButton = nativeOnly
            member val CheckBox : Jspdf.AcroFormCheckBox = nativeOnly
            member val TextField : Jspdf.AcroFormTextField = nativeOnly
            member val PasswordField : Jspdf.AcroFormPasswordField = nativeOnly
            member val Appearance : obj = nativeOnly

        [<Global>]
        [<AllowNullLiteral>]
        type canvas
            [<ParamObject; Emit("$0")>]
            (
                pdf: Jspdf.jsPDF,
                width: float,
                height: float,
                getContext: Jspdf.Context2d,
                style: obj
            ) =

            member val pdf : Jspdf.jsPDF = nativeOnly with get, set
            member val width : float = nativeOnly with get, set
            member val height : float = nativeOnly with get, set
            member val getContext : Jspdf.Context2d = nativeOnly
            member val style : obj = nativeOnly with get, set

        [<Global>]
        [<AllowNullLiteral>]
        type getTextDimensions
            [<ParamObject; Emit("$0")>]
            (
                w: float,
                h: float
            ) =

            member val w : float = nativeOnly with get, set
            member val h : float = nativeOnly with get, set

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

            [<Global>]
            [<AllowNullLiteral>]
            type options
                [<ParamObject; Emit("$0")>]
                (
                    ?filename: string
                ) =

                member val filename : string option = nativeOnly with get, set

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

            [<Global>]
            [<AllowNullLiteral>]
            type options
                [<ParamObject; Emit("$0")>]
                (
                    returnPromise: bool
                ) =

                member val returnPromise : bool = nativeOnly with get, set

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

            [<Global>]
            [<AllowNullLiteral>]
            type pageSize
                [<ParamObject; Emit("$0")>]
                (
                    width: float,
                    getWidth: (unit -> float),
                    height: float,
                    getHeight: (unit -> float)
                ) =

                member val width : float = nativeOnly with get, set
                member val getWidth : (unit -> float) = nativeOnly with get, set
                member val height : float = nativeOnly with get, set
                member val getHeight : (unit -> float) = nativeOnly with get, set

        module setHeaderFunction =

            type func =
                delegate of jsPDFInstance: Jspdf.jsPDF * pages: float -> ResizeArray<float>

        module getTextDimensions =

            [<Global>]
            [<AllowNullLiteral>]
            type options
                [<ParamObject; Emit("$0")>]
                (
                    ?font: string,
                    ?fontSize: float,
                    ?maxWidth: float,
                    ?scaleFactor: float
                ) =

                member val font : string option = nativeOnly with get, set
                member val fontSize : float option = nativeOnly with get, set
                member val maxWidth : float option = nativeOnly with get, set
                member val scaleFactor : float option = nativeOnly with get, set

        module table =

            [<AllowNullLiteral>]
            [<Interface>]
            type data =
                [<EmitIndexer>]
                abstract member Item: key: string -> string with get, set

    module Matrix =

        [<Global>]
        [<AllowNullLiteral>]
        type decompose
            [<ParamObject; Emit("$0")>]
            (
                scale: Jspdf.Matrix,
                translate: Jspdf.Matrix,
                rotate: Jspdf.Matrix,
                skew: Jspdf.Matrix
            ) =

            member val scale : Jspdf.Matrix = nativeOnly with get, set
            member val translate : Jspdf.Matrix = nativeOnly with get, set
            member val rotate : Jspdf.Matrix = nativeOnly with get, set
            member val skew : Jspdf.Matrix = nativeOnly with get, set

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
