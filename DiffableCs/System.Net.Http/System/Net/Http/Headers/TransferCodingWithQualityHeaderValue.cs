namespace System.Net.Http.Headers;

public sealed class TransferCodingWithQualityHeaderValue : TransferCodingHeaderValue
{

	private TransferCodingWithQualityHeaderValue() { }

	internal static bool TryParse(string input, int minimalCount, out List<TransferCodingWithQualityHeaderValue>& result) { }

	private static bool TryParseElement(Lexer lexer, out TransferCodingWithQualityHeaderValue parsedValue, out Token t) { }

}

