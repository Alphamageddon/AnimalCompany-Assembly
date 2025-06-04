namespace Unity.XR.Oculus;

public static class Boundary
{
	internal enum BoundaryType
	{
		OuterBoundary = 0,
		PlayArea = 1,
	}


	public static bool GetBoundaryConfigured() { }

	public static bool GetBoundaryDimensions(BoundaryType boundaryType, out Vector3 dimensions) { }

	public static bool GetBoundaryVisible() { }

	public static void SetBoundaryVisible(bool boundaryVisible) { }

}

