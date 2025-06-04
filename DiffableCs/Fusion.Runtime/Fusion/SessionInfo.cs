namespace Fusion;

public class SessionInfo
{
	[CompilerGenerated]
	private string <Name>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <Region>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private ReadOnlyDictionary<String, SessionProperty> <Properties>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private int <PlayerCount>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private int <MaxPlayers>k__BackingField; //Field offset: 0x2C
	internal bool _isValid; //Field offset: 0x30
	internal bool _isOpen; //Field offset: 0x31
	internal bool _isVisible; //Field offset: 0x32
	private readonly NetworkRunner _runner; //Field offset: 0x38

	public bool IsOpen
	{
		 get { } //Length: 8
		 set { } //Length: 148
	}

	public bool IsValid
	{
		 get { } //Length: 8
	}

	public bool IsVisible
	{
		 get { } //Length: 8
		 set { } //Length: 148
	}

	public internal int MaxPlayers
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	public internal string Name
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	public internal int PlayerCount
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	public internal ReadOnlyDictionary<String, SessionProperty> Properties
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	public internal string Region
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	internal SessionInfo(NetworkRunner runner = null) { }

	public bool get_IsOpen() { }

	public bool get_IsValid() { }

	public bool get_IsVisible() { }

	[CompilerGenerated]
	public int get_MaxPlayers() { }

	[CompilerGenerated]
	public string get_Name() { }

	[CompilerGenerated]
	public int get_PlayerCount() { }

	[CompilerGenerated]
	public ReadOnlyDictionary<String, SessionProperty> get_Properties() { }

	[CompilerGenerated]
	public string get_Region() { }

	public static bool op_Implicit(SessionInfo sessionInfo) { }

	public void set_IsOpen(bool value) { }

	public void set_IsVisible(bool value) { }

	[CompilerGenerated]
	internal void set_MaxPlayers(int value) { }

	[CompilerGenerated]
	internal void set_Name(string value) { }

	[CompilerGenerated]
	internal void set_PlayerCount(int value) { }

	[CompilerGenerated]
	internal void set_Properties(ReadOnlyDictionary<String, SessionProperty> value) { }

	[CompilerGenerated]
	internal void set_Region(string value) { }

	public virtual string ToString() { }

	public bool UpdateCustomProperties(Dictionary<String, SessionProperty> customProperties) { }

}

