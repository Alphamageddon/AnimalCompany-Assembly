namespace UnityEngine.XR.Interaction.Toolkit.Filtering;

public abstract class XRTargetEvaluator : IDisposable
{
	[HideInInspector]
	[SerializeField]
	private XRTargetFilter m_Filter; //Field offset: 0x10
	[HideInInspector]
	[SerializeField]
	[XRTargetEvaluatorEnabled]
	private bool m_Enabled; //Field offset: 0x18
	[SerializeField]
	[Tooltip("The weight curve of this evaluator. Use this curve to configure the returned score.\n\nThe x-axis is the normalized score (calculated in CalculateNormalizedScore) and the y-axis is the returned score of this evaluator.")]
	private AnimationCurve m_Weight; //Field offset: 0x20
	private bool m_IsAwake; //Field offset: 0x28
	private bool m_IsEnabled; //Field offset: 0x29
	private bool m_IsRegistered; //Field offset: 0x2A

	public bool disposed
	{
		 get { } //Length: 96
	}

	public bool enabled
	{
		 get { } //Length: 8
		 set { } //Length: 472
	}

	public XRTargetFilter filter
	{
		 get { } //Length: 8
	}

	public AnimationCurve weight
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	protected XRTargetEvaluator() { }

	protected override void Awake() { }

	internal void AwakeInternal() { }

	protected abstract float CalculateNormalizedScore(IXRInteractor interactor, IXRInteractable target) { }

	internal static XRTargetEvaluator CreateInstance(Type evaluatorType, XRTargetFilter filter) { }

	internal void DisableInternal() { }

	public override void Dispose() { }

	internal void DisposeInternal() { }

	internal void EnableInternal() { }

	public bool get_disposed() { }

	public bool get_enabled() { }

	public XRTargetFilter get_filter() { }

	public AnimationCurve get_weight() { }

	public float GetWeightedScore(IXRInteractor interactor, IXRInteractable target) { }

	internal static bool IsInstanceType(Type evaluatorType) { }

	protected override void OnDisable() { }

	protected override void OnDispose() { }

	protected override void OnEnable() { }

	private void RegisterHandlers() { }

	public override void Reset() { }

	public void set_enabled(bool value) { }

	public void set_weight(AnimationCurve value) { }

	private void UnregisterHandlers() { }

}

