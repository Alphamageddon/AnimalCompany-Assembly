namespace Unity.XR.CoreUtils;

[Extension]
public static class GameObjectExtensions
{

	[Extension]
	public static void AddToHideFlagsRecursively(GameObject gameObject, HideFlags hideFlags) { }

	[Extension]
	public static void SetHideFlagsRecursively(GameObject gameObject, HideFlags hideFlags) { }

	[Extension]
	public static void SetLayerAndAddToHideFlagsRecursively(GameObject gameObject, int layer, HideFlags hideFlags) { }

	[Extension]
	public static void SetLayerAndHideFlagsRecursively(GameObject gameObject, int layer, HideFlags hideFlags) { }

	[Extension]
	public static void SetLayerRecursively(GameObject gameObject, int layer) { }

	[Extension]
	public static void SetRunInEditModeRecursively(GameObject gameObject, bool enabled) { }

}

