namespace Fusion;

[AttributeUsage(AttributeTargets::Field (256))]
public sealed class UnitAttribute : DecoratingPropertyAttribute
{
	[CompilerGenerated]
	private readonly Units <Unit>k__BackingField; //Field offset: 0x14

	public Units Unit
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public UnitAttribute(Units units) { }

	[CompilerGenerated]
	public Units get_Unit() { }

}

