namespace UnityEngine.XR;

public static class CommonUsages
{
	public static InputFeatureUsage<Boolean> isTracked; //Field offset: 0x0
	public static InputFeatureUsage<Boolean> primaryButton; //Field offset: 0x8
	public static InputFeatureUsage<Boolean> primaryTouch; //Field offset: 0x10
	public static InputFeatureUsage<Boolean> secondaryButton; //Field offset: 0x18
	public static InputFeatureUsage<Boolean> secondaryTouch; //Field offset: 0x20
	public static InputFeatureUsage<Boolean> gripButton; //Field offset: 0x28
	public static InputFeatureUsage<Boolean> triggerButton; //Field offset: 0x30
	public static InputFeatureUsage<Boolean> menuButton; //Field offset: 0x38
	public static InputFeatureUsage<Boolean> primary2DAxisClick; //Field offset: 0x40
	public static InputFeatureUsage<Boolean> primary2DAxisTouch; //Field offset: 0x48
	public static InputFeatureUsage<Boolean> secondary2DAxisClick; //Field offset: 0x50
	public static InputFeatureUsage<Boolean> secondary2DAxisTouch; //Field offset: 0x58
	public static InputFeatureUsage<Boolean> userPresence; //Field offset: 0x60
	public static InputFeatureUsage<InputTrackingState> trackingState; //Field offset: 0x68
	public static InputFeatureUsage<Single> batteryLevel; //Field offset: 0x70
	public static InputFeatureUsage<Single> trigger; //Field offset: 0x78
	public static InputFeatureUsage<Single> grip; //Field offset: 0x80
	public static InputFeatureUsage<Vector2> primary2DAxis; //Field offset: 0x88
	public static InputFeatureUsage<Vector2> secondary2DAxis; //Field offset: 0x90
	public static InputFeatureUsage<Vector3> devicePosition; //Field offset: 0x98
	public static InputFeatureUsage<Vector3> leftEyePosition; //Field offset: 0xA0
	public static InputFeatureUsage<Vector3> rightEyePosition; //Field offset: 0xA8
	public static InputFeatureUsage<Vector3> centerEyePosition; //Field offset: 0xB0
	public static InputFeatureUsage<Vector3> colorCameraPosition; //Field offset: 0xB8
	public static InputFeatureUsage<Vector3> deviceVelocity; //Field offset: 0xC0
	public static InputFeatureUsage<Vector3> deviceAngularVelocity; //Field offset: 0xC8
	public static InputFeatureUsage<Vector3> leftEyeVelocity; //Field offset: 0xD0
	public static InputFeatureUsage<Vector3> leftEyeAngularVelocity; //Field offset: 0xD8
	public static InputFeatureUsage<Vector3> rightEyeVelocity; //Field offset: 0xE0
	public static InputFeatureUsage<Vector3> rightEyeAngularVelocity; //Field offset: 0xE8
	public static InputFeatureUsage<Vector3> centerEyeVelocity; //Field offset: 0xF0
	public static InputFeatureUsage<Vector3> centerEyeAngularVelocity; //Field offset: 0xF8
	public static InputFeatureUsage<Vector3> colorCameraVelocity; //Field offset: 0x100
	public static InputFeatureUsage<Vector3> colorCameraAngularVelocity; //Field offset: 0x108
	public static InputFeatureUsage<Vector3> deviceAcceleration; //Field offset: 0x110
	public static InputFeatureUsage<Vector3> deviceAngularAcceleration; //Field offset: 0x118
	public static InputFeatureUsage<Vector3> leftEyeAcceleration; //Field offset: 0x120
	public static InputFeatureUsage<Vector3> leftEyeAngularAcceleration; //Field offset: 0x128
	public static InputFeatureUsage<Vector3> rightEyeAcceleration; //Field offset: 0x130
	public static InputFeatureUsage<Vector3> rightEyeAngularAcceleration; //Field offset: 0x138
	public static InputFeatureUsage<Vector3> centerEyeAcceleration; //Field offset: 0x140
	public static InputFeatureUsage<Vector3> centerEyeAngularAcceleration; //Field offset: 0x148
	public static InputFeatureUsage<Vector3> colorCameraAcceleration; //Field offset: 0x150
	public static InputFeatureUsage<Vector3> colorCameraAngularAcceleration; //Field offset: 0x158
	public static InputFeatureUsage<Quaternion> deviceRotation; //Field offset: 0x160
	public static InputFeatureUsage<Quaternion> leftEyeRotation; //Field offset: 0x168
	public static InputFeatureUsage<Quaternion> rightEyeRotation; //Field offset: 0x170
	public static InputFeatureUsage<Quaternion> centerEyeRotation; //Field offset: 0x178
	public static InputFeatureUsage<Quaternion> colorCameraRotation; //Field offset: 0x180
	public static InputFeatureUsage<Hand> handData; //Field offset: 0x188
	public static InputFeatureUsage<Eyes> eyesData; //Field offset: 0x190
	[Obsolete("CommonUsages.dPad is not used by any XR platform and will be removed.")]
	public static InputFeatureUsage<Vector2> dPad; //Field offset: 0x198
	[Obsolete("CommonUsages.indexFinger is not used by any XR platform and will be removed.")]
	public static InputFeatureUsage<Single> indexFinger; //Field offset: 0x1A0
	[Obsolete("CommonUsages.MiddleFinger is not used by any XR platform and will be removed.")]
	public static InputFeatureUsage<Single> middleFinger; //Field offset: 0x1A8
	[Obsolete("CommonUsages.RingFinger is not used by any XR platform and will be removed.")]
	public static InputFeatureUsage<Single> ringFinger; //Field offset: 0x1B0
	[Obsolete("CommonUsages.PinkyFinger is not used by any XR platform and will be removed.")]
	public static InputFeatureUsage<Single> pinkyFinger; //Field offset: 0x1B8
	[Obsolete("CommonUsages.thumbrest is Oculus only, and is being moved to their package. Please use OculusUsages.thumbrest. These will still function until removed.")]
	public static InputFeatureUsage<Boolean> thumbrest; //Field offset: 0x1C0
	[Obsolete("CommonUsages.indexTouch is Oculus only, and is being moved to their package.  Please use OculusUsages.indexTouch. These will still function until removed.")]
	public static InputFeatureUsage<Single> indexTouch; //Field offset: 0x1C8
	[Obsolete("CommonUsages.thumbTouch is Oculus only, and is being moved to their package.  Please use OculusUsages.thumbTouch. These will still function until removed.")]
	public static InputFeatureUsage<Single> thumbTouch; //Field offset: 0x1D0

	private static CommonUsages() { }

}

