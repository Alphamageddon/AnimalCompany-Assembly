namespace UnityEngine.ProBuilder;

internal sealed class XYZColor
{
	public float x; //Field offset: 0x10
	public float y; //Field offset: 0x14
	public float z; //Field offset: 0x18

	public XYZColor(float x, float y, float z) { }

	public static XYZColor FromRGB(Color col) { }

	public static XYZColor FromRGB(float R, float G, float B) { }

	public virtual string ToString() { }

}

