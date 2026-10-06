namespace rec Glutinum

open Fable.Core
open Fable.Core.JsInterop
open System

// You need to add Glutinum.Web NuGet package to your project

type Iterable<'T> = Collections.Generic.IEnumerable<'T>

module Animejs =

    [<AbstractClass>]
    [<Erase>]
    type Exports =
        [<Import("cubicBezier", "animejs")>]
        static member cubicBezier (?mX1: float, ?mY1: float, ?mX2: float, ?mY2: float) : Animejs.EasingFunction = nativeOnly
        [<Import("steps", "animejs")>]
        static member steps (?steps: float, ?fromStart: bool) : Animejs.EasingFunction = nativeOnly
        [<Import("linear", "animejs")>]
        static member linear ([<ParamArray>] args: U2<string, float> []) : Animejs.EasingFunction = nativeOnly
        [<Import("irregular", "animejs")>]
        static member irregular (?length: float, ?randomness: float) : Animejs.EasingFunction = nativeOnly
        [<Import("spring", "animejs")>]
        static member spring (?parameters: Animejs.SpringParams) : Animejs.easings.spring.Spring = nativeOnly
        [<Import("createSpring", "animejs")>]
        static member createSpring (?parameters: Animejs.SpringParams) : Animejs.easings.spring.Spring = nativeOnly
        /// <param name="targets">
        ///
        /// </param>
        [<Import("$", "animejs")>]
        static member ``$`` (targets: ResizeArray<Animejs.DOMTargetSelector>) : Animejs.DOMTargetsArray = nativeOnly
        /// <param name="targets">
        ///
        /// </param>
        [<Import("$", "animejs")>]
        static member ``$`` (targets: Glutinum.Web.HTMLElement) : Animejs.DOMTargetsArray = nativeOnly
        /// <param name="targets">
        ///
        /// </param>
        [<Import("$", "animejs")>]
        static member ``$`` (targets: Glutinum.Web.SVGElement) : Animejs.DOMTargetsArray = nativeOnly
        /// <param name="targets">
        ///
        /// </param>
        [<Import("$", "animejs")>]
        static member ``$`` (targets: Glutinum.Web.NodeList) : Animejs.DOMTargetsArray = nativeOnly
        /// <param name="targets">
        ///
        /// </param>
        [<Import("$", "animejs")>]
        static member ``$`` (targets: string) : Animejs.DOMTargetsArray = nativeOnly
        /// <param name="targets">
        ///
        /// </param>
        [<Import("$", "animejs")>]
        static member ``$`` (targets: Animejs.DOMTargetsParam) : Animejs.DOMTargetsArray = nativeOnly
        /// <param name="targets">
        ///
        /// </param>
        [<Import("$", "animejs")>]
        static member ``$`` (targets: ResizeArray<Animejs.JSTarget>) : Animejs.JSTargetsArray = nativeOnly
        /// <param name="targets">
        ///
        /// </param>
        [<Import("$", "animejs")>]
        static member ``$`` (targets: Animejs.JSTarget) : Animejs.JSTargetsArray = nativeOnly
        /// <param name="targets">
        ///
        /// </param>
        [<Import("$", "animejs")>]
        static member ``$`` (targets: Animejs.JSTargetsParam) : Animejs.JSTargetsArray = nativeOnly
        /// <param name="targets">
        ///
        /// </param>
        [<Import("$", "animejs")>]
        static member ``$`` (targets: ResizeArray<Animejs.TargetSelector>) : Animejs.TargetsArray = nativeOnly
        /// <param name="targets">
        ///
        /// </param>
        [<Import("$", "animejs")>]
        static member ``$`` (targets: Animejs.TargetsParam) : Animejs.TargetsArray = nativeOnly
        [<Import("createAnimatable", "animejs")>]
        static member createAnimatable (targets: ResizeArray<Animejs.TargetSelector>, parameters: Animejs.AnimatableParams) : Animejs.AnimatableObject = nativeOnly
        [<Import("createAnimatable", "animejs")>]
        static member createAnimatable (targets: Glutinum.Web.HTMLElement, parameters: Animejs.AnimatableParams) : Animejs.AnimatableObject = nativeOnly
        [<Import("createAnimatable", "animejs")>]
        static member createAnimatable (targets: Glutinum.Web.SVGElement, parameters: Animejs.AnimatableParams) : Animejs.AnimatableObject = nativeOnly
        [<Import("createAnimatable", "animejs")>]
        static member createAnimatable (targets: Animejs.JSTarget, parameters: Animejs.AnimatableParams) : Animejs.AnimatableObject = nativeOnly
        [<Import("createAnimatable", "animejs")>]
        static member createAnimatable (targets: Glutinum.Web.NodeList, parameters: Animejs.AnimatableParams) : Animejs.AnimatableObject = nativeOnly
        [<Import("createAnimatable", "animejs")>]
        static member createAnimatable (targets: string, parameters: Animejs.AnimatableParams) : Animejs.AnimatableObject = nativeOnly
        [<Import("createAnimatable", "animejs")>]
        static member createAnimatable (targets: Animejs.TargetsParam, parameters: Animejs.AnimatableParams) : Animejs.AnimatableObject = nativeOnly
        [<Import("animate", "animejs")>]
        static member animate (targets: ResizeArray<Animejs.TargetSelector>, parameters: Animejs.AnimationParams) : Animejs.JSAnimation = nativeOnly
        [<Import("animate", "animejs")>]
        static member animate (targets: Glutinum.Web.HTMLElement, parameters: Animejs.AnimationParams) : Animejs.JSAnimation = nativeOnly
        [<Import("animate", "animejs")>]
        static member animate (targets: Glutinum.Web.SVGElement, parameters: Animejs.AnimationParams) : Animejs.JSAnimation = nativeOnly
        [<Import("animate", "animejs")>]
        static member animate (targets: Animejs.JSTarget, parameters: Animejs.AnimationParams) : Animejs.JSAnimation = nativeOnly
        [<Import("animate", "animejs")>]
        static member animate (targets: Glutinum.Web.NodeList, parameters: Animejs.AnimationParams) : Animejs.JSAnimation = nativeOnly
        [<Import("animate", "animejs")>]
        static member animate (targets: string, parameters: Animejs.AnimationParams) : Animejs.JSAnimation = nativeOnly
        [<Import("animate", "animejs")>]
        static member animate (targets: Animejs.TargetsParam, parameters: Animejs.AnimationParams) : Animejs.JSAnimation = nativeOnly
        [<Import("clamp", "animejs")>]
        static member clamp (v: float, min: float, max: float) : float = nativeOnly
        [<Import("round", "animejs")>]
        static member round (v: float, decimalLength: float) : float = nativeOnly
        [<Import("snap", "animejs")>]
        static member snap (v: float, increment: float) : float = nativeOnly
        [<Import("snap", "animejs")>]
        static member snap (v: float, increment: ResizeArray<float>) : float = nativeOnly
        [<Import("snap", "animejs")>]
        static member snap (v: float, increment: U2<float, ResizeArray<float>>) : float = nativeOnly
        [<Import("lerp", "animejs")>]
        static member lerp (start: float, ``end``: float, factor: float) : float = nativeOnly
        [<Import("forEachChildren", "animejs")>]
        static member forEachChildren (parent: obj, callback: Action, ?reverse: bool, ?prevProp: string, ?nextProp: string) : unit = nativeOnly
        [<Import("removeChild", "animejs")>]
        static member removeChild (parent: obj, child: obj, ?prevProp: string, ?nextProp: string) : unit = nativeOnly
        [<Import("addChild", "animejs")>]
        static member addChild (parent: obj, child: obj, ?sortMethod: Action, ?prevProp: string, ?nextProp: string) : unit = nativeOnly
        [<Import("cleanInlineStyles", "animejs")>]
        static member cleanInlineStyles<'T> (renderable: 'T) : 'T = nativeOnly
        [<Import("createDraggable", "animejs")>]
        static member createDraggable (target: ResizeArray<Animejs.TargetSelector>, ?parameters: Animejs.DraggableParams) : Animejs.Draggable = nativeOnly
        [<Import("createDraggable", "animejs")>]
        static member createDraggable (target: Glutinum.Web.HTMLElement, ?parameters: Animejs.DraggableParams) : Animejs.Draggable = nativeOnly
        [<Import("createDraggable", "animejs")>]
        static member createDraggable (target: Glutinum.Web.SVGElement, ?parameters: Animejs.DraggableParams) : Animejs.Draggable = nativeOnly
        [<Import("createDraggable", "animejs")>]
        static member createDraggable (target: Animejs.JSTarget, ?parameters: Animejs.DraggableParams) : Animejs.Draggable = nativeOnly
        [<Import("createDraggable", "animejs")>]
        static member createDraggable (target: Glutinum.Web.NodeList, ?parameters: Animejs.DraggableParams) : Animejs.Draggable = nativeOnly
        [<Import("createDraggable", "animejs")>]
        static member createDraggable (target: string, ?parameters: Animejs.DraggableParams) : Animejs.Draggable = nativeOnly
        [<Import("createDraggable", "animejs")>]
        static member createDraggable (target: Animejs.TargetsParam, ?parameters: Animejs.DraggableParams) : Animejs.Draggable = nativeOnly
        [<Import("engine", "animejs")>]
        static member inline engine: Animejs.dist.modules.engine.engine.Engine = nativeOnly
        [<Import("scrollContainers", "animejs")>]
        static member inline scrollContainers: obj = nativeOnly
        [<Import("onScroll", "animejs")>]
        static member onScroll (?parameters: Animejs.ScrollObserverParams) : Animejs.ScrollObserver = nativeOnly
        [<Import("createLayout", "animejs")>]
        static member createLayout (root: Glutinum.Web.HTMLElement, ?``params``: Animejs.AutoLayoutParams) : Animejs.AutoLayout = nativeOnly
        [<Import("createLayout", "animejs")>]
        static member createLayout (root: Glutinum.Web.SVGElement, ?``params``: Animejs.AutoLayoutParams) : Animejs.AutoLayout = nativeOnly
        [<Import("createLayout", "animejs")>]
        static member createLayout (root: Glutinum.Web.NodeList, ?``params``: Animejs.AutoLayoutParams) : Animejs.AutoLayout = nativeOnly
        [<Import("createLayout", "animejs")>]
        static member createLayout (root: string, ?``params``: Animejs.AutoLayoutParams) : Animejs.AutoLayout = nativeOnly
        [<Import("createLayout", "animejs")>]
        static member createLayout (root: Animejs.DOMTargetSelector, ?``params``: Animejs.AutoLayoutParams) : Animejs.AutoLayout = nativeOnly
        [<Import("createScope", "animejs")>]
        static member createScope (?``params``: Animejs.ScopeParams) : Animejs.Scope = nativeOnly
        [<Import("createDrawable", "animejs")>]
        static member createDrawable (selector: ResizeArray<Animejs.TargetSelector>, ?start: float, ?``end``: float) : ResizeArray<Animejs.DrawableSVGGeometry> = nativeOnly
        [<Import("createDrawable", "animejs")>]
        static member createDrawable (selector: Glutinum.Web.HTMLElement, ?start: float, ?``end``: float) : ResizeArray<Animejs.DrawableSVGGeometry> = nativeOnly
        [<Import("createDrawable", "animejs")>]
        static member createDrawable (selector: Glutinum.Web.SVGElement, ?start: float, ?``end``: float) : ResizeArray<Animejs.DrawableSVGGeometry> = nativeOnly
        [<Import("createDrawable", "animejs")>]
        static member createDrawable (selector: Animejs.JSTarget, ?start: float, ?``end``: float) : ResizeArray<Animejs.DrawableSVGGeometry> = nativeOnly
        [<Import("createDrawable", "animejs")>]
        static member createDrawable (selector: Glutinum.Web.NodeList, ?start: float, ?``end``: float) : ResizeArray<Animejs.DrawableSVGGeometry> = nativeOnly
        [<Import("createDrawable", "animejs")>]
        static member createDrawable (selector: string, ?start: float, ?``end``: float) : ResizeArray<Animejs.DrawableSVGGeometry> = nativeOnly
        [<Import("createDrawable", "animejs")>]
        static member createDrawable (selector: Animejs.TargetsParam, ?start: float, ?``end``: float) : ResizeArray<Animejs.DrawableSVGGeometry> = nativeOnly
        [<Import("morphTo", "animejs")>]
        static member morphTo (path2: ResizeArray<Animejs.TargetSelector>, ?precision: float) : Animejs.FunctionValue = nativeOnly
        [<Import("morphTo", "animejs")>]
        static member morphTo (path2: Glutinum.Web.HTMLElement, ?precision: float) : Animejs.FunctionValue = nativeOnly
        [<Import("morphTo", "animejs")>]
        static member morphTo (path2: Glutinum.Web.SVGElement, ?precision: float) : Animejs.FunctionValue = nativeOnly
        [<Import("morphTo", "animejs")>]
        static member morphTo (path2: Animejs.JSTarget, ?precision: float) : Animejs.FunctionValue = nativeOnly
        [<Import("morphTo", "animejs")>]
        static member morphTo (path2: Glutinum.Web.NodeList, ?precision: float) : Animejs.FunctionValue = nativeOnly
        [<Import("morphTo", "animejs")>]
        static member morphTo (path2: string, ?precision: float) : Animejs.FunctionValue = nativeOnly
        [<Import("morphTo", "animejs")>]
        static member morphTo (path2: Animejs.TargetsParam, ?precision: float) : Animejs.FunctionValue = nativeOnly
        [<Import("createMotionPath", "animejs")>]
        static member createMotionPath (path: ResizeArray<Animejs.TargetSelector>, ?offset: float) : Exports.createMotionPath__ = nativeOnly
        [<Import("createMotionPath", "animejs")>]
        static member createMotionPath (path: Glutinum.Web.HTMLElement, ?offset: float) : Exports.createMotionPath__ = nativeOnly
        [<Import("createMotionPath", "animejs")>]
        static member createMotionPath (path: Glutinum.Web.SVGElement, ?offset: float) : Exports.createMotionPath__ = nativeOnly
        [<Import("createMotionPath", "animejs")>]
        static member createMotionPath (path: Animejs.JSTarget, ?offset: float) : Exports.createMotionPath__ = nativeOnly
        [<Import("createMotionPath", "animejs")>]
        static member createMotionPath (path: Glutinum.Web.NodeList, ?offset: float) : Exports.createMotionPath__ = nativeOnly
        [<Import("createMotionPath", "animejs")>]
        static member createMotionPath (path: string, ?offset: float) : Exports.createMotionPath__ = nativeOnly
        [<Import("createMotionPath", "animejs")>]
        static member createMotionPath (path: Animejs.TargetsParam, ?offset: float) : Exports.createMotionPath__ = nativeOnly
        [<Import("scrambleText", "animejs")>]
        static member scrambleText (?``params``: Animejs.ScrambleTextParams) : Animejs.FunctionValue<Animejs.ScrambleTextTween> = nativeOnly
        [<Import("splitText", "animejs")>]
        static member splitText (target: Glutinum.Web.Element, ?parameters: Animejs.TextSplitterParams) : Animejs.TextSplitter = nativeOnly
        [<Import("splitText", "animejs")>]
        static member splitText (target: Glutinum.Web.NodeList, ?parameters: Animejs.TextSplitterParams) : Animejs.TextSplitter = nativeOnly
        [<Import("splitText", "animejs")>]
        static member splitText (target: string, ?parameters: Animejs.TextSplitterParams) : Animejs.TextSplitter = nativeOnly
        [<Import("splitText", "animejs")>]
        static member splitText (target: ResizeArray<Glutinum.Web.Element>, ?parameters: Animejs.TextSplitterParams) : Animejs.TextSplitter = nativeOnly
        [<Import("splitText", "animejs")>]
        static member splitText (target: U4<Glutinum.Web.Element, Glutinum.Web.NodeList, string, ResizeArray<Glutinum.Web.Element>>, ?parameters: Animejs.TextSplitterParams) : Animejs.TextSplitter = nativeOnly
        [<Import("split", "animejs")>]
        static member split (target: Glutinum.Web.HTMLElement, ?parameters: Animejs.TextSplitterParams) : Animejs.TextSplitter = nativeOnly
        [<Import("split", "animejs")>]
        static member split (target: Glutinum.Web.NodeList, ?parameters: Animejs.TextSplitterParams) : Animejs.TextSplitter = nativeOnly
        [<Import("split", "animejs")>]
        static member split (target: string, ?parameters: Animejs.TextSplitterParams) : Animejs.TextSplitter = nativeOnly
        [<Import("split", "animejs")>]
        static member split (target: ResizeArray<Glutinum.Web.HTMLElement>, ?parameters: Animejs.TextSplitterParams) : Animejs.TextSplitter = nativeOnly
        [<Import("split", "animejs")>]
        static member split (target: U4<Glutinum.Web.HTMLElement, Glutinum.Web.NodeList, string, ResizeArray<Glutinum.Web.HTMLElement>>, ?parameters: Animejs.TextSplitterParams) : Animejs.TextSplitter = nativeOnly
        [<Import("createTimeline", "animejs")>]
        static member createTimeline (?parameters: Animejs.TimelineParams) : Animejs.Timeline = nativeOnly
        [<Import("createTimer", "animejs")>]
        static member createTimer (?parameters: Animejs.TimerParams) : Animejs.Timer = nativeOnly
        [<Import("roundPad", "animejs")>]
        static member inline roundPad: obj = nativeOnly
        [<Import("padStart", "animejs")>]
        static member inline padStart: obj = nativeOnly
        [<Import("padEnd", "animejs")>]
        static member inline padEnd: obj = nativeOnly
        [<Import("wrap", "animejs")>]
        static member inline wrap: obj = nativeOnly
        [<Import("mapRange", "animejs")>]
        static member inline mapRange: obj = nativeOnly
        [<Import("degToRad", "animejs")>]
        static member inline degToRad: obj = nativeOnly
        [<Import("radToDeg", "animejs")>]
        static member inline radToDeg: obj = nativeOnly
        [<Import("damp", "animejs")>]
        static member inline damp: obj = nativeOnly
        /// <summary>
        /// Generates a random number between min and max (inclusive) with optional decimal precision
        /// </summary>
        [<Import("random", "animejs")>]
        static member inline random: Animejs.RandomNumberGenerator = nativeOnly
        [<Import("createSeededRandom", "animejs")>]
        static member createSeededRandom (?seed: float, ?seededMin: float, ?seededMax: float, ?seededDecimalLength: float) : Animejs.RandomNumberGenerator = nativeOnly
        [<Import("randomPick", "animejs")>]
        static member randomPick<'T> (items: string) : U2<string, 'T> = nativeOnly
        [<Import("randomPick", "animejs")>]
        static member randomPick<'T> (items: ResizeArray<'T>) : U2<string, 'T> = nativeOnly
        [<Import("randomPick", "animejs")>]
        static member randomPick<'T> (items: U2<string, ResizeArray<'T>>) : U2<string, 'T> = nativeOnly
        [<Import("shuffle", "animejs")>]
        static member shuffle (items: ResizeArray<obj>, ?rnd: Animejs.RandomNumberGenerator) : ResizeArray<obj> = nativeOnly
        [<Import("stagger", "animejs")>]
        static member stagger (``val``: float, ?``params``: Animejs.StaggerParams) : Animejs.StaggerFunction<float> = nativeOnly
        [<Import("stagger", "animejs")>]
        static member stagger (``val``: string, ?``params``: Animejs.StaggerParams) : Animejs.StaggerFunction<string> = nativeOnly
        [<Import("stagger", "animejs")>]
        static member stagger (``val``: (float * float), ?``params``: Animejs.StaggerParams) : Animejs.StaggerFunction<float> = nativeOnly
        [<Import("stagger", "animejs")>]
        static member stagger (``val``: (string * string), ?``params``: Animejs.StaggerParams) : Animejs.StaggerFunction<string> = nativeOnly
        /// <param name="targetSelector">
        ///
        /// </param>
        /// <param name="propName">
        ///
        /// </param>
        /// <param name="unit">
        ///
        /// </param>
        [<Import("get", "animejs")>]
        static member get (targetSelector: Glutinum.Web.HTMLElement, propName: string) : string = nativeOnly
        /// <param name="targetSelector">
        ///
        /// </param>
        /// <param name="propName">
        ///
        /// </param>
        /// <param name="unit">
        ///
        /// </param>
        [<Import("get", "animejs")>]
        static member get (targetSelector: Glutinum.Web.SVGElement, propName: string) : string = nativeOnly
        /// <param name="targetSelector">
        ///
        /// </param>
        /// <param name="propName">
        ///
        /// </param>
        /// <param name="unit">
        ///
        /// </param>
        [<Import("get", "animejs")>]
        static member get (targetSelector: Glutinum.Web.NodeList, propName: string) : string = nativeOnly
        /// <param name="targetSelector">
        ///
        /// </param>
        /// <param name="propName">
        ///
        /// </param>
        /// <param name="unit">
        ///
        /// </param>
        [<Import("get", "animejs")>]
        static member get (targetSelector: string, propName: string) : string = nativeOnly
        /// <param name="targetSelector">
        ///
        /// </param>
        /// <param name="propName">
        ///
        /// </param>
        /// <param name="unit">
        ///
        /// </param>
        [<Import("get", "animejs")>]
        static member get (targetSelector: Animejs.DOMTargetSelector, propName: string) : string = nativeOnly
        /// <param name="targetSelector">
        ///
        /// </param>
        /// <param name="propName">
        ///
        /// </param>
        /// <param name="unit">
        ///
        /// </param>
        [<Import("get", "animejs")>]
        static member get (targetSelector: ResizeArray<Animejs.JSTarget>, propName: string) : U2<float, string> = nativeOnly
        /// <param name="targetSelector">
        ///
        /// </param>
        /// <param name="propName">
        ///
        /// </param>
        /// <param name="unit">
        ///
        /// </param>
        [<Import("get", "animejs")>]
        static member get (targetSelector: Animejs.JSTarget, propName: string) : U2<float, string> = nativeOnly
        /// <param name="targetSelector">
        ///
        /// </param>
        /// <param name="propName">
        ///
        /// </param>
        /// <param name="unit">
        ///
        /// </param>
        [<Import("get", "animejs")>]
        static member get (targetSelector: Animejs.JSTargetsParam, propName: string) : U2<float, string> = nativeOnly
        /// <param name="targetSelector">
        ///
        /// </param>
        /// <param name="propName">
        ///
        /// </param>
        /// <param name="unit">
        ///
        /// </param>
        [<Import("get", "animejs")>]
        static member get (targetSelector: ResizeArray<Animejs.DOMTargetSelector>, propName: string, unit: string) : string = nativeOnly
        /// <param name="targetSelector">
        ///
        /// </param>
        /// <param name="propName">
        ///
        /// </param>
        /// <param name="unit">
        ///
        /// </param>
        [<Import("get", "animejs")>]
        static member get (targetSelector: Glutinum.Web.HTMLElement, propName: string, unit: string) : string = nativeOnly
        /// <param name="targetSelector">
        ///
        /// </param>
        /// <param name="propName">
        ///
        /// </param>
        /// <param name="unit">
        ///
        /// </param>
        [<Import("get", "animejs")>]
        static member get (targetSelector: Glutinum.Web.SVGElement, propName: string, unit: string) : string = nativeOnly
        /// <param name="targetSelector">
        ///
        /// </param>
        /// <param name="propName">
        ///
        /// </param>
        /// <param name="unit">
        ///
        /// </param>
        [<Import("get", "animejs")>]
        static member get (targetSelector: Glutinum.Web.NodeList, propName: string, unit: string) : string = nativeOnly
        /// <param name="targetSelector">
        ///
        /// </param>
        /// <param name="propName">
        ///
        /// </param>
        /// <param name="unit">
        ///
        /// </param>
        [<Import("get", "animejs")>]
        static member get (targetSelector: string, propName: string, unit: string) : string = nativeOnly
        /// <param name="targetSelector">
        ///
        /// </param>
        /// <param name="propName">
        ///
        /// </param>
        /// <param name="unit">
        ///
        /// </param>
        [<Import("get", "animejs")>]
        static member get (targetSelector: Animejs.DOMTargetsParam, propName: string, unit: string) : string = nativeOnly
        /// <param name="targetSelector">
        ///
        /// </param>
        /// <param name="propName">
        ///
        /// </param>
        /// <param name="unit">
        ///
        /// </param>
        [<Import("get", "animejs")>]
        static member get (targetSelector: ResizeArray<Animejs.TargetSelector>, propName: string, unit: bool) : float = nativeOnly
        /// <param name="targetSelector">
        ///
        /// </param>
        /// <param name="propName">
        ///
        /// </param>
        /// <param name="unit">
        ///
        /// </param>
        [<Import("get", "animejs")>]
        static member get (targetSelector: Glutinum.Web.HTMLElement, propName: string, unit: bool) : float = nativeOnly
        /// <param name="targetSelector">
        ///
        /// </param>
        /// <param name="propName">
        ///
        /// </param>
        /// <param name="unit">
        ///
        /// </param>
        [<Import("get", "animejs")>]
        static member get (targetSelector: Glutinum.Web.SVGElement, propName: string, unit: bool) : float = nativeOnly
        /// <param name="targetSelector">
        ///
        /// </param>
        /// <param name="propName">
        ///
        /// </param>
        /// <param name="unit">
        ///
        /// </param>
        [<Import("get", "animejs")>]
        static member get (targetSelector: Animejs.JSTarget, propName: string, unit: bool) : float = nativeOnly
        /// <param name="targetSelector">
        ///
        /// </param>
        /// <param name="propName">
        ///
        /// </param>
        /// <param name="unit">
        ///
        /// </param>
        [<Import("get", "animejs")>]
        static member get (targetSelector: Glutinum.Web.NodeList, propName: string, unit: bool) : float = nativeOnly
        /// <param name="targetSelector">
        ///
        /// </param>
        /// <param name="propName">
        ///
        /// </param>
        /// <param name="unit">
        ///
        /// </param>
        [<Import("get", "animejs")>]
        static member get (targetSelector: string, propName: string, unit: bool) : float = nativeOnly
        /// <param name="targetSelector">
        ///
        /// </param>
        /// <param name="propName">
        ///
        /// </param>
        /// <param name="unit">
        ///
        /// </param>
        [<Import("get", "animejs")>]
        static member get (targetSelector: Animejs.TargetsParam, propName: string, unit: bool) : float = nativeOnly
        [<Import("set", "animejs")>]
        static member set (targets: ResizeArray<Animejs.TargetSelector>, parameters: Animejs.AnimationParams) : Animejs.JSAnimation = nativeOnly
        [<Import("set", "animejs")>]
        static member set (targets: Glutinum.Web.HTMLElement, parameters: Animejs.AnimationParams) : Animejs.JSAnimation = nativeOnly
        [<Import("set", "animejs")>]
        static member set (targets: Glutinum.Web.SVGElement, parameters: Animejs.AnimationParams) : Animejs.JSAnimation = nativeOnly
        [<Import("set", "animejs")>]
        static member set (targets: Animejs.JSTarget, parameters: Animejs.AnimationParams) : Animejs.JSAnimation = nativeOnly
        [<Import("set", "animejs")>]
        static member set (targets: Glutinum.Web.NodeList, parameters: Animejs.AnimationParams) : Animejs.JSAnimation = nativeOnly
        [<Import("set", "animejs")>]
        static member set (targets: string, parameters: Animejs.AnimationParams) : Animejs.JSAnimation = nativeOnly
        [<Import("set", "animejs")>]
        static member set (targets: Animejs.TargetsParam, parameters: Animejs.AnimationParams) : Animejs.JSAnimation = nativeOnly
        [<Import("remove", "animejs")>]
        static member remove (targets: ResizeArray<Animejs.TargetSelector>, ?renderable: U2<Animejs.Renderable, Animejs.WAAPIAnimation>, ?propertyName: string) : Animejs.TargetsArray = nativeOnly
        [<Import("remove", "animejs")>]
        static member remove (targets: Glutinum.Web.HTMLElement, ?renderable: U2<Animejs.Renderable, Animejs.WAAPIAnimation>, ?propertyName: string) : Animejs.TargetsArray = nativeOnly
        [<Import("remove", "animejs")>]
        static member remove (targets: Glutinum.Web.SVGElement, ?renderable: U2<Animejs.Renderable, Animejs.WAAPIAnimation>, ?propertyName: string) : Animejs.TargetsArray = nativeOnly
        [<Import("remove", "animejs")>]
        static member remove (targets: Animejs.JSTarget, ?renderable: U2<Animejs.Renderable, Animejs.WAAPIAnimation>, ?propertyName: string) : Animejs.TargetsArray = nativeOnly
        [<Import("remove", "animejs")>]
        static member remove (targets: Glutinum.Web.NodeList, ?renderable: U2<Animejs.Renderable, Animejs.WAAPIAnimation>, ?propertyName: string) : Animejs.TargetsArray = nativeOnly
        [<Import("remove", "animejs")>]
        static member remove (targets: string, ?renderable: U2<Animejs.Renderable, Animejs.WAAPIAnimation>, ?propertyName: string) : Animejs.TargetsArray = nativeOnly
        [<Import("remove", "animejs")>]
        static member remove (targets: Animejs.TargetsParam, ?renderable: U2<Animejs.Renderable, Animejs.WAAPIAnimation>, ?propertyName: string) : Animejs.TargetsArray = nativeOnly
        [<Import("sync", "animejs")>]
        static member sync (?callback: Animejs.Callback<Animejs.Timer>) : Animejs.Timer = nativeOnly
        [<Import("keepTime", "animejs")>]
        static member keepTime (``constructor``: System.Delegate) : System.Delegate = nativeOnly
        /// <param name="targets">
        ///
        /// </param>
        /// <param name="parameters">
        ///
        /// </param>
        [<Import("Animatable", "animejs"); EmitConstructor>]
        static member Animatable (targets: ResizeArray<Animejs.TargetSelector>, parameters: Animejs.AnimatableParams) : Animatable = nativeOnly
        /// <param name="targets">
        ///
        /// </param>
        /// <param name="parameters">
        ///
        /// </param>
        [<Import("Animatable", "animejs"); EmitConstructor>]
        static member Animatable (targets: Glutinum.Web.HTMLElement, parameters: Animejs.AnimatableParams) : Animatable = nativeOnly
        /// <param name="targets">
        ///
        /// </param>
        /// <param name="parameters">
        ///
        /// </param>
        [<Import("Animatable", "animejs"); EmitConstructor>]
        static member Animatable (targets: Glutinum.Web.SVGElement, parameters: Animejs.AnimatableParams) : Animatable = nativeOnly
        /// <param name="targets">
        ///
        /// </param>
        /// <param name="parameters">
        ///
        /// </param>
        [<Import("Animatable", "animejs"); EmitConstructor>]
        static member Animatable (targets: Animejs.JSTarget, parameters: Animejs.AnimatableParams) : Animatable = nativeOnly
        /// <param name="targets">
        ///
        /// </param>
        /// <param name="parameters">
        ///
        /// </param>
        [<Import("Animatable", "animejs"); EmitConstructor>]
        static member Animatable (targets: Glutinum.Web.NodeList, parameters: Animejs.AnimatableParams) : Animatable = nativeOnly
        /// <param name="targets">
        ///
        /// </param>
        /// <param name="parameters">
        ///
        /// </param>
        [<Import("Animatable", "animejs"); EmitConstructor>]
        static member Animatable (targets: string, parameters: Animejs.AnimatableParams) : Animatable = nativeOnly
        /// <param name="targets">
        ///
        /// </param>
        /// <param name="parameters">
        ///
        /// </param>
        [<Import("Animatable", "animejs"); EmitConstructor>]
        static member Animatable (targets: Animejs.TargetsParam, parameters: Animejs.AnimatableParams) : Animatable = nativeOnly
        /// <param name="targets">
        ///
        /// </param>
        /// <param name="parameters">
        ///
        /// </param>
        /// <param name="parent">
        ///
        /// </param>
        /// <param name="parentPosition">
        ///
        /// </param>
        /// <param name="fastSet">
        ///
        /// </param>
        /// <param name="index">
        ///
        /// </param>
        /// <param name="allTargets">
        ///
        /// </param>
        [<Import("JSAnimation", "animejs"); EmitConstructor>]
        static member JSAnimation (targets: ResizeArray<Animejs.TargetSelector>, parameters: Animejs.AnimationParams, ?parent: Animejs.Timeline, ?parentPosition: float, ?fastSet: bool, ?index: float, ?allTargets: Animejs.TargetsArray) : JSAnimation = nativeOnly
        /// <param name="targets">
        ///
        /// </param>
        /// <param name="parameters">
        ///
        /// </param>
        /// <param name="parent">
        ///
        /// </param>
        /// <param name="parentPosition">
        ///
        /// </param>
        /// <param name="fastSet">
        ///
        /// </param>
        /// <param name="index">
        ///
        /// </param>
        /// <param name="allTargets">
        ///
        /// </param>
        [<Import("JSAnimation", "animejs"); EmitConstructor>]
        static member JSAnimation (targets: Glutinum.Web.HTMLElement, parameters: Animejs.AnimationParams, ?parent: Animejs.Timeline, ?parentPosition: float, ?fastSet: bool, ?index: float, ?allTargets: Animejs.TargetsArray) : JSAnimation = nativeOnly
        /// <param name="targets">
        ///
        /// </param>
        /// <param name="parameters">
        ///
        /// </param>
        /// <param name="parent">
        ///
        /// </param>
        /// <param name="parentPosition">
        ///
        /// </param>
        /// <param name="fastSet">
        ///
        /// </param>
        /// <param name="index">
        ///
        /// </param>
        /// <param name="allTargets">
        ///
        /// </param>
        [<Import("JSAnimation", "animejs"); EmitConstructor>]
        static member JSAnimation (targets: Glutinum.Web.SVGElement, parameters: Animejs.AnimationParams, ?parent: Animejs.Timeline, ?parentPosition: float, ?fastSet: bool, ?index: float, ?allTargets: Animejs.TargetsArray) : JSAnimation = nativeOnly
        /// <param name="targets">
        ///
        /// </param>
        /// <param name="parameters">
        ///
        /// </param>
        /// <param name="parent">
        ///
        /// </param>
        /// <param name="parentPosition">
        ///
        /// </param>
        /// <param name="fastSet">
        ///
        /// </param>
        /// <param name="index">
        ///
        /// </param>
        /// <param name="allTargets">
        ///
        /// </param>
        [<Import("JSAnimation", "animejs"); EmitConstructor>]
        static member JSAnimation (targets: Animejs.JSTarget, parameters: Animejs.AnimationParams, ?parent: Animejs.Timeline, ?parentPosition: float, ?fastSet: bool, ?index: float, ?allTargets: Animejs.TargetsArray) : JSAnimation = nativeOnly
        /// <param name="targets">
        ///
        /// </param>
        /// <param name="parameters">
        ///
        /// </param>
        /// <param name="parent">
        ///
        /// </param>
        /// <param name="parentPosition">
        ///
        /// </param>
        /// <param name="fastSet">
        ///
        /// </param>
        /// <param name="index">
        ///
        /// </param>
        /// <param name="allTargets">
        ///
        /// </param>
        [<Import("JSAnimation", "animejs"); EmitConstructor>]
        static member JSAnimation (targets: Glutinum.Web.NodeList, parameters: Animejs.AnimationParams, ?parent: Animejs.Timeline, ?parentPosition: float, ?fastSet: bool, ?index: float, ?allTargets: Animejs.TargetsArray) : JSAnimation = nativeOnly
        /// <param name="targets">
        ///
        /// </param>
        /// <param name="parameters">
        ///
        /// </param>
        /// <param name="parent">
        ///
        /// </param>
        /// <param name="parentPosition">
        ///
        /// </param>
        /// <param name="fastSet">
        ///
        /// </param>
        /// <param name="index">
        ///
        /// </param>
        /// <param name="allTargets">
        ///
        /// </param>
        [<Import("JSAnimation", "animejs"); EmitConstructor>]
        static member JSAnimation (targets: string, parameters: Animejs.AnimationParams, ?parent: Animejs.Timeline, ?parentPosition: float, ?fastSet: bool, ?index: float, ?allTargets: Animejs.TargetsArray) : JSAnimation = nativeOnly
        /// <param name="targets">
        ///
        /// </param>
        /// <param name="parameters">
        ///
        /// </param>
        /// <param name="parent">
        ///
        /// </param>
        /// <param name="parentPosition">
        ///
        /// </param>
        /// <param name="fastSet">
        ///
        /// </param>
        /// <param name="index">
        ///
        /// </param>
        /// <param name="allTargets">
        ///
        /// </param>
        [<Import("JSAnimation", "animejs"); EmitConstructor>]
        static member JSAnimation (targets: Animejs.TargetsParam, parameters: Animejs.AnimationParams, ?parent: Animejs.Timeline, ?parentPosition: float, ?fastSet: bool, ?index: float, ?allTargets: Animejs.TargetsArray) : JSAnimation = nativeOnly
        /// <param name="target">
        ///
        /// </param>
        /// <param name="parameters">
        ///
        /// </param>
        [<Import("Draggable", "animejs"); EmitConstructor>]
        static member Draggable (target: ResizeArray<Animejs.TargetSelector>, ?parameters: Animejs.DraggableParams) : Draggable = nativeOnly
        /// <param name="target">
        ///
        /// </param>
        /// <param name="parameters">
        ///
        /// </param>
        [<Import("Draggable", "animejs"); EmitConstructor>]
        static member Draggable (target: Glutinum.Web.HTMLElement, ?parameters: Animejs.DraggableParams) : Draggable = nativeOnly
        /// <param name="target">
        ///
        /// </param>
        /// <param name="parameters">
        ///
        /// </param>
        [<Import("Draggable", "animejs"); EmitConstructor>]
        static member Draggable (target: Glutinum.Web.SVGElement, ?parameters: Animejs.DraggableParams) : Draggable = nativeOnly
        /// <param name="target">
        ///
        /// </param>
        /// <param name="parameters">
        ///
        /// </param>
        [<Import("Draggable", "animejs"); EmitConstructor>]
        static member Draggable (target: Animejs.JSTarget, ?parameters: Animejs.DraggableParams) : Draggable = nativeOnly
        /// <param name="target">
        ///
        /// </param>
        /// <param name="parameters">
        ///
        /// </param>
        [<Import("Draggable", "animejs"); EmitConstructor>]
        static member Draggable (target: Glutinum.Web.NodeList, ?parameters: Animejs.DraggableParams) : Draggable = nativeOnly
        /// <param name="target">
        ///
        /// </param>
        /// <param name="parameters">
        ///
        /// </param>
        [<Import("Draggable", "animejs"); EmitConstructor>]
        static member Draggable (target: string, ?parameters: Animejs.DraggableParams) : Draggable = nativeOnly
        /// <param name="target">
        ///
        /// </param>
        /// <param name="parameters">
        ///
        /// </param>
        [<Import("Draggable", "animejs"); EmitConstructor>]
        static member Draggable (target: Animejs.TargetsParam, ?parameters: Animejs.DraggableParams) : Draggable = nativeOnly
        /// <param name="parameters">
        ///
        /// </param>
        [<Import("ScrollObserver", "animejs"); EmitConstructor>]
        static member ScrollObserver (?parameters: Animejs.ScrollObserverParams) : ScrollObserver = nativeOnly
        /// <param name="root">
        ///
        /// </param>
        /// <param name="params">
        ///
        /// </param>
        [<Import("AutoLayout", "animejs"); EmitConstructor>]
        static member AutoLayout (root: Glutinum.Web.HTMLElement, ?``params``: Animejs.AutoLayoutParams) : AutoLayout = nativeOnly
        /// <param name="root">
        ///
        /// </param>
        /// <param name="params">
        ///
        /// </param>
        [<Import("AutoLayout", "animejs"); EmitConstructor>]
        static member AutoLayout (root: Glutinum.Web.SVGElement, ?``params``: Animejs.AutoLayoutParams) : AutoLayout = nativeOnly
        /// <param name="root">
        ///
        /// </param>
        /// <param name="params">
        ///
        /// </param>
        [<Import("AutoLayout", "animejs"); EmitConstructor>]
        static member AutoLayout (root: Glutinum.Web.NodeList, ?``params``: Animejs.AutoLayoutParams) : AutoLayout = nativeOnly
        /// <param name="root">
        ///
        /// </param>
        /// <param name="params">
        ///
        /// </param>
        [<Import("AutoLayout", "animejs"); EmitConstructor>]
        static member AutoLayout (root: string, ?``params``: Animejs.AutoLayoutParams) : AutoLayout = nativeOnly
        /// <param name="root">
        ///
        /// </param>
        /// <param name="params">
        ///
        /// </param>
        [<Import("AutoLayout", "animejs"); EmitConstructor>]
        static member AutoLayout (root: Animejs.DOMTargetSelector, ?``params``: Animejs.AutoLayoutParams) : AutoLayout = nativeOnly
        /// <param name="parameters">
        ///
        /// </param>
        [<Import("Scope", "animejs"); EmitConstructor>]
        static member Scope (?parameters: Animejs.ScopeParams) : Scope = nativeOnly
        /// <param name="target">
        ///
        /// </param>
        /// <param name="parameters">
        ///
        /// </param>
        [<Import("TextSplitter", "animejs"); EmitConstructor>]
        static member TextSplitter (target: Glutinum.Web.Element, ?parameters: Animejs.TextSplitterParams) : TextSplitter = nativeOnly
        /// <param name="target">
        ///
        /// </param>
        /// <param name="parameters">
        ///
        /// </param>
        [<Import("TextSplitter", "animejs"); EmitConstructor>]
        static member TextSplitter (target: Glutinum.Web.NodeList, ?parameters: Animejs.TextSplitterParams) : TextSplitter = nativeOnly
        /// <param name="target">
        ///
        /// </param>
        /// <param name="parameters">
        ///
        /// </param>
        [<Import("TextSplitter", "animejs"); EmitConstructor>]
        static member TextSplitter (target: string, ?parameters: Animejs.TextSplitterParams) : TextSplitter = nativeOnly
        /// <param name="target">
        ///
        /// </param>
        /// <param name="parameters">
        ///
        /// </param>
        [<Import("TextSplitter", "animejs"); EmitConstructor>]
        static member TextSplitter (target: ResizeArray<Glutinum.Web.Element>, ?parameters: Animejs.TextSplitterParams) : TextSplitter = nativeOnly
        /// <param name="target">
        ///
        /// </param>
        /// <param name="parameters">
        ///
        /// </param>
        [<Import("TextSplitter", "animejs"); EmitConstructor>]
        static member TextSplitter (target: U4<Glutinum.Web.Element, Glutinum.Web.NodeList, string, ResizeArray<Glutinum.Web.Element>>, ?parameters: Animejs.TextSplitterParams) : TextSplitter = nativeOnly
        /// <param name="parameters">
        ///
        /// </param>
        [<Import("Timeline", "animejs"); EmitConstructor>]
        static member Timeline (?parameters: Animejs.TimelineParams) : Timeline = nativeOnly
        /// <param name="parameters">
        ///
        /// </param>
        /// <param name="parent">
        ///
        /// </param>
        /// <param name="parentPosition">
        ///
        /// </param>
        [<Import("Timer", "animejs"); EmitConstructor>]
        static member Timer (?parameters: Animejs.TimerParams, ?parent: Animejs.Timeline, ?parentPosition: float) : Timer = nativeOnly
        /// <param name="targets">
        ///
        /// </param>
        /// <param name="params">
        ///
        /// </param>
        [<Import("WAAPIAnimation", "animejs"); EmitConstructor>]
        static member WAAPIAnimation (targets: ResizeArray<Animejs.DOMTargetSelector>, ``params``: Animejs.WAAPIAnimationParams) : WAAPIAnimation = nativeOnly
        /// <param name="targets">
        ///
        /// </param>
        /// <param name="params">
        ///
        /// </param>
        [<Import("WAAPIAnimation", "animejs"); EmitConstructor>]
        static member WAAPIAnimation (targets: Glutinum.Web.HTMLElement, ``params``: Animejs.WAAPIAnimationParams) : WAAPIAnimation = nativeOnly
        /// <param name="targets">
        ///
        /// </param>
        /// <param name="params">
        ///
        /// </param>
        [<Import("WAAPIAnimation", "animejs"); EmitConstructor>]
        static member WAAPIAnimation (targets: Glutinum.Web.SVGElement, ``params``: Animejs.WAAPIAnimationParams) : WAAPIAnimation = nativeOnly
        /// <param name="targets">
        ///
        /// </param>
        /// <param name="params">
        ///
        /// </param>
        [<Import("WAAPIAnimation", "animejs"); EmitConstructor>]
        static member WAAPIAnimation (targets: Glutinum.Web.NodeList, ``params``: Animejs.WAAPIAnimationParams) : WAAPIAnimation = nativeOnly
        /// <param name="targets">
        ///
        /// </param>
        /// <param name="params">
        ///
        /// </param>
        [<Import("WAAPIAnimation", "animejs"); EmitConstructor>]
        static member WAAPIAnimation (targets: string, ``params``: Animejs.WAAPIAnimationParams) : WAAPIAnimation = nativeOnly
        /// <param name="targets">
        ///
        /// </param>
        /// <param name="params">
        ///
        /// </param>
        [<Import("WAAPIAnimation", "animejs"); EmitConstructor>]
        static member WAAPIAnimation (targets: Animejs.DOMTargetsParam, ``params``: Animejs.WAAPIAnimationParams) : WAAPIAnimation = nativeOnly
        /// <param name="parameters">
        ///
        /// </param>
        [<Import("Spring", "animejs"); EmitConstructor>]
        static member Spring (?parameters: Animejs.SpringParams) : Spring = nativeOnly

    type Spring =
        Animejs.easings.spring.Spring

    [<AllowNullLiteral>]
    [<Interface>]
    type Animatable =
        abstract member targets: ResizeArray<U3<Glutinum.Web.HTMLElement, Glutinum.Web.SVGElement, Animejs.JSTarget>> with get, set
        abstract member animations: Animatable.animations with get, set
        abstract member callbacks: Animejs.JSAnimation option with get, set
        abstract member revert: unit -> Animatable

    [<AllowNullLiteral>]
    [<Interface>]
    type JSAnimation =
        inherit Animejs.Timer
        abstract member targets: Animejs.TargetsArray with get, set
        abstract member onRender: self: Animejs.Callback<JSAnimation> -> obj
        abstract member _ease: time: float -> float
        /// <param name="newDuration">
        ///
        /// </param>
        abstract member stretch: newDuration: float -> JSAnimation
        abstract member refresh: unit -> JSAnimation
        /// <summary>
        /// Cancel the animation and revert all the values affected by this animation to their original state
        /// </summary>
        abstract member revert: unit -> JSAnimation
        /// <param name="callback">
        ///
        /// </param>
        /// <returns>
        /// Promise<this>
        /// </returns>
        abstract member ``then``: ?callback: Animejs.Callback<obj> -> JS.Promise<obj>

    [<AllowNullLiteral>]
    [<Interface>]
    type Clock =
        abstract member deltaTime: float with get, set
        abstract member _currentTime: float with get, set
        abstract member _lastTickTime: float with get, set
        abstract member _startTime: float with get, set
        abstract member _lastTime: float with get, set
        abstract member _frameDuration: float with get, set
        abstract member _fps: float with get, set
        abstract member _speed: float with get, set
        abstract member _hasChildren: bool with get, set
        abstract member _head: U2<Animejs.Tickable, Animejs.Tween> with get, set
        abstract member _tail: U2<Animejs.Tickable, Animejs.Tween> with get, set
        abstract member fps: float with get, set
        abstract member speed: float with get, set
        /// <param name="time">
        ///
        /// </param>
        abstract member requestTick: time: float -> Animejs.dist.modules.core.consts.tickModes
        /// <param name="time">
        ///
        /// </param>
        abstract member computeDeltaTime: time: float -> float

    /// <summary>
    /// /**
    /// </summary>
    type AnimeJSWindow =
        obj option

    [<AllowNullLiteral>]
    [<Interface>]
    type EditorGlobals =
        abstract member showPanel: bool with get, set
        abstract member addAnimation: Action with get, set
        abstract member addSet: Action with get, set
        abstract member addTimeline: Action with get, set
        abstract member addTimelineChild: Action with get, set
        abstract member addTimelineLabel: Action with get, set
        abstract member addTimelineCall: Action with get, set
        abstract member addTimelineSync: Action with get, set
        abstract member resolveStagger: Action with get, set
        abstract member _head: obj option with get, set
        abstract member _tail: obj option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type Draggable =
        abstract member containerArray: ResizeArray<float> with get, set
        abstract member ``$container``: Glutinum.Web.HTMLElement with get, set
        abstract member useWin: bool with get, set
        abstract member ``$scrollContainer``: U2<Glutinum.Web.Window, Glutinum.Web.HTMLElement> with get, set
        abstract member ``$target``: Glutinum.Web.HTMLElement with get, set
        abstract member ``$trigger``: Glutinum.Web.HTMLElement with get, set
        abstract member ``fixed``: bool with get, set
        abstract member isFinePointer: bool with get, set
        abstract member containerPadding: float * float * float * float with get, set
        abstract member containerFriction: float with get, set
        abstract member releaseContainerFriction: float with get, set
        abstract member snapX: U2<float, ResizeArray<float>> with get, set
        abstract member snapY: U2<float, ResizeArray<float>> with get, set
        abstract member scrollSpeed: float with get, set
        abstract member scrollThreshold: float with get, set
        abstract member dragSpeed: float with get, set
        abstract member dragThreshold: float with get, set
        abstract member maxVelocity: float with get, set
        abstract member minVelocity: float with get, set
        abstract member velocityMultiplier: float with get, set
        abstract member cursor: U2<bool, Animejs.DraggableCursorParams> with get, set
        abstract member releaseXSpring: Animejs.easings.spring.Spring with get, set
        abstract member releaseYSpring: Animejs.easings.spring.Spring with get, set
        abstract member releaseEase: time: float -> float
        abstract member hasReleaseSpring: bool with get, set
        abstract member onGrab: self: Animejs.Callback<Draggable> -> obj
        abstract member onDrag: self: Animejs.Callback<Draggable> -> obj
        abstract member onRelease: self: Animejs.Callback<Draggable> -> obj
        abstract member onUpdate: self: Animejs.Callback<Draggable> -> obj
        abstract member onSettle: self: Animejs.Callback<Draggable> -> obj
        abstract member onSnap: self: Animejs.Callback<Draggable> -> obj
        abstract member onResize: self: Animejs.Callback<Draggable> -> obj
        abstract member onAfterResize: self: Animejs.Callback<Draggable> -> obj
        abstract member disabled: float * float with get, set
        abstract member animate: Animejs.AnimatableObject with get, set
        abstract member xProp: string with get, set
        abstract member yProp: string with get, set
        abstract member destX: float with get, set
        abstract member destY: float with get, set
        abstract member deltaX: float with get, set
        abstract member deltaY: float with get, set
        abstract member scroll: Draggable.scroll with get, set
        abstract member coords: float * float * float * float with get, set
        abstract member snapped: float * float with get, set
        abstract member pointer: float * float * float * float * float * float * float * float with get, set
        abstract member scrollView: float * float with get, set
        abstract member dragArea: float * float * float * float with get, set
        abstract member containerBounds: float * float * float * float with get, set
        abstract member scrollBounds: float * float * float * float with get, set
        abstract member targetBounds: float * float * float * float with get, set
        abstract member window: float * float with get, set
        abstract member velocityStack: float * float * float with get, set
        abstract member velocityStackIndex: float with get, set
        abstract member velocityTime: float with get, set
        abstract member velocity: float with get, set
        abstract member angle: float with get, set
        abstract member cursorStyles: Animejs.JSAnimation with get, set
        abstract member triggerStyles: Animejs.JSAnimation with get, set
        abstract member bodyStyles: Animejs.JSAnimation with get, set
        abstract member targetStyles: Animejs.JSAnimation with get, set
        abstract member touchActionStyles: Animejs.JSAnimation with get, set
        abstract member transforms: Animejs.dist.modules.draggable.draggable.Transforms with get, set
        abstract member overshootCoords: Draggable.overshootCoords with get, set
        abstract member overshootTicker: Animejs.Timer with get, set
        abstract member updated: bool with get, set
        abstract member manual: bool with get, set
        abstract member updateTicker: Animejs.Timer with get, set
        abstract member contained: bool with get, set
        abstract member grabbed: bool with get, set
        abstract member dragged: bool with get, set
        abstract member released: bool with get, set
        abstract member canScroll: bool with get, set
        abstract member enabled: bool with get, set
        abstract member initialized: bool with get, set
        abstract member activeProp: string with get, set
        abstract member resizeTicker: Animejs.Timer with get, set
        abstract member parameters: Animejs.DraggableParams with get, set
        abstract member resizeObserver: Glutinum.Web.ResizeObserver with get, set
        /// <param name="dx">
        ///
        /// </param>
        /// <param name="dy">
        ///
        /// </param>
        abstract member computeVelocity: dx: float * dy: float -> float
        /// <param name="x">
        ///
        /// </param>
        /// <param name="muteUpdateCallback">
        ///
        /// </param>
        abstract member setX: x: float * ?muteUpdateCallback: bool -> Draggable
        /// <param name="y">
        ///
        /// </param>
        /// <param name="muteUpdateCallback">
        ///
        /// </param>
        abstract member setY: y: float * ?muteUpdateCallback: bool -> Draggable
        abstract member x: float with get, set
        abstract member y: float with get, set
        abstract member progressX: float with get, set
        abstract member progressY: float with get, set
        abstract member updateScrollCoords: unit -> unit
        abstract member updateBoundingValues: unit -> unit
        /// <param name="bounds">
        ///
        /// </param>
        /// <param name="x">
        ///
        /// </param>
        /// <param name="y">
        ///
        /// </param>
        abstract member isOutOfBounds: bounds: ResizeArray<obj> * x: float * y: float -> float
        abstract member refresh: unit -> unit
        abstract member update: unit -> unit
        abstract member stop: unit -> Draggable
        /// <param name="duration">
        ///
        /// </param>
        /// <param name="gap">
        ///
        /// </param>
        /// <param name="ease">
        ///
        /// </param>
        abstract member scrollInView: ?duration: float * ?gap: float * ?ease: Animejs.EasingParam -> Draggable
        abstract member handleHover: unit -> unit
        /// <param name="duration">
        ///
        /// </param>
        /// <param name="gap">
        ///
        /// </param>
        /// <param name="ease">
        ///
        /// </param>
        abstract member animateInView: ?duration: float * ?gap: float * ?ease: Animejs.EasingParam -> Draggable
        /// <param name="e">
        ///
        /// </param>
        abstract member handleDown: e: Glutinum.Web.MouseEvent -> unit
        /// <param name="e">
        ///
        /// </param>
        abstract member handleDown: e: Glutinum.Web.TouchEvent -> unit
        /// <param name="e">
        ///
        /// </param>
        abstract member handleDown: e: U2<Glutinum.Web.MouseEvent, Glutinum.Web.TouchEvent> -> unit
        /// <param name="e">
        ///
        /// </param>
        abstract member handleMove: e: Glutinum.Web.MouseEvent -> unit
        /// <param name="e">
        ///
        /// </param>
        abstract member handleMove: e: Glutinum.Web.TouchEvent -> unit
        /// <param name="e">
        ///
        /// </param>
        abstract member handleMove: e: U2<Glutinum.Web.MouseEvent, Glutinum.Web.TouchEvent> -> unit
        abstract member handleUp: unit -> unit
        abstract member reset: unit -> Draggable
        abstract member enable: unit -> Draggable
        abstract member disable: unit -> Draggable
        abstract member revert: unit -> Draggable
        /// <param name="e">
        ///
        /// </param>
        abstract member handleEvent: e: Glutinum.Web.Event -> unit

    type EaseType =
        delegate of Ease: Animejs.EasingFunction -> Animejs.EasingFunction

    [<AllowNullLiteral>]
    [<Interface>]
    type EasesFunctions =
        abstract member linear: Animejs.EasingFunction with get, set
        abstract member none: Animejs.EasingFunction with get, set
        abstract member ``in``: Animejs.PowerEasing with get, set
        abstract member out: Animejs.PowerEasing with get, set
        abstract member inOut: Animejs.PowerEasing with get, set
        abstract member outIn: Animejs.PowerEasing with get, set
        abstract member inQuad: Animejs.EasingFunction with get, set
        abstract member outQuad: Animejs.EasingFunction with get, set
        abstract member inOutQuad: Animejs.EasingFunction with get, set
        abstract member outInQuad: Animejs.EasingFunction with get, set
        abstract member inCubic: Animejs.EasingFunction with get, set
        abstract member outCubic: Animejs.EasingFunction with get, set
        abstract member inOutCubic: Animejs.EasingFunction with get, set
        abstract member outInCubic: Animejs.EasingFunction with get, set
        abstract member inQuart: Animejs.EasingFunction with get, set
        abstract member outQuart: Animejs.EasingFunction with get, set
        abstract member inOutQuart: Animejs.EasingFunction with get, set
        abstract member outInQuart: Animejs.EasingFunction with get, set
        abstract member inQuint: Animejs.EasingFunction with get, set
        abstract member outQuint: Animejs.EasingFunction with get, set
        abstract member inOutQuint: Animejs.EasingFunction with get, set
        abstract member outInQuint: Animejs.EasingFunction with get, set
        abstract member inSine: Animejs.EasingFunction with get, set
        abstract member outSine: Animejs.EasingFunction with get, set
        abstract member inOutSine: Animejs.EasingFunction with get, set
        abstract member outInSine: Animejs.EasingFunction with get, set
        abstract member inCirc: Animejs.EasingFunction with get, set
        abstract member outCirc: Animejs.EasingFunction with get, set
        abstract member inOutCirc: Animejs.EasingFunction with get, set
        abstract member outInCirc: Animejs.EasingFunction with get, set
        abstract member inExpo: Animejs.EasingFunction with get, set
        abstract member outExpo: Animejs.EasingFunction with get, set
        abstract member inOutExpo: Animejs.EasingFunction with get, set
        abstract member outInExpo: Animejs.EasingFunction with get, set
        abstract member inBounce: Animejs.EasingFunction with get, set
        abstract member outBounce: Animejs.EasingFunction with get, set
        abstract member inOutBounce: Animejs.EasingFunction with get, set
        abstract member outInBounce: Animejs.EasingFunction with get, set
        abstract member inBack: Animejs.BackEasing with get, set
        abstract member outBack: Animejs.BackEasing with get, set
        abstract member inOutBack: Animejs.BackEasing with get, set
        abstract member outInBack: Animejs.BackEasing with get, set
        abstract member inElastic: Animejs.ElasticEasing with get, set
        abstract member outElastic: Animejs.ElasticEasing with get, set
        abstract member inOutElastic: Animejs.ElasticEasing with get, set
        abstract member outInElastic: Animejs.ElasticEasing with get, set

    [<AutoOpen>]
    module EasesFunctionsExtensions =

        type EasesFunctions with
            member inline this.linear(time: float) : float =
                this.linear.Invoke(time)
            member inline this.none(time: float) : float =
                this.none.Invoke(time)
            member inline this.inQuad(time: float) : float =
                this.inQuad.Invoke(time)
            member inline this.outQuad(time: float) : float =
                this.outQuad.Invoke(time)
            member inline this.inOutQuad(time: float) : float =
                this.inOutQuad.Invoke(time)
            member inline this.outInQuad(time: float) : float =
                this.outInQuad.Invoke(time)
            member inline this.inCubic(time: float) : float =
                this.inCubic.Invoke(time)
            member inline this.outCubic(time: float) : float =
                this.outCubic.Invoke(time)
            member inline this.inOutCubic(time: float) : float =
                this.inOutCubic.Invoke(time)
            member inline this.outInCubic(time: float) : float =
                this.outInCubic.Invoke(time)
            member inline this.inQuart(time: float) : float =
                this.inQuart.Invoke(time)
            member inline this.outQuart(time: float) : float =
                this.outQuart.Invoke(time)
            member inline this.inOutQuart(time: float) : float =
                this.inOutQuart.Invoke(time)
            member inline this.outInQuart(time: float) : float =
                this.outInQuart.Invoke(time)
            member inline this.inQuint(time: float) : float =
                this.inQuint.Invoke(time)
            member inline this.outQuint(time: float) : float =
                this.outQuint.Invoke(time)
            member inline this.inOutQuint(time: float) : float =
                this.inOutQuint.Invoke(time)
            member inline this.outInQuint(time: float) : float =
                this.outInQuint.Invoke(time)
            member inline this.inSine(time: float) : float =
                this.inSine.Invoke(time)
            member inline this.outSine(time: float) : float =
                this.outSine.Invoke(time)
            member inline this.inOutSine(time: float) : float =
                this.inOutSine.Invoke(time)
            member inline this.outInSine(time: float) : float =
                this.outInSine.Invoke(time)
            member inline this.inCirc(time: float) : float =
                this.inCirc.Invoke(time)
            member inline this.outCirc(time: float) : float =
                this.outCirc.Invoke(time)
            member inline this.inOutCirc(time: float) : float =
                this.inOutCirc.Invoke(time)
            member inline this.outInCirc(time: float) : float =
                this.outInCirc.Invoke(time)
            member inline this.inExpo(time: float) : float =
                this.inExpo.Invoke(time)
            member inline this.outExpo(time: float) : float =
                this.outExpo.Invoke(time)
            member inline this.inOutExpo(time: float) : float =
                this.inOutExpo.Invoke(time)
            member inline this.outInExpo(time: float) : float =
                this.outInExpo.Invoke(time)
            member inline this.inBounce(time: float) : float =
                this.inBounce.Invoke(time)
            member inline this.outBounce(time: float) : float =
                this.outBounce.Invoke(time)
            member inline this.inOutBounce(time: float) : float =
                this.inOutBounce.Invoke(time)
            member inline this.outInBounce(time: float) : float =
                this.outInBounce.Invoke(time)

    [<AllowNullLiteral>]
    [<Interface>]
    type ScrollObserver =
        abstract member index: float with get, set
        abstract member id: U2<string, float> with get, set
        abstract member container: Animejs.dist.modules.events.scroll.ScrollContainer with get, set
        abstract member target: Glutinum.Web.HTMLElement with get, set
        abstract member linked: U2<Animejs.Tickable, Animejs.WAAPIAnimation> with get, set
        abstract member repeat: bool with get, set
        abstract member horizontal: bool with get, set
        abstract member enter: U3<Animejs.ScrollThresholdParam, Animejs.ScrollThresholdValue, Animejs.ScrollThresholdCallback> with get, set
        abstract member leave: U3<Animejs.ScrollThresholdParam, Animejs.ScrollThresholdValue, Animejs.ScrollThresholdCallback> with get, set
        abstract member sync: bool with get, set
        abstract member syncEase: time: float -> float
        abstract member syncSmooth: float with get, set
        abstract member onSyncEnter: self: Animejs.ScrollObserver -> obj
        abstract member onSyncLeave: self: Animejs.ScrollObserver -> obj
        abstract member onSyncEnterForward: self: Animejs.ScrollObserver -> obj
        abstract member onSyncLeaveForward: self: Animejs.ScrollObserver -> obj
        abstract member onSyncEnterBackward: self: Animejs.ScrollObserver -> obj
        abstract member onSyncLeaveBackward: self: Animejs.ScrollObserver -> obj
        abstract member onEnter: self: Animejs.ScrollObserver -> obj
        abstract member onLeave: self: Animejs.ScrollObserver -> obj
        abstract member onEnterForward: self: Animejs.ScrollObserver -> obj
        abstract member onLeaveForward: self: Animejs.ScrollObserver -> obj
        abstract member onEnterBackward: self: Animejs.ScrollObserver -> obj
        abstract member onLeaveBackward: self: Animejs.ScrollObserver -> obj
        abstract member onUpdate: self: Animejs.ScrollObserver -> obj
        abstract member onResize: self: Animejs.ScrollObserver -> obj
        abstract member onSyncComplete: self: Animejs.ScrollObserver -> obj
        abstract member reverted: bool with get, set
        abstract member ready: bool with get, set
        abstract member completed: bool with get, set
        abstract member began: bool with get, set
        abstract member isInView: bool with get, set
        abstract member forceEnter: bool with get, set
        abstract member hasEntered: bool with get, set
        abstract member offset: float with get, set
        abstract member offsetStart: float with get, set
        abstract member offsetEnd: float with get, set
        abstract member distance: float with get, set
        abstract member prevProgress: float with get, set
        abstract member thresholds: ResizeArray<obj> with get, set
        abstract member coords: float * float * float * float with get, set
        abstract member debugStyles: Animejs.JSAnimation with get, set
        abstract member ``$debug``: Glutinum.Web.HTMLElement with get, set
        abstract member _params: Animejs.ScrollObserverParams with get, set
        abstract member _debug: bool with get, set
        abstract member _next: Animejs.ScrollObserver with get, set
        abstract member _prev: Animejs.ScrollObserver with get, set
        /// <param name="linked">
        ///
        /// </param>
        abstract member link: linked: Animejs.Timer -> ScrollObserver
        /// <param name="linked">
        ///
        /// </param>
        abstract member link: linked: Animejs.JSAnimation -> ScrollObserver
        /// <param name="linked">
        ///
        /// </param>
        abstract member link: linked: Animejs.Timeline -> ScrollObserver
        /// <param name="linked">
        ///
        /// </param>
        abstract member link: linked: Animejs.WAAPIAnimation -> ScrollObserver
        /// <param name="linked">
        ///
        /// </param>
        abstract member link: linked: U2<Animejs.Tickable, Animejs.WAAPIAnimation> -> ScrollObserver
        abstract member velocity: float with get
        abstract member backward: bool with get
        abstract member scroll: float with get
        abstract member progress: float with get
        abstract member refresh: unit -> ScrollObserver
        abstract member removeDebug: unit -> ScrollObserver
        abstract member debug: unit -> unit
        abstract member updateBounds: unit -> unit
        abstract member handleScroll: unit -> unit
        abstract member revert: unit -> ScrollObserver

    [<AllowNullLiteral>]
    [<Interface>]
    type AutoLayout =
        abstract member ``params``: Animejs.AutoLayoutParams with get, set
        abstract member root: Animejs.DOMTarget with get, set
        abstract member id: U2<float, string> with get, set
        abstract member children: Animejs.LayoutChildrenParam with get, set
        abstract member absoluteCoords: bool with get, set
        abstract member swapAtParams: Animejs.LayoutStateParams with get, set
        abstract member enterFromParams: Animejs.LayoutStateParams with get, set
        abstract member leaveToParams: Animejs.LayoutStateParams with get, set
        abstract member properties: obj with get, set
        abstract member recordedProperties: obj with get, set
        abstract member pendingRemoval: obj with get, set
        abstract member transitionMuteStore: obj with get, set
        abstract member oldState: Animejs.dist.modules.layout.layout.LayoutSnapshot with get, set
        abstract member newState: Animejs.dist.modules.layout.layout.LayoutSnapshot with get, set
        abstract member timeline: Animejs.Timeline with get, set
        abstract member transformAnimation: Animejs.WAAPIAnimation with get, set
        abstract member animating: ResizeArray<Animejs.DOMTarget> with get, set
        abstract member swapping: ResizeArray<Animejs.DOMTarget> with get, set
        abstract member leaving: ResizeArray<Animejs.DOMTarget> with get, set
        abstract member entering: ResizeArray<Animejs.DOMTarget> with get, set
        abstract member revert: unit -> AutoLayout
        abstract member record: unit -> AutoLayout
        /// <param name="params">
        ///
        /// </param>
        abstract member animate: ?``params``: Animejs.LayoutAnimationParams -> Animejs.Timeline
        /// <param name="callback">
        ///
        /// </param>
        /// <param name="params">
        ///
        /// </param>
        abstract member update: callback: (AutoLayout -> unit) * ?``params``: Animejs.LayoutAnimationParams -> Animejs.Timeline

    type LayoutChildrenParam =
        U2<Animejs.DOMTargetSelector, ResizeArray<Animejs.DOMTargetSelector>>

    [<AllowNullLiteral>]
    [<Interface>]
    type LayoutAnimationTimingsParams =
        abstract member delay: U2<float, Animejs.FunctionValue> option with get, set
        abstract member duration: U2<float, Animejs.FunctionValue> option with get, set
        abstract member ease: U2<Animejs.EasingParam, Animejs.FunctionValue> option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type LayoutStateAnimationProperties =
        [<EmitIndexer>]
        abstract member Item: key: string -> U3<float, string, Animejs.FunctionValue> with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type LayoutStateParams =
        abstract member delay: U2<float, Animejs.FunctionValue> option with get, set
        abstract member duration: U2<float, Animejs.FunctionValue> option with get, set
        abstract member ease: U2<Animejs.EasingParam, Animejs.FunctionValue> option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type LayoutSpecificAnimationParams =
        abstract member id: U2<float, string> option with get, set
        abstract member delay: U2<float, Animejs.FunctionValue> option with get, set
        abstract member duration: U2<float, Animejs.FunctionValue> option with get, set
        abstract member ease: U2<Animejs.EasingParam, Animejs.FunctionValue> option with get, set
        abstract member playbackEase: Animejs.EasingParam option with get, set
        abstract member swapAt: Animejs.LayoutStateParams option with get, set
        abstract member enterFrom: Animejs.LayoutStateParams option with get, set
        abstract member leaveTo: Animejs.LayoutStateParams option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type LayoutAnimationParams =
        abstract member id: U2<string, float> option with get, set
        abstract member delay: obj option with get, set
        abstract member duration: obj option with get, set
        abstract member ease: U2<Animejs.EasingParam, Animejs.FunctionValue> option with get, set
        abstract member playbackEase: Animejs.EasingParam option with get, set
        abstract member swapAt: Animejs.LayoutStateParams option with get, set
        abstract member enterFrom: Animejs.LayoutStateParams option with get, set
        abstract member leaveTo: Animejs.LayoutStateParams option with get, set
        abstract member loopDelay: float option with get, set
        abstract member reversed: bool option with get, set
        abstract member alternate: bool option with get, set
        abstract member loop: U2<bool, float> option with get, set
        abstract member autoplay: U2<bool, Animejs.ScrollObserver> option with get, set
        abstract member frameRate: float option with get, set
        abstract member playbackRate: float option with get, set
        abstract member priority: float option with get, set
        abstract member onBegin: obj option with get, set
        abstract member onBeforeUpdate: obj option with get, set
        abstract member onUpdate: obj option with get, set
        abstract member onLoop: obj option with get, set
        abstract member onPause: obj option with get, set
        abstract member onComplete: obj option with get, set
        abstract member onRender: (Animejs.Timeline -> unit) option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type LayoutOptions =
        abstract member children: Animejs.LayoutChildrenParam option with get, set
        abstract member properties: ResizeArray<string> option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type AutoLayoutParams =
        abstract member id: U2<string, float> option with get, set
        abstract member delay: obj option with get, set
        abstract member duration: obj option with get, set
        abstract member ease: U2<Animejs.EasingParam, Animejs.FunctionValue> option with get, set
        abstract member playbackEase: Animejs.EasingParam option with get, set
        abstract member swapAt: Animejs.LayoutStateParams option with get, set
        abstract member enterFrom: Animejs.LayoutStateParams option with get, set
        abstract member leaveTo: Animejs.LayoutStateParams option with get, set
        abstract member loopDelay: float option with get, set
        abstract member reversed: bool option with get, set
        abstract member alternate: bool option with get, set
        abstract member loop: U2<bool, float> option with get, set
        abstract member autoplay: U2<bool, Animejs.ScrollObserver> option with get, set
        abstract member frameRate: float option with get, set
        abstract member playbackRate: float option with get, set
        abstract member priority: float option with get, set
        abstract member onBegin: obj option with get, set
        abstract member onBeforeUpdate: obj option with get, set
        abstract member onUpdate: obj option with get, set
        abstract member onLoop: obj option with get, set
        abstract member onPause: obj option with get, set
        abstract member onComplete: obj option with get, set
        abstract member onRender: (Animejs.Timeline -> unit) option with get, set
        abstract member children: Animejs.LayoutChildrenParam option with get, set
        abstract member properties: ResizeArray<string> option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type LayoutNodeProperties =
        abstract member transform: string with get, set
        abstract member x: float with get, set
        abstract member y: float with get, set
        abstract member left: float with get, set
        abstract member top: float with get, set
        abstract member clientLeft: float with get, set
        abstract member clientTop: float with get, set
        abstract member width: float with get, set
        abstract member height: float with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type LayoutNode =
        abstract member id: string with get, set
        abstract member ``$el``: Animejs.DOMTarget with get, set
        abstract member index: float with get, set
        abstract member targets: ResizeArray<Animejs.DOMTarget> with get, set
        abstract member delay: float with get, set
        abstract member duration: float with get, set
        abstract member ease: Animejs.EasingParam with get, set
        abstract member ``$measure``: Animejs.DOMTarget with get, set
        abstract member state: Animejs.dist.modules.layout.layout.LayoutSnapshot with get, set
        abstract member layout: Animejs.AutoLayout with get, set
        abstract member parentNode: Animejs.LayoutNode option with get, set
        abstract member isTarget: bool with get, set
        abstract member isEntering: bool with get, set
        abstract member isLeaving: bool with get, set
        abstract member hasTransform: bool with get, set
        abstract member inlineStyles: ResizeArray<string> with get, set
        abstract member inlineTransforms: string option with get, set
        abstract member inlineTransition: string option with get, set
        abstract member branchAdded: bool with get, set
        abstract member branchRemoved: bool with get, set
        abstract member branchNotRendered: bool with get, set
        abstract member sizeChanged: bool with get, set
        abstract member isInlined: bool with get, set
        abstract member hasVisibilitySwap: bool with get, set
        abstract member hasDisplayNone: bool with get, set
        abstract member hasVisibilityHidden: bool with get, set
        abstract member measuredInlineTransform: string option with get, set
        abstract member measuredInlineTransition: string option with get, set
        abstract member measuredDisplay: string option with get, set
        abstract member measuredVisibility: string option with get, set
        abstract member measuredPosition: string option with get, set
        abstract member measuredHasDisplayNone: bool with get, set
        abstract member measuredHasVisibilityHidden: bool with get, set
        abstract member measuredIsVisible: bool with get, set
        abstract member measuredIsRemoved: bool with get, set
        abstract member measuredIsInsideRoot: bool with get, set
        abstract member properties: Animejs.LayoutNodeProperties with get, set
        abstract member _head: Animejs.LayoutNode option with get, set
        abstract member _tail: Animejs.LayoutNode option with get, set
        abstract member _prev: Animejs.LayoutNode option with get, set
        abstract member _next: Animejs.LayoutNode option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (id: string, ``$el``: Animejs.DOMTarget, index: float, targets: ResizeArray<Animejs.DOMTarget>, delay: float, duration: float, ease: Animejs.EasingParam, ``$measure``: Animejs.DOMTarget, state: Animejs.dist.modules.layout.layout.LayoutSnapshot, layout: Animejs.AutoLayout, isTarget: bool, isEntering: bool, isLeaving: bool, hasTransform: bool, inlineStyles: ResizeArray<string>, branchAdded: bool, branchRemoved: bool, branchNotRendered: bool, sizeChanged: bool, isInlined: bool, hasVisibilitySwap: bool, hasDisplayNone: bool, hasVisibilityHidden: bool, measuredHasDisplayNone: bool, measuredHasVisibilityHidden: bool, measuredIsVisible: bool, measuredIsRemoved: bool, measuredIsInsideRoot: bool, properties: Animejs.LayoutNodeProperties, ?parentNode: Animejs.LayoutNode, ?inlineTransforms: string, ?inlineTransition: string, ?measuredInlineTransform: string, ?measuredInlineTransition: string, ?measuredDisplay: string, ?measuredVisibility: string, ?measuredPosition: string, ?_head: Animejs.LayoutNode, ?_tail: Animejs.LayoutNode, ?_prev: Animejs.LayoutNode, ?_next: Animejs.LayoutNode) : LayoutNode = nativeOnly

    type LayoutNodeIterator =
        delegate of node: Animejs.LayoutNode * index: float -> unit

    [<AllowNullLiteral>]
    [<Interface>]
    type Scope =
        abstract member defaults: Animejs.DefaultsParams with get, set
        abstract member root: U2<Glutinum.Web.Document, Animejs.DOMTarget> with get, set
        abstract member constructors: ResizeArray<Animejs.ScopeConstructorCallback> with get, set
        abstract member revertConstructors: ResizeArray<Animejs.ScopeCleanupCallback> with get, set
        abstract member revertibles: ResizeArray<Animejs.Revertible> with get, set
        abstract member constructorsOnce: ResizeArray<U2<Animejs.ScopeConstructorCallback, (Scope -> Animejs.Tickable)>> with get, set
        abstract member revertConstructorsOnce: ResizeArray<Animejs.ScopeCleanupCallback> with get, set
        abstract member revertiblesOnce: ResizeArray<Animejs.Revertible> with get, set
        abstract member once: bool with get, set
        abstract member onceIndex: float with get, set
        abstract member methods: Scope.methods with get, set
        abstract member matches: Scope.matches with get, set
        abstract member mediaQueryLists: Scope.mediaQueryLists with get, set
        abstract member data: obj with get, set
        /// <param name="revertible">
        ///
        /// </param>
        abstract member register: revertible: Animejs.Revertible -> unit
        /// <param name="cb">
        ///
        /// </param>
        abstract member execute<'T>: cb: Animejs.ScopedCallback<'T> -> 'T
        abstract member refresh: unit -> Scope
        /// <param name="a1">
        ///
        /// </param>
        /// <param name="a2">
        ///
        /// </param>
        abstract member add: a1: string * a2: Animejs.ScopeMethod -> Scope
        /// <param name="a1">
        ///
        /// </param>
        /// <param name="a2">
        ///
        /// </param>
        abstract member add: a1: Animejs.ScopeConstructorCallback -> Scope
        /// <param name="scopeConstructorCallback">
        ///
        /// </param>
        abstract member addOnce: scopeConstructorCallback: Animejs.ScopeConstructorCallback -> Scope
        /// <param name="cb">
        ///
        /// </param>
        abstract member keepTime: cb: (Scope -> Animejs.Tickable) -> Animejs.Tickable
        /// <param name="e">
        ///
        /// </param>
        abstract member handleEvent: e: Glutinum.Web.Event -> unit
        abstract member revert: unit -> unit

    [<AllowNullLiteral>]
    [<Interface>]
    type ScrambleTextTween =
        abstract member from: float with get, set
        abstract member ``to``: float with get, set
        abstract member duration: float with get, set
        abstract member delay: float with get, set
        abstract member ease: string with get, set
        abstract member modifier: (float -> string) with get, set

    /// <summary>
    /// A class that splits text into words and wraps them in span elements while preserving the original HTML structure.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type TextSplitter =
        abstract member debug: bool with get, set
        abstract member includeSpaces: bool with get, set
        abstract member accessible: bool with get, set
        abstract member linesOnly: bool with get, set
        abstract member lineTemplate: U3<string, bool, Animejs.SplitFunctionValue> with get, set
        abstract member wordTemplate: U3<string, bool, Animejs.SplitFunctionValue> with get, set
        abstract member charTemplate: U3<string, bool, Animejs.SplitFunctionValue> with get, set
        abstract member ``$target``: Glutinum.Web.HTMLElement with get, set
        abstract member html: string with get, set
        abstract member lines: ResizeArray<obj> with get, set
        abstract member words: ResizeArray<obj> with get, set
        abstract member chars: ResizeArray<obj> with get, set
        abstract member effects: ResizeArray<obj> with get, set
        abstract member effectsCleanups: ResizeArray<obj> with get, set
        abstract member cache: string with get, set
        abstract member ready: bool with get, set
        abstract member width: float with get, set
        abstract member resizeTimeout: obj with get, set
        abstract member resizeObserver: Glutinum.Web.ResizeObserver with get, set
        /// <param name="effect">
        ///
        /// </param>
        /// <returns>
        /// this
        /// </returns>
        abstract member addEffect: effect: System.Delegate -> TextSplitter
        abstract member revert: unit -> TextSplitter
        /// <summary>
        /// Recursively processes a node and its children
        /// </summary>
        /// <param name="node">
        ///
        /// </param>
        abstract member splitNode: node: Glutinum.Web.Node -> unit
        /// <param name="clearCache">
        ///
        /// </param>
        abstract member split: ?clearCache: bool -> TextSplitter
        abstract member refresh: unit -> unit

    [<AllowNullLiteral>]
    [<Interface>]
    type Segment =
        abstract member segment: string with get, set
        abstract member isWordLike: bool option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type Segmenter =
        abstract member segment: (string -> Iterable<Animejs.Segment>) with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type Timeline =
        inherit Animejs.Timer
        abstract member labels: Timeline.labels with get, set
        abstract member defaults: Animejs.DefaultsParams with get, set
        abstract member composition: bool with get, set
        abstract member onRender: self: Animejs.Callback<Timeline> -> obj
        abstract member _ease: time: float -> float
        /// <param name="a1">
        ///
        /// </param>
        /// <param name="a2">
        ///
        /// </param>
        /// <param name="a3">
        ///
        /// </param>
        abstract member add: a1: ResizeArray<Animejs.TargetSelector> * a2: Animejs.AnimationParams * ?a3: U3<Animejs.TimelinePosition, Animejs.StaggerFunction<U2<float, string>>, Animejs.TweakRegister> -> Timeline
        /// <param name="a1">
        ///
        /// </param>
        /// <param name="a2">
        ///
        /// </param>
        /// <param name="a3">
        ///
        /// </param>
        abstract member add: a1: Glutinum.Web.HTMLElement * a2: Animejs.AnimationParams * ?a3: U3<Animejs.TimelinePosition, Animejs.StaggerFunction<U2<float, string>>, Animejs.TweakRegister> -> Timeline
        /// <param name="a1">
        ///
        /// </param>
        /// <param name="a2">
        ///
        /// </param>
        /// <param name="a3">
        ///
        /// </param>
        abstract member add: a1: Glutinum.Web.SVGElement * a2: Animejs.AnimationParams * ?a3: U3<Animejs.TimelinePosition, Animejs.StaggerFunction<U2<float, string>>, Animejs.TweakRegister> -> Timeline
        /// <param name="a1">
        ///
        /// </param>
        /// <param name="a2">
        ///
        /// </param>
        /// <param name="a3">
        ///
        /// </param>
        abstract member add: a1: Animejs.JSTarget * a2: Animejs.AnimationParams * ?a3: U3<Animejs.TimelinePosition, Animejs.StaggerFunction<U2<float, string>>, Animejs.TweakRegister> -> Timeline
        /// <param name="a1">
        ///
        /// </param>
        /// <param name="a2">
        ///
        /// </param>
        /// <param name="a3">
        ///
        /// </param>
        abstract member add: a1: Glutinum.Web.NodeList * a2: Animejs.AnimationParams * ?a3: U3<Animejs.TimelinePosition, Animejs.StaggerFunction<U2<float, string>>, Animejs.TweakRegister> -> Timeline
        /// <param name="a1">
        ///
        /// </param>
        /// <param name="a2">
        ///
        /// </param>
        /// <param name="a3">
        ///
        /// </param>
        abstract member add: a1: string * a2: Animejs.AnimationParams * ?a3: U3<Animejs.TimelinePosition, Animejs.StaggerFunction<U2<float, string>>, Animejs.TweakRegister> -> Timeline
        /// <param name="a1">
        ///
        /// </param>
        /// <param name="a2">
        ///
        /// </param>
        /// <param name="a3">
        ///
        /// </param>
        abstract member add: a1: Animejs.TargetsParam * a2: Animejs.AnimationParams * ?a3: U3<Animejs.TimelinePosition, Animejs.StaggerFunction<U2<float, string>>, Animejs.TweakRegister> -> Timeline
        /// <param name="a1">
        ///
        /// </param>
        /// <param name="a2">
        ///
        /// </param>
        /// <param name="a3">
        ///
        /// </param>
        abstract member add: a1: Animejs.TimerParams * ?a2: Animejs.TimelinePosition -> Timeline
        /// <param name="synced">
        ///
        /// </param>
        /// <param name="position">
        ///
        /// </param>
        abstract member sync: unit -> Timeline
        /// <param name="synced">
        ///
        /// </param>
        /// <param name="position">
        ///
        /// </param>
        abstract member sync: synced: Animejs.Timer * ?position: Animejs.TimelinePosition -> Timeline
        /// <param name="synced">
        ///
        /// </param>
        /// <param name="position">
        ///
        /// </param>
        abstract member sync: synced: Animejs.JSAnimation * ?position: Animejs.TimelinePosition -> Timeline
        /// <param name="synced">
        ///
        /// </param>
        /// <param name="position">
        ///
        /// </param>
        abstract member sync: synced: Animejs.Timeline * ?position: Animejs.TimelinePosition -> Timeline
        /// <param name="synced">
        ///
        /// </param>
        /// <param name="position">
        ///
        /// </param>
        abstract member sync: ?synced: Glutinum.Web.Animation * ?position: Animejs.TimelinePosition -> Timeline
        /// <param name="synced">
        ///
        /// </param>
        /// <param name="position">
        ///
        /// </param>
        abstract member sync: synced: Animejs.WAAPIAnimation * ?position: Animejs.TimelinePosition -> Timeline
        /// <param name="targets">
        ///
        /// </param>
        /// <param name="parameters">
        ///
        /// </param>
        /// <param name="position">
        ///
        /// </param>
        abstract member set: targets: ResizeArray<Animejs.TargetSelector> * parameters: Animejs.AnimationParams * ?position: U3<Animejs.TimelinePosition, Animejs.StaggerFunction<U2<float, string>>, Animejs.TweakRegister> -> Timeline
        /// <param name="targets">
        ///
        /// </param>
        /// <param name="parameters">
        ///
        /// </param>
        /// <param name="position">
        ///
        /// </param>
        abstract member set: targets: Glutinum.Web.HTMLElement * parameters: Animejs.AnimationParams * ?position: U3<Animejs.TimelinePosition, Animejs.StaggerFunction<U2<float, string>>, Animejs.TweakRegister> -> Timeline
        /// <param name="targets">
        ///
        /// </param>
        /// <param name="parameters">
        ///
        /// </param>
        /// <param name="position">
        ///
        /// </param>
        abstract member set: targets: Glutinum.Web.SVGElement * parameters: Animejs.AnimationParams * ?position: U3<Animejs.TimelinePosition, Animejs.StaggerFunction<U2<float, string>>, Animejs.TweakRegister> -> Timeline
        /// <param name="targets">
        ///
        /// </param>
        /// <param name="parameters">
        ///
        /// </param>
        /// <param name="position">
        ///
        /// </param>
        abstract member set: targets: Animejs.JSTarget * parameters: Animejs.AnimationParams * ?position: U3<Animejs.TimelinePosition, Animejs.StaggerFunction<U2<float, string>>, Animejs.TweakRegister> -> Timeline
        /// <param name="targets">
        ///
        /// </param>
        /// <param name="parameters">
        ///
        /// </param>
        /// <param name="position">
        ///
        /// </param>
        abstract member set: targets: Glutinum.Web.NodeList * parameters: Animejs.AnimationParams * ?position: U3<Animejs.TimelinePosition, Animejs.StaggerFunction<U2<float, string>>, Animejs.TweakRegister> -> Timeline
        /// <param name="targets">
        ///
        /// </param>
        /// <param name="parameters">
        ///
        /// </param>
        /// <param name="position">
        ///
        /// </param>
        abstract member set: targets: string * parameters: Animejs.AnimationParams * ?position: U3<Animejs.TimelinePosition, Animejs.StaggerFunction<U2<float, string>>, Animejs.TweakRegister> -> Timeline
        /// <param name="targets">
        ///
        /// </param>
        /// <param name="parameters">
        ///
        /// </param>
        /// <param name="position">
        ///
        /// </param>
        abstract member set: targets: Animejs.TargetsParam * parameters: Animejs.AnimationParams * ?position: U3<Animejs.TimelinePosition, Animejs.StaggerFunction<U2<float, string>>, Animejs.TweakRegister> -> Timeline
        /// <param name="callback">
        ///
        /// </param>
        /// <param name="position">
        ///
        /// </param>
        abstract member call: callback: Animejs.Callback<Animejs.Timer> * ?position: Animejs.TimelinePosition -> Timeline
        /// <param name="labelName">
        ///
        /// </param>
        /// <param name="position">
        ///
        /// </param>
        abstract member label: labelName: string * ?position: Animejs.TimelinePosition -> Timeline
        /// <param name="targets">
        ///
        /// </param>
        /// <param name="propertyName">
        ///
        /// </param>
        abstract member remove: targets: ResizeArray<Animejs.TargetSelector> * ?propertyName: string -> Timeline
        /// <param name="targets">
        ///
        /// </param>
        /// <param name="propertyName">
        ///
        /// </param>
        abstract member remove: targets: Glutinum.Web.HTMLElement * ?propertyName: string -> Timeline
        /// <param name="targets">
        ///
        /// </param>
        /// <param name="propertyName">
        ///
        /// </param>
        abstract member remove: targets: Glutinum.Web.SVGElement * ?propertyName: string -> Timeline
        /// <param name="targets">
        ///
        /// </param>
        /// <param name="propertyName">
        ///
        /// </param>
        abstract member remove: targets: Animejs.JSTarget * ?propertyName: string -> Timeline
        /// <param name="targets">
        ///
        /// </param>
        /// <param name="propertyName">
        ///
        /// </param>
        abstract member remove: targets: Glutinum.Web.NodeList * ?propertyName: string -> Timeline
        /// <param name="targets">
        ///
        /// </param>
        /// <param name="propertyName">
        ///
        /// </param>
        abstract member remove: targets: string * ?propertyName: string -> Timeline
        /// <param name="targets">
        ///
        /// </param>
        /// <param name="propertyName">
        ///
        /// </param>
        abstract member remove: targets: Animejs.TargetsParam * ?propertyName: string -> Timeline
        /// <param name="newDuration">
        ///
        /// </param>
        abstract member stretch: newDuration: float -> Timeline
        abstract member refresh: unit -> Timeline
        /// <summary>
        /// Cancels the timer by seeking it back to 0 and reverting the attached scroller if necessary
        /// </summary>
        abstract member revert: unit -> Timeline
        /// <param name="callback">
        ///
        /// </param>
        /// <returns>
        /// Promise<this>
        /// </returns>
        abstract member ``then``: ?callback: Animejs.Callback<obj> -> JS.Promise<obj>

    /// <summary>
    /// Base class used to create Timers, Animations and Timelines
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type Timer =
        inherit Animejs.Clock
        abstract member id: U2<string, float> with get, set
        abstract member parent: Animejs.Timeline with get, set
        abstract member duration: float with get, set
        abstract member backwards: bool with get, set
        abstract member paused: bool with get, set
        abstract member began: bool with get, set
        abstract member completed: bool with get, set
        abstract member onBegin: self: Animejs.Callback<Timer> -> obj
        abstract member onBeforeUpdate: self: Animejs.Callback<Timer> -> obj
        abstract member onUpdate: self: Animejs.Callback<Timer> -> obj
        abstract member onLoop: self: Animejs.Callback<Timer> -> obj
        abstract member onPause: self: Animejs.Callback<Timer> -> obj
        abstract member onComplete: self: Animejs.Callback<Timer> -> obj
        abstract member iterationDuration: float with get, set
        abstract member iterationCount: float with get, set
        abstract member _autoplay: U2<bool, Animejs.ScrollObserver> with get, set
        abstract member _offset: float with get, set
        abstract member _delay: float with get, set
        abstract member _loopDelay: float with get, set
        abstract member _iterationTime: float with get, set
        abstract member _currentIteration: float with get, set
        abstract member _resolve: Action with get, set
        abstract member _running: bool with get, set
        abstract member _reversed: float with get, set
        abstract member _reverse: float with get, set
        abstract member _cancelled: float with get, set
        abstract member _alternate: bool with get, set
        abstract member _prev: Animejs.Renderable with get, set
        abstract member _next: Animejs.Renderable with get, set
        abstract member _priority: float with get, set
        abstract member cancelled: bool with get, set
        abstract member currentTime: float with get, set
        abstract member iterationCurrentTime: float with get, set
        abstract member progress: float with get, set
        abstract member iterationProgress: float with get, set
        abstract member currentIteration: float with get, set
        abstract member reversed: bool with get, set
        /// <param name="softReset">
        ///
        /// </param>
        abstract member reset: ?softReset: bool -> Timer
        /// <param name="internalRender">
        ///
        /// </param>
        abstract member init: ?internalRender: bool -> Timer
        abstract member resetTime: unit -> Timer
        abstract member pause: unit -> Timer
        abstract member resume: unit -> Timer
        abstract member restart: unit -> Timer
        /// <param name="time">
        ///
        /// </param>
        /// <param name="muteCallbacks">
        ///
        /// </param>
        /// <param name="internalRender">
        ///
        /// </param>
        abstract member seek: time: float -> Timer
        /// <param name="time">
        ///
        /// </param>
        /// <param name="muteCallbacks">
        ///
        /// </param>
        /// <param name="internalRender">
        ///
        /// </param>
        abstract member seek: time: float * muteCallbacks: bool -> Timer
        /// <param name="time">
        ///
        /// </param>
        /// <param name="muteCallbacks">
        ///
        /// </param>
        /// <param name="internalRender">
        ///
        /// </param>
        abstract member seek: time: float * muteCallbacks: bool * internalRender: bool -> Timer
        /// <param name="time">
        ///
        /// </param>
        /// <param name="muteCallbacks">
        ///
        /// </param>
        /// <param name="internalRender">
        ///
        /// </param>
        abstract member seek: time: float * muteCallbacks: bool * internalRender: float -> Timer
        /// <param name="time">
        ///
        /// </param>
        /// <param name="muteCallbacks">
        ///
        /// </param>
        /// <param name="internalRender">
        ///
        /// </param>
        abstract member seek: time: float * muteCallbacks: float -> Timer
        /// <param name="time">
        ///
        /// </param>
        /// <param name="muteCallbacks">
        ///
        /// </param>
        /// <param name="internalRender">
        ///
        /// </param>
        abstract member seek: time: float * muteCallbacks: float * internalRender: bool -> Timer
        /// <param name="time">
        ///
        /// </param>
        /// <param name="muteCallbacks">
        ///
        /// </param>
        /// <param name="internalRender">
        ///
        /// </param>
        abstract member seek: time: float * muteCallbacks: float * internalRender: float -> Timer
        abstract member alternate: unit -> Timer
        abstract member play: unit -> Timer
        abstract member reverse: unit -> Timer
        abstract member cancel: unit -> Timer
        /// <param name="newDuration">
        ///
        /// </param>
        abstract member stretch: newDuration: float -> Timer
        /// <summary>
        /// Cancels the timer by seeking it back to 0 and reverting the attached scroller if necessary
        /// </summary>
        abstract member revert: unit -> Timer
        /// <summary>
        /// Imediatly completes the timer, cancels it and triggers the onComplete callback
        /// </summary>
        /// <param name="muteCallbacks">
        ///
        /// </param>
        abstract member complete: unit -> Timer
        /// <summary>
        /// Imediatly completes the timer, cancels it and triggers the onComplete callback
        /// </summary>
        /// <param name="muteCallbacks">
        ///
        /// </param>
        abstract member complete: muteCallbacks: bool -> Timer
        /// <summary>
        /// Imediatly completes the timer, cancels it and triggers the onComplete callback
        /// </summary>
        /// <param name="muteCallbacks">
        ///
        /// </param>
        abstract member complete: muteCallbacks: float -> Timer
        /// <param name="callback">
        ///
        /// </param>
        /// <returns>
        /// Promise<this>
        /// </returns>
        abstract member ``then``: ?callback: Animejs.Callback<obj> -> JS.Promise<obj>

    [<AllowNullLiteral>]
    [<Interface>]
    type DefaultsParams =
        abstract member id: U2<float, string> option with get, set
        abstract member keyframes: U2<Animejs.PercentageKeyframes, Animejs.DurationKeyframes> option with get, set
        abstract member playbackEase: Animejs.EasingParam option with get, set
        abstract member playbackRate: float option with get, set
        abstract member frameRate: float option with get, set
        abstract member loop: U2<float, bool> option with get, set
        abstract member reversed: bool option with get, set
        abstract member alternate: bool option with get, set
        abstract member persist: bool option with get, set
        abstract member autoplay: U2<bool, Animejs.ScrollObserver> option with get, set
        abstract member duration: U2<float, Animejs.FunctionValue> option with get, set
        abstract member delay: U2<float, Animejs.FunctionValue> option with get, set
        abstract member loopDelay: float option with get, set
        abstract member ease: U2<Animejs.EasingParam, Animejs.FunctionValue> option with get, set
        abstract member composition: DefaultsParams.composition option with get, set
        abstract member modifier: (obj -> unit) option with get, set
        abstract member onBegin: Animejs.Callback<Animejs.Tickable> option with get, set
        abstract member onBeforeUpdate: Animejs.Callback<Animejs.Tickable> option with get, set
        abstract member onUpdate: Animejs.Callback<Animejs.Tickable> option with get, set
        abstract member onLoop: Animejs.Callback<Animejs.Tickable> option with get, set
        abstract member onPause: Animejs.Callback<Animejs.Tickable> option with get, set
        abstract member onComplete: Animejs.Callback<Animejs.Tickable> option with get, set
        abstract member onRender: Animejs.Callback<Animejs.Renderable> option with get, set

    type Renderable =
        U2<Animejs.JSAnimation, Animejs.Timeline>

    type Tickable =
        U2<Animejs.Timer, Animejs.Renderable>

    [<AllowNullLiteral>]
    [<Interface>]
    type CallbackArgument =
        inherit Animejs.Timer
        inherit Animejs.JSAnimation
        inherit Animejs.Timeline

    type Revertible =
        U8<Animejs.Animatable, Animejs.Tickable, Animejs.WAAPIAnimation, Animejs.Draggable, Animejs.ScrollObserver, Animejs.TextSplitter, Animejs.Scope, Animejs.AutoLayout>

    [<AllowNullLiteral>]
    [<Interface>]
    type TweakRegister =
        abstract member ``type``: string with get, set
        abstract member defaultValue: obj with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (``type``: string, defaultValue: obj) : TweakRegister = nativeOnly

    type StaggerFunction<'T> =
        delegate of ?target: Animejs.Target * ?index: float * ?targets: Animejs.TargetsArray * ?prevTween: Animejs.Tween * ?tl: Animejs.Timeline -> 'T

    [<AllowNullLiteral>]
    [<Interface>]
    type StaggerParams =
        abstract member start: U2<float, string> option with get, set
        abstract member from: StaggerParams.from option with get, set
        abstract member reversed: bool option with get, set
        abstract member grid: U2<ResizeArray<float>, bool> option with get, set
        abstract member axis: StaggerParams.axis option with get, set
        abstract member ``use``: U2<string, StaggerParams.``use``.U2.Case2> option with get, set
        abstract member total: float option with get, set
        abstract member ease: Animejs.EasingParam option with get, set
        abstract member modifier: Animejs.TweenModifier option with get, set
        /// <summary>
        /// Additive uniform noise on the
        /// computed stagger value. Number form gives flat <c>+/-jitter</c>; tuple form
        /// ramps the magnitude <c>start -> end</c> across the from/axis/grid ordering
        /// and respects <c>ease</c>.
        /// </summary>
        abstract member jitter: U2<float, float * float> option with get, set
        /// <summary>
        /// Seed for jitter draws and <c>from: 'random'</c>
        /// shuffling. <c>false</c> (default) uses Math.random. <c>true</c> seeds with <c>0</c>. A
        /// number is used directly as the seed.
        /// </summary>
        abstract member seed: U2<bool, float> option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?start: U2<float, string>, ?from: StaggerParams.from, ?reversed: bool, ?grid: U2<ResizeArray<float>, bool>, ?axis: StaggerParams.axis, ?``use``: U2<string, StaggerParams.``use``.U2.Case2>, ?total: float, ?ease: Animejs.EasingParam, ?modifier: Animejs.TweenModifier, ?jitter: U2<float, float * float>, ?seed: U2<bool, float>) : StaggerParams = nativeOnly

    type DOMTarget =
        U2<Glutinum.Web.HTMLElement, Glutinum.Web.SVGElement>

    [<AllowNullLiteral>]
    [<Interface>]
    type JSTarget =
        [<EmitIndexer>]
        abstract member Item: key: string -> obj with get, set

    type Target =
        U2<Animejs.DOMTarget, Animejs.JSTarget>

    type TargetSelector =
        U3<Animejs.Target, Glutinum.Web.NodeList, string>

    type DOMTargetSelector =
        U3<Animejs.DOMTarget, Glutinum.Web.NodeList, string>

    type DOMTargetsParam =
        U2<ResizeArray<Animejs.DOMTargetSelector>, Animejs.DOMTargetSelector>

    type DOMTargetsArray =
        ResizeArray<Animejs.DOMTarget>

    type JSTargetsParam =
        U2<ResizeArray<Animejs.JSTarget>, Animejs.JSTarget>

    type JSTargetsArray =
        ResizeArray<Animejs.JSTarget>

    type TargetsParam =
        U2<ResizeArray<Animejs.TargetSelector>, Animejs.TargetSelector>

    type TargetsArray =
        ResizeArray<Animejs.Target>

    type EasingFunction =
        delegate of time: float -> float

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type EaseStringParamNames =
        | linear
        | none
        | ``in``
        | out
        | inOut
        | inQuad
        | outQuad
        | inOutQuad
        | inCubic
        | outCubic
        | inOutCubic
        | inQuart
        | outQuart
        | inOutQuart
        | inQuint
        | outQuint
        | inOutQuint
        | inSine
        | outSine
        | inOutSine
        | inCirc
        | outCirc
        | inOutCirc
        | inExpo
        | outExpo
        | inOutExpo
        | inBounce
        | outBounce
        | inOutBounce
        | inBack
        | outBack
        | inOutBack
        | inElastic
        | outElastic
        | inOutElastic
        | [<CompiledName("out(p = 1.675)")>] ``out(p = 1_675)``
        | [<CompiledName("inOut(p = 1.675)")>] ``inOut(p = 1_675)``
        | [<CompiledName("inBack(overshoot = 1.7)")>] ``inBack(overshoot = 1_7)``
        | [<CompiledName("outBack(overshoot = 1.7)")>] ``outBack(overshoot = 1_7)``
        | [<CompiledName("inOutBack(overshoot = 1.7)")>] ``inOutBack(overshoot = 1_7)``
        | [<CompiledName("inElastic(amplitude = 1, period = .3)")>] ``inElastic(amplitude = 1, period = _3)``
        | [<CompiledName("outElastic(amplitude = 1, period = .3)")>] ``outElastic(amplitude = 1, period = _3)``
        | [<CompiledName("inOutElastic(amplitude = 1, period = .3)")>] ``inOutElastic(amplitude = 1, period = _3)``

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type WAAPIEaseStringParamNames =
        | ease
        | ``ease-in``
        | ``ease-out``
        | ``ease-in-out``
        | [<CompiledName("linear(0, 0.25, 1)")>] ``linear(0, 0_25, 1)``
        | steps
        | ``steps(6, start)``
        | ``step-start``
        | ``step-end``
        | [<CompiledName("cubic-bezier(0.42, 0, 1, 1)")>] ``cubic-bezier(0_42, 0, 1, 1)``

    type PowerEasing =
        delegate of ?power: U2<float, string> -> Animejs.EasingFunction

    type BackEasing =
        delegate of ?overshoot: U2<float, string> -> Animejs.EasingFunction

    type ElasticEasing =
        delegate of ?amplitude: U2<float, string> * ?period: U2<float, string> -> Animejs.EasingFunction

    type EasingFunctionWithParams =
        U3<Animejs.PowerEasing, Animejs.BackEasing, Animejs.ElasticEasing>

    type EasingParam =
        U5<string, Animejs.EaseStringParamNames, Animejs.EasingFunction, Animejs.easings.spring.Spring, Animejs.TweakRegister>

    type WAAPIEasingParam =
        U6<string, Animejs.EaseStringParamNames, Animejs.WAAPIEaseStringParamNames, Animejs.EasingFunction, Animejs.easings.spring.Spring, Animejs.TweakRegister>

    [<AllowNullLiteral>]
    [<Interface>]
    type SpringParams =
        /// <summary>
        /// - Mass, default 1
        /// </summary>
        abstract member mass: float option with get, set
        /// <summary>
        /// - Stiffness, default 100
        /// </summary>
        abstract member stiffness: float option with get, set
        /// <summary>
        /// - Damping, default 10
        /// </summary>
        abstract member damping: float option with get, set
        /// <summary>
        /// - Initial velocity, default 0
        /// </summary>
        abstract member velocity: float option with get, set
        /// <summary>
        /// - Initial bounce, default 0
        /// </summary>
        abstract member bounce: float option with get, set
        /// <summary>
        /// - The perceived duration, default 0
        /// </summary>
        abstract member duration: float option with get, set
        /// <summary>
        /// - Callback function called when the spring currentTime hits the perceived duration
        /// </summary>
        abstract member onComplete: Animejs.Callback<Animejs.JSAnimation> option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?mass: float, ?stiffness: float, ?damping: float, ?velocity: float, ?bounce: float, ?duration: float, ?onComplete: Animejs.Callback<Animejs.JSAnimation>) : SpringParams = nativeOnly

    type Callback<'T> =
        delegate of self: 'T -> unit

    [<AllowNullLiteral>]
    [<Interface>]
    type TickableCallbacks<'T> =
        abstract member onBegin: Animejs.Callback<'T> option with get, set
        abstract member onBeforeUpdate: Animejs.Callback<'T> option with get, set
        abstract member onUpdate: Animejs.Callback<'T> option with get, set
        abstract member onLoop: Animejs.Callback<'T> option with get, set
        abstract member onPause: Animejs.Callback<'T> option with get, set
        abstract member onComplete: Animejs.Callback<'T> option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type RenderableCallbacks<'T> =
        abstract member onRender: Animejs.Callback<'T> option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type TimerOptions =
        abstract member id: U2<float, string> option with get, set
        abstract member duration: Animejs.TweenParamValue option with get, set
        abstract member delay: Animejs.TweenParamValue option with get, set
        abstract member loopDelay: float option with get, set
        abstract member reversed: bool option with get, set
        abstract member alternate: bool option with get, set
        abstract member loop: U2<bool, float> option with get, set
        abstract member autoplay: U2<bool, Animejs.ScrollObserver> option with get, set
        abstract member frameRate: float option with get, set
        abstract member playbackRate: float option with get, set
        abstract member priority: float option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type TimerParams =
        abstract member id: U2<float, string> option with get, set
        abstract member duration: Animejs.TweenParamValue option with get, set
        abstract member delay: Animejs.TweenParamValue option with get, set
        abstract member loopDelay: float option with get, set
        abstract member reversed: bool option with get, set
        abstract member alternate: bool option with get, set
        abstract member loop: U2<bool, float> option with get, set
        abstract member autoplay: U2<bool, Animejs.ScrollObserver> option with get, set
        abstract member frameRate: float option with get, set
        abstract member playbackRate: float option with get, set
        abstract member priority: float option with get, set
        abstract member onBegin: (Animejs.Timer -> unit) option with get, set
        abstract member onBeforeUpdate: (Animejs.Timer -> unit) option with get, set
        abstract member onUpdate: (Animejs.Timer -> unit) option with get, set
        abstract member onLoop: (Animejs.Timer -> unit) option with get, set
        abstract member onPause: (Animejs.Timer -> unit) option with get, set
        abstract member onComplete: (Animejs.Timer -> unit) option with get, set

    type FunctionValueReturn =
        U5<float, string, Animejs.TweenKeyValue, Animejs.EasingParam, ResizeArray<U3<float, string, Animejs.TweenKeyValue>>>

    type FunctionValue<'T> =
        delegate of ?target: Animejs.Target * ?index: float * ?targets: Animejs.TargetsArray * ?prevTween: Animejs.Tween -> 'T

    type TweenModifier =
        delegate of value: float -> U2<float, string>

    type ColorArray =
        float * float * float * float

    [<AllowNullLiteral>]
    [<Interface>]
    type Tween =
        abstract member id: float with get, set
        abstract member parent: Animejs.JSAnimation with get, set
        abstract member property: string with get, set
        abstract member target: Animejs.Target with get, set
        abstract member _value: U3<string, float, obj> with get, set
        abstract member _toFunc: Action option with get, set
        abstract member _fromFunc: Action option with get, set
        abstract member _ease: Animejs.EasingFunction with get, set
        abstract member _fromNumbers: ResizeArray<float> with get, set
        abstract member _toNumbers: ResizeArray<float> with get, set
        abstract member _strings: ResizeArray<string> with get, set
        abstract member _fromNumber: float with get, set
        abstract member _toNumber: float with get, set
        abstract member _numbers: ResizeArray<float> with get, set
        abstract member _number: float with get, set
        abstract member _unit: string with get, set
        abstract member _modifier: Animejs.TweenModifier with get, set
        abstract member _currentTime: float with get, set
        abstract member _delay: float with get, set
        abstract member _updateDuration: float with get, set
        abstract member _startTime: float with get, set
        abstract member _changeDuration: float with get, set
        abstract member _absoluteStartTime: float with get, set
        abstract member _absoluteUpdateStartTime: float with get, set
        abstract member _absoluteEndTime: float with get, set
        abstract member _hasFromValue: float with get, set
        abstract member _tweenType: Animejs.dist.modules.core.consts.tweenTypes with get, set
        abstract member _setter: Tween._setter option with get, set
        abstract member _valueType: Animejs.dist.modules.core.consts.valueTypes with get, set
        abstract member _composition: float with get, set
        abstract member _isOverlapped: float with get, set
        abstract member _isOverridden: float with get, set
        abstract member _renderTransforms: float with get, set
        abstract member _inlineValue: string with get, set
        abstract member _prevRep: Animejs.Tween with get, set
        abstract member _nextRep: Animejs.Tween with get, set
        abstract member _prevAdd: Animejs.Tween with get, set
        abstract member _nextAdd: Animejs.Tween with get, set
        abstract member _prev: Animejs.Tween with get, set
        abstract member _next: Animejs.Tween with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (id: float, parent: Animejs.JSAnimation, property: string, target: Animejs.Target, _value: string, _ease: Animejs.EasingFunction, _fromNumbers: ResizeArray<float>, _toNumbers: ResizeArray<float>, _strings: ResizeArray<string>, _fromNumber: float, _toNumber: float, _numbers: ResizeArray<float>, _number: float, _unit: string, _modifier: Animejs.TweenModifier, _currentTime: float, _delay: float, _updateDuration: float, _startTime: float, _changeDuration: float, _absoluteStartTime: float, _absoluteUpdateStartTime: float, _absoluteEndTime: float, _hasFromValue: float, _tweenType: Animejs.dist.modules.core.consts.tweenTypes, _valueType: Animejs.dist.modules.core.consts.valueTypes, _composition: float, _isOverlapped: float, _isOverridden: float, _renderTransforms: float, _inlineValue: string, _prevRep: Animejs.Tween, _nextRep: Animejs.Tween, _prevAdd: Animejs.Tween, _nextAdd: Animejs.Tween, _prev: Animejs.Tween, _next: Animejs.Tween, ?_toFunc: Action, ?_fromFunc: Action, ?_setter: Tween._setter) : Tween = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (id: float, parent: Animejs.JSAnimation, property: string, target: Animejs.Target, _value: float, _ease: Animejs.EasingFunction, _fromNumbers: ResizeArray<float>, _toNumbers: ResizeArray<float>, _strings: ResizeArray<string>, _fromNumber: float, _toNumber: float, _numbers: ResizeArray<float>, _number: float, _unit: string, _modifier: Animejs.TweenModifier, _currentTime: float, _delay: float, _updateDuration: float, _startTime: float, _changeDuration: float, _absoluteStartTime: float, _absoluteUpdateStartTime: float, _absoluteEndTime: float, _hasFromValue: float, _tweenType: Animejs.dist.modules.core.consts.tweenTypes, _valueType: Animejs.dist.modules.core.consts.valueTypes, _composition: float, _isOverlapped: float, _isOverridden: float, _renderTransforms: float, _inlineValue: string, _prevRep: Animejs.Tween, _nextRep: Animejs.Tween, _prevAdd: Animejs.Tween, _nextAdd: Animejs.Tween, _prev: Animejs.Tween, _next: Animejs.Tween, ?_toFunc: Action, ?_fromFunc: Action, ?_setter: Tween._setter) : Tween = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (id: float, parent: Animejs.JSAnimation, property: string, target: Animejs.Target, _value: obj, _ease: Animejs.EasingFunction, _fromNumbers: ResizeArray<float>, _toNumbers: ResizeArray<float>, _strings: ResizeArray<string>, _fromNumber: float, _toNumber: float, _numbers: ResizeArray<float>, _number: float, _unit: string, _modifier: Animejs.TweenModifier, _currentTime: float, _delay: float, _updateDuration: float, _startTime: float, _changeDuration: float, _absoluteStartTime: float, _absoluteUpdateStartTime: float, _absoluteEndTime: float, _hasFromValue: float, _tweenType: Animejs.dist.modules.core.consts.tweenTypes, _valueType: Animejs.dist.modules.core.consts.valueTypes, _composition: float, _isOverlapped: float, _isOverridden: float, _renderTransforms: float, _inlineValue: string, _prevRep: Animejs.Tween, _nextRep: Animejs.Tween, _prevAdd: Animejs.Tween, _nextAdd: Animejs.Tween, _prev: Animejs.Tween, _next: Animejs.Tween, ?_toFunc: Action, ?_fromFunc: Action, ?_setter: Tween._setter) : Tween = nativeOnly

    [<AutoOpen>]
    module TweenExtensions =

        type Tween with
            member inline this._ease(time: float) : float =
                this._ease.Invoke(time)
            member inline this._modifier(value: float) : U2<float, string> =
                this._modifier.Invoke(value)

    [<AllowNullLiteral>]
    [<Interface>]
    type TweenDecomposedValue =
        /// <summary>
        /// - Type
        /// </summary>
        abstract member t: float with get, set
        /// <summary>
        /// - Single number value
        /// </summary>
        abstract member n: float with get, set
        /// <summary>
        /// - Value unit
        /// </summary>
        abstract member u: string with get, set
        /// <summary>
        /// - Value operator
        /// </summary>
        abstract member o: string with get, set
        /// <summary>
        /// - Array of Numbers (complex / color value type)
        /// </summary>
        abstract member d: ResizeArray<float> with get, set
        /// <summary>
        /// - Strings (complex value type)
        /// </summary>
        abstract member s: ResizeArray<string> with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type TweenPropertySiblings =
        abstract member _head: Animejs.Tween option with get, set
        abstract member _tail: Animejs.Tween option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type TweenLookups =
        [<EmitIndexer>]
        abstract member Item: key: string -> Animejs.TweenPropertySiblings with get, set

    type TweenReplaceLookups =
        obj

    type TweenAdditiveLookups =
        obj

    type TweenParamValue =
        U5<float, string, Animejs.FunctionValue, Animejs.EasingParam, Animejs.TweakRegister>

    type TweenPropValue =
        U2<Animejs.TweenParamValue, Animejs.TweenParamValue * Animejs.TweenParamValue>

    [<RequireQualifiedAccess>]
    [<Erase(CaseRules.None)>]
    type TweenComposition =
        | none
        | replace
        | blend
        | Case1 of string
        | Case2 of Animejs.dist.modules.core.consts.compositionTypes

        [<Emit("$0")>]
        static member op_Implicit(value: string) : TweenComposition = nativeOnly

        [<Emit("$0")>]
        static member op_ErasedCast(value: string) : TweenComposition = nativeOnly

        [<Emit("$0")>]
        static member op_Implicit(value: Animejs.dist.modules.core.consts.compositionTypes) : TweenComposition = nativeOnly

        [<Emit("$0")>]
        static member op_ErasedCast(value: Animejs.dist.modules.core.consts.compositionTypes) : TweenComposition = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type TweenParamsOptions =
        abstract member duration: Animejs.TweenParamValue option with get, set
        abstract member delay: Animejs.TweenParamValue option with get, set
        abstract member ease: U2<Animejs.EasingParam, Animejs.FunctionValue> option with get, set
        abstract member modifier: Animejs.TweenModifier option with get, set
        abstract member composition: Animejs.TweenComposition option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type TweenValues =
        abstract member from: Animejs.TweenParamValue option with get, set
        abstract member ``to``: Animejs.TweenPropValue option with get, set
        abstract member fromTo: Animejs.TweenPropValue option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type TweenKeyValue =
        abstract member duration: Animejs.TweenParamValue option with get, set
        abstract member delay: Animejs.TweenParamValue option with get, set
        abstract member ease: U2<Animejs.EasingParam, Animejs.FunctionValue> option with get, set
        abstract member modifier: Animejs.TweenModifier option with get, set
        abstract member composition: Animejs.TweenComposition option with get, set
        abstract member from: Animejs.TweenParamValue option with get, set
        abstract member ``to``: Animejs.TweenPropValue option with get, set
        abstract member fromTo: Animejs.TweenPropValue option with get, set

    type ArraySyntaxValue =
        ResizeArray<U2<Animejs.TweenKeyValue, Animejs.TweenPropValue>>

    type TweenOptions =
        U3<Animejs.TweenParamValue, Animejs.ArraySyntaxValue, Animejs.TweenKeyValue>

    [<AllowNullLiteral>]
    [<Interface>]
    type TweenObjectValue =
        abstract member ``to``: U2<Animejs.TweenParamValue, ResizeArray<Animejs.TweenParamValue>> option with get, set
        abstract member from: U2<Animejs.TweenParamValue, ResizeArray<Animejs.TweenParamValue>> option with get, set
        abstract member fromTo: U2<Animejs.TweenParamValue, ResizeArray<Animejs.TweenParamValue>> option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type PercentageKeyframeOptions =
        abstract member ease: Animejs.EasingParam option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type PercentageKeyframeParams =
        [<EmitIndexer>]
        abstract member Item: key: string -> Animejs.TweenParamValue with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type PercentageKeyframes =
        [<EmitIndexer>]
        abstract member Item: key: string -> PercentageKeyframes.PercentageKeyframes with get, set

    type DurationKeyframes =
        ResizeArray<DurationKeyframes.ResizeArray.ReturnType>

    [<AllowNullLiteral>]
    [<Interface>]
    type AnimationOptions =
        abstract member keyframes: U2<Animejs.PercentageKeyframes, Animejs.DurationKeyframes> option with get, set
        abstract member playbackEase: Animejs.EasingParam option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type AnimationParams =
        abstract member id: U2<float, string> option with get, set
        abstract member duration: Animejs.TweenParamValue option with get, set
        abstract member delay: Animejs.TweenParamValue option with get, set
        abstract member loopDelay: float option with get, set
        abstract member reversed: bool option with get, set
        abstract member alternate: bool option with get, set
        abstract member loop: U2<bool, float> option with get, set
        abstract member autoplay: U2<bool, Animejs.ScrollObserver> option with get, set
        abstract member frameRate: float option with get, set
        abstract member playbackRate: float option with get, set
        abstract member priority: float option with get, set
        abstract member keyframes: U2<Animejs.PercentageKeyframes, Animejs.DurationKeyframes> option with get, set
        abstract member playbackEase: Animejs.EasingParam option with get, set
        abstract member ease: U2<Animejs.EasingParam, Animejs.FunctionValue> option with get, set
        abstract member modifier: Animejs.TweenModifier option with get, set
        abstract member composition: Animejs.TweenComposition option with get, set
        abstract member onBegin: (Animejs.JSAnimation -> unit) option with get, set
        abstract member onBeforeUpdate: (Animejs.JSAnimation -> unit) option with get, set
        abstract member onUpdate: (Animejs.JSAnimation -> unit) option with get, set
        abstract member onLoop: (Animejs.JSAnimation -> unit) option with get, set
        abstract member onPause: (Animejs.JSAnimation -> unit) option with get, set
        abstract member onComplete: (Animejs.JSAnimation -> unit) option with get, set
        abstract member onRender: (Animejs.JSAnimation -> unit) option with get, set

    [<RequireQualifiedAccess>]
    [<Erase(CaseRules.None)>]
    type TimelinePosition =
        | ``<``
        | ``<<``
        | Case1 of float
        | Case2 of string
        | Case3 of string
        | Case4 of string
        | Case5 of string
        | Case6 of string
        | Case7 of string

        [<Emit("$0")>]
        static member op_Implicit(value: float) : TimelinePosition = nativeOnly

        [<Emit("$0")>]
        static member op_ErasedCast(value: float) : TimelinePosition = nativeOnly

        [<Emit("$0")>]
        static member op_Implicit(value: string) : TimelinePosition = nativeOnly

        [<Emit("$0")>]
        static member op_ErasedCast(value: string) : TimelinePosition = nativeOnly

    /// <summary>
    /// Accepts:<br>
    /// - <c>Number</c> - Absolute position in milliseconds (e.g., <c>500</c> places animation at exactly 500ms)<br>
    /// - <c>'+=Number'</c> - Addition: Position animation X ms after the last animation (e.g., <c>'+=100'</c>)<br>
    /// - <c>'-=Number'</c> - Subtraction: Position animation X ms before the last animation's end (e.g., <c>'-=100'</c>)<br>
    /// - <c>'*=Number'</c> - Multiplier: Position animation at a fraction of the total duration (e.g., <c>'*=.5'</c> for halfway)<br>
    /// - <c>'<'</c> - Previous end: Position animation at the end position of the previous animation<br>
    /// - <c>'<<'</c> - Previous start: Position animation at the start position of the previous animation<br>
    /// - <c>'<<+=Number'</c> - Combined: Position animation relative to previous animation's start (e.g., <c>'<<+=250'</c>)<br>
    /// - <c>'label'</c> - Label: Position animation at a named label position (e.g., <c>'My Label'</c>)<br>
    /// - <c>stagger(String|Nummber)</c> - Stagger multi-elements animation positions (e.g., 10, 20, 30...)
    /// </summary>
    type TimelineAnimationPosition =
        U3<Animejs.TimelinePosition, Animejs.StaggerFunction<U2<float, string>>, Animejs.TweakRegister>

    [<AllowNullLiteral>]
    [<Interface>]
    type TimelineOptions =
        abstract member defaults: Animejs.DefaultsParams option with get, set
        abstract member playbackEase: Animejs.EasingParam option with get, set
        abstract member composition: bool option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type TimelineParams =
        abstract member id: U2<float, string> option with get, set
        abstract member duration: Animejs.TweenParamValue option with get, set
        abstract member delay: Animejs.TweenParamValue option with get, set
        abstract member loopDelay: float option with get, set
        abstract member reversed: bool option with get, set
        abstract member alternate: bool option with get, set
        abstract member loop: U2<bool, float> option with get, set
        abstract member autoplay: U2<bool, Animejs.ScrollObserver> option with get, set
        abstract member frameRate: float option with get, set
        abstract member playbackRate: float option with get, set
        abstract member priority: float option with get, set
        abstract member defaults: Animejs.DefaultsParams option with get, set
        abstract member playbackEase: Animejs.EasingParam option with get, set
        abstract member composition: bool option with get, set
        abstract member onBegin: (Animejs.Timeline -> unit) option with get, set
        abstract member onBeforeUpdate: (Animejs.Timeline -> unit) option with get, set
        abstract member onUpdate: (Animejs.Timeline -> unit) option with get, set
        abstract member onLoop: (Animejs.Timeline -> unit) option with get, set
        abstract member onPause: (Animejs.Timeline -> unit) option with get, set
        abstract member onComplete: (Animejs.Timeline -> unit) option with get, set
        abstract member onRender: (Animejs.Timeline -> unit) option with get, set

    type WAAPITweenValue =
        U4<string, float, ResizeArray<string>, ResizeArray<float>>

    type WAAPIFunctionValue =
        delegate of target: Animejs.DOMTarget * index: float * targets: Animejs.DOMTargetsArray -> U2<Animejs.WAAPITweenValue, Animejs.WAAPIEasingParam>

    type WAAPIKeyframeValue =
        U3<Animejs.WAAPITweenValue, Animejs.WAAPIFunctionValue, ResizeArray<U3<string, float, Animejs.WAAPIFunctionValue>>>

    [<AllowNullLiteral>]
    [<Interface>]
    type WAAPITweenOptions =
        abstract member ``to``: Animejs.WAAPIKeyframeValue option with get, set
        abstract member from: Animejs.WAAPIKeyframeValue option with get, set
        abstract member duration: U2<float, Animejs.WAAPIFunctionValue> option with get, set
        abstract member delay: U2<float, Animejs.WAAPIFunctionValue> option with get, set
        abstract member ease: Animejs.WAAPIEasingParam option with get, set
        abstract member composition: Glutinum.Web.CompositeOperation option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type WAAPIAnimationOptions =
        abstract member loop: U2<float, bool> option with get, set
        abstract member Reversed: bool option with get, set
        abstract member Alternate: bool option with get, set
        abstract member autoplay: U2<bool, Animejs.ScrollObserver> option with get, set
        abstract member playbackRate: float option with get, set
        abstract member duration: U2<float, Animejs.WAAPIFunctionValue> option with get, set
        abstract member delay: U2<float, Animejs.WAAPIFunctionValue> option with get, set
        abstract member ease: U2<Animejs.WAAPIEasingParam, Animejs.WAAPIFunctionValue> option with get, set
        abstract member composition: Glutinum.Web.CompositeOperation option with get, set
        abstract member persist: bool option with get, set
        abstract member onComplete: Animejs.Callback<Animejs.WAAPIAnimation> option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type WAAPIAnimationParams =
        abstract member loop: U2<float, bool> option with get, set
        abstract member Reversed: bool option with get, set
        abstract member Alternate: bool option with get, set
        abstract member autoplay: U2<bool, Animejs.ScrollObserver> option with get, set
        abstract member playbackRate: float option with get, set
        abstract member duration: U2<float, Animejs.WAAPIFunctionValue> option with get, set
        abstract member delay: U2<float, Animejs.WAAPIFunctionValue> option with get, set
        abstract member ease: U2<Animejs.WAAPIEasingParam, Animejs.WAAPIFunctionValue> option with get, set
        abstract member composition: Glutinum.Web.CompositeOperation option with get, set
        abstract member persist: bool option with get, set
        abstract member onComplete: Animejs.Callback<Animejs.WAAPIAnimation> option with get, set

    type AnimatablePropertySetter =
        delegate of ``to``: U2<float, ResizeArray<float>> * ?duration: float * ?ease: Animejs.EasingParam -> Animejs.AnimatableObject

    type AnimatablePropertyGetter =
        delegate of unit -> U2<float, ResizeArray<float>>

    [<AllowNullLiteral>]
    [<Interface>]
    type AnimatableProperty =
        [<Emit("$0($1...)")>]
        abstract member Invoke: ``to``: U2<float, ResizeArray<float>> * ?duration: float * ?ease: Animejs.EasingParam -> Animejs.AnimatableObject
        [<Emit("$0($1...)")>]
        abstract member Invoke: unit -> U2<float, ResizeArray<float>>

    type AnimatableObject =
        obj

    [<AllowNullLiteral>]
    [<Interface>]
    type AnimatablePropertyParamsOptions =
        abstract member unit: string option with get, set
        abstract member duration: Animejs.TweenParamValue option with get, set
        abstract member ease: Animejs.EasingParam option with get, set
        abstract member modifier: Animejs.TweenModifier option with get, set
        abstract member composition: Animejs.TweenComposition option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type AnimatableParams =
        abstract member unit: string option with get, set
        abstract member duration: Animejs.TweenParamValue option with get, set
        abstract member ease: Animejs.EasingParam option with get, set
        abstract member modifier: Animejs.TweenModifier option with get, set
        abstract member composition: Animejs.TweenComposition option with get, set
        abstract member onBegin: (Animejs.JSAnimation -> unit) option with get, set
        abstract member onBeforeUpdate: (Animejs.JSAnimation -> unit) option with get, set
        abstract member onUpdate: (Animejs.JSAnimation -> unit) option with get, set
        abstract member onLoop: (Animejs.JSAnimation -> unit) option with get, set
        abstract member onPause: (Animejs.JSAnimation -> unit) option with get, set
        abstract member onComplete: (Animejs.JSAnimation -> unit) option with get, set
        abstract member onRender: (Animejs.JSAnimation -> unit) option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type ReactRef =
        abstract member current: U2<Glutinum.Web.HTMLElement, Glutinum.Web.SVGElement> option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type AngularRef =
        abstract member nativeElement: U2<Glutinum.Web.HTMLElement, Glutinum.Web.SVGElement> option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type ScopeParams =
        abstract member root: U3<Animejs.DOMTargetSelector, Animejs.ReactRef, Animejs.AngularRef> option with get, set
        abstract member defaults: Animejs.DefaultsParams option with get, set
        abstract member mediaQueries: ScopeParams.mediaQueries option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?defaults: Animejs.DefaultsParams, ?mediaQueries: ScopeParams.mediaQueries) : ScopeParams = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (root: Animejs.DOMTargetSelector, ?defaults: Animejs.DefaultsParams, ?mediaQueries: ScopeParams.mediaQueries) : ScopeParams = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (root: Animejs.ReactRef, ?defaults: Animejs.DefaultsParams, ?mediaQueries: ScopeParams.mediaQueries) : ScopeParams = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (root: Animejs.AngularRef, ?defaults: Animejs.DefaultsParams, ?mediaQueries: ScopeParams.mediaQueries) : ScopeParams = nativeOnly

    type ScopedCallback<'T> =
        delegate of scope: Animejs.Scope -> 'T

    type ScopeCleanupCallback =
        delegate of ?scope: Animejs.Scope -> unit

    type ScopeConstructorCallback =
        delegate of ?scope: Animejs.Scope -> U2<Animejs.ScopeCleanupCallback, unit>

    type ScopeMethod =
        delegate of [<ParamArray>] args: obj [] -> unit

    type ScrollThresholdValue =
        U2<string, float>

    [<AllowNullLiteral>]
    [<Interface>]
    type ScrollThresholdParam =
        abstract member target: Animejs.ScrollThresholdValue option with get, set
        abstract member container: Animejs.ScrollThresholdValue option with get, set

    type ScrollObserverAxisCallback =
        delegate of self: Animejs.ScrollObserver -> ScrollObserverAxisCallback.ReturnType

    type ScrollThresholdCallback =
        delegate of self: Animejs.ScrollObserver -> U2<Animejs.ScrollThresholdValue, Animejs.ScrollThresholdParam>

    [<AllowNullLiteral>]
    [<Interface>]
    type ScrollObserverParams =
        abstract member id: U2<float, string> option with get, set
        abstract member sync: U4<bool, float, string, Animejs.EasingParam> option with get, set
        abstract member container: Animejs.TargetsParam option with get, set
        abstract member target: Animejs.TargetsParam option with get, set
        abstract member axis: ScrollObserverParams.axis option with get, set
        abstract member enter: U4<Animejs.ScrollThresholdValue, Animejs.ScrollThresholdParam, Animejs.ScrollThresholdCallback, (Animejs.ScrollObserver -> U3<Animejs.ScrollThresholdValue, Animejs.ScrollThresholdParam, Animejs.ScrollThresholdCallback>)> option with get, set
        abstract member leave: U4<Animejs.ScrollThresholdValue, Animejs.ScrollThresholdParam, Animejs.ScrollThresholdCallback, (Animejs.ScrollObserver -> U3<Animejs.ScrollThresholdValue, Animejs.ScrollThresholdParam, Animejs.ScrollThresholdCallback>)> option with get, set
        abstract member repeat: U2<bool, (Animejs.ScrollObserver -> bool)> option with get, set
        abstract member debug: bool option with get, set
        abstract member onEnter: Animejs.Callback<Animejs.ScrollObserver> option with get, set
        abstract member onLeave: Animejs.Callback<Animejs.ScrollObserver> option with get, set
        abstract member onEnterForward: Animejs.Callback<Animejs.ScrollObserver> option with get, set
        abstract member onLeaveForward: Animejs.Callback<Animejs.ScrollObserver> option with get, set
        abstract member onEnterBackward: Animejs.Callback<Animejs.ScrollObserver> option with get, set
        abstract member onLeaveBackward: Animejs.Callback<Animejs.ScrollObserver> option with get, set
        abstract member onUpdate: Animejs.Callback<Animejs.ScrollObserver> option with get, set
        abstract member onResize: Animejs.Callback<Animejs.ScrollObserver> option with get, set
        abstract member onSyncComplete: Animejs.Callback<Animejs.ScrollObserver> option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?id: U2<float, string>, ?sync: U4<bool, float, string, Animejs.EasingParam>, ?container: Animejs.TargetsParam, ?target: Animejs.TargetsParam, ?axis: ScrollObserverParams.axis, ?enter: U4<Animejs.ScrollThresholdValue, Animejs.ScrollThresholdParam, Animejs.ScrollThresholdCallback, (Animejs.ScrollObserver -> U3<Animejs.ScrollThresholdValue, Animejs.ScrollThresholdParam, Animejs.ScrollThresholdCallback>)>, ?leave: U4<Animejs.ScrollThresholdValue, Animejs.ScrollThresholdParam, Animejs.ScrollThresholdCallback, (Animejs.ScrollObserver -> U3<Animejs.ScrollThresholdValue, Animejs.ScrollThresholdParam, Animejs.ScrollThresholdCallback>)>, ?repeat: U2<bool, (Animejs.ScrollObserver -> bool)>, ?debug: bool, ?onEnter: Animejs.Callback<Animejs.ScrollObserver>, ?onLeave: Animejs.Callback<Animejs.ScrollObserver>, ?onEnterForward: Animejs.Callback<Animejs.ScrollObserver>, ?onLeaveForward: Animejs.Callback<Animejs.ScrollObserver>, ?onEnterBackward: Animejs.Callback<Animejs.ScrollObserver>, ?onLeaveBackward: Animejs.Callback<Animejs.ScrollObserver>, ?onUpdate: Animejs.Callback<Animejs.ScrollObserver>, ?onResize: Animejs.Callback<Animejs.ScrollObserver>, ?onSyncComplete: Animejs.Callback<Animejs.ScrollObserver>) : ScrollObserverParams = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type DraggableAxisParam =
        abstract member mapTo: string option with get, set
        abstract member modifier: Animejs.TweenModifier option with get, set
        abstract member composition: Animejs.TweenComposition option with get, set
        abstract member snap: U3<float, ResizeArray<float>, (Animejs.Draggable -> U2<float, ResizeArray<float>>)> option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type DraggableCursorParams =
        abstract member onHover: string option with get, set
        abstract member onGrab: string option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type DraggableDragThresholdParams =
        abstract member mouse: float option with get, set
        abstract member touch: float option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type DraggableParams =
        abstract member trigger: Animejs.DOMTargetSelector option with get, set
        abstract member container: U3<Animejs.DOMTargetSelector, ResizeArray<float>, (Animejs.Draggable -> U2<Animejs.DOMTargetSelector, ResizeArray<float>>)> option with get, set
        abstract member x: U2<bool, Animejs.DraggableAxisParam> option with get, set
        abstract member y: U2<bool, Animejs.DraggableAxisParam> option with get, set
        abstract member modifier: Animejs.TweenModifier option with get, set
        abstract member snap: U3<float, ResizeArray<float>, (Animejs.Draggable -> U2<float, ResizeArray<float>>)> option with get, set
        abstract member containerPadding: U3<float, ResizeArray<float>, (Animejs.Draggable -> U2<float, ResizeArray<float>>)> option with get, set
        abstract member containerFriction: U2<float, (Animejs.Draggable -> float)> option with get, set
        abstract member releaseContainerFriction: U2<float, (Animejs.Draggable -> float)> option with get, set
        abstract member dragSpeed: U2<float, (Animejs.Draggable -> float)> option with get, set
        abstract member dragThreshold: U3<float, Animejs.DraggableDragThresholdParams, (Animejs.Draggable -> U2<float, Animejs.DraggableDragThresholdParams>)> option with get, set
        abstract member scrollSpeed: U2<float, (Animejs.Draggable -> float)> option with get, set
        abstract member scrollThreshold: U2<float, (Animejs.Draggable -> float)> option with get, set
        abstract member minVelocity: U2<float, (Animejs.Draggable -> float)> option with get, set
        abstract member maxVelocity: U2<float, (Animejs.Draggable -> float)> option with get, set
        abstract member velocityMultiplier: U2<float, (Animejs.Draggable -> float)> option with get, set
        abstract member releaseMass: float option with get, set
        abstract member releaseStiffness: float option with get, set
        abstract member releaseDamping: float option with get, set
        abstract member releaseEase: Animejs.EasingParam option with get, set
        abstract member cursor: U3<bool, Animejs.DraggableCursorParams, (Animejs.Draggable -> U2<bool, Animejs.DraggableCursorParams>)> option with get, set
        abstract member onGrab: Animejs.Callback<Animejs.Draggable> option with get, set
        abstract member onDrag: Animejs.Callback<Animejs.Draggable> option with get, set
        abstract member onRelease: Animejs.Callback<Animejs.Draggable> option with get, set
        abstract member onUpdate: Animejs.Callback<Animejs.Draggable> option with get, set
        abstract member onSettle: Animejs.Callback<Animejs.Draggable> option with get, set
        abstract member onSnap: Animejs.Callback<Animejs.Draggable> option with get, set
        abstract member onResize: Animejs.Callback<Animejs.Draggable> option with get, set
        abstract member onAfterResize: Animejs.Callback<Animejs.Draggable> option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?trigger: Animejs.DOMTargetSelector, ?container: U3<Animejs.DOMTargetSelector, ResizeArray<float>, (Animejs.Draggable -> U2<Animejs.DOMTargetSelector, ResizeArray<float>>)>, ?x: U2<bool, Animejs.DraggableAxisParam>, ?y: U2<bool, Animejs.DraggableAxisParam>, ?modifier: Animejs.TweenModifier, ?snap: U3<float, ResizeArray<float>, (Animejs.Draggable -> U2<float, ResizeArray<float>>)>, ?containerPadding: U3<float, ResizeArray<float>, (Animejs.Draggable -> U2<float, ResizeArray<float>>)>, ?containerFriction: U2<float, (Animejs.Draggable -> float)>, ?releaseContainerFriction: U2<float, (Animejs.Draggable -> float)>, ?dragSpeed: U2<float, (Animejs.Draggable -> float)>, ?dragThreshold: U3<float, Animejs.DraggableDragThresholdParams, (Animejs.Draggable -> U2<float, Animejs.DraggableDragThresholdParams>)>, ?scrollSpeed: U2<float, (Animejs.Draggable -> float)>, ?scrollThreshold: U2<float, (Animejs.Draggable -> float)>, ?minVelocity: U2<float, (Animejs.Draggable -> float)>, ?maxVelocity: U2<float, (Animejs.Draggable -> float)>, ?velocityMultiplier: U2<float, (Animejs.Draggable -> float)>, ?releaseMass: float, ?releaseStiffness: float, ?releaseDamping: float, ?releaseEase: Animejs.EasingParam, ?cursor: U3<bool, Animejs.DraggableCursorParams, (Animejs.Draggable -> U2<bool, Animejs.DraggableCursorParams>)>, ?onGrab: Animejs.Callback<Animejs.Draggable>, ?onDrag: Animejs.Callback<Animejs.Draggable>, ?onRelease: Animejs.Callback<Animejs.Draggable>, ?onUpdate: Animejs.Callback<Animejs.Draggable>, ?onSettle: Animejs.Callback<Animejs.Draggable>, ?onSnap: Animejs.Callback<Animejs.Draggable>, ?onResize: Animejs.Callback<Animejs.Draggable>, ?onAfterResize: Animejs.Callback<Animejs.Draggable>) : DraggableParams = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type SplitTemplateParams =
        abstract member ``class``: U2<bool, string> option with get, set
        abstract member wrap: SplitTemplateParams.wrap option with get, set
        abstract member clone: SplitTemplateParams.clone option with get, set

    type SplitValue =
        U2<bool, string>

    type SplitFunctionValue =
        delegate of ?value: U2<Glutinum.Web.Node, Glutinum.Web.HTMLElement> -> unit

    [<AllowNullLiteral>]
    [<Interface>]
    type TextSplitterParams =
        abstract member lines: U3<Animejs.SplitValue, Animejs.SplitTemplateParams, Animejs.SplitFunctionValue> option with get, set
        abstract member words: U3<Animejs.SplitValue, Animejs.SplitTemplateParams, Animejs.SplitFunctionValue> option with get, set
        abstract member chars: U3<Animejs.SplitValue, Animejs.SplitTemplateParams, Animejs.SplitFunctionValue> option with get, set
        abstract member accessible: bool option with get, set
        abstract member includeSpaces: bool option with get, set
        abstract member debug: bool option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?lines: U3<Animejs.SplitValue, Animejs.SplitTemplateParams, Animejs.SplitFunctionValue>, ?words: U3<Animejs.SplitValue, Animejs.SplitTemplateParams, Animejs.SplitFunctionValue>, ?chars: U3<Animejs.SplitValue, Animejs.SplitTemplateParams, Animejs.SplitFunctionValue>, ?accessible: bool, ?includeSpaces: bool, ?debug: bool) : TextSplitterParams = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type ScrambleTextParams =
        /// <summary>
        /// - the text to transition to, otherwise uses the original text
        /// </summary>
        abstract member text: U2<string, ScrambleTextParams.text.U2.Case2> option with get, set
        /// <summary>
        /// - the characters used for scramble; named sets: 'lowercase', 'uppercase', 'numbers', 'symbols', 'braille', 'blocks', 'shades'; range syntax: 'A-Z', 'a-z0-9'; defaults to 'a-zA-Z0-9!%#_'
        /// </summary>
        abstract member chars: U2<string, ScrambleTextParams.chars.U2.Case2> option with get, set
        /// <summary>
        /// - the easing applied to the scramble animation
        /// </summary>
        abstract member ease: Animejs.EasingParam option with get, set
        /// <summary>
        /// - where the reveal wave starts from, 'auto' (default) uses 'left' when text grows and 'right' when it shrinks
        /// </summary>
        abstract member from: ScrambleTextParams.from option with get, set
        /// <summary>
        /// - reverses the reveal order, so 'center' reveals from edges inward instead of center outward
        /// </summary>
        abstract member reversed: bool option with get, set
        /// <summary>
        /// - characters displayed at the leading edge of the reveal wave; true uses '_', a number is a char code, a string is used directly
        /// </summary>
        abstract member cursor: U3<bool, float, string> option with get, set
        /// <summary>
        /// - adds random timing offsets to each character's start and end, creating a more organic reveal
        /// </summary>
        abstract member perturbation: float option with get, set
        /// <summary>
        /// - a seed for the random number generator to produce reproducible scramble sequences
        /// </summary>
        abstract member seed: float option with get, set
        /// <summary>
        /// - controls the starting appearance: false shows original text, true scrambles it (default), '' starts from blank, ' ' replaces characters with spaces, a custom string (supports range syntax like 'A-Z') uses its characters as scramble set
        /// </summary>
        abstract member ``override``: U2<bool, string> option with get, set
        /// <summary>
        /// - characters per second entering the active zone; higher values make the reveal wave move faster (default: 60)
        /// </summary>
        abstract member revealRate: float option with get, set
        /// <summary>
        /// - time in ms each character spends scrambling before settling into its final glyph (default: 300)
        /// </summary>
        abstract member settleDuration: float option with get, set
        /// <summary>
        /// - how many times per second scramble characters cycle in the active zone (default: 30)
        /// </summary>
        abstract member settleRate: float option with get, set
        /// <summary>
        /// - if set to a value greater than 0, overrides the computed duration from interval and settle; if unset or 0, duration is calculated automatically from text length and timing parameters
        /// </summary>
        abstract member duration: U2<float, ScrambleTextParams.duration.U2.Case2> option with get, set
        /// <summary>
        /// - delay in ms before the reveal wave starts within the scramble animation
        /// </summary>
        abstract member revealDelay: U2<float, ScrambleTextParams.revealDelay.U2.Case2> option with get, set
        /// <summary>
        /// - delay in ms before the entire scramble animation starts
        /// </summary>
        abstract member delay: U2<float, ScrambleTextParams.delay.U2.Case2> option with get, set
        /// <summary>
        /// - callback fired each time a character changes during scramble; receives the current scrambled text and the eased progress (0-1)
        /// </summary>
        abstract member onChange: ScrambleTextParams.onChange option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?text: U2<string, ScrambleTextParams.text.U2.Case2>, ?chars: U2<string, ScrambleTextParams.chars.U2.Case2>, ?ease: Animejs.EasingParam, ?from: ScrambleTextParams.from, ?reversed: bool, ?cursor: U3<bool, float, string>, ?perturbation: float, ?seed: float, ?``override``: U2<bool, string>, ?revealRate: float, ?settleDuration: float, ?settleRate: float, ?duration: U2<float, ScrambleTextParams.duration.U2.Case2>, ?revealDelay: U2<float, ScrambleTextParams.revealDelay.U2.Case2>, ?delay: U2<float, ScrambleTextParams.delay.U2.Case2>, ?onChange: ScrambleTextParams.onChange) : ScrambleTextParams = nativeOnly

    type DrawableSVGGeometry =
        obj

    type UtilityFunction =
        delegate of [<ParamArray>] args: obj [] -> U2<float, string>

    [<AllowNullLiteral>]
    [<Interface>]
    type ChainablesMap =
        abstract member clamp: Animejs.ChainedClamp with get, set
        abstract member round: Animejs.ChainedRound with get, set
        abstract member snap: Animejs.ChainedSnap with get, set
        abstract member wrap: Animejs.ChainedWrap with get, set
        abstract member lerp: Animejs.ChainedLerp with get, set
        abstract member damp: Animejs.ChainedDamp with get, set
        abstract member mapRange: Animejs.ChainedMapRange with get, set
        abstract member roundPad: Animejs.ChainedRoundPad with get, set
        abstract member padStart: Animejs.ChainedPadStart with get, set
        abstract member padEnd: Animejs.ChainedPadEnd with get, set
        abstract member degToRad: Animejs.ChainedDegToRad with get, set
        abstract member radToDeg: Animejs.ChainedRadToDeg with get, set

    [<AutoOpen>]
    module ChainablesMapExtensions =

        type ChainablesMap with
            member inline this.clamp(min: float, max: float) : Animejs.ChainableUtil =
                this.clamp.Invoke(min, max)
            member inline this.round(decimalLength: float) : Animejs.ChainableUtil =
                this.round.Invoke(decimalLength)
            member inline this.snap(increment: U2<float, ResizeArray<float>>) : Animejs.ChainableUtil =
                this.snap.Invoke(increment)
            member inline this.wrap(min: float, max: float) : Animejs.ChainableUtil =
                this.wrap.Invoke(min, max)
            member inline this.lerp(start: float, ``end``: float) : Animejs.ChainableUtil =
                this.lerp.Invoke(start, ``end``)
            member inline this.damp(start: float, ``end``: float, deltaTime: float) : Animejs.ChainableUtil =
                this.damp.Invoke(start, ``end``, deltaTime)
            member inline this.mapRange(inLow: float, inHigh: float, outLow: float, outHigh: float) : Animejs.ChainableUtil =
                this.mapRange.Invoke(inLow, inHigh, outLow, outHigh)
            member inline this.roundPad(decimalLength: float) : Animejs.ChainableUtil =
                this.roundPad.Invoke(decimalLength)
            member inline this.padStart(totalLength: float, padString: string) : Animejs.ChainableUtil =
                this.padStart.Invoke(totalLength, padString)
            member inline this.padEnd(totalLength: float, padString: string) : Animejs.ChainableUtil =
                this.padEnd.Invoke(totalLength, padString)
            member inline this.degToRad() : Animejs.ChainableUtil =
                this.degToRad.Invoke()
            member inline this.radToDeg() : Animejs.ChainableUtil =
                this.radToDeg.Invoke()

    type ChainedUtilsResult =
        delegate of value: float -> float

    [<AllowNullLiteral>]
    [<Interface>]
    type ChainableUtil =
        abstract member clamp: Animejs.ChainedClamp with get, set
        abstract member round: Animejs.ChainedRound with get, set
        abstract member snap: Animejs.ChainedSnap with get, set
        abstract member wrap: Animejs.ChainedWrap with get, set
        abstract member lerp: Animejs.ChainedLerp with get, set
        abstract member damp: Animejs.ChainedDamp with get, set
        abstract member mapRange: Animejs.ChainedMapRange with get, set
        abstract member roundPad: Animejs.ChainedRoundPad with get, set
        abstract member padStart: Animejs.ChainedPadStart with get, set
        abstract member padEnd: Animejs.ChainedPadEnd with get, set
        abstract member degToRad: Animejs.ChainedDegToRad with get, set
        abstract member radToDeg: Animejs.ChainedRadToDeg with get, set
        [<Emit("$0($1...)")>]
        abstract member Invoke: value: float -> float

    [<AutoOpen>]
    module ChainableUtilExtensions =

        type ChainableUtil with
            member inline this.clamp(min: float, max: float) : Animejs.ChainableUtil =
                this.clamp.Invoke(min, max)
            member inline this.round(decimalLength: float) : Animejs.ChainableUtil =
                this.round.Invoke(decimalLength)
            member inline this.snap(increment: U2<float, ResizeArray<float>>) : Animejs.ChainableUtil =
                this.snap.Invoke(increment)
            member inline this.wrap(min: float, max: float) : Animejs.ChainableUtil =
                this.wrap.Invoke(min, max)
            member inline this.lerp(start: float, ``end``: float) : Animejs.ChainableUtil =
                this.lerp.Invoke(start, ``end``)
            member inline this.damp(start: float, ``end``: float, deltaTime: float) : Animejs.ChainableUtil =
                this.damp.Invoke(start, ``end``, deltaTime)
            member inline this.mapRange(inLow: float, inHigh: float, outLow: float, outHigh: float) : Animejs.ChainableUtil =
                this.mapRange.Invoke(inLow, inHigh, outLow, outHigh)
            member inline this.roundPad(decimalLength: float) : Animejs.ChainableUtil =
                this.roundPad.Invoke(decimalLength)
            member inline this.padStart(totalLength: float, padString: string) : Animejs.ChainableUtil =
                this.padStart.Invoke(totalLength, padString)
            member inline this.padEnd(totalLength: float, padString: string) : Animejs.ChainableUtil =
                this.padEnd.Invoke(totalLength, padString)
            member inline this.degToRad() : Animejs.ChainableUtil =
                this.degToRad.Invoke()
            member inline this.radToDeg() : Animejs.ChainableUtil =
                this.radToDeg.Invoke()

    type ChainedRoundPad =
        delegate of decimalLength: float -> Animejs.ChainableUtil

    type ChainedPadStart =
        delegate of totalLength: float * padString: string -> Animejs.ChainableUtil

    type ChainedPadEnd =
        delegate of totalLength: float * padString: string -> Animejs.ChainableUtil

    type ChainedWrap =
        delegate of min: float * max: float -> Animejs.ChainableUtil

    type ChainedMapRange =
        delegate of inLow: float * inHigh: float * outLow: float * outHigh: float -> Animejs.ChainableUtil

    type ChainedDegToRad =
        delegate of unit -> Animejs.ChainableUtil

    type ChainedRadToDeg =
        delegate of unit -> Animejs.ChainableUtil

    type ChainedSnap =
        delegate of increment: U2<float, ResizeArray<float>> -> Animejs.ChainableUtil

    type ChainedClamp =
        delegate of min: float * max: float -> Animejs.ChainableUtil

    type ChainedRound =
        delegate of decimalLength: float -> Animejs.ChainableUtil

    type ChainedLerp =
        delegate of start: float * ``end``: float -> Animejs.ChainableUtil

    type ChainedDamp =
        delegate of start: float * ``end``: float * deltaTime: float -> Animejs.ChainableUtil

    /// <summary>
    /// Generate a random number between optional min and max (inclusive) and decimal precision
    /// </summary>
    type RandomNumberGenerator =
        delegate of ?min: float * ?max: float * ?decimalLength: float -> float

    [<AllowNullLiteral>]
    [<Interface>]
    type WAAPIAnimation =
        abstract member targets: Animejs.DOMTargetsArray with get, set
        abstract member animations: ResizeArray<Glutinum.Web.Animation> with get, set
        abstract member controlAnimation: Glutinum.Web.Animation with get, set
        abstract member onComplete: self: Animejs.Callback<WAAPIAnimation> -> obj
        abstract member duration: float with get, set
        abstract member muteCallbacks: bool with get, set
        abstract member completed: bool with get, set
        abstract member paused: bool with get, set
        abstract member reversed: bool with get, set
        abstract member persist: bool with get, set
        abstract member autoplay: U2<bool, Animejs.ScrollObserver> with get, set
        abstract member _speed: float with get, set
        abstract member _resolve: Action with get, set
        abstract member _completed: float with get, set
        abstract member _inlineStyles: ResizeArray<obj> with get, set
        /// <param name="callback">
        ///
        /// </param>
        abstract member forEach: callback: (Glutinum.Web.Animation -> unit) -> WAAPIAnimation
        /// <param name="callback">
        ///
        /// </param>
        abstract member forEach: callback: string -> WAAPIAnimation
        /// <param name="callback">
        ///
        /// </param>
        abstract member forEach: callback: U2<(Glutinum.Web.Animation -> unit), string> -> WAAPIAnimation
        abstract member speed: float with get, set
        abstract member currentTime: float with get, set
        abstract member progress: float with get, set
        abstract member resume: unit -> WAAPIAnimation
        abstract member pause: unit -> WAAPIAnimation
        abstract member alternate: unit -> WAAPIAnimation
        abstract member play: unit -> WAAPIAnimation
        abstract member reverse: unit -> WAAPIAnimation
        /// <param name="time">
        ///
        /// </param>
        /// <param name="muteCallbacks">
        ///
        /// </param>
        abstract member seek: time: float * ?muteCallbacks: bool -> WAAPIAnimation
        abstract member restart: unit -> WAAPIAnimation
        abstract member commitStyles: unit -> WAAPIAnimation
        abstract member complete: unit -> WAAPIAnimation
        abstract member cancel: unit -> WAAPIAnimation
        abstract member revert: unit -> WAAPIAnimation
        /// <param name="callback">
        ///
        /// </param>
        /// <returns>
        /// Promise<this>
        /// </returns>
        abstract member ``then``: ?callback: Animejs.Callback<obj> -> JS.Promise<obj>

    module adapters =

        [<AbstractClass>]
        [<Erase>]
        type Exports =
            /// <summary>
            /// Creates and registers an Adapter. Each library extending <c>animate()</c> calls this once and uses the returned Adapter to wire up its target adapters and property resolvers. The optional <c>detect</c> short-circuits all lookups against the Adapter when the target is unrelated.
            /// </summary>
            /// <param name="detect">
            ///
            /// </param>
            [<Import("registerAdapter", "animejs/adapters")>]
            static member registerAdapter (?detect: (obj -> bool)) : Animejs.adapters.Adapter = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type TargetAdapterEntry =
            abstract member get: (obj -> unit) with get, set
            abstract member set: TargetAdapterEntry.set with get, set
            abstract member gate: (obj -> bool) option with get, set

        [<AllowNullLiteral>]
        [<Interface>]
        type Adapter =
            abstract member detect: (obj -> bool) option with get, set
            abstract member targetAdapters: ResizeArray<Animejs.adapters.TargetAdapter> with get, set
            abstract member propertyResolvers: ResizeArray<Adapter.propertyResolvers.Item> with get, set
            /// <summary>
            /// Creates and registers a <c>TargetAdapter</c> scoped to this Adapter.
            /// </summary>
            /// <param name="detect">
            ///
            /// </param>
            abstract member registerTargetAdapter: detect: (obj -> bool) -> Animejs.adapters.TargetAdapter
            /// <summary>
            /// Registers a property resolver scoped to this Adapter. Resolvers are functions invoked at tween creation when no target adapter has claimed the name; the function returns an entry for names it handles or <c>null</c> to defer. Use for runtime-matched patterns (Color / Vector axis detection, name-prefix conventions, etc.).
            /// </summary>
            /// <param name="resolver">
            ///
            /// </param>
            abstract member registerPropertyResolver: resolver: Adapter.registerPropertyResolver.resolver -> unit

        [<AllowNullLiteral>]
        [<Interface>]
        type TargetAdapter =
            abstract member detect: (obj -> bool) with get, set
            abstract member props: TargetAdapter.props with get, set
            /// <summary>
            /// Registers a property the adapter handles. <c>setter</c> receives <c>(target, value, tween)</c>. For color and complex tweens <c>value</c> is <c>undefined</c>, read <c>tween._numbers</c> instead. <c>gate(target)</c> scopes the prop to a subset of matching targets.
            /// </summary>
            /// <param name="name">
            ///
            /// </param>
            /// <param name="getter">
            ///
            /// </param>
            /// <param name="setter">
            ///
            /// </param>
            /// <param name="gate">
            ///
            /// </param>
            abstract member registerProperty: name: string * getter: (obj -> unit) * setter: TargetAdapter.registerProperty.setter * ?gate: (obj -> bool) -> unit

        module three =

            [<AbstractClass>]
            [<Erase>]
            type Exports =
                [<Import("threeAdapter", "animejs/adapters/three")>]
                static member inline threeAdapter: Exports.threeAdapter__.Type = nativeOnly
                /// <summary>
                /// Flushes pending matrix writes for every dirty instance of <c>mesh</c>.
                /// Called automatically before each render. Call it yourself if you read
                /// <c>mesh.instanceMatrix</c> between an animation tick and the next render.
                /// </summary>
                /// <param name="mesh">
                ///
                /// </param>
                [<Import("commitChanges", "animejs/adapters/three")>]
                static member commitChanges (mesh: Animejs.adapters.three.InstanceParent) : unit = nativeOnly
                /// <summary>
                /// Returns an array of per-instance adapters for <c>mesh</c>. Index by id, deleted slots on <c>BatchedMesh</c> are <c>null</c>. Pass the array (or a slice / a single element) to <c>animate()</c>.
                ///
                /// animate(getInstances(mesh), { x: 100, delay: stagger(5) });
                /// animate(getInstances(mesh)[42], { scale: 2 });
                ///
                /// The same array reference is preserved across <c>mesh.count</c> / <c>addInstance</c> / <c>deleteInstance</c> calls. Entries are pushed, nulled, or truncated in place. Animations bound to an outdated reference keep tweening their original adapters.
                ///
                /// <c>mesh.onBeforeRender</c> is replaced with an accessor that flushes
                /// pending instance writes before each render and forwards to your
                /// handler. Assigning your own <c>mesh.onBeforeRender = fn</c> keeps the
                /// auto-flush, but reading <c>mesh.onBeforeRender</c> afterwards returns the
                /// chained dispatcher rather than <c>fn</c> itself, so identity checks
                /// (<c>mesh.onBeforeRender === fn</c>) will not match.
                /// </summary>
                /// <param name="mesh">
                ///
                /// </param>
                [<Import("getInstances", "animejs/adapters/three")>]
                static member getInstances (mesh: Animejs.adapters.three.InstanceParent) : ResizeArray<Animejs.adapters.three.Instance option> = nativeOnly

            type InstanceParent =
                obj

            /// <summary>
            /// Per-instance adapter for <c>InstancedMesh</c> or <c>BatchedMesh</c>. Returned by <c>getInstances(mesh)</c>. Exposes the same flat properties as the mesh adapter, applied to a single instance id. Writes are coalesced and flushed before each render via <c>onBeforeRender</c>; call <c>commitChanges(mesh)</c> if you need to read <c>mesh.instanceMatrix</c> between a tick and a render.
            ///
            /// Caveats:
            /// - <c>opacity</c> writes the parent's shared material, every instance is affected.
            /// - <c>visible</c> is backed by <c>BatchedMesh.setVisibleAt</c>. On <c>InstancedMesh</c> it is a no-op, use <c>scale = 0</c> to hide an instance.
            /// </summary>
            [<AllowNullLiteral>]
            [<Interface>]
            type Instance =
                abstract member isAnimejsInstanceProxy: bool with get, set
                abstract member parent: Animejs.adapters.three.InstanceParent with get, set
                abstract member id: float with get, set
                abstract member _position: obj with get, set
                abstract member _rotation: obj with get, set
                abstract member _scale: obj with get, set
                abstract member _matrix: obj with get, set
                abstract member _quat: obj with get, set
                abstract member _color: obj with get, set
                abstract member _dirty: float with get, set
                abstract member _skewX: float with get, set
                abstract member _skewY: float with get, set
                abstract member _skewZ: float with get, set
                abstract member _originX: float with get, set
                abstract member _originY: float with get, set
                abstract member _originZ: float with get, set
                abstract member _hasSkewOrigin: bool with get, set
                abstract member _dirtyList: ResizeArray<Animejs.adapters.three.Instance> with get, set
                abstract member _hasSetColor: bool with get, set
                abstract member _hasSetVisible: bool with get, set
                abstract member _hasGetVisible: bool with get, set
                /// <param name="flag">
                ///
                /// </param>
                abstract member _markDirty: flag: float -> unit
                abstract member _flush: unit -> unit
                abstract member x: float with get, set
                abstract member y: float with get, set
                abstract member z: float with get, set
                abstract member rotateX: float with get, set
                abstract member rotateY: float with get, set
                abstract member rotateZ: float with get, set
                abstract member scaleX: float with get, set
                abstract member scaleY: float with get, set
                abstract member scaleZ: float with get, set
                abstract member scale: float with get, set
                abstract member skewX: float with get, set
                abstract member skewY: float with get, set
                abstract member skewZ: float with get, set
                abstract member transformOriginX: float with get, set
                abstract member transformOriginY: float with get, set
                abstract member transformOriginZ: float with get, set
                abstract member opacity: float with get, set
                abstract member visible: bool with get, set

            /// <summary>
            /// Per-mesh state for <c>InstancedMesh</c> / <c>BatchedMesh</c> animations. Holds the instance array, the dirty queue, and the chained <c>onBeforeRender</c> closure.
            /// </summary>
            [<AllowNullLiteral>]
            [<Interface>]
            type InstanceBinding =
                abstract member mesh: Animejs.adapters.three.InstanceParent with get, set
                abstract member hasInstanceMatrix: bool with get, set
                abstract member instances: ResizeArray<Animejs.adapters.three.Instance option> with get, set
                abstract member dirtyList: ResizeArray<Animejs.adapters.three.Instance> with get, set
                abstract member userOnBeforeRender: obj option with get, set
                abstract member chainedHandler: InstanceBinding.chainedHandler with get, set
                abstract member flush: unit -> unit

            module InstanceBinding =

                type chainedHandler =
                    delegate of renderer: obj * scene: obj * camera: obj * geometry: obj * material: obj * group: obj -> unit

            module Exports =

                module threeAdapter__ =

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type Type =
                        abstract member detect: (obj -> bool) with get, set
                        abstract member targetAdapters: ResizeArray<Exports.threeAdapter__.Type.targetAdapters.Item> with get, set
                        abstract member propertyResolvers: ResizeArray<Exports.threeAdapter__.Type.propertyResolvers.Item> with get, set
                        abstract member registerTargetAdapter: detect: (obj -> bool) -> Exports.threeAdapter__.Type.registerTargetAdapter
                        abstract member registerPropertyResolver: resolver: Exports.threeAdapter__.Type.registerPropertyResolver.resolver -> unit
                        [<ParamObject; Emit("$0")>]
                        static member Create (detect: (obj -> bool), targetAdapters: ResizeArray<Exports.threeAdapter__.Type.targetAdapters.Item>, propertyResolvers: ResizeArray<Exports.threeAdapter__.Type.propertyResolvers.Item>, registerTargetAdapter: ((obj -> bool) -> Exports.threeAdapter__.Type.registerTargetAdapter), registerPropertyResolver: (Exports.threeAdapter__.Type.registerPropertyResolver.resolver -> unit)) : Type = nativeOnly

                    module Type =

                        [<AllowNullLiteral>]
                        [<Interface>]
                        type registerTargetAdapter =
                            abstract member detect: (obj -> bool) with get, set
                            abstract member props: Exports.threeAdapter__.Type.registerTargetAdapter.props with get, set
                            abstract member registerProperty: name: string * getter: (obj -> unit) * setter: Exports.threeAdapter__.Type.registerTargetAdapter.registerProperty.setter * ?gate: (obj -> bool) -> unit
                            [<ParamObject; Emit("$0")>]
                            static member Create (detect: (obj -> bool), props: Exports.threeAdapter__.Type.registerTargetAdapter.props, registerProperty: Exports.threeAdapter__.Type.registerTargetAdapter.registerProperty) : registerTargetAdapter = nativeOnly

                        module targetAdapters =

                            [<AllowNullLiteral>]
                            [<Interface>]
                            type Item =
                                abstract member detect: (obj -> bool) with get, set
                                abstract member props: Exports.threeAdapter__.Type.targetAdapters.Item.props with get, set
                                abstract member registerProperty: name: string * getter: (obj -> unit) * setter: Exports.threeAdapter__.Type.targetAdapters.Item.registerProperty.setter * ?gate: (obj -> bool) -> unit
                                [<ParamObject; Emit("$0")>]
                                static member Create (detect: (obj -> bool), props: Exports.threeAdapter__.Type.targetAdapters.Item.props, registerProperty: Exports.threeAdapter__.Type.targetAdapters.Item.registerProperty) : Item = nativeOnly

                            module Item =

                                [<AllowNullLiteral>]
                                [<Interface>]
                                type props =
                                    [<EmitIndexer>]
                                    abstract member Item: key: string -> Animejs.adapters.TargetAdapterEntry with get, set

                                type registerProperty =
                                    delegate of name: string * getter: (obj -> unit) * setter: Exports.threeAdapter__.Type.targetAdapters.Item.registerProperty.setter * ?gate: (obj -> bool) -> unit

                                module registerProperty =

                                    type setter =
                                        delegate of target: obj * value: float * tween: obj -> unit

                        module propertyResolvers =

                            type Item =
                                delegate of target: obj * name: string -> Animejs.adapters.TargetAdapterEntry option

                        module registerTargetAdapter =

                            [<AllowNullLiteral>]
                            [<Interface>]
                            type props =
                                [<EmitIndexer>]
                                abstract member Item: key: string -> Animejs.adapters.TargetAdapterEntry with get, set

                            type registerProperty =
                                delegate of name: string * getter: (obj -> unit) * setter: Exports.threeAdapter__.Type.registerTargetAdapter.registerProperty.setter * ?gate: (obj -> bool) -> unit

                            module registerProperty =

                                type setter =
                                    delegate of target: obj * value: float * tween: obj -> unit

                        module registerPropertyResolver =

                            type resolver =
                                delegate of target: obj * name: string -> obj option

        module TargetAdapterEntry =

            type set =
                delegate of target: obj * value: float * tween: obj -> unit

        module Adapter =

            module propertyResolvers =

                type Item =
                    delegate of target: obj * name: string -> Animejs.adapters.TargetAdapterEntry option

            module registerPropertyResolver =

                type resolver =
                    delegate of target: obj * name: string -> Animejs.adapters.TargetAdapterEntry option

        module TargetAdapter =

            [<AllowNullLiteral>]
            [<Interface>]
            type props =
                [<EmitIndexer>]
                abstract member Item: key: string -> Animejs.adapters.TargetAdapterEntry with get, set

            module registerProperty =

                type setter =
                    delegate of target: obj * value: float * tween: obj -> unit

    module dist =

        module modules =

            module core =

                module consts =

                    type tweenTypes =
                        float

                    type valueTypes =
                        float

                    type tickModes =
                        float

                    type compositionTypes =
                        float

                module globals =

                    [<AbstractClass>]
                    [<Erase>]
                    type Exports =
                        [<ImportAll("animejs")>]
                        static member inline globals
                            with get () : globals_.Exports =
                                nativeOnly

                    module globals_ =

                        [<AbstractClass>]
                        [<Erase>]
                        type Exports =
                            [<Emit("$0.precision")>]
                            abstract member precision: float
                            [<Emit("$0.timeScale")>]
                            abstract member timeScale: float
                            [<Emit("$0.tickThreshold")>]
                            abstract member tickThreshold: float
                            [<Emit("$0.editor")>]
                            abstract member editor: Animejs.EditorGlobals option

                module Exports =

                    type globals =
                        globals.Exports

            module draggable =

                module draggable =

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type Transforms =
                        abstract member ``$el``: U2<Animejs.DOMTarget, Animejs.dist.modules.draggable.draggable.DOMProxy> with get, set
                        abstract member inlineTransforms: ResizeArray<obj> with get, set
                        abstract member point: Glutinum.Web.DOMPoint with get, set
                        abstract member inversedMatrix: Glutinum.Web.DOMMatrix with get, set
                        /// <param name="x">
                        ///
                        /// </param>
                        /// <param name="y">
                        ///
                        /// </param>
                        abstract member normalizePoint: x: float * y: float -> Glutinum.Web.DOMPoint
                        /// <param name="cb">
                        ///
                        /// </param>
                        abstract member traverseUp: cb: Transforms.traverseUp.cb -> unit
                        abstract member getMatrix: unit -> Glutinum.Web.DOMMatrix
                        abstract member remove: unit -> unit
                        abstract member revert: unit -> unit

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type DOMProxy =
                        abstract member el: obj with get, set
                        abstract member zIndex: float with get, set
                        abstract member parentElement: obj with get, set
                        abstract member classList: DOMProxy.classList with get, set
                        abstract member x: obj with get, set
                        abstract member y: obj with get, set
                        abstract member width: obj with get, set
                        abstract member height: obj with get, set
                        abstract member getBoundingClientRect: unit -> DOMProxy.getBoundingClientRect

                    module Transforms =

                        module traverseUp =

                            type cb =
                                delegate of ``$el``: Animejs.DOMTarget * i: float -> unit

                    module DOMProxy =

                        [<AllowNullLiteral>]
                        [<Interface>]
                        type classList =
                            abstract member add: (unit -> unit) with get, set
                            abstract member remove: (unit -> unit) with get, set
                            [<ParamObject; Emit("$0")>]
                            static member Create (add: (unit -> unit), remove: (unit -> unit)) : classList = nativeOnly

                        [<AllowNullLiteral>]
                        [<Interface>]
                        type getBoundingClientRect =
                            abstract member top: obj with get, set
                            abstract member right: obj with get, set
                            abstract member bottom: obj with get, set
                            abstract member left: obj with get, set
                            [<ParamObject; Emit("$0")>]
                            static member Create (top: obj, right: obj, bottom: obj, left: obj) : getBoundingClientRect = nativeOnly

            module easings =

                module eases =

                    module parser =

                        [<AbstractClass>]
                        [<Erase>]
                        type Exports =
                            [<ImportAll("animejs")>]
                            static member inline eases
                                with get () : eases_.Exports =
                                    nativeOnly

                        module eases_ =

                            [<AbstractClass>]
                            [<Erase>]
                            type Exports =
                                [<Emit("$0.linear")>]
                                abstract member linear: Animejs.EasingFunction
                                [<Emit("$0.none")>]
                                abstract member none: Animejs.EasingFunction
                                [<Emit("$0._in")>]
                                abstract member _in: Animejs.PowerEasing
                                [<Emit("$0.out")>]
                                abstract member out: Animejs.PowerEasing
                                [<Emit("$0.inOut")>]
                                abstract member inOut: Animejs.PowerEasing
                                [<Emit("$0.outIn")>]
                                abstract member outIn: Animejs.PowerEasing
                                [<Emit("$0.inQuad")>]
                                abstract member inQuad: Animejs.EasingFunction
                                [<Emit("$0.outQuad")>]
                                abstract member outQuad: Animejs.EasingFunction
                                [<Emit("$0.inOutQuad")>]
                                abstract member inOutQuad: Animejs.EasingFunction
                                [<Emit("$0.outInQuad")>]
                                abstract member outInQuad: Animejs.EasingFunction
                                [<Emit("$0.inCubic")>]
                                abstract member inCubic: Animejs.EasingFunction
                                [<Emit("$0.outCubic")>]
                                abstract member outCubic: Animejs.EasingFunction
                                [<Emit("$0.inOutCubic")>]
                                abstract member inOutCubic: Animejs.EasingFunction
                                [<Emit("$0.outInCubic")>]
                                abstract member outInCubic: Animejs.EasingFunction
                                [<Emit("$0.inQuart")>]
                                abstract member inQuart: Animejs.EasingFunction
                                [<Emit("$0.outQuart")>]
                                abstract member outQuart: Animejs.EasingFunction
                                [<Emit("$0.inOutQuart")>]
                                abstract member inOutQuart: Animejs.EasingFunction
                                [<Emit("$0.outInQuart")>]
                                abstract member outInQuart: Animejs.EasingFunction
                                [<Emit("$0.inQuint")>]
                                abstract member inQuint: Animejs.EasingFunction
                                [<Emit("$0.outQuint")>]
                                abstract member outQuint: Animejs.EasingFunction
                                [<Emit("$0.inOutQuint")>]
                                abstract member inOutQuint: Animejs.EasingFunction
                                [<Emit("$0.outInQuint")>]
                                abstract member outInQuint: Animejs.EasingFunction
                                [<Emit("$0.inSine")>]
                                abstract member inSine: Animejs.EasingFunction
                                [<Emit("$0.outSine")>]
                                abstract member outSine: Animejs.EasingFunction
                                [<Emit("$0.inOutSine")>]
                                abstract member inOutSine: Animejs.EasingFunction
                                [<Emit("$0.outInSine")>]
                                abstract member outInSine: Animejs.EasingFunction
                                [<Emit("$0.inCirc")>]
                                abstract member inCirc: Animejs.EasingFunction
                                [<Emit("$0.outCirc")>]
                                abstract member outCirc: Animejs.EasingFunction
                                [<Emit("$0.inOutCirc")>]
                                abstract member inOutCirc: Animejs.EasingFunction
                                [<Emit("$0.outInCirc")>]
                                abstract member outInCirc: Animejs.EasingFunction
                                [<Emit("$0.inExpo")>]
                                abstract member inExpo: Animejs.EasingFunction
                                [<Emit("$0.outExpo")>]
                                abstract member outExpo: Animejs.EasingFunction
                                [<Emit("$0.inOutExpo")>]
                                abstract member inOutExpo: Animejs.EasingFunction
                                [<Emit("$0.outInExpo")>]
                                abstract member outInExpo: Animejs.EasingFunction
                                [<Emit("$0.inBounce")>]
                                abstract member inBounce: Animejs.EasingFunction
                                [<Emit("$0.outBounce")>]
                                abstract member outBounce: Animejs.EasingFunction
                                [<Emit("$0.inOutBounce")>]
                                abstract member inOutBounce: Animejs.EasingFunction
                                [<Emit("$0.outInBounce")>]
                                abstract member outInBounce: Animejs.EasingFunction
                                [<Emit("$0.inBack")>]
                                abstract member inBack: Animejs.BackEasing
                                [<Emit("$0.outBack")>]
                                abstract member outBack: Animejs.BackEasing
                                [<Emit("$0.inOutBack")>]
                                abstract member inOutBack: Animejs.BackEasing
                                [<Emit("$0.outInBack")>]
                                abstract member outInBack: Animejs.BackEasing
                                [<Emit("$0.inElastic")>]
                                abstract member inElastic: Animejs.ElasticEasing
                                [<Emit("$0.outElastic")>]
                                abstract member outElastic: Animejs.ElasticEasing
                                [<Emit("$0.inOutElastic")>]
                                abstract member inOutElastic: Animejs.ElasticEasing
                                [<Emit("$0.outInElastic")>]
                                abstract member outInElastic: Animejs.ElasticEasing

                            [<AutoOpen>]
                            module ExportsExtensions =

                                type Exports with
                                    member inline this.linear(time: float) : float =
                                        this.linear.Invoke(time)
                                    member inline this.none(time: float) : float =
                                        this.none.Invoke(time)
                                    member inline this.inQuad(time: float) : float =
                                        this.inQuad.Invoke(time)
                                    member inline this.outQuad(time: float) : float =
                                        this.outQuad.Invoke(time)
                                    member inline this.inOutQuad(time: float) : float =
                                        this.inOutQuad.Invoke(time)
                                    member inline this.outInQuad(time: float) : float =
                                        this.outInQuad.Invoke(time)
                                    member inline this.inCubic(time: float) : float =
                                        this.inCubic.Invoke(time)
                                    member inline this.outCubic(time: float) : float =
                                        this.outCubic.Invoke(time)
                                    member inline this.inOutCubic(time: float) : float =
                                        this.inOutCubic.Invoke(time)
                                    member inline this.outInCubic(time: float) : float =
                                        this.outInCubic.Invoke(time)
                                    member inline this.inQuart(time: float) : float =
                                        this.inQuart.Invoke(time)
                                    member inline this.outQuart(time: float) : float =
                                        this.outQuart.Invoke(time)
                                    member inline this.inOutQuart(time: float) : float =
                                        this.inOutQuart.Invoke(time)
                                    member inline this.outInQuart(time: float) : float =
                                        this.outInQuart.Invoke(time)
                                    member inline this.inQuint(time: float) : float =
                                        this.inQuint.Invoke(time)
                                    member inline this.outQuint(time: float) : float =
                                        this.outQuint.Invoke(time)
                                    member inline this.inOutQuint(time: float) : float =
                                        this.inOutQuint.Invoke(time)
                                    member inline this.outInQuint(time: float) : float =
                                        this.outInQuint.Invoke(time)
                                    member inline this.inSine(time: float) : float =
                                        this.inSine.Invoke(time)
                                    member inline this.outSine(time: float) : float =
                                        this.outSine.Invoke(time)
                                    member inline this.inOutSine(time: float) : float =
                                        this.inOutSine.Invoke(time)
                                    member inline this.outInSine(time: float) : float =
                                        this.outInSine.Invoke(time)
                                    member inline this.inCirc(time: float) : float =
                                        this.inCirc.Invoke(time)
                                    member inline this.outCirc(time: float) : float =
                                        this.outCirc.Invoke(time)
                                    member inline this.inOutCirc(time: float) : float =
                                        this.inOutCirc.Invoke(time)
                                    member inline this.outInCirc(time: float) : float =
                                        this.outInCirc.Invoke(time)
                                    member inline this.inExpo(time: float) : float =
                                        this.inExpo.Invoke(time)
                                    member inline this.outExpo(time: float) : float =
                                        this.outExpo.Invoke(time)
                                    member inline this.inOutExpo(time: float) : float =
                                        this.inOutExpo.Invoke(time)
                                    member inline this.outInExpo(time: float) : float =
                                        this.outInExpo.Invoke(time)
                                    member inline this.inBounce(time: float) : float =
                                        this.inBounce.Invoke(time)
                                    member inline this.outBounce(time: float) : float =
                                        this.outBounce.Invoke(time)
                                    member inline this.inOutBounce(time: float) : float =
                                        this.inOutBounce.Invoke(time)
                                    member inline this.outInBounce(time: float) : float =
                                        this.outInBounce.Invoke(time)

                    module Exports =

                        type parser =
                            parser.Exports

                module Exports =

                    module eases =

                        type parser =
                            eases.parser.Exports

            module engine =

                module engine =

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type Engine =
                        inherit Animejs.Clock
                        abstract member useDefaultMainLoop: bool with get, set
                        abstract member pauseOnDocumentHidden: bool with get, set
                        abstract member defaults: Animejs.DefaultsParams with get, set
                        abstract member paused: bool with get, set
                        abstract member reqId: U2<float, obj> with get, set
                        abstract member update: unit -> unit
                        abstract member wake: unit -> Engine
                        abstract member pause: unit -> Animejs.dist.modules.engine.engine.Engine
                        abstract member resume: unit -> Engine
                        abstract member timeUnit: Engine.timeUnit with get, set
                        abstract member precision: float with get, set

                    module Engine =

                        [<RequireQualifiedAccess>]
                        [<StringEnum(CaseRules.None)>]
                        type timeUnit =
                            | ms
                            | s

            module events =

                module scroll =

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type ScrollContainer =
                        abstract member element: Glutinum.Web.HTMLElement with get, set
                        abstract member useWin: bool with get, set
                        abstract member winWidth: float with get, set
                        abstract member winHeight: float with get, set
                        abstract member width: float with get, set
                        abstract member height: float with get, set
                        abstract member left: float with get, set
                        abstract member top: float with get, set
                        abstract member scale: float with get, set
                        abstract member zIndex: float with get, set
                        abstract member scrollX: float with get, set
                        abstract member scrollY: float with get, set
                        abstract member prevScrollX: float with get, set
                        abstract member prevScrollY: float with get, set
                        abstract member scrollWidth: float with get, set
                        abstract member scrollHeight: float with get, set
                        abstract member velocity: float with get, set
                        abstract member backwardX: bool with get, set
                        abstract member backwardY: bool with get, set
                        abstract member scrollTicker: Animejs.Timer with get, set
                        abstract member dataTimer: Animejs.Timer with get, set
                        abstract member resizeTicker: Animejs.Timer with get, set
                        abstract member wakeTicker: Animejs.Timer with get, set
                        abstract member _head: Animejs.ScrollObserver with get, set
                        abstract member _tail: Animejs.ScrollObserver with get, set
                        abstract member resizeObserver: Glutinum.Web.ResizeObserver with get, set
                        abstract member updateScrollCoords: unit -> unit
                        abstract member updateWindowBounds: unit -> unit
                        abstract member updateBounds: unit -> unit
                        abstract member refreshScrollObservers: unit -> unit
                        abstract member refresh: unit -> unit
                        abstract member handleScroll: unit -> unit
                        /// <param name="e">
                        ///
                        /// </param>
                        abstract member handleEvent: e: Glutinum.Web.Event -> unit
                        abstract member revert: unit -> unit

            module layout =

                module layout =

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type LayoutSnapshot =
                        abstract member layout: Animejs.AutoLayout with get, set
                        abstract member rootNode: Animejs.LayoutNode option with get, set
                        abstract member rootNodes: obj with get, set
                        abstract member nodes: obj with get, set
                        abstract member scrollX: float with get, set
                        abstract member scrollY: float with get, set
                        abstract member revert: unit -> LayoutSnapshot
                        /// <param name="$el">
                        ///
                        /// </param>
                        abstract member getNode: ``$el``: Glutinum.Web.HTMLElement -> Animejs.LayoutNode
                        /// <param name="$el">
                        ///
                        /// </param>
                        abstract member getNode: ``$el``: Glutinum.Web.SVGElement -> Animejs.LayoutNode
                        /// <param name="$el">
                        ///
                        /// </param>
                        abstract member getNode: ``$el``: Animejs.DOMTarget -> Animejs.LayoutNode
                        /// <param name="$el">
                        ///
                        /// </param>
                        /// <param name="prop">
                        ///
                        /// </param>
                        abstract member getComputedValue: ``$el``: Glutinum.Web.HTMLElement * prop: string -> U2<float, string>
                        /// <param name="$el">
                        ///
                        /// </param>
                        /// <param name="prop">
                        ///
                        /// </param>
                        abstract member getComputedValue: ``$el``: Glutinum.Web.SVGElement * prop: string -> U2<float, string>
                        /// <param name="$el">
                        ///
                        /// </param>
                        /// <param name="prop">
                        ///
                        /// </param>
                        abstract member getComputedValue: ``$el``: Animejs.DOMTarget * prop: string -> U2<float, string>
                        /// <param name="rootNode">
                        ///
                        /// </param>
                        /// <param name="cb">
                        ///
                        /// </param>
                        abstract member forEach: rootNode: Animejs.LayoutNode option * cb: Animejs.LayoutNodeIterator -> unit
                        /// <param name="cb">
                        ///
                        /// </param>
                        abstract member forEachRootNode: cb: Animejs.LayoutNodeIterator -> unit
                        /// <param name="cb">
                        ///
                        /// </param>
                        abstract member forEachNode: cb: Animejs.LayoutNodeIterator -> unit
                        /// <param name="$el">
                        ///
                        /// </param>
                        /// <param name="parentNode">
                        ///
                        /// </param>
                        abstract member registerElement: ``$el``: Glutinum.Web.HTMLElement * parentNode: Animejs.LayoutNode option -> Animejs.LayoutNode option
                        /// <param name="$el">
                        ///
                        /// </param>
                        /// <param name="parentNode">
                        ///
                        /// </param>
                        abstract member registerElement: ``$el``: Glutinum.Web.SVGElement * parentNode: Animejs.LayoutNode option -> Animejs.LayoutNode option
                        /// <param name="$el">
                        ///
                        /// </param>
                        /// <param name="parentNode">
                        ///
                        /// </param>
                        abstract member registerElement: ``$el``: Animejs.DOMTarget * parentNode: Animejs.LayoutNode option -> Animejs.LayoutNode option
                        /// <param name="$el">
                        ///
                        /// </param>
                        /// <param name="candidates">
                        ///
                        /// </param>
                        abstract member ensureDetachedNode: ``$el``: Glutinum.Web.HTMLElement * candidates: obj -> Animejs.LayoutNode option
                        /// <param name="$el">
                        ///
                        /// </param>
                        /// <param name="candidates">
                        ///
                        /// </param>
                        abstract member ensureDetachedNode: ``$el``: Glutinum.Web.SVGElement * candidates: obj -> Animejs.LayoutNode option
                        /// <param name="$el">
                        ///
                        /// </param>
                        /// <param name="candidates">
                        ///
                        /// </param>
                        abstract member ensureDetachedNode: ``$el``: Animejs.DOMTarget * candidates: obj -> Animejs.LayoutNode option
                        abstract member record: unit -> LayoutSnapshot

            module utils =

                module chainable =

                    [<AbstractClass>]
                    [<Erase>]
                    type Exports =
                        [<Import("snap", "animejs")>]
                        static member inline snap: obj = nativeOnly
                        [<Import("clamp", "animejs")>]
                        static member inline clamp: obj = nativeOnly
                        [<Import("round", "animejs")>]
                        static member inline round: obj = nativeOnly
                        [<Import("lerp", "animejs")>]
                        static member inline lerp: obj = nativeOnly

                module number =

                    [<AbstractClass>]
                    [<Erase>]
                    type Exports =
                        [<Import("roundPad", "animejs")>]
                        static member roundPad (v: float, decimalLength: float) : string = nativeOnly
                        [<Import("roundPad", "animejs")>]
                        static member roundPad (v: string, decimalLength: float) : string = nativeOnly
                        [<Import("roundPad", "animejs")>]
                        static member roundPad (v: U2<float, string>, decimalLength: float) : string = nativeOnly
                        [<Import("padStart", "animejs")>]
                        static member padStart (v: float, totalLength: float, padString: string) : string = nativeOnly
                        [<Import("padEnd", "animejs")>]
                        static member padEnd (v: float, totalLength: float, padString: string) : string = nativeOnly
                        [<Import("wrap", "animejs")>]
                        static member wrap (v: float, min: float, max: float) : float = nativeOnly
                        [<Import("mapRange", "animejs")>]
                        static member mapRange (value: float, inLow: float, inHigh: float, outLow: float, outHigh: float) : float = nativeOnly
                        [<Import("degToRad", "animejs")>]
                        static member degToRad (degrees: float) : float = nativeOnly
                        [<Import("radToDeg", "animejs")>]
                        static member radToDeg (radians: float) : float = nativeOnly
                        [<Import("damp", "animejs")>]
                        static member damp (start: float, ``end``: float, deltaTime: float, factor: float) : float = nativeOnly
                        [<Import("snap", "animejs")>]
                        static member snap (v: float, increment: float) : float = nativeOnly
                        [<Import("snap", "animejs")>]
                        static member snap (v: float, increment: ResizeArray<float>) : float = nativeOnly
                        [<Import("snap", "animejs")>]
                        static member snap (v: float, increment: U2<float, ResizeArray<float>>) : float = nativeOnly
                        [<Import("clamp", "animejs")>]
                        static member clamp (v: float, min: float, max: float) : float = nativeOnly
                        [<Import("round", "animejs")>]
                        static member round (v: float, decimalLength: float) : float = nativeOnly
                        [<Import("lerp", "animejs")>]
                        static member lerp (start: float, ``end``: float, factor: float) : float = nativeOnly

                module target =

                    [<AbstractClass>]
                    [<Erase>]
                    type Exports =
                        /// <param name="targets">
                        ///
                        /// </param>
                        [<Import("$", "animejs")>]
                        static member ``$`` (targets: ResizeArray<Animejs.DOMTargetSelector>) : Animejs.DOMTargetsArray = nativeOnly
                        /// <param name="targets">
                        ///
                        /// </param>
                        [<Import("$", "animejs")>]
                        static member ``$`` (targets: Glutinum.Web.HTMLElement) : Animejs.DOMTargetsArray = nativeOnly
                        /// <param name="targets">
                        ///
                        /// </param>
                        [<Import("$", "animejs")>]
                        static member ``$`` (targets: Glutinum.Web.SVGElement) : Animejs.DOMTargetsArray = nativeOnly
                        /// <param name="targets">
                        ///
                        /// </param>
                        [<Import("$", "animejs")>]
                        static member ``$`` (targets: Glutinum.Web.NodeList) : Animejs.DOMTargetsArray = nativeOnly
                        /// <param name="targets">
                        ///
                        /// </param>
                        [<Import("$", "animejs")>]
                        static member ``$`` (targets: string) : Animejs.DOMTargetsArray = nativeOnly
                        /// <param name="targets">
                        ///
                        /// </param>
                        [<Import("$", "animejs")>]
                        static member ``$`` (targets: Animejs.DOMTargetsParam) : Animejs.DOMTargetsArray = nativeOnly
                        /// <param name="targets">
                        ///
                        /// </param>
                        [<Import("$", "animejs")>]
                        static member ``$`` (targets: ResizeArray<Animejs.JSTarget>) : Animejs.JSTargetsArray = nativeOnly
                        /// <param name="targets">
                        ///
                        /// </param>
                        [<Import("$", "animejs")>]
                        static member ``$`` (targets: Animejs.JSTarget) : Animejs.JSTargetsArray = nativeOnly
                        /// <param name="targets">
                        ///
                        /// </param>
                        [<Import("$", "animejs")>]
                        static member ``$`` (targets: Animejs.JSTargetsParam) : Animejs.JSTargetsArray = nativeOnly
                        /// <param name="targets">
                        ///
                        /// </param>
                        [<Import("$", "animejs")>]
                        static member ``$`` (targets: ResizeArray<Animejs.TargetSelector>) : Animejs.TargetsArray = nativeOnly
                        /// <param name="targets">
                        ///
                        /// </param>
                        [<Import("$", "animejs")>]
                        static member ``$`` (targets: Animejs.TargetsParam) : Animejs.TargetsArray = nativeOnly
                        [<Import("cleanInlineStyles", "animejs")>]
                        static member cleanInlineStyles<'T> (renderable: 'T) : 'T = nativeOnly

                module Exports =

                    type chainable =
                        chainable.Exports

                    type number =
                        number.Exports

                    type target =
                        target.Exports

            module waapi =

                module waapi =

                    [<AbstractClass>]
                    [<Erase>]
                    type Exports =
                        [<ImportAll("animejs")>]
                        static member inline waapi
                            with get () : waapi_.Exports =
                                nativeOnly

                    module waapi_ =

                        [<AbstractClass>]
                        [<Erase>]
                        type Exports =
                            [<Emit("$0.animate($1...)")>]
                            abstract member animate: targets: ResizeArray<Animejs.DOMTargetSelector> * ``params``: Animejs.WAAPIAnimationParams -> Animejs.WAAPIAnimation
                            [<Emit("$0.animate($1...)")>]
                            abstract member animate: targets: Glutinum.Web.HTMLElement * ``params``: Animejs.WAAPIAnimationParams -> Animejs.WAAPIAnimation
                            [<Emit("$0.animate($1...)")>]
                            abstract member animate: targets: Glutinum.Web.SVGElement * ``params``: Animejs.WAAPIAnimationParams -> Animejs.WAAPIAnimation
                            [<Emit("$0.animate($1...)")>]
                            abstract member animate: targets: Glutinum.Web.NodeList * ``params``: Animejs.WAAPIAnimationParams -> Animejs.WAAPIAnimation
                            [<Emit("$0.animate($1...)")>]
                            abstract member animate: targets: string * ``params``: Animejs.WAAPIAnimationParams -> Animejs.WAAPIAnimation
                            [<Emit("$0.animate($1...)")>]
                            abstract member animate: targets: Animejs.DOMTargetsParam * ``params``: Animejs.WAAPIAnimationParams -> Animejs.WAAPIAnimation

                module Exports =

                    type waapi =
                        waapi.Exports

            module Exports =

                module core =

                    type globals =
                        core.globals.Exports

                module easings =

                    module eases =

                        type parser =
                            easings.eases.parser.Exports

                module utils =

                    type chainable =
                        utils.chainable.Exports

                    type number =
                        utils.number.Exports

                    type target =
                        utils.target.Exports

                module waapi =

                    type waapi =
                        waapi.waapi.Exports

        module Exports =

            module modules =

                module core =

                    type globals =
                        modules.core.globals.Exports

                module easings =

                    module eases =

                        type parser =
                            modules.easings.eases.parser.Exports

                module utils =

                    type chainable =
                        modules.utils.chainable.Exports

                    type number =
                        modules.utils.number.Exports

                    type target =
                        modules.utils.target.Exports

                module waapi =

                    type waapi =
                        modules.waapi.waapi.Exports

    module animatable =

        [<AbstractClass>]
        [<Erase>]
        type Exports =
            [<Import("createAnimatable", "animejs/animatable")>]
            static member createAnimatable (targets: ResizeArray<Animejs.TargetSelector>, parameters: Animejs.AnimatableParams) : Animejs.AnimatableObject = nativeOnly
            [<Import("createAnimatable", "animejs/animatable")>]
            static member createAnimatable (targets: Glutinum.Web.HTMLElement, parameters: Animejs.AnimatableParams) : Animejs.AnimatableObject = nativeOnly
            [<Import("createAnimatable", "animejs/animatable")>]
            static member createAnimatable (targets: Glutinum.Web.SVGElement, parameters: Animejs.AnimatableParams) : Animejs.AnimatableObject = nativeOnly
            [<Import("createAnimatable", "animejs/animatable")>]
            static member createAnimatable (targets: Animejs.JSTarget, parameters: Animejs.AnimatableParams) : Animejs.AnimatableObject = nativeOnly
            [<Import("createAnimatable", "animejs/animatable")>]
            static member createAnimatable (targets: Glutinum.Web.NodeList, parameters: Animejs.AnimatableParams) : Animejs.AnimatableObject = nativeOnly
            [<Import("createAnimatable", "animejs/animatable")>]
            static member createAnimatable (targets: string, parameters: Animejs.AnimatableParams) : Animejs.AnimatableObject = nativeOnly
            [<Import("createAnimatable", "animejs/animatable")>]
            static member createAnimatable (targets: Animejs.TargetsParam, parameters: Animejs.AnimatableParams) : Animejs.AnimatableObject = nativeOnly
            /// <param name="targets">
            ///
            /// </param>
            /// <param name="parameters">
            ///
            /// </param>
            [<Import("Animatable", "animejs/animatable"); EmitConstructor>]
            static member Animatable (targets: ResizeArray<Animejs.TargetSelector>, parameters: Animejs.AnimatableParams) : Animatable = nativeOnly
            /// <param name="targets">
            ///
            /// </param>
            /// <param name="parameters">
            ///
            /// </param>
            [<Import("Animatable", "animejs/animatable"); EmitConstructor>]
            static member Animatable (targets: Glutinum.Web.HTMLElement, parameters: Animejs.AnimatableParams) : Animatable = nativeOnly
            /// <param name="targets">
            ///
            /// </param>
            /// <param name="parameters">
            ///
            /// </param>
            [<Import("Animatable", "animejs/animatable"); EmitConstructor>]
            static member Animatable (targets: Glutinum.Web.SVGElement, parameters: Animejs.AnimatableParams) : Animatable = nativeOnly
            /// <param name="targets">
            ///
            /// </param>
            /// <param name="parameters">
            ///
            /// </param>
            [<Import("Animatable", "animejs/animatable"); EmitConstructor>]
            static member Animatable (targets: Animejs.JSTarget, parameters: Animejs.AnimatableParams) : Animatable = nativeOnly
            /// <param name="targets">
            ///
            /// </param>
            /// <param name="parameters">
            ///
            /// </param>
            [<Import("Animatable", "animejs/animatable"); EmitConstructor>]
            static member Animatable (targets: Glutinum.Web.NodeList, parameters: Animejs.AnimatableParams) : Animatable = nativeOnly
            /// <param name="targets">
            ///
            /// </param>
            /// <param name="parameters">
            ///
            /// </param>
            [<Import("Animatable", "animejs/animatable"); EmitConstructor>]
            static member Animatable (targets: string, parameters: Animejs.AnimatableParams) : Animatable = nativeOnly
            /// <param name="targets">
            ///
            /// </param>
            /// <param name="parameters">
            ///
            /// </param>
            [<Import("Animatable", "animejs/animatable"); EmitConstructor>]
            static member Animatable (targets: Animejs.TargetsParam, parameters: Animejs.AnimatableParams) : Animatable = nativeOnly

        type Animatable =
            Animejs.Animatable

    module animation =

        [<AbstractClass>]
        [<Erase>]
        type Exports =
            [<Import("animate", "animejs/animation")>]
            static member animate (targets: ResizeArray<Animejs.TargetSelector>, parameters: Animejs.AnimationParams) : Animejs.JSAnimation = nativeOnly
            [<Import("animate", "animejs/animation")>]
            static member animate (targets: Glutinum.Web.HTMLElement, parameters: Animejs.AnimationParams) : Animejs.JSAnimation = nativeOnly
            [<Import("animate", "animejs/animation")>]
            static member animate (targets: Glutinum.Web.SVGElement, parameters: Animejs.AnimationParams) : Animejs.JSAnimation = nativeOnly
            [<Import("animate", "animejs/animation")>]
            static member animate (targets: Animejs.JSTarget, parameters: Animejs.AnimationParams) : Animejs.JSAnimation = nativeOnly
            [<Import("animate", "animejs/animation")>]
            static member animate (targets: Glutinum.Web.NodeList, parameters: Animejs.AnimationParams) : Animejs.JSAnimation = nativeOnly
            [<Import("animate", "animejs/animation")>]
            static member animate (targets: string, parameters: Animejs.AnimationParams) : Animejs.JSAnimation = nativeOnly
            [<Import("animate", "animejs/animation")>]
            static member animate (targets: Animejs.TargetsParam, parameters: Animejs.AnimationParams) : Animejs.JSAnimation = nativeOnly
            /// <param name="targets">
            ///
            /// </param>
            /// <param name="parameters">
            ///
            /// </param>
            /// <param name="parent">
            ///
            /// </param>
            /// <param name="parentPosition">
            ///
            /// </param>
            /// <param name="fastSet">
            ///
            /// </param>
            /// <param name="index">
            ///
            /// </param>
            /// <param name="allTargets">
            ///
            /// </param>
            [<Import("JSAnimation", "animejs/animation"); EmitConstructor>]
            static member JSAnimation (targets: ResizeArray<Animejs.TargetSelector>, parameters: Animejs.AnimationParams, ?parent: Animejs.Timeline, ?parentPosition: float, ?fastSet: bool, ?index: float, ?allTargets: Animejs.TargetsArray) : JSAnimation = nativeOnly
            /// <param name="targets">
            ///
            /// </param>
            /// <param name="parameters">
            ///
            /// </param>
            /// <param name="parent">
            ///
            /// </param>
            /// <param name="parentPosition">
            ///
            /// </param>
            /// <param name="fastSet">
            ///
            /// </param>
            /// <param name="index">
            ///
            /// </param>
            /// <param name="allTargets">
            ///
            /// </param>
            [<Import("JSAnimation", "animejs/animation"); EmitConstructor>]
            static member JSAnimation (targets: Glutinum.Web.HTMLElement, parameters: Animejs.AnimationParams, ?parent: Animejs.Timeline, ?parentPosition: float, ?fastSet: bool, ?index: float, ?allTargets: Animejs.TargetsArray) : JSAnimation = nativeOnly
            /// <param name="targets">
            ///
            /// </param>
            /// <param name="parameters">
            ///
            /// </param>
            /// <param name="parent">
            ///
            /// </param>
            /// <param name="parentPosition">
            ///
            /// </param>
            /// <param name="fastSet">
            ///
            /// </param>
            /// <param name="index">
            ///
            /// </param>
            /// <param name="allTargets">
            ///
            /// </param>
            [<Import("JSAnimation", "animejs/animation"); EmitConstructor>]
            static member JSAnimation (targets: Glutinum.Web.SVGElement, parameters: Animejs.AnimationParams, ?parent: Animejs.Timeline, ?parentPosition: float, ?fastSet: bool, ?index: float, ?allTargets: Animejs.TargetsArray) : JSAnimation = nativeOnly
            /// <param name="targets">
            ///
            /// </param>
            /// <param name="parameters">
            ///
            /// </param>
            /// <param name="parent">
            ///
            /// </param>
            /// <param name="parentPosition">
            ///
            /// </param>
            /// <param name="fastSet">
            ///
            /// </param>
            /// <param name="index">
            ///
            /// </param>
            /// <param name="allTargets">
            ///
            /// </param>
            [<Import("JSAnimation", "animejs/animation"); EmitConstructor>]
            static member JSAnimation (targets: Animejs.JSTarget, parameters: Animejs.AnimationParams, ?parent: Animejs.Timeline, ?parentPosition: float, ?fastSet: bool, ?index: float, ?allTargets: Animejs.TargetsArray) : JSAnimation = nativeOnly
            /// <param name="targets">
            ///
            /// </param>
            /// <param name="parameters">
            ///
            /// </param>
            /// <param name="parent">
            ///
            /// </param>
            /// <param name="parentPosition">
            ///
            /// </param>
            /// <param name="fastSet">
            ///
            /// </param>
            /// <param name="index">
            ///
            /// </param>
            /// <param name="allTargets">
            ///
            /// </param>
            [<Import("JSAnimation", "animejs/animation"); EmitConstructor>]
            static member JSAnimation (targets: Glutinum.Web.NodeList, parameters: Animejs.AnimationParams, ?parent: Animejs.Timeline, ?parentPosition: float, ?fastSet: bool, ?index: float, ?allTargets: Animejs.TargetsArray) : JSAnimation = nativeOnly
            /// <param name="targets">
            ///
            /// </param>
            /// <param name="parameters">
            ///
            /// </param>
            /// <param name="parent">
            ///
            /// </param>
            /// <param name="parentPosition">
            ///
            /// </param>
            /// <param name="fastSet">
            ///
            /// </param>
            /// <param name="index">
            ///
            /// </param>
            /// <param name="allTargets">
            ///
            /// </param>
            [<Import("JSAnimation", "animejs/animation"); EmitConstructor>]
            static member JSAnimation (targets: string, parameters: Animejs.AnimationParams, ?parent: Animejs.Timeline, ?parentPosition: float, ?fastSet: bool, ?index: float, ?allTargets: Animejs.TargetsArray) : JSAnimation = nativeOnly
            /// <param name="targets">
            ///
            /// </param>
            /// <param name="parameters">
            ///
            /// </param>
            /// <param name="parent">
            ///
            /// </param>
            /// <param name="parentPosition">
            ///
            /// </param>
            /// <param name="fastSet">
            ///
            /// </param>
            /// <param name="index">
            ///
            /// </param>
            /// <param name="allTargets">
            ///
            /// </param>
            [<Import("JSAnimation", "animejs/animation"); EmitConstructor>]
            static member JSAnimation (targets: Animejs.TargetsParam, parameters: Animejs.AnimationParams, ?parent: Animejs.Timeline, ?parentPosition: float, ?fastSet: bool, ?index: float, ?allTargets: Animejs.TargetsArray) : JSAnimation = nativeOnly

        type JSAnimation =
            Animejs.JSAnimation

    module draggable =

        [<AbstractClass>]
        [<Erase>]
        type Exports =
            [<Import("createDraggable", "animejs/draggable")>]
            static member createDraggable (target: ResizeArray<Animejs.TargetSelector>, ?parameters: Animejs.DraggableParams) : Animejs.Draggable = nativeOnly
            [<Import("createDraggable", "animejs/draggable")>]
            static member createDraggable (target: Glutinum.Web.HTMLElement, ?parameters: Animejs.DraggableParams) : Animejs.Draggable = nativeOnly
            [<Import("createDraggable", "animejs/draggable")>]
            static member createDraggable (target: Glutinum.Web.SVGElement, ?parameters: Animejs.DraggableParams) : Animejs.Draggable = nativeOnly
            [<Import("createDraggable", "animejs/draggable")>]
            static member createDraggable (target: Animejs.JSTarget, ?parameters: Animejs.DraggableParams) : Animejs.Draggable = nativeOnly
            [<Import("createDraggable", "animejs/draggable")>]
            static member createDraggable (target: Glutinum.Web.NodeList, ?parameters: Animejs.DraggableParams) : Animejs.Draggable = nativeOnly
            [<Import("createDraggable", "animejs/draggable")>]
            static member createDraggable (target: string, ?parameters: Animejs.DraggableParams) : Animejs.Draggable = nativeOnly
            [<Import("createDraggable", "animejs/draggable")>]
            static member createDraggable (target: Animejs.TargetsParam, ?parameters: Animejs.DraggableParams) : Animejs.Draggable = nativeOnly
            /// <param name="target">
            ///
            /// </param>
            /// <param name="parameters">
            ///
            /// </param>
            [<Import("Draggable", "animejs/draggable"); EmitConstructor>]
            static member Draggable (target: ResizeArray<Animejs.TargetSelector>, ?parameters: Animejs.DraggableParams) : Draggable = nativeOnly
            /// <param name="target">
            ///
            /// </param>
            /// <param name="parameters">
            ///
            /// </param>
            [<Import("Draggable", "animejs/draggable"); EmitConstructor>]
            static member Draggable (target: Glutinum.Web.HTMLElement, ?parameters: Animejs.DraggableParams) : Draggable = nativeOnly
            /// <param name="target">
            ///
            /// </param>
            /// <param name="parameters">
            ///
            /// </param>
            [<Import("Draggable", "animejs/draggable"); EmitConstructor>]
            static member Draggable (target: Glutinum.Web.SVGElement, ?parameters: Animejs.DraggableParams) : Draggable = nativeOnly
            /// <param name="target">
            ///
            /// </param>
            /// <param name="parameters">
            ///
            /// </param>
            [<Import("Draggable", "animejs/draggable"); EmitConstructor>]
            static member Draggable (target: Animejs.JSTarget, ?parameters: Animejs.DraggableParams) : Draggable = nativeOnly
            /// <param name="target">
            ///
            /// </param>
            /// <param name="parameters">
            ///
            /// </param>
            [<Import("Draggable", "animejs/draggable"); EmitConstructor>]
            static member Draggable (target: Glutinum.Web.NodeList, ?parameters: Animejs.DraggableParams) : Draggable = nativeOnly
            /// <param name="target">
            ///
            /// </param>
            /// <param name="parameters">
            ///
            /// </param>
            [<Import("Draggable", "animejs/draggable"); EmitConstructor>]
            static member Draggable (target: string, ?parameters: Animejs.DraggableParams) : Draggable = nativeOnly
            /// <param name="target">
            ///
            /// </param>
            /// <param name="parameters">
            ///
            /// </param>
            [<Import("Draggable", "animejs/draggable"); EmitConstructor>]
            static member Draggable (target: Animejs.TargetsParam, ?parameters: Animejs.DraggableParams) : Draggable = nativeOnly

        type Draggable =
            Animejs.Draggable

    module easings =

        [<AbstractClass>]
        [<Erase>]
        type Exports =
            [<Import("cubicBezier", "animejs/easings")>]
            static member cubicBezier (?mX1: float, ?mY1: float, ?mX2: float, ?mY2: float) : Animejs.EasingFunction = nativeOnly
            [<Import("steps", "animejs/easings")>]
            static member steps (?steps: float, ?fromStart: bool) : Animejs.EasingFunction = nativeOnly
            [<Import("linear", "animejs/easings")>]
            static member linear ([<ParamArray>] args: U2<string, float> []) : Animejs.EasingFunction = nativeOnly
            [<Import("irregular", "animejs/easings")>]
            static member irregular (?length: float, ?randomness: float) : Animejs.EasingFunction = nativeOnly
            [<Import("spring", "animejs/easings")>]
            static member spring (?parameters: Animejs.SpringParams) : Animejs.easings.spring.Spring = nativeOnly
            [<Import("createSpring", "animejs/easings")>]
            static member createSpring (?parameters: Animejs.SpringParams) : Animejs.easings.spring.Spring = nativeOnly
            /// <param name="parameters">
            ///
            /// </param>
            [<Import("Spring", "animejs/easings"); EmitConstructor>]
            static member Spring (?parameters: Animejs.SpringParams) : Spring = nativeOnly

        type Spring =
            Animejs.easings.spring.Spring

        module cubic_bezier =

            [<AbstractClass>]
            [<Erase>]
            type Exports =
                [<Import("cubicBezier", "animejs/easings/cubic-bezier")>]
                static member cubicBezier (?mX1: float, ?mY1: float, ?mX2: float, ?mY2: float) : Animejs.EasingFunction = nativeOnly

        module irregular =

            [<AbstractClass>]
            [<Erase>]
            type Exports =
                [<Import("irregular", "animejs/easings/irregular")>]
                static member irregular (?length: float, ?randomness: float) : Animejs.EasingFunction = nativeOnly

        module linear =

            [<AbstractClass>]
            [<Erase>]
            type Exports =
                [<Import("linear", "animejs/easings/linear")>]
                static member linear ([<ParamArray>] args: U2<string, float> []) : Animejs.EasingFunction = nativeOnly

        module spring =

            [<AbstractClass>]
            [<Erase>]
            type Exports =
                [<Import("spring", "animejs/easings/spring")>]
                static member spring (?parameters: Animejs.SpringParams) : Animejs.easings.spring.Spring = nativeOnly
                [<Import("createSpring", "animejs/easings/spring")>]
                static member createSpring (?parameters: Animejs.SpringParams) : Animejs.easings.spring.Spring = nativeOnly
                /// <param name="parameters">
                ///
                /// </param>
                [<Import("Spring", "animejs/easings/spring"); EmitConstructor>]
                static member Spring (?parameters: Animejs.SpringParams) : Spring = nativeOnly

            [<AllowNullLiteral>]
            [<Interface>]
            type Spring =
                abstract member timeStep: float with get, set
                abstract member restThreshold: float with get, set
                abstract member restDuration: float with get, set
                abstract member maxDuration: float with get, set
                abstract member maxRestSteps: float with get, set
                abstract member maxIterations: float with get, set
                abstract member bn: float with get, set
                abstract member pd: float with get, set
                abstract member m: float with get, set
                abstract member s: float with get, set
                abstract member d: float with get, set
                abstract member v: float with get, set
                abstract member w0: float with get, set
                abstract member zeta: float with get, set
                abstract member wd: float with get, set
                abstract member b: float with get, set
                abstract member completed: bool with get, set
                abstract member solverDuration: float with get, set
                abstract member settlingDuration: float with get, set
                abstract member parent: Animejs.JSAnimation with get, set
                abstract member onComplete: self: Animejs.JSAnimation -> obj
                abstract member ease: time: float -> float
                abstract member solve: time: float -> float
                abstract member calculateSDFromBD: unit -> unit
                abstract member calculateBDFromSD: unit -> unit
                abstract member compute: unit -> unit
                abstract member bounce: float with get, set
                abstract member duration: float with get, set
                abstract member stiffness: float with get, set
                abstract member damping: float with get, set
                abstract member mass: float with get, set
                abstract member velocity: float with get, set

        module steps =

            [<AbstractClass>]
            [<Erase>]
            type Exports =
                [<Import("steps", "animejs/easings/steps")>]
                static member steps (?steps: float, ?fromStart: bool) : Animejs.EasingFunction = nativeOnly

    module engine =

        [<AbstractClass>]
        [<Erase>]
        type Exports =
            [<Import("engine", "animejs/engine")>]
            static member inline engine: Animejs.dist.modules.engine.engine.Engine = nativeOnly

    module events =

        [<AbstractClass>]
        [<Erase>]
        type Exports =
            [<Import("onScroll", "animejs/events")>]
            static member onScroll (?parameters: Animejs.ScrollObserverParams) : Animejs.ScrollObserver = nativeOnly
            [<Import("scrollContainers", "animejs/events")>]
            static member inline scrollContainers: obj = nativeOnly
            /// <param name="parameters">
            ///
            /// </param>
            [<Import("ScrollObserver", "animejs/events"); EmitConstructor>]
            static member ScrollObserver (?parameters: Animejs.ScrollObserverParams) : ScrollObserver = nativeOnly

        type ScrollObserver =
            Animejs.ScrollObserver

    module layout =

        [<AbstractClass>]
        [<Erase>]
        type Exports =
            [<Import("createLayout", "animejs/layout")>]
            static member createLayout (root: Glutinum.Web.HTMLElement, ?``params``: Animejs.AutoLayoutParams) : Animejs.AutoLayout = nativeOnly
            [<Import("createLayout", "animejs/layout")>]
            static member createLayout (root: Glutinum.Web.SVGElement, ?``params``: Animejs.AutoLayoutParams) : Animejs.AutoLayout = nativeOnly
            [<Import("createLayout", "animejs/layout")>]
            static member createLayout (root: Glutinum.Web.NodeList, ?``params``: Animejs.AutoLayoutParams) : Animejs.AutoLayout = nativeOnly
            [<Import("createLayout", "animejs/layout")>]
            static member createLayout (root: string, ?``params``: Animejs.AutoLayoutParams) : Animejs.AutoLayout = nativeOnly
            [<Import("createLayout", "animejs/layout")>]
            static member createLayout (root: Animejs.DOMTargetSelector, ?``params``: Animejs.AutoLayoutParams) : Animejs.AutoLayout = nativeOnly
            /// <param name="root">
            ///
            /// </param>
            /// <param name="params">
            ///
            /// </param>
            [<Import("AutoLayout", "animejs/layout"); EmitConstructor>]
            static member AutoLayout (root: Glutinum.Web.HTMLElement, ?``params``: Animejs.AutoLayoutParams) : AutoLayout = nativeOnly
            /// <param name="root">
            ///
            /// </param>
            /// <param name="params">
            ///
            /// </param>
            [<Import("AutoLayout", "animejs/layout"); EmitConstructor>]
            static member AutoLayout (root: Glutinum.Web.SVGElement, ?``params``: Animejs.AutoLayoutParams) : AutoLayout = nativeOnly
            /// <param name="root">
            ///
            /// </param>
            /// <param name="params">
            ///
            /// </param>
            [<Import("AutoLayout", "animejs/layout"); EmitConstructor>]
            static member AutoLayout (root: Glutinum.Web.NodeList, ?``params``: Animejs.AutoLayoutParams) : AutoLayout = nativeOnly
            /// <param name="root">
            ///
            /// </param>
            /// <param name="params">
            ///
            /// </param>
            [<Import("AutoLayout", "animejs/layout"); EmitConstructor>]
            static member AutoLayout (root: string, ?``params``: Animejs.AutoLayoutParams) : AutoLayout = nativeOnly
            /// <param name="root">
            ///
            /// </param>
            /// <param name="params">
            ///
            /// </param>
            [<Import("AutoLayout", "animejs/layout"); EmitConstructor>]
            static member AutoLayout (root: Animejs.DOMTargetSelector, ?``params``: Animejs.AutoLayoutParams) : AutoLayout = nativeOnly

        type AutoLayout =
            Animejs.AutoLayout

        type LayoutChildrenParam =
            Animejs.LayoutChildrenParam

        type LayoutAnimationTimingsParams =
            Animejs.LayoutAnimationTimingsParams

        type LayoutStateAnimationProperties =
            Animejs.LayoutStateAnimationProperties

        type LayoutStateParams =
            Animejs.LayoutStateParams

        type LayoutSpecificAnimationParams =
            Animejs.LayoutSpecificAnimationParams

        type LayoutAnimationParams =
            Animejs.LayoutAnimationParams

        type LayoutOptions =
            Animejs.LayoutOptions

        type AutoLayoutParams =
            Animejs.AutoLayoutParams

        type LayoutNodeProperties =
            Animejs.LayoutNodeProperties

        type LayoutNode =
            Animejs.LayoutNode

        type LayoutNodeIterator =
            Animejs.LayoutNodeIterator

    module scope =

        [<AbstractClass>]
        [<Erase>]
        type Exports =
            [<Import("createScope", "animejs/scope")>]
            static member createScope (?``params``: Animejs.ScopeParams) : Animejs.Scope = nativeOnly
            /// <param name="parameters">
            ///
            /// </param>
            [<Import("Scope", "animejs/scope"); EmitConstructor>]
            static member Scope (?parameters: Animejs.ScopeParams) : Scope = nativeOnly

        type Scope =
            Animejs.Scope

    module svg =

        [<AbstractClass>]
        [<Erase>]
        type Exports =
            [<Import("createMotionPath", "animejs/svg")>]
            static member createMotionPath (path: ResizeArray<Animejs.TargetSelector>, ?offset: float) : Exports.createMotionPath__ = nativeOnly
            [<Import("createMotionPath", "animejs/svg")>]
            static member createMotionPath (path: Glutinum.Web.HTMLElement, ?offset: float) : Exports.createMotionPath__ = nativeOnly
            [<Import("createMotionPath", "animejs/svg")>]
            static member createMotionPath (path: Glutinum.Web.SVGElement, ?offset: float) : Exports.createMotionPath__ = nativeOnly
            [<Import("createMotionPath", "animejs/svg")>]
            static member createMotionPath (path: Animejs.JSTarget, ?offset: float) : Exports.createMotionPath__ = nativeOnly
            [<Import("createMotionPath", "animejs/svg")>]
            static member createMotionPath (path: Glutinum.Web.NodeList, ?offset: float) : Exports.createMotionPath__ = nativeOnly
            [<Import("createMotionPath", "animejs/svg")>]
            static member createMotionPath (path: string, ?offset: float) : Exports.createMotionPath__ = nativeOnly
            [<Import("createMotionPath", "animejs/svg")>]
            static member createMotionPath (path: Animejs.TargetsParam, ?offset: float) : Exports.createMotionPath__ = nativeOnly
            [<Import("createDrawable", "animejs/svg")>]
            static member createDrawable (selector: ResizeArray<Animejs.TargetSelector>, ?start: float, ?``end``: float) : ResizeArray<Animejs.DrawableSVGGeometry> = nativeOnly
            [<Import("createDrawable", "animejs/svg")>]
            static member createDrawable (selector: Glutinum.Web.HTMLElement, ?start: float, ?``end``: float) : ResizeArray<Animejs.DrawableSVGGeometry> = nativeOnly
            [<Import("createDrawable", "animejs/svg")>]
            static member createDrawable (selector: Glutinum.Web.SVGElement, ?start: float, ?``end``: float) : ResizeArray<Animejs.DrawableSVGGeometry> = nativeOnly
            [<Import("createDrawable", "animejs/svg")>]
            static member createDrawable (selector: Animejs.JSTarget, ?start: float, ?``end``: float) : ResizeArray<Animejs.DrawableSVGGeometry> = nativeOnly
            [<Import("createDrawable", "animejs/svg")>]
            static member createDrawable (selector: Glutinum.Web.NodeList, ?start: float, ?``end``: float) : ResizeArray<Animejs.DrawableSVGGeometry> = nativeOnly
            [<Import("createDrawable", "animejs/svg")>]
            static member createDrawable (selector: string, ?start: float, ?``end``: float) : ResizeArray<Animejs.DrawableSVGGeometry> = nativeOnly
            [<Import("createDrawable", "animejs/svg")>]
            static member createDrawable (selector: Animejs.TargetsParam, ?start: float, ?``end``: float) : ResizeArray<Animejs.DrawableSVGGeometry> = nativeOnly
            [<Import("morphTo", "animejs/svg")>]
            static member morphTo (path2: ResizeArray<Animejs.TargetSelector>, ?precision: float) : Animejs.FunctionValue = nativeOnly
            [<Import("morphTo", "animejs/svg")>]
            static member morphTo (path2: Glutinum.Web.HTMLElement, ?precision: float) : Animejs.FunctionValue = nativeOnly
            [<Import("morphTo", "animejs/svg")>]
            static member morphTo (path2: Glutinum.Web.SVGElement, ?precision: float) : Animejs.FunctionValue = nativeOnly
            [<Import("morphTo", "animejs/svg")>]
            static member morphTo (path2: Animejs.JSTarget, ?precision: float) : Animejs.FunctionValue = nativeOnly
            [<Import("morphTo", "animejs/svg")>]
            static member morphTo (path2: Glutinum.Web.NodeList, ?precision: float) : Animejs.FunctionValue = nativeOnly
            [<Import("morphTo", "animejs/svg")>]
            static member morphTo (path2: string, ?precision: float) : Animejs.FunctionValue = nativeOnly
            [<Import("morphTo", "animejs/svg")>]
            static member morphTo (path2: Animejs.TargetsParam, ?precision: float) : Animejs.FunctionValue = nativeOnly

        module Exports =

            [<AllowNullLiteral>]
            [<Interface>]
            type createMotionPath__ =
                abstract member translateX: Animejs.FunctionValue with get, set
                abstract member translateY: Animejs.FunctionValue with get, set
                abstract member rotate: Animejs.FunctionValue with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (translateX: Animejs.FunctionValue, translateY: Animejs.FunctionValue, rotate: Animejs.FunctionValue) : createMotionPath__ = nativeOnly

    module text =

        [<AbstractClass>]
        [<Erase>]
        type Exports =
            [<Import("splitText", "animejs/text")>]
            static member splitText (target: Glutinum.Web.Element, ?parameters: Animejs.TextSplitterParams) : Animejs.TextSplitter = nativeOnly
            [<Import("splitText", "animejs/text")>]
            static member splitText (target: Glutinum.Web.NodeList, ?parameters: Animejs.TextSplitterParams) : Animejs.TextSplitter = nativeOnly
            [<Import("splitText", "animejs/text")>]
            static member splitText (target: string, ?parameters: Animejs.TextSplitterParams) : Animejs.TextSplitter = nativeOnly
            [<Import("splitText", "animejs/text")>]
            static member splitText (target: ResizeArray<Glutinum.Web.Element>, ?parameters: Animejs.TextSplitterParams) : Animejs.TextSplitter = nativeOnly
            [<Import("splitText", "animejs/text")>]
            static member splitText (target: U4<Glutinum.Web.Element, Glutinum.Web.NodeList, string, ResizeArray<Glutinum.Web.Element>>, ?parameters: Animejs.TextSplitterParams) : Animejs.TextSplitter = nativeOnly
            [<Import("split", "animejs/text")>]
            static member split (target: Glutinum.Web.HTMLElement, ?parameters: Animejs.TextSplitterParams) : Animejs.TextSplitter = nativeOnly
            [<Import("split", "animejs/text")>]
            static member split (target: Glutinum.Web.NodeList, ?parameters: Animejs.TextSplitterParams) : Animejs.TextSplitter = nativeOnly
            [<Import("split", "animejs/text")>]
            static member split (target: string, ?parameters: Animejs.TextSplitterParams) : Animejs.TextSplitter = nativeOnly
            [<Import("split", "animejs/text")>]
            static member split (target: ResizeArray<Glutinum.Web.HTMLElement>, ?parameters: Animejs.TextSplitterParams) : Animejs.TextSplitter = nativeOnly
            [<Import("split", "animejs/text")>]
            static member split (target: U4<Glutinum.Web.HTMLElement, Glutinum.Web.NodeList, string, ResizeArray<Glutinum.Web.HTMLElement>>, ?parameters: Animejs.TextSplitterParams) : Animejs.TextSplitter = nativeOnly
            [<Import("scrambleText", "animejs/text")>]
            static member scrambleText (?``params``: Animejs.ScrambleTextParams) : Animejs.FunctionValue<Animejs.ScrambleTextTween> = nativeOnly
            /// <param name="target">
            ///
            /// </param>
            /// <param name="parameters">
            ///
            /// </param>
            [<Import("TextSplitter", "animejs/text"); EmitConstructor>]
            static member TextSplitter (target: Glutinum.Web.Element, ?parameters: Animejs.TextSplitterParams) : TextSplitter = nativeOnly
            /// <param name="target">
            ///
            /// </param>
            /// <param name="parameters">
            ///
            /// </param>
            [<Import("TextSplitter", "animejs/text"); EmitConstructor>]
            static member TextSplitter (target: Glutinum.Web.NodeList, ?parameters: Animejs.TextSplitterParams) : TextSplitter = nativeOnly
            /// <param name="target">
            ///
            /// </param>
            /// <param name="parameters">
            ///
            /// </param>
            [<Import("TextSplitter", "animejs/text"); EmitConstructor>]
            static member TextSplitter (target: string, ?parameters: Animejs.TextSplitterParams) : TextSplitter = nativeOnly
            /// <param name="target">
            ///
            /// </param>
            /// <param name="parameters">
            ///
            /// </param>
            [<Import("TextSplitter", "animejs/text"); EmitConstructor>]
            static member TextSplitter (target: ResizeArray<Glutinum.Web.Element>, ?parameters: Animejs.TextSplitterParams) : TextSplitter = nativeOnly
            /// <param name="target">
            ///
            /// </param>
            /// <param name="parameters">
            ///
            /// </param>
            [<Import("TextSplitter", "animejs/text"); EmitConstructor>]
            static member TextSplitter (target: U4<Glutinum.Web.Element, Glutinum.Web.NodeList, string, ResizeArray<Glutinum.Web.Element>>, ?parameters: Animejs.TextSplitterParams) : TextSplitter = nativeOnly

        type TextSplitter =
            Animejs.TextSplitter

        type Segment =
            Animejs.Segment

        type Segmenter =
            Animejs.Segmenter

        type ScrambleTextTween =
            Animejs.ScrambleTextTween

    module timeline =

        [<AbstractClass>]
        [<Erase>]
        type Exports =
            [<Import("createTimeline", "animejs/timeline")>]
            static member createTimeline (?parameters: Animejs.TimelineParams) : Animejs.Timeline = nativeOnly
            /// <param name="parameters">
            ///
            /// </param>
            [<Import("Timeline", "animejs/timeline"); EmitConstructor>]
            static member Timeline (?parameters: Animejs.TimelineParams) : Timeline = nativeOnly

        type Timeline =
            Animejs.Timeline

    module timer =

        [<AbstractClass>]
        [<Erase>]
        type Exports =
            [<Import("createTimer", "animejs/timer")>]
            static member createTimer (?parameters: Animejs.TimerParams) : Animejs.Timer = nativeOnly
            /// <param name="parameters">
            ///
            /// </param>
            /// <param name="parent">
            ///
            /// </param>
            /// <param name="parentPosition">
            ///
            /// </param>
            [<Import("Timer", "animejs/timer"); EmitConstructor>]
            static member Timer (?parameters: Animejs.TimerParams, ?parent: Animejs.Timeline, ?parentPosition: float) : Timer = nativeOnly

        type Timer =
            Animejs.Timer

    module utils =

        [<AbstractClass>]
        [<Erase>]
        type Exports =
            [<Import("roundPad", "animejs/utils")>]
            static member inline roundPad: obj = nativeOnly
            [<Import("padStart", "animejs/utils")>]
            static member inline padStart: obj = nativeOnly
            [<Import("padEnd", "animejs/utils")>]
            static member inline padEnd: obj = nativeOnly
            [<Import("wrap", "animejs/utils")>]
            static member inline wrap: obj = nativeOnly
            [<Import("mapRange", "animejs/utils")>]
            static member inline mapRange: obj = nativeOnly
            [<Import("degToRad", "animejs/utils")>]
            static member inline degToRad: obj = nativeOnly
            [<Import("radToDeg", "animejs/utils")>]
            static member inline radToDeg: obj = nativeOnly
            [<Import("snap", "animejs/utils")>]
            static member inline snap: obj = nativeOnly
            [<Import("clamp", "animejs/utils")>]
            static member inline clamp: obj = nativeOnly
            [<Import("round", "animejs/utils")>]
            static member inline round: obj = nativeOnly
            [<Import("lerp", "animejs/utils")>]
            static member inline lerp: obj = nativeOnly
            [<Import("damp", "animejs/utils")>]
            static member inline damp: obj = nativeOnly
            [<Import("createSeededRandom", "animejs/utils")>]
            static member createSeededRandom (?seed: float, ?seededMin: float, ?seededMax: float, ?seededDecimalLength: float) : Animejs.RandomNumberGenerator = nativeOnly
            [<Import("randomPick", "animejs/utils")>]
            static member randomPick<'T> (items: string) : U2<string, 'T> = nativeOnly
            [<Import("randomPick", "animejs/utils")>]
            static member randomPick<'T> (items: ResizeArray<'T>) : U2<string, 'T> = nativeOnly
            [<Import("randomPick", "animejs/utils")>]
            static member randomPick<'T> (items: U2<string, ResizeArray<'T>>) : U2<string, 'T> = nativeOnly
            [<Import("shuffle", "animejs/utils")>]
            static member shuffle (items: ResizeArray<obj>, ?rnd: Animejs.RandomNumberGenerator) : ResizeArray<obj> = nativeOnly
            /// <summary>
            /// Generates a random number between min and max (inclusive) with optional decimal precision
            /// </summary>
            [<Import("random", "animejs/utils")>]
            static member inline random: Animejs.RandomNumberGenerator = nativeOnly
            [<Import("sync", "animejs/utils")>]
            static member sync (?callback: Animejs.Callback<Animejs.Timer>) : Animejs.Timer = nativeOnly
            [<Import("keepTime", "animejs/utils")>]
            static member keepTime (``constructor``: System.Delegate) : System.Delegate = nativeOnly
            /// <param name="targetSelector">
            ///
            /// </param>
            /// <param name="propName">
            ///
            /// </param>
            /// <param name="unit">
            ///
            /// </param>
            [<Import("get", "animejs/utils")>]
            static member get (targetSelector: Glutinum.Web.HTMLElement, propName: string) : string = nativeOnly
            /// <param name="targetSelector">
            ///
            /// </param>
            /// <param name="propName">
            ///
            /// </param>
            /// <param name="unit">
            ///
            /// </param>
            [<Import("get", "animejs/utils")>]
            static member get (targetSelector: Glutinum.Web.SVGElement, propName: string) : string = nativeOnly
            /// <param name="targetSelector">
            ///
            /// </param>
            /// <param name="propName">
            ///
            /// </param>
            /// <param name="unit">
            ///
            /// </param>
            [<Import("get", "animejs/utils")>]
            static member get (targetSelector: Glutinum.Web.NodeList, propName: string) : string = nativeOnly
            /// <param name="targetSelector">
            ///
            /// </param>
            /// <param name="propName">
            ///
            /// </param>
            /// <param name="unit">
            ///
            /// </param>
            [<Import("get", "animejs/utils")>]
            static member get (targetSelector: string, propName: string) : string = nativeOnly
            /// <param name="targetSelector">
            ///
            /// </param>
            /// <param name="propName">
            ///
            /// </param>
            /// <param name="unit">
            ///
            /// </param>
            [<Import("get", "animejs/utils")>]
            static member get (targetSelector: Animejs.DOMTargetSelector, propName: string) : string = nativeOnly
            /// <param name="targetSelector">
            ///
            /// </param>
            /// <param name="propName">
            ///
            /// </param>
            /// <param name="unit">
            ///
            /// </param>
            [<Import("get", "animejs/utils")>]
            static member get (targetSelector: ResizeArray<Animejs.JSTarget>, propName: string) : U2<float, string> = nativeOnly
            /// <param name="targetSelector">
            ///
            /// </param>
            /// <param name="propName">
            ///
            /// </param>
            /// <param name="unit">
            ///
            /// </param>
            [<Import("get", "animejs/utils")>]
            static member get (targetSelector: Animejs.JSTarget, propName: string) : U2<float, string> = nativeOnly
            /// <param name="targetSelector">
            ///
            /// </param>
            /// <param name="propName">
            ///
            /// </param>
            /// <param name="unit">
            ///
            /// </param>
            [<Import("get", "animejs/utils")>]
            static member get (targetSelector: Animejs.JSTargetsParam, propName: string) : U2<float, string> = nativeOnly
            /// <param name="targetSelector">
            ///
            /// </param>
            /// <param name="propName">
            ///
            /// </param>
            /// <param name="unit">
            ///
            /// </param>
            [<Import("get", "animejs/utils")>]
            static member get (targetSelector: ResizeArray<Animejs.DOMTargetSelector>, propName: string, unit: string) : string = nativeOnly
            /// <param name="targetSelector">
            ///
            /// </param>
            /// <param name="propName">
            ///
            /// </param>
            /// <param name="unit">
            ///
            /// </param>
            [<Import("get", "animejs/utils")>]
            static member get (targetSelector: Glutinum.Web.HTMLElement, propName: string, unit: string) : string = nativeOnly
            /// <param name="targetSelector">
            ///
            /// </param>
            /// <param name="propName">
            ///
            /// </param>
            /// <param name="unit">
            ///
            /// </param>
            [<Import("get", "animejs/utils")>]
            static member get (targetSelector: Glutinum.Web.SVGElement, propName: string, unit: string) : string = nativeOnly
            /// <param name="targetSelector">
            ///
            /// </param>
            /// <param name="propName">
            ///
            /// </param>
            /// <param name="unit">
            ///
            /// </param>
            [<Import("get", "animejs/utils")>]
            static member get (targetSelector: Glutinum.Web.NodeList, propName: string, unit: string) : string = nativeOnly
            /// <param name="targetSelector">
            ///
            /// </param>
            /// <param name="propName">
            ///
            /// </param>
            /// <param name="unit">
            ///
            /// </param>
            [<Import("get", "animejs/utils")>]
            static member get (targetSelector: string, propName: string, unit: string) : string = nativeOnly
            /// <param name="targetSelector">
            ///
            /// </param>
            /// <param name="propName">
            ///
            /// </param>
            /// <param name="unit">
            ///
            /// </param>
            [<Import("get", "animejs/utils")>]
            static member get (targetSelector: Animejs.DOMTargetsParam, propName: string, unit: string) : string = nativeOnly
            /// <param name="targetSelector">
            ///
            /// </param>
            /// <param name="propName">
            ///
            /// </param>
            /// <param name="unit">
            ///
            /// </param>
            [<Import("get", "animejs/utils")>]
            static member get (targetSelector: ResizeArray<Animejs.TargetSelector>, propName: string, unit: bool) : float = nativeOnly
            /// <param name="targetSelector">
            ///
            /// </param>
            /// <param name="propName">
            ///
            /// </param>
            /// <param name="unit">
            ///
            /// </param>
            [<Import("get", "animejs/utils")>]
            static member get (targetSelector: Glutinum.Web.HTMLElement, propName: string, unit: bool) : float = nativeOnly
            /// <param name="targetSelector">
            ///
            /// </param>
            /// <param name="propName">
            ///
            /// </param>
            /// <param name="unit">
            ///
            /// </param>
            [<Import("get", "animejs/utils")>]
            static member get (targetSelector: Glutinum.Web.SVGElement, propName: string, unit: bool) : float = nativeOnly
            /// <param name="targetSelector">
            ///
            /// </param>
            /// <param name="propName">
            ///
            /// </param>
            /// <param name="unit">
            ///
            /// </param>
            [<Import("get", "animejs/utils")>]
            static member get (targetSelector: Animejs.JSTarget, propName: string, unit: bool) : float = nativeOnly
            /// <param name="targetSelector">
            ///
            /// </param>
            /// <param name="propName">
            ///
            /// </param>
            /// <param name="unit">
            ///
            /// </param>
            [<Import("get", "animejs/utils")>]
            static member get (targetSelector: Glutinum.Web.NodeList, propName: string, unit: bool) : float = nativeOnly
            /// <param name="targetSelector">
            ///
            /// </param>
            /// <param name="propName">
            ///
            /// </param>
            /// <param name="unit">
            ///
            /// </param>
            [<Import("get", "animejs/utils")>]
            static member get (targetSelector: string, propName: string, unit: bool) : float = nativeOnly
            /// <param name="targetSelector">
            ///
            /// </param>
            /// <param name="propName">
            ///
            /// </param>
            /// <param name="unit">
            ///
            /// </param>
            [<Import("get", "animejs/utils")>]
            static member get (targetSelector: Animejs.TargetsParam, propName: string, unit: bool) : float = nativeOnly
            [<Import("set", "animejs/utils")>]
            static member set (targets: ResizeArray<Animejs.TargetSelector>, parameters: Animejs.AnimationParams) : Animejs.JSAnimation = nativeOnly
            [<Import("set", "animejs/utils")>]
            static member set (targets: Glutinum.Web.HTMLElement, parameters: Animejs.AnimationParams) : Animejs.JSAnimation = nativeOnly
            [<Import("set", "animejs/utils")>]
            static member set (targets: Glutinum.Web.SVGElement, parameters: Animejs.AnimationParams) : Animejs.JSAnimation = nativeOnly
            [<Import("set", "animejs/utils")>]
            static member set (targets: Animejs.JSTarget, parameters: Animejs.AnimationParams) : Animejs.JSAnimation = nativeOnly
            [<Import("set", "animejs/utils")>]
            static member set (targets: Glutinum.Web.NodeList, parameters: Animejs.AnimationParams) : Animejs.JSAnimation = nativeOnly
            [<Import("set", "animejs/utils")>]
            static member set (targets: string, parameters: Animejs.AnimationParams) : Animejs.JSAnimation = nativeOnly
            [<Import("set", "animejs/utils")>]
            static member set (targets: Animejs.TargetsParam, parameters: Animejs.AnimationParams) : Animejs.JSAnimation = nativeOnly
            [<Import("remove", "animejs/utils")>]
            static member remove (targets: ResizeArray<Animejs.TargetSelector>, ?renderable: U2<Animejs.Renderable, Animejs.WAAPIAnimation>, ?propertyName: string) : Animejs.TargetsArray = nativeOnly
            [<Import("remove", "animejs/utils")>]
            static member remove (targets: Glutinum.Web.HTMLElement, ?renderable: U2<Animejs.Renderable, Animejs.WAAPIAnimation>, ?propertyName: string) : Animejs.TargetsArray = nativeOnly
            [<Import("remove", "animejs/utils")>]
            static member remove (targets: Glutinum.Web.SVGElement, ?renderable: U2<Animejs.Renderable, Animejs.WAAPIAnimation>, ?propertyName: string) : Animejs.TargetsArray = nativeOnly
            [<Import("remove", "animejs/utils")>]
            static member remove (targets: Animejs.JSTarget, ?renderable: U2<Animejs.Renderable, Animejs.WAAPIAnimation>, ?propertyName: string) : Animejs.TargetsArray = nativeOnly
            [<Import("remove", "animejs/utils")>]
            static member remove (targets: Glutinum.Web.NodeList, ?renderable: U2<Animejs.Renderable, Animejs.WAAPIAnimation>, ?propertyName: string) : Animejs.TargetsArray = nativeOnly
            [<Import("remove", "animejs/utils")>]
            static member remove (targets: string, ?renderable: U2<Animejs.Renderable, Animejs.WAAPIAnimation>, ?propertyName: string) : Animejs.TargetsArray = nativeOnly
            [<Import("remove", "animejs/utils")>]
            static member remove (targets: Animejs.TargetsParam, ?renderable: U2<Animejs.Renderable, Animejs.WAAPIAnimation>, ?propertyName: string) : Animejs.TargetsArray = nativeOnly
            /// <param name="targets">
            ///
            /// </param>
            [<Import("$", "animejs/utils")>]
            static member ``$`` (targets: ResizeArray<Animejs.DOMTargetSelector>) : Animejs.DOMTargetsArray = nativeOnly
            /// <param name="targets">
            ///
            /// </param>
            [<Import("$", "animejs/utils")>]
            static member ``$`` (targets: Glutinum.Web.HTMLElement) : Animejs.DOMTargetsArray = nativeOnly
            /// <param name="targets">
            ///
            /// </param>
            [<Import("$", "animejs/utils")>]
            static member ``$`` (targets: Glutinum.Web.SVGElement) : Animejs.DOMTargetsArray = nativeOnly
            /// <param name="targets">
            ///
            /// </param>
            [<Import("$", "animejs/utils")>]
            static member ``$`` (targets: Glutinum.Web.NodeList) : Animejs.DOMTargetsArray = nativeOnly
            /// <param name="targets">
            ///
            /// </param>
            [<Import("$", "animejs/utils")>]
            static member ``$`` (targets: string) : Animejs.DOMTargetsArray = nativeOnly
            /// <param name="targets">
            ///
            /// </param>
            [<Import("$", "animejs/utils")>]
            static member ``$`` (targets: Animejs.DOMTargetsParam) : Animejs.DOMTargetsArray = nativeOnly
            /// <param name="targets">
            ///
            /// </param>
            [<Import("$", "animejs/utils")>]
            static member ``$`` (targets: ResizeArray<Animejs.JSTarget>) : Animejs.JSTargetsArray = nativeOnly
            /// <param name="targets">
            ///
            /// </param>
            [<Import("$", "animejs/utils")>]
            static member ``$`` (targets: Animejs.JSTarget) : Animejs.JSTargetsArray = nativeOnly
            /// <param name="targets">
            ///
            /// </param>
            [<Import("$", "animejs/utils")>]
            static member ``$`` (targets: Animejs.JSTargetsParam) : Animejs.JSTargetsArray = nativeOnly
            /// <param name="targets">
            ///
            /// </param>
            [<Import("$", "animejs/utils")>]
            static member ``$`` (targets: ResizeArray<Animejs.TargetSelector>) : Animejs.TargetsArray = nativeOnly
            /// <param name="targets">
            ///
            /// </param>
            [<Import("$", "animejs/utils")>]
            static member ``$`` (targets: Animejs.TargetsParam) : Animejs.TargetsArray = nativeOnly
            [<Import("cleanInlineStyles", "animejs/utils")>]
            static member cleanInlineStyles<'T> (renderable: 'T) : 'T = nativeOnly
            [<Import("stagger", "animejs/utils")>]
            static member stagger (``val``: float, ?``params``: Animejs.StaggerParams) : Animejs.StaggerFunction<float> = nativeOnly
            [<Import("stagger", "animejs/utils")>]
            static member stagger (``val``: string, ?``params``: Animejs.StaggerParams) : Animejs.StaggerFunction<string> = nativeOnly
            [<Import("stagger", "animejs/utils")>]
            static member stagger (``val``: (float * float), ?``params``: Animejs.StaggerParams) : Animejs.StaggerFunction<float> = nativeOnly
            [<Import("stagger", "animejs/utils")>]
            static member stagger (``val``: (string * string), ?``params``: Animejs.StaggerParams) : Animejs.StaggerFunction<string> = nativeOnly
            [<Import("forEachChildren", "animejs/utils")>]
            static member forEachChildren (parent: obj, callback: Action, ?reverse: bool, ?prevProp: string, ?nextProp: string) : unit = nativeOnly
            [<Import("addChild", "animejs/utils")>]
            static member addChild (parent: obj, child: obj, ?sortMethod: Action, ?prevProp: string, ?nextProp: string) : unit = nativeOnly
            [<Import("removeChild", "animejs/utils")>]
            static member removeChild (parent: obj, child: obj, ?prevProp: string, ?nextProp: string) : unit = nativeOnly

        type UtilityFunction =
            Animejs.UtilityFunction

        type ChainablesMap =
            Animejs.ChainablesMap

        type ChainedUtilsResult =
            Animejs.ChainedUtilsResult

        type ChainableUtil =
            Animejs.ChainableUtil

        type ChainedRoundPad =
            Animejs.ChainedRoundPad

        type ChainedPadStart =
            Animejs.ChainedPadStart

        type ChainedPadEnd =
            Animejs.ChainedPadEnd

        type ChainedWrap =
            Animejs.ChainedWrap

        type ChainedMapRange =
            Animejs.ChainedMapRange

        type ChainedDegToRad =
            Animejs.ChainedDegToRad

        type ChainedRadToDeg =
            Animejs.ChainedRadToDeg

        type ChainedSnap =
            Animejs.ChainedSnap

        type ChainedClamp =
            Animejs.ChainedClamp

        type ChainedRound =
            Animejs.ChainedRound

        type ChainedLerp =
            Animejs.ChainedLerp

        type ChainedDamp =
            Animejs.ChainedDamp

        type RandomNumberGenerator =
            Animejs.RandomNumberGenerator

    module waapi =

        [<AbstractClass>]
        [<Erase>]
        type Exports =
            /// <param name="targets">
            ///
            /// </param>
            /// <param name="params">
            ///
            /// </param>
            [<Import("WAAPIAnimation", "animejs/waapi"); EmitConstructor>]
            static member WAAPIAnimation (targets: ResizeArray<Animejs.DOMTargetSelector>, ``params``: Animejs.WAAPIAnimationParams) : WAAPIAnimation = nativeOnly
            /// <param name="targets">
            ///
            /// </param>
            /// <param name="params">
            ///
            /// </param>
            [<Import("WAAPIAnimation", "animejs/waapi"); EmitConstructor>]
            static member WAAPIAnimation (targets: Glutinum.Web.HTMLElement, ``params``: Animejs.WAAPIAnimationParams) : WAAPIAnimation = nativeOnly
            /// <param name="targets">
            ///
            /// </param>
            /// <param name="params">
            ///
            /// </param>
            [<Import("WAAPIAnimation", "animejs/waapi"); EmitConstructor>]
            static member WAAPIAnimation (targets: Glutinum.Web.SVGElement, ``params``: Animejs.WAAPIAnimationParams) : WAAPIAnimation = nativeOnly
            /// <param name="targets">
            ///
            /// </param>
            /// <param name="params">
            ///
            /// </param>
            [<Import("WAAPIAnimation", "animejs/waapi"); EmitConstructor>]
            static member WAAPIAnimation (targets: Glutinum.Web.NodeList, ``params``: Animejs.WAAPIAnimationParams) : WAAPIAnimation = nativeOnly
            /// <param name="targets">
            ///
            /// </param>
            /// <param name="params">
            ///
            /// </param>
            [<Import("WAAPIAnimation", "animejs/waapi"); EmitConstructor>]
            static member WAAPIAnimation (targets: string, ``params``: Animejs.WAAPIAnimationParams) : WAAPIAnimation = nativeOnly
            /// <param name="targets">
            ///
            /// </param>
            /// <param name="params">
            ///
            /// </param>
            [<Import("WAAPIAnimation", "animejs/waapi"); EmitConstructor>]
            static member WAAPIAnimation (targets: Animejs.DOMTargetsParam, ``params``: Animejs.WAAPIAnimationParams) : WAAPIAnimation = nativeOnly

        type WAAPIAnimation =
            Animejs.WAAPIAnimation

    type FunctionValue =
        FunctionValue<Animejs.FunctionValueReturn>

    module Animatable =

        [<AllowNullLiteral>]
        [<Interface>]
        type animations =
            [<EmitIndexer>]
            abstract member Item: key: string -> Animejs.JSAnimation with get, set

    module Draggable =

        [<AllowNullLiteral>]
        [<Interface>]
        type scroll =
            abstract member x: float with get, set
            abstract member y: float with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (x: float, y: float) : scroll = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type overshootCoords =
            abstract member x: float with get, set
            abstract member y: float with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (x: float, y: float) : overshootCoords = nativeOnly

    module Scope =

        [<AllowNullLiteral>]
        [<Interface>]
        type methods =
            [<EmitIndexer>]
            abstract member Item: key: string -> Animejs.ScopeMethod with get, set

        [<AllowNullLiteral>]
        [<Interface>]
        type matches =
            [<EmitIndexer>]
            abstract member Item: key: string -> bool with get, set

        [<AllowNullLiteral>]
        [<Interface>]
        type mediaQueryLists =
            [<EmitIndexer>]
            abstract member Item: key: string -> Glutinum.Web.MediaQueryList with get, set

    module Timeline =

        [<AllowNullLiteral>]
        [<Interface>]
        type labels =
            [<EmitIndexer>]
            abstract member Item: key: string -> float with get, set

    module DefaultsParams =

        [<RequireQualifiedAccess>]
        [<Erase(CaseRules.None)>]
        type composition =
            | none
            | replace
            | blend
            | Case1 of Animejs.dist.modules.core.consts.compositionTypes

            [<Emit("$0")>]
            static member op_Implicit(value: Animejs.dist.modules.core.consts.compositionTypes) : composition = nativeOnly

            [<Emit("$0")>]
            static member op_ErasedCast(value: Animejs.dist.modules.core.consts.compositionTypes) : composition = nativeOnly

    module StaggerParams =

        [<RequireQualifiedAccess>]
        [<Erase(CaseRules.None)>]
        type from =
            | first
            | center
            | last
            | random
            | Case1 of float
            | Case2 of ResizeArray<float>

            [<Emit("$0")>]
            static member op_Implicit(value: float) : from = nativeOnly

            [<Emit("$0")>]
            static member op_ErasedCast(value: float) : from = nativeOnly

            [<Emit("$0")>]
            static member op_Implicit(value: ResizeArray<float>) : from = nativeOnly

            [<Emit("$0")>]
            static member op_ErasedCast(value: ResizeArray<float>) : from = nativeOnly

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type axis =
            | x
            | y
            | z

        module ``use`` =

            module U2 =

                type Case2 =
                    delegate of target: Animejs.Target * i: float * length: float -> float

    module Tween =

        type _setter =
            delegate of target: obj * value: float * tween: Animejs.Tween -> unit

    module PercentageKeyframes =

        [<AllowNullLiteral>]
        [<Interface>]
        type PercentageKeyframes =
            abstract member ease: Animejs.EasingParam option with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (?ease: Animejs.EasingParam) : PercentageKeyframes = nativeOnly

    module DurationKeyframes =

        module ResizeArray =

            [<AllowNullLiteral>]
            [<Interface>]
            type ReturnType =
                abstract member duration: Animejs.TweenParamValue option with get, set
                abstract member delay: Animejs.TweenParamValue option with get, set
                abstract member ease: U2<Animejs.EasingParam, Animejs.FunctionValue> option with get, set
                abstract member modifier: Animejs.TweenModifier option with get, set
                abstract member composition: Animejs.TweenComposition option with get, set

    module ScopeParams =

        [<AllowNullLiteral>]
        [<Interface>]
        type mediaQueries =
            [<EmitIndexer>]
            abstract member Item: key: string -> string with get, set

    module ScrollObserverAxisCallback =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type ReturnType =
            | x
            | y

    module ScrollObserverParams =

        [<RequireQualifiedAccess>]
        [<Erase(CaseRules.None)>]
        type axis =
            | x
            | y
            | Case1 of Animejs.ScrollObserverAxisCallback
            | Case2 of (Animejs.ScrollObserver -> ScrollObserverParams.axis.Cases.Case2)

            [<Emit("$0")>]
            static member op_Implicit(value: Animejs.ScrollObserverAxisCallback) : axis = nativeOnly

            [<Emit("$0")>]
            static member op_ErasedCast(value: Animejs.ScrollObserverAxisCallback) : axis = nativeOnly

            [<Emit("$0")>]
            static member op_Implicit(value: (Animejs.ScrollObserver -> ScrollObserverParams.axis.Cases.Case2)) : axis = nativeOnly

            [<Emit("$0")>]
            static member op_ErasedCast(value: (Animejs.ScrollObserver -> ScrollObserverParams.axis.Cases.Case2)) : axis = nativeOnly

        module axis =

            module Cases =

                [<RequireQualifiedAccess>]
                [<Erase(CaseRules.None)>]
                type Case2 =
                    | x
                    | y
                    | Case1 of Animejs.ScrollObserverAxisCallback

                    [<Emit("$0")>]
                    static member op_Implicit(value: Animejs.ScrollObserverAxisCallback) : Case2 = nativeOnly

                    [<Emit("$0")>]
                    static member op_ErasedCast(value: Animejs.ScrollObserverAxisCallback) : Case2 = nativeOnly

    module SplitTemplateParams =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type wrap =
            | [<CompiledValue(true)>] True
            | [<CompiledValue(false)>] False
            | hidden
            | clip
            | visible
            | scroll
            | auto

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type clone =
            | [<CompiledValue(true)>] True
            | [<CompiledValue(false)>] False
            | top
            | right
            | bottom
            | left
            | center

    module ScrambleTextParams =

        [<RequireQualifiedAccess>]
        [<Erase(CaseRules.None)>]
        type from =
            | left
            | center
            | right
            | random
            | auto
            | Case1 of float

            [<Emit("$0")>]
            static member op_Implicit(value: float) : from = nativeOnly

            [<Emit("$0")>]
            static member op_ErasedCast(value: float) : from = nativeOnly

        type onChange =
            delegate of arg0: string * arg1: float -> unit

        module text =

            module U2 =

                type Case2 =
                    delegate of arg0: Animejs.Target * arg1: float * arg2: Animejs.TargetsArray -> string

        module chars =

            module U2 =

                type Case2 =
                    delegate of arg0: Animejs.Target * arg1: float * arg2: Animejs.TargetsArray -> string

        module duration =

            module U2 =

                type Case2 =
                    delegate of arg0: Animejs.Target * arg1: float * arg2: Animejs.TargetsArray -> float

        module revealDelay =

            module U2 =

                type Case2 =
                    delegate of arg0: Animejs.Target * arg1: float * arg2: Animejs.TargetsArray -> float

        module delay =

            module U2 =

                type Case2 =
                    delegate of arg0: Animejs.Target * arg1: float * arg2: Animejs.TargetsArray -> float

    module Exports =

        [<AllowNullLiteral>]
        [<Interface>]
        type createMotionPath__ =
            abstract member translateX: Animejs.FunctionValue with get, set
            abstract member translateY: Animejs.FunctionValue with get, set
            abstract member rotate: Animejs.FunctionValue with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (translateX: Animejs.FunctionValue, translateY: Animejs.FunctionValue, rotate: Animejs.FunctionValue) : createMotionPath__ = nativeOnly
