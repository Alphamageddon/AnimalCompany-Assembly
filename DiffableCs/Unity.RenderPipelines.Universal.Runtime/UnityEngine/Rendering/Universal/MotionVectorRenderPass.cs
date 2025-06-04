namespace UnityEngine.Rendering.Universal;

internal sealed class MotionVectorRenderPass : ScriptableRenderPass
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static RenderFunc<PassData> <>9__20_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <Render>b__20_0(PassData data, RenderGraphContext context) { }

	}

	private class PassData
	{
		internal TextureHandle motionVectorColor; //Field offset: 0x10
		internal TextureHandle motionVectorDepth; //Field offset: 0x18
		internal TextureHandle cameraDepth; //Field offset: 0x20
		internal RenderingData renderingData; //Field offset: 0x28
		internal Material cameraMaterial; //Field offset: 0x2E0
		internal Material objectMaterial; //Field offset: 0x2E8

		public PassData() { }

	}

	private const string kPreviousViewProjectionNoJitter = "_PrevViewProjMatrix"; //Field offset: 0x0
	private const string kViewProjectionNoJitter = "_NonJitteredViewProjMatrix"; //Field offset: 0x0
	private const string kPreviousViewProjectionNoJitterStereo = "_PrevViewProjMatrixStereo"; //Field offset: 0x0
	private const string kViewProjectionNoJitterStereo = "_NonJitteredViewProjMatrixStereo"; //Field offset: 0x0
	internal const GraphicsFormat k_TargetFormat = 46; //Field offset: 0x0
	private static readonly String[] s_ShaderTags; //Field offset: 0x0
	private RTHandle m_Color; //Field offset: 0xE0
	private RTHandle m_Depth; //Field offset: 0xE8
	private readonly Material m_CameraMaterial; //Field offset: 0xF0
	private readonly Material m_ObjectMaterial; //Field offset: 0xF8
	private PassData m_PassData; //Field offset: 0x100

	private static MotionVectorRenderPass() { }

	internal MotionVectorRenderPass(RenderPassEvent evt, Material cameraMaterial, Material objectMaterial) { }

	public virtual void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor) { }

	private static void DrawCameraMotionVectors(ScriptableRenderContext context, CommandBuffer cmd, ref RenderingData renderingData, Camera camera, Material cameraMaterial) { }

	private static void DrawObjectMotionVectors(ScriptableRenderContext context, ref RenderingData renderingData, Camera camera, Material objectMaterial, CommandBuffer cmd) { }

	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	private static void ExecutePass(ScriptableRenderContext context, PassData passData, ref RenderingData renderingData) { }

	private static DrawingSettings GetDrawingSettings(ref RenderingData renderingData, Material objectMaterial) { }

	internal void Render(RenderGraph renderGraph, ref TextureHandle cameraDepthTexture, in TextureHandle motionVectorColor, in TextureHandle motionVectorDepth, ref RenderingData renderingData) { }

	internal void Setup(RTHandle color, RTHandle depth) { }

}

