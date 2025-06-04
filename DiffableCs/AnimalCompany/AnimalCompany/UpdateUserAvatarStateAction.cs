namespace AnimalCompany;

public class UpdateUserAvatarStateAction : BaseAction
{
	private ApiUserAvatar _avatar; //Field offset: 0x18

	public UpdateUserAvatarStateAction(ApiUserAvatar avatar) { }

	public virtual void Execute(AppState state) { }

}

