namespace UnityEngine.Rendering;

public static class CameraCaptureBridge
{
	private static Dictionary<Camera, HashSet`1<Action`2<RenderTargetIdentifier, CommandBuffer>>> actionDict; //Field offset: 0x0
	private static bool _enabled; //Field offset: 0x8

	public static bool enabled
	{
		 get { } //Length: 88
		 set { } //Length: 96
	}

	private static CameraCaptureBridge() { }

	public static void AddCaptureAction(Camera camera, Action<RenderTargetIdentifier, CommandBuffer> action) { }

	public static bool get_enabled() { }

	public static IEnumerator<Action`2<RenderTargetIdentifier, CommandBuffer>> GetCaptureActions(Camera camera) { }

	public static void RemoveCaptureAction(Camera camera, Action<RenderTargetIdentifier, CommandBuffer> action) { }

	public static void set_enabled(bool value) { }

}

