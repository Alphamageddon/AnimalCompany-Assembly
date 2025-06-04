namespace Fusion;

[Preserve]
public class FusionGlobalScriptableObjectAddressAttribute : FusionGlobalScriptableObjectSourceAttribute
{
	[CompilerGenerated]
	private readonly string <Address>k__BackingField; //Field offset: 0x20

	public string Address
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public FusionGlobalScriptableObjectAddressAttribute(Type objectType, string address) { }

	[CompilerGenerated]
	public string get_Address() { }

	public virtual FusionGlobalScriptableObjectLoadResult Load(Type type) { }

}

