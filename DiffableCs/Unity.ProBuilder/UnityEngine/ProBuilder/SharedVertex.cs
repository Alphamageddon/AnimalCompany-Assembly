namespace UnityEngine.ProBuilder;

[DefaultMember("Item")]
public sealed class SharedVertex : ICollection<Int32>, IEnumerable<Int32>, IEnumerable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<KeyValuePair`2<Int32, Int32>, Boolean> <>9__26_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <SortedRemoveAndShift>b__26_0(KeyValuePair<Int32, Int32> x) { }

	}

	[FormerlySerializedAs("array")]
	[FormerlySerializedAs("m_Vertexes")]
	[SerializeField]
	private Int32[] m_Vertices; //Field offset: 0x10

	internal Int32[] arrayInternal
	{
		internal get { } //Length: 8
	}

	public override int Count
	{
		 get { } //Length: 28
	}

	public override bool IsReadOnly
	{
		 get { } //Length: 28
	}

	public int Item
	{
		 get { } //Length: 48
		 set { } //Length: 48
	}

	public SharedVertex(IEnumerable<Int32> indexes) { }

	public SharedVertex(SharedVertex sharedVertex) { }

	public override void Add(int item) { }

	public override void Clear() { }

	public override bool Contains(int item) { }

	public override void CopyTo(Int32[] array, int arrayIndex) { }

	internal Int32[] get_arrayInternal() { }

	public override int get_Count() { }

	public override bool get_IsReadOnly() { }

	public int get_Item(int i) { }

	public override IEnumerator<Int32> GetEnumerator() { }

	public static void GetSharedVertexLookup(IList<SharedVertex> sharedVertices, Dictionary<Int32, Int32> lookup) { }

	public static SharedVertex[] GetSharedVerticesWithPositions(IList<Vector3> positions) { }

	public override bool Remove(int item) { }

	internal static SharedVertex[] RemoveAndShift(Dictionary<Int32, Int32> lookup, IEnumerable<Int32> remove) { }

	public void set_Item(int i, int value) { }

	internal static void SetCoincident(ref Dictionary<Int32, Int32>& lookup, IEnumerable<Int32> vertices) { }

	internal void ShiftIndexes(int offset) { }

	internal static SharedVertex[] SortedRemoveAndShift(Dictionary<Int32, Int32> lookup, List<Int32> remove) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	internal static SharedVertex[] ToSharedVertices(IEnumerable<KeyValuePair`2<Int32, Int32>> lookup) { }

	private static SharedVertex[] ToSharedVertices(List<List`1<Int32>> list) { }

	public virtual string ToString() { }

}

