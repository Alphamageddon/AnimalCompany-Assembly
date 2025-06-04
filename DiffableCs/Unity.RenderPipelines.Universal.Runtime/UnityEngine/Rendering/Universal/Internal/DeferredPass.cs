namespace UnityEngine.Rendering.Universal.Internal;

internal class DeferredPass : ScriptableRenderPass
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static RenderFunc<PassData> <>9__5_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <Render>b__5_0(PassData data, RenderGraphContext context) { }

	}

	private class PassData
	{
		internal TextureHandle color; //Field offset: 0x10
		internal TextureHandle depth; //Field offset: 0x18
		internal RenderingData renderingData; //Field offset: 0x20
		internal DeferredLights deferredLights; //Field offset: 0x2D8

		public PassData() { }

	}

	private DeferredLights m_DeferredLights; //Field offset: 0xE0

	public DeferredPass(RenderPassEvent evt, DeferredLights deferredLights) { }

	public virtual void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescripor) { }

	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	public virtual void OnCameraCleanup(CommandBuffer cmd) { }

	internal void Render(RenderGraph renderGraph, TextureHandle color, TextureHandle depth, TextureHandle[] gbuffer, ref RenderingData renderingData) { }

}

