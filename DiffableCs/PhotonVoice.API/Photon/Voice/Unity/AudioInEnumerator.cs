namespace Photon.Voice.Unity;

public class AudioInEnumerator : DeviceEnumeratorBase
{

	public virtual string Error
	{
		 get { } //Length: 8
	}

	public AudioInEnumerator(ILogger logger) { }

	public virtual void Dispose() { }

	public virtual string get_Error() { }

	public virtual void Refresh() { }

}

