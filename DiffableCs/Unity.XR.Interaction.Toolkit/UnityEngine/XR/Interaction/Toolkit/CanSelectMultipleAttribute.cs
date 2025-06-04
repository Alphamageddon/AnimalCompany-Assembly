namespace UnityEngine.XR.Interaction.Toolkit;

[AttributeUsage(AttributeTargets::Class (4))]
public sealed class CanSelectMultipleAttribute : Attribute
{
	[CompilerGenerated]
	private readonly bool <allowMultiple>k__BackingField; //Field offset: 0x10

	public bool allowMultiple
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public CanSelectMultipleAttribute(bool allowMultiple = true) { }

	[CompilerGenerated]
	public bool get_allowMultiple() { }

}

