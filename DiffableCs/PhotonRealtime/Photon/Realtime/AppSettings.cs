namespace Photon.Realtime;

public class AppSettings
{
	public string AppIdRealtime; //Field offset: 0x10
	public string AppIdFusion; //Field offset: 0x18
	public string AppIdChat; //Field offset: 0x20
	public string AppIdVoice; //Field offset: 0x28
	public string AppVersion; //Field offset: 0x30
	public bool UseNameServer; //Field offset: 0x38
	public string FixedRegion; //Field offset: 0x40
	public string BestRegionSummaryFromStorage; //Field offset: 0x48
	public string Server; //Field offset: 0x50
	public int Port; //Field offset: 0x58
	public string ProxyServer; //Field offset: 0x60
	public ConnectionProtocol Protocol; //Field offset: 0x68
	public bool EnableProtocolFallback; //Field offset: 0x69
	public AuthModeOption AuthMode; //Field offset: 0x6C
	public bool EnableLobbyStatistics; //Field offset: 0x70
	public DebugLevel NetworkLogging; //Field offset: 0x71

	public bool IsBestRegion
	{
		 get { } //Length: 28
	}

	public bool IsDefaultNameServer
	{
		 get { } //Length: 28
	}

	public bool IsDefaultPort
	{
		 get { } //Length: 16
	}

	public bool IsMasterServerAddress
	{
		 get { } //Length: 16
	}

	public AppSettings() { }

	public AppSettings CopyTo(AppSettings d) { }

	public bool get_IsBestRegion() { }

	public bool get_IsDefaultNameServer() { }

	public bool get_IsDefaultPort() { }

	public bool get_IsMasterServerAddress() { }

	private string HideAppId(string appId) { }

	public static bool IsAppId(string val) { }

	public string ToStringFull() { }

}

