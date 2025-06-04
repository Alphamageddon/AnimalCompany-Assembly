//Type is in global namespace

public class FullScreenPassRendererFeature : ScriptableRendererFeature, ISerializationCallbackReceiver
{
	public class FullScreenRenderPass : ScriptableRenderPass
	{
		private static MaterialPropertyBlock s_SharedPropertyBlock; //Field offset: 0x0
		private Material m_Material; //Field offset: 0xE0
		private int m_PassIndex; //Field offset: 0xE8
		private bool m_CopyActiveColor; //Field offset: 0xEC
		private bool m_BindDepthStencilAttachment; //Field offset: 0xED
		private RTHandle m_CopiedColor; //Field offset: 0xF0

		private static FullScreenRenderPass() { }

		public FullScreenRenderPass(string passName) { }

		public void Dispose() { }

		public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

		private static void ExecuteCopyColorPass(CommandBuffer cmd, RTHandle sourceTexture) { }

		private static void ExecuteMainPass(CommandBuffer cmd, RTHandle sourceTexture, Material material, int passIndex) { }

		public virtual void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData) { }

		internal void ReAllocate(RenderTextureDescriptor desc) { }

		public void SetupMembers(Material material, int passIndex, bool copyActiveColor, bool bindDepthStencilAttachment) { }

	}

	internal enum InjectionPoint
	{
		BeforeRenderingTransparents = 450,
		BeforeRenderingPostProcessing = 550,
		AfterRenderingPostProcessing = 600,
	}

	private enum Version
	{
		Uninitialised = -1,
		Initial = 0,
		AddFetchColorBufferCheckbox = 1,
		Count = 2,
		Latest = 1,
	}

	public InjectionPoint injectionPoint; //Field offset: 0x1C
	public bool fetchColorBuffer; //Field offset: 0x20
	public ScriptableRenderPassInput requirements; //Field offset: 0x24
	public Material passMaterial; //Field offset: 0x28
	internal bool showAdditionalProperties; //Field offset: 0x30
	public int passIndex; //Field offset: 0x34
	public bool bindDepthStencilAttachment; //Field offset: 0x38
	private FullScreenRenderPass m_FullScreenPass; //Field offset: 0x40
	[HideInInspector]
	[SerializeField]
	private Version m_Version; //Field offset: 0x48

	public FullScreenPassRendererFeature() { }

	public virtual void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData) { }

	public virtual void Create() { }

	protected virtual void Dispose(bool disposing) { }

	internal virtual bool RequireRenderingLayers(bool isDeferred, bool needsGBufferAccurateNormals, out Event atEvent, out MaskSize maskSize) { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	private void UpgradeIfNeeded() { }

}

