namespace UnityEngine.Rendering.Universal;

internal static class Light2DManager
{
	private static SortingLayer[] s_SortingLayers; //Field offset: 0x0
	[CompilerGenerated]
	private static readonly List<Light2D> <lights>k__BackingField; //Field offset: 0x8

	public static List<Light2D> lights
	{
		[CompilerGenerated]
		 get { } //Length: 88
	}

	private static Light2DManager() { }

	private static bool ContainsDuplicateGlobalLight(int sortingLayerIndex, int blendStyleIndex) { }

	public static void DeregisterLight(Light2D light) { }

	public static void ErrorIfDuplicateGlobalLight(Light2D light) { }

	[CompilerGenerated]
	public static List<Light2D> get_lights() { }

	public static SortingLayer[] GetCachedSortingLayer() { }

	public static bool GetGlobalColor(int sortingLayerIndex, int blendStyleIndex, out Color color) { }

	public static void RegisterLight(Light2D light) { }

}

