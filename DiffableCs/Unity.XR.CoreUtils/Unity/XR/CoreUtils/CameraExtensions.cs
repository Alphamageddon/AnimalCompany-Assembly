namespace Unity.XR.CoreUtils;

[Extension]
public static class CameraExtensions
{
	private const float k_OneOverSqrt2 = 0.70710677; //Field offset: 0x0

	[Extension]
	public static float GetHorizontalFieldOfView(Camera camera) { }

	[Extension]
	public static float GetVerticalFieldOfView(Camera camera, float aspectNeutralFieldOfView) { }

	[Extension]
	public static float GetVerticalOrthographicSize(Camera camera, float size) { }

}

