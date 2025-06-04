namespace UnityEngine.XR.Interaction.Toolkit;

[DefaultExecutionOrder(-99)]
[DisallowMultipleComponent]
[SelectionBase]
public abstract class XRBaseInteractor : MonoBehaviour, IXRHoverInteractor, IXRInteractor, IXRSelectInteractor, IXRTargetPriorityInteractor, IXRGroupMember, IXRInteractionStrengthInteractor
{
	private const float k_InteractionStrengthHover = 0; //Field offset: 0x0
	private const int k_VelocityUpdateInterval = 6; //Field offset: 0x0
	private static readonly ProfilerMarker s_ProcessInteractionStrengthMarker; //Field offset: 0x0
	private const float k_InteractionStrengthSelect = 1; //Field offset: 0x0
	[CompilerGenerated]
	private Action<InteractorRegisteredEventArgs> registered; //Field offset: 0x20
	[CompilerGenerated]
	private Action<InteractorUnregisteredEventArgs> unregistered; //Field offset: 0x28
	[SerializeField]
	private XRInteractionManager m_InteractionManager; //Field offset: 0x30
	[CompilerGenerated]
	private IXRInteractionGroup <containingGroup>k__BackingField; //Field offset: 0x38
	[SerializeField]
	private LayerMask m_InteractionLayerMask; //Field offset: 0x40
	[SerializeField]
	private InteractionLayerMask m_InteractionLayers; //Field offset: 0x44
	[SerializeField]
	private Transform m_AttachTransform; //Field offset: 0x50
	[SerializeField]
	private bool m_KeepSelectedTargetValid; //Field offset: 0x58
	[SerializeField]
	private bool m_DisableVisualsWhenBlockedInGroup; //Field offset: 0x59
	[SerializeField]
	private XRBaseInteractable m_StartingSelectedInteractable; //Field offset: 0x60
	[SerializeField]
	private XRBaseTargetFilter m_StartingTargetFilter; //Field offset: 0x68
	[SerializeField]
	private HoverEnterEvent m_HoverEntered; //Field offset: 0x70
	[SerializeField]
	private HoverExitEvent m_HoverExited; //Field offset: 0x78
	[SerializeField]
	private SelectEnterEvent m_SelectEntered; //Field offset: 0x80
	[SerializeField]
	private SelectExitEvent m_SelectExited; //Field offset: 0x88
	private IXRTargetFilter m_TargetFilter; //Field offset: 0x90
	private bool m_AllowHover; //Field offset: 0x98
	private bool m_AllowSelect; //Field offset: 0x99
	private bool m_IsPerformingManualInteraction; //Field offset: 0x9A
	private readonly HashSetList<IXRHoverInteractable> m_InteractablesHovered; //Field offset: 0xA0
	private readonly HashSetList<IXRSelectInteractable> m_InteractablesSelected; //Field offset: 0xA8
	[CompilerGenerated]
	private IXRSelectInteractable <firstInteractableSelected>k__BackingField; //Field offset: 0xB0
	[CompilerGenerated]
	private bool <isInteractingWithUI>k__BackingField; //Field offset: 0xB8
	[RequireInterface(typeof(IXRHoverFilter))]
	[SerializeField]
	private List<Object> m_StartingHoverFilters; //Field offset: 0xC0
	private readonly ExposedRegistrationList<IXRHoverFilter> m_HoverFilters; //Field offset: 0xC8
	[RequireInterface(typeof(IXRSelectFilter))]
	[SerializeField]
	private List<Object> m_StartingSelectFilters; //Field offset: 0xD0
	private readonly ExposedRegistrationList<IXRSelectFilter> m_SelectFilters; //Field offset: 0xD8
	private readonly BindableVariable<Single> m_LargestInteractionStrength; //Field offset: 0xE0
	private readonly Dictionary<IXRSelectInteractable, Pose> m_AttachPoseOnSelect; //Field offset: 0xE8
	private readonly Dictionary<IXRSelectInteractable, Pose> m_LocalAttachPoseOnSelect; //Field offset: 0xF0
	private readonly HashSetList<IXRInteractionStrengthInteractable> m_InteractionStrengthInteractables; //Field offset: 0xF8
	private readonly Dictionary<IXRInteractable, Single> m_InteractionStrengths; //Field offset: 0x100
	private IXRSelectInteractable m_ManualInteractionInteractable; //Field offset: 0x108
	private XRInteractionManager m_RegisteredInteractionManager; //Field offset: 0x110
	[CompilerGenerated]
	private bool <useAttachPointVelocity>k__BackingField; //Field offset: 0x118
	private Vector3 m_AttachPointVelocity; //Field offset: 0x11C
	private Vector3 m_AttachPointAngularVelocity; //Field offset: 0x128
	private Transform m_XROriginTransform; //Field offset: 0x138
	private bool m_HasXROrigin; //Field offset: 0x140
	private bool m_FailedToFindXROrigin; //Field offset: 0x141
	[CompilerGenerated]
	private TargetPriorityMode <targetPriorityMode>k__BackingField; //Field offset: 0x144
	[CompilerGenerated]
	private List<IXRSelectInteractable> <targetsForSelection>k__BackingField; //Field offset: 0x148
	private float m_DeltaTimeStart; //Field offset: 0x150
	private int m_FrameOn; //Field offset: 0x154
	private readonly Vector3[] m_VelocityPositionsCache; //Field offset: 0x158
	private readonly Vector3[] m_VelocityNormalsCache; //Field offset: 0x160
	private Vector3 m_VelocityPositionsSum; //Field offset: 0x168
	private Vector3 m_VelocityNormalsSum; //Field offset: 0x174
	[FormerlySerializedAs("m_OnHoverEnter")]
	[SerializeField]
	private XRInteractorEvent m_OnHoverEntered; //Field offset: 0x180
	[FormerlySerializedAs("m_OnHoverExit")]
	[SerializeField]
	private XRInteractorEvent m_OnHoverExited; //Field offset: 0x188
	[FormerlySerializedAs("m_OnSelectEnter")]
	[SerializeField]
	private XRInteractorEvent m_OnSelectEntered; //Field offset: 0x190
	[FormerlySerializedAs("m_OnSelectExit")]
	[SerializeField]
	private XRInteractorEvent m_OnSelectExited; //Field offset: 0x198
	[CompilerGenerated]
	private readonly List<XRBaseInteractable> <hoverTargets>k__BackingField; //Field offset: 0x1A0

	public override event Action<InteractorRegisteredEventArgs> registered
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public override event Action<InteractorUnregisteredEventArgs> unregistered
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public bool allowHover
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool allowSelect
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public Transform attachTransform
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public private override IXRInteractionGroup containingGroup
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public bool disableVisualsWhenBlockedInGroup
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	[Obsolete("enableInteractions has been deprecated. Use allowHover and allowSelect instead.")]
	public bool enableInteractions
	{
		 get { } //Length: 32
		 set { } //Length: 16
	}

	public private override IXRSelectInteractable firstInteractableSelected
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public override bool hasHover
	{
		 get { } //Length: 92
	}

	public override bool hasSelection
	{
		 get { } //Length: 92
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

	[Obsolete("hoverTargets has been deprecated. Use interactablesHovered instead.")]
	protected List<XRBaseInteractable> hoverTargets
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public override List<IXRHoverInteractable> interactablesHovered
	{
		 get { } //Length: 144
	}

	public override List<IXRSelectInteractable> interactablesSelected
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

	public override bool isHoverActive
	{
		 get { } //Length: 8
	}

	internal bool isInteractingWithUI
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 12
	}

	public bool isPerformingManualInteraction
	{
		 get { } //Length: 8
	}

	public override bool isSelectActive
	{
		 get { } //Length: 8
	}

	public override bool keepSelectedTargetValid
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public override IReadOnlyBindableVariable<Single> largestInteractionStrength
	{
		 get { } //Length: 8
	}

	[Obsolete("onHoverEnter has been deprecated. Use onHoverEntered instead. (UnityUpgradable) -> onHoverEntered")]
	public XRInteractorEvent onHoverEnter
	{
		 get { } //Length: 8
	}

	[Obsolete("onHoverEntered has been deprecated. Use hoverEntered with updated signature instead.")]
	public XRInteractorEvent onHoverEntered
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	[Obsolete("onHoverExit has been deprecated. Use onHoverExited instead. (UnityUpgradable) -> onHoverExited")]
	public XRInteractorEvent onHoverExit
	{
		 get { } //Length: 8
	}

	[Obsolete("onHoverExited has been deprecated. Use hoverExited with updated signature instead.")]
	public XRInteractorEvent onHoverExited
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	[Obsolete("onSelectEnter has been deprecated. Use onSelectEntered instead. (UnityUpgradable) -> onSelectEntered")]
	public XRInteractorEvent onSelectEnter
	{
		 get { } //Length: 8
	}

	[Obsolete("onSelectEntered has been deprecated. Use selectEntered with updated signature instead.")]
	public XRInteractorEvent onSelectEntered
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	[Obsolete("onSelectExit has been deprecated. Use onSelectExited instead. (UnityUpgradable) -> onSelectExited")]
	public XRInteractorEvent onSelectExit
	{
		 get { } //Length: 8
	}

	[Obsolete("onSelectExited has been deprecated. Use selectExited with updated signature instead.")]
	public XRInteractorEvent onSelectExited
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	[Obsolete("requireSelectExclusive has been deprecated. Put logic in CanSelect instead.")]
	public override bool requireSelectExclusive
	{
		 get { } //Length: 8
	}

	public override Nullable<MovementType> selectedInteractableMovementTypeOverride
	{
		 get { } //Length: 8
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

	[Obsolete("selectTarget has been deprecated. Use interactablesSelected, GetOldestInteractableSelected, hasSelection, or IsSelecting for similar functionality.")]
	public XRBaseInteractable selectTarget
	{
		 get { } //Length: 180
		 set { } //Length: 96
	}

	public List<Object> startingHoverFilters
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public XRBaseInteractable startingSelectedInteractable
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public List<Object> startingSelectFilters
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public XRBaseTargetFilter startingTargetFilter
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public IXRTargetFilter targetFilter
	{
		 get { } //Length: 160
		 set { } //Length: 380
	}

	public override TargetPriorityMode targetPriorityMode
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public override List<IXRSelectInteractable> targetsForSelection
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	internal bool useAttachPointVelocity
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 12
	}

	private static XRBaseInteractor() { }

	protected XRBaseInteractor() { }

	[CompilerGenerated]
	public override void add_registered(Action<InteractorRegisteredEventArgs> value) { }

	[CompilerGenerated]
	public override void add_unregistered(Action<InteractorUnregisteredEventArgs> value) { }

	protected override void Awake() { }

	[Obsolete("CanHover(XRBaseInteractable) has been deprecated. Use CanHover(IXRHoverInteractable) instead.")]
	public override bool CanHover(XRBaseInteractable interactable) { }

	public override bool CanHover(IXRHoverInteractable interactable) { }

	[Obsolete("CanSelect(XRBaseInteractable) has been deprecated. Use CanSelect(IXRSelectInteractable) instead.")]
	public override bool CanSelect(XRBaseInteractable interactable) { }

	public override bool CanSelect(IXRSelectInteractable interactable) { }

	protected void CaptureAttachPose(IXRSelectInteractable interactable) { }

	protected void CreateAttachTransform() { }

	public override void EndManualInteraction() { }

	private void FindCreateInteractionManager() { }

	public bool get_allowHover() { }

	public bool get_allowSelect() { }

	public Transform get_attachTransform() { }

	[CompilerGenerated]
	public override IXRInteractionGroup get_containingGroup() { }

	public bool get_disableVisualsWhenBlockedInGroup() { }

	public bool get_enableInteractions() { }

	[CompilerGenerated]
	public override IXRSelectInteractable get_firstInteractableSelected() { }

	public override bool get_hasHover() { }

	public override bool get_hasSelection() { }

	public override HoverEnterEvent get_hoverEntered() { }

	public override HoverExitEvent get_hoverExited() { }

	public IXRFilterList<IXRHoverFilter> get_hoverFilters() { }

	[CompilerGenerated]
	protected List<XRBaseInteractable> get_hoverTargets() { }

	public override List<IXRHoverInteractable> get_interactablesHovered() { }

	public override List<IXRSelectInteractable> get_interactablesSelected() { }

	public LayerMask get_interactionLayerMask() { }

	public override InteractionLayerMask get_interactionLayers() { }

	public XRInteractionManager get_interactionManager() { }

	public override bool get_isHoverActive() { }

	[CompilerGenerated]
	internal bool get_isInteractingWithUI() { }

	public bool get_isPerformingManualInteraction() { }

	public override bool get_isSelectActive() { }

	public override bool get_keepSelectedTargetValid() { }

	public override IReadOnlyBindableVariable<Single> get_largestInteractionStrength() { }

	public XRInteractorEvent get_onHoverEnter() { }

	public XRInteractorEvent get_onHoverEntered() { }

	public XRInteractorEvent get_onHoverExit() { }

	public XRInteractorEvent get_onHoverExited() { }

	public XRInteractorEvent get_onSelectEnter() { }

	public XRInteractorEvent get_onSelectEntered() { }

	public XRInteractorEvent get_onSelectExit() { }

	public XRInteractorEvent get_onSelectExited() { }

	public override bool get_requireSelectExclusive() { }

	public override Nullable<MovementType> get_selectedInteractableMovementTypeOverride() { }

	public override SelectEnterEvent get_selectEntered() { }

	public override SelectExitEvent get_selectExited() { }

	public IXRFilterList<IXRSelectFilter> get_selectFilters() { }

	public XRBaseInteractable get_selectTarget() { }

	public List<Object> get_startingHoverFilters() { }

	public XRBaseInteractable get_startingSelectedInteractable() { }

	public List<Object> get_startingSelectFilters() { }

	public XRBaseTargetFilter get_startingTargetFilter() { }

	public IXRTargetFilter get_targetFilter() { }

	[CompilerGenerated]
	public override TargetPriorityMode get_targetPriorityMode() { }

	[CompilerGenerated]
	public override List<IXRSelectInteractable> get_targetsForSelection() { }

	[CompilerGenerated]
	internal bool get_useAttachPointVelocity() { }

	internal Vector3 GetAttachPointAngularVelocity() { }

	internal Vector3 GetAttachPointVelocity() { }

	public override Pose GetAttachPoseOnSelect(IXRSelectInteractable interactable) { }

	public override Transform GetAttachTransform(IXRInteractable interactable) { }

	[Obsolete("GetHoverTargets has been deprecated. Use interactablesHovered instead.")]
	public void GetHoverTargets(List<XRBaseInteractable> targets) { }

	public override float GetInteractionStrength(IXRInteractable interactable) { }

	public override Pose GetLocalAttachPoseOnSelect(IXRSelectInteractable interactable) { }

	[Obsolete("GetValidTargets(List<XRBaseInteractable>) has been deprecated. Override GetValidTargets(List<IXRInteractable>) instead. XRInteractionManager.GetValidTargets will stitch the results together with GetValidTargets(List<IXRInteractable>), but by default this method now does nothing.")]
	public override void GetValidTargets(List<XRBaseInteractable> targets) { }

	public override void GetValidTargets(List<IXRInteractable> targets) { }

	protected bool IsHovering(IXRInteractable interactable) { }

	public override bool IsHovering(IXRHoverInteractable interactable) { }

	public override bool IsSelecting(IXRSelectInteractable interactable) { }

	protected bool IsSelecting(IXRInteractable interactable) { }

	protected override void OnDestroy() { }

	protected override void OnDisable() { }

	protected override void OnEnable() { }

	[Obsolete("OnHoverEntered(XRBaseInteractable) has been deprecated. Use OnHoverEntered(HoverEnterEventArgs) instead.")]
	protected override void OnHoverEntered(XRBaseInteractable interactable) { }

	protected override void OnHoverEntered(HoverEnterEventArgs args) { }

	protected override void OnHoverEntering(HoverEnterEventArgs args) { }

	[Obsolete("OnHoverEntering(XRBaseInteractable) has been deprecated. Use OnHoverEntering(HoverEnterEventArgs) instead.")]
	protected override void OnHoverEntering(XRBaseInteractable interactable) { }

	[Obsolete("OnHoverExited(XRBaseInteractable) has been deprecated. Use OnHoverExited(HoverExitEventArgs) instead.")]
	protected override void OnHoverExited(XRBaseInteractable interactable) { }

	protected override void OnHoverExited(HoverExitEventArgs args) { }

	[Obsolete("OnHoverExiting(XRBaseInteractable) has been deprecated. Use OnHoverExiting(HoverExitEventArgs) instead.")]
	protected override void OnHoverExiting(XRBaseInteractable interactable) { }

	protected override void OnHoverExiting(HoverExitEventArgs args) { }

	protected override void OnRegistered(InteractorRegisteredEventArgs args) { }

	[Obsolete("OnSelectEntered(XRBaseInteractable) has been deprecated. Use OnSelectEntered(SelectEnterEventArgs) instead.")]
	protected override void OnSelectEntered(XRBaseInteractable interactable) { }

	protected override void OnSelectEntered(SelectEnterEventArgs args) { }

	protected override void OnSelectEntering(SelectEnterEventArgs args) { }

	[Obsolete("OnSelectEntering(XRBaseInteractable) has been deprecated. Use OnSelectEntering(SelectEnterEventArgs) instead.")]
	protected override void OnSelectEntering(XRBaseInteractable interactable) { }

	[Obsolete("OnSelectExited(XRBaseInteractable) has been deprecated. Use OnSelectExited(SelectExitEventArgs) instead.")]
	protected override void OnSelectExited(XRBaseInteractable interactable) { }

	protected override void OnSelectExited(SelectExitEventArgs args) { }

	[Obsolete("OnSelectExiting(XRBaseInteractable) has been deprecated. Use OnSelectExiting(SelectExitEventArgs) instead.")]
	protected override void OnSelectExiting(XRBaseInteractable interactable) { }

	protected override void OnSelectExiting(SelectExitEventArgs args) { }

	protected override void OnUnregistered(InteractorUnregisteredEventArgs args) { }

	public override void PreprocessInteractor(UpdatePhase updatePhase) { }

	protected bool ProcessHoverFilters(IXRHoverInteractable interactable) { }

	protected override void ProcessInteractionStrength(UpdatePhase updatePhase) { }

	public override void ProcessInteractor(UpdatePhase updatePhase) { }

	protected bool ProcessSelectFilters(IXRSelectInteractable interactable) { }

	private void RegisterWithInteractionManager() { }

	[CompilerGenerated]
	public override void remove_registered(Action<InteractorRegisteredEventArgs> value) { }

	[CompilerGenerated]
	public override void remove_unregistered(Action<InteractorUnregisteredEventArgs> value) { }

	[Conditional("UNITY_EDITOR")]
	protected override void Reset() { }

	public void set_allowHover(bool value) { }

	public void set_allowSelect(bool value) { }

	public void set_attachTransform(Transform value) { }

	[CompilerGenerated]
	private void set_containingGroup(IXRInteractionGroup value) { }

	public void set_disableVisualsWhenBlockedInGroup(bool value) { }

	public void set_enableInteractions(bool value) { }

	[CompilerGenerated]
	private void set_firstInteractableSelected(IXRSelectInteractable value) { }

	public void set_hoverEntered(HoverEnterEvent value) { }

	public void set_hoverExited(HoverExitEvent value) { }

	public void set_interactionLayerMask(LayerMask value) { }

	public void set_interactionLayers(InteractionLayerMask value) { }

	public void set_interactionManager(XRInteractionManager value) { }

	[CompilerGenerated]
	internal void set_isInteractingWithUI(bool value) { }

	public void set_keepSelectedTargetValid(bool value) { }

	public void set_onHoverEntered(XRInteractorEvent value) { }

	public void set_onHoverExited(XRInteractorEvent value) { }

	public void set_onSelectEntered(XRInteractorEvent value) { }

	public void set_onSelectExited(XRInteractorEvent value) { }

	public void set_selectEntered(SelectEnterEvent value) { }

	public void set_selectExited(SelectExitEvent value) { }

	protected void set_selectTarget(XRBaseInteractable value) { }

	public void set_startingHoverFilters(List<Object> value) { }

	public void set_startingSelectedInteractable(XRBaseInteractable value) { }

	public void set_startingSelectFilters(List<Object> value) { }

	public void set_startingTargetFilter(XRBaseTargetFilter value) { }

	public void set_targetFilter(IXRTargetFilter value) { }

	[CompilerGenerated]
	public override void set_targetPriorityMode(TargetPriorityMode value) { }

	[CompilerGenerated]
	public override void set_targetsForSelection(List<IXRSelectInteractable> value) { }

	[CompilerGenerated]
	internal void set_useAttachPointVelocity(bool value) { }

	protected override void Start() { }

	public override void StartManualInteraction(IXRSelectInteractable interactable) { }

	[Obsolete("StartManualInteraction(XRBaseInteractable) has been deprecated. Use StartManualInteraction(IXRSelectInteractable) instead.")]
	public override void StartManualInteraction(XRBaseInteractable interactable) { }

	internal bool TryGetXROrigin(out Transform origin) { }

	private override void UnityEngine.XR.Interaction.Toolkit.IXRGroupMember.OnRegisteringAsGroupMember(IXRInteractionGroup group) { }

	private override void UnityEngine.XR.Interaction.Toolkit.IXRGroupMember.OnRegisteringAsNonGroupMember() { }

	private override bool UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractor.CanHover(IXRHoverInteractable interactable) { }

	private override void UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractor.OnHoverEntered(HoverEnterEventArgs args) { }

	private override void UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractor.OnHoverEntering(HoverEnterEventArgs args) { }

	private override void UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractor.OnHoverExited(HoverExitEventArgs args) { }

	private override void UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractor.OnHoverExiting(HoverExitEventArgs args) { }

	private override void UnityEngine.XR.Interaction.Toolkit.IXRInteractionStrengthInteractor.ProcessInteractionStrength(UpdatePhase updatePhase) { }

	private override Transform UnityEngine.XR.Interaction.Toolkit.IXRInteractor.get_transform() { }

	private override void UnityEngine.XR.Interaction.Toolkit.IXRInteractor.OnRegistered(InteractorRegisteredEventArgs args) { }

	private override void UnityEngine.XR.Interaction.Toolkit.IXRInteractor.OnUnregistered(InteractorUnregisteredEventArgs args) { }

	private override bool UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractor.CanSelect(IXRSelectInteractable interactable) { }

	private override void UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractor.OnSelectEntered(SelectEnterEventArgs args) { }

	private override void UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractor.OnSelectEntering(SelectEnterEventArgs args) { }

	private override void UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractor.OnSelectExited(SelectExitEventArgs args) { }

	private override void UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractor.OnSelectExiting(SelectExitEventArgs args) { }

	private void UnregisterWithInteractionManager() { }

	private void UpdateVelocityAndAngularVelocity() { }

}

