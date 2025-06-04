namespace AnimalCompany;

public class ItemController : MonoBehaviour
{
	public DoodEditorManager editorManager; //Field offset: 0x20
	public CollisionTrigger trigger; //Field offset: 0x28
	public AvatarSystemCatalog avatarSystemCatalog; //Field offset: 0x30
	public GameObject defaultViewPrefab; //Field offset: 0x38
	public GameObject clearItemViewPrefab; //Field offset: 0x40
	public GameObject equippedElement; //Field offset: 0x48
	public Transform viewRoot; //Field offset: 0x50
	public TextMeshProUGUI itemNameText; //Field offset: 0x58
	public GameObject priceTagRoot; //Field offset: 0x60
	public TextMeshProUGUI priceTagText; //Field offset: 0x68
	public float viewBoundsSize; //Field offset: 0x70
	public RandomSFX interactSFX; //Field offset: 0x78
	private AvatarItemState _itemData; //Field offset: 0x80
	private bool _isNullAccessory; //Field offset: 0x88
	private ApiAvatarItemType _itemType; //Field offset: 0x8C

	public ItemController() { }

	private void Awake() { }

	public void ClearItem() { }

	private void DestroyViews() { }

	[ContextMenu("Select Item")]
	private void InspectorSelect() { }

	private void OnDrawGizmos() { }

	public void SetItem(AvatarItemState data, ApiAvatarItemType itemType, bool isNullAccesory = false) { }

	private void TriggerEnter(Collider other) { }

	public void UpdateIsEquipped() { }

}

