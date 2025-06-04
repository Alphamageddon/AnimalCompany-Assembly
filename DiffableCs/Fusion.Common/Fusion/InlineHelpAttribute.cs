namespace Fusion;

[AttributeUsage(268)]
public class InlineHelpAttribute : DecoratingPropertyAttribute
{
	private const int DefaultOrder = -9000; //Field offset: 0x0
	[CompilerGenerated]
	private bool <ShowTypeHelp>k__BackingField; //Field offset: 0x14

	public bool ShowTypeHelp
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public InlineHelpAttribute() { }

	[CompilerGenerated]
	public bool get_ShowTypeHelp() { }

	[CompilerGenerated]
	public void set_ShowTypeHelp(bool value) { }

}

