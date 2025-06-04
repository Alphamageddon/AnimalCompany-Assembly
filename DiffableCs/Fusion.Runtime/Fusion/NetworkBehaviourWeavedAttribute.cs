namespace Fusion;

[AttributeUsage(AttributeTargets::Class (4), AllowMultiple = False, Inherited = False)]
public sealed class NetworkBehaviourWeavedAttribute : Attribute
{
	[CompilerGenerated]
	private readonly int <WordCount>k__BackingField; //Field offset: 0x10

	public int WordCount
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public NetworkBehaviourWeavedAttribute(int wordCount) { }

	[CompilerGenerated]
	public int get_WordCount() { }

}

