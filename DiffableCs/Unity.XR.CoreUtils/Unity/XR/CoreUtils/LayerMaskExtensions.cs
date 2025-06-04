namespace Unity.XR.CoreUtils;

[Extension]
public static class LayerMaskExtensions
{

	[Extension]
	public static bool Contains(LayerMask mask, int layer) { }

	[Extension]
	public static int GetFirstLayerIndex(LayerMask layerMask) { }

}

