namespace AnimalCompany;

public class CategoryController : MonoBehaviour
{
	public DoodEditorManager doodEditor; //Field offset: 0x20
	public ApiAvatarItemType category; //Field offset: 0x28
	public CanvasGroup canvasGroup; //Field offset: 0x30
	public MeshRenderer filledRenderer; //Field offset: 0x38
	public MeshRenderer wireRenderer; //Field offset: 0x40
	public Transform animScaler; //Field offset: 0x48
	public TextMeshProUGUI categoryText; //Field offset: 0x50
	public Image uiIcon; //Field offset: 0x58
	public Color selectedUIColor; //Field offset: 0x60
	public Color unselectedUIColor; //Field offset: 0x70
	public RandomSFX interactSFX; //Field offset: 0x80
	public string categoryEmptyPlaceholderText; //Field offset: 0x88
	private float _alpha; //Field offset: 0x90
	private int _selectTweenID; //Field offset: 0x94
	[HideInInspector]
	public Vector3 lastLocalPosition; //Field offset: 0x98

	public CategoryController() { }

	[CompilerGenerated]
	private void <OnTriggerEnter>b__19_0(float val) { }

	private void Awake() { }

	private void OnTriggerEnter(Collider other) { }

	public void SetAlpha(float f) { }

	public void SetIsSelectedVisual(bool selected) { }

	[ContextMenu("SELECT ME")]
	private void TestSelect() { }

}

