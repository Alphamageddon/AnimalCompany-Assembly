namespace UnityEngine.SpatialTracking;

internal class TrackedPoseDriverDataDescription
{
	public struct PoseData
	{
		public List<String> PoseNames; //Field offset: 0x0
		public List<TrackedPose> Poses; //Field offset: 0x8

	}

	internal static List<PoseData> DeviceData; //Field offset: 0x0

	private static TrackedPoseDriverDataDescription() { }

	public TrackedPoseDriverDataDescription() { }

}

