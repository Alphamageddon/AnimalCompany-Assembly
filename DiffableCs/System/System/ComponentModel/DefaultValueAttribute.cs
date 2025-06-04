namespace System.ComponentModel;

[AttributeUsage(AttributeTargets::All (32767))]
public class DefaultValueAttribute : Attribute
{
	private object _value; //Field offset: 0x10

	public override object Value
	{
		 get { } //Length: 8
	}

	public DefaultValueAttribute(bool value) { }

	public DefaultValueAttribute(string value) { }

	public virtual bool Equals(object obj) { }

	public override object get_Value() { }

	public virtual int GetHashCode() { }

}

