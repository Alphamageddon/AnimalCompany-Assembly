namespace Fusion;

[AttributeUsage(12)]
public class ScriptHelpAttribute : PropertyAttribute
{
	[CompilerGenerated]
	private bool <Hide>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private string <Url>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private ScriptHeaderBackColor <BackColor>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private ScriptHeaderStyle <Style>k__BackingField; //Field offset: 0x24

	public ScriptHeaderBackColor BackColor
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public bool Hide
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public ScriptHeaderStyle Style
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public string Url
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public ScriptHelpAttribute() { }

	[CompilerGenerated]
	public ScriptHeaderBackColor get_BackColor() { }

	[CompilerGenerated]
	public bool get_Hide() { }

	[CompilerGenerated]
	public ScriptHeaderStyle get_Style() { }

	[CompilerGenerated]
	public string get_Url() { }

	[CompilerGenerated]
	public void set_BackColor(ScriptHeaderBackColor value) { }

	[CompilerGenerated]
	public void set_Hide(bool value) { }

	[CompilerGenerated]
	public void set_Style(ScriptHeaderStyle value) { }

	[CompilerGenerated]
	public void set_Url(string value) { }

}

