namespace System.IO;

public static class File
{

	public static StreamWriter AppendText(string path) { }

	public static FileStream Create(string path) { }

	public static FileStream Create(string path, int bufferSize) { }

	public static StreamWriter CreateText(string path) { }

	public static void Delete(string path) { }

	public static bool Exists(string path) { }

	private static string InternalReadAllText(string path, Encoding encoding) { }

	public static FileStream Open(string path, FileMode mode) { }

	public static FileStream Open(string path, FileMode mode, FileAccess access, FileShare share) { }

	public static FileStream OpenRead(string path) { }

	public static StreamReader OpenText(string path) { }

	public static FileStream OpenWrite(string path) { }

	public static Byte[] ReadAllBytes(string path) { }

	private static Byte[] ReadAllBytesUnknownLength(FileStream fs) { }

	public static string ReadAllText(string path) { }

	public static void WriteAllText(string path, string contents) { }

}

