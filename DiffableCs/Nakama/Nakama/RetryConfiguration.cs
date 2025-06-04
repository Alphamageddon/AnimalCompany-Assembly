namespace Nakama;

public class RetryConfiguration
{
	[CompilerGenerated]
	private readonly int <BaseDelayMs>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly Jitter <Jitter>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly int <MaxAttempts>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly RetryListener <RetryListener>k__BackingField; //Field offset: 0x28

	public int BaseDelayMs
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public Jitter Jitter
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public int MaxAttempts
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public RetryListener RetryListener
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public RetryConfiguration(int baseDelayMs, int maxRetries) { }

	public RetryConfiguration(int baseDelayMs, int maxRetries, RetryListener listener) { }

	public RetryConfiguration(int baseDelayMs, int maxRetries, RetryListener listener, Jitter jitter) { }

	[CompilerGenerated]
	public int get_BaseDelayMs() { }

	[CompilerGenerated]
	public Jitter get_Jitter() { }

	[CompilerGenerated]
	public int get_MaxAttempts() { }

	[CompilerGenerated]
	public RetryListener get_RetryListener() { }

}

