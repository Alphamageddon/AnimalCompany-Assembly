namespace UnityEngine.U2D;

[MovedFrom("UnityEngine.Experimental.U2D")]
[NativeHeader("Runtime/2D/Common/PixelSnapping.h")]
public static class PixelPerfectRendering
{

	public static float pixelSnapSpacing
	{
		[FreeFunction("SetPixelSnapSpacing")]
		 set { } //Length: 56
	}

	[FreeFunction("SetPixelSnapSpacing")]
	public static void set_pixelSnapSpacing(float value) { }

}

