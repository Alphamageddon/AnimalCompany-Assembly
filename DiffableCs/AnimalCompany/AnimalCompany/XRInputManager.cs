namespace AnimalCompany;

public class XRInputManager : MonoBehaviour
{
	private static XRInputManager _instance; //Field offset: 0x0
	public static Action onLeftTriggerButtonPressed; //Field offset: 0x8
	public static Action onLeftTriggerButtonReleased; //Field offset: 0x10
	public static Action onRightTriggerButtonPressed; //Field offset: 0x18
	public static Action onRightTriggerButtonReleased; //Field offset: 0x20
	public static Action onLeftGripButtonPressed; //Field offset: 0x28
	public static Action onLeftGripButtonReleased; //Field offset: 0x30
	public static Action onRightGripButtonPressed; //Field offset: 0x38
	public static Action onRightGripButtonReleased; //Field offset: 0x40
	public static Action onLeftPrimaryButtonPressed; //Field offset: 0x48
	public static Action onLeftPrimaryButtonReleased; //Field offset: 0x50
	public static Action onRightPrimaryButtonPressed; //Field offset: 0x58
	public static Action onRightPrimaryButtonReleased; //Field offset: 0x60
	public static Action onLeftSecondaryButtonPressed; //Field offset: 0x68
	public static Action onLeftSecondaryButtonReleased; //Field offset: 0x70
	public static Action onRightSecondaryButtonPressed; //Field offset: 0x78
	public static Action onRightSecondaryButtonReleased; //Field offset: 0x80
	public static Action onLeftJoystickClickPressed; //Field offset: 0x88
	public static Action onLeftJoystickClickReleased; //Field offset: 0x90
	public static Action onRightJoystickClickPressed; //Field offset: 0x98
	public static Action onRightJoystickClickReleased; //Field offset: 0xA0
	public static Action onMenuButtonPressed; //Field offset: 0xA8
	public static Action onMenuButtonReleased; //Field offset: 0xB0
	[Header("XR Controller")]
	[SerializeField]
	private XRController _xrControllerLeft; //Field offset: 0x20
	[SerializeField]
	private XRController _xrControllerRight; //Field offset: 0x28
	private Dictionary<InputFeatureUsage`1<Boolean>, Boolean> _buttonValuesLeft; //Field offset: 0x30
	private Dictionary<InputFeatureUsage`1<Boolean>, Boolean> _buttonValuesRight; //Field offset: 0x38

	public XRInputManager() { }

	private void Awake() { }

	private void GetButtonEvent(HandSide side, InputFeatureUsage<Boolean> inputFeatureUsage, Action onPressed, Action onReleased) { }

	public static bool GetJoystickValue(HandSide side, out Vector2 value) { }

	private static XRController GetXRController(HandSide side) { }

	private void OnDestroy() { }

	public static void SendHapticImpulse(HandSide side, float amplitude, float duration) { }

	public static void SendHapticImpulse(AttachedLocation location, float amplitude, float duration) { }

	private static bool TryGetFeatureValue(HandSide side, InputFeatureUsage<Vector2> inputFeatureUsage, out Vector2 value) { }

	private void Update() { }

}

