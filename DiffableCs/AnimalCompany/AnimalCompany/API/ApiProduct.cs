namespace AnimalCompany.API;

public struct ApiProduct
{
	public string id; //Field offset: 0x0
	public string name; //Field offset: 0x8
	public string description; //Field offset: 0x10
	public bool consumable; //Field offset: 0x18
	public bool enabled; //Field offset: 0x19
	public int rewardSoft; //Field offset: 0x1C
	public int rewardHard; //Field offset: 0x20
	public String[] rewardAvatarItems; //Field offset: 0x28
	public String[] rewardAvatarItemsFlat; //Field offset: 0x30

}

