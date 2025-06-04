namespace Nakama;

public class Session : ISession
{
	public static readonly DateTime Epoch; //Field offset: 0x0
	[CompilerGenerated]
	private string <AuthToken>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly bool <Created>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly long <CreateTime>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private long <ExpireTime>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private long <RefreshExpireTime>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private string <RefreshToken>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private readonly IDictionary<String, String> <Vars>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private string <Username>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private string <UserId>k__BackingField; //Field offset: 0x50

	public private override string AuthToken
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public override bool Created
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public override long CreateTime
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public private override long ExpireTime
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

	public private override string UserId
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private override string Username
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public override IDictionary<String, String> Vars
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	private static Session() { }

	internal Session(string authToken, string refreshToken, bool created) { }

	[CompilerGenerated]
	public override string get_AuthToken() { }

	[CompilerGenerated]
	public override bool get_Created() { }

	[CompilerGenerated]
	public override long get_CreateTime() { }

	[CompilerGenerated]
	public override long get_ExpireTime() { }

	public override bool get_IsExpired() { }

	public override bool get_IsRefreshExpired() { }

	[CompilerGenerated]
	public override long get_RefreshExpireTime() { }

	[CompilerGenerated]
	public override string get_RefreshToken() { }

	[CompilerGenerated]
	public override string get_UserId() { }

	[CompilerGenerated]
	public override string get_Username() { }

	[CompilerGenerated]
	public override IDictionary<String, String> get_Vars() { }

	public override bool HasExpired(DateTime offset) { }

	public override bool HasRefreshExpired(DateTime offset) { }

	private static string JwtUnpack(string jwt) { }

	public static ISession Restore(string authToken, string refreshToken = null) { }

	[CompilerGenerated]
	private void set_AuthToken(string value) { }

	[CompilerGenerated]
	private void set_ExpireTime(long value) { }

	[CompilerGenerated]
	private void set_RefreshExpireTime(long value) { }

	[CompilerGenerated]
	private void set_RefreshToken(string value) { }

	[CompilerGenerated]
	private void set_UserId(string value) { }

	[CompilerGenerated]
	private void set_Username(string value) { }

	public virtual string ToString() { }

	public void Update(string authToken, string refreshToken) { }

}

