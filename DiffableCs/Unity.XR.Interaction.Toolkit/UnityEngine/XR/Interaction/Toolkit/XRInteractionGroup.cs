namespace UnityEngine.XR.Interaction.Toolkit;

[AddComponentMenu("XR/XR Interaction Group", 11)]
[DefaultExecutionOrder(-100)]
[DisallowMultipleComponent]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.XRInteractionGroup.html")]
public class XRInteractionGroup : MonoBehaviour, IXRInteractionOverrideGroup, IXRInteractionGroup, IXRGroupMember
{
	public class GroupMemberAndOverridesPair
	{
		[RequireInterface(typeof(IXRGroupMember))]
		public object groupMember; //Field offset: 0x10
		[RequireInterface(typeof(IXRGroupMember))]
		public List<Object> overrideGroupMembers; //Field offset: 0x18

		public GroupMemberAndOverridesPair() { }

	}

	internal static class GroupNames
	{
		public static readonly string k_Left; //Field offset: 0x0
		public static readonly string k_Right; //Field offset: 0x8
		public static readonly string k_Center; //Field offset: 0x10

		private static GroupNames() { }

	}

	private static readonly List<IXRSelectInteractable> s_InteractablesSelected; //Field offset: 0x0
	private static readonly List<IXRHoverInteractable> s_InteractablesHovered; //Field offset: 0x8
	[CompilerGenerated]
	private Action<InteractionGroupRegisteredEventArgs> registered; //Field offset: 0x20
	[CompilerGenerated]
	private Action<InteractionGroupUnregisteredEventArgs> unregistered; //Field offset: 0x28
	[SerializeField]
	[Tooltip("The name of the interaction group, which can be used to retrieve it from the Interaction Manager.")]
	private string m_GroupName; //Field offset: 0x30
	[SerializeField]
	[Tooltip("The XR Interaction Manager that this Interaction Group will communicate with (will find one if not set manually).")]
	private XRInteractionManager m_InteractionManager; //Field offset: 0x38
	private XRInteractionManager m_RegisteredInteractionManager; //Field offset: 0x40
	[CompilerGenerated]
	private IXRInteractionGroup <containingGroup>k__BackingField; //Field offset: 0x48
	[RequireInterface(typeof(IXRGroupMember))]
	[SerializeField]
	[Tooltip("Ordered list of Interactors or Interaction Groups that are registered with the Group on Awake.")]
	private List<Object> m_StartingGroupMembers; //Field offset: 0x50
	[SerializeField]
	[Tooltip("Configuration for each Group Member of which other Members are able to override its interaction when they attempt to select, despite the difference in priority order.")]
	private List<GroupMemberAndOverridesPair> m_StartingInteractionOverridesMap; //Field offset: 0x58
	[CompilerGenerated]
	private IXRInteractor <activeInteractor>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private IXRInteractor <focusInteractor>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private IXRFocusInteractable <focusInteractable>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private bool <hasRegisteredStartingMembers>k__BackingField; //Field offset: 0x78
	private readonly RegistrationList<IXRGroupMember> m_GroupMembers; //Field offset: 0x80
	private readonly List<IXRGroupMember> m_TempGroupMembers; //Field offset: 0x88
	private bool m_IsProcessingGroupMembers; //Field offset: 0x90
	private readonly Dictionary<IXRGroupMember, HashSet`1<IXRGroupMember>> m_InteractionOverridesMap; //Field offset: 0x98
	private readonly List<IXRInteractable> m_ValidTargets; //Field offset: 0xA0
	private readonly List<XRBaseInteractable> m_DeprecatedValidTargets; //Field offset: 0xA8

	public override event Action<InteractionGroupRegisteredEventArgs> registered
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public override event Action<InteractionGroupUnregisteredEventArgs> unregistered
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public private override IXRInteractor activeInteractor
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private override IXRInteractionGroup containingGroup
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private override IXRFocusInteractable focusInteractable
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private override IXRInteractor focusInteractor
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public override string groupName
	{
		 get { } //Length: 8
	}

	internal bool hasRegisteredStartingMembers
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public XRInteractionManager interactionManager
	{
		 get { } //Length: 8
		 set { } //Length: 144
	}

	internal bool isRegisteredWithInteractionManager
	{
		internal get { } //Length: 96
	}

	public List<Object> startingGroupMembers
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	private static XRInteractionGroup() { }

	public XRInteractionGroup() { }

	[CompilerGenerated]
	public override void add_registered(Action<InteractionGroupRegisteredEventArgs> value) { }

	[CompilerGenerated]
	public override void add_unregistered(Action<InteractionGroupUnregisteredEventArgs> value) { }

	public override void AddGroupMember(IXRGroupMember groupMember) { }

	public override void AddInteractionOverrideForGroupMember(IXRGroupMember sourceGroupMember, IXRGroupMember overrideGroupMember) { }

	public void AddStartingInteractionOverride(object sourceGroupMember, object overrideGroupMember) { }

	protected override void Awake() { }

	private bool CanStartOrContinueAnySelect(IXRSelectInteractor selectInteractor) { }

	private void ClearAllInteractorHovers(IXRHoverInteractor hoverInteractor) { }

	private void ClearAllInteractorSelections(IXRSelectInteractor selectInteractor) { }

	public override void ClearGroupMembers() { }

	public override bool ClearInteractionOverridesForGroupMember(IXRGroupMember sourceGroupMember) { }

	public override bool ContainsGroupMember(IXRGroupMember groupMember) { }

	private void FindCreateInteractionManager() { }

	[CompilerGenerated]
	public override IXRInteractor get_activeInteractor() { }

	[CompilerGenerated]
	public override IXRInteractionGroup get_containingGroup() { }

	[CompilerGenerated]
	public override IXRFocusInteractable get_focusInteractable() { }

	[CompilerGenerated]
	public override IXRInteractor get_focusInteractor() { }

	public override string get_groupName() { }

	[CompilerGenerated]
	internal bool get_hasRegisteredStartingMembers() { }

	public XRInteractionManager get_interactionManager() { }

	internal bool get_isRegisteredWithInteractionManager() { }

	public List<Object> get_startingGroupMembers() { }

	public override void GetGroupMembers(List<IXRGroupMember> results) { }

	public override void GetInteractionOverridesForGroupMember(IXRGroupMember sourceGroupMember, HashSet<IXRGroupMember> results) { }

	private bool GroupMemberIsOrContainsInteractor(IXRGroupMember groupMember, IXRInteractor interactor) { }

	public override bool GroupMemberIsPartOfOverrideChain(IXRGroupMember sourceGroupMember, IXRGroupMember potentialOverrideGroupMember) { }

	public override bool HasDependencyOnGroup(IXRInteractionGroup group) { }

	public override void MoveGroupMemberTo(IXRGroupMember groupMember, int newIndex) { }

	protected override void OnDestroy() { }

	protected override void OnDisable() { }

	protected override void OnEnable() { }

	public override void OnFocusEntering(FocusEnterEventArgs args) { }

	public override void OnFocusExiting(FocusExitEventArgs args) { }

	private void RegisterAsGroupMember(IXRGroupMember groupMember) { }

	private void RegisterAsNonGroupMember(IXRGroupMember groupMember) { }

	private void RegisterWithInteractionManager() { }

	[CompilerGenerated]
	public override void remove_registered(Action<InteractionGroupRegisteredEventArgs> value) { }

	[CompilerGenerated]
	public override void remove_unregistered(Action<InteractionGroupUnregisteredEventArgs> value) { }

	public override bool RemoveGroupMember(IXRGroupMember groupMember) { }

	public override bool RemoveInteractionOverrideForGroupMember(IXRGroupMember sourceGroupMember, IXRGroupMember overrideGroupMember) { }

	internal void RemoveMissingMembersFromStartingOverridesMap() { }

	public bool RemoveStartingInteractionOverride(object sourceGroupMember, object overrideGroupMember) { }

	private void ReRegisterGroupMemberWithInteractionManager(IXRGroupMember groupMember) { }

	[Conditional("UNITY_EDITOR")]
	protected override void Reset() { }

	[CompilerGenerated]
	private void set_activeInteractor(IXRInteractor value) { }

	[CompilerGenerated]
	private void set_containingGroup(IXRInteractionGroup value) { }

	[CompilerGenerated]
	private void set_focusInteractable(IXRFocusInteractable value) { }

	[CompilerGenerated]
	private void set_focusInteractor(IXRInteractor value) { }

	[CompilerGenerated]
	private void set_hasRegisteredStartingMembers(bool value) { }

	public void set_interactionManager(XRInteractionManager value) { }

	public void set_startingGroupMembers(List<Object> value) { }

	private bool ShouldGroupMemberOverrideInteraction(IXRInteractor interactingInteractor, IXRGroupMember overrideGroupMember, out IXRSelectInteractor overridingInteractor) { }

	private bool ShouldInteractorOverrideInteraction(IXRInteractor interactingInteractor, IXRSelectInteractor overridingInteractor) { }

	private bool TryGetOverridesForContainedInteractor(IXRInteractor interactor, out HashSet<IXRGroupMember>& overrideGroupMembers) { }

	private bool TryGetStartingGroupMemberAndOverridesPair(object sourceGroupMember, out GroupMemberAndOverridesPair groupMemberAndOverrides) { }

	private override void UnityEngine.XR.Interaction.Toolkit.IXRGroupMember.OnRegisteringAsGroupMember(IXRInteractionGroup group) { }

	private override void UnityEngine.XR.Interaction.Toolkit.IXRGroupMember.OnRegisteringAsNonGroupMember() { }

	private override void UnityEngine.XR.Interaction.Toolkit.IXRInteractionGroup.OnBeforeUnregistered() { }

	private override void UnityEngine.XR.Interaction.Toolkit.IXRInteractionGroup.OnRegistered(InteractionGroupRegisteredEventArgs args) { }

	private override void UnityEngine.XR.Interaction.Toolkit.IXRInteractionGroup.OnUnregistered(InteractionGroupUnregisteredEventArgs args) { }

	private override void UnityEngine.XR.Interaction.Toolkit.IXRInteractionGroup.PreprocessGroupMembers(UpdatePhase updatePhase) { }

	private override void UnityEngine.XR.Interaction.Toolkit.IXRInteractionGroup.ProcessGroupMembers(UpdatePhase updatePhase) { }

	private override void UnityEngine.XR.Interaction.Toolkit.IXRInteractionGroup.UpdateGroupMemberInteractions(IXRInteractor prePrioritizedInteractor, out IXRInteractor interactorThatPerformedInteraction) { }

	private override void UnityEngine.XR.Interaction.Toolkit.IXRInteractionGroup.UpdateGroupMemberInteractions() { }

	private override bool UnityEngine.XR.Interaction.Toolkit.IXRInteractionOverrideGroup.ShouldAnyMemberOverrideInteraction(IXRInteractor interactingInteractor, out IXRSelectInteractor overridingInteractor) { }

	private override bool UnityEngine.XR.Interaction.Toolkit.IXRInteractionOverrideGroup.ShouldOverrideActiveInteraction(out IXRSelectInteractor overridingInteractor) { }

	private void UnregisterWithInteractionManager() { }

	private void UpdateInteractorInteractions(IXRInteractor interactor, bool preventInteraction, out bool performedInteraction) { }

	private bool ValidateAddGroupMember(IXRGroupMember groupMember) { }

}

