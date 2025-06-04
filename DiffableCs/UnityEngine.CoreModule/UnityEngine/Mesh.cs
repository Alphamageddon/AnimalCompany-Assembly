namespace UnityEngine;

[ExcludeFromPreset]
[NativeHeader("Runtime/Graphics/Mesh/MeshScriptBindings.h")]
[RequiredByNativeCode]
public sealed class Mesh : object
{
	[NativeHeader("Runtime/Graphics/Mesh/MeshScriptBindings.h")]
	[StaticAccessor("MeshDataBindings", StaticAccessorType::DoubleColon (2))]
	internal struct MeshData
	{
		[NativeDisableUnsafePtrRestriction]
		internal IntPtr m_Ptr; //Field offset: 0x0

	}


	public Bounds bounds
	{
		 get { } //Length: 104
		 set { } //Length: 68
	}

	internal bool canAccess
	{
		[NativeMethod("CanAccessFromScript")]
		internal get { } //Length: 60
	}

	public Color[] colors
	{
		 get { } //Length: 76
		 set { } //Length: 96
	}

	public Color32[] colors32
	{
		 get { } //Length: 84
		 set { } //Length: 104
	}

	public IndexFormat indexFormat
	{
		 set { } //Length: 68
	}

	public Vector3[] normals
	{
		 get { } //Length: 76
		 set { } //Length: 96
	}

	public int subMeshCount
	{
		[NativeMethod(Name = "GetSubMeshCount")]
		 get { } //Length: 60
		[FreeFunction(Name = "MeshScripting::SetSubMeshCount", HasExplicitThis = True)]
		 set { } //Length: 68
	}

	public Vector4[] tangents
	{
		 get { } //Length: 76
		 set { } //Length: 96
	}

	public Int32[] triangles
	{
		 get { } //Length: 180
		 set { } //Length: 168
	}

	public Vector2[] uv
	{
		 get { } //Length: 76
		 set { } //Length: 96
	}

	public Vector2[] uv2
	{
		 get { } //Length: 76
		 set { } //Length: 96
	}

	public int vertexCount
	{
		[NativeMethod("GetVertexCount")]
		 get { } //Length: 60
	}

	public Vector3[] vertices
	{
		 get { } //Length: 76
		 set { } //Length: 96
	}

	[RequiredByNativeCode]
	public Mesh() { }

	private bool CheckCanAccessSubmesh(int submesh, bool errorAboutTriangles) { }

	private bool CheckCanAccessSubmeshIndices(int submesh) { }

	private bool CheckCanAccessSubmeshTriangles(int submesh) { }

	private void CheckIndicesArrayRange(int valuesLength, int start, int length) { }

	[ExcludeFromDocs]
	public void Clear() { }

	[NativeMethod("Clear")]
	private void ClearImpl(bool keepVertexLayout) { }

	[ExcludeFromDocs]
	public void CombineMeshes(CombineInstance[] combine, bool mergeSubMeshes) { }

	[ExcludeFromDocs]
	public void CombineMeshes(CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices) { }

	[NativeMethod(Name = "MeshScripting::CombineMeshes", IsFreeFunction = True, ThrowsException = True, HasExplicitThis = True)]
	private void CombineMeshesImpl(CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices, bool hasLightmapData) { }

	internal static int DefaultDimensionForChannel(VertexAttribute channel) { }

	public Bounds get_bounds() { }

	private void get_bounds_Injected(out Bounds ret) { }

	[NativeMethod("CanAccessFromScript")]
	internal bool get_canAccess() { }

	public Color[] get_colors() { }

	public Color32[] get_colors32() { }

	public Vector3[] get_normals() { }

	[NativeMethod(Name = "GetSubMeshCount")]
	public int get_subMeshCount() { }

	public Vector4[] get_tangents() { }

	public Int32[] get_triangles() { }

	public Vector2[] get_uv() { }

	public Vector2[] get_uv2() { }

	[NativeMethod("GetVertexCount")]
	public int get_vertexCount() { }

	public Vector3[] get_vertices() { }

	private T[] GetAllocArrayFromChannel(VertexAttribute channel) { }

	private T[] GetAllocArrayFromChannel(VertexAttribute channel, VertexAttributeFormat format, int dim) { }

	[FreeFunction(Name = "AllocExtractMeshComponentFromScript", HasExplicitThis = True)]
	private Array GetAllocArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim) { }

	[FreeFunction(Name = "ExtractMeshComponentFromScript", HasExplicitThis = True)]
	private void GetArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values) { }

	public uint GetIndexCount(int submesh) { }

	[FreeFunction(Name = "MeshScripting::GetIndexCount", HasExplicitThis = True)]
	private uint GetIndexCountImpl(int submesh) { }

	public Int32[] GetIndices(int submesh, bool applyBaseVertex) { }

	[ExcludeFromDocs]
	public Int32[] GetIndices(int submesh) { }

	[FreeFunction(Name = "MeshScripting::GetIndices", HasExplicitThis = True)]
	private Int32[] GetIndicesImpl(int submesh, bool applyBaseVertex) { }

	private void GetListForChannel(List<T> buffer, int capacity, VertexAttribute channel, int dim) { }

	private void GetListForChannel(List<T> buffer, int capacity, VertexAttribute channel, int dim, VertexAttributeFormat channelType) { }

	[FreeFunction("MeshScripting::GetSubMesh", HasExplicitThis = True, ThrowsException = True)]
	public SubMeshDescriptor GetSubMesh(int index) { }

	private void GetSubMesh_Injected(int index, out SubMeshDescriptor ret) { }

	public MeshTopology GetTopology(int submesh) { }

	[FreeFunction(Name = "MeshScripting::GetPrimitiveType", HasExplicitThis = True)]
	private MeshTopology GetTopologyImpl(int submesh) { }

	public Int32[] GetTriangles(int submesh, bool applyBaseVertex) { }

	public Int32[] GetTriangles(int submesh) { }

	[FreeFunction(Name = "MeshScripting::GetTriangles", HasExplicitThis = True)]
	private Int32[] GetTrianglesImpl(int submesh, bool applyBaseVertex) { }

	internal static VertexAttribute GetUVChannel(int uvIndex) { }

	public void GetUVs(int channel, List<Vector4> uvs) { }

	private void GetUVsImpl(int uvIndex, List<T> uvs, int dim) { }

	[FreeFunction(Name = "MeshScripting::HasChannel", HasExplicitThis = True)]
	public bool HasVertexAttribute(VertexAttribute attr) { }

	[FreeFunction("MeshScripting::CreateMesh")]
	private static void Internal_Create(Mesh mono) { }

	[FreeFunction(Name = "MeshScripting::InternalSetVertexBufferData", HasExplicitThis = True)]
	private void InternalSetVertexBufferData(int stream, IntPtr data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags) { }

	public void MarkDynamic() { }

	[NativeMethod("MarkDynamic")]
	private void MarkDynamicImpl() { }

	public void Optimize() { }

	[NativeMethod("Optimize")]
	private void OptimizeImpl() { }

	[FreeFunction(Name = "MeshScripting::PrintErrorCantAccessChannel", HasExplicitThis = True)]
	private void PrintErrorCantAccessChannel(VertexAttribute ch) { }

	private void PrintErrorCantAccessIndices() { }

	public void RecalculateBounds(MeshUpdateFlags flags) { }

	[ExcludeFromDocs]
	public void RecalculateBounds() { }

	[NativeMethod("RecalculateBounds")]
	private void RecalculateBoundsImpl(MeshUpdateFlags flags) { }

	public void RecalculateNormals(MeshUpdateFlags flags) { }

	[ExcludeFromDocs]
	public void RecalculateNormals() { }

	[NativeMethod("RecalculateNormals")]
	private void RecalculateNormalsImpl(MeshUpdateFlags flags) { }

	public void RecalculateTangents(MeshUpdateFlags flags) { }

	[ExcludeFromDocs]
	public void RecalculateTangents() { }

	[NativeMethod("RecalculateTangents")]
	private void RecalculateTangentsImpl(MeshUpdateFlags flags) { }

	public void set_bounds(Bounds value) { }

	private void set_bounds_Injected(ref Bounds value) { }

	public void set_colors(Color[] value) { }

	public void set_colors32(Color32[] value) { }

	public void set_indexFormat(IndexFormat value) { }

	public void set_normals(Vector3[] value) { }

	[FreeFunction(Name = "MeshScripting::SetSubMeshCount", HasExplicitThis = True)]
	public void set_subMeshCount(int value) { }

	public void set_tangents(Vector4[] value) { }

	public void set_triangles(Int32[] value) { }

	public void set_uv(Vector2[] value) { }

	public void set_uv2(Vector2[] value) { }

	public void set_vertices(Vector3[] value) { }

	private void SetArrayForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, T[] values, MeshUpdateFlags flags = 0) { }

	private void SetArrayForChannel(VertexAttribute channel, T[] values, MeshUpdateFlags flags = 0) { }

	[FreeFunction(Name = "SetMeshComponentFromArrayFromScript", HasExplicitThis = True)]
	private void SetArrayForChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int arraySize, int valuesStart, int valuesCount, MeshUpdateFlags flags) { }

	public void SetColors(List<Color32> inColors, int start, int length, MeshUpdateFlags flags) { }

	public void SetColors(List<Color> inColors) { }

	[ExcludeFromDocs]
	public void SetColors(List<Color> inColors, int start, int length) { }

	public void SetColors(List<Color> inColors, int start, int length, MeshUpdateFlags flags) { }

	public void SetColors(List<Color32> inColors) { }

	[ExcludeFromDocs]
	public void SetColors(List<Color32> inColors, int start, int length) { }

	public void SetIndices(NativeArray<T> indices, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	public void SetIndices(Int32[] indices, MeshTopology topology, int submesh, bool calculateBounds, int baseVertex) { }

	public void SetIndices(Int32[] indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	public void SetIndices(UInt16[] indices, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	public void SetIndices(UInt16[] indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	[ExcludeFromDocs]
	public void SetIndices(Int32[] indices, MeshTopology topology, int submesh) { }

	public void SetIndices(NativeArray<T> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	public void SetIndices(List<Int32> indices, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	public void SetIndices(List<Int32> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	[ExcludeFromDocs]
	public void SetIndices(Int32[] indices, MeshTopology topology, int submesh, bool calculateBounds) { }

	[FreeFunction(Name = "SetMeshIndicesFromScript", HasExplicitThis = True, ThrowsException = True)]
	private void SetIndicesImpl(int submesh, MeshTopology topology, IndexFormat indicesFormat, Array indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex) { }

	[FreeFunction(Name = "SetMeshIndicesFromNativeArray", HasExplicitThis = True, ThrowsException = True)]
	private void SetIndicesNativeArrayImpl(int submesh, MeshTopology topology, IndexFormat indicesFormat, IntPtr indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex) { }

	private void SetListForChannel(VertexAttribute channel, List<T> values, int start, int length, MeshUpdateFlags flags) { }

	private void SetListForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, List<T> values, int start, int length, MeshUpdateFlags flags) { }

	public void SetNormals(List<Vector3> inNormals) { }

	public void SetNormals(List<Vector3> inNormals, int start, int length, MeshUpdateFlags flags) { }

	[ExcludeFromDocs]
	public void SetNormals(List<Vector3> inNormals, int start, int length) { }

	private void SetSizedArrayForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int valuesArrayLength, int valuesStart, int valuesCount, MeshUpdateFlags flags) { }

	public void SetTangents(List<Vector4> inTangents) { }

	[ExcludeFromDocs]
	public void SetTangents(List<Vector4> inTangents, int start, int length) { }

	public void SetTangents(List<Vector4> inTangents, int start, int length, MeshUpdateFlags flags) { }

	public void SetTriangles(Int32[] triangles, int submesh, bool calculateBounds, int baseVertex) { }

	[ExcludeFromDocs]
	public void SetTriangles(Int32[] triangles, int submesh) { }

	public void SetTriangles(Int32[] triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	[ExcludeFromDocs]
	public void SetTriangles(List<Int32> triangles, int submesh) { }

	public void SetTriangles(List<Int32> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	public void SetTriangles(List<Int32> triangles, int submesh, bool calculateBounds, int baseVertex) { }

	private void SetTrianglesImpl(int submesh, IndexFormat indicesFormat, Array triangles, int trianglesArrayLength, int start, int length, bool calculateBounds, int baseVertex) { }

	public void SetUVs(int channel, List<Vector2> uvs) { }

	public void SetUVs(int channel, List<Vector3> uvs) { }

	public void SetUVs(int channel, List<Vector4> uvs) { }

	[ExcludeFromDocs]
	public void SetUVs(int channel, List<Vector2> uvs, int start, int length) { }

	public void SetUVs(int channel, List<Vector2> uvs, int start, int length, MeshUpdateFlags flags) { }

	public void SetUVs(int channel, List<Vector3> uvs, int start, int length, MeshUpdateFlags flags) { }

	[ExcludeFromDocs]
	public void SetUVs(int channel, List<Vector3> uvs, int start, int length) { }

	[ExcludeFromDocs]
	public void SetUVs(int channel, List<Vector4> uvs, int start, int length) { }

	public void SetUVs(int channel, List<Vector4> uvs, int start, int length, MeshUpdateFlags flags) { }

	private void SetUvsImpl(int uvIndex, int dim, List<T> uvs, int start, int length, MeshUpdateFlags flags) { }

	public void SetVertexBufferData(NativeArray<T> data, int dataStart, int meshBufferStart, int count, int stream = 0, MeshUpdateFlags flags = 0) { }

	public void SetVertexBufferParams(int vertexCount, VertexAttributeDescriptor[] attributes) { }

	[FreeFunction(Name = "MeshScripting::SetVertexBufferParamsFromArray", HasExplicitThis = True, ThrowsException = True)]
	private void SetVertexBufferParamsFromArray(int vertexCount, VertexAttributeDescriptor[] attributes) { }

	public void SetVertices(Vector3[] inVertices, int start, int length, MeshUpdateFlags flags) { }

	[ExcludeFromDocs]
	public void SetVertices(Vector3[] inVertices, int start, int length) { }

	public void SetVertices(Vector3[] inVertices) { }

	public void SetVertices(List<Vector3> inVertices, int start, int length, MeshUpdateFlags flags) { }

	[ExcludeFromDocs]
	public void SetVertices(List<Vector3> inVertices, int start, int length) { }

	public void SetVertices(List<Vector3> inVertices) { }

	public void UploadMeshData(bool markNoLongerReadable) { }

	[NativeMethod("UploadMeshData")]
	private void UploadMeshDataImpl(bool markNoLongerReadable) { }

}

