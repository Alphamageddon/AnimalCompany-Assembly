namespace Nakama;

internal class StatusUnfollowMessage
{
	[CompilerGenerated]
	private List<String> <UserIds>k__BackingField; //Field offset: 0x10

	[DataMember(Name = "user_ids")]
	[Preserve]
	public List<String> UserIds
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public StatusUnfollowMessage() { }

	[CompilerGenerated]
	public List<String> get_UserIds() { }

	[CompilerGenerated]
	public void set_UserIds(List<String> value) { }

	public virtual string ToString() { }

}

