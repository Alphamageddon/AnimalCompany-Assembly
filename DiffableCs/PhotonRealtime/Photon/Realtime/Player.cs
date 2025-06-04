namespace Photon.Realtime;

public class Player
{
	[CompilerGenerated]
	private Room <RoomReference>k__BackingField; //Field offset: 0x10
	private int actorNumber; //Field offset: 0x18
	public readonly bool IsLocal; //Field offset: 0x1C
	[CompilerGenerated]
	private bool <HasRejoined>k__BackingField; //Field offset: 0x1D
	private string nickName; //Field offset: 0x20
	[CompilerGenerated]
	private string <UserId>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private bool <IsInactive>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private Hashtable <CustomProperties>k__BackingField; //Field offset: 0x38
	public object TagObject; //Field offset: 0x40

	public int ActorNumber
	{
		 get { } //Length: 8
	}

	public Hashtable CustomProperties
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public internal bool HasRejoined
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 12
	}

	public private bool IsInactive
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public bool IsMasterClient
	{
		 get { } //Length: 36
	}

	public string NickName
	{
		 get { } //Length: 8
		 set { } //Length: 100
	}

	protected private Room RoomReference
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public internal string UserId
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	protected private Player(string nickName, int actorNumber, bool isLocal, Hashtable playerProperties) { }

	protected private Player(string nickName, int actorNumber, bool isLocal) { }

	protected private void ChangeLocalID(int newID) { }

	public virtual bool Equals(object p) { }

	public Player Get(int id) { }

	public int get_ActorNumber() { }

	[CompilerGenerated]
	public Hashtable get_CustomProperties() { }

	[CompilerGenerated]
	public bool get_HasRejoined() { }

	[CompilerGenerated]
	public bool get_IsInactive() { }

	public bool get_IsMasterClient() { }

	public string get_NickName() { }

	[CompilerGenerated]
	protected private Room get_RoomReference() { }

	[CompilerGenerated]
	public string get_UserId() { }

	public virtual int GetHashCode() { }

	public Player GetNext() { }

	public Player GetNextFor(int currentPlayerId) { }

	public Player GetNextFor(Player currentPlayer) { }

	protected private override void InternalCacheProperties(Hashtable properties) { }

	[CompilerGenerated]
	public void set_CustomProperties(Hashtable value) { }

	[CompilerGenerated]
	internal void set_HasRejoined(bool value) { }

	[CompilerGenerated]
	protected private void set_IsInactive(bool value) { }

	public void set_NickName(string value) { }

	[CompilerGenerated]
	protected private void set_RoomReference(Room value) { }

	[CompilerGenerated]
	internal void set_UserId(string value) { }

	public bool SetCustomProperties(Hashtable propertiesToSet, Hashtable expectedValues = null, WebFlags webFlags = null) { }

	private bool SetPlayerNameProperty() { }

	public virtual string ToString() { }

	public string ToStringFull() { }

}

