namespace Photon.Voice.Unity;

[AddComponentMenu("Photon Voice/Recorder Preset")]
public class RecorderPreset : VoiceComponent
{
	internal struct DSP
	{
		[Tooltip("Acoustic Echo Cancellation")]
		public bool AEC; //Field offset: 0x0
		[Tooltip("Voice Activity Detection")]
		public bool VAD; //Field offset: 0x1

	}

	[Tooltip("On which platform to apply the filter.")]
	public RuntimePlatform Platform; //Field offset: 0x28
	[Header("Overrides:")]
	[Tooltip("Which microphone API to use when the Source is set to Microphone.")]
	public MicType MicrophoneType; //Field offset: 0x2C
	[Tooltip("Enable WebRtcAudioDsp component.")]
	public bool DSPEnabled; //Field offset: 0x30
	public DSP DSPSettings; //Field offset: 0x31

	public RecorderPreset() { }

	protected virtual void Awake() { }

}

