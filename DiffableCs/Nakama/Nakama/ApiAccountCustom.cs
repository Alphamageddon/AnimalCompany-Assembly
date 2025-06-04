namespace Nakama;

internal class ApiAccountCustom : IApiAccountCustom
{
	[CompilerGenerated]
	private string <Id>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private Dictionary<String, String> <_vars>k__BackingField; //Field offset: 0x18

	[DataMember(Name = "vars")]
	[Preserve]
	public Dictionary<String, String> _vars
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
	public override IDictionary<String, String> Vars
	{
		 get { } //Length: 116
	}

	public ApiAccountCustom() { }

	[CompilerGenerated]
	public Dictionary<String, String> get__vars() { }

	[CompilerGenerated]
	public override string get_Id() { }

	public override IDictionary<String, String> get_Vars() { }

	[CompilerGenerated]
	public void set__vars(Dictionary<String, String> value) { }

	[CompilerGenerated]
	public void set_Id(string value) { }

	public virtual string ToString() { }

}

