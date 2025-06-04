namespace Nakama.Console;

internal class ApiFriend : IApiFriend
{
	[CompilerGenerated]
	private int <State>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private ApiUser <_user>k__BackingField; //Field offset: 0x18

	[DataMember(Name = "user")]
	public ApiUser _user
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "state")]
	public override int State
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public override IApiUser User
	{
		 get { } //Length: 8
	}

	public ApiFriend() { }

	[CompilerGenerated]
	public ApiUser get__user() { }

	[CompilerGenerated]
	public override int get_State() { }

	public override IApiUser get_User() { }

	[CompilerGenerated]
	public void set__user(ApiUser value) { }

	[CompilerGenerated]
	public void set_State(int value) { }

	public virtual string ToString() { }

}

