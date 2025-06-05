namespace AnimalCompany;

public class Terminal : MonoBehaviour
{
	internal sealed class OnCodeEnteredDelegate : MulticastDelegate
	{

		public OnCodeEnteredDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string code, AsyncCallback callback, object object) { }

		public override bool EndInvoke(IAsyncResult result) { }

		public override bool Invoke(string code) { }

	}

	private static Terminal instance; //Field offset: 0x0
	public static OnCodeEnteredDelegate OnCodeEntered; //Field offset: 0x8
	public int maxInputLength; //Field offset: 0x20
	public string input; //Field offset: 0x28
	public TextMeshProUGUI inputText; //Field offset: 0x30
	public TextMeshProUGUI roomCodeText; //Field offset: 0x38
	public TextMeshProUGUI appVersionText; //Field offset: 0x40
	private TerminalKeyInputListener _keyInputListener; //Field offset: 0x48

	public Terminal() { }

	public void AddKeyInput(string key) { }

	private void Awake() { }

	public void Backspace() { }

	public void Enter() { }

	private void HandleCurrentRoomCodeChanged(StateChangedEventArgs args) { }

	private void HandleKeyInput(KeyCode key, TerminalKeyType keyType) { }

	private void OnDestroy() { }

	private void UpdateText() { }

}

