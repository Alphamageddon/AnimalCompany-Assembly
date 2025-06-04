namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Jobs;

[BurstCompile]
public struct ColorTweenJob : ITweenJob<Color>, IJob
{
	[CompilerGenerated]
	private TweenJobData<Color> <jobData>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private byte <colorBlendMode>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private float <colorBlendAmount>k__BackingField; //Field offset: 0x7C

	public float colorBlendAmount
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public byte colorBlendMode
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public override TweenJobData<Color> jobData
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
	public float get_colorBlendAmount() { }

	[CompilerGenerated]
	[IsReadOnly]
	public byte get_colorBlendMode() { }

	[CompilerGenerated]
	[IsReadOnly]
	public override TweenJobData<Color> get_jobData() { }

	public override bool IsNearlyEqual(Color from, Color to) { }

	public override Color Lerp(Color from, Color to, float t) { }

	private Color ProcessTargetAffordanceValue(Color initialValue, Color newValue) { }

	[CompilerGenerated]
	public void set_colorBlendAmount(float value) { }

	[CompilerGenerated]
	public void set_colorBlendMode(byte value) { }

	[CompilerGenerated]
	public override void set_jobData(TweenJobData<Color> value) { }

}

