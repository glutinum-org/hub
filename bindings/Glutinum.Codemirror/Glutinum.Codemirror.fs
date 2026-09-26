namespace rec Glutinum

open Fable.Core
open Fable.Core.JsInterop
open System

// You need to add Glutinum.Types NuGet package to your project
open Glutinum.Types.TypeScript

// You need to add Glutinum.Web NuGet package to your project

type RegExp = Text.RegularExpressions.Regex

type Iterable<'T> = Collections.Generic.IEnumerable<'T>

module Codemirror =

    [<AbstractClass>]
    [<Erase>]
    type Exports =
        /// <summary>
        /// This is an extension value that just pulls together a number of
        /// extensions that you might want in a basic editor. It is meant as a
        /// convenient helper to quickly set up CodeMirror without installing
        /// and importing a lot of separate packages.
        ///
        /// Specifically, it includes...
        ///
        /// - [the default command bindings](https://codemirror.net/6/docs/ref/#commands.defaultKeymap)
        /// - [line numbers](https://codemirror.net/6/docs/ref/#view.lineNumbers)
        /// - [special character highlighting](https://codemirror.net/6/docs/ref/#view.highlightSpecialChars)
        /// - [the undo history](https://codemirror.net/6/docs/ref/#commands.history)
        /// - [a fold gutter](https://codemirror.net/6/docs/ref/#language.foldGutter)
        /// - [custom selection drawing](https://codemirror.net/6/docs/ref/#view.drawSelection)
        /// - [drop cursor](https://codemirror.net/6/docs/ref/#view.dropCursor)
        /// - [multiple selections](https://codemirror.net/6/docs/ref/#state.EditorState^allowMultipleSelections)
        /// - [reindentation on input](https://codemirror.net/6/docs/ref/#language.indentOnInput)
        /// - [the default highlight style](https://codemirror.net/6/docs/ref/#language.defaultHighlightStyle) (as fallback)
        /// - [bracket matching](https://codemirror.net/6/docs/ref/#language.bracketMatching)
        /// - [bracket closing](https://codemirror.net/6/docs/ref/#autocomplete.closeBrackets)
        /// - [autocompletion](https://codemirror.net/6/docs/ref/#autocomplete.autocompletion)
        /// - [rectangular selection](https://codemirror.net/6/docs/ref/#view.rectangularSelection) and [crosshair cursor](https://codemirror.net/6/docs/ref/#view.crosshairCursor)
        /// - [active line highlighting](https://codemirror.net/6/docs/ref/#view.highlightActiveLine)
        /// - [active line gutter highlighting](https://codemirror.net/6/docs/ref/#view.highlightActiveLineGutter)
        /// - [selection match highlighting](https://codemirror.net/6/docs/ref/#search.highlightSelectionMatches)
        /// - [search](https://codemirror.net/6/docs/ref/#search.searchKeymap)
        /// - [linting](https://codemirror.net/6/docs/ref/#lint.lintKeymap)
        ///
        /// (You'll probably want to add some language package to your setup
        /// too.)
        ///
        /// This extension does not allow customization. The idea is that,
        /// once you decide you want to configure your editor more precisely,
        /// you take this package's source (which is just a bunch of imports
        /// and an array literal), copy it into your own code, and adjust it
        /// as desired.
        /// </summary>
        [<Import("basicSetup", "codemirror")>]
        static member inline basicSetup: CodemirrorState.Extension = nativeOnly
        /// <summary>
        /// A minimal set of extensions to create a functional editor. Only
        /// includes [the default keymap](https://codemirror.net/6/docs/ref/#commands.defaultKeymap), [undo
        /// history](https://codemirror.net/6/docs/ref/#commands.history), [special character
        /// highlighting](https://codemirror.net/6/docs/ref/#view.highlightSpecialChars), [custom selection
        /// drawing](https://codemirror.net/6/docs/ref/#view.drawSelection), and [default highlight
        /// style](https://codemirror.net/6/docs/ref/#language.defaultHighlightStyle).
        /// </summary>
        [<Import("minimalSetup", "codemirror")>]
        static member inline minimalSetup: CodemirrorState.Extension = nativeOnly
        /// <summary>
        /// Construct a new view. You'll want to either provide a <c>parent</c>
        /// option, or put <c>view.dom</c> into your document after creating a
        /// view, so that the user can see the editor.
        /// </summary>
        [<Import("EditorView", "codemirror"); EmitConstructor>]
        static member EditorView (?config: CodemirrorView.EditorViewConfig) : EditorView = nativeOnly

    type EditorView =
        CodemirrorView.EditorView

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
        static member combineConfig (configs: ResizeArray<Exports.combineConfig__.configs>, defaults: Exports.combineConfig__.defaults, ?combine: Exports.combineConfig__.combine) : obj = nativeOnly
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
        static member inline ``of`` (text: ResizeArray<string>): CodemirrorState.Text =
            emitJsExpr (text) $$"""
import { Text } from "@codemirror/state";
Text.of($0)"""
        /// <summary>
        /// The empty document.
        /// </summary>
        static member inline empty
            with get () : CodemirrorState.Text =
                emitJsExpr () $$"""
import { Text } from "@codemirror/state";
Text.empty"""
            and set (value: CodemirrorState.Text) =
                emitJsExpr (value) $$"""
import { Text } from "@codemirror/state";
Text.empty = $0"""

    /// <summary>
    /// This type describes a line in the document. It is created
    /// on-demand when lines are [queried](https://codemirror.net/6/docs/ref/#state.Text.lineAt).
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
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
        static member inline fromJSON (json: obj): CodemirrorState.ChangeDesc =
            emitJsExpr (json) $$"""
import { ChangeDesc } from "@codemirror/state";
ChangeDesc.fromJSON($0)"""

    /// <summary>
    /// This type is used as argument to
    /// [<c>EditorState.changes</c>](https://codemirror.net/6/docs/ref/#state.EditorState.changes) and in the
    /// [<c>changes</c> field](https://codemirror.net/6/docs/ref/#state.TransactionSpec.changes) of transaction
    /// specs to succinctly describe document changes. It may either be a
    /// plain object describing a change (a deletion, insertion, or
    /// replacement, depending on which fields are present), a [change
    /// set](https://codemirror.net/6/docs/ref/#state.ChangeSet), or an array of change specs.
    /// </summary>
    type ChangeSpec =
        U3<ChangeSpec.U3.Case1, CodemirrorState.ChangeSet, ReadonlyArray<obj>>

    /// <summary>
    /// A change set represents a group of modifications to a document. It
    /// stores the document length, and can only be applied to documents
    /// with exactly that length.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
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
        static member inline ``of`` (changes: ChangeSpec.U3.Case1, length: float, ?lineSep: string): CodemirrorState.ChangeSet =
            emitJsExpr (changes, length, lineSep) $$"""
import { ChangeSet } from "@codemirror/state";
ChangeSet.of($0, $1, $2)"""
        /// <summary>
        /// Create a change set for the given changes, for a document of the
        /// given length, using <c>lineSep</c> as line separator.
        /// </summary>
        static member inline ``of`` (changes: CodemirrorState.ChangeSet, length: float, ?lineSep: string): CodemirrorState.ChangeSet =
            emitJsExpr (changes, length, lineSep) $$"""
import { ChangeSet } from "@codemirror/state";
ChangeSet.of($0, $1, $2)"""
        /// <summary>
        /// Create a change set for the given changes, for a document of the
        /// given length, using <c>lineSep</c> as line separator.
        /// </summary>
        static member inline ``of`` (changes: ResizeArray<CodemirrorState.ChangeSpec>, length: float, ?lineSep: string): CodemirrorState.ChangeSet =
            emitJsExpr (changes, length, lineSep) $$"""
import { ChangeSet } from "@codemirror/state";
ChangeSet.of($0, $1, $2)"""
        /// <summary>
        /// Create an empty changeset of the given length.
        /// </summary>
        static member inline empty (length: float): CodemirrorState.ChangeSet =
            emitJsExpr (length) $$"""
import { ChangeSet } from "@codemirror/state";
ChangeSet.empty($0)"""
        /// <summary>
        /// Create a changeset from its JSON representation (as produced by
        /// [<c>toJSON</c>](https://codemirror.net/6/docs/ref/#state.ChangeSet.toJSON).
        /// </summary>
        static member inline fromJSON (json: obj): CodemirrorState.ChangeSet =
            emitJsExpr (json) $$"""
import { ChangeSet } from "@codemirror/state";
ChangeSet.fromJSON($0)"""

    /// <summary>
    /// A single selection range. When
    /// [<c>allowMultipleSelections</c>](https://codemirror.net/6/docs/ref/#state.EditorState^allowMultipleSelections)
    /// is enabled, a [selection](https://codemirror.net/6/docs/ref/#state.EditorSelection) may hold
    /// multiple ranges. By default, selections hold exactly one range.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
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
        static member inline fromJSON (json: obj): CodemirrorState.SelectionRange =
            emitJsExpr (json) $$"""
import { SelectionRange } from "@codemirror/state";
SelectionRange.fromJSON($0)"""

    /// <summary>
    /// An editor selection holds one or more selection ranges.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
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
        static member inline fromJSON (json: obj): CodemirrorState.EditorSelection =
            emitJsExpr (json) $$"""
import { EditorSelection } from "@codemirror/state";
EditorSelection.fromJSON($0)"""
        /// <summary>
        /// Create a selection holding a single range.
        /// </summary>
        static member inline single (anchor: float, ?head: float): CodemirrorState.EditorSelection =
            emitJsExpr (anchor, head) $$"""
import { EditorSelection } from "@codemirror/state";
EditorSelection.single($0, $1)"""
        /// <summary>
        /// Sort and merge the given set of ranges, creating a valid
        /// selection.
        /// </summary>
        static member inline create (ranges: ResizeArray<CodemirrorState.SelectionRange>, ?mainIndex: float): CodemirrorState.EditorSelection =
            emitJsExpr (ranges, mainIndex) $$"""
import { EditorSelection } from "@codemirror/state";
EditorSelection.create($0, $1)"""
        /// <summary>
        /// Create a cursor selection range at the given position. You can
        /// safely ignore the optional arguments in most situations.
        /// </summary>
        static member inline cursor (pos: float, ?assoc: float, ?bidiLevel: float, ?goalColumn: float): CodemirrorState.SelectionRange =
            emitJsExpr (pos, assoc, bidiLevel, goalColumn) $$"""
import { EditorSelection } from "@codemirror/state";
EditorSelection.cursor($0, $1, $2, $3)"""
        /// <summary>
        /// Create a selection range.
        /// </summary>
        static member inline range (anchor: float, head: float, ?goalColumn: float, ?bidiLevel: float, ?assoc: float): CodemirrorState.SelectionRange =
            emitJsExpr (anchor, head, goalColumn, bidiLevel, assoc) $$"""
import { EditorSelection } from "@codemirror/state";
EditorSelection.range($0, $1, $2, $3, $4)"""
        /// <summary>
        /// Create an [undirectional](https://codemirror.net/6/docs/ref/#state.SelectionRange.undirectional)
        /// selection range.
        /// </summary>
        static member inline undirectionalRange (from: float, ``to``: float): CodemirrorState.SelectionRange =
            emitJsExpr (from, ``to``) $$"""
import { EditorSelection } from "@codemirror/state";
EditorSelection.undirectionalRange($0, $1)"""

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
    type Facet<'Input, 'Output> =
        inherit CodemirrorState.FacetReader<'Output>
        /// <summary>
        /// Returns a facet reader for this facet, which can be used to
        /// [read](https://codemirror.net/6/docs/ref/#state.EditorState.facet) it but not to define values for it.
        /// </summary>
        abstract member reader: Facet.reader<'Output> with get
        /// <summary>
        /// Define a new facet.
        /// </summary>
        static member inline define (?config: Facet.define__.config<'Output, 'Input>): CodemirrorState.Facet<'Input, 'Output> =
            emitJsExpr (config) $$"""
import { Facet } from "@codemirror/state";
Facet.define($0)"""
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
        abstract member computeN: deps: ResizeArray<CodemirrorState.Slot<obj>> * get: (CodemirrorState.EditorState -> ReadonlyArray<'Input>) -> CodemirrorState.Extension
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

    [<RequireQualifiedAccess>]
    [<Erase(CaseRules.None)>]
    type Slot<'T> =
        | doc
        | selection
        | Case1 of Slot.Cases.Case1<'T>
        | Case2 of CodemirrorState.StateField<'T>

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

    /// <summary>
    /// Fields can store additional information in an editor state, and
    /// keep it in sync with the rest of the state.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type StateField<'Value> =
        /// <summary>
        /// Define a state field.
        /// </summary>
        static member inline define (config: StateField.define__.config<'Value>): CodemirrorState.StateField<'Value> =
            emitJsExpr (config) $$"""
import { StateField } from "@codemirror/state";
StateField.define($0)"""
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

    /// <summary>
    /// Extension values can be
    /// [provided](https://codemirror.net/6/docs/ref/#state.EditorStateConfig.extensions) when creating a
    /// state to attach various kinds of configuration and behavior
    /// information. They can either be built-in extension-providing
    /// objects, such as [state fields](https://codemirror.net/6/docs/ref/#state.StateField) or [facet
    /// providers](https://codemirror.net/6/docs/ref/#state.Facet.of), or objects with an extension in its
    /// <c>extension</c> property. Extensions can be nested in arrays
    /// arbitrarily deep—they will be flattened when processed.
    /// </summary>
    type Extension =
        U2<Extension.U2.Case1, ReadonlyArray<obj>>

    /// <summary>
    /// Extension compartments can be used to make a configuration
    /// dynamic. By [wrapping](https://codemirror.net/6/docs/ref/#state.Compartment.of) part of your
    /// configuration in a compartment, you can later
    /// [replace](https://codemirror.net/6/docs/ref/#state.Compartment.reconfigure) that part through a
    /// transaction.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type Compartment =
        /// <summary>
        /// Create an instance of this compartment to add to your [state
        /// configuration](https://codemirror.net/6/docs/ref/#state.EditorStateConfig.extensions).
        /// </summary>
        abstract member ``of``: ext: Extension.U2.Case1 -> CodemirrorState.Extension
        /// <summary>
        /// Create an instance of this compartment to add to your [state
        /// configuration](https://codemirror.net/6/docs/ref/#state.EditorStateConfig.extensions).
        /// </summary>
        abstract member ``of``: ext: ResizeArray<CodemirrorState.Extension> -> CodemirrorState.Extension
        /// <summary>
        /// Create an [effect](https://codemirror.net/6/docs/ref/#state.TransactionSpec.effects) that
        /// reconfigures this compartment.
        /// </summary>
        abstract member reconfigure: content: Extension.U2.Case1 -> CodemirrorState.StateEffect<obj>
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
        static member inline define () : CodemirrorState.AnnotationType<'T> =
            emitJsExpr () $$"""
import { Annotation } from "@codemirror/state";
Annotation.define()"""

    /// <summary>
    /// Marker that identifies a type of [annotation](https://codemirror.net/6/docs/ref/#state.Annotation).
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
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

    /// <summary>
    /// Representation of a type of state effect. Defined with
    /// [<c>StateEffect.define</c>](https://codemirror.net/6/docs/ref/#state.StateEffect^define).
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
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
        static member inline define (?spec: CodemirrorState.StateEffectSpec<'Value>): CodemirrorState.StateEffectType<'Value> =
            emitJsExpr (spec) $$"""
import { StateEffect } from "@codemirror/state";
StateEffect.define($0)"""
        /// <summary>
        /// Define a new effect type. The type parameter indicates the type
        /// of values that his effect holds. It should be a type that
        /// doesn't include <c>undefined</c>, since that is used in
        /// [mapping](https://codemirror.net/6/docs/ref/#state.StateEffect.map) to indicate that an effect is
        /// removed.
        /// </summary>
        static member inline define () : CodemirrorState.StateEffectType<'Value> =
            emitJsExpr () $$"""
import { StateEffect } from "@codemirror/state";
StateEffect.define()"""
        /// <summary>
        /// Define a new effect type. The type parameter indicates the type
        /// of values that his effect holds. It should be a type that
        /// doesn't include <c>undefined</c>, since that is used in
        /// [mapping](https://codemirror.net/6/docs/ref/#state.StateEffect.map) to indicate that an effect is
        /// removed.
        /// </summary>
        static member inline define (?spec: CodemirrorState.StateEffectSpec<obj>): CodemirrorState.StateEffectType<obj> =
            emitJsExpr (spec) $$"""
import { StateEffect } from "@codemirror/state";
StateEffect.define($0)"""
        /// <summary>
        /// Map an array of effects through a change set.
        /// </summary>
        static member inline mapEffects (effects: ResizeArray<CodemirrorState.StateEffect<obj>>, mapping: CodemirrorState.ChangeDesc): ReadonlyArray<CodemirrorState.StateEffect<obj>> =
            emitJsExpr (effects, mapping) $$"""
import { StateEffect } from "@codemirror/state";
StateEffect.mapEffects($0, $1)"""
        /// <summary>
        /// This effect can be used to reconfigure the root extensions of
        /// the editor. Doing this will discard any extensions
        /// [appended](https://codemirror.net/6/docs/ref/#state.StateEffect^appendConfig), but does not reset
        /// the content of [reconfigured](https://codemirror.net/6/docs/ref/#state.Compartment.reconfigure)
        /// compartments.
        /// </summary>
        static member inline reconfigure
            with get () : CodemirrorState.StateEffectType<CodemirrorState.Extension> =
                emitJsExpr () $$"""
import { StateEffect } from "@codemirror/state";
StateEffect.reconfigure"""
            and set (value: CodemirrorState.StateEffectType<CodemirrorState.Extension>) =
                emitJsExpr (value) $$"""
import { StateEffect } from "@codemirror/state";
StateEffect.reconfigure = $0"""
        /// <summary>
        /// Append extensions to the top-level configuration of the editor.
        /// </summary>
        static member inline appendConfig
            with get () : CodemirrorState.StateEffectType<CodemirrorState.Extension> =
                emitJsExpr () $$"""
import { StateEffect } from "@codemirror/state";
StateEffect.appendConfig"""
            and set (value: CodemirrorState.StateEffectType<CodemirrorState.Extension>) =
                emitJsExpr (value) $$"""
import { StateEffect } from "@codemirror/state";
StateEffect.appendConfig = $0"""

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
        abstract member effects: U2<CodemirrorState.StateEffect<obj>, ReadonlyArray<CodemirrorState.StateEffect<obj>>> option with get, set
        /// <summary>
        /// Set [annotations](https://codemirror.net/6/docs/ref/#state.Annotation) for this transaction.
        /// </summary>
        abstract member annotations: U2<CodemirrorState.Annotation<obj>, ReadonlyArray<CodemirrorState.Annotation<obj>>> option with get, set
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
        static member inline time
            with get () : CodemirrorState.AnnotationType<float> =
                emitJsExpr () $$"""
import { Transaction } from "@codemirror/state";
Transaction.time"""
            and set (value: CodemirrorState.AnnotationType<float>) =
                emitJsExpr (value) $$"""
import { Transaction } from "@codemirror/state";
Transaction.time = $0"""
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
        static member inline userEvent
            with get () : CodemirrorState.AnnotationType<string> =
                emitJsExpr () $$"""
import { Transaction } from "@codemirror/state";
Transaction.userEvent"""
            and set (value: CodemirrorState.AnnotationType<string>) =
                emitJsExpr (value) $$"""
import { Transaction } from "@codemirror/state";
Transaction.userEvent = $0"""
        /// <summary>
        /// Annotation indicating whether a transaction should be added to
        /// the undo history or not.
        /// </summary>
        static member inline addToHistory
            with get () : CodemirrorState.AnnotationType<bool> =
                emitJsExpr () $$"""
import { Transaction } from "@codemirror/state";
Transaction.addToHistory"""
            and set (value: CodemirrorState.AnnotationType<bool>) =
                emitJsExpr (value) $$"""
import { Transaction } from "@codemirror/state";
Transaction.addToHistory = $0"""
        /// <summary>
        /// Annotation indicating (when present and true) that a transaction
        /// represents a change made by some other actor, not the user. This
        /// is used, for example, to tag other people's changes in
        /// collaborative editing.
        /// </summary>
        static member inline remote
            with get () : CodemirrorState.AnnotationType<bool> =
                emitJsExpr () $$"""
import { Transaction } from "@codemirror/state";
Transaction.remote"""
            and set (value: CodemirrorState.AnnotationType<bool>) =
                emitJsExpr (value) $$"""
import { Transaction } from "@codemirror/state";
Transaction.remote = $0"""

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
        abstract member changes: spec: ChangeSpec.U3.Case1 -> CodemirrorState.ChangeSet
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
        abstract member facet<'Output>: facet: EditorState.facet.facet<'Output> -> 'Output
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
        static member inline fromJSON (json: obj, ?config: CodemirrorState.EditorStateConfig, ?fields: EditorState.fromJSON__.fields): CodemirrorState.EditorState =
            emitJsExpr (json, config, fields) $$"""
import { EditorState } from "@codemirror/state";
EditorState.fromJSON($0, $1, $2)"""
        /// <summary>
        /// Create a new state. You'll usually only need this when
        /// initializing an editor—updated states are created by applying
        /// transactions.
        /// </summary>
        static member inline create (?config: CodemirrorState.EditorStateConfig): CodemirrorState.EditorState =
            emitJsExpr (config) $$"""
import { EditorState } from "@codemirror/state";
EditorState.create($0)"""
        /// <summary>
        /// A facet that, when enabled, causes the editor to allow multiple
        /// ranges to be selected. Be careful though, because by default the
        /// editor relies on the native DOM selection, which cannot handle
        /// multiple selections. An extension like
        /// [<c>drawSelection</c>](https://codemirror.net/6/docs/ref/#view.drawSelection) can be used to make
        /// secondary selections visible to the user.
        /// </summary>
        static member inline allowMultipleSelections
            with get () : CodemirrorState.Facet<bool, bool> =
                emitJsExpr () $$"""
import { EditorState } from "@codemirror/state";
EditorState.allowMultipleSelections"""
            and set (value: CodemirrorState.Facet<bool, bool>) =
                emitJsExpr (value) $$"""
import { EditorState } from "@codemirror/state";
EditorState.allowMultipleSelections = $0"""
        /// <summary>
        /// Configures the tab size to use in this state. The first
        /// (highest-precedence) value of the facet is used. If no value is
        /// given, this defaults to 4.
        /// </summary>
        static member inline tabSize
            with get () : CodemirrorState.Facet<float, float> =
                emitJsExpr () $$"""
import { EditorState } from "@codemirror/state";
EditorState.tabSize"""
            and set (value: CodemirrorState.Facet<float, float>) =
                emitJsExpr (value) $$"""
import { EditorState } from "@codemirror/state";
EditorState.tabSize = $0"""
        /// <summary>
        /// The line separator to use. By default, any of <c>"\n"</c>, <c>"\r\n"</c>
        /// and <c>"\r"</c> is treated as a separator when splitting lines, and
        /// lines are joined with <c>"\n"</c>.
        ///
        /// When you configure a value here, only that precise separator
        /// will be used, allowing you to round-trip documents through the
        /// editor without normalizing line separators.
        /// </summary>
        static member inline lineSeparator
            with get () : CodemirrorState.Facet<string, string option> =
                emitJsExpr () $$"""
import { EditorState } from "@codemirror/state";
EditorState.lineSeparator"""
            and set (value: CodemirrorState.Facet<string, string option>) =
                emitJsExpr (value) $$"""
import { EditorState } from "@codemirror/state";
EditorState.lineSeparator = $0"""
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
        static member inline readOnly
            with get () : CodemirrorState.Facet<bool, bool> =
                emitJsExpr () $$"""
import { EditorState } from "@codemirror/state";
EditorState.readOnly"""
            and set (value: CodemirrorState.Facet<bool, bool>) =
                emitJsExpr (value) $$"""
import { EditorState } from "@codemirror/state";
EditorState.readOnly = $0"""
        /// <summary>
        /// Registers translation phrases. The
        /// [<c>phrase</c>](https://codemirror.net/6/docs/ref/#state.EditorState.phrase) method will look through
        /// all objects registered with this facet to find translations for
        /// its argument.
        /// </summary>
        static member inline phrases
            with get () : CodemirrorState.Facet<EditorState.phrases__, ReadonlyArray<EditorState.phrases__>> =
                emitJsExpr () $$"""
import { EditorState } from "@codemirror/state";
EditorState.phrases"""
            and set (value: CodemirrorState.Facet<EditorState.phrases__, ReadonlyArray<EditorState.phrases__>>) =
                emitJsExpr (value) $$"""
import { EditorState } from "@codemirror/state";
EditorState.phrases = $0"""
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
        static member inline languageData
            with get () : CodemirrorState.Facet<EditorState.languageData__, ReadonlyArray<EditorState.languageData__>> =
                emitJsExpr () $$"""
import { EditorState } from "@codemirror/state";
EditorState.languageData"""
            and set (value: CodemirrorState.Facet<EditorState.languageData__, ReadonlyArray<EditorState.languageData__>>) =
                emitJsExpr (value) $$"""
import { EditorState } from "@codemirror/state";
EditorState.languageData = $0"""
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
        static member inline changeFilter
            with get () : CodemirrorState.Facet<(CodemirrorState.Transaction -> U2<bool, ReadonlyArray<float>>), ReadonlyArray<(CodemirrorState.Transaction -> U2<bool, ReadonlyArray<float>>)>> =
                emitJsExpr () $$"""
import { EditorState } from "@codemirror/state";
EditorState.changeFilter"""
            and set (value: CodemirrorState.Facet<(CodemirrorState.Transaction -> U2<bool, ReadonlyArray<float>>), ReadonlyArray<(CodemirrorState.Transaction -> U2<bool, ReadonlyArray<float>>)>>) =
                emitJsExpr (value) $$"""
import { EditorState } from "@codemirror/state";
EditorState.changeFilter = $0"""
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
        static member inline transactionFilter
            with get () : CodemirrorState.Facet<(CodemirrorState.Transaction -> U2<CodemirrorState.TransactionSpec, ReadonlyArray<CodemirrorState.TransactionSpec>>), ReadonlyArray<(CodemirrorState.Transaction -> U2<CodemirrorState.TransactionSpec, ReadonlyArray<CodemirrorState.TransactionSpec>>)>> =
                emitJsExpr () $$"""
import { EditorState } from "@codemirror/state";
EditorState.transactionFilter"""
            and set (value: CodemirrorState.Facet<(CodemirrorState.Transaction -> U2<CodemirrorState.TransactionSpec, ReadonlyArray<CodemirrorState.TransactionSpec>>), ReadonlyArray<(CodemirrorState.Transaction -> U2<CodemirrorState.TransactionSpec, ReadonlyArray<CodemirrorState.TransactionSpec>>)>>) =
                emitJsExpr (value) $$"""
import { EditorState } from "@codemirror/state";
EditorState.transactionFilter = $0"""
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
        static member inline transactionExtender
            with get () : CodemirrorState.Facet<(CodemirrorState.Transaction -> EditorState.transactionExtender__ option), ReadonlyArray<(CodemirrorState.Transaction -> EditorState.transactionExtender___1 option)>> =
                emitJsExpr () $$"""
import { EditorState } from "@codemirror/state";
EditorState.transactionExtender"""
            and set (value: CodemirrorState.Facet<(CodemirrorState.Transaction -> EditorState.transactionExtender__ option), ReadonlyArray<(CodemirrorState.Transaction -> EditorState.transactionExtender___1 option)>>) =
                emitJsExpr (value) $$"""
import { EditorState } from "@codemirror/state";
EditorState.transactionExtender = $0"""

    /// <summary>
    /// Subtype of [<c>Command</c>](https://codemirror.net/6/docs/ref/#view.Command) that doesn't require access
    /// to the actual editor view. Mostly useful to define commands that
    /// can be run and tested outside of a browser environment.
    /// </summary>
    type StateCommand =
        delegate of target: StateCommand.target -> bool

    /// <summary>
    /// Each range is associated with a value, which must inherit from
    /// this class.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
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
        abstract member boundChange: pos: float -> unit

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

    /// <summary>
    /// A range set stores a collection of [ranges](https://codemirror.net/6/docs/ref/#state.Range) in a
    /// way that makes them efficient to [map](https://codemirror.net/6/docs/ref/#state.RangeSet.map) and
    /// [update](https://codemirror.net/6/docs/ref/#state.RangeSet.update). This is an immutable data
    /// structure.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
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
        abstract member update<'U>: updateSpec: RangeSet.update.updateSpec<'U> -> CodemirrorState.RangeSet<'T>
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
        static member inline iter (sets: ResizeArray<CodemirrorState.RangeSet<'T>>, ?from: float): CodemirrorState.RangeCursor<'T> =
            emitJsExpr (sets, from) $$"""
import { RangeSet } from "@codemirror/state";
RangeSet.iter($0, $1)"""
        /// <summary>
        /// Iterate over two groups of sets, calling methods on <c>comparator</c>
        /// to notify it of possible differences.
        /// </summary>
        static member inline compare (oldSets: ResizeArray<CodemirrorState.RangeSet<'T>>, newSets: ResizeArray<CodemirrorState.RangeSet<'T>>, textDiff: CodemirrorState.ChangeDesc, comparator: CodemirrorState.RangeComparator<'T>, ?minPointSize: float): unit =
            emitJsExpr (oldSets, newSets, textDiff, comparator, minPointSize) $$"""
import { RangeSet } from "@codemirror/state";
RangeSet.compare($0, $1, $2, $3, $4)"""
        /// <summary>
        /// Compare the contents of two groups of range sets, returning true
        /// if they are equivalent in the given range.
        /// </summary>
        static member inline eq (oldSets: ResizeArray<CodemirrorState.RangeSet<'T>>, newSets: ResizeArray<CodemirrorState.RangeSet<'T>>, ?from: float, ?``to``: float): bool =
            emitJsExpr (oldSets, newSets, from, ``to``) $$"""
import { RangeSet } from "@codemirror/state";
RangeSet.eq($0, $1, $2, $3)"""
        /// <summary>
        /// Iterate over a group of range sets at the same time, notifying
        /// the iterator about the ranges covering every given piece of
        /// content. Returns the open count (see
        /// [<c>SpanIterator.span</c>](https://codemirror.net/6/docs/ref/#state.SpanIterator.span)) at the end
        /// of the iteration.
        /// </summary>
        static member inline spans (sets: ResizeArray<CodemirrorState.RangeSet<'T>>, from: float, ``to``: float, iterator: CodemirrorState.SpanIterator<'T>, ?minPointSize: float): float =
            emitJsExpr (sets, from, ``to``, iterator, minPointSize) $$"""
import { RangeSet } from "@codemirror/state";
RangeSet.spans($0, $1, $2, $3, $4)"""
        /// <summary>
        /// Create a range set for the given range or array of ranges. By
        /// default, this expects the ranges to be _sorted_ (by start
        /// position and, if two start at the same position,
        /// <c>value.startSide</c>). You can pass <c>true</c> as second argument to
        /// cause the method to sort them.
        /// </summary>
        static member inline ``of`` (ranges: ResizeArray<CodemirrorState.Range<'T>>, ?sort: bool): CodemirrorState.RangeSet<'T> =
            emitJsExpr (ranges, sort) $$"""
import { RangeSet } from "@codemirror/state";
RangeSet.of($0, $1)"""
        /// <summary>
        /// Create a range set for the given range or array of ranges. By
        /// default, this expects the ranges to be _sorted_ (by start
        /// position and, if two start at the same position,
        /// <c>value.startSide</c>). You can pass <c>true</c> as second argument to
        /// cause the method to sort them.
        /// </summary>
        static member inline ``of`` (ranges: CodemirrorState.Range<'T>, ?sort: bool): CodemirrorState.RangeSet<'T> =
            emitJsExpr (ranges, sort) $$"""
import { RangeSet } from "@codemirror/state";
RangeSet.of($0, $1)"""
        /// <summary>
        /// Join an array of range sets into a single set.
        /// </summary>
        static member inline join (sets: ResizeArray<CodemirrorState.RangeSet<'T>>): CodemirrorState.RangeSet<'T> =
            emitJsExpr (sets) $$"""
import { RangeSet } from "@codemirror/state";
RangeSet.join($0)"""
        /// <summary>
        /// The empty set of ranges.
        /// </summary>
        static member inline empty
            with get () : CodemirrorState.RangeSet<obj> =
                emitJsExpr () $$"""
import { RangeSet } from "@codemirror/state";
RangeSet.empty"""
            and set (value: CodemirrorState.RangeSet<obj>) =
                emitJsExpr (value) $$"""
import { RangeSet } from "@codemirror/state";
RangeSet.empty = $0"""

    /// <summary>
    /// A range set builder is a data structure that helps build up a
    /// [range set](https://codemirror.net/6/docs/ref/#state.RangeSet) directly, without first allocating
    /// an array of [<c>Range</c>](https://codemirror.net/6/docs/ref/#state.Range) objects.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
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
        [<Erase(CaseRules.None)>]
        type touchesRange =
            | cover
            | Case1 of bool

        module iterGaps =

            type f =
                delegate of posA: float * posB: float * length: float -> unit

        module iterChangedRanges =

            type f =
                delegate of fromA: float * toA: float * fromB: float * toB: float -> unit

    module ChangeSpec =

        module U3 =

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

    module Facet =

        [<AllowNullLiteral>]
        [<Interface>]
        type reader<'Output> =
            /// <summary>
            /// Dummy tag that makes sure TypeScript doesn't consider all object
            /// types as conforming to this type. Not actually present on the
            /// object.
            /// </summary>
            abstract member tag: 'Output with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (tag: 'Output) : reader<'Output> = nativeOnly

        module define__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type config<'Output, 'Input> =
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
                abstract member compare: Facet.define__.config.compare<'Output> option with get, set
                /// <summary>
                /// How to compare input values to avoid recomputing the output
                /// value when no inputs changed. Defaults to comparing with <c>===</c>.
                /// </summary>
                abstract member compareInput: Facet.define__.config.compareInput<'Input> option with get, set
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
                static member Create (?combine: (ResizeArray<'Input> -> 'Output), ?compare: Facet.define__.config.compare<'Output>, ?compareInput: Facet.define__.config.compareInput<'Input>, ?``static``: bool) : config<'Output, 'Input> = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (enables: CodemirrorState.Extension, ?combine: (ResizeArray<'Input> -> 'Output), ?compare: Facet.define__.config.compare<'Output>, ?compareInput: Facet.define__.config.compareInput<'Input>, ?``static``: bool) : config<'Output, 'Input> = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (enables: (CodemirrorState.Facet<'Input, 'Output> -> CodemirrorState.Extension), ?combine: (ResizeArray<'Input> -> 'Output), ?compare: Facet.define__.config.compare<'Output>, ?compareInput: Facet.define__.config.compareInput<'Input>, ?``static``: bool) : config<'Output, 'Input> = nativeOnly

            module config =

                type compare<'Output> =
                    delegate of a: 'Output * b: 'Output -> bool

                type compareInput<'Input> =
                    delegate of a: 'Input * b: 'Input -> bool

    module Slot =

        module Cases =

            [<AllowNullLiteral>]
            [<Interface>]
            type Case1<'T> =
                /// <summary>
                /// Dummy tag that makes sure TypeScript doesn't consider all object
                /// types as conforming to this type. Not actually present on the
                /// object.
                /// </summary>
                abstract member tag: 'T with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (tag: 'T) : Case1<'T> = nativeOnly

    module StateFieldSpec =

        type update<'Value> =
            delegate of value: 'Value * transaction: CodemirrorState.Transaction -> 'Value

        type compare<'Value> =
            delegate of a: 'Value * b: 'Value -> bool

        type toJSON<'Value> =
            delegate of value: 'Value * state: CodemirrorState.EditorState -> unit

        type fromJSON<'Value> =
            delegate of json: obj * state: CodemirrorState.EditorState -> 'Value

    module StateField =

        module define__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type config<'Value> =
                /// <summary>
                /// Creates the initial value for the field when a state is created.
                /// </summary>
                abstract member create: (CodemirrorState.EditorState -> 'Value) with get, set
                /// <summary>
                /// Compute a new value from the field's previous value and a
                /// [transaction](https://codemirror.net/6/docs/ref/#state.Transaction).
                /// </summary>
                abstract member update: StateField.define__.config.update<'Value> with get, set
                /// <summary>
                /// Compare two values of the field, returning <c>true</c> when they are
                /// the same. This is used to avoid recomputing facets that depend
                /// on the field when its value did not change. Defaults to using
                /// <c>===</c>.
                /// </summary>
                abstract member compare: StateField.define__.config.compare<'Value> option with get, set
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
                abstract member toJSON: StateField.define__.config.toJSON<'Value> option with get, set
                /// <summary>
                /// A function that deserializes the JSON representation of this
                /// field's content.
                /// </summary>
                abstract member fromJSON: StateField.define__.config.fromJSON<'Value> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (create: (CodemirrorState.EditorState -> 'Value), update: StateField.define__.config.update<'Value>, ?compare: StateField.define__.config.compare<'Value>, ?provide: (CodemirrorState.StateField<'Value> -> CodemirrorState.Extension), ?toJSON: StateField.define__.config.toJSON<'Value>, ?fromJSON: StateField.define__.config.fromJSON<'Value>) : config<'Value> = nativeOnly

            module config =

                type update<'Value> =
                    delegate of value: 'Value * transaction: CodemirrorState.Transaction -> 'Value

                type compare<'Value> =
                    delegate of a: 'Value * b: 'Value -> bool

                type toJSON<'Value> =
                    delegate of value: 'Value * state: CodemirrorState.EditorState -> unit

                type fromJSON<'Value> =
                    delegate of json: obj * state: CodemirrorState.EditorState -> 'Value

    module Extension =

        module U2 =

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
            static member Create (changes: CodemirrorState.ChangeSet, selection: CodemirrorState.EditorSelection, effects: ReadonlyArray<CodemirrorState.StateEffect<obj>>) : changeByRange = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type phrases__ =
            [<EmitIndexer>]
            abstract member Item: key: string -> string with get, set

        type languageData__ =
            delegate of state: CodemirrorState.EditorState * pos: float * side: EditorState.languageData__.side -> ReadonlyArray<EditorState.languageData__.ReturnType>

        [<AllowNullLiteral>]
        [<Interface>]
        type transactionExtender__ =
            /// <summary>
            /// Attach [state effects](https://codemirror.net/6/docs/ref/#state.StateEffect) to this transaction.
            /// Again, when they contain positions and this same spec makes
            /// changes, those positions should refer to positions in the
            /// updated document.
            /// </summary>
            abstract member effects: U2<CodemirrorState.StateEffect<obj>, ReadonlyArray<CodemirrorState.StateEffect<obj>>> option with get, set
            /// <summary>
            /// Set [annotations](https://codemirror.net/6/docs/ref/#state.Annotation) for this transaction.
            /// </summary>
            abstract member annotations: U2<CodemirrorState.Annotation<obj>, ReadonlyArray<CodemirrorState.Annotation<obj>>> option with get, set
            [<ParamObject; Emit("$0")>]
            static member Create () : transactionExtender__ = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (annotations: CodemirrorState.Annotation<obj>) : transactionExtender__ = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (annotations: ReadonlyArray<CodemirrorState.Annotation<obj>>) : transactionExtender__ = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (effects: CodemirrorState.StateEffect<obj>) : transactionExtender__ = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (effects: CodemirrorState.StateEffect<obj>, annotations: CodemirrorState.Annotation<obj>) : transactionExtender__ = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (effects: CodemirrorState.StateEffect<obj>, annotations: ReadonlyArray<CodemirrorState.Annotation<obj>>) : transactionExtender__ = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (effects: ReadonlyArray<CodemirrorState.StateEffect<obj>>) : transactionExtender__ = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (effects: ReadonlyArray<CodemirrorState.StateEffect<obj>>, annotations: CodemirrorState.Annotation<obj>) : transactionExtender__ = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (effects: ReadonlyArray<CodemirrorState.StateEffect<obj>>, annotations: ReadonlyArray<CodemirrorState.Annotation<obj>>) : transactionExtender__ = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type transactionExtender___1 =
            /// <summary>
            /// Attach [state effects](https://codemirror.net/6/docs/ref/#state.StateEffect) to this transaction.
            /// Again, when they contain positions and this same spec makes
            /// changes, those positions should refer to positions in the
            /// updated document.
            /// </summary>
            abstract member effects: U2<CodemirrorState.StateEffect<obj>, ReadonlyArray<CodemirrorState.StateEffect<obj>>> option with get, set
            /// <summary>
            /// Set [annotations](https://codemirror.net/6/docs/ref/#state.Annotation) for this transaction.
            /// </summary>
            abstract member annotations: U2<CodemirrorState.Annotation<obj>, ReadonlyArray<CodemirrorState.Annotation<obj>>> option with get, set
            [<ParamObject; Emit("$0")>]
            static member Create () : transactionExtender___1 = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (annotations: CodemirrorState.Annotation<obj>) : transactionExtender___1 = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (annotations: ReadonlyArray<CodemirrorState.Annotation<obj>>) : transactionExtender___1 = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (effects: CodemirrorState.StateEffect<obj>) : transactionExtender___1 = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (effects: CodemirrorState.StateEffect<obj>, annotations: CodemirrorState.Annotation<obj>) : transactionExtender___1 = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (effects: CodemirrorState.StateEffect<obj>, annotations: ReadonlyArray<CodemirrorState.Annotation<obj>>) : transactionExtender___1 = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (effects: ReadonlyArray<CodemirrorState.StateEffect<obj>>) : transactionExtender___1 = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (effects: ReadonlyArray<CodemirrorState.StateEffect<obj>>, annotations: CodemirrorState.Annotation<obj>) : transactionExtender___1 = nativeOnly
            [<ParamObject; Emit("$0")>]
            static member Create (effects: ReadonlyArray<CodemirrorState.StateEffect<obj>>, annotations: ReadonlyArray<CodemirrorState.Annotation<obj>>) : transactionExtender___1 = nativeOnly

        module changeByRange =

            [<AllowNullLiteral>]
            [<Interface>]
            type f =
                abstract member range: CodemirrorState.SelectionRange with get, set
                abstract member changes: CodemirrorState.ChangeSpec option with get, set
                abstract member effects: U2<CodemirrorState.StateEffect<obj>, ReadonlyArray<CodemirrorState.StateEffect<obj>>> option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (range: CodemirrorState.SelectionRange, ?changes: CodemirrorState.ChangeSpec) : f = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (range: CodemirrorState.SelectionRange, effects: CodemirrorState.StateEffect<obj>, ?changes: CodemirrorState.ChangeSpec) : f = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (range: CodemirrorState.SelectionRange, effects: ReadonlyArray<CodemirrorState.StateEffect<obj>>, ?changes: CodemirrorState.ChangeSpec) : f = nativeOnly

        module facet =

            [<AllowNullLiteral>]
            [<Interface>]
            type facet<'Output> =
                /// <summary>
                /// Dummy tag that makes sure TypeScript doesn't consider all object
                /// types as conforming to this type. Not actually present on the
                /// object.
                /// </summary>
                abstract member tag: 'Output with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (tag: 'Output) : facet<'Output> = nativeOnly

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

        module languageData__ =

            [<RequireQualifiedAccess>]
            type side =
                | _MINUS_1 = -1
                | ``0`` = 0
                | ``1`` = 1

            [<AllowNullLiteral>]
            [<Interface>]
            type ReturnType =
                [<EmitIndexer>]
                abstract member Item: name: string -> obj with get, set

        module languageDataAt =

            [<RequireQualifiedAccess>]
            type side =
                | _MINUS_1 = -1
                | ``0`` = 0
                | ``1`` = 1

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

        module update =

            [<AllowNullLiteral>]
            [<Interface>]
            type updateSpec<'U> =
                /// <summary>
                /// An array of ranges to add. If given, this should be sorted by
                /// <c>from</c> position and <c>startSide</c> unless
                /// [<c>sort</c>](https://codemirror.net/6/docs/ref/#state.RangeSet.update^updateSpec.sort) is given as
                /// <c>true</c>.
                /// </summary>
                abstract member add: ReadonlyArray<CodemirrorState.Range<'U>> option with get, set
                /// <summary>
                /// Indicates whether the library should sort the ranges in <c>add</c>.
                /// Defaults to <c>false</c>.
                /// </summary>
                abstract member sort: bool option with get, set
                /// <summary>
                /// Filter the ranges already in the set. Only those for which this
                /// function returns <c>true</c> are kept.
                /// </summary>
                abstract member filter: RangeSet.update.updateSpec.filter<'U> option with get, set
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
                static member Create (?add: ReadonlyArray<CodemirrorState.Range<'U>>, ?sort: bool, ?filter: RangeSet.update.updateSpec.filter<'U>, ?filterFrom: float, ?filterTo: float) : updateSpec<'U> = nativeOnly

            module updateSpec =

                type filter<'U> =
                    delegate of from: float * ``to``: float * value: 'U -> bool

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
            type configs =
                interface end

            [<AllowNullLiteral>]
            [<Interface>]
            type defaults =
                interface end

            [<AllowNullLiteral>]
            [<Interface>]
            type combine =
                [<EmitIndexer>]
                abstract member Item: key: string -> Exports.combineConfig__.combine.Item with get, set

            module combine =

                type Item =
                    delegate of first: obj * second: obj -> obj

module CodemirrorView =

    [<AbstractClass>]
    [<Erase>]
    type Exports =
        /// <summary>
        /// Log or report an unhandled exception in client code. Should
        /// probably only be used by extension code that allows client code to
        /// provide functions, and calls those functions in a context where an
        /// exception can't be propagated to calling code in a reasonable way
        /// (for example when in an event handler).
        ///
        /// Either calls a handler registered with
        /// [<c>EditorView.exceptionSink</c>](https://codemirror.net/6/docs/ref/#view.EditorView^exceptionSink),
        /// <c>window.onerror</c>, if defined, or <c>console.error</c> (in which case
        /// it'll pass <c>context</c>, when given, as first argument).
        /// </summary>
        [<Import("logException", "@codemirror/view")>]
        static member logException (state: CodemirrorState.EditorState, ``exception``: obj, ?context: string) : unit = nativeOnly
        /// <summary>
        /// Facet used for registering keymaps.
        ///
        /// You can add multiple keymaps to an editor. Their priorities
        /// determine their precedence (the ones specified early or with high
        /// priority get checked first). When a handler has returned <c>true</c>
        /// for a given key, no further handlers are called.
        /// </summary>
        [<Import("keymap", "@codemirror/view")>]
        static member inline keymap: CodemirrorState.Facet<ReadonlyArray<CodemirrorView.KeyBinding>, ReadonlyArray<ReadonlyArray<CodemirrorView.KeyBinding>>> = nativeOnly
        /// <summary>
        /// Run the key handlers registered for a given scope. The event
        /// object should be a <c>"keydown"</c> event. Returns true if any of the
        /// handlers handled it.
        /// </summary>
        [<Import("runScopeHandlers", "@codemirror/view")>]
        static member runScopeHandlers (view: CodemirrorView.EditorView, event: Glutinum.Web.KeyboardEvent, scope: string) : bool = nativeOnly
        /// <summary>
        /// Returns an extension that hides the browser's native selection and
        /// cursor, replacing the selection with a background behind the text
        /// (with the <c>cm-selectionBackground</c> class), and the
        /// cursors with elements overlaid over the code (using
        /// <c>cm-cursor-primary</c> and <c>cm-cursor-secondary</c>).
        ///
        /// This allows the editor to display secondary selection ranges, and
        /// tends to produce a type of selection more in line with that users
        /// expect in a text editor (the native selection styling will often
        /// leave gaps between lines and won't fill the horizontal space after
        /// a line when the selection continues past it).
        ///
        /// It does have a performance cost, in that it requires an extra DOM
        /// layout cycle for many updates (the selection is drawn based on DOM
        /// layout information that's only available after laying out the
        /// content).
        /// </summary>
        [<Import("drawSelection", "@codemirror/view")>]
        static member drawSelection (?config: CodemirrorView.SelectionConfig) : CodemirrorState.Extension = nativeOnly
        /// <summary>
        /// Retrieve the [<c>drawSelection</c>](https://codemirror.net/6/docs/ref/#view.drawSelection) configuration
        /// for this state. (Note that this will return a set of defaults even
        /// if <c>drawSelection</c> isn't enabled.)
        /// </summary>
        [<Import("getDrawSelectionConfig", "@codemirror/view")>]
        static member getDrawSelectionConfig (state: CodemirrorState.EditorState) : CodemirrorView.SelectionConfig = nativeOnly
        /// <summary>
        /// Draws a cursor at the current drop position when something is
        /// dragged over the editor.
        /// </summary>
        [<Import("dropCursor", "@codemirror/view")>]
        static member dropCursor () : CodemirrorState.Extension = nativeOnly
        /// <summary>
        /// Returns an extension that installs highlighting of special
        /// characters.
        /// </summary>
        [<Import("highlightSpecialChars", "@codemirror/view")>]
        static member highlightSpecialChars (?config: CodemirrorView.SpecialCharConfig) : CodemirrorState.Extension = nativeOnly
        /// <summary>
        /// Returns an extension that makes sure the content has a bottom
        /// margin equivalent to the height of the editor, minus one line
        /// height, so that every line in the document can be scrolled to the
        /// top of the editor.
        ///
        /// This is only meaningful when the editor is scrollable, and should
        /// not be enabled in editors that take the size of their content.
        /// </summary>
        [<Import("scrollPastEnd", "@codemirror/view")>]
        static member scrollPastEnd () : CodemirrorState.Extension = nativeOnly
        /// <summary>
        /// Mark lines that have a cursor on them with the <c>"cm-activeLine"</c>
        /// DOM class.
        /// </summary>
        [<Import("highlightActiveLine", "@codemirror/view")>]
        static member highlightActiveLine () : CodemirrorState.Extension = nativeOnly
        /// <summary>
        /// Extension that enables a placeholder—a piece of example content
        /// to show when the editor is empty.
        /// </summary>
        [<Import("placeholder", "@codemirror/view")>]
        static member placeholder (content: string) : CodemirrorState.Extension = nativeOnly
        /// <summary>
        /// Extension that enables a placeholder—a piece of example content
        /// to show when the editor is empty.
        /// </summary>
        [<Import("placeholder", "@codemirror/view")>]
        static member placeholder (content: Glutinum.Web.HTMLElement) : CodemirrorState.Extension = nativeOnly
        /// <summary>
        /// Extension that enables a placeholder—a piece of example content
        /// to show when the editor is empty.
        /// </summary>
        [<Import("placeholder", "@codemirror/view")>]
        static member placeholder (content: (CodemirrorView.EditorView -> Glutinum.Web.HTMLElement)) : CodemirrorState.Extension = nativeOnly
        /// <summary>
        /// Define a layer.
        /// </summary>
        [<Import("layer", "@codemirror/view")>]
        static member layer (config: CodemirrorView.LayerConfig) : CodemirrorState.Extension = nativeOnly
        /// <summary>
        /// Create an extension that enables rectangular selections. By
        /// default, it will react to left mouse drag with the Alt key held
        /// down. When such a selection occurs, the text within the rectangle
        /// that was dragged over will be selected, as one selection
        /// [range](https://codemirror.net/6/docs/ref/#state.SelectionRange) per line.
        /// </summary>
        [<Import("rectangularSelection", "@codemirror/view")>]
        static member rectangularSelection (?options: Exports.rectangularSelection__.options) : CodemirrorState.Extension = nativeOnly
        /// <summary>
        /// Returns an extension that turns the pointer cursor into a
        /// crosshair when a given modifier key, defaulting to Alt, is held
        /// down. Can serve as a visual hint that rectangular selection is
        /// going to happen when paired with
        /// [<c>rectangularSelection</c>](https://codemirror.net/6/docs/ref/#view.rectangularSelection).
        /// </summary>
        [<Import("crosshairCursor", "@codemirror/view")>]
        static member crosshairCursor (?options: Exports.crosshairCursor__.options) : CodemirrorState.Extension = nativeOnly
        /// <summary>
        /// Creates an extension that configures tooltip behavior.
        /// </summary>
        [<Import("tooltips", "@codemirror/view")>]
        static member tooltips (?config: Exports.tooltips__.config) : CodemirrorState.Extension = nativeOnly
        /// <summary>
        /// Facet to which an extension can add a value to show a tooltip.
        /// </summary>
        [<Import("showTooltip", "@codemirror/view")>]
        static member inline showTooltip: CodemirrorState.Facet<CodemirrorView.Tooltip option, ReadonlyArray<CodemirrorView.Tooltip option>> = nativeOnly
        /// <summary>
        /// Set up a hover tooltip, which shows up when the pointer hovers
        /// over ranges of text. The callback is called when the mouse hovers
        /// over the document text. It should, if there is a tooltip
        /// associated with position <c>pos</c>, return the tooltip description
        /// (either directly or in a promise). The <c>side</c> argument indicates
        /// on which side of the position the pointer is—it will be -1 if the
        /// pointer is before the position, 1 if after the position.
        ///
        /// Note that all hover tooltips are hosted within a single tooltip
        /// container element. This allows multiple tooltips over the same
        /// range to be "merged" together without overlapping.
        ///
        /// The return value is a valid [editor extension](https://codemirror.net/6/docs/ref/#state.Extension)
        /// but also provides an <c>active</c> property holding a state field that
        /// can be used to read the currently active tooltips produced by this
        /// extension.
        /// </summary>
        [<Import("hoverTooltip", "@codemirror/view")>]
        static member hoverTooltip (source: CodemirrorView.HoverTooltipSource, ?options: Exports.hoverTooltip__.options) : obj = nativeOnly
        /// <summary>
        /// Activate hover tooltips for the given position and side. If you
        /// provide a specific hover tooltip (the value returned from
        /// [<c>hoverTooltip</c>](https://codemirror.net/6/docs/ref/#view.hoverTooltip)), only that one will be
        /// activated. If not given, all hover tooltips at the given position
        /// are triggered.
        ///
        /// Note that tooltips opened this way don't close automatically, and
        /// you'll want to pass an <c>until</c> callback or use
        /// [<c>closeHoverTooltip</c>](https://codemirror.net/6/docs/ref/#view.closeHoverTooltip)/[<c>closeHoverTooltips</c>](https://codemirror.net/6/docs/ref/#view.closeHoverTooltips)
        /// to deactivate them.
        /// </summary>
        [<Import("activateHover", "@codemirror/view")>]
        static member activateHover (view: CodemirrorView.EditorView, pos: float, side: Exports.activateHover__.side, ?options: Exports.activateHover__.options) : unit = nativeOnly
        /// <summary>
        /// Get the active tooltip view for a given tooltip, if available.
        /// </summary>
        [<Import("getTooltip", "@codemirror/view")>]
        static member getTooltip (view: CodemirrorView.EditorView, tooltip: CodemirrorView.Tooltip) : CodemirrorView.TooltipView option = nativeOnly
        /// <summary>
        /// Returns true if any hover tooltips are currently active.
        /// </summary>
        [<Import("hasHoverTooltips", "@codemirror/view")>]
        static member hasHoverTooltips (state: CodemirrorState.EditorState) : bool = nativeOnly
        /// <summary>
        /// Transaction effect that closes all hover tooltips.
        /// </summary>
        [<Import("closeHoverTooltips", "@codemirror/view")>]
        static member inline closeHoverTooltips: CodemirrorState.StateEffect<obj> = nativeOnly
        /// <summary>
        /// Transaction effect that closes a specific hover tooltip.
        /// </summary>
        [<Import("closeHoverTooltip", "@codemirror/view")>]
        static member closeHoverTooltip (tooltip: obj) : CodemirrorState.StateEffect<obj> = nativeOnly
        /// <summary>
        /// Tell the tooltip extension to recompute the position of the active
        /// tooltips. This can be useful when something happens (such as a
        /// re-positioning or CSS change affecting the editor) that could
        /// invalidate the existing tooltip positions.
        /// </summary>
        [<Import("repositionTooltips", "@codemirror/view")>]
        static member repositionTooltips (view: CodemirrorView.EditorView) : unit = nativeOnly
        /// <summary>
        /// Configures the panel-managing extension.
        /// </summary>
        [<Import("panels", "@codemirror/view")>]
        static member panels (?config: CodemirrorView.PanelConfig) : CodemirrorState.Extension = nativeOnly
        /// <summary>
        /// Get the active panel created by the given constructor, if any.
        /// This can be useful when you need access to your panels' DOM
        /// structure.
        /// </summary>
        [<Import("getPanel", "@codemirror/view")>]
        static member getPanel (view: CodemirrorView.EditorView, panel: CodemirrorView.PanelConstructor) : CodemirrorView.Panel option = nativeOnly
        /// <summary>
        /// Opening a panel is done by providing a constructor function for
        /// the panel through this facet. (The panel is closed again when its
        /// constructor is no longer provided.) Values of <c>null</c> are ignored.
        /// </summary>
        [<Import("showPanel", "@codemirror/view")>]
        static member inline showPanel: CodemirrorState.Facet<CodemirrorView.PanelConstructor option, ReadonlyArray<CodemirrorView.PanelConstructor option>> = nativeOnly
        /// <summary>
        /// Show a panel above or below the editor to show the user a message
        /// or prompt them for input. Returns an effect that can be dispatched
        /// to close the dialog, and a promise that resolves when the dialog
        /// is closed or a form inside of it is submitted.
        ///
        /// You are encouraged, if your handling of the result of the promise
        /// dispatches a transaction, to include the <c>close</c> effect in it. If
        /// you don't, this function will automatically dispatch a separate
        /// transaction right after.
        /// </summary>
        [<Import("showDialog", "@codemirror/view")>]
        static member showDialog (view: CodemirrorView.EditorView, config: CodemirrorView.DialogConfig) : Exports.showDialog__ = nativeOnly
        /// <summary>
        /// Find the [<c>Panel</c>](https://codemirror.net/6/docs/ref/#view.Panel) for an open dialog, using a class
        /// name as identifier.
        /// </summary>
        [<Import("getDialog", "@codemirror/view")>]
        static member getDialog (view: CodemirrorView.EditorView, className: string) : CodemirrorView.Panel option = nativeOnly
        /// <summary>
        /// Facet used to add a class to all gutter elements for a given line.
        /// Markers given to this facet should _only_ define an
        /// [<c>elementclass</c>](https://codemirror.net/6/docs/ref/#view.GutterMarker.elementClass), not a
        /// [<c>toDOM</c>](https://codemirror.net/6/docs/ref/#view.GutterMarker.toDOM) (or the marker will appear
        /// in all gutters for the line).
        /// </summary>
        [<Import("gutterLineClass", "@codemirror/view")>]
        static member inline gutterLineClass: CodemirrorState.Facet<CodemirrorState.RangeSet<CodemirrorView.GutterMarker>, ReadonlyArray<CodemirrorState.RangeSet<CodemirrorView.GutterMarker>>> = nativeOnly
        /// <summary>
        /// Facet used to add a class to all gutter elements next to a widget.
        /// Should not provide widgets with a <c>toDOM</c> method.
        /// </summary>
        [<Import("gutterWidgetClass", "@codemirror/view")>]
        static member inline gutterWidgetClass: CodemirrorState.Facet<Exports.gutterWidgetClass__.Type, ReadonlyArray<Exports.gutterWidgetClass__.Type>> = nativeOnly
        /// <summary>
        /// Define an editor gutter. The order in which the gutters appear is
        /// determined by their extension priority.
        /// </summary>
        [<Import("gutter", "@codemirror/view")>]
        static member gutter (config: CodemirrorView.GutterConfig) : CodemirrorState.Extension = nativeOnly
        /// <summary>
        /// The gutter-drawing plugin is automatically enabled when you add a
        /// gutter, but you can use this function to explicitly configure it.
        ///
        /// Unless <c>fixed</c> is explicitly set to <c>false</c>, the gutters are
        /// fixed, meaning they don't scroll along with the content
        /// horizontally (except on Internet Explorer, which doesn't support
        /// CSS [<c>position:
        /// sticky</c>](https://developer.mozilla.org/en-US/docs/Web/CSS/position#sticky)).
        /// </summary>
        [<Import("gutters", "@codemirror/view")>]
        static member gutters (?config: Exports.gutters__.config) : CodemirrorState.Extension = nativeOnly
        /// <summary>
        /// Facet used to provide markers to the line number gutter.
        /// </summary>
        [<Import("lineNumberMarkers", "@codemirror/view")>]
        static member inline lineNumberMarkers: CodemirrorState.Facet<CodemirrorState.RangeSet<CodemirrorView.GutterMarker>, ReadonlyArray<CodemirrorState.RangeSet<CodemirrorView.GutterMarker>>> = nativeOnly
        /// <summary>
        /// Facet used to create markers in the line number gutter next to widgets.
        /// </summary>
        [<Import("lineNumberWidgetMarker", "@codemirror/view")>]
        static member inline lineNumberWidgetMarker: CodemirrorState.Facet<Exports.lineNumberWidgetMarker__.Type, ReadonlyArray<Exports.lineNumberWidgetMarker__.Type>> = nativeOnly
        /// <summary>
        /// Create a line number gutter extension.
        /// </summary>
        [<Import("lineNumbers", "@codemirror/view")>]
        static member lineNumbers (?config: CodemirrorView.LineNumberConfig) : CodemirrorState.Extension = nativeOnly
        /// <summary>
        /// Returns an extension that adds a <c>cm-activeLineGutter</c> class to
        /// all gutter elements on the [active
        /// line](https://codemirror.net/6/docs/ref/#view.highlightActiveLine).
        /// </summary>
        [<Import("highlightActiveLineGutter", "@codemirror/view")>]
        static member highlightActiveLineGutter () : CodemirrorState.Extension = nativeOnly
        /// <summary>
        /// Returns an extension that highlights whitespace, adding a
        /// <c>cm-highlightSpace</c> class to stretches of spaces, and a
        /// <c>cm-highlightTab</c> class to individual tab characters. By default,
        /// the former are shown as faint dots, and the latter as arrows.
        /// </summary>
        [<Import("highlightWhitespace", "@codemirror/view")>]
        static member highlightWhitespace () : CodemirrorState.Extension = nativeOnly
        /// <summary>
        /// Returns an extension that adds a <c>cm-trailingSpace</c> class to all
        /// trailing whitespace.
        /// </summary>
        [<Import("highlightTrailingWhitespace", "@codemirror/view")>]
        static member highlightTrailingWhitespace () : CodemirrorState.Extension = nativeOnly
        [<Import("BidiSpan", "@codemirror/view"); EmitConstructor>]
        static member BidiSpan () : BidiSpan = nativeOnly
        [<Import("WidgetType", "@codemirror/view"); EmitConstructor>]
        static member WidgetType () : WidgetType = nativeOnly
        [<Import("Decoration", "@codemirror/view"); EmitConstructor>]
        static member Decoration (startSide: float, endSide: float, widget: CodemirrorView.WidgetType option, spec: obj) : Decoration = nativeOnly
        [<Import("BlockWrapper", "@codemirror/view"); EmitConstructor>]
        static member BlockWrapper () : BlockWrapper = nativeOnly
        [<Import("ViewPlugin", "@codemirror/view"); EmitConstructor>]
        static member ViewPlugin<'V, 'Arg> () : ViewPlugin<'V, 'Arg> = nativeOnly
        [<Import("ViewUpdate", "@codemirror/view"); EmitConstructor>]
        static member ViewUpdate () : ViewUpdate = nativeOnly
        [<Import("BlockInfo", "@codemirror/view"); EmitConstructor>]
        static member BlockInfo () : BlockInfo = nativeOnly
        /// <summary>
        /// Construct a new view. You'll want to either provide a <c>parent</c>
        /// option, or put <c>view.dom</c> into your document after creating a
        /// view, so that the user can see the editor.
        /// </summary>
        [<Import("EditorView", "@codemirror/view"); EmitConstructor>]
        static member EditorView (?config: CodemirrorView.EditorViewConfig) : EditorView = nativeOnly
        /// <summary>
        /// Create a marker with the given class and dimensions. If <c>width</c>
        /// is null, the DOM element will get no width style.
        /// </summary>
        [<Import("RectangleMarker", "@codemirror/view"); EmitConstructor>]
        static member RectangleMarker (className: string, left: float, top: float, width: float option, height: float) : RectangleMarker = nativeOnly
        /// <summary>
        /// Create a decorator.
        /// </summary>
        [<Import("MatchDecorator", "@codemirror/view"); EmitConstructor>]
        static member MatchDecorator (config: Exports.MatchDecorator.config) : MatchDecorator = nativeOnly
        [<Import("GutterMarker", "@codemirror/view"); EmitConstructor>]
        static member GutterMarker () : GutterMarker = nativeOnly

    [<RequireQualifiedAccess>]
    type Direction =
        | LTR = 0
        | RTL = 1

    /// <summary>
    /// Represents a contiguous range of text that has a single direction
    /// (as in left-to-right or right-to-left).
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type BidiSpan =
        /// <summary>
        /// The start of the span (relative to the start of the line).
        /// </summary>
        abstract member from: float with get
        /// <summary>
        /// The end of the span.
        /// </summary>
        abstract member ``to``: float with get
        /// <summary>
        /// The ["bidi
        /// level"](https://unicode.org/reports/tr9/#Basic_Display_Algorithm)
        /// of the span (in this context, 0 means
        /// left-to-right, 1 means right-to-left, 2 means left-to-right
        /// number inside right-to-left text).
        /// </summary>
        abstract member level: float with get
        /// <summary>
        /// The direction of this span.
        /// </summary>
        abstract member dir: CodemirrorView.Direction with get

    [<AllowNullLiteral>]
    [<Interface>]
    type Attrs =
        [<EmitIndexer>]
        abstract member Item: name: string -> string with get, set

    /// <summary>
    /// Basic rectangle type.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type Rect =
        abstract member left: float with get
        abstract member right: float with get
        abstract member top: float with get
        abstract member bottom: float with get

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type ScrollStrategy =
        | nearest
        | start
        | ``end``
        | center

    [<AllowNullLiteral>]
    [<Interface>]
    type MarkDecorationSpec =
        /// <summary>
        /// Whether the mark covers its start and end position or not. This
        /// influences whether content inserted at those positions becomes
        /// part of the mark. Defaults to false.
        /// </summary>
        abstract member inclusive: bool option with get, set
        /// <summary>
        /// Specify whether the start position of the marked range should be
        /// inclusive. Overrides <c>inclusive</c>, when both are present.
        /// </summary>
        abstract member inclusiveStart: bool option with get, set
        /// <summary>
        /// Whether the end should be inclusive.
        /// </summary>
        abstract member inclusiveEnd: bool option with get, set
        /// <summary>
        /// Add attributes to the DOM elements that hold the text in the
        /// marked range.
        /// </summary>
        abstract member attributes: MarkDecorationSpec.attributes option with get, set
        /// <summary>
        /// Shorthand for <c>{attributes: {class: value}}</c>.
        /// </summary>
        abstract member ``class``: string option with get, set
        /// <summary>
        /// Add a wrapping element around the text in the marked range. Note
        /// that there will not necessarily be a single element covering the
        /// entire range—other decorations with lower precedence might split
        /// this one if they partially overlap it, and line breaks always
        /// end decoration elements.
        /// </summary>
        abstract member tagName: string option with get, set
        /// <summary>
        /// When using sets of decorations in
        /// [<c>bidiIsolatedRanges</c>](https://codemirror.net/6/docs/ref/##view.EditorView^bidiIsolatedRanges),
        /// this property provides the direction of the isolates. When null
        /// or not given, it indicates the range has <c>dir=auto</c>, and its
        /// direction should be derived from the first strong directional
        /// character in it.
        /// </summary>
        abstract member bidiIsolate: CodemirrorView.Direction option with get, set
        [<EmitIndexer>]
        abstract member Item: other: string -> obj with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type WidgetDecorationSpec =
        /// <summary>
        /// The type of widget to draw here.
        /// </summary>
        abstract member widget: CodemirrorView.WidgetType with get, set
        /// <summary>
        /// Which side of the given position the widget is on. When this is
        /// positive, the widget will be drawn after the cursor if the
        /// cursor is on the same position. Otherwise, it'll be drawn before
        /// it. When multiple widgets sit at the same position, their <c>side</c>
        /// values will determine their ordering—those with a lower value
        /// come first. Defaults to 0. May not be more than 10000 or less
        /// than -10000.
        /// </summary>
        abstract member side: float option with get, set
        /// <summary>
        /// By default, to avoid unintended mixing of block and inline
        /// widgets, block widgets with a positive <c>side</c> are always drawn
        /// after all inline widgets at that position, and those with a
        /// non-positive side before inline widgets. Setting this option to
        /// <c>true</c> for a block widget will turn this off and cause it to be
        /// rendered between the inline widgets, ordered by <c>side</c>.
        /// </summary>
        abstract member inlineOrder: bool option with get, set
        /// <summary>
        /// Determines whether this is a block widgets, which will be drawn
        /// between lines, or an inline widget (the default) which is drawn
        /// between the surrounding text.
        ///
        /// Note that block-level decorations should not have vertical
        /// margins, and if you dynamically change their height, you should
        /// make sure to call
        /// [<c>requestMeasure</c>](https://codemirror.net/6/docs/ref/#view.EditorView.requestMeasure), so that the
        /// editor can update its information about its vertical layout.
        /// </summary>
        abstract member block: bool option with get, set
        [<EmitIndexer>]
        abstract member Item: other: string -> obj with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type ReplaceDecorationSpec =
        /// <summary>
        /// An optional widget to drawn in the place of the replaced
        /// content.
        /// </summary>
        abstract member widget: CodemirrorView.WidgetType option with get, set
        /// <summary>
        /// Whether this range covers the positions on its sides. This
        /// influences whether new content becomes part of the range and
        /// whether the cursor can be drawn on its sides. Defaults to false
        /// for inline replacements, and true for block replacements.
        /// </summary>
        abstract member inclusive: bool option with get, set
        /// <summary>
        /// Set inclusivity at the start.
        /// </summary>
        abstract member inclusiveStart: bool option with get, set
        /// <summary>
        /// Set inclusivity at the end.
        /// </summary>
        abstract member inclusiveEnd: bool option with get, set
        /// <summary>
        /// Whether this is a block-level decoration. Defaults to false.
        /// </summary>
        abstract member block: bool option with get, set
        [<EmitIndexer>]
        abstract member Item: other: string -> obj with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type LineDecorationSpec =
        /// <summary>
        /// DOM attributes to add to the element wrapping the line.
        /// </summary>
        abstract member attributes: LineDecorationSpec.attributes option with get, set
        /// <summary>
        /// Shorthand for <c>{attributes: {class: value}}</c>.
        /// </summary>
        abstract member ``class``: string option with get, set
        [<EmitIndexer>]
        abstract member Item: other: string -> obj with get, set

    /// <summary>
    /// Widgets added to the content are described by subclasses of this
    /// class. Using a description object like that makes it possible to
    /// delay creating of the DOM structure for a widget until it is
    /// needed, and to avoid redrawing widgets even if the decorations
    /// that define them are recreated.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type WidgetType =
        /// <summary>
        /// Build the DOM structure for this widget instance.
        /// </summary>
        abstract member toDOM: view: CodemirrorView.EditorView -> Glutinum.Web.HTMLElement
        /// <summary>
        /// Compare this instance to another instance of the same type.
        /// (TypeScript can't express this, but only instances of the same
        /// specific class will be passed to this method.) This is used to
        /// avoid redrawing widgets when they are replaced by a new
        /// decoration of the same type. The default implementation just
        /// returns <c>false</c>, which will cause new instances of the widget to
        /// always be redrawn.
        /// </summary>
        abstract member eq: widget: CodemirrorView.WidgetType -> bool
        /// <summary>
        /// Update a DOM element created by a widget of the same type (but
        /// different, non-<c>eq</c> content) to reflect this widget. May return
        /// true to indicate that it could update, false to indicate it
        /// couldn't (in which case the widget will be redrawn). The default
        /// implementation just returns false.
        /// </summary>
        abstract member updateDOM: dom: Glutinum.Web.HTMLElement * view: CodemirrorView.EditorView * from: WidgetType -> bool
        /// <summary>
        /// The estimated height this widget will have, to be used when
        /// estimating the height of content that hasn't been drawn. May
        /// return -1 to indicate you don't know. The default implementation
        /// returns -1.
        /// </summary>
        abstract member estimatedHeight: float with get
        /// <summary>
        /// For inline widgets that are displayed inline (as opposed to
        /// <c>inline-block</c>) and introduce line breaks (through <c><br></c> tags
        /// or textual newlines), this must indicate the amount of line
        /// breaks they introduce. Defaults to 0.
        /// </summary>
        abstract member lineBreaks: float with get
        /// <summary>
        /// Can be used to configure which kinds of events inside the widget
        /// should be ignored by the editor. The default is to ignore all
        /// events.
        /// </summary>
        abstract member ignoreEvent: event: Glutinum.Web.Event -> bool
        /// <summary>
        /// Override the way screen coordinates for positions at/in the
        /// widget are found. <c>pos</c> will be the offset into the widget, and
        /// <c>side</c> the side of the position that is being queried—less than
        /// zero for before, greater than zero for after, and zero for
        /// directly at that position.
        /// </summary>
        abstract member coordsAt: dom: Glutinum.Web.HTMLElement * pos: float * side: float -> CodemirrorView.Rect option
        /// <summary>
        /// This is called when the an instance of the widget is removed
        /// from the editor view.
        /// </summary>
        abstract member destroy: dom: Glutinum.Web.HTMLElement -> unit

    /// <summary>
    /// A decoration set represents a collection of decorated ranges,
    /// organized for efficient access and mapping. See
    /// [<c>RangeSet</c>](https://codemirror.net/6/docs/ref/#state.RangeSet) for its methods.
    /// </summary>
    type DecorationSet =
        CodemirrorState.RangeSet<CodemirrorView.Decoration>

    [<RequireQualifiedAccess>]
    type BlockType =
        | Text = 0
        | WidgetBefore = 1
        | WidgetAfter = 2
        | WidgetRange = 3

    /// <summary>
    /// A decoration provides information on how to draw or style a piece
    /// of content. You'll usually use it wrapped in a
    /// [<c>Range</c>](https://codemirror.net/6/docs/ref/#state.Range), which adds a start and end position.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type Decoration =
        inherit CodemirrorState.RangeValue
        /// <summary>
        /// The config object used to create this decoration. You can
        /// include additional properties in there to store metadata about
        /// your decoration.
        /// </summary>
        abstract member spec: obj with get
        /// <summary>
        /// Compare this value with another value. Used when comparing
        /// rangesets. The default implementation compares by identity.
        /// Unless you are only creating a fixed number of unique instances
        /// of your value type, it is a good idea to implement this
        /// properly.
        /// </summary>
        abstract member eq: other: CodemirrorView.Decoration -> bool
        /// <summary>
        /// Create a mark decoration, which influences the styling of the
        /// content in its range. Nested mark decorations will cause nested
        /// DOM elements to be created. Nesting order is determined by
        /// precedence of the [facet](https://codemirror.net/6/docs/ref/#view.EditorView^decorations), with
        /// the higher-precedence decorations creating the inner DOM nodes.
        /// Such elements are split on line boundaries and on the boundaries
        /// of lower-precedence decorations.
        /// </summary>
        static member inline mark (spec: CodemirrorView.MarkDecorationSpec): CodemirrorView.Decoration =
            emitJsExpr (spec) $$"""
import { Decoration } from "@codemirror/view";
Decoration.mark($0)"""
        /// <summary>
        /// Create a widget decoration, which displays a DOM element at the
        /// given position.
        /// </summary>
        static member inline widget (spec: CodemirrorView.WidgetDecorationSpec): CodemirrorView.Decoration =
            emitJsExpr (spec) $$"""
import { Decoration } from "@codemirror/view";
Decoration.widget($0)"""
        /// <summary>
        /// Create a replace decoration which replaces the given range with
        /// a widget, or simply hides it.
        /// </summary>
        static member inline replace (spec: CodemirrorView.ReplaceDecorationSpec): CodemirrorView.Decoration =
            emitJsExpr (spec) $$"""
import { Decoration } from "@codemirror/view";
Decoration.replace($0)"""
        /// <summary>
        /// Create a line decoration, which can add DOM attributes to the
        /// line starting at the given position.
        /// </summary>
        static member inline line (spec: CodemirrorView.LineDecorationSpec): CodemirrorView.Decoration =
            emitJsExpr (spec) $$"""
import { Decoration } from "@codemirror/view";
Decoration.line($0)"""
        /// <summary>
        /// Build a [<c>DecorationSet</c>](https://codemirror.net/6/docs/ref/#view.DecorationSet) from the given
        /// decorated range or ranges. If the ranges aren't already sorted,
        /// pass <c>true</c> for <c>sort</c> to make the library sort them for you.
        /// </summary>
        static member inline set (``of``: CodemirrorState.Range<CodemirrorView.Decoration>, ?sort: bool): CodemirrorView.DecorationSet =
            emitJsExpr (``of``, sort) $$"""
import { Decoration } from "@codemirror/view";
Decoration.set($0, $1)"""
        /// <summary>
        /// Build a [<c>DecorationSet</c>](https://codemirror.net/6/docs/ref/#view.DecorationSet) from the given
        /// decorated range or ranges. If the ranges aren't already sorted,
        /// pass <c>true</c> for <c>sort</c> to make the library sort them for you.
        /// </summary>
        static member inline set (``of``: ResizeArray<CodemirrorState.Range<CodemirrorView.Decoration>>, ?sort: bool): CodemirrorView.DecorationSet =
            emitJsExpr (``of``, sort) $$"""
import { Decoration } from "@codemirror/view";
Decoration.set($0, $1)"""
        /// <summary>
        /// The empty set of decorations.
        /// </summary>
        static member inline none
            with get () : CodemirrorView.DecorationSet =
                emitJsExpr () $$"""
import { Decoration } from "@codemirror/view";
Decoration.none"""
            and set (value: CodemirrorView.DecorationSet) =
                emitJsExpr (value) $$"""
import { Decoration } from "@codemirror/view";
Decoration.none = $0"""

    [<AllowNullLiteral>]
    [<Interface>]
    type BlockWrapperSpec =
        /// <summary>
        /// Tag name of the wrapping element.
        /// </summary>
        abstract member tagName: string with get, set
        /// <summary>
        /// DOM attributes to add to the wrapping element.
        /// </summary>
        abstract member attributes: BlockWrapperSpec.attributes option with get, set
        /// <summary>
        /// When multiple overlapping block wrappers are produced by the
        /// same source, this determines their relative precedence. Lower
        /// rank wrappers are nested inside higher-rank ones. Should be
        /// a number between 0 and 100.
        /// </summary>
        abstract member rank: float option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (tagName: string, ?attributes: BlockWrapperSpec.attributes, ?rank: float) : BlockWrapperSpec = nativeOnly

    /// <summary>
    /// A block wrapper defines a DOM node that wraps lines or other block
    /// wrappers at the top of the document. It affects any line or block
    /// widget that starts inside its range, including blocks starting
    /// directly at <c>from</c> but not including <c>to</c>.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type BlockWrapper =
        inherit CodemirrorState.RangeValue
        /// <summary>
        /// Compare this value with another value. Used when comparing
        /// rangesets. The default implementation compares by identity.
        /// Unless you are only creating a fixed number of unique instances
        /// of your value type, it is a good idea to implement this
        /// properly.
        /// </summary>
        abstract member eq: other: CodemirrorState.RangeValue -> bool
        /// <summary>
        /// Create a block wrapper object with the given tag name and
        /// attributes.
        /// </summary>
        static member inline create (spec: CodemirrorView.BlockWrapperSpec): CodemirrorView.BlockWrapper =
            emitJsExpr (spec) $$"""
import { BlockWrapper } from "@codemirror/view";
BlockWrapper.create($0)"""
        /// <summary>
        /// Create a range set from the given block wrapper ranges.
        /// </summary>
        static member inline set (``of``: CodemirrorState.Range<CodemirrorView.BlockWrapper>, ?sort: bool): CodemirrorState.RangeSet<CodemirrorView.BlockWrapper> =
            emitJsExpr (``of``, sort) $$"""
import { BlockWrapper } from "@codemirror/view";
BlockWrapper.set($0, $1)"""
        /// <summary>
        /// Create a range set from the given block wrapper ranges.
        /// </summary>
        static member inline set (``of``: ResizeArray<CodemirrorState.Range<CodemirrorView.BlockWrapper>>, ?sort: bool): CodemirrorState.RangeSet<CodemirrorView.BlockWrapper> =
            emitJsExpr (``of``, sort) $$"""
import { BlockWrapper } from "@codemirror/view";
BlockWrapper.set($0, $1)"""

    /// <summary>
    /// Command functions are used in key bindings and other types of user
    /// actions. Given an editor view, they check whether their effect can
    /// apply to the editor, and if it can, perform it as a side effect
    /// (which usually means [dispatching](https://codemirror.net/6/docs/ref/#view.EditorView.dispatch) a
    /// transaction) and return <c>true</c>.
    /// </summary>
    type Command =
        delegate of target: CodemirrorView.EditorView -> bool

    [<AllowNullLiteral>]
    [<Interface>]
    type ScrollTarget =
        abstract member range: CodemirrorState.SelectionRange with get
        abstract member y: CodemirrorView.ScrollStrategy with get
        abstract member x: CodemirrorView.ScrollStrategy with get
        abstract member yMargin: float with get
        abstract member xMargin: float with get
        abstract member isSnapshot: bool with get
        abstract member map: changes: CodemirrorState.ChangeDesc -> CodemirrorView.ScrollTarget
        abstract member clip: state: CodemirrorState.EditorState -> CodemirrorView.ScrollTarget

    /// <summary>
    /// This is the interface plugin objects conform to.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type PluginValue =
        /// <summary>
        /// Notifies the plugin of an update that happened in the view. This
        /// is called _before_ the view updates its own DOM. It is
        /// responsible for updating the plugin's internal state (including
        /// any state that may be read by plugin fields) and _writing_ to
        /// the DOM for the changes in the update. To avoid unnecessary
        /// layout recomputations, it should _not_ read the DOM layout—use
        /// [<c>requestMeasure</c>](https://codemirror.net/6/docs/ref/#view.EditorView.requestMeasure) to schedule
        /// your code in a DOM reading phase if you need to.
        /// </summary>
        abstract member update: update: CodemirrorView.ViewUpdate -> unit
        /// <summary>
        /// Called when the document view is updated (due to content,
        /// decoration, or viewport changes). Should not try to immediately
        /// start another view update. Often useful for calling
        /// [<c>requestMeasure</c>](https://codemirror.net/6/docs/ref/#view.EditorView.requestMeasure).
        /// </summary>
        abstract member docViewUpdate: view: CodemirrorView.EditorView -> unit
        /// <summary>
        /// Called when the plugin is no longer going to be used. Should
        /// revert any changes the plugin made to the DOM.
        /// </summary>
        abstract member destroy: unit -> unit

    /// <summary>
    /// Provides additional information when defining a [view
    /// plugin](https://codemirror.net/6/docs/ref/#view.ViewPlugin).
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type PluginSpec<'V> =
        /// <summary>
        /// Register the given [event
        /// handlers](https://codemirror.net/6/docs/ref/#view.EditorView^domEventHandlers) for the plugin.
        /// When called, these will have their <c>this</c> bound to the plugin
        /// value.
        /// </summary>
        abstract member eventHandlers: CodemirrorView.DOMEventHandlers<'V> option with get, set
        /// <summary>
        /// Registers [event observers](https://codemirror.net/6/docs/ref/#view.EditorView^domEventObservers)
        /// for the plugin. Will, when called, have their <c>this</c> bound to
        /// the plugin value.
        /// </summary>
        abstract member eventObservers: CodemirrorView.DOMEventHandlers<'V> option with get, set
        /// <summary>
        /// Specify that the plugin provides additional extensions when
        /// added to an editor configuration.
        /// </summary>
        abstract member provide: (CodemirrorView.ViewPlugin<'V, obj> -> CodemirrorState.Extension) option with get, set
        /// <summary>
        /// Allow the plugin to provide decorations. When given, this should
        /// be a function that take the plugin value and return a
        /// [decoration set](https://codemirror.net/6/docs/ref/#view.DecorationSet). See also the caveat about
        /// [layout-changing decorations](https://codemirror.net/6/docs/ref/#view.EditorView^decorations) that
        /// depend on the view.
        /// </summary>
        abstract member decorations: ('V -> CodemirrorView.DecorationSet) option with get, set

    /// <summary>
    /// View plugins associate stateful values with a view. They can
    /// influence the way the content is drawn, and are notified of things
    /// that happen in the view. They optionally take an argument, in
    /// which case you need to call [<c>of</c>](https://codemirror.net/6/docs/ref/#view.ViewPlugin.of) to create
    /// an extension for the plugin. When the argument type is undefined,
    /// you can use the plugin instance as an extension directly.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type ViewPlugin<'V, 'Arg> =
        /// <summary>
        /// When <c>Arg</c> is undefined, instances of this class act as
        /// extensions. Otherwise, you have to call <c>of</c> to create an
        /// extension value.
        /// </summary>
        abstract member extension: obj with get, set
        /// <summary>
        /// Create an extension for this plugin with the given argument.
        /// </summary>
        abstract member ``of``: arg: 'Arg -> CodemirrorState.Extension
        /// <summary>
        /// Define a plugin from a constructor function that creates the
        /// plugin's value, given an editor view.
        /// </summary>
        static member inline define (create: ViewPlugin.define__.create<'V, 'Arg>, ?spec: CodemirrorView.PluginSpec<'V>): CodemirrorView.ViewPlugin<'V, 'Arg> =
            emitJsExpr (create, spec) $$"""
import { ViewPlugin } from "@codemirror/view";
ViewPlugin.define($0, $1)"""
        /// <summary>
        /// Create a plugin for a class whose constructor takes a single
        /// editor view as argument.
        /// </summary>
        static member inline fromClass (cls: ViewPlugin.fromClass__.cls<'V, 'Arg>, ?spec: CodemirrorView.PluginSpec<'V>): CodemirrorView.ViewPlugin<'V, 'Arg> =
            emitJsExpr (cls, spec) $$"""
import { ViewPlugin } from "@codemirror/view";
ViewPlugin.fromClass($0, $1)"""

    type ViewPlugin<'V> =
        ViewPlugin<'V, obj>

    [<AllowNullLiteral>]
    [<Interface>]
    type MeasureRequest<'T> =
        /// <summary>
        /// Called in a DOM read phase to gather information that requires
        /// DOM layout. Should _not_ mutate the document.
        /// </summary>
        abstract member read: view: CodemirrorView.EditorView -> 'T
        /// <summary>
        /// Called in a DOM write phase to update the document. Should _not_
        /// do anything that triggers DOM layout.
        /// </summary>
        abstract member write: ``measure``: 'T * view: CodemirrorView.EditorView -> unit
        /// <summary>
        /// When multiple requests with the same key are scheduled, only the
        /// last one will actually be run.
        /// </summary>
        abstract member key: obj option with get, set

    type AttrSource =
        U2<CodemirrorView.Attrs, (CodemirrorView.EditorView -> CodemirrorView.Attrs option)>

    /// <summary>
    /// View [plugins](https://codemirror.net/6/docs/ref/#view.ViewPlugin) are given instances of this
    /// class, which describe what happened, whenever the view is updated.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type ViewUpdate =
        /// <summary>
        /// The editor view that the update is associated with.
        /// </summary>
        abstract member view: CodemirrorView.EditorView with get
        /// <summary>
        /// The new editor state.
        /// </summary>
        abstract member state: CodemirrorState.EditorState with get
        /// <summary>
        /// The transactions involved in the update. May be empty.
        /// </summary>
        abstract member transactions: ReadonlyArray<CodemirrorState.Transaction> with get
        /// <summary>
        /// The changes made to the document by this update.
        /// </summary>
        abstract member changes: CodemirrorState.ChangeSet with get
        /// <summary>
        /// The previous editor state.
        /// </summary>
        abstract member startState: CodemirrorState.EditorState with get
        /// <summary>
        /// Tells you whether the [viewport](https://codemirror.net/6/docs/ref/#view.EditorView.viewport) or
        /// [visible ranges](https://codemirror.net/6/docs/ref/#view.EditorView.visibleRanges) changed in this
        /// update.
        /// </summary>
        abstract member viewportChanged: bool with get
        /// <summary>
        /// Returns true when
        /// [<c>viewportChanged</c>](https://codemirror.net/6/docs/ref/#view.ViewUpdate.viewportChanged) is true
        /// and the viewport change is not just the result of mapping it in
        /// response to document changes.
        /// </summary>
        abstract member viewportMoved: bool with get
        /// <summary>
        /// Indicates whether the height of a block element in the editor
        /// changed in this update.
        /// </summary>
        abstract member heightChanged: bool with get
        /// <summary>
        /// Returns true when the document was modified or the size of the
        /// editor, or elements within the editor, changed.
        /// </summary>
        abstract member geometryChanged: bool with get
        /// <summary>
        /// True when this update indicates a focus change.
        /// </summary>
        abstract member focusChanged: bool with get
        /// <summary>
        /// Whether the document changed in this update.
        /// </summary>
        abstract member docChanged: bool with get
        /// <summary>
        /// Whether the selection was explicitly set in this update.
        /// </summary>
        abstract member selectionSet: bool with get

    /// <summary>
    /// Interface that objects registered with
    /// [<c>EditorView.mouseSelectionStyle</c>](https://codemirror.net/6/docs/ref/#view.EditorView^mouseSelectionStyle)
    /// must conform to.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type MouseSelectionStyle =
        /// <summary>
        /// Return a new selection for the mouse gesture that starts with
        /// the event that was originally given to the constructor, and ends
        /// with the event passed here. In case of a plain click, those may
        /// both be the <c>mousedown</c> event, in case of a drag gesture, the
        /// latest <c>mousemove</c> event will be passed.
        ///
        /// When <c>extend</c> is true, that means the new selection should, if
        /// possible, extend the start selection. If <c>multiple</c> is true, the
        /// new selection should be added to the original selection.
        /// </summary>
        abstract member get: MouseSelectionStyle.get with get, set
        /// <summary>
        /// Called when the view is updated while the gesture is in
        /// progress. When the document changes, it may be necessary to map
        /// some data (like the original selection or start position)
        /// through the changes.
        ///
        /// This may return <c>true</c> to indicate that the <c>get</c> method should
        /// get queried again after the update, because something in the
        /// update could change its result. Be wary of infinite loops when
        /// using this (where <c>get</c> returns a new selection, which will
        /// trigger <c>update</c>, which schedules another <c>get</c> in response).
        /// </summary>
        abstract member update: (CodemirrorView.ViewUpdate -> U2<bool, unit>) with get, set

    type MakeSelectionStyle =
        delegate of view: CodemirrorView.EditorView * event: Glutinum.Web.MouseEvent -> CodemirrorView.MouseSelectionStyle option

    /// <summary>
    /// Record used to represent information about a block-level element
    /// in the editor view.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type BlockInfo =
        /// <summary>
        /// The start of the element in the document.
        /// </summary>
        abstract member from: float with get
        /// <summary>
        /// The length of the element.
        /// </summary>
        abstract member length: float with get
        /// <summary>
        /// The top position of the element (relative to the top of the
        /// document).
        /// </summary>
        abstract member top: float with get
        /// <summary>
        /// Its height.
        /// </summary>
        abstract member height: float with get
        /// <summary>
        /// The type of element this is. When querying lines, this may be
        /// an array of all the blocks that make up the line.
        /// </summary>
        abstract member ``type``: U2<CodemirrorView.BlockType, ReadonlyArray<CodemirrorView.BlockInfo>> with get
        /// <summary>
        /// The end of the element as a document position.
        /// </summary>
        abstract member ``to``: float with get
        /// <summary>
        /// The bottom position of the element.
        /// </summary>
        abstract member bottom: float with get
        /// <summary>
        /// If this is a widget block, this will return the widget
        /// associated with it.
        /// </summary>
        abstract member widget: CodemirrorView.WidgetType option with get
        /// <summary>
        /// If this is a textblock, this holds the number of line breaks
        /// that appear in widgets inside the block.
        /// </summary>
        abstract member widgetLineBreaks: float with get

    /// <summary>
    /// The type of object given to the [<c>EditorView</c>](https://codemirror.net/6/docs/ref/#view.EditorView)
    /// constructor.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type EditorViewConfig =
        inherit CodemirrorState.EditorStateConfig
        /// <summary>
        /// The view's initial state. If not given, a new state is created
        /// by passing this configuration object to
        /// [<c>EditorState.create</c>](https://codemirror.net/6/docs/ref/#state.EditorState^create), using its
        /// <c>doc</c>, <c>selection</c>, and <c>extensions</c> field (if provided).
        /// </summary>
        abstract member state: CodemirrorState.EditorState option with get, set
        /// <summary>
        /// When given, the editor is immediately appended to the given
        /// element on creation. (Otherwise, you'll have to place the view's
        /// [<c>dom</c>](https://codemirror.net/6/docs/ref/#view.EditorView.dom) element in the document yourself.)
        /// </summary>
        abstract member parent: U2<Glutinum.Web.Element, Glutinum.Web.DocumentFragment> option with get, set
        /// <summary>
        /// If the view is going to be mounted in a shadow root or document
        /// other than the one held by the global variable <c>document</c> (the
        /// default), you should pass it here. If you provide <c>parent</c>, but
        /// not this option, the editor will automatically look up a root
        /// from the parent.
        /// </summary>
        abstract member root: U2<Glutinum.Web.Document, Glutinum.Web.ShadowRoot> option with get, set
        /// <summary>
        /// Pass an effect created with
        /// [<c>EditorView.scrollIntoView</c>](https://codemirror.net/6/docs/ref/#view.EditorView^scrollIntoView) or
        /// [<c>EditorView.scrollSnapshot</c>](https://codemirror.net/6/docs/ref/#view.EditorView.scrollSnapshot)
        /// here to set an initial scroll position.
        /// </summary>
        abstract member scrollTo: CodemirrorState.StateEffect<obj> option with get, set
        /// <summary>
        /// Override the way transactions are
        /// [dispatched](https://codemirror.net/6/docs/ref/#view.EditorView.dispatch) for this editor view.
        /// Your implementation, if provided, should probably call the
        /// view's [<c>update</c> method](https://codemirror.net/6/docs/ref/#view.EditorView.update).
        /// </summary>
        abstract member dispatchTransactions: EditorViewConfig.dispatchTransactions option with get, set
        /// <summary>
        /// *Deprecated** single-transaction version of
        /// <c>dispatchTransactions</c>. Will force transactions to be dispatched
        /// one at a time when used.
        /// </summary>
        abstract member dispatch: EditorViewConfig.dispatch option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?doc: U2<string, CodemirrorState.Text>, ?selection: U2<CodemirrorState.EditorSelection, EditorViewConfig.selection.U2.Case2>, ?extensions: CodemirrorState.Extension, ?state: CodemirrorState.EditorState, ?parent: U2<Glutinum.Web.Element, Glutinum.Web.DocumentFragment>, ?root: U2<Glutinum.Web.Document, Glutinum.Web.ShadowRoot>, ?scrollTo: CodemirrorState.StateEffect<obj>, ?dispatchTransactions: EditorViewConfig.dispatchTransactions, ?dispatch: EditorViewConfig.dispatch) : EditorViewConfig = nativeOnly

    /// <summary>
    /// An editor view represents the editor's user interface. It holds
    /// the editable DOM surface, and possibly other elements such as the
    /// line number gutter. It handles events and dispatches state
    /// transactions for editing actions.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type EditorView =
        /// <summary>
        /// The current editor state.
        /// </summary>
        abstract member state: CodemirrorState.EditorState with get
        /// <summary>
        /// To be able to display large documents without consuming too much
        /// memory or overloading the browser, CodeMirror only draws the
        /// code that is visible (plus a margin around it) to the DOM. This
        /// property tells you the extent of the current drawn viewport, in
        /// document positions.
        /// </summary>
        abstract member viewport: EditorView.viewport with get
        /// <summary>
        /// When there are, for example, large collapsed ranges in the
        /// viewport, its size can be a lot bigger than the actual visible
        /// content. Thus, if you are doing something like styling the
        /// content in the viewport, it is preferable to only do so for
        /// these ranges, which are the subset of the viewport that is
        /// actually drawn.
        /// </summary>
        abstract member visibleRanges: ReadonlyArray<EditorView.visibleRanges> with get
        /// <summary>
        /// Returns false when the editor is entirely scrolled out of view
        /// or otherwise hidden.
        /// </summary>
        abstract member inView: bool with get
        /// <summary>
        /// Indicates whether the user is currently composing text via
        /// [IME](https://en.wikipedia.org/wiki/Input_method), and at least
        /// one change has been made in the current composition.
        /// </summary>
        abstract member composing: bool with get
        /// <summary>
        /// Indicates whether the user is currently in composing state. Note
        /// that on some platforms, like Android, this will be the case a
        /// lot, since just putting the cursor on a word starts a
        /// composition there.
        /// </summary>
        abstract member compositionStarted: bool with get
        /// <summary>
        /// The document or shadow root that the view lives in.
        /// </summary>
        abstract member root: Glutinum.Web.DocumentOrShadowRoot with get
        /// <summary>
        /// The DOM element that wraps the entire editor view.
        /// </summary>
        abstract member dom: Glutinum.Web.HTMLElement with get
        /// <summary>
        /// The DOM element that can be styled to scroll. (Note that it may
        /// not have been, so you can't assume this is scrollable.)
        /// </summary>
        abstract member scrollDOM: Glutinum.Web.HTMLElement with get
        /// <summary>
        /// The editable DOM element holding the editor content. You should
        /// not, usually, interact with this content directly though the
        /// DOM, since the editor will immediately undo most of the changes
        /// you make. Instead, [dispatch](https://codemirror.net/6/docs/ref/#view.EditorView.dispatch)
        /// [transactions](https://codemirror.net/6/docs/ref/#state.Transaction) to modify content, and
        /// [decorations](https://codemirror.net/6/docs/ref/#view.Decoration) to style it.
        /// </summary>
        abstract member contentDOM: Glutinum.Web.HTMLElement with get
        /// <summary>
        /// All regular editor state updates should go through this. It
        /// takes a transaction, array of transactions, or transaction spec
        /// and updates the view to show the new state produced by that
        /// transaction. Its implementation can be overridden with an
        /// [option](https://codemirror.net/6/docs/ref/#view.EditorView.constructor^config.dispatchTransactions).
        /// This function is bound to the view instance, so it does not have
        /// to be called as a method.
        ///
        /// Note that when multiple <c>TransactionSpec</c> arguments are
        /// provided, these define a single transaction (the specs will be
        /// merged), not a sequence of transactions.
        /// </summary>
        abstract member dispatch: tr: CodemirrorState.Transaction -> unit
        /// <summary>
        /// All regular editor state updates should go through this. It
        /// takes a transaction, array of transactions, or transaction spec
        /// and updates the view to show the new state produced by that
        /// transaction. Its implementation can be overridden with an
        /// [option](https://codemirror.net/6/docs/ref/#view.EditorView.constructor^config.dispatchTransactions).
        /// This function is bound to the view instance, so it does not have
        /// to be called as a method.
        ///
        /// Note that when multiple <c>TransactionSpec</c> arguments are
        /// provided, these define a single transaction (the specs will be
        /// merged), not a sequence of transactions.
        /// </summary>
        abstract member dispatch: trs: ResizeArray<CodemirrorState.Transaction> -> unit
        /// <summary>
        /// All regular editor state updates should go through this. It
        /// takes a transaction, array of transactions, or transaction spec
        /// and updates the view to show the new state produced by that
        /// transaction. Its implementation can be overridden with an
        /// [option](https://codemirror.net/6/docs/ref/#view.EditorView.constructor^config.dispatchTransactions).
        /// This function is bound to the view instance, so it does not have
        /// to be called as a method.
        ///
        /// Note that when multiple <c>TransactionSpec</c> arguments are
        /// provided, these define a single transaction (the specs will be
        /// merged), not a sequence of transactions.
        /// </summary>
        abstract member dispatch: [<ParamArray>] specs: CodemirrorState.TransactionSpec [] -> unit
        /// <summary>
        /// Update the view for the given array of transactions. This will
        /// update the visible document and selection to match the state
        /// produced by the transactions, and notify view plugins of the
        /// change. You should usually call
        /// [<c>dispatch</c>](https://codemirror.net/6/docs/ref/#view.EditorView.dispatch) instead, which uses this
        /// as a primitive.
        /// </summary>
        abstract member update: transactions: ResizeArray<CodemirrorState.Transaction> -> unit
        /// <summary>
        /// Reset the view to the given state. (This will cause the entire
        /// document to be redrawn and all view plugins to be reinitialized,
        /// so you should probably only use it when the new state isn't
        /// derived from the old state. Otherwise, use
        /// [<c>dispatch</c>](https://codemirror.net/6/docs/ref/#view.EditorView.dispatch) instead.)
        /// </summary>
        abstract member setState: newState: CodemirrorState.EditorState -> unit
        /// <summary>
        /// Get the CSS classes for the currently active editor themes.
        /// </summary>
        abstract member themeClasses: string with get
        /// <summary>
        /// Schedule a layout measurement, optionally providing callbacks to
        /// do custom DOM measuring followed by a DOM write phase. Using
        /// this is preferable reading DOM layout directly from, for
        /// example, an event handler, because it'll make sure measuring and
        /// drawing done by other components is synchronized, avoiding
        /// unnecessary DOM layout computations.
        /// </summary>
        abstract member requestMeasure<'T>: ?request: CodemirrorView.MeasureRequest<'T> -> unit
        /// <summary>
        /// Get the value of a specific plugin, if present. Note that
        /// plugins that crash can be dropped from a view, so even when you
        /// know you registered a given plugin, it is recommended to check
        /// the return value of this method.
        /// </summary>
        abstract member plugin<'T>: plugin: CodemirrorView.ViewPlugin<'T, obj> -> 'T option
        /// <summary>
        /// The top position of the document, in screen coordinates. This
        /// may be negative when the editor is scrolled down. Points
        /// directly to the top of the first line, not above the padding.
        /// </summary>
        abstract member documentTop: float with get
        /// <summary>
        /// Reports the padding above and below the document.
        /// </summary>
        abstract member documentPadding: EditorView.documentPadding with get
        /// <summary>
        /// If the editor is transformed with CSS, this provides the scale
        /// along the X axis. Otherwise, it will just be 1. Note that
        /// transforms other than translation and scaling are not supported.
        /// </summary>
        abstract member scaleX: float with get
        /// <summary>
        /// Provide the CSS transformed scale along the Y axis.
        /// </summary>
        abstract member scaleY: float with get
        /// <summary>
        /// Find the text line or block widget at the given vertical
        /// position (which is interpreted as relative to the [top of the
        /// document](https://codemirror.net/6/docs/ref/#view.EditorView.documentTop)).
        /// </summary>
        abstract member elementAtHeight: height: float -> CodemirrorView.BlockInfo
        /// <summary>
        /// Find the line block (see
        /// [<c>lineBlockAt</c>](https://codemirror.net/6/docs/ref/#view.EditorView.lineBlockAt)) at the given
        /// height, again interpreted relative to the [top of the
        /// document](https://codemirror.net/6/docs/ref/#view.EditorView.documentTop).
        /// </summary>
        abstract member lineBlockAtHeight: height: float -> CodemirrorView.BlockInfo
        /// <summary>
        /// Get the extent and vertical position of all [line
        /// blocks](https://codemirror.net/6/docs/ref/#view.EditorView.lineBlockAt) in the viewport. Positions
        /// are relative to the [top of the
        /// document](https://codemirror.net/6/docs/ref/#view.EditorView.documentTop);
        /// </summary>
        abstract member viewportLineBlocks: ResizeArray<CodemirrorView.BlockInfo> with get
        /// <summary>
        /// Find the line block around the given document position. A line
        /// block is a range delimited on both sides by either a
        /// non-[hidden](https://codemirror.net/6/docs/ref/#view.Decoration^replace) line break, or the
        /// start/end of the document. It will usually just hold a line of
        /// text, but may be broken into multiple textblocks by block
        /// widgets.
        /// </summary>
        abstract member lineBlockAt: pos: float -> CodemirrorView.BlockInfo
        /// <summary>
        /// The editor's total content height.
        /// </summary>
        abstract member contentHeight: float with get
        /// <summary>
        /// Move a cursor position by [grapheme
        /// cluster](https://codemirror.net/6/docs/ref/#state.findClusterBreak). <c>forward</c> determines whether
        /// the motion is away from the line start, or towards it. In
        /// bidirectional text, the line is traversed in visual order, using
        /// the editor's [text direction](https://codemirror.net/6/docs/ref/#view.EditorView.textDirection).
        /// When the start position was the last one on the line, the
        /// returned position will be across the line break. If there is no
        /// further line, the original position is returned.
        ///
        /// By default, this method moves over a single cluster. The
        /// optional <c>by</c> argument can be used to move across more. It will
        /// be called with the first cluster as argument, and should return
        /// a predicate that determines, for each subsequent cluster,
        /// whether it should also be moved over.
        /// </summary>
        abstract member moveByChar: start: CodemirrorState.SelectionRange * forward: bool * ?by: (string -> (string -> bool)) -> CodemirrorState.SelectionRange
        /// <summary>
        /// Move a cursor position across the next group of either
        /// [letters](https://codemirror.net/6/docs/ref/#state.EditorState.charCategorizer) or non-letter
        /// non-whitespace characters.
        /// </summary>
        abstract member moveByGroup: start: CodemirrorState.SelectionRange * forward: bool -> CodemirrorState.SelectionRange
        /// <summary>
        /// Get the cursor position visually at the start or end of a line.
        /// Note that this may differ from the _logical_ position at its
        /// start or end (which is simply at <c>line.from</c>/<c>line.to</c>) if text
        /// at the start or end goes against the line's base text direction.
        /// </summary>
        abstract member visualLineSide: line: CodemirrorState.Line * ``end``: bool -> CodemirrorState.SelectionRange
        /// <summary>
        /// Move to the next line boundary in the given direction. If
        /// <c>includeWrap</c> is true, line wrapping is on, and there is a
        /// further wrap point on the current line, the wrap point will be
        /// returned. Otherwise this function will return the start or end
        /// of the line.
        /// </summary>
        abstract member moveToLineBoundary: start: CodemirrorState.SelectionRange * forward: bool * ?includeWrap: bool -> CodemirrorState.SelectionRange
        /// <summary>
        /// Move a cursor position vertically. When <c>distance</c> isn't given,
        /// it defaults to moving to the next line (including wrapped
        /// lines). Otherwise, <c>distance</c> should provide a positive distance
        /// in pixels.
        ///
        /// When <c>start</c> has a
        /// [<c>goalColumn</c>](https://codemirror.net/6/docs/ref/#state.SelectionRange.goalColumn), the vertical
        /// motion will use that as a target horizontal position. Otherwise,
        /// the cursor's own horizontal position is used. The returned
        /// cursor will have its goal column set to whichever column was
        /// used.
        /// </summary>
        abstract member moveVertically: start: CodemirrorState.SelectionRange * forward: bool * ?distance: float -> CodemirrorState.SelectionRange
        /// <summary>
        /// Find the DOM parent node and offset (child offset if <c>node</c> is
        /// an element, character offset when it is a text node) at the
        /// given document position.
        ///
        /// Note that for positions that aren't currently in
        /// <c>visibleRanges</c>, the resulting DOM position isn't necessarily
        /// meaningful (it may just point before or after a placeholder
        /// element).
        /// </summary>
        abstract member domAtPos: pos: float * ?side: EditorView.domAtPos.side -> EditorView.domAtPos
        /// <summary>
        /// Find the document position at the given DOM node. Can be useful
        /// for associating positions with DOM events. Will raise an error
        /// when <c>node</c> isn't part of the editor content.
        /// </summary>
        abstract member posAtDOM: node: Glutinum.Web.Node * ?offset: float -> float
        /// <summary>
        /// Get the document position at the given screen coordinates. For
        /// positions not covered by the visible viewport's DOM structure,
        /// this will return null, unless <c>false</c> is passed as second
        /// argument, in which case it'll return an estimated position that
        /// would be near the coordinates if it were rendered.
        /// </summary>
        abstract member posAtCoords: coords: EditorView.posAtCoords.coords * precise: bool -> float
        /// <summary>
        /// Get the document position at the given screen coordinates. For
        /// positions not covered by the visible viewport's DOM structure,
        /// this will return null, unless <c>false</c> is passed as second
        /// argument, in which case it'll return an estimated position that
        /// would be near the coordinates if it were rendered.
        /// </summary>
        abstract member posAtCoords: coords: EditorView.posAtCoords.coords_1 -> float option
        /// <summary>
        /// Like [<c>posAtCoords</c>](https://codemirror.net/6/docs/ref/#view.EditorView.posAtCoords), but also
        /// returns which side of the position the coordinates are closest
        /// to. For example, for coordinates on the left side of a
        /// left-to-right character, the position before that letter is
        /// returned, with <c>assoc</c> 1, whereas on the right side, you'd get
        /// the position after the character, with <c>assoc</c> -1.
        /// </summary>
        abstract member posAndSideAtCoords: coords: EditorView.posAndSideAtCoords.coords * precise: bool -> EditorView.posAndSideAtCoords
        /// <summary>
        /// Like [<c>posAtCoords</c>](https://codemirror.net/6/docs/ref/#view.EditorView.posAtCoords), but also
        /// returns which side of the position the coordinates are closest
        /// to. For example, for coordinates on the left side of a
        /// left-to-right character, the position before that letter is
        /// returned, with <c>assoc</c> 1, whereas on the right side, you'd get
        /// the position after the character, with <c>assoc</c> -1.
        /// </summary>
        abstract member posAndSideAtCoords: coords: EditorView.posAndSideAtCoords.coords_1 -> EditorView.posAndSideAtCoords_1 option
        /// <summary>
        /// Get the screen coordinates at the given document position.
        /// <c>side</c> determines whether the coordinates are based on the
        /// element before (-1) or after (1) the position (if no element is
        /// available on the given side, the method will transparently use
        /// another strategy to get reasonable coordinates).
        /// </summary>
        abstract member coordsAtPos: pos: float * ?side: EditorView.coordsAtPos.side -> CodemirrorView.Rect option
        /// <summary>
        /// Return the rectangle around a given character. If <c>pos</c> does not
        /// point in front of a character that is in the viewport and
        /// rendered (i.e. not replaced, not a line break), this will return
        /// null. For space characters that are a line wrap point, this will
        /// return the position before the line break.
        /// </summary>
        abstract member coordsForChar: pos: float -> CodemirrorView.Rect option
        /// <summary>
        /// The default width of a character in the editor. May not
        /// accurately reflect the width of all characters (given variable
        /// width fonts or styling of invididual ranges).
        /// </summary>
        abstract member defaultCharacterWidth: float with get
        /// <summary>
        /// The default height of a line in the editor. May not be accurate
        /// for all lines.
        /// </summary>
        abstract member defaultLineHeight: float with get
        /// <summary>
        /// The text direction
        /// ([<c>direction</c>](https://developer.mozilla.org/en-US/docs/Web/CSS/direction)
        /// CSS property) of the editor's content element.
        /// </summary>
        abstract member textDirection: CodemirrorView.Direction with get
        /// <summary>
        /// Find the text direction of the block at the given position, as
        /// assigned by CSS. If
        /// [<c>perLineTextDirection</c>](https://codemirror.net/6/docs/ref/#view.EditorView^perLineTextDirection)
        /// isn't enabled, or the given position is outside of the viewport,
        /// this will always return the same as
        /// [<c>textDirection</c>](https://codemirror.net/6/docs/ref/#view.EditorView.textDirection). Note that
        /// this may trigger a DOM layout.
        /// </summary>
        abstract member textDirectionAt: pos: float -> CodemirrorView.Direction
        /// <summary>
        /// Whether this editor [wraps lines](https://codemirror.net/6/docs/ref/#view.EditorView.lineWrapping)
        /// (as determined by the
        /// [<c>white-space</c>](https://developer.mozilla.org/en-US/docs/Web/CSS/white-space)
        /// CSS property of its content element).
        /// </summary>
        abstract member lineWrapping: bool with get
        /// <summary>
        /// Returns the bidirectional text structure of the given line
        /// (which should be in the current document) as an array of span
        /// objects. The order of these spans matches the [text
        /// direction](https://codemirror.net/6/docs/ref/#view.EditorView.textDirection)—if that is
        /// left-to-right, the leftmost spans come first, otherwise the
        /// rightmost spans come first.
        /// </summary>
        abstract member bidiSpans: line: CodemirrorState.Line -> ReadonlyArray<CodemirrorView.BidiSpan>
        /// <summary>
        /// Check whether the editor has focus.
        /// </summary>
        abstract member hasFocus: bool with get
        /// <summary>
        /// Put focus on the editor.
        /// </summary>
        abstract member focus: unit -> unit
        /// <summary>
        /// Update the [root](https://codemirror.net/6/docs/ref/##view.EditorViewConfig.root) in which the editor lives. This is only
        /// necessary when moving the editor's existing DOM to a new window or shadow root.
        /// </summary>
        abstract member setRoot: root: Glutinum.Web.Document -> unit
        /// <summary>
        /// Update the [root](https://codemirror.net/6/docs/ref/##view.EditorViewConfig.root) in which the editor lives. This is only
        /// necessary when moving the editor's existing DOM to a new window or shadow root.
        /// </summary>
        abstract member setRoot: root: Glutinum.Web.ShadowRoot -> unit
        /// <summary>
        /// Clean up this editor view, removing its element from the
        /// document, unregistering event handlers, and notifying
        /// plugins. The view instance can no longer be used after
        /// calling this.
        /// </summary>
        abstract member destroy: unit -> unit
        /// <summary>
        /// Returns an effect that can be
        /// [added](https://codemirror.net/6/docs/ref/#state.TransactionSpec.effects) to a transaction to
        /// cause it to scroll the given position or range into view.
        /// </summary>
        static member inline scrollIntoView (pos: float, ?options: EditorView.scrollIntoView__.options): CodemirrorState.StateEffect<obj> =
            emitJsExpr (pos, options) $$"""
import { EditorView } from "@codemirror/view";
EditorView.scrollIntoView($0, $1)"""
        /// <summary>
        /// Returns an effect that can be
        /// [added](https://codemirror.net/6/docs/ref/#state.TransactionSpec.effects) to a transaction to
        /// cause it to scroll the given position or range into view.
        /// </summary>
        static member inline scrollIntoView (pos: CodemirrorState.SelectionRange, ?options: EditorView.scrollIntoView__.options): CodemirrorState.StateEffect<obj> =
            emitJsExpr (pos, options) $$"""
import { EditorView } from "@codemirror/view";
EditorView.scrollIntoView($0, $1)"""
        /// <summary>
        /// Return an effect that resets the editor to its current (at the
        /// time this method was called) scroll position. Note that this
        /// only affects the editor's own scrollable element, not parents.
        /// See also
        /// [<c>EditorViewConfig.scrollTo</c>](https://codemirror.net/6/docs/ref/#view.EditorViewConfig.scrollTo).
        ///
        /// The effect should be used with a document identical to the one
        /// it was created for. Failing to do so is not an error, but may
        /// not scroll to the expected position. You can
        /// [map](https://codemirror.net/6/docs/ref/#state.StateEffect.map) the effect to account for changes.
        /// </summary>
        abstract member scrollSnapshot: unit -> CodemirrorState.StateEffect<CodemirrorView.ScrollTarget>
        /// <summary>
        /// Enable or disable tab-focus mode, which disables key bindings
        /// for Tab and Shift-Tab, letting the browser's default
        /// focus-changing behavior go through instead. This is useful to
        /// prevent trapping keyboard users in your editor.
        ///
        /// Without argument, this toggles the mode. With a boolean, it
        /// enables (true) or disables it (false). Given a number, it
        /// temporarily enables the mode until that number of milliseconds
        /// have passed or another non-Tab key is pressed.
        /// </summary>
        abstract member setTabFocusMode: unit -> unit
        /// <summary>
        /// Enable or disable tab-focus mode, which disables key bindings
        /// for Tab and Shift-Tab, letting the browser's default
        /// focus-changing behavior go through instead. This is useful to
        /// prevent trapping keyboard users in your editor.
        ///
        /// Without argument, this toggles the mode. With a boolean, it
        /// enables (true) or disables it (false). Given a number, it
        /// temporarily enables the mode until that number of milliseconds
        /// have passed or another non-Tab key is pressed.
        /// </summary>
        abstract member setTabFocusMode: ``to``: bool -> unit
        /// <summary>
        /// Enable or disable tab-focus mode, which disables key bindings
        /// for Tab and Shift-Tab, letting the browser's default
        /// focus-changing behavior go through instead. This is useful to
        /// prevent trapping keyboard users in your editor.
        ///
        /// Without argument, this toggles the mode. With a boolean, it
        /// enables (true) or disables it (false). Given a number, it
        /// temporarily enables the mode until that number of milliseconds
        /// have passed or another non-Tab key is pressed.
        /// </summary>
        abstract member setTabFocusMode: ``to``: float -> unit
        /// <summary>
        /// Facet to add a [style
        /// module](https://code.haverbeke.berlin/marijn/style-mod#documentation) to
        /// an editor view. The view will ensure that the module is
        /// mounted in its [document
        /// root](https://codemirror.net/6/docs/ref/#view.EditorView.constructor^config.root).
        /// </summary>
        static member inline styleModule
            with get () : CodemirrorState.Facet<StyleMod.StyleModule, ReadonlyArray<StyleMod.StyleModule>> =
                emitJsExpr () $$"""
import { EditorView } from "@codemirror/view";
EditorView.styleModule"""
            and set (value: CodemirrorState.Facet<StyleMod.StyleModule, ReadonlyArray<StyleMod.StyleModule>>) =
                emitJsExpr (value) $$"""
import { EditorView } from "@codemirror/view";
EditorView.styleModule = $0"""
        /// <summary>
        /// Returns an extension that can be used to add DOM event handlers.
        /// The value should be an object mapping event names to handler
        /// functions. For any given event, such functions are ordered by
        /// extension precedence, and the first handler to return true will
        /// be assumed to have handled that event, and no other handlers or
        /// built-in behavior will be activated for it. These are registered
        /// on the [content element](https://codemirror.net/6/docs/ref/#view.EditorView.contentDOM), except
        /// for <c>scroll</c> handlers, which will be called any time the
        /// editor's [scroll element](https://codemirror.net/6/docs/ref/#view.EditorView.scrollDOM) or one of
        /// its parent nodes is scrolled.
        /// </summary>
        static member inline domEventHandlers (handlers: EditorView.domEventHandlers__.handlers): CodemirrorState.Extension =
            emitJsExpr (handlers) $$"""
import { EditorView } from "@codemirror/view";
EditorView.domEventHandlers($0)"""
        /// <summary>
        /// Create an extension that registers DOM event observers. Contrary
        /// to event [handlers](https://codemirror.net/6/docs/ref/#view.EditorView^domEventHandlers),
        /// observers can't be prevented from running by a higher-precedence
        /// handler returning true. They also don't prevent other handlers
        /// and observers from running when they return true, and should not
        /// call <c>preventDefault</c>.
        /// </summary>
        static member inline domEventObservers (observers: EditorView.domEventObservers__.observers): CodemirrorState.Extension =
            emitJsExpr (observers) $$"""
import { EditorView } from "@codemirror/view";
EditorView.domEventObservers($0)"""
        /// <summary>
        /// An input handler can override the way changes to the editable
        /// DOM content are handled. Handlers are passed the document
        /// positions between which the change was found, and the new
        /// content. When one returns true, no further input handlers are
        /// called and the default behavior is prevented.
        ///
        /// The <c>insert</c> argument can be used to get the default transaction
        /// that would be applied for this input. This can be useful when
        /// dispatching the custom behavior as a separate transaction.
        /// </summary>
        static member inline inputHandler
            with get () : CodemirrorState.Facet<EditorView.inputHandler__, ReadonlyArray<EditorView.inputHandler__>> =
                emitJsExpr () $$"""
import { EditorView } from "@codemirror/view";
EditorView.inputHandler"""
            and set (value: CodemirrorState.Facet<EditorView.inputHandler__, ReadonlyArray<EditorView.inputHandler__>>) =
                emitJsExpr (value) $$"""
import { EditorView } from "@codemirror/view";
EditorView.inputHandler = $0"""
        /// <summary>
        /// Functions provided in this facet will be used to transform text
        /// pasted or dropped into the editor.
        /// </summary>
        static member inline clipboardInputFilter
            with get () : CodemirrorState.Facet<EditorView.clipboardInputFilter__, ReadonlyArray<EditorView.clipboardInputFilter__>> =
                emitJsExpr () $$"""
import { EditorView } from "@codemirror/view";
EditorView.clipboardInputFilter"""
            and set (value: CodemirrorState.Facet<EditorView.clipboardInputFilter__, ReadonlyArray<EditorView.clipboardInputFilter__>>) =
                emitJsExpr (value) $$"""
import { EditorView } from "@codemirror/view";
EditorView.clipboardInputFilter = $0"""
        /// <summary>
        /// Transform text copied or dragged from the editor.
        /// </summary>
        static member inline clipboardOutputFilter
            with get () : CodemirrorState.Facet<EditorView.clipboardOutputFilter__, ReadonlyArray<EditorView.clipboardOutputFilter__>> =
                emitJsExpr () $$"""
import { EditorView } from "@codemirror/view";
EditorView.clipboardOutputFilter"""
            and set (value: CodemirrorState.Facet<EditorView.clipboardOutputFilter__, ReadonlyArray<EditorView.clipboardOutputFilter__>>) =
                emitJsExpr (value) $$"""
import { EditorView } from "@codemirror/view";
EditorView.clipboardOutputFilter = $0"""
        /// <summary>
        /// Scroll handlers can override how things are scrolled into view.
        /// If they return <c>true</c>, no further handling happens for the
        /// scrolling. If they return false, the default scroll behavior is
        /// applied. Scroll handlers should never initiate editor updates.
        /// </summary>
        static member inline scrollHandler
            with get () : CodemirrorState.Facet<EditorView.scrollHandler__, ReadonlyArray<EditorView.scrollHandler___1>> =
                emitJsExpr () $$"""
import { EditorView } from "@codemirror/view";
EditorView.scrollHandler"""
            and set (value: CodemirrorState.Facet<EditorView.scrollHandler__, ReadonlyArray<EditorView.scrollHandler___1>>) =
                emitJsExpr (value) $$"""
import { EditorView } from "@codemirror/view";
EditorView.scrollHandler = $0"""
        /// <summary>
        /// This facet can be used to provide functions that create effects
        /// to be dispatched when the editor's focus state changes.
        /// </summary>
        static member inline focusChangeEffect
            with get () : CodemirrorState.Facet<EditorView.focusChangeEffect__, ReadonlyArray<EditorView.focusChangeEffect__>> =
                emitJsExpr () $$"""
import { EditorView } from "@codemirror/view";
EditorView.focusChangeEffect"""
            and set (value: CodemirrorState.Facet<EditorView.focusChangeEffect__, ReadonlyArray<EditorView.focusChangeEffect__>>) =
                emitJsExpr (value) $$"""
import { EditorView } from "@codemirror/view";
EditorView.focusChangeEffect = $0"""
        /// <summary>
        /// By default, the editor assumes all its content has the same
        /// [text direction](https://codemirror.net/6/docs/ref/#view.Direction). Configure this with a <c>true</c>
        /// value to make it read the text direction of every (rendered)
        /// line separately.
        /// </summary>
        static member inline perLineTextDirection
            with get () : CodemirrorState.Facet<bool, bool> =
                emitJsExpr () $$"""
import { EditorView } from "@codemirror/view";
EditorView.perLineTextDirection"""
            and set (value: CodemirrorState.Facet<bool, bool>) =
                emitJsExpr (value) $$"""
import { EditorView } from "@codemirror/view";
EditorView.perLineTextDirection = $0"""
        /// <summary>
        /// Allows you to provide a function that should be called when the
        /// library catches an exception from an extension (mostly from view
        /// plugins, but may be used by other extensions to route exceptions
        /// from user-code-provided callbacks). This is mostly useful for
        /// debugging and logging. See [<c>logException</c>](https://codemirror.net/6/docs/ref/#view.logException).
        /// </summary>
        static member inline exceptionSink
            with get () : CodemirrorState.Facet<(obj -> unit), ReadonlyArray<(obj -> unit)>> =
                emitJsExpr () $$"""
import { EditorView } from "@codemirror/view";
EditorView.exceptionSink"""
            and set (value: CodemirrorState.Facet<(obj -> unit), ReadonlyArray<(obj -> unit)>>) =
                emitJsExpr (value) $$"""
import { EditorView } from "@codemirror/view";
EditorView.exceptionSink = $0"""
        /// <summary>
        /// A facet that can be used to register a function to be called
        /// every time the view updates.
        /// </summary>
        static member inline updateListener
            with get () : CodemirrorState.Facet<(CodemirrorView.ViewUpdate -> unit), ReadonlyArray<(CodemirrorView.ViewUpdate -> unit)>> =
                emitJsExpr () $$"""
import { EditorView } from "@codemirror/view";
EditorView.updateListener"""
            and set (value: CodemirrorState.Facet<(CodemirrorView.ViewUpdate -> unit), ReadonlyArray<(CodemirrorView.ViewUpdate -> unit)>>) =
                emitJsExpr (value) $$"""
import { EditorView } from "@codemirror/view";
EditorView.updateListener = $0"""
        /// <summary>
        /// Facet that controls whether the editor content DOM is editable.
        /// When its highest-precedence value is <c>false</c>, the element will
        /// not have its <c>contenteditable</c> attribute set. (Note that this
        /// doesn't affect API calls that change the editor content, even
        /// when those are bound to keys or buttons. See the
        /// [<c>readOnly</c>](https://codemirror.net/6/docs/ref/#state.EditorState.readOnly) facet for that.)
        /// </summary>
        static member inline editable
            with get () : CodemirrorState.Facet<bool, bool> =
                emitJsExpr () $$"""
import { EditorView } from "@codemirror/view";
EditorView.editable"""
            and set (value: CodemirrorState.Facet<bool, bool>) =
                emitJsExpr (value) $$"""
import { EditorView } from "@codemirror/view";
EditorView.editable = $0"""
        /// <summary>
        /// Allows you to influence the way mouse selection happens. The
        /// functions in this facet will be called for a <c>mousedown</c> event
        /// on the editor, and can return an object that overrides the way a
        /// selection is computed from that mouse click or drag.
        /// </summary>
        static member inline mouseSelectionStyle
            with get () : CodemirrorState.Facet<CodemirrorView.MakeSelectionStyle, ReadonlyArray<CodemirrorView.MakeSelectionStyle>> =
                emitJsExpr () $$"""
import { EditorView } from "@codemirror/view";
EditorView.mouseSelectionStyle"""
            and set (value: CodemirrorState.Facet<CodemirrorView.MakeSelectionStyle, ReadonlyArray<CodemirrorView.MakeSelectionStyle>>) =
                emitJsExpr (value) $$"""
import { EditorView } from "@codemirror/view";
EditorView.mouseSelectionStyle = $0"""
        /// <summary>
        /// Facet used to configure whether a given selection drag event
        /// should move or copy the selection. The given predicate will be
        /// called with the <c>mousedown</c> event, and can return <c>true</c> when
        /// the drag should move the content.
        /// </summary>
        static member inline dragMovesSelection
            with get () : CodemirrorState.Facet<(Glutinum.Web.MouseEvent -> bool), ReadonlyArray<(Glutinum.Web.MouseEvent -> bool)>> =
                emitJsExpr () $$"""
import { EditorView } from "@codemirror/view";
EditorView.dragMovesSelection"""
            and set (value: CodemirrorState.Facet<(Glutinum.Web.MouseEvent -> bool), ReadonlyArray<(Glutinum.Web.MouseEvent -> bool)>>) =
                emitJsExpr (value) $$"""
import { EditorView } from "@codemirror/view";
EditorView.dragMovesSelection = $0"""
        /// <summary>
        /// Facet used to configure whether a given selecting click adds a
        /// new range to the existing selection or replaces it entirely. The
        /// default behavior is to check <c>event.metaKey</c> on macOS, and
        /// <c>event.ctrlKey</c> elsewhere.
        /// </summary>
        static member inline clickAddsSelectionRange
            with get () : CodemirrorState.Facet<(Glutinum.Web.MouseEvent -> bool), ReadonlyArray<(Glutinum.Web.MouseEvent -> bool)>> =
                emitJsExpr () $$"""
import { EditorView } from "@codemirror/view";
EditorView.clickAddsSelectionRange"""
            and set (value: CodemirrorState.Facet<(Glutinum.Web.MouseEvent -> bool), ReadonlyArray<(Glutinum.Web.MouseEvent -> bool)>>) =
                emitJsExpr (value) $$"""
import { EditorView } from "@codemirror/view";
EditorView.clickAddsSelectionRange = $0"""
        /// <summary>
        /// A facet that determines which [decorations](https://codemirror.net/6/docs/ref/#view.Decoration)
        /// are shown in the view. Decorations can be provided in two
        /// ways—directly, or via a function that takes an editor view.
        ///
        /// Only decoration sets provided directly are allowed to influence
        /// the editor's vertical layout structure. The ones provided as
        /// functions are called _after_ the new viewport has been computed,
        /// and thus **must not** introduce block widgets or replacing
        /// decorations that cover line breaks.
        ///
        /// If you want decorated ranges to behave like atomic units for
        /// cursor motion and deletion purposes, also provide the range set
        /// containing the decorations to
        /// [<c>EditorView.atomicRanges</c>](https://codemirror.net/6/docs/ref/#view.EditorView^atomicRanges).
        /// </summary>
        static member inline decorations
            with get () : CodemirrorState.Facet<U2<CodemirrorView.DecorationSet, (CodemirrorView.EditorView -> CodemirrorView.DecorationSet)>, ReadonlyArray<U2<CodemirrorView.DecorationSet, (CodemirrorView.EditorView -> CodemirrorView.DecorationSet)>>> =
                emitJsExpr () $$"""
import { EditorView } from "@codemirror/view";
EditorView.decorations"""
            and set (value: CodemirrorState.Facet<U2<CodemirrorView.DecorationSet, (CodemirrorView.EditorView -> CodemirrorView.DecorationSet)>, ReadonlyArray<U2<CodemirrorView.DecorationSet, (CodemirrorView.EditorView -> CodemirrorView.DecorationSet)>>>) =
                emitJsExpr (value) $$"""
import { EditorView } from "@codemirror/view";
EditorView.decorations = $0"""
        /// <summary>
        /// [Block wrappers](https://codemirror.net/6/docs/ref/#view.BlockWrapper) provide a way to add DOM
        /// structure around editor lines and block widgets. Sets of
        /// wrappers are provided in a similar way to decorations, and are
        /// nested in a similar way when they overlap. A wrapper affects all
        /// lines and block widgets that start inside its range.
        /// </summary>
        static member inline blockWrappers
            with get () : CodemirrorState.Facet<U2<CodemirrorState.RangeSet<CodemirrorView.BlockWrapper>, (CodemirrorView.EditorView -> CodemirrorState.RangeSet<CodemirrorView.BlockWrapper>)>, ReadonlyArray<U2<CodemirrorState.RangeSet<CodemirrorView.BlockWrapper>, (CodemirrorView.EditorView -> CodemirrorState.RangeSet<CodemirrorView.BlockWrapper>)>>> =
                emitJsExpr () $$"""
import { EditorView } from "@codemirror/view";
EditorView.blockWrappers"""
            and set (value: CodemirrorState.Facet<U2<CodemirrorState.RangeSet<CodemirrorView.BlockWrapper>, (CodemirrorView.EditorView -> CodemirrorState.RangeSet<CodemirrorView.BlockWrapper>)>, ReadonlyArray<U2<CodemirrorState.RangeSet<CodemirrorView.BlockWrapper>, (CodemirrorView.EditorView -> CodemirrorState.RangeSet<CodemirrorView.BlockWrapper>)>>>) =
                emitJsExpr (value) $$"""
import { EditorView } from "@codemirror/view";
EditorView.blockWrappers = $0"""
        /// <summary>
        /// Facet that works much like
        /// [<c>decorations</c>](https://codemirror.net/6/docs/ref/#view.EditorView^decorations), but puts its
        /// inputs at the very bottom of the precedence stack, meaning mark
        /// decorations provided here will only be split by other, partially
        /// overlapping <c>outerDecorations</c> ranges, and wrap around all
        /// regular decorations. Use this for mark elements that should, as
        /// much as possible, remain in one piece.
        /// </summary>
        static member inline outerDecorations
            with get () : CodemirrorState.Facet<U2<CodemirrorView.DecorationSet, (CodemirrorView.EditorView -> CodemirrorView.DecorationSet)>, ReadonlyArray<U2<CodemirrorView.DecorationSet, (CodemirrorView.EditorView -> CodemirrorView.DecorationSet)>>> =
                emitJsExpr () $$"""
import { EditorView } from "@codemirror/view";
EditorView.outerDecorations"""
            and set (value: CodemirrorState.Facet<U2<CodemirrorView.DecorationSet, (CodemirrorView.EditorView -> CodemirrorView.DecorationSet)>, ReadonlyArray<U2<CodemirrorView.DecorationSet, (CodemirrorView.EditorView -> CodemirrorView.DecorationSet)>>>) =
                emitJsExpr (value) $$"""
import { EditorView } from "@codemirror/view";
EditorView.outerDecorations = $0"""
        /// <summary>
        /// Used to provide ranges that should be treated as atoms as far as
        /// cursor motion is concerned. This causes methods like
        /// [<c>moveByChar</c>](https://codemirror.net/6/docs/ref/#view.EditorView.moveByChar) and
        /// [<c>moveVertically</c>](https://codemirror.net/6/docs/ref/#view.EditorView.moveVertically) (and the
        /// commands built on top of them) to skip across such regions when
        /// a selection endpoint would enter them. This does _not_ prevent
        /// direct programmatic [selection
        /// updates](https://codemirror.net/6/docs/ref/#state.TransactionSpec.selection) from moving into such
        /// regions.
        /// </summary>
        static member inline atomicRanges
            with get () : CodemirrorState.Facet<(CodemirrorView.EditorView -> CodemirrorState.RangeSet<obj>), ReadonlyArray<(CodemirrorView.EditorView -> CodemirrorState.RangeSet<obj>)>> =
                emitJsExpr () $$"""
import { EditorView } from "@codemirror/view";
EditorView.atomicRanges"""
            and set (value: CodemirrorState.Facet<(CodemirrorView.EditorView -> CodemirrorState.RangeSet<obj>), ReadonlyArray<(CodemirrorView.EditorView -> CodemirrorState.RangeSet<obj>)>>) =
                emitJsExpr (value) $$"""
import { EditorView } from "@codemirror/view";
EditorView.atomicRanges = $0"""
        /// <summary>
        /// When range decorations add a <c>unicode-bidi: isolate</c> style, they
        /// should also include a
        /// [<c>bidiIsolate</c>](https://codemirror.net/6/docs/ref/#view.MarkDecorationSpec.bidiIsolate) property
        /// in their decoration spec, and be exposed through this facet, so
        /// that the editor can compute the proper text order. (Other values
        /// for <c>unicode-bidi</c>, except of course <c>normal</c>, are not
        /// supported.)
        /// </summary>
        static member inline bidiIsolatedRanges
            with get () : CodemirrorState.Facet<U2<CodemirrorView.DecorationSet, (CodemirrorView.EditorView -> CodemirrorView.DecorationSet)>, ReadonlyArray<U2<CodemirrorView.DecorationSet, (CodemirrorView.EditorView -> CodemirrorView.DecorationSet)>>> =
                emitJsExpr () $$"""
import { EditorView } from "@codemirror/view";
EditorView.bidiIsolatedRanges"""
            and set (value: CodemirrorState.Facet<U2<CodemirrorView.DecorationSet, (CodemirrorView.EditorView -> CodemirrorView.DecorationSet)>, ReadonlyArray<U2<CodemirrorView.DecorationSet, (CodemirrorView.EditorView -> CodemirrorView.DecorationSet)>>>) =
                emitJsExpr (value) $$"""
import { EditorView } from "@codemirror/view";
EditorView.bidiIsolatedRanges = $0"""
        /// <summary>
        /// Can be used to specify the distance that scrolling cursor into
        /// view keeps it away from the sides of the editor, either as a
        /// single pixel number or two different values for the different
        /// axes. Defaults to 5 pixels on both axes.
        /// </summary>
        static member inline cursorScrollMargin
            with get () : CodemirrorState.Facet<U2<float, EditorView.cursorScrollMargin__.U2.Case2>, EditorView.cursorScrollMargin__> =
                emitJsExpr () $$"""
import { EditorView } from "@codemirror/view";
EditorView.cursorScrollMargin"""
            and set (value: CodemirrorState.Facet<U2<float, EditorView.cursorScrollMargin__.U2.Case2>, EditorView.cursorScrollMargin__>) =
                emitJsExpr (value) $$"""
import { EditorView } from "@codemirror/view";
EditorView.cursorScrollMargin = $0"""
        /// <summary>
        /// Facet that allows extensions to provide additional scroll
        /// margins (space around the sides of the scrolling element that
        /// should be considered invisible). This can be useful when the
        /// plugin introduces elements that cover part of that element (for
        /// example a horizontally fixed gutter). Not to be confused with
        /// [<c>cursorScrollMargin</c>](https://codemirror.net/6/docs/ref/#view.EditorView^cursorScrollMargin).
        /// </summary>
        static member inline scrollMargins
            with get () : CodemirrorState.Facet<(CodemirrorView.EditorView -> EditorView.scrollMargins__ option), ReadonlyArray<(CodemirrorView.EditorView -> EditorView.scrollMargins__ option)>> =
                emitJsExpr () $$"""
import { EditorView } from "@codemirror/view";
EditorView.scrollMargins"""
            and set (value: CodemirrorState.Facet<(CodemirrorView.EditorView -> EditorView.scrollMargins__ option), ReadonlyArray<(CodemirrorView.EditorView -> EditorView.scrollMargins__ option)>>) =
                emitJsExpr (value) $$"""
import { EditorView } from "@codemirror/view";
EditorView.scrollMargins = $0"""
        /// <summary>
        /// Create a theme extension. The first argument can be a
        /// [<c>style-mod</c>](https://code.haverbeke.berlin/marijn/style-mod#documentation)
        /// style spec providing the styles for the theme. These will be
        /// prefixed with a generated class for the style.
        ///
        /// Because the selectors will be prefixed with a scope class, rule
        /// that directly match the editor's [wrapper
        /// element](https://codemirror.net/6/docs/ref/#view.EditorView.dom)—to which the scope class will be
        /// added—need to be explicitly differentiated by adding an <c>&</c> to
        /// the selector for that element—for example
        /// <c>&.cm-focused</c>.
        ///
        /// When <c>dark</c> is set to true, the theme will be marked as dark,
        /// which will cause the <c>&dark</c> rules from [base
        /// themes](https://codemirror.net/6/docs/ref/#view.EditorView^baseTheme) to be used (as opposed to
        /// <c>&light</c> when a light theme is active).
        /// </summary>
        static member inline theme (spec: EditorView.theme__.spec, ?options: EditorView.theme__.options): CodemirrorState.Extension =
            emitJsExpr (spec, options) $$"""
import { EditorView } from "@codemirror/view";
EditorView.theme($0, $1)"""
        /// <summary>
        /// This facet records whether a dark theme is active. The extension
        /// returned by [<c>theme</c>](https://codemirror.net/6/docs/ref/#view.EditorView^theme) automatically
        /// includes an instance of this when the <c>dark</c> option is set to
        /// true.
        /// </summary>
        static member inline darkTheme
            with get () : CodemirrorState.Facet<bool, bool> =
                emitJsExpr () $$"""
import { EditorView } from "@codemirror/view";
EditorView.darkTheme"""
            and set (value: CodemirrorState.Facet<bool, bool>) =
                emitJsExpr (value) $$"""
import { EditorView } from "@codemirror/view";
EditorView.darkTheme = $0"""
        /// <summary>
        /// Create an extension that adds styles to the base theme. Like
        /// with [<c>theme</c>](https://codemirror.net/6/docs/ref/#view.EditorView^theme), use <c>&</c> to indicate the
        /// place of the editor wrapper element when directly targeting
        /// that. You can also use <c>&dark</c> or <c>&light</c> instead to only
        /// target editors with a dark or light theme.
        /// </summary>
        static member inline baseTheme (spec: EditorView.baseTheme__.spec): CodemirrorState.Extension =
            emitJsExpr (spec) $$"""
import { EditorView } from "@codemirror/view";
EditorView.baseTheme($0)"""
        /// <summary>
        /// Provides a Content Security Policy nonce to use when creating
        /// the style sheets for the editor. Holds the empty string when no
        /// nonce has been provided.
        /// </summary>
        static member inline cspNonce
            with get () : CodemirrorState.Facet<string, string> =
                emitJsExpr () $$"""
import { EditorView } from "@codemirror/view";
EditorView.cspNonce"""
            and set (value: CodemirrorState.Facet<string, string>) =
                emitJsExpr (value) $$"""
import { EditorView } from "@codemirror/view";
EditorView.cspNonce = $0"""
        /// <summary>
        /// Facet that provides additional DOM attributes for the editor's
        /// editable DOM element.
        /// </summary>
        static member inline contentAttributes
            with get () : CodemirrorState.Facet<CodemirrorView.AttrSource, ReadonlyArray<CodemirrorView.AttrSource>> =
                emitJsExpr () $$"""
import { EditorView } from "@codemirror/view";
EditorView.contentAttributes"""
            and set (value: CodemirrorState.Facet<CodemirrorView.AttrSource, ReadonlyArray<CodemirrorView.AttrSource>>) =
                emitJsExpr (value) $$"""
import { EditorView } from "@codemirror/view";
EditorView.contentAttributes = $0"""
        /// <summary>
        /// Facet that provides DOM attributes for the editor's outer
        /// element.
        /// </summary>
        static member inline editorAttributes
            with get () : CodemirrorState.Facet<CodemirrorView.AttrSource, ReadonlyArray<CodemirrorView.AttrSource>> =
                emitJsExpr () $$"""
import { EditorView } from "@codemirror/view";
EditorView.editorAttributes"""
            and set (value: CodemirrorState.Facet<CodemirrorView.AttrSource, ReadonlyArray<CodemirrorView.AttrSource>>) =
                emitJsExpr (value) $$"""
import { EditorView } from "@codemirror/view";
EditorView.editorAttributes = $0"""
        /// <summary>
        /// State effect used to include screen reader announcements in a
        /// transaction. These will be added to the DOM in a visually hidden
        /// element with <c>aria-live="polite"</c> set, and should be used to
        /// describe effects that are visually obvious but may not be
        /// noticed by screen reader users (such as moving to the next
        /// search match).
        /// </summary>
        static member inline announce
            with get () : CodemirrorState.StateEffectType<string> =
                emitJsExpr () $$"""
import { EditorView } from "@codemirror/view";
EditorView.announce"""
            and set (value: CodemirrorState.StateEffectType<string>) =
                emitJsExpr (value) $$"""
import { EditorView } from "@codemirror/view";
EditorView.announce = $0"""
        /// <summary>
        /// Retrieve an editor view instance from the view's DOM
        /// representation.
        /// </summary>
        static member inline findFromDOM (dom: Glutinum.Web.HTMLElement): CodemirrorView.EditorView option =
            emitJsExpr (dom) $$"""
import { EditorView } from "@codemirror/view";
EditorView.findFromDOM($0)"""

    /// <summary>
    /// Helper type that maps event names to event object types, or the
    /// <c>any</c> type for unknown events.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type DOMEventMap =
        inherit Glutinum.Web.HTMLElementEventMap
        [<EmitIndexer>]
        abstract member Item: other: string -> obj with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type DOMEventHandlers<'This> =
        interface end

    /// <summary>
    /// Key bindings associate key names with
    /// [command](https://codemirror.net/6/docs/ref/#view.Command)-style functions.
    ///
    /// Key names may be strings like <c>"Shift-Ctrl-Enter"</c>—a key identifier
    /// prefixed with zero or more modifiers. Key identifiers are based on
    /// the strings that can appear in
    /// [<c>KeyEvent.key</c>](https://developer.mozilla.org/en-US/docs/Web/API/KeyboardEvent/key).
    /// Use lowercase letters to refer to letter keys (or uppercase letters
    /// if you want shift to be held). You may use <c>"Space"</c> as an alias
    /// for the <c>" "</c> name.
    ///
    /// Modifiers can be given in any order. <c>Shift-</c> (or <c>s-</c>), <c>Alt-</c> (or
    /// <c>a-</c>), <c>Ctrl-</c> (or <c>c-</c> or <c>Control-</c>) and <c>Cmd-</c> (or <c>m-</c> or
    /// <c>Meta-</c>) are recognized.
    ///
    /// When a key binding contains multiple key names separated by
    /// spaces, it represents a multi-stroke binding, which will fire when
    /// the user presses the given keys after each other.
    ///
    /// You can use <c>Mod-</c> as a shorthand for <c>Cmd-</c> on Mac and <c>Ctrl-</c> on
    /// other platforms. So <c>Mod-b</c> is <c>Ctrl-b</c> on Linux but <c>Cmd-b</c> on
    /// macOS.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type KeyBinding =
        /// <summary>
        /// The key name to use for this binding. If the platform-specific
        /// property (<c>mac</c>, <c>win</c>, or <c>linux</c>) for the current platform is
        /// used as well in the binding, that one takes precedence. If <c>key</c>
        /// isn't defined and the platform-specific binding isn't either,
        /// a binding is ignored.
        /// </summary>
        abstract member key: string option with get, set
        /// <summary>
        /// Key to use specifically on macOS.
        /// </summary>
        abstract member mac: string option with get, set
        /// <summary>
        /// Key to use specifically on Windows.
        /// </summary>
        abstract member win: string option with get, set
        /// <summary>
        /// Key to use specifically on Linux.
        /// </summary>
        abstract member linux: string option with get, set
        /// <summary>
        /// The command to execute when this binding is triggered. When the
        /// command function returns <c>false</c>, further bindings will be tried
        /// for the key.
        /// </summary>
        abstract member run: CodemirrorView.Command option with get, set
        /// <summary>
        /// When given, this defines a second binding, using the (possibly
        /// platform-specific) key name prefixed with <c>Shift-</c> to activate
        /// this command.
        /// </summary>
        abstract member shift: CodemirrorView.Command option with get, set
        /// <summary>
        /// When this property is present, the function is called for every
        /// key that is not a multi-stroke prefix.
        /// </summary>
        abstract member any: KeyBinding.any option with get, set
        /// <summary>
        /// By default, key bindings apply when focus is on the editor
        /// content (the <c>"editor"</c> scope). Some extensions, mostly those
        /// that define their own panels, might want to allow you to
        /// register bindings local to that panel. Such bindings should use
        /// a custom scope name. You may also assign multiple scope names to
        /// a binding, separating them by spaces.
        /// </summary>
        abstract member scope: string option with get, set
        /// <summary>
        /// When set to true (the default is false), this will always
        /// prevent the further handling for the bound key, even if the
        /// command(s) return false. This can be useful for cases where the
        /// native behavior of the key is annoying or irrelevant but the
        /// command doesn't always apply (such as, Mod-u for undo selection,
        /// which would cause the browser to view source instead when no
        /// selection can be undone).
        /// </summary>
        abstract member preventDefault: bool option with get, set
        /// <summary>
        /// When set to true, <c>stopPropagation</c> will be called on keyboard
        /// events that have their <c>preventDefault</c> called in response to
        /// this key binding (see also
        /// [<c>preventDefault</c>](https://codemirror.net/6/docs/ref/#view.KeyBinding.preventDefault)).
        /// </summary>
        abstract member stopPropagation: bool option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type SelectionConfig =
        /// <summary>
        /// The length of a full cursor blink cycle, in milliseconds.
        /// Defaults to 1200. Can be set to 0 to disable blinking.
        /// </summary>
        abstract member cursorBlinkRate: float option with get, set
        /// <summary>
        /// Whether to show a cursor for non-empty ranges. Defaults to
        /// true.
        /// </summary>
        abstract member drawRangeCursor: bool option with get, set
        /// <summary>
        /// Because hiding the cursor also hides the selection handles in
        /// the iOS browser, when this is enabled (the default), the
        /// extension draws handles on the side of the selection in iOS.
        /// </summary>
        abstract member iosSelectionHandles: bool option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type SpecialCharConfig =
        /// <summary>
        /// An optional function that renders the placeholder elements.
        ///
        /// The <c>description</c> argument will be text that clarifies what the
        /// character is, which should be provided to screen readers (for
        /// example with the
        /// [<c>aria-label</c>](https://www.w3.org/TR/wai-aria/#aria-label)
        /// attribute) and optionally shown to the user in other ways (such
        /// as the
        /// [<c>title</c>](https://developer.mozilla.org/en-US/docs/Web/HTML/Global_attributes/title)
        /// attribute).
        ///
        /// The given placeholder string is a suggestion for how to display
        /// the character visually.
        /// </summary>
        abstract member render: SpecialCharConfig.render option with get, set
        /// <summary>
        /// Regular expression that matches the special characters to
        /// highlight. Must have its 'g'/global flag set.
        /// </summary>
        abstract member specialChars: RegExp option with get, set
        /// <summary>
        /// Regular expression that can be used to add characters to the
        /// default set of characters to highlight.
        /// </summary>
        abstract member addSpecialChars: RegExp option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?render: SpecialCharConfig.render, ?specialChars: RegExp, ?addSpecialChars: RegExp) : SpecialCharConfig = nativeOnly

    /// <summary>
    /// Markers shown in a [layer](https://codemirror.net/6/docs/ref/#view.layer) must conform to this
    /// interface. They are created in a measuring phase, and have to
    /// contain all their positioning information, so that they can be
    /// drawn without further DOM layout reading.
    ///
    /// Markers are automatically absolutely positioned. Their parent
    /// element has the same top-left corner as the document, so they
    /// should be positioned relative to the document.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type LayerMarker =
        /// <summary>
        /// Compare this marker to a marker of the same type. Used to avoid
        /// unnecessary redraws.
        /// </summary>
        abstract member eq: other: CodemirrorView.LayerMarker -> bool
        /// <summary>
        /// Draw the marker to the DOM.
        /// </summary>
        abstract member draw: unit -> Glutinum.Web.HTMLElement
        /// <summary>
        /// Update an existing marker of this type to this marker.
        /// </summary>
        abstract member update: dom: Glutinum.Web.HTMLElement * oldMarker: CodemirrorView.LayerMarker -> bool

    /// <summary>
    /// Implementation of [<c>LayerMarker</c>](https://codemirror.net/6/docs/ref/#view.LayerMarker) that creates
    /// a rectangle at a given set of coordinates.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type RectangleMarker =
        inherit CodemirrorView.LayerMarker
        /// <summary>
        /// The left position of the marker (in pixels, document-relative).
        /// </summary>
        abstract member left: float with get
        /// <summary>
        /// The top position of the marker.
        /// </summary>
        abstract member top: float with get
        /// <summary>
        /// The width of the marker, or null if it shouldn't get a width assigned.
        /// </summary>
        abstract member width: float option with get
        /// <summary>
        /// The height of the marker.
        /// </summary>
        abstract member height: float with get
        /// <summary>
        /// Draw the marker to the DOM.
        /// </summary>
        abstract member draw: unit -> Glutinum.Web.HTMLDivElement
        /// <summary>
        /// Update an existing marker of this type to this marker.
        /// </summary>
        abstract member update: elt: Glutinum.Web.HTMLElement * prev: CodemirrorView.RectangleMarker -> bool
        /// <summary>
        /// Compare this marker to a marker of the same type. Used to avoid
        /// unnecessary redraws.
        /// </summary>
        abstract member eq: p: CodemirrorView.RectangleMarker -> bool
        /// <summary>
        /// Create a set of rectangles for the given selection range,
        /// assigning them theclass<c>className</c>. Will create a single
        /// rectangle for empty ranges, and a set of selection-style
        /// rectangles covering the range's content (in a bidi-aware
        /// way) for non-empty ones.
        /// </summary>
        static member inline forRange (view: CodemirrorView.EditorView, className: string, range: CodemirrorState.SelectionRange): ReadonlyArray<CodemirrorView.RectangleMarker> =
            emitJsExpr (view, className, range) $$"""
import { RectangleMarker } from "@codemirror/view";
RectangleMarker.forRange($0, $1, $2)"""

    [<AllowNullLiteral>]
    [<Interface>]
    type LayerConfig =
        /// <summary>
        /// Determines whether this layer is shown above or below the text.
        /// </summary>
        abstract member above: bool with get, set
        /// <summary>
        /// When given, this class is added to the DOM element that will
        /// wrap the markers.
        /// </summary>
        abstract member ``class``: string option with get, set
        /// <summary>
        /// Called on every view update. Returning true triggers a marker
        /// update (a call to <c>markers</c> and drawing of those markers).
        /// </summary>
        abstract member update: update: CodemirrorView.ViewUpdate * layer: Glutinum.Web.HTMLElement -> bool
        /// <summary>
        /// Whether to update this layer every time the document view
        /// changes. Defaults to true.
        /// </summary>
        abstract member updateOnDocViewUpdate: bool option with get, set
        /// <summary>
        /// Build a set of markers for this layer, and measure their
        /// dimensions.
        /// </summary>
        abstract member markers: view: CodemirrorView.EditorView -> ReadonlyArray<CodemirrorView.LayerMarker>
        /// <summary>
        /// If given, this is called when the layer is created.
        /// </summary>
        abstract member mount: layer: Glutinum.Web.HTMLElement * view: CodemirrorView.EditorView -> unit
        /// <summary>
        /// If given, called when the layer is removed from the editor or
        /// the entire editor is destroyed.
        /// </summary>
        abstract member destroy: layer: Glutinum.Web.HTMLElement * view: CodemirrorView.EditorView -> unit

    /// <summary>
    /// Helper class used to make it easier to maintain decorations on
    /// visible code that matches a given regular expression. To be used
    /// in a [view plugin](https://codemirror.net/6/docs/ref/#view.ViewPlugin). Instances of this object
    /// represent a matching configuration.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type MatchDecorator =
        /// <summary>
        /// Compute the full set of decorations for matches in the given
        /// view's viewport. You'll want to call this when initializing your
        /// plugin.
        /// </summary>
        abstract member createDeco: view: CodemirrorView.EditorView -> CodemirrorState.RangeSet<CodemirrorView.Decoration>
        /// <summary>
        /// Update a set of decorations for a view update. <c>deco</c> _must_ be
        /// the set of decorations produced by _this_ <c>MatchDecorator</c> for
        /// the view state before the update.
        /// </summary>
        abstract member updateDeco: update: CodemirrorView.ViewUpdate * deco: CodemirrorView.DecorationSet -> CodemirrorView.DecorationSet

    /// <summary>
    /// Describes a tooltip. Values of this type, when provided through
    /// the [<c>showTooltip</c>](https://codemirror.net/6/docs/ref/#view.showTooltip) facet, control the
    /// individual tooltips on the editor.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type Tooltip =
        /// <summary>
        /// The document position at which to show the tooltip.
        /// </summary>
        abstract member pos: float with get, set
        /// <summary>
        /// The end of the range annotated by this tooltip, if different
        /// from <c>pos</c>.
        /// </summary>
        abstract member ``end``: float option with get, set
        /// <summary>
        /// A constructor function that creates the tooltip's [DOM
        /// representation](https://codemirror.net/6/docs/ref/#view.TooltipView).
        /// </summary>
        abstract member create: view: CodemirrorView.EditorView -> CodemirrorView.TooltipView
        /// <summary>
        /// Whether the tooltip should be shown above or below the target
        /// position. Not guaranteed to be respected for hover tooltips
        /// since all hover tooltips for the same range are always
        /// positioned together. Defaults to false.
        /// </summary>
        abstract member above: bool option with get, set
        /// <summary>
        /// Whether the <c>above</c> option should be honored when there isn't
        /// enough space on that side to show the tooltip inside the
        /// viewport. Defaults to false.
        /// </summary>
        abstract member strictSide: bool option with get, set
        /// <summary>
        /// When set to true, show a triangle connecting the tooltip element
        /// to position <c>pos</c>.
        /// </summary>
        abstract member arrow: bool option with get, set
        /// <summary>
        /// By default, tooltips are hidden when their position is outside
        /// of the visible editor content. Set this to false to turn that
        /// off.
        /// </summary>
        abstract member clip: bool option with get, set

    /// <summary>
    /// Describes the way a tooltip is displayed.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type TooltipView =
        /// <summary>
        /// The DOM element to position over the editor.
        /// </summary>
        abstract member dom: Glutinum.Web.HTMLElement with get, set
        /// <summary>
        /// Adjust the position of the tooltip relative to its anchor
        /// position. A positive <c>x</c> value will move the tooltip
        /// horizontally along with the text direction (so right in
        /// left-to-right context, left in right-to-left). A positive <c>y</c>
        /// will move the tooltip up when it is above its anchor, and down
        /// otherwise.
        /// </summary>
        abstract member offset: TooltipView.offset option with get, set
        /// <summary>
        /// By default, a tooltip's screen position will be based on the
        /// text position of its <c>pos</c> property. This method can be provided
        /// to make the tooltip view itself responsible for finding its
        /// screen position.
        /// </summary>
        abstract member getCoords: (float -> CodemirrorView.Rect) option with get, set
        /// <summary>
        /// By default, tooltips are moved when they overlap with other
        /// tooltips. Set this to <c>true</c> to disable that behavior for this
        /// tooltip.
        /// </summary>
        abstract member overlap: bool option with get, set
        /// <summary>
        /// Called after the tooltip is added to the DOM for the first time.
        /// </summary>
        abstract member mount: view: CodemirrorView.EditorView -> unit
        /// <summary>
        /// Update the DOM element for a change in the view's state.
        /// </summary>
        abstract member update: update: CodemirrorView.ViewUpdate -> unit
        /// <summary>
        /// Called when the tooltip is removed from the editor or the editor
        /// is destroyed.
        /// </summary>
        abstract member destroy: unit -> unit
        /// <summary>
        /// Called when the tooltip has been (re)positioned. The argument is
        /// the [space](https://codemirror.net/6/docs/ref/#view.tooltips^config.tooltipSpace) available to the
        /// tooltip.
        /// </summary>
        abstract member positioned: space: CodemirrorView.Rect -> unit
        /// <summary>
        /// By default, the library will restrict the size of tooltips so
        /// that they don't stick out of the available space. Set this to
        /// false to disable that.
        /// </summary>
        abstract member resize: bool option with get, set

    /// <summary>
    /// The type of function that can be used as a [hover tooltip
    /// source](https://codemirror.net/6/docs/ref/#view.hoverTooltip^source).
    /// </summary>
    type HoverTooltipSource =
        delegate of view: CodemirrorView.EditorView * pos: float * side: HoverTooltipSource.side -> U3<CodemirrorView.Tooltip, ReadonlyArray<CodemirrorView.Tooltip>, JS.Promise<U2<CodemirrorView.Tooltip, ReadonlyArray<CodemirrorView.Tooltip>> option>> option

    [<AllowNullLiteral>]
    [<Interface>]
    type PanelConfig =
        /// <summary>
        /// By default, panels will be placed inside the editor's DOM
        /// structure. You can use this option to override where panels with
        /// <c>top: true</c> are placed.
        /// </summary>
        abstract member topContainer: Glutinum.Web.HTMLElement option with get, set
        /// <summary>
        /// Override where panels with <c>top: false</c> are placed.
        /// </summary>
        abstract member bottomContainer: Glutinum.Web.HTMLElement option with get, set

    /// <summary>
    /// Object that describes an active panel.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type Panel =
        /// <summary>
        /// The element representing this panel. The library will add the
        /// <c>"cm-panel"</c> DOM class to this.
        /// </summary>
        abstract member dom: Glutinum.Web.HTMLElement with get, set
        /// <summary>
        /// Optionally called after the panel has been added to the editor.
        /// </summary>
        abstract member mount: unit -> unit
        /// <summary>
        /// Update the DOM for a given view update.
        /// </summary>
        abstract member update: update: CodemirrorView.ViewUpdate -> unit
        /// <summary>
        /// Called when the panel is removed from the editor or the editor
        /// is destroyed.
        /// </summary>
        abstract member destroy: unit -> unit
        /// <summary>
        /// Whether the panel should be at the top or bottom of the editor.
        /// Defaults to false.
        /// </summary>
        abstract member top: bool option with get, set

    /// <summary>
    /// A function that initializes a panel. Used in
    /// [<c>showPanel</c>](https://codemirror.net/6/docs/ref/#view.showPanel).
    /// </summary>
    type PanelConstructor =
        delegate of view: CodemirrorView.EditorView -> CodemirrorView.Panel

    [<AllowNullLiteral>]
    [<Interface>]
    type DialogConfig =
        /// <summary>
        /// A function to render the content of the dialog. The result
        /// should contain at least one <c><form></c> element. Submit handlers
        /// and a handler for the Escape key will be added to the form.
        ///
        /// If this is not given, the <c>label</c>, <c>input</c>, and <c>submitLabel</c>
        /// fields will be used to create a simple form for you.
        /// </summary>
        abstract member content: DialogConfig.content option with get, set
        /// <summary>
        /// When <c>content</c> isn't given, this provides the text shown in the
        /// dialog.
        /// </summary>
        abstract member label: string option with get, set
        /// <summary>
        /// The attributes for an input element shown next to the label. If
        /// not given, no input element is added.
        /// </summary>
        abstract member input: DialogConfig.input option with get, set
        /// <summary>
        /// The label for the button that submits the form. Defaults to
        /// <c>"OK"</c>.
        /// </summary>
        abstract member submitLabel: string option with get, set
        /// <summary>
        /// Extra classes to add to the panel.
        /// </summary>
        abstract member ``class``: string option with get, set
        /// <summary>
        /// A query selector to find the field that should be focused when
        /// the dialog is opened. When set to true, this picks the first
        /// <c><input></c> or <c><button></c> element in the form.
        /// </summary>
        abstract member focus: U2<string, bool> option with get, set
        /// <summary>
        /// By default, dialogs are shown below the editor. Set this to
        /// <c>true</c> to have it show up at the top.
        /// </summary>
        abstract member top: bool option with get, set

    /// <summary>
    /// A gutter marker represents a bit of information attached to a line
    /// in a specific gutter. Your own custom markers have to extend this
    /// class.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type GutterMarker =
        inherit CodemirrorState.RangeValue
        /// <summary>
        /// Compare this marker to another marker of the same type.
        /// </summary>
        abstract member eq: other: CodemirrorView.GutterMarker -> bool
        /// <summary>
        /// Render the DOM node for this marker, if any.
        /// </summary>
        abstract member toDOM: view: CodemirrorView.EditorView -> Glutinum.Web.Node
        /// <summary>
        /// This property can be used to add CSS classes to the gutter
        /// element that contains this marker.
        /// </summary>
        abstract member elementClass: string with get, set
        /// <summary>
        /// Called if the marker has a <c>toDOM</c> method and its representation
        /// was removed from a gutter.
        /// </summary>
        abstract member destroy: dom: Glutinum.Web.Node -> unit

    [<AllowNullLiteral>]
    [<Interface>]
    type Handlers =
        [<EmitIndexer>]
        abstract member Item: event: string -> Handlers.Item with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type GutterConfig =
        /// <summary>
        /// An extra CSS class to be added to the wrapper (<c>cm-gutter</c>)
        /// element.
        /// </summary>
        abstract member ``class``: string option with get, set
        /// <summary>
        /// Controls whether empty gutter elements should be rendered.
        /// Defaults to false.
        /// </summary>
        abstract member renderEmptyElements: bool option with get, set
        /// <summary>
        /// Retrieve a set of markers to use in this gutter.
        /// </summary>
        abstract member markers: (CodemirrorView.EditorView -> U2<CodemirrorState.RangeSet<CodemirrorView.GutterMarker>, ReadonlyArray<CodemirrorState.RangeSet<CodemirrorView.GutterMarker>>>) option with get, set
        /// <summary>
        /// Can be used to optionally add a single marker to every line.
        /// </summary>
        abstract member lineMarker: GutterConfig.lineMarker option with get, set
        /// <summary>
        /// Associate markers with block widgets in the document.
        /// </summary>
        abstract member widgetMarker: GutterConfig.widgetMarker option with get, set
        /// <summary>
        /// If line or widget markers depend on additional state, and should
        /// be updated when that changes, pass a predicate here that checks
        /// whether a given view update might change the line markers.
        /// </summary>
        abstract member lineMarkerChange: (CodemirrorView.ViewUpdate -> bool) option with get, set
        /// <summary>
        /// Add a hidden spacer element that gives the gutter its base
        /// width.
        /// </summary>
        abstract member initialSpacer: (CodemirrorView.EditorView -> CodemirrorView.GutterMarker) option with get, set
        /// <summary>
        /// Update the spacer element when the view is updated.
        /// </summary>
        abstract member updateSpacer: GutterConfig.updateSpacer option with get, set
        /// <summary>
        /// Supply event handlers for DOM events on this gutter.
        /// </summary>
        abstract member domEventHandlers: CodemirrorView.Handlers option with get, set
        /// <summary>
        /// By default, gutters are shown horizontally before the editor
        /// content (to the left in a left-to-right layout). Set this to
        /// <c>"after"</c> to show a gutter on the other side of the content.
        /// </summary>
        abstract member side: GutterConfig.side option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?``class``: string, ?renderEmptyElements: bool, ?markers: (CodemirrorView.EditorView -> U2<CodemirrorState.RangeSet<CodemirrorView.GutterMarker>, ReadonlyArray<CodemirrorState.RangeSet<CodemirrorView.GutterMarker>>>), ?lineMarker: GutterConfig.lineMarker, ?widgetMarker: GutterConfig.widgetMarker, ?lineMarkerChange: (CodemirrorView.ViewUpdate -> bool), ?initialSpacer: (CodemirrorView.EditorView -> CodemirrorView.GutterMarker), ?updateSpacer: GutterConfig.updateSpacer, ?domEventHandlers: CodemirrorView.Handlers, ?side: GutterConfig.side) : GutterConfig = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type LineNumberConfig =
        /// <summary>
        /// How to display line numbers. Defaults to simply converting them
        /// to string.
        /// </summary>
        abstract member formatNumber: LineNumberConfig.formatNumber option with get, set
        /// <summary>
        /// Supply event handlers for DOM events on this gutter.
        /// </summary>
        abstract member domEventHandlers: CodemirrorView.Handlers option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?formatNumber: LineNumberConfig.formatNumber, ?domEventHandlers: CodemirrorView.Handlers) : LineNumberConfig = nativeOnly

    module MarkDecorationSpec =

        [<AllowNullLiteral>]
        [<Interface>]
        type attributes =
            [<EmitIndexer>]
            abstract member Item: key: string -> string with get, set

    module LineDecorationSpec =

        [<AllowNullLiteral>]
        [<Interface>]
        type attributes =
            [<EmitIndexer>]
            abstract member Item: key: string -> string with get, set

    module BlockWrapperSpec =

        [<AllowNullLiteral>]
        [<Interface>]
        type attributes =
            [<EmitIndexer>]
            abstract member Item: key: string -> string with get, set

    module ViewPlugin =

        module define__ =

            type create<'V, 'Arg> =
                delegate of view: CodemirrorView.EditorView * arg: 'Arg -> 'V

        module fromClass__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type cls<'V, 'Arg> =
                [<EmitConstructor>]
                abstract member Create: view: CodemirrorView.EditorView * arg: 'Arg -> 'V

    module MouseSelectionStyle =

        type get =
            delegate of curEvent: Glutinum.Web.MouseEvent * extend: bool * multiple: bool -> CodemirrorState.EditorSelection

    module EditorViewConfig =

        type dispatchTransactions =
            delegate of trs: ResizeArray<CodemirrorState.Transaction> * view: CodemirrorView.EditorView -> unit

        type dispatch =
            delegate of tr: CodemirrorState.Transaction * view: CodemirrorView.EditorView -> unit

        module selection =

            module U2 =

                [<AllowNullLiteral>]
                [<Interface>]
                type Case2 =
                    abstract member anchor: float with get, set
                    abstract member head: float option with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (anchor: float, ?head: float) : Case2 = nativeOnly

    module EditorView =

        [<AllowNullLiteral>]
        [<Interface>]
        type viewport =
            abstract member from: float with get, set
            abstract member ``to``: float with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (from: float, ``to``: float) : viewport = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type visibleRanges =
            abstract member from: float with get, set
            abstract member ``to``: float with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (from: float, ``to``: float) : visibleRanges = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type documentPadding =
            abstract member top: float with get, set
            abstract member bottom: float with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (top: float, bottom: float) : documentPadding = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type domAtPos =
            abstract member node: Glutinum.Web.Node with get, set
            abstract member offset: float with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (node: Glutinum.Web.Node, offset: float) : domAtPos = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type posAndSideAtCoords =
            abstract member pos: float with get, set
            abstract member assoc: EditorView.posAndSideAtCoords.assoc with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (pos: float, assoc: EditorView.posAndSideAtCoords.assoc) : posAndSideAtCoords = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type posAndSideAtCoords_1 =
            abstract member pos: float with get, set
            abstract member assoc: EditorView.posAndSideAtCoords.assoc with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (pos: float, assoc: EditorView.posAndSideAtCoords.assoc) : posAndSideAtCoords_1 = nativeOnly

        type inputHandler__ =
            delegate of view: CodemirrorView.EditorView * from: float * ``to``: float * text: string * insert: (unit -> CodemirrorState.Transaction) -> bool

        type clipboardInputFilter__ =
            delegate of text: string * state: CodemirrorState.EditorState -> string

        type clipboardOutputFilter__ =
            delegate of text: string * state: CodemirrorState.EditorState -> string

        type scrollHandler__ =
            delegate of view: CodemirrorView.EditorView * range: CodemirrorState.SelectionRange * options: EditorView.scrollHandler__.options -> bool

        type scrollHandler___1 =
            delegate of view: CodemirrorView.EditorView * range: CodemirrorState.SelectionRange * options: EditorView.scrollHandler__.options_1 -> bool

        type focusChangeEffect__ =
            delegate of state: CodemirrorState.EditorState * focusing: bool -> CodemirrorState.StateEffect<obj> option

        [<AllowNullLiteral>]
        [<Interface>]
        type cursorScrollMargin__ =
            abstract member x: float with get, set
            abstract member y: float with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (x: float, y: float) : cursorScrollMargin__ = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type scrollMargins__ =
            abstract member left: float option with get
            abstract member right: float option with get
            abstract member top: float option with get
            abstract member bottom: float option with get

        module domAtPos =

            [<RequireQualifiedAccess>]
            type side =
                | _MINUS_1 = -1
                | ``1`` = 1

        module posAtCoords =

            [<AllowNullLiteral>]
            [<Interface>]
            type coords =
                abstract member x: float with get, set
                abstract member y: float with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (x: float, y: float) : coords = nativeOnly

            [<AllowNullLiteral>]
            [<Interface>]
            type coords_1 =
                abstract member x: float with get, set
                abstract member y: float with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (x: float, y: float) : coords_1 = nativeOnly

        module posAndSideAtCoords =

            [<AllowNullLiteral>]
            [<Interface>]
            type coords =
                abstract member x: float with get, set
                abstract member y: float with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (x: float, y: float) : coords = nativeOnly

            [<RequireQualifiedAccess>]
            type assoc =
                | _MINUS_1 = -1
                | ``1`` = 1

            [<AllowNullLiteral>]
            [<Interface>]
            type coords_1 =
                abstract member x: float with get, set
                abstract member y: float with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (x: float, y: float) : coords_1 = nativeOnly

        module coordsAtPos =

            [<RequireQualifiedAccess>]
            type side =
                | _MINUS_1 = -1
                | ``1`` = 1

        module scrollIntoView__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                /// <summary>
                /// By default (<c>"nearest"</c>) the position will be vertically
                /// scrolled only the minimal amount required to move the given
                /// position into view. You can set this to <c>"start"</c> to move it
                /// to the top of the view, <c>"end"</c> to move it to the bottom, or
                /// <c>"center"</c> to move it to the center.
                /// </summary>
                abstract member y: CodemirrorView.ScrollStrategy option with get, set
                /// <summary>
                /// Effect similar to
                /// [<c>y</c>](https://codemirror.net/6/docs/ref/#view.EditorView^scrollIntoView^options.y), but for the
                /// horizontal scroll position.
                /// </summary>
                abstract member x: CodemirrorView.ScrollStrategy option with get, set
                /// <summary>
                /// Extra vertical distance to add when moving something into
                /// view. Not used with the <c>"center"</c> strategy. Defaults to 5.
                /// Must be less than the height of the editor.
                /// </summary>
                abstract member yMargin: float option with get, set
                /// <summary>
                /// Extra horizontal distance to add. Not used with the <c>"center"</c>
                /// strategy. Defaults to 5. Must be less than the width of the
                /// editor.
                /// </summary>
                abstract member xMargin: float option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?y: CodemirrorView.ScrollStrategy, ?x: CodemirrorView.ScrollStrategy, ?yMargin: float, ?xMargin: float) : options = nativeOnly

        module domEventHandlers__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type handlers =
                abstract member fullscreenchange: EditorView.domEventHandlers__.handlers.fullscreenchange option with get, set
                abstract member fullscreenerror: EditorView.domEventHandlers__.handlers.fullscreenerror option with get, set
                abstract member abort: EditorView.domEventHandlers__.handlers.abort option with get, set
                abstract member animationcancel: EditorView.domEventHandlers__.handlers.animationcancel option with get, set
                abstract member animationend: EditorView.domEventHandlers__.handlers.animationend option with get, set
                abstract member animationiteration: EditorView.domEventHandlers__.handlers.animationiteration option with get, set
                abstract member animationstart: EditorView.domEventHandlers__.handlers.animationstart option with get, set
                abstract member auxclick: EditorView.domEventHandlers__.handlers.auxclick option with get, set
                abstract member beforeinput: EditorView.domEventHandlers__.handlers.beforeinput option with get, set
                abstract member blur: EditorView.domEventHandlers__.handlers.blur option with get, set
                abstract member cancel: EditorView.domEventHandlers__.handlers.cancel option with get, set
                abstract member canplay: EditorView.domEventHandlers__.handlers.canplay option with get, set
                abstract member canplaythrough: EditorView.domEventHandlers__.handlers.canplaythrough option with get, set
                abstract member change: EditorView.domEventHandlers__.handlers.change option with get, set
                abstract member click: EditorView.domEventHandlers__.handlers.click option with get, set
                abstract member close: EditorView.domEventHandlers__.handlers.close option with get, set
                abstract member compositionend: EditorView.domEventHandlers__.handlers.compositionend option with get, set
                abstract member compositionstart: EditorView.domEventHandlers__.handlers.compositionstart option with get, set
                abstract member compositionupdate: EditorView.domEventHandlers__.handlers.compositionupdate option with get, set
                abstract member contextmenu: EditorView.domEventHandlers__.handlers.contextmenu option with get, set
                abstract member copy: EditorView.domEventHandlers__.handlers.copy option with get, set
                abstract member cuechange: EditorView.domEventHandlers__.handlers.cuechange option with get, set
                abstract member cut: EditorView.domEventHandlers__.handlers.cut option with get, set
                abstract member dblclick: EditorView.domEventHandlers__.handlers.dblclick option with get, set
                abstract member drag: EditorView.domEventHandlers__.handlers.drag option with get, set
                abstract member dragend: EditorView.domEventHandlers__.handlers.dragend option with get, set
                abstract member dragenter: EditorView.domEventHandlers__.handlers.dragenter option with get, set
                abstract member dragleave: EditorView.domEventHandlers__.handlers.dragleave option with get, set
                abstract member dragover: EditorView.domEventHandlers__.handlers.dragover option with get, set
                abstract member dragstart: EditorView.domEventHandlers__.handlers.dragstart option with get, set
                abstract member drop: EditorView.domEventHandlers__.handlers.drop option with get, set
                abstract member durationchange: EditorView.domEventHandlers__.handlers.durationchange option with get, set
                abstract member emptied: EditorView.domEventHandlers__.handlers.emptied option with get, set
                abstract member ended: EditorView.domEventHandlers__.handlers.ended option with get, set
                abstract member error: EditorView.domEventHandlers__.handlers.error option with get, set
                abstract member focus: EditorView.domEventHandlers__.handlers.focus option with get, set
                abstract member focusin: EditorView.domEventHandlers__.handlers.focusin option with get, set
                abstract member focusout: EditorView.domEventHandlers__.handlers.focusout option with get, set
                abstract member formdata: EditorView.domEventHandlers__.handlers.formdata option with get, set
                abstract member gotpointercapture: EditorView.domEventHandlers__.handlers.gotpointercapture option with get, set
                abstract member input: EditorView.domEventHandlers__.handlers.input option with get, set
                abstract member invalid: EditorView.domEventHandlers__.handlers.invalid option with get, set
                abstract member keydown: EditorView.domEventHandlers__.handlers.keydown option with get, set
                abstract member keypress: EditorView.domEventHandlers__.handlers.keypress option with get, set
                abstract member keyup: EditorView.domEventHandlers__.handlers.keyup option with get, set
                abstract member load: EditorView.domEventHandlers__.handlers.load option with get, set
                abstract member loadeddata: EditorView.domEventHandlers__.handlers.loadeddata option with get, set
                abstract member loadedmetadata: EditorView.domEventHandlers__.handlers.loadedmetadata option with get, set
                abstract member loadstart: EditorView.domEventHandlers__.handlers.loadstart option with get, set
                abstract member lostpointercapture: EditorView.domEventHandlers__.handlers.lostpointercapture option with get, set
                abstract member mousedown: EditorView.domEventHandlers__.handlers.mousedown option with get, set
                abstract member mouseenter: EditorView.domEventHandlers__.handlers.mouseenter option with get, set
                abstract member mouseleave: EditorView.domEventHandlers__.handlers.mouseleave option with get, set
                abstract member mousemove: EditorView.domEventHandlers__.handlers.mousemove option with get, set
                abstract member mouseout: EditorView.domEventHandlers__.handlers.mouseout option with get, set
                abstract member mouseover: EditorView.domEventHandlers__.handlers.mouseover option with get, set
                abstract member mouseup: EditorView.domEventHandlers__.handlers.mouseup option with get, set
                abstract member paste: EditorView.domEventHandlers__.handlers.paste option with get, set
                abstract member pause: EditorView.domEventHandlers__.handlers.pause option with get, set
                abstract member play: EditorView.domEventHandlers__.handlers.play option with get, set
                abstract member playing: EditorView.domEventHandlers__.handlers.playing option with get, set
                abstract member pointercancel: EditorView.domEventHandlers__.handlers.pointercancel option with get, set
                abstract member pointerdown: EditorView.domEventHandlers__.handlers.pointerdown option with get, set
                abstract member pointerenter: EditorView.domEventHandlers__.handlers.pointerenter option with get, set
                abstract member pointerleave: EditorView.domEventHandlers__.handlers.pointerleave option with get, set
                abstract member pointermove: EditorView.domEventHandlers__.handlers.pointermove option with get, set
                abstract member pointerout: EditorView.domEventHandlers__.handlers.pointerout option with get, set
                abstract member pointerover: EditorView.domEventHandlers__.handlers.pointerover option with get, set
                abstract member pointerup: EditorView.domEventHandlers__.handlers.pointerup option with get, set
                abstract member progress: EditorView.domEventHandlers__.handlers.progress option with get, set
                abstract member ratechange: EditorView.domEventHandlers__.handlers.ratechange option with get, set
                abstract member reset: EditorView.domEventHandlers__.handlers.reset option with get, set
                abstract member resize: EditorView.domEventHandlers__.handlers.resize option with get, set
                abstract member scroll: EditorView.domEventHandlers__.handlers.scroll option with get, set
                abstract member scrollend: EditorView.domEventHandlers__.handlers.scrollend option with get, set
                abstract member securitypolicyviolation: EditorView.domEventHandlers__.handlers.securitypolicyviolation option with get, set
                abstract member seeked: EditorView.domEventHandlers__.handlers.seeked option with get, set
                abstract member seeking: EditorView.domEventHandlers__.handlers.seeking option with get, set
                abstract member select: EditorView.domEventHandlers__.handlers.select option with get, set
                abstract member selectionchange: EditorView.domEventHandlers__.handlers.selectionchange option with get, set
                abstract member selectstart: EditorView.domEventHandlers__.handlers.selectstart option with get, set
                abstract member slotchange: EditorView.domEventHandlers__.handlers.slotchange option with get, set
                abstract member stalled: EditorView.domEventHandlers__.handlers.stalled option with get, set
                abstract member submit: EditorView.domEventHandlers__.handlers.submit option with get, set
                abstract member suspend: EditorView.domEventHandlers__.handlers.suspend option with get, set
                abstract member timeupdate: EditorView.domEventHandlers__.handlers.timeupdate option with get, set
                abstract member toggle: EditorView.domEventHandlers__.handlers.toggle option with get, set
                abstract member touchcancel: EditorView.domEventHandlers__.handlers.touchcancel option with get, set
                abstract member touchend: EditorView.domEventHandlers__.handlers.touchend option with get, set
                abstract member touchmove: EditorView.domEventHandlers__.handlers.touchmove option with get, set
                abstract member touchstart: EditorView.domEventHandlers__.handlers.touchstart option with get, set
                abstract member transitioncancel: EditorView.domEventHandlers__.handlers.transitioncancel option with get, set
                abstract member transitionend: EditorView.domEventHandlers__.handlers.transitionend option with get, set
                abstract member transitionrun: EditorView.domEventHandlers__.handlers.transitionrun option with get, set
                abstract member transitionstart: EditorView.domEventHandlers__.handlers.transitionstart option with get, set
                abstract member volumechange: EditorView.domEventHandlers__.handlers.volumechange option with get, set
                abstract member waiting: EditorView.domEventHandlers__.handlers.waiting option with get, set
                abstract member webkitanimationend: EditorView.domEventHandlers__.handlers.webkitanimationend option with get, set
                abstract member webkitanimationiteration: EditorView.domEventHandlers__.handlers.webkitanimationiteration option with get, set
                abstract member webkitanimationstart: EditorView.domEventHandlers__.handlers.webkitanimationstart option with get, set
                abstract member webkittransitionend: EditorView.domEventHandlers__.handlers.webkittransitionend option with get, set
                abstract member wheel: EditorView.domEventHandlers__.handlers.wheel option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?fullscreenchange: EditorView.domEventHandlers__.handlers.fullscreenchange, ?fullscreenerror: EditorView.domEventHandlers__.handlers.fullscreenerror, ?abort: EditorView.domEventHandlers__.handlers.abort, ?animationcancel: EditorView.domEventHandlers__.handlers.animationcancel, ?animationend: EditorView.domEventHandlers__.handlers.animationend, ?animationiteration: EditorView.domEventHandlers__.handlers.animationiteration, ?animationstart: EditorView.domEventHandlers__.handlers.animationstart, ?auxclick: EditorView.domEventHandlers__.handlers.auxclick, ?beforeinput: EditorView.domEventHandlers__.handlers.beforeinput, ?blur: EditorView.domEventHandlers__.handlers.blur, ?cancel: EditorView.domEventHandlers__.handlers.cancel, ?canplay: EditorView.domEventHandlers__.handlers.canplay, ?canplaythrough: EditorView.domEventHandlers__.handlers.canplaythrough, ?change: EditorView.domEventHandlers__.handlers.change, ?click: EditorView.domEventHandlers__.handlers.click, ?close: EditorView.domEventHandlers__.handlers.close, ?compositionend: EditorView.domEventHandlers__.handlers.compositionend, ?compositionstart: EditorView.domEventHandlers__.handlers.compositionstart, ?compositionupdate: EditorView.domEventHandlers__.handlers.compositionupdate, ?contextmenu: EditorView.domEventHandlers__.handlers.contextmenu, ?copy: EditorView.domEventHandlers__.handlers.copy, ?cuechange: EditorView.domEventHandlers__.handlers.cuechange, ?cut: EditorView.domEventHandlers__.handlers.cut, ?dblclick: EditorView.domEventHandlers__.handlers.dblclick, ?drag: EditorView.domEventHandlers__.handlers.drag, ?dragend: EditorView.domEventHandlers__.handlers.dragend, ?dragenter: EditorView.domEventHandlers__.handlers.dragenter, ?dragleave: EditorView.domEventHandlers__.handlers.dragleave, ?dragover: EditorView.domEventHandlers__.handlers.dragover, ?dragstart: EditorView.domEventHandlers__.handlers.dragstart, ?drop: EditorView.domEventHandlers__.handlers.drop, ?durationchange: EditorView.domEventHandlers__.handlers.durationchange, ?emptied: EditorView.domEventHandlers__.handlers.emptied, ?ended: EditorView.domEventHandlers__.handlers.ended, ?error: EditorView.domEventHandlers__.handlers.error, ?focus: EditorView.domEventHandlers__.handlers.focus, ?focusin: EditorView.domEventHandlers__.handlers.focusin, ?focusout: EditorView.domEventHandlers__.handlers.focusout, ?formdata: EditorView.domEventHandlers__.handlers.formdata, ?gotpointercapture: EditorView.domEventHandlers__.handlers.gotpointercapture, ?input: EditorView.domEventHandlers__.handlers.input, ?invalid: EditorView.domEventHandlers__.handlers.invalid, ?keydown: EditorView.domEventHandlers__.handlers.keydown, ?keypress: EditorView.domEventHandlers__.handlers.keypress, ?keyup: EditorView.domEventHandlers__.handlers.keyup, ?load: EditorView.domEventHandlers__.handlers.load, ?loadeddata: EditorView.domEventHandlers__.handlers.loadeddata, ?loadedmetadata: EditorView.domEventHandlers__.handlers.loadedmetadata, ?loadstart: EditorView.domEventHandlers__.handlers.loadstart, ?lostpointercapture: EditorView.domEventHandlers__.handlers.lostpointercapture, ?mousedown: EditorView.domEventHandlers__.handlers.mousedown, ?mouseenter: EditorView.domEventHandlers__.handlers.mouseenter, ?mouseleave: EditorView.domEventHandlers__.handlers.mouseleave, ?mousemove: EditorView.domEventHandlers__.handlers.mousemove, ?mouseout: EditorView.domEventHandlers__.handlers.mouseout, ?mouseover: EditorView.domEventHandlers__.handlers.mouseover, ?mouseup: EditorView.domEventHandlers__.handlers.mouseup, ?paste: EditorView.domEventHandlers__.handlers.paste, ?pause: EditorView.domEventHandlers__.handlers.pause, ?play: EditorView.domEventHandlers__.handlers.play, ?playing: EditorView.domEventHandlers__.handlers.playing, ?pointercancel: EditorView.domEventHandlers__.handlers.pointercancel, ?pointerdown: EditorView.domEventHandlers__.handlers.pointerdown, ?pointerenter: EditorView.domEventHandlers__.handlers.pointerenter, ?pointerleave: EditorView.domEventHandlers__.handlers.pointerleave, ?pointermove: EditorView.domEventHandlers__.handlers.pointermove, ?pointerout: EditorView.domEventHandlers__.handlers.pointerout, ?pointerover: EditorView.domEventHandlers__.handlers.pointerover, ?pointerup: EditorView.domEventHandlers__.handlers.pointerup, ?progress: EditorView.domEventHandlers__.handlers.progress, ?ratechange: EditorView.domEventHandlers__.handlers.ratechange, ?reset: EditorView.domEventHandlers__.handlers.reset, ?resize: EditorView.domEventHandlers__.handlers.resize, ?scroll: EditorView.domEventHandlers__.handlers.scroll, ?scrollend: EditorView.domEventHandlers__.handlers.scrollend, ?securitypolicyviolation: EditorView.domEventHandlers__.handlers.securitypolicyviolation, ?seeked: EditorView.domEventHandlers__.handlers.seeked, ?seeking: EditorView.domEventHandlers__.handlers.seeking, ?select: EditorView.domEventHandlers__.handlers.select, ?selectionchange: EditorView.domEventHandlers__.handlers.selectionchange, ?selectstart: EditorView.domEventHandlers__.handlers.selectstart, ?slotchange: EditorView.domEventHandlers__.handlers.slotchange, ?stalled: EditorView.domEventHandlers__.handlers.stalled, ?submit: EditorView.domEventHandlers__.handlers.submit, ?suspend: EditorView.domEventHandlers__.handlers.suspend, ?timeupdate: EditorView.domEventHandlers__.handlers.timeupdate, ?toggle: EditorView.domEventHandlers__.handlers.toggle, ?touchcancel: EditorView.domEventHandlers__.handlers.touchcancel, ?touchend: EditorView.domEventHandlers__.handlers.touchend, ?touchmove: EditorView.domEventHandlers__.handlers.touchmove, ?touchstart: EditorView.domEventHandlers__.handlers.touchstart, ?transitioncancel: EditorView.domEventHandlers__.handlers.transitioncancel, ?transitionend: EditorView.domEventHandlers__.handlers.transitionend, ?transitionrun: EditorView.domEventHandlers__.handlers.transitionrun, ?transitionstart: EditorView.domEventHandlers__.handlers.transitionstart, ?volumechange: EditorView.domEventHandlers__.handlers.volumechange, ?waiting: EditorView.domEventHandlers__.handlers.waiting, ?webkitanimationend: EditorView.domEventHandlers__.handlers.webkitanimationend, ?webkitanimationiteration: EditorView.domEventHandlers__.handlers.webkitanimationiteration, ?webkitanimationstart: EditorView.domEventHandlers__.handlers.webkitanimationstart, ?webkittransitionend: EditorView.domEventHandlers__.handlers.webkittransitionend, ?wheel: EditorView.domEventHandlers__.handlers.wheel) : handlers = nativeOnly

            module handlers =

                type fullscreenchange =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type fullscreenerror =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type abort =
                    delegate of event: Glutinum.Web.UIEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type animationcancel =
                    delegate of event: Glutinum.Web.AnimationEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type animationend =
                    delegate of event: Glutinum.Web.AnimationEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type animationiteration =
                    delegate of event: Glutinum.Web.AnimationEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type animationstart =
                    delegate of event: Glutinum.Web.AnimationEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type auxclick =
                    delegate of event: Glutinum.Web.MouseEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type beforeinput =
                    delegate of event: Glutinum.Web.InputEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type blur =
                    delegate of event: Glutinum.Web.FocusEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type cancel =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type canplay =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type canplaythrough =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type change =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type click =
                    delegate of event: Glutinum.Web.MouseEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type close =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type compositionend =
                    delegate of event: Glutinum.Web.CompositionEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type compositionstart =
                    delegate of event: Glutinum.Web.CompositionEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type compositionupdate =
                    delegate of event: Glutinum.Web.CompositionEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type contextmenu =
                    delegate of event: Glutinum.Web.MouseEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type copy =
                    delegate of event: Glutinum.Web.ClipboardEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type cuechange =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type cut =
                    delegate of event: Glutinum.Web.ClipboardEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type dblclick =
                    delegate of event: Glutinum.Web.MouseEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type drag =
                    delegate of event: Glutinum.Web.DragEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type dragend =
                    delegate of event: Glutinum.Web.DragEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type dragenter =
                    delegate of event: Glutinum.Web.DragEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type dragleave =
                    delegate of event: Glutinum.Web.DragEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type dragover =
                    delegate of event: Glutinum.Web.DragEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type dragstart =
                    delegate of event: Glutinum.Web.DragEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type drop =
                    delegate of event: Glutinum.Web.DragEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type durationchange =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type emptied =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type ended =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type error =
                    delegate of event: Glutinum.Web.ErrorEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type focus =
                    delegate of event: Glutinum.Web.FocusEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type focusin =
                    delegate of event: Glutinum.Web.FocusEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type focusout =
                    delegate of event: Glutinum.Web.FocusEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type formdata =
                    delegate of event: Glutinum.Web.FormDataEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type gotpointercapture =
                    delegate of event: Glutinum.Web.PointerEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type input =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type invalid =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type keydown =
                    delegate of event: Glutinum.Web.KeyboardEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type keypress =
                    delegate of event: Glutinum.Web.KeyboardEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type keyup =
                    delegate of event: Glutinum.Web.KeyboardEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type load =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type loadeddata =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type loadedmetadata =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type loadstart =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type lostpointercapture =
                    delegate of event: Glutinum.Web.PointerEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type mousedown =
                    delegate of event: Glutinum.Web.MouseEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type mouseenter =
                    delegate of event: Glutinum.Web.MouseEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type mouseleave =
                    delegate of event: Glutinum.Web.MouseEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type mousemove =
                    delegate of event: Glutinum.Web.MouseEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type mouseout =
                    delegate of event: Glutinum.Web.MouseEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type mouseover =
                    delegate of event: Glutinum.Web.MouseEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type mouseup =
                    delegate of event: Glutinum.Web.MouseEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type paste =
                    delegate of event: Glutinum.Web.ClipboardEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type pause =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type play =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type playing =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type pointercancel =
                    delegate of event: Glutinum.Web.PointerEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type pointerdown =
                    delegate of event: Glutinum.Web.PointerEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type pointerenter =
                    delegate of event: Glutinum.Web.PointerEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type pointerleave =
                    delegate of event: Glutinum.Web.PointerEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type pointermove =
                    delegate of event: Glutinum.Web.PointerEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type pointerout =
                    delegate of event: Glutinum.Web.PointerEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type pointerover =
                    delegate of event: Glutinum.Web.PointerEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type pointerup =
                    delegate of event: Glutinum.Web.PointerEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type progress =
                    delegate of event: Glutinum.Web.ProgressEvent<Glutinum.Web.EventTarget> * view: CodemirrorView.EditorView -> U2<bool, unit>

                type ratechange =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type reset =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type resize =
                    delegate of event: Glutinum.Web.UIEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type scroll =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type scrollend =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type securitypolicyviolation =
                    delegate of event: Glutinum.Web.SecurityPolicyViolationEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type seeked =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type seeking =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type select =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type selectionchange =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type selectstart =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type slotchange =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type stalled =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type submit =
                    delegate of event: Glutinum.Web.SubmitEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type suspend =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type timeupdate =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type toggle =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type touchcancel =
                    delegate of event: Glutinum.Web.TouchEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type touchend =
                    delegate of event: Glutinum.Web.TouchEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type touchmove =
                    delegate of event: Glutinum.Web.TouchEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type touchstart =
                    delegate of event: Glutinum.Web.TouchEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type transitioncancel =
                    delegate of event: Glutinum.Web.TransitionEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type transitionend =
                    delegate of event: Glutinum.Web.TransitionEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type transitionrun =
                    delegate of event: Glutinum.Web.TransitionEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type transitionstart =
                    delegate of event: Glutinum.Web.TransitionEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type volumechange =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type waiting =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type webkitanimationend =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type webkitanimationiteration =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type webkitanimationstart =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type webkittransitionend =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type wheel =
                    delegate of event: Glutinum.Web.WheelEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

        module domEventObservers__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type observers =
                abstract member fullscreenchange: EditorView.domEventObservers__.observers.fullscreenchange option with get, set
                abstract member fullscreenerror: EditorView.domEventObservers__.observers.fullscreenerror option with get, set
                abstract member abort: EditorView.domEventObservers__.observers.abort option with get, set
                abstract member animationcancel: EditorView.domEventObservers__.observers.animationcancel option with get, set
                abstract member animationend: EditorView.domEventObservers__.observers.animationend option with get, set
                abstract member animationiteration: EditorView.domEventObservers__.observers.animationiteration option with get, set
                abstract member animationstart: EditorView.domEventObservers__.observers.animationstart option with get, set
                abstract member auxclick: EditorView.domEventObservers__.observers.auxclick option with get, set
                abstract member beforeinput: EditorView.domEventObservers__.observers.beforeinput option with get, set
                abstract member blur: EditorView.domEventObservers__.observers.blur option with get, set
                abstract member cancel: EditorView.domEventObservers__.observers.cancel option with get, set
                abstract member canplay: EditorView.domEventObservers__.observers.canplay option with get, set
                abstract member canplaythrough: EditorView.domEventObservers__.observers.canplaythrough option with get, set
                abstract member change: EditorView.domEventObservers__.observers.change option with get, set
                abstract member click: EditorView.domEventObservers__.observers.click option with get, set
                abstract member close: EditorView.domEventObservers__.observers.close option with get, set
                abstract member compositionend: EditorView.domEventObservers__.observers.compositionend option with get, set
                abstract member compositionstart: EditorView.domEventObservers__.observers.compositionstart option with get, set
                abstract member compositionupdate: EditorView.domEventObservers__.observers.compositionupdate option with get, set
                abstract member contextmenu: EditorView.domEventObservers__.observers.contextmenu option with get, set
                abstract member copy: EditorView.domEventObservers__.observers.copy option with get, set
                abstract member cuechange: EditorView.domEventObservers__.observers.cuechange option with get, set
                abstract member cut: EditorView.domEventObservers__.observers.cut option with get, set
                abstract member dblclick: EditorView.domEventObservers__.observers.dblclick option with get, set
                abstract member drag: EditorView.domEventObservers__.observers.drag option with get, set
                abstract member dragend: EditorView.domEventObservers__.observers.dragend option with get, set
                abstract member dragenter: EditorView.domEventObservers__.observers.dragenter option with get, set
                abstract member dragleave: EditorView.domEventObservers__.observers.dragleave option with get, set
                abstract member dragover: EditorView.domEventObservers__.observers.dragover option with get, set
                abstract member dragstart: EditorView.domEventObservers__.observers.dragstart option with get, set
                abstract member drop: EditorView.domEventObservers__.observers.drop option with get, set
                abstract member durationchange: EditorView.domEventObservers__.observers.durationchange option with get, set
                abstract member emptied: EditorView.domEventObservers__.observers.emptied option with get, set
                abstract member ended: EditorView.domEventObservers__.observers.ended option with get, set
                abstract member error: EditorView.domEventObservers__.observers.error option with get, set
                abstract member focus: EditorView.domEventObservers__.observers.focus option with get, set
                abstract member focusin: EditorView.domEventObservers__.observers.focusin option with get, set
                abstract member focusout: EditorView.domEventObservers__.observers.focusout option with get, set
                abstract member formdata: EditorView.domEventObservers__.observers.formdata option with get, set
                abstract member gotpointercapture: EditorView.domEventObservers__.observers.gotpointercapture option with get, set
                abstract member input: EditorView.domEventObservers__.observers.input option with get, set
                abstract member invalid: EditorView.domEventObservers__.observers.invalid option with get, set
                abstract member keydown: EditorView.domEventObservers__.observers.keydown option with get, set
                abstract member keypress: EditorView.domEventObservers__.observers.keypress option with get, set
                abstract member keyup: EditorView.domEventObservers__.observers.keyup option with get, set
                abstract member load: EditorView.domEventObservers__.observers.load option with get, set
                abstract member loadeddata: EditorView.domEventObservers__.observers.loadeddata option with get, set
                abstract member loadedmetadata: EditorView.domEventObservers__.observers.loadedmetadata option with get, set
                abstract member loadstart: EditorView.domEventObservers__.observers.loadstart option with get, set
                abstract member lostpointercapture: EditorView.domEventObservers__.observers.lostpointercapture option with get, set
                abstract member mousedown: EditorView.domEventObservers__.observers.mousedown option with get, set
                abstract member mouseenter: EditorView.domEventObservers__.observers.mouseenter option with get, set
                abstract member mouseleave: EditorView.domEventObservers__.observers.mouseleave option with get, set
                abstract member mousemove: EditorView.domEventObservers__.observers.mousemove option with get, set
                abstract member mouseout: EditorView.domEventObservers__.observers.mouseout option with get, set
                abstract member mouseover: EditorView.domEventObservers__.observers.mouseover option with get, set
                abstract member mouseup: EditorView.domEventObservers__.observers.mouseup option with get, set
                abstract member paste: EditorView.domEventObservers__.observers.paste option with get, set
                abstract member pause: EditorView.domEventObservers__.observers.pause option with get, set
                abstract member play: EditorView.domEventObservers__.observers.play option with get, set
                abstract member playing: EditorView.domEventObservers__.observers.playing option with get, set
                abstract member pointercancel: EditorView.domEventObservers__.observers.pointercancel option with get, set
                abstract member pointerdown: EditorView.domEventObservers__.observers.pointerdown option with get, set
                abstract member pointerenter: EditorView.domEventObservers__.observers.pointerenter option with get, set
                abstract member pointerleave: EditorView.domEventObservers__.observers.pointerleave option with get, set
                abstract member pointermove: EditorView.domEventObservers__.observers.pointermove option with get, set
                abstract member pointerout: EditorView.domEventObservers__.observers.pointerout option with get, set
                abstract member pointerover: EditorView.domEventObservers__.observers.pointerover option with get, set
                abstract member pointerup: EditorView.domEventObservers__.observers.pointerup option with get, set
                abstract member progress: EditorView.domEventObservers__.observers.progress option with get, set
                abstract member ratechange: EditorView.domEventObservers__.observers.ratechange option with get, set
                abstract member reset: EditorView.domEventObservers__.observers.reset option with get, set
                abstract member resize: EditorView.domEventObservers__.observers.resize option with get, set
                abstract member scroll: EditorView.domEventObservers__.observers.scroll option with get, set
                abstract member scrollend: EditorView.domEventObservers__.observers.scrollend option with get, set
                abstract member securitypolicyviolation: EditorView.domEventObservers__.observers.securitypolicyviolation option with get, set
                abstract member seeked: EditorView.domEventObservers__.observers.seeked option with get, set
                abstract member seeking: EditorView.domEventObservers__.observers.seeking option with get, set
                abstract member select: EditorView.domEventObservers__.observers.select option with get, set
                abstract member selectionchange: EditorView.domEventObservers__.observers.selectionchange option with get, set
                abstract member selectstart: EditorView.domEventObservers__.observers.selectstart option with get, set
                abstract member slotchange: EditorView.domEventObservers__.observers.slotchange option with get, set
                abstract member stalled: EditorView.domEventObservers__.observers.stalled option with get, set
                abstract member submit: EditorView.domEventObservers__.observers.submit option with get, set
                abstract member suspend: EditorView.domEventObservers__.observers.suspend option with get, set
                abstract member timeupdate: EditorView.domEventObservers__.observers.timeupdate option with get, set
                abstract member toggle: EditorView.domEventObservers__.observers.toggle option with get, set
                abstract member touchcancel: EditorView.domEventObservers__.observers.touchcancel option with get, set
                abstract member touchend: EditorView.domEventObservers__.observers.touchend option with get, set
                abstract member touchmove: EditorView.domEventObservers__.observers.touchmove option with get, set
                abstract member touchstart: EditorView.domEventObservers__.observers.touchstart option with get, set
                abstract member transitioncancel: EditorView.domEventObservers__.observers.transitioncancel option with get, set
                abstract member transitionend: EditorView.domEventObservers__.observers.transitionend option with get, set
                abstract member transitionrun: EditorView.domEventObservers__.observers.transitionrun option with get, set
                abstract member transitionstart: EditorView.domEventObservers__.observers.transitionstart option with get, set
                abstract member volumechange: EditorView.domEventObservers__.observers.volumechange option with get, set
                abstract member waiting: EditorView.domEventObservers__.observers.waiting option with get, set
                abstract member webkitanimationend: EditorView.domEventObservers__.observers.webkitanimationend option with get, set
                abstract member webkitanimationiteration: EditorView.domEventObservers__.observers.webkitanimationiteration option with get, set
                abstract member webkitanimationstart: EditorView.domEventObservers__.observers.webkitanimationstart option with get, set
                abstract member webkittransitionend: EditorView.domEventObservers__.observers.webkittransitionend option with get, set
                abstract member wheel: EditorView.domEventObservers__.observers.wheel option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?fullscreenchange: EditorView.domEventObservers__.observers.fullscreenchange, ?fullscreenerror: EditorView.domEventObservers__.observers.fullscreenerror, ?abort: EditorView.domEventObservers__.observers.abort, ?animationcancel: EditorView.domEventObservers__.observers.animationcancel, ?animationend: EditorView.domEventObservers__.observers.animationend, ?animationiteration: EditorView.domEventObservers__.observers.animationiteration, ?animationstart: EditorView.domEventObservers__.observers.animationstart, ?auxclick: EditorView.domEventObservers__.observers.auxclick, ?beforeinput: EditorView.domEventObservers__.observers.beforeinput, ?blur: EditorView.domEventObservers__.observers.blur, ?cancel: EditorView.domEventObservers__.observers.cancel, ?canplay: EditorView.domEventObservers__.observers.canplay, ?canplaythrough: EditorView.domEventObservers__.observers.canplaythrough, ?change: EditorView.domEventObservers__.observers.change, ?click: EditorView.domEventObservers__.observers.click, ?close: EditorView.domEventObservers__.observers.close, ?compositionend: EditorView.domEventObservers__.observers.compositionend, ?compositionstart: EditorView.domEventObservers__.observers.compositionstart, ?compositionupdate: EditorView.domEventObservers__.observers.compositionupdate, ?contextmenu: EditorView.domEventObservers__.observers.contextmenu, ?copy: EditorView.domEventObservers__.observers.copy, ?cuechange: EditorView.domEventObservers__.observers.cuechange, ?cut: EditorView.domEventObservers__.observers.cut, ?dblclick: EditorView.domEventObservers__.observers.dblclick, ?drag: EditorView.domEventObservers__.observers.drag, ?dragend: EditorView.domEventObservers__.observers.dragend, ?dragenter: EditorView.domEventObservers__.observers.dragenter, ?dragleave: EditorView.domEventObservers__.observers.dragleave, ?dragover: EditorView.domEventObservers__.observers.dragover, ?dragstart: EditorView.domEventObservers__.observers.dragstart, ?drop: EditorView.domEventObservers__.observers.drop, ?durationchange: EditorView.domEventObservers__.observers.durationchange, ?emptied: EditorView.domEventObservers__.observers.emptied, ?ended: EditorView.domEventObservers__.observers.ended, ?error: EditorView.domEventObservers__.observers.error, ?focus: EditorView.domEventObservers__.observers.focus, ?focusin: EditorView.domEventObservers__.observers.focusin, ?focusout: EditorView.domEventObservers__.observers.focusout, ?formdata: EditorView.domEventObservers__.observers.formdata, ?gotpointercapture: EditorView.domEventObservers__.observers.gotpointercapture, ?input: EditorView.domEventObservers__.observers.input, ?invalid: EditorView.domEventObservers__.observers.invalid, ?keydown: EditorView.domEventObservers__.observers.keydown, ?keypress: EditorView.domEventObservers__.observers.keypress, ?keyup: EditorView.domEventObservers__.observers.keyup, ?load: EditorView.domEventObservers__.observers.load, ?loadeddata: EditorView.domEventObservers__.observers.loadeddata, ?loadedmetadata: EditorView.domEventObservers__.observers.loadedmetadata, ?loadstart: EditorView.domEventObservers__.observers.loadstart, ?lostpointercapture: EditorView.domEventObservers__.observers.lostpointercapture, ?mousedown: EditorView.domEventObservers__.observers.mousedown, ?mouseenter: EditorView.domEventObservers__.observers.mouseenter, ?mouseleave: EditorView.domEventObservers__.observers.mouseleave, ?mousemove: EditorView.domEventObservers__.observers.mousemove, ?mouseout: EditorView.domEventObservers__.observers.mouseout, ?mouseover: EditorView.domEventObservers__.observers.mouseover, ?mouseup: EditorView.domEventObservers__.observers.mouseup, ?paste: EditorView.domEventObservers__.observers.paste, ?pause: EditorView.domEventObservers__.observers.pause, ?play: EditorView.domEventObservers__.observers.play, ?playing: EditorView.domEventObservers__.observers.playing, ?pointercancel: EditorView.domEventObservers__.observers.pointercancel, ?pointerdown: EditorView.domEventObservers__.observers.pointerdown, ?pointerenter: EditorView.domEventObservers__.observers.pointerenter, ?pointerleave: EditorView.domEventObservers__.observers.pointerleave, ?pointermove: EditorView.domEventObservers__.observers.pointermove, ?pointerout: EditorView.domEventObservers__.observers.pointerout, ?pointerover: EditorView.domEventObservers__.observers.pointerover, ?pointerup: EditorView.domEventObservers__.observers.pointerup, ?progress: EditorView.domEventObservers__.observers.progress, ?ratechange: EditorView.domEventObservers__.observers.ratechange, ?reset: EditorView.domEventObservers__.observers.reset, ?resize: EditorView.domEventObservers__.observers.resize, ?scroll: EditorView.domEventObservers__.observers.scroll, ?scrollend: EditorView.domEventObservers__.observers.scrollend, ?securitypolicyviolation: EditorView.domEventObservers__.observers.securitypolicyviolation, ?seeked: EditorView.domEventObservers__.observers.seeked, ?seeking: EditorView.domEventObservers__.observers.seeking, ?select: EditorView.domEventObservers__.observers.select, ?selectionchange: EditorView.domEventObservers__.observers.selectionchange, ?selectstart: EditorView.domEventObservers__.observers.selectstart, ?slotchange: EditorView.domEventObservers__.observers.slotchange, ?stalled: EditorView.domEventObservers__.observers.stalled, ?submit: EditorView.domEventObservers__.observers.submit, ?suspend: EditorView.domEventObservers__.observers.suspend, ?timeupdate: EditorView.domEventObservers__.observers.timeupdate, ?toggle: EditorView.domEventObservers__.observers.toggle, ?touchcancel: EditorView.domEventObservers__.observers.touchcancel, ?touchend: EditorView.domEventObservers__.observers.touchend, ?touchmove: EditorView.domEventObservers__.observers.touchmove, ?touchstart: EditorView.domEventObservers__.observers.touchstart, ?transitioncancel: EditorView.domEventObservers__.observers.transitioncancel, ?transitionend: EditorView.domEventObservers__.observers.transitionend, ?transitionrun: EditorView.domEventObservers__.observers.transitionrun, ?transitionstart: EditorView.domEventObservers__.observers.transitionstart, ?volumechange: EditorView.domEventObservers__.observers.volumechange, ?waiting: EditorView.domEventObservers__.observers.waiting, ?webkitanimationend: EditorView.domEventObservers__.observers.webkitanimationend, ?webkitanimationiteration: EditorView.domEventObservers__.observers.webkitanimationiteration, ?webkitanimationstart: EditorView.domEventObservers__.observers.webkitanimationstart, ?webkittransitionend: EditorView.domEventObservers__.observers.webkittransitionend, ?wheel: EditorView.domEventObservers__.observers.wheel) : observers = nativeOnly

            module observers =

                type fullscreenchange =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type fullscreenerror =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type abort =
                    delegate of event: Glutinum.Web.UIEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type animationcancel =
                    delegate of event: Glutinum.Web.AnimationEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type animationend =
                    delegate of event: Glutinum.Web.AnimationEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type animationiteration =
                    delegate of event: Glutinum.Web.AnimationEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type animationstart =
                    delegate of event: Glutinum.Web.AnimationEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type auxclick =
                    delegate of event: Glutinum.Web.MouseEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type beforeinput =
                    delegate of event: Glutinum.Web.InputEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type blur =
                    delegate of event: Glutinum.Web.FocusEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type cancel =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type canplay =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type canplaythrough =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type change =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type click =
                    delegate of event: Glutinum.Web.MouseEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type close =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type compositionend =
                    delegate of event: Glutinum.Web.CompositionEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type compositionstart =
                    delegate of event: Glutinum.Web.CompositionEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type compositionupdate =
                    delegate of event: Glutinum.Web.CompositionEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type contextmenu =
                    delegate of event: Glutinum.Web.MouseEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type copy =
                    delegate of event: Glutinum.Web.ClipboardEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type cuechange =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type cut =
                    delegate of event: Glutinum.Web.ClipboardEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type dblclick =
                    delegate of event: Glutinum.Web.MouseEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type drag =
                    delegate of event: Glutinum.Web.DragEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type dragend =
                    delegate of event: Glutinum.Web.DragEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type dragenter =
                    delegate of event: Glutinum.Web.DragEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type dragleave =
                    delegate of event: Glutinum.Web.DragEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type dragover =
                    delegate of event: Glutinum.Web.DragEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type dragstart =
                    delegate of event: Glutinum.Web.DragEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type drop =
                    delegate of event: Glutinum.Web.DragEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type durationchange =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type emptied =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type ended =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type error =
                    delegate of event: Glutinum.Web.ErrorEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type focus =
                    delegate of event: Glutinum.Web.FocusEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type focusin =
                    delegate of event: Glutinum.Web.FocusEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type focusout =
                    delegate of event: Glutinum.Web.FocusEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type formdata =
                    delegate of event: Glutinum.Web.FormDataEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type gotpointercapture =
                    delegate of event: Glutinum.Web.PointerEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type input =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type invalid =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type keydown =
                    delegate of event: Glutinum.Web.KeyboardEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type keypress =
                    delegate of event: Glutinum.Web.KeyboardEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type keyup =
                    delegate of event: Glutinum.Web.KeyboardEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type load =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type loadeddata =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type loadedmetadata =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type loadstart =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type lostpointercapture =
                    delegate of event: Glutinum.Web.PointerEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type mousedown =
                    delegate of event: Glutinum.Web.MouseEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type mouseenter =
                    delegate of event: Glutinum.Web.MouseEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type mouseleave =
                    delegate of event: Glutinum.Web.MouseEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type mousemove =
                    delegate of event: Glutinum.Web.MouseEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type mouseout =
                    delegate of event: Glutinum.Web.MouseEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type mouseover =
                    delegate of event: Glutinum.Web.MouseEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type mouseup =
                    delegate of event: Glutinum.Web.MouseEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type paste =
                    delegate of event: Glutinum.Web.ClipboardEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type pause =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type play =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type playing =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type pointercancel =
                    delegate of event: Glutinum.Web.PointerEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type pointerdown =
                    delegate of event: Glutinum.Web.PointerEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type pointerenter =
                    delegate of event: Glutinum.Web.PointerEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type pointerleave =
                    delegate of event: Glutinum.Web.PointerEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type pointermove =
                    delegate of event: Glutinum.Web.PointerEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type pointerout =
                    delegate of event: Glutinum.Web.PointerEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type pointerover =
                    delegate of event: Glutinum.Web.PointerEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type pointerup =
                    delegate of event: Glutinum.Web.PointerEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type progress =
                    delegate of event: Glutinum.Web.ProgressEvent<Glutinum.Web.EventTarget> * view: CodemirrorView.EditorView -> U2<bool, unit>

                type ratechange =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type reset =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type resize =
                    delegate of event: Glutinum.Web.UIEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type scroll =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type scrollend =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type securitypolicyviolation =
                    delegate of event: Glutinum.Web.SecurityPolicyViolationEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type seeked =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type seeking =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type select =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type selectionchange =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type selectstart =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type slotchange =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type stalled =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type submit =
                    delegate of event: Glutinum.Web.SubmitEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type suspend =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type timeupdate =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type toggle =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type touchcancel =
                    delegate of event: Glutinum.Web.TouchEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type touchend =
                    delegate of event: Glutinum.Web.TouchEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type touchmove =
                    delegate of event: Glutinum.Web.TouchEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type touchstart =
                    delegate of event: Glutinum.Web.TouchEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type transitioncancel =
                    delegate of event: Glutinum.Web.TransitionEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type transitionend =
                    delegate of event: Glutinum.Web.TransitionEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type transitionrun =
                    delegate of event: Glutinum.Web.TransitionEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type transitionstart =
                    delegate of event: Glutinum.Web.TransitionEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type volumechange =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type waiting =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type webkitanimationend =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type webkitanimationiteration =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type webkitanimationstart =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type webkittransitionend =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type wheel =
                    delegate of event: Glutinum.Web.WheelEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

        module scrollHandler__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member x: CodemirrorView.ScrollStrategy with get, set
                abstract member y: CodemirrorView.ScrollStrategy with get, set
                abstract member xMargin: float with get, set
                abstract member yMargin: float with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (x: CodemirrorView.ScrollStrategy, y: CodemirrorView.ScrollStrategy, xMargin: float, yMargin: float) : options = nativeOnly

            [<AllowNullLiteral>]
            [<Interface>]
            type options_1 =
                abstract member x: CodemirrorView.ScrollStrategy with get, set
                abstract member y: CodemirrorView.ScrollStrategy with get, set
                abstract member xMargin: float with get, set
                abstract member yMargin: float with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (x: CodemirrorView.ScrollStrategy, y: CodemirrorView.ScrollStrategy, xMargin: float, yMargin: float) : options_1 = nativeOnly

        module cursorScrollMargin__ =

            module U2 =

                [<AllowNullLiteral>]
                [<Interface>]
                type Case2 =
                    abstract member x: float with get, set
                    abstract member y: float with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (x: float, y: float) : Case2 = nativeOnly

        module theme__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type spec =
                [<EmitIndexer>]
                abstract member Item: selector: string -> StyleMod.StyleSpec with get, set

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member dark: bool option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?dark: bool) : options = nativeOnly

        module baseTheme__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type spec =
                [<EmitIndexer>]
                abstract member Item: selector: string -> StyleMod.StyleSpec with get, set

    module KeyBinding =

        type any =
            delegate of view: CodemirrorView.EditorView * event: Glutinum.Web.KeyboardEvent -> bool

    module SpecialCharConfig =

        type render =
            delegate of code: float * description: string option * placeholder: string -> Glutinum.Web.HTMLElement

    module TooltipView =

        [<AllowNullLiteral>]
        [<Interface>]
        type offset =
            abstract member x: float with get, set
            abstract member y: float with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (x: float, y: float) : offset = nativeOnly

    module HoverTooltipSource =

        [<RequireQualifiedAccess>]
        type side =
            | _MINUS_1 = -1
            | ``1`` = 1

    module DialogConfig =

        type content =
            delegate of view: CodemirrorView.EditorView * close: (unit -> unit) -> Glutinum.Web.HTMLElement

        [<AllowNullLiteral>]
        [<Interface>]
        type input =
            [<EmitIndexer>]
            abstract member Item: attr: string -> string with get, set

    module Handlers =

        type Item =
            delegate of view: CodemirrorView.EditorView * line: CodemirrorView.BlockInfo * event: Glutinum.Web.Event -> bool

    module GutterConfig =

        type lineMarker =
            delegate of view: CodemirrorView.EditorView * line: CodemirrorView.BlockInfo * otherMarkers: ResizeArray<CodemirrorView.GutterMarker> -> CodemirrorView.GutterMarker option

        type widgetMarker =
            delegate of view: CodemirrorView.EditorView * widget: CodemirrorView.WidgetType * block: CodemirrorView.BlockInfo -> CodemirrorView.GutterMarker option

        type updateSpacer =
            delegate of spacer: CodemirrorView.GutterMarker * update: CodemirrorView.ViewUpdate -> CodemirrorView.GutterMarker

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type side =
            | before
            | after

    module LineNumberConfig =

        type formatNumber =
            delegate of lineNo: float * state: CodemirrorState.EditorState -> string

    module Exports =

        [<AllowNullLiteral>]
        [<Interface>]
        type showDialog__ =
            abstract member close: CodemirrorState.StateEffect<obj> with get, set
            abstract member result: JS.Promise<Glutinum.Web.HTMLFormElement option> with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (close: CodemirrorState.StateEffect<obj>, result: JS.Promise<Glutinum.Web.HTMLFormElement option>) : showDialog__ = nativeOnly

        module rectangularSelection__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                /// <summary>
                /// A custom predicate function, which takes a <c>mousedown</c> event and
                /// returns true if it should be used for rectangular selection.
                /// </summary>
                abstract member eventFilter: (Glutinum.Web.MouseEvent -> bool) option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?eventFilter: (Glutinum.Web.MouseEvent -> bool)) : options = nativeOnly

        module crosshairCursor__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member key: Exports.crosshairCursor__.options.key option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?key: Exports.crosshairCursor__.options.key) : options = nativeOnly

            module options =

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type key =
                    | Alt
                    | Control
                    | Shift
                    | Meta

        module tooltips__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type config =
                /// <summary>
                /// By default, tooltips use <c>"fixed"</c>
                /// [positioning](https://developer.mozilla.org/en-US/docs/Web/CSS/position),
                /// which has the advantage that tooltips don't get cut off by
                /// scrollable parent elements. However, CSS rules like <c>contain:
                /// layout</c> can break fixed positioning in child nodes, which can be
                /// worked about by using <c>"absolute"</c> here.
                ///
                /// On iOS, which at the time of writing still doesn't properly
                /// support fixed positioning, the library always uses absolute
                /// positioning.
                ///
                /// If the tooltip parent element sits in a transformed element, the
                /// library also falls back to absolute positioning.
                /// </summary>
                abstract member position: Exports.tooltips__.config.position option with get, set
                /// <summary>
                /// The element to put the tooltips into. By default, they are put
                /// in the editor (<c>cm-editor</c>) element, and that is usually what
                /// you want. But in some layouts that can lead to positioning
                /// issues, and you need to use a different parent to work around
                /// those.
                /// </summary>
                abstract member parent: Glutinum.Web.HTMLElement option with get, set
                /// <summary>
                /// By default, when figuring out whether there is room for a
                /// tooltip at a given position, the extension considers the entire
                /// space between 0,0 and
                /// <c>documentElement.clientWidth</c>/<c>clientHeight</c> to be available for
                /// showing tooltips. You can provide a function here that returns
                /// an alternative rectangle.
                /// </summary>
                abstract member tooltipSpace: (CodemirrorView.EditorView -> CodemirrorView.Rect) option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?position: Exports.tooltips__.config.position, ?parent: Glutinum.Web.HTMLElement, ?tooltipSpace: (CodemirrorView.EditorView -> CodemirrorView.Rect)) : config = nativeOnly

            module config =

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type position =
                    | ``fixed``
                    | absolute

        module hoverTooltip__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                /// <summary>
                /// Controls whether a transaction hides the tooltip. The default
                /// is to not hide.
                /// </summary>
                abstract member hideOn: Exports.hoverTooltip__.options.hideOn option with get, set
                /// <summary>
                /// When enabled (this defaults to false), close the tooltip
                /// whenever the document changes or the selection is set.
                /// </summary>
                abstract member hideOnChange: Exports.hoverTooltip__.options.hideOnChange option with get, set
                /// <summary>
                /// Hover time after which the tooltip should appear, in
                /// milliseconds. Defaults to 300ms.
                /// </summary>
                abstract member hoverTime: float option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?hideOn: Exports.hoverTooltip__.options.hideOn, ?hideOnChange: Exports.hoverTooltip__.options.hideOnChange, ?hoverTime: float) : options = nativeOnly

            module options =

                type hideOn =
                    delegate of tr: CodemirrorState.Transaction * tooltip: CodemirrorView.Tooltip -> bool

                [<RequireQualifiedAccess>]
                [<Erase(CaseRules.None)>]
                type hideOnChange =
                    | touch
                    | Case1 of bool

        module activateHover__ =

            [<RequireQualifiedAccess>]
            type side =
                | _MINUS_1 = -1
                | ``1`` = 1

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member tooltip: CodemirrorState.Extension option with get, set
                abstract member until: (CodemirrorState.Transaction -> bool) option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?tooltip: CodemirrorState.Extension, ?until: (CodemirrorState.Transaction -> bool)) : options = nativeOnly

        module gutterWidgetClass__ =

            type Type =
                delegate of view: CodemirrorView.EditorView * widget: CodemirrorView.WidgetType * block: CodemirrorView.BlockInfo -> CodemirrorView.GutterMarker option

        module gutters__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type config =
                abstract member ``fixed``: bool option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?``fixed``: bool) : config = nativeOnly

        module lineNumberWidgetMarker__ =

            type Type =
                delegate of view: CodemirrorView.EditorView * widget: CodemirrorView.WidgetType * block: CodemirrorView.BlockInfo -> CodemirrorView.GutterMarker option

        module MatchDecorator =

            [<AllowNullLiteral>]
            [<Interface>]
            type config =
                /// <summary>
                /// The regular expression to match against the content. Will only
                /// be matched inside lines (not across them). Should have its 'g'
                /// flag set.
                /// </summary>
                abstract member regexp: RegExp with get, set
                /// <summary>
                /// The decoration to apply to matches, either directly or as a
                /// function of the match.
                /// </summary>
                abstract member decoration: U2<CodemirrorView.Decoration, Exports.MatchDecorator.config.decoration.U2.Case2> option with get, set
                /// <summary>
                /// Customize the way decorations are added for matches. This
                /// function, when given, will be called for matches and should
                /// call <c>add</c> to create decorations for them. Note that the
                /// decorations should appear *in* the given range, and the
                /// function should have no side effects beyond calling <c>add</c>.
                ///
                /// The <c>decoration</c> option is ignored when <c>decorate</c> is
                /// provided.
                /// </summary>
                abstract member decorate: Exports.MatchDecorator.config.decorate option with get, set
                /// <summary>
                /// By default, changed lines are re-matched entirely. You can
                /// provide a boundary expression, which should match single
                /// character strings that can never occur in <c>regexp</c>, to reduce
                /// the amount of re-matching.
                /// </summary>
                abstract member boundary: RegExp option with get, set
                /// <summary>
                /// Matching happens by line, by default, but when lines are
                /// folded or very long lines are only partially drawn, the
                /// decorator may avoid matching part of them for speed. This
                /// controls how much additional invisible content it should
                /// include in its matches. Defaults to 1000.
                /// </summary>
                abstract member maxLength: float option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (regexp: RegExp, ?decorate: Exports.MatchDecorator.config.decorate, ?boundary: RegExp, ?maxLength: float) : config = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (regexp: RegExp, decoration: CodemirrorView.Decoration, ?decorate: Exports.MatchDecorator.config.decorate, ?boundary: RegExp, ?maxLength: float) : config = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (regexp: RegExp, decoration: Exports.MatchDecorator.config.decoration.U2.Case2, ?decorate: Exports.MatchDecorator.config.decorate, ?boundary: RegExp, ?maxLength: float) : config = nativeOnly

            module config =

                type decorate =
                    delegate of add: Exports.MatchDecorator.config.decorate.add * from: float * ``to``: float * ``match``: obj * view: CodemirrorView.EditorView -> unit

                module decoration =

                    module U2 =

                        type Case2 =
                            delegate of ``match``: obj * view: CodemirrorView.EditorView * pos: float -> CodemirrorView.Decoration option

                module decorate =

                    type add =
                        delegate of from: float * ``to``: float * decoration: CodemirrorView.Decoration -> unit

module StyleMod =

    [<AbstractClass>]
    [<Erase>]
    type Exports =
        [<Import("StyleModule", "style-mod"); EmitConstructor>]
        static member StyleModule (spec: Exports.StyleModule.spec, ?options: Exports.StyleModule.options) : StyleModule = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type StyleModule =
        abstract member getRules: unit -> string
        static member inline mount (root: Glutinum.Web.Document, ``module``: StyleMod.StyleModule, ?options: StyleModule.mount__.options): unit =
            emitJsExpr (root, ``module``, options) $$"""
import { StyleModule } from "style-mod";
StyleModule.mount($0, $1, $2)"""
        static member inline mount (root: Glutinum.Web.Document, ``module``: ResizeArray<StyleMod.StyleModule>, ?options: StyleModule.mount__.options): unit =
            emitJsExpr (root, ``module``, options) $$"""
import { StyleModule } from "style-mod";
StyleModule.mount($0, $1, $2)"""
        static member inline mount (root: Glutinum.Web.ShadowRoot, ``module``: StyleMod.StyleModule, ?options: StyleModule.mount__.options): unit =
            emitJsExpr (root, ``module``, options) $$"""
import { StyleModule } from "style-mod";
StyleModule.mount($0, $1, $2)"""
        static member inline mount (root: Glutinum.Web.ShadowRoot, ``module``: ResizeArray<StyleMod.StyleModule>, ?options: StyleModule.mount__.options): unit =
            emitJsExpr (root, ``module``, options) $$"""
import { StyleModule } from "style-mod";
StyleModule.mount($0, $1, $2)"""
        static member inline mount (root: Glutinum.Web.DocumentOrShadowRoot, ``module``: StyleMod.StyleModule, ?options: StyleModule.mount__.options): unit =
            emitJsExpr (root, ``module``, options) $$"""
import { StyleModule } from "style-mod";
StyleModule.mount($0, $1, $2)"""
        static member inline mount (root: Glutinum.Web.DocumentOrShadowRoot, ``module``: ResizeArray<StyleMod.StyleModule>, ?options: StyleModule.mount__.options): unit =
            emitJsExpr (root, ``module``, options) $$"""
import { StyleModule } from "style-mod";
StyleModule.mount($0, $1, $2)"""
        static member inline newName () : string =
            emitJsExpr () $$"""
import { StyleModule } from "style-mod";
StyleModule.newName()"""

    [<AllowNullLiteral>]
    [<Interface>]
    type StyleSpec =
        [<EmitIndexer>]
        abstract member Item: propOrSelector: string -> U3<string, float, StyleMod.StyleSpec> option with get, set

    module StyleModule =

        module mount__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member nonce: string option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?nonce: string) : options = nativeOnly

    module Exports =

        module StyleModule =

            [<AllowNullLiteral>]
            [<Interface>]
            type spec =
                [<EmitIndexer>]
                abstract member Item: selector: string -> StyleMod.StyleSpec with get, set

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member finish: sel: string -> string
                [<ParamObject; Emit("$0")>]
                static member Create (finish: string) : options = nativeOnly
