namespace System.Net.Http.Headers;

internal static class CollectionParser
{

	public static bool TryParse(string input, int minimalCount, ElementTryParser<T> parser, out List<T>& result) { }

	public static bool TryParse(string input, int minimalCount, out List<String>& result) { }

	private static bool TryParseStringElement(Lexer lexer, out string parsedValue, out Token t) { }

}

