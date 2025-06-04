namespace Photon.Voice;

public interface IAudioInChangeNotifier : IDisposable
{

	public string Error
	{
		 get { } //Length: 0
	}

	public bool IsSupported
	{
		 get { } //Length: 0
	}

	public string get_Error() { }

	public bool get_IsSupported() { }

}

