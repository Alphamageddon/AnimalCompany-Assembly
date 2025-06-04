namespace Fusion.Analyzer;

[AttributeUsage(AttributeTargets::Constructor (32))]
[Conditional("false")]
public class StaticConstructorAttribute : Attribute
{

	public StaticConstructorAttribute() { }

}

