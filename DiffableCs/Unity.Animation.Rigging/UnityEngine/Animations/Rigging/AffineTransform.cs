namespace UnityEngine.Animations.Rigging;

public struct AffineTransform
{
	[CompilerGenerated]
	private static readonly AffineTransform <identity>k__BackingField; //Field offset: 0x0
	public Vector3 translation; //Field offset: 0x0
	public Quaternion rotation; //Field offset: 0xC

	public static AffineTransform identity
	{
		[CompilerGenerated]
		 get { } //Length: 104
	}

	private static AffineTransform() { }

	public AffineTransform(Vector3 t, Quaternion r) { }

	[CompilerGenerated]
	public static AffineTransform get_identity() { }

	public AffineTransform Inverse() { }

	public AffineTransform InverseMul(AffineTransform transform) { }

	public Vector3 InverseTransform(Vector3 p) { }

	public static Vector3 op_Multiply(AffineTransform lhs, Vector3 rhs) { }

	public static AffineTransform op_Multiply(AffineTransform lhs, AffineTransform rhs) { }

	public static AffineTransform op_Multiply(Quaternion lhs, AffineTransform rhs) { }

	public static AffineTransform op_Multiply(AffineTransform lhs, Quaternion rhs) { }

	public void Set(Vector3 t, Quaternion r) { }

	public Vector3 Transform(Vector3 p) { }

}

