namespace AnimalCompany;

[ExecuteAlways]
public class ItemScroller : MonoBehaviour
{
	public float visibleDistance; //Field offset: 0x20
	public float fullScaleDistance; //Field offset: 0x24
	public Vector2 zPositionRange; //Field offset: 0x28
	public Vector2 rotationRange; //Field offset: 0x30
	public UIScrollWheel scrollWheel; //Field offset: 0x38
	public RectTransform content; //Field offset: 0x40
	public float scrollSensitivity; //Field offset: 0x48
	public List<ItemController> items; //Field offset: 0x50

	public ItemScroller() { }

	private void Awake() { }

	private void OnDrawGizmosSelected() { }

	private bool OnTryScroll(float dist) { }

	public void ResetScroll() { }

	private void Update() { }

	private void UpdateItemScale() { }

	private void UpdateItemZAndRotation() { }

}

