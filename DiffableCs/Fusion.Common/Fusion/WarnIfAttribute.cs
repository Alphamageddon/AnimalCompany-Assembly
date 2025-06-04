namespace Fusion;

[AttributeUsage(448, AllowMultiple = True)]
public class WarnIfAttribute : DoIfAttributeBase
{
	public string Message; //Field offset: 0x48
	public bool AsBox; //Field offset: 0x50

	public WarnIfAttribute(string conditionMember, double compareToValue, string message, CompareOperator compare = 0) { }

	public WarnIfAttribute(string conditionMember, bool compareToValue, string message, CompareOperator compare = 0) { }

	public WarnIfAttribute(string conditionMember, long compareToValue, string message, CompareOperator compare = 0) { }

	public WarnIfAttribute(string conditionMember, string message) { }

}

