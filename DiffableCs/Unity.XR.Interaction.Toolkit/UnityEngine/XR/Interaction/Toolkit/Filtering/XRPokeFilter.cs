namespace UnityEngine.XR.Interaction.Toolkit.Filtering;

[AddComponentMenu("XR/XR Poke Filter", 11)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.Filtering.XRPokeFilter.html")]
public class XRPokeFilter : MonoBehaviour, IXRPokeFilter, IXRSelectFilter, IXRInteractionStrengthFilter, IPokeStateDataProvider
{
	[SerializeField]
	[Tooltip("The interactable associated with this poke filter.")]
	private XRBaseInteractable m_Interactable; //Field offset: 0x20
	[SerializeField]
	[Tooltip("The collider used to compute bounds of the poke interaction.")]
	private Collider m_PokeCollider; //Field offset: 0x28
	[SerializeField]
	[Tooltip("The settings used to fine tune the vector and offsets which dictate how the poke interaction will be evaluated.")]
	private PokeThresholdDatumProperty m_PokeConfiguration; //Field offset: 0x30
	private XRPokeLogic m_PokeLogic; //Field offset: 0x38
	private readonly BindingsGroup m_BindingsGroup; //Field offset: 0x40

	public override bool canProcess
	{
		 get { } //Length: 48
	}

	public Collider pokeCollider
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public PokeThresholdDatumProperty pokeConfiguration
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public XRBaseInteractable pokeInteractable
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public override IReadOnlyBindableVariable<PokeStateData> pokeStateData
	{
		 get { } //Length: 24
	}

	public XRPokeFilter() { }

	protected void Awake() { }

	private void ClearBindings() { }

	private Collider FindPokeCollider() { }

	private XRBaseInteractable FindPokeInteractable() { }

	public override bool get_canProcess() { }

	public Collider get_pokeCollider() { }

	public PokeThresholdDatumProperty get_pokeConfiguration() { }

	public XRBaseInteractable get_pokeInteractable() { }

	public override IReadOnlyBindableVariable<PokeStateData> get_pokeStateData() { }

	protected void OnDestroy() { }

	[Conditional("UNITY_EDITOR")]
	protected void OnDrawGizmosSelected() { }

	private void OnHoverEntered(HoverEnterEventArgs args) { }

	private void OnHoverExited(HoverExitEventArgs args) { }

	[Conditional("UNITY_EDITOR")]
	protected void OnValidate() { }

	public override bool Process(IXRSelectInteractor interactor, IXRSelectInteractable interactable) { }

	public override float Process(IXRInteractor interactor, IXRInteractable interactable, float interactionStrength) { }

	[Conditional("UNITY_EDITOR")]
	protected override void Reset() { }

	public void set_pokeCollider(Collider value) { }

	public void set_pokeConfiguration(PokeThresholdDatumProperty value) { }

	public void set_pokeInteractable(XRBaseInteractable value) { }

	private void Setup() { }

	private void SetupBindings() { }

	protected void Start() { }

}

