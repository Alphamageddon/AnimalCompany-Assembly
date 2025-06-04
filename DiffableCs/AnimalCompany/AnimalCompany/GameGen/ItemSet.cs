namespace AnimalCompany.GameGen;

[CreateAssetMenu(fileName = "ItemSet", menuName = "GameGen/Item Set", order = 0)]
public class ItemSet : ScriptableObject
{
	public List<WeightedItem> items; //Field offset: 0x18

	public ItemSet() { }

}

