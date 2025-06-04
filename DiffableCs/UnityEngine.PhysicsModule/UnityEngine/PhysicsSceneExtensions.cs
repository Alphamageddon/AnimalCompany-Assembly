namespace UnityEngine;

[Extension]
public static class PhysicsSceneExtensions
{

	[Extension]
	public static PhysicsScene GetPhysicsScene(Scene scene) { }

	[NativeMethod("GetPhysicsSceneFromUnityScene")]
	[StaticAccessor("GetPhysicsManager()", StaticAccessorType::Dot (0))]
	private static PhysicsScene GetPhysicsScene_Internal(Scene scene) { }

	private static void GetPhysicsScene_Internal_Injected(ref Scene scene, out PhysicsScene ret) { }

}

