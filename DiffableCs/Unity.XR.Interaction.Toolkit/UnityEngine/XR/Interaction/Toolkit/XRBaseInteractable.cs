namespace UnityEngine.XR.Interaction.Toolkit;

[DefaultExecutionOrder(-98)]
[SelectionBase]
public abstract class XRBaseInteractable : MonoBehaviour, IXRActivateInteractable, IXRInteractable, IXRHoverInteractable, IXRSelectInteractable, IXRFocusInteractable, IXRInteractionStrengthInteractable, IXROverridesGazeAutoSelect
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<Collider> <>9__183_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <Awake>b__183_0(Collider col) { }

	}

	internal enum DistanceCalculationMode
	{
		TransformPosition = 0,
		ColliderPosition = 1,
		ColliderVolume = 2,
	}

	internal enum MovementType
	{
		VelocityTracking = 0,
		Kinematic = 1,
		Instantaneous = 2,
	}

	private const float k_InteractionStrengthHover = 0; //Field offset: 0x0
	private static readonly ProfilerMarker s_ProcessInteractionStrengthMarker; //Field offset: 0x0
	private const float k_InteractionStrengthSelect = 1; //Field offset: 0x0
	[CompilerGenerated]
	private Action<InteractableRegisteredEventArgs> registered; //Field offset: 0x20
	[CompilerGenerated]
	private Action<InteractableUnregisteredEventArgs> unregistered; //Field offset: 0x28
	[CompilerGenerated]
	private Func<IXRInteractable, Vector3, DistanceInfo> <getDistanceOverride>k__BackingField; //Field offset: 0x30
	[SerializeField]
	private XRInteractionManager m_InteractionManager; //Field offset: 0x38
	[SerializeField]
	private List<Collider> m_Colliders; //Field offset: 0x40
	[SerializeField]
	private LayerMask m_InteractionLayerMask; //Field offset: 0x48
	[SerializeField]
	private InteractionLayerMask m_InteractionLayers; //Field offset: 0x4C
	[SerializeField]
	private DistanceCalculationMode m_DistanceCalculationMode; //Field offset: 0x54
	[SerializeField]
	private InteractableSelectMode m_SelectMode; //Field offset: 0x58
	[SerializeField]
	private InteractableFocusMode m_FocusMode; //Field offset: 0x5C
	[SerializeField]
	private GameObject m_CustomReticle; //Field offset: 0x60
	[SerializeField]
	private bool m_AllowGazeInteraction; //Field offset: 0x68
	[SerializeField]
	private bool m_AllowGazeSelect; //Field offset: 0x69
	[SerializeField]
	private bool m_OverrideGazeTimeToSelect; //Field offset: 0x6A
	[SerializeField]
	private float m_GazeTimeToSelect; //Field offset: 0x6C
	[SerializeField]
	private bool m_OverrideTimeToAutoDeselectGaze; //Field offset: 0x70
	[SerializeField]
	private float m_TimeToAutoDeselectGaze; //Field offset: 0x74
	[SerializeField]
	private bool m_AllowGazeAssistance; //Field offset: 0x78
	[SerializeField]
	private HoverEnterEvent m_FirstHoverEntered; //Field offset: 0x80
	[SerializeField]
	private HoverExitEvent m_LastHoverExited; //Field offset: 0x88
	[SerializeField]
	private HoverEnterEvent m_HoverEntered; //Field offset: 0x90
	[SerializeField]
	private HoverExitEvent m_HoverExited; //Field offset: 0x98
	[SerializeField]
	private SelectEnterEvent m_FirstSelectEntered; //Field offset: 0xA0
	[SerializeField]
	private SelectExitEvent m_LastSelectExited; //Field offset: 0xA8
	[SerializeField]
	private SelectEnterEvent m_SelectEntered; //Field offset: 0xB0
	[SerializeField]
	private SelectExitEvent m_SelectExited; //Field offset: 0xB8
	[SerializeField]
	private FocusEnterEvent m_FirstFocusEntered; //Field offset: 0xC0
	[SerializeField]
	private FocusExitEvent m_LastFocusExited; //Field offset: 0xC8
	[SerializeField]
	private FocusEnterEvent m_FocusEntered; //Field offset: 0xD0
	[SerializeField]
	private FocusExitEvent m_FocusExited; //Field offset: 0xD8
	[SerializeField]
	private ActivateEvent m_Activated; //Field offset: 0xE0
	[SerializeField]
	private DeactivateEvent m_Deactivated; //Field offset: 0xE8
	private readonly HashSetList<IXRHoverInteractor> m_InteractorsHovering; //Field offset: 0xF0
	private readonly HashSetList<IXRSelectInteractor> m_InteractorsSelecting; //Field offset: 0xF8
	[CompilerGenerated]
	private IXRSelectInteractor <firstInteractorSelecting>k__BackingField; //Field offset: 0x100
	private readonly HashSetList<IXRInteractionGroup> m_InteractionGroupsFocusing; //Field offset: 0x108
	[CompilerGenerated]
	private IXRInteractionGroup <firstInteractionGroupFocusing>k__BackingField; //Field offset: 0x110
	[RequireInterface(typeof(IXRHoverFilter))]
	[SerializeField]
	private List<Object> m_StartingHoverFilters; //Field offset: 0x118
	private readonly ExposedRegistrationList<IXRHoverFilter> m_HoverFilters; //Field offset: 0x120
	[RequireInterface(typeof(IXRSelectFilter))]
	[SerializeField]
	private List<Object> m_StartingSelectFilters; //Field offset: 0x128
	private readonly ExposedRegistrationList<IXRSelectFilter> m_SelectFilters; //Field offset: 0x130
	[RequireInterface(typeof(IXRInteractionStrengthFilter))]
	[SerializeField]
	private List<Object> m_StartingInteractionStrengthFilters; //Field offset: 0x138
	private readonly ExposedRegistrationList<IXRInteractionStrengthFilter> m_InteractionStrengthFilters; //Field offset: 0x140
	private readonly BindableVariable<Single> m_LargestInteractionStrength; //Field offset: 0x148
	private readonly Dictionary<IXRSelectInteractor, Pose> m_AttachPoseOnSelect; //Field offset: 0x150
	private readonly Dictionary<IXRSelectInteractor, Pose> m_LocalAttachPoseOnSelect; //Field offset: 0x158
	private readonly Dictionary<IXRInteractor, GameObject> m_ReticleCache; //Field offset: 0x160
	private readonly HashSetList<XRBaseControllerInteractor> m_VariableSelectInteractors; //Field offset: 0x168
	private readonly Dictionary<IXRInteractor, Single> m_InteractionStrengths; //Field offset: 0x170
	private XRInteractionManager m_RegisteredInteractionManager; //Field offset: 0x178
	[FormerlySerializedAs("m_OnFirstHoverEnter")]
	[SerializeField]
	private XRInteractableEvent m_OnFirstHoverEntered; //Field offset: 0x180
	[FormerlySerializedAs("m_OnLastHoverExit")]
	[SerializeField]
	private XRInteractableEvent m_OnLastHoverExited; //Field offset: 0x188
	[FormerlySerializedAs("m_OnHoverEnter")]
	[SerializeField]
	private XRInteractableEvent m_OnHoverEntered; //Field offset: 0x190
	[FormerlySerializedAs("m_OnHoverExit")]
	[SerializeField]
	private XRInteractableEvent m_OnHoverExited; //Field offset: 0x198
	[FormerlySerializedAs("m_OnSelectEnter")]
	[SerializeField]
	private XRInteractableEvent m_OnSelectEntered; //Field offset: 0x1A0
	[FormerlySerializedAs("m_OnSelectExit")]
	[SerializeField]
	private XRInteractableEvent m_OnSelectExited; //Field offset: 0x1A8
	[FormerlySerializedAs("m_OnSelectCancel")]
	[SerializeField]
	private XRInteractableEvent m_OnSelectCanceled; //Field offset: 0x1B0
	[SerializeField]
	private XRInteractableEvent m_OnActivate; //Field offset: 0x1B8
	[SerializeField]
	private XRInteractableEvent m_OnDeactivate; //Field offset: 0x1C0
	[CompilerGenerated]
	private readonly List<XRBaseInteractor> <hoveringInteractors>k__BackingField; //Field offset: 0x1C8

	public override event Action<InteractableRegisteredEventArgs> registered
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public override event Action<InteractableUnregisteredEventArgs> unregistered
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public override ActivateEvent activated
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public bool allowGazeAssistance
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool allowGazeInteraction
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool allowGazeSelect
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public override bool canFocus
	{
		 get { } //Length: 16
	}

	public override List<Collider> colliders
	{
		 get { } //Length: 8
	}

	public GameObject customReticle
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public override DeactivateEvent deactivated
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public DistanceCalculationMode distanceCalculationMode
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public override FocusEnterEvent firstFocusEntered
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public override HoverEnterEvent firstHoverEntered
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public private override IXRInteractionGroup firstInteractionGroupFocusing
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private override IXRSelectInteractor firstInteractorSelecting
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public override SelectEnterEvent firstSelectEntered
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public override FocusEnterEvent focusEntered
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public override FocusExitEvent focusExited
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public override InteractableFocusMode focusMode
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public override float gazeTimeToSelect
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public Func<IXRInteractable, Vector3, DistanceInfo> getDistanceOverride
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public override HoverEnterEvent hoverEntered
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public override HoverExitEvent hoverExited
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public IXRFilterList<IXRHoverFilter> hoverFilters
	{
		 get { } //Length: 8
	}

	[Obsolete("hoveringInteractors has been deprecated. Use interactorsHovering instead.")]
	public List<XRBaseInteractor> hoveringInteractors
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public override List<IXRInteractionGroup> interactionGroupsFocusing
	{
		 get { } //Length: 144
	}

	[Obsolete("interactionLayerMask has been deprecated. Use interactionLayers instead.")]
	public LayerMask interactionLayerMask
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public override InteractionLayerMask interactionLayers
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public XRInteractionManager interactionManager
	{
		 get { } //Length: 8
		 set { } //Length: 144
	}

	public IXRFilterList<IXRInteractionStrengthFilter> interactionStrengthFilters
	{
		 get { } //Length: 8
	}

	public override List<IXRHoverInteractor> interactorsHovering
	{
		 get { } //Length: 144
	}

	public override List<IXRSelectInteractor> interactorsSelecting
	{
		 get { } //Length: 144
	}

	public override bool isFocused
	{
		 get { } //Length: 92
	}

	public override bool isHovered
	{
		 get { } //Length: 92
	}

	public override bool isSelected
	{
		 get { } //Length: 92
	}

	public override IReadOnlyBindableVariable<Single> largestInteractionStrength
	{
		 get { } //Length: 8
	}

	public override FocusExitEvent lastFocusExited
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public override HoverExitEvent lastHoverExited
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public override SelectExitEvent lastSelectExited
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	[Obsolete("onActivate has been deprecated. Use activated with updated signature instead.")]
	public XRInteractableEvent onActivate
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	[Obsolete("onDeactivate has been deprecated. Use deactivated with updated signature instead.")]
	public XRInteractableEvent onDeactivate
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	[Obsolete("onFirstHoverEnter has been deprecated. Use onFirstHoverEntered instead. (UnityUpgradable) -> onFirstHoverEntered")]
	public XRInteractableEvent onFirstHoverEnter
	{
		 get { } //Length: 8
	}

	[Obsolete("onFirstHoverEntered has been deprecated. Use firstHoverEntered with updated signature instead.")]
	public XRInteractableEvent onFirstHoverEntered
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	[Obsolete("onHoverEnter has been deprecated. Use onHoverEntered instead. (UnityUpgradable) -> onHoverEntered")]
	public XRInteractableEvent onHoverEnter
	{
		 get { } //Length: 8
	}

	[Obsolete("onHoverEntered has been deprecated. Use hoverEntered with updated signature instead.")]
	public XRInteractableEvent onHoverEntered
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	[Obsolete("onHoverExit has been deprecated. Use onHoverExited instead. (UnityUpgradable) -> onHoverExited")]
	public XRInteractableEvent onHoverExit
	{
		 get { } //Length: 8
	}

	[Obsolete("onHoverExited has been deprecated. Use hoverExited with updated signature instead.")]
	public XRInteractableEvent onHoverExited
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	[Obsolete("onLastHoverExit has been deprecated. Use onLastHoverExited instead. (UnityUpgradable) -> onLastHoverExited")]
	public XRInteractableEvent onLastHoverExit
	{
		 get { } //Length: 8
	}

	[Obsolete("onLastHoverExited has been deprecated. Use lastHoverExited with updated signature instead.")]
	public XRInteractableEvent onLastHoverExited
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	[Obsolete("onSelectCancel has been deprecated. Use onSelectCanceled instead. (UnityUpgradable) -> onSelectCanceled")]
	public XRInteractableEvent onSelectCancel
	{
		 get { } //Length: 8
	}

	[Obsolete("onSelectCanceled has been deprecated. Use selectExited with updated signature and check for args.isCanceled instead.")]
	public XRInteractableEvent onSelectCanceled
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	[Obsolete("onSelectEnter has been deprecated. Use onSelectEntered instead. (UnityUpgradable) -> onSelectEntered")]
	public XRInteractableEvent onSelectEnter
	{
		 get { } //Length: 8
	}

	[Obsolete("onSelectEntered has been deprecated. Use selectEntered with updated signature instead.")]
	public XRInteractableEvent onSelectEntered
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	[Obsolete("onSelectExit has been deprecated. Use onSelectExited instead. (UnityUpgradable) -> onSelectExited")]
	public XRInteractableEvent onSelectExit
	{
		 get { } //Length: 8
	}

	[Obsolete("onSelectExited has been deprecated. Use selectExited with updated signature and check for !args.isCanceled instead.")]
	public XRInteractableEvent onSelectExited
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public override bool overrideGazeTimeToSelect
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public override bool overrideTimeToAutoDeselectGaze
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public override SelectEnterEvent selectEntered
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public override SelectExitEvent selectExited
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public IXRFilterList<IXRSelectFilter> selectFilters
	{
		 get { } //Length: 8
	}

	[Obsolete("selectingInteractor has been deprecated. Use interactorsSelecting, GetOldestInteractorSelecting, or isSelected for similar functionality.")]
	public XRBaseInteractor selectingInteractor
	{
		 get { } //Length: 180
		 set { } //Length: 228
	}

	public override InteractableSelectMode selectMode
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public List<Object> startingHoverFilters
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public List<Object> startingInteractionStrengthFilters
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public List<Object> startingSelectFilters
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public override float timeToAutoDeselectGaze
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	private static XRBaseInteractable() { }

	protected XRBaseInteractable() { }

	[CompilerGenerated]
	public override void add_registered(Action<InteractableRegisteredEventArgs> value) { }

	[CompilerGenerated]
	public override void add_unregistered(Action<InteractableUnregisteredEventArgs> value) { }

	public override void AttachCustomReticle(IXRInteractor interactor) { }

	[Obsolete("AttachCustomReticle(XRBaseInteractor) has been deprecated. Use AttachCustomReticle(IXRInteractor) instead.")]
	public override void AttachCustomReticle(XRBaseInteractor interactor) { }

	protected override void Awake() { }

	protected void CaptureAttachPose(IXRSelectInteractor interactor) { }

	private void FindCreateInteractionManager() { }

	public override ActivateEvent get_activated() { }

	public bool get_allowGazeAssistance() { }

	public bool get_allowGazeInteraction() { }

	public bool get_allowGazeSelect() { }

	public override bool get_canFocus() { }

	public override List<Collider> get_colliders() { }

	public GameObject get_customReticle() { }

	public override DeactivateEvent get_deactivated() { }

	public DistanceCalculationMode get_distanceCalculationMode() { }

	public override FocusEnterEvent get_firstFocusEntered() { }

	public override HoverEnterEvent get_firstHoverEntered() { }

	[CompilerGenerated]
	public override IXRInteractionGroup get_firstInteractionGroupFocusing() { }

	[CompilerGenerated]
	public override IXRSelectInteractor get_firstInteractorSelecting() { }

	public override SelectEnterEvent get_firstSelectEntered() { }

	public override FocusEnterEvent get_focusEntered() { }

	public override FocusExitEvent get_focusExited() { }

	public override InteractableFocusMode get_focusMode() { }

	public override float get_gazeTimeToSelect() { }

	[CompilerGenerated]
	public Func<IXRInteractable, Vector3, DistanceInfo> get_getDistanceOverride() { }

	public override HoverEnterEvent get_hoverEntered() { }

	public override HoverExitEvent get_hoverExited() { }

	public IXRFilterList<IXRHoverFilter> get_hoverFilters() { }

	[CompilerGenerated]
	public List<XRBaseInteractor> get_hoveringInteractors() { }

	public override List<IXRInteractionGroup> get_interactionGroupsFocusing() { }

	public LayerMask get_interactionLayerMask() { }

	public override InteractionLayerMask get_interactionLayers() { }

	public XRInteractionManager get_interactionManager() { }

	public IXRFilterList<IXRInteractionStrengthFilter> get_interactionStrengthFilters() { }

	public override List<IXRHoverInteractor> get_interactorsHovering() { }

	public override List<IXRSelectInteractor> get_interactorsSelecting() { }

	public override bool get_isFocused() { }

	public override bool get_isHovered() { }

	public override bool get_isSelected() { }

	public override IReadOnlyBindableVariable<Single> get_largestInteractionStrength() { }

	public override FocusExitEvent get_lastFocusExited() { }

	public override HoverExitEvent get_lastHoverExited() { }

	public override SelectExitEvent get_lastSelectExited() { }

	public XRInteractableEvent get_onActivate() { }

	public XRInteractableEvent get_onDeactivate() { }

	public XRInteractableEvent get_onFirstHoverEnter() { }

	public XRInteractableEvent get_onFirstHoverEntered() { }

	public XRInteractableEvent get_onHoverEnter() { }

	public XRInteractableEvent get_onHoverEntered() { }

	public XRInteractableEvent get_onHoverExit() { }

	public XRInteractableEvent get_onHoverExited() { }

	public XRInteractableEvent get_onLastHoverExit() { }

	public XRInteractableEvent get_onLastHoverExited() { }

	public XRInteractableEvent get_onSelectCancel() { }

	public XRInteractableEvent get_onSelectCanceled() { }

	public XRInteractableEvent get_onSelectEnter() { }

	public XRInteractableEvent get_onSelectEntered() { }

	public XRInteractableEvent get_onSelectExit() { }

	public XRInteractableEvent get_onSelectExited() { }

	public override bool get_overrideGazeTimeToSelect() { }

	public override bool get_overrideTimeToAutoDeselectGaze() { }

	public override SelectEnterEvent get_selectEntered() { }

	public override SelectExitEvent get_selectExited() { }

	public IXRFilterList<IXRSelectFilter> get_selectFilters() { }

	public XRBaseInteractor get_selectingInteractor() { }

	public override InteractableSelectMode get_selectMode() { }

	public List<Object> get_startingHoverFilters() { }

	public List<Object> get_startingInteractionStrengthFilters() { }

	public List<Object> get_startingSelectFilters() { }

	public override float get_timeToAutoDeselectGaze() { }

	public override Pose GetAttachPoseOnSelect(IXRSelectInteractor interactor) { }

	public override Transform GetAttachTransform(IXRInteractor interactor) { }

	public override GameObject GetCustomReticle(IXRInteractor interactor) { }

	public override DistanceInfo GetDistance(Vector3 position) { }

	[Obsolete("GetDistanceSqrToInteractor(XRBaseInteractor) has been deprecated. Use GetDistanceSqrToInteractor(IXRInteractor) instead.")]
	public override float GetDistanceSqrToInteractor(XRBaseInteractor interactor) { }

	public override float GetDistanceSqrToInteractor(IXRInteractor interactor) { }

	public override float GetInteractionStrength(IXRInteractor interactor) { }

	public override Pose GetLocalAttachPoseOnSelect(IXRSelectInteractor interactor) { }

	public override bool IsHoverableBy(IXRHoverInteractor interactor) { }

	[Obsolete("IsHoverableBy(XRBaseInteractor) has been deprecated. Use IsHoverableBy(IXRHoverInteractor) instead.")]
	public override bool IsHoverableBy(XRBaseInteractor interactor) { }

	protected bool IsHovered(IXRInteractor interactor) { }

	public bool IsHovered(IXRHoverInteractor interactor) { }

	[Obsolete("IsSelectableBy(XRBaseInteractor) has been deprecated. Use IsSelectableBy(IXRSelectInteractor) instead.")]
	public override bool IsSelectableBy(XRBaseInteractor interactor) { }

	public override bool IsSelectableBy(IXRSelectInteractor interactor) { }

	protected bool IsSelected(IXRInteractor interactor) { }

	public bool IsSelected(IXRSelectInteractor interactor) { }

	[Obsolete("OnActivate(XRBaseInteractor) has been deprecated. Use OnActivated(ActivateEventArgs) instead.")]
	protected override void OnActivate(XRBaseInteractor interactor) { }

	protected override void OnActivated(ActivateEventArgs args) { }

	[Obsolete("OnDeactivate(XRBaseInteractor) has been deprecated. Use OnDeactivated(DeactivateEventArgs) instead.")]
	protected override void OnDeactivate(XRBaseInteractor interactor) { }

	protected override void OnDeactivated(DeactivateEventArgs args) { }

	protected override void OnDestroy() { }

	protected override void OnDisable() { }

	protected override void OnEnable() { }

	protected override void OnFocusEntered(FocusEnterEventArgs args) { }

	protected override void OnFocusEntering(FocusEnterEventArgs args) { }

	protected override void OnFocusExited(FocusExitEventArgs args) { }

	protected override void OnFocusExiting(FocusExitEventArgs args) { }

	protected override void OnHoverEntered(HoverEnterEventArgs args) { }

	[Obsolete("OnHoverEntered(XRBaseInteractor) has been deprecated. Use OnHoverEntered(HoverEnterEventArgs) instead.")]
	protected override void OnHoverEntered(XRBaseInteractor interactor) { }

	protected override void OnHoverEntering(HoverEnterEventArgs args) { }

	[Obsolete("OnHoverEntering(XRBaseInteractor) has been deprecated. Use OnHoverEntering(HoverEnterEventArgs) instead.")]
	protected override void OnHoverEntering(XRBaseInteractor interactor) { }

	protected override void OnHoverExited(HoverExitEventArgs args) { }

	[Obsolete("OnHoverExited(XRBaseInteractor) has been deprecated. Use OnHoverExited(HoverExitEventArgs) instead.")]
	protected override void OnHoverExited(XRBaseInteractor interactor) { }

	[Obsolete("OnHoverExiting(XRBaseInteractor) has been deprecated. Use OnHoverExiting(HoverExitEventArgs) instead.")]
	protected override void OnHoverExiting(XRBaseInteractor interactor) { }

	protected override void OnHoverExiting(HoverExitEventArgs args) { }

	protected override void OnRegistered(InteractableRegisteredEventArgs args) { }

	[Obsolete("OnSelectCanceled(XRBaseInteractor) has been deprecated. Use OnSelectExited(SelectExitEventArgs) and check for args.isCanceled instead.")]
	protected override void OnSelectCanceled(XRBaseInteractor interactor) { }

	[Obsolete("OnSelectCanceling(XRBaseInteractor) has been deprecated. Use OnSelectExiting(SelectExitEventArgs) and check for args.isCanceled instead.")]
	protected override void OnSelectCanceling(XRBaseInteractor interactor) { }

	protected override void OnSelectEntered(SelectEnterEventArgs args) { }

	[Obsolete("OnSelectEntered(XRBaseInteractor) has been deprecated. Use OnSelectEntered(SelectEnterEventArgs) instead.")]
	protected override void OnSelectEntered(XRBaseInteractor interactor) { }

	[Obsolete("OnSelectEntering(XRBaseInteractor) has been deprecated. Use OnSelectEntering(SelectEnterEventArgs) instead.")]
	protected override void OnSelectEntering(XRBaseInteractor interactor) { }

	protected override void OnSelectEntering(SelectEnterEventArgs args) { }

	[Obsolete("OnSelectExited(XRBaseInteractor) has been deprecated. Use OnSelectExited(SelectExitEventArgs) and check for !args.isCanceled instead.")]
	protected override void OnSelectExited(XRBaseInteractor interactor) { }

	protected override void OnSelectExited(SelectExitEventArgs args) { }

	protected override void OnSelectExiting(SelectExitEventArgs args) { }

	[Obsolete("OnSelectExiting(XRBaseInteractor) has been deprecated. Use OnSelectExiting(SelectExitEventArgs) and check for !args.isCanceled instead.")]
	protected override void OnSelectExiting(XRBaseInteractor interactor) { }

	protected override void OnUnregistered(InteractableUnregisteredEventArgs args) { }

	protected bool ProcessHoverFilters(IXRHoverInteractor interactor) { }

	public override void ProcessInteractable(UpdatePhase updatePhase) { }

	protected override void ProcessInteractionStrength(UpdatePhase updatePhase) { }

	protected float ProcessInteractionStrengthFilters(IXRInteractor interactor, float interactionStrength) { }

	protected bool ProcessSelectFilters(IXRSelectInteractor interactor) { }

	private void RegisterWithInteractionManager() { }

	[CompilerGenerated]
	public override void remove_registered(Action<InteractableRegisteredEventArgs> value) { }

	[CompilerGenerated]
	public override void remove_unregistered(Action<InteractableUnregisteredEventArgs> value) { }

	public override void RemoveCustomReticle(IXRInteractor interactor) { }

	[Obsolete("RemoveCustomReticle(XRBaseInteractor) has been deprecated. Use RemoveCustomReticle(IXRInteractor) instead.")]
	public override void RemoveCustomReticle(XRBaseInteractor interactor) { }

	[Conditional("UNITY_EDITOR")]
	protected override void Reset() { }

	public void set_activated(ActivateEvent value) { }

	public void set_allowGazeAssistance(bool value) { }

	public void set_allowGazeInteraction(bool value) { }

	public void set_allowGazeSelect(bool value) { }

	public void set_customReticle(GameObject value) { }

	public void set_deactivated(DeactivateEvent value) { }

	public void set_distanceCalculationMode(DistanceCalculationMode value) { }

	public void set_firstFocusEntered(FocusEnterEvent value) { }

	public void set_firstHoverEntered(HoverEnterEvent value) { }

	[CompilerGenerated]
	private void set_firstInteractionGroupFocusing(IXRInteractionGroup value) { }

	[CompilerGenerated]
	private void set_firstInteractorSelecting(IXRSelectInteractor value) { }

	public void set_firstSelectEntered(SelectEnterEvent value) { }

	public void set_focusEntered(FocusEnterEvent value) { }

	public void set_focusExited(FocusExitEvent value) { }

	public void set_focusMode(InteractableFocusMode value) { }

	public void set_gazeTimeToSelect(float value) { }

	[CompilerGenerated]
	public void set_getDistanceOverride(Func<IXRInteractable, Vector3, DistanceInfo> value) { }

	public void set_hoverEntered(HoverEnterEvent value) { }

	public void set_hoverExited(HoverExitEvent value) { }

	public void set_interactionLayerMask(LayerMask value) { }

	public void set_interactionLayers(InteractionLayerMask value) { }

	public void set_interactionManager(XRInteractionManager value) { }

	public void set_lastFocusExited(FocusExitEvent value) { }

	public void set_lastHoverExited(HoverExitEvent value) { }

	public void set_lastSelectExited(SelectExitEvent value) { }

	public void set_onActivate(XRInteractableEvent value) { }

	public void set_onDeactivate(XRInteractableEvent value) { }

	public void set_onFirstHoverEntered(XRInteractableEvent value) { }

	public void set_onHoverEntered(XRInteractableEvent value) { }

	public void set_onHoverExited(XRInteractableEvent value) { }

	public void set_onLastHoverExited(XRInteractableEvent value) { }

	public void set_onSelectCanceled(XRInteractableEvent value) { }

	public void set_onSelectEntered(XRInteractableEvent value) { }

	public void set_onSelectExited(XRInteractableEvent value) { }

	public void set_overrideGazeTimeToSelect(bool value) { }

	public void set_overrideTimeToAutoDeselectGaze(bool value) { }

	public void set_selectEntered(SelectEnterEvent value) { }

	public void set_selectExited(SelectExitEvent value) { }

	protected void set_selectingInteractor(XRBaseInteractor value) { }

	public void set_selectMode(InteractableSelectMode value) { }

	public void set_startingHoverFilters(List<Object> value) { }

	public void set_startingInteractionStrengthFilters(List<Object> value) { }

	public void set_startingSelectFilters(List<Object> value) { }

	public void set_timeToAutoDeselectGaze(float value) { }

	private override void UnityEngine.XR.Interaction.Toolkit.IXRActivateInteractable.OnActivated(ActivateEventArgs args) { }

	private override void UnityEngine.XR.Interaction.Toolkit.IXRActivateInteractable.OnDeactivated(DeactivateEventArgs args) { }

	private override void UnityEngine.XR.Interaction.Toolkit.IXRFocusInteractable.OnFocusEntered(FocusEnterEventArgs args) { }

	private override void UnityEngine.XR.Interaction.Toolkit.IXRFocusInteractable.OnFocusEntering(FocusEnterEventArgs args) { }

	private override void UnityEngine.XR.Interaction.Toolkit.IXRFocusInteractable.OnFocusExited(FocusExitEventArgs args) { }

	private override void UnityEngine.XR.Interaction.Toolkit.IXRFocusInteractable.OnFocusExiting(FocusExitEventArgs args) { }

	private override bool UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractable.IsHoverableBy(IXRHoverInteractor interactor) { }

	private override void UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractable.OnHoverEntered(HoverEnterEventArgs args) { }

	private override void UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractable.OnHoverEntering(HoverEnterEventArgs args) { }

	private override void UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractable.OnHoverExited(HoverExitEventArgs args) { }

	private override void UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractable.OnHoverExiting(HoverExitEventArgs args) { }

	private override Transform UnityEngine.XR.Interaction.Toolkit.IXRInteractable.get_transform() { }

	private override void UnityEngine.XR.Interaction.Toolkit.IXRInteractable.OnRegistered(InteractableRegisteredEventArgs args) { }

	private override void UnityEngine.XR.Interaction.Toolkit.IXRInteractable.OnUnregistered(InteractableUnregisteredEventArgs args) { }

	private override void UnityEngine.XR.Interaction.Toolkit.IXRInteractionStrengthInteractable.ProcessInteractionStrength(UpdatePhase updatePhase) { }

	private override bool UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractable.IsSelectableBy(IXRSelectInteractor interactor) { }

	private override void UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractable.OnSelectEntered(SelectEnterEventArgs args) { }

	private override void UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractable.OnSelectEntering(SelectEnterEventArgs args) { }

	private override void UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractable.OnSelectExited(SelectExitEventArgs args) { }

	private override void UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractable.OnSelectExiting(SelectExitEventArgs args) { }

	private void UnregisterWithInteractionManager() { }

}

