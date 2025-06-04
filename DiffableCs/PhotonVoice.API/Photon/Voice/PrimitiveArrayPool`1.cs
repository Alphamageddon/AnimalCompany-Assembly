namespace Photon.Voice;

public class PrimitiveArrayPool : ObjectPool<T[], Int32>
{

	public PrimitiveArrayPool`1(int capacity, string name) { }

	public PrimitiveArrayPool`1(int capacity, string name, int info) { }

	protected virtual T[] createObject(int info) { }

	protected virtual void destroyObject(T[] obj) { }

	protected virtual bool infosMatch(int i0, int i1) { }

}

