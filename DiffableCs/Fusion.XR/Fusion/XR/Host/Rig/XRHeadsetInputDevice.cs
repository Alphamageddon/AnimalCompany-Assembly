namespace Fusion.XR.Host.Rig;

public class XRHeadsetInputDevice : XRInputDevice
{
	[Header("Camera options")]
	public bool preventAutoXRCameraTracking; //Field offset: 0x7C

	protected virtual InputDeviceCharacteristics DesiredCharacteristics
	{
		 get { } //Length: 8
	}

	public XRHeadsetInputDevice() { }

	private void Awake() { }

	protected virtual InputDeviceCharacteristics get_DesiredCharacteristics() { }

}

