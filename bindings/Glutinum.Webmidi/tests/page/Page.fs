module Glutinum.Webmidi.Tests.Page

open Fable.Core
open Glutinum.Webmidi

open type Glutinum.Web.Exports

// The page exercises the binding in a real browser, the tests read the results in the DOM
let private report (id: string) (text: string) =
    let element = document.createElement "p"
    element.id <- id
    element.textContent <- text
    document.body.appendChild element |> ignore

let midi = Exports.WebMidi

// The library reports whether the browser has the Web MIDI API before anything is enabled
report "supported" $"{midi.supported}"
report "enabled-before" $"{midi.enabled}"

// Notes are parsed from their identifier
let note = Exports.Note("C#4", Exports.Note.options (duration = 500.0))
report "note" $"{note.name}{note.accidental} {note.identifier} {note.duration}"

// Utilities are static members of the class
let number = Utilities.toNoteNumber "A4"
let identifier = Utilities.toNoteIdentifier (60.0, 0.0)
report "utilities" $"{number} {identifier}"

// A raw MIDI message is decoded into its command, channel and data bytes
let message = Exports.Message(JS.Constructors.Uint8Array.Create [| 0x90; 60; 100 |])

report
    "message"
    $"{message.command} {message.channel} {message.dataBytes.[0]} {message.dataBytes.[1]}"

// Enabling asks the browser for MIDI access, the page reports the outcome either way.
// The Chromium of Playwright has no `navigator.requestMIDIAccess`
if midi.supported then
    midi.enable ()
    |> Promise.map (fun enabled ->
        report
            "enable"
            $"enabled {enabled.enabled} inputs {enabled.inputs.Count} outputs {enabled.outputs.Count}"
    )
    |> Promise.catch (fun error -> report "enable" $"error {error.Message}")
    |> ignore
else
    report "enable" "unsupported"
