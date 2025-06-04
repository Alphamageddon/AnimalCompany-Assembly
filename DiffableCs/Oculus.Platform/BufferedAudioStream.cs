//Type is in global namespace

public class BufferedAudioStream
{
	private const bool VerboseLogging = False; //Field offset: 0x0
	private const float bufferLengthSeconds = 0.25; //Field offset: 0x0
	private const int sampleRate = 48000; //Field offset: 0x0
	private const int bufferSize = 12000; //Field offset: 0x0
	private const float playbackDelayTimeSeconds = 0.05; //Field offset: 0x0
	private AudioSource audio; //Field offset: 0x10
	private Single[] audioBuffer; //Field offset: 0x18
	private int writePos; //Field offset: 0x20
	private float playbackDelayRemaining; //Field offset: 0x24
	private float remainingBufferTime; //Field offset: 0x28

	public BufferedAudioStream(AudioSource audio) { }

	public void AddData(Single[] samples) { }

	private void Stop() { }

	public void Update() { }

}

