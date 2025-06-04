namespace UnityEngine.ProBuilder;

internal sealed class HSVColor
{
	public float h; //Field offset: 0x10
	public float s; //Field offset: 0x14
	public float v; //Field offset: 0x18

	public HSVColor(float h, float s, float v) { }

	public HSVColor(float h, float s, float v, float sv_modifier) { }

	public static HSVColor FromRGB(Color col) { }

	public float SqrDistance(HSVColor InColor) { }

	public virtual string ToString() { }

}

