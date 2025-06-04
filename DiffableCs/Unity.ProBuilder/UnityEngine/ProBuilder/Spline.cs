namespace UnityEngine.ProBuilder;

internal static class Spline
{

	internal static ProBuilderMesh Extrude(IList<BezierPoint> points, float radius = 0.5, int columns = 32, int rows = 16, bool closeLoop = false, bool smooth = true) { }

	internal static void Extrude(IList<BezierPoint> bezierPoints, float radius, int columns, int rows, bool closeLoop, bool smooth, ref ProBuilderMesh target) { }

	internal static void Extrude(IList<Vector3> points, float radius, int radiusRows, bool closeLoop, bool smooth, ref ProBuilderMesh target, IList<Quaternion> pointRotations = null) { }

	internal static List<Vector3> GetControlPoints(IList<BezierPoint> bezierPoints, int subdivisionsPerSegment, bool closeLoop, List<Quaternion> rotations) { }

	private static Quaternion GetRingRotation(IList<Vector3> points, int i, bool closeLoop, out float secant) { }

	private static Vector3[] VertexRing(Quaternion orientation, Vector3 offset, float radius, int segments) { }

}

