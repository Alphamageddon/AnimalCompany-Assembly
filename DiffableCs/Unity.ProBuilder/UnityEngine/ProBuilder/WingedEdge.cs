namespace UnityEngine.ProBuilder;

public sealed class WingedEdge : IEquatable<WingedEdge>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<WingedEdge, Edge> <>9__32_1; //Field offset: 0x8
		public static Converter<Edge, Int32> <>9__32_2; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal Edge <SortCommonIndexesByAdjacency>b__32_1(WingedEdge y) { }

		internal int <SortCommonIndexesByAdjacency>b__32_2(Edge x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass32_0
	{
		public HashSet<Int32> common; //Field offset: 0x10

		public <>c__DisplayClass32_0() { }

		internal bool <SortCommonIndexesByAdjacency>b__0(WingedEdge x) { }

	}

	private static readonly Dictionary<Edge, WingedEdge> k_OppositeEdgeDictionary; //Field offset: 0x0
	[CompilerGenerated]
	private EdgeLookup <edge>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private Face <face>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private WingedEdge <next>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private WingedEdge <previous>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private WingedEdge <opposite>k__BackingField; //Field offset: 0x38

	public private EdgeLookup edge
	{
		[CompilerGenerated]
		 get { } //Length: 12
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private Face face
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private WingedEdge next
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private WingedEdge opposite
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private WingedEdge previous
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	private static WingedEdge() { }

	private WingedEdge() { }

	public int Count() { }

	public override bool Equals(WingedEdge other) { }

	public virtual bool Equals(object obj) { }

	[CompilerGenerated]
	public EdgeLookup get_edge() { }

	[CompilerGenerated]
	public Face get_face() { }

	[CompilerGenerated]
	public WingedEdge get_next() { }

	[CompilerGenerated]
	public WingedEdge get_opposite() { }

	[CompilerGenerated]
	public WingedEdge get_previous() { }

	public WingedEdge GetAdjacentEdgeWithCommonIndex(int common) { }

	public virtual int GetHashCode() { }

	public static Dictionary<Int32, List`1<WingedEdge>> GetSpokes(List<WingedEdge> wings) { }

	public static List<WingedEdge> GetWingedEdges(ProBuilderMesh mesh, bool oneWingPerFace = false) { }

	public static List<WingedEdge> GetWingedEdges(ProBuilderMesh mesh, IEnumerable<Face> faces, bool oneWingPerFace = false) { }

	internal static Int32[] MakeQuad(WingedEdge left, WingedEdge right) { }

	[CompilerGenerated]
	private void set_edge(EdgeLookup value) { }

	[CompilerGenerated]
	private void set_face(Face value) { }

	[CompilerGenerated]
	private void set_next(WingedEdge value) { }

	[CompilerGenerated]
	private void set_opposite(WingedEdge value) { }

	[CompilerGenerated]
	private void set_previous(WingedEdge value) { }

	internal static List<Int32> SortCommonIndexesByAdjacency(List<WingedEdge> wings, HashSet<Int32> common) { }

	public static List<Edge> SortEdgesByAdjacency(Face face) { }

	public static void SortEdgesByAdjacency(List<Edge> edges) { }

	public virtual string ToString() { }

}

