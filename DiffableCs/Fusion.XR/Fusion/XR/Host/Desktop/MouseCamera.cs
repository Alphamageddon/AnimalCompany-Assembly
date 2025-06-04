namespace Fusion.XR.Host.Desktop;

public class MouseCamera : MonoBehaviour
{
	public InputActionProperty mouseXAction; //Field offset: 0x20
	public InputActionProperty mouseYAction; //Field offset: 0x38
	public bool forceRotation; //Field offset: 0x50
	public HardwareRig rig; //Field offset: 0x58
	[Header("Mouse point of view")]
	public Vector2 maxMouseInput; //Field offset: 0x60
	public float maxHeadRotationSpeed; //Field offset: 0x68
	public Vector2 sensitivity; //Field offset: 0x6C
	public float maxHeadAngle; //Field offset: 0x74
	public float minHeadAngle; //Field offset: 0x78
	private Vector3 rotation; //Field offset: 0x7C
	private Vector2 mouseInput; //Field offset: 0x88

	private Transform Head
	{
		private get { } //Length: 144
	}

	public MouseCamera() { }

	private void Awake() { }

	private Transform get_Head() { }

	private void Update() { }

}

