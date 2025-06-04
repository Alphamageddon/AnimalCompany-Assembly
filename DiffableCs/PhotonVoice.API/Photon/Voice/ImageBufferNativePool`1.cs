namespace Photon.Voice;

public class ImageBufferNativePool : ObjectPool<T, ImageBufferInfo>
{
	internal sealed class Factory : MulticastDelegate
	{

		public Factory(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ImageBufferNativePool<T> pool, ImageBufferInfo info, AsyncCallback callback, object object) { }

		public override T EndInvoke(IAsyncResult result) { }

		public override T Invoke(ImageBufferNativePool<T> pool, ImageBufferInfo info) { }

	}

	private Factory<T> factory; //Field offset: 0x0

	public ImageBufferNativePool`1(int capacity, Factory<T> factory, string name) { }

	public ImageBufferNativePool`1(int capacity, Factory<T> factory, string name, ImageBufferInfo info) { }

	protected virtual T createObject(ImageBufferInfo info) { }

	protected virtual void destroyObject(T obj) { }

	protected virtual bool infosMatch(ImageBufferInfo i0, ImageBufferInfo i1) { }

}

