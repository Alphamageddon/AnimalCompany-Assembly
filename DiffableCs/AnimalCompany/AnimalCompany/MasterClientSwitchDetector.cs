namespace AnimalCompany;

[NetworkBehaviourWeaved(0)]
public class MasterClientSwitchDetector : NetworkBehaviour, IStateAuthorityChanged
{
	private static MasterClientSwitchDetector _instance; //Field offset: 0x0

	public static PlayerRef CurrentMasterClient
	{
		 get { } //Length: 216
	}

	public MasterClientSwitchDetector() { }

	[WeaverGenerated]
	public virtual void CopyBackingFieldsToState(bool unnamed_param_0) { }

	[WeaverGenerated]
	public virtual void CopyStateToBackingFields() { }

	public static PlayerRef get_CurrentMasterClient() { }

	public virtual void Spawned() { }

	public override void StateAuthorityChanged() { }

}

