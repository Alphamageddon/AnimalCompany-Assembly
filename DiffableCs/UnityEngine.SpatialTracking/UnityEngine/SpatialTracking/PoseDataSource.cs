namespace UnityEngine.SpatialTracking;

public static class PoseDataSource
{
	internal static List<XRNodeState> nodeStates; //Field offset: 0x0

	private static PoseDataSource() { }

	public static PoseDataFlags GetDataFromSource(TrackedPose poseSource, out Pose resultPose) { }

	internal static PoseDataFlags GetNodePoseData(XRNode node, out Pose resultPose) { }

	public static bool TryGetDataFromSource(TrackedPose poseSource, out Pose resultPose) { }

}

