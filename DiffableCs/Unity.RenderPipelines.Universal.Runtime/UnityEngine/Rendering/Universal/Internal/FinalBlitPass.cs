namespace UnityEngine.Rendering.Universal.Internal;

public class FinalBlitPass : ScriptableRenderPass
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static RenderFunc<PassData> <>9__16_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <Render>b__16_0(PassData data, RenderGraphContext context) { }

	}

	private struct BlitMaterialData
	{
		public Material material; //Field offset: 0x0
		public int nearestSamplerPass; //Field offset: 0x8
		public int bilinearSamplerPass; //Field offset: 0xC

	}

	private static class BlitPassNames
	{
		public const string NearestSampler = "NearestDebugDraw"; //Field offset: 0x0
		public const string BilinearSampler = "BilinearDebugDraw"; //Field offset: 0x0

	}

	private enum BlitType
	{
		Core = 0,
		HDR = 1,
		Count = 2,
	}

	private class PassData
	{
		internal TextureHandle source; //Field offset: 0x10
		internal TextureHandle destination; //Field offset: 0x18
		internal int sourceID; //Field offset: 0x20
		internal Vector4 hdrOutputLuminanceParams; //Field offset: 0x24
		internal bool requireSrgbConversion; //Field offset: 0x34
		internal BlitMaterialData blitMaterialData; //Field offset: 0x38
		internal RenderingData renderingData; //Field offset: 0x48

		public PassData() { }

	}

	private RTHandle m_Source; //Field offset: 0xE0
	private PassData m_PassData; //Field offset: 0xE8
	private BlitMaterialData[] m_BlitMaterialData; //Field offset: 0xF0

	public FinalBlitPass(RenderPassEvent evt, Material blitMaterial, Material blitHDRMaterial) { }

	public void Dispose() { }

	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	private static void ExecutePass(ref RenderingData renderingData, in BlitMaterialData blitMaterialData, RTHandle cameraTarget, RTHandle source) { }

	private void InitPassData(ref RenderingData renderingData, ref PassData passData, BlitType blitType) { }

	public virtual void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData) { }

	internal void Render(RenderGraph renderGraph, ref RenderingData renderingData, TextureHandle src, TextureHandle dest, TextureHandle overlayUITexture) { }

	[Obsolete("Use RTHandles for colorHandle")]
	public void Setup(RenderTextureDescriptor baseDescriptor, RenderTargetHandle colorHandle) { }

	public void Setup(RenderTextureDescriptor baseDescriptor, RTHandle colorHandle) { }

	private static void SetupHDROutput(ColorGamut hdrDisplayColorGamut, Material material, Operation hdrOperation, Vector4 hdrOutputParameters) { }

}

