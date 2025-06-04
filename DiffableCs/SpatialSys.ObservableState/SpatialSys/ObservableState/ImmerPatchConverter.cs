namespace SpatialSys.ObservableState;

public static class ImmerPatchConverter
{
	private static Dictionary<OperationType, String> _opTypePairs; //Field offset: 0x0

	private static ImmerPatchConverter() { }

	public static ImmerPatch FromStateOp(StateOperation<T> op) { }

	public static JSONArray GetPath(IStateObject obj) { }

	private static void GetPathRecursive(IStateObject obj, JSONArray pathArray) { }

	public static bool TryConvertToImmerPatchType(OperationType operationType, out string immerPatchOpType) { }

}

