namespace UnityEngine.Rendering.Universal.Internal;

public class DrawObjectsPass : ScriptableRenderPass
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static DrawFunction <>9__16_0; //Field offset: 0x8
		public static RenderFunc<PassData> <>9__18_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal void <ExecutePass>b__16_0(ScriptableRenderContext ctx, ref RenderingData data, ref DrawingSettings ds, ref FilteringSettings fs, ref RenderStateBlock rsb) { }

		internal void <Render>b__18_0(PassData data, RenderGraphContext context) { }

	}

	private class PassData
	{
		internal TextureHandle m_Albedo; //Field offset: 0x10
		internal TextureHandle m_Depth; //Field offset: 0x18
		internal RenderingData m_RenderingData; //Field offset: 0x20
		internal bool m_IsOpaque; //Field offset: 0x2D8
		internal RenderStateBlock m_RenderStateBlock; //Field offset: 0x2DC
		internal FilteringSettings m_FilteringSettings; //Field offset: 0x348
		internal List<ShaderTagId> m_ShaderTagIdList; //Field offset: 0x360
		internal ProfilingSampler m_ProfilingSampler; //Field offset: 0x368
		internal bool m_ShouldTransparentsReceiveShadows; //Field offset: 0x370
		internal bool m_IsActiveTargetBackBuffer; //Field offset: 0x371
		internal DrawObjectsPass pass; //Field offset: 0x378

		public PassData() { }

	}

	private static readonly int s_DrawObjectPassDataPropID; //Field offset: 0x0
	private FilteringSettings m_FilteringSettings; //Field offset: 0xE0
	private RenderStateBlock m_RenderStateBlock; //Field offset: 0xF8
	private List<ShaderTagId> m_ShaderTagIdList; //Field offset: 0x168
	private string m_ProfilerTag; //Field offset: 0x170
	private ProfilingSampler m_ProfilingSampler; //Field offset: 0x178
	private bool m_IsOpaque; //Field offset: 0x180
	public bool m_IsActiveTargetBackBuffer; //Field offset: 0x181
	public bool m_ShouldTransparentsReceiveShadows; //Field offset: 0x182
	private PassData m_PassData; //Field offset: 0x188
	private bool m_UseDepthPriming; //Field offset: 0x190

	private static DrawObjectsPass() { }

	public DrawObjectsPass(string profilerTag, ShaderTagId[] shaderTagIds, bool opaque, RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask, StencilState stencilState, int stencilReference) { }

	public DrawObjectsPass(string profilerTag, bool opaque, RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask, StencilState stencilState, int stencilReference) { }

	internal DrawObjectsPass(URPProfileId profileId, bool opaque, RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask, StencilState stencilState, int stencilReference) { }

	private static void CameraSetup(CommandBuffer cmd, PassData data, ref RenderingData renderingData) { }

	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	private static void ExecutePass(ScriptableRenderContext context, PassData data, ref RenderingData renderingData, bool yFlip) { }

	protected override void OnExecute(CommandBuffer cmd) { }

	internal void Render(RenderGraph renderGraph, TextureHandle colorTarget, TextureHandle depthTarget, TextureHandle mainShadowsTexture, TextureHandle additionalShadowsTexture, ref RenderingData renderingData) { }

}

