namespace Photon.Voice.Unity;

[AddComponentMenu("Photon Voice/Speaker AudioFilterRead")]
public class SpeakerAudioFilterRead : Speaker
{
	private AudioSyncBuffer<Single> outBuffer; //Field offset: 0x60
	private int outputSampleRate; //Field offset: 0x68

	public SpeakerAudioFilterRead() { }

	protected virtual IAudioOut<Single> CreateAudioOut() { }

	private void OnAudioFilterRead(Single[] data, int channels) { }

}

