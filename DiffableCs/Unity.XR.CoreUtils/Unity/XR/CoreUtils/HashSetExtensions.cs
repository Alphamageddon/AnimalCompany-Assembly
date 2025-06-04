namespace Unity.XR.CoreUtils;

[Extension]
public static class HashSetExtensions
{

	[Extension]
	public static void ExceptWithNonAlloc(HashSet<T> self, HashSet<T> other) { }

	[Extension]
	public static T First(HashSet<T> set) { }

}

