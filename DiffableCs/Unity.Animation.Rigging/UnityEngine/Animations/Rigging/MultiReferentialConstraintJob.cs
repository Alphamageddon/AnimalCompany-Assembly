namespace UnityEngine.Animations.Rigging;

[BurstCompile]
public struct MultiReferentialConstraintJob : IWeightedAnimationJob, IAnimationJob
{
	public IntProperty driver; //Field offset: 0x0
	public NativeArray<ReadWriteTransformHandle> sources; //Field offset: 0x10
	public NativeArray<AffineTransform> sourceBindTx; //Field offset: 0x20
	public NativeArray<AffineTransform> offsetTx; //Field offset: 0x30
	private int m_PrevDriverIdx; //Field offset: 0x40
	[CompilerGenerated]
	private FloatProperty <jobWeight>k__BackingField; //Field offset: 0x44

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

	internal void UpdateOffsets(int driver) { }

}

