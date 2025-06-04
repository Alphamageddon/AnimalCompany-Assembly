namespace AnimalCompany;

public static class SurfaceAssetCache
{
	private static Dictionary<String, SurfaceDefinition> surfaceLookupCache; //Field offset: 0x0

	private static SurfaceAssetCache() { }

	public static void InvalidateCache() { }

	public static bool TryGetSurface(string name, out SurfaceDefinition surface) { }

}

