namespace UnityEngine.Experimental.Rendering.RenderGraphModule;

internal class RenderGraphResourceRegistry
{
	private class RenderGraphResourcesData
	{
		public DynamicArray<IRenderGraphResource> resourceArray; //Field offset: 0x10
		public int sharedResourcesCount; //Field offset: 0x18
		public IRenderGraphResourcePool pool; //Field offset: 0x20
		public ResourceCallback createResourceCallback; //Field offset: 0x28
		public ResourceCallback releaseResourceCallback; //Field offset: 0x30

		public RenderGraphResourcesData() { }

		public int AddNewRenderGraphResource(out ResType outRes, bool pooledResource = true) { }

		public void Cleanup() { }

		public void Clear(bool onException, int frameIndex) { }

		public void PurgeUnusedGraphicsResources(int frameIndex) { }

	}

	private sealed class ResourceCallback : MulticastDelegate
	{

		public ResourceCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(RenderGraphContext rgContext, IRenderGraphResource res, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(RenderGraphContext rgContext, IRenderGraphResource res) { }

	}

	private const int kSharedResourceLifetime = 30; //Field offset: 0x0
	private static RenderGraphResourceRegistry m_CurrentRegistry; //Field offset: 0x0
	private const int kInitialRendererListCount = 256; //Field offset: 0x0
	private RenderGraphResourcesData[] m_RenderGraphResources; //Field offset: 0x10
	private DynamicArray<RendererListResource> m_RendererListResources; //Field offset: 0x18
	private RenderGraphDebugParams m_RenderGraphDebug; //Field offset: 0x20
	private RenderGraphLogger m_ResourceLogger; //Field offset: 0x28
	private RenderGraphLogger m_FrameInformationLogger; //Field offset: 0x30
	private int m_CurrentFrameIndex; //Field offset: 0x38
	private int m_ExecutionCount; //Field offset: 0x3C
	private RTHandle m_CurrentBackbuffer; //Field offset: 0x40
	private List<RendererList> m_ActiveRendererLists; //Field offset: 0x48

	internal static RenderGraphResourceRegistry current
	{
		internal get { } //Length: 72
		internal set { } //Length: 76
	}

	private RenderGraphResourceRegistry() { }

	internal RenderGraphResourceRegistry(RenderGraphDebugParams renderGraphDebug, RenderGraphLogger frameInformationLogger) { }

	internal void BeginExecute(int currentFrameIndex) { }

	internal void BeginRenderGraph(int executionCount) { }

	private void CheckHandleValidity(in ResourceHandle res) { }

	private void CheckHandleValidity(RenderGraphResourceType type, int index) { }

	internal void Cleanup() { }

	internal void Clear(bool onException) { }

	internal ComputeBufferHandle CreateComputeBuffer(in ComputeBufferDesc desc, int transientPassIndex = -1) { }

	internal void CreatePooledResource(RenderGraphContext rgContext, ResourceHandle handle) { }

	internal void CreatePooledResource(RenderGraphContext rgContext, int type, int index) { }

	internal RendererListHandle CreateRendererList(in RendererListDesc desc) { }

	internal void CreateRendererLists(List<RendererListHandle> rendererLists, ScriptableRenderContext context, bool manualDispatch = false) { }

	internal TextureHandle CreateSharedTexture(in TextureDesc desc, bool explicitRelease) { }

	internal TextureHandle CreateTexture(in TextureDesc desc, int transientPassIndex = -1) { }

	private void CreateTextureCallback(RenderGraphContext rgContext, IRenderGraphResource res) { }

	internal void EndExecute() { }

	internal void FlushLogs() { }

	internal static RenderGraphResourceRegistry get_current() { }

	internal ComputeBuffer GetComputeBuffer(in ComputeBufferHandle handle) { }

	private ComputeBufferResource GetComputeBufferResource(in ResourceHandle handle) { }

	internal int GetComputeBufferResourceCount() { }

	internal ComputeBufferDesc GetComputeBufferResourceDesc(in ResourceHandle handle) { }

	internal RendererList GetRendererList(in RendererListHandle handle) { }

	internal string GetRenderGraphResourceName(RenderGraphResourceType type, int index) { }

	internal string GetRenderGraphResourceName(in ResourceHandle res) { }

	internal int GetRenderGraphResourceTransientIndex(in ResourceHandle res) { }

	internal int GetResourceCount(RenderGraphResourceType type) { }

	internal RTHandle GetTexture(in TextureHandle handle) { }

	internal TextureResource GetTextureResource(in ResourceHandle handle) { }

	internal int GetTextureResourceCount() { }

	internal TextureDesc GetTextureResourceDesc(in ResourceHandle handle) { }

	internal TextureHandle ImportBackbuffer(RenderTargetIdentifier rt) { }

	internal ComputeBufferHandle ImportComputeBuffer(ComputeBuffer computeBuffer) { }

	internal TextureHandle ImportTexture(RTHandle rt) { }

	internal void IncrementWriteCount(in ResourceHandle res) { }

	internal bool IsGraphicsResourceCreated(in ResourceHandle res) { }

	internal bool IsRendererListCreated(in RendererListHandle res) { }

	internal bool IsRenderGraphResourceImported(in ResourceHandle res) { }

	internal bool IsRenderGraphResourceImported(RenderGraphResourceType type, int index) { }

	internal bool IsRenderGraphResourceShared(RenderGraphResourceType type, int index) { }

	private void LogResources() { }

	private void ManageSharedRenderGraphResources() { }

	internal void PurgeUnusedGraphicsResources() { }

	internal void RefreshSharedTextureDesc(TextureHandle texture, in TextureDesc desc) { }

	internal void ReleasePooledResource(RenderGraphContext rgContext, int type, int index) { }

	internal void ReleasePooledResource(RenderGraphContext rgContext, ResourceHandle handle) { }

	internal void ReleaseSharedTexture(TextureHandle texture) { }

	private void ReleaseTextureCallback(RenderGraphContext rgContext, IRenderGraphResource res) { }

	internal static void set_current(RenderGraphResourceRegistry value) { }

	internal bool TextureNeedsFallback(in TextureHandle handle) { }

	internal void UpdateSharedResourceLastFrameIndex(int type, int index) { }

	private void ValidateComputeBufferDesc(in ComputeBufferDesc desc) { }

	private void ValidateRendererListDesc(in RendererListDesc desc) { }

	private void ValidateTextureDesc(in TextureDesc desc) { }

}

