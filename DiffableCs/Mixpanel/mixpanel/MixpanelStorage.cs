namespace mixpanel;

public static class MixpanelStorage
{
	public enum FlushType
	{
		EVENTS = 0,
		PEOPLE = 1,
	}

	private static IPreferences PreferencesSource; //Field offset: 0x0
	private const string HasMigratedFrom1To2Name = "Mixpanel.HasMigratedFrom1To2"; //Field offset: 0x0
	private const string DistinctIdName = "Mixpanel.DistinctId"; //Field offset: 0x0
	private const string EventAutoIncrementingIdName = "EventAutoIncrementingID"; //Field offset: 0x0
	private const string PeopleAutoIncrementingIdName = "PeopleAutoIncrementingID"; //Field offset: 0x0
	private const string EventStartIndexName = "EventStartIndex"; //Field offset: 0x0
	private const string PeopleStartIndexName = "PeopleStartIndex"; //Field offset: 0x0
	private const string IsTrackingName = "Mixpanel.IsTracking"; //Field offset: 0x0
	private const string OncePropertiesName = "Mixpanel.OnceProperties"; //Field offset: 0x0
	private const string SuperPropertiesName = "Mixpanel.SuperProperties"; //Field offset: 0x0
	private const string TimedEventsName = "Mixpanel.TimedEvents"; //Field offset: 0x0
	private static string _distinctId; //Field offset: 0x8
	private static bool _isTracking; //Field offset: 0x10
	private static Value _onceProperties; //Field offset: 0x18
	private static Value _superProperties; //Field offset: 0x20
	private static Value _timedEvents; //Field offset: 0x28

	public static string DistinctId
	{
		 get { } //Length: 580
		 set { } //Length: 244
	}

	internal static bool HasMigratedFrom1To2
	{
		internal get { } //Length: 292
		internal set { } //Length: 296
	}

	public static bool IsTracking
	{
		 get { } //Length: 456
		 set { } //Length: 256
	}

	internal static Value OnceProperties
	{
		internal get { } //Length: 544
		internal set { } //Length: 260
	}

	internal static Value SuperProperties
	{
		internal get { } //Length: 544
		internal set { } //Length: 260
	}

	internal static Value TimedEvents
	{
		internal get { } //Length: 544
		internal set { } //Length: 260
	}

	private static MixpanelStorage() { }

	internal static void DeleteAllTrackingData(FlushType flushType) { }

	internal static void DeleteBatchTrackingData(FlushType flushType, int batchSize) { }

	internal static void DeleteBatchTrackingData(Value batch) { }

	internal static Value DequeueBatchTrackingData(FlushType flushType, int batchSize) { }

	internal static void EnqueueTrackingData(Value data, FlushType flushType) { }

	internal static int EventAutoIncrementingID() { }

	internal static int EventStartIndex() { }

	public static string get_DistinctId() { }

	internal static bool get_HasMigratedFrom1To2() { }

	public static bool get_IsTracking() { }

	internal static Value get_OnceProperties() { }

	internal static Value get_SuperProperties() { }

	internal static Value get_TimedEvents() { }

	private static void IncreaseTrackingDataID(FlushType flushType) { }

	internal static int PeopleAutoIncrementingID() { }

	internal static int PeopleStartIndex() { }

	internal static void ResetOnceProperties() { }

	internal static void ResetSuperProperties() { }

	internal static void ResetTimedEvents() { }

	public static void set_DistinctId(string value) { }

	internal static void set_HasMigratedFrom1To2(bool value) { }

	public static void set_IsTracking(bool value) { }

	internal static void set_OnceProperties(Value value) { }

	internal static void set_SuperProperties(Value value) { }

	internal static void set_TimedEvents(Value value) { }

	public static void SetPreferencesSource(IPreferences preferences) { }

}

