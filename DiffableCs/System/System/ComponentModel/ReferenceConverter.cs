namespace System.ComponentModel;

public class ReferenceConverter : TypeConverter
{
	private static readonly string s_none; //Field offset: 0x0
	private Type _type; //Field offset: 0x10

	private static ReferenceConverter() { }

	public ReferenceConverter(Type type) { }

}

