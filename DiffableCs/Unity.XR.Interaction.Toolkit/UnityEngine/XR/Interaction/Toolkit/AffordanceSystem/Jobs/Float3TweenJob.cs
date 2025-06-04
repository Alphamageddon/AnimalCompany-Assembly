namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Jobs;

[BurstCompile]
public struct Float3TweenJob : ITweenJob<float3>, IJob
{
	[CompilerGenerated]
	private TweenJobData<float3> <jobData>k__BackingField; //Field offset: 0x0

	public override TweenJobData<float3> jobData
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
	public override TweenJobData<float3> get_jobData() { }

	public override bool IsNearlyEqual(float3 from, float3 to) { }

	public override float3 Lerp(float3 from, float3 to, float t) { }

	[CompilerGenerated]
	public override void set_jobData(TweenJobData<float3> value) { }

}

