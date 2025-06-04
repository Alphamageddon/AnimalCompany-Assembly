namespace Fusion;

public abstract class FieldsMask
{
	public Mask256 Mask; //Field offset: 0x10

	protected FieldsMask(Mask256 mask) { }

	protected FieldsMask(long a, long b, long c, long d) { }

	protected FieldsMask() { }

	public static Mask256 op_Implicit(FieldsMask mask) { }

}

