namespace UnityEngine.Rendering.Universal;

internal class DrawScreenSpaceUIPass : ScriptableRenderPass
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static RenderFunc<PassData> <>9__12_0; //Field offset: 0x8
		public static RenderFunc<PassData> <>9__13_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal void <RenderOffscreen>b__12_0(PassData data, RenderGraphContext context) { }

		internal void <RenderOverlay>b__13_0(PassData data, RenderGraphContext context) { }

	}

	private class PassData
	{
		internal CommandBuffer cmd; //Field offset: 0x10
		internal Camera camera; //Field offset: 0x18
		internal TextureHandle offscreenTexture; //Field offset: 0x20

		public PassData() { }

	}

	private PassData m_PassData; //Field offset: 0xE0
	private RTHandle m_ColorTarget; //Field offset: 0xE8
	private RTHandle m_DepthTarget; //Field offset: 0xF0
	private bool m_RenderOffscreen; //Field offset: 0xF8

	public DrawScreenSpaceUIPass(RenderPassEvent evt, bool renderOffscreen) { }

	public static void ConfigureColorDescriptor(ref RenderTextureDescriptor descriptor, int cameraWidth, int cameraHeight) { }

	public static void ConfigureDepthDescriptor(ref RenderTextureDescriptor descriptor, int depthBufferBits, int cameraWidth, int cameraHeight) { }

	public void Dispose() { }

	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	private static void ExecutePass(ScriptableRenderContext context, PassData passData) { }

	internal void RenderOffscreen(RenderGraph renderGraph, int depthBufferBits, out TextureHandle output, ref RenderingData renderingData) { }

	internal void RenderOverlay(RenderGraph renderGraph, in TextureHandle colorBuffer, in TextureHandle depthBuffer, ref RenderingData renderingData) { }

	public void Setup(ref CameraData cameraData, int depthBufferBits) { }

}

