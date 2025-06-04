namespace UnityEngine.XR.Interaction.Toolkit;

[AddComponentMenu("XR/XR Interaction Manager", 11)]
[DefaultExecutionOrder(-105)]
[DisallowMultipleComponent]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.XRInteractionManager.html")]
public class XRInteractionManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<FocusEnterEventArgs> <>9__227_0; //Field offset: 0x8
		public static Func<FocusExitEventArgs> <>9__227_1; //Field offset: 0x10
		public static Func<SelectEnterEventArgs> <>9__227_2; //Field offset: 0x18
		public static Func<SelectExitEventArgs> <>9__227_3; //Field offset: 0x20
		public static Func<HoverEnterEventArgs> <>9__227_4; //Field offset: 0x28
		public static Func<HoverExitEventArgs> <>9__227_5; //Field offset: 0x30
		public static Func<InteractionGroupRegisteredEventArgs> <>9__227_6; //Field offset: 0x38
		public static Func<InteractionGroupUnregisteredEventArgs> <>9__227_7; //Field offset: 0x40
		public static Func<InteractorRegisteredEventArgs> <>9__227_8; //Field offset: 0x48
		public static Func<InteractorUnregisteredEventArgs> <>9__227_9; //Field offset: 0x50
		public static Func<InteractableRegisteredEventArgs> <>9__227_10; //Field offset: 0x58
		public static Func<InteractableUnregisteredEventArgs> <>9__227_11; //Field offset: 0x60

		private static <>c() { }

		public <>c() { }

		internal List<IXRTargetPriorityInteractor> <.cctor>b__228_0() { }

		internal void <.cctor>b__228_1(List<IXRTargetPriorityInteractor> list) { }

		internal FocusEnterEventArgs <.ctor>b__227_0() { }

		internal FocusExitEventArgs <.ctor>b__227_1() { }

		internal InteractableRegisteredEventArgs <.ctor>b__227_10() { }

		internal InteractableUnregisteredEventArgs <.ctor>b__227_11() { }

		internal SelectEnterEventArgs <.ctor>b__227_2() { }

		internal SelectExitEventArgs <.ctor>b__227_3() { }

		internal HoverEnterEventArgs <.ctor>b__227_4() { }

		internal HoverExitEventArgs <.ctor>b__227_5() { }

		internal InteractionGroupRegisteredEventArgs <.ctor>b__227_6() { }

		internal InteractionGroupUnregisteredEventArgs <.ctor>b__227_7() { }

		internal InteractorRegisteredEventArgs <.ctor>b__227_8() { }

		internal InteractorUnregisteredEventArgs <.ctor>b__227_9() { }

	}

	[CompilerGenerated]
	private static readonly List<XRInteractionManager> <activeInteractionManagers>k__BackingField; //Field offset: 0x0
	private static readonly LinkedPool<List`1<IXRTargetPriorityInteractor>> s_TargetPriorityInteractorListPool; //Field offset: 0x8
	private static readonly ProfilerMarker s_PreprocessInteractorsMarker; //Field offset: 0x10
	private static readonly ProfilerMarker s_ProcessInteractionStrengthMarker; //Field offset: 0x18
	private static readonly ProfilerMarker s_ProcessInteractorsMarker; //Field offset: 0x20
	private static readonly ProfilerMarker s_ProcessInteractablesMarker; //Field offset: 0x28
	private static readonly ProfilerMarker s_UpdateGroupMemberInteractionsMarker; //Field offset: 0x30
	internal static readonly ProfilerMarker s_GetValidTargetsMarker; //Field offset: 0x38
	private static readonly ProfilerMarker s_FilterRegisteredValidTargetsMarker; //Field offset: 0x40
	internal static readonly ProfilerMarker s_EvaluateInvalidFocusMarker; //Field offset: 0x48
	internal static readonly ProfilerMarker s_EvaluateInvalidSelectionsMarker; //Field offset: 0x50
	internal static readonly ProfilerMarker s_EvaluateInvalidHoversMarker; //Field offset: 0x58
	internal static readonly ProfilerMarker s_EvaluateValidSelectionsMarker; //Field offset: 0x60
	internal static readonly ProfilerMarker s_EvaluateValidHoversMarker; //Field offset: 0x68
	private static readonly ProfilerMarker s_FocusEnterMarker; //Field offset: 0x70
	private static readonly ProfilerMarker s_FocusExitMarker; //Field offset: 0x78
	private static readonly ProfilerMarker s_SelectEnterMarker; //Field offset: 0x80
	private static readonly ProfilerMarker s_SelectExitMarker; //Field offset: 0x88
	private static readonly ProfilerMarker s_HoverEnterMarker; //Field offset: 0x90
	private static readonly ProfilerMarker s_HoverExitMarker; //Field offset: 0x98
	[CompilerGenerated]
	private Action<InteractionGroupRegisteredEventArgs> interactionGroupRegistered; //Field offset: 0x20
	[CompilerGenerated]
	private Action<InteractionGroupUnregisteredEventArgs> interactionGroupUnregistered; //Field offset: 0x28
	[CompilerGenerated]
	private Action<InteractorRegisteredEventArgs> interactorRegistered; //Field offset: 0x30
	[CompilerGenerated]
	private Action<InteractorUnregisteredEventArgs> interactorUnregistered; //Field offset: 0x38
	[CompilerGenerated]
	private Action<InteractableRegisteredEventArgs> interactableRegistered; //Field offset: 0x40
	[CompilerGenerated]
	private Action<InteractableUnregisteredEventArgs> interactableUnregistered; //Field offset: 0x48
	[CompilerGenerated]
	private Action<FocusEnterEventArgs> focusGained; //Field offset: 0x50
	[CompilerGenerated]
	private Action<FocusExitEventArgs> focusLost; //Field offset: 0x58
	[RequireInterface(typeof(IXRHoverFilter))]
	[SerializeField]
	private List<Object> m_StartingHoverFilters; //Field offset: 0x60
	private readonly ExposedRegistrationList<IXRHoverFilter> m_HoverFilters; //Field offset: 0x68
	[RequireInterface(typeof(IXRSelectFilter))]
	[SerializeField]
	private List<Object> m_StartingSelectFilters; //Field offset: 0x70
	private readonly ExposedRegistrationList<IXRSelectFilter> m_SelectFilters; //Field offset: 0x78
	[CompilerGenerated]
	private IXRFocusInteractable <lastFocused>k__BackingField; //Field offset: 0x80
	private readonly Dictionary<Collider, IXRInteractable> m_ColliderToInteractableMap; //Field offset: 0x88
	private readonly Dictionary<Collider, XRInteractableSnapVolume> m_ColliderToSnapVolumes; //Field offset: 0x90
	private readonly RegistrationList<IXRInteractor> m_Interactors; //Field offset: 0x98
	private readonly RegistrationList<IXRInteractionGroup> m_InteractionGroups; //Field offset: 0xA0
	private readonly RegistrationList<IXRInteractable> m_Interactables; //Field offset: 0xA8
	private readonly List<IXRHoverInteractable> m_CurrentHovered; //Field offset: 0xB0
	private readonly List<IXRSelectInteractable> m_CurrentSelected; //Field offset: 0xB8
	private readonly Dictionary<IXRSelectInteractable, List`1<IXRTargetPriorityInteractor>> m_HighestPriorityTargetMap; //Field offset: 0xC0
	private readonly List<IXRInteractable> m_ValidTargets; //Field offset: 0xC8
	private readonly HashSet<IXRInteractable> m_UnorderedValidTargets; //Field offset: 0xD0
	private readonly HashSet<IXRInteractor> m_InteractorsInGroup; //Field offset: 0xD8
	private readonly HashSet<IXRInteractionGroup> m_GroupsInGroup; //Field offset: 0xE0
	private readonly List<XRBaseInteractable> m_DeprecatedValidTargets; //Field offset: 0xE8
	private readonly List<IXRInteractionGroup> m_ScratchInteractionGroups; //Field offset: 0xF0
	private readonly List<IXRInteractor> m_ScratchInteractors; //Field offset: 0xF8
	private readonly List<IXRInteractable> m_ScratchInteractables; //Field offset: 0x100
	private readonly LinkedPool<FocusEnterEventArgs> m_FocusEnterEventArgs; //Field offset: 0x108
	private readonly LinkedPool<FocusExitEventArgs> m_FocusExitEventArgs; //Field offset: 0x110
	private readonly LinkedPool<SelectEnterEventArgs> m_SelectEnterEventArgs; //Field offset: 0x118
	private readonly LinkedPool<SelectExitEventArgs> m_SelectExitEventArgs; //Field offset: 0x120
	private readonly LinkedPool<HoverEnterEventArgs> m_HoverEnterEventArgs; //Field offset: 0x128
	private readonly LinkedPool<HoverExitEventArgs> m_HoverExitEventArgs; //Field offset: 0x130
	private readonly LinkedPool<InteractionGroupRegisteredEventArgs> m_InteractionGroupRegisteredEventArgs; //Field offset: 0x138
	private readonly LinkedPool<InteractionGroupUnregisteredEventArgs> m_InteractionGroupUnregisteredEventArgs; //Field offset: 0x140
	private readonly LinkedPool<InteractorRegisteredEventArgs> m_InteractorRegisteredEventArgs; //Field offset: 0x148
	private readonly LinkedPool<InteractorUnregisteredEventArgs> m_InteractorUnregisteredEventArgs; //Field offset: 0x150
	private readonly LinkedPool<InteractableRegisteredEventArgs> m_InteractableRegisteredEventArgs; //Field offset: 0x158
	private readonly LinkedPool<InteractableUnregisteredEventArgs> m_InteractableUnregisteredEventArgs; //Field offset: 0x160

	public event Action<FocusEnterEventArgs> focusGained
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public event Action<FocusExitEventArgs> focusLost
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public event Action<InteractableRegisteredEventArgs> interactableRegistered
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public event Action<InteractableUnregisteredEventArgs> interactableUnregistered
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public event Action<InteractionGroupRegisteredEventArgs> interactionGroupRegistered
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public event Action<InteractionGroupUnregisteredEventArgs> interactionGroupUnregistered
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public event Action<InteractorRegisteredEventArgs> interactorRegistered
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public event Action<InteractorUnregisteredEventArgs> interactorUnregistered
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	internal static List<XRInteractionManager> activeInteractionManagers
	{
		[CompilerGenerated]
		internal get { } //Length: 88
	}

	public IXRFilterList<IXRHoverFilter> hoverFilters
	{
		 get { } //Length: 8
	}

	public IXRFocusInteractable lastFocused
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public IXRFilterList<IXRSelectFilter> selectFilters
	{
		 get { } //Length: 8
	}

	public List<Object> startingHoverFilters
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public List<Object> startingSelectFilters
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	private static XRInteractionManager() { }

	public XRInteractionManager() { }

	[CompilerGenerated]
	public void add_focusGained(Action<FocusEnterEventArgs> value) { }

	[CompilerGenerated]
	public void add_focusLost(Action<FocusExitEventArgs> value) { }

	[CompilerGenerated]
	public void add_interactableRegistered(Action<InteractableRegisteredEventArgs> value) { }

	[CompilerGenerated]
	public void add_interactableUnregistered(Action<InteractableUnregisteredEventArgs> value) { }

	[CompilerGenerated]
	public void add_interactionGroupRegistered(Action<InteractionGroupRegisteredEventArgs> value) { }

	[CompilerGenerated]
	public void add_interactionGroupUnregistered(Action<InteractionGroupUnregisteredEventArgs> value) { }

	[CompilerGenerated]
	public void add_interactorRegistered(Action<InteractorRegisteredEventArgs> value) { }

	[CompilerGenerated]
	public void add_interactorUnregistered(Action<InteractorUnregisteredEventArgs> value) { }

	protected override void Awake() { }

	public override void CancelInteractableFocus(IXRFocusInteractable interactable) { }

	private void CancelInteractableFocusInternal(IXRFocusInteractable interactable) { }

	public override void CancelInteractableHover(IXRHoverInteractable interactable) { }

	[Obsolete("CancelInteractableHover(XRBaseInteractable) has been deprecated. Use CancelInteractableHover(IXRHoverInteractable) instead.")]
	public override void CancelInteractableHover(XRBaseInteractable interactable) { }

	private void CancelInteractableHoverInternal(IXRHoverInteractable interactable) { }

	[Obsolete("CancelInteractableSelection(XRBaseInteractable) has been deprecated. Use CancelInteractableSelection(IXRSelectInteractable) instead.")]
	public override void CancelInteractableSelection(XRBaseInteractable interactable) { }

	public override void CancelInteractableSelection(IXRSelectInteractable interactable) { }

	private void CancelInteractableSelectionInternal(IXRSelectInteractable interactable) { }

	private void CancelInteractorFocusInternal(IXRInteractor interactor) { }

	[Obsolete("CancelInteractorHover(XRBaseInteractor) has been deprecated. Use CancelInteractorHover(IXRHoverInteractor) instead.")]
	public override void CancelInteractorHover(XRBaseInteractor interactor) { }

	public override void CancelInteractorHover(IXRHoverInteractor interactor) { }

	private void CancelInteractorHoverInternal(IXRHoverInteractor interactor) { }

	public override void CancelInteractorSelection(IXRSelectInteractor interactor) { }

	[Obsolete("CancelInteractorSelection(XRBaseInteractor) has been deprecated. Use CancelInteractorSelection(IXRSelectInteractor) instead.")]
	public override void CancelInteractorSelection(XRBaseInteractor interactor) { }

	private void CancelInteractorSelectionInternal(IXRSelectInteractor interactor) { }

	public override bool CanFocus(IXRInteractor interactor, IXRFocusInteractable interactable) { }

	public override bool CanHover(IXRHoverInteractor interactor, IXRHoverInteractable interactable) { }

	public override bool CanSelect(IXRSelectInteractor interactor, IXRSelectInteractable interactable) { }

	protected override void ClearInteractionGroupFocus(IXRInteractionGroup interactionGroup) { }

	internal void ClearInteractionGroupFocusInternal(IXRInteractionGroup interactionGroup) { }

	[Obsolete("ClearInteractorHover(XRBaseInteractor, List<XRBaseInteractable>) has been deprecated. Use ClearInteractorHover(IXRHoverInteractor, List<IXRInteractable>) instead.")]
	public override void ClearInteractorHover(XRBaseInteractor interactor, List<XRBaseInteractable> validTargets) { }

	protected override void ClearInteractorHover(IXRHoverInteractor interactor, List<IXRInteractable> validTargets) { }

	internal void ClearInteractorHoverInternal(IXRHoverInteractor interactor, List<IXRInteractable> validTargets, List<XRBaseInteractable> deprecatedValidTargets) { }

	[Obsolete("ClearInteractorSelection(XRBaseInteractor) has been deprecated. Use ClearInteractorSelection(IXRSelectInteractor, List<IXRInteractable>) instead.")]
	public override void ClearInteractorSelection(XRBaseInteractor interactor) { }

	protected override void ClearInteractorSelection(IXRSelectInteractor interactor, List<IXRInteractable> validTargets) { }

	internal void ClearInteractorSelectionInternal(IXRSelectInteractor interactor, List<IXRInteractable> validTargets) { }

	private void ClearPriorityForSelectionMap() { }

	private void ExitInteractableFocus(IXRFocusInteractable interactable) { }

	private void ExitInteractableSelection(IXRSelectInteractable interactable) { }

	protected override void FixedUpdate() { }

	private void FlushRegistration() { }

	public override void FocusCancel(IXRInteractionGroup group, IXRFocusInteractable interactable) { }

	private void FocusCancelInternal(IXRInteractionGroup group, IXRFocusInteractable interactable) { }

	protected override void FocusEnter(IXRInteractionGroup group, IXRFocusInteractable interactable, FocusEnterEventArgs args) { }

	public override void FocusEnter(IXRInteractor interactor, IXRFocusInteractable interactable) { }

	private void FocusEnterInternal(IXRInteractionGroup group, IXRFocusInteractable interactable, FocusEnterEventArgs args) { }

	protected override void FocusExit(IXRInteractionGroup group, IXRFocusInteractable interactable, FocusExitEventArgs args) { }

	public override void FocusExit(IXRInteractionGroup group, IXRFocusInteractable interactable) { }

	internal void FocusExitInternal(IXRInteractionGroup group, IXRFocusInteractable interactable) { }

	private void FocusExitInternal(IXRInteractionGroup group, IXRFocusInteractable interactable, FocusExitEventArgs args) { }

	[Obsolete("ForceSelect(XRBaseInteractor, XRBaseInteractable) has been deprecated. Use SelectEnter(IXRSelectInteractor, IXRSelectInteractable) instead.")]
	public void ForceSelect(XRBaseInteractor interactor, XRBaseInteractable interactable) { }

	[CompilerGenerated]
	internal static List<XRInteractionManager> get_activeInteractionManagers() { }

	public IXRFilterList<IXRHoverFilter> get_hoverFilters() { }

	[CompilerGenerated]
	public IXRFocusInteractable get_lastFocused() { }

	public IXRFilterList<IXRSelectFilter> get_selectFilters() { }

	public List<Object> get_startingHoverFilters() { }

	public List<Object> get_startingSelectFilters() { }

	[Obsolete("GetColliderToInteractableMap has been deprecated. The signature no longer matches the field used by the XRInteractionManager, so a copy is returned instead of a ref. Changes to the returned Dictionary will not be observed by the XRInteractionManager.", True)]
	public void GetColliderToInteractableMap(ref Dictionary<Collider, XRBaseInteractable>& map) { }

	[Obsolete("GetInteractableForCollider has been deprecated. Use TryGetInteractableForCollider(Collider, out IXRInteractable) instead.")]
	public XRBaseInteractable GetInteractableForCollider(Collider interactableCollider) { }

	public IXRInteractionGroup GetInteractionGroup(string groupName) { }

	public void GetInteractionGroups(List<IXRInteractionGroup> interactionGroups) { }

	internal static void GetOfType(List<TSource> source, List<TDestination> destination) { }

	public void GetRegisteredInteractables(List<IXRInteractable> results) { }

	[Obsolete("GetRegisteredInteractables(List<XRBaseInteractable>) has been deprecated. Use GetRegisteredInteractables(List<IXRInteractable>) instead.")]
	public void GetRegisteredInteractables(List<XRBaseInteractable> results) { }

	public void GetRegisteredInteractionGroups(List<IXRInteractionGroup> results) { }

	public void GetRegisteredInteractors(List<IXRInteractor> results) { }

	[Obsolete("GetRegisteredInteractors(List<XRBaseInteractor>) has been deprecated. Use GetRegisteredInteractors(List<IXRInteractor>) instead.")]
	public void GetRegisteredInteractors(List<XRBaseInteractor> results) { }

	public void GetValidTargets(IXRInteractor interactor, List<IXRInteractable> targets) { }

	[Obsolete("GetValidTargets(XRBaseInteractor, List<XRBaseInteractable>) has been deprecated. Use GetValidTargets(IXRInteractor, List<IXRInteractable>) instead.")]
	public List<XRBaseInteractable> GetValidTargets(XRBaseInteractor interactor, List<XRBaseInteractable> validTargets) { }

	protected static bool HasInteractionLayerOverlap(IXRInteractor interactor, IXRInteractable interactable) { }

	[Obsolete("HoverCancel(XRBaseInteractor, XRBaseInteractable) has been deprecated. Use HoverCancel(IXRHoverInteractor, IXRHoverInteractable) instead.")]
	public override void HoverCancel(XRBaseInteractor interactor, XRBaseInteractable interactable) { }

	public override void HoverCancel(IXRHoverInteractor interactor, IXRHoverInteractable interactable) { }

	private void HoverCancelInternal(IXRHoverInteractor interactor, IXRHoverInteractable interactable) { }

	protected override void HoverEnter(IXRHoverInteractor interactor, IXRHoverInteractable interactable, HoverEnterEventArgs args) { }

	public override void HoverEnter(IXRHoverInteractor interactor, IXRHoverInteractable interactable) { }

	[Obsolete("HoverEnter(XRBaseInteractor, XRBaseInteractable, HoverEnterEventArgs) has been deprecated. Use HoverEnter(IXRHoverInteractor, IXRHoverInteractable, HoverEnterEventArgs) instead.")]
	protected override void HoverEnter(XRBaseInteractor interactor, XRBaseInteractable interactable, HoverEnterEventArgs args) { }

	[Obsolete("HoverEnter(XRBaseInteractor, XRBaseInteractable) has been deprecated. Use HoverEnter(IXRHoverInteractor, IXRHoverInteractable) instead.")]
	public override void HoverEnter(XRBaseInteractor interactor, XRBaseInteractable interactable) { }

	private void HoverEnterInternal(IXRHoverInteractor interactor, IXRHoverInteractable interactable) { }

	private void HoverEnterInternal(IXRHoverInteractor interactor, IXRHoverInteractable interactable, HoverEnterEventArgs args) { }

	public override void HoverExit(IXRHoverInteractor interactor, IXRHoverInteractable interactable) { }

	[Obsolete("HoverExit(XRBaseInteractor, XRBaseInteractable) has been deprecated. Use HoverExit(IXRHoverInteractor, IXRHoverInteractable) instead.")]
	public override void HoverExit(XRBaseInteractor interactor, XRBaseInteractable interactable) { }

	protected override void HoverExit(IXRHoverInteractor interactor, IXRHoverInteractable interactable, HoverExitEventArgs args) { }

	[Obsolete("HoverExit(XRBaseInteractor, XRBaseInteractable, HoverExitEventArgs) has been deprecated. Use HoverExit(IXRHoverInteractor, IXRHoverInteractable, HoverExitEventArgs) instead.")]
	protected override void HoverExit(XRBaseInteractor interactor, XRBaseInteractable interactable, HoverExitEventArgs args) { }

	internal void HoverExitInternal(IXRHoverInteractor interactor, IXRHoverInteractable interactable) { }

	private void HoverExitInternal(IXRHoverInteractor interactor, IXRHoverInteractable interactable, HoverExitEventArgs args) { }

	protected override void InteractorHoverValidTargets(IXRHoverInteractor interactor, List<IXRInteractable> validTargets) { }

	[Obsolete("InteractorHoverValidTargets(XRBaseInteractor, List<XRBaseInteractable>) has been deprecated. Use InteractorHoverValidTargets(IXRHoverInteractor, List<IXRInteractable>) instead.")]
	protected override void InteractorHoverValidTargets(XRBaseInteractor interactor, List<XRBaseInteractable> validTargets) { }

	internal void InteractorHoverValidTargetsInternal(IXRHoverInteractor interactor, List<IXRInteractable> validTargets, List<XRBaseInteractable> deprecatedValidTargets) { }

	[Obsolete("InteractorSelectValidTargets(XRBaseInteractor, List<XRBaseInteractable>) has been deprecated. Use InteractorSelectValidTargets(IXRSelectInteractor, List<IXRInteractable>) instead.")]
	protected override void InteractorSelectValidTargets(XRBaseInteractor interactor, List<XRBaseInteractable> validTargets) { }

	protected override void InteractorSelectValidTargets(IXRSelectInteractor interactor, List<IXRInteractable> validTargets) { }

	internal void InteractorSelectValidTargetsInternal(IXRSelectInteractor interactor, List<IXRInteractable> validTargets, List<XRBaseInteractable> deprecatedValidTargets) { }

	public bool IsFocusPossible(IXRInteractor interactor, IXRFocusInteractable interactable) { }

	public bool IsHighestPriorityTarget(IXRSelectInteractable target, List<IXRTargetPriorityInteractor> interactors = null) { }

	public bool IsHoverPossible(IXRHoverInteractor interactor, IXRHoverInteractable interactable) { }

	[Obsolete("IsRegistered(XRBaseInteractor) has been deprecated. Use IsRegistered(IXRInteractor) instead.")]
	public bool IsRegistered(XRBaseInteractor interactor) { }

	[Obsolete("IsRegistered(XRBaseInteractable) has been deprecated. Use IsRegistered(IXRInteractable) instead.")]
	public bool IsRegistered(XRBaseInteractable interactable) { }

	public bool IsRegistered(IXRInteractionGroup interactionGroup) { }

	public bool IsRegistered(IXRInteractor interactor) { }

	public bool IsRegistered(IXRInteractable interactable) { }

	public bool IsSelectPossible(IXRSelectInteractor interactor, IXRSelectInteractable interactable) { }

	protected override void LateUpdate() { }

	[BeforeRenderOrder(100)]
	protected override void OnBeforeRender() { }

	protected override void OnDisable() { }

	protected override void OnEnable() { }

	protected override void OnRegistered(InteractorRegisteredEventArgs args) { }

	protected override void OnRegistered(InteractableRegisteredEventArgs args) { }

	protected override void OnRegistered(InteractionGroupRegisteredEventArgs args) { }

	protected override void OnUnregistered(InteractorUnregisteredEventArgs args) { }

	protected override void OnUnregistered(InteractableUnregisteredEventArgs args) { }

	protected override void OnUnregistered(InteractionGroupUnregisteredEventArgs args) { }

	protected override void PreprocessInteractors(UpdatePhase updatePhase) { }

	protected bool ProcessHoverFilters(IXRHoverInteractor interactor, IXRHoverInteractable interactable) { }

	protected override void ProcessInteractables(UpdatePhase updatePhase) { }

	protected override void ProcessInteractionStrength(UpdatePhase updatePhase) { }

	protected override void ProcessInteractors(UpdatePhase updatePhase) { }

	protected bool ProcessSelectFilters(IXRSelectInteractor interactor, IXRSelectInteractable interactable) { }

	public override void RegisterInteractable(IXRInteractable interactable) { }

	[Obsolete("RegisterInteractable(XRBaseInteractable) has been deprecated. Use RegisterInteractable(IXRInteractable) instead.")]
	public override void RegisterInteractable(XRBaseInteractable interactable) { }

	public override void RegisterInteractionGroup(IXRInteractionGroup interactionGroup) { }

	public override void RegisterInteractor(IXRInteractor interactor) { }

	[Obsolete("RegisterInteractor(XRBaseInteractor) has been deprecated. Use RegisterInteractor(IXRInteractor) instead.")]
	public override void RegisterInteractor(XRBaseInteractor interactor) { }

	public void RegisterSnapVolume(XRInteractableSnapVolume snapVolume) { }

	[CompilerGenerated]
	public void remove_focusGained(Action<FocusEnterEventArgs> value) { }

	[CompilerGenerated]
	public void remove_focusLost(Action<FocusExitEventArgs> value) { }

	[CompilerGenerated]
	public void remove_interactableRegistered(Action<InteractableRegisteredEventArgs> value) { }

	[CompilerGenerated]
	public void remove_interactableUnregistered(Action<InteractableUnregisteredEventArgs> value) { }

	[CompilerGenerated]
	public void remove_interactionGroupRegistered(Action<InteractionGroupRegisteredEventArgs> value) { }

	[CompilerGenerated]
	public void remove_interactionGroupUnregistered(Action<InteractionGroupUnregisteredEventArgs> value) { }

	[CompilerGenerated]
	public void remove_interactorRegistered(Action<InteractorRegisteredEventArgs> value) { }

	[CompilerGenerated]
	public void remove_interactorUnregistered(Action<InteractorUnregisteredEventArgs> value) { }

	internal static int RemoveAllUnregistered(XRInteractionManager manager, List<IXRInteractable> interactables) { }

	protected override bool ResolveExistingFocus(IXRInteractionGroup interactionGroup, IXRFocusInteractable interactable) { }

	protected override bool ResolveExistingSelect(IXRSelectInteractor interactor, IXRSelectInteractable interactable) { }

	public override void SelectCancel(IXRSelectInteractor interactor, IXRSelectInteractable interactable) { }

	[Obsolete("SelectCancel(XRBaseInteractor, XRBaseInteractable) has been deprecated. Use SelectCancel(IXRSelectInteractor, IXRSelectInteractable) instead.")]
	public override void SelectCancel(XRBaseInteractor interactor, XRBaseInteractable interactable) { }

	private void SelectCancelInternal(IXRSelectInteractor interactor, IXRSelectInteractable interactable) { }

	[Obsolete("SelectExit(XRBaseInteractor, XRBaseInteractable, SelectExitEventArgs) has been deprecated. Use SelectExit(IXRSelectInteractor, IXRSelectInteractable, SelectExitEventArgs) instead.")]
	protected override void SelectEnter(XRBaseInteractor interactor, XRBaseInteractable interactable, SelectEnterEventArgs args) { }

	[Obsolete("SelectEnter(XRBaseInteractor, XRBaseInteractable) has been deprecated. Use SelectEnter(IXRSelectInteractor, IXRSelectInteractable) instead.")]
	public override void SelectEnter(XRBaseInteractor interactor, XRBaseInteractable interactable) { }

	protected override void SelectEnter(IXRSelectInteractor interactor, IXRSelectInteractable interactable, SelectEnterEventArgs args) { }

	public override void SelectEnter(IXRSelectInteractor interactor, IXRSelectInteractable interactable) { }

	private void SelectEnterInternal(IXRSelectInteractor interactor, IXRSelectInteractable interactable) { }

	private void SelectEnterInternal(IXRSelectInteractor interactor, IXRSelectInteractable interactable, SelectEnterEventArgs args) { }

	[Obsolete("SelectExit(XRBaseInteractor, XRBaseInteractable) has been deprecated. Use SelectExit(IXRSelectInteractor, IXRSelectInteractable) instead.")]
	public override void SelectExit(XRBaseInteractor interactor, XRBaseInteractable interactable) { }

	[Obsolete("SelectExit(XRBaseInteractor, XRBaseInteractable, SelectExitEventArgs) has been deprecated. Use SelectExit(IXRSelectInteractor, IXRSelectInteractable, SelectExitEventArgs) instead.")]
	protected override void SelectExit(XRBaseInteractor interactor, XRBaseInteractable interactable, SelectExitEventArgs args) { }

	protected override void SelectExit(IXRSelectInteractor interactor, IXRSelectInteractable interactable, SelectExitEventArgs args) { }

	public override void SelectExit(IXRSelectInteractor interactor, IXRSelectInteractable interactable) { }

	private void SelectExitInternal(IXRSelectInteractor interactor, IXRSelectInteractable interactable, SelectExitEventArgs args) { }

	internal void SelectExitInternal(IXRSelectInteractor interactor, IXRSelectInteractable interactable) { }

	[CompilerGenerated]
	protected void set_lastFocused(IXRFocusInteractable value) { }

	public void set_startingHoverFilters(List<Object> value) { }

	public void set_startingSelectFilters(List<Object> value) { }

	public bool TryGetInteractableForCollider(Collider interactableCollider, out IXRInteractable interactable) { }

	public bool TryGetInteractableForCollider(Collider interactableCollider, out IXRInteractable interactable, out XRInteractableSnapVolume snapVolume) { }

	[Obsolete("TryGetInteractableForCollider has been deprecated. Use GetInteractableForCollider instead. (UnityUpgradable) -> GetInteractableForCollider(*)")]
	public XRBaseInteractable TryGetInteractableForCollider(Collider interactableCollider) { }

	public override void UnregisterInteractable(IXRInteractable interactable) { }

	[Obsolete("UnregisterInteractable(XRBaseInteractable) has been deprecated. Use UnregisterInteractable(IXRInteractable) instead.")]
	public override void UnregisterInteractable(XRBaseInteractable interactable) { }

	public override void UnregisterInteractionGroup(IXRInteractionGroup interactionGroup) { }

	[Obsolete("UnregisterInteractor(XRBaseInteractor) has been deprecated. Use UnregisterInteractor(IXRInteractor) instead.")]
	public override void UnregisterInteractor(XRBaseInteractor interactor) { }

	public override void UnregisterInteractor(IXRInteractor interactor) { }

	public void UnregisterSnapVolume(XRInteractableSnapVolume snapVolume) { }

	protected override void Update() { }

}

