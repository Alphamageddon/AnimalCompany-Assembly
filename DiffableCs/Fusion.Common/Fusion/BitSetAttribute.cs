namespace Fusion;

[AttributeUsage(AttributeTargets::Field (256), AllowMultiple = False)]
public sealed class BitSetAttribute : DrawerPropertyAttribute
{
	[CompilerGenerated]
	private readonly int <BitCount>k__BackingField; //Field offset: 0x14

	public int BitCount
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public BitSetAttribute(int bitCount) { }

	[CompilerGenerated]
	public int get_BitCount() { }

}

