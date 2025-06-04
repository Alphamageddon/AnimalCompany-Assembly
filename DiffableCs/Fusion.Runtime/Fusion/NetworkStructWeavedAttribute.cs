namespace Fusion;

[AttributeUsage(AttributeTargets::Struct (8), Inherited = False, AllowMultiple = False)]
public sealed class NetworkStructWeavedAttribute : Attribute
{
	[CompilerGenerated]
	private readonly int <WordCount>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly bool <IsGenericComposite>k__BackingField; //Field offset: 0x14

	internal bool IsGenericComposite
	{
		[CompilerGenerated]
		internal get { } //Length: 8
	}

	public int WordCount
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public NetworkStructWeavedAttribute(int wordCount) { }

	internal NetworkStructWeavedAttribute(int wordCount, bool isGenericComposite) { }

	[CompilerGenerated]
	internal bool get_IsGenericComposite() { }

	[CompilerGenerated]
	public int get_WordCount() { }

}

