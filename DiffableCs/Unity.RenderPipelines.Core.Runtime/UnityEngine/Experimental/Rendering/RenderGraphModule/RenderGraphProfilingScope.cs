namespace UnityEngine.Experimental.Rendering.RenderGraphModule;

public struct RenderGraphProfilingScope : IDisposable
{
	private bool m_Disposed; //Field offset: 0x0
	private ProfilingSampler m_Sampler; //Field offset: 0x8
	private RenderGraph m_RenderGraph; //Field offset: 0x10

	public RenderGraphProfilingScope(RenderGraph renderGraph, ProfilingSampler sampler) { }

	public override void Dispose() { }

	private void Dispose(bool disposing) { }

}

