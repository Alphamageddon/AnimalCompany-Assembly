namespace UnityEngine.ProBuilder;

[AddComponentMenu("//ProBuilder MeshFilter")]
[DisallowMultipleComponent]
[ExcludeFromObjectFactory]
[ExcludeFromPreset]
[ExecuteInEditMode]
[RequireComponent(typeof(MeshRenderer))]
public sealed class ProBuilderMesh : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Vector4, Vector2> <>9__118_0; //Field offset: 0x8
		public static Func<Vector4, Vector2> <>9__118_1; //Field offset: 0x10
		public static Func<Face, Int32> <>9__126_0; //Field offset: 0x18
		public static Func<Face, Int32> <>9__128_0; //Field offset: 0x20
		public static Func<Face, Face> <>9__171_0; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal Face <CopyFrom>b__171_0(Face x) { }

		internal int <get_indexCount>b__126_0(Face x) { }

		internal int <get_triangleCount>b__128_0(Face x) { }

		internal Vector2 <SetUVs>b__118_0(Vector4 x) { }

		internal Vector2 <SetUVs>b__118_1(Vector4 x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass174_0
	{
		public int i; //Field offset: 0x10

		public <>c__DisplayClass174_0() { }

		internal bool <GetUnusedTextureGroup>b__0(Face element) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass176_0
	{
		public int i; //Field offset: 0x10

		public <>c__DisplayClass176_0() { }

		internal bool <UnusedElementGroup>b__0(Face element) { }

	}

	[Flags]
	private enum CacheValidState
	{
		SharedVertex = 1,
		SharedTexture = 2,
	}

	public struct NonVersionedEditScope : IDisposable
	{
		private readonly ProBuilderMesh m_Mesh; //Field offset: 0x0
		private readonly ushort m_VersionIndex; //Field offset: 0x8
		private readonly ushort m_InstanceVersionIndex; //Field offset: 0xA

		public NonVersionedEditScope(ProBuilderMesh mesh) { }

		public override void Dispose() { }

	}

	internal const HideFlags k_MeshFilterHideFlags = 10; //Field offset: 0x0
	internal const ushort k_UnitializedVersionIndex = 0; //Field offset: 0x0
	public const uint maxVertexCount = 65535; //Field offset: 0x0
	internal const int k_MeshFormatVersionAutoUVScaleOffset = 2; //Field offset: 0x0
	[CompilerGenerated]
	private static Action<ProBuilderMesh> meshWillBeDestroyed; //Field offset: 0x0
	internal const int k_MeshFormatVersion = 2; //Field offset: 0x0
	private const int k_UVChannelCount = 4; //Field offset: 0x0
	internal const int k_MeshFormatVersionSubmeshMaterialRefactor = 1; //Field offset: 0x0
	[CompilerGenerated]
	private static Action<ProBuilderMesh> meshWasInitialized; //Field offset: 0x8
	[CompilerGenerated]
	private static Action<ProBuilderMesh> componentWillBeDestroyed; //Field offset: 0x10
	[CompilerGenerated]
	private static Action<ProBuilderMesh> componentHasBeenReset; //Field offset: 0x18
	[CompilerGenerated]
	private static Action<ProBuilderMesh> elementSelectionChanged; //Field offset: 0x20
	private static HashSet<Int32> s_CachedHashSet; //Field offset: 0x28
	[SerializeField]
	private int m_MeshFormatVersion; //Field offset: 0x20
	[FormerlySerializedAs("_quads")]
	[SerializeField]
	private Face[] m_Faces; //Field offset: 0x28
	[FormerlySerializedAs("_sharedIndices")]
	[FormerlySerializedAs("m_SharedVertexes")]
	[SerializeField]
	private SharedVertex[] m_SharedVertices; //Field offset: 0x30
	private CacheValidState m_CacheValid; //Field offset: 0x38
	private Dictionary<Int32, Int32> m_SharedVertexLookup; //Field offset: 0x40
	[FormerlySerializedAs("_sharedIndicesUV")]
	[SerializeField]
	private SharedVertex[] m_SharedTextures; //Field offset: 0x48
	private Dictionary<Int32, Int32> m_SharedTextureLookup; //Field offset: 0x50
	[FormerlySerializedAs("_vertices")]
	[SerializeField]
	private Vector3[] m_Positions; //Field offset: 0x58
	[FormerlySerializedAs("_uv")]
	[SerializeField]
	private Vector2[] m_Textures0; //Field offset: 0x60
	[FormerlySerializedAs("_uv3")]
	[SerializeField]
	private List<Vector4> m_Textures2; //Field offset: 0x68
	[FormerlySerializedAs("_uv4")]
	[SerializeField]
	private List<Vector4> m_Textures3; //Field offset: 0x70
	[FormerlySerializedAs("_tangents")]
	[SerializeField]
	private Vector4[] m_Tangents; //Field offset: 0x78
	private Vector3[] m_Normals; //Field offset: 0x80
	[FormerlySerializedAs("_colors")]
	[SerializeField]
	private Color[] m_Colors; //Field offset: 0x88
	[CompilerGenerated]
	private bool <userCollisions>k__BackingField; //Field offset: 0x90
	[FormerlySerializedAs("unwrapParameters")]
	[SerializeField]
	private UnwrapParameters m_UnwrapParameters; //Field offset: 0x98
	[FormerlySerializedAs("dontDestroyMeshOnDelete")]
	[SerializeField]
	private bool m_PreserveMeshAssetOnDestroy; //Field offset: 0xA0
	[SerializeField]
	internal string assetGuid; //Field offset: 0xA8
	[SerializeField]
	private Mesh m_Mesh; //Field offset: 0xB0
	private MeshRenderer m_MeshRenderer; //Field offset: 0xB8
	private MeshFilter m_MeshFilter; //Field offset: 0xC0
	[SerializeField]
	private ushort m_VersionIndex; //Field offset: 0xC8
	private ushort m_InstanceVersionIndex; //Field offset: 0xCA
	[SerializeField]
	private bool m_IsSelectable; //Field offset: 0xCC
	[SerializeField]
	private Int32[] m_SelectedFaces; //Field offset: 0xD0
	[SerializeField]
	private Edge[] m_SelectedEdges; //Field offset: 0xD8
	[SerializeField]
	private Int32[] m_SelectedVertices; //Field offset: 0xE0
	private bool m_SelectedCacheDirty; //Field offset: 0xE8
	private int m_SelectedSharedVerticesCount; //Field offset: 0xEC
	private int m_SelectedCoincidentVertexCount; //Field offset: 0xF0
	private HashSet<Int32> m_SelectedSharedVertices; //Field offset: 0xF8
	private List<Int32> m_SelectedCoincidentVertices; //Field offset: 0x100

	internal static event Action<ProBuilderMesh> componentHasBeenReset
	{
		[CompilerGenerated]
		internal add { } //Length: 244
		[CompilerGenerated]
		internal remove { } //Length: 244
	}

	internal static event Action<ProBuilderMesh> componentWillBeDestroyed
	{
		[CompilerGenerated]
		internal add { } //Length: 244
		[CompilerGenerated]
		internal remove { } //Length: 244
	}

	public static event Action<ProBuilderMesh> elementSelectionChanged
	{
		[CompilerGenerated]
		 add { } //Length: 244
		[CompilerGenerated]
		 remove { } //Length: 244
	}

	internal static event Action<ProBuilderMesh> meshWasInitialized
	{
		[CompilerGenerated]
		internal add { } //Length: 244
		[CompilerGenerated]
		internal remove { } //Length: 244
	}

	public static event Action<ProBuilderMesh> meshWillBeDestroyed
	{
		[CompilerGenerated]
		 add { } //Length: 240
		[CompilerGenerated]
		 remove { } //Length: 240
	}

	public IList<Color> colors
	{
		 get { } //Length: 128
		 set { } //Length: 408
	}

	internal Color[] colorsInternal
	{
		internal get { } //Length: 8
		internal set { } //Length: 8
	}

	public int edgeCount
	{
		 get { } //Length: 140
	}

	public int faceCount
	{
		 get { } //Length: 24
	}

	public IList<Face> faces
	{
		 get { } //Length: 124
		 set { } //Length: 160
	}

	internal Face[] facesInternal
	{
		internal get { } //Length: 8
		internal set { } //Length: 8
	}

	internal MeshFilter filter
	{
		internal get { } //Length: 184
	}

	[Obsolete("InstanceID is not used to track mesh references as of 2023/04/12")]
	internal int id
	{
		internal get { } //Length: 32
	}

	public int indexCount
	{
		 get { } //Length: 268
	}

	internal Mesh mesh
	{
		internal get { } //Length: 188
		internal set { } //Length: 8
	}

	internal int meshFormatVersion
	{
		internal get { } //Length: 8
	}

	public MeshSyncState meshSyncState
	{
		 get { } //Length: 188
	}

	internal ushort nonSerializedVersionIndex
	{
		internal get { } //Length: 8
	}

	public IList<Vector3> normals
	{
		 get { } //Length: 128
	}

	internal Vector3[] normalsInternal
	{
		internal get { } //Length: 8
		internal set { } //Length: 8
	}

	public IList<Vector3> positions
	{
		 get { } //Length: 124
		 set { } //Length: 160
	}

	internal Vector3[] positionsInternal
	{
		internal get { } //Length: 8
		internal set { } //Length: 8
	}

	public bool preserveMeshAssetOnDestroy
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	internal MeshRenderer renderer
	{
		internal get { } //Length: 116
	}

	public bool selectable
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	internal int selectedCoincidentVertexCount
	{
		internal get { } //Length: 24
	}

	internal IEnumerable<Int32> selectedCoincidentVertices
	{
		internal get { } //Length: 24
	}

	public int selectedEdgeCount
	{
		 get { } //Length: 28
	}

	public ReadOnlyCollection<Edge> selectedEdges
	{
		 get { } //Length: 124
	}

	internal Edge[] selectedEdgesInternal
	{
		internal get { } //Length: 8
		internal set { } //Length: 8
	}

	public int selectedFaceCount
	{
		 get { } //Length: 28
	}

	public ReadOnlyCollection<Int32> selectedFaceIndexes
	{
		 get { } //Length: 124
	}

	internal Int32[] selectedFaceIndicesInternal
	{
		internal get { } //Length: 8
		internal set { } //Length: 8
	}

	internal Face[] selectedFacesInternal
	{
		internal get { } //Length: 4
		internal set { } //Length: 200
	}

	internal Int32[] selectedIndexesInternal
	{
		internal get { } //Length: 8
		internal set { } //Length: 8
	}

	internal IEnumerable<Int32> selectedSharedVertices
	{
		internal get { } //Length: 24
	}

	internal int selectedSharedVerticesCount
	{
		internal get { } //Length: 24
	}

	public int selectedVertexCount
	{
		 get { } //Length: 28
	}

	public ReadOnlyCollection<Int32> selectedVertices
	{
		 get { } //Length: 124
	}

	internal Dictionary<Int32, Int32> sharedTextureLookup
	{
		internal get { } //Length: 152
	}

	internal SharedVertex[] sharedTextures
	{
		internal get { } //Length: 8
		internal set { } //Length: 8
	}

	internal Dictionary<Int32, Int32> sharedVertexLookup
	{
		internal get { } //Length: 156
	}

	public IList<SharedVertex> sharedVertices
	{
		 get { } //Length: 124
		 set { } //Length: 540
	}

	internal SharedVertex[] sharedVerticesInternal
	{
		internal get { } //Length: 8
		internal set { } //Length: 8
	}

	public IList<Vector4> tangents
	{
		 get { } //Length: 152
		 set { } //Length: 316
	}

	internal Vector4[] tangentsInternal
	{
		internal get { } //Length: 8
		internal set { } //Length: 8
	}

	public IList<Vector2> textures
	{
		 get { } //Length: 128
		 set { } //Length: 296
	}

	internal List<Vector4> textures2Internal
	{
		internal get { } //Length: 8
		internal set { } //Length: 8
	}

	internal List<Vector4> textures3Internal
	{
		internal get { } //Length: 8
		internal set { } //Length: 8
	}

	internal Vector2[] texturesInternal
	{
		internal get { } //Length: 8
		internal set { } //Length: 8
	}

	public int triangleCount
	{
		 get { } //Length: 284
	}

	public UnwrapParameters unwrapParameters
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public bool userCollisions
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	internal ushort versionIndex
	{
		internal get { } //Length: 8
	}

	public int vertexCount
	{
		 get { } //Length: 24
	}

	private static ProBuilderMesh() { }

	public ProBuilderMesh() { }

	[CompilerGenerated]
	private int <set_selectedFacesInternal>b__231_0(Face x) { }

	[CompilerGenerated]
	private int <SetSelectedFaces>b__245_0(Face x) { }

	[CompilerGenerated]
	private IEnumerable<Int32> <SetSelectedFaces>b__246_0(int x) { }

	[CompilerGenerated]
	private IEnumerable<Edge> <SetSelectedFaces>b__246_1(int x) { }

	[CompilerGenerated]
	internal static void add_componentHasBeenReset(Action<ProBuilderMesh> value) { }

	[CompilerGenerated]
	internal static void add_componentWillBeDestroyed(Action<ProBuilderMesh> value) { }

	[CompilerGenerated]
	public static void add_elementSelectionChanged(Action<ProBuilderMesh> value) { }

	[CompilerGenerated]
	internal static void add_meshWasInitialized(Action<ProBuilderMesh> value) { }

	[CompilerGenerated]
	public static void add_meshWillBeDestroyed(Action<ProBuilderMesh> value) { }

	internal void AddSharedVertex(SharedVertex vertex) { }

	internal void AddToFaceSelection(int index) { }

	internal void AddToSharedVertex(int sharedVertexHandle, int vertex) { }

	private void Awake() { }

	private void CacheSelection() { }

	public void Clear() { }

	public void ClearSelection() { }

	public void CopyFrom(ProBuilderMesh other) { }

	public static ProBuilderMesh Create() { }

	public static ProBuilderMesh Create(IEnumerable<Vector3> positions, IEnumerable<Face> faces) { }

	public static ProBuilderMesh Create(IList<Vertex> vertices, IList<Face> faces, IList<SharedVertex> sharedVertices = null, IList<SharedVertex> sharedTextures = null, IList<Material> materials = null) { }

	internal static ProBuilderMesh CreateInstanceWithPoints(Vector3[] positions) { }

	internal void DestroyUnityMesh() { }

	internal void EnsureMeshColliderIsAssigned() { }

	internal void EnsureMeshFilterIsAssigned() { }

	private void FinalizeToMesh(bool usedInParticleSystem) { }

	internal void GeometryWithPoints(Vector3[] points) { }

	public IList<Color> get_colors() { }

	internal Color[] get_colorsInternal() { }

	public int get_edgeCount() { }

	public int get_faceCount() { }

	public IList<Face> get_faces() { }

	internal Face[] get_facesInternal() { }

	internal MeshFilter get_filter() { }

	internal int get_id() { }

	public int get_indexCount() { }

	internal Mesh get_mesh() { }

	internal int get_meshFormatVersion() { }

	public MeshSyncState get_meshSyncState() { }

	internal ushort get_nonSerializedVersionIndex() { }

	public IList<Vector3> get_normals() { }

	internal Vector3[] get_normalsInternal() { }

	public IList<Vector3> get_positions() { }

	internal Vector3[] get_positionsInternal() { }

	public bool get_preserveMeshAssetOnDestroy() { }

	internal MeshRenderer get_renderer() { }

	public bool get_selectable() { }

	internal int get_selectedCoincidentVertexCount() { }

	internal IEnumerable<Int32> get_selectedCoincidentVertices() { }

	public int get_selectedEdgeCount() { }

	public ReadOnlyCollection<Edge> get_selectedEdges() { }

	internal Edge[] get_selectedEdgesInternal() { }

	public int get_selectedFaceCount() { }

	public ReadOnlyCollection<Int32> get_selectedFaceIndexes() { }

	internal Int32[] get_selectedFaceIndicesInternal() { }

	internal Face[] get_selectedFacesInternal() { }

	internal Int32[] get_selectedIndexesInternal() { }

	internal IEnumerable<Int32> get_selectedSharedVertices() { }

	internal int get_selectedSharedVerticesCount() { }

	public int get_selectedVertexCount() { }

	public ReadOnlyCollection<Int32> get_selectedVertices() { }

	internal Dictionary<Int32, Int32> get_sharedTextureLookup() { }

	internal SharedVertex[] get_sharedTextures() { }

	internal Dictionary<Int32, Int32> get_sharedVertexLookup() { }

	public IList<SharedVertex> get_sharedVertices() { }

	internal SharedVertex[] get_sharedVerticesInternal() { }

	public IList<Vector4> get_tangents() { }

	internal Vector4[] get_tangentsInternal() { }

	public IList<Vector2> get_textures() { }

	internal List<Vector4> get_textures2Internal() { }

	internal List<Vector4> get_textures3Internal() { }

	internal Vector2[] get_texturesInternal() { }

	public int get_triangleCount() { }

	public UnwrapParameters get_unwrapParameters() { }

	[CompilerGenerated]
	public bool get_userCollisions() { }

	internal ushort get_versionIndex() { }

	public int get_vertexCount() { }

	internal Edge GetActiveEdge() { }

	internal Face GetActiveFace() { }

	internal int GetActiveVertex() { }

	public List<Int32> GetCoincidentVertices(IEnumerable<Int32> vertices) { }

	public void GetCoincidentVertices(IEnumerable<Face> faces, List<Int32> coincident) { }

	public void GetCoincidentVertices(IEnumerable<Edge> edges, List<Int32> coincident) { }

	public void GetCoincidentVertices(IEnumerable<Int32> vertices, List<Int32> coincident) { }

	public void GetCoincidentVertices(int vertex, List<Int32> coincident) { }

	public Color[] GetColors() { }

	public Vector3[] GetNormals() { }

	public Face[] GetSelectedFaces() { }

	internal int GetSharedVertexHandle(int vertex) { }

	internal HashSet<Int32> GetSharedVertexHandles(IEnumerable<Int32> vertices) { }

	public Vector4[] GetTangents() { }

	internal int GetUnusedTextureGroup(int i = 1) { }

	internal ReadOnlyCollection<Vector2> GetUVs(int channel) { }

	public void GetUVs(int channel, List<Vector4> uvs) { }

	public Vertex[] GetVertices(IList<Int32> indexes = null) { }

	internal void GetVerticesInList(IList<Vertex> vertices) { }

	public bool HasArrays(MeshArrays channels) { }

	private void IncrementVersionIndex() { }

	internal void InvalidateCaches() { }

	internal void InvalidateFaces() { }

	internal void InvalidateSharedTextureLookup() { }

	internal void InvalidateSharedVertexLookup() { }

	private static bool IsValidTextureGroup(int group) { }

	public void MakeUnique() { }

	private void OnDestroy() { }

	internal void Rebuild() { }

	public void RebuildWithPositionsAndFaces(IEnumerable<Vector3> vertices, IEnumerable<Face> faces) { }

	public void Refresh(RefreshMask mask = 31) { }

	private void RefreshColors() { }

	private void RefreshNormals() { }

	private void RefreshTangents() { }

	public void RefreshUV(IEnumerable<Face> facesToRefresh) { }

	[CompilerGenerated]
	internal static void remove_componentHasBeenReset(Action<ProBuilderMesh> value) { }

	[CompilerGenerated]
	internal static void remove_componentWillBeDestroyed(Action<ProBuilderMesh> value) { }

	[CompilerGenerated]
	public static void remove_elementSelectionChanged(Action<ProBuilderMesh> value) { }

	[CompilerGenerated]
	internal static void remove_meshWasInitialized(Action<ProBuilderMesh> value) { }

	[CompilerGenerated]
	public static void remove_meshWillBeDestroyed(Action<ProBuilderMesh> value) { }

	internal void RemoveFromFaceSelectionAtIndex(int index) { }

	private void Reset() { }

	public void set_colors(IList<Color> value) { }

	internal void set_colorsInternal(Color[] value) { }

	public void set_faces(IList<Face> value) { }

	internal void set_facesInternal(Face[] value) { }

	internal void set_mesh(Mesh value) { }

	internal void set_normalsInternal(Vector3[] value) { }

	public void set_positions(IList<Vector3> value) { }

	internal void set_positionsInternal(Vector3[] value) { }

	public void set_preserveMeshAssetOnDestroy(bool value) { }

	public void set_selectable(bool value) { }

	internal void set_selectedEdgesInternal(Edge[] value) { }

	internal void set_selectedFaceIndicesInternal(Int32[] value) { }

	internal void set_selectedFacesInternal(Face[] value) { }

	internal void set_selectedIndexesInternal(Int32[] value) { }

	internal void set_sharedTextures(SharedVertex[] value) { }

	public void set_sharedVertices(IList<SharedVertex> value) { }

	internal void set_sharedVerticesInternal(SharedVertex[] value) { }

	public void set_tangents(IList<Vector4> value) { }

	internal void set_tangentsInternal(Vector4[] value) { }

	public void set_textures(IList<Vector2> value) { }

	internal void set_textures2Internal(List<Vector4> value) { }

	internal void set_textures3Internal(List<Vector4> value) { }

	internal void set_texturesInternal(Vector2[] value) { }

	public void set_unwrapParameters(UnwrapParameters value) { }

	[CompilerGenerated]
	public void set_userCollisions(bool value) { }

	public void SetFaceColor(Face face, Color color) { }

	internal void SetGroupUV(AutoUnwrapSettings settings, int group) { }

	public void SetMaterial(IEnumerable<Face> faces, Material material) { }

	public void SetSelectedEdges(IEnumerable<Edge> edges) { }

	public void SetSelectedFaces(IEnumerable<Face> selected) { }

	internal void SetSelectedFaces(IEnumerable<Int32> selected) { }

	public void SetSelectedVertices(IEnumerable<Int32> vertices) { }

	internal void SetSharedTextures(IEnumerable<KeyValuePair`2<Int32, Int32>> indexes) { }

	internal void SetSharedVertices(IEnumerable<KeyValuePair`2<Int32, Int32>> indexes) { }

	internal void SetTexturesCoincident(IEnumerable<Int32> vertices) { }

	public void SetUVs(int channel, List<Vector4> uvs) { }

	public void SetVertices(IList<Vertex> vertices, bool applyMesh = false) { }

	public void SetVerticesCoincident(IEnumerable<Int32> vertices) { }

	public void ToMesh(MeshTopology preferredTopology = 0) { }

	internal int UnusedElementGroup(int i = 1) { }

}

