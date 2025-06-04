namespace UnityEngine.Experimental.Rendering.RenderGraphModule;

[DebuggerDisplay("TextureResource ({desc.name})")]
internal class TextureResource : RenderGraphResource<TextureDesc, RTHandle>
{
	private static int m_TextureCreationIndex; //Field offset: 0x0

	public TextureResource() { }

	public virtual void CreateGraphicsResource(string name = "") { }

	public virtual void CreatePooledGraphicsResource() { }

	public virtual string GetName() { }

	public virtual void LogCreation(RenderGraphLogger logger) { }

	public virtual void LogRelease(RenderGraphLogger logger) { }

	public virtual void ReleaseGraphicsResource() { }

	public virtual void ReleasePooledGraphicsResource(int frameIndex) { }

}

