namespace Fusion;

[AttributeUsage(AttributeTargets::Method (64))]
public class EditorButtonAttribute : Attribute
{
	public string Label; //Field offset: 0x10
	public EditorButtonVisibility Visibility; //Field offset: 0x18
	public int Priority; //Field offset: 0x1C
	public bool AllowMultipleTargets; //Field offset: 0x20
	public bool DirtyObject; //Field offset: 0x21

	public EditorButtonAttribute(string label, EditorButtonVisibility visibility = 2, int priority = 0, bool dirtyObject = false) { }

	public EditorButtonAttribute(EditorButtonVisibility visibility = 2, int priority = 0, bool dirtyObject = false) { }

}

