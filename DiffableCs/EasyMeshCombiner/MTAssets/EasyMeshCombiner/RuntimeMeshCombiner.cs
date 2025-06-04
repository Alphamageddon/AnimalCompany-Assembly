namespace MTAssets.EasyMeshCombiner;

[AddComponentMenu("MT Assets/Easy Mesh Combiner/Runtime Mesh Combiner")]
public class RuntimeMeshCombiner : MonoBehaviour
{
	internal enum AfterMerge
	{
		DisableOriginalMeshes = 0,
		DeactiveOriginalGameObjects = 1,
		DoNothing = 2,
	}

	internal enum CombineOnStart
	{
		Disabled = 0,
		OnStart = 1,
		OnAwake = 2,
	}

	private class GameObjectWithMesh
	{
		public GameObject gameObject; //Field offset: 0x10
		public MeshFilter meshFilter; //Field offset: 0x18
		public MeshRenderer meshRenderer; //Field offset: 0x20

		public GameObjectWithMesh(GameObject gameObject, MeshFilter meshFilter, MeshRenderer meshRenderer) { }

	}

	private class OriginalGameObjectWithMesh
	{
		public GameObject gameObject; //Field offset: 0x10
		public bool originalGoState; //Field offset: 0x18
		public MeshRenderer meshRenderer; //Field offset: 0x20
		public bool originalMrState; //Field offset: 0x28

		public OriginalGameObjectWithMesh(GameObject gameObject, bool originalGoState, MeshRenderer meshRenderer, bool originalMrState) { }

	}

	private class SubMeshToCombine
	{
		public Transform transform; //Field offset: 0x10
		public MeshFilter meshFilter; //Field offset: 0x18
		public MeshRenderer meshRenderer; //Field offset: 0x20
		public int subMeshIndex; //Field offset: 0x28

		public SubMeshToCombine(Transform transform, MeshFilter meshFilter, MeshRenderer meshRenderer, int subMeshIndex) { }

	}

	private int MAX_VERTICES_FOR_16BITS_MESH; //Field offset: 0x20
	private Vector3 originalPosition; //Field offset: 0x24
	private Vector3 originalEulerAngles; //Field offset: 0x30
	private Vector3 originalScale; //Field offset: 0x3C
	private List<OriginalGameObjectWithMesh> originalGameObjectsWithMeshToRestore; //Field offset: 0x48
	private bool targetMeshesMerged; //Field offset: 0x50
	[HideInInspector]
	public AfterMerge afterMerge; //Field offset: 0x54
	[HideInInspector]
	public bool addMeshColliderAfter; //Field offset: 0x58
	[HideInInspector]
	public CombineOnStart combineMeshesAtStartUp; //Field offset: 0x5C
	[HideInInspector]
	public bool combineInChildren; //Field offset: 0x60
	[HideInInspector]
	public bool combineInactives; //Field offset: 0x61
	[HideInInspector]
	public bool recalculateNormals; //Field offset: 0x62
	[HideInInspector]
	public bool recalculateTangents; //Field offset: 0x63
	[HideInInspector]
	public bool optimizeResultingMesh; //Field offset: 0x64
	[HideInInspector]
	public List<GameObject> targetMeshes; //Field offset: 0x68
	[HideInInspector]
	public bool showDebugLogs; //Field offset: 0x70
	[HideInInspector]
	public bool garbageCollectorAfterUndo; //Field offset: 0x71
	public UnityEvent onDoneMerge; //Field offset: 0x78
	public UnityEvent onDoneUnmerge; //Field offset: 0x80

	public RuntimeMeshCombiner() { }

	private void Awake() { }

	public bool CombineMeshes() { }

	private GameObjectWithMesh[] GetValidatedTargetGameObjects() { }

	public bool isTargetMeshesMerged() { }

	private void Start() { }

	public bool UndoMerge() { }

}

