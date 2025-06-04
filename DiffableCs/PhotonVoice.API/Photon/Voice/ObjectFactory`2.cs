namespace Photon.Voice;

public interface ObjectFactory : IDisposable
{

	public TInfo Info
	{
		 get { } //Length: 0
	}

	public void Free(TType obj) { }

	public void Free(TType obj, TInfo info) { }

	public TInfo get_Info() { }

	public TType New() { }

	public TType New(TInfo info) { }

}

