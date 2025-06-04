namespace Satori;

internal class ApiEvent : IApiEvent
{
	[CompilerGenerated]
	private string <Id>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private Dictionary<String, String> <_metadata>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <Name>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private string <Timestamp>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private string <Value>k__BackingField; //Field offset: 0x30

	[DataMember(Name = "metadata")]
	[Preserve]
	public Dictionary<String, String> _metadata
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "id")]
	[Preserve]
	public override string Id
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[IgnoreDataMember]
	public override IDictionary<String, String> Metadata
	{
		 get { } //Length: 116
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

	[DataMember(Name = "timestamp")]
	[Preserve]
	public override string Timestamp
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "value")]
	[Preserve]
	public override string Value
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public ApiEvent() { }

	[CompilerGenerated]
	public Dictionary<String, String> get__metadata() { }

	[CompilerGenerated]
	public override string get_Id() { }

	public override IDictionary<String, String> get_Metadata() { }

	[CompilerGenerated]
	public override string get_Name() { }

	[CompilerGenerated]
	public override string get_Timestamp() { }

	[CompilerGenerated]
	public override string get_Value() { }

	[CompilerGenerated]
	public void set__metadata(Dictionary<String, String> value) { }

	[CompilerGenerated]
	public void set_Id(string value) { }

	[CompilerGenerated]
	public void set_Name(string value) { }

	[CompilerGenerated]
	public void set_Timestamp(string value) { }

	[CompilerGenerated]
	public void set_Value(string value) { }

	public virtual string ToString() { }

}

