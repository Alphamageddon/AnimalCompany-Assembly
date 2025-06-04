namespace Nakama;

public class Retry
{
	[CompilerGenerated]
	private readonly int <ExponentialBackoff>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly int <JitterBackoff>k__BackingField; //Field offset: 0x14

	public int ExponentialBackoff
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public int JitterBackoff
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	internal Retry(int expoBackoff, int jitterBackoff) { }

	[CompilerGenerated]
	public int get_ExponentialBackoff() { }

	[CompilerGenerated]
	public int get_JitterBackoff() { }

}

