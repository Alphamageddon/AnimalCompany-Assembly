namespace Nakama;

internal class Channel : IChannel
{
	[CompilerGenerated]
	private string <Id>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private List<UserPresence> <_presences>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private UserPresence <_self>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private string <RoomName>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private string <GroupId>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private string <UserIdOne>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private string <UserIdTwo>k__BackingField; //Field offset: 0x40

	[DataMember(Name = "presences")]
	[Preserve]
	public List<UserPresence> _presences
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "self")]
	[Preserve]
	public UserPresence _self
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

	[DataMember(Name = "id")]
	[Preserve]
	public override string Id
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public override IEnumerable<IUserPresence> Presences
	{
		 get { } //Length: 100
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

	public override IUserPresence Self
	{
		 get { } //Length: 8
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

	public Channel() { }

	private bool Equals(IChannel other) { }

	public virtual bool Equals(object obj) { }

	[CompilerGenerated]
	public List<UserPresence> get__presences() { }

	[CompilerGenerated]
	public UserPresence get__self() { }

	[CompilerGenerated]
	public override string get_GroupId() { }

	[CompilerGenerated]
	public override string get_Id() { }

	public override IEnumerable<IUserPresence> get_Presences() { }

	[CompilerGenerated]
	public override string get_RoomName() { }

	public override IUserPresence get_Self() { }

	[CompilerGenerated]
	public override string get_UserIdOne() { }

	[CompilerGenerated]
	public override string get_UserIdTwo() { }

	public virtual int GetHashCode() { }

	[CompilerGenerated]
	public void set__presences(List<UserPresence> value) { }

	[CompilerGenerated]
	public void set__self(UserPresence value) { }

	[CompilerGenerated]
	public void set_GroupId(string value) { }

	[CompilerGenerated]
	public void set_Id(string value) { }

	[CompilerGenerated]
	public void set_RoomName(string value) { }

	[CompilerGenerated]
	public void set_UserIdOne(string value) { }

	[CompilerGenerated]
	public void set_UserIdTwo(string value) { }

	public virtual string ToString() { }

}

