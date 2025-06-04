namespace Fusion;

[AttributeUsage(AttributeTargets::Property (128))]
[Conditional("UNITY_2020_1_OR_NEWER")]
[Conditional("UNITY_EDITOR")]
[Conditional("FUSION_UNITY")]
[UnityPropertyAttributeProxy(typeof(MinAttribute))]
public sealed class UnityMinAttribute : Attribute
{
	[CompilerGenerated]
	private int <order>k__BackingField; //Field offset: 0x10

	public int order
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public UnityMinAttribute(float min) { }

	[CompilerGenerated]
	public int get_order() { }

	[CompilerGenerated]
	public void set_order(int value) { }

}

