namespace Unity.AI.Navigation;

[AddComponentMenu("Navigation/NavMeshSurface", 30)]
[DefaultExecutionOrder(-102)]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.ai.navigation@1.1/manual/NavMeshSurface.html")]
public class NavMeshSurface : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<NavMeshModifierVolume> <>9__84_0; //Field offset: 0x8
		public static Predicate<NavMeshModifier> <>9__85_0; //Field offset: 0x10
		public static Predicate<NavMeshBuildSource> <>9__85_1; //Field offset: 0x18
		public static Predicate<NavMeshBuildSource> <>9__85_2; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal bool <AppendModifierVolumes>b__84_0(NavMeshModifierVolume x) { }

		internal bool <CollectSources>b__85_0(NavMeshModifier x) { }

		internal bool <CollectSources>b__85_1(NavMeshBuildSource x) { }

		internal bool <CollectSources>b__85_2(NavMeshBuildSource x) { }

	}

	private static readonly List<NavMeshSurface> s_NavMeshSurfaces; //Field offset: 0x0
	[SerializeField]
	private int m_AgentTypeID; //Field offset: 0x20
	[SerializeField]
	private CollectObjects m_CollectObjects; //Field offset: 0x24
	[SerializeField]
	private Vector3 m_Size; //Field offset: 0x28
	[SerializeField]
	private Vector3 m_Center; //Field offset: 0x34
	[SerializeField]
	private LayerMask m_LayerMask; //Field offset: 0x40
	[SerializeField]
	private NavMeshCollectGeometry m_UseGeometry; //Field offset: 0x44
	[SerializeField]
	private int m_DefaultArea; //Field offset: 0x48
	[SerializeField]
	private bool m_GenerateLinks; //Field offset: 0x4C
	[SerializeField]
	private bool m_IgnoreNavMeshAgent; //Field offset: 0x4D
	[SerializeField]
	private bool m_IgnoreNavMeshObstacle; //Field offset: 0x4E
	[SerializeField]
	private bool m_OverrideTileSize; //Field offset: 0x4F
	[SerializeField]
	private int m_TileSize; //Field offset: 0x50
	[SerializeField]
	private bool m_OverrideVoxelSize; //Field offset: 0x54
	[SerializeField]
	private float m_VoxelSize; //Field offset: 0x58
	[SerializeField]
	private float m_MinRegionArea; //Field offset: 0x5C
	[FormerlySerializedAs("m_BakedNavMeshData")]
	[SerializeField]
	private NavMeshData m_NavMeshData; //Field offset: 0x60
	[SerializeField]
	private bool m_BuildHeightMesh; //Field offset: 0x68
	private NavMeshDataInstance m_NavMeshDataInstance; //Field offset: 0x6C
	private Vector3 m_LastPosition; //Field offset: 0x70
	private Quaternion m_LastRotation; //Field offset: 0x7C

	public static List<NavMeshSurface> activeSurfaces
	{
		 get { } //Length: 88
	}

	public int agentTypeID
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public bool buildHeightMesh
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public Vector3 center
	{
		 get { } //Length: 12
		 set { } //Length: 12
	}

	public CollectObjects collectObjects
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public int defaultArea
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public bool ignoreNavMeshAgent
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool ignoreNavMeshObstacle
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public LayerMask layerMask
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float minRegionArea
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public NavMeshData navMeshData
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	internal NavMeshDataInstance navMeshDataInstance
	{
		internal get { } //Length: 8
	}

	public bool overrideTileSize
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool overrideVoxelSize
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public Vector3 size
	{
		 get { } //Length: 12
		 set { } //Length: 12
	}

	public int tileSize
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public NavMeshCollectGeometry useGeometry
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float voxelSize
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	private static NavMeshSurface() { }

	public NavMeshSurface() { }

	private static Vector3 Abs(Vector3 v) { }

	public void AddData() { }

	private void AppendModifierVolumes(ref List<NavMeshBuildSource>& sources) { }

	public void BuildNavMesh() { }

	private Bounds CalculateWorldBounds(List<NavMeshBuildSource> sources) { }

	private List<NavMeshBuildSource> CollectSources() { }

	public static List<NavMeshSurface> get_activeSurfaces() { }

	public int get_agentTypeID() { }

	public bool get_buildHeightMesh() { }

	public Vector3 get_center() { }

	public CollectObjects get_collectObjects() { }

	public int get_defaultArea() { }

	public bool get_ignoreNavMeshAgent() { }

	public bool get_ignoreNavMeshObstacle() { }

	public LayerMask get_layerMask() { }

	public float get_minRegionArea() { }

	public NavMeshData get_navMeshData() { }

	internal NavMeshDataInstance get_navMeshDataInstance() { }

	public bool get_overrideTileSize() { }

	public bool get_overrideVoxelSize() { }

	public Vector3 get_size() { }

	public int get_tileSize() { }

	public NavMeshCollectGeometry get_useGeometry() { }

	public float get_voxelSize() { }

	public NavMeshBuildSettings GetBuildSettings() { }

	private Bounds GetInflatedBounds() { }

	private static Bounds GetWorldBounds(Matrix4x4 mat, Bounds bounds) { }

	private bool HasTransformChanged() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private static void Register(NavMeshSurface surface) { }

	public void RemoveData() { }

	public void set_agentTypeID(int value) { }

	public void set_buildHeightMesh(bool value) { }

	public void set_center(Vector3 value) { }

	public void set_collectObjects(CollectObjects value) { }

	public void set_defaultArea(int value) { }

	public void set_ignoreNavMeshAgent(bool value) { }

	public void set_ignoreNavMeshObstacle(bool value) { }

	public void set_layerMask(LayerMask value) { }

	public void set_minRegionArea(float value) { }

	public void set_navMeshData(NavMeshData value) { }

	public void set_overrideTileSize(bool value) { }

	public void set_overrideVoxelSize(bool value) { }

	public void set_size(Vector3 value) { }

	public void set_tileSize(int value) { }

	public void set_useGeometry(NavMeshCollectGeometry value) { }

	public void set_voxelSize(float value) { }

	private static void Unregister(NavMeshSurface surface) { }

	private static void UpdateActive() { }

	private void UpdateDataIfTransformChanged() { }

	public AsyncOperation UpdateNavMesh(NavMeshData data) { }

}

