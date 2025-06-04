namespace Fusion;

public abstract class DoIfAttributeBase : DecoratingPropertyAttribute
{
	public double _doubleValue; //Field offset: 0x18
	public bool _isDouble; //Field offset: 0x20
	public long _longValue; //Field offset: 0x28
	public CompareOperator Compare; //Field offset: 0x30
	public string ConditionMember; //Field offset: 0x38
	public bool ErrorOnConditionMemberNotFound; //Field offset: 0x40

	protected DoIfAttributeBase(string conditionMember, double compareToValue, CompareOperator compare) { }

	protected DoIfAttributeBase(string conditionMember, long compareToValue, CompareOperator compare) { }

	protected DoIfAttributeBase(string conditionMember, bool compareToValue, CompareOperator compare) { }

}

