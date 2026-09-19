module Glutinum.Playwright.Tests.Main

open Fable.Core
open Scriptorium.Nib.Assertion
open Glutinum

open type Scriptorium.Quill.Runner
open type Scriptorium.Quill.Test

let private content =
    """<title>Fable</title>
<h1>Hello from Playwright</h1>
<input id="name" />
<button id="greet" onclick="document.getElementById('out').textContent = 'Hi ' + document.getElementById('name').value">Greet</button>
<p id="out"></p>
<ul><li>a</li><li>b</li><li>c</li></ul>"""

let private withPage (test: PlaywrightCore.Page -> Async<unit>) =
    async {
        let! browser = Async.AwaitPromise(Playwright.Exports.chromium.launch ())
        let! page = Async.AwaitPromise(browser.newPage ())
        do! Async.AwaitPromise(page.setContent content)

        try
            do! test page
        finally
            browser.close () |> ignore
    }

[<EntryPoint>]
let main _ =
    runTests
        [
            testList (
                "Glutinum.Playwright",
                [
                    testAsync (
                        "Chromium opens a page",
                        fun _ ->
                            withPage (fun page ->
                                async {
                                    let! title = Async.AwaitPromise(page.title ())
                                    let! heading = Async.AwaitPromise(page.textContent "h1")
                                    assertThat title (isEqualTo "Fable")
                                    assertThat heading (isEqualTo (Some "Hello from Playwright"))
                                }
                            )
                    )

                    testAsync (
                        "fill, click and read the result",
                        fun _ ->
                            withPage (fun page ->
                                async {
                                    do! Async.AwaitPromise(page.fill ("#name", "Fable"))
                                    let! value = Async.AwaitPromise(page.inputValue "#name")
                                    do! Async.AwaitPromise(page.click "#greet")
                                    let! out = Async.AwaitPromise(page.innerText "#out")
                                    assertThat value (isEqualTo "Fable")
                                    assertThat out (isEqualTo "Hi Fable")
                                }
                            )
                    )

                    testAsync (
                        "a locator counts and indexes elements",
                        fun _ ->
                            withPage (fun page ->
                                async {
                                    let items = page.locator "li"
                                    let! count = Async.AwaitPromise(items.count ())
                                    let! second = Async.AwaitPromise(items.nth(1).textContent ())
                                    assertThat count (isEqualTo 3)
                                    assertThat second (isEqualTo (Some "b"))
                                }
                            )
                    )
                ]
            )
        ]
