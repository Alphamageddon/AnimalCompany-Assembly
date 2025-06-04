namespace Nakama;

internal class ChannelJoinMessage
{
	[CompilerGenerated]
	private bool <Hidden>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private bool <Persistence>k__BackingField; //Field offset: 0x11
	[CompilerGenerated]
	private string <Target>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private int <Type>k__BackingField; //Field offset: 0x20

	[DataMember(Name = "hidden")]
	[Preserve]
	public bool Hidden
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	[DataMember(Name = "persistence")]
	[Preserve]
	public bool Persistence
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	[DataMember(Name = "target")]
	[Preserve]
	public string Target
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "type")]
	[Preserve]
	public int Type
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public ChannelJoinMessage() { }

	[CompilerGenerated]
	public bool get_Hidden() { }

	[CompilerGenerated]
	public bool get_Persistence() { }

	[CompilerGenerated]
	public string get_Target() { }

	[CompilerGenerated]
	public int get_Type() { }

	[CompilerGenerated]
	public void set_Hidden(bool value) { }

	[CompilerGenerated]
	public void set_Persistence(bool value) { }

	[CompilerGenerated]
	public void set_Target(string value) { }

	[CompilerGenerated]
	public void set_Type(int value) { }

	public virtual string ToString() { }

}

