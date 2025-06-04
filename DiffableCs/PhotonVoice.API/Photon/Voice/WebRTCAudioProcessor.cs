namespace Photon.Voice;

public class WebRTCAudioProcessor : WebRTCAudioLib, IProcessor<Int16>, IDisposable
{
	private const int REVERSE_BUFFER_POOL_CAPACITY = 50; //Field offset: 0x0
	public static readonly Int32[] SupportedSamplingRates; //Field offset: 0x0
	private const int supportedFrameLenMs = 10; //Field offset: 0x0
	private int reverseStreamDelayMs; //Field offset: 0x10
	private bool aec; //Field offset: 0x14
	private bool aecHighPass; //Field offset: 0x15
	private bool aecm; //Field offset: 0x16
	private bool highPass; //Field offset: 0x17
	private bool ns; //Field offset: 0x18
	private bool agc; //Field offset: 0x19
	private int agcCompressionGain; //Field offset: 0x1C
	private int agcTargetLevel; //Field offset: 0x20
	private bool agc2; //Field offset: 0x24
	private bool vad; //Field offset: 0x25
	private bool reverseStreamThreadRunning; //Field offset: 0x26
	private Queue<Int16[]> reverseStreamQueue; //Field offset: 0x28
	private AutoResetEvent reverseStreamQueueReady; //Field offset: 0x30
	private FactoryPrimitiveArrayPool<Int16> reverseBufferFactory; //Field offset: 0x38
	private bool bypass; //Field offset: 0x40
	private int inFrameSize; //Field offset: 0x44
	private int processFrameSize; //Field offset: 0x48
	private int samplingRate; //Field offset: 0x4C
	private int channels; //Field offset: 0x50
	private IntPtr proc; //Field offset: 0x58
	private bool disposed; //Field offset: 0x60
	private Framer<Single> reverseFramer; //Field offset: 0x68
	private int reverseSamplingRate; //Field offset: 0x70
	private int reverseChannels; //Field offset: 0x74
	private ILogger logger; //Field offset: 0x78
	private bool aecInited; //Field offset: 0x80
	private int lastProcessErr; //Field offset: 0x84
	private int lastProcessReverseErr; //Field offset: 0x88

	public bool AEC
	{
		 set { } //Length: 108
	}

	public bool AECHighPass
	{
		 set { } //Length: 92
	}

	public bool AECMobile
	{
		 set { } //Length: 108
	}

	public int AECStreamDelayMs
	{
		 set { } //Length: 88
	}

	public bool AGC
	{
		 set { } //Length: 92
	}

	public bool AGC2
	{
		 set { } //Length: 92
	}

	public int AGCCompressionGain
	{
		 set { } //Length: 420
	}

	public int AGCTargetLevel
	{
		 set { } //Length: 420
	}

	public private bool Bypass
	{
		private get { } //Length: 8
		 set { } //Length: 408
	}

	public bool HighPass
	{
		 set { } //Length: 92
	}

	public bool NoiseSuppression
	{
		 set { } //Length: 92
	}

	public bool VAD
	{
		 set { } //Length: 92
	}

	private static WebRTCAudioProcessor() { }

	public WebRTCAudioProcessor(ILogger logger, int frameSize, int samplingRate, int channels, int reverseSamplingRate, int reverseChannels) { }

	public override void Dispose() { }

	private bool get_Bypass() { }

	private void InitReverseStream() { }

	public void OnAudioOutFrameFloat(Single[] data) { }

	public override Int16[] Process(Int16[] buf) { }

	private void ReverseStreamThread() { }

	public void set_AEC(bool value) { }

	public void set_AECHighPass(bool value) { }

	public void set_AECMobile(bool value) { }

	public void set_AECStreamDelayMs(int value) { }

	public void set_AGC(bool value) { }

	public void set_AGC2(bool value) { }

	public void set_AGCCompressionGain(int value) { }

	public void set_AGCTargetLevel(int value) { }

	public void set_Bypass(bool value) { }

	public void set_HighPass(bool value) { }

	public void set_NoiseSuppression(bool value) { }

	public void set_VAD(bool value) { }

	private int setParam(Param param, int v) { }

}

