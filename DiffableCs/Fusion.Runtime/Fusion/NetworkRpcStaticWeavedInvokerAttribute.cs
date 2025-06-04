namespace Fusion;

[AttributeUsage(AttributeTargets::Method (64), Inherited = False, AllowMultiple = False)]
public class NetworkRpcStaticWeavedInvokerAttribute : Attribute
{
	[CompilerGenerated]
	private readonly string <Key>k__BackingField; //Field offset: 0x10

	public string Key
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public NetworkRpcStaticWeavedInvokerAttribute(string key) { }

	[CompilerGenerated]
	public string get_Key() { }

}

