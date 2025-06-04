namespace AnimalCompany;

public class LoadingScreenView : MonoBehaviour
{
	private static LoadingScreenView _instance; //Field offset: 0x0
	[SerializeField]
	private GameObject _loadingTextGO; //Field offset: 0x20
	[SerializeField]
	private TextMeshPro _versionText; //Field offset: 0x28
	[SerializeField]
	private TextMeshPro _statusText; //Field offset: 0x30

	public LoadingScreenView() { }

	private void Awake() { }

	private void OnDestroy() { }

	public static void SetStatus(string status, bool showLoading) { }

}

