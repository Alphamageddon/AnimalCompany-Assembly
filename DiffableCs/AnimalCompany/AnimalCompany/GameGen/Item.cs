namespace AnimalCompany.GameGen;

public class Item : MonoBehaviour
{
	[SerializeField]
	public ItemData _itemData; //Field offset: 0x20
	public GrabbableItem grabbableItem; //Field offset: 0x28
	public ItemPointSize size; //Field offset: 0x30

	public ItemData itemData
	{
		 get { } //Length: 136
	}

	public int itemValue
	{
		 get { } //Length: 28
	}

	public Item() { }

	public ItemData get_itemData() { }

	public int get_itemValue() { }

	private void OnDrawGizmos() { }

	private void OnDrawGizmosSelected() { }

}

