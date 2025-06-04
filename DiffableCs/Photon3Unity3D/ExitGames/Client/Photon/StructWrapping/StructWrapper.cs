namespace ExitGames.Client.Photon.StructWrapping;

public abstract class StructWrapper : IDisposable
{
	public readonly WrappedType wrappedType; //Field offset: 0x10
	public readonly Type ttype; //Field offset: 0x18

	public StructWrapper(Type ttype, WrappedType wrappedType) { }

	public abstract object Box() { }

	public abstract void DisconnectFromPool() { }

	public abstract void Dispose() { }

	public static Vector2 op_Implicit(StructWrapper wrapper) { }

	public static StructWrapper op_Implicit(Quaternion value) { }

	public static StructWrapper op_Implicit(Vector3 value) { }

	public static StructWrapper op_Implicit(Vector2 value) { }

	public static long op_Implicit(StructWrapper wrapper) { }

	public static int op_Implicit(StructWrapper wrapper) { }

	public static short op_Implicit(StructWrapper wrapper) { }

	public static double op_Implicit(StructWrapper wrapper) { }

	public static float op_Implicit(StructWrapper wrapper) { }

	public static bool op_Implicit(StructWrapper wrapper) { }

	public static Vector3 op_Implicit(StructWrapper wrapper) { }

	public static StructWrapper op_Implicit(long value) { }

	public static StructWrapper op_Implicit(int value) { }

	public static StructWrapper op_Implicit(short value) { }

	public static StructWrapper op_Implicit(double value) { }

	public static StructWrapper op_Implicit(float value) { }

	public static StructWrapper op_Implicit(byte value) { }

	public static StructWrapper op_Implicit(bool value) { }

	public static byte op_Implicit(StructWrapper wrapper) { }

	public static Quaternion op_Implicit(StructWrapper wrapper) { }

	public abstract string ToString(bool writeType) { }

}

