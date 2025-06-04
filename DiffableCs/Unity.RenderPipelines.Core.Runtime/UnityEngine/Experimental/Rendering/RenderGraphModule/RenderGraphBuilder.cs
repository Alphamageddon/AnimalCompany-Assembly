namespace UnityEngine.Experimental.Rendering.RenderGraphModule;

public struct RenderGraphBuilder : IDisposable
{
	private RenderGraphPass m_RenderPass; //Field offset: 0x0
	private RenderGraphResourceRegistry m_Resources; //Field offset: 0x8
	private RenderGraph m_RenderGraph; //Field offset: 0x10
	private bool m_Disposed; //Field offset: 0x18

	internal RenderGraphBuilder(RenderGraphPass renderPass, RenderGraphResourceRegistry resources, RenderGraph renderGraph) { }

	public void AllowPassCulling(bool value) { }

	public void AllowRendererListCulling(bool value) { }

	private void CheckResource(in ResourceHandle res, bool dontCheckTransientReadWrite = false) { }

	public ComputeBufferHandle CreateTransientComputeBuffer(in ComputeBufferDesc desc) { }

	public ComputeBufferHandle CreateTransientComputeBuffer(in ComputeBufferHandle computebuffer) { }

	public TextureHandle CreateTransientTexture(in TextureDesc desc) { }

	public TextureHandle CreateTransientTexture(in TextureHandle texture) { }

	public RendererListHandle DependsOn(in RendererListHandle input) { }

	private void Dispose(bool disposing) { }

	public override void Dispose() { }

	public void EnableAsyncCompute(bool value) { }

	internal void GenerateDebugData(bool value) { }

	public ComputeBufferHandle ReadComputeBuffer(in ComputeBufferHandle input) { }

	public TextureHandle ReadTexture(in TextureHandle input) { }

	public TextureHandle ReadWriteTexture(in TextureHandle input) { }

	public void SetRenderFunc(RenderFunc<PassData> renderFunc) { }

	public TextureHandle UseColorBuffer(in TextureHandle input, int index) { }

	public TextureHandle UseDepthBuffer(in TextureHandle input, DepthAccess flags) { }

	public RendererListHandle UseRendererList(in RendererListHandle input) { }

	public ComputeBufferHandle WriteComputeBuffer(in ComputeBufferHandle input) { }

	public TextureHandle WriteTexture(in TextureHandle input) { }

}

