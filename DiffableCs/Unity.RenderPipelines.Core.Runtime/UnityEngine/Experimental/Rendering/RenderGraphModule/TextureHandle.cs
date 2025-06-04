namespace UnityEngine.Experimental.Rendering.RenderGraphModule;

[DebuggerDisplay("Texture ({handle.index})")]
public struct TextureHandle
{
	private static TextureHandle s_NullHandle; //Field offset: 0x0
	internal ResourceHandle handle; //Field offset: 0x0

	public static TextureHandle nullHandle
	{
		 get { } //Length: 88
	}

	private static TextureHandle() { }

	internal TextureHandle(int handle, bool shared = false) { }

	public static TextureHandle get_nullHandle() { }

	public bool IsValid() { }

	public static RenderTargetIdentifier op_Implicit(TextureHandle texture) { }

	public static Texture op_Implicit(TextureHandle texture) { }

	public static RenderTexture op_Implicit(TextureHandle texture) { }

	public static RTHandle op_Implicit(TextureHandle texture) { }

}

