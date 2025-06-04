namespace UnityEngine.Rendering.Universal;

public class XROcclusionMeshPass : ScriptableRenderPass
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static RenderFunc<PassData> <>9__6_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <Render>b__6_0(PassData data, RenderGraphContext context) { }

	}

	private class PassData
	{
		internal RenderingData renderingData; //Field offset: 0x10
		internal TextureHandle cameraColorAttachment; //Field offset: 0x2C8
		internal TextureHandle cameraDepthAttachment; //Field offset: 0x2D0
		internal bool isActiveTargetBackBuffer; //Field offset: 0x2D8

		public PassData() { }

	}

	private PassData m_PassData; //Field offset: 0xE0
	public bool m_IsActiveTargetBackBuffer; //Field offset: 0xE8

	public XROcclusionMeshPass(RenderPassEvent evt) { }

	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	private static void ExecutePass(ScriptableRenderContext context, PassData data) { }

	internal void Render(RenderGraph renderGraph, in TextureHandle cameraColorAttachment, in TextureHandle cameraDepthAttachment, ref RenderingData renderingData) { }

}

