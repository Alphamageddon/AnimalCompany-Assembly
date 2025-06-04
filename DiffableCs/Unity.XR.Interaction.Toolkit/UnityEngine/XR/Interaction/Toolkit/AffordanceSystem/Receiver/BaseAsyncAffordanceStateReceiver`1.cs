namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver;

public abstract class BaseAsyncAffordanceStateReceiver : BaseAffordanceStateReceiver<T>, IAsyncAffordanceStateReceiver, IAffordanceStateReceiver
{
	private NativeArray<T> m_JobOutputStore; //Field offset: 0x0
	private NativeCurve m_NativeCurve; //Field offset: 0x0
	private JobHandle m_LastJobHandle; //Field offset: 0x0
	private bool m_OutputInitialized; //Field offset: 0x0

	protected BaseAsyncAffordanceStateReceiver`1() { }

	private NativeArray<T> GetJobOutputStore() { }

	public override JobHandle HandleTween(float tweenTarget) { }

	protected virtual void OnAffordanceThemeChanged(BaseAffordanceTheme<T> newValue) { }

	protected override void OnDestroy() { }

	protected abstract JobHandle ScheduleTweenJob(ref TweenJobData<T>& jobData) { }

	public override void UpdateStateFromCompletedJob() { }

}

