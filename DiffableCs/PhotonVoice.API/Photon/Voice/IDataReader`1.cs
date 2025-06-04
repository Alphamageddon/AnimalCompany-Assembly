namespace Photon.Voice;

public interface IDataReader : IDisposable
{

	public bool Read(T[] buffer) { }

}

