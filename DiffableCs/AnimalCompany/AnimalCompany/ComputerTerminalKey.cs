namespace AnimalCompany;

public class ComputerTerminalKey : MonoBehaviour
{
	public KeyCode keyCode; //Field offset: 0x20
	public Collider keyCollider; //Field offset: 0x28
	public Transform pressTransform; //Field offset: 0x30
	public Vector3 pressedOffset; //Field offset: 0x38
	private Collider _handCollider; //Field offset: 0x48
	private Vector3 _originalPosition; //Field offset: 0x50
	public Action<ComputerTerminalKey> onKeyPressed; //Field offset: 0x60
	public Action<ComputerTerminalKey> onKeyReleased; //Field offset: 0x68

	public ComputerTerminalKey() { }

	private void OnTriggerEnter(Collider other) { }

	private void OnTriggerExit(Collider other) { }

	private void Start() { }

}

