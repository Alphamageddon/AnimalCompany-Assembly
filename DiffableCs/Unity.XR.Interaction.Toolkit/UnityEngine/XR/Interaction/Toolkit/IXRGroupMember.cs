namespace UnityEngine.XR.Interaction.Toolkit;

public interface IXRGroupMember
{

	public IXRInteractionGroup containingGroup
	{
		 get { } //Length: 0
	}

	public IXRInteractionGroup get_containingGroup() { }

	public void OnRegisteringAsGroupMember(IXRInteractionGroup group) { }

	public void OnRegisteringAsNonGroupMember() { }

}

