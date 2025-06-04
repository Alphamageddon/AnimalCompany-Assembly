namespace Fusion;

[AttributeUsage(AttributeTargets::Field (256))]
public sealed class UnityResourcePathAttribute : DrawerPropertyAttribute
{
	[CompilerGenerated]
	private readonly Type <ResourceType>k__BackingField; //Field offset: 0x18

	public Type ResourceType
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public UnityResourcePathAttribute(Type resourceType) { }

	[CompilerGenerated]
	public Type get_ResourceType() { }

}

