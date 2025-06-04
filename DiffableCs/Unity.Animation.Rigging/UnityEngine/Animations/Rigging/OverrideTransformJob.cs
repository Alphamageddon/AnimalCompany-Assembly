namespace UnityEngine.Animations.Rigging;

[BurstCompile]
public struct OverrideTransformJob : IWeightedAnimationJob, IAnimationJob
{
	internal enum Space
	{
		World = 0,
		Local = 1,
		Pivot = 2,
	}

	public ReadWriteTransformHandle driven; //Field offset: 0x0
	public ReadOnlyTransformHandle source; //Field offset: 0xC
	public AffineTransform sourceInvLocalBindTx; //Field offset: 0x24
	public Quaternion sourceToWorldRot; //Field offset: 0x40
	public Quaternion sourceToLocalRot; //Field offset: 0x50
	public Quaternion sourceToPivotRot; //Field offset: 0x60
	public CacheIndex spaceIdx; //Field offset: 0x70
	public CacheIndex sourceToCurrSpaceRotIdx; //Field offset: 0x74
	public Vector3Property position; //Field offset: 0x78
	public Vector3Property rotation; //Field offset: 0xA8
	public FloatProperty positionWeight; //Field offset: 0xD8
	public FloatProperty rotationWeight; //Field offset: 0xE8
	public AnimationJobCache cache; //Field offset: 0xF8
	[CompilerGenerated]
	private FloatProperty <jobWeight>k__BackingField; //Field offset: 0x108

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

	internal void UpdateSpace(int space) { }

}

