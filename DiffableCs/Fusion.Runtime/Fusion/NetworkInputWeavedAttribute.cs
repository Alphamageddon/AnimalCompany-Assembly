namespace Fusion;

[AttributeUsage(AttributeTargets::Struct (8), Inherited = False, AllowMultiple = False)]
public sealed class NetworkInputWeavedAttribute : Attribute
{
	[CompilerGenerated]
	private readonly int <WordCount>k__BackingField; //Field offset: 0x10

	public int WordCount
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public NetworkInputWeavedAttribute(int wordCount) { }

	[CompilerGenerated]
	public int get_WordCount() { }

}

