namespace UnityEngine.Animations.Rigging;

[BurstCompile]
public struct MultiParentConstraintJob : IWeightedAnimationJob, IAnimationJob
{
	private const float k_Epsilon = 1E-05; //Field offset: 0x0
	public ReadWriteTransformHandle driven; //Field offset: 0x0
	public ReadOnlyTransformHandle drivenParent; //Field offset: 0xC
	public NativeArray<ReadOnlyTransformHandle> sourceTransforms; //Field offset: 0x28
	public NativeArray<PropertyStreamHandle> sourceWeights; //Field offset: 0x38
	public NativeArray<AffineTransform> sourceOffsets; //Field offset: 0x48
	public NativeArray<Single> weightBuffer; //Field offset: 0x58
	public Vector3 positionAxesMask; //Field offset: 0x68
	public Vector3 rotationAxesMask; //Field offset: 0x74
	[CompilerGenerated]
	private FloatProperty <jobWeight>k__BackingField; //Field offset: 0x80

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

