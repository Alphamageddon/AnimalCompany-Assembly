namespace UnityEngine.Rendering.Universal;

internal class DebugHandler : IDebugDisplaySettingsQuery
{
	private class DebugRenderPassEnumerable : IEnumerable<DebugRenderSetup>, IEnumerable
	{
		private class Enumerator : IEnumerator<DebugRenderSetup>, IEnumerator, IDisposable
		{
			private readonly DebugHandler m_DebugHandler; //Field offset: 0x10
			private readonly ScriptableRenderContext m_Context; //Field offset: 0x18
			private readonly CommandBuffer m_CommandBuffer; //Field offset: 0x20
			private readonly FilteringSettings m_FilteringSettings; //Field offset: 0x28
			private readonly int m_NumIterations; //Field offset: 0x40
			private int m_Index; //Field offset: 0x44
			[CompilerGenerated]
			private DebugRenderSetup <Current>k__BackingField; //Field offset: 0x48

			public private override DebugRenderSetup Current
			{
				[CompilerGenerated]
				 get { } //Length: 8
				[CompilerGenerated]
				private set { } //Length: 8
			}

			private override object System.Collections.IEnumerator.Current
			{
				private get { } //Length: 8
			}

			public Enumerator(DebugHandler debugHandler, ScriptableRenderContext context, CommandBuffer commandBuffer, FilteringSettings filteringSettings) { }

			public override void Dispose() { }

			[CompilerGenerated]
			public override DebugRenderSetup get_Current() { }

			public override bool MoveNext() { }

			public override void Reset() { }

			[CompilerGenerated]
			private void set_Current(DebugRenderSetup value) { }

			private override object System.Collections.IEnumerator.get_Current() { }

		}

		private readonly DebugHandler m_DebugHandler; //Field offset: 0x10
		private readonly ScriptableRenderContext m_Context; //Field offset: 0x18
		private readonly CommandBuffer m_CommandBuffer; //Field offset: 0x20
		private readonly FilteringSettings m_FilteringSettings; //Field offset: 0x28

		public DebugRenderPassEnumerable(DebugHandler debugHandler, ScriptableRenderContext context, CommandBuffer commandBuffer, FilteringSettings filteringSettings) { }

		public override IEnumerator<DebugRenderSetup> GetEnumerator() { }

		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	public sealed class DrawFunction : MulticastDelegate
	{

		public DrawFunction(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ScriptableRenderContext context, ref RenderingData renderingData, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref RenderStateBlock renderStateBlock, AsyncCallback callback, object object) { }

		public override void EndInvoke(ref RenderingData renderingData, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref RenderStateBlock renderStateBlock, IAsyncResult result) { }

		public override void Invoke(ScriptableRenderContext context, ref RenderingData renderingData, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref RenderStateBlock renderStateBlock) { }

	}

	private static readonly int k_DebugColorInvalidModePropertyId; //Field offset: 0x0
	private static readonly int k_DebugColorPropertyId; //Field offset: 0x4
	private static readonly int k_DebugTexturePropertyId; //Field offset: 0x8
	private static readonly int k_DebugTextureNoStereoPropertyId; //Field offset: 0xC
	private static readonly int k_DebugTextureDisplayRect; //Field offset: 0x10
	private static readonly int k_DebugRenderTargetSupportsStereo; //Field offset: 0x14
	private static readonly int k_DebugMaterialModeId; //Field offset: 0x18
	private static readonly int k_DebugVertexAttributeModeId; //Field offset: 0x1C
	private static readonly int k_DebugMaterialValidationModeId; //Field offset: 0x20
	private static readonly int k_DebugMipInfoModeId; //Field offset: 0x24
	private static readonly int k_DebugSceneOverrideModeId; //Field offset: 0x28
	private static readonly int k_DebugFullScreenModeId; //Field offset: 0x2C
	private static readonly int k_DebugValidationModeId; //Field offset: 0x30
	private static readonly int k_DebugValidateBelowMinThresholdColorPropertyId; //Field offset: 0x34
	private static readonly int k_DebugValidateAboveMaxThresholdColorPropertyId; //Field offset: 0x38
	private static readonly int k_DebugMaxPixelCost; //Field offset: 0x3C
	private static readonly int k_DebugLightingModeId; //Field offset: 0x40
	private static readonly int k_DebugLightingFeatureFlagsId; //Field offset: 0x44
	private static readonly int k_DebugValidateAlbedoMinLuminanceId; //Field offset: 0x48
	private static readonly int k_DebugValidateAlbedoMaxLuminanceId; //Field offset: 0x4C
	private static readonly int k_DebugValidateAlbedoSaturationToleranceId; //Field offset: 0x50
	private static readonly int k_DebugValidateAlbedoHueToleranceId; //Field offset: 0x54
	private static readonly int k_DebugValidateAlbedoCompareColorId; //Field offset: 0x58
	private static readonly int k_DebugValidateMetallicMinValueId; //Field offset: 0x5C
	private static readonly int k_DebugValidateMetallicMaxValueId; //Field offset: 0x60
	private static readonly int k_ValidationChannelsId; //Field offset: 0x64
	private static readonly int k_RangeMinimumId; //Field offset: 0x68
	private static readonly int k_RangeMaximumId; //Field offset: 0x6C
	private readonly Material m_ReplacementMaterial; //Field offset: 0x10
	private readonly Material m_HDRDebugViewMaterial; //Field offset: 0x18
	private HDRDebugViewPass m_HDRDebugViewPass; //Field offset: 0x20
	private RTHandle m_DebugScreenColorHandle; //Field offset: 0x28
	private RTHandle m_DebugScreenDepthHandle; //Field offset: 0x30
	private bool m_HasDebugRenderTarget; //Field offset: 0x38
	private bool m_DebugRenderTargetSupportsStereo; //Field offset: 0x39
	private Vector4 m_DebugRenderTargetPixelRect; //Field offset: 0x3C
	private RenderTargetIdentifier m_DebugRenderTargetIdentifier; //Field offset: 0x50
	private readonly UniversalRenderPipelineDebugDisplaySettings m_DebugDisplaySettings; //Field offset: 0x78

	public override bool AreAnySettingsActive
	{
		 get { } //Length: 32
	}

	internal UniversalRenderPipelineDebugDisplaySettings DebugDisplaySettings
	{
		internal get { } //Length: 8
	}

	internal RTHandle DebugScreenColorHandle
	{
		internal get { } //Length: 8
	}

	internal RTHandle DebugScreenDepthHandle
	{
		internal get { } //Length: 8
	}

	internal HDRDebugViewPass hdrDebugViewPass
	{
		internal get { } //Length: 8
	}

	internal bool IsActiveModeUnsupportedForDeferred
	{
		internal get { } //Length: 108
	}

	public override bool IsLightingActive
	{
		 get { } //Length: 32
	}

	public override bool IsPostProcessingAllowed
	{
		 get { } //Length: 32
	}

	internal bool IsRenderPassSupported
	{
		internal get { } //Length: 44
	}

	internal bool IsScreenClearNeeded
	{
		internal get { } //Length: 60
	}

	private DebugDisplaySettingsLighting LightingSettings
	{
		private get { } //Length: 28
	}

	private DebugDisplaySettingsMaterial MaterialSettings
	{
		private get { } //Length: 28
	}

	private DebugDisplaySettingsRendering RenderingSettings
	{
		private get { } //Length: 28
	}

	internal Material ReplacementMaterial
	{
		internal get { } //Length: 8
	}

	private static DebugHandler() { }

	internal DebugHandler(ScriptableRendererData scriptableRendererData) { }

	internal static void ConfigureColorDescriptorForDebugScreen(ref RenderTextureDescriptor descriptor, int cameraWidth, int cameraHeight) { }

	internal static void ConfigureDepthDescriptorForDebugScreen(ref RenderTextureDescriptor descriptor, int depthBufferBits, int cameraWidth, int cameraHeight) { }

	internal IEnumerable<DebugRenderSetup> CreateDebugRenderSetupEnumerable(ScriptableRenderContext context, CommandBuffer commandBuffer, FilteringSettings filteringSettings) { }

	public void Dispose() { }

	internal void DrawWithDebugRenderState(ScriptableRenderContext context, CommandBuffer cmd, ref RenderingData renderingData, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref RenderStateBlock renderStateBlock, DrawFunction func) { }

	public override bool get_AreAnySettingsActive() { }

	internal UniversalRenderPipelineDebugDisplaySettings get_DebugDisplaySettings() { }

	internal RTHandle get_DebugScreenColorHandle() { }

	internal RTHandle get_DebugScreenDepthHandle() { }

	internal HDRDebugViewPass get_hdrDebugViewPass() { }

	internal bool get_IsActiveModeUnsupportedForDeferred() { }

	public override bool get_IsLightingActive() { }

	public override bool get_IsPostProcessingAllowed() { }

	internal bool get_IsRenderPassSupported() { }

	internal bool get_IsScreenClearNeeded() { }

	private DebugDisplaySettingsLighting get_LightingSettings() { }

	private DebugDisplaySettingsMaterial get_MaterialSettings() { }

	private DebugDisplaySettingsRendering get_RenderingSettings() { }

	internal Material get_ReplacementMaterial() { }

	internal bool HDRDebugViewIsActive(ref CameraData cameraData) { }

	internal bool IsActiveForCamera(ref CameraData cameraData) { }

	internal void ResetDebugRenderTarget() { }

	internal void SetDebugRenderTarget(RenderTargetIdentifier renderTargetIdentifier, Rect displayRect, bool supportsStereo) { }

	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	internal void Setup(ScriptableRenderContext context, ref RenderingData renderingData) { }

	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	internal void SetupShaderProperties(CommandBuffer cmd, int passIndex = 0) { }

	internal bool TryGetFullscreenDebugMode(out DebugFullScreenMode debugFullScreenMode) { }

	internal bool TryGetFullscreenDebugMode(out DebugFullScreenMode debugFullScreenMode, out int textureHeightPercent) { }

	public override bool TryGetScreenClearColor(ref Color color) { }

	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	internal void UpdateShaderGlobalPropertiesForFinalValidationPass(CommandBuffer cmd, ref CameraData cameraData, bool isFinalPass) { }

	internal bool WriteToDebugScreenTexture(ref CameraData cameraData) { }

}

