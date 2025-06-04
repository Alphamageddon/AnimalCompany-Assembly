namespace UnityEngine;

[AttributeUsage(AttributeTargets::Method (64))]
public class BeforeRenderOrderAttribute : Attribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <order>k__BackingField; //Field offset: 0x10

	public private int order
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public BeforeRenderOrderAttribute(int order) { }

	[CompilerGenerated]
	public int get_order() { }

	[CompilerGenerated]
	private void set_order(int value) { }

}

