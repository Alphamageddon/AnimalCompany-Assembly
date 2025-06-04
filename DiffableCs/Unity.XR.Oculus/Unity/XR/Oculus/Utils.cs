namespace Unity.XR.Oculus;

public static class Utils
{

	public static bool eyeTrackedFoveatedRenderingEnabled
	{
		 get { } //Length: 32
		 set { } //Length: 264
	}

	public static bool eyeTrackedFoveatedRenderingSupported
	{
		 get { } //Length: 4
	}

	public static int foveatedRenderingLevel
	{
		 get { } //Length: 120
		 set { } //Length: 124
	}

	public static bool useDynamicFoveatedRendering
	{
		 get { } //Length: 4
		 set { } //Length: 124
	}

	[Obsolete("Please use useDynamicFoveatedRendering instead", False)]
	public static bool EnableDynamicFFR(bool enable) { }

	public static bool get_eyeTrackedFoveatedRenderingEnabled() { }

	public static bool get_eyeTrackedFoveatedRenderingSupported() { }

	public static int get_foveatedRenderingLevel() { }

	public static bool get_useDynamicFoveatedRendering() { }

	[Obsolete("Please use foveatedRenderingLevel instead.", False)]
	public static int GetFoveationLevel() { }

	public static SystemHeadset GetSystemHeadsetType() { }

	public static bool IsEyeTrackingPermissionGranted() { }

	private static void PermissionGrantedCallback(string permissionName) { }

	public static void set_eyeTrackedFoveatedRenderingEnabled(bool value) { }

	public static void set_foveatedRenderingLevel(int value) { }

	public static void set_useDynamicFoveatedRendering(bool value) { }

	public static void SetColorScaleAndOffset(Vector4 colorScale, Vector4 colorOffset) { }

	[Obsolete("Please use foveatedRenderingLevel instead.", False)]
	public static bool SetFoveationLevel(int level) { }

}

