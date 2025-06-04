namespace Fusion;

[AttributeUsage(AttributeTargets::Class (4))]
public class FusionGlobalScriptableObjectAttribute : Attribute
{
	[CompilerGenerated]
	private readonly string <DefaultPath>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <DefaultContents>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <DefaultContentsGeneratorMethod>k__BackingField; //Field offset: 0x20

	public string DefaultContents
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public string DefaultContentsGeneratorMethod
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public string DefaultPath
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public FusionGlobalScriptableObjectAttribute(string defaultPath) { }

	[CompilerGenerated]
	public string get_DefaultContents() { }

	[CompilerGenerated]
	public string get_DefaultContentsGeneratorMethod() { }

	[CompilerGenerated]
	public string get_DefaultPath() { }

	[CompilerGenerated]
	public void set_DefaultContents(string value) { }

	[CompilerGenerated]
	public void set_DefaultContentsGeneratorMethod(string value) { }

}

