namespace Fusion.XR.Host.Rig;

public class XRControllerInputDevice : XRInputDevice
{
	internal enum ControllerSide
	{
		Left = 0,
		Right = 1,
	}

	[Header("Hand type")]
	public ControllerSide side; //Field offset: 0x7C

	protected virtual InputDeviceCharacteristics DesiredCharacteristics
	{
		 get { } //Length: 24
	}

	public XRControllerInputDevice() { }

	protected virtual InputDeviceCharacteristics get_DesiredCharacteristics() { }

}

