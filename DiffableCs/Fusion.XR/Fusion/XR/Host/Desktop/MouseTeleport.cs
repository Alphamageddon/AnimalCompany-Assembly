namespace Fusion.XR.Host.Desktop;

public class MouseTeleport : MonoBehaviour
{
	public const float HAND_RANGE = 0.7; //Field offset: 0x0
	public HardwareRig rig; //Field offset: 0x20
	public Camera mouseCamera; //Field offset: 0x28
	public Vector3 defaultLeftHandPosition; //Field offset: 0x30
	public Vector3 defaultRightHandPosition; //Field offset: 0x3C
	public Quaternion defaultLeftHandRotation; //Field offset: 0x48
	public Quaternion defaultRightHandRotation; //Field offset: 0x58
	public bool forceFirstPersonView; //Field offset: 0x68
	public DesktopController hardwareRigControl; //Field offset: 0x70
	public HardwareHand grabberHand; //Field offset: 0x78
	public HardwareHand beamerHand; //Field offset: 0x80
	public RayBeamer rayBeamer; //Field offset: 0x88
	private GameObject grabbed; //Field offset: 0x90
	public IMouseTeleportHover hoverListener; //Field offset: 0x98
	private float grabHandDistance; //Field offset: 0xA0

	private Transform Head
	{
		private get { } //Length: 144
	}

	public MouseTeleport() { }

	private void Awake() { }

	private bool CheckGrab(Ray mouseRay) { }

	private void CheckUngrab() { }

	private Transform get_Head() { }

	private Vector3 SearchTarget(Ray mouseRay) { }

	private void Start() { }

	private void Update() { }

}

