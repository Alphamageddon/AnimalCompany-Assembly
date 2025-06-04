namespace AnimalCompany;

public static class Analytics
{
	private static bool ANALYTICS_ENABLED; //Field offset: 0x0

	private static Analytics() { }

	private static Value ObjectsToValue(Dictionary<String, Object> dict) { }

	private static Value ObjectsToValue(ValueTuple<String, Object>[] objects) { }

	private static Value ObjectToValue(object obj) { }

	public static void Register(string propertyName, object propertyValue) { }

	public static void Track(string eventName) { }

	public static void Track(string eventName, Dictionary<String, Object> properties) { }

	public static void Track(string eventName, ValueTuple<String, Object>[] properties) { }

	public static void Track(string eventName, string propertyName, object propertyValue) { }

}

