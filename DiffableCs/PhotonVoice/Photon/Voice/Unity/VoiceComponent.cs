namespace Photon.Voice.Unity;

[HelpURL("https://doc.photonengine.com/en-us/voice/v2")]
public abstract class VoiceComponent : MonoBehaviour
{
	private VoiceComponentImpl impl; //Field offset: 0x20

	protected ILogger Logger
	{
		 get { } //Length: 28
	}

	public string Name
	{
		 set { } //Length: 60
	}

	public VoiceLogger VoiceLogger
	{
		 get { } //Length: 28
	}

	protected VoiceComponent() { }

	protected override void Awake() { }

	protected ILogger get_Logger() { }

	public VoiceLogger get_VoiceLogger() { }

	public void set_Name(string value) { }

}

