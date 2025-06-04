namespace UnityEngine.Rendering.Universal;

[AddComponentMenu("Rendering/2D/Light 2D")]
[DisallowMultipleComponent]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.render-pipelines.universal@latest/index.html?subfolder=/manual/2DLightProperties.html")]
[MovedFrom("UnityEngine.Experimental.Rendering.Universal")]
public sealed class Light2D : Light2DBase, ISerializationCallbackReceiver
{
	private enum ComponentVersions
	{
		Version_Unserialized = 0,
		Version_1 = 1,
	}

	internal enum DeprecatedLightType
	{
		Parametric = 0,
	}

	internal enum LightType
	{
		Parametric = 0,
		Freeform = 1,
		Sprite = 2,
		Point = 3,
		Global = 4,
	}

	internal enum NormalMapQuality
	{
		Disabled = 2,
		Fast = 0,
		Accurate = 1,
	}

	internal enum OverlapOperation
	{
		Additive = 0,
		AlphaBlend = 1,
	}

	private const ComponentVersions k_CurrentComponentVersion = 1; //Field offset: 0x0
	[SerializeField]
	private ComponentVersions m_ComponentVersion; //Field offset: 0x20
	[NotKeyable]
	[SerializeField]
	private LightType m_LightType; //Field offset: 0x24
	[FormerlySerializedAs("m_LightOperationIndex")]
	[SerializeField]
	private int m_BlendStyleIndex; //Field offset: 0x28
	[SerializeField]
	private float m_FalloffIntensity; //Field offset: 0x2C
	[ColorUsage(True)]
	[SerializeField]
	private Color m_Color; //Field offset: 0x30
	[SerializeField]
	private float m_Intensity; //Field offset: 0x40
	[FormerlySerializedAs("m_LightVolumeOpacity")]
	[SerializeField]
	private float m_LightVolumeIntensity; //Field offset: 0x44
	[SerializeField]
	private bool m_LightVolumeIntensityEnabled; //Field offset: 0x48
	[SerializeField]
	private Int32[] m_ApplyToSortingLayers; //Field offset: 0x50
	[Reload("Textures/2D/Sparkle.png", Package::Root (1))]
	[SerializeField]
	private Sprite m_LightCookieSprite; //Field offset: 0x58
	[FormerlySerializedAs("m_LightCookieSprite")]
	[SerializeField]
	private Sprite m_DeprecatedPointLightCookieSprite; //Field offset: 0x60
	[SerializeField]
	private int m_LightOrder; //Field offset: 0x68
	[SerializeField]
	private bool m_AlphaBlendOnOverlap; //Field offset: 0x6C
	[SerializeField]
	private OverlapOperation m_OverlapOperation; //Field offset: 0x70
	[FormerlySerializedAs("m_PointLightDistance")]
	[SerializeField]
	private float m_NormalMapDistance; //Field offset: 0x74
	[FormerlySerializedAs("m_PointLightQuality")]
	[NotKeyable]
	[SerializeField]
	private NormalMapQuality m_NormalMapQuality; //Field offset: 0x78
	[SerializeField]
	private bool m_UseNormalMap; //Field offset: 0x7C
	[SerializeField]
	private bool m_ShadowIntensityEnabled; //Field offset: 0x7D
	[Range(0, 1)]
	[SerializeField]
	private float m_ShadowIntensity; //Field offset: 0x80
	[SerializeField]
	private bool m_ShadowVolumeIntensityEnabled; //Field offset: 0x84
	[Range(0, 1)]
	[SerializeField]
	private float m_ShadowVolumeIntensity; //Field offset: 0x88
	private Mesh m_Mesh; //Field offset: 0x90
	private LightMeshVertex[] m_Vertices; //Field offset: 0x98
	private UInt16[] m_Triangles; //Field offset: 0xA0
	private int m_PreviousLightCookieSprite; //Field offset: 0xA8
	internal Vector3 m_CachedPosition; //Field offset: 0xAC
	[SerializeField]
	private Bounds m_LocalBounds; //Field offset: 0xB8
	[CompilerGenerated]
	private BoundingSphere <boundingSphere>k__BackingField; //Field offset: 0xD0
	internal bool forceUpdate; //Field offset: 0xE0
	[SerializeField]
	private float m_PointLightInnerAngle; //Field offset: 0xE4
	[SerializeField]
	private float m_PointLightOuterAngle; //Field offset: 0xE8
	[SerializeField]
	private float m_PointLightInnerRadius; //Field offset: 0xEC
	[SerializeField]
	private float m_PointLightOuterRadius; //Field offset: 0xF0
	[SerializeField]
	private int m_ShapeLightParametricSides; //Field offset: 0xF4
	[SerializeField]
	private float m_ShapeLightParametricAngleOffset; //Field offset: 0xF8
	[SerializeField]
	private float m_ShapeLightParametricRadius; //Field offset: 0xFC
	[SerializeField]
	private float m_ShapeLightFalloffSize; //Field offset: 0x100
	[SerializeField]
	private Vector2 m_ShapeLightFalloffOffset; //Field offset: 0x104
	[SerializeField]
	private Vector3[] m_ShapePath; //Field offset: 0x110
	private float m_PreviousShapeLightFalloffSize; //Field offset: 0x118
	private int m_PreviousShapeLightParametricSides; //Field offset: 0x11C
	private float m_PreviousShapeLightParametricAngleOffset; //Field offset: 0x120
	private float m_PreviousShapeLightParametricRadius; //Field offset: 0x124
	private int m_PreviousShapePathHash; //Field offset: 0x128
	private LightType m_PreviousLightType; //Field offset: 0x12C

	internal Int32[] affectedSortingLayers
	{
		internal get { } //Length: 8
	}

	[Obsolete]
	public bool alphaBlendOnOverlap
	{
		 get { } //Length: 16
	}

	public int blendStyleIndex
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	internal BoundingSphere boundingSphere
	{
		[CompilerGenerated]
		internal get { } //Length: 12
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public Color color
	{
		 get { } //Length: 12
		 set { } //Length: 12
	}

	public float falloffIntensity
	{
		 get { } //Length: 8
		 set { } //Length: 28
	}

	internal bool hasCachedMesh
	{
		internal get { } //Length: 64
	}

	internal UInt16[] indices
	{
		internal get { } //Length: 8
		internal set { } //Length: 8
	}

	public float intensity
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	internal bool isPointLight
	{
		internal get { } //Length: 16
	}

	public Sprite lightCookieSprite
	{
		 get { } //Length: 28
		 set { } //Length: 8
	}

	private int lightCookieSpriteInstanceID
	{
		private get { } //Length: 20
	}

	internal Mesh lightMesh
	{
		internal get { } //Length: 160
	}

	public int lightOrder
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public LightType lightType
	{
		 get { } //Length: 8
		 set { } //Length: 116
	}

	public float normalMapDistance
	{
		 get { } //Length: 8
	}

	public NormalMapQuality normalMapQuality
	{
		 get { } //Length: 8
	}

	public OverlapOperation overlapOperation
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	[Obsolete("pointLightDistance has been changed to normalMapDistance", True)]
	public float pointLightDistance
	{
		 get { } //Length: 8
	}

	public float pointLightInnerAngle
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float pointLightInnerRadius
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float pointLightOuterAngle
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float pointLightOuterRadius
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	[Obsolete("pointLightQuality has been changed to normalMapQuality", True)]
	public NormalMapQuality pointLightQuality
	{
		 get { } //Length: 8
	}

	public bool renderVolumetricShadows
	{
		 get { } //Length: 32
	}

	public float shadowIntensity
	{
		 get { } //Length: 8
		 set { } //Length: 28
	}

	public bool shadowsEnabled
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public float shadowVolumeIntensity
	{
		 get { } //Length: 8
		 set { } //Length: 28
	}

	public float shapeLightFalloffSize
	{
		 get { } //Length: 8
		 set { } //Length: 16
	}

	public float shapeLightParametricAngleOffset
	{
		 get { } //Length: 8
	}

	public internal float shapeLightParametricRadius
	{
		 get { } //Length: 8
		internal set { } //Length: 8
	}

	public int shapeLightParametricSides
	{
		 get { } //Length: 8
	}

	public internal Vector3[] shapePath
	{
		 get { } //Length: 8
		internal set { } //Length: 8
	}

	internal LightMeshVertex[] vertices
	{
		internal get { } //Length: 8
		internal set { } //Length: 8
	}

	public float volumeIntensity
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public bool volumeIntensityEnabled
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	[Obsolete]
	public float volumeOpacity
	{
		 get { } //Length: 8
	}

	public bool volumetricShadowsEnabled
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public Light2D() { }

	private void Awake() { }

	internal void CacheValues() { }

	internal Int32[] get_affectedSortingLayers() { }

	public bool get_alphaBlendOnOverlap() { }

	public int get_blendStyleIndex() { }

	[CompilerGenerated]
	internal BoundingSphere get_boundingSphere() { }

	public Color get_color() { }

	public float get_falloffIntensity() { }

	internal bool get_hasCachedMesh() { }

	internal UInt16[] get_indices() { }

	public float get_intensity() { }

	internal bool get_isPointLight() { }

	public Sprite get_lightCookieSprite() { }

	private int get_lightCookieSpriteInstanceID() { }

	internal Mesh get_lightMesh() { }

	public int get_lightOrder() { }

	public LightType get_lightType() { }

	public float get_normalMapDistance() { }

	public NormalMapQuality get_normalMapQuality() { }

	public OverlapOperation get_overlapOperation() { }

	public float get_pointLightDistance() { }

	public float get_pointLightInnerAngle() { }

	public float get_pointLightInnerRadius() { }

	public float get_pointLightOuterAngle() { }

	public float get_pointLightOuterRadius() { }

	public NormalMapQuality get_pointLightQuality() { }

	public bool get_renderVolumetricShadows() { }

	public float get_shadowIntensity() { }

	public bool get_shadowsEnabled() { }

	public float get_shadowVolumeIntensity() { }

	public float get_shapeLightFalloffSize() { }

	public float get_shapeLightParametricAngleOffset() { }

	public float get_shapeLightParametricRadius() { }

	public int get_shapeLightParametricSides() { }

	public Vector3[] get_shapePath() { }

	internal LightMeshVertex[] get_vertices() { }

	public float get_volumeIntensity() { }

	public bool get_volumeIntensityEnabled() { }

	public float get_volumeOpacity() { }

	public bool get_volumetricShadowsEnabled() { }

	internal int GetTopMostLitLayer() { }

	internal bool IsLitLayer(int layer) { }

	private void LateUpdate() { }

	internal void MarkForUpdate() { }

	public override void OnAfterDeserialize() { }

	public override void OnBeforeSerialize() { }

	private void OnDisable() { }

	private void OnEnable() { }

	public void set_blendStyleIndex(int value) { }

	[CompilerGenerated]
	private void set_boundingSphere(BoundingSphere value) { }

	public void set_color(Color value) { }

	public void set_falloffIntensity(float value) { }

	internal void set_indices(UInt16[] value) { }

	public void set_intensity(float value) { }

	public void set_lightCookieSprite(Sprite value) { }

	public void set_lightOrder(int value) { }

	public void set_lightType(LightType value) { }

	public void set_overlapOperation(OverlapOperation value) { }

	public void set_pointLightInnerAngle(float value) { }

	public void set_pointLightInnerRadius(float value) { }

	public void set_pointLightOuterAngle(float value) { }

	public void set_pointLightOuterRadius(float value) { }

	public void set_shadowIntensity(float value) { }

	public void set_shadowsEnabled(bool value) { }

	public void set_shadowVolumeIntensity(float value) { }

	public void set_shapeLightFalloffSize(float value) { }

	internal void set_shapeLightParametricRadius(float value) { }

	internal void set_shapePath(Vector3[] value) { }

	internal void set_vertices(LightMeshVertex[] value) { }

	public void set_volumeIntensity(float value) { }

	public void set_volumeIntensityEnabled(bool value) { }

	public void set_volumetricShadowsEnabled(bool value) { }

	public void SetShapePath(Vector3[] path) { }

	internal void UpdateBoundingSphere() { }

	internal void UpdateMesh(bool forceUpdate = false) { }

	internal Bounds UpdateSpriteMesh() { }

}

