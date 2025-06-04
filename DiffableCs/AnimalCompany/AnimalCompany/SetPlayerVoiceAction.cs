namespace AnimalCompany;

public class SetPlayerVoiceAction : BaseAction
{
	private int _playerID; //Field offset: 0x14
	private float _voice; //Field offset: 0x18

	public SetPlayerVoiceAction(int playerID, float voice) { }

	public virtual void Execute(AppState state) { }

}

