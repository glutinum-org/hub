module Glutinum.Animejs.Tests.Main

open Fable.Core
open Fable.Core.JsInterop
open Scriptorium.Nib.Assertion
open Glutinum

open type Scriptorium.Quill.Runner
open type Scriptorium.Quill.Test

type Helpers = Animejs.Exports
type Registry = Animejs.adapters.Exports
type Anime = Animejs.Exports
type StaggerParams = Animejs.StaggerParams

[<EntryPoint>]
let main _ =
    runTests
        [
            testList (
                "Glutinum.Animejs",
                [
                    test (
                        "clamp keeps the value inside the range",
                        fun _ ->
                            assertThat (Helpers.clamp (12., 0., 10.)) (isEqualTo 10.)
                            assertThat (Helpers.clamp (-3., 0., 10.)) (isEqualTo 0.)
                    )

                    test (
                        "round keeps the asked decimals",
                        fun _ -> assertThat (Helpers.round (1.2345, 2.)) (isEqualTo 1.23)
                    )

                    test (
                        "snap rounds to the increment",
                        fun _ -> assertThat (Helpers.snap (12., 5.)) (isEqualTo 10.)
                    )

                    test (
                        "lerp interpolates between the bounds",
                        fun _ -> assertThat (Helpers.lerp (0., 10., 0.5)) (isEqualTo 5.)
                    )

                    // The declaration is re-exported by the `./adapters` subpath and not by the
                    // package root, so it is imported from `animejs/adapters`
                    test (
                        "a declaration of a subpath is imported from it",
                        fun _ ->
                            assertThat (jsTypeof Registry.registerAdapter) (isEqualTo "function")
                    )

                    test (
                        "the factory of an object literal type alias builds the parameters",
                        fun _ ->
                            let parameters = StaggerParams.Create(start = !^ 100., total = 3.)

                            assertThat (parameters?start) (isEqualTo 100.)
                            assertThat (parameters?total) (isEqualTo 3.)

                            assertThat
                                (jsTypeof (Anime.stagger (10., parameters)))
                                (isEqualTo "function")
                    )
                ]
            )
        ]
