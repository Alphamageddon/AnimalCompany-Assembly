namespace UnityEngine.XR;

[NativeConditional("ENABLE_VR")]
[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputTrackingFacade.h")]
[RequiredByNativeCode]
[StaticAccessor("XRInputTrackingFacade::Get()", StaticAccessorType::Dot (0))]
public static class InputTracking
{
	private enum TrackingStateEventType
	{
		NodeAdded = 0,
		NodeRemoved = 1,
		TrackingAcquired = 2,
		TrackingLost = 3,
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<XRNodeState> trackingAcquired; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<XRNodeState> trackingLost; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<XRNodeState> nodeAdded; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<XRNodeState> nodeRemoved; //Field offset: 0x18

	public static event Action<XRNodeState> trackingAcquired
	{
		[CompilerGenerated]
		 add { } //Length: 204
		[CompilerGenerated]
		 remove { } //Length: 204
	}

	[CompilerGenerated]
	public static void add_trackingAcquired(Action<XRNodeState> value) { }

	[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputTracking.h")]
	[StaticAccessor("XRInputTracking::Get()", StaticAccessorType::Dot (0))]
	internal static ulong GetDeviceIdAtXRNode(XRNode node) { }

	public static void GetNodeStates(List<XRNodeState> nodeStates) { }

	[NativeConditional("ENABLE_VR")]
	private static void GetNodeStates_Internal(List<XRNodeState> nodeStates) { }

	[RequiredByNativeCode]
	private static void InvokeTrackingEvent(TrackingStateEventType eventType, XRNode nodeType, long uniqueID, bool tracked) { }

	[CompilerGenerated]
	public static void remove_trackingAcquired(Action<XRNodeState> value) { }

}

