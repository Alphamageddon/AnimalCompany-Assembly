namespace AnimalCompany;

public class ClearAccessoryFromDraftAvatarAction : BaseAction
{
	private ApiAvatarItemType _accessoryType; //Field offset: 0x14

	public ClearAccessoryFromDraftAvatarAction(ApiAvatarItemType accessory) { }

	public virtual void Execute(AppState state) { }

}

