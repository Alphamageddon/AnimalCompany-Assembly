namespace Fusion;

[AttributeUsage(AttributeTargets::Field (256), AllowMultiple = False)]
public sealed class MaxStringByteCountAttribute : DrawerPropertyAttribute
{
	[CompilerGenerated]
	private readonly int <ByteCount>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private readonly string <Encoding>k__BackingField; //Field offset: 0x18

	public int ByteCount
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public string Encoding
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public MaxStringByteCountAttribute(int count, string encoding) { }

	[CompilerGenerated]
	public int get_ByteCount() { }

	[CompilerGenerated]
	public string get_Encoding() { }

}

