namespace Photon.Voice;

public struct Flip
{
	public static Flip None; //Field offset: 0x0
	public static Flip Vertical; //Field offset: 0x2
	public static Flip Horizontal; //Field offset: 0x4
	public static Flip Both; //Field offset: 0x6
	[CompilerGenerated]
	private bool <IsVertical>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private bool <IsHorizontal>k__BackingField; //Field offset: 0x1

	public private bool IsHorizontal
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public private bool IsVertical
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 12
	}

	private static Flip() { }

	public virtual bool Equals(object obj) { }

	[CompilerGenerated]
	[IsReadOnly]
	public bool get_IsHorizontal() { }

	[CompilerGenerated]
	[IsReadOnly]
	public bool get_IsVertical() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(Flip f1, Flip f2) { }

	public static bool op_Inequality(Flip f1, Flip f2) { }

	public static Flip op_Multiply(Flip f1, Flip f2) { }

	[CompilerGenerated]
	private void set_IsHorizontal(bool value) { }

	[CompilerGenerated]
	private void set_IsVertical(bool value) { }

}

