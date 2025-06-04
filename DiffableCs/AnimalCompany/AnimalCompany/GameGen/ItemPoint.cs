namespace AnimalCompany.GameGen;

public class ItemPoint : MonoBehaviour
{
	public ItemPointSize size; //Field offset: 0x20
	[HideInInspector]
	public bool used; //Field offset: 0x24

	public ItemPoint() { }

	public Vector3 GetCenterPosition() { }

	private void OnDrawGizmos() { }

	private void OnDrawGizmosSelected() { }

}

