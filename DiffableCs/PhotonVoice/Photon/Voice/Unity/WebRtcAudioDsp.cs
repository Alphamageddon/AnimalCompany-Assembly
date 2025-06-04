namespace Photon.Voice.Unity;

[AddComponentMenu("Photon Voice/WebRTC Audio DSP")]
[DisallowMultipleComponent]
[RequireComponent(typeof(Recorder))]
public class WebRtcAudioDsp : VoiceComponent
{
	private static readonly Dictionary<AudioSpeakerMode, Int32> channelsMap; //Field offset: 0x0
	[SerializeField]
	private bool aec; //Field offset: 0x28
	[SerializeField]
	private bool aecHighPass; //Field offset: 0x29
	[SerializeField]
	private bool agc; //Field offset: 0x2A
	[Range(0, 90)]
	[SerializeField]
	private int agcCompressionGain; //Field offset: 0x2C
	[Range(0, 31)]
	[SerializeField]
	private int agcTargetLevel; //Field offset: 0x30
	[SerializeField]
	private bool vad; //Field offset: 0x34
	[SerializeField]
	private bool highPass; //Field offset: 0x35
	private bool bypass; //Field offset: 0x36
	[SerializeField]
	private bool noiseSuppression; //Field offset: 0x37
	[SerializeField]
	private int reverseStreamDelayMs; //Field offset: 0x38
	private int reverseChannels; //Field offset: 0x3C
	private WebRTCAudioProcessor proc; //Field offset: 0x40
	private LocalVoiceAudioShort localVoice; //Field offset: 0x48
	private int outputSampleRate; //Field offset: 0x50

	public bool AEC
	{
		 get { } //Length: 8
		 set { } //Length: 28
	}

	public bool AecHighPass
	{
		 get { } //Length: 8
		 set { } //Length: 28
	}

	public bool AGC
	{
		 get { } //Length: 8
		 set { } //Length: 28
	}

	public int AgcCompressionGain
	{
		 get { } //Length: 8
		 set { } //Length: 24
	}

	public int AgcTargetLevel
	{
		 get { } //Length: 8
		 set { } //Length: 24
	}

	public bool Bypass
	{
		 get { } //Length: 8
		 set { } //Length: 28
	}

	public bool HighPass
	{
		 get { } //Length: 8
		 set { } //Length: 28
	}

	public bool IsSupported
	{
		 get { } //Length: 8
	}

	public bool NoiseSuppression
	{
		 get { } //Length: 8
		 set { } //Length: 52
	}

	public int ReverseStreamDelayMs
	{
		 get { } //Length: 8
		 set { } //Length: 24
	}

	public bool VAD
	{
		 get { } //Length: 8
		 set { } //Length: 28
	}

	private static WebRtcAudioDsp() { }

	public WebRtcAudioDsp() { }

	public void AdjustVoiceInfo(ref VoiceInfo voiceInfo, ref AudioSampleType st) { }

	private void applyToProc() { }

	protected virtual void Awake() { }

	public bool get_AEC() { }

	public bool get_AecHighPass() { }

	public bool get_AGC() { }

	public int get_AgcCompressionGain() { }

	public int get_AgcTargetLevel() { }

	public bool get_Bypass() { }

	public bool get_HighPass() { }

	public bool get_IsSupported() { }

	public bool get_NoiseSuppression() { }

	public int get_ReverseStreamDelayMs() { }

	public bool get_VAD() { }

	private void OnAudioConfigurationChanged(bool deviceWasChanged) { }

	private void OnAudioOutFrameFloat(Single[] data, int outChannels) { }

	private void OnDestroy() { }

	private void PhotonVoiceCreated(PhotonVoiceCreatedParams p) { }

	private void PhotonVoiceRemoved() { }

	private void Restart() { }

	public void set_AEC(bool value) { }

	public void set_AecHighPass(bool value) { }

	public void set_AGC(bool value) { }

	public void set_AgcCompressionGain(int value) { }

	public void set_AgcTargetLevel(int value) { }

	public void set_Bypass(bool value) { }

	public void set_HighPass(bool value) { }

	public void set_NoiseSuppression(bool value) { }

	public void set_ReverseStreamDelayMs(int value) { }

	public void set_VAD(bool value) { }

	private void setOutputListener(bool set) { }

	private void Start() { }

	private void StartProc(LocalVoiceAudioShort v) { }

	private void StopProc(LocalVoiceAudioShort v) { }

}

