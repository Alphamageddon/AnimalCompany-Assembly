namespace Fusion;

public static class BinUtils
{
	private static readonly String[] _byteHexValue; //Field offset: 0x0

	private static BinUtils() { }

	public static string BytesToHex(Byte* buffer, int length, int columns = 16, string rowSeparator = "
", string columnSeparator = " ") { }

	public static string BytesToHex(Byte[] buffer, int columns = 16) { }

	public static string ByteToHex(byte value) { }

	public static int HexToBytes(string str, Byte* buffer, int length) { }

	public static ValueTuple<Int32, Int32> HexToInts(string str, Int32* buffer, int length) { }

	private static bool TryHexToByte(char c, out byte result) { }

	public static string WordsToHex(Int32* buffer, int length, int columns = 4, string rowSeparator = "
", string columnSeparator = " ") { }

	public static string WordsToHex(UInt32* buffer, int length, int columns = 4, string rowSeparator = "
", string columnSeparator = " ") { }

}

