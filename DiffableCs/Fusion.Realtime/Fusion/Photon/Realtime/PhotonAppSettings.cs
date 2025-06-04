namespace Fusion.Photon.Realtime;

[CreateAssetMenu(menuName = "Fusion/Photon Application Settings", fileName = "PhotonAppSettings")]
[FusionGlobalScriptableObject("Assets/Photon/Fusion/Resources/PhotonAppSettings.asset")]
[HelpURL("https://doc.photonengine.com/en-us/pun/v2/getting-started/initial-setup")]
public class PhotonAppSettings : FusionGlobalScriptableObject<PhotonAppSettings>
{
	[InlineHelp]
	public FusionAppSettings AppSettings; //Field offset: 0x20

	public static PhotonAppSettings Global
	{
		 get { } //Length: 64
	}

	public static bool IsGlobalLoaded
	{
		 get { } //Length: 64
	}

	public PhotonAppSettings() { }

	public static PhotonAppSettings get_Global() { }

	public static bool get_IsGlobalLoaded() { }

	public static bool TryGetGlobal(out PhotonAppSettings settings) { }

}

