namespace System.Net.Cache;

internal sealed class RequestCacheManager
{
	private static RequestCachingSectionInternal s_CacheConfigSettings; //Field offset: 0x0
	private static readonly RequestCacheBinding s_BypassCacheBinding; //Field offset: 0x8
	private static RequestCacheBinding s_DefaultGlobalBinding; //Field offset: 0x10
	private static RequestCacheBinding s_DefaultHttpBinding; //Field offset: 0x18
	private static RequestCacheBinding s_DefaultFtpBinding; //Field offset: 0x20

	private static RequestCacheManager() { }

	internal static RequestCacheBinding GetBinding(string internedScheme) { }

	private static void LoadConfigSettings() { }

}

