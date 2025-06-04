namespace AnimalCompany;

public class TerminalKeyInput : MonoBehaviour
{
	private const float PRESS_DEBOUNCE_TIME = 0.25; //Field offset: 0x0
	public TerminalKeyType keyType; //Field offset: 0x20
	public KeyCode keyCode; //Field offset: 0x24
	public string keyData; //Field offset: 0x28
	public Transform translateTransform; //Field offset: 0x30
	public RandomSFX keyPressSFX; //Field offset: 0x38
	public TerminalKeyInputListener keyInputListener; //Field offset: 0x40
	public float tweenValue; //Field offset: 0x48
	private int tweenID; //Field offset: 0x4C
	private float _lastKeyPressTime; //Field offset: 0x50

	public TerminalKeyInput() { }

	[CompilerGenerated]
	private void <Press>b__12_0(float val) { }

	[CompilerGenerated]
	private void <Press>b__12_1() { }

	private void OnDestroy() { }

	private void OnTriggerEnter(Collider other) { }

	public void Press() { }

}

