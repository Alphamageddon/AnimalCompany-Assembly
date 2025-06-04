namespace mixpanel;

public static class Mixpanel
{
	internal static class People
	{

		public static string Email
		{
			 set { } //Length: 136
		}

		public static string FirstName
		{
			 set { } //Length: 136
		}

		public static string LastName
		{
			 set { } //Length: 136
		}

		public static string Name
		{
			 set { } //Length: 136
		}

		public static void Append(Value properties) { }

		public static void Append(string property, Value values) { }

		public static void ClearCharges() { }

		public static void DeleteUser() { }

		public static void Increment(Value properties) { }

		public static void Increment(string property, Value by) { }

		public static void Set(Value properties) { }

		public static void Set(string property, Value to) { }

		public static void set_Email(string value) { }

		public static void set_FirstName(string value) { }

		public static void set_LastName(string value) { }

		public static void set_Name(string value) { }

		public static void SetOnce(Value properties) { }

		public static void SetOnce(string property, Value to) { }

		public static void TrackCharge(Value properties) { }

		public static void TrackCharge(double amount, Value properties) { }

		public static void TrackCharge(double amount) { }

		public static void Union(Value properties) { }

		public static void Union(string property, Value values) { }

		public static void Unset(string property) { }

	}

	internal const string MixpanelUnityVersion = "3.5.2"; //Field offset: 0x0

	public static string DistinctId
	{
		 get { } //Length: 76
	}

	[Obsolete("Please use 'DistinctId' instead!")]
	public static string DistinctID
	{
		 get { } //Length: 76
	}

	public static void Alias(string alias) { }

	public static void Clear() { }

	public static void ClearSuperProperties() { }

	public static void ClearTimedEvent(string eventName) { }

	public static void ClearTimedEvents() { }

	public static void Disable() { }

	public static void Flush(Action<Boolean> onFlushComplete = null) { }

	public static string get_DistinctId() { }

	public static string get_DistinctID() { }

	public static void Identify(string uniqueId) { }

	public static void Init() { }

	public static bool IsInitialized() { }

	public static void Log(string s) { }

	public static void LogError(string s) { }

	public static void OptInTracking() { }

	public static void OptInTracking(string distinctId) { }

	public static void OptOutTracking() { }

	public static void Register(string key, Value value) { }

	public static void RegisterOnce(string key, Value value) { }

	public static void Reset() { }

	public static void SetPreferencesSource(IPreferences preferences) { }

	public static void SetToken(string token) { }

	public static void StartTimedEvent(string eventName) { }

	public static void StartTimedEventOnce(string eventName) { }

	public static void Track(string eventName) { }

	public static void Track(string eventName, string key, Value value) { }

	public static void Track(string eventName, Value properties) { }

	public static void Unregister(string key) { }

}

