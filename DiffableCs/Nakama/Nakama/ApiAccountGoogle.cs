namespace Nakama;

internal class ApiAccountGoogle : IApiAccountGoogle
{
	[CompilerGenerated]
	private string <Token>k__BackingField; //Field offset: 0x10
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

	[DataMember(Name = "token")]
	[Preserve]
	public override string Token
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

	public ApiAccountGoogle() { }

	[CompilerGenerated]
	public Dictionary<String, String> get__vars() { }

	[CompilerGenerated]
	public override string get_Token() { }

	public override IDictionary<String, String> get_Vars() { }

	[CompilerGenerated]
	public void set__vars(Dictionary<String, String> value) { }

	[CompilerGenerated]
	public void set_Token(string value) { }

	public virtual string ToString() { }

}

