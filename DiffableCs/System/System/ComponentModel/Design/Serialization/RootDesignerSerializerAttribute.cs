namespace System.ComponentModel.Design.Serialization;

[AttributeUsage(1028, AllowMultiple = True, Inherited = True)]
[Obsolete("This attribute has been deprecated. Use DesignerSerializerAttribute instead.  For example, to specify a root designer for CodeDom, use DesignerSerializerAttribute(...,typeof(TypeCodeDomSerializer)).  https://go.microsoft.com/fwlink/?linkid=14202")]
public sealed class RootDesignerSerializerAttribute : Attribute
{
	[CompilerGenerated]
	private readonly bool <Reloadable>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly string <SerializerTypeName>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly string <SerializerBaseTypeName>k__BackingField; //Field offset: 0x20

	public RootDesignerSerializerAttribute(string serializerTypeName, string baseSerializerTypeName, bool reloadable) { }

}

