namespace Photon.Voice;

public class PhotonAppSettings : ScriptableObject
{
	private static PhotonAppSettings instance; //Field offset: 0x0
	private const string SettingsFileName = "VoiceAppSettings"; //Field offset: 0x0
	private const string PhotonVoiceFolderGUID = "d3a9df3027b4a45679a2a3e978dde78e"; //Field offset: 0x0
	[Tooltip("Core Photon Server/Cloud settings.")]
	public AppSettings AppSettings; //Field offset: 0x18

	public static PhotonAppSettings Instance
	{
		 get { } //Length: 144
	}

	public PhotonAppSettings() { }

	public static PhotonAppSettings get_Instance() { }

	public static void LoadOrCreateSettings() { }

	public virtual string ToString() { }

	public void UseCloud(string cloudAppid, string code = "") { }

}

