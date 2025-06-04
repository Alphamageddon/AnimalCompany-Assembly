namespace UnityEngine.XR.Interaction.Toolkit.Utilities.Tweenables.Primitives;

public class QuaternionTweenableVariable : TweenableVariableSynchronousBase<Quaternion>
{
	[CompilerGenerated]
	private float <angleEqualityThreshold>k__BackingField; //Field offset: 0x68

	public float angleEqualityThreshold
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public QuaternionTweenableVariable() { }

	[CompilerGenerated]
	public float get_angleEqualityThreshold() { }

	protected virtual bool IsNearlyEqual(Quaternion startValue, Quaternion targetValue) { }

	protected virtual Quaternion Lerp(Quaternion from, Quaternion to, float t) { }

	[CompilerGenerated]
	public void set_angleEqualityThreshold(float value) { }

}

