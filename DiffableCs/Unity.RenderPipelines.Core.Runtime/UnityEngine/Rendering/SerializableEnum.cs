namespace UnityEngine.Rendering;

public class SerializableEnum
{
	[SerializeField]
	private string m_EnumValueAsString; //Field offset: 0x10
	[SerializeField]
	private string m_EnumTypeAsString; //Field offset: 0x18

	public Enum value
	{
		 get { } //Length: 320
		 set { } //Length: 48
	}

	public SerializableEnum(Type enumType) { }

	public Enum get_value() { }

	public void set_value(Enum value) { }

}

