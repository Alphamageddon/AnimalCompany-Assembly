namespace AnimalCompany;

[NetworkBehaviourWeaved(1)]
public class Flashlight : NetworkBehaviour
{
	private static readonly int PROP_EMISSION_COLOR; //Field offset: 0x0
	private static readonly Color EMISSION_COLOR_LIGHT_ON; //Field offset: 0x4
	[SerializeField]
	private GrabbableItem _grabbable; //Field offset: 0x80
	[SerializeField]
	private MeshRenderer _meshRenderer; //Field offset: 0x88
	[SerializeField]
	private MeshRenderer _lensFlareRenderer; //Field offset: 0x90
	[SerializeField]
	private Light _light; //Field offset: 0x98
	[SerializeField]
	private LightCollider _lightCollider; //Field offset: 0xA0
	[SerializeField]
	private RandomSFX _SFXswitch; //Field offset: 0xA8
	[DefaultForProperty("isOn", 0, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private bool _isOn; //Field offset: 0xB0

	public GrabbableItem grabbable
	{
		 get { } //Length: 8
	}

	[Networked]
	[NetworkedWeaved(0, 1)]
	[OnChangedRender("HandleIsOnChanged")]
	public bool isOn
	{
		 get { } //Length: 104
		 set { } //Length: 100
	}

	public Light light
	{
		 get { } //Length: 8
	}

	private static Flashlight() { }

	public Flashlight() { }

	private void Awake() { }

	[WeaverGenerated]
	public virtual void CopyBackingFieldsToState(bool unnamed_param_0) { }

	[WeaverGenerated]
	public virtual void CopyStateToBackingFields() { }

	public GrabbableItem get_grabbable() { }

	public bool get_isOn() { }

	public Light get_light() { }

	private void HandleInBackpackChanged() { }

	private void HandleIsOnChanged() { }

	private void HandleToggleUse() { }

	private void OnDestroy() { }

	[Rpc(RpcSources::All (7), RpcTargets::StateAuthority (1))]
	public void RPC_ToggleOnOff() { }

	[NetworkRpcWeavedInvoker(1, 7, 1)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_ToggleOnOff@Invoker(NetworkBehaviour behaviour, SimulationMessage* message) { }

	public void set_isOn(bool value) { }

	public virtual void Spawned() { }

}

