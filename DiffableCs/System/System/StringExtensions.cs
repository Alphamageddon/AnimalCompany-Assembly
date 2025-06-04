namespace System;

[Extension]
internal static class StringExtensions
{

	[Extension]
	internal static string SubstringTrim(string value, int startIndex) { }

	[Extension]
	internal static string SubstringTrim(string value, int startIndex, int length) { }

}

