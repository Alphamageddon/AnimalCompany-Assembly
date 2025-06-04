namespace UnityEngine.Experimental.Rendering.RenderGraphModule;

[DebuggerDisplay("RendererList ({handle})")]
public struct RendererListHandle
{
	private bool m_IsValid; //Field offset: 0x0
	[CompilerGenerated]
	private int <handle>k__BackingField; //Field offset: 0x4

	internal int handle
	{
		[CompilerGenerated]
		[IsReadOnly]
		internal get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	internal RendererListHandle(int handle) { }

	[CompilerGenerated]
	[IsReadOnly]
	internal int get_handle() { }

	public bool IsValid() { }

	public static int op_Implicit(RendererListHandle handle) { }

	public static RendererList op_Implicit(RendererListHandle rendererList) { }

	[CompilerGenerated]
	private void set_handle(int value) { }

}

