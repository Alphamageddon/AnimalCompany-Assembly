namespace UnityEngine.Experimental.Rendering.RenderGraphModule;

public class RenderGraph
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static RenderFunc<ProfilingScopePassData> <>9__62_0; //Field offset: 0x8
		public static RenderFunc<ProfilingScopePassData> <>9__63_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal void <BeginProfilingSampler>b__62_0(ProfilingScopePassData data, RenderGraphContext ctx) { }

		internal void <EndProfilingSampler>b__63_0(ProfilingScopePassData data, RenderGraphContext ctx) { }

	}

	[DebuggerDisplay("RenderPass: {pass.name} (Index:{pass.index} Async:{enableAsyncCompute})")]
	public struct CompiledPassInfo
	{
		public RenderGraphPass pass; //Field offset: 0x0
		public List<Int32>[] resourceCreateList; //Field offset: 0x8
		public List<Int32>[] resourceReleaseList; //Field offset: 0x10
		public int refCount; //Field offset: 0x18
		public bool culled; //Field offset: 0x1C
		public bool culledByRendererList; //Field offset: 0x1D
		public bool hasSideEffect; //Field offset: 0x1E
		public int syncToPassIndex; //Field offset: 0x20
		public int syncFromPassIndex; //Field offset: 0x24
		public bool needGraphicsFence; //Field offset: 0x28
		public GraphicsFence fence; //Field offset: 0x30
		public bool enableAsyncCompute; //Field offset: 0x40

		public bool allowPassCulling
		{
			 get { } //Length: 28
		}

		public bool get_allowPassCulling() { }

		public void Reset(RenderGraphPass pass) { }

	}

	public struct CompiledResourceInfo
	{
		public List<Int32> producers; //Field offset: 0x0
		public List<Int32> consumers; //Field offset: 0x8
		public int refCount; //Field offset: 0x10
		public bool imported; //Field offset: 0x14

		public void Reset() { }

	}

	public sealed class OnExecutionRegisteredDelegate : MulticastDelegate
	{

		public OnExecutionRegisteredDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(RenderGraph graph, string executionName, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(RenderGraph graph, string executionName) { }

	}

	public sealed class OnGraphRegisteredDelegate : MulticastDelegate
	{

		public OnGraphRegisteredDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(RenderGraph graph, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(RenderGraph graph) { }

	}

	private class ProfilingScopePassData
	{
		public ProfilingSampler sampler; //Field offset: 0x10

		public ProfilingScopePassData() { }

	}

	public static readonly int kMaxMRTCount; //Field offset: 0x0
	private static List<RenderGraph> s_RegisteredGraphs; //Field offset: 0x8
	[CompilerGenerated]
	private static bool <requireDebugData>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private static OnGraphRegisteredDelegate onGraphRegistered; //Field offset: 0x18
	[CompilerGenerated]
	private static OnGraphRegisteredDelegate onGraphUnregistered; //Field offset: 0x20
	[CompilerGenerated]
	private static OnExecutionRegisteredDelegate onExecutionRegistered; //Field offset: 0x28
	[CompilerGenerated]
	private static OnExecutionRegisteredDelegate onExecutionUnregistered; //Field offset: 0x30
	private RenderGraphResourceRegistry m_Resources; //Field offset: 0x10
	private RenderGraphObjectPool m_RenderGraphPool; //Field offset: 0x18
	private List<RenderGraphPass> m_RenderPasses; //Field offset: 0x20
	private List<RendererListHandle> m_RendererLists; //Field offset: 0x28
	private RenderGraphDebugParams m_DebugParameters; //Field offset: 0x30
	private RenderGraphLogger m_FrameInformationLogger; //Field offset: 0x38
	private RenderGraphDefaultResources m_DefaultResources; //Field offset: 0x40
	private Dictionary<Int32, ProfilingSampler> m_DefaultProfilingSamplers; //Field offset: 0x48
	private bool m_ExecutionExceptionWasRaised; //Field offset: 0x50
	private RenderGraphContext m_RenderGraphContext; //Field offset: 0x58
	private CommandBuffer m_PreviousCommandBuffer; //Field offset: 0x60
	private int m_CurrentImmediatePassIndex; //Field offset: 0x68
	private List<Int32>[] m_ImmediateModeResourceList; //Field offset: 0x70
	private DynamicArray<CompiledResourceInfo>[] m_CompiledResourcesInfos; //Field offset: 0x78
	private DynamicArray<CompiledPassInfo> m_CompiledPassInfos; //Field offset: 0x80
	private Stack<Int32> m_CullingStack; //Field offset: 0x88
	private int m_ExecutionCount; //Field offset: 0x90
	private int m_CurrentFrameIndex; //Field offset: 0x94
	private bool m_HasRenderGraphBegun; //Field offset: 0x98
	private string m_CurrentExecutionName; //Field offset: 0xA0
	private bool m_RendererListCulling; //Field offset: 0xA8
	private Dictionary<String, RenderGraphDebugData> m_DebugData; //Field offset: 0xB0
	[CompilerGenerated]
	private string <name>k__BackingField; //Field offset: 0xB8

	internal static event OnExecutionRegisteredDelegate onExecutionRegistered
	{
		[CompilerGenerated]
		internal add { } //Length: 220
		[CompilerGenerated]
		internal remove { } //Length: 220
	}

	internal static event OnExecutionRegisteredDelegate onExecutionUnregistered
	{
		[CompilerGenerated]
		internal add { } //Length: 220
		[CompilerGenerated]
		internal remove { } //Length: 220
	}

	internal static event OnGraphRegisteredDelegate onGraphRegistered
	{
		[CompilerGenerated]
		internal add { } //Length: 220
		[CompilerGenerated]
		internal remove { } //Length: 220
	}

	internal static event OnGraphRegisteredDelegate onGraphUnregistered
	{
		[CompilerGenerated]
		internal add { } //Length: 220
		[CompilerGenerated]
		internal remove { } //Length: 220
	}

	public RenderGraphDefaultResources defaultResources
	{
		 get { } //Length: 8
	}

	public private string name
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	internal static bool requireDebugData
	{
		[CompilerGenerated]
		internal get { } //Length: 88
		[CompilerGenerated]
		internal set { } //Length: 96
	}

	private static RenderGraph() { }

	public RenderGraph(string name = "RenderGraph") { }

	[CompilerGenerated]
	internal static void add_onExecutionRegistered(OnExecutionRegisteredDelegate value) { }

	[CompilerGenerated]
	internal static void add_onExecutionUnregistered(OnExecutionRegisteredDelegate value) { }

	[CompilerGenerated]
	internal static void add_onGraphRegistered(OnGraphRegisteredDelegate value) { }

	[CompilerGenerated]
	internal static void add_onGraphUnregistered(OnGraphRegisteredDelegate value) { }

	public RenderGraphBuilder AddRenderPass(string passName, out PassData passData, ProfilingSampler sampler) { }

	public RenderGraphBuilder AddRenderPass(string passName, out PassData passData) { }

	private void AllocateCulledPassResources(ref CompiledPassInfo passInfo, int passIndex) { }

	private bool AreRendererListsEmpty(List<RendererListHandle> rendererLists) { }

	public void BeginProfilingSampler(ProfilingSampler sampler) { }

	public void Cleanup() { }

	private void CleanupDebugData() { }

	internal void ClearCompiledGraph() { }

	private void ClearRenderPasses() { }

	private CompiledPassInfo CompilePassImmediatly(RenderGraphPass pass) { }

	internal void CompileRenderGraph() { }

	private void CountReferences() { }

	public ComputeBufferHandle CreateComputeBuffer(in ComputeBufferHandle computeBuffer) { }

	public ComputeBufferHandle CreateComputeBuffer(in ComputeBufferDesc desc) { }

	public RendererListHandle CreateRendererList(in RendererListDesc desc) { }

	private void CreateRendererLists() { }

	public TextureHandle CreateSharedTexture(in TextureDesc desc, bool explicitRelease = false) { }

	public TextureHandle CreateTexture(TextureHandle texture) { }

	public TextureHandle CreateTexture(in TextureDesc desc) { }

	public void CreateTextureIfInvalid(in TextureDesc desc, ref TextureHandle texture) { }

	private void CullRendererLists() { }

	private void CullUnusedPasses() { }

	public void EndFrame() { }

	public void EndProfilingSampler(ProfilingSampler sampler) { }

	internal void Execute() { }

	private void ExecuteCompiledPass(ref CompiledPassInfo passInfo, int passIndex) { }

	private void ExecutePassImmediatly(RenderGraphPass pass) { }

	private void ExecuteRenderGraph() { }

	private int FindTextureProducer(int consumerPass, in CompiledResourceInfo info, out int index) { }

	private void GenerateDebugData() { }

	public RenderGraphDefaultResources get_defaultResources() { }

	[CompilerGenerated]
	public string get_name() { }

	[CompilerGenerated]
	internal static bool get_requireDebugData() { }

	internal DynamicArray<CompiledPassInfo> GetCompiledPassInfos() { }

	public ComputeBufferDesc GetComputeBufferDesc(in ComputeBufferHandle computeBuffer) { }

	internal RenderGraphDebugData GetDebugData(string executionName) { }

	private ProfilingSampler GetDefaultProfilingSampler(string name) { }

	private int GetFirstValidConsumerIndex(int passIndex, in CompiledResourceInfo info) { }

	private int GetFirstValidWriteIndex(in CompiledResourceInfo info) { }

	internal bool GetImportedFallback(TextureDesc desc, out TextureHandle fallback) { }

	private int GetLatestProducerIndex(int passIndex, in CompiledResourceInfo info) { }

	private int GetLatestValidReadIndex(in CompiledResourceInfo info) { }

	private int GetLatestValidWriteIndex(in CompiledResourceInfo info) { }

	public static List<RenderGraph> GetRegisteredRenderGraphs() { }

	public TextureDesc GetTextureDesc(TextureHandle texture) { }

	public TextureHandle ImportBackbuffer(RenderTargetIdentifier rt) { }

	public ComputeBufferHandle ImportComputeBuffer(ComputeBuffer computeBuffer) { }

	public TextureHandle ImportTexture(RTHandle rt) { }

	private void InitializeCompilationData() { }

	private void InitResourceInfosData(DynamicArray<CompiledResourceInfo> resourceInfos, int count) { }

	private void InvalidateContext() { }

	private void LogCulledPasses() { }

	private void LogFrameInformation() { }

	private void LogRendererListsCreation() { }

	private void LogRenderPassBegin(in CompiledPassInfo passInfo) { }

	internal void OnPassAdded(RenderGraphPass pass) { }

	private void PostRenderPassExecute(ref CompiledPassInfo passInfo, RenderGraphContext rgContext) { }

	private void PreRenderPassExecute(in CompiledPassInfo passInfo, RenderGraphContext rgContext) { }

	private void PreRenderPassSetRenderTargets(in CompiledPassInfo passInfo, RenderGraphContext rgContext) { }

	public RenderGraphExecution RecordAndExecute(in RenderGraphParameters parameters) { }

	public void RefreshSharedTextureDesc(TextureHandle handle, in TextureDesc desc) { }

	public void RegisterDebug(Panel panel = null) { }

	private void ReleaseImmediateModeResources() { }

	public void ReleaseSharedTexture(TextureHandle texture) { }

	[CompilerGenerated]
	internal static void remove_onExecutionRegistered(OnExecutionRegisteredDelegate value) { }

	[CompilerGenerated]
	internal static void remove_onExecutionUnregistered(OnExecutionRegisteredDelegate value) { }

	[CompilerGenerated]
	internal static void remove_onGraphRegistered(OnGraphRegisteredDelegate value) { }

	[CompilerGenerated]
	internal static void remove_onGraphUnregistered(OnGraphRegisteredDelegate value) { }

	[CompilerGenerated]
	private void set_name(string value) { }

	[CompilerGenerated]
	internal static void set_requireDebugData(bool value) { }

	private void TryCullPassAtIndex(int passIndex) { }

	public void UnRegisterDebug() { }

	private void UpdateImportedResourceLifeTime(ref ResourceDebugData data, List<Int32> passList) { }

	private void UpdatePassSynchronization(ref CompiledPassInfo currentPassInfo, ref CompiledPassInfo producerPassInfo, int currentPassIndex, int lastProducer, ref int intLastSyncIndex) { }

	private void UpdateResourceAllocationAndSynchronization() { }

	private void UpdateResourceSynchronization(ref int lastGraphicsPipeSync, ref int lastComputePipeSync, int currentPassIndex, in CompiledResourceInfo resource) { }

}

