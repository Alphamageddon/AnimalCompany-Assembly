namespace Fusion;

[NetworkStructWeaved(4)]
public struct QuaternionCompressed : INetworkStruct, IEquatable<QuaternionCompressed>
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

	public override bool Equals(QuaternionCompressed other) { }

	public virtual bool Equals(object obj) { }

	public float get_W() { }

	public float get_X() { }

	public float get_Y() { }

	public float get_Z() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(QuaternionCompressed left, QuaternionCompressed right) { }

	public static QuaternionCompressed op_Implicit(Quaternion v) { }

	public static Quaternion op_Implicit(QuaternionCompressed q) { }

	public static bool op_Inequality(QuaternionCompressed left, QuaternionCompressed right) { }

	public void set_W(float value) { }

	public void set_X(float value) { }

	public void set_Y(float value) { }

	public void set_Z(float value) { }

}

