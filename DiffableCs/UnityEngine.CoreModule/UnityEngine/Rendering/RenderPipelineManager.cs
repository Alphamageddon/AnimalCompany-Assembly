namespace UnityEngine.Rendering;

public static class RenderPipelineManager
{
	internal static RenderPipelineAsset s_CurrentPipelineAsset; //Field offset: 0x0
	private static List<Camera> s_Cameras; //Field offset: 0x8
	private static string s_CurrentPipelineType; //Field offset: 0x10
	private static RenderPipeline s_CurrentPipeline; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<ScriptableRenderContext, Camera[]> beginFrameRendering; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<ScriptableRenderContext, Camera[]> endFrameRendering; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<ScriptableRenderContext, List`1<Camera>> beginContextRendering; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<ScriptableRenderContext, List`1<Camera>> endContextRendering; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<ScriptableRenderContext, Camera> beginCameraRendering; //Field offset: 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<ScriptableRenderContext, Camera> endCameraRendering; //Field offset: 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action activeRenderPipelineTypeChanged; //Field offset: 0x50
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<RenderPipelineAsset, RenderPipelineAsset> activeRenderPipelineAssetChanged; //Field offset: 0x58
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action activeRenderPipelineCreated; //Field offset: 0x60
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action activeRenderPipelineDisposed; //Field offset: 0x68

	public static event Action<ScriptableRenderContext, Camera> beginCameraRendering
	{
		[CompilerGenerated]
		 add { } //Length: 244
		[CompilerGenerated]
		 remove { } //Length: 244
	}

	public static event Action<ScriptableRenderContext, Camera> endCameraRendering
	{
		[CompilerGenerated]
		 add { } //Length: 244
		[CompilerGenerated]
		 remove { } //Length: 244
	}

	public private static RenderPipeline currentPipeline
	{
		 get { } //Length: 88
		private set { } //Length: 160
	}

	private static RenderPipelineManager() { }

	[CompilerGenerated]
	public static void add_beginCameraRendering(Action<ScriptableRenderContext, Camera> value) { }

	[CompilerGenerated]
	public static void add_endCameraRendering(Action<ScriptableRenderContext, Camera> value) { }

	internal static void BeginCameraRendering(ScriptableRenderContext context, Camera camera) { }

	internal static void BeginContextRendering(ScriptableRenderContext context, List<Camera> cameras) { }

	[RequiredByNativeCode]
	internal static void CleanupRenderPipeline() { }

	[RequiredByNativeCode]
	private static void DoRenderLoop_Internal(RenderPipelineAsset pipe, IntPtr loopPtr, object renderRequest) { }

	internal static void EndCameraRendering(ScriptableRenderContext context, Camera camera) { }

	internal static void EndContextRendering(ScriptableRenderContext context, List<Camera> cameras) { }

	public static RenderPipeline get_currentPipeline() { }

	[RequiredByNativeCode]
	private static string GetCurrentPipelineAssetType() { }

	[RequiredByNativeCode]
	internal static void HandleRenderPipelineChange(RenderPipelineAsset pipelineAsset) { }

	private static bool IsPipelineRequireCreation() { }

	[RequiredByNativeCode]
	internal static void OnActiveRenderPipelineAssetChanged(ScriptableObject from, ScriptableObject to) { }

	[RequiredByNativeCode]
	internal static void OnActiveRenderPipelineTypeChanged() { }

	internal static void PrepareRenderPipeline(RenderPipelineAsset pipelineAsset) { }

	[CompilerGenerated]
	public static void remove_beginCameraRendering(Action<ScriptableRenderContext, Camera> value) { }

	[CompilerGenerated]
	public static void remove_endCameraRendering(Action<ScriptableRenderContext, Camera> value) { }

	private static void set_currentPipeline(RenderPipeline value) { }

}

