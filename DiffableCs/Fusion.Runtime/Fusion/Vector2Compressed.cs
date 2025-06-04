namespace Fusion;

[NetworkStructWeaved(2)]
public struct Vector2Compressed : INetworkStruct, IEquatable<Vector2Compressed>
{
	public int xEncoded; //Field offset: 0x0
	public int yEncoded; //Field offset: 0x4

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

	public override bool Equals(Vector2Compressed other) { }

	public virtual bool Equals(object obj) { }

	public float get_X() { }

	public float get_Y() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(Vector2Compressed left, Vector2Compressed right) { }

	public static Vector2Compressed op_Implicit(Vector2 v) { }

	public static Vector2 op_Implicit(Vector2Compressed q) { }

	public static bool op_Inequality(Vector2Compressed left, Vector2Compressed right) { }

	public void set_X(float value) { }

	public void set_Y(float value) { }

}

