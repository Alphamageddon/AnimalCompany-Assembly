namespace System.Net.Http;

internal static class PlatformHelper
{

	internal static StreamContent CreateStreamContent(Stream stream, CancellationToken cancellationToken) { }

	internal static string GetSingleHeaderString(string name, IEnumerable<String> values) { }

	internal static bool IsContentHeader(string name) { }

}

