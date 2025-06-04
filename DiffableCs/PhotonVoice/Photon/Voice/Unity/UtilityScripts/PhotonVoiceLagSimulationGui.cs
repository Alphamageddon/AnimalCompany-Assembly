namespace Photon.Voice.Unity.UtilityScripts;

[RequireComponent(typeof(VoiceConnection))]
public class PhotonVoiceLagSimulationGui : MonoBehaviour
{
	private VoiceConnection voiceConnection; //Field offset: 0x20
	private Rect windowRect; //Field offset: 0x28
	private int windowId; //Field offset: 0x38
	private bool visible; //Field offset: 0x3C
	private PhotonPeer peer; //Field offset: 0x40
	private float debugLostPercent; //Field offset: 0x48

	public PhotonVoiceLagSimulationGui() { }

	private void NetSimHasNoPeerWindow(int windowId) { }

	private void NetSimWindow(int windowId) { }

	private void OnGUI() { }

	public void Start() { }

}

