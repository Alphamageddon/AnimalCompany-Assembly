namespace Fusion;

[AttributeUsage(AttributeTargets::Field (256))]
public class DisplayAsEnumAttribute : DrawerPropertyAttribute
{
	[CompilerGenerated]
	private readonly Type <EnumType>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly string <EnumTypeMemberName>k__BackingField; //Field offset: 0x20

	public Type EnumType
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public string EnumTypeMemberName
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public DisplayAsEnumAttribute(Type enumType) { }

	public DisplayAsEnumAttribute(string enumTypeMemberName) { }

	[CompilerGenerated]
	public Type get_EnumType() { }

	[CompilerGenerated]
	public string get_EnumTypeMemberName() { }

}

