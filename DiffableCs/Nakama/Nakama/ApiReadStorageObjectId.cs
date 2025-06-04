namespace Nakama;

internal class ApiReadStorageObjectId : IApiReadStorageObjectId
{
	[CompilerGenerated]
	private string <Collection>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <Key>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <UserId>k__BackingField; //Field offset: 0x20

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

	[DataMember(Name = "user_id")]
	[Preserve]
	public override string UserId
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public ApiReadStorageObjectId() { }

	[CompilerGenerated]
	public override string get_Collection() { }

	[CompilerGenerated]
	public override string get_Key() { }

	[CompilerGenerated]
	public override string get_UserId() { }

	[CompilerGenerated]
	public void set_Collection(string value) { }

	[CompilerGenerated]
	public void set_Key(string value) { }

	[CompilerGenerated]
	public void set_UserId(string value) { }

	public virtual string ToString() { }

}

