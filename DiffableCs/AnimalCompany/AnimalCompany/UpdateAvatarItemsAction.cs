namespace AnimalCompany;

public class UpdateAvatarItemsAction : BaseAction
{
	private IEnumerable<ApiAvatarItem> _items; //Field offset: 0x18

	public UpdateAvatarItemsAction(IEnumerable<ApiAvatarItem> items) { }

	public virtual void Execute(AppState state) { }

}

