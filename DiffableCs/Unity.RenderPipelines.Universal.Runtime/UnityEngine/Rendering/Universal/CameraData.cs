namespace UnityEngine.Rendering.Universal;

public struct CameraData
{
	private Matrix4x4 m_ViewMatrix; //Field offset: 0x0
	private Matrix4x4 m_ProjectionMatrix; //Field offset: 0x40
	private Matrix4x4 m_JitterMatrix; //Field offset: 0x80
	public Camera camera; //Field offset: 0xC0
	public CameraRenderType renderType; //Field offset: 0xC8
	public RenderTexture targetTexture; //Field offset: 0xD0
	public RenderTextureDescriptor cameraTargetDescriptor; //Field offset: 0xD8
	internal Rect pixelRect; //Field offset: 0x10C
	internal bool useScreenCoordOverride; //Field offset: 0x11C
	internal Vector4 screenSizeOverride; //Field offset: 0x120
	internal Vector4 screenCoordScaleBias; //Field offset: 0x130
	internal int pixelWidth; //Field offset: 0x140
	internal int pixelHeight; //Field offset: 0x144
	internal float aspectRatio; //Field offset: 0x148
	public float renderScale; //Field offset: 0x14C
	internal ImageScalingMode imageScalingMode; //Field offset: 0x150
	internal ImageUpscalingFilter upscalingFilter; //Field offset: 0x154
	internal bool fsrOverrideSharpness; //Field offset: 0x158
	internal float fsrSharpness; //Field offset: 0x15C
	internal HDRColorBufferPrecision hdrColorBufferPrecision; //Field offset: 0x160
	public bool clearDepth; //Field offset: 0x164
	public CameraType cameraType; //Field offset: 0x168
	public bool isDefaultViewport; //Field offset: 0x16C
	public bool isHdrEnabled; //Field offset: 0x16D
	public bool allowHDROutput; //Field offset: 0x16E
	public bool requiresDepthTexture; //Field offset: 0x16F
	public bool requiresOpaqueTexture; //Field offset: 0x170
	public bool postProcessingRequiresDepthTexture; //Field offset: 0x171
	public bool xrRendering; //Field offset: 0x172
	internal bool stackLastCameraOutputToHDR; //Field offset: 0x173
	public SortingCriteria defaultOpaqueSortFlags; //Field offset: 0x174
	[CompilerGenerated]
	private XRPass <xr>k__BackingField; //Field offset: 0x178
	[Obsolete("Please use xr.enabled instead.", True)]
	public bool isStereoEnabled; //Field offset: 0x180
	public float maxShadowDistance; //Field offset: 0x184
	public bool postProcessEnabled; //Field offset: 0x188
	internal bool stackAnyPostProcessingEnabled; //Field offset: 0x189
	public IEnumerator<Action`2<RenderTargetIdentifier, CommandBuffer>> captureActions; //Field offset: 0x190
	public LayerMask volumeLayerMask; //Field offset: 0x198
	public Transform volumeTrigger; //Field offset: 0x1A0
	public bool isStopNaNEnabled; //Field offset: 0x1A8
	public bool isDitheringEnabled; //Field offset: 0x1A9
	public AntialiasingMode antialiasing; //Field offset: 0x1AC
	public AntialiasingQuality antialiasingQuality; //Field offset: 0x1B0
	public ScriptableRenderer renderer; //Field offset: 0x1B8
	public bool resolveFinalTarget; //Field offset: 0x1C0
	public Vector3 worldSpaceCameraPos; //Field offset: 0x1C4
	public Color backgroundColor; //Field offset: 0x1D0
	internal TaaPersistentData taaPersistentData; //Field offset: 0x1E0
	internal Settings taaSettings; //Field offset: 0x1E8
	public Camera baseCamera; //Field offset: 0x208

	public ColorGamut hdrDisplayColorGamut
	{
		 get { } //Length: 144
	}

	public HDRDisplayInformation hdrDisplayInformation
	{
		 get { } //Length: 244
	}

	public bool isHDROutputActive
	{
		 get { } //Length: 172
	}

	public bool isPreviewCamera
	{
		 get { } //Length: 16
	}

	internal bool isRenderPassSupportedCamera
	{
		internal get { } //Length: 28
	}

	public bool isSceneViewCamera
	{
		 get { } //Length: 16
	}

	public bool rendersOverlayUI
	{
		 get { } //Length: 124
	}

	internal bool requireSrgbConversion
	{
		internal get { } //Length: 388
	}

	internal bool resetHistory
	{
		internal get { } //Length: 16
	}

	internal bool resolveToScreen
	{
		internal get { } //Length: 168
	}

	public int scaledHeight
	{
		 get { } //Length: 80
	}

	public int scaledWidth
	{
		 get { } //Length: 80
	}

	public internal XRPass xr
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	internal XRPassUniversal xrUniversal
	{
		internal get { } //Length: 124
	}

	public ColorGamut get_hdrDisplayColorGamut() { }

	public HDRDisplayInformation get_hdrDisplayInformation() { }

	public bool get_isHDROutputActive() { }

	public bool get_isPreviewCamera() { }

	internal bool get_isRenderPassSupportedCamera() { }

	public bool get_isSceneViewCamera() { }

	public bool get_rendersOverlayUI() { }

	internal bool get_requireSrgbConversion() { }

	internal bool get_resetHistory() { }

	internal bool get_resolveToScreen() { }

	public int get_scaledHeight() { }

	public int get_scaledWidth() { }

	[CompilerGenerated]
	[IsReadOnly]
	public XRPass get_xr() { }

	internal XRPassUniversal get_xrUniversal() { }

	public Matrix4x4 GetGPUProjectionMatrix(int viewIndex = 0) { }

	internal Matrix4x4 GetGPUProjectionMatrix(bool renderIntoTexture, int viewIndex = 0) { }

	public Matrix4x4 GetGPUProjectionMatrixNoJitter(int viewIndex = 0) { }

	public Matrix4x4 GetProjectionMatrix(int viewIndex = 0) { }

	internal Matrix4x4 GetProjectionMatrixNoJitter(int viewIndex = 0) { }

	public Matrix4x4 GetViewMatrix(int viewIndex = 0) { }

	public bool IsCameraProjectionMatrixFlipped() { }

	public bool IsHandleYFlipped(RTHandle handle) { }

	public bool IsRenderTargetProjectionMatrixFlipped(RTHandle color, RTHandle depth = null) { }

	internal bool IsTemporalAAEnabled() { }

	internal void PushBuiltinShaderConstantsXR(CommandBuffer cmd, bool renderIntoTexture) { }

	[CompilerGenerated]
	internal void set_xr(XRPass value) { }

	internal void SetViewAndProjectionMatrix(Matrix4x4 viewMatrix, Matrix4x4 projectionMatrix) { }

	internal void SetViewProjectionAndJitterMatrix(Matrix4x4 viewMatrix, Matrix4x4 projectionMatrix, Matrix4x4 jitterMatrix) { }

}

