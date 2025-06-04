namespace Photon.Voice;

public class DeviceFeatures
{
	internal static DeviceFeatures Default; //Field offset: 0x0
	[CompilerGenerated]
	private CameraFacing <CameraFacing>k__BackingField; //Field offset: 0x10

	public private CameraFacing CameraFacing
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	private static DeviceFeatures() { }

	public DeviceFeatures() { }

	public DeviceFeatures(CameraFacing facing) { }

	[CompilerGenerated]
	public CameraFacing get_CameraFacing() { }

	[CompilerGenerated]
	private void set_CameraFacing(CameraFacing value) { }

}

