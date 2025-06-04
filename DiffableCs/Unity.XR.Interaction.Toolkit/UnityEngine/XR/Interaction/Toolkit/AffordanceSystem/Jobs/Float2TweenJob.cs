namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Jobs;

[BurstCompile]
public struct Float2TweenJob : ITweenJob<float2>, IJob
{
	[CompilerGenerated]
	private TweenJobData<float2> <jobData>k__BackingField; //Field offset: 0x0

	public override TweenJobData<float2> jobData
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 16
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public override void Execute() { }

	[CompilerGenerated]
	[IsReadOnly]
	public override TweenJobData<float2> get_jobData() { }

	public override bool IsNearlyEqual(float2 from, float2 to) { }

	public override float2 Lerp(float2 from, float2 to, float t) { }

	[CompilerGenerated]
	public override void set_jobData(TweenJobData<float2> value) { }

}

