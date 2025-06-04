namespace UnityEngine;

[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[NativeHeader("Runtime/Graphics/WindowLayout.h")]
[NativeHeader("Runtime/Graphics/ScreenManager.h")]
[StaticAccessor("GetScreenManager()", StaticAccessorType::Dot (0))]
public sealed class Screen
{

	public static float dpi
	{
		[NativeName("GetDPI")]
		 get { } //Length: 40
	}

	public static bool fullScreen
	{
		[NativeName("IsFullscreen")]
		 get { } //Length: 40
	}

	public static int height
	{
		[NativeMethod(Name = "GetHeight", IsThreadSafe = True)]
		 get { } //Length: 40
	}

	public static ScreenOrientation orientation
	{
		 get { } //Length: 40
	}

	public static Rect safeArea
	{
		 get { } //Length: 72
	}

	public static int width
	{
		[NativeMethod(Name = "GetWidth", IsThreadSafe = True)]
		 get { } //Length: 40
	}

	[NativeName("GetDPI")]
	public static float get_dpi() { }

	[NativeName("IsFullscreen")]
	public static bool get_fullScreen() { }

	[NativeMethod(Name = "GetHeight", IsThreadSafe = True)]
	public static int get_height() { }

	public static ScreenOrientation get_orientation() { }

	public static Rect get_safeArea() { }

	private static void get_safeArea_Injected(out Rect ret) { }

	[NativeMethod(Name = "GetWidth", IsThreadSafe = True)]
	public static int get_width() { }

	private static ScreenOrientation GetScreenOrientation() { }

}

