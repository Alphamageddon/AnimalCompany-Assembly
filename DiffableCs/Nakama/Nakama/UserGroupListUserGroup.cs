namespace Nakama;

internal class UserGroupListUserGroup : IUserGroupListUserGroup
{
	[CompilerGenerated]
	private ApiGroup <_group>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <State>k__BackingField; //Field offset: 0x18

	[DataMember(Name = "group")]
	[Preserve]
	public ApiGroup _group
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[IgnoreDataMember]
	public override IApiGroup Group
	{
		 get { } //Length: 8
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

	public UserGroupListUserGroup() { }

	[CompilerGenerated]
	public ApiGroup get__group() { }

	public override IApiGroup get_Group() { }

	[CompilerGenerated]
	public override int get_State() { }

	[CompilerGenerated]
	public void set__group(ApiGroup value) { }

	[CompilerGenerated]
	public void set_State(int value) { }

	public virtual string ToString() { }

}

