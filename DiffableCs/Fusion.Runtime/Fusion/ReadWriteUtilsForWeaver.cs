namespace Fusion;

public static class ReadWriteUtilsForWeaver
{
	private const float ACCURACY = 1024; //Field offset: 0x0
	private const int STRING_LENGTH_INDEX = 0; //Field offset: 0x0
	private const int STRING_HASHCODE_INDEX = 1; //Field offset: 0x0
	private const int STRING_DATA_INDEX = 2; //Field offset: 0x0
	private const int STRING_NOHASHCODE_DATA_INDEX = 1; //Field offset: 0x0

	[Preserve]
	public static int GetByteArrayHashCode(Byte* ptr, int length) { }

	[Preserve]
	public static int GetByteCountUtf8NoHash(string value) { }

	[Preserve]
	public static int GetStringHashCode(string value, int maxLength) { }

	[Preserve]
	public static int GetWordCountString(int capacity, bool withCaching) { }

	[Preserve]
	public static bool ReadBoolean(Int32* data) { }

	[Preserve]
	public static int ReadStringUtf32NoHash(Int32* ptr, int maxLength, out string result) { }

	[Preserve]
	public static int ReadStringUtf32WithHash(Int32* ptr, int maxLength, ref string cache) { }

	[Preserve]
	public static int ReadStringUtf8NoHash(Void* source, out string result) { }

	[Preserve]
	public static int VerifyRawNetworkUnwrap(int actual, int maxBytes) { }

	[Preserve]
	public static int VerifyRawNetworkWrap(int actual, int maxBytes) { }

	[Preserve]
	public static void WriteBoolean(Int32* data, bool value) { }

	[Preserve]
	public static int WriteStringUtf32NoHash(Int32* ptr, int maxLength, string value) { }

	[Preserve]
	public static int WriteStringUtf32WithHash(Int32* ptr, int maxLength, string value, ref string cache) { }

	[Preserve]
	public static int WriteStringUtf8NoHash(Void* destination, string str) { }

}

