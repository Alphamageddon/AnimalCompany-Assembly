namespace Fusion;

[AttributeUsage(AttributeTargets::Field (256))]
public class ExpandableEnumAttribute : DrawerPropertyAttribute
{
	[CompilerGenerated]
	private bool <AlwaysExpanded>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private bool <ShowFlagsButtons>k__BackingField; //Field offset: 0x15
	[CompilerGenerated]
	private bool <ShowInlineHelp>k__BackingField; //Field offset: 0x16

	public bool AlwaysExpanded
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public bool ShowFlagsButtons
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public bool ShowInlineHelp
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public ExpandableEnumAttribute() { }

	[CompilerGenerated]
	public bool get_AlwaysExpanded() { }

	[CompilerGenerated]
	public bool get_ShowFlagsButtons() { }

	[CompilerGenerated]
	public bool get_ShowInlineHelp() { }

	[CompilerGenerated]
	public void set_AlwaysExpanded(bool value) { }

	[CompilerGenerated]
	public void set_ShowFlagsButtons(bool value) { }

	[CompilerGenerated]
	public void set_ShowInlineHelp(bool value) { }

}

