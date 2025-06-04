namespace Unity.XR.CoreUtils.Capabilities;

[AttributeUsage(AttributeTargets::Field (256))]
public sealed class CustomCapabilityKeyAttribute : Attribute
{
	public readonly int Order; //Field offset: 0x10

	public CustomCapabilityKeyAttribute(int order = 1000) { }

}

