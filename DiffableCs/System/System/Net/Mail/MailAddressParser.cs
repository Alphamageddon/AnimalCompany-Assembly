namespace System.Net.Mail;

internal static class MailAddressParser
{

	internal static string NormalizeOrThrow(string input) { }

	internal static MailAddress ParseAddress(string data) { }

	private static MailAddress ParseAddress(string data, bool expectMultipleAddresses, ref int index) { }

	private static string ParseDisplayName(string data, ref int index, bool expectMultipleAddresses) { }

	private static string ParseDomain(string data, ref int index) { }

	private static string ParseLocalPart(string data, ref int index, bool expectAngleBracket, bool expectMultipleAddresses) { }

	private static int ReadCfwsAndThrowIfIncomplete(string data, int index) { }

}

