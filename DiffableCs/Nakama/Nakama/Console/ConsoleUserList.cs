namespace Nakama.Console;

internal class ConsoleUserList : IConsoleUserList
{
	[CompilerGenerated]
	private int <TotalCount>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private List<ApiUser> <_users>k__BackingField; //Field offset: 0x18

	[DataMember(Name = "users")]
	public List<ApiUser> _users
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "total_count")]
	public override int TotalCount
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public override IEnumerable<IApiUser> Users
	{
		 get { } //Length: 120
	}

	public ConsoleUserList() { }

	[CompilerGenerated]
	public List<ApiUser> get__users() { }

	[CompilerGenerated]
	public override int get_TotalCount() { }

	public override IEnumerable<IApiUser> get_Users() { }

	[CompilerGenerated]
	public void set__users(List<ApiUser> value) { }

	[CompilerGenerated]
	public void set_TotalCount(int value) { }

	public virtual string ToString() { }

}

