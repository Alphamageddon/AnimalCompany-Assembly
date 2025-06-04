namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Camera/GraphicsSettings.h")]
[StaticAccessor("GetGraphicsSettings()", StaticAccessorType::Dot (0))]
public sealed class GraphicsSettings : object
{

	public static RenderPipelineAsset currentRenderPipeline
	{
		 get { } //Length: 144
	}

	public static uint defaultRenderingLayerMask
	{
		 set { } //Length: 60
	}

	public static RenderPipelineAsset defaultRenderPipeline
	{
		 get { } //Length: 144
		 set { } //Length: 60
	}

	[NativeName("CurrentRenderPipeline")]
	private static ScriptableObject INTERNAL_currentRenderPipeline
	{
		private get { } //Length: 40
	}

	[NativeName("DefaultRenderPipeline")]
	private static ScriptableObject INTERNAL_defaultRenderPipeline
	{
		private get { } //Length: 40
		private set { } //Length: 60
	}

	public static bool lightsUseColorTemperature
	{
		 set { } //Length: 60
	}

	public static bool lightsUseLinearIntensity
	{
		 get { } //Length: 40
		 set { } //Length: 60
	}

	public static RenderPipelineAsset renderPipelineAsset
	{
		 get { } //Length: 4
		 set { } //Length: 60
	}

	public static bool useScriptableRenderPipelineBatching
	{
		 set { } //Length: 60
	}

	public static RenderPipelineAsset get_currentRenderPipeline() { }

	public static RenderPipelineAsset get_defaultRenderPipeline() { }

	private static ScriptableObject get_INTERNAL_currentRenderPipeline() { }

	private static ScriptableObject get_INTERNAL_defaultRenderPipeline() { }

	public static bool get_lightsUseLinearIntensity() { }

	public static RenderPipelineAsset get_renderPipelineAsset() { }

	public static RenderPipelineGlobalSettings GetSettingsForRenderPipeline() { }

	[NativeName("GetSettingsForRenderPipeline")]
	private static object GetSettingsForRenderPipeline(string renderpipelineName) { }

	public static bool HasShaderDefine(GraphicsTier tier, BuiltinShaderDefine defineHash) { }

	public static bool HasShaderDefine(BuiltinShaderDefine defineHash) { }

	[NativeName("RegisterRenderPipelineSettings")]
	private static void RegisterRenderPipeline(string renderpipelineName, object settings) { }

	public static void RegisterRenderPipelineSettings(RenderPipelineGlobalSettings settings) { }

	public static void set_defaultRenderingLayerMask(uint value) { }

	public static void set_defaultRenderPipeline(RenderPipelineAsset value) { }

	private static void set_INTERNAL_defaultRenderPipeline(ScriptableObject value) { }

	public static void set_lightsUseColorTemperature(bool value) { }

	public static void set_lightsUseLinearIntensity(bool value) { }

	public static void set_renderPipelineAsset(RenderPipelineAsset value) { }

	public static void set_useScriptableRenderPipelineBatching(bool value) { }

	[NativeName("UnregisterRenderPipelineSettings")]
	private static void UnregisterRenderPipeline(string renderpipelineName) { }

	public static void UnregisterRenderPipelineSettings() { }

}

