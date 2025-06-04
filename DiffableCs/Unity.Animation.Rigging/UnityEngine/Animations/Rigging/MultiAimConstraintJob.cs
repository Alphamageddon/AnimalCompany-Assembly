namespace UnityEngine.Animations.Rigging;

[BurstCompile]
public struct MultiAimConstraintJob : IWeightedAnimationJob, IAnimationJob
{
	internal enum WorldUpType
	{
		None = 0,
		SceneUp = 1,
		ObjectUp = 2,
		ObjectRotationUp = 3,
		Vector = 4,
	}

	private const float k_Epsilon = 1E-05; //Field offset: 0x0
	public ReadWriteTransformHandle driven; //Field offset: 0x0
	public ReadOnlyTransformHandle drivenParent; //Field offset: 0xC
	public Vector3Property drivenOffset; //Field offset: 0x24
	public NativeArray<ReadOnlyTransformHandle> sourceTransforms; //Field offset: 0x58
	public NativeArray<PropertyStreamHandle> sourceWeights; //Field offset: 0x68
	public NativeArray<Quaternion> sourceOffsets; //Field offset: 0x78
	public NativeArray<Single> weightBuffer; //Field offset: 0x88
	public Vector3 aimAxis; //Field offset: 0x98
	public Vector3 upAxis; //Field offset: 0xA4
	public WorldUpType worldUpType; //Field offset: 0xB0
	public Vector3 worldUpAxis; //Field offset: 0xB4
	public ReadOnlyTransformHandle worldUpObject; //Field offset: 0xC0
	public Vector3 axesMask; //Field offset: 0xD8
	public FloatProperty minLimit; //Field offset: 0xE4
	public FloatProperty maxLimit; //Field offset: 0xF4
	[CompilerGenerated]
	private FloatProperty <jobWeight>k__BackingField; //Field offset: 0x104

	public override FloatProperty jobWeight
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 12
		[CompilerGenerated]
		 set { } //Length: 12
	}

	private Vector3 ComputeWorldUpVector(AnimationStream stream) { }

	[CompilerGenerated]
	[IsReadOnly]
	public override FloatProperty get_jobWeight() { }

	public override void ProcessAnimation(AnimationStream stream) { }

	public override void ProcessRootMotion(AnimationStream stream) { }

	[CompilerGenerated]
	public override void set_jobWeight(FloatProperty value) { }

}

