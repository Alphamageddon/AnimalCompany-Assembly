namespace UnityEngine.Experimental.Rendering;

[NativeHeader("Runtime/Graphics/TextureFormat.h")]
[NativeHeader("Runtime/Graphics/GraphicsFormatUtility.bindings.h")]
[NativeHeader("Runtime/Graphics/Format.h")]
public class GraphicsFormatUtility
{
	private static readonly GraphicsFormat[] tableNoStencil; //Field offset: 0x0
	private static readonly GraphicsFormat[] tableStencil; //Field offset: 0x8

	private static GraphicsFormatUtility() { }

	internal static bool CanDecompressFormat(GraphicsFormat format) { }

	[FreeFunction(IsThreadSafe = True)]
	private static bool CanDecompressFormat(GraphicsFormat format, bool wholeImage) { }

	[FreeFunction(IsThreadSafe = True)]
	public static uint GetBlockSize(GraphicsFormat format) { }

	[FreeFunction(IsThreadSafe = True)]
	public static uint GetComponentCount(GraphicsFormat format) { }

	[FreeFunction(IsThreadSafe = True)]
	public static int GetDepthBits(GraphicsFormat format) { }

	internal static GraphicsFormat GetDepthStencilFormat(int minimumDepthBits) { }

	public static GraphicsFormat GetDepthStencilFormat(int minimumDepthBits, int minimumStencilBits) { }

	[FreeFunction(IsThreadSafe = True)]
	private static GraphicsFormat GetDepthStencilFormatFromBitsLegacy_Native(int minimumDepthBits) { }

	[FreeFunction("GetGraphicsFormat_Native_Texture")]
	internal static GraphicsFormat GetFormat(Texture texture) { }

	[FreeFunction(IsThreadSafe = True)]
	public static string GetFormatString(GraphicsFormat format) { }

	public static GraphicsFormat GetGraphicsFormat(TextureFormat format, bool isSRGB) { }

	public static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, bool isSRGB) { }

	public static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[FreeFunction(IsThreadSafe = False)]
	private static GraphicsFormat GetGraphicsFormat_Native_RenderTextureFormat(RenderTextureFormat format, bool isSRGB) { }

	[FreeFunction(IsThreadSafe = True)]
	private static GraphicsFormat GetGraphicsFormat_Native_TextureFormat(TextureFormat format, bool isSRGB) { }

	[FreeFunction(IsThreadSafe = True)]
	public static GraphicsFormat GetLinearFormat(GraphicsFormat format) { }

	[FreeFunction(IsThreadSafe = True)]
	public static RenderTextureFormat GetRenderTextureFormat(GraphicsFormat format) { }

	[FreeFunction(IsThreadSafe = True)]
	public static GraphicsFormat GetSRGBFormat(GraphicsFormat format) { }

	[FreeFunction(IsThreadSafe = True)]
	public static FormatSwizzle GetSwizzleA(GraphicsFormat format) { }

	[FreeFunction(IsThreadSafe = True)]
	public static FormatSwizzle GetSwizzleB(GraphicsFormat format) { }

	[FreeFunction(IsThreadSafe = True)]
	public static FormatSwizzle GetSwizzleG(GraphicsFormat format) { }

	[FreeFunction(IsThreadSafe = True)]
	public static FormatSwizzle GetSwizzleR(GraphicsFormat format) { }

	[FreeFunction(IsThreadSafe = True)]
	public static bool IsAlphaOnlyFormat(GraphicsFormat format) { }

	public static bool IsCompressedFormat(TextureFormat format) { }

	[FreeFunction(IsThreadSafe = True)]
	private static bool IsCompressedFormat_Native_TextureFormat(TextureFormat format) { }

	[FreeFunction("IsCompressedCrunchTextureFormat", IsThreadSafe = True)]
	public static bool IsCrunchFormat(TextureFormat format) { }

	[FreeFunction(IsThreadSafe = True)]
	public static bool IsDepthStencilFormat(GraphicsFormat format) { }

	[FreeFunction(IsThreadSafe = True)]
	public static bool IsPVRTCFormat(GraphicsFormat format) { }

	[FreeFunction(IsThreadSafe = True)]
	public static bool IsSRGBFormat(GraphicsFormat format) { }

}

