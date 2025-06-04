namespace UnityEngine.Animations.Rigging;

[BurstCompile]
public struct TwistCorrectionJob : IWeightedAnimationJob, IAnimationJob
{
	public ReadOnlyTransformHandle source; //Field offset: 0x0
	public Quaternion sourceInverseBindRotation; //Field offset: 0x18
	public Vector3 axisMask; //Field offset: 0x28
	public NativeArray<ReadWriteTransformHandle> twistTransforms; //Field offset: 0x38
	public NativeArray<PropertyStreamHandle> twistWeights; //Field offset: 0x48
	public NativeArray<Quaternion> twistBindRotations; //Field offset: 0x58
	public NativeArray<Single> weightBuffer; //Field offset: 0x68
	[CompilerGenerated]
	private FloatProperty <jobWeight>k__BackingField; //Field offset: 0x78

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

	private static Quaternion TwistRotation(Vector3 axis, Quaternion rot) { }

}

