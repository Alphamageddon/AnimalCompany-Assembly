namespace UnityEngine.Experimental.Rendering.RenderGraphModule;

[DebuggerDisplay("RenderPass: {name} (Index:{index} Async:{enableAsyncCompute})")]
internal sealed class RenderGraphPass : RenderGraphPass
{
	internal PassData data; //Field offset: 0x0
	internal RenderFunc<PassData> renderFunc; //Field offset: 0x0

	public RenderGraphPass`1() { }

	public virtual void Execute(RenderGraphContext renderGraphContext) { }

	public virtual bool HasRenderFunc() { }

	public void Initialize(int passIndex, PassData passData, string passName, ProfilingSampler sampler) { }

	public virtual void Release(RenderGraphObjectPool pool) { }

}

