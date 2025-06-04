namespace UnityEngine.XR;

[NativeConditional("ENABLE_XR")]
[NativeType(Header = "Modules/XR/Subsystems/Input/XRInputSubsystem.h")]
[UsedByNativeCode]
public class XRInputSubsystem : IntegratedSubsystem<XRInputSubsystemDescriptor>
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<XRInputSubsystem> trackingOriginUpdated; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<XRInputSubsystem> boundaryChanged; //Field offset: 0x28
	private List<UInt64> m_DeviceIdsCache; //Field offset: 0x30

	public event Action<XRInputSubsystem> trackingOriginUpdated
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public XRInputSubsystem() { }

	[CompilerGenerated]
	public void add_trackingOriginUpdated(Action<XRInputSubsystem> value) { }

	public TrackingOriginModeFlags GetSupportedTrackingOriginModes() { }

	public TrackingOriginModeFlags GetTrackingOriginMode() { }

	[RequiredByNativeCode(GenerateProxy = True)]
	private static void InvokeBoundaryChangedEvent(IntPtr internalPtr) { }

	[RequiredByNativeCode(GenerateProxy = True)]
	private static void InvokeTrackingOriginUpdatedEvent(IntPtr internalPtr) { }

	[CompilerGenerated]
	public void remove_trackingOriginUpdated(Action<XRInputSubsystem> value) { }

	public bool TryRecenter() { }

	public bool TrySetTrackingOriginMode(TrackingOriginModeFlags origin) { }

}

