namespace System.Runtime.Serialization;

[AttributeUsage(384, Inherited = False, AllowMultiple = False)]
public sealed class DataMemberAttribute : Attribute
{
	private string name; //Field offset: 0x10
	private bool isNameSetExplicitly; //Field offset: 0x18
	private int order; //Field offset: 0x1C
	private bool emitDefaultValue; //Field offset: 0x20

	public string Name
	{
		 get { } //Length: 8
		 set { } //Length: 16
	}

	public DataMemberAttribute() { }

	public string get_Name() { }

	public void set_Name(string value) { }

}

