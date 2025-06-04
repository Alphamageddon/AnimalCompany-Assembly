namespace Fusion;

[AttributeUsage(AttributeTargets::Property (128), AllowMultiple = False, Inherited = False)]
public sealed class NetworkedWeavedAttribute : Attribute
{
	[CompilerGenerated]
	private readonly int <WordOffset>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly int <WordCount>k__BackingField; //Field offset: 0x14

	public int WordCount
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public int WordOffset
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public NetworkedWeavedAttribute(int wordOffset, int wordCount) { }

	[CompilerGenerated]
	public int get_WordCount() { }

	[CompilerGenerated]
	public int get_WordOffset() { }

}

