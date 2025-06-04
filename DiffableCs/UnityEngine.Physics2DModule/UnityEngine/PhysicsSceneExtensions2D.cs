namespace UnityEngine;

[Extension]
public static class PhysicsSceneExtensions2D
{

	[NativeMethod("GetPhysicsSceneFromUnityScene")]
	[StaticAccessor("GetPhysicsManager2D()", StaticAccessorType::Arrow (1))]
	private static PhysicsScene2D GetPhysicsScene_Internal(Scene scene) { }

	private static void GetPhysicsScene_Internal_Injected(ref Scene scene, out PhysicsScene2D ret) { }

	[Extension]
	public static PhysicsScene2D GetPhysicsScene2D(Scene scene) { }

}

