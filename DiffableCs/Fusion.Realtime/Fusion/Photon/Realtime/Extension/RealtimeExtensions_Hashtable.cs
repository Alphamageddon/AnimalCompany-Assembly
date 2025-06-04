namespace Fusion.Photon.Realtime.Extension;

[Extension]
internal static class RealtimeExtensions_Hashtable
{
	private static readonly StreamBuffer buffer; //Field offset: 0x0
	private static readonly Protocol18 protocol; //Field offset: 0x8

	private static RealtimeExtensions_Hashtable() { }

	[Extension]
	public static int CalculateTotalSize(Hashtable hashtable) { }

	[Extension]
	public static Dictionary<String, SessionProperty> ConvertToDictionaryProperty(Hashtable customProperties) { }

	[Extension]
	public static Hashtable ConvertToHashtable(Dictionary<String, SessionProperty> properties) { }

}

