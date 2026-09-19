module Glutinum.Dayjs.Tests.Main

open Fable.Core
open Scriptorium.Nib.Assertion
open Glutinum

open type Scriptorium.Quill.Runner
open type Scriptorium.Quill.Test

type Dayjs = Dayjs.Exports

let private day (text: string) = Dayjs.dayjs text

let private today = day "2026-09-17"

[<EntryPoint>]
let main _ =
    runTests
        [
            testList (
                "Glutinum.Dayjs",
                [
                    test (
                        "format",
                        fun _ -> assertThat (today.format "YYYY-MM-DD") (isEqualTo "2026-09-17")
                    )

                    test (
                        "add with a typed unit",
                        fun _ ->
                            assertThat
                                (today.add(10, Glutinum.Dayjs.dayjs_.ManipulateType.day).format
                                    "YYYY-MM-DD")
                                (isEqualTo "2026-09-27")
                    )

                    test ("isBefore", (fun _ -> assertThat (today.isBefore "2027-01-01") (isTrue)))

                    test (
                        "startOf month",
                        fun _ ->
                            assertThat
                                (today.startOf(Glutinum.Dayjs.dayjs_.OpUnitType.month).format
                                    "YYYY-MM-DD")
                                (isEqualTo "2026-09-01")
                    )

                    test (
                        "diff in days",
                        fun _ ->
                            let christmas = day "2026-12-25"

                            assertThat
                                (christmas.diff (today, Glutinum.Dayjs.dayjs_.OpUnitType.day))
                                (isEqualTo 99)
                    )

                    test (
                        "isSame with a unit",
                        fun _ ->
                            let sameMonth = day "2026-09-01"

                            assertThat
                                (today.isSame (sameMonth, Glutinum.Dayjs.dayjs_.OpUnitType.month))
                                (isTrue)

                            assertThat
                                (today.isSame (sameMonth, Glutinum.Dayjs.dayjs_.OpUnitType.day))
                                (isFalse)
                    )

                    test (
                        "daysInMonth",
                        fun _ -> assertThat (today.daysInMonth ()) (isEqualTo 30)
                    )

                    test ("year", (fun _ -> assertThat (today.year ()) (isEqualTo 2026)))

                    test (
                        "an invalid date is detected",
                        fun _ -> assertThat ((day "not a date").isValid ()) (isFalse)
                    )

                    test (
                        "toDate gives a JS date",
                        fun _ -> assertThat (today.toDate().getFullYear ()) (isEqualTo 2026)
                    )
                ]
            )
        ]
