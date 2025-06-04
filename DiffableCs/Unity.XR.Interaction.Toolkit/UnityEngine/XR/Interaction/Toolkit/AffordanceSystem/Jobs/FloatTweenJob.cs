namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Jobs;

[BurstCompile]
public struct FloatTweenJob : ITweenJob<Single>, IJob
{
	[CompilerGenerated]
	private TweenJobData<Single> <jobData>k__BackingField; //Field offset: 0x0

	public override TweenJobData<Single> jobData
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 20
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public override void Execute() { }

	[CompilerGenerated]
	[IsReadOnly]
	public override TweenJobData<Single> get_jobData() { }

	public override bool IsNearlyEqual(float from, float to) { }

	public override float Lerp(float from, float to, float t) { }

	[CompilerGenerated]
	public override void set_jobData(TweenJobData<Single> value) { }

}

