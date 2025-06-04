namespace Fusion.Photon.Realtime;

internal class RoomInfo
{
	public bool RemovedFromList; //Field offset: 0x10
	private Hashtable customProperties; //Field offset: 0x18
	protected int maxPlayers; //Field offset: 0x20
	protected int emptyRoomTtl; //Field offset: 0x24
	protected int playerTtl; //Field offset: 0x28
	protected String[] expectedUsers; //Field offset: 0x30
	protected bool isOpen; //Field offset: 0x38
	protected bool isVisible; //Field offset: 0x39
	protected bool autoCleanUp; //Field offset: 0x3A
	protected string name; //Field offset: 0x40
	public int masterClientId; //Field offset: 0x48
	protected String[] propertiesListedInLobby; //Field offset: 0x50
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <PlayerCount>k__BackingField; //Field offset: 0x58

	public Hashtable CustomProperties
	{
		 get { } //Length: 8
	}

	public bool IsOpen
	{
		 get { } //Length: 8
	}

	public bool IsVisible
	{
		 get { } //Length: 8
	}

	public int MaxPlayers
	{
		 get { } //Length: 8
	}

	public string Name
	{
		 get { } //Length: 8
	}

	public private int PlayerCount
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	protected private RoomInfo(string roomName, Hashtable roomProperties) { }

	public virtual bool Equals(object other) { }

	public Hashtable get_CustomProperties() { }

	public bool get_IsOpen() { }

	public bool get_IsVisible() { }

	public int get_MaxPlayers() { }

	public string get_Name() { }

	[CompilerGenerated]
	public int get_PlayerCount() { }

	public virtual int GetHashCode() { }

	protected private override void InternalCacheProperties(Hashtable propertiesToCache) { }

	[CompilerGenerated]
	private void set_PlayerCount(int value) { }

	public virtual string ToString() { }

	public string ToStringFull() { }

}

