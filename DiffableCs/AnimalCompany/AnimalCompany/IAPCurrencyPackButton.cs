namespace AnimalCompany;

[RequireComponent(typeof(SlowHoverButton))]
public class IAPCurrencyPackButton : MonoBehaviour
{
	public string productID; //Field offset: 0x20
	public TextMeshProUGUI rewardText; //Field offset: 0x28
	public TextMeshProUGUI priceText; //Field offset: 0x30
	public Action<IAPCurrencyPackButton> onActivate; //Field offset: 0x38
	private SlowHoverButton _button; //Field offset: 0x40

	public IAPCurrencyPackButton() { }

	private void Awake() { }

	private void HandleActivate() { }

	private void OnDestroy() { }

}

