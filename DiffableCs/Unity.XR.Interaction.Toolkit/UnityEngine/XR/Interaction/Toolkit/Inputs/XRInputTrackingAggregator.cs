namespace UnityEngine.XR.Interaction.Toolkit.Inputs;

public static class XRInputTrackingAggregator
{
	internal static class Characteristics
	{

		public static InputDeviceCharacteristics eyeGaze
		{
			 get { } //Length: 8
		}

		public static InputDeviceCharacteristics hmd
		{
			 get { } //Length: 8
		}

		public static InputDeviceCharacteristics leftController
		{
			 get { } //Length: 8
		}

		public static InputDeviceCharacteristics leftTrackedHand
		{
			 get { } //Length: 8
		}

		public static InputDeviceCharacteristics rightController
		{
			 get { } //Length: 8
		}

		public static InputDeviceCharacteristics rightTrackedHand
		{
			 get { } //Length: 8
		}

		public static InputDeviceCharacteristics get_eyeGaze() { }

		public static InputDeviceCharacteristics get_hmd() { }

		public static InputDeviceCharacteristics get_leftController() { }

		public static InputDeviceCharacteristics get_leftTrackedHand() { }

		public static InputDeviceCharacteristics get_rightController() { }

		public static InputDeviceCharacteristics get_rightTrackedHand() { }

	}

	private static List<InputDevice> s_XRInputDevices; //Field offset: 0x0

	public static TrackingStatus GetEyeGazeStatus() { }

	public static TrackingStatus GetHMDStatus() { }

	public static TrackingStatus GetLeftControllerStatus() { }

	public static TrackingStatus GetLeftMetaAimHandStatus() { }

	public static TrackingStatus GetLeftTrackedHandStatus() { }

	public static TrackingStatus GetRightControllerStatus() { }

	public static TrackingStatus GetRightMetaAimHandStatus() { }

	public static TrackingStatus GetRightTrackedHandStatus() { }

	private static TrackingStatus GetTrackingStatus(TrackedDevice device) { }

	private static TrackingStatus GetTrackingStatus(InputDevice device) { }

	internal static bool TryGetDeviceWithExactCharacteristics(InputDeviceCharacteristics desiredCharacteristics, out InputDevice inputDevice) { }

}

