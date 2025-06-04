namespace Unity.XR.CoreUtils.GUI;

public sealed class EnumDisplayAttribute : PropertyAttribute
{
	public String[] Names; //Field offset: 0x18
	public Int32[] Values; //Field offset: 0x20

	public EnumDisplayAttribute(Object[] enumValues) { }

}

