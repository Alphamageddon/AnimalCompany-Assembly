namespace Photon.Voice.Unity;

[AddComponentMenu("Photon Voice/Audio Changes Handler")]
[DisallowMultipleComponent]
[RequireComponent(typeof(Recorder))]
public class AudioChangesHandler : VoiceComponent
{
	private IAudioInChangeNotifier photonMicChangeNotifier; //Field offset: 0x28
	private Recorder recorder; //Field offset: 0x30
	[Tooltip("React to device change notification when Recorder is started.")]
	public bool HandleDeviceChange; //Field offset: 0x38
	[Tooltip("iOS: React to device change notification when Recorder is started.")]
	public bool HandleDeviceChangeIOS; //Field offset: 0x39
	[Tooltip("Android: React to device change notification when Recorder is started.")]
	public bool HandleDeviceChangeAndroid; //Field offset: 0x3A

	public AudioChangesHandler() { }

	protected virtual void Awake() { }

	private void OnAudioConfigChanged(bool deviceWasChanged) { }

	private void OnDestroy() { }

	private void OnDeviceChange() { }

	private void PhotonMicrophoneChangeDetected() { }

}

