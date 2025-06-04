namespace AnimalCompany.API;

public static class APIHelper
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal AppPlatform <.cctor>b__0_0(KeyValuePair<String, AppPlatform> kv) { }

		internal string <.cctor>b__0_1(KeyValuePair<String, AppPlatform> kv) { }

	}

	private static Dictionary<String, AppPlatform> _apiToClientPlatformTypeLookup; //Field offset: 0x0
	private static Dictionary<AppPlatform, String> _clientToAPIPlatformTypeLookup; //Field offset: 0x8

	private static APIHelper() { }

	public static AppPlatform FromAPIClientPlatform(string apiClientPlatform) { }

	public static string ToAPIPlatform(AppPlatform platform) { }

}

