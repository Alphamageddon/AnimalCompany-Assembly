namespace UnityEngine;

[NativeHeader("Physics2DScriptingClasses.h")]
[NativeHeader("Physics2DScriptingClasses.h")]
[NativeHeader("Modules/Physics2D/PhysicsManager2D.h")]
[StaticAccessor("GetPhysicsManager2D()", StaticAccessorType::Arrow (1))]
public class Physics2D
{
	private static List<Rigidbody2D> m_LastDisabledRigidbody2D; //Field offset: 0x0

	[StaticAccessor("GetPhysics2DSettings()")]
	public static float angularSleepTolerance
	{
		 get { } //Length: 40
	}

	[StaticAccessor("GetPhysics2DSettings()")]
	public static bool autoSyncTransforms
	{
		 get { } //Length: 40
		 set { } //Length: 60
	}

	public static PhysicsScene2D defaultPhysicsScene
	{
		 get { } //Length: 8
	}

	[StaticAccessor("GetPhysics2DSettings()")]
	public static float linearSleepTolerance
	{
		 get { } //Length: 40
	}

	[StaticAccessor("GetPhysics2DSettings()")]
	public static bool queriesHitTriggers
	{
		 get { } //Length: 40
	}

	[StaticAccessor("GetPhysics2DSettings()")]
	public static SimulationMode2D simulationMode
	{
		 get { } //Length: 40
		 set { } //Length: 60
	}

	private static Physics2D() { }

	public static float get_angularSleepTolerance() { }

	public static bool get_autoSyncTransforms() { }

	public static PhysicsScene2D get_defaultPhysicsScene() { }

	public static float get_linearSleepTolerance() { }

	public static bool get_queriesHitTriggers() { }

	public static SimulationMode2D get_simulationMode() { }

	public static RaycastHit2D GetRayIntersection(Ray ray, float distance, int layerMask) { }

	[RequiredByNativeCode]
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, float distance, int layerMask) { }

	[ExcludeFromDocs]
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, float distance) { }

	[ExcludeFromDocs]
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray) { }

	[NativeMethod("GetRayIntersectionAll_Binding")]
	[StaticAccessor("PhysicsQuery2D", StaticAccessorType::DoubleColon (2))]
	private static RaycastHit2D[] GetRayIntersectionAll_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask) { }

	private static RaycastHit2D[] GetRayIntersectionAll_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector3 origin, ref Vector3 direction, float distance, int layerMask) { }

	[ExcludeFromDocs]
	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results) { }

	[ExcludeFromDocs]
	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, float distance) { }

	[RequiredByNativeCode]
	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, float distance, int layerMask) { }

	[ExcludeFromDocs]
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth) { }

	[ExcludeFromDocs]
	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, float distance) { }

	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, float distance = ∞) { }

	[ExcludeFromDocs]
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance) { }

	[ExcludeFromDocs]
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction) { }

	[ExcludeFromDocs]
	[RequiredByNativeCode]
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask) { }

	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth) { }

	public static void set_autoSyncTransforms(bool value) { }

	public static void set_simulationMode(SimulationMode2D value) { }

	public static bool Simulate(float step) { }

	[NativeMethod("Simulate_Binding")]
	internal static bool Simulate_Internal(PhysicsScene2D physicsScene, float step) { }

	private static bool Simulate_Internal_Injected(ref PhysicsScene2D physicsScene, float step) { }

}

