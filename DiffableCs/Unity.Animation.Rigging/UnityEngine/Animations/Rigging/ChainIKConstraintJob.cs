namespace UnityEngine.Animations.Rigging;

[BurstCompile]
public struct ChainIKConstraintJob : IWeightedAnimationJob, IAnimationJob
{
	public NativeArray<ReadWriteTransformHandle> chain; //Field offset: 0x0
	public ReadOnlyTransformHandle target; //Field offset: 0x10
	public AffineTransform targetOffset; //Field offset: 0x28
	public NativeArray<Single> linkLengths; //Field offset: 0x48
	public NativeArray<Vector3> linkPositions; //Field offset: 0x58
	public FloatProperty chainRotationWeight; //Field offset: 0x68
	public FloatProperty tipRotationWeight; //Field offset: 0x78
	public CacheIndex toleranceIdx; //Field offset: 0x88
	public CacheIndex maxIterationsIdx; //Field offset: 0x8C
	public AnimationJobCache cache; //Field offset: 0x90
	public float maxReach; //Field offset: 0xA0
	[CompilerGenerated]
	private FloatProperty <jobWeight>k__BackingField; //Field offset: 0xA4

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

