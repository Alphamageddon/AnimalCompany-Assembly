namespace Nakama;

internal class StreamPresenceEvent : IStreamPresenceEvent
{
	[CompilerGenerated]
	private List<UserPresence> <LeavesField>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private List<UserPresence> <JoinsField>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private Stream <StreamField>k__BackingField; //Field offset: 0x20

	public override IEnumerable<IUserPresence> Joins
	{
		 get { } //Length: 100
	}

	[DataMember(Name = "joins")]
	[Preserve]
	public List<UserPresence> JoinsField
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public override IEnumerable<IUserPresence> Leaves
	{
		 get { } //Length: 100
	}

	[DataMember(Name = "leaves")]
	[Preserve]
	public List<UserPresence> LeavesField
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public override IStream Stream
	{
		 get { } //Length: 8
	}

	[DataMember(Name = "stream")]
	[Preserve]
	public Stream StreamField
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public StreamPresenceEvent() { }

	public override IEnumerable<IUserPresence> get_Joins() { }

	[CompilerGenerated]
	public List<UserPresence> get_JoinsField() { }

	public override IEnumerable<IUserPresence> get_Leaves() { }

	[CompilerGenerated]
	public List<UserPresence> get_LeavesField() { }

	public override IStream get_Stream() { }

	[CompilerGenerated]
	public Stream get_StreamField() { }

	[CompilerGenerated]
	public void set_JoinsField(List<UserPresence> value) { }

	[CompilerGenerated]
	public void set_LeavesField(List<UserPresence> value) { }

	[CompilerGenerated]
	public void set_StreamField(Stream value) { }

	public virtual string ToString() { }

}

