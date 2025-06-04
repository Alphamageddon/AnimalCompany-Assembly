namespace Nakama;

internal class ApiUsers : IApiUsers
{
	[CompilerGenerated]
	private List<ApiUser> <_users>k__BackingField; //Field offset: 0x10

	[DataMember(Name = "users")]
	[Preserve]
	public List<ApiUser> _users
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[IgnoreDataMember]
	public override IEnumerable<IApiUser> Users
	{
		 get { } //Length: 120
	}

	public ApiUsers() { }

	[CompilerGenerated]
	public List<ApiUser> get__users() { }

	public override IEnumerable<IApiUser> get_Users() { }

	[CompilerGenerated]
	public void set__users(List<ApiUser> value) { }

	public virtual string ToString() { }

}

