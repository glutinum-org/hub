namespace rec Glutinum

open Fable.Core
open Fable.Core.JsInterop
open System

// You need to add Glutinum.Types NuGet package to your project
open Glutinum.Types.TypeScript

// You need to add Glutinum.LezerCommon NuGet package to your project

module LezerHighlight =

    [<AbstractClass>]
    [<Erase>]
    type Exports =
        /// <summary>
        /// This function is used to add a set of tags to a language syntax
        /// via [<c>NodeSet.extend</c>](#common.NodeSet.extend) or
        /// [<c>LRParser.configure</c>](#lr.LRParser.configure).
        ///
        /// The argument object maps node selectors to [highlighting
        /// tags](#highlight.Tag) or arrays of tags.
        ///
        /// Node selectors may hold one or more (space-separated) node paths.
        /// Such a path can be a [node name](#common.NodeType.name), or
        /// multiple node names (or <c>*</c> wildcards) separated by slash
        /// characters, as in <c>"Block/Declaration/VariableName"</c>. Such a path
        /// matches the final node but only if its direct parent nodes are the
        /// other nodes mentioned. A <c>*</c> in such a path matches any parent,
        /// but only a single level—wildcards that match multiple parents
        /// aren't supported, both for efficiency reasons and because Lezer
        /// trees make it rather hard to reason about what they would match.)
        ///
        /// A path can be ended with <c>/...</c> to indicate that the tag assigned
        /// to the node should also apply to all child nodes, even if they
        /// match their own style (by default, only the innermost style is
        /// used).
        ///
        /// When a path ends in <c>!</c>, as in <c>Attribute!</c>, no further matching
        /// happens for the node's child nodes, and the entire node gets the
        /// given style.
        ///
        /// In this notation, node names that contain <c>/</c>, <c>!</c>, <c>*</c>, or <c>...</c>
        /// must be quoted as JSON strings.
        ///
        /// For example:
        ///
        /// <c></c><c>javascript
        /// parser.configure({props: [
        /// styleTags({
        /// // Style Number and BigNumber nodes
        /// "Number BigNumber": tags.number,
        /// // Style Escape nodes whose parent is String
        /// "String/Escape": tags.escape,
        /// // Style anything inside Attributes nodes
        /// "Attributes!": tags.meta,
        /// // Add a style to all content inside Italic nodes
        /// "Italic/...": tags.emphasis,
        /// // Style InvalidString nodes as both </c>string<c> and </c>invalid<c>
        /// "InvalidString": [tags.string, tags.invalid],
        /// // Style the node named "/" as punctuation
        /// '"/"': tags.punctuation
        /// })
        /// ]})
        /// </c><c></c>
        /// </summary>
        [<Import("styleTags", "@lezer/highlight")>]
        static member styleTags (spec: Exports.styleTags__.spec) : Glutinum.LezerCommon.NodePropSource = nativeOnly
        /// <summary>
        /// Define a [highlighter](#highlight.Highlighter) from an array of
        /// tag/class pairs. Classes associated with more specific tags will
        /// take precedence.
        /// </summary>
        [<Import("tagHighlighter", "@lezer/highlight")>]
        static member tagHighlighter (tags: ResizeArray<Exports.tagHighlighter__.tags.Item>, ?options: Exports.tagHighlighter__.options) : LezerHighlight.Highlighter = nativeOnly
        /// <summary>
        /// Highlight the given [tree](#common.Tree) with the given
        /// [highlighter](#highlight.Highlighter). Often, the higher-level
        /// [<c>highlightCode</c>](#highlight.highlightCode) function is easier to
        /// use.
        /// </summary>
        [<Import("highlightTree", "@lezer/highlight")>]
        static member highlightTree (tree: Glutinum.LezerCommon.Tree, highlighter: LezerHighlight.Highlighter, putStyle: Exports.highlightTree__.putStyle, ?from: float, ?``to``: float) : unit = nativeOnly
        /// <summary>
        /// Highlight the given [tree](#common.Tree) with the given
        /// [highlighter](#highlight.Highlighter). Often, the higher-level
        /// [<c>highlightCode</c>](#highlight.highlightCode) function is easier to
        /// use.
        /// </summary>
        [<Import("highlightTree", "@lezer/highlight")>]
        static member highlightTree (tree: Glutinum.LezerCommon.Tree, highlighter: ResizeArray<LezerHighlight.Highlighter>, putStyle: Exports.highlightTree__.putStyle, ?from: float, ?``to``: float) : unit = nativeOnly
        /// <summary>
        /// Highlight the given tree with the given highlighter, calling
        /// <c>putText</c> for every piece of text, either with a set of classes or
        /// with the empty string when unstyled, and <c>putBreak</c> for every line
        /// break.
        /// </summary>
        [<Import("highlightCode", "@lezer/highlight")>]
        static member highlightCode (code: string, tree: Glutinum.LezerCommon.Tree, highlighter: LezerHighlight.Highlighter, putText: Exports.highlightCode__.putText, putBreak: (unit -> unit), ?from: float, ?``to``: float) : unit = nativeOnly
        /// <summary>
        /// Highlight the given tree with the given highlighter, calling
        /// <c>putText</c> for every piece of text, either with a set of classes or
        /// with the empty string when unstyled, and <c>putBreak</c> for every line
        /// break.
        /// </summary>
        [<Import("highlightCode", "@lezer/highlight")>]
        static member highlightCode (code: string, tree: Glutinum.LezerCommon.Tree, highlighter: ResizeArray<LezerHighlight.Highlighter>, putText: Exports.highlightCode__.putText, putBreak: (unit -> unit), ?from: float, ?``to``: float) : unit = nativeOnly
        /// <summary>
        /// Match a syntax node's [highlight rules](#highlight.styleTags). If
        /// there's a match, return its set of tags, and whether it is
        /// opaque (uses a <c>!</c>) or applies to all child nodes (<c>/...</c>).
        /// </summary>
        [<Import("getStyleTags", "@lezer/highlight")>]
        static member getStyleTags (node: Glutinum.LezerCommon.SyntaxNodeRef) : Exports.getStyleTags__ option = nativeOnly
        /// <summary>
        /// The default set of highlighting [tags](#highlight.Tag).
        ///
        /// This collection is heavily biased towards programming languages,
        /// and necessarily incomplete. A full ontology of syntactic
        /// constructs would fill a stack of books, and be impractical to
        /// write themes for. So try to make do with this set. If all else
        /// fails, [open an
        /// issue](https://code.haverbeke.berlin/codemirror/dev/issues) to propose a
        /// new tag, or [define](#highlight.Tag^define) a local custom tag for
        /// your use case.
        ///
        /// Note that it is not obligatory to always attach the most specific
        /// tag possible to an element—if your grammar can't easily
        /// distinguish a certain type of element (such as a local variable),
        /// it is okay to style it as its more general variant (a variable).
        ///
        /// For tags that extend some parent tag, the documentation links to
        /// the parent.
        /// </summary>
        [<Import("tags", "@lezer/highlight")>]
        static member inline tags: Exports.tags__.Type = nativeOnly
        /// <summary>
        /// This is a highlighter that adds stable, predictable classes to
        /// tokens, for styling with external CSS.
        ///
        /// The following tags are mapped to their name prefixed with <c>"tok-"</c>
        /// (for example <c>"tok-comment"</c>):
        ///
        /// [<c>link</c>](#highlight.tags.link)
        /// [<c>heading</c>](#highlight.tags.heading)
        /// [<c>emphasis</c>](#highlight.tags.emphasis)
        /// [<c>strong</c>](#highlight.tags.strong)
        /// [<c>keyword</c>](#highlight.tags.keyword)
        /// [<c>atom</c>](#highlight.tags.atom)
        /// [<c>bool</c>](#highlight.tags.bool)
        /// [<c>url</c>](#highlight.tags.url)
        /// [<c>labelName</c>](#highlight.tags.labelName)
        /// [<c>inserted</c>](#highlight.tags.inserted)
        /// [<c>deleted</c>](#highlight.tags.deleted)
        /// [<c>literal</c>](#highlight.tags.literal)
        /// [<c>string</c>](#highlight.tags.string)
        /// [<c>number</c>](#highlight.tags.number)
        /// [<c>variableName</c>](#highlight.tags.variableName)
        /// [<c>typeName</c>](#highlight.tags.typeName)
        /// [<c>namespace</c>](#highlight.tags.namespace)
        /// [<c>className</c>](#highlight.tags.className)
        /// [<c>macroName</c>](#highlight.tags.macroName)
        /// [<c>propertyName</c>](#highlight.tags.propertyName)
        /// [<c>operator</c>](#highlight.tags.operator)
        /// [<c>comment</c>](#highlight.tags.comment)
        /// [<c>meta</c>](#highlight.tags.meta)
        /// [<c>punctuation</c>](#highlight.tags.punctuation)
        /// [<c>invalid</c>](#highlight.tags.invalid)
        ///
        /// In addition, these mappings are provided:
        ///
        /// [<c>regexp</c>](#highlight.tags.regexp),
        /// [<c>escape</c>](#highlight.tags.escape), and
        /// [<c>special</c>](#highlight.tags.special)[<c>(string)</c>](#highlight.tags.string)
        /// are mapped to <c>"tok-string2"</c>
        /// [<c>special</c>](#highlight.tags.special)[<c>(variableName)</c>](#highlight.tags.variableName)
        /// to <c>"tok-variableName2"</c>
        /// [<c>local</c>](#highlight.tags.local)[<c>(variableName)</c>](#highlight.tags.variableName)
        /// to <c>"tok-variableName tok-local"</c>
        /// [<c>definition</c>](#highlight.tags.definition)[<c>(variableName)</c>](#highlight.tags.variableName)
        /// to <c>"tok-variableName tok-definition"</c>
        /// [<c>definition</c>](#highlight.tags.definition)[<c>(propertyName)</c>](#highlight.tags.propertyName)
        /// to <c>"tok-propertyName tok-definition"</c>
        /// </summary>
        [<Import("classHighlighter", "@lezer/highlight")>]
        static member inline classHighlighter: LezerHighlight.Highlighter = nativeOnly
        [<Import("Tag", "@lezer/highlight"); EmitConstructor>]
        static member Tag () : Tag = nativeOnly

    /// <summary>
    /// Highlighting tags are markers that denote a highlighting category.
    /// They are [associated](#highlight.styleTags) with parts of a syntax
    /// tree by a language mode, and then mapped to an actual CSS style by
    /// a [highlighter](#highlight.Highlighter).
    ///
    /// Because syntax tree node types and highlight styles have to be
    /// able to talk the same language, CodeMirror uses a mostly _closed_
    /// [vocabulary](#highlight.tags) of syntax tags (as opposed to
    /// traditional open string-based systems, which make it hard for
    /// highlighting themes to cover all the tokens produced by the
    /// various languages).
    ///
    /// It _is_ possible to [define](#highlight.Tag^define) your own
    /// highlighting tags for system-internal use (where you control both
    /// the language package and the highlighter), but such tags will not
    /// be picked up by regular highlighters (though you can derive them
    /// from standard tags to allow highlighters to fall back to those).
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("Tag", "@lezer/highlight")>]
    type Tag =
        /// <summary>
        /// The set of this tag and all its parent tags, starting with
        /// this one itself and sorted in order of decreasing specificity.
        /// </summary>
        abstract member set: ResizeArray<LezerHighlight.Tag> with get
        abstract member toString: unit -> string
        /// <summary>
        /// Define a new tag. If <c>parent</c> is given, the tag is treated as a
        /// sub-tag of that parent, and
        /// [highlighters](#highlight.tagHighlighter) that don't mention
        /// this tag will try to fall back to the parent tag (or grandparent
        /// tag, etc).
        /// </summary>
        [<Emit("""import { Tag } from "@lezer/highlight";
Tag.define($0, $1)""")>]
        static member inline define (?name: string, ?parent: LezerHighlight.Tag): LezerHighlight.Tag = nativeOnly
        /// <summary>
        /// Define a new tag. If <c>parent</c> is given, the tag is treated as a
        /// sub-tag of that parent, and
        /// [highlighters](#highlight.tagHighlighter) that don't mention
        /// this tag will try to fall back to the parent tag (or grandparent
        /// tag, etc).
        /// </summary>
        [<Emit("""import { Tag } from "@lezer/highlight";
Tag.define()""")>]
        static member inline define () : LezerHighlight.Tag = nativeOnly
        /// <summary>
        /// Define a new tag. If <c>parent</c> is given, the tag is treated as a
        /// sub-tag of that parent, and
        /// [highlighters](#highlight.tagHighlighter) that don't mention
        /// this tag will try to fall back to the parent tag (or grandparent
        /// tag, etc).
        /// </summary>
        [<Emit("""import { Tag } from "@lezer/highlight";
Tag.define($0)""")>]
        static member inline define (parent: LezerHighlight.Tag): LezerHighlight.Tag = nativeOnly
        /// <summary>
        /// Define a tag _modifier_, which is a function that, given a tag,
        /// will return a tag that is a subtag of the original. Applying the
        /// same modifier to a twice tag will return the same value (<c>m1(t1)
        /// == m1(t1)</c>) and applying multiple modifiers will, regardless or
        /// order, produce the same tag (<c>m1(m2(t1)) == m2(m1(t1))</c>).
        ///
        /// When multiple modifiers are applied to a given base tag, each
        /// smaller set of modifiers is registered as a parent, so that for
        /// example <c>m1(m2(m3(t1)))</c> is a subtype of <c>m1(m2(t1))</c>,
        /// <c>m1(m3(t1)</c>, and so on.
        /// </summary>
        [<Emit("""import { Tag } from "@lezer/highlight";
Tag.defineModifier($0)""")>]
        static member inline defineModifier (?name: string): (LezerHighlight.Tag -> LezerHighlight.Tag) = nativeOnly

    /// <summary>
    /// A highlighter defines a mapping from highlighting tags and
    /// language scopes to CSS class names. They are usually defined via
    /// [<c>tagHighlighter</c>](#highlight.tagHighlighter) or some wrapper
    /// around that, but it is also possible to implement them from
    /// scratch.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type Highlighter =
        /// <summary>
        /// Get the set of classes that should be applied to the given set
        /// of highlighting tags, or null if this highlighter doesn't assign
        /// a style to the tags.
        /// </summary>
        abstract member style: tags: ResizeArray<LezerHighlight.Tag> -> string option
        /// <summary>
        /// When given, the highlighter will only be applied to trees on
        /// whose [top](#common.NodeType.isTop) node this predicate returns
        /// true.
        /// </summary>
        abstract member scope: (Glutinum.LezerCommon.NodeType -> bool) option with get, set

    module Exports =

        [<AllowNullLiteral>]
        [<Interface>]
        type getStyleTags__ =
            abstract member tags: ReadonlyArray<LezerHighlight.Tag> with get, set
            abstract member opaque: bool with get, set
            abstract member ``inherit``: bool with get, set
            [<ParamObject; Emit("$0")>]
            static member Create (tags: ResizeArray<LezerHighlight.Tag>, opaque: bool, ``inherit``: bool) : getStyleTags__ = nativeOnly

        module styleTags__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type spec =
                [<EmitIndexer>]
                abstract member Item: selector: string -> U2<LezerHighlight.Tag, ResizeArray<LezerHighlight.Tag>> with get, set

        module tagHighlighter__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type options =
                /// <summary>
                /// By default, highlighters apply to the entire document. You can
                /// scope them to a single language by providing the tree's
                /// [top](#common.NodeType.isTop) node type here.
                /// </summary>
                abstract member scope: (Glutinum.LezerCommon.NodeType -> bool) option with get, set
                /// <summary>
                /// Add a style to _all_ tokens. Probably only useful in combination
                /// with <c>scope</c>.
                /// </summary>
                abstract member all: string option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?scope: (Glutinum.LezerCommon.NodeType -> bool), ?all: string) : options = nativeOnly

            module tags =

                [<AllowNullLiteral>]
                [<Interface>]
                type Item =
                    abstract member tag: U2<LezerHighlight.Tag, ResizeArray<LezerHighlight.Tag>> with get, set
                    abstract member ``class``: string with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (tag: LezerHighlight.Tag, ``class``: string) : Item = nativeOnly
                    [<ParamObject; Emit("$0")>]
                    static member Create (tag: ResizeArray<LezerHighlight.Tag>, ``class``: string) : Item = nativeOnly

        module highlightTree__ =

            type putStyle =
                delegate of from: float * ``to``: float * classes: string -> unit

        module highlightCode__ =

            type putText =
                delegate of code: string * classes: string -> unit

        module tags__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type Type =
                /// <summary>
                /// A comment.
                /// </summary>
                abstract member comment: LezerHighlight.Tag with get, set
                /// <summary>
                /// A line [comment](#highlight.tags.comment).
                /// </summary>
                abstract member lineComment: LezerHighlight.Tag with get, set
                /// <summary>
                /// A block [comment](#highlight.tags.comment).
                /// </summary>
                abstract member blockComment: LezerHighlight.Tag with get, set
                /// <summary>
                /// A documentation [comment](#highlight.tags.comment).
                /// </summary>
                abstract member docComment: LezerHighlight.Tag with get, set
                /// <summary>
                /// Any kind of identifier.
                /// </summary>
                abstract member name: LezerHighlight.Tag with get, set
                /// <summary>
                /// The [name](#highlight.tags.name) of a variable.
                /// </summary>
                abstract member variableName: LezerHighlight.Tag with get, set
                /// <summary>
                /// A type [name](#highlight.tags.name).
                /// </summary>
                abstract member typeName: LezerHighlight.Tag with get, set
                /// <summary>
                /// A tag name (subtag of [<c>typeName</c>](#highlight.tags.typeName)).
                /// </summary>
                abstract member tagName: LezerHighlight.Tag with get, set
                /// <summary>
                /// A property or field [name](#highlight.tags.name).
                /// </summary>
                abstract member propertyName: LezerHighlight.Tag with get, set
                /// <summary>
                /// An attribute name (subtag of [<c>propertyName</c>](#highlight.tags.propertyName)).
                /// </summary>
                abstract member attributeName: LezerHighlight.Tag with get, set
                /// <summary>
                /// The [name](#highlight.tags.name) of a class.
                /// </summary>
                abstract member className: LezerHighlight.Tag with get, set
                /// <summary>
                /// A label [name](#highlight.tags.name).
                /// </summary>
                abstract member labelName: LezerHighlight.Tag with get, set
                /// <summary>
                /// A namespace [name](#highlight.tags.name).
                /// </summary>
                abstract member ``namespace``: LezerHighlight.Tag with get, set
                /// <summary>
                /// The [name](#highlight.tags.name) of a macro.
                /// </summary>
                abstract member macroName: LezerHighlight.Tag with get, set
                /// <summary>
                /// A literal value.
                /// </summary>
                abstract member literal: LezerHighlight.Tag with get, set
                /// <summary>
                /// A string [literal](#highlight.tags.literal).
                /// </summary>
                abstract member string: LezerHighlight.Tag with get, set
                /// <summary>
                /// A documentation [string](#highlight.tags.string).
                /// </summary>
                abstract member docString: LezerHighlight.Tag with get, set
                /// <summary>
                /// A character literal (subtag of [string](#highlight.tags.string)).
                /// </summary>
                abstract member character: LezerHighlight.Tag with get, set
                /// <summary>
                /// An attribute value (subtag of [string](#highlight.tags.string)).
                /// </summary>
                abstract member attributeValue: LezerHighlight.Tag with get, set
                /// <summary>
                /// A number [literal](#highlight.tags.literal).
                /// </summary>
                abstract member number: LezerHighlight.Tag with get, set
                /// <summary>
                /// An integer [number](#highlight.tags.number) literal.
                /// </summary>
                abstract member integer: LezerHighlight.Tag with get, set
                /// <summary>
                /// A floating-point [number](#highlight.tags.number) literal.
                /// </summary>
                abstract member float: LezerHighlight.Tag with get, set
                /// <summary>
                /// A boolean [literal](#highlight.tags.literal).
                /// </summary>
                abstract member bool: LezerHighlight.Tag with get, set
                /// <summary>
                /// Regular expression [literal](#highlight.tags.literal).
                /// </summary>
                abstract member regexp: LezerHighlight.Tag with get, set
                /// <summary>
                /// An escape [literal](#highlight.tags.literal), for example a
                /// backslash escape in a string.
                /// </summary>
                abstract member escape: LezerHighlight.Tag with get, set
                /// <summary>
                /// A color [literal](#highlight.tags.literal).
                /// </summary>
                abstract member color: LezerHighlight.Tag with get, set
                /// <summary>
                /// A URL [literal](#highlight.tags.literal).
                /// </summary>
                abstract member url: LezerHighlight.Tag with get, set
                /// <summary>
                /// A language keyword.
                /// </summary>
                abstract member keyword: LezerHighlight.Tag with get, set
                /// <summary>
                /// The [keyword](#highlight.tags.keyword) for the self or this
                /// object.
                /// </summary>
                abstract member self: LezerHighlight.Tag with get, set
                /// <summary>
                /// The [keyword](#highlight.tags.keyword) for null.
                /// </summary>
                abstract member ``null``: LezerHighlight.Tag with get, set
                /// <summary>
                /// A [keyword](#highlight.tags.keyword) denoting some atomic value.
                /// </summary>
                abstract member atom: LezerHighlight.Tag with get, set
                /// <summary>
                /// A [keyword](#highlight.tags.keyword) that represents a unit.
                /// </summary>
                abstract member unit: LezerHighlight.Tag with get, set
                /// <summary>
                /// A modifier [keyword](#highlight.tags.keyword).
                /// </summary>
                abstract member modifier: LezerHighlight.Tag with get, set
                /// <summary>
                /// A [keyword](#highlight.tags.keyword) that acts as an operator.
                /// </summary>
                abstract member operatorKeyword: LezerHighlight.Tag with get, set
                /// <summary>
                /// A control-flow related [keyword](#highlight.tags.keyword).
                /// </summary>
                abstract member controlKeyword: LezerHighlight.Tag with get, set
                /// <summary>
                /// A [keyword](#highlight.tags.keyword) that defines something.
                /// </summary>
                abstract member definitionKeyword: LezerHighlight.Tag with get, set
                /// <summary>
                /// A [keyword](#highlight.tags.keyword) related to defining or
                /// interfacing with modules.
                /// </summary>
                abstract member moduleKeyword: LezerHighlight.Tag with get, set
                /// <summary>
                /// An operator.
                /// </summary>
                abstract member operator: LezerHighlight.Tag with get, set
                /// <summary>
                /// An [operator](#highlight.tags.operator) that dereferences something.
                /// </summary>
                abstract member derefOperator: LezerHighlight.Tag with get, set
                /// <summary>
                /// Arithmetic-related [operator](#highlight.tags.operator).
                /// </summary>
                abstract member arithmeticOperator: LezerHighlight.Tag with get, set
                /// <summary>
                /// Logical [operator](#highlight.tags.operator).
                /// </summary>
                abstract member logicOperator: LezerHighlight.Tag with get, set
                /// <summary>
                /// Bit [operator](#highlight.tags.operator).
                /// </summary>
                abstract member bitwiseOperator: LezerHighlight.Tag with get, set
                /// <summary>
                /// Comparison [operator](#highlight.tags.operator).
                /// </summary>
                abstract member compareOperator: LezerHighlight.Tag with get, set
                /// <summary>
                /// [Operator](#highlight.tags.operator) that updates its operand.
                /// </summary>
                abstract member updateOperator: LezerHighlight.Tag with get, set
                /// <summary>
                /// [Operator](#highlight.tags.operator) that defines something.
                /// </summary>
                abstract member definitionOperator: LezerHighlight.Tag with get, set
                /// <summary>
                /// Type-related [operator](#highlight.tags.operator).
                /// </summary>
                abstract member typeOperator: LezerHighlight.Tag with get, set
                /// <summary>
                /// Control-flow [operator](#highlight.tags.operator).
                /// </summary>
                abstract member controlOperator: LezerHighlight.Tag with get, set
                /// <summary>
                /// Program or markup punctuation.
                /// </summary>
                abstract member punctuation: LezerHighlight.Tag with get, set
                /// <summary>
                /// [Punctuation](#highlight.tags.punctuation) that separates
                /// things.
                /// </summary>
                abstract member separator: LezerHighlight.Tag with get, set
                /// <summary>
                /// Bracket-style [punctuation](#highlight.tags.punctuation).
                /// </summary>
                abstract member bracket: LezerHighlight.Tag with get, set
                /// <summary>
                /// Angle [brackets](#highlight.tags.bracket) (usually <c><</c> and <c>></c>
                /// tokens).
                /// </summary>
                abstract member angleBracket: LezerHighlight.Tag with get, set
                /// <summary>
                /// Square [brackets](#highlight.tags.bracket) (usually <c>[</c> and <c>]</c>
                /// tokens).
                /// </summary>
                abstract member squareBracket: LezerHighlight.Tag with get, set
                /// <summary>
                /// Parentheses (usually <c>(</c> and <c>)</c> tokens). Subtag of
                /// [bracket](#highlight.tags.bracket).
                /// </summary>
                abstract member paren: LezerHighlight.Tag with get, set
                /// <summary>
                /// Braces (usually <c>{</c> and <c>}</c> tokens). Subtag of
                /// [bracket](#highlight.tags.bracket).
                /// </summary>
                abstract member brace: LezerHighlight.Tag with get, set
                /// <summary>
                /// Content, for example plain text in XML or markup documents.
                /// </summary>
                abstract member content: LezerHighlight.Tag with get, set
                /// <summary>
                /// [Content](#highlight.tags.content) that represents a heading.
                /// </summary>
                abstract member heading: LezerHighlight.Tag with get, set
                /// <summary>
                /// A level 1 [heading](#highlight.tags.heading).
                /// </summary>
                abstract member heading1: LezerHighlight.Tag with get, set
                /// <summary>
                /// A level 2 [heading](#highlight.tags.heading).
                /// </summary>
                abstract member heading2: LezerHighlight.Tag with get, set
                /// <summary>
                /// A level 3 [heading](#highlight.tags.heading).
                /// </summary>
                abstract member heading3: LezerHighlight.Tag with get, set
                /// <summary>
                /// A level 4 [heading](#highlight.tags.heading).
                /// </summary>
                abstract member heading4: LezerHighlight.Tag with get, set
                /// <summary>
                /// A level 5 [heading](#highlight.tags.heading).
                /// </summary>
                abstract member heading5: LezerHighlight.Tag with get, set
                /// <summary>
                /// A level 6 [heading](#highlight.tags.heading).
                /// </summary>
                abstract member heading6: LezerHighlight.Tag with get, set
                /// <summary>
                /// A prose [content](#highlight.tags.content) separator (such as a horizontal rule).
                /// </summary>
                abstract member contentSeparator: LezerHighlight.Tag with get, set
                /// <summary>
                /// [Content](#highlight.tags.content) that represents a list.
                /// </summary>
                abstract member list: LezerHighlight.Tag with get, set
                /// <summary>
                /// [Content](#highlight.tags.content) that represents a quote.
                /// </summary>
                abstract member quote: LezerHighlight.Tag with get, set
                /// <summary>
                /// [Content](#highlight.tags.content) that is emphasized.
                /// </summary>
                abstract member emphasis: LezerHighlight.Tag with get, set
                /// <summary>
                /// [Content](#highlight.tags.content) that is styled strong.
                /// </summary>
                abstract member strong: LezerHighlight.Tag with get, set
                /// <summary>
                /// [Content](#highlight.tags.content) that is part of a link.
                /// </summary>
                abstract member link: LezerHighlight.Tag with get, set
                /// <summary>
                /// [Content](#highlight.tags.content) that is styled as code or
                /// monospace.
                /// </summary>
                abstract member monospace: LezerHighlight.Tag with get, set
                /// <summary>
                /// [Content](#highlight.tags.content) that has a strike-through
                /// style.
                /// </summary>
                abstract member strikethrough: LezerHighlight.Tag with get, set
                /// <summary>
                /// Inserted text in a change-tracking format.
                /// </summary>
                abstract member inserted: LezerHighlight.Tag with get, set
                /// <summary>
                /// Deleted text.
                /// </summary>
                abstract member deleted: LezerHighlight.Tag with get, set
                /// <summary>
                /// Changed text.
                /// </summary>
                abstract member changed: LezerHighlight.Tag with get, set
                /// <summary>
                /// An invalid or unsyntactic element.
                /// </summary>
                abstract member invalid: LezerHighlight.Tag with get, set
                /// <summary>
                /// Metadata or meta-instruction.
                /// </summary>
                abstract member meta: LezerHighlight.Tag with get, set
                /// <summary>
                /// [Metadata](#highlight.tags.meta) that applies to the entire
                /// document.
                /// </summary>
                abstract member documentMeta: LezerHighlight.Tag with get, set
                /// <summary>
                /// [Metadata](#highlight.tags.meta) that annotates or adds
                /// attributes to a given syntactic element.
                /// </summary>
                abstract member annotation: LezerHighlight.Tag with get, set
                /// <summary>
                /// Processing instruction or preprocessor directive. Subtag of
                /// [meta](#highlight.tags.meta).
                /// </summary>
                abstract member processingInstruction: LezerHighlight.Tag with get, set
                /// <summary>
                /// [Modifier](#highlight.Tag^defineModifier) that indicates that a
                /// given element is being defined. Expected to be used with the
                /// various [name](#highlight.tags.name) tags.
                /// </summary>
                abstract member definition: (LezerHighlight.Tag -> LezerHighlight.Tag) with get, set
                /// <summary>
                /// [Modifier](#highlight.Tag^defineModifier) that indicates that
                /// something is constant. Mostly expected to be used with
                /// [variable names](#highlight.tags.variableName).
                /// </summary>
                abstract member constant: (LezerHighlight.Tag -> LezerHighlight.Tag) with get, set
                /// <summary>
                /// [Modifier](#highlight.Tag^defineModifier) used to indicate that
                /// a [variable](#highlight.tags.variableName) or [property
                /// name](#highlight.tags.propertyName) is being called or defined
                /// as a function.
                /// </summary>
                abstract member ``function``: (LezerHighlight.Tag -> LezerHighlight.Tag) with get, set
                /// <summary>
                /// [Modifier](#highlight.Tag^defineModifier) that can be applied to
                /// [names](#highlight.tags.name) to indicate that they belong to
                /// the language's standard environment.
                /// </summary>
                abstract member standard: (LezerHighlight.Tag -> LezerHighlight.Tag) with get, set
                /// <summary>
                /// [Modifier](#highlight.Tag^defineModifier) that indicates a given
                /// [names](#highlight.tags.name) is local to some scope.
                /// </summary>
                abstract member local: (LezerHighlight.Tag -> LezerHighlight.Tag) with get, set
                /// <summary>
                /// A generic variant [modifier](#highlight.Tag^defineModifier) that
                /// can be used to tag language-specific alternative variants of
                /// some common tag. It is recommended for themes to define special
                /// forms of at least the [string](#highlight.tags.string) and
                /// [variable name](#highlight.tags.variableName) tags, since those
                /// come up a lot.
                /// </summary>
                abstract member special: (LezerHighlight.Tag -> LezerHighlight.Tag) with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (comment: LezerHighlight.Tag, lineComment: LezerHighlight.Tag, blockComment: LezerHighlight.Tag, docComment: LezerHighlight.Tag, name: LezerHighlight.Tag, variableName: LezerHighlight.Tag, typeName: LezerHighlight.Tag, tagName: LezerHighlight.Tag, propertyName: LezerHighlight.Tag, attributeName: LezerHighlight.Tag, className: LezerHighlight.Tag, labelName: LezerHighlight.Tag, ``namespace``: LezerHighlight.Tag, macroName: LezerHighlight.Tag, literal: LezerHighlight.Tag, string: LezerHighlight.Tag, docString: LezerHighlight.Tag, character: LezerHighlight.Tag, attributeValue: LezerHighlight.Tag, number: LezerHighlight.Tag, integer: LezerHighlight.Tag, float: LezerHighlight.Tag, bool: LezerHighlight.Tag, regexp: LezerHighlight.Tag, escape: LezerHighlight.Tag, color: LezerHighlight.Tag, url: LezerHighlight.Tag, keyword: LezerHighlight.Tag, self: LezerHighlight.Tag, ``null``: LezerHighlight.Tag, atom: LezerHighlight.Tag, unit: LezerHighlight.Tag, modifier: LezerHighlight.Tag, operatorKeyword: LezerHighlight.Tag, controlKeyword: LezerHighlight.Tag, definitionKeyword: LezerHighlight.Tag, moduleKeyword: LezerHighlight.Tag, operator: LezerHighlight.Tag, derefOperator: LezerHighlight.Tag, arithmeticOperator: LezerHighlight.Tag, logicOperator: LezerHighlight.Tag, bitwiseOperator: LezerHighlight.Tag, compareOperator: LezerHighlight.Tag, updateOperator: LezerHighlight.Tag, definitionOperator: LezerHighlight.Tag, typeOperator: LezerHighlight.Tag, controlOperator: LezerHighlight.Tag, punctuation: LezerHighlight.Tag, separator: LezerHighlight.Tag, bracket: LezerHighlight.Tag, angleBracket: LezerHighlight.Tag, squareBracket: LezerHighlight.Tag, paren: LezerHighlight.Tag, brace: LezerHighlight.Tag, content: LezerHighlight.Tag, heading: LezerHighlight.Tag, heading1: LezerHighlight.Tag, heading2: LezerHighlight.Tag, heading3: LezerHighlight.Tag, heading4: LezerHighlight.Tag, heading5: LezerHighlight.Tag, heading6: LezerHighlight.Tag, contentSeparator: LezerHighlight.Tag, list: LezerHighlight.Tag, quote: LezerHighlight.Tag, emphasis: LezerHighlight.Tag, strong: LezerHighlight.Tag, link: LezerHighlight.Tag, monospace: LezerHighlight.Tag, strikethrough: LezerHighlight.Tag, inserted: LezerHighlight.Tag, deleted: LezerHighlight.Tag, changed: LezerHighlight.Tag, invalid: LezerHighlight.Tag, meta: LezerHighlight.Tag, documentMeta: LezerHighlight.Tag, annotation: LezerHighlight.Tag, processingInstruction: LezerHighlight.Tag, definition: (LezerHighlight.Tag -> LezerHighlight.Tag), constant: (LezerHighlight.Tag -> LezerHighlight.Tag), ``function``: (LezerHighlight.Tag -> LezerHighlight.Tag), standard: (LezerHighlight.Tag -> LezerHighlight.Tag), local: (LezerHighlight.Tag -> LezerHighlight.Tag), special: (LezerHighlight.Tag -> LezerHighlight.Tag)) : Type = nativeOnly
