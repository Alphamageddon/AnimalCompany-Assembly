namespace Fusion;

[AttributeUsage(320, AllowMultiple = True)]
public class DrawIfAttribute : DoIfAttributeBase
{
	private const int DefaultOrder = -11000; //Field offset: 0x0
	public DrawIfMode Mode; //Field offset: 0x44

	public bool Hide
	{
		 get { } //Length: 16
		 set { } //Length: 28
	}

	public DrawIfAttribute(string conditionMember, double compareToValue, CompareOperator compare = 0, DrawIfMode mode = 0) { }

	public DrawIfAttribute(string conditionMember, bool compareToValue, CompareOperator compare = 0, DrawIfMode mode = 0) { }

	public DrawIfAttribute(string conditionMember, long compareToValue, CompareOperator compare = 0, DrawIfMode mode = 0) { }

	public DrawIfAttribute(string conditionMember) { }

	public bool get_Hide() { }

	public void set_Hide(bool value) { }

}

