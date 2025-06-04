namespace AnimalCompany;

public class TabButtonView : MonoBehaviour
{
	[SerializeField]
	private Image selectedBG; //Field offset: 0x20
	[SerializeField]
	private TMP_Text label; //Field offset: 0x28

	public TabButtonView() { }

	public void SetSelected(bool selected) { }

}

