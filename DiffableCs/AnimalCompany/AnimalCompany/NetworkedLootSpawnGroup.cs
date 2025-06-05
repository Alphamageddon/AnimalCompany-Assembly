namespace AnimalCompany;

[NetworkBehaviourWeaved(194)]
public class NetworkedLootSpawnGroup : NetworkBehaviour
{
	private const int CAPACITY = 64; //Field offset: 0x0
	private const int RECHECK_SPAWN_TIME = 180; //Field offset: 0x0
	[DefaultForProperty("_groupID", 0, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[WeaverGenerated]
	private short __groupID; //Field offset: 0x80
	[DefaultForProperty("_spawnedLoot", 1, 192)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[WeaverGenerated]
	private SpawnedLoot[] __spawnedLoot; //Field offset: 0x88
	[DefaultForProperty("_respawnTimer", 193, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[WeaverGenerated]
	private TickTimer __respawnTimer; //Field offset: 0x90
	private HashSet<ValueTuple`2<Byte, Byte>> _usedItemPoints; //Field offset: 0x98
	private List<List`1<Byte>> _availableItemPoints; //Field offset: 0xA0
	[SerializeField]
	private LootSpawnGroup _lootSpawnGroup; //Field offset: 0xA8

	[Networked]
	[NetworkedWeaved(0, 1)]
	private short _groupID
	{
		private get { } //Length: 96
		private set { } //Length: 96
	}

	[Networked]
	[NetworkedWeaved(193, 1)]
	private TickTimer _respawnTimer
	{
		private get { } //Length: 96
		private set { } //Length: 96
	}

	[Capacity(64)]
	[Networked]
	[NetworkedWeaved(1, 192)]
	private NetworkArray<SpawnedLoot> _spawnedLoot
	{
		private get { } //Length: 184
	}

	public NetworkedLootSpawnGroup() { }

	private void CheckAndSpawnLoot() { }

	[WeaverGenerated]
	public virtual void CopyBackingFieldsToState(bool unnamed_param_0) { }

	[WeaverGenerated]
	public virtual void CopyStateToBackingFields() { }

	public virtual void FixedUpdateNetwork() { }

	private short get__groupID() { }

	private TickTimer get__respawnTimer() { }

	private NetworkArray<SpawnedLoot> get__spawnedLoot() { }

	private Item PickRandomItem() { }

	private void ResetAvailableItemPoints() { }

	private void set__groupID(short value) { }

	private void set__respawnTimer(TickTimer value) { }

	public void SetGroupID(short id) { }

	public virtual void Spawned() { }

}

