namespace Nakama;

internal class StatusPresenceEvent : IStatusPresenceEvent
{
	[CompilerGenerated]
	private List<UserPresence> <_leaves>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private List<UserPresence> <_joins>k__BackingField; //Field offset: 0x18

	[DataMember(Name = "joins")]
	[Preserve]
	public List<UserPresence> _joins
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "leaves")]
	[Preserve]
	public List<UserPresence> _leaves
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public override IEnumerable<IUserPresence> Joins
	{
		 get { } //Length: 100
	}

	public override IEnumerable<IUserPresence> Leaves
	{
		 get { } //Length: 100
	}

	public StatusPresenceEvent() { }

	[CompilerGenerated]
	public List<UserPresence> get__joins() { }

	[CompilerGenerated]
	public List<UserPresence> get__leaves() { }

	public override IEnumerable<IUserPresence> get_Joins() { }

	public override IEnumerable<IUserPresence> get_Leaves() { }

	[CompilerGenerated]
	public void set__joins(List<UserPresence> value) { }

	[CompilerGenerated]
	public void set__leaves(List<UserPresence> value) { }

	public virtual string ToString() { }

}

