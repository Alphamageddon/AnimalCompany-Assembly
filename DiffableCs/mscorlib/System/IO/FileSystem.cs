namespace System.IO;

internal static class FileSystem
{

	public static void CreateDirectory(string fullPath) { }

	public static void DeleteFile(string fullPath) { }

	public static bool DirectoryExists(ReadOnlySpan<Char> fullPath) { }

	private static bool DirectoryExists(ReadOnlySpan<Char> fullPath, out ErrorInfo errorInfo) { }

	public static bool FileExists(ReadOnlySpan<Char> fullPath) { }

	private static bool FileExists(ReadOnlySpan<Char> fullPath, int fileType, out ErrorInfo errorInfo) { }

}

