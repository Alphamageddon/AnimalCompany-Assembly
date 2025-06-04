namespace Fusion;

[AttributeUsage(AttributeTargets::Property (128), Inherited = False, AllowMultiple = True)]
public sealed class CapacityAttribute : Attribute
{
	[CompilerGenerated]
	private readonly int <Length>k__BackingField; //Field offset: 0x10

	public int Length
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public CapacityAttribute(int length) { }

	[CompilerGenerated]
	public int get_Length() { }

}

