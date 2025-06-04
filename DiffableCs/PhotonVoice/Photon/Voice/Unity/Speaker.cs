namespace Photon.Voice.Unity;

[AddComponentMenu("Photon Voice/Speaker")]
[DisallowMultipleComponent]
[RequireComponent(typeof(AudioSource))]
public class Speaker : VoiceComponent
{
	protected IAudioOut<Single> audioOutput; //Field offset: 0x28
	[SerializeField]
	protected PlayDelayConfig playDelayConfig; //Field offset: 0x30
	[SerializeField]
	protected bool restartOnDeviceChange; //Field offset: 0x40
	[CompilerGenerated]
	private Action<Speaker> <OnRemoteVoiceRemoveAction>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private RemoteVoiceLink <RemoteVoice>k__BackingField; //Field offset: 0x50
	private int restartPlaybackPending; //Field offset: 0x58

	public bool IsLinked
	{
		 get { } //Length: 16
	}

	public bool IsPlaying
	{
		 get { } //Length: 172
	}

	public int Lag
	{
		 get { } //Length: 176
	}

	public Action<Speaker> OnRemoteVoiceRemoveAction
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public int PlayDelay
	{
		 get { } //Length: 8
		 set { } //Length: 60
	}

	public PlayDelayConfig PlayDelayConfig
	{
		 get { } //Length: 12
		 set { } //Length: 56
	}

	public private RemoteVoiceLink RemoteVoice
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public bool RestartOnDeviceChange
	{
		 get { } //Length: 8
		 set { } //Length: 200
	}

	public Speaker() { }

	private void AudioConfigurationChangeHandler(bool deviceWasChanged) { }

	protected virtual void Awake() { }

	protected override IAudioOut<Single> CreateAudioOut() { }

	public bool get_IsLinked() { }

	public bool get_IsPlaying() { }

	public int get_Lag() { }

	[CompilerGenerated]
	public Action<Speaker> get_OnRemoteVoiceRemoveAction() { }

	public int get_PlayDelay() { }

	public PlayDelayConfig get_PlayDelayConfig() { }

	[CompilerGenerated]
	public RemoteVoiceLink get_RemoteVoice() { }

	public bool get_RestartOnDeviceChange() { }

	private void Initialize() { }

	internal bool Link(RemoteVoiceLink stream) { }

	private void OnAudioFrame(FrameOut<Single> frame) { }

	protected override void OnDestroy() { }

	private void OnRemoteVoiceRemove() { }

	public void RestartPlayback() { }

	[CompilerGenerated]
	public void set_OnRemoteVoiceRemoveAction(Action<Speaker> value) { }

	public void set_PlayDelay(int value) { }

	public void set_PlayDelayConfig(PlayDelayConfig value) { }

	[CompilerGenerated]
	private void set_RemoteVoice(RemoteVoiceLink value) { }

	public void set_RestartOnDeviceChange(bool value) { }

	private bool StartPlayback() { }

	private void StopPlayback() { }

	private void Unlink() { }

	protected void Update() { }

}

