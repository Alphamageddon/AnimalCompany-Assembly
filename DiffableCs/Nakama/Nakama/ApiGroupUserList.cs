namespace Nakama;

internal class ApiGroupUserList : IApiGroupUserList
{
	[CompilerGenerated]
	private string <Cursor>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private List<GroupUserListGroupUser> <_groupUsers>k__BackingField; //Field offset: 0x18

	[DataMember(Name = "group_users")]
	[Preserve]
	public List<GroupUserListGroupUser> _groupUsers
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "cursor")]
	[Preserve]
	public override string Cursor
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[IgnoreDataMember]
	public override IEnumerable<IGroupUserListGroupUser> GroupUsers
	{
		 get { } //Length: 120
	}

	public ApiGroupUserList() { }

	[CompilerGenerated]
	public List<GroupUserListGroupUser> get__groupUsers() { }

	[CompilerGenerated]
	public override string get_Cursor() { }

	public override IEnumerable<IGroupUserListGroupUser> get_GroupUsers() { }

	[CompilerGenerated]
	public void set__groupUsers(List<GroupUserListGroupUser> value) { }

	[CompilerGenerated]
	public void set_Cursor(string value) { }

	public virtual string ToString() { }

}

