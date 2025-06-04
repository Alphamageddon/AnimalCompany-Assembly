namespace System.Xml;

internal struct XmlCharType
{
	private static object s_Lock; //Field offset: 0x0
	private static Byte[] s_CharProperties; //Field offset: 0x8
	internal Byte[] charProperties; //Field offset: 0x0

	public static XmlCharType Instance
	{
		 get { } //Length: 104
	}

	private static object StaticLock
	{
		private get { } //Length: 148
	}

	private XmlCharType(Byte[] charProperties) { }

	public static XmlCharType get_Instance() { }

	private static object get_StaticLock() { }

	private static void InitInstance() { }

	private static void SetProperties(Byte[] chProps, string ranges, byte value) { }

}

