namespace UnityEngine.Experimental.Rendering.RenderGraphModule;

[DebuggerDisplay("ComputeBufferResource ({desc.name})")]
internal class ComputeBufferResource : RenderGraphResource<ComputeBufferDesc, ComputeBuffer>
{

	public ComputeBufferResource() { }

	public virtual void CreateGraphicsResource(string name = "") { }

	public virtual void CreatePooledGraphicsResource() { }

	public virtual string GetName() { }

	public virtual void LogCreation(RenderGraphLogger logger) { }

	public virtual void LogRelease(RenderGraphLogger logger) { }

	public virtual void ReleaseGraphicsResource() { }

	public virtual void ReleasePooledGraphicsResource(int frameIndex) { }

}

