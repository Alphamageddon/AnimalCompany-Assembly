namespace Nakama;

internal class ApiUserGroupList : IApiUserGroupList
{
	[CompilerGenerated]
	private string <Cursor>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private List<UserGroupListUserGroup> <_userGroups>k__BackingField; //Field offset: 0x18

	[DataMember(Name = "user_groups")]
	[Preserve]
	public List<UserGroupListUserGroup> _userGroups
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
	public override IEnumerable<IUserGroupListUserGroup> UserGroups
	{
		 get { } //Length: 120
	}

	public ApiUserGroupList() { }

	[CompilerGenerated]
	public List<UserGroupListUserGroup> get__userGroups() { }

	[CompilerGenerated]
	public override string get_Cursor() { }

	public override IEnumerable<IUserGroupListUserGroup> get_UserGroups() { }

	[CompilerGenerated]
	public void set__userGroups(List<UserGroupListUserGroup> value) { }

	[CompilerGenerated]
	public void set_Cursor(string value) { }

	public virtual string ToString() { }

}

