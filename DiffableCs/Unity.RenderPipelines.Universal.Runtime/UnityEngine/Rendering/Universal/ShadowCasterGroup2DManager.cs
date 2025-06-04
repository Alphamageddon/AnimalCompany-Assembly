namespace UnityEngine.Rendering.Universal;

internal class ShadowCasterGroup2DManager
{
	private static List<ShadowCasterGroup2D> s_ShadowCasterGroups; //Field offset: 0x0

	public static List<ShadowCasterGroup2D> shadowCasterGroups
	{
		 get { } //Length: 72
	}

	public ShadowCasterGroup2DManager() { }

	public static void AddGroup(ShadowCasterGroup2D group) { }

	public static void AddShadowCasterGroupToList(ShadowCasterGroup2D shadowCaster, List<ShadowCasterGroup2D> list) { }

	public static bool AddToShadowCasterGroup(ShadowCaster2D shadowCaster, ref ShadowCasterGroup2D shadowCasterGroup) { }

	public static void CacheValues() { }

	private static CompositeShadowCaster2D FindTopMostCompositeShadowCaster(ShadowCaster2D shadowCaster) { }

	public static List<ShadowCasterGroup2D> get_shadowCasterGroups() { }

	public static void RemoveFromShadowCasterGroup(ShadowCaster2D shadowCaster, ShadowCasterGroup2D shadowCasterGroup) { }

	public static void RemoveGroup(ShadowCasterGroup2D group) { }

	public static void RemoveShadowCasterGroupFromList(ShadowCasterGroup2D shadowCaster, List<ShadowCasterGroup2D> list) { }

}

