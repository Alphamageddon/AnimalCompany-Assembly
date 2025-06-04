namespace AnimalCompany;

public class ItemSellingMachineButtonView : MonoBehaviour
{
	private static readonly int PROP_BUTTON_EMISSION_COLOR; //Field offset: 0x0
	private const float PRESS_DEBOUNCE_TIME = 0.2; //Field offset: 0x0
	private const float BUTTON_LOCAL_Z_PRESSED = -0.082; //Field offset: 0x0
	private static readonly Color BUTTON_PRESSED_COLOR_CORRECT; //Field offset: 0x4
	private static readonly Color BUTTON_PRESSED_COLOR_INCORRECT; //Field offset: 0x14
	public ItemSellingMachineController controller; //Field offset: 0x20
	public int buttonGroupId; //Field offset: 0x28
	public int buttonId; //Field offset: 0x2C
	[SerializeField]
	private Transform _buttonTransform; //Field offset: 0x30
	[SerializeField]
	private MeshRenderer _buttonRenderer; //Field offset: 0x38
	[SerializeField]
	private MeshRenderer _buttonBackRenderer; //Field offset: 0x40
	private float _lastKeyPressTime; //Field offset: 0x48
	private int _tweenID; //Field offset: 0x4C

	private static ItemSellingMachineButtonView() { }

	public ItemSellingMachineButtonView() { }

	[CompilerGenerated]
	private void <PlayButtonPressedAnimation>b__16_0(float val) { }

	[CompilerGenerated]
	private void <PlayButtonPressedAnimation>b__16_1() { }

	[CompilerGenerated]
	private void <PlayButtonPressedAnimation>b__16_2(float val) { }

	[CompilerGenerated]
	private void <PlayButtonPressedAnimation>b__16_3() { }

	private void OnDestroy() { }

	private void OnTriggerEnter(Collider other) { }

	public void PlayButtonPressedAnimation() { }

	public void SetBackButtonEmission(bool isOn, bool isCorrect) { }

	public void Setup(ItemSellingMachineController controller, int buttonGroupId, int buttonId) { }

}

