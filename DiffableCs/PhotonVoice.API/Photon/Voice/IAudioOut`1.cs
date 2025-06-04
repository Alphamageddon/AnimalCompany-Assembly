namespace Photon.Voice;

public interface IAudioOut
{

	public bool IsPlaying
	{
		 get { } //Length: 0
	}

	public int Lag
	{
		 get { } //Length: 0
	}

	public void Flush() { }

	public bool get_IsPlaying() { }

	public int get_Lag() { }

	public void Push(T[] frame) { }

	public void Service() { }

	public void Start(int frequency, int channels, int frameSamplesPerChannel) { }

	public void Stop() { }

}

