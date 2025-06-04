namespace AnimalCompany;

[NetworkBehaviourWeaved(2)]
public class AttachedItemAnchor : NetworkBehaviour
{
	public static Action<NetworkBehaviourId> onDespawned; //Field offset: 0x0
	public AttachedLocation location; //Field offset: 0x80
	[SerializeField]
	private bool _affectMovementWhileAttached; //Field offset: 0x84
	[DefaultForProperty("grabbedItem", 0, 2)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private NetworkBehaviourId _grabbedItem; //Field offset: 0x88
	public Action<AttachedLocation, GrabbableItem> onGrabChanged; //Field offset: 0x90
	public Action<AttachedLocation, Collision, Vector3> onItemCollision; //Field offset: 0x98
	public Action<AttachedLocation, GrabbableItem> onGrabbedItemMassChanged; //Field offset: 0xA0
	private Vector3 _currVelocity; //Field offset: 0xA8
	private Vector3 _lastPosition; //Field offset: 0xB4
	private GrabbableItem _cachedGrabbedItem; //Field offset: 0xC0
	private GrabbableItem _rootGrabbableItem; //Field offset: 0xC8

	public bool affectMovementWhileAttached
	{
		 get { } //Length: 8
	}

	public GrabbableItem grabbableItem
	{
		 get { } //Length: 8
	}

	[Networked]
	[NetworkedWeaved(0, 2)]
	[OnChangedRender("HandleGrabbedItemChanged")]
	public NetworkBehaviourId grabbedItem
	{
		 get { } //Length: 96
		 set { } //Length: 96
	}

	public bool isHand
	{
		 get { } //Length: 16
	}

	public GrabbableItem rootGrabbable
	{
		 get { } //Length: 8
	}

	public Vector3 velocity
	{
		 get { } //Length: 12
	}

	public AttachedItemAnchor() { }

	private void Awake() { }

	[WeaverGenerated]
	public virtual void CopyBackingFieldsToState(bool unnamed_param_0) { }

	[WeaverGenerated]
	public virtual void CopyStateToBackingFields() { }

	public virtual void Despawned(NetworkRunner runner, bool hasState) { }

	public void DropItemIfHolding(bool fromDeath = true) { }

	public void DropWithThrowVelocity(Vector3 throwVelocity, bool fromDeath = false) { }

	public bool get_affectMovementWhileAttached() { }

	public GrabbableItem get_grabbableItem() { }

	public NetworkBehaviourId get_grabbedItem() { }

	public bool get_isHand() { }

	public GrabbableItem get_rootGrabbable() { }

	public Vector3 get_velocity() { }

	private void HandleDrop(NetworkBehaviourId objectID, Vector3 position, Quaternion rotation, Vector3 velocity, Vector3 angularVelocity, bool fromDeath) { }

	private void HandleGrabbedItemChanged() { }

	private void HandleItemDespawned(NetworkRunner runner) { }

	private void HandleItemGrabChanged() { }

	private void HandleRootItemViewUpdated() { }

	private void HandleRootItemVisibleUpdated() { }

	public void ItemCollision(Collision collision, Vector3 velocity) { }

	private void OnDestroy() { }

	public void RepositionItemIfHolding() { }

	private void ResetGrabbedItem() { }

	[Rpc(3, RpcTargets::StateAuthority (1))]
	public void RPC_DropItem(NetworkBehaviourId objectID, Vector3 position, Quaternion rotation, Vector3 itemVelocity, Vector3 itemAngularVelocity, bool fromDeath, RpcInfo info = null) { }

	[NetworkRpcWeavedInvoker(2, 3, 1)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_DropItem@Invoker(NetworkBehaviour behaviour, SimulationMessage* message) { }

	[Rpc(3, RpcTargets::StateAuthority (1))]
	public void RPC_TryGrabItem(NetworkBehaviourId objectID, bool forceAssign = false, bool playSFX = true, RpcInfo info = null) { }

	[NetworkRpcWeavedInvoker(1, 3, 1)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_TryGrabItem@Invoker(NetworkBehaviour behaviour, SimulationMessage* message) { }

	[Rpc(3, RpcTargets::StateAuthority (1))]
	public void RPC_UnattachItem() { }

	[NetworkRpcWeavedInvoker(3, 3, 1)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_UnattachItem@Invoker(NetworkBehaviour behaviour, SimulationMessage* message) { }

	public void set_grabbedItem(NetworkBehaviourId value) { }

	public virtual void Spawned() { }

	private void Start() { }

	public void UnattachItem() { }

	private void Update() { }

	public void UpdatedItemMass() { }

}

