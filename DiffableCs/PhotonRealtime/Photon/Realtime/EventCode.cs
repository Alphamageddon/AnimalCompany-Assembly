namespace Photon.Realtime;

public class EventCode
{
	public const byte GameList = 230; //Field offset: 0x0
	public const byte GameListUpdate = 229; //Field offset: 0x0
	public const byte QueueState = 228; //Field offset: 0x0
	public const byte Match = 227; //Field offset: 0x0
	public const byte AppStats = 226; //Field offset: 0x0
	public const byte LobbyStats = 224; //Field offset: 0x0
	[Obsolete("TCP routing was removed after becoming obsolete.")]
	public const byte AzureNodeInfo = 210; //Field offset: 0x0
	public const byte Join = 255; //Field offset: 0x0
	public const byte Leave = 254; //Field offset: 0x0
	public const byte PropertiesChanged = 253; //Field offset: 0x0
	[Obsolete("Use PropertiesChanged now.")]
	public const byte SetProperties = 253; //Field offset: 0x0
	public const byte ErrorInfo = 251; //Field offset: 0x0
	public const byte CacheSliceChanged = 250; //Field offset: 0x0
	public const byte AuthEvent = 223; //Field offset: 0x0

	public EventCode() { }

}

