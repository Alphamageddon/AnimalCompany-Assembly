namespace Fusion;

[NetworkStructWeaved(4)]
public struct Vector4Compressed : INetworkStruct, IEquatable<Vector4Compressed>
{
	public int xEncoded; //Field offset: 0x0
	public int yEncoded; //Field offset: 0x4
	public int zEncoded; //Field offset: 0x8
	public int wEncoded; //Field offset: 0xC

	public float W
	{
		 get { } //Length: 108
		 set { } //Length: 164
	}

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

	public override bool Equals(Vector4Compressed other) { }

	public virtual bool Equals(object obj) { }

	public float get_W() { }

	public float get_X() { }

	public float get_Y() { }

	public float get_Z() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(Vector4Compressed left, Vector4Compressed right) { }

	public static Vector4Compressed op_Implicit(Vector4 v) { }

	public static Vector4 op_Implicit(Vector4Compressed q) { }

	public static bool op_Inequality(Vector4Compressed left, Vector4Compressed right) { }

	public void set_W(float value) { }

	public void set_X(float value) { }

	public void set_Y(float value) { }

	public void set_Z(float value) { }

}

