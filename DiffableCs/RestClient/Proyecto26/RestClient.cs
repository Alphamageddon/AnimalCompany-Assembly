namespace Proyecto26;

[Extension]
public static class RestClient
{
	private static Dictionary<String, String> _defaultRequestHeaders; //Field offset: 0x0

	public static Dictionary<String, String> DefaultRequestHeaders
	{
		 get { } //Length: 160
		 set { } //Length: 76
	}

	public static void CleanDefaultHeaders() { }

	public static IPromise<ResponseHelper> Delete(RequestHelper options) { }

	public static void Delete(string url, object body, Action<RequestException, ResponseHelper, T> callback) { }

	public static void Delete(RequestHelper options, Action<RequestException, ResponseHelper, T> callback) { }

	public static IPromise<ResponseHelper> Delete(string url) { }

	public static void Delete(RequestHelper options, Action<RequestException, ResponseHelper> callback) { }

	public static IPromise<T> Delete(string url, object body) { }

	public static void Delete(string url, Action<RequestException, ResponseHelper> callback) { }

	public static IPromise<T> Delete(RequestHelper options) { }

	public static void Get(RequestHelper options, Action<RequestException, ResponseHelper, T> callback) { }

	public static IPromise<ResponseHelper> Get(string url) { }

	public static IPromise<ResponseHelper> Get(RequestHelper options) { }

	public static IPromise<T> Get(string url) { }

	public static void Get(string url, Action<RequestException, ResponseHelper, T> callback) { }

	public static IPromise<T> Get(RequestHelper options) { }

	public static void Get(string url, Action<RequestException, ResponseHelper> callback) { }

	public static void Get(RequestHelper options, Action<RequestException, ResponseHelper> callback) { }

	public static Dictionary<String, String> get_DefaultRequestHeaders() { }

	public static IPromise<T[]> GetArray(string url) { }

	public static void GetArray(RequestHelper options, Action<RequestException, ResponseHelper, T[]> callback) { }

	public static void GetArray(string url, Action<RequestException, ResponseHelper, T[]> callback) { }

	public static IPromise<T[]> GetArray(RequestHelper options) { }

	public static void Head(string url, Action<RequestException, ResponseHelper> callback) { }

	public static IPromise<ResponseHelper> Head(string url) { }

	public static IPromise<ResponseHelper> Head(RequestHelper options) { }

	public static void Head(RequestHelper options, Action<RequestException, ResponseHelper> callback) { }

	public static IPromise<ResponseHelper> Patch(RequestHelper options) { }

	public static void Patch(RequestHelper options, Action<RequestException, ResponseHelper> callback) { }

	public static IPromise<T> Post(string url, object body) { }

	public static void Post(string url, object body, Action<RequestException, ResponseHelper> callback) { }

	public static void Post(string url, string bodyString, Action<RequestException, ResponseHelper> callback) { }

	public static void Post(RequestHelper options, Action<RequestException, ResponseHelper> callback) { }

	public static IPromise<T> Post(RequestHelper options) { }

	public static IPromise<T> Post(string url, string bodyString) { }

	public static IPromise<ResponseHelper> Post(RequestHelper options) { }

	public static void Post(RequestHelper options, Action<RequestException, ResponseHelper, T> callback) { }

	public static void Post(string url, string bodyString, Action<RequestException, ResponseHelper, T> callback) { }

	public static void Post(string url, object body, Action<RequestException, ResponseHelper, T> callback) { }

	public static IPromise<ResponseHelper> Post(string url, object body) { }

	public static IPromise<ResponseHelper> Post(string url, string bodyString) { }

	[Extension]
	private static void Promisify(Promise<T> promise, RequestException error, ResponseHelper response, T body) { }

	[Extension]
	private static void Promisify(Promise<T> promise, RequestException error, T response) { }

	public static void Put(string url, string bodyString, Action<RequestException, ResponseHelper> callback) { }

	public static void Put(string url, object body, Action<RequestException, ResponseHelper, T> callback) { }

	public static void Put(RequestHelper options, Action<RequestException, ResponseHelper> callback) { }

	public static IPromise<T> Put(RequestHelper options) { }

	public static void Put(string url, object body, Action<RequestException, ResponseHelper> callback) { }

	public static IPromise<T> Put(string url, object body) { }

	public static IPromise<T> Put(string url, string bodyString) { }

	public static IPromise<ResponseHelper> Put(string url, string bodyString) { }

	public static IPromise<ResponseHelper> Put(string url, object body) { }

	public static void Put(RequestHelper options, Action<RequestException, ResponseHelper, T> callback) { }

	public static IPromise<ResponseHelper> Put(RequestHelper options) { }

	public static void Put(string url, string bodyString, Action<RequestException, ResponseHelper, T> callback) { }

	public static IPromise<ResponseHelper> Request(RequestHelper options) { }

	public static IPromise<T> Request(RequestHelper options) { }

	public static void Request(RequestHelper options, Action<RequestException, ResponseHelper, T> callback) { }

	public static void Request(RequestHelper options, Action<RequestException, ResponseHelper> callback) { }

	public static void set_DefaultRequestHeaders(Dictionary<String, String> value) { }

}

