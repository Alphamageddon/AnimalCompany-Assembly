namespace Fusion;

[Extension]
internal static class HashCodeUtilities
{
	public const int InitialHash = 352654597; //Field offset: 0x0

	public static int CombineHashCodes(int a, int b) { }

	public static int CombineHashCodes(int a, int b, int c) { }

	public static int GetArrayHashCode(T* ptr, int length, int initialHash = 352654597) { }

	public static int GetHashCodeDeterministic(Byte[] data, int initialHash = 0) { }

	public static int GetHashCodeDeterministic(string data, int initialHash = 0) { }

	public static int GetHashCodeDeterministic(T data, int initialHash = 0) { }

	public static int GetHashCodeDeterministic(T* data, int initialHash = 0) { }

	[Extension]
	public static int GetHashDeterministic(string str, int initialHash = 352654597) { }

	[Extension]
	internal static int GetHashDeterministicInternal(string str, int len, int initialHash) { }

}

