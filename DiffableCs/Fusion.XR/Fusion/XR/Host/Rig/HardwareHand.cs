namespace Fusion.XR.Host.Rig;

public class HardwareHand : MonoBehaviour
{
	public RigPart side; //Field offset: 0x20
	public HandCommand handCommand; //Field offset: 0x24
	public bool isGrabbing; //Field offset: 0x3C
	public Grabber grabber; //Field offset: 0x40
	[Header("Hand pose input")]
	public InputActionProperty thumbAction; //Field offset: 0x48
	public InputActionProperty gripAction; //Field offset: 0x60
	public InputActionProperty triggerAction; //Field offset: 0x78
	public InputActionProperty indexAction; //Field offset: 0x90
	public int handPose; //Field offset: 0xA8
	[Header("Hand interaction input")]
	public InputActionProperty grabAction; //Field offset: 0xB0
	public float grabThreshold; //Field offset: 0xC8
	public bool updateGrabWithAction; //Field offset: 0xCC
	public NetworkTransform networkTransform; //Field offset: 0xD0
	public IHandRepresentation localHandRepresentation; //Field offset: 0xD8
	private Nullable<InputDevice> _device; //Field offset: 0xE0
	private bool supportImpulse; //Field offset: 0xF8

	public Nullable<InputDevice> Device
	{
		 get { } //Length: 392
	}

	public HardwareHand() { }

	private void Awake() { }

	public Nullable<InputDevice> get_Device() { }

	public void SendHapticBuffer(Byte[] buffer, uint channel = 0) { }

	public void SendHapticImpulse(float amplitude, float duration, uint channel = 0) { }

	protected override void Update() { }

}

