namespace Photon.Realtime;

[HelpURL("https://doc.photonengine.com/en-us/pun/v2/getting-started/initial-setup")]
public class PhotonAppSettings : ScriptableObject
{
	private static PhotonAppSettings instance; //Field offset: 0x0
	[Tooltip("Core Photon Server/Cloud settings.")]
	public AppSettings AppSettings; //Field offset: 0x18

	public private static PhotonAppSettings Instance
	{
		 get { } //Length: 144
		private set { } //Length: 76
	}

	public PhotonAppSettings() { }

	public static PhotonAppSettings get_Instance() { }

	public static void LoadOrCreateSettings() { }

	private static void set_Instance(PhotonAppSettings value) { }

}

