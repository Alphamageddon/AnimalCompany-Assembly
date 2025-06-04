namespace AnimalCompany;

public class AnimalLabColorEditor : MonoBehaviour
{
	public float scrollSensitivity; //Field offset: 0x20
	[Space]
	public UIScrollWheel scrollRed; //Field offset: 0x28
	public UIScrollWheel scrollGreen; //Field offset: 0x30
	public UIScrollWheel scrollBlue; //Field offset: 0x38
	[Space]
	public TextMeshProUGUI redValueText; //Field offset: 0x40
	public TextMeshProUGUI greenValueText; //Field offset: 0x48
	public TextMeshProUGUI blueValueText; //Field offset: 0x50

	public AnimalLabColorEditor() { }

	private void Awake() { }

	private void OnDisable() { }

	private void OnDraftAvatarColorChanged(StateChangedEventArgs args) { }

	private void OnEnable() { }

	private bool ScrollBlue(float value) { }

	private bool ScrollGreen(float value) { }

	private bool ScrollRed(float value) { }

}

