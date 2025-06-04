namespace UnityEngine.Rendering.Universal;

public abstract class ScriptableRenderPass
{
	public static RTHandle k_CameraTarget; //Field offset: 0x0
	[CompilerGenerated]
	private RenderPassEvent <renderPassEvent>k__BackingField; //Field offset: 0x10
	private RenderBufferStoreAction[] m_ColorStoreActions; //Field offset: 0x18
	private RenderBufferStoreAction m_DepthStoreAction; //Field offset: 0x20
	private Boolean[] m_OverriddenColorStoreActions; //Field offset: 0x28
	private bool m_OverriddenDepthStoreAction; //Field offset: 0x30
	[CompilerGenerated]
	private ProfilingSampler <profilingSampler>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private bool <overrideCameraTarget>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private bool <isBlitRenderPass>k__BackingField; //Field offset: 0x41
	[CompilerGenerated]
	private bool <useNativeRenderPass>k__BackingField; //Field offset: 0x42
	[CompilerGenerated]
	private int <renderPassQueueIndex>k__BackingField; //Field offset: 0x44
	internal NativeArray<Int32> m_ColorAttachmentIndices; //Field offset: 0x48
	internal NativeArray<Int32> m_InputAttachmentIndices; //Field offset: 0x58
	[CompilerGenerated]
	private GraphicsFormat[] <renderTargetFormat>k__BackingField; //Field offset: 0x68
	internal bool m_UsesRTHandles; //Field offset: 0x70
	private RTHandle[] m_ColorAttachments; //Field offset: 0x78
	private RenderTargetIdentifier[] m_ColorAttachmentIds; //Field offset: 0x80
	internal RTHandle[] m_InputAttachments; //Field offset: 0x88
	internal Boolean[] m_InputAttachmentIsTransient; //Field offset: 0x90
	private RTHandle m_DepthAttachment; //Field offset: 0x98
	private RenderTargetIdentifier m_DepthAttachmentId; //Field offset: 0xA0
	private ScriptableRenderPassInput m_Input; //Field offset: 0xC8
	private ClearFlag m_ClearFlag; //Field offset: 0xCC
	private Color m_ClearColor; //Field offset: 0xD0

	public Color clearColor
	{
		 get { } //Length: 12
	}

	public ClearFlag clearFlag
	{
		 get { } //Length: 8
	}

	[Obsolete("Use colorAttachmentHandle")]
	public RenderTargetIdentifier colorAttachment
	{
		 get { } //Length: 52
	}

	public RTHandle colorAttachmentHandle
	{
		 get { } //Length: 40
	}

	public RTHandle[] colorAttachmentHandles
	{
		 get { } //Length: 8
	}

	[Obsolete("Use colorAttachmentHandles")]
	public RenderTargetIdentifier[] colorAttachments
	{
		 get { } //Length: 8
	}

	public RenderBufferStoreAction[] colorStoreActions
	{
		 get { } //Length: 8
	}

	[Obsolete("Use depthAttachmentHandle")]
	public RenderTargetIdentifier depthAttachment
	{
		 get { } //Length: 120
	}

	public RTHandle depthAttachmentHandle
	{
		 get { } //Length: 8
	}

	public RenderBufferStoreAction depthStoreAction
	{
		 get { } //Length: 8
	}

	public ScriptableRenderPassInput input
	{
		 get { } //Length: 8
	}

	internal bool isBlitRenderPass
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 12
	}

	internal Boolean[] overriddenColorStoreActions
	{
		internal get { } //Length: 8
	}

	internal bool overriddenDepthStoreAction
	{
		internal get { } //Length: 8
	}

	internal bool overrideCameraTarget
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 12
	}

	protected private ProfilingSampler profilingSampler
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public RenderPassEvent renderPassEvent
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	internal int renderPassQueueIndex
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	internal GraphicsFormat[] renderTargetFormat
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	internal bool useNativeRenderPass
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 12
	}

	private static ScriptableRenderPass() { }

	public ScriptableRenderPass() { }

	public void Blit(CommandBuffer cmd, ref RenderingData data, RTHandle source, Material material, int passIndex = 0) { }

	public void Blit(CommandBuffer cmd, ref RenderingData data, Material material, int passIndex = 0) { }

	public void Blit(CommandBuffer cmd, RTHandle source, RTHandle destination, Material material = null, int passIndex = 0) { }

	[Obsolete("Use RTHandles for source and destination")]
	public void Blit(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material = null, int passIndex = 0) { }

	public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor) { }

	public void ConfigureClear(ClearFlag clearFlag, Color clearColor) { }

	public void ConfigureColorStoreAction(RenderBufferStoreAction storeAction, uint attachmentIndex = 0) { }

	public void ConfigureColorStoreActions(RenderBufferStoreAction[] storeActions) { }

	public void ConfigureDepthStoreAction(RenderBufferStoreAction storeAction) { }

	public void ConfigureInput(ScriptableRenderPassInput passInput) { }

	internal void ConfigureInputAttachments(RTHandle[] inputs, Boolean[] isTransient) { }

	internal void ConfigureInputAttachments(RTHandle input, bool isTransient = false) { }

	internal void ConfigureInputAttachments(RTHandle[] inputs) { }

	[Obsolete("Use RTHandles for colorAttachment and depthAttachment")]
	public void ConfigureTarget(RenderTargetIdentifier colorAttachment, RenderTargetIdentifier depthAttachment) { }

	public void ConfigureTarget(RTHandle colorAttachment, RTHandle depthAttachment) { }

	[Obsolete("Use RTHandles for colorAttachments and depthAttachment")]
	public void ConfigureTarget(RenderTargetIdentifier[] colorAttachments, RenderTargetIdentifier depthAttachment) { }

	public void ConfigureTarget(RTHandle[] colorAttachments, RTHandle depthAttachment) { }

	internal void ConfigureTarget(RTHandle[] colorAttachments, RTHandle depthAttachment, GraphicsFormat[] formats) { }

	public void ConfigureTarget(RTHandle colorAttachment) { }

	[Obsolete("Use RTHandle for colorAttachment")]
	public void ConfigureTarget(RenderTargetIdentifier colorAttachment) { }

	public void ConfigureTarget(RTHandle[] colorAttachments) { }

	[Obsolete("Use RTHandles for colorAttachments")]
	public void ConfigureTarget(RenderTargetIdentifier[] colorAttachments) { }

	public DrawingSettings CreateDrawingSettings(ShaderTagId shaderTagId, ref RenderingData renderingData, SortingCriteria sortingCriteria) { }

	public DrawingSettings CreateDrawingSettings(List<ShaderTagId> shaderTagIdList, ref RenderingData renderingData, SortingCriteria sortingCriteria) { }

	public abstract void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	public override void FrameCleanup(CommandBuffer cmd) { }

	public Color get_clearColor() { }

	public ClearFlag get_clearFlag() { }

	public RenderTargetIdentifier get_colorAttachment() { }

	public RTHandle get_colorAttachmentHandle() { }

	public RTHandle[] get_colorAttachmentHandles() { }

	public RenderTargetIdentifier[] get_colorAttachments() { }

	public RenderBufferStoreAction[] get_colorStoreActions() { }

	public RenderTargetIdentifier get_depthAttachment() { }

	public RTHandle get_depthAttachmentHandle() { }

	public RenderBufferStoreAction get_depthStoreAction() { }

	public ScriptableRenderPassInput get_input() { }

	[CompilerGenerated]
	internal bool get_isBlitRenderPass() { }

	internal Boolean[] get_overriddenColorStoreActions() { }

	internal bool get_overriddenDepthStoreAction() { }

	[CompilerGenerated]
	internal bool get_overrideCameraTarget() { }

	[CompilerGenerated]
	protected private ProfilingSampler get_profilingSampler() { }

	[CompilerGenerated]
	public RenderPassEvent get_renderPassEvent() { }

	[CompilerGenerated]
	internal int get_renderPassQueueIndex() { }

	[CompilerGenerated]
	internal GraphicsFormat[] get_renderTargetFormat() { }

	[CompilerGenerated]
	internal bool get_useNativeRenderPass() { }

	internal static DebugHandler GetActiveDebugHandler(ref RenderingData renderingData) { }

	internal static int GetRenderPassEventRange(RenderPassEvent renderPassEvent) { }

	internal bool IsInputAttachmentTransient(int idx) { }

	public override void OnCameraCleanup(CommandBuffer cmd) { }

	public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData) { }

	public override void OnFinishCameraStackRendering(CommandBuffer cmd) { }

	public static bool op_GreaterThan(ScriptableRenderPass lhs, ScriptableRenderPass rhs) { }

	public static bool op_LessThan(ScriptableRenderPass lhs, ScriptableRenderPass rhs) { }

	internal override void RecordRenderGraph(RenderGraph renderGraph, ref RenderingData renderingData) { }

	public void ResetTarget() { }

	[CompilerGenerated]
	internal void set_isBlitRenderPass(bool value) { }

	[CompilerGenerated]
	internal void set_overrideCameraTarget(bool value) { }

	[CompilerGenerated]
	protected private void set_profilingSampler(ProfilingSampler value) { }

	[CompilerGenerated]
	public void set_renderPassEvent(RenderPassEvent value) { }

	[CompilerGenerated]
	internal void set_renderPassQueueIndex(int value) { }

	[CompilerGenerated]
	internal void set_renderTargetFormat(GraphicsFormat[] value) { }

	[CompilerGenerated]
	internal void set_useNativeRenderPass(bool value) { }

	internal void SetInputAttachmentTransient(int idx, bool isTransient) { }

}

