namespace Fusion;

[AttributeUsage(AttributeTargets::Field (256), AllowMultiple = False)]
public class ReadOnlyAttribute : DecoratingPropertyAttribute
{
	[CompilerGenerated]
	private bool <InPlayMode>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private bool <InEditMode>k__BackingField; //Field offset: 0x15

	public bool InEditMode
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public bool InPlayMode
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public ReadOnlyAttribute() { }

	[CompilerGenerated]
	public bool get_InEditMode() { }

	[CompilerGenerated]
	public bool get_InPlayMode() { }

	[CompilerGenerated]
	public void set_InEditMode(bool value) { }

	[CompilerGenerated]
	public void set_InPlayMode(bool value) { }

}

