namespace AnimalCompany;

[NetworkBehaviourWeaved(3)]
public class Hoverpad : NetworkBehaviour
{
	private const float DRAIN_RATE = 0.2; //Field offset: 0x0
	private const float CHARGE_RATE = 0.2; //Field offset: 0x0
	[SerializeField]
	private Transform _hoverOrigin; //Field offset: 0x80
	[SerializeField]
	private List<Renderer> _beams; //Field offset: 0x88
	[SerializeField]
	private AudioSource _motorAudio; //Field offset: 0x90
	[SerializeField]
	private AudioSource _beamAudio; //Field offset: 0x98
	[SerializeField]
	private Renderer _uraniumRenderer; //Field offset: 0xA0
	[SerializeField]
	private RandomSFX _shutdownSFX; //Field offset: 0xA8
	[SerializeField]
	private RandomSFX _startFailSFX; //Field offset: 0xB0
	[DefaultForProperty("turnedOnTick", 0, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private int _turnedOnTick; //Field offset: 0xB8
	[DefaultForProperty("battery", 1, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private float _battery; //Field offset: 0xBC
	private GrabbableItem _grabbable; //Field offset: 0xC0
	[DefaultForProperty("isOn", 2, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[WeaverGenerated]
	private bool _isOn; //Field offset: 0xC8
	private float _turnedOnTime; //Field offset: 0xCC
	private int _beamSizeProp; //Field offset: 0xD0
	private readonly Color BASE_URANIUM_COLOR; //Field offset: 0xD4
	private readonly int EMISSION_COLOR_PROP; //Field offset: 0xE4

	[Networked]
	[NetworkedWeaved(1, 1)]
	[OnChangedRender("HandleBatteryChanged")]
	public float battery
	{
		 get { } //Length: 96
		 set { } //Length: 96
	}

	[Networked]
	[NetworkedWeaved(2, 1)]
	[OnChangedRender("HandleIsOnChanged")]
	private bool isOn
	{
		private get { } //Length: 104
		private set { } //Length: 100
	}

	[Networked]
	[NetworkedWeaved(0, 1)]
	[OnChangedRender("HandleTurnedOnTickChanged")]
	public int turnedOnTick
	{
		 get { } //Length: 96
		 set { } //Length: 96
	}

	public Hoverpad() { }

	private void Awake() { }

	private Vector3 CalculateForce(Vector3 playerVelocity) { }

	[WeaverGenerated]
	public virtual void CopyBackingFieldsToState(bool unnamed_param_0) { }

	[WeaverGenerated]
	public virtual void CopyStateToBackingFields() { }

	private void FixedUpdate() { }

	public virtual void FixedUpdateNetwork() { }

	public float get_battery() { }

	private bool get_isOn() { }

	public int get_turnedOnTick() { }

	private void HandleBatteryChanged() { }

	private void HandleGrabbedChanged() { }

	private void HandleIsOnChanged() { }

	private void HandleTurnedOnTickChanged() { }

	private void HandleUse() { }

	private void OnDestroy() { }

	public void set_battery(float value) { }

	private void set_isOn(bool value) { }

	public void set_turnedOnTick(int value) { }

	public virtual void Spawned() { }

	private void Update() { }

	private void UpdateForce() { }

	private void UpdateHoverVisual() { }

}

