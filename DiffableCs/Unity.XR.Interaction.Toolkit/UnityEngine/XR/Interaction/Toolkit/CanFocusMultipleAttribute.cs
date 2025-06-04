namespace UnityEngine.XR.Interaction.Toolkit;

[AttributeUsage(AttributeTargets::Class (4))]
public sealed class CanFocusMultipleAttribute : Attribute
{
	[CompilerGenerated]
	private readonly bool <allowMultiple>k__BackingField; //Field offset: 0x10

	public bool allowMultiple
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public CanFocusMultipleAttribute(bool allowMultiple = true) { }

	[CompilerGenerated]
	public bool get_allowMultiple() { }

}

