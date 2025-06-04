namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver;

public abstract class BaseAffordanceStateReceiver : MonoBehaviour, IAffordanceStateReceiver<T>, IAffordanceStateReceiver
{
	[SerializeField]
	[Tooltip("Affordance state provider component to subscribe to.")]
	private BaseAffordanceStateProvider m_AffordanceStateProvider; //Field offset: 0x0
	[SerializeField]
	[Tooltip("If true, the initial captured state value for the receiver will replace the idle value in the affordance theme.")]
	private bool m_ReplaceIdleStateValueWithInitialValue; //Field offset: 0x0
	private BaseAffordanceTheme<T> m_AffordanceTheme; //Field offset: 0x0
	private readonly BindableVariable<AffordanceStateData> m_AffordanceStateData; //Field offset: 0x0
	private bool m_Initialized; //Field offset: 0x0
	[CompilerGenerated]
	private T <initialValue>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private bool <initialValueCaptured>k__BackingField; //Field offset: 0x0

	public BaseAffordanceStateProvider affordanceStateProvider
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public override BaseAffordanceTheme<T> affordanceTheme
	{
		 get { } //Length: 8
		 set { } //Length: 20
	}

	protected abstract BindableVariable<T> affordanceValue
	{
		 get { } //Length: 0
	}

	public override IReadOnlyBindableVariable<AffordanceStateData> currentAffordanceStateData
	{
		 get { } //Length: 8
	}

	public override IReadOnlyBindableVariable<T> currentAffordanceValue
	{
		 get { } //Length: 12
	}

	protected abstract BaseAffordanceTheme<T> defaultAffordanceTheme
	{
		 get { } //Length: 0
	}

	protected T initialValue
	{
		[CompilerGenerated]
		 get { } //Length: 12
		[CompilerGenerated]
		 set { } //Length: 12
	}

	protected bool initialValueCaptured
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public bool replaceIdleStateValueWithInitialValue
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	protected BaseAffordanceStateReceiver`1() { }

	protected override void Awake() { }

	protected override void CaptureInitialValue() { }

	protected override void ConsumeAffordance(T newValue) { }

	protected abstract BaseAffordanceTheme<T> GenerateNewAffordanceThemeInstance() { }

	public BaseAffordanceStateProvider get_affordanceStateProvider() { }

	public override BaseAffordanceTheme<T> get_affordanceTheme() { }

	protected abstract BindableVariable<T> get_affordanceValue() { }

	public override IReadOnlyBindableVariable<AffordanceStateData> get_currentAffordanceStateData() { }

	public override IReadOnlyBindableVariable<T> get_currentAffordanceValue() { }

	protected abstract BaseAffordanceTheme<T> get_defaultAffordanceTheme() { }

	[CompilerGenerated]
	protected T get_initialValue() { }

	[CompilerGenerated]
	protected bool get_initialValueCaptured() { }

	public bool get_replaceIdleStateValueWithInitialValue() { }

	protected override T GetCurrentValueForCapture() { }

	private void Initialize() { }

	private void LogIfMissingAffordanceStates(BaseAffordanceTheme<T> theme) { }

	public override void OnAffordanceStateUpdated(AffordanceStateData previousState, AffordanceStateData newState) { }

	protected override void OnAffordanceThemeChanged(BaseAffordanceTheme<T> newValue) { }

	protected abstract void OnAffordanceValueUpdated(T newValue) { }

	protected override void OnDisable() { }

	protected override void OnEnable() { }

	protected override T ProcessTargetAffordanceValue(T newValue) { }

	public void set_affordanceStateProvider(BaseAffordanceStateProvider value) { }

	public void set_affordanceTheme(BaseAffordanceTheme<T> value) { }

	[CompilerGenerated]
	protected void set_initialValue(T value) { }

	[CompilerGenerated]
	protected void set_initialValueCaptured(bool value) { }

	public void set_replaceIdleStateValueWithInitialValue(bool value) { }

	protected override void Start() { }

}

