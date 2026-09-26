namespace rec Glutinum

open Fable.Core
open Fable.Core.JsInterop
open System

// You need to add Glutinum.Types NuGet package to your project
open Glutinum.Types.TypeScript

// You need to add Glutinum.Node NuGet package to your project

type RegExp = Text.RegularExpressions.Regex

module Express =

    [<AbstractClass>]
    [<Erase>]
    type Exports =
        /// <summary>
        /// Creates an Express application. The express() function is a top-level function exported by the express module.
        /// </summary>
        [<ImportDefault("express")>]
        static member e () : ExpressServeStaticCore.Express = nativeOnly
        /// <summary>
        /// Creates an Express application. The express() function is a top-level function exported by the express module.
        /// </summary>
        [<ImportDefault("express")>]
        static member express () : ExpressServeStaticCore.Express = nativeOnly
        /// <summary>
        /// Creates an Express application. The express() function is a top-level function exported by the express module.
        /// </summary>
        [<ImportAll("express")>]
        static member inline e_
            with get () : e_.Exports =
                nativeOnly
        /// <summary>
        /// This is a built-in middleware function in Express. It parses incoming requests with JSON payloads and is based on body-parser.
        /// </summary>
        [<ImportDefault("express")>]
        [<Emit("$0.json")>]
        static member inline json: (BodyParser.bodyParser_.OptionsJson option -> Connect.createServer_.NextHandleFunction) = nativeOnly
        /// <summary>
        /// This is a built-in middleware function in Express. It parses incoming requests with Buffer payloads and is based on body-parser.
        /// </summary>
        [<ImportDefault("express")>]
        [<Emit("$0.raw")>]
        static member inline raw: (BodyParser.bodyParser_.Options option -> Connect.createServer_.NextHandleFunction) = nativeOnly
        /// <summary>
        /// This is a built-in middleware function in Express. It parses incoming requests with text payloads and is based on body-parser.
        /// </summary>
        [<ImportDefault("express")>]
        [<Emit("$0.text")>]
        static member inline text: (BodyParser.bodyParser_.OptionsText option -> Connect.createServer_.NextHandleFunction) = nativeOnly
        /// <summary>
        /// These are the exposed prototypes.
        /// </summary>
        [<ImportDefault("express")>]
        [<Emit("$0.application")>]
        static member inline application: Express.e_.Application = nativeOnly
        [<ImportDefault("express")>]
        [<Emit("$0.request")>]
        static member inline request: Express.e_.Request = nativeOnly
        [<ImportDefault("express")>]
        [<Emit("$0.response")>]
        static member inline response: Express.e_.Response = nativeOnly
        /// <summary>
        /// This is a built-in middleware function in Express. It serves static files and is based on serve-static.
        /// </summary>
        [<ImportDefault("express")>]
        [<Emit("$0.static")>]
        static member inline ``static``: ServeStatic.serveStatic_.RequestHandlerConstructor<Express.e_.Response> = nativeOnly
        /// <summary>
        /// This is a built-in middleware function in Express. It parses incoming requests with urlencoded payloads and is based on body-parser.
        /// </summary>
        [<ImportDefault("express")>]
        [<Emit("$0.urlencoded")>]
        static member inline urlencoded: (BodyParser.bodyParser_.OptionsUrlencoded option -> Connect.createServer_.NextHandleFunction) = nativeOnly
        [<ImportDefault("express"); Emit("$0.Router($1...)")>]
        static member Router (?options: Express.e_.RouterOptions) : ExpressServeStaticCore.Router = nativeOnly

    module e_ =

        [<AbstractClass>]
        [<Erase>]
        type Exports =
            /// <summary>
            /// This is a built-in middleware function in Express. It parses incoming requests with JSON payloads and is based on body-parser.
            /// </summary>
            [<Emit("$0.json")>]
            abstract member json: (BodyParser.bodyParser_.OptionsJson option -> Connect.createServer_.NextHandleFunction)
            /// <summary>
            /// This is a built-in middleware function in Express. It parses incoming requests with Buffer payloads and is based on body-parser.
            /// </summary>
            [<Emit("$0.raw")>]
            abstract member raw: (BodyParser.bodyParser_.Options option -> Connect.createServer_.NextHandleFunction)
            /// <summary>
            /// This is a built-in middleware function in Express. It parses incoming requests with text payloads and is based on body-parser.
            /// </summary>
            [<Emit("$0.text")>]
            abstract member text: (BodyParser.bodyParser_.OptionsText option -> Connect.createServer_.NextHandleFunction)
            /// <summary>
            /// These are the exposed prototypes.
            /// </summary>
            [<Emit("$0.application")>]
            abstract member application: Express.e_.Application
            [<Emit("$0.request")>]
            abstract member request: Express.e_.Request
            [<Emit("$0.response")>]
            abstract member response: Express.e_.Response
            /// <summary>
            /// This is a built-in middleware function in Express. It serves static files and is based on serve-static.
            /// </summary>
            [<Emit("$0.static")>]
            abstract member ``static``: ServeStatic.serveStatic_.RequestHandlerConstructor<Express.e_.Response>
            /// <summary>
            /// This is a built-in middleware function in Express. It parses incoming requests with urlencoded payloads and is based on body-parser.
            /// </summary>
            [<Emit("$0.urlencoded")>]
            abstract member urlencoded: (BodyParser.bodyParser_.OptionsUrlencoded option -> Connect.createServer_.NextHandleFunction)
            [<Emit("$0.Router($1...)")>]
            abstract member Router: ?options: Express.e_.RouterOptions -> ExpressServeStaticCore.Router

        [<AllowNullLiteral>]
        [<Interface>]
        type RouterOptions =
            /// <summary>
            /// Enable case sensitivity.
            /// </summary>
            abstract member caseSensitive: bool option with get, set
            /// <summary>
            /// Preserve the req.params values from the parent router.
            /// If the parent and the child have conflicting param names, the child’s value take precedence.
            /// </summary>
            abstract member mergeParams: bool option with get, set
            /// <summary>
            /// Enable strict routing.
            /// </summary>
            abstract member strict: bool option with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (?caseSensitive: bool, ?mergeParams: bool, ?strict: bool) : RouterOptions = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type Application =
            inherit ExpressServeStaticCore.Application

        [<AllowNullLiteral>]
        [<Interface>]
        type CookieOptions =
            inherit ExpressServeStaticCore.CookieOptions

        type Errback =
            ExpressServeStaticCore.Errback

        type ErrorRequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'Locals> =
            ExpressServeStaticCore.ErrorRequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'Locals>

        [<AllowNullLiteral>]
        [<Interface>]
        type Express =
            inherit ExpressServeStaticCore.Express

        type Handler =
            ExpressServeStaticCore.Handler

        [<AllowNullLiteral>]
        [<Interface>]
        type IRoute =
            inherit ExpressServeStaticCore.IRoute

        [<AllowNullLiteral>]
        [<Interface>]
        type IRouter =
            inherit ExpressServeStaticCore.IRouter

        [<AllowNullLiteral>]
        [<Interface>]
        type IRouterHandler<'T> =
            inherit ExpressServeStaticCore.IRouterHandler<'T>

        [<AllowNullLiteral>]
        [<Interface>]
        type IRouterMatcher<'T> =
            inherit ExpressServeStaticCore.IRouterMatcher<'T>

        [<AllowNullLiteral>]
        [<Interface>]
        type MediaType =
            inherit ExpressServeStaticCore.MediaType

        [<AllowNullLiteral>]
        [<Interface>]
        type NextFunction =
            inherit ExpressServeStaticCore.NextFunction

        [<AllowNullLiteral>]
        [<Interface>]
        type Locals =
            inherit ExpressServeStaticCore.Locals

        [<AllowNullLiteral>]
        [<Interface>]
        type Request<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'Locals> =
            inherit ExpressServeStaticCore.Request<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'Locals>

        type RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'Locals> =
            ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'Locals>

        type RequestParamHandler =
            ExpressServeStaticCore.RequestParamHandler

        [<AllowNullLiteral>]
        [<Interface>]
        type Response<'ResBody, 'Locals> =
            inherit ExpressServeStaticCore.Response<'ResBody, 'Locals>

        [<AllowNullLiteral>]
        [<Interface>]
        type Router =
            inherit ExpressServeStaticCore.Router

        type Send =
            ExpressServeStaticCore.Send

        type ErrorRequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery> =
            ErrorRequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, obj>

        type ErrorRequestHandler<'P, 'ResBody, 'ReqBody> =
            ErrorRequestHandler<'P, 'ResBody, 'ReqBody, ExpressServeStaticCore.Query, obj>

        type ErrorRequestHandler<'P, 'ResBody> =
            ErrorRequestHandler<'P, 'ResBody, obj, ExpressServeStaticCore.Query, obj>

        type ErrorRequestHandler<'P> =
            ErrorRequestHandler<'P, obj, obj, ExpressServeStaticCore.Query, obj>

        type ErrorRequestHandler =
            ErrorRequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, ExpressServeStaticCore.Query, obj>

        type Request<'P, 'ResBody, 'ReqBody, 'ReqQuery> =
            Request<'P, 'ResBody, 'ReqBody, 'ReqQuery, obj>

        type Request<'P, 'ResBody, 'ReqBody> =
            Request<'P, 'ResBody, 'ReqBody, ExpressServeStaticCore.Query, obj>

        type Request<'P, 'ResBody> =
            Request<'P, 'ResBody, obj, ExpressServeStaticCore.Query, obj>

        type Request<'P> =
            Request<'P, obj, obj, ExpressServeStaticCore.Query, obj>

        type Request =
            Request<ExpressServeStaticCore.ParamsDictionary, obj, obj, ExpressServeStaticCore.Query, obj>

        type RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery> =
            RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, obj>

        type RequestHandler<'P, 'ResBody, 'ReqBody> =
            RequestHandler<'P, 'ResBody, 'ReqBody, ExpressServeStaticCore.Query, obj>

        type RequestHandler<'P, 'ResBody> =
            RequestHandler<'P, 'ResBody, obj, ExpressServeStaticCore.Query, obj>

        type RequestHandler<'P> =
            RequestHandler<'P, obj, obj, ExpressServeStaticCore.Query, obj>

        type RequestHandler =
            RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, ExpressServeStaticCore.Query, obj>

        type Response<'ResBody> =
            Response<'ResBody, obj>

        type Response =
            Response<obj, obj>

    type RouterOptions =
        e_.RouterOptions

    type Application =
        e_.Application

    type CookieOptions =
        e_.CookieOptions

    type Errback =
        e_.Errback

    type ErrorRequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'Locals> =
        e_.ErrorRequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'Locals>

    type ErrorRequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery> =
        ErrorRequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, obj>

    type ErrorRequestHandler<'P, 'ResBody, 'ReqBody> =
        ErrorRequestHandler<'P, 'ResBody, 'ReqBody, ExpressServeStaticCore.Query, obj>

    type ErrorRequestHandler<'P, 'ResBody> =
        ErrorRequestHandler<'P, 'ResBody, obj, ExpressServeStaticCore.Query, obj>

    type ErrorRequestHandler<'P> =
        ErrorRequestHandler<'P, obj, obj, ExpressServeStaticCore.Query, obj>

    type ErrorRequestHandler =
        ErrorRequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, ExpressServeStaticCore.Query, obj>

    type Express =
        e_.Express

    type Handler =
        e_.Handler

    type IRoute =
        e_.IRoute

    type IRouter =
        e_.IRouter

    type IRouterHandler<'T> =
        e_.IRouterHandler<'T>

    type IRouterMatcher<'T> =
        e_.IRouterMatcher<'T>

    type MediaType =
        e_.MediaType

    type NextFunction =
        e_.NextFunction

    type Locals =
        e_.Locals

    type Request<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'Locals> =
        e_.Request<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'Locals>

    type Request<'P, 'ResBody, 'ReqBody, 'ReqQuery> =
        Request<'P, 'ResBody, 'ReqBody, 'ReqQuery, obj>

    type Request<'P, 'ResBody, 'ReqBody> =
        Request<'P, 'ResBody, 'ReqBody, ExpressServeStaticCore.Query, obj>

    type Request<'P, 'ResBody> =
        Request<'P, 'ResBody, obj, ExpressServeStaticCore.Query, obj>

    type Request<'P> =
        Request<'P, obj, obj, ExpressServeStaticCore.Query, obj>

    type Request =
        Request<ExpressServeStaticCore.ParamsDictionary, obj, obj, ExpressServeStaticCore.Query, obj>

    type RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'Locals> =
        e_.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'Locals>

    type RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery> =
        RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, obj>

    type RequestHandler<'P, 'ResBody, 'ReqBody> =
        RequestHandler<'P, 'ResBody, 'ReqBody, ExpressServeStaticCore.Query, obj>

    type RequestHandler<'P, 'ResBody> =
        RequestHandler<'P, 'ResBody, obj, ExpressServeStaticCore.Query, obj>

    type RequestHandler<'P> =
        RequestHandler<'P, obj, obj, ExpressServeStaticCore.Query, obj>

    type RequestHandler =
        RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, ExpressServeStaticCore.Query, obj>

    type RequestParamHandler =
        e_.RequestParamHandler

    type Response<'ResBody, 'Locals> =
        e_.Response<'ResBody, 'Locals>

    type Response<'ResBody> =
        Response<'ResBody, obj>

    type Response =
        Response<obj, obj>

    type Router =
        e_.Router

    type Send =
        e_.Send

module BodyParser =

    [<AbstractClass>]
    [<Erase>]
    type Exports =
        [<ImportDefault("body-parser"); Emit("$0($1...)")>]
        static member bodyParser (?options: Exports.bodyParser__.options) : Connect.createServer_.NextHandleFunction = nativeOnly
        /// <summary>
        /// Returns middleware that only parses json and only looks at requests
        /// where the Content-Type header matches the type option.
        /// </summary>
        [<ImportDefault("body-parser"); Emit("$0.json($1...)")>]
        static member json (?options: BodyParser.bodyParser_.OptionsJson) : Connect.createServer_.NextHandleFunction = nativeOnly
        /// <summary>
        /// Returns middleware that parses all bodies as a Buffer and only looks at requests
        /// where the Content-Type header matches the type option.
        /// </summary>
        [<ImportDefault("body-parser"); Emit("$0.raw($1...)")>]
        static member raw (?options: BodyParser.bodyParser_.Options) : Connect.createServer_.NextHandleFunction = nativeOnly
        /// <summary>
        /// Returns middleware that parses all bodies as a string and only looks at requests
        /// where the Content-Type header matches the type option.
        /// </summary>
        [<ImportDefault("body-parser"); Emit("$0.text($1...)")>]
        static member text (?options: BodyParser.bodyParser_.OptionsText) : Connect.createServer_.NextHandleFunction = nativeOnly
        /// <summary>
        /// Returns middleware that only parses urlencoded bodies and only looks at requests
        /// where the Content-Type header matches the type option
        /// </summary>
        [<ImportDefault("body-parser"); Emit("$0.urlencoded($1...)")>]
        static member urlencoded (?options: BodyParser.bodyParser_.OptionsUrlencoded) : Connect.createServer_.NextHandleFunction = nativeOnly

    module bodyParser_ =

        [<AllowNullLiteral>]
        [<Interface>]
        type BodyParser =
            [<Emit("$0($1...)")>]
            abstract member Invoke: ?options: BodyParser.Invoke.options -> Connect.createServer_.NextHandleFunction
            /// <summary>
            /// Returns middleware that only parses json and only looks at requests
            /// where the Content-Type header matches the type option.
            /// </summary>
            abstract member json: ?options: BodyParser.bodyParser_.OptionsJson -> Connect.createServer_.NextHandleFunction
            /// <summary>
            /// Returns middleware that parses all bodies as a Buffer and only looks at requests
            /// where the Content-Type header matches the type option.
            /// </summary>
            abstract member raw: ?options: BodyParser.bodyParser_.Options -> Connect.createServer_.NextHandleFunction
            /// <summary>
            /// Returns middleware that parses all bodies as a string and only looks at requests
            /// where the Content-Type header matches the type option.
            /// </summary>
            abstract member text: ?options: BodyParser.bodyParser_.OptionsText -> Connect.createServer_.NextHandleFunction
            /// <summary>
            /// Returns middleware that only parses urlencoded bodies and only looks at requests
            /// where the Content-Type header matches the type option
            /// </summary>
            abstract member urlencoded: ?options: BodyParser.bodyParser_.OptionsUrlencoded -> Connect.createServer_.NextHandleFunction

        [<AllowNullLiteral>]
        [<Interface>]
        type Options =
            /// <summary>
            /// When set to true, then deflated (compressed) bodies will be inflated; when false, deflated bodies are rejected. Defaults to true.
            /// </summary>
            abstract member inflate: bool option with get, set
            /// <summary>
            /// Controls the maximum request body size. If this is a number,
            /// then the value specifies the number of bytes; if it is a string,
            /// the value is passed to the bytes library for parsing. Defaults to '100kb'.
            /// </summary>
            abstract member limit: U2<float, string> option with get, set
            /// <summary>
            /// The type option is used to determine what media type the middleware will parse
            /// </summary>
            abstract member ``type``: U3<string, ResizeArray<string>, (Glutinum.Node.http.IncomingMessage -> unit)> option with get, set
            /// <summary>
            /// The verify option, if supplied, is called as verify(req, res, buf, encoding),
            /// where buf is a Buffer of the raw request body and encoding is the encoding of the request.
            /// </summary>
            abstract member verify: req: Glutinum.Node.http.IncomingMessage * res: Glutinum.Node.http.ServerResponse * buf: Glutinum.Node.Buffer * encoding: string -> unit

        [<AllowNullLiteral>]
        [<Interface>]
        type OptionsJson =
            inherit BodyParser.bodyParser_.Options
            /// <summary>
            /// The reviver option is passed directly to JSON.parse as the second argument.
            /// </summary>
            abstract member reviver: key: string * value: obj -> obj
            /// <summary>
            /// When set to <c>true</c>, will only accept arrays and objects;
            /// when <c>false</c> will accept anything JSON.parse accepts. Defaults to <c>true</c>.
            /// </summary>
            abstract member strict: bool option with get, set

        [<AllowNullLiteral>]
        [<Interface>]
        type OptionsText =
            inherit BodyParser.bodyParser_.Options
            /// <summary>
            /// Specify the default character set for the text content if the charset
            /// is not specified in the Content-Type header of the request.
            /// Defaults to <c>utf-8</c>.
            /// </summary>
            abstract member defaultCharset: string option with get, set

        [<AllowNullLiteral>]
        [<Interface>]
        type OptionsUrlencoded =
            inherit BodyParser.bodyParser_.Options
            /// <summary>
            /// The extended option allows to choose between parsing the URL-encoded data
            /// with the querystring library (when <c>false</c>) or the qs library (when <c>true</c>).
            /// </summary>
            abstract member extended: bool option with get, set
            /// <summary>
            /// The parameterLimit option controls the maximum number of parameters
            /// that are allowed in the URL-encoded data. If a request contains more parameters than this value,
            /// a 413 will be returned to the client. Defaults to 1000.
            /// </summary>
            abstract member parameterLimit: float option with get, set

        module BodyParser =

            module Invoke =

                [<AllowNullLiteral>]
                [<Interface>]
                type options =
                    /// <summary>
                    /// The reviver option is passed directly to JSON.parse as the second argument.
                    /// </summary>
                    abstract member reviver: key: string * value: obj -> obj
                    /// <summary>
                    /// When set to <c>true</c>, will only accept arrays and objects;
                    /// when <c>false</c> will accept anything JSON.parse accepts. Defaults to <c>true</c>.
                    /// </summary>
                    abstract member strict: bool option with get, set
                    /// <summary>
                    /// When set to true, then deflated (compressed) bodies will be inflated; when false, deflated bodies are rejected. Defaults to true.
                    /// </summary>
                    abstract member inflate: bool option with get, set
                    /// <summary>
                    /// Controls the maximum request body size. If this is a number,
                    /// then the value specifies the number of bytes; if it is a string,
                    /// the value is passed to the bytes library for parsing. Defaults to '100kb'.
                    /// </summary>
                    abstract member limit: U2<float, string> option with get, set
                    /// <summary>
                    /// The type option is used to determine what media type the middleware will parse
                    /// </summary>
                    abstract member ``type``: U3<string, ResizeArray<string>, (Glutinum.Node.http.IncomingMessage -> unit)> option with get, set
                    /// <summary>
                    /// The verify option, if supplied, is called as verify(req, res, buf, encoding),
                    /// where buf is a Buffer of the raw request body and encoding is the encoding of the request.
                    /// </summary>
                    abstract member verify: req: Glutinum.Node.http.IncomingMessage * res: Glutinum.Node.http.ServerResponse * buf: Glutinum.Node.Buffer * encoding: string -> unit
                    /// <summary>
                    /// Specify the default character set for the text content if the charset
                    /// is not specified in the Content-Type header of the request.
                    /// Defaults to <c>utf-8</c>.
                    /// </summary>
                    abstract member defaultCharset: string option with get, set
                    /// <summary>
                    /// The extended option allows to choose between parsing the URL-encoded data
                    /// with the querystring library (when <c>false</c>) or the qs library (when <c>true</c>).
                    /// </summary>
                    abstract member extended: bool option with get, set
                    /// <summary>
                    /// The parameterLimit option controls the maximum number of parameters
                    /// that are allowed in the URL-encoded data. If a request contains more parameters than this value,
                    /// a 413 will be returned to the client. Defaults to 1000.
                    /// </summary>
                    abstract member parameterLimit: float option with get, set

    type BodyParser =
        bodyParser_.BodyParser

    type Options =
        bodyParser_.Options

    type OptionsJson =
        bodyParser_.OptionsJson

    type OptionsText =
        bodyParser_.OptionsText

    type OptionsUrlencoded =
        bodyParser_.OptionsUrlencoded

    module Exports =

        module bodyParser__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                /// <summary>
                /// The reviver option is passed directly to JSON.parse as the second argument.
                /// </summary>
                abstract member reviver: key: string * value: obj -> obj
                /// <summary>
                /// When set to <c>true</c>, will only accept arrays and objects;
                /// when <c>false</c> will accept anything JSON.parse accepts. Defaults to <c>true</c>.
                /// </summary>
                abstract member strict: bool option with get, set
                /// <summary>
                /// When set to true, then deflated (compressed) bodies will be inflated; when false, deflated bodies are rejected. Defaults to true.
                /// </summary>
                abstract member inflate: bool option with get, set
                /// <summary>
                /// Controls the maximum request body size. If this is a number,
                /// then the value specifies the number of bytes; if it is a string,
                /// the value is passed to the bytes library for parsing. Defaults to '100kb'.
                /// </summary>
                abstract member limit: U2<float, string> option with get, set
                /// <summary>
                /// The type option is used to determine what media type the middleware will parse
                /// </summary>
                abstract member ``type``: U3<string, ResizeArray<string>, (Glutinum.Node.http.IncomingMessage -> unit)> option with get, set
                /// <summary>
                /// The verify option, if supplied, is called as verify(req, res, buf, encoding),
                /// where buf is a Buffer of the raw request body and encoding is the encoding of the request.
                /// </summary>
                abstract member verify: req: Glutinum.Node.http.IncomingMessage * res: Glutinum.Node.http.ServerResponse * buf: Glutinum.Node.Buffer * encoding: string -> unit
                /// <summary>
                /// Specify the default character set for the text content if the charset
                /// is not specified in the Content-Type header of the request.
                /// Defaults to <c>utf-8</c>.
                /// </summary>
                abstract member defaultCharset: string option with get, set
                /// <summary>
                /// The extended option allows to choose between parsing the URL-encoded data
                /// with the querystring library (when <c>false</c>) or the qs library (when <c>true</c>).
                /// </summary>
                abstract member extended: bool option with get, set
                /// <summary>
                /// The parameterLimit option controls the maximum number of parameters
                /// that are allowed in the URL-encoded data. If a request contains more parameters than this value,
                /// a 413 will be returned to the client. Defaults to 1000.
                /// </summary>
                abstract member parameterLimit: float option with get, set

module Connect =

    [<AbstractClass>]
    [<Erase>]
    type Exports =
        /// <summary>
        /// Create a new connect server.
        /// </summary>
        [<ImportDefault("connect")>]
        static member createServer () : Connect.createServer_.Server = nativeOnly
        /// <summary>
        /// Create a new connect server.
        /// </summary>
        [<ImportDefault("connect")>]
        static member connect () : Connect.createServer_.Server = nativeOnly
        /// <summary>
        /// Create a new connect server.
        /// </summary>
        [<ImportAll("connect")>]
        static member inline createServer_
            with get () : createServer_.Exports =
                nativeOnly

    module createServer_ =

        [<AbstractClass>]
        [<Erase>]
        type Exports =
            [<Emit("new $0.IncomingMessage($1...)")>]
            abstract member IncomingMessage: unit -> IncomingMessage

        type ServerHandle =
            U2<Connect.createServer_.HandleFunction, Glutinum.Node.http.Server>

        [<AllowNullLiteral>]
        [<Interface>]
        type IncomingMessage =
            inherit Glutinum.Node.http.IncomingMessage

        type NextFunction =
            delegate of ?err: obj -> unit

        type SimpleHandleFunction =
            delegate of req: Connect.createServer_.IncomingMessage * res: Glutinum.Node.http.ServerResponse -> unit

        type NextHandleFunction =
            delegate of req: Connect.createServer_.IncomingMessage * res: Glutinum.Node.http.ServerResponse * next: Connect.createServer_.NextFunction -> unit

        type ErrorHandleFunction =
            delegate of err: obj * req: Connect.createServer_.IncomingMessage * res: Glutinum.Node.http.ServerResponse * next: Connect.createServer_.NextFunction -> unit

        type HandleFunction =
            U3<Connect.createServer_.SimpleHandleFunction, Connect.createServer_.NextHandleFunction, Connect.createServer_.ErrorHandleFunction>

        [<AllowNullLiteral>]
        [<Interface>]
        type ServerStackItem =
            abstract member route: string with get, set
            abstract member handle: Connect.createServer_.ServerHandle with get, set

        [<AllowNullLiteral>]
        [<Interface>]
        type Server =
            inherit Glutinum.Node.NodeJS.EventEmitter
            [<Emit("$0($1...)")>]
            abstract member Invoke: req: Glutinum.Node.http.IncomingMessage * res: Glutinum.Node.http.ServerResponse * ?next: Action -> unit
            abstract member route: string with get, set
            abstract member stack: ResizeArray<Connect.createServer_.ServerStackItem> with get, set
            /// <summary>
            /// Utilize the given middleware <c>handle</c> to the given <c>route</c>,
            /// defaulting to _/_. This "route" is the mount-point for the
            /// middleware, when given a value other than _/_ the middleware
            /// is only effective when that segment is present in the request's
            /// pathname.
            ///
            /// For example if we were to mount a function at _/admin_, it would
            /// be invoked on _/admin_, and _/admin/settings_, however it would
            /// not be invoked for _/_, or _/posts_.
            /// </summary>
            abstract member ``use``: fn: Connect.createServer_.NextHandleFunction -> Connect.createServer_.Server
            /// <summary>
            /// Utilize the given middleware <c>handle</c> to the given <c>route</c>,
            /// defaulting to _/_. This "route" is the mount-point for the
            /// middleware, when given a value other than _/_ the middleware
            /// is only effective when that segment is present in the request's
            /// pathname.
            ///
            /// For example if we were to mount a function at _/admin_, it would
            /// be invoked on _/admin_, and _/admin/settings_, however it would
            /// not be invoked for _/_, or _/posts_.
            /// </summary>
            abstract member ``use``: fn: Connect.createServer_.SimpleHandleFunction -> Connect.createServer_.Server
            /// <summary>
            /// Utilize the given middleware <c>handle</c> to the given <c>route</c>,
            /// defaulting to _/_. This "route" is the mount-point for the
            /// middleware, when given a value other than _/_ the middleware
            /// is only effective when that segment is present in the request's
            /// pathname.
            ///
            /// For example if we were to mount a function at _/admin_, it would
            /// be invoked on _/admin_, and _/admin/settings_, however it would
            /// not be invoked for _/_, or _/posts_.
            /// </summary>
            abstract member ``use``: fn: Connect.createServer_.ErrorHandleFunction -> Connect.createServer_.Server
            /// <summary>
            /// Utilize the given middleware <c>handle</c> to the given <c>route</c>,
            /// defaulting to _/_. This "route" is the mount-point for the
            /// middleware, when given a value other than _/_ the middleware
            /// is only effective when that segment is present in the request's
            /// pathname.
            ///
            /// For example if we were to mount a function at _/admin_, it would
            /// be invoked on _/admin_, and _/admin/settings_, however it would
            /// not be invoked for _/_, or _/posts_.
            /// </summary>
            abstract member ``use``: route: string * fn: Connect.createServer_.NextHandleFunction -> Connect.createServer_.Server
            /// <summary>
            /// Utilize the given middleware <c>handle</c> to the given <c>route</c>,
            /// defaulting to _/_. This "route" is the mount-point for the
            /// middleware, when given a value other than _/_ the middleware
            /// is only effective when that segment is present in the request's
            /// pathname.
            ///
            /// For example if we were to mount a function at _/admin_, it would
            /// be invoked on _/admin_, and _/admin/settings_, however it would
            /// not be invoked for _/_, or _/posts_.
            /// </summary>
            abstract member ``use``: route: string * fn: Connect.createServer_.SimpleHandleFunction -> Connect.createServer_.Server
            /// <summary>
            /// Utilize the given middleware <c>handle</c> to the given <c>route</c>,
            /// defaulting to _/_. This "route" is the mount-point for the
            /// middleware, when given a value other than _/_ the middleware
            /// is only effective when that segment is present in the request's
            /// pathname.
            ///
            /// For example if we were to mount a function at _/admin_, it would
            /// be invoked on _/admin_, and _/admin/settings_, however it would
            /// not be invoked for _/_, or _/posts_.
            /// </summary>
            abstract member ``use``: route: string * fn: Connect.createServer_.ErrorHandleFunction -> Connect.createServer_.Server
            /// <summary>
            /// Handle server requests, punting them down
            /// the middleware stack.
            /// </summary>
            abstract member handle: req: Glutinum.Node.http.IncomingMessage * res: Glutinum.Node.http.ServerResponse * next: Action -> unit
            /// <summary>
            /// Listen for connections.
            ///
            /// This method takes the same arguments
            /// as node's <c>http.Server#listen()</c>.
            ///
            /// HTTP and HTTPS:
            ///
            /// If you run your application both as HTTP
            /// and HTTPS you may wrap them individually,
            /// since your Connect "server" is really just
            /// a JavaScript <c>Function</c>.
            ///
            ///      var connect = require('connect')
            ///        , http = require('http')
            ///        , https = require('https');
            ///
            ///      var app = connect();
            ///
            ///      http.createServer(app).listen(80);
            ///      https.createServer(options, app).listen(443);
            /// </summary>
            abstract member listen: port: float * ?hostname: string * ?backlog: float * ?callback: Action -> Glutinum.Node.http.Server
            /// <summary>
            /// Listen for connections.
            ///
            /// This method takes the same arguments
            /// as node's <c>http.Server#listen()</c>.
            ///
            /// HTTP and HTTPS:
            ///
            /// If you run your application both as HTTP
            /// and HTTPS you may wrap them individually,
            /// since your Connect "server" is really just
            /// a JavaScript <c>Function</c>.
            ///
            ///      var connect = require('connect')
            ///        , http = require('http')
            ///        , https = require('https');
            ///
            ///      var app = connect();
            ///
            ///      http.createServer(app).listen(80);
            ///      https.createServer(options, app).listen(443);
            /// </summary>
            abstract member listen: port: float * ?hostname: string * ?callback: Action -> Glutinum.Node.http.Server
            /// <summary>
            /// Listen for connections.
            ///
            /// This method takes the same arguments
            /// as node's <c>http.Server#listen()</c>.
            ///
            /// HTTP and HTTPS:
            ///
            /// If you run your application both as HTTP
            /// and HTTPS you may wrap them individually,
            /// since your Connect "server" is really just
            /// a JavaScript <c>Function</c>.
            ///
            ///      var connect = require('connect')
            ///        , http = require('http')
            ///        , https = require('https');
            ///
            ///      var app = connect();
            ///
            ///      http.createServer(app).listen(80);
            ///      https.createServer(options, app).listen(443);
            /// </summary>
            abstract member listen: path: string * ?callback: Action -> Glutinum.Node.http.Server
            /// <summary>
            /// Listen for connections.
            ///
            /// This method takes the same arguments
            /// as node's <c>http.Server#listen()</c>.
            ///
            /// HTTP and HTTPS:
            ///
            /// If you run your application both as HTTP
            /// and HTTPS you may wrap them individually,
            /// since your Connect "server" is really just
            /// a JavaScript <c>Function</c>.
            ///
            ///      var connect = require('connect')
            ///        , http = require('http')
            ///        , https = require('https');
            ///
            ///      var app = connect();
            ///
            ///      http.createServer(app).listen(80);
            ///      https.createServer(options, app).listen(443);
            /// </summary>
            abstract member listen: handle: obj * ?listeningListener: Action -> Glutinum.Node.http.Server

    type ServerHandle =
        createServer_.ServerHandle

    type NextFunction =
        createServer_.NextFunction

    type SimpleHandleFunction =
        createServer_.SimpleHandleFunction

    type NextHandleFunction =
        createServer_.NextHandleFunction

    type ErrorHandleFunction =
        createServer_.ErrorHandleFunction

    type HandleFunction =
        createServer_.HandleFunction

    type ServerStackItem =
        createServer_.ServerStackItem

    type Server =
        createServer_.Server

module ExpressServeStaticCore =

    type Query =
        Qs.QueryString_.ParsedQs

    [<AllowNullLiteral>]
    [<Interface>]
    type NextFunction =
        [<Emit("$0($1...)")>]
        abstract member Invoke: ?err: obj -> unit
        [<Emit("$0($1...)")>]
        abstract member Invoke: deferToNext: string -> unit

    [<AllowNullLiteral>]
    [<Interface>]
    type Dictionary<'T> =
        [<EmitIndexer>]
        abstract member Item: key: string -> 'T with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type ParamsDictionary =
        [<EmitIndexer>]
        abstract member Item: key: string -> U2<string, ResizeArray<string>> with get, set
        [<EmitIndexer>]
        abstract member Item: key: int -> string with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type ParamsFlatDictionary =
        [<EmitIndexer>]
        abstract member Item: key: U2<string, float> -> string with get, set

    type Params =
        U2<ExpressServeStaticCore.ParamsDictionary, ExpressServeStaticCore.ParamsFlatDictionary>

    [<AllowNullLiteral>]
    [<Interface>]
    type Locals =
        inherit ExpressServeStaticCore.Express.Locals

    type RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> =
        delegate of req: ExpressServeStaticCore.Request<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> * res: ExpressServeStaticCore.Response<'ResBody, 'LocalsObj> * next: ExpressServeStaticCore.NextFunction -> unit

    type ErrorRequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> =
        delegate of err: obj * req: ExpressServeStaticCore.Request<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> * res: ExpressServeStaticCore.Response<'ResBody, 'LocalsObj> * next: ExpressServeStaticCore.NextFunction -> unit

    type PathParams =
        U3<string, RegExp, ResizeArray<U2<string, RegExp>>>

    type RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> =
        U3<ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>, ExpressServeStaticCore.ErrorRequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>, ResizeArray<U2<ExpressServeStaticCore.RequestHandler<'P>, ExpressServeStaticCore.ErrorRequestHandler<'P>>>>

    [<AllowNullLiteral>]
    [<Interface>]
    type RemoveTail<'S, 'Tail> =
        interface end

    [<AllowNullLiteral>]
    [<Interface>]
    type GetRouteParameter<'S> =
        interface end

    [<AllowNullLiteral>]
    [<Interface>]
    type RouteParameters<'Route> =
        interface end

    [<AllowNullLiteral>]
    [<Interface>]
    type ParseRouteParameters<'Route> =
        interface end

    [<AllowNullLiteral>]
    [<Interface>]
    type IRouterMatcher<'T, 'Method> =
        [<Emit("$0($1...)")>]
        abstract member Invoke<'Route, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Route * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> 'T
        [<Emit("$0($1...)")>]
        abstract member Invoke<'Path, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Path * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> 'T
        [<Emit("$0($1...)")>]
        abstract member Invoke<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ExpressServeStaticCore.PathParams * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> 'T
        [<Emit("$0($1...)")>]
        abstract member Invoke<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ExpressServeStaticCore.PathParams * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> 'T
        [<Emit("$0($1...)")>]
        abstract member Invoke: path: ExpressServeStaticCore.PathParams * subApplication: ExpressServeStaticCore.Application -> 'T

    [<AllowNullLiteral>]
    [<Interface>]
    type IRouterHandler<'T, 'Route> =
        [<Emit("$0($1...)")>]
        abstract member Invoke: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<obj> [] -> 'T
        [<Emit("$0($1...)")>]
        abstract member Invoke: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<obj> [] -> 'T
        [<Emit("$0($1...)")>]
        abstract member Invoke<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> 'T
        [<Emit("$0($1...)")>]
        abstract member Invoke<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> 'T

    [<AllowNullLiteral>]
    [<Interface>]
    type IRouter =
        /// <summary>
        /// Map the given param placeholder <c>name</c>(s) to the given callback(s).
        ///
        /// Parameter mapping is used to provide pre-conditions to routes
        /// which use normalized placeholders. For example a _:user_id_ parameter
        /// could automatically load a user's information from the database without
        /// any additional code,
        ///
        /// The callback uses the samesignature as middleware, the only differencing
        /// being that the value of the placeholder is passed, in this case the _id_
        /// of the user. Once the <c>next()</c> function is invoked, just like middleware
        /// it will continue on to execute the route, or subsequent parameter functions.
        ///
        ///      app.param('user_id', function(req, res, next, id){
        ///        User.find(id, function(err, user){
        ///          if (err) {
        ///            next(err);
        ///          } else if (user) {
        ///            req.user = user;
        ///            next();
        ///          } else {
        ///            next(new Error('failed to load user'));
        ///          }
        ///        });
        ///      });
        /// </summary>
        abstract member param: name: string * handler: ExpressServeStaticCore.RequestParamHandler -> IRouter
        /// <summary>
        /// Special-cased "all" method, applying the given route <c>path</c>,
        /// middleware, and callback to _every_ HTTP method.
        /// </summary>
        abstract member all<'Route, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Route * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        /// <summary>
        /// Special-cased "all" method, applying the given route <c>path</c>,
        /// middleware, and callback to _every_ HTTP method.
        /// </summary>
        abstract member all<'Path, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Path * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        /// <summary>
        /// Special-cased "all" method, applying the given route <c>path</c>,
        /// middleware, and callback to _every_ HTTP method.
        /// </summary>
        abstract member all<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        /// <summary>
        /// Special-cased "all" method, applying the given route <c>path</c>,
        /// middleware, and callback to _every_ HTTP method.
        /// </summary>
        abstract member all<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        /// <summary>
        /// Special-cased "all" method, applying the given route <c>path</c>,
        /// middleware, and callback to _every_ HTTP method.
        /// </summary>
        abstract member all<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        /// <summary>
        /// Special-cased "all" method, applying the given route <c>path</c>,
        /// middleware, and callback to _every_ HTTP method.
        /// </summary>
        abstract member all: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        /// <summary>
        /// Special-cased "all" method, applying the given route <c>path</c>,
        /// middleware, and callback to _every_ HTTP method.
        /// </summary>
        abstract member all: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        /// <summary>
        /// Special-cased "all" method, applying the given route <c>path</c>,
        /// middleware, and callback to _every_ HTTP method.
        /// </summary>
        abstract member all: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        /// <summary>
        /// Special-cased "all" method, applying the given route <c>path</c>,
        /// middleware, and callback to _every_ HTTP method.
        /// </summary>
        abstract member all<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        /// <summary>
        /// Special-cased "all" method, applying the given route <c>path</c>,
        /// middleware, and callback to _every_ HTTP method.
        /// </summary>
        abstract member all<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        /// <summary>
        /// Special-cased "all" method, applying the given route <c>path</c>,
        /// middleware, and callback to _every_ HTTP method.
        /// </summary>
        abstract member all<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        /// <summary>
        /// Special-cased "all" method, applying the given route <c>path</c>,
        /// middleware, and callback to _every_ HTTP method.
        /// </summary>
        abstract member all: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        /// <summary>
        /// Special-cased "all" method, applying the given route <c>path</c>,
        /// middleware, and callback to _every_ HTTP method.
        /// </summary>
        abstract member all: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        /// <summary>
        /// Special-cased "all" method, applying the given route <c>path</c>,
        /// middleware, and callback to _every_ HTTP method.
        /// </summary>
        abstract member all: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        /// <summary>
        /// Special-cased "all" method, applying the given route <c>path</c>,
        /// middleware, and callback to _every_ HTTP method.
        /// </summary>
        abstract member all: path: string * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        /// <summary>
        /// Special-cased "all" method, applying the given route <c>path</c>,
        /// middleware, and callback to _every_ HTTP method.
        /// </summary>
        abstract member all: path: RegExp * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        /// <summary>
        /// Special-cased "all" method, applying the given route <c>path</c>,
        /// middleware, and callback to _every_ HTTP method.
        /// </summary>
        abstract member all: path: ResizeArray<U2<string, RegExp>> * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member get<'Route, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Route * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member get<'Path, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Path * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member get<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member get<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member get<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member get: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member get: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member get: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member get<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member get<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member get<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member get: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member get: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member get: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member get: path: string * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member get: path: RegExp * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member get: path: ResizeArray<U2<string, RegExp>> * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member post<'Route, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Route * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member post<'Path, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Path * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member post<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member post<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member post<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member post: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member post: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member post: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member post<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member post<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member post<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member post: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member post: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member post: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member post: path: string * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member post: path: RegExp * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member post: path: ResizeArray<U2<string, RegExp>> * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member put<'Route, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Route * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member put<'Path, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Path * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member put<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member put<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member put<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member put: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member put: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member put: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member put<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member put<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member put<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member put: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member put: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member put: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member put: path: string * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member put: path: RegExp * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member put: path: ResizeArray<U2<string, RegExp>> * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member delete<'Route, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Route * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member delete<'Path, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Path * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member delete<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member delete<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member delete<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member delete: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member delete: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member delete: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member delete<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member delete<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member delete<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member delete: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member delete: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member delete: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member delete: path: string * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member delete: path: RegExp * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member delete: path: ResizeArray<U2<string, RegExp>> * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member patch<'Route, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Route * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member patch<'Path, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Path * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member patch<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member patch<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member patch<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member patch: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member patch: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member patch: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member patch<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member patch<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member patch<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member patch: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member patch: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member patch: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member patch: path: string * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member patch: path: RegExp * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member patch: path: ResizeArray<U2<string, RegExp>> * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member options<'Route, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Route * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member options<'Path, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Path * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member options<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member options<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member options<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member options: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member options: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member options: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member options<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member options<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member options<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member options: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member options: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member options: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member options: path: string * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member options: path: RegExp * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member options: path: ResizeArray<U2<string, RegExp>> * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member head<'Route, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Route * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member head<'Path, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Path * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member head<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member head<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member head<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member head: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member head: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member head: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member head<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member head<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member head<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member head: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member head: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member head: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member head: path: string * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member head: path: RegExp * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        abstract member head: path: ResizeArray<U2<string, RegExp>> * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter, string>
        /// <summary>
        /// Requires Node.js >=20.19.3 <21 || >=22.2.0
        /// </summary>
        abstract member query: ExpressServeStaticCore.IRouterMatcher<IRouter, string> option with get, set
        abstract member checkout<'Route, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Route * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member checkout<'Path, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Path * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member checkout<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member checkout<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member checkout<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member checkout: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member checkout: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member checkout: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member checkout<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member checkout<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member checkout<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member checkout: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member checkout: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member checkout: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member checkout: path: string * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member checkout: path: RegExp * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member checkout: path: ResizeArray<U2<string, RegExp>> * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member connect<'Route, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Route * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member connect<'Path, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Path * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member connect<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member connect<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member connect<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member connect: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member connect: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member connect: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member connect<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member connect<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member connect<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member connect: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member connect: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member connect: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member connect: path: string * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member connect: path: RegExp * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member connect: path: ResizeArray<U2<string, RegExp>> * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member copy<'Route, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Route * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member copy<'Path, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Path * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member copy<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member copy<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member copy<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member copy: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member copy: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member copy: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member copy<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member copy<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member copy<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member copy: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member copy: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member copy: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member copy: path: string * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member copy: path: RegExp * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member copy: path: ResizeArray<U2<string, RegExp>> * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member lock<'Route, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Route * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member lock<'Path, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Path * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member lock<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member lock<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member lock<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member lock: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member lock: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member lock: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member lock<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member lock<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member lock<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member lock: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member lock: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member lock: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member lock: path: string * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member lock: path: RegExp * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member lock: path: ResizeArray<U2<string, RegExp>> * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member merge<'Route, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Route * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member merge<'Path, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Path * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member merge<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member merge<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member merge<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member merge: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member merge: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member merge: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member merge<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member merge<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member merge<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member merge: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member merge: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member merge: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member merge: path: string * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member merge: path: RegExp * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member merge: path: ResizeArray<U2<string, RegExp>> * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member mkactivity<'Route, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Route * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member mkactivity<'Path, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Path * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member mkactivity<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member mkactivity<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member mkactivity<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member mkactivity: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member mkactivity: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member mkactivity: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member mkactivity<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member mkactivity<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member mkactivity<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member mkactivity: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member mkactivity: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member mkactivity: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member mkactivity: path: string * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member mkactivity: path: RegExp * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member mkactivity: path: ResizeArray<U2<string, RegExp>> * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member mkcol<'Route, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Route * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member mkcol<'Path, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Path * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member mkcol<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member mkcol<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member mkcol<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member mkcol: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member mkcol: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member mkcol: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member mkcol<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member mkcol<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member mkcol<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member mkcol: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member mkcol: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member mkcol: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member mkcol: path: string * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member mkcol: path: RegExp * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member mkcol: path: ResizeArray<U2<string, RegExp>> * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member move<'Route, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Route * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member move<'Path, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Path * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member move<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member move<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member move<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member move: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member move: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member move: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member move<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member move<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member move<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member move: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member move: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member move: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member move: path: string * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member move: path: RegExp * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member move: path: ResizeArray<U2<string, RegExp>> * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member ``m-search``<'Route, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Route * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member ``m-search``<'Path, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Path * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member ``m-search``<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member ``m-search``<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member ``m-search``<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member ``m-search``: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member ``m-search``: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member ``m-search``: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member ``m-search``<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member ``m-search``<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member ``m-search``<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member ``m-search``: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member ``m-search``: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member ``m-search``: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member ``m-search``: path: string * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member ``m-search``: path: RegExp * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member ``m-search``: path: ResizeArray<U2<string, RegExp>> * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member notify<'Route, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Route * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member notify<'Path, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Path * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member notify<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member notify<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member notify<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member notify: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member notify: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member notify: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member notify<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member notify<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member notify<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member notify: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member notify: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member notify: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member notify: path: string * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member notify: path: RegExp * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member notify: path: ResizeArray<U2<string, RegExp>> * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member propfind<'Route, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Route * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member propfind<'Path, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Path * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member propfind<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member propfind<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member propfind<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member propfind: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member propfind: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member propfind: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member propfind<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member propfind<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member propfind<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member propfind: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member propfind: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member propfind: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member propfind: path: string * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member propfind: path: RegExp * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member propfind: path: ResizeArray<U2<string, RegExp>> * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member proppatch<'Route, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Route * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member proppatch<'Path, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Path * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member proppatch<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member proppatch<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member proppatch<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member proppatch: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member proppatch: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member proppatch: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member proppatch<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member proppatch<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member proppatch<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member proppatch: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member proppatch: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member proppatch: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member proppatch: path: string * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member proppatch: path: RegExp * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member proppatch: path: ResizeArray<U2<string, RegExp>> * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member purge<'Route, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Route * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member purge<'Path, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Path * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member purge<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member purge<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member purge<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member purge: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member purge: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member purge: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member purge<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member purge<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member purge<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member purge: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member purge: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member purge: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member purge: path: string * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member purge: path: RegExp * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member purge: path: ResizeArray<U2<string, RegExp>> * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member report<'Route, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Route * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member report<'Path, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Path * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member report<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member report<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member report<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member report: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member report: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member report: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member report<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member report<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member report<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member report: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member report: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member report: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member report: path: string * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member report: path: RegExp * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member report: path: ResizeArray<U2<string, RegExp>> * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member search<'Route, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Route * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member search<'Path, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Path * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member search<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member search<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member search<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member search: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member search: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member search: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member search<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member search<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member search<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member search: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member search: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member search: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member search: path: string * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member search: path: RegExp * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member search: path: ResizeArray<U2<string, RegExp>> * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member subscribe<'Route, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Route * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member subscribe<'Path, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Path * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member subscribe<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member subscribe<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member subscribe<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member subscribe: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member subscribe: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member subscribe: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member subscribe<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member subscribe<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member subscribe<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member subscribe: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member subscribe: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member subscribe: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member subscribe: path: string * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member subscribe: path: RegExp * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member subscribe: path: ResizeArray<U2<string, RegExp>> * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member trace<'Route, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Route * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member trace<'Path, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Path * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member trace<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member trace<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member trace<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member trace: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member trace: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member trace: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member trace<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member trace<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member trace<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member trace: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member trace: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member trace: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member trace: path: string * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member trace: path: RegExp * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member trace: path: ResizeArray<U2<string, RegExp>> * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member unlock<'Route, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Route * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member unlock<'Path, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Path * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member unlock<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member unlock<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member unlock<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member unlock: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member unlock: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member unlock: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member unlock<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member unlock<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member unlock<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member unlock: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member unlock: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member unlock: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member unlock: path: string * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member unlock: path: RegExp * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member unlock: path: ResizeArray<U2<string, RegExp>> * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member unsubscribe<'Route, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Route * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member unsubscribe<'Path, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Path * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member unsubscribe<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member unsubscribe<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member unsubscribe<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member unsubscribe: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member unsubscribe: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member unsubscribe: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member unsubscribe<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member unsubscribe<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member unsubscribe<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member unsubscribe: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member unsubscribe: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member unsubscribe: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member unsubscribe: path: string * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member unsubscribe: path: RegExp * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member unsubscribe: path: ResizeArray<U2<string, RegExp>> * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member link<'Route, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Route * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member link<'Path, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Path * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member link<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member link<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member link<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member link: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member link: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member link: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member link<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member link<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member link<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member link: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member link: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member link: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member link: path: string * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member link: path: RegExp * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member link: path: ResizeArray<U2<string, RegExp>> * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member unlink<'Route, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Route * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member unlink<'Path, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Path * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member unlink<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member unlink<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member unlink<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member unlink: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member unlink: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member unlink: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member unlink<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member unlink<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member unlink<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member unlink: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member unlink: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member unlink: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member unlink: path: string * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member unlink: path: RegExp * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member unlink: path: ResizeArray<U2<string, RegExp>> * subApplication: ExpressServeStaticCore.Application -> ExpressServeStaticCore.IRouterMatcher<IRouter>
        abstract member ``use``: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> obj
        abstract member ``use``: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> obj
        abstract member ``use``<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> obj
        abstract member ``use``<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> obj
        abstract member ``use``<'Route, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Route * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> obj
        abstract member ``use``<'Path, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Path * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> obj
        abstract member ``use``<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> obj
        abstract member ``use``<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> obj
        abstract member ``use``<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> obj
        abstract member ``use``: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> obj
        abstract member ``use``: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> obj
        abstract member ``use``: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> obj
        abstract member ``use``<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> obj
        abstract member ``use``<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> obj
        abstract member ``use``<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> obj
        abstract member ``use``: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> obj
        abstract member ``use``: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> obj
        abstract member ``use``: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> obj
        abstract member ``use``: path: string * subApplication: ExpressServeStaticCore.Application<obj> -> obj
        abstract member ``use``: path: RegExp * subApplication: ExpressServeStaticCore.Application<obj> -> obj
        abstract member ``use``: path: ResizeArray<U2<string, RegExp>> * subApplication: ExpressServeStaticCore.Application<obj> -> obj
        abstract member route<'T>: prefix: 'T -> ExpressServeStaticCore.IRoute<'T>
        abstract member route: prefix: string -> ExpressServeStaticCore.IRoute
        abstract member route: prefix: RegExp -> ExpressServeStaticCore.IRoute
        abstract member route: prefix: ResizeArray<U2<string, RegExp>> -> ExpressServeStaticCore.IRoute
        /// <summary>
        /// Stack of configured routes
        /// </summary>
        abstract member stack: ResizeArray<ExpressServeStaticCore.ILayer> with get, set
        [<Emit("$0($1...)")>]
        abstract member Invoke: req: ExpressServeStaticCore.Request<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> * res: ExpressServeStaticCore.Response<'ResBody, 'LocalsObj> * next: ExpressServeStaticCore.NextFunction -> obj

    [<AllowNullLiteral>]
    [<Interface>]
    type ILayer =
        abstract member route: ExpressServeStaticCore.IRoute option with get, set
        abstract member name: ILayer.name with get, set
        abstract member ``params``: obj option with get, set
        abstract member keys: ResizeArray<string> with get, set
        abstract member path: string option with get, set
        abstract member ``method``: string with get, set
        abstract member regexp: RegExp with get, set
        abstract member handle: ILayer.handle with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type IRoute<'Route> =
        abstract member path: string with get, set
        abstract member stack: ResizeArray<ExpressServeStaticCore.ILayer> with get, set
        abstract member all: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member all: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member all<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member all<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member all: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member all: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member get: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member get: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member get<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member get<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member get: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member get: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member post: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member post: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member post<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member post<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member post: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member post: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member put: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member put: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member put<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member put<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member put: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member put: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member delete: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member delete: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member delete<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member delete<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member delete: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member delete: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member patch: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member patch: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member patch<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member patch<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member patch: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member patch: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member options: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member options: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member options<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member options<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member options: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member options: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member head: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member head: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member head<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member head<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member head: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member head: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member checkout: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member checkout: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member checkout<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member checkout<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member checkout: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member checkout: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member copy: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member copy: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member copy<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member copy<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member copy: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member copy: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member lock: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member lock: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member lock<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member lock<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member lock: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member lock: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member merge: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member merge: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member merge<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member merge<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member merge: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member merge: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member mkactivity: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member mkactivity: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member mkactivity<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member mkactivity<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member mkactivity: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member mkactivity: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member mkcol: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member mkcol: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member mkcol<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member mkcol<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member mkcol: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member mkcol: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member move: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member move: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member move<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member move<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member move: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member move: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member ``m-search``: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member ``m-search``: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member ``m-search``<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member ``m-search``<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member ``m-search``: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member ``m-search``: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member notify: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member notify: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member notify<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member notify<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member notify: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member notify: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member purge: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member purge: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member purge<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member purge<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member purge: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member purge: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member report: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member report: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member report<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member report<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member report: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member report: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member search: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member search: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member search<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member search<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member search: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member search: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member subscribe: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member subscribe: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member subscribe<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member subscribe<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member subscribe: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member subscribe: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member trace: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member trace: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member trace<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member trace<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member trace: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member trace: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member unlock: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member unlock: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member unlock<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member unlock<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member unlock: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member unlock: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member unsubscribe: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member unsubscribe: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member unsubscribe<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member unsubscribe<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member unsubscribe: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>
        abstract member unsubscribe: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.IRouterHandler<IRoute<'Route>, 'Route>

    [<AllowNullLiteral>]
    [<Interface>]
    type Router =
        inherit ExpressServeStaticCore.IRouter

    /// <summary>
    /// Options passed down into <c>res.cookie</c>
    /// <see href="https://expressjs.com/en/api.html#res.cookie">https://expressjs.com/en/api.html#res.cookie</see>
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type CookieOptions =
        /// <summary>
        /// Convenient option for setting the expiry time relative to the current time in **milliseconds**.
        /// </summary>
        abstract member maxAge: float option with get, set
        /// <summary>
        /// Indicates if the cookie should be signed.
        /// </summary>
        abstract member signed: bool option with get, set
        /// <summary>
        /// Expiry date of the cookie in GMT. If not specified (undefined), creates a session cookie.
        /// </summary>
        abstract member expires: Date option with get, set
        /// <summary>
        /// Flags the cookie to be accessible only by the web server.
        /// </summary>
        abstract member httpOnly: bool option with get, set
        /// <summary>
        /// Path for the cookie. Defaults to “/”.
        /// </summary>
        abstract member path: string option with get, set
        /// <summary>
        /// Domain name for the cookie. Defaults to the domain name of the app.
        /// </summary>
        abstract member domain: string option with get, set
        /// <summary>
        /// Marks the cookie to be used with HTTPS only.
        /// </summary>
        abstract member secure: bool option with get, set
        /// <summary>
        /// A synchronous function used for cookie value encoding. Defaults to encodeURIComponent.
        /// </summary>
        abstract member encode: (string -> string) option with get, set
        /// <summary>
        /// Value of the “SameSite” Set-Cookie attribute.
        /// <see href="https://tools.ietf.org/html/draft-ietf-httpbis-cookie-same-site-00#section-4.1.1.">https://tools.ietf.org/html/draft-ietf-httpbis-cookie-same-site-00#section-4.1.1.</see>
        /// </summary>
        abstract member sameSite: CookieOptions.sameSite option with get, set
        /// <summary>
        /// Value of the “Priority” Set-Cookie attribute.
        /// <see href="https://datatracker.ietf.org/doc/html/draft-west-cookie-priority-00#section-4.3">https://datatracker.ietf.org/doc/html/draft-west-cookie-priority-00#section-4.3</see>
        /// </summary>
        abstract member priority: CookieOptions.priority option with get, set
        /// <summary>
        /// Marks the cookie to use partioned storage.
        /// </summary>
        abstract member partitioned: bool option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type ByteRange =
        abstract member start: float with get, set
        abstract member ``end``: float with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type RequestRanges =
        inherit RangeParser.RangeParser_.Ranges

    type Errback =
        delegate of ?err: Exception -> unit

    /// <example>
    ///     app.get('/user/:id', (req, res) => res.send(req.params.id)); // implicitly <c>ParamsDictionary</c>, parameter is string
    ///     app.get('/user/*id', (req, res) => res.send(req.params.id)); // implicitly <c>ParamsDictionary</c>, parameter is string[]
    ///     app.get(/user\/(?<id>.*)/, (req, res) => res.send(req.params.id)); // implicitly <c>ParamsFlatDictionary</c>, parameter is string
    ///     app.get(/user\/(.*)/, (req, res) => res.send(req.params[0])); // implicitly <c>ParamsFlatDictionary</c>, parameter is string
    /// </example>
    /// <param name="P">
    /// For most requests, this should be <c>ParamsDictionary</c>, but if you're
    /// using this in a route handler for a route that uses a <c>RegExp</c>, then <c>req.params</c>
    /// will only contains strings, in which case you should use <c>ParamsFlatDictionary</c> instead.
    /// </param>
    [<AllowNullLiteral>]
    [<Interface>]
    type Request<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> =
        inherit Glutinum.Node.http.IncomingMessage
        inherit ExpressServeStaticCore.Express.Request
        /// <summary>
        /// Return request header.
        ///
        /// The <c>Referrer</c> header field is special-cased,
        /// both <c>Referrer</c> and <c>Referer</c> are interchangeable.
        ///
        /// Examples:
        ///
        ///     req.get('Content-Type');
        ///     // => "text/plain"
        ///
        ///     req.get('content-type');
        ///     // => "text/plain"
        ///
        ///     req.get('Something');
        ///     // => undefined
        ///
        /// Aliased as <c>req.header()</c>.
        /// </summary>
        [<Emit("$0.get('set-cookie')")>]
        abstract member ``get_set-cookie``: unit -> ResizeArray<string> option
        /// <summary>
        /// Return request header.
        ///
        /// The <c>Referrer</c> header field is special-cased,
        /// both <c>Referrer</c> and <c>Referer</c> are interchangeable.
        ///
        /// Examples:
        ///
        ///     req.get('Content-Type');
        ///     // => "text/plain"
        ///
        ///     req.get('content-type');
        ///     // => "text/plain"
        ///
        ///     req.get('Something');
        ///     // => undefined
        ///
        /// Aliased as <c>req.header()</c>.
        /// </summary>
        abstract member get: name: string -> string option
        [<Emit("$0.header('set-cookie')")>]
        abstract member ``header_set-cookie``: unit -> ResizeArray<string> option
        abstract member header: name: string -> string option
        /// <summary>
        /// Check if the given <c>type(s)</c> is acceptable, returning
        /// the best match when true, otherwise <c>undefined</c>, in which
        /// case you should respond with 406 "Not Acceptable".
        ///
        /// The <c>type</c> value may be a single mime type string
        /// such as "application/json", the extension name
        /// such as "json", a comma-delimted list such as "json, html, text/plain",
        /// or an array <c>["json", "html", "text/plain"]</c>. When a list
        /// or array is given the _best_ match, if any is returned.
        ///
        /// Examples:
        ///
        ///     // Accept: text/html
        ///     req.accepts('html');
        ///     // => "html"
        ///
        ///     // Accept: text/*, application/json
        ///     req.accepts('html');
        ///     // => "html"
        ///     req.accepts('text/html');
        ///     // => "text/html"
        ///     req.accepts('json, text');
        ///     // => "json"
        ///     req.accepts('application/json');
        ///     // => "application/json"
        ///
        ///     // Accept: text/*, application/json
        ///     req.accepts('image/png');
        ///     req.accepts('png');
        ///     // => false
        ///
        ///     // Accept: text/*;q=.5, application/json
        ///     req.accepts(['html', 'json']);
        ///     req.accepts('html, json');
        ///     // => "json"
        /// </summary>
        abstract member accepts: unit -> ResizeArray<string>
        /// <summary>
        /// Check if the given <c>type(s)</c> is acceptable, returning
        /// the best match when true, otherwise <c>undefined</c>, in which
        /// case you should respond with 406 "Not Acceptable".
        ///
        /// The <c>type</c> value may be a single mime type string
        /// such as "application/json", the extension name
        /// such as "json", a comma-delimted list such as "json, html, text/plain",
        /// or an array <c>["json", "html", "text/plain"]</c>. When a list
        /// or array is given the _best_ match, if any is returned.
        ///
        /// Examples:
        ///
        ///     // Accept: text/html
        ///     req.accepts('html');
        ///     // => "html"
        ///
        ///     // Accept: text/*, application/json
        ///     req.accepts('html');
        ///     // => "html"
        ///     req.accepts('text/html');
        ///     // => "text/html"
        ///     req.accepts('json, text');
        ///     // => "json"
        ///     req.accepts('application/json');
        ///     // => "application/json"
        ///
        ///     // Accept: text/*, application/json
        ///     req.accepts('image/png');
        ///     req.accepts('png');
        ///     // => false
        ///
        ///     // Accept: text/*;q=.5, application/json
        ///     req.accepts(['html', 'json']);
        ///     req.accepts('html, json');
        ///     // => "json"
        /// </summary>
        abstract member accepts: ``type``: string -> U2<string, bool>
        /// <summary>
        /// Check if the given <c>type(s)</c> is acceptable, returning
        /// the best match when true, otherwise <c>undefined</c>, in which
        /// case you should respond with 406 "Not Acceptable".
        ///
        /// The <c>type</c> value may be a single mime type string
        /// such as "application/json", the extension name
        /// such as "json", a comma-delimted list such as "json, html, text/plain",
        /// or an array <c>["json", "html", "text/plain"]</c>. When a list
        /// or array is given the _best_ match, if any is returned.
        ///
        /// Examples:
        ///
        ///     // Accept: text/html
        ///     req.accepts('html');
        ///     // => "html"
        ///
        ///     // Accept: text/*, application/json
        ///     req.accepts('html');
        ///     // => "html"
        ///     req.accepts('text/html');
        ///     // => "text/html"
        ///     req.accepts('json, text');
        ///     // => "json"
        ///     req.accepts('application/json');
        ///     // => "application/json"
        ///
        ///     // Accept: text/*, application/json
        ///     req.accepts('image/png');
        ///     req.accepts('png');
        ///     // => false
        ///
        ///     // Accept: text/*;q=.5, application/json
        ///     req.accepts(['html', 'json']);
        ///     req.accepts('html, json');
        ///     // => "json"
        /// </summary>
        abstract member accepts: ``type``: ResizeArray<string> -> U2<string, bool>
        /// <summary>
        /// Returns the first accepted charset of the specified character sets,
        /// based on the request's Accept-Charset HTTP header field.
        /// If none of the specified charsets is accepted, returns false.
        ///
        /// For more information, or if you have issues or concerns, see accepts.
        /// </summary>
        abstract member acceptsCharsets: unit -> ResizeArray<string>
        /// <summary>
        /// Returns the first accepted charset of the specified character sets,
        /// based on the request's Accept-Charset HTTP header field.
        /// If none of the specified charsets is accepted, returns false.
        ///
        /// For more information, or if you have issues or concerns, see accepts.
        /// </summary>
        abstract member acceptsCharsets: charset: string -> U2<string, bool>
        /// <summary>
        /// Returns the first accepted charset of the specified character sets,
        /// based on the request's Accept-Charset HTTP header field.
        /// If none of the specified charsets is accepted, returns false.
        ///
        /// For more information, or if you have issues or concerns, see accepts.
        /// </summary>
        abstract member acceptsCharsets: charset: ResizeArray<string> -> U2<string, bool>
        /// <summary>
        /// Returns the first accepted encoding of the specified encodings,
        /// based on the request's Accept-Encoding HTTP header field.
        /// If none of the specified encodings is accepted, returns false.
        ///
        /// For more information, or if you have issues or concerns, see accepts.
        /// </summary>
        abstract member acceptsEncodings: unit -> ResizeArray<string>
        /// <summary>
        /// Returns the first accepted encoding of the specified encodings,
        /// based on the request's Accept-Encoding HTTP header field.
        /// If none of the specified encodings is accepted, returns false.
        ///
        /// For more information, or if you have issues or concerns, see accepts.
        /// </summary>
        abstract member acceptsEncodings: encoding: string -> U2<string, bool>
        /// <summary>
        /// Returns the first accepted encoding of the specified encodings,
        /// based on the request's Accept-Encoding HTTP header field.
        /// If none of the specified encodings is accepted, returns false.
        ///
        /// For more information, or if you have issues or concerns, see accepts.
        /// </summary>
        abstract member acceptsEncodings: encoding: ResizeArray<string> -> U2<string, bool>
        /// <summary>
        /// Returns the first accepted language of the specified languages,
        /// based on the request's Accept-Language HTTP header field.
        /// If none of the specified languages is accepted, returns false.
        ///
        /// For more information, or if you have issues or concerns, see accepts.
        /// </summary>
        abstract member acceptsLanguages: unit -> ResizeArray<string>
        /// <summary>
        /// Returns the first accepted language of the specified languages,
        /// based on the request's Accept-Language HTTP header field.
        /// If none of the specified languages is accepted, returns false.
        ///
        /// For more information, or if you have issues or concerns, see accepts.
        /// </summary>
        abstract member acceptsLanguages: lang: string -> U2<string, bool>
        /// <summary>
        /// Returns the first accepted language of the specified languages,
        /// based on the request's Accept-Language HTTP header field.
        /// If none of the specified languages is accepted, returns false.
        ///
        /// For more information, or if you have issues or concerns, see accepts.
        /// </summary>
        abstract member acceptsLanguages: lang: ResizeArray<string> -> U2<string, bool>
        /// <summary>
        /// Parse Range header field, capping to the given <c>size</c>.
        ///
        /// Unspecified ranges such as "0-" require knowledge of your resource length. In
        /// the case of a byte range this is of course the total number of bytes.
        /// If the Range header field is not given <c>undefined</c> is returned.
        /// If the Range header field is given, return value is a result of range-parser.
        /// See more ./types/range-parser/index.d.ts
        ///
        /// NOTE: remember that ranges are inclusive, so for example "Range: users=0-3"
        /// should respond with 4 users when available, not 3.
        /// </summary>
        abstract member range: size: float * ?options: RangeParser.RangeParser_.Options -> U2<RangeParser.RangeParser_.Ranges, RangeParser.RangeParser_.Result> option
        /// <summary>
        /// Return an array of Accepted media types
        /// ordered from highest quality to lowest.
        /// </summary>
        abstract member accepted: ResizeArray<ExpressServeStaticCore.MediaType> with get, set
        /// <summary>
        /// Check if the incoming request contains the "Content-Type"
        /// header field, and it contains the give mime <c>type</c>.
        ///
        /// Examples:
        ///
        ///      // With Content-Type: text/html; charset=utf-8
        ///      req.is('html');
        ///      req.is('text/html');
        ///      req.is('text/*');
        ///      // => true
        ///
        ///      // When Content-Type is application/json
        ///      req.is('json');
        ///      req.is('application/json');
        ///      req.is('application/*');
        ///      // => true
        ///
        ///      req.is('html');
        ///      // => false
        /// </summary>
        abstract member is: ``type``: string -> U2<string, bool> option
        /// <summary>
        /// Check if the incoming request contains the "Content-Type"
        /// header field, and it contains the give mime <c>type</c>.
        ///
        /// Examples:
        ///
        ///      // With Content-Type: text/html; charset=utf-8
        ///      req.is('html');
        ///      req.is('text/html');
        ///      req.is('text/*');
        ///      // => true
        ///
        ///      // When Content-Type is application/json
        ///      req.is('json');
        ///      req.is('application/json');
        ///      req.is('application/*');
        ///      // => true
        ///
        ///      req.is('html');
        ///      // => false
        /// </summary>
        abstract member is: ``type``: ResizeArray<string> -> U2<string, bool> option
        /// <summary>
        /// Return the protocol string "http" or "https"
        /// when requested with TLS. When the "trust proxy"
        /// setting is enabled the "X-Forwarded-Proto" header
        /// field will be trusted. If you're running behind
        /// a reverse proxy that supplies https for you this
        /// may be enabled.
        /// </summary>
        abstract member protocol: string with get
        /// <summary>
        /// Short-hand for:
        ///
        ///    req.protocol == 'https'
        /// </summary>
        abstract member secure: bool with get
        /// <summary>
        /// Return the remote address, or when
        /// "trust proxy" is <c>true</c> return
        /// the upstream addr.
        ///
        /// Value may be undefined if the <c>req.socket</c> is destroyed
        /// (for example, if the client disconnected).
        /// </summary>
        abstract member ip: string option with get
        /// <summary>
        /// When "trust proxy" is <c>true</c>, parse
        /// the "X-Forwarded-For" ip address list.
        ///
        /// For example if the value were "client, proxy1, proxy2"
        /// you would receive the array <c>["client", "proxy1", "proxy2"]</c>
        /// where "proxy2" is the furthest down-stream.
        /// </summary>
        abstract member ips: ResizeArray<string> with get
        /// <summary>
        /// Return subdomains as an array.
        ///
        /// Subdomains are the dot-separated parts of the host before the main domain of
        /// the app. By default, the domain of the app is assumed to be the last two
        /// parts of the host. This can be changed by setting "subdomain offset".
        ///
        /// For example, if the domain is "tobi.ferrets.example.com":
        /// If "subdomain offset" is not set, req.subdomains is <c>["ferrets", "tobi"]</c>.
        /// If "subdomain offset" is 3, req.subdomains is <c>["tobi"]</c>.
        /// </summary>
        abstract member subdomains: ResizeArray<string> with get
        /// <summary>
        /// Short-hand for <c>url.parse(req.url).pathname</c>.
        /// </summary>
        abstract member path: string with get
        /// <summary>
        /// Contains the hostname derived from the <c>Host</c> HTTP header.
        /// </summary>
        abstract member hostname: string with get
        /// <summary>
        /// Contains the host derived from the <c>Host</c> HTTP header.
        /// </summary>
        abstract member host: string with get
        /// <summary>
        /// Check if the request is fresh, aka
        /// Last-Modified and/or the ETag
        /// still match.
        /// </summary>
        abstract member fresh: bool with get
        /// <summary>
        /// Check if the request is stale, aka
        /// "Last-Modified" and / or the "ETag" for the
        /// resource has changed.
        /// </summary>
        abstract member stale: bool with get
        /// <summary>
        /// Check if the request was an _XMLHttpRequest_.
        /// </summary>
        abstract member xhr: bool with get
        abstract member body: 'ReqBody with get, set
        abstract member cookies: obj with get, set
        /// <summary>
        /// **Only valid for request obtained from <see href="Server">Server</see>.**
        ///
        /// The request method as a string. Read only. Examples: <c>'GET'</c>, <c>'DELETE'</c>.
        /// </summary>
        abstract member ``method``: string with get, set
        abstract member ``params``: 'P with get, set
        abstract member query: 'ReqQuery with get, set
        abstract member route: obj with get, set
        abstract member signedCookies: obj with get, set
        abstract member originalUrl: string with get, set
        /// <summary>
        /// **Only valid for request obtained from <see href="Server">Server</see>.**
        ///
        /// Request URL string. This contains only the URL that is present in the actual
        /// HTTP request. Take the following request:
        ///
        /// <code lang="http">
        /// GET /status?name=ryan HTTP/1.1
        /// Accept: text/plain
        /// </code>
        ///
        /// To parse the URL into its parts:
        ///
        /// <c></c><c>js
        /// new URL(</c>http://${process.env.HOST ?? 'localhost'}${request.url}<c>);
        /// </c><c></c>
        ///
        /// When <c>request.url</c> is <c>'/status?name=ryan'</c> and <c>process.env.HOST</c> is undefined:
        ///
        /// <c></c><c>console
        /// $ node
        /// > new URL(</c>http://${process.env.HOST ?? 'localhost'}${request.url}<c>);
        /// URL {
        ///   href: 'http://localhost/status?name=ryan',
        ///   origin: 'http://localhost',
        ///   protocol: 'http:',
        ///   username: '',
        ///   password: '',
        ///   host: 'localhost',
        ///   hostname: 'localhost',
        ///   port: '',
        ///   pathname: '/status',
        ///   search: '?name=ryan',
        ///   searchParams: URLSearchParams { 'name' => 'ryan' },
        ///   hash: ''
        /// }
        /// </c><c></c>
        ///
        /// Ensure that you set <c>process.env.HOST</c> to the server's host name, or consider replacing this part entirely. If using <c>req.headers.host</c>, ensure proper
        /// validation is used, as clients may specify a custom <c>Host</c> header.
        /// </summary>
        abstract member url: string with get, set
        abstract member baseUrl: string with get, set
        abstract member app: ExpressServeStaticCore.Application with get, set
        /// <summary>
        /// After middleware.init executed, Request will contain res and next properties
        /// See: express/lib/middleware/init.js
        /// </summary>
        abstract member res: ExpressServeStaticCore.Response<'ResBody, 'LocalsObj> option with get, set
        abstract member next: ExpressServeStaticCore.NextFunction option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type MediaType =
        abstract member value: string with get, set
        abstract member quality: float with get, set
        abstract member ``type``: string with get, set
        abstract member subtype: string with get, set

    type Send<'ResBody, 'T> =
        delegate of ?body: 'ResBody -> 'T

    [<AllowNullLiteral>]
    [<Interface>]
    type SendFileOptions =
        inherit Send.send_.SendOptions
        /// <summary>
        /// Object containing HTTP headers to serve with the file.
        /// </summary>
        abstract member headers: SendFileOptions.headers option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?acceptRanges: bool, ?cacheControl: bool, ?dotfiles: SendFileOptions.dotfiles, ?``end``: float, ?etag: bool, ?extensions: U3<ResizeArray<string>, string, bool>, ?immutable: bool, ?index: U3<ResizeArray<string>, string, bool>, ?lastModified: bool, ?maxAge: U2<string, float>, ?root: string, ?start: float, ?headers: SendFileOptions.headers) : SendFileOptions = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type DownloadOptions =
        inherit Send.send_.SendOptions
        /// <summary>
        /// Object containing HTTP headers to serve with the file. The header <c>Content-Disposition</c> will be overridden by the filename argument.
        /// </summary>
        abstract member headers: DownloadOptions.headers option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?acceptRanges: bool, ?cacheControl: bool, ?dotfiles: DownloadOptions.dotfiles, ?``end``: float, ?etag: bool, ?extensions: U3<ResizeArray<string>, string, bool>, ?immutable: bool, ?index: U3<ResizeArray<string>, string, bool>, ?lastModified: bool, ?maxAge: U2<string, float>, ?root: string, ?start: float, ?headers: DownloadOptions.headers) : DownloadOptions = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type Response<'ResBody, 'LocalsObj, 'StatusCode> =
        inherit Glutinum.Node.http.ServerResponse
        inherit ExpressServeStaticCore.Express.Response
        /// <summary>
        /// Set status <c>code</c>.
        /// </summary>
        abstract member status: code: 'StatusCode -> Response<'ResBody, 'LocalsObj, 'StatusCode>
        /// <summary>
        /// Set the response HTTP status code to <c>statusCode</c> and send its string representation as the response body.
        /// <see href="http://expressjs.com/4x/api.html#res.sendStatus">Examples:
        ///
        /// res.sendStatus(200); // equivalent to res.status(200).send('OK')
        /// res.sendStatus(403); // equivalent to res.status(403).send('Forbidden')
        /// res.sendStatus(404); // equivalent to res.status(404).send('Not Found')
        /// res.sendStatus(500); // equivalent to res.status(500).send('Internal Server Error')</see>
        /// </summary>
        abstract member sendStatus: code: 'StatusCode -> Response<'ResBody, 'LocalsObj, 'StatusCode>
        /// <summary>
        /// Set Link header field with the given <c>links</c>.
        ///
        /// Examples:
        ///
        ///    res.links({
        ///      next: 'http://api.example.com/users?page=2',
        ///      last: 'http://api.example.com/users?page=5'
        ///    });
        /// </summary>
        abstract member links: links: obj -> Response<'ResBody, 'LocalsObj, 'StatusCode>
        /// <summary>
        /// Send a response.
        ///
        /// Examples:
        ///
        ///     res.send(new Buffer('wahoo'));
        ///     res.send({ some: 'json' });
        ///     res.send('<p>some html</p>');
        ///     res.status(404).send('Sorry, cant find that');
        /// </summary>
        abstract member send: ?body: 'ResBody -> ExpressServeStaticCore.Send<'ResBody, Response<'ResBody, 'LocalsObj, 'StatusCode>>
        /// <summary>
        /// Send JSON response.
        ///
        /// Examples:
        ///
        ///     res.json(null);
        ///     res.json({ user: 'tj' });
        ///     res.status(500).json('oh noes!');
        ///     res.status(404).json('I dont have that');
        /// </summary>
        abstract member json: ?body: 'ResBody -> ExpressServeStaticCore.Send<'ResBody, Response<'ResBody, 'LocalsObj, 'StatusCode>>
        /// <summary>
        /// Send JSON response with JSONP callback support.
        ///
        /// Examples:
        ///
        ///     res.jsonp(null);
        ///     res.jsonp({ user: 'tj' });
        ///     res.status(500).jsonp('oh noes!');
        ///     res.status(404).jsonp('I dont have that');
        /// </summary>
        abstract member jsonp: ?body: 'ResBody -> ExpressServeStaticCore.Send<'ResBody, Response<'ResBody, 'LocalsObj, 'StatusCode>>
        /// <summary>
        /// Transfer the file at the given <c>path</c>.
        ///
        /// Automatically sets the _Content-Type_ response header field.
        /// The callback <c>fn(err)</c> is invoked when the transfer is complete
        /// or when an error occurs. Be sure to check <c>res.headersSent</c>
        /// if you wish to attempt responding, as the header and some data
        /// may have already been transferred.
        ///
        /// Options:
        ///
        ///   - <c>maxAge</c>   defaulting to 0 (can be string converted by <c>ms</c>)
        ///   - <c>root</c>     root directory for relative filenames
        ///   - <c>headers</c>  object of headers to serve with file
        ///   - <c>dotfiles</c> serve dotfiles, defaulting to false; can be <c>"allow"</c> to send them
        ///
        /// Other options are passed along to <c>send</c>.
        ///
        /// Examples:
        ///
        ///  The following example illustrates how <c>res.sendFile()</c> may
        ///  be used as an alternative for the <c>static()</c> middleware for
        ///  dynamic situations. The code backing <c>res.sendFile()</c> is actually
        ///  the same code, so HTTP cache support etc is identical.
        ///
        ///     app.get('/user/:uid/photos/:file', function(req, res){
        ///       var uid = req.params.uid
        ///         , file = req.params.file;
        ///
        ///       req.user.mayViewFilesFrom(uid, function(yes){
        ///         if (yes) {
        ///           res.sendFile('/uploads/' + uid + '/' + file);
        ///         } else {
        ///           res.send(403, 'Sorry! you cant see that.');
        ///         }
        ///       });
        ///     });
        /// </summary>
        abstract member sendFile: path: string * ?fn: ExpressServeStaticCore.Errback -> unit
        /// <summary>
        /// Transfer the file at the given <c>path</c>.
        ///
        /// Automatically sets the _Content-Type_ response header field.
        /// The callback <c>fn(err)</c> is invoked when the transfer is complete
        /// or when an error occurs. Be sure to check <c>res.headersSent</c>
        /// if you wish to attempt responding, as the header and some data
        /// may have already been transferred.
        ///
        /// Options:
        ///
        ///   - <c>maxAge</c>   defaulting to 0 (can be string converted by <c>ms</c>)
        ///   - <c>root</c>     root directory for relative filenames
        ///   - <c>headers</c>  object of headers to serve with file
        ///   - <c>dotfiles</c> serve dotfiles, defaulting to false; can be <c>"allow"</c> to send them
        ///
        /// Other options are passed along to <c>send</c>.
        ///
        /// Examples:
        ///
        ///  The following example illustrates how <c>res.sendFile()</c> may
        ///  be used as an alternative for the <c>static()</c> middleware for
        ///  dynamic situations. The code backing <c>res.sendFile()</c> is actually
        ///  the same code, so HTTP cache support etc is identical.
        ///
        ///     app.get('/user/:uid/photos/:file', function(req, res){
        ///       var uid = req.params.uid
        ///         , file = req.params.file;
        ///
        ///       req.user.mayViewFilesFrom(uid, function(yes){
        ///         if (yes) {
        ///           res.sendFile('/uploads/' + uid + '/' + file);
        ///         } else {
        ///           res.send(403, 'Sorry! you cant see that.');
        ///         }
        ///       });
        ///     });
        /// </summary>
        abstract member sendFile: path: string * options: ExpressServeStaticCore.SendFileOptions * ?fn: ExpressServeStaticCore.Errback -> unit
        /// <summary>
        /// Transfer the file at the given <c>path</c> as an attachment.
        ///
        /// Optionally providing an alternate attachment <c>filename</c>,
        /// and optional callback <c>fn(err)</c>. The callback is invoked
        /// when the data transfer is complete, or when an error has
        /// ocurred. Be sure to check <c>res.headersSent</c> if you plan to respond.
        ///
        /// The optional options argument passes through to the underlying
        /// res.sendFile() call, and takes the exact same parameters.
        ///
        /// This method uses <c>res.sendFile()</c>.
        /// </summary>
        abstract member download: path: string * ?fn: ExpressServeStaticCore.Errback -> unit
        /// <summary>
        /// Transfer the file at the given <c>path</c> as an attachment.
        ///
        /// Optionally providing an alternate attachment <c>filename</c>,
        /// and optional callback <c>fn(err)</c>. The callback is invoked
        /// when the data transfer is complete, or when an error has
        /// ocurred. Be sure to check <c>res.headersSent</c> if you plan to respond.
        ///
        /// The optional options argument passes through to the underlying
        /// res.sendFile() call, and takes the exact same parameters.
        ///
        /// This method uses <c>res.sendFile()</c>.
        /// </summary>
        abstract member download: path: string * filename: string * ?fn: ExpressServeStaticCore.Errback -> unit
        /// <summary>
        /// Transfer the file at the given <c>path</c> as an attachment.
        ///
        /// Optionally providing an alternate attachment <c>filename</c>,
        /// and optional callback <c>fn(err)</c>. The callback is invoked
        /// when the data transfer is complete, or when an error has
        /// ocurred. Be sure to check <c>res.headersSent</c> if you plan to respond.
        ///
        /// The optional options argument passes through to the underlying
        /// res.sendFile() call, and takes the exact same parameters.
        ///
        /// This method uses <c>res.sendFile()</c>.
        /// </summary>
        abstract member download: path: string * filename: string * options: ExpressServeStaticCore.DownloadOptions * ?fn: ExpressServeStaticCore.Errback -> unit
        /// <summary>
        /// Set _Content-Type_ response header with <c>type</c> through <c>mime.lookup()</c>
        /// when it does not contain "/", or set the Content-Type to <c>type</c> otherwise.
        ///
        /// Examples:
        ///
        ///     res.type('.html');
        ///     res.type('html');
        ///     res.type('json');
        ///     res.type('application/json');
        ///     res.type('png');
        /// </summary>
        abstract member contentType: ``type``: string -> Response<'ResBody, 'LocalsObj, 'StatusCode>
        /// <summary>
        /// Set _Content-Type_ response header with <c>type</c> through <c>mime.lookup()</c>
        /// when it does not contain "/", or set the Content-Type to <c>type</c> otherwise.
        ///
        /// Examples:
        ///
        ///     res.type('.html');
        ///     res.type('html');
        ///     res.type('json');
        ///     res.type('application/json');
        ///     res.type('png');
        /// </summary>
        abstract member ``type``: ``type``: string -> Response<'ResBody, 'LocalsObj, 'StatusCode>
        /// <summary>
        /// Respond to the Acceptable formats using an <c>obj</c>
        /// of mime-type callbacks.
        ///
        /// This method uses <c>req.accepted</c>, an array of
        /// acceptable types ordered by their quality values.
        /// When "Accept" is not present the _first_ callback
        /// is invoked, otherwise the first match is used. When
        /// no match is performed the server responds with
        /// 406 "Not Acceptable".
        ///
        /// Content-Type is set for you, however if you choose
        /// you may alter this within the callback using <c>res.type()</c>
        /// or <c>res.set('Content-Type', ...)</c>.
        ///
        ///    res.format({
        ///      'text/plain': function(){
        ///        res.send('hey');
        ///      },
        ///
        ///      'text/html': function(){
        ///        res.send('<p>hey</p>');
        ///      },
        ///
        ///      'appliation/json': function(){
        ///        res.send({ message: 'hey' });
        ///      }
        ///    });
        ///
        /// In addition to canonicalized MIME types you may
        /// also use extnames mapped to these types:
        ///
        ///    res.format({
        ///      text: function(){
        ///        res.send('hey');
        ///      },
        ///
        ///      html: function(){
        ///        res.send('<p>hey</p>');
        ///      },
        ///
        ///      json: function(){
        ///        res.send({ message: 'hey' });
        ///      }
        ///    });
        ///
        /// By default Express passes an <c>Error</c>
        /// with a <c>.status</c> of 406 to <c>next(err)</c>
        /// if a match is not made. If you provide
        /// a <c>.default</c> callback it will be invoked
        /// instead.
        /// </summary>
        abstract member format: obj: obj -> Response<'ResBody, 'LocalsObj, 'StatusCode>
        /// <summary>
        /// Set _Content-Disposition_ header to _attachment_ with optional <c>filename</c>.
        /// </summary>
        abstract member attachment: ?filename: string -> Response<'ResBody, 'LocalsObj, 'StatusCode>
        /// <summary>
        /// Set header <c>field</c> to <c>val</c>, or pass
        /// an object of header fields.
        ///
        /// Examples:
        ///
        ///    res.set('Foo', ['bar', 'baz']);
        ///    res.set('Accept', 'application/json');
        ///    res.set({ Accept: 'text/plain', 'X-API-Key': 'tobi' });
        ///
        /// Aliased as <c>res.header()</c>.
        /// </summary>
        abstract member set: field: obj -> Response<'ResBody, 'LocalsObj, 'StatusCode>
        /// <summary>
        /// Set header <c>field</c> to <c>val</c>, or pass
        /// an object of header fields.
        ///
        /// Examples:
        ///
        ///    res.set('Foo', ['bar', 'baz']);
        ///    res.set('Accept', 'application/json');
        ///    res.set({ Accept: 'text/plain', 'X-API-Key': 'tobi' });
        ///
        /// Aliased as <c>res.header()</c>.
        /// </summary>
        abstract member set: field: string -> Response<'ResBody, 'LocalsObj, 'StatusCode>
        /// <summary>
        /// Set header <c>field</c> to <c>val</c>, or pass
        /// an object of header fields.
        ///
        /// Examples:
        ///
        ///    res.set('Foo', ['bar', 'baz']);
        ///    res.set('Accept', 'application/json');
        ///    res.set({ Accept: 'text/plain', 'X-API-Key': 'tobi' });
        ///
        /// Aliased as <c>res.header()</c>.
        /// </summary>
        abstract member set: field: string * value: string -> Response<'ResBody, 'LocalsObj, 'StatusCode>
        /// <summary>
        /// Set header <c>field</c> to <c>val</c>, or pass
        /// an object of header fields.
        ///
        /// Examples:
        ///
        ///    res.set('Foo', ['bar', 'baz']);
        ///    res.set('Accept', 'application/json');
        ///    res.set({ Accept: 'text/plain', 'X-API-Key': 'tobi' });
        ///
        /// Aliased as <c>res.header()</c>.
        /// </summary>
        abstract member set: field: string * value: ResizeArray<string> -> Response<'ResBody, 'LocalsObj, 'StatusCode>
        abstract member header: field: obj -> Response<'ResBody, 'LocalsObj, 'StatusCode>
        abstract member header: field: string -> Response<'ResBody, 'LocalsObj, 'StatusCode>
        abstract member header: field: string * value: string -> Response<'ResBody, 'LocalsObj, 'StatusCode>
        abstract member header: field: string * value: ResizeArray<string> -> Response<'ResBody, 'LocalsObj, 'StatusCode>
        /// <summary>
        /// Read-only. <c>true</c> if the headers were sent, otherwise <c>false</c>.
        /// </summary>
        abstract member headersSent: bool with get, set
        /// <summary>
        /// Get value for header <c>field</c>.
        /// </summary>
        abstract member get: field: string -> string option
        /// <summary>
        /// Clear cookie <c>name</c>.
        /// </summary>
        abstract member clearCookie: name: string * ?options: ExpressServeStaticCore.CookieOptions -> Response<'ResBody, 'LocalsObj, 'StatusCode>
        /// <summary>
        /// Set cookie <c>name</c> to <c>val</c>, with the given <c>options</c>.
        ///
        /// Options:
        ///
        ///    - <c>maxAge</c>   max-age in milliseconds, converted to <c>expires</c>
        ///    - <c>signed</c>   sign the cookie
        ///    - <c>path</c>     defaults to "/"
        ///
        /// Examples:
        ///
        ///    // "Remember Me" for 15 minutes
        ///    res.cookie('rememberme', '1', { expires: new Date(Date.now() + 900000), httpOnly: true });
        ///
        ///    // save as above
        ///    res.cookie('rememberme', '1', { maxAge: 900000, httpOnly: true })
        /// </summary>
        abstract member cookie: name: string * ``val``: string * options: ExpressServeStaticCore.CookieOptions -> Response<'ResBody, 'LocalsObj, 'StatusCode>
        /// <summary>
        /// Set cookie <c>name</c> to <c>val</c>, with the given <c>options</c>.
        ///
        /// Options:
        ///
        ///    - <c>maxAge</c>   max-age in milliseconds, converted to <c>expires</c>
        ///    - <c>signed</c>   sign the cookie
        ///    - <c>path</c>     defaults to "/"
        ///
        /// Examples:
        ///
        ///    // "Remember Me" for 15 minutes
        ///    res.cookie('rememberme', '1', { expires: new Date(Date.now() + 900000), httpOnly: true });
        ///
        ///    // save as above
        ///    res.cookie('rememberme', '1', { maxAge: 900000, httpOnly: true })
        /// </summary>
        abstract member cookie: name: string * ``val``: obj * options: ExpressServeStaticCore.CookieOptions -> Response<'ResBody, 'LocalsObj, 'StatusCode>
        /// <summary>
        /// Set cookie <c>name</c> to <c>val</c>, with the given <c>options</c>.
        ///
        /// Options:
        ///
        ///    - <c>maxAge</c>   max-age in milliseconds, converted to <c>expires</c>
        ///    - <c>signed</c>   sign the cookie
        ///    - <c>path</c>     defaults to "/"
        ///
        /// Examples:
        ///
        ///    // "Remember Me" for 15 minutes
        ///    res.cookie('rememberme', '1', { expires: new Date(Date.now() + 900000), httpOnly: true });
        ///
        ///    // save as above
        ///    res.cookie('rememberme', '1', { maxAge: 900000, httpOnly: true })
        /// </summary>
        abstract member cookie: name: string * ``val``: obj -> Response<'ResBody, 'LocalsObj, 'StatusCode>
        /// <summary>
        /// Set the location header to <c>url</c>.
        ///
        /// Examples:
        ///
        ///    res.location('/foo/bar').;
        ///    res.location('http://example.com');
        ///    res.location('../login'); // /blog/post/1 -> /blog/login
        ///
        /// Mounting:
        ///
        ///   When an application is mounted and <c>res.location()</c>
        ///   is given a path that does _not_ lead with "/" it becomes
        ///   relative to the mount-point. For example if the application
        ///   is mounted at "/blog", the following would become "/blog/login".
        ///
        ///      res.location('login');
        ///
        ///   While the leading slash would result in a location of "/login":
        ///
        ///      res.location('/login');
        /// </summary>
        abstract member location: url: string -> Response<'ResBody, 'LocalsObj, 'StatusCode>
        /// <summary>
        /// Redirect to the given <c>url</c> with optional response <c>status</c>
        /// defaulting to 302.
        ///
        /// The resulting <c>url</c> is determined by <c>res.location()</c>, so
        /// it will play nicely with mounted apps, relative paths, etc.
        ///
        /// Examples:
        ///
        ///    res.redirect('/foo/bar');
        ///    res.redirect('http://example.com');
        ///    res.redirect(301, 'http://example.com');
        ///    res.redirect('../login'); // /blog/post/1 -> /blog/login
        /// </summary>
        abstract member redirect: url: string -> unit
        /// <summary>
        /// Redirect to the given <c>url</c> with optional response <c>status</c>
        /// defaulting to 302.
        ///
        /// The resulting <c>url</c> is determined by <c>res.location()</c>, so
        /// it will play nicely with mounted apps, relative paths, etc.
        ///
        /// Examples:
        ///
        ///    res.redirect('/foo/bar');
        ///    res.redirect('http://example.com');
        ///    res.redirect(301, 'http://example.com');
        ///    res.redirect('../login'); // /blog/post/1 -> /blog/login
        /// </summary>
        abstract member redirect: status: float * url: string -> unit
        /// <summary>
        /// Render <c>view</c> with the given <c>options</c> and optional callback <c>fn</c>.
        /// When a callback function is given a response will _not_ be made
        /// automatically, otherwise a response of _200_ and _text/html_ is given.
        ///
        /// Options:
        ///
        ///  - <c>cache</c>     boolean hinting to the engine it should cache
        ///  - <c>filename</c>  filename of the view being rendered
        /// </summary>
        abstract member render: view: string * ?options: obj * ?callback: Response.render.callback -> unit
        /// <summary>
        /// Render <c>view</c> with the given <c>options</c> and optional callback <c>fn</c>.
        /// When a callback function is given a response will _not_ be made
        /// automatically, otherwise a response of _200_ and _text/html_ is given.
        ///
        /// Options:
        ///
        ///  - <c>cache</c>     boolean hinting to the engine it should cache
        ///  - <c>filename</c>  filename of the view being rendered
        /// </summary>
        abstract member render: view: string * ?callback: Response.render.callback -> unit
        abstract member locals: obj with get, set
        abstract member charset: string with get, set
        /// <summary>
        /// Adds the field to the Vary response header, if it is not there already.
        /// Examples:
        ///
        ///     res.vary('User-Agent').render('docs');
        /// </summary>
        abstract member vary: field: string -> Response<'ResBody, 'LocalsObj, 'StatusCode>
        abstract member app: ExpressServeStaticCore.Application with get, set
        /// <summary>
        /// Appends the specified value to the HTTP response header field.
        /// If the header is not already set, it creates the header with the specified value.
        /// The value parameter can be a string or an array.
        ///
        /// Note: calling res.set() after res.append() will reset the previously-set header value.
        /// </summary>
        abstract member append: field: string -> Response<'ResBody, 'LocalsObj, 'StatusCode>
        /// <summary>
        /// Appends the specified value to the HTTP response header field.
        /// If the header is not already set, it creates the header with the specified value.
        /// The value parameter can be a string or an array.
        ///
        /// Note: calling res.set() after res.append() will reset the previously-set header value.
        /// </summary>
        abstract member append: field: string * value: ResizeArray<string> -> Response<'ResBody, 'LocalsObj, 'StatusCode>
        /// <summary>
        /// Appends the specified value to the HTTP response header field.
        /// If the header is not already set, it creates the header with the specified value.
        /// The value parameter can be a string or an array.
        ///
        /// Note: calling res.set() after res.append() will reset the previously-set header value.
        /// </summary>
        abstract member append: field: string * value: string -> Response<'ResBody, 'LocalsObj, 'StatusCode>
        /// <summary>
        /// After middleware.init executed, Response will contain req property
        /// See: express/lib/middleware/init.js
        /// </summary>
        abstract member req: ExpressServeStaticCore.Request with get, set

    type Handler =
        ExpressServeStaticCore.RequestHandler

    type RequestParamHandler =
        delegate of req: ExpressServeStaticCore.Request * res: ExpressServeStaticCore.Response * next: ExpressServeStaticCore.NextFunction * value: obj * name: string -> unit

    [<AllowNullLiteral>]
    [<Interface>]
    type ApplicationRequestHandler<'T> =
        [<Emit("$0($1...)")>]
        abstract member Invoke: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> 'T
        [<Emit("$0($1...)")>]
        abstract member Invoke: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> 'T
        [<Emit("$0($1...)")>]
        abstract member Invoke<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> 'T
        [<Emit("$0($1...)")>]
        abstract member Invoke<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> 'T
        [<Emit("$0($1...)")>]
        abstract member Invoke<'Route, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Route * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> 'T
        [<Emit("$0($1...)")>]
        abstract member Invoke<'Path, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Path * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> 'T
        [<Emit("$0($1...)")>]
        abstract member Invoke<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ExpressServeStaticCore.PathParams * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> 'T
        [<Emit("$0($1...)")>]
        abstract member Invoke<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ExpressServeStaticCore.PathParams * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> 'T
        [<Emit("$0($1...)")>]
        abstract member Invoke: path: ExpressServeStaticCore.PathParams * subApplication: ExpressServeStaticCore.Application<obj> -> 'T

    [<AllowNullLiteral>]
    [<Interface>]
    type Application<'LocalsObj> =
        inherit Glutinum.Node.events.EventEmitter
        inherit ExpressServeStaticCore.IRouter
        inherit ExpressServeStaticCore.Express.Application
        [<Emit("$0($1...)")>]
        abstract member Invoke: req: U2<ExpressServeStaticCore.Request, Glutinum.Node.http.IncomingMessage> * res: U2<ExpressServeStaticCore.Response, Glutinum.Node.http.ServerResponse> -> obj
        /// <summary>
        /// Initialize the server.
        ///
        ///   - setup default configuration
        ///   - setup default middleware
        ///   - setup route reflection methods
        /// </summary>
        abstract member init: unit -> unit
        /// <summary>
        /// Initialize application configuration.
        /// </summary>
        abstract member defaultConfiguration: unit -> unit
        /// <summary>
        /// Register the given template engine callback <c>fn</c>
        /// as <c>ext</c>.
        ///
        /// By default will <c>require()</c> the engine based on the
        /// file extension. For example if you try to render
        /// a "foo.jade" file Express will invoke the following internally:
        ///
        ///     app.engine('jade', require('jade').__express);
        ///
        /// For engines that do not provide <c>.__express</c> out of the box,
        /// or if you wish to "map" a different extension to the template engine
        /// you may use this method. For example mapping the EJS template engine to
        /// ".html" files:
        ///
        ///     app.engine('html', require('ejs').renderFile);
        ///
        /// In this case EJS provides a <c>.renderFile()</c> method with
        /// the same signature that Express expects: <c>(path, options, callback)</c>,
        /// though note that it aliases this method as <c>ejs.__express</c> internally
        /// so if you're using ".ejs" extensions you dont need to do anything.
        ///
        /// Some template engines do not follow this convention, the
        /// [Consolidate.js](https://github.com/visionmedia/consolidate.js)
        /// library was created to map all of node's popular template
        /// engines to follow this convention, thus allowing them to
        /// work seamlessly within Express.
        /// </summary>
        abstract member engine: ext: string * fn: Application.engine.fn -> Application<'LocalsObj>
        /// <summary>
        /// Assign <c>setting</c> to <c>val</c>, or return <c>setting</c>'s value.
        ///
        ///    app.set('foo', 'bar');
        ///    app.get('foo');
        ///    // => "bar"
        ///    app.set('foo', ['bar', 'baz']);
        ///    app.get('foo');
        ///    // => ["bar", "baz"]
        ///
        /// Mounted servers inherit their parent server's settings.
        /// </summary>
        abstract member set: setting: string * ``val``: obj -> Application<'LocalsObj>
        abstract member get: name: string -> obj
        abstract member get<'Route, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Route * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> obj
        abstract member get<'Path, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Path * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> obj
        abstract member get<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> obj
        abstract member get<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> obj
        abstract member get<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> obj
        abstract member get: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> obj
        abstract member get: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> obj
        abstract member get: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> obj
        abstract member get<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> obj
        abstract member get<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> obj
        abstract member get<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> obj
        abstract member get: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> obj
        abstract member get: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> obj
        abstract member get: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> obj
        abstract member get: path: string * subApplication: ExpressServeStaticCore.Application<obj> -> obj
        abstract member get: path: RegExp * subApplication: ExpressServeStaticCore.Application<obj> -> obj
        abstract member get: path: ResizeArray<U2<string, RegExp>> * subApplication: ExpressServeStaticCore.Application<obj> -> obj
        /// <summary>
        /// Map the given param placeholder <c>name</c>(s) to the given callback(s).
        ///
        /// Parameter mapping is used to provide pre-conditions to routes
        /// which use normalized placeholders. For example a _:user_id_ parameter
        /// could automatically load a user's information from the database without
        /// any additional code,
        ///
        /// The callback uses the samesignature as middleware, the only differencing
        /// being that the value of the placeholder is passed, in this case the _id_
        /// of the user. Once the <c>next()</c> function is invoked, just like middleware
        /// it will continue on to execute the route, or subsequent parameter functions.
        ///
        ///      app.param('user_id', function(req, res, next, id){
        ///        User.find(id, function(err, user){
        ///          if (err) {
        ///            next(err);
        ///          } else if (user) {
        ///            req.user = user;
        ///            next();
        ///          } else {
        ///            next(new Error('failed to load user'));
        ///          }
        ///        });
        ///      });
        /// </summary>
        abstract member param: name: string * handler: ExpressServeStaticCore.RequestParamHandler -> Application<'LocalsObj>
        /// <summary>
        /// Map the given param placeholder <c>name</c>(s) to the given callback(s).
        ///
        /// Parameter mapping is used to provide pre-conditions to routes
        /// which use normalized placeholders. For example a _:user_id_ parameter
        /// could automatically load a user's information from the database without
        /// any additional code,
        ///
        /// The callback uses the samesignature as middleware, the only differencing
        /// being that the value of the placeholder is passed, in this case the _id_
        /// of the user. Once the <c>next()</c> function is invoked, just like middleware
        /// it will continue on to execute the route, or subsequent parameter functions.
        ///
        ///      app.param('user_id', function(req, res, next, id){
        ///        User.find(id, function(err, user){
        ///          if (err) {
        ///            next(err);
        ///          } else if (user) {
        ///            req.user = user;
        ///            next();
        ///          } else {
        ///            next(new Error('failed to load user'));
        ///          }
        ///        });
        ///      });
        /// </summary>
        abstract member param: name: ResizeArray<string> * handler: ExpressServeStaticCore.RequestParamHandler -> Application<'LocalsObj>
        /// <summary>
        /// Return the app's absolute pathname
        /// based on the parent(s) that have
        /// mounted it.
        ///
        /// For example if the application was
        /// mounted as "/admin", which itself
        /// was mounted as "/blog" then the
        /// return value would be "/blog/admin".
        /// </summary>
        abstract member path: unit -> string
        /// <summary>
        /// Check if <c>setting</c> is enabled (truthy).
        ///
        ///    app.enabled('foo')
        ///    // => false
        ///
        ///    app.enable('foo')
        ///    app.enabled('foo')
        ///    // => true
        /// </summary>
        abstract member enabled: setting: string -> bool
        /// <summary>
        /// Check if <c>setting</c> is disabled.
        ///
        ///    app.disabled('foo')
        ///    // => true
        ///
        ///    app.enable('foo')
        ///    app.disabled('foo')
        ///    // => false
        /// </summary>
        abstract member disabled: setting: string -> bool
        /// <summary>
        /// Enable <c>setting</c>.
        /// </summary>
        abstract member enable: setting: string -> Application<'LocalsObj>
        /// <summary>
        /// Disable <c>setting</c>.
        /// </summary>
        abstract member disable: setting: string -> Application<'LocalsObj>
        /// <summary>
        /// Render the given view <c>name</c> name with <c>options</c>
        /// and a callback accepting an error and the
        /// rendered template string.
        ///
        /// Example:
        ///
        ///    app.render('email', { name: 'Tobi' }, function(err, html){
        ///      // ...
        ///    })
        /// </summary>
        abstract member render: name: string * ?options: obj * ?callback: Application.render.callback -> unit
        /// <summary>
        /// Render the given view <c>name</c> name with <c>options</c>
        /// and a callback accepting an error and the
        /// rendered template string.
        ///
        /// Example:
        ///
        ///    app.render('email', { name: 'Tobi' }, function(err, html){
        ///      // ...
        ///    })
        /// </summary>
        abstract member render: name: string * callback: Application.render.callback -> unit
        /// <summary>
        /// Listen for connections.
        ///
        /// A node <c>http.Server</c> is returned, with this
        /// application (which is a <c>Function</c>) as its
        /// callback. If you wish to create both an HTTP
        /// and HTTPS server you may do so with the "http"
        /// and "https" modules as shown here:
        ///
        ///    var http = require('http')
        ///      , https = require('https')
        ///      , express = require('express')
        ///      , app = express();
        ///
        ///    http.createServer(app).listen(80);
        ///    https.createServer({ ... }, app).listen(443);
        /// </summary>
        abstract member listen: port: float * hostname: string * backlog: float * ?callback: (Exception option -> unit) -> Glutinum.Node.http.Server
        /// <summary>
        /// Listen for connections.
        ///
        /// A node <c>http.Server</c> is returned, with this
        /// application (which is a <c>Function</c>) as its
        /// callback. If you wish to create both an HTTP
        /// and HTTPS server you may do so with the "http"
        /// and "https" modules as shown here:
        ///
        ///    var http = require('http')
        ///      , https = require('https')
        ///      , express = require('express')
        ///      , app = express();
        ///
        ///    http.createServer(app).listen(80);
        ///    https.createServer({ ... }, app).listen(443);
        /// </summary>
        abstract member listen: port: float * hostname: string * ?callback: (Exception option -> unit) -> Glutinum.Node.http.Server
        /// <summary>
        /// Listen for connections.
        ///
        /// A node <c>http.Server</c> is returned, with this
        /// application (which is a <c>Function</c>) as its
        /// callback. If you wish to create both an HTTP
        /// and HTTPS server you may do so with the "http"
        /// and "https" modules as shown here:
        ///
        ///    var http = require('http')
        ///      , https = require('https')
        ///      , express = require('express')
        ///      , app = express();
        ///
        ///    http.createServer(app).listen(80);
        ///    https.createServer({ ... }, app).listen(443);
        /// </summary>
        abstract member listen: port: float * ?callback: (Exception option -> unit) -> Glutinum.Node.http.Server
        /// <summary>
        /// Listen for connections.
        ///
        /// A node <c>http.Server</c> is returned, with this
        /// application (which is a <c>Function</c>) as its
        /// callback. If you wish to create both an HTTP
        /// and HTTPS server you may do so with the "http"
        /// and "https" modules as shown here:
        ///
        ///    var http = require('http')
        ///      , https = require('https')
        ///      , express = require('express')
        ///      , app = express();
        ///
        ///    http.createServer(app).listen(80);
        ///    https.createServer({ ... }, app).listen(443);
        /// </summary>
        abstract member listen: ?callback: (Exception option -> unit) -> Glutinum.Node.http.Server
        /// <summary>
        /// Listen for connections.
        ///
        /// A node <c>http.Server</c> is returned, with this
        /// application (which is a <c>Function</c>) as its
        /// callback. If you wish to create both an HTTP
        /// and HTTPS server you may do so with the "http"
        /// and "https" modules as shown here:
        ///
        ///    var http = require('http')
        ///      , https = require('https')
        ///      , express = require('express')
        ///      , app = express();
        ///
        ///    http.createServer(app).listen(80);
        ///    https.createServer({ ... }, app).listen(443);
        /// </summary>
        abstract member listen: path: string * ?callback: (Exception option -> unit) -> Glutinum.Node.http.Server
        /// <summary>
        /// Listen for connections.
        ///
        /// A node <c>http.Server</c> is returned, with this
        /// application (which is a <c>Function</c>) as its
        /// callback. If you wish to create both an HTTP
        /// and HTTPS server you may do so with the "http"
        /// and "https" modules as shown here:
        ///
        ///    var http = require('http')
        ///      , https = require('https')
        ///      , express = require('express')
        ///      , app = express();
        ///
        ///    http.createServer(app).listen(80);
        ///    https.createServer({ ... }, app).listen(443);
        /// </summary>
        abstract member listen: handle: obj * ?listeningListener: (Exception option -> unit) -> Glutinum.Node.http.Server
        abstract member router: ExpressServeStaticCore.Router with get, set
        abstract member settings: obj with get, set
        abstract member resource: obj with get, set
        abstract member map: obj with get, set
        abstract member locals: obj with get, set
        /// <summary>
        /// The app.routes object houses all of the routes defined mapped by the
        /// associated HTTP verb. This object may be used for introspection
        /// capabilities, for example Express uses this internally not only for
        /// routing but to provide default OPTIONS behaviour unless app.options()
        /// is used. Your application or framework may also remove routes by
        /// simply by removing them from this object.
        /// </summary>
        abstract member routes: obj with get, set
        /// <summary>
        /// Used to get all registered routes in Express Application
        /// </summary>
        abstract member _router: obj with get, set
        abstract member ``use``: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.ApplicationRequestHandler<Application<'LocalsObj>>
        abstract member ``use``: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.ApplicationRequestHandler<Application<'LocalsObj>>
        abstract member ``use``<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.ApplicationRequestHandler<Application<'LocalsObj>>
        abstract member ``use``<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.ApplicationRequestHandler<Application<'LocalsObj>>
        abstract member ``use``<'Route, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Route * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.ApplicationRequestHandler<Application<'LocalsObj>>
        abstract member ``use``<'Path, 'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: 'Path * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.ApplicationRequestHandler<Application<'LocalsObj>>
        abstract member ``use``<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.ApplicationRequestHandler<Application<'LocalsObj>>
        abstract member ``use``<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.ApplicationRequestHandler<Application<'LocalsObj>>
        abstract member ``use``<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.ApplicationRequestHandler<Application<'LocalsObj>>
        abstract member ``use``: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.ApplicationRequestHandler<Application<'LocalsObj>>
        abstract member ``use``: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.ApplicationRequestHandler<Application<'LocalsObj>>
        abstract member ``use``: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.ApplicationRequestHandler<Application<'LocalsObj>>
        abstract member ``use``<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.ApplicationRequestHandler<Application<'LocalsObj>>
        abstract member ``use``<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.ApplicationRequestHandler<Application<'LocalsObj>>
        abstract member ``use``<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj>: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, 'LocalsObj> [] -> ExpressServeStaticCore.ApplicationRequestHandler<Application<'LocalsObj>>
        abstract member ``use``: path: string * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.ApplicationRequestHandler<Application<'LocalsObj>>
        abstract member ``use``: path: RegExp * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.ApplicationRequestHandler<Application<'LocalsObj>>
        abstract member ``use``: path: ResizeArray<U2<string, RegExp>> * [<ParamArray>] handlers: ExpressServeStaticCore.RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj> [] -> ExpressServeStaticCore.ApplicationRequestHandler<Application<'LocalsObj>>
        abstract member ``use``: path: string * subApplication: ExpressServeStaticCore.Application<obj> -> ExpressServeStaticCore.ApplicationRequestHandler<Application<'LocalsObj>>
        abstract member ``use``: path: RegExp * subApplication: ExpressServeStaticCore.Application<obj> -> ExpressServeStaticCore.ApplicationRequestHandler<Application<'LocalsObj>>
        abstract member ``use``: path: ResizeArray<U2<string, RegExp>> * subApplication: ExpressServeStaticCore.Application<obj> -> ExpressServeStaticCore.ApplicationRequestHandler<Application<'LocalsObj>>
        /// <summary>
        /// The mount event is fired on a sub-app, when it is mounted on a parent app.
        /// The parent app is passed to the callback function.
        ///
        /// NOTE:
        /// Sub-apps will:
        ///  - Not inherit the value of settings that have a default value. You must set the value in the sub-app.
        ///  - Inherit the value of settings with no default value.
        /// </summary>
        abstract member on: Application.on<'LocalsObj> with get, set
        /// <summary>
        /// The app.mountpath property contains one or more path patterns on which a sub-app was mounted.
        /// </summary>
        abstract member mountpath: U2<string, ResizeArray<string>> with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type Express =
        inherit ExpressServeStaticCore.Application
        abstract member request: ExpressServeStaticCore.Request with get, set
        abstract member response: ExpressServeStaticCore.Response with get, set

    module Express =

        [<AllowNullLiteral>]
        [<Interface>]
        type Request =
            interface end

        [<AllowNullLiteral>]
        [<Interface>]
        type Response =
            interface end

        [<AllowNullLiteral>]
        [<Interface>]
        type Locals =
            interface end

        [<AllowNullLiteral>]
        [<Interface>]
        type Application =
            interface end

    type RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery> =
        RequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, obj>

    type RequestHandler<'P, 'ResBody, 'ReqBody> =
        RequestHandler<'P, 'ResBody, 'ReqBody, Qs.QueryString_.ParsedQs, obj>

    type RequestHandler<'P, 'ResBody> =
        RequestHandler<'P, 'ResBody, obj, Qs.QueryString_.ParsedQs, obj>

    type RequestHandler<'P> =
        RequestHandler<'P, obj, obj, Qs.QueryString_.ParsedQs, obj>

    type RequestHandler =
        RequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj>

    type ErrorRequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery> =
        ErrorRequestHandler<'P, 'ResBody, 'ReqBody, 'ReqQuery, obj>

    type ErrorRequestHandler<'P, 'ResBody, 'ReqBody> =
        ErrorRequestHandler<'P, 'ResBody, 'ReqBody, Qs.QueryString_.ParsedQs, obj>

    type ErrorRequestHandler<'P, 'ResBody> =
        ErrorRequestHandler<'P, 'ResBody, obj, Qs.QueryString_.ParsedQs, obj>

    type ErrorRequestHandler<'P> =
        ErrorRequestHandler<'P, obj, obj, Qs.QueryString_.ParsedQs, obj>

    type ErrorRequestHandler =
        ErrorRequestHandler<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj>

    type RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery> =
        RequestHandlerParams<'P, 'ResBody, 'ReqBody, 'ReqQuery, obj>

    type RequestHandlerParams<'P, 'ResBody, 'ReqBody> =
        RequestHandlerParams<'P, 'ResBody, 'ReqBody, Qs.QueryString_.ParsedQs, obj>

    type RequestHandlerParams<'P, 'ResBody> =
        RequestHandlerParams<'P, 'ResBody, obj, Qs.QueryString_.ParsedQs, obj>

    type RequestHandlerParams<'P> =
        RequestHandlerParams<'P, obj, obj, Qs.QueryString_.ParsedQs, obj>

    type RequestHandlerParams =
        RequestHandlerParams<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj>

    type RemoveTail =
        RemoveTail<string, string>

    type GetRouteParameter =
        GetRouteParameter<string>

    type RouteParameters =
        RouteParameters<U2<string, RegExp>>

    type ParseRouteParameters =
        ParseRouteParameters<string>

    type IRouterMatcher<'T> =
        IRouterMatcher<'T, obj>

    type IRouterHandler<'T> =
        IRouterHandler<'T, string>

    type IRoute =
        IRoute<string>

    type Request<'P, 'ResBody, 'ReqBody, 'ReqQuery> =
        Request<'P, 'ResBody, 'ReqBody, 'ReqQuery, obj>

    type Request<'P, 'ResBody, 'ReqBody> =
        Request<'P, 'ResBody, 'ReqBody, Qs.QueryString_.ParsedQs, obj>

    type Request<'P, 'ResBody> =
        Request<'P, 'ResBody, obj, Qs.QueryString_.ParsedQs, obj>

    type Request<'P> =
        Request<'P, obj, obj, Qs.QueryString_.ParsedQs, obj>

    type Request =
        Request<ExpressServeStaticCore.ParamsDictionary, obj, obj, Qs.QueryString_.ParsedQs, obj>

    type Send<'ResBody> =
        Send<'ResBody, ExpressServeStaticCore.Response<'ResBody>>

    type Send =
        Send<obj, ExpressServeStaticCore.Response<obj>>

    type Response<'ResBody, 'LocalsObj> =
        Response<'ResBody, 'LocalsObj, float>

    type Response<'ResBody> =
        Response<'ResBody, obj, float>

    type Response =
        Response<obj, obj, float>

    type Application =
        Application<obj>

    module IRouterMatcher =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type Method =
            | all
            | get
            | post
            | put
            | delete
            | patch
            | options
            | head
            | query

    module ILayer =

        [<RequireQualifiedAccess>]
        [<Erase(CaseRules.None)>]
        type name =
            | ``<anonymous>``
            | Case1 of string

        type handle =
            delegate of req: ExpressServeStaticCore.Request * res: ExpressServeStaticCore.Response * next: ExpressServeStaticCore.NextFunction -> unit

    module CookieOptions =

        [<RequireQualifiedAccess>]
        [<Erase(CaseRules.None)>]
        type sameSite =
            | lax
            | strict
            | none
            | Case1 of bool

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type priority =
            | low
            | medium
            | high

    module SendFileOptions =

        [<AllowNullLiteral>]
        [<Interface>]
        type headers =
            [<EmitIndexer>]
            abstract member Item: key: string -> obj with get, set

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type dotfiles =
            | allow
            | deny
            | ignore

    module DownloadOptions =

        [<AllowNullLiteral>]
        [<Interface>]
        type headers =
            [<EmitIndexer>]
            abstract member Item: key: string -> obj with get, set

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type dotfiles =
            | allow
            | deny
            | ignore

    module Response =

        module render =

            type callback =
                delegate of err: Exception * html: string -> unit

    module Application =

        type on<'LocalsObj> =
            delegate of event: string * callback: (ExpressServeStaticCore.Application -> unit) -> Application<'LocalsObj>

        module engine =

            type fn =
                delegate of path: string * options: obj * callback: Application.engine.fn.callback -> unit

            module fn =

                type callback =
                    delegate of e: obj * ?rendered: string -> unit

        module render =

            type callback =
                delegate of err: Exception * html: string -> unit

module HttpErrors =

    [<AbstractClass>]
    [<Erase>]
    type Exports =
        [<ImportDefault("http-errors")>]
        static member inline createHttpError: Exports.createHttpError__ = nativeOnly

    module createHttpError_ =

        [<AllowNullLiteral>]
        [<Interface>]
        type HttpError<'N> =
            abstract member status: 'N with get, set
            abstract member statusCode: 'N with get, set
            abstract member expose: bool with get, set
            abstract member headers: HttpError.headers option with get, set
            [<EmitIndexer>]
            abstract member Item: key: string -> obj with get, set

        type UnknownError =
            U3<Exception, string, UnknownError.U3.Case3>

        [<AllowNullLiteral>]
        [<Interface>]
        type HttpErrorConstructor<'N> =
            [<Emit("$0($1...)")>]
            abstract member Invoke: ?msg: string -> HttpErrors.createHttpError_.HttpError<'N>
            [<EmitConstructor>]
            abstract member Create: ?msg: string -> HttpErrors.createHttpError_.HttpError<'N>

        [<AllowNullLiteral>]
        [<Interface>]
        type CreateHttpError =
            [<Emit("$0($1...)")>]
            abstract member Invoke<'N>: arg: 'N * [<ParamArray>] rest: HttpErrors.createHttpError_.UnknownError [] -> HttpErrors.createHttpError_.HttpError<'N>
            [<Emit("$0($1...)")>]
            abstract member Invoke: [<ParamArray>] rest: HttpErrors.createHttpError_.UnknownError [] -> HttpErrors.createHttpError_.HttpError

        type IsHttpError =
            delegate of error: obj -> bool

        [<AllowNullLiteral>]
        [<Interface>]
        type NamedConstructors =
            abstract member HttpError: HttpErrors.createHttpError_.HttpErrorConstructor with get, set
            abstract member BadRequest: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``400``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member Unauthorized: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``401``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member PaymentRequired: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``402``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member Forbidden: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``403``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member NotFound: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``404``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member MethodNotAllowed: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``405``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member NotAcceptable: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``406``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ProxyAuthenticationRequired: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``407``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member RequestTimeout: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``408``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member Conflict: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``409``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member Gone: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``410``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member LengthRequired: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``411``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member PreconditionFailed: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``412``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member PayloadTooLarge: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``413``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member URITooLong: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``414``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member UnsupportedMediaType: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``415``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member RangeNotSatisfiable: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``416``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ExpectationFailed: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``417``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ImATeapot: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``418``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member MisdirectedRequest: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``421``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member UnprocessableEntity: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``422``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member Locked: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``423``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member FailedDependency: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``424``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member TooEarly: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``425``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member UpgradeRequired: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``426``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member PreconditionRequired: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``428``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member TooManyRequests: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``429``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member RequestHeaderFieldsTooLarge: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``431``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member UnavailableForLegalReasons: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``451``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member InternalServerError: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``500``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member NotImplemented: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``501``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member BadGateway: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``502``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ServiceUnavailable: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``503``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member GatewayTimeout: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``504``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member HTTPVersionNotSupported: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``505``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member VariantAlsoNegotiates: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``506``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member InsufficientStorage: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``507``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member LoopDetected: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``508``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member BandwidthLimitExceeded: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``509``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member NotExtended: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``510``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member NetworkAuthenticationRequire: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``511``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set

        type HttpError =
            HttpError<float>

        type HttpErrorConstructor =
            HttpErrorConstructor<float>

        module HttpError =

            [<AllowNullLiteral>]
            [<Interface>]
            type headers =
                [<EmitIndexer>]
                abstract member Item: key: string -> string with get, set

        module UnknownError =

            module U3 =

                [<AllowNullLiteral>]
                [<Interface>]
                type Case3 =
                    [<EmitIndexer>]
                    abstract member Item: key: string -> obj with get, set

    type HttpError<'N> =
        createHttpError_.HttpError<'N>

    type HttpError =
        HttpError<float>

    type UnknownError =
        createHttpError_.UnknownError

    type HttpErrorConstructor<'N> =
        createHttpError_.HttpErrorConstructor<'N>

    type HttpErrorConstructor =
        HttpErrorConstructor<float>

    type CreateHttpError =
        createHttpError_.CreateHttpError

    type IsHttpError =
        createHttpError_.IsHttpError

    type NamedConstructors =
        createHttpError_.NamedConstructors

    module Exports =

        [<AllowNullLiteral>]
        [<Interface>]
        type createHttpError__ =
            abstract member HttpError: HttpErrors.createHttpError_.HttpErrorConstructor with get, set
            abstract member BadRequest: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``400``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member Unauthorized: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``401``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member PaymentRequired: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``402``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member Forbidden: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``403``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member NotFound: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``404``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member MethodNotAllowed: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``405``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member NotAcceptable: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``406``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ProxyAuthenticationRequired: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``407``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member RequestTimeout: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``408``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member Conflict: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``409``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member Gone: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``410``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member LengthRequired: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``411``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member PreconditionFailed: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``412``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member PayloadTooLarge: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``413``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member URITooLong: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``414``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member UnsupportedMediaType: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``415``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member RangeNotSatisfiable: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``416``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ExpectationFailed: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``417``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ImATeapot: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``418``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member MisdirectedRequest: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``421``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member UnprocessableEntity: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``422``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member Locked: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``423``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member FailedDependency: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``424``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member TooEarly: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``425``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member UpgradeRequired: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``426``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member PreconditionRequired: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``428``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member TooManyRequests: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``429``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member RequestHeaderFieldsTooLarge: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``431``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member UnavailableForLegalReasons: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``451``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member InternalServerError: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``500``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member NotImplemented: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``501``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member BadGateway: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``502``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ServiceUnavailable: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``503``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member GatewayTimeout: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``504``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member HTTPVersionNotSupported: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``505``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member VariantAlsoNegotiates: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``506``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member InsufficientStorage: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``507``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member LoopDetected: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``508``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member BandwidthLimitExceeded: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``509``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member NotExtended: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``510``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member NetworkAuthenticationRequire: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member ``511``: HttpErrors.createHttpError_.HttpErrorConstructor<int> with get, set
            abstract member isHttpError: HttpErrors.createHttpError_.IsHttpError with get, set
            [<Emit("$0($1...)")>]
            abstract member Invoke<'N>: arg: 'N * [<ParamArray>] rest: HttpErrors.createHttpError_.UnknownError [] -> HttpErrors.createHttpError_.HttpError<'N>
            [<Emit("$0($1...)")>]
            abstract member Invoke: [<ParamArray>] rest: HttpErrors.createHttpError_.UnknownError [] -> HttpErrors.createHttpError_.HttpError<float>

module Qs =

    [<AbstractClass>]
    [<Erase>]
    type Exports =
        [<ImportAll("qs")>]
        static member inline QueryString
            with get () : QueryString_.Exports =
                nativeOnly

    module QueryString_ =

        [<AbstractClass>]
        [<Erase>]
        type Exports =
            [<Emit("$0.stringify($1...)")>]
            abstract member stringify: obj: obj * ?options: Qs.QueryString_.IStringifyOptions<Qs.QueryString_.BooleanOptional> -> string
            [<Emit("$0.parse($1...)")>]
            abstract member parse: str: string * ?options: Exports.parse.options -> Qs.QueryString_.ParsedQs
            [<Emit("$0.parse($1...)")>]
            abstract member parse: str: string * ?options: Qs.QueryString_.IParseOptions<Qs.QueryString_.BooleanOptional> -> Exports.parse
            [<Emit("$0.parse($1...)")>]
            abstract member parse: str: Exports.parse.str * ?options: Qs.QueryString_.IParseOptions<Qs.QueryString_.BooleanOptional> -> Exports.parse

        type defaultEncoder =
            delegate of str: obj * ?defaultEncoder: obj * ?charset: string -> string

        type defaultDecoder =
            delegate of str: string * ?decoder: obj * ?charset: string -> string

        type BooleanOptional =
            bool option

        [<AllowNullLiteral>]
        [<Interface>]
        type IStringifyBaseOptions =
            abstract member delimiter: string option with get, set
            abstract member strictNullHandling: bool option with get, set
            abstract member skipNulls: bool option with get, set
            abstract member encode: bool option with get, set
            abstract member encoder: IStringifyBaseOptions.encoder option with get, set
            abstract member filter: U2<ResizeArray<U2<string, float>>, IStringifyBaseOptions.filter.U2.Case2> option with get, set
            abstract member arrayFormat: IStringifyBaseOptions.arrayFormat option with get, set
            abstract member indices: bool option with get, set
            abstract member sort: IStringifyBaseOptions.sort option with get, set
            abstract member serializeDate: (Date -> string) option with get, set
            abstract member format: IStringifyBaseOptions.format option with get, set
            abstract member encodeValuesOnly: bool option with get, set
            abstract member addQueryPrefix: bool option with get, set
            abstract member charset: IStringifyBaseOptions.charset option with get, set
            abstract member charsetSentinel: bool option with get, set
            abstract member allowEmptyArrays: bool option with get, set
            abstract member commaRoundTrip: bool option with get, set

        [<AllowNullLiteral>]
        [<Interface>]
        type IStringifyDynamicOptions<'AllowDots> =
            interface end

        [<AllowNullLiteral>]
        [<Interface>]
        type IStringifyOptions<'AllowDots> =
            abstract member delimiter: string option with get, set
            abstract member strictNullHandling: bool option with get, set
            abstract member skipNulls: bool option with get, set
            abstract member encode: bool option with get, set
            abstract member encoder: IStringifyOptions.encoder option with get, set
            abstract member filter: U2<ResizeArray<U2<string, float>>, IStringifyOptions.filter.U2.Case2> option with get, set
            abstract member arrayFormat: IStringifyOptions.arrayFormat option with get, set
            abstract member indices: bool option with get, set
            abstract member sort: IStringifyOptions.sort option with get, set
            abstract member serializeDate: (Date -> string) option with get, set
            abstract member format: IStringifyOptions.format option with get, set
            abstract member encodeValuesOnly: bool option with get, set
            abstract member addQueryPrefix: bool option with get, set
            abstract member charset: IStringifyOptions.charset option with get, set
            abstract member charsetSentinel: bool option with get, set
            abstract member allowEmptyArrays: bool option with get, set
            abstract member commaRoundTrip: bool option with get, set
            abstract member allowDots: bool option with get, set
            abstract member encodeDotInKeys: bool option with get, set

        [<AllowNullLiteral>]
        [<Interface>]
        type IParseBaseOptions =
            abstract member comma: bool option with get, set
            abstract member delimiter: U2<string, RegExp> option with get, set
            abstract member depth: U2<float, bool> option with get, set
            abstract member decoder: IParseBaseOptions.decoder option with get, set
            abstract member arrayLimit: float option with get, set
            abstract member parseArrays: bool option with get, set
            abstract member plainObjects: bool option with get, set
            abstract member allowPrototypes: bool option with get, set
            abstract member allowSparse: bool option with get, set
            abstract member parameterLimit: float option with get, set
            abstract member strictNullHandling: bool option with get, set
            abstract member ignoreQueryPrefix: bool option with get, set
            abstract member charset: IParseBaseOptions.charset option with get, set
            abstract member charsetSentinel: bool option with get, set
            abstract member interpretNumericEntities: bool option with get, set
            abstract member allowEmptyArrays: bool option with get, set
            abstract member duplicates: IParseBaseOptions.duplicates option with get, set
            abstract member strictDepth: bool option with get, set
            abstract member strictMerge: bool option with get, set
            abstract member throwOnLimitExceeded: bool option with get, set

        [<AllowNullLiteral>]
        [<Interface>]
        type IParseDynamicOptions<'AllowDots> =
            interface end

        [<AllowNullLiteral>]
        [<Interface>]
        type IParseOptions<'AllowDots> =
            abstract member comma: bool option with get, set
            abstract member delimiter: U2<string, RegExp> option with get, set
            abstract member depth: U2<float, bool> option with get, set
            abstract member decoder: IParseOptions.decoder option with get, set
            abstract member arrayLimit: float option with get, set
            abstract member parseArrays: bool option with get, set
            abstract member plainObjects: bool option with get, set
            abstract member allowPrototypes: bool option with get, set
            abstract member allowSparse: bool option with get, set
            abstract member parameterLimit: float option with get, set
            abstract member strictNullHandling: bool option with get, set
            abstract member ignoreQueryPrefix: bool option with get, set
            abstract member charset: IParseOptions.charset option with get, set
            abstract member charsetSentinel: bool option with get, set
            abstract member interpretNumericEntities: bool option with get, set
            abstract member allowEmptyArrays: bool option with get, set
            abstract member duplicates: IParseOptions.duplicates option with get, set
            abstract member strictDepth: bool option with get, set
            abstract member strictMerge: bool option with get, set
            abstract member throwOnLimitExceeded: bool option with get, set
            abstract member allowDots: bool option with get, set
            abstract member decodeDotInKeys: bool option with get, set

        [<AllowNullLiteral>]
        [<Interface>]
        type ParsedQs =
            [<EmitIndexer>]
            abstract member Item: key: string -> U3<string, Qs.QueryString_.ParsedQs, ResizeArray<U2<string, Qs.QueryString_.ParsedQs>>> option with get, set

        type IStringifyOptions =
            IStringifyOptions<obj>

        type IParseOptions =
            IParseOptions<obj>

        module IStringifyBaseOptions =

            type encoder =
                delegate of str: obj * defaultEncoder: Qs.QueryString_.defaultEncoder * charset: string * ``type``: IStringifyBaseOptions.encoder.``type`` -> string

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type arrayFormat =
                | indices
                | brackets
                | repeat
                | comma

            type sort =
                delegate of a: string * b: string -> float

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type format =
                | RFC1738
                | RFC3986

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type charset =
                | ``utf-8``
                | ``iso-8859-1``

            module encoder =

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type ``type`` =
                    | key
                    | value

            module filter =

                module U2 =

                    type Case2 =
                        delegate of prefix: string * value: obj -> unit

        module IStringifyOptions =

            type encoder =
                delegate of str: obj * defaultEncoder: Qs.QueryString_.defaultEncoder * charset: string * ``type``: IStringifyOptions.encoder.``type`` -> string

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type arrayFormat =
                | indices
                | brackets
                | repeat
                | comma

            type sort =
                delegate of a: string * b: string -> float

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type format =
                | RFC1738
                | RFC3986

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type charset =
                | ``utf-8``
                | ``iso-8859-1``

            module encoder =

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type ``type`` =
                    | key
                    | value

            module filter =

                module U2 =

                    type Case2 =
                        delegate of prefix: string * value: obj -> unit

        module IParseBaseOptions =

            type decoder =
                delegate of str: string * defaultDecoder: Qs.QueryString_.defaultDecoder * charset: string * ``type``: IParseBaseOptions.decoder.``type`` -> unit

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type charset =
                | ``utf-8``
                | ``iso-8859-1``

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type duplicates =
                | combine
                | first
                | last

            module decoder =

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type ``type`` =
                    | key
                    | value

        module IParseOptions =

            type decoder =
                delegate of str: string * defaultDecoder: Qs.QueryString_.defaultDecoder * charset: string * ``type``: IParseOptions.decoder.``type`` -> unit

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type charset =
                | ``utf-8``
                | ``iso-8859-1``

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type duplicates =
                | combine
                | first
                | last

            module decoder =

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type ``type`` =
                    | key
                    | value

        module Exports =

            [<AllowNullLiteral>]
            [<Interface>]
            type parse =
                [<EmitIndexer>]
                abstract member Item: key: string -> obj with get, set

            module parse =

                [<AllowNullLiteral>]
                [<Interface>]
                type options =
                    abstract member comma: bool option with get, set
                    abstract member delimiter: U2<string, RegExp> option with get, set
                    abstract member depth: U2<float, bool> option with get, set
                    abstract member decoder: obj option with get, set
                    abstract member arrayLimit: float option with get, set
                    abstract member parseArrays: bool option with get, set
                    abstract member plainObjects: bool option with get, set
                    abstract member allowPrototypes: bool option with get, set
                    abstract member allowSparse: bool option with get, set
                    abstract member parameterLimit: float option with get, set
                    abstract member strictNullHandling: bool option with get, set
                    abstract member ignoreQueryPrefix: bool option with get, set
                    abstract member charset: Exports.parse.options.charset option with get, set
                    abstract member charsetSentinel: bool option with get, set
                    abstract member interpretNumericEntities: bool option with get, set
                    abstract member allowEmptyArrays: bool option with get, set
                    abstract member duplicates: Exports.parse.options.duplicates option with get, set
                    abstract member strictDepth: bool option with get, set
                    abstract member strictMerge: bool option with get, set
                    abstract member throwOnLimitExceeded: bool option with get, set
                    abstract member allowDots: bool option with get, set
                    abstract member decodeDotInKeys: bool option with get, set

                module options =

                    [<RequireQualifiedAccess>]
                    [<StringEnum(CaseRules.None)>]
                    type charset =
                        | ``utf-8``
                        | ``iso-8859-1``

                    [<RequireQualifiedAccess>]
                    [<StringEnum(CaseRules.None)>]
                    type duplicates =
                        | combine
                        | first
                        | last

                [<AllowNullLiteral>]
                [<Interface>]
                type str =
                    [<EmitIndexer>]
                    abstract member Item: key: string -> string with get, set

module RangeParser =

    [<AbstractClass>]
    [<Erase>]
    type Exports =
        /// <summary>
        /// When ranges are returned, the array has a "type" property which is the type of
        /// range that is required (most commonly, "bytes"). Each array element is an object
        /// with a "start" and "end" property for the portion of the range.
        /// </summary>
        /// <returns>
        /// <c>-1</c> when unsatisfiable and <c>-2</c> when syntactically invalid, ranges otherwise.
        /// </returns>
        [<ImportDefault("range-parser")>]
        static member RangeParser (size: float, str: string, ?options: RangeParser.RangeParser_.Options) : U2<RangeParser.RangeParser_.Result, RangeParser.RangeParser_.Ranges> = nativeOnly

    module RangeParser_ =

        [<AllowNullLiteral>]
        [<Interface>]
        type Ranges =
            abstract member ``type``: string with get, set

        [<AllowNullLiteral>]
        [<Interface>]
        type Range =
            abstract member start: float with get, set
            abstract member ``end``: float with get, set

        [<AllowNullLiteral>]
        [<Interface>]
        type Options =
            /// <summary>
            /// The "combine" option can be set to <c>true</c> and overlapping & adjacent ranges
            /// will be combined into a single range.
            /// </summary>
            abstract member combine: bool option with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (?combine: bool) : Options = nativeOnly

        type ResultUnsatisfiable =
            int

        type ResultInvalid =
            int

        type Result =
            U2<RangeParser.RangeParser_.ResultUnsatisfiable, RangeParser.RangeParser_.ResultInvalid>

    type Ranges =
        RangeParser_.Ranges

    type Range =
        RangeParser_.Range

    type Options =
        RangeParser_.Options

    type ResultUnsatisfiable =
        RangeParser_.ResultUnsatisfiable

    type ResultInvalid =
        RangeParser_.ResultInvalid

    type Result =
        RangeParser_.Result

module Send =

    [<AbstractClass>]
    [<Erase>]
    type Exports =
        /// <summary>
        /// Create a new SendStream for the given path to send to a res.
        /// The req is the Node.js HTTP request and the path is a urlencoded path to send (urlencoded, not the actual file-system path).
        /// </summary>
        [<ImportDefault("send")>]
        static member send (req: Glutinum.Node.stream.Stream_.Readable, path: string, ?options: Send.send_.SendOptions) : Send.send_.SendStream = nativeOnly

    module send_ =

        [<AllowNullLiteral>]
        [<Interface>]
        type SendOptions =
            /// <summary>
            /// Enable or disable accepting ranged requests, defaults to true.
            /// Disabling this will not send Accept-Ranges and ignore the contents of the Range request header.
            /// </summary>
            abstract member acceptRanges: bool option with get, set
            /// <summary>
            /// Enable or disable setting Cache-Control response header, defaults to true.
            /// Disabling this will ignore the maxAge option.
            /// </summary>
            abstract member cacheControl: bool option with get, set
            /// <summary>
            /// Set how "dotfiles" are treated when encountered.
            /// A dotfile is a file or directory that begins with a dot (".").
            /// Note this check is done on the path itself without checking if the path actually exists on the disk.
            /// If root is specified, only the dotfiles above the root are checked (i.e. the root itself can be within a dotfile when when set to "deny").
            /// 'allow' No special treatment for dotfiles.
            /// 'deny' Send a 403 for any request for a dotfile.
            /// 'ignore' Pretend like the dotfile does not exist and 404.
            /// The default value is similar to 'ignore', with the exception that this default will not ignore the files within a directory that begins with a dot, for backward-compatibility.
            /// </summary>
            abstract member dotfiles: SendOptions.dotfiles option with get, set
            /// <summary>
            /// Byte offset at which the stream ends, defaults to the length of the file minus 1.
            /// The end is inclusive in the stream, meaning end: 3 will include the 4th byte in the stream.
            /// </summary>
            abstract member ``end``: float option with get, set
            /// <summary>
            /// Enable or disable etag generation, defaults to true.
            /// </summary>
            abstract member etag: bool option with get, set
            /// <summary>
            /// If a given file doesn't exist, try appending one of the given extensions, in the given order.
            /// By default, this is disabled (set to false).
            /// An example value that will serve extension-less HTML files: ['html', 'htm'].
            /// This is skipped if the requested file already has an extension.
            /// </summary>
            abstract member extensions: U3<ResizeArray<string>, string, bool> option with get, set
            /// <summary>
            /// Enable or disable the immutable directive in the Cache-Control response header, defaults to false.
            /// If set to true, the maxAge option should also be specified to enable caching.
            /// The immutable directive will prevent supported clients from making conditional requests during the life of the maxAge option to check if the file has changed.
            /// </summary>
            abstract member immutable: bool option with get, set
            /// <summary>
            /// By default send supports "index.html" files, to disable this set false or to supply a new index pass a string or an array in preferred order.
            /// </summary>
            abstract member index: U3<ResizeArray<string>, string, bool> option with get, set
            /// <summary>
            /// Enable or disable Last-Modified header, defaults to true.
            /// Uses the file system's last modified value.
            /// </summary>
            abstract member lastModified: bool option with get, set
            /// <summary>
            /// Provide a max-age in milliseconds for http caching, defaults to 0.
            /// This can also be a string accepted by the ms module.
            /// </summary>
            abstract member maxAge: U2<string, float> option with get, set
            /// <summary>
            /// Serve files relative to path.
            /// </summary>
            abstract member root: string option with get, set
            /// <summary>
            /// Byte offset at which the stream starts, defaults to 0.
            /// The start is inclusive, meaning start: 2 will include the 3rd byte in the stream.
            /// </summary>
            abstract member start: float option with get, set

        [<AllowNullLiteral>]
        [<Interface>]
        type SendStream =
            inherit Glutinum.Node.stream.Stream
            /// <summary>
            /// Emit error with <c>status</c>.
            /// </summary>
            abstract member error: status: float * ?error: Exception -> unit
            /// <summary>
            /// Check if the pathname ends with "/".
            /// </summary>
            abstract member hasTrailingSlash: unit -> bool
            /// <summary>
            /// Check if this is a conditional GET request.
            /// </summary>
            abstract member isConditionalGET: unit -> bool
            /// <summary>
            /// Strip content-* header fields.
            /// </summary>
            abstract member removeContentHeaderFields: unit -> unit
            /// <summary>
            /// Respond with 304 not modified.
            /// </summary>
            abstract member notModified: unit -> unit
            /// <summary>
            /// Raise error that headers already sent.
            /// </summary>
            abstract member headersAlreadySent: unit -> unit
            /// <summary>
            /// Check if the request is cacheable, aka responded with 2xx or 304 (see RFC 2616 section 14.2{5,6}).
            /// </summary>
            abstract member isCachable: unit -> bool
            /// <summary>
            /// Handle stat() error.
            /// </summary>
            abstract member onStatError: error: Exception -> unit
            /// <summary>
            /// Check if the cache is fresh.
            /// </summary>
            abstract member isFresh: unit -> bool
            /// <summary>
            /// Check if the range is fresh.
            /// </summary>
            abstract member isRangeFresh: unit -> bool
            /// <summary>
            /// Redirect to path.
            /// </summary>
            abstract member redirect: path: string -> unit
            /// <summary>
            /// Pipe to <c>res</c>.
            /// </summary>
            abstract member pipe<'T>: res: 'T -> 'T
            /// <summary>
            /// Transfer <c>path</c>.
            /// </summary>
            abstract member send: path: string * ?stat: Glutinum.Node.fs.Stats -> unit
            /// <summary>
            /// Transfer file for <c>path</c>.
            /// </summary>
            abstract member sendFile: path: string -> unit
            /// <summary>
            /// Transfer index for <c>path</c>.
            /// </summary>
            abstract member sendIndex: path: string -> unit
            /// <summary>
            /// Transfer index for <c>path</c>.
            /// </summary>
            abstract member stream: path: string * ?options: obj -> unit
            /// <summary>
            /// Set content-type based on <c>path</c> if it hasn't been explicitly set.
            /// </summary>
            abstract member ``type``: path: string -> unit
            /// <summary>
            /// Set response header fields, most fields may be pre-defined.
            /// </summary>
            abstract member setHeader: path: string * stat: Glutinum.Node.fs.Stats -> unit

        module SendOptions =

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type dotfiles =
                | allow
                | deny
                | ignore

    type SendOptions =
        send_.SendOptions

    type SendStream =
        send_.SendStream

module ServeStatic =

    [<AbstractClass>]
    [<Erase>]
    type Exports =
        /// <summary>
        /// Create a new middleware function to serve files from within a given root directory.
        /// The file to serve will be determined by combining req.url with the provided root directory.
        /// When a file is not found, instead of sending a 404 response, this module will instead call next() to move on to the next middleware, allowing for stacking and fall-backs.
        /// </summary>
        [<ImportDefault("serve-static")>]
        static member serveStatic<'R> (root: string, ?options: ServeStatic.serveStatic_.ServeStaticOptions<'R>) : ServeStatic.serveStatic_.RequestHandler<'R> = nativeOnly

    module serveStatic_ =

        [<AllowNullLiteral>]
        [<Interface>]
        type ServeStaticOptions<'R> =
            /// <summary>
            /// Enable or disable accepting ranged requests, defaults to true.
            /// Disabling this will not send Accept-Ranges and ignore the contents of the Range request header.
            /// </summary>
            abstract member acceptRanges: bool option with get, set
            /// <summary>
            /// Enable or disable setting Cache-Control response header, defaults to true.
            /// Disabling this will ignore the immutable and maxAge options.
            /// </summary>
            abstract member cacheControl: bool option with get, set
            /// <summary>
            /// Set how "dotfiles" are treated when encountered. A dotfile is a file or directory that begins with a dot (".").
            /// Note this check is done on the path itself without checking if the path actually exists on the disk.
            /// If root is specified, only the dotfiles above the root are checked (i.e. the root itself can be within a dotfile when when set to "deny").
            /// The default value is 'ignore'.
            /// 'allow' No special treatment for dotfiles
            /// 'deny' Send a 403 for any request for a dotfile
            /// 'ignore' Pretend like the dotfile does not exist and call next()
            /// </summary>
            abstract member dotfiles: string option with get, set
            /// <summary>
            /// Enable or disable etag generation, defaults to true.
            /// </summary>
            abstract member etag: bool option with get, set
            /// <summary>
            /// Set file extension fallbacks. When set, if a file is not found, the given extensions will be added to the file name and search for.
            /// The first that exists will be served. Example: ['html', 'htm'].
            /// The default value is false.
            /// </summary>
            abstract member extensions: U2<ResizeArray<string>, bool> option with get, set
            /// <summary>
            /// Set the middleware to have client errors fall-through as just unhandled requests,
            /// otherwise forward a client error.
            /// The difference is that client errors like a bad request or a request to a non-existent file
            /// will cause this middleware to simply next() to your next middleware when this value is true.
            /// When this value is false, these errors (even 404s), will invoke next(err).
            ///
            /// Typically true is desired such that multiple physical directories can be mapped to the same web address
            /// or for routes to fill in non-existent files.
            ///
            /// The value false can be used if this middleware is mounted at a path that is designed to be strictly
            /// a single file system directory, which allows for short-circuiting 404s for less overhead.
            /// This middleware will also reply to all methods.
            ///
            /// The default value is true.
            /// </summary>
            abstract member fallthrough: bool option with get, set
            /// <summary>
            /// Enable or disable the immutable directive in the Cache-Control response header.
            /// If enabled, the maxAge option should also be specified to enable caching. The immutable directive will prevent supported clients from making conditional requests during the life of the maxAge option to check if the file has changed.
            /// </summary>
            abstract member immutable: bool option with get, set
            /// <summary>
            /// By default this module will send "index.html" files in response to a request on a directory.
            /// To disable this set false or to supply a new index pass a string or an array in preferred order.
            /// </summary>
            abstract member index: U3<bool, string, ResizeArray<string>> option with get, set
            /// <summary>
            /// Enable or disable Last-Modified header, defaults to true. Uses the file system's last modified value.
            /// </summary>
            abstract member lastModified: bool option with get, set
            /// <summary>
            /// Provide a max-age in milliseconds for http caching, defaults to 0. This can also be a string accepted by the ms module.
            /// </summary>
            abstract member maxAge: U2<float, string> option with get, set
            /// <summary>
            /// Redirect to trailing "/" when the pathname is a dir. Defaults to true.
            /// </summary>
            abstract member redirect: bool option with get, set
            /// <summary>
            /// Function to set custom headers on response. Alterations to the headers need to occur synchronously.
            /// The function is called as fn(res, path, stat), where the arguments are:
            /// res the response object
            /// path the file path that is being sent
            /// stat the stat object of the file that is being sent
            /// </summary>
            abstract member setHeaders: ServeStaticOptions.setHeaders<'R> option with get, set

        type RequestHandler<'R> =
            delegate of request: Glutinum.Node.http.IncomingMessage * response: 'R * next: (HttpErrors.createHttpError_.HttpError option -> unit) -> unit

        type RequestHandlerConstructor<'R> =
            delegate of root: string * ?options: ServeStatic.serveStatic_.ServeStaticOptions<'R> -> ServeStatic.serveStatic_.RequestHandler<'R>

        type ServeStaticOptions =
            ServeStaticOptions<Glutinum.Node.http.ServerResponse>

        module ServeStaticOptions =

            type setHeaders<'R> =
                delegate of res: 'R * path: string * stat: obj -> unit

    type ServeStaticOptions<'R> =
        serveStatic_.ServeStaticOptions<'R>

    type ServeStaticOptions =
        ServeStaticOptions<Glutinum.Node.http.ServerResponse>

    type RequestHandler<'R> =
        serveStatic_.RequestHandler<'R>

    type RequestHandlerConstructor<'R> =
        serveStatic_.RequestHandlerConstructor<'R>
