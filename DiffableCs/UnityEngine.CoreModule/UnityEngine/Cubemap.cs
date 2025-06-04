namespace UnityEngine;

[ExcludeFromPreset]
[NativeHeader("Runtime/Graphics/CubemapTexture.h")]
public sealed class Cubemap : Texture
{

	public virtual bool isReadable
	{
		 get { } //Length: 60
	}

	[ExcludeFromDocs]
	public Cubemap(int width, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	public Cubemap(int width, TextureFormat format, int mipCount, bool createUninitialized) { }

	[ExcludeFromDocs]
	public Cubemap(int width, DefaultFormat format, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	public Cubemap(int width, DefaultFormat format, TextureCreationFlags flags, int mipCount) { }

	[ExcludeFromDocs]
	[RequiredByNativeCode]
	public Cubemap(int width, GraphicsFormat format, TextureCreationFlags flags) { }

	public Cubemap(int width, TextureFormat format, int mipCount) { }

	internal Cubemap(int width, TextureFormat textureFormat, int mipCount, IntPtr nativeTex, bool createUninitialized) { }

	public Cubemap(int width, TextureFormat textureFormat, bool mipChain) { }

	public Cubemap(int width, TextureFormat textureFormat, bool mipChain, bool createUninitialized) { }

	[ExcludeFromDocs]
	public void Apply() { }

	public void Apply(bool updateMipmaps, bool makeNoLongerReadable) { }

	[FreeFunction(Name = "CubemapScripting::Apply", HasExplicitThis = True)]
	private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) { }

	public virtual bool get_isReadable() { }

	private static void Internal_Create(Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) { }

	[FreeFunction("CubemapScripting::Create")]
	private static bool Internal_CreateImpl(Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) { }

	[ExcludeFromDocs]
	public void SetPixel(CubemapFace face, int x, int y, Color color) { }

	public void SetPixel(CubemapFace face, int x, int y, Color color, int mip) { }

	[NativeName("SetPixel")]
	private void SetPixelImpl(int image, int mip, int x, int y, Color color) { }

	private void SetPixelImpl_Injected(int image, int mip, int x, int y, ref Color color) { }

	internal bool ValidateFormat(GraphicsFormat format, int width) { }

	internal bool ValidateFormat(TextureFormat format, int width) { }

	private static void ValidateIsNotCrunched(TextureCreationFlags flags) { }

}

