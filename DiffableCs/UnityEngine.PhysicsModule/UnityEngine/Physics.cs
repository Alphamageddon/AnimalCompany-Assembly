namespace UnityEngine;

[NativeHeader("Modules/Physics/PhysicsManager.h")]
[StaticAccessor("GetPhysicsManager()", StaticAccessorType::Dot (0))]
public class Physics
{
	internal sealed class ContactEventDelegate : MulticastDelegate
	{

		public ContactEventDelegate(object object, IntPtr method) { }

		public override void Invoke(PhysicsScene scene, ReadOnly<ContactPairHeader> headerArray) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<PhysicsScene, NativeArray`1<ModifiableContactPair>> ContactModifyEvent; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<PhysicsScene, NativeArray`1<ModifiableContactPair>> ContactModifyEventCCD; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static ContactEventDelegate ContactEvent; //Field offset: 0x10
	private static readonly Collision s_ReusableCollision; //Field offset: 0x18

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Physics.autoSimulation has been replaced by Physics.simulationMode", False)]
	public static bool autoSimulation
	{
		 get { } //Length: 120
		 set { } //Length: 124
	}

	public static bool autoSyncTransforms
	{
		 get { } //Length: 40
		 set { } //Length: 60
	}

	[NativeProperty("DefaultPhysicsSceneHandle", True, TargetType::Function (0), True)]
	public static PhysicsScene defaultPhysicsScene
	{
		 get { } //Length: 124
	}

	public static Vector3 gravity
	{
		[ThreadSafe]
		 get { } //Length: 140
	}

	public static bool invokeCollisionCallbacks
	{
		 get { } //Length: 40
	}

	public static bool queriesHitTriggers
	{
		 get { } //Length: 40
	}

	public static bool reuseCollisionCallbacks
	{
		 get { } //Length: 40
	}

	public static SimulationMode simulationMode
	{
		 get { } //Length: 40
		 set { } //Length: 60
	}

	public static float sleepThreshold
	{
		 get { } //Length: 40
	}

	private static Physics() { }

	public static bool ComputePenetration(Collider colliderA, Vector3 positionA, Quaternion rotationA, Collider colliderB, Vector3 positionB, Quaternion rotationB, out Vector3 direction, out float distance) { }

	public static bool get_autoSimulation() { }

	public static bool get_autoSyncTransforms() { }

	public static PhysicsScene get_defaultPhysicsScene() { }

	private static void get_defaultPhysicsScene_Injected(out PhysicsScene ret) { }

	[ThreadSafe]
	public static Vector3 get_gravity() { }

	private static void get_gravity_Injected(out Vector3 ret) { }

	public static bool get_invokeCollisionCallbacks() { }

	public static bool get_queriesHitTriggers() { }

	public static bool get_reuseCollisionCallbacks() { }

	public static SimulationMode get_simulationMode() { }

	public static float get_sleepThreshold() { }

	[StaticAccessor("PhysicsManager", StaticAccessorType::DoubleColon (2))]
	internal static Component GetBodyByInstanceID(int instanceID) { }

	[StaticAccessor("PhysicsManager", StaticAccessorType::DoubleColon (2))]
	internal static Collider GetColliderByInstanceID(int instanceID) { }

	private static Collision GetCollisionToReport(in ContactPairHeader header, in ContactPair pair, bool flipped) { }

	public static bool GetIgnoreCollision(Collider collider1, Collider collider2) { }

	public static void IgnoreCollision(Collider collider1, Collider collider2, bool ignore) { }

	[ExcludeFromDocs]
	public static void IgnoreCollision(Collider collider1, Collider collider2) { }

	[NativeName("RaycastAll")]
	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", StaticAccessorType::Dot (0))]
	private static RaycastHit[] Internal_RaycastAll(PhysicsScene physicsScene, Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	private static RaycastHit[] Internal_RaycastAll_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo, int layerMask) { }

	[RequiredByNativeCode]
	private static void OnSceneContact(PhysicsScene scene, IntPtr buffer, int count) { }

	[RequiredByNativeCode]
	private static void OnSceneContactModify(PhysicsScene scene, IntPtr buffer, int count, bool isCCD) { }

	public static Collider[] OverlapCapsule(Vector3 point0, Vector3 point1, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	public static Collider[] OverlapCapsule(Vector3 point0, Vector3 point1, float radius, int layerMask) { }

	[NativeName("OverlapCapsule")]
	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", StaticAccessorType::Dot (0))]
	private static Collider[] OverlapCapsule_Internal(PhysicsScene physicsScene, Vector3 point0, Vector3 point1, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	private static Collider[] OverlapCapsule_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 point0, ref Vector3 point1, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	public static Collider[] OverlapSphere(Vector3 position, float radius) { }

	[ExcludeFromDocs]
	public static Collider[] OverlapSphere(Vector3 position, float radius, int layerMask) { }

	public static Collider[] OverlapSphere(Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[NativeName("OverlapSphere")]
	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", StaticAccessorType::Dot (0))]
	private static Collider[] OverlapSphere_Internal(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	private static Collider[] OverlapSphere_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	public static int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	public static int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results, int layerMask) { }

	[NativeName("ComputePenetration")]
	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
	private static bool Query_ComputePenetration(Collider colliderA, Vector3 positionA, Quaternion rotationA, Collider colliderB, Vector3 positionB, Quaternion rotationB, ref Vector3 direction, ref float distance) { }

	private static bool Query_ComputePenetration_Injected(Collider colliderA, ref Vector3 positionA, ref Quaternion rotationA, Collider colliderB, ref Vector3 positionB, ref Quaternion rotationB, ref Vector3 direction, ref float distance) { }

	[ExcludeFromDocs]
	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	public static bool Raycast(Ray ray) { }

	[ExcludeFromDocs]
	public static bool Raycast(Ray ray, float maxDistance) { }

	[ExcludeFromDocs]
	public static bool Raycast(Ray ray, float maxDistance, int layerMask) { }

	public static bool Raycast(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance) { }

	[ExcludeFromDocs]
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo) { }

	[ExcludeFromDocs]
	[RequiredByNativeCode]
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	public static bool Raycast(Vector3 origin, Vector3 direction) { }

	[ExcludeFromDocs]
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance) { }

	[ExcludeFromDocs]
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask) { }

	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance) { }

	[ExcludeFromDocs]
	public static bool Raycast(Ray ray, out RaycastHit hitInfo) { }

	[ExcludeFromDocs]
	[RequiredByNativeCode]
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance) { }

	[ExcludeFromDocs]
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction) { }

	[ExcludeFromDocs]
	public static RaycastHit[] RaycastAll(Ray ray) { }

	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance) { }

	[ExcludeFromDocs]
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results) { }

	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance) { }

	[ExcludeFromDocs]
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results) { }

	[ExcludeFromDocs]
	[RequiredByNativeCode]
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask) { }

	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance) { }

	private static void ReportContacts(ReadOnly<ContactPairHeader> array) { }

	[StaticAccessor("PhysicsManager", StaticAccessorType::DoubleColon (2))]
	private static void SendOnCollisionEnter(Component component, Collision collision) { }

	[StaticAccessor("PhysicsManager", StaticAccessorType::DoubleColon (2))]
	private static void SendOnCollisionExit(Component component, Collision collision) { }

	[StaticAccessor("PhysicsManager", StaticAccessorType::DoubleColon (2))]
	private static void SendOnCollisionStay(Component component, Collision collision) { }

	public static void set_autoSimulation(bool value) { }

	public static void set_autoSyncTransforms(bool value) { }

	public static void set_simulationMode(SimulationMode value) { }

	public static void Simulate(float step) { }

	[NativeName("Simulate")]
	internal static void Simulate_Internal(PhysicsScene physicsScene, float step) { }

	private static void Simulate_Internal_Injected(ref PhysicsScene physicsScene, float step) { }

	[ExcludeFromDocs]
	public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask) { }

	public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	public static void SyncTransforms() { }

}

