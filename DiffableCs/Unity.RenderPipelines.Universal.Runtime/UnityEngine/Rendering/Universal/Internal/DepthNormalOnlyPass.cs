namespace UnityEngine.Rendering.Universal.Internal;

public class DepthNormalOnlyPass : ScriptableRenderPass
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static RenderFunc<PassData> <>9__34_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <Render>b__34_0(PassData data, RenderGraphContext context) { }

	}

	private class PassData
	{
		internal TextureHandle cameraDepthTexture; //Field offset: 0x10
		internal TextureHandle cameraNormalsTexture; //Field offset: 0x18
		internal RenderingData renderingData; //Field offset: 0x20
		internal List<ShaderTagId> shaderTagIds; //Field offset: 0x2D8
		internal FilteringSettings filteringSettings; //Field offset: 0x2E0
		internal bool enableRenderingLayers; //Field offset: 0x2F8

		public PassData() { }

	}

	private static readonly List<ShaderTagId> k_DepthNormals; //Field offset: 0x0
	private static readonly RTHandle[] k_ColorAttachment1; //Field offset: 0x8
	private static readonly RTHandle[] k_ColorAttachment2; //Field offset: 0x10
	[CompilerGenerated]
	private List<ShaderTagId> <shaderTagIds>k__BackingField; //Field offset: 0xE0
	[CompilerGenerated]
	private RTHandle <depthHandle>k__BackingField; //Field offset: 0xE8
	[CompilerGenerated]
	private RTHandle <normalHandle>k__BackingField; //Field offset: 0xF0
	[CompilerGenerated]
	private RTHandle <renderingLayersHandle>k__BackingField; //Field offset: 0xF8
	[CompilerGenerated]
	private bool <enableRenderingLayers>k__BackingField; //Field offset: 0x100
	private FilteringSettings m_FilteringSettings; //Field offset: 0x104
	private PassData m_PassData; //Field offset: 0x120

	private RTHandle depthHandle
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	internal bool enableRenderingLayers
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 12
	}

	private RTHandle normalHandle
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	private RTHandle renderingLayersHandle
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	internal List<ShaderTagId> shaderTagIds
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	private static DepthNormalOnlyPass() { }

	public DepthNormalOnlyPass(RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask) { }

	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	private static void ExecutePass(ScriptableRenderContext context, PassData passData, ref RenderingData renderingData) { }

	[CompilerGenerated]
	private RTHandle get_depthHandle() { }

	[CompilerGenerated]
	internal bool get_enableRenderingLayers() { }

	[CompilerGenerated]
	private RTHandle get_normalHandle() { }

	[CompilerGenerated]
	private RTHandle get_renderingLayersHandle() { }

	[CompilerGenerated]
	internal List<ShaderTagId> get_shaderTagIds() { }

	public static GraphicsFormat GetGraphicsFormat() { }

	public virtual void OnCameraCleanup(CommandBuffer cmd) { }

	public virtual void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData) { }

	internal void Render(RenderGraph renderGraph, out TextureHandle cameraNormalsTexture, out TextureHandle cameraDepthTexture, ref RenderingData renderingData) { }

	[CompilerGenerated]
	private void set_depthHandle(RTHandle value) { }

	[CompilerGenerated]
	internal void set_enableRenderingLayers(bool value) { }

	[CompilerGenerated]
	private void set_normalHandle(RTHandle value) { }

	[CompilerGenerated]
	private void set_renderingLayersHandle(RTHandle value) { }

	[CompilerGenerated]
	internal void set_shaderTagIds(List<ShaderTagId> value) { }

	public void Setup(RTHandle depthHandle, RTHandle normalHandle) { }

	public void Setup(RTHandle depthHandle, RTHandle normalHandle, RTHandle decalLayerHandle) { }

}

