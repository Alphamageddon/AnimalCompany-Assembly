namespace AnimalCompany;

public class FreeCamera : MonoBehaviour
{
	public GameObject player; //Field offset: 0x20
	public bool useFreeCamera; //Field offset: 0x28
	public float movementSpeed; //Field offset: 0x2C
	public float fastMovementSpeed; //Field offset: 0x30
	public float freeLookSensitivity; //Field offset: 0x34
	public float zoomSensitivity; //Field offset: 0x38
	public float fastZoomSensitivity; //Field offset: 0x3C
	private bool looking; //Field offset: 0x40

	public FreeCamera() { }

	private void OnDisable() { }

	private void Start() { }

	public void StartLooking() { }

	public void StopLooking() { }

	private void Update() { }

}

