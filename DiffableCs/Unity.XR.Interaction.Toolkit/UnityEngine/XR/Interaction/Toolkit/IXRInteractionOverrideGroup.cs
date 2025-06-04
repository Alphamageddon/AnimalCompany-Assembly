namespace UnityEngine.XR.Interaction.Toolkit;

public interface IXRInteractionOverrideGroup : IXRInteractionGroup
{

	public void AddInteractionOverrideForGroupMember(IXRGroupMember sourceGroupMember, IXRGroupMember overrideGroupMember) { }

	public bool ClearInteractionOverridesForGroupMember(IXRGroupMember sourceGroupMember) { }

	public void GetInteractionOverridesForGroupMember(IXRGroupMember sourceGroupMember, HashSet<IXRGroupMember> results) { }

	public bool GroupMemberIsPartOfOverrideChain(IXRGroupMember sourceGroupMember, IXRGroupMember potentialOverrideGroupMember) { }

	public bool RemoveInteractionOverrideForGroupMember(IXRGroupMember sourceGroupMember, IXRGroupMember overrideGroupMember) { }

	public bool ShouldAnyMemberOverrideInteraction(IXRInteractor interactingInteractor, out IXRSelectInteractor overridingInteractor) { }

	public bool ShouldOverrideActiveInteraction(out IXRSelectInteractor overridingInteractor) { }

}

