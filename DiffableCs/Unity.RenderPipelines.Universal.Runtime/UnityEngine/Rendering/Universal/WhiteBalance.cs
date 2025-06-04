namespace UnityEngine.Rendering.Universal;

[VolumeComponentMenuForRenderPipeline("Post-processing/White Balance", new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(UniversalRenderPipeline)}])]
public sealed class WhiteBalance : VolumeComponent, IPostProcessComponent
{
	[Tooltip("Sets the white balance to a custom color temperature.")]
	public ClampedFloatParameter temperature; //Field offset: 0x38
	[Tooltip("Sets the white balance to compensate for a green or magenta tint.")]
	public ClampedFloatParameter tint; //Field offset: 0x40

	public WhiteBalance() { }

	public override bool IsActive() { }

	public override bool IsTileCompatible() { }

}

