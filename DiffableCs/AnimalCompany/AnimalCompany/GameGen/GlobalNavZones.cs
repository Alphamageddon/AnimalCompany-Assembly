namespace AnimalCompany.GameGen;

public static class GlobalNavZones
{
	public static Dictionary<Int32, NavZone> zones; //Field offset: 0x0

	private static GlobalNavZones() { }

	public static void DeregisterZones(List<NavZone> newZones) { }

	public static void RegisterZones(List<NavZone> newZones) { }

	public static bool TryGetNavZone(int id, out NavZone zone) { }

}

