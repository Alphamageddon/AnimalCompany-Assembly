namespace Fusion;

[AttributeUsage(AttributeTargets::Method (64), AllowMultiple = False, Inherited = False)]
public sealed class NetworkSerializeMethodAttribute : Attribute
{
	[CompilerGenerated]
	private int <MaxSize>k__BackingField; //Field offset: 0x10

	public int MaxSize
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public NetworkSerializeMethodAttribute() { }

	[CompilerGenerated]
	public int get_MaxSize() { }

	[CompilerGenerated]
	public void set_MaxSize(int value) { }

}

