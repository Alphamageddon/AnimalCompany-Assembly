namespace AnimalCompany;

public class SetPlayerBlockedLocalPlayerAction : BaseAction
{
	private int _playerID; //Field offset: 0x14
	private bool _blockedLocalPlayer; //Field offset: 0x18

	public SetPlayerBlockedLocalPlayerAction(int playerID, bool blockedLocalPlayer) { }

	public virtual void Execute(AppState state) { }

}

