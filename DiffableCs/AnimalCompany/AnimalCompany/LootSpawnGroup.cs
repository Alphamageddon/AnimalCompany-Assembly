namespace AnimalCompany;

public class LootSpawnGroup : MonoBehaviour
{
	private static Dictionary<Int16, LootSpawnGroup> _spawnGroupLookup; //Field offset: 0x0
	public float valueToSpawn; //Field offset: 0x20
	public List<WeightedConnectionItemPoints> pointsWeightedByConnection; //Field offset: 0x28
	public int totalConnectionWeight; //Field offset: 0x30
	public List<WeightedItem> weightedItems; //Field offset: 0x38
	public float totalItemWeight; //Field offset: 0x40
	[SerializeField]
	private short _id; //Field offset: 0x44

	public short id
	{
		 get { } //Length: 8
	}

	private static LootSpawnGroup() { }

	public LootSpawnGroup() { }

	private void Awake() { }

	public short get_id() { }

	protected void OnValidate() { }

	public Item PickRandomItem() { }

	public static bool TryGetSpawnGroup(short id, out LootSpawnGroup spawnGroup) { }

}

