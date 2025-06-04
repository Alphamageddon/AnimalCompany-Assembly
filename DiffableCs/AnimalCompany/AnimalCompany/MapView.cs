namespace AnimalCompany;

public class MapView : MonoBehaviour
{
	private const float POS_MULTIPLIER = 2; //Field offset: 0x0
	[SerializeField]
	private MapIconView _playerIconPrefab; //Field offset: 0x20
	[SerializeField]
	private MapIconView _mobIconPrefab; //Field offset: 0x28
	[SerializeField]
	private MapIconView _lootIconPrefab; //Field offset: 0x30
	[SerializeField]
	private RectTransform _mapIconsRoot; //Field offset: 0x38
	[SerializeField]
	private Image _gridBackground; //Field offset: 0x40
	[SerializeField]
	private RectTransform _anchoredRoot; //Field offset: 0x48
	[SerializeField]
	private bool _useRelativeLocations; //Field offset: 0x50
	[SerializeField]
	private bool _useChannels; //Field offset: 0x51
	[SerializeField]
	private float _maxScanDistance; //Field offset: 0x54
	private MapIconView[] _playerIconPool; //Field offset: 0x58
	private MapIconView[] _mobIconPool; //Field offset: 0x60
	private MapIconView[] _lootIconPool; //Field offset: 0x68

	public MapView() { }

	private void Awake() { }

	private void DeactivateMapIcon(MapIconView icon) { }

	private void SetupLootIconPool() { }

	private void SetupMobIconPool() { }

	private void SetupPlayerIconPool() { }

	private void Update() { }

	public void UpdateLootLocations(IEnumerable<GrabbableItem> items, IEnumerable<Crate> crates) { }

	public void UpdateMobLocations(IEnumerable<MobController> mobs, IEnumerable<MobControllerMine> mines) { }

	public void UpdatePlayerLocations(IEnumerable<NetPlayer> players, int visiblePlayers) { }

}

