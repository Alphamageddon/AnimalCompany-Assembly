namespace UnityEngine.ProBuilder;

internal static class SelectionPickerRenderer
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Face, IEnumerable`1<Int32>> <>9__24_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal IEnumerable<Int32> <GenerateFacePickingObjects>b__24_0(Face x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public Vector3[] positions; //Field offset: 0x10
		public SharedVertex[] sharedVertices; //Field offset: 0x18

		public <>c__DisplayClass19_0() { }

		internal int <PickVerticesInRect>b__0(int x) { }

	}

	public interface ISelectionPickerRenderer
	{

		public Texture2D RenderLookupTexture(Camera camera, Shader shader, string tag, int width, int height) { }

	}

	public class SelectionPickerRendererHDRP : ISelectionPickerRenderer
	{

		public SelectionPickerRendererHDRP() { }

		public override Texture2D RenderLookupTexture(Camera camera, Shader shader, string tag, int width = -1, int height = -1) { }

	}

	public class SelectionPickerRendererStandard : ISelectionPickerRenderer
	{

		public SelectionPickerRendererStandard() { }

		public override Texture2D RenderLookupTexture(Camera camera, Shader shader, string tag, int width = -1, int height = -1) { }

	}

	private const string k_FacePickerOcclusionTintUniform = "_Tint"; //Field offset: 0x0
	private static readonly Color k_Blackf; //Field offset: 0x0
	private const uint k_PickerHashNone = 0; //Field offset: 0x0
	private const uint k_PickerHashMin = 1; //Field offset: 0x0
	private const uint k_PickerHashMax = 16777215; //Field offset: 0x0
	private const uint k_MinEdgePixelsForValidSelection = 1; //Field offset: 0x0
	private static readonly Color k_Whitef; //Field offset: 0x10
	private static bool s_Initialized; //Field offset: 0x20
	private static ISelectionPickerRenderer s_PickerRenderer; //Field offset: 0x28
	private static RenderTextureFormat s_RenderTextureFormat; //Field offset: 0x30
	private static RenderTextureFormat[] s_PreferredFormats; //Field offset: 0x38

	private static ISelectionPickerRenderer pickerRenderer
	{
		private get { } //Length: 208
	}

	private static RenderTextureFormat renderTextureFormat
	{
		private get { } //Length: 348
	}

	private static TextureFormat textureFormat
	{
		private get { } //Length: 8
	}

	private static SelectionPickerRenderer() { }

	private static Mesh BuildEdgeMesh(ProBuilderMesh pb, Dictionary<UInt32, SimpleTuple`2<ProBuilderMesh, Edge>> map, ref uint index) { }

	private static Mesh BuildVertexMesh(ProBuilderMesh pb, Dictionary<UInt32, SimpleTuple`2<ProBuilderMesh, Int32>> map, ref uint index) { }

	public static uint DecodeRGBA(Color32 color) { }

	public static Color32 EncodeRGBA(uint hash) { }

	private static void GenerateEdgePickingObjects(IList<ProBuilderMesh> selection, bool doDepthTest, out Dictionary<UInt32, SimpleTuple`2<ProBuilderMesh, Edge>>& map, out GameObject[] depthObjects, out GameObject[] pickerObjects) { }

	private static GameObject[] GenerateFacePickingObjects(IList<ProBuilderMesh> selection, out Dictionary<UInt32, SimpleTuple`2<ProBuilderMesh, Face>>& map) { }

	private static void GenerateVertexPickingObjects(IList<ProBuilderMesh> selection, bool doDepthTest, out Dictionary<UInt32, SimpleTuple`2<ProBuilderMesh, Int32>>& map, out GameObject[] depthObjects, out GameObject[] pickerObjects) { }

	private static ISelectionPickerRenderer get_pickerRenderer() { }

	private static RenderTextureFormat get_renderTextureFormat() { }

	private static TextureFormat get_textureFormat() { }

	public static Dictionary<ProBuilderMesh, HashSet`1<Edge>> PickEdgesInRect(Camera camera, Rect pickerRect, IList<ProBuilderMesh> selection, bool doDepthTest, int renderTextureWidth = -1, int renderTextureHeight = -1) { }

	public static Dictionary<ProBuilderMesh, HashSet`1<Face>> PickFacesInRect(Camera camera, Rect pickerRect, IList<ProBuilderMesh> selection, int renderTextureWidth = -1, int renderTextureHeight = -1) { }

	public static Dictionary<ProBuilderMesh, HashSet`1<Int32>> PickVerticesInRect(Camera camera, Rect pickerRect, IList<ProBuilderMesh> selection, bool doDepthTest, int renderTextureWidth = -1, int renderTextureHeight = -1) { }

	internal static Texture2D RenderSelectionPickerTexture(Camera camera, IList<ProBuilderMesh> selection, bool doDepthTest, out Dictionary<UInt32, SimpleTuple`2<ProBuilderMesh, Int32>>& map, int width = -1, int height = -1) { }

	internal static Texture2D RenderSelectionPickerTexture(Camera camera, IList<ProBuilderMesh> selection, out Dictionary<UInt32, SimpleTuple`2<ProBuilderMesh, Face>>& map, int width = -1, int height = -1) { }

	internal static Texture2D RenderSelectionPickerTexture(Camera camera, IList<ProBuilderMesh> selection, bool doDepthTest, out Dictionary<UInt32, SimpleTuple`2<ProBuilderMesh, Edge>>& map, int width = -1, int height = -1) { }

	private static bool ShouldUseHDRP() { }

}

