namespace UnityEngine;

[ExcludeFromPreset]
[NativeHeader("Runtime/Graphics/Texture3D.h")]
public sealed class Texture3D : Texture
{

	public virtual bool isReadable
	{
		 get { } //Length: 60
	}

	[ExcludeFromDocs]
	public Texture3D(int width, int height, int depth, TextureFormat textureFormat, int mipCount) { }

	public Texture3D(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, IntPtr nativeTex) { }

	public Texture3D(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool createUninitialized) { }

	[ExcludeFromDocs]
	public Texture3D(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	public Texture3D(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags, int mipCount) { }

	[ExcludeFromDocs]
	[RequiredByNativeCode]
	public Texture3D(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	public Texture3D(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	[ExcludeFromDocs]
	public Texture3D(int width, int height, int depth, TextureFormat textureFormat, bool mipChain) { }

	public Texture3D(int width, int height, int depth, TextureFormat textureFormat, int mipCount, IntPtr nativeTex) { }

	public Texture3D(int width, int height, int depth, TextureFormat textureFormat, int mipCount, IntPtr nativeTex, bool createUninitialized) { }

	[ExcludeFromDocs]
	public void Apply() { }

	[ExcludeFromDocs]
	public void Apply(bool updateMipmaps) { }

	public void Apply(bool updateMipmaps, bool makeNoLongerReadable) { }

	[FreeFunction(Name = "Texture3DScripting::Apply", HasExplicitThis = True)]
	private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) { }

	public virtual bool get_isReadable() { }

	private static void Internal_Create(Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) { }

	[FreeFunction("Texture3DScripting::Create")]
	private static bool Internal_CreateImpl(Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) { }

	public void SetPixel(int x, int y, int z, Color color, int mipLevel) { }

	public void SetPixelData(NativeArray<T> data, int mipLevel, int sourceDataStartIndex = 0) { }

	[FreeFunction(Name = "Texture3DScripting::SetPixelData", HasExplicitThis = True, ThrowsException = True)]
	private bool SetPixelDataImpl(IntPtr data, int mipLevel, int elementSize, int dataArraySize, int sourceDataStartIndex = 0) { }

	[NativeName("SetPixel")]
	private void SetPixelImpl(int mip, int x, int y, int z, Color color) { }

	private void SetPixelImpl_Injected(int mip, int x, int y, int z, ref Color color) { }

	[FreeFunction(Name = "Texture3DScripting::SetPixels", HasExplicitThis = True, ThrowsException = True)]
	public void SetPixels(Color[] colors, int miplevel) { }

	private static void ValidateIsNotCrunched(TextureCreationFlags flags) { }

}

