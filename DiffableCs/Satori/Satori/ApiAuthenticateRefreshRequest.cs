namespace Satori;

internal class ApiAuthenticateRefreshRequest : IApiAuthenticateRefreshRequest
{
	[CompilerGenerated]
	private string <RefreshToken>k__BackingField; //Field offset: 0x10

	[DataMember(Name = "refresh_token")]
	[Preserve]
	public override string RefreshToken
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public ApiAuthenticateRefreshRequest() { }

	[CompilerGenerated]
	public override string get_RefreshToken() { }

	[CompilerGenerated]
	public void set_RefreshToken(string value) { }

	public virtual string ToString() { }

}

