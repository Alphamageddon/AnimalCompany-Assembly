namespace Nakama;

internal class StatusFollowMessage
{
	[CompilerGenerated]
	private List<String> <UserIds>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private List<String> <Usernames>k__BackingField; //Field offset: 0x18

	[DataMember(Name = "user_ids")]
	[Preserve]
	public List<String> UserIds
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "usernames")]
	[Preserve]
	public List<String> Usernames
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public StatusFollowMessage() { }

	[CompilerGenerated]
	public List<String> get_UserIds() { }

	[CompilerGenerated]
	public List<String> get_Usernames() { }

	[CompilerGenerated]
	public void set_UserIds(List<String> value) { }

	[CompilerGenerated]
	public void set_Usernames(List<String> value) { }

	public virtual string ToString() { }

}

