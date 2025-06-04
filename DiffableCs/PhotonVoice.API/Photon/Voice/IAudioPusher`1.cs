namespace Photon.Voice;

public interface IAudioPusher : IAudioDesc, IDisposable
{

	public void SetCallback(Action<T[]> callback, ObjectFactory<T[], Int32> bufferFactory) { }

}

