namespace UnityEngine;

[NativeHeader("Runtime/Misc/PlayerSettings.h")]
[NativeHeader("Runtime/Graphics/QualitySettings.h")]
[StaticAccessor("GetQualitySettings()", StaticAccessorType::Dot (0))]
public sealed class QualitySettings : object
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<Int32, Int32> activeQualityLevelChanged; //Field offset: 0x0

	public static ColorSpace activeColorSpace
	{
		[NativeName("GetColorSpace")]
		[StaticAccessor("GetPlayerSettings()", StaticAccessorType::Dot (0))]
		 get { } //Length: 40
	}

	public static int antiAliasing
	{
		 get { } //Length: 40
		 set { } //Length: 60
	}

	public static bool billboardsFaceCameraPosition
	{
		 get { } //Length: 40
	}

	public static bool enableLODCrossFade
	{
		 set { } //Length: 60
	}

	[NativeName("RenderPipeline")]
	private static ScriptableObject INTERNAL_renderPipeline
	{
		private get { } //Length: 40
		private set { } //Length: 60
	}

	public static RenderPipelineAsset renderPipeline
	{
		 get { } //Length: 144
		 set { } //Length: 60
	}

	[NativeProperty("ShadowmaskMode")]
	public static ShadowmaskMode shadowmaskMode
	{
		 get { } //Length: 40
	}

	[NativeName("GetColorSpace")]
	[StaticAccessor("GetPlayerSettings()", StaticAccessorType::Dot (0))]
	public static ColorSpace get_activeColorSpace() { }

	public static int get_antiAliasing() { }

	public static bool get_billboardsFaceCameraPosition() { }

	private static ScriptableObject get_INTERNAL_renderPipeline() { }

	public static RenderPipelineAsset get_renderPipeline() { }

	public static ShadowmaskMode get_shadowmaskMode() { }

	[RequiredByNativeCode]
	internal static void OnActiveQualityLevelChanged(int previousQualityLevel, int currentQualityLevel) { }

	public static void set_antiAliasing(int value) { }

	public static void set_enableLODCrossFade(bool value) { }

	private static void set_INTERNAL_renderPipeline(ScriptableObject value) { }

	public static void set_renderPipeline(RenderPipelineAsset value) { }

}

