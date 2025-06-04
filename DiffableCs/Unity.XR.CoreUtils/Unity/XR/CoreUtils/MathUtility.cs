namespace Unity.XR.CoreUtils;

[Extension]
public static class MathUtility
{
	internal static readonly float EpsilonScaled; //Field offset: 0x0

	private static MathUtility() { }

	public static bool Approximately(float a, float b) { }

	public static bool ApproximatelyZero(float a) { }

	public static double Clamp(double input, double min, double max) { }

	public static int FirstActiveFlagIndex(int value) { }

	[Extension]
	public static bool IsAxisAligned(Vector3 v) { }

	public static bool IsPositivePowerOfTwo(int value) { }

	[Extension]
	public static bool IsUndefined(float value) { }

	public static double ShortestAngleDistance(double start, double end, double halfMax, double max) { }

	public static float ShortestAngleDistance(float start, float end, float halfMax, float max) { }

}

