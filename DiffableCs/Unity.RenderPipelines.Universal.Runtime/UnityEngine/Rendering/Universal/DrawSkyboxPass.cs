namespace UnityEngine.Rendering.Universal;

public class DrawSkyboxPass : ScriptableRenderPass
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
		internal DrawSkyboxPass pass; //Field offset: 0x2D8

		public PassData() { }

	}

	public bool m_IsActiveTargetBackBuffer; //Field offset: 0xE0

	public DrawSkyboxPass(RenderPassEvent evt) { }

	private RendererList CreateSkyboxRendererList(ScriptableRenderContext context, CameraData cameraData) { }

	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	internal void Render(RenderGraph renderGraph, TextureHandle colorTarget, TextureHandle depthTarget, ref RenderingData renderingData) { }

}

