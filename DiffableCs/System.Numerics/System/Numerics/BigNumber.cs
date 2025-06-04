namespace System.Numerics;

internal static class BigNumber
{

	internal static string FormatBigInteger(BigInteger value, string format, NumberFormatInfo info) { }

	private static string FormatBigInteger(bool targetSpan, BigInteger value, string formatString, ReadOnlySpan<Char> formatSpan, NumberFormatInfo info, Span<Char> destination, out int charsWritten, out bool spanSuccess) { }

	private static string FormatBigIntegerToHex(bool targetSpan, BigInteger value, char format, int digits, NumberFormatInfo info, Span<Char> destination, out int charsWritten, out bool spanSuccess) { }

	internal static char ParseFormatSpecifier(ReadOnlySpan<Char> format, out int digits) { }

}

