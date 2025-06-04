namespace UnityEngine.Rendering.Universal;

[VolumeComponentMenuForRenderPipeline("Post-processing/Lift, Gamma, Gain", new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(UniversalRenderPipeline)}])]
public sealed class LiftGammaGain : VolumeComponent, IPostProcessComponent
{
	[Tooltip("Use this to control and apply a hue to the dark tones. This has a more exaggerated effect on shadows.")]
	public Vector4Parameter lift; //Field offset: 0x38
	[Tooltip("Use this to control and apply a hue to the mid-range tones with a power function.")]
	public Vector4Parameter gamma; //Field offset: 0x40
	[Tooltip("Use this to increase and apply a hue to the signal and make highlights brighter.")]
	public Vector4Parameter gain; //Field offset: 0x48

	public LiftGammaGain() { }

	public override bool IsActive() { }

	public override bool IsTileCompatible() { }

}

