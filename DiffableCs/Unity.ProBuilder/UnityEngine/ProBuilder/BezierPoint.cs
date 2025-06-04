namespace UnityEngine.ProBuilder;

internal struct BezierPoint
{
	public Vector3 position; //Field offset: 0x0
	public Vector3 tangentIn; //Field offset: 0xC
	public Vector3 tangentOut; //Field offset: 0x18
	public Quaternion rotation; //Field offset: 0x24

	public BezierPoint(Vector3 position, Vector3 tangentIn, Vector3 tangentOut, Quaternion rotation) { }

	public static Vector3 CubicPosition(BezierPoint a, BezierPoint b, float t) { }

	public void EnforceTangentMode(BezierTangentDirection master, BezierTangentMode mode) { }

	public static Vector3 GetLookDirection(IList<BezierPoint> points, int index, int previous, int next) { }

	public static Vector3 QuadraticPosition(BezierPoint a, BezierPoint b, float t) { }

	public void SetPosition(Vector3 position) { }

	public void SetTangentIn(Vector3 tangent, BezierTangentMode mode) { }

	public void SetTangentOut(Vector3 tangent, BezierTangentMode mode) { }

}

