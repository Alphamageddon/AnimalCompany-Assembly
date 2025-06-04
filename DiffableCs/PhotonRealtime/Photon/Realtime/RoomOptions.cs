namespace Photon.Realtime;

public class RoomOptions
{
	private bool isVisible; //Field offset: 0x10
	private bool isOpen; //Field offset: 0x11
	public int MaxPlayers; //Field offset: 0x14
	public int PlayerTtl; //Field offset: 0x18
	public int EmptyRoomTtl; //Field offset: 0x1C
	private bool cleanupCacheOnLeave; //Field offset: 0x20
	public Hashtable CustomRoomProperties; //Field offset: 0x28
	public String[] CustomRoomPropertiesForLobby; //Field offset: 0x30
	public String[] Plugins; //Field offset: 0x38
	[CompilerGenerated]
	private bool <SuppressRoomEvents>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private bool <SuppressPlayerInfo>k__BackingField; //Field offset: 0x41
	[CompilerGenerated]
	private bool <PublishUserId>k__BackingField; //Field offset: 0x42
	[CompilerGenerated]
	private bool <DeleteNullProperties>k__BackingField; //Field offset: 0x43
	private bool broadcastPropsChangeToAll; //Field offset: 0x44

	public bool BroadcastPropsChangeToAll
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool CleanupCacheOnLeave
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool DeleteNullProperties
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public bool IsOpen
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool IsVisible
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool PublishUserId
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public bool SuppressPlayerInfo
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public bool SuppressRoomEvents
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public RoomOptions() { }

	public bool get_BroadcastPropsChangeToAll() { }

	public bool get_CleanupCacheOnLeave() { }

	[CompilerGenerated]
	public bool get_DeleteNullProperties() { }

	public bool get_IsOpen() { }

	public bool get_IsVisible() { }

	[CompilerGenerated]
	public bool get_PublishUserId() { }

	[CompilerGenerated]
	public bool get_SuppressPlayerInfo() { }

	[CompilerGenerated]
	public bool get_SuppressRoomEvents() { }

	public void set_BroadcastPropsChangeToAll(bool value) { }

	public void set_CleanupCacheOnLeave(bool value) { }

	[CompilerGenerated]
	public void set_DeleteNullProperties(bool value) { }

	public void set_IsOpen(bool value) { }

	public void set_IsVisible(bool value) { }

	[CompilerGenerated]
	public void set_PublishUserId(bool value) { }

	[CompilerGenerated]
	public void set_SuppressPlayerInfo(bool value) { }

	[CompilerGenerated]
	public void set_SuppressRoomEvents(bool value) { }

}

