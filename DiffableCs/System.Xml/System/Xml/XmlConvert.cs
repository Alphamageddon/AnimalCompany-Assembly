namespace System.Xml;

public class XmlConvert
{
	private static XmlCharType xmlCharType; //Field offset: 0x0
	internal static Char[] crt; //Field offset: 0x8
	private static readonly int c_EncodedCharLength; //Field offset: 0x10
	internal static readonly Char[] WhitespaceChars; //Field offset: 0x18

	private static XmlConvert() { }

	private static DateTime SwitchToLocalTime(DateTime value) { }

	private static DateTime SwitchToUtcTime(DateTime value) { }

	public static string ToString(DateTime value, XmlDateTimeSerializationMode dateTimeOption) { }

}

