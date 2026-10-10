namespace rec Glutinum

open Fable.Core
open Fable.Core.JsInterop
open System

// You need to add Glutinum.Web NuGet package to your project

module Webmidi =

    [<AbstractClass>]
    [<Erase>]
    type Exports =
        [<Import("WebMidi", "webmidi")>]
        static member inline WebMidi: Webmidi.WebMidi = nativeOnly
        /// <summary>
        /// Creates a new <c>EventEmitter</c>object.
        /// </summary>
        /// <param name="eventsSuspended">
        /// Whether the <c>EventEmitter</c> is initially in a suspended
        /// state (i.e. not executing callbacks).
        /// </param>
        [<Import("EventEmitter", "webmidi"); EmitConstructor>]
        static member EventEmitter (?eventsSuspended: bool) : EventEmitter = nativeOnly
        /// <summary>
        /// Creates a new <c>Listener</c> object
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// The <c>event</c> parameter must be a string or
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>.
        ///
        /// The <c>target</c> parameter is mandatory.
        ///
        /// The <c>callback</c> must be a function.
        /// </remarks>
        /// <param name="event">
        /// The event being listened to
        /// </param>
        /// <param name="target">
        /// The [<c>EventEmitter</c>]<see href="EventEmitter">EventEmitter</see> object that the listener
        /// is attached to.
        /// </param>
        /// <param name="callback">
        /// The function to call when the listener is triggered
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        [<Import("Listener", "webmidi"); EmitConstructor>]
        static member Listener (event: string, target: Webmidi.EventEmitter, callback: Webmidi.EventEmitterCallback, options: Exports.Listener.options, [<ParamArray>] args: obj []) : Listener = nativeOnly
        /// <summary>
        /// Creates a new <c>Listener</c> object
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// The <c>event</c> parameter must be a string or
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>.
        ///
        /// The <c>target</c> parameter is mandatory.
        ///
        /// The <c>callback</c> must be a function.
        /// </remarks>
        /// <param name="event">
        /// The event being listened to
        /// </param>
        /// <param name="target">
        /// The [<c>EventEmitter</c>]<see href="EventEmitter">EventEmitter</see> object that the listener
        /// is attached to.
        /// </param>
        /// <param name="callback">
        /// The function to call when the listener is triggered
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        [<Import("Listener", "webmidi"); EmitConstructor>]
        static member Listener (event: obj, target: Webmidi.EventEmitter, callback: Webmidi.EventEmitterCallback, options: Exports.Listener.options, [<ParamArray>] args: obj []) : Listener = nativeOnly
        /// <summary>
        /// Creates a new <c>Listener</c> object
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// The <c>event</c> parameter must be a string or
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>.
        ///
        /// The <c>target</c> parameter is mandatory.
        ///
        /// The <c>callback</c> must be a function.
        /// </remarks>
        /// <param name="event">
        /// The event being listened to
        /// </param>
        /// <param name="target">
        /// The [<c>EventEmitter</c>]<see href="EventEmitter">EventEmitter</see> object that the listener
        /// is attached to.
        /// </param>
        /// <param name="callback">
        /// The function to call when the listener is triggered
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        [<Import("Listener", "webmidi"); EmitConstructor>]
        static member Listener (event: U2<string, obj>, target: Webmidi.EventEmitter, callback: Webmidi.EventEmitterCallback, options: Exports.Listener.options, [<ParamArray>] args: obj []) : Listener = nativeOnly
        [<Import("Enumerations", "webmidi"); EmitConstructor>]
        static member Enumerations () : Enumerations = nativeOnly
        /// <summary>
        /// Creates a <c>Forwarder</c> object.
        /// </summary>
        /// <param name="destinations">
        /// \[\]] An [<c>Output</c>](Output) object, or an array of such
        /// objects, to forward the message to.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        [<Import("Forwarder", "webmidi"); EmitConstructor>]
        static member Forwarder () : Forwarder = nativeOnly
        /// <summary>
        /// Creates a <c>Forwarder</c> object.
        /// </summary>
        /// <param name="destinations">
        /// \[\]] An [<c>Output</c>](Output) object, or an array of such
        /// objects, to forward the message to.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        [<Import("Forwarder", "webmidi"); EmitConstructor>]
        static member Forwarder (destinations: Webmidi.Output, ?options: Exports.Forwarder.options) : Forwarder = nativeOnly
        /// <summary>
        /// Creates a <c>Forwarder</c> object.
        /// </summary>
        /// <param name="destinations">
        /// \[\]] An [<c>Output</c>](Output) object, or an array of such
        /// objects, to forward the message to.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        [<Import("Forwarder", "webmidi"); EmitConstructor>]
        static member Forwarder (destinations: ResizeArray<Webmidi.Output>, ?options: Exports.Forwarder.options) : Forwarder = nativeOnly
        /// <summary>
        /// Creates an <c>Input</c> object.
        /// </summary>
        /// <param name="midiInput">
        /// [<c>MIDIInput</c>](https://developer.mozilla.org/en-US/docs/Web/API/MIDIInput)
        /// object as provided by the MIDI subsystem (Web MIDI API).
        /// </param>
        [<Import("Input", "webmidi"); EmitConstructor>]
        static member Input (midiInput: Webmidi.WebMidiApi_.MIDIInput) : Input = nativeOnly
        /// <summary>
        /// Creates an <c>InputChannel</c> object.
        /// </summary>
        /// <param name="input">
        /// The [<c>Input</c>](Input) object this channel belongs to.
        /// </param>
        /// <param name="number">
        /// The channel's MIDI number (1-16).
        /// </param>
        [<Import("InputChannel", "webmidi"); EmitConstructor>]
        static member InputChannel (input: Webmidi.Input, number: float) : InputChannel = nativeOnly
        /// <summary>
        /// Creates a new <c>Message</c> object from raw MIDI data.
        /// </summary>
        /// <param name="data">
        /// The raw data of the MIDI message as a
        /// [<c>Uint8Array</c>](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Uint8Array)
        /// of integers between <c>0</c> and <c>255</c>.
        /// </param>
        [<Import("Message", "webmidi"); EmitConstructor>]
        static member Message (data: JS.Uint8Array) : Message = nativeOnly
        /// <summary>
        /// Creates a <c>Note</c> object.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// Invalid note identifier
        ///
        /// Invalid name value
        ///
        /// Invalid accidental value
        ///
        /// Invalid octave value
        ///
        /// Invalid duration value
        ///
        /// Invalid attack value
        ///
        /// Invalid release value
        /// </remarks>
        /// <param name="value">
        /// The value used to create the note. If an identifier string is used,
        /// it must start with the note letter, optionally followed by an accidental and followed by the
        /// octave number (<c>"C3"</c>, <c>"G#4"</c>, <c>"F-1"</c>, <c>"Db7"</c>, etc.). If a number is used, it must be an
        /// integer between 0 and 127. In this case, middle C is considered to be C4 (note number 60).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        [<Import("Note", "webmidi"); EmitConstructor>]
        static member Note (value: string, ?options: Exports.Note.options) : Note = nativeOnly
        /// <summary>
        /// Creates a <c>Note</c> object.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// Invalid note identifier
        ///
        /// Invalid name value
        ///
        /// Invalid accidental value
        ///
        /// Invalid octave value
        ///
        /// Invalid duration value
        ///
        /// Invalid attack value
        ///
        /// Invalid release value
        /// </remarks>
        /// <param name="value">
        /// The value used to create the note. If an identifier string is used,
        /// it must start with the note letter, optionally followed by an accidental and followed by the
        /// octave number (<c>"C3"</c>, <c>"G#4"</c>, <c>"F-1"</c>, <c>"Db7"</c>, etc.). If a number is used, it must be an
        /// integer between 0 and 127. In this case, middle C is considered to be C4 (note number 60).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        [<Import("Note", "webmidi"); EmitConstructor>]
        static member Note (value: float, ?options: Exports.Note.options) : Note = nativeOnly
        /// <summary>
        /// Creates a <c>Note</c> object.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// Invalid note identifier
        ///
        /// Invalid name value
        ///
        /// Invalid accidental value
        ///
        /// Invalid octave value
        ///
        /// Invalid duration value
        ///
        /// Invalid attack value
        ///
        /// Invalid release value
        /// </remarks>
        /// <param name="value">
        /// The value used to create the note. If an identifier string is used,
        /// it must start with the note letter, optionally followed by an accidental and followed by the
        /// octave number (<c>"C3"</c>, <c>"G#4"</c>, <c>"F-1"</c>, <c>"Db7"</c>, etc.). If a number is used, it must be an
        /// integer between 0 and 127. In this case, middle C is considered to be C4 (note number 60).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        [<Import("Note", "webmidi"); EmitConstructor>]
        static member Note (value: U2<string, float>, ?options: Exports.Note.options) : Note = nativeOnly
        /// <summary>
        /// Creates an <c>Output</c> object.
        /// </summary>
        /// <param name="midiOutput">
        /// [<c>MIDIOutput</c>](https://developer.mozilla.org/en-US/docs/Web/API/MIDIOutput)
        /// object as provided by the MIDI subsystem.
        /// </param>
        [<Import("Output", "webmidi"); EmitConstructor>]
        static member Output (midiOutput: Webmidi.WebMidiApi_.MIDIOutput) : Output = nativeOnly
        /// <summary>
        /// Creates an <c>OutputChannel</c> object.
        /// </summary>
        /// <param name="output">
        /// The [<c>Output</c>](Output) this channel belongs to.
        /// </param>
        /// <param name="number">
        /// The MIDI channel number (<c>1</c> - <c>16</c>).
        /// </param>
        [<Import("OutputChannel", "webmidi"); EmitConstructor>]
        static member OutputChannel (output: Webmidi.Output, number: float) : OutputChannel = nativeOnly
        [<Import("Utilities", "webmidi"); EmitConstructor>]
        static member Utilities () : Utilities = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type Navigator =
        /// <summary>
        /// When invoked, returns a Promise object representing a request for access to MIDI devices on the
        /// user's system.
        /// </summary>
        abstract member requestMIDIAccess: ?options: Webmidi.WebMidiApi_.MIDIOptions -> JS.Promise<Webmidi.WebMidiApi_.MIDIAccess>

    module WebMidiApi_ =

        [<AllowNullLiteral>]
        [<Interface>]
        type MIDIOptions =
            /// <summary>
            /// This member informs the system whether the ability to send and receive system
            /// exclusive messages is requested or allowed on a given MIDIAccess object.
            /// </summary>
            abstract member sysex: bool with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (sysex: bool) : MIDIOptions = nativeOnly

        /// <summary>
        /// This is a maplike interface whose value is a MIDIInput instance and key is its
        /// ID.
        /// </summary>
        type MIDIInputMap =
            obj

        /// <summary>
        /// This is a maplike interface whose value is a MIDIOutput instance and key is its
        /// ID.
        /// </summary>
        type MIDIOutputMap =
            obj

        [<AllowNullLiteral>]
        [<Interface>]
        type MIDIAccess =
            inherit Glutinum.Web.EventTarget
            /// <summary>
            /// The MIDI input ports available to the system.
            /// </summary>
            abstract member inputs: Webmidi.WebMidiApi_.MIDIInputMap with get, set
            /// <summary>
            /// The MIDI output ports available to the system.
            /// </summary>
            abstract member outputs: Webmidi.WebMidiApi_.MIDIOutputMap with get, set
            /// <summary>
            /// The handler called when a new port is connected or an existing port changes the
            /// state attribute.
            /// </summary>
            abstract member onstatechange: e: Webmidi.WebMidiApi_.MIDIConnectionEvent -> unit
            /// <summary>
            /// The **<c>addEventListener()</c>** method of the EventTarget interface sets up a function that will be called whenever the specified event is delivered to the target.
            ///
            /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/EventTarget/addEventListener)
            /// </summary>
            [<Emit("$0.addEventListener('statechange',$1...)")>]
            abstract member addEventListener_statechange: listener: (Webmidi.WebMidiApi_.MIDIConnectionEvent -> unit) -> unit
            /// <summary>
            /// The **<c>addEventListener()</c>** method of the EventTarget interface sets up a function that will be called whenever the specified event is delivered to the target.
            ///
            /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/EventTarget/addEventListener)
            /// </summary>
            [<Emit("$0.addEventListener('statechange',$1...)")>]
            abstract member addEventListener_statechange: listener: (Webmidi.WebMidiApi_.MIDIConnectionEvent -> unit) * options: bool -> unit
            /// <summary>
            /// The **<c>addEventListener()</c>** method of the EventTarget interface sets up a function that will be called whenever the specified event is delivered to the target.
            ///
            /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/EventTarget/addEventListener)
            /// </summary>
            [<Emit("$0.addEventListener('statechange',$1...)")>]
            abstract member addEventListener_statechange: listener: (Webmidi.WebMidiApi_.MIDIConnectionEvent -> unit) * options: Glutinum.Web.AddEventListenerOptions -> unit
            /// <summary>
            /// The **<c>addEventListener()</c>** method of the EventTarget interface sets up a function that will be called whenever the specified event is delivered to the target.
            ///
            /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/EventTarget/addEventListener)
            /// </summary>
            abstract member addEventListener: ``type``: string * listener: Glutinum.Web.EventListenerOrEventListenerObject -> unit
            /// <summary>
            /// The **<c>addEventListener()</c>** method of the EventTarget interface sets up a function that will be called whenever the specified event is delivered to the target.
            ///
            /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/EventTarget/addEventListener)
            /// </summary>
            abstract member addEventListener: ``type``: string * listener: Glutinum.Web.EventListenerOrEventListenerObject * options: bool -> unit
            /// <summary>
            /// The **<c>addEventListener()</c>** method of the EventTarget interface sets up a function that will be called whenever the specified event is delivered to the target.
            ///
            /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/EventTarget/addEventListener)
            /// </summary>
            abstract member addEventListener: ``type``: string * listener: Glutinum.Web.EventListenerOrEventListenerObject * options: Glutinum.Web.AddEventListenerOptions -> unit
            /// <summary>
            /// This attribute informs the user whether system exclusive support is enabled on
            /// this MIDIAccess.
            /// </summary>
            abstract member sysexEnabled: bool with get, set

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type MIDIPortType =
            | input
            | output

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type MIDIPortDeviceState =
            | disconnected
            | connected

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type MIDIPortConnectionState =
            | ``open``
            | closed
            | pending

        [<AllowNullLiteral>]
        [<Interface>]
        type MIDIPort =
            inherit Glutinum.Web.EventTarget
            /// <summary>
            /// A unique ID of the port. This can be used by developers to remember ports the
            /// user has chosen for their application.
            /// </summary>
            abstract member id: string with get, set
            /// <summary>
            /// The manufacturer of the port.
            /// </summary>
            abstract member manufacturer: string option with get, set
            /// <summary>
            /// The system name of the port.
            /// </summary>
            abstract member name: string option with get, set
            /// <summary>
            /// A descriptor property to distinguish whether the port is an input or an output
            /// port.
            /// </summary>
            abstract member ``type``: Webmidi.WebMidiApi_.MIDIPortType with get, set
            /// <summary>
            /// The version of the port.
            /// </summary>
            abstract member version: string option with get, set
            /// <summary>
            /// The state of the device.
            /// </summary>
            abstract member state: Webmidi.WebMidiApi_.MIDIPortDeviceState with get, set
            /// <summary>
            /// The state of the connection to the device.
            /// </summary>
            abstract member connection: Webmidi.WebMidiApi_.MIDIPortConnectionState with get, set
            /// <summary>
            /// The handler called when an existing port changes its state or connection
            /// attributes.
            /// </summary>
            abstract member onstatechange: e: Webmidi.WebMidiApi_.MIDIConnectionEvent -> unit
            /// <summary>
            /// The **<c>addEventListener()</c>** method of the EventTarget interface sets up a function that will be called whenever the specified event is delivered to the target.
            ///
            /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/EventTarget/addEventListener)
            /// </summary>
            [<Emit("$0.addEventListener('statechange',$1...)")>]
            abstract member addEventListener_statechange: listener: (Webmidi.WebMidiApi_.MIDIConnectionEvent -> unit) -> unit
            /// <summary>
            /// The **<c>addEventListener()</c>** method of the EventTarget interface sets up a function that will be called whenever the specified event is delivered to the target.
            ///
            /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/EventTarget/addEventListener)
            /// </summary>
            [<Emit("$0.addEventListener('statechange',$1...)")>]
            abstract member addEventListener_statechange: listener: (Webmidi.WebMidiApi_.MIDIConnectionEvent -> unit) * options: bool -> unit
            /// <summary>
            /// The **<c>addEventListener()</c>** method of the EventTarget interface sets up a function that will be called whenever the specified event is delivered to the target.
            ///
            /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/EventTarget/addEventListener)
            /// </summary>
            [<Emit("$0.addEventListener('statechange',$1...)")>]
            abstract member addEventListener_statechange: listener: (Webmidi.WebMidiApi_.MIDIConnectionEvent -> unit) * options: Glutinum.Web.AddEventListenerOptions -> unit
            /// <summary>
            /// The **<c>addEventListener()</c>** method of the EventTarget interface sets up a function that will be called whenever the specified event is delivered to the target.
            ///
            /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/EventTarget/addEventListener)
            /// </summary>
            abstract member addEventListener: ``type``: string * listener: Glutinum.Web.EventListenerOrEventListenerObject -> unit
            /// <summary>
            /// The **<c>addEventListener()</c>** method of the EventTarget interface sets up a function that will be called whenever the specified event is delivered to the target.
            ///
            /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/EventTarget/addEventListener)
            /// </summary>
            abstract member addEventListener: ``type``: string * listener: Glutinum.Web.EventListenerOrEventListenerObject * options: bool -> unit
            /// <summary>
            /// The **<c>addEventListener()</c>** method of the EventTarget interface sets up a function that will be called whenever the specified event is delivered to the target.
            ///
            /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/EventTarget/addEventListener)
            /// </summary>
            abstract member addEventListener: ``type``: string * listener: Glutinum.Web.EventListenerOrEventListenerObject * options: Glutinum.Web.AddEventListenerOptions -> unit
            /// <summary>
            /// Makes the MIDI device corresponding to the MIDIPort explicitly available. Note
            /// that this call is NOT required in order to use the MIDIPort - calling send() on
            /// a MIDIOutput or attaching a MIDIMessageEvent handler on a MIDIInputPort will
            /// cause an implicit open().
            ///
            /// When invoked, this method returns a Promise object representing a request for
            /// access to the given MIDI port on the user's system.
            /// </summary>
            abstract member ``open``: unit -> JS.Promise<Webmidi.WebMidiApi_.MIDIPort>
            /// <summary>
            /// Makes the MIDI device corresponding to the MIDIPort
            /// explicitly unavailable (subsequently changing the state from "open" to
            /// "connected"). Note that successful invocation of this method will result in MIDI
            /// messages no longer being delivered to MIDIMessageEvent handlers on a
            /// MIDIInputPort (although setting a new handler will cause an implicit open()).
            ///
            /// When invoked, this method returns a Promise object representing a request for
            /// access to the given MIDI port on the user's system. When the port has been
            /// closed (and therefore, in exclusive access systems, the port is available to
            /// other applications), the vended Promise is resolved. If the port is
            /// disconnected, the Promise is rejected.
            /// </summary>
            abstract member close: unit -> JS.Promise<Webmidi.WebMidiApi_.MIDIPort>

        [<AllowNullLiteral>]
        [<Interface>]
        type MIDIInput =
            inherit Webmidi.WebMidiApi_.MIDIPort
            /// <summary>
            /// A descriptor property to distinguish whether the port is an input or an output
            /// port.
            /// </summary>
            abstract member ``type``: string with get, set
            abstract member onmidimessage: e: Webmidi.WebMidiApi_.MIDIMessageEvent -> unit
            /// <summary>
            /// The **<c>addEventListener()</c>** method of the EventTarget interface sets up a function that will be called whenever the specified event is delivered to the target.
            ///
            /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/EventTarget/addEventListener)
            /// </summary>
            [<Emit("$0.addEventListener('midimessage',$1...)")>]
            abstract member addEventListener_midimessage: listener: (Webmidi.WebMidiApi_.MIDIMessageEvent -> unit) -> unit
            /// <summary>
            /// The **<c>addEventListener()</c>** method of the EventTarget interface sets up a function that will be called whenever the specified event is delivered to the target.
            ///
            /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/EventTarget/addEventListener)
            /// </summary>
            [<Emit("$0.addEventListener('midimessage',$1...)")>]
            abstract member addEventListener_midimessage: listener: (Webmidi.WebMidiApi_.MIDIMessageEvent -> unit) * options: bool -> unit
            /// <summary>
            /// The **<c>addEventListener()</c>** method of the EventTarget interface sets up a function that will be called whenever the specified event is delivered to the target.
            ///
            /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/EventTarget/addEventListener)
            /// </summary>
            [<Emit("$0.addEventListener('midimessage',$1...)")>]
            abstract member addEventListener_midimessage: listener: (Webmidi.WebMidiApi_.MIDIMessageEvent -> unit) * options: Glutinum.Web.AddEventListenerOptions -> unit
            /// <summary>
            /// The **<c>addEventListener()</c>** method of the EventTarget interface sets up a function that will be called whenever the specified event is delivered to the target.
            ///
            /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/EventTarget/addEventListener)
            /// </summary>
            [<Emit("$0.addEventListener('statechange',$1...)")>]
            abstract member addEventListener_statechange: listener: (Webmidi.WebMidiApi_.MIDIConnectionEvent -> unit) -> unit
            /// <summary>
            /// The **<c>addEventListener()</c>** method of the EventTarget interface sets up a function that will be called whenever the specified event is delivered to the target.
            ///
            /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/EventTarget/addEventListener)
            /// </summary>
            [<Emit("$0.addEventListener('statechange',$1...)")>]
            abstract member addEventListener_statechange: listener: (Webmidi.WebMidiApi_.MIDIConnectionEvent -> unit) * options: bool -> unit
            /// <summary>
            /// The **<c>addEventListener()</c>** method of the EventTarget interface sets up a function that will be called whenever the specified event is delivered to the target.
            ///
            /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/EventTarget/addEventListener)
            /// </summary>
            [<Emit("$0.addEventListener('statechange',$1...)")>]
            abstract member addEventListener_statechange: listener: (Webmidi.WebMidiApi_.MIDIConnectionEvent -> unit) * options: Glutinum.Web.AddEventListenerOptions -> unit
            /// <summary>
            /// The **<c>addEventListener()</c>** method of the EventTarget interface sets up a function that will be called whenever the specified event is delivered to the target.
            ///
            /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/EventTarget/addEventListener)
            /// </summary>
            abstract member addEventListener: ``type``: string * listener: Glutinum.Web.EventListenerOrEventListenerObject -> unit
            /// <summary>
            /// The **<c>addEventListener()</c>** method of the EventTarget interface sets up a function that will be called whenever the specified event is delivered to the target.
            ///
            /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/EventTarget/addEventListener)
            /// </summary>
            abstract member addEventListener: ``type``: string * listener: Glutinum.Web.EventListenerOrEventListenerObject * options: bool -> unit
            /// <summary>
            /// The **<c>addEventListener()</c>** method of the EventTarget interface sets up a function that will be called whenever the specified event is delivered to the target.
            ///
            /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/EventTarget/addEventListener)
            /// </summary>
            abstract member addEventListener: ``type``: string * listener: Glutinum.Web.EventListenerOrEventListenerObject * options: Glutinum.Web.AddEventListenerOptions -> unit

        [<AllowNullLiteral>]
        [<Interface>]
        type MIDIOutput =
            inherit Webmidi.WebMidiApi_.MIDIPort
            /// <summary>
            /// A descriptor property to distinguish whether the port is an input or an output
            /// port.
            /// </summary>
            abstract member ``type``: string with get, set
            /// <summary>
            /// Enqueues the message to be sent to the corresponding MIDI port.
            /// </summary>
            /// <param name="data">
            /// The data to be enqueued, with each sequence entry representing a single byte of data.
            /// </param>
            /// <param name="timestamp">
            /// The time at which to begin sending the data to the port. If timestamp is set
            /// to zero (or another time in the past), the data is to be sent as soon as
            /// possible.
            /// </param>
            abstract member send: data: ResizeArray<float> * ?timestamp: float -> unit
            /// <summary>
            /// Enqueues the message to be sent to the corresponding MIDI port.
            /// </summary>
            /// <param name="data">
            /// The data to be enqueued, with each sequence entry representing a single byte of data.
            /// </param>
            /// <param name="timestamp">
            /// The time at which to begin sending the data to the port. If timestamp is set
            /// to zero (or another time in the past), the data is to be sent as soon as
            /// possible.
            /// </param>
            abstract member send: data: JS.Uint8Array * ?timestamp: float -> unit
            /// <summary>
            /// Enqueues the message to be sent to the corresponding MIDI port.
            /// </summary>
            /// <param name="data">
            /// The data to be enqueued, with each sequence entry representing a single byte of data.
            /// </param>
            /// <param name="timestamp">
            /// The time at which to begin sending the data to the port. If timestamp is set
            /// to zero (or another time in the past), the data is to be sent as soon as
            /// possible.
            /// </param>
            abstract member send: data: U2<ResizeArray<float>, JS.Uint8Array> * ?timestamp: float -> unit
            /// <summary>
            /// Clears any pending send data that has not yet been sent from the MIDIOutput 's
            /// queue. The implementation will need to ensure the MIDI stream is left in a good
            /// state, so if the output port is in the middle of a sysex message, a sysex
            /// termination byte (0xf7) should be sent.
            /// </summary>
            abstract member clear: unit -> unit

        [<AllowNullLiteral>]
        [<Interface>]
        type MIDIMessageEvent =
            inherit Webmidi.Event
            /// <summary>
            /// A timestamp specifying when the event occurred.
            /// </summary>
            abstract member receivedTime: float with get, set
            /// <summary>
            /// A Uint8Array containing the MIDI data bytes of a single MIDI message.
            /// </summary>
            abstract member data: JS.Uint8Array with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (target: Webmidi.Input, timestamp: Glutinum.Web.DOMHighResTimeStamp, ``type``: string, receivedTime: float, data: JS.Uint8Array) : MIDIMessageEvent = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (target: Webmidi.InputChannel, timestamp: Glutinum.Web.DOMHighResTimeStamp, ``type``: string, receivedTime: float, data: JS.Uint8Array) : MIDIMessageEvent = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (target: Webmidi.Output, timestamp: Glutinum.Web.DOMHighResTimeStamp, ``type``: string, receivedTime: float, data: JS.Uint8Array) : MIDIMessageEvent = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (target: Webmidi.WebMidi, timestamp: Glutinum.Web.DOMHighResTimeStamp, ``type``: string, receivedTime: float, data: JS.Uint8Array) : MIDIMessageEvent = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type MIDIMessageEventInit =
            inherit Glutinum.Web.EventInit
            /// <summary>
            /// A timestamp specifying when the event occurred.
            /// </summary>
            abstract member receivedTime: float with get, set
            /// <summary>
            /// A Uint8Array containing the MIDI data bytes of a single MIDI message.
            /// </summary>
            abstract member data: JS.Uint8Array with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (receivedTime: float, data: JS.Uint8Array, ?bubbles: bool, ?cancelable: bool, ?composed: bool) : MIDIMessageEventInit = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type MIDIConnectionEvent =
            inherit Webmidi.Event
            /// <summary>
            /// The port that has been connected or disconnected.
            /// </summary>
            abstract member port: Webmidi.WebMidiApi_.MIDIPort with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (target: Webmidi.Input, timestamp: Glutinum.Web.DOMHighResTimeStamp, ``type``: string, port: Webmidi.WebMidiApi_.MIDIPort) : MIDIConnectionEvent = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (target: Webmidi.InputChannel, timestamp: Glutinum.Web.DOMHighResTimeStamp, ``type``: string, port: Webmidi.WebMidiApi_.MIDIPort) : MIDIConnectionEvent = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (target: Webmidi.Output, timestamp: Glutinum.Web.DOMHighResTimeStamp, ``type``: string, port: Webmidi.WebMidiApi_.MIDIPort) : MIDIConnectionEvent = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (target: Webmidi.WebMidi, timestamp: Glutinum.Web.DOMHighResTimeStamp, ``type``: string, port: Webmidi.WebMidiApi_.MIDIPort) : MIDIConnectionEvent = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type MIDIConnectionEventInit =
            inherit Glutinum.Web.EventInit
            /// <summary>
            /// The port that has been connected or disconnected.
            /// </summary>
            abstract member port: Webmidi.WebMidiApi_.MIDIPort with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (port: Webmidi.WebMidiApi_.MIDIPort, ?bubbles: bool, ?cancelable: bool, ?composed: bool) : MIDIConnectionEventInit = nativeOnly

    /// <summary>
    /// The <c>EventEmitter</c> class provides methods to implement the _observable_ design pattern. This
    /// pattern allows one to _register_ a function to execute when a specific event is _emitted_ by the
    /// emitter.
    ///
    /// It is intended to be an abstract class meant to be extended by (or mixed into) other objects.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("EventEmitter", "webmidi")>]
    type EventEmitter =
        /// <summary>
        /// Identifier (Symbol) to use when adding or removing a listener that should be triggered when any
        /// events occur.
        /// </summary>
        static member inline ANY_EVENT
            with get () : obj =
                nativeOnly
        /// <summary>
        /// An object containing a property for each event with at least one registered listener. Each
        /// event property contains an array of all the [<c>Listener</c>]<see href="Listener">Listener</see> objects registered
        /// for the event.
        /// </summary>
        abstract member eventMap: obj with get, set
        /// <summary>
        /// Whether or not the execution of callbacks is currently suspended for this emitter.
        /// </summary>
        abstract member eventsSuspended: bool with get, set
        /// <summary>
        /// Adds a listener for the specified event. It returns the [<c>Listener</c>]<see href="Listener">Listener</see> object
        /// that was created and attached to the event.
        ///
        /// To attach a global listener that will be triggered for any events, use
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="#ANY_EVENT">#ANY_EVENT</see> as the first parameter. Note that a global
        /// listener will also be triggered by non-registered events.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// The <c>event</c> parameter must be a string or
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>.
        ///
        /// The <c>callback</c> parameter must be a function.
        /// </remarks>
        /// <param name="event">
        /// The event to listen to.
        /// </param>
        /// <param name="callback">
        /// The callback function to execute when the event occurs.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// The newly created [<c>Listener</c>]<see href="Listener">Listener</see> object (typical) or an array
        /// of [<c>Listener</c>]<see href="Listener">Listener</see> objects.
        /// </returns>
        abstract member addListener: event: string * callback: Webmidi.EventEmitterCallback * ?options: EventEmitter.addListener.options -> U2<Webmidi.Listener, ResizeArray<Webmidi.Listener>>
        /// <summary>
        /// Adds a listener for the specified event. It returns the [<c>Listener</c>]<see href="Listener">Listener</see> object
        /// that was created and attached to the event.
        ///
        /// To attach a global listener that will be triggered for any events, use
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="#ANY_EVENT">#ANY_EVENT</see> as the first parameter. Note that a global
        /// listener will also be triggered by non-registered events.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// The <c>event</c> parameter must be a string or
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>.
        ///
        /// The <c>callback</c> parameter must be a function.
        /// </remarks>
        /// <param name="event">
        /// The event to listen to.
        /// </param>
        /// <param name="callback">
        /// The callback function to execute when the event occurs.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// The newly created [<c>Listener</c>]<see href="Listener">Listener</see> object (typical) or an array
        /// of [<c>Listener</c>]<see href="Listener">Listener</see> objects.
        /// </returns>
        abstract member addListener: event: obj * callback: Webmidi.EventEmitterCallback * ?options: EventEmitter.addListener.options -> U2<Webmidi.Listener, ResizeArray<Webmidi.Listener>>
        /// <summary>
        /// Adds a listener for the specified event. It returns the [<c>Listener</c>]<see href="Listener">Listener</see> object
        /// that was created and attached to the event.
        ///
        /// To attach a global listener that will be triggered for any events, use
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="#ANY_EVENT">#ANY_EVENT</see> as the first parameter. Note that a global
        /// listener will also be triggered by non-registered events.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// The <c>event</c> parameter must be a string or
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>.
        ///
        /// The <c>callback</c> parameter must be a function.
        /// </remarks>
        /// <param name="event">
        /// The event to listen to.
        /// </param>
        /// <param name="callback">
        /// The callback function to execute when the event occurs.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// The newly created [<c>Listener</c>]<see href="Listener">Listener</see> object (typical) or an array
        /// of [<c>Listener</c>]<see href="Listener">Listener</see> objects.
        /// </returns>
        abstract member addListener: event: U2<string, obj> * callback: Webmidi.EventEmitterCallback * ?options: EventEmitter.addListener.options -> U2<Webmidi.Listener, ResizeArray<Webmidi.Listener>>
        /// <summary>
        /// Adds a one-time listener for the specified event. The listener will be executed once and then
        /// destroyed. It returns the [<c>Listener</c>]<see href="Listener">Listener</see> object that was created and attached
        /// to the event.
        ///
        /// To attach a global listener that will be triggered for any events, use
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> as the first parameter. Note that a
        /// global listener will also be triggered by non-registered events.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// The <c>event</c> parameter must be a string or
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>.
        ///
        /// The <c>callback</c> parameter must be a function.
        /// </remarks>
        /// <param name="event">
        /// The event to listen to
        /// </param>
        /// <param name="callback">
        /// The callback function to execute when the event occurs
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// The newly created [<c>Listener</c>]<see href="Listener">Listener</see> object (typical) or an array
        /// of [<c>Listener</c>]<see href="Listener">Listener</see> objects.
        /// </returns>
        abstract member addOneTimeListener: event: string * callback: Webmidi.EventEmitterCallback * ?options: EventEmitter.addOneTimeListener.options -> U2<Webmidi.Listener, ResizeArray<Webmidi.Listener>>
        /// <summary>
        /// Adds a one-time listener for the specified event. The listener will be executed once and then
        /// destroyed. It returns the [<c>Listener</c>]<see href="Listener">Listener</see> object that was created and attached
        /// to the event.
        ///
        /// To attach a global listener that will be triggered for any events, use
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> as the first parameter. Note that a
        /// global listener will also be triggered by non-registered events.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// The <c>event</c> parameter must be a string or
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>.
        ///
        /// The <c>callback</c> parameter must be a function.
        /// </remarks>
        /// <param name="event">
        /// The event to listen to
        /// </param>
        /// <param name="callback">
        /// The callback function to execute when the event occurs
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// The newly created [<c>Listener</c>]<see href="Listener">Listener</see> object (typical) or an array
        /// of [<c>Listener</c>]<see href="Listener">Listener</see> objects.
        /// </returns>
        abstract member addOneTimeListener: event: obj * callback: Webmidi.EventEmitterCallback * ?options: EventEmitter.addOneTimeListener.options -> U2<Webmidi.Listener, ResizeArray<Webmidi.Listener>>
        /// <summary>
        /// Adds a one-time listener for the specified event. The listener will be executed once and then
        /// destroyed. It returns the [<c>Listener</c>]<see href="Listener">Listener</see> object that was created and attached
        /// to the event.
        ///
        /// To attach a global listener that will be triggered for any events, use
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> as the first parameter. Note that a
        /// global listener will also be triggered by non-registered events.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// The <c>event</c> parameter must be a string or
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>.
        ///
        /// The <c>callback</c> parameter must be a function.
        /// </remarks>
        /// <param name="event">
        /// The event to listen to
        /// </param>
        /// <param name="callback">
        /// The callback function to execute when the event occurs
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// The newly created [<c>Listener</c>]<see href="Listener">Listener</see> object (typical) or an array
        /// of [<c>Listener</c>]<see href="Listener">Listener</see> objects.
        /// </returns>
        abstract member addOneTimeListener: event: U2<string, obj> * callback: Webmidi.EventEmitterCallback * ?options: EventEmitter.addOneTimeListener.options -> U2<Webmidi.Listener, ResizeArray<Webmidi.Listener>>
        /// <summary>
        /// Returns <c>true</c> if the specified event has at least one registered listener. If no event is
        /// specified, the method returns <c>true</c> if any event has at least one listener registered (this
        /// includes global listeners registered to
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>).
        ///
        /// Note: to specifically check for global listeners added with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>, use
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> as the parameter.
        /// </summary>
        /// <param name="event">
        /// event)] The event to check
        /// </param>
        /// <param name="callback">
        /// callback)] The actual function that was added to the
        /// event or the <see href="Listener">Listener</see> object returned by <c>addListener()</c>.
        /// </param>
        abstract member hasListener: unit -> bool
        /// <summary>
        /// Returns <c>true</c> if the specified event has at least one registered listener. If no event is
        /// specified, the method returns <c>true</c> if any event has at least one listener registered (this
        /// includes global listeners registered to
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>).
        ///
        /// Note: to specifically check for global listeners added with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>, use
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> as the parameter.
        /// </summary>
        /// <param name="event">
        /// event)] The event to check
        /// </param>
        /// <param name="callback">
        /// callback)] The actual function that was added to the
        /// event or the <see href="Listener">Listener</see> object returned by <c>addListener()</c>.
        /// </param>
        abstract member hasListener: event: string -> bool
        /// <summary>
        /// Returns <c>true</c> if the specified event has at least one registered listener. If no event is
        /// specified, the method returns <c>true</c> if any event has at least one listener registered (this
        /// includes global listeners registered to
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>).
        ///
        /// Note: to specifically check for global listeners added with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>, use
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> as the parameter.
        /// </summary>
        /// <param name="event">
        /// event)] The event to check
        /// </param>
        /// <param name="callback">
        /// callback)] The actual function that was added to the
        /// event or the <see href="Listener">Listener</see> object returned by <c>addListener()</c>.
        /// </param>
        abstract member hasListener: event: string * callback: Action -> bool
        /// <summary>
        /// Returns <c>true</c> if the specified event has at least one registered listener. If no event is
        /// specified, the method returns <c>true</c> if any event has at least one listener registered (this
        /// includes global listeners registered to
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>).
        ///
        /// Note: to specifically check for global listeners added with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>, use
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> as the parameter.
        /// </summary>
        /// <param name="event">
        /// event)] The event to check
        /// </param>
        /// <param name="callback">
        /// callback)] The actual function that was added to the
        /// event or the <see href="Listener">Listener</see> object returned by <c>addListener()</c>.
        /// </param>
        abstract member hasListener: event: string * callback: Webmidi.Listener -> bool
        /// <summary>
        /// Returns <c>true</c> if the specified event has at least one registered listener. If no event is
        /// specified, the method returns <c>true</c> if any event has at least one listener registered (this
        /// includes global listeners registered to
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>).
        ///
        /// Note: to specifically check for global listeners added with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>, use
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> as the parameter.
        /// </summary>
        /// <param name="event">
        /// event)] The event to check
        /// </param>
        /// <param name="callback">
        /// callback)] The actual function that was added to the
        /// event or the <see href="Listener">Listener</see> object returned by <c>addListener()</c>.
        /// </param>
        abstract member hasListener: event: obj -> bool
        /// <summary>
        /// Returns <c>true</c> if the specified event has at least one registered listener. If no event is
        /// specified, the method returns <c>true</c> if any event has at least one listener registered (this
        /// includes global listeners registered to
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>).
        ///
        /// Note: to specifically check for global listeners added with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>, use
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> as the parameter.
        /// </summary>
        /// <param name="event">
        /// event)] The event to check
        /// </param>
        /// <param name="callback">
        /// callback)] The actual function that was added to the
        /// event or the <see href="Listener">Listener</see> object returned by <c>addListener()</c>.
        /// </param>
        abstract member hasListener: event: obj * callback: Action -> bool
        /// <summary>
        /// Returns <c>true</c> if the specified event has at least one registered listener. If no event is
        /// specified, the method returns <c>true</c> if any event has at least one listener registered (this
        /// includes global listeners registered to
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>).
        ///
        /// Note: to specifically check for global listeners added with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>, use
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> as the parameter.
        /// </summary>
        /// <param name="event">
        /// event)] The event to check
        /// </param>
        /// <param name="callback">
        /// callback)] The actual function that was added to the
        /// event or the <see href="Listener">Listener</see> object returned by <c>addListener()</c>.
        /// </param>
        abstract member hasListener: event: obj * callback: Webmidi.Listener -> bool
        /// <summary>
        /// An array of all the unique event names for which the emitter has at least one registered
        /// listener.
        ///
        /// Note: this excludes global events registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> because they are not tied to a
        /// specific event.
        /// </summary>
        abstract member eventNames: ResizeArray<string> with get
        /// <summary>
        /// Returns an array of all the [<c>Listener</c>]<see href="Listener">Listener</see> objects that have been registered for
        /// a specific event.
        ///
        /// Please note that global events (those added with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>) are not returned for "regular"
        /// events. To get the list of global listeners, specifically use
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> as the parameter.
        /// </summary>
        /// <param name="event">
        /// The event to get listeners for.
        /// </param>
        /// <returns>
        /// An array of [<c>Listener</c>]<see href="Listener">Listener</see> objects.
        /// </returns>
        abstract member getListeners: event: string -> ResizeArray<Webmidi.Listener>
        /// <summary>
        /// Returns an array of all the [<c>Listener</c>]<see href="Listener">Listener</see> objects that have been registered for
        /// a specific event.
        ///
        /// Please note that global events (those added with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>) are not returned for "regular"
        /// events. To get the list of global listeners, specifically use
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> as the parameter.
        /// </summary>
        /// <param name="event">
        /// The event to get listeners for.
        /// </param>
        /// <returns>
        /// An array of [<c>Listener</c>]<see href="Listener">Listener</see> objects.
        /// </returns>
        abstract member getListeners: event: obj -> ResizeArray<Webmidi.Listener>
        /// <summary>
        /// Returns an array of all the [<c>Listener</c>]<see href="Listener">Listener</see> objects that have been registered for
        /// a specific event.
        ///
        /// Please note that global events (those added with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>) are not returned for "regular"
        /// events. To get the list of global listeners, specifically use
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> as the parameter.
        /// </summary>
        /// <param name="event">
        /// The event to get listeners for.
        /// </param>
        /// <returns>
        /// An array of [<c>Listener</c>]<see href="Listener">Listener</see> objects.
        /// </returns>
        abstract member getListeners: event: U2<string, obj> -> ResizeArray<Webmidi.Listener>
        /// <summary>
        /// Suspends execution of all callbacks functions registered for the specified event type.
        ///
        /// You can suspend execution of callbacks registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> by passing
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> to <c>suspendEvent()</c>. Beware that this
        /// will not suspend all callbacks but only those registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>. While this may seem counter-intuitive
        /// at first glance, it allows the selective suspension of global listeners while leaving other
        /// listeners alone. If you truly want to suspends all callbacks for a specific
        /// [<c>EventEmitter</c>]<see href="EventEmitter">EventEmitter</see>, simply set its <c>eventsSuspended</c> property to <c>true</c>.
        /// </summary>
        /// <param name="event">
        /// The event name (or <c>EventEmitter.ANY_EVENT</c>) for which to suspend
        /// execution of all callback functions.
        /// </param>
        abstract member suspendEvent: event: string -> unit
        /// <summary>
        /// Suspends execution of all callbacks functions registered for the specified event type.
        ///
        /// You can suspend execution of callbacks registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> by passing
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> to <c>suspendEvent()</c>. Beware that this
        /// will not suspend all callbacks but only those registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>. While this may seem counter-intuitive
        /// at first glance, it allows the selective suspension of global listeners while leaving other
        /// listeners alone. If you truly want to suspends all callbacks for a specific
        /// [<c>EventEmitter</c>]<see href="EventEmitter">EventEmitter</see>, simply set its <c>eventsSuspended</c> property to <c>true</c>.
        /// </summary>
        /// <param name="event">
        /// The event name (or <c>EventEmitter.ANY_EVENT</c>) for which to suspend
        /// execution of all callback functions.
        /// </param>
        abstract member suspendEvent: event: obj -> unit
        /// <summary>
        /// Suspends execution of all callbacks functions registered for the specified event type.
        ///
        /// You can suspend execution of callbacks registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> by passing
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> to <c>suspendEvent()</c>. Beware that this
        /// will not suspend all callbacks but only those registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>. While this may seem counter-intuitive
        /// at first glance, it allows the selective suspension of global listeners while leaving other
        /// listeners alone. If you truly want to suspends all callbacks for a specific
        /// [<c>EventEmitter</c>]<see href="EventEmitter">EventEmitter</see>, simply set its <c>eventsSuspended</c> property to <c>true</c>.
        /// </summary>
        /// <param name="event">
        /// The event name (or <c>EventEmitter.ANY_EVENT</c>) for which to suspend
        /// execution of all callback functions.
        /// </param>
        abstract member suspendEvent: event: U2<string, obj> -> unit
        /// <summary>
        /// Resumes execution of all suspended callback functions registered for the specified event type.
        ///
        /// You can resume execution of callbacks registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> by passing
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> to <c>unsuspendEvent()</c>. Beware that
        /// this will not resume all callbacks but only those registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>. While this may seem
        /// counter-intuitive, it allows the selective unsuspension of global listeners while leaving other
        /// callbacks alone.
        /// </summary>
        /// <param name="event">
        /// The event name (or <c>EventEmitter.ANY_EVENT</c>) for which to resume
        /// execution of all callback functions.
        /// </param>
        abstract member unsuspendEvent: event: string -> unit
        /// <summary>
        /// Resumes execution of all suspended callback functions registered for the specified event type.
        ///
        /// You can resume execution of callbacks registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> by passing
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> to <c>unsuspendEvent()</c>. Beware that
        /// this will not resume all callbacks but only those registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>. While this may seem
        /// counter-intuitive, it allows the selective unsuspension of global listeners while leaving other
        /// callbacks alone.
        /// </summary>
        /// <param name="event">
        /// The event name (or <c>EventEmitter.ANY_EVENT</c>) for which to resume
        /// execution of all callback functions.
        /// </param>
        abstract member unsuspendEvent: event: obj -> unit
        /// <summary>
        /// Resumes execution of all suspended callback functions registered for the specified event type.
        ///
        /// You can resume execution of callbacks registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> by passing
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> to <c>unsuspendEvent()</c>. Beware that
        /// this will not resume all callbacks but only those registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>. While this may seem
        /// counter-intuitive, it allows the selective unsuspension of global listeners while leaving other
        /// callbacks alone.
        /// </summary>
        /// <param name="event">
        /// The event name (or <c>EventEmitter.ANY_EVENT</c>) for which to resume
        /// execution of all callback functions.
        /// </param>
        abstract member unsuspendEvent: event: U2<string, obj> -> unit
        /// <summary>
        /// Returns the number of listeners registered for a specific event.
        ///
        /// Please note that global events (those added with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>) do not count towards the remaining
        /// number for a "regular" event. To get the number of global listeners, specifically use
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> as the parameter.
        /// </summary>
        /// <param name="event">
        /// The event which is usually a string but can also be the special
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> symbol.
        /// </param>
        /// <returns>
        /// An integer representing the number of listeners registered for the specified
        /// event.
        /// </returns>
        abstract member getListenerCount: event: string -> float
        /// <summary>
        /// Returns the number of listeners registered for a specific event.
        ///
        /// Please note that global events (those added with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>) do not count towards the remaining
        /// number for a "regular" event. To get the number of global listeners, specifically use
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> as the parameter.
        /// </summary>
        /// <param name="event">
        /// The event which is usually a string but can also be the special
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> symbol.
        /// </param>
        /// <returns>
        /// An integer representing the number of listeners registered for the specified
        /// event.
        /// </returns>
        abstract member getListenerCount: event: obj -> float
        /// <summary>
        /// Returns the number of listeners registered for a specific event.
        ///
        /// Please note that global events (those added with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>) do not count towards the remaining
        /// number for a "regular" event. To get the number of global listeners, specifically use
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> as the parameter.
        /// </summary>
        /// <param name="event">
        /// The event which is usually a string but can also be the special
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> symbol.
        /// </param>
        /// <returns>
        /// An integer representing the number of listeners registered for the specified
        /// event.
        /// </returns>
        abstract member getListenerCount: event: U2<string, obj> -> float
        /// <summary>
        /// Executes the callback function of all the [<c>Listener</c>]<see href="Listener">Listener</see> objects registered for
        /// a given event. The callback functions are passed the additional arguments passed to <c>emit()</c>
        /// (if any) followed by the arguments present in the [<c>arguments</c>](Listener#arguments) property of
        /// the [<c>Listener</c>](Listener) object (if any).
        ///
        /// If the [<c>eventsSuspended</c>]<see href="#eventsSuspended">#eventsSuspended</see> property is <c>true</c> or the
        /// [<c>Listener.suspended</c>]<see href="Listener#suspended">Listener#suspended</see> property is <c>true</c>, the callback functions
        /// will not be executed.
        ///
        /// This function returns an array containing the return values of each of the callbacks.
        ///
        /// It should be noted that the regular listeners are triggered first followed by the global
        /// listeners (those added with [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>).
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// The <c>event</c> parameter must be a string.
        /// </remarks>
        /// <param name="event">
        /// The event
        /// </param>
        /// <param name="args">
        /// Arbitrary number of arguments to pass along to the callback functions
        /// </param>
        /// <returns>
        /// An array containing the return value of each of the executed listener
        /// functions.
        /// </returns>
        abstract member emit: event: string * [<ParamArray>] args: obj [] -> ResizeArray<obj>
        /// <summary>
        /// Removes all the listeners that match the specified criterias. If no parameters are passed, all
        /// listeners will be removed. If only the <c>event</c> parameter is passed, all listeners for that
        /// event will be removed. You can remove global listeners by using
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> as the first parameter.
        ///
        /// To use more granular options, you must at least define the <c>event</c>. Then, you can specify the
        /// callback to match or one or more of the additional options.
        /// </summary>
        /// <param name="event">
        /// The event name.
        /// </param>
        /// <param name="callback">
        /// Only remove the listeners that match this exact
        /// callback function.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        abstract member removeListener: unit -> unit
        /// <summary>
        /// Removes all the listeners that match the specified criterias. If no parameters are passed, all
        /// listeners will be removed. If only the <c>event</c> parameter is passed, all listeners for that
        /// event will be removed. You can remove global listeners by using
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> as the first parameter.
        ///
        /// To use more granular options, you must at least define the <c>event</c>. Then, you can specify the
        /// callback to match or one or more of the additional options.
        /// </summary>
        /// <param name="event">
        /// The event name.
        /// </param>
        /// <param name="callback">
        /// Only remove the listeners that match this exact
        /// callback function.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        abstract member removeListener: event: string * ?callback: Webmidi.EventEmitterCallback * ?options: EventEmitter.removeListener.options -> unit
        /// <summary>
        /// Removes all the listeners that match the specified criterias. If no parameters are passed, all
        /// listeners will be removed. If only the <c>event</c> parameter is passed, all listeners for that
        /// event will be removed. You can remove global listeners by using
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> as the first parameter.
        ///
        /// To use more granular options, you must at least define the <c>event</c>. Then, you can specify the
        /// callback to match or one or more of the additional options.
        /// </summary>
        /// <param name="event">
        /// The event name.
        /// </param>
        /// <param name="callback">
        /// Only remove the listeners that match this exact
        /// callback function.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        abstract member removeListener: event: obj * ?callback: Webmidi.EventEmitterCallback * ?options: EventEmitter.removeListener.options -> unit
        /// <summary>
        /// The <c>waitFor()</c> method is an async function which returns a promise. The promise is fulfilled
        /// when the specified event occurs. The event can be a regular event or
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> (if you want to resolve as soon as any
        /// event is emitted).
        ///
        /// If the <c>duration</c> option is set, the promise will only be fulfilled if the event is emitted
        /// within the specified duration. If the event has not been fulfilled after the specified
        /// duration, the promise is rejected. This makes it super easy to wait for an event and timeout
        /// after a certain time if the event is not triggered.
        /// </summary>
        /// <param name="event">
        /// The event to wait for
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        abstract member waitFor: event: string * ?options: EventEmitter.waitFor.options -> JS.Promise<obj>
        /// <summary>
        /// The <c>waitFor()</c> method is an async function which returns a promise. The promise is fulfilled
        /// when the specified event occurs. The event can be a regular event or
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> (if you want to resolve as soon as any
        /// event is emitted).
        ///
        /// If the <c>duration</c> option is set, the promise will only be fulfilled if the event is emitted
        /// within the specified duration. If the event has not been fulfilled after the specified
        /// duration, the promise is rejected. This makes it super easy to wait for an event and timeout
        /// after a certain time if the event is not triggered.
        /// </summary>
        /// <param name="event">
        /// The event to wait for
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        abstract member waitFor: event: obj * ?options: EventEmitter.waitFor.options -> JS.Promise<obj>
        /// <summary>
        /// The <c>waitFor()</c> method is an async function which returns a promise. The promise is fulfilled
        /// when the specified event occurs. The event can be a regular event or
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> (if you want to resolve as soon as any
        /// event is emitted).
        ///
        /// If the <c>duration</c> option is set, the promise will only be fulfilled if the event is emitted
        /// within the specified duration. If the event has not been fulfilled after the specified
        /// duration, the promise is rejected. This makes it super easy to wait for an event and timeout
        /// after a certain time if the event is not triggered.
        /// </summary>
        /// <param name="event">
        /// The event to wait for
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        abstract member waitFor: event: U2<string, obj> * ?options: EventEmitter.waitFor.options -> JS.Promise<obj>
        /// <summary>
        /// The number of unique events that have registered listeners.
        ///
        /// Note: this excludes global events registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> because they are not tied to a
        /// specific event.
        /// </summary>
        abstract member eventCount: float with get

    /// <summary>
    /// The <c>Listener</c> class represents a single event listener object. Such objects keep all relevant
    /// contextual information such as the event being listened to, the object the listener was attached
    /// to, the callback function and so on.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("Listener", "webmidi")>]
    type Listener =
        /// <summary>
        /// An array of arguments to pass to the callback function upon execution.
        /// </summary>
        abstract member arguments: ResizeArray<obj> with get, set
        /// <summary>
        /// The callback function to execute.
        /// </summary>
        abstract member callback: Action with get, set
        /// <summary>
        /// The context to execute the callback function in (a.k.a. the value of <c>this</c> inside the
        /// callback function)
        /// </summary>
        abstract member context: obj with get, set
        /// <summary>
        /// The number of times the listener function was executed.
        /// </summary>
        abstract member count: float with get, set
        /// <summary>
        /// The event name.
        /// </summary>
        abstract member event: string with get, set
        /// <summary>
        /// The remaining number of times after which the callback should automatically be removed.
        /// </summary>
        abstract member remaining: float with get, set
        /// <summary>
        /// Whether this listener is currently suspended or not.
        /// </summary>
        abstract member suspended: bool with get, set
        /// <summary>
        /// The object that the event is attached to (or that emitted the event).
        /// </summary>
        abstract member target: Webmidi.EventEmitter with get, set
        /// <summary>
        /// Removes the listener from its target.
        /// </summary>
        abstract member remove: unit -> unit

    /// <summary>
    /// The <c>Enumerations</c> class contains enumerations and arrays of elements used throughout the
    /// library. All properties are static and should be referenced using the class name. For example:
    /// <c>Enumerations.CHANNEL_MESSAGES</c>.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("Enumerations", "webmidi")>]
    type Enumerations =
        /// <summary>
        /// Enumeration of all MIDI channel message names and their associated 4-bit numerical value:
        ///
        /// | Message Name        | Hexadecimal | Decimal |
        /// |---------------------|-------------|---------|
        /// | <c>noteoff</c>           | 0x8         | 8       |
        /// | <c>noteon</c>            | 0x9         | 9       |
        /// | <c>keyaftertouch</c>     | 0xA         | 10      |
        /// | <c>controlchange</c>     | 0xB         | 11      |
        /// | <c>programchange</c>     | 0xC         | 12      |
        /// | <c>channelaftertouch</c> | 0xD         | 13      |
        /// | <c>pitchbend</c>         | 0xE         | 14      |
        /// </summary>
        static member inline CHANNEL_MESSAGES
            with get () : Enumerations.CHANNEL_MESSAGES__ =
                nativeOnly
        /// <summary>
        /// A simple array of the 16 valid MIDI channel numbers (<c>1</c> to <c>16</c>):
        /// </summary>
        static member inline CHANNEL_NUMBERS
            with get () : ResizeArray<float> =
                nativeOnly
        /// <summary>
        /// Enumeration of all MIDI channel mode message names and their associated numerical value:
        /// | Message Name          | Hexadecimal | Decimal |
        /// |-----------------------|-------------|---------|
        /// | <c>allsoundoff</c>         | 0x78        | 120     |
        /// | <c>resetallcontrollers</c> | 0x79        | 121     |
        /// | <c>localcontrol</c>        | 0x7A        | 122     |
        /// | <c>allnotesoff</c>         | 0x7B        | 123     |
        /// | <c>omnimodeoff</c>         | 0x7C        | 124     |
        /// | <c>omnimodeon</c>          | 0x7D        | 125     |
        /// | <c>monomodeon</c>          | 0x7E        | 126     |
        /// | <c>polymodeon</c>          | 0x7F        | 127     |
        /// </summary>
        static member inline CHANNEL_MODE_MESSAGES
            with get () : Enumerations.CHANNEL_MODE_MESSAGES__ =
                nativeOnly
        /// <summary>
        /// An array of objects, ordered by control number, describing control change messages. Each object
        /// in the array can have up to 4 properties:
        ///
        ///  * <c>number</c>: MIDI control number (0-127);
        ///  * <c>event</c>: name of emitted event (eg: <c>bankselectcoarse</c>, <c>choruslevel</c>, etc) that can be
        ///  listened to;
        ///  * <c>description</c>: user-friendly description of the controller's purpose;
        ///  * <c>position</c>: whether this controller's value should be considered an <c>msb</c> or <c>lsb</c> (if
        ///  appropriate).
        ///
        /// Not all controllers have a predefined function. For those that don't, name is the word
        /// "controller" followed by the number (e.g. <c>controller112</c>).
        ///
        /// | Event name                     | Control Number |
        /// |--------------------------------|----------------|
        /// | <c>bankselectcoarse</c>             | 0              |
        /// | <c>modulationwheelcoarse</c>        | 1              |
        /// | <c>breathcontrollercoarse</c>       | 2              |
        /// | <c>controller3</c>                  | 3              |
        /// | <c>footcontrollercoarse</c>         | 4              |
        /// | <c>portamentotimecoarse</c>         | 5              |
        /// | <c>dataentrycoarse</c>              | 6              |
        /// | <c>volumecoarse</c>                 | 7              |
        /// | <c>balancecoarse</c>                | 8              |
        /// | <c>controller9</c>                  | 9              |
        /// | <c>pancoarse</c>                    | 10             |
        /// | <c>expressioncoarse</c>             | 11             |
        /// | <c>effectcontrol1coarse</c>         | 12             |
        /// | <c>effectcontrol2coarse</c>         | 13             |
        /// | <c>controller14</c>                 | 14             |
        /// | <c>controller15</c>                 | 15             |
        /// | <c>generalpurposecontroller1</c>    | 16             |
        /// | <c>generalpurposecontroller2</c>    | 17             |
        /// | <c>generalpurposecontroller3</c>    | 18             |
        /// | <c>generalpurposecontroller4</c>    | 19             |
        /// | <c>controller20</c>                 | 20             |
        /// | <c>controller21</c>                 | 21             |
        /// | <c>controller22</c>                 | 22             |
        /// | <c>controller23</c>                 | 23             |
        /// | <c>controller24</c>                 | 24             |
        /// | <c>controller25</c>                 | 25             |
        /// | <c>controller26</c>                 | 26             |
        /// | <c>controller27</c>                 | 27             |
        /// | <c>controller28</c>                 | 28             |
        /// | <c>controller29</c>                 | 29             |
        /// | <c>controller30</c>                 | 30             |
        /// | <c>controller31</c>                 | 31             |
        /// | <c>bankselectfine</c>               | 32             |
        /// | <c>modulationwheelfine</c>          | 33             |
        /// | <c>breathcontrollerfine</c>         | 34             |
        /// | <c>controller35</c>                 | 35             |
        /// | <c>footcontrollerfine</c>           | 36             |
        /// | <c>portamentotimefine</c>           | 37             |
        /// | <c>dataentryfine</c>                | 38             |
        /// | <c>channelvolumefine</c>            | 39             |
        /// | <c>balancefine</c>                  | 40             |
        /// | <c>controller41</c>                 | 41             |
        /// | <c>panfine</c>                      | 42             |
        /// | <c>expressionfine</c>               | 43             |
        /// | <c>effectcontrol1fine</c>           | 44             |
        /// | <c>effectcontrol2fine</c>           | 45             |
        /// | <c>controller46</c>                 | 46             |
        /// | <c>controller47</c>                 | 47             |
        /// | <c>controller48</c>                 | 48             |
        /// | <c>controller49</c>                 | 49             |
        /// | <c>controller50</c>                 | 50             |
        /// | <c>controller51</c>                 | 51             |
        /// | <c>controller52</c>                 | 52             |
        /// | <c>controller53</c>                 | 53             |
        /// | <c>controller54</c>                 | 54             |
        /// | <c>controller55</c>                 | 55             |
        /// | <c>controller56</c>                 | 56             |
        /// | <c>controller57</c>                 | 57             |
        /// | <c>controller58</c>                 | 58             |
        /// | <c>controller59</c>                 | 59             |
        /// | <c>controller60</c>                 | 60             |
        /// | <c>controller61</c>                 | 61             |
        /// | <c>controller62</c>                 | 62             |
        /// | <c>controller63</c>                 | 63             |
        /// | <c>damperpedal</c>                  | 64             |
        /// | <c>portamento</c>                   | 65             |
        /// | <c>sostenuto</c>                    | 66             |
        /// | <c>softpedal</c>                    | 67             |
        /// | <c>legatopedal</c>                  | 68             |
        /// | <c>hold2</c>                        | 69             |
        /// | <c>soundvariation</c>               | 70             |
        /// | <c>resonance</c>                    | 71             |
        /// | <c>releasetime</c>                  | 72             |
        /// | <c>attacktime</c>                   | 73             |
        /// | <c>brightness</c>                   | 74             |
        /// | <c>decaytime</c>                    | 75             |
        /// | <c>vibratorate</c>                  | 76             |
        /// | <c>vibratodepth</c>                 | 77             |
        /// | <c>vibratodelay</c>                 | 78             |
        /// | <c>controller79</c>                 | 79             |
        /// | <c>generalpurposecontroller5</c>    | 80             |
        /// | <c>generalpurposecontroller6</c>    | 81             |
        /// | <c>generalpurposecontroller7</c>    | 82             |
        /// | <c>generalpurposecontroller8</c>    | 83             |
        /// | <c>portamentocontrol</c>            | 84             |
        /// | <c>controller85</c>                 | 85             |
        /// | <c>controller86</c>                 | 86             |
        /// | <c>controller87</c>                 | 87             |
        /// | <c>highresolutionvelocityprefix</c> | 88             |
        /// | <c>controller89</c>                 | 89             |
        /// | <c>controller90</c>                 | 90             |
        /// | <c>effect1depth</c>                 | 91             |
        /// | <c>effect2depth</c>                 | 92             |
        /// | <c>effect3depth</c>                 | 93             |
        /// | <c>effect4depth</c>                 | 94             |
        /// | <c>effect5depth</c>                 | 95             |
        /// | <c>dataincrement</c>                | 96             |
        /// | <c>datadecrement</c>                | 97             |
        /// | <c>nonregisteredparameterfine</c>   | 98             |
        /// | <c>nonregisteredparametercoarse</c> | 99             |
        /// | <c>nonregisteredparameterfine</c>   | 100            |
        /// | <c>registeredparametercoarse</c>    | 101            |
        /// | <c>controller102</c>                | 102            |
        /// | <c>controller103</c>                | 103            |
        /// | <c>controller104</c>                | 104            |
        /// | <c>controller105</c>                | 105            |
        /// | <c>controller106</c>                | 106            |
        /// | <c>controller107</c>                | 107            |
        /// | <c>controller108</c>                | 108            |
        /// | <c>controller109</c>                | 109            |
        /// | <c>controller110</c>                | 110            |
        /// | <c>controller111</c>                | 111            |
        /// | <c>controller112</c>                | 112            |
        /// | <c>controller113</c>                | 113            |
        /// | <c>controller114</c>                | 114            |
        /// | <c>controller115</c>                | 115            |
        /// | <c>controller116</c>                | 116            |
        /// | <c>controller117</c>                | 117            |
        /// | <c>controller118</c>                | 118            |
        /// | <c>controller119</c>                | 119            |
        /// | <c>allsoundoff</c>                  | 120            |
        /// | <c>resetallcontrollers</c>          | 121            |
        /// | <c>localcontrol</c>                 | 122            |
        /// | <c>allnotesoff</c>                  | 123            |
        /// | <c>omnimodeoff</c>                  | 124            |
        /// | <c>omnimodeon</c>                   | 125            |
        /// | <c>monomodeon</c>                   | 126            |
        /// | <c>polymodeon</c>                   | 127            |
        /// </summary>
        static member inline CONTROL_CHANGE_MESSAGES
            with get () : ResizeArray<obj> =
                nativeOnly
        /// <summary>
        /// Enumeration of all MIDI registered parameters and their associated pair of numerical values.
        /// MIDI registered parameters extend the original list of control change messages. Currently,
        /// there are only a limited number of them:
        /// | Control Function             | [LSB, MSB]   |
        /// |------------------------------|--------------|
        /// | <c>pitchbendrange</c>             | [0x00, 0x00] |
        /// | <c>channelfinetuning</c>          | [0x00, 0x01] |
        /// | <c>channelcoarsetuning</c>        | [0x00, 0x02] |
        /// | <c>tuningprogram</c>              | [0x00, 0x03] |
        /// | <c>tuningbank</c>                 | [0x00, 0x04] |
        /// | <c>modulationrange</c>            | [0x00, 0x05] |
        /// | <c>azimuthangle</c>               | [0x3D, 0x00] |
        /// | <c>elevationangle</c>             | [0x3D, 0x01] |
        /// | <c>gain</c>                       | [0x3D, 0x02] |
        /// | <c>distanceratio</c>              | [0x3D, 0x03] |
        /// | <c>maximumdistance</c>            | [0x3D, 0x04] |
        /// | <c>maximumdistancegain</c>        | [0x3D, 0x05] |
        /// | <c>referencedistanceratio</c>     | [0x3D, 0x06] |
        /// | <c>panspreadangle</c>             | [0x3D, 0x07] |
        /// | <c>rollangle</c>                  | [0x3D, 0x08] |
        /// </summary>
        static member inline REGISTERED_PARAMETERS
            with get () : Enumerations.REGISTERED_PARAMETERS__ =
                nativeOnly
        /// <summary>
        /// Enumeration of all valid MIDI system messages and matching numerical values. WebMidi.js also
        /// uses two additional custom messages.
        ///
        /// **System Common Messages**
        ///
        /// | Function               | Hexadecimal | Decimal |
        /// |------------------------|-------------|---------|
        /// | <c>sysex</c>                | 0xF0        |  240    |
        /// | <c>timecode</c>             | 0xF1        |  241    |
        /// | <c>songposition</c>         | 0xF2        |  242    |
        /// | <c>songselect</c>           | 0xF3        |  243    |
        /// | <c>tunerequest</c>          | 0xF6        |  246    |
        /// | <c>sysexend</c>             | 0xF7        |  247    |
        ///
        /// The <c>sysexend</c> message is never actually received. It simply ends a sysex stream.
        ///
        /// **System Real-Time Messages**
        ///
        /// | Function               | Hexadecimal | Decimal |
        /// |------------------------|-------------|---------|
        /// | <c>clock</c>                | 0xF8        |  248    |
        /// | <c>start</c>                | 0xFA        |  250    |
        /// | <c>continue</c>             | 0xFB        |  251    |
        /// | <c>stop</c>                 | 0xFC        |  252    |
        /// | <c>activesensing</c>        | 0xFE        |  254    |
        /// | <c>reset</c>                | 0xFF        |  255    |
        ///
        /// Values 249 and 253 are relayed by the
        /// [Web MIDI API](https://developer.mozilla.org/en-US/docs/Web/API/Web_MIDI_API) but they do not
        /// serve any specific purpose. The
        /// [MIDI 1.0 spec](https://www.midi.org/specifications/item/table-1-summary-of-midi-message)
        /// simply states that they are undefined/reserved.
        ///
        /// **Custom WebMidi.js Messages**
        ///
        /// These two messages are mostly for internal use. They are not MIDI messages and cannot be sent
        /// or forwarded.
        ///
        /// | Function               | Hexadecimal | Decimal |
        /// |------------------------|-------------|---------|
        /// | <c>midimessage</c>          |             |  0      |
        /// | <c>unknownsystemmessage</c> |             |  -1     |
        /// </summary>
        static member inline SYSTEM_MESSAGES
            with get () : Enumerations.SYSTEM_MESSAGES__ =
                nativeOnly
        /// <summary>
        /// Array of channel-specific event names that can be listened for. This includes channel mode
        /// events and RPN/NRPN events.
        /// </summary>
        static member inline CHANNEL_EVENTS
            with get () : ResizeArray<string> =
                nativeOnly

    /// <summary>
    /// The <c>Forwarder</c> class allows the forwarding of MIDI messages to predetermined outputs. When you
    /// call its [<c>forward()</c>](#forward) method, it will send the specified [<c>Message</c>](Message) object
    /// to all the outputs listed in its [<c>destinations</c>](#destinations) property.
    ///
    /// If specific channels or message types have been defined in the [<c>channels</c>](#channels) or
    /// [<c>types</c>](#types) properties, only messages matching the channels/types will be forwarded.
    ///
    /// While it can be manually instantiated, you are more likely to come across a <c>Forwarder</c> object as
    /// the return value of the [<c>Input.addForwarder()</c>](Input#addForwarder) method.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("Forwarder", "webmidi")>]
    type Forwarder =
        /// <summary>
        /// An array of [<c>Output</c>](Output) objects to forward the message to.
        /// </summary>
        abstract member destinations: ResizeArray<Webmidi.Output> with get, set
        /// <summary>
        /// An array of message types (<c>"noteon"</c>, <c>"controlchange"</c>, etc.) that must be matched in order
        /// for messages to be forwarded. By default, this array includes all
        /// [<c>Enumerations.SYSTEM_MESSAGES</c>](Enumerations#SYSTEM_MESSAGES) and
        /// [<c>Enumerations.CHANNEL_MESSAGES</c>](Enumerations#CHANNEL_MESSAGES).
        /// </summary>
        abstract member types: ResizeArray<string> with get, set
        /// <summary>
        /// An array of MIDI channel numbers that the message must match in order to be forwarded. By
        /// default, this array includes all MIDI channels (<c>1</c> to <c>16</c>).
        /// </summary>
        abstract member channels: ResizeArray<float> with get, set
        /// <summary>
        /// Indicates whether message forwarding is currently suspended or not in this forwarder.
        /// </summary>
        abstract member suspended: bool with get, set
        /// <summary>
        /// Sends the specified message to the forwarder's destination(s) if it matches the specified
        /// type(s) and channel(s).
        /// </summary>
        /// <param name="message">
        /// The [<c>Message</c>](Message) object to forward.
        /// </param>
        abstract member forward: message: Webmidi.Message -> unit

    /// <summary>
    /// The <c>Input</c> class represents a single MIDI input port. This object is automatically instantiated
    /// by the library according to the host's MIDI subsystem and does not need to be directly
    /// instantiated. Instead, you can access all <c>Input</c> objects by referring to the
    /// [<c>WebMidi.inputs</c>](WebMidi#inputs) array. You can also retrieve inputs by using methods such as
    /// [<c>WebMidi.getInputByName()</c>](WebMidi#getInputByName) and
    /// [<c>WebMidi.getInputById()</c>](WebMidi#getInputById).
    ///
    /// Note that a single MIDI device may expose several inputs and/or outputs.
    ///
    /// **Important**: the <c>Input</c> class does not directly fire channel-specific MIDI messages
    /// (such as [<c>noteon</c>](InputChannel#event:noteon) or
    /// [<c>controlchange</c>](InputChannel#event:controlchange), etc.). The [<c>InputChannel</c>](InputChannel)
    /// object does that. However, you can still use the
    /// [<c>Input.addListener()</c>](#addListener) method to listen to channel-specific events on multiple
    /// [<c>InputChannel</c>](InputChannel) objects at once.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("Input", "webmidi")>]
    type Input =
        /// <summary>
        /// Array containing the 16 [<c>InputChannel</c>](InputChannel) objects available for this <c>Input</c>. The
        /// channels are numbered 1 through 16.
        /// </summary>
        abstract member channels: ResizeArray<Webmidi.InputChannel> with get, set
        /// <summary>
        /// Adds a forwarder that will forward all incoming MIDI messages matching the criteria to the
        /// specified [<c>Output</c>](Output) destination(s). This is akin to the hardware MIDI THRU port, with
        /// the added benefit of being able to filter which data is forwarded.
        /// </summary>
        /// <param name="output">
        /// An [<c>Output</c>](Output) object, a [<c>Forwarder</c>](Forwarder)
        /// object or an array of such objects, to forward messages to.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// The [<c>Forwarder</c>](Forwarder) object created to handle the forwarding. This
        /// is useful if you wish to manipulate or remove the [<c>Forwarder</c>](Forwarder) later on.
        /// </returns>
        abstract member addForwarder: output: Webmidi.Output * ?options: Input.addForwarder.options -> Webmidi.Forwarder
        /// <summary>
        /// Adds a forwarder that will forward all incoming MIDI messages matching the criteria to the
        /// specified [<c>Output</c>](Output) destination(s). This is akin to the hardware MIDI THRU port, with
        /// the added benefit of being able to filter which data is forwarded.
        /// </summary>
        /// <param name="output">
        /// An [<c>Output</c>](Output) object, a [<c>Forwarder</c>](Forwarder)
        /// object or an array of such objects, to forward messages to.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// The [<c>Forwarder</c>](Forwarder) object created to handle the forwarding. This
        /// is useful if you wish to manipulate or remove the [<c>Forwarder</c>](Forwarder) later on.
        /// </returns>
        abstract member addForwarder: output: ResizeArray<Webmidi.Output> * ?options: Input.addForwarder.options -> Webmidi.Forwarder
        /// <summary>
        /// Adds a forwarder that will forward all incoming MIDI messages matching the criteria to the
        /// specified [<c>Output</c>](Output) destination(s). This is akin to the hardware MIDI THRU port, with
        /// the added benefit of being able to filter which data is forwarded.
        /// </summary>
        /// <param name="output">
        /// An [<c>Output</c>](Output) object, a [<c>Forwarder</c>](Forwarder)
        /// object or an array of such objects, to forward messages to.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// The [<c>Forwarder</c>](Forwarder) object created to handle the forwarding. This
        /// is useful if you wish to manipulate or remove the [<c>Forwarder</c>](Forwarder) later on.
        /// </returns>
        abstract member addForwarder: output: Webmidi.Forwarder * ?options: Input.addForwarder.options -> Webmidi.Forwarder
        /// <summary>
        /// Adds a forwarder that will forward all incoming MIDI messages matching the criteria to the
        /// specified [<c>Output</c>](Output) destination(s). This is akin to the hardware MIDI THRU port, with
        /// the added benefit of being able to filter which data is forwarded.
        /// </summary>
        /// <param name="output">
        /// An [<c>Output</c>](Output) object, a [<c>Forwarder</c>](Forwarder)
        /// object or an array of such objects, to forward messages to.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// The [<c>Forwarder</c>](Forwarder) object created to handle the forwarding. This
        /// is useful if you wish to manipulate or remove the [<c>Forwarder</c>](Forwarder) later on.
        /// </returns>
        abstract member addForwarder: output: U3<Webmidi.Output, ResizeArray<Webmidi.Output>, Webmidi.Forwarder> * ?options: Input.addForwarder.options -> Webmidi.Forwarder
        /// <summary>
        /// Adds an event listener that will trigger a function callback when the specified event is
        /// dispatched. The event usually is **input-wide** but can also be **channel-specific**.
        ///
        /// Input-wide events do not target a specific MIDI channel so it makes sense to listen for them
        /// at the <c>Input</c> level and not at the [<c>InputChannel</c>](InputChannel) level. Channel-specific
        /// events target a specific channel. Usually, in this case, you would add the listener to the
        /// [<c>InputChannel</c>](InputChannel) object. However, as a convenience, you can also listen to
        /// channel-specific events directly on an <c>Input</c>. This allows you to react to a channel-specific
        /// event no matter which channel it actually came through.
        ///
        /// When listening for an event, you simply need to specify the event name and the function to
        /// execute:
        ///
        /// <code lang="javascript">
        /// const listener = WebMidi.inputs[0].addListener("midimessage", e => {
        ///   console.log(e);
        /// });
        /// </code>
        ///
        /// Calling the function with an input-wide event (such as
        /// [<c>"midimessage"</c>]<see href="#event:midimessage">#event:midimessage</see>), will return the [<c>Listener</c>](Listener) object
        /// that was created.
        ///
        /// If you call the function with a channel-specific event (such as
        /// [<c>"noteon"</c>]<see href="InputChannel#event">:noteon</see>), it will return an array of all
        /// [<c>Listener</c>](Listener) objects that were created (one for each channel):
        ///
        /// <code lang="javascript">
        /// const listeners = WebMidi.inputs[0].addListener("noteon", someFunction);
        /// </code>
        ///
        /// You can also specify which channels you want to add the listener to:
        ///
        /// <code lang="javascript">
        /// const listeners = WebMidi.inputs[0].addListener("noteon", someFunction, {channels: [1, 2, 3]});
        /// </code>
        ///
        /// In this case, <c>listeners</c> is an array containing 3 [<c>Listener</c>](Listener) objects.
        ///
        /// Note that, when adding channel-specific listeners, it is the [<c>InputChannel</c>](InputChannel)
        /// instance that actually gets a listener added and not the <c>Input</c> instance. You can check that
        /// by calling [<c>InputChannel.hasListener()</c>](InputChannel#hasListener()).
        ///
        /// There are 8 families of events you can listen to:
        ///
        /// 1. **MIDI System Common** Events (input-wide)
        ///
        ///    * [<c>songposition</c>]<see href="Input#event">:songposition</see>
        ///    * [<c>songselect</c>]<see href="Input#event">:songselect</see>
        ///    * [<c>sysex</c>]<see href="Input#event">:sysex</see>
        ///    * [<c>timecode</c>]<see href="Input#event">:timecode</see>
        ///    * [<c>tunerequest</c>]<see href="Input#event">:tunerequest</see>
        ///
        /// 2. **MIDI System Real-Time** Events (input-wide)
        ///
        ///    * [<c>clock</c>]<see href="Input#event">:clock</see>
        ///    * [<c>start</c>]<see href="Input#event">:start</see>
        ///    * [<c>continue</c>]<see href="Input#event">:continue</see>
        ///    * [<c>stop</c>]<see href="Input#event">:stop</see>
        ///    * [<c>activesensing</c>]<see href="Input#event">:activesensing</see>
        ///    * [<c>reset</c>]<see href="Input#event">:reset</see>
        ///
        /// 3. **State Change** Events (input-wide)
        ///
        ///    * [<c>opened</c>]<see href="Input#event">:opened</see>
        ///    * [<c>closed</c>]<see href="Input#event">:closed</see>
        ///    * [<c>disconnected</c>]<see href="Input#event">:disconnected</see>
        ///
        /// 4. **Catch-All** Events (input-wide)
        ///
        ///    * [<c>midimessage</c>]<see href="Input#event">:midimessage</see>
        ///    * [<c>unknownmidimessage</c>]<see href="Input#event">:unknownmidimessage</see>
        ///
        /// 5. **Channel Voice** Events (channel-specific)
        ///
        ///    * [<c>channelaftertouch</c>]<see href="InputChannel#event">:channelaftertouch</see>
        ///    * [<c>controlchange</c>]<see href="InputChannel#event">:controlchange</see>
        ///      * [<c>controlchange-controller0</c>]<see href="InputChannel#event">:controlchange-controller0</see>
        ///      * [<c>controlchange-controller1</c>]<see href="InputChannel#event">:controlchange-controller1</see>
        ///      * [<c>controlchange-controller2</c>]<see href="InputChannel#event">:controlchange-controller2</see>
        ///      * (...)
        ///      * [<c>controlchange-controller127</c>]<see href="InputChannel#event">:controlchange-controller127</see>
        ///    * [<c>keyaftertouch</c>]<see href="InputChannel#event">:keyaftertouch</see>
        ///    * [<c>noteoff</c>]<see href="InputChannel#event">:noteoff</see>
        ///    * [<c>noteon</c>]<see href="InputChannel#event">:noteon</see>
        ///    * [<c>pitchbend</c>]<see href="InputChannel#event">:pitchbend</see>
        ///    * [<c>programchange</c>]<see href="InputChannel#event">:programchange</see>
        ///
        ///    Note: you can listen for a specific control change message by using an event name like this:
        ///    <c>controlchange-controller23</c>, <c>controlchange-controller99</c>, <c>controlchange-controller122</c>,
        ///    etc.
        ///
        /// 6. **Channel Mode** Events (channel-specific)
        ///
        ///    * [<c>allnotesoff</c>]<see href="InputChannel#event">:allnotesoff</see>
        ///    * [<c>allsoundoff</c>]<see href="InputChannel#event">:allsoundoff</see>
        ///    * [<c>localcontrol</c>]<see href="InputChannel#event">:localcontrol</see>
        ///    * [<c>monomode</c>]<see href="InputChannel#event">:monomode</see>
        ///    * [<c>omnimode</c>]<see href="InputChannel#event">:omnimode</see>
        ///    * [<c>resetallcontrollers</c>]<see href="InputChannel#event">:resetallcontrollers</see>
        ///
        /// 7. **NRPN** Events (channel-specific)
        ///
        ///    * [<c>nrpn</c>]<see href="InputChannel#event">:nrpn</see>
        ///    * [<c>nrpn-dataentrycoarse</c>]<see href="InputChannel#event">:nrpn-dataentrycoarse</see>
        ///    * [<c>nrpn-dataentryfine</c>]<see href="InputChannel#event">:nrpn-dataentryfine</see>
        ///    * [<c>nrpn-dataincrement</c>]<see href="InputChannel#event">:nrpn-dataincrement</see>
        ///    * [<c>nrpn-datadecrement</c>]<see href="InputChannel#event">:nrpn-datadecrement</see>
        ///
        /// 8. **RPN** Events (channel-specific)
        ///
        ///    * [<c>rpn</c>]<see href="InputChannel#event">:rpn</see>
        ///    * [<c>rpn-dataentrycoarse</c>]<see href="InputChannel#event">:rpn-dataentrycoarse</see>
        ///    * [<c>rpn-dataentryfine</c>]<see href="InputChannel#event">:rpn-dataentryfine</see>
        ///    * [<c>rpn-dataincrement</c>]<see href="InputChannel#event">:rpn-dataincrement</see>
        ///    * [<c>rpn-datadecrement</c>]<see href="InputChannel#event">:rpn-datadecrement</see>
        /// </summary>
        /// <param name="event">
        /// The type of the event.
        /// </param>
        /// <param name="listener">
        /// A callback function to execute when the specified event is detected.
        /// This function will receive an event parameter object. For details on this object's properties,
        /// check out the documentation for the various events (links above).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// If the event is input-wide, a single [<c>Listener</c>](Listener)
        /// object is returned. If the event is channel-specific, an array of all the
        /// [<c>Listener</c>](Listener) objects is returned (one for each channel).
        /// </returns>
        abstract member addListener<'T>: e: obj * listener: 'T * ?options: Input.addListener.options -> U2<Webmidi.Listener, ResizeArray<Webmidi.Listener>>
        /// <summary>
        /// Adds an event listener that will trigger a function callback when the specified event is
        /// dispatched. The event usually is **input-wide** but can also be **channel-specific**.
        ///
        /// Input-wide events do not target a specific MIDI channel so it makes sense to listen for them
        /// at the <c>Input</c> level and not at the [<c>InputChannel</c>](InputChannel) level. Channel-specific
        /// events target a specific channel. Usually, in this case, you would add the listener to the
        /// [<c>InputChannel</c>](InputChannel) object. However, as a convenience, you can also listen to
        /// channel-specific events directly on an <c>Input</c>. This allows you to react to a channel-specific
        /// event no matter which channel it actually came through.
        ///
        /// When listening for an event, you simply need to specify the event name and the function to
        /// execute:
        ///
        /// <code lang="javascript">
        /// const listener = WebMidi.inputs[0].addListener("midimessage", e => {
        ///   console.log(e);
        /// });
        /// </code>
        ///
        /// Calling the function with an input-wide event (such as
        /// [<c>"midimessage"</c>]<see href="#event:midimessage">#event:midimessage</see>), will return the [<c>Listener</c>](Listener) object
        /// that was created.
        ///
        /// If you call the function with a channel-specific event (such as
        /// [<c>"noteon"</c>]<see href="InputChannel#event">:noteon</see>), it will return an array of all
        /// [<c>Listener</c>](Listener) objects that were created (one for each channel):
        ///
        /// <code lang="javascript">
        /// const listeners = WebMidi.inputs[0].addListener("noteon", someFunction);
        /// </code>
        ///
        /// You can also specify which channels you want to add the listener to:
        ///
        /// <code lang="javascript">
        /// const listeners = WebMidi.inputs[0].addListener("noteon", someFunction, {channels: [1, 2, 3]});
        /// </code>
        ///
        /// In this case, <c>listeners</c> is an array containing 3 [<c>Listener</c>](Listener) objects.
        ///
        /// Note that, when adding channel-specific listeners, it is the [<c>InputChannel</c>](InputChannel)
        /// instance that actually gets a listener added and not the <c>Input</c> instance. You can check that
        /// by calling [<c>InputChannel.hasListener()</c>](InputChannel#hasListener()).
        ///
        /// There are 8 families of events you can listen to:
        ///
        /// 1. **MIDI System Common** Events (input-wide)
        ///
        ///    * [<c>songposition</c>]<see href="Input#event">:songposition</see>
        ///    * [<c>songselect</c>]<see href="Input#event">:songselect</see>
        ///    * [<c>sysex</c>]<see href="Input#event">:sysex</see>
        ///    * [<c>timecode</c>]<see href="Input#event">:timecode</see>
        ///    * [<c>tunerequest</c>]<see href="Input#event">:tunerequest</see>
        ///
        /// 2. **MIDI System Real-Time** Events (input-wide)
        ///
        ///    * [<c>clock</c>]<see href="Input#event">:clock</see>
        ///    * [<c>start</c>]<see href="Input#event">:start</see>
        ///    * [<c>continue</c>]<see href="Input#event">:continue</see>
        ///    * [<c>stop</c>]<see href="Input#event">:stop</see>
        ///    * [<c>activesensing</c>]<see href="Input#event">:activesensing</see>
        ///    * [<c>reset</c>]<see href="Input#event">:reset</see>
        ///
        /// 3. **State Change** Events (input-wide)
        ///
        ///    * [<c>opened</c>]<see href="Input#event">:opened</see>
        ///    * [<c>closed</c>]<see href="Input#event">:closed</see>
        ///    * [<c>disconnected</c>]<see href="Input#event">:disconnected</see>
        ///
        /// 4. **Catch-All** Events (input-wide)
        ///
        ///    * [<c>midimessage</c>]<see href="Input#event">:midimessage</see>
        ///    * [<c>unknownmidimessage</c>]<see href="Input#event">:unknownmidimessage</see>
        ///
        /// 5. **Channel Voice** Events (channel-specific)
        ///
        ///    * [<c>channelaftertouch</c>]<see href="InputChannel#event">:channelaftertouch</see>
        ///    * [<c>controlchange</c>]<see href="InputChannel#event">:controlchange</see>
        ///      * [<c>controlchange-controller0</c>]<see href="InputChannel#event">:controlchange-controller0</see>
        ///      * [<c>controlchange-controller1</c>]<see href="InputChannel#event">:controlchange-controller1</see>
        ///      * [<c>controlchange-controller2</c>]<see href="InputChannel#event">:controlchange-controller2</see>
        ///      * (...)
        ///      * [<c>controlchange-controller127</c>]<see href="InputChannel#event">:controlchange-controller127</see>
        ///    * [<c>keyaftertouch</c>]<see href="InputChannel#event">:keyaftertouch</see>
        ///    * [<c>noteoff</c>]<see href="InputChannel#event">:noteoff</see>
        ///    * [<c>noteon</c>]<see href="InputChannel#event">:noteon</see>
        ///    * [<c>pitchbend</c>]<see href="InputChannel#event">:pitchbend</see>
        ///    * [<c>programchange</c>]<see href="InputChannel#event">:programchange</see>
        ///
        ///    Note: you can listen for a specific control change message by using an event name like this:
        ///    <c>controlchange-controller23</c>, <c>controlchange-controller99</c>, <c>controlchange-controller122</c>,
        ///    etc.
        ///
        /// 6. **Channel Mode** Events (channel-specific)
        ///
        ///    * [<c>allnotesoff</c>]<see href="InputChannel#event">:allnotesoff</see>
        ///    * [<c>allsoundoff</c>]<see href="InputChannel#event">:allsoundoff</see>
        ///    * [<c>localcontrol</c>]<see href="InputChannel#event">:localcontrol</see>
        ///    * [<c>monomode</c>]<see href="InputChannel#event">:monomode</see>
        ///    * [<c>omnimode</c>]<see href="InputChannel#event">:omnimode</see>
        ///    * [<c>resetallcontrollers</c>]<see href="InputChannel#event">:resetallcontrollers</see>
        ///
        /// 7. **NRPN** Events (channel-specific)
        ///
        ///    * [<c>nrpn</c>]<see href="InputChannel#event">:nrpn</see>
        ///    * [<c>nrpn-dataentrycoarse</c>]<see href="InputChannel#event">:nrpn-dataentrycoarse</see>
        ///    * [<c>nrpn-dataentryfine</c>]<see href="InputChannel#event">:nrpn-dataentryfine</see>
        ///    * [<c>nrpn-dataincrement</c>]<see href="InputChannel#event">:nrpn-dataincrement</see>
        ///    * [<c>nrpn-datadecrement</c>]<see href="InputChannel#event">:nrpn-datadecrement</see>
        ///
        /// 8. **RPN** Events (channel-specific)
        ///
        ///    * [<c>rpn</c>]<see href="InputChannel#event">:rpn</see>
        ///    * [<c>rpn-dataentrycoarse</c>]<see href="InputChannel#event">:rpn-dataentrycoarse</see>
        ///    * [<c>rpn-dataentryfine</c>]<see href="InputChannel#event">:rpn-dataentryfine</see>
        ///    * [<c>rpn-dataincrement</c>]<see href="InputChannel#event">:rpn-dataincrement</see>
        ///    * [<c>rpn-datadecrement</c>]<see href="InputChannel#event">:rpn-datadecrement</see>
        /// </summary>
        /// <param name="event">
        /// The type of the event.
        /// </param>
        /// <param name="listener">
        /// A callback function to execute when the specified event is detected.
        /// This function will receive an event parameter object. For details on this object's properties,
        /// check out the documentation for the various events (links above).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// If the event is input-wide, a single [<c>Listener</c>](Listener)
        /// object is returned. If the event is channel-specific, an array of all the
        /// [<c>Listener</c>](Listener) objects is returned (one for each channel).
        /// </returns>
        abstract member addListener<'T>: e: Webmidi.InputEventMap.Key<'T> * listener: 'T * ?options: Input.addListener.options -> U2<Webmidi.Listener, ResizeArray<Webmidi.Listener>>
        /// <summary>
        /// Adds an event listener that will trigger a function callback when the specified event is
        /// dispatched. The event usually is **input-wide** but can also be **channel-specific**.
        ///
        /// Input-wide events do not target a specific MIDI channel so it makes sense to listen for them
        /// at the <c>Input</c> level and not at the [<c>InputChannel</c>](InputChannel) level. Channel-specific
        /// events target a specific channel. Usually, in this case, you would add the listener to the
        /// [<c>InputChannel</c>](InputChannel) object. However, as a convenience, you can also listen to
        /// channel-specific events directly on an <c>Input</c>. This allows you to react to a channel-specific
        /// event no matter which channel it actually came through.
        ///
        /// When listening for an event, you simply need to specify the event name and the function to
        /// execute:
        ///
        /// <code lang="javascript">
        /// const listener = WebMidi.inputs[0].addListener("midimessage", e => {
        ///   console.log(e);
        /// });
        /// </code>
        ///
        /// Calling the function with an input-wide event (such as
        /// [<c>"midimessage"</c>]<see href="#event:midimessage">#event:midimessage</see>), will return the [<c>Listener</c>](Listener) object
        /// that was created.
        ///
        /// If you call the function with a channel-specific event (such as
        /// [<c>"noteon"</c>]<see href="InputChannel#event">:noteon</see>), it will return an array of all
        /// [<c>Listener</c>](Listener) objects that were created (one for each channel):
        ///
        /// <code lang="javascript">
        /// const listeners = WebMidi.inputs[0].addListener("noteon", someFunction);
        /// </code>
        ///
        /// You can also specify which channels you want to add the listener to:
        ///
        /// <code lang="javascript">
        /// const listeners = WebMidi.inputs[0].addListener("noteon", someFunction, {channels: [1, 2, 3]});
        /// </code>
        ///
        /// In this case, <c>listeners</c> is an array containing 3 [<c>Listener</c>](Listener) objects.
        ///
        /// Note that, when adding channel-specific listeners, it is the [<c>InputChannel</c>](InputChannel)
        /// instance that actually gets a listener added and not the <c>Input</c> instance. You can check that
        /// by calling [<c>InputChannel.hasListener()</c>](InputChannel#hasListener()).
        ///
        /// There are 8 families of events you can listen to:
        ///
        /// 1. **MIDI System Common** Events (input-wide)
        ///
        ///    * [<c>songposition</c>]<see href="Input#event">:songposition</see>
        ///    * [<c>songselect</c>]<see href="Input#event">:songselect</see>
        ///    * [<c>sysex</c>]<see href="Input#event">:sysex</see>
        ///    * [<c>timecode</c>]<see href="Input#event">:timecode</see>
        ///    * [<c>tunerequest</c>]<see href="Input#event">:tunerequest</see>
        ///
        /// 2. **MIDI System Real-Time** Events (input-wide)
        ///
        ///    * [<c>clock</c>]<see href="Input#event">:clock</see>
        ///    * [<c>start</c>]<see href="Input#event">:start</see>
        ///    * [<c>continue</c>]<see href="Input#event">:continue</see>
        ///    * [<c>stop</c>]<see href="Input#event">:stop</see>
        ///    * [<c>activesensing</c>]<see href="Input#event">:activesensing</see>
        ///    * [<c>reset</c>]<see href="Input#event">:reset</see>
        ///
        /// 3. **State Change** Events (input-wide)
        ///
        ///    * [<c>opened</c>]<see href="Input#event">:opened</see>
        ///    * [<c>closed</c>]<see href="Input#event">:closed</see>
        ///    * [<c>disconnected</c>]<see href="Input#event">:disconnected</see>
        ///
        /// 4. **Catch-All** Events (input-wide)
        ///
        ///    * [<c>midimessage</c>]<see href="Input#event">:midimessage</see>
        ///    * [<c>unknownmidimessage</c>]<see href="Input#event">:unknownmidimessage</see>
        ///
        /// 5. **Channel Voice** Events (channel-specific)
        ///
        ///    * [<c>channelaftertouch</c>]<see href="InputChannel#event">:channelaftertouch</see>
        ///    * [<c>controlchange</c>]<see href="InputChannel#event">:controlchange</see>
        ///      * [<c>controlchange-controller0</c>]<see href="InputChannel#event">:controlchange-controller0</see>
        ///      * [<c>controlchange-controller1</c>]<see href="InputChannel#event">:controlchange-controller1</see>
        ///      * [<c>controlchange-controller2</c>]<see href="InputChannel#event">:controlchange-controller2</see>
        ///      * (...)
        ///      * [<c>controlchange-controller127</c>]<see href="InputChannel#event">:controlchange-controller127</see>
        ///    * [<c>keyaftertouch</c>]<see href="InputChannel#event">:keyaftertouch</see>
        ///    * [<c>noteoff</c>]<see href="InputChannel#event">:noteoff</see>
        ///    * [<c>noteon</c>]<see href="InputChannel#event">:noteon</see>
        ///    * [<c>pitchbend</c>]<see href="InputChannel#event">:pitchbend</see>
        ///    * [<c>programchange</c>]<see href="InputChannel#event">:programchange</see>
        ///
        ///    Note: you can listen for a specific control change message by using an event name like this:
        ///    <c>controlchange-controller23</c>, <c>controlchange-controller99</c>, <c>controlchange-controller122</c>,
        ///    etc.
        ///
        /// 6. **Channel Mode** Events (channel-specific)
        ///
        ///    * [<c>allnotesoff</c>]<see href="InputChannel#event">:allnotesoff</see>
        ///    * [<c>allsoundoff</c>]<see href="InputChannel#event">:allsoundoff</see>
        ///    * [<c>localcontrol</c>]<see href="InputChannel#event">:localcontrol</see>
        ///    * [<c>monomode</c>]<see href="InputChannel#event">:monomode</see>
        ///    * [<c>omnimode</c>]<see href="InputChannel#event">:omnimode</see>
        ///    * [<c>resetallcontrollers</c>]<see href="InputChannel#event">:resetallcontrollers</see>
        ///
        /// 7. **NRPN** Events (channel-specific)
        ///
        ///    * [<c>nrpn</c>]<see href="InputChannel#event">:nrpn</see>
        ///    * [<c>nrpn-dataentrycoarse</c>]<see href="InputChannel#event">:nrpn-dataentrycoarse</see>
        ///    * [<c>nrpn-dataentryfine</c>]<see href="InputChannel#event">:nrpn-dataentryfine</see>
        ///    * [<c>nrpn-dataincrement</c>]<see href="InputChannel#event">:nrpn-dataincrement</see>
        ///    * [<c>nrpn-datadecrement</c>]<see href="InputChannel#event">:nrpn-datadecrement</see>
        ///
        /// 8. **RPN** Events (channel-specific)
        ///
        ///    * [<c>rpn</c>]<see href="InputChannel#event">:rpn</see>
        ///    * [<c>rpn-dataentrycoarse</c>]<see href="InputChannel#event">:rpn-dataentrycoarse</see>
        ///    * [<c>rpn-dataentryfine</c>]<see href="InputChannel#event">:rpn-dataentryfine</see>
        ///    * [<c>rpn-dataincrement</c>]<see href="InputChannel#event">:rpn-dataincrement</see>
        ///    * [<c>rpn-datadecrement</c>]<see href="InputChannel#event">:rpn-datadecrement</see>
        /// </summary>
        /// <param name="event">
        /// The type of the event.
        /// </param>
        /// <param name="listener">
        /// A callback function to execute when the specified event is detected.
        /// This function will receive an event parameter object. For details on this object's properties,
        /// check out the documentation for the various events (links above).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// If the event is input-wide, a single [<c>Listener</c>](Listener)
        /// object is returned. If the event is channel-specific, an array of all the
        /// [<c>Listener</c>](Listener) objects is returned (one for each channel).
        /// </returns>
        abstract member addListener<'T>: e: U2<obj, Webmidi.InputEventMap.Key<'T>> * listener: 'T * ?options: Input.addListener.options -> U2<Webmidi.Listener, ResizeArray<Webmidi.Listener>>
        /// <summary>
        /// Adds a one-time event listener that will trigger a function callback when the specified event
        /// happens. The event can be **channel-bound** or **input-wide**. Channel-bound events are
        /// dispatched by [<c>InputChannel</c>]<see href="InputChannel">InputChannel</see> objects and are tied to a specific MIDI
        /// channel while input-wide events are dispatched by the <c>Input</c> object itself and are not tied
        /// to a specific channel.
        ///
        /// Calling the function with an input-wide event (such as
        /// [<c>"midimessage"</c>]<see href="#event:midimessage">#event:midimessage</see>), will return the [<c>Listener</c>](Listener) object
        /// that was created.
        ///
        /// If you call the function with a channel-specific event (such as
        /// [<c>"noteon"</c>]<see href="InputChannel#event">:noteon</see>), it will return an array of all
        /// [<c>Listener</c>](Listener) objects that were created (one for each channel):
        ///
        /// <code lang="javascript">
        /// const listeners = WebMidi.inputs[0].addOneTimeListener("noteon", someFunction);
        /// </code>
        ///
        /// You can also specify which channels you want to add the listener to:
        ///
        /// <code lang="javascript">
        /// const listeners = WebMidi.inputs[0].addOneTimeListener("noteon", someFunction, {channels: [1, 2, 3]});
        /// </code>
        ///
        /// In this case, the <c>listeners</c> variable contains an array of 3 [<c>Listener</c>](Listener) objects.
        ///
        /// The code above will add a listener for the <c>"noteon"</c> event and call <c>someFunction</c> when the
        /// event is triggered on MIDI channels <c>1</c>, <c>2</c> or <c>3</c>.
        ///
        /// Note that, when adding events to channels, it is the [<c>InputChannel</c>](InputChannel) instance
        /// that actually gets a listener added and not the <c>Input</c> instance.
        ///
        /// Note: if you want to add a listener to a single MIDI channel you should probably do so directly
        /// on the [<c>InputChannel</c>](InputChannel) object itself.
        ///
        /// There are 8 families of events you can listen to:
        ///
        /// 1. **MIDI System Common** Events (input-wide)
        ///
        ///    * [<c>songposition</c>]<see href="Input#event">:songposition</see>
        ///    * [<c>songselect</c>]<see href="Input#event">:songselect</see>
        ///    * [<c>sysex</c>]<see href="Input#event">:sysex</see>
        ///    * [<c>timecode</c>]<see href="Input#event">:timecode</see>
        ///    * [<c>tunerequest</c>]<see href="Input#event">:tunerequest</see>
        ///
        /// 2. **MIDI System Real-Time** Events (input-wide)
        ///
        ///    * [<c>clock</c>]<see href="Input#event">:clock</see>
        ///    * [<c>start</c>]<see href="Input#event">:start</see>
        ///    * [<c>continue</c>]<see href="Input#event">:continue</see>
        ///    * [<c>stop</c>]<see href="Input#event">:stop</see>
        ///    * [<c>activesensing</c>]<see href="Input#event">:activesensing</see>
        ///    * [<c>reset</c>]<see href="Input#event">:reset</see>
        ///
        /// 3. **State Change** Events (input-wide)
        ///
        ///    * [<c>opened</c>]<see href="Input#event">:opened</see>
        ///    * [<c>closed</c>]<see href="Input#event">:closed</see>
        ///    * [<c>disconnected</c>]<see href="Input#event">:disconnected</see>
        ///
        /// 4. **Catch-All** Events (input-wide)
        ///
        ///    * [<c>midimessage</c>]<see href="Input#event">:midimessage</see>
        ///    * [<c>unknownmidimessage</c>]<see href="Input#event">:unknownmidimessage</see>
        ///
        /// 5. **Channel Voice** Events (channel-specific)
        ///
        ///    * [<c>channelaftertouch</c>]<see href="InputChannel#event">:channelaftertouch</see>
        ///    * [<c>controlchange</c>]<see href="InputChannel#event">:controlchange</see>
        ///      * [<c>controlchange-controller0</c>]<see href="InputChannel#event">:controlchange-controller0</see>
        ///      * [<c>controlchange-controller1</c>]<see href="InputChannel#event">:controlchange-controller1</see>
        ///      * [<c>controlchange-controller2</c>]<see href="InputChannel#event">:controlchange-controller2</see>
        ///      * (...)
        ///      * [<c>controlchange-controller127</c>]<see href="InputChannel#event">:controlchange-controller127</see>
        ///    * [<c>keyaftertouch</c>]<see href="InputChannel#event">:keyaftertouch</see>
        ///    * [<c>noteoff</c>]<see href="InputChannel#event">:noteoff</see>
        ///    * [<c>noteon</c>]<see href="InputChannel#event">:noteon</see>
        ///    * [<c>pitchbend</c>]<see href="InputChannel#event">:pitchbend</see>
        ///    * [<c>programchange</c>]<see href="InputChannel#event">:programchange</see>
        ///
        ///    Note: you can listen for a specific control change message by using an event name like this:
        ///    <c>controlchange-controller23</c>, <c>controlchange-controller99</c>, <c>controlchange-controller122</c>,
        ///    etc.
        ///
        /// 6. **Channel Mode** Events (channel-specific)
        ///
        ///    * [<c>allnotesoff</c>]<see href="InputChannel#event">:allnotesoff</see>
        ///    * [<c>allsoundoff</c>]<see href="InputChannel#event">:allsoundoff</see>
        ///    * [<c>localcontrol</c>]<see href="InputChannel#event">:localcontrol</see>
        ///    * [<c>monomode</c>]<see href="InputChannel#event">:monomode</see>
        ///    * [<c>omnimode</c>]<see href="InputChannel#event">:omnimode</see>
        ///    * [<c>resetallcontrollers</c>]<see href="InputChannel#event">:resetallcontrollers</see>
        ///
        /// 7. **NRPN** Events (channel-specific)
        ///
        ///    * [<c>nrpn</c>]<see href="InputChannel#event">:nrpn</see>
        ///    * [<c>nrpn-dataentrycoarse</c>]<see href="InputChannel#event">:nrpn-dataentrycoarse</see>
        ///    * [<c>nrpn-dataentryfine</c>]<see href="InputChannel#event">:nrpn-dataentryfine</see>
        ///    * [<c>nrpn-dataincrement</c>]<see href="InputChannel#event">:nrpn-dataincrement</see>
        ///    * [<c>nrpn-datadecrement</c>]<see href="InputChannel#event">:nrpn-datadecrement</see>
        ///
        /// 8. **RPN** Events (channel-specific)
        ///
        ///    * [<c>rpn</c>]<see href="InputChannel#event">:rpn</see>
        ///    * [<c>rpn-dataentrycoarse</c>]<see href="InputChannel#event">:rpn-dataentrycoarse</see>
        ///    * [<c>rpn-dataentryfine</c>]<see href="InputChannel#event">:rpn-dataentryfine</see>
        ///    * [<c>rpn-dataincrement</c>]<see href="InputChannel#event">:rpn-dataincrement</see>
        ///    * [<c>rpn-datadecrement</c>]<see href="InputChannel#event">:rpn-datadecrement</see>
        /// </summary>
        /// <param name="event">
        /// The type of the event.
        /// </param>
        /// <param name="listener">
        /// A callback function to execute when the specified event
        /// is detected. This function will receive an event parameter object. For details on this object's
        /// properties, check out the documentation for the various events (links above).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// An array of all [<c>Listener</c>](Listener) objects that were
        /// created.
        /// </returns>
        abstract member addOneTimeListener<'T>: e: obj * listener: 'T * ?options: Input.addOneTimeListener.options -> U2<Webmidi.Listener, ResizeArray<Webmidi.Listener>>
        /// <summary>
        /// Adds a one-time event listener that will trigger a function callback when the specified event
        /// happens. The event can be **channel-bound** or **input-wide**. Channel-bound events are
        /// dispatched by [<c>InputChannel</c>]<see href="InputChannel">InputChannel</see> objects and are tied to a specific MIDI
        /// channel while input-wide events are dispatched by the <c>Input</c> object itself and are not tied
        /// to a specific channel.
        ///
        /// Calling the function with an input-wide event (such as
        /// [<c>"midimessage"</c>]<see href="#event:midimessage">#event:midimessage</see>), will return the [<c>Listener</c>](Listener) object
        /// that was created.
        ///
        /// If you call the function with a channel-specific event (such as
        /// [<c>"noteon"</c>]<see href="InputChannel#event">:noteon</see>), it will return an array of all
        /// [<c>Listener</c>](Listener) objects that were created (one for each channel):
        ///
        /// <code lang="javascript">
        /// const listeners = WebMidi.inputs[0].addOneTimeListener("noteon", someFunction);
        /// </code>
        ///
        /// You can also specify which channels you want to add the listener to:
        ///
        /// <code lang="javascript">
        /// const listeners = WebMidi.inputs[0].addOneTimeListener("noteon", someFunction, {channels: [1, 2, 3]});
        /// </code>
        ///
        /// In this case, the <c>listeners</c> variable contains an array of 3 [<c>Listener</c>](Listener) objects.
        ///
        /// The code above will add a listener for the <c>"noteon"</c> event and call <c>someFunction</c> when the
        /// event is triggered on MIDI channels <c>1</c>, <c>2</c> or <c>3</c>.
        ///
        /// Note that, when adding events to channels, it is the [<c>InputChannel</c>](InputChannel) instance
        /// that actually gets a listener added and not the <c>Input</c> instance.
        ///
        /// Note: if you want to add a listener to a single MIDI channel you should probably do so directly
        /// on the [<c>InputChannel</c>](InputChannel) object itself.
        ///
        /// There are 8 families of events you can listen to:
        ///
        /// 1. **MIDI System Common** Events (input-wide)
        ///
        ///    * [<c>songposition</c>]<see href="Input#event">:songposition</see>
        ///    * [<c>songselect</c>]<see href="Input#event">:songselect</see>
        ///    * [<c>sysex</c>]<see href="Input#event">:sysex</see>
        ///    * [<c>timecode</c>]<see href="Input#event">:timecode</see>
        ///    * [<c>tunerequest</c>]<see href="Input#event">:tunerequest</see>
        ///
        /// 2. **MIDI System Real-Time** Events (input-wide)
        ///
        ///    * [<c>clock</c>]<see href="Input#event">:clock</see>
        ///    * [<c>start</c>]<see href="Input#event">:start</see>
        ///    * [<c>continue</c>]<see href="Input#event">:continue</see>
        ///    * [<c>stop</c>]<see href="Input#event">:stop</see>
        ///    * [<c>activesensing</c>]<see href="Input#event">:activesensing</see>
        ///    * [<c>reset</c>]<see href="Input#event">:reset</see>
        ///
        /// 3. **State Change** Events (input-wide)
        ///
        ///    * [<c>opened</c>]<see href="Input#event">:opened</see>
        ///    * [<c>closed</c>]<see href="Input#event">:closed</see>
        ///    * [<c>disconnected</c>]<see href="Input#event">:disconnected</see>
        ///
        /// 4. **Catch-All** Events (input-wide)
        ///
        ///    * [<c>midimessage</c>]<see href="Input#event">:midimessage</see>
        ///    * [<c>unknownmidimessage</c>]<see href="Input#event">:unknownmidimessage</see>
        ///
        /// 5. **Channel Voice** Events (channel-specific)
        ///
        ///    * [<c>channelaftertouch</c>]<see href="InputChannel#event">:channelaftertouch</see>
        ///    * [<c>controlchange</c>]<see href="InputChannel#event">:controlchange</see>
        ///      * [<c>controlchange-controller0</c>]<see href="InputChannel#event">:controlchange-controller0</see>
        ///      * [<c>controlchange-controller1</c>]<see href="InputChannel#event">:controlchange-controller1</see>
        ///      * [<c>controlchange-controller2</c>]<see href="InputChannel#event">:controlchange-controller2</see>
        ///      * (...)
        ///      * [<c>controlchange-controller127</c>]<see href="InputChannel#event">:controlchange-controller127</see>
        ///    * [<c>keyaftertouch</c>]<see href="InputChannel#event">:keyaftertouch</see>
        ///    * [<c>noteoff</c>]<see href="InputChannel#event">:noteoff</see>
        ///    * [<c>noteon</c>]<see href="InputChannel#event">:noteon</see>
        ///    * [<c>pitchbend</c>]<see href="InputChannel#event">:pitchbend</see>
        ///    * [<c>programchange</c>]<see href="InputChannel#event">:programchange</see>
        ///
        ///    Note: you can listen for a specific control change message by using an event name like this:
        ///    <c>controlchange-controller23</c>, <c>controlchange-controller99</c>, <c>controlchange-controller122</c>,
        ///    etc.
        ///
        /// 6. **Channel Mode** Events (channel-specific)
        ///
        ///    * [<c>allnotesoff</c>]<see href="InputChannel#event">:allnotesoff</see>
        ///    * [<c>allsoundoff</c>]<see href="InputChannel#event">:allsoundoff</see>
        ///    * [<c>localcontrol</c>]<see href="InputChannel#event">:localcontrol</see>
        ///    * [<c>monomode</c>]<see href="InputChannel#event">:monomode</see>
        ///    * [<c>omnimode</c>]<see href="InputChannel#event">:omnimode</see>
        ///    * [<c>resetallcontrollers</c>]<see href="InputChannel#event">:resetallcontrollers</see>
        ///
        /// 7. **NRPN** Events (channel-specific)
        ///
        ///    * [<c>nrpn</c>]<see href="InputChannel#event">:nrpn</see>
        ///    * [<c>nrpn-dataentrycoarse</c>]<see href="InputChannel#event">:nrpn-dataentrycoarse</see>
        ///    * [<c>nrpn-dataentryfine</c>]<see href="InputChannel#event">:nrpn-dataentryfine</see>
        ///    * [<c>nrpn-dataincrement</c>]<see href="InputChannel#event">:nrpn-dataincrement</see>
        ///    * [<c>nrpn-datadecrement</c>]<see href="InputChannel#event">:nrpn-datadecrement</see>
        ///
        /// 8. **RPN** Events (channel-specific)
        ///
        ///    * [<c>rpn</c>]<see href="InputChannel#event">:rpn</see>
        ///    * [<c>rpn-dataentrycoarse</c>]<see href="InputChannel#event">:rpn-dataentrycoarse</see>
        ///    * [<c>rpn-dataentryfine</c>]<see href="InputChannel#event">:rpn-dataentryfine</see>
        ///    * [<c>rpn-dataincrement</c>]<see href="InputChannel#event">:rpn-dataincrement</see>
        ///    * [<c>rpn-datadecrement</c>]<see href="InputChannel#event">:rpn-datadecrement</see>
        /// </summary>
        /// <param name="event">
        /// The type of the event.
        /// </param>
        /// <param name="listener">
        /// A callback function to execute when the specified event
        /// is detected. This function will receive an event parameter object. For details on this object's
        /// properties, check out the documentation for the various events (links above).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// An array of all [<c>Listener</c>](Listener) objects that were
        /// created.
        /// </returns>
        abstract member addOneTimeListener<'T>: e: Webmidi.InputEventMap.Key<'T> * listener: 'T * ?options: Input.addOneTimeListener.options -> U2<Webmidi.Listener, ResizeArray<Webmidi.Listener>>
        /// <summary>
        /// Adds a one-time event listener that will trigger a function callback when the specified event
        /// happens. The event can be **channel-bound** or **input-wide**. Channel-bound events are
        /// dispatched by [<c>InputChannel</c>]<see href="InputChannel">InputChannel</see> objects and are tied to a specific MIDI
        /// channel while input-wide events are dispatched by the <c>Input</c> object itself and are not tied
        /// to a specific channel.
        ///
        /// Calling the function with an input-wide event (such as
        /// [<c>"midimessage"</c>]<see href="#event:midimessage">#event:midimessage</see>), will return the [<c>Listener</c>](Listener) object
        /// that was created.
        ///
        /// If you call the function with a channel-specific event (such as
        /// [<c>"noteon"</c>]<see href="InputChannel#event">:noteon</see>), it will return an array of all
        /// [<c>Listener</c>](Listener) objects that were created (one for each channel):
        ///
        /// <code lang="javascript">
        /// const listeners = WebMidi.inputs[0].addOneTimeListener("noteon", someFunction);
        /// </code>
        ///
        /// You can also specify which channels you want to add the listener to:
        ///
        /// <code lang="javascript">
        /// const listeners = WebMidi.inputs[0].addOneTimeListener("noteon", someFunction, {channels: [1, 2, 3]});
        /// </code>
        ///
        /// In this case, the <c>listeners</c> variable contains an array of 3 [<c>Listener</c>](Listener) objects.
        ///
        /// The code above will add a listener for the <c>"noteon"</c> event and call <c>someFunction</c> when the
        /// event is triggered on MIDI channels <c>1</c>, <c>2</c> or <c>3</c>.
        ///
        /// Note that, when adding events to channels, it is the [<c>InputChannel</c>](InputChannel) instance
        /// that actually gets a listener added and not the <c>Input</c> instance.
        ///
        /// Note: if you want to add a listener to a single MIDI channel you should probably do so directly
        /// on the [<c>InputChannel</c>](InputChannel) object itself.
        ///
        /// There are 8 families of events you can listen to:
        ///
        /// 1. **MIDI System Common** Events (input-wide)
        ///
        ///    * [<c>songposition</c>]<see href="Input#event">:songposition</see>
        ///    * [<c>songselect</c>]<see href="Input#event">:songselect</see>
        ///    * [<c>sysex</c>]<see href="Input#event">:sysex</see>
        ///    * [<c>timecode</c>]<see href="Input#event">:timecode</see>
        ///    * [<c>tunerequest</c>]<see href="Input#event">:tunerequest</see>
        ///
        /// 2. **MIDI System Real-Time** Events (input-wide)
        ///
        ///    * [<c>clock</c>]<see href="Input#event">:clock</see>
        ///    * [<c>start</c>]<see href="Input#event">:start</see>
        ///    * [<c>continue</c>]<see href="Input#event">:continue</see>
        ///    * [<c>stop</c>]<see href="Input#event">:stop</see>
        ///    * [<c>activesensing</c>]<see href="Input#event">:activesensing</see>
        ///    * [<c>reset</c>]<see href="Input#event">:reset</see>
        ///
        /// 3. **State Change** Events (input-wide)
        ///
        ///    * [<c>opened</c>]<see href="Input#event">:opened</see>
        ///    * [<c>closed</c>]<see href="Input#event">:closed</see>
        ///    * [<c>disconnected</c>]<see href="Input#event">:disconnected</see>
        ///
        /// 4. **Catch-All** Events (input-wide)
        ///
        ///    * [<c>midimessage</c>]<see href="Input#event">:midimessage</see>
        ///    * [<c>unknownmidimessage</c>]<see href="Input#event">:unknownmidimessage</see>
        ///
        /// 5. **Channel Voice** Events (channel-specific)
        ///
        ///    * [<c>channelaftertouch</c>]<see href="InputChannel#event">:channelaftertouch</see>
        ///    * [<c>controlchange</c>]<see href="InputChannel#event">:controlchange</see>
        ///      * [<c>controlchange-controller0</c>]<see href="InputChannel#event">:controlchange-controller0</see>
        ///      * [<c>controlchange-controller1</c>]<see href="InputChannel#event">:controlchange-controller1</see>
        ///      * [<c>controlchange-controller2</c>]<see href="InputChannel#event">:controlchange-controller2</see>
        ///      * (...)
        ///      * [<c>controlchange-controller127</c>]<see href="InputChannel#event">:controlchange-controller127</see>
        ///    * [<c>keyaftertouch</c>]<see href="InputChannel#event">:keyaftertouch</see>
        ///    * [<c>noteoff</c>]<see href="InputChannel#event">:noteoff</see>
        ///    * [<c>noteon</c>]<see href="InputChannel#event">:noteon</see>
        ///    * [<c>pitchbend</c>]<see href="InputChannel#event">:pitchbend</see>
        ///    * [<c>programchange</c>]<see href="InputChannel#event">:programchange</see>
        ///
        ///    Note: you can listen for a specific control change message by using an event name like this:
        ///    <c>controlchange-controller23</c>, <c>controlchange-controller99</c>, <c>controlchange-controller122</c>,
        ///    etc.
        ///
        /// 6. **Channel Mode** Events (channel-specific)
        ///
        ///    * [<c>allnotesoff</c>]<see href="InputChannel#event">:allnotesoff</see>
        ///    * [<c>allsoundoff</c>]<see href="InputChannel#event">:allsoundoff</see>
        ///    * [<c>localcontrol</c>]<see href="InputChannel#event">:localcontrol</see>
        ///    * [<c>monomode</c>]<see href="InputChannel#event">:monomode</see>
        ///    * [<c>omnimode</c>]<see href="InputChannel#event">:omnimode</see>
        ///    * [<c>resetallcontrollers</c>]<see href="InputChannel#event">:resetallcontrollers</see>
        ///
        /// 7. **NRPN** Events (channel-specific)
        ///
        ///    * [<c>nrpn</c>]<see href="InputChannel#event">:nrpn</see>
        ///    * [<c>nrpn-dataentrycoarse</c>]<see href="InputChannel#event">:nrpn-dataentrycoarse</see>
        ///    * [<c>nrpn-dataentryfine</c>]<see href="InputChannel#event">:nrpn-dataentryfine</see>
        ///    * [<c>nrpn-dataincrement</c>]<see href="InputChannel#event">:nrpn-dataincrement</see>
        ///    * [<c>nrpn-datadecrement</c>]<see href="InputChannel#event">:nrpn-datadecrement</see>
        ///
        /// 8. **RPN** Events (channel-specific)
        ///
        ///    * [<c>rpn</c>]<see href="InputChannel#event">:rpn</see>
        ///    * [<c>rpn-dataentrycoarse</c>]<see href="InputChannel#event">:rpn-dataentrycoarse</see>
        ///    * [<c>rpn-dataentryfine</c>]<see href="InputChannel#event">:rpn-dataentryfine</see>
        ///    * [<c>rpn-dataincrement</c>]<see href="InputChannel#event">:rpn-dataincrement</see>
        ///    * [<c>rpn-datadecrement</c>]<see href="InputChannel#event">:rpn-datadecrement</see>
        /// </summary>
        /// <param name="event">
        /// The type of the event.
        /// </param>
        /// <param name="listener">
        /// A callback function to execute when the specified event
        /// is detected. This function will receive an event parameter object. For details on this object's
        /// properties, check out the documentation for the various events (links above).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// An array of all [<c>Listener</c>](Listener) objects that were
        /// created.
        /// </returns>
        abstract member addOneTimeListener<'T>: e: U2<obj, Webmidi.InputEventMap.Key<'T>> * listener: 'T * ?options: Input.addOneTimeListener.options -> U2<Webmidi.Listener, ResizeArray<Webmidi.Listener>>
        /// <summary>
        /// Closes the input. When an input is closed, it cannot be used to listen to MIDI messages until
        /// the input is opened again by calling [<c>Input.open()</c>](Input#open).
        ///
        /// **Note**: if what you want to do is stop events from being dispatched, you should use
        /// [<c>eventsSuspended</c>](#eventsSuspended) instead.
        /// </summary>
        /// <returns>
        /// The promise is fulfilled with the <c>Input</c> object
        /// </returns>
        abstract member close: unit -> JS.Promise<Webmidi.Input>
        /// <summary>
        /// Destroys the <c>Input</c> by removing all listeners, emptying the [<c>channels</c>](#channels) array and
        /// unlinking the MIDI subsystem. This is mostly for internal use.
        /// </summary>
        abstract member destroy: unit -> JS.Promise<unit>
        /// <summary>
        /// Checks whether the specified [<c>Forwarder</c>](Forwarder) object has already been attached to this
        /// input.
        /// </summary>
        /// <param name="forwarder">
        /// The [<c>Forwarder</c>](Forwarder) to check for (the
        /// [<c>Forwarder</c>](Forwarder) object is returned when calling [<c>addForwarder()</c>](#addForwarder).
        /// </param>
        abstract member hasForwarder: forwarder: Webmidi.Forwarder -> bool
        /// <summary>
        /// Checks if the specified event type is already defined to trigger the specified callback
        /// function. For channel-specific events, the function will return <c>true</c> only if all channels
        /// have the listener defined.
        /// </summary>
        /// <param name="event">
        /// The type of the event.
        /// </param>
        /// <param name="listener">
        /// The callback function to check for.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Boolean value indicating whether or not the <c>Input</c> or <c>InputChannel</c>
        /// already has this listener defined.
        /// </returns>
        abstract member hasListener<'T>: e: obj * listener: 'T * ?options: Input.hasListener.options -> bool
        /// <summary>
        /// Checks if the specified event type is already defined to trigger the specified callback
        /// function. For channel-specific events, the function will return <c>true</c> only if all channels
        /// have the listener defined.
        /// </summary>
        /// <param name="event">
        /// The type of the event.
        /// </param>
        /// <param name="listener">
        /// The callback function to check for.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Boolean value indicating whether or not the <c>Input</c> or <c>InputChannel</c>
        /// already has this listener defined.
        /// </returns>
        abstract member hasListener<'T>: e: Webmidi.InputEventMap.Key<'T> * listener: 'T * ?options: Input.hasListener.options -> bool
        /// <summary>
        /// Checks if the specified event type is already defined to trigger the specified callback
        /// function. For channel-specific events, the function will return <c>true</c> only if all channels
        /// have the listener defined.
        /// </summary>
        /// <param name="event">
        /// The type of the event.
        /// </param>
        /// <param name="listener">
        /// The callback function to check for.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Boolean value indicating whether or not the <c>Input</c> or <c>InputChannel</c>
        /// already has this listener defined.
        /// </returns>
        abstract member hasListener<'T>: e: U2<obj, Webmidi.InputEventMap.Key<'T>> * listener: 'T * ?options: Input.hasListener.options -> bool
        /// <summary>
        /// Opens the input for usage. This is usually unnecessary as the port is opened automatically when
        /// WebMidi is enabled.
        /// </summary>
        /// <returns>
        /// The promise is fulfilled with the <c>Input</c> object.
        /// </returns>
        abstract member ``open``: unit -> JS.Promise<Webmidi.Input>
        /// <summary>
        /// Removes the specified [<c>Forwarder</c>](Forwarder) object from the input.
        /// </summary>
        /// <param name="forwarder">
        /// The [<c>Forwarder</c>](Forwarder) to remove (the
        /// [<c>Forwarder</c>](Forwarder) object is returned when calling <c>addForwarder()</c>.
        /// </param>
        abstract member removeForwarder: forwarder: Webmidi.Forwarder -> unit
        /// <summary>
        /// Removes the specified listener for the specified event. If no listener is specified, all
        /// listeners for the specified event will be removed. If no event is specified, all listeners for
        /// the <c>Input</c> as well as all listeners for all [<c>InputChannel</c>]<see href="InputChannel">InputChannel</see> objects will
        /// be removed.
        ///
        /// By default, channel-specific listeners will be removed from all channels unless the
        /// <c>options.channel</c> narrows it down.
        /// </summary>
        /// <param name="type">
        /// The type of the event.
        /// </param>
        /// <param name="listener">
        /// The callback function to check for.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        abstract member removeListener: unit -> unit
        /// <summary>
        /// Removes the specified listener for the specified event. If no listener is specified, all
        /// listeners for the specified event will be removed. If no event is specified, all listeners for
        /// the <c>Input</c> as well as all listeners for all [<c>InputChannel</c>]<see href="InputChannel">InputChannel</see> objects will
        /// be removed.
        ///
        /// By default, channel-specific listeners will be removed from all channels unless the
        /// <c>options.channel</c> narrows it down.
        /// </summary>
        /// <param name="type">
        /// The type of the event.
        /// </param>
        /// <param name="listener">
        /// The callback function to check for.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        abstract member removeListener<'T>: ``type``: obj * ?listener: 'T * ?options: Input.removeListener.options -> unit
        /// <summary>
        /// Removes the specified listener for the specified event. If no listener is specified, all
        /// listeners for the specified event will be removed. If no event is specified, all listeners for
        /// the <c>Input</c> as well as all listeners for all [<c>InputChannel</c>]<see href="InputChannel">InputChannel</see> objects will
        /// be removed.
        ///
        /// By default, channel-specific listeners will be removed from all channels unless the
        /// <c>options.channel</c> narrows it down.
        /// </summary>
        /// <param name="type">
        /// The type of the event.
        /// </param>
        /// <param name="listener">
        /// The callback function to check for.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        abstract member removeListener<'T>: ``type``: Webmidi.InputEventMap.Key<'T> * ?listener: 'T * ?options: Input.removeListener.options -> unit
        /// <summary>
        /// Input port's connection state: <c>pending</c>, <c>open</c> or <c>closed</c>.
        /// </summary>
        abstract member connection: Webmidi.WebMidiApi_.MIDIPortConnectionState with get
        /// <summary>
        /// ID string of the MIDI port. The ID is host-specific. Do not expect the same ID on different
        /// platforms. For example, Google Chrome and the Jazz-Plugin report completely different IDs for
        /// the same port.
        /// </summary>
        abstract member id: string with get
        /// <summary>
        /// Name of the manufacturer of the device that makes this input port available.
        /// </summary>
        abstract member manufacturer: string with get
        /// <summary>
        /// Name of the MIDI input.
        /// </summary>
        abstract member name: string with get
        /// <summary>
        /// An integer to offset the reported octave of incoming notes. By default, middle C (MIDI note
        /// number 60) is placed on the 4th octave (C4).
        ///
        /// If, for example, <c>octaveOffset</c> is set to 2, MIDI note number 60 will be reported as C6. If
        /// <c>octaveOffset</c> is set to -1, MIDI note number 60 will be reported as C3.
        ///
        /// Note that this value is combined with the global offset value defined in the
        /// [<c>WebMidi.octaveOffset</c>](WebMidi#octaveOffset) property (if any).
        /// </summary>
        abstract member octaveOffset: float with get, set
        /// <summary>
        /// State of the input port: <c>connected</c> or <c>disconnected</c>.
        /// </summary>
        abstract member state: Webmidi.WebMidiApi_.MIDIPortDeviceState with get
        /// <summary>
        /// The port type. In the case of the <c>Input</c> object, this is always: <c>input</c>.
        /// </summary>
        abstract member ``type``: Webmidi.WebMidiApi_.MIDIPortType with get
        /// <summary>
        /// Identifier (Symbol) to use when adding or removing a listener that should be triggered when any
        /// events occur.
        /// </summary>
        static member inline ANY_EVENT
            with get () : obj =
                nativeOnly
        /// <summary>
        /// An object containing a property for each event with at least one registered listener. Each
        /// event property contains an array of all the [<c>Listener</c>]<see href="Listener">Listener</see> objects registered
        /// for the event.
        /// </summary>
        abstract member eventMap: obj with get, set
        /// <summary>
        /// Whether or not the execution of callbacks is currently suspended for this emitter.
        /// </summary>
        abstract member eventsSuspended: bool with get, set
        /// <summary>
        /// An array of all the unique event names for which the emitter has at least one registered
        /// listener.
        ///
        /// Note: this excludes global events registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> because they are not tied to a
        /// specific event.
        /// </summary>
        abstract member eventNames: ResizeArray<string> with get
        /// <summary>
        /// Returns an array of all the [<c>Listener</c>]<see href="Listener">Listener</see> objects that have been registered for
        /// a specific event.
        ///
        /// Please note that global events (those added with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>) are not returned for "regular"
        /// events. To get the list of global listeners, specifically use
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> as the parameter.
        /// </summary>
        /// <param name="event">
        /// The event to get listeners for.
        /// </param>
        /// <returns>
        /// An array of [<c>Listener</c>]<see href="Listener">Listener</see> objects.
        /// </returns>
        abstract member getListeners: event: string -> ResizeArray<Webmidi.Listener>
        /// <summary>
        /// Returns an array of all the [<c>Listener</c>]<see href="Listener">Listener</see> objects that have been registered for
        /// a specific event.
        ///
        /// Please note that global events (those added with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>) are not returned for "regular"
        /// events. To get the list of global listeners, specifically use
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> as the parameter.
        /// </summary>
        /// <param name="event">
        /// The event to get listeners for.
        /// </param>
        /// <returns>
        /// An array of [<c>Listener</c>]<see href="Listener">Listener</see> objects.
        /// </returns>
        abstract member getListeners: event: obj -> ResizeArray<Webmidi.Listener>
        /// <summary>
        /// Returns an array of all the [<c>Listener</c>]<see href="Listener">Listener</see> objects that have been registered for
        /// a specific event.
        ///
        /// Please note that global events (those added with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>) are not returned for "regular"
        /// events. To get the list of global listeners, specifically use
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> as the parameter.
        /// </summary>
        /// <param name="event">
        /// The event to get listeners for.
        /// </param>
        /// <returns>
        /// An array of [<c>Listener</c>]<see href="Listener">Listener</see> objects.
        /// </returns>
        abstract member getListeners: event: U2<string, obj> -> ResizeArray<Webmidi.Listener>
        /// <summary>
        /// Suspends execution of all callbacks functions registered for the specified event type.
        ///
        /// You can suspend execution of callbacks registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> by passing
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> to <c>suspendEvent()</c>. Beware that this
        /// will not suspend all callbacks but only those registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>. While this may seem counter-intuitive
        /// at first glance, it allows the selective suspension of global listeners while leaving other
        /// listeners alone. If you truly want to suspends all callbacks for a specific
        /// [<c>EventEmitter</c>]<see href="EventEmitter">EventEmitter</see>, simply set its <c>eventsSuspended</c> property to <c>true</c>.
        /// </summary>
        /// <param name="event">
        /// The event name (or <c>EventEmitter.ANY_EVENT</c>) for which to suspend
        /// execution of all callback functions.
        /// </param>
        abstract member suspendEvent: event: string -> unit
        /// <summary>
        /// Suspends execution of all callbacks functions registered for the specified event type.
        ///
        /// You can suspend execution of callbacks registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> by passing
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> to <c>suspendEvent()</c>. Beware that this
        /// will not suspend all callbacks but only those registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>. While this may seem counter-intuitive
        /// at first glance, it allows the selective suspension of global listeners while leaving other
        /// listeners alone. If you truly want to suspends all callbacks for a specific
        /// [<c>EventEmitter</c>]<see href="EventEmitter">EventEmitter</see>, simply set its <c>eventsSuspended</c> property to <c>true</c>.
        /// </summary>
        /// <param name="event">
        /// The event name (or <c>EventEmitter.ANY_EVENT</c>) for which to suspend
        /// execution of all callback functions.
        /// </param>
        abstract member suspendEvent: event: obj -> unit
        /// <summary>
        /// Suspends execution of all callbacks functions registered for the specified event type.
        ///
        /// You can suspend execution of callbacks registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> by passing
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> to <c>suspendEvent()</c>. Beware that this
        /// will not suspend all callbacks but only those registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>. While this may seem counter-intuitive
        /// at first glance, it allows the selective suspension of global listeners while leaving other
        /// listeners alone. If you truly want to suspends all callbacks for a specific
        /// [<c>EventEmitter</c>]<see href="EventEmitter">EventEmitter</see>, simply set its <c>eventsSuspended</c> property to <c>true</c>.
        /// </summary>
        /// <param name="event">
        /// The event name (or <c>EventEmitter.ANY_EVENT</c>) for which to suspend
        /// execution of all callback functions.
        /// </param>
        abstract member suspendEvent: event: U2<string, obj> -> unit
        /// <summary>
        /// Resumes execution of all suspended callback functions registered for the specified event type.
        ///
        /// You can resume execution of callbacks registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> by passing
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> to <c>unsuspendEvent()</c>. Beware that
        /// this will not resume all callbacks but only those registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>. While this may seem
        /// counter-intuitive, it allows the selective unsuspension of global listeners while leaving other
        /// callbacks alone.
        /// </summary>
        /// <param name="event">
        /// The event name (or <c>EventEmitter.ANY_EVENT</c>) for which to resume
        /// execution of all callback functions.
        /// </param>
        abstract member unsuspendEvent: event: string -> unit
        /// <summary>
        /// Resumes execution of all suspended callback functions registered for the specified event type.
        ///
        /// You can resume execution of callbacks registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> by passing
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> to <c>unsuspendEvent()</c>. Beware that
        /// this will not resume all callbacks but only those registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>. While this may seem
        /// counter-intuitive, it allows the selective unsuspension of global listeners while leaving other
        /// callbacks alone.
        /// </summary>
        /// <param name="event">
        /// The event name (or <c>EventEmitter.ANY_EVENT</c>) for which to resume
        /// execution of all callback functions.
        /// </param>
        abstract member unsuspendEvent: event: obj -> unit
        /// <summary>
        /// Resumes execution of all suspended callback functions registered for the specified event type.
        ///
        /// You can resume execution of callbacks registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> by passing
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> to <c>unsuspendEvent()</c>. Beware that
        /// this will not resume all callbacks but only those registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>. While this may seem
        /// counter-intuitive, it allows the selective unsuspension of global listeners while leaving other
        /// callbacks alone.
        /// </summary>
        /// <param name="event">
        /// The event name (or <c>EventEmitter.ANY_EVENT</c>) for which to resume
        /// execution of all callback functions.
        /// </param>
        abstract member unsuspendEvent: event: U2<string, obj> -> unit
        /// <summary>
        /// Returns the number of listeners registered for a specific event.
        ///
        /// Please note that global events (those added with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>) do not count towards the remaining
        /// number for a "regular" event. To get the number of global listeners, specifically use
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> as the parameter.
        /// </summary>
        /// <param name="event">
        /// The event which is usually a string but can also be the special
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> symbol.
        /// </param>
        /// <returns>
        /// An integer representing the number of listeners registered for the specified
        /// event.
        /// </returns>
        abstract member getListenerCount: event: string -> float
        /// <summary>
        /// Returns the number of listeners registered for a specific event.
        ///
        /// Please note that global events (those added with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>) do not count towards the remaining
        /// number for a "regular" event. To get the number of global listeners, specifically use
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> as the parameter.
        /// </summary>
        /// <param name="event">
        /// The event which is usually a string but can also be the special
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> symbol.
        /// </param>
        /// <returns>
        /// An integer representing the number of listeners registered for the specified
        /// event.
        /// </returns>
        abstract member getListenerCount: event: obj -> float
        /// <summary>
        /// Returns the number of listeners registered for a specific event.
        ///
        /// Please note that global events (those added with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>) do not count towards the remaining
        /// number for a "regular" event. To get the number of global listeners, specifically use
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> as the parameter.
        /// </summary>
        /// <param name="event">
        /// The event which is usually a string but can also be the special
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> symbol.
        /// </param>
        /// <returns>
        /// An integer representing the number of listeners registered for the specified
        /// event.
        /// </returns>
        abstract member getListenerCount: event: U2<string, obj> -> float
        /// <summary>
        /// Executes the callback function of all the [<c>Listener</c>]<see href="Listener">Listener</see> objects registered for
        /// a given event. The callback functions are passed the additional arguments passed to <c>emit()</c>
        /// (if any) followed by the arguments present in the [<c>arguments</c>](Listener#arguments) property of
        /// the [<c>Listener</c>](Listener) object (if any).
        ///
        /// If the [<c>eventsSuspended</c>]<see href="#eventsSuspended">#eventsSuspended</see> property is <c>true</c> or the
        /// [<c>Listener.suspended</c>]<see href="Listener#suspended">Listener#suspended</see> property is <c>true</c>, the callback functions
        /// will not be executed.
        ///
        /// This function returns an array containing the return values of each of the callbacks.
        ///
        /// It should be noted that the regular listeners are triggered first followed by the global
        /// listeners (those added with [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>).
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// The <c>event</c> parameter must be a string.
        /// </remarks>
        /// <param name="event">
        /// The event
        /// </param>
        /// <param name="args">
        /// Arbitrary number of arguments to pass along to the callback functions
        /// </param>
        /// <returns>
        /// An array containing the return value of each of the executed listener
        /// functions.
        /// </returns>
        abstract member emit: event: string * [<ParamArray>] args: obj [] -> ResizeArray<obj>
        /// <summary>
        /// The <c>waitFor()</c> method is an async function which returns a promise. The promise is fulfilled
        /// when the specified event occurs. The event can be a regular event or
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> (if you want to resolve as soon as any
        /// event is emitted).
        ///
        /// If the <c>duration</c> option is set, the promise will only be fulfilled if the event is emitted
        /// within the specified duration. If the event has not been fulfilled after the specified
        /// duration, the promise is rejected. This makes it super easy to wait for an event and timeout
        /// after a certain time if the event is not triggered.
        /// </summary>
        /// <param name="event">
        /// The event to wait for
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        abstract member waitFor: event: string * ?options: EventEmitter.waitFor.options -> JS.Promise<obj>
        /// <summary>
        /// The <c>waitFor()</c> method is an async function which returns a promise. The promise is fulfilled
        /// when the specified event occurs. The event can be a regular event or
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> (if you want to resolve as soon as any
        /// event is emitted).
        ///
        /// If the <c>duration</c> option is set, the promise will only be fulfilled if the event is emitted
        /// within the specified duration. If the event has not been fulfilled after the specified
        /// duration, the promise is rejected. This makes it super easy to wait for an event and timeout
        /// after a certain time if the event is not triggered.
        /// </summary>
        /// <param name="event">
        /// The event to wait for
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        abstract member waitFor: event: obj * ?options: EventEmitter.waitFor.options -> JS.Promise<obj>
        /// <summary>
        /// The <c>waitFor()</c> method is an async function which returns a promise. The promise is fulfilled
        /// when the specified event occurs. The event can be a regular event or
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> (if you want to resolve as soon as any
        /// event is emitted).
        ///
        /// If the <c>duration</c> option is set, the promise will only be fulfilled if the event is emitted
        /// within the specified duration. If the event has not been fulfilled after the specified
        /// duration, the promise is rejected. This makes it super easy to wait for an event and timeout
        /// after a certain time if the event is not triggered.
        /// </summary>
        /// <param name="event">
        /// The event to wait for
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        abstract member waitFor: event: U2<string, obj> * ?options: EventEmitter.waitFor.options -> JS.Promise<obj>
        /// <summary>
        /// The number of unique events that have registered listeners.
        ///
        /// Note: this excludes global events registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> because they are not tied to a
        /// specific event.
        /// </summary>
        abstract member eventCount: float with get

    /// <summary>
    /// The <c>InputChannel</c> class represents a single MIDI input channel (1-16) from a single input
    /// device. This object is derived from the host's MIDI subsystem and should not be instantiated
    /// directly.
    ///
    /// All 16 <c>InputChannel</c> objects can be found inside the input's [<c>channels</c>](Input#channels)
    /// property.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("InputChannel", "webmidi")>]
    type InputChannel =
        /// <summary>
        /// Contains the current playing state of all MIDI notes of this channel (0-127). The state is
        /// <c>true</c> for a currently playing note and <c>false</c> otherwise.
        /// </summary>
        abstract member notesState: ResizeArray<bool> with get, set
        /// <summary>
        /// Indicates whether events for **Registered Parameter Number** and **Non-Registered Parameter
        /// Number** should be dispatched. RPNs and NRPNs are composed of a sequence of specific
        /// **control change** messages. When a valid sequence of such control change messages is
        /// received, an [<c>rpn</c>](#event-rpn) or [<c>nrpn</c>](#event-nrpn) event will fire.
        ///
        /// If an invalid or out-of-order **control change** message is received, it will fall through
        /// the collector logic and all buffered **control change** messages will be discarded as
        /// incomplete.
        /// </summary>
        abstract member parameterNumberEventsEnabled: bool with get, set
        /// <summary>
        /// Adds an event listener that will trigger a function callback when the specified event is
        /// dispatched.
        ///
        /// Here are the events you can listen to:
        ///
        /// **Channel Voice** Events
        ///
        ///    * [<c>channelaftertouch</c>]<see href="InputChannel#event">:channelaftertouch</see>
        ///    * [<c>controlchange</c>]<see href="InputChannel#event">:controlchange</see>
        ///      * [<c>controlchange-controller0</c>]<see href="InputChannel#event">:controlchange-controller0</see>
        ///      * [<c>controlchange-controller1</c>]<see href="InputChannel#event">:controlchange-controller1</see>
        ///      * [<c>controlchange-controller2</c>]<see href="InputChannel#event">:controlchange-controller2</see>
        ///      * (...)
        ///      * [<c>controlchange-controller127</c>]<see href="InputChannel#event">:controlchange-controller127</see>
        ///    * [<c>keyaftertouch</c>]<see href="InputChannel#event">:keyaftertouch</see>
        ///    * [<c>noteoff</c>]<see href="InputChannel#event">:noteoff</see>
        ///    * [<c>noteon</c>]<see href="InputChannel#event">:noteon</see>
        ///    * [<c>pitchbend</c>]<see href="InputChannel#event">:pitchbend</see>
        ///    * [<c>programchange</c>]<see href="InputChannel#event">:programchange</see>
        ///
        ///    Note: you can listen for a specific control change message by using an event name like this:
        ///    <c>controlchange-controller23</c>, <c>controlchange-controller99</c>, <c>controlchange-controller122</c>,
        ///    etc.
        ///
        /// **Channel Mode** Events
        ///
        ///    * [<c>allnotesoff</c>]<see href="InputChannel#event">:allnotesoff</see>
        ///    * [<c>allsoundoff</c>]<see href="InputChannel#event">:allsoundoff</see>
        ///    * [<c>localcontrol</c>]<see href="InputChannel#event">:localcontrol</see>
        ///    * [<c>monomode</c>]<see href="InputChannel#event">:monomode</see>
        ///    * [<c>omnimode</c>]<see href="InputChannel#event">:omnimode</see>
        ///    * [<c>resetallcontrollers</c>]<see href="InputChannel#event">:resetallcontrollers</see>
        ///
        /// **NRPN** Events
        ///
        ///    * [<c>nrpn</c>]<see href="InputChannel#event">:nrpn</see>
        ///    * [<c>nrpn-dataentrycoarse</c>]<see href="InputChannel#event">:nrpn-dataentrycoarse</see>
        ///    * [<c>nrpn-dataentryfine</c>]<see href="InputChannel#event">:nrpn-dataentryfine</see>
        ///    * [<c>nrpn-dataincrement</c>]<see href="InputChannel#event">:nrpn-dataincrement</see>
        ///    * [<c>nrpn-datadecrement</c>]<see href="InputChannel#event">:nrpn-datadecrement</see>
        ///
        /// **RPN** Events
        ///
        ///    * [<c>rpn</c>]<see href="InputChannel#event">:rpn</see>
        ///    * [<c>rpn-dataentrycoarse</c>]<see href="InputChannel#event">:rpn-dataentrycoarse</see>
        ///    * [<c>rpn-dataentryfine</c>]<see href="InputChannel#event">:rpn-dataentryfine</see>
        ///    * [<c>rpn-dataincrement</c>]<see href="InputChannel#event">:rpn-dataincrement</see>
        ///    * [<c>rpn-datadecrement</c>]<see href="InputChannel#event">:rpn-datadecrement</see>
        /// </summary>
        /// <param name="event">
        /// The type of the event.
        /// </param>
        /// <param name="listener">
        /// A callback function to execute when the specified event
        /// is detected. This function will receive an event parameter object. For details on this object's
        /// properties, check out the documentation for the various events (links above).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// The listener object that was created
        /// </returns>
        abstract member addListener<'T>: e: obj * listener: 'T * ?options: InputChannel.addListener.options -> Webmidi.Listener
        /// <summary>
        /// Adds an event listener that will trigger a function callback when the specified event is
        /// dispatched.
        ///
        /// Here are the events you can listen to:
        ///
        /// **Channel Voice** Events
        ///
        ///    * [<c>channelaftertouch</c>]<see href="InputChannel#event">:channelaftertouch</see>
        ///    * [<c>controlchange</c>]<see href="InputChannel#event">:controlchange</see>
        ///      * [<c>controlchange-controller0</c>]<see href="InputChannel#event">:controlchange-controller0</see>
        ///      * [<c>controlchange-controller1</c>]<see href="InputChannel#event">:controlchange-controller1</see>
        ///      * [<c>controlchange-controller2</c>]<see href="InputChannel#event">:controlchange-controller2</see>
        ///      * (...)
        ///      * [<c>controlchange-controller127</c>]<see href="InputChannel#event">:controlchange-controller127</see>
        ///    * [<c>keyaftertouch</c>]<see href="InputChannel#event">:keyaftertouch</see>
        ///    * [<c>noteoff</c>]<see href="InputChannel#event">:noteoff</see>
        ///    * [<c>noteon</c>]<see href="InputChannel#event">:noteon</see>
        ///    * [<c>pitchbend</c>]<see href="InputChannel#event">:pitchbend</see>
        ///    * [<c>programchange</c>]<see href="InputChannel#event">:programchange</see>
        ///
        ///    Note: you can listen for a specific control change message by using an event name like this:
        ///    <c>controlchange-controller23</c>, <c>controlchange-controller99</c>, <c>controlchange-controller122</c>,
        ///    etc.
        ///
        /// **Channel Mode** Events
        ///
        ///    * [<c>allnotesoff</c>]<see href="InputChannel#event">:allnotesoff</see>
        ///    * [<c>allsoundoff</c>]<see href="InputChannel#event">:allsoundoff</see>
        ///    * [<c>localcontrol</c>]<see href="InputChannel#event">:localcontrol</see>
        ///    * [<c>monomode</c>]<see href="InputChannel#event">:monomode</see>
        ///    * [<c>omnimode</c>]<see href="InputChannel#event">:omnimode</see>
        ///    * [<c>resetallcontrollers</c>]<see href="InputChannel#event">:resetallcontrollers</see>
        ///
        /// **NRPN** Events
        ///
        ///    * [<c>nrpn</c>]<see href="InputChannel#event">:nrpn</see>
        ///    * [<c>nrpn-dataentrycoarse</c>]<see href="InputChannel#event">:nrpn-dataentrycoarse</see>
        ///    * [<c>nrpn-dataentryfine</c>]<see href="InputChannel#event">:nrpn-dataentryfine</see>
        ///    * [<c>nrpn-dataincrement</c>]<see href="InputChannel#event">:nrpn-dataincrement</see>
        ///    * [<c>nrpn-datadecrement</c>]<see href="InputChannel#event">:nrpn-datadecrement</see>
        ///
        /// **RPN** Events
        ///
        ///    * [<c>rpn</c>]<see href="InputChannel#event">:rpn</see>
        ///    * [<c>rpn-dataentrycoarse</c>]<see href="InputChannel#event">:rpn-dataentrycoarse</see>
        ///    * [<c>rpn-dataentryfine</c>]<see href="InputChannel#event">:rpn-dataentryfine</see>
        ///    * [<c>rpn-dataincrement</c>]<see href="InputChannel#event">:rpn-dataincrement</see>
        ///    * [<c>rpn-datadecrement</c>]<see href="InputChannel#event">:rpn-datadecrement</see>
        /// </summary>
        /// <param name="event">
        /// The type of the event.
        /// </param>
        /// <param name="listener">
        /// A callback function to execute when the specified event
        /// is detected. This function will receive an event parameter object. For details on this object's
        /// properties, check out the documentation for the various events (links above).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// The listener object that was created
        /// </returns>
        abstract member addListener<'T>: e: Webmidi.InputChannelEventMap.Key<'T> * listener: 'T * ?options: InputChannel.addListener.options -> Webmidi.Listener
        /// <summary>
        /// Adds an event listener that will trigger a function callback when the specified event is
        /// dispatched.
        ///
        /// Here are the events you can listen to:
        ///
        /// **Channel Voice** Events
        ///
        ///    * [<c>channelaftertouch</c>]<see href="InputChannel#event">:channelaftertouch</see>
        ///    * [<c>controlchange</c>]<see href="InputChannel#event">:controlchange</see>
        ///      * [<c>controlchange-controller0</c>]<see href="InputChannel#event">:controlchange-controller0</see>
        ///      * [<c>controlchange-controller1</c>]<see href="InputChannel#event">:controlchange-controller1</see>
        ///      * [<c>controlchange-controller2</c>]<see href="InputChannel#event">:controlchange-controller2</see>
        ///      * (...)
        ///      * [<c>controlchange-controller127</c>]<see href="InputChannel#event">:controlchange-controller127</see>
        ///    * [<c>keyaftertouch</c>]<see href="InputChannel#event">:keyaftertouch</see>
        ///    * [<c>noteoff</c>]<see href="InputChannel#event">:noteoff</see>
        ///    * [<c>noteon</c>]<see href="InputChannel#event">:noteon</see>
        ///    * [<c>pitchbend</c>]<see href="InputChannel#event">:pitchbend</see>
        ///    * [<c>programchange</c>]<see href="InputChannel#event">:programchange</see>
        ///
        ///    Note: you can listen for a specific control change message by using an event name like this:
        ///    <c>controlchange-controller23</c>, <c>controlchange-controller99</c>, <c>controlchange-controller122</c>,
        ///    etc.
        ///
        /// **Channel Mode** Events
        ///
        ///    * [<c>allnotesoff</c>]<see href="InputChannel#event">:allnotesoff</see>
        ///    * [<c>allsoundoff</c>]<see href="InputChannel#event">:allsoundoff</see>
        ///    * [<c>localcontrol</c>]<see href="InputChannel#event">:localcontrol</see>
        ///    * [<c>monomode</c>]<see href="InputChannel#event">:monomode</see>
        ///    * [<c>omnimode</c>]<see href="InputChannel#event">:omnimode</see>
        ///    * [<c>resetallcontrollers</c>]<see href="InputChannel#event">:resetallcontrollers</see>
        ///
        /// **NRPN** Events
        ///
        ///    * [<c>nrpn</c>]<see href="InputChannel#event">:nrpn</see>
        ///    * [<c>nrpn-dataentrycoarse</c>]<see href="InputChannel#event">:nrpn-dataentrycoarse</see>
        ///    * [<c>nrpn-dataentryfine</c>]<see href="InputChannel#event">:nrpn-dataentryfine</see>
        ///    * [<c>nrpn-dataincrement</c>]<see href="InputChannel#event">:nrpn-dataincrement</see>
        ///    * [<c>nrpn-datadecrement</c>]<see href="InputChannel#event">:nrpn-datadecrement</see>
        ///
        /// **RPN** Events
        ///
        ///    * [<c>rpn</c>]<see href="InputChannel#event">:rpn</see>
        ///    * [<c>rpn-dataentrycoarse</c>]<see href="InputChannel#event">:rpn-dataentrycoarse</see>
        ///    * [<c>rpn-dataentryfine</c>]<see href="InputChannel#event">:rpn-dataentryfine</see>
        ///    * [<c>rpn-dataincrement</c>]<see href="InputChannel#event">:rpn-dataincrement</see>
        ///    * [<c>rpn-datadecrement</c>]<see href="InputChannel#event">:rpn-datadecrement</see>
        /// </summary>
        /// <param name="event">
        /// The type of the event.
        /// </param>
        /// <param name="listener">
        /// A callback function to execute when the specified event
        /// is detected. This function will receive an event parameter object. For details on this object's
        /// properties, check out the documentation for the various events (links above).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// The listener object that was created
        /// </returns>
        abstract member addListener<'T>: e: U2<obj, Webmidi.InputChannelEventMap.Key<'T>> * listener: 'T * ?options: InputChannel.addListener.options -> Webmidi.Listener
        /// <summary>
        /// Adds a one-time event listener that will trigger a function callback when the specified event
        /// is dispatched.
        ///
        /// Here are the events you can listen to:
        ///
        /// **Channel Voice** Events
        ///
        ///    * [<c>channelaftertouch</c>]<see href="InputChannel#event">:channelaftertouch</see>
        ///    * [<c>controlchange</c>]<see href="InputChannel#event">:controlchange</see>
        ///      * [<c>controlchange-controller0</c>]<see href="InputChannel#event">:controlchange-controller0</see>
        ///      * [<c>controlchange-controller1</c>]<see href="InputChannel#event">:controlchange-controller1</see>
        ///      * [<c>controlchange-controller2</c>]<see href="InputChannel#event">:controlchange-controller2</see>
        ///      * (...)
        ///      * [<c>controlchange-controller127</c>]<see href="InputChannel#event">:controlchange-controller127</see>
        ///    * [<c>keyaftertouch</c>]<see href="InputChannel#event">:keyaftertouch</see>
        ///    * [<c>noteoff</c>]<see href="InputChannel#event">:noteoff</see>
        ///    * [<c>noteon</c>]<see href="InputChannel#event">:noteon</see>
        ///    * [<c>pitchbend</c>]<see href="InputChannel#event">:pitchbend</see>
        ///    * [<c>programchange</c>]<see href="InputChannel#event">:programchange</see>
        ///
        ///    Note: you can listen for a specific control change message by using an event name like this:
        ///    <c>controlchange-controller23</c>, <c>controlchange-controller99</c>, <c>controlchange-controller122</c>,
        ///    etc.
        ///
        /// **Channel Mode** Events
        ///
        ///    * [<c>allnotesoff</c>]<see href="InputChannel#event">:allnotesoff</see>
        ///    * [<c>allsoundoff</c>]<see href="InputChannel#event">:allsoundoff</see>
        ///    * [<c>localcontrol</c>]<see href="InputChannel#event">:localcontrol</see>
        ///    * [<c>monomode</c>]<see href="InputChannel#event">:monomode</see>
        ///    * [<c>omnimode</c>]<see href="InputChannel#event">:omnimode</see>
        ///    * [<c>resetallcontrollers</c>]<see href="InputChannel#event">:resetallcontrollers</see>
        ///
        /// **NRPN** Events
        ///
        ///    * [<c>nrpn</c>]<see href="InputChannel#event">:nrpn</see>
        ///    * [<c>nrpn-dataentrycoarse</c>]<see href="InputChannel#event">:nrpn-dataentrycoarse</see>
        ///    * [<c>nrpn-dataentryfine</c>]<see href="InputChannel#event">:nrpn-dataentryfine</see>
        ///    * [<c>nrpn-dataincrement</c>]<see href="InputChannel#event">:nrpn-dataincrement</see>
        ///    * [<c>nrpn-datadecrement</c>]<see href="InputChannel#event">:nrpn-datadecrement</see>
        ///
        /// **RPN** Events
        ///
        ///    * [<c>rpn</c>]<see href="InputChannel#event">:rpn</see>
        ///    * [<c>rpn-dataentrycoarse</c>]<see href="InputChannel#event">:rpn-dataentrycoarse</see>
        ///    * [<c>rpn-dataentryfine</c>]<see href="InputChannel#event">:rpn-dataentryfine</see>
        ///    * [<c>rpn-dataincrement</c>]<see href="InputChannel#event">:rpn-dataincrement</see>
        ///    * [<c>rpn-datadecrement</c>]<see href="InputChannel#event">:rpn-datadecrement</see>
        /// </summary>
        /// <param name="event">
        /// The type of the event.
        /// </param>
        /// <param name="listener">
        /// A callback function to execute when the specified event
        /// is detected. This function will receive an event parameter object. For details on this object's
        /// properties, check out the documentation for the various events (links above).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// The listener object that was created
        /// </returns>
        abstract member addOneTimeListener<'T>: e: obj * listener: 'T * ?options: InputChannel.addOneTimeListener.options -> Webmidi.Listener
        /// <summary>
        /// Adds a one-time event listener that will trigger a function callback when the specified event
        /// is dispatched.
        ///
        /// Here are the events you can listen to:
        ///
        /// **Channel Voice** Events
        ///
        ///    * [<c>channelaftertouch</c>]<see href="InputChannel#event">:channelaftertouch</see>
        ///    * [<c>controlchange</c>]<see href="InputChannel#event">:controlchange</see>
        ///      * [<c>controlchange-controller0</c>]<see href="InputChannel#event">:controlchange-controller0</see>
        ///      * [<c>controlchange-controller1</c>]<see href="InputChannel#event">:controlchange-controller1</see>
        ///      * [<c>controlchange-controller2</c>]<see href="InputChannel#event">:controlchange-controller2</see>
        ///      * (...)
        ///      * [<c>controlchange-controller127</c>]<see href="InputChannel#event">:controlchange-controller127</see>
        ///    * [<c>keyaftertouch</c>]<see href="InputChannel#event">:keyaftertouch</see>
        ///    * [<c>noteoff</c>]<see href="InputChannel#event">:noteoff</see>
        ///    * [<c>noteon</c>]<see href="InputChannel#event">:noteon</see>
        ///    * [<c>pitchbend</c>]<see href="InputChannel#event">:pitchbend</see>
        ///    * [<c>programchange</c>]<see href="InputChannel#event">:programchange</see>
        ///
        ///    Note: you can listen for a specific control change message by using an event name like this:
        ///    <c>controlchange-controller23</c>, <c>controlchange-controller99</c>, <c>controlchange-controller122</c>,
        ///    etc.
        ///
        /// **Channel Mode** Events
        ///
        ///    * [<c>allnotesoff</c>]<see href="InputChannel#event">:allnotesoff</see>
        ///    * [<c>allsoundoff</c>]<see href="InputChannel#event">:allsoundoff</see>
        ///    * [<c>localcontrol</c>]<see href="InputChannel#event">:localcontrol</see>
        ///    * [<c>monomode</c>]<see href="InputChannel#event">:monomode</see>
        ///    * [<c>omnimode</c>]<see href="InputChannel#event">:omnimode</see>
        ///    * [<c>resetallcontrollers</c>]<see href="InputChannel#event">:resetallcontrollers</see>
        ///
        /// **NRPN** Events
        ///
        ///    * [<c>nrpn</c>]<see href="InputChannel#event">:nrpn</see>
        ///    * [<c>nrpn-dataentrycoarse</c>]<see href="InputChannel#event">:nrpn-dataentrycoarse</see>
        ///    * [<c>nrpn-dataentryfine</c>]<see href="InputChannel#event">:nrpn-dataentryfine</see>
        ///    * [<c>nrpn-dataincrement</c>]<see href="InputChannel#event">:nrpn-dataincrement</see>
        ///    * [<c>nrpn-datadecrement</c>]<see href="InputChannel#event">:nrpn-datadecrement</see>
        ///
        /// **RPN** Events
        ///
        ///    * [<c>rpn</c>]<see href="InputChannel#event">:rpn</see>
        ///    * [<c>rpn-dataentrycoarse</c>]<see href="InputChannel#event">:rpn-dataentrycoarse</see>
        ///    * [<c>rpn-dataentryfine</c>]<see href="InputChannel#event">:rpn-dataentryfine</see>
        ///    * [<c>rpn-dataincrement</c>]<see href="InputChannel#event">:rpn-dataincrement</see>
        ///    * [<c>rpn-datadecrement</c>]<see href="InputChannel#event">:rpn-datadecrement</see>
        /// </summary>
        /// <param name="event">
        /// The type of the event.
        /// </param>
        /// <param name="listener">
        /// A callback function to execute when the specified event
        /// is detected. This function will receive an event parameter object. For details on this object's
        /// properties, check out the documentation for the various events (links above).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// The listener object that was created
        /// </returns>
        abstract member addOneTimeListener<'T>: e: Webmidi.InputChannelEventMap.Key<'T> * listener: 'T * ?options: InputChannel.addOneTimeListener.options -> Webmidi.Listener
        /// <summary>
        /// Adds a one-time event listener that will trigger a function callback when the specified event
        /// is dispatched.
        ///
        /// Here are the events you can listen to:
        ///
        /// **Channel Voice** Events
        ///
        ///    * [<c>channelaftertouch</c>]<see href="InputChannel#event">:channelaftertouch</see>
        ///    * [<c>controlchange</c>]<see href="InputChannel#event">:controlchange</see>
        ///      * [<c>controlchange-controller0</c>]<see href="InputChannel#event">:controlchange-controller0</see>
        ///      * [<c>controlchange-controller1</c>]<see href="InputChannel#event">:controlchange-controller1</see>
        ///      * [<c>controlchange-controller2</c>]<see href="InputChannel#event">:controlchange-controller2</see>
        ///      * (...)
        ///      * [<c>controlchange-controller127</c>]<see href="InputChannel#event">:controlchange-controller127</see>
        ///    * [<c>keyaftertouch</c>]<see href="InputChannel#event">:keyaftertouch</see>
        ///    * [<c>noteoff</c>]<see href="InputChannel#event">:noteoff</see>
        ///    * [<c>noteon</c>]<see href="InputChannel#event">:noteon</see>
        ///    * [<c>pitchbend</c>]<see href="InputChannel#event">:pitchbend</see>
        ///    * [<c>programchange</c>]<see href="InputChannel#event">:programchange</see>
        ///
        ///    Note: you can listen for a specific control change message by using an event name like this:
        ///    <c>controlchange-controller23</c>, <c>controlchange-controller99</c>, <c>controlchange-controller122</c>,
        ///    etc.
        ///
        /// **Channel Mode** Events
        ///
        ///    * [<c>allnotesoff</c>]<see href="InputChannel#event">:allnotesoff</see>
        ///    * [<c>allsoundoff</c>]<see href="InputChannel#event">:allsoundoff</see>
        ///    * [<c>localcontrol</c>]<see href="InputChannel#event">:localcontrol</see>
        ///    * [<c>monomode</c>]<see href="InputChannel#event">:monomode</see>
        ///    * [<c>omnimode</c>]<see href="InputChannel#event">:omnimode</see>
        ///    * [<c>resetallcontrollers</c>]<see href="InputChannel#event">:resetallcontrollers</see>
        ///
        /// **NRPN** Events
        ///
        ///    * [<c>nrpn</c>]<see href="InputChannel#event">:nrpn</see>
        ///    * [<c>nrpn-dataentrycoarse</c>]<see href="InputChannel#event">:nrpn-dataentrycoarse</see>
        ///    * [<c>nrpn-dataentryfine</c>]<see href="InputChannel#event">:nrpn-dataentryfine</see>
        ///    * [<c>nrpn-dataincrement</c>]<see href="InputChannel#event">:nrpn-dataincrement</see>
        ///    * [<c>nrpn-datadecrement</c>]<see href="InputChannel#event">:nrpn-datadecrement</see>
        ///
        /// **RPN** Events
        ///
        ///    * [<c>rpn</c>]<see href="InputChannel#event">:rpn</see>
        ///    * [<c>rpn-dataentrycoarse</c>]<see href="InputChannel#event">:rpn-dataentrycoarse</see>
        ///    * [<c>rpn-dataentryfine</c>]<see href="InputChannel#event">:rpn-dataentryfine</see>
        ///    * [<c>rpn-dataincrement</c>]<see href="InputChannel#event">:rpn-dataincrement</see>
        ///    * [<c>rpn-datadecrement</c>]<see href="InputChannel#event">:rpn-datadecrement</see>
        /// </summary>
        /// <param name="event">
        /// The type of the event.
        /// </param>
        /// <param name="listener">
        /// A callback function to execute when the specified event
        /// is detected. This function will receive an event parameter object. For details on this object's
        /// properties, check out the documentation for the various events (links above).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// The listener object that was created
        /// </returns>
        abstract member addOneTimeListener<'T>: e: U2<obj, Webmidi.InputChannelEventMap.Key<'T>> * listener: 'T * ?options: InputChannel.addOneTimeListener.options -> Webmidi.Listener
        /// <summary>
        /// Destroys the <c>InputChannel</c> by removing all listeners and severing the link with the MIDI
        /// subsystem's input.
        /// </summary>
        abstract member destroy: unit -> unit
        /// <summary>
        /// Returns the playing status of the specified note (<c>true</c> if the note is currently playing,
        /// <c>false</c> if it is not). The <c>note</c> parameter can be an unsigned integer (0-127), a note
        /// identifier (<c>"C4"</c>, <c>"G#5"</c>, etc.) or a [<c>Note</c>]<see href="Note">Note</see> object.
        ///
        /// IF the note is specified using an integer (0-127), no octave offset will be applied.
        /// </summary>
        /// <param name="note">
        /// The note to get the state for. The
        /// [<c>octaveOffset</c>](#octaveOffset) (channel, input and global) will be factored in for note
        /// identifiers and [<c>Note</c>]<see href="Note">Note</see> objects.
        /// </param>
        abstract member getNoteState: note: float -> bool
        /// <summary>
        /// Returns the playing status of the specified note (<c>true</c> if the note is currently playing,
        /// <c>false</c> if it is not). The <c>note</c> parameter can be an unsigned integer (0-127), a note
        /// identifier (<c>"C4"</c>, <c>"G#5"</c>, etc.) or a [<c>Note</c>]<see href="Note">Note</see> object.
        ///
        /// IF the note is specified using an integer (0-127), no octave offset will be applied.
        /// </summary>
        /// <param name="note">
        /// The note to get the state for. The
        /// [<c>octaveOffset</c>](#octaveOffset) (channel, input and global) will be factored in for note
        /// identifiers and [<c>Note</c>]<see href="Note">Note</see> objects.
        /// </param>
        abstract member getNoteState: note: string -> bool
        /// <summary>
        /// Returns the playing status of the specified note (<c>true</c> if the note is currently playing,
        /// <c>false</c> if it is not). The <c>note</c> parameter can be an unsigned integer (0-127), a note
        /// identifier (<c>"C4"</c>, <c>"G#5"</c>, etc.) or a [<c>Note</c>]<see href="Note">Note</see> object.
        ///
        /// IF the note is specified using an integer (0-127), no octave offset will be applied.
        /// </summary>
        /// <param name="note">
        /// The note to get the state for. The
        /// [<c>octaveOffset</c>](#octaveOffset) (channel, input and global) will be factored in for note
        /// identifiers and [<c>Note</c>]<see href="Note">Note</see> objects.
        /// </param>
        abstract member getNoteState: note: Webmidi.Note -> bool
        /// <summary>
        /// Returns the playing status of the specified note (<c>true</c> if the note is currently playing,
        /// <c>false</c> if it is not). The <c>note</c> parameter can be an unsigned integer (0-127), a note
        /// identifier (<c>"C4"</c>, <c>"G#5"</c>, etc.) or a [<c>Note</c>]<see href="Note">Note</see> object.
        ///
        /// IF the note is specified using an integer (0-127), no octave offset will be applied.
        /// </summary>
        /// <param name="note">
        /// The note to get the state for. The
        /// [<c>octaveOffset</c>](#octaveOffset) (channel, input and global) will be factored in for note
        /// identifiers and [<c>Note</c>]<see href="Note">Note</see> objects.
        /// </param>
        abstract member getNoteState: note: U3<float, string, Webmidi.Note> -> bool
        /// <summary>
        /// Checks if the specified event type is already defined to trigger the specified callback
        /// function.
        /// </summary>
        /// <param name="event">
        /// The type of the event.
        /// </param>
        /// <param name="listener">
        /// The callback function to check for.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Boolean value indicating whether or not the <c>Input</c> or <c>InputChannel</c>
        /// already has this listener defined.
        /// </returns>
        abstract member hasListener<'T>: e: obj * listener: 'T -> bool
        /// <summary>
        /// Checks if the specified event type is already defined to trigger the specified callback
        /// function.
        /// </summary>
        /// <param name="event">
        /// The type of the event.
        /// </param>
        /// <param name="listener">
        /// The callback function to check for.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Boolean value indicating whether or not the <c>Input</c> or <c>InputChannel</c>
        /// already has this listener defined.
        /// </returns>
        abstract member hasListener<'T>: e: Webmidi.InputChannelEventMap.Key<'T> * listener: 'T -> bool
        /// <summary>
        /// Checks if the specified event type is already defined to trigger the specified callback
        /// function.
        /// </summary>
        /// <param name="event">
        /// The type of the event.
        /// </param>
        /// <param name="listener">
        /// The callback function to check for.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Boolean value indicating whether or not the <c>Input</c> or <c>InputChannel</c>
        /// already has this listener defined.
        /// </returns>
        abstract member hasListener<'T>: e: U2<obj, Webmidi.InputChannelEventMap.Key<'T>> * listener: 'T -> bool
        /// <summary>
        /// Removes the specified listener for the specified event. If no listener is specified, all
        /// listeners for the specified event will be removed. If no event is specified, all listeners
        /// will be removed.
        /// </summary>
        /// <param name="type">
        /// The type of the event.
        /// </param>
        /// <param name="listener">
        /// The callback function to check for.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        abstract member removeListener: unit -> unit
        /// <summary>
        /// Removes the specified listener for the specified event. If no listener is specified, all
        /// listeners for the specified event will be removed. If no event is specified, all listeners
        /// will be removed.
        /// </summary>
        /// <param name="type">
        /// The type of the event.
        /// </param>
        /// <param name="listener">
        /// The callback function to check for.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        abstract member removeListener<'T>: ``type``: obj * ?listener: 'T * ?options: InputChannel.removeListener.options -> unit
        /// <summary>
        /// Removes the specified listener for the specified event. If no listener is specified, all
        /// listeners for the specified event will be removed. If no event is specified, all listeners
        /// will be removed.
        /// </summary>
        /// <param name="type">
        /// The type of the event.
        /// </param>
        /// <param name="listener">
        /// The callback function to check for.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        abstract member removeListener<'T>: ``type``: Webmidi.InputChannelEventMap.Key<'T> * ?listener: 'T * ?options: InputChannel.removeListener.options -> unit
        /// <summary>
        /// The [<c>Input</c>](Input) this channel belongs to.
        /// </summary>
        abstract member input: Webmidi.Input with get
        /// <summary>
        /// This channel's MIDI number (1-16).
        /// </summary>
        abstract member number: float with get
        /// <summary>
        /// An integer to offset the reported octave of incoming note-specific messages (<c>noteon</c>,
        /// <c>noteoff</c> and <c>keyaftertouch</c>). By default, middle C (MIDI note number 60) is placed on the 4th
        /// octave (C4).
        ///
        /// If, for example, <c>octaveOffset</c> is set to 2, MIDI note number 60 will be reported as C6. If
        /// <c>octaveOffset</c> is set to -1, MIDI note number 60 will be reported as C3.
        ///
        /// Note that this value is combined with the global offset value defined by
        /// [<c>WebMidi.octaveOffset</c>](WebMidi#octaveOffset) object and with the value defined on the parent
        /// input object with [<c>Input.octaveOffset</c>](Input#octaveOffset).
        /// </summary>
        abstract member octaveOffset: float with get, set
        /// <summary>
        /// Identifier (Symbol) to use when adding or removing a listener that should be triggered when any
        /// events occur.
        /// </summary>
        static member inline ANY_EVENT
            with get () : obj =
                nativeOnly
        /// <summary>
        /// An object containing a property for each event with at least one registered listener. Each
        /// event property contains an array of all the [<c>Listener</c>]<see href="Listener">Listener</see> objects registered
        /// for the event.
        /// </summary>
        abstract member eventMap: obj with get, set
        /// <summary>
        /// Whether or not the execution of callbacks is currently suspended for this emitter.
        /// </summary>
        abstract member eventsSuspended: bool with get, set
        /// <summary>
        /// An array of all the unique event names for which the emitter has at least one registered
        /// listener.
        ///
        /// Note: this excludes global events registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> because they are not tied to a
        /// specific event.
        /// </summary>
        abstract member eventNames: ResizeArray<string> with get
        /// <summary>
        /// Returns an array of all the [<c>Listener</c>]<see href="Listener">Listener</see> objects that have been registered for
        /// a specific event.
        ///
        /// Please note that global events (those added with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>) are not returned for "regular"
        /// events. To get the list of global listeners, specifically use
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> as the parameter.
        /// </summary>
        /// <param name="event">
        /// The event to get listeners for.
        /// </param>
        /// <returns>
        /// An array of [<c>Listener</c>]<see href="Listener">Listener</see> objects.
        /// </returns>
        abstract member getListeners: event: string -> ResizeArray<Webmidi.Listener>
        /// <summary>
        /// Returns an array of all the [<c>Listener</c>]<see href="Listener">Listener</see> objects that have been registered for
        /// a specific event.
        ///
        /// Please note that global events (those added with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>) are not returned for "regular"
        /// events. To get the list of global listeners, specifically use
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> as the parameter.
        /// </summary>
        /// <param name="event">
        /// The event to get listeners for.
        /// </param>
        /// <returns>
        /// An array of [<c>Listener</c>]<see href="Listener">Listener</see> objects.
        /// </returns>
        abstract member getListeners: event: obj -> ResizeArray<Webmidi.Listener>
        /// <summary>
        /// Returns an array of all the [<c>Listener</c>]<see href="Listener">Listener</see> objects that have been registered for
        /// a specific event.
        ///
        /// Please note that global events (those added with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>) are not returned for "regular"
        /// events. To get the list of global listeners, specifically use
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> as the parameter.
        /// </summary>
        /// <param name="event">
        /// The event to get listeners for.
        /// </param>
        /// <returns>
        /// An array of [<c>Listener</c>]<see href="Listener">Listener</see> objects.
        /// </returns>
        abstract member getListeners: event: U2<string, obj> -> ResizeArray<Webmidi.Listener>
        /// <summary>
        /// Suspends execution of all callbacks functions registered for the specified event type.
        ///
        /// You can suspend execution of callbacks registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> by passing
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> to <c>suspendEvent()</c>. Beware that this
        /// will not suspend all callbacks but only those registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>. While this may seem counter-intuitive
        /// at first glance, it allows the selective suspension of global listeners while leaving other
        /// listeners alone. If you truly want to suspends all callbacks for a specific
        /// [<c>EventEmitter</c>]<see href="EventEmitter">EventEmitter</see>, simply set its <c>eventsSuspended</c> property to <c>true</c>.
        /// </summary>
        /// <param name="event">
        /// The event name (or <c>EventEmitter.ANY_EVENT</c>) for which to suspend
        /// execution of all callback functions.
        /// </param>
        abstract member suspendEvent: event: string -> unit
        /// <summary>
        /// Suspends execution of all callbacks functions registered for the specified event type.
        ///
        /// You can suspend execution of callbacks registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> by passing
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> to <c>suspendEvent()</c>. Beware that this
        /// will not suspend all callbacks but only those registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>. While this may seem counter-intuitive
        /// at first glance, it allows the selective suspension of global listeners while leaving other
        /// listeners alone. If you truly want to suspends all callbacks for a specific
        /// [<c>EventEmitter</c>]<see href="EventEmitter">EventEmitter</see>, simply set its <c>eventsSuspended</c> property to <c>true</c>.
        /// </summary>
        /// <param name="event">
        /// The event name (or <c>EventEmitter.ANY_EVENT</c>) for which to suspend
        /// execution of all callback functions.
        /// </param>
        abstract member suspendEvent: event: obj -> unit
        /// <summary>
        /// Suspends execution of all callbacks functions registered for the specified event type.
        ///
        /// You can suspend execution of callbacks registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> by passing
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> to <c>suspendEvent()</c>. Beware that this
        /// will not suspend all callbacks but only those registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>. While this may seem counter-intuitive
        /// at first glance, it allows the selective suspension of global listeners while leaving other
        /// listeners alone. If you truly want to suspends all callbacks for a specific
        /// [<c>EventEmitter</c>]<see href="EventEmitter">EventEmitter</see>, simply set its <c>eventsSuspended</c> property to <c>true</c>.
        /// </summary>
        /// <param name="event">
        /// The event name (or <c>EventEmitter.ANY_EVENT</c>) for which to suspend
        /// execution of all callback functions.
        /// </param>
        abstract member suspendEvent: event: U2<string, obj> -> unit
        /// <summary>
        /// Resumes execution of all suspended callback functions registered for the specified event type.
        ///
        /// You can resume execution of callbacks registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> by passing
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> to <c>unsuspendEvent()</c>. Beware that
        /// this will not resume all callbacks but only those registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>. While this may seem
        /// counter-intuitive, it allows the selective unsuspension of global listeners while leaving other
        /// callbacks alone.
        /// </summary>
        /// <param name="event">
        /// The event name (or <c>EventEmitter.ANY_EVENT</c>) for which to resume
        /// execution of all callback functions.
        /// </param>
        abstract member unsuspendEvent: event: string -> unit
        /// <summary>
        /// Resumes execution of all suspended callback functions registered for the specified event type.
        ///
        /// You can resume execution of callbacks registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> by passing
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> to <c>unsuspendEvent()</c>. Beware that
        /// this will not resume all callbacks but only those registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>. While this may seem
        /// counter-intuitive, it allows the selective unsuspension of global listeners while leaving other
        /// callbacks alone.
        /// </summary>
        /// <param name="event">
        /// The event name (or <c>EventEmitter.ANY_EVENT</c>) for which to resume
        /// execution of all callback functions.
        /// </param>
        abstract member unsuspendEvent: event: obj -> unit
        /// <summary>
        /// Resumes execution of all suspended callback functions registered for the specified event type.
        ///
        /// You can resume execution of callbacks registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> by passing
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> to <c>unsuspendEvent()</c>. Beware that
        /// this will not resume all callbacks but only those registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>. While this may seem
        /// counter-intuitive, it allows the selective unsuspension of global listeners while leaving other
        /// callbacks alone.
        /// </summary>
        /// <param name="event">
        /// The event name (or <c>EventEmitter.ANY_EVENT</c>) for which to resume
        /// execution of all callback functions.
        /// </param>
        abstract member unsuspendEvent: event: U2<string, obj> -> unit
        /// <summary>
        /// Returns the number of listeners registered for a specific event.
        ///
        /// Please note that global events (those added with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>) do not count towards the remaining
        /// number for a "regular" event. To get the number of global listeners, specifically use
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> as the parameter.
        /// </summary>
        /// <param name="event">
        /// The event which is usually a string but can also be the special
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> symbol.
        /// </param>
        /// <returns>
        /// An integer representing the number of listeners registered for the specified
        /// event.
        /// </returns>
        abstract member getListenerCount: event: string -> float
        /// <summary>
        /// Returns the number of listeners registered for a specific event.
        ///
        /// Please note that global events (those added with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>) do not count towards the remaining
        /// number for a "regular" event. To get the number of global listeners, specifically use
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> as the parameter.
        /// </summary>
        /// <param name="event">
        /// The event which is usually a string but can also be the special
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> symbol.
        /// </param>
        /// <returns>
        /// An integer representing the number of listeners registered for the specified
        /// event.
        /// </returns>
        abstract member getListenerCount: event: obj -> float
        /// <summary>
        /// Returns the number of listeners registered for a specific event.
        ///
        /// Please note that global events (those added with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>) do not count towards the remaining
        /// number for a "regular" event. To get the number of global listeners, specifically use
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> as the parameter.
        /// </summary>
        /// <param name="event">
        /// The event which is usually a string but can also be the special
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> symbol.
        /// </param>
        /// <returns>
        /// An integer representing the number of listeners registered for the specified
        /// event.
        /// </returns>
        abstract member getListenerCount: event: U2<string, obj> -> float
        /// <summary>
        /// Executes the callback function of all the [<c>Listener</c>]<see href="Listener">Listener</see> objects registered for
        /// a given event. The callback functions are passed the additional arguments passed to <c>emit()</c>
        /// (if any) followed by the arguments present in the [<c>arguments</c>](Listener#arguments) property of
        /// the [<c>Listener</c>](Listener) object (if any).
        ///
        /// If the [<c>eventsSuspended</c>]<see href="#eventsSuspended">#eventsSuspended</see> property is <c>true</c> or the
        /// [<c>Listener.suspended</c>]<see href="Listener#suspended">Listener#suspended</see> property is <c>true</c>, the callback functions
        /// will not be executed.
        ///
        /// This function returns an array containing the return values of each of the callbacks.
        ///
        /// It should be noted that the regular listeners are triggered first followed by the global
        /// listeners (those added with [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>).
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// The <c>event</c> parameter must be a string.
        /// </remarks>
        /// <param name="event">
        /// The event
        /// </param>
        /// <param name="args">
        /// Arbitrary number of arguments to pass along to the callback functions
        /// </param>
        /// <returns>
        /// An array containing the return value of each of the executed listener
        /// functions.
        /// </returns>
        abstract member emit: event: string * [<ParamArray>] args: obj [] -> ResizeArray<obj>
        /// <summary>
        /// The <c>waitFor()</c> method is an async function which returns a promise. The promise is fulfilled
        /// when the specified event occurs. The event can be a regular event or
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> (if you want to resolve as soon as any
        /// event is emitted).
        ///
        /// If the <c>duration</c> option is set, the promise will only be fulfilled if the event is emitted
        /// within the specified duration. If the event has not been fulfilled after the specified
        /// duration, the promise is rejected. This makes it super easy to wait for an event and timeout
        /// after a certain time if the event is not triggered.
        /// </summary>
        /// <param name="event">
        /// The event to wait for
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        abstract member waitFor: event: string * ?options: EventEmitter.waitFor.options -> JS.Promise<obj>
        /// <summary>
        /// The <c>waitFor()</c> method is an async function which returns a promise. The promise is fulfilled
        /// when the specified event occurs. The event can be a regular event or
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> (if you want to resolve as soon as any
        /// event is emitted).
        ///
        /// If the <c>duration</c> option is set, the promise will only be fulfilled if the event is emitted
        /// within the specified duration. If the event has not been fulfilled after the specified
        /// duration, the promise is rejected. This makes it super easy to wait for an event and timeout
        /// after a certain time if the event is not triggered.
        /// </summary>
        /// <param name="event">
        /// The event to wait for
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        abstract member waitFor: event: obj * ?options: EventEmitter.waitFor.options -> JS.Promise<obj>
        /// <summary>
        /// The <c>waitFor()</c> method is an async function which returns a promise. The promise is fulfilled
        /// when the specified event occurs. The event can be a regular event or
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> (if you want to resolve as soon as any
        /// event is emitted).
        ///
        /// If the <c>duration</c> option is set, the promise will only be fulfilled if the event is emitted
        /// within the specified duration. If the event has not been fulfilled after the specified
        /// duration, the promise is rejected. This makes it super easy to wait for an event and timeout
        /// after a certain time if the event is not triggered.
        /// </summary>
        /// <param name="event">
        /// The event to wait for
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        abstract member waitFor: event: U2<string, obj> * ?options: EventEmitter.waitFor.options -> JS.Promise<obj>
        /// <summary>
        /// The number of unique events that have registered listeners.
        ///
        /// Note: this excludes global events registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> because they are not tied to a
        /// specific event.
        /// </summary>
        abstract member eventCount: float with get

    /// <summary>
    /// The <c>Message</c> class represents a single MIDI message. It has several properties that make it
    /// easy to make sense of the binary data it contains.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("Message", "webmidi")>]
    type Message =
        /// <summary>
        /// The MIDI channel number (<c>1</c> - <c>16</c>) that the message is targeting. This is only for
        /// channel-specific messages. For system messages, this will be left <c>undefined</c>.
        /// </summary>
        abstract member channel: float with get, set
        /// <summary>
        /// An integer identifying the MIDI command. For channel-specific messages, the value is 4-bit
        /// and will be between <c>8</c> and <c>14</c>. For system messages, the value will be between <c>240</c> and
        /// <c>255</c>.
        /// </summary>
        abstract member command: float with get, set
        /// <summary>
        /// An array containing all the bytes of the MIDI message. Each byte is an integer between <c>0</c>
        /// and <c>255</c>.
        /// </summary>
        abstract member data: ResizeArray<float> with get, set
        /// <summary>
        /// An array of the the data byte(s) of the MIDI message (as opposed to the status byte). When
        /// the message is a system exclusive message (sysex), <c>dataBytes</c> explicitly excludes the
        /// manufacturer ID and the sysex end byte so only the actual data is included.
        /// </summary>
        abstract member dataBytes: ResizeArray<float> with get, set
        /// <summary>
        /// A boolean indicating whether the MIDI message is a channel-specific message.
        /// </summary>
        abstract member isChannelMessage: bool with get, set
        /// <summary>
        /// A boolean indicating whether the MIDI message is a system message (not specific to a
        /// channel).
        /// </summary>
        abstract member isSystemMessage: bool with get, set
        /// <summary>
        /// When the message is a system exclusive message (sysex), this property contains an array with
        /// either 1 or 3 entries that identify the manufacturer targeted by the message.
        ///
        /// To know how to translate these entries into manufacturer names, check out the official list:
        /// https://www.midi.org/specifications-old/item/manufacturer-id-numbers
        /// </summary>
        abstract member manufacturerId: ResizeArray<float> with get, set
        /// <summary>
        /// A
        /// [<c>Uint8Array</c>](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Uint8Array)
        /// containing the bytes of the MIDI message. Each byte is an integer between <c>0</c> and <c>255</c>.
        /// </summary>
        abstract member rawData: JS.Uint8Array with get, set
        /// <summary>
        /// A
        /// [<c>Uint8Array</c>](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Uint8Array)
        /// of the data byte(s) of the MIDI message. When the message is a system exclusive message
        /// (sysex), <c>rawDataBytes</c> explicitly excludes the manufacturer ID and the sysex end byte so
        /// only the actual data is included.
        /// </summary>
        abstract member rawDataBytes: JS.Uint8Array with get, set
        /// <summary>
        /// The MIDI status byte of the message as an integer between <c>0</c> and <c>255</c>.
        /// </summary>
        abstract member statusByte: float with get, set
        /// <summary>
        /// The type of message as a string (<c>"noteon"</c>, <c>"controlchange"</c>, <c>"sysex"</c>, etc.)
        /// </summary>
        abstract member ``type``: string with get, set

    /// <summary>
    /// The <c>Note</c> class represents a single musical note such as <c>"D3"</c>, <c>"G#4"</c>, <c>"F-1"</c>, <c>"Gb7"</c>, etc.
    ///
    /// <c>Note</c> objects can be played back on a single channel by calling
    /// [<c>OutputChannel.playNote()</c>]<see href="OutputChannel#playNote">OutputChannel#playNote</see> or, on multiple channels of the same
    /// output, by calling [<c>Output.playNote()</c>]<see href="Output#playNote">Output#playNote</see>.
    ///
    /// The note has [<c>attack</c>](#attack) and [<c>release</c>](#release) velocities set at <c>0.5</c> by default.
    /// These can be changed by passing in the appropriate option. It is also possible to set a
    /// system-wide default for attack and release velocities by using the
    /// [<c>WebMidi.defaults</c>](WebMidi#defaults) property.
    ///
    /// If you prefer to work with raw MIDI values (<c>0</c> to <c>127</c>), you can use [<c>rawAttack</c>](#rawAttack) and
    /// [<c>rawRelease</c>](#rawRelease) to both get and set the values.
    ///
    /// The note may have a [<c>duration</c>](#duration). If it does, playback will be automatically stopped
    /// when the duration has elapsed by sending a <c>"noteoff"</c> event. By default, the duration is set to
    /// <c>Infinity</c>. In this case, it will never stop playing unless explicitly stopped by calling a
    /// method such as [<c>OutputChannel.stopNote()</c>]<see href="OutputChannel#stopNote">OutputChannel#stopNote</see>,
    /// [<c>Output.stopNote()</c>]<see href="Output#stopNote">Output#stopNote</see> or similar.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("Note", "webmidi")>]
    type Note =
        /// <summary>
        /// Returns a MIDI note number offset by octave and/or semitone. If the calculated value is less
        /// than 0, 0 will be returned. If the calculated value is more than 127, 127 will be returned. If
        /// an invalid value is supplied, 0 will be used.
        /// </summary>
        /// <param name="octaveOffset">
        /// An integer to offset the note number by octave.
        /// </param>
        /// <param name="semitoneOffset">
        /// An integer to offset the note number by semitone.
        /// </param>
        /// <returns>
        /// An integer between 0 and 127
        /// </returns>
        abstract member getOffsetNumber: ?octaveOffset: float * ?semitoneOffset: float -> float
        /// <summary>
        /// The accidental (#, ##, b or bb) of the note.
        /// </summary>
        abstract member accidental: string with get, set
        /// <summary>
        /// The attack velocity of the note as a float between 0 and 1.
        /// </summary>
        abstract member attack: float with get, set
        /// <summary>
        /// The duration of the note as a positive decimal number representing the number of milliseconds
        /// that the note should play for.
        /// </summary>
        abstract member duration: float with get, set
        /// <summary>
        /// The name, optional accidental and octave of the note, as a string.
        /// </summary>
        abstract member identifier: string with get, set
        /// <summary>
        /// The name (letter) of the note. If you need the full name with octave and accidental, you can
        /// use the [<c>identifier</c>]<see href="Note#identifier">Note#identifier</see> property instead.
        /// </summary>
        abstract member name: string with get, set
        /// <summary>
        /// The MIDI number of the note (<c>0</c> - <c>127</c>). This number is derived from the note identifier
        /// using C4 as a reference for middle C.
        /// </summary>
        abstract member number: float with get
        /// <summary>
        /// The octave of the note.
        /// </summary>
        abstract member octave: float with get, set
        /// <summary>
        /// The attack velocity of the note as a positive integer between 0 and 127.
        /// </summary>
        abstract member rawAttack: float with get, set
        /// <summary>
        /// The release velocity of the note as a positive integer between 0 and 127.
        /// </summary>
        abstract member rawRelease: float with get, set
        /// <summary>
        /// The release velocity of the note as an integer between 0 and 1.
        /// </summary>
        abstract member release: float with get, set

    /// <summary>
    /// The <c>Output</c> class represents a single MIDI output port (not to be confused with a MIDI channel).
    /// A port is made available by a MIDI device. A MIDI device can advertise several input and output
    /// ports. Each port has 16 MIDI channels which can be accessed via the [<c>channels</c>](#channels)
    /// property.
    ///
    /// The <c>Output</c> object is automatically instantiated by the library according to the host's MIDI
    /// subsystem and should not be directly instantiated.
    ///
    /// You can access all available <c>Output</c> objects by referring to the
    /// [<c>WebMidi.outputs</c>](WebMidi#outputs) array or by using methods such as
    /// [<c>WebMidi.getOutputByName()</c>](WebMidi#getOutputByName) or
    /// [<c>WebMidi.getOutputById()</c>](WebMidi#getOutputById).
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("Output", "webmidi")>]
    type Output =
        /// <summary>
        /// Array containing the 16 [<c>OutputChannel</c>]<see href="OutputChannel">OutputChannel</see> objects available provided by
        /// this <c>Output</c>. The channels are numbered 1 through 16.
        /// </summary>
        abstract member channels: ResizeArray<Webmidi.OutputChannel> with get, set
        /// <summary>
        /// Adds an event listener that will trigger a function callback when the specified event is
        /// dispatched.
        ///
        /// Here are the events you can listen to: closed, disconnected, open.
        /// </summary>
        /// <param name="event">
        /// The type of the event.
        /// </param>
        /// <param name="listener">
        /// A callback function to execute when the specified event
        /// is detected. This function will receive an event parameter object. For details on this object's
        /// properties, check out the documentation for the various events (links above).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// The listener object that was created
        /// </returns>
        abstract member addListener<'T>: e: obj * listener: 'T * ?options: Output.addListener.options -> Webmidi.Listener
        /// <summary>
        /// Adds an event listener that will trigger a function callback when the specified event is
        /// dispatched.
        ///
        /// Here are the events you can listen to: closed, disconnected, open.
        /// </summary>
        /// <param name="event">
        /// The type of the event.
        /// </param>
        /// <param name="listener">
        /// A callback function to execute when the specified event
        /// is detected. This function will receive an event parameter object. For details on this object's
        /// properties, check out the documentation for the various events (links above).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// The listener object that was created
        /// </returns>
        abstract member addListener<'T>: e: Webmidi.PortEventMap.Key<'T> * listener: 'T * ?options: Output.addListener.options -> Webmidi.Listener
        /// <summary>
        /// Adds an event listener that will trigger a function callback when the specified event is
        /// dispatched.
        ///
        /// Here are the events you can listen to: closed, disconnected, open.
        /// </summary>
        /// <param name="event">
        /// The type of the event.
        /// </param>
        /// <param name="listener">
        /// A callback function to execute when the specified event
        /// is detected. This function will receive an event parameter object. For details on this object's
        /// properties, check out the documentation for the various events (links above).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// The listener object that was created
        /// </returns>
        abstract member addListener<'T>: e: U2<obj, Webmidi.PortEventMap.Key<'T>> * listener: 'T * ?options: Output.addListener.options -> Webmidi.Listener
        /// <summary>
        /// Adds a one-time event listener that will trigger a function callback when the specified event
        /// is dispatched.
        ///
        /// Here are the events you can listen to: closed, disconnected, open.
        /// </summary>
        /// <param name="event">
        /// The type of the event.
        /// </param>
        /// <param name="listener">
        /// A callback function to execute when the specified event
        /// is detected. This function will receive an event parameter object. For details on this object's
        /// properties, check out the documentation for the various events (links above).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// The listener object that was created
        /// </returns>
        abstract member addOneTimeListener<'T>: e: obj * listener: 'T * ?options: Output.addOneTimeListener.options -> Webmidi.Listener
        /// <summary>
        /// Adds a one-time event listener that will trigger a function callback when the specified event
        /// is dispatched.
        ///
        /// Here are the events you can listen to: closed, disconnected, open.
        /// </summary>
        /// <param name="event">
        /// The type of the event.
        /// </param>
        /// <param name="listener">
        /// A callback function to execute when the specified event
        /// is detected. This function will receive an event parameter object. For details on this object's
        /// properties, check out the documentation for the various events (links above).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// The listener object that was created
        /// </returns>
        abstract member addOneTimeListener<'T>: e: Webmidi.PortEventMap.Key<'T> * listener: 'T * ?options: Output.addOneTimeListener.options -> Webmidi.Listener
        /// <summary>
        /// Adds a one-time event listener that will trigger a function callback when the specified event
        /// is dispatched.
        ///
        /// Here are the events you can listen to: closed, disconnected, open.
        /// </summary>
        /// <param name="event">
        /// The type of the event.
        /// </param>
        /// <param name="listener">
        /// A callback function to execute when the specified event
        /// is detected. This function will receive an event parameter object. For details on this object's
        /// properties, check out the documentation for the various events (links above).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// The listener object that was created
        /// </returns>
        abstract member addOneTimeListener<'T>: e: U2<obj, Webmidi.PortEventMap.Key<'T>> * listener: 'T * ?options: Output.addOneTimeListener.options -> Webmidi.Listener
        /// <summary>
        /// Clears all messages that have been queued but not yet delivered.
        ///
        /// **Warning**: this method has been defined in the specification but has not been implemented
        /// yet. As soon as browsers implement it, it will work.
        ///
        /// You can check out the current status of this feature for Chromium (Chrome) here:
        /// https://bugs.chromium.org/p/chromium/issues/detail?id=471798
        /// </summary>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member clear: unit -> Webmidi.Output
        /// <summary>
        /// Closes the output connection. When an output is closed, it cannot be used to send MIDI messages
        /// until the output is opened again by calling [<c>open()</c>]<see href="#open">#open</see>. You can check
        /// the connection status by looking at the [<c>connection</c>]<see href="#connection">#connection</see> property.
        /// </summary>
        abstract member close: unit -> JS.Promise<unit>
        /// <summary>
        /// Destroys the <c>Output</c>. All listeners are removed, all channels are destroyed and the MIDI
        /// subsystem is unlinked.
        /// </summary>
        abstract member destroy: unit -> JS.Promise<unit>
        /// <summary>
        /// Checks if the specified event type is already defined to trigger the specified callback
        /// function.
        /// </summary>
        /// <param name="event">
        /// The type of the event.
        /// </param>
        /// <param name="listener">
        /// The callback function to check for.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Boolean value indicating whether or not the <c>Input</c> or <c>InputChannel</c>
        /// already has this listener defined.
        /// </returns>
        abstract member hasListener<'T>: e: obj * listener: 'T -> bool
        /// <summary>
        /// Checks if the specified event type is already defined to trigger the specified callback
        /// function.
        /// </summary>
        /// <param name="event">
        /// The type of the event.
        /// </param>
        /// <param name="listener">
        /// The callback function to check for.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Boolean value indicating whether or not the <c>Input</c> or <c>InputChannel</c>
        /// already has this listener defined.
        /// </returns>
        abstract member hasListener<'T>: e: Webmidi.PortEventMap.Key<'T> * listener: 'T -> bool
        /// <summary>
        /// Checks if the specified event type is already defined to trigger the specified callback
        /// function.
        /// </summary>
        /// <param name="event">
        /// The type of the event.
        /// </param>
        /// <param name="listener">
        /// The callback function to check for.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Boolean value indicating whether or not the <c>Input</c> or <c>InputChannel</c>
        /// already has this listener defined.
        /// </returns>
        abstract member hasListener<'T>: e: U2<obj, Webmidi.PortEventMap.Key<'T>> * listener: 'T -> bool
        /// <summary>
        /// Opens the output for usage. When the library is enabled, all ports are automatically opened.
        /// This method is only useful for ports that have been manually closed.
        /// </summary>
        /// <returns>
        /// The promise is fulfilled with the <c>Output</c> object.
        /// </returns>
        abstract member ``open``: unit -> JS.Promise<Webmidi.Output>
        /// <summary>
        /// Plays a note or an array of notes on one or more channels of this output. If you intend to play
        /// notes on a single channel, you should probably use
        /// [<c>OutputChannel.playNote()</c>](OutputChannel#playNote) instead.
        ///
        /// The first parameter is the note to play. It can be a single value or an array of the following
        /// valid values:
        ///
        ///  - A MIDI note number (integer between <c>0</c> and <c>127</c>)
        ///  - A note identifier (e.g. <c>"C3"</c>, <c>"G#4"</c>, <c>"F-1"</c>, <c>"Db7"</c>)
        ///  - A [<c>Note</c>]<see href="Note">Note</see> object
        ///
        /// The <c>playNote()</c> method sends a **note on** MIDI message for all specified notes on all
        /// specified channels. If no channel is specified, it will send to all channels. If a <c>duration</c>
        /// is set in the <c>options</c> parameter or in the [<c>Note</c>]<see href="Note">Note</see> object's
        /// [<c>duration</c>]<see href="Note#duration">Note#duration</see> property, it will also schedule a **note off** message to end
        /// the note after said duration. If no <c>duration</c> is set, the note will simply play until a
        /// matching **note off** message is sent with [<c>stopNote()</c>]<see href="#stopNote">#stopNote</see>.
        ///
        /// The execution of the **note on** command can be delayed by using the <c>time</c> property of the
        /// <c>options</c> parameter.
        ///
        /// When using [<c>Note</c>]<see href="Note">Note</see> objects, the durations and velocities defined in the
        /// [<c>Note</c>]<see href="Note">Note</see> objects have precedence over the ones specified via the method's <c>options</c>
        /// parameter.
        ///
        /// **Note**: As per the MIDI standard, a **note on** message with an attack velocity of <c>0</c> is
        /// functionally equivalent to a **note off** message.
        /// </summary>
        /// <param name="note">
        /// The note(s) to play. The notes can be
        /// specified by using a MIDI note number (0-127), a note identifier (e.g. C3, G#4, F-1, Db7), a
        /// [<c>Note</c>]<see href="Note">Note</see> object or an array of the previous types. When using a note identifier,
        /// octave range must be between -1 and 9. The lowest note is C-1 (MIDI note number <c>0</c>) and the
        /// highest note is G9 (MIDI note number <c>127</c>).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member playNote: note: float * ?options: Output.playNote.options -> Webmidi.Output
        /// <summary>
        /// Plays a note or an array of notes on one or more channels of this output. If you intend to play
        /// notes on a single channel, you should probably use
        /// [<c>OutputChannel.playNote()</c>](OutputChannel#playNote) instead.
        ///
        /// The first parameter is the note to play. It can be a single value or an array of the following
        /// valid values:
        ///
        ///  - A MIDI note number (integer between <c>0</c> and <c>127</c>)
        ///  - A note identifier (e.g. <c>"C3"</c>, <c>"G#4"</c>, <c>"F-1"</c>, <c>"Db7"</c>)
        ///  - A [<c>Note</c>]<see href="Note">Note</see> object
        ///
        /// The <c>playNote()</c> method sends a **note on** MIDI message for all specified notes on all
        /// specified channels. If no channel is specified, it will send to all channels. If a <c>duration</c>
        /// is set in the <c>options</c> parameter or in the [<c>Note</c>]<see href="Note">Note</see> object's
        /// [<c>duration</c>]<see href="Note#duration">Note#duration</see> property, it will also schedule a **note off** message to end
        /// the note after said duration. If no <c>duration</c> is set, the note will simply play until a
        /// matching **note off** message is sent with [<c>stopNote()</c>]<see href="#stopNote">#stopNote</see>.
        ///
        /// The execution of the **note on** command can be delayed by using the <c>time</c> property of the
        /// <c>options</c> parameter.
        ///
        /// When using [<c>Note</c>]<see href="Note">Note</see> objects, the durations and velocities defined in the
        /// [<c>Note</c>]<see href="Note">Note</see> objects have precedence over the ones specified via the method's <c>options</c>
        /// parameter.
        ///
        /// **Note**: As per the MIDI standard, a **note on** message with an attack velocity of <c>0</c> is
        /// functionally equivalent to a **note off** message.
        /// </summary>
        /// <param name="note">
        /// The note(s) to play. The notes can be
        /// specified by using a MIDI note number (0-127), a note identifier (e.g. C3, G#4, F-1, Db7), a
        /// [<c>Note</c>]<see href="Note">Note</see> object or an array of the previous types. When using a note identifier,
        /// octave range must be between -1 and 9. The lowest note is C-1 (MIDI note number <c>0</c>) and the
        /// highest note is G9 (MIDI note number <c>127</c>).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member playNote: note: string * ?options: Output.playNote.options -> Webmidi.Output
        /// <summary>
        /// Plays a note or an array of notes on one or more channels of this output. If you intend to play
        /// notes on a single channel, you should probably use
        /// [<c>OutputChannel.playNote()</c>](OutputChannel#playNote) instead.
        ///
        /// The first parameter is the note to play. It can be a single value or an array of the following
        /// valid values:
        ///
        ///  - A MIDI note number (integer between <c>0</c> and <c>127</c>)
        ///  - A note identifier (e.g. <c>"C3"</c>, <c>"G#4"</c>, <c>"F-1"</c>, <c>"Db7"</c>)
        ///  - A [<c>Note</c>]<see href="Note">Note</see> object
        ///
        /// The <c>playNote()</c> method sends a **note on** MIDI message for all specified notes on all
        /// specified channels. If no channel is specified, it will send to all channels. If a <c>duration</c>
        /// is set in the <c>options</c> parameter or in the [<c>Note</c>]<see href="Note">Note</see> object's
        /// [<c>duration</c>]<see href="Note#duration">Note#duration</see> property, it will also schedule a **note off** message to end
        /// the note after said duration. If no <c>duration</c> is set, the note will simply play until a
        /// matching **note off** message is sent with [<c>stopNote()</c>]<see href="#stopNote">#stopNote</see>.
        ///
        /// The execution of the **note on** command can be delayed by using the <c>time</c> property of the
        /// <c>options</c> parameter.
        ///
        /// When using [<c>Note</c>]<see href="Note">Note</see> objects, the durations and velocities defined in the
        /// [<c>Note</c>]<see href="Note">Note</see> objects have precedence over the ones specified via the method's <c>options</c>
        /// parameter.
        ///
        /// **Note**: As per the MIDI standard, a **note on** message with an attack velocity of <c>0</c> is
        /// functionally equivalent to a **note off** message.
        /// </summary>
        /// <param name="note">
        /// The note(s) to play. The notes can be
        /// specified by using a MIDI note number (0-127), a note identifier (e.g. C3, G#4, F-1, Db7), a
        /// [<c>Note</c>]<see href="Note">Note</see> object or an array of the previous types. When using a note identifier,
        /// octave range must be between -1 and 9. The lowest note is C-1 (MIDI note number <c>0</c>) and the
        /// highest note is G9 (MIDI note number <c>127</c>).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member playNote: note: Webmidi.Note * ?options: Output.playNote.options -> Webmidi.Output
        /// <summary>
        /// Plays a note or an array of notes on one or more channels of this output. If you intend to play
        /// notes on a single channel, you should probably use
        /// [<c>OutputChannel.playNote()</c>](OutputChannel#playNote) instead.
        ///
        /// The first parameter is the note to play. It can be a single value or an array of the following
        /// valid values:
        ///
        ///  - A MIDI note number (integer between <c>0</c> and <c>127</c>)
        ///  - A note identifier (e.g. <c>"C3"</c>, <c>"G#4"</c>, <c>"F-1"</c>, <c>"Db7"</c>)
        ///  - A [<c>Note</c>]<see href="Note">Note</see> object
        ///
        /// The <c>playNote()</c> method sends a **note on** MIDI message for all specified notes on all
        /// specified channels. If no channel is specified, it will send to all channels. If a <c>duration</c>
        /// is set in the <c>options</c> parameter or in the [<c>Note</c>]<see href="Note">Note</see> object's
        /// [<c>duration</c>]<see href="Note#duration">Note#duration</see> property, it will also schedule a **note off** message to end
        /// the note after said duration. If no <c>duration</c> is set, the note will simply play until a
        /// matching **note off** message is sent with [<c>stopNote()</c>]<see href="#stopNote">#stopNote</see>.
        ///
        /// The execution of the **note on** command can be delayed by using the <c>time</c> property of the
        /// <c>options</c> parameter.
        ///
        /// When using [<c>Note</c>]<see href="Note">Note</see> objects, the durations and velocities defined in the
        /// [<c>Note</c>]<see href="Note">Note</see> objects have precedence over the ones specified via the method's <c>options</c>
        /// parameter.
        ///
        /// **Note**: As per the MIDI standard, a **note on** message with an attack velocity of <c>0</c> is
        /// functionally equivalent to a **note off** message.
        /// </summary>
        /// <param name="note">
        /// The note(s) to play. The notes can be
        /// specified by using a MIDI note number (0-127), a note identifier (e.g. C3, G#4, F-1, Db7), a
        /// [<c>Note</c>]<see href="Note">Note</see> object or an array of the previous types. When using a note identifier,
        /// octave range must be between -1 and 9. The lowest note is C-1 (MIDI note number <c>0</c>) and the
        /// highest note is G9 (MIDI note number <c>127</c>).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member playNote: note: ResizeArray<float> * ?options: Output.playNote.options -> Webmidi.Output
        /// <summary>
        /// Plays a note or an array of notes on one or more channels of this output. If you intend to play
        /// notes on a single channel, you should probably use
        /// [<c>OutputChannel.playNote()</c>](OutputChannel#playNote) instead.
        ///
        /// The first parameter is the note to play. It can be a single value or an array of the following
        /// valid values:
        ///
        ///  - A MIDI note number (integer between <c>0</c> and <c>127</c>)
        ///  - A note identifier (e.g. <c>"C3"</c>, <c>"G#4"</c>, <c>"F-1"</c>, <c>"Db7"</c>)
        ///  - A [<c>Note</c>]<see href="Note">Note</see> object
        ///
        /// The <c>playNote()</c> method sends a **note on** MIDI message for all specified notes on all
        /// specified channels. If no channel is specified, it will send to all channels. If a <c>duration</c>
        /// is set in the <c>options</c> parameter or in the [<c>Note</c>]<see href="Note">Note</see> object's
        /// [<c>duration</c>]<see href="Note#duration">Note#duration</see> property, it will also schedule a **note off** message to end
        /// the note after said duration. If no <c>duration</c> is set, the note will simply play until a
        /// matching **note off** message is sent with [<c>stopNote()</c>]<see href="#stopNote">#stopNote</see>.
        ///
        /// The execution of the **note on** command can be delayed by using the <c>time</c> property of the
        /// <c>options</c> parameter.
        ///
        /// When using [<c>Note</c>]<see href="Note">Note</see> objects, the durations and velocities defined in the
        /// [<c>Note</c>]<see href="Note">Note</see> objects have precedence over the ones specified via the method's <c>options</c>
        /// parameter.
        ///
        /// **Note**: As per the MIDI standard, a **note on** message with an attack velocity of <c>0</c> is
        /// functionally equivalent to a **note off** message.
        /// </summary>
        /// <param name="note">
        /// The note(s) to play. The notes can be
        /// specified by using a MIDI note number (0-127), a note identifier (e.g. C3, G#4, F-1, Db7), a
        /// [<c>Note</c>]<see href="Note">Note</see> object or an array of the previous types. When using a note identifier,
        /// octave range must be between -1 and 9. The lowest note is C-1 (MIDI note number <c>0</c>) and the
        /// highest note is G9 (MIDI note number <c>127</c>).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member playNote: note: ResizeArray<string> * ?options: Output.playNote.options -> Webmidi.Output
        /// <summary>
        /// Plays a note or an array of notes on one or more channels of this output. If you intend to play
        /// notes on a single channel, you should probably use
        /// [<c>OutputChannel.playNote()</c>](OutputChannel#playNote) instead.
        ///
        /// The first parameter is the note to play. It can be a single value or an array of the following
        /// valid values:
        ///
        ///  - A MIDI note number (integer between <c>0</c> and <c>127</c>)
        ///  - A note identifier (e.g. <c>"C3"</c>, <c>"G#4"</c>, <c>"F-1"</c>, <c>"Db7"</c>)
        ///  - A [<c>Note</c>]<see href="Note">Note</see> object
        ///
        /// The <c>playNote()</c> method sends a **note on** MIDI message for all specified notes on all
        /// specified channels. If no channel is specified, it will send to all channels. If a <c>duration</c>
        /// is set in the <c>options</c> parameter or in the [<c>Note</c>]<see href="Note">Note</see> object's
        /// [<c>duration</c>]<see href="Note#duration">Note#duration</see> property, it will also schedule a **note off** message to end
        /// the note after said duration. If no <c>duration</c> is set, the note will simply play until a
        /// matching **note off** message is sent with [<c>stopNote()</c>]<see href="#stopNote">#stopNote</see>.
        ///
        /// The execution of the **note on** command can be delayed by using the <c>time</c> property of the
        /// <c>options</c> parameter.
        ///
        /// When using [<c>Note</c>]<see href="Note">Note</see> objects, the durations and velocities defined in the
        /// [<c>Note</c>]<see href="Note">Note</see> objects have precedence over the ones specified via the method's <c>options</c>
        /// parameter.
        ///
        /// **Note**: As per the MIDI standard, a **note on** message with an attack velocity of <c>0</c> is
        /// functionally equivalent to a **note off** message.
        /// </summary>
        /// <param name="note">
        /// The note(s) to play. The notes can be
        /// specified by using a MIDI note number (0-127), a note identifier (e.g. C3, G#4, F-1, Db7), a
        /// [<c>Note</c>]<see href="Note">Note</see> object or an array of the previous types. When using a note identifier,
        /// octave range must be between -1 and 9. The lowest note is C-1 (MIDI note number <c>0</c>) and the
        /// highest note is G9 (MIDI note number <c>127</c>).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member playNote: note: ResizeArray<Webmidi.Note> * ?options: Output.playNote.options -> Webmidi.Output
        /// <summary>
        /// Plays a note or an array of notes on one or more channels of this output. If you intend to play
        /// notes on a single channel, you should probably use
        /// [<c>OutputChannel.playNote()</c>](OutputChannel#playNote) instead.
        ///
        /// The first parameter is the note to play. It can be a single value or an array of the following
        /// valid values:
        ///
        ///  - A MIDI note number (integer between <c>0</c> and <c>127</c>)
        ///  - A note identifier (e.g. <c>"C3"</c>, <c>"G#4"</c>, <c>"F-1"</c>, <c>"Db7"</c>)
        ///  - A [<c>Note</c>]<see href="Note">Note</see> object
        ///
        /// The <c>playNote()</c> method sends a **note on** MIDI message for all specified notes on all
        /// specified channels. If no channel is specified, it will send to all channels. If a <c>duration</c>
        /// is set in the <c>options</c> parameter or in the [<c>Note</c>]<see href="Note">Note</see> object's
        /// [<c>duration</c>]<see href="Note#duration">Note#duration</see> property, it will also schedule a **note off** message to end
        /// the note after said duration. If no <c>duration</c> is set, the note will simply play until a
        /// matching **note off** message is sent with [<c>stopNote()</c>]<see href="#stopNote">#stopNote</see>.
        ///
        /// The execution of the **note on** command can be delayed by using the <c>time</c> property of the
        /// <c>options</c> parameter.
        ///
        /// When using [<c>Note</c>]<see href="Note">Note</see> objects, the durations and velocities defined in the
        /// [<c>Note</c>]<see href="Note">Note</see> objects have precedence over the ones specified via the method's <c>options</c>
        /// parameter.
        ///
        /// **Note**: As per the MIDI standard, a **note on** message with an attack velocity of <c>0</c> is
        /// functionally equivalent to a **note off** message.
        /// </summary>
        /// <param name="note">
        /// The note(s) to play. The notes can be
        /// specified by using a MIDI note number (0-127), a note identifier (e.g. C3, G#4, F-1, Db7), a
        /// [<c>Note</c>]<see href="Note">Note</see> object or an array of the previous types. When using a note identifier,
        /// octave range must be between -1 and 9. The lowest note is C-1 (MIDI note number <c>0</c>) and the
        /// highest note is G9 (MIDI note number <c>127</c>).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member playNote: note: U6<float, string, Webmidi.Note, ResizeArray<float>, ResizeArray<string>, ResizeArray<Webmidi.Note>> * ?options: Output.playNote.options -> Webmidi.Output
        /// <summary>
        /// Removes the specified listener for the specified event. If no listener is specified, all
        /// listeners for the specified event will be removed.
        /// </summary>
        /// <param name="type">
        /// The type of the event.
        /// </param>
        /// <param name="listener">
        /// The callback function to check for.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        abstract member removeListener: unit -> unit
        /// <summary>
        /// Removes the specified listener for the specified event. If no listener is specified, all
        /// listeners for the specified event will be removed.
        /// </summary>
        /// <param name="type">
        /// The type of the event.
        /// </param>
        /// <param name="listener">
        /// The callback function to check for.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        abstract member removeListener<'T>: ``type``: obj * ?listener: 'T * ?options: Output.removeListener.options -> unit
        /// <summary>
        /// Removes the specified listener for the specified event. If no listener is specified, all
        /// listeners for the specified event will be removed.
        /// </summary>
        /// <param name="type">
        /// The type of the event.
        /// </param>
        /// <param name="listener">
        /// The callback function to check for.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        abstract member removeListener<'T>: ``type``: Webmidi.PortEventMap.Key<'T> * ?listener: 'T * ?options: Output.removeListener.options -> unit
        /// <summary>
        /// Sends a MIDI message on the MIDI output port. If no time is specified, the message will be
        /// sent immediately. The message should be an array of 8 bit unsigned integers (0-225), a
        /// [<c>Uint8Array</c>]<see href="https://developer.mozilla.org/docs/Web/JavaScript/Reference/Global_Objects/Uint8Array">https://developer.mozilla.org/docs/Web/JavaScript/Reference/Global_Objects/Uint8Array</see>
        /// object or a [<c>Message</c>](Message) object.
        ///
        /// It is usually not necessary to use this method directly as you can use one of the simpler
        /// helper methods such as [<c>playNote()</c>](#playNote), [<c>stopNote()</c>](#stopNote),
        /// [<c>sendControlChange()</c>](#sendControlChange), etc.
        ///
        /// Details on the format of MIDI messages are available in the summary of
        /// [MIDI messages]<see href="https://www.midi.org/specifications-old/item/table-1-summary-of-midi-message">https://www.midi.org/specifications-old/item/table-1-summary-of-midi-message</see>
        /// from the MIDI Manufacturers Association.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// The first byte (status) must be an integer between 128 and 255.
        /// </remarks>
        /// <param name="message">
        /// An array of 8bit unsigned integers, a <c>Uint8Array</c>
        /// object (not available in Node.js) containing the message bytes or a <c>Message</c> object.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member send: message: ResizeArray<float> * ?options: Output.send.options * ?legacy: float -> Webmidi.Output
        /// <summary>
        /// Sends a MIDI message on the MIDI output port. If no time is specified, the message will be
        /// sent immediately. The message should be an array of 8 bit unsigned integers (0-225), a
        /// [<c>Uint8Array</c>]<see href="https://developer.mozilla.org/docs/Web/JavaScript/Reference/Global_Objects/Uint8Array">https://developer.mozilla.org/docs/Web/JavaScript/Reference/Global_Objects/Uint8Array</see>
        /// object or a [<c>Message</c>](Message) object.
        ///
        /// It is usually not necessary to use this method directly as you can use one of the simpler
        /// helper methods such as [<c>playNote()</c>](#playNote), [<c>stopNote()</c>](#stopNote),
        /// [<c>sendControlChange()</c>](#sendControlChange), etc.
        ///
        /// Details on the format of MIDI messages are available in the summary of
        /// [MIDI messages]<see href="https://www.midi.org/specifications-old/item/table-1-summary-of-midi-message">https://www.midi.org/specifications-old/item/table-1-summary-of-midi-message</see>
        /// from the MIDI Manufacturers Association.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// The first byte (status) must be an integer between 128 and 255.
        /// </remarks>
        /// <param name="message">
        /// An array of 8bit unsigned integers, a <c>Uint8Array</c>
        /// object (not available in Node.js) containing the message bytes or a <c>Message</c> object.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member send: message: JS.Uint8Array * ?options: Output.send.options * ?legacy: float -> Webmidi.Output
        /// <summary>
        /// Sends a MIDI message on the MIDI output port. If no time is specified, the message will be
        /// sent immediately. The message should be an array of 8 bit unsigned integers (0-225), a
        /// [<c>Uint8Array</c>]<see href="https://developer.mozilla.org/docs/Web/JavaScript/Reference/Global_Objects/Uint8Array">https://developer.mozilla.org/docs/Web/JavaScript/Reference/Global_Objects/Uint8Array</see>
        /// object or a [<c>Message</c>](Message) object.
        ///
        /// It is usually not necessary to use this method directly as you can use one of the simpler
        /// helper methods such as [<c>playNote()</c>](#playNote), [<c>stopNote()</c>](#stopNote),
        /// [<c>sendControlChange()</c>](#sendControlChange), etc.
        ///
        /// Details on the format of MIDI messages are available in the summary of
        /// [MIDI messages]<see href="https://www.midi.org/specifications-old/item/table-1-summary-of-midi-message">https://www.midi.org/specifications-old/item/table-1-summary-of-midi-message</see>
        /// from the MIDI Manufacturers Association.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// The first byte (status) must be an integer between 128 and 255.
        /// </remarks>
        /// <param name="message">
        /// An array of 8bit unsigned integers, a <c>Uint8Array</c>
        /// object (not available in Node.js) containing the message bytes or a <c>Message</c> object.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member send: message: Webmidi.Message * ?options: Output.send.options * ?legacy: float -> Webmidi.Output
        /// <summary>
        /// Sends a MIDI message on the MIDI output port. If no time is specified, the message will be
        /// sent immediately. The message should be an array of 8 bit unsigned integers (0-225), a
        /// [<c>Uint8Array</c>]<see href="https://developer.mozilla.org/docs/Web/JavaScript/Reference/Global_Objects/Uint8Array">https://developer.mozilla.org/docs/Web/JavaScript/Reference/Global_Objects/Uint8Array</see>
        /// object or a [<c>Message</c>](Message) object.
        ///
        /// It is usually not necessary to use this method directly as you can use one of the simpler
        /// helper methods such as [<c>playNote()</c>](#playNote), [<c>stopNote()</c>](#stopNote),
        /// [<c>sendControlChange()</c>](#sendControlChange), etc.
        ///
        /// Details on the format of MIDI messages are available in the summary of
        /// [MIDI messages]<see href="https://www.midi.org/specifications-old/item/table-1-summary-of-midi-message">https://www.midi.org/specifications-old/item/table-1-summary-of-midi-message</see>
        /// from the MIDI Manufacturers Association.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// The first byte (status) must be an integer between 128 and 255.
        /// </remarks>
        /// <param name="message">
        /// An array of 8bit unsigned integers, a <c>Uint8Array</c>
        /// object (not available in Node.js) containing the message bytes or a <c>Message</c> object.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member send: message: U3<ResizeArray<float>, JS.Uint8Array, Webmidi.Message> * ?options: Output.send.options * ?legacy: float -> Webmidi.Output
        /// <summary>
        /// Sends a MIDI [**system exclusive**]<see href="*">https://www.midi.org/specifications-old/item/table-4-universal-system-exclusive-messages</see>
        /// (*sysex*) message. There are two categories of system exclusive messages: manufacturer-specific
        /// messages and universal messages. Universal messages are further divided into three subtypes:
        ///
        ///   * Universal non-commercial (for research and testing): <c>0x7D</c>
        ///   * Universal non-realtime: <c>0x7E</c>
        ///   * Universal realtime: <c>0x7F</c>
        ///
        /// The method's first parameter (<c>identification</c>) identifies the type of message. If the value of
        /// <c>identification</c> is <c>0x7D</c> (125), <c>0x7E</c> (126) or <c>0x7F</c> (127), the message will be identified
        /// as a **universal non-commercial**, **universal non-realtime** or **universal realtime** message
        /// (respectively).
        ///
        /// If the <c>identification</c> value is an array or an integer between 0 and 124, it will be used to
        /// identify the manufacturer targeted by the message. The *MIDI Manufacturers Association*
        /// maintains a full list of
        /// [Manufacturer ID Numbers](https://www.midi.org/specifications-old/item/manufacturer-id-numbers).
        ///
        /// The <c>data</c> parameter should only contain the data of the message. When sending out the actual
        /// MIDI message, WEBMIDI.js will automatically prepend the data with the **sysex byte** (<c>0xF0</c>)
        /// and the identification byte(s). It will also automatically terminate the message with the
        /// **sysex end byte** (<c>0xF7</c>).
        ///
        /// To use the <c>sendSysex()</c> method, system exclusive message support must have been enabled. To
        /// do so, you must set the <c>sysex</c> option to <c>true</c> when calling
        /// [<c>WebMidi.enable()</c>]<see href="WebMidi#enable">WebMidi#enable</see>:
        ///
        /// <code lang="js">
        /// WebMidi.enable({sysex: true})
        ///   .then(() => console.log("System exclusive messages are enabled");
        /// </code>
        ///
        /// ##### Examples of manufacturer-specific system exclusive messages
        ///
        /// If you want to send a sysex message to a Korg device connected to the first output, you would
        /// use the following code:
        ///
        /// <code lang="js">
        /// WebMidi.outputs[0].sendSysex(0x42, [0x1, 0x2, 0x3, 0x4, 0x5]);
        /// </code>
        /// In this case <c>0x42</c> is the ID of the manufacturer (Korg) and <c>[0x1, 0x2, 0x3, 0x4, 0x5]</c> is the
        /// data being sent.
        ///
        /// The parameters can be specified using any number notation (decimal, hex, binary, etc.).
        /// Therefore, the code above is equivalent to this code:
        ///
        /// <code lang="js">
        /// WebMidi.outputs[0].sendSysex(66, [1, 2, 3, 4, 5]);
        /// </code>
        ///
        /// Some manufacturers are identified using 3 bytes. In this case, you would use a 3-position array
        /// as the first parameter. For example, to send the same sysex message to a
        /// *Native Instruments* device:
        ///
        /// <code lang="js">
        /// WebMidi.outputs[0].sendSysex([0x00, 0x21, 0x09], [0x1, 0x2, 0x3, 0x4, 0x5]);
        /// </code>
        ///
        /// There is no limit for the length of the data array. However, it is generally suggested to keep
        /// system exclusive messages to 64Kb or less.
        ///
        /// ##### Example of universal system exclusive message
        ///
        /// If you want to send a universal sysex message, simply assign the correct identification number
        /// in the first parameter. Number <c>0x7D</c> (125) is for non-commercial, <c>0x7E</c> (126) is for
        /// non-realtime and <c>0x7F</c> (127) is for realtime.
        ///
        /// So, for example, if you wanted to send an identity request non-realtime message (<c>0x7E</c>), you
        /// could use the following:
        ///
        /// <code lang="js">
        /// WebMidi.outputs[0].sendSysex(0x7E, [0x7F, 0x06, 0x01]);
        /// </code>
        ///
        /// For more details on the format of universal messages, consult the list of
        /// [universal sysex messages](https://www.midi.org/specifications-old/item/table-4-universal-system-exclusive-messages).
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// Failed to execute 'send' on 'MIDIOutput': System exclusive message is
        /// not allowed.
        ///
        /// Failed to execute 'send' on 'MIDIOutput': The value at index x is greater
        /// than 0xFF.
        /// </remarks>
        /// <param name="identification">
        /// An unsigned integer or an array of three unsigned
        /// integers between <c>0</c> and <c>127</c> that either identify the manufacturer or sets the message to be
        /// a **universal non-commercial message** (<c>0x7D</c>), a **universal non-realtime message** (<c>0x7E</c>)
        /// or a **universal realtime message** (<c>0x7F</c>). The *MIDI Manufacturers Association* maintains a
        /// full list of
        /// [Manufacturer ID Numbers](https://www.midi.org/specifications-old/item/manufacturer-id-numbers).
        /// </param>
        /// <param name="data">
        /// A <c>Uint8Array</c> or an array of unsigned integers between <c>0</c>
        /// and <c>127</c>. This is the data you wish to transfer.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendSysex: identification: float -> Webmidi.Output
        /// <summary>
        /// Sends a MIDI [**system exclusive**]<see href="*">https://www.midi.org/specifications-old/item/table-4-universal-system-exclusive-messages</see>
        /// (*sysex*) message. There are two categories of system exclusive messages: manufacturer-specific
        /// messages and universal messages. Universal messages are further divided into three subtypes:
        ///
        ///   * Universal non-commercial (for research and testing): <c>0x7D</c>
        ///   * Universal non-realtime: <c>0x7E</c>
        ///   * Universal realtime: <c>0x7F</c>
        ///
        /// The method's first parameter (<c>identification</c>) identifies the type of message. If the value of
        /// <c>identification</c> is <c>0x7D</c> (125), <c>0x7E</c> (126) or <c>0x7F</c> (127), the message will be identified
        /// as a **universal non-commercial**, **universal non-realtime** or **universal realtime** message
        /// (respectively).
        ///
        /// If the <c>identification</c> value is an array or an integer between 0 and 124, it will be used to
        /// identify the manufacturer targeted by the message. The *MIDI Manufacturers Association*
        /// maintains a full list of
        /// [Manufacturer ID Numbers](https://www.midi.org/specifications-old/item/manufacturer-id-numbers).
        ///
        /// The <c>data</c> parameter should only contain the data of the message. When sending out the actual
        /// MIDI message, WEBMIDI.js will automatically prepend the data with the **sysex byte** (<c>0xF0</c>)
        /// and the identification byte(s). It will also automatically terminate the message with the
        /// **sysex end byte** (<c>0xF7</c>).
        ///
        /// To use the <c>sendSysex()</c> method, system exclusive message support must have been enabled. To
        /// do so, you must set the <c>sysex</c> option to <c>true</c> when calling
        /// [<c>WebMidi.enable()</c>]<see href="WebMidi#enable">WebMidi#enable</see>:
        ///
        /// <code lang="js">
        /// WebMidi.enable({sysex: true})
        ///   .then(() => console.log("System exclusive messages are enabled");
        /// </code>
        ///
        /// ##### Examples of manufacturer-specific system exclusive messages
        ///
        /// If you want to send a sysex message to a Korg device connected to the first output, you would
        /// use the following code:
        ///
        /// <code lang="js">
        /// WebMidi.outputs[0].sendSysex(0x42, [0x1, 0x2, 0x3, 0x4, 0x5]);
        /// </code>
        /// In this case <c>0x42</c> is the ID of the manufacturer (Korg) and <c>[0x1, 0x2, 0x3, 0x4, 0x5]</c> is the
        /// data being sent.
        ///
        /// The parameters can be specified using any number notation (decimal, hex, binary, etc.).
        /// Therefore, the code above is equivalent to this code:
        ///
        /// <code lang="js">
        /// WebMidi.outputs[0].sendSysex(66, [1, 2, 3, 4, 5]);
        /// </code>
        ///
        /// Some manufacturers are identified using 3 bytes. In this case, you would use a 3-position array
        /// as the first parameter. For example, to send the same sysex message to a
        /// *Native Instruments* device:
        ///
        /// <code lang="js">
        /// WebMidi.outputs[0].sendSysex([0x00, 0x21, 0x09], [0x1, 0x2, 0x3, 0x4, 0x5]);
        /// </code>
        ///
        /// There is no limit for the length of the data array. However, it is generally suggested to keep
        /// system exclusive messages to 64Kb or less.
        ///
        /// ##### Example of universal system exclusive message
        ///
        /// If you want to send a universal sysex message, simply assign the correct identification number
        /// in the first parameter. Number <c>0x7D</c> (125) is for non-commercial, <c>0x7E</c> (126) is for
        /// non-realtime and <c>0x7F</c> (127) is for realtime.
        ///
        /// So, for example, if you wanted to send an identity request non-realtime message (<c>0x7E</c>), you
        /// could use the following:
        ///
        /// <code lang="js">
        /// WebMidi.outputs[0].sendSysex(0x7E, [0x7F, 0x06, 0x01]);
        /// </code>
        ///
        /// For more details on the format of universal messages, consult the list of
        /// [universal sysex messages](https://www.midi.org/specifications-old/item/table-4-universal-system-exclusive-messages).
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// Failed to execute 'send' on 'MIDIOutput': System exclusive message is
        /// not allowed.
        ///
        /// Failed to execute 'send' on 'MIDIOutput': The value at index x is greater
        /// than 0xFF.
        /// </remarks>
        /// <param name="identification">
        /// An unsigned integer or an array of three unsigned
        /// integers between <c>0</c> and <c>127</c> that either identify the manufacturer or sets the message to be
        /// a **universal non-commercial message** (<c>0x7D</c>), a **universal non-realtime message** (<c>0x7E</c>)
        /// or a **universal realtime message** (<c>0x7F</c>). The *MIDI Manufacturers Association* maintains a
        /// full list of
        /// [Manufacturer ID Numbers](https://www.midi.org/specifications-old/item/manufacturer-id-numbers).
        /// </param>
        /// <param name="data">
        /// A <c>Uint8Array</c> or an array of unsigned integers between <c>0</c>
        /// and <c>127</c>. This is the data you wish to transfer.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendSysex: identification: float * data: ResizeArray<float> * ?options: Output.sendSysex.options -> Webmidi.Output
        /// <summary>
        /// Sends a MIDI [**system exclusive**]<see href="*">https://www.midi.org/specifications-old/item/table-4-universal-system-exclusive-messages</see>
        /// (*sysex*) message. There are two categories of system exclusive messages: manufacturer-specific
        /// messages and universal messages. Universal messages are further divided into three subtypes:
        ///
        ///   * Universal non-commercial (for research and testing): <c>0x7D</c>
        ///   * Universal non-realtime: <c>0x7E</c>
        ///   * Universal realtime: <c>0x7F</c>
        ///
        /// The method's first parameter (<c>identification</c>) identifies the type of message. If the value of
        /// <c>identification</c> is <c>0x7D</c> (125), <c>0x7E</c> (126) or <c>0x7F</c> (127), the message will be identified
        /// as a **universal non-commercial**, **universal non-realtime** or **universal realtime** message
        /// (respectively).
        ///
        /// If the <c>identification</c> value is an array or an integer between 0 and 124, it will be used to
        /// identify the manufacturer targeted by the message. The *MIDI Manufacturers Association*
        /// maintains a full list of
        /// [Manufacturer ID Numbers](https://www.midi.org/specifications-old/item/manufacturer-id-numbers).
        ///
        /// The <c>data</c> parameter should only contain the data of the message. When sending out the actual
        /// MIDI message, WEBMIDI.js will automatically prepend the data with the **sysex byte** (<c>0xF0</c>)
        /// and the identification byte(s). It will also automatically terminate the message with the
        /// **sysex end byte** (<c>0xF7</c>).
        ///
        /// To use the <c>sendSysex()</c> method, system exclusive message support must have been enabled. To
        /// do so, you must set the <c>sysex</c> option to <c>true</c> when calling
        /// [<c>WebMidi.enable()</c>]<see href="WebMidi#enable">WebMidi#enable</see>:
        ///
        /// <code lang="js">
        /// WebMidi.enable({sysex: true})
        ///   .then(() => console.log("System exclusive messages are enabled");
        /// </code>
        ///
        /// ##### Examples of manufacturer-specific system exclusive messages
        ///
        /// If you want to send a sysex message to a Korg device connected to the first output, you would
        /// use the following code:
        ///
        /// <code lang="js">
        /// WebMidi.outputs[0].sendSysex(0x42, [0x1, 0x2, 0x3, 0x4, 0x5]);
        /// </code>
        /// In this case <c>0x42</c> is the ID of the manufacturer (Korg) and <c>[0x1, 0x2, 0x3, 0x4, 0x5]</c> is the
        /// data being sent.
        ///
        /// The parameters can be specified using any number notation (decimal, hex, binary, etc.).
        /// Therefore, the code above is equivalent to this code:
        ///
        /// <code lang="js">
        /// WebMidi.outputs[0].sendSysex(66, [1, 2, 3, 4, 5]);
        /// </code>
        ///
        /// Some manufacturers are identified using 3 bytes. In this case, you would use a 3-position array
        /// as the first parameter. For example, to send the same sysex message to a
        /// *Native Instruments* device:
        ///
        /// <code lang="js">
        /// WebMidi.outputs[0].sendSysex([0x00, 0x21, 0x09], [0x1, 0x2, 0x3, 0x4, 0x5]);
        /// </code>
        ///
        /// There is no limit for the length of the data array. However, it is generally suggested to keep
        /// system exclusive messages to 64Kb or less.
        ///
        /// ##### Example of universal system exclusive message
        ///
        /// If you want to send a universal sysex message, simply assign the correct identification number
        /// in the first parameter. Number <c>0x7D</c> (125) is for non-commercial, <c>0x7E</c> (126) is for
        /// non-realtime and <c>0x7F</c> (127) is for realtime.
        ///
        /// So, for example, if you wanted to send an identity request non-realtime message (<c>0x7E</c>), you
        /// could use the following:
        ///
        /// <code lang="js">
        /// WebMidi.outputs[0].sendSysex(0x7E, [0x7F, 0x06, 0x01]);
        /// </code>
        ///
        /// For more details on the format of universal messages, consult the list of
        /// [universal sysex messages](https://www.midi.org/specifications-old/item/table-4-universal-system-exclusive-messages).
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// Failed to execute 'send' on 'MIDIOutput': System exclusive message is
        /// not allowed.
        ///
        /// Failed to execute 'send' on 'MIDIOutput': The value at index x is greater
        /// than 0xFF.
        /// </remarks>
        /// <param name="identification">
        /// An unsigned integer or an array of three unsigned
        /// integers between <c>0</c> and <c>127</c> that either identify the manufacturer or sets the message to be
        /// a **universal non-commercial message** (<c>0x7D</c>), a **universal non-realtime message** (<c>0x7E</c>)
        /// or a **universal realtime message** (<c>0x7F</c>). The *MIDI Manufacturers Association* maintains a
        /// full list of
        /// [Manufacturer ID Numbers](https://www.midi.org/specifications-old/item/manufacturer-id-numbers).
        /// </param>
        /// <param name="data">
        /// A <c>Uint8Array</c> or an array of unsigned integers between <c>0</c>
        /// and <c>127</c>. This is the data you wish to transfer.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendSysex: identification: float * data: JS.Uint8Array * ?options: Output.sendSysex.options -> Webmidi.Output
        /// <summary>
        /// Sends a MIDI [**system exclusive**]<see href="*">https://www.midi.org/specifications-old/item/table-4-universal-system-exclusive-messages</see>
        /// (*sysex*) message. There are two categories of system exclusive messages: manufacturer-specific
        /// messages and universal messages. Universal messages are further divided into three subtypes:
        ///
        ///   * Universal non-commercial (for research and testing): <c>0x7D</c>
        ///   * Universal non-realtime: <c>0x7E</c>
        ///   * Universal realtime: <c>0x7F</c>
        ///
        /// The method's first parameter (<c>identification</c>) identifies the type of message. If the value of
        /// <c>identification</c> is <c>0x7D</c> (125), <c>0x7E</c> (126) or <c>0x7F</c> (127), the message will be identified
        /// as a **universal non-commercial**, **universal non-realtime** or **universal realtime** message
        /// (respectively).
        ///
        /// If the <c>identification</c> value is an array or an integer between 0 and 124, it will be used to
        /// identify the manufacturer targeted by the message. The *MIDI Manufacturers Association*
        /// maintains a full list of
        /// [Manufacturer ID Numbers](https://www.midi.org/specifications-old/item/manufacturer-id-numbers).
        ///
        /// The <c>data</c> parameter should only contain the data of the message. When sending out the actual
        /// MIDI message, WEBMIDI.js will automatically prepend the data with the **sysex byte** (<c>0xF0</c>)
        /// and the identification byte(s). It will also automatically terminate the message with the
        /// **sysex end byte** (<c>0xF7</c>).
        ///
        /// To use the <c>sendSysex()</c> method, system exclusive message support must have been enabled. To
        /// do so, you must set the <c>sysex</c> option to <c>true</c> when calling
        /// [<c>WebMidi.enable()</c>]<see href="WebMidi#enable">WebMidi#enable</see>:
        ///
        /// <code lang="js">
        /// WebMidi.enable({sysex: true})
        ///   .then(() => console.log("System exclusive messages are enabled");
        /// </code>
        ///
        /// ##### Examples of manufacturer-specific system exclusive messages
        ///
        /// If you want to send a sysex message to a Korg device connected to the first output, you would
        /// use the following code:
        ///
        /// <code lang="js">
        /// WebMidi.outputs[0].sendSysex(0x42, [0x1, 0x2, 0x3, 0x4, 0x5]);
        /// </code>
        /// In this case <c>0x42</c> is the ID of the manufacturer (Korg) and <c>[0x1, 0x2, 0x3, 0x4, 0x5]</c> is the
        /// data being sent.
        ///
        /// The parameters can be specified using any number notation (decimal, hex, binary, etc.).
        /// Therefore, the code above is equivalent to this code:
        ///
        /// <code lang="js">
        /// WebMidi.outputs[0].sendSysex(66, [1, 2, 3, 4, 5]);
        /// </code>
        ///
        /// Some manufacturers are identified using 3 bytes. In this case, you would use a 3-position array
        /// as the first parameter. For example, to send the same sysex message to a
        /// *Native Instruments* device:
        ///
        /// <code lang="js">
        /// WebMidi.outputs[0].sendSysex([0x00, 0x21, 0x09], [0x1, 0x2, 0x3, 0x4, 0x5]);
        /// </code>
        ///
        /// There is no limit for the length of the data array. However, it is generally suggested to keep
        /// system exclusive messages to 64Kb or less.
        ///
        /// ##### Example of universal system exclusive message
        ///
        /// If you want to send a universal sysex message, simply assign the correct identification number
        /// in the first parameter. Number <c>0x7D</c> (125) is for non-commercial, <c>0x7E</c> (126) is for
        /// non-realtime and <c>0x7F</c> (127) is for realtime.
        ///
        /// So, for example, if you wanted to send an identity request non-realtime message (<c>0x7E</c>), you
        /// could use the following:
        ///
        /// <code lang="js">
        /// WebMidi.outputs[0].sendSysex(0x7E, [0x7F, 0x06, 0x01]);
        /// </code>
        ///
        /// For more details on the format of universal messages, consult the list of
        /// [universal sysex messages](https://www.midi.org/specifications-old/item/table-4-universal-system-exclusive-messages).
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// Failed to execute 'send' on 'MIDIOutput': System exclusive message is
        /// not allowed.
        ///
        /// Failed to execute 'send' on 'MIDIOutput': The value at index x is greater
        /// than 0xFF.
        /// </remarks>
        /// <param name="identification">
        /// An unsigned integer or an array of three unsigned
        /// integers between <c>0</c> and <c>127</c> that either identify the manufacturer or sets the message to be
        /// a **universal non-commercial message** (<c>0x7D</c>), a **universal non-realtime message** (<c>0x7E</c>)
        /// or a **universal realtime message** (<c>0x7F</c>). The *MIDI Manufacturers Association* maintains a
        /// full list of
        /// [Manufacturer ID Numbers](https://www.midi.org/specifications-old/item/manufacturer-id-numbers).
        /// </param>
        /// <param name="data">
        /// A <c>Uint8Array</c> or an array of unsigned integers between <c>0</c>
        /// and <c>127</c>. This is the data you wish to transfer.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendSysex: identification: ResizeArray<float> -> Webmidi.Output
        /// <summary>
        /// Sends a MIDI [**system exclusive**]<see href="*">https://www.midi.org/specifications-old/item/table-4-universal-system-exclusive-messages</see>
        /// (*sysex*) message. There are two categories of system exclusive messages: manufacturer-specific
        /// messages and universal messages. Universal messages are further divided into three subtypes:
        ///
        ///   * Universal non-commercial (for research and testing): <c>0x7D</c>
        ///   * Universal non-realtime: <c>0x7E</c>
        ///   * Universal realtime: <c>0x7F</c>
        ///
        /// The method's first parameter (<c>identification</c>) identifies the type of message. If the value of
        /// <c>identification</c> is <c>0x7D</c> (125), <c>0x7E</c> (126) or <c>0x7F</c> (127), the message will be identified
        /// as a **universal non-commercial**, **universal non-realtime** or **universal realtime** message
        /// (respectively).
        ///
        /// If the <c>identification</c> value is an array or an integer between 0 and 124, it will be used to
        /// identify the manufacturer targeted by the message. The *MIDI Manufacturers Association*
        /// maintains a full list of
        /// [Manufacturer ID Numbers](https://www.midi.org/specifications-old/item/manufacturer-id-numbers).
        ///
        /// The <c>data</c> parameter should only contain the data of the message. When sending out the actual
        /// MIDI message, WEBMIDI.js will automatically prepend the data with the **sysex byte** (<c>0xF0</c>)
        /// and the identification byte(s). It will also automatically terminate the message with the
        /// **sysex end byte** (<c>0xF7</c>).
        ///
        /// To use the <c>sendSysex()</c> method, system exclusive message support must have been enabled. To
        /// do so, you must set the <c>sysex</c> option to <c>true</c> when calling
        /// [<c>WebMidi.enable()</c>]<see href="WebMidi#enable">WebMidi#enable</see>:
        ///
        /// <code lang="js">
        /// WebMidi.enable({sysex: true})
        ///   .then(() => console.log("System exclusive messages are enabled");
        /// </code>
        ///
        /// ##### Examples of manufacturer-specific system exclusive messages
        ///
        /// If you want to send a sysex message to a Korg device connected to the first output, you would
        /// use the following code:
        ///
        /// <code lang="js">
        /// WebMidi.outputs[0].sendSysex(0x42, [0x1, 0x2, 0x3, 0x4, 0x5]);
        /// </code>
        /// In this case <c>0x42</c> is the ID of the manufacturer (Korg) and <c>[0x1, 0x2, 0x3, 0x4, 0x5]</c> is the
        /// data being sent.
        ///
        /// The parameters can be specified using any number notation (decimal, hex, binary, etc.).
        /// Therefore, the code above is equivalent to this code:
        ///
        /// <code lang="js">
        /// WebMidi.outputs[0].sendSysex(66, [1, 2, 3, 4, 5]);
        /// </code>
        ///
        /// Some manufacturers are identified using 3 bytes. In this case, you would use a 3-position array
        /// as the first parameter. For example, to send the same sysex message to a
        /// *Native Instruments* device:
        ///
        /// <code lang="js">
        /// WebMidi.outputs[0].sendSysex([0x00, 0x21, 0x09], [0x1, 0x2, 0x3, 0x4, 0x5]);
        /// </code>
        ///
        /// There is no limit for the length of the data array. However, it is generally suggested to keep
        /// system exclusive messages to 64Kb or less.
        ///
        /// ##### Example of universal system exclusive message
        ///
        /// If you want to send a universal sysex message, simply assign the correct identification number
        /// in the first parameter. Number <c>0x7D</c> (125) is for non-commercial, <c>0x7E</c> (126) is for
        /// non-realtime and <c>0x7F</c> (127) is for realtime.
        ///
        /// So, for example, if you wanted to send an identity request non-realtime message (<c>0x7E</c>), you
        /// could use the following:
        ///
        /// <code lang="js">
        /// WebMidi.outputs[0].sendSysex(0x7E, [0x7F, 0x06, 0x01]);
        /// </code>
        ///
        /// For more details on the format of universal messages, consult the list of
        /// [universal sysex messages](https://www.midi.org/specifications-old/item/table-4-universal-system-exclusive-messages).
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// Failed to execute 'send' on 'MIDIOutput': System exclusive message is
        /// not allowed.
        ///
        /// Failed to execute 'send' on 'MIDIOutput': The value at index x is greater
        /// than 0xFF.
        /// </remarks>
        /// <param name="identification">
        /// An unsigned integer or an array of three unsigned
        /// integers between <c>0</c> and <c>127</c> that either identify the manufacturer or sets the message to be
        /// a **universal non-commercial message** (<c>0x7D</c>), a **universal non-realtime message** (<c>0x7E</c>)
        /// or a **universal realtime message** (<c>0x7F</c>). The *MIDI Manufacturers Association* maintains a
        /// full list of
        /// [Manufacturer ID Numbers](https://www.midi.org/specifications-old/item/manufacturer-id-numbers).
        /// </param>
        /// <param name="data">
        /// A <c>Uint8Array</c> or an array of unsigned integers between <c>0</c>
        /// and <c>127</c>. This is the data you wish to transfer.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendSysex: identification: ResizeArray<float> * data: ResizeArray<float> * ?options: Output.sendSysex.options -> Webmidi.Output
        /// <summary>
        /// Sends a MIDI [**system exclusive**]<see href="*">https://www.midi.org/specifications-old/item/table-4-universal-system-exclusive-messages</see>
        /// (*sysex*) message. There are two categories of system exclusive messages: manufacturer-specific
        /// messages and universal messages. Universal messages are further divided into three subtypes:
        ///
        ///   * Universal non-commercial (for research and testing): <c>0x7D</c>
        ///   * Universal non-realtime: <c>0x7E</c>
        ///   * Universal realtime: <c>0x7F</c>
        ///
        /// The method's first parameter (<c>identification</c>) identifies the type of message. If the value of
        /// <c>identification</c> is <c>0x7D</c> (125), <c>0x7E</c> (126) or <c>0x7F</c> (127), the message will be identified
        /// as a **universal non-commercial**, **universal non-realtime** or **universal realtime** message
        /// (respectively).
        ///
        /// If the <c>identification</c> value is an array or an integer between 0 and 124, it will be used to
        /// identify the manufacturer targeted by the message. The *MIDI Manufacturers Association*
        /// maintains a full list of
        /// [Manufacturer ID Numbers](https://www.midi.org/specifications-old/item/manufacturer-id-numbers).
        ///
        /// The <c>data</c> parameter should only contain the data of the message. When sending out the actual
        /// MIDI message, WEBMIDI.js will automatically prepend the data with the **sysex byte** (<c>0xF0</c>)
        /// and the identification byte(s). It will also automatically terminate the message with the
        /// **sysex end byte** (<c>0xF7</c>).
        ///
        /// To use the <c>sendSysex()</c> method, system exclusive message support must have been enabled. To
        /// do so, you must set the <c>sysex</c> option to <c>true</c> when calling
        /// [<c>WebMidi.enable()</c>]<see href="WebMidi#enable">WebMidi#enable</see>:
        ///
        /// <code lang="js">
        /// WebMidi.enable({sysex: true})
        ///   .then(() => console.log("System exclusive messages are enabled");
        /// </code>
        ///
        /// ##### Examples of manufacturer-specific system exclusive messages
        ///
        /// If you want to send a sysex message to a Korg device connected to the first output, you would
        /// use the following code:
        ///
        /// <code lang="js">
        /// WebMidi.outputs[0].sendSysex(0x42, [0x1, 0x2, 0x3, 0x4, 0x5]);
        /// </code>
        /// In this case <c>0x42</c> is the ID of the manufacturer (Korg) and <c>[0x1, 0x2, 0x3, 0x4, 0x5]</c> is the
        /// data being sent.
        ///
        /// The parameters can be specified using any number notation (decimal, hex, binary, etc.).
        /// Therefore, the code above is equivalent to this code:
        ///
        /// <code lang="js">
        /// WebMidi.outputs[0].sendSysex(66, [1, 2, 3, 4, 5]);
        /// </code>
        ///
        /// Some manufacturers are identified using 3 bytes. In this case, you would use a 3-position array
        /// as the first parameter. For example, to send the same sysex message to a
        /// *Native Instruments* device:
        ///
        /// <code lang="js">
        /// WebMidi.outputs[0].sendSysex([0x00, 0x21, 0x09], [0x1, 0x2, 0x3, 0x4, 0x5]);
        /// </code>
        ///
        /// There is no limit for the length of the data array. However, it is generally suggested to keep
        /// system exclusive messages to 64Kb or less.
        ///
        /// ##### Example of universal system exclusive message
        ///
        /// If you want to send a universal sysex message, simply assign the correct identification number
        /// in the first parameter. Number <c>0x7D</c> (125) is for non-commercial, <c>0x7E</c> (126) is for
        /// non-realtime and <c>0x7F</c> (127) is for realtime.
        ///
        /// So, for example, if you wanted to send an identity request non-realtime message (<c>0x7E</c>), you
        /// could use the following:
        ///
        /// <code lang="js">
        /// WebMidi.outputs[0].sendSysex(0x7E, [0x7F, 0x06, 0x01]);
        /// </code>
        ///
        /// For more details on the format of universal messages, consult the list of
        /// [universal sysex messages](https://www.midi.org/specifications-old/item/table-4-universal-system-exclusive-messages).
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// Failed to execute 'send' on 'MIDIOutput': System exclusive message is
        /// not allowed.
        ///
        /// Failed to execute 'send' on 'MIDIOutput': The value at index x is greater
        /// than 0xFF.
        /// </remarks>
        /// <param name="identification">
        /// An unsigned integer or an array of three unsigned
        /// integers between <c>0</c> and <c>127</c> that either identify the manufacturer or sets the message to be
        /// a **universal non-commercial message** (<c>0x7D</c>), a **universal non-realtime message** (<c>0x7E</c>)
        /// or a **universal realtime message** (<c>0x7F</c>). The *MIDI Manufacturers Association* maintains a
        /// full list of
        /// [Manufacturer ID Numbers](https://www.midi.org/specifications-old/item/manufacturer-id-numbers).
        /// </param>
        /// <param name="data">
        /// A <c>Uint8Array</c> or an array of unsigned integers between <c>0</c>
        /// and <c>127</c>. This is the data you wish to transfer.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendSysex: identification: ResizeArray<float> * data: JS.Uint8Array * ?options: Output.sendSysex.options -> Webmidi.Output
        /// <summary>
        /// Sends a MIDI **timecode quarter frame** message. Please note that no processing is being done
        /// on the data. It is up to the developer to format the data according to the
        /// [MIDI Timecode](https://en.wikipedia.org/wiki/MIDI_timecode) format.
        /// </summary>
        /// <param name="value">
        /// The quarter frame message content (integer between 0 and 127).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendTimecodeQuarterFrame: value: float * ?options: Output.sendTimecodeQuarterFrame.options -> Webmidi.Output
        /// <summary>
        /// Sends a **song position** MIDI message. The value is expressed in MIDI beats (between <c>0</c> and
        /// <c>16383</c>) which are 16th note. Position <c>0</c> is always the start of the song.
        /// </summary>
        /// <param name="value">
        /// The MIDI beat to cue to (integer between <c>0</c> and <c>16383</c>).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendSongPosition: ?value: float * ?options: Output.sendSongPosition.options -> Webmidi.Output
        /// <summary>
        /// Sends a **song select** MIDI message.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// The song number must be between 0 and 127.
        /// </remarks>
        /// <param name="value">
        /// The number of the song to select (integer between <c>0</c> and <c>127</c>).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendSongSelect: ?value: float * ?options: Output.sendSongSelect.options -> Webmidi.Output
        /// <summary>
        /// Sends a MIDI **tune request** real-time message.
        /// </summary>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendTuneRequest: ?options: Output.sendTuneRequest.options -> Webmidi.Output
        /// <summary>
        /// Sends a MIDI **clock** real-time message. According to the standard, there are 24 MIDI clocks
        /// for every quarter note.
        /// </summary>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendClock: ?options: Output.sendClock.options -> Webmidi.Output
        /// <summary>
        /// Sends a **start** real-time message. A MIDI Start message starts the playback of the current
        /// song at beat 0. To start playback elsewhere in the song, use the
        /// [<c>sendContinue()</c>]<see href="#sendContinue">#sendContinue</see> method.
        /// </summary>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendStart: ?options: Output.sendStart.options -> Webmidi.Output
        /// <summary>
        /// Sends a **continue** real-time message. This resumes song playback where it was previously
        /// stopped or where it was last cued with a song position message. To start playback from the
        /// start, use the [<c>sendStart()</c>]<see href="Output#sendStart">Output#sendStart</see>` method.
        /// </summary>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendContinue: ?options: Output.sendContinue.options -> Webmidi.Output
        /// <summary>
        /// Sends a **stop** real-time message. This tells the device connected to this output to stop
        /// playback immediately (or at the scheduled time, if specified).
        /// </summary>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendStop: ?options: Output.sendStop.options -> Webmidi.Output
        /// <summary>
        /// Sends an **active sensing** real-time message. This tells the device connected to this port
        /// that the connection is still good. Active sensing messages are often sent every 300 ms if there
        /// was no other activity on the MIDI port.
        /// </summary>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendActiveSensing: ?options: Output.sendActiveSensing.options -> Webmidi.Output
        /// <summary>
        /// Sends a **reset** real-time message. This tells the device connected to this output that it
        /// should reset itself to a default state.
        /// </summary>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendReset: ?options: Output.sendReset.options -> Webmidi.Output
        /// <summary>
        /// Sends a MIDI **key aftertouch** message to the specified channel(s) at the scheduled time. This
        /// is a key-specific aftertouch. For a channel-wide aftertouch message, use
        /// [<c>setChannelAftertouch()</c>]<see href="#setChannelAftertouch">#setChannelAftertouch</see>.
        /// </summary>
        /// <param name="note">
        /// The note(s) for which you are sending
        /// an aftertouch value. The notes can be specified by using a MIDI note number (<c>0</c> - <c>127</c>), a
        /// [<c>Note</c>](Note) object, a note identifier (e.g. <c>C3</c>, <c>G#4</c>, <c>F-1</c>, <c>Db7</c>) or an array of the
        /// previous types. When using a note identifier, octave range must be between <c>-1</c> and <c>9</c>. The
        /// lowest note is <c>C-1</c> (MIDI note number <c>0</c>) and the highest note is <c>G9</c> (MIDI note number
        /// <c>127</c>).
        /// </param>
        /// <param name="pressure">
        /// The pressure level (between 0 and 1). An invalid pressure value
        /// will silently trigger the default behaviour. If the <c>rawValue</c> option is set to <c>true</c>, the
        /// pressure can be defined by using an integer between 0 and 127.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendKeyAftertouch: note: float * ?pressure: float * ?options: Output.sendKeyAftertouch.options -> Webmidi.Output
        /// <summary>
        /// Sends a MIDI **key aftertouch** message to the specified channel(s) at the scheduled time. This
        /// is a key-specific aftertouch. For a channel-wide aftertouch message, use
        /// [<c>setChannelAftertouch()</c>]<see href="#setChannelAftertouch">#setChannelAftertouch</see>.
        /// </summary>
        /// <param name="note">
        /// The note(s) for which you are sending
        /// an aftertouch value. The notes can be specified by using a MIDI note number (<c>0</c> - <c>127</c>), a
        /// [<c>Note</c>](Note) object, a note identifier (e.g. <c>C3</c>, <c>G#4</c>, <c>F-1</c>, <c>Db7</c>) or an array of the
        /// previous types. When using a note identifier, octave range must be between <c>-1</c> and <c>9</c>. The
        /// lowest note is <c>C-1</c> (MIDI note number <c>0</c>) and the highest note is <c>G9</c> (MIDI note number
        /// <c>127</c>).
        /// </param>
        /// <param name="pressure">
        /// The pressure level (between 0 and 1). An invalid pressure value
        /// will silently trigger the default behaviour. If the <c>rawValue</c> option is set to <c>true</c>, the
        /// pressure can be defined by using an integer between 0 and 127.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendKeyAftertouch: note: Webmidi.Note * ?pressure: float * ?options: Output.sendKeyAftertouch.options -> Webmidi.Output
        /// <summary>
        /// Sends a MIDI **key aftertouch** message to the specified channel(s) at the scheduled time. This
        /// is a key-specific aftertouch. For a channel-wide aftertouch message, use
        /// [<c>setChannelAftertouch()</c>]<see href="#setChannelAftertouch">#setChannelAftertouch</see>.
        /// </summary>
        /// <param name="note">
        /// The note(s) for which you are sending
        /// an aftertouch value. The notes can be specified by using a MIDI note number (<c>0</c> - <c>127</c>), a
        /// [<c>Note</c>](Note) object, a note identifier (e.g. <c>C3</c>, <c>G#4</c>, <c>F-1</c>, <c>Db7</c>) or an array of the
        /// previous types. When using a note identifier, octave range must be between <c>-1</c> and <c>9</c>. The
        /// lowest note is <c>C-1</c> (MIDI note number <c>0</c>) and the highest note is <c>G9</c> (MIDI note number
        /// <c>127</c>).
        /// </param>
        /// <param name="pressure">
        /// The pressure level (between 0 and 1). An invalid pressure value
        /// will silently trigger the default behaviour. If the <c>rawValue</c> option is set to <c>true</c>, the
        /// pressure can be defined by using an integer between 0 and 127.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendKeyAftertouch: note: string * ?pressure: float * ?options: Output.sendKeyAftertouch.options -> Webmidi.Output
        /// <summary>
        /// Sends a MIDI **key aftertouch** message to the specified channel(s) at the scheduled time. This
        /// is a key-specific aftertouch. For a channel-wide aftertouch message, use
        /// [<c>setChannelAftertouch()</c>]<see href="#setChannelAftertouch">#setChannelAftertouch</see>.
        /// </summary>
        /// <param name="note">
        /// The note(s) for which you are sending
        /// an aftertouch value. The notes can be specified by using a MIDI note number (<c>0</c> - <c>127</c>), a
        /// [<c>Note</c>](Note) object, a note identifier (e.g. <c>C3</c>, <c>G#4</c>, <c>F-1</c>, <c>Db7</c>) or an array of the
        /// previous types. When using a note identifier, octave range must be between <c>-1</c> and <c>9</c>. The
        /// lowest note is <c>C-1</c> (MIDI note number <c>0</c>) and the highest note is <c>G9</c> (MIDI note number
        /// <c>127</c>).
        /// </param>
        /// <param name="pressure">
        /// The pressure level (between 0 and 1). An invalid pressure value
        /// will silently trigger the default behaviour. If the <c>rawValue</c> option is set to <c>true</c>, the
        /// pressure can be defined by using an integer between 0 and 127.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendKeyAftertouch: note: ResizeArray<float> * ?pressure: float * ?options: Output.sendKeyAftertouch.options -> Webmidi.Output
        /// <summary>
        /// Sends a MIDI **key aftertouch** message to the specified channel(s) at the scheduled time. This
        /// is a key-specific aftertouch. For a channel-wide aftertouch message, use
        /// [<c>setChannelAftertouch()</c>]<see href="#setChannelAftertouch">#setChannelAftertouch</see>.
        /// </summary>
        /// <param name="note">
        /// The note(s) for which you are sending
        /// an aftertouch value. The notes can be specified by using a MIDI note number (<c>0</c> - <c>127</c>), a
        /// [<c>Note</c>](Note) object, a note identifier (e.g. <c>C3</c>, <c>G#4</c>, <c>F-1</c>, <c>Db7</c>) or an array of the
        /// previous types. When using a note identifier, octave range must be between <c>-1</c> and <c>9</c>. The
        /// lowest note is <c>C-1</c> (MIDI note number <c>0</c>) and the highest note is <c>G9</c> (MIDI note number
        /// <c>127</c>).
        /// </param>
        /// <param name="pressure">
        /// The pressure level (between 0 and 1). An invalid pressure value
        /// will silently trigger the default behaviour. If the <c>rawValue</c> option is set to <c>true</c>, the
        /// pressure can be defined by using an integer between 0 and 127.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendKeyAftertouch: note: ResizeArray<Webmidi.Note> * ?pressure: float * ?options: Output.sendKeyAftertouch.options -> Webmidi.Output
        /// <summary>
        /// Sends a MIDI **key aftertouch** message to the specified channel(s) at the scheduled time. This
        /// is a key-specific aftertouch. For a channel-wide aftertouch message, use
        /// [<c>setChannelAftertouch()</c>]<see href="#setChannelAftertouch">#setChannelAftertouch</see>.
        /// </summary>
        /// <param name="note">
        /// The note(s) for which you are sending
        /// an aftertouch value. The notes can be specified by using a MIDI note number (<c>0</c> - <c>127</c>), a
        /// [<c>Note</c>](Note) object, a note identifier (e.g. <c>C3</c>, <c>G#4</c>, <c>F-1</c>, <c>Db7</c>) or an array of the
        /// previous types. When using a note identifier, octave range must be between <c>-1</c> and <c>9</c>. The
        /// lowest note is <c>C-1</c> (MIDI note number <c>0</c>) and the highest note is <c>G9</c> (MIDI note number
        /// <c>127</c>).
        /// </param>
        /// <param name="pressure">
        /// The pressure level (between 0 and 1). An invalid pressure value
        /// will silently trigger the default behaviour. If the <c>rawValue</c> option is set to <c>true</c>, the
        /// pressure can be defined by using an integer between 0 and 127.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendKeyAftertouch: note: ResizeArray<string> * ?pressure: float * ?options: Output.sendKeyAftertouch.options -> Webmidi.Output
        /// <summary>
        /// Sends a MIDI **key aftertouch** message to the specified channel(s) at the scheduled time. This
        /// is a key-specific aftertouch. For a channel-wide aftertouch message, use
        /// [<c>setChannelAftertouch()</c>]<see href="#setChannelAftertouch">#setChannelAftertouch</see>.
        /// </summary>
        /// <param name="note">
        /// The note(s) for which you are sending
        /// an aftertouch value. The notes can be specified by using a MIDI note number (<c>0</c> - <c>127</c>), a
        /// [<c>Note</c>](Note) object, a note identifier (e.g. <c>C3</c>, <c>G#4</c>, <c>F-1</c>, <c>Db7</c>) or an array of the
        /// previous types. When using a note identifier, octave range must be between <c>-1</c> and <c>9</c>. The
        /// lowest note is <c>C-1</c> (MIDI note number <c>0</c>) and the highest note is <c>G9</c> (MIDI note number
        /// <c>127</c>).
        /// </param>
        /// <param name="pressure">
        /// The pressure level (between 0 and 1). An invalid pressure value
        /// will silently trigger the default behaviour. If the <c>rawValue</c> option is set to <c>true</c>, the
        /// pressure can be defined by using an integer between 0 and 127.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendKeyAftertouch: note: U6<float, Webmidi.Note, string, ResizeArray<float>, ResizeArray<Webmidi.Note>, ResizeArray<string>> * ?pressure: float * ?options: Output.sendKeyAftertouch.options -> Webmidi.Output
        /// <summary>
        /// Sends a MIDI **control change** message to the specified channel(s) at the scheduled time. The
        /// control change message to send can be specified numerically (0-127) or by using one of the
        /// following common names:
        ///
        /// | Number | Name                          |
        /// |--------|-------------------------------|
        /// | 0      |<c>bankselectcoarse</c>             |
        /// | 1      |<c>modulationwheelcoarse</c>        |
        /// | 2      |<c>breathcontrollercoarse</c>       |
        /// | 4      |<c>footcontrollercoarse</c>         |
        /// | 5      |<c>portamentotimecoarse</c>         |
        /// | 6      |<c>dataentrycoarse</c>              |
        /// | 7      |<c>volumecoarse</c>                 |
        /// | 8      |<c>balancecoarse</c>                |
        /// | 10     |<c>pancoarse</c>                    |
        /// | 11     |<c>expressioncoarse</c>             |
        /// | 12     |<c>effectcontrol1coarse</c>         |
        /// | 13     |<c>effectcontrol2coarse</c>         |
        /// | 18     |<c>generalpurposeslider3</c>        |
        /// | 19     |<c>generalpurposeslider4</c>        |
        /// | 32     |<c>bankselectfine</c>               |
        /// | 33     |<c>modulationwheelfine</c>          |
        /// | 34     |<c>breathcontrollerfine</c>         |
        /// | 36     |<c>footcontrollerfine</c>           |
        /// | 37     |<c>portamentotimefine</c>           |
        /// | 38     |<c>dataentryfine</c>                |
        /// | 39     |<c>volumefine</c>                   |
        /// | 40     |<c>balancefine</c>                  |
        /// | 42     |<c>panfine</c>                      |
        /// | 43     |<c>expressionfine</c>               |
        /// | 44     |<c>effectcontrol1fine</c>           |
        /// | 45     |<c>effectcontrol2fine</c>           |
        /// | 64     |<c>holdpedal</c>                    |
        /// | 65     |<c>portamento</c>                   |
        /// | 66     |<c>sustenutopedal</c>               |
        /// | 67     |<c>softpedal</c>                    |
        /// | 68     |<c>legatopedal</c>                  |
        /// | 69     |<c>hold2pedal</c>                   |
        /// | 70     |<c>soundvariation</c>               |
        /// | 71     |<c>resonance</c>                    |
        /// | 72     |<c>soundreleasetime</c>             |
        /// | 73     |<c>soundattacktime</c>              |
        /// | 74     |<c>brightness</c>                   |
        /// | 75     |<c>soundcontrol6</c>                |
        /// | 76     |<c>soundcontrol7</c>                |
        /// | 77     |<c>soundcontrol8</c>                |
        /// | 78     |<c>soundcontrol9</c>                |
        /// | 79     |<c>soundcontrol10</c>               |
        /// | 80     |<c>generalpurposebutton1</c>        |
        /// | 81     |<c>generalpurposebutton2</c>        |
        /// | 82     |<c>generalpurposebutton3</c>        |
        /// | 83     |<c>generalpurposebutton4</c>        |
        /// | 91     |<c>reverblevel</c>                  |
        /// | 92     |<c>tremololevel</c>                 |
        /// | 93     |<c>choruslevel</c>                  |
        /// | 94     |<c>celestelevel</c>                 |
        /// | 95     |<c>phaserlevel</c>                  |
        /// | 96     |<c>dataincrement</c>          |
        /// | 97     |<c>datadecrement</c>          |
        /// | 98     |<c>nonregisteredparametercoarse</c> |
        /// | 99     |<c>nonregisteredparameterfine</c>   |
        /// | 100    |<c>registeredparametercoarse</c>    |
        /// | 101    |<c>registeredparameterfine</c>      |
        /// | 120    |<c>allsoundoff</c>                  |
        /// | 121    |<c>resetallcontrollers</c>          |
        /// | 122    |<c>localcontrol</c>                 |
        /// | 123    |<c>allnotesoff</c>                  |
        /// | 124    |<c>omnimodeoff</c>                  |
        /// | 125    |<c>omnimodeon</c>                   |
        /// | 126    |<c>monomodeon</c>                   |
        /// | 127    |<c>polymodeon</c>                   |
        ///
        /// Note: as you can see above, not all control change message have a matching name. This does not
        /// mean you cannot use the others. It simply means you will need to use their number (<c>0</c> - <c>127</c>)
        /// instead of their name. While you can still use them, numbers <c>120</c> to <c>127</c> are usually
        /// reserved for *channel mode* messages. See [<c>sendChannelMode()</c>]<see href="#sendChannelMode">#sendChannelMode</see> method
        /// for more info.
        ///
        /// To view a list of all available **control change** messages, please consult [Table 3 - Control
        /// Change Messages](https://www.midi.org/specifications-old/item/table-3-control-change-messages-data-bytes-2)
        /// from the MIDI specification.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// Controller numbers must be between 0 and 127.
        ///
        /// Invalid controller name.
        /// </remarks>
        /// <param name="controller">
        /// The MIDI controller name or number (0-127).
        /// </param>
        /// <param name="value">
        /// The value to send (0-127).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendControlChange: controller: float * ?value: float * ?options: Output.sendControlChange.options -> Webmidi.Output
        /// <summary>
        /// Sends a MIDI **control change** message to the specified channel(s) at the scheduled time. The
        /// control change message to send can be specified numerically (0-127) or by using one of the
        /// following common names:
        ///
        /// | Number | Name                          |
        /// |--------|-------------------------------|
        /// | 0      |<c>bankselectcoarse</c>             |
        /// | 1      |<c>modulationwheelcoarse</c>        |
        /// | 2      |<c>breathcontrollercoarse</c>       |
        /// | 4      |<c>footcontrollercoarse</c>         |
        /// | 5      |<c>portamentotimecoarse</c>         |
        /// | 6      |<c>dataentrycoarse</c>              |
        /// | 7      |<c>volumecoarse</c>                 |
        /// | 8      |<c>balancecoarse</c>                |
        /// | 10     |<c>pancoarse</c>                    |
        /// | 11     |<c>expressioncoarse</c>             |
        /// | 12     |<c>effectcontrol1coarse</c>         |
        /// | 13     |<c>effectcontrol2coarse</c>         |
        /// | 18     |<c>generalpurposeslider3</c>        |
        /// | 19     |<c>generalpurposeslider4</c>        |
        /// | 32     |<c>bankselectfine</c>               |
        /// | 33     |<c>modulationwheelfine</c>          |
        /// | 34     |<c>breathcontrollerfine</c>         |
        /// | 36     |<c>footcontrollerfine</c>           |
        /// | 37     |<c>portamentotimefine</c>           |
        /// | 38     |<c>dataentryfine</c>                |
        /// | 39     |<c>volumefine</c>                   |
        /// | 40     |<c>balancefine</c>                  |
        /// | 42     |<c>panfine</c>                      |
        /// | 43     |<c>expressionfine</c>               |
        /// | 44     |<c>effectcontrol1fine</c>           |
        /// | 45     |<c>effectcontrol2fine</c>           |
        /// | 64     |<c>holdpedal</c>                    |
        /// | 65     |<c>portamento</c>                   |
        /// | 66     |<c>sustenutopedal</c>               |
        /// | 67     |<c>softpedal</c>                    |
        /// | 68     |<c>legatopedal</c>                  |
        /// | 69     |<c>hold2pedal</c>                   |
        /// | 70     |<c>soundvariation</c>               |
        /// | 71     |<c>resonance</c>                    |
        /// | 72     |<c>soundreleasetime</c>             |
        /// | 73     |<c>soundattacktime</c>              |
        /// | 74     |<c>brightness</c>                   |
        /// | 75     |<c>soundcontrol6</c>                |
        /// | 76     |<c>soundcontrol7</c>                |
        /// | 77     |<c>soundcontrol8</c>                |
        /// | 78     |<c>soundcontrol9</c>                |
        /// | 79     |<c>soundcontrol10</c>               |
        /// | 80     |<c>generalpurposebutton1</c>        |
        /// | 81     |<c>generalpurposebutton2</c>        |
        /// | 82     |<c>generalpurposebutton3</c>        |
        /// | 83     |<c>generalpurposebutton4</c>        |
        /// | 91     |<c>reverblevel</c>                  |
        /// | 92     |<c>tremololevel</c>                 |
        /// | 93     |<c>choruslevel</c>                  |
        /// | 94     |<c>celestelevel</c>                 |
        /// | 95     |<c>phaserlevel</c>                  |
        /// | 96     |<c>dataincrement</c>          |
        /// | 97     |<c>datadecrement</c>          |
        /// | 98     |<c>nonregisteredparametercoarse</c> |
        /// | 99     |<c>nonregisteredparameterfine</c>   |
        /// | 100    |<c>registeredparametercoarse</c>    |
        /// | 101    |<c>registeredparameterfine</c>      |
        /// | 120    |<c>allsoundoff</c>                  |
        /// | 121    |<c>resetallcontrollers</c>          |
        /// | 122    |<c>localcontrol</c>                 |
        /// | 123    |<c>allnotesoff</c>                  |
        /// | 124    |<c>omnimodeoff</c>                  |
        /// | 125    |<c>omnimodeon</c>                   |
        /// | 126    |<c>monomodeon</c>                   |
        /// | 127    |<c>polymodeon</c>                   |
        ///
        /// Note: as you can see above, not all control change message have a matching name. This does not
        /// mean you cannot use the others. It simply means you will need to use their number (<c>0</c> - <c>127</c>)
        /// instead of their name. While you can still use them, numbers <c>120</c> to <c>127</c> are usually
        /// reserved for *channel mode* messages. See [<c>sendChannelMode()</c>]<see href="#sendChannelMode">#sendChannelMode</see> method
        /// for more info.
        ///
        /// To view a list of all available **control change** messages, please consult [Table 3 - Control
        /// Change Messages](https://www.midi.org/specifications-old/item/table-3-control-change-messages-data-bytes-2)
        /// from the MIDI specification.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// Controller numbers must be between 0 and 127.
        ///
        /// Invalid controller name.
        /// </remarks>
        /// <param name="controller">
        /// The MIDI controller name or number (0-127).
        /// </param>
        /// <param name="value">
        /// The value to send (0-127).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendControlChange: controller: string * ?value: float * ?options: Output.sendControlChange.options -> Webmidi.Output
        /// <summary>
        /// Sends a MIDI **control change** message to the specified channel(s) at the scheduled time. The
        /// control change message to send can be specified numerically (0-127) or by using one of the
        /// following common names:
        ///
        /// | Number | Name                          |
        /// |--------|-------------------------------|
        /// | 0      |<c>bankselectcoarse</c>             |
        /// | 1      |<c>modulationwheelcoarse</c>        |
        /// | 2      |<c>breathcontrollercoarse</c>       |
        /// | 4      |<c>footcontrollercoarse</c>         |
        /// | 5      |<c>portamentotimecoarse</c>         |
        /// | 6      |<c>dataentrycoarse</c>              |
        /// | 7      |<c>volumecoarse</c>                 |
        /// | 8      |<c>balancecoarse</c>                |
        /// | 10     |<c>pancoarse</c>                    |
        /// | 11     |<c>expressioncoarse</c>             |
        /// | 12     |<c>effectcontrol1coarse</c>         |
        /// | 13     |<c>effectcontrol2coarse</c>         |
        /// | 18     |<c>generalpurposeslider3</c>        |
        /// | 19     |<c>generalpurposeslider4</c>        |
        /// | 32     |<c>bankselectfine</c>               |
        /// | 33     |<c>modulationwheelfine</c>          |
        /// | 34     |<c>breathcontrollerfine</c>         |
        /// | 36     |<c>footcontrollerfine</c>           |
        /// | 37     |<c>portamentotimefine</c>           |
        /// | 38     |<c>dataentryfine</c>                |
        /// | 39     |<c>volumefine</c>                   |
        /// | 40     |<c>balancefine</c>                  |
        /// | 42     |<c>panfine</c>                      |
        /// | 43     |<c>expressionfine</c>               |
        /// | 44     |<c>effectcontrol1fine</c>           |
        /// | 45     |<c>effectcontrol2fine</c>           |
        /// | 64     |<c>holdpedal</c>                    |
        /// | 65     |<c>portamento</c>                   |
        /// | 66     |<c>sustenutopedal</c>               |
        /// | 67     |<c>softpedal</c>                    |
        /// | 68     |<c>legatopedal</c>                  |
        /// | 69     |<c>hold2pedal</c>                   |
        /// | 70     |<c>soundvariation</c>               |
        /// | 71     |<c>resonance</c>                    |
        /// | 72     |<c>soundreleasetime</c>             |
        /// | 73     |<c>soundattacktime</c>              |
        /// | 74     |<c>brightness</c>                   |
        /// | 75     |<c>soundcontrol6</c>                |
        /// | 76     |<c>soundcontrol7</c>                |
        /// | 77     |<c>soundcontrol8</c>                |
        /// | 78     |<c>soundcontrol9</c>                |
        /// | 79     |<c>soundcontrol10</c>               |
        /// | 80     |<c>generalpurposebutton1</c>        |
        /// | 81     |<c>generalpurposebutton2</c>        |
        /// | 82     |<c>generalpurposebutton3</c>        |
        /// | 83     |<c>generalpurposebutton4</c>        |
        /// | 91     |<c>reverblevel</c>                  |
        /// | 92     |<c>tremololevel</c>                 |
        /// | 93     |<c>choruslevel</c>                  |
        /// | 94     |<c>celestelevel</c>                 |
        /// | 95     |<c>phaserlevel</c>                  |
        /// | 96     |<c>dataincrement</c>          |
        /// | 97     |<c>datadecrement</c>          |
        /// | 98     |<c>nonregisteredparametercoarse</c> |
        /// | 99     |<c>nonregisteredparameterfine</c>   |
        /// | 100    |<c>registeredparametercoarse</c>    |
        /// | 101    |<c>registeredparameterfine</c>      |
        /// | 120    |<c>allsoundoff</c>                  |
        /// | 121    |<c>resetallcontrollers</c>          |
        /// | 122    |<c>localcontrol</c>                 |
        /// | 123    |<c>allnotesoff</c>                  |
        /// | 124    |<c>omnimodeoff</c>                  |
        /// | 125    |<c>omnimodeon</c>                   |
        /// | 126    |<c>monomodeon</c>                   |
        /// | 127    |<c>polymodeon</c>                   |
        ///
        /// Note: as you can see above, not all control change message have a matching name. This does not
        /// mean you cannot use the others. It simply means you will need to use their number (<c>0</c> - <c>127</c>)
        /// instead of their name. While you can still use them, numbers <c>120</c> to <c>127</c> are usually
        /// reserved for *channel mode* messages. See [<c>sendChannelMode()</c>]<see href="#sendChannelMode">#sendChannelMode</see> method
        /// for more info.
        ///
        /// To view a list of all available **control change** messages, please consult [Table 3 - Control
        /// Change Messages](https://www.midi.org/specifications-old/item/table-3-control-change-messages-data-bytes-2)
        /// from the MIDI specification.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// Controller numbers must be between 0 and 127.
        ///
        /// Invalid controller name.
        /// </remarks>
        /// <param name="controller">
        /// The MIDI controller name or number (0-127).
        /// </param>
        /// <param name="value">
        /// The value to send (0-127).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendControlChange: controller: U2<float, string> * ?value: float * ?options: Output.sendControlChange.options -> Webmidi.Output
        /// <summary>
        /// Sends a **pitch bend range** message to the specified channel(s) at the scheduled time so that
        /// they adjust the range used by their pitch bend lever. The range is specified by using the
        /// <c>semitones</c> and <c>cents</c> parameters. For example, setting the <c>semitones</c> parameter to <c>12</c>
        /// means that the pitch bend range will be 12 semitones above and below the nominal pitch.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// The msb value must be between 0 and 127.
        ///
        /// The lsb value must be between 0 and 127.
        /// </remarks>
        /// <param name="semitones">
        /// The desired adjustment value in semitones (between <c>0</c> and <c>127</c>).
        /// While nothing imposes that in the specification, it is very common for manufacturers to limit
        /// the range to 2 octaves (-12 semitones to 12 semitones).
        /// </param>
        /// <param name="cents">
        /// The desired adjustment value in cents (integer between <c>0</c> and
        /// <c>127</c>).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendPitchBendRange: ?semitones: float * ?cents: float * ?options: Output.sendPitchBendRange.options -> Webmidi.Output
        /// <summary>
        /// Sets the specified MIDI registered parameter to the desired value. The value is defined with
        /// up to two bytes of data (msb, lsb) that each can go from <c>0</c> to <c>127</c>.
        ///
        /// MIDI
        /// [registered parameters](https://www.midi.org/specifications-old/item/table-3-control-change-messages-data-bytes-2)
        /// extend the original list of control change messages. The MIDI 1.0 specification lists only a
        /// limited number of them:
        ///
        /// | Numbers      | Function                 |
        /// |--------------|--------------------------|
        /// | (0x00, 0x00) | <c>pitchbendrange</c>         |
        /// | (0x00, 0x01) | <c>channelfinetuning</c>      |
        /// | (0x00, 0x02) | <c>channelcoarsetuning</c>    |
        /// | (0x00, 0x03) | <c>tuningprogram</c>          |
        /// | (0x00, 0x04) | <c>tuningbank</c>             |
        /// | (0x00, 0x05) | <c>modulationrange</c>        |
        /// | (0x3D, 0x00) | <c>azimuthangle</c>           |
        /// | (0x3D, 0x01) | <c>elevationangle</c>         |
        /// | (0x3D, 0x02) | <c>gain</c>                   |
        /// | (0x3D, 0x03) | <c>distanceratio</c>          |
        /// | (0x3D, 0x04) | <c>maximumdistance</c>        |
        /// | (0x3D, 0x05) | <c>maximumdistancegain</c>    |
        /// | (0x3D, 0x06) | <c>referencedistanceratio</c> |
        /// | (0x3D, 0x07) | <c>panspreadangle</c>         |
        /// | (0x3D, 0x08) | <c>rollangle</c>              |
        ///
        /// Note that the <c>tuningprogram</c> and <c>tuningbank</c> parameters are part of the *MIDI Tuning
        /// Standard*, which is not widely implemented.
        /// </summary>
        /// <param name="parameter">
        /// A string identifying the parameter's name (see above) or a
        /// two-position array specifying the two control bytes (e.g. <c>[0x65, 0x64]</c>) that identify the
        /// registered parameter.
        /// </param>
        /// <param name="data">
        /// A single integer or an array of integers with a maximum
        /// length of 2 specifying the desired data.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendRpnValue: parameter: string -> Webmidi.Output
        /// <summary>
        /// Sets the specified MIDI registered parameter to the desired value. The value is defined with
        /// up to two bytes of data (msb, lsb) that each can go from <c>0</c> to <c>127</c>.
        ///
        /// MIDI
        /// [registered parameters](https://www.midi.org/specifications-old/item/table-3-control-change-messages-data-bytes-2)
        /// extend the original list of control change messages. The MIDI 1.0 specification lists only a
        /// limited number of them:
        ///
        /// | Numbers      | Function                 |
        /// |--------------|--------------------------|
        /// | (0x00, 0x00) | <c>pitchbendrange</c>         |
        /// | (0x00, 0x01) | <c>channelfinetuning</c>      |
        /// | (0x00, 0x02) | <c>channelcoarsetuning</c>    |
        /// | (0x00, 0x03) | <c>tuningprogram</c>          |
        /// | (0x00, 0x04) | <c>tuningbank</c>             |
        /// | (0x00, 0x05) | <c>modulationrange</c>        |
        /// | (0x3D, 0x00) | <c>azimuthangle</c>           |
        /// | (0x3D, 0x01) | <c>elevationangle</c>         |
        /// | (0x3D, 0x02) | <c>gain</c>                   |
        /// | (0x3D, 0x03) | <c>distanceratio</c>          |
        /// | (0x3D, 0x04) | <c>maximumdistance</c>        |
        /// | (0x3D, 0x05) | <c>maximumdistancegain</c>    |
        /// | (0x3D, 0x06) | <c>referencedistanceratio</c> |
        /// | (0x3D, 0x07) | <c>panspreadangle</c>         |
        /// | (0x3D, 0x08) | <c>rollangle</c>              |
        ///
        /// Note that the <c>tuningprogram</c> and <c>tuningbank</c> parameters are part of the *MIDI Tuning
        /// Standard*, which is not widely implemented.
        /// </summary>
        /// <param name="parameter">
        /// A string identifying the parameter's name (see above) or a
        /// two-position array specifying the two control bytes (e.g. <c>[0x65, 0x64]</c>) that identify the
        /// registered parameter.
        /// </param>
        /// <param name="data">
        /// A single integer or an array of integers with a maximum
        /// length of 2 specifying the desired data.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendRpnValue: parameter: string * data: float * ?options: Output.sendRpnValue.options -> Webmidi.Output
        /// <summary>
        /// Sets the specified MIDI registered parameter to the desired value. The value is defined with
        /// up to two bytes of data (msb, lsb) that each can go from <c>0</c> to <c>127</c>.
        ///
        /// MIDI
        /// [registered parameters](https://www.midi.org/specifications-old/item/table-3-control-change-messages-data-bytes-2)
        /// extend the original list of control change messages. The MIDI 1.0 specification lists only a
        /// limited number of them:
        ///
        /// | Numbers      | Function                 |
        /// |--------------|--------------------------|
        /// | (0x00, 0x00) | <c>pitchbendrange</c>         |
        /// | (0x00, 0x01) | <c>channelfinetuning</c>      |
        /// | (0x00, 0x02) | <c>channelcoarsetuning</c>    |
        /// | (0x00, 0x03) | <c>tuningprogram</c>          |
        /// | (0x00, 0x04) | <c>tuningbank</c>             |
        /// | (0x00, 0x05) | <c>modulationrange</c>        |
        /// | (0x3D, 0x00) | <c>azimuthangle</c>           |
        /// | (0x3D, 0x01) | <c>elevationangle</c>         |
        /// | (0x3D, 0x02) | <c>gain</c>                   |
        /// | (0x3D, 0x03) | <c>distanceratio</c>          |
        /// | (0x3D, 0x04) | <c>maximumdistance</c>        |
        /// | (0x3D, 0x05) | <c>maximumdistancegain</c>    |
        /// | (0x3D, 0x06) | <c>referencedistanceratio</c> |
        /// | (0x3D, 0x07) | <c>panspreadangle</c>         |
        /// | (0x3D, 0x08) | <c>rollangle</c>              |
        ///
        /// Note that the <c>tuningprogram</c> and <c>tuningbank</c> parameters are part of the *MIDI Tuning
        /// Standard*, which is not widely implemented.
        /// </summary>
        /// <param name="parameter">
        /// A string identifying the parameter's name (see above) or a
        /// two-position array specifying the two control bytes (e.g. <c>[0x65, 0x64]</c>) that identify the
        /// registered parameter.
        /// </param>
        /// <param name="data">
        /// A single integer or an array of integers with a maximum
        /// length of 2 specifying the desired data.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendRpnValue: parameter: string * data: ResizeArray<float> * ?options: Output.sendRpnValue.options -> Webmidi.Output
        /// <summary>
        /// Sets the specified MIDI registered parameter to the desired value. The value is defined with
        /// up to two bytes of data (msb, lsb) that each can go from <c>0</c> to <c>127</c>.
        ///
        /// MIDI
        /// [registered parameters](https://www.midi.org/specifications-old/item/table-3-control-change-messages-data-bytes-2)
        /// extend the original list of control change messages. The MIDI 1.0 specification lists only a
        /// limited number of them:
        ///
        /// | Numbers      | Function                 |
        /// |--------------|--------------------------|
        /// | (0x00, 0x00) | <c>pitchbendrange</c>         |
        /// | (0x00, 0x01) | <c>channelfinetuning</c>      |
        /// | (0x00, 0x02) | <c>channelcoarsetuning</c>    |
        /// | (0x00, 0x03) | <c>tuningprogram</c>          |
        /// | (0x00, 0x04) | <c>tuningbank</c>             |
        /// | (0x00, 0x05) | <c>modulationrange</c>        |
        /// | (0x3D, 0x00) | <c>azimuthangle</c>           |
        /// | (0x3D, 0x01) | <c>elevationangle</c>         |
        /// | (0x3D, 0x02) | <c>gain</c>                   |
        /// | (0x3D, 0x03) | <c>distanceratio</c>          |
        /// | (0x3D, 0x04) | <c>maximumdistance</c>        |
        /// | (0x3D, 0x05) | <c>maximumdistancegain</c>    |
        /// | (0x3D, 0x06) | <c>referencedistanceratio</c> |
        /// | (0x3D, 0x07) | <c>panspreadangle</c>         |
        /// | (0x3D, 0x08) | <c>rollangle</c>              |
        ///
        /// Note that the <c>tuningprogram</c> and <c>tuningbank</c> parameters are part of the *MIDI Tuning
        /// Standard*, which is not widely implemented.
        /// </summary>
        /// <param name="parameter">
        /// A string identifying the parameter's name (see above) or a
        /// two-position array specifying the two control bytes (e.g. <c>[0x65, 0x64]</c>) that identify the
        /// registered parameter.
        /// </param>
        /// <param name="data">
        /// A single integer or an array of integers with a maximum
        /// length of 2 specifying the desired data.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendRpnValue: parameter: ResizeArray<float> -> Webmidi.Output
        /// <summary>
        /// Sets the specified MIDI registered parameter to the desired value. The value is defined with
        /// up to two bytes of data (msb, lsb) that each can go from <c>0</c> to <c>127</c>.
        ///
        /// MIDI
        /// [registered parameters](https://www.midi.org/specifications-old/item/table-3-control-change-messages-data-bytes-2)
        /// extend the original list of control change messages. The MIDI 1.0 specification lists only a
        /// limited number of them:
        ///
        /// | Numbers      | Function                 |
        /// |--------------|--------------------------|
        /// | (0x00, 0x00) | <c>pitchbendrange</c>         |
        /// | (0x00, 0x01) | <c>channelfinetuning</c>      |
        /// | (0x00, 0x02) | <c>channelcoarsetuning</c>    |
        /// | (0x00, 0x03) | <c>tuningprogram</c>          |
        /// | (0x00, 0x04) | <c>tuningbank</c>             |
        /// | (0x00, 0x05) | <c>modulationrange</c>        |
        /// | (0x3D, 0x00) | <c>azimuthangle</c>           |
        /// | (0x3D, 0x01) | <c>elevationangle</c>         |
        /// | (0x3D, 0x02) | <c>gain</c>                   |
        /// | (0x3D, 0x03) | <c>distanceratio</c>          |
        /// | (0x3D, 0x04) | <c>maximumdistance</c>        |
        /// | (0x3D, 0x05) | <c>maximumdistancegain</c>    |
        /// | (0x3D, 0x06) | <c>referencedistanceratio</c> |
        /// | (0x3D, 0x07) | <c>panspreadangle</c>         |
        /// | (0x3D, 0x08) | <c>rollangle</c>              |
        ///
        /// Note that the <c>tuningprogram</c> and <c>tuningbank</c> parameters are part of the *MIDI Tuning
        /// Standard*, which is not widely implemented.
        /// </summary>
        /// <param name="parameter">
        /// A string identifying the parameter's name (see above) or a
        /// two-position array specifying the two control bytes (e.g. <c>[0x65, 0x64]</c>) that identify the
        /// registered parameter.
        /// </param>
        /// <param name="data">
        /// A single integer or an array of integers with a maximum
        /// length of 2 specifying the desired data.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendRpnValue: parameter: ResizeArray<float> * data: float * ?options: Output.sendRpnValue.options -> Webmidi.Output
        /// <summary>
        /// Sets the specified MIDI registered parameter to the desired value. The value is defined with
        /// up to two bytes of data (msb, lsb) that each can go from <c>0</c> to <c>127</c>.
        ///
        /// MIDI
        /// [registered parameters](https://www.midi.org/specifications-old/item/table-3-control-change-messages-data-bytes-2)
        /// extend the original list of control change messages. The MIDI 1.0 specification lists only a
        /// limited number of them:
        ///
        /// | Numbers      | Function                 |
        /// |--------------|--------------------------|
        /// | (0x00, 0x00) | <c>pitchbendrange</c>         |
        /// | (0x00, 0x01) | <c>channelfinetuning</c>      |
        /// | (0x00, 0x02) | <c>channelcoarsetuning</c>    |
        /// | (0x00, 0x03) | <c>tuningprogram</c>          |
        /// | (0x00, 0x04) | <c>tuningbank</c>             |
        /// | (0x00, 0x05) | <c>modulationrange</c>        |
        /// | (0x3D, 0x00) | <c>azimuthangle</c>           |
        /// | (0x3D, 0x01) | <c>elevationangle</c>         |
        /// | (0x3D, 0x02) | <c>gain</c>                   |
        /// | (0x3D, 0x03) | <c>distanceratio</c>          |
        /// | (0x3D, 0x04) | <c>maximumdistance</c>        |
        /// | (0x3D, 0x05) | <c>maximumdistancegain</c>    |
        /// | (0x3D, 0x06) | <c>referencedistanceratio</c> |
        /// | (0x3D, 0x07) | <c>panspreadangle</c>         |
        /// | (0x3D, 0x08) | <c>rollangle</c>              |
        ///
        /// Note that the <c>tuningprogram</c> and <c>tuningbank</c> parameters are part of the *MIDI Tuning
        /// Standard*, which is not widely implemented.
        /// </summary>
        /// <param name="parameter">
        /// A string identifying the parameter's name (see above) or a
        /// two-position array specifying the two control bytes (e.g. <c>[0x65, 0x64]</c>) that identify the
        /// registered parameter.
        /// </param>
        /// <param name="data">
        /// A single integer or an array of integers with a maximum
        /// length of 2 specifying the desired data.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendRpnValue: parameter: ResizeArray<float> * data: ResizeArray<float> * ?options: Output.sendRpnValue.options -> Webmidi.Output
        /// <summary>
        /// Sends a MIDI **channel aftertouch** message to the specified channel(s). For key-specific
        /// aftertouch, you should instead use [<c>setKeyAftertouch()</c>]<see href="#setKeyAftertouch">#setKeyAftertouch</see>.
        /// </summary>
        /// <param name="pressure">
        /// The pressure level (between <c>0</c> and <c>1</c>). An invalid pressure
        /// value will silently trigger the default behaviour. If the <c>rawValue</c> option is set to <c>true</c>,
        /// the pressure can be defined by using an integer between <c>0</c> and <c>127</c>.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendChannelAftertouch: ?pressure: float * ?options: Output.sendChannelAftertouch.options -> Webmidi.Output
        /// <summary>
        /// Sends a MIDI **pitch bend** message to the specified channel(s) at the scheduled time.
        ///
        /// The resulting bend is relative to the pitch bend range that has been defined. The range can be
        /// set with [<c>sendPitchBendRange()</c>]<see href="#sendPitchBendRange">#sendPitchBendRange</see>. So, for example, if the pitch
        /// bend range has been set to 12 semitones, using a bend value of <c>-1</c> will bend the note 1 octave
        /// below its nominal value.
        /// </summary>
        /// <param name="value">
        /// The intensity of the bend (between <c>-1.0</c> and <c>1.0</c>). A value of
        /// <c>0</c> means no bend. If an invalid value is specified, the nearest valid value will be used
        /// instead. If the <c>rawValue</c> option is set to <c>true</c>, the intensity of the bend can be defined by
        /// either using a single integer between <c>0</c> and <c>127</c> (MSB) or an array of two integers between
        /// <c>0</c> and <c>127</c> representing, respectively, the MSB (most significant byte) and the LSB (least
        /// significant byte). The MSB is expressed in semitones with <c>64</c> meaning no bend. A value lower
        /// than <c>64</c> bends downwards while a value higher than <c>64</c> bends upwards. The LSB is expressed
        /// in cents (1/100 of a semitone). An LSB of <c>64</c> also means no bend.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendPitchBend: value: float * ?options: Output.sendPitchBend.options -> Webmidi.Output
        /// <summary>
        /// Sends a MIDI **pitch bend** message to the specified channel(s) at the scheduled time.
        ///
        /// The resulting bend is relative to the pitch bend range that has been defined. The range can be
        /// set with [<c>sendPitchBendRange()</c>]<see href="#sendPitchBendRange">#sendPitchBendRange</see>. So, for example, if the pitch
        /// bend range has been set to 12 semitones, using a bend value of <c>-1</c> will bend the note 1 octave
        /// below its nominal value.
        /// </summary>
        /// <param name="value">
        /// The intensity of the bend (between <c>-1.0</c> and <c>1.0</c>). A value of
        /// <c>0</c> means no bend. If an invalid value is specified, the nearest valid value will be used
        /// instead. If the <c>rawValue</c> option is set to <c>true</c>, the intensity of the bend can be defined by
        /// either using a single integer between <c>0</c> and <c>127</c> (MSB) or an array of two integers between
        /// <c>0</c> and <c>127</c> representing, respectively, the MSB (most significant byte) and the LSB (least
        /// significant byte). The MSB is expressed in semitones with <c>64</c> meaning no bend. A value lower
        /// than <c>64</c> bends downwards while a value higher than <c>64</c> bends upwards. The LSB is expressed
        /// in cents (1/100 of a semitone). An LSB of <c>64</c> also means no bend.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendPitchBend: value: ResizeArray<float> * ?options: Output.sendPitchBend.options -> Webmidi.Output
        /// <summary>
        /// Sends a MIDI **pitch bend** message to the specified channel(s) at the scheduled time.
        ///
        /// The resulting bend is relative to the pitch bend range that has been defined. The range can be
        /// set with [<c>sendPitchBendRange()</c>]<see href="#sendPitchBendRange">#sendPitchBendRange</see>. So, for example, if the pitch
        /// bend range has been set to 12 semitones, using a bend value of <c>-1</c> will bend the note 1 octave
        /// below its nominal value.
        /// </summary>
        /// <param name="value">
        /// The intensity of the bend (between <c>-1.0</c> and <c>1.0</c>). A value of
        /// <c>0</c> means no bend. If an invalid value is specified, the nearest valid value will be used
        /// instead. If the <c>rawValue</c> option is set to <c>true</c>, the intensity of the bend can be defined by
        /// either using a single integer between <c>0</c> and <c>127</c> (MSB) or an array of two integers between
        /// <c>0</c> and <c>127</c> representing, respectively, the MSB (most significant byte) and the LSB (least
        /// significant byte). The MSB is expressed in semitones with <c>64</c> meaning no bend. A value lower
        /// than <c>64</c> bends downwards while a value higher than <c>64</c> bends upwards. The LSB is expressed
        /// in cents (1/100 of a semitone). An LSB of <c>64</c> also means no bend.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendPitchBend: value: U2<float, ResizeArray<float>> * ?options: Output.sendPitchBend.options -> Webmidi.Output
        /// <summary>
        /// Sends a MIDI **program change** message to the specified channel(s) at the scheduled time.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// Failed to execute 'send' on 'MIDIOutput': The value at index 1 is greater
        /// than 0xFF.
        /// </remarks>
        /// <param name="program">
        /// The MIDI patch (program) number (integer between <c>0</c> and <c>127</c>).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendProgramChange: ?program: float * ?options: Output.sendProgramChange.options -> Webmidi.Output
        /// <summary>
        /// Sends a **modulation depth range** message to the specified channel(s) so that they adjust the
        /// depth of their modulation wheel's range. The range can be specified with the <c>semitones</c>
        /// parameter, the <c>cents</c> parameter or by specifying both parameters at the same time.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// The msb value must be between 0 and 127
        ///
        /// The lsb value must be between 0 and 127
        /// </remarks>
        /// <param name="semitones">
        /// The desired adjustment value in semitones (integer between
        /// 0 and 127).
        /// </param>
        /// <param name="cents">
        /// The desired adjustment value in cents (integer between 0 and 127).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendModulationRange: ?semitones: float * ?cents: float * ?options: Output.sendModulationRange.options -> Webmidi.Output
        /// <summary>
        /// Sends a master tuning message to the specified channel(s). The value is decimal and must be
        /// larger than <c>-65</c> semitones and smaller than <c>64</c> semitones.
        ///
        /// Because of the way the MIDI specification works, the decimal portion of the value will be
        /// encoded with a resolution of 14bit. The integer portion must be between -64 and 63
        /// inclusively. This function actually generates two MIDI messages: a **Master Coarse Tuning** and
        /// a **Master Fine Tuning** RPN messages.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// The value must be a decimal number between larger than -65 and smaller
        /// than 64.
        /// </remarks>
        /// <param name="value">
        /// The desired decimal adjustment value in semitones (-65 < x < 64)
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendMasterTuning: ?value: float * ?options: Output.sendMasterTuning.options -> Webmidi.Output
        /// <summary>
        /// Sets the MIDI tuning program to use. Note that the **Tuning Program** parameter is part of the
        /// *MIDI Tuning Standard*, which is not widely implemented.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// The program value must be between 0 and 127.
        /// </remarks>
        /// <param name="value">
        /// The desired tuning program (integer between <c>0</c> and <c>127</c>).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendTuningProgram: value: float * ?options: Output.sendTuningProgram.options -> Webmidi.Output
        /// <summary>
        /// Sets the MIDI tuning bank to use. Note that the **Tuning Bank** parameter is part of the
        /// *MIDI Tuning Standard*, which is not widely implemented.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// The bank value must be between 0 and 127.
        /// </remarks>
        /// <param name="value">
        /// The desired tuning bank (integer between <c>0</c> and <c>127</c>).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendTuningBank: ?value: float * ?options: Output.sendTuningBank.options -> Webmidi.Output
        /// <summary>
        /// Sends a MIDI **channel mode** message to the specified channel(s). The channel mode message to
        /// send can be specified numerically or by using one of the following common names:
        ///
        /// |  Type                |Number| Shortcut Method                                               |
        /// | ---------------------|------|-------------------------------------------------------------- |
        /// | <c>allsoundoff</c>        | 120  | [<c>sendAllSoundOff()</c>]<see href="#sendAllSoundOff">#sendAllSoundOff</see>                 |
        /// | <c>resetallcontrollers</c>| 121  | [<c>sendResetAllControllers()</c>]<see href="#sendResetAllControllers">#sendResetAllControllers</see> |
        /// | <c>localcontrol</c>       | 122  | [<c>sendLocalControl()</c>]<see href="#sendLocalControl">#sendLocalControl</see>               |
        /// | <c>allnotesoff</c>        | 123  | [<c>sendAllNotesOff()</c>]<see href="#sendAllNotesOff">#sendAllNotesOff</see>                 |
        /// | <c>omnimodeoff</c>        | 124  | [<c>sendOmniMode(false)</c>]<see href="#sendOmniMode">#sendOmniMode</see>                  |
        /// | <c>omnimodeon</c>         | 125  | [<c>sendOmniMode(true)</c>]<see href="#sendOmniMode">#sendOmniMode</see>                   |
        /// | <c>monomodeon</c>         | 126  | [<c>sendPolyphonicMode("mono")</c>]<see href="#sendPolyphonicMode">#sendPolyphonicMode</see>     |
        /// | <c>polymodeon</c>         | 127  | [<c>sendPolyphonicMode("poly")</c>]<see href="#sendPolyphonicMode">#sendPolyphonicMode</see>     |
        ///
        /// Note: as you can see above, to make it easier, all channel mode messages also have a matching
        /// helper method.
        ///
        /// It should also be noted that, per the MIDI specification, only <c>localcontrol</c> and <c>monomodeon</c>
        /// may require a value that's not zero. For that reason, the <c>value</c> parameter is optional and
        /// defaults to 0.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// Invalid channel mode message name.
        ///
        /// Channel mode controller numbers must be between 120 and 127.
        ///
        /// Value must be an integer between 0 and 127.
        /// </remarks>
        /// <param name="command">
        /// The numerical identifier of the channel mode message (integer
        /// between 120-127) or its name as a string.
        /// </param>
        /// <param name="value">
        /// The value to send (integer between 0-127).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendChannelMode: command: float * ?value: float * ?options: Output.sendChannelMode.options -> Webmidi.Output
        /// <summary>
        /// Sends a MIDI **channel mode** message to the specified channel(s). The channel mode message to
        /// send can be specified numerically or by using one of the following common names:
        ///
        /// |  Type                |Number| Shortcut Method                                               |
        /// | ---------------------|------|-------------------------------------------------------------- |
        /// | <c>allsoundoff</c>        | 120  | [<c>sendAllSoundOff()</c>]<see href="#sendAllSoundOff">#sendAllSoundOff</see>                 |
        /// | <c>resetallcontrollers</c>| 121  | [<c>sendResetAllControllers()</c>]<see href="#sendResetAllControllers">#sendResetAllControllers</see> |
        /// | <c>localcontrol</c>       | 122  | [<c>sendLocalControl()</c>]<see href="#sendLocalControl">#sendLocalControl</see>               |
        /// | <c>allnotesoff</c>        | 123  | [<c>sendAllNotesOff()</c>]<see href="#sendAllNotesOff">#sendAllNotesOff</see>                 |
        /// | <c>omnimodeoff</c>        | 124  | [<c>sendOmniMode(false)</c>]<see href="#sendOmniMode">#sendOmniMode</see>                  |
        /// | <c>omnimodeon</c>         | 125  | [<c>sendOmniMode(true)</c>]<see href="#sendOmniMode">#sendOmniMode</see>                   |
        /// | <c>monomodeon</c>         | 126  | [<c>sendPolyphonicMode("mono")</c>]<see href="#sendPolyphonicMode">#sendPolyphonicMode</see>     |
        /// | <c>polymodeon</c>         | 127  | [<c>sendPolyphonicMode("poly")</c>]<see href="#sendPolyphonicMode">#sendPolyphonicMode</see>     |
        ///
        /// Note: as you can see above, to make it easier, all channel mode messages also have a matching
        /// helper method.
        ///
        /// It should also be noted that, per the MIDI specification, only <c>localcontrol</c> and <c>monomodeon</c>
        /// may require a value that's not zero. For that reason, the <c>value</c> parameter is optional and
        /// defaults to 0.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// Invalid channel mode message name.
        ///
        /// Channel mode controller numbers must be between 120 and 127.
        ///
        /// Value must be an integer between 0 and 127.
        /// </remarks>
        /// <param name="command">
        /// The numerical identifier of the channel mode message (integer
        /// between 120-127) or its name as a string.
        /// </param>
        /// <param name="value">
        /// The value to send (integer between 0-127).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendChannelMode: command: string * ?value: float * ?options: Output.sendChannelMode.options -> Webmidi.Output
        /// <summary>
        /// Sends a MIDI **channel mode** message to the specified channel(s). The channel mode message to
        /// send can be specified numerically or by using one of the following common names:
        ///
        /// |  Type                |Number| Shortcut Method                                               |
        /// | ---------------------|------|-------------------------------------------------------------- |
        /// | <c>allsoundoff</c>        | 120  | [<c>sendAllSoundOff()</c>]<see href="#sendAllSoundOff">#sendAllSoundOff</see>                 |
        /// | <c>resetallcontrollers</c>| 121  | [<c>sendResetAllControllers()</c>]<see href="#sendResetAllControllers">#sendResetAllControllers</see> |
        /// | <c>localcontrol</c>       | 122  | [<c>sendLocalControl()</c>]<see href="#sendLocalControl">#sendLocalControl</see>               |
        /// | <c>allnotesoff</c>        | 123  | [<c>sendAllNotesOff()</c>]<see href="#sendAllNotesOff">#sendAllNotesOff</see>                 |
        /// | <c>omnimodeoff</c>        | 124  | [<c>sendOmniMode(false)</c>]<see href="#sendOmniMode">#sendOmniMode</see>                  |
        /// | <c>omnimodeon</c>         | 125  | [<c>sendOmniMode(true)</c>]<see href="#sendOmniMode">#sendOmniMode</see>                   |
        /// | <c>monomodeon</c>         | 126  | [<c>sendPolyphonicMode("mono")</c>]<see href="#sendPolyphonicMode">#sendPolyphonicMode</see>     |
        /// | <c>polymodeon</c>         | 127  | [<c>sendPolyphonicMode("poly")</c>]<see href="#sendPolyphonicMode">#sendPolyphonicMode</see>     |
        ///
        /// Note: as you can see above, to make it easier, all channel mode messages also have a matching
        /// helper method.
        ///
        /// It should also be noted that, per the MIDI specification, only <c>localcontrol</c> and <c>monomodeon</c>
        /// may require a value that's not zero. For that reason, the <c>value</c> parameter is optional and
        /// defaults to 0.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// Invalid channel mode message name.
        ///
        /// Channel mode controller numbers must be between 120 and 127.
        ///
        /// Value must be an integer between 0 and 127.
        /// </remarks>
        /// <param name="command">
        /// The numerical identifier of the channel mode message (integer
        /// between 120-127) or its name as a string.
        /// </param>
        /// <param name="value">
        /// The value to send (integer between 0-127).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendChannelMode: command: U2<float, string> * ?value: float * ?options: Output.sendChannelMode.options -> Webmidi.Output
        /// <summary>
        /// Sends an **all sound off** channel mode message. This will silence all sounds playing on that
        /// channel but will not prevent new sounds from being triggered.
        /// </summary>
        /// <param name="options">
        ///
        /// </param>
        abstract member sendAllSoundOff: ?options: Output.sendAllSoundOff.options -> Webmidi.Output
        /// <summary>
        /// Sends an **all notes off** channel mode message. This will make all currently playing notes
        /// fade out just as if their key had been released. This is different from the
        /// [<c>turnSoundOff()</c>]<see href="#turnSoundOff">#turnSoundOff</see> method which mutes all sounds immediately.
        /// </summary>
        /// <param name="options">
        ///
        /// </param>
        abstract member sendAllNotesOff: ?options: Output.sendAllNotesOff.options -> Webmidi.Output
        /// <summary>
        /// Sends a **reset all controllers** channel mode message. This resets all controllers, such as
        /// the pitch bend, to their default value.
        /// </summary>
        /// <param name="options">
        ///
        /// </param>
        abstract member sendResetAllControllers: ?options: Output.sendResetAllControllers.options -> Webmidi.Output
        /// <summary>
        /// Sets the polyphonic mode. In <c>poly</c> mode (usually the default), multiple notes can be played
        /// and heard at the same time. In <c>mono</c> mode, only one note will be heard at once even if
        /// multiple notes are being played.
        /// </summary>
        /// <param name="mode">
        /// The mode to use: <c>mono</c> or <c>poly</c>.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendPolyphonicMode: mode: string * ?options: Output.sendPolyphonicMode.options -> Webmidi.Output
        /// <summary>
        /// Turns local control on or off. Local control is usually enabled by default. If you disable it,
        /// the instrument will no longer trigger its own sounds. It will only send the MIDI messages to
        /// its out port.
        /// </summary>
        /// <param name="state">
        /// Whether to activate local control (<c>true</c>) or disable it
        /// (<c>false</c>).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendLocalControl: ?state: bool * ?options: Output.sendLocalControl.options -> Webmidi.Output
        /// <summary>
        /// Sets OMNI mode to **on** or **off** for the specified channel(s). MIDI's OMNI mode causes the
        /// instrument to respond to messages from all channels.
        ///
        /// It should be noted that support for OMNI mode is not as common as it used to be.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// Invalid channel mode message name.
        ///
        /// Channel mode controller numbers must be between 120 and 127.
        ///
        /// Value must be an integer between 0 and 127.
        /// </remarks>
        /// <param name="state">
        /// Whether to activate OMNI mode (<c>true</c>) or not (<c>false</c>).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendOmniMode: ?state: bool * ?options: Output.sendOmniMode.options -> Webmidi.Output
        /// <summary>
        /// Sets a non-registered parameter to the specified value. The NRPN is selected by passing a
        /// two-position array specifying the values of the two control bytes. The value is specified by
        /// passing a single integer (most cases) or an array of two integers.
        ///
        /// NRPNs are not standardized in any way. Each manufacturer is free to implement them any way
        /// they see fit. For example, according to the Roland GS specification, you can control the
        /// **vibrato rate** using NRPN (<c>1</c>, <c>8</c>). Therefore, to set the **vibrato rate** value to <c>123</c>
        /// you would use:
        ///
        /// <code lang="js">
        /// WebMidi.outputs[0].sendNrpnValue([1, 8], 123);
        /// </code>
        ///
        /// You probably want to should select a channel so the message is not sent to all channels. For
        /// instance, to send to channel <c>1</c> of the first output port, you would use:
        ///
        /// <code lang="js">
        /// WebMidi.outputs[0].sendNrpnValue([1, 8], 123, 1);
        /// </code>
        ///
        /// In some rarer cases, you need to send two values with your NRPN messages. In such cases, you
        /// would use a 2-position array. For example, for its **ClockBPM** parameter (<c>2</c>, <c>63</c>), Novation
        /// uses a 14-bit value that combines an MSB and an LSB (7-bit values). So, for example, if the
        /// value to send was <c>10</c>, you could use:
        ///
        /// <code lang="js">
        /// WebMidi.outputs[0].sendNrpnValue([2, 63], [0, 10], 1);
        /// </code>
        ///
        /// For further implementation details, refer to the manufacturer's documentation.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// The control value must be between 0 and 127.
        ///
        /// The msb value must be between 0 and 127
        /// </remarks>
        /// <param name="parameter">
        /// A two-position array specifying the two control bytes (<c>0x63</c>,
        /// <c>0x62</c>) that identify the non-registered parameter.
        /// </param>
        /// <param name="data">
        /// An integer or an array of integers with a length of 1 or 2
        /// specifying the desired data.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendNrpnValue: parameter: ResizeArray<float> -> Webmidi.Output
        /// <summary>
        /// Sets a non-registered parameter to the specified value. The NRPN is selected by passing a
        /// two-position array specifying the values of the two control bytes. The value is specified by
        /// passing a single integer (most cases) or an array of two integers.
        ///
        /// NRPNs are not standardized in any way. Each manufacturer is free to implement them any way
        /// they see fit. For example, according to the Roland GS specification, you can control the
        /// **vibrato rate** using NRPN (<c>1</c>, <c>8</c>). Therefore, to set the **vibrato rate** value to <c>123</c>
        /// you would use:
        ///
        /// <code lang="js">
        /// WebMidi.outputs[0].sendNrpnValue([1, 8], 123);
        /// </code>
        ///
        /// You probably want to should select a channel so the message is not sent to all channels. For
        /// instance, to send to channel <c>1</c> of the first output port, you would use:
        ///
        /// <code lang="js">
        /// WebMidi.outputs[0].sendNrpnValue([1, 8], 123, 1);
        /// </code>
        ///
        /// In some rarer cases, you need to send two values with your NRPN messages. In such cases, you
        /// would use a 2-position array. For example, for its **ClockBPM** parameter (<c>2</c>, <c>63</c>), Novation
        /// uses a 14-bit value that combines an MSB and an LSB (7-bit values). So, for example, if the
        /// value to send was <c>10</c>, you could use:
        ///
        /// <code lang="js">
        /// WebMidi.outputs[0].sendNrpnValue([2, 63], [0, 10], 1);
        /// </code>
        ///
        /// For further implementation details, refer to the manufacturer's documentation.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// The control value must be between 0 and 127.
        ///
        /// The msb value must be between 0 and 127
        /// </remarks>
        /// <param name="parameter">
        /// A two-position array specifying the two control bytes (<c>0x63</c>,
        /// <c>0x62</c>) that identify the non-registered parameter.
        /// </param>
        /// <param name="data">
        /// An integer or an array of integers with a length of 1 or 2
        /// specifying the desired data.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendNrpnValue: parameter: ResizeArray<float> * data: float * ?options: Output.sendNrpnValue.options -> Webmidi.Output
        /// <summary>
        /// Sets a non-registered parameter to the specified value. The NRPN is selected by passing a
        /// two-position array specifying the values of the two control bytes. The value is specified by
        /// passing a single integer (most cases) or an array of two integers.
        ///
        /// NRPNs are not standardized in any way. Each manufacturer is free to implement them any way
        /// they see fit. For example, according to the Roland GS specification, you can control the
        /// **vibrato rate** using NRPN (<c>1</c>, <c>8</c>). Therefore, to set the **vibrato rate** value to <c>123</c>
        /// you would use:
        ///
        /// <code lang="js">
        /// WebMidi.outputs[0].sendNrpnValue([1, 8], 123);
        /// </code>
        ///
        /// You probably want to should select a channel so the message is not sent to all channels. For
        /// instance, to send to channel <c>1</c> of the first output port, you would use:
        ///
        /// <code lang="js">
        /// WebMidi.outputs[0].sendNrpnValue([1, 8], 123, 1);
        /// </code>
        ///
        /// In some rarer cases, you need to send two values with your NRPN messages. In such cases, you
        /// would use a 2-position array. For example, for its **ClockBPM** parameter (<c>2</c>, <c>63</c>), Novation
        /// uses a 14-bit value that combines an MSB and an LSB (7-bit values). So, for example, if the
        /// value to send was <c>10</c>, you could use:
        ///
        /// <code lang="js">
        /// WebMidi.outputs[0].sendNrpnValue([2, 63], [0, 10], 1);
        /// </code>
        ///
        /// For further implementation details, refer to the manufacturer's documentation.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// The control value must be between 0 and 127.
        ///
        /// The msb value must be between 0 and 127
        /// </remarks>
        /// <param name="parameter">
        /// A two-position array specifying the two control bytes (<c>0x63</c>,
        /// <c>0x62</c>) that identify the non-registered parameter.
        /// </param>
        /// <param name="data">
        /// An integer or an array of integers with a length of 1 or 2
        /// specifying the desired data.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendNrpnValue: parameter: ResizeArray<float> * data: ResizeArray<float> * ?options: Output.sendNrpnValue.options -> Webmidi.Output
        /// <summary>
        /// Increments the specified MIDI registered parameter by 1. Here is the full list of parameter
        /// names that can be used with this method:
        ///
        ///  * Pitchbend Range (0x00, 0x00): <c>"pitchbendrange"</c>
        ///  * Channel Fine Tuning (0x00, 0x01): <c>"channelfinetuning"</c>
        ///  * Channel Coarse Tuning (0x00, 0x02): <c>"channelcoarsetuning"</c>
        ///  * Tuning Program (0x00, 0x03): <c>"tuningprogram"</c>
        ///  * Tuning Bank (0x00, 0x04): <c>"tuningbank"</c>
        ///  * Modulation Range (0x00, 0x05): <c>"modulationrange"</c>
        ///  * Azimuth Angle (0x3D, 0x00): <c>"azimuthangle"</c>
        ///  * Elevation Angle (0x3D, 0x01): <c>"elevationangle"</c>
        ///  * Gain (0x3D, 0x02): <c>"gain"</c>
        ///  * Distance Ratio (0x3D, 0x03): <c>"distanceratio"</c>
        ///  * Maximum Distance (0x3D, 0x04): <c>"maximumdistance"</c>
        ///  * Maximum Distance Gain (0x3D, 0x05): <c>"maximumdistancegain"</c>
        ///  * Reference Distance Ratio (0x3D, 0x06): <c>"referencedistanceratio"</c>
        ///  * Pan Spread Angle (0x3D, 0x07): <c>"panspreadangle"</c>
        ///  * Roll Angle (0x3D, 0x08): <c>"rollangle"</c>
        /// </summary>
        /// <param name="parameter">
        /// A string identifying the parameter's name (see above) or a
        /// two-position array specifying the two control bytes (0x65, 0x64) that identify the registered
        /// parameter.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendRpnIncrement: parameter: string * ?options: Output.sendRpnIncrement.options -> Webmidi.Output
        /// <summary>
        /// Increments the specified MIDI registered parameter by 1. Here is the full list of parameter
        /// names that can be used with this method:
        ///
        ///  * Pitchbend Range (0x00, 0x00): <c>"pitchbendrange"</c>
        ///  * Channel Fine Tuning (0x00, 0x01): <c>"channelfinetuning"</c>
        ///  * Channel Coarse Tuning (0x00, 0x02): <c>"channelcoarsetuning"</c>
        ///  * Tuning Program (0x00, 0x03): <c>"tuningprogram"</c>
        ///  * Tuning Bank (0x00, 0x04): <c>"tuningbank"</c>
        ///  * Modulation Range (0x00, 0x05): <c>"modulationrange"</c>
        ///  * Azimuth Angle (0x3D, 0x00): <c>"azimuthangle"</c>
        ///  * Elevation Angle (0x3D, 0x01): <c>"elevationangle"</c>
        ///  * Gain (0x3D, 0x02): <c>"gain"</c>
        ///  * Distance Ratio (0x3D, 0x03): <c>"distanceratio"</c>
        ///  * Maximum Distance (0x3D, 0x04): <c>"maximumdistance"</c>
        ///  * Maximum Distance Gain (0x3D, 0x05): <c>"maximumdistancegain"</c>
        ///  * Reference Distance Ratio (0x3D, 0x06): <c>"referencedistanceratio"</c>
        ///  * Pan Spread Angle (0x3D, 0x07): <c>"panspreadangle"</c>
        ///  * Roll Angle (0x3D, 0x08): <c>"rollangle"</c>
        /// </summary>
        /// <param name="parameter">
        /// A string identifying the parameter's name (see above) or a
        /// two-position array specifying the two control bytes (0x65, 0x64) that identify the registered
        /// parameter.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendRpnIncrement: parameter: ResizeArray<float> * ?options: Output.sendRpnIncrement.options -> Webmidi.Output
        /// <summary>
        /// Increments the specified MIDI registered parameter by 1. Here is the full list of parameter
        /// names that can be used with this method:
        ///
        ///  * Pitchbend Range (0x00, 0x00): <c>"pitchbendrange"</c>
        ///  * Channel Fine Tuning (0x00, 0x01): <c>"channelfinetuning"</c>
        ///  * Channel Coarse Tuning (0x00, 0x02): <c>"channelcoarsetuning"</c>
        ///  * Tuning Program (0x00, 0x03): <c>"tuningprogram"</c>
        ///  * Tuning Bank (0x00, 0x04): <c>"tuningbank"</c>
        ///  * Modulation Range (0x00, 0x05): <c>"modulationrange"</c>
        ///  * Azimuth Angle (0x3D, 0x00): <c>"azimuthangle"</c>
        ///  * Elevation Angle (0x3D, 0x01): <c>"elevationangle"</c>
        ///  * Gain (0x3D, 0x02): <c>"gain"</c>
        ///  * Distance Ratio (0x3D, 0x03): <c>"distanceratio"</c>
        ///  * Maximum Distance (0x3D, 0x04): <c>"maximumdistance"</c>
        ///  * Maximum Distance Gain (0x3D, 0x05): <c>"maximumdistancegain"</c>
        ///  * Reference Distance Ratio (0x3D, 0x06): <c>"referencedistanceratio"</c>
        ///  * Pan Spread Angle (0x3D, 0x07): <c>"panspreadangle"</c>
        ///  * Roll Angle (0x3D, 0x08): <c>"rollangle"</c>
        /// </summary>
        /// <param name="parameter">
        /// A string identifying the parameter's name (see above) or a
        /// two-position array specifying the two control bytes (0x65, 0x64) that identify the registered
        /// parameter.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendRpnIncrement: parameter: U2<string, ResizeArray<float>> * ?options: Output.sendRpnIncrement.options -> Webmidi.Output
        /// <summary>
        /// Decrements the specified MIDI registered parameter by 1. Here is the full list of parameter
        /// names that can be used with this method:
        ///
        ///  * Pitchbend Range (0x00, 0x00): <c>"pitchbendrange"</c>
        ///  * Channel Fine Tuning (0x00, 0x01): <c>"channelfinetuning"</c>
        ///  * Channel Coarse Tuning (0x00, 0x02): <c>"channelcoarsetuning"</c>
        ///  * Tuning Program (0x00, 0x03): <c>"tuningprogram"</c>
        ///  * Tuning Bank (0x00, 0x04): <c>"tuningbank"</c>
        ///  * Modulation Range (0x00, 0x05): <c>"modulationrange"</c>
        ///  * Azimuth Angle (0x3D, 0x00): <c>"azimuthangle"</c>
        ///  * Elevation Angle (0x3D, 0x01): <c>"elevationangle"</c>
        ///  * Gain (0x3D, 0x02): <c>"gain"</c>
        ///  * Distance Ratio (0x3D, 0x03): <c>"distanceratio"</c>
        ///  * Maximum Distance (0x3D, 0x04): <c>"maximumdistance"</c>
        ///  * Maximum Distance Gain (0x3D, 0x05): <c>"maximumdistancegain"</c>
        ///  * Reference Distance Ratio (0x3D, 0x06): <c>"referencedistanceratio"</c>
        ///  * Pan Spread Angle (0x3D, 0x07): <c>"panspreadangle"</c>
        ///  * Roll Angle (0x3D, 0x08): <c>"rollangle"</c>
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// TypeError The specified parameter is not available.
        /// </remarks>
        /// <param name="parameter">
        /// A string identifying the parameter's name (see above) or a
        /// two-position array specifying the two control bytes (0x65, 0x64) that identify the registered
        /// parameter.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendRpnDecrement: parameter: string * ?options: Output.sendRpnDecrement.options -> Webmidi.Output
        /// <summary>
        /// Decrements the specified MIDI registered parameter by 1. Here is the full list of parameter
        /// names that can be used with this method:
        ///
        ///  * Pitchbend Range (0x00, 0x00): <c>"pitchbendrange"</c>
        ///  * Channel Fine Tuning (0x00, 0x01): <c>"channelfinetuning"</c>
        ///  * Channel Coarse Tuning (0x00, 0x02): <c>"channelcoarsetuning"</c>
        ///  * Tuning Program (0x00, 0x03): <c>"tuningprogram"</c>
        ///  * Tuning Bank (0x00, 0x04): <c>"tuningbank"</c>
        ///  * Modulation Range (0x00, 0x05): <c>"modulationrange"</c>
        ///  * Azimuth Angle (0x3D, 0x00): <c>"azimuthangle"</c>
        ///  * Elevation Angle (0x3D, 0x01): <c>"elevationangle"</c>
        ///  * Gain (0x3D, 0x02): <c>"gain"</c>
        ///  * Distance Ratio (0x3D, 0x03): <c>"distanceratio"</c>
        ///  * Maximum Distance (0x3D, 0x04): <c>"maximumdistance"</c>
        ///  * Maximum Distance Gain (0x3D, 0x05): <c>"maximumdistancegain"</c>
        ///  * Reference Distance Ratio (0x3D, 0x06): <c>"referencedistanceratio"</c>
        ///  * Pan Spread Angle (0x3D, 0x07): <c>"panspreadangle"</c>
        ///  * Roll Angle (0x3D, 0x08): <c>"rollangle"</c>
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// TypeError The specified parameter is not available.
        /// </remarks>
        /// <param name="parameter">
        /// A string identifying the parameter's name (see above) or a
        /// two-position array specifying the two control bytes (0x65, 0x64) that identify the registered
        /// parameter.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendRpnDecrement: parameter: ResizeArray<float> * ?options: Output.sendRpnDecrement.options -> Webmidi.Output
        /// <summary>
        /// Decrements the specified MIDI registered parameter by 1. Here is the full list of parameter
        /// names that can be used with this method:
        ///
        ///  * Pitchbend Range (0x00, 0x00): <c>"pitchbendrange"</c>
        ///  * Channel Fine Tuning (0x00, 0x01): <c>"channelfinetuning"</c>
        ///  * Channel Coarse Tuning (0x00, 0x02): <c>"channelcoarsetuning"</c>
        ///  * Tuning Program (0x00, 0x03): <c>"tuningprogram"</c>
        ///  * Tuning Bank (0x00, 0x04): <c>"tuningbank"</c>
        ///  * Modulation Range (0x00, 0x05): <c>"modulationrange"</c>
        ///  * Azimuth Angle (0x3D, 0x00): <c>"azimuthangle"</c>
        ///  * Elevation Angle (0x3D, 0x01): <c>"elevationangle"</c>
        ///  * Gain (0x3D, 0x02): <c>"gain"</c>
        ///  * Distance Ratio (0x3D, 0x03): <c>"distanceratio"</c>
        ///  * Maximum Distance (0x3D, 0x04): <c>"maximumdistance"</c>
        ///  * Maximum Distance Gain (0x3D, 0x05): <c>"maximumdistancegain"</c>
        ///  * Reference Distance Ratio (0x3D, 0x06): <c>"referencedistanceratio"</c>
        ///  * Pan Spread Angle (0x3D, 0x07): <c>"panspreadangle"</c>
        ///  * Roll Angle (0x3D, 0x08): <c>"rollangle"</c>
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// TypeError The specified parameter is not available.
        /// </remarks>
        /// <param name="parameter">
        /// A string identifying the parameter's name (see above) or a
        /// two-position array specifying the two control bytes (0x65, 0x64) that identify the registered
        /// parameter.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendRpnDecrement: parameter: U2<string, ResizeArray<float>> * ?options: Output.sendRpnDecrement.options -> Webmidi.Output
        /// <summary>
        /// Sends a **note off** message for the specified MIDI note number on the specified channel(s).
        /// The first parameter is the note to stop. It can be a single value or an array of the following
        /// valid values:
        ///
        ///  - A MIDI note number (integer between <c>0</c> and <c>127</c>)
        ///  - A note identifier (e.g. <c>"C3"</c>, <c>"G#4"</c>, <c>"F-1"</c>, <c>"Db7"</c>)
        ///  - A [<c>Note</c>](Note) object
        ///
        /// The execution of the **note off** command can be delayed by using the <c>time</c> property of the
        /// <c>options</c> parameter.
        /// </summary>
        /// <param name="note">
        /// The note(s) to stop. The notes can be
        /// specified by using a MIDI note number (<c>0</c> - <c>127</c>), a note identifier (e.g. <c>C3</c>, <c>G#4</c>,
        /// <c>F-1</c>, <c>Db7</c>) or an array of the previous types. When using a note identifier, octave range
        /// must be between <c>-1</c> and <c>9</c>. The lowest note is <c>C-1</c> (MIDI note number <c>0</c>) and the highest
        /// note is <c>G9</c> (MIDI note number <c>127</c>).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendNoteOff: note: float * ?options: Output.sendNoteOff.options -> Webmidi.Output
        /// <summary>
        /// Sends a **note off** message for the specified MIDI note number on the specified channel(s).
        /// The first parameter is the note to stop. It can be a single value or an array of the following
        /// valid values:
        ///
        ///  - A MIDI note number (integer between <c>0</c> and <c>127</c>)
        ///  - A note identifier (e.g. <c>"C3"</c>, <c>"G#4"</c>, <c>"F-1"</c>, <c>"Db7"</c>)
        ///  - A [<c>Note</c>](Note) object
        ///
        /// The execution of the **note off** command can be delayed by using the <c>time</c> property of the
        /// <c>options</c> parameter.
        /// </summary>
        /// <param name="note">
        /// The note(s) to stop. The notes can be
        /// specified by using a MIDI note number (<c>0</c> - <c>127</c>), a note identifier (e.g. <c>C3</c>, <c>G#4</c>,
        /// <c>F-1</c>, <c>Db7</c>) or an array of the previous types. When using a note identifier, octave range
        /// must be between <c>-1</c> and <c>9</c>. The lowest note is <c>C-1</c> (MIDI note number <c>0</c>) and the highest
        /// note is <c>G9</c> (MIDI note number <c>127</c>).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendNoteOff: note: Webmidi.Note * ?options: Output.sendNoteOff.options -> Webmidi.Output
        /// <summary>
        /// Sends a **note off** message for the specified MIDI note number on the specified channel(s).
        /// The first parameter is the note to stop. It can be a single value or an array of the following
        /// valid values:
        ///
        ///  - A MIDI note number (integer between <c>0</c> and <c>127</c>)
        ///  - A note identifier (e.g. <c>"C3"</c>, <c>"G#4"</c>, <c>"F-1"</c>, <c>"Db7"</c>)
        ///  - A [<c>Note</c>](Note) object
        ///
        /// The execution of the **note off** command can be delayed by using the <c>time</c> property of the
        /// <c>options</c> parameter.
        /// </summary>
        /// <param name="note">
        /// The note(s) to stop. The notes can be
        /// specified by using a MIDI note number (<c>0</c> - <c>127</c>), a note identifier (e.g. <c>C3</c>, <c>G#4</c>,
        /// <c>F-1</c>, <c>Db7</c>) or an array of the previous types. When using a note identifier, octave range
        /// must be between <c>-1</c> and <c>9</c>. The lowest note is <c>C-1</c> (MIDI note number <c>0</c>) and the highest
        /// note is <c>G9</c> (MIDI note number <c>127</c>).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendNoteOff: note: string * ?options: Output.sendNoteOff.options -> Webmidi.Output
        /// <summary>
        /// Sends a **note off** message for the specified MIDI note number on the specified channel(s).
        /// The first parameter is the note to stop. It can be a single value or an array of the following
        /// valid values:
        ///
        ///  - A MIDI note number (integer between <c>0</c> and <c>127</c>)
        ///  - A note identifier (e.g. <c>"C3"</c>, <c>"G#4"</c>, <c>"F-1"</c>, <c>"Db7"</c>)
        ///  - A [<c>Note</c>](Note) object
        ///
        /// The execution of the **note off** command can be delayed by using the <c>time</c> property of the
        /// <c>options</c> parameter.
        /// </summary>
        /// <param name="note">
        /// The note(s) to stop. The notes can be
        /// specified by using a MIDI note number (<c>0</c> - <c>127</c>), a note identifier (e.g. <c>C3</c>, <c>G#4</c>,
        /// <c>F-1</c>, <c>Db7</c>) or an array of the previous types. When using a note identifier, octave range
        /// must be between <c>-1</c> and <c>9</c>. The lowest note is <c>C-1</c> (MIDI note number <c>0</c>) and the highest
        /// note is <c>G9</c> (MIDI note number <c>127</c>).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendNoteOff: note: ResizeArray<float> * ?options: Output.sendNoteOff.options -> Webmidi.Output
        /// <summary>
        /// Sends a **note off** message for the specified MIDI note number on the specified channel(s).
        /// The first parameter is the note to stop. It can be a single value or an array of the following
        /// valid values:
        ///
        ///  - A MIDI note number (integer between <c>0</c> and <c>127</c>)
        ///  - A note identifier (e.g. <c>"C3"</c>, <c>"G#4"</c>, <c>"F-1"</c>, <c>"Db7"</c>)
        ///  - A [<c>Note</c>](Note) object
        ///
        /// The execution of the **note off** command can be delayed by using the <c>time</c> property of the
        /// <c>options</c> parameter.
        /// </summary>
        /// <param name="note">
        /// The note(s) to stop. The notes can be
        /// specified by using a MIDI note number (<c>0</c> - <c>127</c>), a note identifier (e.g. <c>C3</c>, <c>G#4</c>,
        /// <c>F-1</c>, <c>Db7</c>) or an array of the previous types. When using a note identifier, octave range
        /// must be between <c>-1</c> and <c>9</c>. The lowest note is <c>C-1</c> (MIDI note number <c>0</c>) and the highest
        /// note is <c>G9</c> (MIDI note number <c>127</c>).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendNoteOff: note: ResizeArray<Webmidi.Note> * ?options: Output.sendNoteOff.options -> Webmidi.Output
        /// <summary>
        /// Sends a **note off** message for the specified MIDI note number on the specified channel(s).
        /// The first parameter is the note to stop. It can be a single value or an array of the following
        /// valid values:
        ///
        ///  - A MIDI note number (integer between <c>0</c> and <c>127</c>)
        ///  - A note identifier (e.g. <c>"C3"</c>, <c>"G#4"</c>, <c>"F-1"</c>, <c>"Db7"</c>)
        ///  - A [<c>Note</c>](Note) object
        ///
        /// The execution of the **note off** command can be delayed by using the <c>time</c> property of the
        /// <c>options</c> parameter.
        /// </summary>
        /// <param name="note">
        /// The note(s) to stop. The notes can be
        /// specified by using a MIDI note number (<c>0</c> - <c>127</c>), a note identifier (e.g. <c>C3</c>, <c>G#4</c>,
        /// <c>F-1</c>, <c>Db7</c>) or an array of the previous types. When using a note identifier, octave range
        /// must be between <c>-1</c> and <c>9</c>. The lowest note is <c>C-1</c> (MIDI note number <c>0</c>) and the highest
        /// note is <c>G9</c> (MIDI note number <c>127</c>).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendNoteOff: note: ResizeArray<string> * ?options: Output.sendNoteOff.options -> Webmidi.Output
        /// <summary>
        /// Sends a **note off** message for the specified MIDI note number on the specified channel(s).
        /// The first parameter is the note to stop. It can be a single value or an array of the following
        /// valid values:
        ///
        ///  - A MIDI note number (integer between <c>0</c> and <c>127</c>)
        ///  - A note identifier (e.g. <c>"C3"</c>, <c>"G#4"</c>, <c>"F-1"</c>, <c>"Db7"</c>)
        ///  - A [<c>Note</c>](Note) object
        ///
        /// The execution of the **note off** command can be delayed by using the <c>time</c> property of the
        /// <c>options</c> parameter.
        /// </summary>
        /// <param name="note">
        /// The note(s) to stop. The notes can be
        /// specified by using a MIDI note number (<c>0</c> - <c>127</c>), a note identifier (e.g. <c>C3</c>, <c>G#4</c>,
        /// <c>F-1</c>, <c>Db7</c>) or an array of the previous types. When using a note identifier, octave range
        /// must be between <c>-1</c> and <c>9</c>. The lowest note is <c>C-1</c> (MIDI note number <c>0</c>) and the highest
        /// note is <c>G9</c> (MIDI note number <c>127</c>).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendNoteOff: note: U6<float, Webmidi.Note, string, ResizeArray<float>, ResizeArray<Webmidi.Note>, ResizeArray<string>> * ?options: Output.sendNoteOff.options -> Webmidi.Output
        /// <summary>
        /// Sends a **note off** message for the specified MIDI note number on the specified channel(s).
        /// The first parameter is the note to stop. It can be a single value or an array of the following
        /// valid values:
        ///
        ///  - A MIDI note number (integer between <c>0</c> and <c>127</c>)
        ///  - A note identifier (e.g. <c>"C3"</c>, <c>"G#4"</c>, <c>"F-1"</c>, <c>"Db7"</c>)
        ///  - A [<c>Note</c>](Note) object
        ///
        /// The execution of the **note off** command can be delayed by using the <c>time</c> property of the
        /// <c>options</c> parameter.
        /// </summary>
        /// <param name="note">
        /// The note(s) to stop. The notes can be
        /// specified by using a MIDI note number (<c>0</c> - <c>127</c>), a note identifier (e.g. <c>C3</c>, <c>G#4</c>, <c>F-1</c>,
        /// <c>Db7</c>) or an array of the previous types. When using a note identifier, octave range must be
        /// between <c>-1</c> and <c>9</c>. The lowest note is <c>C-1</c> (MIDI note number <c>0</c>) and the highest note is
        /// <c>G9</c> (MIDI note number <c>127</c>).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member stopNote: note: float * ?options: Output.stopNote.options -> Webmidi.Output
        /// <summary>
        /// Sends a **note off** message for the specified MIDI note number on the specified channel(s).
        /// The first parameter is the note to stop. It can be a single value or an array of the following
        /// valid values:
        ///
        ///  - A MIDI note number (integer between <c>0</c> and <c>127</c>)
        ///  - A note identifier (e.g. <c>"C3"</c>, <c>"G#4"</c>, <c>"F-1"</c>, <c>"Db7"</c>)
        ///  - A [<c>Note</c>](Note) object
        ///
        /// The execution of the **note off** command can be delayed by using the <c>time</c> property of the
        /// <c>options</c> parameter.
        /// </summary>
        /// <param name="note">
        /// The note(s) to stop. The notes can be
        /// specified by using a MIDI note number (<c>0</c> - <c>127</c>), a note identifier (e.g. <c>C3</c>, <c>G#4</c>, <c>F-1</c>,
        /// <c>Db7</c>) or an array of the previous types. When using a note identifier, octave range must be
        /// between <c>-1</c> and <c>9</c>. The lowest note is <c>C-1</c> (MIDI note number <c>0</c>) and the highest note is
        /// <c>G9</c> (MIDI note number <c>127</c>).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member stopNote: note: Webmidi.Note * ?options: Output.stopNote.options -> Webmidi.Output
        /// <summary>
        /// Sends a **note off** message for the specified MIDI note number on the specified channel(s).
        /// The first parameter is the note to stop. It can be a single value or an array of the following
        /// valid values:
        ///
        ///  - A MIDI note number (integer between <c>0</c> and <c>127</c>)
        ///  - A note identifier (e.g. <c>"C3"</c>, <c>"G#4"</c>, <c>"F-1"</c>, <c>"Db7"</c>)
        ///  - A [<c>Note</c>](Note) object
        ///
        /// The execution of the **note off** command can be delayed by using the <c>time</c> property of the
        /// <c>options</c> parameter.
        /// </summary>
        /// <param name="note">
        /// The note(s) to stop. The notes can be
        /// specified by using a MIDI note number (<c>0</c> - <c>127</c>), a note identifier (e.g. <c>C3</c>, <c>G#4</c>, <c>F-1</c>,
        /// <c>Db7</c>) or an array of the previous types. When using a note identifier, octave range must be
        /// between <c>-1</c> and <c>9</c>. The lowest note is <c>C-1</c> (MIDI note number <c>0</c>) and the highest note is
        /// <c>G9</c> (MIDI note number <c>127</c>).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member stopNote: note: string * ?options: Output.stopNote.options -> Webmidi.Output
        /// <summary>
        /// Sends a **note off** message for the specified MIDI note number on the specified channel(s).
        /// The first parameter is the note to stop. It can be a single value or an array of the following
        /// valid values:
        ///
        ///  - A MIDI note number (integer between <c>0</c> and <c>127</c>)
        ///  - A note identifier (e.g. <c>"C3"</c>, <c>"G#4"</c>, <c>"F-1"</c>, <c>"Db7"</c>)
        ///  - A [<c>Note</c>](Note) object
        ///
        /// The execution of the **note off** command can be delayed by using the <c>time</c> property of the
        /// <c>options</c> parameter.
        /// </summary>
        /// <param name="note">
        /// The note(s) to stop. The notes can be
        /// specified by using a MIDI note number (<c>0</c> - <c>127</c>), a note identifier (e.g. <c>C3</c>, <c>G#4</c>, <c>F-1</c>,
        /// <c>Db7</c>) or an array of the previous types. When using a note identifier, octave range must be
        /// between <c>-1</c> and <c>9</c>. The lowest note is <c>C-1</c> (MIDI note number <c>0</c>) and the highest note is
        /// <c>G9</c> (MIDI note number <c>127</c>).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member stopNote: note: ResizeArray<float> * ?options: Output.stopNote.options -> Webmidi.Output
        /// <summary>
        /// Sends a **note off** message for the specified MIDI note number on the specified channel(s).
        /// The first parameter is the note to stop. It can be a single value or an array of the following
        /// valid values:
        ///
        ///  - A MIDI note number (integer between <c>0</c> and <c>127</c>)
        ///  - A note identifier (e.g. <c>"C3"</c>, <c>"G#4"</c>, <c>"F-1"</c>, <c>"Db7"</c>)
        ///  - A [<c>Note</c>](Note) object
        ///
        /// The execution of the **note off** command can be delayed by using the <c>time</c> property of the
        /// <c>options</c> parameter.
        /// </summary>
        /// <param name="note">
        /// The note(s) to stop. The notes can be
        /// specified by using a MIDI note number (<c>0</c> - <c>127</c>), a note identifier (e.g. <c>C3</c>, <c>G#4</c>, <c>F-1</c>,
        /// <c>Db7</c>) or an array of the previous types. When using a note identifier, octave range must be
        /// between <c>-1</c> and <c>9</c>. The lowest note is <c>C-1</c> (MIDI note number <c>0</c>) and the highest note is
        /// <c>G9</c> (MIDI note number <c>127</c>).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member stopNote: note: ResizeArray<Webmidi.Note> * ?options: Output.stopNote.options -> Webmidi.Output
        /// <summary>
        /// Sends a **note off** message for the specified MIDI note number on the specified channel(s).
        /// The first parameter is the note to stop. It can be a single value or an array of the following
        /// valid values:
        ///
        ///  - A MIDI note number (integer between <c>0</c> and <c>127</c>)
        ///  - A note identifier (e.g. <c>"C3"</c>, <c>"G#4"</c>, <c>"F-1"</c>, <c>"Db7"</c>)
        ///  - A [<c>Note</c>](Note) object
        ///
        /// The execution of the **note off** command can be delayed by using the <c>time</c> property of the
        /// <c>options</c> parameter.
        /// </summary>
        /// <param name="note">
        /// The note(s) to stop. The notes can be
        /// specified by using a MIDI note number (<c>0</c> - <c>127</c>), a note identifier (e.g. <c>C3</c>, <c>G#4</c>, <c>F-1</c>,
        /// <c>Db7</c>) or an array of the previous types. When using a note identifier, octave range must be
        /// between <c>-1</c> and <c>9</c>. The lowest note is <c>C-1</c> (MIDI note number <c>0</c>) and the highest note is
        /// <c>G9</c> (MIDI note number <c>127</c>).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member stopNote: note: ResizeArray<string> * ?options: Output.stopNote.options -> Webmidi.Output
        /// <summary>
        /// Sends a **note off** message for the specified MIDI note number on the specified channel(s).
        /// The first parameter is the note to stop. It can be a single value or an array of the following
        /// valid values:
        ///
        ///  - A MIDI note number (integer between <c>0</c> and <c>127</c>)
        ///  - A note identifier (e.g. <c>"C3"</c>, <c>"G#4"</c>, <c>"F-1"</c>, <c>"Db7"</c>)
        ///  - A [<c>Note</c>](Note) object
        ///
        /// The execution of the **note off** command can be delayed by using the <c>time</c> property of the
        /// <c>options</c> parameter.
        /// </summary>
        /// <param name="note">
        /// The note(s) to stop. The notes can be
        /// specified by using a MIDI note number (<c>0</c> - <c>127</c>), a note identifier (e.g. <c>C3</c>, <c>G#4</c>, <c>F-1</c>,
        /// <c>Db7</c>) or an array of the previous types. When using a note identifier, octave range must be
        /// between <c>-1</c> and <c>9</c>. The lowest note is <c>C-1</c> (MIDI note number <c>0</c>) and the highest note is
        /// <c>G9</c> (MIDI note number <c>127</c>).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member stopNote: note: U6<float, Webmidi.Note, string, ResizeArray<float>, ResizeArray<Webmidi.Note>, ResizeArray<string>> * ?options: Output.stopNote.options -> Webmidi.Output
        /// <summary>
        /// Sends a **note on** message for the specified MIDI note number on the specified channel(s). The
        /// first parameter is the number. It can be a single value or an array of the following valid
        /// values:
        ///
        ///  - A MIDI note number (integer between <c>0</c> and <c>127</c>)
        ///  - A note identifier (e.g. <c>"C3"</c>, <c>"G#4"</c>, <c>"F-1"</c>, <c>"Db7"</c>)
        ///  - A [<c>Note</c>](Note) object
        ///
        ///  The execution of the **note on** command can be delayed by using the <c>time</c> property of the
        /// <c>options</c> parameter.
        ///
        /// **Note**: As per the MIDI standard, a **note on** message with an attack velocity of <c>0</c> is
        /// functionally equivalent to a **note off** message.
        /// </summary>
        /// <param name="note">
        /// The note(s) to stop. The notes can be
        /// specified by using a MIDI note number (<c>0</c> - <c>127</c>), a note identifier (e.g. <c>C3</c>, <c>G#4</c>, <c>F-1</c>,
        /// <c>Db7</c>) or an array of the previous types. When using a note identifier, octave range must be
        /// between <c>-1</c> and <c>9</c>. The lowest note is <c>C-1</c> (MIDI note number <c>0</c>) and the highest note is
        /// <c>G9</c> (MIDI note number <c>127</c>).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendNoteOn: note: float * ?options: Output.sendNoteOn.options -> Webmidi.Output
        /// <summary>
        /// Sends a **note on** message for the specified MIDI note number on the specified channel(s). The
        /// first parameter is the number. It can be a single value or an array of the following valid
        /// values:
        ///
        ///  - A MIDI note number (integer between <c>0</c> and <c>127</c>)
        ///  - A note identifier (e.g. <c>"C3"</c>, <c>"G#4"</c>, <c>"F-1"</c>, <c>"Db7"</c>)
        ///  - A [<c>Note</c>](Note) object
        ///
        ///  The execution of the **note on** command can be delayed by using the <c>time</c> property of the
        /// <c>options</c> parameter.
        ///
        /// **Note**: As per the MIDI standard, a **note on** message with an attack velocity of <c>0</c> is
        /// functionally equivalent to a **note off** message.
        /// </summary>
        /// <param name="note">
        /// The note(s) to stop. The notes can be
        /// specified by using a MIDI note number (<c>0</c> - <c>127</c>), a note identifier (e.g. <c>C3</c>, <c>G#4</c>, <c>F-1</c>,
        /// <c>Db7</c>) or an array of the previous types. When using a note identifier, octave range must be
        /// between <c>-1</c> and <c>9</c>. The lowest note is <c>C-1</c> (MIDI note number <c>0</c>) and the highest note is
        /// <c>G9</c> (MIDI note number <c>127</c>).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendNoteOn: note: Webmidi.Note * ?options: Output.sendNoteOn.options -> Webmidi.Output
        /// <summary>
        /// Sends a **note on** message for the specified MIDI note number on the specified channel(s). The
        /// first parameter is the number. It can be a single value or an array of the following valid
        /// values:
        ///
        ///  - A MIDI note number (integer between <c>0</c> and <c>127</c>)
        ///  - A note identifier (e.g. <c>"C3"</c>, <c>"G#4"</c>, <c>"F-1"</c>, <c>"Db7"</c>)
        ///  - A [<c>Note</c>](Note) object
        ///
        ///  The execution of the **note on** command can be delayed by using the <c>time</c> property of the
        /// <c>options</c> parameter.
        ///
        /// **Note**: As per the MIDI standard, a **note on** message with an attack velocity of <c>0</c> is
        /// functionally equivalent to a **note off** message.
        /// </summary>
        /// <param name="note">
        /// The note(s) to stop. The notes can be
        /// specified by using a MIDI note number (<c>0</c> - <c>127</c>), a note identifier (e.g. <c>C3</c>, <c>G#4</c>, <c>F-1</c>,
        /// <c>Db7</c>) or an array of the previous types. When using a note identifier, octave range must be
        /// between <c>-1</c> and <c>9</c>. The lowest note is <c>C-1</c> (MIDI note number <c>0</c>) and the highest note is
        /// <c>G9</c> (MIDI note number <c>127</c>).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendNoteOn: note: string * ?options: Output.sendNoteOn.options -> Webmidi.Output
        /// <summary>
        /// Sends a **note on** message for the specified MIDI note number on the specified channel(s). The
        /// first parameter is the number. It can be a single value or an array of the following valid
        /// values:
        ///
        ///  - A MIDI note number (integer between <c>0</c> and <c>127</c>)
        ///  - A note identifier (e.g. <c>"C3"</c>, <c>"G#4"</c>, <c>"F-1"</c>, <c>"Db7"</c>)
        ///  - A [<c>Note</c>](Note) object
        ///
        ///  The execution of the **note on** command can be delayed by using the <c>time</c> property of the
        /// <c>options</c> parameter.
        ///
        /// **Note**: As per the MIDI standard, a **note on** message with an attack velocity of <c>0</c> is
        /// functionally equivalent to a **note off** message.
        /// </summary>
        /// <param name="note">
        /// The note(s) to stop. The notes can be
        /// specified by using a MIDI note number (<c>0</c> - <c>127</c>), a note identifier (e.g. <c>C3</c>, <c>G#4</c>, <c>F-1</c>,
        /// <c>Db7</c>) or an array of the previous types. When using a note identifier, octave range must be
        /// between <c>-1</c> and <c>9</c>. The lowest note is <c>C-1</c> (MIDI note number <c>0</c>) and the highest note is
        /// <c>G9</c> (MIDI note number <c>127</c>).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendNoteOn: note: ResizeArray<float> * ?options: Output.sendNoteOn.options -> Webmidi.Output
        /// <summary>
        /// Sends a **note on** message for the specified MIDI note number on the specified channel(s). The
        /// first parameter is the number. It can be a single value or an array of the following valid
        /// values:
        ///
        ///  - A MIDI note number (integer between <c>0</c> and <c>127</c>)
        ///  - A note identifier (e.g. <c>"C3"</c>, <c>"G#4"</c>, <c>"F-1"</c>, <c>"Db7"</c>)
        ///  - A [<c>Note</c>](Note) object
        ///
        ///  The execution of the **note on** command can be delayed by using the <c>time</c> property of the
        /// <c>options</c> parameter.
        ///
        /// **Note**: As per the MIDI standard, a **note on** message with an attack velocity of <c>0</c> is
        /// functionally equivalent to a **note off** message.
        /// </summary>
        /// <param name="note">
        /// The note(s) to stop. The notes can be
        /// specified by using a MIDI note number (<c>0</c> - <c>127</c>), a note identifier (e.g. <c>C3</c>, <c>G#4</c>, <c>F-1</c>,
        /// <c>Db7</c>) or an array of the previous types. When using a note identifier, octave range must be
        /// between <c>-1</c> and <c>9</c>. The lowest note is <c>C-1</c> (MIDI note number <c>0</c>) and the highest note is
        /// <c>G9</c> (MIDI note number <c>127</c>).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendNoteOn: note: ResizeArray<Webmidi.Note> * ?options: Output.sendNoteOn.options -> Webmidi.Output
        /// <summary>
        /// Sends a **note on** message for the specified MIDI note number on the specified channel(s). The
        /// first parameter is the number. It can be a single value or an array of the following valid
        /// values:
        ///
        ///  - A MIDI note number (integer between <c>0</c> and <c>127</c>)
        ///  - A note identifier (e.g. <c>"C3"</c>, <c>"G#4"</c>, <c>"F-1"</c>, <c>"Db7"</c>)
        ///  - A [<c>Note</c>](Note) object
        ///
        ///  The execution of the **note on** command can be delayed by using the <c>time</c> property of the
        /// <c>options</c> parameter.
        ///
        /// **Note**: As per the MIDI standard, a **note on** message with an attack velocity of <c>0</c> is
        /// functionally equivalent to a **note off** message.
        /// </summary>
        /// <param name="note">
        /// The note(s) to stop. The notes can be
        /// specified by using a MIDI note number (<c>0</c> - <c>127</c>), a note identifier (e.g. <c>C3</c>, <c>G#4</c>, <c>F-1</c>,
        /// <c>Db7</c>) or an array of the previous types. When using a note identifier, octave range must be
        /// between <c>-1</c> and <c>9</c>. The lowest note is <c>C-1</c> (MIDI note number <c>0</c>) and the highest note is
        /// <c>G9</c> (MIDI note number <c>127</c>).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendNoteOn: note: ResizeArray<string> * ?options: Output.sendNoteOn.options -> Webmidi.Output
        /// <summary>
        /// Sends a **note on** message for the specified MIDI note number on the specified channel(s). The
        /// first parameter is the number. It can be a single value or an array of the following valid
        /// values:
        ///
        ///  - A MIDI note number (integer between <c>0</c> and <c>127</c>)
        ///  - A note identifier (e.g. <c>"C3"</c>, <c>"G#4"</c>, <c>"F-1"</c>, <c>"Db7"</c>)
        ///  - A [<c>Note</c>](Note) object
        ///
        ///  The execution of the **note on** command can be delayed by using the <c>time</c> property of the
        /// <c>options</c> parameter.
        ///
        /// **Note**: As per the MIDI standard, a **note on** message with an attack velocity of <c>0</c> is
        /// functionally equivalent to a **note off** message.
        /// </summary>
        /// <param name="note">
        /// The note(s) to stop. The notes can be
        /// specified by using a MIDI note number (<c>0</c> - <c>127</c>), a note identifier (e.g. <c>C3</c>, <c>G#4</c>, <c>F-1</c>,
        /// <c>Db7</c>) or an array of the previous types. When using a note identifier, octave range must be
        /// between <c>-1</c> and <c>9</c>. The lowest note is <c>C-1</c> (MIDI note number <c>0</c>) and the highest note is
        /// <c>G9</c> (MIDI note number <c>127</c>).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member sendNoteOn: note: U6<float, Webmidi.Note, string, ResizeArray<float>, ResizeArray<Webmidi.Note>, ResizeArray<string>> * ?options: Output.sendNoteOn.options -> Webmidi.Output
        /// <summary>
        /// Output port's connection state: <c>pending</c>, <c>open</c> or <c>closed</c>.
        /// </summary>
        abstract member connection: Webmidi.WebMidiApi_.MIDIPortConnectionState with get
        /// <summary>
        /// ID string of the MIDI output. The ID is host-specific. Do not expect the same ID on different
        /// platforms. For example, Google Chrome and the Jazz-Plugin report completely different IDs for
        /// the same port.
        /// </summary>
        abstract member id: string with get
        /// <summary>
        /// Name of the manufacturer of the device that makes this output port available.
        /// </summary>
        abstract member manufacturer: string with get
        /// <summary>
        /// Name of the MIDI output.
        /// </summary>
        abstract member name: string with get
        /// <summary>
        /// An integer to offset the octave of outgoing notes. By default, middle C (MIDI note number 60)
        /// is placed on the 4th octave (C4).
        ///
        /// Note that this value is combined with the global offset value defined in
        /// [<c>WebMidi.octaveOffset</c>](WebMidi#octaveOffset) (if any).
        /// </summary>
        abstract member octaveOffset: float with get, set
        /// <summary>
        /// State of the output port: <c>connected</c> or <c>disconnected</c>.
        /// </summary>
        abstract member state: Webmidi.WebMidiApi_.MIDIPortDeviceState with get
        /// <summary>
        /// Type of the output port (it will always be: <c>output</c>).
        /// </summary>
        abstract member ``type``: Webmidi.WebMidiApi_.MIDIPortType with get
        /// <summary>
        /// Identifier (Symbol) to use when adding or removing a listener that should be triggered when any
        /// events occur.
        /// </summary>
        static member inline ANY_EVENT
            with get () : obj =
                nativeOnly
        /// <summary>
        /// An object containing a property for each event with at least one registered listener. Each
        /// event property contains an array of all the [<c>Listener</c>]<see href="Listener">Listener</see> objects registered
        /// for the event.
        /// </summary>
        abstract member eventMap: obj with get, set
        /// <summary>
        /// Whether or not the execution of callbacks is currently suspended for this emitter.
        /// </summary>
        abstract member eventsSuspended: bool with get, set
        /// <summary>
        /// An array of all the unique event names for which the emitter has at least one registered
        /// listener.
        ///
        /// Note: this excludes global events registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> because they are not tied to a
        /// specific event.
        /// </summary>
        abstract member eventNames: ResizeArray<string> with get
        /// <summary>
        /// Returns an array of all the [<c>Listener</c>]<see href="Listener">Listener</see> objects that have been registered for
        /// a specific event.
        ///
        /// Please note that global events (those added with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>) are not returned for "regular"
        /// events. To get the list of global listeners, specifically use
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> as the parameter.
        /// </summary>
        /// <param name="event">
        /// The event to get listeners for.
        /// </param>
        /// <returns>
        /// An array of [<c>Listener</c>]<see href="Listener">Listener</see> objects.
        /// </returns>
        abstract member getListeners: event: string -> ResizeArray<Webmidi.Listener>
        /// <summary>
        /// Returns an array of all the [<c>Listener</c>]<see href="Listener">Listener</see> objects that have been registered for
        /// a specific event.
        ///
        /// Please note that global events (those added with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>) are not returned for "regular"
        /// events. To get the list of global listeners, specifically use
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> as the parameter.
        /// </summary>
        /// <param name="event">
        /// The event to get listeners for.
        /// </param>
        /// <returns>
        /// An array of [<c>Listener</c>]<see href="Listener">Listener</see> objects.
        /// </returns>
        abstract member getListeners: event: obj -> ResizeArray<Webmidi.Listener>
        /// <summary>
        /// Returns an array of all the [<c>Listener</c>]<see href="Listener">Listener</see> objects that have been registered for
        /// a specific event.
        ///
        /// Please note that global events (those added with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>) are not returned for "regular"
        /// events. To get the list of global listeners, specifically use
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> as the parameter.
        /// </summary>
        /// <param name="event">
        /// The event to get listeners for.
        /// </param>
        /// <returns>
        /// An array of [<c>Listener</c>]<see href="Listener">Listener</see> objects.
        /// </returns>
        abstract member getListeners: event: U2<string, obj> -> ResizeArray<Webmidi.Listener>
        /// <summary>
        /// Suspends execution of all callbacks functions registered for the specified event type.
        ///
        /// You can suspend execution of callbacks registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> by passing
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> to <c>suspendEvent()</c>. Beware that this
        /// will not suspend all callbacks but only those registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>. While this may seem counter-intuitive
        /// at first glance, it allows the selective suspension of global listeners while leaving other
        /// listeners alone. If you truly want to suspends all callbacks for a specific
        /// [<c>EventEmitter</c>]<see href="EventEmitter">EventEmitter</see>, simply set its <c>eventsSuspended</c> property to <c>true</c>.
        /// </summary>
        /// <param name="event">
        /// The event name (or <c>EventEmitter.ANY_EVENT</c>) for which to suspend
        /// execution of all callback functions.
        /// </param>
        abstract member suspendEvent: event: string -> unit
        /// <summary>
        /// Suspends execution of all callbacks functions registered for the specified event type.
        ///
        /// You can suspend execution of callbacks registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> by passing
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> to <c>suspendEvent()</c>. Beware that this
        /// will not suspend all callbacks but only those registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>. While this may seem counter-intuitive
        /// at first glance, it allows the selective suspension of global listeners while leaving other
        /// listeners alone. If you truly want to suspends all callbacks for a specific
        /// [<c>EventEmitter</c>]<see href="EventEmitter">EventEmitter</see>, simply set its <c>eventsSuspended</c> property to <c>true</c>.
        /// </summary>
        /// <param name="event">
        /// The event name (or <c>EventEmitter.ANY_EVENT</c>) for which to suspend
        /// execution of all callback functions.
        /// </param>
        abstract member suspendEvent: event: obj -> unit
        /// <summary>
        /// Suspends execution of all callbacks functions registered for the specified event type.
        ///
        /// You can suspend execution of callbacks registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> by passing
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> to <c>suspendEvent()</c>. Beware that this
        /// will not suspend all callbacks but only those registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>. While this may seem counter-intuitive
        /// at first glance, it allows the selective suspension of global listeners while leaving other
        /// listeners alone. If you truly want to suspends all callbacks for a specific
        /// [<c>EventEmitter</c>]<see href="EventEmitter">EventEmitter</see>, simply set its <c>eventsSuspended</c> property to <c>true</c>.
        /// </summary>
        /// <param name="event">
        /// The event name (or <c>EventEmitter.ANY_EVENT</c>) for which to suspend
        /// execution of all callback functions.
        /// </param>
        abstract member suspendEvent: event: U2<string, obj> -> unit
        /// <summary>
        /// Resumes execution of all suspended callback functions registered for the specified event type.
        ///
        /// You can resume execution of callbacks registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> by passing
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> to <c>unsuspendEvent()</c>. Beware that
        /// this will not resume all callbacks but only those registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>. While this may seem
        /// counter-intuitive, it allows the selective unsuspension of global listeners while leaving other
        /// callbacks alone.
        /// </summary>
        /// <param name="event">
        /// The event name (or <c>EventEmitter.ANY_EVENT</c>) for which to resume
        /// execution of all callback functions.
        /// </param>
        abstract member unsuspendEvent: event: string -> unit
        /// <summary>
        /// Resumes execution of all suspended callback functions registered for the specified event type.
        ///
        /// You can resume execution of callbacks registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> by passing
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> to <c>unsuspendEvent()</c>. Beware that
        /// this will not resume all callbacks but only those registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>. While this may seem
        /// counter-intuitive, it allows the selective unsuspension of global listeners while leaving other
        /// callbacks alone.
        /// </summary>
        /// <param name="event">
        /// The event name (or <c>EventEmitter.ANY_EVENT</c>) for which to resume
        /// execution of all callback functions.
        /// </param>
        abstract member unsuspendEvent: event: obj -> unit
        /// <summary>
        /// Resumes execution of all suspended callback functions registered for the specified event type.
        ///
        /// You can resume execution of callbacks registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> by passing
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> to <c>unsuspendEvent()</c>. Beware that
        /// this will not resume all callbacks but only those registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>. While this may seem
        /// counter-intuitive, it allows the selective unsuspension of global listeners while leaving other
        /// callbacks alone.
        /// </summary>
        /// <param name="event">
        /// The event name (or <c>EventEmitter.ANY_EVENT</c>) for which to resume
        /// execution of all callback functions.
        /// </param>
        abstract member unsuspendEvent: event: U2<string, obj> -> unit
        /// <summary>
        /// Returns the number of listeners registered for a specific event.
        ///
        /// Please note that global events (those added with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>) do not count towards the remaining
        /// number for a "regular" event. To get the number of global listeners, specifically use
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> as the parameter.
        /// </summary>
        /// <param name="event">
        /// The event which is usually a string but can also be the special
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> symbol.
        /// </param>
        /// <returns>
        /// An integer representing the number of listeners registered for the specified
        /// event.
        /// </returns>
        abstract member getListenerCount: event: string -> float
        /// <summary>
        /// Returns the number of listeners registered for a specific event.
        ///
        /// Please note that global events (those added with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>) do not count towards the remaining
        /// number for a "regular" event. To get the number of global listeners, specifically use
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> as the parameter.
        /// </summary>
        /// <param name="event">
        /// The event which is usually a string but can also be the special
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> symbol.
        /// </param>
        /// <returns>
        /// An integer representing the number of listeners registered for the specified
        /// event.
        /// </returns>
        abstract member getListenerCount: event: obj -> float
        /// <summary>
        /// Returns the number of listeners registered for a specific event.
        ///
        /// Please note that global events (those added with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>) do not count towards the remaining
        /// number for a "regular" event. To get the number of global listeners, specifically use
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> as the parameter.
        /// </summary>
        /// <param name="event">
        /// The event which is usually a string but can also be the special
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> symbol.
        /// </param>
        /// <returns>
        /// An integer representing the number of listeners registered for the specified
        /// event.
        /// </returns>
        abstract member getListenerCount: event: U2<string, obj> -> float
        /// <summary>
        /// Executes the callback function of all the [<c>Listener</c>]<see href="Listener">Listener</see> objects registered for
        /// a given event. The callback functions are passed the additional arguments passed to <c>emit()</c>
        /// (if any) followed by the arguments present in the [<c>arguments</c>](Listener#arguments) property of
        /// the [<c>Listener</c>](Listener) object (if any).
        ///
        /// If the [<c>eventsSuspended</c>]<see href="#eventsSuspended">#eventsSuspended</see> property is <c>true</c> or the
        /// [<c>Listener.suspended</c>]<see href="Listener#suspended">Listener#suspended</see> property is <c>true</c>, the callback functions
        /// will not be executed.
        ///
        /// This function returns an array containing the return values of each of the callbacks.
        ///
        /// It should be noted that the regular listeners are triggered first followed by the global
        /// listeners (those added with [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>).
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// The <c>event</c> parameter must be a string.
        /// </remarks>
        /// <param name="event">
        /// The event
        /// </param>
        /// <param name="args">
        /// Arbitrary number of arguments to pass along to the callback functions
        /// </param>
        /// <returns>
        /// An array containing the return value of each of the executed listener
        /// functions.
        /// </returns>
        abstract member emit: event: string * [<ParamArray>] args: obj [] -> ResizeArray<obj>
        /// <summary>
        /// The <c>waitFor()</c> method is an async function which returns a promise. The promise is fulfilled
        /// when the specified event occurs. The event can be a regular event or
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> (if you want to resolve as soon as any
        /// event is emitted).
        ///
        /// If the <c>duration</c> option is set, the promise will only be fulfilled if the event is emitted
        /// within the specified duration. If the event has not been fulfilled after the specified
        /// duration, the promise is rejected. This makes it super easy to wait for an event and timeout
        /// after a certain time if the event is not triggered.
        /// </summary>
        /// <param name="event">
        /// The event to wait for
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        abstract member waitFor: event: string * ?options: EventEmitter.waitFor.options -> JS.Promise<obj>
        /// <summary>
        /// The <c>waitFor()</c> method is an async function which returns a promise. The promise is fulfilled
        /// when the specified event occurs. The event can be a regular event or
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> (if you want to resolve as soon as any
        /// event is emitted).
        ///
        /// If the <c>duration</c> option is set, the promise will only be fulfilled if the event is emitted
        /// within the specified duration. If the event has not been fulfilled after the specified
        /// duration, the promise is rejected. This makes it super easy to wait for an event and timeout
        /// after a certain time if the event is not triggered.
        /// </summary>
        /// <param name="event">
        /// The event to wait for
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        abstract member waitFor: event: obj * ?options: EventEmitter.waitFor.options -> JS.Promise<obj>
        /// <summary>
        /// The <c>waitFor()</c> method is an async function which returns a promise. The promise is fulfilled
        /// when the specified event occurs. The event can be a regular event or
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> (if you want to resolve as soon as any
        /// event is emitted).
        ///
        /// If the <c>duration</c> option is set, the promise will only be fulfilled if the event is emitted
        /// within the specified duration. If the event has not been fulfilled after the specified
        /// duration, the promise is rejected. This makes it super easy to wait for an event and timeout
        /// after a certain time if the event is not triggered.
        /// </summary>
        /// <param name="event">
        /// The event to wait for
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        abstract member waitFor: event: U2<string, obj> * ?options: EventEmitter.waitFor.options -> JS.Promise<obj>
        /// <summary>
        /// The number of unique events that have registered listeners.
        ///
        /// Note: this excludes global events registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> because they are not tied to a
        /// specific event.
        /// </summary>
        abstract member eventCount: float with get

    /// <summary>
    /// The <c>OutputChannel</c> class represents a single output MIDI channel. <c>OutputChannel</c> objects are
    /// provided by an [<c>Output</c>](Output) port which, itself, is made available by a device. The
    /// <c>OutputChannel</c> object is derived from the host's MIDI subsystem and should not be instantiated
    /// directly.
    ///
    /// All 16 <c>OutputChannel</c> objects can be found inside the parent output's
    /// [<c>channels</c>]<see href="Output#channels">Output#channels</see> property.
    /// </summary>
    /// <param name="output">
    /// The [<c>Output</c>](Output) this channel belongs to.
    /// </param>
    /// <param name="number">
    /// The MIDI channel number (<c>1</c> - <c>16</c>).
    /// </param>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("OutputChannel", "webmidi")>]
    type OutputChannel =
        inherit Webmidi.EventEmitter
        /// <summary>
        /// Sends a MIDI message on the MIDI output port. If no time is specified, the message will be
        /// sent immediately. The message should be an array of 8-bit unsigned integers (<c>0</c> - <c>225</c>),
        /// a
        /// [<c>Uint8Array</c>]<see href="https://developer.mozilla.org/docs/Web/JavaScript/Reference/Global_Objects/Uint8Array">https://developer.mozilla.org/docs/Web/JavaScript/Reference/Global_Objects/Uint8Array</see>
        /// object or a [<c>Message</c>](Message) object.
        ///
        /// It is usually not necessary to use this method directly as you can use one of the simpler
        /// helper methods such as [<c>playNote()</c>](#playNote), [<c>stopNote()</c>](#stopNote),
        /// [<c>sendControlChange()</c>](#sendControlChange), etc.
        ///
        /// Details on the format of MIDI messages are available in the summary of
        /// [MIDI messages]<see href="https://www.midi.org/specifications-old/item/table-1-summary-of-midi-message">https://www.midi.org/specifications-old/item/table-1-summary-of-midi-message</see>
        /// from the MIDI Manufacturers Association.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// The first byte (status) must be an integer between 128 and 255.
        ///
        /// Data bytes must be integers between 0 and 255.
        /// </remarks>
        /// <param name="message">
        /// A <c>Message</c> object, an array of 8-bit unsigned
        /// integers or a <c>Uint8Array</c> object (not available in Node.js) containing the message bytes.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member send: message: ResizeArray<float> * ?options: OutputChannel.send.options -> Webmidi.OutputChannel
        /// <summary>
        /// Sends a MIDI message on the MIDI output port. If no time is specified, the message will be
        /// sent immediately. The message should be an array of 8-bit unsigned integers (<c>0</c> - <c>225</c>),
        /// a
        /// [<c>Uint8Array</c>]<see href="https://developer.mozilla.org/docs/Web/JavaScript/Reference/Global_Objects/Uint8Array">https://developer.mozilla.org/docs/Web/JavaScript/Reference/Global_Objects/Uint8Array</see>
        /// object or a [<c>Message</c>](Message) object.
        ///
        /// It is usually not necessary to use this method directly as you can use one of the simpler
        /// helper methods such as [<c>playNote()</c>](#playNote), [<c>stopNote()</c>](#stopNote),
        /// [<c>sendControlChange()</c>](#sendControlChange), etc.
        ///
        /// Details on the format of MIDI messages are available in the summary of
        /// [MIDI messages]<see href="https://www.midi.org/specifications-old/item/table-1-summary-of-midi-message">https://www.midi.org/specifications-old/item/table-1-summary-of-midi-message</see>
        /// from the MIDI Manufacturers Association.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// The first byte (status) must be an integer between 128 and 255.
        ///
        /// Data bytes must be integers between 0 and 255.
        /// </remarks>
        /// <param name="message">
        /// A <c>Message</c> object, an array of 8-bit unsigned
        /// integers or a <c>Uint8Array</c> object (not available in Node.js) containing the message bytes.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member send: message: JS.Uint8Array * ?options: OutputChannel.send.options -> Webmidi.OutputChannel
        /// <summary>
        /// Sends a MIDI message on the MIDI output port. If no time is specified, the message will be
        /// sent immediately. The message should be an array of 8-bit unsigned integers (<c>0</c> - <c>225</c>),
        /// a
        /// [<c>Uint8Array</c>]<see href="https://developer.mozilla.org/docs/Web/JavaScript/Reference/Global_Objects/Uint8Array">https://developer.mozilla.org/docs/Web/JavaScript/Reference/Global_Objects/Uint8Array</see>
        /// object or a [<c>Message</c>](Message) object.
        ///
        /// It is usually not necessary to use this method directly as you can use one of the simpler
        /// helper methods such as [<c>playNote()</c>](#playNote), [<c>stopNote()</c>](#stopNote),
        /// [<c>sendControlChange()</c>](#sendControlChange), etc.
        ///
        /// Details on the format of MIDI messages are available in the summary of
        /// [MIDI messages]<see href="https://www.midi.org/specifications-old/item/table-1-summary-of-midi-message">https://www.midi.org/specifications-old/item/table-1-summary-of-midi-message</see>
        /// from the MIDI Manufacturers Association.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// The first byte (status) must be an integer between 128 and 255.
        ///
        /// Data bytes must be integers between 0 and 255.
        /// </remarks>
        /// <param name="message">
        /// A <c>Message</c> object, an array of 8-bit unsigned
        /// integers or a <c>Uint8Array</c> object (not available in Node.js) containing the message bytes.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member send: message: Webmidi.Message * ?options: OutputChannel.send.options -> Webmidi.OutputChannel
        /// <summary>
        /// Sends a MIDI message on the MIDI output port. If no time is specified, the message will be
        /// sent immediately. The message should be an array of 8-bit unsigned integers (<c>0</c> - <c>225</c>),
        /// a
        /// [<c>Uint8Array</c>]<see href="https://developer.mozilla.org/docs/Web/JavaScript/Reference/Global_Objects/Uint8Array">https://developer.mozilla.org/docs/Web/JavaScript/Reference/Global_Objects/Uint8Array</see>
        /// object or a [<c>Message</c>](Message) object.
        ///
        /// It is usually not necessary to use this method directly as you can use one of the simpler
        /// helper methods such as [<c>playNote()</c>](#playNote), [<c>stopNote()</c>](#stopNote),
        /// [<c>sendControlChange()</c>](#sendControlChange), etc.
        ///
        /// Details on the format of MIDI messages are available in the summary of
        /// [MIDI messages]<see href="https://www.midi.org/specifications-old/item/table-1-summary-of-midi-message">https://www.midi.org/specifications-old/item/table-1-summary-of-midi-message</see>
        /// from the MIDI Manufacturers Association.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// The first byte (status) must be an integer between 128 and 255.
        ///
        /// Data bytes must be integers between 0 and 255.
        /// </remarks>
        /// <param name="message">
        /// A <c>Message</c> object, an array of 8-bit unsigned
        /// integers or a <c>Uint8Array</c> object (not available in Node.js) containing the message bytes.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member send: message: U3<ResizeArray<float>, JS.Uint8Array, Webmidi.Message> * ?options: OutputChannel.send.options -> Webmidi.OutputChannel
        /// <summary>
        /// Sends a MIDI **key aftertouch** message at the scheduled time. This is a key-specific
        /// aftertouch. For a channel-wide aftertouch message, use
        /// [<c>sendChannelAftertouch()</c>]<see href="#sendChannelAftertouch">#sendChannelAftertouch</see>.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// RangeError Invalid key aftertouch value.
        /// </remarks>
        /// <param name="target">
        /// The note(s) for which you are sending
        /// an aftertouch value. The notes can be specified by using a MIDI note number (<c>0</c> - <c>127</c>), a
        /// [<c>Note</c>](Note) object, a note identifier (e.g. <c>C3</c>, <c>G#4</c>, <c>F-1</c>, <c>Db7</c>) or an array of the
        /// previous types. When using a note identifier, octave range must be between <c>-1</c> and <c>9</c>. The
        /// lowest note is <c>C-1</c> (MIDI note number <c>0</c>) and the highest note is <c>G9</c> (MIDI note number
        /// <c>127</c>).
        ///
        /// When using a note identifier, the octave value will be offset by the local
        /// [<c>octaveOffset</c>](#octaveOffset) and by
        /// [<c>Output.octaveOffset</c>](Output#octaveOffset) and [<c>WebMidi.octaveOffset</c>](WebMidi#octaveOffset)
        /// (if those values are not <c>0</c>). When using a key number, <c>octaveOffset</c> values are ignored.
        /// </param>
        /// <param name="pressure">
        /// The pressure level (between <c>0</c> and <c>1</c>). An invalid pressure
        /// value will silently trigger the default behaviour. If the <c>rawValue</c> option is set to <c>true</c>,
        /// the pressure is defined by using an integer between <c>0</c> and <c>127</c>.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member sendKeyAftertouch: target: float * ?pressure: float * ?options: OutputChannel.sendKeyAftertouch.options -> Webmidi.OutputChannel
        /// <summary>
        /// Sends a MIDI **key aftertouch** message at the scheduled time. This is a key-specific
        /// aftertouch. For a channel-wide aftertouch message, use
        /// [<c>sendChannelAftertouch()</c>]<see href="#sendChannelAftertouch">#sendChannelAftertouch</see>.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// RangeError Invalid key aftertouch value.
        /// </remarks>
        /// <param name="target">
        /// The note(s) for which you are sending
        /// an aftertouch value. The notes can be specified by using a MIDI note number (<c>0</c> - <c>127</c>), a
        /// [<c>Note</c>](Note) object, a note identifier (e.g. <c>C3</c>, <c>G#4</c>, <c>F-1</c>, <c>Db7</c>) or an array of the
        /// previous types. When using a note identifier, octave range must be between <c>-1</c> and <c>9</c>. The
        /// lowest note is <c>C-1</c> (MIDI note number <c>0</c>) and the highest note is <c>G9</c> (MIDI note number
        /// <c>127</c>).
        ///
        /// When using a note identifier, the octave value will be offset by the local
        /// [<c>octaveOffset</c>](#octaveOffset) and by
        /// [<c>Output.octaveOffset</c>](Output#octaveOffset) and [<c>WebMidi.octaveOffset</c>](WebMidi#octaveOffset)
        /// (if those values are not <c>0</c>). When using a key number, <c>octaveOffset</c> values are ignored.
        /// </param>
        /// <param name="pressure">
        /// The pressure level (between <c>0</c> and <c>1</c>). An invalid pressure
        /// value will silently trigger the default behaviour. If the <c>rawValue</c> option is set to <c>true</c>,
        /// the pressure is defined by using an integer between <c>0</c> and <c>127</c>.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member sendKeyAftertouch: target: Webmidi.Note * ?pressure: float * ?options: OutputChannel.sendKeyAftertouch.options -> Webmidi.OutputChannel
        /// <summary>
        /// Sends a MIDI **key aftertouch** message at the scheduled time. This is a key-specific
        /// aftertouch. For a channel-wide aftertouch message, use
        /// [<c>sendChannelAftertouch()</c>]<see href="#sendChannelAftertouch">#sendChannelAftertouch</see>.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// RangeError Invalid key aftertouch value.
        /// </remarks>
        /// <param name="target">
        /// The note(s) for which you are sending
        /// an aftertouch value. The notes can be specified by using a MIDI note number (<c>0</c> - <c>127</c>), a
        /// [<c>Note</c>](Note) object, a note identifier (e.g. <c>C3</c>, <c>G#4</c>, <c>F-1</c>, <c>Db7</c>) or an array of the
        /// previous types. When using a note identifier, octave range must be between <c>-1</c> and <c>9</c>. The
        /// lowest note is <c>C-1</c> (MIDI note number <c>0</c>) and the highest note is <c>G9</c> (MIDI note number
        /// <c>127</c>).
        ///
        /// When using a note identifier, the octave value will be offset by the local
        /// [<c>octaveOffset</c>](#octaveOffset) and by
        /// [<c>Output.octaveOffset</c>](Output#octaveOffset) and [<c>WebMidi.octaveOffset</c>](WebMidi#octaveOffset)
        /// (if those values are not <c>0</c>). When using a key number, <c>octaveOffset</c> values are ignored.
        /// </param>
        /// <param name="pressure">
        /// The pressure level (between <c>0</c> and <c>1</c>). An invalid pressure
        /// value will silently trigger the default behaviour. If the <c>rawValue</c> option is set to <c>true</c>,
        /// the pressure is defined by using an integer between <c>0</c> and <c>127</c>.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member sendKeyAftertouch: target: string * ?pressure: float * ?options: OutputChannel.sendKeyAftertouch.options -> Webmidi.OutputChannel
        /// <summary>
        /// Sends a MIDI **key aftertouch** message at the scheduled time. This is a key-specific
        /// aftertouch. For a channel-wide aftertouch message, use
        /// [<c>sendChannelAftertouch()</c>]<see href="#sendChannelAftertouch">#sendChannelAftertouch</see>.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// RangeError Invalid key aftertouch value.
        /// </remarks>
        /// <param name="target">
        /// The note(s) for which you are sending
        /// an aftertouch value. The notes can be specified by using a MIDI note number (<c>0</c> - <c>127</c>), a
        /// [<c>Note</c>](Note) object, a note identifier (e.g. <c>C3</c>, <c>G#4</c>, <c>F-1</c>, <c>Db7</c>) or an array of the
        /// previous types. When using a note identifier, octave range must be between <c>-1</c> and <c>9</c>. The
        /// lowest note is <c>C-1</c> (MIDI note number <c>0</c>) and the highest note is <c>G9</c> (MIDI note number
        /// <c>127</c>).
        ///
        /// When using a note identifier, the octave value will be offset by the local
        /// [<c>octaveOffset</c>](#octaveOffset) and by
        /// [<c>Output.octaveOffset</c>](Output#octaveOffset) and [<c>WebMidi.octaveOffset</c>](WebMidi#octaveOffset)
        /// (if those values are not <c>0</c>). When using a key number, <c>octaveOffset</c> values are ignored.
        /// </param>
        /// <param name="pressure">
        /// The pressure level (between <c>0</c> and <c>1</c>). An invalid pressure
        /// value will silently trigger the default behaviour. If the <c>rawValue</c> option is set to <c>true</c>,
        /// the pressure is defined by using an integer between <c>0</c> and <c>127</c>.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member sendKeyAftertouch: target: ResizeArray<float> * ?pressure: float * ?options: OutputChannel.sendKeyAftertouch.options -> Webmidi.OutputChannel
        /// <summary>
        /// Sends a MIDI **key aftertouch** message at the scheduled time. This is a key-specific
        /// aftertouch. For a channel-wide aftertouch message, use
        /// [<c>sendChannelAftertouch()</c>]<see href="#sendChannelAftertouch">#sendChannelAftertouch</see>.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// RangeError Invalid key aftertouch value.
        /// </remarks>
        /// <param name="target">
        /// The note(s) for which you are sending
        /// an aftertouch value. The notes can be specified by using a MIDI note number (<c>0</c> - <c>127</c>), a
        /// [<c>Note</c>](Note) object, a note identifier (e.g. <c>C3</c>, <c>G#4</c>, <c>F-1</c>, <c>Db7</c>) or an array of the
        /// previous types. When using a note identifier, octave range must be between <c>-1</c> and <c>9</c>. The
        /// lowest note is <c>C-1</c> (MIDI note number <c>0</c>) and the highest note is <c>G9</c> (MIDI note number
        /// <c>127</c>).
        ///
        /// When using a note identifier, the octave value will be offset by the local
        /// [<c>octaveOffset</c>](#octaveOffset) and by
        /// [<c>Output.octaveOffset</c>](Output#octaveOffset) and [<c>WebMidi.octaveOffset</c>](WebMidi#octaveOffset)
        /// (if those values are not <c>0</c>). When using a key number, <c>octaveOffset</c> values are ignored.
        /// </param>
        /// <param name="pressure">
        /// The pressure level (between <c>0</c> and <c>1</c>). An invalid pressure
        /// value will silently trigger the default behaviour. If the <c>rawValue</c> option is set to <c>true</c>,
        /// the pressure is defined by using an integer between <c>0</c> and <c>127</c>.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member sendKeyAftertouch: target: ResizeArray<Webmidi.Note> * ?pressure: float * ?options: OutputChannel.sendKeyAftertouch.options -> Webmidi.OutputChannel
        /// <summary>
        /// Sends a MIDI **key aftertouch** message at the scheduled time. This is a key-specific
        /// aftertouch. For a channel-wide aftertouch message, use
        /// [<c>sendChannelAftertouch()</c>]<see href="#sendChannelAftertouch">#sendChannelAftertouch</see>.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// RangeError Invalid key aftertouch value.
        /// </remarks>
        /// <param name="target">
        /// The note(s) for which you are sending
        /// an aftertouch value. The notes can be specified by using a MIDI note number (<c>0</c> - <c>127</c>), a
        /// [<c>Note</c>](Note) object, a note identifier (e.g. <c>C3</c>, <c>G#4</c>, <c>F-1</c>, <c>Db7</c>) or an array of the
        /// previous types. When using a note identifier, octave range must be between <c>-1</c> and <c>9</c>. The
        /// lowest note is <c>C-1</c> (MIDI note number <c>0</c>) and the highest note is <c>G9</c> (MIDI note number
        /// <c>127</c>).
        ///
        /// When using a note identifier, the octave value will be offset by the local
        /// [<c>octaveOffset</c>](#octaveOffset) and by
        /// [<c>Output.octaveOffset</c>](Output#octaveOffset) and [<c>WebMidi.octaveOffset</c>](WebMidi#octaveOffset)
        /// (if those values are not <c>0</c>). When using a key number, <c>octaveOffset</c> values are ignored.
        /// </param>
        /// <param name="pressure">
        /// The pressure level (between <c>0</c> and <c>1</c>). An invalid pressure
        /// value will silently trigger the default behaviour. If the <c>rawValue</c> option is set to <c>true</c>,
        /// the pressure is defined by using an integer between <c>0</c> and <c>127</c>.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member sendKeyAftertouch: target: ResizeArray<string> * ?pressure: float * ?options: OutputChannel.sendKeyAftertouch.options -> Webmidi.OutputChannel
        /// <summary>
        /// Sends a MIDI **key aftertouch** message at the scheduled time. This is a key-specific
        /// aftertouch. For a channel-wide aftertouch message, use
        /// [<c>sendChannelAftertouch()</c>]<see href="#sendChannelAftertouch">#sendChannelAftertouch</see>.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// RangeError Invalid key aftertouch value.
        /// </remarks>
        /// <param name="target">
        /// The note(s) for which you are sending
        /// an aftertouch value. The notes can be specified by using a MIDI note number (<c>0</c> - <c>127</c>), a
        /// [<c>Note</c>](Note) object, a note identifier (e.g. <c>C3</c>, <c>G#4</c>, <c>F-1</c>, <c>Db7</c>) or an array of the
        /// previous types. When using a note identifier, octave range must be between <c>-1</c> and <c>9</c>. The
        /// lowest note is <c>C-1</c> (MIDI note number <c>0</c>) and the highest note is <c>G9</c> (MIDI note number
        /// <c>127</c>).
        ///
        /// When using a note identifier, the octave value will be offset by the local
        /// [<c>octaveOffset</c>](#octaveOffset) and by
        /// [<c>Output.octaveOffset</c>](Output#octaveOffset) and [<c>WebMidi.octaveOffset</c>](WebMidi#octaveOffset)
        /// (if those values are not <c>0</c>). When using a key number, <c>octaveOffset</c> values are ignored.
        /// </param>
        /// <param name="pressure">
        /// The pressure level (between <c>0</c> and <c>1</c>). An invalid pressure
        /// value will silently trigger the default behaviour. If the <c>rawValue</c> option is set to <c>true</c>,
        /// the pressure is defined by using an integer between <c>0</c> and <c>127</c>.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member sendKeyAftertouch: target: U6<float, Webmidi.Note, string, ResizeArray<float>, ResizeArray<Webmidi.Note>, ResizeArray<string>> * ?pressure: float * ?options: OutputChannel.sendKeyAftertouch.options -> Webmidi.OutputChannel
        /// <summary>
        /// Sends a MIDI **control change** message to the channel at the scheduled time. The control
        /// change message to send can be specified numerically (<c>0</c> to <c>127</c>) or by using one of the
        /// following common names:
        ///
        /// | Number | Name                          |
        /// |--------|-------------------------------|
        /// | 0      |<c>bankselectcoarse</c>             |
        /// | 1      |<c>modulationwheelcoarse</c>        |
        /// | 2      |<c>breathcontrollercoarse</c>       |
        /// | 4      |<c>footcontrollercoarse</c>         |
        /// | 5      |<c>portamentotimecoarse</c>         |
        /// | 6      |<c>dataentrycoarse</c>              |
        /// | 7      |<c>volumecoarse</c>                 |
        /// | 8      |<c>balancecoarse</c>                |
        /// | 10     |<c>pancoarse</c>                    |
        /// | 11     |<c>expressioncoarse</c>             |
        /// | 12     |<c>effectcontrol1coarse</c>         |
        /// | 13     |<c>effectcontrol2coarse</c>         |
        /// | 18     |<c>generalpurposeslider3</c>        |
        /// | 19     |<c>generalpurposeslider4</c>        |
        /// | 32     |<c>bankselectfine</c>               |
        /// | 33     |<c>modulationwheelfine</c>          |
        /// | 34     |<c>breathcontrollerfine</c>         |
        /// | 36     |<c>footcontrollerfine</c>           |
        /// | 37     |<c>portamentotimefine</c>           |
        /// | 38     |<c>dataentryfine</c>                |
        /// | 39     |<c>volumefine</c>                   |
        /// | 40     |<c>balancefine</c>                  |
        /// | 42     |<c>panfine</c>                      |
        /// | 43     |<c>expressionfine</c>               |
        /// | 44     |<c>effectcontrol1fine</c>           |
        /// | 45     |<c>effectcontrol2fine</c>           |
        /// | 64     |<c>holdpedal</c>                    |
        /// | 65     |<c>portamento</c>                   |
        /// | 66     |<c>sustenutopedal</c>               |
        /// | 67     |<c>softpedal</c>                    |
        /// | 68     |<c>legatopedal</c>                  |
        /// | 69     |<c>hold2pedal</c>                   |
        /// | 70     |<c>soundvariation</c>               |
        /// | 71     |<c>resonance</c>                    |
        /// | 72     |<c>soundreleasetime</c>             |
        /// | 73     |<c>soundattacktime</c>              |
        /// | 74     |<c>brightness</c>                   |
        /// | 75     |<c>soundcontrol6</c>                |
        /// | 76     |<c>soundcontrol7</c>                |
        /// | 77     |<c>soundcontrol8</c>                |
        /// | 78     |<c>soundcontrol9</c>                |
        /// | 79     |<c>soundcontrol10</c>               |
        /// | 80     |<c>generalpurposebutton1</c>        |
        /// | 81     |<c>generalpurposebutton2</c>        |
        /// | 82     |<c>generalpurposebutton3</c>        |
        /// | 83     |<c>generalpurposebutton4</c>        |
        /// | 91     |<c>reverblevel</c>                  |
        /// | 92     |<c>tremololevel</c>                 |
        /// | 93     |<c>choruslevel</c>                  |
        /// | 94     |<c>celestelevel</c>                 |
        /// | 95     |<c>phaserlevel</c>                  |
        /// | 96     |<c>dataincrement</c>          |
        /// | 97     |<c>datadecrement</c>          |
        /// | 98     |<c>nonregisteredparametercoarse</c> |
        /// | 99     |<c>nonregisteredparameterfine</c>   |
        /// | 100    |<c>registeredparametercoarse</c>    |
        /// | 101    |<c>registeredparameterfine</c>      |
        /// | 120    |<c>allsoundoff</c>                  |
        /// | 121    |<c>resetallcontrollers</c>          |
        /// | 122    |<c>localcontrol</c>                 |
        /// | 123    |<c>allnotesoff</c>                  |
        /// | 124    |<c>omnimodeoff</c>                  |
        /// | 125    |<c>omnimodeon</c>                   |
        /// | 126    |<c>monomodeon</c>                   |
        /// | 127    |<c>polymodeon</c>                   |
        ///
        /// As you can see above, not all control change message have a matching name. This does not mean
        /// you cannot use the others. It simply means you will need to use their number
        /// (<c>0</c> to <c>127</c>) instead of their name. While you can still use them, numbers <c>120</c> to <c>127</c> are
        /// usually reserved for *channel mode* messages. See
        /// [<c>sendChannelMode()</c>]<see href="OutputChannel#sendChannelMode">OutputChannel#sendChannelMode</see> method for more info.
        ///
        /// To view a detailed list of all available **control change** messages, please consult "Table 3 -
        /// Control Change Messages" from the [MIDI Messages](
        /// https://www.midi.org/specifications/item/table-3-control-change-messages-data-bytes-2)
        /// specification.
        ///
        /// **Note**: messages #0-31 (MSB) are paired with messages #32-63 (LSB). For example, message #1
        /// (<c>modulationwheelcoarse</c>) can be accompanied by a second control change message for
        /// <c>modulationwheelfine</c> to achieve a greater level of precision. if you want to specify both MSB
        /// and LSB for messages between <c>0</c> and <c>31</c>, you can do so by passing a 2-value array as the
        /// second parameter.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// Controller numbers must be between 0 and 127.
        ///
        /// Invalid controller name.
        ///
        /// The value array must have a length of 2.
        /// </remarks>
        /// <param name="controller">
        /// The MIDI controller name or number (<c>0</c> - <c>127</c>).
        /// </param>
        /// <param name="value">
        /// The value to send (0-127). You can also use a two-position array
        /// for controllers 0 to 31. In this scenario, the first value will be sent as usual and the second
        /// value will be sent to the matching LSB controller (which is obtained by adding 32 to the first
        /// controller)
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member sendControlChange: controller: float * value: float * ?options: OutputChannel.sendControlChange.options -> Webmidi.OutputChannel
        /// <summary>
        /// Sends a MIDI **control change** message to the channel at the scheduled time. The control
        /// change message to send can be specified numerically (<c>0</c> to <c>127</c>) or by using one of the
        /// following common names:
        ///
        /// | Number | Name                          |
        /// |--------|-------------------------------|
        /// | 0      |<c>bankselectcoarse</c>             |
        /// | 1      |<c>modulationwheelcoarse</c>        |
        /// | 2      |<c>breathcontrollercoarse</c>       |
        /// | 4      |<c>footcontrollercoarse</c>         |
        /// | 5      |<c>portamentotimecoarse</c>         |
        /// | 6      |<c>dataentrycoarse</c>              |
        /// | 7      |<c>volumecoarse</c>                 |
        /// | 8      |<c>balancecoarse</c>                |
        /// | 10     |<c>pancoarse</c>                    |
        /// | 11     |<c>expressioncoarse</c>             |
        /// | 12     |<c>effectcontrol1coarse</c>         |
        /// | 13     |<c>effectcontrol2coarse</c>         |
        /// | 18     |<c>generalpurposeslider3</c>        |
        /// | 19     |<c>generalpurposeslider4</c>        |
        /// | 32     |<c>bankselectfine</c>               |
        /// | 33     |<c>modulationwheelfine</c>          |
        /// | 34     |<c>breathcontrollerfine</c>         |
        /// | 36     |<c>footcontrollerfine</c>           |
        /// | 37     |<c>portamentotimefine</c>           |
        /// | 38     |<c>dataentryfine</c>                |
        /// | 39     |<c>volumefine</c>                   |
        /// | 40     |<c>balancefine</c>                  |
        /// | 42     |<c>panfine</c>                      |
        /// | 43     |<c>expressionfine</c>               |
        /// | 44     |<c>effectcontrol1fine</c>           |
        /// | 45     |<c>effectcontrol2fine</c>           |
        /// | 64     |<c>holdpedal</c>                    |
        /// | 65     |<c>portamento</c>                   |
        /// | 66     |<c>sustenutopedal</c>               |
        /// | 67     |<c>softpedal</c>                    |
        /// | 68     |<c>legatopedal</c>                  |
        /// | 69     |<c>hold2pedal</c>                   |
        /// | 70     |<c>soundvariation</c>               |
        /// | 71     |<c>resonance</c>                    |
        /// | 72     |<c>soundreleasetime</c>             |
        /// | 73     |<c>soundattacktime</c>              |
        /// | 74     |<c>brightness</c>                   |
        /// | 75     |<c>soundcontrol6</c>                |
        /// | 76     |<c>soundcontrol7</c>                |
        /// | 77     |<c>soundcontrol8</c>                |
        /// | 78     |<c>soundcontrol9</c>                |
        /// | 79     |<c>soundcontrol10</c>               |
        /// | 80     |<c>generalpurposebutton1</c>        |
        /// | 81     |<c>generalpurposebutton2</c>        |
        /// | 82     |<c>generalpurposebutton3</c>        |
        /// | 83     |<c>generalpurposebutton4</c>        |
        /// | 91     |<c>reverblevel</c>                  |
        /// | 92     |<c>tremololevel</c>                 |
        /// | 93     |<c>choruslevel</c>                  |
        /// | 94     |<c>celestelevel</c>                 |
        /// | 95     |<c>phaserlevel</c>                  |
        /// | 96     |<c>dataincrement</c>          |
        /// | 97     |<c>datadecrement</c>          |
        /// | 98     |<c>nonregisteredparametercoarse</c> |
        /// | 99     |<c>nonregisteredparameterfine</c>   |
        /// | 100    |<c>registeredparametercoarse</c>    |
        /// | 101    |<c>registeredparameterfine</c>      |
        /// | 120    |<c>allsoundoff</c>                  |
        /// | 121    |<c>resetallcontrollers</c>          |
        /// | 122    |<c>localcontrol</c>                 |
        /// | 123    |<c>allnotesoff</c>                  |
        /// | 124    |<c>omnimodeoff</c>                  |
        /// | 125    |<c>omnimodeon</c>                   |
        /// | 126    |<c>monomodeon</c>                   |
        /// | 127    |<c>polymodeon</c>                   |
        ///
        /// As you can see above, not all control change message have a matching name. This does not mean
        /// you cannot use the others. It simply means you will need to use their number
        /// (<c>0</c> to <c>127</c>) instead of their name. While you can still use them, numbers <c>120</c> to <c>127</c> are
        /// usually reserved for *channel mode* messages. See
        /// [<c>sendChannelMode()</c>]<see href="OutputChannel#sendChannelMode">OutputChannel#sendChannelMode</see> method for more info.
        ///
        /// To view a detailed list of all available **control change** messages, please consult "Table 3 -
        /// Control Change Messages" from the [MIDI Messages](
        /// https://www.midi.org/specifications/item/table-3-control-change-messages-data-bytes-2)
        /// specification.
        ///
        /// **Note**: messages #0-31 (MSB) are paired with messages #32-63 (LSB). For example, message #1
        /// (<c>modulationwheelcoarse</c>) can be accompanied by a second control change message for
        /// <c>modulationwheelfine</c> to achieve a greater level of precision. if you want to specify both MSB
        /// and LSB for messages between <c>0</c> and <c>31</c>, you can do so by passing a 2-value array as the
        /// second parameter.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// Controller numbers must be between 0 and 127.
        ///
        /// Invalid controller name.
        ///
        /// The value array must have a length of 2.
        /// </remarks>
        /// <param name="controller">
        /// The MIDI controller name or number (<c>0</c> - <c>127</c>).
        /// </param>
        /// <param name="value">
        /// The value to send (0-127). You can also use a two-position array
        /// for controllers 0 to 31. In this scenario, the first value will be sent as usual and the second
        /// value will be sent to the matching LSB controller (which is obtained by adding 32 to the first
        /// controller)
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member sendControlChange: controller: float * value: ResizeArray<float> * ?options: OutputChannel.sendControlChange.options -> Webmidi.OutputChannel
        /// <summary>
        /// Sends a MIDI **control change** message to the channel at the scheduled time. The control
        /// change message to send can be specified numerically (<c>0</c> to <c>127</c>) or by using one of the
        /// following common names:
        ///
        /// | Number | Name                          |
        /// |--------|-------------------------------|
        /// | 0      |<c>bankselectcoarse</c>             |
        /// | 1      |<c>modulationwheelcoarse</c>        |
        /// | 2      |<c>breathcontrollercoarse</c>       |
        /// | 4      |<c>footcontrollercoarse</c>         |
        /// | 5      |<c>portamentotimecoarse</c>         |
        /// | 6      |<c>dataentrycoarse</c>              |
        /// | 7      |<c>volumecoarse</c>                 |
        /// | 8      |<c>balancecoarse</c>                |
        /// | 10     |<c>pancoarse</c>                    |
        /// | 11     |<c>expressioncoarse</c>             |
        /// | 12     |<c>effectcontrol1coarse</c>         |
        /// | 13     |<c>effectcontrol2coarse</c>         |
        /// | 18     |<c>generalpurposeslider3</c>        |
        /// | 19     |<c>generalpurposeslider4</c>        |
        /// | 32     |<c>bankselectfine</c>               |
        /// | 33     |<c>modulationwheelfine</c>          |
        /// | 34     |<c>breathcontrollerfine</c>         |
        /// | 36     |<c>footcontrollerfine</c>           |
        /// | 37     |<c>portamentotimefine</c>           |
        /// | 38     |<c>dataentryfine</c>                |
        /// | 39     |<c>volumefine</c>                   |
        /// | 40     |<c>balancefine</c>                  |
        /// | 42     |<c>panfine</c>                      |
        /// | 43     |<c>expressionfine</c>               |
        /// | 44     |<c>effectcontrol1fine</c>           |
        /// | 45     |<c>effectcontrol2fine</c>           |
        /// | 64     |<c>holdpedal</c>                    |
        /// | 65     |<c>portamento</c>                   |
        /// | 66     |<c>sustenutopedal</c>               |
        /// | 67     |<c>softpedal</c>                    |
        /// | 68     |<c>legatopedal</c>                  |
        /// | 69     |<c>hold2pedal</c>                   |
        /// | 70     |<c>soundvariation</c>               |
        /// | 71     |<c>resonance</c>                    |
        /// | 72     |<c>soundreleasetime</c>             |
        /// | 73     |<c>soundattacktime</c>              |
        /// | 74     |<c>brightness</c>                   |
        /// | 75     |<c>soundcontrol6</c>                |
        /// | 76     |<c>soundcontrol7</c>                |
        /// | 77     |<c>soundcontrol8</c>                |
        /// | 78     |<c>soundcontrol9</c>                |
        /// | 79     |<c>soundcontrol10</c>               |
        /// | 80     |<c>generalpurposebutton1</c>        |
        /// | 81     |<c>generalpurposebutton2</c>        |
        /// | 82     |<c>generalpurposebutton3</c>        |
        /// | 83     |<c>generalpurposebutton4</c>        |
        /// | 91     |<c>reverblevel</c>                  |
        /// | 92     |<c>tremololevel</c>                 |
        /// | 93     |<c>choruslevel</c>                  |
        /// | 94     |<c>celestelevel</c>                 |
        /// | 95     |<c>phaserlevel</c>                  |
        /// | 96     |<c>dataincrement</c>          |
        /// | 97     |<c>datadecrement</c>          |
        /// | 98     |<c>nonregisteredparametercoarse</c> |
        /// | 99     |<c>nonregisteredparameterfine</c>   |
        /// | 100    |<c>registeredparametercoarse</c>    |
        /// | 101    |<c>registeredparameterfine</c>      |
        /// | 120    |<c>allsoundoff</c>                  |
        /// | 121    |<c>resetallcontrollers</c>          |
        /// | 122    |<c>localcontrol</c>                 |
        /// | 123    |<c>allnotesoff</c>                  |
        /// | 124    |<c>omnimodeoff</c>                  |
        /// | 125    |<c>omnimodeon</c>                   |
        /// | 126    |<c>monomodeon</c>                   |
        /// | 127    |<c>polymodeon</c>                   |
        ///
        /// As you can see above, not all control change message have a matching name. This does not mean
        /// you cannot use the others. It simply means you will need to use their number
        /// (<c>0</c> to <c>127</c>) instead of their name. While you can still use them, numbers <c>120</c> to <c>127</c> are
        /// usually reserved for *channel mode* messages. See
        /// [<c>sendChannelMode()</c>]<see href="OutputChannel#sendChannelMode">OutputChannel#sendChannelMode</see> method for more info.
        ///
        /// To view a detailed list of all available **control change** messages, please consult "Table 3 -
        /// Control Change Messages" from the [MIDI Messages](
        /// https://www.midi.org/specifications/item/table-3-control-change-messages-data-bytes-2)
        /// specification.
        ///
        /// **Note**: messages #0-31 (MSB) are paired with messages #32-63 (LSB). For example, message #1
        /// (<c>modulationwheelcoarse</c>) can be accompanied by a second control change message for
        /// <c>modulationwheelfine</c> to achieve a greater level of precision. if you want to specify both MSB
        /// and LSB for messages between <c>0</c> and <c>31</c>, you can do so by passing a 2-value array as the
        /// second parameter.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// Controller numbers must be between 0 and 127.
        ///
        /// Invalid controller name.
        ///
        /// The value array must have a length of 2.
        /// </remarks>
        /// <param name="controller">
        /// The MIDI controller name or number (<c>0</c> - <c>127</c>).
        /// </param>
        /// <param name="value">
        /// The value to send (0-127). You can also use a two-position array
        /// for controllers 0 to 31. In this scenario, the first value will be sent as usual and the second
        /// value will be sent to the matching LSB controller (which is obtained by adding 32 to the first
        /// controller)
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member sendControlChange: controller: string * value: float * ?options: OutputChannel.sendControlChange.options -> Webmidi.OutputChannel
        /// <summary>
        /// Sends a MIDI **control change** message to the channel at the scheduled time. The control
        /// change message to send can be specified numerically (<c>0</c> to <c>127</c>) or by using one of the
        /// following common names:
        ///
        /// | Number | Name                          |
        /// |--------|-------------------------------|
        /// | 0      |<c>bankselectcoarse</c>             |
        /// | 1      |<c>modulationwheelcoarse</c>        |
        /// | 2      |<c>breathcontrollercoarse</c>       |
        /// | 4      |<c>footcontrollercoarse</c>         |
        /// | 5      |<c>portamentotimecoarse</c>         |
        /// | 6      |<c>dataentrycoarse</c>              |
        /// | 7      |<c>volumecoarse</c>                 |
        /// | 8      |<c>balancecoarse</c>                |
        /// | 10     |<c>pancoarse</c>                    |
        /// | 11     |<c>expressioncoarse</c>             |
        /// | 12     |<c>effectcontrol1coarse</c>         |
        /// | 13     |<c>effectcontrol2coarse</c>         |
        /// | 18     |<c>generalpurposeslider3</c>        |
        /// | 19     |<c>generalpurposeslider4</c>        |
        /// | 32     |<c>bankselectfine</c>               |
        /// | 33     |<c>modulationwheelfine</c>          |
        /// | 34     |<c>breathcontrollerfine</c>         |
        /// | 36     |<c>footcontrollerfine</c>           |
        /// | 37     |<c>portamentotimefine</c>           |
        /// | 38     |<c>dataentryfine</c>                |
        /// | 39     |<c>volumefine</c>                   |
        /// | 40     |<c>balancefine</c>                  |
        /// | 42     |<c>panfine</c>                      |
        /// | 43     |<c>expressionfine</c>               |
        /// | 44     |<c>effectcontrol1fine</c>           |
        /// | 45     |<c>effectcontrol2fine</c>           |
        /// | 64     |<c>holdpedal</c>                    |
        /// | 65     |<c>portamento</c>                   |
        /// | 66     |<c>sustenutopedal</c>               |
        /// | 67     |<c>softpedal</c>                    |
        /// | 68     |<c>legatopedal</c>                  |
        /// | 69     |<c>hold2pedal</c>                   |
        /// | 70     |<c>soundvariation</c>               |
        /// | 71     |<c>resonance</c>                    |
        /// | 72     |<c>soundreleasetime</c>             |
        /// | 73     |<c>soundattacktime</c>              |
        /// | 74     |<c>brightness</c>                   |
        /// | 75     |<c>soundcontrol6</c>                |
        /// | 76     |<c>soundcontrol7</c>                |
        /// | 77     |<c>soundcontrol8</c>                |
        /// | 78     |<c>soundcontrol9</c>                |
        /// | 79     |<c>soundcontrol10</c>               |
        /// | 80     |<c>generalpurposebutton1</c>        |
        /// | 81     |<c>generalpurposebutton2</c>        |
        /// | 82     |<c>generalpurposebutton3</c>        |
        /// | 83     |<c>generalpurposebutton4</c>        |
        /// | 91     |<c>reverblevel</c>                  |
        /// | 92     |<c>tremololevel</c>                 |
        /// | 93     |<c>choruslevel</c>                  |
        /// | 94     |<c>celestelevel</c>                 |
        /// | 95     |<c>phaserlevel</c>                  |
        /// | 96     |<c>dataincrement</c>          |
        /// | 97     |<c>datadecrement</c>          |
        /// | 98     |<c>nonregisteredparametercoarse</c> |
        /// | 99     |<c>nonregisteredparameterfine</c>   |
        /// | 100    |<c>registeredparametercoarse</c>    |
        /// | 101    |<c>registeredparameterfine</c>      |
        /// | 120    |<c>allsoundoff</c>                  |
        /// | 121    |<c>resetallcontrollers</c>          |
        /// | 122    |<c>localcontrol</c>                 |
        /// | 123    |<c>allnotesoff</c>                  |
        /// | 124    |<c>omnimodeoff</c>                  |
        /// | 125    |<c>omnimodeon</c>                   |
        /// | 126    |<c>monomodeon</c>                   |
        /// | 127    |<c>polymodeon</c>                   |
        ///
        /// As you can see above, not all control change message have a matching name. This does not mean
        /// you cannot use the others. It simply means you will need to use their number
        /// (<c>0</c> to <c>127</c>) instead of their name. While you can still use them, numbers <c>120</c> to <c>127</c> are
        /// usually reserved for *channel mode* messages. See
        /// [<c>sendChannelMode()</c>]<see href="OutputChannel#sendChannelMode">OutputChannel#sendChannelMode</see> method for more info.
        ///
        /// To view a detailed list of all available **control change** messages, please consult "Table 3 -
        /// Control Change Messages" from the [MIDI Messages](
        /// https://www.midi.org/specifications/item/table-3-control-change-messages-data-bytes-2)
        /// specification.
        ///
        /// **Note**: messages #0-31 (MSB) are paired with messages #32-63 (LSB). For example, message #1
        /// (<c>modulationwheelcoarse</c>) can be accompanied by a second control change message for
        /// <c>modulationwheelfine</c> to achieve a greater level of precision. if you want to specify both MSB
        /// and LSB for messages between <c>0</c> and <c>31</c>, you can do so by passing a 2-value array as the
        /// second parameter.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// Controller numbers must be between 0 and 127.
        ///
        /// Invalid controller name.
        ///
        /// The value array must have a length of 2.
        /// </remarks>
        /// <param name="controller">
        /// The MIDI controller name or number (<c>0</c> - <c>127</c>).
        /// </param>
        /// <param name="value">
        /// The value to send (0-127). You can also use a two-position array
        /// for controllers 0 to 31. In this scenario, the first value will be sent as usual and the second
        /// value will be sent to the matching LSB controller (which is obtained by adding 32 to the first
        /// controller)
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member sendControlChange: controller: string * value: ResizeArray<float> * ?options: OutputChannel.sendControlChange.options -> Webmidi.OutputChannel
        /// <summary>
        /// Sends a MIDI **control change** message to the channel at the scheduled time. The control
        /// change message to send can be specified numerically (<c>0</c> to <c>127</c>) or by using one of the
        /// following common names:
        ///
        /// | Number | Name                          |
        /// |--------|-------------------------------|
        /// | 0      |<c>bankselectcoarse</c>             |
        /// | 1      |<c>modulationwheelcoarse</c>        |
        /// | 2      |<c>breathcontrollercoarse</c>       |
        /// | 4      |<c>footcontrollercoarse</c>         |
        /// | 5      |<c>portamentotimecoarse</c>         |
        /// | 6      |<c>dataentrycoarse</c>              |
        /// | 7      |<c>volumecoarse</c>                 |
        /// | 8      |<c>balancecoarse</c>                |
        /// | 10     |<c>pancoarse</c>                    |
        /// | 11     |<c>expressioncoarse</c>             |
        /// | 12     |<c>effectcontrol1coarse</c>         |
        /// | 13     |<c>effectcontrol2coarse</c>         |
        /// | 18     |<c>generalpurposeslider3</c>        |
        /// | 19     |<c>generalpurposeslider4</c>        |
        /// | 32     |<c>bankselectfine</c>               |
        /// | 33     |<c>modulationwheelfine</c>          |
        /// | 34     |<c>breathcontrollerfine</c>         |
        /// | 36     |<c>footcontrollerfine</c>           |
        /// | 37     |<c>portamentotimefine</c>           |
        /// | 38     |<c>dataentryfine</c>                |
        /// | 39     |<c>volumefine</c>                   |
        /// | 40     |<c>balancefine</c>                  |
        /// | 42     |<c>panfine</c>                      |
        /// | 43     |<c>expressionfine</c>               |
        /// | 44     |<c>effectcontrol1fine</c>           |
        /// | 45     |<c>effectcontrol2fine</c>           |
        /// | 64     |<c>holdpedal</c>                    |
        /// | 65     |<c>portamento</c>                   |
        /// | 66     |<c>sustenutopedal</c>               |
        /// | 67     |<c>softpedal</c>                    |
        /// | 68     |<c>legatopedal</c>                  |
        /// | 69     |<c>hold2pedal</c>                   |
        /// | 70     |<c>soundvariation</c>               |
        /// | 71     |<c>resonance</c>                    |
        /// | 72     |<c>soundreleasetime</c>             |
        /// | 73     |<c>soundattacktime</c>              |
        /// | 74     |<c>brightness</c>                   |
        /// | 75     |<c>soundcontrol6</c>                |
        /// | 76     |<c>soundcontrol7</c>                |
        /// | 77     |<c>soundcontrol8</c>                |
        /// | 78     |<c>soundcontrol9</c>                |
        /// | 79     |<c>soundcontrol10</c>               |
        /// | 80     |<c>generalpurposebutton1</c>        |
        /// | 81     |<c>generalpurposebutton2</c>        |
        /// | 82     |<c>generalpurposebutton3</c>        |
        /// | 83     |<c>generalpurposebutton4</c>        |
        /// | 91     |<c>reverblevel</c>                  |
        /// | 92     |<c>tremololevel</c>                 |
        /// | 93     |<c>choruslevel</c>                  |
        /// | 94     |<c>celestelevel</c>                 |
        /// | 95     |<c>phaserlevel</c>                  |
        /// | 96     |<c>dataincrement</c>          |
        /// | 97     |<c>datadecrement</c>          |
        /// | 98     |<c>nonregisteredparametercoarse</c> |
        /// | 99     |<c>nonregisteredparameterfine</c>   |
        /// | 100    |<c>registeredparametercoarse</c>    |
        /// | 101    |<c>registeredparameterfine</c>      |
        /// | 120    |<c>allsoundoff</c>                  |
        /// | 121    |<c>resetallcontrollers</c>          |
        /// | 122    |<c>localcontrol</c>                 |
        /// | 123    |<c>allnotesoff</c>                  |
        /// | 124    |<c>omnimodeoff</c>                  |
        /// | 125    |<c>omnimodeon</c>                   |
        /// | 126    |<c>monomodeon</c>                   |
        /// | 127    |<c>polymodeon</c>                   |
        ///
        /// As you can see above, not all control change message have a matching name. This does not mean
        /// you cannot use the others. It simply means you will need to use their number
        /// (<c>0</c> to <c>127</c>) instead of their name. While you can still use them, numbers <c>120</c> to <c>127</c> are
        /// usually reserved for *channel mode* messages. See
        /// [<c>sendChannelMode()</c>]<see href="OutputChannel#sendChannelMode">OutputChannel#sendChannelMode</see> method for more info.
        ///
        /// To view a detailed list of all available **control change** messages, please consult "Table 3 -
        /// Control Change Messages" from the [MIDI Messages](
        /// https://www.midi.org/specifications/item/table-3-control-change-messages-data-bytes-2)
        /// specification.
        ///
        /// **Note**: messages #0-31 (MSB) are paired with messages #32-63 (LSB). For example, message #1
        /// (<c>modulationwheelcoarse</c>) can be accompanied by a second control change message for
        /// <c>modulationwheelfine</c> to achieve a greater level of precision. if you want to specify both MSB
        /// and LSB for messages between <c>0</c> and <c>31</c>, you can do so by passing a 2-value array as the
        /// second parameter.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// Controller numbers must be between 0 and 127.
        ///
        /// Invalid controller name.
        ///
        /// The value array must have a length of 2.
        /// </remarks>
        /// <param name="controller">
        /// The MIDI controller name or number (<c>0</c> - <c>127</c>).
        /// </param>
        /// <param name="value">
        /// The value to send (0-127). You can also use a two-position array
        /// for controllers 0 to 31. In this scenario, the first value will be sent as usual and the second
        /// value will be sent to the matching LSB controller (which is obtained by adding 32 to the first
        /// controller)
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member sendControlChange: controller: U2<float, string> * value: U2<float, ResizeArray<float>> * ?options: OutputChannel.sendControlChange.options -> Webmidi.OutputChannel
        /// <summary>
        /// Decrements the specified MIDI registered parameter by 1. Here is the full list of parameter
        /// names that can be used with this function:
        ///
        ///  * Pitchbend Range (0x00, 0x00): <c>"pitchbendrange"</c>
        ///  * Channel Fine Tuning (0x00, 0x01): <c>"channelfinetuning"</c>
        ///  * Channel Coarse Tuning (0x00, 0x02): <c>"channelcoarsetuning"</c>
        ///  * Tuning Program (0x00, 0x03): <c>"tuningprogram"</c>
        ///  * Tuning Bank (0x00, 0x04): <c>"tuningbank"</c>
        ///  * Modulation Range (0x00, 0x05): <c>"modulationrange"</c>
        ///  * Azimuth Angle (0x3D, 0x00): <c>"azimuthangle"</c>
        ///  * Elevation Angle (0x3D, 0x01): <c>"elevationangle"</c>
        ///  * Gain (0x3D, 0x02): <c>"gain"</c>
        ///  * Distance Ratio (0x3D, 0x03): <c>"distanceratio"</c>
        ///  * Maximum Distance (0x3D, 0x04): <c>"maximumdistance"</c>
        ///  * Maximum Distance Gain (0x3D, 0x05): <c>"maximumdistancegain"</c>
        ///  * Reference Distance Ratio (0x3D, 0x06): <c>"referencedistanceratio"</c>
        ///  * Pan Spread Angle (0x3D, 0x07): <c>"panspreadangle"</c>
        ///  * Roll Angle (0x3D, 0x08): <c>"rollangle"</c>
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// TypeError The specified registered parameter is invalid.
        /// </remarks>
        /// <param name="parameter">
        /// A string identifying the parameter's name (see above) or a
        /// two-position array specifying the two control bytes (0x65, 0x64) that identify the registered
        /// parameter.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member sendRpnDecrement: parameter: string * ?options: OutputChannel.sendRpnDecrement.options -> Webmidi.OutputChannel
        /// <summary>
        /// Decrements the specified MIDI registered parameter by 1. Here is the full list of parameter
        /// names that can be used with this function:
        ///
        ///  * Pitchbend Range (0x00, 0x00): <c>"pitchbendrange"</c>
        ///  * Channel Fine Tuning (0x00, 0x01): <c>"channelfinetuning"</c>
        ///  * Channel Coarse Tuning (0x00, 0x02): <c>"channelcoarsetuning"</c>
        ///  * Tuning Program (0x00, 0x03): <c>"tuningprogram"</c>
        ///  * Tuning Bank (0x00, 0x04): <c>"tuningbank"</c>
        ///  * Modulation Range (0x00, 0x05): <c>"modulationrange"</c>
        ///  * Azimuth Angle (0x3D, 0x00): <c>"azimuthangle"</c>
        ///  * Elevation Angle (0x3D, 0x01): <c>"elevationangle"</c>
        ///  * Gain (0x3D, 0x02): <c>"gain"</c>
        ///  * Distance Ratio (0x3D, 0x03): <c>"distanceratio"</c>
        ///  * Maximum Distance (0x3D, 0x04): <c>"maximumdistance"</c>
        ///  * Maximum Distance Gain (0x3D, 0x05): <c>"maximumdistancegain"</c>
        ///  * Reference Distance Ratio (0x3D, 0x06): <c>"referencedistanceratio"</c>
        ///  * Pan Spread Angle (0x3D, 0x07): <c>"panspreadangle"</c>
        ///  * Roll Angle (0x3D, 0x08): <c>"rollangle"</c>
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// TypeError The specified registered parameter is invalid.
        /// </remarks>
        /// <param name="parameter">
        /// A string identifying the parameter's name (see above) or a
        /// two-position array specifying the two control bytes (0x65, 0x64) that identify the registered
        /// parameter.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member sendRpnDecrement: parameter: ResizeArray<float> * ?options: OutputChannel.sendRpnDecrement.options -> Webmidi.OutputChannel
        /// <summary>
        /// Decrements the specified MIDI registered parameter by 1. Here is the full list of parameter
        /// names that can be used with this function:
        ///
        ///  * Pitchbend Range (0x00, 0x00): <c>"pitchbendrange"</c>
        ///  * Channel Fine Tuning (0x00, 0x01): <c>"channelfinetuning"</c>
        ///  * Channel Coarse Tuning (0x00, 0x02): <c>"channelcoarsetuning"</c>
        ///  * Tuning Program (0x00, 0x03): <c>"tuningprogram"</c>
        ///  * Tuning Bank (0x00, 0x04): <c>"tuningbank"</c>
        ///  * Modulation Range (0x00, 0x05): <c>"modulationrange"</c>
        ///  * Azimuth Angle (0x3D, 0x00): <c>"azimuthangle"</c>
        ///  * Elevation Angle (0x3D, 0x01): <c>"elevationangle"</c>
        ///  * Gain (0x3D, 0x02): <c>"gain"</c>
        ///  * Distance Ratio (0x3D, 0x03): <c>"distanceratio"</c>
        ///  * Maximum Distance (0x3D, 0x04): <c>"maximumdistance"</c>
        ///  * Maximum Distance Gain (0x3D, 0x05): <c>"maximumdistancegain"</c>
        ///  * Reference Distance Ratio (0x3D, 0x06): <c>"referencedistanceratio"</c>
        ///  * Pan Spread Angle (0x3D, 0x07): <c>"panspreadangle"</c>
        ///  * Roll Angle (0x3D, 0x08): <c>"rollangle"</c>
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// TypeError The specified registered parameter is invalid.
        /// </remarks>
        /// <param name="parameter">
        /// A string identifying the parameter's name (see above) or a
        /// two-position array specifying the two control bytes (0x65, 0x64) that identify the registered
        /// parameter.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member sendRpnDecrement: parameter: U2<string, ResizeArray<float>> * ?options: OutputChannel.sendRpnDecrement.options -> Webmidi.OutputChannel
        /// <summary>
        /// Increments the specified MIDI registered parameter by 1. Here is the full list of parameter
        /// names that can be used with this function:
        ///
        ///  * Pitchbend Range (0x00, 0x00): <c>"pitchbendrange"</c>
        ///  * Channel Fine Tuning (0x00, 0x01): <c>"channelfinetuning"</c>
        ///  * Channel Coarse Tuning (0x00, 0x02): <c>"channelcoarsetuning"</c>
        ///  * Tuning Program (0x00, 0x03): <c>"tuningprogram"</c>
        ///  * Tuning Bank (0x00, 0x04): <c>"tuningbank"</c>
        ///  * Modulation Range (0x00, 0x05): <c>"modulationrange"</c>
        ///  * Azimuth Angle (0x3D, 0x00): <c>"azimuthangle"</c>
        ///  * Elevation Angle (0x3D, 0x01): <c>"elevationangle"</c>
        ///  * Gain (0x3D, 0x02): <c>"gain"</c>
        ///  * Distance Ratio (0x3D, 0x03): <c>"distanceratio"</c>
        ///  * Maximum Distance (0x3D, 0x04): <c>"maximumdistance"</c>
        ///  * Maximum Distance Gain (0x3D, 0x05): <c>"maximumdistancegain"</c>
        ///  * Reference Distance Ratio (0x3D, 0x06): <c>"referencedistanceratio"</c>
        ///  * Pan Spread Angle (0x3D, 0x07): <c>"panspreadangle"</c>
        ///  * Roll Angle (0x3D, 0x08): <c>"rollangle"</c>
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// TypeError The specified registered parameter is invalid.
        /// </remarks>
        /// <param name="parameter">
        /// A string identifying the parameter's name (see above) or a
        /// two-position array specifying the two control bytes (0x65, 0x64) that identify the registered
        /// parameter.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member sendRpnIncrement: parameter: string * ?options: OutputChannel.sendRpnIncrement.options -> Webmidi.OutputChannel
        /// <summary>
        /// Increments the specified MIDI registered parameter by 1. Here is the full list of parameter
        /// names that can be used with this function:
        ///
        ///  * Pitchbend Range (0x00, 0x00): <c>"pitchbendrange"</c>
        ///  * Channel Fine Tuning (0x00, 0x01): <c>"channelfinetuning"</c>
        ///  * Channel Coarse Tuning (0x00, 0x02): <c>"channelcoarsetuning"</c>
        ///  * Tuning Program (0x00, 0x03): <c>"tuningprogram"</c>
        ///  * Tuning Bank (0x00, 0x04): <c>"tuningbank"</c>
        ///  * Modulation Range (0x00, 0x05): <c>"modulationrange"</c>
        ///  * Azimuth Angle (0x3D, 0x00): <c>"azimuthangle"</c>
        ///  * Elevation Angle (0x3D, 0x01): <c>"elevationangle"</c>
        ///  * Gain (0x3D, 0x02): <c>"gain"</c>
        ///  * Distance Ratio (0x3D, 0x03): <c>"distanceratio"</c>
        ///  * Maximum Distance (0x3D, 0x04): <c>"maximumdistance"</c>
        ///  * Maximum Distance Gain (0x3D, 0x05): <c>"maximumdistancegain"</c>
        ///  * Reference Distance Ratio (0x3D, 0x06): <c>"referencedistanceratio"</c>
        ///  * Pan Spread Angle (0x3D, 0x07): <c>"panspreadangle"</c>
        ///  * Roll Angle (0x3D, 0x08): <c>"rollangle"</c>
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// TypeError The specified registered parameter is invalid.
        /// </remarks>
        /// <param name="parameter">
        /// A string identifying the parameter's name (see above) or a
        /// two-position array specifying the two control bytes (0x65, 0x64) that identify the registered
        /// parameter.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member sendRpnIncrement: parameter: ResizeArray<float> * ?options: OutputChannel.sendRpnIncrement.options -> Webmidi.OutputChannel
        /// <summary>
        /// Increments the specified MIDI registered parameter by 1. Here is the full list of parameter
        /// names that can be used with this function:
        ///
        ///  * Pitchbend Range (0x00, 0x00): <c>"pitchbendrange"</c>
        ///  * Channel Fine Tuning (0x00, 0x01): <c>"channelfinetuning"</c>
        ///  * Channel Coarse Tuning (0x00, 0x02): <c>"channelcoarsetuning"</c>
        ///  * Tuning Program (0x00, 0x03): <c>"tuningprogram"</c>
        ///  * Tuning Bank (0x00, 0x04): <c>"tuningbank"</c>
        ///  * Modulation Range (0x00, 0x05): <c>"modulationrange"</c>
        ///  * Azimuth Angle (0x3D, 0x00): <c>"azimuthangle"</c>
        ///  * Elevation Angle (0x3D, 0x01): <c>"elevationangle"</c>
        ///  * Gain (0x3D, 0x02): <c>"gain"</c>
        ///  * Distance Ratio (0x3D, 0x03): <c>"distanceratio"</c>
        ///  * Maximum Distance (0x3D, 0x04): <c>"maximumdistance"</c>
        ///  * Maximum Distance Gain (0x3D, 0x05): <c>"maximumdistancegain"</c>
        ///  * Reference Distance Ratio (0x3D, 0x06): <c>"referencedistanceratio"</c>
        ///  * Pan Spread Angle (0x3D, 0x07): <c>"panspreadangle"</c>
        ///  * Roll Angle (0x3D, 0x08): <c>"rollangle"</c>
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// TypeError The specified registered parameter is invalid.
        /// </remarks>
        /// <param name="parameter">
        /// A string identifying the parameter's name (see above) or a
        /// two-position array specifying the two control bytes (0x65, 0x64) that identify the registered
        /// parameter.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member sendRpnIncrement: parameter: U2<string, ResizeArray<float>> * ?options: OutputChannel.sendRpnIncrement.options -> Webmidi.OutputChannel
        /// <summary>
        /// Plays a note or an array of notes on the channel. The first parameter is the note to play. It
        /// can be a single value or an array of the following valid values:
        ///
        ///  - A [<c>Note</c>]<see href="Note">Note</see> object
        ///  - A MIDI note number (integer between <c>0</c> and <c>127</c>)
        ///  - A note name, followed by the octave (e.g. <c>"C3"</c>, <c>"G#4"</c>, <c>"F-1"</c>, <c>"Db7"</c>)
        ///
        /// The <c>playNote()</c> method sends a **note on** MIDI message for all specified notes. If a
        /// <c>duration</c> is set in the <c>options</c> parameter or in the [<c>Note</c>]<see href="Note">Note</see> object's
        /// [<c>duration</c>]<see href="Note#duration">Note#duration</see> property, it will also schedule a **note off** message
        /// to end the note after said duration. If no <c>duration</c> is set, the note will simply play until
        /// a matching **note off** message is sent with [<c>stopNote()</c>]<see href="OutputChannel#stopNote">OutputChannel#stopNote</see> or
        /// [<c>sendNoteOff()</c>]<see href="OutputChannel#sendNoteOff">OutputChannel#sendNoteOff</see>.
        ///
        ///  The execution of the **note on** command can be delayed by using the <c>time</c> property of the
        /// <c>options</c> parameter.
        ///
        /// When using [<c>Note</c>]<see href="Note">Note</see> objects, the durations and velocities defined in the
        /// [<c>Note</c>]<see href="Note">Note</see> objects have precedence over the ones specified via the method's <c>options</c>
        /// parameter.
        ///
        /// **Note**: per the MIDI standard, a **note on** message with an attack velocity of <c>0</c> is
        /// functionally equivalent to a **note off** message.
        /// </summary>
        /// <param name="note">
        /// The note(s) to play. The notes can be
        /// specified by using a MIDI note number (<c>0</c> - <c>127</c>), a note identifier (e.g. <c>C3</c>, <c>G#4</c>,
        /// <c>F-1</c>, <c>Db7</c>), a [<c>Note</c>]<see href="Note">Note</see> object or an array of the previous types. When using a
        /// note identifier, the octave range must be between <c>-1</c> and <c>9</c>. The lowest note is <c>C-1</c> (MIDI
        /// note number <c>0</c>) and the highest note is <c>G9</c> (MIDI note number <c>127</c>).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member playNote: note: float * ?options: OutputChannel.playNote.options -> Webmidi.OutputChannel
        /// <summary>
        /// Plays a note or an array of notes on the channel. The first parameter is the note to play. It
        /// can be a single value or an array of the following valid values:
        ///
        ///  - A [<c>Note</c>]<see href="Note">Note</see> object
        ///  - A MIDI note number (integer between <c>0</c> and <c>127</c>)
        ///  - A note name, followed by the octave (e.g. <c>"C3"</c>, <c>"G#4"</c>, <c>"F-1"</c>, <c>"Db7"</c>)
        ///
        /// The <c>playNote()</c> method sends a **note on** MIDI message for all specified notes. If a
        /// <c>duration</c> is set in the <c>options</c> parameter or in the [<c>Note</c>]<see href="Note">Note</see> object's
        /// [<c>duration</c>]<see href="Note#duration">Note#duration</see> property, it will also schedule a **note off** message
        /// to end the note after said duration. If no <c>duration</c> is set, the note will simply play until
        /// a matching **note off** message is sent with [<c>stopNote()</c>]<see href="OutputChannel#stopNote">OutputChannel#stopNote</see> or
        /// [<c>sendNoteOff()</c>]<see href="OutputChannel#sendNoteOff">OutputChannel#sendNoteOff</see>.
        ///
        ///  The execution of the **note on** command can be delayed by using the <c>time</c> property of the
        /// <c>options</c> parameter.
        ///
        /// When using [<c>Note</c>]<see href="Note">Note</see> objects, the durations and velocities defined in the
        /// [<c>Note</c>]<see href="Note">Note</see> objects have precedence over the ones specified via the method's <c>options</c>
        /// parameter.
        ///
        /// **Note**: per the MIDI standard, a **note on** message with an attack velocity of <c>0</c> is
        /// functionally equivalent to a **note off** message.
        /// </summary>
        /// <param name="note">
        /// The note(s) to play. The notes can be
        /// specified by using a MIDI note number (<c>0</c> - <c>127</c>), a note identifier (e.g. <c>C3</c>, <c>G#4</c>,
        /// <c>F-1</c>, <c>Db7</c>), a [<c>Note</c>]<see href="Note">Note</see> object or an array of the previous types. When using a
        /// note identifier, the octave range must be between <c>-1</c> and <c>9</c>. The lowest note is <c>C-1</c> (MIDI
        /// note number <c>0</c>) and the highest note is <c>G9</c> (MIDI note number <c>127</c>).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member playNote: note: string * ?options: OutputChannel.playNote.options -> Webmidi.OutputChannel
        /// <summary>
        /// Plays a note or an array of notes on the channel. The first parameter is the note to play. It
        /// can be a single value or an array of the following valid values:
        ///
        ///  - A [<c>Note</c>]<see href="Note">Note</see> object
        ///  - A MIDI note number (integer between <c>0</c> and <c>127</c>)
        ///  - A note name, followed by the octave (e.g. <c>"C3"</c>, <c>"G#4"</c>, <c>"F-1"</c>, <c>"Db7"</c>)
        ///
        /// The <c>playNote()</c> method sends a **note on** MIDI message for all specified notes. If a
        /// <c>duration</c> is set in the <c>options</c> parameter or in the [<c>Note</c>]<see href="Note">Note</see> object's
        /// [<c>duration</c>]<see href="Note#duration">Note#duration</see> property, it will also schedule a **note off** message
        /// to end the note after said duration. If no <c>duration</c> is set, the note will simply play until
        /// a matching **note off** message is sent with [<c>stopNote()</c>]<see href="OutputChannel#stopNote">OutputChannel#stopNote</see> or
        /// [<c>sendNoteOff()</c>]<see href="OutputChannel#sendNoteOff">OutputChannel#sendNoteOff</see>.
        ///
        ///  The execution of the **note on** command can be delayed by using the <c>time</c> property of the
        /// <c>options</c> parameter.
        ///
        /// When using [<c>Note</c>]<see href="Note">Note</see> objects, the durations and velocities defined in the
        /// [<c>Note</c>]<see href="Note">Note</see> objects have precedence over the ones specified via the method's <c>options</c>
        /// parameter.
        ///
        /// **Note**: per the MIDI standard, a **note on** message with an attack velocity of <c>0</c> is
        /// functionally equivalent to a **note off** message.
        /// </summary>
        /// <param name="note">
        /// The note(s) to play. The notes can be
        /// specified by using a MIDI note number (<c>0</c> - <c>127</c>), a note identifier (e.g. <c>C3</c>, <c>G#4</c>,
        /// <c>F-1</c>, <c>Db7</c>), a [<c>Note</c>]<see href="Note">Note</see> object or an array of the previous types. When using a
        /// note identifier, the octave range must be between <c>-1</c> and <c>9</c>. The lowest note is <c>C-1</c> (MIDI
        /// note number <c>0</c>) and the highest note is <c>G9</c> (MIDI note number <c>127</c>).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member playNote: note: Webmidi.Note * ?options: OutputChannel.playNote.options -> Webmidi.OutputChannel
        /// <summary>
        /// Plays a note or an array of notes on the channel. The first parameter is the note to play. It
        /// can be a single value or an array of the following valid values:
        ///
        ///  - A [<c>Note</c>]<see href="Note">Note</see> object
        ///  - A MIDI note number (integer between <c>0</c> and <c>127</c>)
        ///  - A note name, followed by the octave (e.g. <c>"C3"</c>, <c>"G#4"</c>, <c>"F-1"</c>, <c>"Db7"</c>)
        ///
        /// The <c>playNote()</c> method sends a **note on** MIDI message for all specified notes. If a
        /// <c>duration</c> is set in the <c>options</c> parameter or in the [<c>Note</c>]<see href="Note">Note</see> object's
        /// [<c>duration</c>]<see href="Note#duration">Note#duration</see> property, it will also schedule a **note off** message
        /// to end the note after said duration. If no <c>duration</c> is set, the note will simply play until
        /// a matching **note off** message is sent with [<c>stopNote()</c>]<see href="OutputChannel#stopNote">OutputChannel#stopNote</see> or
        /// [<c>sendNoteOff()</c>]<see href="OutputChannel#sendNoteOff">OutputChannel#sendNoteOff</see>.
        ///
        ///  The execution of the **note on** command can be delayed by using the <c>time</c> property of the
        /// <c>options</c> parameter.
        ///
        /// When using [<c>Note</c>]<see href="Note">Note</see> objects, the durations and velocities defined in the
        /// [<c>Note</c>]<see href="Note">Note</see> objects have precedence over the ones specified via the method's <c>options</c>
        /// parameter.
        ///
        /// **Note**: per the MIDI standard, a **note on** message with an attack velocity of <c>0</c> is
        /// functionally equivalent to a **note off** message.
        /// </summary>
        /// <param name="note">
        /// The note(s) to play. The notes can be
        /// specified by using a MIDI note number (<c>0</c> - <c>127</c>), a note identifier (e.g. <c>C3</c>, <c>G#4</c>,
        /// <c>F-1</c>, <c>Db7</c>), a [<c>Note</c>]<see href="Note">Note</see> object or an array of the previous types. When using a
        /// note identifier, the octave range must be between <c>-1</c> and <c>9</c>. The lowest note is <c>C-1</c> (MIDI
        /// note number <c>0</c>) and the highest note is <c>G9</c> (MIDI note number <c>127</c>).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member playNote: note: ResizeArray<float> * ?options: OutputChannel.playNote.options -> Webmidi.OutputChannel
        /// <summary>
        /// Plays a note or an array of notes on the channel. The first parameter is the note to play. It
        /// can be a single value or an array of the following valid values:
        ///
        ///  - A [<c>Note</c>]<see href="Note">Note</see> object
        ///  - A MIDI note number (integer between <c>0</c> and <c>127</c>)
        ///  - A note name, followed by the octave (e.g. <c>"C3"</c>, <c>"G#4"</c>, <c>"F-1"</c>, <c>"Db7"</c>)
        ///
        /// The <c>playNote()</c> method sends a **note on** MIDI message for all specified notes. If a
        /// <c>duration</c> is set in the <c>options</c> parameter or in the [<c>Note</c>]<see href="Note">Note</see> object's
        /// [<c>duration</c>]<see href="Note#duration">Note#duration</see> property, it will also schedule a **note off** message
        /// to end the note after said duration. If no <c>duration</c> is set, the note will simply play until
        /// a matching **note off** message is sent with [<c>stopNote()</c>]<see href="OutputChannel#stopNote">OutputChannel#stopNote</see> or
        /// [<c>sendNoteOff()</c>]<see href="OutputChannel#sendNoteOff">OutputChannel#sendNoteOff</see>.
        ///
        ///  The execution of the **note on** command can be delayed by using the <c>time</c> property of the
        /// <c>options</c> parameter.
        ///
        /// When using [<c>Note</c>]<see href="Note">Note</see> objects, the durations and velocities defined in the
        /// [<c>Note</c>]<see href="Note">Note</see> objects have precedence over the ones specified via the method's <c>options</c>
        /// parameter.
        ///
        /// **Note**: per the MIDI standard, a **note on** message with an attack velocity of <c>0</c> is
        /// functionally equivalent to a **note off** message.
        /// </summary>
        /// <param name="note">
        /// The note(s) to play. The notes can be
        /// specified by using a MIDI note number (<c>0</c> - <c>127</c>), a note identifier (e.g. <c>C3</c>, <c>G#4</c>,
        /// <c>F-1</c>, <c>Db7</c>), a [<c>Note</c>]<see href="Note">Note</see> object or an array of the previous types. When using a
        /// note identifier, the octave range must be between <c>-1</c> and <c>9</c>. The lowest note is <c>C-1</c> (MIDI
        /// note number <c>0</c>) and the highest note is <c>G9</c> (MIDI note number <c>127</c>).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member playNote: note: ResizeArray<string> * ?options: OutputChannel.playNote.options -> Webmidi.OutputChannel
        /// <summary>
        /// Plays a note or an array of notes on the channel. The first parameter is the note to play. It
        /// can be a single value or an array of the following valid values:
        ///
        ///  - A [<c>Note</c>]<see href="Note">Note</see> object
        ///  - A MIDI note number (integer between <c>0</c> and <c>127</c>)
        ///  - A note name, followed by the octave (e.g. <c>"C3"</c>, <c>"G#4"</c>, <c>"F-1"</c>, <c>"Db7"</c>)
        ///
        /// The <c>playNote()</c> method sends a **note on** MIDI message for all specified notes. If a
        /// <c>duration</c> is set in the <c>options</c> parameter or in the [<c>Note</c>]<see href="Note">Note</see> object's
        /// [<c>duration</c>]<see href="Note#duration">Note#duration</see> property, it will also schedule a **note off** message
        /// to end the note after said duration. If no <c>duration</c> is set, the note will simply play until
        /// a matching **note off** message is sent with [<c>stopNote()</c>]<see href="OutputChannel#stopNote">OutputChannel#stopNote</see> or
        /// [<c>sendNoteOff()</c>]<see href="OutputChannel#sendNoteOff">OutputChannel#sendNoteOff</see>.
        ///
        ///  The execution of the **note on** command can be delayed by using the <c>time</c> property of the
        /// <c>options</c> parameter.
        ///
        /// When using [<c>Note</c>]<see href="Note">Note</see> objects, the durations and velocities defined in the
        /// [<c>Note</c>]<see href="Note">Note</see> objects have precedence over the ones specified via the method's <c>options</c>
        /// parameter.
        ///
        /// **Note**: per the MIDI standard, a **note on** message with an attack velocity of <c>0</c> is
        /// functionally equivalent to a **note off** message.
        /// </summary>
        /// <param name="note">
        /// The note(s) to play. The notes can be
        /// specified by using a MIDI note number (<c>0</c> - <c>127</c>), a note identifier (e.g. <c>C3</c>, <c>G#4</c>,
        /// <c>F-1</c>, <c>Db7</c>), a [<c>Note</c>]<see href="Note">Note</see> object or an array of the previous types. When using a
        /// note identifier, the octave range must be between <c>-1</c> and <c>9</c>. The lowest note is <c>C-1</c> (MIDI
        /// note number <c>0</c>) and the highest note is <c>G9</c> (MIDI note number <c>127</c>).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member playNote: note: ResizeArray<Webmidi.Note> * ?options: OutputChannel.playNote.options -> Webmidi.OutputChannel
        /// <summary>
        /// Plays a note or an array of notes on the channel. The first parameter is the note to play. It
        /// can be a single value or an array of the following valid values:
        ///
        ///  - A [<c>Note</c>]<see href="Note">Note</see> object
        ///  - A MIDI note number (integer between <c>0</c> and <c>127</c>)
        ///  - A note name, followed by the octave (e.g. <c>"C3"</c>, <c>"G#4"</c>, <c>"F-1"</c>, <c>"Db7"</c>)
        ///
        /// The <c>playNote()</c> method sends a **note on** MIDI message for all specified notes. If a
        /// <c>duration</c> is set in the <c>options</c> parameter or in the [<c>Note</c>]<see href="Note">Note</see> object's
        /// [<c>duration</c>]<see href="Note#duration">Note#duration</see> property, it will also schedule a **note off** message
        /// to end the note after said duration. If no <c>duration</c> is set, the note will simply play until
        /// a matching **note off** message is sent with [<c>stopNote()</c>]<see href="OutputChannel#stopNote">OutputChannel#stopNote</see> or
        /// [<c>sendNoteOff()</c>]<see href="OutputChannel#sendNoteOff">OutputChannel#sendNoteOff</see>.
        ///
        ///  The execution of the **note on** command can be delayed by using the <c>time</c> property of the
        /// <c>options</c> parameter.
        ///
        /// When using [<c>Note</c>]<see href="Note">Note</see> objects, the durations and velocities defined in the
        /// [<c>Note</c>]<see href="Note">Note</see> objects have precedence over the ones specified via the method's <c>options</c>
        /// parameter.
        ///
        /// **Note**: per the MIDI standard, a **note on** message with an attack velocity of <c>0</c> is
        /// functionally equivalent to a **note off** message.
        /// </summary>
        /// <param name="note">
        /// The note(s) to play. The notes can be
        /// specified by using a MIDI note number (<c>0</c> - <c>127</c>), a note identifier (e.g. <c>C3</c>, <c>G#4</c>,
        /// <c>F-1</c>, <c>Db7</c>), a [<c>Note</c>]<see href="Note">Note</see> object or an array of the previous types. When using a
        /// note identifier, the octave range must be between <c>-1</c> and <c>9</c>. The lowest note is <c>C-1</c> (MIDI
        /// note number <c>0</c>) and the highest note is <c>G9</c> (MIDI note number <c>127</c>).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member playNote: note: U6<float, string, Webmidi.Note, ResizeArray<float>, ResizeArray<string>, ResizeArray<Webmidi.Note>> * ?options: OutputChannel.playNote.options -> Webmidi.OutputChannel
        /// <summary>
        /// Sends a **note off** message for the specified notes on the channel. The first parameter is the
        /// note. It can be a single value or an array of the following valid values:
        ///
        ///  - A MIDI note number (integer between <c>0</c> and <c>127</c>)
        ///  - A note name, followed by the octave (e.g. <c>"C3"</c>, <c>"G#4"</c>, <c>"F-1"</c>, <c>"Db7"</c>)
        ///  - A [<c>Note</c>]<see href="Note">Note</see> object
        ///
        /// The execution of the **note off** command can be delayed by using the <c>time</c> property of the
        /// <c>options</c> parameter.
        ///
        /// When using [<c>Note</c>]<see href="Note">Note</see> objects, the release velocity defined in the
        /// [<c>Note</c>]<see href="Note">Note</see> objects has precedence over the one specified via the method's <c>options</c>
        /// parameter.
        /// </summary>
        /// <param name="note">
        /// The note(s) to stop. The notes can be
        /// specified by using a MIDI note number (0-127), a note identifier (e.g. C3, G#4, F-1, Db7), a
        /// [<c>Note</c>]<see href="Note">Note</see> object or an array of the previous types. When using a note name, octave
        /// range must be between -1 and 9. The lowest note is C-1 (MIDI note number 0) and the highest
        /// note is G9 (MIDI note number 127).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member sendNoteOff: note: float * ?options: OutputChannel.sendNoteOff.options -> Webmidi.OutputChannel
        /// <summary>
        /// Sends a **note off** message for the specified notes on the channel. The first parameter is the
        /// note. It can be a single value or an array of the following valid values:
        ///
        ///  - A MIDI note number (integer between <c>0</c> and <c>127</c>)
        ///  - A note name, followed by the octave (e.g. <c>"C3"</c>, <c>"G#4"</c>, <c>"F-1"</c>, <c>"Db7"</c>)
        ///  - A [<c>Note</c>]<see href="Note">Note</see> object
        ///
        /// The execution of the **note off** command can be delayed by using the <c>time</c> property of the
        /// <c>options</c> parameter.
        ///
        /// When using [<c>Note</c>]<see href="Note">Note</see> objects, the release velocity defined in the
        /// [<c>Note</c>]<see href="Note">Note</see> objects has precedence over the one specified via the method's <c>options</c>
        /// parameter.
        /// </summary>
        /// <param name="note">
        /// The note(s) to stop. The notes can be
        /// specified by using a MIDI note number (0-127), a note identifier (e.g. C3, G#4, F-1, Db7), a
        /// [<c>Note</c>]<see href="Note">Note</see> object or an array of the previous types. When using a note name, octave
        /// range must be between -1 and 9. The lowest note is C-1 (MIDI note number 0) and the highest
        /// note is G9 (MIDI note number 127).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member sendNoteOff: note: string * ?options: OutputChannel.sendNoteOff.options -> Webmidi.OutputChannel
        /// <summary>
        /// Sends a **note off** message for the specified notes on the channel. The first parameter is the
        /// note. It can be a single value or an array of the following valid values:
        ///
        ///  - A MIDI note number (integer between <c>0</c> and <c>127</c>)
        ///  - A note name, followed by the octave (e.g. <c>"C3"</c>, <c>"G#4"</c>, <c>"F-1"</c>, <c>"Db7"</c>)
        ///  - A [<c>Note</c>]<see href="Note">Note</see> object
        ///
        /// The execution of the **note off** command can be delayed by using the <c>time</c> property of the
        /// <c>options</c> parameter.
        ///
        /// When using [<c>Note</c>]<see href="Note">Note</see> objects, the release velocity defined in the
        /// [<c>Note</c>]<see href="Note">Note</see> objects has precedence over the one specified via the method's <c>options</c>
        /// parameter.
        /// </summary>
        /// <param name="note">
        /// The note(s) to stop. The notes can be
        /// specified by using a MIDI note number (0-127), a note identifier (e.g. C3, G#4, F-1, Db7), a
        /// [<c>Note</c>]<see href="Note">Note</see> object or an array of the previous types. When using a note name, octave
        /// range must be between -1 and 9. The lowest note is C-1 (MIDI note number 0) and the highest
        /// note is G9 (MIDI note number 127).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member sendNoteOff: note: Webmidi.Note * ?options: OutputChannel.sendNoteOff.options -> Webmidi.OutputChannel
        /// <summary>
        /// Sends a **note off** message for the specified notes on the channel. The first parameter is the
        /// note. It can be a single value or an array of the following valid values:
        ///
        ///  - A MIDI note number (integer between <c>0</c> and <c>127</c>)
        ///  - A note name, followed by the octave (e.g. <c>"C3"</c>, <c>"G#4"</c>, <c>"F-1"</c>, <c>"Db7"</c>)
        ///  - A [<c>Note</c>]<see href="Note">Note</see> object
        ///
        /// The execution of the **note off** command can be delayed by using the <c>time</c> property of the
        /// <c>options</c> parameter.
        ///
        /// When using [<c>Note</c>]<see href="Note">Note</see> objects, the release velocity defined in the
        /// [<c>Note</c>]<see href="Note">Note</see> objects has precedence over the one specified via the method's <c>options</c>
        /// parameter.
        /// </summary>
        /// <param name="note">
        /// The note(s) to stop. The notes can be
        /// specified by using a MIDI note number (0-127), a note identifier (e.g. C3, G#4, F-1, Db7), a
        /// [<c>Note</c>]<see href="Note">Note</see> object or an array of the previous types. When using a note name, octave
        /// range must be between -1 and 9. The lowest note is C-1 (MIDI note number 0) and the highest
        /// note is G9 (MIDI note number 127).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member sendNoteOff: note: ResizeArray<float> * ?options: OutputChannel.sendNoteOff.options -> Webmidi.OutputChannel
        /// <summary>
        /// Sends a **note off** message for the specified notes on the channel. The first parameter is the
        /// note. It can be a single value or an array of the following valid values:
        ///
        ///  - A MIDI note number (integer between <c>0</c> and <c>127</c>)
        ///  - A note name, followed by the octave (e.g. <c>"C3"</c>, <c>"G#4"</c>, <c>"F-1"</c>, <c>"Db7"</c>)
        ///  - A [<c>Note</c>]<see href="Note">Note</see> object
        ///
        /// The execution of the **note off** command can be delayed by using the <c>time</c> property of the
        /// <c>options</c> parameter.
        ///
        /// When using [<c>Note</c>]<see href="Note">Note</see> objects, the release velocity defined in the
        /// [<c>Note</c>]<see href="Note">Note</see> objects has precedence over the one specified via the method's <c>options</c>
        /// parameter.
        /// </summary>
        /// <param name="note">
        /// The note(s) to stop. The notes can be
        /// specified by using a MIDI note number (0-127), a note identifier (e.g. C3, G#4, F-1, Db7), a
        /// [<c>Note</c>]<see href="Note">Note</see> object or an array of the previous types. When using a note name, octave
        /// range must be between -1 and 9. The lowest note is C-1 (MIDI note number 0) and the highest
        /// note is G9 (MIDI note number 127).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member sendNoteOff: note: ResizeArray<string> * ?options: OutputChannel.sendNoteOff.options -> Webmidi.OutputChannel
        /// <summary>
        /// Sends a **note off** message for the specified notes on the channel. The first parameter is the
        /// note. It can be a single value or an array of the following valid values:
        ///
        ///  - A MIDI note number (integer between <c>0</c> and <c>127</c>)
        ///  - A note name, followed by the octave (e.g. <c>"C3"</c>, <c>"G#4"</c>, <c>"F-1"</c>, <c>"Db7"</c>)
        ///  - A [<c>Note</c>]<see href="Note">Note</see> object
        ///
        /// The execution of the **note off** command can be delayed by using the <c>time</c> property of the
        /// <c>options</c> parameter.
        ///
        /// When using [<c>Note</c>]<see href="Note">Note</see> objects, the release velocity defined in the
        /// [<c>Note</c>]<see href="Note">Note</see> objects has precedence over the one specified via the method's <c>options</c>
        /// parameter.
        /// </summary>
        /// <param name="note">
        /// The note(s) to stop. The notes can be
        /// specified by using a MIDI note number (0-127), a note identifier (e.g. C3, G#4, F-1, Db7), a
        /// [<c>Note</c>]<see href="Note">Note</see> object or an array of the previous types. When using a note name, octave
        /// range must be between -1 and 9. The lowest note is C-1 (MIDI note number 0) and the highest
        /// note is G9 (MIDI note number 127).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member sendNoteOff: note: ResizeArray<Webmidi.Note> * ?options: OutputChannel.sendNoteOff.options -> Webmidi.OutputChannel
        /// <summary>
        /// Sends a **note off** message for the specified notes on the channel. The first parameter is the
        /// note. It can be a single value or an array of the following valid values:
        ///
        ///  - A MIDI note number (integer between <c>0</c> and <c>127</c>)
        ///  - A note name, followed by the octave (e.g. <c>"C3"</c>, <c>"G#4"</c>, <c>"F-1"</c>, <c>"Db7"</c>)
        ///  - A [<c>Note</c>]<see href="Note">Note</see> object
        ///
        /// The execution of the **note off** command can be delayed by using the <c>time</c> property of the
        /// <c>options</c> parameter.
        ///
        /// When using [<c>Note</c>]<see href="Note">Note</see> objects, the release velocity defined in the
        /// [<c>Note</c>]<see href="Note">Note</see> objects has precedence over the one specified via the method's <c>options</c>
        /// parameter.
        /// </summary>
        /// <param name="note">
        /// The note(s) to stop. The notes can be
        /// specified by using a MIDI note number (0-127), a note identifier (e.g. C3, G#4, F-1, Db7), a
        /// [<c>Note</c>]<see href="Note">Note</see> object or an array of the previous types. When using a note name, octave
        /// range must be between -1 and 9. The lowest note is C-1 (MIDI note number 0) and the highest
        /// note is G9 (MIDI note number 127).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member sendNoteOff: note: U6<float, string, Webmidi.Note, ResizeArray<float>, ResizeArray<string>, ResizeArray<Webmidi.Note>> * ?options: OutputChannel.sendNoteOff.options -> Webmidi.OutputChannel
        /// <summary>
        /// Sends a **note off** message for the specified MIDI note number. The first parameter is the
        /// note to stop. It can be a single value or an array of the following valid values:
        ///
        ///  - A MIDI note number (integer between <c>0</c> and <c>127</c>)
        ///  - A note identifier (e.g. <c>"C3"</c>, <c>"G#4"</c>, <c>"F-1"</c>, <c>"Db7"</c>)
        ///  - A [<c>Note</c>](Note) object
        ///
        /// The execution of the **note off** command can be delayed by using the <c>time</c> property of the
        /// <c>options</c> parameter.
        /// </summary>
        /// <param name="note">
        /// The note(s) to stop. The notes can be
        /// specified by using a MIDI note number (<c>0</c> - <c>127</c>), a note identifier (e.g. <c>C3</c>, <c>G#4</c>, <c>F-1</c>,
        /// <c>Db7</c>) or an array of the previous types. When using a note identifier, octave range must be
        /// between <c>-1</c> and <c>9</c>. The lowest note is <c>C-1</c> (MIDI note number <c>0</c>) and the highest note is
        /// <c>G9</c> (MIDI note number <c>127</c>).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member stopNote: note: float * ?options: OutputChannel.stopNote.options -> Webmidi.Output
        /// <summary>
        /// Sends a **note off** message for the specified MIDI note number. The first parameter is the
        /// note to stop. It can be a single value or an array of the following valid values:
        ///
        ///  - A MIDI note number (integer between <c>0</c> and <c>127</c>)
        ///  - A note identifier (e.g. <c>"C3"</c>, <c>"G#4"</c>, <c>"F-1"</c>, <c>"Db7"</c>)
        ///  - A [<c>Note</c>](Note) object
        ///
        /// The execution of the **note off** command can be delayed by using the <c>time</c> property of the
        /// <c>options</c> parameter.
        /// </summary>
        /// <param name="note">
        /// The note(s) to stop. The notes can be
        /// specified by using a MIDI note number (<c>0</c> - <c>127</c>), a note identifier (e.g. <c>C3</c>, <c>G#4</c>, <c>F-1</c>,
        /// <c>Db7</c>) or an array of the previous types. When using a note identifier, octave range must be
        /// between <c>-1</c> and <c>9</c>. The lowest note is <c>C-1</c> (MIDI note number <c>0</c>) and the highest note is
        /// <c>G9</c> (MIDI note number <c>127</c>).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member stopNote: note: Webmidi.Note * ?options: OutputChannel.stopNote.options -> Webmidi.Output
        /// <summary>
        /// Sends a **note off** message for the specified MIDI note number. The first parameter is the
        /// note to stop. It can be a single value or an array of the following valid values:
        ///
        ///  - A MIDI note number (integer between <c>0</c> and <c>127</c>)
        ///  - A note identifier (e.g. <c>"C3"</c>, <c>"G#4"</c>, <c>"F-1"</c>, <c>"Db7"</c>)
        ///  - A [<c>Note</c>](Note) object
        ///
        /// The execution of the **note off** command can be delayed by using the <c>time</c> property of the
        /// <c>options</c> parameter.
        /// </summary>
        /// <param name="note">
        /// The note(s) to stop. The notes can be
        /// specified by using a MIDI note number (<c>0</c> - <c>127</c>), a note identifier (e.g. <c>C3</c>, <c>G#4</c>, <c>F-1</c>,
        /// <c>Db7</c>) or an array of the previous types. When using a note identifier, octave range must be
        /// between <c>-1</c> and <c>9</c>. The lowest note is <c>C-1</c> (MIDI note number <c>0</c>) and the highest note is
        /// <c>G9</c> (MIDI note number <c>127</c>).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member stopNote: note: string * ?options: OutputChannel.stopNote.options -> Webmidi.Output
        /// <summary>
        /// Sends a **note off** message for the specified MIDI note number. The first parameter is the
        /// note to stop. It can be a single value or an array of the following valid values:
        ///
        ///  - A MIDI note number (integer between <c>0</c> and <c>127</c>)
        ///  - A note identifier (e.g. <c>"C3"</c>, <c>"G#4"</c>, <c>"F-1"</c>, <c>"Db7"</c>)
        ///  - A [<c>Note</c>](Note) object
        ///
        /// The execution of the **note off** command can be delayed by using the <c>time</c> property of the
        /// <c>options</c> parameter.
        /// </summary>
        /// <param name="note">
        /// The note(s) to stop. The notes can be
        /// specified by using a MIDI note number (<c>0</c> - <c>127</c>), a note identifier (e.g. <c>C3</c>, <c>G#4</c>, <c>F-1</c>,
        /// <c>Db7</c>) or an array of the previous types. When using a note identifier, octave range must be
        /// between <c>-1</c> and <c>9</c>. The lowest note is <c>C-1</c> (MIDI note number <c>0</c>) and the highest note is
        /// <c>G9</c> (MIDI note number <c>127</c>).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member stopNote: note: ResizeArray<float> * ?options: OutputChannel.stopNote.options -> Webmidi.Output
        /// <summary>
        /// Sends a **note off** message for the specified MIDI note number. The first parameter is the
        /// note to stop. It can be a single value or an array of the following valid values:
        ///
        ///  - A MIDI note number (integer between <c>0</c> and <c>127</c>)
        ///  - A note identifier (e.g. <c>"C3"</c>, <c>"G#4"</c>, <c>"F-1"</c>, <c>"Db7"</c>)
        ///  - A [<c>Note</c>](Note) object
        ///
        /// The execution of the **note off** command can be delayed by using the <c>time</c> property of the
        /// <c>options</c> parameter.
        /// </summary>
        /// <param name="note">
        /// The note(s) to stop. The notes can be
        /// specified by using a MIDI note number (<c>0</c> - <c>127</c>), a note identifier (e.g. <c>C3</c>, <c>G#4</c>, <c>F-1</c>,
        /// <c>Db7</c>) or an array of the previous types. When using a note identifier, octave range must be
        /// between <c>-1</c> and <c>9</c>. The lowest note is <c>C-1</c> (MIDI note number <c>0</c>) and the highest note is
        /// <c>G9</c> (MIDI note number <c>127</c>).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member stopNote: note: ResizeArray<Webmidi.Note> * ?options: OutputChannel.stopNote.options -> Webmidi.Output
        /// <summary>
        /// Sends a **note off** message for the specified MIDI note number. The first parameter is the
        /// note to stop. It can be a single value or an array of the following valid values:
        ///
        ///  - A MIDI note number (integer between <c>0</c> and <c>127</c>)
        ///  - A note identifier (e.g. <c>"C3"</c>, <c>"G#4"</c>, <c>"F-1"</c>, <c>"Db7"</c>)
        ///  - A [<c>Note</c>](Note) object
        ///
        /// The execution of the **note off** command can be delayed by using the <c>time</c> property of the
        /// <c>options</c> parameter.
        /// </summary>
        /// <param name="note">
        /// The note(s) to stop. The notes can be
        /// specified by using a MIDI note number (<c>0</c> - <c>127</c>), a note identifier (e.g. <c>C3</c>, <c>G#4</c>, <c>F-1</c>,
        /// <c>Db7</c>) or an array of the previous types. When using a note identifier, octave range must be
        /// between <c>-1</c> and <c>9</c>. The lowest note is <c>C-1</c> (MIDI note number <c>0</c>) and the highest note is
        /// <c>G9</c> (MIDI note number <c>127</c>).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member stopNote: note: ResizeArray<string> * ?options: OutputChannel.stopNote.options -> Webmidi.Output
        /// <summary>
        /// Sends a **note off** message for the specified MIDI note number. The first parameter is the
        /// note to stop. It can be a single value or an array of the following valid values:
        ///
        ///  - A MIDI note number (integer between <c>0</c> and <c>127</c>)
        ///  - A note identifier (e.g. <c>"C3"</c>, <c>"G#4"</c>, <c>"F-1"</c>, <c>"Db7"</c>)
        ///  - A [<c>Note</c>](Note) object
        ///
        /// The execution of the **note off** command can be delayed by using the <c>time</c> property of the
        /// <c>options</c> parameter.
        /// </summary>
        /// <param name="note">
        /// The note(s) to stop. The notes can be
        /// specified by using a MIDI note number (<c>0</c> - <c>127</c>), a note identifier (e.g. <c>C3</c>, <c>G#4</c>, <c>F-1</c>,
        /// <c>Db7</c>) or an array of the previous types. When using a note identifier, octave range must be
        /// between <c>-1</c> and <c>9</c>. The lowest note is <c>C-1</c> (MIDI note number <c>0</c>) and the highest note is
        /// <c>G9</c> (MIDI note number <c>127</c>).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>Output</c> object so methods can be chained.
        /// </returns>
        abstract member stopNote: note: U6<float, Webmidi.Note, string, ResizeArray<float>, ResizeArray<Webmidi.Note>, ResizeArray<string>> * ?options: OutputChannel.stopNote.options -> Webmidi.Output
        /// <summary>
        /// Sends a **note on** message for the specified note(s) on the channel. The first parameter is
        /// the note. It can be a single value or an array of the following valid values:
        ///
        ///  - A [<c>Note</c>]<see href="Note">Note</see> object
        ///  - A MIDI note number (integer between <c>0</c> and <c>127</c>)
        ///  - A note identifier (e.g. <c>"C3"</c>, <c>"G#4"</c>, <c>"F-1"</c>, <c>"Db7"</c>)
        ///
        ///  When passing a [<c>Note</c>]<see href="Note">Note</see>object or a note name, the <c>octaveOffset</c> will be applied.
        ///  This is not the case when using a note number. In this case, we assume you know exactly which
        ///  MIDI note number should be sent out.
        ///
        /// The execution of the **note on** command can be delayed by using the <c>time</c> property of the
        /// <c>options</c> parameter.
        ///
        /// When using [<c>Note</c>]<see href="Note">Note</see> objects, the attack velocity defined in the
        /// [<c>Note</c>]<see href="Note">Note</see> objects has precedence over the one specified via the method's <c>options</c>
        /// parameter. Also, the <c>duration</c> is ignored. If you want to also send a **note off** message,
        /// use the [<c>playNote()</c>]<see href="#playNote">#playNote</see> method instead.
        ///
        /// **Note**: As per the MIDI standard, a **note on** message with an attack velocity of <c>0</c> is
        /// functionally equivalent to a **note off** message.
        /// </summary>
        /// <param name="note">
        /// The note(s) to play. The notes can be
        /// specified by using a MIDI note number (0-127), a note identifier (e.g. C3, G#4, F-1, Db7), a
        /// [<c>Note</c>]<see href="Note">Note</see> object or an array of the previous types.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member sendNoteOn: note: float * ?options: OutputChannel.sendNoteOn.options -> Webmidi.OutputChannel
        /// <summary>
        /// Sends a **note on** message for the specified note(s) on the channel. The first parameter is
        /// the note. It can be a single value or an array of the following valid values:
        ///
        ///  - A [<c>Note</c>]<see href="Note">Note</see> object
        ///  - A MIDI note number (integer between <c>0</c> and <c>127</c>)
        ///  - A note identifier (e.g. <c>"C3"</c>, <c>"G#4"</c>, <c>"F-1"</c>, <c>"Db7"</c>)
        ///
        ///  When passing a [<c>Note</c>]<see href="Note">Note</see>object or a note name, the <c>octaveOffset</c> will be applied.
        ///  This is not the case when using a note number. In this case, we assume you know exactly which
        ///  MIDI note number should be sent out.
        ///
        /// The execution of the **note on** command can be delayed by using the <c>time</c> property of the
        /// <c>options</c> parameter.
        ///
        /// When using [<c>Note</c>]<see href="Note">Note</see> objects, the attack velocity defined in the
        /// [<c>Note</c>]<see href="Note">Note</see> objects has precedence over the one specified via the method's <c>options</c>
        /// parameter. Also, the <c>duration</c> is ignored. If you want to also send a **note off** message,
        /// use the [<c>playNote()</c>]<see href="#playNote">#playNote</see> method instead.
        ///
        /// **Note**: As per the MIDI standard, a **note on** message with an attack velocity of <c>0</c> is
        /// functionally equivalent to a **note off** message.
        /// </summary>
        /// <param name="note">
        /// The note(s) to play. The notes can be
        /// specified by using a MIDI note number (0-127), a note identifier (e.g. C3, G#4, F-1, Db7), a
        /// [<c>Note</c>]<see href="Note">Note</see> object or an array of the previous types.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member sendNoteOn: note: string * ?options: OutputChannel.sendNoteOn.options -> Webmidi.OutputChannel
        /// <summary>
        /// Sends a **note on** message for the specified note(s) on the channel. The first parameter is
        /// the note. It can be a single value or an array of the following valid values:
        ///
        ///  - A [<c>Note</c>]<see href="Note">Note</see> object
        ///  - A MIDI note number (integer between <c>0</c> and <c>127</c>)
        ///  - A note identifier (e.g. <c>"C3"</c>, <c>"G#4"</c>, <c>"F-1"</c>, <c>"Db7"</c>)
        ///
        ///  When passing a [<c>Note</c>]<see href="Note">Note</see>object or a note name, the <c>octaveOffset</c> will be applied.
        ///  This is not the case when using a note number. In this case, we assume you know exactly which
        ///  MIDI note number should be sent out.
        ///
        /// The execution of the **note on** command can be delayed by using the <c>time</c> property of the
        /// <c>options</c> parameter.
        ///
        /// When using [<c>Note</c>]<see href="Note">Note</see> objects, the attack velocity defined in the
        /// [<c>Note</c>]<see href="Note">Note</see> objects has precedence over the one specified via the method's <c>options</c>
        /// parameter. Also, the <c>duration</c> is ignored. If you want to also send a **note off** message,
        /// use the [<c>playNote()</c>]<see href="#playNote">#playNote</see> method instead.
        ///
        /// **Note**: As per the MIDI standard, a **note on** message with an attack velocity of <c>0</c> is
        /// functionally equivalent to a **note off** message.
        /// </summary>
        /// <param name="note">
        /// The note(s) to play. The notes can be
        /// specified by using a MIDI note number (0-127), a note identifier (e.g. C3, G#4, F-1, Db7), a
        /// [<c>Note</c>]<see href="Note">Note</see> object or an array of the previous types.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member sendNoteOn: note: Webmidi.Note * ?options: OutputChannel.sendNoteOn.options -> Webmidi.OutputChannel
        /// <summary>
        /// Sends a **note on** message for the specified note(s) on the channel. The first parameter is
        /// the note. It can be a single value or an array of the following valid values:
        ///
        ///  - A [<c>Note</c>]<see href="Note">Note</see> object
        ///  - A MIDI note number (integer between <c>0</c> and <c>127</c>)
        ///  - A note identifier (e.g. <c>"C3"</c>, <c>"G#4"</c>, <c>"F-1"</c>, <c>"Db7"</c>)
        ///
        ///  When passing a [<c>Note</c>]<see href="Note">Note</see>object or a note name, the <c>octaveOffset</c> will be applied.
        ///  This is not the case when using a note number. In this case, we assume you know exactly which
        ///  MIDI note number should be sent out.
        ///
        /// The execution of the **note on** command can be delayed by using the <c>time</c> property of the
        /// <c>options</c> parameter.
        ///
        /// When using [<c>Note</c>]<see href="Note">Note</see> objects, the attack velocity defined in the
        /// [<c>Note</c>]<see href="Note">Note</see> objects has precedence over the one specified via the method's <c>options</c>
        /// parameter. Also, the <c>duration</c> is ignored. If you want to also send a **note off** message,
        /// use the [<c>playNote()</c>]<see href="#playNote">#playNote</see> method instead.
        ///
        /// **Note**: As per the MIDI standard, a **note on** message with an attack velocity of <c>0</c> is
        /// functionally equivalent to a **note off** message.
        /// </summary>
        /// <param name="note">
        /// The note(s) to play. The notes can be
        /// specified by using a MIDI note number (0-127), a note identifier (e.g. C3, G#4, F-1, Db7), a
        /// [<c>Note</c>]<see href="Note">Note</see> object or an array of the previous types.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member sendNoteOn: note: ResizeArray<float> * ?options: OutputChannel.sendNoteOn.options -> Webmidi.OutputChannel
        /// <summary>
        /// Sends a **note on** message for the specified note(s) on the channel. The first parameter is
        /// the note. It can be a single value or an array of the following valid values:
        ///
        ///  - A [<c>Note</c>]<see href="Note">Note</see> object
        ///  - A MIDI note number (integer between <c>0</c> and <c>127</c>)
        ///  - A note identifier (e.g. <c>"C3"</c>, <c>"G#4"</c>, <c>"F-1"</c>, <c>"Db7"</c>)
        ///
        ///  When passing a [<c>Note</c>]<see href="Note">Note</see>object or a note name, the <c>octaveOffset</c> will be applied.
        ///  This is not the case when using a note number. In this case, we assume you know exactly which
        ///  MIDI note number should be sent out.
        ///
        /// The execution of the **note on** command can be delayed by using the <c>time</c> property of the
        /// <c>options</c> parameter.
        ///
        /// When using [<c>Note</c>]<see href="Note">Note</see> objects, the attack velocity defined in the
        /// [<c>Note</c>]<see href="Note">Note</see> objects has precedence over the one specified via the method's <c>options</c>
        /// parameter. Also, the <c>duration</c> is ignored. If you want to also send a **note off** message,
        /// use the [<c>playNote()</c>]<see href="#playNote">#playNote</see> method instead.
        ///
        /// **Note**: As per the MIDI standard, a **note on** message with an attack velocity of <c>0</c> is
        /// functionally equivalent to a **note off** message.
        /// </summary>
        /// <param name="note">
        /// The note(s) to play. The notes can be
        /// specified by using a MIDI note number (0-127), a note identifier (e.g. C3, G#4, F-1, Db7), a
        /// [<c>Note</c>]<see href="Note">Note</see> object or an array of the previous types.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member sendNoteOn: note: ResizeArray<string> * ?options: OutputChannel.sendNoteOn.options -> Webmidi.OutputChannel
        /// <summary>
        /// Sends a **note on** message for the specified note(s) on the channel. The first parameter is
        /// the note. It can be a single value or an array of the following valid values:
        ///
        ///  - A [<c>Note</c>]<see href="Note">Note</see> object
        ///  - A MIDI note number (integer between <c>0</c> and <c>127</c>)
        ///  - A note identifier (e.g. <c>"C3"</c>, <c>"G#4"</c>, <c>"F-1"</c>, <c>"Db7"</c>)
        ///
        ///  When passing a [<c>Note</c>]<see href="Note">Note</see>object or a note name, the <c>octaveOffset</c> will be applied.
        ///  This is not the case when using a note number. In this case, we assume you know exactly which
        ///  MIDI note number should be sent out.
        ///
        /// The execution of the **note on** command can be delayed by using the <c>time</c> property of the
        /// <c>options</c> parameter.
        ///
        /// When using [<c>Note</c>]<see href="Note">Note</see> objects, the attack velocity defined in the
        /// [<c>Note</c>]<see href="Note">Note</see> objects has precedence over the one specified via the method's <c>options</c>
        /// parameter. Also, the <c>duration</c> is ignored. If you want to also send a **note off** message,
        /// use the [<c>playNote()</c>]<see href="#playNote">#playNote</see> method instead.
        ///
        /// **Note**: As per the MIDI standard, a **note on** message with an attack velocity of <c>0</c> is
        /// functionally equivalent to a **note off** message.
        /// </summary>
        /// <param name="note">
        /// The note(s) to play. The notes can be
        /// specified by using a MIDI note number (0-127), a note identifier (e.g. C3, G#4, F-1, Db7), a
        /// [<c>Note</c>]<see href="Note">Note</see> object or an array of the previous types.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member sendNoteOn: note: ResizeArray<Webmidi.Note> * ?options: OutputChannel.sendNoteOn.options -> Webmidi.OutputChannel
        /// <summary>
        /// Sends a **note on** message for the specified note(s) on the channel. The first parameter is
        /// the note. It can be a single value or an array of the following valid values:
        ///
        ///  - A [<c>Note</c>]<see href="Note">Note</see> object
        ///  - A MIDI note number (integer between <c>0</c> and <c>127</c>)
        ///  - A note identifier (e.g. <c>"C3"</c>, <c>"G#4"</c>, <c>"F-1"</c>, <c>"Db7"</c>)
        ///
        ///  When passing a [<c>Note</c>]<see href="Note">Note</see>object or a note name, the <c>octaveOffset</c> will be applied.
        ///  This is not the case when using a note number. In this case, we assume you know exactly which
        ///  MIDI note number should be sent out.
        ///
        /// The execution of the **note on** command can be delayed by using the <c>time</c> property of the
        /// <c>options</c> parameter.
        ///
        /// When using [<c>Note</c>]<see href="Note">Note</see> objects, the attack velocity defined in the
        /// [<c>Note</c>]<see href="Note">Note</see> objects has precedence over the one specified via the method's <c>options</c>
        /// parameter. Also, the <c>duration</c> is ignored. If you want to also send a **note off** message,
        /// use the [<c>playNote()</c>]<see href="#playNote">#playNote</see> method instead.
        ///
        /// **Note**: As per the MIDI standard, a **note on** message with an attack velocity of <c>0</c> is
        /// functionally equivalent to a **note off** message.
        /// </summary>
        /// <param name="note">
        /// The note(s) to play. The notes can be
        /// specified by using a MIDI note number (0-127), a note identifier (e.g. C3, G#4, F-1, Db7), a
        /// [<c>Note</c>]<see href="Note">Note</see> object or an array of the previous types.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member sendNoteOn: note: U6<float, string, Webmidi.Note, ResizeArray<float>, ResizeArray<string>, ResizeArray<Webmidi.Note>> * ?options: OutputChannel.sendNoteOn.options -> Webmidi.OutputChannel
        /// <summary>
        /// Sends a MIDI **channel mode** message. The channel mode message to send can be specified
        /// numerically or by using one of the following common names:
        ///
        /// |  Type                |Number| Shortcut Method                                               |
        /// | ---------------------|------|-------------------------------------------------------------- |
        /// | <c>allsoundoff</c>        | 120  | [<c>sendAllSoundOff()</c>]<see href="#sendAllSoundOff">#sendAllSoundOff</see>                 |
        /// | <c>resetallcontrollers</c>| 121  | [<c>sendResetAllControllers()</c>]<see href="#sendResetAllControllers">#sendResetAllControllers</see> |
        /// | <c>localcontrol</c>       | 122  | [<c>sendLocalControl()</c>]<see href="#sendLocalControl">#sendLocalControl</see>               |
        /// | <c>allnotesoff</c>        | 123  | [<c>sendAllNotesOff()</c>]<see href="#sendAllNotesOff">#sendAllNotesOff</see>                 |
        /// | <c>omnimodeoff</c>        | 124  | [<c>sendOmniMode(false)</c>]<see href="#sendOmniMode">#sendOmniMode</see>                  |
        /// | <c>omnimodeon</c>         | 125  | [<c>sendOmniMode(true)</c>]<see href="#sendOmniMode">#sendOmniMode</see>                   |
        /// | <c>monomodeon</c>         | 126  | [<c>sendPolyphonicMode("mono")</c>]<see href="#sendPolyphonicMode">#sendPolyphonicMode</see>     |
        /// | <c>polymodeon</c>         | 127  | [<c>sendPolyphonicMode("poly")</c>]<see href="#sendPolyphonicMode">#sendPolyphonicMode</see>     |
        ///
        /// **Note**: as you can see above, to make it easier, all channel mode messages also have a matching
        /// helper method.
        ///
        /// It should be noted that, per the MIDI specification, only <c>localcontrol</c> and <c>monomodeon</c> may
        /// require a value that's not zero. For that reason, the <c>value</c> parameter is optional and
        /// defaults to 0.
        /// </summary>
        /// <param name="command">
        /// The numerical identifier of the channel mode message (integer
        /// between <c>120</c> and <c>127</c>) or its name as a string.
        /// </param>
        /// <param name="value">
        /// The value to send (integer between <c>0</c> - <c>127</c>).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member sendChannelMode: command: float * ?value: float * ?options: OutputChannel.sendChannelMode.options -> Webmidi.OutputChannel
        /// <summary>
        /// Sends a MIDI **channel mode** message. The channel mode message to send can be specified
        /// numerically or by using one of the following common names:
        ///
        /// |  Type                |Number| Shortcut Method                                               |
        /// | ---------------------|------|-------------------------------------------------------------- |
        /// | <c>allsoundoff</c>        | 120  | [<c>sendAllSoundOff()</c>]<see href="#sendAllSoundOff">#sendAllSoundOff</see>                 |
        /// | <c>resetallcontrollers</c>| 121  | [<c>sendResetAllControllers()</c>]<see href="#sendResetAllControllers">#sendResetAllControllers</see> |
        /// | <c>localcontrol</c>       | 122  | [<c>sendLocalControl()</c>]<see href="#sendLocalControl">#sendLocalControl</see>               |
        /// | <c>allnotesoff</c>        | 123  | [<c>sendAllNotesOff()</c>]<see href="#sendAllNotesOff">#sendAllNotesOff</see>                 |
        /// | <c>omnimodeoff</c>        | 124  | [<c>sendOmniMode(false)</c>]<see href="#sendOmniMode">#sendOmniMode</see>                  |
        /// | <c>omnimodeon</c>         | 125  | [<c>sendOmniMode(true)</c>]<see href="#sendOmniMode">#sendOmniMode</see>                   |
        /// | <c>monomodeon</c>         | 126  | [<c>sendPolyphonicMode("mono")</c>]<see href="#sendPolyphonicMode">#sendPolyphonicMode</see>     |
        /// | <c>polymodeon</c>         | 127  | [<c>sendPolyphonicMode("poly")</c>]<see href="#sendPolyphonicMode">#sendPolyphonicMode</see>     |
        ///
        /// **Note**: as you can see above, to make it easier, all channel mode messages also have a matching
        /// helper method.
        ///
        /// It should be noted that, per the MIDI specification, only <c>localcontrol</c> and <c>monomodeon</c> may
        /// require a value that's not zero. For that reason, the <c>value</c> parameter is optional and
        /// defaults to 0.
        /// </summary>
        /// <param name="command">
        /// The numerical identifier of the channel mode message (integer
        /// between <c>120</c> and <c>127</c>) or its name as a string.
        /// </param>
        /// <param name="value">
        /// The value to send (integer between <c>0</c> - <c>127</c>).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member sendChannelMode: command: string * ?value: float * ?options: OutputChannel.sendChannelMode.options -> Webmidi.OutputChannel
        /// <summary>
        /// Sends a MIDI **channel mode** message. The channel mode message to send can be specified
        /// numerically or by using one of the following common names:
        ///
        /// |  Type                |Number| Shortcut Method                                               |
        /// | ---------------------|------|-------------------------------------------------------------- |
        /// | <c>allsoundoff</c>        | 120  | [<c>sendAllSoundOff()</c>]<see href="#sendAllSoundOff">#sendAllSoundOff</see>                 |
        /// | <c>resetallcontrollers</c>| 121  | [<c>sendResetAllControllers()</c>]<see href="#sendResetAllControllers">#sendResetAllControllers</see> |
        /// | <c>localcontrol</c>       | 122  | [<c>sendLocalControl()</c>]<see href="#sendLocalControl">#sendLocalControl</see>               |
        /// | <c>allnotesoff</c>        | 123  | [<c>sendAllNotesOff()</c>]<see href="#sendAllNotesOff">#sendAllNotesOff</see>                 |
        /// | <c>omnimodeoff</c>        | 124  | [<c>sendOmniMode(false)</c>]<see href="#sendOmniMode">#sendOmniMode</see>                  |
        /// | <c>omnimodeon</c>         | 125  | [<c>sendOmniMode(true)</c>]<see href="#sendOmniMode">#sendOmniMode</see>                   |
        /// | <c>monomodeon</c>         | 126  | [<c>sendPolyphonicMode("mono")</c>]<see href="#sendPolyphonicMode">#sendPolyphonicMode</see>     |
        /// | <c>polymodeon</c>         | 127  | [<c>sendPolyphonicMode("poly")</c>]<see href="#sendPolyphonicMode">#sendPolyphonicMode</see>     |
        ///
        /// **Note**: as you can see above, to make it easier, all channel mode messages also have a matching
        /// helper method.
        ///
        /// It should be noted that, per the MIDI specification, only <c>localcontrol</c> and <c>monomodeon</c> may
        /// require a value that's not zero. For that reason, the <c>value</c> parameter is optional and
        /// defaults to 0.
        /// </summary>
        /// <param name="command">
        /// The numerical identifier of the channel mode message (integer
        /// between <c>120</c> and <c>127</c>) or its name as a string.
        /// </param>
        /// <param name="value">
        /// The value to send (integer between <c>0</c> - <c>127</c>).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member sendChannelMode: command: U2<float, string> * ?value: float * ?options: OutputChannel.sendChannelMode.options -> Webmidi.OutputChannel
        /// <summary>
        /// Sets OMNI mode to <c>"on"</c> or <c>"off"</c>. MIDI's OMNI mode causes the instrument to respond to
        /// messages from all channels.
        ///
        /// It should be noted that support for OMNI mode is not as common as it used to be.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// Invalid channel mode message name.
        ///
        /// Channel mode controller numbers must be between 120 and 127.
        ///
        /// Value must be an integer between 0 and 127.
        /// </remarks>
        /// <param name="state">
        /// Whether to activate OMNI mode (<c>true</c>) or not (<c>false</c>).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member sendOmniMode: ?state: bool * ?options: OutputChannel.sendOmniMode.options -> Webmidi.OutputChannel
        /// <summary>
        /// Sends a MIDI **channel aftertouch** message. For key-specific aftertouch, you should instead
        /// use [<c>sendKeyAftertouch()</c>]<see href="#sendKeyAftertouch">#sendKeyAftertouch</see>.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// RangeError Invalid channel aftertouch value.
        /// </remarks>
        /// <param name="pressure">
        /// The pressure level (between <c>0</c> and <c>1</c>). If the <c>rawValue</c> option
        /// is set to <c>true</c>, the pressure can be defined by using an integer between <c>0</c> and <c>127</c>.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member sendChannelAftertouch: ?pressure: float * ?options: OutputChannel.sendChannelAftertouch.options -> Webmidi.OutputChannel
        /// <summary>
        /// Sends a **master tuning** message. The value is decimal and must be larger than -65 semitones
        /// and smaller than 64 semitones.
        ///
        /// Because of the way the MIDI specification works, the decimal portion of the value will be
        /// encoded with a resolution of 14bit. The integer portion must be between -64 and 63
        /// inclusively. This function actually generates two MIDI messages: a **Master Coarse Tuning** and
        /// a **Master Fine Tuning** RPN messages.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// The value must be a decimal number between larger than -65 and smaller
        /// than 64.
        /// </remarks>
        /// <param name="value">
        /// The desired decimal adjustment value in semitones (-65 < x < 64)
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member sendMasterTuning: ?value: float * ?options: OutputChannel.sendMasterTuning.options -> Webmidi.OutputChannel
        /// <summary>
        /// Sends a **modulation depth range** message to adjust the depth of the modulation wheel's range.
        /// The range can be specified with the <c>semitones</c> parameter, the <c>cents</c> parameter or by
        /// specifying both parameters at the same time.
        /// </summary>
        /// <param name="semitones">
        /// The desired adjustment value in semitones (integer between 0 and
        /// 127).
        /// </param>
        /// <param name="cents">
        /// The desired adjustment value in cents (integer between 0 and 127).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member sendModulationRange: semitones: float * ?cents: float * ?options: OutputChannel.sendModulationRange.options -> Webmidi.OutputChannel
        /// <summary>
        /// Sets a non-registered parameter (NRPN) to the specified value. The NRPN is selected by passing
        /// in a two-position array specifying the values of the two control bytes. The value is specified
        /// by passing in a single integer (most cases) or an array of two integers.
        ///
        /// NRPNs are not standardized in any way. Each manufacturer is free to implement them any way
        /// they see fit. For example, according to the Roland GS specification, you can control the
        /// **vibrato rate** using NRPN (1, 8). Therefore, to set the **vibrato rate** value to **123** you
        /// would use:
        ///
        /// <code lang="js">
        /// WebMidi.outputs[0].channels[0].sendNrpnValue([1, 8], 123);
        /// </code>
        ///
        /// In some rarer cases, you need to send two values with your NRPN messages. In such cases, you
        /// would use a 2-position array. For example, for its **ClockBPM** parameter (2, 63), Novation
        /// uses a 14-bit value that combines an MSB and an LSB (7-bit values). So, for example, if the
        /// value to send was 10, you could use:
        ///
        /// <code lang="js">
        /// WebMidi.outputs[0].channels[0].sendNrpnValue([2, 63], [0, 10]);
        /// </code>
        ///
        /// For further implementation details, refer to the manufacturer's documentation.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// The control value must be between 0 and 127.
        ///
        /// The msb value must be between 0 and 127
        /// </remarks>
        /// <param name="nrpn">
        /// A two-position array specifying the two control bytes (0x63,
        /// 0x62) that identify the non-registered parameter.
        /// </param>
        /// <param name="data">
        /// An integer or an array of integers with a length of 1 or 2
        /// specifying the desired data.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member sendNrpnValue: nrpn: ResizeArray<float> -> Webmidi.OutputChannel
        /// <summary>
        /// Sets a non-registered parameter (NRPN) to the specified value. The NRPN is selected by passing
        /// in a two-position array specifying the values of the two control bytes. The value is specified
        /// by passing in a single integer (most cases) or an array of two integers.
        ///
        /// NRPNs are not standardized in any way. Each manufacturer is free to implement them any way
        /// they see fit. For example, according to the Roland GS specification, you can control the
        /// **vibrato rate** using NRPN (1, 8). Therefore, to set the **vibrato rate** value to **123** you
        /// would use:
        ///
        /// <code lang="js">
        /// WebMidi.outputs[0].channels[0].sendNrpnValue([1, 8], 123);
        /// </code>
        ///
        /// In some rarer cases, you need to send two values with your NRPN messages. In such cases, you
        /// would use a 2-position array. For example, for its **ClockBPM** parameter (2, 63), Novation
        /// uses a 14-bit value that combines an MSB and an LSB (7-bit values). So, for example, if the
        /// value to send was 10, you could use:
        ///
        /// <code lang="js">
        /// WebMidi.outputs[0].channels[0].sendNrpnValue([2, 63], [0, 10]);
        /// </code>
        ///
        /// For further implementation details, refer to the manufacturer's documentation.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// The control value must be between 0 and 127.
        ///
        /// The msb value must be between 0 and 127
        /// </remarks>
        /// <param name="nrpn">
        /// A two-position array specifying the two control bytes (0x63,
        /// 0x62) that identify the non-registered parameter.
        /// </param>
        /// <param name="data">
        /// An integer or an array of integers with a length of 1 or 2
        /// specifying the desired data.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member sendNrpnValue: nrpn: ResizeArray<float> * data: float * ?options: OutputChannel.sendNrpnValue.options -> Webmidi.OutputChannel
        /// <summary>
        /// Sets a non-registered parameter (NRPN) to the specified value. The NRPN is selected by passing
        /// in a two-position array specifying the values of the two control bytes. The value is specified
        /// by passing in a single integer (most cases) or an array of two integers.
        ///
        /// NRPNs are not standardized in any way. Each manufacturer is free to implement them any way
        /// they see fit. For example, according to the Roland GS specification, you can control the
        /// **vibrato rate** using NRPN (1, 8). Therefore, to set the **vibrato rate** value to **123** you
        /// would use:
        ///
        /// <code lang="js">
        /// WebMidi.outputs[0].channels[0].sendNrpnValue([1, 8], 123);
        /// </code>
        ///
        /// In some rarer cases, you need to send two values with your NRPN messages. In such cases, you
        /// would use a 2-position array. For example, for its **ClockBPM** parameter (2, 63), Novation
        /// uses a 14-bit value that combines an MSB and an LSB (7-bit values). So, for example, if the
        /// value to send was 10, you could use:
        ///
        /// <code lang="js">
        /// WebMidi.outputs[0].channels[0].sendNrpnValue([2, 63], [0, 10]);
        /// </code>
        ///
        /// For further implementation details, refer to the manufacturer's documentation.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// The control value must be between 0 and 127.
        ///
        /// The msb value must be between 0 and 127
        /// </remarks>
        /// <param name="nrpn">
        /// A two-position array specifying the two control bytes (0x63,
        /// 0x62) that identify the non-registered parameter.
        /// </param>
        /// <param name="data">
        /// An integer or an array of integers with a length of 1 or 2
        /// specifying the desired data.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member sendNrpnValue: nrpn: ResizeArray<float> * data: ResizeArray<float> * ?options: OutputChannel.sendNrpnValue.options -> Webmidi.OutputChannel
        /// <summary>
        /// Sends a MIDI **pitch bend** message at the scheduled time. The resulting bend is relative to
        /// the pitch bend range that has been defined. The range can be set with
        /// [<c>sendPitchBendRange()</c>]<see href="#sendPitchBendRange">#sendPitchBendRange</see>. So, for example, if the pitch
        /// bend range has been set to 12 semitones, using a bend value of -1 will bend the note 1 octave
        /// below its nominal value.
        /// </summary>
        /// <param name="value">
        /// The intensity of the bend (between -1.0 and 1.0). A value of
        /// zero means no bend. If the <c>rawValue</c> option is set to <c>true</c>, the intensity of the bend can be
        /// defined by either using a single integer between 0 and 127 (MSB) or an array of two integers
        /// between 0 and 127 representing, respectively, the MSB (most significant byte) and the LSB
        /// (least significant byte). The MSB is expressed in semitones with <c>64</c> meaning no bend. A value
        /// lower than <c>64</c> bends downwards while a value higher than <c>64</c> bends upwards. The LSB is
        /// expressed in cents (1/100 of a semitone). An LSB of <c>64</c> also means no bend.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member sendPitchBend: unit -> Webmidi.OutputChannel
        /// <summary>
        /// Sends a MIDI **pitch bend** message at the scheduled time. The resulting bend is relative to
        /// the pitch bend range that has been defined. The range can be set with
        /// [<c>sendPitchBendRange()</c>]<see href="#sendPitchBendRange">#sendPitchBendRange</see>. So, for example, if the pitch
        /// bend range has been set to 12 semitones, using a bend value of -1 will bend the note 1 octave
        /// below its nominal value.
        /// </summary>
        /// <param name="value">
        /// The intensity of the bend (between -1.0 and 1.0). A value of
        /// zero means no bend. If the <c>rawValue</c> option is set to <c>true</c>, the intensity of the bend can be
        /// defined by either using a single integer between 0 and 127 (MSB) or an array of two integers
        /// between 0 and 127 representing, respectively, the MSB (most significant byte) and the LSB
        /// (least significant byte). The MSB is expressed in semitones with <c>64</c> meaning no bend. A value
        /// lower than <c>64</c> bends downwards while a value higher than <c>64</c> bends upwards. The LSB is
        /// expressed in cents (1/100 of a semitone). An LSB of <c>64</c> also means no bend.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member sendPitchBend: value: float * ?options: OutputChannel.sendPitchBend.options -> Webmidi.OutputChannel
        /// <summary>
        /// Sends a MIDI **pitch bend** message at the scheduled time. The resulting bend is relative to
        /// the pitch bend range that has been defined. The range can be set with
        /// [<c>sendPitchBendRange()</c>]<see href="#sendPitchBendRange">#sendPitchBendRange</see>. So, for example, if the pitch
        /// bend range has been set to 12 semitones, using a bend value of -1 will bend the note 1 octave
        /// below its nominal value.
        /// </summary>
        /// <param name="value">
        /// The intensity of the bend (between -1.0 and 1.0). A value of
        /// zero means no bend. If the <c>rawValue</c> option is set to <c>true</c>, the intensity of the bend can be
        /// defined by either using a single integer between 0 and 127 (MSB) or an array of two integers
        /// between 0 and 127 representing, respectively, the MSB (most significant byte) and the LSB
        /// (least significant byte). The MSB is expressed in semitones with <c>64</c> meaning no bend. A value
        /// lower than <c>64</c> bends downwards while a value higher than <c>64</c> bends upwards. The LSB is
        /// expressed in cents (1/100 of a semitone). An LSB of <c>64</c> also means no bend.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member sendPitchBend: value: ResizeArray<float> * ?options: OutputChannel.sendPitchBend.options -> Webmidi.OutputChannel
        /// <summary>
        /// Sends a **pitch bend range** message at the scheduled time to adjust the range used by the
        /// pitch bend lever. The range is specified by using the <c>semitones</c> and <c>cents</c> parameters. For
        /// example, setting the <c>semitones</c> parameter to <c>12</c> means that the pitch bend range will be 12
        /// semitones above and below the nominal pitch.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// The semitones value must be an integer between 0 and 127.
        ///
        /// The cents value must be an integer between 0 and 127.
        /// </remarks>
        /// <param name="semitones">
        /// The desired adjustment value in semitones (between 0 and 127). While
        /// nothing imposes that in the specification, it is very common for manufacturers to limit the
        /// range to 2 octaves (-12 semitones to 12 semitones).
        /// </param>
        /// <param name="cents">
        /// The desired adjustment value in cents (integer between 0-127).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member sendPitchBendRange: semitones: float * ?cents: float * ?options: OutputChannel.sendPitchBendRange.options -> Webmidi.OutputChannel
        /// <summary>
        /// Sends a MIDI **program change** message at the scheduled time.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// Failed to execute 'send' on 'MIDIOutput': The value at index 1 is greater
        /// than 0xFF.
        /// </remarks>
        /// <param name="program">
        /// The MIDI patch (program) number (integer between <c>0</c> and <c>127</c>).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member sendProgramChange: ?program: float * ?options: OutputChannel.sendProgramChange.options -> Webmidi.OutputChannel
        /// <summary>
        /// Sets the specified MIDI registered parameter to the desired value. The value is defined with
        /// up to two bytes of data (msb, lsb) that each can go from 0 to 127.
        ///
        /// MIDI
        /// [registered parameters](https://www.midi.org/specifications-old/item/table-3-control-change-messages-data-bytes-2)
        /// extend the original list of control change messages. The MIDI 1.0 specification lists only a
        /// limited number of them:
        ///
        /// | Numbers      | Function                 |
        /// |--------------|--------------------------|
        /// | (0x00, 0x00) | <c>pitchbendrange</c>         |
        /// | (0x00, 0x01) | <c>channelfinetuning</c>      |
        /// | (0x00, 0x02) | <c>channelcoarsetuning</c>    |
        /// | (0x00, 0x03) | <c>tuningprogram</c>          |
        /// | (0x00, 0x04) | <c>tuningbank</c>             |
        /// | (0x00, 0x05) | <c>modulationrange</c>        |
        /// | (0x3D, 0x00) | <c>azimuthangle</c>           |
        /// | (0x3D, 0x01) | <c>elevationangle</c>         |
        /// | (0x3D, 0x02) | <c>gain</c>                   |
        /// | (0x3D, 0x03) | <c>distanceratio</c>          |
        /// | (0x3D, 0x04) | <c>maximumdistance</c>        |
        /// | (0x3D, 0x05) | <c>maximumdistancegain</c>    |
        /// | (0x3D, 0x06) | <c>referencedistanceratio</c> |
        /// | (0x3D, 0x07) | <c>panspreadangle</c>         |
        /// | (0x3D, 0x08) | <c>rollangle</c>              |
        ///
        /// Note that the **Tuning Program** and **Tuning Bank** parameters are part of the *MIDI Tuning
        /// Standard*, which is not widely implemented.
        /// </summary>
        /// <param name="rpn">
        /// A string identifying the parameter's name (see above) or a
        /// two-position array specifying the two control bytes (e.g. <c>[0x65, 0x64]</c>) that identify the
        /// registered parameter.
        /// </param>
        /// <param name="data">
        /// An single integer or an array of integers with a maximum
        /// length of 2 specifying the desired data.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member sendRpnValue: rpn: string -> Webmidi.OutputChannel
        /// <summary>
        /// Sets the specified MIDI registered parameter to the desired value. The value is defined with
        /// up to two bytes of data (msb, lsb) that each can go from 0 to 127.
        ///
        /// MIDI
        /// [registered parameters](https://www.midi.org/specifications-old/item/table-3-control-change-messages-data-bytes-2)
        /// extend the original list of control change messages. The MIDI 1.0 specification lists only a
        /// limited number of them:
        ///
        /// | Numbers      | Function                 |
        /// |--------------|--------------------------|
        /// | (0x00, 0x00) | <c>pitchbendrange</c>         |
        /// | (0x00, 0x01) | <c>channelfinetuning</c>      |
        /// | (0x00, 0x02) | <c>channelcoarsetuning</c>    |
        /// | (0x00, 0x03) | <c>tuningprogram</c>          |
        /// | (0x00, 0x04) | <c>tuningbank</c>             |
        /// | (0x00, 0x05) | <c>modulationrange</c>        |
        /// | (0x3D, 0x00) | <c>azimuthangle</c>           |
        /// | (0x3D, 0x01) | <c>elevationangle</c>         |
        /// | (0x3D, 0x02) | <c>gain</c>                   |
        /// | (0x3D, 0x03) | <c>distanceratio</c>          |
        /// | (0x3D, 0x04) | <c>maximumdistance</c>        |
        /// | (0x3D, 0x05) | <c>maximumdistancegain</c>    |
        /// | (0x3D, 0x06) | <c>referencedistanceratio</c> |
        /// | (0x3D, 0x07) | <c>panspreadangle</c>         |
        /// | (0x3D, 0x08) | <c>rollangle</c>              |
        ///
        /// Note that the **Tuning Program** and **Tuning Bank** parameters are part of the *MIDI Tuning
        /// Standard*, which is not widely implemented.
        /// </summary>
        /// <param name="rpn">
        /// A string identifying the parameter's name (see above) or a
        /// two-position array specifying the two control bytes (e.g. <c>[0x65, 0x64]</c>) that identify the
        /// registered parameter.
        /// </param>
        /// <param name="data">
        /// An single integer or an array of integers with a maximum
        /// length of 2 specifying the desired data.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member sendRpnValue: rpn: string * data: float * ?options: OutputChannel.sendRpnValue.options -> Webmidi.OutputChannel
        /// <summary>
        /// Sets the specified MIDI registered parameter to the desired value. The value is defined with
        /// up to two bytes of data (msb, lsb) that each can go from 0 to 127.
        ///
        /// MIDI
        /// [registered parameters](https://www.midi.org/specifications-old/item/table-3-control-change-messages-data-bytes-2)
        /// extend the original list of control change messages. The MIDI 1.0 specification lists only a
        /// limited number of them:
        ///
        /// | Numbers      | Function                 |
        /// |--------------|--------------------------|
        /// | (0x00, 0x00) | <c>pitchbendrange</c>         |
        /// | (0x00, 0x01) | <c>channelfinetuning</c>      |
        /// | (0x00, 0x02) | <c>channelcoarsetuning</c>    |
        /// | (0x00, 0x03) | <c>tuningprogram</c>          |
        /// | (0x00, 0x04) | <c>tuningbank</c>             |
        /// | (0x00, 0x05) | <c>modulationrange</c>        |
        /// | (0x3D, 0x00) | <c>azimuthangle</c>           |
        /// | (0x3D, 0x01) | <c>elevationangle</c>         |
        /// | (0x3D, 0x02) | <c>gain</c>                   |
        /// | (0x3D, 0x03) | <c>distanceratio</c>          |
        /// | (0x3D, 0x04) | <c>maximumdistance</c>        |
        /// | (0x3D, 0x05) | <c>maximumdistancegain</c>    |
        /// | (0x3D, 0x06) | <c>referencedistanceratio</c> |
        /// | (0x3D, 0x07) | <c>panspreadangle</c>         |
        /// | (0x3D, 0x08) | <c>rollangle</c>              |
        ///
        /// Note that the **Tuning Program** and **Tuning Bank** parameters are part of the *MIDI Tuning
        /// Standard*, which is not widely implemented.
        /// </summary>
        /// <param name="rpn">
        /// A string identifying the parameter's name (see above) or a
        /// two-position array specifying the two control bytes (e.g. <c>[0x65, 0x64]</c>) that identify the
        /// registered parameter.
        /// </param>
        /// <param name="data">
        /// An single integer or an array of integers with a maximum
        /// length of 2 specifying the desired data.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member sendRpnValue: rpn: string * data: ResizeArray<float> * ?options: OutputChannel.sendRpnValue.options -> Webmidi.OutputChannel
        /// <summary>
        /// Sets the specified MIDI registered parameter to the desired value. The value is defined with
        /// up to two bytes of data (msb, lsb) that each can go from 0 to 127.
        ///
        /// MIDI
        /// [registered parameters](https://www.midi.org/specifications-old/item/table-3-control-change-messages-data-bytes-2)
        /// extend the original list of control change messages. The MIDI 1.0 specification lists only a
        /// limited number of them:
        ///
        /// | Numbers      | Function                 |
        /// |--------------|--------------------------|
        /// | (0x00, 0x00) | <c>pitchbendrange</c>         |
        /// | (0x00, 0x01) | <c>channelfinetuning</c>      |
        /// | (0x00, 0x02) | <c>channelcoarsetuning</c>    |
        /// | (0x00, 0x03) | <c>tuningprogram</c>          |
        /// | (0x00, 0x04) | <c>tuningbank</c>             |
        /// | (0x00, 0x05) | <c>modulationrange</c>        |
        /// | (0x3D, 0x00) | <c>azimuthangle</c>           |
        /// | (0x3D, 0x01) | <c>elevationangle</c>         |
        /// | (0x3D, 0x02) | <c>gain</c>                   |
        /// | (0x3D, 0x03) | <c>distanceratio</c>          |
        /// | (0x3D, 0x04) | <c>maximumdistance</c>        |
        /// | (0x3D, 0x05) | <c>maximumdistancegain</c>    |
        /// | (0x3D, 0x06) | <c>referencedistanceratio</c> |
        /// | (0x3D, 0x07) | <c>panspreadangle</c>         |
        /// | (0x3D, 0x08) | <c>rollangle</c>              |
        ///
        /// Note that the **Tuning Program** and **Tuning Bank** parameters are part of the *MIDI Tuning
        /// Standard*, which is not widely implemented.
        /// </summary>
        /// <param name="rpn">
        /// A string identifying the parameter's name (see above) or a
        /// two-position array specifying the two control bytes (e.g. <c>[0x65, 0x64]</c>) that identify the
        /// registered parameter.
        /// </param>
        /// <param name="data">
        /// An single integer or an array of integers with a maximum
        /// length of 2 specifying the desired data.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member sendRpnValue: rpn: ResizeArray<float> -> Webmidi.OutputChannel
        /// <summary>
        /// Sets the specified MIDI registered parameter to the desired value. The value is defined with
        /// up to two bytes of data (msb, lsb) that each can go from 0 to 127.
        ///
        /// MIDI
        /// [registered parameters](https://www.midi.org/specifications-old/item/table-3-control-change-messages-data-bytes-2)
        /// extend the original list of control change messages. The MIDI 1.0 specification lists only a
        /// limited number of them:
        ///
        /// | Numbers      | Function                 |
        /// |--------------|--------------------------|
        /// | (0x00, 0x00) | <c>pitchbendrange</c>         |
        /// | (0x00, 0x01) | <c>channelfinetuning</c>      |
        /// | (0x00, 0x02) | <c>channelcoarsetuning</c>    |
        /// | (0x00, 0x03) | <c>tuningprogram</c>          |
        /// | (0x00, 0x04) | <c>tuningbank</c>             |
        /// | (0x00, 0x05) | <c>modulationrange</c>        |
        /// | (0x3D, 0x00) | <c>azimuthangle</c>           |
        /// | (0x3D, 0x01) | <c>elevationangle</c>         |
        /// | (0x3D, 0x02) | <c>gain</c>                   |
        /// | (0x3D, 0x03) | <c>distanceratio</c>          |
        /// | (0x3D, 0x04) | <c>maximumdistance</c>        |
        /// | (0x3D, 0x05) | <c>maximumdistancegain</c>    |
        /// | (0x3D, 0x06) | <c>referencedistanceratio</c> |
        /// | (0x3D, 0x07) | <c>panspreadangle</c>         |
        /// | (0x3D, 0x08) | <c>rollangle</c>              |
        ///
        /// Note that the **Tuning Program** and **Tuning Bank** parameters are part of the *MIDI Tuning
        /// Standard*, which is not widely implemented.
        /// </summary>
        /// <param name="rpn">
        /// A string identifying the parameter's name (see above) or a
        /// two-position array specifying the two control bytes (e.g. <c>[0x65, 0x64]</c>) that identify the
        /// registered parameter.
        /// </param>
        /// <param name="data">
        /// An single integer or an array of integers with a maximum
        /// length of 2 specifying the desired data.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member sendRpnValue: rpn: ResizeArray<float> * data: float * ?options: OutputChannel.sendRpnValue.options -> Webmidi.OutputChannel
        /// <summary>
        /// Sets the specified MIDI registered parameter to the desired value. The value is defined with
        /// up to two bytes of data (msb, lsb) that each can go from 0 to 127.
        ///
        /// MIDI
        /// [registered parameters](https://www.midi.org/specifications-old/item/table-3-control-change-messages-data-bytes-2)
        /// extend the original list of control change messages. The MIDI 1.0 specification lists only a
        /// limited number of them:
        ///
        /// | Numbers      | Function                 |
        /// |--------------|--------------------------|
        /// | (0x00, 0x00) | <c>pitchbendrange</c>         |
        /// | (0x00, 0x01) | <c>channelfinetuning</c>      |
        /// | (0x00, 0x02) | <c>channelcoarsetuning</c>    |
        /// | (0x00, 0x03) | <c>tuningprogram</c>          |
        /// | (0x00, 0x04) | <c>tuningbank</c>             |
        /// | (0x00, 0x05) | <c>modulationrange</c>        |
        /// | (0x3D, 0x00) | <c>azimuthangle</c>           |
        /// | (0x3D, 0x01) | <c>elevationangle</c>         |
        /// | (0x3D, 0x02) | <c>gain</c>                   |
        /// | (0x3D, 0x03) | <c>distanceratio</c>          |
        /// | (0x3D, 0x04) | <c>maximumdistance</c>        |
        /// | (0x3D, 0x05) | <c>maximumdistancegain</c>    |
        /// | (0x3D, 0x06) | <c>referencedistanceratio</c> |
        /// | (0x3D, 0x07) | <c>panspreadangle</c>         |
        /// | (0x3D, 0x08) | <c>rollangle</c>              |
        ///
        /// Note that the **Tuning Program** and **Tuning Bank** parameters are part of the *MIDI Tuning
        /// Standard*, which is not widely implemented.
        /// </summary>
        /// <param name="rpn">
        /// A string identifying the parameter's name (see above) or a
        /// two-position array specifying the two control bytes (e.g. <c>[0x65, 0x64]</c>) that identify the
        /// registered parameter.
        /// </param>
        /// <param name="data">
        /// An single integer or an array of integers with a maximum
        /// length of 2 specifying the desired data.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member sendRpnValue: rpn: ResizeArray<float> * data: ResizeArray<float> * ?options: OutputChannel.sendRpnValue.options -> Webmidi.OutputChannel
        /// <summary>
        /// Sets the MIDI tuning bank to use. Note that the **Tuning Bank** parameter is part of the
        /// *MIDI Tuning Standard*, which is not widely implemented.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// The bank value must be between 0 and 127.
        /// </remarks>
        /// <param name="value">
        /// The desired tuning bank (integer between <c>0</c> and <c>127</c>).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member sendTuningBank: value: float * ?options: OutputChannel.sendTuningBank.options -> Webmidi.OutputChannel
        /// <summary>
        /// Sets the MIDI tuning program to use. Note that the **Tuning Program** parameter is part of the
        /// *MIDI Tuning Standard*, which is not widely implemented.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// The program value must be between 0 and 127.
        /// </remarks>
        /// <param name="value">
        /// The desired tuning program (integer between <c>0</c> and <c>127</c>).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member sendTuningProgram: value: float * ?options: OutputChannel.sendTuningProgram.options -> Webmidi.OutputChannel
        /// <summary>
        /// Turns local control on or off. Local control is usually enabled by default. If you disable it,
        /// the instrument will no longer trigger its own sounds. It will only send the MIDI messages to
        /// its out port.
        /// </summary>
        /// <param name="state">
        /// Whether to activate local control (<c>true</c>) or disable it
        /// (<c>false</c>).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member sendLocalControl: ?state: bool * ?options: OutputChannel.sendLocalControl.options -> Webmidi.OutputChannel
        /// <summary>
        /// Sends an **all notes off** channel mode message. This will make all currently playing notes
        /// fade out just as if their key had been released. This is different from the
        /// [<c>sendAllSoundOff()</c>]<see href="#sendAllSoundOff">#sendAllSoundOff</see> method which mutes all sounds immediately.
        /// </summary>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member sendAllNotesOff: ?options: OutputChannel.sendAllNotesOff.options -> Webmidi.OutputChannel
        /// <summary>
        /// Sends an **all sound off** channel mode message. This will silence all sounds playing on that
        /// channel but will not prevent new sounds from being triggered.
        /// </summary>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member sendAllSoundOff: ?options: OutputChannel.sendAllSoundOff.options -> Webmidi.OutputChannel
        /// <summary>
        /// Sends a **reset all controllers** channel mode message. This resets all controllers, such as
        /// the pitch bend, to their default value.
        /// </summary>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member sendResetAllControllers: ?options: OutputChannel.sendResetAllControllers.options -> Webmidi.OutputChannel
        /// <summary>
        /// Sets the polyphonic mode. In <c>"poly"</c> mode (usually the default), multiple notes can be played
        /// and heard at the same time. In <c>"mono"</c> mode, only one note will be heard at once even if
        /// multiple notes are being played.
        /// </summary>
        /// <param name="mode">
        /// The mode to use: <c>"mono"</c> or <c>"poly"</c>.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Returns the <c>OutputChannel</c> object so methods can be chained.
        /// </returns>
        abstract member sendPolyphonicMode: ?mode: string * ?options: OutputChannel.sendPolyphonicMode.options -> Webmidi.OutputChannel
        /// <summary>
        /// An integer to offset the reported octave of outgoing note-specific messages (<c>noteon</c>,
        /// <c>noteoff</c> and <c>keyaftertouch</c>). By default, middle C (MIDI note number 60) is placed on the 4th
        /// octave (C4).
        ///
        /// Note that this value is combined with the global offset value defined in
        /// [<c>WebMidi.octaveOffset</c>](WebMidi#octaveOffset) and with the parent value defined in
        /// [<c>Output.octaveOffset</c>]<see href="Output#octaveOffset">Output#octaveOffset</see>.
        /// </summary>
        abstract member octaveOffset: float with get, set
        /// <summary>
        /// The parent [<c>Output</c>]<see href="Output">Output</see> this channel belongs to.
        /// </summary>
        abstract member output: Webmidi.Output with get
        /// <summary>
        /// This channel's MIDI number (<c>1</c> - <c>16</c>).
        /// </summary>
        abstract member number: float with get

    /// <summary>
    /// The <c>Utilities</c> class contains general-purpose utility methods. All methods are static and
    /// should be called using the class name. For example: <c>Utilities.getNoteDetails("C4")</c>.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("Utilities", "webmidi")>]
    type Utilities =
        /// <summary>
        /// Converts the <c>input</c> parameter to a valid [<c>Note</c>]<see href="Note">Note</see> object. The input usually is an
        /// unsigned integer (0-127) or a note identifier (<c>"C4"</c>, <c>"G#5"</c>, etc.). If the input is a
        /// [<c>Note</c>]<see href="Note">Note</see> object, it will be returned as is.
        ///
        /// If the input is a note number or identifier, it is possible to specify options by providing the
        /// <c>options</c> parameter.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// TypeError The input could not be parsed to a note
        /// </remarks>
        /// <param name="input">
        ///
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        [<Emit("""import { Utilities } from "webmidi";
Utilities.buildNote()""")>]
        static member inline buildNote () : Webmidi.Note = nativeOnly
        /// <summary>
        /// Converts the <c>input</c> parameter to a valid [<c>Note</c>]<see href="Note">Note</see> object. The input usually is an
        /// unsigned integer (0-127) or a note identifier (<c>"C4"</c>, <c>"G#5"</c>, etc.). If the input is a
        /// [<c>Note</c>]<see href="Note">Note</see> object, it will be returned as is.
        ///
        /// If the input is a note number or identifier, it is possible to specify options by providing the
        /// <c>options</c> parameter.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// TypeError The input could not be parsed to a note
        /// </remarks>
        /// <param name="input">
        ///
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        [<Emit("""import { Utilities } from "webmidi";
Utilities.buildNote($0, $1)""")>]
        static member inline buildNote (input: float, ?options: Utilities.buildNote__.options): Webmidi.Note = nativeOnly
        /// <summary>
        /// Converts the <c>input</c> parameter to a valid [<c>Note</c>]<see href="Note">Note</see> object. The input usually is an
        /// unsigned integer (0-127) or a note identifier (<c>"C4"</c>, <c>"G#5"</c>, etc.). If the input is a
        /// [<c>Note</c>]<see href="Note">Note</see> object, it will be returned as is.
        ///
        /// If the input is a note number or identifier, it is possible to specify options by providing the
        /// <c>options</c> parameter.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// TypeError The input could not be parsed to a note
        /// </remarks>
        /// <param name="input">
        ///
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        [<Emit("""import { Utilities } from "webmidi";
Utilities.buildNote($0, $1)""")>]
        static member inline buildNote (input: string, ?options: Utilities.buildNote__.options): Webmidi.Note = nativeOnly
        /// <summary>
        /// Converts the <c>input</c> parameter to a valid [<c>Note</c>]<see href="Note">Note</see> object. The input usually is an
        /// unsigned integer (0-127) or a note identifier (<c>"C4"</c>, <c>"G#5"</c>, etc.). If the input is a
        /// [<c>Note</c>]<see href="Note">Note</see> object, it will be returned as is.
        ///
        /// If the input is a note number or identifier, it is possible to specify options by providing the
        /// <c>options</c> parameter.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// TypeError The input could not be parsed to a note
        /// </remarks>
        /// <param name="input">
        ///
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        [<Emit("""import { Utilities } from "webmidi";
Utilities.buildNote($0, $1)""")>]
        static member inline buildNote (input: Webmidi.Note, ?options: Utilities.buildNote__.options): Webmidi.Note = nativeOnly
        /// <summary>
        /// Converts an input value, which can be an unsigned integer (0-127), a note identifier, a
        /// [<c>Note</c>]<see href="Note">Note</see>  object or an array of the previous types, to an array of
        /// [<c>Note</c>]<see href="Note">Note</see>  objects.
        ///
        /// [<c>Note</c>]<see href="Note">Note</see>  objects are returned as is. For note numbers and identifiers, a
        /// [<c>Note</c>]<see href="Note">Note</see> object is created with the options specified. An error will be thrown when
        /// encountering invalid input.
        ///
        /// Note: if both the <c>attack</c> and <c>rawAttack</c> options are specified, the later has priority. The
        /// same goes for <c>release</c> and <c>rawRelease</c>.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// TypeError An element could not be parsed as a note.
        /// </remarks>
        /// <param name="notes">
        ///
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        [<Emit("""import { Utilities } from "webmidi";
Utilities.buildNoteArray()""")>]
        static member inline buildNoteArray () : ResizeArray<Webmidi.Note> = nativeOnly
        /// <summary>
        /// Converts an input value, which can be an unsigned integer (0-127), a note identifier, a
        /// [<c>Note</c>]<see href="Note">Note</see>  object or an array of the previous types, to an array of
        /// [<c>Note</c>]<see href="Note">Note</see>  objects.
        ///
        /// [<c>Note</c>]<see href="Note">Note</see>  objects are returned as is. For note numbers and identifiers, a
        /// [<c>Note</c>]<see href="Note">Note</see> object is created with the options specified. An error will be thrown when
        /// encountering invalid input.
        ///
        /// Note: if both the <c>attack</c> and <c>rawAttack</c> options are specified, the later has priority. The
        /// same goes for <c>release</c> and <c>rawRelease</c>.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// TypeError An element could not be parsed as a note.
        /// </remarks>
        /// <param name="notes">
        ///
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        [<Emit("""import { Utilities } from "webmidi";
Utilities.buildNoteArray($0, $1)""")>]
        static member inline buildNoteArray (notes: float, ?options: Utilities.buildNoteArray__.options): ResizeArray<Webmidi.Note> = nativeOnly
        /// <summary>
        /// Converts an input value, which can be an unsigned integer (0-127), a note identifier, a
        /// [<c>Note</c>]<see href="Note">Note</see>  object or an array of the previous types, to an array of
        /// [<c>Note</c>]<see href="Note">Note</see>  objects.
        ///
        /// [<c>Note</c>]<see href="Note">Note</see>  objects are returned as is. For note numbers and identifiers, a
        /// [<c>Note</c>]<see href="Note">Note</see> object is created with the options specified. An error will be thrown when
        /// encountering invalid input.
        ///
        /// Note: if both the <c>attack</c> and <c>rawAttack</c> options are specified, the later has priority. The
        /// same goes for <c>release</c> and <c>rawRelease</c>.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// TypeError An element could not be parsed as a note.
        /// </remarks>
        /// <param name="notes">
        ///
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        [<Emit("""import { Utilities } from "webmidi";
Utilities.buildNoteArray($0, $1)""")>]
        static member inline buildNoteArray (notes: string, ?options: Utilities.buildNoteArray__.options): ResizeArray<Webmidi.Note> = nativeOnly
        /// <summary>
        /// Converts an input value, which can be an unsigned integer (0-127), a note identifier, a
        /// [<c>Note</c>]<see href="Note">Note</see>  object or an array of the previous types, to an array of
        /// [<c>Note</c>]<see href="Note">Note</see>  objects.
        ///
        /// [<c>Note</c>]<see href="Note">Note</see>  objects are returned as is. For note numbers and identifiers, a
        /// [<c>Note</c>]<see href="Note">Note</see> object is created with the options specified. An error will be thrown when
        /// encountering invalid input.
        ///
        /// Note: if both the <c>attack</c> and <c>rawAttack</c> options are specified, the later has priority. The
        /// same goes for <c>release</c> and <c>rawRelease</c>.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// TypeError An element could not be parsed as a note.
        /// </remarks>
        /// <param name="notes">
        ///
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        [<Emit("""import { Utilities } from "webmidi";
Utilities.buildNoteArray($0, $1)""")>]
        static member inline buildNoteArray (notes: Webmidi.Note, ?options: Utilities.buildNoteArray__.options): ResizeArray<Webmidi.Note> = nativeOnly
        /// <summary>
        /// Converts an input value, which can be an unsigned integer (0-127), a note identifier, a
        /// [<c>Note</c>]<see href="Note">Note</see>  object or an array of the previous types, to an array of
        /// [<c>Note</c>]<see href="Note">Note</see>  objects.
        ///
        /// [<c>Note</c>]<see href="Note">Note</see>  objects are returned as is. For note numbers and identifiers, a
        /// [<c>Note</c>]<see href="Note">Note</see> object is created with the options specified. An error will be thrown when
        /// encountering invalid input.
        ///
        /// Note: if both the <c>attack</c> and <c>rawAttack</c> options are specified, the later has priority. The
        /// same goes for <c>release</c> and <c>rawRelease</c>.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// TypeError An element could not be parsed as a note.
        /// </remarks>
        /// <param name="notes">
        ///
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        [<Emit("""import { Utilities } from "webmidi";
Utilities.buildNoteArray($0, $1)""")>]
        static member inline buildNoteArray (notes: ResizeArray<float>, ?options: Utilities.buildNoteArray__.options): ResizeArray<Webmidi.Note> = nativeOnly
        /// <summary>
        /// Converts an input value, which can be an unsigned integer (0-127), a note identifier, a
        /// [<c>Note</c>]<see href="Note">Note</see>  object or an array of the previous types, to an array of
        /// [<c>Note</c>]<see href="Note">Note</see>  objects.
        ///
        /// [<c>Note</c>]<see href="Note">Note</see>  objects are returned as is. For note numbers and identifiers, a
        /// [<c>Note</c>]<see href="Note">Note</see> object is created with the options specified. An error will be thrown when
        /// encountering invalid input.
        ///
        /// Note: if both the <c>attack</c> and <c>rawAttack</c> options are specified, the later has priority. The
        /// same goes for <c>release</c> and <c>rawRelease</c>.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// TypeError An element could not be parsed as a note.
        /// </remarks>
        /// <param name="notes">
        ///
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        [<Emit("""import { Utilities } from "webmidi";
Utilities.buildNoteArray($0, $1)""")>]
        static member inline buildNoteArray (notes: ResizeArray<string>, ?options: Utilities.buildNoteArray__.options): ResizeArray<Webmidi.Note> = nativeOnly
        /// <summary>
        /// Converts an input value, which can be an unsigned integer (0-127), a note identifier, a
        /// [<c>Note</c>]<see href="Note">Note</see>  object or an array of the previous types, to an array of
        /// [<c>Note</c>]<see href="Note">Note</see>  objects.
        ///
        /// [<c>Note</c>]<see href="Note">Note</see>  objects are returned as is. For note numbers and identifiers, a
        /// [<c>Note</c>]<see href="Note">Note</see> object is created with the options specified. An error will be thrown when
        /// encountering invalid input.
        ///
        /// Note: if both the <c>attack</c> and <c>rawAttack</c> options are specified, the later has priority. The
        /// same goes for <c>release</c> and <c>rawRelease</c>.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// TypeError An element could not be parsed as a note.
        /// </remarks>
        /// <param name="notes">
        ///
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        [<Emit("""import { Utilities } from "webmidi";
Utilities.buildNoteArray($0, $1)""")>]
        static member inline buildNoteArray (notes: ResizeArray<Webmidi.Note>, ?options: Utilities.buildNoteArray__.options): ResizeArray<Webmidi.Note> = nativeOnly
        /// <summary>
        /// Returns a number between 0 and 1 representing the ratio of the input value divided by 127 (7
        /// bit). The returned value is restricted between 0 and 1 even if the input is greater than 127 or
        /// smaller than 0.
        ///
        /// Passing <c>Infinity</c> will return <c>1</c> and passing <c>-Infinity</c> will return <c>0</c>. Otherwise, when the
        /// input value cannot be converted to an integer, the method returns 0.
        /// </summary>
        /// <param name="value">
        /// A positive integer between 0 and 127 (inclusive)
        /// </param>
        /// <returns>
        /// A number between 0 and 1 (inclusive)
        /// </returns>
        [<Emit("""import { Utilities } from "webmidi";
Utilities.from7bitToFloat($0)""")>]
        static member inline from7bitToFloat (value: float): float = nativeOnly
        /// <summary>
        /// Returns an integer between 0 and 127 which is the result of multiplying the input value by
        /// 127. The input value should be a number between 0 and 1 (inclusively). The returned value is
        /// restricted between 0 and 127 even if the input is greater than 1 or smaller than 0.
        ///
        /// Passing <c>Infinity</c> will return <c>127</c> and passing <c>-Infinity</c> will return <c>0</c>. Otherwise, when
        /// the input value cannot be converted to a number, the method returns 0.
        /// </summary>
        /// <param name="value">
        /// A positive float between 0 and 1 (inclusive)
        /// </param>
        /// <returns>
        /// A number between 0 and 127 (inclusive)
        /// </returns>
        [<Emit("""import { Utilities } from "webmidi";
Utilities.fromFloatTo7Bit($0)""")>]
        static member inline fromFloatTo7Bit (value: float): float = nativeOnly
        /// <summary>
        /// Extracts 7bit MSB and LSB values from the supplied float.
        /// </summary>
        /// <param name="value">
        /// A float between 0 and 1
        /// </param>
        [<Emit("""import { Utilities } from "webmidi";
Utilities.fromFloatToMsbLsb($0)""")>]
        static member inline fromFloatToMsbLsb (value: float): Utilities.fromFloatToMsbLsb__ = nativeOnly
        /// <summary>
        /// Combines and converts MSB and LSB values (0-127) to a float between 0 and 1. The returned value
        /// is within between 0 and 1 even if the result is greater than 1 or smaller than 0.
        /// </summary>
        /// <param name="msb">
        /// The most significant byte as a integer between 0 and 127.
        /// </param>
        /// <param name="lsb">
        /// The least significant byte as a integer between 0 and 127.
        /// </param>
        /// <returns>
        /// A float between 0 and 1.
        /// </returns>
        [<Emit("""import { Utilities } from "webmidi";
Utilities.fromMsbLsbToFloat($0, $1)""")>]
        static member inline fromMsbLsbToFloat (msb: float, ?lsb: float): float = nativeOnly
        /// <summary>
        /// Returns the name of a control change message matching the specified number (0-127). Some valid
        /// control change numbers do not have a specific name or purpose assigned in the MIDI
        /// [spec](https://midi.org/specifications-old/item/table-3-control-change-messages-data-bytes-2).
        /// In these cases, the method returns <c>controllerXXX</c> (where XXX is the number).
        /// </summary>
        /// <param name="number">
        /// An integer (0-127) representing the control change message
        /// </param>
        /// <returns>
        /// The matching control change name or <c>undefined</c> if no match was
        /// found.
        /// </returns>
        [<Emit("""import { Utilities } from "webmidi";
Utilities.getCcNameByNumber($0)""")>]
        static member inline getCcNameByNumber (number: float): string option = nativeOnly
        /// <summary>
        /// Returns the number of a control change message matching the specified name.
        /// </summary>
        /// <param name="name">
        /// A string representing the control change message
        /// </param>
        /// <returns>
        /// The matching control change number or <c>undefined</c> if no match was
        /// found.
        /// </returns>
        [<Emit("""import { Utilities } from "webmidi";
Utilities.getCcNumberByName($0)""")>]
        static member inline getCcNumberByName (name: string): float option = nativeOnly
        /// <summary>
        /// Returns the channel mode name matching the specified number. If no match is found, the function
        /// returns <c>false</c>.
        /// </summary>
        /// <param name="number">
        /// An integer representing the channel mode message (120-127)
        /// </param>
        /// <returns>
        /// The name of the matching channel mode or <c>false</c> if no match could be
        /// found.
        /// </returns>
        [<Emit("""import { Utilities } from "webmidi";
Utilities.getChannelModeByNumber($0)""")>]
        static member inline getChannelModeByNumber (number: float): U2<string, bool> = nativeOnly
        /// <summary>
        /// Given a proper note identifier (<c>C#4</c>, <c>Gb-1</c>, etc.) or a valid MIDI note number (0-127), this
        /// method returns an object containing broken down details about the specified note (uppercase
        /// letter, accidental and octave).
        ///
        /// When a number is specified, the translation to note is done using a value of 60 for middle C
        /// (C4 = middle C).
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// TypeError Invalid note identifier
        /// </remarks>
        /// <param name="value">
        /// A note identifier A  atring ("C#4", "Gb-1", etc.) or a MIDI note
        /// number (0-127).
        /// </param>
        [<Emit("""import { Utilities } from "webmidi";
Utilities.getNoteDetails($0)""")>]
        static member inline getNoteDetails (value: string): Utilities.getNoteDetails__ = nativeOnly
        /// <summary>
        /// Given a proper note identifier (<c>C#4</c>, <c>Gb-1</c>, etc.) or a valid MIDI note number (0-127), this
        /// method returns an object containing broken down details about the specified note (uppercase
        /// letter, accidental and octave).
        ///
        /// When a number is specified, the translation to note is done using a value of 60 for middle C
        /// (C4 = middle C).
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// TypeError Invalid note identifier
        /// </remarks>
        /// <param name="value">
        /// A note identifier A  atring ("C#4", "Gb-1", etc.) or a MIDI note
        /// number (0-127).
        /// </param>
        [<Emit("""import { Utilities } from "webmidi";
Utilities.getNoteDetails($0)""")>]
        static member inline getNoteDetails (value: float): Utilities.getNoteDetails__ = nativeOnly
        /// <summary>
        /// Given a proper note identifier (<c>C#4</c>, <c>Gb-1</c>, etc.) or a valid MIDI note number (0-127), this
        /// method returns an object containing broken down details about the specified note (uppercase
        /// letter, accidental and octave).
        ///
        /// When a number is specified, the translation to note is done using a value of 60 for middle C
        /// (C4 = middle C).
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// TypeError Invalid note identifier
        /// </remarks>
        /// <param name="value">
        /// A note identifier A  atring ("C#4", "Gb-1", etc.) or a MIDI note
        /// number (0-127).
        /// </param>
        [<Emit("""import { Utilities } from "webmidi";
Utilities.getNoteDetails($0)""")>]
        static member inline getNoteDetails (value: U2<string, float>): Utilities.getNoteDetails__ = nativeOnly
        /// <summary>
        /// Returns the name of the first property of the supplied object whose value is equal to the one
        /// supplied. If nothing is found, <c>undefined</c> is returned.
        /// </summary>
        /// <param name="object">
        /// The object to look for the property in.
        /// </param>
        /// <param name="value">
        /// Any value that can be expected to be found in the object's properties.
        /// </param>
        /// <returns>
        /// The name of the matching property or <c>undefined</c> if nothing is
        /// found.
        /// </returns>
        [<Emit("""import { Utilities } from "webmidi";
Utilities.getPropertyByValue($0, $1)""")>]
        static member inline getPropertyByValue (``object``: obj, value: obj): string option = nativeOnly
        /// <summary>
        /// Returns a valid MIDI note number (0-127) given the specified input. The input usually is a
        /// string containing a note identifier (<c>"C3"</c>, <c>"F#4"</c>, <c>"D-2"</c>, <c>"G8"</c>, etc.). If an integer
        /// between 0 and 127 is passed, it will simply be returned as is (for convenience). Other strings
        /// will be parsed for integer value, if possible.
        ///
        /// If the input is an identifier, the resulting note number is offset by the <c>octaveOffset</c>
        /// parameter. For example, if you pass in "C4" (note number 60) and the <c>octaveOffset</c> value is
        /// -2, the resulting MIDI note number will be 36.
        /// </summary>
        /// <param name="input">
        /// A string or number to extract the MIDI note number from.
        /// </param>
        /// <param name="octaveOffset">
        /// An integer to offset the octave by
        /// </param>
        /// <returns>
        /// A valid MIDI note number (0-127) or <c>false</c> if the input could not
        /// successfully be parsed to a note number.
        /// </returns>
        [<Emit("""import { Utilities } from "webmidi";
Utilities.guessNoteNumber($0, $1)""")>]
        static member inline guessNoteNumber (input: string, octaveOffset: float): U2<float, bool> = nativeOnly
        /// <summary>
        /// Returns a valid MIDI note number (0-127) given the specified input. The input usually is a
        /// string containing a note identifier (<c>"C3"</c>, <c>"F#4"</c>, <c>"D-2"</c>, <c>"G8"</c>, etc.). If an integer
        /// between 0 and 127 is passed, it will simply be returned as is (for convenience). Other strings
        /// will be parsed for integer value, if possible.
        ///
        /// If the input is an identifier, the resulting note number is offset by the <c>octaveOffset</c>
        /// parameter. For example, if you pass in "C4" (note number 60) and the <c>octaveOffset</c> value is
        /// -2, the resulting MIDI note number will be 36.
        /// </summary>
        /// <param name="input">
        /// A string or number to extract the MIDI note number from.
        /// </param>
        /// <param name="octaveOffset">
        /// An integer to offset the octave by
        /// </param>
        /// <returns>
        /// A valid MIDI note number (0-127) or <c>false</c> if the input could not
        /// successfully be parsed to a note number.
        /// </returns>
        [<Emit("""import { Utilities } from "webmidi";
Utilities.guessNoteNumber($0, $1)""")>]
        static member inline guessNoteNumber (input: float, octaveOffset: float): U2<float, bool> = nativeOnly
        /// <summary>
        /// Returns a valid MIDI note number (0-127) given the specified input. The input usually is a
        /// string containing a note identifier (<c>"C3"</c>, <c>"F#4"</c>, <c>"D-2"</c>, <c>"G8"</c>, etc.). If an integer
        /// between 0 and 127 is passed, it will simply be returned as is (for convenience). Other strings
        /// will be parsed for integer value, if possible.
        ///
        /// If the input is an identifier, the resulting note number is offset by the <c>octaveOffset</c>
        /// parameter. For example, if you pass in "C4" (note number 60) and the <c>octaveOffset</c> value is
        /// -2, the resulting MIDI note number will be 36.
        /// </summary>
        /// <param name="input">
        /// A string or number to extract the MIDI note number from.
        /// </param>
        /// <param name="octaveOffset">
        /// An integer to offset the octave by
        /// </param>
        /// <returns>
        /// A valid MIDI note number (0-127) or <c>false</c> if the input could not
        /// successfully be parsed to a note number.
        /// </returns>
        [<Emit("""import { Utilities } from "webmidi";
Utilities.guessNoteNumber($0, $1)""")>]
        static member inline guessNoteNumber (input: U2<string, float>, octaveOffset: float): U2<float, bool> = nativeOnly
        /// <summary>
        /// Indicates whether the execution environment is Node.js (<c>true</c>) or not (<c>false</c>)
        /// </summary>
        static member inline isNode
            with get () : bool =
                nativeOnly
        /// <summary>
        /// Indicates whether the execution environment is a browser (<c>true</c>) or not (<c>false</c>)
        /// </summary>
        static member inline isBrowser
            with get () : bool =
                nativeOnly
        /// <summary>
        /// Returns the supplied MIDI note number offset by the requested octave and semitone values. If
        /// the calculated value is less than 0, 0 will be returned. If the calculated value is more than
        /// 127, 127 will be returned. If an invalid offset value is supplied, 0 will be used.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// Invalid note number
        /// </remarks>
        /// <param name="number">
        /// The MIDI note to offset as an integer between 0 and 127.
        /// </param>
        /// <param name="octaveOffset">
        /// An integer to offset the note by (in octave)
        /// </param>
        /// <param name="octaveOffset">
        /// An integer to offset the note by (in semitones)
        /// </param>
        /// <returns>
        /// An integer between 0 and 127
        /// </returns>
        [<Emit("""import { Utilities } from "webmidi";
Utilities.offsetNumber($0, $1, $2)""")>]
        static member inline offsetNumber (number: float, ?octaveOffset: float, ?semitoneOffset: float): float = nativeOnly
        /// <summary>
        /// Returns a sanitized array of valid MIDI channel numbers (1-16). The parameter should be a
        /// single integer or an array of integers.
        ///
        /// For backwards-compatibility, passing <c>undefined</c> as a parameter to this method results in all
        /// channels being returned (1-16). Otherwise, parameters that cannot successfully be parsed to
        /// integers between 1 and 16 are silently ignored.
        /// </summary>
        /// <param name="channel">
        /// An integer or an array of integers to parse as channel
        /// numbers.
        /// </param>
        /// <returns>
        /// An array of 0 or more valid MIDI channel numbers.
        /// </returns>
        [<Emit("""import { Utilities } from "webmidi";
Utilities.sanitizeChannels()""")>]
        static member inline sanitizeChannels () : ResizeArray<float> = nativeOnly
        /// <summary>
        /// Returns a sanitized array of valid MIDI channel numbers (1-16). The parameter should be a
        /// single integer or an array of integers.
        ///
        /// For backwards-compatibility, passing <c>undefined</c> as a parameter to this method results in all
        /// channels being returned (1-16). Otherwise, parameters that cannot successfully be parsed to
        /// integers between 1 and 16 are silently ignored.
        /// </summary>
        /// <param name="channel">
        /// An integer or an array of integers to parse as channel
        /// numbers.
        /// </param>
        /// <returns>
        /// An array of 0 or more valid MIDI channel numbers.
        /// </returns>
        [<Emit("""import { Utilities } from "webmidi";
Utilities.sanitizeChannels($0)""")>]
        static member inline sanitizeChannels (channel: float): ResizeArray<float> = nativeOnly
        /// <summary>
        /// Returns a sanitized array of valid MIDI channel numbers (1-16). The parameter should be a
        /// single integer or an array of integers.
        ///
        /// For backwards-compatibility, passing <c>undefined</c> as a parameter to this method results in all
        /// channels being returned (1-16). Otherwise, parameters that cannot successfully be parsed to
        /// integers between 1 and 16 are silently ignored.
        /// </summary>
        /// <param name="channel">
        /// An integer or an array of integers to parse as channel
        /// numbers.
        /// </param>
        /// <returns>
        /// An array of 0 or more valid MIDI channel numbers.
        /// </returns>
        [<Emit("""import { Utilities } from "webmidi";
Utilities.sanitizeChannels($0)""")>]
        static member inline sanitizeChannels (channel: ResizeArray<float>): ResizeArray<float> = nativeOnly
        /// <summary>
        /// Returns an identifier string representing a note name (with optional accidental) followed by an
        /// octave number. The octave can be offset by using the <c>octaveOffset</c> parameter.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// RangeError Invalid note number
        ///
        /// RangeError Invalid octaveOffset value
        /// </remarks>
        /// <param name="number">
        /// The MIDI note number to convert to a note identifier
        /// </param>
        /// <param name="octaveOffset">
        /// An offset to apply to the resulting octave
        /// </param>
        [<Emit("""import { Utilities } from "webmidi";
Utilities.toNoteIdentifier($0, $1)""")>]
        static member inline toNoteIdentifier (number: float, octaveOffset: float): string = nativeOnly
        /// <summary>
        /// Returns a MIDI note number matching the identifier passed in the form of a string. The
        /// identifier must include the octave number. The identifier also optionally include a sharp (#),
        /// a double sharp (##), a flat (b) or a double flat (bb) symbol. For example, these are all valid
        /// identifiers: C5, G4, D#-1, F0, Gb7, Eb-1, Abb4, B##6, etc.
        ///
        /// When converting note identifiers to numbers, C4 is considered to be middle C (MIDI note number
        /// 60) as per the scientific pitch notation standard.
        ///
        /// The resulting note number can be offset by using the <c>octaveOffset</c> parameter.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// RangeError Invalid 'octaveOffset' value
        ///
        /// TypeError Invalid note identifier
        /// </remarks>
        /// <param name="identifier">
        /// The identifier in the form of a letter, followed by an optional "#",
        /// "##", "b" or "bb" followed by the octave number. For exemple: C5, G4, D#-1, F0, Gb7, Eb-1,
        /// Abb4, B##6, etc.
        /// </param>
        /// <param name="octaveOffset">
        /// A integer to offset the octave by.
        /// </param>
        /// <returns>
        /// The MIDI note number (an integer between 0 and 127).
        /// </returns>
        [<Emit("""import { Utilities } from "webmidi";
Utilities.toNoteNumber($0, $1)""")>]
        static member inline toNoteNumber (identifier: string, ?octaveOffset: float): float = nativeOnly
        /// <summary>
        /// Returns a valid timestamp, relative to the navigation start of the document, derived from the
        /// <c>time</c> parameter. If the parameter is a string starting with the "+" sign and followed by a
        /// number, the resulting timestamp will be the sum of the current timestamp plus that number. If
        /// the parameter is a positive number, it will be returned as is. Otherwise, false will be
        /// returned.
        /// </summary>
        /// <param name="time">
        /// The time string (e.g. <c>"+2000"</c>) or number to parse
        /// </param>
        /// <returns>
        /// A positive number or <c>false</c> (if the time cannot be converted)
        /// </returns>
        [<Emit("""import { Utilities } from "webmidi";
Utilities.toTimestamp()""")>]
        static member inline toTimestamp () : U2<float, bool> = nativeOnly
        /// <summary>
        /// Returns a valid timestamp, relative to the navigation start of the document, derived from the
        /// <c>time</c> parameter. If the parameter is a string starting with the "+" sign and followed by a
        /// number, the resulting timestamp will be the sum of the current timestamp plus that number. If
        /// the parameter is a positive number, it will be returned as is. Otherwise, false will be
        /// returned.
        /// </summary>
        /// <param name="time">
        /// The time string (e.g. <c>"+2000"</c>) or number to parse
        /// </param>
        /// <returns>
        /// A positive number or <c>false</c> (if the time cannot be converted)
        /// </returns>
        [<Emit("""import { Utilities } from "webmidi";
Utilities.toTimestamp($0)""")>]
        static member inline toTimestamp (time: float): U2<float, bool> = nativeOnly
        /// <summary>
        /// Returns a valid timestamp, relative to the navigation start of the document, derived from the
        /// <c>time</c> parameter. If the parameter is a string starting with the "+" sign and followed by a
        /// number, the resulting timestamp will be the sum of the current timestamp plus that number. If
        /// the parameter is a positive number, it will be returned as is. Otherwise, false will be
        /// returned.
        /// </summary>
        /// <param name="time">
        /// The time string (e.g. <c>"+2000"</c>) or number to parse
        /// </param>
        /// <returns>
        /// A positive number or <c>false</c> (if the time cannot be converted)
        /// </returns>
        [<Emit("""import { Utilities } from "webmidi";
Utilities.toTimestamp($0)""")>]
        static member inline toTimestamp (time: string): U2<float, bool> = nativeOnly

    /// <summary>
    /// The <c>WebMidi</c> object makes it easier to work with the low-level Web MIDI API. Basically, it
    /// simplifies sending outgoing MIDI messages and reacting to incoming MIDI messages.
    ///
    /// When using the WebMidi.js library, you should know that the <c>WebMidi</c> class has already been
    /// instantiated. You cannot instantiate it yourself. If you use the **IIFE** version, you should
    /// simply use the global object called <c>WebMidi</c>. If you use the **CJS** (CommonJS) or **ESM** (ES6
    /// module) version, you get an already-instantiated object when you import the module.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type WebMidi =
        /// <summary>
        /// Object containing system-wide default values that can be changed to customize how the library
        /// works.
        /// </summary>
        abstract member defaults: obj with get, set
        /// <summary>
        /// The [<c>MIDIAccess</c>](https://developer.mozilla.org/en-US/docs/Web/API/MIDIAccess)
        /// instance used to talk to the lower-level Web MIDI API. This should not be used directly
        /// unless you know what you are doing.
        /// </summary>
        abstract member ``interface``: Webmidi.WebMidiApi_.MIDIAccess with get, set
        /// <summary>
        /// Indicates whether argument validation and backwards-compatibility checks are performed
        /// throughout the WebMidi.js library for object methods and property setters.
        ///
        /// This is an advanced setting that should be used carefully. Setting <c>validation</c> to <c>false</c>
        /// improves performance but should only be done once the project has been thoroughly tested with
        /// <c>validation</c> turned on.
        /// </summary>
        abstract member validation: bool with get, set
        /// <summary>
        /// Adds an event listener that will trigger a function callback when the specified event is
        /// dispatched.
        ///
        /// Here are the events you can listen to:   connected, disabled, disconnected, enabled,
        /// midiaccessgranted, portschanged, error
        /// </summary>
        /// <param name="event">
        /// The type of the event.
        /// </param>
        /// <param name="listener">
        /// A callback function to execute when the specified event
        /// is detected. This function will receive an event parameter object. For details on this object's
        /// properties, check out the documentation for the various events (links above).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// The listener object that was created
        /// </returns>
        abstract member addListener<'T>: e: obj * listener: 'T * ?options: WebMidi.addListener.options -> Webmidi.Listener
        /// <summary>
        /// Adds an event listener that will trigger a function callback when the specified event is
        /// dispatched.
        ///
        /// Here are the events you can listen to:   connected, disabled, disconnected, enabled,
        /// midiaccessgranted, portschanged, error
        /// </summary>
        /// <param name="event">
        /// The type of the event.
        /// </param>
        /// <param name="listener">
        /// A callback function to execute when the specified event
        /// is detected. This function will receive an event parameter object. For details on this object's
        /// properties, check out the documentation for the various events (links above).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// The listener object that was created
        /// </returns>
        abstract member addListener<'T>: e: Webmidi.WebMidiEventMap.Key<'T> * listener: 'T * ?options: WebMidi.addListener.options -> Webmidi.Listener
        /// <summary>
        /// Adds an event listener that will trigger a function callback when the specified event is
        /// dispatched.
        ///
        /// Here are the events you can listen to:   connected, disabled, disconnected, enabled,
        /// midiaccessgranted, portschanged, error
        /// </summary>
        /// <param name="event">
        /// The type of the event.
        /// </param>
        /// <param name="listener">
        /// A callback function to execute when the specified event
        /// is detected. This function will receive an event parameter object. For details on this object's
        /// properties, check out the documentation for the various events (links above).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// The listener object that was created
        /// </returns>
        abstract member addListener<'T>: e: U2<obj, Webmidi.WebMidiEventMap.Key<'T>> * listener: 'T * ?options: WebMidi.addListener.options -> Webmidi.Listener
        /// <summary>
        /// Adds a one-time event listener that will trigger a function callback when the specified event
        /// is dispatched.
        ///
        /// Here are the events you can listen to:   connected, disabled, disconnected, enabled,
        /// midiaccessgranted, portschanged, error
        /// </summary>
        /// <param name="event">
        /// The type of the event.
        /// </param>
        /// <param name="listener">
        /// A callback function to execute when the specified event
        /// is detected. This function will receive an event parameter object. For details on this object's
        /// properties, check out the documentation for the various events (links above).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// The listener object that was created
        /// </returns>
        abstract member addOneTimeListener<'T>: e: obj * listener: 'T * ?options: WebMidi.addOneTimeListener.options -> Webmidi.Listener
        /// <summary>
        /// Adds a one-time event listener that will trigger a function callback when the specified event
        /// is dispatched.
        ///
        /// Here are the events you can listen to:   connected, disabled, disconnected, enabled,
        /// midiaccessgranted, portschanged, error
        /// </summary>
        /// <param name="event">
        /// The type of the event.
        /// </param>
        /// <param name="listener">
        /// A callback function to execute when the specified event
        /// is detected. This function will receive an event parameter object. For details on this object's
        /// properties, check out the documentation for the various events (links above).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// The listener object that was created
        /// </returns>
        abstract member addOneTimeListener<'T>: e: Webmidi.WebMidiEventMap.Key<'T> * listener: 'T * ?options: WebMidi.addOneTimeListener.options -> Webmidi.Listener
        /// <summary>
        /// Adds a one-time event listener that will trigger a function callback when the specified event
        /// is dispatched.
        ///
        /// Here are the events you can listen to:   connected, disabled, disconnected, enabled,
        /// midiaccessgranted, portschanged, error
        /// </summary>
        /// <param name="event">
        /// The type of the event.
        /// </param>
        /// <param name="listener">
        /// A callback function to execute when the specified event
        /// is detected. This function will receive an event parameter object. For details on this object's
        /// properties, check out the documentation for the various events (links above).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// The listener object that was created
        /// </returns>
        abstract member addOneTimeListener<'T>: e: U2<obj, Webmidi.WebMidiEventMap.Key<'T>> * listener: 'T * ?options: WebMidi.addOneTimeListener.options -> Webmidi.Listener
        /// <summary>
        /// Completely disables **WebMidi.js** by unlinking the MIDI subsystem's interface and closing all
        /// [<c>Input</c>](Input) and [<c>Output</c>](Output) objects that may have been opened. This also means that
        /// listeners added to [<c>Input</c>](Input) objects, [<c>Output</c>](Output) objects or to <c>WebMidi</c> itself
        /// are also destroyed.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// The Web MIDI API is not supported by your environment.
        /// </remarks>
        abstract member disable: unit -> JS.Promise<ResizeArray<obj>>
        /// <summary>
        /// Checks if the Web MIDI API is available in the current environment and then tries to connect to
        /// the host's MIDI subsystem. This is an asynchronous operation and it causes a security prompt to
        /// be displayed to the user.
        ///
        /// To enable the use of MIDI system exclusive messages, the <c>sysex</c> option should be set to
        /// <c>true</c>. However, under some environments (e.g. Jazz-Plugin), the <c>sysex</c> option is ignored
        /// and system exclusive messages are always enabled. You can check the
        /// [<c>sysexEnabled</c>](#sysexEnabled) property to confirm.
        ///
        /// To enable access to software synthesizers available on the host, you would set the <c>software</c>
        /// option to <c>true</c>. However, this option is only there to future-proof the library as support for
        /// software synths has not yet been implemented in any browser (as of September 2021).
        ///
        /// By the way, if you call the [<c>enable()</c>](#enable) method while WebMidi.js is already enabled,
        /// the callback function will be executed (if any), the promise will resolve but the events
        /// ([<c>"midiaccessgranted"</c>](#event:midiaccessgranted), [<c>"connected"</c>](#event:connected) and
        /// [<c>"enabled"</c>](#event:enabled)) will not be fired.
        ///
        /// There are 3 ways to execute code after <c>WebMidi</c> has been enabled:
        ///
        /// - Pass a callback function in the <c>options</c>
        /// - Listen to the [<c>"enabled"</c>](#event:enabled) event
        /// - Wait for the promise to resolve
        ///
        /// In order, this is what happens towards the end of the enabling process:
        ///
        /// 1. [<c>"midiaccessgranted"</c>](#event:midiaccessgranted) event is triggered once the user has
        /// granted access to use MIDI.
        /// 2. [<c>"connected"</c>](#event:connected) events are triggered (for each available input and output)
        /// 3. [<c>"enabled"</c>](#event:enabled) event is triggered when WebMidi.js is fully ready
        /// 4. specified callback (if any) is executed
        /// 5. promise is resolved and fulfilled with the <c>WebMidi</c> object.
        ///
        /// **Important note**: starting with Chrome v77, a page using Web MIDI API must be hosted on a
        /// secure origin (<c>https://</c>, <c>localhost</c> or <c>file:///</c>) and the user will always be prompted to
        /// authorize the operation (no matter if the <c>sysex</c> option is <c>true</c> or not).
        ///
        /// ##### Example
        /// <code lang="js">
        /// // Enabling WebMidi and using the promise
        /// WebMidi.enable().then(() => {
        ///   console.log("WebMidi.js has been enabled!");
        /// })
        /// </code>
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// The Web MIDI API is not supported in your environment.
        ///
        /// Jazz-Plugin must be installed to use WebMIDIAPIShim.
        /// </remarks>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// The promise is fulfilled with the <c>WebMidi</c> object for
        /// chainability
        /// </returns>
        abstract member enable: ?options: WebMidi.enable.options -> JS.Promise<Webmidi.WebMidi>
        /// <summary>
        /// Returns the [<c>Input</c>](Input) object that matches the specified ID string or <c>false</c> if no
        /// matching input is found. As per the Web MIDI API specification, IDs are strings (not integers).
        ///
        /// Please note that IDs change from one host to another. For example, Chrome does not use the same
        /// kind of IDs as Jazz-Plugin.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// WebMidi is not enabled.
        /// </remarks>
        /// <param name="id">
        /// The ID string of the input. IDs can be viewed by looking at the
        /// [<c>WebMidi.inputs</c>](WebMidi#inputs) array. Even though they sometimes look like integers, IDs
        /// are strings.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// An [<c>Input</c>](Input) object matching the specified ID string or <c>undefined</c>
        /// if no matching input can be found.
        /// </returns>
        abstract member getInputById: id: string * ?options: WebMidi.getInputById.options -> Webmidi.Input
        /// <summary>
        /// Returns the first [<c>Input</c>](Input) object whose name **contains** the specified string. Note
        /// that the port names change from one environment to another. For example, Chrome does not report
        /// input names in the same way as the Jazz-Plugin does.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// WebMidi is not enabled.
        /// </remarks>
        /// <param name="name">
        /// The non-empty string to look for within the name of MIDI inputs (such as
        /// those visible in the [inputs](WebMidi#inputs) array).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// The [<c>Input</c>](Input) that was found or <c>undefined</c> if no input contained the
        /// specified name.
        /// </returns>
        abstract member getInputByName: name: string * ?options: WebMidi.getInputByName.options -> Webmidi.Input option
        /// <summary>
        /// Returns the [<c>Output</c>](Output) object that matches the specified ID string or <c>false</c> if no
        /// matching output is found. As per the Web MIDI API specification, IDs are strings (not
        /// integers).
        ///
        /// Please note that IDs change from one host to another. For example, Chrome does not use the same
        /// kind of IDs as Jazz-Plugin.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// WebMidi is not enabled.
        /// </remarks>
        /// <param name="id">
        /// The ID string of the port. IDs can be viewed by looking at the
        /// [<c>WebMidi.outputs</c>](WebMidi#outputs) array.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// An [<c>Output</c>](Output) object matching the specified ID string. If no
        /// matching output can be found, the method returns <c>undefined</c>.
        /// </returns>
        abstract member getOutputById: id: string * ?options: WebMidi.getOutputById.options -> Webmidi.Output option
        /// <summary>
        /// Returns the first [<c>Output</c>](Output) object whose name **contains** the specified string. Note
        /// that the port names change from one environment to another. For example, Chrome does not report
        /// input names in the same way as the Jazz-Plugin does.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// WebMidi is not enabled.
        /// </remarks>
        /// <param name="name">
        /// The non-empty string to look for within the name of MIDI inputs (such as
        /// those visible in the [<c>outputs</c>](#outputs) array).
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// The [<c>Output</c>](Output) that was found or <c>undefined</c> if no output matched
        /// the specified name.
        /// </returns>
        abstract member getOutputByName: name: string * ?options: WebMidi.getOutputByName.options -> Webmidi.Output
        /// <summary>
        /// Checks if the specified event type is already defined to trigger the specified callback
        /// function.
        /// </summary>
        /// <param name="event">
        /// The type of the event.
        /// </param>
        /// <param name="listener">
        /// The callback function to check for.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Boolean value indicating whether or not the <c>Input</c> or <c>InputChannel</c>
        /// already has this listener defined.
        /// </returns>
        abstract member hasListener<'T>: e: obj * listener: 'T -> bool
        /// <summary>
        /// Checks if the specified event type is already defined to trigger the specified callback
        /// function.
        /// </summary>
        /// <param name="event">
        /// The type of the event.
        /// </param>
        /// <param name="listener">
        /// The callback function to check for.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Boolean value indicating whether or not the <c>Input</c> or <c>InputChannel</c>
        /// already has this listener defined.
        /// </returns>
        abstract member hasListener<'T>: e: Webmidi.WebMidiEventMap.Key<'T> * listener: 'T -> bool
        /// <summary>
        /// Checks if the specified event type is already defined to trigger the specified callback
        /// function.
        /// </summary>
        /// <param name="event">
        /// The type of the event.
        /// </param>
        /// <param name="listener">
        /// The callback function to check for.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        /// <returns>
        /// Boolean value indicating whether or not the <c>Input</c> or <c>InputChannel</c>
        /// already has this listener defined.
        /// </returns>
        abstract member hasListener<'T>: e: U2<obj, Webmidi.WebMidiEventMap.Key<'T>> * listener: 'T -> bool
        /// <summary>
        /// Removes the specified listener for the specified event. If no listener is specified, all
        /// listeners for the specified event will be removed.
        /// </summary>
        /// <param name="type">
        /// The type of the event.
        /// </param>
        /// <param name="listener">
        /// The callback function to check for.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        abstract member removeListener: unit -> unit
        /// <summary>
        /// Removes the specified listener for the specified event. If no listener is specified, all
        /// listeners for the specified event will be removed.
        /// </summary>
        /// <param name="type">
        /// The type of the event.
        /// </param>
        /// <param name="listener">
        /// The callback function to check for.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        abstract member removeListener<'T>: ``type``: obj * ?listener: 'T * ?options: WebMidi.removeListener.options -> unit
        /// <summary>
        /// Removes the specified listener for the specified event. If no listener is specified, all
        /// listeners for the specified event will be removed.
        /// </summary>
        /// <param name="type">
        /// The type of the event.
        /// </param>
        /// <param name="listener">
        /// The callback function to check for.
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        abstract member removeListener<'T>: ``type``: Webmidi.WebMidiEventMap.Key<'T> * ?listener: 'T * ?options: WebMidi.removeListener.options -> unit
        /// <summary>
        /// Indicates whether access to the host's MIDI subsystem is active or not.
        /// </summary>
        abstract member enabled: bool with get
        /// <summary>
        /// An array of all currently available MIDI inputs.
        /// </summary>
        abstract member inputs: ResizeArray<Webmidi.Input> with get
        /// <summary>
        /// An integer to offset the octave of notes received from external devices or sent to external
        /// devices.
        ///
        /// When a MIDI message comes in on an input channel the reported note name will be offset. For
        /// example, if the <c>octaveOffset</c> is set to <c>-1</c> and a [<c>"noteon"</c>](InputChannel#event:noteon)
        /// message with MIDI number 60 comes in, the note will be reported as C3 (instead of C4).
        ///
        /// By the same token, when [<c>OutputChannel.playNote()</c>](OutputChannel#playNote) is called, the
        /// MIDI note number being sent will be offset. If <c>octaveOffset</c> is set to <c>-1</c>, the MIDI note
        /// number sent will be 72 (instead of 60).
        /// </summary>
        abstract member octaveOffset: float with get, set
        /// <summary>
        /// An array of all currently available MIDI outputs as [<c>Output</c>](Output) objects.
        /// </summary>
        abstract member outputs: ResizeArray<Webmidi.Output> with get
        /// <summary>
        /// Indicates whether the environment provides support for the Web MIDI API or not.
        ///
        /// **Note**: in environments that do not offer built-in MIDI support, this will report <c>true</c> if
        /// the
        /// [<c>navigator.requestMIDIAccess</c>](https://developer.mozilla.org/en-US/docs/Web/API/MIDIAccess)
        /// function is available. For example, if you have installed WebMIDIAPIShim.js but no plugin, this
        /// property will be <c>true</c> even though actual support might not be there.
        /// </summary>
        abstract member supported: bool with get
        /// <summary>
        /// Indicates whether MIDI system exclusive messages have been activated when WebMidi.js was
        /// enabled via the [<c>enable()</c>](#enable) method.
        /// </summary>
        abstract member sysexEnabled: bool with get
        /// <summary>
        /// The elapsed time, in milliseconds, since the time
        /// [origin](https://developer.mozilla.org/en-US/docs/Web/API/DOMHighResTimeStamp#The_time_origin).
        /// Said simply, it is the number of milliseconds that passed since the page was loaded. Being a
        /// floating-point number, it has sub-millisecond accuracy. According to the
        /// [documentation](https://developer.mozilla.org/en-US/docs/Web/API/DOMHighResTimeStamp), the
        /// time should be accurate to 5 µs (microseconds). However, due to various constraints, the
        /// browser might only be accurate to one millisecond.
        ///
        /// Note: <c>WebMidi.time</c> is simply an alias to <c>performance.now()</c>.
        /// </summary>
        abstract member time: float with get
        /// <summary>
        /// The version of the library as a [semver](https://semver.org/) string.
        /// </summary>
        abstract member version: string with get
        /// <summary>
        /// The flavour of the library. Can be one of:
        ///
        /// * <c>esm</c>: ECMAScript Module
        /// * <c>cjs</c>: CommonJS Module
        /// * <c>iife</c>: Immediately-Invoked Function Expression
        /// </summary>
        abstract member flavour: string with get
        /// <summary>
        /// Identifier (Symbol) to use when adding or removing a listener that should be triggered when any
        /// events occur.
        /// </summary>
        static member inline ANY_EVENT
            with get () : obj =
                nativeOnly
        /// <summary>
        /// An object containing a property for each event with at least one registered listener. Each
        /// event property contains an array of all the [<c>Listener</c>]<see href="Listener">Listener</see> objects registered
        /// for the event.
        /// </summary>
        abstract member eventMap: obj with get, set
        /// <summary>
        /// Whether or not the execution of callbacks is currently suspended for this emitter.
        /// </summary>
        abstract member eventsSuspended: bool with get, set
        /// <summary>
        /// An array of all the unique event names for which the emitter has at least one registered
        /// listener.
        ///
        /// Note: this excludes global events registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> because they are not tied to a
        /// specific event.
        /// </summary>
        abstract member eventNames: ResizeArray<string> with get
        /// <summary>
        /// Returns an array of all the [<c>Listener</c>]<see href="Listener">Listener</see> objects that have been registered for
        /// a specific event.
        ///
        /// Please note that global events (those added with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>) are not returned for "regular"
        /// events. To get the list of global listeners, specifically use
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> as the parameter.
        /// </summary>
        /// <param name="event">
        /// The event to get listeners for.
        /// </param>
        /// <returns>
        /// An array of [<c>Listener</c>]<see href="Listener">Listener</see> objects.
        /// </returns>
        abstract member getListeners: event: string -> ResizeArray<Webmidi.Listener>
        /// <summary>
        /// Returns an array of all the [<c>Listener</c>]<see href="Listener">Listener</see> objects that have been registered for
        /// a specific event.
        ///
        /// Please note that global events (those added with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>) are not returned for "regular"
        /// events. To get the list of global listeners, specifically use
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> as the parameter.
        /// </summary>
        /// <param name="event">
        /// The event to get listeners for.
        /// </param>
        /// <returns>
        /// An array of [<c>Listener</c>]<see href="Listener">Listener</see> objects.
        /// </returns>
        abstract member getListeners: event: obj -> ResizeArray<Webmidi.Listener>
        /// <summary>
        /// Returns an array of all the [<c>Listener</c>]<see href="Listener">Listener</see> objects that have been registered for
        /// a specific event.
        ///
        /// Please note that global events (those added with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>) are not returned for "regular"
        /// events. To get the list of global listeners, specifically use
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> as the parameter.
        /// </summary>
        /// <param name="event">
        /// The event to get listeners for.
        /// </param>
        /// <returns>
        /// An array of [<c>Listener</c>]<see href="Listener">Listener</see> objects.
        /// </returns>
        abstract member getListeners: event: U2<string, obj> -> ResizeArray<Webmidi.Listener>
        /// <summary>
        /// Suspends execution of all callbacks functions registered for the specified event type.
        ///
        /// You can suspend execution of callbacks registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> by passing
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> to <c>suspendEvent()</c>. Beware that this
        /// will not suspend all callbacks but only those registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>. While this may seem counter-intuitive
        /// at first glance, it allows the selective suspension of global listeners while leaving other
        /// listeners alone. If you truly want to suspends all callbacks for a specific
        /// [<c>EventEmitter</c>]<see href="EventEmitter">EventEmitter</see>, simply set its <c>eventsSuspended</c> property to <c>true</c>.
        /// </summary>
        /// <param name="event">
        /// The event name (or <c>EventEmitter.ANY_EVENT</c>) for which to suspend
        /// execution of all callback functions.
        /// </param>
        abstract member suspendEvent: event: string -> unit
        /// <summary>
        /// Suspends execution of all callbacks functions registered for the specified event type.
        ///
        /// You can suspend execution of callbacks registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> by passing
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> to <c>suspendEvent()</c>. Beware that this
        /// will not suspend all callbacks but only those registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>. While this may seem counter-intuitive
        /// at first glance, it allows the selective suspension of global listeners while leaving other
        /// listeners alone. If you truly want to suspends all callbacks for a specific
        /// [<c>EventEmitter</c>]<see href="EventEmitter">EventEmitter</see>, simply set its <c>eventsSuspended</c> property to <c>true</c>.
        /// </summary>
        /// <param name="event">
        /// The event name (or <c>EventEmitter.ANY_EVENT</c>) for which to suspend
        /// execution of all callback functions.
        /// </param>
        abstract member suspendEvent: event: obj -> unit
        /// <summary>
        /// Suspends execution of all callbacks functions registered for the specified event type.
        ///
        /// You can suspend execution of callbacks registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> by passing
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> to <c>suspendEvent()</c>. Beware that this
        /// will not suspend all callbacks but only those registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>. While this may seem counter-intuitive
        /// at first glance, it allows the selective suspension of global listeners while leaving other
        /// listeners alone. If you truly want to suspends all callbacks for a specific
        /// [<c>EventEmitter</c>]<see href="EventEmitter">EventEmitter</see>, simply set its <c>eventsSuspended</c> property to <c>true</c>.
        /// </summary>
        /// <param name="event">
        /// The event name (or <c>EventEmitter.ANY_EVENT</c>) for which to suspend
        /// execution of all callback functions.
        /// </param>
        abstract member suspendEvent: event: U2<string, obj> -> unit
        /// <summary>
        /// Resumes execution of all suspended callback functions registered for the specified event type.
        ///
        /// You can resume execution of callbacks registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> by passing
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> to <c>unsuspendEvent()</c>. Beware that
        /// this will not resume all callbacks but only those registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>. While this may seem
        /// counter-intuitive, it allows the selective unsuspension of global listeners while leaving other
        /// callbacks alone.
        /// </summary>
        /// <param name="event">
        /// The event name (or <c>EventEmitter.ANY_EVENT</c>) for which to resume
        /// execution of all callback functions.
        /// </param>
        abstract member unsuspendEvent: event: string -> unit
        /// <summary>
        /// Resumes execution of all suspended callback functions registered for the specified event type.
        ///
        /// You can resume execution of callbacks registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> by passing
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> to <c>unsuspendEvent()</c>. Beware that
        /// this will not resume all callbacks but only those registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>. While this may seem
        /// counter-intuitive, it allows the selective unsuspension of global listeners while leaving other
        /// callbacks alone.
        /// </summary>
        /// <param name="event">
        /// The event name (or <c>EventEmitter.ANY_EVENT</c>) for which to resume
        /// execution of all callback functions.
        /// </param>
        abstract member unsuspendEvent: event: obj -> unit
        /// <summary>
        /// Resumes execution of all suspended callback functions registered for the specified event type.
        ///
        /// You can resume execution of callbacks registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> by passing
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> to <c>unsuspendEvent()</c>. Beware that
        /// this will not resume all callbacks but only those registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>. While this may seem
        /// counter-intuitive, it allows the selective unsuspension of global listeners while leaving other
        /// callbacks alone.
        /// </summary>
        /// <param name="event">
        /// The event name (or <c>EventEmitter.ANY_EVENT</c>) for which to resume
        /// execution of all callback functions.
        /// </param>
        abstract member unsuspendEvent: event: U2<string, obj> -> unit
        /// <summary>
        /// Returns the number of listeners registered for a specific event.
        ///
        /// Please note that global events (those added with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>) do not count towards the remaining
        /// number for a "regular" event. To get the number of global listeners, specifically use
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> as the parameter.
        /// </summary>
        /// <param name="event">
        /// The event which is usually a string but can also be the special
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> symbol.
        /// </param>
        /// <returns>
        /// An integer representing the number of listeners registered for the specified
        /// event.
        /// </returns>
        abstract member getListenerCount: event: string -> float
        /// <summary>
        /// Returns the number of listeners registered for a specific event.
        ///
        /// Please note that global events (those added with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>) do not count towards the remaining
        /// number for a "regular" event. To get the number of global listeners, specifically use
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> as the parameter.
        /// </summary>
        /// <param name="event">
        /// The event which is usually a string but can also be the special
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> symbol.
        /// </param>
        /// <returns>
        /// An integer representing the number of listeners registered for the specified
        /// event.
        /// </returns>
        abstract member getListenerCount: event: obj -> float
        /// <summary>
        /// Returns the number of listeners registered for a specific event.
        ///
        /// Please note that global events (those added with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>) do not count towards the remaining
        /// number for a "regular" event. To get the number of global listeners, specifically use
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> as the parameter.
        /// </summary>
        /// <param name="event">
        /// The event which is usually a string but can also be the special
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> symbol.
        /// </param>
        /// <returns>
        /// An integer representing the number of listeners registered for the specified
        /// event.
        /// </returns>
        abstract member getListenerCount: event: U2<string, obj> -> float
        /// <summary>
        /// Executes the callback function of all the [<c>Listener</c>]<see href="Listener">Listener</see> objects registered for
        /// a given event. The callback functions are passed the additional arguments passed to <c>emit()</c>
        /// (if any) followed by the arguments present in the [<c>arguments</c>](Listener#arguments) property of
        /// the [<c>Listener</c>](Listener) object (if any).
        ///
        /// If the [<c>eventsSuspended</c>]<see href="#eventsSuspended">#eventsSuspended</see> property is <c>true</c> or the
        /// [<c>Listener.suspended</c>]<see href="Listener#suspended">Listener#suspended</see> property is <c>true</c>, the callback functions
        /// will not be executed.
        ///
        /// This function returns an array containing the return values of each of the callbacks.
        ///
        /// It should be noted that the regular listeners are triggered first followed by the global
        /// listeners (those added with [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see>).
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// The <c>event</c> parameter must be a string.
        /// </remarks>
        /// <param name="event">
        /// The event
        /// </param>
        /// <param name="args">
        /// Arbitrary number of arguments to pass along to the callback functions
        /// </param>
        /// <returns>
        /// An array containing the return value of each of the executed listener
        /// functions.
        /// </returns>
        abstract member emit: event: string * [<ParamArray>] args: obj [] -> ResizeArray<obj>
        /// <summary>
        /// The <c>waitFor()</c> method is an async function which returns a promise. The promise is fulfilled
        /// when the specified event occurs. The event can be a regular event or
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> (if you want to resolve as soon as any
        /// event is emitted).
        ///
        /// If the <c>duration</c> option is set, the promise will only be fulfilled if the event is emitted
        /// within the specified duration. If the event has not been fulfilled after the specified
        /// duration, the promise is rejected. This makes it super easy to wait for an event and timeout
        /// after a certain time if the event is not triggered.
        /// </summary>
        /// <param name="event">
        /// The event to wait for
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        abstract member waitFor: event: string * ?options: EventEmitter.waitFor.options -> JS.Promise<obj>
        /// <summary>
        /// The <c>waitFor()</c> method is an async function which returns a promise. The promise is fulfilled
        /// when the specified event occurs. The event can be a regular event or
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> (if you want to resolve as soon as any
        /// event is emitted).
        ///
        /// If the <c>duration</c> option is set, the promise will only be fulfilled if the event is emitted
        /// within the specified duration. If the event has not been fulfilled after the specified
        /// duration, the promise is rejected. This makes it super easy to wait for an event and timeout
        /// after a certain time if the event is not triggered.
        /// </summary>
        /// <param name="event">
        /// The event to wait for
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        abstract member waitFor: event: obj * ?options: EventEmitter.waitFor.options -> JS.Promise<obj>
        /// <summary>
        /// The <c>waitFor()</c> method is an async function which returns a promise. The promise is fulfilled
        /// when the specified event occurs. The event can be a regular event or
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> (if you want to resolve as soon as any
        /// event is emitted).
        ///
        /// If the <c>duration</c> option is set, the promise will only be fulfilled if the event is emitted
        /// within the specified duration. If the event has not been fulfilled after the specified
        /// duration, the promise is rejected. This makes it super easy to wait for an event and timeout
        /// after a certain time if the event is not triggered.
        /// </summary>
        /// <param name="event">
        /// The event to wait for
        /// </param>
        /// <param name="options">
        ///
        /// </param>
        abstract member waitFor: event: U2<string, obj> * ?options: EventEmitter.waitFor.options -> JS.Promise<obj>
        /// <summary>
        /// The number of unique events that have registered listeners.
        ///
        /// Note: this excludes global events registered with
        /// [<c>EventEmitter.ANY_EVENT</c>]<see href="EventEmitter#ANY_EVENT">EventEmitter#ANY_EVENT</see> because they are not tied to a
        /// specific event.
        /// </summary>
        abstract member eventCount: float with get

    type EventEmitterCallback =
        delegate of [<ParamArray>] args: obj [] -> unit

    /// <summary>
    /// The <c>Event</c> object is transmitted when state change events occur.
    ///
    /// WebMidi
    ///  * disabled
    ///  * enabled
    ///  * midiaccessgranted
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type Event =
        abstract member target: U4<Webmidi.Input, Webmidi.InputChannel, Webmidi.Output, Webmidi.WebMidi> with get, set
        abstract member timestamp: Glutinum.Web.DOMHighResTimeStamp with get, set
        abstract member ``type``: string with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (target: Webmidi.Input, timestamp: Glutinum.Web.DOMHighResTimeStamp, ``type``: string) : Event = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (target: Webmidi.InputChannel, timestamp: Glutinum.Web.DOMHighResTimeStamp, ``type``: string) : Event = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (target: Webmidi.Output, timestamp: Glutinum.Web.DOMHighResTimeStamp, ``type``: string) : Event = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (target: Webmidi.WebMidi, timestamp: Glutinum.Web.DOMHighResTimeStamp, ``type``: string) : Event = nativeOnly

    /// <summary>
    /// The <c>ErrorEvent</c> object is transmitted when an error occurs. Only the <c>WebMidi</c> object dispatches
    /// this type of event.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type ErrorEvent =
        inherit Webmidi.Event
        abstract member error: obj with get, set
        abstract member target: Webmidi.WebMidi with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (timestamp: Glutinum.Web.DOMHighResTimeStamp, ``type``: string, error: obj, target: Webmidi.WebMidi) : ErrorEvent = nativeOnly

    /// <summary>
    /// The <c>PortEvent</c> object is transmitted when an event occurs on an <c>Input</c> or <c>Output</c> port.
    ///
    /// Input
    ///  * closed
    ///  * disconnected
    ///  * opened
    ///
    /// Output
    ///  * closed
    ///  * disconnected
    ///  * opened
    ///
    /// WebMidi
    ///  * connected
    ///  * disconnected
    ///  * portschanged
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type PortEvent =
        inherit Webmidi.Event
        abstract member port: obj with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (target: Webmidi.Input, timestamp: Glutinum.Web.DOMHighResTimeStamp, ``type``: string, port: obj) : PortEvent = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (target: Webmidi.InputChannel, timestamp: Glutinum.Web.DOMHighResTimeStamp, ``type``: string, port: obj) : PortEvent = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (target: Webmidi.Output, timestamp: Glutinum.Web.DOMHighResTimeStamp, ``type``: string, port: obj) : PortEvent = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (target: Webmidi.WebMidi, timestamp: Glutinum.Web.DOMHighResTimeStamp, ``type``: string, port: obj) : PortEvent = nativeOnly

    /// <summary>
    /// The <c>MessageEvent</c> object is transmitted when a MIDI message has been received. These events
    /// are dispatched by <c>Input</c> and <c>InputChannel</c> classes:
    ///
    /// <c>Input</c>: activesensing, clock, continue, midimessage, reset, songposition, songselect, start,
    /// stop, sysex, timecode, tunerequest, unknownmessage
    ///
    /// <c>InputChannel</c>: allnotesoff, allsoundoff, midimessage, resetallcontrollers, channelaftertouch,
    /// localcontrol, monomode, omnimode, pitchbend, programchange
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type MessageEvent =
        inherit Webmidi.PortEvent
        abstract member message: Webmidi.Message with get, set
        abstract member port: Webmidi.Input with get, set
        abstract member rawValue: float option with get, set
        abstract member target: U2<Webmidi.Input, Webmidi.InputChannel> with get, set
        abstract member value: U2<float, bool> option with get, set
        abstract member data: JS.Uint8Array with get, set
        abstract member rawData: JS.Uint8Array with get, set
        abstract member statusByte: obj with get, set
        abstract member dataBytes: JS.Uint8Array with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (timestamp: Glutinum.Web.DOMHighResTimeStamp, ``type``: string, message: Webmidi.Message, port: Webmidi.Input, target: Webmidi.Input, data: JS.Uint8Array, rawData: JS.Uint8Array, statusByte: obj, dataBytes: JS.Uint8Array, ?rawValue: float) : MessageEvent = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (timestamp: Glutinum.Web.DOMHighResTimeStamp, ``type``: string, message: Webmidi.Message, port: Webmidi.Input, target: Webmidi.Input, data: JS.Uint8Array, rawData: JS.Uint8Array, statusByte: obj, dataBytes: JS.Uint8Array, value: float, ?rawValue: float) : MessageEvent = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (timestamp: Glutinum.Web.DOMHighResTimeStamp, ``type``: string, message: Webmidi.Message, port: Webmidi.Input, target: Webmidi.Input, data: JS.Uint8Array, rawData: JS.Uint8Array, statusByte: obj, dataBytes: JS.Uint8Array, value: bool, ?rawValue: float) : MessageEvent = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (timestamp: Glutinum.Web.DOMHighResTimeStamp, ``type``: string, message: Webmidi.Message, port: Webmidi.Input, target: Webmidi.InputChannel, data: JS.Uint8Array, rawData: JS.Uint8Array, statusByte: obj, dataBytes: JS.Uint8Array, ?rawValue: float) : MessageEvent = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (timestamp: Glutinum.Web.DOMHighResTimeStamp, ``type``: string, message: Webmidi.Message, port: Webmidi.Input, target: Webmidi.InputChannel, data: JS.Uint8Array, rawData: JS.Uint8Array, statusByte: obj, dataBytes: JS.Uint8Array, value: float, ?rawValue: float) : MessageEvent = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (timestamp: Glutinum.Web.DOMHighResTimeStamp, ``type``: string, message: Webmidi.Message, port: Webmidi.Input, target: Webmidi.InputChannel, data: JS.Uint8Array, rawData: JS.Uint8Array, statusByte: obj, dataBytes: JS.Uint8Array, value: bool, ?rawValue: float) : MessageEvent = nativeOnly

    /// <summary>
    /// The <c>ControlChangeMessageEvent</c> object is transmitted when a control change MIDI message has been
    /// received. There is a general <c>controlchange</c> event and a specific <c>controlchange-controllerxxx</c>
    /// for each controller.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type ControlChangeMessageEvent =
        inherit Webmidi.MessageEvent
        abstract member controller: ControlChangeMessageEvent.controller with get, set
        abstract member port: Webmidi.Input with get, set
        abstract member subtype: string option with get, set
        abstract member target: U2<Webmidi.Input, Webmidi.InputChannel> with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (timestamp: Glutinum.Web.DOMHighResTimeStamp, ``type``: string, message: Webmidi.Message, data: JS.Uint8Array, rawData: JS.Uint8Array, statusByte: obj, dataBytes: JS.Uint8Array, controller: ControlChangeMessageEvent.controller, port: Webmidi.Input, target: Webmidi.Input, ?rawValue: float, ?subtype: string) : ControlChangeMessageEvent = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (timestamp: Glutinum.Web.DOMHighResTimeStamp, ``type``: string, message: Webmidi.Message, data: JS.Uint8Array, rawData: JS.Uint8Array, statusByte: obj, dataBytes: JS.Uint8Array, controller: ControlChangeMessageEvent.controller, port: Webmidi.Input, target: Webmidi.Input, value: float, ?rawValue: float, ?subtype: string) : ControlChangeMessageEvent = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (timestamp: Glutinum.Web.DOMHighResTimeStamp, ``type``: string, message: Webmidi.Message, data: JS.Uint8Array, rawData: JS.Uint8Array, statusByte: obj, dataBytes: JS.Uint8Array, controller: ControlChangeMessageEvent.controller, port: Webmidi.Input, target: Webmidi.Input, value: bool, ?rawValue: float, ?subtype: string) : ControlChangeMessageEvent = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (timestamp: Glutinum.Web.DOMHighResTimeStamp, ``type``: string, message: Webmidi.Message, data: JS.Uint8Array, rawData: JS.Uint8Array, statusByte: obj, dataBytes: JS.Uint8Array, controller: ControlChangeMessageEvent.controller, port: Webmidi.Input, target: Webmidi.InputChannel, ?rawValue: float, ?subtype: string) : ControlChangeMessageEvent = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (timestamp: Glutinum.Web.DOMHighResTimeStamp, ``type``: string, message: Webmidi.Message, data: JS.Uint8Array, rawData: JS.Uint8Array, statusByte: obj, dataBytes: JS.Uint8Array, controller: ControlChangeMessageEvent.controller, port: Webmidi.Input, target: Webmidi.InputChannel, value: float, ?rawValue: float, ?subtype: string) : ControlChangeMessageEvent = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (timestamp: Glutinum.Web.DOMHighResTimeStamp, ``type``: string, message: Webmidi.Message, data: JS.Uint8Array, rawData: JS.Uint8Array, statusByte: obj, dataBytes: JS.Uint8Array, controller: ControlChangeMessageEvent.controller, port: Webmidi.Input, target: Webmidi.InputChannel, value: bool, ?rawValue: float, ?subtype: string) : ControlChangeMessageEvent = nativeOnly

    /// <summary>
    /// The <c>NoteMessageEvent</c> object is transmitted when a note-related MIDI message (<c>noteoff</c>,
    /// <c>noteon</c> or <c>keyaftertouch</c>) is received on an input channel
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type NoteMessageEvent =
        inherit Webmidi.MessageEvent
        abstract member note: Webmidi.Note with get, set
        abstract member port: Webmidi.Input with get, set
        abstract member target: U2<Webmidi.Input, Webmidi.InputChannel> with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (timestamp: Glutinum.Web.DOMHighResTimeStamp, ``type``: string, message: Webmidi.Message, data: JS.Uint8Array, rawData: JS.Uint8Array, statusByte: obj, dataBytes: JS.Uint8Array, note: Webmidi.Note, port: Webmidi.Input, target: Webmidi.Input, ?rawValue: float) : NoteMessageEvent = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (timestamp: Glutinum.Web.DOMHighResTimeStamp, ``type``: string, message: Webmidi.Message, data: JS.Uint8Array, rawData: JS.Uint8Array, statusByte: obj, dataBytes: JS.Uint8Array, note: Webmidi.Note, port: Webmidi.Input, target: Webmidi.Input, value: float, ?rawValue: float) : NoteMessageEvent = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (timestamp: Glutinum.Web.DOMHighResTimeStamp, ``type``: string, message: Webmidi.Message, data: JS.Uint8Array, rawData: JS.Uint8Array, statusByte: obj, dataBytes: JS.Uint8Array, note: Webmidi.Note, port: Webmidi.Input, target: Webmidi.Input, value: bool, ?rawValue: float) : NoteMessageEvent = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (timestamp: Glutinum.Web.DOMHighResTimeStamp, ``type``: string, message: Webmidi.Message, data: JS.Uint8Array, rawData: JS.Uint8Array, statusByte: obj, dataBytes: JS.Uint8Array, note: Webmidi.Note, port: Webmidi.Input, target: Webmidi.InputChannel, ?rawValue: float) : NoteMessageEvent = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (timestamp: Glutinum.Web.DOMHighResTimeStamp, ``type``: string, message: Webmidi.Message, data: JS.Uint8Array, rawData: JS.Uint8Array, statusByte: obj, dataBytes: JS.Uint8Array, note: Webmidi.Note, port: Webmidi.Input, target: Webmidi.InputChannel, value: float, ?rawValue: float) : NoteMessageEvent = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (timestamp: Glutinum.Web.DOMHighResTimeStamp, ``type``: string, message: Webmidi.Message, data: JS.Uint8Array, rawData: JS.Uint8Array, statusByte: obj, dataBytes: JS.Uint8Array, note: Webmidi.Note, port: Webmidi.Input, target: Webmidi.InputChannel, value: bool, ?rawValue: float) : NoteMessageEvent = nativeOnly

    /// <summary>
    /// The <c>ParameterNumberMessageEvent</c> object is transmitted when an RPN or NRPN message is received
    /// on an input channel.
    ///
    ///  * nrpn
    ///  * nrpn-datadecrement
    ///  * nrpn-dataincrement
    ///  * nrpn-dataentrycoarse
    ///  * nrpn-dataentryfine
    ///
    ///  * rpn
    ///  * rpn-datadecrement
    ///  * rpn-dataincrement
    ///  * rpn-dataentrycoarse
    ///  * rpn-dataentryfine
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type ParameterNumberMessageEvent =
        inherit Webmidi.MessageEvent
        abstract member parameter: string with get, set
        abstract member parameterMsb: float with get, set
        abstract member parameterLsb: float with get, set
        abstract member port: Webmidi.Input with get, set
        abstract member target: U2<Webmidi.Input, Webmidi.InputChannel> with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (timestamp: Glutinum.Web.DOMHighResTimeStamp, ``type``: string, message: Webmidi.Message, data: JS.Uint8Array, rawData: JS.Uint8Array, statusByte: obj, dataBytes: JS.Uint8Array, parameter: string, parameterMsb: float, parameterLsb: float, port: Webmidi.Input, target: Webmidi.Input, ?rawValue: float) : ParameterNumberMessageEvent = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (timestamp: Glutinum.Web.DOMHighResTimeStamp, ``type``: string, message: Webmidi.Message, data: JS.Uint8Array, rawData: JS.Uint8Array, statusByte: obj, dataBytes: JS.Uint8Array, parameter: string, parameterMsb: float, parameterLsb: float, port: Webmidi.Input, target: Webmidi.Input, value: float, ?rawValue: float) : ParameterNumberMessageEvent = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (timestamp: Glutinum.Web.DOMHighResTimeStamp, ``type``: string, message: Webmidi.Message, data: JS.Uint8Array, rawData: JS.Uint8Array, statusByte: obj, dataBytes: JS.Uint8Array, parameter: string, parameterMsb: float, parameterLsb: float, port: Webmidi.Input, target: Webmidi.Input, value: bool, ?rawValue: float) : ParameterNumberMessageEvent = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (timestamp: Glutinum.Web.DOMHighResTimeStamp, ``type``: string, message: Webmidi.Message, data: JS.Uint8Array, rawData: JS.Uint8Array, statusByte: obj, dataBytes: JS.Uint8Array, parameter: string, parameterMsb: float, parameterLsb: float, port: Webmidi.Input, target: Webmidi.InputChannel, ?rawValue: float) : ParameterNumberMessageEvent = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (timestamp: Glutinum.Web.DOMHighResTimeStamp, ``type``: string, message: Webmidi.Message, data: JS.Uint8Array, rawData: JS.Uint8Array, statusByte: obj, dataBytes: JS.Uint8Array, parameter: string, parameterMsb: float, parameterLsb: float, port: Webmidi.Input, target: Webmidi.InputChannel, value: float, ?rawValue: float) : ParameterNumberMessageEvent = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (timestamp: Glutinum.Web.DOMHighResTimeStamp, ``type``: string, message: Webmidi.Message, data: JS.Uint8Array, rawData: JS.Uint8Array, statusByte: obj, dataBytes: JS.Uint8Array, parameter: string, parameterMsb: float, parameterLsb: float, port: Webmidi.Input, target: Webmidi.InputChannel, value: bool, ?rawValue: float) : ParameterNumberMessageEvent = nativeOnly

    /// <summary>
    /// A map of all the events that can be passed to <c>InputChannel.addListener()</c>.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type InputChannelEventMap =
        abstract member midimessage: (Webmidi.MessageEvent -> unit) with get, set
        abstract member channelaftertouch: (Webmidi.MessageEvent -> unit) with get, set
        abstract member keyaftertouch: (Webmidi.NoteMessageEvent -> unit) with get, set
        abstract member noteoff: (Webmidi.NoteMessageEvent -> unit) with get, set
        abstract member noteon: (Webmidi.NoteMessageEvent -> unit) with get, set
        abstract member pitchbend: (Webmidi.MessageEvent -> unit) with get, set
        abstract member programchange: (Webmidi.MessageEvent -> unit) with get, set
        abstract member controlchange: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller0``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller1``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller2``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller3``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller4``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller5``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller6``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller7``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller8``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller9``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller10``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller11``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller12``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller13``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller14``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller15``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller16``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller17``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller18``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller19``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller20``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller21``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller22``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller23``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller24``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller25``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller26``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller27``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller28``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller29``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller30``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller31``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller32``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller33``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller34``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller35``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller36``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller37``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller38``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller39``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller40``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller41``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller42``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller43``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller44``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller45``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller46``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller47``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller48``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller49``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller50``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller51``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller52``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller53``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller54``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller55``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller56``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller57``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller58``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller59``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller60``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller61``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller62``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller63``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller64``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller65``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller66``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller67``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller68``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller69``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller70``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller71``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller72``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller73``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller74``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller75``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller76``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller77``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller78``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller79``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller80``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller81``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller82``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller83``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller84``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller85``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller86``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller87``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller88``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller89``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller90``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller91``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller92``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller93``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller94``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller95``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller96``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller97``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller98``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller99``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller100``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller101``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller102``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller103``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller104``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller105``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller106``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller107``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller108``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller109``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller110``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller111``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller112``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller113``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller114``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller115``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller116``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller117``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller118``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller119``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller120``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller121``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller122``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller123``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller124``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller125``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller126``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller127``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member allnotesoff: (Webmidi.MessageEvent -> unit) with get, set
        abstract member allsoundoff: (Webmidi.MessageEvent -> unit) with get, set
        abstract member localcontrol: (Webmidi.MessageEvent -> unit) with get, set
        abstract member monomode: (Webmidi.MessageEvent -> unit) with get, set
        abstract member omnimode: (Webmidi.MessageEvent -> unit) with get, set
        abstract member resetallcontrollers: (Webmidi.MessageEvent -> unit) with get, set
        abstract member nrpn: (Webmidi.ParameterNumberMessageEvent -> unit) with get, set
        abstract member ``nrpn-datadecrement``: (Webmidi.ParameterNumberMessageEvent -> unit) with get, set
        abstract member ``nrpn-dataincrement``: (Webmidi.ParameterNumberMessageEvent -> unit) with get, set
        abstract member ``nrpn-dataentrycoarse``: (Webmidi.ParameterNumberMessageEvent -> unit) with get, set
        abstract member ``nrpn-dataentryfine``: (Webmidi.ParameterNumberMessageEvent -> unit) with get, set
        abstract member rpn: (Webmidi.ParameterNumberMessageEvent -> unit) with get, set
        abstract member ``rpn-datadecrement``: (Webmidi.ParameterNumberMessageEvent -> unit) with get, set
        abstract member ``rpn-dataincrement``: (Webmidi.ParameterNumberMessageEvent -> unit) with get, set
        abstract member ``rpn-dataentrycoarse``: (Webmidi.ParameterNumberMessageEvent -> unit) with get, set
        abstract member ``rpn-dataentryfine``: (Webmidi.ParameterNumberMessageEvent -> unit) with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (midimessage: (Webmidi.MessageEvent -> unit), channelaftertouch: (Webmidi.MessageEvent -> unit), keyaftertouch: (Webmidi.NoteMessageEvent -> unit), noteoff: (Webmidi.NoteMessageEvent -> unit), noteon: (Webmidi.NoteMessageEvent -> unit), pitchbend: (Webmidi.MessageEvent -> unit), programchange: (Webmidi.MessageEvent -> unit), controlchange: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller0``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller1``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller2``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller3``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller4``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller5``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller6``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller7``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller8``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller9``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller10``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller11``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller12``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller13``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller14``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller15``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller16``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller17``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller18``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller19``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller20``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller21``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller22``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller23``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller24``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller25``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller26``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller27``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller28``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller29``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller30``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller31``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller32``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller33``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller34``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller35``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller36``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller37``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller38``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller39``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller40``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller41``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller42``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller43``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller44``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller45``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller46``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller47``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller48``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller49``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller50``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller51``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller52``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller53``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller54``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller55``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller56``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller57``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller58``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller59``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller60``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller61``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller62``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller63``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller64``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller65``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller66``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller67``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller68``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller69``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller70``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller71``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller72``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller73``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller74``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller75``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller76``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller77``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller78``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller79``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller80``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller81``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller82``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller83``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller84``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller85``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller86``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller87``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller88``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller89``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller90``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller91``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller92``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller93``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller94``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller95``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller96``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller97``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller98``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller99``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller100``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller101``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller102``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller103``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller104``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller105``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller106``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller107``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller108``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller109``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller110``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller111``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller112``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller113``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller114``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller115``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller116``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller117``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller118``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller119``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller120``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller121``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller122``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller123``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller124``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller125``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller126``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller127``: (Webmidi.ControlChangeMessageEvent -> unit), allnotesoff: (Webmidi.MessageEvent -> unit), allsoundoff: (Webmidi.MessageEvent -> unit), localcontrol: (Webmidi.MessageEvent -> unit), monomode: (Webmidi.MessageEvent -> unit), omnimode: (Webmidi.MessageEvent -> unit), resetallcontrollers: (Webmidi.MessageEvent -> unit), nrpn: (Webmidi.ParameterNumberMessageEvent -> unit), ``nrpn-datadecrement``: (Webmidi.ParameterNumberMessageEvent -> unit), ``nrpn-dataincrement``: (Webmidi.ParameterNumberMessageEvent -> unit), ``nrpn-dataentrycoarse``: (Webmidi.ParameterNumberMessageEvent -> unit), ``nrpn-dataentryfine``: (Webmidi.ParameterNumberMessageEvent -> unit), rpn: (Webmidi.ParameterNumberMessageEvent -> unit), ``rpn-datadecrement``: (Webmidi.ParameterNumberMessageEvent -> unit), ``rpn-dataincrement``: (Webmidi.ParameterNumberMessageEvent -> unit), ``rpn-dataentrycoarse``: (Webmidi.ParameterNumberMessageEvent -> unit), ``rpn-dataentryfine``: (Webmidi.ParameterNumberMessageEvent -> unit)) : InputChannelEventMap = nativeOnly

    module InputChannelEventMap =

        [<AllowNullLiteral>]
        [<Interface>]
        type Key<'V> =
            interface end

        [<AbstractClass>]
        [<Erase>]
        type Keys =
            [<Emit("\"midimessage\"")>]
            static member inline midimessage: Key<(Webmidi.MessageEvent -> unit)> = nativeOnly
            [<Emit("\"channelaftertouch\"")>]
            static member inline channelaftertouch: Key<(Webmidi.MessageEvent -> unit)> = nativeOnly
            [<Emit("\"keyaftertouch\"")>]
            static member inline keyaftertouch: Key<(Webmidi.NoteMessageEvent -> unit)> = nativeOnly
            [<Emit("\"noteoff\"")>]
            static member inline noteoff: Key<(Webmidi.NoteMessageEvent -> unit)> = nativeOnly
            [<Emit("\"noteon\"")>]
            static member inline noteon: Key<(Webmidi.NoteMessageEvent -> unit)> = nativeOnly
            [<Emit("\"pitchbend\"")>]
            static member inline pitchbend: Key<(Webmidi.MessageEvent -> unit)> = nativeOnly
            [<Emit("\"programchange\"")>]
            static member inline programchange: Key<(Webmidi.MessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange\"")>]
            static member inline controlchange: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller0\"")>]
            static member inline ``controlchange-controller0``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller1\"")>]
            static member inline ``controlchange-controller1``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller2\"")>]
            static member inline ``controlchange-controller2``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller3\"")>]
            static member inline ``controlchange-controller3``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller4\"")>]
            static member inline ``controlchange-controller4``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller5\"")>]
            static member inline ``controlchange-controller5``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller6\"")>]
            static member inline ``controlchange-controller6``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller7\"")>]
            static member inline ``controlchange-controller7``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller8\"")>]
            static member inline ``controlchange-controller8``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller9\"")>]
            static member inline ``controlchange-controller9``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller10\"")>]
            static member inline ``controlchange-controller10``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller11\"")>]
            static member inline ``controlchange-controller11``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller12\"")>]
            static member inline ``controlchange-controller12``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller13\"")>]
            static member inline ``controlchange-controller13``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller14\"")>]
            static member inline ``controlchange-controller14``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller15\"")>]
            static member inline ``controlchange-controller15``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller16\"")>]
            static member inline ``controlchange-controller16``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller17\"")>]
            static member inline ``controlchange-controller17``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller18\"")>]
            static member inline ``controlchange-controller18``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller19\"")>]
            static member inline ``controlchange-controller19``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller20\"")>]
            static member inline ``controlchange-controller20``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller21\"")>]
            static member inline ``controlchange-controller21``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller22\"")>]
            static member inline ``controlchange-controller22``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller23\"")>]
            static member inline ``controlchange-controller23``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller24\"")>]
            static member inline ``controlchange-controller24``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller25\"")>]
            static member inline ``controlchange-controller25``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller26\"")>]
            static member inline ``controlchange-controller26``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller27\"")>]
            static member inline ``controlchange-controller27``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller28\"")>]
            static member inline ``controlchange-controller28``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller29\"")>]
            static member inline ``controlchange-controller29``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller30\"")>]
            static member inline ``controlchange-controller30``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller31\"")>]
            static member inline ``controlchange-controller31``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller32\"")>]
            static member inline ``controlchange-controller32``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller33\"")>]
            static member inline ``controlchange-controller33``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller34\"")>]
            static member inline ``controlchange-controller34``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller35\"")>]
            static member inline ``controlchange-controller35``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller36\"")>]
            static member inline ``controlchange-controller36``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller37\"")>]
            static member inline ``controlchange-controller37``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller38\"")>]
            static member inline ``controlchange-controller38``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller39\"")>]
            static member inline ``controlchange-controller39``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller40\"")>]
            static member inline ``controlchange-controller40``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller41\"")>]
            static member inline ``controlchange-controller41``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller42\"")>]
            static member inline ``controlchange-controller42``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller43\"")>]
            static member inline ``controlchange-controller43``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller44\"")>]
            static member inline ``controlchange-controller44``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller45\"")>]
            static member inline ``controlchange-controller45``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller46\"")>]
            static member inline ``controlchange-controller46``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller47\"")>]
            static member inline ``controlchange-controller47``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller48\"")>]
            static member inline ``controlchange-controller48``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller49\"")>]
            static member inline ``controlchange-controller49``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller50\"")>]
            static member inline ``controlchange-controller50``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller51\"")>]
            static member inline ``controlchange-controller51``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller52\"")>]
            static member inline ``controlchange-controller52``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller53\"")>]
            static member inline ``controlchange-controller53``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller54\"")>]
            static member inline ``controlchange-controller54``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller55\"")>]
            static member inline ``controlchange-controller55``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller56\"")>]
            static member inline ``controlchange-controller56``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller57\"")>]
            static member inline ``controlchange-controller57``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller58\"")>]
            static member inline ``controlchange-controller58``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller59\"")>]
            static member inline ``controlchange-controller59``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller60\"")>]
            static member inline ``controlchange-controller60``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller61\"")>]
            static member inline ``controlchange-controller61``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller62\"")>]
            static member inline ``controlchange-controller62``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller63\"")>]
            static member inline ``controlchange-controller63``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller64\"")>]
            static member inline ``controlchange-controller64``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller65\"")>]
            static member inline ``controlchange-controller65``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller66\"")>]
            static member inline ``controlchange-controller66``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller67\"")>]
            static member inline ``controlchange-controller67``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller68\"")>]
            static member inline ``controlchange-controller68``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller69\"")>]
            static member inline ``controlchange-controller69``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller70\"")>]
            static member inline ``controlchange-controller70``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller71\"")>]
            static member inline ``controlchange-controller71``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller72\"")>]
            static member inline ``controlchange-controller72``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller73\"")>]
            static member inline ``controlchange-controller73``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller74\"")>]
            static member inline ``controlchange-controller74``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller75\"")>]
            static member inline ``controlchange-controller75``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller76\"")>]
            static member inline ``controlchange-controller76``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller77\"")>]
            static member inline ``controlchange-controller77``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller78\"")>]
            static member inline ``controlchange-controller78``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller79\"")>]
            static member inline ``controlchange-controller79``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller80\"")>]
            static member inline ``controlchange-controller80``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller81\"")>]
            static member inline ``controlchange-controller81``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller82\"")>]
            static member inline ``controlchange-controller82``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller83\"")>]
            static member inline ``controlchange-controller83``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller84\"")>]
            static member inline ``controlchange-controller84``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller85\"")>]
            static member inline ``controlchange-controller85``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller86\"")>]
            static member inline ``controlchange-controller86``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller87\"")>]
            static member inline ``controlchange-controller87``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller88\"")>]
            static member inline ``controlchange-controller88``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller89\"")>]
            static member inline ``controlchange-controller89``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller90\"")>]
            static member inline ``controlchange-controller90``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller91\"")>]
            static member inline ``controlchange-controller91``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller92\"")>]
            static member inline ``controlchange-controller92``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller93\"")>]
            static member inline ``controlchange-controller93``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller94\"")>]
            static member inline ``controlchange-controller94``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller95\"")>]
            static member inline ``controlchange-controller95``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller96\"")>]
            static member inline ``controlchange-controller96``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller97\"")>]
            static member inline ``controlchange-controller97``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller98\"")>]
            static member inline ``controlchange-controller98``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller99\"")>]
            static member inline ``controlchange-controller99``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller100\"")>]
            static member inline ``controlchange-controller100``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller101\"")>]
            static member inline ``controlchange-controller101``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller102\"")>]
            static member inline ``controlchange-controller102``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller103\"")>]
            static member inline ``controlchange-controller103``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller104\"")>]
            static member inline ``controlchange-controller104``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller105\"")>]
            static member inline ``controlchange-controller105``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller106\"")>]
            static member inline ``controlchange-controller106``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller107\"")>]
            static member inline ``controlchange-controller107``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller108\"")>]
            static member inline ``controlchange-controller108``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller109\"")>]
            static member inline ``controlchange-controller109``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller110\"")>]
            static member inline ``controlchange-controller110``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller111\"")>]
            static member inline ``controlchange-controller111``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller112\"")>]
            static member inline ``controlchange-controller112``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller113\"")>]
            static member inline ``controlchange-controller113``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller114\"")>]
            static member inline ``controlchange-controller114``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller115\"")>]
            static member inline ``controlchange-controller115``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller116\"")>]
            static member inline ``controlchange-controller116``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller117\"")>]
            static member inline ``controlchange-controller117``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller118\"")>]
            static member inline ``controlchange-controller118``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller119\"")>]
            static member inline ``controlchange-controller119``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller120\"")>]
            static member inline ``controlchange-controller120``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller121\"")>]
            static member inline ``controlchange-controller121``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller122\"")>]
            static member inline ``controlchange-controller122``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller123\"")>]
            static member inline ``controlchange-controller123``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller124\"")>]
            static member inline ``controlchange-controller124``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller125\"")>]
            static member inline ``controlchange-controller125``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller126\"")>]
            static member inline ``controlchange-controller126``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller127\"")>]
            static member inline ``controlchange-controller127``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"allnotesoff\"")>]
            static member inline allnotesoff: Key<(Webmidi.MessageEvent -> unit)> = nativeOnly
            [<Emit("\"allsoundoff\"")>]
            static member inline allsoundoff: Key<(Webmidi.MessageEvent -> unit)> = nativeOnly
            [<Emit("\"localcontrol\"")>]
            static member inline localcontrol: Key<(Webmidi.MessageEvent -> unit)> = nativeOnly
            [<Emit("\"monomode\"")>]
            static member inline monomode: Key<(Webmidi.MessageEvent -> unit)> = nativeOnly
            [<Emit("\"omnimode\"")>]
            static member inline omnimode: Key<(Webmidi.MessageEvent -> unit)> = nativeOnly
            [<Emit("\"resetallcontrollers\"")>]
            static member inline resetallcontrollers: Key<(Webmidi.MessageEvent -> unit)> = nativeOnly
            [<Emit("\"nrpn\"")>]
            static member inline nrpn: Key<(Webmidi.ParameterNumberMessageEvent -> unit)> = nativeOnly
            [<Emit("\"nrpn-datadecrement\"")>]
            static member inline ``nrpn-datadecrement``: Key<(Webmidi.ParameterNumberMessageEvent -> unit)> = nativeOnly
            [<Emit("\"nrpn-dataincrement\"")>]
            static member inline ``nrpn-dataincrement``: Key<(Webmidi.ParameterNumberMessageEvent -> unit)> = nativeOnly
            [<Emit("\"nrpn-dataentrycoarse\"")>]
            static member inline ``nrpn-dataentrycoarse``: Key<(Webmidi.ParameterNumberMessageEvent -> unit)> = nativeOnly
            [<Emit("\"nrpn-dataentryfine\"")>]
            static member inline ``nrpn-dataentryfine``: Key<(Webmidi.ParameterNumberMessageEvent -> unit)> = nativeOnly
            [<Emit("\"rpn\"")>]
            static member inline rpn: Key<(Webmidi.ParameterNumberMessageEvent -> unit)> = nativeOnly
            [<Emit("\"rpn-datadecrement\"")>]
            static member inline ``rpn-datadecrement``: Key<(Webmidi.ParameterNumberMessageEvent -> unit)> = nativeOnly
            [<Emit("\"rpn-dataincrement\"")>]
            static member inline ``rpn-dataincrement``: Key<(Webmidi.ParameterNumberMessageEvent -> unit)> = nativeOnly
            [<Emit("\"rpn-dataentrycoarse\"")>]
            static member inline ``rpn-dataentrycoarse``: Key<(Webmidi.ParameterNumberMessageEvent -> unit)> = nativeOnly
            [<Emit("\"rpn-dataentryfine\"")>]
            static member inline ``rpn-dataentryfine``: Key<(Webmidi.ParameterNumberMessageEvent -> unit)> = nativeOnly

    /// <summary>
    /// A map of all the events that can be passed to <c>Output.addListener()</c>.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type PortEventMap =
        abstract member closed: (Webmidi.PortEvent -> unit) with get, set
        abstract member disconnected: (Webmidi.PortEvent -> unit) with get, set
        abstract member opened: (Webmidi.PortEvent -> unit) with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (closed: (Webmidi.PortEvent -> unit), disconnected: (Webmidi.PortEvent -> unit), opened: (Webmidi.PortEvent -> unit)) : PortEventMap = nativeOnly

    module PortEventMap =

        [<AllowNullLiteral>]
        [<Interface>]
        type Key<'V> =
            interface end

        [<AbstractClass>]
        [<Erase>]
        type Keys =
            [<Emit("\"closed\"")>]
            static member inline closed: Key<(Webmidi.PortEvent -> unit)> = nativeOnly
            [<Emit("\"disconnected\"")>]
            static member inline disconnected: Key<(Webmidi.PortEvent -> unit)> = nativeOnly
            [<Emit("\"opened\"")>]
            static member inline opened: Key<(Webmidi.PortEvent -> unit)> = nativeOnly

    /// <summary>
    /// A map of all the events that can be passed to <c>Input.addListener()</c>.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type InputEventMap =
        inherit Webmidi.PortEventMap
        abstract member activesensing: (Webmidi.MessageEvent -> unit) with get, set
        abstract member clock: (Webmidi.MessageEvent -> unit) with get, set
        abstract member ``continue``: (Webmidi.MessageEvent -> unit) with get, set
        abstract member reset: (Webmidi.MessageEvent -> unit) with get, set
        abstract member songposition: (Webmidi.MessageEvent -> unit) with get, set
        abstract member songselect: (Webmidi.MessageEvent -> unit) with get, set
        abstract member start: (Webmidi.MessageEvent -> unit) with get, set
        abstract member stop: (Webmidi.MessageEvent -> unit) with get, set
        abstract member sysex: (Webmidi.MessageEvent -> unit) with get, set
        abstract member timecode: (Webmidi.MessageEvent -> unit) with get, set
        abstract member tunerequest: (Webmidi.MessageEvent -> unit) with get, set
        abstract member midimessage: (Webmidi.MessageEvent -> unit) with get, set
        abstract member unknownmessage: (Webmidi.MessageEvent -> unit) with get, set
        abstract member channelaftertouch: (Webmidi.MessageEvent -> unit) with get, set
        abstract member keyaftertouch: (Webmidi.NoteMessageEvent -> unit) with get, set
        abstract member noteoff: (Webmidi.NoteMessageEvent -> unit) with get, set
        abstract member noteon: (Webmidi.NoteMessageEvent -> unit) with get, set
        abstract member pitchbend: (Webmidi.MessageEvent -> unit) with get, set
        abstract member programchange: (Webmidi.MessageEvent -> unit) with get, set
        abstract member controlchange: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller0``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller1``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller2``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller3``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller4``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller5``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller6``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller7``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller8``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller9``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller10``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller11``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller12``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller13``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller14``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller15``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller16``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller17``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller18``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller19``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller20``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller21``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller22``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller23``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller24``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller25``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller26``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller27``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller28``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller29``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller30``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller31``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller32``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller33``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller34``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller35``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller36``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller37``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller38``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller39``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller40``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller41``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller42``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller43``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller44``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller45``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller46``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller47``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller48``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller49``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller50``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller51``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller52``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller53``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller54``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller55``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller56``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller57``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller58``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller59``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller60``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller61``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller62``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller63``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller64``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller65``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller66``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller67``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller68``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller69``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller70``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller71``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller72``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller73``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller74``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller75``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller76``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller77``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller78``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller79``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller80``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller81``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller82``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller83``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller84``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller85``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller86``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller87``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller88``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller89``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller90``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller91``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller92``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller93``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller94``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller95``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller96``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller97``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller98``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller99``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller100``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller101``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller102``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller103``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller104``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller105``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller106``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller107``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller108``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller109``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller110``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller111``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller112``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller113``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller114``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller115``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller116``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller117``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller118``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller119``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller120``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller121``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller122``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller123``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller124``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller125``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller126``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member ``controlchange-controller127``: (Webmidi.ControlChangeMessageEvent -> unit) with get, set
        abstract member allnotesoff: (Webmidi.MessageEvent -> unit) with get, set
        abstract member allsoundoff: (Webmidi.MessageEvent -> unit) with get, set
        abstract member localcontrol: (Webmidi.MessageEvent -> unit) with get, set
        abstract member monomode: (Webmidi.MessageEvent -> unit) with get, set
        abstract member omnimode: (Webmidi.MessageEvent -> unit) with get, set
        abstract member resetallcontrollers: (Webmidi.MessageEvent -> unit) with get, set
        abstract member nrpn: (Webmidi.ParameterNumberMessageEvent -> unit) with get, set
        abstract member ``nrpn-datadecrement``: (Webmidi.ParameterNumberMessageEvent -> unit) with get, set
        abstract member ``nrpn-dataincrement``: (Webmidi.ParameterNumberMessageEvent -> unit) with get, set
        abstract member ``nrpn-dataentrycoarse``: (Webmidi.ParameterNumberMessageEvent -> unit) with get, set
        abstract member ``nrpn-dataentryfine``: (Webmidi.ParameterNumberMessageEvent -> unit) with get, set
        abstract member rpn: (Webmidi.ParameterNumberMessageEvent -> unit) with get, set
        abstract member ``rpn-datadecrement``: (Webmidi.ParameterNumberMessageEvent -> unit) with get, set
        abstract member ``rpn-dataincrement``: (Webmidi.ParameterNumberMessageEvent -> unit) with get, set
        abstract member ``rpn-dataentrycoarse``: (Webmidi.ParameterNumberMessageEvent -> unit) with get, set
        abstract member ``rpn-dataentryfine``: (Webmidi.ParameterNumberMessageEvent -> unit) with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (closed: (Webmidi.PortEvent -> unit), disconnected: (Webmidi.PortEvent -> unit), opened: (Webmidi.PortEvent -> unit), activesensing: (Webmidi.MessageEvent -> unit), clock: (Webmidi.MessageEvent -> unit), ``continue``: (Webmidi.MessageEvent -> unit), reset: (Webmidi.MessageEvent -> unit), songposition: (Webmidi.MessageEvent -> unit), songselect: (Webmidi.MessageEvent -> unit), start: (Webmidi.MessageEvent -> unit), stop: (Webmidi.MessageEvent -> unit), sysex: (Webmidi.MessageEvent -> unit), timecode: (Webmidi.MessageEvent -> unit), tunerequest: (Webmidi.MessageEvent -> unit), midimessage: (Webmidi.MessageEvent -> unit), unknownmessage: (Webmidi.MessageEvent -> unit), channelaftertouch: (Webmidi.MessageEvent -> unit), keyaftertouch: (Webmidi.NoteMessageEvent -> unit), noteoff: (Webmidi.NoteMessageEvent -> unit), noteon: (Webmidi.NoteMessageEvent -> unit), pitchbend: (Webmidi.MessageEvent -> unit), programchange: (Webmidi.MessageEvent -> unit), controlchange: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller0``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller1``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller2``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller3``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller4``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller5``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller6``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller7``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller8``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller9``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller10``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller11``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller12``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller13``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller14``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller15``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller16``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller17``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller18``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller19``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller20``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller21``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller22``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller23``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller24``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller25``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller26``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller27``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller28``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller29``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller30``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller31``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller32``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller33``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller34``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller35``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller36``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller37``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller38``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller39``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller40``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller41``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller42``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller43``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller44``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller45``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller46``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller47``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller48``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller49``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller50``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller51``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller52``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller53``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller54``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller55``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller56``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller57``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller58``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller59``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller60``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller61``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller62``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller63``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller64``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller65``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller66``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller67``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller68``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller69``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller70``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller71``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller72``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller73``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller74``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller75``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller76``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller77``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller78``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller79``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller80``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller81``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller82``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller83``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller84``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller85``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller86``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller87``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller88``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller89``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller90``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller91``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller92``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller93``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller94``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller95``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller96``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller97``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller98``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller99``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller100``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller101``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller102``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller103``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller104``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller105``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller106``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller107``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller108``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller109``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller110``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller111``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller112``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller113``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller114``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller115``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller116``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller117``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller118``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller119``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller120``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller121``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller122``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller123``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller124``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller125``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller126``: (Webmidi.ControlChangeMessageEvent -> unit), ``controlchange-controller127``: (Webmidi.ControlChangeMessageEvent -> unit), allnotesoff: (Webmidi.MessageEvent -> unit), allsoundoff: (Webmidi.MessageEvent -> unit), localcontrol: (Webmidi.MessageEvent -> unit), monomode: (Webmidi.MessageEvent -> unit), omnimode: (Webmidi.MessageEvent -> unit), resetallcontrollers: (Webmidi.MessageEvent -> unit), nrpn: (Webmidi.ParameterNumberMessageEvent -> unit), ``nrpn-datadecrement``: (Webmidi.ParameterNumberMessageEvent -> unit), ``nrpn-dataincrement``: (Webmidi.ParameterNumberMessageEvent -> unit), ``nrpn-dataentrycoarse``: (Webmidi.ParameterNumberMessageEvent -> unit), ``nrpn-dataentryfine``: (Webmidi.ParameterNumberMessageEvent -> unit), rpn: (Webmidi.ParameterNumberMessageEvent -> unit), ``rpn-datadecrement``: (Webmidi.ParameterNumberMessageEvent -> unit), ``rpn-dataincrement``: (Webmidi.ParameterNumberMessageEvent -> unit), ``rpn-dataentrycoarse``: (Webmidi.ParameterNumberMessageEvent -> unit), ``rpn-dataentryfine``: (Webmidi.ParameterNumberMessageEvent -> unit)) : InputEventMap = nativeOnly

    module InputEventMap =

        [<AllowNullLiteral>]
        [<Interface>]
        type Key<'V> =
            interface end

        [<AbstractClass>]
        [<Erase>]
        type Keys =
            [<Emit("\"closed\"")>]
            static member inline closed: Key<(Webmidi.PortEvent -> unit)> = nativeOnly
            [<Emit("\"disconnected\"")>]
            static member inline disconnected: Key<(Webmidi.PortEvent -> unit)> = nativeOnly
            [<Emit("\"opened\"")>]
            static member inline opened: Key<(Webmidi.PortEvent -> unit)> = nativeOnly
            [<Emit("\"activesensing\"")>]
            static member inline activesensing: Key<(Webmidi.MessageEvent -> unit)> = nativeOnly
            [<Emit("\"clock\"")>]
            static member inline clock: Key<(Webmidi.MessageEvent -> unit)> = nativeOnly
            [<Emit("\"continue\"")>]
            static member inline ``continue``: Key<(Webmidi.MessageEvent -> unit)> = nativeOnly
            [<Emit("\"reset\"")>]
            static member inline reset: Key<(Webmidi.MessageEvent -> unit)> = nativeOnly
            [<Emit("\"songposition\"")>]
            static member inline songposition: Key<(Webmidi.MessageEvent -> unit)> = nativeOnly
            [<Emit("\"songselect\"")>]
            static member inline songselect: Key<(Webmidi.MessageEvent -> unit)> = nativeOnly
            [<Emit("\"start\"")>]
            static member inline start: Key<(Webmidi.MessageEvent -> unit)> = nativeOnly
            [<Emit("\"stop\"")>]
            static member inline stop: Key<(Webmidi.MessageEvent -> unit)> = nativeOnly
            [<Emit("\"sysex\"")>]
            static member inline sysex: Key<(Webmidi.MessageEvent -> unit)> = nativeOnly
            [<Emit("\"timecode\"")>]
            static member inline timecode: Key<(Webmidi.MessageEvent -> unit)> = nativeOnly
            [<Emit("\"tunerequest\"")>]
            static member inline tunerequest: Key<(Webmidi.MessageEvent -> unit)> = nativeOnly
            [<Emit("\"midimessage\"")>]
            static member inline midimessage: Key<(Webmidi.MessageEvent -> unit)> = nativeOnly
            [<Emit("\"unknownmessage\"")>]
            static member inline unknownmessage: Key<(Webmidi.MessageEvent -> unit)> = nativeOnly
            [<Emit("\"channelaftertouch\"")>]
            static member inline channelaftertouch: Key<(Webmidi.MessageEvent -> unit)> = nativeOnly
            [<Emit("\"keyaftertouch\"")>]
            static member inline keyaftertouch: Key<(Webmidi.NoteMessageEvent -> unit)> = nativeOnly
            [<Emit("\"noteoff\"")>]
            static member inline noteoff: Key<(Webmidi.NoteMessageEvent -> unit)> = nativeOnly
            [<Emit("\"noteon\"")>]
            static member inline noteon: Key<(Webmidi.NoteMessageEvent -> unit)> = nativeOnly
            [<Emit("\"pitchbend\"")>]
            static member inline pitchbend: Key<(Webmidi.MessageEvent -> unit)> = nativeOnly
            [<Emit("\"programchange\"")>]
            static member inline programchange: Key<(Webmidi.MessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange\"")>]
            static member inline controlchange: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller0\"")>]
            static member inline ``controlchange-controller0``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller1\"")>]
            static member inline ``controlchange-controller1``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller2\"")>]
            static member inline ``controlchange-controller2``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller3\"")>]
            static member inline ``controlchange-controller3``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller4\"")>]
            static member inline ``controlchange-controller4``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller5\"")>]
            static member inline ``controlchange-controller5``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller6\"")>]
            static member inline ``controlchange-controller6``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller7\"")>]
            static member inline ``controlchange-controller7``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller8\"")>]
            static member inline ``controlchange-controller8``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller9\"")>]
            static member inline ``controlchange-controller9``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller10\"")>]
            static member inline ``controlchange-controller10``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller11\"")>]
            static member inline ``controlchange-controller11``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller12\"")>]
            static member inline ``controlchange-controller12``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller13\"")>]
            static member inline ``controlchange-controller13``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller14\"")>]
            static member inline ``controlchange-controller14``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller15\"")>]
            static member inline ``controlchange-controller15``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller16\"")>]
            static member inline ``controlchange-controller16``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller17\"")>]
            static member inline ``controlchange-controller17``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller18\"")>]
            static member inline ``controlchange-controller18``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller19\"")>]
            static member inline ``controlchange-controller19``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller20\"")>]
            static member inline ``controlchange-controller20``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller21\"")>]
            static member inline ``controlchange-controller21``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller22\"")>]
            static member inline ``controlchange-controller22``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller23\"")>]
            static member inline ``controlchange-controller23``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller24\"")>]
            static member inline ``controlchange-controller24``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller25\"")>]
            static member inline ``controlchange-controller25``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller26\"")>]
            static member inline ``controlchange-controller26``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller27\"")>]
            static member inline ``controlchange-controller27``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller28\"")>]
            static member inline ``controlchange-controller28``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller29\"")>]
            static member inline ``controlchange-controller29``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller30\"")>]
            static member inline ``controlchange-controller30``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller31\"")>]
            static member inline ``controlchange-controller31``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller32\"")>]
            static member inline ``controlchange-controller32``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller33\"")>]
            static member inline ``controlchange-controller33``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller34\"")>]
            static member inline ``controlchange-controller34``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller35\"")>]
            static member inline ``controlchange-controller35``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller36\"")>]
            static member inline ``controlchange-controller36``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller37\"")>]
            static member inline ``controlchange-controller37``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller38\"")>]
            static member inline ``controlchange-controller38``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller39\"")>]
            static member inline ``controlchange-controller39``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller40\"")>]
            static member inline ``controlchange-controller40``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller41\"")>]
            static member inline ``controlchange-controller41``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller42\"")>]
            static member inline ``controlchange-controller42``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller43\"")>]
            static member inline ``controlchange-controller43``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller44\"")>]
            static member inline ``controlchange-controller44``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller45\"")>]
            static member inline ``controlchange-controller45``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller46\"")>]
            static member inline ``controlchange-controller46``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller47\"")>]
            static member inline ``controlchange-controller47``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller48\"")>]
            static member inline ``controlchange-controller48``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller49\"")>]
            static member inline ``controlchange-controller49``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller50\"")>]
            static member inline ``controlchange-controller50``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller51\"")>]
            static member inline ``controlchange-controller51``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller52\"")>]
            static member inline ``controlchange-controller52``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller53\"")>]
            static member inline ``controlchange-controller53``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller54\"")>]
            static member inline ``controlchange-controller54``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller55\"")>]
            static member inline ``controlchange-controller55``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller56\"")>]
            static member inline ``controlchange-controller56``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller57\"")>]
            static member inline ``controlchange-controller57``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller58\"")>]
            static member inline ``controlchange-controller58``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller59\"")>]
            static member inline ``controlchange-controller59``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller60\"")>]
            static member inline ``controlchange-controller60``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller61\"")>]
            static member inline ``controlchange-controller61``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller62\"")>]
            static member inline ``controlchange-controller62``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller63\"")>]
            static member inline ``controlchange-controller63``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller64\"")>]
            static member inline ``controlchange-controller64``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller65\"")>]
            static member inline ``controlchange-controller65``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller66\"")>]
            static member inline ``controlchange-controller66``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller67\"")>]
            static member inline ``controlchange-controller67``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller68\"")>]
            static member inline ``controlchange-controller68``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller69\"")>]
            static member inline ``controlchange-controller69``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller70\"")>]
            static member inline ``controlchange-controller70``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller71\"")>]
            static member inline ``controlchange-controller71``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller72\"")>]
            static member inline ``controlchange-controller72``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller73\"")>]
            static member inline ``controlchange-controller73``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller74\"")>]
            static member inline ``controlchange-controller74``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller75\"")>]
            static member inline ``controlchange-controller75``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller76\"")>]
            static member inline ``controlchange-controller76``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller77\"")>]
            static member inline ``controlchange-controller77``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller78\"")>]
            static member inline ``controlchange-controller78``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller79\"")>]
            static member inline ``controlchange-controller79``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller80\"")>]
            static member inline ``controlchange-controller80``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller81\"")>]
            static member inline ``controlchange-controller81``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller82\"")>]
            static member inline ``controlchange-controller82``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller83\"")>]
            static member inline ``controlchange-controller83``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller84\"")>]
            static member inline ``controlchange-controller84``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller85\"")>]
            static member inline ``controlchange-controller85``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller86\"")>]
            static member inline ``controlchange-controller86``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller87\"")>]
            static member inline ``controlchange-controller87``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller88\"")>]
            static member inline ``controlchange-controller88``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller89\"")>]
            static member inline ``controlchange-controller89``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller90\"")>]
            static member inline ``controlchange-controller90``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller91\"")>]
            static member inline ``controlchange-controller91``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller92\"")>]
            static member inline ``controlchange-controller92``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller93\"")>]
            static member inline ``controlchange-controller93``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller94\"")>]
            static member inline ``controlchange-controller94``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller95\"")>]
            static member inline ``controlchange-controller95``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller96\"")>]
            static member inline ``controlchange-controller96``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller97\"")>]
            static member inline ``controlchange-controller97``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller98\"")>]
            static member inline ``controlchange-controller98``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller99\"")>]
            static member inline ``controlchange-controller99``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller100\"")>]
            static member inline ``controlchange-controller100``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller101\"")>]
            static member inline ``controlchange-controller101``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller102\"")>]
            static member inline ``controlchange-controller102``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller103\"")>]
            static member inline ``controlchange-controller103``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller104\"")>]
            static member inline ``controlchange-controller104``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller105\"")>]
            static member inline ``controlchange-controller105``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller106\"")>]
            static member inline ``controlchange-controller106``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller107\"")>]
            static member inline ``controlchange-controller107``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller108\"")>]
            static member inline ``controlchange-controller108``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller109\"")>]
            static member inline ``controlchange-controller109``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller110\"")>]
            static member inline ``controlchange-controller110``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller111\"")>]
            static member inline ``controlchange-controller111``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller112\"")>]
            static member inline ``controlchange-controller112``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller113\"")>]
            static member inline ``controlchange-controller113``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller114\"")>]
            static member inline ``controlchange-controller114``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller115\"")>]
            static member inline ``controlchange-controller115``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller116\"")>]
            static member inline ``controlchange-controller116``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller117\"")>]
            static member inline ``controlchange-controller117``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller118\"")>]
            static member inline ``controlchange-controller118``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller119\"")>]
            static member inline ``controlchange-controller119``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller120\"")>]
            static member inline ``controlchange-controller120``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller121\"")>]
            static member inline ``controlchange-controller121``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller122\"")>]
            static member inline ``controlchange-controller122``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller123\"")>]
            static member inline ``controlchange-controller123``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller124\"")>]
            static member inline ``controlchange-controller124``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller125\"")>]
            static member inline ``controlchange-controller125``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller126\"")>]
            static member inline ``controlchange-controller126``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"controlchange-controller127\"")>]
            static member inline ``controlchange-controller127``: Key<(Webmidi.ControlChangeMessageEvent -> unit)> = nativeOnly
            [<Emit("\"allnotesoff\"")>]
            static member inline allnotesoff: Key<(Webmidi.MessageEvent -> unit)> = nativeOnly
            [<Emit("\"allsoundoff\"")>]
            static member inline allsoundoff: Key<(Webmidi.MessageEvent -> unit)> = nativeOnly
            [<Emit("\"localcontrol\"")>]
            static member inline localcontrol: Key<(Webmidi.MessageEvent -> unit)> = nativeOnly
            [<Emit("\"monomode\"")>]
            static member inline monomode: Key<(Webmidi.MessageEvent -> unit)> = nativeOnly
            [<Emit("\"omnimode\"")>]
            static member inline omnimode: Key<(Webmidi.MessageEvent -> unit)> = nativeOnly
            [<Emit("\"resetallcontrollers\"")>]
            static member inline resetallcontrollers: Key<(Webmidi.MessageEvent -> unit)> = nativeOnly
            [<Emit("\"nrpn\"")>]
            static member inline nrpn: Key<(Webmidi.ParameterNumberMessageEvent -> unit)> = nativeOnly
            [<Emit("\"nrpn-datadecrement\"")>]
            static member inline ``nrpn-datadecrement``: Key<(Webmidi.ParameterNumberMessageEvent -> unit)> = nativeOnly
            [<Emit("\"nrpn-dataincrement\"")>]
            static member inline ``nrpn-dataincrement``: Key<(Webmidi.ParameterNumberMessageEvent -> unit)> = nativeOnly
            [<Emit("\"nrpn-dataentrycoarse\"")>]
            static member inline ``nrpn-dataentrycoarse``: Key<(Webmidi.ParameterNumberMessageEvent -> unit)> = nativeOnly
            [<Emit("\"nrpn-dataentryfine\"")>]
            static member inline ``nrpn-dataentryfine``: Key<(Webmidi.ParameterNumberMessageEvent -> unit)> = nativeOnly
            [<Emit("\"rpn\"")>]
            static member inline rpn: Key<(Webmidi.ParameterNumberMessageEvent -> unit)> = nativeOnly
            [<Emit("\"rpn-datadecrement\"")>]
            static member inline ``rpn-datadecrement``: Key<(Webmidi.ParameterNumberMessageEvent -> unit)> = nativeOnly
            [<Emit("\"rpn-dataincrement\"")>]
            static member inline ``rpn-dataincrement``: Key<(Webmidi.ParameterNumberMessageEvent -> unit)> = nativeOnly
            [<Emit("\"rpn-dataentrycoarse\"")>]
            static member inline ``rpn-dataentrycoarse``: Key<(Webmidi.ParameterNumberMessageEvent -> unit)> = nativeOnly
            [<Emit("\"rpn-dataentryfine\"")>]
            static member inline ``rpn-dataentryfine``: Key<(Webmidi.ParameterNumberMessageEvent -> unit)> = nativeOnly

    /// <summary>
    /// A map of all the events that can be passed to <c>Output.addListener()</c>.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type WebMidiEventMap =
        abstract member connected: (Webmidi.PortEvent -> unit) with get, set
        abstract member disabled: (Webmidi.Event -> unit) with get, set
        abstract member disconnected: (Webmidi.PortEvent -> unit) with get, set
        abstract member enabled: (Webmidi.Event -> unit) with get, set
        abstract member midiaccessgranted: (Webmidi.Event -> unit) with get, set
        abstract member portschanged: (Webmidi.PortEvent -> unit) with get, set
        abstract member error: (Webmidi.ErrorEvent -> unit) with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (connected: (Webmidi.PortEvent -> unit), disabled: (Webmidi.Event -> unit), disconnected: (Webmidi.PortEvent -> unit), enabled: (Webmidi.Event -> unit), midiaccessgranted: (Webmidi.Event -> unit), portschanged: (Webmidi.PortEvent -> unit), error: (Webmidi.ErrorEvent -> unit)) : WebMidiEventMap = nativeOnly

    module WebMidiEventMap =

        [<AllowNullLiteral>]
        [<Interface>]
        type Key<'V> =
            interface end

        [<AbstractClass>]
        [<Erase>]
        type Keys =
            [<Emit("\"connected\"")>]
            static member inline connected: Key<(Webmidi.PortEvent -> unit)> = nativeOnly
            [<Emit("\"disabled\"")>]
            static member inline disabled: Key<(Webmidi.Event -> unit)> = nativeOnly
            [<Emit("\"disconnected\"")>]
            static member inline disconnected: Key<(Webmidi.PortEvent -> unit)> = nativeOnly
            [<Emit("\"enabled\"")>]
            static member inline enabled: Key<(Webmidi.Event -> unit)> = nativeOnly
            [<Emit("\"midiaccessgranted\"")>]
            static member inline midiaccessgranted: Key<(Webmidi.Event -> unit)> = nativeOnly
            [<Emit("\"portschanged\"")>]
            static member inline portschanged: Key<(Webmidi.PortEvent -> unit)> = nativeOnly
            [<Emit("\"error\"")>]
            static member inline error: Key<(Webmidi.ErrorEvent -> unit)> = nativeOnly

    module EventEmitter =

        module addListener =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member context: obj option with get, set
                abstract member prepend: bool option with get, set
                abstract member duration: float option with get, set
                abstract member remaining: float option with get, set
                abstract member arguments: ResizeArray<obj> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?context: obj, ?prepend: bool, ?duration: float, ?remaining: float, ?arguments: ResizeArray<obj>) : options = nativeOnly

        module addOneTimeListener =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member context: obj option with get, set
                abstract member prepend: bool option with get, set
                abstract member duration: float option with get, set
                abstract member arguments: ResizeArray<obj> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?context: obj, ?prepend: bool, ?duration: float, ?arguments: ResizeArray<obj>) : options = nativeOnly

        module removeListener =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member context: obj option with get, set
                abstract member remaining: float option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?context: obj, ?remaining: float) : options = nativeOnly

        module waitFor =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member duration: float option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?duration: float) : options = nativeOnly

    module Enumerations =

        [<AllowNullLiteral>]
        [<Interface>]
        type CHANNEL_MESSAGES__ =
            abstract member noteoff: float with get, set
            abstract member noteon: float with get, set
            abstract member keyaftertouch: float with get, set
            abstract member controlchange: float with get, set
            abstract member programchange: float with get, set
            abstract member channelaftertouch: float with get, set
            abstract member pitchbend: float with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (noteoff: float, noteon: float, keyaftertouch: float, controlchange: float, programchange: float, channelaftertouch: float, pitchbend: float) : CHANNEL_MESSAGES__ = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type CHANNEL_MODE_MESSAGES__ =
            abstract member allsoundoff: float with get, set
            abstract member resetallcontrollers: float with get, set
            abstract member localcontrol: float with get, set
            abstract member allnotesoff: float with get, set
            abstract member omnimodeoff: float with get, set
            abstract member omnimodeon: float with get, set
            abstract member monomodeon: float with get, set
            abstract member polymodeon: float with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (allsoundoff: float, resetallcontrollers: float, localcontrol: float, allnotesoff: float, omnimodeoff: float, omnimodeon: float, monomodeon: float, polymodeon: float) : CHANNEL_MODE_MESSAGES__ = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type REGISTERED_PARAMETERS__ =
            abstract member pitchbendrange: ResizeArray<float> with get, set
            abstract member channelfinetuning: ResizeArray<float> with get, set
            abstract member channelcoarsetuning: ResizeArray<float> with get, set
            abstract member tuningprogram: ResizeArray<float> with get, set
            abstract member tuningbank: ResizeArray<float> with get, set
            abstract member modulationrange: ResizeArray<float> with get, set
            abstract member azimuthangle: ResizeArray<float> with get, set
            abstract member elevationangle: ResizeArray<float> with get, set
            abstract member gain: ResizeArray<float> with get, set
            abstract member distanceratio: ResizeArray<float> with get, set
            abstract member maximumdistance: ResizeArray<float> with get, set
            abstract member maximumdistancegain: ResizeArray<float> with get, set
            abstract member referencedistanceratio: ResizeArray<float> with get, set
            abstract member panspreadangle: ResizeArray<float> with get, set
            abstract member rollangle: ResizeArray<float> with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (pitchbendrange: ResizeArray<float>, channelfinetuning: ResizeArray<float>, channelcoarsetuning: ResizeArray<float>, tuningprogram: ResizeArray<float>, tuningbank: ResizeArray<float>, modulationrange: ResizeArray<float>, azimuthangle: ResizeArray<float>, elevationangle: ResizeArray<float>, gain: ResizeArray<float>, distanceratio: ResizeArray<float>, maximumdistance: ResizeArray<float>, maximumdistancegain: ResizeArray<float>, referencedistanceratio: ResizeArray<float>, panspreadangle: ResizeArray<float>, rollangle: ResizeArray<float>) : REGISTERED_PARAMETERS__ = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type SYSTEM_MESSAGES__ =
            abstract member sysex: float with get, set
            abstract member timecode: float with get, set
            abstract member songposition: float with get, set
            abstract member songselect: float with get, set
            abstract member tunerequest: float with get, set
            abstract member tuningrequest: float with get, set
            abstract member sysexend: float with get, set
            abstract member clock: float with get, set
            abstract member start: float with get, set
            abstract member ``continue``: float with get, set
            abstract member stop: float with get, set
            abstract member activesensing: float with get, set
            abstract member reset: float with get, set
            abstract member midimessage: float with get, set
            abstract member unknownsystemmessage: float with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (sysex: float, timecode: float, songposition: float, songselect: float, tunerequest: float, tuningrequest: float, sysexend: float, clock: float, start: float, ``continue``: float, stop: float, activesensing: float, reset: float, midimessage: float, unknownsystemmessage: float) : SYSTEM_MESSAGES__ = nativeOnly

    module Input =

        module addForwarder =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member types: U2<string, ResizeArray<string>> option with get, set
                abstract member channels: U2<float, ResizeArray<float>> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create () : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (channels: float) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (channels: ResizeArray<float>) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (types: string) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (types: string, channels: float) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (types: string, channels: ResizeArray<float>) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (types: ResizeArray<string>) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (types: ResizeArray<string>, channels: float) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (types: ResizeArray<string>, channels: ResizeArray<float>) : options = nativeOnly

        module addListener =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member arguments: ResizeArray<obj> option with get, set
                abstract member channels: U2<float, ResizeArray<float>> option with get, set
                abstract member context: obj option with get, set
                abstract member duration: float option with get, set
                abstract member prepend: bool option with get, set
                abstract member remaining: float option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?arguments: ResizeArray<obj>, ?context: obj, ?duration: float, ?prepend: bool, ?remaining: float) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (channels: float, ?arguments: ResizeArray<obj>, ?context: obj, ?duration: float, ?prepend: bool, ?remaining: float) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (channels: ResizeArray<float>, ?arguments: ResizeArray<obj>, ?context: obj, ?duration: float, ?prepend: bool, ?remaining: float) : options = nativeOnly

        module addOneTimeListener =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member arguments: ResizeArray<obj> option with get, set
                abstract member channels: U2<float, ResizeArray<float>> option with get, set
                abstract member context: obj option with get, set
                abstract member duration: float option with get, set
                abstract member prepend: bool option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?arguments: ResizeArray<obj>, ?context: obj, ?duration: float, ?prepend: bool) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (channels: float, ?arguments: ResizeArray<obj>, ?context: obj, ?duration: float, ?prepend: bool) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (channels: ResizeArray<float>, ?arguments: ResizeArray<obj>, ?context: obj, ?duration: float, ?prepend: bool) : options = nativeOnly

        module hasListener =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member channels: U2<float, ResizeArray<float>> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create () : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (channels: float) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (channels: ResizeArray<float>) : options = nativeOnly

        module removeListener =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member channels: U2<float, ResizeArray<float>> option with get, set
                abstract member context: obj option with get, set
                abstract member remaining: float option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?context: obj, ?remaining: float) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (channels: float, ?context: obj, ?remaining: float) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (channels: ResizeArray<float>, ?context: obj, ?remaining: float) : options = nativeOnly

    module InputChannel =

        module addListener =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member arguments: ResizeArray<obj> option with get, set
                abstract member context: obj option with get, set
                abstract member duration: float option with get, set
                abstract member prepend: bool option with get, set
                abstract member remaining: float option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?arguments: ResizeArray<obj>, ?context: obj, ?duration: float, ?prepend: bool, ?remaining: float) : options = nativeOnly

        module addOneTimeListener =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member arguments: ResizeArray<obj> option with get, set
                abstract member context: obj option with get, set
                abstract member duration: float option with get, set
                abstract member prepend: bool option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?arguments: ResizeArray<obj>, ?context: obj, ?duration: float, ?prepend: bool) : options = nativeOnly

        module removeListener =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member channels: U2<float, ResizeArray<float>> option with get, set
                abstract member context: obj option with get, set
                abstract member remaining: float option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?context: obj, ?remaining: float) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (channels: float, ?context: obj, ?remaining: float) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (channels: ResizeArray<float>, ?context: obj, ?remaining: float) : options = nativeOnly

    module Output =

        module addListener =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member arguments: ResizeArray<obj> option with get, set
                abstract member context: obj option with get, set
                abstract member duration: float option with get, set
                abstract member prepend: bool option with get, set
                abstract member remaining: float option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?arguments: ResizeArray<obj>, ?context: obj, ?duration: float, ?prepend: bool, ?remaining: float) : options = nativeOnly

        module addOneTimeListener =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member arguments: ResizeArray<obj> option with get, set
                abstract member context: obj option with get, set
                abstract member duration: float option with get, set
                abstract member prepend: bool option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?arguments: ResizeArray<obj>, ?context: obj, ?duration: float, ?prepend: bool) : options = nativeOnly

        module playNote =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member channels: U2<float, ResizeArray<float>> option with get, set
                abstract member duration: float option with get, set
                abstract member attack: float option with get, set
                abstract member rawAttack: float option with get, set
                abstract member release: float option with get, set
                abstract member rawRelease: float option with get, set
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?channels: U2<float, ResizeArray<float>>, ?duration: float, ?attack: float, ?rawAttack: float, ?release: float, ?rawRelease: float, ?time: U2<float, string>) : options = nativeOnly

        module removeListener =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member context: obj option with get, set
                abstract member remaining: float option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?context: obj, ?remaining: float) : options = nativeOnly

        module send =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create () : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: float) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: string) : options = nativeOnly

        module sendSysex =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create () : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: float) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: string) : options = nativeOnly

        module sendTimecodeQuarterFrame =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create () : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: float) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: string) : options = nativeOnly

        module sendSongPosition =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create () : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: float) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: string) : options = nativeOnly

        module sendSongSelect =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create () : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: float) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: string) : options = nativeOnly

        module sendTuneRequest =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create () : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: float) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: string) : options = nativeOnly

        module sendClock =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create () : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: float) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: string) : options = nativeOnly

        module sendStart =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create () : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: float) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: string) : options = nativeOnly

        module sendContinue =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create () : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: float) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: string) : options = nativeOnly

        module sendStop =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create () : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: float) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: string) : options = nativeOnly

        module sendActiveSensing =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create () : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: float) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: string) : options = nativeOnly

        module sendReset =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create () : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: float) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: string) : options = nativeOnly

        module sendKeyAftertouch =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member channels: U2<float, ResizeArray<float>> option with get, set
                abstract member rawValue: bool option with get, set
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?channels: U2<float, ResizeArray<float>>, ?rawValue: bool, ?time: U2<float, string>) : options = nativeOnly

        module sendControlChange =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member channels: U2<float, ResizeArray<float>> option with get, set
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?channels: U2<float, ResizeArray<float>>, ?time: U2<float, string>) : options = nativeOnly

        module sendPitchBendRange =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member channels: U2<float, ResizeArray<float>> option with get, set
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?channels: U2<float, ResizeArray<float>>, ?time: U2<float, string>) : options = nativeOnly

        module sendRpnValue =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member channels: U2<float, ResizeArray<float>> option with get, set
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?channels: U2<float, ResizeArray<float>>, ?time: U2<float, string>) : options = nativeOnly

        module sendChannelAftertouch =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member channels: U2<float, ResizeArray<float>> option with get, set
                abstract member rawValue: bool option with get, set
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?channels: U2<float, ResizeArray<float>>, ?rawValue: bool, ?time: U2<float, string>) : options = nativeOnly

        module sendPitchBend =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member channels: U2<float, ResizeArray<float>> option with get, set
                abstract member rawValue: bool option with get, set
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?channels: U2<float, ResizeArray<float>>, ?rawValue: bool, ?time: U2<float, string>) : options = nativeOnly

        module sendProgramChange =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member channels: U2<float, ResizeArray<float>> option with get, set
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?channels: U2<float, ResizeArray<float>>, ?time: U2<float, string>) : options = nativeOnly

        module sendModulationRange =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member channels: U2<float, ResizeArray<float>> option with get, set
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?channels: U2<float, ResizeArray<float>>, ?time: U2<float, string>) : options = nativeOnly

        module sendMasterTuning =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member channels: U2<float, ResizeArray<float>> option with get, set
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?channels: U2<float, ResizeArray<float>>, ?time: U2<float, string>) : options = nativeOnly

        module sendTuningProgram =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member channels: U2<float, ResizeArray<float>> option with get, set
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?channels: U2<float, ResizeArray<float>>, ?time: U2<float, string>) : options = nativeOnly

        module sendTuningBank =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member channels: U2<float, ResizeArray<float>> option with get, set
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?channels: U2<float, ResizeArray<float>>, ?time: U2<float, string>) : options = nativeOnly

        module sendChannelMode =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member channels: U2<float, ResizeArray<float>> option with get, set
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?channels: U2<float, ResizeArray<float>>, ?time: U2<float, string>) : options = nativeOnly

        module sendAllSoundOff =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member channels: U2<float, ResizeArray<float>> option with get, set
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?channels: U2<float, ResizeArray<float>>, ?time: U2<float, string>) : options = nativeOnly

        module sendAllNotesOff =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member channels: U2<float, ResizeArray<float>> option with get, set
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?channels: U2<float, ResizeArray<float>>, ?time: U2<float, string>) : options = nativeOnly

        module sendResetAllControllers =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member channels: U2<float, ResizeArray<float>> option with get, set
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?channels: U2<float, ResizeArray<float>>, ?time: U2<float, string>) : options = nativeOnly

        module sendPolyphonicMode =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member channels: U2<float, ResizeArray<float>> option with get, set
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?channels: U2<float, ResizeArray<float>>, ?time: U2<float, string>) : options = nativeOnly

        module sendLocalControl =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member channels: U2<float, ResizeArray<float>> option with get, set
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?channels: U2<float, ResizeArray<float>>, ?time: U2<float, string>) : options = nativeOnly

        module sendOmniMode =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member channels: U2<float, ResizeArray<float>> option with get, set
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?channels: U2<float, ResizeArray<float>>, ?time: U2<float, string>) : options = nativeOnly

        module sendNrpnValue =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member channels: U2<float, ResizeArray<float>> option with get, set
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?channels: U2<float, ResizeArray<float>>, ?time: U2<float, string>) : options = nativeOnly

        module sendRpnIncrement =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member channels: U2<float, ResizeArray<float>> option with get, set
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?channels: U2<float, ResizeArray<float>>, ?time: U2<float, string>) : options = nativeOnly

        module sendRpnDecrement =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member channels: U2<float, ResizeArray<float>> option with get, set
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?channels: U2<float, ResizeArray<float>>, ?time: U2<float, string>) : options = nativeOnly

        module sendNoteOff =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member channels: U2<float, ResizeArray<float>> option with get, set
                abstract member release: float option with get, set
                abstract member rawRelease: float option with get, set
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?channels: U2<float, ResizeArray<float>>, ?release: float, ?rawRelease: float, ?time: U2<float, string>) : options = nativeOnly

        module stopNote =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member channels: U2<float, ResizeArray<float>> option with get, set
                abstract member release: float option with get, set
                abstract member rawRelease: float option with get, set
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?channels: U2<float, ResizeArray<float>>, ?release: float, ?rawRelease: float, ?time: U2<float, string>) : options = nativeOnly

        module sendNoteOn =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member channels: U2<float, ResizeArray<float>> option with get, set
                abstract member attack: float option with get, set
                abstract member rawAttack: float option with get, set
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?channels: U2<float, ResizeArray<float>>, ?attack: float, ?rawAttack: float, ?time: U2<float, string>) : options = nativeOnly

    module OutputChannel =

        module send =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create () : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: float) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: string) : options = nativeOnly

        module sendKeyAftertouch =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member rawValue: bool option with get, set
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?rawValue: bool) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: float, ?rawValue: bool) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: string, ?rawValue: bool) : options = nativeOnly

        module sendControlChange =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create () : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: float) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: string) : options = nativeOnly

        module sendRpnDecrement =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create () : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: float) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: string) : options = nativeOnly

        module sendRpnIncrement =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create () : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: float) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: string) : options = nativeOnly

        module playNote =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member duration: float option with get, set
                abstract member attack: float option with get, set
                abstract member rawAttack: float option with get, set
                abstract member release: float option with get, set
                abstract member rawRelease: float option with get, set
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?duration: float, ?attack: float, ?rawAttack: float, ?release: float, ?rawRelease: float) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: float, ?duration: float, ?attack: float, ?rawAttack: float, ?release: float, ?rawRelease: float) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: string, ?duration: float, ?attack: float, ?rawAttack: float, ?release: float, ?rawRelease: float) : options = nativeOnly

        module sendNoteOff =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member time: U2<float, string> option with get, set
                abstract member release: float option with get, set
                abstract member rawRelease: float option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?release: float, ?rawRelease: float) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: float, ?release: float, ?rawRelease: float) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: string, ?release: float, ?rawRelease: float) : options = nativeOnly

        module stopNote =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member release: float option with get, set
                abstract member rawRelease: float option with get, set
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?release: float, ?rawRelease: float) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: float, ?release: float, ?rawRelease: float) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: string, ?release: float, ?rawRelease: float) : options = nativeOnly

        module sendNoteOn =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member time: U2<float, string> option with get, set
                abstract member attack: float option with get, set
                abstract member rawAttack: float option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?attack: float, ?rawAttack: float) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: float, ?attack: float, ?rawAttack: float) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: string, ?attack: float, ?rawAttack: float) : options = nativeOnly

        module sendChannelMode =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create () : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: float) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: string) : options = nativeOnly

        module sendOmniMode =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create () : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: float) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: string) : options = nativeOnly

        module sendChannelAftertouch =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member rawValue: bool option with get, set
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?rawValue: bool) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: float, ?rawValue: bool) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: string, ?rawValue: bool) : options = nativeOnly

        module sendMasterTuning =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create () : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: float) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: string) : options = nativeOnly

        module sendModulationRange =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create () : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: float) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: string) : options = nativeOnly

        module sendNrpnValue =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create () : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: float) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: string) : options = nativeOnly

        module sendPitchBend =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member rawValue: bool option with get, set
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?rawValue: bool) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: float, ?rawValue: bool) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: string, ?rawValue: bool) : options = nativeOnly

        module sendPitchBendRange =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create () : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: float) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: string) : options = nativeOnly

        module sendProgramChange =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create () : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: float) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: string) : options = nativeOnly

        module sendRpnValue =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create () : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: float) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: string) : options = nativeOnly

        module sendTuningBank =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create () : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: float) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: string) : options = nativeOnly

        module sendTuningProgram =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create () : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: float) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: string) : options = nativeOnly

        module sendLocalControl =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create () : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: float) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: string) : options = nativeOnly

        module sendAllNotesOff =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create () : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: float) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: string) : options = nativeOnly

        module sendAllSoundOff =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create () : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: float) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: string) : options = nativeOnly

        module sendResetAllControllers =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create () : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: float) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: string) : options = nativeOnly

        module sendPolyphonicMode =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member time: U2<float, string> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create () : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: float) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (time: string) : options = nativeOnly

    module Utilities =

        [<AllowNullLiteral>]
        [<Interface>]
        type fromFloatToMsbLsb__ =
            abstract member lsb: float with get, set
            abstract member msb: float with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (lsb: float, msb: float) : fromFloatToMsbLsb__ = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type getNoteDetails__ =
            abstract member accidental: string with get, set
            abstract member identifier: string with get, set
            abstract member name: string with get, set
            abstract member octave: float with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (accidental: string, identifier: string, name: string, octave: float) : getNoteDetails__ = nativeOnly

        module buildNote__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member duration: float option with get, set
                abstract member attack: float option with get, set
                abstract member release: float option with get, set
                abstract member rawAttack: float option with get, set
                abstract member rawRelease: float option with get, set
                abstract member octaveOffset: float option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?duration: float, ?attack: float, ?release: float, ?rawAttack: float, ?rawRelease: float, ?octaveOffset: float) : options = nativeOnly

        module buildNoteArray__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member duration: float option with get, set
                abstract member attack: float option with get, set
                abstract member release: float option with get, set
                abstract member rawAttack: float option with get, set
                abstract member rawRelease: float option with get, set
                abstract member octaveOffset: float option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?duration: float, ?attack: float, ?release: float, ?rawAttack: float, ?rawRelease: float, ?octaveOffset: float) : options = nativeOnly

    module WebMidi =

        module addListener =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member arguments: ResizeArray<obj> option with get, set
                abstract member context: obj option with get, set
                abstract member duration: float option with get, set
                abstract member prepend: bool option with get, set
                abstract member remaining: float option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?arguments: ResizeArray<obj>, ?context: obj, ?duration: float, ?prepend: bool, ?remaining: float) : options = nativeOnly

        module addOneTimeListener =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member arguments: ResizeArray<obj> option with get, set
                abstract member context: obj option with get, set
                abstract member duration: float option with get, set
                abstract member prepend: bool option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?arguments: ResizeArray<obj>, ?context: obj, ?duration: float, ?prepend: bool) : options = nativeOnly

        module enable =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member callback: Action option with get, set
                abstract member sysex: bool option with get, set
                abstract member validation: bool option with get, set
                abstract member software: bool option with get, set
                abstract member requestMIDIAccessFunction: Action option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?callback: Action, ?sysex: bool, ?validation: bool, ?software: bool, ?requestMIDIAccessFunction: Action) : options = nativeOnly

        module getInputById =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member disconnected: bool option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?disconnected: bool) : options = nativeOnly

        module getInputByName =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member disconnected: bool option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?disconnected: bool) : options = nativeOnly

        module getOutputById =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member disconnected: bool option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?disconnected: bool) : options = nativeOnly

        module getOutputByName =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member disconnected: bool option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?disconnected: bool) : options = nativeOnly

        module removeListener =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member context: obj option with get, set
                abstract member remaining: float option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?context: obj, ?remaining: float) : options = nativeOnly

    module ControlChangeMessageEvent =

        [<AllowNullLiteral>]
        [<Interface>]
        type controller =
            abstract member name: string with get, set
            abstract member number: float with get, set
            abstract member description: string with get, set
            abstract member position: string with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (name: string, number: float, description: string, position: string) : controller = nativeOnly

    module Exports =

        module Listener =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member context: obj option with get, set
                abstract member remaining: float option with get, set
                abstract member arguments: ResizeArray<obj> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?context: obj, ?remaining: float, ?arguments: ResizeArray<obj>) : options = nativeOnly

        module Forwarder =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member types: U2<string, ResizeArray<string>> option with get, set
                abstract member channels: U2<float, ResizeArray<float>> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create () : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (channels: float) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (channels: ResizeArray<float>) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (types: string) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (types: string, channels: float) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (types: string, channels: ResizeArray<float>) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (types: ResizeArray<string>) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (types: ResizeArray<string>, channels: float) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (types: ResizeArray<string>, channels: ResizeArray<float>) : options = nativeOnly

        module Note =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member duration: float option with get, set
                abstract member attack: float option with get, set
                abstract member release: float option with get, set
                abstract member rawAttack: float option with get, set
                abstract member rawRelease: float option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?duration: float, ?attack: float, ?release: float, ?rawAttack: float, ?rawRelease: float) : options = nativeOnly
