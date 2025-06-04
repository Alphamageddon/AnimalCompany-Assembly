namespace System.Net.Http.Headers;

public sealed class MediaTypeWithQualityHeaderValue : MediaTypeHeaderValue
{

	public MediaTypeWithQualityHeaderValue(string mediaType) { }

	private MediaTypeWithQualityHeaderValue() { }

	internal static bool TryParse(string input, int minimalCount, out List<MediaTypeWithQualityHeaderValue>& result) { }

	private static bool TryParseElement(Lexer lexer, out MediaTypeWithQualityHeaderValue parsedValue, out Token t) { }

}

