namespace Photon.Voice.Unity;

[AddComponentMenu("Photon Voice/Recorder")]
[DisallowMultipleComponent]
[HelpURL("https://doc.photonengine.com/en-us/voice/v2/getting-started/recorder")]
public class Recorder : VoiceComponent
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<IAudioDesc> <>9__134_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal IAudioDesc <CreateLocalVoiceAudioAndSource>b__134_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass127_0
	{
		public Recorder <>4__this; //Field offset: 0x10
		public Action<Single> detectionEndedCallback; //Field offset: 0x18

		public <>c__DisplayClass127_0() { }

		internal void <VoiceDetectorCalibrate>b__0(float newThreshold) { }

	}

	internal enum InputSourceType
	{
		Microphone = 0,
		AudioClip = 1,
		Factory = 2,
	}

	internal enum MicType
	{
		Unity = 0,
		Photon = 1,
	}

	public const int MIN_OPUS_BITRATE = 6000; //Field offset: 0x0
	public const int MAX_OPUS_BITRATE = 510000; //Field offset: 0x0
	[SerializeField]
	private bool voiceDetection; //Field offset: 0x28
	[SerializeField]
	private float voiceDetectionThreshold; //Field offset: 0x2C
	[SerializeField]
	private int voiceDetectionDelayMs; //Field offset: 0x30
	private object userData; //Field offset: 0x38
	private LocalVoice voice; //Field offset: 0x40
	private IAudioDesc inputSource; //Field offset: 0x48
	private VoiceConnection voiceConnection; //Field offset: 0x50
	[FormerlySerializedAs("audioGroup")]
	[SerializeField]
	private byte interestGroup; //Field offset: 0x58
	[SerializeField]
	private bool useTargetPlayers; //Field offset: 0x59
	[SerializeField]
	private Int32[] targetPlayers; //Field offset: 0x60
	[SerializeField]
	private bool debugEchoMode; //Field offset: 0x68
	[SerializeField]
	private bool reliableMode; //Field offset: 0x69
	[SerializeField]
	private bool encrypt; //Field offset: 0x6A
	[SerializeField]
	private bool transmitEnabled; //Field offset: 0x6B
	[SerializeField]
	private SamplingRate samplingRate; //Field offset: 0x6C
	[SerializeField]
	private FrameDuration frameDuration; //Field offset: 0x70
	[Range(6000, 510000)]
	[SerializeField]
	private int bitrate; //Field offset: 0x74
	[SerializeField]
	private InputSourceType sourceType; //Field offset: 0x78
	[SerializeField]
	private MicType microphoneType; //Field offset: 0x7C
	[SerializeField]
	private AudioClip audioClip; //Field offset: 0x80
	[SerializeField]
	private bool loopAudioClip; //Field offset: 0x88
	[SerializeField]
	private bool recordingEnabled; //Field offset: 0x89
	private Func<IAudioDesc> inputFactory; //Field offset: 0x90
	[SerializeField]
	private AudioSessionParameters audioSessionParameters; //Field offset: 0x98
	[SerializeField]
	private AndroidAudioInParameters androidMicrophoneSettings; //Field offset: 0xA8
	private bool isPausedOrInBackground; //Field offset: 0xAB
	[SerializeField]
	private bool stopRecordingWhenPaused; //Field offset: 0xAC
	[SerializeField]
	private bool useOnAudioFilterRead; //Field offset: 0xAD
	[SerializeField]
	private bool useMicrophoneTypeFallback; //Field offset: 0xAE
	[SerializeField]
	private bool recordWhenJoined; //Field offset: 0xAF
	private DeviceInfo microphoneDevice; //Field offset: 0xB0
	private int microphoneDeviceChangePending; //Field offset: 0xD8
	private int restartRecordingPending; //Field offset: 0xDC

	public bool AndroidMicrophoneAEC
	{
		 get { } //Length: 8
	}

	public bool AndroidMicrophoneAGC
	{
		 get { } //Length: 8
	}

	public bool AndroidMicrophoneNS
	{
		 get { } //Length: 8
	}

	public AudioClip AudioClip
	{
		 get { } //Length: 8
		 set { } //Length: 416
	}

	public int Bitrate
	{
		 get { } //Length: 8
		 set { } //Length: 808
	}

	public bool DebugEchoMode
	{
		 get { } //Length: 28
		 set { } //Length: 56
	}

	public bool Encrypt
	{
		 get { } //Length: 28
		 set { } //Length: 36
	}

	public FrameDuration FrameDuration
	{
		 get { } //Length: 8
		 set { } //Length: 356
	}

	public Func<IAudioDesc> InputFactory
	{
		 get { } //Length: 8
		 set { } //Length: 376
	}

	public byte InterestGroup
	{
		 get { } //Length: 28
		 set { } //Length: 32
	}

	public bool IsCurrentlyTransmitting
	{
		 get { } //Length: 56
	}

	public ILevelMeter LevelMeter
	{
		 get { } //Length: 196
	}

	public bool LoopAudioClip
	{
		 get { } //Length: 8
		 set { } //Length: 436
	}

	public DeviceInfo MicrophoneDevice
	{
		 get { } //Length: 20
		 set { } //Length: 496
	}

	public MicType MicrophoneType
	{
		 get { } //Length: 108
		 set { } //Length: 364
	}

	public bool RecordingEnabled
	{
		 get { } //Length: 8
		 set { } //Length: 40
	}

	public bool RecordWhenJoined
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool ReliableMode
	{
		 get { } //Length: 28
		 set { } //Length: 36
	}

	public SamplingRate SamplingRate
	{
		 get { } //Length: 8
		 set { } //Length: 356
	}

	public InputSourceType SourceType
	{
		 get { } //Length: 8
		 set { } //Length: 356
	}

	public bool StopRecordingWhenPaused
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public Int32[] TargetPlayers
	{
		 get { } //Length: 28
		 set { } //Length: 64
	}

	public bool TransmitEnabled
	{
		 get { } //Length: 8
		 set { } //Length: 172
	}

	public bool UseMicrophoneTypeFallback
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool UseOnAudioFilterRead
	{
		 get { } //Length: 8
		 set { } //Length: 376
	}

	public object UserData
	{
		 get { } //Length: 8
		 set { } //Length: 356
	}

	protected ILocalVoiceAudio voiceAudio
	{
		 get { } //Length: 72
	}

	public bool VoiceDetection
	{
		 get { } //Length: 8
		 set { } //Length: 224
	}

	public int VoiceDetectionDelayMs
	{
		 get { } //Length: 8
		 set { } //Length: 220
	}

	public float VoiceDetectionThreshold
	{
		 get { } //Length: 8
		 set { } //Length: 560
	}

	public IVoiceDetector VoiceDetector
	{
		 get { } //Length: 192
	}

	public bool VoiceDetectorCalibrating
	{
		 get { } //Length: 208
	}

	public Recorder() { }

	private LocalVoice CreateLocalVoiceAudioAndSource() { }

	internal bool Deinit(VoiceConnection connection) { }

	public bool get_AndroidMicrophoneAEC() { }

	public bool get_AndroidMicrophoneAGC() { }

	public bool get_AndroidMicrophoneNS() { }

	public AudioClip get_AudioClip() { }

	public int get_Bitrate() { }

	public bool get_DebugEchoMode() { }

	public bool get_Encrypt() { }

	public FrameDuration get_FrameDuration() { }

	public Func<IAudioDesc> get_InputFactory() { }

	public byte get_InterestGroup() { }

	public bool get_IsCurrentlyTransmitting() { }

	public ILevelMeter get_LevelMeter() { }

	public bool get_LoopAudioClip() { }

	public DeviceInfo get_MicrophoneDevice() { }

	public MicType get_MicrophoneType() { }

	public bool get_RecordingEnabled() { }

	public bool get_RecordWhenJoined() { }

	public bool get_ReliableMode() { }

	public SamplingRate get_SamplingRate() { }

	public InputSourceType get_SourceType() { }

	public bool get_StopRecordingWhenPaused() { }

	public Int32[] get_TargetPlayers() { }

	public bool get_TransmitEnabled() { }

	public bool get_UseMicrophoneTypeFallback() { }

	public bool get_UseOnAudioFilterRead() { }

	public object get_UserData() { }

	protected ILocalVoiceAudio get_voiceAudio() { }

	public bool get_VoiceDetection() { }

	public int get_VoiceDetectionDelayMs() { }

	public float get_VoiceDetectionThreshold() { }

	public IVoiceDetector get_VoiceDetector() { }

	public bool get_VoiceDetectorCalibrating() { }

	private void HandleApplicationPause(bool paused) { }

	private void HandleDeviceChange() { }

	internal bool Init(VoiceConnection connection) { }

	internal void MicrophoneDeviceChangeDetected() { }

	private void OnApplicationFocus(bool focused) { }

	private void OnApplicationPause(bool paused) { }

	private void OnDestroy() { }

	public bool ResetLocalAudio() { }

	public bool RestartRecording() { }

	protected override void SendPhotonVoiceCreatedMessage() { }

	public void set_AudioClip(AudioClip value) { }

	public void set_Bitrate(int value) { }

	public void set_DebugEchoMode(bool value) { }

	public void set_Encrypt(bool value) { }

	public void set_FrameDuration(FrameDuration value) { }

	public void set_InputFactory(Func<IAudioDesc> value) { }

	public void set_InterestGroup(byte value) { }

	public void set_LoopAudioClip(bool value) { }

	public void set_MicrophoneDevice(DeviceInfo value) { }

	public void set_MicrophoneType(MicType value) { }

	public void set_RecordingEnabled(bool value) { }

	public void set_RecordWhenJoined(bool value) { }

	public void set_ReliableMode(bool value) { }

	public void set_SamplingRate(SamplingRate value) { }

	public void set_SourceType(InputSourceType value) { }

	public void set_StopRecordingWhenPaused(bool value) { }

	public void set_TargetPlayers(Int32[] value) { }

	public void set_TransmitEnabled(bool value) { }

	public void set_UseMicrophoneTypeFallback(bool value) { }

	public void set_UseOnAudioFilterRead(bool value) { }

	public void set_UserData(object value) { }

	public void set_VoiceDetection(bool value) { }

	public void set_VoiceDetectionDelayMs(int value) { }

	public void set_VoiceDetectionThreshold(float value) { }

	public bool SetAndroidNativeMicrophoneSettings(bool aec = false, bool agc = false, bool ns = false) { }

	public bool SetIosAudioSessionParameters(AudioSessionCategory category, AudioSessionMode mode, AudioSessionCategoryOption[] options) { }

	public bool SetIosAudioSessionParameters(AudioSessionParameters asp) { }

	private void StartRecording() { }

	private void StopRecording() { }

	protected void Update() { }

	public void VoiceDetectorCalibrate(int durationMs, Action<Single> detectionEndedCallback = null) { }

}

