namespace UnityEngine.ProBuilder;

[Extension]
public static class Math
{
	public const float phi = 1.618034; //Field offset: 0x0
	private const float k_FltEpsilon = 1E-45; //Field offset: 0x0
	private const float k_FltCompareEpsilon = 0.0001; //Field offset: 0x0
	internal const float handleEpsilon = 0.0001; //Field offset: 0x0
	private static Vector3 tv1; //Field offset: 0x0
	private static Vector3 tv2; //Field offset: 0xC
	private static Vector3 tv3; //Field offset: 0x18
	private static Vector3 tv4; //Field offset: 0x24

	[Extension]
	internal static Vector3 Abs(Vector3 v) { }

	[Extension]
	internal static bool Approx(float a, float b, float delta = 0.0001) { }

	[Extension]
	internal static bool Approx2(Vector2 a, Vector2 b, float delta = 0.0001) { }

	[Extension]
	internal static bool Approx3(Vector3 a, Vector3 b, float delta = 0.0001) { }

	[Extension]
	internal static bool Approx4(Vector4 a, Vector4 b, float delta = 0.0001) { }

	[Extension]
	internal static bool ApproxC(Color a, Color b, float delta = 0.0001) { }

	public static Vector4 Average(IList<Vector4> array, IList<Int32> indexes = null) { }

	public static Vector3 Average(IList<Vector3> array, IList<Int32> indexes = null) { }

	public static Vector2 Average(IList<Vector2> array, IList<Int32> indexes = null) { }

	public static int Clamp(int value, int lowerBound, int upperBound) { }

	internal static void Cross(Vector3 a, Vector3 b, ref Vector3 res) { }

	public static float DistancePointLineSegment(Vector3 point, Vector3 lineStart, Vector3 lineEnd) { }

	public static float DistancePointLineSegment(Vector2 point, Vector2 lineStart, Vector2 lineEnd) { }

	[Extension]
	internal static Vector3 DivideBy(Vector3 v, Vector3 o) { }

	[Extension]
	internal static Vector2 DivideBy(Vector2 v, Vector2 o) { }

	internal static Vector3 EnsureUnitVector(Vector3 value) { }

	internal static Vector2 EnsureUnitVector(Vector2 value) { }

	internal static Vector4 EnsureUnitVector(Vector4 value) { }

	internal static Vector4 FixNaN(Vector4 value) { }

	internal static Bounds GetBounds(Vector3[] positions, IList<Int32> indices = null) { }

	internal static bool GetLineSegmentIntersect(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3, ref Vector2 intersect) { }

	internal static bool GetLineSegmentIntersect(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3) { }

	public static Vector3 GetNearestPointRayRay(Ray a, Ray b) { }

	internal static Vector3 GetNearestPointRayRay(Vector3 ao, Vector3 ad, Vector3 bo, Vector3 bd) { }

	internal static Vector3 InvertScaleVector(Vector3 scaleVector) { }

	internal static bool IsCardinalAxis(Vector3 v, float epsilon = 1E-45) { }

	internal static bool IsNumber(float value) { }

	internal static bool IsNumber(Vector2 value) { }

	internal static bool IsNumber(Vector4 value) { }

	internal static bool IsNumber(Vector3 value) { }

	internal static float LargestValue(Vector2 v) { }

	internal static float LargestValue(Vector3 v) { }

	internal static Vector2 LargestVector2(Vector2[] v) { }

	internal static Vector2 LargestVector2(Vector2[] v, IList<Int32> indexes) { }

	internal static float MakeNonZero(float value, float min = 0.0001) { }

	internal static T Max(T[] array) { }

	internal static T Min(T[] array) { }

	public static Vector3 Normal(ProBuilderMesh mesh, Face face) { }

	internal static Vector3 Normal(IList<Vertex> vertices, IList<Int32> indexes = null) { }

	public static Vector3 Normal(Vector3 p0, Vector3 p1, Vector3 p2) { }

	public static Normal NormalTangentBitangent(ProBuilderMesh mesh, Face face) { }

	internal static Vector2 Perpendicular(Vector2 value) { }

	internal static Vector2 PointInCircumference(float radius, float angleInDegrees, Vector2 origin) { }

	internal static Vector2 PointInEllipseCircumference(float xRadius, float yRadius, float angleInDegrees, Vector2 origin, out Vector2 tangent) { }

	internal static Vector2 PointInEllipseCircumferenceWithConstantAngle(float xRadius, float yRadius, float angleInDegrees, Vector2 origin, out Vector2 tangent) { }

	internal static bool PointInPolygon(Vector3[] positions, Bounds2D polyBounds, Edge[] edges, Vector2 point) { }

	internal static bool PointInPolygon(Vector2[] polygon, Vector2 point, Int32[] indexes = null) { }

	internal static bool PointInPolygon(Vector2[] positions, Bounds2D polyBounds, Edge[] edges, Vector2 point) { }

	internal static Vector3 PointInSphere(float radius, float latitudeAngle, float longitudeAngle) { }

	internal static float PolygonArea(Vector3[] vertices, Int32[] indexes) { }

	public static bool RayIntersectsTriangle(Ray InRay, Vector3 InTriangleA, Vector3 InTriangleB, Vector3 InTriangleC, out float OutDistance, out Vector3 OutPoint) { }

	internal static bool RayIntersectsTriangle2(Vector3 origin, Vector3 dir, Vector3 vert0, Vector3 vert1, Vector3 vert2, ref float distance, ref Vector3 normal) { }

	internal static bool RectIntersectsLineSegment(Rect rect, Vector2 a, Vector2 b) { }

	internal static bool RectIntersectsLineSegment(Rect rect, Vector3 a, Vector3 b) { }

	public static Vector2 ReflectPoint(Vector2 point, Vector2 lineStart, Vector2 lineEnd) { }

	[Extension]
	internal static Vector2 RotateAroundPoint(Vector2 v, Vector2 origin, float theta) { }

	[Extension]
	public static Vector2 ScaleAroundPoint(Vector2 v, Vector2 origin, Vector2 scale) { }

	public static float Secant(float x) { }

	[Extension]
	internal static Vector3 Sign(Vector3 v) { }

	internal static float SignedAngle(Vector2 a, Vector2 b) { }

	internal static Vector2 SmallestVector2(Vector2[] v, IList<Int32> indexes) { }

	internal static Vector2 SmallestVector2(Vector2[] v) { }

	public static float SqrDistance(Vector3 a, Vector3 b) { }

	internal static float SqrDistanceRayPoint(Ray ray, Vector3 point) { }

	internal static void Subtract(Vector3 a, Vector3 b, ref Vector3 res) { }

	[Extension]
	internal static float Sum(Vector3 v) { }

	public static float TriangleArea(Vector3 x, Vector3 y, Vector3 z) { }

}

