namespace UnityEngine.Experimental.Rendering.RenderGraphModule;

internal class ComputeBufferPool : RenderGraphResourcePool<ComputeBuffer>
{

	public ComputeBufferPool() { }

	protected virtual string GetResourceName(ComputeBuffer res) { }

	protected virtual long GetResourceSize(ComputeBuffer res) { }

	protected virtual string GetResourceTypeName() { }

	protected virtual int GetSortIndex(ComputeBuffer res) { }

	public virtual void PurgeUnusedResources(int currentFrameIndex) { }

	protected virtual void ReleaseInternalResource(ComputeBuffer res) { }

}

