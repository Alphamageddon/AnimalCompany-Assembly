namespace Photon.Voice.Unity;

[AddComponentMenu("Photon Voice/Voice Logger")]
[DisallowMultipleComponent]
public class VoiceLogger : MonoBehaviour
{
	public LogLevel LogLevel; //Field offset: 0x20

	public VoiceLogger() { }

	public static VoiceLogger CreateRootLogger() { }

	public static VoiceLogger FindLogger(GameObject gameObject) { }

	private void Start() { }

}

