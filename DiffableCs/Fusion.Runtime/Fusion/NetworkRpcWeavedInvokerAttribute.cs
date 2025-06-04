namespace Fusion;

[AttributeUsage(AttributeTargets::Method (64), Inherited = False, AllowMultiple = False)]
public class NetworkRpcWeavedInvokerAttribute : Attribute
{
	[CompilerGenerated]
	private readonly int <Key>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly int <Sources>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private readonly int <Targets>k__BackingField; //Field offset: 0x18

	public int Key
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public int Sources
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public int Targets
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public NetworkRpcWeavedInvokerAttribute(int key, int sources, int targets) { }

	[CompilerGenerated]
	public int get_Key() { }

	[CompilerGenerated]
	public int get_Sources() { }

	[CompilerGenerated]
	public int get_Targets() { }

}

