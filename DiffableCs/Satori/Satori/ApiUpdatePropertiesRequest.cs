namespace Satori;

internal class ApiUpdatePropertiesRequest : IApiUpdatePropertiesRequest
{
	[CompilerGenerated]
	private Dictionary<String, String> <_custom>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private Dictionary<String, String> <_default>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private bool <Recompute>k__BackingField; //Field offset: 0x20

	[DataMember(Name = "custom")]
	[Preserve]
	public Dictionary<String, String> _custom
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "default")]
	[Preserve]
	public Dictionary<String, String> _default
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[IgnoreDataMember]
	public override IDictionary<String, String> Custom
	{
		 get { } //Length: 116
	}

	[IgnoreDataMember]
	public override IDictionary<String, String> Default
	{
		 get { } //Length: 116
	}

	[DataMember(Name = "recompute")]
	[Preserve]
	public override bool Recompute
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public ApiUpdatePropertiesRequest() { }

	[CompilerGenerated]
	public Dictionary<String, String> get__custom() { }

	[CompilerGenerated]
	public Dictionary<String, String> get__default() { }

	public override IDictionary<String, String> get_Custom() { }

	public override IDictionary<String, String> get_Default() { }

	[CompilerGenerated]
	public override bool get_Recompute() { }

	[CompilerGenerated]
	public void set__custom(Dictionary<String, String> value) { }

	[CompilerGenerated]
	public void set__default(Dictionary<String, String> value) { }

	[CompilerGenerated]
	public void set_Recompute(bool value) { }

	public virtual string ToString() { }

}

