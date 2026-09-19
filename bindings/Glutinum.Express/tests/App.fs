/// A small web app on the binding: a JSON API for a list of users
module Glutinum.Express.Tests.App

open Fable.Core
open Fable.Core.JsInterop
open Glutinum
open Glutinum.Express

type User = { id: int; name: string }

let create () =
    let users = ResizeArray [ { id = 1; name = "Ada" }; { id = 2; name = "Grace" } ]

    let app = Exports.express ()

    // The JSON body parser, a middleware
    app.``use`` (ExpressAdapter.Middleware(Exports.json None)) |> ignore

    app.get (
        "/",
        ExpressAdapter.RequestHandler(fun _ response -> response.send "Hello from Fable" |> ignore)
    )
    |> ignore

    app.get (
        "/users",
        ExpressAdapter.RequestHandler(fun _ response -> response.json users |> ignore)
    )
    |> ignore

    // A JSON body, parsed by the middleware above
    app.post (
        "/users",
        ExpressAdapter.RequestHandler(fun request response ->
            let user =
                {
                    id = users.Count + 1
                    name = request.body?name
                }

            users.Add user
            response.status(201).json user |> ignore
        )
    )
    |> ignore

    // A route parameter, read through the `params` dictionary
    app.get (
        "/users/:id",
        ExpressAdapter.RequestHandler(fun request response ->
            let id = int (unbox<string> request.``params``.["id"])

            match users |> Seq.tryFind (fun user -> user.id = id) with
            | Some user -> response.json user |> ignore
            | None -> response.status(404).json {| error = $"no user {id}" |} |> ignore
        )
    )
    |> ignore

    // A query string, read through the `query` dictionary
    app.get (
        "/search",
        ExpressAdapter.RequestHandler(fun request response ->
            let term = unbox<string> request.query.["q"]

            let names =
                users
                |> Seq.filter (fun user -> user.name.ToLower().Contains term)
                |> Seq.map (fun user -> user.name)
                |> Seq.toArray

            response.json names |> ignore
        )
    )
    |> ignore

    app
