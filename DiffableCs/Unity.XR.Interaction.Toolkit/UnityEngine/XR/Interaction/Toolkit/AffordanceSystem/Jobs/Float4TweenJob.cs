namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Jobs;

[BurstCompile]
public struct Float4TweenJob : ITweenJob<float4>, IJob
{
	[CompilerGenerated]
	private TweenJobData<float4> <jobData>k__BackingField; //Field offset: 0x0

	public override TweenJobData<float4> jobData
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
	public override TweenJobData<float4> get_jobData() { }

	public override bool IsNearlyEqual(float4 from, float4 to) { }

	public override float4 Lerp(float4 from, float4 to, float t) { }

	[CompilerGenerated]
	public override void set_jobData(TweenJobData<float4> value) { }

}

