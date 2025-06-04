namespace Satori;

public class Session : ISession
{
	public static readonly DateTime Epoch; //Field offset: 0x0
	[CompilerGenerated]
	private string <AuthToken>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private long <ExpireTime>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private long <RefreshExpireTime>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private string <RefreshToken>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private string <IdentityId>k__BackingField; //Field offset: 0x30

	public private override string AuthToken
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private override long ExpireTime
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private override string IdentityId
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public override bool IsExpired
	{
		 get { } //Length: 96
	}

	public override bool IsRefreshExpired
	{
		 get { } //Length: 96
	}

	public private override long RefreshExpireTime
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private override string RefreshToken
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	private static Session() { }

	internal Session(string authToken, string refreshToken) { }

	[CompilerGenerated]
	public override string get_AuthToken() { }

	[CompilerGenerated]
	public override long get_ExpireTime() { }

	[CompilerGenerated]
	public override string get_IdentityId() { }

	public override bool get_IsExpired() { }

	public override bool get_IsRefreshExpired() { }

	[CompilerGenerated]
	public override long get_RefreshExpireTime() { }

	[CompilerGenerated]
	public override string get_RefreshToken() { }

	public override bool HasExpired(DateTime offset) { }

	public override bool HasRefreshExpired(DateTime offset) { }

	private static string JwtUnpack(string jwt) { }

	public static ISession Restore(string authToken, string refreshToken = null) { }

	[CompilerGenerated]
	private void set_AuthToken(string value) { }

	[CompilerGenerated]
	private void set_ExpireTime(long value) { }

	[CompilerGenerated]
	private void set_IdentityId(string value) { }

	[CompilerGenerated]
	private void set_RefreshExpireTime(long value) { }

	[CompilerGenerated]
	private void set_RefreshToken(string value) { }

	public virtual string ToString() { }

	internal void Update(string authToken, string refreshToken) { }

}

