namespace AnimalCompany;

public class UpdateUserAvatarsAction : BaseAction
{
	private GetAvatarsResponse _response; //Field offset: 0x18

	public UpdateUserAvatarsAction(GetAvatarsResponse response) { }

	public virtual void Execute(AppState state) { }

}

