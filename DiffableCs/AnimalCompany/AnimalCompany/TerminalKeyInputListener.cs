namespace AnimalCompany;

public class TerminalKeyInputListener : MonoBehaviour
{
	public Action<KeyCode, TerminalKeyType> onKeyInput; //Field offset: 0x20

	public TerminalKeyInputListener() { }

	public void AddKeyInput(KeyCode keyCode, TerminalKeyType keyType) { }

}

