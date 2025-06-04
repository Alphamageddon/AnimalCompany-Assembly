namespace UnityEngine.XR;

[NativeConditional("ENABLE_XR")]
[NativeHeader("Modules/XR/XRPrefix.h")]
[NativeType(Header = "Modules/XR/Subsystems/Display/XRDisplaySubsystem.h")]
[UsedByNativeCode]
public class XRDisplaySubsystem : IntegratedSubsystem<XRDisplaySubsystemDescriptor>
{
	[Flags]
	internal enum TextureLayout
	{
		Texture2DArray = 1,
		SingleTexture2D = 2,
		SeparateTexture2Ds = 4,
	}

	[NativeHeader("Modules/XR/Subsystems/Display/XRDisplaySubsystem.bindings.h")]
	[NativeHeader("Runtime/Graphics/RenderTexture.h")]
	internal struct XRBlitParams
	{
		public RenderTexture srcTex; //Field offset: 0x0
		public int srcTexArraySlice; //Field offset: 0x8
		public Rect srcRect; //Field offset: 0xC
		public Rect destRect; //Field offset: 0x1C
		public IntPtr foveatedRenderingInfo; //Field offset: 0x30
		public bool srcHdrEncoded; //Field offset: 0x38
		public ColorGamut srcHdrColorGamut; //Field offset: 0x3C
		public int srcHdrMaxLuminance; //Field offset: 0x40

	}

	[NativeHeader("Modules/XR/Subsystems/Display/XRDisplaySubsystem.bindings.h")]
	internal struct XRMirrorViewBlitDesc
	{
		private IntPtr displaySubsystemInstance; //Field offset: 0x0
		public bool nativeBlitAvailable; //Field offset: 0x8
		public bool nativeBlitInvalidStates; //Field offset: 0x9
		public int blitParamsCount; //Field offset: 0xC

		[NativeConditional("ENABLE_XR")]
		[NativeMethod(Name = "XRMirrorViewBlitDescScriptApi::GetBlitParameter", IsFreeFunction = True, HasExplicitThis = True)]
		public void GetBlitParameter(int blitParameterIndex, out XRBlitParams blitParameter) { }

		private static void GetBlitParameter_Injected(ref XRMirrorViewBlitDesc _unity_self, int blitParameterIndex, out XRBlitParams blitParameter) { }

	}

	[NativeHeader("Modules/XR/Subsystems/Display/XRDisplaySubsystem.bindings.h")]
	internal struct XRRenderParameter
	{
		public Matrix4x4 view; //Field offset: 0x0
		public Matrix4x4 projection; //Field offset: 0x40
		public Rect viewport; //Field offset: 0x80
		public Mesh occlusionMesh; //Field offset: 0x90
		public int textureArraySlice; //Field offset: 0x98
		public Matrix4x4 previousView; //Field offset: 0x9C
		public bool isPreviousViewValid; //Field offset: 0xDC

	}

	[NativeHeader("Runtime/Graphics/RenderTextureDesc.h")]
	[NativeHeader("Runtime/Graphics/CommandBuffer/RenderingCommandBuffer.h")]
	[NativeHeader("Modules/XR/Subsystems/Display/XRDisplaySubsystem.bindings.h")]
	internal struct XRRenderPass
	{
		private IntPtr displaySubsystemInstance; //Field offset: 0x0
		public int renderPassIndex; //Field offset: 0x8
		public RenderTargetIdentifier renderTarget; //Field offset: 0x10
		public RenderTextureDescriptor renderTargetDesc; //Field offset: 0x38
		public bool hasMotionVectorPass; //Field offset: 0x6C
		public RenderTargetIdentifier motionVectorRenderTarget; //Field offset: 0x70
		public RenderTextureDescriptor motionVectorRenderTargetDesc; //Field offset: 0x98
		public bool shouldFillOutDepth; //Field offset: 0xCC
		public int cullingPassIndex; //Field offset: 0xD0
		public IntPtr foveatedRenderingInfo; //Field offset: 0xD8

		[NativeConditional("ENABLE_XR")]
		[NativeMethod(Name = "XRRenderPassScriptApi::GetRenderParameter", IsFreeFunction = True, HasExplicitThis = True, ThrowsException = True)]
		public void GetRenderParameter(Camera camera, int renderParameterIndex, out XRRenderParameter renderParameter) { }

		private static void GetRenderParameter_Injected(ref XRRenderPass _unity_self, Camera camera, int renderParameterIndex, out XRRenderParameter renderParameter) { }

		[NativeConditional("ENABLE_XR")]
		[NativeMethod(Name = "XRRenderPassScriptApi::GetRenderParameterCount", IsFreeFunction = True, HasExplicitThis = True)]
		public int GetRenderParameterCount() { }

		private static int GetRenderParameterCount_Injected(ref XRRenderPass _unity_self) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<Boolean> displayFocusChanged; //Field offset: 0x20
	private HDROutputSettings m_HDROutputSettings; //Field offset: 0x28

	public bool disableLegacyRenderer
	{
		 set { } //Length: 68
	}

	public HDROutputSettings hdrOutputSettings
	{
		 get { } //Length: 104
	}

	public float scaleOfAllRenderTargets
	{
		 set { } //Length: 76
	}

	public bool sRGB
	{
		 set { } //Length: 68
	}

	public TextureLayout textureLayout
	{
		 set { } //Length: 68
	}

	public float zFar
	{
		 set { } //Length: 76
	}

	public float zNear
	{
		 set { } //Length: 76
	}

	public XRDisplaySubsystem() { }

	[NativeConditional("ENABLE_XR")]
	[NativeHeader("Runtime/Graphics/CommandBuffer/RenderingCommandBuffer.h")]
	[NativeMethod(Name = "AddGraphicsThreadMirrorViewBlit", IsThreadSafe = False)]
	public bool AddGraphicsThreadMirrorViewBlit(CommandBuffer cmd, bool allowGraphicsStateInvalidate, int mode) { }

	public void BeginRecordingIfLateLatched(Camera camera) { }

	public void EndRecordingIfLateLatched(Camera camera) { }

	public HDROutputSettings get_hdrOutputSettings() { }

	public void GetCullingParameters(Camera camera, int cullingPassIndex, out ScriptableCullingParameters scriptableCullingParameters) { }

	[NativeConditional("ENABLE_XR")]
	[NativeMethod(Name = "QueryMirrorViewBlitDesc", IsThreadSafe = False)]
	public bool GetMirrorViewBlitDesc(RenderTexture mirrorRt, out XRMirrorViewBlitDesc outDesc, int mode) { }

	[NativeConditional("ENABLE_XR")]
	[NativeMethod(Name = "GetPreferredMirrorViewBlitMode", IsThreadSafe = False)]
	public int GetPreferredMirrorBlitMode() { }

	public void GetRenderPass(int renderPassIndex, out XRRenderPass renderPass) { }

	public int GetRenderPassCount() { }

	[NativeMethod("TryBeginRecordingIfLateLatched")]
	private bool Internal_TryBeginRecordingIfLateLatched(Camera camera) { }

	[NativeMethod("TryEndRecordingIfLateLatched")]
	private bool Internal_TryEndRecordingIfLateLatched(Camera camera) { }

	[NativeHeader("Runtime/Graphics/ScriptableRenderLoop/ScriptableCulling.h")]
	[NativeMethod("TryGetCullingParams")]
	private bool Internal_TryGetCullingParams(Camera camera, int cullingPassIndex, out ScriptableCullingParameters scriptableCullingParameters) { }

	[NativeMethod("TryGetRenderPass")]
	private bool Internal_TryGetRenderPass(int renderPassIndex, out XRRenderPass renderPass) { }

	[RequiredByNativeCode]
	private void InvokeDisplayFocusChanged(bool focus) { }

	public void set_disableLegacyRenderer(bool value) { }

	public void set_scaleOfAllRenderTargets(float value) { }

	public void set_sRGB(bool value) { }

	public void set_textureLayout(TextureLayout value) { }

	public void set_zFar(float value) { }

	public void set_zNear(float value) { }

	public void SetMSAALevel(int level) { }

	[NativeMethod("TryGetAppGPUTimeLastFrame")]
	public bool TryGetAppGPUTimeLastFrame(out float gpuTimeLastFrame) { }

	[NativeMethod("TryGetCompositorGPUTimeLastFrame")]
	public bool TryGetCompositorGPUTimeLastFrame(out float gpuTimeLastFrameCompositor) { }

	[NativeMethod("TryGetDisplayRefreshRate")]
	public bool TryGetDisplayRefreshRate(out float displayRefreshRate) { }

	[NativeMethod("TryGetMotionToPhoton")]
	public bool TryGetMotionToPhoton(out float motionToPhoton) { }

}

