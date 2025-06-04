namespace UnityEngine.Animations.Rigging;

[BurstCompile]
public struct MultiRotationConstraintJob : IWeightedAnimationJob, IAnimationJob
{
	private const float k_Epsilon = 1E-05; //Field offset: 0x0
	public ReadWriteTransformHandle driven; //Field offset: 0x0
	public ReadOnlyTransformHandle drivenParent; //Field offset: 0xC
	public Vector3Property drivenOffset; //Field offset: 0x24
	public NativeArray<ReadOnlyTransformHandle> sourceTransforms; //Field offset: 0x58
	public NativeArray<PropertyStreamHandle> sourceWeights; //Field offset: 0x68
	public NativeArray<Quaternion> sourceOffsets; //Field offset: 0x78
	public NativeArray<Single> weightBuffer; //Field offset: 0x88
	public Vector3 axesMask; //Field offset: 0x98
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

