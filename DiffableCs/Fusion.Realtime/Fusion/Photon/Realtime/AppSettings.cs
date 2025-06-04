namespace Fusion.Photon.Realtime;

public class AppSettings
{
	[InlineHelp]
	public string AppIdRealtime; //Field offset: 0x10
	[InlineHelp]
	public string AppIdFusion; //Field offset: 0x18
	[InlineHelp]
	public string AppIdChat; //Field offset: 0x20
	[InlineHelp]
	public string AppIdVoice; //Field offset: 0x28
	[InlineHelp]
	public string AppVersion; //Field offset: 0x30
	[InlineHelp]
	public bool UseNameServer; //Field offset: 0x38
	[InlineHelp]
	public string FixedRegion; //Field offset: 0x40
	[InlineHelp]
	public string BestRegionSummaryFromStorage; //Field offset: 0x48
	[InlineHelp]
	public string Server; //Field offset: 0x50
	[InlineHelp]
	public int Port; //Field offset: 0x58
	[InlineHelp]
	public string ProxyServer; //Field offset: 0x60
	[Header("Miscellaneous")]
	[InlineHelp]
	public ConnectionProtocol Protocol; //Field offset: 0x68
	[InlineHelp]
	public bool EnableProtocolFallback; //Field offset: 0x69
	[InlineHelp]
	public AuthModeOption AuthMode; //Field offset: 0x6C
	[InlineHelp]
	public bool EnableLobbyStatistics; //Field offset: 0x70
	[InlineHelp]
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

	public AppSettings GetCopy() { }

	private string HideAppId(string appId) { }

	public static bool IsAppId(string val) { }

	public string ToStringFull() { }

}

