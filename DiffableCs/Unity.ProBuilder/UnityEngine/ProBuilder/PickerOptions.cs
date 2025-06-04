namespace UnityEngine.ProBuilder;

public struct PickerOptions
{
	private static readonly PickerOptions k_Default; //Field offset: 0x0
	[CompilerGenerated]
	private bool <depthTest>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private RectSelectMode <rectSelectMode>k__BackingField; //Field offset: 0x4

	public static PickerOptions Default
	{
		 get { } //Length: 88
	}

	public bool depthTest
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public RectSelectMode rectSelectMode
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	private static PickerOptions() { }

	public virtual bool Equals(object obj) { }

	public bool Equals(PickerOptions other) { }

	public static PickerOptions get_Default() { }

	[CompilerGenerated]
	[IsReadOnly]
	public bool get_depthTest() { }

	[CompilerGenerated]
	[IsReadOnly]
	public RectSelectMode get_rectSelectMode() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(PickerOptions a, PickerOptions b) { }

	public static bool op_Inequality(PickerOptions a, PickerOptions b) { }

	[CompilerGenerated]
	public void set_depthTest(bool value) { }

	[CompilerGenerated]
	public void set_rectSelectMode(RectSelectMode value) { }

}

