namespace Photon.Voice;

public static class AudioUtil
{
	internal abstract class GeneratorPusher : IAudioPusher<T>, IAudioDesc, IDisposable
	{
		private Timer timer; //Field offset: 0x0
		private Action<T[]> callback; //Field offset: 0x0
		private ObjectFactory<T[], Int32> bufferFactory; //Field offset: 0x0
		protected long timeSamples; //Field offset: 0x0
		private int bufSamples; //Field offset: 0x0
		[CompilerGenerated]
		private readonly int <Channels>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private readonly int <SamplingRate>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private string <Error>k__BackingField; //Field offset: 0x0

		public override int Channels
		{
			[CompilerGenerated]
			 get { } //Length: 8
		}

		public private override string Error
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			private set { } //Length: 8
		}

		public override int SamplingRate
		{
			[CompilerGenerated]
			 get { } //Length: 8
		}

		public GeneratorPusher`1(int bufSizeMs = 100, int samplingRate = 48000, int channels = 1) { }

		public override void Dispose() { }

		protected abstract int Gen(T[] buf, long timeSamples) { }

		[CompilerGenerated]
		public override int get_Channels() { }

		[CompilerGenerated]
		public override string get_Error() { }

		[CompilerGenerated]
		public override int get_SamplingRate() { }

		private void OnTimedEvent(object source, ElapsedEventArgs e) { }

		[CompilerGenerated]
		private void set_Error(string value) { }

		public override void SetCallback(Action<T[]> callback, ObjectFactory<T[], Int32> bufferFactory) { }

	}

	internal abstract class GeneratorReader : IAudioReader<T>, IDataReader<T>, IDisposable, IAudioDesc
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c<T> <>9; //Field offset: 0x0
			public static Func<Double> <>9__0_0; //Field offset: 0x0

			private static <>c() { }

			public <>c() { }

			internal double <.ctor>b__0_0() { }

		}

		[CompilerGenerated]
		private readonly int <Channels>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private readonly int <SamplingRate>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private string <Error>k__BackingField; //Field offset: 0x0
		private long timeSamples; //Field offset: 0x0
		private Func<Double> clockSec; //Field offset: 0x0

		public override int Channels
		{
			[CompilerGenerated]
			 get { } //Length: 8
		}

		public private override string Error
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			private set { } //Length: 8
		}

		public override int SamplingRate
		{
			[CompilerGenerated]
			 get { } //Length: 8
		}

		public GeneratorReader`1(Func<Double> clockSec = null, int samplingRate = 48000, int channels = 1) { }

		public override void Dispose() { }

		protected abstract int Gen(T[] buf, long timeSamples) { }

		[CompilerGenerated]
		public override int get_Channels() { }

		[CompilerGenerated]
		public override string get_Error() { }

		[CompilerGenerated]
		public override int get_SamplingRate() { }

		public override bool Read(T[] buf) { }

		[CompilerGenerated]
		private void set_Error(string value) { }

	}

	internal interface ILevelMeter
	{

		public float AccumAvgPeakAmp
		{
			 get { } //Length: 0
		}

		public float CurrentAvgAmp
		{
			 get { } //Length: 0
		}

		public float CurrentPeakAmp
		{
			 get { } //Length: 0
		}

		public float get_AccumAvgPeakAmp() { }

		public float get_CurrentAvgAmp() { }

		public float get_CurrentPeakAmp() { }

		public void ResetAccumAvgPeakAmp() { }

	}

	internal interface IVoiceDetector
	{

		public event Action OnDetected
		{
			[CompilerGenerated]
			 add { } //Length: 0
			[CompilerGenerated]
			 remove { } //Length: 0
		}

		public int ActivityDelayMs
		{
			 get { } //Length: 0
			 set { } //Length: 0
		}

		public bool Detected
		{
			 get { } //Length: 0
		}

		public DateTime DetectedTime
		{
			 get { } //Length: 0
		}

		public bool On
		{
			 get { } //Length: 0
			 set { } //Length: 0
		}

		public float Threshold
		{
			 get { } //Length: 0
			 set { } //Length: 0
		}

		[CompilerGenerated]
		public void add_OnDetected(Action value) { }

		public int get_ActivityDelayMs() { }

		public bool get_Detected() { }

		public DateTime get_DetectedTime() { }

		public bool get_On() { }

		public float get_Threshold() { }

		[CompilerGenerated]
		public void remove_OnDetected(Action value) { }

		public void set_ActivityDelayMs(int value) { }

		public void set_On(bool value) { }

		public void set_Threshold(float value) { }

	}

	internal abstract class LevelMeter : IProcessor<T>, IDisposable, ILevelMeter
	{
		protected float ampSum; //Field offset: 0x0
		protected float ampPeak; //Field offset: 0x0
		protected int bufferSize; //Field offset: 0x0
		protected Single[] prevValues; //Field offset: 0x0
		protected int prevValuesHead; //Field offset: 0x0
		protected float accumAvgPeakAmpSum; //Field offset: 0x0
		protected int accumAvgPeakAmpCount; //Field offset: 0x0
		protected float currentPeakAmp; //Field offset: 0x0
		protected float norm; //Field offset: 0x0

		public override float AccumAvgPeakAmp
		{
			 get { } //Length: 40
		}

		public override float CurrentAvgAmp
		{
			 get { } //Length: 28
		}

		public override float CurrentPeakAmp
		{
			 get { } //Length: 12
			 set { } //Length: 16
		}

		internal LevelMeter`1(int samplingRate, int numChannels) { }

		public override void Dispose() { }

		public override float get_AccumAvgPeakAmp() { }

		public override float get_CurrentAvgAmp() { }

		public override float get_CurrentPeakAmp() { }

		public abstract T[] Process(T[] buf) { }

		public override void ResetAccumAvgPeakAmp() { }

		protected void set_CurrentPeakAmp(float value) { }

	}

	internal class LevelMeterDummy : ILevelMeter
	{

		public override float AccumAvgPeakAmp
		{
			 get { } //Length: 8
		}

		public override float CurrentAvgAmp
		{
			 get { } //Length: 8
		}

		public override float CurrentPeakAmp
		{
			 get { } //Length: 8
		}

		public LevelMeterDummy() { }

		public override float get_AccumAvgPeakAmp() { }

		public override float get_CurrentAvgAmp() { }

		public override float get_CurrentPeakAmp() { }

		public override void ResetAccumAvgPeakAmp() { }

	}

	internal class LevelMeterFloat : LevelMeter<Single>
	{

		public LevelMeterFloat(int samplingRate, int numChannels) { }

		public virtual Single[] Process(Single[] buf) { }

	}

	internal class LevelMeterShort : LevelMeter<Int16>
	{

		public LevelMeterShort(int samplingRate, int numChannels) { }

		public virtual Int16[] Process(Int16[] buf) { }

	}

	internal class Resampler : IProcessor<T>, IDisposable
	{
		protected T[] frameResampled; //Field offset: 0x0
		private int channels; //Field offset: 0x0

		public Resampler`1(int dstSize, int channels) { }

		public override void Dispose() { }

		public override T[] Process(T[] buf) { }

	}

	internal class TempoUp
	{
		private readonly int sizeofT; //Field offset: 0x0
		private int channels; //Field offset: 0x0
		private int skipGroup; //Field offset: 0x0
		private int skipFactor; //Field offset: 0x0
		private int sign; //Field offset: 0x0
		private int waveCnt; //Field offset: 0x0
		private bool skipping; //Field offset: 0x0

		public TempoUp`1() { }

		public void Begin(int channels, int changePerc, int skipGroup) { }

		public int End(T[] s) { }

		public int endFloat(Single[] s) { }

		public int endShort(Int16[] s) { }

		public int Process(T[] s, T[] d) { }

		private int processFloat(Single[] s, Single[] d) { }

		private int processShort(Int16[] s, Int16[] d) { }

	}

	internal class ToneAudioPusher : GeneratorPusher<T>
	{
		private double k; //Field offset: 0x0

		public ToneAudioPusher`1(int frequency = 440, int bufSizeMs = 100, int samplingRate = 48000, int channels = 1) { }

		protected virtual int Gen(T[] buf, long timeSamples) { }

	}

	internal class ToneAudioReader : GeneratorReader<T>
	{
		private double k; //Field offset: 0x0

		public ToneAudioReader`1(Func<Double> clockSec = null, double frequency = 440, int samplingRate = 48000, int channels = 1) { }

		protected virtual int Gen(T[] buf, long timeSamples) { }

	}

	internal abstract class VoiceDetector : IProcessor<T>, IDisposable, IVoiceDetector
	{
		[CompilerGenerated]
		private bool <On>k__BackingField; //Field offset: 0x0
		protected float norm; //Field offset: 0x0
		protected float threshold; //Field offset: 0x0
		private bool detected; //Field offset: 0x0
		[CompilerGenerated]
		private DateTime <DetectedTime>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private Action OnDetected; //Field offset: 0x0
		protected int activityDelay; //Field offset: 0x0
		protected int autoSilenceCounter; //Field offset: 0x0
		protected int valuesCountPerSec; //Field offset: 0x0
		protected int activityDelayValuesCount; //Field offset: 0x0

		public override event Action OnDetected
		{
			[CompilerGenerated]
			 add { } //Length: 156
			[CompilerGenerated]
			 remove { } //Length: 156
		}

		public override int ActivityDelayMs
		{
			 get { } //Length: 8
			 set { } //Length: 44
		}

		public override bool Detected
		{
			 get { } //Length: 8
			 set { } //Length: 152
		}

		public private override DateTime DetectedTime
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			private set { } //Length: 8
		}

		public override bool On
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 12
		}

		public override float Threshold
		{
			 get { } //Length: 12
			 set { } //Length: 16
		}

		internal VoiceDetector`1(int samplingRate, int numChannels) { }

		[CompilerGenerated]
		public override void add_OnDetected(Action value) { }

		public override void Dispose() { }

		public override int get_ActivityDelayMs() { }

		public override bool get_Detected() { }

		[CompilerGenerated]
		public override DateTime get_DetectedTime() { }

		[CompilerGenerated]
		public override bool get_On() { }

		public override float get_Threshold() { }

		public abstract T[] Process(T[] buf) { }

		[CompilerGenerated]
		public override void remove_OnDetected(Action value) { }

		public override void set_ActivityDelayMs(int value) { }

		protected void set_Detected(bool value) { }

		[CompilerGenerated]
		private void set_DetectedTime(DateTime value) { }

		[CompilerGenerated]
		public override void set_On(bool value) { }

		public override void set_Threshold(float value) { }

	}

	internal class VoiceDetectorCalibration : IProcessor<T>, IDisposable
	{
		private IVoiceDetector voiceDetector; //Field offset: 0x0
		private ILevelMeter levelMeter; //Field offset: 0x0
		private int valuesPerSec; //Field offset: 0x0
		protected int calibrateCount; //Field offset: 0x0
		private Action<Single> onCalibrated; //Field offset: 0x0

		public bool IsCalibrating
		{
			 get { } //Length: 16
		}

		public VoiceDetectorCalibration`1(IVoiceDetector voiceDetector, ILevelMeter levelMeter, int samplingRate, int channels) { }

		public void Calibrate(int durationMs, Action<Single> onCalibrated = null) { }

		public override void Dispose() { }

		public bool get_IsCalibrating() { }

		public override T[] Process(T[] buf) { }

	}

	internal class VoiceDetectorDummy : IVoiceDetector
	{
		[CompilerGenerated]
		private DateTime <DetectedTime>k__BackingField; //Field offset: 0x10

		public override event Action OnDetected
		{
			 add { } //Length: 4
			 remove { } //Length: 4
		}

		public override int ActivityDelayMs
		{
			 get { } //Length: 8
			 set { } //Length: 4
		}

		public override bool Detected
		{
			 get { } //Length: 8
		}

		public private override DateTime DetectedTime
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			private set { } //Length: 8
		}

		public override bool On
		{
			 get { } //Length: 8
			 set { } //Length: 4
		}

		public override float Threshold
		{
			 get { } //Length: 8
			 set { } //Length: 4
		}

		public VoiceDetectorDummy() { }

		public override void add_OnDetected(Action value) { }

		public override int get_ActivityDelayMs() { }

		public override bool get_Detected() { }

		[CompilerGenerated]
		public override DateTime get_DetectedTime() { }

		public override bool get_On() { }

		public override float get_Threshold() { }

		public override void remove_OnDetected(Action value) { }

		public override void set_ActivityDelayMs(int value) { }

		[CompilerGenerated]
		private void set_DetectedTime(DateTime value) { }

		public override void set_On(bool value) { }

		public override void set_Threshold(float value) { }

	}

	internal class VoiceDetectorFloat : VoiceDetector<Single>
	{

		public VoiceDetectorFloat(int samplingRate, int numChannels) { }

		public virtual Single[] Process(Single[] buffer) { }

	}

	internal class VoiceDetectorShort : VoiceDetector<Int16>
	{

		public VoiceDetectorShort(int samplingRate, int numChannels) { }

		public virtual Int16[] Process(Int16[] buffer) { }

	}

	internal class VoiceLevelDetectCalibrate : IProcessor<T>, IDisposable
	{
		[CompilerGenerated]
		private ILevelMeter <LevelMeter>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private IVoiceDetector <VoiceDetector>k__BackingField; //Field offset: 0x0
		private VoiceDetectorCalibration<T> calibration; //Field offset: 0x0

		public bool IsCalibrating
		{
			 get { } //Length: 40
		}

		public private ILevelMeter LevelMeter
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			private set { } //Length: 8
		}

		public private IVoiceDetector VoiceDetector
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			private set { } //Length: 8
		}

		public VoiceLevelDetectCalibrate`1(int samplingRate, int channels) { }

		public void Calibrate(int durationMs, Action<Single> onCalibrated = null) { }

		public override void Dispose() { }

		public bool get_IsCalibrating() { }

		[CompilerGenerated]
		public ILevelMeter get_LevelMeter() { }

		[CompilerGenerated]
		public IVoiceDetector get_VoiceDetector() { }

		public override T[] Process(T[] buf) { }

		[CompilerGenerated]
		private void set_LevelMeter(ILevelMeter value) { }

		[CompilerGenerated]
		private void set_VoiceDetector(IVoiceDetector value) { }

	}

	internal class WaveformAudioPusher : GeneratorPusher<T>
	{
		[CompilerGenerated]
		private T[] <Waveform>k__BackingField; //Field offset: 0x0

		public private T[] Waveform
		{
			[CompilerGenerated]
			private get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 8
		}

		public WaveformAudioPusher`1(int bufSizeMs = 100, int samplingRate = 48000, int channels = 1) { }

		protected virtual int Gen(T[] buf, long timeSamples) { }

		[CompilerGenerated]
		private T[] get_Waveform() { }

		[CompilerGenerated]
		public void set_Waveform(T[] value) { }

	}

	internal class WaveformAudioReader : GeneratorReader<T>
	{
		[CompilerGenerated]
		private T[] <Waveform>k__BackingField; //Field offset: 0x0

		public private T[] Waveform
		{
			[CompilerGenerated]
			private get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 8
		}

		public WaveformAudioReader`1(Func<Double> clockSec = null, int samplingRate = 48000, int channels = 1) { }

		protected virtual int Gen(T[] buf, long timeSamples) { }

		[CompilerGenerated]
		private T[] get_Waveform() { }

		[CompilerGenerated]
		public void set_Waveform(T[] value) { }

	}


	public static void Convert(Single[] src, Int16[] dst, int dstCount) { }

	public static void Convert(Int16[] src, Single[] dst, int dstCount) { }

	public static void ForceToStereo(T[] src, T[] dst, int srcChannels) { }

	public static void Resample(T[] src, T[] dst, int dstCount, int channels) { }

	public static void Resample(T[] src, int srcOffset, int srcCount, T[] dst, int dstOffset, int dstCount, int channels) { }

	public static void Resample(T[] src, int srcOffset, int srcCount, int srcChannels, T[] dst, int dstOffset, int dstCount, int dstChannels) { }

	public static void ResampleAndConvert(Int16[] src, Single[] dst, int dstCount, int channels) { }

	public static void ResampleAndConvert(Single[] src, Int16[] dst, int dstCount, int channels) { }

	public static int ToneToBuf(T[] buf, long timeSamples, int channels, double amp, double k, double phaseMod = 0) { }

	public static int ToneToBuf(T[] buf, int offset, int length, long timeSamples, int channels, double amp, double k, double phaseMod = 0) { }

	internal static string tostr(T[] x, int lim = 10) { }

	public static int WaveformToBuf(T[] buf, T[] waveform, long timePos) { }

}

