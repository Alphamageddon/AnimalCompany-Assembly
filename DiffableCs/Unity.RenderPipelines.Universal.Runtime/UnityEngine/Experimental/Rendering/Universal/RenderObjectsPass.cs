namespace UnityEngine.Experimental.Rendering.Universal;

public class RenderObjectsPass : ScriptableRenderPass
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static DrawFunction <>9__27_0; //Field offset: 0x8
		public static RenderFunc<PassData> <>9__29_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal void <Execute>b__27_0(ScriptableRenderContext ctx, ref RenderingData data, ref DrawingSettings ds, ref FilteringSettings fs, ref RenderStateBlock rsb) { }

		internal void <RecordRenderGraph>b__29_0(PassData data, RenderGraphContext rgContext) { }

	}

	private class PassData
	{
		internal RenderObjectsPass pass; //Field offset: 0x10
		internal RenderingData renderingData; //Field offset: 0x18

		public PassData() { }

	}

	private RenderQueueType renderQueueType; //Field offset: 0xE0
	private FilteringSettings m_FilteringSettings; //Field offset: 0xE4
	private CustomCameraSettings m_CameraSettings; //Field offset: 0x100
	private string m_ProfilerTag; //Field offset: 0x108
	private ProfilingSampler m_ProfilingSampler; //Field offset: 0x110
	[CompilerGenerated]
	private Material <overrideMaterial>k__BackingField; //Field offset: 0x118
	[CompilerGenerated]
	private int <overrideMaterialPassIndex>k__BackingField; //Field offset: 0x120
	[CompilerGenerated]
	private Shader <overrideShader>k__BackingField; //Field offset: 0x128
	[CompilerGenerated]
	private int <overrideShaderPassIndex>k__BackingField; //Field offset: 0x130
	private List<ShaderTagId> m_ShaderTagIdList; //Field offset: 0x138
	private RenderStateBlock m_RenderStateBlock; //Field offset: 0x140

	public Material overrideMaterial
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public int overrideMaterialPassIndex
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public Shader overrideShader
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public int overrideShaderPassIndex
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public RenderObjectsPass(string profilerTag, RenderPassEvent renderPassEvent, String[] shaderTags, RenderQueueType renderQueueType, int layerMask, CustomCameraSettings cameraSettings) { }

	internal RenderObjectsPass(URPProfileId profileId, RenderPassEvent renderPassEvent, String[] shaderTags, RenderQueueType renderQueueType, int layerMask, CustomCameraSettings cameraSettings) { }

	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	[CompilerGenerated]
	public Material get_overrideMaterial() { }

	[CompilerGenerated]
	public int get_overrideMaterialPassIndex() { }

	[CompilerGenerated]
	public Shader get_overrideShader() { }

	[CompilerGenerated]
	public int get_overrideShaderPassIndex() { }

	internal virtual void RecordRenderGraph(RenderGraph renderGraph, ref RenderingData renderingData) { }

	[CompilerGenerated]
	public void set_overrideMaterial(Material value) { }

	[CompilerGenerated]
	public void set_overrideMaterialPassIndex(int value) { }

	[CompilerGenerated]
	public void set_overrideShader(Shader value) { }

	[CompilerGenerated]
	public void set_overrideShaderPassIndex(int value) { }

	public void SetDetphState(bool writeEnabled, CompareFunction function = 2) { }

	public void SetStencilState(int reference, CompareFunction compareFunction, StencilOp passOp, StencilOp failOp, StencilOp zFailOp) { }

}

