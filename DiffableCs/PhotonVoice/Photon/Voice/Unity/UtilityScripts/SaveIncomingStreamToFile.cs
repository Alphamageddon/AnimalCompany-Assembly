namespace Photon.Voice.Unity.UtilityScripts;

[DisallowMultipleComponent]
[RequireComponent(typeof(VoiceConnection))]
public class SaveIncomingStreamToFile : VoiceComponent
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public WaveWriter waveWriter; //Field offset: 0x10
		public SaveIncomingStreamToFile <>4__this; //Field offset: 0x18

		public <>c__DisplayClass5_0() { }

		internal void <OnRemoteVoiceAdded>b__0(FrameOut<Single> f) { }

		internal void <OnRemoteVoiceAdded>b__1() { }

	}

	private VoiceConnection voiceConnection; //Field offset: 0x28
	[SerializeField]
	private bool muteLocalSpeaker; //Field offset: 0x30

	public SaveIncomingStreamToFile() { }

	protected virtual void Awake() { }

	private string GetFilePath(RemoteVoiceLink remoteVoiceLink) { }

	private void OnDestroy() { }

	private void OnRemoteVoiceAdded(RemoteVoiceLink remoteVoiceLink) { }

	private void OnSpeakerLinked(Speaker speaker) { }

}

