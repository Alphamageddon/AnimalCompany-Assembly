namespace Photon.Voice;

public class AudioOutDummy : IAudioOut<T>
{

	public override bool IsPlaying
	{
		 get { } //Length: 8
	}

	public override int Lag
	{
		 get { } //Length: 8
	}

	public AudioOutDummy`1() { }

	public override void Flush() { }

	public override bool get_IsPlaying() { }

	public override int get_Lag() { }

	public override void Push(T[] frame) { }

	public override void Service() { }

	public override void Start(int frequency, int channels, int frameSamplesPerChannel) { }

	public override void Stop() { }

}

