namespace Fusion.Analyzer;

[AttributeUsage(AttributeTargets::Field (256))]
[Conditional("false")]
public class StaticFieldAttribute : Attribute
{
	[CompilerGenerated]
	private readonly StaticFieldResetMode <Reset>k__BackingField; //Field offset: 0x10

	public StaticFieldResetMode Reset
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public StaticFieldAttribute(StaticFieldResetMode resetMode) { }

	public StaticFieldAttribute() { }

	[CompilerGenerated]
	public StaticFieldResetMode get_Reset() { }

}

