namespace AnimalCompany.API;

public struct ApiAvatarItem
{
	public string id; //Field offset: 0x0
	public string name; //Field offset: 0x8
	public string type; //Field offset: 0x10
	public bool showInShop; //Field offset: 0x18
	public bool new; //Field offset: 0x19
	public int hardPrice; //Field offset: 0x1C
	public String[] subItems; //Field offset: 0x20
	public String[] subItemsFlat; //Field offset: 0x28

}

