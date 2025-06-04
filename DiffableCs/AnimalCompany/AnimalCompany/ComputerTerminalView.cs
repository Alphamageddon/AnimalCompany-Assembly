namespace AnimalCompany;

public class ComputerTerminalView : MonoBehaviour
{
	private class KeyData
	{
		public KeyCode code; //Field offset: 0x10
		public GameObject obj; //Field offset: 0x18

		public KeyData() { }

	}

	internal enum Program
	{
		Room = 0,
		Promo = 1,
		Terminal = 2,
		Count = 3,
	}

	private static Dictionary<KeyCode, Char> KEYCODE_TO_CHAR; //Field offset: 0x0
	[SerializeField]
	private GameObject _powerButton; //Field offset: 0x20
	[Header("Screen")]
	[SerializeField]
	private Canvas _canvas; //Field offset: 0x28
	[SerializeField]
	private int _renderTexResolution; //Field offset: 0x30
	[SerializeField]
	private MeshRenderer _screenRenderer; //Field offset: 0x38
	[SerializeField]
	private float _screenAspect; //Field offset: 0x40
	[SerializeField]
	private Camera _screenCamera; //Field offset: 0x48
	[SerializeField]
	private TextMeshProUGUI _versionText; //Field offset: 0x50
	[SerializeField]
	private TextMeshProUGUI _programTabText; //Field offset: 0x58
	[SerializeField]
	private TextMeshProUGUI _programOutputText; //Field offset: 0x60
	[SerializeField]
	private TextMeshProUGUI _promptText; //Field offset: 0x68
	[Header("Keyboard")]
	[SerializeField]
	private float _keyPressDebounceTime; //Field offset: 0x70
	[SerializeField]
	private Transform _keyboardParent; //Field offset: 0x78
	[SerializeField]
	private KeyData[] _keys; //Field offset: 0x80
	[SerializeField]
	private Vector3 _keyPressedOffset; //Field offset: 0x88
	[SerializeField]
	private Vector3 _keyColliderSizeOffset; //Field offset: 0x94
	[SerializeField]
	private RandomSFX _buttonPressSFX; //Field offset: 0xA0
	[SerializeField]
	private RandomSFX _buttonReleaseSFX; //Field offset: 0xA8
	[SerializeField]
	private Transform _sfxOrigin; //Field offset: 0xB0
	private RenderTexture _renderTexture; //Field offset: 0xB8
	private Program _currentProgram; //Field offset: 0xC0
	private String[] _programOutput; //Field offset: 0xC8
	private string _currentPromptInput; //Field offset: 0xD0
	private float _lastKeyPressTime; //Field offset: 0xD8
	private StringBuilder _sb; //Field offset: 0xE0
	private bool _isDirty; //Field offset: 0xE8
	public Action<String> onEnteredRoomCode; //Field offset: 0xF0
	public Action<String> onEnteredPromoCode; //Field offset: 0xF8
	public Action<String> onTerminalCommand; //Field offset: 0x100
	public Action onJoinRandomPressed; //Field offset: 0x108
	public Action onJoinRandomNoPvpPressed; //Field offset: 0x110

	private static ComputerTerminalView() { }

	public ComputerTerminalView() { }

	private void Awake() { }

	private void HandleKeyPressed(ComputerTerminalKey keyView) { }

	private void HandleKeyReleased(ComputerTerminalKey keyView) { }

	private void OnDestroy() { }

	private void RefreshScreen() { }

	public void SetProgramOutput(Program program, string output) { }

	private void SetupPokeButton(KeyCode keyCode, GameObject keyObj) { }

	public void SetVersionText(string version) { }

	private void Update() { }

}

