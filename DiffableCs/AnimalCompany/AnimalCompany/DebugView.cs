namespace AnimalCompany;

public class DebugView : MonoBehaviour
{
	private static DebugView _instance; //Field offset: 0x0
	[SerializeField]
	private TextMeshProUGUI _textDebug; //Field offset: 0x20
	[SerializeField]
	private XRBaseController _xrControllerLeft; //Field offset: 0x28
	private Dictionary<String, String> _textsToShow; //Field offset: 0x30
	private bool _needUpdateText; //Field offset: 0x38

	public DebugView() { }

	public static void AddText(string key, string text) { }

	private void Awake() { }

	private void Update() { }

}

