namespace AnimalCompany;

[DefaultExecutionOrder(102)]
[NetworkBehaviourWeaved(4)]
public class PlayerWatch : NetworkBehaviour
{
	internal enum WatchDisplay
	{
		Money = 0,
		Map = 1,
	}

	private const float PROJ_DISTANCE_TO_EXPAND = 0.88; //Field offset: 0x0
	private const float PROJ_DISTANCE_TO_SHRINK = 0.6; //Field offset: 0x0
	private const int TOTAL_CHANNELS = 10; //Field offset: 0x0
	private const float TOGGLE_TIME = 1; //Field offset: 0x0
	private static HashSet<PlayerWatch> _transmittingWalkieTalkies; //Field offset: 0x0
	[SerializeField]
	private WalkieTalkieSpeaker _speaker; //Field offset: 0x80
	[SerializeField]
	private AudioSource _soundOn; //Field offset: 0x88
	[SerializeField]
	private AudioSource _soundOff; //Field offset: 0x90
	[SerializeField]
	private PlayerWatchView _view; //Field offset: 0x98
	[DefaultForProperty("transmittingPlayerObjectID", 0, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private int _transmittingPlayerObjectID; //Field offset: 0xA0
	[DefaultForProperty("channel", 1, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private int _channel; //Field offset: 0xA4
	[DefaultForProperty("moneyAmount", 2, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private int _moneyAmount; //Field offset: 0xA8
	private int _moneyAmountCache; //Field offset: 0xAC
	[DefaultForProperty("display", 3, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private WatchDisplay _display; //Field offset: 0xB0
	private NetPlayer _player; //Field offset: 0xB8
	private ChangeDetector _changeDetector; //Field offset: 0xC0
	private NetPlayer _currentTransmittingPlayer; //Field offset: 0xC8
	private float _lastChangeTransmissionTime; //Field offset: 0xD0
	private bool _isLookingAtWatch; //Field offset: 0xD4
	private float _lastHitToggleTime; //Field offset: 0xD8

	[Networked]
	[NetworkedWeaved(1, 1)]
	[OnChangedRender("HandleChannelChanged")]
	public private int channel
	{
		 get { } //Length: 96
		private set { } //Length: 96
	}

	[Networked]
	[NetworkedWeaved(3, 1)]
	[OnChangedRender("HandleDisplayChanged")]
	public WatchDisplay display
	{
		 get { } //Length: 96
		 set { } //Length: 96
	}

	public bool IsMine
	{
		 get { } //Length: 136
	}

	public bool IsTransmitting
	{
		 get { } //Length: 24
	}

	[Networked]
	[NetworkedWeaved(2, 1)]
	[OnChangedRender("HandleMoneyChanged")]
	public int moneyAmount
	{
		 get { } //Length: 96
		 set { } //Length: 96
	}

	[Networked]
	[NetworkedWeaved(0, 1)]
	[OnChangedRender("HandleTransmittingChanged")]
	public private int transmittingPlayerObjectID
	{
		 get { } //Length: 96
		private set { } //Length: 96
	}

	private static PlayerWatch() { }

	public PlayerWatch() { }

	private void Awake() { }

	[WeaverGenerated]
	public virtual void CopyBackingFieldsToState(bool unnamed_param_0) { }

	[WeaverGenerated]
	public virtual void CopyStateToBackingFields() { }

	public virtual void Despawned(NetworkRunner runner, bool hasState) { }

	public int get_channel() { }

	public WatchDisplay get_display() { }

	public bool get_IsMine() { }

	public bool get_IsTransmitting() { }

	public int get_moneyAmount() { }

	public int get_transmittingPlayerObjectID() { }

	private void HandleChannelChanged() { }

	private void HandleDisplayChanged() { }

	private void HandleMoneyChanged() { }

	[ContextMenu("Switch Channel")]
	private void HandleSwitchChannelPressed() { }

	private void HandleTransmittingChanged() { }

	private void HandleUserWalletChanged(StateChangedEventArgs args) { }

	private bool IsRightHand(Collider collider) { }

	private void LateUpdate() { }

	private void OnDestroy() { }

	private void OnHealthChanged(int health) { }

	private void OnPlayerBackpackUpdated(bool equipped, float fillAmount) { }

	private void OnPlayerHeldWeightUpdated(float weight) { }

	public virtual void Render() { }

	[Rpc(RpcSources::InputAuthority (2), RpcTargets::StateAuthority (1))]
	public void RPC_SetTransmittingPlayer(int playerObjectID) { }

	[NetworkRpcWeavedInvoker(1, 2, 1)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_SetTransmittingPlayer@Invoker(NetworkBehaviour behaviour, SimulationMessage* message) { }

	private void set_channel(int value) { }

	public void set_display(WatchDisplay value) { }

	public void set_moneyAmount(int value) { }

	private void set_transmittingPlayerObjectID(int value) { }

	public virtual void Spawned() { }

	private void Start() { }

	private void ToggleDisplayChange() { }

}

