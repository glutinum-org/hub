namespace rec Glutinum

open Fable.Core
open Fable.Core.JsInterop
open System

// You need to add Glutinum.Types NuGet package to your project
open Glutinum.Types.TypeScript

// You need to add Glutinum.Web NuGet package to your project

module ChartJs =

    [<AbstractClass>]
    [<Erase>]
    type Exports =
        [<Import("_adapters", "chart.js")>]
        static member inline _adapters: Exports._adapters__.Type = nativeOnly
        [<Import("animator", "chart.js")>]
        static member inline animator: ChartJs.Animator = nativeOnly
        [<Import("easingEffects", "chart.js/helpers")>]
        static member inline easingEffects: Exports.easingEffects__.Type = nativeOnly
        [<Import("_detectPlatform", "chart.js")>]
        static member _detectPlatform (canvas: obj) : U2<ChartJs.dist.platform.platform_basic.BasicPlatform, ChartJs.dist.platform.platform_dom.DomPlatform> = nativeOnly
        [<Import("Colors", "chart.js")>]
        static member inline Colors: Exports.Colors__.Type = nativeOnly
        [<Import("BarController", "chart.js")>]
        static member inline BarController: Exports.BarController__.Type = nativeOnly
        [<Import("BubbleController", "chart.js")>]
        static member inline BubbleController: Exports.BubbleController__.Type = nativeOnly
        [<Import("LineController", "chart.js")>]
        static member inline LineController: Exports.LineController__.Type = nativeOnly
        [<Import("ScatterController", "chart.js")>]
        static member inline ScatterController: Exports.ScatterController__.Type = nativeOnly
        [<Import("DoughnutController", "chart.js")>]
        static member inline DoughnutController: Exports.DoughnutController__.Type = nativeOnly
        [<Import("PieController", "chart.js")>]
        static member inline PieController: Exports.PieController__.Type = nativeOnly
        [<Import("PolarAreaController", "chart.js")>]
        static member inline PolarAreaController: Exports.PolarAreaController__.Type = nativeOnly
        [<Import("RadarController", "chart.js")>]
        static member inline RadarController: Exports.RadarController__.Type = nativeOnly
        [<Import("registerables", "chart.js")>]
        static member inline registerables: ReadonlyArray<ChartJs.ChartComponentLike> = nativeOnly
        [<Import("defaults", "chart.js")>]
        static member inline defaults: ChartJs.Defaults = nativeOnly
        [<Import("Interaction", "chart.js")>]
        static member inline Interaction: Exports.Interaction__.Type = nativeOnly
        [<Import("layouts", "chart.js")>]
        static member inline layouts: Exports.layouts__.Type = nativeOnly
        [<Import("registry", "chart.js")>]
        static member inline registry: ChartJs.Registry = nativeOnly
        [<Import("Ticks", "chart.js")>]
        static member inline Ticks: Exports.Ticks__.Type = nativeOnly
        [<Import("LineElement", "chart.js")>]
        static member inline LineElement: Exports.LineElement__.Type = nativeOnly
        [<Import("BarElement", "chart.js")>]
        static member inline BarElement: Exports.BarElement__.Type = nativeOnly
        [<Import("Decimation", "chart.js")>]
        static member inline Decimation: ChartJs.Plugin = nativeOnly
        [<Import("Filler", "chart.js")>]
        static member inline Filler: ChartJs.Plugin = nativeOnly
        [<Import("Legend", "chart.js")>]
        static member inline Legend: ChartJs.Plugin = nativeOnly
        [<Import("SubTitle", "chart.js")>]
        static member inline SubTitle: ChartJs.Plugin = nativeOnly
        [<Import("Title", "chart.js")>]
        static member inline Title: ChartJs.Plugin = nativeOnly
        [<Import("Tooltip", "chart.js")>]
        static member inline Tooltip: ChartJs.Tooltip = nativeOnly
        [<Import("CategoryScale", "chart.js")>]
        static member inline CategoryScale: Exports.CategoryScale__.Type = nativeOnly
        [<Import("LinearScale", "chart.js")>]
        static member inline LinearScale: Exports.LinearScale__.Type = nativeOnly
        [<Import("LogarithmicScale", "chart.js")>]
        static member inline LogarithmicScale: Exports.LogarithmicScale__.Type = nativeOnly
        [<Import("TimeScale", "chart.js")>]
        static member inline TimeScale: Exports.TimeScale__.Type = nativeOnly
        [<Import("RadialLinearScale", "chart.js")>]
        static member inline RadialLinearScale: Exports.RadialLinearScale__.Type = nativeOnly
        [<Import("Animator", "chart.js"); EmitConstructor>]
        static member Animator () : Animator = nativeOnly
        [<ImportDefault("chart.js"); EmitConstructor>]
        static member Config (config: obj) : Config = nativeOnly
        [<ImportDefault("chart.js"); EmitConstructor>]
        static member Element<'T, 'O> () : Element<'T, 'O> = nativeOnly
        [<ImportDefault("chart.js"); EmitConstructor>]
        static member PluginService () : PluginService = nativeOnly
        [<ImportDefault("chart.js"); EmitConstructor>]
        static member ArcElement (cfg: obj) : ArcElement = nativeOnly
        [<ImportDefault("chart.js"); EmitConstructor>]
        static member PointElement (cfg: obj) : PointElement = nativeOnly
        [<ImportDefault("chart.js"); EmitConstructor>]
        static member LinearScaleBase () : LinearScaleBase = nativeOnly
        [<Import("Animations", "chart.js"); EmitConstructor>]
        static member Animations (chart: ChartJs.dist.types.Chart, animations: ChartJs.AnyObject) : Animations = nativeOnly
        [<Import("DatasetController", "chart.js"); EmitConstructor>]
        static member DatasetController<'TType, 'TElement, 'TDatasetElement, 'TParsedData> (chart: ChartJs.dist.types.Chart, datasetIndex: float) : DatasetController<'TType, 'TElement, 'TDatasetElement, 'TParsedData> = nativeOnly
        [<Import("Scale", "chart.js"); EmitConstructor>]
        static member Scale (cfg: Exports.Scale.cfg) : Scale = nativeOnly
        [<Import("BasePlatform", "chart.js"); EmitConstructor>]
        static member BasePlatform () : BasePlatform = nativeOnly
        [<Import("BasicPlatform", "chart.js"); EmitConstructor>]
        static member BasicPlatform () : BasicPlatform = nativeOnly
        [<Import("DomPlatform", "chart.js"); EmitConstructor>]
        static member DomPlatform () : DomPlatform = nativeOnly
        [<Import("TimeSeriesScale", "chart.js"); EmitConstructor>]
        static member TimeSeriesScale () : TimeSeriesScale = nativeOnly
        [<Import("Animation", "chart.js"); EmitConstructor>]
        static member Animation (cfg: ChartJs.AnyObject, target: ChartJs.AnyObject, prop: string, ?``to``: obj) : Animation = nativeOnly
        [<Import("Chart", "chart.js"); EmitConstructor>]
        static member Chart<'TType, 'TData, 'TLabel> (item: string, config: ChartJs.ChartConfiguration<'TType, 'TData, 'TLabel>) : Chart<'TType, 'TData, 'TLabel> = nativeOnly
        [<Import("Chart", "chart.js"); EmitConstructor>]
        static member Chart<'TType, 'TData, 'TLabel> (item: string, config: ChartJs.ChartConfigurationCustomTypesPerDataset<'TType, 'TData, 'TLabel>) : Chart<'TType, 'TData, 'TLabel> = nativeOnly
        [<Import("Chart", "chart.js"); EmitConstructor>]
        static member Chart<'TType, 'TData, 'TLabel> (item: Glutinum.Web.CanvasRenderingContext2D, config: ChartJs.ChartConfiguration<'TType, 'TData, 'TLabel>) : Chart<'TType, 'TData, 'TLabel> = nativeOnly
        [<Import("Chart", "chart.js"); EmitConstructor>]
        static member Chart<'TType, 'TData, 'TLabel> (item: Glutinum.Web.CanvasRenderingContext2D, config: ChartJs.ChartConfigurationCustomTypesPerDataset<'TType, 'TData, 'TLabel>) : Chart<'TType, 'TData, 'TLabel> = nativeOnly
        [<Import("Chart", "chart.js"); EmitConstructor>]
        static member Chart<'TType, 'TData, 'TLabel> (item: Glutinum.Web.HTMLCanvasElement, config: ChartJs.ChartConfiguration<'TType, 'TData, 'TLabel>) : Chart<'TType, 'TData, 'TLabel> = nativeOnly
        [<Import("Chart", "chart.js"); EmitConstructor>]
        static member Chart<'TType, 'TData, 'TLabel> (item: Glutinum.Web.HTMLCanvasElement, config: ChartJs.ChartConfigurationCustomTypesPerDataset<'TType, 'TData, 'TLabel>) : Chart<'TType, 'TData, 'TLabel> = nativeOnly
        [<Import("Chart", "chart.js"); EmitConstructor>]
        static member Chart<'TType, 'TData, 'TLabel> (item: Exports.Chart.item, config: ChartJs.ChartConfiguration<'TType, 'TData, 'TLabel>) : Chart<'TType, 'TData, 'TLabel> = nativeOnly
        [<Import("Chart", "chart.js"); EmitConstructor>]
        static member Chart<'TType, 'TData, 'TLabel> (item: Exports.Chart.item, config: ChartJs.ChartConfigurationCustomTypesPerDataset<'TType, 'TData, 'TLabel>) : Chart<'TType, 'TData, 'TLabel> = nativeOnly
        [<Import("Chart", "chart.js"); EmitConstructor>]
        static member Chart<'TType, 'TData, 'TLabel> (item: obj, config: ChartJs.ChartConfiguration<'TType, 'TData, 'TLabel>) : Chart<'TType, 'TData, 'TLabel> = nativeOnly
        [<Import("Chart", "chart.js"); EmitConstructor>]
        static member Chart<'TType, 'TData, 'TLabel> (item: obj, config: ChartJs.ChartConfigurationCustomTypesPerDataset<'TType, 'TData, 'TLabel>) : Chart<'TType, 'TData, 'TLabel> = nativeOnly
        [<Import("Chart", "chart.js"); EmitConstructor>]
        static member Chart<'TType, 'TData, 'TLabel> (item: ChartJs.ChartItem, config: U2<ChartJs.ChartConfiguration<'TType, 'TData, 'TLabel>, ChartJs.ChartConfigurationCustomTypesPerDataset<'TType, 'TData, 'TLabel>>) : Chart<'TType, 'TData, 'TLabel> = nativeOnly

    type TimeSeriesScale =
        ChartJs.dist.scales.scale_timeseries.TimeSeriesScale

    type Animation =
        ChartJs.dist.types.animation.Animation

    type Chart<'TType, 'TData, 'TLabel> =
        ChartJs.dist.types.Chart<'TType, 'TData, 'TLabel>

    type Chart<'TType, 'TData> =
        Chart<'TType, 'TData, obj>

    type Chart<'TType> =
        Chart<'TType, ResizeArray<U4<float, ChartJs.Point, float * float, ChartJs.BubbleDataPoint> option>, obj>

    type Chart =
        Chart<ChartJs.ChartType, ResizeArray<U4<float, ChartJs.Point, float * float, ChartJs.BubbleDataPoint> option>, obj>

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type TimeUnit =
        | millisecond
        | second
        | minute
        | hour
        | day
        | week
        | month
        | quarter
        | year

    [<AllowNullLiteral>]
    [<Interface>]
    type DateAdapter<'T> =
        abstract member options: 'T with get
        /// <summary>
        /// Will called with chart options after adapter creation.
        /// </summary>
        abstract member init: chartOptions: ChartJs.ChartOptions -> unit
        /// <summary>
        /// Returns a map of time formats for the supported formatting units defined
        /// in Unit as well as 'datetime' representing a detailed date/time string.
        /// </summary>
        abstract member formats: unit -> DateAdapter.formats
        /// <summary>
        /// Parses the given <c>value</c> and return the associated timestamp.
        /// </summary>
        /// <param name="value">
        /// the value to parse (usually comes from the data)
        /// </param>
        /// <param name="format">
        /// the expected data format
        /// </param>
        abstract member parse: value: obj * ?format: string -> float option
        /// <summary>
        /// Returns the formatted date in the specified <c>format</c> for a given <c>timestamp</c>.
        /// </summary>
        /// <param name="timestamp">
        /// the timestamp to format
        /// </param>
        /// <param name="format">
        /// the date/time token
        /// </param>
        abstract member format: timestamp: float * format: string -> string
        /// <summary>
        /// Adds the specified <c>amount</c> of <c>unit</c> to the given <c>timestamp</c>.
        /// </summary>
        /// <param name="timestamp">
        /// the input timestamp
        /// </param>
        /// <param name="amount">
        /// the amount to add
        /// </param>
        /// <param name="unit">
        /// the unit as string
        /// </param>
        abstract member add: timestamp: float * amount: float * unit: ChartJs.TimeUnit -> float
        /// <summary>
        /// Returns the number of <c>unit</c> between the given timestamps.
        /// </summary>
        /// <param name="a">
        /// the input timestamp (reference)
        /// </param>
        /// <param name="b">
        /// the timestamp to subtract
        /// </param>
        /// <param name="unit">
        /// the unit as string
        /// </param>
        abstract member diff: a: float * b: float * unit: ChartJs.TimeUnit -> float
        /// <summary>
        /// Returns start of <c>unit</c> for the given <c>timestamp</c>.
        /// </summary>
        /// <param name="timestamp">
        /// the input timestamp
        /// </param>
        /// <param name="unit">
        /// the unit as string
        /// </param>
        /// <param name="weekday">
        /// the ISO day of the week with 1 being Monday
        /// and 7 being Sunday (only needed if param *unit* is <c>isoWeek</c>).
        /// </param>
        abstract member startOf: timestamp: float * unit: DateAdapter.startOf.unit -> float
        /// <summary>
        /// Returns start of <c>unit</c> for the given <c>timestamp</c>.
        /// </summary>
        /// <param name="timestamp">
        /// the input timestamp
        /// </param>
        /// <param name="unit">
        /// the unit as string
        /// </param>
        /// <param name="weekday">
        /// the ISO day of the week with 1 being Monday
        /// and 7 being Sunday (only needed if param *unit* is <c>isoWeek</c>).
        /// </param>
        abstract member startOf: timestamp: float * unit: DateAdapter.startOf.unit * weekday: float -> float
        /// <summary>
        /// Returns start of <c>unit</c> for the given <c>timestamp</c>.
        /// </summary>
        /// <param name="timestamp">
        /// the input timestamp
        /// </param>
        /// <param name="unit">
        /// the unit as string
        /// </param>
        /// <param name="weekday">
        /// the ISO day of the week with 1 being Monday
        /// and 7 being Sunday (only needed if param *unit* is <c>isoWeek</c>).
        /// </param>
        abstract member startOf: timestamp: float * unit: DateAdapter.startOf.unit * weekday: bool -> float
        /// <summary>
        /// Returns end of <c>unit</c> for the given <c>timestamp</c>.
        /// </summary>
        /// <param name="timestamp">
        /// the input timestamp
        /// </param>
        /// <param name="unit">
        /// the unit as string
        /// </param>
        abstract member endOf: timestamp: float * unit: ChartJs.TimeUnit -> float

    /// <summary>
    /// Please use the module's default export which provides a singleton instance
    /// Note: class is export for typedoc
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type Animator =
        abstract member _request: obj with get, set
        abstract member _charts: obj with get, set
        abstract member _running: bool with get, set
        abstract member _lastDate: float with get, set
        /// <param name="chart">
        ///
        /// </param>
        /// <param name="event">
        /// event name
        /// </param>
        /// <param name="cb">
        /// callback
        /// </param>
        abstract member listen: chart: ChartJs.Chart * event: string * cb: Action -> unit
        /// <summary>
        /// Add animations
        /// </summary>
        /// <param name="chart">
        ///
        /// </param>
        /// <param name="items">
        /// animations
        /// </param>
        abstract member add: chart: ChartJs.Chart * items: ResizeArray<ChartJs.Animation> -> unit
        /// <summary>
        /// Counts number of active animations for the chart
        /// </summary>
        /// <param name="chart">
        ///
        /// </param>
        abstract member has: chart: ChartJs.Chart -> bool
        /// <summary>
        /// Start animating (all charts)
        /// </summary>
        /// <param name="chart">
        ///
        /// </param>
        abstract member start: chart: ChartJs.Chart -> unit
        abstract member running: chart: obj -> bool
        /// <summary>
        /// Stop all animations for the chart
        /// </summary>
        /// <param name="chart">
        ///
        /// </param>
        abstract member stop: chart: ChartJs.Chart -> unit
        /// <summary>
        /// Remove chart from Animator
        /// </summary>
        /// <param name="chart">
        ///
        /// </param>
        abstract member remove: chart: ChartJs.Chart -> bool

    [<AllowNullLiteral>]
    [<Interface>]
    type Config =
        abstract member _config: obj with get, set
        abstract member _scopeCache: obj with get, set
        abstract member _resolverCache: obj with get, set
        abstract member platform: obj with get
        abstract member ``type``: obj with get, set
        abstract member data: obj with get, set
        abstract member options: obj with get, set
        abstract member plugins: obj with get
        abstract member update: unit -> unit
        abstract member clearCache: unit -> unit
        /// <summary>
        /// Returns the option scope keys for resolving dataset options.
        /// These keys do not include the dataset itself, because it is not under options.
        /// </summary>
        /// <param name="datasetType">
        ///
        /// </param>
        abstract member datasetScopeKeys: datasetType: string -> ResizeArray<ResizeArray<string>>
        /// <summary>
        /// Returns the option scope keys for resolving dataset animation options.
        /// These keys do not include the dataset itself, because it is not under options.
        /// </summary>
        /// <param name="datasetType">
        ///
        /// </param>
        /// <param name="transition">
        ///
        /// </param>
        abstract member datasetAnimationScopeKeys: datasetType: string * transition: string -> ResizeArray<ResizeArray<string>>
        /// <summary>
        /// Returns the options scope keys for resolving element options that belong
        /// to an dataset. These keys do not include the dataset itself, because it
        /// is not under options.
        /// </summary>
        /// <param name="datasetType">
        ///
        /// </param>
        /// <param name="elementType">
        ///
        /// </param>
        abstract member datasetElementScopeKeys: datasetType: string * elementType: string -> ResizeArray<ResizeArray<string>>
        /// <summary>
        /// Returns the options scope keys for resolving plugin options.
        /// </summary>
        /// <param name="plugin">
        ///
        /// </param>
        abstract member pluginScopeKeys: plugin: Config.pluginScopeKeys.plugin -> ResizeArray<ResizeArray<string>>
        /// <summary>
        /// Resolves the objects from options and defaults for option value resolution.
        /// </summary>
        /// <param name="mainScope">
        /// The main scope object for options
        /// </param>
        /// <param name="keyLists">
        /// The arrays of keys in resolution order
        /// </param>
        /// <param name="resetCache">
        /// reset the cache for this mainScope
        /// </param>
        abstract member getOptionScopes: mainScope: obj * keyLists: ResizeArray<ResizeArray<string>> * ?resetCache: bool -> obj
        /// <summary>
        /// Returns the option scopes for resolving chart options
        /// </summary>
        abstract member chartOptionScopes: unit -> ResizeArray<obj>
        /// <param name="scopes">
        ///
        /// </param>
        /// <param name="names">
        ///
        /// </param>
        /// <param name="context">
        ///
        /// </param>
        /// <param name="prefixes">
        ///
        /// </param>
        abstract member resolveNamedOptions: scopes: ResizeArray<obj> * names: ResizeArray<string> * context: Action * ?prefixes: ResizeArray<string> -> obj
        /// <param name="scopes">
        ///
        /// </param>
        /// <param name="names">
        ///
        /// </param>
        /// <param name="context">
        ///
        /// </param>
        /// <param name="prefixes">
        ///
        /// </param>
        abstract member resolveNamedOptions: scopes: ResizeArray<obj> * names: ResizeArray<string> * context: obj * ?prefixes: ResizeArray<string> -> obj
        /// <param name="scopes">
        ///
        /// </param>
        /// <param name="names">
        ///
        /// </param>
        /// <param name="context">
        ///
        /// </param>
        /// <param name="prefixes">
        ///
        /// </param>
        abstract member resolveNamedOptions: scopes: ResizeArray<obj> * names: ResizeArray<string> * context: U2<Action, obj> * ?prefixes: ResizeArray<string> -> obj
        /// <param name="scopes">
        ///
        /// </param>
        /// <param name="context">
        ///
        /// </param>
        /// <param name="prefixes">
        ///
        /// </param>
        /// <param name="descriptorDefaults">
        ///
        /// </param>
        abstract member createResolver: scopes: ResizeArray<obj> * ?context: obj * ?prefixes: ResizeArray<string> * ?descriptorDefaults: Config.createResolver.descriptorDefaults -> obj

    [<AllowNullLiteral>]
    [<Interface>]
    type Element<'T, 'O> =
        [<Emit("""import { Element } from "chart.js";
Element.defaults{{=$0}}""")>]
        static member inline defaults
            with get () : obj =
                nativeOnly
            and set (value: obj) =
                nativeOnly
        [<Emit("""import { Element } from "chart.js";
Element.defaultRoutes{{=$0}}""")>]
        static member inline defaultRoutes
            with get () : obj =
                nativeOnly
            and set (value: obj) =
                nativeOnly
        abstract member x: float with get, set
        abstract member y: float with get, set
        abstract member active: bool with get, set
        abstract member options: 'O with get, set
        abstract member ``$animations``: Element._DOLLAR_animations with get, set
        abstract member tooltipPosition: useFinalPosition: bool -> ChartJs.Point
        abstract member hasValue: unit -> bool
        /// <summary>
        /// Gets the current or final value of each prop. Can return extra properties (whole object).
        /// </summary>
        /// <param name="props">
        /// properties to get
        /// </param>
        /// <param name="final">
        /// get the final value (animation target)
        /// </param>
        abstract member getProps<'P>: props: 'P * ?final: bool -> obj
        /// <summary>
        /// Gets the current or final value of each prop. Can return extra properties (whole object).
        /// </summary>
        abstract member getProps<'P>: props: ResizeArray<'P> * ?final: bool -> Element.getProps

    type Element<'T> =
        Element<'T, ChartJs.AnyObject>

    type Element =
        Element<ChartJs.AnyObject, ChartJs.AnyObject>

    [<AllowNullLiteral>]
    [<Interface>]
    type PluginService =
        abstract member _init: ResizeArray<PluginService._init.Item> with get, set
        /// <summary>
        /// Calls enabled plugins for <c>chart</c> on the specified hook and with the given args.
        /// This method immediately returns as soon as a plugin explicitly returns false. The
        /// returned value can be used, for instance, to interrupt the current action.
        /// </summary>
        /// <param name="chart">
        /// The chart instance for which plugins should be called.
        /// </param>
        /// <param name="hook">
        /// The name of the plugin method to call (e.g. 'beforeUpdate').
        /// </param>
        /// <param name="args">
        /// Extra arguments to apply to the hook call.
        /// </param>
        /// <param name="filter">
        /// Filtering function for limiting which plugins are notified
        /// </param>
        /// <returns>
        /// false if any of the plugins return false, else returns true.
        /// </returns>
        abstract member notify: chart: ChartJs.dist.core.core_plugins.Chart * hook: string * ?args: obj * ?filter: ChartJs.filterCallback -> bool
        abstract member invalidate: unit -> unit
        abstract member _oldCache: ResizeArray<PluginService._oldCache.Item> with get, set
        abstract member _cache: ResizeArray<PluginService._cache.Item> with get, set
        abstract member _createDescriptors: chart: obj * all: obj -> ResizeArray<PluginService._createDescriptors.Item>

    type filterCallback =
        delegate of value: filterCallback.value * ?index: float * ?array: ResizeArray<obj> * ?thisArg: obj -> bool

    [<AllowNullLiteral>]
    [<Interface>]
    type IChartComponent =
        abstract member id: string with get, set
        abstract member defaults: obj with get, set
        abstract member overrides: obj option with get, set
        abstract member defaultRoutes: obj with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (id: string, defaults: obj, defaultRoutes: obj, ?overrides: obj) : IChartComponent = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type ArcProps =
        inherit ChartJs.Point
        abstract member startAngle: float with get, set
        abstract member endAngle: float with get, set
        abstract member innerRadius: float with get, set
        abstract member outerRadius: float with get, set
        abstract member circumference: float with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type ArcElement =
        inherit ChartJs.Element<ChartJs.ArcProps, ChartJs.ArcOptions>
        [<Emit("""import { ArcElement } from "chart.js";
ArcElement.id{{=$0}}""")>]
        static member inline id
            with get () : string =
                nativeOnly
            and set (value: string) =
                nativeOnly
        [<Emit("""import { ArcElement } from "chart.js";
ArcElement.defaults{{=$0}}""")>]
        static member inline defaults
            with get () : ArcElement.defaults__ =
                nativeOnly
            and set (value: ArcElement.defaults__) =
                nativeOnly
        [<Emit("""import { ArcElement } from "chart.js";
ArcElement.defaultRoutes{{=$0}}""")>]
        static member inline defaultRoutes
            with get () : ArcElement.defaultRoutes__ =
                nativeOnly
            and set (value: ArcElement.defaultRoutes__) =
                nativeOnly
        [<Emit("""import { ArcElement } from "chart.js";
ArcElement.descriptors{{=$0}}""")>]
        static member inline descriptors
            with get () : ArcElement.descriptors__ =
                nativeOnly
            and set (value: ArcElement.descriptors__) =
                nativeOnly
        abstract member circumference: float with get, set
        abstract member endAngle: float with get, set
        abstract member fullCircles: float with get, set
        abstract member innerRadius: float with get, set
        abstract member outerRadius: float with get, set
        abstract member pixelMargin: float with get, set
        abstract member startAngle: float with get, set
        abstract member inRange: chartX: float * chartY: float * useFinalPosition: bool -> bool
        abstract member getCenterPoint: useFinalPosition: bool -> ArcElement.getCenterPoint
        abstract member tooltipPosition: useFinalPosition: bool -> ArcElement.tooltipPosition
        abstract member draw: ctx: Glutinum.Web.CanvasRenderingContext2D -> unit

    type PointProps =
        ChartJs.Point

    [<AllowNullLiteral>]
    [<Interface>]
    type PointElement =
        inherit ChartJs.Element<ChartJs.PointProps, PointElement.Extends>
        [<Emit("""import { PointElement } from "chart.js";
PointElement.id{{=$0}}""")>]
        static member inline id
            with get () : string =
                nativeOnly
            and set (value: string) =
                nativeOnly
        abstract member parsed: ChartJs.CartesianParsedData with get, set
        abstract member skip: bool option with get, set
        abstract member stop: bool option with get, set
        [<Emit("""import { PointElement } from "chart.js";
PointElement.defaults{{=$0}}""")>]
        static member inline defaults
            with get () : PointElement.defaults__ =
                nativeOnly
            and set (value: PointElement.defaults__) =
                nativeOnly
        [<Emit("""import { PointElement } from "chart.js";
PointElement.defaultRoutes{{=$0}}""")>]
        static member inline defaultRoutes
            with get () : PointElement.defaultRoutes__ =
                nativeOnly
            and set (value: PointElement.defaultRoutes__) =
                nativeOnly
        abstract member inRange: mouseX: float * mouseY: float * ?useFinalPosition: bool -> bool
        abstract member inXRange: mouseX: float * ?useFinalPosition: bool -> bool
        abstract member inYRange: mouseY: float * ?useFinalPosition: bool -> bool
        abstract member getCenterPoint: ?useFinalPosition: bool -> PointElement.getCenterPoint
        abstract member size: ?options: PointElement.size.options -> float
        abstract member draw: ctx: Glutinum.Web.CanvasRenderingContext2D * area: ChartJs.ChartArea -> unit
        abstract member getRange: unit -> obj

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type EasingFunction =
        | linear
        | easeInQuad
        | easeOutQuad
        | easeInOutQuad
        | easeInCubic
        | easeOutCubic
        | easeInOutCubic
        | easeInQuart
        | easeOutQuart
        | easeInOutQuart
        | easeInQuint
        | easeOutQuint
        | easeInOutQuint
        | easeInSine
        | easeOutSine
        | easeInOutSine
        | easeInExpo
        | easeOutExpo
        | easeInOutExpo
        | easeInCirc
        | easeOutCirc
        | easeInOutCirc
        | easeInElastic
        | easeOutElastic
        | easeInOutElastic
        | easeInBack
        | easeOutBack
        | easeInOutBack
        | easeInBounce
        | easeOutBounce
        | easeInOutBounce

    [<AllowNullLiteral>]
    [<Interface>]
    type ColorsPluginOptions =
        abstract member enabled: bool option with get, set
        abstract member forceOverride: bool option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?enabled: bool, ?forceOverride: bool) : ColorsPluginOptions = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type LinearScaleBase =
        inherit ChartJs.dist.core.core_scale.Scale
        abstract member start: float with get, set
        abstract member ``end``: float with get, set
        abstract member _startValue: float with get, set
        abstract member _endValue: float with get, set
        abstract member _valueRange: float with get, set
        /// <summary>
        /// Parse a supported input value to internal representation.
        /// </summary>
        abstract member parse: raw: obj * index: obj -> float
        abstract member handleTickRangeOptions: unit -> unit
        abstract member getTickLimit: unit -> float
        /// <summary>
        /// Used to get the label to display in the tooltip for the given value
        /// </summary>
        abstract member getLabelForValue: value: obj -> string

    type Unit =
        ChartJs.TimeUnit

    [<AllowNullLiteral>]
    [<Interface>]
    type Interval =
        abstract member common: bool with get, set
        abstract member size: float with get, set
        abstract member steps: float option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type AnimationEvent =
        abstract member chart: ChartJs.dist.types.Chart with get, set
        abstract member numSteps: float with get, set
        abstract member initial: bool with get, set
        abstract member currentStep: float with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type Animations =
        abstract member configure: animations: ChartJs.AnyObject -> unit
        abstract member update: target: ChartJs.AnyObject * values: ChartJs.AnyObject -> bool option

    [<AllowNullLiteral>]
    [<Interface>]
    type AnyObject =
        [<EmitIndexer>]
        abstract member Item: key: string -> obj with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type EmptyObject =
        [<EmitIndexer>]
        abstract member Item: key: string -> obj with get, set

    type Color =
        U3<string, Glutinum.Web.CanvasGradient, Glutinum.Web.CanvasPattern>

    [<AllowNullLiteral>]
    [<Interface>]
    type ChartArea =
        abstract member top: float with get, set
        abstract member left: float with get, set
        abstract member right: float with get, set
        abstract member bottom: float with get, set
        abstract member width: float with get, set
        abstract member height: float with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (top: float, left: float, right: float, bottom: float, width: float, height: float) : ChartArea = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type Point =
        abstract member x: float option with get, set
        abstract member y: float option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?x: float, ?y: float) : Point = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type TRBL =
        abstract member top: float with get, set
        abstract member right: float with get, set
        abstract member bottom: float with get, set
        abstract member left: float with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (top: float, right: float, bottom: float, left: float) : TRBL = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type TRBLCorners =
        abstract member topLeft: float with get, set
        abstract member topRight: float with get, set
        abstract member bottomLeft: float with get, set
        abstract member bottomRight: float with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (topLeft: float, topRight: float, bottomLeft: float, bottomRight: float) : TRBLCorners = nativeOnly

    type CornerRadius =
        U2<float, CornerRadius.U2.Case2>

    [<AllowNullLiteral>]
    [<Interface>]
    type RoundedRect =
        abstract member x: float with get, set
        abstract member y: float with get, set
        abstract member w: float with get, set
        abstract member h: float with get, set
        abstract member radius: ChartJs.CornerRadius option with get, set

    type Padding =
        U3<Padding.U3.Case1, float, ChartJs.Point>

    [<AllowNullLiteral>]
    [<Interface>]
    type SplinePoint =
        abstract member x: float with get, set
        abstract member y: float with get, set
        abstract member skip: bool option with get, set
        abstract member cp1x: float option with get, set
        abstract member cp1y: float option with get, set
        abstract member cp2x: float option with get, set
        abstract member cp2y: float option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (x: float, y: float, ?skip: bool, ?cp1x: float, ?cp1y: float, ?cp2x: float, ?cp2y: float) : SplinePoint = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type ScriptableContext<'TType> =
        abstract member active: bool with get, set
        abstract member chart: ChartJs.dist.types.Chart with get, set
        abstract member dataIndex: float with get, set
        abstract member dataset: obj with get, set
        abstract member datasetIndex: float with get, set
        abstract member ``type``: string with get, set
        abstract member mode: string with get, set
        abstract member parsed: obj with get, set
        abstract member raw: obj with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type ScriptableLineSegmentContext =
        abstract member ``type``: string with get, set
        abstract member p0: ChartJs.PointElement with get, set
        abstract member p1: ChartJs.PointElement with get, set
        abstract member p0DataIndex: float with get, set
        abstract member p1DataIndex: float with get, set
        abstract member datasetIndex: float with get, set

    type Scriptable<'T, 'TContext> =
        U2<'T, Scriptable.U2.Case2<'T, 'TContext>>

    [<AllowNullLiteral>]
    [<Interface>]
    type ScriptableOptions<'T, 'TContext> =
        [<EmitIndexer>]
        abstract member Item: key: string -> ChartJs.Scriptable<obj, 'TContext> with get, set

    type ScriptableAndScriptableOptions<'T, 'TContext> =
        U2<ChartJs.Scriptable<'T, 'TContext>, ChartJs.ScriptableOptions<'T, 'TContext>>

    type ScriptableAndArray<'T, 'TContext> =
        U2<ReadonlyArray<'T>, ChartJs.Scriptable<'T, 'TContext>>

    [<AllowNullLiteral>]
    [<Interface>]
    type ScriptableAndArrayOptions<'T, 'TContext> =
        [<EmitIndexer>]
        abstract member Item: key: string -> ChartJs.ScriptableAndArray<obj, 'TContext> with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type ParsingOptions =
        /// <summary>
        /// How to parse the dataset. The parsing can be disabled by specifying parsing: false at chart options or dataset. If parsing is disabled, data must be sorted and in the formats the associated chart type and scales use internally.
        /// </summary>
        abstract member parsing: U2<ParsingOptions.parsing.U2.Case1, bool> with get, set
        /// <summary>
        /// Chart.js is fastest if you provide data with indices that are unique, sorted, and consistent across datasets and provide the normalized: true option to let Chart.js know that you have done so.
        /// </summary>
        abstract member normalized: bool with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type ControllerDatasetOptions =
        inherit ChartJs.ParsingOptions
        /// <summary>
        /// The base axis of the chart. 'x' for vertical charts and 'y' for horizontal charts.
        /// </summary>
        abstract member indexAxis: ControllerDatasetOptions.indexAxis with get, set
        /// <summary>
        /// How to clip relative to chartArea. Positive value allows overflow, negative value clips that many pixels inside chartArea. 0 = clip at chartArea. Clipping can also be configured per side: <c>clip: {left: 5, top: false, right: -2, bottom: 0}</c>
        /// </summary>
        abstract member clip: U3<float, ChartJs.ChartArea, bool> with get, set
        /// <summary>
        /// The label for the dataset which appears in the legend and tooltips.
        /// </summary>
        abstract member label: string with get, set
        /// <summary>
        /// The drawing order of dataset. Also affects order for stacking, tooltip and legend.
        /// </summary>
        abstract member order: float with get, set
        /// <summary>
        /// The ID of the group to which this dataset belongs to (when stacked, each group will be a separate stack).
        /// </summary>
        abstract member stack: string with get, set
        /// <summary>
        /// Configures the visibility state of the dataset. Set it to true, to hide the dataset from the chart.
        /// </summary>
        abstract member hidden: bool with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type BarControllerDatasetOptions =
        inherit ChartJs.ControllerDatasetOptions
        inherit ChartJs.ScriptableAndArrayOptions<ChartJs.BarOptions, ChartJs.ScriptableContext<string>>
        inherit ChartJs.ScriptableAndArrayOptions<ChartJs.CommonHoverOptions, ChartJs.ScriptableContext<string>>
        inherit ChartJs.AnimationOptions<string>
        /// <summary>
        /// The ID of the x axis to plot this dataset on.
        /// </summary>
        abstract member xAxisID: string with get, set
        /// <summary>
        /// The ID of the y axis to plot this dataset on.
        /// </summary>
        abstract member yAxisID: string with get, set
        /// <summary>
        /// Percent (0-1) of the available width each bar should be within the category width. 1.0 will take the whole category width and put the bars right next to each other.
        /// </summary>
        abstract member barPercentage: float with get, set
        /// <summary>
        /// Percent (0-1) of the available width each category should be within the sample width.
        /// </summary>
        abstract member categoryPercentage: float with get, set
        /// <summary>
        /// Manually set width of each bar in pixels. If set to 'flex', it computes "optimal" sample widths that globally arrange bars side by side. If not set (default), bars are equally sized based on the smallest interval.
        /// </summary>
        abstract member barThickness: BarControllerDatasetOptions.barThickness with get, set
        /// <summary>
        /// Set this to ensure that bars are not sized thicker than this.
        /// </summary>
        abstract member maxBarThickness: float with get, set
        /// <summary>
        /// Set this to ensure that bars have a minimum length in pixels.
        /// </summary>
        abstract member minBarLength: float with get, set
        /// <summary>
        /// Point style for the legend
        /// </summary>
        abstract member pointStyle: ChartJs.PointStyle with get, set
        /// <summary>
        /// Should the bars be grouped on index axis
        /// </summary>
        abstract member grouped: bool with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type BarControllerChartOptions =
        /// <summary>
        /// Should null or undefined values be omitted from drawing
        /// </summary>
        abstract member skipNull: bool option with get, set

    type BarController =
        ChartJs.DatasetController

    [<AllowNullLiteral>]
    [<Interface>]
    type BubbleControllerDatasetOptions =
        inherit ChartJs.ControllerDatasetOptions
        inherit ChartJs.ScriptableAndArrayOptions<ChartJs.PointOptions, ChartJs.ScriptableContext<string>>
        inherit ChartJs.ScriptableAndArrayOptions<ChartJs.PointHoverOptions, ChartJs.ScriptableContext<string>>
        /// <summary>
        /// The ID of the x axis to plot this dataset on.
        /// </summary>
        abstract member xAxisID: string with get, set
        /// <summary>
        /// The ID of the y axis to plot this dataset on.
        /// </summary>
        abstract member yAxisID: string with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type BubbleDataPoint =
        inherit ChartJs.Point
        /// <summary>
        /// Bubble radius in pixels (not scaled).
        /// </summary>
        abstract member r: float option with get, set

    type BubbleController =
        ChartJs.DatasetController

    [<AllowNullLiteral>]
    [<Interface>]
    type LineControllerDatasetOptions =
        inherit ChartJs.ControllerDatasetOptions
        inherit ChartJs.ScriptableAndArrayOptions<ChartJs.PointPrefixedOptions, ChartJs.ScriptableContext<string>>
        inherit ChartJs.ScriptableAndArrayOptions<ChartJs.PointPrefixedHoverOptions, ChartJs.ScriptableContext<string>>
        inherit ChartJs.ScriptableOptions<LineControllerDatasetOptions.Extends, ChartJs.ScriptableContext<string>>
        inherit ChartJs.ScriptableAndArrayOptions<ChartJs.CommonElementOptions, ChartJs.ScriptableContext<string>>
        inherit ChartJs.ScriptableOptions<LineControllerDatasetOptions.Extends_1, ChartJs.ScriptableContext<string>>
        inherit ChartJs.ScriptableAndArrayOptions<ChartJs.CommonHoverOptions, ChartJs.ScriptableContext<string>>
        inherit ChartJs.AnimationOptions<string>
        /// <summary>
        /// The ID of the x axis to plot this dataset on.
        /// </summary>
        abstract member xAxisID: string with get, set
        /// <summary>
        /// The ID of the y axis to plot this dataset on.
        /// </summary>
        abstract member yAxisID: string with get, set
        /// <summary>
        /// If true, lines will be drawn between points with no or null data. If false, points with NaN data will create a break in the line. Can also be a number specifying the maximum gap length to span. The unit of the value depends on the scale used.
        /// </summary>
        abstract member spanGaps: U2<bool, float> with get, set
        abstract member showLine: bool with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type LineControllerChartOptions =
        /// <summary>
        /// If true, lines will be drawn between points with no or null data. If false, points with NaN data will create a break in the line. Can also be a number specifying the maximum gap length to span. The unit of the value depends on the scale used.
        /// </summary>
        abstract member spanGaps: U2<bool, float> with get, set
        /// <summary>
        /// If false, the lines between points are not drawn.
        /// </summary>
        abstract member showLine: bool with get, set

    type LineController =
        ChartJs.DatasetController

    type ScatterControllerDatasetOptions =
        ChartJs.LineControllerDatasetOptions

    type ScatterDataPoint =
        ChartJs.Point

    type ScatterControllerChartOptions =
        ChartJs.LineControllerChartOptions

    type ScatterController =
        ChartJs.LineController

    [<AllowNullLiteral>]
    [<Interface>]
    type DoughnutControllerDatasetOptions =
        inherit ChartJs.ControllerDatasetOptions
        inherit ChartJs.ScriptableAndArrayOptions<ChartJs.ArcOptions, ChartJs.ScriptableContext<string>>
        inherit ChartJs.ScriptableAndArrayOptions<ChartJs.ArcHoverOptions, ChartJs.ScriptableContext<string>>
        inherit ChartJs.AnimationOptions<string>
        /// <summary>
        /// Sweep to allow arcs to cover.
        /// </summary>
        abstract member circumference: float with get, set
        /// <summary>
        /// Arc offset (in pixels).
        /// </summary>
        abstract member offset: U2<float, ResizeArray<float>> with get, set
        /// <summary>
        /// Starting angle to draw this dataset from.
        /// </summary>
        abstract member rotation: float with get, set
        /// <summary>
        /// The relative thickness of the dataset. Providing a value for weight will cause the pie or doughnut dataset to be drawn with a thickness relative to the sum of all the dataset weight values.
        /// </summary>
        abstract member weight: float with get, set
        /// <summary>
        /// Similar to the <c>offset</c> option, but applies to all arcs. This can be used to to add spaces
        /// between arcs
        /// </summary>
        abstract member spacing: float with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type DoughnutAnimationOptions =
        inherit ChartJs.AnimationSpec<string>
        /// <summary>
        /// If true, the chart will animate in with a rotation animation. This property is in the options.animation object.
        /// </summary>
        abstract member animateRotate: bool with get, set
        /// <summary>
        /// If true, will animate scaling the chart from the center outwards.
        /// </summary>
        abstract member animateScale: bool with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type DoughnutControllerChartOptions =
        /// <summary>
        /// Sweep to allow arcs to cover.
        /// </summary>
        abstract member circumference: float with get, set
        /// <summary>
        /// The portion of the chart that is cut out of the middle. ('50%' - for doughnut, 0 - for pie)
        /// String ending with '%' means percentage, number means pixels.
        /// </summary>
        abstract member cutout: ChartJs.Scriptable<U2<float, string>, ChartJs.ScriptableContext<string>> with get, set
        /// <summary>
        /// Arc offset (in pixels).
        /// </summary>
        abstract member offset: U2<float, ResizeArray<float>> with get, set
        /// <summary>
        /// The outer radius of the chart. String ending with '%' means percentage of maximum radius, number means pixels.
        /// </summary>
        abstract member radius: ChartJs.Scriptable<U2<float, string>, ChartJs.ScriptableContext<string>> with get, set
        /// <summary>
        /// Starting angle to draw arcs from.
        /// </summary>
        abstract member rotation: float with get, set
        /// <summary>
        /// Spacing between the arcs
        /// </summary>
        abstract member spacing: float with get, set
        abstract member animation: U2<bool, ChartJs.DoughnutAnimationOptions> with get, set

    type DoughnutDataPoint =
        float

    [<AllowNullLiteral>]
    [<Interface>]
    type DoughnutController =
        inherit ChartJs.DatasetController
        abstract member innerRadius: float with get
        abstract member outerRadius: float with get
        abstract member offsetX: float with get
        abstract member offsetY: float with get
        abstract member calculateTotal: unit -> float
        abstract member calculateCircumference: value: float -> float

    [<AllowNullLiteral>]
    [<Interface>]
    type DoughnutMetaExtensions =
        abstract member total: float with get, set

    type PieControllerDatasetOptions =
        ChartJs.DoughnutControllerDatasetOptions

    type PieControllerChartOptions =
        ChartJs.DoughnutControllerChartOptions

    type PieAnimationOptions =
        ChartJs.DoughnutAnimationOptions

    type PieDataPoint =
        ChartJs.DoughnutDataPoint

    type PieMetaExtensions =
        ChartJs.DoughnutMetaExtensions

    type PieController =
        ChartJs.DoughnutController

    [<AllowNullLiteral>]
    [<Interface>]
    type PolarAreaControllerDatasetOptions =
        inherit ChartJs.DoughnutControllerDatasetOptions
        /// <summary>
        /// Arc angle to cover. - for polar only
        /// </summary>
        abstract member angle: float with get, set

    type PolarAreaAnimationOptions =
        ChartJs.DoughnutAnimationOptions

    [<AllowNullLiteral>]
    [<Interface>]
    type PolarAreaControllerChartOptions =
        /// <summary>
        /// Starting angle to draw arcs for the first item in a dataset. In degrees, 0 is at top.
        /// </summary>
        abstract member startAngle: float with get, set
        abstract member animation: U2<bool, ChartJs.PolarAreaAnimationOptions> with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type PolarAreaController =
        inherit ChartJs.DoughnutController
        abstract member countVisibleElements: unit -> float

    [<AllowNullLiteral>]
    [<Interface>]
    type RadarControllerDatasetOptions =
        inherit ChartJs.ControllerDatasetOptions
        inherit ChartJs.ScriptableAndArrayOptions<RadarControllerDatasetOptions.Extends, ChartJs.ScriptableContext<string>>
        inherit ChartJs.ScriptableAndArrayOptions<RadarControllerDatasetOptions.Extends_1, ChartJs.ScriptableContext<string>>
        inherit ChartJs.AnimationOptions<string>
        /// <summary>
        /// The ID of the x axis to plot this dataset on.
        /// </summary>
        abstract member xAxisID: string with get, set
        /// <summary>
        /// The ID of the y axis to plot this dataset on.
        /// </summary>
        abstract member yAxisID: string with get, set
        /// <summary>
        /// If true, lines will be drawn between points with no or null data. If false, points with NaN data will create a break in the line. Can also be a number specifying the maximum gap length to span. The unit of the value depends on the scale used.
        /// </summary>
        abstract member spanGaps: U2<bool, float> with get, set
        /// <summary>
        /// If false, the line is not drawn for this dataset.
        /// </summary>
        abstract member showLine: bool with get, set

    type RadarControllerChartOptions =
        ChartJs.LineControllerChartOptions

    type RadarController =
        ChartJs.DatasetController

    [<AllowNullLiteral>]
    [<Interface>]
    type ChartMeta<'TType, 'TElement, 'TDatasetElement> =
        inherit ChartJs.dist.types.ChartMetaCommon<'TElement, 'TDatasetElement>

    [<AllowNullLiteral>]
    [<Interface>]
    type ActiveDataPoint =
        abstract member datasetIndex: float with get, set
        abstract member index: float with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type ActiveElement =
        inherit ChartJs.ActiveDataPoint
        abstract member element: ChartJs.Element with get, set

    type ChartItem =
        U5<string, Glutinum.Web.CanvasRenderingContext2D, Glutinum.Web.HTMLCanvasElement, ChartItem.U5.Case4, obj>

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type UpdateModeEnum =
        | resize
        | reset
        | none
        | hide
        | show
        | [<CompiledName("default")>] ``default``
        | active

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type UpdateMode =
        | resize
        | reset
        | none
        | hide
        | show
        | ``default``
        | active

    [<AllowNullLiteral>]
    [<Interface>]
    type DatasetController<'TType, 'TElement, 'TDatasetElement, 'TParsedData> =
        abstract member chart: ChartJs.dist.types.Chart with get
        abstract member index: float with get
        abstract member _cachedMeta: ChartJs.ChartMeta<'TType, 'TElement, 'TDatasetElement> with get
        abstract member enableOptionSharing: bool with get, set
        abstract member supportsDecimation: bool with get, set
        abstract member linkScales: unit -> unit
        abstract member getAllParsedValues: scale: ChartJs.Scale -> ResizeArray<float>
        abstract member updateElements: elements: ResizeArray<'TElement> * start: float * count: float * mode: ChartJs.UpdateMode -> unit
        abstract member update: mode: ChartJs.UpdateMode -> unit
        abstract member updateIndex: datasetIndex: float -> unit
        abstract member draw: unit -> unit
        abstract member reset: unit -> unit
        abstract member getDataset: unit -> ChartJs.ChartDataset
        abstract member getMeta: unit -> ChartJs.ChartMeta<'TType, 'TElement, 'TDatasetElement>
        abstract member getScaleForId: scaleID: string -> ChartJs.Scale option
        abstract member configure: unit -> unit
        abstract member initialize: unit -> unit
        abstract member addElements: unit -> unit
        abstract member buildOrUpdateElements: ?resetNewElements: bool -> unit
        abstract member getStyle: index: float * active: bool -> ChartJs.AnyObject
        abstract member removeHoverStyle: element: 'TElement * datasetIndex: float * index: float -> unit
        abstract member setHoverStyle: element: 'TElement * datasetIndex: float * index: float -> unit
        abstract member parse: start: float * count: float -> unit

    type DatasetController<'TType, 'TElement, 'TDatasetElement> =
        DatasetController<'TType, 'TElement, 'TDatasetElement, ChartJs.ParsedDataType<'TType>>

    type DatasetController<'TType, 'TElement> =
        DatasetController<'TType, 'TElement, ChartJs.Element, ChartJs.ParsedDataType<'TType>>

    type DatasetController<'TType> =
        DatasetController<'TType, ChartJs.Element, ChartJs.Element, ChartJs.ParsedDataType<'TType>>

    type DatasetController =
        DatasetController<ChartJs.ChartType, ChartJs.Element, ChartJs.Element, ChartJs.ParsedDataType<ChartJs.ChartType>>

    [<AllowNullLiteral>]
    [<Interface>]
    type DatasetControllerChartComponent =
        inherit ChartJs.ChartComponent
        abstract member defaults: DatasetControllerChartComponent.defaults with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type Defaults =
        inherit ChartJs.CoreChartOptions<ChartJs.ChartType>
        inherit ChartJs.ElementChartOptions<ChartJs.ChartType>
        inherit ChartJs.PluginChartOptions<ChartJs.ChartType>
        abstract member scale: ChartJs.ScaleOptionsByType with get, set
        abstract member scales: Defaults.scales with get, set
        abstract member set: values: ChartJs.AnyObject -> ChartJs.AnyObject
        abstract member set: scope: string * values: ChartJs.AnyObject -> ChartJs.AnyObject
        abstract member get: scope: string -> ChartJs.AnyObject
        abstract member describe: scope: string * values: ChartJs.AnyObject -> ChartJs.AnyObject
        abstract member ``override``: scope: string * values: ChartJs.AnyObject -> ChartJs.AnyObject
        /// <summary>
        /// Routes the named defaults to fallback to another scope/name.
        /// This routing is useful when those target values, like defaults.color, are changed runtime.
        /// If the values would be copied, the runtime change would not take effect. By routing, the
        /// fallback is evaluated at each access, so its always up to date.
        ///
        /// Example:
        ///
        ///   defaults.route('elements.arc', 'backgroundColor', '', 'color')
        ///    - reads the backgroundColor from defaults.color when undefined locally
        /// </summary>
        /// <param name="scope">
        /// Scope this route applies to.
        /// </param>
        /// <param name="name">
        /// Property name that should be routed to different namespace when not defined here.
        /// </param>
        /// <param name="targetScope">
        /// The namespace where those properties should be routed to.
        /// Empty string ('') is the root of defaults.
        /// </param>
        /// <param name="targetName">
        /// The target name in the target scope the property should be routed to.
        /// </param>
        abstract member route: scope: string * name: string * targetScope: string * targetName: string -> unit

    [<AllowNullLiteral>]
    [<Interface>]
    type Overrides =
        [<EmitIndexer>]
        abstract member Item: key: string -> Overrides.Item with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type InteractionOptions =
        abstract member axis: string option with get, set
        abstract member intersect: bool option with get, set
        abstract member includeInvisible: bool option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?axis: string, ?intersect: bool, ?includeInvisible: bool) : InteractionOptions = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type InteractionItem =
        abstract member element: ChartJs.Element with get, set
        abstract member datasetIndex: float with get, set
        abstract member index: float with get, set

    type InteractionModeFunction =
        delegate of chart: ChartJs.dist.types.Chart * e: ChartJs.ChartEvent * options: ChartJs.InteractionOptions * ?useFinalPosition: bool -> ResizeArray<ChartJs.InteractionItem>

    [<AllowNullLiteral>]
    [<Interface>]
    type InteractionModeMap =
        /// <summary>
        /// Returns items at the same index. If the options.intersect parameter is true, we only return items if we intersect something
        /// If the options.intersect mode is false, we find the nearest item and return the items at the same index as that item
        /// </summary>
        abstract member index: chart: ChartJs.dist.types.Chart * e: ChartJs.ChartEvent * options: ChartJs.InteractionOptions * ?useFinalPosition: bool -> ResizeArray<ChartJs.InteractionItem>
        /// <summary>
        /// Returns items in the same dataset. If the options.intersect parameter is true, we only return items if we intersect something
        /// If the options.intersect is false, we find the nearest item and return the items in that dataset
        /// </summary>
        abstract member dataset: chart: ChartJs.dist.types.Chart * e: ChartJs.ChartEvent * options: ChartJs.InteractionOptions * ?useFinalPosition: bool -> ResizeArray<ChartJs.InteractionItem>
        /// <summary>
        /// Point mode returns all elements that hit test based on the event position
        /// of the event
        /// </summary>
        abstract member point: chart: ChartJs.dist.types.Chart * e: ChartJs.ChartEvent * options: ChartJs.InteractionOptions * ?useFinalPosition: bool -> ResizeArray<ChartJs.InteractionItem>
        /// <summary>
        /// nearest mode returns the element closest to the point
        /// </summary>
        abstract member nearest: chart: ChartJs.dist.types.Chart * e: ChartJs.ChartEvent * options: ChartJs.InteractionOptions * ?useFinalPosition: bool -> ResizeArray<ChartJs.InteractionItem>
        /// <summary>
        /// x mode returns the elements that hit-test at the current x coordinate
        /// </summary>
        abstract member x: chart: ChartJs.dist.types.Chart * e: ChartJs.ChartEvent * options: ChartJs.InteractionOptions * ?useFinalPosition: bool -> ResizeArray<ChartJs.InteractionItem>
        /// <summary>
        /// y mode returns the elements that hit-test at the current y coordinate
        /// </summary>
        abstract member y: chart: ChartJs.dist.types.Chart * e: ChartJs.ChartEvent * options: ChartJs.InteractionOptions * ?useFinalPosition: bool -> ResizeArray<ChartJs.InteractionItem>

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type InteractionMode =
        | index
        | dataset
        | point
        | nearest
        | x
        | y

    [<AllowNullLiteral>]
    [<Interface>]
    type Plugin<'TType, 'O> =
        inherit ChartJs.ExtendedPlugin<'TType, 'O>
        abstract member id: string with get, set
        /// <summary>
        /// The events option defines the browser events that the plugin should listen.
        /// </summary>
        abstract member events: ResizeArray<obj> option with get, set
        /// <param name="chart">
        /// The chart instance.
        /// </param>
        /// <param name="args">
        /// The call arguments.
        /// </param>
        /// <param name="options">
        /// The plugin options.
        /// </param>
        abstract member install: Plugin.install option with get, set
        /// <param name="chart">
        /// The chart instance.
        /// </param>
        /// <param name="args">
        /// The call arguments.
        /// </param>
        /// <param name="options">
        /// The plugin options.
        /// </param>
        abstract member start: Plugin.start option with get, set
        /// <param name="chart">
        /// The chart instance.
        /// </param>
        /// <param name="args">
        /// The call arguments.
        /// </param>
        /// <param name="options">
        /// The plugin options.
        /// </param>
        abstract member stop: Plugin.stop option with get, set
        /// <param name="chart">
        /// The chart instance.
        /// </param>
        /// <param name="args">
        /// The call arguments.
        /// </param>
        /// <param name="options">
        /// The plugin options.
        /// </param>
        abstract member beforeInit: Plugin.beforeInit option with get, set
        /// <param name="chart">
        /// The chart instance.
        /// </param>
        /// <param name="args">
        /// The call arguments.
        /// </param>
        /// <param name="options">
        /// The plugin options.
        /// </param>
        abstract member afterInit: Plugin.afterInit option with get, set
        /// <param name="chart">
        /// The chart instance.
        /// </param>
        /// <param name="args">
        /// The call arguments.
        /// </param>
        /// <param name="options">
        /// The plugin options.
        /// </param>
        /// <returns>
        /// <c>false</c> to cancel the chart update.
        /// </returns>
        abstract member beforeUpdate: Plugin.beforeUpdate option with get, set
        /// <param name="chart">
        /// The chart instance.
        /// </param>
        /// <param name="args">
        /// The call arguments.
        /// </param>
        /// <param name="options">
        /// The plugin options.
        /// </param>
        abstract member afterUpdate: Plugin.afterUpdate option with get, set
        /// <param name="chart">
        /// The chart instance.
        /// </param>
        /// <param name="args">
        /// The call arguments.
        /// </param>
        /// <param name="options">
        /// The plugin options.
        /// </param>
        abstract member beforeElementsUpdate: Plugin.beforeElementsUpdate option with get, set
        /// <param name="chart">
        /// The chart instance.
        /// </param>
        /// <param name="args">
        /// The call arguments.
        /// </param>
        /// <param name="options">
        /// The plugin options.
        /// </param>
        abstract member reset: Plugin.reset option with get, set
        /// <param name="chart">
        /// The chart instance.
        /// </param>
        /// <param name="args">
        /// The call arguments.
        /// </param>
        /// <param name="options">
        /// The plugin options.
        /// </param>
        /// <returns>
        /// false to cancel the datasets update.
        /// </returns>
        abstract member beforeDatasetsUpdate: Plugin.beforeDatasetsUpdate option with get, set
        /// <param name="chart">
        /// The chart instance.
        /// </param>
        /// <param name="args">
        /// The call arguments.
        /// </param>
        /// <param name="options">
        /// The plugin options.
        /// </param>
        abstract member afterDatasetsUpdate: Plugin.afterDatasetsUpdate option with get, set
        /// <param name="chart">
        /// The chart instance.
        /// </param>
        /// <param name="args">
        /// The call arguments.
        /// </param>
        /// <param name="options">
        /// The plugin options.
        /// </param>
        /// <returns>
        /// <c>false</c> to cancel the chart datasets drawing.
        /// </returns>
        abstract member beforeDatasetUpdate: Plugin.beforeDatasetUpdate option with get, set
        /// <param name="chart">
        /// The chart instance.
        /// </param>
        /// <param name="args">
        /// The call arguments.
        /// </param>
        /// <param name="options">
        /// The plugin options.
        /// </param>
        abstract member afterDatasetUpdate: Plugin.afterDatasetUpdate option with get, set
        /// <param name="chart">
        /// The chart instance.
        /// </param>
        /// <param name="args">
        /// The call arguments.
        /// </param>
        /// <param name="options">
        /// The plugin options.
        /// </param>
        /// <returns>
        /// <c>false</c> to cancel the chart layout.
        /// </returns>
        abstract member beforeLayout: Plugin.beforeLayout option with get, set
        /// <param name="chart">
        /// The chart instance.
        /// </param>
        /// <param name="args">
        /// The call arguments.
        /// </param>
        /// <param name="options">
        /// The plugin options.
        /// </param>
        abstract member beforeDataLimits: Plugin.beforeDataLimits option with get, set
        /// <param name="chart">
        /// The chart instance.
        /// </param>
        /// <param name="args">
        /// The call arguments.
        /// </param>
        /// <param name="options">
        /// The plugin options.
        /// </param>
        abstract member afterDataLimits: Plugin.afterDataLimits option with get, set
        /// <param name="chart">
        /// The chart instance.
        /// </param>
        /// <param name="args">
        /// The call arguments.
        /// </param>
        /// <param name="options">
        /// The plugin options.
        /// </param>
        abstract member beforeBuildTicks: Plugin.beforeBuildTicks option with get, set
        /// <param name="chart">
        /// The chart instance.
        /// </param>
        /// <param name="args">
        /// The call arguments.
        /// </param>
        /// <param name="options">
        /// The plugin options.
        /// </param>
        abstract member afterBuildTicks: Plugin.afterBuildTicks option with get, set
        /// <param name="chart">
        /// The chart instance.
        /// </param>
        /// <param name="args">
        /// The call arguments.
        /// </param>
        /// <param name="options">
        /// The plugin options.
        /// </param>
        abstract member afterLayout: Plugin.afterLayout option with get, set
        /// <param name="chart">
        /// The chart instance.
        /// </param>
        /// <param name="args">
        /// The call arguments.
        /// </param>
        /// <param name="options">
        /// The plugin options.
        /// </param>
        /// <returns>
        /// <c>false</c> to cancel the chart rendering.
        /// </returns>
        abstract member beforeRender: Plugin.beforeRender option with get, set
        /// <param name="chart">
        /// The chart instance.
        /// </param>
        /// <param name="args">
        /// The call arguments.
        /// </param>
        /// <param name="options">
        /// The plugin options.
        /// </param>
        abstract member afterRender: Plugin.afterRender option with get, set
        /// <param name="chart">
        /// The chart instance.
        /// </param>
        /// <param name="args">
        /// The call arguments.
        /// </param>
        /// <param name="options">
        /// The plugin options.
        /// </param>
        /// <returns>
        /// <c>false</c> to cancel the chart drawing.
        /// </returns>
        abstract member beforeDraw: Plugin.beforeDraw option with get, set
        /// <param name="chart">
        /// The chart instance.
        /// </param>
        /// <param name="args">
        /// The call arguments.
        /// </param>
        /// <param name="options">
        /// The plugin options.
        /// </param>
        abstract member afterDraw: Plugin.afterDraw option with get, set
        /// <param name="chart">
        /// The chart instance.
        /// </param>
        /// <param name="args">
        /// The call arguments.
        /// </param>
        /// <param name="options">
        /// The plugin options.
        /// </param>
        /// <returns>
        /// <c>false</c> to cancel the chart datasets drawing.
        /// </returns>
        abstract member beforeDatasetsDraw: Plugin.beforeDatasetsDraw option with get, set
        /// <param name="chart">
        /// The chart instance.
        /// </param>
        /// <param name="args">
        /// The call arguments.
        /// </param>
        /// <param name="options">
        /// The plugin options.
        /// </param>
        abstract member afterDatasetsDraw: Plugin.afterDatasetsDraw option with get, set
        /// <param name="chart">
        /// The chart instance.
        /// </param>
        /// <param name="args">
        /// The call arguments.
        /// </param>
        /// <param name="options">
        /// The plugin options.
        /// </param>
        /// <returns>
        /// <c>false</c> to cancel the chart datasets drawing.
        /// </returns>
        abstract member beforeDatasetDraw: Plugin.beforeDatasetDraw option with get, set
        /// <param name="chart">
        /// The chart instance.
        /// </param>
        /// <param name="args">
        /// The call arguments.
        /// </param>
        /// <param name="options">
        /// The plugin options.
        /// </param>
        abstract member afterDatasetDraw: Plugin.afterDatasetDraw option with get, set
        /// <param name="chart">
        /// The chart instance.
        /// </param>
        /// <param name="args">
        /// The call arguments.
        /// </param>
        /// <param name="options">
        /// The plugin options.
        /// </param>
        abstract member beforeEvent: Plugin.beforeEvent option with get, set
        /// <param name="chart">
        /// The chart instance.
        /// </param>
        /// <param name="args">
        /// The call arguments.
        /// </param>
        /// <param name="options">
        /// The plugin options.
        /// </param>
        abstract member afterEvent: Plugin.afterEvent option with get, set
        /// <param name="chart">
        /// The chart instance.
        /// </param>
        /// <param name="args">
        /// The call arguments.
        /// </param>
        /// <param name="options">
        /// The plugin options.
        /// </param>
        abstract member resize: Plugin.resize option with get, set
        /// <summary>
        /// Called before the chart is being destroyed.
        /// </summary>
        /// <param name="chart">
        /// The chart instance.
        /// </param>
        /// <param name="args">
        /// The call arguments.
        /// </param>
        /// <param name="options">
        /// The plugin options.
        /// </param>
        abstract member beforeDestroy: Plugin.beforeDestroy option with get, set
        /// <summary>
        /// Called after the chart has been destroyed.
        /// </summary>
        /// <param name="chart">
        /// The chart instance.
        /// </param>
        /// <param name="args">
        /// The call arguments.
        /// </param>
        /// <param name="options">
        /// The plugin options.
        /// </param>
        abstract member afterDestroy: Plugin.afterDestroy option with get, set
        /// <summary>
        /// Called after chart is destroyed on all plugins that were installed for that chart. This hook is also invoked for disabled plugins (options === false).
        /// </summary>
        /// <param name="chart">
        /// The chart instance.
        /// </param>
        /// <param name="args">
        /// The call arguments.
        /// </param>
        /// <param name="options">
        /// The plugin options.
        /// </param>
        abstract member uninstall: Plugin.uninstall option with get, set
        /// <summary>
        /// Default options used in the plugin
        /// </summary>
        abstract member defaults: Plugin.defaults option with get, set

    type ChartComponentLike =
        U5<ChartJs.ChartComponent, ResizeArray<ChartJs.ChartComponent>, ChartComponentLike.U5.Case3, ChartJs.Plugin, ResizeArray<ChartJs.Plugin>>

    /// <summary>
    /// Please use the module's default export which provides a singleton instance
    /// Note: class is exported for typedoc
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type Registry =
        abstract member controllers: ChartJs.TypedRegistry<ChartJs.DatasetController> with get
        abstract member elements: ChartJs.TypedRegistry<ChartJs.Element> with get
        abstract member plugins: ChartJs.TypedRegistry<ChartJs.Plugin> with get
        abstract member scales: ChartJs.TypedRegistry<ChartJs.Scale> with get
        abstract member add: [<ParamArray>] args: ChartJs.ChartComponentLike [] -> unit
        abstract member remove: [<ParamArray>] args: ChartJs.ChartComponentLike [] -> unit
        abstract member addControllers: [<ParamArray>] args: ChartJs.ChartComponentLike [] -> unit
        abstract member addElements: [<ParamArray>] args: ChartJs.ChartComponentLike [] -> unit
        abstract member addPlugins: [<ParamArray>] args: ChartJs.ChartComponentLike [] -> unit
        abstract member addScales: [<ParamArray>] args: ChartJs.ChartComponentLike [] -> unit
        abstract member getController: id: string -> ChartJs.DatasetController option
        abstract member getElement: id: string -> ChartJs.Element option
        abstract member getPlugin: id: string -> ChartJs.Plugin option
        abstract member getScale: id: string -> ChartJs.Scale option

    [<AllowNullLiteral>]
    [<Interface>]
    type Tick =
        abstract member value: float with get, set
        abstract member label: U2<string, ResizeArray<string>> option with get, set
        abstract member major: bool option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (value: float, ?major: bool) : Tick = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (value: float, label: string, ?major: bool) : Tick = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (value: float, label: ResizeArray<string>, ?major: bool) : Tick = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type CoreScaleOptions =
        /// <summary>
        /// Controls the axis global visibility (visible when true, hidden when false). When display: 'auto', the axis is visible only if at least one associated dataset is visible.
        /// </summary>
        abstract member display: CoreScaleOptions.display with get, set
        /// <summary>
        /// Align pixel values to device pixels
        /// </summary>
        abstract member alignToPixels: bool with get, set
        /// <summary>
        /// Background color of the scale area.
        /// </summary>
        abstract member backgroundColor: ChartJs.Color with get, set
        /// <summary>
        /// Reverse the scale.
        /// </summary>
        abstract member reverse: bool with get, set
        /// <summary>
        /// Clip the dataset drawing against the size of the scale instead of chart area.
        /// </summary>
        abstract member clip: bool with get, set
        /// <summary>
        /// The weight used to sort the axis. Higher weights are further away from the chart area.
        /// </summary>
        abstract member weight: float with get, set
        /// <summary>
        /// User defined minimum value for the scale, overrides minimum value from data.
        /// </summary>
        abstract member min: obj with get, set
        /// <summary>
        /// User defined maximum value for the scale, overrides maximum value from data.
        /// </summary>
        abstract member max: obj with get, set
        /// <summary>
        /// Adjustment used when calculating the maximum data value.
        /// </summary>
        abstract member suggestedMin: obj with get, set
        /// <summary>
        /// Adjustment used when calculating the minimum data value.
        /// </summary>
        abstract member suggestedMax: obj with get, set
        /// <summary>
        /// Callback called before the update process starts.
        /// </summary>
        abstract member beforeUpdate: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs before dimensions are set.
        /// </summary>
        abstract member beforeSetDimensions: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs after dimensions are set.
        /// </summary>
        abstract member afterSetDimensions: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs before data limits are determined.
        /// </summary>
        abstract member beforeDataLimits: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs after data limits are determined.
        /// </summary>
        abstract member afterDataLimits: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs before ticks are created.
        /// </summary>
        abstract member beforeBuildTicks: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs after ticks are created. Useful for filtering ticks.
        /// </summary>
        abstract member afterBuildTicks: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs before ticks are converted into strings.
        /// </summary>
        abstract member beforeTickToLabelConversion: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs after ticks are converted into strings.
        /// </summary>
        abstract member afterTickToLabelConversion: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs before tick rotation is determined.
        /// </summary>
        abstract member beforeCalculateLabelRotation: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs after tick rotation is determined.
        /// </summary>
        abstract member afterCalculateLabelRotation: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs before the scale fits to the canvas.
        /// </summary>
        abstract member beforeFit: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs after the scale fits to the canvas.
        /// </summary>
        abstract member afterFit: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs at the end of the update process.
        /// </summary>
        abstract member afterUpdate: axis: ChartJs.Scale -> unit

    [<AllowNullLiteral>]
    [<Interface>]
    type Scale<'O> =
        inherit ChartJs.Element<obj, 'O>
        inherit ChartJs.LayoutItem
        abstract member id: string with get
        abstract member ``type``: string with get
        abstract member ctx: Glutinum.Web.CanvasRenderingContext2D with get
        abstract member chart: ChartJs.dist.types.Chart with get
        abstract member maxWidth: float with get, set
        abstract member maxHeight: float with get, set
        abstract member paddingTop: float with get, set
        abstract member paddingBottom: float with get, set
        abstract member paddingLeft: float with get, set
        abstract member paddingRight: float with get, set
        abstract member axis: string with get, set
        abstract member labelRotation: float with get, set
        abstract member min: float with get, set
        abstract member max: float with get, set
        abstract member ticks: ResizeArray<ChartJs.Tick> with get, set
        abstract member getMatchingVisibleMetas: ?``type``: string -> ResizeArray<ChartJs.ChartMeta>
        abstract member drawTitle: chartArea: ChartJs.ChartArea -> unit
        abstract member drawLabels: chartArea: ChartJs.ChartArea -> unit
        abstract member drawGrid: chartArea: ChartJs.ChartArea -> unit
        /// <param name="pixel">
        ///
        /// </param>
        abstract member getDecimalForPixel: pixel: float -> float
        /// <summary>
        /// Utility for getting the pixel location of a percentage of scale
        /// The coordinate (0, 0) is at the upper-left corner of the canvas
        /// </summary>
        /// <param name="decimal">
        ///
        /// </param>
        abstract member getPixelForDecimal: decimal: float -> float
        /// <summary>
        /// Returns the location of the tick at the given index
        /// The coordinate (0, 0) is at the upper-left corner of the canvas
        /// </summary>
        /// <param name="index">
        ///
        /// </param>
        abstract member getPixelForTick: index: float -> float
        /// <summary>
        /// Used to get the label to display in the tooltip for the given value
        /// </summary>
        /// <param name="value">
        ///
        /// </param>
        abstract member getLabelForValue: value: float -> string
        /// <summary>
        /// Returns the grid line width at given value
        /// </summary>
        abstract member getLineWidthForValue: value: float -> float
        /// <summary>
        /// Returns the location of the given data point. Value can either be an index or a numerical value
        /// The coordinate (0, 0) is at the upper-left corner of the canvas
        /// </summary>
        /// <param name="value">
        ///
        /// </param>
        /// <param name="index">
        ///
        /// </param>
        abstract member getPixelForValue: value: float * ?index: float -> float
        /// <summary>
        /// Used to get the data value from a given pixel. This is the inverse of getPixelForValue
        /// The coordinate (0, 0) is at the upper-left corner of the canvas
        /// </summary>
        /// <param name="pixel">
        ///
        /// </param>
        abstract member getValueForPixel: pixel: float -> float option
        abstract member getBaseValue: unit -> float
        /// <summary>
        /// Returns the pixel for the minimum chart value
        /// The coordinate (0, 0) is at the upper-left corner of the canvas
        /// </summary>
        abstract member getBasePixel: unit -> float
        abstract member init: options: 'O -> unit
        abstract member parse: raw: obj * ?index: float -> obj
        abstract member getUserBounds: unit -> Scale.getUserBounds
        abstract member getMinMax: canStack: bool -> Scale.getMinMax
        abstract member getTicks: unit -> ResizeArray<ChartJs.Tick>
        abstract member getLabels: unit -> ResizeArray<string>
        abstract member getLabelItems: ?chartArea: ChartJs.ChartArea -> ResizeArray<ChartJs.LabelItem>
        abstract member beforeUpdate: unit -> unit
        abstract member configure: unit -> unit
        abstract member afterUpdate: unit -> unit
        abstract member beforeSetDimensions: unit -> unit
        abstract member setDimensions: unit -> unit
        abstract member afterSetDimensions: unit -> unit
        abstract member beforeDataLimits: unit -> unit
        abstract member determineDataLimits: unit -> unit
        abstract member afterDataLimits: unit -> unit
        abstract member beforeBuildTicks: unit -> unit
        abstract member buildTicks: unit -> ResizeArray<ChartJs.Tick>
        abstract member afterBuildTicks: unit -> unit
        abstract member beforeTickToLabelConversion: unit -> unit
        abstract member generateTickLabels: ticks: ResizeArray<ChartJs.Tick> -> unit
        abstract member afterTickToLabelConversion: unit -> unit
        abstract member beforeCalculateLabelRotation: unit -> unit
        abstract member calculateLabelRotation: unit -> unit
        abstract member afterCalculateLabelRotation: unit -> unit
        abstract member beforeFit: unit -> unit
        abstract member fit: unit -> unit
        abstract member afterFit: unit -> unit
        abstract member isFullSize: unit -> bool

    [<AllowNullLiteral>]
    [<Interface>]
    type ScriptableScaleContext =
        abstract member chart: ChartJs.dist.types.Chart with get, set
        abstract member scale: ChartJs.Scale with get, set
        abstract member index: float with get, set
        abstract member tick: ChartJs.Tick with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (chart: ChartJs.dist.types.Chart, scale: ChartJs.Scale, index: float, tick: ChartJs.Tick) : ScriptableScaleContext = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type ScriptableScalePointLabelContext =
        abstract member chart: ChartJs.dist.types.Chart with get, set
        abstract member scale: ChartJs.Scale with get, set
        abstract member index: float with get, set
        abstract member label: string with get, set
        abstract member ``type``: string with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type RenderTextOpts =
        /// <summary>
        /// The fill color of the text. If unset, the existing
        /// fillStyle property of the canvas is unchanged.
        /// </summary>
        abstract member color: ChartJs.Color option with get, set
        /// <summary>
        /// The width of the strikethrough / underline
        /// </summary>
        abstract member decorationWidth: float option with get, set
        /// <summary>
        /// The max width of the text in pixels
        /// </summary>
        abstract member maxWidth: float option with get, set
        /// <summary>
        /// A rotation to be applied to the canvas
        /// This is applied after the translation is applied
        /// </summary>
        abstract member rotation: float option with get, set
        /// <summary>
        /// Apply a strikethrough effect to the text
        /// </summary>
        abstract member strikethrough: bool option with get, set
        /// <summary>
        /// The color of the text stroke. If unset, the existing
        /// strokeStyle property of the context is unchanged
        /// </summary>
        abstract member strokeColor: ChartJs.Color option with get, set
        /// <summary>
        /// The text stroke width. If unset, the existing
        /// lineWidth property of the context is unchanged
        /// </summary>
        abstract member strokeWidth: float option with get, set
        /// <summary>
        /// The text alignment to use. If unset, the existing
        /// textAlign property of the context is unchanged
        /// </summary>
        abstract member textAlign: Glutinum.Web.CanvasTextAlign option with get, set
        /// <summary>
        /// The text baseline to use. If unset, the existing
        /// textBaseline property of the context is unchanged
        /// </summary>
        abstract member textBaseline: Glutinum.Web.CanvasTextBaseline option with get, set
        /// <summary>
        /// If specified, a translation to apply to the context
        /// </summary>
        abstract member translation: float * float option with get, set
        /// <summary>
        /// Underline the text
        /// </summary>
        abstract member underline: bool option with get, set
        /// <summary>
        /// Dimensions for drawing the label backdrop
        /// </summary>
        abstract member backdrop: ChartJs.BackdropOptions option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?color: ChartJs.Color, ?decorationWidth: float, ?maxWidth: float, ?rotation: float, ?strikethrough: bool, ?strokeColor: ChartJs.Color, ?strokeWidth: float, ?textAlign: Glutinum.Web.CanvasTextAlign, ?textBaseline: Glutinum.Web.CanvasTextBaseline, ?translation: (float * float), ?underline: bool, ?backdrop: ChartJs.BackdropOptions) : RenderTextOpts = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type BackdropOptions =
        /// <summary>
        /// Left position of backdrop as pixel
        /// </summary>
        abstract member left: float with get, set
        /// <summary>
        /// Top position of backdrop as pixel
        /// </summary>
        abstract member top: float with get, set
        /// <summary>
        /// Width of backdrop in pixels
        /// </summary>
        abstract member width: float with get, set
        /// <summary>
        /// Height of backdrop in pixels
        /// </summary>
        abstract member height: float with get, set
        /// <summary>
        /// Color of label backdrops.
        /// </summary>
        abstract member color: ChartJs.Scriptable<ChartJs.Color, ChartJs.ScriptableScaleContext> with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (left: float, top: float, width: float, height: float, color: ChartJs.Scriptable<ChartJs.Color, ChartJs.ScriptableScaleContext>) : BackdropOptions = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type LabelItem =
        abstract member label: U2<string, ResizeArray<string>> with get, set
        abstract member font: ChartJs.CanvasFontSpec with get, set
        abstract member textOffset: float with get, set
        abstract member options: ChartJs.RenderTextOpts with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type TypedRegistry<'T> =
        /// <param name="item">
        ///
        /// </param>
        /// <returns>
        /// The scope where items defaults were registered to.
        /// </returns>
        abstract member register: item: ChartJs.ChartComponent -> string
        abstract member get: id: string -> 'T option
        abstract member unregister: item: ChartJs.ChartComponent -> unit

    [<AllowNullLiteral>]
    [<Interface>]
    type ChartEvent =
        abstract member ``type``: ChartEvent.``type`` with get, set
        abstract member native: Glutinum.Web.Event option with get, set
        abstract member x: float option with get, set
        abstract member y: float option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (``type``: ChartEvent.``type``, ?native: Glutinum.Web.Event, ?x: float, ?y: float) : ChartEvent = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type ChartComponent =
        abstract member id: string with get, set
        abstract member defaults: ChartJs.AnyObject option with get, set
        abstract member defaultRoutes: ChartComponent.defaultRoutes option with get, set
        abstract member beforeRegister: (unit -> unit) option with get, set
        abstract member afterRegister: (unit -> unit) option with get, set
        abstract member beforeUnregister: (unit -> unit) option with get, set
        abstract member afterUnregister: (unit -> unit) option with get, set

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type InteractionAxis =
        | x
        | y
        | xy
        | r

    [<AllowNullLiteral>]
    [<Interface>]
    type CoreInteractionOptions =
        /// <summary>
        /// Sets which elements appear in the tooltip. See Interaction Modes for details.
        /// </summary>
        abstract member mode: ChartJs.InteractionMode with get, set
        /// <summary>
        /// if true, the hover mode only applies when the mouse position intersects an item on the chart.
        /// </summary>
        abstract member intersect: bool with get, set
        /// <summary>
        /// Defines which directions are used in calculating distances. Defaults to 'x' for 'index' mode and 'xy' in dataset and 'nearest' modes.
        /// </summary>
        abstract member axis: ChartJs.InteractionAxis with get, set
        /// <summary>
        /// if true, the invisible points that are outside of the chart area will also be included when evaluating interactions.
        /// </summary>
        abstract member includeInvisible: bool with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type CoreChartOptions<'TType> =
        inherit ChartJs.ParsingOptions
        inherit ChartJs.AnimationOptions<'TType>
        abstract member datasets: CoreChartOptions.datasets with get, set
        /// <summary>
        /// The base axis of the chart. 'x' for vertical charts and 'y' for horizontal charts.
        /// </summary>
        abstract member indexAxis: CoreChartOptions.indexAxis with get, set
        /// <summary>
        /// How to clip relative to chartArea. Positive value allows overflow, negative value clips that many pixels inside chartArea. 0 = clip at chartArea. Clipping can also be configured per side: <c>clip: {left: 5, top: false, right: -2, bottom: 0}</c>
        /// </summary>
        abstract member clip: U3<float, ChartJs.ChartArea, bool> with get, set
        /// <summary>
        /// base color
        /// </summary>
        abstract member color: ChartJs.Scriptable<ChartJs.Color, ChartJs.ScriptableContext<'TType>> with get, set
        /// <summary>
        /// base background color
        /// </summary>
        abstract member backgroundColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<'TType>> with get, set
        /// <summary>
        /// base hover background color
        /// </summary>
        abstract member hoverBackgroundColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<'TType>> with get, set
        /// <summary>
        /// base border color
        /// </summary>
        abstract member borderColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<'TType>> with get, set
        /// <summary>
        /// base hover border color
        /// </summary>
        abstract member hoverBorderColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<'TType>> with get, set
        /// <summary>
        /// base font
        /// </summary>
        abstract member font: CoreChartOptions.font with get, set
        /// <summary>
        /// Resizes the chart canvas when its container does (important note...).
        /// </summary>
        abstract member responsive: bool with get, set
        /// <summary>
        /// Maintain the original canvas aspect ratio (width / height) when resizing. For this option to work properly the chart must be in its own dedicated container.
        /// </summary>
        abstract member maintainAspectRatio: bool with get, set
        /// <summary>
        /// Delay the resize update by give amount of milliseconds. This can ease the resize process by debouncing update of the elements.
        /// </summary>
        abstract member resizeDelay: float with get, set
        /// <summary>
        /// Canvas aspect ratio (i.e. width / height, a value of 1 representing a square canvas). Note that this option is ignored if the height is explicitly defined either as attribute or via the style.
        /// </summary>
        abstract member aspectRatio: float with get, set
        /// <summary>
        /// Locale used for number formatting (using <c>Intl.NumberFormat</c>).
        /// </summary>
        abstract member locale: string with get, set
        /// <summary>
        /// Called when a resize occurs. Gets passed two arguments: the chart instance and the new size.
        /// </summary>
        abstract member onResize: chart: ChartJs.dist.types.Chart * size: Overrides.Item.onResize.size -> unit
        /// <summary>
        /// Override the window's default devicePixelRatio.
        /// </summary>
        abstract member devicePixelRatio: float with get, set
        abstract member interaction: ChartJs.CoreInteractionOptions with get, set
        abstract member hover: ChartJs.CoreInteractionOptions with get, set
        /// <summary>
        /// The events option defines the browser events that the chart should listen to for tooltips and hovering.
        /// </summary>
        abstract member events: ResizeArray<obj> with get, set
        /// <summary>
        /// Called when any of the events fire. Passed the event, an array of active elements (bars, points, etc), and the chart.
        /// </summary>
        abstract member onHover: event: ChartJs.ChartEvent * elements: ResizeArray<ChartJs.ActiveElement> * chart: ChartJs.dist.types.Chart -> unit
        /// <summary>
        /// Called if the event is of type 'mouseup' or 'click'. Passed the event, an array of active elements, and the chart.
        /// </summary>
        abstract member onClick: event: ChartJs.ChartEvent * elements: ResizeArray<ChartJs.ActiveElement> * chart: ChartJs.dist.types.Chart -> unit
        abstract member layout: CoreChartOptions.layout<'TType> with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type AnimationSpec<'TType> =
        /// <summary>
        /// The number of milliseconds an animation takes.
        /// </summary>
        abstract member duration: ChartJs.Scriptable<float, ChartJs.ScriptableContext<'TType>> option with get, set
        /// <summary>
        /// Easing function to use
        /// </summary>
        abstract member easing: ChartJs.Scriptable<ChartJs.EasingFunction, ChartJs.ScriptableContext<'TType>> option with get, set
        /// <summary>
        /// Delay before starting the animations.
        /// </summary>
        abstract member delay: ChartJs.Scriptable<float, ChartJs.ScriptableContext<'TType>> option with get, set
        /// <summary>
        /// If set to true, the animations loop endlessly.
        /// </summary>
        abstract member loop: ChartJs.Scriptable<bool, ChartJs.ScriptableContext<'TType>> option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type AnimationsSpec<'TType> =
        [<EmitIndexer>]
        abstract member Item: name: string -> U2<bool, AnimationsSpec.Item.U2.Case2<'TType>> with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type TransitionSpec<'TType> =
        abstract member animation: TransitionSpec.animation<'TType> with get, set
        abstract member animations: ChartJs.AnimationsSpec<'TType> with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type TransitionsSpec<'TType> =
        [<EmitIndexer>]
        abstract member Item: mode: string -> TransitionsSpec.Item<'TType> with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type AnimationOptions<'TType> =
        abstract member animation: U2<bool, AnimationOptions.animation.U2.Case2<'TType>> with get, set
        abstract member animations: ChartJs.AnimationsSpec<'TType> with get, set
        abstract member transitions: ChartJs.TransitionsSpec<'TType> with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type FontSpec =
        /// <summary>
        /// Default font family for all text, follows CSS font-family options.
        /// </summary>
        abstract member family: string with get, set
        /// <summary>
        /// Default font size (in px) for text. Does not apply to radialLinear scale point labels.
        /// </summary>
        abstract member size: float with get, set
        /// <summary>
        /// Default font style. Does not apply to tooltip title or footer. Does not apply to chart title. Follows CSS font-style options (i.e. normal, italic, oblique, initial, inherit)
        /// </summary>
        abstract member style: FontSpec.style with get, set
        /// <summary>
        /// Default font weight (boldness). (see MDN).
        /// </summary>
        abstract member weight: FontSpec.weight with get, set
        /// <summary>
        /// Height of an individual line of text (see MDN).
        /// </summary>
        abstract member lineHeight: U2<float, string> with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (family: string, size: float, style: FontSpec.style, weight: FontSpec.weight, lineHeight: float) : FontSpec = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (family: string, size: float, style: FontSpec.style, weight: FontSpec.weight, lineHeight: string) : FontSpec = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type CanvasFontSpec =
        inherit ChartJs.FontSpec
        abstract member string: string with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (family: string, size: float, style: CanvasFontSpec.style, weight: CanvasFontSpec.weight, lineHeight: float, string: string) : CanvasFontSpec = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (family: string, size: float, style: CanvasFontSpec.style, weight: CanvasFontSpec.weight, lineHeight: string, string: string) : CanvasFontSpec = nativeOnly

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type TextAlign =
        | left
        | center
        | right

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type Align =
        | start
        | center
        | ``end``

    [<AllowNullLiteral>]
    [<Interface>]
    type VisualElement =
        abstract member draw: ctx: Glutinum.Web.CanvasRenderingContext2D * ?area: ChartJs.ChartArea -> unit
        abstract member inRange: mouseX: float * mouseY: float * ?useFinalPosition: bool -> bool
        abstract member inXRange: mouseX: float * ?useFinalPosition: bool -> bool
        abstract member inYRange: mouseY: float * ?useFinalPosition: bool -> bool
        abstract member getCenterPoint: ?useFinalPosition: bool -> ChartJs.Point
        abstract member getRange: (VisualElement.getRange.axis -> float) option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type CommonElementOptions =
        abstract member borderWidth: float with get, set
        abstract member borderColor: ChartJs.Color with get, set
        abstract member backgroundColor: ChartJs.Color with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type CommonHoverOptions =
        abstract member hoverBorderWidth: float with get, set
        abstract member hoverBorderColor: ChartJs.Color with get, set
        abstract member hoverBackgroundColor: ChartJs.Color with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type Segment =
        abstract member start: float with get, set
        abstract member ``end``: float with get, set
        abstract member loop: bool with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (start: float, ``end``: float, loop: bool) : Segment = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type ArcBorderRadius =
        abstract member outerStart: float with get, set
        abstract member outerEnd: float with get, set
        abstract member innerStart: float with get, set
        abstract member innerEnd: float with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type ArcOptions =
        inherit ChartJs.CommonElementOptions
        /// <summary>
        /// If true, Arc can take up 100% of a circular graph without any visual split or cut. This option doesn't support borderRadius and borderJoinStyle miter
        /// </summary>
        abstract member selfJoin: bool with get, set
        /// <summary>
        /// Arc stroke alignment.
        /// </summary>
        abstract member borderAlign: ArcOptions.borderAlign with get, set
        /// <summary>
        /// Line dash. See MDN.
        /// </summary>
        abstract member borderDash: ResizeArray<float> with get, set
        /// <summary>
        /// Line dash offset. See MDN.
        /// </summary>
        abstract member borderDashOffset: float with get, set
        /// <summary>
        /// Line join style. See MDN. Default is 'round' when <c>borderAlign</c> is 'inner', else 'bevel'.
        /// </summary>
        abstract member borderJoinStyle: Glutinum.Web.CanvasLineJoin with get, set
        /// <summary>
        /// Sets the border radius for arcs
        /// </summary>
        abstract member borderRadius: U2<float, ChartJs.ArcBorderRadius> with get, set
        /// <summary>
        /// Arc offset (in pixels).
        /// </summary>
        abstract member offset: float with get, set
        /// <summary>
        /// If false, Arc will be flat.
        /// </summary>
        abstract member circular: bool with get, set
        /// <summary>
        /// Spacing between arcs
        /// </summary>
        abstract member spacing: float with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type ArcHoverOptions =
        inherit ChartJs.CommonHoverOptions
        abstract member hoverBorderDash: ResizeArray<float> with get, set
        abstract member hoverBorderDashOffset: float with get, set
        abstract member hoverOffset: float with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type LineProps =
        abstract member points: ResizeArray<ChartJs.Point> with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type LineOptions =
        inherit ChartJs.CommonElementOptions
        /// <summary>
        /// Line cap style. See MDN.
        /// </summary>
        abstract member borderCapStyle: Glutinum.Web.CanvasLineCap with get, set
        /// <summary>
        /// Line dash. See MDN.
        /// </summary>
        abstract member borderDash: ResizeArray<float> with get, set
        /// <summary>
        /// Line dash offset. See MDN.
        /// </summary>
        abstract member borderDashOffset: float with get, set
        /// <summary>
        /// Line join style. See MDN.
        /// </summary>
        abstract member borderJoinStyle: Glutinum.Web.CanvasLineJoin with get, set
        /// <summary>
        /// true to keep Bézier control inside the chart, false for no restriction.
        /// </summary>
        abstract member capBezierPoints: bool with get, set
        /// <summary>
        /// Interpolation mode to apply.
        /// </summary>
        abstract member cubicInterpolationMode: LineOptions.cubicInterpolationMode with get, set
        /// <summary>
        /// Bézier curve tension (0 for no Bézier curves).
        /// </summary>
        abstract member tension: float with get, set
        /// <summary>
        /// true to show the line as a stepped line (tension will be ignored).
        /// </summary>
        abstract member stepped: LineOptions.stepped with get, set
        /// <summary>
        /// Both line and radar charts support a fill option on the dataset object which can be used to create area between two datasets or a dataset and a boundary, i.e. the scale origin, start or end
        /// </summary>
        abstract member fill: U2<ChartJs.FillTarget, ChartJs.ComplexFillTarget> with get, set
        /// <summary>
        /// If true, lines will be drawn between points with no or null data. If false, points with NaN data will create a break in the line. Can also be a number specifying the maximum gap length to span. The unit of the value depends on the scale used.
        /// </summary>
        abstract member spanGaps: U2<bool, float> with get, set
        abstract member segment: LineControllerDatasetOptions.Extends.segment with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type LineHoverOptions =
        inherit ChartJs.CommonHoverOptions
        abstract member hoverBorderCapStyle: Glutinum.Web.CanvasLineCap with get, set
        abstract member hoverBorderDash: ResizeArray<float> with get, set
        abstract member hoverBorderDashOffset: float with get, set
        abstract member hoverBorderJoinStyle: Glutinum.Web.CanvasLineJoin with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type LineElement<'T, 'O> =
        inherit ChartJs.Element<'T, 'O>
        inherit ChartJs.VisualElement
        abstract member updateControlPoints: chartArea: ChartJs.ChartArea * ?indexAxis: LineElement.updateControlPoints.indexAxis -> unit
        abstract member points: ResizeArray<ChartJs.Point> with get, set
        abstract member segments: ResizeArray<ChartJs.Segment> with get
        abstract member first: unit -> U2<ChartJs.Point, bool>
        abstract member last: unit -> U2<ChartJs.Point, bool>
        abstract member interpolate: point: ChartJs.Point * property: LineElement.interpolate.property -> U2<ChartJs.Point, ResizeArray<ChartJs.Point>> option
        abstract member pathSegment: ctx: Glutinum.Web.CanvasRenderingContext2D * segment: ChartJs.Segment * ``params``: ChartJs.AnyObject -> bool option
        abstract member path: ctx: Glutinum.Web.CanvasRenderingContext2D -> bool

    [<RequireQualifiedAccess>]
    [<Erase(CaseRules.None)>]
    type PointStyle =
        | circle
        | cross
        | crossRot
        | dash
        | line
        | rect
        | rectRounded
        | rectRot
        | star
        | triangle
        | [<CompiledValue(false)>] False
        | Case1 of Glutinum.Web.HTMLImageElement
        | Case2 of Glutinum.Web.HTMLCanvasElement

        [<Emit("$0")>]
        static member op_Implicit(value: Glutinum.Web.HTMLImageElement) : PointStyle = nativeOnly

        [<Emit("$0")>]
        static member op_ErasedCast(value: Glutinum.Web.HTMLImageElement) : PointStyle = nativeOnly

        [<Emit("$0")>]
        static member op_Implicit(value: Glutinum.Web.HTMLCanvasElement) : PointStyle = nativeOnly

        [<Emit("$0")>]
        static member op_ErasedCast(value: Glutinum.Web.HTMLCanvasElement) : PointStyle = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type PointOptions =
        inherit ChartJs.CommonElementOptions
        /// <summary>
        /// Point radius
        /// </summary>
        abstract member radius: float with get, set
        /// <summary>
        /// Extra radius added to point radius for hit detection.
        /// </summary>
        abstract member hitRadius: float with get, set
        /// <summary>
        /// Point style
        /// </summary>
        abstract member pointStyle: ChartJs.PointStyle with get, set
        /// <summary>
        /// Point rotation (in degrees).
        /// </summary>
        abstract member rotation: float with get, set
        /// <summary>
        /// Draw the active elements over the other elements of the dataset,
        /// </summary>
        abstract member drawActiveElementsOnTop: bool with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type PointHoverOptions =
        inherit ChartJs.CommonHoverOptions
        /// <summary>
        /// Point radius when hovered.
        /// </summary>
        abstract member hoverRadius: float with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type PointPrefixedOptions =
        /// <summary>
        /// The fill color for points.
        /// </summary>
        abstract member pointBackgroundColor: ChartJs.Color with get, set
        /// <summary>
        /// The border color for points.
        /// </summary>
        abstract member pointBorderColor: ChartJs.Color with get, set
        /// <summary>
        /// The width of the point border in pixels.
        /// </summary>
        abstract member pointBorderWidth: float with get, set
        /// <summary>
        /// The pixel size of the non-displayed point that reacts to mouse events.
        /// </summary>
        abstract member pointHitRadius: float with get, set
        /// <summary>
        /// The radius of the point shape. If set to 0, the point is not rendered.
        /// </summary>
        abstract member pointRadius: float with get, set
        /// <summary>
        /// The rotation of the point in degrees.
        /// </summary>
        abstract member pointRotation: float with get, set
        /// <summary>
        /// Style of the point.
        /// </summary>
        abstract member pointStyle: ChartJs.PointStyle with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type PointPrefixedHoverOptions =
        /// <summary>
        /// Point background color when hovered.
        /// </summary>
        abstract member pointHoverBackgroundColor: ChartJs.Color with get, set
        /// <summary>
        /// Point border color when hovered.
        /// </summary>
        abstract member pointHoverBorderColor: ChartJs.Color with get, set
        /// <summary>
        /// Border width of point when hovered.
        /// </summary>
        abstract member pointHoverBorderWidth: float with get, set
        /// <summary>
        /// The radius of the point when hovered.
        /// </summary>
        abstract member pointHoverRadius: float with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type BarProps =
        inherit ChartJs.Point
        abstract member ``base``: float with get, set
        abstract member horizontal: bool with get, set
        abstract member width: float with get, set
        abstract member height: float with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type BarOptions =
        /// <summary>
        /// The base value for the bar in data units along the value axis.
        /// </summary>
        abstract member ``base``: float with get, set
        /// <summary>
        /// Skipped (excluded) border: 'start', 'end', 'left',  'right', 'bottom', 'top', 'middle', false (none) or true (all).
        /// </summary>
        abstract member borderSkipped: BarOptions.borderSkipped with get, set
        /// <summary>
        /// Border radius
        /// </summary>
        abstract member borderRadius: U2<float, ChartJs.BorderRadius> with get, set
        /// <summary>
        /// Amount to inflate the rectangle(s). This can be used to hide artifacts between bars.
        /// Unit is pixels. 'auto' translates to 0.33 pixels when barPercentage * categoryPercentage is 1, else 0.
        /// </summary>
        abstract member inflateAmount: BarOptions.inflateAmount with get, set
        /// <summary>
        /// Width of the border, number for all sides, object to specify width for each side specifically
        /// </summary>
        abstract member borderWidth: U2<float, BarOptions.borderWidth.U2.Case2> with get, set
        abstract member borderColor: ChartJs.Color with get, set
        abstract member backgroundColor: ChartJs.Color with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type BorderRadius =
        abstract member topLeft: float with get, set
        abstract member topRight: float with get, set
        abstract member bottomLeft: float with get, set
        abstract member bottomRight: float with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (topLeft: float, topRight: float, bottomLeft: float, bottomRight: float) : BorderRadius = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type BarHoverOptions =
        inherit ChartJs.CommonHoverOptions
        abstract member hoverBorderRadius: U2<float, ChartJs.BorderRadius> with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type BarElement<'T, 'O> =
        inherit ChartJs.Element<'T, 'O>
        inherit ChartJs.VisualElement

    [<AllowNullLiteral>]
    [<Interface>]
    type ElementOptionsByType<'TType> =
        abstract member arc: ElementOptionsByType.arc<'TType> with get, set
        abstract member bar: ElementOptionsByType.bar<'TType> with get, set
        abstract member line: ElementOptionsByType.line<'TType> with get, set
        abstract member point: ElementOptionsByType.point<'TType> with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type ElementChartOptions<'TType> =
        abstract member elements: ChartJs.ElementOptionsByType<'TType> with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type BasePlatform =
        /// <summary>
        /// Called at chart construction time, returns a context2d instance implementing
        /// the [W3C Canvas 2D Context API standard]<see href="https://www.w3.org/TR/2dcontext/">https://www.w3.org/TR/2dcontext/</see>.
        /// </summary>
        /// <param name="canvas">
        /// The canvas from which to acquire context (platform specific)
        /// </param>
        /// <param name="options">
        /// The chart options
        /// </param>
        abstract member acquireContext: canvas: Glutinum.Web.HTMLCanvasElement * ?options: Glutinum.Web.CanvasRenderingContext2DSettings -> Glutinum.Web.CanvasRenderingContext2D option
        /// <summary>
        /// Called at chart destruction time, releases any resources associated to the context
        /// previously returned by the acquireContext() method.
        /// </summary>
        /// <param name="context">
        /// The context2d instance
        /// </param>
        /// <returns>
        /// true if the method succeeded, else false
        /// </returns>
        abstract member releaseContext: context: Glutinum.Web.CanvasRenderingContext2D -> bool
        /// <summary>
        /// Registers the specified listener on the given chart.
        /// </summary>
        /// <param name="chart">
        /// Chart from which to listen for event
        /// </param>
        /// <param name="type">
        /// The (<see href="ChartEvent">ChartEvent</see>) type to listen for
        /// </param>
        /// <param name="listener">
        /// Receives a notification (an object that implements
        /// the <see href="ChartEvent">ChartEvent</see> interface) when an event of the specified type occurs.
        /// </param>
        abstract member addEventListener: chart: ChartJs.dist.types.Chart * ``type``: string * listener: (ChartJs.ChartEvent -> unit) -> unit
        /// <summary>
        /// Removes the specified listener previously registered with addEventListener.
        /// </summary>
        /// <param name="chart">
        /// Chart from which to remove the listener
        /// </param>
        /// <param name="type">
        /// The (<see href="ChartEvent">ChartEvent</see>) type to remove
        /// </param>
        /// <param name="listener">
        /// The listener function to remove from the event target.
        /// </param>
        abstract member removeEventListener: chart: ChartJs.dist.types.Chart * ``type``: string * listener: (ChartJs.ChartEvent -> unit) -> unit
        /// <returns>
        /// the current devicePixelRatio of the device this platform is connected to.
        /// </returns>
        abstract member getDevicePixelRatio: unit -> float
        /// <param name="canvas">
        /// The canvas for which to calculate the maximum size
        /// </param>
        /// <param name="width">
        /// Parent element's content width
        /// </param>
        /// <param name="height">
        /// Parent element's content height
        /// </param>
        /// <param name="aspectRatio">
        /// The aspect ratio to maintain
        /// </param>
        /// <returns>
        /// : number, height: number } the maximum size available.
        /// </returns>
        abstract member getMaximumSize: canvas: Glutinum.Web.HTMLCanvasElement * ?width: float * ?height: float * ?aspectRatio: float -> BasePlatform.getMaximumSize
        /// <param name="canvas">
        ///
        /// </param>
        /// <returns>
        /// true if the canvas is attached to the platform, false if not.
        /// </returns>
        abstract member isAttached: canvas: Glutinum.Web.HTMLCanvasElement -> bool
        /// <summary>
        /// Updates config with platform specific requirements
        /// </summary>
        /// <param name="config">
        ///
        /// </param>
        abstract member updateConfig: config: ChartJs.ChartConfiguration -> unit
        /// <summary>
        /// Updates config with platform specific requirements
        /// </summary>
        /// <param name="config">
        ///
        /// </param>
        abstract member updateConfig: config: ChartJs.ChartConfigurationCustomTypesPerDataset -> unit
        /// <summary>
        /// Updates config with platform specific requirements
        /// </summary>
        /// <param name="config">
        ///
        /// </param>
        abstract member updateConfig: config: U2<ChartJs.ChartConfiguration, ChartJs.ChartConfigurationCustomTypesPerDataset> -> unit

    [<AllowNullLiteral>]
    [<Interface>]
    type BasicPlatform =
        inherit ChartJs.BasePlatform

    [<AllowNullLiteral>]
    [<Interface>]
    type DomPlatform =
        inherit ChartJs.BasePlatform

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type DecimationAlgorithm =
        | lttb
        | [<CompiledName("min-max")>] minmax

    type DecimationOptions =
        U2<ChartJs.dist.types.LttbDecimationOptions, ChartJs.dist.types.MinMaxDecimationOptions>

    [<AllowNullLiteral>]
    [<Interface>]
    type FillerOptions =
        abstract member drawTime: FillerOptions.drawTime with get, set
        abstract member propagate: bool with get, set

    [<RequireQualifiedAccess>]
    [<Erase(CaseRules.None)>]
    type FillTarget =
        | start
        | ``end``
        | origin
        | stack
        | shape
        | Case1 of float
        | Case2 of string
        | Case3 of FillTarget.Cases.Case3
        | Case4 of bool

        [<Emit("$0")>]
        static member op_Implicit(value: float) : FillTarget = nativeOnly

        [<Emit("$0")>]
        static member op_ErasedCast(value: float) : FillTarget = nativeOnly

        [<Emit("$0")>]
        static member op_Implicit(value: string) : FillTarget = nativeOnly

        [<Emit("$0")>]
        static member op_ErasedCast(value: string) : FillTarget = nativeOnly

        [<Emit("$0")>]
        static member op_Implicit(value: FillTarget.Cases.Case3) : FillTarget = nativeOnly

        [<Emit("$0")>]
        static member op_ErasedCast(value: FillTarget.Cases.Case3) : FillTarget = nativeOnly

        [<Emit("$0")>]
        static member op_Implicit(value: bool) : FillTarget = nativeOnly

        [<Emit("$0")>]
        static member op_ErasedCast(value: bool) : FillTarget = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type ComplexFillTarget =
        /// <summary>
        /// The accepted values are the same as the filling mode values, so you may use absolute and relative dataset indexes and/or boundaries.
        /// </summary>
        abstract member target: ChartJs.FillTarget with get, set
        /// <summary>
        /// If no color is set, the default color will be the background color of the chart.
        /// </summary>
        abstract member above: ChartJs.Color with get, set
        /// <summary>
        /// Same as the above.
        /// </summary>
        abstract member below: ChartJs.Color with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type FillerControllerDatasetOptions =
        /// <summary>
        /// Both line and radar charts support a fill option on the dataset object which can be used to create area between two datasets or a dataset and a boundary, i.e. the scale origin, start or end
        /// </summary>
        abstract member fill: U2<ChartJs.FillTarget, ChartJs.ComplexFillTarget> with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type LegendItem =
        /// <summary>
        /// Label that will be displayed
        /// </summary>
        abstract member text: string with get, set
        /// <summary>
        /// Border radius of the legend box
        /// </summary>
        abstract member borderRadius: U2<float, ChartJs.BorderRadius> option with get, set
        /// <summary>
        /// Index of the associated dataset
        /// </summary>
        abstract member datasetIndex: float option with get, set
        /// <summary>
        /// Index the associated label in the labels array
        /// </summary>
        abstract member index: float option with get, set
        /// <summary>
        /// Fill style of the legend box
        /// </summary>
        abstract member fillStyle: ChartJs.Color option with get, set
        /// <summary>
        /// Font color for the text
        /// Defaults to LegendOptions.labels.color
        /// </summary>
        abstract member fontColor: ChartJs.Color option with get, set
        /// <summary>
        /// If true, this item represents a hidden dataset. Label will be rendered with a strike-through effect
        /// </summary>
        abstract member hidden: bool option with get, set
        /// <summary>
        /// For box border.
        /// </summary>
        abstract member lineCap: Glutinum.Web.CanvasLineCap option with get, set
        /// <summary>
        /// For box border.
        /// </summary>
        abstract member lineDash: ResizeArray<float> option with get, set
        /// <summary>
        /// For box border.
        /// </summary>
        abstract member lineDashOffset: float option with get, set
        /// <summary>
        /// For box border.
        /// </summary>
        abstract member lineJoin: Glutinum.Web.CanvasLineJoin option with get, set
        /// <summary>
        /// Width of box border
        /// </summary>
        abstract member lineWidth: float option with get, set
        /// <summary>
        /// Stroke style of the legend box
        /// </summary>
        abstract member strokeStyle: ChartJs.Color option with get, set
        /// <summary>
        /// Point style of the legend box (only used if usePointStyle is true)
        /// </summary>
        abstract member pointStyle: ChartJs.PointStyle option with get, set
        /// <summary>
        /// Rotation of the point in degrees (only used if usePointStyle is true)
        /// </summary>
        abstract member rotation: float option with get, set
        /// <summary>
        /// Text alignment
        /// </summary>
        abstract member textAlign: ChartJs.TextAlign option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (text: string, ?datasetIndex: float, ?index: float, ?fillStyle: ChartJs.Color, ?fontColor: ChartJs.Color, ?hidden: bool, ?lineCap: Glutinum.Web.CanvasLineCap, ?lineDash: ResizeArray<float>, ?lineDashOffset: float, ?lineJoin: Glutinum.Web.CanvasLineJoin, ?lineWidth: float, ?strokeStyle: ChartJs.Color, ?pointStyle: ChartJs.PointStyle, ?rotation: float, ?textAlign: ChartJs.TextAlign) : LegendItem = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (text: string, borderRadius: float, ?datasetIndex: float, ?index: float, ?fillStyle: ChartJs.Color, ?fontColor: ChartJs.Color, ?hidden: bool, ?lineCap: Glutinum.Web.CanvasLineCap, ?lineDash: ResizeArray<float>, ?lineDashOffset: float, ?lineJoin: Glutinum.Web.CanvasLineJoin, ?lineWidth: float, ?strokeStyle: ChartJs.Color, ?pointStyle: ChartJs.PointStyle, ?rotation: float, ?textAlign: ChartJs.TextAlign) : LegendItem = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (text: string, borderRadius: ChartJs.BorderRadius, ?datasetIndex: float, ?index: float, ?fillStyle: ChartJs.Color, ?fontColor: ChartJs.Color, ?hidden: bool, ?lineCap: Glutinum.Web.CanvasLineCap, ?lineDash: ResizeArray<float>, ?lineDashOffset: float, ?lineJoin: Glutinum.Web.CanvasLineJoin, ?lineWidth: float, ?strokeStyle: ChartJs.Color, ?pointStyle: ChartJs.PointStyle, ?rotation: float, ?textAlign: ChartJs.TextAlign) : LegendItem = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type LegendElement<'TType> =
        inherit ChartJs.Element<ChartJs.AnyObject, ChartJs.LegendOptions<'TType>>
        inherit ChartJs.LayoutItem
        abstract member chart: ChartJs.dist.types.Chart<'TType> with get, set
        abstract member ctx: Glutinum.Web.CanvasRenderingContext2D with get, set
        abstract member legendItems: ResizeArray<ChartJs.LegendItem> option with get, set
        abstract member options: ChartJs.LegendOptions<'TType> with get, set
        abstract member fit: unit -> unit

    [<AllowNullLiteral>]
    [<Interface>]
    type LegendOptions<'TType> =
        /// <summary>
        /// Is the legend shown?
        /// </summary>
        abstract member display: bool with get, set
        /// <summary>
        /// Position of the legend.
        /// </summary>
        abstract member position: ChartJs.LayoutPosition with get, set
        /// <summary>
        /// Alignment of the legend.
        /// </summary>
        abstract member align: ChartJs.Align with get, set
        /// <summary>
        /// Maximum height of the legend, in pixels
        /// </summary>
        abstract member maxHeight: float with get, set
        /// <summary>
        /// Maximum width of the legend, in pixels
        /// </summary>
        abstract member maxWidth: float with get, set
        /// <summary>
        /// Marks that this box should take the full width/height of the canvas (moving other boxes). This is unlikely to need to be changed in day-to-day use.
        /// </summary>
        abstract member fullSize: bool with get, set
        /// <summary>
        /// Legend will show datasets in reverse order.
        /// </summary>
        abstract member reverse: bool with get, set
        /// <summary>
        /// A callback that is called when a click event is registered on a label item.
        /// </summary>
        abstract member onClick: e: ChartJs.ChartEvent * legendItem: ChartJs.LegendItem * legend: ChartJs.LegendElement<'TType> -> unit
        /// <summary>
        /// A callback that is called when a 'mousemove' event is registered on top of a label item
        /// </summary>
        abstract member onHover: e: ChartJs.ChartEvent * legendItem: ChartJs.LegendItem * legend: ChartJs.LegendElement<'TType> -> unit
        /// <summary>
        /// A callback that is called when a 'mousemove' event is registered outside of a previously hovered label item.
        /// </summary>
        abstract member onLeave: e: ChartJs.ChartEvent * legendItem: ChartJs.LegendItem * legend: ChartJs.LegendElement<'TType> -> unit
        abstract member labels: LegendOptions.labels with get, set
        /// <summary>
        /// true for rendering the legends from right to left.
        /// </summary>
        abstract member rtl: bool with get, set
        /// <summary>
        /// This will force the text direction 'rtl' or 'ltr' on the canvas for rendering the legend, regardless of the css specified on the canvas
        /// </summary>
        abstract member textDirection: string with get, set
        abstract member title: LegendOptions.title with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type TitleOptions =
        /// <summary>
        /// Alignment of the title.
        /// </summary>
        abstract member align: ChartJs.Align with get, set
        /// <summary>
        /// Is the title shown?
        /// </summary>
        abstract member display: bool with get, set
        /// <summary>
        /// Position of title
        /// </summary>
        abstract member position: TitleOptions.position with get, set
        /// <summary>
        /// Color of text
        /// </summary>
        abstract member color: ChartJs.Color with get, set
        abstract member font: ChartJs.ScriptableAndScriptableOptions<TitleOptions.font, ChartJs.ScriptableChartContext> with get, set
        /// <summary>
        /// Marks that this box should take the full width/height of the canvas (moving other boxes). If set to <c>false</c>, places the box above/beside the
        /// chart area
        /// </summary>
        abstract member fullSize: bool with get, set
        /// <summary>
        /// Adds padding above and below the title text if a single number is specified. It is also possible to change top and bottom padding separately.
        /// </summary>
        abstract member padding: U2<float, TitleOptions.padding.U2.Case2> with get, set
        /// <summary>
        /// Title text to display. If specified as an array, text is rendered on multiple lines.
        /// </summary>
        abstract member text: U2<string, ResizeArray<string>> with get, set

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type TooltipXAlignment =
        | left
        | center
        | right

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type TooltipYAlignment =
        | top
        | center
        | bottom

    [<AllowNullLiteral>]
    [<Interface>]
    type TooltipLabelStyle =
        abstract member borderColor: ChartJs.Color with get, set
        abstract member backgroundColor: ChartJs.Color with get, set
        /// <summary>
        /// Width of border line
        /// </summary>
        abstract member borderWidth: float option with get, set
        /// <summary>
        /// Border dash
        /// </summary>
        abstract member borderDash: float * float option with get, set
        /// <summary>
        /// Border dash offset
        /// </summary>
        abstract member borderDashOffset: float option with get, set
        /// <summary>
        /// borderRadius
        /// </summary>
        abstract member borderRadius: U2<float, ChartJs.BorderRadius> option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type TooltipModel<'TType> =
        inherit ChartJs.Element<ChartJs.AnyObject, ChartJs.TooltipOptions<'TType>>
        abstract member chart: ChartJs.dist.types.Chart<'TType> with get
        abstract member dataPoints: ResizeArray<ChartJs.TooltipItem<'TType>> with get, set
        abstract member xAlign: ChartJs.TooltipXAlignment with get, set
        abstract member yAlign: ChartJs.TooltipYAlignment with get, set
        abstract member x: float with get, set
        abstract member y: float with get, set
        abstract member width: float with get, set
        abstract member height: float with get, set
        abstract member caretX: float with get, set
        abstract member caretY: float with get, set
        abstract member body: ResizeArray<TooltipModel.body.Item> with get, set
        abstract member beforeBody: ResizeArray<string> with get, set
        abstract member afterBody: ResizeArray<string> with get, set
        abstract member title: ResizeArray<string> with get, set
        abstract member footer: ResizeArray<string> with get, set
        abstract member labelColors: ResizeArray<ChartJs.TooltipLabelStyle> with get, set
        abstract member labelTextColors: ResizeArray<ChartJs.Color> with get, set
        abstract member labelPointStyles: ResizeArray<TooltipModel.labelPointStyles.Item> with get, set
        abstract member opacity: float with get, set
        abstract member options: ChartJs.TooltipOptions<'TType> with get, set
        abstract member getActiveElements: unit -> ResizeArray<ChartJs.ActiveElement>
        abstract member setActiveElements: active: ResizeArray<ChartJs.ActiveDataPoint> * eventPosition: ChartJs.Point -> unit

    [<AllowNullLiteral>]
    [<Interface>]
    type TooltipPosition =
        inherit ChartJs.Point
        abstract member xAlign: ChartJs.TooltipXAlignment option with get, set
        abstract member yAlign: ChartJs.TooltipYAlignment option with get, set

    type TooltipPositionerFunction<'TType> =
        delegate of items: ResizeArray<ChartJs.ActiveElement> * eventPosition: ChartJs.Point -> U2<ChartJs.TooltipPosition, bool>

    [<AllowNullLiteral>]
    [<Interface>]
    type TooltipPositionerMap =
        abstract member average: items: ResizeArray<ChartJs.ActiveElement> * eventPosition: ChartJs.Point -> U2<ChartJs.TooltipPosition, bool>
        abstract member nearest: items: ResizeArray<ChartJs.ActiveElement> * eventPosition: ChartJs.Point -> U2<ChartJs.TooltipPosition, bool>

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type TooltipPositioner =
        | average
        | nearest

    [<AllowNullLiteral>]
    [<Interface>]
    type Tooltip =
        inherit ChartJs.Plugin
        abstract member positioners: ChartJs.TooltipPositionerMap with get

    [<AllowNullLiteral>]
    [<Interface>]
    type TooltipDatasetCallbacks<'TType, 'Model, 'Item> =
        abstract member beforeLabel: tooltipItem: 'Item -> U3<string, ResizeArray<string>, unit>
        abstract member label: tooltipItem: 'Item -> U3<string, ResizeArray<string>, unit>
        abstract member afterLabel: tooltipItem: 'Item -> U3<string, ResizeArray<string>, unit>
        abstract member labelColor: tooltipItem: 'Item -> U2<ChartJs.TooltipLabelStyle, unit>
        abstract member labelTextColor: tooltipItem: 'Item -> U2<ChartJs.Color, unit>
        abstract member labelPointStyle: tooltipItem: 'Item -> U2<TooltipDatasetCallbacks.labelPointStyle.U2.Case1, unit>

    [<AllowNullLiteral>]
    [<Interface>]
    type TooltipCallbacks<'TType, 'Model, 'Item> =
        inherit ChartJs.TooltipDatasetCallbacks<'TType, 'Model, 'Item>
        abstract member beforeTitle: tooltipItems: ResizeArray<'Item> -> U3<string, ResizeArray<string>, unit>
        abstract member title: tooltipItems: ResizeArray<'Item> -> U3<string, ResizeArray<string>, unit>
        abstract member afterTitle: tooltipItems: ResizeArray<'Item> -> U3<string, ResizeArray<string>, unit>
        abstract member beforeBody: tooltipItems: ResizeArray<'Item> -> U3<string, ResizeArray<string>, unit>
        abstract member afterBody: tooltipItems: ResizeArray<'Item> -> U3<string, ResizeArray<string>, unit>
        abstract member beforeLabel: tooltipItem: 'Item -> U3<string, ResizeArray<string>, unit>
        abstract member label: tooltipItem: 'Item -> U3<string, ResizeArray<string>, unit>
        abstract member afterLabel: tooltipItem: 'Item -> U3<string, ResizeArray<string>, unit>
        abstract member labelColor: tooltipItem: 'Item -> U2<ChartJs.TooltipLabelStyle, unit>
        abstract member labelTextColor: tooltipItem: 'Item -> U2<ChartJs.Color, unit>
        abstract member labelPointStyle: tooltipItem: 'Item -> U2<TooltipCallbacks.labelPointStyle.U2.Case1, unit>
        abstract member beforeFooter: tooltipItems: ResizeArray<'Item> -> U3<string, ResizeArray<string>, unit>
        abstract member footer: tooltipItems: ResizeArray<'Item> -> U3<string, ResizeArray<string>, unit>
        abstract member afterFooter: tooltipItems: ResizeArray<'Item> -> U3<string, ResizeArray<string>, unit>

    [<AllowNullLiteral>]
    [<Interface>]
    type ExtendedPlugin<'TType, 'O, 'Model> =
        /// <param name="chart">
        /// The chart instance.
        /// </param>
        /// <param name="args">
        /// The call arguments.
        /// </param>
        /// <param name="options">
        /// The plugin options.
        /// </param>
        /// <returns>
        /// <c>false</c> to cancel the chart tooltip drawing.
        /// </returns>
        abstract member beforeTooltipDraw: ExtendedPlugin.beforeTooltipDraw option with get, set
        /// <param name="chart">
        /// The chart instance.
        /// </param>
        /// <param name="args">
        /// The call arguments.
        /// </param>
        /// <param name="options">
        /// The plugin options.
        /// </param>
        abstract member afterTooltipDraw: ExtendedPlugin.afterTooltipDraw option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type ScriptableTooltipContext<'TType> =
        abstract member chart: ChartJs.dist.types.Chart<'TType, ResizeArray<obj>, obj> with get, set
        abstract member tooltip: ChartJs.TooltipModel<'TType> with get, set
        abstract member tooltipItems: ResizeArray<ChartJs.TooltipItem<'TType>> with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type TooltipOptions<'TType> =
        inherit ChartJs.CoreInteractionOptions
        /// <summary>
        /// Are on-canvas tooltips enabled?
        /// </summary>
        abstract member enabled: ChartJs.Scriptable<bool, ChartJs.ScriptableTooltipContext<'TType>> with get, set
        /// <summary>
        /// See external tooltip section.
        /// </summary>
        abstract member external: args: TooltipOptions.external.args<'TType> -> unit
        /// <summary>
        /// The mode for positioning the tooltip
        /// </summary>
        abstract member position: ChartJs.Scriptable<ChartJs.TooltipPositioner, ChartJs.ScriptableTooltipContext<'TType>> with get, set
        /// <summary>
        /// Override the tooltip alignment calculations
        /// </summary>
        abstract member xAlign: ChartJs.Scriptable<ChartJs.TooltipXAlignment, ChartJs.ScriptableTooltipContext<'TType>> with get, set
        abstract member yAlign: ChartJs.Scriptable<ChartJs.TooltipYAlignment, ChartJs.ScriptableTooltipContext<'TType>> with get, set
        /// <summary>
        /// Sort tooltip items.
        /// </summary>
        abstract member itemSort: TooltipOptions.itemSort<'TType> with get, set
        abstract member filter: TooltipOptions.filter<'TType> with get, set
        /// <summary>
        /// Background color of the tooltip.
        /// </summary>
        abstract member backgroundColor: ChartJs.Scriptable<ChartJs.Color, ChartJs.ScriptableTooltipContext<'TType>> with get, set
        /// <summary>
        /// Padding between the color box and the text.
        /// </summary>
        abstract member boxPadding: float with get, set
        /// <summary>
        /// Color of title
        /// </summary>
        abstract member titleColor: ChartJs.Scriptable<ChartJs.Color, ChartJs.ScriptableTooltipContext<'TType>> with get, set
        /// <summary>
        /// See Fonts
        /// </summary>
        abstract member titleFont: ChartJs.ScriptableAndScriptableOptions<TooltipOptions.titleFont, ChartJs.ScriptableTooltipContext<'TType>> with get, set
        /// <summary>
        /// Spacing to add to top and bottom of each title line.
        /// </summary>
        abstract member titleSpacing: ChartJs.Scriptable<float, ChartJs.ScriptableTooltipContext<'TType>> with get, set
        /// <summary>
        /// Margin to add on bottom of title section.
        /// </summary>
        abstract member titleMarginBottom: ChartJs.Scriptable<float, ChartJs.ScriptableTooltipContext<'TType>> with get, set
        /// <summary>
        /// Horizontal alignment of the title text lines.
        /// </summary>
        abstract member titleAlign: ChartJs.Scriptable<ChartJs.TextAlign, ChartJs.ScriptableTooltipContext<'TType>> with get, set
        /// <summary>
        /// Spacing to add to top and bottom of each tooltip item.
        /// </summary>
        abstract member bodySpacing: ChartJs.Scriptable<float, ChartJs.ScriptableTooltipContext<'TType>> with get, set
        /// <summary>
        /// Color of body
        /// </summary>
        abstract member bodyColor: ChartJs.Scriptable<ChartJs.Color, ChartJs.ScriptableTooltipContext<'TType>> with get, set
        /// <summary>
        /// See Fonts.
        /// </summary>
        abstract member bodyFont: ChartJs.ScriptableAndScriptableOptions<TooltipOptions.bodyFont, ChartJs.ScriptableTooltipContext<'TType>> with get, set
        /// <summary>
        /// Horizontal alignment of the body text lines.
        /// </summary>
        abstract member bodyAlign: ChartJs.Scriptable<ChartJs.TextAlign, ChartJs.ScriptableTooltipContext<'TType>> with get, set
        /// <summary>
        /// Spacing to add to top and bottom of each footer line.
        /// </summary>
        abstract member footerSpacing: ChartJs.Scriptable<float, ChartJs.ScriptableTooltipContext<'TType>> with get, set
        /// <summary>
        /// Margin to add before drawing the footer.
        /// </summary>
        abstract member footerMarginTop: ChartJs.Scriptable<float, ChartJs.ScriptableTooltipContext<'TType>> with get, set
        /// <summary>
        /// Color of footer
        /// </summary>
        abstract member footerColor: ChartJs.Scriptable<ChartJs.Color, ChartJs.ScriptableTooltipContext<'TType>> with get, set
        /// <summary>
        /// See Fonts
        /// </summary>
        abstract member footerFont: ChartJs.ScriptableAndScriptableOptions<TooltipOptions.footerFont, ChartJs.ScriptableTooltipContext<'TType>> with get, set
        /// <summary>
        /// Horizontal alignment of the footer text lines.
        /// </summary>
        abstract member footerAlign: ChartJs.Scriptable<ChartJs.TextAlign, ChartJs.ScriptableTooltipContext<'TType>> with get, set
        /// <summary>
        /// Padding to add to the tooltip
        /// </summary>
        abstract member padding: ChartJs.Scriptable<ChartJs.Padding, ChartJs.ScriptableTooltipContext<'TType>> with get, set
        /// <summary>
        /// Extra distance to move the end of the tooltip arrow away from the tooltip point.
        /// </summary>
        abstract member caretPadding: ChartJs.Scriptable<float, ChartJs.ScriptableTooltipContext<'TType>> with get, set
        /// <summary>
        /// Size, in px, of the tooltip arrow.
        /// </summary>
        abstract member caretSize: ChartJs.Scriptable<float, ChartJs.ScriptableTooltipContext<'TType>> with get, set
        /// <summary>
        /// Radius of tooltip corner curves.
        /// </summary>
        abstract member cornerRadius: ChartJs.Scriptable<U2<float, ChartJs.BorderRadius>, ChartJs.ScriptableTooltipContext<'TType>> with get, set
        /// <summary>
        /// Color to draw behind the colored boxes when multiple items are in the tooltip.
        /// </summary>
        abstract member multiKeyBackground: ChartJs.Scriptable<ChartJs.Color, ChartJs.ScriptableTooltipContext<'TType>> with get, set
        /// <summary>
        /// If true, color boxes are shown in the tooltip.
        /// </summary>
        abstract member displayColors: ChartJs.Scriptable<bool, ChartJs.ScriptableTooltipContext<'TType>> with get, set
        /// <summary>
        /// Width of the color box if displayColors is true.
        /// </summary>
        abstract member boxWidth: ChartJs.Scriptable<float, ChartJs.ScriptableTooltipContext<'TType>> with get, set
        /// <summary>
        /// Height of the color box if displayColors is true.
        /// </summary>
        abstract member boxHeight: ChartJs.Scriptable<float, ChartJs.ScriptableTooltipContext<'TType>> with get, set
        /// <summary>
        /// Use the corresponding point style (from dataset options) instead of color boxes, ex: star, triangle etc. (size is based on the minimum value between boxWidth and boxHeight)
        /// </summary>
        abstract member usePointStyle: ChartJs.Scriptable<bool, ChartJs.ScriptableTooltipContext<'TType>> with get, set
        /// <summary>
        /// Color of the border.
        /// </summary>
        abstract member borderColor: ChartJs.Scriptable<ChartJs.Color, ChartJs.ScriptableTooltipContext<'TType>> with get, set
        /// <summary>
        /// Size of the border.
        /// </summary>
        abstract member borderWidth: ChartJs.Scriptable<float, ChartJs.ScriptableTooltipContext<'TType>> with get, set
        /// <summary>
        /// true for rendering the legends from right to left.
        /// </summary>
        abstract member rtl: ChartJs.Scriptable<bool, ChartJs.ScriptableTooltipContext<'TType>> with get, set
        /// <summary>
        /// This will force the text direction 'rtl' or 'ltr on the canvas for rendering the tooltips, regardless of the css specified on the canvas
        /// </summary>
        abstract member textDirection: ChartJs.Scriptable<string, ChartJs.ScriptableTooltipContext<'TType>> with get, set
        abstract member animation: U2<TooltipOptions.animation.U2.Case1<'TType>, bool> with get, set
        abstract member animations: U2<ChartJs.AnimationsSpec<'TType>, bool> with get, set
        abstract member callbacks: ChartJs.TooltipCallbacks<'TType> with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type TooltipDatasetOptions<'TType> =
        abstract member callbacks: ChartJs.TooltipDatasetCallbacks<'TType> with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type TooltipItem<'TType> =
        /// <summary>
        /// The chart the tooltip is being shown on
        /// </summary>
        abstract member chart: ChartJs.dist.types.Chart with get, set
        /// <summary>
        /// Label for the tooltip
        /// </summary>
        abstract member label: string with get, set
        /// <summary>
        /// Parsed data values for the given <c>dataIndex</c> and <c>datasetIndex</c>
        /// </summary>
        abstract member parsed: obj with get, set
        /// <summary>
        /// Raw data values for the given <c>dataIndex</c> and <c>datasetIndex</c>
        /// </summary>
        abstract member raw: obj with get, set
        /// <summary>
        /// Formatted value for the tooltip
        /// </summary>
        abstract member formattedValue: string with get, set
        /// <summary>
        /// The dataset the item comes from
        /// </summary>
        abstract member dataset: obj with get, set
        /// <summary>
        /// Index of the dataset the item comes from
        /// </summary>
        abstract member datasetIndex: float with get, set
        /// <summary>
        /// Index of this data item in the dataset
        /// </summary>
        abstract member dataIndex: float with get, set
        /// <summary>
        /// The chart element (point, arc, bar, etc.) for this tooltip item
        /// </summary>
        abstract member element: ChartJs.Element with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type PluginDatasetOptionsByType<'TType> =
        abstract member tooltip: ChartJs.TooltipDatasetOptions<'TType> with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type PluginOptionsByType<'TType> =
        abstract member colors: ChartJs.ColorsPluginOptions with get, set
        abstract member decimation: ChartJs.DecimationOptions with get, set
        abstract member filler: ChartJs.FillerOptions with get, set
        abstract member legend: ChartJs.LegendOptions<'TType> with get, set
        abstract member subtitle: ChartJs.TitleOptions with get, set
        abstract member title: ChartJs.TitleOptions with get, set
        abstract member tooltip: ChartJs.TooltipOptions<'TType> with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type PluginChartOptions<'TType> =
        abstract member plugins: ChartJs.PluginOptionsByType<'TType> with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type BorderOptions =
        abstract member display: bool with get, set
        abstract member dash: ChartJs.Scriptable<ResizeArray<float>, ChartJs.ScriptableScaleContext> with get, set
        abstract member dashOffset: ChartJs.Scriptable<float, ChartJs.ScriptableScaleContext> with get, set
        abstract member color: ChartJs.Color with get, set
        abstract member width: float with get, set
        abstract member z: float with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type GridLineOptions =
        abstract member display: bool with get, set
        abstract member circular: bool with get, set
        abstract member color: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableScaleContext> with get, set
        abstract member lineWidth: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableScaleContext> with get, set
        abstract member drawOnChartArea: bool with get, set
        abstract member drawTicks: bool with get, set
        abstract member tickBorderDash: ChartJs.Scriptable<ResizeArray<float>, ChartJs.ScriptableScaleContext> with get, set
        abstract member tickBorderDashOffset: ChartJs.Scriptable<float, ChartJs.ScriptableScaleContext> with get, set
        abstract member tickColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableScaleContext> with get, set
        abstract member tickLength: float with get, set
        abstract member tickWidth: float with get, set
        abstract member offset: bool with get, set
        abstract member z: float with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type TickOptions =
        /// <summary>
        /// Color of label backdrops.
        /// </summary>
        abstract member backdropColor: ChartJs.Scriptable<ChartJs.Color, ChartJs.ScriptableScaleContext> with get, set
        /// <summary>
        /// Padding of tick backdrop.
        /// </summary>
        abstract member backdropPadding: U2<float, ChartJs.ChartArea> with get, set
        /// <summary>
        /// Returns the string representation of the tick value as it should be displayed on the chart. See callback.
        /// </summary>
        abstract member callback: TickOptions.callback with get, set
        /// <summary>
        /// If true, show tick labels.
        /// </summary>
        abstract member display: bool with get, set
        /// <summary>
        /// Color of tick
        /// </summary>
        abstract member color: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableScaleContext> with get, set
        /// <summary>
        /// see Fonts
        /// </summary>
        abstract member font: ChartJs.ScriptableAndScriptableOptions<TickOptions.font, ChartJs.ScriptableScaleContext> with get, set
        /// <summary>
        /// Sets the offset of the tick labels from the axis
        /// </summary>
        abstract member padding: float with get, set
        /// <summary>
        /// If true, draw a background behind the tick labels.
        /// </summary>
        abstract member showLabelBackdrop: ChartJs.Scriptable<bool, ChartJs.ScriptableScaleContext> with get, set
        /// <summary>
        /// The color of the stroke around the text.
        /// </summary>
        abstract member textStrokeColor: ChartJs.Scriptable<ChartJs.Color, ChartJs.ScriptableScaleContext> with get, set
        /// <summary>
        /// Stroke width around the text.
        /// </summary>
        abstract member textStrokeWidth: ChartJs.Scriptable<float, ChartJs.ScriptableScaleContext> with get, set
        /// <summary>
        /// z-index of tick layer. Useful when ticks are drawn on chart area. Values <= 0 are drawn under datasets, > 0 on top.
        /// </summary>
        abstract member z: float with get, set
        abstract member major: TickOptions.major with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type CartesianTickOptions =
        /// <summary>
        /// Color of label backdrops.
        /// </summary>
        abstract member backdropColor: ChartJs.Scriptable<ChartJs.Color, ChartJs.ScriptableScaleContext> with get, set
        /// <summary>
        /// Padding of tick backdrop.
        /// </summary>
        abstract member backdropPadding: U2<float, ChartJs.ChartArea> with get, set
        /// <summary>
        /// Returns the string representation of the tick value as it should be displayed on the chart. See callback.
        /// </summary>
        abstract member callback: CartesianTickOptions.callback with get, set
        /// <summary>
        /// If true, show tick labels.
        /// </summary>
        abstract member display: bool with get, set
        /// <summary>
        /// Color of tick
        /// </summary>
        abstract member color: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableScaleContext> with get, set
        /// <summary>
        /// see Fonts
        /// </summary>
        abstract member font: ChartJs.ScriptableAndScriptableOptions<CartesianTickOptions.font, ChartJs.ScriptableScaleContext> with get, set
        abstract member padding: float with get, set
        /// <summary>
        /// If true, draw a background behind the tick labels.
        /// </summary>
        abstract member showLabelBackdrop: ChartJs.Scriptable<bool, ChartJs.ScriptableScaleContext> with get, set
        /// <summary>
        /// The color of the stroke around the text.
        /// </summary>
        abstract member textStrokeColor: ChartJs.Scriptable<ChartJs.Color, ChartJs.ScriptableScaleContext> with get, set
        /// <summary>
        /// Stroke width around the text.
        /// </summary>
        abstract member textStrokeWidth: ChartJs.Scriptable<float, ChartJs.ScriptableScaleContext> with get, set
        /// <summary>
        /// z-index of tick layer. Useful when ticks are drawn on chart area. Values <= 0 are drawn under datasets, > 0 on top.
        /// </summary>
        abstract member z: float with get, set
        abstract member major: TickOptions.major with get, set
        /// <summary>
        /// The number of ticks to examine when deciding how many labels will fit. Setting a smaller value will be faster, but may be less accurate when there is large variability in label length.
        /// </summary>
        abstract member sampleSize: float with get, set
        /// <summary>
        /// The label alignment
        /// </summary>
        abstract member align: CartesianTickOptions.align with get, set
        /// <summary>
        /// If true, automatically calculates how many labels can be shown and hides labels accordingly. Labels will be rotated up to maxRotation before skipping any. Turn autoSkip off to show all labels no matter what.
        /// </summary>
        abstract member autoSkip: bool with get, set
        /// <summary>
        /// Padding between the ticks on the horizontal axis when autoSkip is enabled.
        /// </summary>
        abstract member autoSkipPadding: float with get, set
        /// <summary>
        /// How is the label positioned perpendicular to the axis direction.
        /// This only applies when the rotation is 0 and the axis position is one of "top", "left", "right", or "bottom"
        /// </summary>
        abstract member crossAlign: CartesianTickOptions.crossAlign with get, set
        /// <summary>
        /// Should the defined <c>min</c> and <c>max</c> values be presented as ticks even if they are not "nice".
        /// </summary>
        abstract member includeBounds: bool with get, set
        /// <summary>
        /// Distance in pixels to offset the label from the centre point of the tick (in the x direction for the x axis, and the y direction for the y axis). Note: this can cause labels at the edges to be cropped by the edge of the canvas
        /// </summary>
        abstract member labelOffset: float with get, set
        /// <summary>
        /// Minimum rotation for tick labels. Note: Only applicable to horizontal scales.
        /// </summary>
        abstract member minRotation: float with get, set
        /// <summary>
        /// Maximum rotation for tick labels when rotating to condense labels. Note: Rotation doesn't occur until necessary. Note: Only applicable to horizontal scales.
        /// </summary>
        abstract member maxRotation: float with get, set
        /// <summary>
        /// Flips tick labels around axis, displaying the labels inside the chart instead of outside. Note: Only applicable to vertical scales.
        /// </summary>
        abstract member mirror: bool with get, set
        /// <summary>
        /// Maximum number of ticks and gridlines to show.
        /// </summary>
        abstract member maxTicksLimit: float with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type ScriptableCartesianScaleContext =
        abstract member scale: ScriptableCartesianScaleContext.scale with get, set
        abstract member ``type``: string with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type ScriptableChartContext =
        abstract member chart: ChartJs.dist.types.Chart with get, set
        abstract member ``type``: string with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type CartesianScaleOptions =
        inherit ChartJs.CoreScaleOptions
        /// <summary>
        /// Scale boundary strategy (bypassed by min/max time options)
        /// - <c>data</c>: make sure data are fully visible, ticks outside are removed
        /// - <c>ticks</c>: make sure ticks are fully visible, data outside are truncated
        /// </summary>
        abstract member bounds: CartesianScaleOptions.bounds with get, set
        /// <summary>
        /// Position of the axis.
        /// </summary>
        abstract member position: CartesianScaleOptions.position with get, set
        /// <summary>
        /// Stack group. Axes at the same <c>position</c> with same <c>stack</c> are stacked.
        /// </summary>
        abstract member stack: string option with get, set
        /// <summary>
        /// Weight of the scale in stack group. Used to determine the amount of allocated space for the scale within the group.
        /// </summary>
        abstract member stackWeight: float option with get, set
        /// <summary>
        /// Which type of axis this is. Possible values are: 'x', 'y', 'r'. If not set, this is inferred from the first character of the ID which should be 'x', 'y' or 'r'.
        /// </summary>
        abstract member axis: CartesianScaleOptions.axis with get, set
        /// <summary>
        /// User defined minimum value for the scale, overrides minimum value from data.
        /// </summary>
        abstract member min: float with get, set
        /// <summary>
        /// User defined maximum value for the scale, overrides maximum value from data.
        /// </summary>
        abstract member max: float with get, set
        /// <summary>
        /// If true, extra space is added to the both edges and the axis is scaled to fit into the chart area. This is set to true for a bar chart by default.
        /// </summary>
        abstract member offset: bool with get, set
        abstract member grid: CartesianScaleOptions.grid with get, set
        abstract member border: ChartJs.BorderOptions with get, set
        /// <summary>
        /// Options for the scale title.
        /// </summary>
        abstract member title: CartesianScaleOptions.title with get, set
        /// <summary>
        /// If true, data will be comprised between datasets of data
        /// </summary>
        abstract member stacked: CartesianScaleOptions.stacked option with get, set
        abstract member ticks: ChartJs.CartesianTickOptions with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type CategoryScaleOptions =
        /// <summary>
        /// Clip the dataset drawing against the size of the scale instead of chart area.
        /// </summary>
        abstract member clip: bool with get, set
        /// <summary>
        /// Background color of the scale area.
        /// </summary>
        abstract member backgroundColor: ChartJs.Color with get, set
        /// <summary>
        /// Stack group. Axes at the same <c>position</c> with same <c>stack</c> are stacked.
        /// </summary>
        abstract member stack: string option with get, set
        /// <summary>
        /// Scale boundary strategy (bypassed by min/max time options)
        /// - <c>data</c>: make sure data are fully visible, ticks outside are removed
        /// - <c>ticks</c>: make sure ticks are fully visible, data outside are truncated
        /// </summary>
        abstract member bounds: CategoryScaleOptions.bounds with get, set
        /// <summary>
        /// Position of the axis.
        /// </summary>
        abstract member position: CategoryScaleOptions.position with get, set
        /// <summary>
        /// Weight of the scale in stack group. Used to determine the amount of allocated space for the scale within the group.
        /// </summary>
        abstract member stackWeight: float option with get, set
        /// <summary>
        /// Which type of axis this is. Possible values are: 'x', 'y', 'r'. If not set, this is inferred from the first character of the ID which should be 'x', 'y' or 'r'.
        /// </summary>
        abstract member axis: CategoryScaleOptions.axis with get, set
        /// <summary>
        /// If true, extra space is added to the both edges and the axis is scaled to fit into the chart area. This is set to true for a bar chart by default.
        /// </summary>
        abstract member offset: bool with get, set
        abstract member grid: CategoryScaleOptions.grid with get, set
        abstract member border: ChartJs.BorderOptions with get, set
        /// <summary>
        /// Options for the scale title.
        /// </summary>
        abstract member title: CartesianScaleOptions.title with get, set
        /// <summary>
        /// If true, data will be comprised between datasets of data
        /// </summary>
        abstract member stacked: CategoryScaleOptions.stacked option with get, set
        abstract member ticks: ChartJs.CartesianTickOptions with get, set
        /// <summary>
        /// Controls the axis global visibility (visible when true, hidden when false). When display: 'auto', the axis is visible only if at least one associated dataset is visible.
        /// </summary>
        abstract member display: CategoryScaleOptions.display with get, set
        /// <summary>
        /// Align pixel values to device pixels
        /// </summary>
        abstract member alignToPixels: bool with get, set
        /// <summary>
        /// Reverse the scale.
        /// </summary>
        abstract member reverse: bool with get, set
        /// <summary>
        /// The weight used to sort the axis. Higher weights are further away from the chart area.
        /// </summary>
        abstract member weight: float with get, set
        /// <summary>
        /// Adjustment used when calculating the maximum data value.
        /// </summary>
        abstract member suggestedMin: obj with get, set
        /// <summary>
        /// Adjustment used when calculating the minimum data value.
        /// </summary>
        abstract member suggestedMax: obj with get, set
        /// <summary>
        /// Callback called before the update process starts.
        /// </summary>
        abstract member beforeUpdate: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs before dimensions are set.
        /// </summary>
        abstract member beforeSetDimensions: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs after dimensions are set.
        /// </summary>
        abstract member afterSetDimensions: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs before data limits are determined.
        /// </summary>
        abstract member beforeDataLimits: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs after data limits are determined.
        /// </summary>
        abstract member afterDataLimits: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs before ticks are created.
        /// </summary>
        abstract member beforeBuildTicks: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs after ticks are created. Useful for filtering ticks.
        /// </summary>
        abstract member afterBuildTicks: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs before ticks are converted into strings.
        /// </summary>
        abstract member beforeTickToLabelConversion: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs after ticks are converted into strings.
        /// </summary>
        abstract member afterTickToLabelConversion: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs before tick rotation is determined.
        /// </summary>
        abstract member beforeCalculateLabelRotation: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs after tick rotation is determined.
        /// </summary>
        abstract member afterCalculateLabelRotation: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs before the scale fits to the canvas.
        /// </summary>
        abstract member beforeFit: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs after the scale fits to the canvas.
        /// </summary>
        abstract member afterFit: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs at the end of the update process.
        /// </summary>
        abstract member afterUpdate: axis: ChartJs.Scale -> unit
        abstract member min: U2<string, float> with get, set
        abstract member max: U2<string, float> with get, set
        abstract member labels: U2<ResizeArray<string>, ResizeArray<ResizeArray<string>>> with get, set

    type CategoryScale<'O> =
        ChartJs.Scale<'O>

    [<AllowNullLiteral>]
    [<Interface>]
    type LinearScaleOptions =
        /// <summary>
        /// Scale boundary strategy (bypassed by min/max time options)
        /// - <c>data</c>: make sure data are fully visible, ticks outside are removed
        /// - <c>ticks</c>: make sure ticks are fully visible, data outside are truncated
        /// </summary>
        abstract member bounds: LinearScaleOptions.bounds with get, set
        /// <summary>
        /// Position of the axis.
        /// </summary>
        abstract member position: LinearScaleOptions.position with get, set
        /// <summary>
        /// Stack group. Axes at the same <c>position</c> with same <c>stack</c> are stacked.
        /// </summary>
        abstract member stack: string option with get, set
        /// <summary>
        /// Weight of the scale in stack group. Used to determine the amount of allocated space for the scale within the group.
        /// </summary>
        abstract member stackWeight: float option with get, set
        /// <summary>
        /// Which type of axis this is. Possible values are: 'x', 'y', 'r'. If not set, this is inferred from the first character of the ID which should be 'x', 'y' or 'r'.
        /// </summary>
        abstract member axis: LinearScaleOptions.axis with get, set
        /// <summary>
        /// User defined minimum value for the scale, overrides minimum value from data.
        /// </summary>
        abstract member min: float with get, set
        /// <summary>
        /// User defined maximum value for the scale, overrides maximum value from data.
        /// </summary>
        abstract member max: float with get, set
        /// <summary>
        /// If true, extra space is added to the both edges and the axis is scaled to fit into the chart area. This is set to true for a bar chart by default.
        /// </summary>
        abstract member offset: bool with get, set
        abstract member grid: LinearScaleOptions.grid with get, set
        abstract member border: ChartJs.BorderOptions with get, set
        /// <summary>
        /// Options for the scale title.
        /// </summary>
        abstract member title: CartesianScaleOptions.title with get, set
        /// <summary>
        /// If true, data will be comprised between datasets of data
        /// </summary>
        abstract member stacked: LinearScaleOptions.stacked option with get, set
        abstract member ticks: obj with get, set
        /// <summary>
        /// Controls the axis global visibility (visible when true, hidden when false). When display: 'auto', the axis is visible only if at least one associated dataset is visible.
        /// </summary>
        abstract member display: LinearScaleOptions.display with get, set
        /// <summary>
        /// Align pixel values to device pixels
        /// </summary>
        abstract member alignToPixels: bool with get, set
        /// <summary>
        /// Background color of the scale area.
        /// </summary>
        abstract member backgroundColor: ChartJs.Color with get, set
        /// <summary>
        /// Reverse the scale.
        /// </summary>
        abstract member reverse: bool with get, set
        /// <summary>
        /// Clip the dataset drawing against the size of the scale instead of chart area.
        /// </summary>
        abstract member clip: bool with get, set
        /// <summary>
        /// The weight used to sort the axis. Higher weights are further away from the chart area.
        /// </summary>
        abstract member weight: float with get, set
        abstract member suggestedMin: float option with get, set
        abstract member suggestedMax: float option with get, set
        /// <summary>
        /// Callback called before the update process starts.
        /// </summary>
        abstract member beforeUpdate: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs before dimensions are set.
        /// </summary>
        abstract member beforeSetDimensions: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs after dimensions are set.
        /// </summary>
        abstract member afterSetDimensions: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs before data limits are determined.
        /// </summary>
        abstract member beforeDataLimits: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs after data limits are determined.
        /// </summary>
        abstract member afterDataLimits: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs before ticks are created.
        /// </summary>
        abstract member beforeBuildTicks: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs after ticks are created. Useful for filtering ticks.
        /// </summary>
        abstract member afterBuildTicks: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs before ticks are converted into strings.
        /// </summary>
        abstract member beforeTickToLabelConversion: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs after ticks are converted into strings.
        /// </summary>
        abstract member afterTickToLabelConversion: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs before tick rotation is determined.
        /// </summary>
        abstract member beforeCalculateLabelRotation: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs after tick rotation is determined.
        /// </summary>
        abstract member afterCalculateLabelRotation: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs before the scale fits to the canvas.
        /// </summary>
        abstract member beforeFit: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs after the scale fits to the canvas.
        /// </summary>
        abstract member afterFit: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs at the end of the update process.
        /// </summary>
        abstract member afterUpdate: axis: ChartJs.Scale -> unit
        /// <summary>
        /// if true, scale will include 0 if it is not already included.
        /// </summary>
        abstract member beginAtZero: bool with get, set
        /// <summary>
        /// Percentage (string ending with %) or amount (number) for added room in the scale range above and below data.
        /// </summary>
        abstract member grace: U2<string, float> option with get, set

    type LinearScale<'O> =
        ChartJs.Scale<'O>

    [<AllowNullLiteral>]
    [<Interface>]
    type LogarithmicScaleOptions =
        /// <summary>
        /// Scale boundary strategy (bypassed by min/max time options)
        /// - <c>data</c>: make sure data are fully visible, ticks outside are removed
        /// - <c>ticks</c>: make sure ticks are fully visible, data outside are truncated
        /// </summary>
        abstract member bounds: LogarithmicScaleOptions.bounds with get, set
        /// <summary>
        /// Position of the axis.
        /// </summary>
        abstract member position: LogarithmicScaleOptions.position with get, set
        /// <summary>
        /// Stack group. Axes at the same <c>position</c> with same <c>stack</c> are stacked.
        /// </summary>
        abstract member stack: string option with get, set
        /// <summary>
        /// Weight of the scale in stack group. Used to determine the amount of allocated space for the scale within the group.
        /// </summary>
        abstract member stackWeight: float option with get, set
        /// <summary>
        /// Which type of axis this is. Possible values are: 'x', 'y', 'r'. If not set, this is inferred from the first character of the ID which should be 'x', 'y' or 'r'.
        /// </summary>
        abstract member axis: LogarithmicScaleOptions.axis with get, set
        /// <summary>
        /// User defined minimum value for the scale, overrides minimum value from data.
        /// </summary>
        abstract member min: float with get, set
        /// <summary>
        /// User defined maximum value for the scale, overrides maximum value from data.
        /// </summary>
        abstract member max: float with get, set
        /// <summary>
        /// If true, extra space is added to the both edges and the axis is scaled to fit into the chart area. This is set to true for a bar chart by default.
        /// </summary>
        abstract member offset: bool with get, set
        abstract member grid: LogarithmicScaleOptions.grid with get, set
        abstract member border: ChartJs.BorderOptions with get, set
        /// <summary>
        /// Options for the scale title.
        /// </summary>
        abstract member title: CartesianScaleOptions.title with get, set
        /// <summary>
        /// If true, data will be comprised between datasets of data
        /// </summary>
        abstract member stacked: LogarithmicScaleOptions.stacked option with get, set
        abstract member ticks: obj with get, set
        /// <summary>
        /// Controls the axis global visibility (visible when true, hidden when false). When display: 'auto', the axis is visible only if at least one associated dataset is visible.
        /// </summary>
        abstract member display: LogarithmicScaleOptions.display with get, set
        /// <summary>
        /// Align pixel values to device pixels
        /// </summary>
        abstract member alignToPixels: bool with get, set
        /// <summary>
        /// Background color of the scale area.
        /// </summary>
        abstract member backgroundColor: ChartJs.Color with get, set
        /// <summary>
        /// Reverse the scale.
        /// </summary>
        abstract member reverse: bool with get, set
        /// <summary>
        /// Clip the dataset drawing against the size of the scale instead of chart area.
        /// </summary>
        abstract member clip: bool with get, set
        /// <summary>
        /// The weight used to sort the axis. Higher weights are further away from the chart area.
        /// </summary>
        abstract member weight: float with get, set
        abstract member suggestedMin: float option with get, set
        abstract member suggestedMax: float option with get, set
        /// <summary>
        /// Callback called before the update process starts.
        /// </summary>
        abstract member beforeUpdate: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs before dimensions are set.
        /// </summary>
        abstract member beforeSetDimensions: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs after dimensions are set.
        /// </summary>
        abstract member afterSetDimensions: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs before data limits are determined.
        /// </summary>
        abstract member beforeDataLimits: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs after data limits are determined.
        /// </summary>
        abstract member afterDataLimits: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs before ticks are created.
        /// </summary>
        abstract member beforeBuildTicks: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs after ticks are created. Useful for filtering ticks.
        /// </summary>
        abstract member afterBuildTicks: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs before ticks are converted into strings.
        /// </summary>
        abstract member beforeTickToLabelConversion: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs after ticks are converted into strings.
        /// </summary>
        abstract member afterTickToLabelConversion: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs before tick rotation is determined.
        /// </summary>
        abstract member beforeCalculateLabelRotation: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs after tick rotation is determined.
        /// </summary>
        abstract member afterCalculateLabelRotation: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs before the scale fits to the canvas.
        /// </summary>
        abstract member beforeFit: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs after the scale fits to the canvas.
        /// </summary>
        abstract member afterFit: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs at the end of the update process.
        /// </summary>
        abstract member afterUpdate: axis: ChartJs.Scale -> unit

    type LogarithmicScale<'O> =
        ChartJs.Scale<'O>

    [<AllowNullLiteral>]
    [<Interface>]
    type TimeScaleTimeOptions =
        /// <summary>
        /// Custom parser for dates.
        /// </summary>
        abstract member parser: U2<string, (obj -> float)> with get, set
        /// <summary>
        /// If defined, dates will be rounded to the start of this unit. See Time Units below for the allowed units.
        /// </summary>
        abstract member round: TimeScaleTimeOptions.round with get, set
        /// <summary>
        /// If boolean and true and the unit is set to 'week', then the first day of the week will be Monday. Otherwise, it will be Sunday.
        /// If <c>number</c>, the index of the first day of the week (0 - Sunday, 6 - Saturday).
        /// </summary>
        abstract member isoWeekday: U2<bool, float> with get, set
        /// <summary>
        /// Sets how different time units are displayed.
        /// </summary>
        abstract member displayFormats: TimeScaleTimeOptions.displayFormats with get, set
        /// <summary>
        /// The format string to use for the tooltip.
        /// </summary>
        abstract member tooltipFormat: string with get, set
        /// <summary>
        /// If defined, will force the unit to be a certain type. See Time Units section below for details.
        /// </summary>
        abstract member unit: TimeScaleTimeOptions.unit with get, set
        /// <summary>
        /// The minimum display format to be used for a time unit.
        /// </summary>
        abstract member minUnit: ChartJs.TimeUnit with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type TimeScaleTickOptions =
        /// <summary>
        /// Ticks generation input values:
        /// - 'auto': generates "optimal" ticks based on scale size and time options.
        /// - 'data': generates ticks from data (including labels from data <c>{t|x|y}</c> objects).
        /// - 'labels': generates ticks from user given <c>data.labels</c> values ONLY.
        /// </summary>
        abstract member source: TimeScaleTickOptions.source with get, set
        /// <summary>
        /// The number of units between grid lines.
        /// </summary>
        abstract member stepSize: float with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type TimeScaleOptions =
        /// <summary>
        /// Clip the dataset drawing against the size of the scale instead of chart area.
        /// </summary>
        abstract member clip: bool with get, set
        /// <summary>
        /// Background color of the scale area.
        /// </summary>
        abstract member backgroundColor: ChartJs.Color with get, set
        /// <summary>
        /// Stack group. Axes at the same <c>position</c> with same <c>stack</c> are stacked.
        /// </summary>
        abstract member stack: string option with get, set
        abstract member bounds: TimeScaleOptions.bounds with get, set
        /// <summary>
        /// Position of the axis.
        /// </summary>
        abstract member position: TimeScaleOptions.position with get, set
        /// <summary>
        /// Weight of the scale in stack group. Used to determine the amount of allocated space for the scale within the group.
        /// </summary>
        abstract member stackWeight: float option with get, set
        /// <summary>
        /// Which type of axis this is. Possible values are: 'x', 'y', 'r'. If not set, this is inferred from the first character of the ID which should be 'x', 'y' or 'r'.
        /// </summary>
        abstract member axis: TimeScaleOptions.axis with get, set
        /// <summary>
        /// If true, extra space is added to the both edges and the axis is scaled to fit into the chart area. This is set to true for a bar chart by default.
        /// </summary>
        abstract member offset: bool with get, set
        abstract member grid: TimeScaleOptions.grid with get, set
        abstract member border: ChartJs.BorderOptions with get, set
        /// <summary>
        /// Options for the scale title.
        /// </summary>
        abstract member title: CartesianScaleOptions.title with get, set
        /// <summary>
        /// If true, data will be comprised between datasets of data
        /// </summary>
        abstract member stacked: TimeScaleOptions.stacked option with get, set
        abstract member ticks: obj with get, set
        /// <summary>
        /// Controls the axis global visibility (visible when true, hidden when false). When display: 'auto', the axis is visible only if at least one associated dataset is visible.
        /// </summary>
        abstract member display: TimeScaleOptions.display with get, set
        /// <summary>
        /// Align pixel values to device pixels
        /// </summary>
        abstract member alignToPixels: bool with get, set
        /// <summary>
        /// Reverse the scale.
        /// </summary>
        abstract member reverse: bool with get, set
        /// <summary>
        /// The weight used to sort the axis. Higher weights are further away from the chart area.
        /// </summary>
        abstract member weight: float with get, set
        abstract member suggestedMin: U2<string, float> with get, set
        abstract member suggestedMax: U2<string, float> with get, set
        /// <summary>
        /// Callback called before the update process starts.
        /// </summary>
        abstract member beforeUpdate: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs before dimensions are set.
        /// </summary>
        abstract member beforeSetDimensions: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs after dimensions are set.
        /// </summary>
        abstract member afterSetDimensions: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs before data limits are determined.
        /// </summary>
        abstract member beforeDataLimits: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs after data limits are determined.
        /// </summary>
        abstract member afterDataLimits: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs before ticks are created.
        /// </summary>
        abstract member beforeBuildTicks: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs after ticks are created. Useful for filtering ticks.
        /// </summary>
        abstract member afterBuildTicks: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs before ticks are converted into strings.
        /// </summary>
        abstract member beforeTickToLabelConversion: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs after ticks are converted into strings.
        /// </summary>
        abstract member afterTickToLabelConversion: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs before tick rotation is determined.
        /// </summary>
        abstract member beforeCalculateLabelRotation: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs after tick rotation is determined.
        /// </summary>
        abstract member afterCalculateLabelRotation: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs before the scale fits to the canvas.
        /// </summary>
        abstract member beforeFit: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs after the scale fits to the canvas.
        /// </summary>
        abstract member afterFit: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs at the end of the update process.
        /// </summary>
        abstract member afterUpdate: axis: ChartJs.Scale -> unit
        abstract member min: U2<string, float> with get, set
        abstract member max: U2<string, float> with get, set
        /// <summary>
        /// If true, bar chart offsets are computed with skipped tick sizes
        /// </summary>
        abstract member offsetAfterAutoskip: bool with get, set
        /// <summary>
        /// options for creating a new adapter instance
        /// </summary>
        abstract member adapters: TimeScaleOptions.adapters with get, set
        abstract member time: ChartJs.TimeScaleTimeOptions with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type TimeScale<'O> =
        inherit ChartJs.Scale<'O>
        abstract member format: value: float * ?format: string -> string
        abstract member getDataTimestamps: unit -> ResizeArray<float>
        abstract member getLabelTimestamps: unit -> ResizeArray<string>
        abstract member normalize: values: ResizeArray<float> -> ResizeArray<float>

    type TimeSeriesScale<'O> =
        ChartJs.TimeScale<'O>

    [<AllowNullLiteral>]
    [<Interface>]
    type RadialTickOptions =
        /// <summary>
        /// Color of label backdrops.
        /// </summary>
        abstract member backdropColor: ChartJs.Scriptable<ChartJs.Color, ChartJs.ScriptableScaleContext> with get, set
        /// <summary>
        /// Padding of tick backdrop.
        /// </summary>
        abstract member backdropPadding: U2<float, ChartJs.ChartArea> with get, set
        /// <summary>
        /// Returns the string representation of the tick value as it should be displayed on the chart. See callback.
        /// </summary>
        abstract member callback: RadialTickOptions.callback with get, set
        /// <summary>
        /// If true, show tick labels.
        /// </summary>
        abstract member display: bool with get, set
        /// <summary>
        /// Color of tick
        /// </summary>
        abstract member color: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableScaleContext> with get, set
        /// <summary>
        /// see Fonts
        /// </summary>
        abstract member font: ChartJs.ScriptableAndScriptableOptions<RadialTickOptions.font, ChartJs.ScriptableScaleContext> with get, set
        /// <summary>
        /// Sets the offset of the tick labels from the axis
        /// </summary>
        abstract member padding: float with get, set
        /// <summary>
        /// If true, draw a background behind the tick labels.
        /// </summary>
        abstract member showLabelBackdrop: ChartJs.Scriptable<bool, ChartJs.ScriptableScaleContext> with get, set
        /// <summary>
        /// The color of the stroke around the text.
        /// </summary>
        abstract member textStrokeColor: ChartJs.Scriptable<ChartJs.Color, ChartJs.ScriptableScaleContext> with get, set
        /// <summary>
        /// Stroke width around the text.
        /// </summary>
        abstract member textStrokeWidth: ChartJs.Scriptable<float, ChartJs.ScriptableScaleContext> with get, set
        /// <summary>
        /// z-index of tick layer. Useful when ticks are drawn on chart area. Values <= 0 are drawn under datasets, > 0 on top.
        /// </summary>
        abstract member z: float with get, set
        abstract member major: TickOptions.major with get, set
        /// <summary>
        /// The Intl.NumberFormat options used by the default label formatter
        /// </summary>
        abstract member format: obj with get, set
        /// <summary>
        /// Maximum number of ticks and gridlines to show.
        /// </summary>
        abstract member maxTicksLimit: float with get, set
        /// <summary>
        /// if defined and stepSize is not specified, the step size will be rounded to this many decimal places.
        /// </summary>
        abstract member precision: float with get, set
        /// <summary>
        /// User defined fixed step size for the scale.
        /// </summary>
        abstract member stepSize: float with get, set
        /// <summary>
        /// User defined number of ticks
        /// </summary>
        abstract member count: float with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type RadialLinearScaleOptions =
        /// <summary>
        /// Controls the axis global visibility (visible when true, hidden when false). When display: 'auto', the axis is visible only if at least one associated dataset is visible.
        /// </summary>
        abstract member display: RadialLinearScaleOptions.display with get, set
        /// <summary>
        /// Align pixel values to device pixels
        /// </summary>
        abstract member alignToPixels: bool with get, set
        /// <summary>
        /// Background color of the scale area.
        /// </summary>
        abstract member backgroundColor: ChartJs.Color with get, set
        /// <summary>
        /// Reverse the scale.
        /// </summary>
        abstract member reverse: bool with get, set
        /// <summary>
        /// Clip the dataset drawing against the size of the scale instead of chart area.
        /// </summary>
        abstract member clip: bool with get, set
        /// <summary>
        /// The weight used to sort the axis. Higher weights are further away from the chart area.
        /// </summary>
        abstract member weight: float with get, set
        abstract member min: float with get, set
        abstract member max: float with get, set
        abstract member suggestedMin: float with get, set
        abstract member suggestedMax: float with get, set
        /// <summary>
        /// Callback called before the update process starts.
        /// </summary>
        abstract member beforeUpdate: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs before dimensions are set.
        /// </summary>
        abstract member beforeSetDimensions: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs after dimensions are set.
        /// </summary>
        abstract member afterSetDimensions: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs before data limits are determined.
        /// </summary>
        abstract member beforeDataLimits: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs after data limits are determined.
        /// </summary>
        abstract member afterDataLimits: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs before ticks are created.
        /// </summary>
        abstract member beforeBuildTicks: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs after ticks are created. Useful for filtering ticks.
        /// </summary>
        abstract member afterBuildTicks: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs before ticks are converted into strings.
        /// </summary>
        abstract member beforeTickToLabelConversion: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs after ticks are converted into strings.
        /// </summary>
        abstract member afterTickToLabelConversion: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs before tick rotation is determined.
        /// </summary>
        abstract member beforeCalculateLabelRotation: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs after tick rotation is determined.
        /// </summary>
        abstract member afterCalculateLabelRotation: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs before the scale fits to the canvas.
        /// </summary>
        abstract member beforeFit: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs after the scale fits to the canvas.
        /// </summary>
        abstract member afterFit: axis: ChartJs.Scale -> unit
        /// <summary>
        /// Callback that runs at the end of the update process.
        /// </summary>
        abstract member afterUpdate: axis: ChartJs.Scale -> unit
        abstract member animate: bool with get, set
        abstract member startAngle: float with get, set
        abstract member angleLines: RadialLinearScaleOptions.angleLines with get, set
        /// <summary>
        /// if true, scale will include 0 if it is not already included.
        /// </summary>
        abstract member beginAtZero: bool with get, set
        abstract member grid: RadialLinearScaleOptions.grid with get, set
        abstract member pointLabels: RadialLinearScaleOptions.pointLabels with get, set
        abstract member ticks: ChartJs.RadialTickOptions with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type RadialLinearScale<'O> =
        inherit ChartJs.Scale<'O>
        abstract member xCenter: float with get, set
        abstract member yCenter: float with get, set
        abstract member drawingArea: float with get
        abstract member setCenterPoint: leftMovement: float * rightMovement: float * topMovement: float * bottomMovement: float -> unit
        abstract member getIndexAngle: index: float -> float
        abstract member getDistanceFromCenterForValue: value: float -> float
        abstract member getValueForDistanceFromCenter: distance: float -> float
        abstract member getPointPosition: index: float * distanceFromCenter: float -> RadialLinearScale.getPointPosition
        abstract member getPointPositionForValue: index: float * value: float -> RadialLinearScale.getPointPositionForValue
        abstract member getPointLabelPosition: index: float -> ChartJs.ChartArea
        abstract member getBasePosition: index: float -> RadialLinearScale.getBasePosition

    [<AllowNullLiteral>]
    [<Interface>]
    type CartesianScaleTypeRegistry =
        abstract member linear: CartesianScaleTypeRegistry.linear with get, set
        abstract member logarithmic: CartesianScaleTypeRegistry.logarithmic with get, set
        abstract member category: CartesianScaleTypeRegistry.category with get, set
        abstract member time: CartesianScaleTypeRegistry.time with get, set
        abstract member timeseries: CartesianScaleTypeRegistry.timeseries with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type RadialScaleTypeRegistry =
        abstract member radialLinear: RadialScaleTypeRegistry.radialLinear with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type ScaleTypeRegistry =
        inherit ChartJs.CartesianScaleTypeRegistry
        inherit ChartJs.RadialScaleTypeRegistry

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type ScaleType =
        | linear
        | logarithmic
        | category
        | time
        | timeseries
        | radialLinear

    [<AllowNullLiteral>]
    [<Interface>]
    type CartesianParsedData =
        inherit ChartJs.Point
        abstract member _stacks: CartesianParsedData._stacks option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type BarParsedData =
        inherit ChartJs.CartesianParsedData
        abstract member _custom: BarParsedData._custom option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type BubbleParsedData =
        inherit ChartJs.CartesianParsedData
        abstract member _custom: float with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type RadialParsedData =
        abstract member r: float with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type ChartTypeRegistry =
        abstract member bar: ChartTypeRegistry.bar with get, set
        abstract member line: ChartTypeRegistry.line with get, set
        abstract member scatter: ChartTypeRegistry.scatter with get, set
        abstract member bubble: ChartTypeRegistry.bubble with get, set
        abstract member pie: ChartTypeRegistry.pie with get, set
        abstract member doughnut: ChartTypeRegistry.doughnut with get, set
        abstract member polarArea: ChartTypeRegistry.polarArea with get, set
        abstract member radar: ChartTypeRegistry.radar with get, set

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type ChartType =
        | bar
        | line
        | scatter
        | bubble
        | pie
        | doughnut
        | polarArea
        | radar

    [<AllowNullLiteral>]
    [<Interface>]
    type ScaleOptionsByType<'TScale> =
        interface end

    [<AllowNullLiteral>]
    [<Interface>]
    type ScaleOptions<'TScale> =
        interface end

    [<AllowNullLiteral>]
    [<Interface>]
    type DatasetChartOptions<'TType> =
        [<EmitIndexer>]
        abstract member Item: key: string -> DatasetChartOptions.Item with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type ScaleChartOptions<'TType> =
        abstract member scales: ScaleChartOptions.scales with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type ChartOptions<'TType> =
        interface end

    [<AllowNullLiteral>]
    [<Interface>]
    type DefaultDataPoint<'TType> =
        interface end

    [<AllowNullLiteral>]
    [<Interface>]
    type ParsedDataType<'TType> =
        interface end

    [<AllowNullLiteral>]
    [<Interface>]
    type ChartDatasetProperties<'TType, 'TData> =
        abstract member ``type``: 'TType option with get, set
        abstract member data: 'TData with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type ChartDatasetPropertiesCustomTypesPerDataset<'TType, 'TData> =
        abstract member ``type``: 'TType with get, set
        abstract member data: 'TData with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type ChartDataset<'TType, 'TData> =
        abstract member ``type``: obj option with get, set
        abstract member indexAxis: ChartDataset.indexAxis option with get, set
        abstract member clip: U3<float, bool, ChartJs._DeepPartialObject<ChartJs.ChartArea>> option with get, set
        abstract member label: string option with get, set
        abstract member order: float option with get, set
        abstract member stack: string option with get, set
        abstract member hidden: bool option with get, set
        abstract member parsing: U2<bool, ChartJs._DeepPartialObject<ChartDataset.parsing.U2.Case2>> option with get, set
        abstract member normalized: bool option with get, set
        abstract member borderWidth: U9<float, ChartDataset.borderWidth.U9.Case2, ChartDataset.borderWidth.U9.Case3, ChartDataset.borderWidth.U9.Case4, ChartDataset.borderWidth.U9.Case5, ChartDataset.borderWidth.U9.Case6, ReadonlyArray<float option>, ChartJs._DeepPartialObject<ChartDataset.borderWidth.U9.Case8>, ReadonlyArray<U2<float, ChartJs._DeepPartialObject<ChartDataset.borderWidth.U9.Case9.U2.Case2>> option>> option with get, set
        abstract member borderColor: U9<string, ChartDataset.borderColor.U9.Case2, ChartDataset.borderColor.U9.Case3, ChartDataset.borderColor.U9.Case4, ChartDataset.borderColor.U9.Case5, ChartDataset.borderColor.U9.Case6, ChartJs._DeepPartialObject<Glutinum.Web.CanvasGradient>, ChartJs._DeepPartialObject<Glutinum.Web.CanvasPattern>, ReadonlyArray<U3<string, ChartJs._DeepPartialObject<Glutinum.Web.CanvasGradient>, ChartJs._DeepPartialObject<Glutinum.Web.CanvasPattern>> option>> option with get, set
        abstract member backgroundColor: U9<string, ChartDataset.backgroundColor.U9.Case2, ChartDataset.backgroundColor.U9.Case3, ChartDataset.backgroundColor.U9.Case4, ChartDataset.backgroundColor.U9.Case5, ChartDataset.backgroundColor.U9.Case6, ChartJs._DeepPartialObject<Glutinum.Web.CanvasGradient>, ChartJs._DeepPartialObject<Glutinum.Web.CanvasPattern>, ReadonlyArray<U3<string, ChartJs._DeepPartialObject<Glutinum.Web.CanvasGradient>, ChartJs._DeepPartialObject<Glutinum.Web.CanvasPattern>> option>> option with get, set
        abstract member hoverBorderWidth: U7<float, ChartDataset.hoverBorderWidth.U7.Case2, ChartDataset.hoverBorderWidth.U7.Case3, ChartDataset.hoverBorderWidth.U7.Case4, ChartDataset.hoverBorderWidth.U7.Case5, ChartDataset.hoverBorderWidth.U7.Case6, ReadonlyArray<float option>> option with get, set
        abstract member hoverBorderColor: U9<string, ChartDataset.hoverBorderColor.U9.Case2, ChartDataset.hoverBorderColor.U9.Case3, ChartDataset.hoverBorderColor.U9.Case4, ChartDataset.hoverBorderColor.U9.Case5, ChartDataset.hoverBorderColor.U9.Case6, ChartJs._DeepPartialObject<Glutinum.Web.CanvasGradient>, ChartJs._DeepPartialObject<Glutinum.Web.CanvasPattern>, ReadonlyArray<U3<string, ChartJs._DeepPartialObject<Glutinum.Web.CanvasGradient>, ChartJs._DeepPartialObject<Glutinum.Web.CanvasPattern>> option>> option with get, set
        abstract member hoverBackgroundColor: U9<string, ChartDataset.hoverBackgroundColor.U9.Case2, ChartDataset.hoverBackgroundColor.U9.Case3, ChartDataset.hoverBackgroundColor.U9.Case4, ChartDataset.hoverBackgroundColor.U9.Case5, ChartDataset.hoverBackgroundColor.U9.Case6, ChartJs._DeepPartialObject<Glutinum.Web.CanvasGradient>, ChartJs._DeepPartialObject<Glutinum.Web.CanvasPattern>, ReadonlyArray<U3<string, ChartJs._DeepPartialObject<Glutinum.Web.CanvasGradient>, ChartJs._DeepPartialObject<Glutinum.Web.CanvasPattern>> option>> option with get, set
        abstract member tooltip: ChartJs._DeepPartialObject<ChartJs.TooltipDatasetOptions<'TType>> option with get, set
        abstract member data: 'TData with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type ChartDatasetCustomTypesPerDataset<'TType, 'TData> =
        abstract member ``type``: obj with get, set
        abstract member indexAxis: ChartDatasetCustomTypesPerDataset.indexAxis option with get, set
        abstract member clip: U3<float, bool, ChartJs._DeepPartialObject<ChartJs.ChartArea>> option with get, set
        abstract member label: string option with get, set
        abstract member order: float option with get, set
        abstract member stack: string option with get, set
        abstract member hidden: bool option with get, set
        abstract member parsing: U2<bool, ChartJs._DeepPartialObject<ChartDatasetCustomTypesPerDataset.parsing.U2.Case2>> option with get, set
        abstract member normalized: bool option with get, set
        abstract member borderWidth: U9<float, ChartDatasetCustomTypesPerDataset.borderWidth.U9.Case2, ChartDatasetCustomTypesPerDataset.borderWidth.U9.Case3, ChartDatasetCustomTypesPerDataset.borderWidth.U9.Case4, ChartDatasetCustomTypesPerDataset.borderWidth.U9.Case5, ChartDatasetCustomTypesPerDataset.borderWidth.U9.Case6, ReadonlyArray<float option>, ChartJs._DeepPartialObject<ChartDatasetCustomTypesPerDataset.borderWidth.U9.Case8>, ReadonlyArray<U2<float, ChartJs._DeepPartialObject<ChartDatasetCustomTypesPerDataset.borderWidth.U9.Case9.U2.Case2>> option>> option with get, set
        abstract member borderColor: U9<string, ChartDatasetCustomTypesPerDataset.borderColor.U9.Case2, ChartDatasetCustomTypesPerDataset.borderColor.U9.Case3, ChartDatasetCustomTypesPerDataset.borderColor.U9.Case4, ChartDatasetCustomTypesPerDataset.borderColor.U9.Case5, ChartDatasetCustomTypesPerDataset.borderColor.U9.Case6, ChartJs._DeepPartialObject<Glutinum.Web.CanvasGradient>, ChartJs._DeepPartialObject<Glutinum.Web.CanvasPattern>, ReadonlyArray<U3<string, ChartJs._DeepPartialObject<Glutinum.Web.CanvasGradient>, ChartJs._DeepPartialObject<Glutinum.Web.CanvasPattern>> option>> option with get, set
        abstract member backgroundColor: U9<string, ChartDatasetCustomTypesPerDataset.backgroundColor.U9.Case2, ChartDatasetCustomTypesPerDataset.backgroundColor.U9.Case3, ChartDatasetCustomTypesPerDataset.backgroundColor.U9.Case4, ChartDatasetCustomTypesPerDataset.backgroundColor.U9.Case5, ChartDatasetCustomTypesPerDataset.backgroundColor.U9.Case6, ChartJs._DeepPartialObject<Glutinum.Web.CanvasGradient>, ChartJs._DeepPartialObject<Glutinum.Web.CanvasPattern>, ReadonlyArray<U3<string, ChartJs._DeepPartialObject<Glutinum.Web.CanvasGradient>, ChartJs._DeepPartialObject<Glutinum.Web.CanvasPattern>> option>> option with get, set
        abstract member hoverBorderWidth: U7<float, ChartDatasetCustomTypesPerDataset.hoverBorderWidth.U7.Case2, ChartDatasetCustomTypesPerDataset.hoverBorderWidth.U7.Case3, ChartDatasetCustomTypesPerDataset.hoverBorderWidth.U7.Case4, ChartDatasetCustomTypesPerDataset.hoverBorderWidth.U7.Case5, ChartDatasetCustomTypesPerDataset.hoverBorderWidth.U7.Case6, ReadonlyArray<float option>> option with get, set
        abstract member hoverBorderColor: U9<string, ChartDatasetCustomTypesPerDataset.hoverBorderColor.U9.Case2, ChartDatasetCustomTypesPerDataset.hoverBorderColor.U9.Case3, ChartDatasetCustomTypesPerDataset.hoverBorderColor.U9.Case4, ChartDatasetCustomTypesPerDataset.hoverBorderColor.U9.Case5, ChartDatasetCustomTypesPerDataset.hoverBorderColor.U9.Case6, ChartJs._DeepPartialObject<Glutinum.Web.CanvasGradient>, ChartJs._DeepPartialObject<Glutinum.Web.CanvasPattern>, ReadonlyArray<U3<string, ChartJs._DeepPartialObject<Glutinum.Web.CanvasGradient>, ChartJs._DeepPartialObject<Glutinum.Web.CanvasPattern>> option>> option with get, set
        abstract member hoverBackgroundColor: U9<string, ChartDatasetCustomTypesPerDataset.hoverBackgroundColor.U9.Case2, ChartDatasetCustomTypesPerDataset.hoverBackgroundColor.U9.Case3, ChartDatasetCustomTypesPerDataset.hoverBackgroundColor.U9.Case4, ChartDatasetCustomTypesPerDataset.hoverBackgroundColor.U9.Case5, ChartDatasetCustomTypesPerDataset.hoverBackgroundColor.U9.Case6, ChartJs._DeepPartialObject<Glutinum.Web.CanvasGradient>, ChartJs._DeepPartialObject<Glutinum.Web.CanvasPattern>, ReadonlyArray<U3<string, ChartJs._DeepPartialObject<Glutinum.Web.CanvasGradient>, ChartJs._DeepPartialObject<Glutinum.Web.CanvasPattern>> option>> option with get, set
        abstract member tooltip: ChartJs._DeepPartialObject<ChartJs.TooltipDatasetOptions<'TType>> option with get, set
        abstract member data: 'TData with get, set

    /// <summary>
    /// TData represents the data point type. If unspecified, a default is provided
    ///   based on the chart type.
    /// TLabel represents the label type
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type ChartData<'TType, 'TData, 'TLabel> =
        abstract member labels: ResizeArray<'TLabel> option with get, set
        abstract member xLabels: ResizeArray<'TLabel> option with get, set
        abstract member yLabels: ResizeArray<'TLabel> option with get, set
        abstract member datasets: ResizeArray<ChartJs.ChartDataset<'TType, 'TData>> with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (datasets: ResizeArray<ChartJs.ChartDataset<'TType, 'TData>>, ?labels: ResizeArray<'TLabel>, ?xLabels: ResizeArray<'TLabel>, ?yLabels: ResizeArray<'TLabel>) : ChartData<'TType, 'TData, 'TLabel> = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type ChartDataCustomTypesPerDataset<'TType, 'TData, 'TLabel> =
        abstract member labels: ResizeArray<'TLabel> option with get, set
        abstract member xLabels: ResizeArray<'TLabel> option with get, set
        abstract member yLabels: ResizeArray<'TLabel> option with get, set
        abstract member datasets: ResizeArray<ChartJs.ChartDatasetCustomTypesPerDataset<'TType, 'TData>> with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (datasets: ResizeArray<ChartJs.ChartDatasetCustomTypesPerDataset<'TType, 'TData>>, ?labels: ResizeArray<'TLabel>, ?xLabels: ResizeArray<'TLabel>, ?yLabels: ResizeArray<'TLabel>) : ChartDataCustomTypesPerDataset<'TType, 'TData, 'TLabel> = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type ChartConfiguration<'TType, 'TData, 'TLabel> =
        abstract member ``type``: 'TType with get, set
        abstract member data: ChartJs.ChartData<'TType, 'TData, 'TLabel> with get, set
        abstract member options: ChartJs.ChartOptions<'TType> option with get, set
        abstract member plugins: ResizeArray<ChartJs.Plugin<'TType>> option with get, set
        abstract member platform: ChartJs.BasePlatform option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (``type``: 'TType, data: ChartJs.ChartData<'TType, 'TData, 'TLabel>, ?options: ChartJs.ChartOptions<'TType>, ?plugins: ResizeArray<ChartJs.Plugin<'TType>>, ?platform: ChartJs.BasePlatform) : ChartConfiguration<'TType, 'TData, 'TLabel> = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type ChartConfigurationCustomTypesPerDataset<'TType, 'TData, 'TLabel> =
        abstract member data: ChartJs.ChartDataCustomTypesPerDataset<'TType, 'TData, 'TLabel> with get, set
        abstract member options: ChartJs.ChartOptions<'TType> option with get, set
        abstract member plugins: ResizeArray<ChartJs.Plugin<'TType>> option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (data: ChartJs.ChartDataCustomTypesPerDataset<'TType, 'TData, 'TLabel>, ?options: ChartJs.ChartOptions<'TType>, ?plugins: ResizeArray<ChartJs.Plugin<'TType>>) : ChartConfigurationCustomTypesPerDataset<'TType, 'TData, 'TLabel> = nativeOnly

    [<RequireQualifiedAccess>]
    [<Erase(CaseRules.None)>]
    type LayoutPosition =
        | left
        | top
        | right
        | bottom
        | center
        | chartArea
        | Case1 of LayoutPosition.Cases.Case1

        [<Emit("$0")>]
        static member op_Implicit(value: LayoutPosition.Cases.Case1) : LayoutPosition = nativeOnly

        [<Emit("$0")>]
        static member op_ErasedCast(value: LayoutPosition.Cases.Case1) : LayoutPosition = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type LayoutItem =
        /// <summary>
        /// The position of the item in the chart layout. Possible values are
        /// </summary>
        abstract member position: ChartJs.LayoutPosition with get, set
        /// <summary>
        /// The weight used to sort the item. Higher weights are further away from the chart area
        /// </summary>
        abstract member weight: float with get, set
        /// <summary>
        /// if true, and the item is horizontal, then push vertical boxes down
        /// </summary>
        abstract member fullSize: bool with get, set
        /// <summary>
        /// Width of item. Must be valid after update()
        /// </summary>
        abstract member width: float with get, set
        /// <summary>
        /// Height of item. Must be valid after update()
        /// </summary>
        abstract member height: float with get, set
        /// <summary>
        /// Left edge of the item. Set by layout system and cannot be used in update
        /// </summary>
        abstract member left: float with get, set
        /// <summary>
        /// Top edge of the item. Set by layout system and cannot be used in update
        /// </summary>
        abstract member top: float with get, set
        /// <summary>
        /// Right edge of the item. Set by layout system and cannot be used in update
        /// </summary>
        abstract member right: float with get, set
        /// <summary>
        /// Bottom edge of the item. Set by layout system and cannot be used in update
        /// </summary>
        abstract member bottom: float with get, set
        /// <summary>
        /// Called before the layout process starts
        /// </summary>
        abstract member beforeLayout: (unit -> unit) option with get, set
        /// <summary>
        /// Draws the element
        /// </summary>
        abstract member draw: chartArea: ChartJs.ChartArea -> unit
        /// <summary>
        /// Returns an object with padding on the edges
        /// </summary>
        abstract member getPadding: (unit -> ChartJs.ChartArea) option with get, set
        /// <summary>
        /// returns true if the layout item is horizontal (ie. top or bottom)
        /// </summary>
        abstract member isHorizontal: unit -> bool
        /// <summary>
        /// Takes two parameters: width and height.
        /// </summary>
        /// <param name="width">
        ///
        /// </param>
        /// <param name="height">
        ///
        /// </param>
        abstract member update: width: float * height: float * ?margins: ChartJs.ChartArea -> unit

    [<AllowNullLiteral>]
    [<Interface>]
    type DeepPartial<'T> =
        interface end

    [<AllowNullLiteral>]
    [<Interface>]
    type _DeepPartialArray<'T> =
        interface end

    [<AllowNullLiteral>]
    [<Interface>]
    type _DeepPartialObject<'T> =
        [<EmitIndexer>]
        abstract member Item: key: string -> obj with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type DistributiveArray<'T> =
        interface end

    [<AllowNullLiteral>]
    [<Interface>]
    type UnionToIntersection<'U> =
        interface end

    [<AllowNullLiteral>]
    [<Interface>]
    type AllKeys<'T> =
        interface end

    [<AllowNullLiteral>]
    [<Interface>]
    type PickType<'T, 'K> =
        interface end

    [<AllowNullLiteral>]
    [<Interface>]
    type Merge<'T> =
        [<EmitIndexer>]
        abstract member Item: key: string -> obj with get, set

    module auto =

        [<AbstractClass>]
        [<Erase>]
        type Exports =
            [<Import("BarController", "chart.js/auto")>]
            static member inline BarController: Exports.BarController__.Type = nativeOnly
            [<Import("BubbleController", "chart.js/auto")>]
            static member inline BubbleController: Exports.BubbleController__.Type = nativeOnly
            [<Import("DoughnutController", "chart.js/auto")>]
            static member inline DoughnutController: Exports.DoughnutController__.Type = nativeOnly
            [<Import("LineController", "chart.js/auto")>]
            static member inline LineController: Exports.LineController__.Type = nativeOnly
            [<Import("PieController", "chart.js/auto")>]
            static member inline PieController: Exports.PieController__.Type = nativeOnly
            [<Import("PolarAreaController", "chart.js/auto")>]
            static member inline PolarAreaController: Exports.PolarAreaController__.Type = nativeOnly
            [<Import("RadarController", "chart.js/auto")>]
            static member inline RadarController: Exports.RadarController__.Type = nativeOnly
            [<Import("ScatterController", "chart.js/auto")>]
            static member inline ScatterController: Exports.ScatterController__.Type = nativeOnly
            [<Import("Interaction", "chart.js/auto")>]
            static member inline Interaction: Exports.Interaction__.Type = nativeOnly
            [<Import("Ticks", "chart.js/auto")>]
            static member inline Ticks: Exports.Ticks__.Type = nativeOnly
            [<Import("defaults", "chart.js/auto")>]
            static member inline defaults: ChartJs.Defaults = nativeOnly
            [<Import("layouts", "chart.js/auto")>]
            static member inline layouts: Exports.layouts__.Type = nativeOnly
            [<Import("registry", "chart.js/auto")>]
            static member inline registry: ChartJs.Registry = nativeOnly
            [<Import("BarElement", "chart.js/auto")>]
            static member inline BarElement: Exports.BarElement__.Type = nativeOnly
            [<Import("LineElement", "chart.js/auto")>]
            static member inline LineElement: Exports.LineElement__.Type = nativeOnly
            [<Import("Decimation", "chart.js/auto")>]
            static member inline Decimation: ChartJs.Plugin = nativeOnly
            [<Import("Filler", "chart.js/auto")>]
            static member inline Filler: ChartJs.Plugin = nativeOnly
            [<Import("Legend", "chart.js/auto")>]
            static member inline Legend: ChartJs.Plugin = nativeOnly
            [<Import("SubTitle", "chart.js/auto")>]
            static member inline SubTitle: ChartJs.Plugin = nativeOnly
            [<Import("Title", "chart.js/auto")>]
            static member inline Title: ChartJs.Plugin = nativeOnly
            [<Import("Tooltip", "chart.js/auto")>]
            static member inline Tooltip: ChartJs.Tooltip = nativeOnly
            [<Import("CategoryScale", "chart.js/auto")>]
            static member inline CategoryScale: Exports.CategoryScale__.Type = nativeOnly
            [<Import("LinearScale", "chart.js/auto")>]
            static member inline LinearScale: Exports.LinearScale__.Type = nativeOnly
            [<Import("LogarithmicScale", "chart.js/auto")>]
            static member inline LogarithmicScale: Exports.LogarithmicScale__.Type = nativeOnly
            [<Import("RadialLinearScale", "chart.js/auto")>]
            static member inline RadialLinearScale: Exports.RadialLinearScale__.Type = nativeOnly
            [<Import("TimeScale", "chart.js/auto")>]
            static member inline TimeScale: Exports.TimeScale__.Type = nativeOnly
            [<Import("TimeSeriesScale", "chart.js/auto")>]
            static member inline TimeSeriesScale: Exports.TimeSeriesScale__.Type = nativeOnly
            [<Import("registerables", "chart.js/auto")>]
            static member inline registerables: ReadonlyArray<ChartJs.ChartComponentLike> = nativeOnly
            [<Import("_detectPlatform", "chart.js/auto")>]
            static member _detectPlatform (canvas: obj) : U2<ChartJs.dist.platform.platform_basic.BasicPlatform, ChartJs.dist.platform.platform_dom.DomPlatform> = nativeOnly
            [<Import("Animation", "chart.js/auto"); EmitConstructor>]
            static member Animation (cfg: ChartJs.AnyObject, target: ChartJs.AnyObject, prop: string, ?``to``: obj) : Animation = nativeOnly
            [<Import("Animations", "chart.js/auto"); EmitConstructor>]
            static member Animations (chart: ChartJs.dist.types.Chart, animations: ChartJs.AnyObject) : Animations = nativeOnly
            [<ImportDefault("chart.js/auto"); EmitConstructor>]
            static member Chart<'TType, 'TData, 'TLabel> (item: string, config: ChartJs.ChartConfiguration<'TType, 'TData, 'TLabel>) : Chart<'TType, 'TData, 'TLabel> = nativeOnly
            [<ImportDefault("chart.js/auto"); EmitConstructor>]
            static member Chart<'TType, 'TData, 'TLabel> (item: string, config: ChartJs.ChartConfigurationCustomTypesPerDataset<'TType, 'TData, 'TLabel>) : Chart<'TType, 'TData, 'TLabel> = nativeOnly
            [<ImportDefault("chart.js/auto"); EmitConstructor>]
            static member Chart<'TType, 'TData, 'TLabel> (item: Glutinum.Web.CanvasRenderingContext2D, config: ChartJs.ChartConfiguration<'TType, 'TData, 'TLabel>) : Chart<'TType, 'TData, 'TLabel> = nativeOnly
            [<ImportDefault("chart.js/auto"); EmitConstructor>]
            static member Chart<'TType, 'TData, 'TLabel> (item: Glutinum.Web.CanvasRenderingContext2D, config: ChartJs.ChartConfigurationCustomTypesPerDataset<'TType, 'TData, 'TLabel>) : Chart<'TType, 'TData, 'TLabel> = nativeOnly
            [<ImportDefault("chart.js/auto"); EmitConstructor>]
            static member Chart<'TType, 'TData, 'TLabel> (item: Glutinum.Web.HTMLCanvasElement, config: ChartJs.ChartConfiguration<'TType, 'TData, 'TLabel>) : Chart<'TType, 'TData, 'TLabel> = nativeOnly
            [<ImportDefault("chart.js/auto"); EmitConstructor>]
            static member Chart<'TType, 'TData, 'TLabel> (item: Glutinum.Web.HTMLCanvasElement, config: ChartJs.ChartConfigurationCustomTypesPerDataset<'TType, 'TData, 'TLabel>) : Chart<'TType, 'TData, 'TLabel> = nativeOnly
            [<ImportDefault("chart.js/auto"); EmitConstructor>]
            static member Chart<'TType, 'TData, 'TLabel> (item: Exports.Chart.item, config: ChartJs.ChartConfiguration<'TType, 'TData, 'TLabel>) : Chart<'TType, 'TData, 'TLabel> = nativeOnly
            [<ImportDefault("chart.js/auto"); EmitConstructor>]
            static member Chart<'TType, 'TData, 'TLabel> (item: Exports.Chart.item, config: ChartJs.ChartConfigurationCustomTypesPerDataset<'TType, 'TData, 'TLabel>) : Chart<'TType, 'TData, 'TLabel> = nativeOnly
            [<ImportDefault("chart.js/auto"); EmitConstructor>]
            static member Chart<'TType, 'TData, 'TLabel> (item: obj, config: ChartJs.ChartConfiguration<'TType, 'TData, 'TLabel>) : Chart<'TType, 'TData, 'TLabel> = nativeOnly
            [<ImportDefault("chart.js/auto"); EmitConstructor>]
            static member Chart<'TType, 'TData, 'TLabel> (item: obj, config: ChartJs.ChartConfigurationCustomTypesPerDataset<'TType, 'TData, 'TLabel>) : Chart<'TType, 'TData, 'TLabel> = nativeOnly
            [<ImportDefault("chart.js/auto"); EmitConstructor>]
            static member Chart<'TType, 'TData, 'TLabel> (item: ChartJs.ChartItem, config: U2<ChartJs.ChartConfiguration<'TType, 'TData, 'TLabel>, ChartJs.ChartConfigurationCustomTypesPerDataset<'TType, 'TData, 'TLabel>>) : Chart<'TType, 'TData, 'TLabel> = nativeOnly
            [<Import("DatasetController", "chart.js/auto"); EmitConstructor>]
            static member DatasetController<'TType, 'TElement, 'TDatasetElement, 'TParsedData> (chart: ChartJs.dist.types.Chart, datasetIndex: float) : DatasetController<'TType, 'TElement, 'TDatasetElement, 'TParsedData> = nativeOnly
            [<Import("Scale", "chart.js/auto"); EmitConstructor>]
            static member Scale (cfg: Exports.Scale.cfg) : Scale = nativeOnly
            [<Import("BasePlatform", "chart.js/auto"); EmitConstructor>]
            static member BasePlatform () : BasePlatform = nativeOnly
            [<Import("BasicPlatform", "chart.js/auto"); EmitConstructor>]
            static member BasicPlatform () : BasicPlatform = nativeOnly
            [<Import("DomPlatform", "chart.js/auto"); EmitConstructor>]
            static member DomPlatform () : DomPlatform = nativeOnly
            [<Import("Animator", "chart.js/auto"); EmitConstructor>]
            static member Animator () : Animator = nativeOnly

        type BarController =
            ChartJs.BarController

        type BubbleController =
            ChartJs.BubbleController

        type DoughnutController =
            ChartJs.DoughnutController

        type LineController =
            ChartJs.LineController

        type PieController =
            ChartJs.PieController

        type PolarAreaController =
            ChartJs.PolarAreaController

        type RadarController =
            ChartJs.RadarController

        type ScatterController =
            ChartJs.ScatterController

        type Animation =
            ChartJs.dist.types.animation.Animation

        type Animations =
            ChartJs.Animations

        type Chart<'TType, 'TData, 'TLabel> =
            ChartJs.dist.types.Chart<'TType, 'TData, 'TLabel>

        type Chart<'TType, 'TData> =
            Chart<'TType, 'TData, obj>

        type Chart<'TType> =
            Chart<'TType, ResizeArray<U4<float, ChartJs.Point, float * float, ChartJs.BubbleDataPoint> option>, obj>

        type Chart =
            Chart<ChartJs.ChartType, ResizeArray<U4<float, ChartJs.Point, float * float, ChartJs.BubbleDataPoint> option>, obj>

        type DatasetController<'TType, 'TElement, 'TDatasetElement, 'TParsedData> =
            ChartJs.DatasetController<'TType, 'TElement, 'TDatasetElement, 'TParsedData>

        type DatasetController<'TType, 'TElement, 'TDatasetElement> =
            DatasetController<'TType, 'TElement, 'TDatasetElement, ChartJs.ParsedDataType<'TType>>

        type DatasetController<'TType, 'TElement> =
            DatasetController<'TType, 'TElement, ChartJs.Element, ChartJs.ParsedDataType<'TType>>

        type DatasetController<'TType> =
            DatasetController<'TType, ChartJs.Element, ChartJs.Element, ChartJs.ParsedDataType<'TType>>

        type DatasetController =
            DatasetController<ChartJs.ChartType, ChartJs.Element, ChartJs.Element, ChartJs.ParsedDataType<ChartJs.ChartType>>

        type Scale<'O> =
            ChartJs.Scale<'O>

        type Scale =
            Scale<ChartJs.CoreScaleOptions>

        type BarElement<'T, 'O> =
            ChartJs.BarElement<'T, 'O>

        type BarElement<'T> =
            BarElement<'T, ChartJs.BarOptions>

        type BarElement =
            BarElement<ChartJs.BarProps, ChartJs.BarOptions>

        type LineElement<'T, 'O> =
            ChartJs.LineElement<'T, 'O>

        type LineElement<'T> =
            LineElement<'T, ChartJs.LineOptions>

        type LineElement =
            LineElement<ChartJs.LineProps, ChartJs.LineOptions>

        type BasePlatform =
            ChartJs.BasePlatform

        type BasicPlatform =
            ChartJs.BasicPlatform

        type DomPlatform =
            ChartJs.DomPlatform

        type Tooltip =
            ChartJs.Tooltip

        type CategoryScale<'O> =
            ChartJs.CategoryScale<'O>

        type CategoryScale =
            CategoryScale<ChartJs.CategoryScaleOptions>

        type LinearScale<'O> =
            ChartJs.LinearScale<'O>

        type LinearScale =
            LinearScale<ChartJs.LinearScaleOptions>

        type LogarithmicScale<'O> =
            ChartJs.LogarithmicScale<'O>

        type LogarithmicScale =
            LogarithmicScale<ChartJs.LogarithmicScaleOptions>

        type RadialLinearScale<'O> =
            ChartJs.RadialLinearScale<'O>

        type RadialLinearScale =
            RadialLinearScale<ChartJs.RadialLinearScaleOptions>

        type TimeScale<'O> =
            ChartJs.TimeScale<'O>

        type TimeScale =
            TimeScale<ChartJs.TimeScaleOptions>

        type TimeSeriesScale<'O> =
            ChartJs.TimeSeriesScale<'O>

        type TimeSeriesScale =
            TimeSeriesScale<ChartJs.TimeScaleOptions>

        type PluginOptionsByType<'TType> =
            ChartJs.PluginOptionsByType<'TType>

        type ElementOptionsByType<'TType> =
            ChartJs.ElementOptionsByType<'TType>

        type ChartDatasetProperties<'TType, 'TData> =
            ChartJs.ChartDatasetProperties<'TType, 'TData>

        type UpdateModeEnum =
            ChartJs.UpdateModeEnum

        type DateAdapter<'T> =
            ChartJs.DateAdapter<'T>

        type DateAdapter =
            DateAdapter<ChartJs.AnyObject>

        type TimeUnit =
            ChartJs.TimeUnit

        type EasingFunction =
            ChartJs.EasingFunction

        type ArcProps =
            ChartJs.ArcProps

        type PointProps =
            ChartJs.PointProps

        type Animator =
            ChartJs.dist.types.animation.Animator

        type AnimationEvent =
            ChartJs.AnimationEvent

        type Color =
            ChartJs.Color

        type ChartArea =
            ChartJs.ChartArea

        type Point =
            ChartJs.Point

        type TRBL =
            ChartJs.TRBL

        type LayoutItem =
            ChartJs.LayoutItem

        type LayoutPosition =
            ChartJs.LayoutPosition

        type ScriptableContext<'TType> =
            ChartJs.ScriptableContext<'TType>

        type ScriptableLineSegmentContext =
            ChartJs.ScriptableLineSegmentContext

        type Scriptable<'T, 'TContext> =
            ChartJs.Scriptable<'T, 'TContext>

        type ScriptableOptions<'T, 'TContext> =
            ChartJs.ScriptableOptions<'T, 'TContext>

        type ScriptableAndScriptableOptions<'T, 'TContext> =
            ChartJs.ScriptableAndScriptableOptions<'T, 'TContext>

        type ScriptableAndArray<'T, 'TContext> =
            ChartJs.ScriptableAndArray<'T, 'TContext>

        type ScriptableAndArrayOptions<'T, 'TContext> =
            ChartJs.ScriptableAndArrayOptions<'T, 'TContext>

        type ParsingOptions =
            ChartJs.ParsingOptions

        type ControllerDatasetOptions =
            ChartJs.ControllerDatasetOptions

        type BarControllerDatasetOptions =
            ChartJs.BarControllerDatasetOptions

        type BarControllerChartOptions =
            ChartJs.BarControllerChartOptions

        type BubbleControllerDatasetOptions =
            ChartJs.BubbleControllerDatasetOptions

        type BubbleDataPoint =
            ChartJs.BubbleDataPoint

        type LineControllerDatasetOptions =
            ChartJs.LineControllerDatasetOptions

        type LineControllerChartOptions =
            ChartJs.LineControllerChartOptions

        type ScatterControllerDatasetOptions =
            ChartJs.ScatterControllerDatasetOptions

        type ScatterDataPoint =
            ChartJs.ScatterDataPoint

        type ScatterControllerChartOptions =
            ChartJs.ScatterControllerChartOptions

        type DoughnutControllerDatasetOptions =
            ChartJs.DoughnutControllerDatasetOptions

        type DoughnutAnimationOptions =
            ChartJs.DoughnutAnimationOptions

        type DoughnutControllerChartOptions =
            ChartJs.DoughnutControllerChartOptions

        type DoughnutDataPoint =
            ChartJs.DoughnutDataPoint

        type DoughnutMetaExtensions =
            ChartJs.DoughnutMetaExtensions

        type PieControllerDatasetOptions =
            ChartJs.PieControllerDatasetOptions

        type PieControllerChartOptions =
            ChartJs.PieControllerChartOptions

        type PieAnimationOptions =
            ChartJs.PieAnimationOptions

        type PieDataPoint =
            ChartJs.PieDataPoint

        type PieMetaExtensions =
            ChartJs.PieMetaExtensions

        type PolarAreaControllerDatasetOptions =
            ChartJs.PolarAreaControllerDatasetOptions

        type PolarAreaAnimationOptions =
            ChartJs.PolarAreaAnimationOptions

        type PolarAreaControllerChartOptions =
            ChartJs.PolarAreaControllerChartOptions

        type RadarControllerDatasetOptions =
            ChartJs.RadarControllerDatasetOptions

        type RadarControllerChartOptions =
            ChartJs.RadarControllerChartOptions

        type ChartMeta<'TType, 'TElement, 'TDatasetElement> =
            ChartJs.ChartMeta<'TType, 'TElement, 'TDatasetElement>

        type ChartMeta<'TType, 'TElement> =
            ChartMeta<'TType, 'TElement, ChartJs.Element>

        type ChartMeta<'TType> =
            ChartMeta<'TType, ChartJs.Element, ChartJs.Element>

        type ChartMeta =
            ChartMeta<ChartJs.ChartType, ChartJs.Element, ChartJs.Element>

        type ActiveDataPoint =
            ChartJs.ActiveDataPoint

        type ActiveElement =
            ChartJs.ActiveElement

        type ChartItem =
            ChartJs.ChartItem

        type UpdateMode =
            ChartJs.UpdateMode

        type DatasetControllerChartComponent =
            ChartJs.DatasetControllerChartComponent

        type Defaults =
            ChartJs.Defaults

        type Overrides =
            ChartJs.Overrides

        type InteractionOptions =
            ChartJs.InteractionOptions

        type InteractionItem =
            ChartJs.InteractionItem

        type InteractionModeFunction =
            ChartJs.InteractionModeFunction

        type InteractionModeMap =
            ChartJs.InteractionModeMap

        type InteractionMode =
            ChartJs.InteractionMode

        type Plugin<'TType, 'O> =
            ChartJs.Plugin<'TType, 'O>

        type Plugin<'TType> =
            Plugin<'TType, ChartJs.AnyObject>

        type Plugin =
            Plugin<ChartJs.ChartType, ChartJs.AnyObject>

        type ChartComponentLike =
            ChartJs.ChartComponentLike

        type Registry =
            ChartJs.Registry

        type Tick =
            ChartJs.Tick

        type CoreScaleOptions =
            ChartJs.CoreScaleOptions

        type ScriptableScaleContext =
            ChartJs.ScriptableScaleContext

        type ScriptableScalePointLabelContext =
            ChartJs.ScriptableScalePointLabelContext

        type RenderTextOpts =
            ChartJs.RenderTextOpts

        type BackdropOptions =
            ChartJs.BackdropOptions

        type LabelItem =
            ChartJs.LabelItem

        type TypedRegistry<'T> =
            ChartJs.TypedRegistry<'T>

        type ChartEvent =
            ChartJs.ChartEvent

        type ChartComponent =
            ChartJs.ChartComponent

        type InteractionAxis =
            ChartJs.InteractionAxis

        type CoreInteractionOptions =
            ChartJs.CoreInteractionOptions

        type CoreChartOptions<'TType> =
            ChartJs.CoreChartOptions<'TType>

        type AnimationSpec<'TType> =
            ChartJs.AnimationSpec<'TType>

        type AnimationsSpec<'TType> =
            ChartJs.AnimationsSpec<'TType>

        type TransitionSpec<'TType> =
            ChartJs.TransitionSpec<'TType>

        type TransitionsSpec<'TType> =
            ChartJs.TransitionsSpec<'TType>

        type AnimationOptions<'TType> =
            ChartJs.AnimationOptions<'TType>

        type FontSpec =
            ChartJs.FontSpec

        type CanvasFontSpec =
            ChartJs.CanvasFontSpec

        type TextAlign =
            ChartJs.TextAlign

        type Align =
            ChartJs.Align

        type VisualElement =
            ChartJs.VisualElement

        type CommonElementOptions =
            ChartJs.CommonElementOptions

        type CommonHoverOptions =
            ChartJs.CommonHoverOptions

        type Segment =
            ChartJs.Segment

        type ArcBorderRadius =
            ChartJs.ArcBorderRadius

        type ArcOptions =
            ChartJs.ArcOptions

        type ArcHoverOptions =
            ChartJs.ArcHoverOptions

        type LineProps =
            ChartJs.LineProps

        type LineOptions =
            ChartJs.LineOptions

        type LineHoverOptions =
            ChartJs.LineHoverOptions

        type PointStyle =
            ChartJs.PointStyle

        type PointOptions =
            ChartJs.PointOptions

        type PointHoverOptions =
            ChartJs.PointHoverOptions

        type PointPrefixedOptions =
            ChartJs.PointPrefixedOptions

        type PointPrefixedHoverOptions =
            ChartJs.PointPrefixedHoverOptions

        type BarProps =
            ChartJs.BarProps

        type BarOptions =
            ChartJs.BarOptions

        type BorderRadius =
            ChartJs.BorderRadius

        type BarHoverOptions =
            ChartJs.BarHoverOptions

        type ElementChartOptions<'TType> =
            ChartJs.ElementChartOptions<'TType>

        type ElementChartOptions =
            ElementChartOptions<ChartJs.ChartType>

        type DecimationAlgorithm =
            ChartJs.DecimationAlgorithm

        type DecimationOptions =
            ChartJs.DecimationOptions

        type FillerOptions =
            ChartJs.FillerOptions

        type FillTarget =
            ChartJs.FillTarget

        type ComplexFillTarget =
            ChartJs.ComplexFillTarget

        type FillerControllerDatasetOptions =
            ChartJs.FillerControllerDatasetOptions

        type LegendItem =
            ChartJs.LegendItem

        type LegendElement<'TType> =
            ChartJs.LegendElement<'TType>

        type LegendOptions<'TType> =
            ChartJs.LegendOptions<'TType>

        type TitleOptions =
            ChartJs.TitleOptions

        type TooltipXAlignment =
            ChartJs.TooltipXAlignment

        type TooltipYAlignment =
            ChartJs.TooltipYAlignment

        type TooltipLabelStyle =
            ChartJs.TooltipLabelStyle

        type TooltipModel<'TType> =
            ChartJs.TooltipModel<'TType>

        type TooltipPosition =
            ChartJs.TooltipPosition

        type TooltipPositionerFunction<'TType> =
            ChartJs.TooltipPositionerFunction<'TType>

        type TooltipPositionerMap =
            ChartJs.TooltipPositionerMap

        type TooltipPositioner =
            ChartJs.TooltipPositioner

        type TooltipDatasetCallbacks<'TType, 'Model, 'Item> =
            ChartJs.TooltipDatasetCallbacks<'TType, 'Model, 'Item>

        type TooltipDatasetCallbacks<'TType, 'Model> =
            TooltipDatasetCallbacks<'TType, 'Model, ChartJs.TooltipItem<'TType>>

        type TooltipDatasetCallbacks<'TType> =
            TooltipDatasetCallbacks<'TType, ChartJs.TooltipModel<'TType>, ChartJs.TooltipItem<'TType>>

        type TooltipCallbacks<'TType, 'Model, 'Item> =
            ChartJs.TooltipCallbacks<'TType, 'Model, 'Item>

        type TooltipCallbacks<'TType, 'Model> =
            TooltipCallbacks<'TType, 'Model, ChartJs.TooltipItem<'TType>>

        type TooltipCallbacks<'TType> =
            TooltipCallbacks<'TType, ChartJs.TooltipModel<'TType>, ChartJs.TooltipItem<'TType>>

        type ExtendedPlugin<'TType, 'O, 'Model> =
            ChartJs.ExtendedPlugin<'TType, 'O, 'Model>

        type ExtendedPlugin<'TType, 'O> =
            ExtendedPlugin<'TType, 'O, ChartJs.TooltipModel<'TType>>

        type ExtendedPlugin<'TType> =
            ExtendedPlugin<'TType, ChartJs.AnyObject, ChartJs.TooltipModel<'TType>>

        type ScriptableTooltipContext<'TType> =
            ChartJs.ScriptableTooltipContext<'TType>

        type TooltipOptions<'TType> =
            ChartJs.TooltipOptions<'TType>

        type TooltipOptions =
            TooltipOptions<ChartJs.ChartType>

        type TooltipDatasetOptions<'TType> =
            ChartJs.TooltipDatasetOptions<'TType>

        type TooltipDatasetOptions =
            TooltipDatasetOptions<ChartJs.ChartType>

        type TooltipItem<'TType> =
            ChartJs.TooltipItem<'TType>

        type PluginDatasetOptionsByType<'TType> =
            ChartJs.PluginDatasetOptionsByType<'TType>

        type PluginChartOptions<'TType> =
            ChartJs.PluginChartOptions<'TType>

        type BorderOptions =
            ChartJs.BorderOptions

        type GridLineOptions =
            ChartJs.GridLineOptions

        type TickOptions =
            ChartJs.TickOptions

        type CartesianTickOptions =
            ChartJs.CartesianTickOptions

        type ScriptableCartesianScaleContext =
            ChartJs.ScriptableCartesianScaleContext

        type ScriptableChartContext =
            ChartJs.ScriptableChartContext

        type CartesianScaleOptions =
            ChartJs.CartesianScaleOptions

        type CategoryScaleOptions =
            ChartJs.CategoryScaleOptions

        type LinearScaleOptions =
            ChartJs.LinearScaleOptions

        type LogarithmicScaleOptions =
            ChartJs.LogarithmicScaleOptions

        type TimeScaleTimeOptions =
            ChartJs.TimeScaleTimeOptions

        type TimeScaleTickOptions =
            ChartJs.TimeScaleTickOptions

        type TimeScaleOptions =
            ChartJs.TimeScaleOptions

        type RadialTickOptions =
            ChartJs.RadialTickOptions

        type RadialLinearScaleOptions =
            ChartJs.RadialLinearScaleOptions

        type CartesianScaleTypeRegistry =
            ChartJs.CartesianScaleTypeRegistry

        type RadialScaleTypeRegistry =
            ChartJs.RadialScaleTypeRegistry

        type ScaleTypeRegistry =
            ChartJs.ScaleTypeRegistry

        type ScaleType =
            ChartJs.ScaleType

        type CartesianParsedData =
            ChartJs.CartesianParsedData

        type BarParsedData =
            ChartJs.BarParsedData

        type BubbleParsedData =
            ChartJs.BubbleParsedData

        type RadialParsedData =
            ChartJs.RadialParsedData

        type ChartTypeRegistry =
            ChartJs.ChartTypeRegistry

        type ChartType =
            ChartJs.ChartType

        type ScaleOptionsByType<'TScale> =
            ChartJs.ScaleOptionsByType<'TScale>

        type ScaleOptionsByType =
            ScaleOptionsByType<ChartJs.ScaleType>

        type ScaleOptions<'TScale> =
            ChartJs.ScaleOptions<'TScale>

        type ScaleOptions =
            ScaleOptions<ChartJs.ScaleType>

        type DatasetChartOptions<'TType> =
            ChartJs.DatasetChartOptions<'TType>

        type DatasetChartOptions =
            DatasetChartOptions<ChartJs.ChartType>

        type ScaleChartOptions<'TType> =
            ChartJs.ScaleChartOptions<'TType>

        type ScaleChartOptions =
            ScaleChartOptions<ChartJs.ChartType>

        type ChartOptions<'TType> =
            ChartJs.ChartOptions<'TType>

        type ChartOptions =
            ChartOptions<ChartJs.ChartType>

        type DefaultDataPoint<'TType> =
            ChartJs.DefaultDataPoint<'TType>

        type ParsedDataType<'TType> =
            ChartJs.ParsedDataType<'TType>

        type ParsedDataType =
            ParsedDataType<ChartJs.ChartType>

        type ChartDatasetPropertiesCustomTypesPerDataset<'TType, 'TData> =
            ChartJs.ChartDatasetPropertiesCustomTypesPerDataset<'TType, 'TData>

        type ChartDataset<'TType, 'TData> =
            ChartJs.ChartDataset<'TType, 'TData>

        type ChartDataset<'TType> =
            ChartDataset<'TType, obj>

        type ChartDataset =
            ChartDataset<ChartJs.ChartType, obj>

        type ChartDatasetCustomTypesPerDataset<'TType, 'TData> =
            ChartJs.ChartDatasetCustomTypesPerDataset<'TType, 'TData>

        type ChartDatasetCustomTypesPerDataset<'TType> =
            ChartDatasetCustomTypesPerDataset<'TType, obj>

        type ChartDatasetCustomTypesPerDataset =
            ChartDatasetCustomTypesPerDataset<ChartJs.ChartType, obj>

        type ChartData<'TType, 'TData, 'TLabel> =
            ChartJs.ChartData<'TType, 'TData, 'TLabel>

        type ChartData<'TType, 'TData> =
            ChartData<'TType, 'TData, obj>

        type ChartData<'TType> =
            ChartData<'TType, ResizeArray<U4<float, ChartJs.Point, float * float, ChartJs.BubbleDataPoint> option>, obj>

        type ChartData =
            ChartData<ChartJs.ChartType, ResizeArray<U4<float, ChartJs.Point, float * float, ChartJs.BubbleDataPoint> option>, obj>

        type ChartDataCustomTypesPerDataset<'TType, 'TData, 'TLabel> =
            ChartJs.ChartDataCustomTypesPerDataset<'TType, 'TData, 'TLabel>

        type ChartDataCustomTypesPerDataset<'TType, 'TData> =
            ChartDataCustomTypesPerDataset<'TType, 'TData, obj>

        type ChartDataCustomTypesPerDataset<'TType> =
            ChartDataCustomTypesPerDataset<'TType, ResizeArray<U4<float, ChartJs.Point, float * float, ChartJs.BubbleDataPoint> option>, obj>

        type ChartDataCustomTypesPerDataset =
            ChartDataCustomTypesPerDataset<ChartJs.ChartType, ResizeArray<U4<float, ChartJs.Point, float * float, ChartJs.BubbleDataPoint> option>, obj>

        type ChartConfiguration<'TType, 'TData, 'TLabel> =
            ChartJs.ChartConfiguration<'TType, 'TData, 'TLabel>

        type ChartConfiguration<'TType, 'TData> =
            ChartConfiguration<'TType, 'TData, obj>

        type ChartConfiguration<'TType> =
            ChartConfiguration<'TType, ResizeArray<U4<float, ChartJs.Point, float * float, ChartJs.BubbleDataPoint> option>, obj>

        type ChartConfiguration =
            ChartConfiguration<ChartJs.ChartType, ResizeArray<U4<float, ChartJs.Point, float * float, ChartJs.BubbleDataPoint> option>, obj>

        type ChartConfigurationCustomTypesPerDataset<'TType, 'TData, 'TLabel> =
            ChartJs.ChartConfigurationCustomTypesPerDataset<'TType, 'TData, 'TLabel>

        type ChartConfigurationCustomTypesPerDataset<'TType, 'TData> =
            ChartConfigurationCustomTypesPerDataset<'TType, 'TData, obj>

        type ChartConfigurationCustomTypesPerDataset<'TType> =
            ChartConfigurationCustomTypesPerDataset<'TType, ResizeArray<U4<float, ChartJs.Point, float * float, ChartJs.BubbleDataPoint> option>, obj>

        type ChartConfigurationCustomTypesPerDataset =
            ChartConfigurationCustomTypesPerDataset<ChartJs.ChartType, ResizeArray<U4<float, ChartJs.Point, float * float, ChartJs.BubbleDataPoint> option>, obj>

        module Exports =

            module BarController__ =

                [<AllowNullLiteral>]
                [<Interface>]
                type Type =
                    abstract member id: string with get, set
                    abstract member defaults: ChartJs.AnyObject option with get, set
                    abstract member defaultRoutes: Exports.BarController__.Type.defaultRoutes option with get, set
                    abstract member beforeRegister: (unit -> unit) option with get, set
                    abstract member afterRegister: (unit -> unit) option with get, set
                    abstract member beforeUnregister: (unit -> unit) option with get, set
                    abstract member afterUnregister: (unit -> unit) option with get, set
                    abstract member prototype: ChartJs.BarController with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (id: string, prototype: ChartJs.BarController, ?defaults: ChartJs.AnyObject, ?defaultRoutes: Exports.BarController__.Type.defaultRoutes, ?beforeRegister: (unit -> unit), ?afterRegister: (unit -> unit), ?beforeUnregister: (unit -> unit), ?afterUnregister: (unit -> unit)) : Type = nativeOnly

                module Type =

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type defaultRoutes =
                        [<EmitIndexer>]
                        abstract member Item: property: string -> string with get, set

            module BubbleController__ =

                [<AllowNullLiteral>]
                [<Interface>]
                type Type =
                    abstract member id: string with get, set
                    abstract member defaults: ChartJs.AnyObject option with get, set
                    abstract member defaultRoutes: Exports.BarController__.Type.defaultRoutes option with get, set
                    abstract member beforeRegister: (unit -> unit) option with get, set
                    abstract member afterRegister: (unit -> unit) option with get, set
                    abstract member beforeUnregister: (unit -> unit) option with get, set
                    abstract member afterUnregister: (unit -> unit) option with get, set
                    abstract member prototype: ChartJs.BubbleController with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (id: string, prototype: ChartJs.BubbleController, ?defaults: ChartJs.AnyObject, ?defaultRoutes: Exports.BarController__.Type.defaultRoutes, ?beforeRegister: (unit -> unit), ?afterRegister: (unit -> unit), ?beforeUnregister: (unit -> unit), ?afterUnregister: (unit -> unit)) : Type = nativeOnly

            module DoughnutController__ =

                [<AllowNullLiteral>]
                [<Interface>]
                type Type =
                    abstract member id: string with get, set
                    abstract member defaults: ChartJs.AnyObject option with get, set
                    abstract member defaultRoutes: Exports.BarController__.Type.defaultRoutes option with get, set
                    abstract member beforeRegister: (unit -> unit) option with get, set
                    abstract member afterRegister: (unit -> unit) option with get, set
                    abstract member beforeUnregister: (unit -> unit) option with get, set
                    abstract member afterUnregister: (unit -> unit) option with get, set
                    abstract member prototype: ChartJs.DoughnutController with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (id: string, prototype: ChartJs.DoughnutController, ?defaults: ChartJs.AnyObject, ?defaultRoutes: Exports.BarController__.Type.defaultRoutes, ?beforeRegister: (unit -> unit), ?afterRegister: (unit -> unit), ?beforeUnregister: (unit -> unit), ?afterUnregister: (unit -> unit)) : Type = nativeOnly

            module LineController__ =

                [<AllowNullLiteral>]
                [<Interface>]
                type Type =
                    abstract member id: string with get, set
                    abstract member defaults: ChartJs.AnyObject option with get, set
                    abstract member defaultRoutes: Exports.BarController__.Type.defaultRoutes option with get, set
                    abstract member beforeRegister: (unit -> unit) option with get, set
                    abstract member afterRegister: (unit -> unit) option with get, set
                    abstract member beforeUnregister: (unit -> unit) option with get, set
                    abstract member afterUnregister: (unit -> unit) option with get, set
                    abstract member prototype: ChartJs.LineController with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (id: string, prototype: ChartJs.LineController, ?defaults: ChartJs.AnyObject, ?defaultRoutes: Exports.BarController__.Type.defaultRoutes, ?beforeRegister: (unit -> unit), ?afterRegister: (unit -> unit), ?beforeUnregister: (unit -> unit), ?afterUnregister: (unit -> unit)) : Type = nativeOnly

            module PieController__ =

                [<AllowNullLiteral>]
                [<Interface>]
                type Type =
                    abstract member id: string with get, set
                    abstract member defaults: ChartJs.AnyObject option with get, set
                    abstract member defaultRoutes: Exports.BarController__.Type.defaultRoutes option with get, set
                    abstract member beforeRegister: (unit -> unit) option with get, set
                    abstract member afterRegister: (unit -> unit) option with get, set
                    abstract member beforeUnregister: (unit -> unit) option with get, set
                    abstract member afterUnregister: (unit -> unit) option with get, set
                    abstract member prototype: ChartJs.PieController with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (id: string, prototype: ChartJs.PieController, ?defaults: ChartJs.AnyObject, ?defaultRoutes: Exports.BarController__.Type.defaultRoutes, ?beforeRegister: (unit -> unit), ?afterRegister: (unit -> unit), ?beforeUnregister: (unit -> unit), ?afterUnregister: (unit -> unit)) : Type = nativeOnly

            module PolarAreaController__ =

                [<AllowNullLiteral>]
                [<Interface>]
                type Type =
                    abstract member id: string with get, set
                    abstract member defaults: ChartJs.AnyObject option with get, set
                    abstract member defaultRoutes: Exports.BarController__.Type.defaultRoutes option with get, set
                    abstract member beforeRegister: (unit -> unit) option with get, set
                    abstract member afterRegister: (unit -> unit) option with get, set
                    abstract member beforeUnregister: (unit -> unit) option with get, set
                    abstract member afterUnregister: (unit -> unit) option with get, set
                    abstract member prototype: ChartJs.PolarAreaController with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (id: string, prototype: ChartJs.PolarAreaController, ?defaults: ChartJs.AnyObject, ?defaultRoutes: Exports.BarController__.Type.defaultRoutes, ?beforeRegister: (unit -> unit), ?afterRegister: (unit -> unit), ?beforeUnregister: (unit -> unit), ?afterUnregister: (unit -> unit)) : Type = nativeOnly

            module RadarController__ =

                [<AllowNullLiteral>]
                [<Interface>]
                type Type =
                    abstract member id: string with get, set
                    abstract member defaults: ChartJs.AnyObject option with get, set
                    abstract member defaultRoutes: Exports.BarController__.Type.defaultRoutes option with get, set
                    abstract member beforeRegister: (unit -> unit) option with get, set
                    abstract member afterRegister: (unit -> unit) option with get, set
                    abstract member beforeUnregister: (unit -> unit) option with get, set
                    abstract member afterUnregister: (unit -> unit) option with get, set
                    abstract member prototype: ChartJs.RadarController with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (id: string, prototype: ChartJs.RadarController, ?defaults: ChartJs.AnyObject, ?defaultRoutes: Exports.BarController__.Type.defaultRoutes, ?beforeRegister: (unit -> unit), ?afterRegister: (unit -> unit), ?beforeUnregister: (unit -> unit), ?afterUnregister: (unit -> unit)) : Type = nativeOnly

            module ScatterController__ =

                [<AllowNullLiteral>]
                [<Interface>]
                type Type =
                    abstract member id: string with get, set
                    abstract member defaults: ChartJs.AnyObject option with get, set
                    abstract member defaultRoutes: Exports.BarController__.Type.defaultRoutes option with get, set
                    abstract member beforeRegister: (unit -> unit) option with get, set
                    abstract member afterRegister: (unit -> unit) option with get, set
                    abstract member beforeUnregister: (unit -> unit) option with get, set
                    abstract member afterUnregister: (unit -> unit) option with get, set
                    abstract member prototype: ChartJs.ScatterController with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (id: string, prototype: ChartJs.ScatterController, ?defaults: ChartJs.AnyObject, ?defaultRoutes: Exports.BarController__.Type.defaultRoutes, ?beforeRegister: (unit -> unit), ?afterRegister: (unit -> unit), ?beforeUnregister: (unit -> unit), ?afterUnregister: (unit -> unit)) : Type = nativeOnly

            module Interaction__ =

                [<AllowNullLiteral>]
                [<Interface>]
                type Type =
                    abstract member modes: ChartJs.InteractionModeMap with get, set
                    /// <summary>
                    /// Helper function to select candidate elements for interaction
                    /// </summary>
                    abstract member evaluateInteractionItems: chart: ChartJs.dist.types.Chart * axis: ChartJs.InteractionAxis * position: ChartJs.Point * handler: Exports.Interaction__.Type.evaluateInteractionItems.handler * ?intersect: bool -> ResizeArray<ChartJs.InteractionItem>
                    [<ParamObject; Emit("$0")>]
                    static member Create (modes: ChartJs.InteractionModeMap, evaluateInteractionItems: Exports.Interaction__.Type.evaluateInteractionItems) : Type = nativeOnly

                module Type =

                    type evaluateInteractionItems =
                        delegate of chart: ChartJs.dist.types.Chart * axis: ChartJs.InteractionAxis * position: ChartJs.Point * handler: Exports.Interaction__.Type.evaluateInteractionItems.handler * ?intersect: bool -> ResizeArray<ChartJs.InteractionItem>

                    module evaluateInteractionItems =

                        type handler =
                            delegate of element: Exports.Interaction__.Type.evaluateInteractionItems.handler.element * datasetIndex: float * index: float -> unit

                        module handler =

                            [<AllowNullLiteral>]
                            [<Interface>]
                            type element =
                                inherit ChartJs.VisualElement

            module Ticks__ =

                [<AllowNullLiteral>]
                [<Interface>]
                type Type =
                    abstract member formatters: Exports.Ticks__.Type.formatters with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (formatters: Exports.Ticks__.Type.formatters) : Type = nativeOnly

                module Type =

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type formatters =
                        /// <summary>
                        /// Formatter for value labels
                        /// </summary>
                        /// <param name="value">
                        /// the value to display
                        /// </param>
                        /// <returns>
                        /// the label to display
                        /// </returns>
                        abstract member values: value: obj -> U2<string, ResizeArray<string>>
                        /// <summary>
                        /// Formatter for numeric ticks
                        /// </summary>
                        /// <param name="tickValue">
                        /// the value to be formatted
                        /// </param>
                        /// <param name="index">
                        /// the position of the tickValue parameter in the ticks array
                        /// </param>
                        /// <param name="ticks">
                        /// the list of ticks being converted
                        /// </param>
                        /// <returns>
                        /// string representation of the tickValue parameter
                        /// </returns>
                        abstract member numeric: tickValue: float * index: float * ticks: ResizeArray<Exports.Ticks__.Type.formatters.numeric.ticks.Item> -> string
                        /// <summary>
                        /// Formatter for logarithmic ticks
                        /// </summary>
                        /// <param name="tickValue">
                        /// the value to be formatted
                        /// </param>
                        /// <param name="index">
                        /// the position of the tickValue parameter in the ticks array
                        /// </param>
                        /// <param name="ticks">
                        /// the list of ticks being converted
                        /// </param>
                        /// <returns>
                        /// string representation of the tickValue parameter
                        /// </returns>
                        abstract member logarithmic: tickValue: float * index: float * ticks: ResizeArray<Exports.Ticks__.Type.formatters.logarithmic.ticks.Item> -> string
                        [<ParamObject; Emit("$0")>]
                        static member Create (values: (obj -> U2<string, ResizeArray<string>>), numeric: Exports.Ticks__.Type.formatters.numeric, logarithmic: Exports.Ticks__.Type.formatters.logarithmic) : formatters = nativeOnly

                    module formatters =

                        type numeric =
                            delegate of tickValue: float * index: float * ticks: ResizeArray<Exports.Ticks__.Type.formatters.numeric.ticks.Item> -> string

                        type logarithmic =
                            delegate of tickValue: float * index: float * ticks: ResizeArray<Exports.Ticks__.Type.formatters.logarithmic.ticks.Item> -> string

                        module numeric =

                            module ticks =

                                [<AllowNullLiteral>]
                                [<Interface>]
                                type Item =
                                    abstract member value: float with get, set
                                    [<ParamObject; Emit("$0")>]
                                    static member Create (value: float) : Item = nativeOnly

                        module logarithmic =

                            module ticks =

                                [<AllowNullLiteral>]
                                [<Interface>]
                                type Item =
                                    abstract member value: float with get, set
                                    [<ParamObject; Emit("$0")>]
                                    static member Create (value: float) : Item = nativeOnly

            module layouts__ =

                [<AllowNullLiteral>]
                [<Interface>]
                type Type =
                    /// <summary>
                    /// Register a box to a chart.
                    /// A box is simply a reference to an object that requires layout. eg. Scales, Legend, Title.
                    /// </summary>
                    /// <param name="chart">
                    /// the chart to use
                    /// </param>
                    /// <param name="item">
                    /// the item to add to be laid out
                    /// </param>
                    abstract member addBox: chart: ChartJs.dist.types.Chart * item: ChartJs.LayoutItem -> unit
                    /// <summary>
                    /// Remove a layoutItem from a chart
                    /// </summary>
                    /// <param name="chart">
                    /// the chart to remove the box from
                    /// </param>
                    /// <param name="layoutItem">
                    /// the item to remove from the layout
                    /// </param>
                    abstract member removeBox: chart: ChartJs.dist.types.Chart * layoutItem: ChartJs.LayoutItem -> unit
                    /// <summary>
                    /// Sets (or updates) options on the given <c>item</c>.
                    /// </summary>
                    /// <param name="chart">
                    /// the chart in which the item lives (or will be added to)
                    /// </param>
                    /// <param name="item">
                    /// the item to configure with the given options
                    /// </param>
                    /// <param name="options">
                    /// the new item options.
                    /// </param>
                    abstract member configure: chart: ChartJs.dist.types.Chart * item: ChartJs.LayoutItem * options: Exports.layouts__.Type.configure.options -> unit
                    /// <summary>
                    /// Fits boxes of the given chart into the given size by having each box measure itself
                    /// then running a fitting algorithm
                    /// </summary>
                    /// <param name="chart">
                    /// the chart
                    /// </param>
                    /// <param name="width">
                    /// the width to fit into
                    /// </param>
                    /// <param name="height">
                    /// the height to fit into
                    /// </param>
                    abstract member update: chart: ChartJs.dist.types.Chart * width: float * height: float -> unit
                    [<ParamObject; Emit("$0")>]
                    static member Create (addBox: Exports.layouts__.Type.addBox, removeBox: Exports.layouts__.Type.removeBox, configure: Exports.layouts__.Type.configure, update: Exports.layouts__.Type.update) : Type = nativeOnly

                module Type =

                    type addBox =
                        delegate of chart: ChartJs.dist.types.Chart * item: ChartJs.LayoutItem -> unit

                    type removeBox =
                        delegate of chart: ChartJs.dist.types.Chart * layoutItem: ChartJs.LayoutItem -> unit

                    type configure =
                        delegate of chart: ChartJs.dist.types.Chart * item: ChartJs.LayoutItem * options: Exports.layouts__.Type.configure.options -> unit

                    type update =
                        delegate of chart: ChartJs.dist.types.Chart * width: float * height: float -> unit

                    module configure =

                        [<AllowNullLiteral>]
                        [<Interface>]
                        type options =
                            abstract member fullSize: float option with get, set
                            abstract member position: ChartJs.LayoutPosition option with get, set
                            abstract member weight: float option with get, set
                            [<ParamObject; Emit("$0")>]
                            static member Create (?fullSize: float, ?position: ChartJs.LayoutPosition, ?weight: float) : options = nativeOnly

            module BarElement__ =

                [<AllowNullLiteral>]
                [<Interface>]
                type Type =
                    abstract member id: string with get, set
                    abstract member defaults: ChartJs.AnyObject option with get, set
                    abstract member defaultRoutes: Exports.BarController__.Type.defaultRoutes option with get, set
                    abstract member beforeRegister: (unit -> unit) option with get, set
                    abstract member afterRegister: (unit -> unit) option with get, set
                    abstract member beforeUnregister: (unit -> unit) option with get, set
                    abstract member afterUnregister: (unit -> unit) option with get, set
                    abstract member prototype: ChartJs.BarElement with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (id: string, prototype: ChartJs.BarElement, ?defaults: ChartJs.AnyObject, ?defaultRoutes: Exports.BarController__.Type.defaultRoutes, ?beforeRegister: (unit -> unit), ?afterRegister: (unit -> unit), ?beforeUnregister: (unit -> unit), ?afterUnregister: (unit -> unit)) : Type = nativeOnly

            module LineElement__ =

                [<AllowNullLiteral>]
                [<Interface>]
                type Type =
                    abstract member id: string with get, set
                    abstract member defaults: ChartJs.AnyObject option with get, set
                    abstract member defaultRoutes: Exports.BarController__.Type.defaultRoutes option with get, set
                    abstract member beforeRegister: (unit -> unit) option with get, set
                    abstract member afterRegister: (unit -> unit) option with get, set
                    abstract member beforeUnregister: (unit -> unit) option with get, set
                    abstract member afterUnregister: (unit -> unit) option with get, set
                    abstract member prototype: ChartJs.LineElement with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (id: string, prototype: ChartJs.LineElement, ?defaults: ChartJs.AnyObject, ?defaultRoutes: Exports.BarController__.Type.defaultRoutes, ?beforeRegister: (unit -> unit), ?afterRegister: (unit -> unit), ?beforeUnregister: (unit -> unit), ?afterUnregister: (unit -> unit)) : Type = nativeOnly

            module CategoryScale__ =

                [<AllowNullLiteral>]
                [<Interface>]
                type Type =
                    abstract member id: string with get, set
                    abstract member defaults: ChartJs.AnyObject option with get, set
                    abstract member defaultRoutes: Exports.BarController__.Type.defaultRoutes option with get, set
                    abstract member beforeRegister: (unit -> unit) option with get, set
                    abstract member afterRegister: (unit -> unit) option with get, set
                    abstract member beforeUnregister: (unit -> unit) option with get, set
                    abstract member afterUnregister: (unit -> unit) option with get, set
                    abstract member prototype: ChartJs.CategoryScale with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (id: string, prototype: ChartJs.CategoryScale, ?defaults: ChartJs.AnyObject, ?defaultRoutes: Exports.BarController__.Type.defaultRoutes, ?beforeRegister: (unit -> unit), ?afterRegister: (unit -> unit), ?beforeUnregister: (unit -> unit), ?afterUnregister: (unit -> unit)) : Type = nativeOnly

            module LinearScale__ =

                [<AllowNullLiteral>]
                [<Interface>]
                type Type =
                    abstract member id: string with get, set
                    abstract member defaults: ChartJs.AnyObject option with get, set
                    abstract member defaultRoutes: Exports.BarController__.Type.defaultRoutes option with get, set
                    abstract member beforeRegister: (unit -> unit) option with get, set
                    abstract member afterRegister: (unit -> unit) option with get, set
                    abstract member beforeUnregister: (unit -> unit) option with get, set
                    abstract member afterUnregister: (unit -> unit) option with get, set
                    abstract member prototype: ChartJs.LinearScale with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (id: string, prototype: ChartJs.LinearScale, ?defaults: ChartJs.AnyObject, ?defaultRoutes: Exports.BarController__.Type.defaultRoutes, ?beforeRegister: (unit -> unit), ?afterRegister: (unit -> unit), ?beforeUnregister: (unit -> unit), ?afterUnregister: (unit -> unit)) : Type = nativeOnly

            module LogarithmicScale__ =

                [<AllowNullLiteral>]
                [<Interface>]
                type Type =
                    abstract member id: string with get, set
                    abstract member defaults: ChartJs.AnyObject option with get, set
                    abstract member defaultRoutes: Exports.BarController__.Type.defaultRoutes option with get, set
                    abstract member beforeRegister: (unit -> unit) option with get, set
                    abstract member afterRegister: (unit -> unit) option with get, set
                    abstract member beforeUnregister: (unit -> unit) option with get, set
                    abstract member afterUnregister: (unit -> unit) option with get, set
                    abstract member prototype: ChartJs.LogarithmicScale with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (id: string, prototype: ChartJs.LogarithmicScale, ?defaults: ChartJs.AnyObject, ?defaultRoutes: Exports.BarController__.Type.defaultRoutes, ?beforeRegister: (unit -> unit), ?afterRegister: (unit -> unit), ?beforeUnregister: (unit -> unit), ?afterUnregister: (unit -> unit)) : Type = nativeOnly

            module RadialLinearScale__ =

                [<AllowNullLiteral>]
                [<Interface>]
                type Type =
                    abstract member id: string with get, set
                    abstract member defaults: ChartJs.AnyObject option with get, set
                    abstract member defaultRoutes: Exports.BarController__.Type.defaultRoutes option with get, set
                    abstract member beforeRegister: (unit -> unit) option with get, set
                    abstract member afterRegister: (unit -> unit) option with get, set
                    abstract member beforeUnregister: (unit -> unit) option with get, set
                    abstract member afterUnregister: (unit -> unit) option with get, set
                    abstract member prototype: ChartJs.RadialLinearScale with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (id: string, prototype: ChartJs.RadialLinearScale, ?defaults: ChartJs.AnyObject, ?defaultRoutes: Exports.BarController__.Type.defaultRoutes, ?beforeRegister: (unit -> unit), ?afterRegister: (unit -> unit), ?beforeUnregister: (unit -> unit), ?afterUnregister: (unit -> unit)) : Type = nativeOnly

            module TimeScale__ =

                [<AllowNullLiteral>]
                [<Interface>]
                type Type =
                    abstract member id: string with get, set
                    abstract member defaults: ChartJs.AnyObject option with get, set
                    abstract member defaultRoutes: Exports.BarController__.Type.defaultRoutes option with get, set
                    abstract member beforeRegister: (unit -> unit) option with get, set
                    abstract member afterRegister: (unit -> unit) option with get, set
                    abstract member beforeUnregister: (unit -> unit) option with get, set
                    abstract member afterUnregister: (unit -> unit) option with get, set
                    abstract member prototype: ChartJs.TimeScale with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (id: string, prototype: ChartJs.TimeScale, ?defaults: ChartJs.AnyObject, ?defaultRoutes: Exports.BarController__.Type.defaultRoutes, ?beforeRegister: (unit -> unit), ?afterRegister: (unit -> unit), ?beforeUnregister: (unit -> unit), ?afterUnregister: (unit -> unit)) : Type = nativeOnly

            module TimeSeriesScale__ =

                [<AllowNullLiteral>]
                [<Interface>]
                type Type =
                    abstract member id: string with get, set
                    abstract member defaults: ChartJs.AnyObject option with get, set
                    abstract member defaultRoutes: Exports.BarController__.Type.defaultRoutes option with get, set
                    abstract member beforeRegister: (unit -> unit) option with get, set
                    abstract member afterRegister: (unit -> unit) option with get, set
                    abstract member beforeUnregister: (unit -> unit) option with get, set
                    abstract member afterUnregister: (unit -> unit) option with get, set
                    abstract member prototype: ChartJs.TimeSeriesScale with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (id: string, prototype: ChartJs.TimeSeriesScale, ?defaults: ChartJs.AnyObject, ?defaultRoutes: Exports.BarController__.Type.defaultRoutes, ?beforeRegister: (unit -> unit), ?afterRegister: (unit -> unit), ?beforeUnregister: (unit -> unit), ?afterUnregister: (unit -> unit)) : Type = nativeOnly

            module Chart =

                [<AllowNullLiteral>]
                [<Interface>]
                type item =
                    abstract member canvas: Glutinum.Web.HTMLCanvasElement with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (canvas: Glutinum.Web.HTMLCanvasElement) : item = nativeOnly

            module Scale =

                [<AllowNullLiteral>]
                [<Interface>]
                type cfg =
                    abstract member id: string with get, set
                    abstract member ``type``: string with get, set
                    abstract member ctx: Glutinum.Web.CanvasRenderingContext2D with get, set
                    abstract member chart: ChartJs.dist.types.Chart with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (id: string, ``type``: string, ctx: Glutinum.Web.CanvasRenderingContext2D, chart: ChartJs.dist.types.Chart) : cfg = nativeOnly

    module dist =

        [<AbstractClass>]
        [<Erase>]
        type Exports =
            [<Import("_detectPlatform", "chart.js")>]
            static member _detectPlatform (canvas: obj) : U2<ChartJs.dist.platform.platform_basic.BasicPlatform, ChartJs.dist.platform.platform_dom.DomPlatform> = nativeOnly
            [<Import("registerables", "chart.js")>]
            static member inline registerables: ResizeArray<obj> = nativeOnly
            [<Import("Chart", "chart.js"); EmitConstructor>]
            static member Chart (item: obj, userConfig: obj) : Chart = nativeOnly
            [<Import("TimeSeriesScale", "chart.js"); EmitConstructor>]
            static member TimeSeriesScale () : TimeSeriesScale = nativeOnly

        type DateAdapter<'T> =
            ChartJs.DateAdapter<'T>

        type DateAdapter =
            DateAdapter<ChartJs.AnyObject>

        type TimeUnit =
            ChartJs.TimeUnit

        type Chart =
            ChartJs.dist.core.core_controller.Chart

        type TimeSeriesScale =
            ChartJs.dist.scales.scale_timeseries.TimeSeriesScale

        module controllers =

            module controller_bar =

                [<AbstractClass>]
                [<Erase>]
                type Exports =
                    [<ImportDefault("chart.js"); EmitConstructor>]
                    static member BarController () : BarController = nativeOnly

                [<AllowNullLiteral>]
                [<Interface>]
                type BarController =
                    inherit ChartJs.dist.core.core_datasetController.DatasetController
                    [<Emit("""import { BarController } from "chart.js/dist/controllers/controller.bar.js";
BarController.id{{=$0}}""")>]
                    static member inline id
                        with get () : string =
                            nativeOnly
                        and set (value: string) =
                            nativeOnly
                    [<Emit("""import { BarController } from "chart.js/dist/controllers/controller.bar.js";
BarController.overrides{{=$0}}""")>]
                    static member inline overrides
                        with get () : obj =
                            nativeOnly
                        and set (value: obj) =
                            nativeOnly
                    abstract member update: mode: obj -> unit
                    abstract member _getAxisCount: unit -> float
                    abstract member getFirstScaleIdForIndexAxis: unit -> string
                    abstract member _getAxis: unit -> ResizeArray<string>

            module controller_bubble =

                [<AbstractClass>]
                [<Erase>]
                type Exports =
                    [<ImportDefault("chart.js"); EmitConstructor>]
                    static member BubbleController () : BubbleController = nativeOnly

                [<AllowNullLiteral>]
                [<Interface>]
                type BubbleController =
                    inherit ChartJs.dist.core.core_datasetController.DatasetController
                    [<Emit("""import { BubbleController } from "chart.js/dist/controllers/controller.bubble.js";
BubbleController.id{{=$0}}""")>]
                    static member inline id
                        with get () : string =
                            nativeOnly
                        and set (value: string) =
                            nativeOnly
                    [<Emit("""import { BubbleController } from "chart.js/dist/controllers/controller.bubble.js";
BubbleController.overrides{{=$0}}""")>]
                    static member inline overrides
                        with get () : obj =
                            nativeOnly
                        and set (value: obj) =
                            nativeOnly
                    abstract member update: mode: obj -> unit

            module controller_doughnut =

                [<AbstractClass>]
                [<Erase>]
                type Exports =
                    [<ImportDefault("chart.js"); EmitConstructor>]
                    static member DoughnutController (chart: obj, datasetIndex: obj) : DoughnutController = nativeOnly

                [<AllowNullLiteral>]
                [<Interface>]
                type DoughnutController =
                    inherit ChartJs.dist.core.core_datasetController.DatasetController
                    [<Emit("""import { DoughnutController } from "chart.js/dist/controllers/controller.doughnut.js";
DoughnutController.id{{=$0}}""")>]
                    static member inline id
                        with get () : string =
                            nativeOnly
                        and set (value: string) =
                            nativeOnly
                    [<Emit("""import { DoughnutController } from "chart.js/dist/controllers/controller.doughnut.js";
DoughnutController.descriptors{{=$0}}""")>]
                    static member inline descriptors
                        with get () : DoughnutController.descriptors__ =
                            nativeOnly
                        and set (value: DoughnutController.descriptors__) =
                            nativeOnly
                    [<Emit("""import { DoughnutController } from "chart.js/dist/controllers/controller.doughnut.js";
DoughnutController.overrides{{=$0}}""")>]
                    static member inline overrides
                        with get () : obj =
                            nativeOnly
                        and set (value: obj) =
                            nativeOnly
                    abstract member innerRadius: float with get, set
                    abstract member outerRadius: float with get, set
                    abstract member offsetX: float with get, set
                    abstract member offsetY: float with get, set
                    /// <summary>
                    /// Override data parsing, since we are not using scales
                    /// </summary>
                    abstract member parse: start: obj * count: obj -> unit
                    /// <summary>
                    /// Get the maximal rotation & circumference extents
                    /// across all visible datasets.
                    /// </summary>
                    abstract member _getRotationExtents: unit -> DoughnutController._getRotationExtents
                    abstract member calculateTotal: unit -> float
                    abstract member calculateCircumference: value: obj -> float
                    abstract member getLabelAndValue: index: obj -> DoughnutController.getLabelAndValue
                    abstract member getMaxBorderWidth: arcs: obj -> float
                    abstract member getMaxOffset: arcs: obj -> float

                type Chart =
                    obj

                module DoughnutController =

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type descriptors__ =
                        abstract member _scriptable: (obj -> bool) with get, set
                        abstract member _indexable: (obj -> bool) with get, set
                        [<ParamObject; Emit("$0")>]
                        static member Create (_scriptable: (obj -> bool), _indexable: (obj -> bool)) : descriptors__ = nativeOnly

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type _getRotationExtents =
                        abstract member rotation: float with get, set
                        abstract member circumference: float with get, set
                        [<ParamObject; Emit("$0")>]
                        static member Create (rotation: float, circumference: float) : _getRotationExtents = nativeOnly

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type getLabelAndValue =
                        abstract member label: obj with get, set
                        abstract member value: string with get, set
                        [<ParamObject; Emit("$0")>]
                        static member Create (label: obj, value: string) : getLabelAndValue = nativeOnly

            module controller_line =

                [<AbstractClass>]
                [<Erase>]
                type Exports =
                    [<ImportDefault("chart.js"); EmitConstructor>]
                    static member LineController () : LineController = nativeOnly

                [<AllowNullLiteral>]
                [<Interface>]
                type LineController =
                    inherit ChartJs.dist.core.core_datasetController.DatasetController
                    [<Emit("""import { LineController } from "chart.js/dist/controllers/controller.line.js";
LineController.id{{=$0}}""")>]
                    static member inline id
                        with get () : string =
                            nativeOnly
                        and set (value: string) =
                            nativeOnly
                    [<Emit("""import { LineController } from "chart.js/dist/controllers/controller.line.js";
LineController.overrides{{=$0}}""")>]
                    static member inline overrides
                        with get () : obj =
                            nativeOnly
                        and set (value: obj) =
                            nativeOnly
                    abstract member update: mode: obj -> unit

            module controller_pie =

                [<AbstractClass>]
                [<Erase>]
                type Exports =
                    [<ImportDefault("chart.js"); EmitConstructor>]
                    static member PieController () : PieController = nativeOnly

                [<AllowNullLiteral>]
                [<Interface>]
                type PieController =
                    inherit ChartJs.dist.controllers.controller_doughnut.DoughnutController

            module controller_polarArea =

                [<AbstractClass>]
                [<Erase>]
                type Exports =
                    [<ImportDefault("chart.js"); EmitConstructor>]
                    static member PolarAreaController (chart: obj, datasetIndex: obj) : PolarAreaController = nativeOnly

                [<AllowNullLiteral>]
                [<Interface>]
                type PolarAreaController =
                    inherit ChartJs.dist.core.core_datasetController.DatasetController
                    [<Emit("""import { PolarAreaController } from "chart.js/dist/controllers/controller.polarArea.js";
PolarAreaController.id{{=$0}}""")>]
                    static member inline id
                        with get () : string =
                            nativeOnly
                        and set (value: string) =
                            nativeOnly
                    [<Emit("""import { PolarAreaController } from "chart.js/dist/controllers/controller.polarArea.js";
PolarAreaController.overrides{{=$0}}""")>]
                    static member inline overrides
                        with get () : obj =
                            nativeOnly
                        and set (value: obj) =
                            nativeOnly
                    abstract member innerRadius: float with get, set
                    abstract member outerRadius: float with get, set
                    abstract member getLabelAndValue: index: obj -> PolarAreaController.getLabelAndValue
                    /// <summary>
                    /// Parse array of objects
                    /// </summary>
                    abstract member parseObjectData: meta: obj * data: obj * start: obj * count: obj -> ResizeArray<PolarAreaController.parseObjectData.Item>
                    abstract member update: mode: obj -> unit
                    abstract member countVisibleElements: unit -> float

                module PolarAreaController =

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type getLabelAndValue =
                        abstract member label: obj with get, set
                        abstract member value: string with get, set
                        [<ParamObject; Emit("$0")>]
                        static member Create (label: obj, value: string) : getLabelAndValue = nativeOnly

                    module parseObjectData =

                        [<AllowNullLiteral>]
                        [<Interface>]
                        type Item =
                            abstract member r: obj with get, set
                            [<ParamObject; Emit("$0")>]
                            static member Create (r: obj) : Item = nativeOnly

            module controller_radar =

                [<AbstractClass>]
                [<Erase>]
                type Exports =
                    [<ImportDefault("chart.js"); EmitConstructor>]
                    static member RadarController () : RadarController = nativeOnly

                [<AllowNullLiteral>]
                [<Interface>]
                type RadarController =
                    inherit ChartJs.dist.core.core_datasetController.DatasetController
                    [<Emit("""import { RadarController } from "chart.js/dist/controllers/controller.radar.js";
RadarController.id{{=$0}}""")>]
                    static member inline id
                        with get () : string =
                            nativeOnly
                        and set (value: string) =
                            nativeOnly
                    [<Emit("""import { RadarController } from "chart.js/dist/controllers/controller.radar.js";
RadarController.overrides{{=$0}}""")>]
                    static member inline overrides
                        with get () : obj =
                            nativeOnly
                        and set (value: obj) =
                            nativeOnly
                    /// <summary>
                    /// Parse array of objects
                    /// </summary>
                    abstract member parseObjectData: meta: obj * data: obj * start: obj * count: obj -> ResizeArray<RadarController.parseObjectData.Item>
                    abstract member update: mode: obj -> unit

                module RadarController =

                    module parseObjectData =

                        [<AllowNullLiteral>]
                        [<Interface>]
                        type Item =
                            abstract member r: obj with get, set
                            [<ParamObject; Emit("$0")>]
                            static member Create (r: obj) : Item = nativeOnly

            module controller_scatter =

                [<AbstractClass>]
                [<Erase>]
                type Exports =
                    [<ImportDefault("chart.js"); EmitConstructor>]
                    static member ScatterController () : ScatterController = nativeOnly

                [<AllowNullLiteral>]
                [<Interface>]
                type ScatterController =
                    inherit ChartJs.dist.core.core_datasetController.DatasetController
                    [<Emit("""import { ScatterController } from "chart.js/dist/controllers/controller.scatter.js";
ScatterController.id{{=$0}}""")>]
                    static member inline id
                        with get () : string =
                            nativeOnly
                        and set (value: string) =
                            nativeOnly
                    [<Emit("""import { ScatterController } from "chart.js/dist/controllers/controller.scatter.js";
ScatterController.overrides{{=$0}}""")>]
                    static member inline overrides
                        with get () : obj =
                            nativeOnly
                        and set (value: obj) =
                            nativeOnly
                    abstract member update: mode: obj -> unit

            module Exports =

                type controller_bar =
                    controller_bar.Exports

                type controller_bubble =
                    controller_bubble.Exports

                type controller_doughnut =
                    controller_doughnut.Exports

                type controller_line =
                    controller_line.Exports

                type controller_pie =
                    controller_pie.Exports

                type controller_polarArea =
                    controller_polarArea.Exports

                type controller_radar =
                    controller_radar.Exports

                type controller_scatter =
                    controller_scatter.Exports

        module core =

            [<AbstractClass>]
            [<Erase>]
            type Exports =
                [<Import("Chart", "chart.js"); EmitConstructor>]
                static member Chart (item: obj, userConfig: obj) : Chart = nativeOnly

            type DateAdapter<'T> =
                ChartJs.DateAdapter<'T>

            type DateAdapter =
                DateAdapter<ChartJs.AnyObject>

            type TimeUnit =
                ChartJs.TimeUnit

            type Chart =
                ChartJs.dist.core.core_controller.Chart

            module core_animation =

                [<AbstractClass>]
                [<Erase>]
                type Exports =
                    [<ImportDefault("chart.js"); EmitConstructor>]
                    static member Animation (cfg: obj, target: obj, prop: obj, ``to``: obj) : Animation = nativeOnly

                [<AllowNullLiteral>]
                [<Interface>]
                type Animation =
                    abstract member _active: bool with get, set
                    abstract member _fn: obj with get, set
                    abstract member _easing: obj with get, set
                    abstract member _start: float with get, set
                    abstract member _duration: float with get, set
                    abstract member _total: float with get, set
                    abstract member _loop: bool with get, set
                    abstract member _target: obj with get, set
                    abstract member _prop: obj with get, set
                    abstract member _from: obj with get, set
                    abstract member _to: obj with get, set
                    abstract member _promises: ResizeArray<obj> with get, set
                    abstract member active: unit -> bool
                    abstract member update: cfg: obj * ``to``: obj * date: obj -> unit
                    abstract member cancel: unit -> unit
                    abstract member tick: date: obj -> unit
                    abstract member wait: unit -> JS.Promise<obj>
                    abstract member _notify: resolved: obj -> unit

            module core_animations =

                [<AbstractClass>]
                [<Erase>]
                type Exports =
                    [<ImportDefault("chart.js"); EmitConstructor>]
                    static member Animations (chart: obj, config: obj) : Animations = nativeOnly

                [<AllowNullLiteral>]
                [<Interface>]
                type Animations =
                    abstract member _chart: obj with get, set
                    abstract member _properties: obj with get, set
                    abstract member configure: config: obj -> unit
                    /// <summary>
                    /// Update <c>target</c> properties to new values, using configured animations
                    /// </summary>
                    /// <param name="target">
                    /// object to update
                    /// </param>
                    /// <param name="values">
                    /// new target properties
                    /// </param>
                    /// <returns>
                    /// - <c>true</c> if animations were started
                    /// </returns>
                    abstract member update: target: obj * values: obj -> bool option

            module core_controller =

                [<AbstractClass>]
                [<Erase>]
                type Exports =
                    [<Import("Chart", "chart.js"); EmitConstructor>]
                    static member Chart (item: obj, userConfig: obj) : Chart = nativeOnly

                type ChartEvent =
                    obj

                type Point =
                    obj

                [<AllowNullLiteral>]
                [<Interface>]
                type Chart =
                    [<Emit("""import { Chart } from "chart.js/dist/core/core.controller.js";
Chart.defaults{{=$0}}""")>]
                    static member inline defaults
                        with get () : ChartJs.dist.core.core_defaults.Defaults =
                            nativeOnly
                        and set (value: ChartJs.dist.core.core_defaults.Defaults) =
                            nativeOnly
                    [<Emit("""import { Chart } from "chart.js/dist/core/core.controller.js";
Chart.instances{{=$0}}""")>]
                    static member inline instances
                        with get () : obj =
                            nativeOnly
                        and set (value: obj) =
                            nativeOnly
                    [<Emit("""import { Chart } from "chart.js/dist/core/core.controller.js";
Chart.overrides{{=$0}}""")>]
                    static member inline overrides
                        with get () : obj =
                            nativeOnly
                        and set (value: obj) =
                            nativeOnly
                    [<Emit("""import { Chart } from "chart.js/dist/core/core.controller.js";
Chart.registry{{=$0}}""")>]
                    static member inline registry
                        with get () : ChartJs.dist.core.core_registry.Registry =
                            nativeOnly
                        and set (value: ChartJs.dist.core.core_registry.Registry) =
                            nativeOnly
                    [<Emit("""import { Chart } from "chart.js/dist/core/core.controller.js";
Chart.version{{=$0}}""")>]
                    static member inline version
                        with get () : string =
                            nativeOnly
                        and set (value: string) =
                            nativeOnly
                    [<Emit("""import { Chart } from "chart.js/dist/core/core.controller.js";
Chart.getChart{{=$0}}""")>]
                    static member inline getChart
                        with get () : (obj -> unit) =
                            nativeOnly
                        and set (value: (obj -> unit)) =
                            nativeOnly
                    [<Emit("""import { Chart } from "chart.js/dist/core/core.controller.js";
Chart.register($0)""")>]
                    static member inline register ([<ParamArray>] items: obj []): unit = nativeOnly
                    [<Emit("""import { Chart } from "chart.js/dist/core/core.controller.js";
Chart.unregister($0)""")>]
                    static member inline unregister ([<ParamArray>] items: obj []): unit = nativeOnly
                    abstract member config: ChartJs.Config with get, set
                    abstract member platform: obj with get, set
                    abstract member id: float with get, set
                    abstract member ctx: obj with get, set
                    abstract member canvas: obj with get, set
                    abstract member width: obj with get, set
                    abstract member height: obj with get, set
                    abstract member _options: obj with get, set
                    abstract member _aspectRatio: obj with get, set
                    abstract member _layers: ResizeArray<obj> with get, set
                    abstract member _metasets: ResizeArray<obj> with get, set
                    abstract member _stacks: obj with get, set
                    abstract member boxes: ResizeArray<obj> with get, set
                    abstract member currentDevicePixelRatio: obj with get, set
                    abstract member chartArea: obj with get, set
                    abstract member _active: ResizeArray<obj> with get, set
                    abstract member _lastEvent: ChartJs.ChartEvent with get, set
                    abstract member _listeners: obj with get, set
                    abstract member _responsiveListeners: Chart._responsiveListeners with get, set
                    abstract member _sortedMetasets: ResizeArray<obj> with get, set
                    abstract member scales: obj with get, set
                    abstract member _plugins: ChartJs.PluginService with get, set
                    abstract member ``$proxies``: obj with get, set
                    abstract member _hiddenIndices: obj with get, set
                    abstract member attached: bool with get, set
                    abstract member _animationsDisabled: bool with get, set
                    abstract member ``$context``: Chart._DOLLAR_context with get, set
                    abstract member _doResize: (obj option -> float) with get, set
                    abstract member _dataChanges: ResizeArray<obj> with get, set
                    abstract member aspectRatio: obj with get
                    abstract member data: obj with get, set
                    abstract member options: obj with get, set
                    abstract member clear: unit -> ChartJs.dist.core.core_controller.Chart
                    abstract member stop: unit -> ChartJs.dist.core.core_controller.Chart
                    /// <summary>
                    /// Resize the chart to its container or to explicit dimensions.
                    /// </summary>
                    /// <param name="width">
                    ///
                    /// </param>
                    /// <param name="height">
                    ///
                    /// </param>
                    abstract member resize: ?width: float * ?height: float -> unit
                    abstract member _resizeBeforeDraw: Chart._resizeBeforeDraw with get, set
                    abstract member _resize: width: obj * height: obj -> unit
                    abstract member ensureScalesHaveIDs: unit -> unit
                    /// <summary>
                    /// Builds a map of scale ID to scale object for future lookup.
                    /// </summary>
                    abstract member buildOrUpdateScales: unit -> unit
                    abstract member buildOrUpdateControllers: unit -> ResizeArray<obj>
                    /// <summary>
                    /// Resets the chart back to its state before the initial animation
                    /// </summary>
                    abstract member reset: unit -> unit
                    abstract member update: mode: obj -> unit
                    abstract member _minPadding: float with get, set
                    abstract member render: unit -> unit
                    abstract member draw: unit -> unit
                    /// <summary>
                    /// Gets the visible dataset metas in drawing order
                    /// </summary>
                    abstract member getSortedVisibleDatasetMetas: unit -> ResizeArray<obj>
                    /// <summary>
                    /// Checks whether the given point is in the chart area.
                    /// </summary>
                    /// <param name="point">
                    /// in relative coordinates (see, e.g., getRelativePosition)
                    /// </param>
                    abstract member isPointInArea: point: ChartJs.dist.core.core_controller.Point -> bool
                    abstract member getElementsAtEventForMode: e: obj * mode: obj * options: obj * useFinalPosition: obj -> obj
                    abstract member getDatasetMeta: datasetIndex: obj -> obj
                    abstract member getContext: unit -> Chart.getContext
                    abstract member getVisibleDatasetCount: unit -> float
                    abstract member isDatasetVisible: datasetIndex: obj -> bool
                    abstract member setDatasetVisibility: datasetIndex: obj * visible: obj -> unit
                    abstract member toggleDataVisibility: index: obj -> unit
                    abstract member getDataVisibility: index: obj -> bool
                    abstract member hide: datasetIndex: obj * dataIndex: obj -> unit
                    abstract member show: datasetIndex: obj * dataIndex: obj -> unit
                    abstract member _stop: unit -> unit
                    abstract member destroy: unit -> unit
                    abstract member toBase64Image: [<ParamArray>] args: obj [] -> obj
                    abstract member updateHoverStyle: items: obj * mode: obj * enabled: obj -> unit
                    /// <summary>
                    /// Get active (hovered) elements
                    /// </summary>
                    /// <returns>
                    /// array
                    /// </returns>
                    abstract member getActiveElements: unit -> ResizeArray<obj>
                    /// <summary>
                    /// Set active (hovered) elements
                    /// </summary>
                    /// <param name="activeElements">
                    /// New active data points
                    /// </param>
                    abstract member setActiveElements: activeElements: ResizeArray<obj> -> unit
                    /// <summary>
                    /// Calls enabled plugins on the specified hook and with the given args.
                    /// This method immediately returns as soon as a plugin explicitly returns false. The
                    /// returned value can be used, for instance, to interrupt the current action.
                    /// </summary>
                    /// <param name="hook">
                    /// The name of the plugin method to call (e.g. 'beforeUpdate').
                    /// </param>
                    /// <param name="args">
                    /// Extra arguments to apply to the hook call.
                    /// </param>
                    /// <param name="filter">
                    /// Filtering function for limiting which plugins are notified
                    /// </param>
                    /// <returns>
                    /// false if any of the plugins return false, else returns true.
                    /// </returns>
                    abstract member notifyPlugins: hook: string * ?args: obj * ?filter: ChartJs.filterCallback -> bool
                    /// <summary>
                    /// Check if a plugin with the specific ID is registered and enabled
                    /// </summary>
                    /// <param name="pluginId">
                    /// The ID of the plugin of which to check if it is enabled
                    /// </param>
                    abstract member isPluginEnabled: pluginId: string -> bool
                    /// <param name="e">
                    /// The event
                    /// </param>
                    /// <param name="lastActive">
                    /// Previously active elements
                    /// </param>
                    /// <param name="inChartArea">
                    /// Is the event inside chartArea
                    /// </param>
                    /// <param name="useFinalPosition">
                    /// Should the evaluation be done with current or final (after animation) element positions
                    /// </param>
                    /// <returns>
                    /// - The active elements
                    /// </returns>
                    abstract member _getActiveElements: e: ChartJs.dist.core.core_controller.ChartEvent * lastActive: ResizeArray<ChartJs.ActiveElement> * inChartArea: bool * useFinalPosition: bool -> ResizeArray<ChartJs.ActiveElement>

                module Chart =

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type _responsiveListeners =
                        abstract member attach: Action option with get, set
                        abstract member detach: Action option with get, set
                        abstract member resize: Action option with get, set
                        [<ParamObject; Emit("$0")>]
                        static member Create (?attach: Action, ?detach: Action, ?resize: Action) : _responsiveListeners = nativeOnly

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type _DOLLAR_context =
                        abstract member chart: ChartJs.dist.core.core_controller.Chart with get, set
                        abstract member ``type``: string with get, set
                        [<ParamObject; Emit("$0")>]
                        static member Create (chart: ChartJs.dist.core.core_controller.Chart, ``type``: string) : _DOLLAR_context = nativeOnly

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type _resizeBeforeDraw =
                        abstract member width: float with get, set
                        abstract member height: float with get, set
                        [<ParamObject; Emit("$0")>]
                        static member Create (width: float, height: float) : _resizeBeforeDraw = nativeOnly

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type getContext =
                        abstract member chart: ChartJs.dist.core.core_controller.Chart with get, set
                        abstract member ``type``: string with get, set
                        [<ParamObject; Emit("$0")>]
                        static member Create (chart: ChartJs.dist.core.core_controller.Chart, ``type``: string) : getContext = nativeOnly

            module core_datasetController =

                [<AbstractClass>]
                [<Erase>]
                type Exports =
                    /// <param name="chart">
                    ///
                    /// </param>
                    /// <param name="datasetIndex">
                    ///
                    /// </param>
                    [<ImportDefault("chart.js"); EmitConstructor>]
                    static member DatasetController (chart: ChartJs.dist.core.core_datasetController.Chart, datasetIndex: float) : DatasetController = nativeOnly

                [<AllowNullLiteral>]
                [<Interface>]
                type DatasetController =
                    [<Emit("""import { DatasetController } from "chart.js/dist/core/core.datasetController.js";
DatasetController.defaults{{=$0}}""")>]
                    static member inline defaults
                        with get () : obj =
                            nativeOnly
                        and set (value: obj) =
                            nativeOnly
                    /// <summary>
                    /// Element type used to generate a meta dataset (e.g. Chart.element.LineElement).
                    /// </summary>
                    [<Emit("""import { DatasetController } from "chart.js/dist/core/core.datasetController.js";
DatasetController.datasetElementType{{=$0}}""")>]
                    static member inline datasetElementType
                        with get () : obj =
                            nativeOnly
                        and set (value: obj) =
                            nativeOnly
                    /// <summary>
                    /// Element type used to generate a meta data (e.g. Chart.element.PointElement).
                    /// </summary>
                    [<Emit("""import { DatasetController } from "chart.js/dist/core/core.datasetController.js";
DatasetController.dataElementType{{=$0}}""")>]
                    static member inline dataElementType
                        with get () : obj =
                            nativeOnly
                        and set (value: obj) =
                            nativeOnly
                    abstract member chart: ChartJs.dist.core.core_controller.Chart with get, set
                    abstract member _ctx: obj with get, set
                    abstract member index: float with get, set
                    abstract member _cachedDataOpts: obj with get, set
                    abstract member _cachedMeta: obj with get, set
                    abstract member _type: obj with get, set
                    abstract member options: obj with get, set
                    abstract member _parsing: U2<bool, obj> with get, set
                    abstract member _data: obj with get, set
                    abstract member _objectData: obj with get, set
                    abstract member _sharedOptions: obj with get, set
                    abstract member _drawStart: obj with get, set
                    abstract member _drawCount: obj with get, set
                    abstract member enableOptionSharing: bool with get, set
                    abstract member supportsDecimation: bool with get, set
                    abstract member ``$context``: obj with get, set
                    abstract member _syncList: ResizeArray<obj> with get, set
                    abstract member initialize: unit -> unit
                    abstract member updateIndex: datasetIndex: obj -> unit
                    abstract member linkScales: unit -> unit
                    abstract member getDataset: unit -> obj
                    abstract member getMeta: unit -> obj
                    /// <param name="scaleID">
                    ///
                    /// </param>
                    abstract member getScaleForId: scaleID: string -> ChartJs.dist.core.core_datasetController.Scale
                    abstract member reset: unit -> unit
                    abstract member addElements: unit -> unit
                    abstract member buildOrUpdateElements: resetNewElements: obj -> unit
                    /// <param name="start">
                    ///
                    /// </param>
                    /// <param name="count">
                    ///
                    /// </param>
                    abstract member parse: start: float * count: float -> unit
                    abstract member getAllParsedValues: scale: obj -> ResizeArray<float>
                    /// <param name="mode">
                    ///
                    /// </param>
                    abstract member update: mode: string -> unit
                    abstract member draw: unit -> unit
                    /// <summary>
                    /// Returns a set of predefined style properties that should be used to represent the dataset
                    /// or the data if the index is specified
                    /// </summary>
                    /// <param name="index">
                    /// data index
                    /// </param>
                    /// <param name="active">
                    /// true if hover
                    /// </param>
                    /// <returns>
                    /// style object
                    /// </returns>
                    abstract member getStyle: index: float * ?active: bool -> obj
                    abstract member _getSharedOptions: start: obj * mode: obj -> DatasetController._getSharedOptions
                    abstract member removeHoverStyle: element: obj * datasetIndex: obj * index: obj -> unit
                    abstract member setHoverStyle: element: obj * datasetIndex: obj * index: obj -> unit
                    abstract member updateElements: element: obj * start: obj * count: obj * mode: obj -> unit
                    abstract member _onDataPush: [<ParamArray>] args: obj [] -> unit
                    abstract member _onDataPop: unit -> unit
                    abstract member _onDataShift: unit -> unit
                    abstract member _onDataSplice: start: obj * count: obj * [<ParamArray>] args: obj [] -> unit
                    abstract member _onDataUnshift: [<ParamArray>] args: obj [] -> unit

                type Chart =
                    obj

                type Scale =
                    obj

                module DatasetController =

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type _getSharedOptions =
                        abstract member sharedOptions: obj with get, set
                        abstract member includeOptions: bool with get, set
                        [<ParamObject; Emit("$0")>]
                        static member Create (sharedOptions: obj, includeOptions: bool) : _getSharedOptions = nativeOnly

            module core_defaults =

                [<AbstractClass>]
                [<Erase>]
                type Exports =
                    [<Import("Defaults", "chart.js"); EmitConstructor>]
                    static member Defaults (_descriptors: obj, _appliers: obj) : Defaults = nativeOnly

                /// <summary>
                /// Please use the module's default export which provides a singleton instance
                /// Note: class is exported for typedoc
                /// </summary>
                [<AllowNullLiteral>]
                [<Interface>]
                type Defaults =
                    abstract member animation: obj with get, set
                    abstract member backgroundColor: string with get, set
                    abstract member borderColor: string with get, set
                    abstract member color: string with get, set
                    abstract member datasets: obj with get, set
                    abstract member devicePixelRatio: (obj -> unit) with get, set
                    abstract member elements: obj with get, set
                    abstract member events: ResizeArray<string> with get, set
                    abstract member font: Defaults.font with get, set
                    abstract member hover: obj with get, set
                    abstract member hoverBackgroundColor: Defaults.hoverBackgroundColor with get, set
                    abstract member hoverBorderColor: Defaults.hoverBorderColor with get, set
                    abstract member hoverColor: Defaults.hoverColor with get, set
                    abstract member indexAxis: string with get, set
                    abstract member interaction: Defaults.interaction with get, set
                    abstract member maintainAspectRatio: bool with get, set
                    abstract member onHover: obj with get, set
                    abstract member onClick: obj with get, set
                    abstract member parsing: bool with get, set
                    abstract member plugins: obj with get, set
                    abstract member responsive: bool with get, set
                    abstract member scale: obj with get, set
                    abstract member scales: obj with get, set
                    abstract member showLine: bool with get, set
                    abstract member drawActiveElementsOnTop: bool with get, set
                    /// <param name="scope">
                    ///
                    /// </param>
                    /// <param name="values">
                    ///
                    /// </param>
                    abstract member set: scope: string * ?values: obj -> obj
                    /// <param name="scope">
                    ///
                    /// </param>
                    /// <param name="values">
                    ///
                    /// </param>
                    abstract member set: scope: obj * ?values: obj -> obj
                    /// <param name="scope">
                    ///
                    /// </param>
                    /// <param name="values">
                    ///
                    /// </param>
                    abstract member set: scope: U2<string, obj> * ?values: obj -> obj
                    /// <param name="scope">
                    ///
                    /// </param>
                    abstract member get: scope: string -> obj
                    /// <param name="scope">
                    ///
                    /// </param>
                    /// <param name="values">
                    ///
                    /// </param>
                    abstract member describe: scope: string * ?values: obj -> obj
                    /// <param name="scope">
                    ///
                    /// </param>
                    /// <param name="values">
                    ///
                    /// </param>
                    abstract member describe: scope: obj * ?values: obj -> obj
                    /// <param name="scope">
                    ///
                    /// </param>
                    /// <param name="values">
                    ///
                    /// </param>
                    abstract member describe: scope: U2<string, obj> * ?values: obj -> obj
                    abstract member ``override``: scope: obj * values: obj -> obj
                    /// <summary>
                    /// Routes the named defaults to fallback to another scope/name.
                    /// This routing is useful when those target values, like defaults.color, are changed runtime.
                    /// If the values would be copied, the runtime change would not take effect. By routing, the
                    /// fallback is evaluated at each access, so its always up to date.
                    ///
                    /// Example:
                    ///
                    /// 	defaults.route('elements.arc', 'backgroundColor', '', 'color')
                    ///   - reads the backgroundColor from defaults.color when undefined locally
                    /// </summary>
                    /// <param name="scope">
                    /// Scope this route applies to.
                    /// </param>
                    /// <param name="name">
                    /// Property name that should be routed to different namespace when not defined here.
                    /// </param>
                    /// <param name="targetScope">
                    /// The namespace where those properties should be routed to.
                    /// Empty string ('') is the root of defaults.
                    /// </param>
                    /// <param name="targetName">
                    /// The target name in the target scope the property should be routed to.
                    /// </param>
                    abstract member route: scope: string * name: string * targetScope: string * targetName: string -> unit
                    abstract member apply: appliers: obj -> unit

                module Defaults =

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type font =
                        abstract member family: string with get, set
                        abstract member size: float with get, set
                        abstract member style: string with get, set
                        abstract member lineHeight: float with get, set
                        abstract member weight: obj with get, set
                        [<ParamObject; Emit("$0")>]
                        static member Create (family: string, size: float, style: string, lineHeight: float, weight: obj) : font = nativeOnly

                    type hoverBackgroundColor =
                        delegate of ctx: obj * options: obj -> Glutinum.Web.CanvasGradient

                    type hoverBorderColor =
                        delegate of ctx: obj * options: obj -> Glutinum.Web.CanvasGradient

                    type hoverColor =
                        delegate of ctx: obj * options: obj -> Glutinum.Web.CanvasGradient

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type interaction =
                        abstract member mode: string with get, set
                        abstract member intersect: bool with get, set
                        abstract member includeInvisible: bool with get, set
                        [<ParamObject; Emit("$0")>]
                        static member Create (mode: string, intersect: bool, includeInvisible: bool) : interaction = nativeOnly

            module core_interaction =

                type Chart =
                    obj

                type ChartEvent =
                    obj

                [<AllowNullLiteral>]
                [<Interface>]
                type InteractionOptions =
                    abstract member axis: string option with get, set
                    abstract member intersect: bool option with get, set
                    abstract member includeInvisible: bool option with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (?axis: string, ?intersect: bool, ?includeInvisible: bool) : InteractionOptions = nativeOnly

                [<AllowNullLiteral>]
                [<Interface>]
                type InteractionItem =
                    abstract member datasetIndex: float with get, set
                    abstract member index: float with get, set
                    abstract member element: ChartJs.Element with get, set

                type Point =
                    obj

            module core_layouts =

                type Chart =
                    obj

                [<AllowNullLiteral>]
                [<Interface>]
                type LayoutItem =
                    /// <summary>
                    /// - The position of the item in the chart layout. Possible values are
                    /// 'left', 'top', 'right', 'bottom', and 'chartArea'
                    /// </summary>
                    abstract member position: string with get, set
                    /// <summary>
                    /// - The weight used to sort the item. Higher weights are further away from the chart area
                    /// </summary>
                    abstract member weight: float with get, set
                    /// <summary>
                    /// - if true, and the item is horizontal, then push vertical boxes down
                    /// </summary>
                    abstract member fullSize: bool with get, set
                    /// <summary>
                    /// - returns true if the layout item is horizontal (ie. top or bottom)
                    /// </summary>
                    abstract member isHorizontal: Action with get, set
                    /// <summary>
                    /// - Takes two parameters: width and height. Returns size of item
                    /// </summary>
                    abstract member update: Action with get, set
                    /// <summary>
                    /// - Draws the element
                    /// </summary>
                    abstract member draw: Action with get, set
                    /// <summary>
                    /// -  Returns an object with padding on the edges
                    /// </summary>
                    abstract member getPadding: Action option with get, set
                    /// <summary>
                    /// - Width of item. Must be valid after update()
                    /// </summary>
                    abstract member width: float with get, set
                    /// <summary>
                    /// - Height of item. Must be valid after update()
                    /// </summary>
                    abstract member height: float with get, set
                    /// <summary>
                    /// - Left edge of the item. Set by layout system and cannot be used in update
                    /// </summary>
                    abstract member left: float with get, set
                    /// <summary>
                    /// - Top edge of the item. Set by layout system and cannot be used in update
                    /// </summary>
                    abstract member top: float with get, set
                    /// <summary>
                    /// - Right edge of the item. Set by layout system and cannot be used in update
                    /// </summary>
                    abstract member right: float with get, set
                    /// <summary>
                    /// - Bottom edge of the item. Set by layout system and cannot be used in update
                    /// </summary>
                    abstract member bottom: float with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (position: string, weight: float, fullSize: bool, isHorizontal: Action, update: Action, draw: Action, width: float, height: float, left: float, top: float, right: float, bottom: float, ?getPadding: Action) : LayoutItem = nativeOnly

            module core_plugins =

                type Chart =
                    obj

                type ChartEvent =
                    obj

                type Tooltip =
                    obj

            module core_registry =

                [<AbstractClass>]
                [<Erase>]
                type Exports =
                    [<Import("Registry", "chart.js"); EmitConstructor>]
                    static member Registry () : Registry = nativeOnly

                /// <summary>
                /// Please use the module's default export which provides a singleton instance
                /// Note: class is exported for typedoc
                /// </summary>
                [<AllowNullLiteral>]
                [<Interface>]
                type Registry =
                    abstract member controllers: ChartJs.dist.core.core_typedRegistry.TypedRegistry with get, set
                    abstract member elements: ChartJs.dist.core.core_typedRegistry.TypedRegistry with get, set
                    abstract member plugins: ChartJs.dist.core.core_typedRegistry.TypedRegistry with get, set
                    abstract member scales: ChartJs.dist.core.core_typedRegistry.TypedRegistry with get, set
                    abstract member _typedRegistries: ResizeArray<ChartJs.dist.core.core_typedRegistry.TypedRegistry> with get, set
                    /// <param name="args">
                    ///
                    /// </param>
                    abstract member add: [<ParamArray>] args: obj [] -> unit
                    abstract member remove: [<ParamArray>] args: obj [] -> unit
                    /// <param name="args">
                    ///
                    /// </param>
                    abstract member addControllers: [<ParamArray>] args: ChartJs.dist.core.core_datasetController.DatasetController [] -> unit
                    /// <param name="args">
                    ///
                    /// </param>
                    abstract member addElements: [<ParamArray>] args: ChartJs.Element<obj, obj> [] -> unit
                    /// <param name="args">
                    ///
                    /// </param>
                    abstract member addPlugins: [<ParamArray>] args: obj [] -> unit
                    /// <param name="args">
                    ///
                    /// </param>
                    abstract member addScales: [<ParamArray>] args: ChartJs.dist.core.core_scale.Scale [] -> unit
                    /// <param name="id">
                    ///
                    /// </param>
                    abstract member getController: id: string -> ChartJs.dist.core.core_datasetController.DatasetController
                    /// <param name="id">
                    ///
                    /// </param>
                    abstract member getElement: id: string -> ChartJs.Element<obj, obj>
                    /// <param name="id">
                    ///
                    /// </param>
                    abstract member getPlugin: id: string -> obj
                    /// <param name="id">
                    ///
                    /// </param>
                    abstract member getScale: id: string -> ChartJs.dist.core.core_scale.Scale
                    /// <param name="args">
                    ///
                    /// </param>
                    abstract member removeControllers: [<ParamArray>] args: ChartJs.dist.core.core_datasetController.DatasetController [] -> unit
                    /// <param name="args">
                    ///
                    /// </param>
                    abstract member removeElements: [<ParamArray>] args: ChartJs.Element<obj, obj> [] -> unit
                    /// <param name="args">
                    ///
                    /// </param>
                    abstract member removePlugins: [<ParamArray>] args: obj [] -> unit
                    /// <param name="args">
                    ///
                    /// </param>
                    abstract member removeScales: [<ParamArray>] args: ChartJs.dist.core.core_scale.Scale [] -> unit

            module core_scale =

                [<AbstractClass>]
                [<Erase>]
                type Exports =
                    [<ImportDefault("chart.js"); EmitConstructor>]
                    static member Scale (cfg: obj) : Scale = nativeOnly

                [<AllowNullLiteral>]
                [<Interface>]
                type Scale =
                    inherit ChartJs.Element<ChartJs.AnyObject, ChartJs.AnyObject>
                    abstract member id: string with get, set
                    abstract member ``type``: string with get, set
                    abstract member options: obj with get, set
                    abstract member ctx: Glutinum.Web.CanvasRenderingContext2D with get, set
                    abstract member chart: ChartJs.dist.core.core_scale.Chart with get, set
                    abstract member top: float with get, set
                    abstract member bottom: float with get, set
                    abstract member left: float with get, set
                    abstract member right: float with get, set
                    abstract member width: float with get, set
                    abstract member height: float with get, set
                    abstract member _margins: Scale._margins with get, set
                    abstract member maxWidth: float with get, set
                    abstract member maxHeight: float with get, set
                    abstract member paddingTop: float with get, set
                    abstract member paddingBottom: float with get, set
                    abstract member paddingLeft: float with get, set
                    abstract member paddingRight: float with get, set
                    abstract member axis: string option with get, set
                    abstract member labelRotation: float option with get, set
                    abstract member min: obj with get, set
                    abstract member max: obj with get, set
                    abstract member _range: Scale._range with get, set
                    abstract member ticks: ResizeArray<ChartJs.dist.core.core_scale.Tick> with get, set
                    abstract member _gridLineItems: ResizeArray<obj> option with get, set
                    abstract member _labelItems: ResizeArray<obj> option with get, set
                    abstract member _labelSizes: obj option with get, set
                    abstract member _length: float with get, set
                    abstract member _maxLength: float with get, set
                    abstract member _longestTextCache: obj with get, set
                    abstract member _startPixel: float with get, set
                    abstract member _endPixel: float with get, set
                    abstract member _reversePixels: bool with get, set
                    abstract member _userMax: obj with get, set
                    abstract member _userMin: obj with get, set
                    abstract member _suggestedMax: obj with get, set
                    abstract member _suggestedMin: obj with get, set
                    abstract member _ticksLength: float with get, set
                    abstract member _borderValue: float with get, set
                    abstract member _cache: obj with get, set
                    abstract member _dataLimitsCached: bool with get, set
                    abstract member ``$context``: obj with get, set
                    /// <param name="options">
                    ///
                    /// </param>
                    abstract member init: options: obj -> unit
                    /// <summary>
                    /// Parse a supported input value to internal representation.
                    /// </summary>
                    /// <param name="raw">
                    ///
                    /// </param>
                    /// <param name="index">
                    ///
                    /// </param>
                    abstract member parse: raw: obj * ?index: float -> obj
                    /// <summary>
                    /// Returns the scale tick objects
                    /// </summary>
                    abstract member getTicks: unit -> ResizeArray<ChartJs.dist.core.core_scale.Tick>
                    abstract member getLabels: unit -> ResizeArray<string>
                    abstract member getLabelItems: ?chartArea: ChartJs.ChartArea -> ResizeArray<ChartJs.LabelItem>
                    abstract member beforeLayout: unit -> unit
                    abstract member beforeUpdate: unit -> unit
                    /// <param name="maxWidth">
                    /// the max width in pixels
                    /// </param>
                    /// <param name="maxHeight">
                    /// the max height in pixels
                    /// </param>
                    /// <param name="margins">
                    /// the space between the edge of the other scales and edge of the chart
                    /// This space comes from two sources:
                    /// - padding - space that's required to show the labels at the edges of the scale
                    /// - thickness of scales or legends in another orientation
                    /// </param>
                    abstract member update: maxWidth: float * maxHeight: float * margins: Scale.update.margins -> unit
                    abstract member _alignToPixels: obj with get, set
                    abstract member afterUpdate: unit -> unit
                    abstract member beforeSetDimensions: unit -> unit
                    abstract member setDimensions: unit -> unit
                    abstract member afterSetDimensions: unit -> unit
                    abstract member _callHooks: name: obj -> unit
                    abstract member beforeDataLimits: unit -> unit
                    abstract member determineDataLimits: unit -> unit
                    abstract member afterDataLimits: unit -> unit
                    abstract member beforeBuildTicks: unit -> unit
                    /// <returns>
                    /// the ticks
                    /// </returns>
                    abstract member buildTicks: unit -> ResizeArray<obj>
                    abstract member afterBuildTicks: unit -> unit
                    abstract member beforeTickToLabelConversion: unit -> unit
                    /// <summary>
                    /// Convert ticks to label strings
                    /// </summary>
                    /// <param name="ticks">
                    ///
                    /// </param>
                    abstract member generateTickLabels: ticks: ResizeArray<ChartJs.dist.core.core_scale.Tick> -> unit
                    abstract member afterTickToLabelConversion: unit -> unit
                    abstract member beforeCalculateLabelRotation: unit -> unit
                    abstract member calculateLabelRotation: unit -> unit
                    abstract member afterCalculateLabelRotation: unit -> unit
                    abstract member afterAutoSkip: unit -> unit
                    abstract member beforeFit: unit -> unit
                    abstract member fit: unit -> unit
                    abstract member _calculatePadding: first: obj * last: obj * sin: obj * cos: obj -> unit
                    abstract member afterFit: unit -> unit
                    abstract member isHorizontal: unit -> bool
                    abstract member isFullSize: unit -> bool
                    /// <summary>
                    /// Used to get the label to display in the tooltip for the given value
                    /// </summary>
                    /// <param name="value">
                    ///
                    /// </param>
                    abstract member getLabelForValue: value: obj -> string
                    /// <summary>
                    /// Returns the location of the given data point. Value can either be an index or a numerical value
                    /// The coordinate (0, 0) is at the upper-left corner of the canvas
                    /// </summary>
                    /// <param name="value">
                    ///
                    /// </param>
                    /// <param name="index">
                    ///
                    /// </param>
                    abstract member getPixelForValue: value: obj * ?index: float -> float
                    /// <summary>
                    /// Used to get the data value from a given pixel. This is the inverse of getPixelForValue
                    /// The coordinate (0, 0) is at the upper-left corner of the canvas
                    /// </summary>
                    /// <param name="pixel">
                    ///
                    /// </param>
                    abstract member getValueForPixel: pixel: float -> obj
                    /// <summary>
                    /// Returns the location of the tick at the given index
                    /// The coordinate (0, 0) is at the upper-left corner of the canvas
                    /// </summary>
                    /// <param name="index">
                    ///
                    /// </param>
                    abstract member getPixelForTick: index: float -> float
                    /// <summary>
                    /// Utility for getting the pixel location of a percentage of scale
                    /// The coordinate (0, 0) is at the upper-left corner of the canvas
                    /// </summary>
                    /// <param name="decimal">
                    ///
                    /// </param>
                    abstract member getPixelForDecimal: decimal: float -> float
                    /// <param name="pixel">
                    ///
                    /// </param>
                    abstract member getDecimalForPixel: pixel: float -> float
                    /// <summary>
                    /// Returns the pixel for the minimum chart value
                    /// The coordinate (0, 0) is at the upper-left corner of the canvas
                    /// </summary>
                    abstract member getBasePixel: unit -> float
                    abstract member getBaseValue: unit -> float
                    abstract member _getXAxisLabelAlignment: unit -> string
                    abstract member _getYAxisLabelAlignment: tl: obj -> Scale._getYAxisLabelAlignment
                    abstract member getLineWidthForValue: value: obj -> obj
                    abstract member draw: chartArea: obj -> unit
                    /// <summary>
                    /// Returns visible dataset metas that are attached to this scale
                    /// </summary>
                    /// <param name="type">
                    /// if specified, also filter by dataset type
                    /// </param>
                    abstract member getMatchingVisibleMetas: ?``type``: string -> ResizeArray<obj>

                type Chart =
                    obj

                [<AllowNullLiteral>]
                [<Interface>]
                type Tick =
                    abstract member value: U2<float, string> with get, set
                    abstract member label: string option with get, set
                    abstract member major: bool option with get, set
                    abstract member ``$context``: obj option with get, set

                module Scale =

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type _margins =
                        abstract member left: float with get, set
                        abstract member right: float with get, set
                        abstract member top: float with get, set
                        abstract member bottom: float with get, set
                        [<ParamObject; Emit("$0")>]
                        static member Create (left: float, right: float, top: float, bottom: float) : _margins = nativeOnly

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type _range =
                        abstract member min: float with get, set
                        abstract member max: float with get, set
                        [<ParamObject; Emit("$0")>]
                        static member Create (min: float, max: float) : _range = nativeOnly

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type _getYAxisLabelAlignment =
                        abstract member textAlign: string with get, set
                        abstract member x: obj with get, set
                        [<ParamObject; Emit("$0")>]
                        static member Create (textAlign: string, x: obj) : _getYAxisLabelAlignment = nativeOnly

                    module update =

                        [<AllowNullLiteral>]
                        [<Interface>]
                        type margins =
                            abstract member top: float with get, set
                            abstract member left: float with get, set
                            abstract member bottom: float with get, set
                            abstract member right: float with get, set
                            [<ParamObject; Emit("$0")>]
                            static member Create (top: float, left: float, bottom: float, right: float) : margins = nativeOnly

            module core_typedRegistry =

                [<AbstractClass>]
                [<Erase>]
                type Exports =
                    [<ImportDefault("chart.js"); EmitConstructor>]
                    static member TypedRegistry (``type``: obj, scope: obj, ``override``: obj) : TypedRegistry = nativeOnly

                [<AllowNullLiteral>]
                [<Interface>]
                type TypedRegistry =
                    abstract member ``type``: obj with get, set
                    abstract member scope: obj with get, set
                    abstract member ``override``: obj with get, set
                    abstract member items: obj with get, set
                    abstract member isForType: ``type``: obj -> bool
                    /// <param name="item">
                    ///
                    /// </param>
                    /// <returns>
                    /// The scope where items defaults were registered to.
                    /// </returns>
                    abstract member register: item: ChartJs.IChartComponent -> string
                    /// <param name="id">
                    ///
                    /// </param>
                    abstract member get: id: string -> obj option
                    /// <param name="item">
                    ///
                    /// </param>
                    abstract member unregister: item: ChartJs.IChartComponent -> unit

        module elements =

            module element_bar =

                [<AbstractClass>]
                [<Erase>]
                type Exports =
                    [<ImportDefault("chart.js"); EmitConstructor>]
                    static member BarElement (cfg: obj) : BarElement = nativeOnly

                [<AllowNullLiteral>]
                [<Interface>]
                type BarElement =
                    inherit ChartJs.Element<ChartJs.AnyObject, ChartJs.AnyObject>
                    [<Emit("""import { BarElement } from "chart.js/dist/elements/element.bar.js";
BarElement.id{{=$0}}""")>]
                    static member inline id
                        with get () : string =
                            nativeOnly
                        and set (value: string) =
                            nativeOnly
                    [<Emit("""import { BarElement } from "chart.js/dist/elements/element.bar.js";
BarElement.defaults{{=$0}}""")>]
                    static member inline defaults
                        with get () : obj =
                            nativeOnly
                        and set (value: obj) =
                            nativeOnly
                    abstract member options: obj with get, set
                    abstract member horizontal: obj with get, set
                    abstract member ``base``: obj with get, set
                    abstract member width: obj with get, set
                    abstract member height: obj with get, set
                    abstract member inflateAmount: obj with get, set
                    abstract member draw: ctx: obj -> unit
                    abstract member inRange: mouseX: obj * mouseY: obj * useFinalPosition: obj -> bool
                    abstract member inXRange: mouseX: obj * useFinalPosition: obj -> bool
                    abstract member inYRange: mouseY: obj * useFinalPosition: obj -> bool
                    abstract member getCenterPoint: useFinalPosition: obj -> BarElement.getCenterPoint
                    abstract member getRange: axis: obj -> float

                [<AllowNullLiteral>]
                [<Interface>]
                type BarProps =
                    abstract member x: float with get, set
                    abstract member y: float with get, set
                    abstract member ``base``: float with get, set
                    abstract member horizontal: bool with get, set
                    abstract member width: float with get, set
                    abstract member height: float with get, set

                module BarElement =

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type getCenterPoint =
                        abstract member x: float with get, set
                        abstract member y: float with get, set
                        [<ParamObject; Emit("$0")>]
                        static member Create (x: float, y: float) : getCenterPoint = nativeOnly

            module element_line =

                [<AbstractClass>]
                [<Erase>]
                type Exports =
                    [<ImportDefault("chart.js"); EmitConstructor>]
                    static member LineElement (cfg: obj) : LineElement = nativeOnly

                [<AllowNullLiteral>]
                [<Interface>]
                type LineElement =
                    inherit ChartJs.Element<ChartJs.AnyObject, ChartJs.AnyObject>
                    [<Emit("""import { LineElement } from "chart.js/dist/elements/element.line.js";
LineElement.id{{=$0}}""")>]
                    static member inline id
                        with get () : string =
                            nativeOnly
                        and set (value: string) =
                            nativeOnly
                    [<Emit("""import { LineElement } from "chart.js/dist/elements/element.line.js";
LineElement.defaults{{=$0}}""")>]
                    static member inline defaults
                        with get () : obj =
                            nativeOnly
                        and set (value: obj) =
                            nativeOnly
                    [<Emit("""import { LineElement } from "chart.js/dist/elements/element.line.js";
LineElement.descriptors{{=$0}}""")>]
                    static member inline descriptors
                        with get () : LineElement.descriptors__ =
                            nativeOnly
                        and set (value: LineElement.descriptors__) =
                            nativeOnly
                    abstract member animated: bool with get, set
                    abstract member options: obj with get, set
                    abstract member _chart: obj with get, set
                    abstract member _loop: obj with get, set
                    abstract member _fullLoop: obj with get, set
                    abstract member _path: obj with get, set
                    abstract member _points: obj with get, set
                    abstract member _segments: ResizeArray<ChartJs.helpers.Segment> with get, set
                    abstract member _decimated: bool with get, set
                    abstract member _pointsUpdated: bool with get, set
                    abstract member _datasetIndex: obj with get, set
                    abstract member updateControlPoints: chartArea: obj * indexAxis: obj -> unit
                    abstract member points: obj with get, set
                    abstract member segments: ResizeArray<ChartJs.helpers.Segment> with get
                    /// <summary>
                    /// First non-skipped point on this line
                    /// </summary>
                    abstract member first: unit -> ChartJs.dist.elements.element_line.PointElement option
                    /// <summary>
                    /// Last non-skipped point on this line
                    /// </summary>
                    abstract member last: unit -> ChartJs.dist.elements.element_line.PointElement option
                    /// <summary>
                    /// Interpolate a point in this line at the same value on <c>property</c> as
                    /// the reference <c>point</c> provided
                    /// </summary>
                    /// <param name="point">
                    /// the reference point
                    /// </param>
                    /// <param name="property">
                    /// the property to match on
                    /// </param>
                    abstract member interpolate: point: ChartJs.dist.elements.element_line.PointElement * property: string -> ChartJs.dist.elements.element_line.PointElement option
                    /// <summary>
                    /// Append a segment of this line to current path.
                    /// </summary>
                    /// <param name="ctx">
                    ///
                    /// </param>
                    /// <param name="segment">
                    ///
                    /// </param>
                    /// <param name="params">
                    ///
                    /// </param>
                    /// <returns>
                    /// - true if the segment is a full loop (path should be closed)
                    /// </returns>
                    abstract member pathSegment: ctx: Glutinum.Web.CanvasRenderingContext2D * segment: LineElement.pathSegment.segment * ``params``: LineElement.pathSegment.``params`` -> bool option
                    /// <summary>
                    /// Append all segments of this line to current path.
                    /// </summary>
                    /// <param name="ctx">
                    ///
                    /// </param>
                    /// <param name="start">
                    ///
                    /// </param>
                    /// <param name="count">
                    ///
                    /// </param>
                    /// <returns>
                    /// - true if line is a full loop (path should be closed)
                    /// </returns>
                    abstract member path: ctx: Glutinum.Web.CanvasRenderingContext2D * ?start: float * ?count: float -> bool option
                    /// <summary>
                    /// Append all segments of this line to current path.
                    /// </summary>
                    /// <param name="ctx">
                    ///
                    /// </param>
                    /// <param name="start">
                    ///
                    /// </param>
                    /// <param name="count">
                    ///
                    /// </param>
                    /// <returns>
                    /// - true if line is a full loop (path should be closed)
                    /// </returns>
                    abstract member path: ctx: Glutinum.Web.Path2D * ?start: float * ?count: float -> bool option
                    /// <summary>
                    /// Append all segments of this line to current path.
                    /// </summary>
                    /// <param name="ctx">
                    ///
                    /// </param>
                    /// <param name="start">
                    ///
                    /// </param>
                    /// <param name="count">
                    ///
                    /// </param>
                    /// <returns>
                    /// - true if line is a full loop (path should be closed)
                    /// </returns>
                    abstract member path: ctx: U2<Glutinum.Web.CanvasRenderingContext2D, Glutinum.Web.Path2D> * ?start: float * ?count: float -> bool option
                    /// <summary>
                    /// Draw
                    /// </summary>
                    /// <param name="ctx">
                    ///
                    /// </param>
                    /// <param name="chartArea">
                    ///
                    /// </param>
                    /// <param name="start">
                    ///
                    /// </param>
                    /// <param name="count">
                    ///
                    /// </param>
                    abstract member draw: ctx: Glutinum.Web.CanvasRenderingContext2D * chartArea: obj * ?start: float * ?count: float -> unit

                type PointElement =
                    obj

                module LineElement =

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type descriptors__ =
                        abstract member _scriptable: bool with get, set
                        abstract member _indexable: (obj -> bool) with get, set
                        [<ParamObject; Emit("$0")>]
                        static member Create (_scriptable: bool, _indexable: (obj -> bool)) : descriptors__ = nativeOnly

                    module pathSegment =

                        [<AllowNullLiteral>]
                        [<Interface>]
                        type segment =
                            abstract member start: float with get, set
                            abstract member ``end``: float with get, set
                            abstract member loop: bool with get, set
                            [<ParamObject; Emit("$0")>]
                            static member Create (start: float, ``end``: float, loop: bool) : segment = nativeOnly

                        [<AllowNullLiteral>]
                        [<Interface>]
                        type ``params`` =
                            abstract member move: bool with get, set
                            abstract member reverse: bool with get, set
                            abstract member start: float with get, set
                            abstract member ``end``: float with get, set
                            [<ParamObject; Emit("$0")>]
                            static member Create (move: bool, reverse: bool, start: float, ``end``: float) : ``params`` = nativeOnly

            module Exports =

                type element_bar =
                    element_bar.Exports

                type element_line =
                    element_line.Exports

        module helpers =

            [<AbstractClass>]
            [<Erase>]
            type Exports =
                [<Import("isPatternOrGradient", "chart.js/helpers")>]
                static member isPatternOrGradient (value: obj) : bool = nativeOnly
                [<Import("color", "chart.js/helpers")>]
                static member color (value: Glutinum.Web.CanvasGradient) : Glutinum.Web.CanvasGradient = nativeOnly
                [<Import("color", "chart.js/helpers")>]
                static member color (value: Glutinum.Web.CanvasPattern) : Glutinum.Web.CanvasPattern = nativeOnly
                [<Import("color", "chart.js/helpers")>]
                static member color (value: string) : KurkleColor.Color = nativeOnly
                [<Import("color", "chart.js/helpers")>]
                static member color (value: Exports.color__.value) : KurkleColor.Color = nativeOnly
                [<Import("color", "chart.js/helpers")>]
                static member color (value: (float * float * float)) : KurkleColor.Color = nativeOnly
                [<Import("color", "chart.js/helpers")>]
                static member color (value: (float * float * float * float)) : KurkleColor.Color = nativeOnly
                [<Import("color", "chart.js/helpers")>]
                static member color (value: U4<string, Exports.color__.value, float * float * float, float * float * float * float>) : KurkleColor.Color = nativeOnly
                [<Import("getHoverColor", "chart.js/helpers")>]
                static member getHoverColor (value: Glutinum.Web.CanvasGradient) : Glutinum.Web.CanvasGradient = nativeOnly
                [<Import("getHoverColor", "chart.js/helpers")>]
                static member getHoverColor (value: Glutinum.Web.CanvasPattern) : Glutinum.Web.CanvasPattern = nativeOnly
                [<Import("getHoverColor", "chart.js/helpers")>]
                static member getHoverColor (value: string) : string = nativeOnly
                /// <summary>
                /// An empty function that can be used, for example, for optional callback.
                /// </summary>
                [<Import("noop", "chart.js/helpers")>]
                static member noop () : unit = nativeOnly
                /// <summary>
                /// Returns true if <c>value</c> is neither null nor undefined, else returns false.
                /// </summary>
                /// <param name="value">
                /// The value to test.
                /// </param>
                [<Import("isNullOrUndef", "chart.js/helpers")>]
                static member isNullOrUndef (value: obj) : bool = nativeOnly
                /// <summary>
                /// Returns true if <c>value</c> is an array (including typed arrays), else returns false.
                /// </summary>
                /// <param name="value">
                /// The value to test.
                /// </param>
                [<Import("isArray", "chart.js/helpers")>]
                static member isArray<'T> (value: obj) : bool = nativeOnly
                /// <summary>
                /// Returns true if <c>value</c> is an object (excluding null), else returns false.
                /// </summary>
                /// <param name="value">
                /// The value to test.
                /// </param>
                [<Import("isObject", "chart.js/helpers")>]
                static member isObject (value: obj) : bool = nativeOnly
                /// <summary>
                /// Returns <c>value</c> if finite, else returns <c>defaultValue</c>.
                /// </summary>
                /// <param name="value">
                /// The value to return if defined.
                /// </param>
                /// <param name="defaultValue">
                /// The value to return if <c>value</c> is not finite.
                /// </param>
                [<Import("finiteOrDefault", "chart.js/helpers")>]
                static member finiteOrDefault (value: obj, defaultValue: float) : float = nativeOnly
                /// <summary>
                /// Returns <c>value</c> if defined, else returns <c>defaultValue</c>.
                /// </summary>
                /// <param name="value">
                /// The value to return if defined.
                /// </param>
                /// <param name="defaultValue">
                /// The value to return if <c>value</c> is undefined.
                /// </param>
                [<Import("valueOrDefault", "chart.js/helpers")>]
                static member valueOrDefault<'T> (value: 'T option, defaultValue: 'T) : 'T = nativeOnly
                /// <summary>
                /// Calls <c>fn</c> with the given <c>args</c> in the scope defined by <c>thisArg</c> and returns the
                /// value returned by <c>fn</c>. If <c>fn</c> is not a function, this method returns undefined.
                /// </summary>
                /// <param name="fn">
                /// The function to call.
                /// </param>
                /// <param name="args">
                /// The arguments with which <c>fn</c> should be called.
                /// </param>
                /// <param name="thisArg">
                /// The value of <c>this</c> provided for the call to <c>fn</c>.
                /// </param>
                [<Import("callback", "chart.js/helpers")>]
                static member callback<'T, 'TA, 'R> (fn: 'T option, args: ResizeArray<obj>, ?thisArg: 'TA) : 'R option = nativeOnly
                /// <summary>
                /// Note(SB) for performance sake, this method should only be used when loopable type
                /// is unknown or in none intensive code (not called often and small loopable). Else
                /// it's preferable to use a regular for() loop and save extra function calls.
                /// </summary>
                /// <param name="loopable">
                /// The object or array to be iterated.
                /// </param>
                /// <param name="fn">
                /// The function to call for each item.
                /// </param>
                /// <param name="thisArg">
                /// The value of <c>this</c> provided for the call to <c>fn</c>.
                /// </param>
                /// <param name="reverse">
                /// If true, iterates backward on the loopable.
                /// </param>
                [<Import("each", "chart.js/helpers")>]
                static member each<'T, 'TA> (loopable: Exports.each__.loopable<'T>, fn: Exports.each__.fn<'T>, ?thisArg: 'TA, ?reverse: bool) : unit = nativeOnly
                [<Import("each", "chart.js/helpers")>]
                static member each<'T, 'TA> (loopable: ResizeArray<'T>, fn: Exports.each__.fn_1<'T>, ?thisArg: 'TA, ?reverse: bool) : unit = nativeOnly
                /// <summary>
                /// Returns true if the <c>a0</c> and <c>a1</c> arrays have the same content, else returns false.
                /// </summary>
                /// <param name="a0">
                /// The array to compare
                /// </param>
                /// <param name="a1">
                /// The array to compare
                /// </param>
                [<Import("_elementsEqual", "chart.js/helpers")>]
                static member _elementsEqual (a0: ResizeArray<ChartJs.ActiveDataPoint>, a1: ResizeArray<ChartJs.ActiveDataPoint>) : bool = nativeOnly
                /// <summary>
                /// Returns a deep copy of <c>source</c> without keeping references on objects and arrays.
                /// </summary>
                /// <param name="source">
                /// The value to clone.
                /// </param>
                [<Import("clone", "chart.js/helpers")>]
                static member clone<'T> (source: 'T) : 'T = nativeOnly
                /// <summary>
                /// The default merger when Chart.helpers.merge is called without merger option.
                /// Note(SB): also used by mergeConfig and mergeScaleConfig as fallback.
                /// </summary>
                [<Import("_merger", "chart.js/helpers")>]
                static member _merger (key: string, target: ChartJs.AnyObject, source: ChartJs.AnyObject, options: ChartJs.AnyObject) : unit = nativeOnly
                /// <summary>
                /// Recursively deep copies <c>source</c> properties into <c>target</c> with the given <c>options</c>.
                /// IMPORTANT: <c>target</c> is not cloned and will be updated with <c>source</c> properties.
                /// </summary>
                /// <param name="target">
                /// The target object in which all sources are merged into.
                /// </param>
                /// <param name="source">
                /// Object(s) to merge into <c>target</c>.
                /// </param>
                /// <param name="options">
                /// Merging options:
                /// </param>
                /// <param name="options.merger">
                /// The merge method (key, target, source, options)
                /// </param>
                /// <returns>
                /// The <c>target</c> object.
                /// </returns>
                [<Import("merge", "chart.js/helpers")>]
                static member merge<'T> (target: 'T, source: obj, ?options: ChartJs.helpers.MergeOptions) : 'T = nativeOnly
                [<Import("merge", "chart.js/helpers")>]
                static member merge<'T, 'S1> (target: 'T, source: ResizeArray<'S1>, ?options: ChartJs.helpers.MergeOptions) : obj = nativeOnly
                [<Import("merge", "chart.js/helpers")>]
                static member merge<'T, 'S1, 'S2> (target: 'T, source: ('S1 * 'S2), ?options: ChartJs.helpers.MergeOptions) : obj = nativeOnly
                [<Import("merge", "chart.js/helpers")>]
                static member merge<'T, 'S1, 'S2, 'S3> (target: 'T, source: ('S1 * 'S2 * 'S3), ?options: ChartJs.helpers.MergeOptions) : obj = nativeOnly
                [<Import("merge", "chart.js/helpers")>]
                static member merge<'T, 'S1, 'S2, 'S3, 'S4> (target: 'T, source: ('S1 * 'S2 * 'S3 * 'S4), ?options: ChartJs.helpers.MergeOptions) : obj = nativeOnly
                [<Import("merge", "chart.js/helpers")>]
                static member merge<'T> (target: 'T, source: ResizeArray<ChartJs.AnyObject>, ?options: ChartJs.helpers.MergeOptions) : ChartJs.AnyObject = nativeOnly
                /// <summary>
                /// Recursively deep copies <c>source</c> properties into <c>target</c> *only* if not defined in target.
                /// IMPORTANT: <c>target</c> is not cloned and will be updated with <c>source</c> properties.
                /// </summary>
                /// <param name="target">
                /// The target object in which all sources are merged into.
                /// </param>
                /// <param name="source">
                /// Object(s) to merge into <c>target</c>.
                /// </param>
                /// <returns>
                /// The <c>target</c> object.
                /// </returns>
                [<Import("mergeIf", "chart.js/helpers")>]
                static member mergeIf<'T> (target: 'T, source: obj) : 'T = nativeOnly
                [<Import("mergeIf", "chart.js/helpers")>]
                static member mergeIf<'T, 'S1> (target: 'T, source: ResizeArray<'S1>) : obj = nativeOnly
                [<Import("mergeIf", "chart.js/helpers")>]
                static member mergeIf<'T, 'S1, 'S2> (target: 'T, source: ('S1 * 'S2)) : obj = nativeOnly
                [<Import("mergeIf", "chart.js/helpers")>]
                static member mergeIf<'T, 'S1, 'S2, 'S3> (target: 'T, source: ('S1 * 'S2 * 'S3)) : obj = nativeOnly
                [<Import("mergeIf", "chart.js/helpers")>]
                static member mergeIf<'T, 'S1, 'S2, 'S3, 'S4> (target: 'T, source: ('S1 * 'S2 * 'S3 * 'S4)) : obj = nativeOnly
                [<Import("mergeIf", "chart.js/helpers")>]
                static member mergeIf<'T> (target: 'T, source: ResizeArray<ChartJs.AnyObject>) : ChartJs.AnyObject = nativeOnly
                /// <summary>
                /// Merges source[key] in target[key] only if target[key] is undefined.
                /// </summary>
                [<Import("_mergerIf", "chart.js/helpers")>]
                static member _mergerIf (key: string, target: ChartJs.AnyObject, source: ChartJs.AnyObject) : unit = nativeOnly
                [<Import("_deprecated", "chart.js/helpers")>]
                static member _deprecated (scope: string, value: obj, previous: string, current: string) : unit = nativeOnly
                [<Import("_splitKey", "chart.js/helpers")>]
                static member _splitKey (key: string) : ResizeArray<string> = nativeOnly
                [<Import("resolveObjectKey", "chart.js/helpers")>]
                static member resolveObjectKey (obj: ChartJs.AnyObject, key: string) : obj = nativeOnly
                [<Import("_capitalize", "chart.js/helpers")>]
                static member _capitalize (str: string) : string = nativeOnly
                /// <param name="e">
                /// The event
                /// </param>
                [<Import("_isClickEvent", "chart.js/helpers")>]
                static member _isClickEvent (e: ChartJs.ChartEvent) : bool = nativeOnly
                /// <summary>
                /// Returns a unique id, sequentially generated from a global variable.
                /// </summary>
                [<Import("uid", "chart.js/helpers")>]
                static member inline uid: (unit -> float) = nativeOnly
                /// <summary>
                /// Returns true if <c>value</c> is a finite number, else returns false
                /// </summary>
                /// <param name="value">
                /// The value to test.
                /// </param>
                [<Import("isFinite", "chart.js/helpers")>]
                static member isFinite (value: obj) : bool = nativeOnly
                [<Import("toPercentage", "chart.js/helpers")>]
                static member inline toPercentage: Exports.toPercentage__.Type = nativeOnly
                [<Import("toDimension", "chart.js/helpers")>]
                static member inline toDimension: Exports.toDimension__.Type = nativeOnly
                [<Import("defined", "chart.js/helpers")>]
                static member inline defined: (obj -> bool) = nativeOnly
                [<Import("isFunction", "chart.js/helpers")>]
                static member inline isFunction: (obj -> bool) = nativeOnly
                [<Import("setsEqual", "chart.js/helpers")>]
                static member inline setsEqual: Exports.setsEqual__.Type = nativeOnly
                /// <summary>
                /// Converts the given font object into a CSS font string.
                /// </summary>
                /// <param name="font">
                /// A font object.
                /// </param>
                /// <returns>
                /// The CSS font string. See https://developer.mozilla.org/en-US/docs/Web/CSS/font
                /// </returns>
                [<Import("toFontString", "chart.js/helpers")>]
                static member toFontString (font: ChartJs.FontSpec) : string = nativeOnly
                [<Import("_measureText", "chart.js/helpers")>]
                static member _measureText (ctx: Glutinum.Web.CanvasRenderingContext2D, data: Exports._measureText__.data, gc: ResizeArray<string>, longest: float, string: string) : float = nativeOnly
                [<Import("_longestText", "chart.js/helpers")>]
                static member _longestText (ctx: Glutinum.Web.CanvasRenderingContext2D, font: string, arrayOfThings: ChartJs.helpers.Things, ?cache: Exports._longestText__.cache) : float = nativeOnly
                /// <summary>
                /// Returns the aligned pixel value to avoid anti-aliasing blur
                /// </summary>
                /// <param name="chart">
                /// The chart instance.
                /// </param>
                /// <param name="pixel">
                /// A pixel value.
                /// </param>
                /// <param name="width">
                /// The width of the element.
                /// </param>
                /// <returns>
                /// The aligned pixel value.
                /// </returns>
                [<Import("_alignPixel", "chart.js/helpers")>]
                static member _alignPixel (chart: ChartJs.dist.types.Chart, pixel: float, width: float) : float = nativeOnly
                /// <summary>
                /// Clears the entire canvas.
                /// </summary>
                [<Import("clearCanvas", "chart.js/helpers")>]
                static member clearCanvas (?canvas: Glutinum.Web.HTMLCanvasElement, ?ctx: Glutinum.Web.CanvasRenderingContext2D) : unit = nativeOnly
                [<Import("drawPoint", "chart.js/helpers")>]
                static member drawPoint (ctx: Glutinum.Web.CanvasRenderingContext2D, options: ChartJs.helpers.DrawPointOptions, x: float, y: float) : unit = nativeOnly
                [<Import("drawPointLegend", "chart.js/helpers")>]
                static member drawPointLegend (ctx: Glutinum.Web.CanvasRenderingContext2D, options: ChartJs.helpers.DrawPointOptions, x: float, y: float, w: float) : unit = nativeOnly
                /// <summary>
                /// Returns true if the point is inside the rectangle
                /// </summary>
                /// <param name="point">
                /// The point to test
                /// </param>
                /// <param name="area">
                /// The rectangle
                /// </param>
                /// <param name="margin">
                /// allowed margin
                /// </param>
                [<Import("_isPointInArea", "chart.js/helpers")>]
                static member _isPointInArea (point: ChartJs.Point, area: ChartJs.TRBL, ?margin: float) : bool = nativeOnly
                [<Import("clipArea", "chart.js/helpers")>]
                static member clipArea (ctx: Glutinum.Web.CanvasRenderingContext2D, area: ChartJs.TRBL) : unit = nativeOnly
                [<Import("unclipArea", "chart.js/helpers")>]
                static member unclipArea (ctx: Glutinum.Web.CanvasRenderingContext2D) : unit = nativeOnly
                [<Import("_steppedLineTo", "chart.js/helpers")>]
                static member _steppedLineTo (ctx: Glutinum.Web.CanvasRenderingContext2D, previous: ChartJs.Point, target: ChartJs.Point, ?flip: bool, ?mode: string) : unit = nativeOnly
                [<Import("_bezierCurveTo", "chart.js/helpers")>]
                static member _bezierCurveTo (ctx: Glutinum.Web.CanvasRenderingContext2D, previous: ChartJs.SplinePoint, target: ChartJs.SplinePoint, ?flip: bool) : unit = nativeOnly
                /// <summary>
                /// Render text onto the canvas
                /// </summary>
                [<Import("renderText", "chart.js/helpers")>]
                static member renderText (ctx: Glutinum.Web.CanvasRenderingContext2D, text: string, x: float, y: float, font: ChartJs.CanvasFontSpec, ?opts: ChartJs.RenderTextOpts) : unit = nativeOnly
                /// <summary>
                /// Render text onto the canvas
                /// </summary>
                [<Import("renderText", "chart.js/helpers")>]
                static member renderText (ctx: Glutinum.Web.CanvasRenderingContext2D, text: ResizeArray<string>, x: float, y: float, font: ChartJs.CanvasFontSpec, ?opts: ChartJs.RenderTextOpts) : unit = nativeOnly
                /// <summary>
                /// Render text onto the canvas
                /// </summary>
                [<Import("renderText", "chart.js/helpers")>]
                static member renderText (ctx: Glutinum.Web.CanvasRenderingContext2D, text: U2<string, ResizeArray<string>>, x: float, y: float, font: ChartJs.CanvasFontSpec, ?opts: ChartJs.RenderTextOpts) : unit = nativeOnly
                /// <summary>
                /// Add a path of a rectangle with rounded corners to the current sub-path
                /// </summary>
                /// <param name="ctx">
                /// Context
                /// </param>
                /// <param name="rect">
                /// Bounding rect
                /// </param>
                [<Import("addRoundedRectPath", "chart.js/helpers")>]
                static member addRoundedRectPath (ctx: Glutinum.Web.CanvasRenderingContext2D, rect: Exports.addRoundedRectPath__.rect) : unit = nativeOnly
                /// <summary>
                /// Binary search
                /// </summary>
                /// <param name="table">
                /// the table search. must be sorted!
                /// </param>
                /// <param name="value">
                /// value to find
                /// </param>
                /// <param name="cmp">
                ///
                /// </param>
                [<Import("_lookup", "chart.js/helpers")>]
                static member _lookup (table: ResizeArray<float>, value: float, ?cmp: (float -> bool)) : Exports._lookup__ = nativeOnly
                [<Import("_lookup", "chart.js/helpers")>]
                static member _lookup<'T> (table: ResizeArray<'T>, value: float, cmp: (float -> bool)) : Exports._lookup__ = nativeOnly
                /// <summary>
                /// Return subset of <c>values</c> between <c>min</c> and <c>max</c> inclusive.
                /// Values are assumed to be in sorted order.
                /// </summary>
                /// <param name="values">
                /// sorted array of values
                /// </param>
                /// <param name="min">
                /// min value
                /// </param>
                /// <param name="max">
                /// max value
                /// </param>
                [<Import("_filterBetween", "chart.js/helpers")>]
                static member _filterBetween (values: ResizeArray<float>, min: float, max: float) : ResizeArray<float> = nativeOnly
                /// <summary>
                /// Hooks the array methods that add or remove values ('push', pop', 'shift', 'splice',
                /// 'unshift') and notify the listener AFTER the array has been altered. Listeners are
                /// called on the '_onData*' callbacks (e.g. _onDataPush, etc.) with same arguments.
                /// </summary>
                [<Import("listenArrayEvents", "chart.js/helpers")>]
                static member listenArrayEvents<'T> (array: ResizeArray<'T>, listener: ChartJs.helpers.ArrayListener<'T>) : unit = nativeOnly
                /// <summary>
                /// Removes the given array event listener and cleanup extra attached properties (such as
                /// the _chartjs stub and overridden methods) if array doesn't have any more listeners.
                /// </summary>
                [<Import("unlistenArrayEvents", "chart.js/helpers")>]
                static member unlistenArrayEvents<'T> (array: ResizeArray<'T>, listener: ChartJs.helpers.ArrayListener<'T>) : unit = nativeOnly
                /// <param name="items">
                ///
                /// </param>
                [<Import("_arrayUnique", "chart.js/helpers")>]
                static member _arrayUnique<'T> (items: ResizeArray<'T>) : ResizeArray<'T> = nativeOnly
                /// <summary>
                /// Binary search
                /// </summary>
                /// <param name="table">
                /// the table search. must be sorted!
                /// </param>
                /// <param name="key">
                /// property name for the value in each entry
                /// </param>
                /// <param name="value">
                /// value to find
                /// </param>
                /// <param name="last">
                /// lookup last index
                /// </param>
                [<Import("_lookupByKey", "chart.js/helpers")>]
                static member inline _lookupByKey: Exports._lookupByKey__.Type = nativeOnly
                /// <summary>
                /// Reverse binary search
                /// </summary>
                /// <param name="table">
                /// the table search. must be sorted!
                /// </param>
                /// <param name="key">
                /// property name for the value in each entry
                /// </param>
                /// <param name="value">
                /// value to find
                /// </param>
                [<Import("_rlookupByKey", "chart.js/helpers")>]
                static member inline _rlookupByKey: Exports._rlookupByKey__.Type = nativeOnly
                /// <summary>
                /// Creates a Proxy for resolving raw values for options.
                /// </summary>
                /// <param name="scopes">
                /// The option scopes to look for values, in resolution order
                /// </param>
                /// <param name="prefixes">
                /// The prefixes for values, in resolution order.
                /// </param>
                /// <param name="rootScopes">
                /// The root option scopes
                /// </param>
                /// <param name="fallback">
                /// Parent scopes fallback
                /// </param>
                /// <param name="getTarget">
                /// callback for getting the target for changed values
                /// </param>
                /// <returns>
                /// Proxy
                /// </returns>
                [<Import("_createResolver", "chart.js/helpers")>]
                static member _createResolver<'T, 'R> (scopes: 'T, ?prefixes: ResizeArray<string>, ?rootScopes: 'R, ?fallback: ChartJs.helpers.ResolverObjectKey, ?getTarget: (unit -> ChartJs.AnyObject)) : obj = nativeOnly
                /// <summary>
                /// Creates a Proxy for resolving raw values for options.
                /// </summary>
                /// <param name="scopes">
                /// The option scopes to look for values, in resolution order
                /// </param>
                /// <param name="prefixes">
                /// The prefixes for values, in resolution order.
                /// </param>
                /// <param name="rootScopes">
                /// The root option scopes
                /// </param>
                /// <param name="fallback">
                /// Parent scopes fallback
                /// </param>
                /// <param name="getTarget">
                /// callback for getting the target for changed values
                /// </param>
                /// <returns>
                /// Proxy
                /// </returns>
                [<Import("_createResolver", "chart.js/helpers")>]
                static member _createResolver (scopes: ResizeArray<ChartJs.AnyObject>, ?prefixes: ResizeArray<string>, ?rootScopes: ResizeArray<ChartJs.AnyObject>, ?fallback: ChartJs.helpers.ResolverObjectKey, ?getTarget: (unit -> ChartJs.AnyObject)) : obj = nativeOnly
                /// <summary>
                /// Returns an Proxy for resolving option values with context.
                /// </summary>
                /// <param name="proxy">
                /// The Proxy returned by <c>_createResolver</c>
                /// </param>
                /// <param name="context">
                /// Context object for scriptable/indexable options
                /// </param>
                /// <param name="subProxy">
                /// The proxy provided for scriptable options
                /// </param>
                /// <param name="descriptorDefaults">
                /// Defaults for descriptors
                /// </param>
                [<Import("_attachContext", "chart.js/helpers")>]
                static member _attachContext<'T, 'R> (proxy: ChartJs.helpers.ResolverProxy<'T, 'R>, context: ChartJs.AnyObject, ?subProxy: ChartJs.helpers.ResolverProxy<'T, 'R>, ?descriptorDefaults: ChartJs.helpers.DescriptorDefaults) : ChartJs.helpers.ContextProxy<'T, 'R> = nativeOnly
                /// <summary>
                /// Returns an Proxy for resolving option values with context.
                /// </summary>
                /// <param name="proxy">
                /// The Proxy returned by <c>_createResolver</c>
                /// </param>
                /// <param name="context">
                /// Context object for scriptable/indexable options
                /// </param>
                /// <param name="subProxy">
                /// The proxy provided for scriptable options
                /// </param>
                /// <param name="descriptorDefaults">
                /// Defaults for descriptors
                /// </param>
                [<Import("_attachContext", "chart.js/helpers")>]
                static member _attachContext (proxy: ChartJs.helpers.ResolverProxy<ResizeArray<ChartJs.AnyObject>, ResizeArray<ChartJs.AnyObject>>, context: ChartJs.AnyObject, ?subProxy: ChartJs.helpers.ResolverProxy<ResizeArray<ChartJs.AnyObject>, ResizeArray<ChartJs.AnyObject>>, ?descriptorDefaults: ChartJs.helpers.DescriptorDefaults) : ChartJs.helpers.ContextProxy<ResizeArray<ChartJs.AnyObject>, ResizeArray<ChartJs.AnyObject>> = nativeOnly
                [<Import("_descriptors", "chart.js/helpers")>]
                static member _descriptors (proxy: ChartJs.helpers.ResolverCache, ?defaults: ChartJs.helpers.DescriptorDefaults) : ChartJs.helpers.Descriptor = nativeOnly
                [<Import("_parseObjectDataRadialScale", "chart.js/helpers")>]
                static member _parseObjectDataRadialScale (meta: ChartJs.ChartMeta<Exports._parseObjectDataRadialScale__.meta>, data: ResizeArray<ChartJs.AnyObject>, start: float, count: float) : ResizeArray<Exports._parseObjectDataRadialScale__.Item> = nativeOnly
                [<Import("splineCurve", "chart.js/helpers")>]
                static member splineCurve (firstPoint: ChartJs.SplinePoint, middlePoint: ChartJs.SplinePoint, afterPoint: ChartJs.SplinePoint, t: float) : Exports.splineCurve__ = nativeOnly
                /// <summary>
                /// This function calculates Bézier control points in a similar way than |splineCurve|,
                /// but preserves monotonicity of the provided data and ensures no local extremums are added
                /// between the dataset discrete points due to the interpolation.
                /// See : https://en.wikipedia.org/wiki/Monotone_cubic_interpolation
                /// </summary>
                [<Import("splineCurveMonotone", "chart.js/helpers")>]
                static member splineCurveMonotone (points: ResizeArray<ChartJs.SplinePoint>, ?indexAxis: Exports.splineCurveMonotone__.indexAxis) : unit = nativeOnly
                [<Import("_updateBezierControlPoints", "chart.js/helpers")>]
                static member _updateBezierControlPoints (points: ResizeArray<ChartJs.SplinePoint>, options: obj, area: ChartJs.ChartArea, loop: bool, indexAxis: Exports._updateBezierControlPoints__.indexAxis) : unit = nativeOnly
                [<Import("_isDomSupported", "chart.js/helpers")>]
                static member _isDomSupported () : bool = nativeOnly
                [<Import("_getParentNode", "chart.js/helpers")>]
                static member _getParentNode (domNode: Glutinum.Web.HTMLCanvasElement) : Glutinum.Web.HTMLCanvasElement = nativeOnly
                [<Import("getStyle", "chart.js/helpers")>]
                static member getStyle (el: Glutinum.Web.HTMLElement, property: string) : string = nativeOnly
                /// <summary>
                /// Gets an event's x, y coordinates, relative to the chart area
                /// </summary>
                /// <param name="event">
                ///
                /// </param>
                /// <param name="chart">
                ///
                /// </param>
                /// <returns>
                /// x and y coordinates of the event
                /// </returns>
                [<Import("getRelativePosition", "chart.js/helpers")>]
                static member getRelativePosition (event: Glutinum.Web.Event, chart: ChartJs.dist.types.Chart) : Exports.getRelativePosition__ = nativeOnly
                /// <summary>
                /// Gets an event's x, y coordinates, relative to the chart area
                /// </summary>
                /// <param name="event">
                ///
                /// </param>
                /// <param name="chart">
                ///
                /// </param>
                /// <returns>
                /// x and y coordinates of the event
                /// </returns>
                [<Import("getRelativePosition", "chart.js/helpers")>]
                static member getRelativePosition (event: Glutinum.Web.Event, chart: ChartJs.dist.core.core_controller.Chart) : Exports.getRelativePosition__ = nativeOnly
                /// <summary>
                /// Gets an event's x, y coordinates, relative to the chart area
                /// </summary>
                /// <param name="event">
                ///
                /// </param>
                /// <param name="chart">
                ///
                /// </param>
                /// <returns>
                /// x and y coordinates of the event
                /// </returns>
                [<Import("getRelativePosition", "chart.js/helpers")>]
                static member getRelativePosition (event: ChartJs.ChartEvent, chart: ChartJs.dist.types.Chart) : Exports.getRelativePosition__ = nativeOnly
                /// <summary>
                /// Gets an event's x, y coordinates, relative to the chart area
                /// </summary>
                /// <param name="event">
                ///
                /// </param>
                /// <param name="chart">
                ///
                /// </param>
                /// <returns>
                /// x and y coordinates of the event
                /// </returns>
                [<Import("getRelativePosition", "chart.js/helpers")>]
                static member getRelativePosition (event: ChartJs.ChartEvent, chart: ChartJs.dist.core.core_controller.Chart) : Exports.getRelativePosition__ = nativeOnly
                /// <summary>
                /// Gets an event's x, y coordinates, relative to the chart area
                /// </summary>
                /// <param name="event">
                ///
                /// </param>
                /// <param name="chart">
                ///
                /// </param>
                /// <returns>
                /// x and y coordinates of the event
                /// </returns>
                [<Import("getRelativePosition", "chart.js/helpers")>]
                static member getRelativePosition (event: Glutinum.Web.TouchEvent, chart: ChartJs.dist.types.Chart) : Exports.getRelativePosition__ = nativeOnly
                /// <summary>
                /// Gets an event's x, y coordinates, relative to the chart area
                /// </summary>
                /// <param name="event">
                ///
                /// </param>
                /// <param name="chart">
                ///
                /// </param>
                /// <returns>
                /// x and y coordinates of the event
                /// </returns>
                [<Import("getRelativePosition", "chart.js/helpers")>]
                static member getRelativePosition (event: Glutinum.Web.TouchEvent, chart: ChartJs.dist.core.core_controller.Chart) : Exports.getRelativePosition__ = nativeOnly
                /// <summary>
                /// Gets an event's x, y coordinates, relative to the chart area
                /// </summary>
                /// <param name="event">
                ///
                /// </param>
                /// <param name="chart">
                ///
                /// </param>
                /// <returns>
                /// x and y coordinates of the event
                /// </returns>
                [<Import("getRelativePosition", "chart.js/helpers")>]
                static member getRelativePosition (event: Glutinum.Web.MouseEvent, chart: ChartJs.dist.types.Chart) : Exports.getRelativePosition__ = nativeOnly
                /// <summary>
                /// Gets an event's x, y coordinates, relative to the chart area
                /// </summary>
                /// <param name="event">
                ///
                /// </param>
                /// <param name="chart">
                ///
                /// </param>
                /// <returns>
                /// x and y coordinates of the event
                /// </returns>
                [<Import("getRelativePosition", "chart.js/helpers")>]
                static member getRelativePosition (event: Glutinum.Web.MouseEvent, chart: ChartJs.dist.core.core_controller.Chart) : Exports.getRelativePosition__ = nativeOnly
                /// <summary>
                /// Gets an event's x, y coordinates, relative to the chart area
                /// </summary>
                /// <param name="event">
                ///
                /// </param>
                /// <param name="chart">
                ///
                /// </param>
                /// <returns>
                /// x and y coordinates of the event
                /// </returns>
                [<Import("getRelativePosition", "chart.js/helpers")>]
                static member getRelativePosition (event: U4<Glutinum.Web.Event, ChartJs.ChartEvent, Glutinum.Web.TouchEvent, Glutinum.Web.MouseEvent>, chart: U2<ChartJs.dist.types.Chart, ChartJs.dist.core.core_controller.Chart>) : Exports.getRelativePosition__ = nativeOnly
                [<Import("getMaximumSize", "chart.js/helpers")>]
                static member getMaximumSize (canvas: Glutinum.Web.HTMLCanvasElement, ?bbWidth: float, ?bbHeight: float, ?aspectRatio: float) : Exports.getMaximumSize__ = nativeOnly
                /// <param name="chart">
                ///
                /// </param>
                /// <param name="forceRatio">
                ///
                /// </param>
                /// <param name="forceStyle">
                ///
                /// </param>
                /// <returns>
                /// True if the canvas context size or transformation has changed.
                /// </returns>
                [<Import("retinaScale", "chart.js/helpers")>]
                static member retinaScale (chart: ChartJs.dist.types.Chart, forceRatio: float, ?forceStyle: bool) : U2<bool, unit> = nativeOnly
                /// <param name="chart">
                ///
                /// </param>
                /// <param name="forceRatio">
                ///
                /// </param>
                /// <param name="forceStyle">
                ///
                /// </param>
                /// <returns>
                /// True if the canvas context size or transformation has changed.
                /// </returns>
                [<Import("retinaScale", "chart.js/helpers")>]
                static member retinaScale (chart: ChartJs.dist.core.core_controller.Chart, forceRatio: float, ?forceStyle: bool) : U2<bool, unit> = nativeOnly
                /// <param name="chart">
                ///
                /// </param>
                /// <param name="forceRatio">
                ///
                /// </param>
                /// <param name="forceStyle">
                ///
                /// </param>
                /// <returns>
                /// True if the canvas context size or transformation has changed.
                /// </returns>
                [<Import("retinaScale", "chart.js/helpers")>]
                static member retinaScale (chart: U2<ChartJs.dist.types.Chart, ChartJs.dist.core.core_controller.Chart>, forceRatio: float, ?forceStyle: bool) : U2<bool, unit> = nativeOnly
                /// <summary>
                /// The "used" size is the final value of a dimension property after all calculations have
                /// been performed. This method uses the computed style of <c>element</c> but returns undefined
                /// if the computed style is not expressed in pixels. That can happen in some cases where
                /// <c>element</c> has a size relative to its parent and this last one is not yet displayed,
                /// for example because of <c>display: none</c> on a parent node.
                /// </summary>
                /// <returns>
                /// Size in pixels or undefined if unknown.
                /// </returns>
                [<Import("readUsedSize", "chart.js/helpers")>]
                static member readUsedSize (element: Glutinum.Web.HTMLElement, property: Exports.readUsedSize__.property) : float option = nativeOnly
                /// <summary>
                /// Detects support for options object argument in addEventListener.
                /// https://developer.mozilla.org/en-US/docs/Web/API/EventTarget/addEventListener#Safely_detecting_option_support
                /// </summary>
                [<Import("supportsEventListenerOptions", "chart.js/helpers")>]
                static member inline supportsEventListenerOptions: bool = nativeOnly
                [<Import("fontString", "chart.js/helpers")>]
                static member fontString (pixelSize: float, fontStyle: string, fontFamily: string) : string = nativeOnly
                /// <summary>
                /// Throttles calling <c>fn</c> once per animation frame
                /// Latest arguments are used on the actual call
                /// </summary>
                [<Import("throttled", "chart.js/helpers")>]
                static member throttled<'TArgs> (fn: System.Delegate, thisArg: obj) : System.Delegate = nativeOnly
                /// <summary>
                /// Debounces calling <c>fn</c> for <c>delay</c> ms
                /// </summary>
                [<Import("debounce", "chart.js/helpers")>]
                static member debounce<'TArgs> (fn: System.Delegate, delay: float) : System.Delegate = nativeOnly
                /// <summary>
                /// Return start and count of visible points.
                /// </summary>
                [<Import("_getStartAndCountOfVisiblePoints", "chart.js/helpers")>]
                static member _getStartAndCountOfVisiblePoints (meta: ChartJs.ChartMeta<Exports._getStartAndCountOfVisiblePoints__.meta>, points: ResizeArray<ChartJs.PointElement>, animationsDisabled: bool) : Exports._getStartAndCountOfVisiblePoints__ = nativeOnly
                /// <summary>
                /// Checks if the scale ranges have changed.
                /// </summary>
                /// <param name="meta">
                /// dataset meta.
                /// </param>
                [<Import("_scaleRangesChanged", "chart.js/helpers")>]
                static member _scaleRangesChanged (meta: obj) : bool = nativeOnly
                /// <summary>
                /// Request animation polyfill
                /// </summary>
                [<Import("requestAnimFrame", "chart.js/helpers")>]
                static member inline requestAnimFrame: U2<obj, (obj -> unit)> = nativeOnly
                /// <summary>
                /// Converts 'start' to 'left', 'end' to 'right' and others to 'center'
                /// </summary>
                [<Import("_toLeftRightCenter", "chart.js/helpers")>]
                static member inline _toLeftRightCenter: (Exports._toLeftRightCenter__.Type.align -> Exports._toLeftRightCenter__.Type) = nativeOnly
                /// <summary>
                /// Returns <c>start</c>, <c>end</c> or <c>(start + end) / 2</c> depending on <c>align</c>. Defaults to <c>center</c>
                /// </summary>
                [<Import("_alignStartEnd", "chart.js/helpers")>]
                static member inline _alignStartEnd: Exports._alignStartEnd__.Type = nativeOnly
                /// <summary>
                /// Returns <c>left</c>, <c>right</c> or <c>(left + right) / 2</c> depending on <c>align</c>. Defaults to <c>left</c>
                /// </summary>
                [<Import("_textX", "chart.js/helpers")>]
                static member inline _textX: Exports._textX__.Type = nativeOnly
                [<Import("_pointInLine", "chart.js/helpers")>]
                static member _pointInLine (p1: ChartJs.Point, p2: ChartJs.Point, t: float, ?mode: obj) : Exports._pointInLine__ = nativeOnly
                [<Import("_steppedInterpolation", "chart.js/helpers")>]
                static member _steppedInterpolation (p1: ChartJs.Point, p2: ChartJs.Point, t: float, mode: Exports._steppedInterpolation__.mode) : Exports._steppedInterpolation__ = nativeOnly
                [<Import("_bezierInterpolation", "chart.js/helpers")>]
                static member _bezierInterpolation (p1: ChartJs.SplinePoint, p2: ChartJs.SplinePoint, t: float, ?mode: obj) : Exports._bezierInterpolation__ = nativeOnly
                [<Import("formatNumber", "chart.js/helpers")>]
                static member formatNumber (num: float, locale: string, ?options: obj) : string = nativeOnly
                /// <summary>
                /// Converts the given line height <c>value</c> in pixels for a specific font <c>size</c>.
                /// </summary>
                /// <param name="value">
                /// The lineHeight to parse (eg. 1.6, '14px', '75%', '1.6em').
                /// </param>
                /// <param name="size">
                /// The font size (in pixels) used to resolve relative <c>value</c>.
                /// </param>
                /// <returns>
                /// The effective line height in pixels (size * 1.2 if value is invalid).
                /// </returns>
                [<Import("toLineHeight", "chart.js/helpers")>]
                static member toLineHeight (value: float, size: float) : float = nativeOnly
                /// <summary>
                /// Converts the given line height <c>value</c> in pixels for a specific font <c>size</c>.
                /// </summary>
                /// <param name="value">
                /// The lineHeight to parse (eg. 1.6, '14px', '75%', '1.6em').
                /// </param>
                /// <param name="size">
                /// The font size (in pixels) used to resolve relative <c>value</c>.
                /// </param>
                /// <returns>
                /// The effective line height in pixels (size * 1.2 if value is invalid).
                /// </returns>
                [<Import("toLineHeight", "chart.js/helpers")>]
                static member toLineHeight (value: string, size: float) : float = nativeOnly
                /// <summary>
                /// Converts the given line height <c>value</c> in pixels for a specific font <c>size</c>.
                /// </summary>
                /// <param name="value">
                /// The lineHeight to parse (eg. 1.6, '14px', '75%', '1.6em').
                /// </param>
                /// <param name="size">
                /// The font size (in pixels) used to resolve relative <c>value</c>.
                /// </param>
                /// <returns>
                /// The effective line height in pixels (size * 1.2 if value is invalid).
                /// </returns>
                [<Import("toLineHeight", "chart.js/helpers")>]
                static member toLineHeight (value: U2<float, string>, size: float) : float = nativeOnly
                /// <param name="value">
                ///
                /// </param>
                /// <param name="props">
                ///
                /// </param>
                [<Import("_readValueToProps", "chart.js/helpers")>]
                static member _readValueToProps (value: float, props: ResizeArray<string>) : Exports._readValueToProps__<string> = nativeOnly
                /// <param name="value">
                ///
                /// </param>
                /// <param name="props">
                ///
                /// </param>
                [<Import("_readValueToProps", "chart.js/helpers")>]
                static member _readValueToProps (value: Exports._readValueToProps__.value<string>, props: ResizeArray<string>) : Exports._readValueToProps__<string> = nativeOnly
                /// <param name="value">
                ///
                /// </param>
                /// <param name="props">
                ///
                /// </param>
                [<Import("_readValueToProps", "chart.js/helpers")>]
                static member _readValueToProps (value: U2<float, Exports._readValueToProps__.value.U2.Case2<string>>, props: ResizeArray<string>) : Exports._readValueToProps__<string> = nativeOnly
                [<Import("_readValueToProps", "chart.js/helpers")>]
                static member _readValueToProps (value: float, props: Exports._readValueToProps__.props<string, string>) : Exports._readValueToProps___1<string> = nativeOnly
                [<Import("_readValueToProps", "chart.js/helpers")>]
                static member _readValueToProps (value: Exports._readValueToProps__.value_1, props: Exports._readValueToProps__.props<string, string>) : Exports._readValueToProps___1<string> = nativeOnly
                [<Import("_readValueToProps", "chart.js/helpers")>]
                static member _readValueToProps (value: U2<float, Exports._readValueToProps__.value.U2.Case2_1>, props: Exports._readValueToProps__.props<string, string>) : Exports._readValueToProps___1<string> = nativeOnly
                /// <summary>
                /// Converts the given value into a TRBL object.
                /// </summary>
                /// <param name="value">
                /// If a number, set the value to all TRBL component,
                /// else, if an object, use defined properties and sets undefined ones to 0.
                /// x / y are shorthands for same value for left/right and top/bottom.
                /// </param>
                /// <returns>
                /// The padding values (top, right, bottom, left)
                /// </returns>
                [<Import("toTRBL", "chart.js/helpers")>]
                static member toTRBL (value: float) : Exports.toTRBL__ = nativeOnly
                /// <summary>
                /// Converts the given value into a TRBL object.
                /// </summary>
                /// <param name="value">
                /// If a number, set the value to all TRBL component,
                /// else, if an object, use defined properties and sets undefined ones to 0.
                /// x / y are shorthands for same value for left/right and top/bottom.
                /// </param>
                /// <returns>
                /// The padding values (top, right, bottom, left)
                /// </returns>
                [<Import("toTRBL", "chart.js/helpers")>]
                static member toTRBL (value: ChartJs.TRBL) : Exports.toTRBL___1 = nativeOnly
                /// <summary>
                /// Converts the given value into a TRBL object.
                /// </summary>
                /// <param name="value">
                /// If a number, set the value to all TRBL component,
                /// else, if an object, use defined properties and sets undefined ones to 0.
                /// x / y are shorthands for same value for left/right and top/bottom.
                /// </param>
                /// <returns>
                /// The padding values (top, right, bottom, left)
                /// </returns>
                [<Import("toTRBL", "chart.js/helpers")>]
                static member toTRBL (value: ChartJs.Point) : Exports.toTRBL___2 = nativeOnly
                /// <summary>
                /// Converts the given value into a TRBL object.
                /// </summary>
                /// <param name="value">
                /// If a number, set the value to all TRBL component,
                /// else, if an object, use defined properties and sets undefined ones to 0.
                /// x / y are shorthands for same value for left/right and top/bottom.
                /// </param>
                /// <returns>
                /// The padding values (top, right, bottom, left)
                /// </returns>
                [<Import("toTRBL", "chart.js/helpers")>]
                static member toTRBL (value: U3<float, ChartJs.TRBL, ChartJs.Point>) : Exports.toTRBL___3 = nativeOnly
                /// <summary>
                /// Converts the given value into a TRBL corners object (similar with css border-radius).
                /// </summary>
                /// <param name="value">
                /// If a number, set the value to all TRBL corner components,
                /// else, if an object, use defined properties and sets undefined ones to 0.
                /// </param>
                /// <returns>
                /// The TRBL corner values (topLeft, topRight, bottomLeft, bottomRight)
                /// </returns>
                [<Import("toTRBLCorners", "chart.js/helpers")>]
                static member toTRBLCorners (value: float) : Exports.toTRBLCorners__ = nativeOnly
                /// <summary>
                /// Converts the given value into a TRBL corners object (similar with css border-radius).
                /// </summary>
                /// <param name="value">
                /// If a number, set the value to all TRBL corner components,
                /// else, if an object, use defined properties and sets undefined ones to 0.
                /// </param>
                /// <returns>
                /// The TRBL corner values (topLeft, topRight, bottomLeft, bottomRight)
                /// </returns>
                [<Import("toTRBLCorners", "chart.js/helpers")>]
                static member toTRBLCorners (value: ChartJs.TRBLCorners) : Exports.toTRBLCorners___1 = nativeOnly
                /// <summary>
                /// Converts the given value into a TRBL corners object (similar with css border-radius).
                /// </summary>
                /// <param name="value">
                /// If a number, set the value to all TRBL corner components,
                /// else, if an object, use defined properties and sets undefined ones to 0.
                /// </param>
                /// <returns>
                /// The TRBL corner values (topLeft, topRight, bottomLeft, bottomRight)
                /// </returns>
                [<Import("toTRBLCorners", "chart.js/helpers")>]
                static member toTRBLCorners (value: U2<float, ChartJs.TRBLCorners>) : Exports.toTRBLCorners___2 = nativeOnly
                /// <summary>
                /// Converts the given value into a padding object with pre-computed width/height.
                /// </summary>
                /// <param name="value">
                /// If a number, set the value to all TRBL component,
                /// else, if an object, use defined properties and sets undefined ones to 0.
                /// x / y are shorthands for same value for left/right and top/bottom.
                /// </param>
                /// <returns>
                /// The padding values (top, right, bottom, left, width, height)
                /// </returns>
                [<Import("toPadding", "chart.js/helpers")>]
                static member toPadding () : ChartJs.ChartArea = nativeOnly
                /// <summary>
                /// Converts the given value into a padding object with pre-computed width/height.
                /// </summary>
                /// <param name="value">
                /// If a number, set the value to all TRBL component,
                /// else, if an object, use defined properties and sets undefined ones to 0.
                /// x / y are shorthands for same value for left/right and top/bottom.
                /// </param>
                /// <returns>
                /// The padding values (top, right, bottom, left, width, height)
                /// </returns>
                [<Import("toPadding", "chart.js/helpers")>]
                static member toPadding (value: float) : ChartJs.ChartArea = nativeOnly
                /// <summary>
                /// Converts the given value into a padding object with pre-computed width/height.
                /// </summary>
                /// <param name="value">
                /// If a number, set the value to all TRBL component,
                /// else, if an object, use defined properties and sets undefined ones to 0.
                /// x / y are shorthands for same value for left/right and top/bottom.
                /// </param>
                /// <returns>
                /// The padding values (top, right, bottom, left, width, height)
                /// </returns>
                [<Import("toPadding", "chart.js/helpers")>]
                static member toPadding (value: ChartJs.TRBL) : ChartJs.ChartArea = nativeOnly
                /// <summary>
                /// Parses font options and returns the font object.
                /// </summary>
                /// <param name="options">
                /// A object that contains font options to be parsed.
                /// </param>
                /// <param name="fallback">
                /// A object that contains fallback font options.
                /// </param>
                /// <returns>
                /// The font object.
                /// </returns>
                [<Import("toFont", "chart.js/helpers")>]
                static member toFont (options: Exports.toFont__.options, ?fallback: Exports.toFont__.fallback) : Exports.toFont__ = nativeOnly
                /// <summary>
                /// Evaluates the given <c>inputs</c> sequentially and returns the first defined value.
                /// </summary>
                /// <param name="inputs">
                /// An array of values, falling back to the last value.
                /// </param>
                /// <param name="context">
                /// If defined and the current value is a function, the value
                /// is called with <c>context</c> as first argument and the result becomes the new input.
                /// </param>
                /// <param name="index">
                /// If defined and the current value is an array, the value
                /// at <c>index</c> become the new input.
                /// </param>
                /// <param name="info">
                /// object to return information about resolution in
                /// </param>
                /// <param name="info.cacheable">
                /// Will be set to <c>false</c> if option is not cacheable.
                /// </param>
                [<Import("resolve", "chart.js/helpers")>]
                static member resolve (inputs: ResizeArray<obj>, ?context: obj, ?index: float, ?info: Exports.resolve__.info) : obj = nativeOnly
                /// <param name="minmax">
                ///
                /// </param>
                /// <param name="grace">
                ///
                /// </param>
                /// <param name="beginAtZero">
                ///
                /// </param>
                [<Import("_addGrace", "chart.js/helpers")>]
                static member _addGrace (minmax: Exports._addGrace__.minmax, grace: float, beginAtZero: bool) : Exports._addGrace__ = nativeOnly
                /// <param name="minmax">
                ///
                /// </param>
                /// <param name="grace">
                ///
                /// </param>
                /// <param name="beginAtZero">
                ///
                /// </param>
                [<Import("_addGrace", "chart.js/helpers")>]
                static member _addGrace (minmax: Exports._addGrace__.minmax, grace: string, beginAtZero: bool) : Exports._addGrace__ = nativeOnly
                /// <param name="minmax">
                ///
                /// </param>
                /// <param name="grace">
                ///
                /// </param>
                /// <param name="beginAtZero">
                ///
                /// </param>
                [<Import("_addGrace", "chart.js/helpers")>]
                static member _addGrace (minmax: Exports._addGrace__.minmax, grace: U2<float, string>, beginAtZero: bool) : Exports._addGrace__ = nativeOnly
                /// <summary>
                /// Create a context inheriting parentContext
                /// </summary>
                /// <param name="parentContext">
                ///
                /// </param>
                /// <param name="context">
                ///
                /// </param>
                [<Import("createContext", "chart.js/helpers")>]
                static member createContext (parentContext: obj, context: obj) : obj = nativeOnly
                [<Import("almostEquals", "chart.js/helpers")>]
                static member almostEquals (x: float, y: float, epsilon: float) : bool = nativeOnly
                /// <summary>
                /// Implementation of the nice number algorithm used in determining where axis labels will go
                /// </summary>
                [<Import("niceNum", "chart.js/helpers")>]
                static member niceNum (range: float) : float = nativeOnly
                /// <summary>
                /// Returns an array of factors sorted from 1 to sqrt(value)
                /// </summary>
                [<Import("_factorize", "chart.js/helpers")>]
                static member _factorize (value: float) : ResizeArray<float> = nativeOnly
                [<Import("isNumber", "chart.js/helpers")>]
                static member isNumber (n: obj) : bool = nativeOnly
                [<Import("almostWhole", "chart.js/helpers")>]
                static member almostWhole (x: float, epsilon: float) : bool = nativeOnly
                [<Import("_setMinAndMaxByKey", "chart.js/helpers")>]
                static member _setMinAndMaxByKey (array: ResizeArray<Exports._setMinAndMaxByKey__.array.Item>, target: Exports._setMinAndMaxByKey__.target, property: string) : unit = nativeOnly
                [<Import("toRadians", "chart.js/helpers")>]
                static member toRadians (degrees: float) : float = nativeOnly
                [<Import("toDegrees", "chart.js/helpers")>]
                static member toDegrees (radians: float) : float = nativeOnly
                /// <summary>
                /// Returns the number of decimal places
                /// i.e. the number of digits after the decimal point, of the value of this Number.
                /// </summary>
                /// <param name="x">
                /// A number.
                /// </param>
                /// <returns>
                /// The number of decimal places.
                /// </returns>
                [<Import("_decimalPlaces", "chart.js/helpers")>]
                static member _decimalPlaces (x: float) : float = nativeOnly
                [<Import("getAngleFromPoint", "chart.js/helpers")>]
                static member getAngleFromPoint (centrePoint: ChartJs.Point, anglePoint: ChartJs.Point) : Exports.getAngleFromPoint__ = nativeOnly
                [<Import("distanceBetweenPoints", "chart.js/helpers")>]
                static member distanceBetweenPoints (pt1: ChartJs.Point, pt2: ChartJs.Point) : float = nativeOnly
                /// <summary>
                /// Shortest distance between angles, in either direction.
                /// </summary>
                [<Import("_angleDiff", "chart.js/helpers")>]
                static member _angleDiff (a: float, b: float) : float = nativeOnly
                /// <summary>
                /// Normalize angle to be between 0 and 2*PI
                /// </summary>
                [<Import("_normalizeAngle", "chart.js/helpers")>]
                static member _normalizeAngle (a: float) : float = nativeOnly
                [<Import("_angleBetween", "chart.js/helpers")>]
                static member _angleBetween (angle: float, start: float, ``end``: float, ?sameAngleIsFullCircle: bool) : bool = nativeOnly
                /// <summary>
                /// Limit <c>value</c> between <c>min</c> and <c>max</c>
                /// </summary>
                /// <param name="value">
                ///
                /// </param>
                /// <param name="min">
                ///
                /// </param>
                /// <param name="max">
                ///
                /// </param>
                [<Import("_limitValue", "chart.js/helpers")>]
                static member _limitValue (value: float, min: float, max: float) : float = nativeOnly
                /// <param name="value">
                ///
                /// </param>
                [<Import("_int16Range", "chart.js/helpers")>]
                static member _int16Range (value: float) : float = nativeOnly
                /// <param name="value">
                ///
                /// </param>
                /// <param name="start">
                ///
                /// </param>
                /// <param name="end">
                ///
                /// </param>
                /// <param name="epsilon">
                ///
                /// </param>
                [<Import("_isBetween", "chart.js/helpers")>]
                static member _isBetween (value: float, start: float, ``end``: float, ?epsilon: float) : bool = nativeOnly
                [<Import("PI", "chart.js/helpers")>]
                static member inline PI: float = nativeOnly
                [<Import("TAU", "chart.js/helpers")>]
                static member inline TAU: float = nativeOnly
                [<Import("PITAU", "chart.js/helpers")>]
                static member inline PITAU: float = nativeOnly
                [<Import("INFINITY", "chart.js/helpers")>]
                static member inline INFINITY: float = nativeOnly
                [<Import("RAD_PER_DEG", "chart.js/helpers")>]
                static member inline RAD_PER_DEG: float = nativeOnly
                [<Import("HALF_PI", "chart.js/helpers")>]
                static member inline HALF_PI: float = nativeOnly
                [<Import("QUARTER_PI", "chart.js/helpers")>]
                static member inline QUARTER_PI: float = nativeOnly
                [<Import("TWO_THIRDS_PI", "chart.js/helpers")>]
                static member inline TWO_THIRDS_PI: float = nativeOnly
                [<Import("log10", "chart.js/helpers")>]
                static member inline log10: (float -> float) = nativeOnly
                [<Import("sign", "chart.js/helpers")>]
                static member inline sign: (float -> float) = nativeOnly
                [<Import("getRtlAdapter", "chart.js/helpers")>]
                static member getRtlAdapter (rtl: bool, rectX: float, width: float) : ChartJs.helpers.RTLAdapter = nativeOnly
                [<Import("overrideTextDirection", "chart.js/helpers")>]
                static member overrideTextDirection (ctx: Glutinum.Web.CanvasRenderingContext2D, direction: Exports.overrideTextDirection__.direction) : unit = nativeOnly
                [<Import("restoreTextDirection", "chart.js/helpers")>]
                static member restoreTextDirection (ctx: Glutinum.Web.CanvasRenderingContext2D, ?original: (string * string)) : unit = nativeOnly
                /// <summary>
                /// Returns the sub-segment(s) of a line segment that fall in the given bounds
                /// </summary>
                /// <param name="segment">
                ///
                /// </param>
                /// <param name="points">
                /// the points that this segment refers to
                /// </param>
                /// <param name="bounds">
                ///
                /// </param>
                [<Import("_boundSegment", "chart.js/helpers")>]
                static member _boundSegment (segment: Exports._boundSegment__.segment, points: ResizeArray<ChartJs.helpers.PointElement>, ?bounds: Exports._boundSegment__.bounds) : ResizeArray<Exports._boundSegment__.Item> = nativeOnly
                /// <summary>
                /// Returns the segments of the line that are inside given bounds
                /// </summary>
                /// <param name="line">
                ///
                /// </param>
                /// <param name="bounds">
                ///
                /// </param>
                [<Import("_boundSegments", "chart.js/helpers")>]
                static member _boundSegments (line: ChartJs.helpers.LineElement, ?bounds: Exports._boundSegments__.bounds) : ResizeArray<Exports._boundSegments__.Item> = nativeOnly
                /// <summary>
                /// Compute the continuous segments that define the whole line
                /// There can be skipped points within a segment, if spanGaps is true.
                /// </summary>
                /// <param name="line">
                ///
                /// </param>
                /// <param name="segmentOptions">
                ///
                /// </param>
                [<Import("_computeSegments", "chart.js/helpers")>]
                static member _computeSegments (line: ChartJs.helpers.LineElement, ?segmentOptions: obj) : ResizeArray<ChartJs.helpers.Segment> = nativeOnly
                [<Import("getDatasetClipArea", "chart.js/helpers")>]
                static member getDatasetClipArea (chart: ChartJs.dist.types.Chart, meta: ChartJs.ChartMeta) : U2<ChartJs.TRBL, bool> = nativeOnly

            type MergeOptions =
                ChartJs.helpers.MergeOptions

            type DrawPointOptions =
                ChartJs.helpers.DrawPointOptions

            type ArrayListener<'T> =
                ChartJs.helpers.ArrayListener<'T>

            type ResolverObjectKey =
                ChartJs.helpers.ResolverObjectKey

            type ResolverCache<'T, 'R> =
                ChartJs.helpers.ResolverCache<'T, 'R>

            type ResolverCache<'T> =
                ResolverCache<'T, 'T>

            type ResolverCache =
                ResolverCache<ResizeArray<ChartJs.AnyObject>, ResizeArray<ChartJs.AnyObject>>

            type ResolverProxy<'T, 'R> =
                ChartJs.helpers.ResolverProxy<'T, 'R>

            type ResolverProxy<'T> =
                ResolverProxy<'T, 'T>

            type ResolverProxy =
                ResolverProxy<ResizeArray<ChartJs.AnyObject>, ResizeArray<ChartJs.AnyObject>>

            type DescriptorDefaults =
                ChartJs.helpers.DescriptorDefaults

            type Descriptor =
                ChartJs.helpers.Descriptor

            type ContextCache<'T, 'R> =
                ChartJs.helpers.ContextCache<'T, 'R>

            type ContextCache<'T> =
                ContextCache<'T, 'T>

            type ContextCache =
                ContextCache<ResizeArray<ChartJs.AnyObject>, ResizeArray<ChartJs.AnyObject>>

            type ContextProxy<'T, 'R> =
                ChartJs.helpers.ContextProxy<'T, 'R>

            type ContextProxy<'T> =
                ContextProxy<'T, 'T>

            type ContextProxy =
                ContextProxy<ResizeArray<ChartJs.AnyObject>, ResizeArray<ChartJs.AnyObject>>

            type RTLAdapter =
                ChartJs.helpers.RTLAdapter

            type LineElement =
                ChartJs.helpers.LineElement

            type PointElement =
                ChartJs.helpers.PointElement

            type Segment =
                ChartJs.helpers.Segment

            module Exports =

                [<AllowNullLiteral>]
                [<Interface>]
                type _lookup__ =
                    abstract member lo: float with get, set
                    abstract member hi: float with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (lo: float, hi: float) : _lookup__ = nativeOnly

                [<AllowNullLiteral>]
                [<Interface>]
                type splineCurve__ =
                    abstract member previous: ChartJs.SplinePoint with get, set
                    abstract member next: ChartJs.SplinePoint with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (previous: ChartJs.SplinePoint, next: ChartJs.SplinePoint) : splineCurve__ = nativeOnly

                [<AllowNullLiteral>]
                [<Interface>]
                type getRelativePosition__ =
                    abstract member x: float with get, set
                    abstract member y: float with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (x: float, y: float) : getRelativePosition__ = nativeOnly

                [<AllowNullLiteral>]
                [<Interface>]
                type getMaximumSize__ =
                    abstract member width: float with get, set
                    abstract member height: float with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (width: float, height: float) : getMaximumSize__ = nativeOnly

                [<AllowNullLiteral>]
                [<Interface>]
                type _getStartAndCountOfVisiblePoints__ =
                    abstract member start: float with get, set
                    abstract member count: float with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (start: float, count: float) : _getStartAndCountOfVisiblePoints__ = nativeOnly

                [<AllowNullLiteral>]
                [<Interface>]
                type _pointInLine__ =
                    abstract member x: float with get, set
                    abstract member y: float with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (x: float, y: float) : _pointInLine__ = nativeOnly

                [<AllowNullLiteral>]
                [<Interface>]
                type _steppedInterpolation__ =
                    abstract member x: float with get, set
                    abstract member y: float with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (x: float, y: float) : _steppedInterpolation__ = nativeOnly

                [<AllowNullLiteral>]
                [<Interface>]
                type _bezierInterpolation__ =
                    abstract member x: float with get, set
                    abstract member y: float with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (x: float, y: float) : _bezierInterpolation__ = nativeOnly

                [<AllowNullLiteral>]
                [<Interface>]
                type _readValueToProps__<'K> =
                    [<EmitIndexer>]
                    abstract member Item: key: 'K -> float with get, set

                [<AllowNullLiteral>]
                [<Interface>]
                type _readValueToProps___1<'T> =
                    [<EmitIndexer>]
                    abstract member Item: key: 'T -> float with get, set

                [<AllowNullLiteral>]
                [<Interface>]
                type toTRBL__ =
                    [<EmitIndexer>]
                    abstract member Item: key: Exports.toTRBL__.toTRBL__.key -> float with get, set

                [<AllowNullLiteral>]
                [<Interface>]
                type toTRBL___1 =
                    [<EmitIndexer>]
                    abstract member Item: key: Exports.toTRBL__.toTRBL___1.key -> float with get, set

                [<AllowNullLiteral>]
                [<Interface>]
                type toTRBL___2 =
                    [<EmitIndexer>]
                    abstract member Item: key: Exports.toTRBL__.toTRBL___2.key -> float with get, set

                [<AllowNullLiteral>]
                [<Interface>]
                type toTRBL___3 =
                    [<EmitIndexer>]
                    abstract member Item: key: Exports.toTRBL__.toTRBL___3.key -> float with get, set

                [<AllowNullLiteral>]
                [<Interface>]
                type toTRBLCorners__ =
                    [<EmitIndexer>]
                    abstract member Item: key: Exports.toTRBLCorners__.toTRBLCorners__.key -> float with get, set

                [<AllowNullLiteral>]
                [<Interface>]
                type toTRBLCorners___1 =
                    [<EmitIndexer>]
                    abstract member Item: key: Exports.toTRBLCorners__.toTRBLCorners___1.key -> float with get, set

                [<AllowNullLiteral>]
                [<Interface>]
                type toTRBLCorners___2 =
                    [<EmitIndexer>]
                    abstract member Item: key: Exports.toTRBLCorners__.toTRBLCorners___2.key -> float with get, set

                [<AllowNullLiteral>]
                [<Interface>]
                type toFont__ =
                    abstract member family: string with get, set
                    abstract member lineHeight: float with get, set
                    abstract member size: float with get, set
                    abstract member style: Exports.toFont__.style with get, set
                    abstract member weight: Exports.toFont__.weight with get, set
                    abstract member string: string with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (family: string, lineHeight: float, size: float, style: Exports.toFont__.style, weight: Exports.toFont__.weight, string: string) : toFont__ = nativeOnly

                [<AllowNullLiteral>]
                [<Interface>]
                type _addGrace__ =
                    abstract member min: float with get, set
                    abstract member max: float with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (min: float, max: float) : _addGrace__ = nativeOnly

                [<AllowNullLiteral>]
                [<Interface>]
                type getAngleFromPoint__ =
                    abstract member angle: float with get, set
                    abstract member distance: float with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (angle: float, distance: float) : getAngleFromPoint__ = nativeOnly

                module color__ =

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type value =
                        abstract member r: float with get, set
                        abstract member g: float with get, set
                        abstract member b: float with get, set
                        abstract member a: float with get, set
                        [<ParamObject; Emit("$0")>]
                        static member Create (r: float, g: float, b: float, a: float) : value = nativeOnly

                module each__ =

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type loopable<'T> =
                        [<EmitIndexer>]
                        abstract member Item: key: string -> 'T with get, set

                    type fn<'T> =
                        delegate of v: 'T * i: string -> unit

                    type fn_1<'T> =
                        delegate of v: 'T * i: float -> unit

                module toPercentage__ =

                    type Type =
                        delegate of value: U2<float, string> * dimension: float -> float

                module toDimension__ =

                    type Type =
                        delegate of value: U2<float, string> * dimension: float -> float

                module setsEqual__ =

                    type Type =
                        delegate of a: obj * b: obj -> bool

                module _measureText__ =

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type data =
                        [<EmitIndexer>]
                        abstract member Item: key: string -> float with get, set

                module _longestText__ =

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type cache =
                        abstract member data: Exports._longestText__.cache.data option with get, set
                        abstract member garbageCollect: ResizeArray<string> option with get, set
                        abstract member font: string option with get, set
                        [<ParamObject; Emit("$0")>]
                        static member Create (?data: Exports._longestText__.cache.data, ?garbageCollect: ResizeArray<string>, ?font: string) : cache = nativeOnly

                    module cache =

                        [<AllowNullLiteral>]
                        [<Interface>]
                        type data =
                            [<EmitIndexer>]
                            abstract member Item: key: string -> float with get, set

                module addRoundedRectPath__ =

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type rect =
                        abstract member x: float with get, set
                        abstract member y: float with get, set
                        abstract member w: float with get, set
                        abstract member h: float with get, set
                        abstract member radius: obj with get, set
                        [<ParamObject; Emit("$0")>]
                        static member Create (x: float, y: float, w: float, h: float, radius: obj) : rect = nativeOnly

                module _lookupByKey__ =

                    type Type =
                        delegate of table: ResizeArray<Exports._lookupByKey__.Type.table.Item> * key: string * value: float * ?last: bool -> Exports._lookupByKey__.Type.ReturnType

                    module Type =

                        [<AllowNullLiteral>]
                        [<Interface>]
                        type ReturnType =
                            abstract member lo: float with get, set
                            abstract member hi: float with get, set
                            [<ParamObject; Emit("$0")>]
                            static member Create (lo: float, hi: float) : ReturnType = nativeOnly

                        module table =

                            [<AllowNullLiteral>]
                            [<Interface>]
                            type Item =
                                [<EmitIndexer>]
                                abstract member Item: key: string -> float with get, set

                module _rlookupByKey__ =

                    type Type =
                        delegate of table: ResizeArray<Exports._rlookupByKey__.Type.table.Item> * key: string * value: float -> Exports._rlookupByKey__.Type.ReturnType

                    module Type =

                        [<AllowNullLiteral>]
                        [<Interface>]
                        type ReturnType =
                            abstract member lo: float with get, set
                            abstract member hi: float with get, set
                            [<ParamObject; Emit("$0")>]
                            static member Create (lo: float, hi: float) : ReturnType = nativeOnly

                        module table =

                            [<AllowNullLiteral>]
                            [<Interface>]
                            type Item =
                                [<EmitIndexer>]
                                abstract member Item: key: string -> float with get, set

                module _parseObjectDataRadialScale__ =

                    [<RequireQualifiedAccess>]
                    [<StringEnum(CaseRules.None)>]
                    type meta =
                        | line
                        | scatter

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type Item =
                        abstract member r: obj with get, set
                        [<ParamObject; Emit("$0")>]
                        static member Create (r: obj) : Item = nativeOnly

                module splineCurveMonotone__ =

                    [<RequireQualifiedAccess>]
                    [<StringEnum(CaseRules.None)>]
                    type indexAxis =
                        | x
                        | y

                module _updateBezierControlPoints__ =

                    [<RequireQualifiedAccess>]
                    [<StringEnum(CaseRules.None)>]
                    type indexAxis =
                        | x
                        | y

                module readUsedSize__ =

                    [<RequireQualifiedAccess>]
                    [<StringEnum(CaseRules.None)>]
                    type property =
                        | width
                        | height

                module _getStartAndCountOfVisiblePoints__ =

                    [<RequireQualifiedAccess>]
                    [<StringEnum(CaseRules.None)>]
                    type meta =
                        | line
                        | scatter

                module _toLeftRightCenter__ =

                    [<RequireQualifiedAccess>]
                    [<StringEnum(CaseRules.None)>]
                    type Type =
                        | center
                        | left
                        | right

                    module Type =

                        [<RequireQualifiedAccess>]
                        [<StringEnum(CaseRules.None)>]
                        type align =
                            | start
                            | ``end``
                            | center

                module _alignStartEnd__ =

                    type Type =
                        delegate of align: Exports._alignStartEnd__.Type.align * start: float * ``end``: float -> float

                    module Type =

                        [<RequireQualifiedAccess>]
                        [<StringEnum(CaseRules.None)>]
                        type align =
                            | start
                            | ``end``
                            | center

                module _textX__ =

                    type Type =
                        delegate of align: Exports._textX__.Type.align * left: float * right: float * rtl: bool -> float

                    module Type =

                        [<RequireQualifiedAccess>]
                        [<StringEnum(CaseRules.None)>]
                        type align =
                            | left
                            | right
                            | center

                module _steppedInterpolation__ =

                    [<RequireQualifiedAccess>]
                    [<Erase(CaseRules.None)>]
                    type mode =
                        | middle
                        | after
                        | Case1 of obj

                        [<Emit("$0")>]
                        static member op_Implicit(value: obj) : mode = nativeOnly

                        [<Emit("$0")>]
                        static member op_ErasedCast(value: obj) : mode = nativeOnly

                module _readValueToProps__ =

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type value<'K> =
                        [<EmitIndexer>]
                        abstract member Item: key: 'K -> float with get, set

                    module value =

                        module U2 =

                            [<AllowNullLiteral>]
                            [<Interface>]
                            type Case2<'K> =
                                [<EmitIndexer>]
                                abstract member Item: key: 'K -> float with get, set

                            [<AllowNullLiteral>]
                            [<Interface>]
                            type Case2_1 =
                                [<EmitIndexer>]
                                abstract member Item: key: obj -> float with get, set

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type props<'T, 'K> =
                        [<EmitIndexer>]
                        abstract member Item: key: 'T -> 'K with get, set

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type value_1 =
                        [<EmitIndexer>]
                        abstract member Item: key: obj -> float with get, set

                module toTRBL__ =

                    module toTRBL__ =

                        [<RequireQualifiedAccess>]
                        [<StringEnum(CaseRules.None)>]
                        type key =
                            | left
                            | top
                            | bottom
                            | right

                    module toTRBL___1 =

                        [<RequireQualifiedAccess>]
                        [<StringEnum(CaseRules.None)>]
                        type key =
                            | left
                            | top
                            | bottom
                            | right

                    module toTRBL___2 =

                        [<RequireQualifiedAccess>]
                        [<StringEnum(CaseRules.None)>]
                        type key =
                            | left
                            | top
                            | bottom
                            | right

                    module toTRBL___3 =

                        [<RequireQualifiedAccess>]
                        [<StringEnum(CaseRules.None)>]
                        type key =
                            | left
                            | top
                            | bottom
                            | right

                module toTRBLCorners__ =

                    module toTRBLCorners__ =

                        [<RequireQualifiedAccess>]
                        [<StringEnum(CaseRules.None)>]
                        type key =
                            | topLeft
                            | topRight
                            | bottomLeft
                            | bottomRight

                    module toTRBLCorners___1 =

                        [<RequireQualifiedAccess>]
                        [<StringEnum(CaseRules.None)>]
                        type key =
                            | topLeft
                            | topRight
                            | bottomLeft
                            | bottomRight

                    module toTRBLCorners___2 =

                        [<RequireQualifiedAccess>]
                        [<StringEnum(CaseRules.None)>]
                        type key =
                            | topLeft
                            | topRight
                            | bottomLeft
                            | bottomRight

                module toFont__ =

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type options =
                        /// <summary>
                        /// Default font family for all text, follows CSS font-family options.
                        /// </summary>
                        abstract member family: string option with get, set
                        /// <summary>
                        /// Default font size (in px) for text. Does not apply to radialLinear scale point labels.
                        /// </summary>
                        abstract member size: float option with get, set
                        /// <summary>
                        /// Default font style. Does not apply to tooltip title or footer. Does not apply to chart title. Follows CSS font-style options (i.e. normal, italic, oblique, initial, inherit)
                        /// </summary>
                        abstract member style: Exports.toFont__.options.Partial.style option with get, set
                        /// <summary>
                        /// Default font weight (boldness). (see MDN).
                        /// </summary>
                        abstract member weight: Exports.toFont__.options.Partial.weight option with get, set
                        /// <summary>
                        /// Height of an individual line of text (see MDN).
                        /// </summary>
                        abstract member lineHeight: U2<float, string> option with get, set

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type fallback =
                        /// <summary>
                        /// Default font family for all text, follows CSS font-family options.
                        /// </summary>
                        abstract member family: string option with get, set
                        /// <summary>
                        /// Default font size (in px) for text. Does not apply to radialLinear scale point labels.
                        /// </summary>
                        abstract member size: float option with get, set
                        /// <summary>
                        /// Default font style. Does not apply to tooltip title or footer. Does not apply to chart title. Follows CSS font-style options (i.e. normal, italic, oblique, initial, inherit)
                        /// </summary>
                        abstract member style: Exports.toFont__.fallback.Partial.style option with get, set
                        /// <summary>
                        /// Default font weight (boldness). (see MDN).
                        /// </summary>
                        abstract member weight: Exports.toFont__.fallback.Partial.weight option with get, set
                        /// <summary>
                        /// Height of an individual line of text (see MDN).
                        /// </summary>
                        abstract member lineHeight: U2<float, string> option with get, set

                    [<RequireQualifiedAccess>]
                    [<StringEnum(CaseRules.None)>]
                    type style =
                        | normal
                        | ``inherit``
                        | italic
                        | oblique
                        | initial

                    [<RequireQualifiedAccess>]
                    [<Erase(CaseRules.None)>]
                    type weight =
                        | bold
                        | normal
                        | lighter
                        | bolder
                        | Case1 of float

                        [<Emit("$0")>]
                        static member op_Implicit(value: float) : weight = nativeOnly

                        [<Emit("$0")>]
                        static member op_ErasedCast(value: float) : weight = nativeOnly

                    module options =

                        module Partial =

                            [<RequireQualifiedAccess>]
                            [<StringEnum(CaseRules.None)>]
                            type style =
                                | normal
                                | italic
                                | oblique
                                | initial
                                | ``inherit``

                            [<RequireQualifiedAccess>]
                            [<Erase(CaseRules.None)>]
                            type weight =
                                | normal
                                | bold
                                | lighter
                                | bolder
                                | Case1 of float

                                [<Emit("$0")>]
                                static member op_Implicit(value: float) : weight = nativeOnly

                                [<Emit("$0")>]
                                static member op_ErasedCast(value: float) : weight = nativeOnly

                    module fallback =

                        module Partial =

                            [<RequireQualifiedAccess>]
                            [<StringEnum(CaseRules.None)>]
                            type style =
                                | normal
                                | italic
                                | oblique
                                | initial
                                | ``inherit``

                            [<RequireQualifiedAccess>]
                            [<Erase(CaseRules.None)>]
                            type weight =
                                | normal
                                | bold
                                | lighter
                                | bolder
                                | Case1 of float

                                [<Emit("$0")>]
                                static member op_Implicit(value: float) : weight = nativeOnly

                                [<Emit("$0")>]
                                static member op_ErasedCast(value: float) : weight = nativeOnly

                module resolve__ =

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type info =
                        abstract member cacheable: bool with get, set
                        [<ParamObject; Emit("$0")>]
                        static member Create (cacheable: bool) : info = nativeOnly

                module _addGrace__ =

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type minmax =
                        abstract member min: float with get, set
                        abstract member max: float with get, set
                        [<ParamObject; Emit("$0")>]
                        static member Create (min: float, max: float) : minmax = nativeOnly

                module _setMinAndMaxByKey__ =

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type target =
                        abstract member min: float with get, set
                        abstract member max: float with get, set
                        [<ParamObject; Emit("$0")>]
                        static member Create (min: float, max: float) : target = nativeOnly

                    module array =

                        [<AllowNullLiteral>]
                        [<Interface>]
                        type Item =
                            [<EmitIndexer>]
                            abstract member Item: key: string -> float with get, set

                module overrideTextDirection__ =

                    [<RequireQualifiedAccess>]
                    [<StringEnum(CaseRules.None)>]
                    type direction =
                        | ltr
                        | rtl

                module _boundSegment__ =

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type segment =
                        abstract member start: float with get, set
                        abstract member ``end``: float with get, set
                        abstract member loop: bool with get, set
                        abstract member style: obj option with get, set
                        [<ParamObject; Emit("$0")>]
                        static member Create (start: float, ``end``: float, loop: bool, ?style: obj) : segment = nativeOnly

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type bounds =
                        abstract member property: string with get, set
                        abstract member start: float with get, set
                        abstract member ``end``: float with get, set
                        [<ParamObject; Emit("$0")>]
                        static member Create (property: string, start: float, ``end``: float) : bounds = nativeOnly

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type Item =
                        abstract member start: float with get, set
                        abstract member ``end``: float with get, set
                        abstract member loop: bool with get, set
                        abstract member style: obj option with get, set
                        [<ParamObject; Emit("$0")>]
                        static member Create (start: float, ``end``: float, loop: bool, ?style: obj) : Item = nativeOnly

                module _boundSegments__ =

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type bounds =
                        abstract member property: string with get, set
                        abstract member start: float with get, set
                        abstract member ``end``: float with get, set
                        [<ParamObject; Emit("$0")>]
                        static member Create (property: string, start: float, ``end``: float) : bounds = nativeOnly

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type Item =
                        abstract member start: float with get, set
                        abstract member ``end``: float with get, set
                        abstract member loop: bool with get, set
                        abstract member style: obj option with get, set
                        [<ParamObject; Emit("$0")>]
                        static member Create (start: float, ``end``: float, loop: bool, ?style: obj) : Item = nativeOnly

        module platform =

            module platform_base =

                [<AbstractClass>]
                [<Erase>]
                type Exports =
                    [<ImportDefault("chart.js"); EmitConstructor>]
                    static member BasePlatform () : BasePlatform = nativeOnly

                /// <summary>
                /// Abstract class that allows abstracting platform dependencies away from the chart.
                /// </summary>
                [<AllowNullLiteral>]
                [<Interface>]
                type BasePlatform =
                    /// <summary>
                    /// Called at chart construction time, returns a context2d instance implementing
                    /// the [W3C Canvas 2D Context API standard]<see href="https://www.w3.org/TR/2dcontext/">https://www.w3.org/TR/2dcontext/</see>.
                    /// </summary>
                    /// <param name="canvas">
                    /// The canvas from which to acquire context (platform specific)
                    /// </param>
                    /// <param name="aspectRatio">
                    /// The chart options
                    /// </param>
                    abstract member acquireContext: canvas: Glutinum.Web.HTMLCanvasElement * ?aspectRatio: float -> unit
                    /// <summary>
                    /// Called at chart destruction time, releases any resources associated to the context
                    /// previously returned by the acquireContext() method.
                    /// </summary>
                    /// <param name="context">
                    /// The context2d instance
                    /// </param>
                    /// <returns>
                    /// true if the method succeeded, else false
                    /// </returns>
                    abstract member releaseContext: context: Glutinum.Web.CanvasRenderingContext2D -> bool
                    /// <summary>
                    /// Registers the specified listener on the given chart.
                    /// </summary>
                    /// <param name="chart">
                    /// Chart from which to listen for event
                    /// </param>
                    /// <param name="type">
                    /// The (<see href="ChartEvent">ChartEvent</see>) type to listen for
                    /// </param>
                    /// <param name="listener">
                    /// Receives a notification (an object that implements
                    /// the <see href="ChartEvent">ChartEvent</see> interface) when an event of the specified type occurs.
                    /// </param>
                    abstract member addEventListener: chart: ChartJs.dist.platform.platform_base.Chart * ``type``: string * listener: Action -> unit
                    /// <summary>
                    /// Removes the specified listener previously registered with addEventListener.
                    /// </summary>
                    /// <param name="chart">
                    /// Chart from which to remove the listener
                    /// </param>
                    /// <param name="type">
                    /// The (<see href="ChartEvent">ChartEvent</see>) type to remove
                    /// </param>
                    /// <param name="listener">
                    /// The listener function to remove from the event target.
                    /// </param>
                    abstract member removeEventListener: chart: ChartJs.dist.platform.platform_base.Chart * ``type``: string * listener: Action -> unit
                    /// <returns>
                    /// the current devicePixelRatio of the device this platform is connected to.
                    /// </returns>
                    abstract member getDevicePixelRatio: unit -> float
                    /// <summary>
                    /// Returns the maximum size in pixels of given canvas element.
                    /// </summary>
                    /// <param name="element">
                    ///
                    /// </param>
                    /// <param name="width">
                    /// content width of parent element
                    /// </param>
                    /// <param name="height">
                    /// content height of parent element
                    /// </param>
                    /// <param name="aspectRatio">
                    /// aspect ratio to maintain
                    /// </param>
                    abstract member getMaximumSize: element: Glutinum.Web.HTMLCanvasElement * ?width: float * ?height: float * ?aspectRatio: float -> BasePlatform.getMaximumSize
                    /// <param name="canvas">
                    ///
                    /// </param>
                    /// <returns>
                    /// true if the canvas is attached to the platform, false if not.
                    /// </returns>
                    abstract member isAttached: canvas: Glutinum.Web.HTMLCanvasElement -> bool
                    /// <summary>
                    /// Updates config with platform specific requirements
                    /// </summary>
                    /// <param name="config">
                    ///
                    /// </param>
                    abstract member updateConfig: config: ChartJs.Config -> unit

                type Chart =
                    obj

                module BasePlatform =

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type getMaximumSize =
                        abstract member width: float with get, set
                        abstract member height: float with get, set
                        [<ParamObject; Emit("$0")>]
                        static member Create (width: float, height: float) : getMaximumSize = nativeOnly

            module platform_basic =

                [<AbstractClass>]
                [<Erase>]
                type Exports =
                    [<ImportDefault("chart.js"); EmitConstructor>]
                    static member BasicPlatform () : BasicPlatform = nativeOnly

                /// <summary>
                /// Platform class for charts without access to the DOM or to many element properties
                /// This platform is used by default for any chart passed an OffscreenCanvas.
                /// </summary>
                [<AllowNullLiteral>]
                [<Interface>]
                type BasicPlatform =
                    inherit ChartJs.dist.platform.platform_base.BasePlatform
                    /// <summary>
                    /// Called at chart construction time, returns a context2d instance implementing
                    /// the [W3C Canvas 2D Context API standard]<see href="https://www.w3.org/TR/2dcontext/">https://www.w3.org/TR/2dcontext/</see>.
                    /// </summary>
                    abstract member acquireContext: item: obj -> obj
                    /// <summary>
                    /// Updates config with platform specific requirements
                    /// </summary>
                    abstract member updateConfig: config: obj -> unit

            module platform_dom =

                [<AbstractClass>]
                [<Erase>]
                type Exports =
                    [<ImportDefault("chart.js"); EmitConstructor>]
                    static member DomPlatform () : DomPlatform = nativeOnly

                /// <summary>
                /// Platform class for charts that can access the DOM and global window/document properties
                /// </summary>
                [<AllowNullLiteral>]
                [<Interface>]
                type DomPlatform =
                    inherit ChartJs.dist.platform.platform_base.BasePlatform
                    /// <summary>
                    /// Called at chart construction time, returns a context2d instance implementing
                    /// the [W3C Canvas 2D Context API standard]<see href="https://www.w3.org/TR/2dcontext/">https://www.w3.org/TR/2dcontext/</see>.
                    /// </summary>
                    /// <param name="canvas">
                    ///
                    /// </param>
                    /// <param name="aspectRatio">
                    ///
                    /// </param>
                    abstract member acquireContext: canvas: Glutinum.Web.HTMLCanvasElement * ?aspectRatio: float -> Glutinum.Web.CanvasRenderingContext2D option
                    /// <summary>
                    /// Removes the specified listener previously registered with addEventListener.
                    /// </summary>
                    /// <param name="chart">
                    ///
                    /// </param>
                    /// <param name="type">
                    ///
                    /// </param>
                    abstract member removeEventListener: chart: ChartJs.dist.platform.platform_dom.Chart * ``type``: string -> unit

                type Chart =
                    obj

            module Exports =

                type platform_base =
                    platform_base.Exports

                type platform_basic =
                    platform_basic.Exports

                type platform_dom =
                    platform_dom.Exports

        module plugins =

            module plugin_legend =

                [<AbstractClass>]
                [<Erase>]
                type Exports =
                    /// <param name="config">
                    ///
                    /// </param>
                    [<Import("Legend", "chart.js"); EmitConstructor>]
                    static member Legend (config: Exports.Legend.config) : Legend = nativeOnly

                [<AllowNullLiteral>]
                [<Interface>]
                type Legend =
                    inherit ChartJs.Element<ChartJs.AnyObject, ChartJs.AnyObject>
                    abstract member _added: bool with get, set
                    abstract member legendHitBoxes: ResizeArray<obj> with get, set
                    abstract member doughnutMode: bool with get, set
                    abstract member chart: obj with get, set
                    abstract member options: obj with get, set
                    abstract member ctx: obj with get, set
                    abstract member legendItems: obj with get, set
                    abstract member columnSizes: ResizeArray<obj> with get, set
                    abstract member lineWidths: ResizeArray<float> with get, set
                    abstract member maxHeight: obj with get, set
                    abstract member maxWidth: obj with get, set
                    abstract member top: obj with get, set
                    abstract member bottom: obj with get, set
                    abstract member left: obj with get, set
                    abstract member right: obj with get, set
                    abstract member height: obj with get, set
                    abstract member width: obj with get, set
                    abstract member _margins: obj with get, set
                    abstract member position: obj with get, set
                    abstract member weight: obj with get, set
                    abstract member fullSize: obj with get, set
                    abstract member update: maxWidth: obj * maxHeight: obj * margins: obj -> unit
                    abstract member setDimensions: unit -> unit
                    abstract member buildLabels: unit -> unit
                    abstract member fit: unit -> unit
                    abstract member _fitCols: titleHeight: obj * labelFont: obj * boxWidth: obj * _itemHeight: obj -> obj
                    abstract member adjustHitBoxes: unit -> unit
                    abstract member isHorizontal: unit -> bool
                    abstract member draw: unit -> unit
                    /// <summary>
                    /// Handle an event
                    /// </summary>
                    /// <param name="e">
                    /// The event to handle
                    /// </param>
                    abstract member handleEvent: e: ChartJs.dist.plugins.plugin_legend.ChartEvent -> unit

                type ChartEvent =
                    obj

                module Exports =

                    module Legend =

                        [<AllowNullLiteral>]
                        [<Interface>]
                        type config =
                            abstract member ctx: obj with get, set
                            abstract member options: obj with get, set
                            abstract member chart: obj with get, set
                            [<ParamObject; Emit("$0")>]
                            static member Create (ctx: obj, options: obj, chart: obj) : config = nativeOnly

            module plugin_title =

                [<AbstractClass>]
                [<Erase>]
                type Exports =
                    /// <param name="config">
                    ///
                    /// </param>
                    [<Import("Title", "chart.js"); EmitConstructor>]
                    static member Title (config: Exports.Title.config) : Title = nativeOnly

                [<AllowNullLiteral>]
                [<Interface>]
                type Title =
                    inherit ChartJs.Element<ChartJs.AnyObject, ChartJs.AnyObject>
                    abstract member chart: obj with get, set
                    abstract member options: obj with get, set
                    abstract member ctx: obj with get, set
                    abstract member _padding: ChartJs.ChartArea with get, set
                    abstract member top: float with get, set
                    abstract member bottom: obj with get, set
                    abstract member left: float with get, set
                    abstract member right: obj with get, set
                    abstract member width: obj with get, set
                    abstract member height: obj with get, set
                    abstract member position: obj with get, set
                    abstract member weight: obj with get, set
                    abstract member fullSize: obj with get, set
                    abstract member update: maxWidth: obj * maxHeight: obj -> unit
                    abstract member isHorizontal: unit -> bool
                    abstract member _drawArgs: offset: obj -> Title._drawArgs
                    abstract member draw: unit -> unit

                module Title =

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type _drawArgs =
                        abstract member titleX: obj with get, set
                        abstract member titleY: obj with get, set
                        abstract member maxWidth: float with get, set
                        abstract member rotation: float with get, set
                        [<ParamObject; Emit("$0")>]
                        static member Create (titleX: obj, titleY: obj, maxWidth: float, rotation: float) : _drawArgs = nativeOnly

                module Exports =

                    module Title =

                        [<AllowNullLiteral>]
                        [<Interface>]
                        type config =
                            abstract member ctx: obj with get, set
                            abstract member options: obj with get, set
                            abstract member chart: obj with get, set
                            [<ParamObject; Emit("$0")>]
                            static member Create (ctx: obj, options: obj, chart: obj) : config = nativeOnly

            module plugin_tooltip =

                [<AbstractClass>]
                [<Erase>]
                type Exports =
                    [<Import("Tooltip", "chart.js"); EmitConstructor>]
                    static member Tooltip (config: obj) : Tooltip = nativeOnly

                [<AllowNullLiteral>]
                [<Interface>]
                type Tooltip =
                    inherit ChartJs.Element<ChartJs.AnyObject, ChartJs.AnyObject>
                    [<Emit("""import { Tooltip } from "chart.js/dist/plugins/plugin.tooltip.js";
Tooltip.positioners{{=$0}}""")>]
                    static member inline positioners
                        with get () : Tooltip.positioners__ =
                            nativeOnly
                        and set (value: Tooltip.positioners__) =
                            nativeOnly
                    abstract member opacity: float with get, set
                    abstract member _active: ResizeArray<obj> with get, set
                    abstract member _eventPosition: obj with get, set
                    abstract member _size: Tooltip._size with get, set
                    abstract member _cachedAnimations: Tooltip._cachedAnimations with get, set
                    abstract member _tooltipItems: ResizeArray<obj> with get, set
                    abstract member ``$animations``: obj with get, set
                    abstract member ``$context``: obj with get, set
                    abstract member chart: obj with get, set
                    abstract member options: obj with get, set
                    abstract member dataPoints: ResizeArray<Tooltip.dataPoints.Item> with get, set
                    abstract member title: obj with get, set
                    abstract member beforeBody: obj with get, set
                    abstract member body: ResizeArray<obj> with get, set
                    abstract member afterBody: obj with get, set
                    abstract member footer: obj with get, set
                    abstract member xAlign: obj with get, set
                    abstract member yAlign: obj with get, set
                    abstract member x: obj with get, set
                    abstract member y: obj with get, set
                    abstract member height: float with get, set
                    abstract member width: float with get, set
                    abstract member caretX: obj with get, set
                    abstract member caretY: obj with get, set
                    abstract member labelColors: ResizeArray<obj> with get, set
                    abstract member labelPointStyles: ResizeArray<obj> with get, set
                    abstract member labelTextColors: ResizeArray<obj> with get, set
                    abstract member initialize: options: obj -> unit
                    abstract member getTitle: context: obj * options: obj -> obj
                    abstract member getBeforeBody: tooltipItems: obj * options: obj -> obj
                    abstract member getBody: tooltipItems: obj * options: obj -> ResizeArray<obj>
                    abstract member getAfterBody: tooltipItems: obj * options: obj -> obj
                    abstract member getFooter: tooltipItems: obj * options: obj -> obj
                    abstract member update: changed: obj * replay: obj -> unit
                    abstract member drawCaret: tooltipPoint: obj * ctx: obj * size: obj * options: obj -> unit
                    abstract member getCaretPosition: tooltipPoint: obj * size: obj * options: obj -> Tooltip.getCaretPosition
                    abstract member drawTitle: pt: obj * ctx: obj * options: obj -> unit
                    abstract member drawBody: pt: obj * ctx: obj * options: obj -> unit
                    abstract member drawFooter: pt: obj * ctx: obj * options: obj -> unit
                    abstract member drawBackground: pt: obj * ctx: obj * tooltipSize: obj * options: obj -> unit
                    /// <summary>
                    /// Determine if the tooltip will draw anything
                    /// </summary>
                    /// <returns>
                    /// True if the tooltip will render
                    /// </returns>
                    abstract member _willRender: unit -> bool
                    abstract member draw: ctx: obj -> unit
                    /// <summary>
                    /// Get active elements in the tooltip
                    /// </summary>
                    /// <returns>
                    /// Array of elements that are active in the tooltip
                    /// </returns>
                    abstract member getActiveElements: unit -> ResizeArray<obj>
                    /// <summary>
                    /// Set active elements in the tooltip
                    /// </summary>
                    /// <param name="activeElements">
                    /// Array of active datasetIndex/index pairs.
                    /// </param>
                    /// <param name="eventPosition">
                    /// Synthetic event position used in positioning
                    /// </param>
                    abstract member setActiveElements: activeElements: ResizeArray<obj> * eventPosition: obj -> unit
                    abstract member _ignoreReplayEvents: bool with get, set
                    /// <summary>
                    /// Handle an event
                    /// </summary>
                    /// <param name="e">
                    /// The event to handle
                    /// </param>
                    /// <param name="replay">
                    /// This is a replayed event (from update)
                    /// </param>
                    /// <param name="inChartArea">
                    /// The event is inside chartArea
                    /// </param>
                    /// <returns>
                    /// true if the tooltip changed
                    /// </returns>
                    abstract member handleEvent: e: ChartJs.dist.plugins.plugin_tooltip.ChartEvent * ?replay: bool * ?inChartArea: bool -> bool
                    /// <summary>
                    /// Determine if the active elements + event combination changes the
                    /// tooltip position
                    /// </summary>
                    /// <param name="active">
                    /// Active elements
                    /// </param>
                    /// <param name="e">
                    /// Event that triggered the position change
                    /// </param>
                    /// <returns>
                    /// True if the position has changed
                    /// </returns>
                    abstract member _positionChanged: active: ResizeArray<obj> * e: ChartJs.dist.plugins.plugin_tooltip.ChartEvent -> bool

                type Chart =
                    obj

                type ChartEvent =
                    obj

                type ActiveElement =
                    obj

                type InteractionItem =
                    obj

                module Tooltip =

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type positioners__ =
                        /// <summary>
                        /// Average mode places the tooltip at the average position of the elements shown
                        /// </summary>
                        abstract member average: items: obj -> U2<bool, Tooltip.positioners__.average.U2.Case2>
                        /// <summary>
                        /// Gets the tooltip position nearest of the item nearest to the event position
                        /// </summary>
                        abstract member nearest: items: obj * eventPosition: obj -> U2<bool, Tooltip.positioners__.nearest.U2.Case2>
                        [<ParamObject; Emit("$0")>]
                        static member Create (average: (obj -> U2<bool, Tooltip.positioners__.average.U2.Case2>), nearest: Tooltip.positioners__.nearest) : positioners__ = nativeOnly

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type _size =
                        abstract member width: float with get, set
                        abstract member height: float with get, set
                        [<ParamObject; Emit("$0")>]
                        static member Create (width: float, height: float) : _size = nativeOnly

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type _cachedAnimations =
                        abstract member _chart: obj with get
                        abstract member _properties: obj with get
                        abstract member configure: config: obj -> unit
                        /// <summary>
                        /// Update <c>target</c> properties to new values, using configured animations
                        /// </summary>
                        /// <param name="target">
                        /// object to update
                        /// </param>
                        /// <param name="values">
                        /// new target properties
                        /// </param>
                        /// <returns>
                        /// - <c>true</c> if animations were started
                        /// </returns>
                        abstract member update: target: obj * values: obj -> bool option

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type getCaretPosition =
                        abstract member x1: obj with get, set
                        abstract member x2: obj with get, set
                        abstract member x3: obj with get, set
                        abstract member y1: obj with get, set
                        abstract member y2: obj with get, set
                        abstract member y3: obj with get, set
                        [<ParamObject; Emit("$0")>]
                        static member Create (x1: obj, x2: obj, x3: obj, y1: obj, y2: obj, y3: obj) : getCaretPosition = nativeOnly

                    module positioners__ =

                        type nearest =
                            delegate of items: obj * eventPosition: obj -> U2<bool, Tooltip.positioners__.nearest.U2.Case2>

                        module average =

                            module U2 =

                                [<AllowNullLiteral>]
                                [<Interface>]
                                type Case2 =
                                    abstract member x: float with get, set
                                    abstract member y: float with get, set
                                    [<ParamObject; Emit("$0")>]
                                    static member Create (x: float, y: float) : Case2 = nativeOnly

                        module nearest =

                            module U2 =

                                [<AllowNullLiteral>]
                                [<Interface>]
                                type Case2 =
                                    abstract member x: obj with get, set
                                    abstract member y: obj with get, set
                                    [<ParamObject; Emit("$0")>]
                                    static member Create (x: obj, y: obj) : Case2 = nativeOnly

                    module dataPoints =

                        [<AllowNullLiteral>]
                        [<Interface>]
                        type Item =
                            abstract member chart: ChartJs.dist.core.core_controller.Chart with get, set
                            abstract member label: obj with get, set
                            abstract member parsed: obj with get, set
                            abstract member raw: obj with get, set
                            abstract member formattedValue: obj with get, set
                            abstract member dataset: obj with get, set
                            abstract member dataIndex: float with get, set
                            abstract member datasetIndex: float with get, set
                            abstract member element: ChartJs.Element<ChartJs.AnyObject, ChartJs.AnyObject> with get, set
                            [<ParamObject; Emit("$0")>]
                            static member Create (chart: ChartJs.dist.core.core_controller.Chart, label: obj, parsed: obj, raw: obj, formattedValue: obj, dataset: obj, dataIndex: float, datasetIndex: float, element: ChartJs.Element<ChartJs.AnyObject, ChartJs.AnyObject>) : Item = nativeOnly

            module Exports =

                type plugin_legend =
                    plugin_legend.Exports

                type plugin_title =
                    plugin_title.Exports

                type plugin_tooltip =
                    plugin_tooltip.Exports

        module scales =

            [<AbstractClass>]
            [<Erase>]
            type Exports =
                [<Import("TimeSeriesScale", "chart.js"); EmitConstructor>]
                static member TimeSeriesScale () : TimeSeriesScale = nativeOnly

            type TimeSeriesScale =
                ChartJs.dist.scales.scale_timeseries.TimeSeriesScale

            module scale_category =

                [<AbstractClass>]
                [<Erase>]
                type Exports =
                    [<ImportDefault("chart.js"); EmitConstructor>]
                    static member CategoryScale () : CategoryScale = nativeOnly

                [<AllowNullLiteral>]
                [<Interface>]
                type CategoryScale =
                    inherit ChartJs.dist.core.core_scale.Scale
                    [<Emit("""import { CategoryScale } from "chart.js/dist/scales/scale.category.js";
CategoryScale.id{{=$0}}""")>]
                    static member inline id
                        with get () : string =
                            nativeOnly
                        and set (value: string) =
                            nativeOnly
                    [<Emit("""import { CategoryScale } from "chart.js/dist/scales/scale.category.js";
CategoryScale.defaults{{=$0}}""")>]
                    static member inline defaults
                        with get () : obj =
                            nativeOnly
                        and set (value: obj) =
                            nativeOnly
                    abstract member _startValue: float with get, set
                    abstract member _valueRange: float with get, set
                    abstract member _addedLabels: ResizeArray<obj> with get, set
                    abstract member init: scaleOptions: obj -> unit
                    /// <summary>
                    /// Parse a supported input value to internal representation.
                    /// </summary>
                    abstract member parse: raw: obj * index: obj -> float
                    abstract member buildTicks: unit -> ResizeArray<CategoryScale.buildTicks.Item>
                    /// <summary>
                    /// Used to get the label to display in the tooltip for the given value
                    /// </summary>
                    abstract member getLabelForValue: value: obj -> obj
                    /// <summary>
                    /// Returns the location of the given data point. Value can either be an index or a numerical value
                    /// The coordinate (0, 0) is at the upper-left corner of the canvas
                    /// </summary>
                    abstract member getPixelForValue: value: obj -> float
                    /// <summary>
                    /// Returns the location of the tick at the given index
                    /// The coordinate (0, 0) is at the upper-left corner of the canvas
                    /// </summary>
                    abstract member getPixelForTick: index: obj -> float
                    /// <summary>
                    /// Used to get the data value from a given pixel. This is the inverse of getPixelForValue
                    /// The coordinate (0, 0) is at the upper-left corner of the canvas
                    /// </summary>
                    abstract member getValueForPixel: pixel: obj -> float

                module CategoryScale =

                    module buildTicks =

                        [<AllowNullLiteral>]
                        [<Interface>]
                        type Item =
                            abstract member value: obj with get, set
                            [<ParamObject; Emit("$0")>]
                            static member Create (value: obj) : Item = nativeOnly

            module scale_linear =

                [<AbstractClass>]
                [<Erase>]
                type Exports =
                    [<ImportDefault("chart.js"); EmitConstructor>]
                    static member LinearScale () : LinearScale = nativeOnly

                [<AllowNullLiteral>]
                [<Interface>]
                type LinearScale =
                    inherit ChartJs.LinearScaleBase
                    [<Emit("""import { LinearScale } from "chart.js/dist/scales/scale.linear.js";
LinearScale.id{{=$0}}""")>]
                    static member inline id
                        with get () : string =
                            nativeOnly
                        and set (value: string) =
                            nativeOnly
                    [<Emit("""import { LinearScale } from "chart.js/dist/scales/scale.linear.js";
LinearScale.defaults{{=$0}}""")>]
                    static member inline defaults
                        with get () : obj =
                            nativeOnly
                        and set (value: obj) =
                            nativeOnly
                    /// <summary>
                    /// Returns the location of the given data point. Value can either be an index or a numerical value
                    /// The coordinate (0, 0) is at the upper-left corner of the canvas
                    /// </summary>
                    abstract member getPixelForValue: value: obj -> float
                    /// <summary>
                    /// Used to get the data value from a given pixel. This is the inverse of getPixelForValue
                    /// The coordinate (0, 0) is at the upper-left corner of the canvas
                    /// </summary>
                    abstract member getValueForPixel: pixel: obj -> float

            module scale_logarithmic =

                [<AbstractClass>]
                [<Erase>]
                type Exports =
                    [<ImportDefault("chart.js"); EmitConstructor>]
                    static member LogarithmicScale () : LogarithmicScale = nativeOnly

                [<AllowNullLiteral>]
                [<Interface>]
                type LogarithmicScale =
                    inherit ChartJs.dist.core.core_scale.Scale
                    [<Emit("""import { LogarithmicScale } from "chart.js/dist/scales/scale.logarithmic.js";
LogarithmicScale.id{{=$0}}""")>]
                    static member inline id
                        with get () : string =
                            nativeOnly
                        and set (value: string) =
                            nativeOnly
                    [<Emit("""import { LogarithmicScale } from "chart.js/dist/scales/scale.logarithmic.js";
LogarithmicScale.defaults{{=$0}}""")>]
                    static member inline defaults
                        with get () : obj =
                            nativeOnly
                        and set (value: obj) =
                            nativeOnly
                    abstract member start: float with get, set
                    abstract member ``end``: float with get, set
                    abstract member _startValue: float with get, set
                    abstract member _valueRange: float with get, set
                    /// <summary>
                    /// Parse a supported input value to internal representation.
                    /// </summary>
                    abstract member parse: raw: obj * index: obj -> float
                    abstract member _zero: bool with get, set
                    abstract member handleTickRangeOptions: unit -> unit
                    /// <summary>
                    /// Used to get the label to display in the tooltip for the given value
                    /// </summary>
                    /// <param name="value">
                    ///
                    /// </param>
                    abstract member getLabelForValue: value: float -> string
                    /// <summary>
                    /// Returns the location of the given data point. Value can either be an index or a numerical value
                    /// The coordinate (0, 0) is at the upper-left corner of the canvas
                    /// </summary>
                    abstract member getPixelForValue: value: obj -> float
                    /// <summary>
                    /// Used to get the data value from a given pixel. This is the inverse of getPixelForValue
                    /// The coordinate (0, 0) is at the upper-left corner of the canvas
                    /// </summary>
                    abstract member getValueForPixel: pixel: obj -> float

            module scale_radialLinear =

                [<AbstractClass>]
                [<Erase>]
                type Exports =
                    [<ImportDefault("chart.js"); EmitConstructor>]
                    static member RadialLinearScale () : RadialLinearScale = nativeOnly

                [<AllowNullLiteral>]
                [<Interface>]
                type RadialLinearScale =
                    inherit ChartJs.LinearScaleBase
                    [<Emit("""import { RadialLinearScale } from "chart.js/dist/scales/scale.radialLinear.js";
RadialLinearScale.id{{=$0}}""")>]
                    static member inline id
                        with get () : string =
                            nativeOnly
                        and set (value: string) =
                            nativeOnly
                    [<Emit("""import { RadialLinearScale } from "chart.js/dist/scales/scale.radialLinear.js";
RadialLinearScale.defaults{{=$0}}""")>]
                    static member inline defaults
                        with get () : obj =
                            nativeOnly
                        and set (value: obj) =
                            nativeOnly
                    [<Emit("""import { RadialLinearScale } from "chart.js/dist/scales/scale.radialLinear.js";
RadialLinearScale.defaultRoutes{{=$0}}""")>]
                    static member inline defaultRoutes
                        with get () : RadialLinearScale.defaultRoutes__ =
                            nativeOnly
                        and set (value: RadialLinearScale.defaultRoutes__) =
                            nativeOnly
                    [<Emit("""import { RadialLinearScale } from "chart.js/dist/scales/scale.radialLinear.js";
RadialLinearScale.descriptors{{=$0}}""")>]
                    static member inline descriptors
                        with get () : RadialLinearScale.descriptors__ =
                            nativeOnly
                        and set (value: RadialLinearScale.descriptors__) =
                            nativeOnly
                    abstract member xCenter: float with get, set
                    abstract member yCenter: float with get, set
                    abstract member drawingArea: float with get, set
                    abstract member _pointLabels: ResizeArray<string> with get, set
                    abstract member _pointLabelItems: ResizeArray<obj> with get, set
                    abstract member _padding: ChartJs.ChartArea with get, set
                    /// <summary>
                    /// Convert ticks to label strings
                    /// </summary>
                    abstract member generateTickLabels: ticks: obj -> unit
                    abstract member setCenterPoint: leftMovement: obj * rightMovement: obj * topMovement: obj * bottomMovement: obj -> unit
                    abstract member getIndexAngle: index: obj -> float
                    abstract member getDistanceFromCenterForValue: value: obj -> float
                    abstract member getValueForDistanceFromCenter: distance: obj -> obj
                    abstract member getPointLabelContext: index: obj -> obj
                    abstract member getPointPosition: index: obj * distanceFromCenter: obj * ?additionalAngle: float -> RadialLinearScale.getPointPosition
                    abstract member getPointPositionForValue: index: obj * value: obj -> RadialLinearScale.getPointPositionForValue
                    abstract member getBasePosition: index: obj -> RadialLinearScale.getBasePosition
                    abstract member getPointLabelPosition: index: obj -> RadialLinearScale.getPointLabelPosition

                module RadialLinearScale =

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type defaultRoutes__ =
                        abstract member angleLines_color: string with get, set
                        abstract member pointLabels_color: string with get, set
                        abstract member ticks_color: string with get, set
                        [<ParamObject; Emit("$0")>]
                        static member Create (angleLines_color: string, pointLabels_color: string, ticks_color: string) : defaultRoutes__ = nativeOnly

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type descriptors__ =
                        abstract member angleLines: RadialLinearScale.descriptors__.angleLines with get, set
                        [<ParamObject; Emit("$0")>]
                        static member Create (angleLines: RadialLinearScale.descriptors__.angleLines) : descriptors__ = nativeOnly

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type getPointPosition =
                        abstract member x: float with get, set
                        abstract member y: float with get, set
                        abstract member angle: float with get, set
                        [<ParamObject; Emit("$0")>]
                        static member Create (x: float, y: float, angle: float) : getPointPosition = nativeOnly

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type getPointPositionForValue =
                        abstract member x: float with get, set
                        abstract member y: float with get, set
                        abstract member angle: float with get, set
                        [<ParamObject; Emit("$0")>]
                        static member Create (x: float, y: float, angle: float) : getPointPositionForValue = nativeOnly

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type getBasePosition =
                        abstract member x: float with get, set
                        abstract member y: float with get, set
                        abstract member angle: float with get, set
                        [<ParamObject; Emit("$0")>]
                        static member Create (x: float, y: float, angle: float) : getBasePosition = nativeOnly

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type getPointLabelPosition =
                        abstract member left: obj with get, set
                        abstract member top: obj with get, set
                        abstract member right: obj with get, set
                        abstract member bottom: obj with get, set
                        [<ParamObject; Emit("$0")>]
                        static member Create (left: obj, top: obj, right: obj, bottom: obj) : getPointLabelPosition = nativeOnly

                    module descriptors__ =

                        [<AllowNullLiteral>]
                        [<Interface>]
                        type angleLines =
                            abstract member _fallback: string with get, set
                            [<ParamObject; Emit("$0")>]
                            static member Create (_fallback: string) : angleLines = nativeOnly

            module scale_time =

                [<AbstractClass>]
                [<Erase>]
                type Exports =
                    /// <param name="props">
                    ///
                    /// </param>
                    [<ImportDefault("chart.js"); EmitConstructor>]
                    static member TimeScale (props: obj) : TimeScale = nativeOnly

                [<AllowNullLiteral>]
                [<Interface>]
                type TimeScale =
                    inherit ChartJs.dist.core.core_scale.Scale
                    [<Emit("""import { TimeScale } from "chart.js/dist/scales/scale.time.js";
TimeScale.id{{=$0}}""")>]
                    static member inline id
                        with get () : string =
                            nativeOnly
                        and set (value: string) =
                            nativeOnly
                    [<Emit("""import { TimeScale } from "chart.js/dist/scales/scale.time.js";
TimeScale.defaults{{=$0}}""")>]
                    static member inline defaults
                        with get () : obj =
                            nativeOnly
                        and set (value: obj) =
                            nativeOnly
                    abstract member _cache: TimeScale._cache with get, set
                    abstract member _unit: ChartJs.Unit with get, set
                    abstract member _majorUnit: ChartJs.Unit option with get, set
                    abstract member _offsets: obj with get, set
                    abstract member _normalized: bool with get, set
                    abstract member _parseOpts: TimeScale._parseOpts with get, set
                    abstract member init: scaleOpts: obj * ?opts: obj -> unit
                    abstract member _adapter: ChartJs.dist.scales.scale_time.DateAdapter with get, set
                    /// <summary>
                    /// Parse a supported input value to internal representation.
                    /// </summary>
                    /// <param name="raw">
                    ///
                    /// </param>
                    /// <param name="index">
                    ///
                    /// </param>
                    abstract member parse: raw: obj * ?index: float -> float
                    /// <summary>
                    /// Used to get the label to display in the tooltip for the given value
                    /// </summary>
                    /// <param name="value">
                    ///
                    /// </param>
                    abstract member getLabelForValue: value: float -> string
                    /// <param name="value">
                    ///
                    /// </param>
                    /// <param name="format">
                    ///
                    /// </param>
                    abstract member format: value: float * format: string option -> string
                    /// <summary>
                    /// Convert ticks to label strings
                    /// </summary>
                    /// <param name="ticks">
                    ///
                    /// </param>
                    abstract member generateTickLabels: ticks: ResizeArray<obj> -> unit
                    /// <param name="value">
                    /// Milliseconds since epoch (1 January 1970 00:00:00 UTC)
                    /// </param>
                    abstract member getDecimalForValue: value: float -> float
                    /// <summary>
                    /// Returns the location of the given data point. Value can either be an index or a numerical value
                    /// The coordinate (0, 0) is at the upper-left corner of the canvas
                    /// </summary>
                    /// <param name="value">
                    /// Milliseconds since epoch (1 January 1970 00:00:00 UTC)
                    /// </param>
                    abstract member getPixelForValue: value: float -> float
                    /// <summary>
                    /// Used to get the data value from a given pixel. This is the inverse of getPixelForValue
                    /// The coordinate (0, 0) is at the upper-left corner of the canvas
                    /// </summary>
                    /// <param name="pixel">
                    ///
                    /// </param>
                    abstract member getValueForPixel: pixel: float -> float

                type DateAdapter =
                    obj

                module TimeScale =

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type _cache =
                        abstract member data: ResizeArray<float> with get, set
                        abstract member labels: ResizeArray<float> with get, set
                        abstract member all: ResizeArray<float> with get, set
                        [<ParamObject; Emit("$0")>]
                        static member Create (data: ResizeArray<float>, labels: ResizeArray<float>, all: ResizeArray<float>) : _cache = nativeOnly

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type _parseOpts =
                        abstract member parser: obj with get, set
                        abstract member round: obj with get, set
                        abstract member isoWeekday: obj with get, set
                        [<ParamObject; Emit("$0")>]
                        static member Create (parser: obj, round: obj, isoWeekday: obj) : _parseOpts = nativeOnly

            module scale_timeseries =

                [<AbstractClass>]
                [<Erase>]
                type Exports =
                    [<Import("TimeSeriesScale", "chart.js"); EmitConstructor>]
                    static member TimeSeriesScale () : TimeSeriesScale = nativeOnly

                [<AllowNullLiteral>]
                [<Interface>]
                type TimeSeriesScale =
                    inherit ChartJs.dist.scales.scale_time.TimeScale
                    abstract member _table: ResizeArray<obj> with get, set
                    abstract member _minPos: float with get, set
                    abstract member _tableRange: float with get, set

        module types =

            [<AbstractClass>]
            [<Erase>]
            type Exports =
                [<Import("Chart", "chart.js"); EmitConstructor>]
                static member Chart<'TType, 'TData, 'TLabel> (item: string, config: ChartJs.ChartConfiguration<'TType, 'TData, 'TLabel>) : Chart<'TType, 'TData, 'TLabel> = nativeOnly
                [<Import("Chart", "chart.js"); EmitConstructor>]
                static member Chart<'TType, 'TData, 'TLabel> (item: string, config: ChartJs.ChartConfigurationCustomTypesPerDataset<'TType, 'TData, 'TLabel>) : Chart<'TType, 'TData, 'TLabel> = nativeOnly
                [<Import("Chart", "chart.js"); EmitConstructor>]
                static member Chart<'TType, 'TData, 'TLabel> (item: Glutinum.Web.CanvasRenderingContext2D, config: ChartJs.ChartConfiguration<'TType, 'TData, 'TLabel>) : Chart<'TType, 'TData, 'TLabel> = nativeOnly
                [<Import("Chart", "chart.js"); EmitConstructor>]
                static member Chart<'TType, 'TData, 'TLabel> (item: Glutinum.Web.CanvasRenderingContext2D, config: ChartJs.ChartConfigurationCustomTypesPerDataset<'TType, 'TData, 'TLabel>) : Chart<'TType, 'TData, 'TLabel> = nativeOnly
                [<Import("Chart", "chart.js"); EmitConstructor>]
                static member Chart<'TType, 'TData, 'TLabel> (item: Glutinum.Web.HTMLCanvasElement, config: ChartJs.ChartConfiguration<'TType, 'TData, 'TLabel>) : Chart<'TType, 'TData, 'TLabel> = nativeOnly
                [<Import("Chart", "chart.js"); EmitConstructor>]
                static member Chart<'TType, 'TData, 'TLabel> (item: Glutinum.Web.HTMLCanvasElement, config: ChartJs.ChartConfigurationCustomTypesPerDataset<'TType, 'TData, 'TLabel>) : Chart<'TType, 'TData, 'TLabel> = nativeOnly
                [<Import("Chart", "chart.js"); EmitConstructor>]
                static member Chart<'TType, 'TData, 'TLabel> (item: Exports.Chart.item, config: ChartJs.ChartConfiguration<'TType, 'TData, 'TLabel>) : Chart<'TType, 'TData, 'TLabel> = nativeOnly
                [<Import("Chart", "chart.js"); EmitConstructor>]
                static member Chart<'TType, 'TData, 'TLabel> (item: Exports.Chart.item, config: ChartJs.ChartConfigurationCustomTypesPerDataset<'TType, 'TData, 'TLabel>) : Chart<'TType, 'TData, 'TLabel> = nativeOnly
                [<Import("Chart", "chart.js"); EmitConstructor>]
                static member Chart<'TType, 'TData, 'TLabel> (item: obj, config: ChartJs.ChartConfiguration<'TType, 'TData, 'TLabel>) : Chart<'TType, 'TData, 'TLabel> = nativeOnly
                [<Import("Chart", "chart.js"); EmitConstructor>]
                static member Chart<'TType, 'TData, 'TLabel> (item: obj, config: ChartJs.ChartConfigurationCustomTypesPerDataset<'TType, 'TData, 'TLabel>) : Chart<'TType, 'TData, 'TLabel> = nativeOnly
                [<Import("Chart", "chart.js"); EmitConstructor>]
                static member Chart<'TType, 'TData, 'TLabel> (item: ChartJs.ChartItem, config: U2<ChartJs.ChartConfiguration<'TType, 'TData, 'TLabel>, ChartJs.ChartConfigurationCustomTypesPerDataset<'TType, 'TData, 'TLabel>>) : Chart<'TType, 'TData, 'TLabel> = nativeOnly
                [<Import("Animation", "chart.js"); EmitConstructor>]
                static member Animation (cfg: ChartJs.AnyObject, target: ChartJs.AnyObject, prop: string, ?``to``: obj) : Animation = nativeOnly
                [<Import("Animations", "chart.js"); EmitConstructor>]
                static member Animations (chart: ChartJs.dist.types.Chart, animations: ChartJs.AnyObject) : Animations = nativeOnly
                [<Import("Animator", "chart.js"); EmitConstructor>]
                static member Animator () : Animator = nativeOnly

            type EasingFunction =
                ChartJs.EasingFunction

            type ArcProps =
                ChartJs.ArcProps

            type PointProps =
                ChartJs.PointProps

            type Animation =
                ChartJs.dist.types.animation.Animation

            type Animations =
                ChartJs.Animations

            type Animator =
                ChartJs.dist.types.animation.Animator

            type AnimationEvent =
                ChartJs.AnimationEvent

            type Color =
                ChartJs.Color

            type ChartArea =
                ChartJs.ChartArea

            type Point =
                ChartJs.Point

            type TRBL =
                ChartJs.TRBL

            type LayoutItem =
                ChartJs.LayoutItem

            type LayoutPosition =
                ChartJs.LayoutPosition

            [<AllowNullLiteral>]
            [<Interface>]
            type ChartMetaClip =
                abstract member left: U2<float, bool> with get, set
                abstract member top: U2<float, bool> with get, set
                abstract member right: U2<float, bool> with get, set
                abstract member bottom: U2<float, bool> with get, set
                abstract member disabled: bool with get, set

            [<AllowNullLiteral>]
            [<Interface>]
            type ChartMetaCommon<'TElement, 'TDatasetElement> =
                abstract member ``type``: string with get, set
                abstract member controller: ChartJs.DatasetController with get, set
                abstract member order: float with get, set
                abstract member label: string with get, set
                abstract member index: float with get, set
                abstract member visible: bool with get, set
                abstract member stack: float with get, set
                abstract member indexAxis: ChartMetaCommon.indexAxis with get, set
                abstract member data: ResizeArray<'TElement> with get, set
                abstract member dataset: 'TDatasetElement option with get, set
                abstract member hidden: bool with get, set
                abstract member xAxisID: string option with get, set
                abstract member yAxisID: string option with get, set
                abstract member rAxisID: string option with get, set
                abstract member iAxisID: string with get, set
                abstract member vAxisID: string with get, set
                abstract member xScale: ChartJs.Scale option with get, set
                abstract member yScale: ChartJs.Scale option with get, set
                abstract member rScale: ChartJs.Scale option with get, set
                abstract member iScale: ChartJs.Scale option with get, set
                abstract member vScale: ChartJs.Scale option with get, set
                abstract member _sorted: bool with get, set
                abstract member _stacked: ChartMetaCommon._stacked with get, set
                abstract member _parsed: ResizeArray<obj> with get, set
                abstract member _clip: ChartJs.dist.types.ChartMetaClip with get, set

            [<AllowNullLiteral>]
            [<Interface>]
            type Chart<'TType, 'TData, 'TLabel> =
                abstract member platform: ChartJs.BasePlatform with get
                abstract member id: string with get
                abstract member canvas: Glutinum.Web.HTMLCanvasElement with get
                abstract member ctx: Glutinum.Web.CanvasRenderingContext2D with get
                abstract member config: U2<ChartJs.ChartConfiguration<'TType, 'TData, 'TLabel>, ChartJs.ChartConfigurationCustomTypesPerDataset<'TType, 'TData, 'TLabel>> with get
                abstract member width: float with get
                abstract member height: float with get
                abstract member aspectRatio: float with get
                abstract member boxes: ResizeArray<ChartJs.LayoutItem> with get
                abstract member currentDevicePixelRatio: float with get
                abstract member chartArea: ChartJs.ChartArea with get
                abstract member scales: Chart.scales with get
                abstract member attached: bool with get
                abstract member legend: ChartJs.LegendElement<'TType> option with get
                abstract member tooltip: ChartJs.TooltipModel<'TType> option with get
                abstract member data: ChartJs.ChartData<'TType, 'TData, 'TLabel> with get, set
                abstract member options: ChartJs.ChartOptions<'TType> with get, set
                abstract member clear: unit -> Chart<'TType, 'TData, 'TLabel>
                abstract member stop: unit -> Chart<'TType, 'TData, 'TLabel>
                abstract member resize: ?width: float * ?height: float -> unit
                abstract member ensureScalesHaveIDs: unit -> unit
                abstract member buildOrUpdateScales: unit -> unit
                abstract member buildOrUpdateControllers: unit -> unit
                abstract member reset: unit -> unit
                abstract member update: unit -> unit
                abstract member update: mode: ChartJs.UpdateMode -> unit
                abstract member update: mode: (Chart.update.mode.ctx -> ChartJs.UpdateMode) -> unit
                abstract member render: unit -> unit
                abstract member draw: unit -> unit
                abstract member isPointInArea: point: ChartJs.Point -> bool
                abstract member getElementsAtEventForMode: e: Glutinum.Web.Event * mode: string * options: ChartJs.InteractionOptions * useFinalPosition: bool -> ResizeArray<ChartJs.InteractionItem>
                abstract member getSortedVisibleDatasetMetas: unit -> ResizeArray<ChartJs.ChartMeta>
                abstract member getDatasetMeta: datasetIndex: float -> ChartJs.ChartMeta
                abstract member getVisibleDatasetCount: unit -> float
                abstract member isDatasetVisible: datasetIndex: float -> bool
                abstract member setDatasetVisibility: datasetIndex: float * visible: bool -> unit
                abstract member toggleDataVisibility: index: float -> unit
                abstract member getDataVisibility: index: float -> bool
                abstract member hide: datasetIndex: float * ?dataIndex: float -> unit
                abstract member show: datasetIndex: float * ?dataIndex: float -> unit
                abstract member getActiveElements: unit -> ResizeArray<ChartJs.ActiveElement>
                abstract member setActiveElements: active: ResizeArray<ChartJs.ActiveDataPoint> -> unit
                abstract member destroy: unit -> unit
                abstract member toBase64Image: ?``type``: string * ?quality: obj -> string
                abstract member bindEvents: unit -> unit
                abstract member unbindEvents: unit -> unit
                abstract member updateHoverStyle: items: ResizeArray<ChartJs.InteractionItem> * mode: string * enabled: bool -> unit
                abstract member notifyPlugins: hook: string * ?args: ChartJs.AnyObject -> U2<bool, unit>
                abstract member isPluginEnabled: pluginId: string -> bool
                abstract member getContext: unit -> Chart.getContext
                [<Emit("""import { Chart } from "chart.js";
Chart.defaults{{=$0}}""")>]
                static member inline defaults
                    with get () : ChartJs.Defaults =
                        nativeOnly
                [<Emit("""import { Chart } from "chart.js";
Chart.overrides{{=$0}}""")>]
                static member inline overrides
                    with get () : ChartJs.Overrides =
                        nativeOnly
                [<Emit("""import { Chart } from "chart.js";
Chart.version{{=$0}}""")>]
                static member inline version
                    with get () : string =
                        nativeOnly
                [<Emit("""import { Chart } from "chart.js";
Chart.instances{{=$0}}""")>]
                static member inline instances
                    with get () : Chart.instances__ =
                        nativeOnly
                [<Emit("""import { Chart } from "chart.js";
Chart.registry{{=$0}}""")>]
                static member inline registry
                    with get () : ChartJs.Registry =
                        nativeOnly
                [<Emit("""import { Chart } from "chart.js";
Chart.getChart($0)""")>]
                static member inline getChart (key: string): ChartJs.dist.types.Chart option = nativeOnly
                [<Emit("""import { Chart } from "chart.js";
Chart.getChart($0)""")>]
                static member inline getChart (key: Glutinum.Web.CanvasRenderingContext2D): ChartJs.dist.types.Chart option = nativeOnly
                [<Emit("""import { Chart } from "chart.js";
Chart.getChart($0)""")>]
                static member inline getChart (key: Glutinum.Web.HTMLCanvasElement): ChartJs.dist.types.Chart option = nativeOnly
                [<Emit("""import { Chart } from "chart.js";
Chart.getChart($0)""")>]
                static member inline getChart (key: U3<string, Glutinum.Web.CanvasRenderingContext2D, Glutinum.Web.HTMLCanvasElement>): ChartJs.dist.types.Chart option = nativeOnly
                [<Emit("""import { Chart } from "chart.js";
Chart.register($0)""")>]
                static member inline register ([<ParamArray>] items: ChartJs.ChartComponentLike []): unit = nativeOnly
                [<Emit("""import { Chart } from "chart.js";
Chart.unregister($0)""")>]
                static member inline unregister ([<ParamArray>] items: ChartJs.ChartComponentLike []): unit = nativeOnly

            type Chart<'TType, 'TData> =
                Chart<'TType, 'TData, obj>

            type Chart<'TType> =
                Chart<'TType, ResizeArray<U4<float, ChartJs.Point, float * float, ChartJs.BubbleDataPoint> option>, obj>

            type Chart =
                Chart<ChartJs.ChartType, ResizeArray<U4<float, ChartJs.Point, float * float, ChartJs.BubbleDataPoint> option>, obj>

            [<AllowNullLiteral>]
            [<Interface>]
            type BaseDecimationOptions =
                abstract member enabled: bool with get, set
                abstract member threshold: float option with get, set

            [<AllowNullLiteral>]
            [<Interface>]
            type LttbDecimationOptions =
                inherit ChartJs.dist.types.BaseDecimationOptions
                abstract member algorithm: LttbDecimationOptions.algorithm with get, set
                abstract member samples: float option with get, set

            [<AllowNullLiteral>]
            [<Interface>]
            type MinMaxDecimationOptions =
                inherit ChartJs.dist.types.BaseDecimationOptions
                abstract member algorithm: MinMaxDecimationOptions.algorithm with get, set

            module animation =

                [<AbstractClass>]
                [<Erase>]
                type Exports =
                    [<Import("Animation", "chart.js"); EmitConstructor>]
                    static member Animation (cfg: ChartJs.AnyObject, target: ChartJs.AnyObject, prop: string, ?``to``: obj) : Animation = nativeOnly
                    [<Import("Animator", "chart.js"); EmitConstructor>]
                    static member Animator () : Animator = nativeOnly

                [<AllowNullLiteral>]
                [<Interface>]
                type Animation =
                    abstract member active: unit -> bool
                    abstract member update: cfg: ChartJs.AnyObject * ``to``: obj * date: float -> unit
                    abstract member cancel: unit -> unit
                    abstract member tick: date: float -> unit
                    abstract member _to: obj with get

                [<AllowNullLiteral>]
                [<Interface>]
                type Animator =
                    abstract member listen: chart: ChartJs.dist.types.Chart * event: Animator.listen.event * cb: (ChartJs.AnimationEvent -> unit) -> unit
                    abstract member add: chart: ChartJs.dist.types.Chart * items: ResizeArray<ChartJs.dist.types.animation.Animation> -> unit
                    abstract member has: chart: ChartJs.dist.types.Chart -> bool
                    abstract member start: chart: ChartJs.dist.types.Chart -> unit
                    abstract member running: chart: ChartJs.dist.types.Chart -> bool
                    abstract member stop: chart: ChartJs.dist.types.Chart -> unit
                    abstract member remove: chart: ChartJs.dist.types.Chart -> bool

                module Animator =

                    module listen =

                        [<RequireQualifiedAccess>]
                        [<StringEnum(CaseRules.None)>]
                        type event =
                            | complete
                            | progress

            type ChartMetaCommon<'TElement> =
                ChartMetaCommon<'TElement, ChartJs.Element>

            type ChartMetaCommon =
                ChartMetaCommon<ChartJs.Element, ChartJs.Element>

            module ChartMetaCommon =

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type indexAxis =
                    | x
                    | y

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type _stacked =
                    | [<CompiledValue(true)>] True
                    | [<CompiledValue(false)>] False
                    | single

            module Chart =

                [<AllowNullLiteral>]
                [<Interface>]
                type scales =
                    [<EmitIndexer>]
                    abstract member Item: key: string -> ChartJs.Scale with get, set

                [<AllowNullLiteral>]
                [<Interface>]
                type getContext =
                    abstract member chart: ChartJs.dist.types.Chart with get, set
                    abstract member ``type``: string with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (chart: ChartJs.dist.types.Chart, ``type``: string) : getContext = nativeOnly

                [<AllowNullLiteral>]
                [<Interface>]
                type instances__ =
                    [<EmitIndexer>]
                    abstract member Item: key: string -> ChartJs.dist.types.Chart with get, set

                module update =

                    module mode =

                        [<AllowNullLiteral>]
                        [<Interface>]
                        type ctx =
                            abstract member datasetIndex: float with get, set
                            [<ParamObject; Emit("$0")>]
                            static member Create (datasetIndex: float) : ctx = nativeOnly

            module LttbDecimationOptions =

                [<RequireQualifiedAccess>]
                [<Erase(CaseRules.None)>]
                type algorithm =
                    | lttb
                    | Case1 of ChartJs.DecimationAlgorithm

                    [<Emit("$0")>]
                    static member op_Implicit(value: ChartJs.DecimationAlgorithm) : algorithm = nativeOnly

                    [<Emit("$0")>]
                    static member op_ErasedCast(value: ChartJs.DecimationAlgorithm) : algorithm = nativeOnly

            module MinMaxDecimationOptions =

                [<RequireQualifiedAccess>]
                [<Erase(CaseRules.None)>]
                type algorithm =
                    | ``min-max``
                    | Case1 of ChartJs.DecimationAlgorithm

                    [<Emit("$0")>]
                    static member op_Implicit(value: ChartJs.DecimationAlgorithm) : algorithm = nativeOnly

                    [<Emit("$0")>]
                    static member op_ErasedCast(value: ChartJs.DecimationAlgorithm) : algorithm = nativeOnly

            module Exports =

                module Chart =

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type item =
                        abstract member canvas: Glutinum.Web.HTMLCanvasElement with get, set
                        [<ParamObject; Emit("$0")>]
                        static member Create (canvas: Glutinum.Web.HTMLCanvasElement) : item = nativeOnly

    module helpers =

        [<AbstractClass>]
        [<Erase>]
        type Exports =
            /// <summary>
            /// Converts the given font object into a CSS font string.
            /// </summary>
            /// <param name="font">
            /// A font object.
            /// </param>
            /// <returns>
            /// The CSS font string. See https://developer.mozilla.org/en-US/docs/Web/CSS/font
            /// </returns>
            [<Import("toFontString", "chart.js/helpers")>]
            static member toFontString (font: ChartJs.FontSpec) : string = nativeOnly
            [<Import("_measureText", "chart.js/helpers")>]
            static member _measureText (ctx: Glutinum.Web.CanvasRenderingContext2D, data: Exports._measureText__.data, gc: ResizeArray<string>, longest: float, string: string) : float = nativeOnly
            [<Import("_longestText", "chart.js/helpers")>]
            static member _longestText (ctx: Glutinum.Web.CanvasRenderingContext2D, font: string, arrayOfThings: ChartJs.helpers.Things, ?cache: Exports._longestText__.cache) : float = nativeOnly
            /// <summary>
            /// Returns the aligned pixel value to avoid anti-aliasing blur
            /// </summary>
            /// <param name="chart">
            /// The chart instance.
            /// </param>
            /// <param name="pixel">
            /// A pixel value.
            /// </param>
            /// <param name="width">
            /// The width of the element.
            /// </param>
            /// <returns>
            /// The aligned pixel value.
            /// </returns>
            [<Import("_alignPixel", "chart.js/helpers")>]
            static member _alignPixel (chart: ChartJs.dist.types.Chart, pixel: float, width: float) : float = nativeOnly
            /// <summary>
            /// Clears the entire canvas.
            /// </summary>
            [<Import("clearCanvas", "chart.js/helpers")>]
            static member clearCanvas (?canvas: Glutinum.Web.HTMLCanvasElement, ?ctx: Glutinum.Web.CanvasRenderingContext2D) : unit = nativeOnly
            [<Import("drawPoint", "chart.js/helpers")>]
            static member drawPoint (ctx: Glutinum.Web.CanvasRenderingContext2D, options: ChartJs.helpers.DrawPointOptions, x: float, y: float) : unit = nativeOnly
            [<Import("drawPointLegend", "chart.js/helpers")>]
            static member drawPointLegend (ctx: Glutinum.Web.CanvasRenderingContext2D, options: ChartJs.helpers.DrawPointOptions, x: float, y: float, w: float) : unit = nativeOnly
            /// <summary>
            /// Returns true if the point is inside the rectangle
            /// </summary>
            /// <param name="point">
            /// The point to test
            /// </param>
            /// <param name="area">
            /// The rectangle
            /// </param>
            /// <param name="margin">
            /// allowed margin
            /// </param>
            [<Import("_isPointInArea", "chart.js/helpers")>]
            static member _isPointInArea (point: ChartJs.Point, area: ChartJs.TRBL, ?margin: float) : bool = nativeOnly
            [<Import("clipArea", "chart.js/helpers")>]
            static member clipArea (ctx: Glutinum.Web.CanvasRenderingContext2D, area: ChartJs.TRBL) : unit = nativeOnly
            [<Import("unclipArea", "chart.js/helpers")>]
            static member unclipArea (ctx: Glutinum.Web.CanvasRenderingContext2D) : unit = nativeOnly
            [<Import("_steppedLineTo", "chart.js/helpers")>]
            static member _steppedLineTo (ctx: Glutinum.Web.CanvasRenderingContext2D, previous: ChartJs.Point, target: ChartJs.Point, ?flip: bool, ?mode: string) : unit = nativeOnly
            [<Import("_bezierCurveTo", "chart.js/helpers")>]
            static member _bezierCurveTo (ctx: Glutinum.Web.CanvasRenderingContext2D, previous: ChartJs.SplinePoint, target: ChartJs.SplinePoint, ?flip: bool) : unit = nativeOnly
            /// <summary>
            /// Render text onto the canvas
            /// </summary>
            [<Import("renderText", "chart.js/helpers")>]
            static member renderText (ctx: Glutinum.Web.CanvasRenderingContext2D, text: string, x: float, y: float, font: ChartJs.CanvasFontSpec, ?opts: ChartJs.RenderTextOpts) : unit = nativeOnly
            /// <summary>
            /// Render text onto the canvas
            /// </summary>
            [<Import("renderText", "chart.js/helpers")>]
            static member renderText (ctx: Glutinum.Web.CanvasRenderingContext2D, text: ResizeArray<string>, x: float, y: float, font: ChartJs.CanvasFontSpec, ?opts: ChartJs.RenderTextOpts) : unit = nativeOnly
            /// <summary>
            /// Render text onto the canvas
            /// </summary>
            [<Import("renderText", "chart.js/helpers")>]
            static member renderText (ctx: Glutinum.Web.CanvasRenderingContext2D, text: U2<string, ResizeArray<string>>, x: float, y: float, font: ChartJs.CanvasFontSpec, ?opts: ChartJs.RenderTextOpts) : unit = nativeOnly
            /// <summary>
            /// Add a path of a rectangle with rounded corners to the current sub-path
            /// </summary>
            /// <param name="ctx">
            /// Context
            /// </param>
            /// <param name="rect">
            /// Bounding rect
            /// </param>
            [<Import("addRoundedRectPath", "chart.js/helpers")>]
            static member addRoundedRectPath (ctx: Glutinum.Web.CanvasRenderingContext2D, rect: Exports.addRoundedRectPath__.rect) : unit = nativeOnly
            /// <summary>
            /// Binary search
            /// </summary>
            /// <param name="table">
            /// the table search. must be sorted!
            /// </param>
            /// <param name="value">
            /// value to find
            /// </param>
            /// <param name="cmp">
            ///
            /// </param>
            [<Import("_lookup", "chart.js/helpers")>]
            static member _lookup (table: ResizeArray<float>, value: float, ?cmp: (float -> bool)) : Exports._lookup__ = nativeOnly
            [<Import("_lookup", "chart.js/helpers")>]
            static member _lookup<'T> (table: ResizeArray<'T>, value: float, cmp: (float -> bool)) : Exports._lookup__ = nativeOnly
            /// <summary>
            /// Binary search
            /// </summary>
            /// <param name="table">
            /// the table search. must be sorted!
            /// </param>
            /// <param name="key">
            /// property name for the value in each entry
            /// </param>
            /// <param name="value">
            /// value to find
            /// </param>
            /// <param name="last">
            /// lookup last index
            /// </param>
            [<Import("_lookupByKey", "chart.js/helpers")>]
            static member inline _lookupByKey: Exports._lookupByKey__.Type = nativeOnly
            /// <summary>
            /// Reverse binary search
            /// </summary>
            /// <param name="table">
            /// the table search. must be sorted!
            /// </param>
            /// <param name="key">
            /// property name for the value in each entry
            /// </param>
            /// <param name="value">
            /// value to find
            /// </param>
            [<Import("_rlookupByKey", "chart.js/helpers")>]
            static member inline _rlookupByKey: Exports._rlookupByKey__.Type = nativeOnly
            /// <summary>
            /// Return subset of <c>values</c> between <c>min</c> and <c>max</c> inclusive.
            /// Values are assumed to be in sorted order.
            /// </summary>
            /// <param name="values">
            /// sorted array of values
            /// </param>
            /// <param name="min">
            /// min value
            /// </param>
            /// <param name="max">
            /// max value
            /// </param>
            [<Import("_filterBetween", "chart.js/helpers")>]
            static member _filterBetween (values: ResizeArray<float>, min: float, max: float) : ResizeArray<float> = nativeOnly
            /// <summary>
            /// Hooks the array methods that add or remove values ('push', pop', 'shift', 'splice',
            /// 'unshift') and notify the listener AFTER the array has been altered. Listeners are
            /// called on the '_onData*' callbacks (e.g. _onDataPush, etc.) with same arguments.
            /// </summary>
            [<Import("listenArrayEvents", "chart.js/helpers")>]
            static member listenArrayEvents<'T> (array: ResizeArray<'T>, listener: ChartJs.helpers.ArrayListener<'T>) : unit = nativeOnly
            /// <summary>
            /// Removes the given array event listener and cleanup extra attached properties (such as
            /// the _chartjs stub and overridden methods) if array doesn't have any more listeners.
            /// </summary>
            [<Import("unlistenArrayEvents", "chart.js/helpers")>]
            static member unlistenArrayEvents<'T> (array: ResizeArray<'T>, listener: ChartJs.helpers.ArrayListener<'T>) : unit = nativeOnly
            /// <param name="items">
            ///
            /// </param>
            [<Import("_arrayUnique", "chart.js/helpers")>]
            static member _arrayUnique<'T> (items: ResizeArray<'T>) : ResizeArray<'T> = nativeOnly
            [<Import("isPatternOrGradient", "chart.js/helpers")>]
            static member isPatternOrGradient (value: obj) : bool = nativeOnly
            [<Import("color", "chart.js/helpers")>]
            static member color (value: Glutinum.Web.CanvasGradient) : Glutinum.Web.CanvasGradient = nativeOnly
            [<Import("color", "chart.js/helpers")>]
            static member color (value: Glutinum.Web.CanvasPattern) : Glutinum.Web.CanvasPattern = nativeOnly
            [<Import("color", "chart.js/helpers")>]
            static member color (value: string) : KurkleColor.Color = nativeOnly
            [<Import("color", "chart.js/helpers")>]
            static member color (value: Exports.color__.value) : KurkleColor.Color = nativeOnly
            [<Import("color", "chart.js/helpers")>]
            static member color (value: (float * float * float)) : KurkleColor.Color = nativeOnly
            [<Import("color", "chart.js/helpers")>]
            static member color (value: (float * float * float * float)) : KurkleColor.Color = nativeOnly
            [<Import("color", "chart.js/helpers")>]
            static member color (value: U4<string, Exports.color__.value, float * float * float, float * float * float * float>) : KurkleColor.Color = nativeOnly
            [<Import("getHoverColor", "chart.js/helpers")>]
            static member getHoverColor (value: Glutinum.Web.CanvasGradient) : Glutinum.Web.CanvasGradient = nativeOnly
            [<Import("getHoverColor", "chart.js/helpers")>]
            static member getHoverColor (value: Glutinum.Web.CanvasPattern) : Glutinum.Web.CanvasPattern = nativeOnly
            [<Import("getHoverColor", "chart.js/helpers")>]
            static member getHoverColor (value: string) : string = nativeOnly
            /// <summary>
            /// Creates a Proxy for resolving raw values for options.
            /// </summary>
            /// <param name="scopes">
            /// The option scopes to look for values, in resolution order
            /// </param>
            /// <param name="prefixes">
            /// The prefixes for values, in resolution order.
            /// </param>
            /// <param name="rootScopes">
            /// The root option scopes
            /// </param>
            /// <param name="fallback">
            /// Parent scopes fallback
            /// </param>
            /// <param name="getTarget">
            /// callback for getting the target for changed values
            /// </param>
            /// <returns>
            /// Proxy
            /// </returns>
            [<Import("_createResolver", "chart.js/helpers")>]
            static member _createResolver<'T, 'R> (scopes: 'T, ?prefixes: ResizeArray<string>, ?rootScopes: 'R, ?fallback: ChartJs.helpers.ResolverObjectKey, ?getTarget: (unit -> ChartJs.AnyObject)) : obj = nativeOnly
            /// <summary>
            /// Creates a Proxy for resolving raw values for options.
            /// </summary>
            /// <param name="scopes">
            /// The option scopes to look for values, in resolution order
            /// </param>
            /// <param name="prefixes">
            /// The prefixes for values, in resolution order.
            /// </param>
            /// <param name="rootScopes">
            /// The root option scopes
            /// </param>
            /// <param name="fallback">
            /// Parent scopes fallback
            /// </param>
            /// <param name="getTarget">
            /// callback for getting the target for changed values
            /// </param>
            /// <returns>
            /// Proxy
            /// </returns>
            [<Import("_createResolver", "chart.js/helpers")>]
            static member _createResolver (scopes: ResizeArray<ChartJs.AnyObject>, ?prefixes: ResizeArray<string>, ?rootScopes: ResizeArray<ChartJs.AnyObject>, ?fallback: ChartJs.helpers.ResolverObjectKey, ?getTarget: (unit -> ChartJs.AnyObject)) : obj = nativeOnly
            /// <summary>
            /// Returns an Proxy for resolving option values with context.
            /// </summary>
            /// <param name="proxy">
            /// The Proxy returned by <c>_createResolver</c>
            /// </param>
            /// <param name="context">
            /// Context object for scriptable/indexable options
            /// </param>
            /// <param name="subProxy">
            /// The proxy provided for scriptable options
            /// </param>
            /// <param name="descriptorDefaults">
            /// Defaults for descriptors
            /// </param>
            [<Import("_attachContext", "chart.js/helpers")>]
            static member _attachContext<'T, 'R> (proxy: ChartJs.helpers.ResolverProxy<'T, 'R>, context: ChartJs.AnyObject, ?subProxy: ChartJs.helpers.ResolverProxy<'T, 'R>, ?descriptorDefaults: ChartJs.helpers.DescriptorDefaults) : ChartJs.helpers.ContextProxy<'T, 'R> = nativeOnly
            /// <summary>
            /// Returns an Proxy for resolving option values with context.
            /// </summary>
            /// <param name="proxy">
            /// The Proxy returned by <c>_createResolver</c>
            /// </param>
            /// <param name="context">
            /// Context object for scriptable/indexable options
            /// </param>
            /// <param name="subProxy">
            /// The proxy provided for scriptable options
            /// </param>
            /// <param name="descriptorDefaults">
            /// Defaults for descriptors
            /// </param>
            [<Import("_attachContext", "chart.js/helpers")>]
            static member _attachContext (proxy: ChartJs.helpers.ResolverProxy<ResizeArray<ChartJs.AnyObject>, ResizeArray<ChartJs.AnyObject>>, context: ChartJs.AnyObject, ?subProxy: ChartJs.helpers.ResolverProxy<ResizeArray<ChartJs.AnyObject>, ResizeArray<ChartJs.AnyObject>>, ?descriptorDefaults: ChartJs.helpers.DescriptorDefaults) : ChartJs.helpers.ContextProxy<ResizeArray<ChartJs.AnyObject>, ResizeArray<ChartJs.AnyObject>> = nativeOnly
            [<Import("_descriptors", "chart.js/helpers")>]
            static member _descriptors (proxy: ChartJs.helpers.ResolverCache, ?defaults: ChartJs.helpers.DescriptorDefaults) : ChartJs.helpers.Descriptor = nativeOnly
            [<Import("_parseObjectDataRadialScale", "chart.js/helpers")>]
            static member _parseObjectDataRadialScale (meta: ChartJs.ChartMeta<Exports._parseObjectDataRadialScale__.meta>, data: ResizeArray<ChartJs.AnyObject>, start: float, count: float) : ResizeArray<Exports._parseObjectDataRadialScale__.Item> = nativeOnly
            /// <summary>
            /// An empty function that can be used, for example, for optional callback.
            /// </summary>
            [<Import("noop", "chart.js/helpers")>]
            static member noop () : unit = nativeOnly
            /// <summary>
            /// Returns a unique id, sequentially generated from a global variable.
            /// </summary>
            [<Import("uid", "chart.js/helpers")>]
            static member inline uid: (unit -> float) = nativeOnly
            /// <summary>
            /// Returns true if <c>value</c> is neither null nor undefined, else returns false.
            /// </summary>
            /// <param name="value">
            /// The value to test.
            /// </param>
            [<Import("isNullOrUndef", "chart.js/helpers")>]
            static member isNullOrUndef (value: obj) : bool = nativeOnly
            /// <summary>
            /// Returns true if <c>value</c> is an array (including typed arrays), else returns false.
            /// </summary>
            /// <param name="value">
            /// The value to test.
            /// </param>
            [<Import("isArray", "chart.js/helpers")>]
            static member isArray<'T> (value: obj) : bool = nativeOnly
            /// <summary>
            /// Returns true if <c>value</c> is an object (excluding null), else returns false.
            /// </summary>
            /// <param name="value">
            /// The value to test.
            /// </param>
            [<Import("isObject", "chart.js/helpers")>]
            static member isObject (value: obj) : bool = nativeOnly
            /// <summary>
            /// Returns <c>value</c> if finite, else returns <c>defaultValue</c>.
            /// </summary>
            /// <param name="value">
            /// The value to return if defined.
            /// </param>
            /// <param name="defaultValue">
            /// The value to return if <c>value</c> is not finite.
            /// </param>
            [<Import("finiteOrDefault", "chart.js/helpers")>]
            static member finiteOrDefault (value: obj, defaultValue: float) : float = nativeOnly
            /// <summary>
            /// Returns <c>value</c> if defined, else returns <c>defaultValue</c>.
            /// </summary>
            /// <param name="value">
            /// The value to return if defined.
            /// </param>
            /// <param name="defaultValue">
            /// The value to return if <c>value</c> is undefined.
            /// </param>
            [<Import("valueOrDefault", "chart.js/helpers")>]
            static member valueOrDefault<'T> (value: 'T option, defaultValue: 'T) : 'T = nativeOnly
            [<Import("toPercentage", "chart.js/helpers")>]
            static member inline toPercentage: Exports.toPercentage__.Type = nativeOnly
            [<Import("toDimension", "chart.js/helpers")>]
            static member inline toDimension: Exports.toDimension__.Type = nativeOnly
            /// <summary>
            /// Calls <c>fn</c> with the given <c>args</c> in the scope defined by <c>thisArg</c> and returns the
            /// value returned by <c>fn</c>. If <c>fn</c> is not a function, this method returns undefined.
            /// </summary>
            /// <param name="fn">
            /// The function to call.
            /// </param>
            /// <param name="args">
            /// The arguments with which <c>fn</c> should be called.
            /// </param>
            /// <param name="thisArg">
            /// The value of <c>this</c> provided for the call to <c>fn</c>.
            /// </param>
            [<Import("callback", "chart.js/helpers")>]
            static member callback<'T, 'TA, 'R> (fn: 'T option, args: ResizeArray<obj>, ?thisArg: 'TA) : 'R option = nativeOnly
            /// <summary>
            /// Note(SB) for performance sake, this method should only be used when loopable type
            /// is unknown or in none intensive code (not called often and small loopable). Else
            /// it's preferable to use a regular for() loop and save extra function calls.
            /// </summary>
            /// <param name="loopable">
            /// The object or array to be iterated.
            /// </param>
            /// <param name="fn">
            /// The function to call for each item.
            /// </param>
            /// <param name="thisArg">
            /// The value of <c>this</c> provided for the call to <c>fn</c>.
            /// </param>
            /// <param name="reverse">
            /// If true, iterates backward on the loopable.
            /// </param>
            [<Import("each", "chart.js/helpers")>]
            static member each<'T, 'TA> (loopable: Exports.each__.loopable<'T>, fn: Exports.each__.fn<'T>, ?thisArg: 'TA, ?reverse: bool) : unit = nativeOnly
            [<Import("each", "chart.js/helpers")>]
            static member each<'T, 'TA> (loopable: ResizeArray<'T>, fn: Exports.each__.fn_1<'T>, ?thisArg: 'TA, ?reverse: bool) : unit = nativeOnly
            /// <summary>
            /// Returns true if the <c>a0</c> and <c>a1</c> arrays have the same content, else returns false.
            /// </summary>
            /// <param name="a0">
            /// The array to compare
            /// </param>
            /// <param name="a1">
            /// The array to compare
            /// </param>
            [<Import("_elementsEqual", "chart.js/helpers")>]
            static member _elementsEqual (a0: ResizeArray<ChartJs.ActiveDataPoint>, a1: ResizeArray<ChartJs.ActiveDataPoint>) : bool = nativeOnly
            /// <summary>
            /// Returns a deep copy of <c>source</c> without keeping references on objects and arrays.
            /// </summary>
            /// <param name="source">
            /// The value to clone.
            /// </param>
            [<Import("clone", "chart.js/helpers")>]
            static member clone<'T> (source: 'T) : 'T = nativeOnly
            /// <summary>
            /// The default merger when Chart.helpers.merge is called without merger option.
            /// Note(SB): also used by mergeConfig and mergeScaleConfig as fallback.
            /// </summary>
            [<Import("_merger", "chart.js/helpers")>]
            static member _merger (key: string, target: ChartJs.AnyObject, source: ChartJs.AnyObject, options: ChartJs.AnyObject) : unit = nativeOnly
            /// <summary>
            /// Recursively deep copies <c>source</c> properties into <c>target</c> with the given <c>options</c>.
            /// IMPORTANT: <c>target</c> is not cloned and will be updated with <c>source</c> properties.
            /// </summary>
            /// <param name="target">
            /// The target object in which all sources are merged into.
            /// </param>
            /// <param name="source">
            /// Object(s) to merge into <c>target</c>.
            /// </param>
            /// <param name="options">
            /// Merging options:
            /// </param>
            /// <param name="options.merger">
            /// The merge method (key, target, source, options)
            /// </param>
            /// <returns>
            /// The <c>target</c> object.
            /// </returns>
            [<Import("merge", "chart.js/helpers")>]
            static member merge<'T> (target: 'T, source: obj, ?options: ChartJs.helpers.MergeOptions) : 'T = nativeOnly
            [<Import("merge", "chart.js/helpers")>]
            static member merge<'T, 'S1> (target: 'T, source: ResizeArray<'S1>, ?options: ChartJs.helpers.MergeOptions) : obj = nativeOnly
            [<Import("merge", "chart.js/helpers")>]
            static member merge<'T, 'S1, 'S2> (target: 'T, source: ('S1 * 'S2), ?options: ChartJs.helpers.MergeOptions) : obj = nativeOnly
            [<Import("merge", "chart.js/helpers")>]
            static member merge<'T, 'S1, 'S2, 'S3> (target: 'T, source: ('S1 * 'S2 * 'S3), ?options: ChartJs.helpers.MergeOptions) : obj = nativeOnly
            [<Import("merge", "chart.js/helpers")>]
            static member merge<'T, 'S1, 'S2, 'S3, 'S4> (target: 'T, source: ('S1 * 'S2 * 'S3 * 'S4), ?options: ChartJs.helpers.MergeOptions) : obj = nativeOnly
            [<Import("merge", "chart.js/helpers")>]
            static member merge<'T> (target: 'T, source: ResizeArray<ChartJs.AnyObject>, ?options: ChartJs.helpers.MergeOptions) : ChartJs.AnyObject = nativeOnly
            /// <summary>
            /// Recursively deep copies <c>source</c> properties into <c>target</c> *only* if not defined in target.
            /// IMPORTANT: <c>target</c> is not cloned and will be updated with <c>source</c> properties.
            /// </summary>
            /// <param name="target">
            /// The target object in which all sources are merged into.
            /// </param>
            /// <param name="source">
            /// Object(s) to merge into <c>target</c>.
            /// </param>
            /// <returns>
            /// The <c>target</c> object.
            /// </returns>
            [<Import("mergeIf", "chart.js/helpers")>]
            static member mergeIf<'T> (target: 'T, source: obj) : 'T = nativeOnly
            [<Import("mergeIf", "chart.js/helpers")>]
            static member mergeIf<'T, 'S1> (target: 'T, source: ResizeArray<'S1>) : obj = nativeOnly
            [<Import("mergeIf", "chart.js/helpers")>]
            static member mergeIf<'T, 'S1, 'S2> (target: 'T, source: ('S1 * 'S2)) : obj = nativeOnly
            [<Import("mergeIf", "chart.js/helpers")>]
            static member mergeIf<'T, 'S1, 'S2, 'S3> (target: 'T, source: ('S1 * 'S2 * 'S3)) : obj = nativeOnly
            [<Import("mergeIf", "chart.js/helpers")>]
            static member mergeIf<'T, 'S1, 'S2, 'S3, 'S4> (target: 'T, source: ('S1 * 'S2 * 'S3 * 'S4)) : obj = nativeOnly
            [<Import("mergeIf", "chart.js/helpers")>]
            static member mergeIf<'T> (target: 'T, source: ResizeArray<ChartJs.AnyObject>) : ChartJs.AnyObject = nativeOnly
            /// <summary>
            /// Merges source[key] in target[key] only if target[key] is undefined.
            /// </summary>
            [<Import("_mergerIf", "chart.js/helpers")>]
            static member _mergerIf (key: string, target: ChartJs.AnyObject, source: ChartJs.AnyObject) : unit = nativeOnly
            [<Import("_deprecated", "chart.js/helpers")>]
            static member _deprecated (scope: string, value: obj, previous: string, current: string) : unit = nativeOnly
            [<Import("_splitKey", "chart.js/helpers")>]
            static member _splitKey (key: string) : ResizeArray<string> = nativeOnly
            [<Import("resolveObjectKey", "chart.js/helpers")>]
            static member resolveObjectKey (obj: ChartJs.AnyObject, key: string) : obj = nativeOnly
            [<Import("_capitalize", "chart.js/helpers")>]
            static member _capitalize (str: string) : string = nativeOnly
            [<Import("defined", "chart.js/helpers")>]
            static member inline defined: (obj -> bool) = nativeOnly
            [<Import("isFunction", "chart.js/helpers")>]
            static member inline isFunction: (obj -> bool) = nativeOnly
            [<Import("setsEqual", "chart.js/helpers")>]
            static member inline setsEqual: Exports.setsEqual__.Type = nativeOnly
            /// <param name="e">
            /// The event
            /// </param>
            [<Import("_isClickEvent", "chart.js/helpers")>]
            static member _isClickEvent (e: ChartJs.ChartEvent) : bool = nativeOnly
            [<Import("splineCurve", "chart.js/helpers")>]
            static member splineCurve (firstPoint: ChartJs.SplinePoint, middlePoint: ChartJs.SplinePoint, afterPoint: ChartJs.SplinePoint, t: float) : Exports.splineCurve__ = nativeOnly
            /// <summary>
            /// This function calculates Bézier control points in a similar way than |splineCurve|,
            /// but preserves monotonicity of the provided data and ensures no local extremums are added
            /// between the dataset discrete points due to the interpolation.
            /// See : https://en.wikipedia.org/wiki/Monotone_cubic_interpolation
            /// </summary>
            [<Import("splineCurveMonotone", "chart.js/helpers")>]
            static member splineCurveMonotone (points: ResizeArray<ChartJs.SplinePoint>, ?indexAxis: Exports.splineCurveMonotone__.indexAxis) : unit = nativeOnly
            [<Import("_updateBezierControlPoints", "chart.js/helpers")>]
            static member _updateBezierControlPoints (points: ResizeArray<ChartJs.SplinePoint>, options: obj, area: ChartJs.ChartArea, loop: bool, indexAxis: Exports._updateBezierControlPoints__.indexAxis) : unit = nativeOnly
            [<Import("getDatasetClipArea", "chart.js/helpers")>]
            static member getDatasetClipArea (chart: ChartJs.dist.types.Chart, meta: ChartJs.ChartMeta) : U2<ChartJs.TRBL, bool> = nativeOnly
            [<Import("_isDomSupported", "chart.js/helpers")>]
            static member _isDomSupported () : bool = nativeOnly
            [<Import("_getParentNode", "chart.js/helpers")>]
            static member _getParentNode (domNode: Glutinum.Web.HTMLCanvasElement) : Glutinum.Web.HTMLCanvasElement = nativeOnly
            [<Import("getStyle", "chart.js/helpers")>]
            static member getStyle (el: Glutinum.Web.HTMLElement, property: string) : string = nativeOnly
            /// <summary>
            /// Gets an event's x, y coordinates, relative to the chart area
            /// </summary>
            /// <param name="event">
            ///
            /// </param>
            /// <param name="chart">
            ///
            /// </param>
            /// <returns>
            /// x and y coordinates of the event
            /// </returns>
            [<Import("getRelativePosition", "chart.js/helpers")>]
            static member getRelativePosition (event: Glutinum.Web.Event, chart: ChartJs.dist.types.Chart) : Exports.getRelativePosition__ = nativeOnly
            /// <summary>
            /// Gets an event's x, y coordinates, relative to the chart area
            /// </summary>
            /// <param name="event">
            ///
            /// </param>
            /// <param name="chart">
            ///
            /// </param>
            /// <returns>
            /// x and y coordinates of the event
            /// </returns>
            [<Import("getRelativePosition", "chart.js/helpers")>]
            static member getRelativePosition (event: Glutinum.Web.Event, chart: ChartJs.dist.core.core_controller.Chart) : Exports.getRelativePosition__ = nativeOnly
            /// <summary>
            /// Gets an event's x, y coordinates, relative to the chart area
            /// </summary>
            /// <param name="event">
            ///
            /// </param>
            /// <param name="chart">
            ///
            /// </param>
            /// <returns>
            /// x and y coordinates of the event
            /// </returns>
            [<Import("getRelativePosition", "chart.js/helpers")>]
            static member getRelativePosition (event: ChartJs.ChartEvent, chart: ChartJs.dist.types.Chart) : Exports.getRelativePosition__ = nativeOnly
            /// <summary>
            /// Gets an event's x, y coordinates, relative to the chart area
            /// </summary>
            /// <param name="event">
            ///
            /// </param>
            /// <param name="chart">
            ///
            /// </param>
            /// <returns>
            /// x and y coordinates of the event
            /// </returns>
            [<Import("getRelativePosition", "chart.js/helpers")>]
            static member getRelativePosition (event: ChartJs.ChartEvent, chart: ChartJs.dist.core.core_controller.Chart) : Exports.getRelativePosition__ = nativeOnly
            /// <summary>
            /// Gets an event's x, y coordinates, relative to the chart area
            /// </summary>
            /// <param name="event">
            ///
            /// </param>
            /// <param name="chart">
            ///
            /// </param>
            /// <returns>
            /// x and y coordinates of the event
            /// </returns>
            [<Import("getRelativePosition", "chart.js/helpers")>]
            static member getRelativePosition (event: Glutinum.Web.TouchEvent, chart: ChartJs.dist.types.Chart) : Exports.getRelativePosition__ = nativeOnly
            /// <summary>
            /// Gets an event's x, y coordinates, relative to the chart area
            /// </summary>
            /// <param name="event">
            ///
            /// </param>
            /// <param name="chart">
            ///
            /// </param>
            /// <returns>
            /// x and y coordinates of the event
            /// </returns>
            [<Import("getRelativePosition", "chart.js/helpers")>]
            static member getRelativePosition (event: Glutinum.Web.TouchEvent, chart: ChartJs.dist.core.core_controller.Chart) : Exports.getRelativePosition__ = nativeOnly
            /// <summary>
            /// Gets an event's x, y coordinates, relative to the chart area
            /// </summary>
            /// <param name="event">
            ///
            /// </param>
            /// <param name="chart">
            ///
            /// </param>
            /// <returns>
            /// x and y coordinates of the event
            /// </returns>
            [<Import("getRelativePosition", "chart.js/helpers")>]
            static member getRelativePosition (event: Glutinum.Web.MouseEvent, chart: ChartJs.dist.types.Chart) : Exports.getRelativePosition__ = nativeOnly
            /// <summary>
            /// Gets an event's x, y coordinates, relative to the chart area
            /// </summary>
            /// <param name="event">
            ///
            /// </param>
            /// <param name="chart">
            ///
            /// </param>
            /// <returns>
            /// x and y coordinates of the event
            /// </returns>
            [<Import("getRelativePosition", "chart.js/helpers")>]
            static member getRelativePosition (event: Glutinum.Web.MouseEvent, chart: ChartJs.dist.core.core_controller.Chart) : Exports.getRelativePosition__ = nativeOnly
            /// <summary>
            /// Gets an event's x, y coordinates, relative to the chart area
            /// </summary>
            /// <param name="event">
            ///
            /// </param>
            /// <param name="chart">
            ///
            /// </param>
            /// <returns>
            /// x and y coordinates of the event
            /// </returns>
            [<Import("getRelativePosition", "chart.js/helpers")>]
            static member getRelativePosition (event: U4<Glutinum.Web.Event, ChartJs.ChartEvent, Glutinum.Web.TouchEvent, Glutinum.Web.MouseEvent>, chart: U2<ChartJs.dist.types.Chart, ChartJs.dist.core.core_controller.Chart>) : Exports.getRelativePosition__ = nativeOnly
            [<Import("getMaximumSize", "chart.js/helpers")>]
            static member getMaximumSize (canvas: Glutinum.Web.HTMLCanvasElement, ?bbWidth: float, ?bbHeight: float, ?aspectRatio: float) : Exports.getMaximumSize__ = nativeOnly
            /// <param name="chart">
            ///
            /// </param>
            /// <param name="forceRatio">
            ///
            /// </param>
            /// <param name="forceStyle">
            ///
            /// </param>
            /// <returns>
            /// True if the canvas context size or transformation has changed.
            /// </returns>
            [<Import("retinaScale", "chart.js/helpers")>]
            static member retinaScale (chart: ChartJs.dist.types.Chart, forceRatio: float, ?forceStyle: bool) : U2<bool, unit> = nativeOnly
            /// <param name="chart">
            ///
            /// </param>
            /// <param name="forceRatio">
            ///
            /// </param>
            /// <param name="forceStyle">
            ///
            /// </param>
            /// <returns>
            /// True if the canvas context size or transformation has changed.
            /// </returns>
            [<Import("retinaScale", "chart.js/helpers")>]
            static member retinaScale (chart: ChartJs.dist.core.core_controller.Chart, forceRatio: float, ?forceStyle: bool) : U2<bool, unit> = nativeOnly
            /// <param name="chart">
            ///
            /// </param>
            /// <param name="forceRatio">
            ///
            /// </param>
            /// <param name="forceStyle">
            ///
            /// </param>
            /// <returns>
            /// True if the canvas context size or transformation has changed.
            /// </returns>
            [<Import("retinaScale", "chart.js/helpers")>]
            static member retinaScale (chart: U2<ChartJs.dist.types.Chart, ChartJs.dist.core.core_controller.Chart>, forceRatio: float, ?forceStyle: bool) : U2<bool, unit> = nativeOnly
            /// <summary>
            /// Detects support for options object argument in addEventListener.
            /// https://developer.mozilla.org/en-US/docs/Web/API/EventTarget/addEventListener#Safely_detecting_option_support
            /// </summary>
            [<Import("supportsEventListenerOptions", "chart.js/helpers")>]
            static member inline supportsEventListenerOptions: bool = nativeOnly
            /// <summary>
            /// The "used" size is the final value of a dimension property after all calculations have
            /// been performed. This method uses the computed style of <c>element</c> but returns undefined
            /// if the computed style is not expressed in pixels. That can happen in some cases where
            /// <c>element</c> has a size relative to its parent and this last one is not yet displayed,
            /// for example because of <c>display: none</c> on a parent node.
            /// </summary>
            /// <returns>
            /// Size in pixels or undefined if unknown.
            /// </returns>
            [<Import("readUsedSize", "chart.js/helpers")>]
            static member readUsedSize (element: Glutinum.Web.HTMLElement, property: Exports.readUsedSize__.property) : float option = nativeOnly
            [<Import("fontString", "chart.js/helpers")>]
            static member fontString (pixelSize: float, fontStyle: string, fontFamily: string) : string = nativeOnly
            /// <summary>
            /// Request animation polyfill
            /// </summary>
            [<Import("requestAnimFrame", "chart.js/helpers")>]
            static member inline requestAnimFrame: U2<obj, (obj -> unit)> = nativeOnly
            /// <summary>
            /// Throttles calling <c>fn</c> once per animation frame
            /// Latest arguments are used on the actual call
            /// </summary>
            [<Import("throttled", "chart.js/helpers")>]
            static member throttled<'TArgs> (fn: System.Delegate, thisArg: obj) : System.Delegate = nativeOnly
            /// <summary>
            /// Debounces calling <c>fn</c> for <c>delay</c> ms
            /// </summary>
            [<Import("debounce", "chart.js/helpers")>]
            static member debounce<'TArgs> (fn: System.Delegate, delay: float) : System.Delegate = nativeOnly
            /// <summary>
            /// Converts 'start' to 'left', 'end' to 'right' and others to 'center'
            /// </summary>
            [<Import("_toLeftRightCenter", "chart.js/helpers")>]
            static member inline _toLeftRightCenter: (Exports._toLeftRightCenter__.Type.align -> Exports._toLeftRightCenter__.Type) = nativeOnly
            /// <summary>
            /// Returns <c>start</c>, <c>end</c> or <c>(start + end) / 2</c> depending on <c>align</c>. Defaults to <c>center</c>
            /// </summary>
            [<Import("_alignStartEnd", "chart.js/helpers")>]
            static member inline _alignStartEnd: Exports._alignStartEnd__.Type = nativeOnly
            /// <summary>
            /// Returns <c>left</c>, <c>right</c> or <c>(left + right) / 2</c> depending on <c>align</c>. Defaults to <c>left</c>
            /// </summary>
            [<Import("_textX", "chart.js/helpers")>]
            static member inline _textX: Exports._textX__.Type = nativeOnly
            /// <summary>
            /// Return start and count of visible points.
            /// </summary>
            [<Import("_getStartAndCountOfVisiblePoints", "chart.js/helpers")>]
            static member _getStartAndCountOfVisiblePoints (meta: ChartJs.ChartMeta<Exports._getStartAndCountOfVisiblePoints__.meta>, points: ResizeArray<ChartJs.PointElement>, animationsDisabled: bool) : Exports._getStartAndCountOfVisiblePoints__ = nativeOnly
            /// <summary>
            /// Checks if the scale ranges have changed.
            /// </summary>
            /// <param name="meta">
            /// dataset meta.
            /// </param>
            [<Import("_scaleRangesChanged", "chart.js/helpers")>]
            static member _scaleRangesChanged (meta: obj) : bool = nativeOnly
            [<Import("_pointInLine", "chart.js/helpers")>]
            static member _pointInLine (p1: ChartJs.Point, p2: ChartJs.Point, t: float, ?mode: obj) : Exports._pointInLine__ = nativeOnly
            [<Import("_steppedInterpolation", "chart.js/helpers")>]
            static member _steppedInterpolation (p1: ChartJs.Point, p2: ChartJs.Point, t: float, mode: Exports._steppedInterpolation__.mode) : Exports._steppedInterpolation__ = nativeOnly
            [<Import("_bezierInterpolation", "chart.js/helpers")>]
            static member _bezierInterpolation (p1: ChartJs.SplinePoint, p2: ChartJs.SplinePoint, t: float, ?mode: obj) : Exports._bezierInterpolation__ = nativeOnly
            [<Import("formatNumber", "chart.js/helpers")>]
            static member formatNumber (num: float, locale: string, ?options: obj) : string = nativeOnly
            [<Import("PI", "chart.js/helpers")>]
            static member inline PI: float = nativeOnly
            [<Import("TAU", "chart.js/helpers")>]
            static member inline TAU: float = nativeOnly
            [<Import("PITAU", "chart.js/helpers")>]
            static member inline PITAU: float = nativeOnly
            [<Import("INFINITY", "chart.js/helpers")>]
            static member inline INFINITY: float = nativeOnly
            [<Import("RAD_PER_DEG", "chart.js/helpers")>]
            static member inline RAD_PER_DEG: float = nativeOnly
            [<Import("HALF_PI", "chart.js/helpers")>]
            static member inline HALF_PI: float = nativeOnly
            [<Import("QUARTER_PI", "chart.js/helpers")>]
            static member inline QUARTER_PI: float = nativeOnly
            [<Import("TWO_THIRDS_PI", "chart.js/helpers")>]
            static member inline TWO_THIRDS_PI: float = nativeOnly
            [<Import("log10", "chart.js/helpers")>]
            static member inline log10: (float -> float) = nativeOnly
            [<Import("sign", "chart.js/helpers")>]
            static member inline sign: (float -> float) = nativeOnly
            [<Import("almostEquals", "chart.js/helpers")>]
            static member almostEquals (x: float, y: float, epsilon: float) : bool = nativeOnly
            /// <summary>
            /// Implementation of the nice number algorithm used in determining where axis labels will go
            /// </summary>
            [<Import("niceNum", "chart.js/helpers")>]
            static member niceNum (range: float) : float = nativeOnly
            /// <summary>
            /// Returns an array of factors sorted from 1 to sqrt(value)
            /// </summary>
            [<Import("_factorize", "chart.js/helpers")>]
            static member _factorize (value: float) : ResizeArray<float> = nativeOnly
            [<Import("isNumber", "chart.js/helpers")>]
            static member isNumber (n: obj) : bool = nativeOnly
            [<Import("almostWhole", "chart.js/helpers")>]
            static member almostWhole (x: float, epsilon: float) : bool = nativeOnly
            [<Import("_setMinAndMaxByKey", "chart.js/helpers")>]
            static member _setMinAndMaxByKey (array: ResizeArray<Exports._setMinAndMaxByKey__.array.Item>, target: Exports._setMinAndMaxByKey__.target, property: string) : unit = nativeOnly
            [<Import("toRadians", "chart.js/helpers")>]
            static member toRadians (degrees: float) : float = nativeOnly
            [<Import("toDegrees", "chart.js/helpers")>]
            static member toDegrees (radians: float) : float = nativeOnly
            /// <summary>
            /// Returns the number of decimal places
            /// i.e. the number of digits after the decimal point, of the value of this Number.
            /// </summary>
            /// <param name="x">
            /// A number.
            /// </param>
            /// <returns>
            /// The number of decimal places.
            /// </returns>
            [<Import("_decimalPlaces", "chart.js/helpers")>]
            static member _decimalPlaces (x: float) : float = nativeOnly
            [<Import("getAngleFromPoint", "chart.js/helpers")>]
            static member getAngleFromPoint (centrePoint: ChartJs.Point, anglePoint: ChartJs.Point) : Exports.getAngleFromPoint__ = nativeOnly
            [<Import("distanceBetweenPoints", "chart.js/helpers")>]
            static member distanceBetweenPoints (pt1: ChartJs.Point, pt2: ChartJs.Point) : float = nativeOnly
            /// <summary>
            /// Shortest distance between angles, in either direction.
            /// </summary>
            [<Import("_angleDiff", "chart.js/helpers")>]
            static member _angleDiff (a: float, b: float) : float = nativeOnly
            /// <summary>
            /// Normalize angle to be between 0 and 2*PI
            /// </summary>
            [<Import("_normalizeAngle", "chart.js/helpers")>]
            static member _normalizeAngle (a: float) : float = nativeOnly
            [<Import("_angleBetween", "chart.js/helpers")>]
            static member _angleBetween (angle: float, start: float, ``end``: float, ?sameAngleIsFullCircle: bool) : bool = nativeOnly
            /// <summary>
            /// Limit <c>value</c> between <c>min</c> and <c>max</c>
            /// </summary>
            /// <param name="value">
            ///
            /// </param>
            /// <param name="min">
            ///
            /// </param>
            /// <param name="max">
            ///
            /// </param>
            [<Import("_limitValue", "chart.js/helpers")>]
            static member _limitValue (value: float, min: float, max: float) : float = nativeOnly
            /// <param name="value">
            ///
            /// </param>
            [<Import("_int16Range", "chart.js/helpers")>]
            static member _int16Range (value: float) : float = nativeOnly
            /// <param name="value">
            ///
            /// </param>
            /// <param name="start">
            ///
            /// </param>
            /// <param name="end">
            ///
            /// </param>
            /// <param name="epsilon">
            ///
            /// </param>
            [<Import("_isBetween", "chart.js/helpers")>]
            static member _isBetween (value: float, start: float, ``end``: float, ?epsilon: float) : bool = nativeOnly
            /// <summary>
            /// Converts the given line height <c>value</c> in pixels for a specific font <c>size</c>.
            /// </summary>
            /// <param name="value">
            /// The lineHeight to parse (eg. 1.6, '14px', '75%', '1.6em').
            /// </param>
            /// <param name="size">
            /// The font size (in pixels) used to resolve relative <c>value</c>.
            /// </param>
            /// <returns>
            /// The effective line height in pixels (size * 1.2 if value is invalid).
            /// </returns>
            [<Import("toLineHeight", "chart.js/helpers")>]
            static member toLineHeight (value: float, size: float) : float = nativeOnly
            /// <summary>
            /// Converts the given line height <c>value</c> in pixels for a specific font <c>size</c>.
            /// </summary>
            /// <param name="value">
            /// The lineHeight to parse (eg. 1.6, '14px', '75%', '1.6em').
            /// </param>
            /// <param name="size">
            /// The font size (in pixels) used to resolve relative <c>value</c>.
            /// </param>
            /// <returns>
            /// The effective line height in pixels (size * 1.2 if value is invalid).
            /// </returns>
            [<Import("toLineHeight", "chart.js/helpers")>]
            static member toLineHeight (value: string, size: float) : float = nativeOnly
            /// <summary>
            /// Converts the given line height <c>value</c> in pixels for a specific font <c>size</c>.
            /// </summary>
            /// <param name="value">
            /// The lineHeight to parse (eg. 1.6, '14px', '75%', '1.6em').
            /// </param>
            /// <param name="size">
            /// The font size (in pixels) used to resolve relative <c>value</c>.
            /// </param>
            /// <returns>
            /// The effective line height in pixels (size * 1.2 if value is invalid).
            /// </returns>
            [<Import("toLineHeight", "chart.js/helpers")>]
            static member toLineHeight (value: U2<float, string>, size: float) : float = nativeOnly
            /// <param name="value">
            ///
            /// </param>
            /// <param name="props">
            ///
            /// </param>
            [<Import("_readValueToProps", "chart.js/helpers")>]
            static member _readValueToProps (value: float, props: ResizeArray<string>) : Exports._readValueToProps__<string> = nativeOnly
            /// <param name="value">
            ///
            /// </param>
            /// <param name="props">
            ///
            /// </param>
            [<Import("_readValueToProps", "chart.js/helpers")>]
            static member _readValueToProps (value: Exports._readValueToProps__.value<string>, props: ResizeArray<string>) : Exports._readValueToProps__<string> = nativeOnly
            /// <param name="value">
            ///
            /// </param>
            /// <param name="props">
            ///
            /// </param>
            [<Import("_readValueToProps", "chart.js/helpers")>]
            static member _readValueToProps (value: U2<float, Exports._readValueToProps__.value.U2.Case2<string>>, props: ResizeArray<string>) : Exports._readValueToProps__<string> = nativeOnly
            [<Import("_readValueToProps", "chart.js/helpers")>]
            static member _readValueToProps (value: float, props: Exports._readValueToProps__.props<string, string>) : Exports._readValueToProps___1<string> = nativeOnly
            [<Import("_readValueToProps", "chart.js/helpers")>]
            static member _readValueToProps (value: Exports._readValueToProps__.value_1, props: Exports._readValueToProps__.props<string, string>) : Exports._readValueToProps___1<string> = nativeOnly
            [<Import("_readValueToProps", "chart.js/helpers")>]
            static member _readValueToProps (value: U2<float, Exports._readValueToProps__.value.U2.Case2_1>, props: Exports._readValueToProps__.props<string, string>) : Exports._readValueToProps___1<string> = nativeOnly
            /// <summary>
            /// Converts the given value into a TRBL object.
            /// </summary>
            /// <param name="value">
            /// If a number, set the value to all TRBL component,
            /// else, if an object, use defined properties and sets undefined ones to 0.
            /// x / y are shorthands for same value for left/right and top/bottom.
            /// </param>
            /// <returns>
            /// The padding values (top, right, bottom, left)
            /// </returns>
            [<Import("toTRBL", "chart.js/helpers")>]
            static member toTRBL (value: float) : Exports.toTRBL__ = nativeOnly
            /// <summary>
            /// Converts the given value into a TRBL object.
            /// </summary>
            /// <param name="value">
            /// If a number, set the value to all TRBL component,
            /// else, if an object, use defined properties and sets undefined ones to 0.
            /// x / y are shorthands for same value for left/right and top/bottom.
            /// </param>
            /// <returns>
            /// The padding values (top, right, bottom, left)
            /// </returns>
            [<Import("toTRBL", "chart.js/helpers")>]
            static member toTRBL (value: ChartJs.TRBL) : Exports.toTRBL___1 = nativeOnly
            /// <summary>
            /// Converts the given value into a TRBL object.
            /// </summary>
            /// <param name="value">
            /// If a number, set the value to all TRBL component,
            /// else, if an object, use defined properties and sets undefined ones to 0.
            /// x / y are shorthands for same value for left/right and top/bottom.
            /// </param>
            /// <returns>
            /// The padding values (top, right, bottom, left)
            /// </returns>
            [<Import("toTRBL", "chart.js/helpers")>]
            static member toTRBL (value: ChartJs.Point) : Exports.toTRBL___2 = nativeOnly
            /// <summary>
            /// Converts the given value into a TRBL object.
            /// </summary>
            /// <param name="value">
            /// If a number, set the value to all TRBL component,
            /// else, if an object, use defined properties and sets undefined ones to 0.
            /// x / y are shorthands for same value for left/right and top/bottom.
            /// </param>
            /// <returns>
            /// The padding values (top, right, bottom, left)
            /// </returns>
            [<Import("toTRBL", "chart.js/helpers")>]
            static member toTRBL (value: U3<float, ChartJs.TRBL, ChartJs.Point>) : Exports.toTRBL___3 = nativeOnly
            /// <summary>
            /// Converts the given value into a TRBL corners object (similar with css border-radius).
            /// </summary>
            /// <param name="value">
            /// If a number, set the value to all TRBL corner components,
            /// else, if an object, use defined properties and sets undefined ones to 0.
            /// </param>
            /// <returns>
            /// The TRBL corner values (topLeft, topRight, bottomLeft, bottomRight)
            /// </returns>
            [<Import("toTRBLCorners", "chart.js/helpers")>]
            static member toTRBLCorners (value: float) : Exports.toTRBLCorners__ = nativeOnly
            /// <summary>
            /// Converts the given value into a TRBL corners object (similar with css border-radius).
            /// </summary>
            /// <param name="value">
            /// If a number, set the value to all TRBL corner components,
            /// else, if an object, use defined properties and sets undefined ones to 0.
            /// </param>
            /// <returns>
            /// The TRBL corner values (topLeft, topRight, bottomLeft, bottomRight)
            /// </returns>
            [<Import("toTRBLCorners", "chart.js/helpers")>]
            static member toTRBLCorners (value: ChartJs.TRBLCorners) : Exports.toTRBLCorners___1 = nativeOnly
            /// <summary>
            /// Converts the given value into a TRBL corners object (similar with css border-radius).
            /// </summary>
            /// <param name="value">
            /// If a number, set the value to all TRBL corner components,
            /// else, if an object, use defined properties and sets undefined ones to 0.
            /// </param>
            /// <returns>
            /// The TRBL corner values (topLeft, topRight, bottomLeft, bottomRight)
            /// </returns>
            [<Import("toTRBLCorners", "chart.js/helpers")>]
            static member toTRBLCorners (value: U2<float, ChartJs.TRBLCorners>) : Exports.toTRBLCorners___2 = nativeOnly
            /// <summary>
            /// Converts the given value into a padding object with pre-computed width/height.
            /// </summary>
            /// <param name="value">
            /// If a number, set the value to all TRBL component,
            /// else, if an object, use defined properties and sets undefined ones to 0.
            /// x / y are shorthands for same value for left/right and top/bottom.
            /// </param>
            /// <returns>
            /// The padding values (top, right, bottom, left, width, height)
            /// </returns>
            [<Import("toPadding", "chart.js/helpers")>]
            static member toPadding () : ChartJs.ChartArea = nativeOnly
            /// <summary>
            /// Converts the given value into a padding object with pre-computed width/height.
            /// </summary>
            /// <param name="value">
            /// If a number, set the value to all TRBL component,
            /// else, if an object, use defined properties and sets undefined ones to 0.
            /// x / y are shorthands for same value for left/right and top/bottom.
            /// </param>
            /// <returns>
            /// The padding values (top, right, bottom, left, width, height)
            /// </returns>
            [<Import("toPadding", "chart.js/helpers")>]
            static member toPadding (value: float) : ChartJs.ChartArea = nativeOnly
            /// <summary>
            /// Converts the given value into a padding object with pre-computed width/height.
            /// </summary>
            /// <param name="value">
            /// If a number, set the value to all TRBL component,
            /// else, if an object, use defined properties and sets undefined ones to 0.
            /// x / y are shorthands for same value for left/right and top/bottom.
            /// </param>
            /// <returns>
            /// The padding values (top, right, bottom, left, width, height)
            /// </returns>
            [<Import("toPadding", "chart.js/helpers")>]
            static member toPadding (value: ChartJs.TRBL) : ChartJs.ChartArea = nativeOnly
            /// <summary>
            /// Parses font options and returns the font object.
            /// </summary>
            /// <param name="options">
            /// A object that contains font options to be parsed.
            /// </param>
            /// <param name="fallback">
            /// A object that contains fallback font options.
            /// </param>
            /// <returns>
            /// The font object.
            /// </returns>
            [<Import("toFont", "chart.js/helpers")>]
            static member toFont (options: Exports.toFont__.options, ?fallback: Exports.toFont__.fallback) : Exports.toFont__ = nativeOnly
            /// <summary>
            /// Evaluates the given <c>inputs</c> sequentially and returns the first defined value.
            /// </summary>
            /// <param name="inputs">
            /// An array of values, falling back to the last value.
            /// </param>
            /// <param name="context">
            /// If defined and the current value is a function, the value
            /// is called with <c>context</c> as first argument and the result becomes the new input.
            /// </param>
            /// <param name="index">
            /// If defined and the current value is an array, the value
            /// at <c>index</c> become the new input.
            /// </param>
            /// <param name="info">
            /// object to return information about resolution in
            /// </param>
            /// <param name="info.cacheable">
            /// Will be set to <c>false</c> if option is not cacheable.
            /// </param>
            [<Import("resolve", "chart.js/helpers")>]
            static member resolve (inputs: ResizeArray<obj>, ?context: obj, ?index: float, ?info: Exports.resolve__.info) : obj = nativeOnly
            /// <param name="minmax">
            ///
            /// </param>
            /// <param name="grace">
            ///
            /// </param>
            /// <param name="beginAtZero">
            ///
            /// </param>
            [<Import("_addGrace", "chart.js/helpers")>]
            static member _addGrace (minmax: Exports._addGrace__.minmax, grace: float, beginAtZero: bool) : Exports._addGrace__ = nativeOnly
            /// <param name="minmax">
            ///
            /// </param>
            /// <param name="grace">
            ///
            /// </param>
            /// <param name="beginAtZero">
            ///
            /// </param>
            [<Import("_addGrace", "chart.js/helpers")>]
            static member _addGrace (minmax: Exports._addGrace__.minmax, grace: string, beginAtZero: bool) : Exports._addGrace__ = nativeOnly
            /// <param name="minmax">
            ///
            /// </param>
            /// <param name="grace">
            ///
            /// </param>
            /// <param name="beginAtZero">
            ///
            /// </param>
            [<Import("_addGrace", "chart.js/helpers")>]
            static member _addGrace (minmax: Exports._addGrace__.minmax, grace: U2<float, string>, beginAtZero: bool) : Exports._addGrace__ = nativeOnly
            /// <summary>
            /// Create a context inheriting parentContext
            /// </summary>
            /// <param name="parentContext">
            ///
            /// </param>
            /// <param name="context">
            ///
            /// </param>
            [<Import("createContext", "chart.js/helpers")>]
            static member createContext (parentContext: obj, context: obj) : obj = nativeOnly
            [<Import("getRtlAdapter", "chart.js/helpers")>]
            static member getRtlAdapter (rtl: bool, rectX: float, width: float) : ChartJs.helpers.RTLAdapter = nativeOnly
            [<Import("overrideTextDirection", "chart.js/helpers")>]
            static member overrideTextDirection (ctx: Glutinum.Web.CanvasRenderingContext2D, direction: Exports.overrideTextDirection__.direction) : unit = nativeOnly
            [<Import("restoreTextDirection", "chart.js/helpers")>]
            static member restoreTextDirection (ctx: Glutinum.Web.CanvasRenderingContext2D, ?original: (string * string)) : unit = nativeOnly
            /// <summary>
            /// Returns the sub-segment(s) of a line segment that fall in the given bounds
            /// </summary>
            /// <param name="segment">
            ///
            /// </param>
            /// <param name="points">
            /// the points that this segment refers to
            /// </param>
            /// <param name="bounds">
            ///
            /// </param>
            [<Import("_boundSegment", "chart.js/helpers")>]
            static member _boundSegment (segment: Exports._boundSegment__.segment, points: ResizeArray<ChartJs.helpers.PointElement>, ?bounds: Exports._boundSegment__.bounds) : ResizeArray<Exports._boundSegment__.Item> = nativeOnly
            /// <summary>
            /// Returns the segments of the line that are inside given bounds
            /// </summary>
            /// <param name="line">
            ///
            /// </param>
            /// <param name="bounds">
            ///
            /// </param>
            [<Import("_boundSegments", "chart.js/helpers")>]
            static member _boundSegments (line: ChartJs.helpers.LineElement, ?bounds: Exports._boundSegments__.bounds) : ResizeArray<Exports._boundSegments__.Item> = nativeOnly
            /// <summary>
            /// Compute the continuous segments that define the whole line
            /// There can be skipped points within a segment, if spanGaps is true.
            /// </summary>
            /// <param name="line">
            ///
            /// </param>
            /// <param name="segmentOptions">
            ///
            /// </param>
            [<Import("_computeSegments", "chart.js/helpers")>]
            static member _computeSegments (line: ChartJs.helpers.LineElement, ?segmentOptions: obj) : ResizeArray<ChartJs.helpers.Segment> = nativeOnly
            /// <summary>
            /// Returns true if <c>value</c> is a finite number, else returns false
            /// </summary>
            /// <param name="value">
            /// The value to test.
            /// </param>
            [<Import("isFinite", "chart.js/helpers")>]
            static member isFinite (value: obj) : bool = nativeOnly

        type Thing =
            string option

        type Things =
            ResizeArray<U2<ChartJs.helpers.Thing, ResizeArray<ChartJs.helpers.Thing>>>

        [<AllowNullLiteral>]
        [<Interface>]
        type DrawPointOptions =
            abstract member pointStyle: ChartJs.PointStyle with get, set
            abstract member rotation: float option with get, set
            abstract member radius: float with get, set
            abstract member borderWidth: float with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (pointStyle: ChartJs.PointStyle, radius: float, borderWidth: float, ?rotation: float) : DrawPointOptions = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type ArrayListener<'T> =
            abstract member _onDataPush: System.Delegate option with get, set
            abstract member _onDataPop: (unit -> unit) option with get, set
            abstract member _onDataShift: (unit -> unit) option with get, set
            abstract member _onDataSplice: ArrayListener._onDataSplice option with get, set
            abstract member _onDataUnshift: System.Delegate option with get, set

        type ResolverObjectKey =
            U2<string, bool>

        [<AllowNullLiteral>]
        [<Interface>]
        type ResolverCache<'T, 'R> =
            abstract member _cacheable: bool with get, set
            abstract member _scopes: 'T with get, set
            abstract member _rootScopes: U2<'T, 'R> with get, set
            abstract member _fallback: ChartJs.helpers.ResolverObjectKey with get, set
            abstract member _keys: ResizeArray<string> option with get, set
            abstract member _scriptable: bool option with get, set
            abstract member _indexable: bool option with get, set
            abstract member _allKeys: bool option with get, set
            abstract member _storage: obj option with get, set
            abstract member _getTarget: unit -> obj
            abstract member ``override``<'S>: scope: 'S -> ChartJs.helpers.ResolverProxy<ResizeArray<U2<obj, 'S>>, U2<'T, 'R>>

        [<AllowNullLiteral>]
        [<Interface>]
        type ResolverProxy<'T, 'R> =
            abstract member _cacheable: bool with get, set
            abstract member _scopes: 'T with get, set
            abstract member _rootScopes: U2<'T, 'R> with get, set
            abstract member _fallback: ChartJs.helpers.ResolverObjectKey with get, set
            abstract member _keys: ResizeArray<string> option with get, set
            abstract member _scriptable: bool option with get, set
            abstract member _indexable: bool option with get, set
            abstract member _allKeys: bool option with get, set
            abstract member _storage: obj option with get, set
            abstract member _getTarget: unit -> obj
            abstract member ``override``<'S>: scope: 'S -> ChartJs.helpers.ResolverProxy<ResizeArray<U2<obj, 'S>>, U2<'T, 'R>>

        [<AllowNullLiteral>]
        [<Interface>]
        type DescriptorDefaults =
            abstract member scriptable: bool with get, set
            abstract member indexable: bool with get, set
            abstract member allKeys: bool option with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (scriptable: bool, indexable: bool, ?allKeys: bool) : DescriptorDefaults = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type Descriptor =
            abstract member allKeys: bool with get, set
            abstract member scriptable: bool with get, set
            abstract member indexable: bool with get, set
            abstract member isScriptable: key: string -> bool
            abstract member isIndexable: key: string -> bool

        [<AllowNullLiteral>]
        [<Interface>]
        type ContextCache<'T, 'R> =
            abstract member _cacheable: bool with get, set
            abstract member _proxy: ChartJs.helpers.ResolverProxy<'T, 'R> with get, set
            abstract member _context: ChartJs.AnyObject with get, set
            abstract member _subProxy: ChartJs.helpers.ResolverProxy<'T, 'R> with get, set
            abstract member _stack: obj with get, set
            abstract member _descriptors: ChartJs.helpers.Descriptor with get, set
            abstract member setContext: ctx: ChartJs.AnyObject -> ChartJs.helpers.ContextProxy<'T, 'R>
            abstract member ``override``<'S>: scope: 'S -> ChartJs.helpers.ContextProxy<ResizeArray<U2<obj, 'S>>, U2<'T, 'R>>

        [<AllowNullLiteral>]
        [<Interface>]
        type ContextProxy<'T, 'R> =
            abstract member _cacheable: bool with get, set
            abstract member _proxy: ChartJs.helpers.ResolverProxy<'T, 'R> with get, set
            abstract member _context: ChartJs.AnyObject with get, set
            abstract member _subProxy: ChartJs.helpers.ResolverProxy<'T, 'R> with get, set
            abstract member _stack: obj with get, set
            abstract member _descriptors: ChartJs.helpers.Descriptor with get, set
            abstract member setContext: ctx: ChartJs.AnyObject -> ChartJs.helpers.ContextProxy<'T, 'R>
            abstract member ``override``<'S>: scope: 'S -> ChartJs.helpers.ContextProxy<ResizeArray<U2<obj, 'S>>, U2<'T, 'R>>

        [<AllowNullLiteral>]
        [<Interface>]
        type MergeOptions =
            abstract member merger: MergeOptions.merger option with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (?merger: MergeOptions.merger) : MergeOptions = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type RTLAdapter =
            abstract member x: x: float -> float
            abstract member setWidth: w: float -> unit
            abstract member textAlign: align: RTLAdapter.textAlign.align -> RTLAdapter.textAlign
            abstract member xPlus: x: float * value: float -> float
            abstract member leftForLtr: x: float * itemWidth: float -> float

        type LineElement =
            obj

        type PointElement =
            obj

        [<AllowNullLiteral>]
        [<Interface>]
        type Segment =
            abstract member start: float with get, set
            abstract member ``end``: float with get, set
            abstract member loop: bool with get, set
            abstract member style: obj option with get, set

        type ResolverCache<'T> =
            ResolverCache<'T, 'T>

        type ResolverCache =
            ResolverCache<ResizeArray<ChartJs.AnyObject>, ResizeArray<ChartJs.AnyObject>>

        type ResolverProxy<'T> =
            ResolverProxy<'T, 'T>

        type ResolverProxy =
            ResolverProxy<ResizeArray<ChartJs.AnyObject>, ResizeArray<ChartJs.AnyObject>>

        type ContextCache<'T> =
            ContextCache<'T, 'T>

        type ContextCache =
            ContextCache<ResizeArray<ChartJs.AnyObject>, ResizeArray<ChartJs.AnyObject>>

        type ContextProxy<'T> =
            ContextProxy<'T, 'T>

        type ContextProxy =
            ContextProxy<ResizeArray<ChartJs.AnyObject>, ResizeArray<ChartJs.AnyObject>>

        module ArrayListener =

            type _onDataSplice =
                delegate of index: float * deleteCount: float * [<ParamArray>] items: obj [] -> unit

        module MergeOptions =

            type merger =
                delegate of key: string * target: ChartJs.AnyObject * source: ChartJs.AnyObject * ?options: ChartJs.AnyObject -> unit

        module RTLAdapter =

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type textAlign =
                | center
                | left
                | right

            module textAlign =

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type align =
                    | center
                    | left
                    | right

        module Exports =

            [<AllowNullLiteral>]
            [<Interface>]
            type _lookup__ =
                abstract member lo: float with get, set
                abstract member hi: float with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (lo: float, hi: float) : _lookup__ = nativeOnly

            [<AllowNullLiteral>]
            [<Interface>]
            type splineCurve__ =
                abstract member previous: ChartJs.SplinePoint with get, set
                abstract member next: ChartJs.SplinePoint with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (previous: ChartJs.SplinePoint, next: ChartJs.SplinePoint) : splineCurve__ = nativeOnly

            [<AllowNullLiteral>]
            [<Interface>]
            type getRelativePosition__ =
                abstract member x: float with get, set
                abstract member y: float with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (x: float, y: float) : getRelativePosition__ = nativeOnly

            [<AllowNullLiteral>]
            [<Interface>]
            type getMaximumSize__ =
                abstract member width: float with get, set
                abstract member height: float with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (width: float, height: float) : getMaximumSize__ = nativeOnly

            [<AllowNullLiteral>]
            [<Interface>]
            type _getStartAndCountOfVisiblePoints__ =
                abstract member start: float with get, set
                abstract member count: float with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (start: float, count: float) : _getStartAndCountOfVisiblePoints__ = nativeOnly

            [<AllowNullLiteral>]
            [<Interface>]
            type _pointInLine__ =
                abstract member x: float with get, set
                abstract member y: float with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (x: float, y: float) : _pointInLine__ = nativeOnly

            [<AllowNullLiteral>]
            [<Interface>]
            type _steppedInterpolation__ =
                abstract member x: float with get, set
                abstract member y: float with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (x: float, y: float) : _steppedInterpolation__ = nativeOnly

            [<AllowNullLiteral>]
            [<Interface>]
            type _bezierInterpolation__ =
                abstract member x: float with get, set
                abstract member y: float with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (x: float, y: float) : _bezierInterpolation__ = nativeOnly

            [<AllowNullLiteral>]
            [<Interface>]
            type getAngleFromPoint__ =
                abstract member angle: float with get, set
                abstract member distance: float with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (angle: float, distance: float) : getAngleFromPoint__ = nativeOnly

            [<AllowNullLiteral>]
            [<Interface>]
            type _readValueToProps__<'K> =
                [<EmitIndexer>]
                abstract member Item: key: 'K -> float with get, set

            [<AllowNullLiteral>]
            [<Interface>]
            type _readValueToProps___1<'T> =
                [<EmitIndexer>]
                abstract member Item: key: 'T -> float with get, set

            [<AllowNullLiteral>]
            [<Interface>]
            type toTRBL__ =
                [<EmitIndexer>]
                abstract member Item: key: Exports.toTRBL__.toTRBL__.key -> float with get, set

            [<AllowNullLiteral>]
            [<Interface>]
            type toTRBL___1 =
                [<EmitIndexer>]
                abstract member Item: key: Exports.toTRBL__.toTRBL___1.key -> float with get, set

            [<AllowNullLiteral>]
            [<Interface>]
            type toTRBL___2 =
                [<EmitIndexer>]
                abstract member Item: key: Exports.toTRBL__.toTRBL___2.key -> float with get, set

            [<AllowNullLiteral>]
            [<Interface>]
            type toTRBL___3 =
                [<EmitIndexer>]
                abstract member Item: key: Exports.toTRBL__.toTRBL___3.key -> float with get, set

            [<AllowNullLiteral>]
            [<Interface>]
            type toTRBLCorners__ =
                [<EmitIndexer>]
                abstract member Item: key: Exports.toTRBLCorners__.toTRBLCorners__.key -> float with get, set

            [<AllowNullLiteral>]
            [<Interface>]
            type toTRBLCorners___1 =
                [<EmitIndexer>]
                abstract member Item: key: Exports.toTRBLCorners__.toTRBLCorners___1.key -> float with get, set

            [<AllowNullLiteral>]
            [<Interface>]
            type toTRBLCorners___2 =
                [<EmitIndexer>]
                abstract member Item: key: Exports.toTRBLCorners__.toTRBLCorners___2.key -> float with get, set

            [<AllowNullLiteral>]
            [<Interface>]
            type toFont__ =
                abstract member family: string with get, set
                abstract member lineHeight: float with get, set
                abstract member size: float with get, set
                abstract member style: Exports.toFont__.style with get, set
                abstract member weight: Exports.toFont__.weight with get, set
                abstract member string: string with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (family: string, lineHeight: float, size: float, style: Exports.toFont__.style, weight: Exports.toFont__.weight, string: string) : toFont__ = nativeOnly

            [<AllowNullLiteral>]
            [<Interface>]
            type _addGrace__ =
                abstract member min: float with get, set
                abstract member max: float with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (min: float, max: float) : _addGrace__ = nativeOnly

            module _measureText__ =

                [<AllowNullLiteral>]
                [<Interface>]
                type data =
                    [<EmitIndexer>]
                    abstract member Item: key: string -> float with get, set

            module _longestText__ =

                [<AllowNullLiteral>]
                [<Interface>]
                type cache =
                    abstract member data: Exports._longestText__.cache.data option with get, set
                    abstract member garbageCollect: ResizeArray<string> option with get, set
                    abstract member font: string option with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (?data: Exports._longestText__.cache.data, ?garbageCollect: ResizeArray<string>, ?font: string) : cache = nativeOnly

                module cache =

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type data =
                        [<EmitIndexer>]
                        abstract member Item: key: string -> float with get, set

            module addRoundedRectPath__ =

                [<AllowNullLiteral>]
                [<Interface>]
                type rect =
                    abstract member x: float with get, set
                    abstract member y: float with get, set
                    abstract member w: float with get, set
                    abstract member h: float with get, set
                    abstract member radius: obj with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (x: float, y: float, w: float, h: float, radius: obj) : rect = nativeOnly

            module _lookupByKey__ =

                type Type =
                    delegate of table: ResizeArray<Exports._lookupByKey__.Type.table.Item> * key: string * value: float * ?last: bool -> Exports._lookupByKey__.Type.ReturnType

                module Type =

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type ReturnType =
                        abstract member lo: float with get, set
                        abstract member hi: float with get, set
                        [<ParamObject; Emit("$0")>]
                        static member Create (lo: float, hi: float) : ReturnType = nativeOnly

                    module table =

                        [<AllowNullLiteral>]
                        [<Interface>]
                        type Item =
                            [<EmitIndexer>]
                            abstract member Item: key: string -> float with get, set

            module _rlookupByKey__ =

                type Type =
                    delegate of table: ResizeArray<Exports._rlookupByKey__.Type.table.Item> * key: string * value: float -> Exports._rlookupByKey__.Type.ReturnType

                module Type =

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type ReturnType =
                        abstract member lo: float with get, set
                        abstract member hi: float with get, set
                        [<ParamObject; Emit("$0")>]
                        static member Create (lo: float, hi: float) : ReturnType = nativeOnly

                    module table =

                        [<AllowNullLiteral>]
                        [<Interface>]
                        type Item =
                            [<EmitIndexer>]
                            abstract member Item: key: string -> float with get, set

            module color__ =

                [<AllowNullLiteral>]
                [<Interface>]
                type value =
                    abstract member r: float with get, set
                    abstract member g: float with get, set
                    abstract member b: float with get, set
                    abstract member a: float with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (r: float, g: float, b: float, a: float) : value = nativeOnly

            module _parseObjectDataRadialScale__ =

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type meta =
                    | line
                    | scatter

                [<AllowNullLiteral>]
                [<Interface>]
                type Item =
                    abstract member r: obj with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (r: obj) : Item = nativeOnly

            module toPercentage__ =

                type Type =
                    delegate of value: U2<float, string> * dimension: float -> float

            module toDimension__ =

                type Type =
                    delegate of value: U2<float, string> * dimension: float -> float

            module each__ =

                [<AllowNullLiteral>]
                [<Interface>]
                type loopable<'T> =
                    [<EmitIndexer>]
                    abstract member Item: key: string -> 'T with get, set

                type fn<'T> =
                    delegate of v: 'T * i: string -> unit

                type fn_1<'T> =
                    delegate of v: 'T * i: float -> unit

            module setsEqual__ =

                type Type =
                    delegate of a: obj * b: obj -> bool

            module splineCurveMonotone__ =

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type indexAxis =
                    | x
                    | y

            module _updateBezierControlPoints__ =

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type indexAxis =
                    | x
                    | y

            module readUsedSize__ =

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type property =
                    | width
                    | height

            module _toLeftRightCenter__ =

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type Type =
                    | center
                    | left
                    | right

                module Type =

                    [<RequireQualifiedAccess>]
                    [<StringEnum(CaseRules.None)>]
                    type align =
                        | start
                        | ``end``
                        | center

            module _alignStartEnd__ =

                type Type =
                    delegate of align: Exports._alignStartEnd__.Type.align * start: float * ``end``: float -> float

                module Type =

                    [<RequireQualifiedAccess>]
                    [<StringEnum(CaseRules.None)>]
                    type align =
                        | start
                        | ``end``
                        | center

            module _textX__ =

                type Type =
                    delegate of align: Exports._textX__.Type.align * left: float * right: float * rtl: bool -> float

                module Type =

                    [<RequireQualifiedAccess>]
                    [<StringEnum(CaseRules.None)>]
                    type align =
                        | left
                        | right
                        | center

            module _getStartAndCountOfVisiblePoints__ =

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type meta =
                    | line
                    | scatter

            module _steppedInterpolation__ =

                [<RequireQualifiedAccess>]
                [<Erase(CaseRules.None)>]
                type mode =
                    | middle
                    | after
                    | Case1 of obj

                    [<Emit("$0")>]
                    static member op_Implicit(value: obj) : mode = nativeOnly

                    [<Emit("$0")>]
                    static member op_ErasedCast(value: obj) : mode = nativeOnly

            module _setMinAndMaxByKey__ =

                [<AllowNullLiteral>]
                [<Interface>]
                type target =
                    abstract member min: float with get, set
                    abstract member max: float with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (min: float, max: float) : target = nativeOnly

                module array =

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type Item =
                        [<EmitIndexer>]
                        abstract member Item: key: string -> float with get, set

            module _readValueToProps__ =

                [<AllowNullLiteral>]
                [<Interface>]
                type value<'K> =
                    [<EmitIndexer>]
                    abstract member Item: key: 'K -> float with get, set

                module value =

                    module U2 =

                        [<AllowNullLiteral>]
                        [<Interface>]
                        type Case2<'K> =
                            [<EmitIndexer>]
                            abstract member Item: key: 'K -> float with get, set

                        [<AllowNullLiteral>]
                        [<Interface>]
                        type Case2_1 =
                            [<EmitIndexer>]
                            abstract member Item: key: obj -> float with get, set

                [<AllowNullLiteral>]
                [<Interface>]
                type props<'T, 'K> =
                    [<EmitIndexer>]
                    abstract member Item: key: 'T -> 'K with get, set

                [<AllowNullLiteral>]
                [<Interface>]
                type value_1 =
                    [<EmitIndexer>]
                    abstract member Item: key: obj -> float with get, set

            module toTRBL__ =

                module toTRBL__ =

                    [<RequireQualifiedAccess>]
                    [<StringEnum(CaseRules.None)>]
                    type key =
                        | left
                        | top
                        | bottom
                        | right

                module toTRBL___1 =

                    [<RequireQualifiedAccess>]
                    [<StringEnum(CaseRules.None)>]
                    type key =
                        | left
                        | top
                        | bottom
                        | right

                module toTRBL___2 =

                    [<RequireQualifiedAccess>]
                    [<StringEnum(CaseRules.None)>]
                    type key =
                        | left
                        | top
                        | bottom
                        | right

                module toTRBL___3 =

                    [<RequireQualifiedAccess>]
                    [<StringEnum(CaseRules.None)>]
                    type key =
                        | left
                        | top
                        | bottom
                        | right

            module toTRBLCorners__ =

                module toTRBLCorners__ =

                    [<RequireQualifiedAccess>]
                    [<StringEnum(CaseRules.None)>]
                    type key =
                        | topLeft
                        | topRight
                        | bottomLeft
                        | bottomRight

                module toTRBLCorners___1 =

                    [<RequireQualifiedAccess>]
                    [<StringEnum(CaseRules.None)>]
                    type key =
                        | topLeft
                        | topRight
                        | bottomLeft
                        | bottomRight

                module toTRBLCorners___2 =

                    [<RequireQualifiedAccess>]
                    [<StringEnum(CaseRules.None)>]
                    type key =
                        | topLeft
                        | topRight
                        | bottomLeft
                        | bottomRight

            module toFont__ =

                [<AllowNullLiteral>]
                [<Interface>]
                type options =
                    /// <summary>
                    /// Default font family for all text, follows CSS font-family options.
                    /// </summary>
                    abstract member family: string option with get, set
                    /// <summary>
                    /// Default font size (in px) for text. Does not apply to radialLinear scale point labels.
                    /// </summary>
                    abstract member size: float option with get, set
                    /// <summary>
                    /// Default font style. Does not apply to tooltip title or footer. Does not apply to chart title. Follows CSS font-style options (i.e. normal, italic, oblique, initial, inherit)
                    /// </summary>
                    abstract member style: Exports.toFont__.options.Partial.style option with get, set
                    /// <summary>
                    /// Default font weight (boldness). (see MDN).
                    /// </summary>
                    abstract member weight: Exports.toFont__.options.Partial.weight option with get, set
                    /// <summary>
                    /// Height of an individual line of text (see MDN).
                    /// </summary>
                    abstract member lineHeight: U2<float, string> option with get, set

                [<AllowNullLiteral>]
                [<Interface>]
                type fallback =
                    /// <summary>
                    /// Default font family for all text, follows CSS font-family options.
                    /// </summary>
                    abstract member family: string option with get, set
                    /// <summary>
                    /// Default font size (in px) for text. Does not apply to radialLinear scale point labels.
                    /// </summary>
                    abstract member size: float option with get, set
                    /// <summary>
                    /// Default font style. Does not apply to tooltip title or footer. Does not apply to chart title. Follows CSS font-style options (i.e. normal, italic, oblique, initial, inherit)
                    /// </summary>
                    abstract member style: Exports.toFont__.fallback.Partial.style option with get, set
                    /// <summary>
                    /// Default font weight (boldness). (see MDN).
                    /// </summary>
                    abstract member weight: Exports.toFont__.fallback.Partial.weight option with get, set
                    /// <summary>
                    /// Height of an individual line of text (see MDN).
                    /// </summary>
                    abstract member lineHeight: U2<float, string> option with get, set

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type style =
                    | normal
                    | ``inherit``
                    | italic
                    | oblique
                    | initial

                [<RequireQualifiedAccess>]
                [<Erase(CaseRules.None)>]
                type weight =
                    | bold
                    | normal
                    | lighter
                    | bolder
                    | Case1 of float

                    [<Emit("$0")>]
                    static member op_Implicit(value: float) : weight = nativeOnly

                    [<Emit("$0")>]
                    static member op_ErasedCast(value: float) : weight = nativeOnly

                module options =

                    module Partial =

                        [<RequireQualifiedAccess>]
                        [<StringEnum(CaseRules.None)>]
                        type style =
                            | normal
                            | italic
                            | oblique
                            | initial
                            | ``inherit``

                        [<RequireQualifiedAccess>]
                        [<Erase(CaseRules.None)>]
                        type weight =
                            | normal
                            | bold
                            | lighter
                            | bolder
                            | Case1 of float

                            [<Emit("$0")>]
                            static member op_Implicit(value: float) : weight = nativeOnly

                            [<Emit("$0")>]
                            static member op_ErasedCast(value: float) : weight = nativeOnly

                module fallback =

                    module Partial =

                        [<RequireQualifiedAccess>]
                        [<StringEnum(CaseRules.None)>]
                        type style =
                            | normal
                            | italic
                            | oblique
                            | initial
                            | ``inherit``

                        [<RequireQualifiedAccess>]
                        [<Erase(CaseRules.None)>]
                        type weight =
                            | normal
                            | bold
                            | lighter
                            | bolder
                            | Case1 of float

                            [<Emit("$0")>]
                            static member op_Implicit(value: float) : weight = nativeOnly

                            [<Emit("$0")>]
                            static member op_ErasedCast(value: float) : weight = nativeOnly

            module resolve__ =

                [<AllowNullLiteral>]
                [<Interface>]
                type info =
                    abstract member cacheable: bool with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (cacheable: bool) : info = nativeOnly

            module _addGrace__ =

                [<AllowNullLiteral>]
                [<Interface>]
                type minmax =
                    abstract member min: float with get, set
                    abstract member max: float with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (min: float, max: float) : minmax = nativeOnly

            module overrideTextDirection__ =

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type direction =
                    | ltr
                    | rtl

            module _boundSegment__ =

                [<AllowNullLiteral>]
                [<Interface>]
                type segment =
                    abstract member start: float with get, set
                    abstract member ``end``: float with get, set
                    abstract member loop: bool with get, set
                    abstract member style: obj option with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (start: float, ``end``: float, loop: bool, ?style: obj) : segment = nativeOnly

                [<AllowNullLiteral>]
                [<Interface>]
                type bounds =
                    abstract member property: string with get, set
                    abstract member start: float with get, set
                    abstract member ``end``: float with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (property: string, start: float, ``end``: float) : bounds = nativeOnly

                [<AllowNullLiteral>]
                [<Interface>]
                type Item =
                    abstract member start: float with get, set
                    abstract member ``end``: float with get, set
                    abstract member loop: bool with get, set
                    abstract member style: obj option with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (start: float, ``end``: float, loop: bool, ?style: obj) : Item = nativeOnly

            module _boundSegments__ =

                [<AllowNullLiteral>]
                [<Interface>]
                type bounds =
                    abstract member property: string with get, set
                    abstract member start: float with get, set
                    abstract member ``end``: float with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (property: string, start: float, ``end``: float) : bounds = nativeOnly

                [<AllowNullLiteral>]
                [<Interface>]
                type Item =
                    abstract member start: float with get, set
                    abstract member ``end``: float with get, set
                    abstract member loop: bool with get, set
                    abstract member style: obj option with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (start: float, ``end``: float, loop: bool, ?style: obj) : Item = nativeOnly

    type DateAdapter =
        DateAdapter<ChartJs.AnyObject>

    type ChartMeta<'TType, 'TElement> =
        ChartMeta<'TType, 'TElement, ChartJs.Element>

    type ChartMeta<'TType> =
        ChartMeta<'TType, ChartJs.Element, ChartJs.Element>

    type ChartMeta =
        ChartMeta<ChartJs.ChartType, ChartJs.Element, ChartJs.Element>

    type Plugin<'TType> =
        Plugin<'TType, ChartJs.AnyObject>

    type Plugin =
        Plugin<ChartJs.ChartType, ChartJs.AnyObject>

    type Scale =
        Scale<ChartJs.CoreScaleOptions>

    type LineElement<'T> =
        LineElement<'T, ChartJs.LineOptions>

    type LineElement =
        LineElement<ChartJs.LineProps, ChartJs.LineOptions>

    type BarElement<'T> =
        BarElement<'T, ChartJs.BarOptions>

    type BarElement =
        BarElement<ChartJs.BarProps, ChartJs.BarOptions>

    type ElementChartOptions =
        ElementChartOptions<ChartJs.ChartType>

    type TooltipDatasetCallbacks<'TType, 'Model> =
        TooltipDatasetCallbacks<'TType, 'Model, ChartJs.TooltipItem<'TType>>

    type TooltipDatasetCallbacks<'TType> =
        TooltipDatasetCallbacks<'TType, ChartJs.TooltipModel<'TType>, ChartJs.TooltipItem<'TType>>

    type TooltipCallbacks<'TType, 'Model> =
        TooltipCallbacks<'TType, 'Model, ChartJs.TooltipItem<'TType>>

    type TooltipCallbacks<'TType> =
        TooltipCallbacks<'TType, ChartJs.TooltipModel<'TType>, ChartJs.TooltipItem<'TType>>

    type ExtendedPlugin<'TType, 'O> =
        ExtendedPlugin<'TType, 'O, ChartJs.TooltipModel<'TType>>

    type ExtendedPlugin<'TType> =
        ExtendedPlugin<'TType, ChartJs.AnyObject, ChartJs.TooltipModel<'TType>>

    type TooltipOptions =
        TooltipOptions<ChartJs.ChartType>

    type TooltipDatasetOptions =
        TooltipDatasetOptions<ChartJs.ChartType>

    type CategoryScale =
        CategoryScale<ChartJs.CategoryScaleOptions>

    type LinearScale =
        LinearScale<ChartJs.LinearScaleOptions>

    type LogarithmicScale =
        LogarithmicScale<ChartJs.LogarithmicScaleOptions>

    type TimeScale =
        TimeScale<ChartJs.TimeScaleOptions>

    type RadialLinearScale =
        RadialLinearScale<ChartJs.RadialLinearScaleOptions>

    type ScaleOptionsByType =
        ScaleOptionsByType<ChartJs.ScaleType>

    type ScaleOptions =
        ScaleOptions<ChartJs.ScaleType>

    type DatasetChartOptions =
        DatasetChartOptions<ChartJs.ChartType>

    type ScaleChartOptions =
        ScaleChartOptions<ChartJs.ChartType>

    type ChartOptions =
        ChartOptions<ChartJs.ChartType>

    type ParsedDataType =
        ParsedDataType<ChartJs.ChartType>

    type ChartDataset<'TType> =
        ChartDataset<'TType, obj>

    type ChartDataset =
        ChartDataset<ChartJs.ChartType, obj>

    type ChartDatasetCustomTypesPerDataset<'TType> =
        ChartDatasetCustomTypesPerDataset<'TType, obj>

    type ChartDatasetCustomTypesPerDataset =
        ChartDatasetCustomTypesPerDataset<ChartJs.ChartType, obj>

    type ChartData<'TType, 'TData> =
        ChartData<'TType, 'TData, obj>

    type ChartData<'TType> =
        ChartData<'TType, ResizeArray<U4<float, ChartJs.Point, float * float, ChartJs.BubbleDataPoint> option>, obj>

    type ChartData =
        ChartData<ChartJs.ChartType, ResizeArray<U4<float, ChartJs.Point, float * float, ChartJs.BubbleDataPoint> option>, obj>

    type ChartDataCustomTypesPerDataset<'TType, 'TData> =
        ChartDataCustomTypesPerDataset<'TType, 'TData, obj>

    type ChartDataCustomTypesPerDataset<'TType> =
        ChartDataCustomTypesPerDataset<'TType, ResizeArray<U4<float, ChartJs.Point, float * float, ChartJs.BubbleDataPoint> option>, obj>

    type ChartDataCustomTypesPerDataset =
        ChartDataCustomTypesPerDataset<ChartJs.ChartType, ResizeArray<U4<float, ChartJs.Point, float * float, ChartJs.BubbleDataPoint> option>, obj>

    type ChartConfiguration<'TType, 'TData> =
        ChartConfiguration<'TType, 'TData, obj>

    type ChartConfiguration<'TType> =
        ChartConfiguration<'TType, ResizeArray<U4<float, ChartJs.Point, float * float, ChartJs.BubbleDataPoint> option>, obj>

    type ChartConfiguration =
        ChartConfiguration<ChartJs.ChartType, ResizeArray<U4<float, ChartJs.Point, float * float, ChartJs.BubbleDataPoint> option>, obj>

    type ChartConfigurationCustomTypesPerDataset<'TType, 'TData> =
        ChartConfigurationCustomTypesPerDataset<'TType, 'TData, obj>

    type ChartConfigurationCustomTypesPerDataset<'TType> =
        ChartConfigurationCustomTypesPerDataset<'TType, ResizeArray<U4<float, ChartJs.Point, float * float, ChartJs.BubbleDataPoint> option>, obj>

    type ChartConfigurationCustomTypesPerDataset =
        ChartConfigurationCustomTypesPerDataset<ChartJs.ChartType, ResizeArray<U4<float, ChartJs.Point, float * float, ChartJs.BubbleDataPoint> option>, obj>

    type Merge =
        Merge<obj>

    module DateAdapter =

        [<AllowNullLiteral>]
        [<Interface>]
        type formats =
            [<EmitIndexer>]
            abstract member Item: key: DateAdapter.formats.formats.key -> string with get, set

        module formats =

            module formats =

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type key =
                    | millisecond
                    | second
                    | minute
                    | hour
                    | day
                    | week
                    | month
                    | quarter
                    | year
                    | datetime

        module startOf =

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type unit =
                | millisecond
                | second
                | minute
                | hour
                | day
                | week
                | month
                | quarter
                | year
                | isoWeek

    module Config =

        module pluginScopeKeys =

            [<AllowNullLiteral>]
            [<Interface>]
            type plugin =
                abstract member id: string with get, set
                abstract member additionalOptionScopes: ResizeArray<string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (id: string, ?additionalOptionScopes: ResizeArray<string>) : plugin = nativeOnly

        module createResolver =

            [<AllowNullLiteral>]
            [<Interface>]
            type descriptorDefaults =
                abstract member scriptable: bool with get, set
                abstract member indexable: bool with get, set
                abstract member allKeys: bool option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (scriptable: bool, indexable: bool, ?allKeys: bool) : descriptorDefaults = nativeOnly

    module Element =

        [<AllowNullLiteral>]
        [<Interface>]
        type _DOLLAR_animations =
            [<EmitIndexer>]
            abstract member Item: key: obj -> ChartJs.dist.types.animation.Animation with get, set

        [<AllowNullLiteral>]
        [<Interface>]
        type getProps =
            interface end

    module PluginService =

        module _init =

            [<AllowNullLiteral>]
            [<Interface>]
            type Item =
                abstract member plugin: obj with get, set
                abstract member options: obj with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (plugin: obj, options: obj) : Item = nativeOnly

        module _oldCache =

            [<AllowNullLiteral>]
            [<Interface>]
            type Item =
                abstract member plugin: obj with get, set
                abstract member options: obj with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (plugin: obj, options: obj) : Item = nativeOnly

        module _cache =

            [<AllowNullLiteral>]
            [<Interface>]
            type Item =
                abstract member plugin: obj with get, set
                abstract member options: obj with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (plugin: obj, options: obj) : Item = nativeOnly

        module _createDescriptors =

            [<AllowNullLiteral>]
            [<Interface>]
            type Item =
                abstract member plugin: obj with get, set
                abstract member options: obj with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (plugin: obj, options: obj) : Item = nativeOnly

    module filterCallback =

        [<AllowNullLiteral>]
        [<Interface>]
        type value =
            abstract member plugin: obj with get, set
            abstract member options: obj with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (plugin: obj, options: obj) : value = nativeOnly

    module ArcElement =

        [<AllowNullLiteral>]
        [<Interface>]
        type defaults__ =
            abstract member borderAlign: string with get, set
            abstract member borderColor: string with get, set
            abstract member borderDash: ResizeArray<obj> with get, set
            abstract member borderDashOffset: float with get, set
            abstract member borderJoinStyle: obj with get, set
            abstract member borderRadius: float with get, set
            abstract member borderWidth: float with get, set
            abstract member offset: float with get, set
            abstract member spacing: float with get, set
            abstract member angle: obj with get, set
            abstract member circular: bool with get, set
            abstract member selfJoin: bool with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (borderAlign: string, borderColor: string, borderDash: ResizeArray<obj>, borderDashOffset: float, borderJoinStyle: obj, borderRadius: float, borderWidth: float, offset: float, spacing: float, angle: obj, circular: bool, selfJoin: bool) : defaults__ = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type defaultRoutes__ =
            abstract member backgroundColor: string with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (backgroundColor: string) : defaultRoutes__ = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type descriptors__ =
            abstract member _scriptable: bool with get, set
            abstract member _indexable: (obj -> bool) with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (_scriptable: bool, _indexable: (obj -> bool)) : descriptors__ = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type getCenterPoint =
            abstract member x: float with get, set
            abstract member y: float with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (x: float, y: float) : getCenterPoint = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type tooltipPosition =
            abstract member x: float with get, set
            abstract member y: float with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (x: float, y: float) : tooltipPosition = nativeOnly

    module PointElement =

        [<AllowNullLiteral>]
        [<Interface>]
        type Extends =
            /// <summary>
            /// Point radius
            /// </summary>
            abstract member radius: float with get, set
            /// <summary>
            /// Extra radius added to point radius for hit detection.
            /// </summary>
            abstract member hitRadius: float with get, set
            /// <summary>
            /// Point style
            /// </summary>
            abstract member pointStyle: ChartJs.PointStyle with get, set
            /// <summary>
            /// Point rotation (in degrees).
            /// </summary>
            abstract member rotation: float with get, set
            /// <summary>
            /// Draw the active elements over the other elements of the dataset,
            /// </summary>
            abstract member drawActiveElementsOnTop: bool with get, set
            abstract member borderWidth: float with get, set
            abstract member borderColor: ChartJs.Color with get, set
            abstract member backgroundColor: ChartJs.Color with get, set
            /// <summary>
            /// Point radius when hovered.
            /// </summary>
            abstract member hoverRadius: float with get, set
            abstract member hoverBorderWidth: float with get, set
            abstract member hoverBorderColor: ChartJs.Color with get, set
            abstract member hoverBackgroundColor: ChartJs.Color with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (radius: float, hitRadius: float, pointStyle: ChartJs.PointStyle, rotation: float, drawActiveElementsOnTop: bool, borderWidth: float, borderColor: ChartJs.Color, backgroundColor: ChartJs.Color, hoverRadius: float, hoverBorderWidth: float, hoverBorderColor: ChartJs.Color, hoverBackgroundColor: ChartJs.Color) : Extends = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type defaults__ =
            abstract member borderWidth: float with get, set
            abstract member hitRadius: float with get, set
            abstract member hoverBorderWidth: float with get, set
            abstract member hoverRadius: float with get, set
            abstract member pointStyle: string with get, set
            abstract member radius: float with get, set
            abstract member rotation: float with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (borderWidth: float, hitRadius: float, hoverBorderWidth: float, hoverRadius: float, pointStyle: string, radius: float, rotation: float) : defaults__ = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type defaultRoutes__ =
            abstract member backgroundColor: string with get, set
            abstract member borderColor: string with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (backgroundColor: string, borderColor: string) : defaultRoutes__ = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type getCenterPoint =
            abstract member x: float with get, set
            abstract member y: float with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (x: float, y: float) : getCenterPoint = nativeOnly

        module size =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                /// <summary>
                /// Point radius
                /// </summary>
                abstract member radius: float option with get, set
                /// <summary>
                /// Extra radius added to point radius for hit detection.
                /// </summary>
                abstract member hitRadius: float option with get, set
                /// <summary>
                /// Point style
                /// </summary>
                abstract member pointStyle: ChartJs.PointStyle option with get, set
                /// <summary>
                /// Point rotation (in degrees).
                /// </summary>
                abstract member rotation: float option with get, set
                /// <summary>
                /// Draw the active elements over the other elements of the dataset,
                /// </summary>
                abstract member drawActiveElementsOnTop: bool option with get, set
                abstract member borderWidth: float option with get, set
                abstract member borderColor: ChartJs.Color option with get, set
                abstract member backgroundColor: ChartJs.Color option with get, set
                /// <summary>
                /// Point radius when hovered.
                /// </summary>
                abstract member hoverRadius: float option with get, set
                abstract member hoverBorderWidth: float option with get, set
                abstract member hoverBorderColor: ChartJs.Color option with get, set
                abstract member hoverBackgroundColor: ChartJs.Color option with get, set

    module CornerRadius =

        module U2 =

            [<AllowNullLiteral>]
            [<Interface>]
            type Case2 =
                abstract member topLeft: float option with get, set
                abstract member topRight: float option with get, set
                abstract member bottomLeft: float option with get, set
                abstract member bottomRight: float option with get, set

    module Padding =

        module U3 =

            [<AllowNullLiteral>]
            [<Interface>]
            type Case1 =
                abstract member top: float option with get, set
                abstract member right: float option with get, set
                abstract member bottom: float option with get, set
                abstract member left: float option with get, set

    module Scriptable =

        module U2 =

            type Case2<'T, 'TContext> =
                delegate of ctx: 'TContext * options: ChartJs.AnyObject -> 'T option

    module ParsingOptions =

        module parsing =

            module U2 =

                [<AllowNullLiteral>]
                [<Interface>]
                type Case1 =
                    [<EmitIndexer>]
                    abstract member Item: key: string -> string with get, set

    module ControllerDatasetOptions =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type indexAxis =
            | x
            | y

    module BarControllerDatasetOptions =

        [<RequireQualifiedAccess>]
        [<Erase(CaseRules.None)>]
        type barThickness =
            | flex
            | Case1 of float

            [<Emit("$0")>]
            static member op_Implicit(value: float) : barThickness = nativeOnly

            [<Emit("$0")>]
            static member op_ErasedCast(value: float) : barThickness = nativeOnly

    module LineControllerDatasetOptions =

        [<AllowNullLiteral>]
        [<Interface>]
        type Extends =
            /// <summary>
            /// Line dash. See MDN.
            /// </summary>
            abstract member borderDash: ResizeArray<float> with get, set
            /// <summary>
            /// Line dash offset. See MDN.
            /// </summary>
            abstract member borderDashOffset: float with get, set
            /// <summary>
            /// Line join style. See MDN.
            /// </summary>
            abstract member borderJoinStyle: Glutinum.Web.CanvasLineJoin with get, set
            /// <summary>
            /// Line cap style. See MDN.
            /// </summary>
            abstract member borderCapStyle: Glutinum.Web.CanvasLineCap with get, set
            /// <summary>
            /// true to keep Bézier control inside the chart, false for no restriction.
            /// </summary>
            abstract member capBezierPoints: bool with get, set
            /// <summary>
            /// Interpolation mode to apply.
            /// </summary>
            abstract member cubicInterpolationMode: LineControllerDatasetOptions.Extends.cubicInterpolationMode with get, set
            /// <summary>
            /// Bézier curve tension (0 for no Bézier curves).
            /// </summary>
            abstract member tension: float with get, set
            /// <summary>
            /// true to show the line as a stepped line (tension will be ignored).
            /// </summary>
            abstract member stepped: LineControllerDatasetOptions.Extends.stepped with get, set
            /// <summary>
            /// Both line and radar charts support a fill option on the dataset object which can be used to create area between two datasets or a dataset and a boundary, i.e. the scale origin, start or end
            /// </summary>
            abstract member fill: U2<ChartJs.FillTarget, ChartJs.ComplexFillTarget> with get, set
            /// <summary>
            /// If true, lines will be drawn between points with no or null data. If false, points with NaN data will create a break in the line. Can also be a number specifying the maximum gap length to span. The unit of the value depends on the scale used.
            /// </summary>
            abstract member spanGaps: U2<bool, float> with get, set
            abstract member segment: LineControllerDatasetOptions.Extends.segment with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (borderDash: ResizeArray<float>, borderDashOffset: float, borderJoinStyle: Glutinum.Web.CanvasLineJoin, borderCapStyle: Glutinum.Web.CanvasLineCap, capBezierPoints: bool, cubicInterpolationMode: LineControllerDatasetOptions.Extends.cubicInterpolationMode, tension: float, stepped: LineControllerDatasetOptions.Extends.stepped, fill: ChartJs.FillTarget, spanGaps: bool, segment: LineControllerDatasetOptions.Extends.segment) : Extends = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (borderDash: ResizeArray<float>, borderDashOffset: float, borderJoinStyle: Glutinum.Web.CanvasLineJoin, borderCapStyle: Glutinum.Web.CanvasLineCap, capBezierPoints: bool, cubicInterpolationMode: LineControllerDatasetOptions.Extends.cubicInterpolationMode, tension: float, stepped: LineControllerDatasetOptions.Extends.stepped, fill: ChartJs.FillTarget, spanGaps: float, segment: LineControllerDatasetOptions.Extends.segment) : Extends = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (borderDash: ResizeArray<float>, borderDashOffset: float, borderJoinStyle: Glutinum.Web.CanvasLineJoin, borderCapStyle: Glutinum.Web.CanvasLineCap, capBezierPoints: bool, cubicInterpolationMode: LineControllerDatasetOptions.Extends.cubicInterpolationMode, tension: float, stepped: LineControllerDatasetOptions.Extends.stepped, fill: ChartJs.ComplexFillTarget, spanGaps: bool, segment: LineControllerDatasetOptions.Extends.segment) : Extends = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (borderDash: ResizeArray<float>, borderDashOffset: float, borderJoinStyle: Glutinum.Web.CanvasLineJoin, borderCapStyle: Glutinum.Web.CanvasLineCap, capBezierPoints: bool, cubicInterpolationMode: LineControllerDatasetOptions.Extends.cubicInterpolationMode, tension: float, stepped: LineControllerDatasetOptions.Extends.stepped, fill: ChartJs.ComplexFillTarget, spanGaps: float, segment: LineControllerDatasetOptions.Extends.segment) : Extends = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type Extends_1 =
            abstract member hoverBorderDash: ResizeArray<float> with get, set
            abstract member hoverBorderDashOffset: float with get, set
            abstract member hoverBorderCapStyle: Glutinum.Web.CanvasLineCap with get, set
            abstract member hoverBorderJoinStyle: Glutinum.Web.CanvasLineJoin with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (hoverBorderDash: ResizeArray<float>, hoverBorderDashOffset: float, hoverBorderCapStyle: Glutinum.Web.CanvasLineCap, hoverBorderJoinStyle: Glutinum.Web.CanvasLineJoin) : Extends_1 = nativeOnly

        module Extends =

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type cubicInterpolationMode =
                | ``default``
                | monotone

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type stepped =
                | before
                | after
                | middle
                | [<CompiledValue(true)>] True
                | [<CompiledValue(false)>] False

            [<AllowNullLiteral>]
            [<Interface>]
            type segment =
                abstract member backgroundColor: ChartJs.Scriptable<ChartJs.Color option, ChartJs.ScriptableLineSegmentContext> with get, set
                abstract member borderColor: ChartJs.Scriptable<ChartJs.Color option, ChartJs.ScriptableLineSegmentContext> with get, set
                abstract member borderCapStyle: ChartJs.Scriptable<Glutinum.Web.CanvasLineCap option, ChartJs.ScriptableLineSegmentContext> with get, set
                abstract member borderDash: ChartJs.Scriptable<ResizeArray<float> option, ChartJs.ScriptableLineSegmentContext> with get, set
                abstract member borderDashOffset: ChartJs.Scriptable<float option, ChartJs.ScriptableLineSegmentContext> with get, set
                abstract member borderJoinStyle: ChartJs.Scriptable<Glutinum.Web.CanvasLineJoin option, ChartJs.ScriptableLineSegmentContext> with get, set
                abstract member borderWidth: ChartJs.Scriptable<float option, ChartJs.ScriptableLineSegmentContext> with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (backgroundColor: ChartJs.Scriptable<ChartJs.Color option, ChartJs.ScriptableLineSegmentContext>, borderColor: ChartJs.Scriptable<ChartJs.Color option, ChartJs.ScriptableLineSegmentContext>, borderCapStyle: ChartJs.Scriptable<Glutinum.Web.CanvasLineCap option, ChartJs.ScriptableLineSegmentContext>, borderDash: ChartJs.Scriptable<ResizeArray<float> option, ChartJs.ScriptableLineSegmentContext>, borderDashOffset: ChartJs.Scriptable<float option, ChartJs.ScriptableLineSegmentContext>, borderJoinStyle: ChartJs.Scriptable<Glutinum.Web.CanvasLineJoin option, ChartJs.ScriptableLineSegmentContext>, borderWidth: ChartJs.Scriptable<float option, ChartJs.ScriptableLineSegmentContext>) : segment = nativeOnly

    module RadarControllerDatasetOptions =

        [<AllowNullLiteral>]
        [<Interface>]
        type Extends =
            /// <summary>
            /// Point radius
            /// </summary>
            abstract member radius: float with get, set
            /// <summary>
            /// Extra radius added to point radius for hit detection.
            /// </summary>
            abstract member hitRadius: float with get, set
            abstract member pointStyle: ChartJs.PointStyle with get, set
            /// <summary>
            /// Point rotation (in degrees).
            /// </summary>
            abstract member rotation: float with get, set
            /// <summary>
            /// Draw the active elements over the other elements of the dataset,
            /// </summary>
            abstract member drawActiveElementsOnTop: bool with get, set
            abstract member borderWidth: float with get, set
            abstract member borderColor: ChartJs.Color with get, set
            abstract member backgroundColor: ChartJs.Color with get, set
            /// <summary>
            /// Point radius when hovered.
            /// </summary>
            abstract member hoverRadius: float with get, set
            abstract member hoverBorderWidth: float with get, set
            abstract member hoverBorderColor: ChartJs.Color with get, set
            abstract member hoverBackgroundColor: ChartJs.Color with get, set
            /// <summary>
            /// The fill color for points.
            /// </summary>
            abstract member pointBackgroundColor: ChartJs.Color with get, set
            /// <summary>
            /// The border color for points.
            /// </summary>
            abstract member pointBorderColor: ChartJs.Color with get, set
            /// <summary>
            /// The width of the point border in pixels.
            /// </summary>
            abstract member pointBorderWidth: float with get, set
            /// <summary>
            /// The pixel size of the non-displayed point that reacts to mouse events.
            /// </summary>
            abstract member pointHitRadius: float with get, set
            /// <summary>
            /// The radius of the point shape. If set to 0, the point is not rendered.
            /// </summary>
            abstract member pointRadius: float with get, set
            /// <summary>
            /// The rotation of the point in degrees.
            /// </summary>
            abstract member pointRotation: float with get, set
            /// <summary>
            /// Point background color when hovered.
            /// </summary>
            abstract member pointHoverBackgroundColor: ChartJs.Color with get, set
            /// <summary>
            /// Point border color when hovered.
            /// </summary>
            abstract member pointHoverBorderColor: ChartJs.Color with get, set
            /// <summary>
            /// Border width of point when hovered.
            /// </summary>
            abstract member pointHoverBorderWidth: float with get, set
            /// <summary>
            /// The radius of the point when hovered.
            /// </summary>
            abstract member pointHoverRadius: float with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (radius: float, hitRadius: float, pointStyle: ChartJs.PointStyle, rotation: float, drawActiveElementsOnTop: bool, borderWidth: float, borderColor: ChartJs.Color, backgroundColor: ChartJs.Color, hoverRadius: float, hoverBorderWidth: float, hoverBorderColor: ChartJs.Color, hoverBackgroundColor: ChartJs.Color, pointBackgroundColor: ChartJs.Color, pointBorderColor: ChartJs.Color, pointBorderWidth: float, pointHitRadius: float, pointRadius: float, pointRotation: float, pointHoverBackgroundColor: ChartJs.Color, pointHoverBorderColor: ChartJs.Color, pointHoverBorderWidth: float, pointHoverRadius: float) : Extends = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type Extends_1 =
            /// <summary>
            /// Line cap style. See MDN.
            /// </summary>
            abstract member borderCapStyle: Glutinum.Web.CanvasLineCap with get, set
            /// <summary>
            /// Line dash. See MDN.
            /// </summary>
            abstract member borderDash: ResizeArray<float> with get, set
            /// <summary>
            /// Line dash offset. See MDN.
            /// </summary>
            abstract member borderDashOffset: float with get, set
            /// <summary>
            /// Line join style. See MDN.
            /// </summary>
            abstract member borderJoinStyle: Glutinum.Web.CanvasLineJoin with get, set
            /// <summary>
            /// true to keep Bézier control inside the chart, false for no restriction.
            /// </summary>
            abstract member capBezierPoints: bool with get, set
            /// <summary>
            /// Interpolation mode to apply.
            /// </summary>
            abstract member cubicInterpolationMode: RadarControllerDatasetOptions.Extends.cubicInterpolationMode with get, set
            /// <summary>
            /// Bézier curve tension (0 for no Bézier curves).
            /// </summary>
            abstract member tension: float with get, set
            /// <summary>
            /// true to show the line as a stepped line (tension will be ignored).
            /// </summary>
            abstract member stepped: RadarControllerDatasetOptions.Extends.stepped with get, set
            /// <summary>
            /// Both line and radar charts support a fill option on the dataset object which can be used to create area between two datasets or a dataset and a boundary, i.e. the scale origin, start or end
            /// </summary>
            abstract member fill: U2<ChartJs.FillTarget, ChartJs.ComplexFillTarget> with get, set
            /// <summary>
            /// If true, lines will be drawn between points with no or null data. If false, points with NaN data will create a break in the line. Can also be a number specifying the maximum gap length to span. The unit of the value depends on the scale used.
            /// </summary>
            abstract member spanGaps: U2<bool, float> with get, set
            abstract member segment: LineControllerDatasetOptions.Extends.segment with get, set
            abstract member borderWidth: float with get, set
            abstract member borderColor: ChartJs.Color with get, set
            abstract member backgroundColor: ChartJs.Color with get, set
            abstract member hoverBorderCapStyle: Glutinum.Web.CanvasLineCap with get, set
            abstract member hoverBorderDash: ResizeArray<float> with get, set
            abstract member hoverBorderDashOffset: float with get, set
            abstract member hoverBorderJoinStyle: Glutinum.Web.CanvasLineJoin with get, set
            abstract member hoverBorderWidth: float with get, set
            abstract member hoverBorderColor: ChartJs.Color with get, set
            abstract member hoverBackgroundColor: ChartJs.Color with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (borderCapStyle: Glutinum.Web.CanvasLineCap, borderDash: ResizeArray<float>, borderDashOffset: float, borderJoinStyle: Glutinum.Web.CanvasLineJoin, capBezierPoints: bool, cubicInterpolationMode: RadarControllerDatasetOptions.Extends.cubicInterpolationMode, tension: float, stepped: RadarControllerDatasetOptions.Extends.stepped, fill: ChartJs.FillTarget, spanGaps: bool, segment: LineControllerDatasetOptions.Extends.segment, borderWidth: float, borderColor: ChartJs.Color, backgroundColor: ChartJs.Color, hoverBorderCapStyle: Glutinum.Web.CanvasLineCap, hoverBorderDash: ResizeArray<float>, hoverBorderDashOffset: float, hoverBorderJoinStyle: Glutinum.Web.CanvasLineJoin, hoverBorderWidth: float, hoverBorderColor: ChartJs.Color, hoverBackgroundColor: ChartJs.Color) : Extends_1 = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (borderCapStyle: Glutinum.Web.CanvasLineCap, borderDash: ResizeArray<float>, borderDashOffset: float, borderJoinStyle: Glutinum.Web.CanvasLineJoin, capBezierPoints: bool, cubicInterpolationMode: RadarControllerDatasetOptions.Extends.cubicInterpolationMode, tension: float, stepped: RadarControllerDatasetOptions.Extends.stepped, fill: ChartJs.FillTarget, spanGaps: float, segment: LineControllerDatasetOptions.Extends.segment, borderWidth: float, borderColor: ChartJs.Color, backgroundColor: ChartJs.Color, hoverBorderCapStyle: Glutinum.Web.CanvasLineCap, hoverBorderDash: ResizeArray<float>, hoverBorderDashOffset: float, hoverBorderJoinStyle: Glutinum.Web.CanvasLineJoin, hoverBorderWidth: float, hoverBorderColor: ChartJs.Color, hoverBackgroundColor: ChartJs.Color) : Extends_1 = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (borderCapStyle: Glutinum.Web.CanvasLineCap, borderDash: ResizeArray<float>, borderDashOffset: float, borderJoinStyle: Glutinum.Web.CanvasLineJoin, capBezierPoints: bool, cubicInterpolationMode: RadarControllerDatasetOptions.Extends.cubicInterpolationMode, tension: float, stepped: RadarControllerDatasetOptions.Extends.stepped, fill: ChartJs.ComplexFillTarget, spanGaps: bool, segment: LineControllerDatasetOptions.Extends.segment, borderWidth: float, borderColor: ChartJs.Color, backgroundColor: ChartJs.Color, hoverBorderCapStyle: Glutinum.Web.CanvasLineCap, hoverBorderDash: ResizeArray<float>, hoverBorderDashOffset: float, hoverBorderJoinStyle: Glutinum.Web.CanvasLineJoin, hoverBorderWidth: float, hoverBorderColor: ChartJs.Color, hoverBackgroundColor: ChartJs.Color) : Extends_1 = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (borderCapStyle: Glutinum.Web.CanvasLineCap, borderDash: ResizeArray<float>, borderDashOffset: float, borderJoinStyle: Glutinum.Web.CanvasLineJoin, capBezierPoints: bool, cubicInterpolationMode: RadarControllerDatasetOptions.Extends.cubicInterpolationMode, tension: float, stepped: RadarControllerDatasetOptions.Extends.stepped, fill: ChartJs.ComplexFillTarget, spanGaps: float, segment: LineControllerDatasetOptions.Extends.segment, borderWidth: float, borderColor: ChartJs.Color, backgroundColor: ChartJs.Color, hoverBorderCapStyle: Glutinum.Web.CanvasLineCap, hoverBorderDash: ResizeArray<float>, hoverBorderDashOffset: float, hoverBorderJoinStyle: Glutinum.Web.CanvasLineJoin, hoverBorderWidth: float, hoverBorderColor: ChartJs.Color, hoverBackgroundColor: ChartJs.Color) : Extends_1 = nativeOnly

        module Extends =

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type cubicInterpolationMode =
                | ``default``
                | monotone

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type stepped =
                | before
                | after
                | middle
                | [<CompiledValue(true)>] True
                | [<CompiledValue(false)>] False

    module ChartItem =

        module U5 =

            [<AllowNullLiteral>]
            [<Interface>]
            type Case4 =
                abstract member canvas: Glutinum.Web.HTMLCanvasElement with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (canvas: Glutinum.Web.HTMLCanvasElement) : Case4 = nativeOnly

    module DatasetControllerChartComponent =

        [<AllowNullLiteral>]
        [<Interface>]
        type defaults =
            abstract member datasetElementType: U2<string, bool> option with get, set
            abstract member dataElementType: U2<string, bool> option with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (?datasetElementType: U2<string, bool>, ?dataElementType: U2<string, bool>) : defaults = nativeOnly

    module Defaults =

        [<AllowNullLiteral>]
        [<Interface>]
        type scales =
            [<EmitIndexer>]
            abstract member Item: key: string -> ChartJs.ScaleOptionsByType<string> with get, set

    module Overrides =

        [<AllowNullLiteral>]
        [<Interface>]
        type Item =
            abstract member datasets: Overrides.Item.datasets with get, set
            /// <summary>
            /// The base axis of the chart. 'x' for vertical charts and 'y' for horizontal charts.
            /// </summary>
            abstract member indexAxis: Overrides.Item.indexAxis with get, set
            /// <summary>
            /// How to clip relative to chartArea. Positive value allows overflow, negative value clips that many pixels inside chartArea. 0 = clip at chartArea. Clipping can also be configured per side: <c>clip: {left: 5, top: false, right: -2, bottom: 0}</c>
            /// </summary>
            abstract member clip: U3<float, ChartJs.ChartArea, bool> with get, set
            /// <summary>
            /// base color
            /// </summary>
            abstract member color: ChartJs.Scriptable<ChartJs.Color, ChartJs.ScriptableContext<string>> with get, set
            /// <summary>
            /// base background color
            /// </summary>
            abstract member backgroundColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>> with get, set
            /// <summary>
            /// base hover background color
            /// </summary>
            abstract member hoverBackgroundColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>> with get, set
            /// <summary>
            /// base border color
            /// </summary>
            abstract member borderColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>> with get, set
            /// <summary>
            /// base hover border color
            /// </summary>
            abstract member hoverBorderColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>> with get, set
            /// <summary>
            /// base font
            /// </summary>
            abstract member font: Overrides.Item.font with get, set
            /// <summary>
            /// Resizes the chart canvas when its container does (important note...).
            /// </summary>
            abstract member responsive: bool with get, set
            /// <summary>
            /// Maintain the original canvas aspect ratio (width / height) when resizing. For this option to work properly the chart must be in its own dedicated container.
            /// </summary>
            abstract member maintainAspectRatio: bool with get, set
            /// <summary>
            /// Delay the resize update by give amount of milliseconds. This can ease the resize process by debouncing update of the elements.
            /// </summary>
            abstract member resizeDelay: float with get, set
            /// <summary>
            /// Canvas aspect ratio (i.e. width / height, a value of 1 representing a square canvas). Note that this option is ignored if the height is explicitly defined either as attribute or via the style.
            /// </summary>
            abstract member aspectRatio: float with get, set
            /// <summary>
            /// Locale used for number formatting (using <c>Intl.NumberFormat</c>).
            /// </summary>
            abstract member locale: string with get, set
            /// <summary>
            /// Called when a resize occurs. Gets passed two arguments: the chart instance and the new size.
            /// </summary>
            abstract member onResize: chart: ChartJs.dist.types.Chart * size: Overrides.Item.onResize.size -> unit
            /// <summary>
            /// Override the window's default devicePixelRatio.
            /// </summary>
            abstract member devicePixelRatio: float with get, set
            abstract member interaction: ChartJs.CoreInteractionOptions with get, set
            abstract member hover: ChartJs.CoreInteractionOptions with get, set
            /// <summary>
            /// The events option defines the browser events that the chart should listen to for tooltips and hovering.
            /// </summary>
            abstract member events: ResizeArray<obj> with get, set
            /// <summary>
            /// Called when any of the events fire. Passed the event, an array of active elements (bars, points, etc), and the chart.
            /// </summary>
            abstract member onHover: event: ChartJs.ChartEvent * elements: ResizeArray<ChartJs.ActiveElement> * chart: ChartJs.dist.types.Chart -> unit
            /// <summary>
            /// Called if the event is of type 'mouseup' or 'click'. Passed the event, an array of active elements, and the chart.
            /// </summary>
            abstract member onClick: event: ChartJs.ChartEvent * elements: ResizeArray<ChartJs.ActiveElement> * chart: ChartJs.dist.types.Chart -> unit
            abstract member layout: Overrides.Item.layout with get, set
            /// <summary>
            /// How to parse the dataset. The parsing can be disabled by specifying parsing: false at chart options or dataset. If parsing is disabled, data must be sorted and in the formats the associated chart type and scales use internally.
            /// </summary>
            abstract member parsing: U2<ParsingOptions.parsing.U2.Case1, bool> with get, set
            /// <summary>
            /// Chart.js is fastest if you provide data with indices that are unique, sorted, and consistent across datasets and provide the normalized: true option to let Chart.js know that you have done so.
            /// </summary>
            abstract member normalized: bool with get, set
            abstract member animation: U2<bool, obj> with get, set
            abstract member animations: ChartJs.AnimationsSpec<string> with get, set
            abstract member transitions: ChartJs.TransitionsSpec<string> with get, set
            abstract member elements: ChartJs.ElementOptionsByType<string> with get, set
            abstract member plugins: ChartJs.PluginOptionsByType<string> with get, set
            abstract member line: Overrides.Item.line with get, set
            abstract member bar: Overrides.Item.bar with get, set
            abstract member scatter: Overrides.Item.scatter with get, set
            abstract member bubble: Overrides.Item.bubble with get, set
            abstract member pie: Overrides.Item.pie with get, set
            abstract member doughnut: Overrides.Item.doughnut with get, set
            abstract member polarArea: Overrides.Item.polarArea with get, set
            abstract member radar: Overrides.Item.radar with get, set
            abstract member scales: Overrides.Item.scales with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (datasets: Overrides.Item.datasets, indexAxis: Overrides.Item.indexAxis, clip: float, color: ChartJs.Scriptable<ChartJs.Color, ChartJs.ScriptableContext<string>>, backgroundColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, hoverBackgroundColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, borderColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, hoverBorderColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, font: Overrides.Item.font, responsive: bool, maintainAspectRatio: bool, resizeDelay: float, aspectRatio: float, locale: string, onResize: Overrides.Item.onResize, devicePixelRatio: float, interaction: ChartJs.CoreInteractionOptions, hover: ChartJs.CoreInteractionOptions, events: ResizeArray<obj>, onHover: Overrides.Item.onHover, onClick: Overrides.Item.onClick, layout: Overrides.Item.layout, parsing: ParsingOptions.parsing.U2.Case1, normalized: bool, animation: bool, animations: ChartJs.AnimationsSpec<string>, transitions: ChartJs.TransitionsSpec<string>, elements: ChartJs.ElementOptionsByType<string>, plugins: ChartJs.PluginOptionsByType<string>, line: Overrides.Item.line, bar: Overrides.Item.bar, scatter: Overrides.Item.scatter, bubble: Overrides.Item.bubble, pie: Overrides.Item.pie, doughnut: Overrides.Item.doughnut, polarArea: Overrides.Item.polarArea, radar: Overrides.Item.radar, scales: Overrides.Item.scales) : Item = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (datasets: Overrides.Item.datasets, indexAxis: Overrides.Item.indexAxis, clip: float, color: ChartJs.Scriptable<ChartJs.Color, ChartJs.ScriptableContext<string>>, backgroundColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, hoverBackgroundColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, borderColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, hoverBorderColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, font: Overrides.Item.font, responsive: bool, maintainAspectRatio: bool, resizeDelay: float, aspectRatio: float, locale: string, onResize: Overrides.Item.onResize, devicePixelRatio: float, interaction: ChartJs.CoreInteractionOptions, hover: ChartJs.CoreInteractionOptions, events: ResizeArray<obj>, onHover: Overrides.Item.onHover, onClick: Overrides.Item.onClick, layout: Overrides.Item.layout, parsing: ParsingOptions.parsing.U2.Case1, normalized: bool, animation: obj, animations: ChartJs.AnimationsSpec<string>, transitions: ChartJs.TransitionsSpec<string>, elements: ChartJs.ElementOptionsByType<string>, plugins: ChartJs.PluginOptionsByType<string>, line: Overrides.Item.line, bar: Overrides.Item.bar, scatter: Overrides.Item.scatter, bubble: Overrides.Item.bubble, pie: Overrides.Item.pie, doughnut: Overrides.Item.doughnut, polarArea: Overrides.Item.polarArea, radar: Overrides.Item.radar, scales: Overrides.Item.scales) : Item = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (datasets: Overrides.Item.datasets, indexAxis: Overrides.Item.indexAxis, clip: float, color: ChartJs.Scriptable<ChartJs.Color, ChartJs.ScriptableContext<string>>, backgroundColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, hoverBackgroundColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, borderColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, hoverBorderColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, font: Overrides.Item.font, responsive: bool, maintainAspectRatio: bool, resizeDelay: float, aspectRatio: float, locale: string, onResize: Overrides.Item.onResize, devicePixelRatio: float, interaction: ChartJs.CoreInteractionOptions, hover: ChartJs.CoreInteractionOptions, events: ResizeArray<obj>, onHover: Overrides.Item.onHover, onClick: Overrides.Item.onClick, layout: Overrides.Item.layout, parsing: bool, normalized: bool, animation: bool, animations: ChartJs.AnimationsSpec<string>, transitions: ChartJs.TransitionsSpec<string>, elements: ChartJs.ElementOptionsByType<string>, plugins: ChartJs.PluginOptionsByType<string>, line: Overrides.Item.line, bar: Overrides.Item.bar, scatter: Overrides.Item.scatter, bubble: Overrides.Item.bubble, pie: Overrides.Item.pie, doughnut: Overrides.Item.doughnut, polarArea: Overrides.Item.polarArea, radar: Overrides.Item.radar, scales: Overrides.Item.scales) : Item = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (datasets: Overrides.Item.datasets, indexAxis: Overrides.Item.indexAxis, clip: float, color: ChartJs.Scriptable<ChartJs.Color, ChartJs.ScriptableContext<string>>, backgroundColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, hoverBackgroundColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, borderColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, hoverBorderColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, font: Overrides.Item.font, responsive: bool, maintainAspectRatio: bool, resizeDelay: float, aspectRatio: float, locale: string, onResize: Overrides.Item.onResize, devicePixelRatio: float, interaction: ChartJs.CoreInteractionOptions, hover: ChartJs.CoreInteractionOptions, events: ResizeArray<obj>, onHover: Overrides.Item.onHover, onClick: Overrides.Item.onClick, layout: Overrides.Item.layout, parsing: bool, normalized: bool, animation: obj, animations: ChartJs.AnimationsSpec<string>, transitions: ChartJs.TransitionsSpec<string>, elements: ChartJs.ElementOptionsByType<string>, plugins: ChartJs.PluginOptionsByType<string>, line: Overrides.Item.line, bar: Overrides.Item.bar, scatter: Overrides.Item.scatter, bubble: Overrides.Item.bubble, pie: Overrides.Item.pie, doughnut: Overrides.Item.doughnut, polarArea: Overrides.Item.polarArea, radar: Overrides.Item.radar, scales: Overrides.Item.scales) : Item = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (datasets: Overrides.Item.datasets, indexAxis: Overrides.Item.indexAxis, clip: ChartJs.ChartArea, color: ChartJs.Scriptable<ChartJs.Color, ChartJs.ScriptableContext<string>>, backgroundColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, hoverBackgroundColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, borderColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, hoverBorderColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, font: Overrides.Item.font, responsive: bool, maintainAspectRatio: bool, resizeDelay: float, aspectRatio: float, locale: string, onResize: Overrides.Item.onResize, devicePixelRatio: float, interaction: ChartJs.CoreInteractionOptions, hover: ChartJs.CoreInteractionOptions, events: ResizeArray<obj>, onHover: Overrides.Item.onHover, onClick: Overrides.Item.onClick, layout: Overrides.Item.layout, parsing: ParsingOptions.parsing.U2.Case1, normalized: bool, animation: bool, animations: ChartJs.AnimationsSpec<string>, transitions: ChartJs.TransitionsSpec<string>, elements: ChartJs.ElementOptionsByType<string>, plugins: ChartJs.PluginOptionsByType<string>, line: Overrides.Item.line, bar: Overrides.Item.bar, scatter: Overrides.Item.scatter, bubble: Overrides.Item.bubble, pie: Overrides.Item.pie, doughnut: Overrides.Item.doughnut, polarArea: Overrides.Item.polarArea, radar: Overrides.Item.radar, scales: Overrides.Item.scales) : Item = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (datasets: Overrides.Item.datasets, indexAxis: Overrides.Item.indexAxis, clip: ChartJs.ChartArea, color: ChartJs.Scriptable<ChartJs.Color, ChartJs.ScriptableContext<string>>, backgroundColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, hoverBackgroundColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, borderColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, hoverBorderColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, font: Overrides.Item.font, responsive: bool, maintainAspectRatio: bool, resizeDelay: float, aspectRatio: float, locale: string, onResize: Overrides.Item.onResize, devicePixelRatio: float, interaction: ChartJs.CoreInteractionOptions, hover: ChartJs.CoreInteractionOptions, events: ResizeArray<obj>, onHover: Overrides.Item.onHover, onClick: Overrides.Item.onClick, layout: Overrides.Item.layout, parsing: ParsingOptions.parsing.U2.Case1, normalized: bool, animation: obj, animations: ChartJs.AnimationsSpec<string>, transitions: ChartJs.TransitionsSpec<string>, elements: ChartJs.ElementOptionsByType<string>, plugins: ChartJs.PluginOptionsByType<string>, line: Overrides.Item.line, bar: Overrides.Item.bar, scatter: Overrides.Item.scatter, bubble: Overrides.Item.bubble, pie: Overrides.Item.pie, doughnut: Overrides.Item.doughnut, polarArea: Overrides.Item.polarArea, radar: Overrides.Item.radar, scales: Overrides.Item.scales) : Item = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (datasets: Overrides.Item.datasets, indexAxis: Overrides.Item.indexAxis, clip: ChartJs.ChartArea, color: ChartJs.Scriptable<ChartJs.Color, ChartJs.ScriptableContext<string>>, backgroundColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, hoverBackgroundColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, borderColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, hoverBorderColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, font: Overrides.Item.font, responsive: bool, maintainAspectRatio: bool, resizeDelay: float, aspectRatio: float, locale: string, onResize: Overrides.Item.onResize, devicePixelRatio: float, interaction: ChartJs.CoreInteractionOptions, hover: ChartJs.CoreInteractionOptions, events: ResizeArray<obj>, onHover: Overrides.Item.onHover, onClick: Overrides.Item.onClick, layout: Overrides.Item.layout, parsing: bool, normalized: bool, animation: bool, animations: ChartJs.AnimationsSpec<string>, transitions: ChartJs.TransitionsSpec<string>, elements: ChartJs.ElementOptionsByType<string>, plugins: ChartJs.PluginOptionsByType<string>, line: Overrides.Item.line, bar: Overrides.Item.bar, scatter: Overrides.Item.scatter, bubble: Overrides.Item.bubble, pie: Overrides.Item.pie, doughnut: Overrides.Item.doughnut, polarArea: Overrides.Item.polarArea, radar: Overrides.Item.radar, scales: Overrides.Item.scales) : Item = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (datasets: Overrides.Item.datasets, indexAxis: Overrides.Item.indexAxis, clip: ChartJs.ChartArea, color: ChartJs.Scriptable<ChartJs.Color, ChartJs.ScriptableContext<string>>, backgroundColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, hoverBackgroundColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, borderColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, hoverBorderColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, font: Overrides.Item.font, responsive: bool, maintainAspectRatio: bool, resizeDelay: float, aspectRatio: float, locale: string, onResize: Overrides.Item.onResize, devicePixelRatio: float, interaction: ChartJs.CoreInteractionOptions, hover: ChartJs.CoreInteractionOptions, events: ResizeArray<obj>, onHover: Overrides.Item.onHover, onClick: Overrides.Item.onClick, layout: Overrides.Item.layout, parsing: bool, normalized: bool, animation: obj, animations: ChartJs.AnimationsSpec<string>, transitions: ChartJs.TransitionsSpec<string>, elements: ChartJs.ElementOptionsByType<string>, plugins: ChartJs.PluginOptionsByType<string>, line: Overrides.Item.line, bar: Overrides.Item.bar, scatter: Overrides.Item.scatter, bubble: Overrides.Item.bubble, pie: Overrides.Item.pie, doughnut: Overrides.Item.doughnut, polarArea: Overrides.Item.polarArea, radar: Overrides.Item.radar, scales: Overrides.Item.scales) : Item = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (datasets: Overrides.Item.datasets, indexAxis: Overrides.Item.indexAxis, clip: bool, color: ChartJs.Scriptable<ChartJs.Color, ChartJs.ScriptableContext<string>>, backgroundColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, hoverBackgroundColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, borderColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, hoverBorderColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, font: Overrides.Item.font, responsive: bool, maintainAspectRatio: bool, resizeDelay: float, aspectRatio: float, locale: string, onResize: Overrides.Item.onResize, devicePixelRatio: float, interaction: ChartJs.CoreInteractionOptions, hover: ChartJs.CoreInteractionOptions, events: ResizeArray<obj>, onHover: Overrides.Item.onHover, onClick: Overrides.Item.onClick, layout: Overrides.Item.layout, parsing: ParsingOptions.parsing.U2.Case1, normalized: bool, animation: bool, animations: ChartJs.AnimationsSpec<string>, transitions: ChartJs.TransitionsSpec<string>, elements: ChartJs.ElementOptionsByType<string>, plugins: ChartJs.PluginOptionsByType<string>, line: Overrides.Item.line, bar: Overrides.Item.bar, scatter: Overrides.Item.scatter, bubble: Overrides.Item.bubble, pie: Overrides.Item.pie, doughnut: Overrides.Item.doughnut, polarArea: Overrides.Item.polarArea, radar: Overrides.Item.radar, scales: Overrides.Item.scales) : Item = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (datasets: Overrides.Item.datasets, indexAxis: Overrides.Item.indexAxis, clip: bool, color: ChartJs.Scriptable<ChartJs.Color, ChartJs.ScriptableContext<string>>, backgroundColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, hoverBackgroundColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, borderColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, hoverBorderColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, font: Overrides.Item.font, responsive: bool, maintainAspectRatio: bool, resizeDelay: float, aspectRatio: float, locale: string, onResize: Overrides.Item.onResize, devicePixelRatio: float, interaction: ChartJs.CoreInteractionOptions, hover: ChartJs.CoreInteractionOptions, events: ResizeArray<obj>, onHover: Overrides.Item.onHover, onClick: Overrides.Item.onClick, layout: Overrides.Item.layout, parsing: ParsingOptions.parsing.U2.Case1, normalized: bool, animation: obj, animations: ChartJs.AnimationsSpec<string>, transitions: ChartJs.TransitionsSpec<string>, elements: ChartJs.ElementOptionsByType<string>, plugins: ChartJs.PluginOptionsByType<string>, line: Overrides.Item.line, bar: Overrides.Item.bar, scatter: Overrides.Item.scatter, bubble: Overrides.Item.bubble, pie: Overrides.Item.pie, doughnut: Overrides.Item.doughnut, polarArea: Overrides.Item.polarArea, radar: Overrides.Item.radar, scales: Overrides.Item.scales) : Item = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (datasets: Overrides.Item.datasets, indexAxis: Overrides.Item.indexAxis, clip: bool, color: ChartJs.Scriptable<ChartJs.Color, ChartJs.ScriptableContext<string>>, backgroundColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, hoverBackgroundColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, borderColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, hoverBorderColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, font: Overrides.Item.font, responsive: bool, maintainAspectRatio: bool, resizeDelay: float, aspectRatio: float, locale: string, onResize: Overrides.Item.onResize, devicePixelRatio: float, interaction: ChartJs.CoreInteractionOptions, hover: ChartJs.CoreInteractionOptions, events: ResizeArray<obj>, onHover: Overrides.Item.onHover, onClick: Overrides.Item.onClick, layout: Overrides.Item.layout, parsing: bool, normalized: bool, animation: bool, animations: ChartJs.AnimationsSpec<string>, transitions: ChartJs.TransitionsSpec<string>, elements: ChartJs.ElementOptionsByType<string>, plugins: ChartJs.PluginOptionsByType<string>, line: Overrides.Item.line, bar: Overrides.Item.bar, scatter: Overrides.Item.scatter, bubble: Overrides.Item.bubble, pie: Overrides.Item.pie, doughnut: Overrides.Item.doughnut, polarArea: Overrides.Item.polarArea, radar: Overrides.Item.radar, scales: Overrides.Item.scales) : Item = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (datasets: Overrides.Item.datasets, indexAxis: Overrides.Item.indexAxis, clip: bool, color: ChartJs.Scriptable<ChartJs.Color, ChartJs.ScriptableContext<string>>, backgroundColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, hoverBackgroundColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, borderColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, hoverBorderColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, font: Overrides.Item.font, responsive: bool, maintainAspectRatio: bool, resizeDelay: float, aspectRatio: float, locale: string, onResize: Overrides.Item.onResize, devicePixelRatio: float, interaction: ChartJs.CoreInteractionOptions, hover: ChartJs.CoreInteractionOptions, events: ResizeArray<obj>, onHover: Overrides.Item.onHover, onClick: Overrides.Item.onClick, layout: Overrides.Item.layout, parsing: bool, normalized: bool, animation: obj, animations: ChartJs.AnimationsSpec<string>, transitions: ChartJs.TransitionsSpec<string>, elements: ChartJs.ElementOptionsByType<string>, plugins: ChartJs.PluginOptionsByType<string>, line: Overrides.Item.line, bar: Overrides.Item.bar, scatter: Overrides.Item.scatter, bubble: Overrides.Item.bubble, pie: Overrides.Item.pie, doughnut: Overrides.Item.doughnut, polarArea: Overrides.Item.polarArea, radar: Overrides.Item.radar, scales: Overrides.Item.scales) : Item = nativeOnly

        module Item =

            [<AllowNullLiteral>]
            [<Interface>]
            type datasets =
                [<EmitIndexer>]
                abstract member Item: key: string -> U6<ChartJs.LineControllerDatasetOptions, obj, ChartJs.BarControllerDatasetOptions, ChartJs.BubbleControllerDatasetOptions, ChartJs.DoughnutControllerDatasetOptions, ChartJs.PolarAreaControllerDatasetOptions> with get, set

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type indexAxis =
                | x
                | y

            [<AllowNullLiteral>]
            [<Interface>]
            type font =
                /// <summary>
                /// Default font family for all text, follows CSS font-family options.
                /// </summary>
                abstract member family: string option with get, set
                /// <summary>
                /// Default font size (in px) for text. Does not apply to radialLinear scale point labels.
                /// </summary>
                abstract member size: float option with get, set
                /// <summary>
                /// Default font style. Does not apply to tooltip title or footer. Does not apply to chart title. Follows CSS font-style options (i.e. normal, italic, oblique, initial, inherit)
                /// </summary>
                abstract member style: Overrides.Item.font.Partial.style option with get, set
                /// <summary>
                /// Default font weight (boldness). (see MDN).
                /// </summary>
                abstract member weight: Overrides.Item.font.Partial.weight option with get, set
                /// <summary>
                /// Height of an individual line of text (see MDN).
                /// </summary>
                abstract member lineHeight: U2<float, string> option with get, set

            type onResize =
                delegate of chart: ChartJs.dist.types.Chart * size: Overrides.Item.onResize.size -> unit

            type onHover =
                delegate of event: ChartJs.ChartEvent * elements: ResizeArray<ChartJs.ActiveElement> * chart: ChartJs.dist.types.Chart -> unit

            type onClick =
                delegate of event: ChartJs.ChartEvent * elements: ResizeArray<ChartJs.ActiveElement> * chart: ChartJs.dist.types.Chart -> unit

            [<AllowNullLiteral>]
            [<Interface>]
            type layout =
                abstract member autoPadding: bool option with get, set
                abstract member padding: ChartJs.Scriptable<ChartJs.Padding, ChartJs.ScriptableContext<obj>> option with get, set

            [<AllowNullLiteral>]
            [<Interface>]
            type line =
                abstract member datasets: obj with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (datasets: obj) : line = nativeOnly

            [<AllowNullLiteral>]
            [<Interface>]
            type bar =
                abstract member datasets: ChartJs.BarControllerDatasetOptions with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (datasets: ChartJs.BarControllerDatasetOptions) : bar = nativeOnly

            [<AllowNullLiteral>]
            [<Interface>]
            type scatter =
                abstract member datasets: ChartJs.LineControllerDatasetOptions with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (datasets: ChartJs.LineControllerDatasetOptions) : scatter = nativeOnly

            [<AllowNullLiteral>]
            [<Interface>]
            type bubble =
                abstract member datasets: ChartJs.BubbleControllerDatasetOptions with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (datasets: ChartJs.BubbleControllerDatasetOptions) : bubble = nativeOnly

            [<AllowNullLiteral>]
            [<Interface>]
            type pie =
                abstract member datasets: ChartJs.DoughnutControllerDatasetOptions with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (datasets: ChartJs.DoughnutControllerDatasetOptions) : pie = nativeOnly

            [<AllowNullLiteral>]
            [<Interface>]
            type doughnut =
                abstract member datasets: ChartJs.DoughnutControllerDatasetOptions with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (datasets: ChartJs.DoughnutControllerDatasetOptions) : doughnut = nativeOnly

            [<AllowNullLiteral>]
            [<Interface>]
            type polarArea =
                abstract member datasets: ChartJs.PolarAreaControllerDatasetOptions with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (datasets: ChartJs.PolarAreaControllerDatasetOptions) : polarArea = nativeOnly

            [<AllowNullLiteral>]
            [<Interface>]
            type radar =
                abstract member datasets: obj with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (datasets: obj) : radar = nativeOnly

            [<AllowNullLiteral>]
            [<Interface>]
            type scales =
                [<EmitIndexer>]
                abstract member Item: key: string -> ChartJs.ScaleOptionsByType<obj> with get, set

            module font =

                module Partial =

                    [<RequireQualifiedAccess>]
                    [<StringEnum(CaseRules.None)>]
                    type style =
                        | normal
                        | italic
                        | oblique
                        | initial
                        | ``inherit``

                    [<RequireQualifiedAccess>]
                    [<Erase(CaseRules.None)>]
                    type weight =
                        | normal
                        | bold
                        | lighter
                        | bolder
                        | Case1 of float

                        [<Emit("$0")>]
                        static member op_Implicit(value: float) : weight = nativeOnly

                        [<Emit("$0")>]
                        static member op_ErasedCast(value: float) : weight = nativeOnly

            module onResize =

                [<AllowNullLiteral>]
                [<Interface>]
                type size =
                    abstract member width: float with get, set
                    abstract member height: float with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (width: float, height: float) : size = nativeOnly

    module Plugin =

        type install =
            delegate of chart: ChartJs.dist.types.Chart<obj> * args: ChartJs.EmptyObject * options: obj -> unit

        type start =
            delegate of chart: ChartJs.dist.types.Chart<obj> * args: ChartJs.EmptyObject * options: obj -> unit

        type stop =
            delegate of chart: ChartJs.dist.types.Chart<obj> * args: ChartJs.EmptyObject * options: obj -> unit

        type beforeInit =
            delegate of chart: ChartJs.dist.types.Chart<obj> * args: ChartJs.EmptyObject * options: obj -> unit

        type afterInit =
            delegate of chart: ChartJs.dist.types.Chart<obj> * args: ChartJs.EmptyObject * options: obj -> unit

        type beforeUpdate =
            delegate of chart: ChartJs.dist.types.Chart<obj> * args: Plugin.beforeUpdate.args * options: obj -> U2<bool, unit>

        type afterUpdate =
            delegate of chart: ChartJs.dist.types.Chart<obj> * args: Plugin.afterUpdate.args * options: obj -> unit

        type beforeElementsUpdate =
            delegate of chart: ChartJs.dist.types.Chart<obj> * args: ChartJs.EmptyObject * options: obj -> unit

        type reset =
            delegate of chart: ChartJs.dist.types.Chart<obj> * args: ChartJs.EmptyObject * options: obj -> unit

        type beforeDatasetsUpdate =
            delegate of chart: ChartJs.dist.types.Chart<obj> * args: Plugin.beforeDatasetsUpdate.args * options: obj -> U2<bool, unit>

        type afterDatasetsUpdate =
            delegate of chart: ChartJs.dist.types.Chart<obj> * args: Plugin.afterDatasetsUpdate.args * options: obj -> unit

        type beforeDatasetUpdate =
            delegate of chart: ChartJs.dist.types.Chart<obj> * args: Plugin.beforeDatasetUpdate.args * options: obj -> U2<bool, unit>

        type afterDatasetUpdate =
            delegate of chart: ChartJs.dist.types.Chart<obj> * args: Plugin.afterDatasetUpdate.args * options: obj -> unit

        type beforeLayout =
            delegate of chart: ChartJs.dist.types.Chart<obj> * args: Plugin.beforeLayout.args * options: obj -> U2<bool, unit>

        type beforeDataLimits =
            delegate of chart: ChartJs.dist.types.Chart<obj> * args: Plugin.beforeDataLimits.args * options: obj -> unit

        type afterDataLimits =
            delegate of chart: ChartJs.dist.types.Chart<obj> * args: Plugin.afterDataLimits.args * options: obj -> unit

        type beforeBuildTicks =
            delegate of chart: ChartJs.dist.types.Chart<obj> * args: Plugin.beforeBuildTicks.args * options: obj -> unit

        type afterBuildTicks =
            delegate of chart: ChartJs.dist.types.Chart<obj> * args: Plugin.afterBuildTicks.args * options: obj -> unit

        type afterLayout =
            delegate of chart: ChartJs.dist.types.Chart<obj> * args: ChartJs.EmptyObject * options: obj -> unit

        type beforeRender =
            delegate of chart: ChartJs.dist.types.Chart<obj> * args: Plugin.beforeRender.args * options: obj -> U2<bool, unit>

        type afterRender =
            delegate of chart: ChartJs.dist.types.Chart<obj> * args: ChartJs.EmptyObject * options: obj -> unit

        type beforeDraw =
            delegate of chart: ChartJs.dist.types.Chart<obj> * args: Plugin.beforeDraw.args * options: obj -> U2<bool, unit>

        type afterDraw =
            delegate of chart: ChartJs.dist.types.Chart<obj> * args: ChartJs.EmptyObject * options: obj -> unit

        type beforeDatasetsDraw =
            delegate of chart: ChartJs.dist.types.Chart<obj> * args: Plugin.beforeDatasetsDraw.args * options: obj -> U2<bool, unit>

        type afterDatasetsDraw =
            delegate of chart: ChartJs.dist.types.Chart<obj> * args: ChartJs.EmptyObject * options: obj * cancelable: bool -> unit

        type beforeDatasetDraw =
            delegate of chart: ChartJs.dist.types.Chart<obj> * args: Plugin.beforeDatasetDraw.args * options: obj -> U2<bool, unit>

        type afterDatasetDraw =
            delegate of chart: ChartJs.dist.types.Chart<obj> * args: Plugin.afterDatasetDraw.args * options: obj -> unit

        type beforeEvent =
            delegate of chart: ChartJs.dist.types.Chart<obj> * args: Plugin.beforeEvent.args * options: obj -> U2<bool, unit>

        type afterEvent =
            delegate of chart: ChartJs.dist.types.Chart<obj> * args: Plugin.afterEvent.args * options: obj -> unit

        type resize =
            delegate of chart: ChartJs.dist.types.Chart<obj> * args: Plugin.resize.args * options: obj -> unit

        type beforeDestroy =
            delegate of chart: ChartJs.dist.types.Chart<obj> * args: ChartJs.EmptyObject * options: obj -> unit

        type afterDestroy =
            delegate of chart: ChartJs.dist.types.Chart<obj> * args: ChartJs.EmptyObject * options: obj -> unit

        type uninstall =
            delegate of chart: ChartJs.dist.types.Chart<obj> * args: ChartJs.EmptyObject * options: obj -> unit

        [<AllowNullLiteral>]
        [<Interface>]
        type defaults =
            interface end

        module beforeUpdate =

            [<AllowNullLiteral>]
            [<Interface>]
            type args =
                abstract member mode: ChartJs.UpdateMode with get, set
                abstract member cancelable: bool with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (mode: ChartJs.UpdateMode, cancelable: bool) : args = nativeOnly

        module afterUpdate =

            [<AllowNullLiteral>]
            [<Interface>]
            type args =
                abstract member mode: ChartJs.UpdateMode with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (mode: ChartJs.UpdateMode) : args = nativeOnly

        module beforeDatasetsUpdate =

            [<AllowNullLiteral>]
            [<Interface>]
            type args =
                abstract member mode: ChartJs.UpdateMode with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (mode: ChartJs.UpdateMode) : args = nativeOnly

        module afterDatasetsUpdate =

            [<AllowNullLiteral>]
            [<Interface>]
            type args =
                abstract member mode: ChartJs.UpdateMode with get, set
                abstract member cancelable: bool with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (mode: ChartJs.UpdateMode, cancelable: bool) : args = nativeOnly

        module beforeDatasetUpdate =

            [<AllowNullLiteral>]
            [<Interface>]
            type args =
                abstract member index: float with get, set
                abstract member meta: ChartJs.ChartMeta with get, set
                abstract member mode: ChartJs.UpdateMode with get, set
                abstract member cancelable: bool with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (index: float, meta: ChartJs.ChartMeta, mode: ChartJs.UpdateMode, cancelable: bool) : args = nativeOnly

        module afterDatasetUpdate =

            [<AllowNullLiteral>]
            [<Interface>]
            type args =
                abstract member index: float with get, set
                abstract member meta: ChartJs.ChartMeta with get, set
                abstract member mode: ChartJs.UpdateMode with get, set
                abstract member cancelable: bool with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (index: float, meta: ChartJs.ChartMeta, mode: ChartJs.UpdateMode, cancelable: bool) : args = nativeOnly

        module beforeLayout =

            [<AllowNullLiteral>]
            [<Interface>]
            type args =
                abstract member cancelable: bool with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (cancelable: bool) : args = nativeOnly

        module beforeDataLimits =

            [<AllowNullLiteral>]
            [<Interface>]
            type args =
                abstract member scale: ChartJs.Scale with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (scale: ChartJs.Scale) : args = nativeOnly

        module afterDataLimits =

            [<AllowNullLiteral>]
            [<Interface>]
            type args =
                abstract member scale: ChartJs.Scale with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (scale: ChartJs.Scale) : args = nativeOnly

        module beforeBuildTicks =

            [<AllowNullLiteral>]
            [<Interface>]
            type args =
                abstract member scale: ChartJs.Scale with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (scale: ChartJs.Scale) : args = nativeOnly

        module afterBuildTicks =

            [<AllowNullLiteral>]
            [<Interface>]
            type args =
                abstract member scale: ChartJs.Scale with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (scale: ChartJs.Scale) : args = nativeOnly

        module beforeRender =

            [<AllowNullLiteral>]
            [<Interface>]
            type args =
                abstract member cancelable: bool with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (cancelable: bool) : args = nativeOnly

        module beforeDraw =

            [<AllowNullLiteral>]
            [<Interface>]
            type args =
                abstract member cancelable: bool with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (cancelable: bool) : args = nativeOnly

        module beforeDatasetsDraw =

            [<AllowNullLiteral>]
            [<Interface>]
            type args =
                abstract member cancelable: bool with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (cancelable: bool) : args = nativeOnly

        module beforeDatasetDraw =

            [<AllowNullLiteral>]
            [<Interface>]
            type args =
                abstract member index: float with get, set
                abstract member meta: ChartJs.ChartMeta with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (index: float, meta: ChartJs.ChartMeta) : args = nativeOnly

        module afterDatasetDraw =

            [<AllowNullLiteral>]
            [<Interface>]
            type args =
                abstract member index: float with get, set
                abstract member meta: ChartJs.ChartMeta with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (index: float, meta: ChartJs.ChartMeta) : args = nativeOnly

        module beforeEvent =

            [<AllowNullLiteral>]
            [<Interface>]
            type args =
                abstract member event: ChartJs.ChartEvent with get, set
                abstract member replay: bool with get, set
                abstract member changed: bool option with get, set
                abstract member cancelable: bool with get, set
                abstract member inChartArea: bool with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (event: ChartJs.ChartEvent, replay: bool, cancelable: bool, inChartArea: bool, ?changed: bool) : args = nativeOnly

        module afterEvent =

            [<AllowNullLiteral>]
            [<Interface>]
            type args =
                abstract member event: ChartJs.ChartEvent with get, set
                abstract member replay: bool with get, set
                abstract member changed: bool option with get, set
                abstract member cancelable: bool with get, set
                abstract member inChartArea: bool with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (event: ChartJs.ChartEvent, replay: bool, cancelable: bool, inChartArea: bool, ?changed: bool) : args = nativeOnly

        module resize =

            [<AllowNullLiteral>]
            [<Interface>]
            type args =
                abstract member size: Plugin.resize.args.size with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (size: Plugin.resize.args.size) : args = nativeOnly

            module args =

                [<AllowNullLiteral>]
                [<Interface>]
                type size =
                    abstract member width: float with get, set
                    abstract member height: float with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (width: float, height: float) : size = nativeOnly

    module ChartComponentLike =

        module U5 =

            [<AllowNullLiteral>]
            [<Interface>]
            type Case3 =
                [<EmitIndexer>]
                abstract member Item: key: string -> ChartJs.ChartComponent with get, set

    module CoreScaleOptions =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type display =
            | [<CompiledValue(true)>] True
            | [<CompiledValue(false)>] False
            | auto

    module Scale =

        [<AllowNullLiteral>]
        [<Interface>]
        type getUserBounds =
            abstract member min: float with get, set
            abstract member max: float with get, set
            abstract member minDefined: bool with get, set
            abstract member maxDefined: bool with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (min: float, max: float, minDefined: bool, maxDefined: bool) : getUserBounds = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type getMinMax =
            abstract member min: float with get, set
            abstract member max: float with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (min: float, max: float) : getMinMax = nativeOnly

    module ChartEvent =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type ``type`` =
            | contextmenu
            | mouseenter
            | mousedown
            | mousemove
            | mouseup
            | mouseout
            | click
            | dblclick
            | keydown
            | keypress
            | keyup
            | resize

    module ChartComponent =

        [<AllowNullLiteral>]
        [<Interface>]
        type defaultRoutes =
            [<EmitIndexer>]
            abstract member Item: property: string -> string with get, set

    module CoreChartOptions =

        [<AllowNullLiteral>]
        [<Interface>]
        type datasets =
            [<EmitIndexer>]
            abstract member Item: key: string -> U6<ChartJs.LineControllerDatasetOptions, obj, ChartJs.BarControllerDatasetOptions, ChartJs.BubbleControllerDatasetOptions, ChartJs.DoughnutControllerDatasetOptions, ChartJs.PolarAreaControllerDatasetOptions> with get, set

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type indexAxis =
            | x
            | y

        [<AllowNullLiteral>]
        [<Interface>]
        type font =
            /// <summary>
            /// Default font family for all text, follows CSS font-family options.
            /// </summary>
            abstract member family: string option with get, set
            /// <summary>
            /// Default font size (in px) for text. Does not apply to radialLinear scale point labels.
            /// </summary>
            abstract member size: float option with get, set
            /// <summary>
            /// Default font style. Does not apply to tooltip title or footer. Does not apply to chart title. Follows CSS font-style options (i.e. normal, italic, oblique, initial, inherit)
            /// </summary>
            abstract member style: CoreChartOptions.font.Partial.style option with get, set
            /// <summary>
            /// Default font weight (boldness). (see MDN).
            /// </summary>
            abstract member weight: CoreChartOptions.font.Partial.weight option with get, set
            /// <summary>
            /// Height of an individual line of text (see MDN).
            /// </summary>
            abstract member lineHeight: U2<float, string> option with get, set

        [<AllowNullLiteral>]
        [<Interface>]
        type layout<'TType> =
            abstract member autoPadding: bool option with get, set
            abstract member padding: ChartJs.Scriptable<ChartJs.Padding, ChartJs.ScriptableContext<'TType>> option with get, set

        module font =

            module Partial =

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type style =
                    | normal
                    | italic
                    | oblique
                    | initial
                    | ``inherit``

                [<RequireQualifiedAccess>]
                [<Erase(CaseRules.None)>]
                type weight =
                    | normal
                    | bold
                    | lighter
                    | bolder
                    | Case1 of float

                    [<Emit("$0")>]
                    static member op_Implicit(value: float) : weight = nativeOnly

                    [<Emit("$0")>]
                    static member op_ErasedCast(value: float) : weight = nativeOnly

    module AnimationsSpec =

        module Item =

            module U2 =

                [<AllowNullLiteral>]
                [<Interface>]
                type Case2<'TType> =
                    /// <summary>
                    /// The number of milliseconds an animation takes.
                    /// </summary>
                    abstract member duration: ChartJs.Scriptable<float, ChartJs.ScriptableContext<'TType>> option with get, set
                    /// <summary>
                    /// Easing function to use
                    /// </summary>
                    abstract member easing: ChartJs.Scriptable<AnimationsSpec.Item.U2.Case2.easing, ChartJs.ScriptableContext<'TType>> option with get, set
                    /// <summary>
                    /// Delay before starting the animations.
                    /// </summary>
                    abstract member delay: ChartJs.Scriptable<float, ChartJs.ScriptableContext<'TType>> option with get, set
                    /// <summary>
                    /// If set to true, the animations loop endlessly.
                    /// </summary>
                    abstract member loop: ChartJs.Scriptable<bool, ChartJs.ScriptableContext<'TType>> option with get, set
                    abstract member properties: ResizeArray<string> with get, set
                    /// <summary>
                    /// Type of property, determines the interpolator used. Possible values: 'number', 'color' and 'boolean'. Only really needed for 'color', because typeof does not get that right.
                    /// </summary>
                    abstract member ``type``: AnimationsSpec.Item.U2.Case2.``type`` with get, set
                    abstract member fn: AnimationsSpec.Item.U2.Case2.fn<obj> with get, set
                    /// <summary>
                    /// Start value for the animation. Current value is used when undefined
                    /// </summary>
                    abstract member from: ChartJs.Scriptable<U3<ChartJs.Color, float, bool>, ChartJs.ScriptableContext<'TType>> with get, set
                    abstract member ``to``: ChartJs.Scriptable<U3<ChartJs.Color, float, bool>, ChartJs.ScriptableContext<'TType>> with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (properties: ResizeArray<string>, ``type``: AnimationsSpec.Item.U2.Case2.``type``, fn: AnimationsSpec.Item.U2.Case2.fn<obj>, from: ChartJs.Scriptable<U3<ChartJs.Color, float, bool>, ChartJs.ScriptableContext<'TType>>, ``to``: ChartJs.Scriptable<U3<ChartJs.Color, float, bool>, ChartJs.ScriptableContext<'TType>>, ?duration: ChartJs.Scriptable<float, ChartJs.ScriptableContext<'TType>>, ?easing: ChartJs.Scriptable<AnimationsSpec.Item.U2.Case2.easing, ChartJs.ScriptableContext<'TType>>, ?delay: ChartJs.Scriptable<float, ChartJs.ScriptableContext<'TType>>, ?loop: ChartJs.Scriptable<bool, ChartJs.ScriptableContext<'TType>>) : Case2<'TType> = nativeOnly

                module Case2 =

                    [<RequireQualifiedAccess>]
                    [<StringEnum(CaseRules.None)>]
                    type easing =
                        | linear
                        | easeInQuad
                        | easeOutQuad
                        | easeInOutQuad
                        | easeInCubic
                        | easeOutCubic
                        | easeInOutCubic
                        | easeInQuart
                        | easeOutQuart
                        | easeInOutQuart
                        | easeInQuint
                        | easeOutQuint
                        | easeInOutQuint
                        | easeInSine
                        | easeOutSine
                        | easeInOutSine
                        | easeInExpo
                        | easeOutExpo
                        | easeInOutExpo
                        | easeInCirc
                        | easeOutCirc
                        | easeInOutCirc
                        | easeInElastic
                        | easeOutElastic
                        | easeInOutElastic
                        | easeInBack
                        | easeOutBack
                        | easeInOutBack
                        | easeInBounce
                        | easeOutBounce
                        | easeInOutBounce

                    [<RequireQualifiedAccess>]
                    [<StringEnum(CaseRules.None)>]
                    type ``type`` =
                        | color
                        | number
                        | boolean

                    type fn<'T> =
                        delegate of from: 'T * ``to``: 'T * factor: float -> 'T

    module TransitionSpec =

        [<AllowNullLiteral>]
        [<Interface>]
        type animation<'TType> =
            /// <summary>
            /// The number of milliseconds an animation takes.
            /// </summary>
            abstract member duration: ChartJs.Scriptable<float, ChartJs.ScriptableContext<'TType>> option with get, set
            /// <summary>
            /// Easing function to use
            /// </summary>
            abstract member easing: ChartJs.Scriptable<TransitionSpec.animation.easing, ChartJs.ScriptableContext<'TType>> option with get, set
            /// <summary>
            /// Delay before starting the animations.
            /// </summary>
            abstract member delay: ChartJs.Scriptable<float, ChartJs.ScriptableContext<'TType>> option with get, set
            /// <summary>
            /// If set to true, the animations loop endlessly.
            /// </summary>
            abstract member loop: ChartJs.Scriptable<bool, ChartJs.ScriptableContext<'TType>> option with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (?duration: ChartJs.Scriptable<float, ChartJs.ScriptableContext<'TType>>, ?easing: ChartJs.Scriptable<TransitionSpec.animation.easing, ChartJs.ScriptableContext<'TType>>, ?delay: ChartJs.Scriptable<float, ChartJs.ScriptableContext<'TType>>, ?loop: ChartJs.Scriptable<bool, ChartJs.ScriptableContext<'TType>>) : animation<'TType> = nativeOnly

        module animation =

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type easing =
                | linear
                | easeInQuad
                | easeOutQuad
                | easeInOutQuad
                | easeInCubic
                | easeOutCubic
                | easeInOutCubic
                | easeInQuart
                | easeOutQuart
                | easeInOutQuart
                | easeInQuint
                | easeOutQuint
                | easeInOutQuint
                | easeInSine
                | easeOutSine
                | easeInOutSine
                | easeInExpo
                | easeOutExpo
                | easeInOutExpo
                | easeInCirc
                | easeOutCirc
                | easeInOutCirc
                | easeInElastic
                | easeOutElastic
                | easeInOutElastic
                | easeInBack
                | easeOutBack
                | easeInOutBack
                | easeInBounce
                | easeOutBounce
                | easeInOutBounce

    module TransitionsSpec =

        [<AllowNullLiteral>]
        [<Interface>]
        type Item<'TType> =
            abstract member animation: ChartJs.AnimationSpec<'TType> with get, set
            abstract member animations: ChartJs.AnimationsSpec<'TType> with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (animation: ChartJs.AnimationSpec<'TType>, animations: ChartJs.AnimationsSpec<'TType>) : Item<'TType> = nativeOnly

    module AnimationOptions =

        module animation =

            module U2 =

                [<AllowNullLiteral>]
                [<Interface>]
                type Case2<'TType> =
                    /// <summary>
                    /// The number of milliseconds an animation takes.
                    /// </summary>
                    abstract member duration: ChartJs.Scriptable<float, ChartJs.ScriptableContext<'TType>> option with get, set
                    /// <summary>
                    /// Easing function to use
                    /// </summary>
                    abstract member easing: ChartJs.Scriptable<AnimationOptions.animation.U2.Case2.easing, ChartJs.ScriptableContext<'TType>> option with get, set
                    /// <summary>
                    /// Delay before starting the animations.
                    /// </summary>
                    abstract member delay: ChartJs.Scriptable<float, ChartJs.ScriptableContext<'TType>> option with get, set
                    /// <summary>
                    /// If set to true, the animations loop endlessly.
                    /// </summary>
                    abstract member loop: ChartJs.Scriptable<bool, ChartJs.ScriptableContext<'TType>> option with get, set
                    /// <summary>
                    /// Callback called on each step of an animation.
                    /// </summary>
                    abstract member onProgress: (ChartJs.AnimationEvent -> unit) option with get, set
                    /// <summary>
                    /// Callback called when all animations are completed.
                    /// </summary>
                    abstract member onComplete: (ChartJs.AnimationEvent -> unit) option with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (?duration: ChartJs.Scriptable<float, ChartJs.ScriptableContext<'TType>>, ?easing: ChartJs.Scriptable<AnimationOptions.animation.U2.Case2.easing, ChartJs.ScriptableContext<'TType>>, ?delay: ChartJs.Scriptable<float, ChartJs.ScriptableContext<'TType>>, ?loop: ChartJs.Scriptable<bool, ChartJs.ScriptableContext<'TType>>, ?onProgress: (ChartJs.AnimationEvent -> unit), ?onComplete: (ChartJs.AnimationEvent -> unit)) : Case2<'TType> = nativeOnly

                module Case2 =

                    [<RequireQualifiedAccess>]
                    [<StringEnum(CaseRules.None)>]
                    type easing =
                        | linear
                        | easeInQuad
                        | easeOutQuad
                        | easeInOutQuad
                        | easeInCubic
                        | easeOutCubic
                        | easeInOutCubic
                        | easeInQuart
                        | easeOutQuart
                        | easeInOutQuart
                        | easeInQuint
                        | easeOutQuint
                        | easeInOutQuint
                        | easeInSine
                        | easeOutSine
                        | easeInOutSine
                        | easeInExpo
                        | easeOutExpo
                        | easeInOutExpo
                        | easeInCirc
                        | easeOutCirc
                        | easeInOutCirc
                        | easeInElastic
                        | easeOutElastic
                        | easeInOutElastic
                        | easeInBack
                        | easeOutBack
                        | easeInOutBack
                        | easeInBounce
                        | easeOutBounce
                        | easeInOutBounce

    module FontSpec =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type style =
            | normal
            | italic
            | oblique
            | initial
            | ``inherit``

        [<RequireQualifiedAccess>]
        [<Erase(CaseRules.None)>]
        type weight =
            | normal
            | bold
            | lighter
            | bolder
            | Case1 of float

            [<Emit("$0")>]
            static member op_Implicit(value: float) : weight = nativeOnly

            [<Emit("$0")>]
            static member op_ErasedCast(value: float) : weight = nativeOnly

    module CanvasFontSpec =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type style =
            | normal
            | italic
            | oblique
            | initial
            | ``inherit``

        [<RequireQualifiedAccess>]
        [<Erase(CaseRules.None)>]
        type weight =
            | normal
            | bold
            | lighter
            | bolder
            | Case1 of float

            [<Emit("$0")>]
            static member op_Implicit(value: float) : weight = nativeOnly

            [<Emit("$0")>]
            static member op_ErasedCast(value: float) : weight = nativeOnly

    module VisualElement =

        module getRange =

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type axis =
                | x
                | y

    module ArcOptions =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type borderAlign =
            | center
            | inner

    module LineOptions =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type cubicInterpolationMode =
            | ``default``
            | monotone

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type stepped =
            | before
            | after
            | middle
            | [<CompiledValue(true)>] True
            | [<CompiledValue(false)>] False

    module LineElement =

        module updateControlPoints =

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type indexAxis =
                | x
                | y

        module interpolate =

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type property =
                | x
                | y

    module BarOptions =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type borderSkipped =
            | start
            | ``end``
            | left
            | right
            | bottom
            | top
            | middle
            | [<CompiledValue(true)>] True
            | [<CompiledValue(false)>] False

        [<RequireQualifiedAccess>]
        [<Erase(CaseRules.None)>]
        type inflateAmount =
            | auto
            | Case1 of float

            [<Emit("$0")>]
            static member op_Implicit(value: float) : inflateAmount = nativeOnly

            [<Emit("$0")>]
            static member op_ErasedCast(value: float) : inflateAmount = nativeOnly

        module borderWidth =

            module U2 =

                [<AllowNullLiteral>]
                [<Interface>]
                type Case2 =
                    abstract member top: float option with get, set
                    abstract member right: float option with get, set
                    abstract member bottom: float option with get, set
                    abstract member left: float option with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (?top: float, ?right: float, ?bottom: float, ?left: float) : Case2 = nativeOnly

    module ElementOptionsByType =

        [<AllowNullLiteral>]
        [<Interface>]
        type arc<'TType> =
            /// <summary>
            /// If true, Arc can take up 100% of a circular graph without any visual split or cut. This option doesn't support borderRadius and borderJoinStyle miter
            /// </summary>
            abstract member selfJoin: ChartJs.ScriptableAndArray<bool, ChartJs.ScriptableContext<'TType>> with get, set
            /// <summary>
            /// Arc stroke alignment.
            /// </summary>
            abstract member borderAlign: ChartJs.ScriptableAndArray<ElementOptionsByType.arc.borderAlign, ChartJs.ScriptableContext<'TType>> with get, set
            /// <summary>
            /// Line dash. See MDN.
            /// </summary>
            abstract member borderDash: ChartJs.ScriptableAndArray<ResizeArray<float>, ChartJs.ScriptableContext<'TType>> with get, set
            /// <summary>
            /// Line dash offset. See MDN.
            /// </summary>
            abstract member borderDashOffset: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<'TType>> with get, set
            /// <summary>
            /// Line join style. See MDN. Default is 'round' when <c>borderAlign</c> is 'inner', else 'bevel'.
            /// </summary>
            abstract member borderJoinStyle: ChartJs.ScriptableAndArray<Glutinum.Web.CanvasLineJoin, ChartJs.ScriptableContext<'TType>> with get, set
            /// <summary>
            /// Sets the border radius for arcs
            /// </summary>
            abstract member borderRadius: ChartJs.ScriptableAndArray<U2<float, ChartJs.ArcBorderRadius>, ChartJs.ScriptableContext<'TType>> with get, set
            /// <summary>
            /// Arc offset (in pixels).
            /// </summary>
            abstract member offset: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<'TType>> with get, set
            /// <summary>
            /// If false, Arc will be flat.
            /// </summary>
            abstract member circular: ChartJs.ScriptableAndArray<bool, ChartJs.ScriptableContext<'TType>> with get, set
            /// <summary>
            /// Spacing between arcs
            /// </summary>
            abstract member spacing: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<'TType>> with get, set
            abstract member borderWidth: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<'TType>> with get, set
            abstract member borderColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<'TType>> with get, set
            abstract member backgroundColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<'TType>> with get, set
            abstract member hoverBorderDash: ChartJs.ScriptableAndArray<ResizeArray<float>, ChartJs.ScriptableContext<'TType>> with get, set
            abstract member hoverBorderDashOffset: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<'TType>> with get, set
            abstract member hoverOffset: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<'TType>> with get, set
            abstract member hoverBorderWidth: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<'TType>> with get, set
            abstract member hoverBorderColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<'TType>> with get, set
            abstract member hoverBackgroundColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<'TType>> with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (selfJoin: ChartJs.ScriptableAndArray<bool, ChartJs.ScriptableContext<'TType>>, borderAlign: ChartJs.ScriptableAndArray<ElementOptionsByType.arc.borderAlign, ChartJs.ScriptableContext<'TType>>, borderDash: ChartJs.ScriptableAndArray<ResizeArray<float>, ChartJs.ScriptableContext<'TType>>, borderDashOffset: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<'TType>>, borderJoinStyle: ChartJs.ScriptableAndArray<Glutinum.Web.CanvasLineJoin, ChartJs.ScriptableContext<'TType>>, borderRadius: ChartJs.ScriptableAndArray<U2<float, ChartJs.ArcBorderRadius>, ChartJs.ScriptableContext<'TType>>, offset: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<'TType>>, circular: ChartJs.ScriptableAndArray<bool, ChartJs.ScriptableContext<'TType>>, spacing: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<'TType>>, borderWidth: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<'TType>>, borderColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<'TType>>, backgroundColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<'TType>>, hoverBorderDash: ChartJs.ScriptableAndArray<ResizeArray<float>, ChartJs.ScriptableContext<'TType>>, hoverBorderDashOffset: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<'TType>>, hoverOffset: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<'TType>>, hoverBorderWidth: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<'TType>>, hoverBorderColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<'TType>>, hoverBackgroundColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<'TType>>) : arc<'TType> = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type bar<'TType> =
            /// <summary>
            /// The base value for the bar in data units along the value axis.
            /// </summary>
            abstract member ``base``: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<'TType>> with get, set
            /// <summary>
            /// Skipped (excluded) border: 'start', 'end', 'left',  'right', 'bottom', 'top', 'middle', false (none) or true (all).
            /// </summary>
            abstract member borderSkipped: ChartJs.ScriptableAndArray<ElementOptionsByType.bar.borderSkipped, ChartJs.ScriptableContext<'TType>> with get, set
            /// <summary>
            /// Border radius
            /// </summary>
            abstract member borderRadius: ChartJs.ScriptableAndArray<U2<float, ChartJs.BorderRadius>, ChartJs.ScriptableContext<'TType>> with get, set
            /// <summary>
            /// Amount to inflate the rectangle(s). This can be used to hide artifacts between bars.
            /// Unit is pixels. 'auto' translates to 0.33 pixels when barPercentage * categoryPercentage is 1, else 0.
            /// </summary>
            abstract member inflateAmount: ChartJs.ScriptableAndArray<ElementOptionsByType.bar.inflateAmount, ChartJs.ScriptableContext<'TType>> with get, set
            /// <summary>
            /// Width of the border, number for all sides, object to specify width for each side specifically
            /// </summary>
            abstract member borderWidth: ChartJs.ScriptableAndArray<U2<float, ElementOptionsByType.bar.borderWidth.U2.Case2>, ChartJs.ScriptableContext<'TType>> with get, set
            abstract member backgroundColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<'TType>> with get, set
            abstract member borderColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<'TType>> with get, set
            abstract member hoverBorderRadius: ChartJs.ScriptableAndArray<U2<float, ChartJs.BorderRadius>, ChartJs.ScriptableContext<'TType>> with get, set
            abstract member hoverBorderWidth: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<'TType>> with get, set
            abstract member hoverBorderColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<'TType>> with get, set
            abstract member hoverBackgroundColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<'TType>> with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (``base``: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<'TType>>, borderSkipped: ChartJs.ScriptableAndArray<ElementOptionsByType.bar.borderSkipped, ChartJs.ScriptableContext<'TType>>, borderRadius: ChartJs.ScriptableAndArray<U2<float, ChartJs.BorderRadius>, ChartJs.ScriptableContext<'TType>>, inflateAmount: ChartJs.ScriptableAndArray<ElementOptionsByType.bar.inflateAmount, ChartJs.ScriptableContext<'TType>>, borderWidth: ChartJs.ScriptableAndArray<U2<float, ElementOptionsByType.bar.borderWidth.U2.Case2>, ChartJs.ScriptableContext<'TType>>, backgroundColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<'TType>>, borderColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<'TType>>, hoverBorderRadius: ChartJs.ScriptableAndArray<U2<float, ChartJs.BorderRadius>, ChartJs.ScriptableContext<'TType>>, hoverBorderWidth: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<'TType>>, hoverBorderColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<'TType>>, hoverBackgroundColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<'TType>>) : bar<'TType> = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type line<'TType> =
            /// <summary>
            /// Line cap style. See MDN.
            /// </summary>
            abstract member borderCapStyle: ChartJs.ScriptableAndArray<Glutinum.Web.CanvasLineCap, ChartJs.ScriptableContext<'TType>> with get, set
            /// <summary>
            /// Line dash. See MDN.
            /// </summary>
            abstract member borderDash: ChartJs.ScriptableAndArray<ResizeArray<float>, ChartJs.ScriptableContext<'TType>> with get, set
            /// <summary>
            /// Line dash offset. See MDN.
            /// </summary>
            abstract member borderDashOffset: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<'TType>> with get, set
            /// <summary>
            /// Line join style. See MDN.
            /// </summary>
            abstract member borderJoinStyle: ChartJs.ScriptableAndArray<Glutinum.Web.CanvasLineJoin, ChartJs.ScriptableContext<'TType>> with get, set
            /// <summary>
            /// true to keep Bézier control inside the chart, false for no restriction.
            /// </summary>
            abstract member capBezierPoints: ChartJs.ScriptableAndArray<bool, ChartJs.ScriptableContext<'TType>> with get, set
            /// <summary>
            /// Interpolation mode to apply.
            /// </summary>
            abstract member cubicInterpolationMode: ChartJs.ScriptableAndArray<ElementOptionsByType.line.cubicInterpolationMode, ChartJs.ScriptableContext<'TType>> with get, set
            /// <summary>
            /// Bézier curve tension (0 for no Bézier curves).
            /// </summary>
            abstract member tension: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<'TType>> with get, set
            /// <summary>
            /// true to show the line as a stepped line (tension will be ignored).
            /// </summary>
            abstract member stepped: ChartJs.ScriptableAndArray<ElementOptionsByType.line.stepped, ChartJs.ScriptableContext<'TType>> with get, set
            /// <summary>
            /// Both line and radar charts support a fill option on the dataset object which can be used to create area between two datasets or a dataset and a boundary, i.e. the scale origin, start or end
            /// </summary>
            abstract member fill: ChartJs.ScriptableAndArray<U2<ChartJs.FillTarget, ChartJs.ComplexFillTarget>, ChartJs.ScriptableContext<'TType>> with get, set
            /// <summary>
            /// If true, lines will be drawn between points with no or null data. If false, points with NaN data will create a break in the line. Can also be a number specifying the maximum gap length to span. The unit of the value depends on the scale used.
            /// </summary>
            abstract member spanGaps: ChartJs.ScriptableAndArray<U2<float, bool>, ChartJs.ScriptableContext<'TType>> with get, set
            abstract member segment: ChartJs.ScriptableAndArray<ElementOptionsByType.line.segment, ChartJs.ScriptableContext<'TType>> with get, set
            abstract member borderWidth: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<'TType>> with get, set
            abstract member borderColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<'TType>> with get, set
            abstract member backgroundColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<'TType>> with get, set
            abstract member hoverBorderCapStyle: ChartJs.ScriptableAndArray<Glutinum.Web.CanvasLineCap, ChartJs.ScriptableContext<'TType>> with get, set
            abstract member hoverBorderDash: ChartJs.ScriptableAndArray<ResizeArray<float>, ChartJs.ScriptableContext<'TType>> with get, set
            abstract member hoverBorderDashOffset: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<'TType>> with get, set
            abstract member hoverBorderJoinStyle: ChartJs.ScriptableAndArray<Glutinum.Web.CanvasLineJoin, ChartJs.ScriptableContext<'TType>> with get, set
            abstract member hoverBorderWidth: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<'TType>> with get, set
            abstract member hoverBorderColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<'TType>> with get, set
            abstract member hoverBackgroundColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<'TType>> with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (borderCapStyle: ChartJs.ScriptableAndArray<Glutinum.Web.CanvasLineCap, ChartJs.ScriptableContext<'TType>>, borderDash: ChartJs.ScriptableAndArray<ResizeArray<float>, ChartJs.ScriptableContext<'TType>>, borderDashOffset: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<'TType>>, borderJoinStyle: ChartJs.ScriptableAndArray<Glutinum.Web.CanvasLineJoin, ChartJs.ScriptableContext<'TType>>, capBezierPoints: ChartJs.ScriptableAndArray<bool, ChartJs.ScriptableContext<'TType>>, cubicInterpolationMode: ChartJs.ScriptableAndArray<ElementOptionsByType.line.cubicInterpolationMode, ChartJs.ScriptableContext<'TType>>, tension: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<'TType>>, stepped: ChartJs.ScriptableAndArray<ElementOptionsByType.line.stepped, ChartJs.ScriptableContext<'TType>>, fill: ChartJs.ScriptableAndArray<U2<ChartJs.FillTarget, ChartJs.ComplexFillTarget>, ChartJs.ScriptableContext<'TType>>, spanGaps: ChartJs.ScriptableAndArray<U2<float, bool>, ChartJs.ScriptableContext<'TType>>, segment: ChartJs.ScriptableAndArray<ElementOptionsByType.line.segment, ChartJs.ScriptableContext<'TType>>, borderWidth: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<'TType>>, borderColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<'TType>>, backgroundColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<'TType>>, hoverBorderCapStyle: ChartJs.ScriptableAndArray<Glutinum.Web.CanvasLineCap, ChartJs.ScriptableContext<'TType>>, hoverBorderDash: ChartJs.ScriptableAndArray<ResizeArray<float>, ChartJs.ScriptableContext<'TType>>, hoverBorderDashOffset: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<'TType>>, hoverBorderJoinStyle: ChartJs.ScriptableAndArray<Glutinum.Web.CanvasLineJoin, ChartJs.ScriptableContext<'TType>>, hoverBorderWidth: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<'TType>>, hoverBorderColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<'TType>>, hoverBackgroundColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<'TType>>) : line<'TType> = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type point<'TType> =
            /// <summary>
            /// Point radius
            /// </summary>
            abstract member radius: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<'TType>> with get, set
            /// <summary>
            /// Extra radius added to point radius for hit detection.
            /// </summary>
            abstract member hitRadius: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<'TType>> with get, set
            /// <summary>
            /// Point style
            /// </summary>
            abstract member pointStyle: ChartJs.ScriptableAndArray<ChartJs.PointStyle, ChartJs.ScriptableContext<'TType>> with get, set
            /// <summary>
            /// Point rotation (in degrees).
            /// </summary>
            abstract member rotation: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<'TType>> with get, set
            /// <summary>
            /// Draw the active elements over the other elements of the dataset,
            /// </summary>
            abstract member drawActiveElementsOnTop: ChartJs.ScriptableAndArray<bool, ChartJs.ScriptableContext<'TType>> with get, set
            abstract member borderWidth: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<'TType>> with get, set
            abstract member borderColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<'TType>> with get, set
            abstract member backgroundColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<'TType>> with get, set
            /// <summary>
            /// Point radius when hovered.
            /// </summary>
            abstract member hoverRadius: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<'TType>> with get, set
            abstract member hoverBorderWidth: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<'TType>> with get, set
            abstract member hoverBorderColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<'TType>> with get, set
            abstract member hoverBackgroundColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<'TType>> with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (radius: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<'TType>>, hitRadius: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<'TType>>, pointStyle: ChartJs.ScriptableAndArray<ChartJs.PointStyle, ChartJs.ScriptableContext<'TType>>, rotation: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<'TType>>, drawActiveElementsOnTop: ChartJs.ScriptableAndArray<bool, ChartJs.ScriptableContext<'TType>>, borderWidth: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<'TType>>, borderColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<'TType>>, backgroundColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<'TType>>, hoverRadius: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<'TType>>, hoverBorderWidth: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<'TType>>, hoverBorderColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<'TType>>, hoverBackgroundColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<'TType>>) : point<'TType> = nativeOnly

        module arc =

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type borderAlign =
                | center
                | inner

        module bar =

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type borderSkipped =
                | [<CompiledValue(true)>] True
                | [<CompiledValue(false)>] False
                | start
                | ``end``
                | left
                | right
                | bottom
                | top
                | middle

            [<RequireQualifiedAccess>]
            [<Erase(CaseRules.None)>]
            type inflateAmount =
                | auto
                | Case1 of float

                [<Emit("$0")>]
                static member op_Implicit(value: float) : inflateAmount = nativeOnly

                [<Emit("$0")>]
                static member op_ErasedCast(value: float) : inflateAmount = nativeOnly

            module borderWidth =

                module U2 =

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type Case2 =
                        abstract member top: float option with get, set
                        abstract member right: float option with get, set
                        abstract member bottom: float option with get, set
                        abstract member left: float option with get, set
                        [<ParamObject; Emit("$0")>]
                        static member Create (?top: float, ?right: float, ?bottom: float, ?left: float) : Case2 = nativeOnly

        module line =

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type cubicInterpolationMode =
                | ``default``
                | monotone

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type stepped =
                | [<CompiledValue(true)>] True
                | [<CompiledValue(false)>] False
                | middle
                | before
                | after

            [<AllowNullLiteral>]
            [<Interface>]
            type segment =
                abstract member backgroundColor: ChartJs.Scriptable<ChartJs.Color option, ChartJs.ScriptableLineSegmentContext> with get, set
                abstract member borderColor: ChartJs.Scriptable<ChartJs.Color option, ChartJs.ScriptableLineSegmentContext> with get, set
                abstract member borderCapStyle: ChartJs.Scriptable<Glutinum.Web.CanvasLineCap option, ChartJs.ScriptableLineSegmentContext> with get, set
                abstract member borderDash: ChartJs.Scriptable<ResizeArray<float> option, ChartJs.ScriptableLineSegmentContext> with get, set
                abstract member borderDashOffset: ChartJs.Scriptable<float option, ChartJs.ScriptableLineSegmentContext> with get, set
                abstract member borderJoinStyle: ChartJs.Scriptable<Glutinum.Web.CanvasLineJoin option, ChartJs.ScriptableLineSegmentContext> with get, set
                abstract member borderWidth: ChartJs.Scriptable<float option, ChartJs.ScriptableLineSegmentContext> with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (backgroundColor: ChartJs.Scriptable<ChartJs.Color option, ChartJs.ScriptableLineSegmentContext>, borderColor: ChartJs.Scriptable<ChartJs.Color option, ChartJs.ScriptableLineSegmentContext>, borderCapStyle: ChartJs.Scriptable<Glutinum.Web.CanvasLineCap option, ChartJs.ScriptableLineSegmentContext>, borderDash: ChartJs.Scriptable<ResizeArray<float> option, ChartJs.ScriptableLineSegmentContext>, borderDashOffset: ChartJs.Scriptable<float option, ChartJs.ScriptableLineSegmentContext>, borderJoinStyle: ChartJs.Scriptable<Glutinum.Web.CanvasLineJoin option, ChartJs.ScriptableLineSegmentContext>, borderWidth: ChartJs.Scriptable<float option, ChartJs.ScriptableLineSegmentContext>) : segment = nativeOnly

    module BasePlatform =

        [<AllowNullLiteral>]
        [<Interface>]
        type getMaximumSize =
            abstract member width: float with get, set
            abstract member height: float with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (width: float, height: float) : getMaximumSize = nativeOnly

    module FillerOptions =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type drawTime =
            | beforeDraw
            | beforeDatasetDraw
            | beforeDatasetsDraw

    module FillTarget =

        module Cases =

            [<AllowNullLiteral>]
            [<Interface>]
            type Case3 =
                abstract member value: float with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (value: float) : Case3 = nativeOnly

    module LegendOptions =

        [<AllowNullLiteral>]
        [<Interface>]
        type labels =
            /// <summary>
            /// Width of colored box.
            /// </summary>
            abstract member boxWidth: float with get, set
            /// <summary>
            /// Height of the coloured box.
            /// </summary>
            abstract member boxHeight: float with get, set
            /// <summary>
            /// Color of label
            /// </summary>
            abstract member color: ChartJs.Color with get, set
            /// <summary>
            /// Font of label
            /// </summary>
            abstract member font: ChartJs.ScriptableAndScriptableOptions<LegendOptions.labels.font, ChartJs.ScriptableChartContext> with get, set
            /// <summary>
            /// Padding between rows of colored boxes.
            /// </summary>
            abstract member padding: float with get, set
            /// <summary>
            /// If usePointStyle is true, the width of the point style used for the legend.
            /// </summary>
            abstract member pointStyleWidth: float with get, set
            /// <summary>
            /// Generates legend items for each thing in the legend. Default implementation returns the text + styling for the color box. See Legend Item for details.
            /// </summary>
            abstract member generateLabels: chart: ChartJs.dist.types.Chart -> ResizeArray<ChartJs.LegendItem>
            /// <summary>
            /// Filters legend items out of the legend. Receives 2 parameters, a Legend Item and the chart data
            /// </summary>
            abstract member filter: item: ChartJs.LegendItem * data: ChartJs.ChartData -> bool
            /// <summary>
            /// Sorts the legend items
            /// </summary>
            abstract member sort: a: ChartJs.LegendItem * b: ChartJs.LegendItem * data: ChartJs.ChartData -> float
            /// <summary>
            /// Override point style for the legend. Only applies if usePointStyle is true
            /// </summary>
            abstract member pointStyle: ChartJs.PointStyle with get, set
            /// <summary>
            /// Text alignment
            /// </summary>
            abstract member textAlign: ChartJs.TextAlign option with get, set
            /// <summary>
            /// Label style will match corresponding point style (size is based on the minimum value between boxWidth and font.size).
            /// </summary>
            abstract member usePointStyle: bool with get, set
            /// <summary>
            /// Label borderRadius will match corresponding borderRadius.
            /// </summary>
            abstract member useBorderRadius: bool with get, set
            /// <summary>
            /// Override the borderRadius to use.
            /// </summary>
            abstract member borderRadius: float with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (boxWidth: float, boxHeight: float, color: ChartJs.Color, font: ChartJs.ScriptableAndScriptableOptions<LegendOptions.labels.font, ChartJs.ScriptableChartContext>, padding: float, pointStyleWidth: float, generateLabels: (ChartJs.dist.types.Chart -> ResizeArray<ChartJs.LegendItem>), filter: LegendOptions.labels.filter, sort: LegendOptions.labels.sort, pointStyle: ChartJs.PointStyle, usePointStyle: bool, useBorderRadius: bool, borderRadius: float, ?textAlign: ChartJs.TextAlign) : labels = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type title =
            /// <summary>
            /// Is the legend title displayed.
            /// </summary>
            abstract member display: bool with get, set
            /// <summary>
            /// Color of title
            /// </summary>
            abstract member color: ChartJs.Color with get, set
            /// <summary>
            /// see Fonts
            /// </summary>
            abstract member font: ChartJs.ScriptableAndScriptableOptions<LegendOptions.title.font, ChartJs.ScriptableChartContext> with get, set
            abstract member position: LegendOptions.title.position with get, set
            abstract member padding: U2<float, ChartJs.ChartArea> option with get, set
            /// <summary>
            /// The string title.
            /// </summary>
            abstract member text: string with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (display: bool, color: ChartJs.Color, font: ChartJs.ScriptableAndScriptableOptions<LegendOptions.title.font, ChartJs.ScriptableChartContext>, position: LegendOptions.title.position, text: string) : title = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (display: bool, color: ChartJs.Color, font: ChartJs.ScriptableAndScriptableOptions<LegendOptions.title.font, ChartJs.ScriptableChartContext>, position: LegendOptions.title.position, text: string, padding: float) : title = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (display: bool, color: ChartJs.Color, font: ChartJs.ScriptableAndScriptableOptions<LegendOptions.title.font, ChartJs.ScriptableChartContext>, position: LegendOptions.title.position, text: string, padding: ChartJs.ChartArea) : title = nativeOnly

        module labels =

            [<AllowNullLiteral>]
            [<Interface>]
            type font =
                /// <summary>
                /// Default font family for all text, follows CSS font-family options.
                /// </summary>
                abstract member family: string option with get, set
                /// <summary>
                /// Default font size (in px) for text. Does not apply to radialLinear scale point labels.
                /// </summary>
                abstract member size: float option with get, set
                /// <summary>
                /// Default font style. Does not apply to tooltip title or footer. Does not apply to chart title. Follows CSS font-style options (i.e. normal, italic, oblique, initial, inherit)
                /// </summary>
                abstract member style: LegendOptions.labels.font.Partial.style option with get, set
                /// <summary>
                /// Default font weight (boldness). (see MDN).
                /// </summary>
                abstract member weight: LegendOptions.labels.font.Partial.weight option with get, set
                /// <summary>
                /// Height of an individual line of text (see MDN).
                /// </summary>
                abstract member lineHeight: U2<float, string> option with get, set

            type filter =
                delegate of item: ChartJs.LegendItem * data: ChartJs.ChartData -> bool

            type sort =
                delegate of a: ChartJs.LegendItem * b: ChartJs.LegendItem * data: ChartJs.ChartData -> float

            module font =

                module Partial =

                    [<RequireQualifiedAccess>]
                    [<StringEnum(CaseRules.None)>]
                    type style =
                        | normal
                        | italic
                        | oblique
                        | initial
                        | ``inherit``

                    [<RequireQualifiedAccess>]
                    [<Erase(CaseRules.None)>]
                    type weight =
                        | normal
                        | bold
                        | lighter
                        | bolder
                        | Case1 of float

                        [<Emit("$0")>]
                        static member op_Implicit(value: float) : weight = nativeOnly

                        [<Emit("$0")>]
                        static member op_ErasedCast(value: float) : weight = nativeOnly

        module title =

            [<AllowNullLiteral>]
            [<Interface>]
            type font =
                /// <summary>
                /// Default font family for all text, follows CSS font-family options.
                /// </summary>
                abstract member family: string option with get, set
                /// <summary>
                /// Default font size (in px) for text. Does not apply to radialLinear scale point labels.
                /// </summary>
                abstract member size: float option with get, set
                /// <summary>
                /// Default font style. Does not apply to tooltip title or footer. Does not apply to chart title. Follows CSS font-style options (i.e. normal, italic, oblique, initial, inherit)
                /// </summary>
                abstract member style: LegendOptions.title.font.Partial.style option with get, set
                /// <summary>
                /// Default font weight (boldness). (see MDN).
                /// </summary>
                abstract member weight: LegendOptions.title.font.Partial.weight option with get, set
                /// <summary>
                /// Height of an individual line of text (see MDN).
                /// </summary>
                abstract member lineHeight: U2<float, string> option with get, set

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type position =
                | center
                | start
                | ``end``

            module font =

                module Partial =

                    [<RequireQualifiedAccess>]
                    [<StringEnum(CaseRules.None)>]
                    type style =
                        | normal
                        | italic
                        | oblique
                        | initial
                        | ``inherit``

                    [<RequireQualifiedAccess>]
                    [<Erase(CaseRules.None)>]
                    type weight =
                        | normal
                        | bold
                        | lighter
                        | bolder
                        | Case1 of float

                        [<Emit("$0")>]
                        static member op_Implicit(value: float) : weight = nativeOnly

                        [<Emit("$0")>]
                        static member op_ErasedCast(value: float) : weight = nativeOnly

    module TitleOptions =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type position =
            | top
            | left
            | bottom
            | right

        [<AllowNullLiteral>]
        [<Interface>]
        type font =
            /// <summary>
            /// Default font family for all text, follows CSS font-family options.
            /// </summary>
            abstract member family: string option with get, set
            /// <summary>
            /// Default font size (in px) for text. Does not apply to radialLinear scale point labels.
            /// </summary>
            abstract member size: float option with get, set
            /// <summary>
            /// Default font style. Does not apply to tooltip title or footer. Does not apply to chart title. Follows CSS font-style options (i.e. normal, italic, oblique, initial, inherit)
            /// </summary>
            abstract member style: TitleOptions.font.Partial.style option with get, set
            /// <summary>
            /// Default font weight (boldness). (see MDN).
            /// </summary>
            abstract member weight: TitleOptions.font.Partial.weight option with get, set
            /// <summary>
            /// Height of an individual line of text (see MDN).
            /// </summary>
            abstract member lineHeight: U2<float, string> option with get, set

        module font =

            module Partial =

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type style =
                    | normal
                    | italic
                    | oblique
                    | initial
                    | ``inherit``

                [<RequireQualifiedAccess>]
                [<Erase(CaseRules.None)>]
                type weight =
                    | normal
                    | bold
                    | lighter
                    | bolder
                    | Case1 of float

                    [<Emit("$0")>]
                    static member op_Implicit(value: float) : weight = nativeOnly

                    [<Emit("$0")>]
                    static member op_ErasedCast(value: float) : weight = nativeOnly

        module padding =

            module U2 =

                [<AllowNullLiteral>]
                [<Interface>]
                type Case2 =
                    abstract member top: float with get, set
                    abstract member bottom: float with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (top: float, bottom: float) : Case2 = nativeOnly

    module TooltipModel =

        module body =

            [<AllowNullLiteral>]
            [<Interface>]
            type Item =
                abstract member before: ResizeArray<string> with get, set
                abstract member lines: ResizeArray<string> with get, set
                abstract member after: ResizeArray<string> with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (before: ResizeArray<string>, lines: ResizeArray<string>, after: ResizeArray<string>) : Item = nativeOnly

        module labelPointStyles =

            [<AllowNullLiteral>]
            [<Interface>]
            type Item =
                abstract member pointStyle: ChartJs.PointStyle with get, set
                abstract member rotation: float with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (pointStyle: ChartJs.PointStyle, rotation: float) : Item = nativeOnly

    module TooltipDatasetCallbacks =

        module labelPointStyle =

            module U2 =

                [<AllowNullLiteral>]
                [<Interface>]
                type Case1 =
                    abstract member pointStyle: ChartJs.PointStyle with get, set
                    abstract member rotation: float with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (pointStyle: ChartJs.PointStyle, rotation: float) : Case1 = nativeOnly

    module TooltipCallbacks =

        module labelPointStyle =

            module U2 =

                [<AllowNullLiteral>]
                [<Interface>]
                type Case1 =
                    abstract member pointStyle: ChartJs.PointStyle with get, set
                    abstract member rotation: float with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (pointStyle: ChartJs.PointStyle, rotation: float) : Case1 = nativeOnly

    module ExtendedPlugin =

        type beforeTooltipDraw =
            delegate of chart: ChartJs.dist.types.Chart * args: ExtendedPlugin.beforeTooltipDraw.args<obj> * options: obj -> U2<bool, unit>

        type afterTooltipDraw =
            delegate of chart: ChartJs.dist.types.Chart * args: ExtendedPlugin.afterTooltipDraw.args<obj> * options: obj -> unit

        module beforeTooltipDraw =

            [<AllowNullLiteral>]
            [<Interface>]
            type args<'Model> =
                abstract member tooltip: 'Model with get, set
                abstract member cancelable: bool with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (tooltip: 'Model, cancelable: bool) : args<'Model> = nativeOnly

        module afterTooltipDraw =

            [<AllowNullLiteral>]
            [<Interface>]
            type args<'Model> =
                abstract member tooltip: 'Model with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (tooltip: 'Model) : args<'Model> = nativeOnly

    module TooltipOptions =

        type itemSort<'TType> =
            delegate of a: ChartJs.TooltipItem<'TType> * b: ChartJs.TooltipItem<'TType> * data: ChartJs.ChartData -> float

        type filter<'TType> =
            delegate of e: ChartJs.TooltipItem<'TType> * index: float * array: ResizeArray<ChartJs.TooltipItem<'TType>> * data: ChartJs.ChartData -> bool

        [<AllowNullLiteral>]
        [<Interface>]
        type titleFont =
            /// <summary>
            /// Default font family for all text, follows CSS font-family options.
            /// </summary>
            abstract member family: string option with get, set
            /// <summary>
            /// Default font size (in px) for text. Does not apply to radialLinear scale point labels.
            /// </summary>
            abstract member size: float option with get, set
            /// <summary>
            /// Default font style. Does not apply to tooltip title or footer. Does not apply to chart title. Follows CSS font-style options (i.e. normal, italic, oblique, initial, inherit)
            /// </summary>
            abstract member style: TooltipOptions.titleFont.Partial.style option with get, set
            /// <summary>
            /// Default font weight (boldness). (see MDN).
            /// </summary>
            abstract member weight: TooltipOptions.titleFont.Partial.weight option with get, set
            /// <summary>
            /// Height of an individual line of text (see MDN).
            /// </summary>
            abstract member lineHeight: U2<float, string> option with get, set

        [<AllowNullLiteral>]
        [<Interface>]
        type bodyFont =
            /// <summary>
            /// Default font family for all text, follows CSS font-family options.
            /// </summary>
            abstract member family: string option with get, set
            /// <summary>
            /// Default font size (in px) for text. Does not apply to radialLinear scale point labels.
            /// </summary>
            abstract member size: float option with get, set
            /// <summary>
            /// Default font style. Does not apply to tooltip title or footer. Does not apply to chart title. Follows CSS font-style options (i.e. normal, italic, oblique, initial, inherit)
            /// </summary>
            abstract member style: TooltipOptions.bodyFont.Partial.style option with get, set
            /// <summary>
            /// Default font weight (boldness). (see MDN).
            /// </summary>
            abstract member weight: TooltipOptions.bodyFont.Partial.weight option with get, set
            /// <summary>
            /// Height of an individual line of text (see MDN).
            /// </summary>
            abstract member lineHeight: U2<float, string> option with get, set

        [<AllowNullLiteral>]
        [<Interface>]
        type footerFont =
            /// <summary>
            /// Default font family for all text, follows CSS font-family options.
            /// </summary>
            abstract member family: string option with get, set
            /// <summary>
            /// Default font size (in px) for text. Does not apply to radialLinear scale point labels.
            /// </summary>
            abstract member size: float option with get, set
            /// <summary>
            /// Default font style. Does not apply to tooltip title or footer. Does not apply to chart title. Follows CSS font-style options (i.e. normal, italic, oblique, initial, inherit)
            /// </summary>
            abstract member style: TooltipOptions.footerFont.Partial.style option with get, set
            /// <summary>
            /// Default font weight (boldness). (see MDN).
            /// </summary>
            abstract member weight: TooltipOptions.footerFont.Partial.weight option with get, set
            /// <summary>
            /// Height of an individual line of text (see MDN).
            /// </summary>
            abstract member lineHeight: U2<float, string> option with get, set

        module external =

            [<AllowNullLiteral>]
            [<Interface>]
            type args<'TType> =
                abstract member chart: ChartJs.dist.types.Chart with get, set
                abstract member tooltip: ChartJs.TooltipModel<'TType> with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (chart: ChartJs.dist.types.Chart, tooltip: ChartJs.TooltipModel<'TType>) : args<'TType> = nativeOnly

        module titleFont =

            module Partial =

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type style =
                    | normal
                    | italic
                    | oblique
                    | initial
                    | ``inherit``

                [<RequireQualifiedAccess>]
                [<Erase(CaseRules.None)>]
                type weight =
                    | normal
                    | bold
                    | lighter
                    | bolder
                    | Case1 of float

                    [<Emit("$0")>]
                    static member op_Implicit(value: float) : weight = nativeOnly

                    [<Emit("$0")>]
                    static member op_ErasedCast(value: float) : weight = nativeOnly

        module bodyFont =

            module Partial =

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type style =
                    | normal
                    | italic
                    | oblique
                    | initial
                    | ``inherit``

                [<RequireQualifiedAccess>]
                [<Erase(CaseRules.None)>]
                type weight =
                    | normal
                    | bold
                    | lighter
                    | bolder
                    | Case1 of float

                    [<Emit("$0")>]
                    static member op_Implicit(value: float) : weight = nativeOnly

                    [<Emit("$0")>]
                    static member op_ErasedCast(value: float) : weight = nativeOnly

        module footerFont =

            module Partial =

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type style =
                    | normal
                    | italic
                    | oblique
                    | initial
                    | ``inherit``

                [<RequireQualifiedAccess>]
                [<Erase(CaseRules.None)>]
                type weight =
                    | normal
                    | bold
                    | lighter
                    | bolder
                    | Case1 of float

                    [<Emit("$0")>]
                    static member op_Implicit(value: float) : weight = nativeOnly

                    [<Emit("$0")>]
                    static member op_ErasedCast(value: float) : weight = nativeOnly

        module animation =

            module U2 =

                [<AllowNullLiteral>]
                [<Interface>]
                type Case1<'TType> =
                    /// <summary>
                    /// The number of milliseconds an animation takes.
                    /// </summary>
                    abstract member duration: ChartJs.Scriptable<float, ChartJs.ScriptableContext<'TType>> option with get, set
                    /// <summary>
                    /// Easing function to use
                    /// </summary>
                    abstract member easing: ChartJs.Scriptable<TooltipOptions.animation.U2.Case1.easing, ChartJs.ScriptableContext<'TType>> option with get, set
                    /// <summary>
                    /// Delay before starting the animations.
                    /// </summary>
                    abstract member delay: ChartJs.Scriptable<float, ChartJs.ScriptableContext<'TType>> option with get, set
                    /// <summary>
                    /// If set to true, the animations loop endlessly.
                    /// </summary>
                    abstract member loop: ChartJs.Scriptable<bool, ChartJs.ScriptableContext<'TType>> option with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (?duration: ChartJs.Scriptable<float, ChartJs.ScriptableContext<'TType>>, ?easing: ChartJs.Scriptable<TooltipOptions.animation.U2.Case1.easing, ChartJs.ScriptableContext<'TType>>, ?delay: ChartJs.Scriptable<float, ChartJs.ScriptableContext<'TType>>, ?loop: ChartJs.Scriptable<bool, ChartJs.ScriptableContext<'TType>>) : Case1<'TType> = nativeOnly

                module Case1 =

                    [<RequireQualifiedAccess>]
                    [<StringEnum(CaseRules.None)>]
                    type easing =
                        | linear
                        | easeInQuad
                        | easeOutQuad
                        | easeInOutQuad
                        | easeInCubic
                        | easeOutCubic
                        | easeInOutCubic
                        | easeInQuart
                        | easeOutQuart
                        | easeInOutQuart
                        | easeInQuint
                        | easeOutQuint
                        | easeInOutQuint
                        | easeInSine
                        | easeOutSine
                        | easeInOutSine
                        | easeInExpo
                        | easeOutExpo
                        | easeInOutExpo
                        | easeInCirc
                        | easeOutCirc
                        | easeInOutCirc
                        | easeInElastic
                        | easeOutElastic
                        | easeInOutElastic
                        | easeInBack
                        | easeOutBack
                        | easeInOutBack
                        | easeInBounce
                        | easeOutBounce
                        | easeInOutBounce

    module TickOptions =

        type callback =
            delegate of tickValue: U2<float, string> * index: float * ticks: ResizeArray<ChartJs.Tick> -> U4<string, ResizeArray<string>, float, ResizeArray<float>> option

        [<AllowNullLiteral>]
        [<Interface>]
        type font =
            /// <summary>
            /// Default font family for all text, follows CSS font-family options.
            /// </summary>
            abstract member family: string option with get, set
            /// <summary>
            /// Default font size (in px) for text. Does not apply to radialLinear scale point labels.
            /// </summary>
            abstract member size: float option with get, set
            /// <summary>
            /// Default font style. Does not apply to tooltip title or footer. Does not apply to chart title. Follows CSS font-style options (i.e. normal, italic, oblique, initial, inherit)
            /// </summary>
            abstract member style: TickOptions.font.Partial.style option with get, set
            /// <summary>
            /// Default font weight (boldness). (see MDN).
            /// </summary>
            abstract member weight: TickOptions.font.Partial.weight option with get, set
            /// <summary>
            /// Height of an individual line of text (see MDN).
            /// </summary>
            abstract member lineHeight: U2<float, string> option with get, set

        [<AllowNullLiteral>]
        [<Interface>]
        type major =
            /// <summary>
            /// If true, major ticks are generated. A major tick will affect autoskipping and major will be defined on ticks in the scriptable options context.
            /// </summary>
            abstract member enabled: bool with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (enabled: bool) : major = nativeOnly

        module font =

            module Partial =

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type style =
                    | normal
                    | italic
                    | oblique
                    | initial
                    | ``inherit``

                [<RequireQualifiedAccess>]
                [<Erase(CaseRules.None)>]
                type weight =
                    | normal
                    | bold
                    | lighter
                    | bolder
                    | Case1 of float

                    [<Emit("$0")>]
                    static member op_Implicit(value: float) : weight = nativeOnly

                    [<Emit("$0")>]
                    static member op_ErasedCast(value: float) : weight = nativeOnly

    module CartesianTickOptions =

        type callback =
            delegate of tickValue: U2<float, string> * index: float * ticks: ResizeArray<ChartJs.Tick> -> U4<string, ResizeArray<string>, float, ResizeArray<float>> option

        [<AllowNullLiteral>]
        [<Interface>]
        type font =
            /// <summary>
            /// Default font family for all text, follows CSS font-family options.
            /// </summary>
            abstract member family: string option with get, set
            /// <summary>
            /// Default font size (in px) for text. Does not apply to radialLinear scale point labels.
            /// </summary>
            abstract member size: float option with get, set
            /// <summary>
            /// Default font style. Does not apply to tooltip title or footer. Does not apply to chart title. Follows CSS font-style options (i.e. normal, italic, oblique, initial, inherit)
            /// </summary>
            abstract member style: CartesianTickOptions.font.Partial.style option with get, set
            /// <summary>
            /// Default font weight (boldness). (see MDN).
            /// </summary>
            abstract member weight: CartesianTickOptions.font.Partial.weight option with get, set
            /// <summary>
            /// Height of an individual line of text (see MDN).
            /// </summary>
            abstract member lineHeight: U2<float, string> option with get, set

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type align =
            | start
            | center
            | ``end``
            | inner

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type crossAlign =
            | near
            | center
            | far

        module font =

            module Partial =

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type style =
                    | normal
                    | italic
                    | oblique
                    | initial
                    | ``inherit``

                [<RequireQualifiedAccess>]
                [<Erase(CaseRules.None)>]
                type weight =
                    | normal
                    | bold
                    | lighter
                    | bolder
                    | Case1 of float

                    [<Emit("$0")>]
                    static member op_Implicit(value: float) : weight = nativeOnly

                    [<Emit("$0")>]
                    static member op_ErasedCast(value: float) : weight = nativeOnly

    module ScriptableCartesianScaleContext =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type scale =
            | linear
            | logarithmic
            | category
            | time
            | timeseries

    module CartesianScaleOptions =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type bounds =
            | ticks
            | data

        [<RequireQualifiedAccess>]
        [<Erase(CaseRules.None)>]
        type position =
            | left
            | top
            | right
            | bottom
            | center
            | Case1 of CartesianScaleOptions.position.Cases.Case1

            [<Emit("$0")>]
            static member op_Implicit(value: CartesianScaleOptions.position.Cases.Case1) : position = nativeOnly

            [<Emit("$0")>]
            static member op_ErasedCast(value: CartesianScaleOptions.position.Cases.Case1) : position = nativeOnly

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type axis =
            | x
            | y
            | r

        [<AllowNullLiteral>]
        [<Interface>]
        type grid =
            abstract member display: bool option with get, set
            abstract member circular: bool option with get, set
            abstract member color: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableScaleContext> option with get, set
            abstract member lineWidth: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableScaleContext> option with get, set
            abstract member drawOnChartArea: bool option with get, set
            abstract member drawTicks: bool option with get, set
            abstract member tickBorderDash: ChartJs.Scriptable<ResizeArray<float>, ChartJs.ScriptableScaleContext> option with get, set
            abstract member tickBorderDashOffset: ChartJs.Scriptable<float, ChartJs.ScriptableScaleContext> option with get, set
            abstract member tickColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableScaleContext> option with get, set
            abstract member tickLength: float option with get, set
            abstract member tickWidth: float option with get, set
            abstract member offset: bool option with get, set
            abstract member z: float option with get, set

        [<AllowNullLiteral>]
        [<Interface>]
        type title =
            /// <summary>
            /// If true, displays the axis title.
            /// </summary>
            abstract member display: bool with get, set
            /// <summary>
            /// Alignment of the axis title.
            /// </summary>
            abstract member align: ChartJs.Align with get, set
            /// <summary>
            /// The text for the title, e.g. "# of People" or "Response Choices".
            /// </summary>
            abstract member text: U2<string, ResizeArray<string>> with get, set
            /// <summary>
            /// Color of the axis label.
            /// </summary>
            abstract member color: ChartJs.Color with get, set
            /// <summary>
            /// Information about the axis title font.
            /// </summary>
            abstract member font: ChartJs.ScriptableAndScriptableOptions<CartesianScaleOptions.title.font, ChartJs.ScriptableCartesianScaleContext> with get, set
            /// <summary>
            /// Padding to apply around scale labels.
            /// </summary>
            abstract member padding: U2<float, CartesianScaleOptions.title.padding.U2.Case2> with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (display: bool, align: ChartJs.Align, text: string, color: ChartJs.Color, font: ChartJs.ScriptableAndScriptableOptions<CartesianScaleOptions.title.font, ChartJs.ScriptableCartesianScaleContext>, padding: float) : title = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (display: bool, align: ChartJs.Align, text: string, color: ChartJs.Color, font: ChartJs.ScriptableAndScriptableOptions<CartesianScaleOptions.title.font, ChartJs.ScriptableCartesianScaleContext>, padding: CartesianScaleOptions.title.padding.U2.Case2) : title = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (display: bool, align: ChartJs.Align, text: ResizeArray<string>, color: ChartJs.Color, font: ChartJs.ScriptableAndScriptableOptions<CartesianScaleOptions.title.font, ChartJs.ScriptableCartesianScaleContext>, padding: float) : title = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (display: bool, align: ChartJs.Align, text: ResizeArray<string>, color: ChartJs.Color, font: ChartJs.ScriptableAndScriptableOptions<CartesianScaleOptions.title.font, ChartJs.ScriptableCartesianScaleContext>, padding: CartesianScaleOptions.title.padding.U2.Case2) : title = nativeOnly

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type stacked =
            | [<CompiledValue(true)>] True
            | [<CompiledValue(false)>] False
            | single

        module position =

            module Cases =

                [<AllowNullLiteral>]
                [<Interface>]
                type Case1 =
                    [<EmitIndexer>]
                    abstract member Item: scale: string -> float with get, set

        module title =

            [<AllowNullLiteral>]
            [<Interface>]
            type font =
                /// <summary>
                /// Default font family for all text, follows CSS font-family options.
                /// </summary>
                abstract member family: string option with get, set
                /// <summary>
                /// Default font size (in px) for text. Does not apply to radialLinear scale point labels.
                /// </summary>
                abstract member size: float option with get, set
                /// <summary>
                /// Default font style. Does not apply to tooltip title or footer. Does not apply to chart title. Follows CSS font-style options (i.e. normal, italic, oblique, initial, inherit)
                /// </summary>
                abstract member style: CartesianScaleOptions.title.font.Partial.style option with get, set
                /// <summary>
                /// Default font weight (boldness). (see MDN).
                /// </summary>
                abstract member weight: CartesianScaleOptions.title.font.Partial.weight option with get, set
                /// <summary>
                /// Height of an individual line of text (see MDN).
                /// </summary>
                abstract member lineHeight: U2<float, string> option with get, set

            module font =

                module Partial =

                    [<RequireQualifiedAccess>]
                    [<StringEnum(CaseRules.None)>]
                    type style =
                        | normal
                        | italic
                        | oblique
                        | initial
                        | ``inherit``

                    [<RequireQualifiedAccess>]
                    [<Erase(CaseRules.None)>]
                    type weight =
                        | normal
                        | bold
                        | lighter
                        | bolder
                        | Case1 of float

                        [<Emit("$0")>]
                        static member op_Implicit(value: float) : weight = nativeOnly

                        [<Emit("$0")>]
                        static member op_ErasedCast(value: float) : weight = nativeOnly

            module padding =

                module U2 =

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type Case2 =
                        /// <summary>
                        /// Padding on the (relative) top side of this axis label.
                        /// </summary>
                        abstract member top: float with get, set
                        /// <summary>
                        /// Padding on the (relative) bottom side of this axis label.
                        /// </summary>
                        abstract member bottom: float with get, set
                        /// <summary>
                        /// This is a shorthand for defining top/bottom to the same values.
                        /// </summary>
                        abstract member y: float with get, set
                        [<ParamObject; Emit("$0")>]
                        static member Create (top: float, bottom: float, y: float) : Case2 = nativeOnly

    module CategoryScaleOptions =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type bounds =
            | ticks
            | data

        [<RequireQualifiedAccess>]
        [<Erase(CaseRules.None)>]
        type position =
            | left
            | top
            | right
            | bottom
            | center
            | Case1 of CartesianScaleOptions.position.Cases.Case1

            [<Emit("$0")>]
            static member op_Implicit(value: CartesianScaleOptions.position.Cases.Case1) : position = nativeOnly

            [<Emit("$0")>]
            static member op_ErasedCast(value: CartesianScaleOptions.position.Cases.Case1) : position = nativeOnly

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type axis =
            | x
            | y
            | r

        [<AllowNullLiteral>]
        [<Interface>]
        type grid =
            abstract member display: bool option with get, set
            abstract member circular: bool option with get, set
            abstract member color: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableScaleContext> option with get, set
            abstract member lineWidth: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableScaleContext> option with get, set
            abstract member drawOnChartArea: bool option with get, set
            abstract member drawTicks: bool option with get, set
            abstract member tickBorderDash: ChartJs.Scriptable<ResizeArray<float>, ChartJs.ScriptableScaleContext> option with get, set
            abstract member tickBorderDashOffset: ChartJs.Scriptable<float, ChartJs.ScriptableScaleContext> option with get, set
            abstract member tickColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableScaleContext> option with get, set
            abstract member tickLength: float option with get, set
            abstract member tickWidth: float option with get, set
            abstract member offset: bool option with get, set
            abstract member z: float option with get, set

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type stacked =
            | [<CompiledValue(true)>] True
            | [<CompiledValue(false)>] False
            | single

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type display =
            | [<CompiledValue(true)>] True
            | [<CompiledValue(false)>] False
            | auto

    module LinearScaleOptions =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type bounds =
            | ticks
            | data

        [<RequireQualifiedAccess>]
        [<Erase(CaseRules.None)>]
        type position =
            | left
            | top
            | right
            | bottom
            | center
            | Case1 of CartesianScaleOptions.position.Cases.Case1

            [<Emit("$0")>]
            static member op_Implicit(value: CartesianScaleOptions.position.Cases.Case1) : position = nativeOnly

            [<Emit("$0")>]
            static member op_ErasedCast(value: CartesianScaleOptions.position.Cases.Case1) : position = nativeOnly

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type axis =
            | x
            | y
            | r

        [<AllowNullLiteral>]
        [<Interface>]
        type grid =
            abstract member display: bool option with get, set
            abstract member circular: bool option with get, set
            abstract member color: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableScaleContext> option with get, set
            abstract member lineWidth: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableScaleContext> option with get, set
            abstract member drawOnChartArea: bool option with get, set
            abstract member drawTicks: bool option with get, set
            abstract member tickBorderDash: ChartJs.Scriptable<ResizeArray<float>, ChartJs.ScriptableScaleContext> option with get, set
            abstract member tickBorderDashOffset: ChartJs.Scriptable<float, ChartJs.ScriptableScaleContext> option with get, set
            abstract member tickColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableScaleContext> option with get, set
            abstract member tickLength: float option with get, set
            abstract member tickWidth: float option with get, set
            abstract member offset: bool option with get, set
            abstract member z: float option with get, set

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type stacked =
            | [<CompiledValue(true)>] True
            | [<CompiledValue(false)>] False
            | single

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type display =
            | [<CompiledValue(true)>] True
            | [<CompiledValue(false)>] False
            | auto

    module LogarithmicScaleOptions =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type bounds =
            | ticks
            | data

        [<RequireQualifiedAccess>]
        [<Erase(CaseRules.None)>]
        type position =
            | left
            | top
            | right
            | bottom
            | center
            | Case1 of CartesianScaleOptions.position.Cases.Case1

            [<Emit("$0")>]
            static member op_Implicit(value: CartesianScaleOptions.position.Cases.Case1) : position = nativeOnly

            [<Emit("$0")>]
            static member op_ErasedCast(value: CartesianScaleOptions.position.Cases.Case1) : position = nativeOnly

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type axis =
            | x
            | y
            | r

        [<AllowNullLiteral>]
        [<Interface>]
        type grid =
            abstract member display: bool option with get, set
            abstract member circular: bool option with get, set
            abstract member color: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableScaleContext> option with get, set
            abstract member lineWidth: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableScaleContext> option with get, set
            abstract member drawOnChartArea: bool option with get, set
            abstract member drawTicks: bool option with get, set
            abstract member tickBorderDash: ChartJs.Scriptable<ResizeArray<float>, ChartJs.ScriptableScaleContext> option with get, set
            abstract member tickBorderDashOffset: ChartJs.Scriptable<float, ChartJs.ScriptableScaleContext> option with get, set
            abstract member tickColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableScaleContext> option with get, set
            abstract member tickLength: float option with get, set
            abstract member tickWidth: float option with get, set
            abstract member offset: bool option with get, set
            abstract member z: float option with get, set

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type stacked =
            | [<CompiledValue(true)>] True
            | [<CompiledValue(false)>] False
            | single

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type display =
            | [<CompiledValue(true)>] True
            | [<CompiledValue(false)>] False
            | auto

    module TimeScaleTimeOptions =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type round =
            | [<CompiledValue(false)>] False
            | millisecond
            | second
            | minute
            | hour
            | day
            | week
            | month
            | quarter
            | year

        [<AllowNullLiteral>]
        [<Interface>]
        type displayFormats =
            [<EmitIndexer>]
            abstract member Item: key: string -> string with get, set

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type unit =
            | [<CompiledValue(false)>] False
            | millisecond
            | second
            | minute
            | hour
            | day
            | week
            | month
            | quarter
            | year

    module TimeScaleTickOptions =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type source =
            | labels
            | auto
            | data

    module TimeScaleOptions =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type bounds =
            | data
            | ticks

        [<RequireQualifiedAccess>]
        [<Erase(CaseRules.None)>]
        type position =
            | left
            | top
            | right
            | bottom
            | center
            | Case1 of CartesianScaleOptions.position.Cases.Case1

            [<Emit("$0")>]
            static member op_Implicit(value: CartesianScaleOptions.position.Cases.Case1) : position = nativeOnly

            [<Emit("$0")>]
            static member op_ErasedCast(value: CartesianScaleOptions.position.Cases.Case1) : position = nativeOnly

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type axis =
            | x
            | y
            | r

        [<AllowNullLiteral>]
        [<Interface>]
        type grid =
            abstract member display: bool option with get, set
            abstract member circular: bool option with get, set
            abstract member color: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableScaleContext> option with get, set
            abstract member lineWidth: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableScaleContext> option with get, set
            abstract member drawOnChartArea: bool option with get, set
            abstract member drawTicks: bool option with get, set
            abstract member tickBorderDash: ChartJs.Scriptable<ResizeArray<float>, ChartJs.ScriptableScaleContext> option with get, set
            abstract member tickBorderDashOffset: ChartJs.Scriptable<float, ChartJs.ScriptableScaleContext> option with get, set
            abstract member tickColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableScaleContext> option with get, set
            abstract member tickLength: float option with get, set
            abstract member tickWidth: float option with get, set
            abstract member offset: bool option with get, set
            abstract member z: float option with get, set

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type stacked =
            | [<CompiledValue(true)>] True
            | [<CompiledValue(false)>] False
            | single

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type display =
            | [<CompiledValue(true)>] True
            | [<CompiledValue(false)>] False
            | auto

        [<AllowNullLiteral>]
        [<Interface>]
        type adapters =
            abstract member date: obj with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (date: obj) : adapters = nativeOnly

    module RadialTickOptions =

        type callback =
            delegate of tickValue: U2<float, string> * index: float * ticks: ResizeArray<ChartJs.Tick> -> U4<string, ResizeArray<string>, float, ResizeArray<float>> option

        [<AllowNullLiteral>]
        [<Interface>]
        type font =
            /// <summary>
            /// Default font family for all text, follows CSS font-family options.
            /// </summary>
            abstract member family: string option with get, set
            /// <summary>
            /// Default font size (in px) for text. Does not apply to radialLinear scale point labels.
            /// </summary>
            abstract member size: float option with get, set
            /// <summary>
            /// Default font style. Does not apply to tooltip title or footer. Does not apply to chart title. Follows CSS font-style options (i.e. normal, italic, oblique, initial, inherit)
            /// </summary>
            abstract member style: RadialTickOptions.font.Partial.style option with get, set
            /// <summary>
            /// Default font weight (boldness). (see MDN).
            /// </summary>
            abstract member weight: RadialTickOptions.font.Partial.weight option with get, set
            /// <summary>
            /// Height of an individual line of text (see MDN).
            /// </summary>
            abstract member lineHeight: U2<float, string> option with get, set

        module font =

            module Partial =

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type style =
                    | normal
                    | italic
                    | oblique
                    | initial
                    | ``inherit``

                [<RequireQualifiedAccess>]
                [<Erase(CaseRules.None)>]
                type weight =
                    | normal
                    | bold
                    | lighter
                    | bolder
                    | Case1 of float

                    [<Emit("$0")>]
                    static member op_Implicit(value: float) : weight = nativeOnly

                    [<Emit("$0")>]
                    static member op_ErasedCast(value: float) : weight = nativeOnly

    module RadialLinearScaleOptions =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type display =
            | [<CompiledValue(true)>] True
            | [<CompiledValue(false)>] False
            | auto

        [<AllowNullLiteral>]
        [<Interface>]
        type angleLines =
            /// <summary>
            /// if true, angle lines are shown.
            /// </summary>
            abstract member display: bool with get, set
            /// <summary>
            /// Color of angled lines.
            /// </summary>
            abstract member color: ChartJs.Scriptable<ChartJs.Color, ChartJs.ScriptableScaleContext> with get, set
            /// <summary>
            /// Width of angled lines.
            /// </summary>
            abstract member lineWidth: ChartJs.Scriptable<float, ChartJs.ScriptableScaleContext> with get, set
            /// <summary>
            /// Length and spacing of dashes on angled lines. See MDN.
            /// </summary>
            abstract member borderDash: ChartJs.Scriptable<ResizeArray<float>, ChartJs.ScriptableScaleContext> with get, set
            /// <summary>
            /// Offset for line dashes. See MDN.
            /// </summary>
            abstract member borderDashOffset: ChartJs.Scriptable<float, ChartJs.ScriptableScaleContext> with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (display: bool, color: ChartJs.Scriptable<ChartJs.Color, ChartJs.ScriptableScaleContext>, lineWidth: ChartJs.Scriptable<float, ChartJs.ScriptableScaleContext>, borderDash: ChartJs.Scriptable<ResizeArray<float>, ChartJs.ScriptableScaleContext>, borderDashOffset: ChartJs.Scriptable<float, ChartJs.ScriptableScaleContext>) : angleLines = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type grid =
            abstract member display: bool option with get, set
            abstract member circular: bool option with get, set
            abstract member color: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableScaleContext> option with get, set
            abstract member lineWidth: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableScaleContext> option with get, set
            abstract member drawOnChartArea: bool option with get, set
            abstract member drawTicks: bool option with get, set
            abstract member tickBorderDash: ChartJs.Scriptable<ResizeArray<float>, ChartJs.ScriptableScaleContext> option with get, set
            abstract member tickBorderDashOffset: ChartJs.Scriptable<float, ChartJs.ScriptableScaleContext> option with get, set
            abstract member tickColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableScaleContext> option with get, set
            abstract member tickLength: float option with get, set
            abstract member tickWidth: float option with get, set
            abstract member offset: bool option with get, set
            abstract member z: float option with get, set

        [<AllowNullLiteral>]
        [<Interface>]
        type pointLabels =
            /// <summary>
            /// Background color of the point label.
            /// </summary>
            abstract member backdropColor: ChartJs.Scriptable<ChartJs.Color, ChartJs.ScriptableScalePointLabelContext> with get, set
            /// <summary>
            /// Padding of label backdrop.
            /// </summary>
            abstract member backdropPadding: ChartJs.Scriptable<U2<float, ChartJs.ChartArea>, ChartJs.ScriptableScalePointLabelContext> with get, set
            /// <summary>
            /// Border radius
            /// </summary>
            abstract member borderRadius: ChartJs.Scriptable<U2<float, ChartJs.BorderRadius>, ChartJs.ScriptableScalePointLabelContext> with get, set
            /// <summary>
            /// if true, point labels are shown. When <c>display: 'auto'</c>, the label is hidden if it overlaps with another label.
            /// </summary>
            abstract member display: RadialLinearScaleOptions.pointLabels.display with get, set
            /// <summary>
            /// Color of label
            /// </summary>
            abstract member color: ChartJs.Scriptable<ChartJs.Color, ChartJs.ScriptableScalePointLabelContext> with get, set
            abstract member font: ChartJs.ScriptableAndScriptableOptions<RadialLinearScaleOptions.pointLabels.font, ChartJs.ScriptableScalePointLabelContext> with get, set
            /// <summary>
            /// Callback function to transform data labels to point labels. The default implementation simply returns the current string.
            /// </summary>
            abstract member callback: RadialLinearScaleOptions.pointLabels.callback with get, set
            /// <summary>
            /// Padding around the pointLabels
            /// </summary>
            abstract member padding: ChartJs.Scriptable<float, ChartJs.ScriptableScalePointLabelContext> with get, set
            /// <summary>
            /// if true, point labels are centered.
            /// </summary>
            abstract member centerPointLabels: bool with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (backdropColor: ChartJs.Scriptable<ChartJs.Color, ChartJs.ScriptableScalePointLabelContext>, backdropPadding: ChartJs.Scriptable<U2<float, ChartJs.ChartArea>, ChartJs.ScriptableScalePointLabelContext>, borderRadius: ChartJs.Scriptable<U2<float, ChartJs.BorderRadius>, ChartJs.ScriptableScalePointLabelContext>, display: RadialLinearScaleOptions.pointLabels.display, color: ChartJs.Scriptable<ChartJs.Color, ChartJs.ScriptableScalePointLabelContext>, font: ChartJs.ScriptableAndScriptableOptions<RadialLinearScaleOptions.pointLabels.font, ChartJs.ScriptableScalePointLabelContext>, callback: RadialLinearScaleOptions.pointLabels.callback, padding: ChartJs.Scriptable<float, ChartJs.ScriptableScalePointLabelContext>, centerPointLabels: bool) : pointLabels = nativeOnly

        module pointLabels =

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type display =
                | [<CompiledValue(true)>] True
                | [<CompiledValue(false)>] False
                | auto

            [<AllowNullLiteral>]
            [<Interface>]
            type font =
                /// <summary>
                /// Default font family for all text, follows CSS font-family options.
                /// </summary>
                abstract member family: string option with get, set
                /// <summary>
                /// Default font size (in px) for text. Does not apply to radialLinear scale point labels.
                /// </summary>
                abstract member size: float option with get, set
                /// <summary>
                /// Default font style. Does not apply to tooltip title or footer. Does not apply to chart title. Follows CSS font-style options (i.e. normal, italic, oblique, initial, inherit)
                /// </summary>
                abstract member style: RadialLinearScaleOptions.pointLabels.font.Partial.style option with get, set
                /// <summary>
                /// Default font weight (boldness). (see MDN).
                /// </summary>
                abstract member weight: RadialLinearScaleOptions.pointLabels.font.Partial.weight option with get, set
                /// <summary>
                /// Height of an individual line of text (see MDN).
                /// </summary>
                abstract member lineHeight: U2<float, string> option with get, set

            type callback =
                delegate of label: string * index: float -> U4<string, ResizeArray<string>, float, ResizeArray<float>>

            module font =

                module Partial =

                    [<RequireQualifiedAccess>]
                    [<StringEnum(CaseRules.None)>]
                    type style =
                        | normal
                        | italic
                        | oblique
                        | initial
                        | ``inherit``

                    [<RequireQualifiedAccess>]
                    [<Erase(CaseRules.None)>]
                    type weight =
                        | normal
                        | bold
                        | lighter
                        | bolder
                        | Case1 of float

                        [<Emit("$0")>]
                        static member op_Implicit(value: float) : weight = nativeOnly

                        [<Emit("$0")>]
                        static member op_ErasedCast(value: float) : weight = nativeOnly

    module RadialLinearScale =

        [<AllowNullLiteral>]
        [<Interface>]
        type getPointPosition =
            abstract member x: float with get, set
            abstract member y: float with get, set
            abstract member angle: float with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (x: float, y: float, angle: float) : getPointPosition = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type getPointPositionForValue =
            abstract member x: float with get, set
            abstract member y: float with get, set
            abstract member angle: float with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (x: float, y: float, angle: float) : getPointPositionForValue = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type getBasePosition =
            abstract member x: float with get, set
            abstract member y: float with get, set
            abstract member angle: float with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (x: float, y: float, angle: float) : getBasePosition = nativeOnly

    module CartesianScaleTypeRegistry =

        [<AllowNullLiteral>]
        [<Interface>]
        type linear =
            abstract member options: ChartJs.LinearScaleOptions with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (options: ChartJs.LinearScaleOptions) : linear = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type logarithmic =
            abstract member options: ChartJs.LogarithmicScaleOptions with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (options: ChartJs.LogarithmicScaleOptions) : logarithmic = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type category =
            abstract member options: ChartJs.CategoryScaleOptions with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (options: ChartJs.CategoryScaleOptions) : category = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type time =
            abstract member options: ChartJs.TimeScaleOptions with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (options: ChartJs.TimeScaleOptions) : time = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type timeseries =
            abstract member options: ChartJs.TimeScaleOptions with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (options: ChartJs.TimeScaleOptions) : timeseries = nativeOnly

    module RadialScaleTypeRegistry =

        [<AllowNullLiteral>]
        [<Interface>]
        type radialLinear =
            abstract member options: ChartJs.RadialLinearScaleOptions with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (options: ChartJs.RadialLinearScaleOptions) : radialLinear = nativeOnly

    module CartesianParsedData =

        [<AllowNullLiteral>]
        [<Interface>]
        type _stacks =
            [<EmitIndexer>]
            abstract member Item: key: string -> CartesianParsedData._stacks.Item with get, set

        module _stacks =

            [<AllowNullLiteral>]
            [<Interface>]
            type Item =
                [<EmitIndexer>]
                abstract member Item: key: int -> float with get, set

    module BarParsedData =

        [<AllowNullLiteral>]
        [<Interface>]
        type _custom =
            abstract member barStart: float with get, set
            abstract member barEnd: float with get, set
            abstract member start: float with get, set
            abstract member ``end``: float with get, set
            abstract member min: float with get, set
            abstract member max: float with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (barStart: float, barEnd: float, start: float, ``end``: float, min: float, max: float) : _custom = nativeOnly

    module ChartTypeRegistry =

        [<AllowNullLiteral>]
        [<Interface>]
        type bar =
            abstract member chartOptions: ChartJs.BarControllerChartOptions with get, set
            abstract member datasetOptions: ChartJs.BarControllerDatasetOptions with get, set
            abstract member defaultDataPoint: U2<float, float * float> option with get, set
            abstract member metaExtensions: obj with get, set
            abstract member parsedDataType: ChartJs.BarParsedData with get, set
            abstract member scales: ChartTypeRegistry.bar.scales with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (chartOptions: ChartJs.BarControllerChartOptions, datasetOptions: ChartJs.BarControllerDatasetOptions, metaExtensions: obj, parsedDataType: ChartJs.BarParsedData, scales: ChartTypeRegistry.bar.scales) : bar = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (chartOptions: ChartJs.BarControllerChartOptions, datasetOptions: ChartJs.BarControllerDatasetOptions, metaExtensions: obj, parsedDataType: ChartJs.BarParsedData, scales: ChartTypeRegistry.bar.scales, defaultDataPoint: float) : bar = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (chartOptions: ChartJs.BarControllerChartOptions, datasetOptions: ChartJs.BarControllerDatasetOptions, metaExtensions: obj, parsedDataType: ChartJs.BarParsedData, scales: ChartTypeRegistry.bar.scales, defaultDataPoint: (float * float)) : bar = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type line =
            abstract member chartOptions: ChartJs.LineControllerChartOptions with get, set
            abstract member datasetOptions: ChartTypeRegistry.line.datasetOptions with get, set
            abstract member defaultDataPoint: U2<ChartJs.ScatterDataPoint, float> option with get, set
            abstract member metaExtensions: obj with get, set
            abstract member parsedDataType: ChartJs.CartesianParsedData with get, set
            abstract member scales: ChartTypeRegistry.line.scales with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (chartOptions: ChartJs.LineControllerChartOptions, datasetOptions: ChartTypeRegistry.line.datasetOptions, metaExtensions: obj, parsedDataType: ChartJs.CartesianParsedData, scales: ChartTypeRegistry.line.scales) : line = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (chartOptions: ChartJs.LineControllerChartOptions, datasetOptions: ChartTypeRegistry.line.datasetOptions, metaExtensions: obj, parsedDataType: ChartJs.CartesianParsedData, scales: ChartTypeRegistry.line.scales, defaultDataPoint: ChartJs.ScatterDataPoint) : line = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (chartOptions: ChartJs.LineControllerChartOptions, datasetOptions: ChartTypeRegistry.line.datasetOptions, metaExtensions: obj, parsedDataType: ChartJs.CartesianParsedData, scales: ChartTypeRegistry.line.scales, defaultDataPoint: float) : line = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type scatter =
            abstract member chartOptions: ChartJs.ScatterControllerChartOptions with get, set
            abstract member datasetOptions: ChartJs.ScatterControllerDatasetOptions with get, set
            abstract member defaultDataPoint: U2<ChartJs.ScatterDataPoint, float> option with get, set
            abstract member metaExtensions: obj with get, set
            abstract member parsedDataType: ChartJs.CartesianParsedData with get, set
            abstract member scales: ChartTypeRegistry.scatter.scales with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (chartOptions: ChartJs.ScatterControllerChartOptions, datasetOptions: ChartJs.ScatterControllerDatasetOptions, metaExtensions: obj, parsedDataType: ChartJs.CartesianParsedData, scales: ChartTypeRegistry.scatter.scales) : scatter = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (chartOptions: ChartJs.ScatterControllerChartOptions, datasetOptions: ChartJs.ScatterControllerDatasetOptions, metaExtensions: obj, parsedDataType: ChartJs.CartesianParsedData, scales: ChartTypeRegistry.scatter.scales, defaultDataPoint: ChartJs.ScatterDataPoint) : scatter = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (chartOptions: ChartJs.ScatterControllerChartOptions, datasetOptions: ChartJs.ScatterControllerDatasetOptions, metaExtensions: obj, parsedDataType: ChartJs.CartesianParsedData, scales: ChartTypeRegistry.scatter.scales, defaultDataPoint: float) : scatter = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type bubble =
            abstract member chartOptions: obj with get, set
            abstract member datasetOptions: ChartJs.BubbleControllerDatasetOptions with get, set
            abstract member defaultDataPoint: ChartJs.BubbleDataPoint with get, set
            abstract member metaExtensions: obj with get, set
            abstract member parsedDataType: ChartJs.BubbleParsedData with get, set
            abstract member scales: ChartTypeRegistry.bubble.scales with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (chartOptions: obj, datasetOptions: ChartJs.BubbleControllerDatasetOptions, defaultDataPoint: ChartJs.BubbleDataPoint, metaExtensions: obj, parsedDataType: ChartJs.BubbleParsedData, scales: ChartTypeRegistry.bubble.scales) : bubble = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type pie =
            abstract member chartOptions: ChartJs.PieControllerChartOptions with get, set
            abstract member datasetOptions: ChartJs.PieControllerDatasetOptions with get, set
            abstract member defaultDataPoint: ChartJs.PieDataPoint with get, set
            abstract member metaExtensions: ChartJs.PieMetaExtensions with get, set
            abstract member parsedDataType: float with get, set
            abstract member scales: ChartTypeRegistry.pie.scales with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (chartOptions: ChartJs.PieControllerChartOptions, datasetOptions: ChartJs.PieControllerDatasetOptions, defaultDataPoint: ChartJs.PieDataPoint, metaExtensions: ChartJs.PieMetaExtensions, parsedDataType: float, scales: ChartTypeRegistry.pie.scales) : pie = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type doughnut =
            abstract member chartOptions: ChartJs.DoughnutControllerChartOptions with get, set
            abstract member datasetOptions: ChartJs.DoughnutControllerDatasetOptions with get, set
            abstract member defaultDataPoint: ChartJs.DoughnutDataPoint with get, set
            abstract member metaExtensions: ChartJs.DoughnutMetaExtensions with get, set
            abstract member parsedDataType: float with get, set
            abstract member scales: ChartTypeRegistry.doughnut.scales with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (chartOptions: ChartJs.DoughnutControllerChartOptions, datasetOptions: ChartJs.DoughnutControllerDatasetOptions, defaultDataPoint: ChartJs.DoughnutDataPoint, metaExtensions: ChartJs.DoughnutMetaExtensions, parsedDataType: float, scales: ChartTypeRegistry.doughnut.scales) : doughnut = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type polarArea =
            abstract member chartOptions: ChartJs.PolarAreaControllerChartOptions with get, set
            abstract member datasetOptions: ChartJs.PolarAreaControllerDatasetOptions with get, set
            abstract member defaultDataPoint: float with get, set
            abstract member metaExtensions: obj with get, set
            abstract member parsedDataType: ChartJs.RadialParsedData with get, set
            abstract member scales: ChartTypeRegistry.polarArea.scales with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (chartOptions: ChartJs.PolarAreaControllerChartOptions, datasetOptions: ChartJs.PolarAreaControllerDatasetOptions, defaultDataPoint: float, metaExtensions: obj, parsedDataType: ChartJs.RadialParsedData, scales: ChartTypeRegistry.polarArea.scales) : polarArea = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type radar =
            abstract member chartOptions: ChartJs.RadarControllerChartOptions with get, set
            abstract member datasetOptions: ChartTypeRegistry.radar.datasetOptions with get, set
            abstract member defaultDataPoint: float option with get, set
            abstract member metaExtensions: obj with get, set
            abstract member parsedDataType: ChartJs.RadialParsedData with get, set
            abstract member scales: ChartTypeRegistry.radar.scales with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (chartOptions: ChartJs.RadarControllerChartOptions, datasetOptions: ChartTypeRegistry.radar.datasetOptions, metaExtensions: obj, parsedDataType: ChartJs.RadialParsedData, scales: ChartTypeRegistry.radar.scales, ?defaultDataPoint: float) : radar = nativeOnly

        module bar =

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type scales =
                | linear
                | logarithmic
                | category
                | time
                | timeseries

        module line =

            [<AllowNullLiteral>]
            [<Interface>]
            type datasetOptions =
                /// <summary>
                /// The ID of the x axis to plot this dataset on.
                /// </summary>
                abstract member xAxisID: string with get, set
                /// <summary>
                /// The ID of the y axis to plot this dataset on.
                /// </summary>
                abstract member yAxisID: string with get, set
                /// <summary>
                /// If true, lines will be drawn between points with no or null data. If false, points with NaN data will create a break in the line. Can also be a number specifying the maximum gap length to span. The unit of the value depends on the scale used.
                /// </summary>
                abstract member spanGaps: U2<bool, float> with get, set
                abstract member showLine: bool with get, set
                /// <summary>
                /// The base axis of the chart. 'x' for vertical charts and 'y' for horizontal charts.
                /// </summary>
                abstract member indexAxis: ChartTypeRegistry.line.datasetOptions.indexAxis with get, set
                /// <summary>
                /// How to clip relative to chartArea. Positive value allows overflow, negative value clips that many pixels inside chartArea. 0 = clip at chartArea. Clipping can also be configured per side: <c>clip: {left: 5, top: false, right: -2, bottom: 0}</c>
                /// </summary>
                abstract member clip: U3<float, ChartJs.ChartArea, bool> with get, set
                /// <summary>
                /// The label for the dataset which appears in the legend and tooltips.
                /// </summary>
                abstract member label: string with get, set
                /// <summary>
                /// The drawing order of dataset. Also affects order for stacking, tooltip and legend.
                /// </summary>
                abstract member order: float with get, set
                /// <summary>
                /// The ID of the group to which this dataset belongs to (when stacked, each group will be a separate stack).
                /// </summary>
                abstract member stack: string with get, set
                /// <summary>
                /// Configures the visibility state of the dataset. Set it to true, to hide the dataset from the chart.
                /// </summary>
                abstract member hidden: bool with get, set
                /// <summary>
                /// How to parse the dataset. The parsing can be disabled by specifying parsing: false at chart options or dataset. If parsing is disabled, data must be sorted and in the formats the associated chart type and scales use internally.
                /// </summary>
                abstract member parsing: U2<ParsingOptions.parsing.U2.Case1, bool> with get, set
                /// <summary>
                /// Chart.js is fastest if you provide data with indices that are unique, sorted, and consistent across datasets and provide the normalized: true option to let Chart.js know that you have done so.
                /// </summary>
                abstract member normalized: bool with get, set
                /// <summary>
                /// The fill color for points.
                /// </summary>
                abstract member pointBackgroundColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>> with get, set
                /// <summary>
                /// The border color for points.
                /// </summary>
                abstract member pointBorderColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>> with get, set
                /// <summary>
                /// The width of the point border in pixels.
                /// </summary>
                abstract member pointBorderWidth: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<string>> with get, set
                /// <summary>
                /// The pixel size of the non-displayed point that reacts to mouse events.
                /// </summary>
                abstract member pointHitRadius: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<string>> with get, set
                /// <summary>
                /// The radius of the point shape. If set to 0, the point is not rendered.
                /// </summary>
                abstract member pointRadius: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<string>> with get, set
                /// <summary>
                /// The rotation of the point in degrees.
                /// </summary>
                abstract member pointRotation: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<string>> with get, set
                /// <summary>
                /// Style of the point.
                /// </summary>
                abstract member pointStyle: ChartJs.ScriptableAndArray<ChartJs.PointStyle, ChartJs.ScriptableContext<string>> with get, set
                /// <summary>
                /// Point background color when hovered.
                /// </summary>
                abstract member pointHoverBackgroundColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>> with get, set
                /// <summary>
                /// Point border color when hovered.
                /// </summary>
                abstract member pointHoverBorderColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>> with get, set
                /// <summary>
                /// Border width of point when hovered.
                /// </summary>
                abstract member pointHoverBorderWidth: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<string>> with get, set
                /// <summary>
                /// The radius of the point when hovered.
                /// </summary>
                abstract member pointHoverRadius: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<string>> with get, set
                /// <summary>
                /// Line dash. See MDN.
                /// </summary>
                abstract member borderDash: ChartJs.Scriptable<ResizeArray<float>, ChartJs.ScriptableContext<string>> with get, set
                /// <summary>
                /// Line dash offset. See MDN.
                /// </summary>
                abstract member borderDashOffset: ChartJs.Scriptable<float, ChartJs.ScriptableContext<string>> with get, set
                /// <summary>
                /// Line join style. See MDN.
                /// </summary>
                abstract member borderJoinStyle: ChartJs.Scriptable<Glutinum.Web.CanvasLineJoin, ChartJs.ScriptableContext<string>> with get, set
                /// <summary>
                /// Line cap style. See MDN.
                /// </summary>
                abstract member borderCapStyle: ChartJs.Scriptable<Glutinum.Web.CanvasLineCap, ChartJs.ScriptableContext<string>> with get, set
                /// <summary>
                /// true to keep Bézier control inside the chart, false for no restriction.
                /// </summary>
                abstract member capBezierPoints: ChartJs.Scriptable<bool, ChartJs.ScriptableContext<string>> with get, set
                /// <summary>
                /// Interpolation mode to apply.
                /// </summary>
                abstract member cubicInterpolationMode: ChartJs.Scriptable<ChartTypeRegistry.line.datasetOptions.cubicInterpolationMode, ChartJs.ScriptableContext<string>> with get, set
                /// <summary>
                /// Bézier curve tension (0 for no Bézier curves).
                /// </summary>
                abstract member tension: ChartJs.Scriptable<float, ChartJs.ScriptableContext<string>> with get, set
                /// <summary>
                /// true to show the line as a stepped line (tension will be ignored).
                /// </summary>
                abstract member stepped: ChartJs.Scriptable<ChartTypeRegistry.line.datasetOptions.stepped, ChartJs.ScriptableContext<string>> with get, set
                abstract member fill: obj with get, set
                abstract member segment: ChartJs.Scriptable<ChartTypeRegistry.line.datasetOptions.segment, ChartJs.ScriptableContext<string>> with get, set
                abstract member borderWidth: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<string>> with get, set
                abstract member borderColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>> with get, set
                abstract member backgroundColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>> with get, set
                abstract member hoverBorderDash: ChartJs.Scriptable<ResizeArray<float>, ChartJs.ScriptableContext<string>> with get, set
                abstract member hoverBorderDashOffset: ChartJs.Scriptable<float, ChartJs.ScriptableContext<string>> with get, set
                abstract member hoverBorderCapStyle: ChartJs.Scriptable<Glutinum.Web.CanvasLineCap, ChartJs.ScriptableContext<string>> with get, set
                abstract member hoverBorderJoinStyle: ChartJs.Scriptable<Glutinum.Web.CanvasLineJoin, ChartJs.ScriptableContext<string>> with get, set
                abstract member hoverBorderWidth: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<string>> with get, set
                abstract member hoverBorderColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>> with get, set
                abstract member hoverBackgroundColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>> with get, set
                abstract member animation: U2<bool, obj> with get, set
                abstract member animations: ChartJs.AnimationsSpec<string> with get, set
                abstract member transitions: ChartJs.TransitionsSpec<string> with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (xAxisID: string, yAxisID: string, spanGaps: U2<bool, float>, showLine: bool, indexAxis: ChartTypeRegistry.line.datasetOptions.indexAxis, clip: U3<float, ChartJs.ChartArea, bool>, label: string, order: float, stack: string, hidden: bool, parsing: U2<ParsingOptions.parsing.U2.Case1, bool>, normalized: bool, pointBackgroundColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, pointBorderColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, pointBorderWidth: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<string>>, pointHitRadius: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<string>>, pointRadius: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<string>>, pointRotation: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<string>>, pointStyle: ChartJs.ScriptableAndArray<ChartJs.PointStyle, ChartJs.ScriptableContext<string>>, pointHoverBackgroundColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, pointHoverBorderColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, pointHoverBorderWidth: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<string>>, pointHoverRadius: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<string>>, borderDash: ChartJs.Scriptable<ResizeArray<float>, ChartJs.ScriptableContext<string>>, borderDashOffset: ChartJs.Scriptable<float, ChartJs.ScriptableContext<string>>, borderJoinStyle: ChartJs.Scriptable<Glutinum.Web.CanvasLineJoin, ChartJs.ScriptableContext<string>>, borderCapStyle: ChartJs.Scriptable<Glutinum.Web.CanvasLineCap, ChartJs.ScriptableContext<string>>, capBezierPoints: ChartJs.Scriptable<bool, ChartJs.ScriptableContext<string>>, cubicInterpolationMode: ChartJs.Scriptable<ChartTypeRegistry.line.datasetOptions.cubicInterpolationMode, ChartJs.ScriptableContext<string>>, tension: ChartJs.Scriptable<float, ChartJs.ScriptableContext<string>>, stepped: ChartJs.Scriptable<ChartTypeRegistry.line.datasetOptions.stepped, ChartJs.ScriptableContext<string>>, fill: obj, segment: ChartJs.Scriptable<ChartTypeRegistry.line.datasetOptions.segment, ChartJs.ScriptableContext<string>>, borderWidth: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<string>>, borderColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, backgroundColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, hoverBorderDash: ChartJs.Scriptable<ResizeArray<float>, ChartJs.ScriptableContext<string>>, hoverBorderDashOffset: ChartJs.Scriptable<float, ChartJs.ScriptableContext<string>>, hoverBorderCapStyle: ChartJs.Scriptable<Glutinum.Web.CanvasLineCap, ChartJs.ScriptableContext<string>>, hoverBorderJoinStyle: ChartJs.Scriptable<Glutinum.Web.CanvasLineJoin, ChartJs.ScriptableContext<string>>, hoverBorderWidth: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<string>>, hoverBorderColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, hoverBackgroundColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, animation: U2<bool, obj>, animations: ChartJs.AnimationsSpec<string>, transitions: ChartJs.TransitionsSpec<string>) : datasetOptions = nativeOnly

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type scales =
                | linear
                | logarithmic
                | category
                | time
                | timeseries

            module datasetOptions =

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type indexAxis =
                    | x
                    | y

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type cubicInterpolationMode =
                    | ``default``
                    | monotone

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type stepped =
                    | [<CompiledValue(true)>] True
                    | [<CompiledValue(false)>] False
                    | middle
                    | before
                    | after

                [<AllowNullLiteral>]
                [<Interface>]
                type segment =
                    abstract member backgroundColor: ChartJs.Scriptable<ChartJs.Color option, ChartJs.ScriptableLineSegmentContext> with get, set
                    abstract member borderColor: ChartJs.Scriptable<ChartJs.Color option, ChartJs.ScriptableLineSegmentContext> with get, set
                    abstract member borderCapStyle: ChartJs.Scriptable<Glutinum.Web.CanvasLineCap option, ChartJs.ScriptableLineSegmentContext> with get, set
                    abstract member borderDash: ChartJs.Scriptable<ResizeArray<float> option, ChartJs.ScriptableLineSegmentContext> with get, set
                    abstract member borderDashOffset: ChartJs.Scriptable<float option, ChartJs.ScriptableLineSegmentContext> with get, set
                    abstract member borderJoinStyle: ChartJs.Scriptable<Glutinum.Web.CanvasLineJoin option, ChartJs.ScriptableLineSegmentContext> with get, set
                    abstract member borderWidth: ChartJs.Scriptable<float option, ChartJs.ScriptableLineSegmentContext> with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (backgroundColor: ChartJs.Scriptable<ChartJs.Color option, ChartJs.ScriptableLineSegmentContext>, borderColor: ChartJs.Scriptable<ChartJs.Color option, ChartJs.ScriptableLineSegmentContext>, borderCapStyle: ChartJs.Scriptable<Glutinum.Web.CanvasLineCap option, ChartJs.ScriptableLineSegmentContext>, borderDash: ChartJs.Scriptable<ResizeArray<float> option, ChartJs.ScriptableLineSegmentContext>, borderDashOffset: ChartJs.Scriptable<float option, ChartJs.ScriptableLineSegmentContext>, borderJoinStyle: ChartJs.Scriptable<Glutinum.Web.CanvasLineJoin option, ChartJs.ScriptableLineSegmentContext>, borderWidth: ChartJs.Scriptable<float option, ChartJs.ScriptableLineSegmentContext>) : segment = nativeOnly

        module scatter =

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type scales =
                | linear
                | logarithmic
                | category
                | time
                | timeseries

        module bubble =

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type scales =
                | linear
                | logarithmic
                | category
                | time
                | timeseries

        module pie =

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type scales =
                | linear
                | logarithmic
                | category
                | time
                | timeseries

        module doughnut =

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type scales =
                | linear
                | logarithmic
                | category
                | time
                | timeseries

        module polarArea =

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type scales =
                | radialLinear

        module radar =

            [<AllowNullLiteral>]
            [<Interface>]
            type datasetOptions =
                /// <summary>
                /// The ID of the x axis to plot this dataset on.
                /// </summary>
                abstract member xAxisID: string with get, set
                /// <summary>
                /// The ID of the y axis to plot this dataset on.
                /// </summary>
                abstract member yAxisID: string with get, set
                /// <summary>
                /// If true, lines will be drawn between points with no or null data. If false, points with NaN data will create a break in the line. Can also be a number specifying the maximum gap length to span. The unit of the value depends on the scale used.
                /// </summary>
                abstract member spanGaps: U2<bool, float> with get, set
                /// <summary>
                /// If false, the line is not drawn for this dataset.
                /// </summary>
                abstract member showLine: bool with get, set
                /// <summary>
                /// The base axis of the chart. 'x' for vertical charts and 'y' for horizontal charts.
                /// </summary>
                abstract member indexAxis: ChartTypeRegistry.radar.datasetOptions.indexAxis with get, set
                /// <summary>
                /// How to clip relative to chartArea. Positive value allows overflow, negative value clips that many pixels inside chartArea. 0 = clip at chartArea. Clipping can also be configured per side: <c>clip: {left: 5, top: false, right: -2, bottom: 0}</c>
                /// </summary>
                abstract member clip: U3<float, ChartJs.ChartArea, bool> with get, set
                /// <summary>
                /// The label for the dataset which appears in the legend and tooltips.
                /// </summary>
                abstract member label: string with get, set
                /// <summary>
                /// The drawing order of dataset. Also affects order for stacking, tooltip and legend.
                /// </summary>
                abstract member order: float with get, set
                /// <summary>
                /// The ID of the group to which this dataset belongs to (when stacked, each group will be a separate stack).
                /// </summary>
                abstract member stack: string with get, set
                /// <summary>
                /// Configures the visibility state of the dataset. Set it to true, to hide the dataset from the chart.
                /// </summary>
                abstract member hidden: bool with get, set
                /// <summary>
                /// How to parse the dataset. The parsing can be disabled by specifying parsing: false at chart options or dataset. If parsing is disabled, data must be sorted and in the formats the associated chart type and scales use internally.
                /// </summary>
                abstract member parsing: U2<ParsingOptions.parsing.U2.Case1, bool> with get, set
                /// <summary>
                /// Chart.js is fastest if you provide data with indices that are unique, sorted, and consistent across datasets and provide the normalized: true option to let Chart.js know that you have done so.
                /// </summary>
                abstract member normalized: bool with get, set
                /// <summary>
                /// Point radius
                /// </summary>
                abstract member radius: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<string>> with get, set
                /// <summary>
                /// Extra radius added to point radius for hit detection.
                /// </summary>
                abstract member hitRadius: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<string>> with get, set
                abstract member pointStyle: ChartJs.ScriptableAndArray<ChartJs.PointStyle, ChartJs.ScriptableContext<string>> with get, set
                /// <summary>
                /// Point rotation (in degrees).
                /// </summary>
                abstract member rotation: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<string>> with get, set
                /// <summary>
                /// Draw the active elements over the other elements of the dataset,
                /// </summary>
                abstract member drawActiveElementsOnTop: ChartJs.ScriptableAndArray<bool, ChartJs.ScriptableContext<string>> with get, set
                abstract member borderWidth: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<string>> with get, set
                abstract member borderColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>> with get, set
                abstract member backgroundColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>> with get, set
                /// <summary>
                /// Point radius when hovered.
                /// </summary>
                abstract member hoverRadius: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<string>> with get, set
                abstract member hoverBorderWidth: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<string>> with get, set
                abstract member hoverBorderColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>> with get, set
                abstract member hoverBackgroundColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>> with get, set
                /// <summary>
                /// The fill color for points.
                /// </summary>
                abstract member pointBackgroundColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>> with get, set
                /// <summary>
                /// The border color for points.
                /// </summary>
                abstract member pointBorderColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>> with get, set
                /// <summary>
                /// The width of the point border in pixels.
                /// </summary>
                abstract member pointBorderWidth: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<string>> with get, set
                /// <summary>
                /// The pixel size of the non-displayed point that reacts to mouse events.
                /// </summary>
                abstract member pointHitRadius: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<string>> with get, set
                /// <summary>
                /// The radius of the point shape. If set to 0, the point is not rendered.
                /// </summary>
                abstract member pointRadius: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<string>> with get, set
                /// <summary>
                /// The rotation of the point in degrees.
                /// </summary>
                abstract member pointRotation: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<string>> with get, set
                /// <summary>
                /// Point background color when hovered.
                /// </summary>
                abstract member pointHoverBackgroundColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>> with get, set
                /// <summary>
                /// Point border color when hovered.
                /// </summary>
                abstract member pointHoverBorderColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>> with get, set
                /// <summary>
                /// Border width of point when hovered.
                /// </summary>
                abstract member pointHoverBorderWidth: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<string>> with get, set
                /// <summary>
                /// The radius of the point when hovered.
                /// </summary>
                abstract member pointHoverRadius: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<string>> with get, set
                /// <summary>
                /// Line cap style. See MDN.
                /// </summary>
                abstract member borderCapStyle: ChartJs.ScriptableAndArray<Glutinum.Web.CanvasLineCap, ChartJs.ScriptableContext<string>> with get, set
                /// <summary>
                /// Line dash. See MDN.
                /// </summary>
                abstract member borderDash: ChartJs.ScriptableAndArray<ResizeArray<float>, ChartJs.ScriptableContext<string>> with get, set
                /// <summary>
                /// Line dash offset. See MDN.
                /// </summary>
                abstract member borderDashOffset: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<string>> with get, set
                /// <summary>
                /// Line join style. See MDN.
                /// </summary>
                abstract member borderJoinStyle: ChartJs.ScriptableAndArray<Glutinum.Web.CanvasLineJoin, ChartJs.ScriptableContext<string>> with get, set
                /// <summary>
                /// true to keep Bézier control inside the chart, false for no restriction.
                /// </summary>
                abstract member capBezierPoints: ChartJs.ScriptableAndArray<bool, ChartJs.ScriptableContext<string>> with get, set
                /// <summary>
                /// Interpolation mode to apply.
                /// </summary>
                abstract member cubicInterpolationMode: ChartJs.ScriptableAndArray<ChartTypeRegistry.radar.datasetOptions.cubicInterpolationMode, ChartJs.ScriptableContext<string>> with get, set
                /// <summary>
                /// Bézier curve tension (0 for no Bézier curves).
                /// </summary>
                abstract member tension: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<string>> with get, set
                /// <summary>
                /// true to show the line as a stepped line (tension will be ignored).
                /// </summary>
                abstract member stepped: ChartJs.ScriptableAndArray<ChartTypeRegistry.radar.datasetOptions.stepped, ChartJs.ScriptableContext<string>> with get, set
                abstract member fill: obj with get, set
                abstract member segment: ChartJs.ScriptableAndArray<ChartTypeRegistry.radar.datasetOptions.segment, ChartJs.ScriptableContext<string>> with get, set
                abstract member hoverBorderCapStyle: ChartJs.ScriptableAndArray<Glutinum.Web.CanvasLineCap, ChartJs.ScriptableContext<string>> with get, set
                abstract member hoverBorderDash: ChartJs.ScriptableAndArray<ResizeArray<float>, ChartJs.ScriptableContext<string>> with get, set
                abstract member hoverBorderDashOffset: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<string>> with get, set
                abstract member hoverBorderJoinStyle: ChartJs.ScriptableAndArray<Glutinum.Web.CanvasLineJoin, ChartJs.ScriptableContext<string>> with get, set
                abstract member animation: U2<bool, obj> with get, set
                abstract member animations: ChartJs.AnimationsSpec<string> with get, set
                abstract member transitions: ChartJs.TransitionsSpec<string> with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (xAxisID: string, yAxisID: string, spanGaps: U2<bool, float>, showLine: bool, indexAxis: ChartTypeRegistry.radar.datasetOptions.indexAxis, clip: U3<float, ChartJs.ChartArea, bool>, label: string, order: float, stack: string, hidden: bool, parsing: U2<ParsingOptions.parsing.U2.Case1, bool>, normalized: bool, radius: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<string>>, hitRadius: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<string>>, pointStyle: ChartJs.ScriptableAndArray<ChartJs.PointStyle, ChartJs.ScriptableContext<string>>, rotation: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<string>>, drawActiveElementsOnTop: ChartJs.ScriptableAndArray<bool, ChartJs.ScriptableContext<string>>, borderWidth: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<string>>, borderColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, backgroundColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, hoverRadius: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<string>>, hoverBorderWidth: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<string>>, hoverBorderColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, hoverBackgroundColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, pointBackgroundColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, pointBorderColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, pointBorderWidth: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<string>>, pointHitRadius: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<string>>, pointRadius: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<string>>, pointRotation: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<string>>, pointHoverBackgroundColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, pointHoverBorderColor: ChartJs.ScriptableAndArray<ChartJs.Color, ChartJs.ScriptableContext<string>>, pointHoverBorderWidth: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<string>>, pointHoverRadius: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<string>>, borderCapStyle: ChartJs.ScriptableAndArray<Glutinum.Web.CanvasLineCap, ChartJs.ScriptableContext<string>>, borderDash: ChartJs.ScriptableAndArray<ResizeArray<float>, ChartJs.ScriptableContext<string>>, borderDashOffset: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<string>>, borderJoinStyle: ChartJs.ScriptableAndArray<Glutinum.Web.CanvasLineJoin, ChartJs.ScriptableContext<string>>, capBezierPoints: ChartJs.ScriptableAndArray<bool, ChartJs.ScriptableContext<string>>, cubicInterpolationMode: ChartJs.ScriptableAndArray<ChartTypeRegistry.radar.datasetOptions.cubicInterpolationMode, ChartJs.ScriptableContext<string>>, tension: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<string>>, stepped: ChartJs.ScriptableAndArray<ChartTypeRegistry.radar.datasetOptions.stepped, ChartJs.ScriptableContext<string>>, fill: obj, segment: ChartJs.ScriptableAndArray<ChartTypeRegistry.radar.datasetOptions.segment, ChartJs.ScriptableContext<string>>, hoverBorderCapStyle: ChartJs.ScriptableAndArray<Glutinum.Web.CanvasLineCap, ChartJs.ScriptableContext<string>>, hoverBorderDash: ChartJs.ScriptableAndArray<ResizeArray<float>, ChartJs.ScriptableContext<string>>, hoverBorderDashOffset: ChartJs.ScriptableAndArray<float, ChartJs.ScriptableContext<string>>, hoverBorderJoinStyle: ChartJs.ScriptableAndArray<Glutinum.Web.CanvasLineJoin, ChartJs.ScriptableContext<string>>, animation: U2<bool, obj>, animations: ChartJs.AnimationsSpec<string>, transitions: ChartJs.TransitionsSpec<string>) : datasetOptions = nativeOnly

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type scales =
                | radialLinear

            module datasetOptions =

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type indexAxis =
                    | x
                    | y

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type cubicInterpolationMode =
                    | ``default``
                    | monotone

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type stepped =
                    | [<CompiledValue(true)>] True
                    | [<CompiledValue(false)>] False
                    | middle
                    | before
                    | after

                [<AllowNullLiteral>]
                [<Interface>]
                type segment =
                    abstract member backgroundColor: ChartJs.Scriptable<ChartJs.Color option, ChartJs.ScriptableLineSegmentContext> with get, set
                    abstract member borderColor: ChartJs.Scriptable<ChartJs.Color option, ChartJs.ScriptableLineSegmentContext> with get, set
                    abstract member borderCapStyle: ChartJs.Scriptable<Glutinum.Web.CanvasLineCap option, ChartJs.ScriptableLineSegmentContext> with get, set
                    abstract member borderDash: ChartJs.Scriptable<ResizeArray<float> option, ChartJs.ScriptableLineSegmentContext> with get, set
                    abstract member borderDashOffset: ChartJs.Scriptable<float option, ChartJs.ScriptableLineSegmentContext> with get, set
                    abstract member borderJoinStyle: ChartJs.Scriptable<Glutinum.Web.CanvasLineJoin option, ChartJs.ScriptableLineSegmentContext> with get, set
                    abstract member borderWidth: ChartJs.Scriptable<float option, ChartJs.ScriptableLineSegmentContext> with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (backgroundColor: ChartJs.Scriptable<ChartJs.Color option, ChartJs.ScriptableLineSegmentContext>, borderColor: ChartJs.Scriptable<ChartJs.Color option, ChartJs.ScriptableLineSegmentContext>, borderCapStyle: ChartJs.Scriptable<Glutinum.Web.CanvasLineCap option, ChartJs.ScriptableLineSegmentContext>, borderDash: ChartJs.Scriptable<ResizeArray<float> option, ChartJs.ScriptableLineSegmentContext>, borderDashOffset: ChartJs.Scriptable<float option, ChartJs.ScriptableLineSegmentContext>, borderJoinStyle: ChartJs.Scriptable<Glutinum.Web.CanvasLineJoin option, ChartJs.ScriptableLineSegmentContext>, borderWidth: ChartJs.Scriptable<float option, ChartJs.ScriptableLineSegmentContext>) : segment = nativeOnly

    module DatasetChartOptions =

        [<AllowNullLiteral>]
        [<Interface>]
        type Item =
            abstract member datasets: U6<ChartJs.LineControllerDatasetOptions, obj, ChartJs.BarControllerDatasetOptions, ChartJs.BubbleControllerDatasetOptions, ChartJs.DoughnutControllerDatasetOptions, ChartJs.PolarAreaControllerDatasetOptions> with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (datasets: ChartJs.LineControllerDatasetOptions) : Item = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (datasets: obj) : Item = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (datasets: ChartJs.BarControllerDatasetOptions) : Item = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (datasets: ChartJs.BubbleControllerDatasetOptions) : Item = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (datasets: ChartJs.DoughnutControllerDatasetOptions) : Item = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (datasets: ChartJs.PolarAreaControllerDatasetOptions) : Item = nativeOnly

    module ScaleChartOptions =

        [<AllowNullLiteral>]
        [<Interface>]
        type scales =
            [<EmitIndexer>]
            abstract member Item: key: string -> ChartJs.ScaleOptionsByType<ScaleChartOptions.scales.Item> with get, set

        module scales =

            [<RequireQualifiedAccess>]
            [<Erase(CaseRules.None)>]
            type Item =
                | radialLinear
                | Case1 of obj

                [<Emit("$0")>]
                static member op_Implicit(value: obj) : Item = nativeOnly

                [<Emit("$0")>]
                static member op_ErasedCast(value: obj) : Item = nativeOnly

    module ChartDataset =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type indexAxis =
            | x
            | y

        module parsing =

            module U2 =

                [<AllowNullLiteral>]
                [<Interface>]
                type Case2 =
                    [<EmitIndexer>]
                    abstract member Item: key: string -> string with get, set

        module borderWidth =

            module U9 =

                type Case2 =
                    delegate of ctx: ChartJs.ScriptableContext<string> * options: ChartJs.AnyObject -> float option

                type Case3 =
                    delegate of ctx: ChartJs.ScriptableContext<string> * options: ChartJs.AnyObject -> float option

                type Case4 =
                    delegate of ctx: ChartJs.ScriptableContext<string> * options: ChartJs.AnyObject -> float option

                type Case5 =
                    delegate of ctx: ChartJs.ScriptableContext<string> * options: ChartJs.AnyObject -> U2<float, ChartDataset.borderWidth.U9.Case5.ReturnType.U2.Case2> option

                type Case6 =
                    delegate of ctx: ChartJs.ScriptableContext<string> * options: ChartJs.AnyObject -> float option

                [<AllowNullLiteral>]
                [<Interface>]
                type Case8 =
                    abstract member top: float option with get, set
                    abstract member right: float option with get, set
                    abstract member bottom: float option with get, set
                    abstract member left: float option with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (?top: float, ?right: float, ?bottom: float, ?left: float) : Case8 = nativeOnly

                module Case5 =

                    module ReturnType =

                        module U2 =

                            [<AllowNullLiteral>]
                            [<Interface>]
                            type Case2 =
                                abstract member top: float option with get, set
                                abstract member right: float option with get, set
                                abstract member bottom: float option with get, set
                                abstract member left: float option with get, set
                                [<ParamObject; Emit("$0")>]
                                static member Create (?top: float, ?right: float, ?bottom: float, ?left: float) : Case2 = nativeOnly

                module Case9 =

                    module U2 =

                        [<AllowNullLiteral>]
                        [<Interface>]
                        type Case2 =
                            abstract member top: float option with get, set
                            abstract member right: float option with get, set
                            abstract member bottom: float option with get, set
                            abstract member left: float option with get, set
                            [<ParamObject; Emit("$0")>]
                            static member Create (?top: float, ?right: float, ?bottom: float, ?left: float) : Case2 = nativeOnly

        module borderColor =

            module U9 =

                type Case2 =
                    delegate of ctx: ChartJs.ScriptableContext<string> * options: ChartJs.AnyObject -> ChartJs.Color option

                type Case3 =
                    delegate of ctx: ChartJs.ScriptableContext<string> * options: ChartJs.AnyObject -> ChartJs.Color option

                type Case4 =
                    delegate of ctx: ChartJs.ScriptableContext<string> * options: ChartJs.AnyObject -> ChartJs.Color option

                type Case5 =
                    delegate of ctx: ChartJs.ScriptableContext<string> * options: ChartJs.AnyObject -> ChartJs.Color option

                type Case6 =
                    delegate of ctx: ChartJs.ScriptableContext<string> * options: ChartJs.AnyObject -> ChartJs.Color option

        module backgroundColor =

            module U9 =

                type Case2 =
                    delegate of ctx: ChartJs.ScriptableContext<string> * options: ChartJs.AnyObject -> ChartJs.Color option

                type Case3 =
                    delegate of ctx: ChartJs.ScriptableContext<string> * options: ChartJs.AnyObject -> ChartJs.Color option

                type Case4 =
                    delegate of ctx: ChartJs.ScriptableContext<string> * options: ChartJs.AnyObject -> ChartJs.Color option

                type Case5 =
                    delegate of ctx: ChartJs.ScriptableContext<string> * options: ChartJs.AnyObject -> ChartJs.Color option

                type Case6 =
                    delegate of ctx: ChartJs.ScriptableContext<string> * options: ChartJs.AnyObject -> ChartJs.Color option

        module hoverBorderWidth =

            module U7 =

                type Case2 =
                    delegate of ctx: ChartJs.ScriptableContext<string> * options: ChartJs.AnyObject -> float option

                type Case3 =
                    delegate of ctx: ChartJs.ScriptableContext<string> * options: ChartJs.AnyObject -> float option

                type Case4 =
                    delegate of ctx: ChartJs.ScriptableContext<string> * options: ChartJs.AnyObject -> float option

                type Case5 =
                    delegate of ctx: ChartJs.ScriptableContext<string> * options: ChartJs.AnyObject -> float option

                type Case6 =
                    delegate of ctx: ChartJs.ScriptableContext<string> * options: ChartJs.AnyObject -> float option

        module hoverBorderColor =

            module U9 =

                type Case2 =
                    delegate of ctx: ChartJs.ScriptableContext<string> * options: ChartJs.AnyObject -> ChartJs.Color option

                type Case3 =
                    delegate of ctx: ChartJs.ScriptableContext<string> * options: ChartJs.AnyObject -> ChartJs.Color option

                type Case4 =
                    delegate of ctx: ChartJs.ScriptableContext<string> * options: ChartJs.AnyObject -> ChartJs.Color option

                type Case5 =
                    delegate of ctx: ChartJs.ScriptableContext<string> * options: ChartJs.AnyObject -> ChartJs.Color option

                type Case6 =
                    delegate of ctx: ChartJs.ScriptableContext<string> * options: ChartJs.AnyObject -> ChartJs.Color option

        module hoverBackgroundColor =

            module U9 =

                type Case2 =
                    delegate of ctx: ChartJs.ScriptableContext<string> * options: ChartJs.AnyObject -> ChartJs.Color option

                type Case3 =
                    delegate of ctx: ChartJs.ScriptableContext<string> * options: ChartJs.AnyObject -> ChartJs.Color option

                type Case4 =
                    delegate of ctx: ChartJs.ScriptableContext<string> * options: ChartJs.AnyObject -> ChartJs.Color option

                type Case5 =
                    delegate of ctx: ChartJs.ScriptableContext<string> * options: ChartJs.AnyObject -> ChartJs.Color option

                type Case6 =
                    delegate of ctx: ChartJs.ScriptableContext<string> * options: ChartJs.AnyObject -> ChartJs.Color option

    module ChartDatasetCustomTypesPerDataset =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type indexAxis =
            | x
            | y

        module parsing =

            module U2 =

                [<AllowNullLiteral>]
                [<Interface>]
                type Case2 =
                    [<EmitIndexer>]
                    abstract member Item: key: string -> string with get, set

        module borderWidth =

            module U9 =

                type Case2 =
                    delegate of ctx: ChartJs.ScriptableContext<string> * options: ChartJs.AnyObject -> float option

                type Case3 =
                    delegate of ctx: ChartJs.ScriptableContext<string> * options: ChartJs.AnyObject -> float option

                type Case4 =
                    delegate of ctx: ChartJs.ScriptableContext<string> * options: ChartJs.AnyObject -> float option

                type Case5 =
                    delegate of ctx: ChartJs.ScriptableContext<string> * options: ChartJs.AnyObject -> U2<float, ChartDatasetCustomTypesPerDataset.borderWidth.U9.Case5.ReturnType.U2.Case2> option

                type Case6 =
                    delegate of ctx: ChartJs.ScriptableContext<string> * options: ChartJs.AnyObject -> float option

                [<AllowNullLiteral>]
                [<Interface>]
                type Case8 =
                    abstract member top: float option with get, set
                    abstract member right: float option with get, set
                    abstract member bottom: float option with get, set
                    abstract member left: float option with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (?top: float, ?right: float, ?bottom: float, ?left: float) : Case8 = nativeOnly

                module Case5 =

                    module ReturnType =

                        module U2 =

                            [<AllowNullLiteral>]
                            [<Interface>]
                            type Case2 =
                                abstract member top: float option with get, set
                                abstract member right: float option with get, set
                                abstract member bottom: float option with get, set
                                abstract member left: float option with get, set
                                [<ParamObject; Emit("$0")>]
                                static member Create (?top: float, ?right: float, ?bottom: float, ?left: float) : Case2 = nativeOnly

                module Case9 =

                    module U2 =

                        [<AllowNullLiteral>]
                        [<Interface>]
                        type Case2 =
                            abstract member top: float option with get, set
                            abstract member right: float option with get, set
                            abstract member bottom: float option with get, set
                            abstract member left: float option with get, set
                            [<ParamObject; Emit("$0")>]
                            static member Create (?top: float, ?right: float, ?bottom: float, ?left: float) : Case2 = nativeOnly

        module borderColor =

            module U9 =

                type Case2 =
                    delegate of ctx: ChartJs.ScriptableContext<string> * options: ChartJs.AnyObject -> ChartJs.Color option

                type Case3 =
                    delegate of ctx: ChartJs.ScriptableContext<string> * options: ChartJs.AnyObject -> ChartJs.Color option

                type Case4 =
                    delegate of ctx: ChartJs.ScriptableContext<string> * options: ChartJs.AnyObject -> ChartJs.Color option

                type Case5 =
                    delegate of ctx: ChartJs.ScriptableContext<string> * options: ChartJs.AnyObject -> ChartJs.Color option

                type Case6 =
                    delegate of ctx: ChartJs.ScriptableContext<string> * options: ChartJs.AnyObject -> ChartJs.Color option

        module backgroundColor =

            module U9 =

                type Case2 =
                    delegate of ctx: ChartJs.ScriptableContext<string> * options: ChartJs.AnyObject -> ChartJs.Color option

                type Case3 =
                    delegate of ctx: ChartJs.ScriptableContext<string> * options: ChartJs.AnyObject -> ChartJs.Color option

                type Case4 =
                    delegate of ctx: ChartJs.ScriptableContext<string> * options: ChartJs.AnyObject -> ChartJs.Color option

                type Case5 =
                    delegate of ctx: ChartJs.ScriptableContext<string> * options: ChartJs.AnyObject -> ChartJs.Color option

                type Case6 =
                    delegate of ctx: ChartJs.ScriptableContext<string> * options: ChartJs.AnyObject -> ChartJs.Color option

        module hoverBorderWidth =

            module U7 =

                type Case2 =
                    delegate of ctx: ChartJs.ScriptableContext<string> * options: ChartJs.AnyObject -> float option

                type Case3 =
                    delegate of ctx: ChartJs.ScriptableContext<string> * options: ChartJs.AnyObject -> float option

                type Case4 =
                    delegate of ctx: ChartJs.ScriptableContext<string> * options: ChartJs.AnyObject -> float option

                type Case5 =
                    delegate of ctx: ChartJs.ScriptableContext<string> * options: ChartJs.AnyObject -> float option

                type Case6 =
                    delegate of ctx: ChartJs.ScriptableContext<string> * options: ChartJs.AnyObject -> float option

        module hoverBorderColor =

            module U9 =

                type Case2 =
                    delegate of ctx: ChartJs.ScriptableContext<string> * options: ChartJs.AnyObject -> ChartJs.Color option

                type Case3 =
                    delegate of ctx: ChartJs.ScriptableContext<string> * options: ChartJs.AnyObject -> ChartJs.Color option

                type Case4 =
                    delegate of ctx: ChartJs.ScriptableContext<string> * options: ChartJs.AnyObject -> ChartJs.Color option

                type Case5 =
                    delegate of ctx: ChartJs.ScriptableContext<string> * options: ChartJs.AnyObject -> ChartJs.Color option

                type Case6 =
                    delegate of ctx: ChartJs.ScriptableContext<string> * options: ChartJs.AnyObject -> ChartJs.Color option

        module hoverBackgroundColor =

            module U9 =

                type Case2 =
                    delegate of ctx: ChartJs.ScriptableContext<string> * options: ChartJs.AnyObject -> ChartJs.Color option

                type Case3 =
                    delegate of ctx: ChartJs.ScriptableContext<string> * options: ChartJs.AnyObject -> ChartJs.Color option

                type Case4 =
                    delegate of ctx: ChartJs.ScriptableContext<string> * options: ChartJs.AnyObject -> ChartJs.Color option

                type Case5 =
                    delegate of ctx: ChartJs.ScriptableContext<string> * options: ChartJs.AnyObject -> ChartJs.Color option

                type Case6 =
                    delegate of ctx: ChartJs.ScriptableContext<string> * options: ChartJs.AnyObject -> ChartJs.Color option

    module LayoutPosition =

        module Cases =

            [<AllowNullLiteral>]
            [<Interface>]
            type Case1 =
                [<EmitIndexer>]
                abstract member Item: scaleId: string -> float with get, set

    module Exports =

        module _adapters__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type Type =
                abstract member _date: Exports._adapters__.Type._date with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (_date: Exports._adapters__.Type._date) : Type = nativeOnly

            module Type =

                [<AllowNullLiteral>]
                [<Interface>]
                type _date =
                    [<EmitConstructor>]
                    abstract member Create: ?options: ChartJs.AnyObject -> ChartJs.DateAdapter
                    abstract member ``override``: members: Exports._adapters__.Type._date.``override``.members -> unit

                module _date =

                    module ``override`` =

                        [<AllowNullLiteral>]
                        [<Interface>]
                        type members =
                            /// <summary>
                            /// Will called with chart options after adapter creation.
                            /// </summary>
                            abstract member init: chartOptions: ChartJs.ChartOptions -> unit
                            /// <summary>
                            /// Returns a map of time formats for the supported formatting units defined
                            /// in Unit as well as 'datetime' representing a detailed date/time string.
                            /// </summary>
                            abstract member formats: unit -> Exports._adapters__.Type._date.``override``.members.Partial.formats
                            /// <summary>
                            /// Parses the given <c>value</c> and return the associated timestamp.
                            /// </summary>
                            /// <param name="value">
                            /// the value to parse (usually comes from the data)
                            /// </param>
                            /// <param name="format">
                            /// the expected data format
                            /// </param>
                            abstract member parse: value: obj * ?format: string -> float option
                            /// <summary>
                            /// Returns the formatted date in the specified <c>format</c> for a given <c>timestamp</c>.
                            /// </summary>
                            /// <param name="timestamp">
                            /// the timestamp to format
                            /// </param>
                            /// <param name="format">
                            /// the date/time token
                            /// </param>
                            abstract member format: timestamp: float * format: string -> string
                            /// <summary>
                            /// Adds the specified <c>amount</c> of <c>unit</c> to the given <c>timestamp</c>.
                            /// </summary>
                            /// <param name="timestamp">
                            /// the input timestamp
                            /// </param>
                            /// <param name="amount">
                            /// the amount to add
                            /// </param>
                            /// <param name="unit">
                            /// the unit as string
                            /// </param>
                            abstract member add: timestamp: float * amount: float * unit: ChartJs.TimeUnit -> float
                            /// <summary>
                            /// Returns the number of <c>unit</c> between the given timestamps.
                            /// </summary>
                            /// <param name="a">
                            /// the input timestamp (reference)
                            /// </param>
                            /// <param name="b">
                            /// the timestamp to subtract
                            /// </param>
                            /// <param name="unit">
                            /// the unit as string
                            /// </param>
                            abstract member diff: a: float * b: float * unit: ChartJs.TimeUnit -> float
                            /// <summary>
                            /// Returns start of <c>unit</c> for the given <c>timestamp</c>.
                            /// </summary>
                            /// <param name="timestamp">
                            /// the input timestamp
                            /// </param>
                            /// <param name="unit">
                            /// the unit as string
                            /// </param>
                            /// <param name="weekday">
                            /// the ISO day of the week with 1 being Monday
                            /// and 7 being Sunday (only needed if param *unit* is <c>isoWeek</c>).
                            /// </param>
                            abstract member startOf: timestamp: float * unit: Exports._adapters__.Type._date.``override``.members.Partial.startOf.unit -> float
                            /// <summary>
                            /// Returns start of <c>unit</c> for the given <c>timestamp</c>.
                            /// </summary>
                            /// <param name="timestamp">
                            /// the input timestamp
                            /// </param>
                            /// <param name="unit">
                            /// the unit as string
                            /// </param>
                            /// <param name="weekday">
                            /// the ISO day of the week with 1 being Monday
                            /// and 7 being Sunday (only needed if param *unit* is <c>isoWeek</c>).
                            /// </param>
                            abstract member startOf: timestamp: float * unit: Exports._adapters__.Type._date.``override``.members.Partial.startOf.unit * weekday: float -> float
                            /// <summary>
                            /// Returns start of <c>unit</c> for the given <c>timestamp</c>.
                            /// </summary>
                            /// <param name="timestamp">
                            /// the input timestamp
                            /// </param>
                            /// <param name="unit">
                            /// the unit as string
                            /// </param>
                            /// <param name="weekday">
                            /// the ISO day of the week with 1 being Monday
                            /// and 7 being Sunday (only needed if param *unit* is <c>isoWeek</c>).
                            /// </param>
                            abstract member startOf: timestamp: float * unit: Exports._adapters__.Type._date.``override``.members.Partial.startOf.unit * weekday: bool -> float
                            /// <summary>
                            /// Returns end of <c>unit</c> for the given <c>timestamp</c>.
                            /// </summary>
                            /// <param name="timestamp">
                            /// the input timestamp
                            /// </param>
                            /// <param name="unit">
                            /// the unit as string
                            /// </param>
                            abstract member endOf: timestamp: float * unit: ChartJs.TimeUnit -> float

                        module members =

                            module Partial =

                                [<AllowNullLiteral>]
                                [<Interface>]
                                type formats =
                                    [<EmitIndexer>]
                                    abstract member Item: key: Exports._adapters__.Type._date.``override``.members.Partial.formats.formats.key -> string with get, set

                                module formats =

                                    module formats =

                                        [<RequireQualifiedAccess>]
                                        [<StringEnum(CaseRules.None)>]
                                        type key =
                                            | millisecond
                                            | second
                                            | minute
                                            | hour
                                            | day
                                            | week
                                            | month
                                            | quarter
                                            | year
                                            | datetime

                                module startOf =

                                    [<RequireQualifiedAccess>]
                                    [<StringEnum(CaseRules.None)>]
                                    type unit =
                                        | millisecond
                                        | second
                                        | minute
                                        | hour
                                        | day
                                        | week
                                        | month
                                        | quarter
                                        | year
                                        | isoWeek

        module easingEffects__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type Type =
                abstract member linear: (float -> float) with get
                abstract member easeInQuad: (float -> float) with get
                abstract member easeOutQuad: (float -> float) with get
                abstract member easeInOutQuad: (float -> float) with get
                abstract member easeInCubic: (float -> float) with get
                abstract member easeOutCubic: (float -> float) with get
                abstract member easeInOutCubic: (float -> float) with get
                abstract member easeInQuart: (float -> float) with get
                abstract member easeOutQuart: (float -> float) with get
                abstract member easeInOutQuart: (float -> float) with get
                abstract member easeInQuint: (float -> float) with get
                abstract member easeOutQuint: (float -> float) with get
                abstract member easeInOutQuint: (float -> float) with get
                abstract member easeInSine: (float -> float) with get
                abstract member easeOutSine: (float -> float) with get
                abstract member easeInOutSine: (float -> float) with get
                abstract member easeInExpo: (float -> float) with get
                abstract member easeOutExpo: (float -> float) with get
                abstract member easeInOutExpo: (float -> float) with get
                abstract member easeInCirc: (float -> float) with get
                abstract member easeOutCirc: (float -> float) with get
                abstract member easeInOutCirc: (float -> float) with get
                abstract member easeInElastic: (float -> float) with get
                abstract member easeOutElastic: (float -> float) with get
                abstract member easeInOutElastic: (float -> float) with get
                abstract member easeInBack: (float -> float) with get
                abstract member easeOutBack: (float -> float) with get
                abstract member easeInOutBack: (float -> float) with get
                abstract member easeInBounce: (float -> float) with get
                abstract member easeOutBounce: (float -> float) with get
                abstract member easeInOutBounce: (float -> float) with get
                [<ParamObject; Emit("$0")>]
                static member Create (linear: (float -> float), easeInQuad: (float -> float), easeOutQuad: (float -> float), easeInOutQuad: (float -> float), easeInCubic: (float -> float), easeOutCubic: (float -> float), easeInOutCubic: (float -> float), easeInQuart: (float -> float), easeOutQuart: (float -> float), easeInOutQuart: (float -> float), easeInQuint: (float -> float), easeOutQuint: (float -> float), easeInOutQuint: (float -> float), easeInSine: (float -> float), easeOutSine: (float -> float), easeInOutSine: (float -> float), easeInExpo: (float -> float), easeOutExpo: (float -> float), easeInOutExpo: (float -> float), easeInCirc: (float -> float), easeOutCirc: (float -> float), easeInOutCirc: (float -> float), easeInElastic: (float -> float), easeOutElastic: (float -> float), easeInOutElastic: (float -> float), easeInBack: (float -> float), easeOutBack: (float -> float), easeInOutBack: (float -> float), easeInBounce: (float -> float), easeOutBounce: (float -> float), easeInOutBounce: (float -> float)) : Type = nativeOnly

        module Colors__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type Type =
                abstract member id: string with get, set
                abstract member defaults: ChartJs.ColorsPluginOptions with get, set
                abstract member beforeLayout: chart: ChartJs.dist.types.Chart * _args: obj * options: ChartJs.ColorsPluginOptions -> unit
                [<ParamObject; Emit("$0")>]
                static member Create (id: string, defaults: ChartJs.ColorsPluginOptions, beforeLayout: Exports.Colors__.Type.beforeLayout) : Type = nativeOnly

            module Type =

                type beforeLayout =
                    delegate of chart: ChartJs.dist.types.Chart * _args: obj * options: ChartJs.ColorsPluginOptions -> unit

        module BarController__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type Type =
                abstract member id: string with get, set
                abstract member defaults: ChartJs.AnyObject option with get, set
                abstract member defaultRoutes: Exports.BarController__.Type.defaultRoutes option with get, set
                abstract member beforeRegister: (unit -> unit) option with get, set
                abstract member afterRegister: (unit -> unit) option with get, set
                abstract member beforeUnregister: (unit -> unit) option with get, set
                abstract member afterUnregister: (unit -> unit) option with get, set
                abstract member prototype: ChartJs.BarController with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (id: string, prototype: ChartJs.BarController, ?defaults: ChartJs.AnyObject, ?defaultRoutes: Exports.BarController__.Type.defaultRoutes, ?beforeRegister: (unit -> unit), ?afterRegister: (unit -> unit), ?beforeUnregister: (unit -> unit), ?afterUnregister: (unit -> unit)) : Type = nativeOnly

            module Type =

                [<AllowNullLiteral>]
                [<Interface>]
                type defaultRoutes =
                    [<EmitIndexer>]
                    abstract member Item: property: string -> string with get, set

        module BubbleController__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type Type =
                abstract member id: string with get, set
                abstract member defaults: ChartJs.AnyObject option with get, set
                abstract member defaultRoutes: Exports.BarController__.Type.defaultRoutes option with get, set
                abstract member beforeRegister: (unit -> unit) option with get, set
                abstract member afterRegister: (unit -> unit) option with get, set
                abstract member beforeUnregister: (unit -> unit) option with get, set
                abstract member afterUnregister: (unit -> unit) option with get, set
                abstract member prototype: ChartJs.BubbleController with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (id: string, prototype: ChartJs.BubbleController, ?defaults: ChartJs.AnyObject, ?defaultRoutes: Exports.BarController__.Type.defaultRoutes, ?beforeRegister: (unit -> unit), ?afterRegister: (unit -> unit), ?beforeUnregister: (unit -> unit), ?afterUnregister: (unit -> unit)) : Type = nativeOnly

        module LineController__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type Type =
                abstract member id: string with get, set
                abstract member defaults: ChartJs.AnyObject option with get, set
                abstract member defaultRoutes: Exports.BarController__.Type.defaultRoutes option with get, set
                abstract member beforeRegister: (unit -> unit) option with get, set
                abstract member afterRegister: (unit -> unit) option with get, set
                abstract member beforeUnregister: (unit -> unit) option with get, set
                abstract member afterUnregister: (unit -> unit) option with get, set
                abstract member prototype: ChartJs.LineController with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (id: string, prototype: ChartJs.LineController, ?defaults: ChartJs.AnyObject, ?defaultRoutes: Exports.BarController__.Type.defaultRoutes, ?beforeRegister: (unit -> unit), ?afterRegister: (unit -> unit), ?beforeUnregister: (unit -> unit), ?afterUnregister: (unit -> unit)) : Type = nativeOnly

        module ScatterController__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type Type =
                abstract member id: string with get, set
                abstract member defaults: ChartJs.AnyObject option with get, set
                abstract member defaultRoutes: Exports.BarController__.Type.defaultRoutes option with get, set
                abstract member beforeRegister: (unit -> unit) option with get, set
                abstract member afterRegister: (unit -> unit) option with get, set
                abstract member beforeUnregister: (unit -> unit) option with get, set
                abstract member afterUnregister: (unit -> unit) option with get, set
                abstract member prototype: ChartJs.ScatterController with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (id: string, prototype: ChartJs.ScatterController, ?defaults: ChartJs.AnyObject, ?defaultRoutes: Exports.BarController__.Type.defaultRoutes, ?beforeRegister: (unit -> unit), ?afterRegister: (unit -> unit), ?beforeUnregister: (unit -> unit), ?afterUnregister: (unit -> unit)) : Type = nativeOnly

        module DoughnutController__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type Type =
                abstract member id: string with get, set
                abstract member defaults: ChartJs.AnyObject option with get, set
                abstract member defaultRoutes: Exports.BarController__.Type.defaultRoutes option with get, set
                abstract member beforeRegister: (unit -> unit) option with get, set
                abstract member afterRegister: (unit -> unit) option with get, set
                abstract member beforeUnregister: (unit -> unit) option with get, set
                abstract member afterUnregister: (unit -> unit) option with get, set
                abstract member prototype: ChartJs.DoughnutController with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (id: string, prototype: ChartJs.DoughnutController, ?defaults: ChartJs.AnyObject, ?defaultRoutes: Exports.BarController__.Type.defaultRoutes, ?beforeRegister: (unit -> unit), ?afterRegister: (unit -> unit), ?beforeUnregister: (unit -> unit), ?afterUnregister: (unit -> unit)) : Type = nativeOnly

        module PieController__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type Type =
                abstract member id: string with get, set
                abstract member defaults: ChartJs.AnyObject option with get, set
                abstract member defaultRoutes: Exports.BarController__.Type.defaultRoutes option with get, set
                abstract member beforeRegister: (unit -> unit) option with get, set
                abstract member afterRegister: (unit -> unit) option with get, set
                abstract member beforeUnregister: (unit -> unit) option with get, set
                abstract member afterUnregister: (unit -> unit) option with get, set
                abstract member prototype: ChartJs.PieController with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (id: string, prototype: ChartJs.PieController, ?defaults: ChartJs.AnyObject, ?defaultRoutes: Exports.BarController__.Type.defaultRoutes, ?beforeRegister: (unit -> unit), ?afterRegister: (unit -> unit), ?beforeUnregister: (unit -> unit), ?afterUnregister: (unit -> unit)) : Type = nativeOnly

        module PolarAreaController__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type Type =
                abstract member id: string with get, set
                abstract member defaults: ChartJs.AnyObject option with get, set
                abstract member defaultRoutes: Exports.BarController__.Type.defaultRoutes option with get, set
                abstract member beforeRegister: (unit -> unit) option with get, set
                abstract member afterRegister: (unit -> unit) option with get, set
                abstract member beforeUnregister: (unit -> unit) option with get, set
                abstract member afterUnregister: (unit -> unit) option with get, set
                abstract member prototype: ChartJs.PolarAreaController with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (id: string, prototype: ChartJs.PolarAreaController, ?defaults: ChartJs.AnyObject, ?defaultRoutes: Exports.BarController__.Type.defaultRoutes, ?beforeRegister: (unit -> unit), ?afterRegister: (unit -> unit), ?beforeUnregister: (unit -> unit), ?afterUnregister: (unit -> unit)) : Type = nativeOnly

        module RadarController__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type Type =
                abstract member id: string with get, set
                abstract member defaults: ChartJs.AnyObject option with get, set
                abstract member defaultRoutes: Exports.BarController__.Type.defaultRoutes option with get, set
                abstract member beforeRegister: (unit -> unit) option with get, set
                abstract member afterRegister: (unit -> unit) option with get, set
                abstract member beforeUnregister: (unit -> unit) option with get, set
                abstract member afterUnregister: (unit -> unit) option with get, set
                abstract member prototype: ChartJs.RadarController with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (id: string, prototype: ChartJs.RadarController, ?defaults: ChartJs.AnyObject, ?defaultRoutes: Exports.BarController__.Type.defaultRoutes, ?beforeRegister: (unit -> unit), ?afterRegister: (unit -> unit), ?beforeUnregister: (unit -> unit), ?afterUnregister: (unit -> unit)) : Type = nativeOnly

        module Interaction__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type Type =
                abstract member modes: ChartJs.InteractionModeMap with get, set
                /// <summary>
                /// Helper function to select candidate elements for interaction
                /// </summary>
                abstract member evaluateInteractionItems: chart: ChartJs.dist.types.Chart * axis: ChartJs.InteractionAxis * position: ChartJs.Point * handler: Exports.Interaction__.Type.evaluateInteractionItems.handler * ?intersect: bool -> ResizeArray<ChartJs.InteractionItem>
                [<ParamObject; Emit("$0")>]
                static member Create (modes: ChartJs.InteractionModeMap, evaluateInteractionItems: Exports.Interaction__.Type.evaluateInteractionItems) : Type = nativeOnly

            module Type =

                type evaluateInteractionItems =
                    delegate of chart: ChartJs.dist.types.Chart * axis: ChartJs.InteractionAxis * position: ChartJs.Point * handler: Exports.Interaction__.Type.evaluateInteractionItems.handler * ?intersect: bool -> ResizeArray<ChartJs.InteractionItem>

                module evaluateInteractionItems =

                    type handler =
                        delegate of element: Exports.Interaction__.Type.evaluateInteractionItems.handler.element * datasetIndex: float * index: float -> unit

                    module handler =

                        [<AllowNullLiteral>]
                        [<Interface>]
                        type element =
                            inherit ChartJs.VisualElement

        module layouts__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type Type =
                /// <summary>
                /// Register a box to a chart.
                /// A box is simply a reference to an object that requires layout. eg. Scales, Legend, Title.
                /// </summary>
                /// <param name="chart">
                /// the chart to use
                /// </param>
                /// <param name="item">
                /// the item to add to be laid out
                /// </param>
                abstract member addBox: chart: ChartJs.dist.types.Chart * item: ChartJs.LayoutItem -> unit
                /// <summary>
                /// Remove a layoutItem from a chart
                /// </summary>
                /// <param name="chart">
                /// the chart to remove the box from
                /// </param>
                /// <param name="layoutItem">
                /// the item to remove from the layout
                /// </param>
                abstract member removeBox: chart: ChartJs.dist.types.Chart * layoutItem: ChartJs.LayoutItem -> unit
                /// <summary>
                /// Sets (or updates) options on the given <c>item</c>.
                /// </summary>
                /// <param name="chart">
                /// the chart in which the item lives (or will be added to)
                /// </param>
                /// <param name="item">
                /// the item to configure with the given options
                /// </param>
                /// <param name="options">
                /// the new item options.
                /// </param>
                abstract member configure: chart: ChartJs.dist.types.Chart * item: ChartJs.LayoutItem * options: Exports.layouts__.Type.configure.options -> unit
                /// <summary>
                /// Fits boxes of the given chart into the given size by having each box measure itself
                /// then running a fitting algorithm
                /// </summary>
                /// <param name="chart">
                /// the chart
                /// </param>
                /// <param name="width">
                /// the width to fit into
                /// </param>
                /// <param name="height">
                /// the height to fit into
                /// </param>
                abstract member update: chart: ChartJs.dist.types.Chart * width: float * height: float -> unit
                [<ParamObject; Emit("$0")>]
                static member Create (addBox: Exports.layouts__.Type.addBox, removeBox: Exports.layouts__.Type.removeBox, configure: Exports.layouts__.Type.configure, update: Exports.layouts__.Type.update) : Type = nativeOnly

            module Type =

                type addBox =
                    delegate of chart: ChartJs.dist.types.Chart * item: ChartJs.LayoutItem -> unit

                type removeBox =
                    delegate of chart: ChartJs.dist.types.Chart * layoutItem: ChartJs.LayoutItem -> unit

                type configure =
                    delegate of chart: ChartJs.dist.types.Chart * item: ChartJs.LayoutItem * options: Exports.layouts__.Type.configure.options -> unit

                type update =
                    delegate of chart: ChartJs.dist.types.Chart * width: float * height: float -> unit

                module configure =

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type options =
                        abstract member fullSize: float option with get, set
                        abstract member position: ChartJs.LayoutPosition option with get, set
                        abstract member weight: float option with get, set
                        [<ParamObject; Emit("$0")>]
                        static member Create (?fullSize: float, ?position: ChartJs.LayoutPosition, ?weight: float) : options = nativeOnly

        module Ticks__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type Type =
                abstract member formatters: Exports.Ticks__.Type.formatters with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (formatters: Exports.Ticks__.Type.formatters) : Type = nativeOnly

            module Type =

                [<AllowNullLiteral>]
                [<Interface>]
                type formatters =
                    /// <summary>
                    /// Formatter for value labels
                    /// </summary>
                    /// <param name="value">
                    /// the value to display
                    /// </param>
                    /// <returns>
                    /// the label to display
                    /// </returns>
                    abstract member values: value: obj -> U2<string, ResizeArray<string>>
                    /// <summary>
                    /// Formatter for numeric ticks
                    /// </summary>
                    /// <param name="tickValue">
                    /// the value to be formatted
                    /// </param>
                    /// <param name="index">
                    /// the position of the tickValue parameter in the ticks array
                    /// </param>
                    /// <param name="ticks">
                    /// the list of ticks being converted
                    /// </param>
                    /// <returns>
                    /// string representation of the tickValue parameter
                    /// </returns>
                    abstract member numeric: tickValue: float * index: float * ticks: ResizeArray<Exports.Ticks__.Type.formatters.numeric.ticks.Item> -> string
                    /// <summary>
                    /// Formatter for logarithmic ticks
                    /// </summary>
                    /// <param name="tickValue">
                    /// the value to be formatted
                    /// </param>
                    /// <param name="index">
                    /// the position of the tickValue parameter in the ticks array
                    /// </param>
                    /// <param name="ticks">
                    /// the list of ticks being converted
                    /// </param>
                    /// <returns>
                    /// string representation of the tickValue parameter
                    /// </returns>
                    abstract member logarithmic: tickValue: float * index: float * ticks: ResizeArray<Exports.Ticks__.Type.formatters.logarithmic.ticks.Item> -> string
                    [<ParamObject; Emit("$0")>]
                    static member Create (values: (obj -> U2<string, ResizeArray<string>>), numeric: Exports.Ticks__.Type.formatters.numeric, logarithmic: Exports.Ticks__.Type.formatters.logarithmic) : formatters = nativeOnly

                module formatters =

                    type numeric =
                        delegate of tickValue: float * index: float * ticks: ResizeArray<Exports.Ticks__.Type.formatters.numeric.ticks.Item> -> string

                    type logarithmic =
                        delegate of tickValue: float * index: float * ticks: ResizeArray<Exports.Ticks__.Type.formatters.logarithmic.ticks.Item> -> string

                    module numeric =

                        module ticks =

                            [<AllowNullLiteral>]
                            [<Interface>]
                            type Item =
                                abstract member value: float with get, set
                                [<ParamObject; Emit("$0")>]
                                static member Create (value: float) : Item = nativeOnly

                    module logarithmic =

                        module ticks =

                            [<AllowNullLiteral>]
                            [<Interface>]
                            type Item =
                                abstract member value: float with get, set
                                [<ParamObject; Emit("$0")>]
                                static member Create (value: float) : Item = nativeOnly

        module LineElement__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type Type =
                abstract member id: string with get, set
                abstract member defaults: ChartJs.AnyObject option with get, set
                abstract member defaultRoutes: Exports.BarController__.Type.defaultRoutes option with get, set
                abstract member beforeRegister: (unit -> unit) option with get, set
                abstract member afterRegister: (unit -> unit) option with get, set
                abstract member beforeUnregister: (unit -> unit) option with get, set
                abstract member afterUnregister: (unit -> unit) option with get, set
                abstract member prototype: ChartJs.LineElement with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (id: string, prototype: ChartJs.LineElement, ?defaults: ChartJs.AnyObject, ?defaultRoutes: Exports.BarController__.Type.defaultRoutes, ?beforeRegister: (unit -> unit), ?afterRegister: (unit -> unit), ?beforeUnregister: (unit -> unit), ?afterUnregister: (unit -> unit)) : Type = nativeOnly

        module BarElement__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type Type =
                abstract member id: string with get, set
                abstract member defaults: ChartJs.AnyObject option with get, set
                abstract member defaultRoutes: Exports.BarController__.Type.defaultRoutes option with get, set
                abstract member beforeRegister: (unit -> unit) option with get, set
                abstract member afterRegister: (unit -> unit) option with get, set
                abstract member beforeUnregister: (unit -> unit) option with get, set
                abstract member afterUnregister: (unit -> unit) option with get, set
                abstract member prototype: ChartJs.BarElement with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (id: string, prototype: ChartJs.BarElement, ?defaults: ChartJs.AnyObject, ?defaultRoutes: Exports.BarController__.Type.defaultRoutes, ?beforeRegister: (unit -> unit), ?afterRegister: (unit -> unit), ?beforeUnregister: (unit -> unit), ?afterUnregister: (unit -> unit)) : Type = nativeOnly

        module CategoryScale__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type Type =
                abstract member id: string with get, set
                abstract member defaults: ChartJs.AnyObject option with get, set
                abstract member defaultRoutes: Exports.BarController__.Type.defaultRoutes option with get, set
                abstract member beforeRegister: (unit -> unit) option with get, set
                abstract member afterRegister: (unit -> unit) option with get, set
                abstract member beforeUnregister: (unit -> unit) option with get, set
                abstract member afterUnregister: (unit -> unit) option with get, set
                abstract member prototype: ChartJs.CategoryScale with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (id: string, prototype: ChartJs.CategoryScale, ?defaults: ChartJs.AnyObject, ?defaultRoutes: Exports.BarController__.Type.defaultRoutes, ?beforeRegister: (unit -> unit), ?afterRegister: (unit -> unit), ?beforeUnregister: (unit -> unit), ?afterUnregister: (unit -> unit)) : Type = nativeOnly

        module LinearScale__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type Type =
                abstract member id: string with get, set
                abstract member defaults: ChartJs.AnyObject option with get, set
                abstract member defaultRoutes: Exports.BarController__.Type.defaultRoutes option with get, set
                abstract member beforeRegister: (unit -> unit) option with get, set
                abstract member afterRegister: (unit -> unit) option with get, set
                abstract member beforeUnregister: (unit -> unit) option with get, set
                abstract member afterUnregister: (unit -> unit) option with get, set
                abstract member prototype: ChartJs.LinearScale with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (id: string, prototype: ChartJs.LinearScale, ?defaults: ChartJs.AnyObject, ?defaultRoutes: Exports.BarController__.Type.defaultRoutes, ?beforeRegister: (unit -> unit), ?afterRegister: (unit -> unit), ?beforeUnregister: (unit -> unit), ?afterUnregister: (unit -> unit)) : Type = nativeOnly

        module LogarithmicScale__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type Type =
                abstract member id: string with get, set
                abstract member defaults: ChartJs.AnyObject option with get, set
                abstract member defaultRoutes: Exports.BarController__.Type.defaultRoutes option with get, set
                abstract member beforeRegister: (unit -> unit) option with get, set
                abstract member afterRegister: (unit -> unit) option with get, set
                abstract member beforeUnregister: (unit -> unit) option with get, set
                abstract member afterUnregister: (unit -> unit) option with get, set
                abstract member prototype: ChartJs.LogarithmicScale with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (id: string, prototype: ChartJs.LogarithmicScale, ?defaults: ChartJs.AnyObject, ?defaultRoutes: Exports.BarController__.Type.defaultRoutes, ?beforeRegister: (unit -> unit), ?afterRegister: (unit -> unit), ?beforeUnregister: (unit -> unit), ?afterUnregister: (unit -> unit)) : Type = nativeOnly

        module TimeScale__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type Type =
                abstract member id: string with get, set
                abstract member defaults: ChartJs.AnyObject option with get, set
                abstract member defaultRoutes: Exports.BarController__.Type.defaultRoutes option with get, set
                abstract member beforeRegister: (unit -> unit) option with get, set
                abstract member afterRegister: (unit -> unit) option with get, set
                abstract member beforeUnregister: (unit -> unit) option with get, set
                abstract member afterUnregister: (unit -> unit) option with get, set
                abstract member prototype: ChartJs.TimeScale with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (id: string, prototype: ChartJs.TimeScale, ?defaults: ChartJs.AnyObject, ?defaultRoutes: Exports.BarController__.Type.defaultRoutes, ?beforeRegister: (unit -> unit), ?afterRegister: (unit -> unit), ?beforeUnregister: (unit -> unit), ?afterUnregister: (unit -> unit)) : Type = nativeOnly

        module TimeSeriesScale__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type Type =
                abstract member id: string with get, set
                abstract member defaults: ChartJs.AnyObject option with get, set
                abstract member defaultRoutes: Exports.BarController__.Type.defaultRoutes option with get, set
                abstract member beforeRegister: (unit -> unit) option with get, set
                abstract member afterRegister: (unit -> unit) option with get, set
                abstract member beforeUnregister: (unit -> unit) option with get, set
                abstract member afterUnregister: (unit -> unit) option with get, set
                abstract member prototype: ChartJs.TimeSeriesScale with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (id: string, prototype: ChartJs.TimeSeriesScale, ?defaults: ChartJs.AnyObject, ?defaultRoutes: Exports.BarController__.Type.defaultRoutes, ?beforeRegister: (unit -> unit), ?afterRegister: (unit -> unit), ?beforeUnregister: (unit -> unit), ?afterUnregister: (unit -> unit)) : Type = nativeOnly

        module RadialLinearScale__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type Type =
                abstract member id: string with get, set
                abstract member defaults: ChartJs.AnyObject option with get, set
                abstract member defaultRoutes: Exports.BarController__.Type.defaultRoutes option with get, set
                abstract member beforeRegister: (unit -> unit) option with get, set
                abstract member afterRegister: (unit -> unit) option with get, set
                abstract member beforeUnregister: (unit -> unit) option with get, set
                abstract member afterUnregister: (unit -> unit) option with get, set
                abstract member prototype: ChartJs.RadialLinearScale with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (id: string, prototype: ChartJs.RadialLinearScale, ?defaults: ChartJs.AnyObject, ?defaultRoutes: Exports.BarController__.Type.defaultRoutes, ?beforeRegister: (unit -> unit), ?afterRegister: (unit -> unit), ?beforeUnregister: (unit -> unit), ?afterUnregister: (unit -> unit)) : Type = nativeOnly

        module Scale =

            [<AllowNullLiteral>]
            [<Interface>]
            type cfg =
                abstract member id: string with get, set
                abstract member ``type``: string with get, set
                abstract member ctx: Glutinum.Web.CanvasRenderingContext2D with get, set
                abstract member chart: ChartJs.dist.types.Chart with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (id: string, ``type``: string, ctx: Glutinum.Web.CanvasRenderingContext2D, chart: ChartJs.dist.types.Chart) : cfg = nativeOnly

        module Chart =

            [<AllowNullLiteral>]
            [<Interface>]
            type item =
                abstract member canvas: Glutinum.Web.HTMLCanvasElement with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (canvas: Glutinum.Web.HTMLCanvasElement) : item = nativeOnly

module KurkleColor =

    [<AbstractClass>]
    [<Erase>]
    type Exports =
        /// <summary>
        /// Parse HEX to color
        /// </summary>
        /// <param name="str">
        /// the string
        /// </param>
        [<Import("hexParse", "@kurkle/color")>]
        static member hexParse (str: string) : Exports.hexParse__ = nativeOnly
        /// <summary>
        /// Return HEX string from color
        /// </summary>
        /// <param name="v">
        /// the color
        /// </param>
        [<Import("hexString", "@kurkle/color")>]
        static member hexString (v: KurkleColor.RGBA) : U2<string, KurkleColor.RGBA> = nativeOnly
        /// <summary>
        /// Rounds decimal to nearest integer
        /// </summary>
        /// <param name="v">
        /// the number to round
        /// </param>
        [<Import("round", "@kurkle/color")>]
        static member round (v: float) : float = nativeOnly
        /// <summary>
        /// convert percent to byte 0..255
        /// </summary>
        /// <param name="v">
        /// 0..100
        /// </param>
        [<Import("p2b", "@kurkle/color")>]
        static member p2b (v: float) : float = nativeOnly
        /// <summary>
        /// convert byte to percet 0..100
        /// </summary>
        /// <param name="v">
        /// 0..255
        /// </param>
        [<Import("b2p", "@kurkle/color")>]
        static member b2p (v: float) : float = nativeOnly
        /// <summary>
        /// convert normalized to byte 0..255
        /// </summary>
        /// <param name="v">
        /// 0..1
        /// </param>
        [<Import("n2b", "@kurkle/color")>]
        static member n2b (v: float) : float = nativeOnly
        /// <summary>
        /// convert byte to normalized 0..1
        /// </summary>
        /// <param name="v">
        /// 0..255
        /// </param>
        [<Import("b2n", "@kurkle/color")>]
        static member b2n (v: float) : float = nativeOnly
        /// <summary>
        /// convert normalized to percent 0..100
        /// </summary>
        /// <param name="v">
        /// 0..1
        /// </param>
        [<Import("n2p", "@kurkle/color")>]
        static member n2p (v: float) : float = nativeOnly
        /// <summary>
        /// Convert rgb to hsl
        /// </summary>
        /// <param name="v">
        /// the color
        /// </param>
        /// <returns>
        /// - [h, s, l]
        /// </returns>
        [<Import("rgb2hsl", "@kurkle/color")>]
        static member rgb2hsl (v: KurkleColor.RGBA) : ResizeArray<float> = nativeOnly
        /// <summary>
        /// Convert hsl to rgb
        /// </summary>
        /// <param name="h">
        /// hue | [h, s, l]
        /// </param>
        /// <param name="s">
        /// saturation
        /// </param>
        /// <param name="l">
        /// lightness
        /// </param>
        [<Import("hsl2rgb", "@kurkle/color")>]
        static member hsl2rgb (h: float, ?s: float, ?l: float) : ResizeArray<float> = nativeOnly
        /// <summary>
        /// Convert hsl to rgb
        /// </summary>
        /// <param name="h">
        /// hue | [h, s, l]
        /// </param>
        /// <param name="s">
        /// saturation
        /// </param>
        /// <param name="l">
        /// lightness
        /// </param>
        [<Import("hsl2rgb", "@kurkle/color")>]
        static member hsl2rgb (h: ResizeArray<float>, ?s: float, ?l: float) : ResizeArray<float> = nativeOnly
        /// <summary>
        /// Convert hsl to rgb
        /// </summary>
        /// <param name="h">
        /// hue | [h, s, l]
        /// </param>
        /// <param name="s">
        /// saturation
        /// </param>
        /// <param name="l">
        /// lightness
        /// </param>
        [<Import("hsl2rgb", "@kurkle/color")>]
        static member hsl2rgb (h: U2<float, ResizeArray<float>>, ?s: float, ?l: float) : ResizeArray<float> = nativeOnly
        /// <summary>
        /// Convert hwb to rgb
        /// </summary>
        /// <param name="h">
        /// hue | [h, s, l]
        /// </param>
        /// <param name="w">
        /// whiteness
        /// </param>
        /// <param name="b">
        /// blackness
        /// </param>
        [<Import("hwb2rgb", "@kurkle/color")>]
        static member hwb2rgb (h: float, ?w: float, ?b: float) : ResizeArray<float> = nativeOnly
        /// <summary>
        /// Convert hwb to rgb
        /// </summary>
        /// <param name="h">
        /// hue | [h, s, l]
        /// </param>
        /// <param name="w">
        /// whiteness
        /// </param>
        /// <param name="b">
        /// blackness
        /// </param>
        [<Import("hwb2rgb", "@kurkle/color")>]
        static member hwb2rgb (h: ResizeArray<float>, ?w: float, ?b: float) : ResizeArray<float> = nativeOnly
        /// <summary>
        /// Convert hwb to rgb
        /// </summary>
        /// <param name="h">
        /// hue | [h, s, l]
        /// </param>
        /// <param name="w">
        /// whiteness
        /// </param>
        /// <param name="b">
        /// blackness
        /// </param>
        [<Import("hwb2rgb", "@kurkle/color")>]
        static member hwb2rgb (h: U2<float, ResizeArray<float>>, ?w: float, ?b: float) : ResizeArray<float> = nativeOnly
        /// <summary>
        /// Convert hsv to rgb
        /// </summary>
        /// <param name="h">
        /// hue | [h, s, l]
        /// </param>
        /// <param name="s">
        /// saturation
        /// </param>
        /// <param name="v">
        /// value
        /// </param>
        [<Import("hsv2rgb", "@kurkle/color")>]
        static member hsv2rgb (h: float, ?s: float, ?v: float) : ResizeArray<float> = nativeOnly
        /// <summary>
        /// Convert hsv to rgb
        /// </summary>
        /// <param name="h">
        /// hue | [h, s, l]
        /// </param>
        /// <param name="s">
        /// saturation
        /// </param>
        /// <param name="v">
        /// value
        /// </param>
        [<Import("hsv2rgb", "@kurkle/color")>]
        static member hsv2rgb (h: ResizeArray<float>, ?s: float, ?v: float) : ResizeArray<float> = nativeOnly
        /// <summary>
        /// Convert hsv to rgb
        /// </summary>
        /// <param name="h">
        /// hue | [h, s, l]
        /// </param>
        /// <param name="s">
        /// saturation
        /// </param>
        /// <param name="v">
        /// value
        /// </param>
        [<Import("hsv2rgb", "@kurkle/color")>]
        static member hsv2rgb (h: U2<float, ResizeArray<float>>, ?s: float, ?v: float) : ResizeArray<float> = nativeOnly
        /// <summary>
        /// Parse hsl/hsv/hwb color string
        /// </summary>
        /// <param name="str">
        /// hsl/hsv/hwb color string
        /// </param>
        /// <returns>
        /// - the parsed color components
        /// </returns>
        [<Import("hueParse", "@kurkle/color")>]
        static member hueParse (str: string) : KurkleColor.RGBA = nativeOnly
        /// <summary>
        /// Rotate the <c>v</c> color by <c>deg</c> degrees
        /// </summary>
        /// <param name="v">
        /// the color
        /// </param>
        /// <param name="deg">
        /// degrees to rotate
        /// </param>
        [<Import("rotate", "@kurkle/color")>]
        static member rotate (v: KurkleColor.RGBA, deg: float) : unit = nativeOnly
        /// <summary>
        /// Return hsl(a) string from color components
        /// </summary>
        /// <param name="v">
        /// the color
        /// </param>
        [<Import("hslString", "@kurkle/color")>]
        static member hslString (v: KurkleColor.RGBA) : string = nativeOnly
        /// <summary>
        /// Parse color name
        /// </summary>
        /// <param name="str">
        /// the color name
        /// </param>
        /// <returns>
        /// - the color
        /// </returns>
        [<Import("nameParse", "@kurkle/color")>]
        static member nameParse (str: string) : KurkleColor.RGBA = nativeOnly
        /// <summary>
        /// Parse rgb(a) string to RGBA
        /// </summary>
        /// <param name="str">
        /// the rgb string
        /// </param>
        /// <returns>
        /// - the parsed color
        /// </returns>
        [<Import("rgbParse", "@kurkle/color")>]
        static member rgbParse (str: string) : KurkleColor.RGBA = nativeOnly
        /// <summary>
        /// Return rgb(a) string from color
        /// </summary>
        /// <param name="v">
        /// the color
        /// </param>
        [<Import("rgbString", "@kurkle/color")>]
        static member rgbString (v: KurkleColor.RGBA) : string = nativeOnly
        /// <summary>
        /// Construct new Color instance
        /// </summary>
        /// <param name="input">
        ///
        /// </param>
        [<ImportDefault("@kurkle/color")>]
        static member _default (input: string) : KurkleColor.Color = nativeOnly
        /// <summary>
        /// Construct new Color instance
        /// </summary>
        /// <param name="input">
        ///
        /// </param>
        [<ImportDefault("@kurkle/color")>]
        static member _default (input: ResizeArray<float>) : KurkleColor.Color = nativeOnly
        /// <summary>
        /// Construct new Color instance
        /// </summary>
        /// <param name="input">
        ///
        /// </param>
        [<ImportDefault("@kurkle/color")>]
        static member _default (input: Glutinum.Web.CanvasGradient) : KurkleColor.Color = nativeOnly
        /// <summary>
        /// Construct new Color instance
        /// </summary>
        /// <param name="input">
        ///
        /// </param>
        [<ImportDefault("@kurkle/color")>]
        static member _default (input: Glutinum.Web.CanvasPattern) : KurkleColor.Color = nativeOnly
        /// <summary>
        /// Construct new Color instance
        /// </summary>
        /// <param name="input">
        ///
        /// </param>
        [<ImportDefault("@kurkle/color")>]
        static member _default (input: KurkleColor.RGBA) : KurkleColor.Color = nativeOnly
        /// <summary>
        /// Construct new Color instance
        /// </summary>
        /// <param name="input">
        ///
        /// </param>
        [<ImportDefault("@kurkle/color")>]
        static member _default (input: U4<string, ResizeArray<float>, KurkleColor.Color, KurkleColor.RGBA>) : KurkleColor.Color = nativeOnly
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="input">
        ///
        /// </param>
        [<Import("Color", "@kurkle/color"); EmitConstructor>]
        static member Color (input: string) : Color = nativeOnly
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="input">
        ///
        /// </param>
        [<Import("Color", "@kurkle/color"); EmitConstructor>]
        static member Color (input: ResizeArray<float>) : Color = nativeOnly
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="input">
        ///
        /// </param>
        [<Import("Color", "@kurkle/color"); EmitConstructor>]
        static member Color (input: Glutinum.Web.CanvasGradient) : Color = nativeOnly
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="input">
        ///
        /// </param>
        [<Import("Color", "@kurkle/color"); EmitConstructor>]
        static member Color (input: Glutinum.Web.CanvasPattern) : Color = nativeOnly
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="input">
        ///
        /// </param>
        [<Import("Color", "@kurkle/color"); EmitConstructor>]
        static member Color (input: KurkleColor.RGBA) : Color = nativeOnly
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="input">
        ///
        /// </param>
        [<Import("Color", "@kurkle/color"); EmitConstructor>]
        static member Color (input: U4<string, ResizeArray<float>, KurkleColor.Color, KurkleColor.RGBA>) : Color = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type RGBA =
        /// <summary>
        /// - red [0..255]
        /// </summary>
        abstract member r: float with get, set
        /// <summary>
        /// - green [0..255]
        /// </summary>
        abstract member g: float with get, set
        /// <summary>
        /// - blue [0..255]
        /// </summary>
        abstract member b: float with get, set
        /// <summary>
        /// - alpha [0..1]
        /// </summary>
        abstract member a: float with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (r: float, g: float, b: float, a: float) : RGBA = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type Color =
        abstract member _rgb: KurkleColor.RGBA with get, set
        abstract member _valid: bool with get, set
        /// <summary>
        /// <c>true</c> if this is a valid color
        /// </summary>
        abstract member valid: bool with get
        /// <returns>
        /// - the color
        /// </returns>
        abstract member rgb: KurkleColor.RGBA with get, set
        /// <summary>
        /// rgb(a) string
        /// </summary>
        abstract member rgbString: unit -> string
        /// <summary>
        /// hex string
        /// </summary>
        abstract member hexString: unit -> string
        /// <summary>
        /// hsl(a) string
        /// </summary>
        abstract member hslString: unit -> string
        /// <summary>
        /// Mix another color to this color.
        /// </summary>
        /// <param name="color">
        /// Color to mix in
        /// </param>
        /// <param name="weight">
        /// 0..1
        /// </param>
        abstract member mix: color: string * weight: float -> KurkleColor.Color
        /// <summary>
        /// Mix another color to this color.
        /// </summary>
        /// <param name="color">
        /// Color to mix in
        /// </param>
        /// <param name="weight">
        /// 0..1
        /// </param>
        abstract member mix: color: Glutinum.Web.CanvasGradient * weight: float -> KurkleColor.Color
        /// <summary>
        /// Mix another color to this color.
        /// </summary>
        /// <param name="color">
        /// Color to mix in
        /// </param>
        /// <param name="weight">
        /// 0..1
        /// </param>
        abstract member mix: color: Glutinum.Web.CanvasPattern * weight: float -> KurkleColor.Color
        /// <summary>
        /// Mix another color to this color.
        /// </summary>
        /// <param name="color">
        /// Color to mix in
        /// </param>
        /// <param name="weight">
        /// 0..1
        /// </param>
        abstract member mix: color: KurkleColor.Color * weight: float -> KurkleColor.Color
        /// <summary>
        /// Clone
        /// </summary>
        abstract member clone: unit -> KurkleColor.Color
        /// <summary>
        /// Set aplha
        /// </summary>
        /// <param name="a">
        /// the alpha [0..1]
        /// </param>
        abstract member alpha: a: float -> KurkleColor.Color
        /// <summary>
        /// Make clearer
        /// </summary>
        /// <param name="ratio">
        /// ratio [0..1]
        /// </param>
        abstract member clearer: ratio: float -> KurkleColor.Color
        /// <summary>
        /// Convert to grayscale
        /// </summary>
        abstract member greyscale: unit -> KurkleColor.Color
        /// <summary>
        /// Opaquer
        /// </summary>
        /// <param name="ratio">
        /// ratio [0..1]
        /// </param>
        abstract member opaquer: ratio: float -> KurkleColor.Color
        abstract member negate: unit -> KurkleColor.Color
        /// <summary>
        /// Lighten
        /// </summary>
        /// <param name="ratio">
        /// ratio [0..1]
        /// </param>
        abstract member lighten: ratio: float -> KurkleColor.Color
        /// <summary>
        /// Darken
        /// </summary>
        /// <param name="ratio">
        /// ratio [0..1]
        /// </param>
        abstract member darken: ratio: float -> KurkleColor.Color
        /// <summary>
        /// Saturate
        /// </summary>
        /// <param name="ratio">
        /// ratio [0..1]
        /// </param>
        abstract member saturate: ratio: float -> KurkleColor.Color
        /// <summary>
        /// Desaturate
        /// </summary>
        /// <param name="ratio">
        /// ratio [0..1]
        /// </param>
        abstract member desaturate: ratio: float -> KurkleColor.Color
        /// <summary>
        /// Rotate
        /// </summary>
        /// <param name="deg">
        /// degrees to rotate
        /// </param>
        abstract member rotate: deg: float -> KurkleColor.Color

    module Exports =

        [<AllowNullLiteral>]
        [<Interface>]
        type hexParse__ =
            abstract member r: float with get, set
            abstract member g: float with get, set
            abstract member b: float with get, set
            abstract member a: float with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (r: float, g: float, b: float, a: float) : hexParse__ = nativeOnly
