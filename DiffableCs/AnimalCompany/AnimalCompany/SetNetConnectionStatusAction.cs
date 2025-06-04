namespace AnimalCompany;

public class SetNetConnectionStatusAction : BaseAction
{
	private States _state; //Field offset: 0x14
	private string _message; //Field offset: 0x18

	public SetNetConnectionStatusAction(States state, string message) { }

	public virtual void Execute(AppState state) { }

}

