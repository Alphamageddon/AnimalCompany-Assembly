namespace UnityEngine.Rendering.Universal;

internal class Render2DLightingPass : ScriptableRenderPass, IRenderPass2D
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static DrawFunction <>9__25_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <Render>b__25_0(ScriptableRenderContext ctx, ref RenderingData data, ref DrawingSettings ds, ref FilteringSettings fs, ref RenderStateBlock rsb) { }

	}

	private static readonly int k_HDREmulationScaleID; //Field offset: 0x0
	private static readonly int k_InverseHDREmulationScaleID; //Field offset: 0x4
	private static readonly int k_UseSceneLightingID; //Field offset: 0x8
	private static readonly int k_RendererColorID; //Field offset: 0xC
	private static readonly Int32[] k_ShapeLightTextureIDs; //Field offset: 0x10
	private static readonly ShaderTagId k_CombinedRenderingPassName; //Field offset: 0x18
	private static readonly ShaderTagId k_NormalsRenderingPassName; //Field offset: 0x1C
	private static readonly ShaderTagId k_LegacyPassName; //Field offset: 0x20
	private static readonly List<ShaderTagId> k_ShaderTags; //Field offset: 0x28
	private static readonly ProfilingSampler m_ProfilingDrawLights; //Field offset: 0x30
	private static readonly ProfilingSampler m_ProfilingDrawLightTextures; //Field offset: 0x38
	private static readonly ProfilingSampler m_ProfilingDrawRenderers; //Field offset: 0x40
	private static readonly ProfilingSampler m_ProfilingDrawLayerBatch; //Field offset: 0x48
	private static readonly ProfilingSampler m_ProfilingSamplerUnlit; //Field offset: 0x50
	private Material m_BlitMaterial; //Field offset: 0xE0
	private Material m_SamplingMaterial; //Field offset: 0xE8
	private readonly Renderer2DData m_Renderer2DData; //Field offset: 0xF0
	private bool m_NeedsDepth; //Field offset: 0xF8
	private short m_CameraSortingLayerBoundsIndex; //Field offset: 0xFA

	private override Renderer2DData UnityEngine.Rendering.Universal.IRenderPass2D.rendererData
	{
		private get { } //Length: 8
	}

	private static Render2DLightingPass() { }

	public Render2DLightingPass(Renderer2DData rendererData, Material blitMaterial, Material samplingMaterial) { }

	private void CopyCameraSortingLayerRenderTexture(ScriptableRenderContext context, RenderingData renderingData, RenderBufferStoreAction mainTargetStoreAction) { }

	private void DetermineWhenToResolve(int startIndex, int batchesDrawn, int batchCount, LayerBatch[] layerBatches, out int resolveDuringBatch, out bool resolveIsAfterCopy) { }

	private int DrawLayerBatches(LayerBatch[] layerBatches, int batchCount, int startIndex, CommandBuffer cmd, ScriptableRenderContext context, ref RenderingData renderingData, ref FilteringSettings filterSettings, ref DrawingSettings normalsDrawSettings, ref DrawingSettings drawSettings, ref RenderTextureDescriptor desc) { }

	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	private short GetCameraSortingLayerBoundsIndex() { }

	private void GetTransparencySortingMode(Camera camera, ref SortingSettings sortingSettings) { }

	private void Render(ScriptableRenderContext context, CommandBuffer cmd, ref RenderingData renderingData, ref FilteringSettings filterSettings, DrawingSettings drawSettings) { }

	internal void Setup(bool useDepth) { }

	private override Renderer2DData UnityEngine.Rendering.Universal.IRenderPass2D.get_rendererData() { }

}

