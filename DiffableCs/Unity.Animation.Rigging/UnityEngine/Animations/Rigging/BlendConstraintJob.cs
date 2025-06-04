namespace UnityEngine.Animations.Rigging;

[BurstCompile]
public struct BlendConstraintJob : IWeightedAnimationJob, IAnimationJob
{
	private const int k_BlendTranslationMask = 1; //Field offset: 0x0
	private const int k_BlendRotationMask = 2; //Field offset: 0x0
	public ReadWriteTransformHandle driven; //Field offset: 0x0
	public ReadOnlyTransformHandle sourceA; //Field offset: 0xC
	public ReadOnlyTransformHandle sourceB; //Field offset: 0x24
	public AffineTransform sourceAOffset; //Field offset: 0x3C
	public AffineTransform sourceBOffset; //Field offset: 0x58
	public BoolProperty blendPosition; //Field offset: 0x74
	public BoolProperty blendRotation; //Field offset: 0x84
	public FloatProperty positionWeight; //Field offset: 0x94
	public FloatProperty rotationWeight; //Field offset: 0xA4
	[CompilerGenerated]
	private FloatProperty <jobWeight>k__BackingField; //Field offset: 0xB4

	public override FloatProperty jobWeight
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 16
		[CompilerGenerated]
		 set { } //Length: 12
	}

	[CompilerGenerated]
	[IsReadOnly]
	public override FloatProperty get_jobWeight() { }

	public override void ProcessAnimation(AnimationStream stream) { }

	public override void ProcessRootMotion(AnimationStream stream) { }

	[CompilerGenerated]
	public override void set_jobWeight(FloatProperty value) { }

}

