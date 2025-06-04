namespace Fusion;

[NetworkStructWeaved(4)]
public struct NetworkRNG : INetworkStruct
{
	internal const double FP_32_32_ToUnitDoubleInclusive = 2.3283064370807974E-10; //Field offset: 0x0
	internal const double FP_32_32_ToUnitDoubleExclusive = 2.3283064365386963E-10; //Field offset: 0x0
	internal const float FP_8_24_ToUnitSingleInclusive = 5.960465E-08; //Field offset: 0x0
	internal const float FP_8_24_ToUnitSingleExclusive = 5.9604645E-08; //Field offset: 0x0
	public const int SIZE = 16; //Field offset: 0x0
	public const uint MAX = 4294967295; //Field offset: 0x0
	private ulong _state; //Field offset: 0x0
	private ulong _inc; //Field offset: 0x8

	public NetworkRNG Peek
	{
		 get { } //Length: 12
	}

	public NetworkRNG(int seed) { }

	public NetworkRNG get_Peek() { }

	public double Next() { }

	public double NextExclusive() { }

	public int NextInt32() { }

	public float NextSingle() { }

	public float NextSingleExclusive() { }

	private static ulong NextSplitMix64(ref ulong x) { }

	public uint NextUInt32() { }

	private uint NextUInt32Internal() { }

	private uint NextUnbiasedUInt32(uint max) { }

	public uint RangeExclusive(uint minInclusive, uint maxExclusive) { }

	public int RangeExclusive(int minInclusive, int maxExclusive) { }

	public double RangeInclusive(double minInclusive, double maxInclusive) { }

	public float RangeInclusive(float minInclusive, float maxInclusive) { }

	public int RangeInclusive(int minInclusive, int maxInclusive) { }

	public uint RangeInclusive(uint minInclusive, uint maxInclusive) { }

	public virtual string ToString() { }

}

