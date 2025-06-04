namespace UnityEngine;

[AttributeUsage(AttributeTargets::Field (256), Inherited = True, AllowMultiple = False)]
[UsedByNativeCode]
public abstract class PropertyAttribute : Attribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <order>k__BackingField; //Field offset: 0x10

	public int order
	{
		[CompilerGenerated]
		 set { } //Length: 8
	}

	protected PropertyAttribute() { }

	[CompilerGenerated]
	public void set_order(int value) { }

}

