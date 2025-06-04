namespace UnityEngine.XR;

[NativeConditional("ENABLE_VR")]
[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
[StaticAccessor("XRInputDevices::Get()", StaticAccessorType::Dot (0))]
[UsedByNativeCode]
public class InputDevices
{
	private static List<InputDevice> s_InputDeviceList; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<InputDevice> deviceConnected; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<InputDevice> deviceDisconnected; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<InputDevice> deviceConfigChanged; //Field offset: 0x18

	public static event Action<InputDevice> deviceConfigChanged
	{
		[CompilerGenerated]
		 add { } //Length: 208
		[CompilerGenerated]
		 remove { } //Length: 208
	}

	public static event Action<InputDevice> deviceConnected
	{
		[CompilerGenerated]
		 add { } //Length: 208
		[CompilerGenerated]
		 remove { } //Length: 208
	}

	public static event Action<InputDevice> deviceDisconnected
	{
		[CompilerGenerated]
		 add { } //Length: 208
		[CompilerGenerated]
		 remove { } //Length: 208
	}

	[CompilerGenerated]
	public static void add_deviceConfigChanged(Action<InputDevice> value) { }

	[CompilerGenerated]
	public static void add_deviceConnected(Action<InputDevice> value) { }

	[CompilerGenerated]
	public static void add_deviceDisconnected(Action<InputDevice> value) { }

	public static InputDevice GetDeviceAtXRNode(XRNode node) { }

	internal static InputDeviceCharacteristics GetDeviceCharacteristics(ulong deviceId) { }

	public static void GetDevices(List<InputDevice> inputDevices) { }

	private static void GetDevices_Internal(List<InputDevice> inputDevices) { }

	public static void GetDevicesWithCharacteristics(InputDeviceCharacteristics desiredCharacteristics, List<InputDevice> inputDevices) { }

	[RequiredByNativeCode]
	private static void InvokeConnectionEvent(ulong deviceId, ConnectionChangeType change) { }

	internal static bool IsDeviceValid(ulong deviceId) { }

	[CompilerGenerated]
	public static void remove_deviceConfigChanged(Action<InputDevice> value) { }

	[CompilerGenerated]
	public static void remove_deviceConnected(Action<InputDevice> value) { }

	[CompilerGenerated]
	public static void remove_deviceDisconnected(Action<InputDevice> value) { }

	internal static bool SendHapticBuffer(ulong deviceId, uint channel, Byte[] buffer) { }

	internal static bool SendHapticImpulse(ulong deviceId, uint channel, float amplitude, float duration) { }

	internal static bool TryGetFeatureValue_bool(ulong deviceId, string usage, out bool value) { }

	internal static bool TryGetFeatureValue_float(ulong deviceId, string usage, out float value) { }

	internal static bool TryGetFeatureValue_Quaternionf(ulong deviceId, string usage, out Quaternion value) { }

	internal static bool TryGetFeatureValue_UInt32(ulong deviceId, string usage, out uint value) { }

	internal static bool TryGetFeatureValue_Vector2f(ulong deviceId, string usage, out Vector2 value) { }

	internal static bool TryGetFeatureValue_Vector3f(ulong deviceId, string usage, out Vector3 value) { }

	internal static bool TryGetHapticCapabilities(ulong deviceId, out HapticCapabilities capabilities) { }

}

