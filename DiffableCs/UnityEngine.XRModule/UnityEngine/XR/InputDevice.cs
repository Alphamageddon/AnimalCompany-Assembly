namespace UnityEngine.XR;

[NativeConditional("ENABLE_VR")]
[UsedByNativeCode]
public struct InputDevice : IEquatable<InputDevice>
{
	private static List<XRInputSubsystem> s_InputSubsystemCache; //Field offset: 0x0
	private ulong m_DeviceId; //Field offset: 0x0
	private bool m_Initialized; //Field offset: 0x8

	public InputDeviceCharacteristics characteristics
	{
		 get { } //Length: 92
	}

	private ulong deviceId
	{
		private get { } //Length: 24
	}

	public bool isValid
	{
		 get { } //Length: 92
	}

	internal InputDevice(ulong deviceId) { }

	private bool CheckValidAndSetDefault(out T value) { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(InputDevice other) { }

	public InputDeviceCharacteristics get_characteristics() { }

	private ulong get_deviceId() { }

	public bool get_isValid() { }

	public virtual int GetHashCode() { }

	private bool IsValidId() { }

	public bool SendHapticBuffer(uint channel, Byte[] buffer) { }

	public bool SendHapticImpulse(uint channel, float amplitude, float duration = 1) { }

	public bool TryGetFeatureValue(InputFeatureUsage<Single> usage, out float value) { }

	public bool TryGetFeatureValue(InputFeatureUsage<Vector2> usage, out Vector2 value) { }

	public bool TryGetFeatureValue(InputFeatureUsage<Vector3> usage, out Vector3 value) { }

	public bool TryGetFeatureValue(InputFeatureUsage<Quaternion> usage, out Quaternion value) { }

	public bool TryGetFeatureValue(InputFeatureUsage<InputTrackingState> usage, out InputTrackingState value) { }

	public bool TryGetFeatureValue(InputFeatureUsage<Boolean> usage, out bool value) { }

	public bool TryGetHapticCapabilities(out HapticCapabilities capabilities) { }

}

