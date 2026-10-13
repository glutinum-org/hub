namespace rec Glutinum

open Fable.Core
open Fable.Core.JsInterop
open System

// You need to add Glutinum.Types NuGet package to your project
open Glutinum.Types.TypeScript

// You need to add Glutinum.CodemirrorState NuGet package to your project

// You need to add Glutinum.CodemirrorView NuGet package to your project

module CodemirrorCommands =

    [<AbstractClass>]
    [<Erase>]
    type Exports =
        /// <summary>
        /// Comment or uncomment the current selection. Will use line comments
        /// if available, otherwise falling back to block comments.
        /// </summary>
        [<Import("toggleComment", "@codemirror/commands")>]
        static member inline toggleComment: Glutinum.CodemirrorState.StateCommand = nativeOnly
        /// <summary>
        /// Comment or uncomment the current selection using line comments.
        /// The line comment syntax is taken from the
        /// [<c>commentTokens</c>](https://codemirror.net/6/docs/ref/#commands.CommentTokens) [language
        /// data](https://codemirror.net/6/docs/ref/#state.EditorState.languageDataAt).
        /// </summary>
        [<Import("toggleLineComment", "@codemirror/commands")>]
        static member inline toggleLineComment: Glutinum.CodemirrorState.StateCommand = nativeOnly
        /// <summary>
        /// Comment the current selection using line comments.
        /// </summary>
        [<Import("lineComment", "@codemirror/commands")>]
        static member inline lineComment: Glutinum.CodemirrorState.StateCommand = nativeOnly
        /// <summary>
        /// Uncomment the current selection using line comments.
        /// </summary>
        [<Import("lineUncomment", "@codemirror/commands")>]
        static member inline lineUncomment: Glutinum.CodemirrorState.StateCommand = nativeOnly
        /// <summary>
        /// Comment or uncomment the current selection using block comments.
        /// The block comment syntax is taken from the
        /// [<c>commentTokens</c>](https://codemirror.net/6/docs/ref/#commands.CommentTokens) [language
        /// data](https://codemirror.net/6/docs/ref/#state.EditorState.languageDataAt).
        /// </summary>
        [<Import("toggleBlockComment", "@codemirror/commands")>]
        static member inline toggleBlockComment: Glutinum.CodemirrorState.StateCommand = nativeOnly
        /// <summary>
        /// Comment the current selection using block comments.
        /// </summary>
        [<Import("blockComment", "@codemirror/commands")>]
        static member inline blockComment: Glutinum.CodemirrorState.StateCommand = nativeOnly
        /// <summary>
        /// Uncomment the current selection using block comments.
        /// </summary>
        [<Import("blockUncomment", "@codemirror/commands")>]
        static member inline blockUncomment: Glutinum.CodemirrorState.StateCommand = nativeOnly
        /// <summary>
        /// Comment or uncomment the lines around the current selection using
        /// block comments.
        /// </summary>
        [<Import("toggleBlockCommentByLine", "@codemirror/commands")>]
        static member inline toggleBlockCommentByLine: Glutinum.CodemirrorState.StateCommand = nativeOnly
        /// <summary>
        /// Transaction annotation that will prevent that transaction from
        /// being combined with other transactions in the undo history. Given
        /// <c>"before"</c>, it'll prevent merging with previous transactions. With
        /// <c>"after"</c>, subsequent transactions won't be combined with this
        /// one. With <c>"full"</c>, the transaction is isolated on both sides.
        /// </summary>
        [<Import("isolateHistory", "@codemirror/commands")>]
        static member inline isolateHistory: Glutinum.CodemirrorState.AnnotationType<Exports.isolateHistory__.Type> = nativeOnly
        /// <summary>
        /// This facet provides a way to register functions that, given a
        /// transaction, provide a set of effects that the history should
        /// store when inverting the transaction. This can be used to
        /// integrate some kinds of effects in the history, so that they can
        /// be undone (and redone again).
        /// </summary>
        [<Import("invertedEffects", "@codemirror/commands")>]
        static member inline invertedEffects: Glutinum.CodemirrorState.Facet<(Glutinum.CodemirrorState.Transaction -> ResizeArray<Glutinum.CodemirrorState.StateEffect<obj>>), ReadonlyArray<(Glutinum.CodemirrorState.Transaction -> ResizeArray<Glutinum.CodemirrorState.StateEffect<obj>>)>> = nativeOnly
        /// <summary>
        /// Create a history extension with the given configuration.
        /// </summary>
        [<Import("history", "@codemirror/commands")>]
        static member history (?config: CodemirrorCommands.HistoryConfig) : Glutinum.CodemirrorState.Extension = nativeOnly
        /// <summary>
        /// The state field used to store the history data. Should probably
        /// only be used when you want to
        /// [serialize](https://codemirror.net/6/docs/ref/#state.EditorState.toJSON) or
        /// [deserialize](https://codemirror.net/6/docs/ref/#state.EditorState^fromJSON) state objects in a way
        /// that preserves history.
        /// </summary>
        [<Import("historyField", "@codemirror/commands")>]
        static member inline historyField: Glutinum.CodemirrorState.StateField<obj> = nativeOnly
        /// <summary>
        /// Undo a single group of history events. Returns false if no group
        /// was available.
        /// </summary>
        [<Import("undo", "@codemirror/commands")>]
        static member inline undo: Glutinum.CodemirrorState.StateCommand = nativeOnly
        /// <summary>
        /// Redo a group of history events. Returns false if no group was
        /// available.
        /// </summary>
        [<Import("redo", "@codemirror/commands")>]
        static member inline redo: Glutinum.CodemirrorState.StateCommand = nativeOnly
        /// <summary>
        /// Undo a change or selection change.
        /// </summary>
        [<Import("undoSelection", "@codemirror/commands")>]
        static member inline undoSelection: Glutinum.CodemirrorState.StateCommand = nativeOnly
        /// <summary>
        /// Redo a change or selection change.
        /// </summary>
        [<Import("redoSelection", "@codemirror/commands")>]
        static member inline redoSelection: Glutinum.CodemirrorState.StateCommand = nativeOnly
        /// <summary>
        /// The amount of undoable change events available in a given state.
        /// </summary>
        [<Import("undoDepth", "@codemirror/commands")>]
        static member inline undoDepth: (Glutinum.CodemirrorState.EditorState -> float) = nativeOnly
        /// <summary>
        /// The amount of redoable change events available in a given state.
        /// </summary>
        [<Import("redoDepth", "@codemirror/commands")>]
        static member inline redoDepth: (Glutinum.CodemirrorState.EditorState -> float) = nativeOnly
        /// <summary>
        /// Test whether there is an undoable selection available.
        /// </summary>
        [<Import("canUndoSelection", "@codemirror/commands")>]
        static member inline canUndoSelection: (Glutinum.CodemirrorState.EditorState -> bool) = nativeOnly
        /// <summary>
        /// Test whether there is a redoable selection available.
        /// </summary>
        [<Import("canRedoSelection", "@codemirror/commands")>]
        static member inline canRedoSelection: (Glutinum.CodemirrorState.EditorState -> bool) = nativeOnly
        /// <summary>
        /// Default key bindings for the undo history.
        ///
        /// - Mod-z: [<c>undo</c>](https://codemirror.net/6/docs/ref/#commands.undo).
        /// - Mod-y (Mod-Shift-z on macOS) + Ctrl-Shift-z on Linux: [<c>redo</c>](https://codemirror.net/6/docs/ref/#commands.redo).
        /// - Mod-u: [<c>undoSelection</c>](https://codemirror.net/6/docs/ref/#commands.undoSelection).
        /// - Alt-u (Mod-Shift-u on macOS): [<c>redoSelection</c>](https://codemirror.net/6/docs/ref/#commands.redoSelection).
        /// </summary>
        [<Import("historyKeymap", "@codemirror/commands")>]
        static member inline historyKeymap: ReadonlyArray<Glutinum.CodemirrorView.KeyBinding> = nativeOnly
        /// <summary>
        /// Move the selection one character to the left (which is backward in
        /// left-to-right text, forward in right-to-left text).
        /// </summary>
        [<Import("cursorCharLeft", "@codemirror/commands")>]
        static member inline cursorCharLeft: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Move the selection one character to the right.
        /// </summary>
        [<Import("cursorCharRight", "@codemirror/commands")>]
        static member inline cursorCharRight: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Move the selection one character forward.
        /// </summary>
        [<Import("cursorCharForward", "@codemirror/commands")>]
        static member inline cursorCharForward: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Move the selection one character backward.
        /// </summary>
        [<Import("cursorCharBackward", "@codemirror/commands")>]
        static member inline cursorCharBackward: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Move the selection one character forward, in logical
        /// (non-text-direction-aware) string index order.
        /// </summary>
        [<Import("cursorCharForwardLogical", "@codemirror/commands")>]
        static member inline cursorCharForwardLogical: Glutinum.CodemirrorState.StateCommand = nativeOnly
        /// <summary>
        /// Move the selection one character backward, in logical string index
        /// order.
        /// </summary>
        [<Import("cursorCharBackwardLogical", "@codemirror/commands")>]
        static member inline cursorCharBackwardLogical: Glutinum.CodemirrorState.StateCommand = nativeOnly
        /// <summary>
        /// Move the selection to the left across one group of word or
        /// non-word (but also non-space) characters.
        /// </summary>
        [<Import("cursorGroupLeft", "@codemirror/commands")>]
        static member inline cursorGroupLeft: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Move the selection one group to the right.
        /// </summary>
        [<Import("cursorGroupRight", "@codemirror/commands")>]
        static member inline cursorGroupRight: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Move the selection one group forward.
        /// </summary>
        [<Import("cursorGroupForward", "@codemirror/commands")>]
        static member inline cursorGroupForward: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Move the selection one group backward.
        /// </summary>
        [<Import("cursorGroupBackward", "@codemirror/commands")>]
        static member inline cursorGroupBackward: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Move the cursor one group forward in the default Windows style,
        /// where it moves to the start of the next group.
        /// </summary>
        [<Import("cursorGroupForwardWin", "@codemirror/commands")>]
        static member inline cursorGroupForwardWin: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Move the selection one group or camel-case subword forward.
        /// </summary>
        [<Import("cursorSubwordForward", "@codemirror/commands")>]
        static member inline cursorSubwordForward: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Move the selection one group or camel-case subword backward.
        /// </summary>
        [<Import("cursorSubwordBackward", "@codemirror/commands")>]
        static member inline cursorSubwordBackward: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Move the cursor over the next syntactic element to the left.
        /// </summary>
        [<Import("cursorSyntaxLeft", "@codemirror/commands")>]
        static member inline cursorSyntaxLeft: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Move the cursor over the next syntactic element to the right.
        /// </summary>
        [<Import("cursorSyntaxRight", "@codemirror/commands")>]
        static member inline cursorSyntaxRight: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Move the selection one line up.
        /// </summary>
        [<Import("cursorLineUp", "@codemirror/commands")>]
        static member inline cursorLineUp: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Move the selection one line down.
        /// </summary>
        [<Import("cursorLineDown", "@codemirror/commands")>]
        static member inline cursorLineDown: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Move the selection one page up.
        /// </summary>
        [<Import("cursorPageUp", "@codemirror/commands")>]
        static member inline cursorPageUp: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Move the selection one page down.
        /// </summary>
        [<Import("cursorPageDown", "@codemirror/commands")>]
        static member inline cursorPageDown: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Move the selection to the next line wrap point, or to the end of
        /// the line if there isn't one left on this line.
        /// </summary>
        [<Import("cursorLineBoundaryForward", "@codemirror/commands")>]
        static member inline cursorLineBoundaryForward: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Move the selection to previous line wrap point, or failing that to
        /// the start of the line. If the line is indented, and the cursor
        /// isn't already at the end of the indentation, this will move to the
        /// end of the indentation instead of the start of the line.
        /// </summary>
        [<Import("cursorLineBoundaryBackward", "@codemirror/commands")>]
        static member inline cursorLineBoundaryBackward: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Move the selection one line wrap point to the left.
        /// </summary>
        [<Import("cursorLineBoundaryLeft", "@codemirror/commands")>]
        static member inline cursorLineBoundaryLeft: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Move the selection one line wrap point to the right.
        /// </summary>
        [<Import("cursorLineBoundaryRight", "@codemirror/commands")>]
        static member inline cursorLineBoundaryRight: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Move the selection to the start of the line.
        /// </summary>
        [<Import("cursorLineStart", "@codemirror/commands")>]
        static member inline cursorLineStart: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Move the selection to the end of the line.
        /// </summary>
        [<Import("cursorLineEnd", "@codemirror/commands")>]
        static member inline cursorLineEnd: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Move the selection to the bracket matching the one it is currently
        /// on, if any.
        /// </summary>
        [<Import("cursorMatchingBracket", "@codemirror/commands")>]
        static member inline cursorMatchingBracket: Glutinum.CodemirrorState.StateCommand = nativeOnly
        /// <summary>
        /// Extend the selection to the bracket matching the one the selection
        /// head is currently on, if any.
        /// </summary>
        [<Import("selectMatchingBracket", "@codemirror/commands")>]
        static member inline selectMatchingBracket: Glutinum.CodemirrorState.StateCommand = nativeOnly
        /// <summary>
        /// Move the selection head one character to the left, while leaving
        /// the anchor in place.
        /// </summary>
        [<Import("selectCharLeft", "@codemirror/commands")>]
        static member inline selectCharLeft: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Move the selection head one character to the right.
        /// </summary>
        [<Import("selectCharRight", "@codemirror/commands")>]
        static member inline selectCharRight: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Move the selection head one character forward.
        /// </summary>
        [<Import("selectCharForward", "@codemirror/commands")>]
        static member inline selectCharForward: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Move the selection head one character backward.
        /// </summary>
        [<Import("selectCharBackward", "@codemirror/commands")>]
        static member inline selectCharBackward: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Move the selection head one character forward by logical
        /// (non-direction aware) string index order.
        /// </summary>
        [<Import("selectCharForwardLogical", "@codemirror/commands")>]
        static member inline selectCharForwardLogical: Glutinum.CodemirrorState.StateCommand = nativeOnly
        /// <summary>
        /// Move the selection head one character backward by logical string
        /// index order.
        /// </summary>
        [<Import("selectCharBackwardLogical", "@codemirror/commands")>]
        static member inline selectCharBackwardLogical: Glutinum.CodemirrorState.StateCommand = nativeOnly
        /// <summary>
        /// Move the selection head one [group](https://codemirror.net/6/docs/ref/#commands.cursorGroupLeft) to
        /// the left.
        /// </summary>
        [<Import("selectGroupLeft", "@codemirror/commands")>]
        static member inline selectGroupLeft: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Move the selection head one group to the right.
        /// </summary>
        [<Import("selectGroupRight", "@codemirror/commands")>]
        static member inline selectGroupRight: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Move the selection head one group forward.
        /// </summary>
        [<Import("selectGroupForward", "@codemirror/commands")>]
        static member inline selectGroupForward: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Move the selection head one group backward.
        /// </summary>
        [<Import("selectGroupBackward", "@codemirror/commands")>]
        static member inline selectGroupBackward: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Move the selection head one group forward in the default Windows
        /// style, skipping to the start of the next group.
        /// </summary>
        [<Import("selectGroupForwardWin", "@codemirror/commands")>]
        static member inline selectGroupForwardWin: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Move the selection head one group or camel-case subword forward.
        /// </summary>
        [<Import("selectSubwordForward", "@codemirror/commands")>]
        static member inline selectSubwordForward: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Move the selection head one group or subword backward.
        /// </summary>
        [<Import("selectSubwordBackward", "@codemirror/commands")>]
        static member inline selectSubwordBackward: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Move the selection head over the next syntactic element to the left.
        /// </summary>
        [<Import("selectSyntaxLeft", "@codemirror/commands")>]
        static member inline selectSyntaxLeft: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Move the selection head over the next syntactic element to the right.
        /// </summary>
        [<Import("selectSyntaxRight", "@codemirror/commands")>]
        static member inline selectSyntaxRight: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Move the selection head one line up.
        /// </summary>
        [<Import("selectLineUp", "@codemirror/commands")>]
        static member inline selectLineUp: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Move the selection head one line down.
        /// </summary>
        [<Import("selectLineDown", "@codemirror/commands")>]
        static member inline selectLineDown: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Move the selection head one page up.
        /// </summary>
        [<Import("selectPageUp", "@codemirror/commands")>]
        static member inline selectPageUp: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Move the selection head one page down.
        /// </summary>
        [<Import("selectPageDown", "@codemirror/commands")>]
        static member inline selectPageDown: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Move the selection head to the next line boundary.
        /// </summary>
        [<Import("selectLineBoundaryForward", "@codemirror/commands")>]
        static member inline selectLineBoundaryForward: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Move the selection head to the previous line boundary.
        /// </summary>
        [<Import("selectLineBoundaryBackward", "@codemirror/commands")>]
        static member inline selectLineBoundaryBackward: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Move the selection head one line boundary to the left.
        /// </summary>
        [<Import("selectLineBoundaryLeft", "@codemirror/commands")>]
        static member inline selectLineBoundaryLeft: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Move the selection head one line boundary to the right.
        /// </summary>
        [<Import("selectLineBoundaryRight", "@codemirror/commands")>]
        static member inline selectLineBoundaryRight: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Move the selection head to the start of the line.
        /// </summary>
        [<Import("selectLineStart", "@codemirror/commands")>]
        static member inline selectLineStart: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Move the selection head to the end of the line.
        /// </summary>
        [<Import("selectLineEnd", "@codemirror/commands")>]
        static member inline selectLineEnd: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Move the selection to the start of the document.
        /// </summary>
        [<Import("cursorDocStart", "@codemirror/commands")>]
        static member inline cursorDocStart: Glutinum.CodemirrorState.StateCommand = nativeOnly
        /// <summary>
        /// Move the selection to the end of the document.
        /// </summary>
        [<Import("cursorDocEnd", "@codemirror/commands")>]
        static member inline cursorDocEnd: Glutinum.CodemirrorState.StateCommand = nativeOnly
        /// <summary>
        /// Move the selection head to the start of the document.
        /// </summary>
        [<Import("selectDocStart", "@codemirror/commands")>]
        static member inline selectDocStart: Glutinum.CodemirrorState.StateCommand = nativeOnly
        /// <summary>
        /// Move the selection head to the end of the document.
        /// </summary>
        [<Import("selectDocEnd", "@codemirror/commands")>]
        static member inline selectDocEnd: Glutinum.CodemirrorState.StateCommand = nativeOnly
        /// <summary>
        /// Select the entire document.
        /// </summary>
        [<Import("selectAll", "@codemirror/commands")>]
        static member inline selectAll: Glutinum.CodemirrorState.StateCommand = nativeOnly
        /// <summary>
        /// Expand the selection to cover entire lines.
        /// </summary>
        [<Import("selectLine", "@codemirror/commands")>]
        static member inline selectLine: Glutinum.CodemirrorState.StateCommand = nativeOnly
        /// <summary>
        /// Select the next syntactic construct that is larger than the
        /// selection. Note that this will only work insofar as the language
        /// [provider](https://codemirror.net/6/docs/ref/#language.language) you use builds up a full
        /// syntax tree.
        /// </summary>
        [<Import("selectParentSyntax", "@codemirror/commands")>]
        static member inline selectParentSyntax: Glutinum.CodemirrorState.StateCommand = nativeOnly
        /// <summary>
        /// Expand the selection by adding a cursor above the heads of
        /// currently selected ranges.
        /// </summary>
        [<Import("addCursorAbove", "@codemirror/commands")>]
        static member inline addCursorAbove: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Expand the selection by adding a cursor below the heads of
        /// currently selected ranges.
        /// </summary>
        [<Import("addCursorBelow", "@codemirror/commands")>]
        static member inline addCursorBelow: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Simplify the current selection. When multiple ranges are selected,
        /// reduce it to its main range. Otherwise, if the selection is
        /// non-empty, convert it to a cursor selection.
        /// </summary>
        [<Import("simplifySelection", "@codemirror/commands")>]
        static member inline simplifySelection: Glutinum.CodemirrorState.StateCommand = nativeOnly
        /// <summary>
        /// Delete the selection, or, for cursor selections, the character or
        /// indentation unit before the cursor.
        /// </summary>
        [<Import("deleteCharBackward", "@codemirror/commands")>]
        static member inline deleteCharBackward: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Delete the selection or the character before the cursor. Does not
        /// implement any extended behavior like deleting whole indentation
        /// units in one go.
        /// </summary>
        [<Import("deleteCharBackwardStrict", "@codemirror/commands")>]
        static member inline deleteCharBackwardStrict: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Delete the selection or the character after the cursor.
        /// </summary>
        [<Import("deleteCharForward", "@codemirror/commands")>]
        static member inline deleteCharForward: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Delete the selection or backward until the end of the next
        /// [group](https://codemirror.net/6/docs/ref/#view.EditorView.moveByGroup), only skipping groups of
        /// whitespace when they consist of a single space.
        /// </summary>
        [<Import("deleteGroupBackward", "@codemirror/commands")>]
        static member inline deleteGroupBackward: Glutinum.CodemirrorState.StateCommand = nativeOnly
        /// <summary>
        /// Delete the selection or forward until the end of the next group.
        /// </summary>
        [<Import("deleteGroupForward", "@codemirror/commands")>]
        static member inline deleteGroupForward: Glutinum.CodemirrorState.StateCommand = nativeOnly
        /// <summary>
        /// Variant of [<c>deleteGroupForward</c>](https://codemirror.net/6/docs/ref/#commands.deleteGroupForward)
        /// that uses the Windows convention of also deleting the whitespace
        /// after a word.
        /// </summary>
        [<Import("deleteGroupForwardWin", "@codemirror/commands")>]
        static member inline deleteGroupForwardWin: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Delete the selection, or, if it is a cursor selection, delete to
        /// the end of the line. If the cursor is directly at the end of the
        /// line, delete the line break after it.
        /// </summary>
        [<Import("deleteToLineEnd", "@codemirror/commands")>]
        static member inline deleteToLineEnd: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Delete the selection, or, if it is a cursor selection, delete to
        /// the start of the line. If the cursor is directly at the start of the
        /// line, delete the line break before it.
        /// </summary>
        [<Import("deleteToLineStart", "@codemirror/commands")>]
        static member inline deleteToLineStart: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Delete the selection, or, if it is a cursor selection, delete to
        /// the start of the line or the next line wrap before the cursor.
        /// </summary>
        [<Import("deleteLineBoundaryBackward", "@codemirror/commands")>]
        static member inline deleteLineBoundaryBackward: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Delete the selection, or, if it is a cursor selection, delete to
        /// the end of the line or the next line wrap after the cursor.
        /// </summary>
        [<Import("deleteLineBoundaryForward", "@codemirror/commands")>]
        static member inline deleteLineBoundaryForward: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Delete all whitespace directly before a line end from the
        /// document.
        /// </summary>
        [<Import("deleteTrailingWhitespace", "@codemirror/commands")>]
        static member inline deleteTrailingWhitespace: Glutinum.CodemirrorState.StateCommand = nativeOnly
        /// <summary>
        /// Replace each selection range with a line break, leaving the cursor
        /// on the line before the break.
        /// </summary>
        [<Import("splitLine", "@codemirror/commands")>]
        static member inline splitLine: Glutinum.CodemirrorState.StateCommand = nativeOnly
        /// <summary>
        /// Flip the characters before and after the cursor(s).
        /// </summary>
        [<Import("transposeChars", "@codemirror/commands")>]
        static member inline transposeChars: Glutinum.CodemirrorState.StateCommand = nativeOnly
        /// <summary>
        /// Move the selected lines up one line.
        /// </summary>
        [<Import("moveLineUp", "@codemirror/commands")>]
        static member inline moveLineUp: Glutinum.CodemirrorState.StateCommand = nativeOnly
        /// <summary>
        /// Move the selected lines down one line.
        /// </summary>
        [<Import("moveLineDown", "@codemirror/commands")>]
        static member inline moveLineDown: Glutinum.CodemirrorState.StateCommand = nativeOnly
        /// <summary>
        /// Create a copy of the selected lines. Keep the selection in the top copy.
        /// </summary>
        [<Import("copyLineUp", "@codemirror/commands")>]
        static member inline copyLineUp: Glutinum.CodemirrorState.StateCommand = nativeOnly
        /// <summary>
        /// Create a copy of the selected lines. Keep the selection in the bottom copy.
        /// </summary>
        [<Import("copyLineDown", "@codemirror/commands")>]
        static member inline copyLineDown: Glutinum.CodemirrorState.StateCommand = nativeOnly
        /// <summary>
        /// Delete selected lines.
        /// </summary>
        [<Import("deleteLine", "@codemirror/commands")>]
        static member inline deleteLine: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Replace the selection with a newline.
        /// </summary>
        [<Import("insertNewline", "@codemirror/commands")>]
        static member inline insertNewline: Glutinum.CodemirrorState.StateCommand = nativeOnly
        /// <summary>
        /// Replace the selection with a newline and the same amount of
        /// indentation as the line above.
        /// </summary>
        [<Import("insertNewlineKeepIndent", "@codemirror/commands")>]
        static member inline insertNewlineKeepIndent: Glutinum.CodemirrorState.StateCommand = nativeOnly
        /// <summary>
        /// Replace the selection with a newline and indent the newly created
        /// line(s). If the current line consists only of whitespace, this
        /// will also delete that whitespace. When the cursor is between
        /// matching brackets, an additional newline will be inserted after
        /// the cursor.
        /// </summary>
        [<Import("insertNewlineAndIndent", "@codemirror/commands")>]
        static member inline insertNewlineAndIndent: Glutinum.CodemirrorState.StateCommand = nativeOnly
        /// <summary>
        /// Create a blank, indented line below the current line.
        /// </summary>
        [<Import("insertBlankLine", "@codemirror/commands")>]
        static member inline insertBlankLine: Glutinum.CodemirrorState.StateCommand = nativeOnly
        /// <summary>
        /// Auto-indent the selected lines. This uses the [indentation service
        /// facet](https://codemirror.net/6/docs/ref/#language.indentService) as source for auto-indent
        /// information.
        /// </summary>
        [<Import("indentSelection", "@codemirror/commands")>]
        static member inline indentSelection: Glutinum.CodemirrorState.StateCommand = nativeOnly
        /// <summary>
        /// Add a [unit](https://codemirror.net/6/docs/ref/#language.indentUnit) of indentation to all selected
        /// lines.
        /// </summary>
        [<Import("indentMore", "@codemirror/commands")>]
        static member inline indentMore: Glutinum.CodemirrorState.StateCommand = nativeOnly
        /// <summary>
        /// Remove a [unit](https://codemirror.net/6/docs/ref/#language.indentUnit) of indentation from all
        /// selected lines.
        /// </summary>
        [<Import("indentLess", "@codemirror/commands")>]
        static member inline indentLess: Glutinum.CodemirrorState.StateCommand = nativeOnly
        /// <summary>
        /// Enables or disables
        /// [tab-focus mode](https://codemirror.net/6/docs/ref/#view.EditorView.setTabFocusMode). While on, this
        /// prevents the editor's key bindings from capturing Tab or
        /// Shift-Tab, making it possible for the user to move focus out of
        /// the editor with the keyboard.
        /// </summary>
        [<Import("toggleTabFocusMode", "@codemirror/commands")>]
        static member inline toggleTabFocusMode: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Temporarily enables [tab-focus
        /// mode](https://codemirror.net/6/docs/ref/#view.EditorView.setTabFocusMode) for two seconds or until
        /// another key is pressed.
        /// </summary>
        [<Import("temporarilySetTabFocusMode", "@codemirror/commands")>]
        static member inline temporarilySetTabFocusMode: Glutinum.CodemirrorView.Command = nativeOnly
        /// <summary>
        /// Insert a tab character at the cursor or, if something is selected,
        /// use [<c>indentMore</c>](https://codemirror.net/6/docs/ref/#commands.indentMore) to indent the entire
        /// selection.
        /// </summary>
        [<Import("insertTab", "@codemirror/commands")>]
        static member inline insertTab: Glutinum.CodemirrorState.StateCommand = nativeOnly
        /// <summary>
        /// Array of key bindings containing the Emacs-style bindings that are
        /// available on macOS by default.
        ///
        /// - Ctrl-b: [<c>cursorCharLeft</c>](https://codemirror.net/6/docs/ref/#commands.cursorCharLeft) ([<c>selectCharLeft</c>](https://codemirror.net/6/docs/ref/#commands.selectCharLeft) with Shift)
        /// - Ctrl-f: [<c>cursorCharRight</c>](https://codemirror.net/6/docs/ref/#commands.cursorCharRight) ([<c>selectCharRight</c>](https://codemirror.net/6/docs/ref/#commands.selectCharRight) with Shift)
        /// - Ctrl-p: [<c>cursorLineUp</c>](https://codemirror.net/6/docs/ref/#commands.cursorLineUp) ([<c>selectLineUp</c>](https://codemirror.net/6/docs/ref/#commands.selectLineUp) with Shift)
        /// - Ctrl-n: [<c>cursorLineDown</c>](https://codemirror.net/6/docs/ref/#commands.cursorLineDown) ([<c>selectLineDown</c>](https://codemirror.net/6/docs/ref/#commands.selectLineDown) with Shift)
        /// - Ctrl-a: [<c>cursorLineStart</c>](https://codemirror.net/6/docs/ref/#commands.cursorLineStart) ([<c>selectLineStart</c>](https://codemirror.net/6/docs/ref/#commands.selectLineStart) with Shift)
        /// - Ctrl-e: [<c>cursorLineEnd</c>](https://codemirror.net/6/docs/ref/#commands.cursorLineEnd) ([<c>selectLineEnd</c>](https://codemirror.net/6/docs/ref/#commands.selectLineEnd) with Shift)
        /// - Ctrl-d: [<c>deleteCharForward</c>](https://codemirror.net/6/docs/ref/#commands.deleteCharForward)
        /// - Ctrl-h: [<c>deleteCharBackward</c>](https://codemirror.net/6/docs/ref/#commands.deleteCharBackward)
        /// - Ctrl-k: [<c>deleteToLineEnd</c>](https://codemirror.net/6/docs/ref/#commands.deleteToLineEnd)
        /// - Ctrl-Alt-h: [<c>deleteGroupBackward</c>](https://codemirror.net/6/docs/ref/#commands.deleteGroupBackward)
        /// - Ctrl-o: [<c>splitLine</c>](https://codemirror.net/6/docs/ref/#commands.splitLine)
        /// - Ctrl-t: [<c>transposeChars</c>](https://codemirror.net/6/docs/ref/#commands.transposeChars)
        /// - Ctrl-v: [<c>cursorPageDown</c>](https://codemirror.net/6/docs/ref/#commands.cursorPageDown)
        /// - Alt-v: [<c>cursorPageUp</c>](https://codemirror.net/6/docs/ref/#commands.cursorPageUp)
        /// </summary>
        [<Import("emacsStyleKeymap", "@codemirror/commands")>]
        static member inline emacsStyleKeymap: ReadonlyArray<Glutinum.CodemirrorView.KeyBinding> = nativeOnly
        /// <summary>
        /// An array of key bindings closely sticking to platform-standard or
        /// widely used bindings. (This includes the bindings from
        /// [<c>emacsStyleKeymap</c>](https://codemirror.net/6/docs/ref/#commands.emacsStyleKeymap), with their <c>key</c>
        /// property changed to <c>mac</c>.)
        ///
        /// - ArrowLeft: [<c>cursorCharLeft</c>](https://codemirror.net/6/docs/ref/#commands.cursorCharLeft) ([<c>selectCharLeft</c>](https://codemirror.net/6/docs/ref/#commands.selectCharLeft) with Shift)
        /// - ArrowRight: [<c>cursorCharRight</c>](https://codemirror.net/6/docs/ref/#commands.cursorCharRight) ([<c>selectCharRight</c>](https://codemirror.net/6/docs/ref/#commands.selectCharRight) with Shift)
        /// - Ctrl-ArrowLeft (Alt-ArrowLeft on macOS): [<c>cursorGroupLeft</c>](https://codemirror.net/6/docs/ref/#commands.cursorGroupLeft) ([<c>selectGroupLeft</c>](https://codemirror.net/6/docs/ref/#commands.selectGroupLeft) with Shift)
        /// - Ctrl-ArrowRight (Alt-ArrowRight on macOS): [<c>cursorGroupRight</c>](https://codemirror.net/6/docs/ref/#commands.cursorGroupRight) ([<c>selectGroupRight</c>](https://codemirror.net/6/docs/ref/#commands.selectGroupRight) with Shift)
        /// - Cmd-ArrowLeft (on macOS): [<c>cursorLineStart</c>](https://codemirror.net/6/docs/ref/#commands.cursorLineStart) ([<c>selectLineStart</c>](https://codemirror.net/6/docs/ref/#commands.selectLineStart) with Shift)
        /// - Cmd-ArrowRight (on macOS): [<c>cursorLineEnd</c>](https://codemirror.net/6/docs/ref/#commands.cursorLineEnd) ([<c>selectLineEnd</c>](https://codemirror.net/6/docs/ref/#commands.selectLineEnd) with Shift)
        /// - ArrowUp: [<c>cursorLineUp</c>](https://codemirror.net/6/docs/ref/#commands.cursorLineUp) ([<c>selectLineUp</c>](https://codemirror.net/6/docs/ref/#commands.selectLineUp) with Shift)
        /// - ArrowDown: [<c>cursorLineDown</c>](https://codemirror.net/6/docs/ref/#commands.cursorLineDown) ([<c>selectLineDown</c>](https://codemirror.net/6/docs/ref/#commands.selectLineDown) with Shift)
        /// - Cmd-ArrowUp (on macOS): [<c>cursorDocStart</c>](https://codemirror.net/6/docs/ref/#commands.cursorDocStart) ([<c>selectDocStart</c>](https://codemirror.net/6/docs/ref/#commands.selectDocStart) with Shift)
        /// - Cmd-ArrowDown (on macOS): [<c>cursorDocEnd</c>](https://codemirror.net/6/docs/ref/#commands.cursorDocEnd) ([<c>selectDocEnd</c>](https://codemirror.net/6/docs/ref/#commands.selectDocEnd) with Shift)
        /// - Ctrl-ArrowUp (on macOS): [<c>cursorPageUp</c>](https://codemirror.net/6/docs/ref/#commands.cursorPageUp) ([<c>selectPageUp</c>](https://codemirror.net/6/docs/ref/#commands.selectPageUp) with Shift)
        /// - Ctrl-ArrowDown (on macOS): [<c>cursorPageDown</c>](https://codemirror.net/6/docs/ref/#commands.cursorPageDown) ([<c>selectPageDown</c>](https://codemirror.net/6/docs/ref/#commands.selectPageDown) with Shift)
        /// - PageUp: [<c>cursorPageUp</c>](https://codemirror.net/6/docs/ref/#commands.cursorPageUp) ([<c>selectPageUp</c>](https://codemirror.net/6/docs/ref/#commands.selectPageUp) with Shift)
        /// - PageDown: [<c>cursorPageDown</c>](https://codemirror.net/6/docs/ref/#commands.cursorPageDown) ([<c>selectPageDown</c>](https://codemirror.net/6/docs/ref/#commands.selectPageDown) with Shift)
        /// - Home: [<c>cursorLineBoundaryBackward</c>](https://codemirror.net/6/docs/ref/#commands.cursorLineBoundaryBackward) ([<c>selectLineBoundaryBackward</c>](https://codemirror.net/6/docs/ref/#commands.selectLineBoundaryBackward) with Shift)
        /// - End: [<c>cursorLineBoundaryForward</c>](https://codemirror.net/6/docs/ref/#commands.cursorLineBoundaryForward) ([<c>selectLineBoundaryForward</c>](https://codemirror.net/6/docs/ref/#commands.selectLineBoundaryForward) with Shift)
        /// - Ctrl-Home (Cmd-Home on macOS): [<c>cursorDocStart</c>](https://codemirror.net/6/docs/ref/#commands.cursorDocStart) ([<c>selectDocStart</c>](https://codemirror.net/6/docs/ref/#commands.selectDocStart) with Shift)
        /// - Ctrl-End (Cmd-Home on macOS): [<c>cursorDocEnd</c>](https://codemirror.net/6/docs/ref/#commands.cursorDocEnd) ([<c>selectDocEnd</c>](https://codemirror.net/6/docs/ref/#commands.selectDocEnd) with Shift)
        /// - Enter and Shift-Enter: [<c>insertNewlineAndIndent</c>](https://codemirror.net/6/docs/ref/#commands.insertNewlineAndIndent)
        /// - Ctrl-a (Cmd-a on macOS): [<c>selectAll</c>](https://codemirror.net/6/docs/ref/#commands.selectAll)
        /// - Backspace: [<c>deleteCharBackward</c>](https://codemirror.net/6/docs/ref/#commands.deleteCharBackward)
        /// - Delete: [<c>deleteCharForward</c>](https://codemirror.net/6/docs/ref/#commands.deleteCharForward)
        /// - Ctrl-Backspace (Alt-Backspace on macOS): [<c>deleteGroupBackward</c>](https://codemirror.net/6/docs/ref/#commands.deleteGroupBackward)
        /// - Ctrl-Delete (Alt-Delete on macOS): [<c>deleteGroupForward</c>](https://codemirror.net/6/docs/ref/#commands.deleteGroupForward)
        /// - Cmd-Backspace (macOS): [<c>deleteLineBoundaryBackward</c>](https://codemirror.net/6/docs/ref/#commands.deleteLineBoundaryBackward).
        /// - Cmd-Delete (macOS): [<c>deleteLineBoundaryForward</c>](https://codemirror.net/6/docs/ref/#commands.deleteLineBoundaryForward).
        /// </summary>
        [<Import("standardKeymap", "@codemirror/commands")>]
        static member inline standardKeymap: ReadonlyArray<Glutinum.CodemirrorView.KeyBinding> = nativeOnly
        /// <summary>
        /// The default keymap. Includes all bindings from
        /// [<c>standardKeymap</c>](https://codemirror.net/6/docs/ref/#commands.standardKeymap) plus the following:
        ///
        /// - Alt-ArrowLeft (Ctrl-ArrowLeft on macOS): [<c>cursorSyntaxLeft</c>](https://codemirror.net/6/docs/ref/#commands.cursorSyntaxLeft) ([<c>selectSyntaxLeft</c>](https://codemirror.net/6/docs/ref/#commands.selectSyntaxLeft) with Shift)
        /// - Alt-ArrowRight (Ctrl-ArrowRight on macOS): [<c>cursorSyntaxRight</c>](https://codemirror.net/6/docs/ref/#commands.cursorSyntaxRight) ([<c>selectSyntaxRight</c>](https://codemirror.net/6/docs/ref/#commands.selectSyntaxRight) with Shift)
        /// - Alt-ArrowUp: [<c>moveLineUp</c>](https://codemirror.net/6/docs/ref/#commands.moveLineUp)
        /// - Alt-ArrowDown: [<c>moveLineDown</c>](https://codemirror.net/6/docs/ref/#commands.moveLineDown)
        /// - Shift-Alt-ArrowUp: [<c>copyLineUp</c>](https://codemirror.net/6/docs/ref/#commands.copyLineUp)
        /// - Shift-Alt-ArrowDown: [<c>copyLineDown</c>](https://codemirror.net/6/docs/ref/#commands.copyLineDown)
        /// - Ctrl-Alt-ArrowUp (Cmd-Alt-ArrowUp on macOS): [<c>addCursorAbove</c>](https://codemirror.net/6/docs/ref/#commands.addCursorAbove).
        /// - Ctrl-Alt-ArrowDown (Cmd-Alt-ArrowDown on macOS): [<c>addCursorBelow</c>](https://codemirror.net/6/docs/ref/#commands.addCursorBelow).
        /// - Escape: [<c>simplifySelection</c>](https://codemirror.net/6/docs/ref/#commands.simplifySelection)
        /// - Ctrl-Enter (Cmd-Enter on macOS): [<c>insertBlankLine</c>](https://codemirror.net/6/docs/ref/#commands.insertBlankLine)
        /// - Alt-l (Ctrl-l on macOS): [<c>selectLine</c>](https://codemirror.net/6/docs/ref/#commands.selectLine)
        /// - Ctrl-i (Cmd-i on macOS): [<c>selectParentSyntax</c>](https://codemirror.net/6/docs/ref/#commands.selectParentSyntax)
        /// - Ctrl-[ (Cmd-[ on macOS): [<c>indentLess</c>](https://codemirror.net/6/docs/ref/#commands.indentLess)
        /// - Ctrl-] (Cmd-] on macOS): [<c>indentMore</c>](https://codemirror.net/6/docs/ref/#commands.indentMore)
        /// - Ctrl-Alt-\\ (Cmd-Alt-\\ on macOS): [<c>indentSelection</c>](https://codemirror.net/6/docs/ref/#commands.indentSelection)
        /// - Shift-Ctrl-k (Shift-Cmd-k on macOS): [<c>deleteLine</c>](https://codemirror.net/6/docs/ref/#commands.deleteLine)
        /// - Shift-Ctrl-\\ (Shift-Cmd-\\ on macOS): [<c>cursorMatchingBracket</c>](https://codemirror.net/6/docs/ref/#commands.cursorMatchingBracket)
        /// - Ctrl-/ (Cmd-/ on macOS): [<c>toggleComment</c>](https://codemirror.net/6/docs/ref/#commands.toggleComment).
        /// - Shift-Alt-a (Shift-Ctrl-a on macOS): [<c>toggleBlockComment</c>](https://codemirror.net/6/docs/ref/#commands.toggleBlockComment).
        /// - Ctrl-m (Alt-Shift-m on macOS): [<c>toggleTabFocusMode</c>](https://codemirror.net/6/docs/ref/#commands.toggleTabFocusMode).
        /// </summary>
        [<Import("defaultKeymap", "@codemirror/commands")>]
        static member inline defaultKeymap: ReadonlyArray<Glutinum.CodemirrorView.KeyBinding> = nativeOnly
        /// <summary>
        /// A binding that binds Tab to [<c>indentMore</c>](https://codemirror.net/6/docs/ref/#commands.indentMore) and
        /// Shift-Tab to [<c>indentLess</c>](https://codemirror.net/6/docs/ref/#commands.indentLess).
        /// Please see the [Tab example](../../examples/tab/) before using
        /// this.
        /// </summary>
        [<Import("indentWithTab", "@codemirror/commands")>]
        static member inline indentWithTab: Glutinum.CodemirrorView.KeyBinding = nativeOnly

    /// <summary>
    /// An object of this type can be provided as [language
    /// data](https://codemirror.net/6/docs/ref/#state.EditorState.languageDataAt) under a <c>"commentTokens"</c>
    /// property to configure comment syntax for a language.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type CommentTokens =
        /// <summary>
        /// The block comment syntax, if any. For example, for HTML
        /// you'd provide <c>{open: "<!--", close: "-->"}</c>.
        /// </summary>
        abstract member block: CommentTokens.block option with get, set
        /// <summary>
        /// The line comment syntax. For example <c>"//"</c>.
        /// </summary>
        abstract member line: string option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?block: CommentTokens.block, ?line: string) : CommentTokens = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type HistoryConfig =
        /// <summary>
        /// The minimum depth (amount of events) to store. Defaults to 100.
        /// </summary>
        abstract member minDepth: float option with get, set
        /// <summary>
        /// The maximum time (in milliseconds) that adjacent events can be
        /// apart and still be grouped together. Defaults to 500.
        /// </summary>
        abstract member newGroupDelay: float option with get, set
        /// <summary>
        /// By default, when close enough together in time, changes are
        /// joined into an existing undo event if they touch any of the
        /// changed ranges from that event. You can pass a custom predicate
        /// here to influence that logic.
        /// </summary>
        abstract member joinToEvent: HistoryConfig.joinToEvent option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (?minDepth: float, ?newGroupDelay: float, ?joinToEvent: HistoryConfig.joinToEvent) : HistoryConfig = nativeOnly

    module CommentTokens =

        [<AllowNullLiteral>]
        [<Interface>]
        type block =
            abstract member ``open``: string with get, set
            abstract member close: string with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (``open``: string, close: string) : block = nativeOnly

    module HistoryConfig =

        type joinToEvent =
            delegate of tr: Glutinum.CodemirrorState.Transaction * isAdjacent: bool -> bool

    module Exports =

        module isolateHistory__ =

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type Type =
                | after
                | before
                | full
