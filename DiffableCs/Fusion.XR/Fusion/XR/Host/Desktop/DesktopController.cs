namespace Fusion.XR.Host.Desktop;

public class DesktopController : MonoBehaviour
{
	public InputActionProperty forwardAction; //Field offset: 0x20
	public InputActionProperty rotationAction; //Field offset: 0x38
	private HardwareRig rig; //Field offset: 0x50
	private RigLocomotion locomotion; //Field offset: 0x58
	public float strafeSpeed; //Field offset: 0x60
	public float forwardSpeed; //Field offset: 0x64
	public float rotationSpeed; //Field offset: 0x68

	public DesktopController() { }

	private void Awake() { }

	public override void Move(Vector3 newPosition) { }

	private Vector3 ProjectHeadsetGroundPosition() { }

	private void Start() { }

	private void Update() { }

}

