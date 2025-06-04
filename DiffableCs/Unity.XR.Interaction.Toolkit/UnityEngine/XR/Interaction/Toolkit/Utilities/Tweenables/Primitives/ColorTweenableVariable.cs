namespace UnityEngine.XR.Interaction.Toolkit.Utilities.Tweenables.Primitives;

public class ColorTweenableVariable : TweenableVariableAsyncBase<Color>
{
	[CompilerGenerated]
	private ColorBlendMode <colorBlendMode>k__BackingField; //Field offset: 0xB8
	[CompilerGenerated]
	private float <colorBlendAmount>k__BackingField; //Field offset: 0xBC

	private float colorBlendAmount
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	private ColorBlendMode colorBlendMode
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public ColorTweenableVariable() { }

	[CompilerGenerated]
	private float get_colorBlendAmount() { }

	[CompilerGenerated]
	private ColorBlendMode get_colorBlendMode() { }

	protected virtual JobHandle ScheduleTweenJob(ref TweenJobData<Color>& jobData) { }

	[CompilerGenerated]
	private void set_colorBlendAmount(float value) { }

	[CompilerGenerated]
	private void set_colorBlendMode(ColorBlendMode value) { }

}

