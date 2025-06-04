namespace UnityEngine.ProBuilder;

[DefaultMember("Item")]
public sealed class Face
{
	[FormerlySerializedAs("_indices")]
	[SerializeField]
	private Int32[] m_Indexes; //Field offset: 0x10
	[FormerlySerializedAs("_smoothingGroup")]
	[SerializeField]
	private int m_SmoothingGroup; //Field offset: 0x18
	[FormerlySerializedAs("_uv")]
	[SerializeField]
	private AutoUnwrapSettings m_Uv; //Field offset: 0x1C
	[FormerlySerializedAs("_mat")]
	[SerializeField]
	private Material m_Material; //Field offset: 0x40
	[SerializeField]
	private int m_SubmeshIndex; //Field offset: 0x48
	[FormerlySerializedAs("manualUV")]
	[SerializeField]
	private bool m_ManualUV; //Field offset: 0x4C
	[SerializeField]
	internal int elementGroup; //Field offset: 0x50
	[SerializeField]
	private int m_TextureGroup; //Field offset: 0x54
	private Int32[] m_DistinctIndexes; //Field offset: 0x58
	private Edge[] m_Edges; //Field offset: 0x60

	public ReadOnlyCollection<Int32> distinctIndexes
	{
		 get { } //Length: 140
	}

	internal Int32[] distinctIndexesInternal
	{
		internal get { } //Length: 20
	}

	public ReadOnlyCollection<Edge> edges
	{
		 get { } //Length: 140
	}

	internal Edge[] edgesInternal
	{
		internal get { } //Length: 20
	}

	public ReadOnlyCollection<Int32> indexes
	{
		 get { } //Length: 124
	}

	internal Int32[] indexesInternal
	{
		internal get { } //Length: 8
		internal set { } //Length: 188
	}

	public int Item
	{
		 get { } //Length: 48
	}

	public bool manualUV
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	[Obsolete("Face.material is deprecated. Please use submeshIndex instead.")]
	public Material material
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public int smoothingGroup
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public int submeshIndex
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public int textureGroup
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public AutoUnwrapSettings uv
	{
		 get { } //Length: 16
		 set { } //Length: 16
	}

	public Face(Face other) { }

	internal Face(IEnumerable<Int32> triangles, int submeshIndex, AutoUnwrapSettings u, int smoothing, int texture, int element, bool manualUVs) { }

	[Obsolete("Face.material is deprecated. Please use \"submeshIndex\" instead.")]
	internal Face(Int32[] triangles, Material m, AutoUnwrapSettings u, int smoothing, int texture, int element, bool manualUVs) { }

	public Face(IEnumerable<Int32> indices) { }

	public Face() { }

	private Int32[] CacheDistinctIndexes() { }

	private Edge[] CacheEdges() { }

	public bool Contains(int a, int b, int c) { }

	public void CopyFrom(Face other) { }

	public ReadOnlyCollection<Int32> get_distinctIndexes() { }

	internal Int32[] get_distinctIndexesInternal() { }

	public ReadOnlyCollection<Edge> get_edges() { }

	internal Edge[] get_edgesInternal() { }

	public ReadOnlyCollection<Int32> get_indexes() { }

	internal Int32[] get_indexesInternal() { }

	public int get_Item(int i) { }

	public bool get_manualUV() { }

	public Material get_material() { }

	public int get_smoothingGroup() { }

	public int get_submeshIndex() { }

	public int get_textureGroup() { }

	public AutoUnwrapSettings get_uv() { }

	internal static void GetDistinctIndices(IEnumerable<Face> faces, List<Int32> indices) { }

	internal static void GetIndices(IEnumerable<Face> faces, List<Int32> indices) { }

	internal void InvalidateCache() { }

	public bool IsQuad() { }

	public void Reverse() { }

	internal void set_indexesInternal(Int32[] value) { }

	public void set_manualUV(bool value) { }

	public void set_material(Material value) { }

	public void set_smoothingGroup(int value) { }

	public void set_submeshIndex(int value) { }

	public void set_textureGroup(int value) { }

	public void set_uv(AutoUnwrapSettings value) { }

	public void SetIndexes(IEnumerable<Int32> indices) { }

	public void ShiftIndexes(int offset) { }

	public void ShiftIndexesToZero() { }

	private int SmallestIndexValue() { }

	public Int32[] ToQuad() { }

	public virtual string ToString() { }

	internal bool TryGetNextEdge(Edge source, int index, ref Edge nextEdge, ref int nextIndex) { }

}

