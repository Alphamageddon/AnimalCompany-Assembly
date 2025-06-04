namespace Nakama;

internal class ApiGroupList : IApiGroupList
{
	[CompilerGenerated]
	private string <Cursor>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private List<ApiGroup> <_groups>k__BackingField; //Field offset: 0x18

	[DataMember(Name = "groups")]
	[Preserve]
	public List<ApiGroup> _groups
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
	public override IEnumerable<IApiGroup> Groups
	{
		 get { } //Length: 120
	}

	public ApiGroupList() { }

	[CompilerGenerated]
	public List<ApiGroup> get__groups() { }

	[CompilerGenerated]
	public override string get_Cursor() { }

	public override IEnumerable<IApiGroup> get_Groups() { }

	[CompilerGenerated]
	public void set__groups(List<ApiGroup> value) { }

	[CompilerGenerated]
	public void set_Cursor(string value) { }

	public virtual string ToString() { }

}

