namespace UnityEngine.Rendering.Universal;

internal class LightCookieManager : IDisposable
{
	private struct LightCookieMapping
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0

			private static <>c() { }

			public <>c() { }

			internal int <.cctor>b__6_0(LightCookieMapping a, LightCookieMapping b) { }

			internal int <.cctor>b__6_1(LightCookieMapping a, LightCookieMapping b) { }

		}

		public static Func<LightCookieMapping, LightCookieMapping, Int32> s_CompareByCookieSize; //Field offset: 0x0
		public static Func<LightCookieMapping, LightCookieMapping, Int32> s_CompareByBufferIndex; //Field offset: 0x8
		public ushort visibleLightIndex; //Field offset: 0x0
		public ushort lightBufferIndex; //Field offset: 0x2
		public Light light; //Field offset: 0x8

		private static LightCookieMapping() { }

	}

	private class LightCookieShaderData : IDisposable
	{
		private int m_Size; //Field offset: 0x10
		private bool m_UseStructuredBuffer; //Field offset: 0x14
		private Matrix4x4[] m_WorldToLightCpuData; //Field offset: 0x18
		private Vector4[] m_AtlasUVRectCpuData; //Field offset: 0x20
		private Single[] m_LightTypeCpuData; //Field offset: 0x28
		private ShaderBitArray m_CookieEnableBitsCpuData; //Field offset: 0x30
		private ComputeBuffer m_WorldToLightBuffer; //Field offset: 0x38
		private ComputeBuffer m_AtlasUVRectBuffer; //Field offset: 0x40
		private ComputeBuffer m_LightTypeBuffer; //Field offset: 0x48
		[CompilerGenerated]
		private bool <isUploaded>k__BackingField; //Field offset: 0x50

		public Vector4[] atlasUVRects
		{
			 get { } //Length: 8
		}

		public ShaderBitArray cookieEnableBits
		{
			 get { } //Length: 8
		}

		public bool isUploaded
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 12
		}

		public Single[] lightTypes
		{
			 get { } //Length: 8
		}

		public Matrix4x4[] worldToLights
		{
			 get { } //Length: 8
		}

		public LightCookieShaderData(int size, bool useStructuredBuffer) { }

		public void Clear(CommandBuffer cmd) { }

		public override void Dispose() { }

		public Vector4[] get_atlasUVRects() { }

		public ShaderBitArray get_cookieEnableBits() { }

		[CompilerGenerated]
		public bool get_isUploaded() { }

		public Single[] get_lightTypes() { }

		public Matrix4x4[] get_worldToLights() { }

		public void Resize(int size) { }

		[CompilerGenerated]
		public void set_isUploaded(bool value) { }

		public void Upload(CommandBuffer cmd) { }

	}

	private enum LightCookieShaderFormat
	{
		None = -1,
		RGB = 0,
		Alpha = 1,
		Red = 2,
	}

	internal struct Settings
	{
		internal struct AtlasSettings
		{
			public Vector2Int resolution; //Field offset: 0x0
			public GraphicsFormat format; //Field offset: 0x8
			public bool useMips; //Field offset: 0xC

			public bool isPow2
			{
				 get { } //Length: 52
			}

			public bool isSquare
			{
				 get { } //Length: 16
			}

			public bool get_isPow2() { }

			public bool get_isSquare() { }

		}

		public AtlasSettings atlas; //Field offset: 0x0
		public int maxAdditionalLights; //Field offset: 0x10
		public float cubeOctahedralSizeScale; //Field offset: 0x14
		public bool useStructuredBuffer; //Field offset: 0x18

		public static Settings Create() { }

	}

	[DefaultMember("Item")]
	private struct ShaderBitArray
	{
		private const int k_BitsPerElement = 32; //Field offset: 0x0
		private const int k_ElementShift = 5; //Field offset: 0x0
		private const int k_ElementMask = 31; //Field offset: 0x0
		private Single[] m_Data; //Field offset: 0x0

		public int bitCapacity
		{
			 get { } //Length: 28
		}

		public Single[] data
		{
			 get { } //Length: 8
		}

		public int elemLength
		{
			 get { } //Length: 24
		}

		public bool Item
		{
			 get { } //Length: 48
			 set { } //Length: 68
		}

		public void Clear() { }

		public int get_bitCapacity() { }

		public Single[] get_data() { }

		public int get_elemLength() { }

		public bool get_Item(int index) { }

		private void GetElementIndexAndBitOffset(int index, out int elemIndex, out int bitOffset) { }

		public void Resize(int bitCount) { }

		public void set_Item(int index, bool value) { }

		public virtual string ToString() { }

	}

	private static class ShaderProperty
	{
		public static readonly int mainLightTexture; //Field offset: 0x0
		public static readonly int mainLightWorldToLight; //Field offset: 0x4
		public static readonly int mainLightCookieTextureFormat; //Field offset: 0x8
		public static readonly int additionalLightsCookieAtlasTexture; //Field offset: 0xC
		public static readonly int additionalLightsCookieAtlasTextureFormat; //Field offset: 0x10
		public static readonly int additionalLightsCookieEnableBits; //Field offset: 0x14
		public static readonly int additionalLightsCookieAtlasUVRectBuffer; //Field offset: 0x18
		public static readonly int additionalLightsCookieAtlasUVRects; //Field offset: 0x1C
		public static readonly int additionalLightsWorldToLightBuffer; //Field offset: 0x20
		public static readonly int additionalLightsLightTypeBuffer; //Field offset: 0x24
		public static readonly int additionalLightsWorldToLights; //Field offset: 0x28
		public static readonly int additionalLightsLightTypes; //Field offset: 0x2C

		private static ShaderProperty() { }

	}

	private struct Sorting
	{
		[CompilerGenerated]
		private struct <>c__DisplayClass2_0
		{
			public T[] data; //Field offset: 0x0

		}


		[CompilerGenerated]
		internal static void <Median3Pivot>g__Swap|2_0(int a, int b, ref <>c__DisplayClass2_0<T>& unnamed_param_2) { }

		public static void InsertionSort(T[] data, int start, int end, Func<T, T, Int32> compare) { }

		private static T Median3Pivot(T[] data, int start, int pivot, int end, Func<T, T, Int32> compare) { }

		private static int Partition(T[] data, int start, int end, Func<T, T, Int32> compare) { }

		public static void QuickSort(T[] data, Func<T, T, Int32> compare) { }

		public static void QuickSort(T[] data, int start, int end, Func<T, T, Int32> compare) { }

	}

	private class WorkMemory
	{
		public LightCookieMapping[] lightMappings; //Field offset: 0x10
		public Vector4[] uvRects; //Field offset: 0x18

		public WorkMemory() { }

		public void Resize(int size) { }

	}

	[DefaultMember("Item")]
	[IsReadOnly]
	private struct WorkSlice
	{
		private readonly T[] m_Data; //Field offset: 0x0
		private readonly int m_Start; //Field offset: 0x0
		private readonly int m_Length; //Field offset: 0x0

		public int capacity
		{
			 get { } //Length: 28
		}

		public T Item
		{
			 get { } //Length: 64
			 set { } //Length: 64
		}

		public int length
		{
			 get { } //Length: 8
		}

		public WorkSlice`1(T[] src, int srcLen = -1) { }

		public WorkSlice`1(T[] src, int srcStart, int srcLen = -1) { }

		public int get_capacity() { }

		public T get_Item(int index) { }

		public int get_length() { }

		public void set_Item(int index, T value) { }

		public void Sort(Func<T, T, Int32> compare) { }

	}

	private static readonly Matrix4x4 s_DirLightProj; //Field offset: 0x0
	private const int k_MaxCookieSizeDivisor = 16; //Field offset: 0x0
	private Texture2DAtlas m_AdditionalLightsCookieAtlas; //Field offset: 0x10
	private LightCookieShaderData m_AdditionalLightsCookieShaderData; //Field offset: 0x18
	private readonly Settings m_Settings; //Field offset: 0x20
	private WorkMemory m_WorkMem; //Field offset: 0x40
	private Int32[] m_VisibleLightIndexToShaderDataIndex; //Field offset: 0x48
	private int m_CookieSizeDivisor; //Field offset: 0x50
	private uint m_PrevCookieRequestPixelCount; //Field offset: 0x54
	private int m_PrevWarnFrame; //Field offset: 0x58
	[CompilerGenerated]
	private bool <IsKeywordLightCookieEnabled>k__BackingField; //Field offset: 0x5C

	internal bool IsKeywordLightCookieEnabled
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 12
	}

	private static LightCookieManager() { }

	public LightCookieManager(ref Settings settings) { }

	private void AdjustUVRect(ref Vector4 uvScaleOffset, Texture cookie, ref Vector2 cookieSize) { }

	private int ApproximateCookieSizeDivisor(float requestAtlasRatio) { }

	private uint ComputeCookieRequestPixelCount(ref WorkSlice<LightCookieMapping>& validLightMappings) { }

	private int ComputeOctahedralCookieSize(Texture cookie) { }

	public override void Dispose() { }

	private Vector4 Fetch2D(CommandBuffer cmd, Texture cookie, int cookieSizeDivisor = 1) { }

	private Vector4 FetchCube(CommandBuffer cmd, Texture cookie, int cookieSizeDivisor = 1) { }

	private int FetchUVRects(CommandBuffer cmd, ref WorkSlice<LightCookieMapping>& validLightMappings, Vector4[] textureAtlasUVRects, int cookieSizeDivisor) { }

	private int FilterAndValidateAdditionalLights(ref LightData lightData, LightCookieMapping[] validLightMappings) { }

	[CompilerGenerated]
	internal bool get_IsKeywordLightCookieEnabled() { }

	public int GetLightCookieShaderDataIndex(int visibleLightIndex) { }

	private LightCookieShaderFormat GetLightCookieShaderFormat(GraphicsFormat cookieFormat) { }

	private void GetLightUVScaleOffset(ref UniversalAdditionalLightData additionalLightData, ref Matrix4x4 uvTransform) { }

	private void InitAdditionalLights(int size) { }

	public bool isInitialized() { }

	[CompilerGenerated]
	private void set_IsKeywordLightCookieEnabled(bool value) { }

	public void Setup(ScriptableRenderContext ctx, CommandBuffer cmd, ref LightData lightData) { }

	private bool SetupAdditionalLights(CommandBuffer cmd, ref LightData lightData) { }

	private bool SetupMainLight(CommandBuffer cmd, ref VisibleLight visibleMainLight) { }

	private void ShrinkUVRect(ref Vector4 uvScaleOffset, float amountPixels, ref Vector2 cookieSize) { }

	private int UpdateAdditionalLightsAtlas(CommandBuffer cmd, ref WorkSlice<LightCookieMapping>& validLightMappings, Vector4[] textureAtlasUVRects) { }

	private void UploadAdditionalLights(CommandBuffer cmd, ref LightData lightData, ref WorkSlice<LightCookieMapping>& validLightMappings, ref WorkSlice<Vector4>& validUvRects) { }

}

