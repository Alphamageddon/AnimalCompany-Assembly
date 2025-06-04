namespace AnimalCompany;

public class ProximityActivator : MonoBehaviour
{
	private const float TRIGGER_TIME = 0.25; //Field offset: 0x0
	public CollisionTrigger trigger; //Field offset: 0x20
	public Transform uiParent; //Field offset: 0x28
	private int _uiParentTween; //Field offset: 0x30
	public CanvasGroup placeholderParent; //Field offset: 0x38
	private int _placeholderParentTween; //Field offset: 0x40
	public AudioSource openSound; //Field offset: 0x48
	public AudioSource closeSound; //Field offset: 0x50
	public GameObject[] enableWhenOn; //Field offset: 0x58
	private bool inTrigger; //Field offset: 0x60
	private bool isOn; //Field offset: 0x61
	private float triggerTimer; //Field offset: 0x64
	private float tweenMin; //Field offset: 0x68
	private float tweenMax; //Field offset: 0x6C

	public ProximityActivator() { }

	[CompilerGenerated]
	private void <TurnOff>b__19_0() { }

	private void Awake() { }

	private void PlaceholderTween(float f) { }

	private void TriggerEnter(Collider other) { }

	private void TriggerExit(Collider other) { }

	private void TurnOff(bool playSound = true) { }

	private void TurnOn() { }

	private void UITween(float f) { }

	private void Update() { }

}

