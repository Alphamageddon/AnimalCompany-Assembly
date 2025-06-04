namespace Fusion;

[AttributeUsage(320, Inherited = False, AllowMultiple = True)]
public sealed class DefaultForPropertyAttribute : PropertyAttribute
{
	[CompilerGenerated]
	private readonly string <PropertyName>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly int <WordOffset>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly int <WordCount>k__BackingField; //Field offset: 0x24

	public string PropertyName
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

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

	public DefaultForPropertyAttribute(string propertyName, int wordOffset, int wordCount) { }

	[CompilerGenerated]
	public string get_PropertyName() { }

	[CompilerGenerated]
	public int get_WordCount() { }

	[CompilerGenerated]
	public int get_WordOffset() { }

}

