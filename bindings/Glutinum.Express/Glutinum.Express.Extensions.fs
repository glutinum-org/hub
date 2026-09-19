namespace Glutinum

open System
open Fable.Core
open Glutinum.Express

/// Hand-written helpers for the express binding
[<Erase>]
type ExpressAdapter =

    /// A handler of the request and the response, `next` is ignored
    static member inline RequestHandler
        (handle: Func<ExpressServeStaticCore.Request, ExpressServeStaticCore.Response, unit>)
        : Express.RequestHandler
        =
        Express.RequestHandler(fun request response _ -> handle.Invoke(request, response))

    /// A handler calling `next`
    static member inline RequestHandler
        (handle:
            Func<
                ExpressServeStaticCore.Request,
                ExpressServeStaticCore.Response,
                ExpressServeStaticCore.NextFunction,
                unit
             >)
        : Express.RequestHandler
        =
        Express.RequestHandler(fun request response next -> handle.Invoke(request, response, next))

    /// A middleware of connect, `express.json ()` for example, given to `use`
    static member inline Middleware
        (middleware: Connect.createServer_.NextHandleFunction)
        : Express.RequestHandler
        =
        unbox middleware
