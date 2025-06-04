namespace Unity.XR.CoreUtils;

[Extension]
public static class PoseExtensions
{

	[Extension]
	public static Vector3 ApplyInverseOffsetTo(Pose pose, Vector3 position) { }

	[Extension]
	public static Vector3 ApplyOffsetTo(Pose pose, Vector3 position) { }

	[Extension]
	public static Pose ApplyOffsetTo(Pose pose, Pose otherPose) { }

}

