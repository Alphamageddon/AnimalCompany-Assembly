namespace Fusion;

[AttributeUsage(AttributeTargets::Field (256))]
public class SerializeReferenceTypePickerAttribute : DecoratingPropertyAttribute
{
	public bool GroupTypesByNamespace; //Field offset: 0x14
	public bool ShowFullName; //Field offset: 0x15
	[CompilerGenerated]
	private Type[] <Types>k__BackingField; //Field offset: 0x18

	public private Type[] Types
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public SerializeReferenceTypePickerAttribute(Type[] types) { }

	[CompilerGenerated]
	public Type[] get_Types() { }

	[CompilerGenerated]
	private void set_Types(Type[] value) { }

}

