namespace UnityEngine.Rendering.Universal;

[VolumeComponentMenuForRenderPipeline("Post-processing/Vignette", new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(UniversalRenderPipeline)}])]
public sealed class Vignette : VolumeComponent, IPostProcessComponent
{
	[Tooltip("Vignette color.")]
	public ColorParameter color; //Field offset: 0x38
	[Tooltip("Sets the vignette center point (screen center is [0.5,0.5]).")]
	public Vector2Parameter center; //Field offset: 0x40
	[Tooltip("Amount of vignetting on screen.")]
	public ClampedFloatParameter intensity; //Field offset: 0x48
	[Tooltip("Smoothness of the vignette borders.")]
	public ClampedFloatParameter smoothness; //Field offset: 0x50
	[Tooltip("Should the vignette be perfectly round or be dependent on the current aspect ratio?")]
	public BoolParameter rounded; //Field offset: 0x58

	public Vignette() { }

	public override bool IsActive() { }

	public override bool IsTileCompatible() { }

}

