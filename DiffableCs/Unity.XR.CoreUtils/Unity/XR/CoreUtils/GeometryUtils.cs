namespace Unity.XR.CoreUtils;

public static class GeometryUtils
{
	private const float k_TwoPi = 6.2831855; //Field offset: 0x0
	private static readonly Vector3 k_Up; //Field offset: 0x0
	private const float k_MostlyVertical = 0.95; //Field offset: 0x0
	private static readonly Vector3 k_Forward; //Field offset: 0xC
	private static readonly Vector3 k_Zero; //Field offset: 0x18
	private static readonly Quaternion k_VerticalCorrection; //Field offset: 0x24
	private static readonly List<Vector3> k_HullEdgeDirections; //Field offset: 0x38
	private static readonly HashSet<Int32> k_HullIndices; //Field offset: 0x40

	private static GeometryUtils() { }

	public static Vector3 ClosestPointOnLineSegment(Vector3 point, Vector3 a, Vector3 b) { }

	public static bool ClosestPointsOnTwoLineSegments(Vector3 a, Vector3 aLineVector, Vector3 b, Vector3 bLineVector, out Vector3 resultA, out Vector3 resultB, double parallelTest = 5E-324) { }

	public static void ClosestPolygonApproach(List<Vector3> verticesA, List<Vector3> verticesB, out Vector3 pointA, out Vector3 pointB, float parallelTest = 0) { }

	public static bool ClosestTimesOnTwoLines(Vector3 positionA, Vector3 velocityA, Vector3 positionB, Vector3 velocityB, out float s, out float t, double parallelTest = 5E-324) { }

	public static bool ClosestTimesOnTwoLinesXZ(Vector3 positionA, Vector3 velocityA, Vector3 positionB, Vector3 velocityB, out float s, out float t, double parallelTest = 5E-324) { }

	public static bool ConvexHull2D(List<Vector3> points, List<Vector3> hull) { }

	public static float ConvexPolygonArea(List<Vector3> vertices) { }

	public static bool FindClosestEdge(List<Vector3> vertices, Vector3 point, out Vector3 vertexA, out Vector3 vertexB) { }

	private static Quaternion NormalizeRotationKeepingUp(Quaternion rot) { }

	public static Vector2 OrientedMinimumBoundingBox2D(List<Vector3> convexHull, Vector3[] boundingBox) { }

	public static bool PointInPolygon(Vector3 testPoint, List<Vector3> vertices) { }

	public static bool PointInPolygon3D(Vector3 testPoint, List<Vector3> vertices) { }

	public static bool PointOnLineSegmentXZ(Vector3 testPoint, Vector3 lineStart, Vector3 lineEnd, float epsilon = 1E-45) { }

	public static Vector3 PointOnOppositeSideOfPolygon(List<Vector3> vertices, Vector3 point) { }

	public static bool PointOnPolygonBoundsXZ(Vector3 testPoint, List<Vector3> vertices, float epsilon = 1E-45) { }

	public static Vector3 PolygonCentroid2D(List<Vector3> vertices) { }

	public static bool PolygonInPolygon(List<Vector3> polygonA, List<Vector3> polygonB) { }

	public static bool PolygonsWithinRange(List<Vector3> polygonA, List<Vector3> polygonB, float maxDistance) { }

	public static bool PolygonsWithinSqRange(List<Vector3> polygonA, List<Vector3> polygonB, float maxSqDistance) { }

	public static Pose PolygonUVPoseFromPlanePose(Pose pose) { }

	public static Vector2 PolygonVertexToUV(Vector3 vertexPos, Pose planePose, Pose uvPose) { }

	public static Vector3 ProjectPointOnPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 point) { }

	private static void RotateCalipers(Vector3 alignEdge, List<Vector3> vertices, ref int indexA, out int indexB, out int indexC, out int indexD, out Vector3 caliperA, out Vector3 caliperB, out Vector3 caliperC, out Vector3 caliperD, out Vector3 caliperAEndCorner, out Vector3 caliperBEndCorner, out Vector3 caliperCEndCorner, out Vector3 caliperDEndCorner) { }

	public static Quaternion RotationForBox(Vector3[] vertices) { }

	public static void TriangulatePolygon(List<Int32> indices, int vertCount, bool reverse = false) { }

}

