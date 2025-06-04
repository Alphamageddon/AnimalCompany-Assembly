namespace AnimalCompany;

public class GameManager : MonoBehaviour
{
	private static GameManager _instance; //Field offset: 0x0
	[SerializeField]
	private Transform _masterClientAOIOrigin; //Field offset: 0x20
	[Header("Fall Detection")]
	[SerializeField]
	private PlayerCollider _playerCollider1; //Field offset: 0x28
	[SerializeField]
	private Transform _respawnLocation1; //Field offset: 0x30
	[Header("Debug")]
	[SerializeField]
	private bool _isDebug; //Field offset: 0x38

	public static GameManager instance
	{
		 get { } //Length: 72
	}

	public static bool isDebug
	{
		 get { } //Length: 168
	}

	public Transform masterClientAOIOrigin
	{
		 get { } //Length: 8
	}

	public GameManager() { }

	public static void AddPlayerMoney(int amount) { }

	private void Awake() { }

	public static GameManager get_instance() { }

	public static bool get_isDebug() { }

	public Transform get_masterClientAOIOrigin() { }

	private void OnDestroy() { }

	private void OnPlayerCollisionEnter1(PlayerController playerController) { }

	private static void SubtractPlayerMoney(int amount) { }

	public static bool TrySpendMoney(int amount) { }

}

