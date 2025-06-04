namespace AnimalCompany;

public class UserInventoryState : StateObject
{
	[CompilerGenerated]
	private StatePrimitiveSet<String> <avatarItems>k__BackingField; //Field offset: 0x48

	public private StatePrimitiveSet<String> avatarItems
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public UserInventoryState() { }

	public void FromApiModel(String[] apiModelRaw) { }

	public void FromApiModel(ApiUserInventory apiModel) { }

	[CompilerGenerated]
	public StatePrimitiveSet<String> get_avatarItems() { }

	[CompilerGenerated]
	private void set_avatarItems(StatePrimitiveSet<String> value) { }

}

