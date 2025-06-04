// Batch 2
namespace AnimalCompany;

public class UpdateUserInventoryAction : BaseAction
{
        private ApiUserInventory _inventory; //Field offset: 0x18

        public UpdateUserInventoryAction(ApiUserInventory inventory)
        {
                _inventory = inventory;
        }

        public virtual void Execute(AppState state)
        {
                if (_inventory == null || state?.user?.inventory == null)
                        return;

                state.user.inventory.FromApiModel(_inventory);
        }

}

