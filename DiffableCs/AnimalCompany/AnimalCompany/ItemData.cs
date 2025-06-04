namespace AnimalCompany;

[CreateAssetMenu(fileName = "ItemData", menuName = "AnimalCompany/ItemData", order = 1)]
public class ItemData : ScriptableObject
{
	[Flags]
	internal enum Type
	{
		None = 0,
		Unidentified = 1,
		Loot = 2,
		Purchasable = 4,
		Unique = 8,
	}

	public string itemName; //Field offset: 0x18
	public int price; //Field offset: 0x20
	public int value; //Field offset: 0x24
	public Type type; //Field offset: 0x28
	public GameObject preview; //Field offset: 0x30
	public GameObject prefab; //Field offset: 0x38

	public bool isSellable
	{
		 get { } //Length: 16
	}

	public ItemData() { }

	public bool get_isSellable() { }

}

