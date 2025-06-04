namespace UnityEngine.Rendering;

public static class Blitter
{
	private static class BlitShaderIDs
	{
		public static readonly int _BlitTexture; //Field offset: 0x0
		public static readonly int _BlitCubeTexture; //Field offset: 0x4
		public static readonly int _BlitScaleBias; //Field offset: 0x8
		public static readonly int _BlitScaleBiasRt; //Field offset: 0xC
		public static readonly int _BlitMipLevel; //Field offset: 0x10
		public static readonly int _BlitTextureSize; //Field offset: 0x14
		public static readonly int _BlitPaddingSize; //Field offset: 0x18
		public static readonly int _BlitDecodeInstructions; //Field offset: 0x1C
		public static readonly int _InputDepth; //Field offset: 0x20

		private static BlitShaderIDs() { }

	}

	private static Material s_Blit; //Field offset: 0x0
	private static Material s_BlitTexArray; //Field offset: 0x8
	private static Material s_BlitTexArraySingleSlice; //Field offset: 0x10
	private static Material s_BlitColorAndDepth; //Field offset: 0x18
	private static MaterialPropertyBlock s_PropertyBlock; //Field offset: 0x20
	private static Mesh s_TriangleMesh; //Field offset: 0x28
	private static Mesh s_QuadMesh; //Field offset: 0x30
	private static LocalKeyword s_DecodeHdrKeyword; //Field offset: 0x38

	private static Blitter() { }

	[CompilerGenerated]
	internal static Vector2[] <Initialize>g__GetFullScreenTriangleTexCoord|9_1() { }

	[CompilerGenerated]
	internal static Vector3[] <Initialize>g__GetFullScreenTriangleVertexPosition|9_0(float z) { }

	[CompilerGenerated]
	internal static Vector2[] <Initialize>g__GetQuadTexCoord|9_3() { }

	[CompilerGenerated]
	internal static Vector3[] <Initialize>g__GetQuadVertexPosition|9_2(float z) { }

	public static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, Rect destViewport, float mipLevel = 0, bool bilinear = false) { }

	public static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, Vector4 scaleBias, float mipLevel = 0, bool bilinear = false) { }

	public static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, Material material, int pass) { }

	public static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, float mipLevel = 0, bool bilinear = false) { }

	public static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, Material material, int pass) { }

	public static void BlitCameraTexture2D(CommandBuffer cmd, RTHandle source, RTHandle destination, float mipLevel = 0, bool bilinear = false) { }

	public static void BlitColorAndDepth(CommandBuffer cmd, Texture sourceColor, RenderTexture sourceDepth, Vector4 scaleBias, float mipLevel, bool blitDepth) { }

	public static void BlitCubeToOctahedral2DQuad(CommandBuffer cmd, Texture source, Vector4 scaleBiasRT, int mipLevelTex) { }

	public static void BlitCubeToOctahedral2DQuadSingleChannel(CommandBuffer cmd, Texture source, Vector4 scaleBiasRT, int mipLevelTex) { }

	public static void BlitCubeToOctahedral2DQuadWithPadding(CommandBuffer cmd, Texture source, Vector2 textureSize, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels, Nullable<Vector4> decodeInstructions = null) { }

	public static void BlitOctahedralWithPadding(CommandBuffer cmd, Texture source, Vector2 textureSize, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels) { }

	public static void BlitOctahedralWithPaddingMultiply(CommandBuffer cmd, Texture source, Vector2 textureSize, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels) { }

	public static void BlitQuad(CommandBuffer cmd, Texture source, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear) { }

	public static void BlitQuadSingleChannel(CommandBuffer cmd, Texture source, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex) { }

	public static void BlitQuadWithPadding(CommandBuffer cmd, Texture source, Vector2 textureSize, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels) { }

	public static void BlitQuadWithPaddingMultiply(CommandBuffer cmd, Texture source, Vector2 textureSize, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels) { }

	public static void BlitTexture(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material, int pass) { }

	public static void BlitTexture(CommandBuffer cmd, RTHandle source, Vector4 scaleBias, float mipLevel, bool bilinear) { }

	public static void BlitTexture(CommandBuffer cmd, RTHandle source, Vector4 scaleBias, Material material, int pass) { }

	public static void BlitTexture(CommandBuffer cmd, Vector4 scaleBias, Material material, int pass) { }

	public static void BlitTexture(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, Material material, int pass) { }

	public static void BlitTexture(CommandBuffer cmd, RenderTargetIdentifier source, Vector4 scaleBias, Material material, int pass) { }

	public static void BlitTexture2D(CommandBuffer cmd, RTHandle source, Vector4 scaleBias, float mipLevel, bool bilinear) { }

	public static void Cleanup() { }

	internal static void DrawQuad(CommandBuffer cmd, Material material, int shaderPass) { }

	private static void DrawTriangle(CommandBuffer cmd, Material material, int shaderPass) { }

	public static Material GetBlitMaterial(TextureDimension dimension, bool singleSlice = false) { }

	public static void Initialize(Shader blitPS, Shader blitColorAndDepthPS) { }

}

