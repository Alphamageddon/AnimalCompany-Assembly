namespace UnityEngine.Rendering.Universal.Internal;

public class DepthOnlyPass : ScriptableRenderPass
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static RenderFunc<PassData> <>9__18_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <Render>b__18_0(PassData data, RenderGraphContext context) { }

	}

	private class PassData
	{
		internal TextureHandle cameraDepthTexture; //Field offset: 0x10
		internal RenderingData renderingData; //Field offset: 0x18
		internal ShaderTagId shaderTagId; //Field offset: 0x2D0
		internal FilteringSettings filteringSettings; //Field offset: 0x2D4

		public PassData() { }

	}

	private static readonly ShaderTagId k_ShaderTagId; //Field offset: 0x0
	[CompilerGenerated]
	private RTHandle <destination>k__BackingField; //Field offset: 0xE0
	private GraphicsFormat depthStencilFormat; //Field offset: 0xE8
	[CompilerGenerated]
	private ShaderTagId <shaderTagId>k__BackingField; //Field offset: 0xEC
	private PassData m_PassData; //Field offset: 0xF0
	private FilteringSettings m_FilteringSettings; //Field offset: 0xF8

	private RTHandle destination
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	internal ShaderTagId shaderTagId
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	private static DepthOnlyPass() { }

	public DepthOnlyPass(RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask) { }

	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	private static void ExecutePass(ScriptableRenderContext context, PassData passData, ref RenderingData renderingData) { }

	[CompilerGenerated]
	private RTHandle get_destination() { }

	[CompilerGenerated]
	internal ShaderTagId get_shaderTagId() { }

	public virtual void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData) { }

	internal void Render(RenderGraph renderGraph, out TextureHandle cameraDepthTexture, ref RenderingData renderingData) { }

	[CompilerGenerated]
	private void set_destination(RTHandle value) { }

	[CompilerGenerated]
	internal void set_shaderTagId(ShaderTagId value) { }

	public void Setup(RenderTextureDescriptor baseDescriptor, RTHandle depthAttachmentHandle) { }

}

