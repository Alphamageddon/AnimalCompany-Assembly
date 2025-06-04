namespace System.Globalization;

internal class FormatProvider
{
	private class Number
	{
		public struct NumberBuffer
		{
			public int precision; //Field offset: 0x0
			public int scale; //Field offset: 0x4
			public bool sign; //Field offset: 0x8
			public Char* overrideDigits; //Field offset: 0x10

			public Char* digits
			{
				 get { } //Length: 8
			}

			public Char* get_digits() { }

		}

		private static String[] s_posCurrencyFormats; //Field offset: 0x0
		private static String[] s_negCurrencyFormats; //Field offset: 0x8
		private static String[] s_posPercentFormats; //Field offset: 0x10
		private static String[] s_negPercentFormats; //Field offset: 0x18
		private static String[] s_negNumberFormats; //Field offset: 0x20
		private static string s_posNumberFormat; //Field offset: 0x28

		private static Number() { }

		private static int FindSection(ReadOnlySpan<Char> format, int section) { }

		private static void FormatCurrency(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

		private static void FormatExponent(ref ValueStringBuilder sb, NumberFormatInfo info, int value, char expChar, int minDigits, bool positiveSign) { }

		private static void FormatFixed(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, Int32[] groupDigits, string sDecimal, string sGroup) { }

		private static void FormatGeneral(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar, bool bSuppressScientific) { }

		private static void FormatNumber(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

		private static void FormatPercent(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

		private static void FormatScientific(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar) { }

		internal static void Int32ToDecChars(Char* buffer, ref int index, uint value, int digits) { }

		internal static void NumberToString(ref ValueStringBuilder sb, ref NumberBuffer number, char format, int nMaxDigits, NumberFormatInfo info, bool isDecimal) { }

		internal static void NumberToStringFormat(ref ValueStringBuilder sb, ref NumberBuffer number, ReadOnlySpan<Char> format, NumberFormatInfo info) { }

		internal static char ParseFormatSpecifier(ReadOnlySpan<Char> format, out int digits) { }

		private static void RoundNumber(ref NumberBuffer number, int pos) { }

		private static int wcslen(Char* s) { }

	}


	internal static void FormatBigInteger(ref ValueStringBuilder sb, int precision, int scale, bool sign, ReadOnlySpan<Char> format, NumberFormatInfo numberFormatInfo, Char[] digits, int startIndex) { }

}

