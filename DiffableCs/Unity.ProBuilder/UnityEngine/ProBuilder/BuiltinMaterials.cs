namespace UnityEngine.ProBuilder;

public static class BuiltinMaterials
{
	private static bool s_IsInitialized; //Field offset: 0x0
	public const string faceShader = "Hidden/ProBuilder/FaceHighlight"; //Field offset: 0x0
	public const string lineShader = "Hidden/ProBuilder/LineBillboard"; //Field offset: 0x0
	public const string lineShaderMetal = "Hidden/ProBuilder/LineBillboardMetal"; //Field offset: 0x0
	public const string pointShader = "Hidden/ProBuilder/PointBillboard"; //Field offset: 0x0
	public const string wireShader = "Hidden/ProBuilder/FaceHighlight"; //Field offset: 0x0
	public const string dotShader = "Hidden/ProBuilder/VertexShader"; //Field offset: 0x0
	internal static readonly Color previewColor; //Field offset: 0x4
	private static Shader s_SelectionPickerShader; //Field offset: 0x18
	private static bool s_GeometryShadersSupported; //Field offset: 0x20
	private static Material s_DefaultMaterial; //Field offset: 0x28
	private static Material s_FacePickerMaterial; //Field offset: 0x30
	private static Material s_VertexPickerMaterial; //Field offset: 0x38
	private static Material s_EdgePickerMaterial; //Field offset: 0x40
	private static Material s_UnityDefaultDiffuse; //Field offset: 0x48
	private static Material s_UnlitVertexColorMaterial; //Field offset: 0x50
	private static Material s_ShapePreviewMaterial; //Field offset: 0x58
	private static string k_EdgePickerMaterial; //Field offset: 0x60
	private static string k_FacePickerMaterial; //Field offset: 0x68
	private static string k_VertexPickerMaterial; //Field offset: 0x70
	private static string k_EdgePickerShader; //Field offset: 0x78
	private static string k_FacePickerShader; //Field offset: 0x80
	private static string k_VertexPickerShader; //Field offset: 0x88

	internal static Material colliderMaterial
	{
		internal get { } //Length: 264
	}

	public static Material defaultMaterial
	{
		 get { } //Length: 92
	}

	internal static Material edgePickerMaterial
	{
		internal get { } //Length: 92
	}

	internal static Material facePickerMaterial
	{
		internal get { } //Length: 92
	}

	public static bool geometryShadersSupported
	{
		 get { } //Length: 92
	}

	[Obsolete("NoDraw is no longer supported.")]
	internal static Material noDrawMaterial
	{
		internal get { } //Length: 264
	}

	internal static Shader selectionPickerShader
	{
		internal get { } //Length: 92
	}

	internal static Material ShapePreviewMaterial
	{
		internal get { } //Length: 92
	}

	internal static Material triggerMaterial
	{
		internal get { } //Length: 264
	}

	internal static Material unlitVertexColor
	{
		internal get { } //Length: 92
	}

	internal static Material vertexPickerMaterial
	{
		internal get { } //Length: 92
	}

	private static BuiltinMaterials() { }

	internal static Material get_colliderMaterial() { }

	public static Material get_defaultMaterial() { }

	internal static Material get_edgePickerMaterial() { }

	internal static Material get_facePickerMaterial() { }

	public static bool get_geometryShadersSupported() { }

	internal static Material get_noDrawMaterial() { }

	internal static Shader get_selectionPickerShader() { }

	internal static Material get_ShapePreviewMaterial() { }

	internal static Material get_triggerMaterial() { }

	internal static Material get_unlitVertexColor() { }

	internal static Material get_vertexPickerMaterial() { }

	internal static Material GetDefaultMaterial() { }

	internal static Material GetLegacyDiffuse() { }

	private static void Init() { }

}

