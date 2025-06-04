namespace UnityEngine.Experimental.Rendering.RenderGraphModule;

public class RenderGraphContext
{
	public ScriptableRenderContext renderContext; //Field offset: 0x10
	public CommandBuffer cmd; //Field offset: 0x18
	public RenderGraphObjectPool renderGraphPool; //Field offset: 0x20
	public RenderGraphDefaultResources defaultResources; //Field offset: 0x28

	public RenderGraphContext() { }

}

