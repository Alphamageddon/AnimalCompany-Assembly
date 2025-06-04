namespace UnityEngine;

[AttributeUsage(AttributeTargets::Field (256), Inherited = True, AllowMultiple = True)]
public class HeaderAttribute : PropertyAttribute
{
	public readonly string header; //Field offset: 0x18

	public HeaderAttribute(string header) { }

}

