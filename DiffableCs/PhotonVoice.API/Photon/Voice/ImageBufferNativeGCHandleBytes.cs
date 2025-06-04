namespace Photon.Voice;

public class ImageBufferNativeGCHandleBytes : ImageBufferNative, IDisposable
{
	private ImageBufferNativePool<ImageBufferNativeGCHandleBytes> pool; //Field offset: 0x68
	private readonly GCHandle[] planeHandle; //Field offset: 0x70
	private readonly Byte[][] planeBytes; //Field offset: 0x78

	public Byte[][] PlaneBytes
	{
		 get { } //Length: 8
	}

	public ImageBufferNativeGCHandleBytes(ImageBufferNativePool<ImageBufferNativeGCHandleBytes> pool, ImageBufferInfo info) { }

	public virtual void Dispose() { }

	protected virtual void Free() { }

	public Byte[][] get_PlaneBytes() { }

}

