namespace UnityEngine.Rendering.Universal.Internal;

internal class GBufferPass : ScriptableRenderPass
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static RenderFunc<PassData> <>9__20_0; //Field offset: 0x8
		public static RenderFunc<PassData> <>9__20_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal void <Render>b__20_0(PassData data, RenderGraphContext context) { }

		internal void <Render>b__20_1(PassData data, RenderGraphContext context) { }

	}

	private class PassData
	{
		internal TextureHandle[] gbuffer; //Field offset: 0x10
		internal TextureHandle depth; //Field offset: 0x18
		internal RenderingData renderingData; //Field offset: 0x20
		internal DeferredLights deferredLights; //Field offset: 0x2D8
		internal FilteringSettings filteringSettings; //Field offset: 0x2E0
		internal DrawingSettings drawingSettings; //Field offset: 0x2F8

		public PassData() { }

	}

	private static readonly int s_CameraNormalsTextureID; //Field offset: 0x0
	private static ShaderTagId s_ShaderTagLit; //Field offset: 0x4
	private static ShaderTagId s_ShaderTagSimpleLit; //Field offset: 0x8
	private static ShaderTagId s_ShaderTagUnlit; //Field offset: 0xC
	private static ShaderTagId s_ShaderTagComplexLit; //Field offset: 0x10
	private static ShaderTagId s_ShaderTagUniversalGBuffer; //Field offset: 0x14
	private static ShaderTagId s_ShaderTagUniversalMaterialType; //Field offset: 0x18
	private static ShaderTagId[] s_ShaderTagValues; //Field offset: 0x20
	private static RenderStateBlock[] s_RenderStateBlocks; //Field offset: 0x28
	private ProfilingSampler m_ProfilingSampler; //Field offset: 0xE0
	private DeferredLights m_DeferredLights; //Field offset: 0xE8
	private FilteringSettings m_FilteringSettings; //Field offset: 0xF0
	private RenderStateBlock m_RenderStateBlock; //Field offset: 0x108
	private PassData m_PassData; //Field offset: 0x178

	private static GBufferPass() { }

	public GBufferPass(RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask, StencilState stencilState, int stencilReference, DeferredLights deferredLights) { }

	public virtual void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor) { }

	public void Dispose() { }

	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	private static void ExecutePass(ScriptableRenderContext context, PassData data, ref RenderingData renderingData, bool useRenderGraph = false) { }

	internal void Render(RenderGraph renderGraph, TextureHandle cameraColor, TextureHandle cameraDepth, ref RenderingData renderingData, ref RenderGraphFrameResources frameResources) { }

}

