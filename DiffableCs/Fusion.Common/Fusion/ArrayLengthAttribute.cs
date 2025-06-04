namespace Fusion;

[AttributeUsage(AttributeTargets::Field (256), AllowMultiple = False)]
public sealed class ArrayLengthAttribute : DecoratingPropertyAttribute
{
	[CompilerGenerated]
	private readonly int <MinLength>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private readonly int <MaxLength>k__BackingField; //Field offset: 0x18

	public int MaxLength
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public int MinLength
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public ArrayLengthAttribute(int length) { }

	public ArrayLengthAttribute(int minLength, int maxLength) { }

	[CompilerGenerated]
	public int get_MaxLength() { }

	[CompilerGenerated]
	public int get_MinLength() { }

}

