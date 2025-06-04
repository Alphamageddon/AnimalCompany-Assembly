namespace Photon.Voice;

public class ImageBufferNativeAlloc : ImageBufferNative, IDisposable
{
	private ImageBufferNativePool<ImageBufferNativeAlloc> pool; //Field offset: 0x68

	public ImageBufferNativeAlloc(ImageBufferNativePool<ImageBufferNativeAlloc> pool, ImageBufferInfo info) { }

	public virtual void Dispose() { }

	protected virtual void Free() { }

}

