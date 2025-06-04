namespace UnityEngine.Experimental.Rendering.RenderGraphModule;

[DebuggerDisplay("Resource ({GetType().Name}:{GetName()})")]
internal abstract class RenderGraphResource : IRenderGraphResource
{
	public DescType desc; //Field offset: 0x0
	public ResType graphicsResource; //Field offset: 0x0

	protected RenderGraphResource`2() { }

	public virtual bool IsCreated() { }

	public virtual void ReleaseGraphicsResource() { }

	public virtual void Reset(IRenderGraphResourcePool pool) { }

}

