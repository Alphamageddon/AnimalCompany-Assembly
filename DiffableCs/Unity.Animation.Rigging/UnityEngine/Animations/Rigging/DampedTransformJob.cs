namespace UnityEngine.Animations.Rigging;

[BurstCompile]
public struct DampedTransformJob : IWeightedAnimationJob, IAnimationJob
{
	private const float k_FixedDt = 0.01667; //Field offset: 0x0
	private const float k_DampFactor = 40; //Field offset: 0x0
	public ReadWriteTransformHandle driven; //Field offset: 0x0
	public ReadOnlyTransformHandle source; //Field offset: 0xC
	public AffineTransform localBindTx; //Field offset: 0x24
	public Vector3 aimBindAxis; //Field offset: 0x40
	public AffineTransform prevDrivenTx; //Field offset: 0x4C
	public FloatProperty dampPosition; //Field offset: 0x68
	public FloatProperty dampRotation; //Field offset: 0x78
	[CompilerGenerated]
	private FloatProperty <jobWeight>k__BackingField; //Field offset: 0x88

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

