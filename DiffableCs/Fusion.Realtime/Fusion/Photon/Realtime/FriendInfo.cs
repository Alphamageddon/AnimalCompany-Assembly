namespace Fusion.Photon.Realtime;

internal class FriendInfo
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private string <UserId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <IsOnline>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private string <Room>k__BackingField; //Field offset: 0x20

	public bool IsInRoom
	{
		 get { } //Length: 40
	}

	public private bool IsOnline
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 12
	}

	[Obsolete("Use UserId.")]
	public string Name
	{
		 get { } //Length: 8
	}

	public private string Room
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private string UserId
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public FriendInfo() { }

	public bool get_IsInRoom() { }

	[CompilerGenerated]
	public bool get_IsOnline() { }

	public string get_Name() { }

	[CompilerGenerated]
	public string get_Room() { }

	[CompilerGenerated]
	public string get_UserId() { }

	[CompilerGenerated]
	protected private void set_IsOnline(bool value) { }

	[CompilerGenerated]
	protected private void set_Room(string value) { }

	[CompilerGenerated]
	protected private void set_UserId(string value) { }

	public virtual string ToString() { }

}

