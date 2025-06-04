namespace Photon.Voice.Unity.UtilityScripts;

public class PhotonVoiceStatsGui : MonoBehaviour
{
	private bool statsWindowOn; //Field offset: 0x20
	private bool statsOn; //Field offset: 0x21
	private bool healthStatsVisible; //Field offset: 0x22
	private bool trafficStatsOn; //Field offset: 0x23
	private bool buttonsOn; //Field offset: 0x24
	private bool voiceStatsOn; //Field offset: 0x25
	private Rect statsRect; //Field offset: 0x28
	private int windowId; //Field offset: 0x38
	private PhotonPeer peer; //Field offset: 0x40
	private VoiceConnection voiceConnection; //Field offset: 0x48
	private VoiceClient voiceClient; //Field offset: 0x50

	public PhotonVoiceStatsGui() { }

	private void OnGUI() { }

	private void Start() { }

	private void TrafficStatsWindow(int windowId) { }

	private void Update() { }

}

