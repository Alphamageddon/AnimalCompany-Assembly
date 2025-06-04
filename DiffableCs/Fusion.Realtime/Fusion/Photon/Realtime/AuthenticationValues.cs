namespace Fusion.Photon.Realtime;

public class AuthenticationValues
{
	private CustomAuthenticationType authType; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private string <AuthGetParameters>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private object <AuthPostData>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private object <Token>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private string <UserId>k__BackingField; //Field offset: 0x30

	public string AuthGetParameters
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public private object AuthPostData
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public CustomAuthenticationType AuthType
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public private object Token
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public string UserId
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public AuthenticationValues(string userId) { }

	public AuthenticationValues() { }

	public override void AddAuthParameter(string key, string value) { }

	public AuthenticationValues CopyTo(AuthenticationValues copy) { }

	[CompilerGenerated]
	public string get_AuthGetParameters() { }

	[CompilerGenerated]
	public object get_AuthPostData() { }

	public CustomAuthenticationType get_AuthType() { }

	[CompilerGenerated]
	public object get_Token() { }

	[CompilerGenerated]
	public string get_UserId() { }

	[CompilerGenerated]
	public void set_AuthGetParameters(string value) { }

	[CompilerGenerated]
	private void set_AuthPostData(object value) { }

	public void set_AuthType(CustomAuthenticationType value) { }

	[CompilerGenerated]
	protected private void set_Token(object value) { }

	[CompilerGenerated]
	public void set_UserId(string value) { }

	public override void SetAuthPostData(string stringData) { }

	public override void SetAuthPostData(Byte[] byteData) { }

	public override void SetAuthPostData(Dictionary<String, Object> dictData) { }

	public virtual string ToString() { }

}

