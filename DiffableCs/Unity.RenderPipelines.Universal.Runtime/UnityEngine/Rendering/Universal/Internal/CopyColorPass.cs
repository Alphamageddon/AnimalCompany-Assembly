namespace UnityEngine.Rendering.Universal.Internal;

public class CopyColorPass : ScriptableRenderPass
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static RenderFunc<PassData> <>9__25_0; //Field offset: 0x8
		public static RenderFunc<PassData> <>9__25_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal void <Render>b__25_0(PassData data, RenderGraphContext context) { }

		internal void <Render>b__25_1(PassData data, RenderGraphContext context) { }

	}

	private class PassData
	{
		internal TextureHandle source; //Field offset: 0x10
		internal TextureHandle destination; //Field offset: 0x18
		internal bool useProceduralBlit; //Field offset: 0x20
		internal bool disableFoveatedRenderingForPass; //Field offset: 0x21
		internal CommandBuffer cmd; //Field offset: 0x28
		internal Material samplingMaterial; //Field offset: 0x30
		internal Material copyColorMaterial; //Field offset: 0x38
		internal Downsampling downsamplingMethod; //Field offset: 0x40
		internal ClearFlag clearFlag; //Field offset: 0x44
		internal Color clearColor; //Field offset: 0x48
		internal int sampleOffsetShaderHandle; //Field offset: 0x58

		public PassData() { }

	}

	private int m_SampleOffsetShaderHandle; //Field offset: 0xE0
	private Material m_SamplingMaterial; //Field offset: 0xE8
	private Downsampling m_DownsamplingMethod; //Field offset: 0xF0
	private Material m_CopyColorMaterial; //Field offset: 0xF8
	[CompilerGenerated]
	private RTHandle <source>k__BackingField; //Field offset: 0x100
	[CompilerGenerated]
	private RTHandle <destination>k__BackingField; //Field offset: 0x108
	[CompilerGenerated]
	private int <destinationID>k__BackingField; //Field offset: 0x110
	private PassData m_PassData; //Field offset: 0x118

	private RTHandle destination
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	private int destinationID
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	private RTHandle source
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public CopyColorPass(RenderPassEvent evt, Material samplingMaterial, Material copyColorMaterial = null) { }

	public static void ConfigureDescriptor(Downsampling downsamplingMethod, ref RenderTextureDescriptor descriptor, out FilterMode filterMode) { }

	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	private static void ExecutePass(PassData passData, RTHandle source, RTHandle destination, ref CommandBuffer cmd, bool useDrawProceduralBlit, bool disableFoveatedRenderingForPass) { }

	[CompilerGenerated]
	private RTHandle get_destination() { }

	[CompilerGenerated]
	private int get_destinationID() { }

	[CompilerGenerated]
	private RTHandle get_source() { }

	public virtual void OnCameraCleanup(CommandBuffer cmd) { }

	public virtual void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData) { }

	internal TextureHandle Render(RenderGraph renderGraph, out TextureHandle destination, in TextureHandle source, Downsampling downsampling, ref RenderingData renderingData) { }

	[CompilerGenerated]
	private void set_destination(RTHandle value) { }

	[CompilerGenerated]
	private void set_destinationID(int value) { }

	[CompilerGenerated]
	private void set_source(RTHandle value) { }

	[Obsolete("Use RTHandles for source and destination.")]
	public void Setup(RenderTargetIdentifier source, RenderTargetHandle destination, Downsampling downsampling) { }

	public void Setup(RTHandle source, RTHandle destination, Downsampling downsampling) { }

}

