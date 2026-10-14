namespace rec Glutinum

open Fable.Core
open Fable.Core.JsInterop
open System

// You need to add Glutinum.Types NuGet package to your project
open Glutinum.Types.TypeScript

// You need to add Glutinum.Web NuGet package to your project

// You need to add Glutinum.CodemirrorState NuGet package to your project

// You need to add Glutinum.CodemirrorView NuGet package to your project

module CodemirrorLint =

    [<AbstractClass>]
    [<Erase>]
    type Exports =
        /// <summary>
        /// Returns a transaction spec which updates the current set of
        /// diagnostics, and enables the lint extension if if wasn't already
        /// active.
        /// </summary>
        [<Import("setDiagnostics", "@codemirror/lint")>]
        static member setDiagnostics (state: Glutinum.CodemirrorState.EditorState, diagnostics: ResizeArray<CodemirrorLint.Diagnostic>) : Glutinum.CodemirrorState.TransactionSpec = nativeOnly
        /// <summary>
        /// The state effect that updates the set of active diagnostics. Can
        /// be useful when writing an extension that needs to track these.
        /// </summary>
        [<Import("setDiagnosticsEffect", "@codemirror/lint")>]
        static member inline setDiagnosticsEffect: Glutinum.CodemirrorState.StateEffectType<ReadonlyArray<CodemirrorLint.Diagnostic>> = nativeOnly
        /// <summary>
        /// Returns the number of active lint diagnostics in the given state.
        /// </summary>
        [<Import("diagnosticCount", "@codemirror/lint")>]
        static member diagnosticCount (state: Glutinum.CodemirrorState.EditorState) : float = nativeOnly
        /// <summary>
        /// Command to open and focus the lint panel.
        /// </summary>
        [<Import("openLintPanel", "@codemirror/lint")>]
        static member inline openLintPanel: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Command to close the lint panel, when open.
        /// </summary>
        [<Import("closeLintPanel", "@codemirror/lint")>]
        static member inline closeLintPanel: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Move the selection to the next diagnostic.
        /// </summary>
        [<Import("nextDiagnostic", "@codemirror/lint")>]
        static member inline nextDiagnostic: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Move the selection to the previous diagnostic.
        /// </summary>
        [<Import("previousDiagnostic", "@codemirror/lint")>]
        static member inline previousDiagnostic: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// A set of default key bindings for the lint functionality.
        ///
        /// - Ctrl-Shift-m (Cmd-Shift-m on macOS): [<c>openLintPanel</c>](https://codemirror.net/6/docs/ref/#lint.openLintPanel)
        /// - F8: [<c>nextDiagnostic</c>](https://codemirror.net/6/docs/ref/#lint.nextDiagnostic)
        /// </summary>
        [<Import("lintKeymap", "@codemirror/lint")>]
        static member inline lintKeymap: ReadonlyArray<Glutinum.CodemirrorView.KeyBinding> = nativeOnly
        /// <summary>
        /// Given a diagnostic source, this function returns an extension that
        /// enables linting with that source. It will be called whenever the
        /// editor is idle (after its content changed).
        ///
        /// Note that settings given here will apply to all linters active in
        /// the editor. If <c>null</c> is given as source, this only configures the
        /// lint extension.
        /// </summary>
        [<Import("linter", "@codemirror/lint")>]
        static member linter (source: CodemirrorLint.LintSource option, ?config: CodemirrorLint.LintConfig) : Glutinum.CodemirrorState.Extension = nativeOnly
        /// <summary>
        /// Forces any linters [configured](https://codemirror.net/6/docs/ref/#lint.linter) to run when the
        /// editor is idle to run right away.
        /// </summary>
        [<Import("forceLinting", "@codemirror/lint")>]
        static member forceLinting (view: Glutinum.CodemirrorView.EditorView) : unit = nativeOnly
        /// <summary>
        /// Returns an extension that installs a gutter showing markers for
        /// each line that has diagnostics, which can be hovered over to see
        /// the diagnostics.
        /// </summary>
        [<Import("lintGutter", "@codemirror/lint")>]
        static member lintGutter (?config: CodemirrorLint.LintGutterConfig) : Glutinum.CodemirrorState.Extension = nativeOnly
        /// <summary>
        /// Iterate over the marked diagnostics for the given editor state,
        /// calling <c>f</c> for each of them. Note that, if the document changed
        /// since the diagnostics were created, the <c>Diagnostic</c> object will
        /// hold the original outdated position, whereas the <c>to</c> and <c>from</c>
        /// arguments hold the diagnostic's current position.
        /// </summary>
        [<Import("forEachDiagnostic", "@codemirror/lint")>]
        static member forEachDiagnostic (state: Glutinum.CodemirrorState.EditorState, f: Exports.forEachDiagnostic__.f) : unit = nativeOnly

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type Severity =
        | hint
        | info
        | warning
        | error

    /// <summary>
    /// Describes a problem or hint for a piece of code.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type Diagnostic =
        /// <summary>
        /// The start position of the relevant text.
        /// </summary>
        abstract member from: float with get, set
        /// <summary>
        /// The end position. May be equal to <c>from</c>, though actually
        /// covering text is preferable.
        /// </summary>
        abstract member ``to``: float with get, set
        /// <summary>
        /// The severity of the problem. This will influence how it is
        /// displayed.
        /// </summary>
        abstract member severity: CodemirrorLint.Severity with get, set
        /// <summary>
        /// When given, add an extra CSS class to parts of the code that
        /// this diagnostic applies to.
        /// </summary>
        abstract member markClass: string option with get, set
        /// <summary>
        /// An optional source string indicating where the diagnostic is
        /// coming from. You can put the name of your linter here, if
        /// applicable.
        /// </summary>
        abstract member source: string option with get, set
        /// <summary>
        /// The message associated with this diagnostic.
        /// </summary>
        abstract member message: string with get, set
        /// <summary>
        /// An optional custom rendering function that displays the message
        /// as a DOM node.
        /// </summary>
        abstract member renderMessage: (Glutinum.CodemirrorView.EditorView -> Glutinum.Web.Node) option with get, set
        /// <summary>
        /// An optional array of actions that can be taken on this
        /// diagnostic.
        /// </summary>
        abstract member actions: ReadonlyArray<CodemirrorLint.Action> option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (from: float, ``to``: float, severity: CodemirrorLint.Severity, message: string, ?markClass: string, ?source: string, ?renderMessage: (Glutinum.CodemirrorView.EditorView -> Glutinum.Web.Node), ?actions: ResizeArray<CodemirrorLint.Action>) : Diagnostic = nativeOnly

    /// <summary>
    /// An action associated with a diagnostic.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type Action =
        /// <summary>
        /// The label to show to the user. Should be relatively short.
        /// </summary>
        abstract member name: string with get, set
        /// <summary>
        /// When given, add an extra CSS class to the action button.
        /// </summary>
        abstract member markClass: string option with get, set
        /// <summary>
        /// The function to call when the user activates this action. Is
        /// given the diagnostic's _current_ position, which may have
        /// changed since the creation of the diagnostic, due to editing.
        /// </summary>
        abstract member apply: Action.apply with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (name: string, apply: Action.apply, ?markClass: string) : Action = nativeOnly

    type DiagnosticFilter =
        delegate of diagnostics: ResizeArray<CodemirrorLint.Diagnostic> * state: Glutinum.CodemirrorState.EditorState -> ResizeArray<CodemirrorLint.Diagnostic>

    [<AllowNullLiteral>]
    [<Interface>]
    type LintConfig =
        /// <summary>
        /// Time to wait (in milliseconds) after a change before running
        /// the linter. Defaults to 750ms.
        /// </summary>
        abstract member delay: float option with get, set
        /// <summary>
        /// Optional predicate that can be used to indicate when diagnostics
        /// need to be recomputed. Linting is always re-done on document
        /// changes.
        /// </summary>
        abstract member needsRefresh: (Glutinum.CodemirrorView.ViewUpdate -> bool) option with get, set
        /// <summary>
        /// Optional filter to determine which diagnostics produce markers
        /// in the content.
        /// </summary>
        abstract member markerFilter: CodemirrorLint.DiagnosticFilter option with get, set
        /// <summary>
        /// Filter applied to a set of diagnostics shown in a tooltip. No
        /// tooltip will appear if the empty set is returned.
        /// </summary>
        abstract member tooltipFilter: CodemirrorLint.DiagnosticFilter option with get, set
        /// <summary>
        /// Can be used to control what kind of transactions cause lint
        /// hover tooltips associated with the given document range to be
        /// hidden. By default any transactions that changes the line
        /// around the range will hide it. Returning null falls back to this
        /// behavior.
        /// </summary>
        abstract member hideOn: LintConfig.hideOn option with get, set
        /// <summary>
        /// When enabled (defaults to off), this will cause the lint panel
        /// to automatically open when diagnostics are found, and close when
        /// all diagnostics are resolved or removed.
        /// </summary>
        abstract member autoPanel: bool option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?delay: float, ?needsRefresh: (Glutinum.CodemirrorView.ViewUpdate -> bool), ?markerFilter: CodemirrorLint.DiagnosticFilter, ?tooltipFilter: CodemirrorLint.DiagnosticFilter, ?hideOn: LintConfig.hideOn, ?autoPanel: bool) : LintConfig = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type LintGutterConfig =
        /// <summary>
        /// The delay before showing a tooltip when hovering over a lint gutter marker.
        /// </summary>
        abstract member hoverTime: float option with get, set
        /// <summary>
        /// Optional filter determining which diagnostics show a marker in
        /// the gutter.
        /// </summary>
        abstract member markerFilter: CodemirrorLint.DiagnosticFilter option with get, set
        /// <summary>
        /// Optional filter for diagnostics displayed in a tooltip, which
        /// can also be used to prevent a tooltip appearing.
        /// </summary>
        abstract member tooltipFilter: CodemirrorLint.DiagnosticFilter option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?hoverTime: float, ?markerFilter: CodemirrorLint.DiagnosticFilter, ?tooltipFilter: CodemirrorLint.DiagnosticFilter) : LintGutterConfig = nativeOnly

    /// <summary>
    /// The type of a function that produces diagnostics.
    /// </summary>
    type LintSource =
        Glutinum.CodemirrorView.EditorView -> U2<ResizeArray<CodemirrorLint.Diagnostic>, JS.Promise<ReadonlyArray<CodemirrorLint.Diagnostic>>>

    module Action =

        type apply =
            delegate of view: Glutinum.CodemirrorView.EditorView * from: float * ``to``: float -> unit

    module LintConfig =

        type hideOn =
            delegate of tr: Glutinum.CodemirrorState.Transaction * from: float * ``to``: float -> bool option

    module Exports =

        module forEachDiagnostic__ =

            type f =
                delegate of d: CodemirrorLint.Diagnostic * from: float * ``to``: float -> unit
