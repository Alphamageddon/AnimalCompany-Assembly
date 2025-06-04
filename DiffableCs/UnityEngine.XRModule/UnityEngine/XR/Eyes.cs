namespace UnityEngine.XR;

[NativeConditional("ENABLE_VR")]
[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
[NativeHeader("XRScriptingClasses.h")]
[NativeHeader("Modules/XR/XRPrefix.h")]
[RequiredByNativeCode]
[StaticAccessor("XRInputDevices::Get()", StaticAccessorType::Dot (0))]
public struct Eyes : IEquatable<Eyes>
{
	private ulong m_DeviceId; //Field offset: 0x0
	private uint m_FeatureIndex; //Field offset: 0x8

	internal ulong deviceId
	{
		internal get { } //Length: 8
	}

	internal uint featureIndex
	{
		internal get { } //Length: 8
	}

	public virtual bool Equals(object obj) { }

	public override bool Equals(Eyes other) { }

	internal ulong get_deviceId() { }

	internal uint get_featureIndex() { }

	public virtual int GetHashCode() { }

}

