namespace UnityEngine.Rendering.Universal;

[ExcludeFromPreset]
[ReloadGroup]
public class UniversalRendererData : ScriptableRendererData, ISerializationCallbackReceiver
{
	[ReloadGroup]
	internal sealed class ShaderResources
	{
		[Reload("Shaders/Utils/Blit.shader", Package::Root (1))]
		public Shader blitPS; //Field offset: 0x10
		[Reload("Shaders/Utils/CopyDepth.shader", Package::Root (1))]
		public Shader copyDepthPS; //Field offset: 0x18
		[Obsolete("Obsolete, this feature will be supported by new 'ScreenSpaceShadows' renderer feature")]
		public Shader screenSpaceShadowPS; //Field offset: 0x20
		[Reload("Shaders/Utils/Sampling.shader", Package::Root (1))]
		public Shader samplingPS; //Field offset: 0x28
		[Reload("Shaders/Utils/StencilDeferred.shader", Package::Root (1))]
		public Shader stencilDeferredPS; //Field offset: 0x30
		[Reload("Shaders/Utils/FallbackError.shader", Package::Root (1))]
		public Shader fallbackErrorPS; //Field offset: 0x38
		[Reload("Shaders/Utils/FallbackLoading.shader", Package::Root (1))]
		public Shader fallbackLoadingPS; //Field offset: 0x40
		[Obsolete("Use fallbackErrorPS instead")]
		[Reload("Shaders/Utils/MaterialError.shader", Package::Root (1))]
		public Shader materialErrorPS; //Field offset: 0x48
		[Reload("Shaders/Utils/CoreBlit.shader", Package::Root (1))]
		[SerializeField]
		internal Shader coreBlitPS; //Field offset: 0x50
		[Reload("Shaders/Utils/CoreBlitColorAndDepth.shader", Package::Root (1))]
		[SerializeField]
		internal Shader coreBlitColorAndDepthPS; //Field offset: 0x58
		[Reload("Shaders/Utils/BlitHDROverlay.shader", Package::Root (1))]
		[SerializeField]
		internal Shader blitHDROverlay; //Field offset: 0x60
		[Reload("Shaders/CameraMotionVectors.shader", Package::Root (1))]
		public Shader cameraMotionVector; //Field offset: 0x68
		[Reload("Shaders/ObjectMotionVectors.shader", Package::Root (1))]
		public Shader objectMotionVector; //Field offset: 0x70
		[Reload("Shaders/PostProcessing/LensFlareDataDriven.shader", Package::Root (1))]
		public Shader dataDrivenLensFlare; //Field offset: 0x78

		public ShaderResources() { }

	}

	private const int k_LatestAssetVersion = 2; //Field offset: 0x0
	public PostProcessData postProcessData; //Field offset: 0x40
	[Reload("Runtime/Data/XRSystemData.asset", Package::Root (1))]
	public XRSystemData xrSystemData; //Field offset: 0x48
	public ShaderResources shaders; //Field offset: 0x50
	[SerializeField]
	private int m_AssetVersion; //Field offset: 0x58
	[SerializeField]
	private LayerMask m_OpaqueLayerMask; //Field offset: 0x5C
	[SerializeField]
	private LayerMask m_TransparentLayerMask; //Field offset: 0x60
	[SerializeField]
	private StencilStateData m_DefaultStencilState; //Field offset: 0x68
	[SerializeField]
	private bool m_ShadowTransparentReceive; //Field offset: 0x70
	[SerializeField]
	private RenderingMode m_RenderingMode; //Field offset: 0x74
	[SerializeField]
	private DepthPrimingMode m_DepthPrimingMode; //Field offset: 0x78
	[SerializeField]
	private CopyDepthMode m_CopyDepthMode; //Field offset: 0x7C
	[SerializeField]
	private bool m_AccurateGbufferNormals; //Field offset: 0x80
	[SerializeField]
	private IntermediateTextureMode m_IntermediateTextureMode; //Field offset: 0x84

	public bool accurateGbufferNormals
	{
		 get { } //Length: 8
		 set { } //Length: 40
	}

	public CopyDepthMode copyDepthMode
	{
		 get { } //Length: 8
		 set { } //Length: 40
	}

	public StencilStateData defaultStencilState
	{
		 get { } //Length: 8
		 set { } //Length: 40
	}

	public DepthPrimingMode depthPrimingMode
	{
		 get { } //Length: 8
		 set { } //Length: 40
	}

	public IntermediateTextureMode intermediateTextureMode
	{
		 get { } //Length: 8
		 set { } //Length: 40
	}

	public LayerMask opaqueLayerMask
	{
		 get { } //Length: 8
		 set { } //Length: 40
	}

	public RenderingMode renderingMode
	{
		 get { } //Length: 8
		 set { } //Length: 40
	}

	public bool shadowTransparentReceive
	{
		 get { } //Length: 8
		 set { } //Length: 40
	}

	public LayerMask transparentLayerMask
	{
		 get { } //Length: 8
		 set { } //Length: 40
	}

	public UniversalRendererData() { }

	protected virtual ScriptableRenderer Create() { }

	public bool get_accurateGbufferNormals() { }

	public CopyDepthMode get_copyDepthMode() { }

	public StencilStateData get_defaultStencilState() { }

	public DepthPrimingMode get_depthPrimingMode() { }

	public IntermediateTextureMode get_intermediateTextureMode() { }

	public LayerMask get_opaqueLayerMask() { }

	public RenderingMode get_renderingMode() { }

	public bool get_shadowTransparentReceive() { }

	public LayerMask get_transparentLayerMask() { }

	protected virtual void OnEnable() { }

	private void ReloadAllNullProperties() { }

	public void set_accurateGbufferNormals(bool value) { }

	public void set_copyDepthMode(CopyDepthMode value) { }

	public void set_defaultStencilState(StencilStateData value) { }

	public void set_depthPrimingMode(DepthPrimingMode value) { }

	public void set_intermediateTextureMode(IntermediateTextureMode value) { }

	public void set_opaqueLayerMask(LayerMask value) { }

	public void set_renderingMode(RenderingMode value) { }

	public void set_shadowTransparentReceive(bool value) { }

	public void set_transparentLayerMask(LayerMask value) { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

}

