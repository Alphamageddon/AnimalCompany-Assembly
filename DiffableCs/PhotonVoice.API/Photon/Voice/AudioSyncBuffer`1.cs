namespace Photon.Voice;

public class AudioSyncBuffer : AudioOutDelayControl<T>
{
	private T[] buffer; //Field offset: 0x0
	private int readPosSamples; //Field offset: 0x0
	private int sampleRate; //Field offset: 0x0
	private int channels; //Field offset: 0x0
	private int bufferSamples; //Field offset: 0x0
	private bool started; //Field offset: 0x0

	public virtual long OutPos
	{
		 get { } //Length: 8
	}

	public AudioSyncBuffer`1(PlayDelayConfig playDelayConfig, ILogger logger, string logPrefix, bool debugInfo) { }

	public virtual long get_OutPos() { }

	public virtual void OutCreate(int frequency, int channels, int bufferSamples) { }

	public virtual void OutStart() { }

	public virtual void OutWrite(T[] data, int offsetSamples) { }

	public void Read(T[] outBuf, int outChannels, int outSampleRate) { }

	public virtual void Stop() { }

}

