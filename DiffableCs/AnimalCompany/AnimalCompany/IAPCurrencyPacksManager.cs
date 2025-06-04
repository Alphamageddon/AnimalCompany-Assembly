namespace AnimalCompany;

public class IAPCurrencyPacksManager : MonoBehaviour
{
	public IAPCurrencyPackButton[] currencyPackButtons; //Field offset: 0x20
	private CommandHandle _purchaseCommandHandle; //Field offset: 0x28

	public IAPCurrencyPacksManager() { }

	private void Awake() { }

	private void HandleProductsUpdated(StateChangedEventArgs args) { }

	private void OnDestroy() { }

	private void TryPurchase(IAPCurrencyPackButton btn) { }

}

