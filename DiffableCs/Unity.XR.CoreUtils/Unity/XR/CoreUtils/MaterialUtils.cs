namespace Unity.XR.CoreUtils;

[Extension]
public static class MaterialUtils
{

	[Extension]
	public static void AddMaterial(Renderer renderer, Material material) { }

	public static Material[] CloneMaterials(Renderer renderer) { }

	public static Material GetMaterialClone(Renderer renderer) { }

	public static Material GetMaterialClone(Graphic graphic) { }

	public static Color HexToColor(string hex) { }

	public static Color HueShift(Color color, float shift) { }

}

