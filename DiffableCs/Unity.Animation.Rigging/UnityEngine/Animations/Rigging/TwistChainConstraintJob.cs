namespace UnityEngine.Animations.Rigging;

[BurstCompile]
public struct TwistChainConstraintJob : IWeightedAnimationJob, IAnimationJob
{
	public ReadWriteTransformHandle rootTarget; //Field offset: 0x0
	public ReadWriteTransformHandle tipTarget; //Field offset: 0xC
	public NativeArray<ReadWriteTransformHandle> chain; //Field offset: 0x18
	public NativeArray<Single> steps; //Field offset: 0x28
	public NativeArray<Single> weights; //Field offset: 0x38
	public NativeArray<Quaternion> rotations; //Field offset: 0x48
	[CompilerGenerated]
	private FloatProperty <jobWeight>k__BackingField; //Field offset: 0x58

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

