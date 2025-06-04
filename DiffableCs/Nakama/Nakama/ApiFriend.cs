namespace Nakama;

internal class ApiFriend : IApiFriend
{
	[CompilerGenerated]
	private int <State>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <UpdateTime>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private ApiUser <_user>k__BackingField; //Field offset: 0x20

	[DataMember(Name = "user")]
	[Preserve]
	public ApiUser _user
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "state")]
	[Preserve]
	public override int State
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "update_time")]
	[Preserve]
	public override string UpdateTime
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[IgnoreDataMember]
	public override IApiUser User
	{
		 get { } //Length: 8
	}

	public ApiFriend() { }

	[CompilerGenerated]
	public ApiUser get__user() { }

	[CompilerGenerated]
	public override int get_State() { }

	[CompilerGenerated]
	public override string get_UpdateTime() { }

	public override IApiUser get_User() { }

	[CompilerGenerated]
	public void set__user(ApiUser value) { }

	[CompilerGenerated]
	public void set_State(int value) { }

	[CompilerGenerated]
	public void set_UpdateTime(string value) { }

	public virtual string ToString() { }

}

