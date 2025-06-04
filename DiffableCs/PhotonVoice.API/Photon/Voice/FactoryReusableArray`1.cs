namespace Photon.Voice;

public class FactoryReusableArray : ObjectFactory<T[], Int32>, IDisposable
{
	private T[] arr; //Field offset: 0x0

	public override int Info
	{
		 get { } //Length: 28
	}

	public FactoryReusableArray`1(int size) { }

	public override void Dispose() { }

	public override void Free(T[] obj) { }

	public override void Free(T[] obj, int info) { }

	public override int get_Info() { }

	public override T[] New() { }

	public override T[] New(int size) { }

}

