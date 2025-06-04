namespace AnimalCompany;

public class PlayerEditorController : MonoBehaviour
{
	public static bool isEditorController; //Field offset: 0x0
	public static Transform editorControllerTransform; //Field offset: 0x8
	public bool useEditorController; //Field offset: 0x20
	[SerializeField]
	private RandomSFX footstepSFX; //Field offset: 0x28
	private float _footStepDistance; //Field offset: 0x30
	private float _footStepDistAccum; //Field offset: 0x34
	private Vector3 _prevPosition; //Field offset: 0x38
	[SerializeField]
	private Player _player; //Field offset: 0x48
	[SerializeField]
	private Rigidbody _playerRigidbody; //Field offset: 0x50
	[SerializeField]
	private XRController _xrControllerLeft; //Field offset: 0x58
	[SerializeField]
	private XRController _xrControllerRight; //Field offset: 0x60
	[SerializeField]
	private TrackedPoseDriver _trackedPoseDriverHead; //Field offset: 0x68
	public InputAction playerControl; //Field offset: 0x70
	public InputAction inputActionDash; //Field offset: 0x78
	public InputAction inputActionJump; //Field offset: 0x80
	public InputAction inputActionMouseInput; //Field offset: 0x88
	public InputAction inputActionMouseClick; //Field offset: 0x90
	private InputAction _inputActionTestKey1; //Field offset: 0x98
	private InputAction _inputActionTestKey2; //Field offset: 0xA0
	private InputAction _inputActionTestKey3; //Field offset: 0xA8
	public AudioSource windAudioSource; //Field offset: 0xB0
	public Vector2 windSpeedRange; //Field offset: 0xB8
	private Rigidbody _rigidbody; //Field offset: 0xC0
	private float movementSpeed; //Field offset: 0xC8
	private float fastMovementSpeed; //Field offset: 0xCC
	public float freeLookSensitivity; //Field offset: 0xD0
	public float zoomSensitivity; //Field offset: 0xD4
	public float fastZoomSensitivity; //Field offset: 0xD8
	private bool looking; //Field offset: 0xDC
	private bool _isFastMode; //Field offset: 0xDD

	public PlayerEditorController() { }

	private void Awake() { }

}

