namespace UnityEngine.Rendering.Universal;

[VolumeComponentMenuForRenderPipeline("Post-processing/Chromatic Aberration", new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(UniversalRenderPipeline)}])]
public sealed class ChromaticAberration : VolumeComponent, IPostProcessComponent
{
	[Tooltip("Use the slider to set the strength of the Chromatic Aberration effect.")]
	public ClampedFloatParameter intensity; //Field offset: 0x38

	public ChromaticAberration() { }

	public override bool IsActive() { }

	public override bool IsTileCompatible() { }

}

