namespace UnityEngine.XR.Interaction.Toolkit;

public interface IXRInteractionGroup
{

	public event Action<InteractionGroupRegisteredEventArgs> registered
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action<InteractionGroupUnregisteredEventArgs> unregistered
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public IXRInteractor activeInteractor
	{
		 get { } //Length: 0
	}

	public IXRFocusInteractable focusInteractable
	{
		 get { } //Length: 0
	}

	public IXRInteractor focusInteractor
	{
		 get { } //Length: 0
	}

	public string groupName
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_registered(Action<InteractionGroupRegisteredEventArgs> value) { }

	[CompilerGenerated]
	public void add_unregistered(Action<InteractionGroupUnregisteredEventArgs> value) { }

	public void AddGroupMember(IXRGroupMember groupMember) { }

	public void ClearGroupMembers() { }

	public bool ContainsGroupMember(IXRGroupMember groupMember) { }

	public IXRInteractor get_activeInteractor() { }

	public IXRFocusInteractable get_focusInteractable() { }

	public IXRInteractor get_focusInteractor() { }

	public string get_groupName() { }

	public void GetGroupMembers(List<IXRGroupMember> results) { }

	public bool HasDependencyOnGroup(IXRInteractionGroup group) { }

	public void MoveGroupMemberTo(IXRGroupMember groupMember, int newIndex) { }

	public void OnBeforeUnregistered() { }

	public void OnFocusEntering(FocusEnterEventArgs args) { }

	public void OnFocusExiting(FocusExitEventArgs args) { }

	public void OnRegistered(InteractionGroupRegisteredEventArgs args) { }

	public void OnUnregistered(InteractionGroupUnregisteredEventArgs args) { }

	public void PreprocessGroupMembers(UpdatePhase updatePhase) { }

	public void ProcessGroupMembers(UpdatePhase updatePhase) { }

	[CompilerGenerated]
	public void remove_registered(Action<InteractionGroupRegisteredEventArgs> value) { }

	[CompilerGenerated]
	public void remove_unregistered(Action<InteractionGroupUnregisteredEventArgs> value) { }

	public bool RemoveGroupMember(IXRGroupMember groupMember) { }

	public void UpdateGroupMemberInteractions() { }

	public void UpdateGroupMemberInteractions(IXRInteractor prePrioritizedInteractor, out IXRInteractor interactorThatPerformedInteraction) { }

}

