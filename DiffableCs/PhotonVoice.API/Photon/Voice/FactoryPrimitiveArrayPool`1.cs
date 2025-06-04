namespace Photon.Voice;

public class FactoryPrimitiveArrayPool : ObjectFactory<T[], Int32>, IDisposable
{
	private PrimitiveArrayPool<T> pool; //Field offset: 0x0

	public override int Info
	{
		 get { } //Length: 28
	}

	public FactoryPrimitiveArrayPool`1(int capacity, string name) { }

	public FactoryPrimitiveArrayPool`1(int capacity, string name, int info) { }

	public override void Dispose() { }

	public override void Free(T[] obj) { }

	public override void Free(T[] obj, int info) { }

	public override int get_Info() { }

	public override T[] New() { }

	public override T[] New(int size) { }

}

