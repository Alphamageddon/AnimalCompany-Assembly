namespace UnityEngine.Rendering.Universal;

internal static class LayerUtility
{
	private static LayerBatch[] s_LayerBatches; //Field offset: 0x0
	[CompilerGenerated]
	private static uint <maxTextureCount>k__BackingField; //Field offset: 0x8

	public private static uint maxTextureCount
	{
		[CompilerGenerated]
		 get { } //Length: 72
		[CompilerGenerated]
		private set { } //Length: 76
	}

	public static LayerBatch[] CalculateBatches(ILight2DCullResult lightCullResult, out int batchCount) { }

	private static bool CanBatchLightsInLayer(int layerIndex1, int layerIndex2, SortingLayer[] sortingLayers, ILight2DCullResult lightCullResult) { }

	private static int FindUpperBoundInBatch(int startLayerIndex, SortingLayer[] sortingLayers, ILight2DCullResult lightCullResult) { }

	[CompilerGenerated]
	public static uint get_maxTextureCount() { }

	private static void InitializeBatchInfos(SortingLayer[] cachedSortingLayers) { }

	public static void InitializeBudget(uint maxTextureCount) { }

	[CompilerGenerated]
	private static void set_maxTextureCount(uint value) { }

}

