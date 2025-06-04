namespace UnityEngine.Rendering;

public sealed class LensFlareCommonSRP
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		public LensFlareComponentSRP newData; //Field offset: 0x10

		public <>c__DisplayClass21_0() { }

		internal bool <AddData>b__0(LensFlareCompInfo x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_0
	{
		public LensFlareComponentSRP data; //Field offset: 0x10

		public <>c__DisplayClass22_0() { }

		internal bool <RemoveData>b__0(LensFlareCompInfo x) { }

	}

	[CompilerGenerated]
	private struct <>c__DisplayClass40_0
	{
		public Vector2 screenPos; //Field offset: 0x0

	}

	[CompilerGenerated]
	private struct <>c__DisplayClass40_1
	{
		public LensFlareDataElementSRP element; //Field offset: 0x0

	}

	[CompilerGenerated]
	private struct <>c__DisplayClass40_2
	{
		public float position; //Field offset: 0x0
		public float globalCos0; //Field offset: 0x4
		public float globalSin0; //Field offset: 0x8
		public float combinedScale; //Field offset: 0xC
		public float usedAspectRatio; //Field offset: 0x10

	}

	public class LensFlareCompInfo
	{
		internal int index; //Field offset: 0x10
		internal LensFlareComponentSRP comp; //Field offset: 0x18

		internal LensFlareCompInfo(int idx, LensFlareComponentSRP cmp) { }

	}

	private static LensFlareCommonSRP m_Instance; //Field offset: 0x0
	private static readonly object m_Padlock; //Field offset: 0x8
	private static List<LensFlareCompInfo> m_Data; //Field offset: 0x10
	private static List<Int32> m_AvailableIndicies; //Field offset: 0x18
	public static int maxLensFlareWithOcclusion; //Field offset: 0x20
	public static int maxLensFlareWithOcclusionTemporalSample; //Field offset: 0x24
	public static int mergeNeeded; //Field offset: 0x28
	public static RTHandle occlusionRT; //Field offset: 0x30
	private static int frameIdx; //Field offset: 0x38
	private static readonly bool s_SupportsLensFlareTexFormat; //Field offset: 0x3C

	private List<LensFlareCompInfo> Data
	{
		private get { } //Length: 88
	}

	public static LensFlareCommonSRP Instance
	{
		 get { } //Length: 388
	}

	private static LensFlareCommonSRP() { }

	private LensFlareCommonSRP() { }

	[CompilerGenerated]
	internal static Vector2 <DoLensFlareDataDrivenCommon>g__ComputeLocalSize|40_0(Vector2 rayOff, Vector2 rayOff0, Vector2 curSize, AnimationCurve distortionCurve, ref <>c__DisplayClass40_0 unnamed_param_4, ref <>c__DisplayClass40_1 unnamed_param_5, ref <>c__DisplayClass40_2 unnamed_param_6) { }

	[CompilerGenerated]
	internal static float <DoLensFlareDataDrivenCommon>g__RandomRange|40_1(float min, float max) { }

	[CompilerGenerated]
	internal static float <ShapeAttenuationAreaTubeLight>g__DiffLineIntegral|28_2(Vector3 p1, Vector3 p2) { }

	[CompilerGenerated]
	internal static float <ShapeAttenuationAreaTubeLight>g__Fpo|28_0(float d, float l) { }

	[CompilerGenerated]
	internal static float <ShapeAttenuationAreaTubeLight>g__Fwt|28_1(float d, float l) { }

	public void AddData(LensFlareComponentSRP newData) { }

	private static Vector2 CalcCropExtents(float actualWidth, float actualHeight, float fieldOfView, float d) { }

	private static Vector2 CalcViewExtents(float actualWidth, float actualHeight, float fieldOfView) { }

	public static void ComputeOcclusion(Material lensFlareShader, Camera cam, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, Vector3 cameraPositionWS, Matrix4x4 viewProjMatrix, CommandBuffer cmd, bool taaEnabled, bool hasCloudLayer, Texture cloudOpacityTexture, Texture sunOcclusionTexture, int _FlareOcclusionTex, int _FlareCloudOpacity, int _FlareOcclusionIndex, int _FlareTex, int _FlareColorValue, int _FlareSunOcclusionTex, int _FlareData0, int _FlareData1, int _FlareData2, int _FlareData3, int _FlareData4) { }

	public static void Dispose() { }

	public static void DoLensFlareDataDrivenCommon(Material lensFlareShader, Camera cam, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, Vector3 cameraPositionWS, Matrix4x4 viewProjMatrix, CommandBuffer cmd, bool taaEnabled, bool hasCloudLayer, Texture cloudOpacityTexture, Texture sunOcclusionTexture, RenderTargetIdentifier colorBuffer, Func<Light, Camera, Vector3, Single> GetLensFlareLightAttenuation, int _FlareOcclusionRemapTex, int _FlareOcclusionTex, int _FlareOcclusionIndex, int _FlareCloudOpacity, int _FlareSunOcclusionTex, int _FlareTex, int _FlareColorValue, int _FlareData0, int _FlareData1, int _FlareData2, int _FlareData3, int _FlareData4, bool debugView) { }

	private static Vector2 DoPaniniProjection(Vector2 screenPos, float actualWidth, float actualHeight, float fieldOfView, float paniniProjectionCropToFit, float paniniProjectionDistance) { }

	private List<LensFlareCompInfo> get_Data() { }

	public static LensFlareCommonSRP get_Instance() { }

	public static Vector4 GetFlareData0(Vector2 screenPos, Vector2 translationScale, Vector2 rayOff0, Vector2 vLocalScreenRatio, float angleDeg, float position, float angularOffset, Vector2 positionOffset, bool autoRotate) { }

	private static Vector2 GetLensFlareRayOffset(Vector2 screenPos, float position, float globalCos0, float globalSin0) { }

	private int GetNextAvailableIndex() { }

	public static void Initialize() { }

	public static bool IsCloudLayerOpacityNeeded(Camera cam) { }

	public bool IsEmpty() { }

	private static bool IsLensFlareSRPHidden(Camera cam, LensFlareComponentSRP comp, LensFlareDataSRP data) { }

	public static bool IsOcclusionRTCompatible() { }

	private static Vector2 Panini_Generic_Inv(Vector2 projPos, float d) { }

	public void RemoveData(LensFlareComponentSRP data) { }

	private static void SetOcclusionPermutation(CommandBuffer cmd, bool useBackgroundCloudOcclusion, bool volumetricCloudOcclusion, bool hasCloudLayer, int _FlareCloudOpacity, int _FlareSunOcclusionTex, Texture cloudOpacityTexture, Texture sunOcclusionTexture) { }

	public static float ShapeAttenuationAreaDiscLight(Vector3 forward, Vector3 wo) { }

	public static float ShapeAttenuationAreaRectangleLight(Vector3 forward, Vector3 wo) { }

	public static float ShapeAttenuationAreaTubeLight(Vector3 lightPositionWS, Vector3 lightSide, float lightWidth, Camera cam) { }

	public static float ShapeAttenuationDirLight(Vector3 forward, Vector3 wo) { }

	public static float ShapeAttenuationPointLight() { }

	public static float ShapeAttenuationSpotBoxLight(Vector3 forward, Vector3 wo) { }

	public static float ShapeAttenuationSpotConeLight(Vector3 forward, Vector3 wo, float spotAngle, float innerSpotPercent01) { }

	public static float ShapeAttenuationSpotPyramidLight(Vector3 forward, Vector3 wo) { }

	private static Vector3 WorldToViewport(Camera camera, bool isLocalLight, bool isCameraRelative, Matrix4x4 viewProjMatrix, Vector3 positionWS) { }

	private static Vector3 WorldToViewportDistance(Camera cam, Vector3 positionWS) { }

	private static Vector3 WorldToViewportLocal(bool isCameraRelative, Matrix4x4 viewProjMatrix, Vector3 cameraPosWS, Vector3 positionWS) { }

}

