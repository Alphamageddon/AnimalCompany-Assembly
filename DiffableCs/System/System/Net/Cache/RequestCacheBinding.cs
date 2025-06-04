namespace System.Net.Cache;

internal class RequestCacheBinding
{
	private RequestCache m_RequestCache; //Field offset: 0x10
	private RequestCacheValidator m_CacheValidator; //Field offset: 0x18
	private RequestCachePolicy m_Policy; //Field offset: 0x20

	internal RequestCachePolicy Policy
	{
		internal get { } //Length: 8
	}

	internal RequestCacheBinding(RequestCache requestCache, RequestCacheValidator cacheValidator, RequestCachePolicy policy) { }

	internal RequestCachePolicy get_Policy() { }

}

