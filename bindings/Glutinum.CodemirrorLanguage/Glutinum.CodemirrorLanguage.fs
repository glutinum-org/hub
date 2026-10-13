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

// You need to add Glutinum.LezerHighlight NuGet package to your project

// You need to add Glutinum.StyleMod NuGet package to your project

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
        static member forceParsing (view: Glutinum.CodemirrorView.EditorView, ?upto: float, ?timeout: float) : bool = nativeOnly
        /// <summary>
        /// Tells you whether the language parser is planning to do more
        /// parsing work (in a <c>requestIdleCallback</c> pseudo-thread) or has
        /// stopped running, either because it parsed the entire document,
        /// because it spent too much time and was cut off, or because there
        /// is no language parser enabled.
        /// </summary>
        [<Import("syntaxParserRunning", "@codemirror/language")>]
        static member syntaxParserRunning (view: Glutinum.CodemirrorView.EditorView) : bool = nativeOnly
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
        static member inline foldState: Glutinum.CodemirrorState.StateField<Glutinum.CodemirrorView.DecorationSet> = nativeOnly
        /// <summary>
        /// Get a [range set](https://codemirror.net/6/docs/ref/#state.RangeSet) containing the folded ranges
        /// in the given state.
        /// </summary>
        [<Import("foldedRanges", "@codemirror/language")>]
        static member foldedRanges (state: Glutinum.CodemirrorState.EditorState) : Glutinum.CodemirrorView.DecorationSet = nativeOnly
        /// <summary>
        /// Fold the lines that are selected, if possible.
        /// </summary>
        [<Import("foldCode", "@codemirror/language")>]
        static member inline foldCode: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Unfold folded ranges on selected lines.
        /// </summary>
        [<Import("unfoldCode", "@codemirror/language")>]
        static member inline unfoldCode: Glutinum.CodemirrorView.Command = nativeOnly
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
        static member inline foldAll: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Unfold all folded code.
        /// </summary>
        [<Import("unfoldAll", "@codemirror/language")>]
        static member inline unfoldAll: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Toggle folding at cursors. Unfolds if there is an existing fold
        /// starting in that line, tries to find a foldable range around it
        /// otherwise.
        /// </summary>
        [<Import("toggleFold", "@codemirror/language")>]
        static member inline toggleFold: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Default fold-related key bindings.
        ///
        /// - Ctrl-Shift-[ (Cmd-Alt-[ on macOS): [<c>foldCode</c>](https://codemirror.net/6/docs/ref/#language.foldCode).
        /// - Ctrl-Shift-] (Cmd-Alt-] on macOS): [<c>unfoldCode</c>](https://codemirror.net/6/docs/ref/#language.unfoldCode).
        /// - Ctrl-Alt-[: [<c>foldAll</c>](https://codemirror.net/6/docs/ref/#language.foldAll).
        /// - Ctrl-Alt-]: [<c>unfoldAll</c>](https://codemirror.net/6/docs/ref/#language.unfoldAll).
        /// </summary>
        [<Import("foldKeymap", "@codemirror/language")>]
        static member inline foldKeymap: ReadonlyArray<Glutinum.CodemirrorView.KeyBinding> = nativeOnly
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
        abstract member foldingChanged: (Glutinum.CodemirrorView.ViewUpdate -> bool) option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?markerDOM: (bool -> Glutinum.Web.HTMLElement), ?openText: string, ?closedText: string, ?domEventHandlers: CodemirrorLanguage.Handlers, ?foldingChanged: (Glutinum.CodemirrorView.ViewUpdate -> bool)) : FoldGutterConfig = nativeOnly

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
        abstract member ``module``: Glutinum.StyleMod.StyleModule option with get
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
            delegate of view: Glutinum.CodemirrorView.EditorView * onclick: (Glutinum.Web.Event -> unit) * prepared: obj -> Glutinum.Web.HTMLElement

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
            delegate of view: Glutinum.CodemirrorView.EditorView * line: Glutinum.CodemirrorView.BlockInfo * event: Glutinum.Web.Event -> bool

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
                abstract member all: U2<string, Glutinum.StyleMod.StyleSpec> option with get, set
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
                static member Create (all: Glutinum.StyleMod.StyleSpec, ?themeType: HighlightStyle.define__.options.themeType) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (scope: CodemirrorLanguage.Language, ?themeType: HighlightStyle.define__.options.themeType) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (scope: CodemirrorLanguage.Language, all: string, ?themeType: HighlightStyle.define__.options.themeType) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (scope: CodemirrorLanguage.Language, all: Glutinum.StyleMod.StyleSpec, ?themeType: HighlightStyle.define__.options.themeType) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (scope: Glutinum.LezerCommon.NodeType, ?themeType: HighlightStyle.define__.options.themeType) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (scope: Glutinum.LezerCommon.NodeType, all: string, ?themeType: HighlightStyle.define__.options.themeType) : options = nativeOnly
                [<ParamObject; Emit("$0")>]
                static member Create (scope: Glutinum.LezerCommon.NodeType, all: Glutinum.StyleMod.StyleSpec, ?themeType: HighlightStyle.define__.options.themeType) : options = nativeOnly

            module options =

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type themeType =
                    | dark
                    | light

    module Config =

        type renderMatch =
            delegate of ``match``: CodemirrorLanguage.MatchResult * state: Glutinum.CodemirrorState.EditorState -> ResizeArray<Glutinum.CodemirrorState.Range<Glutinum.CodemirrorView.Decoration>>

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
