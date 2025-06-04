namespace UnityEngine.Rendering.Universal;

[VolumeComponentMenuForRenderPipeline("Post-processing/Lens Distortion", new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(UniversalRenderPipeline)}])]
public sealed class LensDistortion : VolumeComponent, IPostProcessComponent
{
	[Tooltip("Total distortion amount.")]
	public ClampedFloatParameter intensity; //Field offset: 0x38
	[Tooltip("Intensity multiplier on X axis. Set it to 0 to disable distortion on this axis.")]
	public ClampedFloatParameter xMultiplier; //Field offset: 0x40
	[Tooltip("Intensity multiplier on Y axis. Set it to 0 to disable distortion on this axis.")]
	public ClampedFloatParameter yMultiplier; //Field offset: 0x48
	[Tooltip("Distortion center point. 0.5,0.5 is center of the screen")]
	public Vector2Parameter center; //Field offset: 0x50
	[Tooltip("Controls global screen scaling for the distortion effect. Use this to hide screen borders when using high \"Intensity.\"")]
	public ClampedFloatParameter scale; //Field offset: 0x58

	public LensDistortion() { }

	public override bool IsActive() { }

	public override bool IsTileCompatible() { }

}

