namespace Fusion;

[AttributeUsage(AttributeTargets::Field (256), AllowMultiple = True)]
public class FieldEditorButtonAttribute : DecoratingPropertyAttribute
{
	public string Label; //Field offset: 0x18
	public bool AllowMultipleTargets; //Field offset: 0x20
	public string TargetMethod; //Field offset: 0x28

	public FieldEditorButtonAttribute(string label, string targetMethod) { }

}

