namespace UnityEngine.XR.Interaction.Toolkit.Utilities;

[BurstCompile]
public static class BurstGazeUtility
{

	public static bool IsAlignedToGazeForward(in float3 gazeDirection, in float3 targetDirection, float angleThreshold) { }

	public static bool IsOutsideDistanceRange(in float3 gazePosition, in float3 targetPosition, float distanceThreshold) { }

	public static bool IsOutsideGaze(in float3 gazePosition, in float3 gazeDirection, in float3 targetPosition, float angleThreshold) { }

}

