namespace Fusion.XR.Host.Utils;

[Extension]
public static class VelocityExtension
{

	[Extension]
	public static Vector3 AngularVelocityChange(Quaternion previousRotation, Quaternion newRotation, float elapsedTime) { }

	[Extension]
	public static Quaternion RotationFromAngularVelocity(Transform transform, Vector3 angularVelocity, float time) { }

	[Extension]
	public static void VelocityFollow(Rigidbody followerRb, Transform target, Vector3 positionOffset, Quaternion rotationOffset, float elapsedTime) { }

	[Extension]
	public static void VelocityFollow(Rigidbody followerRb, Vector3 targetPosition, Quaternion targetRotation, float elapsedTime) { }

}

