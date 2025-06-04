namespace Fusion;

[NetworkStructWeaved(3)]
public struct Vector3Compressed : INetworkStruct, IEquatable<Vector3Compressed>
{
	public int xEncoded; //Field offset: 0x0
	public int yEncoded; //Field offset: 0x4
	public int zEncoded; //Field offset: 0x8

	public float X
	{
		 get { } //Length: 108
		 set { } //Length: 164
	}

	public float Y
	{
		 get { } //Length: 108
		 set { } //Length: 164
	}

	public float Z
	{
		 get { } //Length: 108
		 set { } //Length: 164
	}

	public override bool Equals(Vector3Compressed other) { }

	public virtual bool Equals(object obj) { }

	public float get_X() { }

	public float get_Y() { }

	public float get_Z() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(Vector3Compressed left, Vector3Compressed right) { }

	public static Vector3Compressed op_Implicit(Vector3 v) { }

	public static Vector3 op_Implicit(Vector3Compressed q) { }

	public static Vector3Compressed op_Implicit(Vector2 v) { }

	public static Vector2 op_Implicit(Vector3Compressed q) { }

	public static bool op_Inequality(Vector3Compressed left, Vector3Compressed right) { }

	public void set_X(float value) { }

	public void set_Y(float value) { }

	public void set_Z(float value) { }

}

