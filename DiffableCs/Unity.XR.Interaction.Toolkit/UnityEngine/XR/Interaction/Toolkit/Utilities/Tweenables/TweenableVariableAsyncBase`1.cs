namespace UnityEngine.XR.Interaction.Toolkit.Utilities.Tweenables;

public abstract class TweenableVariableAsyncBase : TweenableVariableBase<T>, IDisposable
{
	private bool m_OutputInitialized; //Field offset: 0x0
	private NativeArray<T> m_JobOutputStore; //Field offset: 0x0
	private bool m_CurveDirty; //Field offset: 0x0
	private NativeCurve m_NativeCurve; //Field offset: 0x0
	private bool m_HasJobPending; //Field offset: 0x0
	private JobHandle m_LastJobHandle; //Field offset: 0x0

	public T Value
	{
		 get { } //Length: 28
		 set { } //Length: 140
	}

	protected TweenableVariableAsyncBase`1() { }

	private bool CompleteJob() { }

	public override void Dispose() { }

	protected virtual void ExecuteTween(T startValue, T targetValue, float tweenAmount, bool useCurve = false) { }

	public T get_Value() { }

	private NativeArray<T> GetJobOutputStore() { }

	private NativeCurve GetNativeCurve() { }

	protected virtual void OnAnimationCurveChanged(AnimationCurve value) { }

	protected virtual void PreprocessTween() { }

	private void RefreshCurve() { }

	protected abstract JobHandle ScheduleTweenJob(ref TweenJobData<T>& jobData) { }

	public void set_Value(T value) { }

	private void UpdateStateFromCompletedJob() { }

}

