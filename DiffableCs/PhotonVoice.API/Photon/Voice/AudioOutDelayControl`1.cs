namespace Photon.Voice;

public abstract class AudioOutDelayControl : AudioOutDelayControl, IAudioOut<T>
{
	private const int TEMPO_UP_SKIP_GROUP = 6; //Field offset: 0x0
	public const int FRAME_POOL_CAPACITY = 50; //Field offset: 0x0
	private const int NO_PUSH_TIMEOUT_MS = 120; //Field offset: 0x0
	protected readonly int sizeofT; //Field offset: 0x0
	private ConcurrentQueue<T[]> frameQueue; //Field offset: 0x0
	private bool tempoChangeHQ; //Field offset: 0x0
	private TempoUp<T> tempoUp; //Field offset: 0x0
	private T[] resampledFrame; //Field offset: 0x0
	private T[] zeroFrame; //Field offset: 0x0
	private readonly bool processInService; //Field offset: 0x0
	private readonly bool debugInfo; //Field offset: 0x0
	protected readonly string logPrefix; //Field offset: 0x0
	protected readonly ILogger logger; //Field offset: 0x0
	private int lastPushTime; //Field offset: 0x0
	private int maxDelaySamples; //Field offset: 0x0
	private int upperTargetDelaySamples; //Field offset: 0x0
	private int targetDelaySamples; //Field offset: 0x0
	private bool flushed; //Field offset: 0x0
	private bool started; //Field offset: 0x0
	private int channels; //Field offset: 0x0
	private PlayDelayConfig playDelayConfig; //Field offset: 0x0
	private int playSamplePos; //Field offset: 0x0
	private int clearSamplePos; //Field offset: 0x0
	private int writeSamplePos; //Field offset: 0x0
	private int frequency; //Field offset: 0x0
	private int bufferSamplesHalf; //Field offset: 0x0
	private int bufferSamples; //Field offset: 0x0
	private int frameSize; //Field offset: 0x0
	private int frameSamples; //Field offset: 0x0
	private PrimitiveArrayPool<T> framePool; //Field offset: 0x0
	private bool catchingUp; //Field offset: 0x0

	public bool IsFlushed
	{
		 get { } //Length: 32
	}

	public override bool IsPlaying
	{
		 get { } //Length: 64
	}

	public override int Lag
	{
		 get { } //Length: 92
	}

	public abstract long OutPos
	{
		 get { } //Length: 0
	}

	public AudioOutDelayControl`1(bool processInService, PlayDelayConfig playDelayConfig, ILogger logger, string logPrefix, bool debugInfo) { }

	public override void Flush() { }

	public bool get_IsFlushed() { }

	public override bool get_IsPlaying() { }

	public override int get_Lag() { }

	public abstract long get_OutPos() { }

	public bool IsZeroFrame(T[] f) { }

	public abstract void OutCreate(int frequency, int channels, int bufferSamples) { }

	public abstract void OutStart() { }

	public abstract void OutWrite(T[] data, int offsetSamples) { }

	private void processFrame(T[] frame, int playSamplePos) { }

	public override void Push(T[] frame) { }

	public override void Service() { }

	public override void Start(int frequency, int channels, int frameSamples) { }

	public override void Stop() { }

	private int writeResampled(T[] f, int resampledLenSamples) { }

}

