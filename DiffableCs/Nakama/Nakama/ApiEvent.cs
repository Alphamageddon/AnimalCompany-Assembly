namespace Nakama;

internal class ApiEvent : IApiEvent
{
	[CompilerGenerated]
	private bool <External>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <Name>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private Dictionary<String, String> <_properties>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private string <Timestamp>k__BackingField; //Field offset: 0x28

	[DataMember(Name = "properties")]
	[Preserve]
	public Dictionary<String, String> _properties
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "external")]
	[Preserve]
	public override bool External
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
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

	[IgnoreDataMember]
	public override IDictionary<String, String> Properties
	{
		 get { } //Length: 116
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

	public ApiEvent() { }

	[CompilerGenerated]
	public Dictionary<String, String> get__properties() { }

	[CompilerGenerated]
	public override bool get_External() { }

	[CompilerGenerated]
	public override string get_Name() { }

	public override IDictionary<String, String> get_Properties() { }

	[CompilerGenerated]
	public override string get_Timestamp() { }

	[CompilerGenerated]
	public void set__properties(Dictionary<String, String> value) { }

	[CompilerGenerated]
	public void set_External(bool value) { }

	[CompilerGenerated]
	public void set_Name(string value) { }

	[CompilerGenerated]
	public void set_Timestamp(string value) { }

	public virtual string ToString() { }

}

