namespace UnityEngine.Rendering.Universal;

public static class TemporalAA
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static RenderFunc<TaaPassData> <>9__11_0; //Field offset: 0x8
		public static RenderFunc<TaaPassData> <>9__11_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal void <Render>b__11_0(TaaPassData data, RenderGraphContext context) { }

		internal void <Render>b__11_1(TaaPassData data, RenderGraphContext context) { }

	}

	internal struct Settings
	{
		[FormerlySerializedAs("quality")]
		[SerializeField]
		internal TemporalAAQuality m_Quality; //Field offset: 0x0
		[FormerlySerializedAs("frameInfluence")]
		[SerializeField]
		internal float m_FrameInfluence; //Field offset: 0x4
		[FormerlySerializedAs("jitterScale")]
		[SerializeField]
		internal float m_JitterScale; //Field offset: 0x8
		[FormerlySerializedAs("mipBias")]
		[SerializeField]
		internal float m_MipBias; //Field offset: 0xC
		[FormerlySerializedAs("varianceClampScale")]
		[SerializeField]
		internal float m_VarianceClampScale; //Field offset: 0x10
		[FormerlySerializedAs("contrastAdaptiveSharpening")]
		[SerializeField]
		internal float m_ContrastAdaptiveSharpening; //Field offset: 0x14
		internal int resetHistoryFrames; //Field offset: 0x18
		internal int jitterFrameCountOffset; //Field offset: 0x1C

		public float baseBlendFactor
		{
			 get { } //Length: 16
			 set { } //Length: 32
		}

		public float contrastAdaptiveSharpening
		{
			 get { } //Length: 8
			 set { } //Length: 28
		}

		public float jitterScale
		{
			 get { } //Length: 8
			 set { } //Length: 28
		}

		public float mipBias
		{
			 get { } //Length: 8
			 set { } //Length: 28
		}

		public TemporalAAQuality quality
		{
			 get { } //Length: 8
			 set { } //Length: 24
		}

		public float varianceClampScale
		{
			 get { } //Length: 8
			 set { } //Length: 32
		}

		public static Settings Create() { }

		public float get_baseBlendFactor() { }

		public float get_contrastAdaptiveSharpening() { }

		public float get_jitterScale() { }

		public float get_mipBias() { }

		public TemporalAAQuality get_quality() { }

		public float get_varianceClampScale() { }

		public void set_baseBlendFactor(float value) { }

		public void set_contrastAdaptiveSharpening(float value) { }

		public void set_jitterScale(float value) { }

		public void set_mipBias(float value) { }

		public void set_quality(TemporalAAQuality value) { }

		public void set_varianceClampScale(float value) { }

	}

	public static class ShaderConstants
	{
		public static readonly int _TaaAccumulationTex; //Field offset: 0x0
		public static readonly int _TaaMotionVectorTex; //Field offset: 0x4
		public static readonly int _TaaFilterWeights; //Field offset: 0x8
		public static readonly int _TaaFrameInfluence; //Field offset: 0xC
		public static readonly int _TaaVarianceClampScale; //Field offset: 0x10
		public static readonly int _CameraDepthTexture; //Field offset: 0x14

		private static ShaderConstants() { }

	}

	public static class ShaderKeywords
	{
		public static readonly string TAA_LOW_PRECISION_SOURCE; //Field offset: 0x0

		private static ShaderKeywords() { }

	}

	private class TaaPassData
	{
		internal TextureHandle dstTex; //Field offset: 0x10
		internal TextureHandle srcColorTex; //Field offset: 0x18
		internal TextureHandle srcDepthTex; //Field offset: 0x20
		internal TextureHandle srcMotionVectorTex; //Field offset: 0x28
		internal TextureHandle srcTaaAccumTex; //Field offset: 0x30
		internal Material material; //Field offset: 0x38
		internal int passIndex; //Field offset: 0x40
		internal float taaFrameInfluence; //Field offset: 0x44
		internal float taaVarianceClampScale; //Field offset: 0x48
		internal Single[] taaFilterWeights; //Field offset: 0x50
		internal bool taaLowPrecisionSource; //Field offset: 0x58

		public TaaPassData() { }

	}

	private static readonly Vector2[] taaFilterOffsets; //Field offset: 0x0
	private static readonly Single[] taaFilterWeights; //Field offset: 0x8

	private static TemporalAA() { }

	internal static Single[] CalculateFilterWeights(float jitterScale) { }

	internal static Vector2 CalculateJitter(int frameIndex) { }

	internal static Matrix4x4 CalculateJitterMatrix(ref CameraData cameraData) { }

	internal static void ExecutePass(CommandBuffer cmd, Material taaMaterial, ref CameraData cameraData, RTHandle source, RTHandle destination, RenderTexture motionVectors) { }

	internal static void Render(RenderGraph renderGraph, Material taaMaterial, ref CameraData cameraData, ref TextureHandle srcColor, ref TextureHandle srcDepth, ref TextureHandle srcMotionVectors, ref TextureHandle dstColor) { }

	internal static string ValidateAndWarn(ref CameraData cameraData) { }

}

