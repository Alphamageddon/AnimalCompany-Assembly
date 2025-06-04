namespace UnityEngine.Rendering.Universal;

internal sealed class TaaPersistentData
{
	private static GraphicsFormat[] formatList; //Field offset: 0x0
	private RenderTextureDescriptor m_RtDesc; //Field offset: 0x10
	private RTHandle m_AccumulationTexture; //Field offset: 0x48
	private RTHandle m_AccumulationTexture2; //Field offset: 0x50
	private int m_LastAccumUpdateFrameIndex; //Field offset: 0x58
	private int m_LastAccumUpdateFrameIndex2; //Field offset: 0x5C

	public RenderTextureDescriptor rtd
	{
		 get { } //Length: 28
	}

	private static TaaPersistentData() { }

	public TaaPersistentData() { }

	[CompilerGenerated]
	internal static GraphicsFormat <Init>g__CheckFormat|12_0(GraphicsFormat format, FormatUsage usage) { }

	[CompilerGenerated]
	internal static GraphicsFormat <Init>g__FindFormat|12_1(FormatUsage usage) { }

	public RTHandle accumulationTexture(int index) { }

	public bool AllocateTargets(bool xrMultipassEnabled = false) { }

	public void DeallocateTargets() { }

	public RenderTextureDescriptor get_rtd() { }

	public int GetLastAccumFrameIndex(int index) { }

	public void Init(int sizeX, int sizeY, int volumeDepth, GraphicsFormat format, VRTextureUsage vrUsage, TextureDimension texDim) { }

	public void SetLastAccumFrameIndex(int index, int value) { }

}

