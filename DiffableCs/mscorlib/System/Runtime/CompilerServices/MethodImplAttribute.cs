namespace System.Runtime.CompilerServices;

[AttributeUsage(96, Inherited = False)]
[ComVisible(True)]
public sealed class MethodImplAttribute : Attribute
{
	internal MethodImplOptions _val; //Field offset: 0x10

	public MethodImplAttribute(MethodImplOptions methodImplOptions) { }

	public MethodImplAttribute() { }

}

