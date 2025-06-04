namespace AnimalCompany;

public class Terminal : MonoBehaviour
{
	internal sealed class OnCodeEnteredDelegate : MulticastDelegate
	{

		public OnCodeEnteredDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string code, SessionProperties properties, AsyncCallback callback, object object) { }

		public override bool EndInvoke(IAsyncResult result) { }

		public override bool Invoke(string code, SessionProperties properties) { }

	}

	private static Terminal instance; //Field offset: 0x0
	public static OnCodeEnteredDelegate OnCodeEntered; //Field offset: 0x8
	public int maxInputLength; //Field offset: 0x20
	public string input; //Field offset: 0x28
	public TextMeshProUGUI inputText; //Field offset: 0x30
	public TextMeshProUGUI roomCodeText; //Field offset: 0x38
	public TextMeshProUGUI appVersionText; //Field offset: 0x40
	public TextMeshProUGUI statusText; //Field offset: 0x48
	public TextMeshProUGUI playerCountText; //Field offset: 0x50
	public TextMeshProUGUI pvpEnabledText; //Field offset: 0x58
	private TerminalKeyInputListener _keyInputListener; //Field offset: 0x60

	public Terminal() { }

	public void AddKeyInput(string key) { }

	private void Awake() { }

	public void Backspace() { }

	public void Enter(SessionProperties properties = null) { }

	private void HandleCurrentRoomCodeChanged(StateChangedEventArgs args) { }

	private void HandleKeyInput(KeyCode key, TerminalKeyType keyType) { }

	private void HandleSessionPlayerCountChanged(StateChangedEventArgs args) { }

	private void HandleSessionPropertiesChanged(StateChangedEventArgs args) { }

	private void HandleSessionStatusChanged(StateChangedEventArgs args) { }

	private void OnDestroy() { }

	private void UpdateText() { }

}

