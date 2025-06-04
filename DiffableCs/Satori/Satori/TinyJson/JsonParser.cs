namespace Satori.TinyJson;

[Extension]
public static class JsonParser
{
	[ThreadStatic]
	private static Stack<List`1<String>> _splitArrayPool; //Field offset: 0x80000000
	[ThreadStatic]
	private static StringBuilder _stringBuilder; //Field offset: 0x80000008
	[ThreadStatic]
	private static Dictionary<Type, Dictionary`2<String, FieldInfo>> _fieldInfoCache; //Field offset: 0x80000010
	[ThreadStatic]
	private static Dictionary<Type, Dictionary`2<String, PropertyInfo>> _propertyInfoCache; //Field offset: 0x80000018

	private static int AppendUntilStringEnd(bool appendEscapeCharacter, int startIdx, string json) { }

	private static Dictionary<String, T> CreateMemberNameDictionary(IEnumerable<T> members) { }

	[Extension]
	public static T FromJson(string json) { }

	private static object ParseAnonymousValue(string json) { }

	private static object ParseObject(Type type, string json) { }

	private static object ParseValue(Type type, string json) { }

	private static List<String> Split(string json) { }

}

