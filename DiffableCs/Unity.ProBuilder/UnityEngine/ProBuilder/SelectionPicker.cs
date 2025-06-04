namespace UnityEngine.ProBuilder;

public static class SelectionPicker
{

	public static Dictionary<ProBuilderMesh, HashSet`1<Edge>> PickEdgesInRect(Camera cam, Rect rect, IList<ProBuilderMesh> selectable, PickerOptions options, float pixelsPerPoint = 1) { }

	public static Face PickFace(Camera camera, Vector3 mousePosition, ProBuilderMesh pickable) { }

	public static Dictionary<ProBuilderMesh, HashSet`1<Face>> PickFacesInRect(Camera cam, Rect rect, IList<ProBuilderMesh> selectable, PickerOptions options, float pixelsPerPoint = 1) { }

	public static Dictionary<ProBuilderMesh, HashSet`1<Int32>> PickVerticesInRect(Camera cam, Rect rect, IList<ProBuilderMesh> selectable, PickerOptions options, float pixelsPerPoint = 1) { }

}

