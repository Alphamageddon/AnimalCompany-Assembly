namespace Photon.Voice.Unity;

public class UnityAudioOut : AudioOutDelayControl<Single>
{
	protected readonly AudioSource source; //Field offset: 0xB0
	protected AudioClip clip; //Field offset: 0xB8

	public virtual long OutPos
	{
		 get { } //Length: 36
	}

	public UnityAudioOut(AudioSource audioSource, PlayDelayConfig playDelayConfig, ILogger logger, string logPrefix, bool debugInfo) { }

	public virtual long get_OutPos() { }

	public virtual void OutCreate(int frequency, int channels, int bufferSamples) { }

	public virtual void OutStart() { }

	public virtual void OutWrite(Single[] data, int offsetSamples) { }

	public virtual void Stop() { }

}

