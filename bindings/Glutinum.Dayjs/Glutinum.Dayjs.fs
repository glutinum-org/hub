namespace rec Glutinum

open Fable.Core
open Fable.Core.JsInterop
open System

// You need to add Glutinum.Types NuGet package to your project
open Glutinum.Types.TypeScript

module Dayjs =

    [<AbstractClass>]
    [<Erase>]
    type Exports =
        [<ImportDefault("dayjs")>]
        static member dayjs () : Dayjs.dayjs_.Dayjs = nativeOnly
        [<ImportDefault("dayjs")>]
        static member dayjs (date: string) : Dayjs.dayjs_.Dayjs = nativeOnly
        [<ImportDefault("dayjs")>]
        static member dayjs (date: float) : Dayjs.dayjs_.Dayjs = nativeOnly
        [<ImportDefault("dayjs")>]
        static member dayjs (date: Date) : Dayjs.dayjs_.Dayjs = nativeOnly
        [<ImportDefault("dayjs")>]
        static member dayjs (date: Dayjs.dayjs_.Dayjs) : Dayjs.dayjs_.Dayjs = nativeOnly
        [<ImportDefault("dayjs")>]
        static member dayjs (date: string, format: Dayjs.dayjs_.OptionType, ?strict: bool) : Dayjs.dayjs_.Dayjs = nativeOnly
        [<ImportDefault("dayjs")>]
        static member dayjs (date: float, format: Dayjs.dayjs_.OptionType, ?strict: bool) : Dayjs.dayjs_.Dayjs = nativeOnly
        [<ImportDefault("dayjs")>]
        static member dayjs (date: Date, format: Dayjs.dayjs_.OptionType, ?strict: bool) : Dayjs.dayjs_.Dayjs = nativeOnly
        [<ImportDefault("dayjs")>]
        static member dayjs (date: Dayjs.dayjs_.Dayjs, format: Dayjs.dayjs_.OptionType, ?strict: bool) : Dayjs.dayjs_.Dayjs = nativeOnly
        [<ImportDefault("dayjs")>]
        static member dayjs (date: string, format: Dayjs.dayjs_.OptionType, locale: string, ?strict: bool) : Dayjs.dayjs_.Dayjs = nativeOnly
        [<ImportDefault("dayjs")>]
        static member dayjs (date: float, format: Dayjs.dayjs_.OptionType, locale: string, ?strict: bool) : Dayjs.dayjs_.Dayjs = nativeOnly
        [<ImportDefault("dayjs")>]
        static member dayjs (date: Date, format: Dayjs.dayjs_.OptionType, locale: string, ?strict: bool) : Dayjs.dayjs_.Dayjs = nativeOnly
        [<ImportDefault("dayjs")>]
        static member dayjs (date: Dayjs.dayjs_.Dayjs, format: Dayjs.dayjs_.OptionType, locale: string, ?strict: bool) : Dayjs.dayjs_.Dayjs = nativeOnly
        [<ImportAll("dayjs")>]
        static member inline dayjs_
            with get () : dayjs_.Exports =
                nativeOnly
        [<ImportDefault("dayjs"); Emit("$0.extend($1...)")>]
        static member extend<'T> (plugin: Dayjs.dayjs_.PluginFunc<'T>, ?option: 'T) : Dayjs.dayjs_.Dayjs = nativeOnly
        [<ImportDefault("dayjs"); Emit("$0.locale($1...)")>]
        static member locale (?preset: U2<string, Dayjs.ILocale>, ?``object``: Exports.locale__.``object``, ?isLocal: bool) : string = nativeOnly
        [<ImportDefault("dayjs"); Emit("$0.isDayjs($1...)")>]
        static member isDayjs (d: obj) : bool = nativeOnly
        [<ImportDefault("dayjs"); Emit("$0.unix($1...)")>]
        static member unix (t: float) : Dayjs.dayjs_.Dayjs = nativeOnly
        [<ImportDefault("dayjs")>]
        [<Emit("$0.Ls")>]
        static member inline Ls: Exports.Ls__.Type = nativeOnly

    module dayjs_ =

        [<AbstractClass>]
        [<Erase>]
        type Exports =
            [<Emit("$0.extend($1...)")>]
            abstract member extend<'T>: plugin: Dayjs.dayjs_.PluginFunc<'T> * ?option: 'T -> Dayjs.dayjs_.Dayjs
            [<Emit("$0.locale($1...)")>]
            abstract member locale: unit -> string
            [<Emit("$0.locale($1...)")>]
            abstract member locale: preset: string * ?``object``: Exports.locale.``object`` * ?isLocal: bool -> string
            [<Emit("$0.locale($1...)")>]
            abstract member locale: preset: Dayjs.ILocale * ?``object``: Exports.locale.``object`` * ?isLocal: bool -> string
            [<Emit("$0.isDayjs($1...)")>]
            abstract member isDayjs: d: obj -> bool
            [<Emit("$0.unix($1...)")>]
            abstract member unix: t: float -> Dayjs.dayjs_.Dayjs
            [<Emit("$0.Ls")>]
            abstract member Ls: Exports.Ls.Type
            [<Emit("new $0.Dayjs($1...)")>]
            abstract member Dayjs: unit -> Dayjs
            [<Emit("new $0.Dayjs($1...)")>]
            abstract member Dayjs: config: string -> Dayjs
            [<Emit("new $0.Dayjs($1...)")>]
            abstract member Dayjs: config: float -> Dayjs
            [<Emit("new $0.Dayjs($1...)")>]
            abstract member Dayjs: config: Date -> Dayjs
            [<Emit("new $0.Dayjs($1...)")>]
            abstract member Dayjs: config: Dayjs.dayjs_.Dayjs -> Dayjs

        [<AllowNullLiteral>]
        [<Interface>]
        type ConfigTypeMap =
            abstract member ``default``: U4<string, float, Date, Dayjs.dayjs_.Dayjs> option with get, set
            [<ParamObject; Emit("$0")>]
            static member Create () : ConfigTypeMap = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (``default``: string) : ConfigTypeMap = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (``default``: float) : ConfigTypeMap = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (``default``: Date) : ConfigTypeMap = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (``default``: Dayjs.dayjs_.Dayjs) : ConfigTypeMap = nativeOnly

        type ConfigType =
            U4<string, float, Date, Dayjs.dayjs_.Dayjs> option

        [<AllowNullLiteral>]
        [<Interface>]
        type FormatObject =
            abstract member locale: string option with get, set
            abstract member format: string option with get, set
            abstract member utc: bool option with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (?locale: string, ?format: string, ?utc: bool) : FormatObject = nativeOnly

        type OptionType =
            U3<Dayjs.dayjs_.FormatObject, string, ResizeArray<string>>

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type UnitTypeShort =
            | d
            | D
            | M
            | y
            | h
            | m
            | s
            | ms

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type UnitTypeLong =
            | millisecond
            | second
            | minute
            | hour
            | day
            | month
            | year
            | date

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type UnitTypeLongPlural =
            | milliseconds
            | seconds
            | minutes
            | hours
            | days
            | months
            | years
            | dates

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type UnitType =
            | millisecond
            | second
            | minute
            | hour
            | day
            | month
            | year
            | date
            | milliseconds
            | seconds
            | minutes
            | hours
            | days
            | months
            | years
            | dates
            | d
            | D
            | M
            | y
            | h
            | m
            | s
            | ms

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type OpUnitType =
            | millisecond
            | second
            | minute
            | hour
            | day
            | month
            | year
            | date
            | milliseconds
            | seconds
            | minutes
            | hours
            | days
            | months
            | years
            | dates
            | d
            | D
            | M
            | y
            | h
            | m
            | s
            | ms
            | week
            | weeks
            | w

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type QUnitType =
            | millisecond
            | second
            | minute
            | hour
            | day
            | month
            | year
            | date
            | milliseconds
            | seconds
            | minutes
            | hours
            | days
            | months
            | years
            | dates
            | d
            | D
            | M
            | y
            | h
            | m
            | s
            | ms
            | quarter
            | quarters
            | Q

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type ManipulateType =
            | millisecond
            | second
            | minute
            | hour
            | day
            | month
            | year
            | milliseconds
            | seconds
            | minutes
            | hours
            | days
            | months
            | years
            | d
            | D
            | M
            | y
            | h
            | m
            | s
            | ms
            | week
            | weeks
            | w

        [<AllowNullLiteral>]
        [<Interface>]
        type Dayjs =
            /// <summary>
            /// All Day.js objects are immutable. Still, <c>dayjs#clone</c> can create a clone of the current object if you need one.
            /// <code>
            /// dayjs().clone()// => Dayjs
            /// dayjs(dayjs('2019-01-25')) // passing a Dayjs object to a constructor will also clone it
            /// </code>
            /// Docs: https://day.js.org/docs/en/parse/dayjs-clone
            /// </summary>
            abstract member clone: unit -> Dayjs.dayjs_.Dayjs
            /// <summary>
            /// This returns a <c>boolean</c> indicating whether the Day.js object contains a valid date or not.
            /// <code>
            /// dayjs().isValid()// => boolean
            /// </code>
            /// Docs: https://day.js.org/docs/en/parse/is-valid
            /// </summary>
            abstract member isValid: unit -> bool
            /// <summary>
            /// Get the year.
            /// <code>
            /// dayjs().year()// => 2020
            /// </code>
            /// Docs: https://day.js.org/docs/en/get-set/year
            /// Set the year.
            /// <code>
            /// dayjs().year(2000)// => Dayjs
            /// </code>
            /// Docs: https://day.js.org/docs/en/get-set/year
            /// </summary>
            abstract member year: unit -> float
            /// <summary>
            /// Get the year.
            /// <code>
            /// dayjs().year()// => 2020
            /// </code>
            /// Docs: https://day.js.org/docs/en/get-set/year
            /// Set the year.
            /// <code>
            /// dayjs().year(2000)// => Dayjs
            /// </code>
            /// Docs: https://day.js.org/docs/en/get-set/year
            /// </summary>
            abstract member year: value: float -> Dayjs.dayjs_.Dayjs
            /// <summary>
            /// Get the month.
            ///
            /// Months are zero indexed, so January is month 0.
            /// <code>
            /// dayjs().month()// => 0-11
            /// </code>
            /// Docs: https://day.js.org/docs/en/get-set/month
            /// Set the month.
            ///
            /// Months are zero indexed, so January is month 0.
            ///
            /// Accepts numbers from 0 to 11. If the range is exceeded, it will bubble up to the next year.
            /// <code>
            /// dayjs().month(0)// => Dayjs
            /// </code>
            /// Docs: https://day.js.org/docs/en/get-set/month
            /// </summary>
            abstract member month: unit -> float
            /// <summary>
            /// Get the month.
            ///
            /// Months are zero indexed, so January is month 0.
            /// <code>
            /// dayjs().month()// => 0-11
            /// </code>
            /// Docs: https://day.js.org/docs/en/get-set/month
            /// Set the month.
            ///
            /// Months are zero indexed, so January is month 0.
            ///
            /// Accepts numbers from 0 to 11. If the range is exceeded, it will bubble up to the next year.
            /// <code>
            /// dayjs().month(0)// => Dayjs
            /// </code>
            /// Docs: https://day.js.org/docs/en/get-set/month
            /// </summary>
            abstract member month: value: float -> Dayjs.dayjs_.Dayjs
            /// <summary>
            /// Get the date of the month.
            /// <code>
            /// dayjs().date()// => 1-31
            /// </code>
            /// Docs: https://day.js.org/docs/en/get-set/date
            /// Set the date of the month.
            ///
            /// Accepts numbers from 1 to 31. If the range is exceeded, it will bubble up to the next months.
            /// <code>
            /// dayjs().date(1)// => Dayjs
            /// </code>
            /// Docs: https://day.js.org/docs/en/get-set/date
            /// </summary>
            abstract member date: unit -> float
            /// <summary>
            /// Get the date of the month.
            /// <code>
            /// dayjs().date()// => 1-31
            /// </code>
            /// Docs: https://day.js.org/docs/en/get-set/date
            /// Set the date of the month.
            ///
            /// Accepts numbers from 1 to 31. If the range is exceeded, it will bubble up to the next months.
            /// <code>
            /// dayjs().date(1)// => Dayjs
            /// </code>
            /// Docs: https://day.js.org/docs/en/get-set/date
            /// </summary>
            abstract member date: value: float -> Dayjs.dayjs_.Dayjs
            /// <summary>
            /// Get the day of the week.
            ///
            /// Returns numbers from 0 (Sunday) to 6 (Saturday).
            /// <code>
            /// dayjs().day()// 0-6
            /// </code>
            /// Docs: https://day.js.org/docs/en/get-set/day
            /// Set the day of the week.
            ///
            /// Accepts numbers from 0 (Sunday) to 6 (Saturday). If the range is exceeded, it will bubble up to next weeks.
            /// <code>
            /// dayjs().day(0)// => Dayjs
            /// </code>
            /// Docs: https://day.js.org/docs/en/get-set/day
            /// </summary>
            abstract member day: unit -> Dayjs.day
            /// <summary>
            /// Get the day of the week.
            ///
            /// Returns numbers from 0 (Sunday) to 6 (Saturday).
            /// <code>
            /// dayjs().day()// 0-6
            /// </code>
            /// Docs: https://day.js.org/docs/en/get-set/day
            /// Set the day of the week.
            ///
            /// Accepts numbers from 0 (Sunday) to 6 (Saturday). If the range is exceeded, it will bubble up to next weeks.
            /// <code>
            /// dayjs().day(0)// => Dayjs
            /// </code>
            /// Docs: https://day.js.org/docs/en/get-set/day
            /// </summary>
            abstract member day: value: float -> Dayjs.dayjs_.Dayjs
            /// <summary>
            /// Get the hour.
            /// <code>
            /// dayjs().hour()// => 0-23
            /// </code>
            /// Docs: https://day.js.org/docs/en/get-set/hour
            /// Set the hour.
            ///
            /// Accepts numbers from 0 to 23. If the range is exceeded, it will bubble up to the next day.
            /// <code>
            /// dayjs().hour(12)// => Dayjs
            /// </code>
            /// Docs: https://day.js.org/docs/en/get-set/hour
            /// </summary>
            abstract member hour: unit -> float
            /// <summary>
            /// Get the hour.
            /// <code>
            /// dayjs().hour()// => 0-23
            /// </code>
            /// Docs: https://day.js.org/docs/en/get-set/hour
            /// Set the hour.
            ///
            /// Accepts numbers from 0 to 23. If the range is exceeded, it will bubble up to the next day.
            /// <code>
            /// dayjs().hour(12)// => Dayjs
            /// </code>
            /// Docs: https://day.js.org/docs/en/get-set/hour
            /// </summary>
            abstract member hour: value: float -> Dayjs.dayjs_.Dayjs
            /// <summary>
            /// Get the minutes.
            /// <code>
            /// dayjs().minute()// => 0-59
            /// </code>
            /// Docs: https://day.js.org/docs/en/get-set/minute
            /// Set the minutes.
            ///
            /// Accepts numbers from 0 to 59. If the range is exceeded, it will bubble up to the next hour.
            /// <code>
            /// dayjs().minute(59)// => Dayjs
            /// </code>
            /// Docs: https://day.js.org/docs/en/get-set/minute
            /// </summary>
            abstract member minute: unit -> float
            /// <summary>
            /// Get the minutes.
            /// <code>
            /// dayjs().minute()// => 0-59
            /// </code>
            /// Docs: https://day.js.org/docs/en/get-set/minute
            /// Set the minutes.
            ///
            /// Accepts numbers from 0 to 59. If the range is exceeded, it will bubble up to the next hour.
            /// <code>
            /// dayjs().minute(59)// => Dayjs
            /// </code>
            /// Docs: https://day.js.org/docs/en/get-set/minute
            /// </summary>
            abstract member minute: value: float -> Dayjs.dayjs_.Dayjs
            /// <summary>
            /// Get the seconds.
            /// <code>
            /// dayjs().second()// => 0-59
            /// </code>
            /// Docs: https://day.js.org/docs/en/get-set/second
            /// Set the seconds.
            ///
            /// Accepts numbers from 0 to 59. If the range is exceeded, it will bubble up to the next minutes.
            /// <code>
            /// dayjs().second(1)// Dayjs
            /// </code>
            /// </summary>
            abstract member second: unit -> float
            /// <summary>
            /// Get the seconds.
            /// <code>
            /// dayjs().second()// => 0-59
            /// </code>
            /// Docs: https://day.js.org/docs/en/get-set/second
            /// Set the seconds.
            ///
            /// Accepts numbers from 0 to 59. If the range is exceeded, it will bubble up to the next minutes.
            /// <code>
            /// dayjs().second(1)// Dayjs
            /// </code>
            /// </summary>
            abstract member second: value: float -> Dayjs.dayjs_.Dayjs
            /// <summary>
            /// Get the milliseconds.
            /// <code>
            /// dayjs().millisecond()// => 0-999
            /// </code>
            /// Docs: https://day.js.org/docs/en/get-set/millisecond
            /// Set the milliseconds.
            ///
            /// Accepts numbers from 0 to 999. If the range is exceeded, it will bubble up to the next seconds.
            /// <code>
            /// dayjs().millisecond(1)// => Dayjs
            /// </code>
            /// Docs: https://day.js.org/docs/en/get-set/millisecond
            /// </summary>
            abstract member millisecond: unit -> float
            /// <summary>
            /// Get the milliseconds.
            /// <code>
            /// dayjs().millisecond()// => 0-999
            /// </code>
            /// Docs: https://day.js.org/docs/en/get-set/millisecond
            /// Set the milliseconds.
            ///
            /// Accepts numbers from 0 to 999. If the range is exceeded, it will bubble up to the next seconds.
            /// <code>
            /// dayjs().millisecond(1)// => Dayjs
            /// </code>
            /// Docs: https://day.js.org/docs/en/get-set/millisecond
            /// </summary>
            abstract member millisecond: value: float -> Dayjs.dayjs_.Dayjs
            /// <summary>
            /// Generic setter, accepting unit as first argument, and value as second, returns a new instance with the applied changes.
            ///
            /// In general:
            /// <code>
            /// dayjs().set(unit, value) === dayjs()[unit](value)
            /// </code>
            /// Units are case insensitive, and support plural and short forms.
            /// <code>
            /// dayjs().set('date', 1)
            /// dayjs().set('month', 3) // April
            /// dayjs().set('second', 30)
            /// </code>
            /// Docs: https://day.js.org/docs/en/get-set/set
            /// </summary>
            abstract member set: unit: Dayjs.dayjs_.UnitTypeLong * value: float -> Dayjs.dayjs_.Dayjs
            /// <summary>
            /// Generic setter, accepting unit as first argument, and value as second, returns a new instance with the applied changes.
            ///
            /// In general:
            /// <code>
            /// dayjs().set(unit, value) === dayjs()[unit](value)
            /// </code>
            /// Units are case insensitive, and support plural and short forms.
            /// <code>
            /// dayjs().set('date', 1)
            /// dayjs().set('month', 3) // April
            /// dayjs().set('second', 30)
            /// </code>
            /// Docs: https://day.js.org/docs/en/get-set/set
            /// </summary>
            abstract member set: unit: Dayjs.dayjs_.UnitTypeLongPlural * value: float -> Dayjs.dayjs_.Dayjs
            /// <summary>
            /// Generic setter, accepting unit as first argument, and value as second, returns a new instance with the applied changes.
            ///
            /// In general:
            /// <code>
            /// dayjs().set(unit, value) === dayjs()[unit](value)
            /// </code>
            /// Units are case insensitive, and support plural and short forms.
            /// <code>
            /// dayjs().set('date', 1)
            /// dayjs().set('month', 3) // April
            /// dayjs().set('second', 30)
            /// </code>
            /// Docs: https://day.js.org/docs/en/get-set/set
            /// </summary>
            abstract member set: unit: Dayjs.dayjs_.UnitTypeShort * value: float -> Dayjs.dayjs_.Dayjs
            /// <summary>
            /// Generic setter, accepting unit as first argument, and value as second, returns a new instance with the applied changes.
            ///
            /// In general:
            /// <code>
            /// dayjs().set(unit, value) === dayjs()[unit](value)
            /// </code>
            /// Units are case insensitive, and support plural and short forms.
            /// <code>
            /// dayjs().set('date', 1)
            /// dayjs().set('month', 3) // April
            /// dayjs().set('second', 30)
            /// </code>
            /// Docs: https://day.js.org/docs/en/get-set/set
            /// </summary>
            abstract member set: unit: Dayjs.dayjs_.UnitType * value: float -> Dayjs.dayjs_.Dayjs
            /// <summary>
            /// String getter, returns the corresponding information getting from Day.js object.
            ///
            /// In general:
            /// <code>
            /// dayjs().get(unit) === dayjs()[unit]()
            /// </code>
            /// Units are case insensitive, and support plural and short forms.
            /// <code>
            /// dayjs().get('year')
            /// dayjs().get('month') // start 0
            /// dayjs().get('date')
            /// </code>
            /// Docs: https://day.js.org/docs/en/get-set/get
            /// </summary>
            abstract member get: unit: Dayjs.dayjs_.UnitTypeLong -> float
            /// <summary>
            /// String getter, returns the corresponding information getting from Day.js object.
            ///
            /// In general:
            /// <code>
            /// dayjs().get(unit) === dayjs()[unit]()
            /// </code>
            /// Units are case insensitive, and support plural and short forms.
            /// <code>
            /// dayjs().get('year')
            /// dayjs().get('month') // start 0
            /// dayjs().get('date')
            /// </code>
            /// Docs: https://day.js.org/docs/en/get-set/get
            /// </summary>
            abstract member get: unit: Dayjs.dayjs_.UnitTypeLongPlural -> float
            /// <summary>
            /// String getter, returns the corresponding information getting from Day.js object.
            ///
            /// In general:
            /// <code>
            /// dayjs().get(unit) === dayjs()[unit]()
            /// </code>
            /// Units are case insensitive, and support plural and short forms.
            /// <code>
            /// dayjs().get('year')
            /// dayjs().get('month') // start 0
            /// dayjs().get('date')
            /// </code>
            /// Docs: https://day.js.org/docs/en/get-set/get
            /// </summary>
            abstract member get: unit: Dayjs.dayjs_.UnitTypeShort -> float
            /// <summary>
            /// String getter, returns the corresponding information getting from Day.js object.
            ///
            /// In general:
            /// <code>
            /// dayjs().get(unit) === dayjs()[unit]()
            /// </code>
            /// Units are case insensitive, and support plural and short forms.
            /// <code>
            /// dayjs().get('year')
            /// dayjs().get('month') // start 0
            /// dayjs().get('date')
            /// </code>
            /// Docs: https://day.js.org/docs/en/get-set/get
            /// </summary>
            abstract member get: unit: Dayjs.dayjs_.UnitType -> float
            /// <summary>
            /// Returns a cloned Day.js object with a specified amount of time added.
            /// <code>
            /// dayjs().add(7, 'day')// => Dayjs
            /// </code>
            /// Units are case insensitive, and support plural and short forms.
            ///
            /// Docs: https://day.js.org/docs/en/manipulate/add
            /// </summary>
            abstract member add: value: float * ?unit: Dayjs.dayjs_.ManipulateType -> Dayjs.dayjs_.Dayjs
            /// <summary>
            /// Returns a cloned Day.js object with a specified amount of time subtracted.
            /// <code>
            /// dayjs().subtract(7, 'year')// => Dayjs
            /// </code>
            /// Units are case insensitive, and support plural and short forms.
            ///
            /// Docs: https://day.js.org/docs/en/manipulate/subtract
            /// </summary>
            abstract member subtract: value: float * ?unit: Dayjs.dayjs_.ManipulateType -> Dayjs.dayjs_.Dayjs
            /// <summary>
            /// Returns a cloned Day.js object and set it to the start of a unit of time.
            /// <code>
            /// dayjs().startOf('year')// => Dayjs
            /// </code>
            /// Units are case insensitive, and support plural and short forms.
            ///
            /// Docs: https://day.js.org/docs/en/manipulate/start-of
            /// </summary>
            abstract member startOf: unit: Dayjs.dayjs_.OpUnitType -> Dayjs.dayjs_.Dayjs
            /// <summary>
            /// Returns a cloned Day.js object and set it to the end of a unit of time.
            /// <code>
            /// dayjs().endOf('month')// => Dayjs
            /// </code>
            /// Units are case insensitive, and support plural and short forms.
            ///
            /// Docs: https://day.js.org/docs/en/manipulate/end-of
            /// </summary>
            abstract member endOf: unit: Dayjs.dayjs_.OpUnitType -> Dayjs.dayjs_.Dayjs
            /// <summary>
            /// Get the formatted date according to the string of tokens passed in.
            ///
            /// To escape characters, wrap them in square brackets (e.g. [MM]).
            /// <code>
            /// dayjs().format()// => current date in ISO8601, without fraction seconds e.g. '2020-04-02T08:02:17-05:00'
            /// dayjs('2019-01-25').format('[YYYYescape] YYYY-MM-DDTHH:mm:ssZ[Z]')// 'YYYYescape 2019-01-25T00:00:00-02:00Z'
            /// dayjs('2019-01-25').format('DD/MM/YYYY') // '25/01/2019'
            /// </code>
            /// Docs: https://day.js.org/docs/en/display/format
            /// </summary>
            abstract member format: ?template: string -> string
            /// <summary>
            /// This indicates the difference between two date-time in the specified unit.
            ///
            /// To get the difference in milliseconds, use <c>dayjs#diff</c>
            /// <code>
            /// const date1 = dayjs('2019-01-25')
            /// const date2 = dayjs('2018-06-05')
            /// date1.diff(date2) // 20214000000 default milliseconds
            /// date1.diff() // milliseconds to current time
            /// </code>
            ///
            /// To get the difference in another unit of measurement, pass that measurement as the second argument.
            /// <code>
            /// const date1 = dayjs('2019-01-25')
            /// date1.diff('2018-06-05', 'month') // 7
            /// </code>
            /// Units are case insensitive, and support plural and short forms.
            ///
            /// Docs: https://day.js.org/docs/en/display/difference
            /// </summary>
            abstract member diff: unit -> float
            /// <summary>
            /// This indicates the difference between two date-time in the specified unit.
            ///
            /// To get the difference in milliseconds, use <c>dayjs#diff</c>
            /// <code>
            /// const date1 = dayjs('2019-01-25')
            /// const date2 = dayjs('2018-06-05')
            /// date1.diff(date2) // 20214000000 default milliseconds
            /// date1.diff() // milliseconds to current time
            /// </code>
            ///
            /// To get the difference in another unit of measurement, pass that measurement as the second argument.
            /// <code>
            /// const date1 = dayjs('2019-01-25')
            /// date1.diff('2018-06-05', 'month') // 7
            /// </code>
            /// Units are case insensitive, and support plural and short forms.
            ///
            /// Docs: https://day.js.org/docs/en/display/difference
            /// </summary>
            abstract member diff: date: string -> float
            /// <summary>
            /// This indicates the difference between two date-time in the specified unit.
            ///
            /// To get the difference in milliseconds, use <c>dayjs#diff</c>
            /// <code>
            /// const date1 = dayjs('2019-01-25')
            /// const date2 = dayjs('2018-06-05')
            /// date1.diff(date2) // 20214000000 default milliseconds
            /// date1.diff() // milliseconds to current time
            /// </code>
            ///
            /// To get the difference in another unit of measurement, pass that measurement as the second argument.
            /// <code>
            /// const date1 = dayjs('2019-01-25')
            /// date1.diff('2018-06-05', 'month') // 7
            /// </code>
            /// Units are case insensitive, and support plural and short forms.
            ///
            /// Docs: https://day.js.org/docs/en/display/difference
            /// </summary>
            abstract member diff: date: string * unit: Dayjs.dayjs_.QUnitType * ?float: bool -> float
            /// <summary>
            /// This indicates the difference between two date-time in the specified unit.
            ///
            /// To get the difference in milliseconds, use <c>dayjs#diff</c>
            /// <code>
            /// const date1 = dayjs('2019-01-25')
            /// const date2 = dayjs('2018-06-05')
            /// date1.diff(date2) // 20214000000 default milliseconds
            /// date1.diff() // milliseconds to current time
            /// </code>
            ///
            /// To get the difference in another unit of measurement, pass that measurement as the second argument.
            /// <code>
            /// const date1 = dayjs('2019-01-25')
            /// date1.diff('2018-06-05', 'month') // 7
            /// </code>
            /// Units are case insensitive, and support plural and short forms.
            ///
            /// Docs: https://day.js.org/docs/en/display/difference
            /// </summary>
            abstract member diff: date: string * unit: Dayjs.dayjs_.OpUnitType * ?float: bool -> float
            /// <summary>
            /// This indicates the difference between two date-time in the specified unit.
            ///
            /// To get the difference in milliseconds, use <c>dayjs#diff</c>
            /// <code>
            /// const date1 = dayjs('2019-01-25')
            /// const date2 = dayjs('2018-06-05')
            /// date1.diff(date2) // 20214000000 default milliseconds
            /// date1.diff() // milliseconds to current time
            /// </code>
            ///
            /// To get the difference in another unit of measurement, pass that measurement as the second argument.
            /// <code>
            /// const date1 = dayjs('2019-01-25')
            /// date1.diff('2018-06-05', 'month') // 7
            /// </code>
            /// Units are case insensitive, and support plural and short forms.
            ///
            /// Docs: https://day.js.org/docs/en/display/difference
            /// </summary>
            abstract member diff: date: float -> float
            /// <summary>
            /// This indicates the difference between two date-time in the specified unit.
            ///
            /// To get the difference in milliseconds, use <c>dayjs#diff</c>
            /// <code>
            /// const date1 = dayjs('2019-01-25')
            /// const date2 = dayjs('2018-06-05')
            /// date1.diff(date2) // 20214000000 default milliseconds
            /// date1.diff() // milliseconds to current time
            /// </code>
            ///
            /// To get the difference in another unit of measurement, pass that measurement as the second argument.
            /// <code>
            /// const date1 = dayjs('2019-01-25')
            /// date1.diff('2018-06-05', 'month') // 7
            /// </code>
            /// Units are case insensitive, and support plural and short forms.
            ///
            /// Docs: https://day.js.org/docs/en/display/difference
            /// </summary>
            abstract member diff: date: float * unit: Dayjs.dayjs_.QUnitType * ?float: bool -> float
            /// <summary>
            /// This indicates the difference between two date-time in the specified unit.
            ///
            /// To get the difference in milliseconds, use <c>dayjs#diff</c>
            /// <code>
            /// const date1 = dayjs('2019-01-25')
            /// const date2 = dayjs('2018-06-05')
            /// date1.diff(date2) // 20214000000 default milliseconds
            /// date1.diff() // milliseconds to current time
            /// </code>
            ///
            /// To get the difference in another unit of measurement, pass that measurement as the second argument.
            /// <code>
            /// const date1 = dayjs('2019-01-25')
            /// date1.diff('2018-06-05', 'month') // 7
            /// </code>
            /// Units are case insensitive, and support plural and short forms.
            ///
            /// Docs: https://day.js.org/docs/en/display/difference
            /// </summary>
            abstract member diff: date: float * unit: Dayjs.dayjs_.OpUnitType * ?float: bool -> float
            /// <summary>
            /// This indicates the difference between two date-time in the specified unit.
            ///
            /// To get the difference in milliseconds, use <c>dayjs#diff</c>
            /// <code>
            /// const date1 = dayjs('2019-01-25')
            /// const date2 = dayjs('2018-06-05')
            /// date1.diff(date2) // 20214000000 default milliseconds
            /// date1.diff() // milliseconds to current time
            /// </code>
            ///
            /// To get the difference in another unit of measurement, pass that measurement as the second argument.
            /// <code>
            /// const date1 = dayjs('2019-01-25')
            /// date1.diff('2018-06-05', 'month') // 7
            /// </code>
            /// Units are case insensitive, and support plural and short forms.
            ///
            /// Docs: https://day.js.org/docs/en/display/difference
            /// </summary>
            abstract member diff: date: Date -> float
            /// <summary>
            /// This indicates the difference between two date-time in the specified unit.
            ///
            /// To get the difference in milliseconds, use <c>dayjs#diff</c>
            /// <code>
            /// const date1 = dayjs('2019-01-25')
            /// const date2 = dayjs('2018-06-05')
            /// date1.diff(date2) // 20214000000 default milliseconds
            /// date1.diff() // milliseconds to current time
            /// </code>
            ///
            /// To get the difference in another unit of measurement, pass that measurement as the second argument.
            /// <code>
            /// const date1 = dayjs('2019-01-25')
            /// date1.diff('2018-06-05', 'month') // 7
            /// </code>
            /// Units are case insensitive, and support plural and short forms.
            ///
            /// Docs: https://day.js.org/docs/en/display/difference
            /// </summary>
            abstract member diff: date: Date * unit: Dayjs.dayjs_.QUnitType * ?float: bool -> float
            /// <summary>
            /// This indicates the difference between two date-time in the specified unit.
            ///
            /// To get the difference in milliseconds, use <c>dayjs#diff</c>
            /// <code>
            /// const date1 = dayjs('2019-01-25')
            /// const date2 = dayjs('2018-06-05')
            /// date1.diff(date2) // 20214000000 default milliseconds
            /// date1.diff() // milliseconds to current time
            /// </code>
            ///
            /// To get the difference in another unit of measurement, pass that measurement as the second argument.
            /// <code>
            /// const date1 = dayjs('2019-01-25')
            /// date1.diff('2018-06-05', 'month') // 7
            /// </code>
            /// Units are case insensitive, and support plural and short forms.
            ///
            /// Docs: https://day.js.org/docs/en/display/difference
            /// </summary>
            abstract member diff: date: Date * unit: Dayjs.dayjs_.OpUnitType * ?float: bool -> float
            /// <summary>
            /// This indicates the difference between two date-time in the specified unit.
            ///
            /// To get the difference in milliseconds, use <c>dayjs#diff</c>
            /// <code>
            /// const date1 = dayjs('2019-01-25')
            /// const date2 = dayjs('2018-06-05')
            /// date1.diff(date2) // 20214000000 default milliseconds
            /// date1.diff() // milliseconds to current time
            /// </code>
            ///
            /// To get the difference in another unit of measurement, pass that measurement as the second argument.
            /// <code>
            /// const date1 = dayjs('2019-01-25')
            /// date1.diff('2018-06-05', 'month') // 7
            /// </code>
            /// Units are case insensitive, and support plural and short forms.
            ///
            /// Docs: https://day.js.org/docs/en/display/difference
            /// </summary>
            abstract member diff: date: Dayjs.dayjs_.Dayjs -> float
            /// <summary>
            /// This indicates the difference between two date-time in the specified unit.
            ///
            /// To get the difference in milliseconds, use <c>dayjs#diff</c>
            /// <code>
            /// const date1 = dayjs('2019-01-25')
            /// const date2 = dayjs('2018-06-05')
            /// date1.diff(date2) // 20214000000 default milliseconds
            /// date1.diff() // milliseconds to current time
            /// </code>
            ///
            /// To get the difference in another unit of measurement, pass that measurement as the second argument.
            /// <code>
            /// const date1 = dayjs('2019-01-25')
            /// date1.diff('2018-06-05', 'month') // 7
            /// </code>
            /// Units are case insensitive, and support plural and short forms.
            ///
            /// Docs: https://day.js.org/docs/en/display/difference
            /// </summary>
            abstract member diff: date: Dayjs.dayjs_.Dayjs * unit: Dayjs.dayjs_.QUnitType * ?float: bool -> float
            /// <summary>
            /// This indicates the difference between two date-time in the specified unit.
            ///
            /// To get the difference in milliseconds, use <c>dayjs#diff</c>
            /// <code>
            /// const date1 = dayjs('2019-01-25')
            /// const date2 = dayjs('2018-06-05')
            /// date1.diff(date2) // 20214000000 default milliseconds
            /// date1.diff() // milliseconds to current time
            /// </code>
            ///
            /// To get the difference in another unit of measurement, pass that measurement as the second argument.
            /// <code>
            /// const date1 = dayjs('2019-01-25')
            /// date1.diff('2018-06-05', 'month') // 7
            /// </code>
            /// Units are case insensitive, and support plural and short forms.
            ///
            /// Docs: https://day.js.org/docs/en/display/difference
            /// </summary>
            abstract member diff: date: Dayjs.dayjs_.Dayjs * unit: Dayjs.dayjs_.OpUnitType * ?float: bool -> float
            /// <summary>
            /// This returns the number of **milliseconds** since the Unix Epoch of the Day.js object.
            /// <code>
            /// dayjs('2019-01-25').valueOf() // 1548381600000
            /// +dayjs(1548381600000) // 1548381600000
            /// </code>
            /// To get a Unix timestamp (the number of seconds since the epoch) from a Day.js object, you should use Unix Timestamp <c>dayjs#unix()</c>.
            ///
            /// Docs: https://day.js.org/docs/en/display/unix-timestamp-milliseconds
            /// </summary>
            abstract member valueOf: unit -> float
            /// <summary>
            /// This returns the Unix timestamp (the number of **seconds** since the Unix Epoch) of the Day.js object.
            /// <code>
            /// dayjs('2019-01-25').unix() // 1548381600
            /// </code>
            /// This value is floored to the nearest second, and does not include a milliseconds component.
            ///
            /// Docs: https://day.js.org/docs/en/display/unix-timestamp
            /// </summary>
            abstract member unix: unit -> float
            /// <summary>
            /// Get the number of days in the current month.
            /// <code>
            /// dayjs('2019-01-25').daysInMonth() // 31
            /// </code>
            /// Docs: https://day.js.org/docs/en/display/days-in-month
            /// </summary>
            abstract member daysInMonth: unit -> float
            /// <summary>
            /// To get a copy of the native <c>Date</c> object parsed from the Day.js object use <c>dayjs#toDate</c>.
            /// <code>
            /// dayjs('2019-01-25').toDate()// => Date
            /// </code>
            /// </summary>
            abstract member toDate: unit -> Date
            /// <summary>
            /// To serialize as an ISO 8601 string.
            /// <code>
            /// dayjs('2019-01-25').toJSON() // '2019-01-25T02:00:00.000Z'
            /// </code>
            /// Docs: https://day.js.org/docs/en/display/as-json
            /// </summary>
            abstract member toJSON: unit -> string
            /// <summary>
            /// To format as an ISO 8601 string.
            /// <code>
            /// dayjs('2019-01-25').toISOString() // '2019-01-25T02:00:00.000Z'
            /// </code>
            /// Docs: https://day.js.org/docs/en/display/as-iso-string
            /// </summary>
            abstract member toISOString: unit -> string
            /// <summary>
            /// Returns a string representation of the date.
            /// <code>
            /// dayjs('2019-01-25').toString() // 'Fri, 25 Jan 2019 02:00:00 GMT'
            /// </code>
            /// Docs: https://day.js.org/docs/en/display/as-string
            /// </summary>
            abstract member toString: unit -> string
            /// <summary>
            /// Get the UTC offset in minutes.
            /// <code>
            /// dayjs().utcOffset()
            /// </code>
            /// Docs: https://day.js.org/docs/en/manipulate/utc-offset
            /// </summary>
            abstract member utcOffset: unit -> float
            /// <summary>
            /// This indicates whether the Day.js object is before the other supplied date-time.
            /// <code>
            /// dayjs().isBefore(dayjs('2011-01-01')) // default milliseconds
            /// </code>
            /// If you want to limit the granularity to a unit other than milliseconds, pass it as the second parameter.
            /// <code>
            /// dayjs().isBefore('2011-01-01', 'year')// => boolean
            /// </code>
            /// Units are case insensitive, and support plural and short forms.
            ///
            /// Docs: https://day.js.org/docs/en/query/is-before
            /// </summary>
            abstract member isBefore: unit -> bool
            /// <summary>
            /// This indicates whether the Day.js object is before the other supplied date-time.
            /// <code>
            /// dayjs().isBefore(dayjs('2011-01-01')) // default milliseconds
            /// </code>
            /// If you want to limit the granularity to a unit other than milliseconds, pass it as the second parameter.
            /// <code>
            /// dayjs().isBefore('2011-01-01', 'year')// => boolean
            /// </code>
            /// Units are case insensitive, and support plural and short forms.
            ///
            /// Docs: https://day.js.org/docs/en/query/is-before
            /// </summary>
            abstract member isBefore: date: string * ?unit: Dayjs.dayjs_.OpUnitType -> bool
            /// <summary>
            /// This indicates whether the Day.js object is before the other supplied date-time.
            /// <code>
            /// dayjs().isBefore(dayjs('2011-01-01')) // default milliseconds
            /// </code>
            /// If you want to limit the granularity to a unit other than milliseconds, pass it as the second parameter.
            /// <code>
            /// dayjs().isBefore('2011-01-01', 'year')// => boolean
            /// </code>
            /// Units are case insensitive, and support plural and short forms.
            ///
            /// Docs: https://day.js.org/docs/en/query/is-before
            /// </summary>
            abstract member isBefore: date: float * ?unit: Dayjs.dayjs_.OpUnitType -> bool
            /// <summary>
            /// This indicates whether the Day.js object is before the other supplied date-time.
            /// <code>
            /// dayjs().isBefore(dayjs('2011-01-01')) // default milliseconds
            /// </code>
            /// If you want to limit the granularity to a unit other than milliseconds, pass it as the second parameter.
            /// <code>
            /// dayjs().isBefore('2011-01-01', 'year')// => boolean
            /// </code>
            /// Units are case insensitive, and support plural and short forms.
            ///
            /// Docs: https://day.js.org/docs/en/query/is-before
            /// </summary>
            abstract member isBefore: date: Date * ?unit: Dayjs.dayjs_.OpUnitType -> bool
            /// <summary>
            /// This indicates whether the Day.js object is before the other supplied date-time.
            /// <code>
            /// dayjs().isBefore(dayjs('2011-01-01')) // default milliseconds
            /// </code>
            /// If you want to limit the granularity to a unit other than milliseconds, pass it as the second parameter.
            /// <code>
            /// dayjs().isBefore('2011-01-01', 'year')// => boolean
            /// </code>
            /// Units are case insensitive, and support plural and short forms.
            ///
            /// Docs: https://day.js.org/docs/en/query/is-before
            /// </summary>
            abstract member isBefore: date: Dayjs.dayjs_.Dayjs * ?unit: Dayjs.dayjs_.OpUnitType -> bool
            /// <summary>
            /// This indicates whether the Day.js object is the same as the other supplied date-time.
            /// <code>
            /// dayjs().isSame(dayjs('2011-01-01')) // default milliseconds
            /// </code>
            /// If you want to limit the granularity to a unit other than milliseconds, pass it as the second parameter.
            /// <code>
            /// dayjs().isSame('2011-01-01', 'year')// => boolean
            /// </code>
            /// Docs: https://day.js.org/docs/en/query/is-same
            /// </summary>
            abstract member isSame: unit -> bool
            /// <summary>
            /// This indicates whether the Day.js object is the same as the other supplied date-time.
            /// <code>
            /// dayjs().isSame(dayjs('2011-01-01')) // default milliseconds
            /// </code>
            /// If you want to limit the granularity to a unit other than milliseconds, pass it as the second parameter.
            /// <code>
            /// dayjs().isSame('2011-01-01', 'year')// => boolean
            /// </code>
            /// Docs: https://day.js.org/docs/en/query/is-same
            /// </summary>
            abstract member isSame: date: string * ?unit: Dayjs.dayjs_.OpUnitType -> bool
            /// <summary>
            /// This indicates whether the Day.js object is the same as the other supplied date-time.
            /// <code>
            /// dayjs().isSame(dayjs('2011-01-01')) // default milliseconds
            /// </code>
            /// If you want to limit the granularity to a unit other than milliseconds, pass it as the second parameter.
            /// <code>
            /// dayjs().isSame('2011-01-01', 'year')// => boolean
            /// </code>
            /// Docs: https://day.js.org/docs/en/query/is-same
            /// </summary>
            abstract member isSame: date: float * ?unit: Dayjs.dayjs_.OpUnitType -> bool
            /// <summary>
            /// This indicates whether the Day.js object is the same as the other supplied date-time.
            /// <code>
            /// dayjs().isSame(dayjs('2011-01-01')) // default milliseconds
            /// </code>
            /// If you want to limit the granularity to a unit other than milliseconds, pass it as the second parameter.
            /// <code>
            /// dayjs().isSame('2011-01-01', 'year')// => boolean
            /// </code>
            /// Docs: https://day.js.org/docs/en/query/is-same
            /// </summary>
            abstract member isSame: date: Date * ?unit: Dayjs.dayjs_.OpUnitType -> bool
            /// <summary>
            /// This indicates whether the Day.js object is the same as the other supplied date-time.
            /// <code>
            /// dayjs().isSame(dayjs('2011-01-01')) // default milliseconds
            /// </code>
            /// If you want to limit the granularity to a unit other than milliseconds, pass it as the second parameter.
            /// <code>
            /// dayjs().isSame('2011-01-01', 'year')// => boolean
            /// </code>
            /// Docs: https://day.js.org/docs/en/query/is-same
            /// </summary>
            abstract member isSame: date: Dayjs.dayjs_.Dayjs * ?unit: Dayjs.dayjs_.OpUnitType -> bool
            /// <summary>
            /// This indicates whether the Day.js object is after the other supplied date-time.
            /// <code>
            /// dayjs().isAfter(dayjs('2011-01-01')) // default milliseconds
            /// </code>
            /// If you want to limit the granularity to a unit other than milliseconds, pass it as the second parameter.
            /// <code>
            /// dayjs().isAfter('2011-01-01', 'year')// => boolean
            /// </code>
            /// Units are case insensitive, and support plural and short forms.
            ///
            /// Docs: https://day.js.org/docs/en/query/is-after
            /// </summary>
            abstract member isAfter: unit -> bool
            /// <summary>
            /// This indicates whether the Day.js object is after the other supplied date-time.
            /// <code>
            /// dayjs().isAfter(dayjs('2011-01-01')) // default milliseconds
            /// </code>
            /// If you want to limit the granularity to a unit other than milliseconds, pass it as the second parameter.
            /// <code>
            /// dayjs().isAfter('2011-01-01', 'year')// => boolean
            /// </code>
            /// Units are case insensitive, and support plural and short forms.
            ///
            /// Docs: https://day.js.org/docs/en/query/is-after
            /// </summary>
            abstract member isAfter: date: string * ?unit: Dayjs.dayjs_.OpUnitType -> bool
            /// <summary>
            /// This indicates whether the Day.js object is after the other supplied date-time.
            /// <code>
            /// dayjs().isAfter(dayjs('2011-01-01')) // default milliseconds
            /// </code>
            /// If you want to limit the granularity to a unit other than milliseconds, pass it as the second parameter.
            /// <code>
            /// dayjs().isAfter('2011-01-01', 'year')// => boolean
            /// </code>
            /// Units are case insensitive, and support plural and short forms.
            ///
            /// Docs: https://day.js.org/docs/en/query/is-after
            /// </summary>
            abstract member isAfter: date: float * ?unit: Dayjs.dayjs_.OpUnitType -> bool
            /// <summary>
            /// This indicates whether the Day.js object is after the other supplied date-time.
            /// <code>
            /// dayjs().isAfter(dayjs('2011-01-01')) // default milliseconds
            /// </code>
            /// If you want to limit the granularity to a unit other than milliseconds, pass it as the second parameter.
            /// <code>
            /// dayjs().isAfter('2011-01-01', 'year')// => boolean
            /// </code>
            /// Units are case insensitive, and support plural and short forms.
            ///
            /// Docs: https://day.js.org/docs/en/query/is-after
            /// </summary>
            abstract member isAfter: date: Date * ?unit: Dayjs.dayjs_.OpUnitType -> bool
            /// <summary>
            /// This indicates whether the Day.js object is after the other supplied date-time.
            /// <code>
            /// dayjs().isAfter(dayjs('2011-01-01')) // default milliseconds
            /// </code>
            /// If you want to limit the granularity to a unit other than milliseconds, pass it as the second parameter.
            /// <code>
            /// dayjs().isAfter('2011-01-01', 'year')// => boolean
            /// </code>
            /// Units are case insensitive, and support plural and short forms.
            ///
            /// Docs: https://day.js.org/docs/en/query/is-after
            /// </summary>
            abstract member isAfter: date: Dayjs.dayjs_.Dayjs * ?unit: Dayjs.dayjs_.OpUnitType -> bool
            abstract member locale: unit -> string
            abstract member locale: preset: string * ?``object``: Dayjs.locale.``object`` -> Dayjs.dayjs_.Dayjs
            abstract member locale: preset: Dayjs.ILocale * ?``object``: Dayjs.locale.``object`` -> Dayjs.dayjs_.Dayjs
            abstract member locale: preset: U2<string, Dayjs.ILocale> * ?``object``: Dayjs.locale.``object`` -> Dayjs.dayjs_.Dayjs

        type PluginFunc<'T> =
            delegate of option: 'T * c: Dayjs.dayjs_.Dayjs * d: (Dayjs.dayjs_.ConfigType option -> Dayjs.dayjs_.Dayjs) -> unit

        type PluginFunc =
            PluginFunc<obj>

        module Dayjs =

            [<RequireQualifiedAccess>]
            type day =
                | ``0`` = 0
                | ``1`` = 1
                | ``2`` = 2
                | ``3`` = 3
                | ``4`` = 4
                | ``5`` = 5
                | ``6`` = 6

            module locale =

                [<AllowNullLiteral>]
                [<Interface>]
                type ``object`` =
                    abstract member name: string option with get, set
                    abstract member weekdays: ResizeArray<string> option with get, set
                    abstract member months: ResizeArray<string> option with get, set
                    abstract member weekStart: float option with get, set
                    abstract member weekdaysShort: ResizeArray<string> option with get, set
                    abstract member monthsShort: ResizeArray<string> option with get, set
                    abstract member weekdaysMin: ResizeArray<string> option with get, set
                    abstract member ordinal: (float -> U2<float, string>) option with get, set
                    abstract member formats: Dayjs.locale.``object``.Partial.formats option with get, set
                    abstract member relativeTime: Dayjs.locale.``object``.Partial.relativeTime option with get, set

                module ``object`` =

                    module Partial =

                        [<AllowNullLiteral>]
                        [<Interface>]
                        type formats =
                            abstract member LT: string option with get, set
                            abstract member LTS: string option with get, set
                            abstract member L: string option with get, set
                            abstract member LL: string option with get, set
                            abstract member LLL: string option with get, set
                            abstract member LLLL: string option with get, set

                        [<AllowNullLiteral>]
                        [<Interface>]
                        type relativeTime =
                            abstract member future: string option with get, set
                            abstract member past: string option with get, set
                            abstract member s: string option with get, set
                            abstract member m: string option with get, set
                            abstract member mm: string option with get, set
                            abstract member h: string option with get, set
                            abstract member hh: string option with get, set
                            abstract member d: string option with get, set
                            abstract member dd: string option with get, set
                            abstract member M: string option with get, set
                            abstract member MM: string option with get, set
                            abstract member y: string option with get, set
                            abstract member yy: string option with get, set

        module Exports =

            module locale =

                [<AllowNullLiteral>]
                [<Interface>]
                type ``object`` =
                    abstract member name: string option with get, set
                    abstract member weekdays: ResizeArray<string> option with get, set
                    abstract member months: ResizeArray<string> option with get, set
                    abstract member weekStart: float option with get, set
                    abstract member weekdaysShort: ResizeArray<string> option with get, set
                    abstract member monthsShort: ResizeArray<string> option with get, set
                    abstract member weekdaysMin: ResizeArray<string> option with get, set
                    abstract member ordinal: (float -> U2<float, string>) option with get, set
                    abstract member formats: Exports.locale.``object``.Partial.formats option with get, set
                    abstract member relativeTime: Exports.locale.``object``.Partial.relativeTime option with get, set

                module ``object`` =

                    module Partial =

                        [<AllowNullLiteral>]
                        [<Interface>]
                        type formats =
                            abstract member LT: string option with get, set
                            abstract member LTS: string option with get, set
                            abstract member L: string option with get, set
                            abstract member LL: string option with get, set
                            abstract member LLL: string option with get, set
                            abstract member LLLL: string option with get, set

                        [<AllowNullLiteral>]
                        [<Interface>]
                        type relativeTime =
                            abstract member future: string option with get, set
                            abstract member past: string option with get, set
                            abstract member s: string option with get, set
                            abstract member m: string option with get, set
                            abstract member mm: string option with get, set
                            abstract member h: string option with get, set
                            abstract member hh: string option with get, set
                            abstract member d: string option with get, set
                            abstract member dd: string option with get, set
                            abstract member M: string option with get, set
                            abstract member MM: string option with get, set
                            abstract member y: string option with get, set
                            abstract member yy: string option with get, set

            module Ls =

                [<AllowNullLiteral>]
                [<Interface>]
                type Type =
                    [<EmitIndexer>]
                    abstract member Item: key: string -> Dayjs.ILocale with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type ILocale =
        abstract member name: string with get, set
        abstract member weekdays: ResizeArray<string> option with get, set
        abstract member months: ResizeArray<string> option with get, set
        abstract member weekStart: float option with get, set
        abstract member weekdaysShort: ResizeArray<string> option with get, set
        abstract member monthsShort: ResizeArray<string> option with get, set
        abstract member weekdaysMin: ResizeArray<string> option with get, set
        abstract member ordinal: (float -> U2<float, string>) option with get, set
        abstract member formats: ILocale.formats with get, set
        abstract member relativeTime: ILocale.relativeTime with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (name: string, formats: ILocale.formats, relativeTime: ILocale.relativeTime, ?weekdays: ResizeArray<string>, ?months: ResizeArray<string>, ?weekStart: float, ?weekdaysShort: ResizeArray<string>, ?monthsShort: ResizeArray<string>, ?weekdaysMin: ResizeArray<string>, ?ordinal: (float -> U2<float, string>)) : ILocale = nativeOnly

    module ILocale =

        [<AllowNullLiteral>]
        [<Interface>]
        type formats =
            abstract member LT: string option with get, set
            abstract member LTS: string option with get, set
            abstract member L: string option with get, set
            abstract member LL: string option with get, set
            abstract member LLL: string option with get, set
            abstract member LLLL: string option with get, set

        [<AllowNullLiteral>]
        [<Interface>]
        type relativeTime =
            abstract member future: string option with get, set
            abstract member past: string option with get, set
            abstract member s: string option with get, set
            abstract member m: string option with get, set
            abstract member mm: string option with get, set
            abstract member h: string option with get, set
            abstract member hh: string option with get, set
            abstract member d: string option with get, set
            abstract member dd: string option with get, set
            abstract member M: string option with get, set
            abstract member MM: string option with get, set
            abstract member y: string option with get, set
            abstract member yy: string option with get, set

    module locale =

        [<AbstractClass>]
        [<Erase>]
        type Exports =
            [<ImportDefault("dayjs/locale/*")>]
            static member inline locale: Dayjs.locale.locale_.Locale = nativeOnly

        module locale_ =

            [<AllowNullLiteral>]
            [<Interface>]
            type Locale =
                inherit Dayjs.ILocale
                [<ParamObject; Emit("$0")>]
                static member Create (name: string, formats: Locale.formats, relativeTime: Locale.relativeTime, ?weekdays: ResizeArray<string>, ?months: ResizeArray<string>, ?weekStart: float, ?weekdaysShort: ResizeArray<string>, ?monthsShort: ResizeArray<string>, ?weekdaysMin: ResizeArray<string>, ?ordinal: (float -> U2<float, string>)) : Locale = nativeOnly

            module Locale =

                [<AllowNullLiteral>]
                [<Interface>]
                type formats =
                    abstract member LT: string option with get, set
                    abstract member LTS: string option with get, set
                    abstract member L: string option with get, set
                    abstract member LL: string option with get, set
                    abstract member LLL: string option with get, set
                    abstract member LLLL: string option with get, set

                [<AllowNullLiteral>]
                [<Interface>]
                type relativeTime =
                    abstract member future: string option with get, set
                    abstract member past: string option with get, set
                    abstract member s: string option with get, set
                    abstract member m: string option with get, set
                    abstract member mm: string option with get, set
                    abstract member h: string option with get, set
                    abstract member hh: string option with get, set
                    abstract member d: string option with get, set
                    abstract member dd: string option with get, set
                    abstract member M: string option with get, set
                    abstract member MM: string option with get, set
                    abstract member y: string option with get, set
                    abstract member yy: string option with get, set

        type Locale =
            locale_.Locale

    type ConfigTypeMap =
        dayjs_.ConfigTypeMap

    type ConfigType =
        dayjs_.ConfigType

    type FormatObject =
        dayjs_.FormatObject

    type OptionType =
        dayjs_.OptionType

    type UnitTypeShort =
        dayjs_.UnitTypeShort

    type UnitTypeLong =
        dayjs_.UnitTypeLong

    type UnitTypeLongPlural =
        dayjs_.UnitTypeLongPlural

    type UnitType =
        dayjs_.UnitType

    type OpUnitType =
        dayjs_.OpUnitType

    type QUnitType =
        dayjs_.QUnitType

    type ManipulateType =
        dayjs_.ManipulateType

    type PluginFunc<'T> =
        dayjs_.PluginFunc<'T>

    type PluginFunc =
        PluginFunc<obj>

    module Exports =

        module locale__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type ``object`` =
                abstract member name: string option with get, set
                abstract member weekdays: ResizeArray<string> option with get, set
                abstract member months: ResizeArray<string> option with get, set
                abstract member weekStart: float option with get, set
                abstract member weekdaysShort: ResizeArray<string> option with get, set
                abstract member monthsShort: ResizeArray<string> option with get, set
                abstract member weekdaysMin: ResizeArray<string> option with get, set
                abstract member ordinal: (float -> U2<float, string>) option with get, set
                abstract member formats: Exports.locale__.``object``.Partial.formats option with get, set
                abstract member relativeTime: Exports.locale__.``object``.Partial.relativeTime option with get, set

            module ``object`` =

                module Partial =

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type formats =
                        abstract member LT: string option with get, set
                        abstract member LTS: string option with get, set
                        abstract member L: string option with get, set
                        abstract member LL: string option with get, set
                        abstract member LLL: string option with get, set
                        abstract member LLLL: string option with get, set

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type relativeTime =
                        abstract member future: string option with get, set
                        abstract member past: string option with get, set
                        abstract member s: string option with get, set
                        abstract member m: string option with get, set
                        abstract member mm: string option with get, set
                        abstract member h: string option with get, set
                        abstract member hh: string option with get, set
                        abstract member d: string option with get, set
                        abstract member dd: string option with get, set
                        abstract member M: string option with get, set
                        abstract member MM: string option with get, set
                        abstract member y: string option with get, set
                        abstract member yy: string option with get, set

        module Ls__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type Type =
                [<EmitIndexer>]
                abstract member Item: key: string -> Dayjs.ILocale with get, set
