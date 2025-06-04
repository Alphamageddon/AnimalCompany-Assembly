namespace System.Net.Mime;

internal static class MailBnfHelper
{
	internal static readonly Boolean[] Atext; //Field offset: 0x0
	internal static readonly Boolean[] Qtext; //Field offset: 0x8
	internal static readonly Boolean[] Dtext; //Field offset: 0x10
	internal static readonly Boolean[] Ftext; //Field offset: 0x18
	internal static readonly Boolean[] Ttext; //Field offset: 0x20
	internal static readonly Boolean[] Ctext; //Field offset: 0x28
	internal static readonly int Ascii7bitMaxValue; //Field offset: 0x30
	internal static readonly char Quote; //Field offset: 0x34
	internal static readonly char Space; //Field offset: 0x36
	internal static readonly char Tab; //Field offset: 0x38
	internal static readonly char CR; //Field offset: 0x3A
	internal static readonly char LF; //Field offset: 0x3C
	internal static readonly char StartComment; //Field offset: 0x3E
	internal static readonly char EndComment; //Field offset: 0x40
	internal static readonly char Backslash; //Field offset: 0x42
	internal static readonly char At; //Field offset: 0x44
	internal static readonly char EndAngleBracket; //Field offset: 0x46
	internal static readonly char StartAngleBracket; //Field offset: 0x48
	internal static readonly char StartSquareBracket; //Field offset: 0x4A
	internal static readonly char EndSquareBracket; //Field offset: 0x4C
	internal static readonly char Comma; //Field offset: 0x4E
	internal static readonly char Dot; //Field offset: 0x50
	private static readonly Char[] s_colonSeparator; //Field offset: 0x58
	private static String[] s_months; //Field offset: 0x60

	private static MailBnfHelper() { }

	private static Boolean[] CreateCharactersAllowedInAtoms() { }

	private static Boolean[] CreateCharactersAllowedInComments() { }

	private static Boolean[] CreateCharactersAllowedInDomainLiterals() { }

	private static Boolean[] CreateCharactersAllowedInHeaderNames() { }

	private static Boolean[] CreateCharactersAllowedInQuotedStrings() { }

	private static Boolean[] CreateCharactersAllowedInTokens() { }

	internal static bool IsAllowedWhiteSpace(char c) { }

}

