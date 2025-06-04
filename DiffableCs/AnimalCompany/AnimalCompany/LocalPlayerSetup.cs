namespace AnimalCompany;

public class LocalPlayerSetup : MonoBehaviour
{
	public bool enableQWOPEditorControls; //Field offset: 0x20
	public GameObject playerRig; //Field offset: 0x28
	private HardwareRig _hardwareRig; //Field offset: 0x30

	public LocalPlayerSetup() { }

	private void OnConnected(NetworkRunner runner) { }

	private void OnDestroy() { }

	private void Start() { }

}

