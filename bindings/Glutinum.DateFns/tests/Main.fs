module Glutinum.DateFns.Tests.Main

open Fable.Core
open Fable.Core.JsInterop
open Scriptorium.Nib.Assertion
open Glutinum
open Glutinum.Types.TypeScript
open type Glutinum.Types.TypeScript.Exports

open type Scriptorium.Quill.Runner
open type Scriptorium.Quill.Test

type DateFns = DateFns.Exports
type Locales = DateFns.locale.Exports

let private today = Date.Create(2026, 8, 17)

[<EntryPoint>]
let main _ =
    runTests
        [
            testList (
                "Glutinum.DateFns",
                [
                    test (
                        "addDays and format",
                        fun _ ->
                            let inTenDays: Date = DateFns.addDays (today, 10)

                            assertThat
                                (DateFns.format (inTenDays, "yyyy-MM-dd"))
                                (isEqualTo "2026-09-27")
                    )

                    test (
                        "format with a locale of date-fns/locale",
                        fun _ ->
                            let options =
                                jsOptions<DateFns.format.FormatOptions> (fun options ->
                                    options.locale <- Some(box Locales.fr)
                                )

                            assertThat
                                (DateFns.format (today, "PPPP", options))
                                (isEqualTo "jeudi 17 septembre 2026")
                    )

                    test ("isWeekend", (fun _ -> assertThat (DateFns.isWeekend today) (isFalse)))

                    test (
                        "differenceInDays",
                        fun _ ->
                            let later = Date.Create(2026, 11, 25)
                            assertThat (DateFns.differenceInDays (later, today)) (isEqualTo 99)
                    )

                    test (
                        "parse gives back the date",
                        fun _ ->
                            let parsed: Date = DateFns.parse ("2026-09-17", "yyyy-MM-dd", today)
                            assertThat (DateFns.isSameDay (parsed, today)) (isTrue)
                            assertThat (DateFns.isValid parsed) (isTrue)
                    )

                    test (
                        "an invalid date is detected",
                        fun _ ->
                            let parsed: Date = DateFns.parse ("not a date", "yyyy-MM-dd", today)
                            assertThat (DateFns.isValid parsed) (isFalse)
                    )

                    test (
                        "startOfMonth",
                        fun _ ->
                            let start: Date = DateFns.startOfMonth today

                            assertThat
                                (DateFns.format (start, "yyyy-MM-dd"))
                                (isEqualTo "2026-09-01")
                    )

                    test (
                        "eachDayOfInterval lists the days",
                        fun _ ->
                            let interval =
                                createObj [ "start" ==> today; "end" ==> Date.Create(2026, 8, 20) ]

                            let days = DateFns.eachDayOfInterval interval
                            assertThat days.Count (isEqualTo 4)

                            assertThat
                                (DateFns.format (days.[3], "yyyy-MM-dd"))
                                (isEqualTo "2026-09-20")
                    )

                    test (
                        "formatDistance in German",
                        fun _ ->
                            let options =
                                jsOptions<DateFns.formatDistance.FormatDistanceOptions> (fun options ->
                                    options.locale <- Some(box DateFns.locale_de.Exports.de)
                                )

                            let inTenDays: Date = DateFns.addDays (today, 10)

                            assertThat
                                (DateFns.formatDistance (inTenDays, today, options))
                                (isEqualTo "10 Tage")
                    )

                    test (
                        "compareAsc orders dates",
                        fun _ ->
                            let later = Date.Create(2026, 8, 18)
                            assertThat (DateFns.compareAsc (today, later)) (isEqualTo -1)
                            assertThat (DateFns.compareAsc (later, today)) (isEqualTo 1)
                    )
                ]
            )
        ]
