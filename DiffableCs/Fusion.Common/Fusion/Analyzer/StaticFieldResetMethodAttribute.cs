namespace Fusion.Analyzer;

[AttributeUsage(AttributeTargets::Method (64))]
[Conditional("false")]
public class StaticFieldResetMethodAttribute : Attribute
{

	public StaticFieldResetMethodAttribute(bool calledAutomatically) { }

	public StaticFieldResetMethodAttribute() { }

}

