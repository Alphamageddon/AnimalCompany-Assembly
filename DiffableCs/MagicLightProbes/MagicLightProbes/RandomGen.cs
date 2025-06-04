namespace MagicLightProbes;

public static class RandomGen
{
	[ThreadStatic]
	private static Random _local; //Field offset: 0x80000000
	private static Random _global; //Field offset: 0x0

	private static RandomGen() { }

	public static int Next(int min, int max) { }

}

