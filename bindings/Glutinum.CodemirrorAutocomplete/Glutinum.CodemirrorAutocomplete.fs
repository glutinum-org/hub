namespace rec Glutinum

open Fable.Core
open Fable.Core.JsInterop
open System

// You need to add Glutinum.Types NuGet package to your project
open Glutinum.Types.TypeScript

// You need to add Glutinum.Web NuGet package to your project

// You need to add Glutinum.CodemirrorState NuGet package to your project

// You need to add Glutinum.CodemirrorView NuGet package to your project

// You need to add Glutinum.LezerCommon NuGet package to your project

type RegExp = Text.RegularExpressions.Regex

module CodemirrorAutocomplete =

    [<AbstractClass>]
    [<Erase>]
    type Exports =
        /// <summary>
        /// Given a a fixed array of options, return an autocompleter that
        /// completes them.
        /// </summary>
        [<Import("completeFromList", "@codemirror/autocomplete")>]
        static member completeFromList (list: ResizeArray<U2<string, CodemirrorAutocomplete.Completion>>) : CodemirrorAutocomplete.CompletionSource = nativeOnly
        /// <summary>
        /// Wrap the given completion source so that it will only fire when the
        /// cursor is in a syntax node with one of the given names.
        /// </summary>
        [<Import("ifIn", "@codemirror/autocomplete")>]
        static member ifIn (nodes: ResizeArray<string>, source: CodemirrorAutocomplete.CompletionSource) : CodemirrorAutocomplete.CompletionSource = nativeOnly
        /// <summary>
        /// Wrap the given completion source so that it will not fire when the
        /// cursor is in a syntax node with one of the given names.
        /// </summary>
        [<Import("ifNotIn", "@codemirror/autocomplete")>]
        static member ifNotIn (nodes: ResizeArray<string>, source: CodemirrorAutocomplete.CompletionSource) : CodemirrorAutocomplete.CompletionSource = nativeOnly
        /// <summary>
        /// This annotation is added to transactions that are produced by
        /// picking a completion.
        /// </summary>
        [<Import("pickedCompletion", "@codemirror/autocomplete")>]
        static member inline pickedCompletion: Glutinum.CodemirrorState.AnnotationType<CodemirrorAutocomplete.Completion> = nativeOnly
        /// <summary>
        /// Helper function that returns a transaction spec which inserts a
        /// completion's text in the main selection range, and any other
        /// selection range that has the same text in front of it.
        /// </summary>
        [<Import("insertCompletionText", "@codemirror/autocomplete")>]
        static member insertCompletionText (state: Glutinum.CodemirrorState.EditorState, text: string, from: float, ``to``: float) : Glutinum.CodemirrorState.TransactionSpec = nativeOnly
        /// <summary>
        /// Convert a snippet template to a function that can
        /// [apply](https://codemirror.net/6/docs/ref/#autocomplete.Completion.apply) it. Snippets are written
        /// using syntax like this:
        ///
        /// "for (let ${index} = 0; ${index} < ${end}; ${index}++) {\n\t${}\n}"
        ///
        /// Each <c>${}</c> placeholder (you may also use <c>#{}</c>) indicates a field
        /// that the user can fill in. Its name, if any, will be the default
        /// content for the field.
        ///
        /// When the snippet is activated by calling the returned function,
        /// the code is inserted at the given position. Newlines in the
        /// template are indented by the indentation of the start line, plus
        /// one [indent unit](https://codemirror.net/6/docs/ref/#language.indentUnit) per tab character after
        /// the newline.
        ///
        /// On activation, (all instances of) the first field are selected.
        /// The user can move between fields with Tab and Shift-Tab as long as
        /// the fields are active. Moving to the last field or moving the
        /// cursor out of the current field deactivates the fields.
        ///
        /// The order of fields defaults to textual order, but you can add
        /// numbers to placeholders (<c>${1}</c> or <c>${1:defaultText}</c>) to provide
        /// a custom order. <c>${0}</c> is special—it is always the last stop, where
        /// the cursor ends up after tabbing through the other fields.
        ///
        /// To include a literal <c>{</c> or <c>}</c> in your template, put a backslash
        /// in front of it. This will be removed and the brace will not be
        /// interpreted as indicating a placeholder.
        /// </summary>
        [<Import("snippet", "@codemirror/autocomplete")>]
        static member snippet (template: string) : Exports.snippet__ = nativeOnly
        /// <summary>
        /// A command that clears the active snippet, if any.
        /// </summary>
        [<Import("clearSnippet", "@codemirror/autocomplete")>]
        static member inline clearSnippet: Glutinum.CodemirrorState.StateCommand = nativeOnly
        /// <summary>
        /// Move to the next snippet field, if available.
        /// </summary>
        [<Import("nextSnippetField", "@codemirror/autocomplete")>]
        static member inline nextSnippetField: Glutinum.CodemirrorState.StateCommand = nativeOnly
        /// <summary>
        /// Move to the previous snippet field, if available.
        /// </summary>
        [<Import("prevSnippetField", "@codemirror/autocomplete")>]
        static member inline prevSnippetField: Glutinum.CodemirrorState.StateCommand = nativeOnly
        /// <summary>
        /// Check if there is an active snippet with a next field for
        /// <c>nextSnippetField</c> to move to.
        /// </summary>
        [<Import("hasNextSnippetField", "@codemirror/autocomplete")>]
        static member hasNextSnippetField (state: Glutinum.CodemirrorState.EditorState) : bool = nativeOnly
        /// <summary>
        /// Returns true if there is an active snippet and a previous field
        /// for <c>prevSnippetField</c> to move to.
        /// </summary>
        [<Import("hasPrevSnippetField", "@codemirror/autocomplete")>]
        static member hasPrevSnippetField (state: Glutinum.CodemirrorState.EditorState) : bool = nativeOnly
        /// <summary>
        /// A facet that can be used to configure the key bindings used by
        /// snippets. The default binds Tab to
        /// [<c>nextSnippetField</c>](https://codemirror.net/6/docs/ref/#autocomplete.nextSnippetField), Shift-Tab to
        /// [<c>prevSnippetField</c>](https://codemirror.net/6/docs/ref/#autocomplete.prevSnippetField), and Escape
        /// to [<c>clearSnippet</c>](https://codemirror.net/6/docs/ref/#autocomplete.clearSnippet).
        /// </summary>
        [<Import("snippetKeymap", "@codemirror/autocomplete")>]
        static member inline snippetKeymap: Glutinum.CodemirrorState.Facet<ReadonlyArray<Glutinum.CodemirrorView.KeyBinding>, ReadonlyArray<Glutinum.CodemirrorView.KeyBinding>> = nativeOnly
        /// <summary>
        /// Create a completion from a snippet. Returns an object with the
        /// properties from <c>completion</c>, plus an <c>apply</c> function that
        /// applies the snippet.
        /// </summary>
        [<Import("snippetCompletion", "@codemirror/autocomplete")>]
        static member snippetCompletion (template: string, completion: CodemirrorAutocomplete.Completion) : CodemirrorAutocomplete.Completion = nativeOnly
        /// <summary>
        /// Returns a command that moves the completion selection forward or
        /// backward by the given amount.
        /// </summary>
        [<Import("moveCompletionSelection", "@codemirror/autocomplete")>]
        static member moveCompletionSelection (forward: bool, ?by: Exports.moveCompletionSelection__.by) : Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Accept the current completion.
        /// </summary>
        [<Import("acceptCompletion", "@codemirror/autocomplete")>]
        static member inline acceptCompletion: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Explicitly start autocompletion.
        /// </summary>
        [<Import("startCompletion", "@codemirror/autocomplete")>]
        static member inline startCompletion: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Close the currently active completion.
        /// </summary>
        [<Import("closeCompletion", "@codemirror/autocomplete")>]
        static member inline closeCompletion: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// A completion source that will scan the document for words (using a
        /// [character categorizer](https://codemirror.net/6/docs/ref/#state.EditorState.charCategorizer)), and
        /// return those as completions.
        /// </summary>
        [<Import("completeAnyWord", "@codemirror/autocomplete")>]
        static member inline completeAnyWord: CodemirrorAutocomplete.CompletionSource = nativeOnly
        /// <summary>
        /// Extension to enable bracket-closing behavior. When a closeable
        /// bracket is typed, its closing bracket is immediately inserted
        /// after the cursor. When closing a bracket directly in front of a
        /// closing bracket inserted by the extension, the cursor moves over
        /// that bracket.
        /// </summary>
        [<Import("closeBrackets", "@codemirror/autocomplete")>]
        static member closeBrackets () : Glutinum.CodemirrorState.Extension = nativeOnly
        /// <summary>
        /// Command that implements deleting a pair of matching brackets when
        /// the cursor is between them.
        /// </summary>
        [<Import("deleteBracketPair", "@codemirror/autocomplete")>]
        static member inline deleteBracketPair: Glutinum.CodemirrorState.StateCommand = nativeOnly
        /// <summary>
        /// Close-brackets related key bindings. Binds Backspace to
        /// [<c>deleteBracketPair</c>](https://codemirror.net/6/docs/ref/#autocomplete.deleteBracketPair).
        /// </summary>
        [<Import("closeBracketsKeymap", "@codemirror/autocomplete")>]
        static member inline closeBracketsKeymap: ReadonlyArray<Glutinum.CodemirrorView.KeyBinding> = nativeOnly
        /// <summary>
        /// Implements the extension's behavior on text insertion. If the
        /// given string counts as a bracket in the language around the
        /// selection, and replacing the selection with it requires custom
        /// behavior (inserting a closing version or skipping past a
        /// previously-closed bracket), this function returns a transaction
        /// representing that custom behavior. (You only need this if you want
        /// to programmatically insert brackets—the
        /// [<c>closeBrackets</c>](https://codemirror.net/6/docs/ref/#autocomplete.closeBrackets) extension will
        /// take care of running this for user input.)
        /// </summary>
        [<Import("insertBracket", "@codemirror/autocomplete")>]
        static member insertBracket (state: Glutinum.CodemirrorState.EditorState, bracket: string) : Glutinum.CodemirrorState.Transaction option = nativeOnly
        /// <summary>
        /// Returns an extension that enables autocompletion.
        /// </summary>
        [<Import("autocompletion", "@codemirror/autocomplete")>]
        static member autocompletion (?config: CodemirrorAutocomplete.CompletionConfig) : Glutinum.CodemirrorState.Extension = nativeOnly
        /// <summary>
        /// Basic keybindings for autocompletion.
        ///
        /// - Ctrl-Space (and Alt-\<c> or Alt-i on macOS): [</c>startCompletion<c>](https://codemirror.net/6/docs/ref/#autocomplete.startCompletion)
        /// - Escape: [</c>closeCompletion<c>](https://codemirror.net/6/docs/ref/#autocomplete.closeCompletion)
        /// - ArrowDown: [</c>moveCompletionSelection<c>](https://codemirror.net/6/docs/ref/#autocomplete.moveCompletionSelection)</c>(true)<c>
        /// - ArrowUp: [</c>moveCompletionSelection<c>](https://codemirror.net/6/docs/ref/#autocomplete.moveCompletionSelection)</c>(false)<c>
        /// - PageDown: [</c>moveCompletionSelection<c>](https://codemirror.net/6/docs/ref/#autocomplete.moveCompletionSelection)</c>(true, "page")<c>
        /// - PageUp: [</c>moveCompletionSelection<c>](https://codemirror.net/6/docs/ref/#autocomplete.moveCompletionSelection)</c>(false, "page")<c>
        /// - Enter: [</c>acceptCompletion`](https://codemirror.net/6/docs/ref/#autocomplete.acceptCompletion)
        /// </summary>
        [<Import("completionKeymap", "@codemirror/autocomplete")>]
        static member inline completionKeymap: ReadonlyArray<Glutinum.CodemirrorView.KeyBinding> = nativeOnly
        /// <summary>
        /// Get the current completion status. When completions are available,
        /// this will return <c>"active"</c>. When completions are pending (in the
        /// process of being queried), this returns <c>"pending"</c>. Otherwise, it
        /// returns <c>null</c>.
        /// </summary>
        [<Import("completionStatus", "@codemirror/autocomplete")>]
        static member completionStatus (state: Glutinum.CodemirrorState.EditorState) : Exports.completionStatus__ = nativeOnly
        /// <summary>
        /// Returns the available completions as an array.
        /// </summary>
        [<Import("currentCompletions", "@codemirror/autocomplete")>]
        static member currentCompletions (state: Glutinum.CodemirrorState.EditorState) : ReadonlyArray<CodemirrorAutocomplete.Completion> = nativeOnly
        /// <summary>
        /// Return the currently selected completion, if any.
        /// </summary>
        [<Import("selectedCompletion", "@codemirror/autocomplete")>]
        static member selectedCompletion (state: Glutinum.CodemirrorState.EditorState) : CodemirrorAutocomplete.Completion option = nativeOnly
        /// <summary>
        /// Returns the currently selected position in the active completion
        /// list, or null if no completions are active.
        /// </summary>
        [<Import("selectedCompletionIndex", "@codemirror/autocomplete")>]
        static member selectedCompletionIndex (state: Glutinum.CodemirrorState.EditorState) : float option = nativeOnly
        /// <summary>
        /// Create an effect that can be attached to a transaction to change
        /// the currently selected completion.
        /// </summary>
        [<Import("setSelectedCompletion", "@codemirror/autocomplete")>]
        static member setSelectedCompletion (index: float) : Glutinum.CodemirrorState.StateEffect<obj> = nativeOnly
        /// <summary>
        /// Create a new completion context. (Mostly useful for testing
        /// completion sources—in the editor, the extension will create
        /// these for you.)
        /// </summary>
        [<Import("CompletionContext", "@codemirror/autocomplete"); EmitConstructor>]
        static member CompletionContext (state: Glutinum.CodemirrorState.EditorState, pos: float, explicit: bool, ?view: Glutinum.CodemirrorView.EditorView) : CompletionContext = nativeOnly

    /// <summary>
    /// Objects type used to represent individual completions.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type Completion =
        /// <summary>
        /// The label to show in the completion picker. This is what input
        /// is matched against to determine whether a completion matches (and
        /// how well it matches).
        /// </summary>
        abstract member label: string with get, set
        /// <summary>
        /// An optional override for the completion's visible label. When
        /// using this, matched characters will only be highlighted if you
        /// provide a [<c>getMatch</c>](https://codemirror.net/6/docs/ref/#autocomplete.CompletionResult.getMatch)
        /// function.
        /// </summary>
        abstract member displayLabel: string option with get, set
        /// <summary>
        /// Overrides the text that is used to sort completions. Will
        /// default to <c>label</c> if not given.
        /// </summary>
        abstract member sortText: string option with get, set
        /// <summary>
        /// An optional short piece of information to show (with a different
        /// style) after the label.
        /// </summary>
        abstract member detail: string option with get, set
        /// <summary>
        /// Additional info to show when the completion is selected. Can be
        /// a plain string or a function that'll render the DOM structure to
        /// show when invoked.
        /// </summary>
        abstract member info: U2<string, (CodemirrorAutocomplete.Completion -> U2<CodemirrorAutocomplete.CompletionInfo, JS.Promise<CodemirrorAutocomplete.CompletionInfo>>)> option with get, set
        /// <summary>
        /// How to apply the completion. The default is to replace it with
        /// its [label](https://codemirror.net/6/docs/ref/#autocomplete.Completion.label). When this holds a
        /// string, the completion range is replaced by that string. When it
        /// is a function, that function is called to perform the
        /// completion. If it fires a transaction, it is responsible for
        /// adding the [<c>pickedCompletion</c>](https://codemirror.net/6/docs/ref/#autocomplete.pickedCompletion)
        /// annotation to it.
        /// </summary>
        abstract member apply: U2<string, Completion.apply.U2.Case2> option with get, set
        /// <summary>
        /// The type of the completion. This is used to pick an icon to show
        /// for the completion. Icons are styled with a CSS class created by
        /// appending the type name to <c>"cm-completionIcon-"</c>. You can
        /// define or restyle icons by defining these selectors. The base
        /// library defines simple icons for <c>class</c>, <c>constant</c>, <c>enum</c>,
        /// <c>function</c>, <c>interface</c>, <c>keyword</c>, <c>method</c>, <c>namespace</c>,
        /// <c>property</c>, <c>text</c>, <c>type</c>, and <c>variable</c>.
        ///
        /// Multiple types can be provided by separating them with spaces.
        /// </summary>
        abstract member ``type``: string option with get, set
        /// <summary>
        /// When this option is selected, and one of these characters is
        /// typed, insert the completion before typing the character.
        /// </summary>
        abstract member commitCharacters: ReadonlyArray<string> option with get, set
        /// <summary>
        /// When given, should be a number from -99 to 99 that adjusts how
        /// this completion is ranked compared to other completions that
        /// match the input as well as this one. A negative number moves it
        /// down the list, a positive number moves it up.
        /// </summary>
        abstract member boost: float option with get, set
        /// <summary>
        /// Can be used to divide the completion list into sections.
        /// Completions in a given section (matched by name) will be grouped
        /// together, with a heading above them. Options without section
        /// will appear above all sections. A string value is equivalent to
        /// a <c>{name}</c> object.
        /// </summary>
        abstract member section: U2<string, CodemirrorAutocomplete.CompletionSection> option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (label: string, ?displayLabel: string, ?sortText: string, ?detail: string, ?info: U2<string, (CodemirrorAutocomplete.Completion -> U2<CodemirrorAutocomplete.CompletionInfo, JS.Promise<CodemirrorAutocomplete.CompletionInfo>>)>, ?apply: U2<string, Completion.apply.U2.Case2>, ?``type``: string, ?commitCharacters: ResizeArray<string>, ?boost: float, ?section: U2<string, CodemirrorAutocomplete.CompletionSection>) : Completion = nativeOnly

    /// <summary>
    /// The type returned from
    /// [<c>Completion.info</c>](https://codemirror.net/6/docs/ref/#autocomplete.Completion.info). May be a DOM
    /// node, null to indicate there is no info, or an object with an
    /// optional <c>destroy</c> method that cleans up the node.
    /// </summary>
    type CompletionInfo =
        U2<Glutinum.Web.Node, CompletionInfo.U2.Case2> option

    /// <summary>
    /// Object used to describe a completion
    /// [section](https://codemirror.net/6/docs/ref/#autocomplete.Completion.section). It is recommended to
    /// create a shared object used by all the completions in a given
    /// section.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type CompletionSection =
        /// <summary>
        /// The name of the section. If no <c>render</c> method is present, this
        /// will be displayed above the options.
        /// </summary>
        abstract member name: string with get, set
        /// <summary>
        /// An optional function that renders the section header. Since the
        /// headers are shown inside a list, you should make sure the
        /// resulting element has a <c>display: list-item</c> style.
        /// </summary>
        abstract member header: (CodemirrorAutocomplete.CompletionSection -> Glutinum.Web.HTMLElement) option with get, set
        /// <summary>
        /// By default, sections are ordered alphabetically by name. To
        /// specify an explicit order, <c>rank</c> can be used. Sections with a
        /// lower rank will be shown above sections with a higher rank.
        ///
        /// When set to <c>"dynamic"</c>, the section's position compared to
        /// other dynamic sections depends on the matching score of the
        /// best-matching option in the sections.
        /// </summary>
        abstract member rank: CompletionSection.rank option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (name: string, ?header: (CodemirrorAutocomplete.CompletionSection -> Glutinum.Web.HTMLElement), ?rank: CompletionSection.rank) : CompletionSection = nativeOnly

    /// <summary>
    /// An instance of this is passed to completion source functions.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("CompletionContext", "@codemirror/autocomplete")>]
    type CompletionContext =
        /// <summary>
        /// The editor state that the completion happens in.
        /// </summary>
        abstract member state: Glutinum.CodemirrorState.EditorState with get
        /// <summary>
        /// The position at which the completion is happening.
        /// </summary>
        abstract member pos: float with get
        /// <summary>
        /// Indicates whether completion was activated explicitly, or
        /// implicitly by typing. The usual way to respond to this is to
        /// only return completions when either there is part of a
        /// completable entity before the cursor, or <c>explicit</c> is true.
        /// </summary>
        abstract member explicit: bool with get
        /// <summary>
        /// The editor view. May be undefined if the context was created
        /// in a situation where there is no such view available, such as
        /// in synchronous updates via
        /// [<c>CompletionResult.update</c>](https://codemirror.net/6/docs/ref/#autocomplete.CompletionResult.update)
        /// or when called by test code.
        /// </summary>
        abstract member view: Glutinum.CodemirrorView.EditorView option with get
        /// <summary>
        /// Get the extent, content, and (if there is a token) type of the
        /// token before <c>this.pos</c>.
        /// </summary>
        abstract member tokenBefore: types: ResizeArray<string> -> CompletionContext.tokenBefore option
        /// <summary>
        /// Get the match of the given expression directly before the
        /// cursor.
        /// </summary>
        abstract member matchBefore: expr: RegExp -> CompletionContext.matchBefore option
        /// <summary>
        /// Yields true when the query has been aborted. Can be useful in
        /// asynchronous queries to avoid doing work that will be ignored.
        /// </summary>
        abstract member aborted: bool with get
        /// <summary>
        /// Allows you to register abort handlers, which will be called when
        /// the query is
        /// [aborted](https://codemirror.net/6/docs/ref/#autocomplete.CompletionContext.aborted).
        ///
        /// By default, running queries will not be aborted for regular
        /// typing or backspacing, on the assumption that they are likely to
        /// return a result with a
        /// [<c>validFor</c>](https://codemirror.net/6/docs/ref/#autocomplete.CompletionResult.validFor) field that
        /// allows the result to be used after all. Passing <c>onDocChange:
        /// true</c> will cause this query to be aborted for any document
        /// change.
        /// </summary>
        [<Emit("$0.addEventListener('abort',$1...)")>]
        abstract member addEventListener_abort: listener: (unit -> unit) * ?options: CompletionContext.addEventListener_abort.options -> unit

    /// <summary>
    /// The function signature for a completion source. Such a function
    /// may return its [result](https://codemirror.net/6/docs/ref/#autocomplete.CompletionResult)
    /// synchronously or as a promise. Returning null indicates no
    /// completions are available.
    /// </summary>
    type CompletionSource =
        CodemirrorAutocomplete.CompletionContext -> U2<CodemirrorAutocomplete.CompletionResult, JS.Promise<CodemirrorAutocomplete.CompletionResult option>> option

    /// <summary>
    /// Interface for objects returned by completion sources.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type CompletionResult =
        /// <summary>
        /// The start of the range that is being completed.
        /// </summary>
        abstract member from: float with get, set
        /// <summary>
        /// The end of the range that is being completed. Defaults to the
        /// main cursor position.
        /// </summary>
        abstract member ``to``: float option with get, set
        /// <summary>
        /// The completions returned. These don't have to be compared with
        /// the input by the source—the autocompletion system will do its
        /// own matching (against the text between <c>from</c> and <c>to</c>) and
        /// sorting.
        /// </summary>
        abstract member options: ReadonlyArray<CodemirrorAutocomplete.Completion> with get, set
        /// <summary>
        /// When given, further typing or deletion that causes the part of
        /// the document between ([mapped](https://codemirror.net/6/docs/ref/#state.ChangeDesc.mapPos)) <c>from</c>
        /// and <c>to</c> to match this regular expression or predicate function
        /// will not query the completion source again, but continue with
        /// this list of options. This can help a lot with responsiveness,
        /// since it allows the completion list to be updated synchronously.
        /// </summary>
        abstract member validFor: U2<RegExp, CompletionResult.validFor.U2.Case2> option with get, set
        /// <summary>
        /// By default, the library filters and scores completions. Set
        /// <c>filter</c> to <c>false</c> to disable this, and cause your completions
        /// to all be included, in the order they were given. When there are
        /// other sources, unfiltered completions appear at the top of the
        /// list of completions. <c>validFor</c> must not be given when <c>filter</c>
        /// is <c>false</c>, because it only works when filtering.
        /// </summary>
        abstract member filter: bool option with get, set
        /// <summary>
        /// When [<c>filter</c>](https://codemirror.net/6/docs/ref/#autocomplete.CompletionResult.filter) is set to
        /// <c>false</c> or a completion has a
        /// [<c>displayLabel</c>](https://codemirror.net/6/docs/ref/#autocomplete.Completion.displayLabel), this
        /// may be provided to compute the ranges on the label that match
        /// the input. Should return an array of numbers where each pair of
        /// adjacent numbers provide the start and end of a range. The
        /// second argument, the match found by the library, is only passed
        /// when <c>filter</c> isn't <c>false</c>.
        /// </summary>
        abstract member getMatch: CompletionResult.getMatch option with get, set
        /// <summary>
        /// Synchronously update the completion result after typing or
        /// deletion. If given, this should not do any expensive work, since
        /// it will be called during editor state updates. The function
        /// should make sure (similar to
        /// [<c>validFor</c>](https://codemirror.net/6/docs/ref/#autocomplete.CompletionResult.validFor)) that the
        /// completion still applies in the new state.
        /// </summary>
        abstract member update: CompletionResult.update option with get, set
        /// <summary>
        /// When results contain position-dependent information in, for
        /// example, <c>apply</c> methods, you can provide this method to update
        /// the result for transactions that happen after the query. It is
        /// not necessary to update <c>from</c> and <c>to</c>—those are tracked
        /// automatically.
        /// </summary>
        abstract member map: CompletionResult.map option with get, set
        /// <summary>
        /// Set a default set of [commit
        /// characters](https://codemirror.net/6/docs/ref/#autocomplete.Completion.commitCharacters) for all
        /// options in this result.
        /// </summary>
        abstract member commitCharacters: ReadonlyArray<string> option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (from: float, options: ResizeArray<CodemirrorAutocomplete.Completion>, ?``to``: float, ?filter: bool, ?getMatch: CompletionResult.getMatch, ?update: CompletionResult.update, ?map: CompletionResult.map, ?commitCharacters: ResizeArray<string>) : CompletionResult = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (from: float, options: ResizeArray<CodemirrorAutocomplete.Completion>, validFor: RegExp, ?``to``: float, ?filter: bool, ?getMatch: CompletionResult.getMatch, ?update: CompletionResult.update, ?map: CompletionResult.map, ?commitCharacters: ResizeArray<string>) : CompletionResult = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (from: float, options: ResizeArray<CodemirrorAutocomplete.Completion>, validFor: CompletionResult.validFor.U2.Case2, ?``to``: float, ?filter: bool, ?getMatch: CompletionResult.getMatch, ?update: CompletionResult.update, ?map: CompletionResult.map, ?commitCharacters: ResizeArray<string>) : CompletionResult = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type CompletionConfig =
        /// <summary>
        /// When enabled (defaults to true), autocompletion will start
        /// whenever the user types something that can be completed.
        /// </summary>
        abstract member activateOnTyping: bool option with get, set
        /// <summary>
        /// When given, if a completion that matches the predicate is
        /// picked, reactivate completion again as if it was typed normally.
        /// </summary>
        abstract member activateOnCompletion: (CodemirrorAutocomplete.Completion -> bool) option with get, set
        /// <summary>
        /// The amount of time to wait for further typing before querying
        /// completion sources via
        /// [<c>activateOnTyping</c>](https://codemirror.net/6/docs/ref/#autocomplete.autocompletion^config.activateOnTyping).
        /// Defaults to 100, which should be fine unless your completion
        /// source is very slow and/or doesn't use <c>validFor</c>.
        /// </summary>
        abstract member activateOnTypingDelay: float option with get, set
        /// <summary>
        /// By default, when completion opens, the first option is selected
        /// and can be confirmed with
        /// [<c>acceptCompletion</c>](https://codemirror.net/6/docs/ref/#autocomplete.acceptCompletion). When this
        /// is set to false, the completion widget starts with no completion
        /// selected, and the user has to explicitly move to a completion
        /// before you can confirm one.
        /// </summary>
        abstract member selectOnOpen: bool option with get, set
        /// <summary>
        /// Override the completion sources used. By default, they will be
        /// taken from the <c>"autocomplete"</c> [language
        /// data](https://codemirror.net/6/docs/ref/#state.EditorState.languageDataAt) (which should hold
        /// [completion sources](https://codemirror.net/6/docs/ref/#autocomplete.CompletionSource) or arrays
        /// of [completions](https://codemirror.net/6/docs/ref/#autocomplete.Completion)).
        /// </summary>
        abstract member ``override``: ReadonlyArray<CodemirrorAutocomplete.CompletionSource> option with get, set
        /// <summary>
        /// Determines whether the completion tooltip is closed when the
        /// editor loses focus. Defaults to true.
        /// </summary>
        abstract member closeOnBlur: bool option with get, set
        /// <summary>
        /// The maximum number of options to render to the DOM.
        /// </summary>
        abstract member maxRenderedOptions: float option with get, set
        /// <summary>
        /// Set this to false to disable the [default completion
        /// keymap](https://codemirror.net/6/docs/ref/#autocomplete.completionKeymap). (This requires you to
        /// add bindings to control completion yourself. The bindings should
        /// probably have a higher precedence than other bindings for the
        /// same keys.)
        /// </summary>
        abstract member defaultKeymap: bool option with get, set
        /// <summary>
        /// By default, completions are shown below the cursor when there is
        /// space. Setting this to true will make the extension put the
        /// completions above the cursor when possible.
        /// </summary>
        abstract member aboveCursor: bool option with get, set
        /// <summary>
        /// When given, this may return an additional CSS class to add to
        /// the completion dialog element.
        /// </summary>
        abstract member tooltipClass: (Glutinum.CodemirrorState.EditorState -> string) option with get, set
        /// <summary>
        /// This can be used to add additional CSS classes to completion
        /// options.
        /// </summary>
        abstract member optionClass: (CodemirrorAutocomplete.Completion -> string) option with get, set
        /// <summary>
        /// By default, the library will render icons based on the
        /// completion's [type](https://codemirror.net/6/docs/ref/#autocomplete.Completion.type) in front of
        /// each option. Set this to false to turn that off.
        /// </summary>
        abstract member icons: bool option with get, set
        /// <summary>
        /// This option can be used to inject additional content into
        /// options. The <c>render</c> function will be called for each visible
        /// completion, and should produce a DOM node to show. <c>position</c>
        /// determines where in the DOM the result appears, relative to
        /// other added widgets and the standard content. The default icons
        /// have position 20, the label position 50, and the detail position
        /// 80.
        /// </summary>
        abstract member addToOptions: ResizeArray<CompletionConfig.addToOptions.Item> option with get, set
        /// <summary>
        /// By default, [info](https://codemirror.net/6/docs/ref/#autocomplete.Completion.info) tooltips are
        /// placed to the side of the selected completion. This option can
        /// be used to override that. It will be given rectangles for the
        /// list of completions, the selected option, the info element, and
        /// the availble [tooltip
        /// space](https://codemirror.net/6/docs/ref/#view.tooltips^config.tooltipSpace), and should return
        /// style and/or class strings for the info element.
        /// </summary>
        abstract member positionInfo: CompletionConfig.positionInfo option with get, set
        /// <summary>
        /// The comparison function to use when sorting completions with the same
        /// match score. Defaults to using
        /// [<c>localeCompare</c>](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/String/localeCompare).
        /// </summary>
        abstract member compareCompletions: CompletionConfig.compareCompletions option with get, set
        /// <summary>
        /// When set to true (the default is false), turn off fuzzy matching
        /// of completions and only show those that start with the text the
        /// user typed. Only takes effect for results where
        /// [<c>filter</c>](https://codemirror.net/6/docs/ref/#autocomplete.CompletionResult.filter) isn't false.
        /// </summary>
        abstract member filterStrict: bool option with get, set
        /// <summary>
        /// By default, commands relating to an open completion only take
        /// effect 75 milliseconds after the completion opened, so that key
        /// presses made before the user is aware of the tooltip don't go to
        /// the tooltip. This option can be used to configure that delay.
        /// </summary>
        abstract member interactionDelay: float option with get, set
        /// <summary>
        /// When there are multiple asynchronous completion sources, this
        /// controls how long the extension waits for a slow source before
        /// displaying results from faster sources. Defaults to 100
        /// milliseconds.
        /// </summary>
        abstract member updateSyncTime: float option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?activateOnTyping: bool, ?activateOnCompletion: (CodemirrorAutocomplete.Completion -> bool), ?activateOnTypingDelay: float, ?selectOnOpen: bool, ?``override``: ResizeArray<CodemirrorAutocomplete.CompletionSource>, ?closeOnBlur: bool, ?maxRenderedOptions: float, ?defaultKeymap: bool, ?aboveCursor: bool, ?tooltipClass: (Glutinum.CodemirrorState.EditorState -> string), ?optionClass: (CodemirrorAutocomplete.Completion -> string), ?icons: bool, ?addToOptions: ResizeArray<CompletionConfig.addToOptions.Item>, ?positionInfo: CompletionConfig.positionInfo, ?compareCompletions: CompletionConfig.compareCompletions, ?filterStrict: bool, ?interactionDelay: float, ?updateSyncTime: float) : CompletionConfig = nativeOnly

    /// <summary>
    /// Configures bracket closing behavior for a syntax (via
    /// [language data](https://codemirror.net/6/docs/ref/#state.EditorState.languageDataAt)) using the <c>"closeBrackets"</c>
    /// identifier.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type CloseBracketConfig =
        /// <summary>
        /// The opening brackets to close. Defaults to <c>["(", "[", "{", "'",
        /// '"']</c>. Brackets may be single characters or a triple of quotes
        /// (as in <c>"'''"</c>).
        /// </summary>
        abstract member brackets: ResizeArray<string> option with get, set
        /// <summary>
        /// Characters in front of which newly opened brackets are
        /// automatically closed. Closing always happens in front of
        /// whitespace. Defaults to <c>")]}:;>"</c>.
        /// </summary>
        abstract member before: string option with get, set
        /// <summary>
        /// When determining whether a given node may be a string, recognize
        /// these prefixes before the opening quote.
        /// </summary>
        abstract member stringPrefixes: ResizeArray<string> option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?brackets: ResizeArray<string>, ?before: string, ?stringPrefixes: ResizeArray<string>) : CloseBracketConfig = nativeOnly

    module Completion =

        module apply =

            module U2 =

                type Case2 =
                    delegate of view: Glutinum.CodemirrorView.EditorView * completion: CodemirrorAutocomplete.Completion * from: float * ``to``: float -> unit

    module CompletionInfo =

        module U2 =

            [<AllowNullLiteral>]
            [<Interface>]
            type Case2 =
                abstract member dom: Glutinum.Web.Node with get, set
                abstract member destroy: (unit -> unit) option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (dom: Glutinum.Web.Node, ?destroy: (unit -> unit)) : Case2 = nativeOnly

    module CompletionSection =

        [<RequireQualifiedAccess>]
        [<Erase(CaseRules.None)>]
        type rank =
            | dynamic
            | Case1 of float

            [<Emit("$0")>]
            static member op_Implicit(value: float) : rank = nativeOnly

            [<Emit("$0")>]
            static member op_ErasedCast(value: float) : rank = nativeOnly

            /// Unchecked, the value as <c>Case1</c> whatever case it holds
            [<Emit("$0")>]
            member _.AsCase1: float = nativeOnly

    module CompletionContext =

        [<AllowNullLiteral>]
        [<Interface>]
        type tokenBefore =
            abstract member from: float with get, set
            abstract member ``to``: float with get, set
            abstract member text: string with get, set
            abstract member ``type``: Glutinum.LezerCommon.NodeType with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (from: float, ``to``: float, text: string, ``type``: Glutinum.LezerCommon.NodeType) : tokenBefore = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type matchBefore =
            abstract member from: float with get, set
            abstract member ``to``: float with get, set
            abstract member text: string with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (from: float, ``to``: float, text: string) : matchBefore = nativeOnly

        module addEventListener_abort =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member onDocChange: bool with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (onDocChange: bool) : options = nativeOnly

    module CompletionResult =

        type getMatch =
            delegate of completion: CodemirrorAutocomplete.Completion * ?matched: ResizeArray<float> -> ResizeArray<float>

        type update =
            delegate of current: CodemirrorAutocomplete.CompletionResult * from: float * ``to``: float * context: CodemirrorAutocomplete.CompletionContext -> CodemirrorAutocomplete.CompletionResult option

        type map =
            delegate of current: CodemirrorAutocomplete.CompletionResult * changes: Glutinum.CodemirrorState.ChangeDesc -> CodemirrorAutocomplete.CompletionResult option

        module validFor =

            module U2 =

                type Case2 =
                    delegate of text: string * from: float * ``to``: float * state: Glutinum.CodemirrorState.EditorState -> bool

    module CompletionConfig =

        type positionInfo =
            delegate of view: Glutinum.CodemirrorView.EditorView * list: Glutinum.CodemirrorView.Rect * option: Glutinum.CodemirrorView.Rect * info: Glutinum.CodemirrorView.Rect * space: Glutinum.CodemirrorView.Rect -> CompletionConfig.positionInfo.ReturnType

        type compareCompletions =
            delegate of a: CodemirrorAutocomplete.Completion * b: CodemirrorAutocomplete.Completion -> float

        module addToOptions =

            [<AllowNullLiteral>]
            [<Interface>]
            type Item =
                abstract member render: CompletionConfig.addToOptions.Item.render with get, set
                abstract member position: float with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (render: CompletionConfig.addToOptions.Item.render, position: float) : Item = nativeOnly

            module Item =

                type render =
                    delegate of completion: CodemirrorAutocomplete.Completion * state: Glutinum.CodemirrorState.EditorState * view: Glutinum.CodemirrorView.EditorView -> Glutinum.Web.Node option

        module positionInfo =

            [<AllowNullLiteral>]
            [<Interface>]
            type ReturnType =
                abstract member style: string option with get, set
                abstract member ``class``: string option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?style: string, ?``class``: string) : ReturnType = nativeOnly

    module Exports =

        type snippet__ =
            delegate of editor: Exports.snippet__.editor * completion: CodemirrorAutocomplete.Completion option * from: float * ``to``: float -> unit

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type completionStatus__ =
            | active
            | pending

        module snippet__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type editor =
                abstract member state: Glutinum.CodemirrorState.EditorState with get, set
                abstract member dispatch: (Glutinum.CodemirrorState.Transaction -> unit) with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (state: Glutinum.CodemirrorState.EditorState, dispatch: (Glutinum.CodemirrorState.Transaction -> unit)) : editor = nativeOnly

        module moveCompletionSelection__ =

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type by =
                | option
                | page
