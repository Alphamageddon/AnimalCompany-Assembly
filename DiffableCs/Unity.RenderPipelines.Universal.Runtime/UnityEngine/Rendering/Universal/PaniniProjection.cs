namespace UnityEngine.Rendering.Universal;

[VolumeComponentMenuForRenderPipeline("Post-processing/Panini Projection", new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(UniversalRenderPipeline)}])]
public sealed class PaniniProjection : VolumeComponent, IPostProcessComponent
{
	[Tooltip("Panini projection distance.")]
	public ClampedFloatParameter distance; //Field offset: 0x38
	[Tooltip("Panini projection crop to fit.")]
	public ClampedFloatParameter cropToFit; //Field offset: 0x40

	public PaniniProjection() { }

	public override bool IsActive() { }

	public override bool IsTileCompatible() { }

}

