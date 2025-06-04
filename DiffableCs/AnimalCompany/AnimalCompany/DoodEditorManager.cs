namespace AnimalCompany;

public class DoodEditorManager : MonoBehaviour
{
	private const float TRIGGER_TIME = 0.25; //Field offset: 0x0
	public GameObject categoryWithItemsParent; //Field offset: 0x20
	public GameObject categoryColorEditorParent; //Field offset: 0x28
	public CategoryScroller categoryScroller; //Field offset: 0x30
	public ItemScroller itemScroller; //Field offset: 0x38
	public AnimalLabCartManager cart; //Field offset: 0x40
	public CollisionTrigger trigger; //Field offset: 0x48
	public Transform uiParent; //Field offset: 0x50
	private int _uiParentTween; //Field offset: 0x58
	public CanvasGroup placeholderParent; //Field offset: 0x60
	private int _placeholderParentTween; //Field offset: 0x68
	public TextMeshProUGUI emptyCategoryText; //Field offset: 0x70
	public AudioSource openSound; //Field offset: 0x78
	public AudioSource closeSound; //Field offset: 0x80
	public GameObject[] enableWhenOn; //Field offset: 0x88
	private bool inTrigger; //Field offset: 0x90
	private bool isOn; //Field offset: 0x91
	private float triggerTimer; //Field offset: 0x94
	private ApiAvatarItemType currentCategory; //Field offset: 0x98
	public List<CategoryController> categoryButtons; //Field offset: 0xA0
	public CategoryController defaultFocusCategory; //Field offset: 0xA8
	public List<ItemController> itemButtons; //Field offset: 0xB0

	public DoodEditorManager() { }

	[CompilerGenerated]
	private void <TurnOff>b__31_0() { }

	private void Awake() { }

	private List<AvatarItemState> GetItemsForCategory(ApiAvatarItemType category) { }

	private void HandleSystemsReadyChanged(StateChangedEventArgs args) { }

	private int LoadItemsForCategory() { }

	private void OnDisable() { }

	private void OnDraftAvatarChanged(StateChangedEventArgs args) { }

	private void OnEnable() { }

	private void PlaceholderTween(float f) { }

	public void SelectCategory(CategoryController categoryController) { }

	private void TriggerEnter(Collider other) { }

	private void TriggerExit(Collider other) { }

	private void TurnOff(bool playSound = true) { }

	private void TurnOn() { }

	private void UITween(float f) { }

	private void Update() { }

}

