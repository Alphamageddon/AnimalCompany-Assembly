namespace AnimalCompany;

[ExecuteAlways]
public class CategoryScroller : MonoBehaviour
{
	[Tooltip("Max visible distance of a category")]
	public float visibleDistance; //Field offset: 0x20
	public Vector2 zPositionRange; //Field offset: 0x24
	public UIScrollWheel scrollWheel; //Field offset: 0x30
	public RectTransform content; //Field offset: 0x38
	public float scrollSensitivity; //Field offset: 0x40
	public List<CategoryController> categories; //Field offset: 0x48

	public CategoryScroller() { }

	private void Awake() { }

	public void FocusOnCategory(CategoryController category) { }

	private void LateUpdate() { }

	private void OnDrawGizmosSelected() { }

	private bool OnTryScroll(float dist) { }

	private void UpdateCategoryZ() { }

}

