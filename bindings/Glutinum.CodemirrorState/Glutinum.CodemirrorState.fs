namespace rec Glutinum

open Fable.Core
open Fable.Core.JsInterop
open System

// You need to add Glutinum.Types NuGet package to your project
open Glutinum.Types.TypeScript

type Iterable<'T> = Collections.Generic.IEnumerable<'T>

module CodemirrorState =

    [<AbstractClass>]
    [<Erase>]
    type Exports =
        /// <summary>
        /// By default extensions are registered in the order they are found
        /// in the flattened form of nested array that was provided.
        /// Individual extension values can be assigned a precedence to
        /// override this. Extensions that do not have a precedence set get
        /// the precedence of the nearest parent with a precedence, or
        /// [<c>default</c>](https://codemirror.net/6/docs/ref/#state.Prec.default) if there is no such parent. The
        /// final ordering of extensions is determined by first sorting by
        /// precedence and then by order within each precedence.
        /// </summary>
        [<Import("Prec", "@codemirror/state")>]
        static member inline Prec: Exports.Prec__.Type = nativeOnly
        /// <summary>
        /// Utility function for combining behaviors to fill in a config
        /// object from an array of provided configs. <c>defaults</c> should hold
        /// default values for all optional fields in <c>Config</c>.
        ///
        /// The function will, by default, error
        /// when a field gets two values that aren't <c>===</c>-equal, but you can
        /// provide combine functions per field to do something else.
        /// </summary>
        [<Import("combineConfig", "@codemirror/state")>]
        static member combineConfig (configs: ResizeArray<Exports.combineConfig__.configs.Item>, defaults: Exports.combineConfig__.defaults, ?combine: Exports.combineConfig__.combine) : obj = nativeOnly
        /// <summary>
        /// Returns a next grapheme cluster break _after_ (not equal to)
        /// <c>pos</c>, if <c>forward</c> is true, or before otherwise. Returns <c>pos</c>
        /// itself if no further cluster break is available in the string.
        /// Moves across surrogate pairs, extending characters (when
        /// <c>includeExtending</c> is true), characters joined with zero-width
        /// joiners, and flag emoji.
        /// </summary>
        [<Import("findClusterBreak", "@codemirror/state")>]
        static member findClusterBreak (str: string, pos: float, ?forward: bool, ?includeExtending: bool) : float = nativeOnly
        /// <summary>
        /// Find the code point at the given position in a string (like the
        /// [<c>codePointAt</c>](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/String/codePointAt)
        /// string method).
        /// </summary>
        [<Import("codePointAt", "@codemirror/state")>]
        static member codePointAt (str: string, pos: float) : float = nativeOnly
        /// <summary>
        /// Given a Unicode codepoint, return the JavaScript string that
        /// respresents it (like
        /// [<c>String.fromCodePoint</c>](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/String/fromCodePoint)).
        /// </summary>
        [<Import("fromCodePoint", "@codemirror/state")>]
        static member fromCodePoint (code: float) : string = nativeOnly
        /// <summary>
        /// The amount of positions a character takes up in a JavaScript string.
        /// </summary>
        [<Import("codePointSize", "@codemirror/state")>]
        static member codePointSize (code: float) : Exports.codePointSize__ = nativeOnly
        /// <summary>
        /// Count the column position at the given offset into the string,
        /// taking extending characters and tab size into account.
        /// </summary>
        [<Import("countColumn", "@codemirror/state")>]
        static member countColumn (string: string, tabSize: float, ?``to``: float) : float = nativeOnly
        /// <summary>
        /// Find the offset that corresponds to the given column position in a
        /// string, taking extending characters and tab size into account. By
        /// default, the string length is returned when it is too short to
        /// reach the column. Pass <c>strict</c> true to make it return -1 in that
        /// situation.
        /// </summary>
        [<Import("findColumn", "@codemirror/state")>]
        static member findColumn (string: string, col: float, tabSize: float, ?strict: bool) : float = nativeOnly
        [<Import("Text", "@codemirror/state"); EmitConstructor>]
        static member Text () : Text = nativeOnly
        [<Import("Line", "@codemirror/state"); EmitConstructor>]
        static member Line () : Line = nativeOnly
        [<Import("ChangeDesc", "@codemirror/state"); EmitConstructor>]
        static member ChangeDesc () : ChangeDesc = nativeOnly
        [<Import("ChangeSet", "@codemirror/state"); EmitConstructor>]
        static member ChangeSet () : ChangeSet = nativeOnly
        [<Import("SelectionRange", "@codemirror/state"); EmitConstructor>]
        static member SelectionRange () : SelectionRange = nativeOnly
        [<Import("EditorSelection", "@codemirror/state"); EmitConstructor>]
        static member EditorSelection () : EditorSelection = nativeOnly
        [<Import("Facet", "@codemirror/state"); EmitConstructor>]
        static member Facet<'Input, 'Output> () : Facet<'Input, 'Output> = nativeOnly
        [<Import("StateField", "@codemirror/state"); EmitConstructor>]
        static member StateField<'Value> () : StateField<'Value> = nativeOnly
        [<Import("Compartment", "@codemirror/state"); EmitConstructor>]
        static member Compartment () : Compartment = nativeOnly
        [<Import("Annotation", "@codemirror/state"); EmitConstructor>]
        static member Annotation<'T> () : Annotation<'T> = nativeOnly
        [<Import("AnnotationType", "@codemirror/state"); EmitConstructor>]
        static member AnnotationType<'T> () : AnnotationType<'T> = nativeOnly
        [<Import("StateEffectType", "@codemirror/state"); EmitConstructor>]
        static member StateEffectType<'Value> () : StateEffectType<'Value> = nativeOnly
        [<Import("StateEffect", "@codemirror/state"); EmitConstructor>]
        static member StateEffect<'Value> () : StateEffect<'Value> = nativeOnly
        [<Import("Transaction", "@codemirror/state"); EmitConstructor>]
        static member Transaction () : Transaction = nativeOnly
        [<Import("EditorState", "@codemirror/state"); EmitConstructor>]
        static member EditorState () : EditorState = nativeOnly
        [<Import("RangeValue", "@codemirror/state"); EmitConstructor>]
        static member RangeValue () : RangeValue = nativeOnly
        [<Import("Range", "@codemirror/state"); EmitConstructor>]
        static member Range<'T> () : Range<'T> = nativeOnly
        [<Import("RangeSet", "@codemirror/state"); EmitConstructor>]
        static member RangeSet<'T> () : RangeSet<'T> = nativeOnly
        /// <summary>
        /// Create an empty builder.
        /// </summary>
        [<Import("RangeSetBuilder", "@codemirror/state"); EmitConstructor>]
        static member RangeSetBuilder<'T> () : RangeSetBuilder<'T> = nativeOnly

    /// <summary>
    /// A text iterator iterates over a sequence of strings. When
    /// iterating over a [<c>Text</c>](https://codemirror.net/6/docs/ref/#state.Text) document, result values will
    /// either be lines or line breaks.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type TextIterator =
        inherit Iterable<string>
        /// <summary>
        /// Retrieve the next string. Optionally skip a given number of
        /// positions after the current position. Always returns the object
        /// itself.
        /// </summary>
        abstract member next: ?skip: float -> TextIterator
        /// <summary>
        /// The current string. Will be the empty string when the cursor is
        /// at its end or <c>next</c> hasn't been called on it yet.
        /// </summary>
        abstract member value: string with get, set
        /// <summary>
        /// Whether the end of the iteration has been reached. You should
        /// probably check this right after calling <c>next</c>.
        /// </summary>
        abstract member ``done``: bool with get, set
        /// <summary>
        /// Whether the current string represents a line break.
        /// </summary>
        abstract member lineBreak: bool with get, set

    /// <summary>
    /// The data structure for documents.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("Text", "@codemirror/state")>]
    type Text =
        inherit Iterable<string>
        /// <summary>
        /// The length of the string.
        /// </summary>
        abstract member length: float with get
        /// <summary>
        /// The number of lines in the string (always >= 1).
        /// </summary>
        abstract member lines: float with get
        /// <summary>
        /// Get the line description around the given position.
        /// </summary>
        abstract member lineAt: pos: float -> CodemirrorState.Line
        /// <summary>
        /// Get the description for the given (1-based) line number.
        /// </summary>
        abstract member line: n: float -> CodemirrorState.Line
        /// <summary>
        /// Replace a range of the text with the given content.
        /// </summary>
        abstract member replace: from: float * ``to``: float * text: CodemirrorState.Text -> CodemirrorState.Text
        /// <summary>
        /// Append another document to this one.
        /// </summary>
        abstract member append: other: CodemirrorState.Text -> CodemirrorState.Text
        /// <summary>
        /// Retrieve the text between the given points.
        /// </summary>
        abstract member slice: from: float * ?``to``: float -> CodemirrorState.Text
        /// <summary>
        /// Retrieve a part of the document as a string
        /// </summary>
        abstract member sliceString: from: float * ?``to``: float * ?lineSep: string -> string
        /// <summary>
        /// Test whether this text is equal to another instance.
        /// </summary>
        abstract member eq: other: CodemirrorState.Text -> bool
        /// <summary>
        /// Iterate over the text. When <c>dir</c> is <c>-1</c>, iteration happens
        /// from end to start. This will return lines and the breaks between
        /// them as separate strings.
        /// </summary>
        abstract member iter: ?dir: Text.iter.dir -> CodemirrorState.TextIterator
        /// <summary>
        /// Iterate over a range of the text. When <c>from</c> > <c>to</c>, the
        /// iterator will run in reverse.
        /// </summary>
        abstract member iterRange: from: float * ?``to``: float -> CodemirrorState.TextIterator
        /// <summary>
        /// Return a cursor that iterates over the given range of lines,
        /// _without_ returning the line breaks between, and yielding empty
        /// strings for empty lines.
        ///
        /// When <c>from</c> and <c>to</c> are given, they should be 1-based line numbers.
        /// </summary>
        abstract member iterLines: ?from: float * ?``to``: float -> CodemirrorState.TextIterator
        /// <summary>
        /// Return the document as a string, using newline characters to
        /// separate lines.
        /// </summary>
        abstract member toString: unit -> string
        /// <summary>
        /// Convert the document to an array of lines (which can be
        /// deserialized again via [<c>Text.of</c>](https://codemirror.net/6/docs/ref/#state.Text^of)).
        /// </summary>
        abstract member toJSON: unit -> ResizeArray<string>
        /// <summary>
        /// If this is a branch node, <c>children</c> will hold the <c>Text</c>
        /// objects that it is made up of. For leaf nodes, this holds null.
        /// </summary>
        abstract member children: ReadonlyArray<CodemirrorState.Text> option with get
        /// <summary>
        /// Create a <c>Text</c> instance for the given array of lines.
        /// </summary>
        [<Emit("""import { Text } from "@codemirror/state";
Text.of($0)""")>]
        static member inline ``of`` (text: ResizeArray<string>): CodemirrorState.Text = nativeOnly
        /// <summary>
        /// The empty document.
        /// </summary>
        [<Emit("""import { Text } from "@codemirror/state";
Text.empty{{=$0}}""")>]
        static member inline empty
            with get () : CodemirrorState.Text =
                nativeOnly
            and set (value: CodemirrorState.Text) =
                nativeOnly

    /// <summary>
    /// This type describes a line in the document. It is created
    /// on-demand when lines are [queried](https://codemirror.net/6/docs/ref/#state.Text.lineAt).
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("Line", "@codemirror/state")>]
    type Line =
        /// <summary>
        /// The position of the start of the line.
        /// </summary>
        abstract member from: float with get
        /// <summary>
        /// The position at the end of the line (_before_ the line break,
        /// or at the end of document for the last line).
        /// </summary>
        abstract member ``to``: float with get
        /// <summary>
        /// This line's line number (1-based).
        /// </summary>
        abstract member number: float with get
        /// <summary>
        /// The line's content.
        /// </summary>
        abstract member text: string with get
        /// <summary>
        /// The length of the line (not including any line break after it).
        /// </summary>
        abstract member length: float with get

    [<RequireQualifiedAccess>]
    type MapMode =
        | Simple = 0
        | TrackDel = 1
        | TrackBefore = 2
        | TrackAfter = 3

    /// <summary>
    /// A change description is a variant of [change set](https://codemirror.net/6/docs/ref/#state.ChangeSet)
    /// that doesn't store the inserted text. As such, it can't be
    /// applied, but is cheaper to store and manipulate.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("ChangeDesc", "@codemirror/state")>]
    type ChangeDesc =
        /// <summary>
        /// The length of the document before the change.
        /// </summary>
        abstract member length: float with get
        /// <summary>
        /// The length of the document after the change.
        /// </summary>
        abstract member newLength: float with get
        /// <summary>
        /// False when there are actual changes in this set.
        /// </summary>
        abstract member empty: bool with get
        /// <summary>
        /// Iterate over the unchanged parts left by these changes. <c>posA</c>
        /// provides the position of the range in the old document, <c>posB</c>
        /// the new position in the changed document.
        /// </summary>
        abstract member iterGaps: f: ChangeDesc.iterGaps.f -> unit
        /// <summary>
        /// Iterate over the ranges changed by these changes. (See
        /// [<c>ChangeSet.iterChanges</c>](https://codemirror.net/6/docs/ref/#state.ChangeSet.iterChanges) for a
        /// variant that also provides you with the inserted text.)
        /// <c>fromA</c>/<c>toA</c> provides the extent of the change in the starting
        /// document, <c>fromB</c>/<c>toB</c> the extent of the replacement in the
        /// changed document.
        ///
        /// When <c>individual</c> is true, adjacent changes (which are kept
        /// separate for [position mapping](https://codemirror.net/6/docs/ref/#state.ChangeDesc.mapPos)) are
        /// reported separately.
        /// </summary>
        abstract member iterChangedRanges: f: ChangeDesc.iterChangedRanges.f * ?individual: bool -> unit
        /// <summary>
        /// Get a description of the inverted form of these changes.
        /// </summary>
        abstract member invertedDesc: CodemirrorState.ChangeDesc with get
        /// <summary>
        /// Compute the combined effect of applying another set of changes
        /// after this one. The length of the document after this set should
        /// match the length before <c>other</c>.
        /// </summary>
        abstract member composeDesc: other: CodemirrorState.ChangeDesc -> CodemirrorState.ChangeDesc
        /// <summary>
        /// Map this description, which should start with the same document
        /// as <c>other</c>, over another set of changes, so that it can be
        /// applied after it. When <c>before</c> is true, map as if the changes
        /// in <c>this</c> happened before the ones in <c>other</c>.
        /// </summary>
        abstract member mapDesc: other: CodemirrorState.ChangeDesc * ?before: bool -> CodemirrorState.ChangeDesc
        /// <summary>
        /// <c>mode</c> determines whether deletions should be
        /// [reported](https://codemirror.net/6/docs/ref/#state.MapMode). It defaults to
        /// [<c>MapMode.Simple</c>](https://codemirror.net/6/docs/ref/#state.MapMode.Simple) (don't report
        /// deletions).
        /// </summary>
        abstract member mapPos: pos: float * ?assoc: float -> float
        /// <summary>
        /// <c>mode</c> determines whether deletions should be
        /// [reported](https://codemirror.net/6/docs/ref/#state.MapMode). It defaults to
        /// [<c>MapMode.Simple</c>](https://codemirror.net/6/docs/ref/#state.MapMode.Simple) (don't report
        /// deletions).
        /// </summary>
        abstract member mapPos: pos: float * assoc: float * mode: CodemirrorState.MapMode -> float option
        /// <summary>
        /// Check whether these changes touch a given range. When one of the
        /// changes entirely covers the range, the string <c>"cover"</c> is
        /// returned.
        /// </summary>
        abstract member touchesRange: from: float * ?``to``: float -> ChangeDesc.touchesRange
        /// <summary>
        /// Serialize this change desc to a JSON-representable value.
        /// </summary>
        abstract member toJSON: unit -> ReadonlyArray<float>
        /// <summary>
        /// Create a change desc from its JSON representation (as produced
        /// by [<c>toJSON</c>](https://codemirror.net/6/docs/ref/#state.ChangeDesc.toJSON).
        /// </summary>
        [<Emit("""import { ChangeDesc } from "@codemirror/state";
ChangeDesc.fromJSON($0)""")>]
        static member inline fromJSON (json: obj): CodemirrorState.ChangeDesc = nativeOnly

    [<RequireQualifiedAccess>]
    [<Erase>]
    type ChangeSpec =
        | Case1 of ChangeSpec.Cases.Case1
        | ChangeSet of CodemirrorState.ChangeSet
        | ChangeSpecArray of ResizeArray<CodemirrorState.ChangeSpec>

        [<Emit("$0")>]
        static member op_Implicit(value: ChangeSpec.Cases.Case1) : ChangeSpec = nativeOnly

        [<Emit("$0")>]
        static member op_ErasedCast(value: ChangeSpec.Cases.Case1) : ChangeSpec = nativeOnly

        [<Emit("$0")>]
        static member op_Implicit(value: CodemirrorState.ChangeSet) : ChangeSpec = nativeOnly

        [<Emit("$0")>]
        static member op_ErasedCast(value: CodemirrorState.ChangeSet) : ChangeSpec = nativeOnly

        [<Emit("$0")>]
        static member op_Implicit(value: ResizeArray<CodemirrorState.ChangeSpec>) : ChangeSpec = nativeOnly

        [<Emit("$0")>]
        static member op_ErasedCast(value: ResizeArray<CodemirrorState.ChangeSpec>) : ChangeSpec = nativeOnly

        /// Unchecked, the value as <c>Case1</c> whatever case it holds
        [<Emit("$0")>]
        member _.AsCase1: ChangeSpec.Cases.Case1 = nativeOnly

        /// Unchecked, the value as <c>ChangeSet</c> whatever case it holds
        [<Emit("$0")>]
        member _.AsChangeSet: CodemirrorState.ChangeSet = nativeOnly

        /// Unchecked, the value as <c>ChangeSpecArray</c> whatever case it holds
        [<Emit("$0")>]
        member _.AsChangeSpecArray: ResizeArray<CodemirrorState.ChangeSpec> = nativeOnly

    /// <summary>
    /// A change set represents a group of modifications to a document. It
    /// stores the document length, and can only be applied to documents
    /// with exactly that length.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("ChangeSet", "@codemirror/state")>]
    type ChangeSet =
        inherit CodemirrorState.ChangeDesc
        /// <summary>
        /// Apply the changes to a document, returning the modified
        /// document.
        /// </summary>
        abstract member apply: doc: CodemirrorState.Text -> CodemirrorState.Text
        /// <summary>
        /// Map this description, which should start with the same document
        /// as <c>other</c>, over another set of changes, so that it can be
        /// applied after it. When <c>before</c> is true, map as if the changes
        /// in <c>this</c> happened before the ones in <c>other</c>.
        /// </summary>
        abstract member mapDesc: other: CodemirrorState.ChangeDesc * ?before: bool -> CodemirrorState.ChangeDesc
        /// <summary>
        /// Given the document as it existed _before_ the changes, return a
        /// change set that represents the inverse of this set, which could
        /// be used to go from the document created by the changes back to
        /// the document as it existed before the changes.
        /// </summary>
        abstract member invert: doc: CodemirrorState.Text -> CodemirrorState.ChangeSet
        /// <summary>
        /// Combine two subsequent change sets into a single set. <c>other</c>
        /// must start in the document produced by <c>this</c>. If <c>this</c> goes
        /// <c>docA</c> → <c>docB</c> and <c>other</c> represents <c>docB</c> → <c>docC</c>, the
        /// returned value will represent the change <c>docA</c> → <c>docC</c>.
        /// </summary>
        abstract member compose: other: CodemirrorState.ChangeSet -> CodemirrorState.ChangeSet
        /// <summary>
        /// Given another change set starting in the same document, maps this
        /// change set over the other, producing a new change set that can be
        /// applied to the document produced by applying <c>other</c>. When
        /// <c>before</c> is <c>true</c>, order changes as if <c>this</c> comes before
        /// <c>other</c>, otherwise (the default) treat <c>other</c> as coming first.
        ///
        /// Given two changes <c>A</c> and <c>B</c>, <c>A.compose(B.map(A))</c> and
        /// <c>B.compose(A.map(B, true))</c> will produce the same document. This
        /// provides a basic form of [operational
        /// transformation](https://en.wikipedia.org/wiki/Operational_transformation),
        /// and can be used for collaborative editing.
        /// </summary>
        abstract member map: other: CodemirrorState.ChangeDesc * ?before: bool -> CodemirrorState.ChangeSet
        /// <summary>
        /// Iterate over the changed ranges in the document, calling <c>f</c> for
        /// each, with the range in the original document (<c>fromA</c>-<c>toA</c>)
        /// and the range that replaces it in the new document
        /// (<c>fromB</c>-<c>toB</c>).
        ///
        /// When <c>individual</c> is true, adjacent changes are reported
        /// separately.
        /// </summary>
        abstract member iterChanges: f: ChangeSet.iterChanges.f * ?individual: bool -> unit
        /// <summary>
        /// Get a [change description](https://codemirror.net/6/docs/ref/#state.ChangeDesc) for this change
        /// set.
        /// </summary>
        abstract member desc: CodemirrorState.ChangeDesc with get
        /// <summary>
        /// Serialize this change set to a JSON-representable value.
        /// </summary>
        abstract member toJSON: unit -> obj
        /// <summary>
        /// Create a change set for the given changes, for a document of the
        /// given length, using <c>lineSep</c> as line separator.
        /// </summary>
        [<Emit("""import { ChangeSet } from "@codemirror/state";
ChangeSet.of($0, $1, $2)""")>]
        static member inline ``of`` (changes: ChangeSpec.Cases.Case1, length: float, ?lineSep: string): CodemirrorState.ChangeSet = nativeOnly
        /// <summary>
        /// Create a change set for the given changes, for a document of the
        /// given length, using <c>lineSep</c> as line separator.
        /// </summary>
        [<Emit("""import { ChangeSet } from "@codemirror/state";
ChangeSet.of($0, $1, $2)""")>]
        static member inline ``of`` (changes: CodemirrorState.ChangeSet, length: float, ?lineSep: string): CodemirrorState.ChangeSet = nativeOnly
        /// <summary>
        /// Create a change set for the given changes, for a document of the
        /// given length, using <c>lineSep</c> as line separator.
        /// </summary>
        [<Emit("""import { ChangeSet } from "@codemirror/state";
ChangeSet.of($0, $1, $2)""")>]
        static member inline ``of`` (changes: ResizeArray<CodemirrorState.ChangeSpec>, length: float, ?lineSep: string): CodemirrorState.ChangeSet = nativeOnly
        /// <summary>
        /// Create an empty changeset of the given length.
        /// </summary>
        [<Emit("""import { ChangeSet } from "@codemirror/state";
ChangeSet.empty($0)""")>]
        static member inline empty (length: float): CodemirrorState.ChangeSet = nativeOnly
        /// <summary>
        /// Create a changeset from its JSON representation (as produced by
        /// [<c>toJSON</c>](https://codemirror.net/6/docs/ref/#state.ChangeSet.toJSON).
        /// </summary>
        [<Emit("""import { ChangeSet } from "@codemirror/state";
ChangeSet.fromJSON($0)""")>]
        static member inline fromJSON (json: obj): CodemirrorState.ChangeSet = nativeOnly

    /// <summary>
    /// A single selection range. When
    /// [<c>allowMultipleSelections</c>](https://codemirror.net/6/docs/ref/#state.EditorState^allowMultipleSelections)
    /// is enabled, a [selection](https://codemirror.net/6/docs/ref/#state.EditorSelection) may hold
    /// multiple ranges. By default, selections hold exactly one range.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("SelectionRange", "@codemirror/state")>]
    type SelectionRange =
        /// <summary>
        /// The lower boundary of the range.
        /// </summary>
        abstract member from: float with get
        /// <summary>
        /// The upper boundary of the range.
        /// </summary>
        abstract member ``to``: float with get
        /// <summary>
        /// The goal column (stored vertical offset) associated with a
        /// cursor. This is used to preserve the vertical position when
        /// [moving](https://codemirror.net/6/docs/ref/#view.EditorView.moveVertically) across
        /// lines of different length.
        /// </summary>
        abstract member goalColumn: float option with get
        /// <summary>
        /// The anchor of the range—the side that doesn't move when you
        /// extend it.
        /// </summary>
        abstract member anchor: float with get
        /// <summary>
        /// The head of the range, which is moved when the range is
        /// [extended](https://codemirror.net/6/docs/ref/#state.SelectionRange.extend).
        /// </summary>
        abstract member head: float with get
        /// <summary>
        /// True when <c>anchor</c> and <c>head</c> are at the same position.
        /// </summary>
        abstract member empty: bool with get
        /// <summary>
        /// If this is a cursor that is explicitly associated with the
        /// character on one of its sides, this returns the side. -1 means
        /// the character before its position, 1 the character after, and 0
        /// means no association.
        /// </summary>
        abstract member assoc: SelectionRange.assoc with get
        /// <summary>
        /// A flag that, when set, makes some selection-extending commands
        /// treat the range's head and anchor as exchangeable, so that for
        /// example Shift-ArrowUp will make the lower side of the selection
        /// the anchor, even if that was the head before. Used to implement
        /// MacOS-style undirectional selections.
        /// </summary>
        abstract member undirectional: bool with get
        /// <summary>
        /// The bidirectional text level associated with this cursor, if
        /// any.
        /// </summary>
        abstract member bidiLevel: float option with get
        /// <summary>
        /// Map this range through a change, producing a valid range in the
        /// updated document.
        /// </summary>
        abstract member map: change: CodemirrorState.ChangeDesc * ?assoc: float -> CodemirrorState.SelectionRange
        /// <summary>
        /// Extend this range to cover at least <c>from</c> to <c>to</c>.
        /// </summary>
        abstract member extend: from: float * ?``to``: float * ?assoc: float -> CodemirrorState.SelectionRange
        /// <summary>
        /// Compare this range to another range.
        /// </summary>
        abstract member eq: other: CodemirrorState.SelectionRange * ?includeAssoc: bool -> bool
        /// <summary>
        /// Return a JSON-serializable object representing the range.
        /// </summary>
        abstract member toJSON: unit -> obj
        /// <summary>
        /// Convert a JSON representation of a range to a <c>SelectionRange</c>
        /// instance.
        /// </summary>
        [<Emit("""import { SelectionRange } from "@codemirror/state";
SelectionRange.fromJSON($0)""")>]
        static member inline fromJSON (json: obj): CodemirrorState.SelectionRange = nativeOnly

    /// <summary>
    /// An editor selection holds one or more selection ranges.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("EditorSelection", "@codemirror/state")>]
    type EditorSelection =
        /// <summary>
        /// The ranges in the selection, sorted by position. Ranges cannot
        /// overlap (but they may touch, if they aren't empty).
        /// </summary>
        abstract member ranges: ReadonlyArray<CodemirrorState.SelectionRange> with get
        /// <summary>
        /// The index of the _main_ range in the selection (which is
        /// usually the range that was added last).
        /// </summary>
        abstract member mainIndex: float with get
        /// <summary>
        /// Map a selection through a change. Used to adjust the selection
        /// position for changes.
        /// </summary>
        abstract member map: change: CodemirrorState.ChangeDesc * ?assoc: float -> CodemirrorState.EditorSelection
        /// <summary>
        /// Compare this selection to another selection. By default, ranges
        /// are compared only by position. When <c>includeAssoc</c> is true,
        /// cursor ranges must also have the same
        /// [<c>assoc</c>](https://codemirror.net/6/docs/ref/#state.SelectionRange.assoc) value.
        /// </summary>
        abstract member eq: other: CodemirrorState.EditorSelection * ?includeAssoc: bool -> bool
        /// <summary>
        /// Get the primary selection range. Usually, you should make sure
        /// your code applies to _all_ ranges, by using methods like
        /// [<c>changeByRange</c>](https://codemirror.net/6/docs/ref/#state.EditorState.changeByRange).
        /// </summary>
        abstract member main: CodemirrorState.SelectionRange with get
        /// <summary>
        /// Make sure the selection only has one range. Returns a selection
        /// holding only the main range from this selection.
        /// </summary>
        abstract member asSingle: unit -> CodemirrorState.EditorSelection
        /// <summary>
        /// Extend this selection with an extra range.
        /// </summary>
        abstract member addRange: range: CodemirrorState.SelectionRange * ?main: bool -> CodemirrorState.EditorSelection
        /// <summary>
        /// Replace a given range with another range, and then normalize the
        /// selection to merge and sort ranges if necessary.
        /// </summary>
        abstract member replaceRange: range: CodemirrorState.SelectionRange * ?which: float -> CodemirrorState.EditorSelection
        /// <summary>
        /// Convert this selection to an object that can be serialized to
        /// JSON.
        /// </summary>
        abstract member toJSON: unit -> obj
        /// <summary>
        /// Create a selection from a JSON representation.
        /// </summary>
        [<Emit("""import { EditorSelection } from "@codemirror/state";
EditorSelection.fromJSON($0)""")>]
        static member inline fromJSON (json: obj): CodemirrorState.EditorSelection = nativeOnly
        /// <summary>
        /// Create a selection holding a single range.
        /// </summary>
        [<Emit("""import { EditorSelection } from "@codemirror/state";
EditorSelection.single($0, $1)""")>]
        static member inline single (anchor: float, ?head: float): CodemirrorState.EditorSelection = nativeOnly
        /// <summary>
        /// Sort and merge the given set of ranges, creating a valid
        /// selection.
        /// </summary>
        [<Emit("""import { EditorSelection } from "@codemirror/state";
EditorSelection.create($0, $1)""")>]
        static member inline create (ranges: ResizeArray<CodemirrorState.SelectionRange>, ?mainIndex: float): CodemirrorState.EditorSelection = nativeOnly
        /// <summary>
        /// Create a cursor selection range at the given position. You can
        /// safely ignore the optional arguments in most situations.
        /// </summary>
        [<Emit("""import { EditorSelection } from "@codemirror/state";
EditorSelection.cursor($0, $1, $2, $3)""")>]
        static member inline cursor (pos: float, ?assoc: float, ?bidiLevel: float, ?goalColumn: float): CodemirrorState.SelectionRange = nativeOnly
        /// <summary>
        /// Create a selection range.
        /// </summary>
        [<Emit("""import { EditorSelection } from "@codemirror/state";
EditorSelection.range($0, $1, $2, $3, $4)""")>]
        static member inline range (anchor: float, head: float, ?goalColumn: float, ?bidiLevel: float, ?assoc: float): CodemirrorState.SelectionRange = nativeOnly
        /// <summary>
        /// Create an [undirectional](https://codemirror.net/6/docs/ref/#state.SelectionRange.undirectional)
        /// selection range.
        /// </summary>
        [<Emit("""import { EditorSelection } from "@codemirror/state";
EditorSelection.undirectionalRange($0, $1)""")>]
        static member inline undirectionalRange (from: float, ``to``: float): CodemirrorState.SelectionRange = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type FacetConfig<'Input, 'Output> =
        /// <summary>
        /// How to combine the input values into a single output value. When
        /// not given, the array of input values becomes the output. This
        /// function will immediately be called on creating the facet, with
        /// an empty array, to compute the facet's default value when no
        /// inputs are present.
        /// </summary>
        abstract member combine: (ResizeArray<'Input> -> 'Output) option with get, set
        /// <summary>
        /// How to compare output values to determine whether the value of
        /// the facet changed. Defaults to comparing by <c>===</c> or, if no
        /// <c>combine</c> function was given, comparing each element of the
        /// array with <c>===</c>.
        /// </summary>
        abstract member compare: FacetConfig.compare<'Output> option with get, set
        /// <summary>
        /// How to compare input values to avoid recomputing the output
        /// value when no inputs changed. Defaults to comparing with <c>===</c>.
        /// </summary>
        abstract member compareInput: FacetConfig.compareInput<'Input> option with get, set
        /// <summary>
        /// Forbids dynamic inputs to this facet.
        /// </summary>
        abstract member ``static``: bool option with get, set
        /// <summary>
        /// If given, these extension(s) (or the result of calling the given
        /// function with the facet) will be added to any state where this
        /// facet is provided. (Note that, while a facet's default value can
        /// be read from a state even if the facet wasn't present in the
        /// state at all, these extensions won't be added in that
        /// situation.)
        /// </summary>
        abstract member enables: U2<CodemirrorState.Extension, (CodemirrorState.Facet<'Input, 'Output> -> CodemirrorState.Extension)> option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?combine: (ResizeArray<'Input> -> 'Output), ?compare: FacetConfig.compare<'Output>, ?compareInput: FacetConfig.compareInput<'Input>, ?``static``: bool) : FacetConfig<'Input, 'Output> = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (enables: CodemirrorState.Extension, ?combine: (ResizeArray<'Input> -> 'Output), ?compare: FacetConfig.compare<'Output>, ?compareInput: FacetConfig.compareInput<'Input>, ?``static``: bool) : FacetConfig<'Input, 'Output> = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (enables: (CodemirrorState.Facet<'Input, 'Output> -> CodemirrorState.Extension), ?combine: (ResizeArray<'Input> -> 'Output), ?compare: FacetConfig.compare<'Output>, ?compareInput: FacetConfig.compareInput<'Input>, ?``static``: bool) : FacetConfig<'Input, 'Output> = nativeOnly

    /// <summary>
    /// A facet is a labeled value that is associated with an editor
    /// state. It takes inputs from any number of extensions, and combines
    /// those into a single output value.
    ///
    /// Examples of uses of facets are the [tab
    /// size](https://codemirror.net/6/docs/ref/#state.EditorState^tabSize), [editor
    /// attributes](https://codemirror.net/6/docs/ref/#view.EditorView^editorAttributes), and [update
    /// listeners](https://codemirror.net/6/docs/ref/#view.EditorView^updateListener).
    ///
    /// Note that <c>Facet</c> instances can be used anywhere where
    /// [<c>FacetReader</c>](https://codemirror.net/6/docs/ref/#state.FacetReader) is expected.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("Facet", "@codemirror/state")>]
    type Facet<'Input, 'Output> =
        inherit CodemirrorState.FacetReader<'Output>
        /// <summary>
        /// Returns a facet reader for this facet, which can be used to
        /// [read](https://codemirror.net/6/docs/ref/#state.EditorState.facet) it but not to define values for it.
        /// </summary>
        abstract member reader: CodemirrorState.FacetReader<'Output> with get
        /// <summary>
        /// Define a new facet.
        /// </summary>
        [<Emit("""import { Facet } from "@codemirror/state";
Facet.define($0)""")>]
        static member inline define (?config: CodemirrorState.FacetConfig<'Input, 'Output>): CodemirrorState.Facet<'Input, 'Output> = nativeOnly
        /// <summary>
        /// Returns an extension that adds the given value to this facet.
        /// </summary>
        abstract member ``of``: value: 'Input -> CodemirrorState.Extension
        /// <summary>
        /// Create an extension that computes a value for the facet from a
        /// state. You must take care to declare the parts of the state that
        /// this value depends on, since your function is only called again
        /// for a new state when one of those parts changed.
        ///
        /// In cases where your value depends only on a single field, you'll
        /// want to use the [<c>from</c>](https://codemirror.net/6/docs/ref/#state.Facet.from) method instead.
        /// </summary>
        abstract member compute: deps: ResizeArray<CodemirrorState.Slot<obj>> * get: (CodemirrorState.EditorState -> 'Input) -> CodemirrorState.Extension
        /// <summary>
        /// Create an extension that computes zero or more values for this
        /// facet from a state.
        /// </summary>
        abstract member computeN: deps: ResizeArray<CodemirrorState.Slot<obj>> * get: (CodemirrorState.EditorState -> ResizeArray<'Input>) -> CodemirrorState.Extension
        /// <summary>
        /// Shorthand method for registering a facet source with a state
        /// field as input. If the field's type corresponds to this facet's
        /// input type, the getter function can be omitted. If given, it
        /// will be used to retrieve the input from the field value.
        /// </summary>
        abstract member from<'T>: field: CodemirrorState.StateField<'T> -> CodemirrorState.Extension
        /// <summary>
        /// Shorthand method for registering a facet source with a state
        /// field as input. If the field's type corresponds to this facet's
        /// input type, the getter function can be omitted. If given, it
        /// will be used to retrieve the input from the field value.
        /// </summary>
        abstract member from<'T>: field: CodemirrorState.StateField<'T> * get: ('T -> 'Input) -> CodemirrorState.Extension
        /// <summary>
        /// Dummy tag that makes sure TypeScript doesn't consider all object
        /// types as conforming to this type. Not actually present on the
        /// object.
        /// </summary>
        abstract member tag: 'Output with get, set

    type Facet<'Input> =
        Facet<'Input, ReadonlyArray<'Input>>

    [<AllowNullLiteral>]
    [<Interface>]
    type FacetReader<'Output> =
        /// <summary>
        /// Dummy tag that makes sure TypeScript doesn't consider all object
        /// types as conforming to this type. Not actually present on the
        /// object.
        /// </summary>
        abstract member tag: 'Output with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (tag: 'Output) : FacetReader<'Output> = nativeOnly

    [<RequireQualifiedAccess>]
    [<Erase(CaseRules.None)>]
    type Slot<'T> =
        | doc
        | selection
        | Case1 of CodemirrorState.FacetReader<'T>
        | Case2 of CodemirrorState.StateField<'T>

        [<Emit("$0")>]
        static member op_Implicit(value: CodemirrorState.FacetReader<'T>) : Slot<'T> = nativeOnly

        [<Emit("$0")>]
        static member op_ErasedCast(value: CodemirrorState.FacetReader<'T>) : Slot<'T> = nativeOnly

        [<Emit("$0")>]
        static member op_Implicit(value: CodemirrorState.StateField<'T>) : Slot<'T> = nativeOnly

        [<Emit("$0")>]
        static member op_ErasedCast(value: CodemirrorState.StateField<'T>) : Slot<'T> = nativeOnly

        /// Unchecked, the value as <c>Case1</c> whatever case it holds
        [<Emit("$0")>]
        member _.AsCase1: CodemirrorState.FacetReader<'T> = nativeOnly

        /// Unchecked, the value as <c>Case2</c> whatever case it holds
        [<Emit("$0")>]
        member _.AsCase2: CodemirrorState.StateField<'T> = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type StateFieldSpec<'Value> =
        /// <summary>
        /// Creates the initial value for the field when a state is created.
        /// </summary>
        abstract member create: (CodemirrorState.EditorState -> 'Value) with get, set
        /// <summary>
        /// Compute a new value from the field's previous value and a
        /// [transaction](https://codemirror.net/6/docs/ref/#state.Transaction).
        /// </summary>
        abstract member update: StateFieldSpec.update<'Value> with get, set
        /// <summary>
        /// Compare two values of the field, returning <c>true</c> when they are
        /// the same. This is used to avoid recomputing facets that depend
        /// on the field when its value did not change. Defaults to using
        /// <c>===</c>.
        /// </summary>
        abstract member compare: StateFieldSpec.compare<'Value> option with get, set
        /// <summary>
        /// Provide extensions based on this field. The given function will
        /// be called once with the initialized field. It will usually want
        /// to call some facet's [<c>from</c>](https://codemirror.net/6/docs/ref/#state.Facet.from) method to
        /// create facet inputs from this field, but can also return other
        /// extensions that should be enabled when the field is present in a
        /// configuration.
        /// </summary>
        abstract member provide: (CodemirrorState.StateField<'Value> -> CodemirrorState.Extension) option with get, set
        /// <summary>
        /// A function used to serialize this field's content to JSON. Only
        /// necessary when this field is included in the argument to
        /// [<c>EditorState.toJSON</c>](https://codemirror.net/6/docs/ref/#state.EditorState.toJSON).
        /// </summary>
        abstract member toJSON: StateFieldSpec.toJSON<'Value> option with get, set
        /// <summary>
        /// A function that deserializes the JSON representation of this
        /// field's content.
        /// </summary>
        abstract member fromJSON: StateFieldSpec.fromJSON<'Value> option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (create: (CodemirrorState.EditorState -> 'Value), update: StateFieldSpec.update<'Value>, ?compare: StateFieldSpec.compare<'Value>, ?provide: (CodemirrorState.StateField<'Value> -> CodemirrorState.Extension), ?toJSON: StateFieldSpec.toJSON<'Value>, ?fromJSON: StateFieldSpec.fromJSON<'Value>) : StateFieldSpec<'Value> = nativeOnly

    /// <summary>
    /// Fields can store additional information in an editor state, and
    /// keep it in sync with the rest of the state.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("StateField", "@codemirror/state")>]
    type StateField<'Value> =
        /// <summary>
        /// Define a state field.
        /// </summary>
        [<Emit("""import { StateField } from "@codemirror/state";
StateField.define($0)""")>]
        static member inline define (config: CodemirrorState.StateFieldSpec<'Value>): CodemirrorState.StateField<'Value> = nativeOnly
        /// <summary>
        /// Returns an extension that enables this field and overrides the
        /// way it is initialized. Can be useful when you need to provide a
        /// non-default starting value for the field.
        /// </summary>
        abstract member init: create: (CodemirrorState.EditorState -> 'Value) -> CodemirrorState.Extension
        /// <summary>
        /// State field instances can be used as
        /// [<c>Extension</c>](https://codemirror.net/6/docs/ref/#state.Extension) values to enable the field in a
        /// given state.
        /// </summary>
        abstract member extension: CodemirrorState.Extension with get

    [<RequireQualifiedAccess>]
    [<Erase>]
    type Extension =
        | Case1 of Extension.Cases.Case1
        | ExtensionArray of ResizeArray<CodemirrorState.Extension>

        [<Emit("$0")>]
        static member op_Implicit(value: Extension.Cases.Case1) : Extension = nativeOnly

        [<Emit("$0")>]
        static member op_ErasedCast(value: Extension.Cases.Case1) : Extension = nativeOnly

        [<Emit("$0")>]
        static member op_Implicit(value: ResizeArray<CodemirrorState.Extension>) : Extension = nativeOnly

        [<Emit("$0")>]
        static member op_ErasedCast(value: ResizeArray<CodemirrorState.Extension>) : Extension = nativeOnly

        /// Unchecked, the value as <c>Case1</c> whatever case it holds
        [<Emit("$0")>]
        member _.AsCase1: Extension.Cases.Case1 = nativeOnly

        /// Unchecked, the value as <c>ExtensionArray</c> whatever case it holds
        [<Emit("$0")>]
        member _.AsExtensionArray: ResizeArray<CodemirrorState.Extension> = nativeOnly

    /// <summary>
    /// Extension compartments can be used to make a configuration
    /// dynamic. By [wrapping](https://codemirror.net/6/docs/ref/#state.Compartment.of) part of your
    /// configuration in a compartment, you can later
    /// [replace](https://codemirror.net/6/docs/ref/#state.Compartment.reconfigure) that part through a
    /// transaction.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("Compartment", "@codemirror/state")>]
    type Compartment =
        /// <summary>
        /// Create an instance of this compartment to add to your [state
        /// configuration](https://codemirror.net/6/docs/ref/#state.EditorStateConfig.extensions).
        /// </summary>
        abstract member ``of``: ext: Extension.Cases.Case1 -> CodemirrorState.Extension
        /// <summary>
        /// Create an instance of this compartment to add to your [state
        /// configuration](https://codemirror.net/6/docs/ref/#state.EditorStateConfig.extensions).
        /// </summary>
        abstract member ``of``: ext: ResizeArray<CodemirrorState.Extension> -> CodemirrorState.Extension
        /// <summary>
        /// Create an [effect](https://codemirror.net/6/docs/ref/#state.TransactionSpec.effects) that
        /// reconfigures this compartment.
        /// </summary>
        abstract member reconfigure: content: Extension.Cases.Case1 -> CodemirrorState.StateEffect<obj>
        /// <summary>
        /// Create an [effect](https://codemirror.net/6/docs/ref/#state.TransactionSpec.effects) that
        /// reconfigures this compartment.
        /// </summary>
        abstract member reconfigure: content: ResizeArray<CodemirrorState.Extension> -> CodemirrorState.StateEffect<obj>
        /// <summary>
        /// Get the current content of the compartment in the state, or
        /// <c>undefined</c> if it isn't present.
        /// </summary>
        abstract member get: state: CodemirrorState.EditorState -> CodemirrorState.Extension option

    /// <summary>
    /// Annotations are tagged values that are used to add metadata to
    /// transactions in an extensible way. They should be used to model
    /// things that effect the entire transaction (such as its [time
    /// stamp](https://codemirror.net/6/docs/ref/#state.Transaction^time) or information about its
    /// [origin](https://codemirror.net/6/docs/ref/#state.Transaction^userEvent)). For effects that happen
    /// _alongside_ the other changes made by the transaction, [state
    /// effects](https://codemirror.net/6/docs/ref/#state.StateEffect) are more appropriate.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("Annotation", "@codemirror/state")>]
    type Annotation<'T> =
        /// <summary>
        /// The annotation type.
        /// </summary>
        abstract member ``type``: CodemirrorState.AnnotationType<'T> with get
        /// <summary>
        /// The value of this annotation.
        /// </summary>
        abstract member value: 'T with get
        /// <summary>
        /// Define a new type of annotation.
        /// </summary>
        [<Emit("""import { Annotation } from "@codemirror/state";
Annotation.define()""")>]
        static member inline define () : CodemirrorState.AnnotationType<'T> = nativeOnly

    /// <summary>
    /// Marker that identifies a type of [annotation](https://codemirror.net/6/docs/ref/#state.Annotation).
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("AnnotationType", "@codemirror/state")>]
    type AnnotationType<'T> =
        /// <summary>
        /// Create an instance of this annotation.
        /// </summary>
        abstract member ``of``: value: 'T -> CodemirrorState.Annotation<'T>

    [<AllowNullLiteral>]
    [<Interface>]
    type StateEffectSpec<'Value> =
        /// <summary>
        /// Provides a way to map an effect like this through a position
        /// mapping. When not given, the effects will simply not be mapped.
        /// When the function returns <c>undefined</c>, that means the mapping
        /// deletes the effect.
        /// </summary>
        abstract member map: StateEffectSpec.map<'Value> option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?map: StateEffectSpec.map<'Value>) : StateEffectSpec<'Value> = nativeOnly

    /// <summary>
    /// Representation of a type of state effect. Defined with
    /// [<c>StateEffect.define</c>](https://codemirror.net/6/docs/ref/#state.StateEffect^define).
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("StateEffectType", "@codemirror/state")>]
    type StateEffectType<'Value> =
        abstract member map: StateEffectType.map with get
        /// <summary>
        /// Create a [state effect](https://codemirror.net/6/docs/ref/#state.StateEffect) instance of this
        /// type.
        /// </summary>
        abstract member ``of``: value: 'Value -> CodemirrorState.StateEffect<'Value>

    /// <summary>
    /// State effects can be used to represent additional effects
    /// associated with a [transaction](https://codemirror.net/6/docs/ref/#state.Transaction.effects). They
    /// are often useful to model changes to custom [state
    /// fields](https://codemirror.net/6/docs/ref/#state.StateField), when those changes aren't implicit in
    /// document or selection changes.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("StateEffect", "@codemirror/state")>]
    type StateEffect<'Value> =
        /// <summary>
        /// The value of this effect.
        /// </summary>
        abstract member value: 'Value with get
        /// <summary>
        /// Map this effect through a position mapping. Will return
        /// <c>undefined</c> when that ends up deleting the effect.
        /// </summary>
        abstract member map: mapping: CodemirrorState.ChangeDesc -> CodemirrorState.StateEffect<'Value> option
        /// <summary>
        /// Tells you whether this effect object is of a given
        /// [type](https://codemirror.net/6/docs/ref/#state.StateEffectType).
        /// </summary>
        abstract member is<'T>: ``type``: CodemirrorState.StateEffectType<'T> -> bool
        /// <summary>
        /// Define a new effect type. The type parameter indicates the type
        /// of values that his effect holds. It should be a type that
        /// doesn't include <c>undefined</c>, since that is used in
        /// [mapping](https://codemirror.net/6/docs/ref/#state.StateEffect.map) to indicate that an effect is
        /// removed.
        /// </summary>
        [<Emit("""import { StateEffect } from "@codemirror/state";
StateEffect.define($0)""")>]
        static member inline define (?spec: CodemirrorState.StateEffectSpec<'Value>): CodemirrorState.StateEffectType<'Value> = nativeOnly
        /// <summary>
        /// Define a new effect type. The type parameter indicates the type
        /// of values that his effect holds. It should be a type that
        /// doesn't include <c>undefined</c>, since that is used in
        /// [mapping](https://codemirror.net/6/docs/ref/#state.StateEffect.map) to indicate that an effect is
        /// removed.
        /// </summary>
        [<Emit("""import { StateEffect } from "@codemirror/state";
StateEffect.define()""")>]
        static member inline define () : CodemirrorState.StateEffectType<'Value> = nativeOnly
        /// <summary>
        /// Define a new effect type. The type parameter indicates the type
        /// of values that his effect holds. It should be a type that
        /// doesn't include <c>undefined</c>, since that is used in
        /// [mapping](https://codemirror.net/6/docs/ref/#state.StateEffect.map) to indicate that an effect is
        /// removed.
        /// </summary>
        [<Emit("""import { StateEffect } from "@codemirror/state";
StateEffect.define($0)""")>]
        static member inline define (spec: CodemirrorState.StateEffectSpec<obj>): CodemirrorState.StateEffectType<obj> = nativeOnly
        /// <summary>
        /// Map an array of effects through a change set.
        /// </summary>
        [<Emit("""import { StateEffect } from "@codemirror/state";
StateEffect.mapEffects($0, $1)""")>]
        static member inline mapEffects (effects: ResizeArray<CodemirrorState.StateEffect<obj>>, mapping: CodemirrorState.ChangeDesc): ReadonlyArray<CodemirrorState.StateEffect<obj>> = nativeOnly
        /// <summary>
        /// This effect can be used to reconfigure the root extensions of
        /// the editor. Doing this will discard any extensions
        /// [appended](https://codemirror.net/6/docs/ref/#state.StateEffect^appendConfig), but does not reset
        /// the content of [reconfigured](https://codemirror.net/6/docs/ref/#state.Compartment.reconfigure)
        /// compartments.
        /// </summary>
        [<Emit("""import { StateEffect } from "@codemirror/state";
StateEffect.reconfigure{{=$0}}""")>]
        static member inline reconfigure
            with get () : CodemirrorState.StateEffectType<CodemirrorState.Extension> =
                nativeOnly
            and set (value: CodemirrorState.StateEffectType<CodemirrorState.Extension>) =
                nativeOnly
        /// <summary>
        /// Append extensions to the top-level configuration of the editor.
        /// </summary>
        [<Emit("""import { StateEffect } from "@codemirror/state";
StateEffect.appendConfig{{=$0}}""")>]
        static member inline appendConfig
            with get () : CodemirrorState.StateEffectType<CodemirrorState.Extension> =
                nativeOnly
            and set (value: CodemirrorState.StateEffectType<CodemirrorState.Extension>) =
                nativeOnly

    /// <summary>
    /// Describes a [transaction](https://codemirror.net/6/docs/ref/#state.Transaction) when calling the
    /// [<c>EditorState.update</c>](https://codemirror.net/6/docs/ref/#state.EditorState.update) method.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type TransactionSpec =
        /// <summary>
        /// The changes to the document made by this transaction.
        /// </summary>
        abstract member changes: CodemirrorState.ChangeSpec option with get, set
        /// <summary>
        /// When set, this transaction explicitly updates the selection.
        /// Offsets in this selection should refer to the document as it is
        /// _after_ the transaction.
        /// </summary>
        abstract member selection: U2<CodemirrorState.EditorSelection, TransactionSpec.selection.U2.Case2> option with get, set
        /// <summary>
        /// Attach [state effects](https://codemirror.net/6/docs/ref/#state.StateEffect) to this transaction.
        /// Again, when they contain positions and this same spec makes
        /// changes, those positions should refer to positions in the
        /// updated document.
        /// </summary>
        abstract member effects: U2<CodemirrorState.StateEffect<obj>, ResizeArray<CodemirrorState.StateEffect<obj>>> option with get, set
        /// <summary>
        /// Set [annotations](https://codemirror.net/6/docs/ref/#state.Annotation) for this transaction.
        /// </summary>
        abstract member annotations: U2<CodemirrorState.Annotation<obj>, ResizeArray<CodemirrorState.Annotation<obj>>> option with get, set
        /// <summary>
        /// Shorthand for <c>annotations:</c> [<c>Transaction.userEvent</c>](https://codemirror.net/6/docs/ref/#state.Transaction^userEvent)<c>.of(...)</c>.
        /// </summary>
        abstract member userEvent: string option with get, set
        /// <summary>
        /// When set to <c>true</c>, the transaction is marked as needing to
        /// scroll the current selection into view.
        /// </summary>
        abstract member scrollIntoView: bool option with get, set
        /// <summary>
        /// By default, transactions can be modified by [change
        /// filters](https://codemirror.net/6/docs/ref/#state.EditorState^changeFilter) and [transaction
        /// filters](https://codemirror.net/6/docs/ref/#state.EditorState^transactionFilter). You can set this
        /// to <c>false</c> to disable that. This can be necessary for
        /// transactions that, for example, include annotations that must be
        /// kept consistent with their changes.
        /// </summary>
        abstract member filter: bool option with get, set
        /// <summary>
        /// Normally, when multiple specs are combined (for example by
        /// [<c>EditorState.update</c>](https://codemirror.net/6/docs/ref/#state.EditorState.update)), the
        /// positions in <c>changes</c> are taken to refer to the document
        /// positions in the initial document. When a spec has <c>sequental</c>
        /// set to true, its positions will be taken to refer to the
        /// document created by the specs before it instead.
        /// </summary>
        abstract member sequential: bool option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?changes: CodemirrorState.ChangeSpec, ?selection: U2<CodemirrorState.EditorSelection, TransactionSpec.selection.U2.Case2>, ?effects: U2<CodemirrorState.StateEffect<obj>, ResizeArray<CodemirrorState.StateEffect<obj>>>, ?annotations: U2<CodemirrorState.Annotation<obj>, ResizeArray<CodemirrorState.Annotation<obj>>>, ?userEvent: string, ?scrollIntoView: bool, ?filter: bool, ?sequential: bool) : TransactionSpec = nativeOnly

    /// <summary>
    /// Changes to the editor state are grouped into transactions.
    /// Typically, a user action creates a single transaction, which may
    /// contain any number of document changes, may change the selection,
    /// or have other effects. Create a transaction by calling
    /// [<c>EditorState.update</c>](https://codemirror.net/6/docs/ref/#state.EditorState.update), or immediately
    /// dispatch one by calling
    /// [<c>EditorView.dispatch</c>](https://codemirror.net/6/docs/ref/#view.EditorView.dispatch).
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("Transaction", "@codemirror/state")>]
    type Transaction =
        /// <summary>
        /// The state from which the transaction starts.
        /// </summary>
        abstract member startState: CodemirrorState.EditorState with get
        /// <summary>
        /// The document changes made by this transaction.
        /// </summary>
        abstract member changes: CodemirrorState.ChangeSet with get
        /// <summary>
        /// The selection set by this transaction, or undefined if it
        /// doesn't explicitly set a selection.
        /// </summary>
        abstract member selection: CodemirrorState.EditorSelection option with get
        /// <summary>
        /// The effects added to the transaction.
        /// </summary>
        abstract member effects: ReadonlyArray<CodemirrorState.StateEffect<obj>> with get
        /// <summary>
        /// Whether the selection should be scrolled into view after this
        /// transaction is dispatched.
        /// </summary>
        abstract member scrollIntoView: bool with get
        /// <summary>
        /// The new document produced by the transaction. Contrary to
        /// [<c>.state</c>](https://codemirror.net/6/docs/ref/#state.Transaction.state)<c>.doc</c>, accessing this won't
        /// force the entire new state to be computed right away, so it is
        /// recommended that [transaction
        /// filters](https://codemirror.net/6/docs/ref/#state.EditorState^transactionFilter) use this getter
        /// when they need to look at the new document.
        /// </summary>
        abstract member newDoc: CodemirrorState.Text with get
        /// <summary>
        /// The new selection produced by the transaction. If
        /// [<c>this.selection</c>](https://codemirror.net/6/docs/ref/#state.Transaction.selection) is undefined,
        /// this will [map](https://codemirror.net/6/docs/ref/#state.EditorSelection.map) the start state's
        /// current selection through the changes made by the transaction.
        /// </summary>
        abstract member newSelection: CodemirrorState.EditorSelection with get
        /// <summary>
        /// The new state created by the transaction. Computed on demand
        /// (but retained for subsequent access), so it is recommended not to
        /// access it in [transaction
        /// filters](https://codemirror.net/6/docs/ref/#state.EditorState^transactionFilter) when possible.
        /// </summary>
        abstract member state: CodemirrorState.EditorState with get
        /// <summary>
        /// Get the value of the given annotation type, if any.
        /// </summary>
        abstract member annotation<'T>: ``type``: CodemirrorState.AnnotationType<'T> -> 'T option
        /// <summary>
        /// Indicates whether the transaction changed the document.
        /// </summary>
        abstract member docChanged: bool with get
        /// <summary>
        /// Indicates whether this transaction reconfigures the state
        /// (through a [configuration compartment](https://codemirror.net/6/docs/ref/#state.Compartment) or
        /// with a top-level configuration
        /// [effect](https://codemirror.net/6/docs/ref/#state.StateEffect^reconfigure).
        /// </summary>
        abstract member reconfigured: bool with get
        /// <summary>
        /// Returns true if the transaction has a [user
        /// event](https://codemirror.net/6/docs/ref/#state.Transaction^userEvent) annotation that is equal to
        /// or more specific than <c>event</c>. For example, if the transaction
        /// has <c>"select.pointer"</c> as user event, <c>"select"</c> and
        /// <c>"select.pointer"</c> will match it.
        /// </summary>
        abstract member isUserEvent: event: string -> bool
        /// <summary>
        /// Annotation used to store transaction timestamps. Automatically
        /// added to every transaction, holding <c>Date.now()</c>.
        /// </summary>
        [<Emit("""import { Transaction } from "@codemirror/state";
Transaction.time{{=$0}}""")>]
        static member inline time
            with get () : CodemirrorState.AnnotationType<float> =
                nativeOnly
            and set (value: CodemirrorState.AnnotationType<float>) =
                nativeOnly
        /// <summary>
        /// Annotation used to associate a transaction with a user interface
        /// event. Holds a string identifying the event, using a
        /// dot-separated format to support attaching more specific
        /// information. The events used by the core libraries are:
        ///
        ///  - <c>"input"</c> when content is entered
        ///    - <c>"input.type"</c> for typed input
        ///      - <c>"input.type.compose"</c> for composition
        ///    - <c>"input.paste"</c> for pasted input
        ///    - <c>"input.drop"</c> when adding content with drag-and-drop
        ///    - <c>"input.complete"</c> when autocompleting
        ///  - <c>"delete"</c> when the user deletes content
        ///    - <c>"delete.selection"</c> when deleting the selection
        ///    - <c>"delete.forward"</c> when deleting forward from the selection
        ///    - <c>"delete.backward"</c> when deleting backward from the selection
        ///    - <c>"delete.cut"</c> when cutting to the clipboard
        ///  - <c>"move"</c> when content is moved
        ///    - <c>"move.drop"</c> when content is moved within the editor through drag-and-drop
        ///  - <c>"select"</c> when explicitly changing the selection
        ///    - <c>"select.pointer"</c> when selecting with a mouse or other pointing device
        ///  - <c>"undo"</c> and <c>"redo"</c> for history actions
        ///
        /// Use [<c>isUserEvent</c>](https://codemirror.net/6/docs/ref/#state.Transaction.isUserEvent) to check
        /// whether the annotation matches a given event.
        /// </summary>
        [<Emit("""import { Transaction } from "@codemirror/state";
Transaction.userEvent{{=$0}}""")>]
        static member inline userEvent
            with get () : CodemirrorState.AnnotationType<string> =
                nativeOnly
            and set (value: CodemirrorState.AnnotationType<string>) =
                nativeOnly
        /// <summary>
        /// Annotation indicating whether a transaction should be added to
        /// the undo history or not.
        /// </summary>
        [<Emit("""import { Transaction } from "@codemirror/state";
Transaction.addToHistory{{=$0}}""")>]
        static member inline addToHistory
            with get () : CodemirrorState.AnnotationType<bool> =
                nativeOnly
            and set (value: CodemirrorState.AnnotationType<bool>) =
                nativeOnly
        /// <summary>
        /// Annotation indicating (when present and true) that a transaction
        /// represents a change made by some other actor, not the user. This
        /// is used, for example, to tag other people's changes in
        /// collaborative editing.
        /// </summary>
        [<Emit("""import { Transaction } from "@codemirror/state";
Transaction.remote{{=$0}}""")>]
        static member inline remote
            with get () : CodemirrorState.AnnotationType<bool> =
                nativeOnly
            and set (value: CodemirrorState.AnnotationType<bool>) =
                nativeOnly

    [<RequireQualifiedAccess>]
    type CharCategory =
        | Word = 0
        | Space = 1
        | Other = 2

    /// <summary>
    /// Options passed when [creating](https://codemirror.net/6/docs/ref/#state.EditorState^create) an
    /// editor state.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type EditorStateConfig =
        /// <summary>
        /// The initial document. Defaults to an empty document. Can be
        /// provided either as a plain string (which will be split into
        /// lines according to the value of the [<c>lineSeparator</c>
        /// facet](https://codemirror.net/6/docs/ref/#state.EditorState^lineSeparator)), or an instance of
        /// the [<c>Text</c>](https://codemirror.net/6/docs/ref/#state.Text) class (which is what the state will use
        /// to represent the document).
        /// </summary>
        abstract member doc: U2<string, CodemirrorState.Text> option with get, set
        /// <summary>
        /// The starting selection. Defaults to a cursor at the very start
        /// of the document.
        /// </summary>
        abstract member selection: U2<CodemirrorState.EditorSelection, EditorStateConfig.selection.U2.Case2> option with get, set
        /// <summary>
        /// [Extension(s)](https://codemirror.net/6/docs/ref/#state.Extension) to associate with this state.
        /// </summary>
        abstract member extensions: CodemirrorState.Extension option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?doc: U2<string, CodemirrorState.Text>, ?selection: U2<CodemirrorState.EditorSelection, EditorStateConfig.selection.U2.Case2>, ?extensions: CodemirrorState.Extension) : EditorStateConfig = nativeOnly

    /// <summary>
    /// The editor state class is a persistent (immutable) data structure.
    /// To update a state, you [create](https://codemirror.net/6/docs/ref/#state.EditorState.update) a
    /// [transaction](https://codemirror.net/6/docs/ref/#state.Transaction), which produces a _new_ state
    /// instance, without modifying the original object.
    ///
    /// As such, _never_ mutate properties of a state directly. That'll
    /// just break things.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("EditorState", "@codemirror/state")>]
    type EditorState =
        /// <summary>
        /// The current document.
        /// </summary>
        abstract member doc: CodemirrorState.Text with get
        /// <summary>
        /// The current selection.
        /// </summary>
        abstract member selection: CodemirrorState.EditorSelection with get
        /// <summary>
        /// Retrieve the value of a [state field](https://codemirror.net/6/docs/ref/#state.StateField). Throws
        /// an error when the state doesn't have that field, unless you pass
        /// <c>false</c> as second parameter.
        /// </summary>
        abstract member field<'T>: field: CodemirrorState.StateField<'T> -> 'T
        /// <summary>
        /// Retrieve the value of a [state field](https://codemirror.net/6/docs/ref/#state.StateField). Throws
        /// an error when the state doesn't have that field, unless you pass
        /// <c>false</c> as second parameter.
        /// </summary>
        abstract member field<'T>: field: CodemirrorState.StateField<'T> * require: bool -> 'T option
        /// <summary>
        /// Create a [transaction](https://codemirror.net/6/docs/ref/#state.Transaction) that updates this
        /// state. Any number of [transaction specs](https://codemirror.net/6/docs/ref/#state.TransactionSpec)
        /// can be passed. Unless
        /// [<c>sequential</c>](https://codemirror.net/6/docs/ref/#state.TransactionSpec.sequential) is set, the
        /// [changes](https://codemirror.net/6/docs/ref/#state.TransactionSpec.changes) (if any) of each spec
        /// are assumed to start in the _current_ document (not the document
        /// produced by previous specs), and its
        /// [selection](https://codemirror.net/6/docs/ref/#state.TransactionSpec.selection) and
        /// [effects](https://codemirror.net/6/docs/ref/#state.TransactionSpec.effects) are assumed to refer
        /// to the document created by its _own_ changes. The resulting
        /// transaction contains the combined effect of all the different
        /// specs. For [selection](https://codemirror.net/6/docs/ref/#state.TransactionSpec.selection), later
        /// specs take precedence over earlier ones.
        /// </summary>
        abstract member update: [<ParamArray>] specs: CodemirrorState.TransactionSpec [] -> CodemirrorState.Transaction
        /// <summary>
        /// Create a [transaction spec](https://codemirror.net/6/docs/ref/#state.TransactionSpec) that
        /// replaces every selection range with the given content.
        /// </summary>
        abstract member replaceSelection: text: string -> CodemirrorState.TransactionSpec
        /// <summary>
        /// Create a [transaction spec](https://codemirror.net/6/docs/ref/#state.TransactionSpec) that
        /// replaces every selection range with the given content.
        /// </summary>
        abstract member replaceSelection: text: CodemirrorState.Text -> CodemirrorState.TransactionSpec
        /// <summary>
        /// Create a set of changes and a new selection by running the given
        /// function for each range in the active selection. The function
        /// can return an optional set of changes (in the coordinate space
        /// of the start document), plus an updated range (in the coordinate
        /// space of the document produced by the call's own changes). This
        /// method will merge all the changes and ranges into a single
        /// changeset and selection, and return it as a [transaction
        /// spec](https://codemirror.net/6/docs/ref/#state.TransactionSpec), which can be passed to
        /// [<c>update</c>](https://codemirror.net/6/docs/ref/#state.EditorState.update).
        /// </summary>
        abstract member changeByRange: f: (CodemirrorState.SelectionRange -> EditorState.changeByRange.f) -> EditorState.changeByRange
        /// <summary>
        /// Create a [change set](https://codemirror.net/6/docs/ref/#state.ChangeSet) from the given change
        /// description, taking the state's document length and line
        /// separator into account.
        /// </summary>
        abstract member changes: unit -> CodemirrorState.ChangeSet
        /// <summary>
        /// Create a [change set](https://codemirror.net/6/docs/ref/#state.ChangeSet) from the given change
        /// description, taking the state's document length and line
        /// separator into account.
        /// </summary>
        abstract member changes: spec: ChangeSpec.Cases.Case1 -> CodemirrorState.ChangeSet
        /// <summary>
        /// Create a [change set](https://codemirror.net/6/docs/ref/#state.ChangeSet) from the given change
        /// description, taking the state's document length and line
        /// separator into account.
        /// </summary>
        abstract member changes: spec: CodemirrorState.ChangeSet -> CodemirrorState.ChangeSet
        /// <summary>
        /// Create a [change set](https://codemirror.net/6/docs/ref/#state.ChangeSet) from the given change
        /// description, taking the state's document length and line
        /// separator into account.
        /// </summary>
        abstract member changes: spec: ResizeArray<CodemirrorState.ChangeSpec> -> CodemirrorState.ChangeSet
        /// <summary>
        /// Using the state's [line
        /// separator](https://codemirror.net/6/docs/ref/#state.EditorState^lineSeparator), create a
        /// [<c>Text</c>](https://codemirror.net/6/docs/ref/#state.Text) instance from the given string.
        /// </summary>
        abstract member toText: string: string -> CodemirrorState.Text
        /// <summary>
        /// Return the given range of the document as a string.
        /// </summary>
        abstract member sliceDoc: ?from: float * ?``to``: float -> string
        /// <summary>
        /// Get the value of a state [facet](https://codemirror.net/6/docs/ref/#state.Facet).
        /// </summary>
        abstract member facet<'Output>: facet: CodemirrorState.FacetReader<'Output> -> 'Output
        /// <summary>
        /// Convert this state to a JSON-serializable object. When custom
        /// fields should be serialized, you can pass them in as an object
        /// mapping property names (in the resulting object, which should
        /// not use <c>doc</c> or <c>selection</c>) to fields.
        /// </summary>
        abstract member toJSON: ?fields: EditorState.toJSON.fields -> obj
        /// <summary>
        /// Deserialize a state from its JSON representation. When custom
        /// fields should be deserialized, pass the same object you passed
        /// to [<c>toJSON</c>](https://codemirror.net/6/docs/ref/#state.EditorState.toJSON) when serializing as
        /// third argument.
        /// </summary>
        [<Emit("""import { EditorState } from "@codemirror/state";
EditorState.fromJSON($0, $1, $2)""")>]
        static member inline fromJSON (json: obj, ?config: CodemirrorState.EditorStateConfig, ?fields: EditorState.fromJSON__.fields): CodemirrorState.EditorState = nativeOnly
        /// <summary>
        /// Create a new state. You'll usually only need this when
        /// initializing an editor—updated states are created by applying
        /// transactions.
        /// </summary>
        [<Emit("""import { EditorState } from "@codemirror/state";
EditorState.create($0)""")>]
        static member inline create (?config: CodemirrorState.EditorStateConfig): CodemirrorState.EditorState = nativeOnly
        /// <summary>
        /// A facet that, when enabled, causes the editor to allow multiple
        /// ranges to be selected. Be careful though, because by default the
        /// editor relies on the native DOM selection, which cannot handle
        /// multiple selections. An extension like
        /// [<c>drawSelection</c>](https://codemirror.net/6/docs/ref/#view.drawSelection) can be used to make
        /// secondary selections visible to the user.
        /// </summary>
        [<Emit("""import { EditorState } from "@codemirror/state";
EditorState.allowMultipleSelections{{=$0}}""")>]
        static member inline allowMultipleSelections
            with get () : CodemirrorState.Facet<bool, bool> =
                nativeOnly
            and set (value: CodemirrorState.Facet<bool, bool>) =
                nativeOnly
        /// <summary>
        /// Configures the tab size to use in this state. The first
        /// (highest-precedence) value of the facet is used. If no value is
        /// given, this defaults to 4.
        /// </summary>
        [<Emit("""import { EditorState } from "@codemirror/state";
EditorState.tabSize{{=$0}}""")>]
        static member inline tabSize
            with get () : CodemirrorState.Facet<float, float> =
                nativeOnly
            and set (value: CodemirrorState.Facet<float, float>) =
                nativeOnly
        /// <summary>
        /// The line separator to use. By default, any of <c>"\n"</c>, <c>"\r\n"</c>
        /// and <c>"\r"</c> is treated as a separator when splitting lines, and
        /// lines are joined with <c>"\n"</c>.
        ///
        /// When you configure a value here, only that precise separator
        /// will be used, allowing you to round-trip documents through the
        /// editor without normalizing line separators.
        /// </summary>
        [<Emit("""import { EditorState } from "@codemirror/state";
EditorState.lineSeparator{{=$0}}""")>]
        static member inline lineSeparator
            with get () : CodemirrorState.Facet<string, string option> =
                nativeOnly
            and set (value: CodemirrorState.Facet<string, string option>) =
                nativeOnly
        /// <summary>
        /// Get the proper [line-break](https://codemirror.net/6/docs/ref/#state.EditorState^lineSeparator)
        /// string for this state.
        /// </summary>
        abstract member lineBreak: string with get
        /// <summary>
        /// This facet controls the value of the
        /// [<c>readOnly</c>](https://codemirror.net/6/docs/ref/#state.EditorState.readOnly) getter, which is
        /// consulted by commands and extensions that implement editing
        /// functionality to determine whether they should apply. It
        /// defaults to false, but when its highest-precedence value is
        /// <c>true</c>, such functionality disables itself.
        ///
        /// Not to be confused with
        /// [<c>EditorView.editable</c>](https://codemirror.net/6/docs/ref/#view.EditorView^editable), which
        /// controls whether the editor's DOM is set to be editable (and
        /// thus focusable).
        /// </summary>
        [<Emit("""import { EditorState } from "@codemirror/state";
EditorState.readOnly{{=$0}}""")>]
        static member inline readOnly
            with get () : CodemirrorState.Facet<bool, bool> =
                nativeOnly
            and set (value: CodemirrorState.Facet<bool, bool>) =
                nativeOnly
        /// <summary>
        /// Registers translation phrases. The
        /// [<c>phrase</c>](https://codemirror.net/6/docs/ref/#state.EditorState.phrase) method will look through
        /// all objects registered with this facet to find translations for
        /// its argument.
        /// </summary>
        [<Emit("""import { EditorState } from "@codemirror/state";
EditorState.phrases{{=$0}}""")>]
        static member inline phrases
            with get () : CodemirrorState.Facet<EditorState.phrases__, ReadonlyArray<EditorState.phrases__.Item>> =
                nativeOnly
            and set (value: CodemirrorState.Facet<EditorState.phrases__, ReadonlyArray<EditorState.phrases__.Item>>) =
                nativeOnly
        /// <summary>
        /// Look up a translation for the given phrase (via the
        /// [<c>phrases</c>](https://codemirror.net/6/docs/ref/#state.EditorState^phrases) facet), or return the
        /// original string if no translation is found.
        ///
        /// If additional arguments are passed, they will be inserted in
        /// place of markers like <c>$1</c> (for the first value) and <c>$2</c>, etc.
        /// A single <c>$</c> is equivalent to <c>$1</c>, and <c>$$</c> will produce a
        /// literal dollar sign.
        /// </summary>
        abstract member phrase: phrase: string * [<ParamArray>] insert: obj [] -> string
        /// <summary>
        /// A facet used to register [language
        /// data](https://codemirror.net/6/docs/ref/#state.EditorState.languageDataAt) providers.
        /// </summary>
        [<Emit("""import { EditorState } from "@codemirror/state";
EditorState.languageData{{=$0}}""")>]
        static member inline languageData
            with get () : CodemirrorState.Facet<EditorState.languageData__, ReadonlyArray<EditorState.languageData__.Item>> =
                nativeOnly
            and set (value: CodemirrorState.Facet<EditorState.languageData__, ReadonlyArray<EditorState.languageData__.Item>>) =
                nativeOnly
        /// <summary>
        /// Find the values for a given language data field, provided by the
        /// the [<c>languageData</c>](https://codemirror.net/6/docs/ref/#state.EditorState^languageData) facet.
        ///
        /// Examples of language data fields are...
        ///
        /// - [<c>"commentTokens"</c>](https://codemirror.net/6/docs/ref/#commands.CommentTokens) for specifying
        ///   comment syntax.
        /// - [<c>"autocomplete"</c>](https://codemirror.net/6/docs/ref/#autocomplete.autocompletion^config.override)
        ///   for providing language-specific completion sources.
        /// - [<c>"wordChars"</c>](https://codemirror.net/6/docs/ref/#state.EditorState.charCategorizer) for adding
        ///   characters that should be considered part of words in this
        ///   language.
        /// - [<c>"closeBrackets"</c>](https://codemirror.net/6/docs/ref/#autocomplete.CloseBracketConfig) controls
        ///   bracket closing behavior.
        /// </summary>
        abstract member languageDataAt<'T>: name: string * pos: float * ?side: EditorState.languageDataAt.side -> ReadonlyArray<'T>
        /// <summary>
        /// Return a function that can categorize strings (expected to
        /// represent a single [grapheme cluster](https://codemirror.net/6/docs/ref/#state.findClusterBreak))
        /// into one of:
        ///
        ///  - Word (contains an alphanumeric character or a character
        ///    explicitly listed in the local language's <c>"wordChars"</c>
        ///    language data, which should be a string)
        ///  - Space (contains only whitespace)
        ///  - Other (anything else)
        /// </summary>
        abstract member charCategorizer: at: float -> (string -> CodemirrorState.CharCategory)
        /// <summary>
        /// Find the word at the given position, meaning the range
        /// containing all [word](https://codemirror.net/6/docs/ref/#state.CharCategory.Word) characters
        /// around it. If no word characters are adjacent to the position,
        /// this returns null.
        /// </summary>
        abstract member wordAt: pos: float -> CodemirrorState.SelectionRange option
        /// <summary>
        /// Facet used to register change filters, which are called for each
        /// transaction (unless explicitly
        /// [disabled](https://codemirror.net/6/docs/ref/#state.TransactionSpec.filter)), and can suppress
        /// part of the transaction's changes.
        ///
        /// Such a function can return <c>true</c> to indicate that it doesn't
        /// want to do anything, <c>false</c> to completely stop the changes in
        /// the transaction, or a set of ranges in which changes should be
        /// suppressed. Such ranges are represented as an array of numbers,
        /// with each pair of two numbers indicating the start and end of a
        /// range. So for example <c>[10, 20, 100, 110]</c> suppresses changes
        /// between 10 and 20, and between 100 and 110.
        /// </summary>
        [<Emit("""import { EditorState } from "@codemirror/state";
EditorState.changeFilter{{=$0}}""")>]
        static member inline changeFilter
            with get () : CodemirrorState.Facet<(CodemirrorState.Transaction -> U2<bool, ResizeArray<float>>), ReadonlyArray<(CodemirrorState.Transaction -> U2<bool, ResizeArray<float>>)>> =
                nativeOnly
            and set (value: CodemirrorState.Facet<(CodemirrorState.Transaction -> U2<bool, ResizeArray<float>>), ReadonlyArray<(CodemirrorState.Transaction -> U2<bool, ResizeArray<float>>)>>) =
                nativeOnly
        /// <summary>
        /// Facet used to register a hook that gets a chance to update or
        /// replace transaction specs before they are applied. This will
        /// only be applied for transactions that don't have
        /// [<c>filter</c>](https://codemirror.net/6/docs/ref/#state.TransactionSpec.filter) set to <c>false</c>. You
        /// can either return a single transaction spec (possibly the input
        /// transaction), or an array of specs (which will be combined in
        /// the same way as the arguments to
        /// [<c>EditorState.update</c>](https://codemirror.net/6/docs/ref/#state.EditorState.update)).
        ///
        /// When possible, it is recommended to avoid accessing
        /// [<c>Transaction.state</c>](https://codemirror.net/6/docs/ref/#state.Transaction.state) in a filter,
        /// since it will force creation of a state that will then be
        /// discarded again, if the transaction is actually filtered.
        ///
        /// (This functionality should be used with care. Indiscriminately
        /// modifying transaction is likely to break something or degrade
        /// the user experience.)
        /// </summary>
        [<Emit("""import { EditorState } from "@codemirror/state";
EditorState.transactionFilter{{=$0}}""")>]
        static member inline transactionFilter
            with get () : CodemirrorState.Facet<(CodemirrorState.Transaction -> U2<CodemirrorState.TransactionSpec, ResizeArray<CodemirrorState.TransactionSpec>>), ReadonlyArray<(CodemirrorState.Transaction -> U2<CodemirrorState.TransactionSpec, ResizeArray<CodemirrorState.TransactionSpec>>)>> =
                nativeOnly
            and set (value: CodemirrorState.Facet<(CodemirrorState.Transaction -> U2<CodemirrorState.TransactionSpec, ResizeArray<CodemirrorState.TransactionSpec>>), ReadonlyArray<(CodemirrorState.Transaction -> U2<CodemirrorState.TransactionSpec, ResizeArray<CodemirrorState.TransactionSpec>>)>>) =
                nativeOnly
        /// <summary>
        /// This is a more limited form of
        /// [<c>transactionFilter</c>](https://codemirror.net/6/docs/ref/#state.EditorState^transactionFilter),
        /// which can only add
        /// [annotations](https://codemirror.net/6/docs/ref/#state.TransactionSpec.annotations) and
        /// [effects](https://codemirror.net/6/docs/ref/#state.TransactionSpec.effects). _But_, this type
        /// of filter runs even if the transaction has disabled regular
        /// [filtering](https://codemirror.net/6/docs/ref/#state.TransactionSpec.filter), making it suitable
        /// for effects that don't need to touch the changes or selection,
        /// but do want to process every transaction.
        ///
        /// Extenders run _after_ filters, when both are present.
        /// </summary>
        [<Emit("""import { EditorState } from "@codemirror/state";
EditorState.transactionExtender{{=$0}}""")>]
        static member inline transactionExtender
            with get () : CodemirrorState.Facet<(CodemirrorState.Transaction -> EditorState.transactionExtender__ option), ReadonlyArray<(CodemirrorState.Transaction -> EditorState.transactionExtender__.Item option)>> =
                nativeOnly
            and set (value: CodemirrorState.Facet<(CodemirrorState.Transaction -> EditorState.transactionExtender__ option), ReadonlyArray<(CodemirrorState.Transaction -> EditorState.transactionExtender__.Item option)>>) =
                nativeOnly

    /// <summary>
    /// Subtype of [<c>Command</c>](https://codemirror.net/6/docs/ref/#view.Command) that doesn't require access
    /// to the actual editor view. Mostly useful to define commands that
    /// can be run and tested outside of a browser environment.
    /// </summary>
    type StateCommand =
        StateCommand.target -> bool

    /// <summary>
    /// Each range is associated with a value, which must inherit from
    /// this class.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("RangeValue", "@codemirror/state")>]
    type RangeValue =
        /// <summary>
        /// Compare this value with another value. Used when comparing
        /// rangesets. The default implementation compares by identity.
        /// Unless you are only creating a fixed number of unique instances
        /// of your value type, it is a good idea to implement this
        /// properly.
        /// </summary>
        abstract member eq: other: CodemirrorState.RangeValue -> bool
        /// <summary>
        /// The bias value at the start of the range. Determines how the
        /// range is positioned relative to other ranges starting at this
        /// position. Defaults to 0.
        /// </summary>
        abstract member startSide: float with get, set
        /// <summary>
        /// The bias value at the end of the range. Defaults to 0.
        /// </summary>
        abstract member endSide: float with get, set
        /// <summary>
        /// The mode with which the location of the range should be mapped
        /// when its <c>from</c> and <c>to</c> are the same, to decide whether a
        /// change deletes the range. Defaults to <c>MapMode.TrackDel</c>.
        /// </summary>
        abstract member mapMode: CodemirrorState.MapMode with get, set
        /// <summary>
        /// Determines whether this value marks a point range. Regular
        /// ranges affect the part of the document they cover, and are
        /// meaningless when empty. Point ranges have a meaning on their
        /// own. When non-empty, a point range is treated as atomic and
        /// shadows any ranges contained in it.
        /// </summary>
        abstract member point: bool with get, set
        /// <summary>
        /// Create a [range](https://codemirror.net/6/docs/ref/#state.Range) with this value.
        /// </summary>
        abstract member range: from: float * ?``to``: float -> CodemirrorState.Range<RangeValue>

    /// <summary>
    /// A range associates a value with a range of positions.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("Range", "@codemirror/state")>]
    type Range<'T> =
        /// <summary>
        /// The range's start position.
        /// </summary>
        abstract member from: float with get
        /// <summary>
        /// Its end position.
        /// </summary>
        abstract member ``to``: float with get
        /// <summary>
        /// The value associated with this range.
        /// </summary>
        abstract member value: 'T with get

    /// <summary>
    /// Collection of methods used when comparing range sets.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type RangeComparator<'T> =
        /// <summary>
        /// Notifies the comparator that a range (in positions in the new
        /// document) has the given sets of values associated with it, which
        /// are different in the old (A) and new (B) sets.
        /// </summary>
        abstract member compareRange: from: float * ``to``: float * activeA: ResizeArray<'T> * activeB: ResizeArray<'T> -> unit
        /// <summary>
        /// Notification for a changed (or inserted, or deleted) point range.
        /// </summary>
        abstract member comparePoint: from: float * ``to``: float * pointA: 'T option * pointB: 'T option -> unit
        /// <summary>
        /// Notification for a changed boundary between ranges. For example,
        /// if the same span is covered by two partial ranges before and one
        /// bigger range after, this is called at the point where the ranges
        /// used to be split.
        /// </summary>
        abstract member boundChange: (float -> unit) option with get, set

    /// <summary>
    /// Methods used when iterating over the spans created by a set of
    /// ranges. The entire iterated range will be covered with either
    /// <c>span</c> or <c>point</c> calls.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type SpanIterator<'T> =
        /// <summary>
        /// Called for any ranges not covered by point decorations. <c>active</c>
        /// holds the values that the range is marked with (and may be
        /// empty). <c>openStart</c> indicates how many of those ranges are open
        /// (continued) at the start of the span.
        /// </summary>
        abstract member span: from: float * ``to``: float * active: ResizeArray<'T> * openStart: float -> unit
        /// <summary>
        /// Called when going over a point decoration. The active range
        /// decorations that cover the point and have a higher precedence
        /// are provided in <c>active</c>. The open count in <c>openStart</c> counts
        /// the number of those ranges that started before the point and. If
        /// the point started before the iterated range, <c>openStart</c> will be
        /// <c>active.length + 1</c> to signal this.
        /// </summary>
        abstract member point: from: float * ``to``: float * value: 'T * active: ResizeArray<'T> * openStart: float * index: float -> unit

    /// <summary>
    /// A range cursor is an object that moves to the next range every
    /// time you call <c>next</c> on it. Note that, unlike ES6 iterators, these
    /// start out pointing at the first element, so you should call <c>next</c>
    /// only after reading the first range (if any).
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type RangeCursor<'T> =
        /// <summary>
        /// Move the iterator forward.
        /// </summary>
        abstract member next: unit -> unit
        /// <summary>
        /// Jump the cursor to the given position.
        /// </summary>
        abstract member goto: pos: float -> unit
        /// <summary>
        /// The next range's value. Holds <c>null</c> when the cursor has reached
        /// its end.
        /// </summary>
        abstract member value: 'T option with get, set
        /// <summary>
        /// The next range's start position.
        /// </summary>
        abstract member from: float with get, set
        /// <summary>
        /// The next end position.
        /// </summary>
        abstract member ``to``: float with get, set
        /// <summary>
        /// The position of the set that this range comes from in the array
        /// of sets being iterated over.
        /// </summary>
        abstract member rank: float with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type RangeSetUpdate<'T> =
        /// <summary>
        /// An array of ranges to add. If given, this should be sorted by
        /// <c>from</c> position and <c>startSide</c> unless
        /// [<c>sort</c>](https://codemirror.net/6/docs/ref/#state.RangeSet.update^updateSpec.sort) is given as
        /// <c>true</c>.
        /// </summary>
        abstract member add: ReadonlyArray<CodemirrorState.Range<'T>> option with get, set
        /// <summary>
        /// Indicates whether the library should sort the ranges in <c>add</c>.
        /// Defaults to <c>false</c>.
        /// </summary>
        abstract member sort: bool option with get, set
        /// <summary>
        /// Filter the ranges already in the set. Only those for which this
        /// function returns <c>true</c> are kept.
        /// </summary>
        abstract member filter: RangeSetUpdate.filter<'T> option with get, set
        /// <summary>
        /// Can be used to limit the range on which the filter is
        /// applied. Filtering only a small range, as opposed to the entire
        /// set, can make updates cheaper.
        /// </summary>
        abstract member filterFrom: float option with get, set
        /// <summary>
        /// The end position to apply the filter to.
        /// </summary>
        abstract member filterTo: float option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?add: ResizeArray<CodemirrorState.Range<'T>>, ?sort: bool, ?filter: RangeSetUpdate.filter<'T>, ?filterFrom: float, ?filterTo: float) : RangeSetUpdate<'T> = nativeOnly

    /// <summary>
    /// A range set stores a collection of [ranges](https://codemirror.net/6/docs/ref/#state.Range) in a
    /// way that makes them efficient to [map](https://codemirror.net/6/docs/ref/#state.RangeSet.map) and
    /// [update](https://codemirror.net/6/docs/ref/#state.RangeSet.update). This is an immutable data
    /// structure.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("RangeSet", "@codemirror/state")>]
    type RangeSet<'T> =
        /// <summary>
        /// The number of ranges in the set.
        /// </summary>
        abstract member size: float with get
        /// <summary>
        /// Update the range set, optionally adding new ranges or filtering
        /// out existing ones.
        ///
        /// (Note: The type parameter is just there as a kludge to work
        /// around TypeScript variance issues that prevented <c>RangeSet<X></c>
        /// from being a subtype of <c>RangeSet<Y></c> when <c>X</c> is a subtype of
        /// <c>Y</c>.)
        /// </summary>
        abstract member update<'U>: updateSpec: CodemirrorState.RangeSetUpdate<'U> -> CodemirrorState.RangeSet<'T>
        /// <summary>
        /// Map this range set through a set of changes, return the new set.
        /// </summary>
        abstract member map: changes: CodemirrorState.ChangeDesc -> CodemirrorState.RangeSet<'T>
        /// <summary>
        /// Iterate over the ranges that touch the region <c>from</c> to <c>to</c>,
        /// calling <c>f</c> for each. There is no guarantee that the ranges will
        /// be reported in any specific order. When the callback returns
        /// <c>false</c>, iteration stops.
        /// </summary>
        abstract member between: from: float * ``to``: float * f: RangeSet.between.f<'T> -> unit
        /// <summary>
        /// Iterate over the ranges in this set, in order, including all
        /// ranges that end at or after <c>from</c>.
        /// </summary>
        abstract member iter: ?from: float -> CodemirrorState.RangeCursor<'T>
        /// <summary>
        /// Iterate over the ranges in a collection of sets, in order,
        /// starting from <c>from</c>.
        /// </summary>
        [<Emit("""import { RangeSet } from "@codemirror/state";
RangeSet.iter($0, $1)""")>]
        static member inline iter (sets: ResizeArray<CodemirrorState.RangeSet<'T>>, ?from: float): CodemirrorState.RangeCursor<'T> = nativeOnly
        /// <summary>
        /// Iterate over two groups of sets, calling methods on <c>comparator</c>
        /// to notify it of possible differences.
        /// </summary>
        [<Emit("""import { RangeSet } from "@codemirror/state";
RangeSet.compare($0, $1, $2, $3, $4)""")>]
        static member inline compare (oldSets: ResizeArray<CodemirrorState.RangeSet<'T>>, newSets: ResizeArray<CodemirrorState.RangeSet<'T>>, textDiff: CodemirrorState.ChangeDesc, comparator: CodemirrorState.RangeComparator<'T>, ?minPointSize: float): unit = nativeOnly
        /// <summary>
        /// Compare the contents of two groups of range sets, returning true
        /// if they are equivalent in the given range.
        /// </summary>
        [<Emit("""import { RangeSet } from "@codemirror/state";
RangeSet.eq($0, $1, $2, $3)""")>]
        static member inline eq (oldSets: ResizeArray<CodemirrorState.RangeSet<'T>>, newSets: ResizeArray<CodemirrorState.RangeSet<'T>>, ?from: float, ?``to``: float): bool = nativeOnly
        /// <summary>
        /// Iterate over a group of range sets at the same time, notifying
        /// the iterator about the ranges covering every given piece of
        /// content. Returns the open count (see
        /// [<c>SpanIterator.span</c>](https://codemirror.net/6/docs/ref/#state.SpanIterator.span)) at the end
        /// of the iteration.
        /// </summary>
        [<Emit("""import { RangeSet } from "@codemirror/state";
RangeSet.spans($0, $1, $2, $3, $4)""")>]
        static member inline spans (sets: ResizeArray<CodemirrorState.RangeSet<'T>>, from: float, ``to``: float, iterator: CodemirrorState.SpanIterator<'T>, ?minPointSize: float): float = nativeOnly
        /// <summary>
        /// Create a range set for the given range or array of ranges. By
        /// default, this expects the ranges to be _sorted_ (by start
        /// position and, if two start at the same position,
        /// <c>value.startSide</c>). You can pass <c>true</c> as second argument to
        /// cause the method to sort them.
        /// </summary>
        [<Emit("""import { RangeSet } from "@codemirror/state";
RangeSet.of($0, $1)""")>]
        static member inline ``of`` (ranges: ResizeArray<CodemirrorState.Range<'T>>, ?sort: bool): CodemirrorState.RangeSet<'T> = nativeOnly
        /// <summary>
        /// Create a range set for the given range or array of ranges. By
        /// default, this expects the ranges to be _sorted_ (by start
        /// position and, if two start at the same position,
        /// <c>value.startSide</c>). You can pass <c>true</c> as second argument to
        /// cause the method to sort them.
        /// </summary>
        [<Emit("""import { RangeSet } from "@codemirror/state";
RangeSet.of($0, $1)""")>]
        static member inline ``of`` (ranges: CodemirrorState.Range<'T>, ?sort: bool): CodemirrorState.RangeSet<'T> = nativeOnly
        /// <summary>
        /// Join an array of range sets into a single set.
        /// </summary>
        [<Emit("""import { RangeSet } from "@codemirror/state";
RangeSet.join($0)""")>]
        static member inline join (sets: ResizeArray<CodemirrorState.RangeSet<'T>>): CodemirrorState.RangeSet<'T> = nativeOnly
        /// <summary>
        /// The empty set of ranges.
        /// </summary>
        [<Emit("""import { RangeSet } from "@codemirror/state";
RangeSet.empty{{=$0}}""")>]
        static member inline empty
            with get () : CodemirrorState.RangeSet<obj> =
                nativeOnly
            and set (value: CodemirrorState.RangeSet<obj>) =
                nativeOnly

    /// <summary>
    /// A range set builder is a data structure that helps build up a
    /// [range set](https://codemirror.net/6/docs/ref/#state.RangeSet) directly, without first allocating
    /// an array of [<c>Range</c>](https://codemirror.net/6/docs/ref/#state.Range) objects.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("RangeSetBuilder", "@codemirror/state")>]
    type RangeSetBuilder<'T> =
        /// <summary>
        /// Add a range. Ranges should be added in sorted (by <c>from</c> and
        /// <c>value.startSide</c>) order.
        /// </summary>
        abstract member add: from: float * ``to``: float * value: 'T -> unit
        /// <summary>
        /// Finish the range set. Returns the new set. The builder can't be
        /// used anymore after this has been called.
        /// </summary>
        abstract member finish: unit -> CodemirrorState.RangeSet<'T>

    module Text =

        module iter =

            [<RequireQualifiedAccess>]
            type dir =
                | ``1`` = 1
                | _MINUS_1 = -1

    module ChangeDesc =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type touchesRange =
            | [<CompiledValue(true)>] True
            | [<CompiledValue(false)>] False
            | cover

        module iterGaps =

            type f =
                delegate of posA: float * posB: float * length: float -> unit

        module iterChangedRanges =

            type f =
                delegate of fromA: float * toA: float * fromB: float * toB: float -> unit

    module ChangeSpec =

        module Cases =

            [<AllowNullLiteral>]
            [<Interface>]
            type Case1 =
                abstract member from: float with get, set
                abstract member ``to``: float option with get, set
                abstract member insert: U2<string, CodemirrorState.Text> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (from: float, ?``to``: float) : Case1 = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (from: float, insert: string, ?``to``: float) : Case1 = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (from: float, insert: CodemirrorState.Text, ?``to``: float) : Case1 = nativeOnly

    module ChangeSet =

        module iterChanges =

            type f =
                delegate of fromA: float * toA: float * fromB: float * toB: float * inserted: CodemirrorState.Text -> unit

    module SelectionRange =

        [<RequireQualifiedAccess>]
        type assoc =
            | _MINUS_1 = -1
            | ``0`` = 0
            | ``1`` = 1

    module FacetConfig =

        type compare<'Output> =
            delegate of a: 'Output * b: 'Output -> bool

        type compareInput<'Input> =
            delegate of a: 'Input * b: 'Input -> bool

    module StateFieldSpec =

        type update<'Value> =
            delegate of value: 'Value * transaction: CodemirrorState.Transaction -> 'Value

        type compare<'Value> =
            delegate of a: 'Value * b: 'Value -> bool

        type toJSON<'Value> =
            delegate of value: 'Value * state: CodemirrorState.EditorState -> unit

        type fromJSON<'Value> =
            delegate of json: obj * state: CodemirrorState.EditorState -> 'Value

    module Extension =

        module Cases =

            [<AllowNullLiteral>]
            [<Interface>]
            type Case1 =
                abstract member extension: CodemirrorState.Extension with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (extension: CodemirrorState.Extension) : Case1 = nativeOnly

    module StateEffectSpec =

        type map<'Value> =
            delegate of value: 'Value * mapping: CodemirrorState.ChangeDesc -> 'Value option

    module StateEffectType =

        type map =
            delegate of value: obj * mapping: CodemirrorState.ChangeDesc -> obj option

    module TransactionSpec =

        module selection =

            module U2 =

                [<AllowNullLiteral>]
                [<Interface>]
                type Case2 =
                    abstract member anchor: float with get, set
                    abstract member head: float option with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (anchor: float, ?head: float) : Case2 = nativeOnly

    module EditorStateConfig =

        module selection =

            module U2 =

                [<AllowNullLiteral>]
                [<Interface>]
                type Case2 =
                    abstract member anchor: float with get, set
                    abstract member head: float option with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (anchor: float, ?head: float) : Case2 = nativeOnly

    module EditorState =

        [<AllowNullLiteral>]
        [<Interface>]
        type changeByRange =
            abstract member changes: CodemirrorState.ChangeSet with get, set
            abstract member selection: CodemirrorState.EditorSelection with get, set
            abstract member effects: ReadonlyArray<CodemirrorState.StateEffect<obj>> with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (changes: CodemirrorState.ChangeSet, selection: CodemirrorState.EditorSelection, effects: ResizeArray<CodemirrorState.StateEffect<obj>>) : changeByRange = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type phrases__ =
            [<EmitIndexer>]
            abstract member Item: key: string -> string with get, set

        type languageData__ =
            delegate of state: CodemirrorState.EditorState * pos: float * side: EditorState.languageData__.side -> ResizeArray<EditorState.languageData__.ReturnType.Item>

        [<AllowNullLiteral>]
        [<Interface>]
        type transactionExtender__ =
            /// <summary>
            /// Attach [state effects](https://codemirror.net/6/docs/ref/#state.StateEffect) to this transaction.
            /// Again, when they contain positions and this same spec makes
            /// changes, those positions should refer to positions in the
            /// updated document.
            /// </summary>
            abstract member effects: U2<CodemirrorState.StateEffect<obj>, ResizeArray<CodemirrorState.StateEffect<obj>>> option with get, set
            /// <summary>
            /// Set [annotations](https://codemirror.net/6/docs/ref/#state.Annotation) for this transaction.
            /// </summary>
            abstract member annotations: U2<CodemirrorState.Annotation<obj>, ResizeArray<CodemirrorState.Annotation<obj>>> option with get, set
            [<ParamObject; Emit("$0")>]
            static member Create () : transactionExtender__ = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (annotations: CodemirrorState.Annotation<obj>) : transactionExtender__ = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (annotations: ResizeArray<CodemirrorState.Annotation<obj>>) : transactionExtender__ = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (effects: CodemirrorState.StateEffect<obj>) : transactionExtender__ = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (effects: CodemirrorState.StateEffect<obj>, annotations: CodemirrorState.Annotation<obj>) : transactionExtender__ = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (effects: CodemirrorState.StateEffect<obj>, annotations: ResizeArray<CodemirrorState.Annotation<obj>>) : transactionExtender__ = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (effects: ResizeArray<CodemirrorState.StateEffect<obj>>) : transactionExtender__ = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (effects: ResizeArray<CodemirrorState.StateEffect<obj>>, annotations: CodemirrorState.Annotation<obj>) : transactionExtender__ = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (effects: ResizeArray<CodemirrorState.StateEffect<obj>>, annotations: ResizeArray<CodemirrorState.Annotation<obj>>) : transactionExtender__ = nativeOnly

        module changeByRange =

            [<AllowNullLiteral>]
            [<Interface>]
            type f =
                abstract member range: CodemirrorState.SelectionRange with get, set
                abstract member changes: CodemirrorState.ChangeSpec option with get, set
                abstract member effects: U2<CodemirrorState.StateEffect<obj>, ResizeArray<CodemirrorState.StateEffect<obj>>> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (range: CodemirrorState.SelectionRange) : f = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (range: CodemirrorState.SelectionRange, effects: CodemirrorState.StateEffect<obj>) : f = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (range: CodemirrorState.SelectionRange, effects: ResizeArray<CodemirrorState.StateEffect<obj>>) : f = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (range: CodemirrorState.SelectionRange, changes: ChangeSpec.Cases.Case1) : f = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (range: CodemirrorState.SelectionRange, changes: ChangeSpec.Cases.Case1, effects: CodemirrorState.StateEffect<obj>) : f = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (range: CodemirrorState.SelectionRange, changes: ChangeSpec.Cases.Case1, effects: ResizeArray<CodemirrorState.StateEffect<obj>>) : f = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (range: CodemirrorState.SelectionRange, changes: CodemirrorState.ChangeSet) : f = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (range: CodemirrorState.SelectionRange, changes: CodemirrorState.ChangeSet, effects: CodemirrorState.StateEffect<obj>) : f = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (range: CodemirrorState.SelectionRange, changes: CodemirrorState.ChangeSet, effects: ResizeArray<CodemirrorState.StateEffect<obj>>) : f = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (range: CodemirrorState.SelectionRange, changes: ResizeArray<CodemirrorState.ChangeSpec>) : f = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (range: CodemirrorState.SelectionRange, changes: ResizeArray<CodemirrorState.ChangeSpec>, effects: CodemirrorState.StateEffect<obj>) : f = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (range: CodemirrorState.SelectionRange, changes: ResizeArray<CodemirrorState.ChangeSpec>, effects: ResizeArray<CodemirrorState.StateEffect<obj>>) : f = nativeOnly

        module toJSON =

            [<AllowNullLiteral>]
            [<Interface>]
            type fields =
                [<EmitIndexer>]
                abstract member Item: prop: string -> CodemirrorState.StateField<obj> with get, set

        module fromJSON__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type fields =
                [<EmitIndexer>]
                abstract member Item: prop: string -> CodemirrorState.StateField<obj> with get, set

        module phrases__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type Item =
                [<EmitIndexer>]
                abstract member Item: key: string -> string with get, set

        module languageData__ =

            [<RequireQualifiedAccess>]
            type side =
                | _MINUS_1 = -1
                | ``0`` = 0
                | ``1`` = 1

            type Item =
                delegate of state: CodemirrorState.EditorState * pos: float * side: EditorState.languageData__.Item.side -> ResizeArray<EditorState.languageData__.Item.ReturnType.Item>

            module ReturnType =

                [<AllowNullLiteral>]
                [<Interface>]
                type Item =
                    [<EmitIndexer>]
                    abstract member Item: name: string -> obj with get, set

            module Item =

                [<RequireQualifiedAccess>]
                type side =
                    | _MINUS_1 = -1
                    | ``0`` = 0
                    | ``1`` = 1

                module ReturnType =

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type Item =
                        [<EmitIndexer>]
                        abstract member Item: name: string -> obj with get, set

        module languageDataAt =

            [<RequireQualifiedAccess>]
            type side =
                | _MINUS_1 = -1
                | ``0`` = 0
                | ``1`` = 1

        module transactionExtender__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type Item =
                /// <summary>
                /// Attach [state effects](https://codemirror.net/6/docs/ref/#state.StateEffect) to this transaction.
                /// Again, when they contain positions and this same spec makes
                /// changes, those positions should refer to positions in the
                /// updated document.
                /// </summary>
                abstract member effects: U2<CodemirrorState.StateEffect<obj>, ResizeArray<CodemirrorState.StateEffect<obj>>> option with get, set
                /// <summary>
                /// Set [annotations](https://codemirror.net/6/docs/ref/#state.Annotation) for this transaction.
                /// </summary>
                abstract member annotations: U2<CodemirrorState.Annotation<obj>, ResizeArray<CodemirrorState.Annotation<obj>>> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create () : Item = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (annotations: CodemirrorState.Annotation<obj>) : Item = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (annotations: ResizeArray<CodemirrorState.Annotation<obj>>) : Item = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (effects: CodemirrorState.StateEffect<obj>) : Item = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (effects: CodemirrorState.StateEffect<obj>, annotations: CodemirrorState.Annotation<obj>) : Item = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (effects: CodemirrorState.StateEffect<obj>, annotations: ResizeArray<CodemirrorState.Annotation<obj>>) : Item = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (effects: ResizeArray<CodemirrorState.StateEffect<obj>>) : Item = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (effects: ResizeArray<CodemirrorState.StateEffect<obj>>, annotations: CodemirrorState.Annotation<obj>) : Item = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (effects: ResizeArray<CodemirrorState.StateEffect<obj>>, annotations: ResizeArray<CodemirrorState.Annotation<obj>>) : Item = nativeOnly

    module StateCommand =

        [<AllowNullLiteral>]
        [<Interface>]
        type target =
            abstract member state: CodemirrorState.EditorState with get, set
            abstract member dispatch: (CodemirrorState.Transaction -> unit) with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (state: CodemirrorState.EditorState, dispatch: (CodemirrorState.Transaction -> unit)) : target = nativeOnly

    module RangeSetUpdate =

        type filter<'T> =
            delegate of from: float * ``to``: float * value: 'T -> bool

    module RangeSet =

        module between =

            type f<'T> =
                delegate of from: float * ``to``: float * value: 'T -> U2<unit, bool>

    module Exports =

        [<RequireQualifiedAccess>]
        type codePointSize__ =
            | ``1`` = 1
            | ``2`` = 2

        module Prec__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type Type =
                /// <summary>
                /// The highest precedence level, for extensions that should end up
                /// near the start of the precedence ordering.
                /// </summary>
                abstract member highest: (CodemirrorState.Extension -> CodemirrorState.Extension) with get, set
                /// <summary>
                /// A higher-than-default precedence, for extensions that should
                /// come before those with default precedence.
                /// </summary>
                abstract member high: (CodemirrorState.Extension -> CodemirrorState.Extension) with get, set
                /// <summary>
                /// The default precedence, which is also used for extensions
                /// without an explicit precedence.
                /// </summary>
                abstract member ``default``: (CodemirrorState.Extension -> CodemirrorState.Extension) with get, set
                /// <summary>
                /// A lower-than-default precedence.
                /// </summary>
                abstract member low: (CodemirrorState.Extension -> CodemirrorState.Extension) with get, set
                /// <summary>
                /// The lowest precedence level. Meant for things that should end up
                /// near the end of the extension order.
                /// </summary>
                abstract member lowest: (CodemirrorState.Extension -> CodemirrorState.Extension) with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (highest: (CodemirrorState.Extension -> CodemirrorState.Extension), high: (CodemirrorState.Extension -> CodemirrorState.Extension), ``default``: (CodemirrorState.Extension -> CodemirrorState.Extension), low: (CodemirrorState.Extension -> CodemirrorState.Extension), lowest: (CodemirrorState.Extension -> CodemirrorState.Extension)) : Type = nativeOnly

        module combineConfig__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type defaults =
                interface end

            [<AllowNullLiteral>]
            [<Interface>]
            type combine =
                [<EmitIndexer>]
                abstract member Item: key: string -> Exports.combineConfig__.combine.Item with get, set

            module configs =

                [<AllowNullLiteral>]
                [<Interface>]
                type Item =
                    interface end

            module combine =

                type Item =
                    delegate of first: obj * second: obj -> obj
