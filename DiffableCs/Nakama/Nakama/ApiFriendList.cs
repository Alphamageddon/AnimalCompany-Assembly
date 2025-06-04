namespace Nakama;

internal class ApiFriendList : IApiFriendList
{
	[CompilerGenerated]
	private string <Cursor>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private List<ApiFriend> <_friends>k__BackingField; //Field offset: 0x18

	[DataMember(Name = "friends")]
	[Preserve]
	public List<ApiFriend> _friends
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
	public override IEnumerable<IApiFriend> Friends
	{
		 get { } //Length: 120
	}

	public ApiFriendList() { }

	[CompilerGenerated]
	public List<ApiFriend> get__friends() { }

	[CompilerGenerated]
	public override string get_Cursor() { }

	public override IEnumerable<IApiFriend> get_Friends() { }

	[CompilerGenerated]
	public void set__friends(List<ApiFriend> value) { }

	[CompilerGenerated]
	public void set_Cursor(string value) { }

	public virtual string ToString() { }

}

