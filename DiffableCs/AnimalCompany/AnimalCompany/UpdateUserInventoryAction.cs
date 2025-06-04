namespace AnimalCompany;

public class UpdateUserInventoryAction : BaseAction
{
	private ApiUserInventory _inventory; //Field offset: 0x18

	public UpdateUserInventoryAction(ApiUserInventory inventory) { }

	public virtual void Execute(AppState state) { }

}

