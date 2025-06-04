namespace AnimalCompany;

public class ItemVendingMachine : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static OnBeforeSpawned <>9__28_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <TryToBuy>b__28_0(NetworkRunner runner, NetworkObject obj) { }

	}

	private const int ITEM_BUY_TIME_LIMIT = 60; //Field offset: 0x0
	private const float PREVIEW_ROTATE_SPEED = 25; //Field offset: 0x0
	private static int _updateLimitFrame; //Field offset: 0x0
	private const int ITEM_BUY_COUNT_LIMIT = 10; //Field offset: 0x0
	private static int _numItemsBoughtRecently; //Field offset: 0x4
	private static Nullable<Single> _lastItemLimitCheckTime; //Field offset: 0x8
	[SerializeField]
	private List<ItemData> _items; //Field offset: 0x20
	[SerializeField]
	private List<ItemData> _devItems; //Field offset: 0x28
	[SerializeField]
	private TextMeshProUGUI _priceText; //Field offset: 0x30
	[SerializeField]
	private Image _currencyIcon; //Field offset: 0x38
	[SerializeField]
	private Transform _previewRoot; //Field offset: 0x40
	[SerializeField]
	private RandomSFX _successSFX; //Field offset: 0x48
	[SerializeField]
	private RandomSFX _errorSFX; //Field offset: 0x50
	private TerminalKeyInputListener _keyInputListener; //Field offset: 0x58
	private Dictionary<ItemData, GameObject> _previews; //Field offset: 0x60
	private int _currItemIndex; //Field offset: 0x68
	private int _tweenID; //Field offset: 0x6C
	private bool _addedDevItems; //Field offset: 0x70

	private static bool IsPurchaseLimited
	{
		private get { } //Length: 108
	}

	public ItemVendingMachine() { }

	[CompilerGenerated]
	private void <AnimateNotEnoughMoney>b__31_0(float val) { }

	[CompilerGenerated]
	private void <AnimateNotEnoughMoney>b__31_1() { }

	[CompilerGenerated]
	private bool <HandleUserIsDeveloperChanged>b__22_0(ItemData item) { }

	private void AnimateNotEnoughMoney() { }

	private void Awake() { }

	private static bool get_IsPurchaseLimited() { }

	private GameObject GetPreviewGameObject(ItemData itemData) { }

	private void HandleKeyInput(KeyCode keyCode, TerminalKeyType keyType) { }

	private void HandleUserIsDeveloperChanged(StateChangedEventArgs args) { }

	private void OnDestroy() { }

	private void OnDrawGizmos() { }

	private void Start() { }

	private void SwitchCurrentItem(int incr) { }

	[ContextMenu("Test Buy")]
	private void TestBuy() { }

	[ContextMenu("Test Next")]
	private void TestNext() { }

	[ContextMenu("Test Prev")]
	private void TestPrev() { }

	private void TryToBuy() { }

	private void Update() { }

	private void UpdateCurrentPreview() { }

	private void UpdateItemLimitCheck() { }

}

