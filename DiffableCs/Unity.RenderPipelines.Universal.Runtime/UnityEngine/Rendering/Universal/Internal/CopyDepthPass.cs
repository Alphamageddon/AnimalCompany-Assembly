namespace UnityEngine.Rendering.Universal.Internal;

public class CopyDepthPass : ScriptableRenderPass
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static RenderFunc<PassData> <>9__27_0; //Field offset: 0x8
		public static RenderFunc<PassData> <>9__27_1; //Field offset: 0x10
		public static RenderFunc<PassData> <>9__27_2; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal void <Render>b__27_0(PassData data, RenderGraphContext context) { }

		internal void <Render>b__27_1(PassData data, RenderGraphContext context) { }

		internal void <Render>b__27_2(PassData data, RenderGraphContext context) { }

	}

	private class PassData
	{
		internal TextureHandle source; //Field offset: 0x10
		internal TextureHandle destination; //Field offset: 0x18
		internal CommandBuffer cmd; //Field offset: 0x20
		internal CameraData cameraData; //Field offset: 0x28
		internal Material copyDepthMaterial; //Field offset: 0x238
		internal int msaaSamples; //Field offset: 0x240
		internal bool copyResolvedDepth; //Field offset: 0x244
		internal bool copyToDepth; //Field offset: 0x245

		public PassData() { }

	}

	[CompilerGenerated]
	private RTHandle <source>k__BackingField; //Field offset: 0xE0
	[CompilerGenerated]
	private RTHandle <destination>k__BackingField; //Field offset: 0xE8
	[CompilerGenerated]
	private int <MssaSamples>k__BackingField; //Field offset: 0xF0
	[CompilerGenerated]
	private bool <CopyToDepth>k__BackingField; //Field offset: 0xF4
	private Material m_CopyDepthMaterial; //Field offset: 0xF8
	internal bool m_CopyResolvedDepth; //Field offset: 0x100
	internal bool m_ShouldClear; //Field offset: 0x101
	private PassData m_PassData; //Field offset: 0x108

	internal bool CopyToDepth
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 12
	}

	private RTHandle destination
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	internal int MssaSamples
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	private RTHandle source
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public CopyDepthPass(RenderPassEvent evt, Material copyDepthMaterial, bool shouldClear = false, bool copyToDepth = false, bool copyResolvedDepth = false) { }

	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	private static void ExecutePass(ScriptableRenderContext context, PassData passData, ref CommandBuffer cmd, ref CameraData cameraData, RTHandle source, RTHandle destination) { }

	[CompilerGenerated]
	internal bool get_CopyToDepth() { }

	[CompilerGenerated]
	private RTHandle get_destination() { }

	[CompilerGenerated]
	internal int get_MssaSamples() { }

	[CompilerGenerated]
	private RTHandle get_source() { }

	public virtual void OnCameraCleanup(CommandBuffer cmd) { }

	public virtual void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData) { }

	internal void Render(RenderGraph renderGraph, out TextureHandle destination, in TextureHandle source, ref RenderingData renderingData) { }

	[CompilerGenerated]
	internal void set_CopyToDepth(bool value) { }

	[CompilerGenerated]
	private void set_destination(RTHandle value) { }

	[CompilerGenerated]
	internal void set_MssaSamples(int value) { }

	[CompilerGenerated]
	private void set_source(RTHandle value) { }

	public void Setup(RTHandle source, RTHandle destination) { }

}

