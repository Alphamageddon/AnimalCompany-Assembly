namespace AnimalCompany;

public class NotificationView : MonoBehaviour
{
	[SerializeField]
	private TMP_Text _contentLabel; //Field offset: 0x20
	[SerializeField]
	private TMP_Text _createTimeLabel; //Field offset: 0x28
	[SerializeField]
	private SlowHoverButton _deleteButton; //Field offset: 0x30
	[CompilerGenerated]
	private Action<String> onDelete; //Field offset: 0x38
	private string _id; //Field offset: 0x40
	private DateTime _dateTime; //Field offset: 0x48

	public event Action<String> onDelete
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public DateTime date
	{
		 get { } //Length: 8
	}

	public NotificationView() { }

	[CompilerGenerated]
	public void add_onDelete(Action<String> value) { }

	public DateTime get_date() { }

	private string GetPrettyDate(DateTime d) { }

	private void HandleDeletePressed() { }

	private void HandleKeyInput(KeyCode keyCode, TerminalKeyType keyType) { }

	private void OnDisable() { }

	private void OnEnable() { }

	[CompilerGenerated]
	public void remove_onDelete(Action<String> value) { }

	public void Setup(string id, string content, string time) { }

}

