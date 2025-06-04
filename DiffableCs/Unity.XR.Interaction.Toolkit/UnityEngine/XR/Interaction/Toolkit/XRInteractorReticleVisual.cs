namespace UnityEngine.XR.Interaction.Toolkit;

[AddComponentMenu("XR/Visual/XR Interactor Reticle Visual", 11)]
[DisallowMultipleComponent]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.XRInteractorReticleVisual.html")]
public class XRInteractorReticleVisual : MonoBehaviour
{
	private const int k_MaxRaycastHits = 10; //Field offset: 0x0
	[SerializeField]
	private float m_MaxRaycastDistance; //Field offset: 0x20
	[SerializeField]
	private GameObject m_ReticlePrefab; //Field offset: 0x28
	[SerializeField]
	private float m_PrefabScalingFactor; //Field offset: 0x30
	[SerializeField]
	private bool m_UndoDistanceScaling; //Field offset: 0x34
	[SerializeField]
	private bool m_AlignPrefabWithSurfaceNormal; //Field offset: 0x35
	[SerializeField]
	private float m_EndpointSmoothingTime; //Field offset: 0x38
	[SerializeField]
	private bool m_DrawWhileSelecting; //Field offset: 0x3C
	[SerializeField]
	private bool m_DrawOnNoHit; //Field offset: 0x3D
	[SerializeField]
	private LayerMask m_RaycastMask; //Field offset: 0x40
	private bool m_ReticleActive; //Field offset: 0x44
	private NativeArray<Vector3> m_InteractorLinePoints; //Field offset: 0x48
	private XROrigin m_XROrigin; //Field offset: 0x58
	private GameObject m_ReticleInstance; //Field offset: 0x60
	private XRBaseInteractor m_Interactor; //Field offset: 0x68
	private Vector3 m_TargetEndPoint; //Field offset: 0x70
	private Vector3 m_TargetEndNormal; //Field offset: 0x7C
	private PhysicsScene m_LocalPhysicsScene; //Field offset: 0x88
	private bool m_HasRaycastHit; //Field offset: 0x8C
	private readonly RaycastHit[] m_RaycastHits; //Field offset: 0x90

	public bool alignPrefabWithSurfaceNormal
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool drawOnNoHit
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool drawWhileSelecting
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public float endpointSmoothingTime
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float maxRaycastDistance
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float prefabScalingFactor
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public LayerMask raycastMask
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public bool reticleActive
	{
		 get { } //Length: 8
		 set { } //Length: 160
	}

	public GameObject reticlePrefab
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public bool undoDistanceScaling
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public XRInteractorReticleVisual() { }

	private void ActivateReticleAtTarget() { }

	protected void Awake() { }

	private static RaycastHit FindClosestHit(RaycastHit[] hits, int hitCount) { }

	private void FindXROrigin() { }

	public bool get_alignPrefabWithSurfaceNormal() { }

	public bool get_drawOnNoHit() { }

	public bool get_drawWhileSelecting() { }

	public float get_endpointSmoothingTime() { }

	public float get_maxRaycastDistance() { }

	public float get_prefabScalingFactor() { }

	public LayerMask get_raycastMask() { }

	public bool get_reticleActive() { }

	public GameObject get_reticlePrefab() { }

	public bool get_undoDistanceScaling() { }

	protected void OnDestroy() { }

	protected void OnDisable() { }

	private void OnSelectEntered(SelectEnterEventArgs args) { }

	public void set_alignPrefabWithSurfaceNormal(bool value) { }

	public void set_drawOnNoHit(bool value) { }

	public void set_drawWhileSelecting(bool value) { }

	public void set_endpointSmoothingTime(float value) { }

	public void set_maxRaycastDistance(float value) { }

	public void set_prefabScalingFactor(float value) { }

	public void set_raycastMask(LayerMask value) { }

	public void set_reticleActive(bool value) { }

	public void set_reticlePrefab(GameObject value) { }

	public void set_undoDistanceScaling(bool value) { }

	private void SetupReticlePrefab() { }

	private bool TryGetRaycastPoint(ref Vector3 raycastPos, ref Vector3 raycastNormal) { }

	protected void Update() { }

	private bool UpdateReticleTarget() { }

}

