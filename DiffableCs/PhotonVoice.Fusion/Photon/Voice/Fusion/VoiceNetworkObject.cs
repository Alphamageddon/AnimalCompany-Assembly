namespace Photon.Voice.Fusion;

[AddComponentMenu("Photon Voice/Fusion/Voice Network Object")]
[NetworkBehaviourWeaved(0)]
public class VoiceNetworkObject : NetworkBehaviour
{
	private VoiceComponentImpl voiceComponentImpl; //Field offset: 0x80
	private VoiceConnection voiceConnection; //Field offset: 0x88
	[CompilerGenerated]
	private Recorder <RecorderInUse>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private Speaker <SpeakerInUse>k__BackingField; //Field offset: 0x98

	public bool IsLocal
	{
		 get { } //Length: 76
	}

	public bool IsRecording
	{
		 get { } //Length: 136
	}

	public bool IsSpeaking
	{
		 get { } //Length: 136
	}

	protected ILogger Logger
	{
		 get { } //Length: 28
	}

	public private Recorder RecorderInUse
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private Speaker SpeakerInUse
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public VoiceLogger VoiceLogger
	{
		 get { } //Length: 28
	}

	public VoiceNetworkObject() { }

	[WeaverGenerated]
	public virtual void CopyBackingFieldsToState(bool unnamed_param_0) { }

	[WeaverGenerated]
	public virtual void CopyStateToBackingFields() { }

	public virtual void Despawned(NetworkRunner runner, bool hasState) { }

	public bool get_IsLocal() { }

	public bool get_IsRecording() { }

	public bool get_IsSpeaking() { }

	protected ILogger get_Logger() { }

	[CompilerGenerated]
	public Recorder get_RecorderInUse() { }

	[CompilerGenerated]
	public Speaker get_SpeakerInUse() { }

	public VoiceLogger get_VoiceLogger() { }

	private object GetUserData() { }

	[CompilerGenerated]
	private void set_RecorderInUse(Recorder value) { }

	[CompilerGenerated]
	private void set_SpeakerInUse(Speaker value) { }

	private void SetupRecorder() { }

	private void SetupSpeaker() { }

	public virtual void Spawned() { }

}

