namespace Nakama;

internal class ApiCreateGroupRequest : IApiCreateGroupRequest
{
	[CompilerGenerated]
	private string <AvatarUrl>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <Description>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <LangTag>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private int <MaxCount>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private string <Name>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private bool <Open>k__BackingField; //Field offset: 0x38

	[DataMember(Name = "avatar_url")]
	[Preserve]
	public override string AvatarUrl
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "description")]
	[Preserve]
	public override string Description
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "lang_tag")]
	[Preserve]
	public override string LangTag
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "max_count")]
	[Preserve]
	public override int MaxCount
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "name")]
	[Preserve]
	public override string Name
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "open")]
	[Preserve]
	public override bool Open
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public ApiCreateGroupRequest() { }

	[CompilerGenerated]
	public override string get_AvatarUrl() { }

	[CompilerGenerated]
	public override string get_Description() { }

	[CompilerGenerated]
	public override string get_LangTag() { }

	[CompilerGenerated]
	public override int get_MaxCount() { }

	[CompilerGenerated]
	public override string get_Name() { }

	[CompilerGenerated]
	public override bool get_Open() { }

	[CompilerGenerated]
	public void set_AvatarUrl(string value) { }

	[CompilerGenerated]
	public void set_Description(string value) { }

	[CompilerGenerated]
	public void set_LangTag(string value) { }

	[CompilerGenerated]
	public void set_MaxCount(int value) { }

	[CompilerGenerated]
	public void set_Name(string value) { }

	[CompilerGenerated]
	public void set_Open(bool value) { }

	public virtual string ToString() { }

}

