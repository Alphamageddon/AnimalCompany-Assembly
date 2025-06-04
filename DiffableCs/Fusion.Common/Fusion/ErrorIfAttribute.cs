namespace Fusion;

[AttributeUsage(AttributeTargets::Field (256), AllowMultiple = True)]
public class ErrorIfAttribute : DoIfAttributeBase
{
	public string Message; //Field offset: 0x48
	public bool AsBox; //Field offset: 0x50

	public ErrorIfAttribute(string conditionMember, double compareToValue, string message, CompareOperator compare = 0) { }

	public ErrorIfAttribute(string conditionMember, bool compareToValue, string message, CompareOperator compare = 0) { }

	public ErrorIfAttribute(string conditionMember, long compareToValue, string message, CompareOperator compare = 0) { }

}

