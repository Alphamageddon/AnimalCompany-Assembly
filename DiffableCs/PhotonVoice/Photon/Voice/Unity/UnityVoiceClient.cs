namespace Photon.Voice.Unity;

[AddComponentMenu("Photon Voice/Unity Voice Client")]
[HelpURL("https://doc.photonengine.com/en-us/voice/v2/getting-started/voice-intro")]
public class UnityVoiceClient : VoiceConnection
{
	[SerializeField]
	public bool UseVoiceAppSettings; //Field offset: 0xC4

	public virtual bool AlwaysUsePrimaryRecorder
	{
		 get { } //Length: 8
	}

	public UnityVoiceClient() { }

	public virtual bool ConnectUsingSettings(AppSettings overwriteSettings = null) { }

	public virtual bool get_AlwaysUsePrimaryRecorder() { }

	protected virtual Speaker InstantiateSpeakerForRemoteVoice(int playerId, byte voiceId, object userData) { }

	protected override void Start() { }

}

