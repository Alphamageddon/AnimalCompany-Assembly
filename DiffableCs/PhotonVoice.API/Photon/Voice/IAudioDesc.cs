namespace Photon.Voice;

public interface IAudioDesc : IDisposable
{

	public int Channels
	{
		 get { } //Length: 0
	}

	public string Error
	{
		 get { } //Length: 0
	}

	public int SamplingRate
	{
		 get { } //Length: 0
	}

	public int get_Channels() { }

	public string get_Error() { }

	public int get_SamplingRate() { }

}

