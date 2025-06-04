namespace AnimalCompany;

[NetworkBehaviourWeaved(12)]
public class InventoryBag : NetworkBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass26_0
	{
		public InventoryBag <>4__this; //Field offset: 0x10
		public float endVal; //Field offset: 0x18

		public <>c__DisplayClass26_0() { }

		internal void <AnimateOpenClose>b__0(float val) { }

		internal void <AnimateOpenClose>b__1() { }

	}

	private const int CAPACITY = 10; //Field offset: 0x0
	private const float DEFAULT_MASS = 5; //Field offset: 0x0
	[SerializeField]
	private GrabbableItem _grabbable; //Field offset: 0x80
	[SerializeField]
	private GameObject _openedTempView; //Field offset: 0x88
	[SerializeField]
	private Transform _entranceTransform; //Field offset: 0x90
	[SerializeField]
	private Transform _lidRootTransform; //Field offset: 0x98
	[SerializeField]
	private RandomSFX _openSFX; //Field offset: 0xA0
	[DefaultForProperty("isOpen", 0, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private bool _isOpen; //Field offset: 0xA8
	[DefaultForProperty("containedObjects", 1, 10)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[WeaverGenerated]
	private NetworkId[] _containedObjects; //Field offset: 0xB0
	[DefaultForProperty("emptyingTimer", 11, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[WeaverGenerated]
	private TickTimer _emptyingTimer; //Field offset: 0xB8
	private int _tweenID; //Field offset: 0xBC

	[Capacity(10)]
	[Networked]
	[NetworkedWeaved(1, 10)]
	[OnChangedRender("HandleContainedObjectsChanged")]
	private NetworkArray<NetworkId> containedObjects
	{
		private get { } //Length: 184
	}

	[Networked]
	[NetworkedWeaved(11, 1)]
	private TickTimer emptyingTimer
	{
		private get { } //Length: 96
		private set { } //Length: 96
	}

	[Networked]
	[NetworkedWeaved(0, 1)]
	[OnChangedRender("HandleIsOpenChanged")]
	public bool isOpen
	{
		 get { } //Length: 104
		 set { } //Length: 100
	}

	public InventoryBag() { }

	private void AnimateOpenClose() { }

	private void Awake() { }

	private void CheckToAddItem() { }

	private bool CheckToEmptyItem() { }

	[WeaverGenerated]
	public virtual void CopyBackingFieldsToState(bool unnamed_param_0) { }

	[WeaverGenerated]
	public virtual void CopyStateToBackingFields() { }

	public virtual void Despawned(NetworkRunner runner, bool hasState) { }

	public void EmptyContents() { }

	public void Explode() { }

	public virtual void FixedUpdateNetwork() { }

	private NetworkArray<NetworkId> get_containedObjects() { }

	private TickTimer get_emptyingTimer() { }

	public bool get_isOpen() { }

	public List<GrabbableItem> GetContainedItems() { }

	public float GetFilledAmount() { }

	private void HandleContainedObjectsChanged() { }

	private void HandleIsOpenChanged() { }

	private void HandleToggleUse() { }

	private void OnDestroy() { }

	private void RespawnOrDespawnContainedObjects() { }

	[Rpc(RpcSources::All (7), RpcTargets::StateAuthority (1))]
	public void RPC_ToggleOnOff() { }

	[NetworkRpcWeavedInvoker(1, 7, 1)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_ToggleOnOff@Invoker(NetworkBehaviour behaviour, SimulationMessage* message) { }

	private void set_emptyingTimer(TickTimer value) { }

	public void set_isOpen(bool value) { }

	public virtual void Spawned() { }

	private void UpdateMass(float mass) { }

}

