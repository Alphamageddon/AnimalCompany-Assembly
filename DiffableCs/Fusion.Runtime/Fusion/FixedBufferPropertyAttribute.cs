namespace Fusion;

public class FixedBufferPropertyAttribute : PropertyAttribute
{
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly Type <SurrogateType>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly int <Capacity>k__BackingField; //Field offset: 0x28

	public int Capacity
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public Type SurrogateType
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public Type Type
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public FixedBufferPropertyAttribute(Type fieldType, Type surrogateType, int capacity) { }

	[CompilerGenerated]
	public int get_Capacity() { }

	[CompilerGenerated]
	public Type get_SurrogateType() { }

	[CompilerGenerated]
	public Type get_Type() { }

}

