namespace UnityEngine.ProBuilder;

internal sealed class CIELabColor
{
	public float L; //Field offset: 0x10
	public float a; //Field offset: 0x14
	public float b; //Field offset: 0x18

	public CIELabColor(float L, float a, float b) { }

	public static CIELabColor FromRGB(Color col) { }

	public static CIELabColor FromXYZ(XYZColor xyz) { }

	public virtual string ToString() { }

}

