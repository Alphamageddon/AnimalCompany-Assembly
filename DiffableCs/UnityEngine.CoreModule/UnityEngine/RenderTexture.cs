namespace UnityEngine;

[NativeHeader("Runtime/Graphics/RenderBufferManager.h")]
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[NativeHeader("Runtime/Camera/Camera.h")]
[NativeHeader("Runtime/Graphics/RenderTexture.h")]
[UsedByNativeCode]
public class RenderTexture : Texture
{

	public static RenderTexture active
	{
		 get { } //Length: 40
		 set { } //Length: 60
	}

	public int antiAliasing
	{
		 get { } //Length: 60
		 set { } //Length: 68
	}

	public bool autoGenerateMips
	{
		 set { } //Length: 68
	}

	public bool bindTextureMS
	{
		 set { } //Length: 68
	}

	public RenderBuffer colorBuffer
	{
		 get { } //Length: 4
	}

	public RenderBuffer depthBuffer
	{
		 get { } //Length: 4
	}

	public GraphicsFormat depthStencilFormat
	{
		 set { } //Length: 68
	}

	public RenderTextureDescriptor descriptor
	{
		 get { } //Length: 132
	}

	public virtual TextureDimension dimension
	{
		 get { } //Length: 60
		 set { } //Length: 68
	}

	public bool enableRandomWrite
	{
		 set { } //Length: 68
	}

	public RenderTextureFormat format
	{
		 get { } //Length: 284
	}

	public GraphicsFormat graphicsFormat
	{
		 get { } //Length: 64
		 set { } //Length: 68
	}

	public virtual int height
	{
		 get { } //Length: 60
		 set { } //Length: 68
	}

	[NativeProperty("Memoryless")]
	public RenderTextureMemoryless memorylessMode
	{
		 set { } //Length: 68
	}

	[NativeProperty("SRGBReadWrite")]
	public bool sRGB
	{
		 get { } //Length: 60
	}

	public GraphicsFormat stencilFormat
	{
		 set { } //Length: 68
	}

	public bool useDynamicScale
	{
		 get { } //Length: 60
		 set { } //Length: 68
	}

	[NativeProperty("MipMap")]
	public bool useMipMap
	{
		 get { } //Length: 60
		 set { } //Length: 68
	}

	public int volumeDepth
	{
		 get { } //Length: 60
		 set { } //Length: 68
	}

	[NativeProperty("VRUsage")]
	public VRTextureUsage vrUsage
	{
		 set { } //Length: 68
	}

	public virtual int width
	{
		 get { } //Length: 60
		 set { } //Length: 68
	}

	[ExcludeFromDocs]
	public RenderTexture(int width, int height, int depth, GraphicsFormat format, int mipCount) { }

	[ExcludeFromDocs]
	public RenderTexture(int width, int height, int depth, DefaultFormat format) { }

	[ExcludeFromDocs]
	public RenderTexture(int width, int height, int depth) { }

	public RenderTexture(RenderTexture textureToCopy) { }

	public RenderTexture(RenderTextureDescriptor desc) { }

	[RequiredByNativeCode]
	protected private RenderTexture() { }

	[ExcludeFromDocs]
	public RenderTexture(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat, int mipCount) { }

	[ExcludeFromDocs]
	public RenderTexture(int width, int height, int depth, RenderTextureFormat format) { }

	[ExcludeFromDocs]
	public RenderTexture(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat) { }

	[ExcludeFromDocs]
	public RenderTexture(int width, int height, int depth, RenderTextureFormat format, int mipCount) { }

	public RenderTexture(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[ExcludeFromDocs]
	public RenderTexture(int width, int height, int depth, GraphicsFormat format) { }

	public bool Create() { }

	public static RenderTexture get_active() { }

	public int get_antiAliasing() { }

	public RenderBuffer get_colorBuffer() { }

	public RenderBuffer get_depthBuffer() { }

	public RenderTextureDescriptor get_descriptor() { }

	public virtual TextureDimension get_dimension() { }

	public RenderTextureFormat get_format() { }

	public GraphicsFormat get_graphicsFormat() { }

	public virtual int get_height() { }

	public bool get_sRGB() { }

	public bool get_useDynamicScale() { }

	public bool get_useMipMap() { }

	public int get_volumeDepth() { }

	public virtual int get_width() { }

	[FreeFunction("RenderTexture::GetActive")]
	private static RenderTexture GetActive() { }

	[FreeFunction(Name = "RenderTextureScripting::GetColorBuffer", HasExplicitThis = True)]
	private RenderBuffer GetColorBuffer() { }

	private void GetColorBuffer_Injected(out RenderBuffer ret) { }

	[NativeName("GetColorFormat")]
	private GraphicsFormat GetColorFormat(bool suppressWarnings) { }

	internal static GraphicsFormat GetCompatibleFormat(RenderTextureFormat renderTextureFormat, RenderTextureReadWrite readWrite) { }

	internal static GraphicsFormat GetDefaultColorFormat(DefaultFormat format) { }

	internal static GraphicsFormat GetDefaultDepthStencilFormat(DefaultFormat format, int depth) { }

	[FreeFunction(Name = "RenderTextureScripting::GetDepthBuffer", HasExplicitThis = True)]
	private RenderBuffer GetDepthBuffer() { }

	private void GetDepthBuffer_Injected(out RenderBuffer ret) { }

	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, RenderTextureFormat format) { }

	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, DefaultFormat format) { }

	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, bool requestedShadowMap) { }

	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, GraphicsFormat colorFormat) { }

	[NativeName("GetRenderTextureDesc")]
	private RenderTextureDescriptor GetDescriptor() { }

	private void GetDescriptor_Injected(out RenderTextureDescriptor ret) { }

	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage, bool useDynamicScale) { }

	[ExcludeFromDocs]
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing) { }

	[ExcludeFromDocs]
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	public static RenderTexture GetTemporary(RenderTextureDescriptor desc) { }

	[ExcludeFromDocs]
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format) { }

	[ExcludeFromDocs]
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage) { }

	[ExcludeFromDocs]
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode) { }

	[FreeFunction("GetRenderBufferManager().GetTextures().GetTempBuffer")]
	private static RenderTexture GetTemporary_Internal(RenderTextureDescriptor desc) { }

	private static RenderTexture GetTemporary_Internal_Injected(ref RenderTextureDescriptor desc) { }

	private static RenderTexture GetTemporaryImpl(int width, int height, GraphicsFormat depthStencilFormat, GraphicsFormat colorFormat, int antiAliasing = 1, RenderTextureMemoryless memorylessMode = 0, VRTextureUsage vrUsage = 0, bool useDynamicScale = false) { }

	private void Initialize(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite, int mipCount) { }

	[FreeFunction("RenderTextureScripting::Create")]
	private static void Internal_Create(RenderTexture rt) { }

	public void Release() { }

	[FreeFunction("GetRenderBufferManager().GetTextures().ReleaseTempBuffer")]
	public static void ReleaseTemporary(RenderTexture temp) { }

	public static void set_active(RenderTexture value) { }

	public void set_antiAliasing(int value) { }

	public void set_autoGenerateMips(bool value) { }

	public void set_bindTextureMS(bool value) { }

	public void set_depthStencilFormat(GraphicsFormat value) { }

	public virtual void set_dimension(TextureDimension value) { }

	public void set_enableRandomWrite(bool value) { }

	public void set_graphicsFormat(GraphicsFormat value) { }

	public virtual void set_height(int value) { }

	public void set_memorylessMode(RenderTextureMemoryless value) { }

	public void set_stencilFormat(GraphicsFormat value) { }

	public void set_useDynamicScale(bool value) { }

	public void set_useMipMap(bool value) { }

	public void set_volumeDepth(int value) { }

	public void set_vrUsage(VRTextureUsage value) { }

	public virtual void set_width(int value) { }

	[FreeFunction("RenderTextureScripting::SetActive")]
	private static void SetActive(RenderTexture rt) { }

	[NativeName("SetColorFormat")]
	private void SetColorFormat(GraphicsFormat format) { }

	private void SetMipMapCount(int count) { }

	[NativeName("SetRenderTextureDescFromScript")]
	private void SetRenderTextureDescriptor(RenderTextureDescriptor desc) { }

	private void SetRenderTextureDescriptor_Injected(ref RenderTextureDescriptor desc) { }

	internal void SetSRGBReadWrite(bool srgb) { }

	private static void ValidateRenderTextureDesc(RenderTextureDescriptor desc) { }

}

