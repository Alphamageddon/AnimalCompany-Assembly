namespace AnimalCompany;

public class AnimalLabCartManager : MonoBehaviour
{
	private const string SMALL_CURRENCY_PACK_ID = "CURRENCY_SMALL"; //Field offset: 0x0
	private const string MEDIUM_CURRENCY_PACK_ID = "CURRENCY_MEDIUM"; //Field offset: 0x0
	private const string LARGE_CURRENCY_PACK_ID = "CURRENCY_LARGE"; //Field offset: 0x0
	private CommandHandle _cartPurchaseHandle; //Field offset: 0x20
	private CommandHandle _currencyPurchaseHandle; //Field offset: 0x28
	private bool purchaseInProgress; //Field offset: 0x30
	public AnimalLabCartEntry cartEntryPrefab; //Field offset: 0x38
	public Transform cartEntryContainer; //Field offset: 0x40
	public SlowHoverButton spawnButton; //Field offset: 0x48
	public SlowHoverButton purchaseAndSpawnButton; //Field offset: 0x50
	public SlowHoverButton notEnoughCurrencyButton; //Field offset: 0x58
	public TextMeshProUGUI cartTotalText; //Field offset: 0x60
	public GameObject purchaseInProgressParent; //Field offset: 0x68
	public TextMeshProUGUI purchaseInProgressText; //Field offset: 0x70
	private int cartTotalCost; //Field offset: 0x78
	private HashSet<AvatarItemState> cartItems; //Field offset: 0x80
	private List<AnimalLabCartEntry> cartEntries; //Field offset: 0x88

	public AnimalLabCartManager() { }

	[CompilerGenerated]
	private void <AttemptCheckout>b__24_0() { }

	private void AttemptCheckout() { }

	private void AttemptPurchaseMoreCurrency() { }

	private void Awake() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnPurchaseComplete() { }

	private void OnWalletValueChanged(StateChangedEventArgs args) { }

	public void RecalculateCart() { }

	private void UpdateCartUI() { }

}

