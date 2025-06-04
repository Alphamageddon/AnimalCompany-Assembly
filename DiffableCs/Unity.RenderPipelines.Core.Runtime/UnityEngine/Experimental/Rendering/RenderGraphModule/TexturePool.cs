namespace UnityEngine.Experimental.Rendering.RenderGraphModule;

internal class TexturePool : RenderGraphResourcePool<RTHandle>
{

	public TexturePool() { }

	protected virtual string GetResourceName(RTHandle res) { }

	protected virtual long GetResourceSize(RTHandle res) { }

	protected virtual string GetResourceTypeName() { }

	protected virtual int GetSortIndex(RTHandle res) { }

	public virtual void PurgeUnusedResources(int currentFrameIndex) { }

	protected virtual void ReleaseInternalResource(RTHandle res) { }

}

