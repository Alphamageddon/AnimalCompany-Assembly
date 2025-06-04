namespace UnityEngine.XR;

[NativeConditional("ENABLE_VR")]
public static class XRDevice
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<String> deviceLoaded; //Field offset: 0x0

	[NativeName("DisableAutoVRCameraTracking")]
	[StaticAccessor("GetIVRDevice()", StaticAccessorType::ArrowWithDefaultReturnIfNull (3))]
	public static void DisableAutoXRCameraTracking(Camera camera, bool disabled) { }

	[RequiredByNativeCode]
	private static void InvokeDeviceLoaded(string loadedDeviceName) { }

}

