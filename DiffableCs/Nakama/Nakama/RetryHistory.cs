namespace Nakama;

internal class RetryHistory
{
	[CompilerGenerated]
	private readonly RetryConfiguration <Configuration>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly List<Retry> <Retries>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly Nullable<CancellationToken> <UserCancelToken>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly Random <Random>k__BackingField; //Field offset: 0x30

	public RetryConfiguration Configuration
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public Random Random
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public List<Retry> Retries
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public Nullable<CancellationToken> UserCancelToken
	{
		[CompilerGenerated]
		 get { } //Length: 12
	}

	public RetryHistory(ISession session, RetryConfiguration configuration, Nullable<CancellationToken> userCancelToken) { }

	public RetryHistory(string jitterHashKey, RetryConfiguration configuration, Nullable<CancellationToken> userCancelToken) { }

	[CompilerGenerated]
	public RetryConfiguration get_Configuration() { }

	[CompilerGenerated]
	public Random get_Random() { }

	[CompilerGenerated]
	public List<Retry> get_Retries() { }

	[CompilerGenerated]
	public Nullable<CancellationToken> get_UserCancelToken() { }

}

