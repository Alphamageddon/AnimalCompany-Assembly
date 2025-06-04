namespace UnityEngine.Rendering.Universal;

internal class DBufferRenderPass : ScriptableRenderPass
{
	private static String[] s_DBufferNames; //Field offset: 0x0
	private static string s_DBufferDepthName; //Field offset: 0x8
	private DecalDrawDBufferSystem m_DrawSystem; //Field offset: 0xE0
	private DBufferSettings m_Settings; //Field offset: 0xE8
	private Material m_DBufferClear; //Field offset: 0xF0
	private FilteringSettings m_FilteringSettings; //Field offset: 0xF8
	private List<ShaderTagId> m_ShaderTagIdList; //Field offset: 0x110
	private ProfilingSampler m_ProfilingSampler; //Field offset: 0x118
	private ProfilingSampler m_DBufferClearSampler; //Field offset: 0x120
	private bool m_DecalLayers; //Field offset: 0x128
	private RTHandle m_DBufferDepth; //Field offset: 0x130
	[CompilerGenerated]
	private RTHandle[] <dBufferColorHandles>k__BackingField; //Field offset: 0x138
	[CompilerGenerated]
	private RTHandle <depthHandle>k__BackingField; //Field offset: 0x140

	internal RTHandle[] dBufferColorHandles
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	internal RTHandle dBufferDepth
	{
		internal get { } //Length: 8
	}

	internal RTHandle depthHandle
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	private static DBufferRenderPass() { }

	public DBufferRenderPass(Material dBufferClear, DBufferSettings settings, DecalDrawDBufferSystem drawSystem, bool decalLayers) { }

	public void Dispose() { }

	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	[CompilerGenerated]
	internal RTHandle[] get_dBufferColorHandles() { }

	internal RTHandle get_dBufferDepth() { }

	[CompilerGenerated]
	internal RTHandle get_depthHandle() { }

	public virtual void OnCameraCleanup(CommandBuffer cmd) { }

	public virtual void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData) { }

	[CompilerGenerated]
	private void set_dBufferColorHandles(RTHandle[] value) { }

	[CompilerGenerated]
	private void set_depthHandle(RTHandle value) { }

	public void Setup(in CameraData cameraData) { }

	public void Setup(in CameraData cameraData, RTHandle depthTextureHandle) { }

}

