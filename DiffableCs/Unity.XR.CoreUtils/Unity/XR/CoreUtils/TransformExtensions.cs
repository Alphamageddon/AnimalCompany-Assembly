namespace Unity.XR.CoreUtils;

[Extension]
public static class TransformExtensions
{

	[Extension]
	public static Pose GetLocalPose(Transform transform) { }

	[Extension]
	public static Pose GetWorldPose(Transform transform) { }

	[Extension]
	public static Pose InverseTransformPose(Transform transform, Pose pose) { }

	[Extension]
	public static Ray InverseTransformRay(Transform transform, Ray ray) { }

	[Extension]
	public static void SetLocalPose(Transform transform, Pose pose) { }

	[Extension]
	public static void SetWorldPose(Transform transform, Pose pose) { }

	[Extension]
	public static Pose TransformPose(Transform transform, Pose pose) { }

}

