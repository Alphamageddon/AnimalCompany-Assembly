namespace Fusion.XR.Host.Rig;

public class XRInputDevice : MonoBehaviour
{
	internal struct InputDevicePose : ICopiable<InputDevicePose>
	{
		public Vector3 position; //Field offset: 0x0
		public Quaternion rotation; //Field offset: 0xC

		public override void CopyValuesFrom(InputDevicePose source) { }

	}

	public const int INTERPOLATION_BUFFER_SIZE = 20; //Field offset: 0x0
	[Header("Detected input device")]
	[SerializeField]
	private bool isDeviceFound; //Field offset: 0x20
	public InputDevice device; //Field offset: 0x28
	[Header("Synchronisation")]
	public bool shouldSynchDevicePosition; //Field offset: 0x38
	[Header("Positioning timing")]
	public bool updateOnAfterInputSystemUpdate; //Field offset: 0x39
	public TimedRingbuffer<InputDevicePose> ringBuffer; //Field offset: 0x40
	private InputDevicePose latestPose; //Field offset: 0x60

	protected override InputDeviceCharacteristics DesiredCharacteristics
	{
		 get { } //Length: 8
	}

	public XRInputDevice() { }

	public override void DetectDevice() { }

	public override List<InputDevice> DeviceLookup() { }

	protected override InputDeviceCharacteristics get_DesiredCharacteristics() { }

	public InputDevicePose InterpolatedPose(float delay = 0.3) { }

	public void OnAfterInputSystemUpdate() { }

	protected void OnDisable() { }

	protected void OnEnable() { }

	protected override void Update() { }

	protected void UpdatePosition() { }

}

