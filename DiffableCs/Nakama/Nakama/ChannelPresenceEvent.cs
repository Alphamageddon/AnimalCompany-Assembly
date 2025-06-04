namespace Nakama;

internal class ChannelPresenceEvent : IChannelPresenceEvent
{
	[CompilerGenerated]
	private string <ChannelId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private List<UserPresence> <_joins>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private List<UserPresence> <_leaves>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private string <RoomName>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private string <GroupId>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private string <UserIdOne>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private string <UserIdTwo>k__BackingField; //Field offset: 0x40

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

	[DataMember(Name = "channel_id")]
	[Preserve]
	public override string ChannelId
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "group_id")]
	[Preserve]
	public override string GroupId
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public override IEnumerable<IUserPresence> Joins
	{
		 get { } //Length: 120
	}

	public override IEnumerable<IUserPresence> Leaves
	{
		 get { } //Length: 120
	}

	[DataMember(Name = "room_name")]
	[Preserve]
	public override string RoomName
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "user_id_one")]
	[Preserve]
	public override string UserIdOne
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "user_id_two")]
	[Preserve]
	public override string UserIdTwo
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public ChannelPresenceEvent() { }

	[CompilerGenerated]
	public List<UserPresence> get__joins() { }

	[CompilerGenerated]
	public List<UserPresence> get__leaves() { }

	[CompilerGenerated]
	public override string get_ChannelId() { }

	[CompilerGenerated]
	public override string get_GroupId() { }

	public override IEnumerable<IUserPresence> get_Joins() { }

	public override IEnumerable<IUserPresence> get_Leaves() { }

	[CompilerGenerated]
	public override string get_RoomName() { }

	[CompilerGenerated]
	public override string get_UserIdOne() { }

	[CompilerGenerated]
	public override string get_UserIdTwo() { }

	[CompilerGenerated]
	public void set__joins(List<UserPresence> value) { }

	[CompilerGenerated]
	public void set__leaves(List<UserPresence> value) { }

	[CompilerGenerated]
	public void set_ChannelId(string value) { }

	[CompilerGenerated]
	public void set_GroupId(string value) { }

	[CompilerGenerated]
	public void set_RoomName(string value) { }

	[CompilerGenerated]
	public void set_UserIdOne(string value) { }

	[CompilerGenerated]
	public void set_UserIdTwo(string value) { }

	public virtual string ToString() { }

}

