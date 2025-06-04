namespace UnityEngine;

[NativeHeader("Runtime/Camera/Camera.h")]
[NativeHeader("Runtime/Graphics/CommandBuffer/RenderingCommandBuffer.h")]
[NativeHeader("Runtime/Misc/GameObjectUtility.h")]
[NativeHeader("Runtime/Shaders/Shader.h")]
[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
[NativeHeader("Runtime/Graphics/RenderTexture.h")]
[NativeHeader("Runtime/Camera/RenderManager.h")]
[RequireComponent(typeof(Transform))]
[UsedByNativeCode]
public sealed class Camera : Behaviour
{
	internal sealed class CameraCallback : MulticastDelegate
	{

		public CameraCallback(object object, IntPtr method) { }

		public override void Invoke(Camera cam) { }

	}

	internal enum MonoOrStereoscopicEye
	{
		Left = 0,
		Right = 1,
		Mono = 2,
	}

	internal enum SceneViewFilterMode
	{
		Off = 0,
		ShowFiltered = 1,
	}

	internal enum StereoscopicEye
	{
		Left = 0,
		Right = 1,
	}

	public const float kMinAperture = 0.7; //Field offset: 0x0
	public const float kMaxAperture = 32; //Field offset: 0x0
	public const int kMinBladeCount = 3; //Field offset: 0x0
	public const int kMaxBladeCount = 11; //Field offset: 0x0
	public static CameraCallback onPreCull; //Field offset: 0x0
	public static CameraCallback onPreRender; //Field offset: 0x8
	public static CameraCallback onPostRender; //Field offset: 0x10

	public static Camera[] allCameras
	{
		 get { } //Length: 160
	}

	public static int allCamerasCount
	{
		 get { } //Length: 40
	}

	public bool allowDynamicResolution
	{
		 get { } //Length: 60
	}

	public bool allowHDR
	{
		 get { } //Length: 60
		 set { } //Length: 68
	}

	public bool allowMSAA
	{
		 get { } //Length: 60
		 set { } //Length: 68
	}

	public float aspect
	{
		 get { } //Length: 60
	}

	public Color backgroundColor
	{
		 get { } //Length: 88
		 set { } //Length: 84
	}

	public Matrix4x4 cameraToWorldMatrix
	{
		 get { } //Length: 108
	}

	public CameraType cameraType
	{
		 get { } //Length: 60
	}

	public CameraClearFlags clearFlags
	{
		 get { } //Length: 60
		 set { } //Length: 68
	}

	public int cullingMask
	{
		 get { } //Length: 60
		 set { } //Length: 68
	}

	public static Camera current
	{
		[FreeFunction("GetCurrentCameraPPtr")]
		 get { } //Length: 40
	}

	public float depth
	{
		 get { } //Length: 60
	}

	public DepthTextureMode depthTextureMode
	{
		 get { } //Length: 60
		 set { } //Length: 68
	}

	public int eventMask
	{
		 get { } //Length: 60
	}

	[NativeProperty("Far")]
	public float farClipPlane
	{
		 get { } //Length: 60
	}

	[NativeProperty("VerticalFieldOfView")]
	public float fieldOfView
	{
		 get { } //Length: 60
		 set { } //Length: 76
	}

	[NativeProperty("ForceIntoRT")]
	public bool forceIntoRenderTexture
	{
		 set { } //Length: 68
	}

	public static Camera main
	{
		[FreeFunction("FindMainCamera")]
		 get { } //Length: 40
	}

	[NativeProperty("Near")]
	public float nearClipPlane
	{
		 get { } //Length: 60
	}

	public OpaqueSortMode opaqueSortMode
	{
		 get { } //Length: 60
	}

	public bool orthographic
	{
		 get { } //Length: 60
	}

	public float orthographicSize
	{
		 get { } //Length: 60
		 set { } //Length: 76
	}

	public int pixelHeight
	{
		[FreeFunction("CameraScripting::GetPixelHeight", HasExplicitThis = True)]
		 get { } //Length: 60
	}

	[NativeProperty("ScreenViewportRect")]
	public Rect pixelRect
	{
		 get { } //Length: 88
		 set { } //Length: 84
	}

	public int pixelWidth
	{
		[FreeFunction("CameraScripting::GetPixelWidth", HasExplicitThis = True)]
		 get { } //Length: 60
	}

	public Matrix4x4 projectionMatrix
	{
		 get { } //Length: 108
	}

	[NativeProperty("NormalizedViewportRect")]
	public Rect rect
	{
		 get { } //Length: 88
		 set { } //Length: 84
	}

	public RenderingPath renderingPath
	{
		 set { } //Length: 68
	}

	[NativeConditional("UNITY_EDITOR")]
	public SceneViewFilterMode sceneViewFilterMode
	{
		 get { } //Length: 60
	}

	public bool stereoEnabled
	{
		[NativeMethod("GetStereoEnabledForBuiltInOrSRP")]
		 get { } //Length: 60
	}

	public StereoTargetEyeMask stereoTargetEye
	{
		 get { } //Length: 60
	}

	public int targetDisplay
	{
		 get { } //Length: 60
	}

	public RenderTexture targetTexture
	{
		 get { } //Length: 60
		 set { } //Length: 68
	}

	public bool usePhysicalProperties
	{
		 get { } //Length: 60
	}

	public Matrix4x4 worldToCameraMatrix
	{
		 get { } //Length: 108
		 set { } //Length: 68
	}

	public Camera() { }

	[FreeFunction("CameraScripting::CopyFrom", HasExplicitThis = True)]
	public void CopyFrom(Camera other) { }

	[RequiredByNativeCode]
	private static void FireOnPostRender(Camera cam) { }

	[RequiredByNativeCode]
	private static void FireOnPreCull(Camera cam) { }

	[RequiredByNativeCode]
	private static void FireOnPreRender(Camera cam) { }

	public static Camera[] get_allCameras() { }

	public static int get_allCamerasCount() { }

	public bool get_allowDynamicResolution() { }

	public bool get_allowHDR() { }

	public bool get_allowMSAA() { }

	public float get_aspect() { }

	public Color get_backgroundColor() { }

	private void get_backgroundColor_Injected(out Color ret) { }

	public Matrix4x4 get_cameraToWorldMatrix() { }

	private void get_cameraToWorldMatrix_Injected(out Matrix4x4 ret) { }

	public CameraType get_cameraType() { }

	public CameraClearFlags get_clearFlags() { }

	public int get_cullingMask() { }

	[FreeFunction("GetCurrentCameraPPtr")]
	public static Camera get_current() { }

	public float get_depth() { }

	public DepthTextureMode get_depthTextureMode() { }

	public int get_eventMask() { }

	public float get_farClipPlane() { }

	public float get_fieldOfView() { }

	[FreeFunction("FindMainCamera")]
	public static Camera get_main() { }

	public float get_nearClipPlane() { }

	public OpaqueSortMode get_opaqueSortMode() { }

	public bool get_orthographic() { }

	public float get_orthographicSize() { }

	[FreeFunction("CameraScripting::GetPixelHeight", HasExplicitThis = True)]
	public int get_pixelHeight() { }

	public Rect get_pixelRect() { }

	private void get_pixelRect_Injected(out Rect ret) { }

	[FreeFunction("CameraScripting::GetPixelWidth", HasExplicitThis = True)]
	public int get_pixelWidth() { }

	public Matrix4x4 get_projectionMatrix() { }

	private void get_projectionMatrix_Injected(out Matrix4x4 ret) { }

	public Rect get_rect() { }

	private void get_rect_Injected(out Rect ret) { }

	public SceneViewFilterMode get_sceneViewFilterMode() { }

	[NativeMethod("GetStereoEnabledForBuiltInOrSRP")]
	public bool get_stereoEnabled() { }

	public StereoTargetEyeMask get_stereoTargetEye() { }

	public int get_targetDisplay() { }

	public RenderTexture get_targetTexture() { }

	public bool get_usePhysicalProperties() { }

	public Matrix4x4 get_worldToCameraMatrix() { }

	private void get_worldToCameraMatrix_Injected(out Matrix4x4 ret) { }

	public static int GetAllCameras(Camera[] cameras) { }

	[FreeFunction("CameraScripting::GetAllCamerasCount")]
	private static int GetAllCamerasCount() { }

	[FreeFunction("CameraScripting::GetAllCameras")]
	private static int GetAllCamerasImpl(out Camera[] cam) { }

	[FreeFunction("ScriptableRenderPipeline_Bindings::GetCullingParameters_Internal")]
	[NativeHeader("Runtime/Export/RenderPipeline/ScriptableRenderPipeline.bindings.h")]
	private static bool GetCullingParameters_Internal(Camera camera, bool stereoAware, out ScriptableCullingParameters cullingParameters, int managedCullingParametersSize) { }

	[NativeConditional("UNITY_EDITOR")]
	private int GetFilterMode() { }

	[FreeFunction("CameraScripting::Render", HasExplicitThis = True)]
	public void Render() { }

	[FreeFunction("CameraScripting::RenderWithShader", HasExplicitThis = True)]
	public void RenderWithShader(Shader shader, string replacementTag) { }

	public void ResetWorldToCameraMatrix() { }

	private Ray ScreenPointToRay(Vector2 pos, MonoOrStereoscopicEye eye) { }

	public Ray ScreenPointToRay(Vector3 pos, MonoOrStereoscopicEye eye) { }

	public Ray ScreenPointToRay(Vector3 pos) { }

	private void ScreenPointToRay_Injected(ref Vector2 pos, MonoOrStereoscopicEye eye, out Ray ret) { }

	public Vector3 ScreenToViewportPoint(Vector3 position) { }

	private void ScreenToViewportPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	public Vector3 ScreenToWorldPoint(Vector3 position) { }

	public Vector3 ScreenToWorldPoint(Vector3 position, MonoOrStereoscopicEye eye) { }

	private void ScreenToWorldPoint_Injected(ref Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret) { }

	public void set_allowHDR(bool value) { }

	public void set_allowMSAA(bool value) { }

	public void set_backgroundColor(Color value) { }

	private void set_backgroundColor_Injected(ref Color value) { }

	public void set_clearFlags(CameraClearFlags value) { }

	public void set_cullingMask(int value) { }

	public void set_depthTextureMode(DepthTextureMode value) { }

	public void set_fieldOfView(float value) { }

	public void set_forceIntoRenderTexture(bool value) { }

	public void set_orthographicSize(float value) { }

	public void set_pixelRect(Rect value) { }

	private void set_pixelRect_Injected(ref Rect value) { }

	public void set_rect(Rect value) { }

	private void set_rect_Injected(ref Rect value) { }

	public void set_renderingPath(RenderingPath value) { }

	public void set_targetTexture(RenderTexture value) { }

	public void set_worldToCameraMatrix(Matrix4x4 value) { }

	private void set_worldToCameraMatrix_Injected(ref Matrix4x4 value) { }

	public void SetReplacementShader(Shader shader, string replacementTag) { }

	public void SetStereoProjectionMatrix(StereoscopicEye eye, Matrix4x4 matrix) { }

	private void SetStereoProjectionMatrix_Injected(StereoscopicEye eye, ref Matrix4x4 matrix) { }

	public void SetStereoViewMatrix(StereoscopicEye eye, Matrix4x4 matrix) { }

	private void SetStereoViewMatrix_Injected(StereoscopicEye eye, ref Matrix4x4 matrix) { }

	[FreeFunction("CameraScripting::SetupCurrent")]
	public static void SetupCurrent(Camera cur) { }

	public bool TryGetCullingParameters(bool stereoAware, out ScriptableCullingParameters cullingParameters) { }

	public Vector3 WorldToScreenPoint(Vector3 position) { }

	public Vector3 WorldToScreenPoint(Vector3 position, MonoOrStereoscopicEye eye) { }

	private void WorldToScreenPoint_Injected(ref Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret) { }

}

