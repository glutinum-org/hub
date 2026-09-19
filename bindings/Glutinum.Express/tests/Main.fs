module Glutinum.Express.Tests.Main

open System
open Fable.Core
open Fable.Core.JsInterop
open Scriptorium.Nib.Assertion
open Glutinum

open type Scriptorium.Quill.Runner
open type Scriptorium.Quill.Test

[<Emit("fetch($0, $1).then(async response => ({ status: response.status, text: await response.text() }))")>]
let private fetch (url: string) (options: obj) : JS.Promise<{| status: int; text: string |}> =
    jsNative

/// An app of its own, on a free port, closed when the test ends
type private TestServer() =
    let server = App.create().listen 0

    member _.Url(path: string) =
        let port = (unbox<Node.net.AddressInfo> (server.address ())).port
        $"http://127.0.0.1:{int port}{path}"

    interface IDisposable with
        member _.Dispose() = server.close () |> ignore

let private get (server: TestServer) (path: string) =
    Async.AwaitPromise(fetch (server.Url path) (createObj []))

let private post (server: TestServer) (path: string) (body: obj) =
    Async.AwaitPromise(
        fetch
            (server.Url path)
            (createObj
                [
                    "method" ==> "POST"
                    "headers" ==> createObj [ "content-type" ==> "application/json" ]
                    "body" ==> JS.JSON.stringify body
                ])
    )

[<EntryPoint>]
let main _ =
    runTests
        [
            testList (
                "Glutinum.Express",
                [
                    testAsync (
                        "a route sends text",
                        fun _ ->
                            async {
                                use server = new TestServer()
                                let! response = get server "/"
                                assertThat response.status (isEqualTo 200)
                                assertThat response.text (isEqualTo "Hello from Fable")
                            }
                    )

                    testAsync (
                        "a route sends JSON",
                        fun _ ->
                            async {
                                use server = new TestServer()
                                let! response = get server "/users"

                                assertThat
                                    response.text
                                    (isEqualTo """[{"id":1,"name":"Ada"},{"id":2,"name":"Grace"}]""")
                            }
                    )

                    testAsync (
                        "a route parameter",
                        fun _ ->
                            async {
                                use server = new TestServer()
                                let! response = get server "/users/2"
                                assertThat response.text (isEqualTo """{"id":2,"name":"Grace"}""")
                            }
                    )

                    testAsync (
                        "a status code",
                        fun _ ->
                            async {
                                use server = new TestServer()
                                let! response = get server "/users/9"
                                assertThat response.status (isEqualTo 404)
                                assertThat response.text (isEqualTo """{"error":"no user 9"}""")
                            }
                    )

                    testAsync (
                        "a query string",
                        fun _ ->
                            async {
                                use server = new TestServer()
                                let! response = get server "/search?q=gr"
                                assertThat response.text (isEqualTo """["Grace"]""")
                            }
                    )

                    testAsync (
                        "a JSON body through the json middleware",
                        fun _ ->
                            async {
                                use server = new TestServer()

                                let! response =
                                    post server "/users" (createObj [ "name" ==> "Linus" ])

                                assertThat response.status (isEqualTo 201)
                                assertThat response.text (isEqualTo """{"id":3,"name":"Linus"}""")
                            }
                    )

                    testAsync (
                        "an unknown route is a 404",
                        fun _ ->
                            async {
                                use server = new TestServer()
                                let! response = get server "/nothing"
                                assertThat response.status (isEqualTo 404)
                            }
                    )
                ]
            )
        ]
