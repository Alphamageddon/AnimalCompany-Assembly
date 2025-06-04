namespace UnityEngine.Rendering.Universal;

[AddComponentMenu("Rendering/2D/Shadow Caster 2D")]
[DisallowMultipleComponent]
[ExecuteInEditMode]
[MovedFrom("UnityEngine.Experimental.Rendering.Universal")]
public class ShadowCaster2D : ShadowCasterGroup2D, ISerializationCallbackReceiver
{
	internal enum ComponentVersions
	{
		Version_Unserialized = 0,
		Version_1 = 1,
	}

	private const ComponentVersions k_CurrentComponentVersion = 1; //Field offset: 0x0
	[SerializeField]
	private ComponentVersions m_ComponentVersion; //Field offset: 0x30
	[SerializeField]
	private bool m_HasRenderer; //Field offset: 0x34
	[SerializeField]
	private bool m_UseRendererSilhouette; //Field offset: 0x35
	[SerializeField]
	private bool m_CastsShadows; //Field offset: 0x36
	[SerializeField]
	private bool m_SelfShadows; //Field offset: 0x37
	[SerializeField]
	private Int32[] m_ApplyToSortingLayers; //Field offset: 0x38
	[SerializeField]
	private Vector3[] m_ShapePath; //Field offset: 0x40
	[SerializeField]
	private int m_ShapePathHash; //Field offset: 0x48
	[SerializeField]
	private Mesh m_Mesh; //Field offset: 0x50
	[SerializeField]
	private int m_InstanceId; //Field offset: 0x58
	internal ShadowCasterGroup2D m_ShadowCasterGroup; //Field offset: 0x60
	internal ShadowCasterGroup2D m_PreviousShadowCasterGroup; //Field offset: 0x68
	[SerializeField]
	internal Bounds m_LocalBounds; //Field offset: 0x70
	internal BoundingSphere m_BoundingSphere; //Field offset: 0x88
	private int m_PreviousShadowGroup; //Field offset: 0x98
	private bool m_PreviousCastsShadows; //Field offset: 0x9C
	private int m_PreviousPathHash; //Field offset: 0xA0
	internal Vector3 m_CachedPosition; //Field offset: 0xA4
	internal Vector3 m_CachedLossyScale; //Field offset: 0xB0
	internal Quaternion m_CachedRotation; //Field offset: 0xBC
	internal Matrix4x4 m_CachedShadowMatrix; //Field offset: 0xCC
	internal Matrix4x4 m_CachedInverseShadowMatrix; //Field offset: 0x10C
	internal Matrix4x4 m_CachedLocalToWorldMatrix; //Field offset: 0x14C

	public bool castsShadows
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public Mesh mesh
	{
		 get { } //Length: 8
	}

	public bool selfShadows
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public Vector3[] shapePath
	{
		 get { } //Length: 8
	}

	internal int shapePathHash
	{
		internal get { } //Length: 8
		internal set { } //Length: 8
	}

	public bool useRendererSilhouette
	{
		 get { } //Length: 32
		 set { } //Length: 12
	}

	public ShadowCaster2D() { }

	private void Awake() { }

	internal virtual void CacheValues() { }

	public bool get_castsShadows() { }

	public Mesh get_mesh() { }

	public bool get_selfShadows() { }

	public Vector3[] get_shapePath() { }

	internal int get_shapePathHash() { }

	public bool get_useRendererSilhouette() { }

	internal bool IsLit(Light2D light) { }

	internal bool IsShadowedLayer(int layer) { }

	public override void OnAfterDeserialize() { }

	public override void OnBeforeSerialize() { }

	protected void OnDisable() { }

	protected void OnEnable() { }

	public void set_castsShadows(bool value) { }

	public void set_selfShadows(bool value) { }

	internal void set_shapePathHash(int value) { }

	public void set_useRendererSilhouette(bool value) { }

	private static Int32[] SetDefaultSortingLayers() { }

	public void Update() { }

	private void UpdateBoundingSphere() { }

}

