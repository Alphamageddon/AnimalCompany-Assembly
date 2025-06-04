namespace AnimalCompany;

[NetworkBehaviourWeaved(31)]
public class ItemSellingMachineController : NetworkBehaviour
{
	private const int BUTTON_COUNT = 11; //Field offset: 0x0
	private const float CAPSULE_HEIGHT = 5.6; //Field offset: 0x0
	private const float CAPSULE_RADIUS = 0.8; //Field offset: 0x0
	private static readonly Vector3 CAPSULE_POSITION; //Field offset: 0x0
	private const float TIME_TO_RECOVER_AFTER_EXPLOSION = 5; //Field offset: 0x0
	private const float HEAT_PER_BUTTON_PRESS = 0.7; //Field offset: 0x0
	private const float HEAT_PER_ANIMATION = 27.325; //Field offset: 0x0
	private const int MIN_ANIMATION_TO_EXPLOSION = 4; //Field offset: 0x0
	private const float HEAT_REDUCTION_PER_SECOND = 1; //Field offset: 0x0
	private const float HEAT_TO_EXPLOSION = 100; //Field offset: 0x0
	private const string HIT_NAME_SELLING = "ItemSellingMachine"; //Field offset: 0x0
	private const float ANIMATION_DELAY_MIN = 2; //Field offset: 0x0
	private const float ANIMATION_DURATION_OPEN_DOOR = 1; //Field offset: 0x0
	private const float ANIMATION_DURATION_LIGHT_EFFECT = 3; //Field offset: 0x0
	private const float ANIMATION_DURATION_CLOSE_DOOR = 0.3; //Field offset: 0x0
	private const float ANIMATION_DELAY_MAX = 5; //Field offset: 0x0
	private const float ANIMATION_TOTAL_DURATION = 4.3; //Field offset: 0x0
	private const float BUTTON_RESET_TIME = 5; //Field offset: 0x0
	private const float ANIMATION_DURATION_TO_SELL_ITEM = 1.8; //Field offset: 0x0
	[DefaultForProperty("isSellingInProgress", 0, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private bool _isSellingInProgress; //Field offset: 0x80
	[DefaultForProperty("isOverheated", 1, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private bool _isOverheated; //Field offset: 0x81
	[DefaultForProperty("isExploded", 2, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private bool _isExploded; //Field offset: 0x82
	[DefaultForProperty("itemSoldValue", 3, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private int _itemSoldValue; //Field offset: 0x84
	[DefaultForProperty("isButtonPressed", 4, 11)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private Boolean[] _isButtonPressed; //Field offset: 0x88
	[DefaultForProperty("_timerResetButton", 15, 11)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[WeaverGenerated]
	private TickTimer[] __timerResetButton; //Field offset: 0x90
	[DefaultForProperty("_timerAnimationFinished", 26, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[WeaverGenerated]
	private TickTimer __timerAnimationFinished; //Field offset: 0x98
	[DefaultForProperty("_timerItemSell", 27, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[WeaverGenerated]
	private TickTimer __timerItemSell; //Field offset: 0x9C
	[DefaultForProperty("_timerRecoverExplosion", 28, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[WeaverGenerated]
	private TickTimer __timerRecoverExplosion; //Field offset: 0xA0
	[DefaultForProperty("randomButtonId", 29, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private int _randomButtonId; //Field offset: 0xA4
	[DefaultForProperty("heatMeter", 30, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private float _heatMeter; //Field offset: 0xA8
	[Header("References")]
	[SerializeField]
	private ItemSellingMachineView _view; //Field offset: 0xB0
	[SerializeField]
	private ItemSellingMachineButtonView[] _buttonViewsGroup0; //Field offset: 0xB8
	[SerializeField]
	private RandomSFX[] _keyPressSFXs; //Field offset: 0xC0
	[Header("Explosion")]
	[SerializeField]
	private Transform _explosionRoot; //Field offset: 0xC8
	[SerializeField]
	private Explosion _explosionPrefab; //Field offset: 0xD0
	[SerializeField]
	private RandomSFX _SFXoverheat; //Field offset: 0xD8
	[SerializeField]
	private RandomSFX _SFXexplosion; //Field offset: 0xE0
	private HashSet<GrabbableItem> _itemsInMachine; //Field offset: 0xE8
	private bool _isAfterSpawned; //Field offset: 0xF0

	private Vector3 _capsulePoint0
	{
		private get { } //Length: 256
	}

	private Vector3 _capsulePoint1
	{
		private get { } //Length: 256
	}

	[Networked]
	[NetworkedWeaved(26, 1)]
	private TickTimer _timerAnimationFinished
	{
		private get { } //Length: 96
		private set { } //Length: 96
	}

	[Networked]
	[NetworkedWeaved(27, 1)]
	private TickTimer _timerItemSell
	{
		private get { } //Length: 96
		private set { } //Length: 96
	}

	[Networked]
	[NetworkedWeaved(28, 1)]
	private TickTimer _timerRecoverExplosion
	{
		private get { } //Length: 96
		private set { } //Length: 96
	}

	[Capacity(11)]
	[Networked]
	[NetworkedWeaved(15, 11)]
	private NetworkArray<TickTimer> _timerResetButton
	{
		private get { } //Length: 184
	}

	[Networked]
	[NetworkedWeaved(30, 1)]
	public private float heatMeter
	{
		 get { } //Length: 96
		private set { } //Length: 96
	}

	[Capacity(11)]
	[Networked]
	[NetworkedWeaved(4, 11)]
	[OnChangedRender("OnButtonStateChanged")]
	public NetworkArray<Boolean> isButtonPressed
	{
		 get { } //Length: 184
	}

	[Networked]
	[NetworkedWeaved(2, 1)]
	[OnChangedRender("HandleIsExploded")]
	public private bool isExploded
	{
		 get { } //Length: 104
		private set { } //Length: 100
	}

	[Networked]
	[NetworkedWeaved(1, 1)]
	[OnChangedRender("HandleIsOverheated")]
	public private bool isOverheated
	{
		 get { } //Length: 104
		private set { } //Length: 100
	}

	[Networked]
	[NetworkedWeaved(0, 1)]
	public private bool isSellingInProgress
	{
		 get { } //Length: 104
		private set { } //Length: 100
	}

	[Networked]
	[NetworkedWeaved(3, 1)]
	public private int itemSoldValue
	{
		 get { } //Length: 96
		private set { } //Length: 96
	}

	[Networked]
	[NetworkedWeaved(29, 1)]
	public private int randomButtonId
	{
		 get { } //Length: 96
		private set { } //Length: 96
	}

	private static ItemSellingMachineController() { }

	public ItemSellingMachineController() { }

	[WeaverGenerated]
	public virtual void CopyBackingFieldsToState(bool unnamed_param_0) { }

	[WeaverGenerated]
	public virtual void CopyStateToBackingFields() { }

	public virtual void Despawned(NetworkRunner runner, bool hasState) { }

	private void DespawnItemsKillPlayersAndStoreValues() { }

	public virtual void FixedUpdateNetwork() { }

	private Vector3 get__capsulePoint0() { }

	private Vector3 get__capsulePoint1() { }

	private TickTimer get__timerAnimationFinished() { }

	private TickTimer get__timerItemSell() { }

	private TickTimer get__timerRecoverExplosion() { }

	private NetworkArray<TickTimer> get__timerResetButton() { }

	public float get_heatMeter() { }

	public NetworkArray<Boolean> get_isButtonPressed() { }

	public bool get_isExploded() { }

	public bool get_isOverheated() { }

	public bool get_isSellingInProgress() { }

	public int get_itemSoldValue() { }

	public int get_randomButtonId() { }

	private void HandleIsExploded() { }

	private void HandleIsOverheated() { }

	private void OnButtonStateChanged() { }

	private void OnDrawGizmos() { }

	private void OnItemSellingAnimationFinished() { }

	private void ResetButtonsState() { }

	[Rpc(RpcSources::All (7), RpcTargets::All (7))]
	private void RPC_AddPlayerMoneyToAll(int amount) { }

	[NetworkRpcWeavedInvoker(4, 7, 7)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_AddPlayerMoneyToAll@Invoker(NetworkBehaviour behaviour, SimulationMessage* message) { }

	[Rpc(RpcSources::All (7), RpcTargets::All (7))]
	public void RPC_ButtonPressed(int buttonId) { }

	[NetworkRpcWeavedInvoker(5, 7, 7)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_ButtonPressed@Invoker(NetworkBehaviour behaviour, SimulationMessage* message) { }

	[Rpc(RpcSources::All (7), RpcTargets::All (7))]
	private void RPC_ExplodeMachine() { }

	[NetworkRpcWeavedInvoker(2, 7, 7)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_ExplodeMachine@Invoker(NetworkBehaviour behaviour, SimulationMessage* message) { }

	[Rpc(RpcSources::All (7), RpcTargets::All (7))]
	private void RPC_RecoverExplosion() { }

	[NetworkRpcWeavedInvoker(3, 7, 7)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_RecoverExplosion@Invoker(NetworkBehaviour behaviour, SimulationMessage* message) { }

	[Rpc(RpcSources::All (7), RpcTargets::All (7))]
	private void RPC_StartItemSelling(float randomWaitTime) { }

	[NetworkRpcWeavedInvoker(1, 7, 7)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_StartItemSelling@Invoker(NetworkBehaviour behaviour, SimulationMessage* message) { }

	private int SellItem(GrabbableItem grabbableItem) { }

	private void set__timerAnimationFinished(TickTimer value) { }

	private void set__timerItemSell(TickTimer value) { }

	private void set__timerRecoverExplosion(TickTimer value) { }

	private void set_heatMeter(float value) { }

	private void set_isExploded(bool value) { }

	private void set_isOverheated(bool value) { }

	private void set_isSellingInProgress(bool value) { }

	private void set_itemSoldValue(int value) { }

	private void set_randomButtonId(int value) { }

	public override void Setup() { }

	public virtual void Spawned() { }

}

