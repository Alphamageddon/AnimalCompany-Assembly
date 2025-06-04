namespace Fusion.LagCompensation;

internal static class LagCompensationUtils
{
	public struct BoxNarrowData
	{
		public Vector3 Position; //Field offset: 0x0
		public Vector3 Extents; //Field offset: 0xC
		public Vector3 RotatedRight; //Field offset: 0x18
		public Vector3 RotatedUp; //Field offset: 0x24
		public Vector3 RotatedForward; //Field offset: 0x30
		public CustomPlanesBox BoxPlanesRotated; //Field offset: 0x3C
		public CustomEdgesBox BoxEdgesRotated; //Field offset: 0xCC

		public BoxNarrowData(Vector3 pos, Quaternion rot, Vector3 extents) { }

		public Vector3 LocalToWorldPoint(Vector3 point) { }

		public Vector3 LocalToWorldVector(Vector3 vec) { }

		public Vector3 WorldToLocalPoint(Vector3 point) { }

		public Vector3 WorldToLocalVector(Vector3 vec) { }

	}

	internal struct ContactData
	{
		public Vector3 Point; //Field offset: 0x0
		public Vector3 Normal; //Field offset: 0xC
		public float Penetration; //Field offset: 0x18

	}

	public struct CustomEdgesBox
	{
		public Vector3 P0; //Field offset: 0x0
		public Vector3 P1; //Field offset: 0xC
		public Vector3 P2; //Field offset: 0x18
		public Vector3 P3; //Field offset: 0x24
		public Vector3 P4; //Field offset: 0x30
		public Vector3 P5; //Field offset: 0x3C
		public Vector3 P6; //Field offset: 0x48
		public Vector3 P7; //Field offset: 0x54

		public CustomLine E00
		{
			 get { } //Length: 20
		}

		public CustomLine E01
		{
			 get { } //Length: 20
		}

		public CustomLine E02
		{
			 get { } //Length: 20
		}

		public CustomLine E03
		{
			 get { } //Length: 36
		}

		public CustomLine E04
		{
			 get { } //Length: 20
		}

		public CustomLine E05
		{
			 get { } //Length: 20
		}

		public CustomLine E06
		{
			 get { } //Length: 20
		}

		public CustomLine E07
		{
			 get { } //Length: 36
		}

		public CustomLine E08
		{
			 get { } //Length: 36
		}

		public CustomLine E09
		{
			 get { } //Length: 36
		}

		public CustomLine E10
		{
			 get { } //Length: 36
		}

		public CustomLine E11
		{
			 get { } //Length: 36
		}

		public CustomLine get_E00() { }

		public CustomLine get_E01() { }

		public CustomLine get_E02() { }

		public CustomLine get_E03() { }

		public CustomLine get_E04() { }

		public CustomLine get_E05() { }

		public CustomLine get_E06() { }

		public CustomLine get_E07() { }

		public CustomLine get_E08() { }

		public CustomLine get_E09() { }

		public CustomLine get_E10() { }

		public CustomLine get_E11() { }

	}

	public struct CustomLine
	{
		public Vector3 Start; //Field offset: 0x0
		public Vector3 End; //Field offset: 0xC

		public CustomLine(Vector3 start, Vector3 end) { }

	}

	public struct CustomPlane
	{
		public Vector3 Normal; //Field offset: 0x0
		public Vector3 PointOnPlane; //Field offset: 0xC

		public CustomPlane(Vector3 normal, Vector3 pointOnPlane) { }

	}

	public struct CustomPlanesBox
	{
		public CustomPlane P0; //Field offset: 0x0
		public CustomPlane P1; //Field offset: 0x18
		public CustomPlane P2; //Field offset: 0x30
		public CustomPlane P3; //Field offset: 0x48
		public CustomPlane P4; //Field offset: 0x60
		public CustomPlane P5; //Field offset: 0x78

	}

	private struct RotationMatrix
	{
		public float M00; //Field offset: 0x0
		public float M01; //Field offset: 0x4
		public float M02; //Field offset: 0x8
		public float M10; //Field offset: 0xC
		public float M11; //Field offset: 0x10
		public float M12; //Field offset: 0x14
		public float M20; //Field offset: 0x18
		public float M21; //Field offset: 0x1C
		public float M22; //Field offset: 0x20

	}

	private const float ALLOWED_DOT_DIFF = 0.975; //Field offset: 0x0
	private const float EXTENTS_EXPANSION_MULTIPLIER = 1.025; //Field offset: 0x0
	private const float MIN_CROSS_THRESHOLD = 0.0001; //Field offset: 0x0

	private static bool BoxInAABB(ref CustomEdgesBox boxEdges, ref BoxNarrowData boxNarrow, ref Vector3 offset) { }

	internal static bool ClampPointToAABB(Vector3 point, Vector3 aabbExtents, out Vector3 clampedPoint) { }

	private static bool ClipToPlane(ref CustomPlane plane, ref Vector3 lineStart, ref Vector3 lineEnd, ref Vector3 intersection) { }

	public static ValueTuple<Vector3, Vector3, Single> ClosestDistanceBetweenLines(Vector3 a0, Vector3 a1, Vector3 b0, Vector3 b1, bool clampAll = false, bool clampA0 = false, bool clampA1 = false, bool clampB0 = false, bool clampB1 = false) { }

	internal static Vector3 ClosestPtPointSegment(Vector3 point, Vector3 a, Vector3 b) { }

	private static Vector3 GetAABBSupportPoint(Vector3 pointA, Vector3 pointB, Vector3 extents) { }

	private static void GetContactPointPlaneEdge(ref CustomPlanesBox planes, ref CustomEdgesBox edges, ref BoxNarrowData boxNarrow, ref Vector3 offset, ref Vector3 boxAPosition, bool detailedManifold, ref int cpCount, ref Vector3 contactPoint) { }

	private static CustomEdgesBox GetEdgesBox(CustomEdgesBox edges, ref Vector3 translation) { }

	private static bool GetHitPoint(ref CustomPlanesBox planesA, ref CustomPlanesBox planesB, ref CustomEdgesBox edgesA, ref CustomEdgesBox edgesB, ref BoxNarrowData boxNarrowA, ref BoxNarrowData boxNarrowB, ref Vector3 boxAToBoxBOffset, bool computeDetailedInfo, out Vector3 contactPoint) { }

	private static CustomPlanesBox GetPlanesBox(CustomPlanesBox planes, ref Vector3 translation) { }

	internal static bool LocalAABBCapsuleIntersection(Vector3 localCapsuleCenter, Vector3 localCapsulePointA, Vector3 localCapsulePointB, float capsuleRadius, Vector3 aabbExtents, out ContactData contactData) { }

	public static bool LocalAABBSphereContact(Vector3 aabbExtents, Vector3 sphereCenter, float sphereRadius, out ContactData contact) { }

	public static bool LocalAABBSphereIntersection(Vector3 aabbExtents, Vector3 sphereCenter, float sphereRadius) { }

	internal static bool LocalRayCapsuleIntersection(Vector3 capsuleTopCenter, Vector3 capsuleBottomCenter, float capsuleRadius, Vector3 rayLocalOrigin, Vector3 rayLocalDir, float maxDistance, out Vector3 point, out Vector3 normal, out float distance) { }

	internal static bool LocalSphereCapsuleIntersection(Vector3 capsuleTopCenter, Vector3 capsuleBottomCenter, float capsuleRadius, Vector3 sphereCenter, float sphereRadius, out ContactData contactData) { }

	internal static bool NarrowBoxBox(ref BoxNarrowData aNarrow, ref BoxNarrowData bNarrow, bool detailedManifold, out Vector3 hitPoint, out Vector3 normal) { }

	private static bool PointInAABB(Vector3 point, ref BoxNarrowData boxNarrow, ref Vector3 max, ref Vector3 offset) { }

	internal static bool RayAABB(ref Vector3 minB, ref Vector3 maxB, ref Vector3 origin, ref Vector3 dir, float sqrMaxdistance, out Vector3 point, out Vector3 normal, out float distance) { }

	internal static float RayCapsuleIntersect(Vector3 rayOrigin, Vector3 rayDir, Vector3 capsulePointA, Vector3 capsulePointB, float capsuleRadius) { }

	internal static bool RaySphereIntersection(Vector3 p1, Vector3 dir, float length, Vector3 center, float radius, out Vector3 hitPoint, out Vector3 normal, out float distance) { }

	internal static bool SphereSphere(Vector3 centerA, float radiusA, Vector3 centerB, float radiusB, out Vector3 intersection, out Vector3 normal) { }

}

