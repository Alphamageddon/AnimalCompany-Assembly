namespace Nakama;

internal class ApiDeleteStorageObjectId : IApiDeleteStorageObjectId
{
	[CompilerGenerated]
	private string <Collection>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <Key>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <Version>k__BackingField; //Field offset: 0x20

	[DataMember(Name = "collection")]
	[Preserve]
	public override string Collection
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "key")]
	[Preserve]
	public override string Key
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "version")]
	[Preserve]
	public override string Version
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public ApiDeleteStorageObjectId() { }

	[CompilerGenerated]
	public override string get_Collection() { }

	[CompilerGenerated]
	public override string get_Key() { }

	[CompilerGenerated]
	public override string get_Version() { }

	[CompilerGenerated]
	public void set_Collection(string value) { }

	[CompilerGenerated]
	public void set_Key(string value) { }

	[CompilerGenerated]
	public void set_Version(string value) { }

	public virtual string ToString() { }

}

