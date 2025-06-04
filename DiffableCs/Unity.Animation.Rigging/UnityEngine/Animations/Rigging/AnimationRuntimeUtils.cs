namespace UnityEngine.Animations.Rigging;

public static class AnimationRuntimeUtils
{
	private const float k_SqrEpsilon = 1E-08; //Field offset: 0x0

	public static void InverseSolveTwoBoneIK(AnimationStream stream, ReadOnlyTransformHandle root, ReadOnlyTransformHandle mid, ReadOnlyTransformHandle tip, ReadWriteTransformHandle target, ReadWriteTransformHandle hint, float posWeight, float rotWeight, float hintWeight, AffineTransform targetOffset) { }

	public static void InverseSolveTwoBoneIK(Vector3 rootPosition, Vector3 midPosition, Vector3 tipPosition, Quaternion tipRotation, ref Vector3 targetPosition, ref Quaternion targetRotation, ref Vector3 hintPosition, bool isHintValid, float posWeight, float rotWeight, float hintWeight, AffineTransform targetOffset) { }

	public static Vector3 Lerp(Vector3 a, Vector3 b, Vector3 t) { }

	public static void PassThrough(AnimationStream stream, ReadWriteTransformHandle handle) { }

	public static Vector3 ProjectOnPlane(Vector3 vector, Vector3 planeNormal) { }

	public static float Select(float a, float b, float c) { }

	public static Vector3 Select(Vector3 a, Vector3 b, Vector3 c) { }

	public static bool SolveFABRIK(ref NativeArray<Vector3>& linkPositions, ref NativeArray<Single>& linkLengths, Vector3 target, float tolerance, float maxReach, int maxIterations) { }

	public static void SolveTwoBoneIK(AnimationStream stream, ReadWriteTransformHandle root, ReadWriteTransformHandle mid, ReadWriteTransformHandle tip, ReadOnlyTransformHandle target, ReadOnlyTransformHandle hint, float posWeight, float rotWeight, float hintWeight, AffineTransform targetOffset) { }

	public static float SqrDistance(Vector3 lhs, Vector3 rhs) { }

	public static float Square(float value) { }

	internal static float Sum(AnimationJobCache cache, CacheIndex index, int count) { }

	public static float Sum(NativeArray<Single> floatBuffer) { }

	private static float TriangleAngle(float aLen, float aLen1, float aLen2) { }

}

