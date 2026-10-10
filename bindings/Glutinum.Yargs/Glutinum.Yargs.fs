namespace rec Glutinum

open Fable.Core
open Fable.Core.JsInterop
open System

// You need to add Glutinum.Types NuGet package to your project
open Glutinum.Types.TypeScript

type RegExp = Text.RegularExpressions.Regex

module Yargs =

    [<AbstractClass>]
    [<Erase>]
    type Exports =
        [<ImportDefault("yargs")>]
        static member yargs () : Yargs.index.yargs_.Argv = nativeOnly
        [<ImportDefault("yargs")>]
        static member yargs (processArgs: ResizeArray<string>, ?cwd: string, ?parentRequire: Yargs.RequireType) : Yargs.index.yargs_.Argv = nativeOnly
        [<ImportDefault("yargs")>]
        static member yargs (processArgs: string, ?cwd: string, ?parentRequire: Yargs.RequireType) : Yargs.index.yargs_.Argv = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type RequireType =
        [<Emit("$0($1...)")>]
        abstract member Invoke: path: string -> Action
        abstract member main: Yargs.MainType with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type MainType =
        abstract member filename: string with get, set
        abstract member children: ResizeArray<Yargs.MainType> with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (filename: string, children: ResizeArray<Yargs.MainType>) : MainType = nativeOnly

    type Arguments<'T> =
        Yargs.index.yargs_.Arguments<'T>

    type Arguments =
        Arguments<obj>

    type ArgumentsCamelCase<'T> =
        Yargs.index.yargs_.ArgumentsCamelCase<'T>

    type ArgumentsCamelCase =
        ArgumentsCamelCase<obj>

    type Argv<'T> =
        Yargs.index.yargs_.Argv<'T>

    type Argv =
        Argv<obj>

    type AsyncCompletionFunction =
        Yargs.index.yargs_.AsyncCompletionFunction

    type BuilderCallback<'T, 'R> =
        Yargs.index.yargs_.BuilderCallback<'T, 'R>

    type Choices =
        Yargs.index.yargs_.Choices

    type CommandBuilder<'T, 'U> =
        Yargs.index.yargs_.CommandBuilder<'T, 'U>

    type CommandBuilder<'T> =
        CommandBuilder<'T, obj>

    type CommandBuilder =
        CommandBuilder<obj, obj>

    type CommandModule<'T, 'U> =
        Yargs.index.yargs_.CommandModule<'T, 'U>

    type CommandModule<'T> =
        CommandModule<'T, obj>

    type CommandModule =
        CommandModule<obj, obj>

    type CompletionCallback =
        Yargs.index.yargs_.CompletionCallback

    type FallbackCompletionFunction =
        Yargs.index.yargs_.FallbackCompletionFunction

    type InferredOptionType<'O> =
        Yargs.index.yargs_.InferredOptionType<'O>

    type InferredOptionTypeInner<'O> =
        Yargs.index.yargs_.InferredOptionTypeInner<'O>

    type InferredOptionTypePrimitive<'O> =
        Yargs.index.yargs_.InferredOptionTypePrimitive<'O>

    type InferredOptionTypes<'O> =
        Yargs.index.yargs_.InferredOptionTypes<'O>

    type MiddlewareFunction<'T> =
        Yargs.index.yargs_.MiddlewareFunction<'T>

    type MiddlewareFunction =
        MiddlewareFunction<obj>

    type Options =
        Yargs.index.yargs_.Options

    type ParseCallback<'T> =
        Yargs.index.yargs_.ParseCallback<'T>

    type ParseCallback =
        ParseCallback<obj>

    type ParserConfigurationOptions =
        Yargs.index.yargs_.ParserConfigurationOptions

    type PositionalOptions =
        Yargs.index.yargs_.PositionalOptions

    type PositionalOptionsType =
        Yargs.index.yargs_.PositionalOptionsType

    type PromiseCompletionFunction =
        Yargs.index.yargs_.PromiseCompletionFunction

    type RequireDirectoryOptions =
        Yargs.index.yargs_.RequireDirectoryOptions

    type SyncCompletionFunction =
        Yargs.index.yargs_.SyncCompletionFunction

    type ToArray<'T> =
        Yargs.index.yargs_.ToArray<'T>

    type ToNumber<'T> =
        Yargs.index.yargs_.ToNumber<'T>

    type ToString<'T> =
        Yargs.index.yargs_.ToString<'T>

    module helpers =

        [<AbstractClass>]
        [<Erase>]
        type Exports =
            [<Import("applyExtends", "yargs/helpers")>]
            static member applyExtends (config: obj, cwd: string, mergeExtends: bool) : obj = nativeOnly
            [<Import("hideBin", "yargs/helpers")>]
            static member hideBin (argv: ResizeArray<string>) : ResizeArray<string> = nativeOnly

    module index =

        module yargs_ =

            type BuilderCallback<'T, 'R> =
                U2<(Yargs.index.yargs_.Argv<'T> -> unit), (Yargs.index.yargs_.Argv<'T> -> Yargs.index.yargs_.Argv<'R>)>

            [<AllowNullLiteral>]
            [<Interface>]
            type ParserConfigurationOptions =
                /// <summary>
                /// Should variables prefixed with --no be treated as negations? Default is <c>true</c>
                /// </summary>
                abstract member ``boolean-negation``: bool with get, set
                /// <summary>
                /// Should hyphenated arguments be expanded into camel-case aliases? Default is <c>true</c>
                /// </summary>
                abstract member ``camel-case-expansion``: bool with get, set
                /// <summary>
                /// Should arrays be combined when provided by both command line arguments and a configuration file. Default is <c>false</c>
                /// </summary>
                abstract member ``combine-arrays``: bool with get, set
                /// <summary>
                /// Should keys that contain . be treated as objects? Default is <c>true</c>
                /// </summary>
                abstract member ``dot-notation``: bool with get, set
                /// <summary>
                /// Should arguments be coerced into an array when duplicated. Default is <c>true</c>
                /// </summary>
                abstract member ``duplicate-arguments-array``: bool with get, set
                /// <summary>
                /// Should array arguments be coerced into a single array when duplicated. Default is <c>true</c>
                /// </summary>
                abstract member ``flatten-duplicate-arrays``: bool with get, set
                /// <summary>
                /// Should arrays consume more than one positional argument following their flag. Default is <c>true</c>
                /// </summary>
                abstract member ``greedy-arrays``: bool with get, set
                /// <summary>
                /// Should nargs consume dash options as well as positional arguments. Default is <c>false</c>
                /// </summary>
                abstract member ``nargs-eats-options``: bool with get, set
                /// <summary>
                /// Should parsing stop at the first text argument? This is similar to how e.g. ssh parses its command line. Default is <c>false</c>
                /// </summary>
                abstract member ``halt-at-non-option``: bool with get, set
                /// <summary>
                /// The prefix to use for negated boolean variables. Default is <c>'no-'</c>
                /// </summary>
                abstract member ``negation-prefix``: string with get, set
                /// <summary>
                /// Should keys that look like numbers be treated as such? Default is <c>true</c>
                /// </summary>
                abstract member ``parse-numbers``: bool with get, set
                /// <summary>
                /// Should positional keys that look like numbers be treated as such? Default is <c>true</c>
                /// </summary>
                abstract member ``parse-positional-numbers``: bool with get, set
                /// <summary>
                /// Should unparsed flags be stored in -- or _. Default is <c>false</c>
                /// </summary>
                abstract member ``populate--``: bool with get, set
                /// <summary>
                /// Should a placeholder be added for keys not set via the corresponding CLI argument? Default is <c>false</c>
                /// </summary>
                abstract member ``set-placeholder-key``: bool with get, set
                /// <summary>
                /// Should a group of short-options be treated as boolean flags? Default is <c>true</c>
                /// </summary>
                abstract member ``short-option-groups``: bool with get, set
                /// <summary>
                /// Should aliases be removed before returning results? Default is <c>false</c>
                /// </summary>
                abstract member ``strip-aliased``: bool with get, set
                /// <summary>
                /// Should dashed keys be removed before returning results? This option has no effect if camel-case-expansion is disabled. Default is <c>false</c>
                /// </summary>
                abstract member ``strip-dashed``: bool with get, set
                /// <summary>
                /// Should unknown options be treated like regular arguments? An unknown option is one that is not configured in opts. Default is <c>false</c>
                /// </summary>
                abstract member ``unknown-options-as-args``: bool with get, set
                /// <summary>
                /// Sort commands alphabetically. Default is <c>false</c>
                /// </summary>
                abstract member ``sort-commands``: bool with get, set

            /// <summary>
            /// The type parameter <c>T</c> is the expected shape of the parsed options.
            /// <c>Arguments<T></c> is those options plus <c>_</c> and <c>$0</c>, and an indexer falling
            /// back to <c>unknown</c> for unknown options.
            ///
            /// For the return type / <c>argv</c> property, we create a mapped type over
            /// <c>Arguments<T></c> to simplify the inferred type signature in client code.
            /// </summary>
            [<AllowNullLiteral>]
            [<Interface>]
            type Argv<'T> =
                [<Emit("$0($1...)")>]
                abstract member Invoke: ?args: U2<ResizeArray<string>, string> * ?cwd: string -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Set key names as equivalent such that updates to a key will propagate to aliases and vice-versa.
                ///
                /// Optionally <c>.alias()</c> can take an object that maps keys to aliases.
                /// Each key of this object should be the canonical version of the option, and each value should be a string or an array of strings.
                /// </summary>
                abstract member alias<'K1, 'K2>: shortName: 'K1 * longName: 'K2 -> Yargs.index.yargs_.Argv<obj>
                /// <summary>
                /// Set key names as equivalent such that updates to a key will propagate to aliases and vice-versa.
                ///
                /// Optionally <c>.alias()</c> can take an object that maps keys to aliases.
                /// Each key of this object should be the canonical version of the option, and each value should be a string or an array of strings.
                /// </summary>
                abstract member alias<'K1, 'K2>: shortName: 'K1 * longName: ResizeArray<'K2> -> Yargs.index.yargs_.Argv<obj>
                /// <summary>
                /// Set key names as equivalent such that updates to a key will propagate to aliases and vice-versa.
                ///
                /// Optionally <c>.alias()</c> can take an object that maps keys to aliases.
                /// Each key of this object should be the canonical version of the option, and each value should be a string or an array of strings.
                /// </summary>
                abstract member alias<'K1, 'K2>: shortName: 'K1 * longName: U2<'K2, ResizeArray<'K2>> -> Yargs.index.yargs_.Argv<obj>
                /// <summary>
                /// Set key names as equivalent such that updates to a key will propagate to aliases and vice-versa.
                ///
                /// Optionally <c>.alias()</c> can take an object that maps keys to aliases.
                /// Each key of this object should be the canonical version of the option, and each value should be a string or an array of strings.
                /// </summary>
                abstract member alias: shortName: string * longName: string -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Set key names as equivalent such that updates to a key will propagate to aliases and vice-versa.
                ///
                /// Optionally <c>.alias()</c> can take an object that maps keys to aliases.
                /// Each key of this object should be the canonical version of the option, and each value should be a string or an array of strings.
                /// </summary>
                abstract member alias: shortName: string * longName: ResizeArray<string> -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Set key names as equivalent such that updates to a key will propagate to aliases and vice-versa.
                ///
                /// Optionally <c>.alias()</c> can take an object that maps keys to aliases.
                /// Each key of this object should be the canonical version of the option, and each value should be a string or an array of strings.
                /// </summary>
                abstract member alias: shortName: ResizeArray<string> * longName: string -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Set key names as equivalent such that updates to a key will propagate to aliases and vice-versa.
                ///
                /// Optionally <c>.alias()</c> can take an object that maps keys to aliases.
                /// Each key of this object should be the canonical version of the option, and each value should be a string or an array of strings.
                /// </summary>
                abstract member alias: shortName: ResizeArray<string> * longName: ResizeArray<string> -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Set key names as equivalent such that updates to a key will propagate to aliases and vice-versa.
                ///
                /// Optionally <c>.alias()</c> can take an object that maps keys to aliases.
                /// Each key of this object should be the canonical version of the option, and each value should be a string or an array of strings.
                /// </summary>
                abstract member alias: shortName: U2<string, ResizeArray<string>> * longName: U2<string, ResizeArray<string>> -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Set key names as equivalent such that updates to a key will propagate to aliases and vice-versa.
                ///
                /// Optionally <c>.alias()</c> can take an object that maps keys to aliases.
                /// Each key of this object should be the canonical version of the option, and each value should be a string or an array of strings.
                /// </summary>
                abstract member alias: aliases: Argv.alias.aliases -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Get the arguments as a plain old object.
                ///
                /// Arguments without a corresponding flag show up in the <c>argv._</c> array.
                ///
                /// The script name or node command is available at <c>argv.$0</c> similarly to how <c>$0</c> works in bash or perl.
                ///
                /// If <c>yargs</c> is executed in an environment that embeds node and there's no script name (e.g. Electron or nw.js),
                /// it will ignore the first parameter since it expects it to be the script name. In order to override
                /// this behavior, use <c>.parse(process.argv.slice(1))</c> instead of .argv and the first parameter won't be ignored.
                /// </summary>
                abstract member argv: U2<Yargs.index.yargs_.Arguments<'T>, JS.Promise<Yargs.index.yargs_.Arguments<'T>>> with get, set
                /// <summary>
                /// Tell the parser to interpret <c>key</c> as an array.
                /// If <c>.array('foo')</c> is set, <c>--foo foo bar</c> will be parsed as <c>['foo', 'bar']</c> rather than as <c>'foo'</c>.
                /// Also, if you use the option multiple times all the values will be flattened in one array so <c>--foo foo --foo bar</c> will be parsed as <c>['foo', 'bar']</c>
                ///
                /// When the option is used with a positional, use <c>--</c> to tell <c>yargs</c> to stop adding values to the array.
                /// </summary>
                abstract member array<'K>: key: 'K -> Yargs.index.yargs_.Argv<obj>
                /// <summary>
                /// Tell the parser to interpret <c>key</c> as an array.
                /// If <c>.array('foo')</c> is set, <c>--foo foo bar</c> will be parsed as <c>['foo', 'bar']</c> rather than as <c>'foo'</c>.
                /// Also, if you use the option multiple times all the values will be flattened in one array so <c>--foo foo --foo bar</c> will be parsed as <c>['foo', 'bar']</c>
                ///
                /// When the option is used with a positional, use <c>--</c> to tell <c>yargs</c> to stop adding values to the array.
                /// </summary>
                abstract member array<'K>: key: ResizeArray<'K> -> Yargs.index.yargs_.Argv<obj>
                /// <summary>
                /// Tell the parser to interpret <c>key</c> as an array.
                /// If <c>.array('foo')</c> is set, <c>--foo foo bar</c> will be parsed as <c>['foo', 'bar']</c> rather than as <c>'foo'</c>.
                /// Also, if you use the option multiple times all the values will be flattened in one array so <c>--foo foo --foo bar</c> will be parsed as <c>['foo', 'bar']</c>
                ///
                /// When the option is used with a positional, use <c>--</c> to tell <c>yargs</c> to stop adding values to the array.
                /// </summary>
                abstract member array<'K>: key: U2<'K, ResizeArray<'K>> -> Yargs.index.yargs_.Argv<obj>
                /// <summary>
                /// Interpret <c>key</c> as a boolean. If a non-flag option follows <c>key</c> in <c>process.argv</c>, that string won't get set as the value of <c>key</c>.
                ///
                /// <c>key</c> will default to <c>false</c>, unless a <c>default(key, undefined)</c> is explicitly set.
                ///
                /// If <c>key</c> is an array, interpret all the elements as booleans.
                /// </summary>
                abstract member boolean<'K>: key: 'K -> Yargs.index.yargs_.Argv<obj>
                /// <summary>
                /// Interpret <c>key</c> as a boolean. If a non-flag option follows <c>key</c> in <c>process.argv</c>, that string won't get set as the value of <c>key</c>.
                ///
                /// <c>key</c> will default to <c>false</c>, unless a <c>default(key, undefined)</c> is explicitly set.
                ///
                /// If <c>key</c> is an array, interpret all the elements as booleans.
                /// </summary>
                abstract member boolean<'K>: key: ResizeArray<'K> -> Yargs.index.yargs_.Argv<obj>
                /// <summary>
                /// Interpret <c>key</c> as a boolean. If a non-flag option follows <c>key</c> in <c>process.argv</c>, that string won't get set as the value of <c>key</c>.
                ///
                /// <c>key</c> will default to <c>false</c>, unless a <c>default(key, undefined)</c> is explicitly set.
                ///
                /// If <c>key</c> is an array, interpret all the elements as booleans.
                /// </summary>
                abstract member boolean<'K>: key: U2<'K, ResizeArray<'K>> -> Yargs.index.yargs_.Argv<obj>
                /// <summary>
                /// Check that certain conditions are met in the provided arguments.
                /// </summary>
                /// <param name="func">
                /// Called with two arguments, the parsed <c>argv</c> hash and an array of options and their aliases.
                /// If <c>func</c> throws or returns a non-truthy value, show the thrown error, usage information, and exit.
                /// </param>
                /// <param name="global">
                /// Indicates whether <c>check()</c> should be enabled both at the top-level and for each sub-command.
                /// </param>
                abstract member check: func: Argv.check.func<'T> * ?``global``: bool -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Limit valid values for key to a predefined set of choices, given as an array or as an individual value.
                /// If this method is called multiple times, all enumerated values will be merged together.
                /// Choices are generally strings or numbers, and value matching is case-sensitive.
                ///
                /// Optionally <c>.choices()</c> can take an object that maps multiple keys to their choices.
                ///
                /// Choices can also be specified as choices in the object given to <c>option()</c>.
                /// </summary>
                abstract member choices<'K, 'C>: key: 'K * values: 'C -> Yargs.index.yargs_.Argv<obj>
                /// <summary>
                /// Limit valid values for key to a predefined set of choices, given as an array or as an individual value.
                /// If this method is called multiple times, all enumerated values will be merged together.
                /// Choices are generally strings or numbers, and value matching is case-sensitive.
                ///
                /// Optionally <c>.choices()</c> can take an object that maps multiple keys to their choices.
                ///
                /// Choices can also be specified as choices in the object given to <c>option()</c>.
                /// </summary>
                abstract member choices<'C>: choices: 'C -> Yargs.index.yargs_.Argv<obj>
                /// <summary>
                /// Provide a synchronous function to coerce or transform the value(s) given on the command line for <c>key</c>.
                ///
                /// The coercion function should accept one argument, representing the parsed value from the command line, and should return a new value or throw an error.
                /// The returned value will be used as the value for <c>key</c> (or one of its aliases) in <c>argv</c>.
                ///
                /// If the function throws, the error will be treated as a validation failure, delegating to either a custom <c>.fail()</c> handler or printing the error message in the console.
                ///
                /// Coercion will be applied to a value after all other modifications, such as <c>.normalize()</c>.
                ///
                /// Optionally <c>.coerce()</c> can take an object that maps several keys to their respective coercion function.
                ///
                /// You can also map the same function to several keys at one time. Just pass an array of keys as the first argument to <c>.coerce()</c>.
                ///
                /// If you are using dot-notion or arrays, .e.g., <c>user.email</c> and <c>user.password</c>, coercion will be applied to the final object that has been parsed
                /// </summary>
                abstract member coerce<'K, 'V>: key: 'K * func: (obj -> 'V) -> Yargs.index.yargs_.Argv<obj>
                /// <summary>
                /// Provide a synchronous function to coerce or transform the value(s) given on the command line for <c>key</c>.
                ///
                /// The coercion function should accept one argument, representing the parsed value from the command line, and should return a new value or throw an error.
                /// The returned value will be used as the value for <c>key</c> (or one of its aliases) in <c>argv</c>.
                ///
                /// If the function throws, the error will be treated as a validation failure, delegating to either a custom <c>.fail()</c> handler or printing the error message in the console.
                ///
                /// Coercion will be applied to a value after all other modifications, such as <c>.normalize()</c>.
                ///
                /// Optionally <c>.coerce()</c> can take an object that maps several keys to their respective coercion function.
                ///
                /// You can also map the same function to several keys at one time. Just pass an array of keys as the first argument to <c>.coerce()</c>.
                ///
                /// If you are using dot-notion or arrays, .e.g., <c>user.email</c> and <c>user.password</c>, coercion will be applied to the final object that has been parsed
                /// </summary>
                abstract member coerce<'K, 'V>: key: ResizeArray<'K> * func: (obj -> 'V) -> Yargs.index.yargs_.Argv<obj>
                /// <summary>
                /// Provide a synchronous function to coerce or transform the value(s) given on the command line for <c>key</c>.
                ///
                /// The coercion function should accept one argument, representing the parsed value from the command line, and should return a new value or throw an error.
                /// The returned value will be used as the value for <c>key</c> (or one of its aliases) in <c>argv</c>.
                ///
                /// If the function throws, the error will be treated as a validation failure, delegating to either a custom <c>.fail()</c> handler or printing the error message in the console.
                ///
                /// Coercion will be applied to a value after all other modifications, such as <c>.normalize()</c>.
                ///
                /// Optionally <c>.coerce()</c> can take an object that maps several keys to their respective coercion function.
                ///
                /// You can also map the same function to several keys at one time. Just pass an array of keys as the first argument to <c>.coerce()</c>.
                ///
                /// If you are using dot-notion or arrays, .e.g., <c>user.email</c> and <c>user.password</c>, coercion will be applied to the final object that has been parsed
                /// </summary>
                abstract member coerce<'K, 'V>: key: U2<'K, ResizeArray<'K>> * func: (obj -> 'V) -> Yargs.index.yargs_.Argv<obj>
                /// <summary>
                /// Provide a synchronous function to coerce or transform the value(s) given on the command line for <c>key</c>.
                ///
                /// The coercion function should accept one argument, representing the parsed value from the command line, and should return a new value or throw an error.
                /// The returned value will be used as the value for <c>key</c> (or one of its aliases) in <c>argv</c>.
                ///
                /// If the function throws, the error will be treated as a validation failure, delegating to either a custom <c>.fail()</c> handler or printing the error message in the console.
                ///
                /// Coercion will be applied to a value after all other modifications, such as <c>.normalize()</c>.
                ///
                /// Optionally <c>.coerce()</c> can take an object that maps several keys to their respective coercion function.
                ///
                /// You can also map the same function to several keys at one time. Just pass an array of keys as the first argument to <c>.coerce()</c>.
                ///
                /// If you are using dot-notion or arrays, .e.g., <c>user.email</c> and <c>user.password</c>, coercion will be applied to the final object that has been parsed
                /// </summary>
                abstract member coerce<'O>: opts: 'O -> Yargs.index.yargs_.Argv<obj>
                /// <summary>
                /// Define the commands exposed by your application.
                /// </summary>
                /// <param name="command">
                /// Should be a string representing the command or an array of strings representing the command and its aliases.
                /// </param>
                /// <param name="description">
                /// Use to provide a description for each command your application accepts (the values stored in <c>argv._</c>).
                /// Set <c>description</c> to false to create a hidden command. Hidden commands don't show up in the help output and aren't available for completion.
                /// </param>
                /// <param name="builder">
                /// Object to give hints about the options that your command accepts.
                /// Can also be a function. This function is executed with a yargs instance, and can be used to provide advanced command specific help.
                ///
                /// Note that when <c>void</c> is returned, the handler <c>argv</c> object type will not include command-specific arguments.
                /// </param>
                /// <param name="handler">
                /// Function, which will be executed with the parsed <c>argv</c> object.
                /// </param>
                abstract member command: command: string * description: string -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Define the commands exposed by your application.
                /// </summary>
                /// <param name="command">
                /// Should be a string representing the command or an array of strings representing the command and its aliases.
                /// </param>
                /// <param name="description">
                /// Use to provide a description for each command your application accepts (the values stored in <c>argv._</c>).
                /// Set <c>description</c> to false to create a hidden command. Hidden commands don't show up in the help output and aren't available for completion.
                /// </param>
                /// <param name="builder">
                /// Object to give hints about the options that your command accepts.
                /// Can also be a function. This function is executed with a yargs instance, and can be used to provide advanced command specific help.
                ///
                /// Note that when <c>void</c> is returned, the handler <c>argv</c> object type will not include command-specific arguments.
                /// </param>
                /// <param name="handler">
                /// Function, which will be executed with the parsed <c>argv</c> object.
                /// </param>
                abstract member command<'U>: command: string * description: string * builder: (Yargs.index.yargs_.Argv<'T> -> unit) * ?handler: (Yargs.index.yargs_.ArgumentsCamelCase<'U> -> U2<unit, JS.Promise<unit>>) * ?middlewares: ResizeArray<Yargs.index.yargs_.MiddlewareFunction<'U>> * ?deprecated: U2<bool, string> -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Define the commands exposed by your application.
                /// </summary>
                /// <param name="command">
                /// Should be a string representing the command or an array of strings representing the command and its aliases.
                /// </param>
                /// <param name="description">
                /// Use to provide a description for each command your application accepts (the values stored in <c>argv._</c>).
                /// Set <c>description</c> to false to create a hidden command. Hidden commands don't show up in the help output and aren't available for completion.
                /// </param>
                /// <param name="builder">
                /// Object to give hints about the options that your command accepts.
                /// Can also be a function. This function is executed with a yargs instance, and can be used to provide advanced command specific help.
                ///
                /// Note that when <c>void</c> is returned, the handler <c>argv</c> object type will not include command-specific arguments.
                /// </param>
                /// <param name="handler">
                /// Function, which will be executed with the parsed <c>argv</c> object.
                /// </param>
                abstract member command<'U>: command: string * description: string * builder: (Yargs.index.yargs_.Argv<'T> -> Yargs.index.yargs_.Argv<'U>) * ?handler: (Yargs.index.yargs_.ArgumentsCamelCase<'U> -> U2<unit, JS.Promise<unit>>) * ?middlewares: ResizeArray<Yargs.index.yargs_.MiddlewareFunction<'U>> * ?deprecated: U2<bool, string> -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Define the commands exposed by your application.
                /// </summary>
                /// <param name="command">
                /// Should be a string representing the command or an array of strings representing the command and its aliases.
                /// </param>
                /// <param name="description">
                /// Use to provide a description for each command your application accepts (the values stored in <c>argv._</c>).
                /// Set <c>description</c> to false to create a hidden command. Hidden commands don't show up in the help output and aren't available for completion.
                /// </param>
                /// <param name="builder">
                /// Object to give hints about the options that your command accepts.
                /// Can also be a function. This function is executed with a yargs instance, and can be used to provide advanced command specific help.
                ///
                /// Note that when <c>void</c> is returned, the handler <c>argv</c> object type will not include command-specific arguments.
                /// </param>
                /// <param name="handler">
                /// Function, which will be executed with the parsed <c>argv</c> object.
                /// </param>
                abstract member command: command: ResizeArray<string> * description: string -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Define the commands exposed by your application.
                /// </summary>
                /// <param name="command">
                /// Should be a string representing the command or an array of strings representing the command and its aliases.
                /// </param>
                /// <param name="description">
                /// Use to provide a description for each command your application accepts (the values stored in <c>argv._</c>).
                /// Set <c>description</c> to false to create a hidden command. Hidden commands don't show up in the help output and aren't available for completion.
                /// </param>
                /// <param name="builder">
                /// Object to give hints about the options that your command accepts.
                /// Can also be a function. This function is executed with a yargs instance, and can be used to provide advanced command specific help.
                ///
                /// Note that when <c>void</c> is returned, the handler <c>argv</c> object type will not include command-specific arguments.
                /// </param>
                /// <param name="handler">
                /// Function, which will be executed with the parsed <c>argv</c> object.
                /// </param>
                abstract member command<'U>: command: ResizeArray<string> * description: string * builder: (Yargs.index.yargs_.Argv<'T> -> unit) * ?handler: (Yargs.index.yargs_.ArgumentsCamelCase<'U> -> U2<unit, JS.Promise<unit>>) * ?middlewares: ResizeArray<Yargs.index.yargs_.MiddlewareFunction<'U>> * ?deprecated: U2<bool, string> -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Define the commands exposed by your application.
                /// </summary>
                /// <param name="command">
                /// Should be a string representing the command or an array of strings representing the command and its aliases.
                /// </param>
                /// <param name="description">
                /// Use to provide a description for each command your application accepts (the values stored in <c>argv._</c>).
                /// Set <c>description</c> to false to create a hidden command. Hidden commands don't show up in the help output and aren't available for completion.
                /// </param>
                /// <param name="builder">
                /// Object to give hints about the options that your command accepts.
                /// Can also be a function. This function is executed with a yargs instance, and can be used to provide advanced command specific help.
                ///
                /// Note that when <c>void</c> is returned, the handler <c>argv</c> object type will not include command-specific arguments.
                /// </param>
                /// <param name="handler">
                /// Function, which will be executed with the parsed <c>argv</c> object.
                /// </param>
                abstract member command<'U>: command: ResizeArray<string> * description: string * builder: (Yargs.index.yargs_.Argv<'T> -> Yargs.index.yargs_.Argv<'U>) * ?handler: (Yargs.index.yargs_.ArgumentsCamelCase<'U> -> U2<unit, JS.Promise<unit>>) * ?middlewares: ResizeArray<Yargs.index.yargs_.MiddlewareFunction<'U>> * ?deprecated: U2<bool, string> -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Define the commands exposed by your application.
                /// </summary>
                /// <param name="command">
                /// Should be a string representing the command or an array of strings representing the command and its aliases.
                /// </param>
                /// <param name="description">
                /// Use to provide a description for each command your application accepts (the values stored in <c>argv._</c>).
                /// Set <c>description</c> to false to create a hidden command. Hidden commands don't show up in the help output and aren't available for completion.
                /// </param>
                /// <param name="builder">
                /// Object to give hints about the options that your command accepts.
                /// Can also be a function. This function is executed with a yargs instance, and can be used to provide advanced command specific help.
                ///
                /// Note that when <c>void</c> is returned, the handler <c>argv</c> object type will not include command-specific arguments.
                /// </param>
                /// <param name="handler">
                /// Function, which will be executed with the parsed <c>argv</c> object.
                /// </param>
                abstract member command: command: string * description: string * builder: (Yargs.index.yargs_.Argv<'T> -> unit) * ?handler: (Yargs.index.yargs_.ArgumentsCamelCase<'T> -> U2<unit, JS.Promise<unit>>) * ?middlewares: ResizeArray<Yargs.index.yargs_.MiddlewareFunction<'T>> * ?deprecated: U2<bool, string> -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Define the commands exposed by your application.
                /// </summary>
                /// <param name="command">
                /// Should be a string representing the command or an array of strings representing the command and its aliases.
                /// </param>
                /// <param name="description">
                /// Use to provide a description for each command your application accepts (the values stored in <c>argv._</c>).
                /// Set <c>description</c> to false to create a hidden command. Hidden commands don't show up in the help output and aren't available for completion.
                /// </param>
                /// <param name="builder">
                /// Object to give hints about the options that your command accepts.
                /// Can also be a function. This function is executed with a yargs instance, and can be used to provide advanced command specific help.
                ///
                /// Note that when <c>void</c> is returned, the handler <c>argv</c> object type will not include command-specific arguments.
                /// </param>
                /// <param name="handler">
                /// Function, which will be executed with the parsed <c>argv</c> object.
                /// </param>
                abstract member command: command: string * description: string * builder: (Yargs.index.yargs_.Argv<'T> -> Yargs.index.yargs_.Argv<'T>) * ?handler: (Yargs.index.yargs_.ArgumentsCamelCase<'T> -> U2<unit, JS.Promise<unit>>) * ?middlewares: ResizeArray<Yargs.index.yargs_.MiddlewareFunction<'T>> * ?deprecated: U2<bool, string> -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Define the commands exposed by your application.
                /// </summary>
                /// <param name="command">
                /// Should be a string representing the command or an array of strings representing the command and its aliases.
                /// </param>
                /// <param name="description">
                /// Use to provide a description for each command your application accepts (the values stored in <c>argv._</c>).
                /// Set <c>description</c> to false to create a hidden command. Hidden commands don't show up in the help output and aren't available for completion.
                /// </param>
                /// <param name="builder">
                /// Object to give hints about the options that your command accepts.
                /// Can also be a function. This function is executed with a yargs instance, and can be used to provide advanced command specific help.
                ///
                /// Note that when <c>void</c> is returned, the handler <c>argv</c> object type will not include command-specific arguments.
                /// </param>
                /// <param name="handler">
                /// Function, which will be executed with the parsed <c>argv</c> object.
                /// </param>
                abstract member command: command: ResizeArray<string> * description: string * builder: (Yargs.index.yargs_.Argv<'T> -> unit) * ?handler: (Yargs.index.yargs_.ArgumentsCamelCase<'T> -> U2<unit, JS.Promise<unit>>) * ?middlewares: ResizeArray<Yargs.index.yargs_.MiddlewareFunction<'T>> * ?deprecated: U2<bool, string> -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Define the commands exposed by your application.
                /// </summary>
                /// <param name="command">
                /// Should be a string representing the command or an array of strings representing the command and its aliases.
                /// </param>
                /// <param name="description">
                /// Use to provide a description for each command your application accepts (the values stored in <c>argv._</c>).
                /// Set <c>description</c> to false to create a hidden command. Hidden commands don't show up in the help output and aren't available for completion.
                /// </param>
                /// <param name="builder">
                /// Object to give hints about the options that your command accepts.
                /// Can also be a function. This function is executed with a yargs instance, and can be used to provide advanced command specific help.
                ///
                /// Note that when <c>void</c> is returned, the handler <c>argv</c> object type will not include command-specific arguments.
                /// </param>
                /// <param name="handler">
                /// Function, which will be executed with the parsed <c>argv</c> object.
                /// </param>
                abstract member command: command: ResizeArray<string> * description: string * builder: (Yargs.index.yargs_.Argv<'T> -> Yargs.index.yargs_.Argv<'T>) * ?handler: (Yargs.index.yargs_.ArgumentsCamelCase<'T> -> U2<unit, JS.Promise<unit>>) * ?middlewares: ResizeArray<Yargs.index.yargs_.MiddlewareFunction<'T>> * ?deprecated: U2<bool, string> -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Define the commands exposed by your application.
                /// </summary>
                abstract member command<'O>: command: string * description: string * ?builder: 'O * ?handler: (Yargs.index.yargs_.ArgumentsCamelCase<Yargs.index.yargs_.InferredOptionTypes<'O>> -> U2<unit, JS.Promise<unit>>) * ?middlewares: ResizeArray<Yargs.index.yargs_.MiddlewareFunction<'O>> * ?deprecated: U2<bool, string> -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Define the commands exposed by your application.
                /// </summary>
                abstract member command<'O>: command: ResizeArray<string> * description: string * ?builder: 'O * ?handler: (Yargs.index.yargs_.ArgumentsCamelCase<Yargs.index.yargs_.InferredOptionTypes<'O>> -> U2<unit, JS.Promise<unit>>) * ?middlewares: ResizeArray<Yargs.index.yargs_.MiddlewareFunction<'O>> * ?deprecated: U2<bool, string> -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Define the commands exposed by your application.
                /// </summary>
                abstract member command<'O>: command: U2<string, ResizeArray<string>> * description: string * ?builder: 'O * ?handler: (Yargs.index.yargs_.ArgumentsCamelCase<Yargs.index.yargs_.InferredOptionTypes<'O>> -> U2<unit, JS.Promise<unit>>) * ?middlewares: ResizeArray<Yargs.index.yargs_.MiddlewareFunction<'O>> * ?deprecated: U2<bool, string> -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Define the commands exposed by your application.
                /// </summary>
                abstract member command<'U>: command: string * description: string * ``module``: Yargs.index.yargs_.CommandModule<'T, 'U> -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Define the commands exposed by your application.
                /// </summary>
                abstract member command<'U>: command: ResizeArray<string> * description: string * ``module``: Yargs.index.yargs_.CommandModule<'T, 'U> -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Define the commands exposed by your application.
                /// </summary>
                abstract member command<'U>: command: U2<string, ResizeArray<string>> * description: string * ``module``: Yargs.index.yargs_.CommandModule<'T, 'U> -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Define the commands exposed by your application.
                /// </summary>
                abstract member command: command: string * showInHelp: bool -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Define the commands exposed by your application.
                /// </summary>
                abstract member command<'U>: command: string * showInHelp: bool * builder: (Yargs.index.yargs_.Argv<'T> -> unit) * ?handler: (Yargs.index.yargs_.ArgumentsCamelCase<'U> -> U2<unit, JS.Promise<unit>>) * ?middlewares: ResizeArray<Yargs.index.yargs_.MiddlewareFunction<'U>> * ?deprecated: U2<bool, string> -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Define the commands exposed by your application.
                /// </summary>
                abstract member command<'U>: command: string * showInHelp: bool * builder: (Yargs.index.yargs_.Argv<'T> -> Yargs.index.yargs_.Argv<'U>) * ?handler: (Yargs.index.yargs_.ArgumentsCamelCase<'U> -> U2<unit, JS.Promise<unit>>) * ?middlewares: ResizeArray<Yargs.index.yargs_.MiddlewareFunction<'U>> * ?deprecated: U2<bool, string> -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Define the commands exposed by your application.
                /// </summary>
                abstract member command: command: ResizeArray<string> * showInHelp: bool -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Define the commands exposed by your application.
                /// </summary>
                abstract member command<'U>: command: ResizeArray<string> * showInHelp: bool * builder: (Yargs.index.yargs_.Argv<'T> -> unit) * ?handler: (Yargs.index.yargs_.ArgumentsCamelCase<'U> -> U2<unit, JS.Promise<unit>>) * ?middlewares: ResizeArray<Yargs.index.yargs_.MiddlewareFunction<'U>> * ?deprecated: U2<bool, string> -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Define the commands exposed by your application.
                /// </summary>
                abstract member command<'U>: command: ResizeArray<string> * showInHelp: bool * builder: (Yargs.index.yargs_.Argv<'T> -> Yargs.index.yargs_.Argv<'U>) * ?handler: (Yargs.index.yargs_.ArgumentsCamelCase<'U> -> U2<unit, JS.Promise<unit>>) * ?middlewares: ResizeArray<Yargs.index.yargs_.MiddlewareFunction<'U>> * ?deprecated: U2<bool, string> -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Define the commands exposed by your application.
                /// </summary>
                abstract member command: command: string * showInHelp: bool * builder: (Yargs.index.yargs_.Argv<'T> -> unit) * ?handler: (Yargs.index.yargs_.ArgumentsCamelCase<'T> -> U2<unit, JS.Promise<unit>>) * ?middlewares: ResizeArray<Yargs.index.yargs_.MiddlewareFunction<'T>> * ?deprecated: U2<bool, string> -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Define the commands exposed by your application.
                /// </summary>
                abstract member command: command: string * showInHelp: bool * builder: (Yargs.index.yargs_.Argv<'T> -> Yargs.index.yargs_.Argv<'T>) * ?handler: (Yargs.index.yargs_.ArgumentsCamelCase<'T> -> U2<unit, JS.Promise<unit>>) * ?middlewares: ResizeArray<Yargs.index.yargs_.MiddlewareFunction<'T>> * ?deprecated: U2<bool, string> -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Define the commands exposed by your application.
                /// </summary>
                abstract member command: command: ResizeArray<string> * showInHelp: bool * builder: (Yargs.index.yargs_.Argv<'T> -> unit) * ?handler: (Yargs.index.yargs_.ArgumentsCamelCase<'T> -> U2<unit, JS.Promise<unit>>) * ?middlewares: ResizeArray<Yargs.index.yargs_.MiddlewareFunction<'T>> * ?deprecated: U2<bool, string> -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Define the commands exposed by your application.
                /// </summary>
                abstract member command: command: ResizeArray<string> * showInHelp: bool * builder: (Yargs.index.yargs_.Argv<'T> -> Yargs.index.yargs_.Argv<'T>) * ?handler: (Yargs.index.yargs_.ArgumentsCamelCase<'T> -> U2<unit, JS.Promise<unit>>) * ?middlewares: ResizeArray<Yargs.index.yargs_.MiddlewareFunction<'T>> * ?deprecated: U2<bool, string> -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Define the commands exposed by your application.
                /// </summary>
                abstract member command<'O>: command: string * showInHelp: bool * ?builder: 'O * ?handler: (Yargs.index.yargs_.ArgumentsCamelCase<Yargs.index.yargs_.InferredOptionTypes<'O>> -> U2<unit, JS.Promise<unit>>) -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Define the commands exposed by your application.
                /// </summary>
                abstract member command<'O>: command: ResizeArray<string> * showInHelp: bool * ?builder: 'O * ?handler: (Yargs.index.yargs_.ArgumentsCamelCase<Yargs.index.yargs_.InferredOptionTypes<'O>> -> U2<unit, JS.Promise<unit>>) -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Define the commands exposed by your application.
                /// </summary>
                abstract member command<'O>: command: U2<string, ResizeArray<string>> * showInHelp: bool * ?builder: 'O * ?handler: (Yargs.index.yargs_.ArgumentsCamelCase<Yargs.index.yargs_.InferredOptionTypes<'O>> -> U2<unit, JS.Promise<unit>>) -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Define the commands exposed by your application.
                /// </summary>
                abstract member command<'U>: command: string * showInHelp: bool * ``module``: Yargs.index.yargs_.CommandModule<'T, 'U> -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Define the commands exposed by your application.
                /// </summary>
                abstract member command<'U>: command: ResizeArray<string> * showInHelp: bool * ``module``: Yargs.index.yargs_.CommandModule<'T, 'U> -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Define the commands exposed by your application.
                /// </summary>
                abstract member command<'U>: command: U2<string, ResizeArray<string>> * showInHelp: bool * ``module``: Yargs.index.yargs_.CommandModule<'T, 'U> -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Define the commands exposed by your application.
                /// </summary>
                abstract member command<'U>: ``module``: Yargs.index.yargs_.CommandModule<'T, 'U> -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Define the commands exposed by your application.
                /// </summary>
                abstract member command<'U>: modules: ResizeArray<Yargs.index.yargs_.CommandModule<'T, 'U>> -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Apply command modules from a directory relative to the module calling this method.
                /// </summary>
                abstract member commandDir: dir: string * ?opts: Yargs.index.yargs_.RequireDirectoryOptions -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Enable bash/zsh-completion shortcuts for commands and options.
                ///
                /// If invoked without parameters, <c>.completion()</c> will make completion the command to output the completion script.
                /// </summary>
                /// <param name="cmd">
                /// When present in <c>argv._</c>, will result in the <c>.bashrc</c> or <c>.zshrc</c> completion script being outputted.
                /// To enable bash/zsh completions, concat the generated script to your <c>.bashrc</c> or <c>.bash_profile</c> (or <c>.zshrc</c> for zsh).
                /// </param>
                /// <param name="description">
                /// Provide a description in your usage instructions for the command that generates the completion scripts.
                /// </param>
                /// <param name="func">
                /// Rather than relying on yargs' default completion functionality, which shiver me timbers is pretty awesome, you can provide your own completion method.
                /// </param>
                abstract member completion: unit -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Enable bash/zsh-completion shortcuts for commands and options.
                ///
                /// If invoked without parameters, <c>.completion()</c> will make completion the command to output the completion script.
                /// </summary>
                abstract member completion: cmd: string * ?func: Yargs.index.yargs_.AsyncCompletionFunction -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Enable bash/zsh-completion shortcuts for commands and options.
                ///
                /// If invoked without parameters, <c>.completion()</c> will make completion the command to output the completion script.
                /// </summary>
                abstract member completion: cmd: string * func: Yargs.index.yargs_.SyncCompletionFunction -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Enable bash/zsh-completion shortcuts for commands and options.
                ///
                /// If invoked without parameters, <c>.completion()</c> will make completion the command to output the completion script.
                /// </summary>
                abstract member completion: cmd: string * func: Yargs.index.yargs_.PromiseCompletionFunction -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Enable bash/zsh-completion shortcuts for commands and options.
                ///
                /// If invoked without parameters, <c>.completion()</c> will make completion the command to output the completion script.
                /// </summary>
                abstract member completion: cmd: string * func: Yargs.index.yargs_.FallbackCompletionFunction -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Enable bash/zsh-completion shortcuts for commands and options.
                ///
                /// If invoked without parameters, <c>.completion()</c> will make completion the command to output the completion script.
                /// </summary>
                abstract member completion: cmd: string * description: U2<string, bool> * ?func: Yargs.index.yargs_.AsyncCompletionFunction -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Enable bash/zsh-completion shortcuts for commands and options.
                ///
                /// If invoked without parameters, <c>.completion()</c> will make completion the command to output the completion script.
                /// </summary>
                abstract member completion: cmd: string * description: U2<string, bool> * func: Yargs.index.yargs_.SyncCompletionFunction -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Enable bash/zsh-completion shortcuts for commands and options.
                ///
                /// If invoked without parameters, <c>.completion()</c> will make completion the command to output the completion script.
                /// </summary>
                abstract member completion: cmd: string * description: U2<string, bool> * func: Yargs.index.yargs_.PromiseCompletionFunction -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Enable bash/zsh-completion shortcuts for commands and options.
                ///
                /// If invoked without parameters, <c>.completion()</c> will make completion the command to output the completion script.
                /// </summary>
                abstract member completion: cmd: string * description: U2<string, bool> * func: Yargs.index.yargs_.FallbackCompletionFunction -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Tells the parser that if the option specified by <c>key</c> is passed in, it should be interpreted as a path to a JSON config file.
                /// The file is loaded and parsed, and its properties are set as arguments.
                /// Because the file is loaded using Node's require(), the filename MUST end in <c>.json</c> to be interpreted correctly.
                ///
                /// If invoked without parameters, <c>.config()</c> will make --config the option to pass the JSON config file.
                /// </summary>
                /// <param name="description">
                /// Provided to customize the config (<c>key</c>) option in the usage string.
                /// </param>
                /// <param name="explicitConfigurationObject">
                /// An explicit configuration <c>object</c>
                /// </param>
                abstract member config: unit -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Tells the parser that if the option specified by <c>key</c> is passed in, it should be interpreted as a path to a JSON config file.
                /// The file is loaded and parsed, and its properties are set as arguments.
                /// Because the file is loaded using Node's require(), the filename MUST end in <c>.json</c> to be interpreted correctly.
                ///
                /// If invoked without parameters, <c>.config()</c> will make --config the option to pass the JSON config file.
                /// </summary>
                abstract member config: key: string * ?description: string * ?parseFn: (string -> obj) -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Tells the parser that if the option specified by <c>key</c> is passed in, it should be interpreted as a path to a JSON config file.
                /// The file is loaded and parsed, and its properties are set as arguments.
                /// Because the file is loaded using Node's require(), the filename MUST end in <c>.json</c> to be interpreted correctly.
                ///
                /// If invoked without parameters, <c>.config()</c> will make --config the option to pass the JSON config file.
                /// </summary>
                abstract member config: key: ResizeArray<string> * ?description: string * ?parseFn: (string -> obj) -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Tells the parser that if the option specified by <c>key</c> is passed in, it should be interpreted as a path to a JSON config file.
                /// The file is loaded and parsed, and its properties are set as arguments.
                /// Because the file is loaded using Node's require(), the filename MUST end in <c>.json</c> to be interpreted correctly.
                ///
                /// If invoked without parameters, <c>.config()</c> will make --config the option to pass the JSON config file.
                /// </summary>
                abstract member config: key: U2<string, ResizeArray<string>> * ?description: string * ?parseFn: (string -> obj) -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Tells the parser that if the option specified by <c>key</c> is passed in, it should be interpreted as a path to a JSON config file.
                /// The file is loaded and parsed, and its properties are set as arguments.
                /// Because the file is loaded using Node's require(), the filename MUST end in <c>.json</c> to be interpreted correctly.
                ///
                /// If invoked without parameters, <c>.config()</c> will make --config the option to pass the JSON config file.
                /// </summary>
                abstract member config: key: string * parseFn: (string -> obj) -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Tells the parser that if the option specified by <c>key</c> is passed in, it should be interpreted as a path to a JSON config file.
                /// The file is loaded and parsed, and its properties are set as arguments.
                /// Because the file is loaded using Node's require(), the filename MUST end in <c>.json</c> to be interpreted correctly.
                ///
                /// If invoked without parameters, <c>.config()</c> will make --config the option to pass the JSON config file.
                /// </summary>
                abstract member config: key: ResizeArray<string> * parseFn: (string -> obj) -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Tells the parser that if the option specified by <c>key</c> is passed in, it should be interpreted as a path to a JSON config file.
                /// The file is loaded and parsed, and its properties are set as arguments.
                /// Because the file is loaded using Node's require(), the filename MUST end in <c>.json</c> to be interpreted correctly.
                ///
                /// If invoked without parameters, <c>.config()</c> will make --config the option to pass the JSON config file.
                /// </summary>
                abstract member config: key: U2<string, ResizeArray<string>> * parseFn: (string -> obj) -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Tells the parser that if the option specified by <c>key</c> is passed in, it should be interpreted as a path to a JSON config file.
                /// The file is loaded and parsed, and its properties are set as arguments.
                /// Because the file is loaded using Node's require(), the filename MUST end in <c>.json</c> to be interpreted correctly.
                ///
                /// If invoked without parameters, <c>.config()</c> will make --config the option to pass the JSON config file.
                /// </summary>
                abstract member config: explicitConfigurationObject: obj -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Given the key <c>x</c> is set, the key <c>y</c> must not be set. <c>y</c> can either be a single string or an array of argument names that <c>x</c> conflicts with.
                ///
                /// Optionally <c>.conflicts()</c> can accept an object specifying multiple conflicting keys.
                /// </summary>
                abstract member conflicts: key: string * value: string -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Given the key <c>x</c> is set, the key <c>y</c> must not be set. <c>y</c> can either be a single string or an array of argument names that <c>x</c> conflicts with.
                ///
                /// Optionally <c>.conflicts()</c> can accept an object specifying multiple conflicting keys.
                /// </summary>
                abstract member conflicts: key: string * value: ResizeArray<string> -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Given the key <c>x</c> is set, the key <c>y</c> must not be set. <c>y</c> can either be a single string or an array of argument names that <c>x</c> conflicts with.
                ///
                /// Optionally <c>.conflicts()</c> can accept an object specifying multiple conflicting keys.
                /// </summary>
                abstract member conflicts: key: string * value: U2<string, ResizeArray<string>> -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Given the key <c>x</c> is set, the key <c>y</c> must not be set. <c>y</c> can either be a single string or an array of argument names that <c>x</c> conflicts with.
                ///
                /// Optionally <c>.conflicts()</c> can accept an object specifying multiple conflicting keys.
                /// </summary>
                abstract member conflicts: conflicts: Argv.conflicts.conflicts -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Interpret <c>key</c> as a boolean flag, but set its parsed value to the number of flag occurrences rather than <c>true</c> or <c>false</c>. Default value is thus <c>0</c>.
                /// </summary>
                abstract member count<'K>: key: 'K -> Yargs.index.yargs_.Argv<obj>
                /// <summary>
                /// Interpret <c>key</c> as a boolean flag, but set its parsed value to the number of flag occurrences rather than <c>true</c> or <c>false</c>. Default value is thus <c>0</c>.
                /// </summary>
                abstract member count<'K>: key: ResizeArray<'K> -> Yargs.index.yargs_.Argv<obj>
                /// <summary>
                /// Interpret <c>key</c> as a boolean flag, but set its parsed value to the number of flag occurrences rather than <c>true</c> or <c>false</c>. Default value is thus <c>0</c>.
                /// </summary>
                abstract member count<'K>: key: U2<'K, ResizeArray<'K>> -> Yargs.index.yargs_.Argv<obj>
                /// <summary>
                /// Set <c>argv[key]</c> to <c>value</c> if no option was specified in <c>process.argv</c>.
                ///
                /// Optionally <c>.default()</c> can take an object that maps keys to default values.
                ///
                /// The default value can be a <c>function</c> which returns a value. The name of the function will be used in the usage string.
                ///
                /// Optionally, <c>description</c> can also be provided and will take precedence over displaying the value in the usage instructions.
                /// </summary>
                abstract member ``default``<'K, 'V>: key: 'K * value: 'V * ?description: string -> Yargs.index.yargs_.Argv<obj>
                /// <summary>
                /// Set <c>argv[key]</c> to <c>value</c> if no option was specified in <c>process.argv</c>.
                ///
                /// Optionally <c>.default()</c> can take an object that maps keys to default values.
                ///
                /// The default value can be a <c>function</c> which returns a value. The name of the function will be used in the usage string.
                ///
                /// Optionally, <c>description</c> can also be provided and will take precedence over displaying the value in the usage instructions.
                /// </summary>
                abstract member ``default``<'D>: defaults: 'D * ?description: string -> Yargs.index.yargs_.Argv<obj>
                [<Obsolete("since version 6.6.0\nUse '.demandCommand()' or '.demandOption()' instead")>]
                abstract member demand<'K>: key: 'K * ?msg: U2<string, bool> -> Yargs.index.yargs_.Argv<Yargs.index.yargs_.Defined<'T, 'K>>
                [<Obsolete("since version 6.6.0\nUse '.demandCommand()' or '.demandOption()' instead")>]
                abstract member demand<'K>: key: ResizeArray<'K> * ?msg: U2<string, bool> -> Yargs.index.yargs_.Argv<Yargs.index.yargs_.Defined<'T, 'K>>
                [<Obsolete("since version 6.6.0\nUse '.demandCommand()' or '.demandOption()' instead")>]
                abstract member demand<'K>: key: U2<'K, ResizeArray<'K>> * ?msg: U2<string, bool> -> Yargs.index.yargs_.Argv<Yargs.index.yargs_.Defined<'T, 'K>>
                abstract member demand: key: string * ?required: bool -> Yargs.index.yargs_.Argv<'T>
                abstract member demand: key: ResizeArray<string> * ?required: bool -> Yargs.index.yargs_.Argv<'T>
                abstract member demand: key: U2<string, ResizeArray<string>> * ?required: bool -> Yargs.index.yargs_.Argv<'T>
                abstract member demand: positionals: float * msg: string -> Yargs.index.yargs_.Argv<'T>
                abstract member demand: positionals: float * ?required: bool -> Yargs.index.yargs_.Argv<'T>
                abstract member demand: positionals: float * max: float * ?msg: string -> Yargs.index.yargs_.Argv<'T>
                /// <param name="key">
                /// If is a string, show the usage information and exit if key wasn't specified in <c>process.argv</c>.
                /// If is an array, demand each element.
                /// </param>
                /// <param name="msg">
                /// If string is given, it will be printed when the argument is missing, instead of the standard error message.
                /// </param>
                /// <param name="demand">
                /// Controls whether the option is demanded; this is useful when using .options() to specify command line parameters.
                /// </param>
                abstract member demandOption<'K>: key: 'K * ?msg: U2<string, bool> -> Yargs.index.yargs_.Argv<Yargs.index.yargs_.Defined<'T, 'K>>
                /// <param name="key">
                /// If is a string, show the usage information and exit if key wasn't specified in <c>process.argv</c>.
                /// If is an array, demand each element.
                /// </param>
                /// <param name="msg">
                /// If string is given, it will be printed when the argument is missing, instead of the standard error message.
                /// </param>
                /// <param name="demand">
                /// Controls whether the option is demanded; this is useful when using .options() to specify command line parameters.
                /// </param>
                abstract member demandOption<'K>: key: ResizeArray<'K> * ?msg: U2<string, bool> -> Yargs.index.yargs_.Argv<Yargs.index.yargs_.Defined<'T, 'K>>
                /// <param name="key">
                /// If is a string, show the usage information and exit if key wasn't specified in <c>process.argv</c>.
                /// If is an array, demand each element.
                /// </param>
                /// <param name="msg">
                /// If string is given, it will be printed when the argument is missing, instead of the standard error message.
                /// </param>
                /// <param name="demand">
                /// Controls whether the option is demanded; this is useful when using .options() to specify command line parameters.
                /// </param>
                abstract member demandOption<'K>: key: U2<'K, ResizeArray<'K>> * ?msg: U2<string, bool> -> Yargs.index.yargs_.Argv<Yargs.index.yargs_.Defined<'T, 'K>>
                abstract member demandOption: key: string * ?demand: bool -> Yargs.index.yargs_.Argv<'T>
                abstract member demandOption: key: ResizeArray<string> * ?demand: bool -> Yargs.index.yargs_.Argv<'T>
                abstract member demandOption: key: U2<string, ResizeArray<string>> * ?demand: bool -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Demand in context of commands.
                /// You can demand a minimum and a maximum number a user can have within your program, as well as provide corresponding error messages if either of the demands is not met.
                /// </summary>
                abstract member demandCommand: unit -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Demand in context of commands.
                /// You can demand a minimum and a maximum number a user can have within your program, as well as provide corresponding error messages if either of the demands is not met.
                /// </summary>
                abstract member demandCommand: min: float * ?minMsg: string -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Demand in context of commands.
                /// You can demand a minimum and a maximum number a user can have within your program, as well as provide corresponding error messages if either of the demands is not met.
                /// </summary>
                abstract member demandCommand: min: float * max: float * ?minMsg: string * ?maxMsg: string -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Shows a [deprecated] notice in front of the option
                /// </summary>
                abstract member deprecateOption: option: string * ?msg: string -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Describe a <c>key</c> for the generated usage information.
                ///
                /// Optionally <c>.describe()</c> can take an object that maps keys to descriptions.
                /// </summary>
                abstract member describe: key: string * description: string -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Describe a <c>key</c> for the generated usage information.
                ///
                /// Optionally <c>.describe()</c> can take an object that maps keys to descriptions.
                /// </summary>
                abstract member describe: key: ResizeArray<string> * description: string -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Describe a <c>key</c> for the generated usage information.
                ///
                /// Optionally <c>.describe()</c> can take an object that maps keys to descriptions.
                /// </summary>
                abstract member describe: key: U2<string, ResizeArray<string>> * description: string -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Describe a <c>key</c> for the generated usage information.
                ///
                /// Optionally <c>.describe()</c> can take an object that maps keys to descriptions.
                /// </summary>
                abstract member describe: descriptions: Argv.describe.descriptions -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Should yargs attempt to detect the os' locale? Defaults to <c>true</c>.
                /// </summary>
                abstract member detectLocale: detect: bool -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Tell yargs to parse environment variables matching the given prefix and apply them to argv as though they were command line arguments.
                ///
                /// Use the "__" separator in the environment variable to indicate nested options. (e.g. prefix_nested__foo => nested.foo)
                ///
                /// If this method is called with no argument or with an empty string or with true, then all env vars will be applied to argv.
                ///
                /// Program arguments are defined in this order of precedence:
                /// 1. Command line args
                /// 2. Env vars
                /// 3. Config file/objects
                /// 4. Configured defaults
                ///
                /// Env var parsing is disabled by default, but you can also explicitly disable it by calling <c>.env(false)</c>, e.g. if you need to undo previous configuration.
                /// </summary>
                abstract member env: unit -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Tell yargs to parse environment variables matching the given prefix and apply them to argv as though they were command line arguments.
                ///
                /// Use the "__" separator in the environment variable to indicate nested options. (e.g. prefix_nested__foo => nested.foo)
                ///
                /// If this method is called with no argument or with an empty string or with true, then all env vars will be applied to argv.
                ///
                /// Program arguments are defined in this order of precedence:
                /// 1. Command line args
                /// 2. Env vars
                /// 3. Config file/objects
                /// 4. Configured defaults
                ///
                /// Env var parsing is disabled by default, but you can also explicitly disable it by calling <c>.env(false)</c>, e.g. if you need to undo previous configuration.
                /// </summary>
                abstract member env: prefix: string -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Tell yargs to parse environment variables matching the given prefix and apply them to argv as though they were command line arguments.
                ///
                /// Use the "__" separator in the environment variable to indicate nested options. (e.g. prefix_nested__foo => nested.foo)
                ///
                /// If this method is called with no argument or with an empty string or with true, then all env vars will be applied to argv.
                ///
                /// Program arguments are defined in this order of precedence:
                /// 1. Command line args
                /// 2. Env vars
                /// 3. Config file/objects
                /// 4. Configured defaults
                ///
                /// Env var parsing is disabled by default, but you can also explicitly disable it by calling <c>.env(false)</c>, e.g. if you need to undo previous configuration.
                /// </summary>
                abstract member env: enable: bool -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// A message to print at the end of the usage instructions
                /// </summary>
                abstract member epilog: msg: string -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// A message to print at the end of the usage instructions
                /// </summary>
                abstract member epilogue: msg: string -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Give some example invocations of your program.
                /// Inside <c>cmd</c>, the string <c>$0</c> will get interpolated to the current script name or node command for the present script similar to how <c>$0</c> works in bash or perl.
                /// Examples will be printed out as part of the help message.
                /// </summary>
                abstract member example: command: string * description: string -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Give some example invocations of your program.
                /// Inside <c>cmd</c>, the string <c>$0</c> will get interpolated to the current script name or node command for the present script similar to how <c>$0</c> works in bash or perl.
                /// Examples will be printed out as part of the help message.
                /// </summary>
                abstract member example: command: ResizeArray<string * string option> -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Manually indicate that the program should exit, and provide context about why we wanted to exit. Follows the behavior set by <c>.exitProcess().</c>
                /// </summary>
                abstract member exit: code: float * err: Exception -> unit
                /// <summary>
                /// By default, yargs exits the process when the user passes a help flag, the user uses the <c>.version</c> functionality, validation fails, or the command handler fails.
                /// Calling <c>.exitProcess(false)</c> disables this behavior, enabling further actions after yargs have been validated.
                /// </summary>
                abstract member exitProcess: enabled: bool -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Method to execute when a failure occurs, rather than printing the failure message.
                /// </summary>
                /// <param name="func">
                /// Is called with the failure message that would have been printed, the Error instance originally thrown and yargs state when the failure occurred.
                /// </param>
                abstract member fail: func: Argv.fail.func<'T> -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Method to execute when a failure occurs, rather than printing the failure message.
                /// </summary>
                /// <param name="func">
                /// Is called with the failure message that would have been printed, the Error instance originally thrown and yargs state when the failure occurred.
                /// </param>
                abstract member fail: func: bool -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Method to execute when a failure occurs, rather than printing the failure message.
                /// </summary>
                /// <param name="func">
                /// Is called with the failure message that would have been printed, the Error instance originally thrown and yargs state when the failure occurred.
                /// </param>
                abstract member fail: func: U2<Argv.fail.func.U2.Case1<'T>, bool> -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Allows to programmatically get completion choices for any line.
                /// </summary>
                /// <param name="args">
                /// An array of the words in the command line to complete.
                /// </param>
                /// <param name="done">
                /// The callback to be called with the resulting completions.
                /// </param>
                abstract member getCompletion: args: ResizeArray<string> * ``done``: Argv.getCompletion.``done`` -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Allows to programmatically get completion choices for any line.
                /// </summary>
                abstract member getCompletion: args: ResizeArray<string> * ?``done``: obj -> JS.Promise<ReadonlyArray<string>>
                /// <summary>
                /// Returns a promise which resolves to a string containing the help text.
                /// </summary>
                abstract member getHelp: unit -> JS.Promise<string>
                /// <summary>
                /// Indicate that an option (or group of options) should not be reset when a command is executed
                ///
                /// Options default to being global.
                /// </summary>
                abstract member ``global``: key: string -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Indicate that an option (or group of options) should not be reset when a command is executed
                ///
                /// Options default to being global.
                /// </summary>
                abstract member ``global``: key: ResizeArray<string> -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Indicate that an option (or group of options) should not be reset when a command is executed
                ///
                /// Options default to being global.
                /// </summary>
                abstract member ``global``: key: U2<string, ResizeArray<string>> -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Given a key, or an array of keys, places options under an alternative heading when displaying usage instructions
                /// </summary>
                abstract member group: key: string * groupName: string -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Given a key, or an array of keys, places options under an alternative heading when displaying usage instructions
                /// </summary>
                abstract member group: key: ResizeArray<string> * groupName: string -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Given a key, or an array of keys, places options under an alternative heading when displaying usage instructions
                /// </summary>
                abstract member group: key: U2<string, ResizeArray<string>> * groupName: string -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Hides a key from the generated usage information. Unless a <c>--show-hidden</c> option is also passed with <c>--help</c> (see <c>showHidden()</c>).
                /// </summary>
                abstract member hide: key: string -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Configure an (e.g. <c>--help</c>) and implicit command that displays the usage string and exits the process.
                /// By default yargs enables help on the <c>--help</c> option.
                ///
                /// Note that any multi-char aliases (e.g. <c>help</c>) used for the help option will also be used for the implicit command.
                /// If there are no multi-char aliases (e.g. <c>h</c>), then all single-char aliases will be used for the command.
                ///
                /// If invoked without parameters, <c>.help()</c> will use <c>--help</c> as the option and help as the implicit command to trigger help output.
                /// </summary>
                /// <param name="description">
                /// Customizes the description of the help option in the usage string.
                /// </param>
                /// <param name="enableExplicit">
                /// If <c>false</c> is provided, it will disable --help.
                /// </param>
                abstract member help: unit -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Configure an (e.g. <c>--help</c>) and implicit command that displays the usage string and exits the process.
                /// By default yargs enables help on the <c>--help</c> option.
                ///
                /// Note that any multi-char aliases (e.g. <c>help</c>) used for the help option will also be used for the implicit command.
                /// If there are no multi-char aliases (e.g. <c>h</c>), then all single-char aliases will be used for the command.
                ///
                /// If invoked without parameters, <c>.help()</c> will use <c>--help</c> as the option and help as the implicit command to trigger help output.
                /// </summary>
                abstract member help: enableExplicit: bool -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Configure an (e.g. <c>--help</c>) and implicit command that displays the usage string and exits the process.
                /// By default yargs enables help on the <c>--help</c> option.
                ///
                /// Note that any multi-char aliases (e.g. <c>help</c>) used for the help option will also be used for the implicit command.
                /// If there are no multi-char aliases (e.g. <c>h</c>), then all single-char aliases will be used for the command.
                ///
                /// If invoked without parameters, <c>.help()</c> will use <c>--help</c> as the option and help as the implicit command to trigger help output.
                /// </summary>
                abstract member help: option: string * enableExplicit: bool -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Configure an (e.g. <c>--help</c>) and implicit command that displays the usage string and exits the process.
                /// By default yargs enables help on the <c>--help</c> option.
                ///
                /// Note that any multi-char aliases (e.g. <c>help</c>) used for the help option will also be used for the implicit command.
                /// If there are no multi-char aliases (e.g. <c>h</c>), then all single-char aliases will be used for the command.
                ///
                /// If invoked without parameters, <c>.help()</c> will use <c>--help</c> as the option and help as the implicit command to trigger help output.
                /// </summary>
                abstract member help: option: string * ?description: string * ?enableExplicit: bool -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Given the key <c>x</c> is set, it is required that the key <c>y</c> is set.
                /// y<c> can either be the name of an argument to imply, a number indicating the position of an argument or an array of multiple implications to associate with </c>x<c>.
                ///
                /// Optionally </c>.implies()` can accept an object specifying multiple implications.
                /// </summary>
                abstract member implies: key: string * value: string -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Given the key <c>x</c> is set, it is required that the key <c>y</c> is set.
                /// y<c> can either be the name of an argument to imply, a number indicating the position of an argument or an array of multiple implications to associate with </c>x<c>.
                ///
                /// Optionally </c>.implies()` can accept an object specifying multiple implications.
                /// </summary>
                abstract member implies: key: string * value: ResizeArray<string> -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Given the key <c>x</c> is set, it is required that the key <c>y</c> is set.
                /// y<c> can either be the name of an argument to imply, a number indicating the position of an argument or an array of multiple implications to associate with </c>x<c>.
                ///
                /// Optionally </c>.implies()` can accept an object specifying multiple implications.
                /// </summary>
                abstract member implies: key: string * value: U2<string, ResizeArray<string>> -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Given the key <c>x</c> is set, it is required that the key <c>y</c> is set.
                /// y<c> can either be the name of an argument to imply, a number indicating the position of an argument or an array of multiple implications to associate with </c>x<c>.
                ///
                /// Optionally </c>.implies()` can accept an object specifying multiple implications.
                /// </summary>
                abstract member implies: implies: Argv.implies.implies -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Return the locale that yargs is currently using.
                ///
                /// By default, yargs will auto-detect the operating system's locale so that yargs-generated help content will display in the user's language.
                /// Override the auto-detected locale from the user's operating system with a static locale.
                /// Note that the OS locale can be modified by setting/exporting the <c>LC_ALL</c> environment variable.
                /// </summary>
                abstract member locale: unit -> string
                /// <summary>
                /// Return the locale that yargs is currently using.
                ///
                /// By default, yargs will auto-detect the operating system's locale so that yargs-generated help content will display in the user's language.
                /// Override the auto-detected locale from the user's operating system with a static locale.
                /// Note that the OS locale can be modified by setting/exporting the <c>LC_ALL</c> environment variable.
                /// </summary>
                abstract member locale: loc: string -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Define global middleware functions to be called first, in list order, for all cli command.
                /// </summary>
                /// <param name="callbacks">
                /// Can be a function or a list of functions. Each callback gets passed a reference to argv.
                /// </param>
                /// <param name="applyBeforeValidation">
                /// Set to <c>true</c> to apply middleware before validation. This will execute the middleware prior to validation checks, but after parsing.
                /// </param>
                abstract member middleware: callbacks: Yargs.index.yargs_.MiddlewareFunction<'T> * ?applyBeforeValidation: bool -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Define global middleware functions to be called first, in list order, for all cli command.
                /// </summary>
                /// <param name="callbacks">
                /// Can be a function or a list of functions. Each callback gets passed a reference to argv.
                /// </param>
                /// <param name="applyBeforeValidation">
                /// Set to <c>true</c> to apply middleware before validation. This will execute the middleware prior to validation checks, but after parsing.
                /// </param>
                abstract member middleware: callbacks: ResizeArray<Yargs.index.yargs_.MiddlewareFunction<'T>> * ?applyBeforeValidation: bool -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Define global middleware functions to be called first, in list order, for all cli command.
                /// </summary>
                /// <param name="callbacks">
                /// Can be a function or a list of functions. Each callback gets passed a reference to argv.
                /// </param>
                /// <param name="applyBeforeValidation">
                /// Set to <c>true</c> to apply middleware before validation. This will execute the middleware prior to validation checks, but after parsing.
                /// </param>
                abstract member middleware: callbacks: U2<Yargs.index.yargs_.MiddlewareFunction<'T>, ResizeArray<Yargs.index.yargs_.MiddlewareFunction<'T>>> * ?applyBeforeValidation: bool -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// The number of arguments that should be consumed after a key. This can be a useful hint to prevent parsing ambiguity.
                ///
                /// Optionally <c>.nargs()</c> can take an object of <c>key</c>/<c>narg</c> pairs.
                /// </summary>
                abstract member nargs: key: string * count: float -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// The number of arguments that should be consumed after a key. This can be a useful hint to prevent parsing ambiguity.
                ///
                /// Optionally <c>.nargs()</c> can take an object of <c>key</c>/<c>narg</c> pairs.
                /// </summary>
                abstract member nargs: nargs: Argv.nargs.nargs -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// The key provided represents a path and should have <c>path.normalize()</c> applied.
                /// </summary>
                abstract member normalize<'K>: key: 'K -> Yargs.index.yargs_.Argv<obj>
                /// <summary>
                /// The key provided represents a path and should have <c>path.normalize()</c> applied.
                /// </summary>
                abstract member normalize<'K>: key: ResizeArray<'K> -> Yargs.index.yargs_.Argv<obj>
                /// <summary>
                /// The key provided represents a path and should have <c>path.normalize()</c> applied.
                /// </summary>
                abstract member normalize<'K>: key: U2<'K, ResizeArray<'K>> -> Yargs.index.yargs_.Argv<obj>
                /// <summary>
                /// Tell the parser to always interpret key as a number.
                ///
                /// If <c>key</c> is an array, all elements will be parsed as numbers.
                ///
                /// If the option is given on the command line without a value, <c>argv</c> will be populated with <c>undefined</c>.
                ///
                /// If the value given on the command line cannot be parsed as a number, <c>argv</c> will be populated with <c>NaN</c>.
                ///
                /// Note that decimals, hexadecimals, and scientific notation are all accepted.
                /// </summary>
                abstract member number<'K>: key: 'K -> Yargs.index.yargs_.Argv<obj>
                /// <summary>
                /// Tell the parser to always interpret key as a number.
                ///
                /// If <c>key</c> is an array, all elements will be parsed as numbers.
                ///
                /// If the option is given on the command line without a value, <c>argv</c> will be populated with <c>undefined</c>.
                ///
                /// If the value given on the command line cannot be parsed as a number, <c>argv</c> will be populated with <c>NaN</c>.
                ///
                /// Note that decimals, hexadecimals, and scientific notation are all accepted.
                /// </summary>
                abstract member number<'K>: key: ResizeArray<'K> -> Yargs.index.yargs_.Argv<obj>
                /// <summary>
                /// Tell the parser to always interpret key as a number.
                ///
                /// If <c>key</c> is an array, all elements will be parsed as numbers.
                ///
                /// If the option is given on the command line without a value, <c>argv</c> will be populated with <c>undefined</c>.
                ///
                /// If the value given on the command line cannot be parsed as a number, <c>argv</c> will be populated with <c>NaN</c>.
                ///
                /// Note that decimals, hexadecimals, and scientific notation are all accepted.
                /// </summary>
                abstract member number<'K>: key: U2<'K, ResizeArray<'K>> -> Yargs.index.yargs_.Argv<obj>
                /// <summary>
                /// Method to execute when a command finishes successfully.
                /// </summary>
                /// <param name="func">
                /// Is called with the successful result of the command that finished.
                /// </param>
                abstract member onFinishCommand: func: (obj -> unit) -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// This method can be used to make yargs aware of options that could exist.
                /// You can also pass an opt object which can hold further customization, like <c>.alias()</c>, <c>.demandOption()</c> etc. for that option.
                /// </summary>
                abstract member option<'K, 'O>: key: 'K * options: 'O -> Yargs.index.yargs_.Argv<obj>
                /// <summary>
                /// This method can be used to make yargs aware of options that could exist.
                /// You can also pass an opt object which can hold further customization, like <c>.alias()</c>, <c>.demandOption()</c> etc. for that option.
                /// </summary>
                abstract member option<'O>: options: 'O -> Yargs.index.yargs_.Argv<obj>
                /// <summary>
                /// This method can be used to make yargs aware of options that could exist.
                /// You can also pass an opt object which can hold further customization, like <c>.alias()</c>, <c>.demandOption()</c> etc. for that option.
                /// </summary>
                abstract member options<'K, 'O>: key: 'K * options: 'O -> Yargs.index.yargs_.Argv<obj>
                /// <summary>
                /// This method can be used to make yargs aware of options that could exist.
                /// You can also pass an opt object which can hold further customization, like <c>.alias()</c>, <c>.demandOption()</c> etc. for that option.
                /// </summary>
                abstract member options<'O>: options: 'O -> Yargs.index.yargs_.Argv<obj>
                /// <summary>
                /// Parse <c>args</c> instead of <c>process.argv</c>. Returns the <c>argv</c> object. <c>args</c> may either be a pre-processed argv array, or a raw argument string.
                ///
                /// Note: Providing a callback to parse() disables the <c>exitProcess</c> setting until after the callback is invoked.
                /// </summary>
                /// <param name="context">
                /// Provides a useful mechanism for passing state information to commands
                /// </param>
                abstract member parse: unit -> U2<Yargs.index.yargs_.Arguments<'T>, JS.Promise<Yargs.index.yargs_.Arguments<'T>>>
                /// <summary>
                /// Parse <c>args</c> instead of <c>process.argv</c>. Returns the <c>argv</c> object. <c>args</c> may either be a pre-processed argv array, or a raw argument string.
                ///
                /// Note: Providing a callback to parse() disables the <c>exitProcess</c> setting until after the callback is invoked.
                /// </summary>
                abstract member parse: arg: string * ?context: obj * ?parseCallback: Yargs.index.yargs_.ParseCallback<'T> -> U2<Yargs.index.yargs_.Arguments<'T>, JS.Promise<Yargs.index.yargs_.Arguments<'T>>>
                /// <summary>
                /// Parse <c>args</c> instead of <c>process.argv</c>. Returns the <c>argv</c> object. <c>args</c> may either be a pre-processed argv array, or a raw argument string.
                ///
                /// Note: Providing a callback to parse() disables the <c>exitProcess</c> setting until after the callback is invoked.
                /// </summary>
                abstract member parse: arg: ResizeArray<string> * ?context: obj * ?parseCallback: Yargs.index.yargs_.ParseCallback<'T> -> U2<Yargs.index.yargs_.Arguments<'T>, JS.Promise<Yargs.index.yargs_.Arguments<'T>>>
                /// <summary>
                /// Parse <c>args</c> instead of <c>process.argv</c>. Returns the <c>argv</c> object. <c>args</c> may either be a pre-processed argv array, or a raw argument string.
                ///
                /// Note: Providing a callback to parse() disables the <c>exitProcess</c> setting until after the callback is invoked.
                /// </summary>
                abstract member parse: arg: U2<string, ResizeArray<string>> * ?context: obj * ?parseCallback: Yargs.index.yargs_.ParseCallback<'T> -> U2<Yargs.index.yargs_.Arguments<'T>, JS.Promise<Yargs.index.yargs_.Arguments<'T>>>
                abstract member parseSync: unit -> Yargs.index.yargs_.Arguments<'T>
                abstract member parseSync: arg: string * ?context: obj * ?parseCallback: Yargs.index.yargs_.ParseCallback<'T> -> Yargs.index.yargs_.Arguments<'T>
                abstract member parseSync: arg: ResizeArray<string> * ?context: obj * ?parseCallback: Yargs.index.yargs_.ParseCallback<'T> -> Yargs.index.yargs_.Arguments<'T>
                abstract member parseSync: arg: U2<string, ResizeArray<string>> * ?context: obj * ?parseCallback: Yargs.index.yargs_.ParseCallback<'T> -> Yargs.index.yargs_.Arguments<'T>
                abstract member parseAsync: unit -> JS.Promise<Yargs.index.yargs_.Arguments<'T>>
                abstract member parseAsync: arg: string * ?context: obj * ?parseCallback: Yargs.index.yargs_.ParseCallback<'T> -> JS.Promise<Yargs.index.yargs_.Arguments<'T>>
                abstract member parseAsync: arg: ResizeArray<string> * ?context: obj * ?parseCallback: Yargs.index.yargs_.ParseCallback<'T> -> JS.Promise<Yargs.index.yargs_.Arguments<'T>>
                abstract member parseAsync: arg: U2<string, ResizeArray<string>> * ?context: obj * ?parseCallback: Yargs.index.yargs_.ParseCallback<'T> -> JS.Promise<Yargs.index.yargs_.Arguments<'T>>
                /// <summary>
                /// If the arguments have not been parsed, this property is <c>false</c>.
                ///
                /// If the arguments have been parsed, this contain detailed parsed arguments.
                /// </summary>
                abstract member parsed: U2<YargsParser.yargsParser_.DetailedArguments, bool> with get, set
                /// <summary>
                /// Allows to configure advanced yargs features.
                /// </summary>
                abstract member parserConfiguration: configuration: Argv.parserConfiguration.configuration -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Similar to <c>config()</c>, indicates that yargs should interpret the object from the specified key in package.json as a configuration object.
                /// </summary>
                /// <param name="cwd">
                /// If provided, the package.json will be read from this location
                /// </param>
                abstract member pkgConf: key: string * ?cwd: string -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Similar to <c>config()</c>, indicates that yargs should interpret the object from the specified key in package.json as a configuration object.
                /// </summary>
                /// <param name="cwd">
                /// If provided, the package.json will be read from this location
                /// </param>
                abstract member pkgConf: key: ResizeArray<string> * ?cwd: string -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Similar to <c>config()</c>, indicates that yargs should interpret the object from the specified key in package.json as a configuration object.
                /// </summary>
                /// <param name="cwd">
                /// If provided, the package.json will be read from this location
                /// </param>
                abstract member pkgConf: key: U2<string, ResizeArray<string>> * ?cwd: string -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Allows you to configure a command's positional arguments with an API similar to <c>.option()</c>.
                /// <c>.positional()</c> should be called in a command's builder function, and is not available on the top-level yargs instance. If so, it will throw an error.
                /// </summary>
                abstract member positional<'K, 'O>: key: 'K * opt: 'O -> Yargs.index.yargs_.Argv<obj>
                /// <summary>
                /// Should yargs provide suggestions regarding similar commands if no matching command is found?
                /// </summary>
                abstract member recommendCommands: unit -> Yargs.index.yargs_.Argv<'T>
                [<Obsolete("since version 6.6.0\nUse '.demandCommand()' or '.demandOption()' instead")>]
                abstract member require<'K>: key: 'K * ?msg: U2<string, bool> -> Yargs.index.yargs_.Argv<Yargs.index.yargs_.Defined<'T, 'K>>
                [<Obsolete("since version 6.6.0\nUse '.demandCommand()' or '.demandOption()' instead")>]
                abstract member require<'K>: key: ResizeArray<'K> * ?msg: U2<string, bool> -> Yargs.index.yargs_.Argv<Yargs.index.yargs_.Defined<'T, 'K>>
                [<Obsolete("since version 6.6.0\nUse '.demandCommand()' or '.demandOption()' instead")>]
                abstract member require<'K>: key: U2<'K, ResizeArray<'K>> * ?msg: U2<string, bool> -> Yargs.index.yargs_.Argv<Yargs.index.yargs_.Defined<'T, 'K>>
                abstract member require: key: string * msg: string -> Yargs.index.yargs_.Argv<'T>
                abstract member require: key: string * required: bool -> Yargs.index.yargs_.Argv<'T>
                abstract member require: keys: ResizeArray<float> * msg: string -> Yargs.index.yargs_.Argv<'T>
                abstract member require: keys: ResizeArray<float> * required: bool -> Yargs.index.yargs_.Argv<'T>
                abstract member require: positionals: float * required: bool -> Yargs.index.yargs_.Argv<'T>
                abstract member require: positionals: float * msg: string -> Yargs.index.yargs_.Argv<'T>
                [<Obsolete("since version 6.6.0\nUse '.demandCommand()' or '.demandOption()' instead")>]
                abstract member required<'K>: key: 'K * ?msg: U2<string, bool> -> Yargs.index.yargs_.Argv<Yargs.index.yargs_.Defined<'T, 'K>>
                [<Obsolete("since version 6.6.0\nUse '.demandCommand()' or '.demandOption()' instead")>]
                abstract member required<'K>: key: ResizeArray<'K> * ?msg: U2<string, bool> -> Yargs.index.yargs_.Argv<Yargs.index.yargs_.Defined<'T, 'K>>
                [<Obsolete("since version 6.6.0\nUse '.demandCommand()' or '.demandOption()' instead")>]
                abstract member required<'K>: key: U2<'K, ResizeArray<'K>> * ?msg: U2<string, bool> -> Yargs.index.yargs_.Argv<Yargs.index.yargs_.Defined<'T, 'K>>
                abstract member required: key: string * msg: string -> Yargs.index.yargs_.Argv<'T>
                abstract member required: key: string * required: bool -> Yargs.index.yargs_.Argv<'T>
                abstract member required: keys: ResizeArray<float> * msg: string -> Yargs.index.yargs_.Argv<'T>
                abstract member required: keys: ResizeArray<float> * required: bool -> Yargs.index.yargs_.Argv<'T>
                abstract member required: positionals: float * required: bool -> Yargs.index.yargs_.Argv<'T>
                abstract member required: positionals: float * msg: string -> Yargs.index.yargs_.Argv<'T>
                abstract member requiresArg: key: string -> Yargs.index.yargs_.Argv<'T>
                abstract member requiresArg: key: ResizeArray<string> -> Yargs.index.yargs_.Argv<'T>
                abstract member requiresArg: key: U2<string, ResizeArray<string>> -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Set the name of your script ($0). Default is the base filename executed by node (<c>process.argv[1]</c>)
                /// </summary>
                abstract member scriptName: ``$0``: string -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Generate a bash completion script.
                /// Users of your application can install this script in their <c>.bashrc</c>, and yargs will provide completion shortcuts for commands and options.
                /// </summary>
                abstract member showCompletionScript: unit -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Configure the <c>--show-hidden</c> option that displays the hidden keys (see <c>hide()</c>).
                /// </summary>
                /// <param name="option">
                /// If <c>boolean</c>, it enables/disables this option altogether. i.e. hidden keys will be permanently hidden if first argument is <c>false</c>.
                /// If <c>string</c> it changes the key name ("--show-hidden").
                /// </param>
                /// <param name="description">
                /// Changes the default description ("Show hidden options")
                /// </param>
                abstract member showHidden: unit -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Configure the <c>--show-hidden</c> option that displays the hidden keys (see <c>hide()</c>).
                /// </summary>
                /// <param name="option">
                /// If <c>boolean</c>, it enables/disables this option altogether. i.e. hidden keys will be permanently hidden if first argument is <c>false</c>.
                /// If <c>string</c> it changes the key name ("--show-hidden").
                /// </param>
                /// <param name="description">
                /// Changes the default description ("Show hidden options")
                /// </param>
                abstract member showHidden: option: bool -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Configure the <c>--show-hidden</c> option that displays the hidden keys (see <c>hide()</c>).
                /// </summary>
                abstract member showHidden: option: string * ?description: string -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Print the usage data using the console function consoleLevel for printing.
                /// Provide the usage data as a string.
                /// </summary>
                /// <param name="consoleLevel">
                ///
                /// </param>
                abstract member showHelp: ?consoleLevel: string -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Print the usage data using the console function consoleLevel for printing.
                /// Provide the usage data as a string.
                /// </summary>
                /// <param name="printCallback">
                /// a function with a single argument.
                /// </param>
                abstract member showHelp: printCallback: (string -> unit) -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// By default, yargs outputs a usage string if any error is detected.
                /// Use the <c>.showHelpOnFail()</c> method to customize this behavior.
                /// </summary>
                /// <param name="enable">
                /// If <c>false</c>, the usage string is not output.
                /// </param>
                /// <param name="message">
                /// Message that is output after the error message.
                /// </param>
                abstract member showHelpOnFail: enable: bool * ?message: string -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Print the version data using the console function consoleLevel or the specified function.
                /// </summary>
                /// <param name="level">
                ///
                /// </param>
                abstract member showVersion: ?level: Argv.showVersion.level -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Specifies either a single option key (string), or an array of options. If any of the options is present, yargs validation is skipped.
                /// </summary>
                abstract member skipValidation: key: string -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Specifies either a single option key (string), or an array of options. If any of the options is present, yargs validation is skipped.
                /// </summary>
                abstract member skipValidation: key: ResizeArray<string> -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Specifies either a single option key (string), or an array of options. If any of the options is present, yargs validation is skipped.
                /// </summary>
                abstract member skipValidation: key: U2<string, ResizeArray<string>> -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Any command-line argument given that is not demanded, or does not have a corresponding description, will be reported as an error.
                ///
                /// Unrecognized commands will also be reported as errors.
                /// </summary>
                abstract member strict: unit -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Any command-line argument given that is not demanded, or does not have a corresponding description, will be reported as an error.
                ///
                /// Unrecognized commands will also be reported as errors.
                /// </summary>
                abstract member strict: enabled: bool -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Similar to .strict(), except that it only applies to unrecognized commands.
                /// A user can still provide arbitrary options, but unknown positional commands
                /// will raise an error.
                /// </summary>
                abstract member strictCommands: unit -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Similar to .strict(), except that it only applies to unrecognized commands.
                /// A user can still provide arbitrary options, but unknown positional commands
                /// will raise an error.
                /// </summary>
                abstract member strictCommands: enabled: bool -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Similar to <c>.strict()</c>, except that it only applies to unrecognized options. A
                /// user can still provide arbitrary positional options, but unknown options
                /// will raise an error.
                /// </summary>
                abstract member strictOptions: unit -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Similar to <c>.strict()</c>, except that it only applies to unrecognized options. A
                /// user can still provide arbitrary positional options, but unknown options
                /// will raise an error.
                /// </summary>
                abstract member strictOptions: enabled: bool -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Tell the parser logic not to interpret <c>key</c> as a number or boolean. This can be useful if you need to preserve leading zeros in an input.
                ///
                /// If <c>key</c> is an array, interpret all the elements as strings.
                ///
                /// <c>.string('_')</c> will result in non-hyphenated arguments being interpreted as strings, regardless of whether they resemble numbers.
                /// </summary>
                abstract member string<'K>: key: 'K -> Yargs.index.yargs_.Argv<obj>
                /// <summary>
                /// Tell the parser logic not to interpret <c>key</c> as a number or boolean. This can be useful if you need to preserve leading zeros in an input.
                ///
                /// If <c>key</c> is an array, interpret all the elements as strings.
                ///
                /// <c>.string('_')</c> will result in non-hyphenated arguments being interpreted as strings, regardless of whether they resemble numbers.
                /// </summary>
                abstract member string<'K>: key: ResizeArray<'K> -> Yargs.index.yargs_.Argv<obj>
                /// <summary>
                /// Tell the parser logic not to interpret <c>key</c> as a number or boolean. This can be useful if you need to preserve leading zeros in an input.
                ///
                /// If <c>key</c> is an array, interpret all the elements as strings.
                ///
                /// <c>.string('_')</c> will result in non-hyphenated arguments being interpreted as strings, regardless of whether they resemble numbers.
                /// </summary>
                abstract member string<'K>: key: U2<'K, ResizeArray<'K>> -> Yargs.index.yargs_.Argv<obj>
                abstract member terminalWidth: unit -> float
                abstract member updateLocale: obj: Argv.updateLocale.obj -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Override the default strings used by yargs with the key/value pairs provided in obj
                ///
                /// If you explicitly specify a locale(), you should do so before calling <c>updateStrings()</c>.
                /// </summary>
                abstract member updateStrings: obj: Argv.updateStrings.obj -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Set a usage message to show which commands to use.
                /// Inside <c>message</c>, the string <c>$0</c> will get interpolated to the current script name or node command for the present script similar to how <c>$0</c> works in bash or perl.
                ///
                /// If the optional <c>description</c>/<c>builder</c>/<c>handler</c> are provided, <c>.usage()</c> acts an an alias for <c>.command()</c>.
                /// This allows you to use <c>.usage()</c> to configure the default command that will be run as an entry-point to your application
                /// and allows you to provide configuration for the positional arguments accepted by your program:
                /// </summary>
                abstract member usage: message: string -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Set a usage message to show which commands to use.
                /// Inside <c>message</c>, the string <c>$0</c> will get interpolated to the current script name or node command for the present script similar to how <c>$0</c> works in bash or perl.
                ///
                /// If the optional <c>description</c>/<c>builder</c>/<c>handler</c> are provided, <c>.usage()</c> acts an an alias for <c>.command()</c>.
                /// This allows you to use <c>.usage()</c> to configure the default command that will be run as an entry-point to your application
                /// and allows you to provide configuration for the positional arguments accepted by your program:
                /// </summary>
                abstract member usage<'U>: command: string * description: string * ?builder: (Yargs.index.yargs_.Argv<'T> -> Yargs.index.yargs_.Argv<'U>) * ?handler: (Yargs.index.yargs_.ArgumentsCamelCase<'U> -> U2<unit, JS.Promise<unit>>) -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Set a usage message to show which commands to use.
                /// Inside <c>message</c>, the string <c>$0</c> will get interpolated to the current script name or node command for the present script similar to how <c>$0</c> works in bash or perl.
                ///
                /// If the optional <c>description</c>/<c>builder</c>/<c>handler</c> are provided, <c>.usage()</c> acts an an alias for <c>.command()</c>.
                /// This allows you to use <c>.usage()</c> to configure the default command that will be run as an entry-point to your application
                /// and allows you to provide configuration for the positional arguments accepted by your program:
                /// </summary>
                abstract member usage<'U>: command: ResizeArray<string> * description: string * ?builder: (Yargs.index.yargs_.Argv<'T> -> Yargs.index.yargs_.Argv<'U>) * ?handler: (Yargs.index.yargs_.ArgumentsCamelCase<'U> -> U2<unit, JS.Promise<unit>>) -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Set a usage message to show which commands to use.
                /// Inside <c>message</c>, the string <c>$0</c> will get interpolated to the current script name or node command for the present script similar to how <c>$0</c> works in bash or perl.
                ///
                /// If the optional <c>description</c>/<c>builder</c>/<c>handler</c> are provided, <c>.usage()</c> acts an an alias for <c>.command()</c>.
                /// This allows you to use <c>.usage()</c> to configure the default command that will be run as an entry-point to your application
                /// and allows you to provide configuration for the positional arguments accepted by your program:
                /// </summary>
                abstract member usage<'U>: command: U2<string, ResizeArray<string>> * description: string * ?builder: (Yargs.index.yargs_.Argv<'T> -> Yargs.index.yargs_.Argv<'U>) * ?handler: (Yargs.index.yargs_.ArgumentsCamelCase<'U> -> U2<unit, JS.Promise<unit>>) -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Set a usage message to show which commands to use.
                /// Inside <c>message</c>, the string <c>$0</c> will get interpolated to the current script name or node command for the present script similar to how <c>$0</c> works in bash or perl.
                ///
                /// If the optional <c>description</c>/<c>builder</c>/<c>handler</c> are provided, <c>.usage()</c> acts an an alias for <c>.command()</c>.
                /// This allows you to use <c>.usage()</c> to configure the default command that will be run as an entry-point to your application
                /// and allows you to provide configuration for the positional arguments accepted by your program:
                /// </summary>
                abstract member usage<'U>: command: string * showInHelp: bool * ?builder: (Yargs.index.yargs_.Argv<'T> -> Yargs.index.yargs_.Argv<'U>) * ?handler: (Yargs.index.yargs_.ArgumentsCamelCase<'U> -> U2<unit, JS.Promise<unit>>) -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Set a usage message to show which commands to use.
                /// Inside <c>message</c>, the string <c>$0</c> will get interpolated to the current script name or node command for the present script similar to how <c>$0</c> works in bash or perl.
                ///
                /// If the optional <c>description</c>/<c>builder</c>/<c>handler</c> are provided, <c>.usage()</c> acts an an alias for <c>.command()</c>.
                /// This allows you to use <c>.usage()</c> to configure the default command that will be run as an entry-point to your application
                /// and allows you to provide configuration for the positional arguments accepted by your program:
                /// </summary>
                abstract member usage<'U>: command: ResizeArray<string> * showInHelp: bool * ?builder: (Yargs.index.yargs_.Argv<'T> -> Yargs.index.yargs_.Argv<'U>) * ?handler: (Yargs.index.yargs_.ArgumentsCamelCase<'U> -> U2<unit, JS.Promise<unit>>) -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Set a usage message to show which commands to use.
                /// Inside <c>message</c>, the string <c>$0</c> will get interpolated to the current script name or node command for the present script similar to how <c>$0</c> works in bash or perl.
                ///
                /// If the optional <c>description</c>/<c>builder</c>/<c>handler</c> are provided, <c>.usage()</c> acts an an alias for <c>.command()</c>.
                /// This allows you to use <c>.usage()</c> to configure the default command that will be run as an entry-point to your application
                /// and allows you to provide configuration for the positional arguments accepted by your program:
                /// </summary>
                abstract member usage<'U>: command: U2<string, ResizeArray<string>> * showInHelp: bool * ?builder: (Yargs.index.yargs_.Argv<'T> -> Yargs.index.yargs_.Argv<'U>) * ?handler: (Yargs.index.yargs_.ArgumentsCamelCase<'U> -> U2<unit, JS.Promise<unit>>) -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Set a usage message to show which commands to use.
                /// Inside <c>message</c>, the string <c>$0</c> will get interpolated to the current script name or node command for the present script similar to how <c>$0</c> works in bash or perl.
                ///
                /// If the optional <c>description</c>/<c>builder</c>/<c>handler</c> are provided, <c>.usage()</c> acts an an alias for <c>.command()</c>.
                /// This allows you to use <c>.usage()</c> to configure the default command that will be run as an entry-point to your application
                /// and allows you to provide configuration for the positional arguments accepted by your program:
                /// </summary>
                abstract member usage<'O>: command: string * description: string * ?builder: 'O * ?handler: (Yargs.index.yargs_.ArgumentsCamelCase<Yargs.index.yargs_.InferredOptionTypes<'O>> -> U2<unit, JS.Promise<unit>>) -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Set a usage message to show which commands to use.
                /// Inside <c>message</c>, the string <c>$0</c> will get interpolated to the current script name or node command for the present script similar to how <c>$0</c> works in bash or perl.
                ///
                /// If the optional <c>description</c>/<c>builder</c>/<c>handler</c> are provided, <c>.usage()</c> acts an an alias for <c>.command()</c>.
                /// This allows you to use <c>.usage()</c> to configure the default command that will be run as an entry-point to your application
                /// and allows you to provide configuration for the positional arguments accepted by your program:
                /// </summary>
                abstract member usage<'O>: command: ResizeArray<string> * description: string * ?builder: 'O * ?handler: (Yargs.index.yargs_.ArgumentsCamelCase<Yargs.index.yargs_.InferredOptionTypes<'O>> -> U2<unit, JS.Promise<unit>>) -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Set a usage message to show which commands to use.
                /// Inside <c>message</c>, the string <c>$0</c> will get interpolated to the current script name or node command for the present script similar to how <c>$0</c> works in bash or perl.
                ///
                /// If the optional <c>description</c>/<c>builder</c>/<c>handler</c> are provided, <c>.usage()</c> acts an an alias for <c>.command()</c>.
                /// This allows you to use <c>.usage()</c> to configure the default command that will be run as an entry-point to your application
                /// and allows you to provide configuration for the positional arguments accepted by your program:
                /// </summary>
                abstract member usage<'O>: command: U2<string, ResizeArray<string>> * description: string * ?builder: 'O * ?handler: (Yargs.index.yargs_.ArgumentsCamelCase<Yargs.index.yargs_.InferredOptionTypes<'O>> -> U2<unit, JS.Promise<unit>>) -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Set a usage message to show which commands to use.
                /// Inside <c>message</c>, the string <c>$0</c> will get interpolated to the current script name or node command for the present script similar to how <c>$0</c> works in bash or perl.
                ///
                /// If the optional <c>description</c>/<c>builder</c>/<c>handler</c> are provided, <c>.usage()</c> acts an an alias for <c>.command()</c>.
                /// This allows you to use <c>.usage()</c> to configure the default command that will be run as an entry-point to your application
                /// and allows you to provide configuration for the positional arguments accepted by your program:
                /// </summary>
                abstract member usage<'O>: command: string * showInHelp: bool * ?builder: 'O * ?handler: (Yargs.index.yargs_.ArgumentsCamelCase<Yargs.index.yargs_.InferredOptionTypes<'O>> -> U2<unit, JS.Promise<unit>>) -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Set a usage message to show which commands to use.
                /// Inside <c>message</c>, the string <c>$0</c> will get interpolated to the current script name or node command for the present script similar to how <c>$0</c> works in bash or perl.
                ///
                /// If the optional <c>description</c>/<c>builder</c>/<c>handler</c> are provided, <c>.usage()</c> acts an an alias for <c>.command()</c>.
                /// This allows you to use <c>.usage()</c> to configure the default command that will be run as an entry-point to your application
                /// and allows you to provide configuration for the positional arguments accepted by your program:
                /// </summary>
                abstract member usage<'O>: command: ResizeArray<string> * showInHelp: bool * ?builder: 'O * ?handler: (Yargs.index.yargs_.ArgumentsCamelCase<Yargs.index.yargs_.InferredOptionTypes<'O>> -> U2<unit, JS.Promise<unit>>) -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Set a usage message to show which commands to use.
                /// Inside <c>message</c>, the string <c>$0</c> will get interpolated to the current script name or node command for the present script similar to how <c>$0</c> works in bash or perl.
                ///
                /// If the optional <c>description</c>/<c>builder</c>/<c>handler</c> are provided, <c>.usage()</c> acts an an alias for <c>.command()</c>.
                /// This allows you to use <c>.usage()</c> to configure the default command that will be run as an entry-point to your application
                /// and allows you to provide configuration for the positional arguments accepted by your program:
                /// </summary>
                abstract member usage<'O>: command: U2<string, ResizeArray<string>> * showInHelp: bool * ?builder: 'O * ?handler: (Yargs.index.yargs_.ArgumentsCamelCase<Yargs.index.yargs_.InferredOptionTypes<'O>> -> U2<unit, JS.Promise<unit>>) -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Add an option (e.g. <c>--version</c>) that displays the version number (given by the version parameter) and exits the process.
                /// By default yargs enables version for the <c>--version</c> option.
                ///
                /// If no arguments are passed to version (<c>.version()</c>), yargs will parse the package.json of your module and use its version value.
                ///
                /// If the boolean argument <c>false</c> is provided, it will disable <c>--version</c>.
                /// </summary>
                abstract member version: unit -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Add an option (e.g. <c>--version</c>) that displays the version number (given by the version parameter) and exits the process.
                /// By default yargs enables version for the <c>--version</c> option.
                ///
                /// If no arguments are passed to version (<c>.version()</c>), yargs will parse the package.json of your module and use its version value.
                ///
                /// If the boolean argument <c>false</c> is provided, it will disable <c>--version</c>.
                /// </summary>
                abstract member version: version: string -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Add an option (e.g. <c>--version</c>) that displays the version number (given by the version parameter) and exits the process.
                /// By default yargs enables version for the <c>--version</c> option.
                ///
                /// If no arguments are passed to version (<c>.version()</c>), yargs will parse the package.json of your module and use its version value.
                ///
                /// If the boolean argument <c>false</c> is provided, it will disable <c>--version</c>.
                /// </summary>
                abstract member version: enable: bool -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Add an option (e.g. <c>--version</c>) that displays the version number (given by the version parameter) and exits the process.
                /// By default yargs enables version for the <c>--version</c> option.
                ///
                /// If no arguments are passed to version (<c>.version()</c>), yargs will parse the package.json of your module and use its version value.
                ///
                /// If the boolean argument <c>false</c> is provided, it will disable <c>--version</c>.
                /// </summary>
                abstract member version: optionKey: string * version: string -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Add an option (e.g. <c>--version</c>) that displays the version number (given by the version parameter) and exits the process.
                /// By default yargs enables version for the <c>--version</c> option.
                ///
                /// If no arguments are passed to version (<c>.version()</c>), yargs will parse the package.json of your module and use its version value.
                ///
                /// If the boolean argument <c>false</c> is provided, it will disable <c>--version</c>.
                /// </summary>
                abstract member version: optionKey: string * description: string * version: string -> Yargs.index.yargs_.Argv<'T>
                /// <summary>
                /// Format usage output to wrap at columns many columns.
                ///
                /// By default wrap will be set to <c>Math.min(80, windowWidth)</c>. Use <c>.wrap(null)</c> to specify no column limit (no right-align).
                /// Use <c>.wrap(yargs.terminalWidth())</c> to maximize the width of yargs' usage instructions.
                /// </summary>
                abstract member wrap: columns: float option -> Yargs.index.yargs_.Argv<'T>

            [<AllowNullLiteral>]
            [<Interface>]
            type Arguments<'T> =
                /// <summary>
                /// Non-option arguments
                /// </summary>
                abstract member ``_``: ResizeArray<U2<string, float>> with get, set
                /// <summary>
                /// The script name or node command
                /// </summary>
                abstract member ``$0``: string with get, set
                [<EmitIndexer>]
                abstract member Item: argName: string -> obj with get, set

            [<AllowNullLiteral>]
            [<Interface>]
            type ArgumentsCamelCase<'T> =
                /// <summary>
                /// Non-option arguments
                /// </summary>
                abstract member ``_``: ResizeArray<U2<string, float>> with get, set
                /// <summary>
                /// The script name or node command
                /// </summary>
                abstract member ``$0``: string with get, set
                [<EmitIndexer>]
                abstract member Item: argName: string -> obj with get, set

            [<AllowNullLiteral>]
            [<Interface>]
            type RequireDirectoryOptions =
                /// <summary>
                /// Look for command modules in all subdirectories and apply them as a flattened (non-hierarchical) list.
                /// </summary>
                abstract member recurse: bool option with get, set
                /// <summary>
                /// The types of files to look for when requiring command modules.
                /// </summary>
                abstract member extensions: ReadonlyArray<string> option with get, set
                /// <summary>
                /// A synchronous function called for each command module encountered.
                /// Accepts <c>commandObject</c>, <c>pathToFile</c>, and <c>filename</c> as arguments.
                /// Returns <c>commandObject</c> to include the command; any falsy value to exclude/skip it.
                /// </summary>
                abstract member visit: RequireDirectoryOptions.visit option with get, set
                /// <summary>
                /// Whitelist certain modules
                /// </summary>
                abstract member ``include``: U2<RegExp, (string -> bool)> option with get, set
                /// <summary>
                /// Blacklist certain modules.
                /// </summary>
                abstract member exclude: U2<RegExp, (string -> bool)> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?recurse: bool, ?extensions: ReadonlyArray<string>, ?visit: RequireDirectoryOptions.visit, ?``include``: U2<RegExp, (string -> bool)>, ?exclude: U2<RegExp, (string -> bool)>) : RequireDirectoryOptions = nativeOnly

            [<AllowNullLiteral>]
            [<Interface>]
            type Options =
                /// <summary>
                /// string or array of strings, alias(es) for the canonical option key, see <c>alias()</c>
                /// </summary>
                abstract member alias: U2<string, ReadonlyArray<string>> option with get, set
                /// <summary>
                /// boolean, interpret option as an array, see <c>array()</c>
                /// </summary>
                abstract member array: bool option with get, set
                /// <summary>
                /// boolean, interpret option as a boolean flag, see <c>boolean()</c>
                /// </summary>
                abstract member boolean: bool option with get, set
                /// <summary>
                /// value or array of values, limit valid option arguments to a predefined set, see <c>choices()</c>
                /// </summary>
                abstract member choices: Yargs.index.yargs_.Choices option with get, set
                /// <summary>
                /// function, coerce or transform parsed command line values into another value, see <c>coerce()</c>
                /// </summary>
                abstract member coerce: (obj -> unit) option with get, set
                /// <summary>
                /// boolean, interpret option as a path to a JSON config file, see <c>config()</c>
                /// </summary>
                abstract member config: bool option with get, set
                /// <summary>
                /// function, provide a custom config parsing function, see <c>config()</c>
                /// </summary>
                abstract member configParser: (string -> obj) option with get, set
                /// <summary>
                /// string or object, require certain keys not to be set, see <c>conflicts()</c>
                /// </summary>
                abstract member conflicts: U3<string, ReadonlyArray<string>, Options.conflicts.U3.Case3> option with get, set
                /// <summary>
                /// boolean, interpret option as a count of boolean flags, see <c>count()</c>
                /// </summary>
                abstract member count: bool option with get, set
                /// <summary>
                /// value, set a default value for the option, see <c>default()</c>
                /// </summary>
                abstract member ``default``: obj option with get, set
                /// <summary>
                /// string, use this description for the default value in help content, see <c>default()</c>
                /// </summary>
                abstract member defaultDescription: string option with get, set
                [<Obsolete("since version 6.6.0\nUse 'demandOption' instead")>]
                abstract member demand: U2<bool, string> option with get, set
                /// <summary>
                /// boolean or string, mark the argument as deprecated, see <c>deprecateOption()</c>
                /// </summary>
                abstract member deprecate: U2<bool, string> option with get, set
                /// <summary>
                /// boolean or string, mark the argument as deprecated, see <c>deprecateOption()</c>
                /// </summary>
                abstract member deprecated: U2<bool, string> option with get, set
                /// <summary>
                /// boolean or string, demand the option be given, with optional error message, see <c>demandOption()</c>
                /// </summary>
                abstract member demandOption: U2<bool, string> option with get, set
                /// <summary>
                /// string, the option description for help content, see <c>describe()</c>
                /// </summary>
                abstract member desc: string option with get, set
                /// <summary>
                /// string, the option description for help content, see <c>describe()</c>
                /// </summary>
                abstract member describe: string option with get, set
                /// <summary>
                /// string, the option description for help content, see <c>describe()</c>
                /// </summary>
                abstract member description: string option with get, set
                /// <summary>
                /// boolean, indicate that this key should not be reset when a command is invoked, see <c>global()</c>
                /// </summary>
                abstract member ``global``: bool option with get, set
                /// <summary>
                /// string, when displaying usage instructions place the option under an alternative group heading, see <c>group()</c>
                /// </summary>
                abstract member group: string option with get, set
                /// <summary>
                /// don't display option in help output.
                /// </summary>
                abstract member hidden: bool option with get, set
                /// <summary>
                /// string or object, require certain keys to be set, see <c>implies()</c>
                /// </summary>
                abstract member implies: U3<string, ReadonlyArray<string>, Options.implies.U3.Case3> option with get, set
                /// <summary>
                /// number, specify how many arguments should be consumed for the option, see <c>nargs()</c>
                /// </summary>
                abstract member nargs: float option with get, set
                /// <summary>
                /// boolean, apply path.normalize() to the option, see <c>normalize()</c>
                /// </summary>
                abstract member normalize: bool option with get, set
                /// <summary>
                /// boolean, interpret option as a number, <c>number()</c>
                /// </summary>
                abstract member number: bool option with get, set
                [<Obsolete("since version 6.6.0\nUse 'demandOption' instead")>]
                abstract member require: U2<bool, string> option with get, set
                [<Obsolete("since version 6.6.0\nUse 'demandOption' instead")>]
                abstract member required: U2<bool, string> option with get, set
                /// <summary>
                /// boolean, require the option be specified with a value, see <c>requiresArg()</c>
                /// </summary>
                abstract member requiresArg: bool option with get, set
                /// <summary>
                /// boolean, skips validation if the option is present, see <c>skipValidation()</c>
                /// </summary>
                abstract member skipValidation: bool option with get, set
                /// <summary>
                /// boolean, interpret option as a string, see <c>string()</c>
                /// </summary>
                abstract member string: bool option with get, set
                abstract member ``type``: Options.``type`` option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?alias: U2<string, ReadonlyArray<string>>, ?array: bool, ?boolean: bool, ?choices: Yargs.index.yargs_.Choices, ?coerce: (obj -> unit), ?config: bool, ?configParser: (string -> obj), ?conflicts: U3<string, ReadonlyArray<string>, Options.conflicts.U3.Case3>, ?count: bool, ?``default``: obj, ?defaultDescription: string, ?demand: U2<bool, string>, ?deprecate: U2<bool, string>, ?deprecated: U2<bool, string>, ?demandOption: U2<bool, string>, ?desc: string, ?describe: string, ?description: string, ?``global``: bool, ?group: string, ?hidden: bool, ?implies: U3<string, ReadonlyArray<string>, Options.implies.U3.Case3>, ?nargs: float, ?normalize: bool, ?number: bool, ?require: U2<bool, string>, ?required: U2<bool, string>, ?requiresArg: bool, ?skipValidation: bool, ?string: bool, ?``type``: Options.``type``) : Options = nativeOnly

            [<AllowNullLiteral>]
            [<Interface>]
            type PositionalOptions =
                /// <summary>
                /// string or array of strings, see <c>alias()</c>
                /// </summary>
                abstract member alias: U2<string, ReadonlyArray<string>> option with get, set
                /// <summary>
                /// boolean, interpret option as an array, see <c>array()</c>
                /// </summary>
                abstract member array: bool option with get, set
                /// <summary>
                /// value or array of values, limit valid option arguments to a predefined set, see <c>choices()</c>
                /// </summary>
                abstract member choices: Yargs.index.yargs_.Choices option with get, set
                /// <summary>
                /// function, coerce or transform parsed command line values into another value, see <c>coerce()</c>
                /// </summary>
                abstract member coerce: (obj -> unit) option with get, set
                /// <summary>
                /// string or object, require certain keys not to be set, see <c>conflicts()</c>
                /// </summary>
                abstract member conflicts: U3<string, ReadonlyArray<string>, PositionalOptions.conflicts.U3.Case3> option with get, set
                /// <summary>
                /// value, set a default value for the option, see <c>default()</c>
                /// </summary>
                abstract member ``default``: obj option with get, set
                /// <summary>
                /// boolean or string, demand the option be given, with optional error message, see <c>demandOption()</c>
                /// </summary>
                abstract member demandOption: U2<bool, string> option with get, set
                /// <summary>
                /// string, the option description for help content, see <c>describe()</c>
                /// </summary>
                abstract member desc: string option with get, set
                /// <summary>
                /// string, the option description for help content, see <c>describe()</c>
                /// </summary>
                abstract member describe: string option with get, set
                /// <summary>
                /// string, the option description for help content, see <c>describe()</c>
                /// </summary>
                abstract member description: string option with get, set
                /// <summary>
                /// string or object, require certain keys to be set, see <c>implies()</c>
                /// </summary>
                abstract member implies: U3<string, ReadonlyArray<string>, PositionalOptions.implies.U3.Case3> option with get, set
                /// <summary>
                /// boolean, apply path.normalize() to the option, see normalize()
                /// </summary>
                abstract member normalize: bool option with get, set
                abstract member ``type``: Yargs.index.yargs_.PositionalOptionsType option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?alias: U2<string, ReadonlyArray<string>>, ?array: bool, ?choices: Yargs.index.yargs_.Choices, ?coerce: (obj -> unit), ?conflicts: U3<string, ReadonlyArray<string>, PositionalOptions.conflicts.U3.Case3>, ?``default``: obj, ?demandOption: U2<bool, string>, ?desc: string, ?describe: string, ?description: string, ?implies: U3<string, ReadonlyArray<string>, PositionalOptions.implies.U3.Case3>, ?normalize: bool, ?``type``: Yargs.index.yargs_.PositionalOptionsType) : PositionalOptions = nativeOnly

            /// <summary>
            /// Convert literal string types like 'foo-bar' to 'FooBar'
            /// </summary>
            [<AllowNullLiteral>]
            [<Interface>]
            type PascalCase<'S> =
                interface end

            /// <summary>
            /// Convert literal string types like 'foo-bar' to 'fooBar'
            /// </summary>
            [<AllowNullLiteral>]
            [<Interface>]
            type CamelCase<'S> =
                interface end

            /// <summary>
            /// Convert literal string types like 'foo-bar' to 'fooBar', allowing all <c>PropertyKey</c> types
            /// </summary>
            [<AllowNullLiteral>]
            [<Interface>]
            type CamelCaseKey<'K> =
                interface end

            [<AllowNullLiteral>]
            [<Interface>]
            type Omit<'T, 'K> =
                [<EmitIndexer>]
                abstract member Item: key: string -> obj with get, set

            [<AllowNullLiteral>]
            [<Interface>]
            type Defined<'T, 'K when 'K :> obj> =
                interface end

            /// <summary>
            /// Convert T to T[] and T | undefined to T[] | undefined
            /// </summary>
            type ToArray<'T> =
                U2<ResizeArray<'T>, obj>

            /// <summary>
            /// Gives string[] if T is an array type, otherwise string. Preserves | undefined.
            /// </summary>
            [<AllowNullLiteral>]
            [<Interface>]
            type ToString<'T> =
                interface end

            /// <summary>
            /// Gives number[] if T is an array type, otherwise number. Preserves | undefined.
            /// </summary>
            [<AllowNullLiteral>]
            [<Interface>]
            type ToNumber<'T> =
                interface end

            [<AllowNullLiteral>]
            [<Interface>]
            type InferredOptionType<'O> =
                interface end

            [<AllowNullLiteral>]
            [<Interface>]
            type Alias<'O> =
                interface end

            [<AllowNullLiteral>]
            [<Interface>]
            type IsRequiredOrHasDefault<'O> =
                interface end

            [<AllowNullLiteral>]
            [<Interface>]
            type IsAny<'T> =
                interface end

            [<AllowNullLiteral>]
            [<Interface>]
            type IsUnknown<'T> =
                interface end

            [<AllowNullLiteral>]
            [<Interface>]
            type InferredOptionTypePrimitive<'O> =
                interface end

            [<AllowNullLiteral>]
            [<Interface>]
            type InferredOptionTypeInner<'O> =
                interface end

            [<AllowNullLiteral>]
            [<Interface>]
            type InferredOptionTypes<'O> =
                [<EmitIndexer>]
                abstract member Item: key: string -> obj with get, set

            [<AllowNullLiteral>]
            [<Interface>]
            type CommandModule<'T, 'U> =
                /// <summary>
                /// array of strings (or a single string) representing aliases of <c>exports.command</c>, positional args defined in an alias are ignored
                /// </summary>
                abstract member aliases: U2<ReadonlyArray<string>, string> option with get, set
                /// <summary>
                /// object declaring the options the command accepts, or a function accepting and returning a yargs instance
                /// </summary>
                abstract member builder: Yargs.index.yargs_.CommandBuilder<'T, 'U> option with get, set
                /// <summary>
                /// string (or array of strings) that executes this command when given on the command line, first string may contain positional args
                /// </summary>
                abstract member command: U2<ReadonlyArray<string>, string> option with get, set
                /// <summary>
                /// boolean (or string) to show deprecation notice
                /// </summary>
                abstract member deprecated: U2<bool, string> option with get, set
                /// <summary>
                /// string used as the description for the command in help text, use <c>false</c> for a hidden command
                /// </summary>
                abstract member describe: U2<string, bool> option with get, set
                /// <summary>
                /// a function which will be passed the parsed argv.
                /// </summary>
                abstract member handler: (Yargs.index.yargs_.ArgumentsCamelCase<'U> -> U2<unit, JS.Promise<unit>>) with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (handler: (Yargs.index.yargs_.ArgumentsCamelCase<'U> -> U2<unit, JS.Promise<unit>>), ?aliases: U2<ReadonlyArray<string>, string>, ?builder: Yargs.index.yargs_.CommandBuilder<'T, 'U>, ?command: U2<ReadonlyArray<string>, string>, ?deprecated: U2<bool, string>, ?describe: U2<string, bool>) : CommandModule<'T, 'U> = nativeOnly

            type ParseCallback<'T> =
                delegate of err: Exception option * argv: Yargs.index.yargs_.ArgumentsCamelCase<'T> * output: string -> U2<unit, JS.Promise<unit>>

            type CommandBuilder<'T, 'U> =
                U3<CommandBuilder.U3.Case1, (Yargs.index.yargs_.Argv<'T> -> Yargs.index.yargs_.Argv<'U>), (Yargs.index.yargs_.Argv<'T> -> unit)>

            type SyncCompletionFunction =
                delegate of current: string * argv: obj -> ResizeArray<string>

            type AsyncCompletionFunction =
                delegate of current: string * argv: obj * ``done``: (ResizeArray<string> -> unit) -> unit

            type PromiseCompletionFunction =
                delegate of current: string * argv: obj -> JS.Promise<ResizeArray<string>>

            type FallbackCompletionFunction =
                delegate of current: string * argv: obj * completionFilter: (Yargs.index.yargs_.CompletionCallback option -> unit) * ``done``: (ResizeArray<string> -> unit) -> unit

            type MiddlewareFunction<'T> =
                Yargs.index.yargs_.ArgumentsCamelCase<'T> -> U2<unit, JS.Promise<unit>>

            type Choices =
                ReadonlyArray<U3<string, float, bool> option>

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type PositionalOptionsType =
                | boolean
                | number
                | string

            type CompletionCallback =
                delegate of err: Exception option * completions: ResizeArray<string> option -> unit

            [<AllowNullLiteral>]
            [<Interface>]
            type BuilderArguments<'T, 'R> =
                interface end

            type Argv =
                Argv<obj>

            type Arguments =
                Arguments<obj>

            type ArgumentsCamelCase =
                ArgumentsCamelCase<obj>

            type PascalCase =
                PascalCase<string>

            type CamelCase =
                CamelCase<string>

            type CamelCaseKey =
                CamelCaseKey<obj>

            type InferredOptionType =
                InferredOptionType<U2<Yargs.index.yargs_.Options, Yargs.index.yargs_.PositionalOptions>>

            type Alias =
                Alias<U2<Yargs.index.yargs_.Options, Yargs.index.yargs_.PositionalOptions>>

            type IsRequiredOrHasDefault =
                IsRequiredOrHasDefault<U2<Yargs.index.yargs_.Options, Yargs.index.yargs_.PositionalOptions>>

            type InferredOptionTypePrimitive =
                InferredOptionTypePrimitive<U2<Yargs.index.yargs_.Options, Yargs.index.yargs_.PositionalOptions>>

            type InferredOptionTypeInner =
                InferredOptionTypeInner<U2<Yargs.index.yargs_.Options, Yargs.index.yargs_.PositionalOptions>>

            type CommandModule<'T> =
                CommandModule<'T, obj>

            type CommandModule =
                CommandModule<obj, obj>

            type ParseCallback =
                ParseCallback<obj>

            type CommandBuilder<'T> =
                CommandBuilder<'T, obj>

            type CommandBuilder =
                CommandBuilder<obj, obj>

            type MiddlewareFunction =
                MiddlewareFunction<obj>

            type BuilderArguments<'T> =
                BuilderArguments<'T, obj>

            module Argv =

                module alias =

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type aliases =
                        [<EmitIndexer>]
                        abstract member Item: shortName: string -> U2<string, ReadonlyArray<string>> with get, set

                module check =

                    type func<'T> =
                        delegate of argv: Yargs.index.yargs_.Arguments<'T> * aliases: Argv.check.func.aliases -> unit

                    module func =

                        [<AllowNullLiteral>]
                        [<Interface>]
                        type aliases =
                            [<EmitIndexer>]
                            abstract member Item: alias: string -> string with get, set

                module conflicts =

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type conflicts =
                        [<EmitIndexer>]
                        abstract member Item: key: string -> U2<string, ReadonlyArray<string>> with get, set

                module describe =

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type descriptions =
                        [<EmitIndexer>]
                        abstract member Item: key: string -> string with get, set

                module fail =

                    type func<'T> =
                        delegate of msg: string * err: Exception * yargs: Yargs.index.yargs_.Argv<'T> -> unit

                    module func =

                        module U2 =

                            type Case1<'T> =
                                delegate of msg: string * err: Exception * yargs: Yargs.index.yargs_.Argv<'T> -> unit

                module getCompletion =

                    type ``done`` =
                        delegate of err: Exception option * completions: ResizeArray<string> -> unit

                module implies =

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type implies =
                        [<EmitIndexer>]
                        abstract member Item: key: string -> U2<string, ReadonlyArray<string>> with get, set

                module nargs =

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type nargs =
                        [<EmitIndexer>]
                        abstract member Item: key: string -> float with get, set

                module parserConfiguration =

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type configuration =
                        /// <summary>
                        /// Should variables prefixed with --no be treated as negations? Default is <c>true</c>
                        /// </summary>
                        abstract member ``boolean-negation``: bool option with get, set
                        /// <summary>
                        /// Should hyphenated arguments be expanded into camel-case aliases? Default is <c>true</c>
                        /// </summary>
                        abstract member ``camel-case-expansion``: bool option with get, set
                        /// <summary>
                        /// Should arrays be combined when provided by both command line arguments and a configuration file. Default is <c>false</c>
                        /// </summary>
                        abstract member ``combine-arrays``: bool option with get, set
                        /// <summary>
                        /// Should keys that contain . be treated as objects? Default is <c>true</c>
                        /// </summary>
                        abstract member ``dot-notation``: bool option with get, set
                        /// <summary>
                        /// Should arguments be coerced into an array when duplicated. Default is <c>true</c>
                        /// </summary>
                        abstract member ``duplicate-arguments-array``: bool option with get, set
                        /// <summary>
                        /// Should array arguments be coerced into a single array when duplicated. Default is <c>true</c>
                        /// </summary>
                        abstract member ``flatten-duplicate-arrays``: bool option with get, set
                        /// <summary>
                        /// Should arrays consume more than one positional argument following their flag. Default is <c>true</c>
                        /// </summary>
                        abstract member ``greedy-arrays``: bool option with get, set
                        /// <summary>
                        /// Should nargs consume dash options as well as positional arguments. Default is <c>false</c>
                        /// </summary>
                        abstract member ``nargs-eats-options``: bool option with get, set
                        /// <summary>
                        /// Should parsing stop at the first text argument? This is similar to how e.g. ssh parses its command line. Default is <c>false</c>
                        /// </summary>
                        abstract member ``halt-at-non-option``: bool option with get, set
                        /// <summary>
                        /// The prefix to use for negated boolean variables. Default is <c>'no-'</c>
                        /// </summary>
                        abstract member ``negation-prefix``: string option with get, set
                        /// <summary>
                        /// Should keys that look like numbers be treated as such? Default is <c>true</c>
                        /// </summary>
                        abstract member ``parse-numbers``: bool option with get, set
                        /// <summary>
                        /// Should positional keys that look like numbers be treated as such? Default is <c>true</c>
                        /// </summary>
                        abstract member ``parse-positional-numbers``: bool option with get, set
                        /// <summary>
                        /// Should unparsed flags be stored in -- or _. Default is <c>false</c>
                        /// </summary>
                        abstract member ``populate--``: bool option with get, set
                        /// <summary>
                        /// Should a placeholder be added for keys not set via the corresponding CLI argument? Default is <c>false</c>
                        /// </summary>
                        abstract member ``set-placeholder-key``: bool option with get, set
                        /// <summary>
                        /// Should a group of short-options be treated as boolean flags? Default is <c>true</c>
                        /// </summary>
                        abstract member ``short-option-groups``: bool option with get, set
                        /// <summary>
                        /// Should aliases be removed before returning results? Default is <c>false</c>
                        /// </summary>
                        abstract member ``strip-aliased``: bool option with get, set
                        /// <summary>
                        /// Should dashed keys be removed before returning results? This option has no effect if camel-case-expansion is disabled. Default is <c>false</c>
                        /// </summary>
                        abstract member ``strip-dashed``: bool option with get, set
                        /// <summary>
                        /// Should unknown options be treated like regular arguments? An unknown option is one that is not configured in opts. Default is <c>false</c>
                        /// </summary>
                        abstract member ``unknown-options-as-args``: bool option with get, set
                        /// <summary>
                        /// Sort commands alphabetically. Default is <c>false</c>
                        /// </summary>
                        abstract member ``sort-commands``: bool option with get, set

                module showVersion =

                    [<RequireQualifiedAccess>]
                    [<Erase(CaseRules.None)>]
                    type level =
                        | error
                        | log
                        | Case1 of (string -> unit)

                        [<Emit("$0")>]
                        static member op_Implicit(value: (string -> unit)) : level = nativeOnly

                        [<Emit("$0")>]
                        static member op_ErasedCast(value: (string -> unit)) : level = nativeOnly

                module updateLocale =

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type obj =
                        [<EmitIndexer>]
                        abstract member Item: key: string -> string with get, set

                module updateStrings =

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type obj =
                        [<EmitIndexer>]
                        abstract member Item: key: string -> string with get, set

            module RequireDirectoryOptions =

                type visit =
                    delegate of commandObject: obj * ?pathToFile: string * ?filename: string -> unit

            module Options =

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type ``type`` =
                    | array
                    | count
                    | boolean
                    | number
                    | string

                module conflicts =

                    module U3 =

                        [<AllowNullLiteral>]
                        [<Interface>]
                        type Case3 =
                            [<EmitIndexer>]
                            abstract member Item: key: string -> U2<string, ReadonlyArray<string>> with get, set

                module implies =

                    module U3 =

                        [<AllowNullLiteral>]
                        [<Interface>]
                        type Case3 =
                            [<EmitIndexer>]
                            abstract member Item: key: string -> U2<string, ReadonlyArray<string>> with get, set

            module PositionalOptions =

                module conflicts =

                    module U3 =

                        [<AllowNullLiteral>]
                        [<Interface>]
                        type Case3 =
                            [<EmitIndexer>]
                            abstract member Item: key: string -> U2<string, ReadonlyArray<string>> with get, set

                module implies =

                    module U3 =

                        [<AllowNullLiteral>]
                        [<Interface>]
                        type Case3 =
                            [<EmitIndexer>]
                            abstract member Item: key: string -> U2<string, ReadonlyArray<string>> with get, set

            module CommandBuilder =

                module U3 =

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type Case1 =
                        [<EmitIndexer>]
                        abstract member Item: key: string -> Yargs.index.yargs_.Options with get, set

    module yargs =

        [<AbstractClass>]
        [<Erase>]
        type Exports =
            [<ImportDefault("yargs/yargs")>]
            static member Yargs () : Yargs.index.yargs_.Argv = nativeOnly
            [<ImportDefault("yargs/yargs")>]
            static member Yargs (processArgs: ResizeArray<string>, ?cwd: string, ?parentRequire: obj) : Yargs.index.yargs_.Argv = nativeOnly
            [<ImportDefault("yargs/yargs")>]
            static member Yargs (processArgs: string, ?cwd: string, ?parentRequire: obj) : Yargs.index.yargs_.Argv = nativeOnly

module YargsParser =

    [<AbstractClass>]
    [<Erase>]
    type Exports =
        [<ImportDefault("yargs-parser"); Emit("$0($1...)")>]
        static member yargsParser (argv: string, ?opts: YargsParser.yargsParser_.Options) : YargsParser.yargsParser_.Arguments = nativeOnly
        [<ImportDefault("yargs-parser"); Emit("$0($1...)")>]
        static member yargsParser (argv: ResizeArray<string>, ?opts: YargsParser.yargsParser_.Options) : YargsParser.yargsParser_.Arguments = nativeOnly
        [<ImportDefault("yargs-parser"); Emit("$0($1...)")>]
        static member yargsParser (argv: U2<string, ResizeArray<string>>, ?opts: YargsParser.yargsParser_.Options) : YargsParser.yargsParser_.Arguments = nativeOnly
        [<ImportDefault("yargs-parser"); Emit("$0.detailed($1...)")>]
        static member detailed (argv: U2<string, ResizeArray<string>>, ?opts: YargsParser.yargsParser_.Options) : YargsParser.yargsParser_.DetailedArguments = nativeOnly
        [<ImportDefault("yargs-parser"); Emit("$0.camelCase($1...)")>]
        static member camelCase (str: string) : string = nativeOnly
        [<ImportDefault("yargs-parser"); Emit("$0.decamelize($1...)")>]
        static member decamelize (str: string, ?joinString: string) : string = nativeOnly
        [<ImportDefault("yargs-parser"); Emit("$0.looksLikeNumber($1...)")>]
        static member looksLikeNumber (value: U2<string, float> option) : bool = nativeOnly

    module yargsParser_ =

        [<AllowNullLiteral>]
        [<Interface>]
        type Arguments =
            /// <summary>
            /// Non-option arguments
            /// </summary>
            abstract member ``_``: ResizeArray<U2<string, float>> with get, set
            /// <summary>
            /// Arguments after the end-of-options flag <c>--</c>
            /// </summary>
            abstract member ``--``: ResizeArray<U2<string, float>> option with get, set
            [<EmitIndexer>]
            abstract member Item: argName: string -> obj with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (``_``: ResizeArray<U2<string, float>>, ?``--``: ResizeArray<U2<string, float>>) : Arguments = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type DetailedArguments =
            /// <summary>
            /// An object representing the parsed value of <c>args</c>
            /// </summary>
            abstract member argv: YargsParser.yargsParser_.Arguments with get, set
            /// <summary>
            /// Populated with an error object if an exception occurred during parsing.
            /// </summary>
            abstract member error: Exception option with get, set
            /// <summary>
            /// The inferred list of aliases built by combining lists in opts.alias.
            /// </summary>
            abstract member aliases: DetailedArguments.aliases with get, set
            /// <summary>
            /// Any new aliases added via camel-case expansion.
            /// </summary>
            abstract member newAliases: DetailedArguments.newAliases with get, set
            /// <summary>
            /// The configuration loaded from the yargs stanza in package.json.
            /// </summary>
            abstract member configuration: YargsParser.yargsParser_.Configuration with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (argv: YargsParser.yargsParser_.Arguments, aliases: DetailedArguments.aliases, newAliases: DetailedArguments.newAliases, configuration: YargsParser.yargsParser_.Configuration, ?error: Exception) : DetailedArguments = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type Configuration =
            /// <summary>
            /// Should variables prefixed with --no be treated as negations? Default is <c>true</c>
            /// </summary>
            abstract member ``boolean-negation``: bool with get, set
            /// <summary>
            /// Should hyphenated arguments be expanded into camel-case aliases? Default is <c>true</c>
            /// </summary>
            abstract member ``camel-case-expansion``: bool with get, set
            /// <summary>
            /// Should arrays be combined when provided by both command line arguments and a configuration file. Default is <c>false</c>
            /// </summary>
            abstract member ``combine-arrays``: bool with get, set
            /// <summary>
            /// Should keys that contain . be treated as objects? Default is <c>true</c>
            /// </summary>
            abstract member ``dot-notation``: bool with get, set
            /// <summary>
            /// Should arguments be coerced into an array when duplicated. Default is <c>true</c>
            /// </summary>
            abstract member ``duplicate-arguments-array``: bool with get, set
            /// <summary>
            /// Should array arguments be coerced into a single array when duplicated. Default is <c>true</c>
            /// </summary>
            abstract member ``flatten-duplicate-arrays``: bool with get, set
            /// <summary>
            /// Should arrays consume more than one positional argument following their flag. Default is <c>true</c>
            /// </summary>
            abstract member ``greedy-arrays``: bool with get, set
            /// <summary>
            /// Should nargs consume dash options as well as positional arguments. Default is <c>false</c>
            /// </summary>
            abstract member ``nargs-eats-options``: bool with get, set
            /// <summary>
            /// Should parsing stop at the first text argument? This is similar to how e.g. ssh parses its command line. Default is <c>false</c>
            /// </summary>
            abstract member ``halt-at-non-option``: bool with get, set
            /// <summary>
            /// The prefix to use for negated boolean variables. Default is <c>'no-'</c>
            /// </summary>
            abstract member ``negation-prefix``: string with get, set
            /// <summary>
            /// Should keys that look like numbers be treated as such? Default is <c>true</c>
            /// </summary>
            abstract member ``parse-numbers``: bool with get, set
            /// <summary>
            /// Should positional keys that look like numbers be treated as such? Default is <c>true</c>
            /// </summary>
            abstract member ``parse-positional-numbers``: bool with get, set
            /// <summary>
            /// Should unparsed flags be stored in -- or _. Default is <c>false</c>
            /// </summary>
            abstract member ``populate--``: bool with get, set
            /// <summary>
            /// Should a placeholder be added for keys not set via the corresponding CLI argument? Default is <c>false</c>
            /// </summary>
            abstract member ``set-placeholder-key``: bool with get, set
            /// <summary>
            /// Should a group of short-options be treated as boolean flags? Default is <c>true</c>
            /// </summary>
            abstract member ``short-option-groups``: bool with get, set
            /// <summary>
            /// Should aliases be removed before returning results? Default is <c>false</c>
            /// </summary>
            abstract member ``strip-aliased``: bool with get, set
            /// <summary>
            /// Should dashed keys be removed before returning results? This option has no effect if camel-case-expansion is disabled. Default is <c>false</c>
            /// </summary>
            abstract member ``strip-dashed``: bool with get, set
            /// <summary>
            /// Should unknown options be treated like regular arguments? An unknown option is one that is not configured in opts. Default is <c>false</c>
            /// </summary>
            abstract member ``unknown-options-as-args``: bool with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (``boolean-negation``: bool, ``camel-case-expansion``: bool, ``combine-arrays``: bool, ``dot-notation``: bool, ``duplicate-arguments-array``: bool, ``flatten-duplicate-arrays``: bool, ``greedy-arrays``: bool, ``nargs-eats-options``: bool, ``halt-at-non-option``: bool, ``negation-prefix``: string, ``parse-numbers``: bool, ``parse-positional-numbers``: bool, ``populate--``: bool, ``set-placeholder-key``: bool, ``short-option-groups``: bool, ``strip-aliased``: bool, ``strip-dashed``: bool, ``unknown-options-as-args``: bool) : Configuration = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type Options =
            /// <summary>
            /// An object representing the set of aliases for a key: <c>{ alias: { foo: ['f']} }</c>.
            /// </summary>
            abstract member alias: Options.alias option with get, set
            /// <summary>
            /// Indicate that keys should be parsed as an array: <c>{ array: ['foo', 'bar'] }</c>.
            /// Indicate that keys should be parsed as an array and coerced to booleans / numbers:
            /// { array: [ { key: 'foo', boolean: true }, {key: 'bar', number: true} ] }`.
            /// </summary>
            abstract member array: U2<ResizeArray<string>, ResizeArray<Options.array.U2.Case2>> option with get, set
            /// <summary>
            /// Arguments should be parsed as booleans: <c>{ boolean: ['x', 'y'] }</c>.
            /// </summary>
            abstract member boolean: ResizeArray<string> option with get, set
            /// <summary>
            /// Indicate a key that represents a path to a configuration file (this file will be loaded and parsed).
            /// </summary>
            abstract member config: U3<string, ResizeArray<string>, Options.config.U3.Case3> option with get, set
            /// <summary>
            /// Provide configuration options to the yargs-parser.
            /// </summary>
            abstract member configuration: Options.configuration option with get, set
            /// <summary>
            /// Provide a custom synchronous function that returns a coerced value from the argument provided (or throws an error), e.g.
            /// <c>{ coerce: { foo: function (arg) { return modifiedArg } } }</c>.
            /// </summary>
            abstract member coerce: Options.coerce option with get, set
            /// <summary>
            /// Indicate a key that should be used as a counter, e.g., <c>-vvv = {v: 3}</c>.
            /// </summary>
            abstract member count: ResizeArray<string> option with get, set
            /// <summary>
            /// Provide default values for keys: <c>{ default: { x: 33, y: 'hello world!' } }</c>.
            /// </summary>
            abstract member ``default``: Options.``default`` option with get, set
            /// <summary>
            /// Environment variables (<c>process.env</c>) with the prefix provided should be parsed.
            /// </summary>
            abstract member envPrefix: string option with get, set
            /// <summary>
            /// Specify that a key requires n arguments: <c>{ narg: {x: 2} }</c>.
            /// </summary>
            abstract member narg: Options.narg option with get, set
            /// <summary>
            /// <c>path.normalize()</c> will be applied to values set to this key.
            /// </summary>
            abstract member normalize: ResizeArray<string> option with get, set
            /// <summary>
            /// Keys should be treated as strings (even if they resemble a number <c>-x 33</c>).
            /// </summary>
            abstract member string: ResizeArray<string> option with get, set
            /// <summary>
            /// Keys should be treated as numbers.
            /// </summary>
            abstract member number: ResizeArray<string> option with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (?alias: Options.alias, ?array: U2<ResizeArray<string>, ResizeArray<Options.array.U2.Case2>>, ?boolean: ResizeArray<string>, ?config: U3<string, ResizeArray<string>, Options.config.U3.Case3>, ?configuration: Options.configuration, ?coerce: Options.coerce, ?count: ResizeArray<string>, ?``default``: Options.``default``, ?envPrefix: string, ?narg: Options.narg, ?normalize: ResizeArray<string>, ?string: ResizeArray<string>, ?number: ResizeArray<string>) : Options = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type Parser =
            [<Emit("$0($1...)")>]
            abstract member Invoke: argv: U2<string, ResizeArray<string>> * ?opts: YargsParser.yargsParser_.Options -> YargsParser.yargsParser_.Arguments
            abstract member detailed: argv: string * ?opts: YargsParser.yargsParser_.Options -> YargsParser.yargsParser_.DetailedArguments
            abstract member detailed: argv: ResizeArray<string> * ?opts: YargsParser.yargsParser_.Options -> YargsParser.yargsParser_.DetailedArguments
            abstract member detailed: argv: U2<string, ResizeArray<string>> * ?opts: YargsParser.yargsParser_.Options -> YargsParser.yargsParser_.DetailedArguments
            abstract member camelCase: str: string -> string
            abstract member decamelize: str: string * ?joinString: string -> string
            abstract member looksLikeNumber: value: string option -> bool
            abstract member looksLikeNumber: value: float option -> bool
            abstract member looksLikeNumber: value: U2<string, float> option -> bool

        module DetailedArguments =

            [<AllowNullLiteral>]
            [<Interface>]
            type aliases =
                [<EmitIndexer>]
                abstract member Item: alias: string -> ResizeArray<string> with get, set

            [<AllowNullLiteral>]
            [<Interface>]
            type newAliases =
                [<EmitIndexer>]
                abstract member Item: alias: string -> bool with get, set

        module Options =

            [<AllowNullLiteral>]
            [<Interface>]
            type alias =
                [<EmitIndexer>]
                abstract member Item: key: string -> U2<string, ResizeArray<string>> with get, set

            [<AllowNullLiteral>]
            [<Interface>]
            type configuration =
                /// <summary>
                /// Should variables prefixed with --no be treated as negations? Default is <c>true</c>
                /// </summary>
                abstract member ``boolean-negation``: bool option with get, set
                /// <summary>
                /// Should hyphenated arguments be expanded into camel-case aliases? Default is <c>true</c>
                /// </summary>
                abstract member ``camel-case-expansion``: bool option with get, set
                /// <summary>
                /// Should arrays be combined when provided by both command line arguments and a configuration file. Default is <c>false</c>
                /// </summary>
                abstract member ``combine-arrays``: bool option with get, set
                /// <summary>
                /// Should keys that contain . be treated as objects? Default is <c>true</c>
                /// </summary>
                abstract member ``dot-notation``: bool option with get, set
                /// <summary>
                /// Should arguments be coerced into an array when duplicated. Default is <c>true</c>
                /// </summary>
                abstract member ``duplicate-arguments-array``: bool option with get, set
                /// <summary>
                /// Should array arguments be coerced into a single array when duplicated. Default is <c>true</c>
                /// </summary>
                abstract member ``flatten-duplicate-arrays``: bool option with get, set
                /// <summary>
                /// Should arrays consume more than one positional argument following their flag. Default is <c>true</c>
                /// </summary>
                abstract member ``greedy-arrays``: bool option with get, set
                /// <summary>
                /// Should nargs consume dash options as well as positional arguments. Default is <c>false</c>
                /// </summary>
                abstract member ``nargs-eats-options``: bool option with get, set
                /// <summary>
                /// Should parsing stop at the first text argument? This is similar to how e.g. ssh parses its command line. Default is <c>false</c>
                /// </summary>
                abstract member ``halt-at-non-option``: bool option with get, set
                /// <summary>
                /// The prefix to use for negated boolean variables. Default is <c>'no-'</c>
                /// </summary>
                abstract member ``negation-prefix``: string option with get, set
                /// <summary>
                /// Should keys that look like numbers be treated as such? Default is <c>true</c>
                /// </summary>
                abstract member ``parse-numbers``: bool option with get, set
                /// <summary>
                /// Should positional keys that look like numbers be treated as such? Default is <c>true</c>
                /// </summary>
                abstract member ``parse-positional-numbers``: bool option with get, set
                /// <summary>
                /// Should unparsed flags be stored in -- or _. Default is <c>false</c>
                /// </summary>
                abstract member ``populate--``: bool option with get, set
                /// <summary>
                /// Should a placeholder be added for keys not set via the corresponding CLI argument? Default is <c>false</c>
                /// </summary>
                abstract member ``set-placeholder-key``: bool option with get, set
                /// <summary>
                /// Should a group of short-options be treated as boolean flags? Default is <c>true</c>
                /// </summary>
                abstract member ``short-option-groups``: bool option with get, set
                /// <summary>
                /// Should aliases be removed before returning results? Default is <c>false</c>
                /// </summary>
                abstract member ``strip-aliased``: bool option with get, set
                /// <summary>
                /// Should dashed keys be removed before returning results? This option has no effect if camel-case-expansion is disabled. Default is <c>false</c>
                /// </summary>
                abstract member ``strip-dashed``: bool option with get, set
                /// <summary>
                /// Should unknown options be treated like regular arguments? An unknown option is one that is not configured in opts. Default is <c>false</c>
                /// </summary>
                abstract member ``unknown-options-as-args``: bool option with get, set

            [<AllowNullLiteral>]
            [<Interface>]
            type coerce =
                [<EmitIndexer>]
                abstract member Item: key: string -> (obj -> unit) with get, set

            [<AllowNullLiteral>]
            [<Interface>]
            type ``default`` =
                [<EmitIndexer>]
                abstract member Item: key: string -> obj with get, set

            [<AllowNullLiteral>]
            [<Interface>]
            type narg =
                [<EmitIndexer>]
                abstract member Item: key: string -> float with get, set

            module array =

                module U2 =

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type Case2 =
                        abstract member key: string with get, set
                        abstract member boolean: bool option with get, set
                        abstract member number: bool option with get, set
                        [<ParamObject; Emit("$0")>]
                        static member Create (key: string, ?boolean: bool, ?number: bool) : Case2 = nativeOnly

            module config =

                module U3 =

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type Case3 =
                        [<EmitIndexer>]
                        abstract member Item: key: string -> bool with get, set

    type Arguments =
        yargsParser_.Arguments

    type DetailedArguments =
        yargsParser_.DetailedArguments

    type Configuration =
        yargsParser_.Configuration

    type Options =
        yargsParser_.Options

    type Parser =
        yargsParser_.Parser
