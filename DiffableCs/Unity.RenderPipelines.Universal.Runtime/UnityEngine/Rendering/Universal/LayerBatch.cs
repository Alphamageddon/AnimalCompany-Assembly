namespace UnityEngine.Rendering.Universal;

internal struct LayerBatch
{
	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <renderTargetIds>e__FixedBuffer
	{
		public int FixedElementField; //Field offset: 0x0

	}

	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <renderTargetUsed>e__FixedBuffer
	{
		public bool FixedElementField; //Field offset: 0x0

	}

	public int startLayerID; //Field offset: 0x0
	public int endLayerValue; //Field offset: 0x4
	public SortingLayerRange layerRange; //Field offset: 0x8
	public LightStats lightStats; //Field offset: 0xC
	[FixedBuffer(typeof(int, 4)]
	private <renderTargetIds>e__FixedBuffer renderTargetIds; //Field offset: 0x20
	[FixedBuffer(typeof(bool, 4)]
	private <renderTargetUsed>e__FixedBuffer renderTargetUsed; //Field offset: 0x30

	public RenderTargetIdentifier GetRTId(CommandBuffer cmd, RenderTextureDescriptor desc, int index) { }

	public void InitRTIds(int index) { }

	public void ReleaseRT(CommandBuffer cmd) { }

}

