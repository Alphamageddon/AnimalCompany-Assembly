namespace SpatialSys.ObservableState;

[Extension]
public static class ObservableStateExtensions
{

	[Extension]
	public static void AddRange(StateList<StatePrimitive`1<T>> list, IEnumerable<T> collection) { }

	[Extension]
	public static void AssignValues(StateList<StatePrimitive`1<T>> list, T[] values) { }

}

