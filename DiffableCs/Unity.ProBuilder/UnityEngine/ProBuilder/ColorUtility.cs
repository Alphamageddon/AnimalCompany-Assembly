namespace UnityEngine.ProBuilder;

internal static class ColorUtility
{
	private static readonly Dictionary<String, CIELabColor> ColorNameLookup; //Field offset: 0x0

	private static ColorUtility() { }

	private static bool approx(float lhs, float rhs) { }

	private static CIELabColor CIELabFromRGB(float R, float G, float B, float Scale) { }

	public static float DeltaE(CIELabColor lhs, CIELabColor rhs) { }

	public static Color GetColor(Vector3 vec) { }

	public static string GetColorName(Color InColor) { }

	public static Color HSVtoRGB(HSVColor hsv) { }

	public static Color HSVtoRGB(float h, float s, float v) { }

	public static HSVColor RGBtoHSV(Color color) { }

	public static XYZColor RGBToXYZ(Color col) { }

	public static XYZColor RGBToXYZ(float r, float g, float b) { }

	public static CIELabColor XYZToCIE_Lab(XYZColor xyz) { }

}

