namespace rec Glutinum

open Fable.Core
open Fable.Core.JsInterop
open System

// You need to add Glutinum.Types NuGet package to your project
open Glutinum.Types.TypeScript

module LezerCommon =

    [<AbstractClass>]
    [<Erase>]
    type Exports =
        /// <summary>
        /// The default maximum length of a <c>TreeBuffer</c> node.
        /// </summary>
        [<Import("DefaultBufferLength", "@lezer/common")>]
        static member inline DefaultBufferLength: float = nativeOnly
        /// <summary>
        /// Create a parse wrapper that, after the inner parse completes,
        /// scans its tree for mixed language regions with the <c>nest</c>
        /// function, runs the resulting [inner parses](#common.NestedParse),
        /// and then [mounts](#common.NodeProp^mounted) their results onto the
        /// tree.
        /// </summary>
        [<Import("parseMixed", "@lezer/common")>]
        static member parseMixed (nest: Exports.parseMixed__.nest) : LezerCommon.ParseWrapper = nativeOnly
        /// <summary>
        /// Construct a tree fragment. You'll usually want to use
        /// [<c>addTree</c>](#common.TreeFragment^addTree) and
        /// [<c>applyChanges</c>](#common.TreeFragment^applyChanges) instead of
        /// calling this directly.
        /// </summary>
        [<Import("TreeFragment", "@lezer/common"); EmitConstructor>]
        static member TreeFragment (from: float, ``to``: float, tree: LezerCommon.Tree, offset: float, ?openStart: bool, ?openEnd: bool) : TreeFragment = nativeOnly
        [<Import("Parser", "@lezer/common"); EmitConstructor>]
        static member Parser () : Parser = nativeOnly
        /// <summary>
        /// Create a new node prop type.
        /// </summary>
        [<Import("NodeProp", "@lezer/common"); EmitConstructor>]
        static member NodeProp<'T> (?config: Exports.NodeProp.config<'T>) : NodeProp<'T> = nativeOnly
        [<Import("MountedTree", "@lezer/common"); EmitConstructor>]
        static member MountedTree (tree: LezerCommon.Tree, overlay: ResizeArray<Exports.MountedTree.overlay.Item> option, parser: LezerCommon.Parser, ?bracketed: bool) : MountedTree = nativeOnly
        [<Import("NodeType", "@lezer/common"); EmitConstructor>]
        static member NodeType () : NodeType = nativeOnly
        /// <summary>
        /// Create a set with the given types. The <c>id</c> property of each
        /// type should correspond to its position within the array.
        /// </summary>
        [<Import("NodeSet", "@lezer/common"); EmitConstructor>]
        static member NodeSet (types: ResizeArray<LezerCommon.NodeType>) : NodeSet = nativeOnly
        /// <summary>
        /// Construct a new tree. See also [<c>Tree.build</c>](#common.Tree^build).
        /// </summary>
        [<Import("Tree", "@lezer/common"); EmitConstructor>]
        static member Tree (``type``: LezerCommon.NodeType, children: ResizeArray<U2<LezerCommon.Tree, LezerCommon.TreeBuffer>>, positions: ResizeArray<float>, length: float, ?props: ResizeArray<U2<LezerCommon.NodeProp<obj>, float> * obj>) : Tree = nativeOnly
        /// <summary>
        /// Create a tree buffer.
        /// </summary>
        [<Import("TreeBuffer", "@lezer/common"); EmitConstructor>]
        static member TreeBuffer (buffer: JS.Uint16Array, length: float, set: LezerCommon.NodeSet) : TreeBuffer = nativeOnly
        [<Import("TreeCursor", "@lezer/common"); EmitConstructor>]
        static member TreeCursor () : TreeCursor = nativeOnly
        [<Import("NodeWeakMap", "@lezer/common"); EmitConstructor>]
        static member NodeWeakMap<'T> () : NodeWeakMap<'T> = nativeOnly

    /// <summary>
    /// The [<c>TreeFragment.applyChanges</c>](#common.TreeFragment^applyChanges)
    /// method expects changed ranges in this format.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type ChangedRange =
        /// <summary>
        /// The start of the change in the start document
        /// </summary>
        abstract member fromA: float with get, set
        /// <summary>
        /// The end of the change in the start document
        /// </summary>
        abstract member toA: float with get, set
        /// <summary>
        /// The start of the replacement in the new document
        /// </summary>
        abstract member fromB: float with get, set
        /// <summary>
        /// The end of the replacement in the new document
        /// </summary>
        abstract member toB: float with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (fromA: float, toA: float, fromB: float, toB: float) : ChangedRange = nativeOnly

    /// <summary>
    /// Tree fragments are used during [incremental
    /// parsing](#common.Parser.startParse) to track parts of old trees
    /// that can be reused in a new parse. An array of fragments is used
    /// to track regions of an old tree whose nodes might be reused in new
    /// parses. Use the static
    /// [<c>applyChanges</c>](#common.TreeFragment^applyChanges) method to
    /// update fragments for document changes.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("TreeFragment", "@lezer/common")>]
    type TreeFragment =
        /// <summary>
        /// The start of the unchanged range pointed to by this fragment.
        /// This refers to an offset in the _updated_ document (as opposed
        /// to the original tree).
        /// </summary>
        abstract member from: float with get
        /// <summary>
        /// The end of the unchanged range.
        /// </summary>
        abstract member ``to``: float with get
        /// <summary>
        /// The tree that this fragment is based on.
        /// </summary>
        abstract member tree: LezerCommon.Tree with get
        /// <summary>
        /// The offset between the fragment's tree and the document that
        /// this fragment can be used against. Add this when going from
        /// document to tree positions, subtract it to go from tree to
        /// document positions.
        /// </summary>
        abstract member offset: float with get
        /// <summary>
        /// Whether the start of the fragment represents the start of a
        /// parse, or the end of a change. (In the second case, it may not
        /// be safe to reuse some nodes at the start, depending on the
        /// parsing algorithm.)
        /// </summary>
        abstract member openStart: bool with get
        /// <summary>
        /// Whether the end of the fragment represents the end of a
        /// full-document parse, or the start of a change.
        /// </summary>
        abstract member openEnd: bool with get
        /// <summary>
        /// Create a set of fragments from a freshly parsed tree, or update
        /// an existing set of fragments by replacing the ones that overlap
        /// with a tree with content from the new tree. When <c>partial</c> is
        /// true, the parse is treated as incomplete, and the resulting
        /// fragment has [<c>openEnd</c>](#common.TreeFragment.openEnd) set to
        /// true.
        /// </summary>
        [<Emit("""import { TreeFragment } from "@lezer/common";
TreeFragment.addTree($0, $1, $2)""")>]
        static member inline addTree (tree: LezerCommon.Tree, ?fragments: ResizeArray<LezerCommon.TreeFragment>, ?partial: bool): ReadonlyArray<LezerCommon.TreeFragment> = nativeOnly
        /// <summary>
        /// Apply a set of edits to an array of fragments, removing or
        /// splitting fragments as necessary to remove edited ranges, and
        /// adjusting offsets for fragments that moved.
        /// </summary>
        [<Emit("""import { TreeFragment } from "@lezer/common";
TreeFragment.applyChanges($0, $1, $2)""")>]
        static member inline applyChanges (fragments: ResizeArray<LezerCommon.TreeFragment>, changes: ResizeArray<LezerCommon.ChangedRange>, ?minGap: float): ReadonlyArray<LezerCommon.TreeFragment> = nativeOnly

    /// <summary>
    /// Interface used to represent an in-progress parse, which can be
    /// moved forward piece-by-piece.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type PartialParse =
        /// <summary>
        /// Advance the parse state by some amount. Will return the finished
        /// syntax tree when the parse completes.
        /// </summary>
        abstract member advance: unit -> LezerCommon.Tree option
        /// <summary>
        /// The position up to which the document has been parsed. Note
        /// that, in multi-pass parsers, this will stay back until the last
        /// pass has moved past a given position.
        /// </summary>
        abstract member parsedPos: float with get
        /// <summary>
        /// Tell the parse to not advance beyond the given position.
        /// <c>advance</c> will return a tree when the parse has reached the
        /// position. Note that, depending on the parser algorithm and the
        /// state of the parse when <c>stopAt</c> was called, that tree may
        /// contain nodes beyond the position. It is an error to call
        /// <c>stopAt</c> with a higher position than it's [current
        /// value](#common.PartialParse.stoppedAt).
        /// </summary>
        abstract member stopAt: pos: float -> unit
        /// <summary>
        /// Reports whether <c>stopAt</c> has been called on this parse.
        /// </summary>
        abstract member stoppedAt: float option with get

    /// <summary>
    /// A superclass that parsers should extend.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("Parser", "@lezer/common")>]
    type Parser =
        /// <summary>
        /// Start a parse for a single tree. This is the method concrete
        /// parser implementations must implement. Called by <c>startParse</c>,
        /// with the optional arguments resolved.
        /// </summary>
        abstract member createParse: input: LezerCommon.Input * fragments: ResizeArray<LezerCommon.TreeFragment> * ranges: ResizeArray<Parser.createParse.ranges.Item> -> LezerCommon.PartialParse
        /// <summary>
        /// Start a parse, returning a [partial parse](#common.PartialParse)
        /// object. [<c>fragments</c>](#common.TreeFragment) can be passed in to
        /// make the parse incremental.
        ///
        /// By default, the entire input is parsed. You can pass <c>ranges</c>,
        /// which should be a sorted array of non-empty, non-overlapping
        /// ranges, to parse only those ranges. The tree returned in that
        /// case will start at <c>ranges[0].from</c>.
        /// </summary>
        abstract member startParse: input: LezerCommon.Input * ?fragments: ResizeArray<LezerCommon.TreeFragment> * ?ranges: ResizeArray<Parser.startParse.ranges.Item> -> LezerCommon.PartialParse
        /// <summary>
        /// Start a parse, returning a [partial parse](#common.PartialParse)
        /// object. [<c>fragments</c>](#common.TreeFragment) can be passed in to
        /// make the parse incremental.
        ///
        /// By default, the entire input is parsed. You can pass <c>ranges</c>,
        /// which should be a sorted array of non-empty, non-overlapping
        /// ranges, to parse only those ranges. The tree returned in that
        /// case will start at <c>ranges[0].from</c>.
        /// </summary>
        abstract member startParse: input: string * ?fragments: ResizeArray<LezerCommon.TreeFragment> * ?ranges: ResizeArray<Parser.startParse.ranges.Item> -> LezerCommon.PartialParse
        /// <summary>
        /// Run a full parse, returning the resulting tree.
        /// </summary>
        abstract member parse: input: LezerCommon.Input * ?fragments: ResizeArray<LezerCommon.TreeFragment> * ?ranges: ResizeArray<Parser.parse.ranges.Item> -> LezerCommon.Tree
        /// <summary>
        /// Run a full parse, returning the resulting tree.
        /// </summary>
        abstract member parse: input: string * ?fragments: ResizeArray<LezerCommon.TreeFragment> * ?ranges: ResizeArray<Parser.parse.ranges.Item> -> LezerCommon.Tree

    /// <summary>
    /// This is the interface parsers use to access the document. To run
    /// Lezer directly on your own document data structure, you have to
    /// write an implementation of it.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type Input =
        /// <summary>
        /// The length of the document.
        /// </summary>
        abstract member length: float with get
        /// <summary>
        /// Get the chunk after the given position. The returned string
        /// should start at <c>from</c> and, if that isn't the end of the
        /// document, may be of any length greater than zero.
        /// </summary>
        abstract member chunk: from: float -> string
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
    /// Parse wrapper functions are supported by some parsers to inject
    /// additional parsing logic.
    /// </summary>
    type ParseWrapper =
        delegate of inner: LezerCommon.PartialParse * input: LezerCommon.Input * fragments: ResizeArray<LezerCommon.TreeFragment> * ranges: ResizeArray<ParseWrapper.ranges.Item> -> LezerCommon.PartialParse

    /// <summary>
    /// Each [node type](#common.NodeType) or [individual tree](#common.Tree)
    /// can have metadata associated with it in props. Instances of this
    /// class represent prop names.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("NodeProp", "@lezer/common")>]
    type NodeProp<'T> =
        /// <summary>
        /// Indicates whether this prop is stored per [node
        /// type](#common.NodeType) or per [tree node](#common.Tree).
        /// </summary>
        abstract member perNode: bool with get, set
        /// <summary>
        /// A method that deserializes a value of this prop from a string.
        /// Can be used to allow a prop to be directly written in a grammar
        /// file.
        /// </summary>
        abstract member deserialize: (string -> 'T) with get, set
        /// <summary>
        /// This is meant to be used with
        /// [<c>NodeSet.extend</c>](#common.NodeSet.extend) or
        /// [<c>LRParser.configure</c>](#lr.ParserConfig.props) to compute
        /// prop values for each node type in the set. Takes a [match
        /// object](#common.NodeType^match) or function that returns undefined
        /// if the node type doesn't get this prop, and the prop's value if
        /// it does.
        /// </summary>
        abstract member add: ``match``: NodeProp.add.``match``<'T> -> LezerCommon.NodePropSource
        /// <summary>
        /// This is meant to be used with
        /// [<c>NodeSet.extend</c>](#common.NodeSet.extend) or
        /// [<c>LRParser.configure</c>](#lr.ParserConfig.props) to compute
        /// prop values for each node type in the set. Takes a [match
        /// object](#common.NodeType^match) or function that returns undefined
        /// if the node type doesn't get this prop, and the prop's value if
        /// it does.
        /// </summary>
        abstract member add: ``match``: (LezerCommon.NodeType -> 'T option) -> LezerCommon.NodePropSource
        /// <summary>
        /// Prop that is used to describe matching delimiters. For opening
        /// delimiters, this holds an array of node names (written as a
        /// space-separated string when declaring this prop in a grammar)
        /// for the node types of closing delimiters that match it.
        /// </summary>
        [<Emit("""import { NodeProp } from "@lezer/common";
NodeProp.closedBy{{=$0}}""")>]
        static member inline closedBy
            with get () : LezerCommon.NodeProp<ReadonlyArray<string>> =
                nativeOnly
            and set (value: LezerCommon.NodeProp<ReadonlyArray<string>>) =
                nativeOnly
        /// <summary>
        /// The inverse of [<c>closedBy</c>](#common.NodeProp^closedBy). This is
        /// attached to closing delimiters, holding an array of node names
        /// of types of matching opening delimiters.
        /// </summary>
        [<Emit("""import { NodeProp } from "@lezer/common";
NodeProp.openedBy{{=$0}}""")>]
        static member inline openedBy
            with get () : LezerCommon.NodeProp<ReadonlyArray<string>> =
                nativeOnly
            and set (value: LezerCommon.NodeProp<ReadonlyArray<string>>) =
                nativeOnly
        /// <summary>
        /// Used to assign node types to groups (for example, all node
        /// types that represent an expression could be tagged with an
        /// <c>"Expression"</c> group).
        /// </summary>
        [<Emit("""import { NodeProp } from "@lezer/common";
NodeProp.group{{=$0}}""")>]
        static member inline group
            with get () : LezerCommon.NodeProp<ReadonlyArray<string>> =
                nativeOnly
            and set (value: LezerCommon.NodeProp<ReadonlyArray<string>>) =
                nativeOnly
        /// <summary>
        /// Attached to nodes to indicate these should be
        /// [displayed](https://codemirror.net/docs/ref/#language.syntaxTree)
        /// in a bidirectional text isolate, so that direction-neutral
        /// characters on their sides don't incorrectly get associated with
        /// surrounding text. You'll generally want to set this for nodes
        /// that contain arbitrary text, like strings and comments, and for
        /// nodes that appear _inside_ arbitrary text, like HTML tags. When
        /// not given a value, in a grammar declaration, defaults to
        /// <c>"auto"</c>.
        /// </summary>
        [<Emit("""import { NodeProp } from "@lezer/common";
NodeProp.isolate{{=$0}}""")>]
        static member inline isolate
            with get () : LezerCommon.NodeProp<NodeProp.isolate__> =
                nativeOnly
            and set (value: LezerCommon.NodeProp<NodeProp.isolate__>) =
                nativeOnly
        /// <summary>
        /// The hash of the [context](#lr.ContextTracker.constructor)
        /// that the node was parsed in, if any. Used to limit reuse of
        /// contextual nodes.
        /// </summary>
        [<Emit("""import { NodeProp } from "@lezer/common";
NodeProp.contextHash{{=$0}}""")>]
        static member inline contextHash
            with get () : LezerCommon.NodeProp<float> =
                nativeOnly
            and set (value: LezerCommon.NodeProp<float>) =
                nativeOnly
        /// <summary>
        /// The distance beyond the end of the node that the tokenizer
        /// looked ahead for any of the tokens inside the node. (The LR
        /// parser only stores this when it is larger than 25, for
        /// efficiency reasons.)
        /// </summary>
        [<Emit("""import { NodeProp } from "@lezer/common";
NodeProp.lookAhead{{=$0}}""")>]
        static member inline lookAhead
            with get () : LezerCommon.NodeProp<float> =
                nativeOnly
            and set (value: LezerCommon.NodeProp<float>) =
                nativeOnly
        /// <summary>
        /// This per-node prop is used to replace a given node, or part of a
        /// node, with another tree. This is useful to include trees from
        /// different languages in mixed-language parsers.
        /// </summary>
        [<Emit("""import { NodeProp } from "@lezer/common";
NodeProp.mounted{{=$0}}""")>]
        static member inline mounted
            with get () : LezerCommon.NodeProp<LezerCommon.MountedTree> =
                nativeOnly
            and set (value: LezerCommon.NodeProp<LezerCommon.MountedTree>) =
                nativeOnly

    /// <summary>
    /// A mounted tree, which can be [stored](#common.NodeProp^mounted) on
    /// a tree node to indicate that parts of its content are
    /// represented by another tree.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("MountedTree", "@lezer/common")>]
    type MountedTree =
        /// <summary>
        /// The inner tree.
        /// </summary>
        abstract member tree: LezerCommon.Tree with get
        /// <summary>
        /// If this is null, this tree replaces the entire node (it will
        /// be included in the regular iteration instead of its host
        /// node). If not, only the given ranges are considered to be
        /// covered by this tree. This is used for trees that are mixed in
        /// a way that isn't strictly hierarchical. Such mounted trees are
        /// only entered by [<c>resolveInner</c>](#common.Tree.resolveInner)
        /// and [<c>enter</c>](#common.SyntaxNode.enter).
        /// </summary>
        abstract member overlay: ReadonlyArray<MountedTree.overlay.Item> option with get
        /// <summary>
        /// The parser used to create this subtree.
        /// </summary>
        abstract member parser: LezerCommon.Parser with get
        /// <summary>
        /// [Indicates](#common.IterMode.EnterBracketed) that the nested
        /// content is delineated with some kind
        /// of bracket token.
        /// </summary>
        abstract member bracketed: bool with get

    /// <summary>
    /// Type returned by [<c>NodeProp.add</c>](#common.NodeProp.add). Describes
    /// whether a prop should be added to a given node type in a node set,
    /// and what value it should have.
    /// </summary>
    type NodePropSource =
        LezerCommon.NodeType -> LezerCommon.NodeProp<obj> * obj option

    /// <summary>
    /// Each node in a syntax tree has a node type associated with it.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("NodeType", "@lezer/common")>]
    type NodeType =
        /// <summary>
        /// The name of the node type. Not necessarily unique, but if the
        /// grammar was written properly, different node types with the
        /// same name within a node set should play the same semantic
        /// role.
        /// </summary>
        abstract member name: string with get
        /// <summary>
        /// The id of this node in its set. Corresponds to the term ids
        /// used in the parser.
        /// </summary>
        abstract member id: float with get
        /// <summary>
        /// Define a node type.
        /// </summary>
        [<Emit("""import { NodeType } from "@lezer/common";
NodeType.define($0)""")>]
        static member inline define (spec: NodeType.define__.spec): LezerCommon.NodeType = nativeOnly
        /// <summary>
        /// Retrieves a node prop for this type. Will return <c>undefined</c> if
        /// the prop isn't present on this node.
        /// </summary>
        abstract member prop<'T>: prop: LezerCommon.NodeProp<'T> -> 'T option
        /// <summary>
        /// True when this is the top node of a grammar.
        /// </summary>
        abstract member isTop: bool with get
        /// <summary>
        /// True when this node is produced by a skip rule.
        /// </summary>
        abstract member isSkipped: bool with get
        /// <summary>
        /// Indicates whether this is an error node.
        /// </summary>
        abstract member isError: bool with get
        /// <summary>
        /// When true, this node type doesn't correspond to a user-declared
        /// named node, for example because it is used to cache repetition.
        /// </summary>
        abstract member isAnonymous: bool with get
        /// <summary>
        /// Returns true when this node's name or one of its
        /// [groups](#common.NodeProp^group) matches the given string.
        /// </summary>
        abstract member is: name: string -> bool
        /// <summary>
        /// Returns true when this node's name or one of its
        /// [groups](#common.NodeProp^group) matches the given string.
        /// </summary>
        abstract member is: name: float -> bool
        /// <summary>
        /// An empty dummy node type to use when no actual type is available.
        /// </summary>
        [<Emit("""import { NodeType } from "@lezer/common";
NodeType.none{{=$0}}""")>]
        static member inline none
            with get () : LezerCommon.NodeType =
                nativeOnly
            and set (value: LezerCommon.NodeType) =
                nativeOnly
        /// <summary>
        /// Create a function from node types to arbitrary values by
        /// specifying an object whose property names are node or
        /// [group](#common.NodeProp^group) names. Often useful with
        /// [<c>NodeProp.add</c>](#common.NodeProp.add). You can put multiple
        /// names, separated by spaces, in a single property name to map
        /// multiple node names to a single value.
        /// </summary>
        [<Emit("""import { NodeType } from "@lezer/common";
NodeType.match($0)""")>]
        static member inline ``match`` (map: NodeType.match__.map<'T>): (LezerCommon.NodeType -> 'T option) = nativeOnly

    /// <summary>
    /// A node set holds a collection of node types. It is used to
    /// compactly represent trees by storing their type ids, rather than a
    /// full pointer to the type object, in a numeric array. Each parser
    /// [has](#lr.LRParser.nodeSet) a node set, and [tree
    /// buffers](#common.TreeBuffer) can only store collections of nodes
    /// from the same set. A set can have a maximum of 2**16 (65536) node
    /// types in it, so that the ids fit into 16-bit typed array slots.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("NodeSet", "@lezer/common")>]
    type NodeSet =
        /// <summary>
        /// The node types in this set, by id.
        /// </summary>
        abstract member types: ReadonlyArray<LezerCommon.NodeType> with get
        /// <summary>
        /// Create a copy of this set with some node properties added. The
        /// arguments to this method can be created with
        /// [<c>NodeProp.add</c>](#common.NodeProp.add).
        /// </summary>
        abstract member extend: [<ParamArray>] props: LezerCommon.NodePropSource [] -> LezerCommon.NodeSet

    [<RequireQualifiedAccess>]
    type IterMode =
        | ExcludeBuffers = 1
        | IncludeAnonymous = 2
        | IgnoreMounts = 4
        | IgnoreOverlays = 8
        | EnterBracketed = 16

    /// <summary>
    /// A piece of syntax tree. There are two ways to approach these
    /// trees: the way they are actually stored in memory, and the
    /// convenient way.
    ///
    /// Syntax trees are stored as a tree of <c>Tree</c> and <c>TreeBuffer</c>
    /// objects. By packing detail information into <c>TreeBuffer</c> leaf
    /// nodes, the representation is made a lot more memory-efficient.
    ///
    /// However, when you want to actually work with tree nodes, this
    /// representation is very awkward, so most client code will want to
    /// use the [<c>TreeCursor</c>](#common.TreeCursor) or
    /// [<c>SyntaxNode</c>](#common.SyntaxNode) interface instead, which provides
    /// a view on some part of this data structure, and can be used to
    /// move around to adjacent nodes.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("Tree", "@lezer/common")>]
    type Tree =
        /// <summary>
        /// The type of the top node.
        /// </summary>
        abstract member ``type``: LezerCommon.NodeType with get
        /// <summary>
        /// This node's child nodes.
        /// </summary>
        abstract member children: ReadonlyArray<U2<LezerCommon.Tree, LezerCommon.TreeBuffer>> with get
        /// <summary>
        /// The positions (offsets relative to the start of this tree) of
        /// the children.
        /// </summary>
        abstract member positions: ReadonlyArray<float> with get
        /// <summary>
        /// The total length of this tree
        /// </summary>
        abstract member length: float with get
        /// <summary>
        /// The empty tree
        /// </summary>
        [<Emit("""import { Tree } from "@lezer/common";
Tree.empty{{=$0}}""")>]
        static member inline empty
            with get () : LezerCommon.Tree =
                nativeOnly
            and set (value: LezerCommon.Tree) =
                nativeOnly
        /// <summary>
        /// Get a [tree cursor](#common.TreeCursor) positioned at the top of
        /// the tree. Mode can be used to [control](#common.IterMode) which
        /// nodes the cursor visits.
        /// </summary>
        abstract member cursor: ?mode: LezerCommon.IterMode -> LezerCommon.TreeCursor
        /// <summary>
        /// Get a [tree cursor](#common.TreeCursor) pointing into this tree
        /// at the given position and side (see
        /// [<c>moveTo</c>](#common.TreeCursor.moveTo).
        /// </summary>
        abstract member cursorAt: pos: float * ?side: Tree.cursorAt.side * ?mode: LezerCommon.IterMode -> LezerCommon.TreeCursor
        /// <summary>
        /// Get a [syntax node](#common.SyntaxNode) object for the top of the
        /// tree.
        /// </summary>
        abstract member topNode: LezerCommon.SyntaxNode with get
        /// <summary>
        /// Get the [syntax node](#common.SyntaxNode) at the given position.
        /// If <c>side</c> is -1, this will move into nodes that end at the
        /// position. If 1, it'll move into nodes that start at the
        /// position. With 0, it'll only enter nodes that cover the position
        /// from both sides.
        ///
        /// Note that this will not enter
        /// [overlays](#common.MountedTree.overlay), and you often want
        /// [<c>resolveInner</c>](#common.Tree.resolveInner) instead.
        /// </summary>
        abstract member resolve: pos: float * ?side: Tree.resolve.side -> LezerCommon.SyntaxNode
        /// <summary>
        /// Like [<c>resolve</c>](#common.Tree.resolve), but will enter
        /// [overlaid](#common.MountedTree.overlay) nodes, producing a syntax node
        /// pointing into the innermost overlaid tree at the given position
        /// (with parent links going through all parent structure, including
        /// the host trees).
        /// </summary>
        abstract member resolveInner: pos: float * ?side: Tree.resolveInner.side -> LezerCommon.SyntaxNode
        /// <summary>
        /// In some situations, it can be useful to iterate through all
        /// nodes around a position, including those in overlays that don't
        /// directly cover the position. This method gives you an iterator
        /// that will produce all nodes, from small to big, around the given
        /// position.
        /// </summary>
        abstract member resolveStack: pos: float * ?side: Tree.resolveStack.side -> LezerCommon.NodeIterator
        /// <summary>
        /// Iterate over the tree and its children, calling <c>enter</c> for any
        /// node that touches the <c>from</c>/<c>to</c> region (if given) before
        /// running over such a node's children, and <c>leave</c> (if given) when
        /// leaving the node. When <c>enter</c> returns <c>false</c>, that node will
        /// not have its children iterated over (or <c>leave</c> called).
        /// </summary>
        abstract member iterate: spec: Tree.iterate.spec -> unit
        /// <summary>
        /// Get the value of the given [node prop](#common.NodeProp) for this
        /// node. Works with both per-node and per-type props.
        /// </summary>
        abstract member prop<'T>: prop: LezerCommon.NodeProp<'T> -> 'T option
        /// <summary>
        /// Returns the node's [per-node props](#common.NodeProp.perNode) in a
        /// format that can be passed to the [<c>Tree</c>](#common.Tree)
        /// constructor.
        /// </summary>
        abstract member propValues: ReadonlyArray<U2<LezerCommon.NodeProp<obj>, float> * obj> with get
        /// <summary>
        /// Balance the direct children of this tree, producing a copy of
        /// which may have children grouped into subtrees with type
        /// [<c>NodeType.none</c>](#common.NodeType^none).
        /// </summary>
        abstract member balance: ?config: Tree.balance.config -> LezerCommon.Tree
        /// <summary>
        /// Build a tree from a postfix-ordered buffer of node information,
        /// or a cursor over such a buffer.
        /// </summary>
        [<Emit("""import { Tree } from "@lezer/common";
Tree.build($0)""")>]
        static member inline build (data: LezerCommon.BuildData): LezerCommon.Tree = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type NodeIterator =
        abstract member node: LezerCommon.SyntaxNode with get, set
        abstract member next: LezerCommon.NodeIterator option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (node: LezerCommon.SyntaxNode, ?next: LezerCommon.NodeIterator) : NodeIterator = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type BuildData =
        /// <summary>
        /// The buffer or buffer cursor to read the node data from.
        ///
        /// When this is an array, it should contain four values for every
        /// node in the tree.
        ///
        ///  - The first holds the node's type, as a node ID pointing into
        ///    the given <c>NodeSet</c>.
        ///  - The second holds the node's start offset.
        ///  - The third the end offset.
        ///  - The fourth the amount of space taken up in the array by this
        ///    node and its children. Since there's four values per node,
        ///    this is the total number of nodes inside this node (children
        ///    and transitive children) plus one for the node itself, times
        ///    four.
        ///
        /// Parent nodes should appear _after_ child nodes in the array. As
        /// an example, a node of type 10 spanning positions 0 to 4, with
        /// two children, of type 11 and 12, might look like this:
        ///
        ///     [11, 0, 1, 4, 12, 2, 4, 4, 10, 0, 4, 12]
        /// </summary>
        abstract member buffer: U2<LezerCommon.BufferCursor, ResizeArray<float>> with get, set
        /// <summary>
        /// The node types to use.
        /// </summary>
        abstract member nodeSet: LezerCommon.NodeSet with get, set
        /// <summary>
        /// The id of the top node type.
        /// </summary>
        abstract member topID: float with get, set
        /// <summary>
        /// The position the tree should start at. Defaults to 0.
        /// </summary>
        abstract member start: float option with get, set
        /// <summary>
        /// The position in the buffer where the function should stop
        /// reading. Defaults to 0.
        /// </summary>
        abstract member bufferStart: float option with get, set
        /// <summary>
        /// The length of the wrapping node. The end offset of the last
        /// child is used when not provided.
        /// </summary>
        abstract member length: float option with get, set
        /// <summary>
        /// The maximum buffer length to use. Defaults to
        /// [<c>DefaultBufferLength</c>](#common.DefaultBufferLength).
        /// </summary>
        abstract member maxBufferLength: float option with get, set
        /// <summary>
        /// An optional array holding reused nodes that the buffer can refer
        /// to.
        /// </summary>
        abstract member reused: ReadonlyArray<LezerCommon.Tree> option with get, set
        /// <summary>
        /// The first node type that indicates repeat constructs in this
        /// grammar.
        /// </summary>
        abstract member minRepeatType: float option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (buffer: LezerCommon.BufferCursor, nodeSet: LezerCommon.NodeSet, topID: float, ?start: float, ?bufferStart: float, ?length: float, ?maxBufferLength: float, ?reused: ResizeArray<LezerCommon.Tree>, ?minRepeatType: float) : BuildData = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (buffer: ResizeArray<float>, nodeSet: LezerCommon.NodeSet, topID: float, ?start: float, ?bufferStart: float, ?length: float, ?maxBufferLength: float, ?reused: ResizeArray<LezerCommon.Tree>, ?minRepeatType: float) : BuildData = nativeOnly

    /// <summary>
    /// This is used by <c>Tree.build</c> as an abstraction for iterating over
    /// a tree buffer. A cursor initially points at the very last element
    /// in the buffer. Every time <c>next()</c> is called it moves on to the
    /// previous one.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type BufferCursor =
        /// <summary>
        /// The current buffer position (four times the number of nodes
        /// remaining).
        /// </summary>
        abstract member pos: float with get, set
        /// <summary>
        /// The node ID of the next node in the buffer.
        /// </summary>
        abstract member id: float with get, set
        /// <summary>
        /// The start position of the next node in the buffer.
        /// </summary>
        abstract member start: float with get, set
        /// <summary>
        /// The end position of the next node.
        /// </summary>
        abstract member ``end``: float with get, set
        /// <summary>
        /// The size of the next node (the number of nodes inside, counting
        /// the node itself, times 4).
        /// </summary>
        abstract member size: float with get, set
        /// <summary>
        /// Moves <c>this.pos</c> down by 4.
        /// </summary>
        abstract member next: unit -> unit
        /// <summary>
        /// Create a copy of this cursor.
        /// </summary>
        abstract member fork: unit -> LezerCommon.BufferCursor

    /// <summary>
    /// Tree buffers contain (type, start, end, endIndex) quads for each
    /// node. In such a buffer, nodes are stored in prefix order (parents
    /// before children, with the endIndex of the parent indicating which
    /// children belong to it).
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("TreeBuffer", "@lezer/common")>]
    type TreeBuffer =
        /// <summary>
        /// The buffer's content.
        /// </summary>
        abstract member buffer: JS.Uint16Array with get
        /// <summary>
        /// The total length of the group of nodes in the buffer.
        /// </summary>
        abstract member length: float with get
        /// <summary>
        /// The node set used in this buffer.
        /// </summary>
        abstract member set: LezerCommon.NodeSet with get

    /// <summary>
    /// The set of properties provided by both [<c>SyntaxNode</c>](#common.SyntaxNode)
    /// and [<c>TreeCursor</c>](#common.TreeCursor). Note that, if you need
    /// an object that is guaranteed to stay stable in the future, you
    /// need to use the [<c>node</c>](#common.SyntaxNodeRef.node) accessor.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type SyntaxNodeRef =
        /// <summary>
        /// The start position of the node.
        /// </summary>
        abstract member from: float with get
        /// <summary>
        /// The end position of the node.
        /// </summary>
        abstract member ``to``: float with get
        /// <summary>
        /// The type of the node.
        /// </summary>
        abstract member ``type``: LezerCommon.NodeType with get
        /// <summary>
        /// The name of the node (<c>.type.name</c>).
        /// </summary>
        abstract member name: string with get
        /// <summary>
        /// Get the [tree](#common.Tree) that represents the current node,
        /// if any. Will return null when the node is in a [tree
        /// buffer](#common.TreeBuffer).
        /// </summary>
        abstract member tree: LezerCommon.Tree option with get
        /// <summary>
        /// Retrieve a stable [syntax node](#common.SyntaxNode) at this
        /// position.
        /// </summary>
        abstract member node: LezerCommon.SyntaxNode with get
        /// <summary>
        /// Test whether the node matches a given context—a sequence of
        /// direct parent nodes. Empty strings in the context array act as
        /// wildcards, other strings must match the ancestor node's name.
        /// </summary>
        abstract member matchContext: context: ResizeArray<string> -> bool

    /// <summary>
    /// A syntax node provides an immutable pointer to a given node in a
    /// tree. When iterating over large amounts of nodes, you may want to
    /// use a mutable [cursor](#common.TreeCursor) instead, which is more
    /// efficient.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type SyntaxNode =
        inherit LezerCommon.SyntaxNodeRef
        /// <summary>
        /// The node's parent node, if any.
        /// </summary>
        abstract member parent: LezerCommon.SyntaxNode option with get, set
        /// <summary>
        /// The first child, if the node has children.
        /// </summary>
        abstract member firstChild: LezerCommon.SyntaxNode option with get, set
        /// <summary>
        /// The node's last child, if available.
        /// </summary>
        abstract member lastChild: LezerCommon.SyntaxNode option with get, set
        /// <summary>
        /// The first child that ends after <c>pos</c>.
        /// </summary>
        abstract member childAfter: pos: float -> LezerCommon.SyntaxNode option
        /// <summary>
        /// The last child that starts before <c>pos</c>.
        /// </summary>
        abstract member childBefore: pos: float -> LezerCommon.SyntaxNode option
        /// <summary>
        /// Enter the child at the given position. If side is -1 the child
        /// may end at that position, when 1 it may start there.
        ///
        /// This will by default enter
        /// [overlaid](#common.MountedTree.overlay)
        /// [mounted](#common.NodeProp^mounted) trees. You can set
        /// <c>overlays</c> to false to disable that.
        ///
        /// Similarly, when <c>buffers</c> is false this will not enter
        /// [buffers](#common.TreeBuffer), only [nodes](#common.Tree) (which
        /// is mostly useful when looking for props, which cannot exist on
        /// buffer-allocated nodes).
        /// </summary>
        abstract member enter: pos: float * side: SyntaxNode.enter.side * ?mode: LezerCommon.IterMode -> LezerCommon.SyntaxNode option
        /// <summary>
        /// This node's next sibling, if any.
        /// </summary>
        abstract member nextSibling: LezerCommon.SyntaxNode option with get, set
        /// <summary>
        /// This node's previous sibling.
        /// </summary>
        abstract member prevSibling: LezerCommon.SyntaxNode option with get, set
        /// <summary>
        /// Read the given node prop from this node.
        /// </summary>
        abstract member prop<'T>: prop: LezerCommon.NodeProp<'T> -> 'T option
        /// <summary>
        /// A [tree cursor](#common.TreeCursor) starting at this node.
        /// </summary>
        abstract member cursor: ?mode: LezerCommon.IterMode -> LezerCommon.TreeCursor
        /// <summary>
        /// Find the node around, before (if <c>side</c> is -1), or after (<c>side</c>
        /// is 1) the given position. Will look in parent nodes if the
        /// position is outside this node.
        /// </summary>
        abstract member resolve: pos: float * ?side: SyntaxNode.resolve.side -> LezerCommon.SyntaxNode
        /// <summary>
        /// Similar to <c>resolve</c>, but enter
        /// [overlaid](#common.MountedTree.overlay) nodes.
        /// </summary>
        abstract member resolveInner: pos: float * ?side: SyntaxNode.resolveInner.side -> LezerCommon.SyntaxNode
        /// <summary>
        /// Move the position to the innermost node before <c>pos</c> that looks
        /// like it is unfinished (meaning it ends in an error node or has a
        /// child ending in an error node right at its end).
        /// </summary>
        abstract member enterUnfinishedNodesBefore: pos: float -> LezerCommon.SyntaxNode
        /// <summary>
        /// Get a [tree](#common.Tree) for this node. Will allocate one if it
        /// points into a buffer.
        /// </summary>
        abstract member toTree: unit -> LezerCommon.Tree
        /// <summary>
        /// Get the first child of the given type (which may be a [node
        /// name](#common.NodeType.name) or a [group
        /// name](#common.NodeProp^group)). If <c>before</c> is non-null, only
        /// return children that occur somewhere after a node with that name
        /// or group. If <c>after</c> is non-null, only return children that
        /// occur somewhere before a node with that name or group.
        /// </summary>
        abstract member getChild: ``type``: string -> LezerCommon.SyntaxNode option
        /// <summary>
        /// Get the first child of the given type (which may be a [node
        /// name](#common.NodeType.name) or a [group
        /// name](#common.NodeProp^group)). If <c>before</c> is non-null, only
        /// return children that occur somewhere after a node with that name
        /// or group. If <c>after</c> is non-null, only return children that
        /// occur somewhere before a node with that name or group.
        /// </summary>
        abstract member getChild: ``type``: string * before: string * ?after: U2<string, float> -> LezerCommon.SyntaxNode option
        /// <summary>
        /// Get the first child of the given type (which may be a [node
        /// name](#common.NodeType.name) or a [group
        /// name](#common.NodeProp^group)). If <c>before</c> is non-null, only
        /// return children that occur somewhere after a node with that name
        /// or group. If <c>after</c> is non-null, only return children that
        /// occur somewhere before a node with that name or group.
        /// </summary>
        abstract member getChild: ``type``: string * before: float * ?after: U2<string, float> -> LezerCommon.SyntaxNode option
        /// <summary>
        /// Get the first child of the given type (which may be a [node
        /// name](#common.NodeType.name) or a [group
        /// name](#common.NodeProp^group)). If <c>before</c> is non-null, only
        /// return children that occur somewhere after a node with that name
        /// or group. If <c>after</c> is non-null, only return children that
        /// occur somewhere before a node with that name or group.
        /// </summary>
        abstract member getChild: ``type``: float -> LezerCommon.SyntaxNode option
        /// <summary>
        /// Get the first child of the given type (which may be a [node
        /// name](#common.NodeType.name) or a [group
        /// name](#common.NodeProp^group)). If <c>before</c> is non-null, only
        /// return children that occur somewhere after a node with that name
        /// or group. If <c>after</c> is non-null, only return children that
        /// occur somewhere before a node with that name or group.
        /// </summary>
        abstract member getChild: ``type``: float * before: string * ?after: U2<string, float> -> LezerCommon.SyntaxNode option
        /// <summary>
        /// Get the first child of the given type (which may be a [node
        /// name](#common.NodeType.name) or a [group
        /// name](#common.NodeProp^group)). If <c>before</c> is non-null, only
        /// return children that occur somewhere after a node with that name
        /// or group. If <c>after</c> is non-null, only return children that
        /// occur somewhere before a node with that name or group.
        /// </summary>
        abstract member getChild: ``type``: float * before: float * ?after: U2<string, float> -> LezerCommon.SyntaxNode option
        /// <summary>
        /// Like [<c>getChild</c>](#common.SyntaxNode.getChild), but return all
        /// matching children, not just the first.
        /// </summary>
        abstract member getChildren: ``type``: string -> ResizeArray<LezerCommon.SyntaxNode>
        /// <summary>
        /// Like [<c>getChild</c>](#common.SyntaxNode.getChild), but return all
        /// matching children, not just the first.
        /// </summary>
        abstract member getChildren: ``type``: string * before: string * ?after: U2<string, float> -> ResizeArray<LezerCommon.SyntaxNode>
        /// <summary>
        /// Like [<c>getChild</c>](#common.SyntaxNode.getChild), but return all
        /// matching children, not just the first.
        /// </summary>
        abstract member getChildren: ``type``: string * before: float * ?after: U2<string, float> -> ResizeArray<LezerCommon.SyntaxNode>
        /// <summary>
        /// Like [<c>getChild</c>](#common.SyntaxNode.getChild), but return all
        /// matching children, not just the first.
        /// </summary>
        abstract member getChildren: ``type``: float -> ResizeArray<LezerCommon.SyntaxNode>
        /// <summary>
        /// Like [<c>getChild</c>](#common.SyntaxNode.getChild), but return all
        /// matching children, not just the first.
        /// </summary>
        abstract member getChildren: ``type``: float * before: string * ?after: U2<string, float> -> ResizeArray<LezerCommon.SyntaxNode>
        /// <summary>
        /// Like [<c>getChild</c>](#common.SyntaxNode.getChild), but return all
        /// matching children, not just the first.
        /// </summary>
        abstract member getChildren: ``type``: float * before: float * ?after: U2<string, float> -> ResizeArray<LezerCommon.SyntaxNode>

    /// <summary>
    /// A tree cursor object focuses on a given node in a syntax tree, and
    /// allows you to move to adjacent nodes.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("TreeCursor", "@lezer/common")>]
    type TreeCursor =
        inherit LezerCommon.SyntaxNodeRef
        /// <summary>
        /// The node's type.
        /// </summary>
        abstract member ``type``: LezerCommon.NodeType with get, set
        /// <summary>
        /// Shorthand for <c>.type.name</c>.
        /// </summary>
        abstract member name: string with get
        /// <summary>
        /// The start source offset of this node.
        /// </summary>
        abstract member from: float with get, set
        /// <summary>
        /// The end source offset.
        /// </summary>
        abstract member ``to``: float with get, set
        /// <summary>
        /// Move the cursor to this node's first child. When this returns
        /// false, the node has no child, and the cursor has not been moved.
        /// </summary>
        abstract member firstChild: unit -> bool
        /// <summary>
        /// Move the cursor to this node's last child.
        /// </summary>
        abstract member lastChild: unit -> bool
        /// <summary>
        /// Move the cursor to the first child that ends after <c>pos</c>.
        /// </summary>
        abstract member childAfter: pos: float -> bool
        /// <summary>
        /// Move to the last child that starts before <c>pos</c>.
        /// </summary>
        abstract member childBefore: pos: float -> bool
        /// <summary>
        /// Move the cursor to the child around <c>pos</c>. If side is -1 the
        /// child may end at that position, when 1 it may start there. This
        /// will also enter [overlaid](#common.MountedTree.overlay)
        /// [mounted](#common.NodeProp^mounted) trees unless <c>overlays</c> is
        /// set to false.
        /// </summary>
        abstract member enter: pos: float * side: TreeCursor.enter.side * ?mode: LezerCommon.IterMode -> bool
        /// <summary>
        /// Move to the node's parent node, if this isn't the top node.
        /// </summary>
        abstract member parent: unit -> bool
        /// <summary>
        /// Move to this node's next sibling, if any.
        /// </summary>
        abstract member nextSibling: unit -> bool
        /// <summary>
        /// Move to this node's previous sibling, if any.
        /// </summary>
        abstract member prevSibling: unit -> bool
        /// <summary>
        /// Move to the next node in a
        /// [pre-order](https://en.wikipedia.org/wiki/Tree_traversal#Pre-order,_NLR)
        /// traversal, going from a node to its first child or, if the
        /// current node is empty or <c>enter</c> is false, its next sibling or
        /// the next sibling of the first parent node that has one.
        /// </summary>
        abstract member next: ?enter: bool -> bool
        /// <summary>
        /// Move to the next node in a last-to-first pre-order traversal. A
        /// node is followed by its last child or, if it has none, its
        /// previous sibling or the previous sibling of the first parent
        /// node that has one.
        /// </summary>
        abstract member prev: ?enter: bool -> bool
        /// <summary>
        /// Move the cursor to the innermost node that covers <c>pos</c>. If
        /// <c>side</c> is -1, it will enter nodes that end at <c>pos</c>. If it is 1,
        /// it will enter nodes that start at <c>pos</c>.
        /// </summary>
        abstract member moveTo: pos: float * ?side: TreeCursor.moveTo.side -> TreeCursor
        /// <summary>
        /// Get a [syntax node](#common.SyntaxNode) at the cursor's current
        /// position.
        /// </summary>
        abstract member node: LezerCommon.SyntaxNode with get
        /// <summary>
        /// Get the [tree](#common.Tree) that represents the current node, if
        /// any. Will return null when the node is in a [tree
        /// buffer](#common.TreeBuffer).
        /// </summary>
        abstract member tree: LezerCommon.Tree option with get
        /// <summary>
        /// Iterate over the current node and all its descendants, calling
        /// <c>enter</c> when entering a node and <c>leave</c>, if given, when leaving
        /// one. When <c>enter</c> returns <c>false</c>, any children of that node are
        /// skipped, and <c>leave</c> isn't called for it.
        /// </summary>
        abstract member iterate: enter: (LezerCommon.SyntaxNodeRef -> U2<bool, unit>) * ?leave: (LezerCommon.SyntaxNodeRef -> unit) -> unit
        /// <summary>
        /// Test whether the current node matches a given context—a sequence
        /// of direct parent node names. Empty strings in the context array
        /// are treated as wildcards.
        /// </summary>
        abstract member matchContext: context: ResizeArray<string> -> bool

    /// <summary>
    /// Provides a way to associate values with pieces of trees. As long
    /// as that part of the tree is reused, the associated values can be
    /// retrieved from an updated tree.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    [<Import("NodeWeakMap", "@lezer/common")>]
    type NodeWeakMap<'T> =
        /// <summary>
        /// Set the value for this syntax node.
        /// </summary>
        abstract member set: node: LezerCommon.SyntaxNode * value: 'T -> unit
        /// <summary>
        /// Retrieve value for this syntax node, if it exists in the map.
        /// </summary>
        abstract member get: node: LezerCommon.SyntaxNode -> 'T option
        /// <summary>
        /// Set the value for the node that a cursor currently points to.
        /// </summary>
        abstract member cursorSet: cursor: LezerCommon.TreeCursor * value: 'T -> unit
        /// <summary>
        /// Retrieve the value for the node that a cursor currently points
        /// to.
        /// </summary>
        abstract member cursorGet: cursor: LezerCommon.TreeCursor -> 'T option

    /// <summary>
    /// Objects returned by the function passed to
    /// [<c>parseMixed</c>](#common.parseMixed) should conform to this
    /// interface.
    /// </summary>
    [<AllowNullLiteral>]
    [<Interface>]
    type NestedParse =
        /// <summary>
        /// The parser to use for the inner region.
        /// </summary>
        abstract member parser: LezerCommon.Parser with get, set
        /// <summary>
        /// When this property is not given, the entire node is parsed with
        /// this parser, and it is [mounted](#common.NodeProp^mounted) as a
        /// non-overlay node, replacing its host node in tree iteration.
        ///
        /// When an array of ranges is given, only those ranges are parsed,
        /// and the tree is mounted as an
        /// [overlay](#common.MountedTree.overlay).
        ///
        /// When a function is given, that function will be called for
        /// descendant nodes of the target node, not including child nodes
        /// that are covered by another nested parse, to determine the
        /// overlay ranges. When it returns true, the entire descendant is
        /// included, otherwise just the range given. The mixed parser will
        /// optimize range-finding in reused nodes, which means it's a good
        /// idea to use a function here when the target node is expected to
        /// have a large, deep structure.
        /// </summary>
        abstract member overlay: U2<ResizeArray<NestedParse.overlay.U2.Case1.Item>, (LezerCommon.SyntaxNodeRef -> U2<NestedParse.overlay.U2.Case2.U2.Case1, bool>)> option with get, set
        /// <summary>
        /// When <c>true</c>, indicates that this nested language is surrounded
        /// by some kind of bracket token, which can be used to make
        /// iteration [eagerly](#common.IterMode.EnterBracketed) enter such
        /// trees.
        /// </summary>
        abstract member bracketed: bool option with get, set
        [<ParamObject; Emit("$0")>]
        static member Create (parser: LezerCommon.Parser, ?bracketed: bool) : NestedParse = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (parser: LezerCommon.Parser, overlay: ResizeArray<NestedParse.overlay.U2.Case1.Item>, ?bracketed: bool) : NestedParse = nativeOnly
        [<ParamObject; Emit("$0")>]
        static member Create (parser: LezerCommon.Parser, overlay: (LezerCommon.SyntaxNodeRef -> U2<NestedParse.overlay.U2.Case2.U2.Case1, bool>), ?bracketed: bool) : NestedParse = nativeOnly

    module Parser =

        module createParse =

            module ranges =

                [<AllowNullLiteral>]
                [<Interface>]
                type Item =
                    abstract member from: float with get, set
                    abstract member ``to``: float with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (from: float, ``to``: float) : Item = nativeOnly

        module startParse =

            module ranges =

                [<AllowNullLiteral>]
                [<Interface>]
                type Item =
                    abstract member from: float with get, set
                    abstract member ``to``: float with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (from: float, ``to``: float) : Item = nativeOnly

        module parse =

            module ranges =

                [<AllowNullLiteral>]
                [<Interface>]
                type Item =
                    abstract member from: float with get, set
                    abstract member ``to``: float with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (from: float, ``to``: float) : Item = nativeOnly

    module ParseWrapper =

        module ranges =

            [<AllowNullLiteral>]
            [<Interface>]
            type Item =
                abstract member from: float with get, set
                abstract member ``to``: float with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (from: float, ``to``: float) : Item = nativeOnly

    module NodeProp =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type isolate__ =
            | rtl
            | ltr
            | auto

        module add =

            [<AllowNullLiteral>]
            [<Interface>]
            type ``match``<'T> =
                [<EmitIndexer>]
                abstract member Item: selector: string -> 'T with get, set

    module MountedTree =

        module overlay =

            [<AllowNullLiteral>]
            [<Interface>]
            type Item =
                abstract member from: float with get, set
                abstract member ``to``: float with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (from: float, ``to``: float) : Item = nativeOnly

    module NodeType =

        module define__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type spec =
                /// <summary>
                /// The ID of the node type. When this type is used in a
                /// [set](#common.NodeSet), the ID must correspond to its index in
                /// the type array.
                /// </summary>
                abstract member id: float with get, set
                /// <summary>
                /// The name of the node type. Leave empty to define an anonymous
                /// node.
                /// </summary>
                abstract member name: string option with get, set
                /// <summary>
                /// [Node props](#common.NodeProp) to assign to the type. The value
                /// given for any given prop should correspond to the prop's type.
                /// </summary>
                abstract member props: ReadonlyArray<U2<LezerCommon.NodeProp<obj> * obj, LezerCommon.NodePropSource>> option with get, set
                /// <summary>
                /// Whether this is a [top node](#common.NodeType.isTop).
                /// </summary>
                abstract member top: bool option with get, set
                /// <summary>
                /// Whether this node counts as an [error
                /// node](#common.NodeType.isError).
                /// </summary>
                abstract member error: bool option with get, set
                /// <summary>
                /// Whether this node is a [skipped](#common.NodeType.isSkipped)
                /// node.
                /// </summary>
                abstract member skipped: bool option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (id: float, ?name: string, ?props: ResizeArray<U2<LezerCommon.NodeProp<obj> * obj, LezerCommon.NodePropSource>>, ?top: bool, ?error: bool, ?skipped: bool) : spec = nativeOnly

        module match__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type map<'T> =
                [<EmitIndexer>]
                abstract member Item: selector: string -> 'T with get, set

    module Tree =

        module cursorAt =

            [<RequireQualifiedAccess>]
            type side =
                | _MINUS_1 = -1
                | ``0`` = 0
                | ``1`` = 1

        module resolve =

            [<RequireQualifiedAccess>]
            type side =
                | _MINUS_1 = -1
                | ``0`` = 0
                | ``1`` = 1

        module resolveInner =

            [<RequireQualifiedAccess>]
            type side =
                | _MINUS_1 = -1
                | ``0`` = 0
                | ``1`` = 1

        module resolveStack =

            [<RequireQualifiedAccess>]
            type side =
                | _MINUS_1 = -1
                | ``0`` = 0
                | ``1`` = 1

        module iterate =

            [<AllowNullLiteral>]
            [<Interface>]
            type spec =
                abstract member enter: node: LezerCommon.SyntaxNodeRef -> U2<bool, unit>
                abstract member leave: (LezerCommon.SyntaxNodeRef -> unit) option with get, set
                abstract member from: float option with get, set
                abstract member ``to``: float option with get, set
                abstract member mode: LezerCommon.IterMode option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (enter: (LezerCommon.SyntaxNodeRef -> U2<bool, unit>), ?leave: (LezerCommon.SyntaxNodeRef -> unit), ?from: float, ?``to``: float, ?mode: LezerCommon.IterMode) : spec = nativeOnly

        module balance =

            [<AllowNullLiteral>]
            [<Interface>]
            type config =
                /// <summary>
                /// Function to create the newly balanced subtrees.
                /// </summary>
                abstract member makeTree: Tree.balance.config.makeTree option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?makeTree: Tree.balance.config.makeTree) : config = nativeOnly

            module config =

                type makeTree =
                    delegate of children: ResizeArray<U2<LezerCommon.Tree, LezerCommon.TreeBuffer>> * positions: ResizeArray<float> * length: float -> LezerCommon.Tree

    module SyntaxNode =

        module enter =

            [<RequireQualifiedAccess>]
            type side =
                | _MINUS_1 = -1
                | ``0`` = 0
                | ``1`` = 1

        module resolve =

            [<RequireQualifiedAccess>]
            type side =
                | _MINUS_1 = -1
                | ``0`` = 0
                | ``1`` = 1

        module resolveInner =

            [<RequireQualifiedAccess>]
            type side =
                | _MINUS_1 = -1
                | ``0`` = 0
                | ``1`` = 1

    module TreeCursor =

        module enter =

            [<RequireQualifiedAccess>]
            type side =
                | _MINUS_1 = -1
                | ``0`` = 0
                | ``1`` = 1

        module moveTo =

            [<RequireQualifiedAccess>]
            type side =
                | _MINUS_1 = -1
                | ``0`` = 0
                | ``1`` = 1

    module NestedParse =

        module overlay =

            module U2 =

                module Case1 =

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type Item =
                        abstract member from: float with get, set
                        abstract member ``to``: float with get, set
                        [<ParamObject; Emit("$0")>]
                        static member Create (from: float, ``to``: float) : Item = nativeOnly

                module Case2 =

                    module U2 =

                        [<AllowNullLiteral>]
                        [<Interface>]
                        type Case1 =
                            abstract member from: float with get, set
                            abstract member ``to``: float with get, set
                            [<ParamObject; Emit("$0")>]
                            static member Create (from: float, ``to``: float) : Case1 = nativeOnly

    module Exports =

        module parseMixed__ =

            type nest =
                delegate of node: LezerCommon.SyntaxNodeRef * input: LezerCommon.Input -> LezerCommon.NestedParse option

        module NodeProp =

            [<AllowNullLiteral>]
            [<Interface>]
            type config<'T> =
                /// <summary>
                /// The [deserialize](#common.NodeProp.deserialize) function to
                /// use for this prop, used for example when directly providing
                /// the prop from a grammar file. Defaults to a function that
                /// raises an error.
                /// </summary>
                abstract member deserialize: (string -> 'T) option with get, set
                /// <summary>
                /// If configuring another value for this prop when it already
                /// exists on a node should combine the old and new values, rather
                /// than overwrite the old value, you can pass a function that
                /// does the combining here.
                /// </summary>
                abstract member combine: Exports.NodeProp.config.combine<'T> option with get, set
                /// <summary>
                /// By default, node props are stored in the [node
                /// type](#common.NodeType). It can sometimes be useful to directly
                /// store information (usually related to the parsing algorithm)
                /// in [nodes](#common.Tree) themselves. Set this to true to enable
                /// that for this prop.
                /// </summary>
                abstract member perNode: bool option with get, set
                [<ParamObject; Emit("$0")>]
                static member Create (?deserialize: (string -> 'T), ?combine: Exports.NodeProp.config.combine<'T>, ?perNode: bool) : config<'T> = nativeOnly

            module config =

                type combine<'T> =
                    delegate of a: 'T * b: 'T -> 'T

        module MountedTree =

            module overlay =

                [<AllowNullLiteral>]
                [<Interface>]
                type Item =
                    abstract member from: float with get, set
                    abstract member ``to``: float with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (from: float, ``to``: float) : Item = nativeOnly
