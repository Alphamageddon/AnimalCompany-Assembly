namespace System.ComponentModel;

public class EnumConverter : TypeConverter
{
	private StandardValuesCollection values; //Field offset: 0x10
	private Type type; //Field offset: 0x18

	public EnumConverter(Type type) { }

}

