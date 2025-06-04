namespace UnityEngine.ProBuilder;

internal static class Clipping
{
	[Flags]
	private enum OutCode
	{
		Inside = 0,
		Left = 1,
		Right = 2,
		Bottom = 4,
		Top = 8,
	}


	private static OutCode ComputeOutCode(Rect rect, float x, float y) { }

	internal static bool RectContainsLineSegment(Rect rect, float x0, float y0, float x1, float y1) { }

}

