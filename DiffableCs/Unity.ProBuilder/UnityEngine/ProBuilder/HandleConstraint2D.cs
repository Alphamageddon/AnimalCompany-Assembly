namespace UnityEngine.ProBuilder;

internal sealed class HandleConstraint2D
{
	public static readonly HandleConstraint2D None; //Field offset: 0x0
	public int x; //Field offset: 0x10
	public int y; //Field offset: 0x14

	private static HandleConstraint2D() { }

	public HandleConstraint2D(int x, int y) { }

	public virtual bool Equals(object o) { }

	public virtual int GetHashCode() { }

	public HandleConstraint2D Inverse() { }

	public Vector2 InverseMask(Vector2 v) { }

	public Vector2 Mask(Vector2 v) { }

	public static bool op_Equality(HandleConstraint2D a, HandleConstraint2D b) { }

	public static bool op_Inequality(HandleConstraint2D a, HandleConstraint2D b) { }

	public virtual string ToString() { }

}

