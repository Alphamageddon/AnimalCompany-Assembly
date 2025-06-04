namespace UnityEngine.Rendering.Universal.LibTessDotNet;

[DefaultMember("Item")]
internal struct Vec3
{
	public static readonly Vec3 Zero; //Field offset: 0x0
	public float X; //Field offset: 0x0
	public float Y; //Field offset: 0x4
	public float Z; //Field offset: 0x8

	public float Item
	{
		 get { } //Length: 100
		 set { } //Length: 100
	}

	private static Vec3() { }

	public static void Dot(ref Vec3 u, ref Vec3 v, out float dot) { }

	public float get_Item(int index) { }

	public static int LongAxis(ref Vec3 v) { }

	public static void Neg(ref Vec3 v) { }

	public static void Normalize(ref Vec3 v) { }

	public void set_Item(int index, float value) { }

	public static void Sub(ref Vec3 lhs, ref Vec3 rhs, out Vec3 result) { }

	public virtual string ToString() { }

}

