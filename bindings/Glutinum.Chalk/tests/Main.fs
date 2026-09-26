module Glutinum.Chalk.Tests.Main

open Fable.Core
open Fable.Core.JsInterop
open Scriptorium.Nib.Assertion
open Glutinum

open type Scriptorium.Quill.Runner
open type Scriptorium.Quill.Test

let private chalk = Chalk.Exports.chalk

let private esc = "\027"

[<EntryPoint>]
let main _ =
    // No terminal in CI, colors have to be forced
    chalk.level <- Chalk.ColorSupportLevel.``3``

    runTests
        [
            testList (
                "Glutinum.Chalk",
                [
                    test (
                        "red wraps the text in the ANSI code",
                        fun _ ->
                            assertThat
                                (chalk.red.Invoke "hello")
                                (isEqualTo $"{esc}[31mhello{esc}[39m")
                    )

                    test (
                        "styles chain",
                        fun _ ->
                            assertThat
                                (chalk.bold.red.Invoke "hello")
                                (isEqualTo $"{esc}[1m{esc}[31mhello{esc}[39m{esc}[22m")
                    )

                    test (
                        "the color names are listed",
                        fun _ ->
                            assertThat
                                (unbox<string[]> Chalk.Exports.foregroundColorNames
                                 |> Array.contains "red")
                                (isTrue)
                    )

                    test (
                        "hex gives a true color",
                        fun _ ->
                            assertThat
                                (chalk.hex("#FF8800").Invoke "hello")
                                (isEqualTo $"{esc}[38;2;255;136;0mhello{esc}[39m")
                    )

                    test (
                        "rgb is a delegate",
                        fun _ ->
                            assertThat
                                (chalk.rgb.Invoke(0, 128, 255).Invoke "hello")
                                (isEqualTo $"{esc}[38;2;0;128;255mhello{esc}[39m")
                    )

                    test (
                        "a background and a modifier",
                        fun _ ->
                            assertThat
                                (chalk.bgRed.underline.Invoke "hello")
                                (isEqualTo $"{esc}[41m{esc}[4mhello{esc}[24m{esc}[49m")
                    )

                    test (
                        "several arguments are joined",
                        fun _ ->
                            assertThat
                                (chalk.green.Invoke("a", "b"))
                                (isEqualTo $"{esc}[32ma b{esc}[39m")
                    )

                    test (
                        "level 0 leaves the text alone",
                        fun _ ->
                            let plain =
                                Chalk.Exports.Chalk.Create(
                                    Chalk.Options.Create(level = Chalk.ColorSupportLevel.``0``)
                                )

                            assertThat (plain.red.Invoke "hello") (isEqualTo "hello")
                    )
                ]
            )
        ]
