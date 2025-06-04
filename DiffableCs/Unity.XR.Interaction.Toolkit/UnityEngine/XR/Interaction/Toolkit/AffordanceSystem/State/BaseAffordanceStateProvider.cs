namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.State;

public abstract class BaseAffordanceStateProvider : MonoBehaviour
{
	[Range(0, 5)]
	[SerializeField]
	[Tooltip("Duration of transition in seconds. 0 means no smoothing.")]
	private float m_TransitionDuration; //Field offset: 0x20
	private readonly BindableVariable<AffordanceStateData> m_AffordanceStateData; //Field offset: 0x28
	private readonly HashSetList<IAsyncAffordanceStateReceiver> m_AsyncAffordanceReceivers; //Field offset: 0x30
	private readonly HashSetList<ISynchronousAffordanceStateReceiver> m_SynchronousAffordanceReceivers; //Field offset: 0x38
	private readonly List<JobHandle> m_ScheduledJobs; //Field offset: 0x40
	private readonly BindingsGroup m_BindingsGroup; //Field offset: 0x48
	private float m_TimeSinceLastStateUpdate; //Field offset: 0x50
	private bool m_IsFirstFrame; //Field offset: 0x54
	private bool m_CompletingTweens; //Field offset: 0x55
	private float m_InterpolationSpeed; //Field offset: 0x58
	private float m_MaxTransitionDuration; //Field offset: 0x5C

	public IReadOnlyBindableVariable<AffordanceStateData> currentAffordanceStateData
	{
		 get { } //Length: 8
	}

	public bool isCurrentlyTransitioning
	{
		 get { } //Length: 96
	}

	public float transitionDuration
	{
		 get { } //Length: 8
		 set { } //Length: 40
	}

	protected BaseAffordanceStateProvider() { }

	protected void AddBinding(IEventBinding binding) { }

	protected override void BindToProviders() { }

	protected override void ClearBindings() { }

	private bool CompleteJobs() { }

	private void DoTween(float tweenTarget) { }

	public IReadOnlyBindableVariable<AffordanceStateData> get_currentAffordanceStateData() { }

	public bool get_isCurrentlyTransitioning() { }

	public float get_transitionDuration() { }

	private void OnAffordanceStateUpdated(AffordanceStateData newAffordanceStateData) { }

	protected override void OnDisable() { }

	protected override void OnEnable() { }

	protected override void OnValidate() { }

	private void RefreshTransitionDuration() { }

	public bool RegisterAffordanceReceiver(IAffordanceStateReceiver receiver) { }

	private bool RegisterAffordanceReceiver(IAsyncAffordanceStateReceiver receiver) { }

	private bool RegisterAffordanceReceiver(ISynchronousAffordanceStateReceiver receiver) { }

	public void set_transitionDuration(float value) { }

	public bool UnregisterAffordanceReceiver(IAffordanceStateReceiver receiver) { }

	private bool UnregisterAffordanceReceiver(IAsyncAffordanceStateReceiver receiver) { }

	private bool UnregisterAffordanceReceiver(ISynchronousAffordanceStateReceiver receiver) { }

	protected override void Update() { }

	public void UpdateAffordanceState(AffordanceStateData newAffordanceStateData) { }

}

