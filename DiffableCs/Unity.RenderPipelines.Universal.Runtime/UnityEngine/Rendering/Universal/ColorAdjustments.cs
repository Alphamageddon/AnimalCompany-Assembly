namespace UnityEngine.Rendering.Universal;

[VolumeComponentMenuForRenderPipeline("Post-processing/Color Adjustments", new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(UniversalRenderPipeline)}])]
public sealed class ColorAdjustments : VolumeComponent, IPostProcessComponent
{
	[Tooltip("Adjusts the overall exposure of the scene in EV100. This is applied after HDR effect and right before tonemapping so it won't affect previous effects in the chain.")]
	public FloatParameter postExposure; //Field offset: 0x38
	[Tooltip("Expands or shrinks the overall range of tonal values.")]
	public ClampedFloatParameter contrast; //Field offset: 0x40
	[Tooltip("Tint the render by multiplying a color.")]
	public ColorParameter colorFilter; //Field offset: 0x48
	[Tooltip("Shift the hue of all colors.")]
	public ClampedFloatParameter hueShift; //Field offset: 0x50
	[Tooltip("Pushes the intensity of all colors.")]
	public ClampedFloatParameter saturation; //Field offset: 0x58

	public ColorAdjustments() { }

	public override bool IsActive() { }

	public override bool IsTileCompatible() { }

}

