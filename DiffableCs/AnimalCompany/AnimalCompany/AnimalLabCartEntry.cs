namespace AnimalCompany;

public class AnimalLabCartEntry : MonoBehaviour
{
	public TextMeshProUGUI nameText; //Field offset: 0x20
	public TextMeshProUGUI costText; //Field offset: 0x28
	public Color defaultColor; //Field offset: 0x30
	public Color errorColor; //Field offset: 0x40

	public AnimalLabCartEntry() { }

	public void SetColor(bool isError) { }

}

