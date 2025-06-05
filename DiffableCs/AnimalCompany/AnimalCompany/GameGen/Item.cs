namespace AnimalCompany.GameGen;

public class Item : MonoBehaviour
{
	public GrabbableItem grabbableItem; //Field offset: 0x20
	public ItemPointSize size; //Field offset: 0x28

	public int itemValue
	{
		 get { } //Length: 36
	}

	public Item() { }

	public int get_itemValue() { }

	private void OnDrawGizmos() { }

	private void OnDrawGizmosSelected() { }

}

