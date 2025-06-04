namespace AnimalCompany;

[Extension]
public static class MobDetectionUtil
{
	private static readonly List<NetPlayer> _cachedPlayers; //Field offset: 0x0
	private static readonly Collider[] _cachedColliders; //Field offset: 0x8
	private static Collider[] _cachedLightColliders; //Field offset: 0x10
	private static RaycastHit[] _lightsBySight; //Field offset: 0x18

	private static MobDetectionUtil() { }

	public static bool GetContactPoint(Collider colliderA, Collider other, Vector3 centerPosition, Quaternion centerRotation, float radiusInner, float radiusOuter, LayerMask layerMask, out RaycastHit hit) { }

	public static void GetContactPoints(ref List<RaycastHit>& contactPoints, SphereCollider sphereCollider, Vector3 centerPosition, Quaternion centerRotation, float radiusInner, LayerMask layerMask) { }

	[Extension]
	public static void GetPlayersBySight(MobController mob, ref List<NetPlayer>& players) { }

	[Extension]
	public static List<NetPlayer> GetPlayersInRange(MobController mob, Vector3 center, float range) { }

	public static bool IsTargetInLineOfSight(Vector3 viewPosition, Vector3 targetPosition) { }

	public static bool IsTargetInLineOfSight(Vector3 viewPosition, Vector3 viewToTargetDirection, float viewToTargetDistance) { }

	public static bool IsVisibleByAnyLight(Vector3 position) { }

	public static bool TryGetAnyLightBySight(Vector3 viewPoint, Vector3 viewDirection, float viewRange, out Flashlight flashlightOutput) { }

	public static bool TryGetLightsBySight(Vector3 viewPoint, Vector3 viewDirection, float viewRange, out List<Flashlight>& flashlightsOutput) { }

	[Extension]
	public static bool TryGetPlayersBySight(MobController mob, ref List<NetPlayer>& players) { }

	[Extension]
	public static bool TryGetPlayersBySound(MobController mob, ref List<NetPlayer>& players) { }

	[Extension]
	public static bool TryGetPlayersFoundMe(MobController mob, out List<NetPlayer>& players) { }

	[Extension]
	public static bool TryGetPlayersInRange(MobController mob, Vector3 center, float range, out List<NetPlayer>& players) { }

}

