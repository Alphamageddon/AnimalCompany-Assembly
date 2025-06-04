namespace UnityEngine.Rendering;

public class XRGraphics
{
	internal enum StereoRenderingMode
	{
		MultiPass = 0,
		SinglePass = 1,
		SinglePassInstanced = 2,
		SinglePassMultiView = 3,
	}


	public static bool enabled
	{
		 get { } //Length: 8
	}

	public static RenderTextureDescriptor eyeTextureDesc
	{
		 get { } //Length: 120
	}

	public static int eyeTextureHeight
	{
		 get { } //Length: 40
	}

	public static float eyeTextureResolutionScale
	{
		 get { } //Length: 40
		 set { } //Length: 8
	}

	public static int eyeTextureWidth
	{
		 get { } //Length: 40
	}

	public static bool isDeviceActive
	{
		 get { } //Length: 40
	}

	public static string loadedDeviceName
	{
		 get { } //Length: 80
	}

	public static float renderViewportScale
	{
		 get { } //Length: 40
	}

	public static StereoRenderingMode stereoRenderingMode
	{
		 get { } //Length: 40
	}

	public static String[] supportedDevices
	{
		 get { } //Length: 84
	}

	public XRGraphics() { }

	public static bool get_enabled() { }

	public static RenderTextureDescriptor get_eyeTextureDesc() { }

	public static int get_eyeTextureHeight() { }

	public static float get_eyeTextureResolutionScale() { }

	public static int get_eyeTextureWidth() { }

	public static bool get_isDeviceActive() { }

	public static string get_loadedDeviceName() { }

	public static float get_renderViewportScale() { }

	public static StereoRenderingMode get_stereoRenderingMode() { }

	public static String[] get_supportedDevices() { }

	public static void set_eyeTextureResolutionScale(float value) { }

}

