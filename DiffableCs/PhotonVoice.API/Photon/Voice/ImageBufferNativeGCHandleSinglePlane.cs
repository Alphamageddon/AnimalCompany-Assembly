namespace Photon.Voice;

[Obsolete("Requres regular allocations of byte[]. May leak if used w/o pool. Use ImageBufferNativeGCHandleBytes with Texture2D.GetRawTextureData<byte>().CopyTo(b.PlaneBytes)) instead")]
public class ImageBufferNativeGCHandleSinglePlane : ImageBufferNative, IDisposable
{
	private ImageBufferNativePool<ImageBufferNativeGCHandleSinglePlane> pool; //Field offset: 0x68
	private GCHandle planeHandle; //Field offset: 0x70

	public ImageBufferNativeGCHandleSinglePlane(ImageBufferNativePool<ImageBufferNativeGCHandleSinglePlane> pool, ImageBufferInfo info) { }

	public virtual void Dispose() { }

	protected virtual void Free() { }

	public void PinPlane(Byte[] plane) { }

}

