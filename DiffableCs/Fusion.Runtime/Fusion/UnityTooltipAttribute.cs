namespace Fusion;

[AttributeUsage(AttributeTargets::Property (128))]
[Conditional("UNITY_EDITOR")]
[Conditional("FUSION_UNITY")]
[Conditional("UNITY_2020_1_OR_NEWER")]
[UnityPropertyAttributeProxy(typeof(TooltipAttribute))]
public sealed class UnityTooltipAttribute : Attribute
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

	public UnityTooltipAttribute(string tooltip) { }

	[CompilerGenerated]
	public int get_order() { }

	[CompilerGenerated]
	public void set_order(int value) { }

}

