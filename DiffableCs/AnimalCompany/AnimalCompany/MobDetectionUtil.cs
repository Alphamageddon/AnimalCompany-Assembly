namespace AnimalCompany;

[Extension]
public static class MobDetectionUtil
{

	[Extension]
	public static List<NetPlayer> GetPlayersBySight(MobController mob) { }

	[Extension]
	public static List<NetPlayer> GetPlayersInRange(MobController mob, Vector3 center, float range) { }

	public static bool IsTargetInLineOfSight(Vector3 viewPosition, Vector3 targetPosition) { }

	public static bool IsTargetInLineOfSight(Vector3 viewPosition, Vector3 viewToTargetDirection, float viewToTargetDistance) { }

	public static bool TryGetAnyLightBySight(Vector3 viewPoint, Vector3 viewDirection, float viewRange, out Flashlight flashlightOutput) { }

	public static bool TryGetLightsBySight(Vector3 viewPoint, Vector3 viewDirection, float viewRange, out List<Flashlight>& flashlightsOutput) { }

	[Extension]
	public static bool TryGetPlayersBySight(MobController mob, out List<NetPlayer>& players) { }

	[Extension]
	public static bool TryGetPlayersBySound(MobController mob, out List<NetPlayer>& players) { }

	[Extension]
	public static bool TryGetPlayersFoundMe(MobController mob, out List<NetPlayer>& players) { }

	[Extension]
	public static bool TryGetPlayersInRange(MobController mob, Vector3 center, float range, out List<NetPlayer>& players) { }

}

