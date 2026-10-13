namespace rec Glutinum

open Fable.Core
open Fable.Core.JsInterop
open System

// You need to add Glutinum.Types NuGet package to your project
open Glutinum.Types.TypeScript

// You need to add Glutinum.Web NuGet package to your project

// You need to add Glutinum.CodemirrorState NuGet package to your project

// You need to add Glutinum.LezerCommon NuGet package to your project

// You need to add Glutinum.LezerHighlight NuGet package to your project

type RegExp = Text.RegularExpressions.Regex

module CodemirrorLanguage =

    [<AbstractClass>]
    [<Erase>]
    type Exports =
        /// <summary>
        /// Node prop stored in a parser's top syntax node to provide the
        /// facet that stores language-specific data for that language.
        /// </summary>
        [<Import("languageDataProp", "@codemirror/language")>]
        static member inline languageDataProp: Glutinum.LezerCommon.NodeProp<Glutinum.CodemirrorState.Facet<Exports.languageDataProp__.Type, ReadonlyArray<Exports.languageDataProp__.Type.Item>>> = nativeOnly
        /// <summary>
        /// Helper function to define a facet (to be added to the top syntax
        /// node(s) for a language via
        /// [<c>languageDataProp</c>](https://codemirror.net/6/docs/ref/#language.languageDataProp)), that will be
        /// used to associate language data with the language. You
        /// probably only need this when subclassing
        /// [<c>Language</c>](https://codemirror.net/6/docs/ref/#language.Language).
        /// </summary>
        [<Import("defineLanguageFacet", "@codemirror/language")>]
        static member defineLanguageFacet (?baseData: Exports.defineLanguageFacet__.baseData) : Glutinum.CodemirrorState.Facet<Exports.defineLanguageFacet__, ReadonlyArray<Exports.defineLanguageFacet__.Item>> = nativeOnly
        /// <summary>
        /// Helper function to define a facet (to be added to the top syntax
        /// node(s) for a language via
        /// [<c>languageDataProp</c>](https://codemirror.net/6/docs/ref/#language.languageDataProp)), that will be
        /// used to associate language data with the language. You
        /// probably only need this when subclassing
        /// [<c>Language</c>](https://codemirror.net/6/docs/ref/#language.Language).
        /// </summary>
        [<Import("defineLanguageFacet", "@codemirror/language")>]
        static member defineLanguageFacet () : Glutinum.CodemirrorState.Facet<Exports.defineLanguageFacet__, ReadonlyArray<Exports.defineLanguageFacet__.Item>> = nativeOnly
        /// <summary>
        /// Helper function to define a facet (to be added to the top syntax
        /// node(s) for a language via
        /// [<c>languageDataProp</c>](https://codemirror.net/6/docs/ref/#language.languageDataProp)), that will be
        /// used to associate language data with the language. You
        /// probably only need this when subclassing
        /// [<c>Language</c>](https://codemirror.net/6/docs/ref/#language.Language).
        /// </summary>
        [<Import("defineLanguageFacet", "@codemirror/language")>]
        static member defineLanguageFacet<'BaseData> (?baseData: 'BaseData) : Glutinum.CodemirrorState.Facet<Exports.defineLanguageFacet__, ReadonlyArray<Exports.defineLanguageFacet__.Item>> = nativeOnly
        /// <summary>
        /// Syntax node prop used to register sublanguages. Should be added to
        /// the top level node type for the language.
        /// </summary>
        [<Import("sublanguageProp", "@codemirror/language")>]
        static member inline sublanguageProp: Glutinum.LezerCommon.NodeProp<ResizeArray<CodemirrorLanguage.Sublanguage>> = nativeOnly
        /// <summary>
        /// Get the syntax tree for a state, which is the current (possibly
        /// incomplete) parse tree of the active
        /// [language](https://codemirror.net/6/docs/ref/#language.Language), or the empty tree if there is no
        /// language available.
        /// </summary>
        [<Import("syntaxTree", "@codemirror/language")>]
        static member syntaxTree (state: Glutinum.CodemirrorState.EditorState) : Glutinum.LezerCommon.Tree = nativeOnly
        /// <summary>
        /// Try to get a parse tree that spans at least up to <c>upto</c>. The
        /// method will do at most <c>timeout</c> milliseconds of work to parse
        /// up to that point if the tree isn't already available.
        /// </summary>
        [<Import("ensureSyntaxTree", "@codemirror/language")>]
        static member ensureSyntaxTree (state: Glutinum.CodemirrorState.EditorState, upto: float, ?timeout: float) : Glutinum.LezerCommon.Tree option = nativeOnly
        /// <summary>
        /// Queries whether there is a full syntax tree available up to the
        /// given document position. If there isn't, the background parse
        /// process _might_ still be working and update the tree further, but
        /// there is no guarantee of that—the parser will [stop
        /// working](https://codemirror.net/6/docs/ref/#language.syntaxParserRunning) when it has spent a
        /// certain amount of time or has moved beyond the visible viewport.
        /// Always returns false if no language has been enabled.
        /// </summary>
        [<Import("syntaxTreeAvailable", "@codemirror/language")>]
        static member syntaxTreeAvailable (state: Glutinum.CodemirrorState.EditorState, ?upto: float) : bool = nativeOnly
        /// <summary>
        /// Move parsing forward, and update the editor state afterwards to
        /// reflect the new tree. Will work for at most <c>timeout</c>
        /// milliseconds. Returns true if the parser managed get to the given
        /// position in that time.
        /// </summary>
        [<Import("forceParsing", "@codemirror/language")>]
        static member forceParsing (view: CodemirrorView.EditorView, ?upto: float, ?timeout: float) : bool = nativeOnly
        /// <summary>
        /// Tells you whether the language parser is planning to do more
        /// parsing work (in a <c>requestIdleCallback</c> pseudo-thread) or has
        /// stopped running, either because it parsed the entire document,
        /// because it spent too much time and was cut off, or because there
        /// is no language parser enabled.
        /// </summary>
        [<Import("syntaxParserRunning", "@codemirror/language")>]
        static member syntaxParserRunning (view: CodemirrorView.EditorView) : bool = nativeOnly
        /// <summary>
        /// The facet used to associate a language with an editor state. Used
        /// by <c>Language</c> object's <c>extension</c> property (so you don't need to
        /// manually wrap your languages in this). Can be used to access the
        /// current language on a state.
        /// </summary>
        [<Import("language", "@codemirror/language")>]
        static member inline language: Glutinum.CodemirrorState.Facet<CodemirrorLanguage.Language, CodemirrorLanguage.Language option> = nativeOnly
        /// <summary>
        /// Facet that defines a way to provide a function that computes the
        /// appropriate indentation depth, as a column number (see
        /// [<c>indentString</c>](https://codemirror.net/6/docs/ref/#language.indentString)), at the start of a given
        /// line. A return value of <c>null</c> indicates no indentation can be
        /// determined, and the line should inherit the indentation of the one
        /// above it. A return value of <c>undefined</c> defers to the next indent
        /// service.
        /// </summary>
        [<Import("indentService", "@codemirror/language")>]
        static member inline indentService: Glutinum.CodemirrorState.Facet<Exports.indentService__.Type, ReadonlyArray<Exports.indentService__.Type.Item>> = nativeOnly
        /// <summary>
        /// Facet for overriding the unit by which indentation happens. Should
        /// be a string consisting entirely of the same whitespace character.
        /// When not set, this defaults to 2 spaces.
        /// </summary>
        [<Import("indentUnit", "@codemirror/language")>]
        static member inline indentUnit: Glutinum.CodemirrorState.Facet<string, string> = nativeOnly
        /// <summary>
        /// Return the _column width_ of an indent unit in the state.
        /// Determined by the [<c>indentUnit</c>](https://codemirror.net/6/docs/ref/#language.indentUnit)
        /// facet, and [<c>tabSize</c>](https://codemirror.net/6/docs/ref/#state.EditorState^tabSize) when that
        /// contains tabs.
        /// </summary>
        [<Import("getIndentUnit", "@codemirror/language")>]
        static member getIndentUnit (state: Glutinum.CodemirrorState.EditorState) : float = nativeOnly
        /// <summary>
        /// Create an indentation string that covers columns 0 to <c>cols</c>.
        /// Will use tabs for as much of the columns as possible when the
        /// [<c>indentUnit</c>](https://codemirror.net/6/docs/ref/#language.indentUnit) facet contains
        /// tabs.
        /// </summary>
        [<Import("indentString", "@codemirror/language")>]
        static member indentString (state: Glutinum.CodemirrorState.EditorState, cols: float) : string = nativeOnly
        /// <summary>
        /// Get the indentation, as a column number, at the given position.
        /// Will first consult any [indent services](https://codemirror.net/6/docs/ref/#language.indentService)
        /// that are registered, and if none of those return an indentation,
        /// this will check the syntax tree for the [indent node
        /// prop](https://codemirror.net/6/docs/ref/#language.indentNodeProp) and use that if found. Returns a
        /// number when an indentation could be determined, and null
        /// otherwise.
        /// </summary>
        [<Import("getIndentation", "@codemirror/language")>]
        static member getIndentation (context: CodemirrorLanguage.IndentContext, pos: float) : float option = nativeOnly
        /// <summary>
        /// Get the indentation, as a column number, at the given position.
        /// Will first consult any [indent services](https://codemirror.net/6/docs/ref/#language.indentService)
        /// that are registered, and if none of those return an indentation,
        /// this will check the syntax tree for the [indent node
        /// prop](https://codemirror.net/6/docs/ref/#language.indentNodeProp) and use that if found. Returns a
        /// number when an indentation could be determined, and null
        /// otherwise.
        /// </summary>
        [<Import("getIndentation", "@codemirror/language")>]
        static member getIndentation (context: Glutinum.CodemirrorState.EditorState, pos: float) : float option = nativeOnly
        /// <summary>
        /// Create a change set that auto-indents all lines touched by the
        /// given document range.
        /// </summary>
        [<Import("indentRange", "@codemirror/language")>]
        static member indentRange (state: Glutinum.CodemirrorState.EditorState, from: float, ``to``: float) : Glutinum.CodemirrorState.ChangeSet = nativeOnly
        /// <summary>
        /// A syntax tree node prop used to associate indentation strategies
        /// with node types. Such a strategy is a function from an indentation
        /// context to a column number (see also
        /// [<c>indentString</c>](https://codemirror.net/6/docs/ref/#language.indentString)) or null, where null
        /// indicates that no definitive indentation can be determined.
        /// </summary>
        [<Import("indentNodeProp", "@codemirror/language")>]
        static member inline indentNodeProp: Glutinum.LezerCommon.NodeProp<(CodemirrorLanguage.TreeIndentContext -> float option)> = nativeOnly
        /// <summary>
        /// An indentation strategy for delimited (usually bracketed) nodes.
        /// Will, by default, indent one unit more than the parent's base
        /// indent unless the line starts with a closing token. When <c>align</c>
        /// is true and there are non-skipped nodes on the node's opening
        /// line, the content of the node will be aligned with the end of the
        /// opening node, like this:
        ///
        ///   foo(bar,
        ///       baz)
        /// </summary>
        [<Import("delimitedIndent", "@codemirror/language")>]
        static member delimitedIndent (arg0: Exports.delimitedIndent__.arg0) : (CodemirrorLanguage.TreeIndentContext -> float) = nativeOnly
        /// <summary>
        /// An indentation strategy that aligns a node's content to its base
        /// indentation.
        /// </summary>
        [<Import("flatIndent", "@codemirror/language")>]
        static member inline flatIndent: (CodemirrorLanguage.TreeIndentContext -> float) = nativeOnly
        /// <summary>
        /// Creates an indentation strategy that, by default, indents
        /// continued lines one unit more than the node's base indentation.
        /// You can provide <c>except</c> to prevent indentation of lines that
        /// match a pattern (for example <c>/^else\b/</c> in <c>if</c>/<c>else</c>
        /// constructs), and you can change the amount of units used with the
        /// <c>units</c> option.
        /// </summary>
        [<Import("continuedIndent", "@codemirror/language")>]
        static member continuedIndent (?arg0: Exports.continuedIndent__.arg0) : (CodemirrorLanguage.TreeIndentContext -> float) = nativeOnly
        /// <summary>
        /// Enables reindentation on input. When a language defines an
        /// <c>indentOnInput</c> field in its [language
        /// data](https://codemirror.net/6/docs/ref/#state.EditorState.languageDataAt), which must hold a regular
        /// expression, the line at the cursor will be reindented whenever new
        /// text is typed and the input from the start of the line up to the
        /// cursor matches that regexp.
        ///
        /// To avoid unneccesary reindents, it is recommended to start the
        /// regexp with <c>^</c> (usually followed by <c>\s*</c>), and end it with <c>$</c>.
        /// For example, <c>/^\s*\}$/</c> will reindent when a closing brace is
        /// added at the start of a line.
        /// </summary>
        [<Import("indentOnInput", "@codemirror/language")>]
        static member indentOnInput () : Glutinum.CodemirrorState.Extension = nativeOnly
        /// <summary>
        /// A facet that registers a code folding service. When called with
        /// the extent of a line, such a function should return a foldable
        /// range that starts on that line (but continues beyond it), if one
        /// can be found.
        /// </summary>
        [<Import("foldService", "@codemirror/language")>]
        static member inline foldService: Glutinum.CodemirrorState.Facet<Exports.foldService__.Type, ReadonlyArray<Exports.foldService__.Type.Item>> = nativeOnly
        /// <summary>
        /// This node prop is used to associate folding information with
        /// syntax node types. Given a syntax node, it should check whether
        /// that tree is foldable and return the range that can be collapsed
        /// when it is.
        /// </summary>
        [<Import("foldNodeProp", "@codemirror/language")>]
        static member inline foldNodeProp: Glutinum.LezerCommon.NodeProp<Exports.foldNodeProp__.Type> = nativeOnly
        /// <summary>
        /// [Fold](https://codemirror.net/6/docs/ref/#language.foldNodeProp) function that folds everything but
        /// the first and the last child of a syntax node. Useful for nodes
        /// that start and end with delimiters.
        /// </summary>
        [<Import("foldInside", "@codemirror/language")>]
        static member foldInside (node: Glutinum.LezerCommon.SyntaxNode) : Exports.foldInside__ option = nativeOnly
        /// <summary>
        /// Check whether the given line is foldable. First asks any fold
        /// services registered through
        /// [<c>foldService</c>](https://codemirror.net/6/docs/ref/#language.foldService), and if none of them return
        /// a result, tries to query the [fold node
        /// prop](https://codemirror.net/6/docs/ref/#language.foldNodeProp) of syntax nodes that cover the end
        /// of the line.
        /// </summary>
        [<Import("foldable", "@codemirror/language")>]
        static member foldable (state: Glutinum.CodemirrorState.EditorState, lineStart: float, lineEnd: float) : Exports.foldable__ option = nativeOnly
        /// <summary>
        /// State effect that can be attached to a transaction to fold the
        /// given range. (You probably only need this in exceptional
        /// circumstances—usually you'll just want to let
        /// [<c>foldCode</c>](https://codemirror.net/6/docs/ref/#language.foldCode) and the [fold
        /// gutter](https://codemirror.net/6/docs/ref/#language.foldGutter) create the transactions.)
        /// </summary>
        [<Import("foldEffect", "@codemirror/language")>]
        static member inline foldEffect: Glutinum.CodemirrorState.StateEffectType<CodemirrorLanguage.DocRange> = nativeOnly
        /// <summary>
        /// State effect that unfolds the given range (if it was folded).
        /// </summary>
        [<Import("unfoldEffect", "@codemirror/language")>]
        static member inline unfoldEffect: Glutinum.CodemirrorState.StateEffectType<CodemirrorLanguage.DocRange> = nativeOnly
        /// <summary>
        /// The state field that stores the folded ranges (as a [decoration
        /// set](https://codemirror.net/6/docs/ref/#view.DecorationSet)). Can be passed to
        /// [<c>EditorState.toJSON</c>](https://codemirror.net/6/docs/ref/#state.EditorState.toJSON) and
        /// [<c>fromJSON</c>](https://codemirror.net/6/docs/ref/#state.EditorState^fromJSON) to serialize the fold
        /// state.
        /// </summary>
        [<Import("foldState", "@codemirror/language")>]
        static member inline foldState: Glutinum.CodemirrorState.StateField<CodemirrorView.DecorationSet> = nativeOnly
        /// <summary>
        /// Get a [range set](https://codemirror.net/6/docs/ref/#state.RangeSet) containing the folded ranges
        /// in the given state.
        /// </summary>
        [<Import("foldedRanges", "@codemirror/language")>]
        static member foldedRanges (state: Glutinum.CodemirrorState.EditorState) : CodemirrorView.DecorationSet = nativeOnly
        /// <summary>
        /// Fold the lines that are selected, if possible.
        /// </summary>
        [<Import("foldCode", "@codemirror/language")>]
        static member inline foldCode: CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Unfold folded ranges on selected lines.
        /// </summary>
        [<Import("unfoldCode", "@codemirror/language")>]
        static member inline unfoldCode: CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Fold all top-level foldable ranges. Note that, in most cases,
        /// folding information will depend on the [syntax
        /// tree](https://codemirror.net/6/docs/ref/#language.syntaxTree), and folding everything may not work
        /// reliably when the document hasn't been fully parsed (either
        /// because the editor state was only just initialized, or because the
        /// document is so big that the parser decided not to parse it
        /// entirely).
        /// </summary>
        [<Import("foldAll", "@codemirror/language")>]
        static member inline foldAll: CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Unfold all folded code.
        /// </summary>
        [<Import("unfoldAll", "@codemirror/language")>]
        static member inline unfoldAll: CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Toggle folding at cursors. Unfolds if there is an existing fold
        /// starting in that line, tries to find a foldable range around it
        /// otherwise.
        /// </summary>
        [<Import("toggleFold", "@codemirror/language")>]
        static member inline toggleFold: CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Default fold-related key bindings.
        ///
        /// - Ctrl-Shift-[ (Cmd-Alt-[ on macOS): [<c>foldCode</c>](https://codemirror.net/6/docs/ref/#language.foldCode).
        /// - Ctrl-Shift-] (Cmd-Alt-] on macOS): [<c>unfoldCode</c>](https://codemirror.net/6/docs/ref/#language.unfoldCode).
        /// - Ctrl-Alt-[: [<c>foldAll</c>](https://codemirror.net/6/docs/ref/#language.foldAll).
        /// - Ctrl-Alt-]: [<c>unfoldAll</c>](https://codemirror.net/6/docs/ref/#language.unfoldAll).
        /// </summary>
        [<Import("foldKeymap", "@codemirror/language")>]
        static member inline foldKeymap: ReadonlyArray<CodemirrorView.KeyBinding> = nativeOnly
        /// <summary>
        /// Create an extension that configures code folding.
        /// </summary>
        [<Import("codeFolding", "@codemirror/language")>]
        static member codeFolding (?config: CodemirrorLanguage.FoldConfig) : Glutinum.CodemirrorState.Extension = nativeOnly
        /// <summary>
        /// Create an extension that registers a fold gutter, which shows a
        /// fold status indicator before foldable lines (which can be clicked
        /// to fold or unfold the line).
        /// </summary>
        [<Import("foldGutter", "@codemirror/language")>]
        static member foldGutter (?config: CodemirrorLanguage.FoldGutterConfig) : Glutinum.CodemirrorState.Extension = nativeOnly
        /// <summary>
        /// Wrap a highlighter in an editor extension that uses it to apply
        /// syntax highlighting to the editor content.
        ///
        /// When multiple (non-fallback) styles are provided, the styling
        /// applied is the union of the classes they emit.
        /// </summary>
        [<Import("syntaxHighlighting", "@codemirror/language")>]
        static member syntaxHighlighting (highlighter: Glutinum.LezerHighlight.Highlighter, ?options: Exports.syntaxHighlighting__.options) : Glutinum.CodemirrorState.Extension = nativeOnly
        /// <summary>
        /// Returns the CSS classes (if any) that the highlighters active in
        /// the state would assign to the given style
        /// [tags](https://lezer.codemirror.net/docs/ref#highlight.Tag) and
        /// (optional) language
        /// [scope](https://codemirror.net/6/docs/ref/#language.HighlightStyle^define^options.scope).
        /// </summary>
        [<Import("highlightingFor", "@codemirror/language")>]
        static member highlightingFor (state: Glutinum.CodemirrorState.EditorState, tags: ResizeArray<Glutinum.LezerHighlight.Tag>, ?scope: Glutinum.LezerCommon.NodeType) : string option = nativeOnly
        /// <summary>
        /// A default highlight style (works well with light themes).
        /// </summary>
        [<Import("defaultHighlightStyle", "@codemirror/language")>]
        static member inline defaultHighlightStyle: CodemirrorLanguage.HighlightStyle = nativeOnly
        /// <summary>
        /// Create an extension that enables bracket matching. Whenever the
        /// cursor is next to a bracket, that bracket and the one it matches
        /// are highlighted. Or, when no matching bracket is found, another
        /// highlighting style is used to indicate this.
        /// </summary>
        [<Import("bracketMatching", "@codemirror/language")>]
        static member bracketMatching (?config: CodemirrorLanguage.Config) : Glutinum.CodemirrorState.Extension = nativeOnly
        /// <summary>
        /// When larger syntax nodes, such as HTML tags, are marked as
        /// opening/closing, it can be a bit messy to treat the whole node as
        /// a matchable bracket. This node prop allows you to define, for such
        /// a node, a ‘handle’—the part of the node that is highlighted, and
        /// that the cursor must be on to activate highlighting in the first
        /// place.
        /// </summary>
        [<Import("bracketMatchingHandle", "@codemirror/language")>]
        static member inline bracketMatchingHandle: Glutinum.LezerCommon.NodeProp<(Glutinum.LezerCommon.SyntaxNode -> Glutinum.LezerCommon.SyntaxNode option)> = nativeOnly
        /// <summary>
        /// Find the matching bracket for the token at <c>pos</c>, scanning
        /// direction <c>dir</c>. Only the <c>brackets</c> and <c>maxScanDistance</c>
        /// properties are used from <c>config</c>, if given. Returns null if no
        /// bracket was found at <c>pos</c>, or a match result otherwise.
        /// </summary>
        [<Import("matchBrackets", "@codemirror/language")>]
        static member matchBrackets (state: Glutinum.CodemirrorState.EditorState, pos: float, dir: Exports.matchBrackets__.dir, ?config: CodemirrorLanguage.Config) : CodemirrorLanguage.MatchResult option = nativeOnly
        /// <summary>
        /// Make sure nodes
        /// [marked](https://lezer.codemirror.net/docs/ref/#common.NodeProp^isolate)
        /// as isolating for bidirectional text are rendered in a way that
        /// isolates them from the surrounding text.
        /// </summary>
        [<Import("bidiIsolates", "@codemirror/language")>]
        static member bidiIsolates (?options: Exports.bidiIsolates__.options) : Glutinum.CodemirrorState.Extension = nativeOnly
        /// <summary>
        /// Construct a language object. If you need to invoke this
        /// directly, first define a data facet with
        /// [<c>defineLanguageFacet</c>](https://codemirror.net/6/docs/ref/#language.defineLanguageFacet), and then
        /// configure your parser to [attach](https://codemirror.net/6/docs/ref/#language.languageDataProp) it
        /// to the language's outer syntax node.
        /// </summary>
        [<Import("Language", "@codemirror/language"); EmitConstructor>]
        static member Language (data: Glutinum.CodemirrorState.Facet<Exports.Language.data>, parser: Glutinum.LezerCommon.Parser, ?extraExtensions: ResizeArray<Glutinum.CodemirrorState.Extension>, ?name: string) : Language = nativeOnly
        [<Import("LRLanguage", "@codemirror/language"); EmitConstructor>]
        static member LRLanguage () : LRLanguage = nativeOnly
        /// <summary>
        /// Create an input object for the given document.
        /// </summary>
        [<Import("DocInput", "@codemirror/language"); EmitConstructor>]
        static member DocInput (doc: Glutinum.CodemirrorState.Text) : DocInput = nativeOnly
        [<Import("ParseContext", "@codemirror/language"); EmitConstructor>]
        static member ParseContext () : ParseContext = nativeOnly
        /// <summary>
        /// Create a language support object.
        /// </summary>
        [<Import("LanguageSupport", "@codemirror/language"); EmitConstructor>]
        static member LanguageSupport (language: CodemirrorLanguage.Language, ?support: Glutinum.CodemirrorState.Extension) : LanguageSupport = nativeOnly
        [<Import("LanguageDescription", "@codemirror/language"); EmitConstructor>]
        static member LanguageDescription () : LanguageDescription = nativeOnly
        /// <summary>
        /// Create an indent context.
        /// </summary>
        [<Import("IndentContext", "@codemirror/language"); EmitConstructor>]
        static member IndentContext (state: Glutinum.CodemirrorState.EditorState, ?options: Exports.IndentContext.options) : IndentContext = nativeOnly
        [<Import("TreeIndentContext", "@codemirror/language"); EmitConstructor>]
        static member TreeIndentContext () : TreeIndentContext = nativeOnly
        [<Import("HighlightStyle", "@codemirror/language"); EmitConstructor>]
        static member HighlightStyle () : HighlightStyle = nativeOnly
        [<Import("StreamLanguage", "@codemirror/language"); EmitConstructor>]
        static member StreamLanguage<'State> () : StreamLanguage<'State> = nativeOnly
        /// <summary>
        /// Create a stream.
        /// </summary>
        [<Import("StringStream", "@codemirror/language"); EmitConstructor>]
        static member StringStream (string: string, tabSize: float, indentUnit: float, ?overrideIndent: float) : StringStream = nativeOnly

    type StringStream =
        CodemirrorStreamparser.StringStream

    /// <summary>
    /// Some languages need to return different [language
    /// data](https://codemirror.net/6/docs/ref/#state.EditorState.languageDataAt) for some parts of their
    /// tree. Sublanguages, registered by adding a [node
    /// prop](https://codemirror.net/6/docs/ref/#language.sublanguageProp) to the language's top syntax
    /// node, provide a mechanism to do this.
    ///
    /// (Note that when using nested parsing, where nested syntax is
    /// parsed by a different parser and has its own top node type, you
    /// don't need a sublanguage.)
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type Sublanguage =
        /// <summary>
        /// Determines whether the data provided by this sublanguage should
        /// completely replace the regular data or be added to it (with
        /// higher-precedence). The default is <c>"extend"</c>.
        /// </summary>
        abstract member ``type``: Sublanguage.``type`` option with get, set
        /// <summary>
        /// A predicate that returns whether the node at the queried
        /// position is part of the sublanguage.
        /// </summary>
        abstract member test: Sublanguage.test with get, set
        /// <summary>
        /// The language data facet that holds the sublanguage's data.
        /// You'll want to use
        /// [<c>defineLanguageFacet</c>](https://codemirror.net/6/docs/ref/#language.defineLanguageFacet) to create
        /// this.
        /// </summary>
        abstract member facet: Glutinum.CodemirrorState.Facet<Sublanguage.facet> with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (test: Sublanguage.test, facet: Glutinum.CodemirrorState.Facet<Sublanguage.facet>, ?``type``: Sublanguage.``type``) : Sublanguage = nativeOnly

    /// <summary>
    /// A language object manages parsing and per-language
    /// [metadata](https://codemirror.net/6/docs/ref/#state.EditorState.languageDataAt). Parse data is
    /// managed as a [Lezer](https://lezer.codemirror.net) tree. The class
    /// can be used directly, via the [<c>LRLanguage</c>](https://codemirror.net/6/docs/ref/#language.LRLanguage)
    /// subclass for [Lezer](https://lezer.codemirror.net/) LR parsers, or
    /// via the [<c>StreamLanguage</c>](https://codemirror.net/6/docs/ref/#language.StreamLanguage) subclass
    /// for stream parsers.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("Language", "@codemirror/language")>]
    type Language =
        /// <summary>
        /// The [language data](https://codemirror.net/6/docs/ref/#state.EditorState.languageDataAt) facet
        /// used for this language.
        /// </summary>
        abstract member data: Glutinum.CodemirrorState.Facet<Language.data> with get
        /// <summary>
        /// A language name.
        /// </summary>
        abstract member name: string with get
        /// <summary>
        /// The extension value to install this as the document language.
        /// </summary>
        abstract member extension: Glutinum.CodemirrorState.Extension with get
        /// <summary>
        /// The parser object. Can be useful when using this as a [nested
        /// parser](https://lezer.codemirror.net/docs/ref#common.Parser).
        /// </summary>
        abstract member parser: Glutinum.LezerCommon.Parser with get, set
        /// <summary>
        /// Query whether this language is active at the given position.
        /// </summary>
        abstract member isActiveAt: state: Glutinum.CodemirrorState.EditorState * pos: float * ?side: Language.isActiveAt.side -> bool
        /// <summary>
        /// Find the document regions that were parsed using this language.
        /// The returned regions will _include_ any nested languages rooted
        /// in this language, when those exist.
        /// </summary>
        abstract member findRegions: state: Glutinum.CodemirrorState.EditorState -> ResizeArray<Language.findRegions.Item>
        /// <summary>
        /// Indicates whether this language allows nested languages. The
        /// default implementation returns true.
        /// </summary>
        abstract member allowsNesting: bool with get

    /// <summary>
    /// A subclass of [<c>Language</c>](https://codemirror.net/6/docs/ref/#language.Language) for use with Lezer
    /// [LR parsers](https://lezer.codemirror.net/docs/ref#lr.LRParser).
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("LRLanguage", "@codemirror/language")>]
    type LRLanguage =
        inherit CodemirrorLanguage.Language
        /// <summary>
        /// Define a language from a parser.
        /// </summary>
        [<Emit("""import { LRLanguage } from "@codemirror/language";
LRLanguage.define($0)""")>]
        static member inline define (spec: LRLanguage.define__.spec): CodemirrorLanguage.LRLanguage = nativeOnly
        /// <summary>
        /// Create a new instance of this language with a reconfigured
        /// version of its parser and optionally a new name.
        /// </summary>
        abstract member configure: options: LezerLr.ParserConfig * ?name: string -> CodemirrorLanguage.LRLanguage
        /// <summary>
        /// Indicates whether this language allows nested languages. The
        /// default implementation returns true.
        /// </summary>
        abstract member allowsNesting: bool with get

    /// <summary>
    /// Lezer-style
    /// [<c>Input</c>](https://lezer.codemirror.net/docs/ref#common.Input)
    /// object for a [<c>Text</c>](https://codemirror.net/6/docs/ref/#state.Text) object.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("DocInput", "@codemirror/language")>]
    type DocInput =
        inherit Glutinum.LezerCommon.Input
        abstract member doc: Glutinum.CodemirrorState.Text with get
        /// <summary>
        /// The length of the document.
        /// </summary>
        abstract member length: float with get
        /// <summary>
        /// Get the chunk after the given position. The returned string
        /// should start at <c>from</c> and, if that isn't the end of the
        /// document, may be of any length greater than zero.
        /// </summary>
        abstract member chunk: pos: float -> string
        /// <summary>
        /// Indicates whether the chunks already end at line breaks, so that
        /// client code that wants to work by-line can avoid re-scanning
        /// them for line breaks. When this is true, the result of <c>chunk()</c>
        /// should either be a single line break, or the content between
        /// <c>from</c> and the next line break.
        /// </summary>
        abstract member lineChunks: bool with get
        /// <summary>
        /// Read the part of the document between the given positions.
        /// </summary>
        abstract member read: from: float * ``to``: float -> string

    /// <summary>
    /// A parse context provided to parsers working on the editor content.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("ParseContext", "@codemirror/language")>]
    type ParseContext =
        /// <summary>
        /// The current editor state.
        /// </summary>
        abstract member state: Glutinum.CodemirrorState.EditorState with get
        /// <summary>
        /// Tree fragments that can be reused by incremental re-parses.
        /// </summary>
        abstract member fragments: ReadonlyArray<Glutinum.LezerCommon.TreeFragment> with get, set
        /// <summary>
        /// The current editor viewport (or some overapproximation
        /// thereof). Intended to be used for opportunistically avoiding
        /// work (in which case
        /// [<c>skipUntilInView</c>](https://codemirror.net/6/docs/ref/#language.ParseContext.skipUntilInView)
        /// should be called to make sure the parser is restarted when the
        /// skipped region becomes visible).
        /// </summary>
        abstract member viewport: ParseContext.viewport with get, set
        /// <summary>
        /// Notify the parse scheduler that the given region was skipped
        /// because it wasn't in view, and the parse should be restarted
        /// when it comes into view.
        /// </summary>
        abstract member skipUntilInView: from: float * ``to``: float -> unit
        /// <summary>
        /// Returns a parser intended to be used as placeholder when
        /// asynchronously loading a nested parser. It'll skip its input and
        /// mark it as not-really-parsed, so that the next update will parse
        /// it again.
        ///
        /// When <c>until</c> is given, a reparse will be scheduled when that
        /// promise resolves.
        /// </summary>
        [<Emit("""import { ParseContext } from "@codemirror/language";
ParseContext.getSkippingParser($0)""")>]
        static member inline getSkippingParser (?until: JS.Promise<obj>): Glutinum.LezerCommon.Parser = nativeOnly
        /// <summary>
        /// Get the context for the current parse, or <c>null</c> if no editor
        /// parse is in progress.
        /// </summary>
        [<Emit("""import { ParseContext } from "@codemirror/language";
ParseContext.get()""")>]
        static member inline get () : CodemirrorLanguage.ParseContext option = nativeOnly

    /// <summary>
    /// This class bundles a [language](https://codemirror.net/6/docs/ref/#language.Language) with an
    /// optional set of supporting extensions. Language packages are
    /// encouraged to export a function that optionally takes a
    /// configuration object and returns a <c>LanguageSupport</c> instance, as
    /// the main way for client code to use the package.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("LanguageSupport", "@codemirror/language")>]
    type LanguageSupport =
        /// <summary>
        /// The language object.
        /// </summary>
        abstract member language: CodemirrorLanguage.Language with get
        /// <summary>
        /// An optional set of supporting extensions. When nesting a
        /// language in another language, the outer language is encouraged
        /// to include the supporting extensions for its inner languages
        /// in its own set of support extensions.
        /// </summary>
        abstract member support: Glutinum.CodemirrorState.Extension with get
        /// <summary>
        /// An extension including both the language and its support
        /// extensions. (Allowing the object to be used as an extension
        /// value itself.)
        /// </summary>
        abstract member extension: Glutinum.CodemirrorState.Extension with get, set

    /// <summary>
    /// Language descriptions are used to store metadata about languages
    /// and to dynamically load them. Their main role is finding the
    /// appropriate language for a filename or dynamically loading nested
    /// parsers.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("LanguageDescription", "@codemirror/language")>]
    type LanguageDescription =
        /// <summary>
        /// The name of this language.
        /// </summary>
        abstract member name: string with get
        /// <summary>
        /// Alternative names for the mode (lowercased, includes <c>this.name</c>).
        /// </summary>
        abstract member alias: ReadonlyArray<string> with get
        /// <summary>
        /// File extensions associated with this language.
        /// </summary>
        abstract member extensions: ReadonlyArray<string> with get
        /// <summary>
        /// Optional filename pattern that should be associated with this
        /// language.
        /// </summary>
        abstract member filename: RegExp option with get
        /// <summary>
        /// If the language has been loaded, this will hold its value.
        /// </summary>
        abstract member support: CodemirrorLanguage.LanguageSupport option with get, set
        /// <summary>
        /// Start loading the the language. Will return a promise that
        /// resolves to a [<c>LanguageSupport</c>](https://codemirror.net/6/docs/ref/#language.LanguageSupport)
        /// object when the language successfully loads.
        /// </summary>
        abstract member load: unit -> JS.Promise<CodemirrorLanguage.LanguageSupport>
        /// <summary>
        /// Create a language description.
        /// </summary>
        [<Emit("""import { LanguageDescription } from "@codemirror/language";
LanguageDescription.of($0)""")>]
        static member inline ``of`` (spec: LanguageDescription.of__.spec): CodemirrorLanguage.LanguageDescription = nativeOnly
        /// <summary>
        /// Look for a language in the given array of descriptions that
        /// matches the filename. Will first match
        /// [<c>filename</c>](https://codemirror.net/6/docs/ref/#language.LanguageDescription.filename) patterns,
        /// and then [extensions](https://codemirror.net/6/docs/ref/#language.LanguageDescription.extensions),
        /// and return the first language that matches.
        /// </summary>
        [<Emit("""import { LanguageDescription } from "@codemirror/language";
LanguageDescription.matchFilename($0, $1)""")>]
        static member inline matchFilename (descs: ResizeArray<CodemirrorLanguage.LanguageDescription>, filename: string): CodemirrorLanguage.LanguageDescription option = nativeOnly
        /// <summary>
        /// Look for a language whose name or alias matches the the given
        /// name (case-insensitively). If <c>fuzzy</c> is true, and no direct
        /// matchs is found, this'll also search for a language whose name
        /// or alias occurs in the string (for names shorter than three
        /// characters, only when surrounded by non-word characters).
        /// </summary>
        [<Emit("""import { LanguageDescription } from "@codemirror/language";
LanguageDescription.matchLanguageName($0, $1, $2)""")>]
        static member inline matchLanguageName (descs: ResizeArray<CodemirrorLanguage.LanguageDescription>, name: string, ?fuzzy: bool): CodemirrorLanguage.LanguageDescription option = nativeOnly

    /// <summary>
    /// Indentation contexts are used when calling [indentation
    /// services](https://codemirror.net/6/docs/ref/#language.indentService). They provide helper utilities
    /// useful in indentation logic, and can selectively override the
    /// indentation reported for some lines.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("IndentContext", "@codemirror/language")>]
    type IndentContext =
        /// <summary>
        /// The editor state.
        /// </summary>
        abstract member state: Glutinum.CodemirrorState.EditorState with get
        /// <summary>
        /// The indent unit (number of columns per indentation level).
        /// </summary>
        abstract member unit: float with get, set
        /// <summary>
        /// Get a description of the line at the given position, taking
        /// [simulated line
        /// breaks](https://codemirror.net/6/docs/ref/#language.IndentContext.constructor^options.simulateBreak)
        /// into account. If there is such a break at <c>pos</c>, the <c>bias</c>
        /// argument determines whether the part of the line line before or
        /// after the break is used.
        /// </summary>
        abstract member lineAt: pos: float * ?bias: IndentContext.lineAt.bias -> IndentContext.lineAt
        /// <summary>
        /// Get the text directly after <c>pos</c>, either the entire line
        /// or the next 100 characters, whichever is shorter.
        /// </summary>
        abstract member textAfterPos: pos: float * ?bias: IndentContext.textAfterPos.bias -> string
        /// <summary>
        /// Find the column for the given position.
        /// </summary>
        abstract member column: pos: float * ?bias: IndentContext.column.bias -> float
        /// <summary>
        /// Find the column position (taking tabs into account) of the given
        /// position in the given string.
        /// </summary>
        abstract member countColumn: line: string * ?pos: float -> float
        /// <summary>
        /// Find the indentation column of the line at the given point.
        /// </summary>
        abstract member lineIndent: pos: float * ?bias: IndentContext.lineIndent.bias -> float
        /// <summary>
        /// Returns the [simulated line
        /// break](https://codemirror.net/6/docs/ref/#language.IndentContext.constructor^options.simulateBreak)
        /// for this context, if any.
        /// </summary>
        abstract member simulatedBreak: float option with get

    /// <summary>
    /// Objects of this type provide context information and helper
    /// methods to indentation functions registered on syntax nodes.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("TreeIndentContext", "@codemirror/language")>]
    type TreeIndentContext =
        inherit CodemirrorLanguage.IndentContext
        /// <summary>
        /// The position at which indentation is being computed.
        /// </summary>
        abstract member pos: float with get
        /// <summary>
        /// The syntax tree node to which the indentation strategy
        /// applies.
        /// </summary>
        abstract member node: Glutinum.LezerCommon.SyntaxNode with get
        /// <summary>
        /// Get the text directly after <c>this.pos</c>, either the entire line
        /// or the next 100 characters, whichever is shorter.
        /// </summary>
        abstract member textAfter: string with get
        /// <summary>
        /// Get the indentation at the reference line for <c>this.node</c>, which
        /// is the line on which it starts, unless there is a node that is
        /// _not_ a parent of this node covering the start of that line. If
        /// so, the line at the start of that node is tried, again skipping
        /// on if it is covered by another such node.
        /// </summary>
        abstract member baseIndent: float with get
        /// <summary>
        /// Get the indentation for the reference line of the given node
        /// (see [<c>baseIndent</c>](https://codemirror.net/6/docs/ref/#language.TreeIndentContext.baseIndent)).
        /// </summary>
        abstract member baseIndentFor: node: Glutinum.LezerCommon.SyntaxNode -> float
        /// <summary>
        /// Continue looking for indentations in the node's parent nodes,
        /// and return the result of that.
        /// </summary>
        abstract member ``continue``: unit -> float option

    [<AllowNullLiteral>]
    [<Interface>]
    type DocRange =
        abstract member from: float with get, set
        abstract member ``to``: float with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (from: float, ``to``: float) : DocRange = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type FoldConfig =
        /// <summary>
        /// A function that creates the DOM element used to indicate the
        /// position of folded code. The <c>onclick</c> argument is the default
        /// click event handler, which toggles folding on the line that
        /// holds the element, and should probably be added as an event
        /// handler to the returned element. If
        /// [<c>preparePlaceholder</c>](https://codemirror.net/6/docs/ref/#language.FoldConfig.preparePlaceholder)
        /// is given, its result will be passed as 3rd argument. Otherwise,
        /// this will be null.
        ///
        /// When this option isn't given, the <c>placeholderText</c> option will
        /// be used to create the placeholder element.
        /// </summary>
        abstract member placeholderDOM: FoldConfig.placeholderDOM option with get, set
        /// <summary>
        /// Text to use as placeholder for folded text. Defaults to <c>"…"</c>.
        /// Will be styled with the <c>"cm-foldPlaceholder"</c> class.
        /// </summary>
        abstract member placeholderText: string option with get, set
        /// <summary>
        /// Given a range that is being folded, create a value that
        /// describes it, to be used by <c>placeholderDOM</c> to render a custom
        /// widget that, for example, indicates something about the folded
        /// range's size or type.
        /// </summary>
        abstract member preparePlaceholder: FoldConfig.preparePlaceholder option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?placeholderDOM: FoldConfig.placeholderDOM, ?placeholderText: string, ?preparePlaceholder: FoldConfig.preparePlaceholder) : FoldConfig = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type Handlers =
        [<EmitIndexer>]
        abstract member Item: event: string -> Handlers.Item with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type FoldGutterConfig =
        /// <summary>
        /// A function that creates the DOM element used to indicate a
        /// given line is folded or can be folded.
        /// When not given, the <c>openText</c>/<c>closeText</c> option will be used instead.
        /// </summary>
        abstract member markerDOM: (bool -> Glutinum.Web.HTMLElement) option with get, set
        /// <summary>
        /// Text used to indicate that a given line can be folded.
        /// Defaults to <c>"⌄"</c>.
        /// </summary>
        abstract member openText: string option with get, set
        /// <summary>
        /// Text used to indicate that a given line is folded.
        /// Defaults to <c>"›"</c>.
        /// </summary>
        abstract member closedText: string option with get, set
        /// <summary>
        /// Supply event handlers for DOM events on this gutter.
        /// </summary>
        abstract member domEventHandlers: CodemirrorLanguage.Handlers option with get, set
        /// <summary>
        /// When given, if this returns true for a given view update,
        /// recompute the fold markers.
        /// </summary>
        abstract member foldingChanged: (CodemirrorView.ViewUpdate -> bool) option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?markerDOM: (bool -> Glutinum.Web.HTMLElement), ?openText: string, ?closedText: string, ?domEventHandlers: CodemirrorLanguage.Handlers, ?foldingChanged: (CodemirrorView.ViewUpdate -> bool)) : FoldGutterConfig = nativeOnly

    /// <summary>
    /// A highlight style associates CSS styles with highlighting
    /// [tags](https://lezer.codemirror.net/docs/ref#highlight.Tag).
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("HighlightStyle", "@codemirror/language")>]
    type HighlightStyle =
        inherit Glutinum.LezerHighlight.Highlighter
        /// <summary>
        /// The tag styles used to create this highlight style.
        /// </summary>
        abstract member specs: ReadonlyArray<CodemirrorLanguage.TagStyle> with get
        /// <summary>
        /// A style module holding the CSS rules for this highlight style.
        /// When using
        /// [<c>highlightTree</c>](https://lezer.codemirror.net/docs/ref#highlight.highlightTree)
        /// outside of the editor, you may want to manually mount this
        /// module to show the highlighting.
        /// </summary>
        abstract member ``module``: StyleMod.StyleModule option with get
        /// <summary>
        /// Get the set of classes that should be applied to the given set
        /// of highlighting tags, or null if this highlighter doesn't assign
        /// a style to the tags.
        /// </summary>
        abstract member style: (ResizeArray<Glutinum.LezerHighlight.Tag> -> string option) with get
        /// <summary>
        /// When given, the highlighter will only be applied to trees on
        /// whose [top](#common.NodeType.isTop) node this predicate returns
        /// true.
        /// </summary>
        abstract member scope: (Glutinum.LezerCommon.NodeType -> bool) option with get
        /// <summary>
        /// Create a highlighter style that associates the given styles to
        /// the given tags. The specs must be objects that hold a style tag
        /// or array of tags in their <c>tag</c> property, and either a single
        /// <c>class</c> property providing a static CSS class (for highlighter
        /// that rely on external styling), or a
        /// [<c>style-mod</c>](https://code.haverbeke.berlin/marijn/style-mod#documentation)-style
        /// set of CSS properties (which define the styling for those tags).
        ///
        /// The CSS rules created for a highlighter will be emitted in the
        /// order of the spec's properties. That means that for elements that
        /// have multiple tags associated with them, styles defined further
        /// down in the list will have a higher CSS precedence than styles
        /// defined earlier.
        /// </summary>
        [<Emit("""import { HighlightStyle } from "@codemirror/language";
HighlightStyle.define($0, $1)""")>]
        static member inline define (specs: ResizeArray<CodemirrorLanguage.TagStyle>, ?options: HighlightStyle.define__.options): CodemirrorLanguage.HighlightStyle = nativeOnly

    /// <summary>
    /// The type of object used in
    /// [<c>HighlightStyle.define</c>](https://codemirror.net/6/docs/ref/#language.HighlightStyle^define).
    /// Assigns a style to one or more highlighting
    /// [tags](https://lezer.codemirror.net/docs/ref#highlight.Tag), which can either be a fixed class name
    /// (which must be defined elsewhere), or a set of CSS properties, for
    /// which the library will define an anonymous class.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type TagStyle =
        /// <summary>
        /// The tag or tags to target.
        /// </summary>
        abstract member tag: U2<Glutinum.LezerHighlight.Tag, ResizeArray<Glutinum.LezerHighlight.Tag>> with get, set
        /// <summary>
        /// If given, this maps the tags to a fixed class name.
        /// </summary>
        abstract member ``class``: string option with get, set
        [<EmitIndexer>]
        abstract member Item: styleProperty: string -> obj with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (tag: Glutinum.LezerHighlight.Tag, ?``class``: string) : TagStyle = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (tag: ResizeArray<Glutinum.LezerHighlight.Tag>, ?``class``: string) : TagStyle = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type Config =
        /// <summary>
        /// Whether the bracket matching should look at the character after
        /// the cursor when matching (if the one before isn't a bracket).
        /// Defaults to true.
        /// </summary>
        abstract member afterCursor: bool option with get, set
        /// <summary>
        /// The bracket characters to match, as a string of pairs. Defaults
        /// to <c>"()[]{}"</c>. Note that these are only used as fallback when
        /// there is no [matching
        /// information](https://lezer.codemirror.net/docs/ref/#common.NodeProp^closedBy)
        /// in the syntax tree.
        /// </summary>
        abstract member brackets: string option with get, set
        /// <summary>
        /// The maximum distance to scan for matching brackets. This is only
        /// relevant for brackets not encoded in the syntax tree. Defaults
        /// to 10 000.
        /// </summary>
        abstract member maxScanDistance: float option with get, set
        /// <summary>
        /// Can be used to configure the way in which brackets are
        /// decorated. The default behavior is to add the
        /// <c>cm-matchingBracket</c> class for matching pairs, and
        /// <c>cm-nonmatchingBracket</c> for mismatched pairs or single brackets.
        /// </summary>
        abstract member renderMatch: Config.renderMatch option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?afterCursor: bool, ?brackets: string, ?maxScanDistance: float, ?renderMatch: Config.renderMatch) : Config = nativeOnly

    /// <summary>
    /// The result returned from <c>matchBrackets</c>.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type MatchResult =
        /// <summary>
        /// The extent of the bracket token found.
        /// </summary>
        abstract member start: MatchResult.start with get, set
        /// <summary>
        /// The extent of the matched token, if any was found.
        /// </summary>
        abstract member ``end``: MatchResult.``end`` option with get, set
        /// <summary>
        /// Whether the tokens match. This can be false even when <c>end</c> has
        /// a value, if that token doesn't match the opening token.
        /// </summary>
        abstract member matched: bool with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (start: MatchResult.start, matched: bool, ?``end``: MatchResult.``end``) : MatchResult = nativeOnly

    /// <summary>
    /// An extended form of [<c>StreamParser</c>](https://codemirror.net/6/docs/ref/#streamparser.StreamParser)
    /// used to specify a [<c>StreamLanguage</c>](https://codemirror.net/6/docs/ref/#language.StreamLanguage).
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type StreamParser<'State> =
        inherit CodemirrorStreamparser.StreamParser<'State>
        /// <summary>
        /// Extra tokens to use in this parser. When the tokenizer returns a
        /// token name that exists as a property in this object, the
        /// corresponding tags will be assigned to the token.
        /// </summary>
        abstract member tokenTable: StreamParser.tokenTable option with get, set

    /// <summary>
    /// A [language](https://codemirror.net/6/docs/ref/#language.Language) class based on a CodeMirror
    /// 5-style [streaming parser](https://codemirror.net/6/docs/ref/#language.StreamParser).
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("StreamLanguage", "@codemirror/language")>]
    type StreamLanguage<'State> =
        inherit CodemirrorLanguage.Language
        /// <summary>
        /// Define a stream language.
        /// </summary>
        [<Emit("""import { StreamLanguage } from "@codemirror/language";
StreamLanguage.define($0)""")>]
        static member inline define (spec: CodemirrorLanguage.StreamParser<'State>): CodemirrorLanguage.StreamLanguage<'State> = nativeOnly
        /// <summary>
        /// Indicates whether this language allows nested languages. The
        /// default implementation returns true.
        /// </summary>
        abstract member allowsNesting: bool with get

    module Sublanguage =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type ``type`` =
            | replace
            | extend

        type test =
            delegate of node: Glutinum.LezerCommon.SyntaxNode * state: Glutinum.CodemirrorState.EditorState -> bool

        [<AllowNullLiteral>]
        [<Interface>]
        type facet =
            [<EmitIndexer>]
            abstract member Item: name: string -> obj with get, set

    module Language =

        [<AllowNullLiteral>]
        [<Interface>]
        type data =
            [<EmitIndexer>]
            abstract member Item: name: string -> obj with get, set

        module isActiveAt =

            [<RequireQualifiedAccess>]
            type side =
                | _MINUS_1 = -1
                | ``0`` = 0
                | ``1`` = 1

        module findRegions =

            [<AllowNullLiteral>]
            [<Interface>]
            type Item =
                abstract member from: float with get, set
                abstract member ``to``: float with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (from: float, ``to``: float) : Item = nativeOnly

    module LRLanguage =

        module define__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type spec =
                /// <summary>
                /// The [name](https://codemirror.net/6/docs/ref/#Language.name) of the language.
                /// </summary>
                abstract member name: string option with get, set
                /// <summary>
                /// The parser to use. Should already have added editor-relevant
                /// node props (and optionally things like dialect and top rule)
                /// configured.
                /// </summary>
                abstract member parser: LezerLr.LRParser with get, set
                /// <summary>
                /// [Language data](https://codemirror.net/6/docs/ref/#state.EditorState.languageDataAt)
                /// to register for this language.
                /// </summary>
                abstract member languageData: LRLanguage.define__.spec.languageData option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (parser: LezerLr.LRParser, ?name: string, ?languageData: LRLanguage.define__.spec.languageData) : spec = nativeOnly

            module spec =

                [<AllowNullLiteral>]
                [<Interface>]
                type languageData =
                    [<EmitIndexer>]
                    abstract member Item: name: string -> obj with get, set

    module ParseContext =

        [<AllowNullLiteral>]
        [<Interface>]
        type viewport =
            abstract member from: float with get, set
            abstract member ``to``: float with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (from: float, ``to``: float) : viewport = nativeOnly

    module LanguageDescription =

        module of__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type spec =
                /// <summary>
                /// The language's name.
                /// </summary>
                abstract member name: string with get, set
                /// <summary>
                /// An optional array of alternative names.
                /// </summary>
                abstract member alias: ReadonlyArray<string> option with get, set
                /// <summary>
                /// An optional array of filename extensions associated with this
                /// language.
                /// </summary>
                abstract member extensions: ReadonlyArray<string> option with get, set
                /// <summary>
                /// An optional filename pattern associated with this language.
                /// </summary>
                abstract member filename: RegExp option with get, set
                /// <summary>
                /// A function that will asynchronously load the language.
                /// </summary>
                abstract member load: (unit -> JS.Promise<CodemirrorLanguage.LanguageSupport>) option with get, set
                /// <summary>
                /// Alternatively to <c>load</c>, you can provide an already loaded
                /// support object. Either this or <c>load</c> should be provided.
                /// </summary>
                abstract member support: CodemirrorLanguage.LanguageSupport option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (name: string, ?alias: ResizeArray<string>, ?extensions: ResizeArray<string>, ?filename: RegExp, ?load: (unit -> JS.Promise<CodemirrorLanguage.LanguageSupport>), ?support: CodemirrorLanguage.LanguageSupport) : spec = nativeOnly

    module IndentContext =

        [<AllowNullLiteral>]
        [<Interface>]
        type lineAt =
            abstract member text: string with get, set
            abstract member from: float with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (text: string, from: float) : lineAt = nativeOnly

        module lineAt =

            [<RequireQualifiedAccess>]
            type bias =
                | _MINUS_1 = -1
                | ``1`` = 1

        module textAfterPos =

            [<RequireQualifiedAccess>]
            type bias =
                | _MINUS_1 = -1
                | ``1`` = 1

        module column =

            [<RequireQualifiedAccess>]
            type bias =
                | _MINUS_1 = -1
                | ``1`` = 1

        module lineIndent =

            [<RequireQualifiedAccess>]
            type bias =
                | _MINUS_1 = -1
                | ``1`` = 1

    module FoldConfig =

        type placeholderDOM =
            delegate of view: CodemirrorView.EditorView * onclick: (Glutinum.Web.Event -> unit) * prepared: obj -> Glutinum.Web.HTMLElement

        type preparePlaceholder =
            delegate of state: Glutinum.CodemirrorState.EditorState * range: FoldConfig.preparePlaceholder.range -> unit

        module preparePlaceholder =

            [<AllowNullLiteral>]
            [<Interface>]
            type range =
                abstract member from: float with get, set
                abstract member ``to``: float with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (from: float, ``to``: float) : range = nativeOnly

    module Handlers =

        type Item =
            delegate of view: CodemirrorView.EditorView * line: CodemirrorView.BlockInfo * event: Glutinum.Web.Event -> bool

    module HighlightStyle =

        module define__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                /// <summary>
                /// By default, highlighters apply to the entire document. You can
                /// scope them to a single language by providing the language
                /// object or a language's top node type here.
                /// </summary>
                abstract member scope: U2<CodemirrorLanguage.Language, Glutinum.LezerCommon.NodeType> option with get, set
                /// <summary>
                /// Add a style to _all_ content. Probably only useful in
                /// combination with <c>scope</c>.
                /// </summary>
                abstract member all: U2<string, StyleMod.StyleSpec> option with get, set
                /// <summary>
                /// Specify that this highlight style should only be active then
                /// the theme is dark or light. By default, it is active
                /// regardless of theme.
                /// </summary>
                abstract member themeType: HighlightStyle.define__.options.themeType option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?themeType: HighlightStyle.define__.options.themeType) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (all: string, ?themeType: HighlightStyle.define__.options.themeType) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (all: StyleMod.StyleSpec, ?themeType: HighlightStyle.define__.options.themeType) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (scope: CodemirrorLanguage.Language, ?themeType: HighlightStyle.define__.options.themeType) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (scope: CodemirrorLanguage.Language, all: string, ?themeType: HighlightStyle.define__.options.themeType) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (scope: CodemirrorLanguage.Language, all: StyleMod.StyleSpec, ?themeType: HighlightStyle.define__.options.themeType) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (scope: Glutinum.LezerCommon.NodeType, ?themeType: HighlightStyle.define__.options.themeType) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (scope: Glutinum.LezerCommon.NodeType, all: string, ?themeType: HighlightStyle.define__.options.themeType) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (scope: Glutinum.LezerCommon.NodeType, all: StyleMod.StyleSpec, ?themeType: HighlightStyle.define__.options.themeType) : options = nativeOnly

            module options =

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type themeType =
                    | dark
                    | light

    module Config =

        type renderMatch =
            delegate of ``match``: CodemirrorLanguage.MatchResult * state: Glutinum.CodemirrorState.EditorState -> ResizeArray<Glutinum.CodemirrorState.Range<CodemirrorView.Decoration>>

    module MatchResult =

        [<AllowNullLiteral>]
        [<Interface>]
        type start =
            abstract member from: float with get, set
            abstract member ``to``: float with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (from: float, ``to``: float) : start = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type ``end`` =
            abstract member from: float with get, set
            abstract member ``to``: float with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (from: float, ``to``: float) : ``end`` = nativeOnly

    module StreamParser =

        [<AllowNullLiteral>]
        [<Interface>]
        type tokenTable =
            [<EmitIndexer>]
            abstract member Item: name: string -> U2<Glutinum.LezerHighlight.Tag, ResizeArray<Glutinum.LezerHighlight.Tag>> with get, set

    module Exports =

        [<AllowNullLiteral>]
        [<Interface>]
        type defineLanguageFacet__ =
            [<EmitIndexer>]
            abstract member Item: name: string -> obj with get, set

        [<AllowNullLiteral>]
        [<Interface>]
        type foldInside__ =
            abstract member from: float with get, set
            abstract member ``to``: float with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (from: float, ``to``: float) : foldInside__ = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type foldable__ =
            abstract member from: float with get, set
            abstract member ``to``: float with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (from: float, ``to``: float) : foldable__ = nativeOnly

        module languageDataProp__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type Type =
                [<EmitIndexer>]
                abstract member Item: name: string -> obj with get, set

            module Type =

                [<AllowNullLiteral>]
                [<Interface>]
                type Item =
                    [<EmitIndexer>]
                    abstract member Item: name: string -> obj with get, set

        module defineLanguageFacet__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type baseData =
                [<EmitIndexer>]
                abstract member Item: name: string -> obj with get, set

            [<AllowNullLiteral>]
            [<Interface>]
            type Item =
                [<EmitIndexer>]
                abstract member Item: name: string -> obj with get, set

        module indentService__ =

            type Type =
                delegate of context: CodemirrorLanguage.IndentContext * pos: float -> float option

            module Type =

                type Item =
                    delegate of context: CodemirrorLanguage.IndentContext * pos: float -> float option

        module delimitedIndent__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type arg0 =
                abstract member closing: string with get, set
                abstract member align: bool option with get, set
                abstract member units: float option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (closing: string, ?align: bool, ?units: float) : arg0 = nativeOnly

        module continuedIndent__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type arg0 =
                abstract member except: RegExp option with get, set
                abstract member units: float option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?except: RegExp, ?units: float) : arg0 = nativeOnly

        module foldService__ =

            type Type =
                delegate of state: Glutinum.CodemirrorState.EditorState * lineStart: float * lineEnd: float -> Exports.foldService__.Type.ReturnType option

            module Type =

                [<AllowNullLiteral>]
                [<Interface>]
                type ReturnType =
                    abstract member from: float with get, set
                    abstract member ``to``: float with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (from: float, ``to``: float) : ReturnType = nativeOnly

                type Item =
                    delegate of state: Glutinum.CodemirrorState.EditorState * lineStart: float * lineEnd: float -> Exports.foldService__.Type.Item.ReturnType option

                module Item =

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type ReturnType =
                        abstract member from: float with get, set
                        abstract member ``to``: float with get, set
                        [<ParamObject; Emit("$0")>]
                        static member Create (from: float, ``to``: float) : ReturnType = nativeOnly

        module foldNodeProp__ =

            type Type =
                delegate of node: Glutinum.LezerCommon.SyntaxNode * state: Glutinum.CodemirrorState.EditorState -> Exports.foldNodeProp__.Type.ReturnType option

            module Type =

                [<AllowNullLiteral>]
                [<Interface>]
                type ReturnType =
                    abstract member from: float with get, set
                    abstract member ``to``: float with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (from: float, ``to``: float) : ReturnType = nativeOnly

        module syntaxHighlighting__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                /// <summary>
                /// When enabled, this marks the highlighter as a fallback, which
                /// only takes effect if no other highlighters are registered.
                /// </summary>
                abstract member fallback: bool with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (fallback: bool) : options = nativeOnly

        module matchBrackets__ =

            [<RequireQualifiedAccess>]
            type dir =
                | _MINUS_1 = -1
                | ``1`` = 1

        module bidiIsolates__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                /// <summary>
                /// By default, isolating elements are only added when the editor
                /// direction isn't uniformly left-to-right, or if it is, on lines
                /// that contain right-to-left character. When true, disable this
                /// optimization and add them everywhere.
                /// </summary>
                abstract member alwaysIsolate: bool option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?alwaysIsolate: bool) : options = nativeOnly

        module Language =

            [<AllowNullLiteral>]
            [<Interface>]
            type data =
                [<EmitIndexer>]
                abstract member Item: name: string -> obj with get, set

        module IndentContext =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                /// <summary>
                /// Override line indentations provided to the indentation
                /// helper function, which is useful when implementing region
                /// indentation, where indentation for later lines needs to refer
                /// to previous lines, which may have been reindented compared to
                /// the original start state. If given, this function should
                /// return -1 for lines (given by start position) that didn't
                /// change, and an updated indentation otherwise.
                /// </summary>
                abstract member overrideIndentation: (float -> float) option with get, set
                /// <summary>
                /// Make it look, to the indent logic, like a line break was
                /// added at the given position (which is mostly just useful for
                /// implementing something like
                /// [<c>insertNewlineAndIndent</c>](https://codemirror.net/6/docs/ref/#commands.insertNewlineAndIndent)).
                /// </summary>
                abstract member simulateBreak: float option with get, set
                /// <summary>
                /// When <c>simulateBreak</c> is given, this can be used to make the
                /// simulated break behave like a double line break.
                /// </summary>
                abstract member simulateDoubleBreak: bool option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?overrideIndentation: (float -> float), ?simulateBreak: float, ?simulateDoubleBreak: bool) : options = nativeOnly

module CodemirrorStreamparser =

    [<AbstractClass>]
    [<Erase>]
    type Exports =
        /// <summary>
        /// Create a stream.
        /// </summary>
        [<Import("StringStream", "@codemirror/streamparser"); EmitConstructor>]
        static member StringStream (string: string, tabSize: float, indentUnit: float, ?overrideIndent: float) : StringStream = nativeOnly

    /// <summary>
    /// Encapsulates a single line of input. Given to stream syntax code,
    /// which uses it to tokenize the content.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("StringStream", "@codemirror/streamparser")>]
    type StringStream =
        /// <summary>
        /// The line.
        /// </summary>
        abstract member string: string with get, set
        /// <summary>
        /// The current indent unit size.
        /// </summary>
        abstract member indentUnit: float with get, set
        /// <summary>
        /// The current position on the line.
        /// </summary>
        abstract member pos: float with get, set
        /// <summary>
        /// The start position of the current token.
        /// </summary>
        abstract member start: float with get, set
        /// <summary>
        /// True if we are at the end of the line.
        /// </summary>
        abstract member eol: unit -> bool
        /// <summary>
        /// True if we are at the start of the line.
        /// </summary>
        abstract member sol: unit -> bool
        /// <summary>
        /// Get the next code unit after the current position, or undefined
        /// if we're at the end of the line.
        /// </summary>
        abstract member peek: unit -> string option
        /// <summary>
        /// Read the next code unit and advance <c>this.pos</c>.
        /// </summary>
        abstract member next: unit -> U2<string, unit>
        /// <summary>
        /// Match the next character against the given string, regular
        /// expression, or predicate. Consume and return it if it matches.
        /// </summary>
        abstract member eat: ``match``: string -> U2<string, unit>
        /// <summary>
        /// Match the next character against the given string, regular
        /// expression, or predicate. Consume and return it if it matches.
        /// </summary>
        abstract member eat: ``match``: RegExp -> U2<string, unit>
        /// <summary>
        /// Match the next character against the given string, regular
        /// expression, or predicate. Consume and return it if it matches.
        /// </summary>
        abstract member eat: ``match``: (string -> bool) -> U2<string, unit>
        /// <summary>
        /// Continue matching characters that match the given string,
        /// regular expression, or predicate function. Return true if any
        /// characters were consumed.
        /// </summary>
        abstract member eatWhile: ``match``: string -> bool
        /// <summary>
        /// Continue matching characters that match the given string,
        /// regular expression, or predicate function. Return true if any
        /// characters were consumed.
        /// </summary>
        abstract member eatWhile: ``match``: RegExp -> bool
        /// <summary>
        /// Continue matching characters that match the given string,
        /// regular expression, or predicate function. Return true if any
        /// characters were consumed.
        /// </summary>
        abstract member eatWhile: ``match``: (string -> bool) -> bool
        /// <summary>
        /// Consume whitespace ahead of <c>this.pos</c>. Return true if any was
        /// found.
        /// </summary>
        abstract member eatSpace: unit -> bool
        /// <summary>
        /// Move to the end of the line.
        /// </summary>
        abstract member skipToEnd: unit -> unit
        /// <summary>
        /// Move to directly before the given character, if found on the
        /// current line.
        /// </summary>
        abstract member skipTo: ch: string -> U2<bool, unit>
        /// <summary>
        /// Move back <c>n</c> characters.
        /// </summary>
        abstract member backUp: n: float -> unit
        /// <summary>
        /// Get the column position at <c>this.pos</c>.
        /// </summary>
        abstract member column: unit -> float
        /// <summary>
        /// Get the indentation column of the current line.
        /// </summary>
        abstract member indentation: unit -> float
        /// <summary>
        /// Match the input against the given string or regular expression
        /// (which should start with a <c>^</c>). Return true or the regexp match
        /// if it matches.
        ///
        /// Unless <c>consume</c> is set to <c>false</c>, this will move <c>this.pos</c>
        /// past the matched text.
        ///
        /// When matching a string <c>caseInsensitive</c> can be set to true to
        /// make the match case-insensitive.
        /// </summary>
        abstract member ``match``: pattern: string * ?consume: bool * ?caseInsensitive: bool -> U2<bool, obj> option
        /// <summary>
        /// Match the input against the given string or regular expression
        /// (which should start with a <c>^</c>). Return true or the regexp match
        /// if it matches.
        ///
        /// Unless <c>consume</c> is set to <c>false</c>, this will move <c>this.pos</c>
        /// past the matched text.
        ///
        /// When matching a string <c>caseInsensitive</c> can be set to true to
        /// make the match case-insensitive.
        /// </summary>
        abstract member ``match``: pattern: RegExp * ?consume: bool * ?caseInsensitive: bool -> U2<bool, obj> option
        /// <summary>
        /// Get the current token.
        /// </summary>
        abstract member current: unit -> string

    /// <summary>
    /// A stream parser parses or tokenizes content from start to end,
    /// emitting tokens as it goes over it. It keeps a mutable (but
    /// copyable) object with state, in which it can store information
    /// about the current context.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type StreamParser<'State> =
        /// <summary>
        /// A name for this language.
        /// </summary>
        abstract member name: string option with get, set
        /// <summary>
        /// Produce a start state for the parser.
        /// </summary>
        abstract member startState: (float -> 'State) option with get, set
        /// <summary>
        /// Read one token, advancing the stream past it, and returning a
        /// string indicating the token's style tag—either the name of one
        /// of the tags in
        /// [<c>tags</c>](https://lezer.codemirror.net/docs/ref#highlight.tags)
        /// or [<c>tokenTable</c>](https://codemirror.net/6/docs/ref/#language.StreamParser.tokenTable), or such a
        /// name suffixed by one or more tag
        /// [modifier](https://lezer.codemirror.net/docs/ref#highlight.Tag^defineModifier)
        /// names, separated by periods. For example <c>"keyword"</c> or
        /// "<c>variableName.constant"</c>, or a space-separated set of such
        /// token types.
        ///
        /// It is okay to return a zero-length token, but only if that
        /// updates the state so that the next call will return a non-empty
        /// token again.
        /// </summary>
        abstract member token: stream: CodemirrorStreamparser.StringStream * state: 'State -> string option
        /// <summary>
        /// This notifies the parser of a blank line in the input. It can
        /// update its state here if it needs to.
        /// </summary>
        abstract member blankLine: StreamParser.blankLine option with get, set
        /// <summary>
        /// Copy a given state. By default, a shallow object copy is done
        /// which also copies arrays held at the top level of the object.
        /// </summary>
        abstract member copyState: ('State -> 'State) option with get, set
        /// <summary>
        /// Compute automatic indentation for the line that starts with the
        /// given state and text.
        /// </summary>
        abstract member indent: StreamParser.indent option with get, set
        /// <summary>
        /// Default [language data](https://codemirror.net/6/docs/ref/#state.EditorState.languageDataAt) to
        /// attach to this language.
        /// </summary>
        abstract member languageData: StreamParser.languageData option with get, set
        /// <summary>
        /// By default, adjacent tokens of the same type are merged in the
        /// output tree. Set this to false to disable that.
        /// </summary>
        abstract member mergeTokens: bool option with get, set

    module StreamParser =

        type blankLine =
            delegate of state: obj * indentUnit: float -> unit

        type indent =
            delegate of state: obj * textAfter: string * context: StreamParser.indent.context -> float option

        [<AllowNullLiteral>]
        [<Interface>]
        type languageData =
            [<EmitIndexer>]
            abstract member Item: name: string -> obj with get, set

        module indent =

            [<AllowNullLiteral>]
            [<Interface>]
            type context =
                abstract member unit: float with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (unit: float) : context = nativeOnly

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
        static member logException (state: Glutinum.CodemirrorState.EditorState, ``exception``: obj, ?context: string) : unit = nativeOnly
        /// <summary>
        /// Facet used for registering keymaps.
        ///
        /// You can add multiple keymaps to an editor. Their priorities
        /// determine their precedence (the ones specified early or with high
        /// priority get checked first). When a handler has returned <c>true</c>
        /// for a given key, no further handlers are called.
        /// </summary>
        [<Import("keymap", "@codemirror/view")>]
        static member inline keymap: Glutinum.CodemirrorState.Facet<ReadonlyArray<CodemirrorView.KeyBinding>, ReadonlyArray<ReadonlyArray<CodemirrorView.KeyBinding>>> = nativeOnly
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
        static member drawSelection (?config: CodemirrorView.SelectionConfig) : Glutinum.CodemirrorState.Extension = nativeOnly
        /// <summary>
        /// Retrieve the [<c>drawSelection</c>](https://codemirror.net/6/docs/ref/#view.drawSelection) configuration
        /// for this state. (Note that this will return a set of defaults even
        /// if <c>drawSelection</c> isn't enabled.)
        /// </summary>
        [<Import("getDrawSelectionConfig", "@codemirror/view")>]
        static member getDrawSelectionConfig (state: Glutinum.CodemirrorState.EditorState) : CodemirrorView.SelectionConfig = nativeOnly
        /// <summary>
        /// Draws a cursor at the current drop position when something is
        /// dragged over the editor.
        /// </summary>
        [<Import("dropCursor", "@codemirror/view")>]
        static member dropCursor () : Glutinum.CodemirrorState.Extension = nativeOnly
        /// <summary>
        /// Returns an extension that installs highlighting of special
        /// characters.
        /// </summary>
        [<Import("highlightSpecialChars", "@codemirror/view")>]
        static member highlightSpecialChars (?config: CodemirrorView.SpecialCharConfig) : Glutinum.CodemirrorState.Extension = nativeOnly
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
        static member scrollPastEnd () : Glutinum.CodemirrorState.Extension = nativeOnly
        /// <summary>
        /// Mark lines that have a cursor on them with the <c>"cm-activeLine"</c>
        /// DOM class.
        /// </summary>
        [<Import("highlightActiveLine", "@codemirror/view")>]
        static member highlightActiveLine () : Glutinum.CodemirrorState.Extension = nativeOnly
        /// <summary>
        /// Extension that enables a placeholder—a piece of example content
        /// to show when the editor is empty.
        /// </summary>
        [<Import("placeholder", "@codemirror/view")>]
        static member placeholder (content: string) : Glutinum.CodemirrorState.Extension = nativeOnly
        /// <summary>
        /// Extension that enables a placeholder—a piece of example content
        /// to show when the editor is empty.
        /// </summary>
        [<Import("placeholder", "@codemirror/view")>]
        static member placeholder (content: Glutinum.Web.HTMLElement) : Glutinum.CodemirrorState.Extension = nativeOnly
        /// <summary>
        /// Extension that enables a placeholder—a piece of example content
        /// to show when the editor is empty.
        /// </summary>
        [<Import("placeholder", "@codemirror/view")>]
        static member placeholder (content: (CodemirrorView.EditorView -> Glutinum.Web.HTMLElement)) : Glutinum.CodemirrorState.Extension = nativeOnly
        /// <summary>
        /// Define a layer.
        /// </summary>
        [<Import("layer", "@codemirror/view")>]
        static member layer (config: CodemirrorView.LayerConfig) : Glutinum.CodemirrorState.Extension = nativeOnly
        /// <summary>
        /// Create an extension that enables rectangular selections. By
        /// default, it will react to left mouse drag with the Alt key held
        /// down. When such a selection occurs, the text within the rectangle
        /// that was dragged over will be selected, as one selection
        /// [range](https://codemirror.net/6/docs/ref/#state.SelectionRange) per line.
        /// </summary>
        [<Import("rectangularSelection", "@codemirror/view")>]
        static member rectangularSelection (?options: Exports.rectangularSelection__.options) : Glutinum.CodemirrorState.Extension = nativeOnly
        /// <summary>
        /// Returns an extension that turns the pointer cursor into a
        /// crosshair when a given modifier key, defaulting to Alt, is held
        /// down. Can serve as a visual hint that rectangular selection is
        /// going to happen when paired with
        /// [<c>rectangularSelection</c>](https://codemirror.net/6/docs/ref/#view.rectangularSelection).
        /// </summary>
        [<Import("crosshairCursor", "@codemirror/view")>]
        static member crosshairCursor (?options: Exports.crosshairCursor__.options) : Glutinum.CodemirrorState.Extension = nativeOnly
        /// <summary>
        /// Creates an extension that configures tooltip behavior.
        /// </summary>
        [<Import("tooltips", "@codemirror/view")>]
        static member tooltips (?config: Exports.tooltips__.config) : Glutinum.CodemirrorState.Extension = nativeOnly
        /// <summary>
        /// Facet to which an extension can add a value to show a tooltip.
        /// </summary>
        [<Import("showTooltip", "@codemirror/view")>]
        static member inline showTooltip: Glutinum.CodemirrorState.Facet<CodemirrorView.Tooltip option, ReadonlyArray<CodemirrorView.Tooltip option>> = nativeOnly
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
        static member hasHoverTooltips (state: Glutinum.CodemirrorState.EditorState) : bool = nativeOnly
        /// <summary>
        /// Transaction effect that closes all hover tooltips.
        /// </summary>
        [<Import("closeHoverTooltips", "@codemirror/view")>]
        static member inline closeHoverTooltips: Glutinum.CodemirrorState.StateEffect<obj> = nativeOnly
        /// <summary>
        /// Transaction effect that closes a specific hover tooltip.
        /// </summary>
        [<Import("closeHoverTooltip", "@codemirror/view")>]
        static member closeHoverTooltip (tooltip: obj) : Glutinum.CodemirrorState.StateEffect<obj> = nativeOnly
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
        static member panels (?config: CodemirrorView.PanelConfig) : Glutinum.CodemirrorState.Extension = nativeOnly
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
        static member inline showPanel: Glutinum.CodemirrorState.Facet<CodemirrorView.PanelConstructor option, ReadonlyArray<CodemirrorView.PanelConstructor option>> = nativeOnly
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
        static member inline gutterLineClass: Glutinum.CodemirrorState.Facet<Glutinum.CodemirrorState.RangeSet<CodemirrorView.GutterMarker>, ReadonlyArray<Glutinum.CodemirrorState.RangeSet<CodemirrorView.GutterMarker>>> = nativeOnly
        /// <summary>
        /// Facet used to add a class to all gutter elements next to a widget.
        /// Should not provide widgets with a <c>toDOM</c> method.
        /// </summary>
        [<Import("gutterWidgetClass", "@codemirror/view")>]
        static member inline gutterWidgetClass: Glutinum.CodemirrorState.Facet<Exports.gutterWidgetClass__.Type, ReadonlyArray<Exports.gutterWidgetClass__.Type.Item>> = nativeOnly
        /// <summary>
        /// Define an editor gutter. The order in which the gutters appear is
        /// determined by their extension priority.
        /// </summary>
        [<Import("gutter", "@codemirror/view")>]
        static member gutter (config: CodemirrorView.GutterConfig) : Glutinum.CodemirrorState.Extension = nativeOnly
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
        static member gutters (?config: Exports.gutters__.config) : Glutinum.CodemirrorState.Extension = nativeOnly
        /// <summary>
        /// Facet used to provide markers to the line number gutter.
        /// </summary>
        [<Import("lineNumberMarkers", "@codemirror/view")>]
        static member inline lineNumberMarkers: Glutinum.CodemirrorState.Facet<Glutinum.CodemirrorState.RangeSet<CodemirrorView.GutterMarker>, ReadonlyArray<Glutinum.CodemirrorState.RangeSet<CodemirrorView.GutterMarker>>> = nativeOnly
        /// <summary>
        /// Facet used to create markers in the line number gutter next to widgets.
        /// </summary>
        [<Import("lineNumberWidgetMarker", "@codemirror/view")>]
        static member inline lineNumberWidgetMarker: Glutinum.CodemirrorState.Facet<Exports.lineNumberWidgetMarker__.Type, ReadonlyArray<Exports.lineNumberWidgetMarker__.Type.Item>> = nativeOnly
        /// <summary>
        /// Create a line number gutter extension.
        /// </summary>
        [<Import("lineNumbers", "@codemirror/view")>]
        static member lineNumbers (?config: CodemirrorView.LineNumberConfig) : Glutinum.CodemirrorState.Extension = nativeOnly
        /// <summary>
        /// Returns an extension that adds a <c>cm-activeLineGutter</c> class to
        /// all gutter elements on the [active
        /// line](https://codemirror.net/6/docs/ref/#view.highlightActiveLine).
        /// </summary>
        [<Import("highlightActiveLineGutter", "@codemirror/view")>]
        static member highlightActiveLineGutter () : Glutinum.CodemirrorState.Extension = nativeOnly
        /// <summary>
        /// Returns an extension that highlights whitespace, adding a
        /// <c>cm-highlightSpace</c> class to stretches of spaces, and a
        /// <c>cm-highlightTab</c> class to individual tab characters. By default,
        /// the former are shown as faint dots, and the latter as arrows.
        /// </summary>
        [<Import("highlightWhitespace", "@codemirror/view")>]
        static member highlightWhitespace () : Glutinum.CodemirrorState.Extension = nativeOnly
        /// <summary>
        /// Returns an extension that adds a <c>cm-trailingSpace</c> class to all
        /// trailing whitespace.
        /// </summary>
        [<Import("highlightTrailingWhitespace", "@codemirror/view")>]
        static member highlightTrailingWhitespace () : Glutinum.CodemirrorState.Extension = nativeOnly
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
    [<Import("BidiSpan", "@codemirror/view")>]
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
        [<ParamObject; Emit("$0")>]
        static member Create (left: float, right: float, top: float, bottom: float) : Rect = nativeOnly

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
        [<ParamObject; Emit("$0")>]
        static member Create (?inclusive: bool, ?inclusiveStart: bool, ?inclusiveEnd: bool, ?attributes: MarkDecorationSpec.attributes, ?``class``: string, ?tagName: string, ?bidiIsolate: CodemirrorView.Direction) : MarkDecorationSpec = nativeOnly

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
        [<ParamObject; Emit("$0")>]
        static member Create (widget: CodemirrorView.WidgetType, ?side: float, ?inlineOrder: bool, ?block: bool) : WidgetDecorationSpec = nativeOnly

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
        [<ParamObject; Emit("$0")>]
        static member Create (?widget: CodemirrorView.WidgetType, ?inclusive: bool, ?inclusiveStart: bool, ?inclusiveEnd: bool, ?block: bool) : ReplaceDecorationSpec = nativeOnly

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
        [<ParamObject; Emit("$0")>]
        static member Create (?attributes: LineDecorationSpec.attributes, ?``class``: string) : LineDecorationSpec = nativeOnly

    /// <summary>
    /// Widgets added to the content are described by subclasses of this
    /// class. Using a description object like that makes it possible to
    /// delay creating of the DOM structure for a widget until it is
    /// needed, and to avoid redrawing widgets even if the decorations
    /// that define them are recreated.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("WidgetType", "@codemirror/view")>]
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
        Glutinum.CodemirrorState.RangeSet<CodemirrorView.Decoration>

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
    [<Import("Decoration", "@codemirror/view")>]
    type Decoration =
        inherit Glutinum.CodemirrorState.RangeValue
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
        [<Emit("""import { Decoration } from "@codemirror/view";
Decoration.mark($0)""")>]
        static member inline mark (spec: CodemirrorView.MarkDecorationSpec): CodemirrorView.Decoration = nativeOnly
        /// <summary>
        /// Create a widget decoration, which displays a DOM element at the
        /// given position.
        /// </summary>
        [<Emit("""import { Decoration } from "@codemirror/view";
Decoration.widget($0)""")>]
        static member inline widget (spec: CodemirrorView.WidgetDecorationSpec): CodemirrorView.Decoration = nativeOnly
        /// <summary>
        /// Create a replace decoration which replaces the given range with
        /// a widget, or simply hides it.
        /// </summary>
        [<Emit("""import { Decoration } from "@codemirror/view";
Decoration.replace($0)""")>]
        static member inline replace (spec: CodemirrorView.ReplaceDecorationSpec): CodemirrorView.Decoration = nativeOnly
        /// <summary>
        /// Create a line decoration, which can add DOM attributes to the
        /// line starting at the given position.
        /// </summary>
        [<Emit("""import { Decoration } from "@codemirror/view";
Decoration.line($0)""")>]
        static member inline line (spec: CodemirrorView.LineDecorationSpec): CodemirrorView.Decoration = nativeOnly
        /// <summary>
        /// Build a [<c>DecorationSet</c>](https://codemirror.net/6/docs/ref/#view.DecorationSet) from the given
        /// decorated range or ranges. If the ranges aren't already sorted,
        /// pass <c>true</c> for <c>sort</c> to make the library sort them for you.
        /// </summary>
        [<Emit("""import { Decoration } from "@codemirror/view";
Decoration.set($0, $1)""")>]
        static member inline set (``of``: Glutinum.CodemirrorState.Range<CodemirrorView.Decoration>, ?sort: bool): CodemirrorView.DecorationSet = nativeOnly
        /// <summary>
        /// Build a [<c>DecorationSet</c>](https://codemirror.net/6/docs/ref/#view.DecorationSet) from the given
        /// decorated range or ranges. If the ranges aren't already sorted,
        /// pass <c>true</c> for <c>sort</c> to make the library sort them for you.
        /// </summary>
        [<Emit("""import { Decoration } from "@codemirror/view";
Decoration.set($0, $1)""")>]
        static member inline set (``of``: ResizeArray<Glutinum.CodemirrorState.Range<CodemirrorView.Decoration>>, ?sort: bool): CodemirrorView.DecorationSet = nativeOnly
        /// <summary>
        /// The empty set of decorations.
        /// </summary>
        [<Emit("""import { Decoration } from "@codemirror/view";
Decoration.none{{=$0}}""")>]
        static member inline none
            with get () : CodemirrorView.DecorationSet =
                nativeOnly
            and set (value: CodemirrorView.DecorationSet) =
                nativeOnly

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
    [<Import("BlockWrapper", "@codemirror/view")>]
    type BlockWrapper =
        inherit Glutinum.CodemirrorState.RangeValue
        /// <summary>
        /// Compare this value with another value. Used when comparing
        /// rangesets. The default implementation compares by identity.
        /// Unless you are only creating a fixed number of unique instances
        /// of your value type, it is a good idea to implement this
        /// properly.
        /// </summary>
        abstract member eq: other: Glutinum.CodemirrorState.RangeValue -> bool
        /// <summary>
        /// Create a block wrapper object with the given tag name and
        /// attributes.
        /// </summary>
        [<Emit("""import { BlockWrapper } from "@codemirror/view";
BlockWrapper.create($0)""")>]
        static member inline create (spec: CodemirrorView.BlockWrapperSpec): CodemirrorView.BlockWrapper = nativeOnly
        /// <summary>
        /// Create a range set from the given block wrapper ranges.
        /// </summary>
        [<Emit("""import { BlockWrapper } from "@codemirror/view";
BlockWrapper.set($0, $1)""")>]
        static member inline set (``of``: Glutinum.CodemirrorState.Range<CodemirrorView.BlockWrapper>, ?sort: bool): Glutinum.CodemirrorState.RangeSet<CodemirrorView.BlockWrapper> = nativeOnly
        /// <summary>
        /// Create a range set from the given block wrapper ranges.
        /// </summary>
        [<Emit("""import { BlockWrapper } from "@codemirror/view";
BlockWrapper.set($0, $1)""")>]
        static member inline set (``of``: ResizeArray<Glutinum.CodemirrorState.Range<CodemirrorView.BlockWrapper>>, ?sort: bool): Glutinum.CodemirrorState.RangeSet<CodemirrorView.BlockWrapper> = nativeOnly

    /// <summary>
    /// Command functions are used in key bindings and other types of user
    /// actions. Given an editor view, they check whether their effect can
    /// apply to the editor, and if it can, perform it as a side effect
    /// (which usually means [dispatching](https://codemirror.net/6/docs/ref/#view.EditorView.dispatch) a
    /// transaction) and return <c>true</c>.
    /// </summary>
    type Command =
        CodemirrorView.EditorView -> bool

    [<AllowNullLiteral>]
    [<Interface>]
    type ScrollTarget =
        abstract member range: Glutinum.CodemirrorState.SelectionRange with get
        abstract member y: CodemirrorView.ScrollStrategy with get
        abstract member x: CodemirrorView.ScrollStrategy with get
        abstract member yMargin: float with get
        abstract member xMargin: float with get
        abstract member isSnapshot: bool with get
        abstract member map: changes: Glutinum.CodemirrorState.ChangeDesc -> CodemirrorView.ScrollTarget
        abstract member clip: state: Glutinum.CodemirrorState.EditorState -> CodemirrorView.ScrollTarget

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
        abstract member update: (CodemirrorView.ViewUpdate -> unit) option with get, set
        /// <summary>
        /// Called when the document view is updated (due to content,
        /// decoration, or viewport changes). Should not try to immediately
        /// start another view update. Often useful for calling
        /// [<c>requestMeasure</c>](https://codemirror.net/6/docs/ref/#view.EditorView.requestMeasure).
        /// </summary>
        abstract member docViewUpdate: (CodemirrorView.EditorView -> unit) option with get, set
        /// <summary>
        /// Called when the plugin is no longer going to be used. Should
        /// revert any changes the plugin made to the DOM.
        /// </summary>
        abstract member destroy: (unit -> unit) option with get, set

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
        abstract member provide: (CodemirrorView.ViewPlugin<'V, obj> -> Glutinum.CodemirrorState.Extension) option with get, set
        /// <summary>
        /// Allow the plugin to provide decorations. When given, this should
        /// be a function that take the plugin value and return a
        /// [decoration set](https://codemirror.net/6/docs/ref/#view.DecorationSet). See also the caveat about
        /// [layout-changing decorations](https://codemirror.net/6/docs/ref/#view.EditorView^decorations) that
        /// depend on the view.
        /// </summary>
        abstract member decorations: ('V -> CodemirrorView.DecorationSet) option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?eventHandlers: CodemirrorView.DOMEventHandlers<'V>, ?eventObservers: CodemirrorView.DOMEventHandlers<'V>, ?provide: (CodemirrorView.ViewPlugin<'V, obj> -> Glutinum.CodemirrorState.Extension), ?decorations: ('V -> CodemirrorView.DecorationSet)) : PluginSpec<'V> = nativeOnly

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
    [<Import("ViewPlugin", "@codemirror/view")>]
    type ViewPlugin<'V, 'Arg> =
        /// <summary>
        /// When <c>Arg</c> is undefined, instances of this class act as
        /// extensions. Otherwise, you have to call <c>of</c> to create an
        /// extension value.
        /// </summary>
        abstract member extension: Glutinum.CodemirrorState.Extension with get, set
        /// <summary>
        /// Create an extension for this plugin with the given argument.
        /// </summary>
        abstract member ``of``: arg: 'Arg -> Glutinum.CodemirrorState.Extension
        /// <summary>
        /// Define a plugin from a constructor function that creates the
        /// plugin's value, given an editor view.
        /// </summary>
        [<Emit("""import { ViewPlugin } from "@codemirror/view";
ViewPlugin.define($0, $1)""")>]
        static member inline define (create: ViewPlugin.define__.create<'V, 'Arg>, ?spec: CodemirrorView.PluginSpec<'V>): CodemirrorView.ViewPlugin<'V, 'Arg> = nativeOnly
        /// <summary>
        /// Create a plugin for a class whose constructor takes a single
        /// editor view as argument.
        /// </summary>
        [<Emit("""import { ViewPlugin } from "@codemirror/view";
ViewPlugin.fromClass($0, $1)""")>]
        static member inline fromClass (cls: ViewPlugin.fromClass__.cls<'V, 'Arg>, ?spec: CodemirrorView.PluginSpec<'V>): CodemirrorView.ViewPlugin<'V, 'Arg> = nativeOnly

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
        abstract member write: MeasureRequest.write option with get, set
        /// <summary>
        /// When multiple requests with the same key are scheduled, only the
        /// last one will actually be run.
        /// </summary>
        abstract member key: obj option with get, set

    [<RequireQualifiedAccess>]
    [<Erase>]
    type AttrSource =
        | Attrs of CodemirrorView.Attrs
        | Function of (CodemirrorView.EditorView -> CodemirrorView.Attrs option)

        [<Emit("$0")>]
        static member op_Implicit(value: CodemirrorView.Attrs) : AttrSource = nativeOnly

        [<Emit("$0")>]
        static member op_ErasedCast(value: CodemirrorView.Attrs) : AttrSource = nativeOnly

        [<Emit("$0")>]
        static member op_Implicit(value: (CodemirrorView.EditorView -> CodemirrorView.Attrs option)) : AttrSource = nativeOnly

        [<Emit("$0")>]
        static member op_ErasedCast(value: (CodemirrorView.EditorView -> CodemirrorView.Attrs option)) : AttrSource = nativeOnly

        /// Unchecked, the value as <c>Attrs</c> whatever case it holds
        [<Emit("$0")>]
        member _.AsAttrs: CodemirrorView.Attrs = nativeOnly

        /// Unchecked, the value as <c>Function</c> whatever case it holds
        [<Emit("$0")>]
        member _.AsFunction: (CodemirrorView.EditorView -> CodemirrorView.Attrs option) = nativeOnly

    /// <summary>
    /// View [plugins](https://codemirror.net/6/docs/ref/#view.ViewPlugin) are given instances of this
    /// class, which describe what happened, whenever the view is updated.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("ViewUpdate", "@codemirror/view")>]
    type ViewUpdate =
        /// <summary>
        /// The editor view that the update is associated with.
        /// </summary>
        abstract member view: CodemirrorView.EditorView with get
        /// <summary>
        /// The new editor state.
        /// </summary>
        abstract member state: Glutinum.CodemirrorState.EditorState with get
        /// <summary>
        /// The transactions involved in the update. May be empty.
        /// </summary>
        abstract member transactions: ReadonlyArray<Glutinum.CodemirrorState.Transaction> with get
        /// <summary>
        /// The changes made to the document by this update.
        /// </summary>
        abstract member changes: Glutinum.CodemirrorState.ChangeSet with get
        /// <summary>
        /// The previous editor state.
        /// </summary>
        abstract member startState: Glutinum.CodemirrorState.EditorState with get
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
        [<ParamObject; Emit("$0")>]
        static member Create (get: MouseSelectionStyle.get, update: (CodemirrorView.ViewUpdate -> U2<bool, unit>)) : MouseSelectionStyle = nativeOnly

    type MakeSelectionStyle =
        delegate of view: CodemirrorView.EditorView * event: Glutinum.Web.MouseEvent -> CodemirrorView.MouseSelectionStyle option

    /// <summary>
    /// Record used to represent information about a block-level element
    /// in the editor view.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("BlockInfo", "@codemirror/view")>]
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
        abstract member ``type``: U2<CodemirrorView.BlockType, ResizeArray<CodemirrorView.BlockInfo>> with get
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
        inherit Glutinum.CodemirrorState.EditorStateConfig
        /// <summary>
        /// The view's initial state. If not given, a new state is created
        /// by passing this configuration object to
        /// [<c>EditorState.create</c>](https://codemirror.net/6/docs/ref/#state.EditorState^create), using its
        /// <c>doc</c>, <c>selection</c>, and <c>extensions</c> field (if provided).
        /// </summary>
        abstract member state: Glutinum.CodemirrorState.EditorState option with get, set
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
        abstract member scrollTo: Glutinum.CodemirrorState.StateEffect<obj> option with get, set
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
        static member Create (?doc: U2<string, Glutinum.CodemirrorState.Text>, ?selection: U2<Glutinum.CodemirrorState.EditorSelection, EditorViewConfig.selection.U2.Case2>, ?extensions: Glutinum.CodemirrorState.Extension, ?state: Glutinum.CodemirrorState.EditorState, ?parent: U2<Glutinum.Web.Element, Glutinum.Web.DocumentFragment>, ?root: U2<Glutinum.Web.Document, Glutinum.Web.ShadowRoot>, ?scrollTo: Glutinum.CodemirrorState.StateEffect<obj>, ?dispatchTransactions: EditorViewConfig.dispatchTransactions, ?dispatch: EditorViewConfig.dispatch) : EditorViewConfig = nativeOnly

    /// <summary>
    /// An editor view represents the editor's user interface. It holds
    /// the editable DOM surface, and possibly other elements such as the
    /// line number gutter. It handles events and dispatches state
    /// transactions for editing actions.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("EditorView", "@codemirror/view")>]
    type EditorView =
        /// <summary>
        /// The current editor state.
        /// </summary>
        abstract member state: Glutinum.CodemirrorState.EditorState with get
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
        abstract member visibleRanges: ReadonlyArray<EditorView.visibleRanges.Item> with get
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
        abstract member dispatch: tr: Glutinum.CodemirrorState.Transaction -> unit
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
        abstract member dispatch: trs: ResizeArray<Glutinum.CodemirrorState.Transaction> -> unit
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
        abstract member dispatch: [<ParamArray>] specs: Glutinum.CodemirrorState.TransactionSpec [] -> unit
        /// <summary>
        /// Update the view for the given array of transactions. This will
        /// update the visible document and selection to match the state
        /// produced by the transactions, and notify view plugins of the
        /// change. You should usually call
        /// [<c>dispatch</c>](https://codemirror.net/6/docs/ref/#view.EditorView.dispatch) instead, which uses this
        /// as a primitive.
        /// </summary>
        abstract member update: transactions: ResizeArray<Glutinum.CodemirrorState.Transaction> -> unit
        /// <summary>
        /// Reset the view to the given state. (This will cause the entire
        /// document to be redrawn and all view plugins to be reinitialized,
        /// so you should probably only use it when the new state isn't
        /// derived from the old state. Otherwise, use
        /// [<c>dispatch</c>](https://codemirror.net/6/docs/ref/#view.EditorView.dispatch) instead.)
        /// </summary>
        abstract member setState: newState: Glutinum.CodemirrorState.EditorState -> unit
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
        abstract member moveByChar: start: Glutinum.CodemirrorState.SelectionRange * forward: bool * ?by: (string -> (string -> bool)) -> Glutinum.CodemirrorState.SelectionRange
        /// <summary>
        /// Move a cursor position across the next group of either
        /// [letters](https://codemirror.net/6/docs/ref/#state.EditorState.charCategorizer) or non-letter
        /// non-whitespace characters.
        /// </summary>
        abstract member moveByGroup: start: Glutinum.CodemirrorState.SelectionRange * forward: bool -> Glutinum.CodemirrorState.SelectionRange
        /// <summary>
        /// Get the cursor position visually at the start or end of a line.
        /// Note that this may differ from the _logical_ position at its
        /// start or end (which is simply at <c>line.from</c>/<c>line.to</c>) if text
        /// at the start or end goes against the line's base text direction.
        /// </summary>
        abstract member visualLineSide: line: Glutinum.CodemirrorState.Line * ``end``: bool -> Glutinum.CodemirrorState.SelectionRange
        /// <summary>
        /// Move to the next line boundary in the given direction. If
        /// <c>includeWrap</c> is true, line wrapping is on, and there is a
        /// further wrap point on the current line, the wrap point will be
        /// returned. Otherwise this function will return the start or end
        /// of the line.
        /// </summary>
        abstract member moveToLineBoundary: start: Glutinum.CodemirrorState.SelectionRange * forward: bool * ?includeWrap: bool -> Glutinum.CodemirrorState.SelectionRange
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
        abstract member moveVertically: start: Glutinum.CodemirrorState.SelectionRange * forward: bool * ?distance: float -> Glutinum.CodemirrorState.SelectionRange
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
        abstract member posAtCoords: coords: EditorView.posAtCoords.coords -> float option
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
        abstract member posAndSideAtCoords: coords: EditorView.posAndSideAtCoords.coords -> EditorView.posAndSideAtCoords option
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
        abstract member bidiSpans: line: Glutinum.CodemirrorState.Line -> ReadonlyArray<CodemirrorView.BidiSpan>
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
        [<Emit("""import { EditorView } from "@codemirror/view";
EditorView.scrollIntoView($0, $1)""")>]
        static member inline scrollIntoView (pos: float, ?options: EditorView.scrollIntoView__.options): Glutinum.CodemirrorState.StateEffect<obj> = nativeOnly
        /// <summary>
        /// Returns an effect that can be
        /// [added](https://codemirror.net/6/docs/ref/#state.TransactionSpec.effects) to a transaction to
        /// cause it to scroll the given position or range into view.
        /// </summary>
        [<Emit("""import { EditorView } from "@codemirror/view";
EditorView.scrollIntoView($0, $1)""")>]
        static member inline scrollIntoView (pos: Glutinum.CodemirrorState.SelectionRange, ?options: EditorView.scrollIntoView__.options): Glutinum.CodemirrorState.StateEffect<obj> = nativeOnly
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
        abstract member scrollSnapshot: unit -> Glutinum.CodemirrorState.StateEffect<CodemirrorView.ScrollTarget>
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
        [<Emit("""import { EditorView } from "@codemirror/view";
EditorView.styleModule{{=$0}}""")>]
        static member inline styleModule
            with get () : Glutinum.CodemirrorState.Facet<StyleMod.StyleModule, ReadonlyArray<StyleMod.StyleModule>> =
                nativeOnly
            and set (value: Glutinum.CodemirrorState.Facet<StyleMod.StyleModule, ReadonlyArray<StyleMod.StyleModule>>) =
                nativeOnly
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
        [<Emit("""import { EditorView } from "@codemirror/view";
EditorView.domEventHandlers($0)""")>]
        static member inline domEventHandlers (handlers: EditorView.domEventHandlers__.handlers): Glutinum.CodemirrorState.Extension = nativeOnly
        /// <summary>
        /// Create an extension that registers DOM event observers. Contrary
        /// to event [handlers](https://codemirror.net/6/docs/ref/#view.EditorView^domEventHandlers),
        /// observers can't be prevented from running by a higher-precedence
        /// handler returning true. They also don't prevent other handlers
        /// and observers from running when they return true, and should not
        /// call <c>preventDefault</c>.
        /// </summary>
        [<Emit("""import { EditorView } from "@codemirror/view";
EditorView.domEventObservers($0)""")>]
        static member inline domEventObservers (observers: EditorView.domEventObservers__.observers): Glutinum.CodemirrorState.Extension = nativeOnly
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
        [<Emit("""import { EditorView } from "@codemirror/view";
EditorView.inputHandler{{=$0}}""")>]
        static member inline inputHandler
            with get () : Glutinum.CodemirrorState.Facet<EditorView.inputHandler__, ReadonlyArray<EditorView.inputHandler__.Item>> =
                nativeOnly
            and set (value: Glutinum.CodemirrorState.Facet<EditorView.inputHandler__, ReadonlyArray<EditorView.inputHandler__.Item>>) =
                nativeOnly
        /// <summary>
        /// Functions provided in this facet will be used to transform text
        /// pasted or dropped into the editor.
        /// </summary>
        [<Emit("""import { EditorView } from "@codemirror/view";
EditorView.clipboardInputFilter{{=$0}}""")>]
        static member inline clipboardInputFilter
            with get () : Glutinum.CodemirrorState.Facet<EditorView.clipboardInputFilter__, ReadonlyArray<EditorView.clipboardInputFilter__.Item>> =
                nativeOnly
            and set (value: Glutinum.CodemirrorState.Facet<EditorView.clipboardInputFilter__, ReadonlyArray<EditorView.clipboardInputFilter__.Item>>) =
                nativeOnly
        /// <summary>
        /// Transform text copied or dragged from the editor.
        /// </summary>
        [<Emit("""import { EditorView } from "@codemirror/view";
EditorView.clipboardOutputFilter{{=$0}}""")>]
        static member inline clipboardOutputFilter
            with get () : Glutinum.CodemirrorState.Facet<EditorView.clipboardOutputFilter__, ReadonlyArray<EditorView.clipboardOutputFilter__.Item>> =
                nativeOnly
            and set (value: Glutinum.CodemirrorState.Facet<EditorView.clipboardOutputFilter__, ReadonlyArray<EditorView.clipboardOutputFilter__.Item>>) =
                nativeOnly
        /// <summary>
        /// Scroll handlers can override how things are scrolled into view.
        /// If they return <c>true</c>, no further handling happens for the
        /// scrolling. If they return false, the default scroll behavior is
        /// applied. Scroll handlers should never initiate editor updates.
        /// </summary>
        [<Emit("""import { EditorView } from "@codemirror/view";
EditorView.scrollHandler{{=$0}}""")>]
        static member inline scrollHandler
            with get () : Glutinum.CodemirrorState.Facet<EditorView.scrollHandler__, ReadonlyArray<EditorView.scrollHandler__.Item>> =
                nativeOnly
            and set (value: Glutinum.CodemirrorState.Facet<EditorView.scrollHandler__, ReadonlyArray<EditorView.scrollHandler__.Item>>) =
                nativeOnly
        /// <summary>
        /// This facet can be used to provide functions that create effects
        /// to be dispatched when the editor's focus state changes.
        /// </summary>
        [<Emit("""import { EditorView } from "@codemirror/view";
EditorView.focusChangeEffect{{=$0}}""")>]
        static member inline focusChangeEffect
            with get () : Glutinum.CodemirrorState.Facet<EditorView.focusChangeEffect__, ReadonlyArray<EditorView.focusChangeEffect__.Item>> =
                nativeOnly
            and set (value: Glutinum.CodemirrorState.Facet<EditorView.focusChangeEffect__, ReadonlyArray<EditorView.focusChangeEffect__.Item>>) =
                nativeOnly
        /// <summary>
        /// By default, the editor assumes all its content has the same
        /// [text direction](https://codemirror.net/6/docs/ref/#view.Direction). Configure this with a <c>true</c>
        /// value to make it read the text direction of every (rendered)
        /// line separately.
        /// </summary>
        [<Emit("""import { EditorView } from "@codemirror/view";
EditorView.perLineTextDirection{{=$0}}""")>]
        static member inline perLineTextDirection
            with get () : Glutinum.CodemirrorState.Facet<bool, bool> =
                nativeOnly
            and set (value: Glutinum.CodemirrorState.Facet<bool, bool>) =
                nativeOnly
        /// <summary>
        /// Allows you to provide a function that should be called when the
        /// library catches an exception from an extension (mostly from view
        /// plugins, but may be used by other extensions to route exceptions
        /// from user-code-provided callbacks). This is mostly useful for
        /// debugging and logging. See [<c>logException</c>](https://codemirror.net/6/docs/ref/#view.logException).
        /// </summary>
        [<Emit("""import { EditorView } from "@codemirror/view";
EditorView.exceptionSink{{=$0}}""")>]
        static member inline exceptionSink
            with get () : Glutinum.CodemirrorState.Facet<(obj -> unit), ReadonlyArray<(obj -> unit)>> =
                nativeOnly
            and set (value: Glutinum.CodemirrorState.Facet<(obj -> unit), ReadonlyArray<(obj -> unit)>>) =
                nativeOnly
        /// <summary>
        /// A facet that can be used to register a function to be called
        /// every time the view updates.
        /// </summary>
        [<Emit("""import { EditorView } from "@codemirror/view";
EditorView.updateListener{{=$0}}""")>]
        static member inline updateListener
            with get () : Glutinum.CodemirrorState.Facet<(CodemirrorView.ViewUpdate -> unit), ReadonlyArray<(CodemirrorView.ViewUpdate -> unit)>> =
                nativeOnly
            and set (value: Glutinum.CodemirrorState.Facet<(CodemirrorView.ViewUpdate -> unit), ReadonlyArray<(CodemirrorView.ViewUpdate -> unit)>>) =
                nativeOnly
        /// <summary>
        /// Facet that controls whether the editor content DOM is editable.
        /// When its highest-precedence value is <c>false</c>, the element will
        /// not have its <c>contenteditable</c> attribute set. (Note that this
        /// doesn't affect API calls that change the editor content, even
        /// when those are bound to keys or buttons. See the
        /// [<c>readOnly</c>](https://codemirror.net/6/docs/ref/#state.EditorState.readOnly) facet for that.)
        /// </summary>
        [<Emit("""import { EditorView } from "@codemirror/view";
EditorView.editable{{=$0}}""")>]
        static member inline editable
            with get () : Glutinum.CodemirrorState.Facet<bool, bool> =
                nativeOnly
            and set (value: Glutinum.CodemirrorState.Facet<bool, bool>) =
                nativeOnly
        /// <summary>
        /// Allows you to influence the way mouse selection happens. The
        /// functions in this facet will be called for a <c>mousedown</c> event
        /// on the editor, and can return an object that overrides the way a
        /// selection is computed from that mouse click or drag.
        /// </summary>
        [<Emit("""import { EditorView } from "@codemirror/view";
EditorView.mouseSelectionStyle{{=$0}}""")>]
        static member inline mouseSelectionStyle
            with get () : Glutinum.CodemirrorState.Facet<CodemirrorView.MakeSelectionStyle, ReadonlyArray<CodemirrorView.MakeSelectionStyle>> =
                nativeOnly
            and set (value: Glutinum.CodemirrorState.Facet<CodemirrorView.MakeSelectionStyle, ReadonlyArray<CodemirrorView.MakeSelectionStyle>>) =
                nativeOnly
        /// <summary>
        /// Facet used to configure whether a given selection drag event
        /// should move or copy the selection. The given predicate will be
        /// called with the <c>mousedown</c> event, and can return <c>true</c> when
        /// the drag should move the content.
        /// </summary>
        [<Emit("""import { EditorView } from "@codemirror/view";
EditorView.dragMovesSelection{{=$0}}""")>]
        static member inline dragMovesSelection
            with get () : Glutinum.CodemirrorState.Facet<(Glutinum.Web.MouseEvent -> bool), ReadonlyArray<(Glutinum.Web.MouseEvent -> bool)>> =
                nativeOnly
            and set (value: Glutinum.CodemirrorState.Facet<(Glutinum.Web.MouseEvent -> bool), ReadonlyArray<(Glutinum.Web.MouseEvent -> bool)>>) =
                nativeOnly
        /// <summary>
        /// Facet used to configure whether a given selecting click adds a
        /// new range to the existing selection or replaces it entirely. The
        /// default behavior is to check <c>event.metaKey</c> on macOS, and
        /// <c>event.ctrlKey</c> elsewhere.
        /// </summary>
        [<Emit("""import { EditorView } from "@codemirror/view";
EditorView.clickAddsSelectionRange{{=$0}}""")>]
        static member inline clickAddsSelectionRange
            with get () : Glutinum.CodemirrorState.Facet<(Glutinum.Web.MouseEvent -> bool), ReadonlyArray<(Glutinum.Web.MouseEvent -> bool)>> =
                nativeOnly
            and set (value: Glutinum.CodemirrorState.Facet<(Glutinum.Web.MouseEvent -> bool), ReadonlyArray<(Glutinum.Web.MouseEvent -> bool)>>) =
                nativeOnly
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
        [<Emit("""import { EditorView } from "@codemirror/view";
EditorView.decorations{{=$0}}""")>]
        static member inline decorations
            with get () : Glutinum.CodemirrorState.Facet<U2<CodemirrorView.DecorationSet, (CodemirrorView.EditorView -> CodemirrorView.DecorationSet)>, ReadonlyArray<U2<CodemirrorView.DecorationSet, (CodemirrorView.EditorView -> CodemirrorView.DecorationSet)>>> =
                nativeOnly
            and set (value: Glutinum.CodemirrorState.Facet<U2<CodemirrorView.DecorationSet, (CodemirrorView.EditorView -> CodemirrorView.DecorationSet)>, ReadonlyArray<U2<CodemirrorView.DecorationSet, (CodemirrorView.EditorView -> CodemirrorView.DecorationSet)>>>) =
                nativeOnly
        /// <summary>
        /// [Block wrappers](https://codemirror.net/6/docs/ref/#view.BlockWrapper) provide a way to add DOM
        /// structure around editor lines and block widgets. Sets of
        /// wrappers are provided in a similar way to decorations, and are
        /// nested in a similar way when they overlap. A wrapper affects all
        /// lines and block widgets that start inside its range.
        /// </summary>
        [<Emit("""import { EditorView } from "@codemirror/view";
EditorView.blockWrappers{{=$0}}""")>]
        static member inline blockWrappers
            with get () : Glutinum.CodemirrorState.Facet<U2<Glutinum.CodemirrorState.RangeSet<CodemirrorView.BlockWrapper>, (CodemirrorView.EditorView -> Glutinum.CodemirrorState.RangeSet<CodemirrorView.BlockWrapper>)>, ReadonlyArray<U2<Glutinum.CodemirrorState.RangeSet<CodemirrorView.BlockWrapper>, (CodemirrorView.EditorView -> Glutinum.CodemirrorState.RangeSet<CodemirrorView.BlockWrapper>)>>> =
                nativeOnly
            and set (value: Glutinum.CodemirrorState.Facet<U2<Glutinum.CodemirrorState.RangeSet<CodemirrorView.BlockWrapper>, (CodemirrorView.EditorView -> Glutinum.CodemirrorState.RangeSet<CodemirrorView.BlockWrapper>)>, ReadonlyArray<U2<Glutinum.CodemirrorState.RangeSet<CodemirrorView.BlockWrapper>, (CodemirrorView.EditorView -> Glutinum.CodemirrorState.RangeSet<CodemirrorView.BlockWrapper>)>>>) =
                nativeOnly
        /// <summary>
        /// Facet that works much like
        /// [<c>decorations</c>](https://codemirror.net/6/docs/ref/#view.EditorView^decorations), but puts its
        /// inputs at the very bottom of the precedence stack, meaning mark
        /// decorations provided here will only be split by other, partially
        /// overlapping <c>outerDecorations</c> ranges, and wrap around all
        /// regular decorations. Use this for mark elements that should, as
        /// much as possible, remain in one piece.
        /// </summary>
        [<Emit("""import { EditorView } from "@codemirror/view";
EditorView.outerDecorations{{=$0}}""")>]
        static member inline outerDecorations
            with get () : Glutinum.CodemirrorState.Facet<U2<CodemirrorView.DecorationSet, (CodemirrorView.EditorView -> CodemirrorView.DecorationSet)>, ReadonlyArray<U2<CodemirrorView.DecorationSet, (CodemirrorView.EditorView -> CodemirrorView.DecorationSet)>>> =
                nativeOnly
            and set (value: Glutinum.CodemirrorState.Facet<U2<CodemirrorView.DecorationSet, (CodemirrorView.EditorView -> CodemirrorView.DecorationSet)>, ReadonlyArray<U2<CodemirrorView.DecorationSet, (CodemirrorView.EditorView -> CodemirrorView.DecorationSet)>>>) =
                nativeOnly
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
        [<Emit("""import { EditorView } from "@codemirror/view";
EditorView.atomicRanges{{=$0}}""")>]
        static member inline atomicRanges
            with get () : Glutinum.CodemirrorState.Facet<(CodemirrorView.EditorView -> Glutinum.CodemirrorState.RangeSet<obj>), ReadonlyArray<(CodemirrorView.EditorView -> Glutinum.CodemirrorState.RangeSet<obj>)>> =
                nativeOnly
            and set (value: Glutinum.CodemirrorState.Facet<(CodemirrorView.EditorView -> Glutinum.CodemirrorState.RangeSet<obj>), ReadonlyArray<(CodemirrorView.EditorView -> Glutinum.CodemirrorState.RangeSet<obj>)>>) =
                nativeOnly
        /// <summary>
        /// When range decorations add a <c>unicode-bidi: isolate</c> style, they
        /// should also include a
        /// [<c>bidiIsolate</c>](https://codemirror.net/6/docs/ref/#view.MarkDecorationSpec.bidiIsolate) property
        /// in their decoration spec, and be exposed through this facet, so
        /// that the editor can compute the proper text order. (Other values
        /// for <c>unicode-bidi</c>, except of course <c>normal</c>, are not
        /// supported.)
        /// </summary>
        [<Emit("""import { EditorView } from "@codemirror/view";
EditorView.bidiIsolatedRanges{{=$0}}""")>]
        static member inline bidiIsolatedRanges
            with get () : Glutinum.CodemirrorState.Facet<U2<CodemirrorView.DecorationSet, (CodemirrorView.EditorView -> CodemirrorView.DecorationSet)>, ReadonlyArray<U2<CodemirrorView.DecorationSet, (CodemirrorView.EditorView -> CodemirrorView.DecorationSet)>>> =
                nativeOnly
            and set (value: Glutinum.CodemirrorState.Facet<U2<CodemirrorView.DecorationSet, (CodemirrorView.EditorView -> CodemirrorView.DecorationSet)>, ReadonlyArray<U2<CodemirrorView.DecorationSet, (CodemirrorView.EditorView -> CodemirrorView.DecorationSet)>>>) =
                nativeOnly
        /// <summary>
        /// Can be used to specify the distance that scrolling cursor into
        /// view keeps it away from the sides of the editor, either as a
        /// single pixel number or two different values for the different
        /// axes. Defaults to 5 pixels on both axes.
        /// </summary>
        [<Emit("""import { EditorView } from "@codemirror/view";
EditorView.cursorScrollMargin{{=$0}}""")>]
        static member inline cursorScrollMargin
            with get () : Glutinum.CodemirrorState.Facet<U2<float, EditorView.cursorScrollMargin__.U2.Case2>, EditorView.cursorScrollMargin__> =
                nativeOnly
            and set (value: Glutinum.CodemirrorState.Facet<U2<float, EditorView.cursorScrollMargin__.U2.Case2>, EditorView.cursorScrollMargin__>) =
                nativeOnly
        /// <summary>
        /// Facet that allows extensions to provide additional scroll
        /// margins (space around the sides of the scrolling element that
        /// should be considered invisible). This can be useful when the
        /// plugin introduces elements that cover part of that element (for
        /// example a horizontally fixed gutter). Not to be confused with
        /// [<c>cursorScrollMargin</c>](https://codemirror.net/6/docs/ref/#view.EditorView^cursorScrollMargin).
        /// </summary>
        [<Emit("""import { EditorView } from "@codemirror/view";
EditorView.scrollMargins{{=$0}}""")>]
        static member inline scrollMargins
            with get () : Glutinum.CodemirrorState.Facet<(CodemirrorView.EditorView -> EditorView.scrollMargins__ option), ReadonlyArray<(CodemirrorView.EditorView -> EditorView.scrollMargins__.Item option)>> =
                nativeOnly
            and set (value: Glutinum.CodemirrorState.Facet<(CodemirrorView.EditorView -> EditorView.scrollMargins__ option), ReadonlyArray<(CodemirrorView.EditorView -> EditorView.scrollMargins__.Item option)>>) =
                nativeOnly
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
        [<Emit("""import { EditorView } from "@codemirror/view";
EditorView.theme($0, $1)""")>]
        static member inline theme (spec: EditorView.theme__.spec, ?options: EditorView.theme__.options): Glutinum.CodemirrorState.Extension = nativeOnly
        /// <summary>
        /// This facet records whether a dark theme is active. The extension
        /// returned by [<c>theme</c>](https://codemirror.net/6/docs/ref/#view.EditorView^theme) automatically
        /// includes an instance of this when the <c>dark</c> option is set to
        /// true.
        /// </summary>
        [<Emit("""import { EditorView } from "@codemirror/view";
EditorView.darkTheme{{=$0}}""")>]
        static member inline darkTheme
            with get () : Glutinum.CodemirrorState.Facet<bool, bool> =
                nativeOnly
            and set (value: Glutinum.CodemirrorState.Facet<bool, bool>) =
                nativeOnly
        /// <summary>
        /// Create an extension that adds styles to the base theme. Like
        /// with [<c>theme</c>](https://codemirror.net/6/docs/ref/#view.EditorView^theme), use <c>&</c> to indicate the
        /// place of the editor wrapper element when directly targeting
        /// that. You can also use <c>&dark</c> or <c>&light</c> instead to only
        /// target editors with a dark or light theme.
        /// </summary>
        [<Emit("""import { EditorView } from "@codemirror/view";
EditorView.baseTheme($0)""")>]
        static member inline baseTheme (spec: EditorView.baseTheme__.spec): Glutinum.CodemirrorState.Extension = nativeOnly
        /// <summary>
        /// Provides a Content Security Policy nonce to use when creating
        /// the style sheets for the editor. Holds the empty string when no
        /// nonce has been provided.
        /// </summary>
        [<Emit("""import { EditorView } from "@codemirror/view";
EditorView.cspNonce{{=$0}}""")>]
        static member inline cspNonce
            with get () : Glutinum.CodemirrorState.Facet<string, string> =
                nativeOnly
            and set (value: Glutinum.CodemirrorState.Facet<string, string>) =
                nativeOnly
        /// <summary>
        /// Facet that provides additional DOM attributes for the editor's
        /// editable DOM element.
        /// </summary>
        [<Emit("""import { EditorView } from "@codemirror/view";
EditorView.contentAttributes{{=$0}}""")>]
        static member inline contentAttributes
            with get () : Glutinum.CodemirrorState.Facet<CodemirrorView.AttrSource, ReadonlyArray<CodemirrorView.AttrSource>> =
                nativeOnly
            and set (value: Glutinum.CodemirrorState.Facet<CodemirrorView.AttrSource, ReadonlyArray<CodemirrorView.AttrSource>>) =
                nativeOnly
        /// <summary>
        /// Facet that provides DOM attributes for the editor's outer
        /// element.
        /// </summary>
        [<Emit("""import { EditorView } from "@codemirror/view";
EditorView.editorAttributes{{=$0}}""")>]
        static member inline editorAttributes
            with get () : Glutinum.CodemirrorState.Facet<CodemirrorView.AttrSource, ReadonlyArray<CodemirrorView.AttrSource>> =
                nativeOnly
            and set (value: Glutinum.CodemirrorState.Facet<CodemirrorView.AttrSource, ReadonlyArray<CodemirrorView.AttrSource>>) =
                nativeOnly
        /// <summary>
        /// State effect used to include screen reader announcements in a
        /// transaction. These will be added to the DOM in a visually hidden
        /// element with <c>aria-live="polite"</c> set, and should be used to
        /// describe effects that are visually obvious but may not be
        /// noticed by screen reader users (such as moving to the next
        /// search match).
        /// </summary>
        [<Emit("""import { EditorView } from "@codemirror/view";
EditorView.announce{{=$0}}""")>]
        static member inline announce
            with get () : Glutinum.CodemirrorState.StateEffectType<string> =
                nativeOnly
            and set (value: Glutinum.CodemirrorState.StateEffectType<string>) =
                nativeOnly
        /// <summary>
        /// Retrieve an editor view instance from the view's DOM
        /// representation.
        /// </summary>
        [<Emit("""import { EditorView } from "@codemirror/view";
EditorView.findFromDOM($0)""")>]
        static member inline findFromDOM (dom: Glutinum.Web.HTMLElement): CodemirrorView.EditorView option = nativeOnly

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
        [<ParamObject; Emit("$0")>]
        static member Create (?key: string, ?mac: string, ?win: string, ?linux: string, ?run: CodemirrorView.Command, ?shift: CodemirrorView.Command, ?any: KeyBinding.any, ?scope: string, ?preventDefault: bool, ?stopPropagation: bool) : KeyBinding = nativeOnly

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
        [<ParamObject; Emit("$0")>]
        static member Create (?cursorBlinkRate: float, ?drawRangeCursor: bool, ?iosSelectionHandles: bool) : SelectionConfig = nativeOnly

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
        abstract member update: LayerMarker.update option with get, set

    /// <summary>
    /// Implementation of [<c>LayerMarker</c>](https://codemirror.net/6/docs/ref/#view.LayerMarker) that creates
    /// a rectangle at a given set of coordinates.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("RectangleMarker", "@codemirror/view")>]
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
        [<Emit("""import { RectangleMarker } from "@codemirror/view";
RectangleMarker.forRange($0, $1, $2)""")>]
        static member inline forRange (view: CodemirrorView.EditorView, className: string, range: Glutinum.CodemirrorState.SelectionRange): ReadonlyArray<CodemirrorView.RectangleMarker> = nativeOnly

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
        abstract member mount: LayerConfig.mount option with get, set
        /// <summary>
        /// If given, called when the layer is removed from the editor or
        /// the entire editor is destroyed.
        /// </summary>
        abstract member destroy: LayerConfig.destroy option with get, set

    /// <summary>
    /// Helper class used to make it easier to maintain decorations on
    /// visible code that matches a given regular expression. To be used
    /// in a [view plugin](https://codemirror.net/6/docs/ref/#view.ViewPlugin). Instances of this object
    /// represent a matching configuration.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("MatchDecorator", "@codemirror/view")>]
    type MatchDecorator =
        /// <summary>
        /// Compute the full set of decorations for matches in the given
        /// view's viewport. You'll want to call this when initializing your
        /// plugin.
        /// </summary>
        abstract member createDeco: view: CodemirrorView.EditorView -> Glutinum.CodemirrorState.RangeSet<CodemirrorView.Decoration>
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
        abstract member mount: (CodemirrorView.EditorView -> unit) option with get, set
        /// <summary>
        /// Update the DOM element for a change in the view's state.
        /// </summary>
        abstract member update: (CodemirrorView.ViewUpdate -> unit) option with get, set
        /// <summary>
        /// Called when the tooltip is removed from the editor or the editor
        /// is destroyed.
        /// </summary>
        abstract member destroy: (unit -> unit) option with get, set
        /// <summary>
        /// Called when the tooltip has been (re)positioned. The argument is
        /// the [space](https://codemirror.net/6/docs/ref/#view.tooltips^config.tooltipSpace) available to the
        /// tooltip.
        /// </summary>
        abstract member positioned: (CodemirrorView.Rect -> unit) option with get, set
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
        delegate of view: CodemirrorView.EditorView * pos: float * side: HoverTooltipSource.side -> U3<CodemirrorView.Tooltip, ResizeArray<CodemirrorView.Tooltip>, JS.Promise<U2<CodemirrorView.Tooltip, ResizeArray<CodemirrorView.Tooltip>> option>> option

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
        [<ParamObject; Emit("$0")>]
        static member Create (?topContainer: Glutinum.Web.HTMLElement, ?bottomContainer: Glutinum.Web.HTMLElement) : PanelConfig = nativeOnly

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
        abstract member mount: (unit -> unit) option with get, set
        /// <summary>
        /// Update the DOM for a given view update.
        /// </summary>
        abstract member update: (CodemirrorView.ViewUpdate -> unit) option with get, set
        /// <summary>
        /// Called when the panel is removed from the editor or the editor
        /// is destroyed.
        /// </summary>
        abstract member destroy: (unit -> unit) option with get, set
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
        CodemirrorView.EditorView -> CodemirrorView.Panel

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
        [<ParamObject; Emit("$0")>]
        static member Create (?content: DialogConfig.content, ?label: string, ?input: DialogConfig.input, ?submitLabel: string, ?``class``: string, ?top: bool) : DialogConfig = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (focus: string, ?content: DialogConfig.content, ?label: string, ?input: DialogConfig.input, ?submitLabel: string, ?``class``: string, ?top: bool) : DialogConfig = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (focus: bool, ?content: DialogConfig.content, ?label: string, ?input: DialogConfig.input, ?submitLabel: string, ?``class``: string, ?top: bool) : DialogConfig = nativeOnly

    /// <summary>
    /// A gutter marker represents a bit of information attached to a line
    /// in a specific gutter. Your own custom markers have to extend this
    /// class.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("GutterMarker", "@codemirror/view")>]
    type GutterMarker =
        inherit Glutinum.CodemirrorState.RangeValue
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
        abstract member markers: (CodemirrorView.EditorView -> U2<Glutinum.CodemirrorState.RangeSet<CodemirrorView.GutterMarker>, ResizeArray<Glutinum.CodemirrorState.RangeSet<CodemirrorView.GutterMarker>>>) option with get, set
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
        static member Create (?``class``: string, ?renderEmptyElements: bool, ?markers: (CodemirrorView.EditorView -> U2<Glutinum.CodemirrorState.RangeSet<CodemirrorView.GutterMarker>, ResizeArray<Glutinum.CodemirrorState.RangeSet<CodemirrorView.GutterMarker>>>), ?lineMarker: GutterConfig.lineMarker, ?widgetMarker: GutterConfig.widgetMarker, ?lineMarkerChange: (CodemirrorView.ViewUpdate -> bool), ?initialSpacer: (CodemirrorView.EditorView -> CodemirrorView.GutterMarker), ?updateSpacer: GutterConfig.updateSpacer, ?domEventHandlers: CodemirrorView.Handlers, ?side: GutterConfig.side) : GutterConfig = nativeOnly

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

    module MeasureRequest =

        type write =
            delegate of ``measure``: obj * view: CodemirrorView.EditorView -> unit

    module MouseSelectionStyle =

        type get =
            delegate of curEvent: Glutinum.Web.MouseEvent * extend: bool * multiple: bool -> Glutinum.CodemirrorState.EditorSelection

    module EditorViewConfig =

        type dispatchTransactions =
            delegate of trs: ResizeArray<Glutinum.CodemirrorState.Transaction> * view: CodemirrorView.EditorView -> unit

        type dispatch =
            delegate of tr: Glutinum.CodemirrorState.Transaction * view: CodemirrorView.EditorView -> unit

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

        type inputHandler__ =
            delegate of view: CodemirrorView.EditorView * from: float * ``to``: float * text: string * insert: (unit -> Glutinum.CodemirrorState.Transaction) -> bool

        type clipboardInputFilter__ =
            delegate of text: string * state: Glutinum.CodemirrorState.EditorState -> string

        type clipboardOutputFilter__ =
            delegate of text: string * state: Glutinum.CodemirrorState.EditorState -> string

        type scrollHandler__ =
            delegate of view: CodemirrorView.EditorView * range: Glutinum.CodemirrorState.SelectionRange * options: EditorView.scrollHandler__.options -> bool

        type focusChangeEffect__ =
            delegate of state: Glutinum.CodemirrorState.EditorState * focusing: bool -> Glutinum.CodemirrorState.StateEffect<obj> option

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

        module visibleRanges =

            [<AllowNullLiteral>]
            [<Interface>]
            type Item =
                abstract member from: float with get, set
                abstract member ``to``: float with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (from: float, ``to``: float) : Item = nativeOnly

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
                abstract member beforematch: EditorView.domEventHandlers__.handlers.beforematch option with get, set
                abstract member beforetoggle: EditorView.domEventHandlers__.handlers.beforetoggle option with get, set
                abstract member blur: EditorView.domEventHandlers__.handlers.blur option with get, set
                abstract member cancel: EditorView.domEventHandlers__.handlers.cancel option with get, set
                abstract member canplay: EditorView.domEventHandlers__.handlers.canplay option with get, set
                abstract member canplaythrough: EditorView.domEventHandlers__.handlers.canplaythrough option with get, set
                abstract member change: EditorView.domEventHandlers__.handlers.change option with get, set
                abstract member click: EditorView.domEventHandlers__.handlers.click option with get, set
                abstract member close: EditorView.domEventHandlers__.handlers.close option with get, set
                abstract member command: EditorView.domEventHandlers__.handlers.command option with get, set
                abstract member compositionend: EditorView.domEventHandlers__.handlers.compositionend option with get, set
                abstract member compositionstart: EditorView.domEventHandlers__.handlers.compositionstart option with get, set
                abstract member compositionupdate: EditorView.domEventHandlers__.handlers.compositionupdate option with get, set
                abstract member contextlost: EditorView.domEventHandlers__.handlers.contextlost option with get, set
                abstract member contextmenu: EditorView.domEventHandlers__.handlers.contextmenu option with get, set
                abstract member contextrestored: EditorView.domEventHandlers__.handlers.contextrestored option with get, set
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
                abstract member pointerrawupdate: EditorView.domEventHandlers__.handlers.pointerrawupdate option with get, set
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
                static member Create (?fullscreenchange: EditorView.domEventHandlers__.handlers.fullscreenchange, ?fullscreenerror: EditorView.domEventHandlers__.handlers.fullscreenerror, ?abort: EditorView.domEventHandlers__.handlers.abort, ?animationcancel: EditorView.domEventHandlers__.handlers.animationcancel, ?animationend: EditorView.domEventHandlers__.handlers.animationend, ?animationiteration: EditorView.domEventHandlers__.handlers.animationiteration, ?animationstart: EditorView.domEventHandlers__.handlers.animationstart, ?auxclick: EditorView.domEventHandlers__.handlers.auxclick, ?beforeinput: EditorView.domEventHandlers__.handlers.beforeinput, ?beforematch: EditorView.domEventHandlers__.handlers.beforematch, ?beforetoggle: EditorView.domEventHandlers__.handlers.beforetoggle, ?blur: EditorView.domEventHandlers__.handlers.blur, ?cancel: EditorView.domEventHandlers__.handlers.cancel, ?canplay: EditorView.domEventHandlers__.handlers.canplay, ?canplaythrough: EditorView.domEventHandlers__.handlers.canplaythrough, ?change: EditorView.domEventHandlers__.handlers.change, ?click: EditorView.domEventHandlers__.handlers.click, ?close: EditorView.domEventHandlers__.handlers.close, ?command: EditorView.domEventHandlers__.handlers.command, ?compositionend: EditorView.domEventHandlers__.handlers.compositionend, ?compositionstart: EditorView.domEventHandlers__.handlers.compositionstart, ?compositionupdate: EditorView.domEventHandlers__.handlers.compositionupdate, ?contextlost: EditorView.domEventHandlers__.handlers.contextlost, ?contextmenu: EditorView.domEventHandlers__.handlers.contextmenu, ?contextrestored: EditorView.domEventHandlers__.handlers.contextrestored, ?copy: EditorView.domEventHandlers__.handlers.copy, ?cuechange: EditorView.domEventHandlers__.handlers.cuechange, ?cut: EditorView.domEventHandlers__.handlers.cut, ?dblclick: EditorView.domEventHandlers__.handlers.dblclick, ?drag: EditorView.domEventHandlers__.handlers.drag, ?dragend: EditorView.domEventHandlers__.handlers.dragend, ?dragenter: EditorView.domEventHandlers__.handlers.dragenter, ?dragleave: EditorView.domEventHandlers__.handlers.dragleave, ?dragover: EditorView.domEventHandlers__.handlers.dragover, ?dragstart: EditorView.domEventHandlers__.handlers.dragstart, ?drop: EditorView.domEventHandlers__.handlers.drop, ?durationchange: EditorView.domEventHandlers__.handlers.durationchange, ?emptied: EditorView.domEventHandlers__.handlers.emptied, ?ended: EditorView.domEventHandlers__.handlers.ended, ?error: EditorView.domEventHandlers__.handlers.error, ?focus: EditorView.domEventHandlers__.handlers.focus, ?focusin: EditorView.domEventHandlers__.handlers.focusin, ?focusout: EditorView.domEventHandlers__.handlers.focusout, ?formdata: EditorView.domEventHandlers__.handlers.formdata, ?gotpointercapture: EditorView.domEventHandlers__.handlers.gotpointercapture, ?input: EditorView.domEventHandlers__.handlers.input, ?invalid: EditorView.domEventHandlers__.handlers.invalid, ?keydown: EditorView.domEventHandlers__.handlers.keydown, ?keypress: EditorView.domEventHandlers__.handlers.keypress, ?keyup: EditorView.domEventHandlers__.handlers.keyup, ?load: EditorView.domEventHandlers__.handlers.load, ?loadeddata: EditorView.domEventHandlers__.handlers.loadeddata, ?loadedmetadata: EditorView.domEventHandlers__.handlers.loadedmetadata, ?loadstart: EditorView.domEventHandlers__.handlers.loadstart, ?lostpointercapture: EditorView.domEventHandlers__.handlers.lostpointercapture, ?mousedown: EditorView.domEventHandlers__.handlers.mousedown, ?mouseenter: EditorView.domEventHandlers__.handlers.mouseenter, ?mouseleave: EditorView.domEventHandlers__.handlers.mouseleave, ?mousemove: EditorView.domEventHandlers__.handlers.mousemove, ?mouseout: EditorView.domEventHandlers__.handlers.mouseout, ?mouseover: EditorView.domEventHandlers__.handlers.mouseover, ?mouseup: EditorView.domEventHandlers__.handlers.mouseup, ?paste: EditorView.domEventHandlers__.handlers.paste, ?pause: EditorView.domEventHandlers__.handlers.pause, ?play: EditorView.domEventHandlers__.handlers.play, ?playing: EditorView.domEventHandlers__.handlers.playing, ?pointercancel: EditorView.domEventHandlers__.handlers.pointercancel, ?pointerdown: EditorView.domEventHandlers__.handlers.pointerdown, ?pointerenter: EditorView.domEventHandlers__.handlers.pointerenter, ?pointerleave: EditorView.domEventHandlers__.handlers.pointerleave, ?pointermove: EditorView.domEventHandlers__.handlers.pointermove, ?pointerout: EditorView.domEventHandlers__.handlers.pointerout, ?pointerover: EditorView.domEventHandlers__.handlers.pointerover, ?pointerrawupdate: EditorView.domEventHandlers__.handlers.pointerrawupdate, ?pointerup: EditorView.domEventHandlers__.handlers.pointerup, ?progress: EditorView.domEventHandlers__.handlers.progress, ?ratechange: EditorView.domEventHandlers__.handlers.ratechange, ?reset: EditorView.domEventHandlers__.handlers.reset, ?resize: EditorView.domEventHandlers__.handlers.resize, ?scroll: EditorView.domEventHandlers__.handlers.scroll, ?scrollend: EditorView.domEventHandlers__.handlers.scrollend, ?securitypolicyviolation: EditorView.domEventHandlers__.handlers.securitypolicyviolation, ?seeked: EditorView.domEventHandlers__.handlers.seeked, ?seeking: EditorView.domEventHandlers__.handlers.seeking, ?select: EditorView.domEventHandlers__.handlers.select, ?selectionchange: EditorView.domEventHandlers__.handlers.selectionchange, ?selectstart: EditorView.domEventHandlers__.handlers.selectstart, ?slotchange: EditorView.domEventHandlers__.handlers.slotchange, ?stalled: EditorView.domEventHandlers__.handlers.stalled, ?submit: EditorView.domEventHandlers__.handlers.submit, ?suspend: EditorView.domEventHandlers__.handlers.suspend, ?timeupdate: EditorView.domEventHandlers__.handlers.timeupdate, ?toggle: EditorView.domEventHandlers__.handlers.toggle, ?touchcancel: EditorView.domEventHandlers__.handlers.touchcancel, ?touchend: EditorView.domEventHandlers__.handlers.touchend, ?touchmove: EditorView.domEventHandlers__.handlers.touchmove, ?touchstart: EditorView.domEventHandlers__.handlers.touchstart, ?transitioncancel: EditorView.domEventHandlers__.handlers.transitioncancel, ?transitionend: EditorView.domEventHandlers__.handlers.transitionend, ?transitionrun: EditorView.domEventHandlers__.handlers.transitionrun, ?transitionstart: EditorView.domEventHandlers__.handlers.transitionstart, ?volumechange: EditorView.domEventHandlers__.handlers.volumechange, ?waiting: EditorView.domEventHandlers__.handlers.waiting, ?webkitanimationend: EditorView.domEventHandlers__.handlers.webkitanimationend, ?webkitanimationiteration: EditorView.domEventHandlers__.handlers.webkitanimationiteration, ?webkitanimationstart: EditorView.domEventHandlers__.handlers.webkitanimationstart, ?webkittransitionend: EditorView.domEventHandlers__.handlers.webkittransitionend, ?wheel: EditorView.domEventHandlers__.handlers.wheel) : handlers = nativeOnly

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
                    delegate of event: Glutinum.Web.PointerEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type beforeinput =
                    delegate of event: Glutinum.Web.InputEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type beforematch =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type beforetoggle =
                    delegate of event: Glutinum.Web.ToggleEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

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
                    delegate of event: Glutinum.Web.PointerEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type close =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type command =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type compositionend =
                    delegate of event: Glutinum.Web.CompositionEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type compositionstart =
                    delegate of event: Glutinum.Web.CompositionEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type compositionupdate =
                    delegate of event: Glutinum.Web.CompositionEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type contextlost =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type contextmenu =
                    delegate of event: Glutinum.Web.PointerEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type contextrestored =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

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
                    delegate of event: Glutinum.Web.InputEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

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

                type pointerrawupdate =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

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
                    delegate of event: Glutinum.Web.ToggleEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

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
                abstract member beforematch: EditorView.domEventObservers__.observers.beforematch option with get, set
                abstract member beforetoggle: EditorView.domEventObservers__.observers.beforetoggle option with get, set
                abstract member blur: EditorView.domEventObservers__.observers.blur option with get, set
                abstract member cancel: EditorView.domEventObservers__.observers.cancel option with get, set
                abstract member canplay: EditorView.domEventObservers__.observers.canplay option with get, set
                abstract member canplaythrough: EditorView.domEventObservers__.observers.canplaythrough option with get, set
                abstract member change: EditorView.domEventObservers__.observers.change option with get, set
                abstract member click: EditorView.domEventObservers__.observers.click option with get, set
                abstract member close: EditorView.domEventObservers__.observers.close option with get, set
                abstract member command: EditorView.domEventObservers__.observers.command option with get, set
                abstract member compositionend: EditorView.domEventObservers__.observers.compositionend option with get, set
                abstract member compositionstart: EditorView.domEventObservers__.observers.compositionstart option with get, set
                abstract member compositionupdate: EditorView.domEventObservers__.observers.compositionupdate option with get, set
                abstract member contextlost: EditorView.domEventObservers__.observers.contextlost option with get, set
                abstract member contextmenu: EditorView.domEventObservers__.observers.contextmenu option with get, set
                abstract member contextrestored: EditorView.domEventObservers__.observers.contextrestored option with get, set
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
                abstract member pointerrawupdate: EditorView.domEventObservers__.observers.pointerrawupdate option with get, set
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
                static member Create (?fullscreenchange: EditorView.domEventObservers__.observers.fullscreenchange, ?fullscreenerror: EditorView.domEventObservers__.observers.fullscreenerror, ?abort: EditorView.domEventObservers__.observers.abort, ?animationcancel: EditorView.domEventObservers__.observers.animationcancel, ?animationend: EditorView.domEventObservers__.observers.animationend, ?animationiteration: EditorView.domEventObservers__.observers.animationiteration, ?animationstart: EditorView.domEventObservers__.observers.animationstart, ?auxclick: EditorView.domEventObservers__.observers.auxclick, ?beforeinput: EditorView.domEventObservers__.observers.beforeinput, ?beforematch: EditorView.domEventObservers__.observers.beforematch, ?beforetoggle: EditorView.domEventObservers__.observers.beforetoggle, ?blur: EditorView.domEventObservers__.observers.blur, ?cancel: EditorView.domEventObservers__.observers.cancel, ?canplay: EditorView.domEventObservers__.observers.canplay, ?canplaythrough: EditorView.domEventObservers__.observers.canplaythrough, ?change: EditorView.domEventObservers__.observers.change, ?click: EditorView.domEventObservers__.observers.click, ?close: EditorView.domEventObservers__.observers.close, ?command: EditorView.domEventObservers__.observers.command, ?compositionend: EditorView.domEventObservers__.observers.compositionend, ?compositionstart: EditorView.domEventObservers__.observers.compositionstart, ?compositionupdate: EditorView.domEventObservers__.observers.compositionupdate, ?contextlost: EditorView.domEventObservers__.observers.contextlost, ?contextmenu: EditorView.domEventObservers__.observers.contextmenu, ?contextrestored: EditorView.domEventObservers__.observers.contextrestored, ?copy: EditorView.domEventObservers__.observers.copy, ?cuechange: EditorView.domEventObservers__.observers.cuechange, ?cut: EditorView.domEventObservers__.observers.cut, ?dblclick: EditorView.domEventObservers__.observers.dblclick, ?drag: EditorView.domEventObservers__.observers.drag, ?dragend: EditorView.domEventObservers__.observers.dragend, ?dragenter: EditorView.domEventObservers__.observers.dragenter, ?dragleave: EditorView.domEventObservers__.observers.dragleave, ?dragover: EditorView.domEventObservers__.observers.dragover, ?dragstart: EditorView.domEventObservers__.observers.dragstart, ?drop: EditorView.domEventObservers__.observers.drop, ?durationchange: EditorView.domEventObservers__.observers.durationchange, ?emptied: EditorView.domEventObservers__.observers.emptied, ?ended: EditorView.domEventObservers__.observers.ended, ?error: EditorView.domEventObservers__.observers.error, ?focus: EditorView.domEventObservers__.observers.focus, ?focusin: EditorView.domEventObservers__.observers.focusin, ?focusout: EditorView.domEventObservers__.observers.focusout, ?formdata: EditorView.domEventObservers__.observers.formdata, ?gotpointercapture: EditorView.domEventObservers__.observers.gotpointercapture, ?input: EditorView.domEventObservers__.observers.input, ?invalid: EditorView.domEventObservers__.observers.invalid, ?keydown: EditorView.domEventObservers__.observers.keydown, ?keypress: EditorView.domEventObservers__.observers.keypress, ?keyup: EditorView.domEventObservers__.observers.keyup, ?load: EditorView.domEventObservers__.observers.load, ?loadeddata: EditorView.domEventObservers__.observers.loadeddata, ?loadedmetadata: EditorView.domEventObservers__.observers.loadedmetadata, ?loadstart: EditorView.domEventObservers__.observers.loadstart, ?lostpointercapture: EditorView.domEventObservers__.observers.lostpointercapture, ?mousedown: EditorView.domEventObservers__.observers.mousedown, ?mouseenter: EditorView.domEventObservers__.observers.mouseenter, ?mouseleave: EditorView.domEventObservers__.observers.mouseleave, ?mousemove: EditorView.domEventObservers__.observers.mousemove, ?mouseout: EditorView.domEventObservers__.observers.mouseout, ?mouseover: EditorView.domEventObservers__.observers.mouseover, ?mouseup: EditorView.domEventObservers__.observers.mouseup, ?paste: EditorView.domEventObservers__.observers.paste, ?pause: EditorView.domEventObservers__.observers.pause, ?play: EditorView.domEventObservers__.observers.play, ?playing: EditorView.domEventObservers__.observers.playing, ?pointercancel: EditorView.domEventObservers__.observers.pointercancel, ?pointerdown: EditorView.domEventObservers__.observers.pointerdown, ?pointerenter: EditorView.domEventObservers__.observers.pointerenter, ?pointerleave: EditorView.domEventObservers__.observers.pointerleave, ?pointermove: EditorView.domEventObservers__.observers.pointermove, ?pointerout: EditorView.domEventObservers__.observers.pointerout, ?pointerover: EditorView.domEventObservers__.observers.pointerover, ?pointerrawupdate: EditorView.domEventObservers__.observers.pointerrawupdate, ?pointerup: EditorView.domEventObservers__.observers.pointerup, ?progress: EditorView.domEventObservers__.observers.progress, ?ratechange: EditorView.domEventObservers__.observers.ratechange, ?reset: EditorView.domEventObservers__.observers.reset, ?resize: EditorView.domEventObservers__.observers.resize, ?scroll: EditorView.domEventObservers__.observers.scroll, ?scrollend: EditorView.domEventObservers__.observers.scrollend, ?securitypolicyviolation: EditorView.domEventObservers__.observers.securitypolicyviolation, ?seeked: EditorView.domEventObservers__.observers.seeked, ?seeking: EditorView.domEventObservers__.observers.seeking, ?select: EditorView.domEventObservers__.observers.select, ?selectionchange: EditorView.domEventObservers__.observers.selectionchange, ?selectstart: EditorView.domEventObservers__.observers.selectstart, ?slotchange: EditorView.domEventObservers__.observers.slotchange, ?stalled: EditorView.domEventObservers__.observers.stalled, ?submit: EditorView.domEventObservers__.observers.submit, ?suspend: EditorView.domEventObservers__.observers.suspend, ?timeupdate: EditorView.domEventObservers__.observers.timeupdate, ?toggle: EditorView.domEventObservers__.observers.toggle, ?touchcancel: EditorView.domEventObservers__.observers.touchcancel, ?touchend: EditorView.domEventObservers__.observers.touchend, ?touchmove: EditorView.domEventObservers__.observers.touchmove, ?touchstart: EditorView.domEventObservers__.observers.touchstart, ?transitioncancel: EditorView.domEventObservers__.observers.transitioncancel, ?transitionend: EditorView.domEventObservers__.observers.transitionend, ?transitionrun: EditorView.domEventObservers__.observers.transitionrun, ?transitionstart: EditorView.domEventObservers__.observers.transitionstart, ?volumechange: EditorView.domEventObservers__.observers.volumechange, ?waiting: EditorView.domEventObservers__.observers.waiting, ?webkitanimationend: EditorView.domEventObservers__.observers.webkitanimationend, ?webkitanimationiteration: EditorView.domEventObservers__.observers.webkitanimationiteration, ?webkitanimationstart: EditorView.domEventObservers__.observers.webkitanimationstart, ?webkittransitionend: EditorView.domEventObservers__.observers.webkittransitionend, ?wheel: EditorView.domEventObservers__.observers.wheel) : observers = nativeOnly

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
                    delegate of event: Glutinum.Web.PointerEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type beforeinput =
                    delegate of event: Glutinum.Web.InputEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type beforematch =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type beforetoggle =
                    delegate of event: Glutinum.Web.ToggleEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

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
                    delegate of event: Glutinum.Web.PointerEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type close =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type command =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type compositionend =
                    delegate of event: Glutinum.Web.CompositionEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type compositionstart =
                    delegate of event: Glutinum.Web.CompositionEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type compositionupdate =
                    delegate of event: Glutinum.Web.CompositionEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type contextlost =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

                type contextmenu =
                    delegate of event: Glutinum.Web.PointerEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

                type contextrestored =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

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
                    delegate of event: Glutinum.Web.InputEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

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

                type pointerrawupdate =
                    delegate of event: Glutinum.Web.Event * view: CodemirrorView.EditorView -> U2<bool, unit>

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
                    delegate of event: Glutinum.Web.ToggleEvent * view: CodemirrorView.EditorView -> U2<bool, unit>

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

        module inputHandler__ =

            type Item =
                delegate of view: CodemirrorView.EditorView * from: float * ``to``: float * text: string * insert: (unit -> Glutinum.CodemirrorState.Transaction) -> bool

        module clipboardInputFilter__ =

            type Item =
                delegate of text: string * state: Glutinum.CodemirrorState.EditorState -> string

        module clipboardOutputFilter__ =

            type Item =
                delegate of text: string * state: Glutinum.CodemirrorState.EditorState -> string

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

            type Item =
                delegate of view: CodemirrorView.EditorView * range: Glutinum.CodemirrorState.SelectionRange * options: EditorView.scrollHandler__.Item.options -> bool

            module Item =

                [<AllowNullLiteral>]
                [<Interface>]
                type options =
                    abstract member x: CodemirrorView.ScrollStrategy with get, set
                    abstract member y: CodemirrorView.ScrollStrategy with get, set
                    abstract member xMargin: float with get, set
                    abstract member yMargin: float with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (x: CodemirrorView.ScrollStrategy, y: CodemirrorView.ScrollStrategy, xMargin: float, yMargin: float) : options = nativeOnly

        module focusChangeEffect__ =

            type Item =
                delegate of state: Glutinum.CodemirrorState.EditorState * focusing: bool -> Glutinum.CodemirrorState.StateEffect<obj> option

        module cursorScrollMargin__ =

            module U2 =

                [<AllowNullLiteral>]
                [<Interface>]
                type Case2 =
                    abstract member x: float with get, set
                    abstract member y: float with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (x: float, y: float) : Case2 = nativeOnly

        module scrollMargins__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type Item =
                abstract member left: float option with get
                abstract member right: float option with get
                abstract member top: float option with get
                abstract member bottom: float option with get

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

    module LayerMarker =

        type update =
            delegate of dom: Glutinum.Web.HTMLElement * oldMarker: CodemirrorView.LayerMarker -> bool

    module LayerConfig =

        type mount =
            delegate of layer: Glutinum.Web.HTMLElement * view: CodemirrorView.EditorView -> unit

        type destroy =
            delegate of layer: Glutinum.Web.HTMLElement * view: CodemirrorView.EditorView -> unit

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
            delegate of lineNo: float * state: Glutinum.CodemirrorState.EditorState -> string

    module Exports =

        [<AllowNullLiteral>]
        [<Interface>]
        type showDialog__ =
            abstract member close: Glutinum.CodemirrorState.StateEffect<obj> with get, set
            abstract member result: JS.Promise<Glutinum.Web.HTMLFormElement option> with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (close: Glutinum.CodemirrorState.StateEffect<obj>, result: JS.Promise<Glutinum.Web.HTMLFormElement option>) : showDialog__ = nativeOnly

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
                    delegate of tr: Glutinum.CodemirrorState.Transaction * tooltip: CodemirrorView.Tooltip -> bool

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type hideOnChange =
                    | [<CompiledValue(true)>] True
                    | [<CompiledValue(false)>] False
                    | touch

        module activateHover__ =

            [<RequireQualifiedAccess>]
            type side =
                | _MINUS_1 = -1
                | ``1`` = 1

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                abstract member tooltip: Glutinum.CodemirrorState.Extension option with get, set
                abstract member until: (Glutinum.CodemirrorState.Transaction -> bool) option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?tooltip: Glutinum.CodemirrorState.Extension, ?until: (Glutinum.CodemirrorState.Transaction -> bool)) : options = nativeOnly

        module gutterWidgetClass__ =

            type Type =
                delegate of view: CodemirrorView.EditorView * widget: CodemirrorView.WidgetType * block: CodemirrorView.BlockInfo -> CodemirrorView.GutterMarker option

            module Type =

                type Item =
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

            module Type =

                type Item =
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

module LezerLr =

    [<AbstractClass>]
    [<Erase>]
    type Exports =
        [<Import("Stack", "@lezer/lr"); EmitConstructor>]
        static member Stack () : Stack = nativeOnly
        [<Import("InputStream", "@lezer/lr"); EmitConstructor>]
        static member InputStream () : InputStream = nativeOnly
        [<Import("LocalTokenGroup", "@lezer/lr"); EmitConstructor>]
        static member LocalTokenGroup (data: JS.Uint16Array, precTable: float, ?elseToken: float) : LocalTokenGroup = nativeOnly
        [<Import("LocalTokenGroup", "@lezer/lr"); EmitConstructor>]
        static member LocalTokenGroup (data: string, precTable: float, ?elseToken: float) : LocalTokenGroup = nativeOnly
        /// <summary>
        /// Create a tokenizer. The first argument is the function that,
        /// given an input stream, scans for the types of tokens it
        /// recognizes at the stream's position, and calls
        /// [<c>acceptToken</c>](#lr.InputStream.acceptToken) when it finds
        /// one.
        /// </summary>
        [<Import("ExternalTokenizer", "@lezer/lr"); EmitConstructor>]
        static member ExternalTokenizer (token: Exports.ExternalTokenizer.token, ?options: LezerLr.ExternalOptions) : ExternalTokenizer = nativeOnly
        /// <summary>
        /// Define a context tracker.
        /// </summary>
        [<Import("ContextTracker", "@lezer/lr"); EmitConstructor>]
        static member ContextTracker<'T> (spec: Exports.ContextTracker.spec<'T>) : ContextTracker<'T> = nativeOnly
        [<Import("LRParser", "@lezer/lr"); EmitConstructor>]
        static member LRParser () : LRParser = nativeOnly

    /// <summary>
    /// A parse stack. These are used internally by the parser to track
    /// parsing progress. They also provide some properties and methods
    /// that external code such as a tokenizer can use to get information
    /// about the parse state.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("Stack", "@lezer/lr")>]
    type Stack =
        /// <summary>
        /// The input position up to which this stack has parsed.
        /// </summary>
        abstract member pos: float with get, set
        /// <summary>
        /// The stack's current [context](#lr.ContextTracker) value, if
        /// any. Its type will depend on the context tracker's type
        /// parameter, or it will be <c>null</c> if there is no context
        /// tracker.
        /// </summary>
        abstract member context: obj with get
        /// <summary>
        /// Check if the given term would be able to be shifted (optionally
        /// after some reductions) on this stack. This can be useful for
        /// external tokenizers that want to make sure they only provide a
        /// given token when it applies.
        /// </summary>
        abstract member canShift: term: float -> bool
        /// <summary>
        /// Get the parser used by this stack.
        /// </summary>
        abstract member parser: LezerLr.LRParser with get
        /// <summary>
        /// Test whether a given dialect (by numeric ID, as exported from
        /// the terms file) is enabled.
        /// </summary>
        abstract member dialectEnabled: dialectID: float -> bool

    /// <summary>
    /// [Tokenizers](#lr.ExternalTokenizer) interact with the input
    /// through this interface. It presents the input as a stream of
    /// characters, tracking lookahead and hiding the complexity of
    /// [ranges](#common.Parser.parse^ranges) from tokenizer code.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("InputStream", "@lezer/lr")>]
    type InputStream =
        /// <summary>
        /// The character code of the next code unit in the input, or -1
        /// when the stream is at the end of the input.
        /// </summary>
        abstract member next: float with get, set
        /// <summary>
        /// The current position of the stream. Note that, due to parses
        /// being able to cover non-contiguous
        /// [ranges](#common.Parser.startParse), advancing the stream does
        /// not always mean its position moves a single unit.
        /// </summary>
        abstract member pos: float with get, set
        /// <summary>
        /// Look at a code unit near the stream position. <c>.peek(0)</c> equals
        /// <c>.next</c>, <c>.peek(-1)</c> gives you the previous character, and so
        /// on.
        ///
        /// Note that looking around during tokenizing creates dependencies
        /// on potentially far-away content, which may reduce the
        /// effectiveness incremental parsing—when looking forward—or even
        /// cause invalid reparses when looking backward more than 25 code
        /// units, since the library does not track lookbehind.
        /// </summary>
        abstract member peek: offset: float -> float
        /// <summary>
        /// Accept a token. By default, the end of the token is set to the
        /// current stream position, but you can pass an offset (relative to
        /// the stream position) to change that.
        /// </summary>
        abstract member acceptToken: token: float * ?endOffset: float -> unit
        /// <summary>
        /// Accept a token ending at a specific given position.
        /// </summary>
        abstract member acceptTokenTo: token: float * endPos: float -> unit
        /// <summary>
        /// Move the stream forward N (defaults to 1) code units. Returns
        /// the new value of [<c>next</c>](#lr.InputStream.next).
        /// </summary>
        abstract member advance: ?n: float -> float

    [<AllowNullLiteral>]
    [<Interface>]
    type Tokenizer =
        interface end

    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("LocalTokenGroup", "@lezer/lr")>]
    type LocalTokenGroup =
        inherit LezerLr.Tokenizer
        abstract member precTable: float with get
        abstract member elseToken: float option with get
        abstract member contextual: bool with get, set
        abstract member fallback: bool with get, set
        abstract member extend: bool with get, set
        abstract member data: JS.Uint16Array with get
        abstract member token: input: LezerLr.InputStream * stack: LezerLr.Stack -> unit

    [<AllowNullLiteral>]
    [<Interface>]
    type ExternalOptions =
        /// <summary>
        /// When set to true, mark this tokenizer as depending on the
        /// current parse stack, which prevents its result from being cached
        /// between parser actions at the same positions.
        /// </summary>
        abstract member contextual: bool option with get, set
        /// <summary>
        /// By defaults, when a tokenizer returns a token, that prevents
        /// tokenizers with lower precedence from even running. When
        /// <c>fallback</c> is true, the tokenizer is allowed to run when a
        /// previous tokenizer returned a token that didn't match any of the
        /// current state's actions.
        /// </summary>
        abstract member fallback: bool option with get, set
        /// <summary>
        /// When set to true, tokenizing will not stop after this tokenizer
        /// has produced a token. (But it will still fail to reach this one
        /// if a higher-precedence tokenizer produced a token.)
        /// </summary>
        abstract member extend: bool option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?contextual: bool, ?fallback: bool, ?extend: bool) : ExternalOptions = nativeOnly

    /// <summary>
    /// <c>@external tokens</c> declarations in the grammar should resolve to
    /// an instance of this class.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("ExternalTokenizer", "@lezer/lr")>]
    type ExternalTokenizer =
        interface end

    /// <summary>
    /// Context trackers are used to track stateful context (such as
    /// indentation in the Python grammar, or parent elements in the XML
    /// grammar) needed by external tokenizers. You declare them in a
    /// grammar file as <c>@context exportName from "module"</c>.
    ///
    /// Context values should be immutable, and can be updated (replaced)
    /// on shift or reduce actions.
    ///
    /// The export used in a <c>@context</c> declaration should be of this
    /// type.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("ContextTracker", "@lezer/lr")>]
    type ContextTracker<'T> =
        interface end

    /// <summary>
    /// Configuration options when
    /// [reconfiguring](#lr.LRParser.configure) a parser.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type ParserConfig =
        /// <summary>
        /// Node prop values to add to the parser's node set.
        /// </summary>
        abstract member props: ReadonlyArray<Glutinum.LezerCommon.NodePropSource> option with get, set
        /// <summary>
        /// The name of the <c>@top</c> declaration to parse from. If not
        /// specified, the first top rule declaration in the grammar is
        /// used.
        /// </summary>
        abstract member top: string option with get, set
        /// <summary>
        /// A space-separated string of dialects to enable.
        /// </summary>
        abstract member dialect: string option with get, set
        /// <summary>
        /// Replace the given external tokenizers with new ones.
        /// </summary>
        abstract member tokenizers: ResizeArray<ParserConfig.tokenizers.Item> option with get, set
        /// <summary>
        /// Replace external specializers with new ones.
        /// </summary>
        abstract member specializers: ResizeArray<ParserConfig.specializers.Item> option with get, set
        /// <summary>
        /// Replace the context tracker with a new one.
        /// </summary>
        abstract member contextTracker: LezerLr.ContextTracker<obj> option with get, set
        /// <summary>
        /// When true, the parser will raise an exception, rather than run
        /// its error-recovery strategies, when the input doesn't match the
        /// grammar.
        /// </summary>
        abstract member strict: bool option with get, set
        /// <summary>
        /// Add a wrapper, which can extend parses created by this parser
        /// with additional logic (usually used to add
        /// [mixed-language](#common.parseMixed) parsing).
        /// </summary>
        abstract member wrap: Glutinum.LezerCommon.ParseWrapper option with get, set
        /// <summary>
        /// The maximum length of the TreeBuffers generated in the output
        /// tree. Defaults to 1024.
        /// </summary>
        abstract member bufferLength: float option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?props: ResizeArray<Glutinum.LezerCommon.NodePropSource>, ?top: string, ?dialect: string, ?tokenizers: ResizeArray<ParserConfig.tokenizers.Item>, ?specializers: ResizeArray<ParserConfig.specializers.Item>, ?contextTracker: LezerLr.ContextTracker<obj>, ?strict: bool, ?wrap: Glutinum.LezerCommon.ParseWrapper, ?bufferLength: float) : ParserConfig = nativeOnly

    /// <summary>
    /// Holds the parse tables for a given grammar, as generated by
    /// <c>lezer-generator</c>, and provides [methods](#common.Parser) to parse
    /// content with.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("LRParser", "@lezer/lr")>]
    type LRParser =
        inherit Glutinum.LezerCommon.Parser
        /// <summary>
        /// The nodes used in the trees emitted by this parser.
        /// </summary>
        abstract member nodeSet: Glutinum.LezerCommon.NodeSet with get
        /// <summary>
        /// Start a parse for a single tree. This is the method concrete
        /// parser implementations must implement. Called by <c>startParse</c>,
        /// with the optional arguments resolved.
        /// </summary>
        abstract member createParse: input: Glutinum.LezerCommon.Input * fragments: ResizeArray<Glutinum.LezerCommon.TreeFragment> * ranges: ResizeArray<LRParser.createParse.ranges.Item> -> Glutinum.LezerCommon.PartialParse
        /// <summary>
        /// Configure the parser. Returns a new parser instance that has the
        /// given settings modified. Settings not provided in <c>config</c> are
        /// kept from the original parser.
        /// </summary>
        abstract member configure: config: LezerLr.ParserConfig -> LezerLr.LRParser
        /// <summary>
        /// Tells you whether any [parse wrappers](#lr.ParserConfig.wrap)
        /// are registered for this parser.
        /// </summary>
        abstract member hasWrappers: unit -> bool
        /// <summary>
        /// Returns the name associated with a given term. This will only
        /// work for all terms when the parser was generated with the
        /// <c>--names</c> option. By default, only the names of tagged terms are
        /// stored.
        /// </summary>
        abstract member getName: term: float -> string
        /// <summary>
        /// The type of top node produced by the parser.
        /// </summary>
        abstract member topNode: Glutinum.LezerCommon.NodeType with get
        /// <summary>
        /// Used by the output of the parser generator. Not available to
        /// user code.
        /// </summary>
        [<Emit("""import { LRParser } from "@lezer/lr";
LRParser.deserialize($0)""")>]
        static member inline deserialize (spec: obj): LezerLr.LRParser = nativeOnly

    module ParserConfig =

        module tokenizers =

            [<AllowNullLiteral>]
            [<Interface>]
            type Item =
                abstract member from: LezerLr.ExternalTokenizer with get, set
                abstract member ``to``: LezerLr.ExternalTokenizer with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (from: LezerLr.ExternalTokenizer, ``to``: LezerLr.ExternalTokenizer) : Item = nativeOnly

        module specializers =

            [<AllowNullLiteral>]
            [<Interface>]
            type Item =
                abstract member from: ParserConfig.specializers.Item.from with get, set
                abstract member ``to``: ParserConfig.specializers.Item.``to`` with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (from: ParserConfig.specializers.Item.from, ``to``: ParserConfig.specializers.Item.``to``) : Item = nativeOnly

            module Item =

                type from =
                    delegate of value: string * stack: LezerLr.Stack -> float

                type ``to`` =
                    delegate of value: string * stack: LezerLr.Stack -> float

    module LRParser =

        module createParse =

            module ranges =

                [<AllowNullLiteral>]
                [<Interface>]
                type Item =
                    abstract member from: float with get, set
                    abstract member ``to``: float with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (from: float, ``to``: float) : Item = nativeOnly

    module Exports =

        module ExternalTokenizer =

            type token =
                delegate of input: LezerLr.InputStream * stack: LezerLr.Stack -> unit

        module ContextTracker =

            [<AllowNullLiteral>]
            [<Interface>]
            type spec<'T> =
                /// <summary>
                /// The initial value of the context at the start of the parse.
                /// </summary>
                abstract member start: 'T with get, set
                /// <summary>
                /// Update the context when the parser executes a
                /// [shift](https://en.wikipedia.org/wiki/LR_parser#Shift_and_reduce_actions)
                /// action.
                /// </summary>
                abstract member shift: Exports.ContextTracker.spec.shift option with get, set
                /// <summary>
                /// Update the context when the parser executes a reduce action.
                /// </summary>
                abstract member reduce: Exports.ContextTracker.spec.reduce option with get, set
                /// <summary>
                /// Update the context when the parser reuses a node from a tree
                /// fragment.
                /// </summary>
                abstract member reuse: Exports.ContextTracker.spec.reuse option with get, set
                /// <summary>
                /// Reduce a context value to a number (for cheap storage and
                /// comparison). Only needed for strict contexts.
                /// </summary>
                abstract member hash: ('T -> float) option with get, set
                /// <summary>
                /// By default, nodes can only be reused during incremental
                /// parsing if they were created in the same context as the one in
                /// which they are reused. Set this to false to disable that
                /// check (and the overhead of storing the hashes).
                /// </summary>
                abstract member strict: bool option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (start: 'T, ?shift: Exports.ContextTracker.spec.shift, ?reduce: Exports.ContextTracker.spec.reduce, ?reuse: Exports.ContextTracker.spec.reuse, ?hash: ('T -> float), ?strict: bool) : spec<'T> = nativeOnly

            module spec =

                type shift =
                    delegate of context: obj * term: float * stack: LezerLr.Stack * input: LezerLr.InputStream -> obj

                type reduce =
                    delegate of context: obj * term: float * stack: LezerLr.Stack * input: LezerLr.InputStream -> obj

                type reuse =
                    delegate of context: obj * node: Glutinum.LezerCommon.Tree * stack: LezerLr.Stack * input: LezerLr.InputStream -> obj

module StyleMod =

    [<AbstractClass>]
    [<Erase>]
    type Exports =
        [<Import("StyleModule", "style-mod"); EmitConstructor>]
        static member StyleModule (spec: Exports.StyleModule.spec, ?options: Exports.StyleModule.options) : StyleModule = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("StyleModule", "style-mod")>]
    type StyleModule =
        abstract member getRules: unit -> string
        [<Emit("""import { StyleModule } from "style-mod";
StyleModule.mount($0, $1, $2)""")>]
        static member inline mount (root: Glutinum.Web.Document, ``module``: StyleMod.StyleModule, ?options: StyleModule.mount__.options): unit = nativeOnly
        [<Emit("""import { StyleModule } from "style-mod";
StyleModule.mount($0, $1, $2)""")>]
        static member inline mount (root: Glutinum.Web.Document, ``module``: ResizeArray<StyleMod.StyleModule>, ?options: StyleModule.mount__.options): unit = nativeOnly
        [<Emit("""import { StyleModule } from "style-mod";
StyleModule.mount($0, $1, $2)""")>]
        static member inline mount (root: Glutinum.Web.ShadowRoot, ``module``: StyleMod.StyleModule, ?options: StyleModule.mount__.options): unit = nativeOnly
        [<Emit("""import { StyleModule } from "style-mod";
StyleModule.mount($0, $1, $2)""")>]
        static member inline mount (root: Glutinum.Web.ShadowRoot, ``module``: ResizeArray<StyleMod.StyleModule>, ?options: StyleModule.mount__.options): unit = nativeOnly
        [<Emit("""import { StyleModule } from "style-mod";
StyleModule.mount($0, $1, $2)""")>]
        static member inline mount (root: Glutinum.Web.DocumentOrShadowRoot, ``module``: StyleMod.StyleModule, ?options: StyleModule.mount__.options): unit = nativeOnly
        [<Emit("""import { StyleModule } from "style-mod";
StyleModule.mount($0, $1, $2)""")>]
        static member inline mount (root: Glutinum.Web.DocumentOrShadowRoot, ``module``: ResizeArray<StyleMod.StyleModule>, ?options: StyleModule.mount__.options): unit = nativeOnly
        [<Emit("""import { StyleModule } from "style-mod";
StyleModule.newName()""")>]
        static member inline newName () : string = nativeOnly

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
                abstract member finish: (string -> string) option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?finish: (string -> string)) : options = nativeOnly
