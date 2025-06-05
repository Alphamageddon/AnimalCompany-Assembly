namespace AnimalCompany;

[NetworkBehaviourWeaved(0)]
public class MasterClientSwitchDetector : NetworkBehaviour, IStateAuthorityChanged
{

	public MasterClientSwitchDetector() { }

	[WeaverGenerated]
	public virtual void CopyBackingFieldsToState(bool unnamed_param_0) { }

	[WeaverGenerated]
	public virtual void CopyStateToBackingFields() { }

	public override void StateAuthorityChanged() { }

}

