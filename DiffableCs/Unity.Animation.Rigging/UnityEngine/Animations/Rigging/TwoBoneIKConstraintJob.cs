namespace UnityEngine.Animations.Rigging;

[BurstCompile]
public struct TwoBoneIKConstraintJob : IWeightedAnimationJob, IAnimationJob
{
	public ReadWriteTransformHandle root; //Field offset: 0x0
	public ReadWriteTransformHandle mid; //Field offset: 0xC
	public ReadWriteTransformHandle tip; //Field offset: 0x18
	public ReadOnlyTransformHandle hint; //Field offset: 0x24
	public ReadOnlyTransformHandle target; //Field offset: 0x3C
	public AffineTransform targetOffset; //Field offset: 0x54
	public FloatProperty targetPositionWeight; //Field offset: 0x70
	public FloatProperty targetRotationWeight; //Field offset: 0x80
	public FloatProperty hintWeight; //Field offset: 0x90
	[CompilerGenerated]
	private FloatProperty <jobWeight>k__BackingField; //Field offset: 0xA0

	public override FloatProperty jobWeight
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 12
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[CompilerGenerated]
	[IsReadOnly]
	public override FloatProperty get_jobWeight() { }

	public override void ProcessAnimation(AnimationStream stream) { }

	public override void ProcessRootMotion(AnimationStream stream) { }

	[CompilerGenerated]
	public override void set_jobWeight(FloatProperty value) { }

}

