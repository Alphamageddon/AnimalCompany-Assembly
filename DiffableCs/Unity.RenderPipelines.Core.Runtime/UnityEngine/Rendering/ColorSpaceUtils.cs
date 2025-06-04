namespace UnityEngine.Rendering;

internal static class ColorSpaceUtils
{
	public static readonly Matrix4x4 Rec709ToRec2020Mat; //Field offset: 0x0
	public static readonly Matrix4x4 Rec709ToP3D65Mat; //Field offset: 0x40
	public static readonly Matrix4x4 Rec2020ToRec709Mat; //Field offset: 0x80
	public static readonly Matrix4x4 Rec2020ToP3D65Mat; //Field offset: 0xC0
	public static readonly Matrix4x4 P3D65ToRec2020Mat; //Field offset: 0x100

	private static ColorSpaceUtils() { }

}

