namespace AnimalCompany;

[NetworkBehaviourWeaved(22)]
[RequireComponent(typeof(Rigidbody))]
public class GrabbableItem : NetworkBehaviour, IStateAuthorityChanged, IInterestEnter, IInterestExit
{
	internal struct ItemContactPoint
	{
		public Vector3 localPosition; //Field offset: 0x0
		public Vector3 prevWorldPosition; //Field offset: 0xC

	}

	internal enum TimeoutAction
	{
		None = 0,
		Respawn = 1,
		Destroy = 2,
	}

	private const float RESPAWN_TIME = 300; //Field offset: 0x0
	private const float MAX_MOVE_SPEED = 5; //Field offset: 0x0
	private const float MAX_MOVE_SPEED_SQR = 25; //Field offset: 0x0
	private static HashSet<GrabbableItem> _lootItems; //Field offset: 0x0
	private const float AUTO_DESTROY_TIME = 300; //Field offset: 0x0
	[SerializeField]
	private ItemData _itemData; //Field offset: 0x80
	[SerializeField]
	private bool _detectCollisionWhileGrabbed; //Field offset: 0x88
	[SerializeField]
	private bool _affectMovementWhileGrabbed; //Field offset: 0x89
	[SerializeField]
	private bool _useGravity; //Field offset: 0x8A
	[SerializeField]
	private bool _allowGrabAnywhere; //Field offset: 0x8B
	[SerializeField]
	private bool _allowAttachToBack; //Field offset: 0x8C
	[SerializeField]
	private bool _allowAddToBag; //Field offset: 0x8D
	[SerializeField]
	private bool _allowAttachToItem; //Field offset: 0x8E
	[SerializeField]
	private Transform _bottomAttachTransform; //Field offset: 0x90
	[SerializeField]
	private Transform _backAttachTransform; //Field offset: 0x98
	[SerializeField]
	private Transform _grabTransformLeft; //Field offset: 0xA0
	[SerializeField]
	private Transform _grabTransformRight; //Field offset: 0xA8
	[SerializeField]
	private Transform _stickTransform; //Field offset: 0xB0
	[SerializeField]
	private float _collisionDamageMultiplier; //Field offset: 0xB8
	[SerializeField]
	private FingerUsage _lockedFingerUsage; //Field offset: 0xBC
	[SerializeField]
	private bool _allowGrabWhenStuck; //Field offset: 0xC0
	[Header("References")]
	[SerializeField]
	private Transform _viewRoot; //Field offset: 0xC8
	[SerializeField]
	private Transform _rootOffset; //Field offset: 0xD0
	[Header("SFX")]
	[SerializeField]
	private RandomSFX _SFXgrab; //Field offset: 0xD8
	[SerializeField]
	private RandomSFX _SFXrelease; //Field offset: 0xE0
	[SerializeField]
	private RandomSFX _SFXequip; //Field offset: 0xE8
	[DefaultForProperty("attachedAnchorId", 0, 2)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private NetworkBehaviourId _attachedAnchorId; //Field offset: 0xF0
	[DefaultForProperty("backpackId", 2, 2)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private NetworkBehaviourId _backpackId; //Field offset: 0xF8
	[DefaultForProperty("grabbedInfo", 4, 7)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private GrabbedInfo _grabbedInfo; //Field offset: 0x100
	[DefaultForProperty("isHidden", 11, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private bool _isHidden; //Field offset: 0x11C
	[DefaultForProperty("stuckAnchorId", 12, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private NetworkId _stuckAnchorId; //Field offset: 0x120
	[DefaultForProperty("spawnInfo", 13, 8)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private SpawnInfo _spawnInfo; //Field offset: 0x124
	[DefaultForProperty("respawnTimer", 21, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private TickTimer _respawnTimer; //Field offset: 0x144
	[CompilerGenerated]
	private bool <wasPurchased>k__BackingField; //Field offset: 0x148
	private AttachedItemAnchor _cachedAnchor; //Field offset: 0x150
	private HandInteractor _cachedInteractor; //Field offset: 0x158
	private InventoryBag _cachedBackpack; //Field offset: 0x160
	private Rigidbody _rigidbody; //Field offset: 0x168
	private NetworkRigidbody3D _netRigidbody; //Field offset: 0x170
	private Transform _followTransform; //Field offset: 0x178
	private bool _isCollidingEnv; //Field offset: 0x180
	private Vector3 _addedExternalVelocity; //Field offset: 0x184
	private float _lastCollisionEnterTime; //Field offset: 0x190
	private Vector3 _desiredPosition; //Field offset: 0x194
	private AttachedItemAnchor _localNonAuthedInteractor; //Field offset: 0x1A0
	private Transform _stuckAnchorTransform; //Field offset: 0x1A8
	private StickyAnchor _stuckAnchor; //Field offset: 0x1B0
	private bool _updateVisibilityNextUpdate; //Field offset: 0x1B8
	private bool _updatePlayersAlwaysInterestedNextUpdate; //Field offset: 0x1B9
	private bool _updateStateAuthorityCheckNextUpdate; //Field offset: 0x1BA
	public Action onPreGrabbedChanged; //Field offset: 0x1C0
	public Action onGrabbedChanged; //Field offset: 0x1C8
	public Action onUse; //Field offset: 0x1D0
	public Action onTriggerUse; //Field offset: 0x1D8
	public Action onRespawned; //Field offset: 0x1E0
	public Action onInBackpackChanged; //Field offset: 0x1E8
	public Action<NetworkRunner> onDespawned; //Field offset: 0x1F0
	public Action onDroppedFromDeath; //Field offset: 0x1F8
	public Action onUpdatedView; //Field offset: 0x200
	public Action onUpdatedVisibility; //Field offset: 0x208
	public Action<Transform> onStuckAnchorChanged; //Field offset: 0x210
	public Action<Vector3> onReleased; //Field offset: 0x218
	public Action onMovementUpdate; //Field offset: 0x220
	private ItemContactPoint[] _contactPoints; //Field offset: 0x228
	private int _numContactPoints; //Field offset: 0x230
	private Vector3 _avgContactPoint; //Field offset: 0x234
	private Vector3 _avgContactPointLocal; //Field offset: 0x240
	private readonly Vector3 GRAB_POS_OFFSET_RIGHT; //Field offset: 0x24C
	private readonly Vector3 GRAB_POS_OFFSET_LEFT; //Field offset: 0x258
	private float _lastCollisionDmgTime; //Field offset: 0x264

	private TimeoutAction _salesAction
	{
		private get { } //Length: 40
	}

	private TimeoutAction _timeoutAction
	{
		private get { } //Length: 28
	}

	public static IEnumerable<GrabbableItem> allLootItems
	{
		 get { } //Length: 88
	}

	public bool allowAddToBag
	{
		 get { } //Length: 48
	}

	public bool allowAttachToBack
	{
		 get { } //Length: 8
	}

	public bool allowAttachToItem
	{
		 get { } //Length: 48
	}

	[Networked]
	[NetworkedWeaved(0, 2)]
	[OnChangedRender("HandleGrabbedChanged")]
	public NetworkBehaviourId attachedAnchorId
	{
		 get { } //Length: 96
		 set { } //Length: 96
	}

	[Networked]
	[NetworkedWeaved(2, 2)]
	[OnChangedRender("HandleBackpackIdChanged")]
	public NetworkBehaviourId backpackId
	{
		 get { } //Length: 96
		 set { } //Length: 96
	}

	public bool canGrab
	{
		 get { } //Length: 60
	}

	public Transform followTransform
	{
		 get { } //Length: 8
	}

	[Networked]
	[NetworkedWeaved(4, 7)]
	[OnChangedRender("HandleGrabbedInfoChanged")]
	public GrabbedInfo grabbedInfo
	{
		 get { } //Length: 108
		 set { } //Length: 116
	}

	public bool isAttached
	{
		 get { } //Length: 168
	}

	public bool isCollidingEnvironment
	{
		 get { } //Length: 8
	}

	[Networked]
	[NetworkedWeaved(11, 1)]
	[OnChangedRender("HandleIsHiddenChanged")]
	public bool isHidden
	{
		 get { } //Length: 104
		 set { } //Length: 100
	}

	public bool isInterested
	{
		 get { } //Length: 8
	}

	public bool isStuck
	{
		 get { } //Length: 152
	}

	public bool isVisible
	{
		 get { } //Length: 84
	}

	public AttachedItemAnchor itemAnchor
	{
		 get { } //Length: 8
	}

	public ItemData itemData
	{
		 get { } //Length: 8
	}

	public Rigidbody itemRigidbody
	{
		 get { } //Length: 8
	}

	public FingerUsage lockedFingerUsage
	{
		 get { } //Length: 8
	}

	public bool netObjectExists
	{
		 get { } //Length: 140
	}

	[Networked]
	[NetworkedWeaved(21, 1)]
	public TickTimer respawnTimer
	{
		 get { } //Length: 96
		 set { } //Length: 96
	}

	[Networked]
	[NetworkedWeaved(13, 8)]
	public SpawnInfo spawnInfo
	{
		 get { } //Length: 104
		 set { } //Length: 104
	}

	public Transform stickTransform
	{
		 get { } //Length: 8
	}

	[Networked]
	[NetworkedWeaved(12, 1)]
	[OnChangedRender("HandleStuckAnchorIdChanged")]
	public NetworkId stuckAnchorId
	{
		 get { } //Length: 96
		 set { } //Length: 96
	}

	public Transform stuckAnchorTransform
	{
		 get { } //Length: 8
	}

	public bool wasPurchased
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	private static GrabbableItem() { }

	public GrabbableItem() { }

	public void AddExternalForce(Vector3 force) { }

	public void AddToBag(NetworkBehaviourId bagId) { }

	private void ApplyCollisionDamage(GameObject target, Vector3 velocity) { }

	private void ApplyGrabMovement(Vector3 position, Quaternion rotation) { }

	private void Awake() { }

	private void CheckToAssumeStateAuthority(bool requireMasterClient = true) { }

	[WeaverGenerated]
	public virtual void CopyBackingFieldsToState(bool unnamed_param_0) { }

	[WeaverGenerated]
	public virtual void CopyStateToBackingFields() { }

	public void Despawn() { }

	public virtual void Despawned(NetworkRunner runner, bool hasState) { }

	private void FixedUpdate() { }

	public virtual void FixedUpdateNetwork() { }

	private TimeoutAction get__salesAction() { }

	private TimeoutAction get__timeoutAction() { }

	public static IEnumerable<GrabbableItem> get_allLootItems() { }

	public bool get_allowAddToBag() { }

	public bool get_allowAttachToBack() { }

	public bool get_allowAttachToItem() { }

	public NetworkBehaviourId get_attachedAnchorId() { }

	public NetworkBehaviourId get_backpackId() { }

	public bool get_canGrab() { }

	public Transform get_followTransform() { }

	public GrabbedInfo get_grabbedInfo() { }

	public bool get_isAttached() { }

	public bool get_isCollidingEnvironment() { }

	public bool get_isHidden() { }

	public bool get_isInterested() { }

	public bool get_isStuck() { }

	public bool get_isVisible() { }

	public AttachedItemAnchor get_itemAnchor() { }

	public ItemData get_itemData() { }

	public Rigidbody get_itemRigidbody() { }

	public FingerUsage get_lockedFingerUsage() { }

	public bool get_netObjectExists() { }

	public TickTimer get_respawnTimer() { }

	public SpawnInfo get_spawnInfo() { }

	public Transform get_stickTransform() { }

	public NetworkId get_stuckAnchorId() { }

	public Transform get_stuckAnchorTransform() { }

	[CompilerGenerated]
	public bool get_wasPurchased() { }

	private TimeoutAction GetSalesAction(Type type) { }

	private TimeoutAction GetTimeoutAction(Type type) { }

	public void Grab(AttachedItemAnchor interactor, bool playSFX = true) { }

	private void GrabInternal(NetworkBehaviourId interactorId, bool playSFX = true) { }

	public void HandleAttachedAnchorDespawned(NetworkBehaviourId anchorId) { }

	public void HandleBackpackIdChanged() { }

	public void HandleGrabbedChanged() { }

	public void HandleGrabbedInfoChanged() { }

	public void HandleIsHiddenChanged() { }

	private void HandleMasterClientSwitched(PlayerRef player) { }

	public void HandlePlayerLeft(PlayerRef player) { }

	private void HandleStuckAnchorIdChanged() { }

	private void HandleTriggerUse() { }

	private void HandleUse() { }

	private void InitSpawn() { }

	public override void InterestEnter(PlayerRef player) { }

	public override void InterestExit(PlayerRef player) { }

	private bool IsContainsType(Type type, Type containedType) { }

	private void LateUpdate() { }

	private void OnCollisionEnter(Collision collisionInfo) { }

	private void OnCollisionStay(Collision collisionInfo) { }

	private void OnDestroy() { }

	private void OnStuckAnchorDespawned(StickyAnchor stickyAnchor) { }

	private void OnTriggerEnter(Collider other) { }

	public void Release(Vector3 position, Quaternion rotation, Vector3 velocity, Vector3 angularVelocity, bool playSFX = true, bool fromDeath = false) { }

	public void Release(AttachedItemAnchor interactor, Vector3 position, Quaternion rotation, Vector3 velocity, Vector3 angularVelocity, bool playSFX = true, bool fromDeath = false) { }

	private void ReleaseInternal(NetworkBehaviourId interactorId, Vector3 position, Quaternion rotation, Vector3 velocity, Vector3 angularVelocity, bool playSFX = true, bool fromDeath = false) { }

	public void RemoveFromBag(Vector3 position) { }

	public virtual void Render() { }

	public void ResetStuckAnchor() { }

	public void Respawn() { }

	private void RespawnInternally() { }

	public void RespawnOrDespawn() { }

	[Rpc(RpcSources::All (7), RpcTargets::StateAuthority (1))]
	public void RPC_AddToBag(NetworkBehaviourId backpackId) { }

	[NetworkRpcWeavedInvoker(4, 7, 1)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_AddToBag@Invoker(NetworkBehaviour behaviour, SimulationMessage* message) { }

	[Rpc(RpcSources::All (7), RpcTargets::StateAuthority (1))]
	public void RPC_HandleItemSold() { }

	[NetworkRpcWeavedInvoker(7, 7, 1)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_HandleItemSold@Invoker(NetworkBehaviour behaviour, SimulationMessage* message) { }

	[Rpc(RpcSources::All (7), RpcTargets::StateAuthority (1))]
	public void RPC_Release(NetworkBehaviourId interactorId, Vector3 position, Quaternion rotation, Vector3 velocity, Vector3 angularVelocity, bool playSFX = true, bool fromDeath = false) { }

	[NetworkRpcWeavedInvoker(2, 7, 1)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_Release@Invoker(NetworkBehaviour behaviour, SimulationMessage* message) { }

	[Rpc(RpcSources::All (7), RpcTargets::StateAuthority (1))]
	public void RPC_RemoveFromBag(Vector3 position) { }

	[NetworkRpcWeavedInvoker(5, 7, 1)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_RemoveFromBag@Invoker(NetworkBehaviour behaviour, SimulationMessage* message) { }

	[Rpc(RpcSources::All (7), RpcTargets::StateAuthority (1))]
	public void RPC_Respawn() { }

	[NetworkRpcWeavedInvoker(6, 7, 1)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_Respawn@Invoker(NetworkBehaviour behaviour, SimulationMessage* message) { }

	[Rpc(RpcSources::All (7), RpcTargets::StateAuthority (1))]
	public void RPC_SetGrabbedOffsets(GrabbedInfo gInfo) { }

	[NetworkRpcWeavedInvoker(3, 7, 1)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_SetGrabbedOffsets@Invoker(NetworkBehaviour behaviour, SimulationMessage* message) { }

	[Rpc(RpcSources::All (7), RpcTargets::StateAuthority (1))]
	public void RPC_Teleport(Vector3 position) { }

	[NetworkRpcWeavedInvoker(8, 7, 1)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_Teleport@Invoker(NetworkBehaviour behaviour, SimulationMessage* message) { }

	[Rpc(RpcSources::All (7), RpcTargets::StateAuthority (1))]
	public void RPC_TryGrab(NetworkBehaviourId interactorId, bool playSFX = true, RpcInfo info = null) { }

	[NetworkRpcWeavedInvoker(1, 7, 1)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_TryGrab@Invoker(NetworkBehaviour behaviour, SimulationMessage* message) { }

	public void set_attachedAnchorId(NetworkBehaviourId value) { }

	public void set_backpackId(NetworkBehaviourId value) { }

	public void set_grabbedInfo(GrabbedInfo value) { }

	public void set_isHidden(bool value) { }

	public void set_respawnTimer(TickTimer value) { }

	public void set_spawnInfo(SpawnInfo value) { }

	public void set_stuckAnchorId(NetworkId value) { }

	[CompilerGenerated]
	public void set_wasPurchased(bool value) { }

	public void SetBackAttach(Transform backAttach) { }

	public void SetIsHidden(bool hide) { }

	public void SetStuckAnchorId(NetworkId networkId, bool release = false) { }

	public void SnapToFollow() { }

	public virtual void Spawned() { }

	public void StartTimeoutTimer() { }

	public void StartTimeoutTimer(TimeoutAction action, float time) { }

	public override void StateAuthorityChanged() { }

	[ContextMenu("Test Throw")]
	private void TestThrow() { }

	[ContextMenu("Test Trigger Use")]
	private void TestTriggerUse() { }

	[ContextMenu("Test Use")]
	private void TestUse() { }

	public bool TryGetHandSide(out HandSide handSide) { }

	private void Update() { }

	private void UpdateContactPoints(Collision collisionInfo) { }

	private void UpdateDetectCollisions() { }

	private void UpdateFollowTransform() { }

	private void UpdateIsFrozen() { }

	public void UpdateIsVisible(bool applyOnNextUpdate = true) { }

	private void UpdateLayer() { }

	private void UpdateLayerRecursively(GameObject go, int layer) { }

	private void UpdatePlayersAlwaysInterested() { }

	private void UpdateTransformFromStuckAnchor() { }

	private void UpdateUseGravity() { }

	private void UpdateVelocities(float dt) { }

	public void UpdateViewTransform() { }

}

