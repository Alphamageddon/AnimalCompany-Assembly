namespace UnityEngine.XR.Interaction.Toolkit;

[AddComponentMenu("XR/XR Poke Interactor", 11)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.XRPokeInteractor.html")]
public class XRPokeInteractor : XRBaseInteractor, IUIHoverInteractor, IUIInteractor, IPokeStateDataProvider
{
	[IsReadOnly]
	private struct PokeCollision
	{
		public readonly IXRInteractable interactable; //Field offset: 0x0
		public readonly IXRPokeFilter filter; //Field offset: 0x8

		public PokeCollision(IXRInteractable interactable, IXRPokeFilter filter) { }

	}

	private static readonly List<IXRInteractable> s_Results; //Field offset: 0x0
	private static readonly Dictionary<IXRInteractable, IXRPokeFilter> s_ValidTargetsScratchMap; //Field offset: 0x8
	[SerializeField]
	[Tooltip("The depth threshold within which an interaction can begin to be evaluated as a poke.")]
	private float m_PokeDepth; //Field offset: 0x1A8
	[SerializeField]
	[Tooltip("The width threshold within which an interaction can begin to be evaluated as a poke.")]
	private float m_PokeWidth; //Field offset: 0x1AC
	[SerializeField]
	[Tooltip("The width threshold within which an interaction can be evaluated as a poke select.")]
	private float m_PokeSelectWidth; //Field offset: 0x1B0
	[SerializeField]
	[Tooltip("The radius threshold within which an interaction can be evaluated as a poke hover.")]
	private float m_PokeHoverRadius; //Field offset: 0x1B4
	[SerializeField]
	[Tooltip("Distance along the poke interactable interaction axis that allows for a poke to be triggered sooner/with less precision.")]
	private float m_PokeInteractionOffset; //Field offset: 0x1B8
	[SerializeField]
	[Tooltip("Physics layer mask used for limiting poke sphere overlap.")]
	private LayerMask m_PhysicsLayerMask; //Field offset: 0x1BC
	[SerializeField]
	[Tooltip("Determines whether the poke sphere overlap will hit triggers.")]
	private QueryTriggerInteraction m_PhysicsTriggerInteraction; //Field offset: 0x1C0
	[SerializeField]
	[Tooltip("Denotes whether or not valid targets will only include objects with a poke filter.")]
	private bool m_RequirePokeFilter; //Field offset: 0x1C4
	[SerializeField]
	[Tooltip("When enabled, this allows the poke interactor to hover and select UI elements.")]
	private bool m_EnableUIInteraction; //Field offset: 0x1C5
	[SerializeField]
	[Tooltip("Denotes whether or not debug visuals are enabled for this poke interactor.")]
	private bool m_DebugVisualizationsEnabled; //Field offset: 0x1C6
	[SerializeField]
	private UIHoverEnterEvent m_UIHoverEntered; //Field offset: 0x1C8
	[SerializeField]
	private UIHoverExitEvent m_UIHoverExited; //Field offset: 0x1D0
	private BindableVariable<PokeStateData> m_PokeStateData; //Field offset: 0x1D8
	private GameObject m_HoverDebugSphere; //Field offset: 0x1E0
	private MeshRenderer m_HoverDebugRenderer; //Field offset: 0x1E8
	private Vector3 m_LastPokeInteractionPoint; //Field offset: 0x1F0
	private bool m_FirstFrame; //Field offset: 0x1FC
	private IXRSelectInteractable m_CurrentPokeTarget; //Field offset: 0x200
	private IXRPokeFilter m_CurrentPokeFilter; //Field offset: 0x208
	private readonly RaycastHit[] m_SphereCastHits; //Field offset: 0x210
	private readonly Collider[] m_OverlapSphereHits; //Field offset: 0x218
	private readonly List<PokeCollision> m_PokeTargets; //Field offset: 0x220
	private readonly List<IXRSelectFilter> m_InteractableSelectFilters; //Field offset: 0x228
	private readonly List<IXRInteractable> m_ValidTargets; //Field offset: 0x230
	private RegisteredUIInteractorCache m_RegisteredUIInteractorCache; //Field offset: 0x238
	private PhysicsScene m_LocalPhysicsScene; //Field offset: 0x240
	private Func<Vector3> m_PositionGetter; //Field offset: 0x248

	public bool debugVisualizationsEnabled
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool enableUIInteraction
	{
		 get { } //Length: 8
		 set { } //Length: 48
	}

	public LayerMask physicsLayerMask
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public QueryTriggerInteraction physicsTriggerInteraction
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float pokeDepth
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float pokeHoverRadius
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float pokeInteractionOffset
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float pokeSelectWidth
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public override IReadOnlyBindableVariable<PokeStateData> pokeStateData
	{
		 get { } //Length: 8
	}

	public float pokeWidth
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public bool requirePokeFilter
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public override UIHoverEnterEvent uiHoverEntered
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public override UIHoverExitEvent uiHoverExited
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	private static XRPokeInteractor() { }

	public XRPokeInteractor() { }

	protected virtual void Awake() { }

	private int EvaluateSphereOverlap() { }

	private bool FindPokeTarget(Collider hitCollider, out PokeCollision newPokeCollision) { }

	public bool get_debugVisualizationsEnabled() { }

	public bool get_enableUIInteraction() { }

	public LayerMask get_physicsLayerMask() { }

	public QueryTriggerInteraction get_physicsTriggerInteraction() { }

	public float get_pokeDepth() { }

	public float get_pokeHoverRadius() { }

	public float get_pokeInteractionOffset() { }

	public float get_pokeSelectWidth() { }

	public override IReadOnlyBindableVariable<PokeStateData> get_pokeStateData() { }

	public float get_pokeWidth() { }

	public bool get_requirePokeFilter() { }

	public override UIHoverEnterEvent get_uiHoverEntered() { }

	public override UIHoverExitEvent get_uiHoverExited() { }

	private static T GetOrAddComponent(GameObject go) { }

	private Vector3 GetPokePosition() { }

	public virtual void GetValidTargets(List<IXRInteractable> targets) { }

	protected virtual void OnDestroy() { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	protected override void OnUIHoverEntered(UIHoverEventArgs args) { }

	protected override void OnUIHoverExited(UIHoverEventArgs args) { }

	public virtual void PreprocessInteractor(UpdatePhase updatePhase) { }

	public virtual void ProcessInteractor(UpdatePhase updatePhase) { }

	private void ProcessPokeStateData() { }

	private bool RegisterValidTargets(out IXRSelectInteractable currentTarget, out IXRPokeFilter pokeFilter) { }

	public void set_debugVisualizationsEnabled(bool value) { }

	public void set_enableUIInteraction(bool value) { }

	public void set_physicsLayerMask(LayerMask value) { }

	public void set_physicsTriggerInteraction(QueryTriggerInteraction value) { }

	public void set_pokeDepth(float value) { }

	public void set_pokeHoverRadius(float value) { }

	public void set_pokeInteractionOffset(float value) { }

	public void set_pokeSelectWidth(float value) { }

	public void set_pokeWidth(float value) { }

	public void set_requirePokeFilter(bool value) { }

	public void set_uiHoverEntered(UIHoverEnterEvent value) { }

	public void set_uiHoverExited(UIHoverExitEvent value) { }

	private void SetDebugObjectVisibility(bool isVisible) { }

	public override bool TryGetUIModel(out TrackedDeviceModel model) { }

	private override void UnityEngine.XR.Interaction.Toolkit.UI.IUIHoverInteractor.OnUIHoverEntered(UIHoverEventArgs args) { }

	private override void UnityEngine.XR.Interaction.Toolkit.UI.IUIHoverInteractor.OnUIHoverExited(UIHoverEventArgs args) { }

	private void UpdateDebugVisuals() { }

	public override void UpdateUIModel(ref TrackedDeviceModel model) { }

}

