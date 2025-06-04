namespace AnimalCompany.Logging;

public static class Loggly
{
	private const int MAX_EVENT_LENGTH_BYTES = 1048576; //Field offset: 0x0
	private const int MAX_BULK_LOG_LENGTH_BYTES = 5242880; //Field offset: 0x0
	private const float MIN_TIME_BETWEEN_LOGS_SEC = 30; //Field offset: 0x0
	private static readonly Encoding LOG_ENCODING; //Field offset: 0x0
	private static readonly Byte[] NEW_LINE; //Field offset: 0x8
	private static ConcurrentQueue<Byte[]> _queue; //Field offset: 0x10
	private static MemoryStream _logglyBulkLog; //Field offset: 0x18
	private static UnityWebRequest _currentRequest; //Field offset: 0x20
	private static string _envTag; //Field offset: 0x28
	private static string _url; //Field offset: 0x30
	private static float _lastLogTime; //Field offset: 0x38

	public static string envTag
	{
		 get { } //Length: 88
		 set { } //Length: 92
	}

	private static Loggly() { }

	public static string get_envTag() { }

	public static void QueueLog(JSONObject logJSON) { }

	private static void RefreshLogglyURL() { }

	public static void set_envTag(string value) { }

	public static void Update() { }

}

