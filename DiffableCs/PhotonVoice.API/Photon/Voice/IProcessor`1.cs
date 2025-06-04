namespace Photon.Voice;

public interface IProcessor : IDisposable
{

	public T[] Process(T[] buf) { }

}

