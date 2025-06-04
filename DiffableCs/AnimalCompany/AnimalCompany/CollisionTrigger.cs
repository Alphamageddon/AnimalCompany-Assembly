namespace AnimalCompany;

public class CollisionTrigger : MonoBehaviour
{
	internal enum TargetType
	{
		LocalPlayer = 0,
		Item = 1,
	}

	public Action<Collider> onTriggerEnter; //Field offset: 0x20
	public Action<Collider> onTriggerExit; //Field offset: 0x28
	[SerializeField]
	private TargetType _targetType; //Field offset: 0x30

	public CollisionTrigger() { }

	private void OnTriggerEnter(Collider other) { }

	private void OnTriggerExit(Collider other) { }

	private void OnValidate() { }

}

