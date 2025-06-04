namespace UnityEngine.Rendering.Universal;

public static class RenderingUtils
{
	private static List<ShaderTagId> m_LegacyShaderPassNames; //Field offset: 0x0
	private static AttachmentDescriptor s_EmptyAttachment; //Field offset: 0x8
	private static Mesh s_FullscreenMesh; //Field offset: 0x80
	private static Material s_ErrorMaterial; //Field offset: 0x88
	private static Dictionary<RenderTextureFormat, Boolean> m_RenderTextureFormatSupport; //Field offset: 0x90
	private static Dictionary<GraphicsFormat, Dictionary`2<FormatUsage, Boolean>> m_GraphicsFormatSupport; //Field offset: 0x98

	internal static AttachmentDescriptor emptyAttachment
	{
		internal get { } //Length: 100
	}

	private static Material errorMaterial
	{
		private get { } //Length: 400
	}

	[Obsolete("Use Blitter.BlitCameraTexture instead of CommandBuffer.DrawMesh(fullscreenMesh, ...)")]
	public static Mesh fullscreenMesh
	{
		 get { } //Length: 1456
	}

	internal static bool useStructuredBuffer
	{
		internal get { } //Length: 8
	}

	private static RenderingUtils() { }

	internal static void AddStaleResourceToPoolOrRelease(TextureDesc desc, RTHandle handle) { }

	internal static void Blit(CommandBuffer cmd, RTHandle source, Rect viewport, RTHandle destination, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, ClearFlag clearFlag, Color clearColor, Material material, int passIndex = 0) { }

	internal static void Blit(CommandBuffer cmd, RTHandle source, Rect viewport, RTHandle destinationColor, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RTHandle destinationDepthStencil, RenderBufferLoadAction depthStencilLoadAction, RenderBufferStoreAction depthStencilStoreAction, ClearFlag clearFlag, Color clearColor, Material material, int passIndex = 0) { }

	internal static void ClearSystemInfoCache() { }

	internal static bool Contains(ClearFlag a, ClearFlag b) { }

	internal static bool Contains(RenderTargetIdentifier[] source, RenderTargetIdentifier value) { }

	internal static uint CountDistinct(RenderTargetIdentifier[] source, RenderTargetIdentifier value) { }

	public static DrawingSettings CreateDrawingSettings(ShaderTagId shaderTagId, ref RenderingData renderingData, SortingCriteria sortingCriteria) { }

	public static DrawingSettings CreateDrawingSettings(List<ShaderTagId> shaderTagIdList, ref RenderingData renderingData, SortingCriteria sortingCriteria) { }

	internal static void FinalBlit(CommandBuffer cmd, ref CameraData cameraData, RTHandle source, RTHandle destination, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, Material material, int passIndex) { }

	internal static AttachmentDescriptor get_emptyAttachment() { }

	private static Material get_errorMaterial() { }

	public static Mesh get_fullscreenMesh() { }

	internal static bool get_useStructuredBuffer() { }

	internal static RenderTargetIdentifier GetCameraTargetIdentifier(ref RenderingData renderingData) { }

	internal static int GetLastValidColorBufferIndex(RenderTargetIdentifier[] colorBuffers) { }

	[Obsolete("Use RTHandles for colorBuffers")]
	internal static uint GetValidColorBufferCount(RenderTargetIdentifier[] colorBuffers) { }

	internal static uint GetValidColorBufferCount(RTHandle[] colorBuffers) { }

	internal static int IndexOf(RenderTargetIdentifier[] source, RenderTargetIdentifier value) { }

	[Obsolete("Use RTHandles for colorBuffers")]
	internal static bool IsMRT(RenderTargetIdentifier[] colorBuffers) { }

	internal static bool IsMRT(RTHandle[] colorBuffers) { }

	internal static int LastValid(RenderTargetIdentifier[] source) { }

	internal static bool MultisampleDepthResolveSupported() { }

	public static bool ReAllocateIfNeeded(ref RTHandle handle, in RenderTextureDescriptor descriptor, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0, string name = "") { }

	public static bool ReAllocateIfNeeded(ref RTHandle handle, Vector2 scaleFactor, in RenderTextureDescriptor descriptor, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0, string name = "") { }

	public static bool ReAllocateIfNeeded(ref RTHandle handle, ScaleFunc scaleFunc, in RenderTextureDescriptor descriptor, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0, string name = "") { }

	[Conditional("UNITY_EDITOR")]
	[Conditional("DEVELOPMENT_BUILD")]
	internal static void RenderObjectsWithError(ScriptableRenderContext context, ref CullingResults cullResults, Camera camera, FilteringSettings filterSettings, SortingCriteria sortFlags) { }

	internal static bool RTHandleNeedsReAlloc(RTHandle handle, in TextureDesc descriptor, bool scaled) { }

	internal static bool SequenceEqual(RenderTargetIdentifier[] left, RenderTargetIdentifier[] right) { }

	public static bool SetMaxRTHandlePoolCapacity(int capacity) { }

	internal static void SetScaleBiasRt(CommandBuffer cmd, in RenderingData renderingData) { }

	public static void SetViewAndProjectionMatrices(CommandBuffer cmd, Matrix4x4 viewMatrix, Matrix4x4 projectionMatrix, bool setInverseMatrices) { }

	public static bool SupportsGraphicsFormat(GraphicsFormat format, FormatUsage usage) { }

	internal static bool SupportsLightLayers(GraphicsDeviceType type) { }

	public static bool SupportsRenderTextureFormat(RenderTextureFormat format) { }

}

