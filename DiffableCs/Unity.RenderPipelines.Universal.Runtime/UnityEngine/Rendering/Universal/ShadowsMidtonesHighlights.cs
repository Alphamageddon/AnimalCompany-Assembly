namespace UnityEngine.Rendering.Universal;

[VolumeComponentMenuForRenderPipeline("Post-processing/Shadows, Midtones, Highlights", new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(UniversalRenderPipeline)}])]
public sealed class ShadowsMidtonesHighlights : VolumeComponent, IPostProcessComponent
{
	[Tooltip("Use this to control and apply a hue to the shadows.")]
	public Vector4Parameter shadows; //Field offset: 0x38
	[Tooltip("Use this to control and apply a hue to the midtones.")]
	public Vector4Parameter midtones; //Field offset: 0x40
	[Tooltip("Use this to control and apply a hue to the highlights.")]
	public Vector4Parameter highlights; //Field offset: 0x48
	[Header("Shadow Limits")]
	[Tooltip("Start point of the transition between shadows and midtones.")]
	public MinFloatParameter shadowsStart; //Field offset: 0x50
	[Tooltip("End point of the transition between shadows and midtones.")]
	public MinFloatParameter shadowsEnd; //Field offset: 0x58
	[Header("Highlight Limits")]
	[Tooltip("Start point of the transition between midtones and highlights.")]
	public MinFloatParameter highlightsStart; //Field offset: 0x60
	[Tooltip("End point of the transition between midtones and highlights.")]
	public MinFloatParameter highlightsEnd; //Field offset: 0x68

	public ShadowsMidtonesHighlights() { }

	public override bool IsActive() { }

	public override bool IsTileCompatible() { }

}

