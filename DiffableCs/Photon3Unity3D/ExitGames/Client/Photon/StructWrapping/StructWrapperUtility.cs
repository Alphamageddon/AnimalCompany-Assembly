namespace ExitGames.Client.Photon.StructWrapping;

[Extension]
public static class StructWrapperUtility
{

	[Extension]
	public static void BoxAll(Hashtable table, bool recursive = false) { }

	[Extension]
	public static T DisconnectPooling(T table) { }

	[Extension]
	public static T Get(Hashtable table, byte key) { }

	[Extension]
	public static T Get(object obj) { }

	[Extension]
	public static Type GetWrappedType(object obj) { }

	[Extension]
	public static bool IsType(object obj) { }

	[Extension]
	public static List<Object> ReleaseAllWrappers(List<Object> collection) { }

	[Extension]
	public static Object[] ReleaseAllWrappers(Object[] collection) { }

	[Extension]
	public static Hashtable ReleaseAllWrappers(Hashtable table) { }

	[Extension]
	public static bool TryGetValue(Hashtable table, byte key, out T value) { }

	[Extension]
	public static bool TryGetValue(Hashtable table, object key, out T value) { }

	[Extension]
	public static bool TryUnwrapValue(Hashtable table, byte key, out T value) { }

	[Extension]
	public static bool TryUnwrapValue(Hashtable table, object key, out T value) { }

	[Extension]
	public static T Unwrap(Hashtable table, byte key) { }

	[Extension]
	public static T Unwrap(object obj) { }

	[Extension]
	public static T Unwrap(Hashtable table, object key) { }

	[Extension]
	public static StructWrapper<Byte> Wrap(byte value) { }

	[Extension]
	public static StructWrapper<T> Wrap(T value) { }

	[Extension]
	public static StructWrapper<T> Wrap(T value, bool persistant) { }

	[Extension]
	public static StructWrapper<Boolean> Wrap(bool value) { }

}

