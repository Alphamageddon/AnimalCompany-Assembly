namespace Satori;

internal class ApiSession : IApiSession
{
	[CompilerGenerated]
	private ApiProperties <_properties>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <RefreshToken>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <Token>k__BackingField; //Field offset: 0x20

	[DataMember(Name = "properties")]
	[Preserve]
	public ApiProperties _properties
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[IgnoreDataMember]
	public override IApiProperties Properties
	{
		 get { } //Length: 8
	}

	[DataMember(Name = "refresh_token")]
	[Preserve]
	public override string RefreshToken
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

	public ApiSession() { }

	[CompilerGenerated]
	public ApiProperties get__properties() { }

	public override IApiProperties get_Properties() { }

	[CompilerGenerated]
	public override string get_RefreshToken() { }

	[CompilerGenerated]
	public override string get_Token() { }

	[CompilerGenerated]
	public void set__properties(ApiProperties value) { }

	[CompilerGenerated]
	public void set_RefreshToken(string value) { }

	[CompilerGenerated]
	public void set_Token(string value) { }

	public virtual string ToString() { }

}

