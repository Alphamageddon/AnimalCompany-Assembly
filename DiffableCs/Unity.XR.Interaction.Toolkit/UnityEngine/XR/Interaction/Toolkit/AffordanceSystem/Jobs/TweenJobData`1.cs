namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Jobs;

public struct TweenJobData
{
	public const float squareSnapDistanceThreshold = 2.5000003E-07; //Field offset: 0x0
	public const byte totalStateTransitionIncrements = 255; //Field offset: 0x0
	public T initialValue; //Field offset: 0x0
	public T stateOriginValue; //Field offset: 0x0
	public T stateTargetValue; //Field offset: 0x0
	public byte stateTransitionIncrement; //Field offset: 0x0
	public NativeCurve nativeCurve; //Field offset: 0x0
	public T tweenStartValue; //Field offset: 0x0
	public float tweenAmount; //Field offset: 0x0
	public NativeArray<T> outputData; //Field offset: 0x0

	public float stateTransitionAmountFloat
	{
		 get { } //Length: 24
	}

	public float get_stateTransitionAmountFloat() { }

}

