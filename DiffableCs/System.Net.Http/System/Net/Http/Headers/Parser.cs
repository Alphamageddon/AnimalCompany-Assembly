namespace System.Net.Http.Headers;

internal static class Parser
{
	internal static class DateTime
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0

			private static <>c() { }

			public <>c() { }

			internal string <.cctor>b__2_0(object l) { }

		}

		public static readonly Func<Object, String> ToString; //Field offset: 0x0

		private static DateTime() { }

		public static bool TryParse(string input, out DateTimeOffset result) { }

	}

	internal static class EmailAddress
	{

		public static bool TryParse(string input, out string result) { }

	}

	internal static class Host
	{

		public static bool TryParse(string input, out string result) { }

	}

	internal static class Int
	{

		public static bool TryParse(string input, out int result) { }

	}

	internal static class Long
	{

		public static bool TryParse(string input, out long result) { }

	}

	internal static class MD5
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0

			private static <>c() { }

			public <>c() { }

			internal string <.cctor>b__2_0(object l) { }

		}

		public static readonly Func<Object, String> ToString; //Field offset: 0x0

		private static MD5() { }

		public static bool TryParse(string input, out Byte[] result) { }

	}

	internal static class TimeSpanSeconds
	{

		public static bool TryParse(string input, out TimeSpan result) { }

	}

	internal static class Token
	{

		public static void Check(string s) { }

		public static bool TryCheck(string s) { }

	}

	internal static class Uri
	{

		public static bool TryParse(string input, out Uri result) { }

	}


}

