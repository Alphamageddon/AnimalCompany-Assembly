namespace Fusion;

public sealed class SessionProperty
{
	private object _value; //Field offset: 0x10

	public bool Isbool
	{
		 get { } //Length: 96
	}

	public bool IsInt
	{
		 get { } //Length: 96
	}

	public bool IsString
	{
		 get { } //Length: 96
	}

	public Type PropertyType
	{
		 get { } //Length: 28
	}

	public object PropertyValue
	{
		 get { } //Length: 8
	}

	private SessionProperty() { }

	public static SessionProperty Convert(object obj) { }

	public bool get_Isbool() { }

	public bool get_IsInt() { }

	public bool get_IsString() { }

	public Type get_PropertyType() { }

	public object get_PropertyValue() { }

	public static int op_Implicit(SessionProperty sessionProperty) { }

	public static SessionProperty op_Implicit(int v) { }

	public static string op_Implicit(SessionProperty sessionProperty) { }

	public static SessionProperty op_Implicit(string v) { }

	public static bool op_Implicit(SessionProperty sessionProperty) { }

	public static SessionProperty op_Implicit(bool v) { }

	public static bool Support(object obj) { }

	public virtual string ToString() { }

}

