namespace AnimalCompany;

public class PurchaseTagController : MonoBehaviour
{
	public string inspectorItemID; //Field offset: 0x20
	public XRGrabInteractable grabInteractable; //Field offset: 0x28
	private string _currentItemID; //Field offset: 0x30

	public PurchaseTagController() { }

	private void Awake() { }

	private void OnEnable() { }

	private void Release(SelectExitEventArgs args) { }

	private void SetupForID(string itemID) { }

}

