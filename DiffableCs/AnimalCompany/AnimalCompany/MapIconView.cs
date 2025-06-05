namespace AnimalCompany;

public class MapIconView : MonoBehaviour
{
	[SerializeField]
	private Image _icon; //Field offset: 0x20
	[SerializeField]
	private Image _overlayIcon; //Field offset: 0x28
	private RectTransform _rectTransform; //Field offset: 0x30

	public RectTransform rectTransform
	{
		 get { } //Length: 8
	}

	public MapIconView() { }

	private void Awake() { }

	public RectTransform get_rectTransform() { }

	public void SetIconColor(Color color) { }

	public void SetIconSprite(Sprite sprite) { }

	public void SetXOut(bool xOut) { }

}

