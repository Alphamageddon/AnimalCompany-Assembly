namespace AnimalCompany;

public class PlayerController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <RegenerationCoroutine>d__94 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public PlayerController <>4__this; //Field offset: 0x20

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 8
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 8
		}

		[DebuggerHidden]
		public <RegenerationCoroutine>d__94(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <SetDeathCoroutine>d__95 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public PlayerController <>4__this; //Field offset: 0x20
		public string hitName; //Field offset: 0x28
		public Vector3 force; //Field offset: 0x30

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 8
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 8
		}

		[DebuggerHidden]
		public <SetDeathCoroutine>d__95(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private static PlayerController _instance; //Field offset: 0x0
	private const float REGENERATION_INTERVAL = 3; //Field offset: 0x0
	private const int REGENERATION_HEALTH = 1; //Field offset: 0x0
	private const float TIME_TO_REVIVE = 8; //Field offset: 0x0
	public const int MAX_PLAYER_HEALTH = 100; //Field offset: 0x0
	[CompilerGenerated]
	private static Color <playerColor>k__BackingField; //Field offset: 0x8
	public static Action<HandSide, Single> OnHandstep; //Field offset: 0x18
	public static Action<Boolean> OnPlayerDie; //Field offset: 0x20
	public static Action onColorChanged; //Field offset: 0x28
	public static Action<Int32> onHealthChanged; //Field offset: 0x30
	public static Action<Boolean, Single> onBackpackUpdated; //Field offset: 0x38
	public static Action<Single> onHeldWeightUpdated; //Field offset: 0x40
	public static Action<Int32> onChannelChanged; //Field offset: 0x48
	private static readonly Vector2 HAND_MOVE_DELTA_MIN_MAX; //Field offset: 0x50
	private static readonly Vector2 HAND_STEP_VIBRATION_MIN_MAX; //Field offset: 0x58
	[Header("References")]
	[SerializeField]
	private Player _gorillaPlayer; //Field offset: 0x20
	[SerializeField]
	private PlayerControlAsset _playerControlAsset; //Field offset: 0x28
	[SerializeField]
	private Rigidbody _playerRigidbody; //Field offset: 0x30
	[SerializeField]
	private PlayerView _playerView; //Field offset: 0x38
	[SerializeField]
	private RandomSFX defaultFootstepSFX; //Field offset: 0x40
	[SerializeField]
	private AudioReverbZone _trackedReverbZone; //Field offset: 0x48
	[Header("Transforms")]
	[SerializeField]
	private Transform _bodyTransform; //Field offset: 0x50
	[SerializeField]
	private Transform _cameraTransform; //Field offset: 0x58
	[SerializeField]
	private Transform _handTransformLeft; //Field offset: 0x60
	[SerializeField]
	private Transform _handTransformRight; //Field offset: 0x68
	[SerializeField]
	private Transform _controllerTransformLeft; //Field offset: 0x70
	[SerializeField]
	private Transform _controllerTransformRight; //Field offset: 0x78
	[Header("PlayerState")]
	[SerializeField]
	private int _currHealth; //Field offset: 0x80
	[SerializeField]
	private bool _isDie; //Field offset: 0x84
	private WaitForSeconds _regenerationWait; //Field offset: 0x88
	private IEnumerator _regenerationCoroutine; //Field offset: 0x90
	public Vector3 _forceExternal; //Field offset: 0x98
	private float _forceDrag; //Field offset: 0xA4
	private Transform _grabbedTransform; //Field offset: 0xA8
	private Vector3 _grabbedOffset; //Field offset: 0xB0
	private IEnumerator _deathCoroutine; //Field offset: 0xC0
	private Dictionary<AttachedLocation, Single> _itemWeights; //Field offset: 0xC8
	private float _cachedItemWeight; //Field offset: 0xD0
	private Collider[] hitDamageSafeZoneCollidersBuffer; //Field offset: 0xD8
	private float _fpsMeasureInterval; //Field offset: 0xE0
	private float _timeLastMeasure; //Field offset: 0xE4
	private int _frameCount; //Field offset: 0xE8
	private Vector3 _spawnPosition; //Field offset: 0xEC
	private Vector3 _spawnDirection; //Field offset: 0xF8
	private readonly Color[] COLOR_OPTIONS; //Field offset: 0x108
	[CompilerGenerated]
	private int <playerChannel>k__BackingField; //Field offset: 0x110
	[CompilerGenerated]
	private bool <snapTurnEnabled>k__BackingField; //Field offset: 0x114
	private Vector2 _prevLeftJoystickValue; //Field offset: 0x118
	private Vector2 _prevRightJoystickValue; //Field offset: 0x120
	private XRController _leftController; //Field offset: 0x128
	private XRController _rightController; //Field offset: 0x130
	private bool _prevTrackedleft; //Field offset: 0x138
	private bool _prevTrackedRight; //Field offset: 0x139

	public Transform backAttachAnchor
	{
		 get { } //Length: 28
	}

	public Transform body
	{
		 get { } //Length: 8
	}

	public Transform controllerLeft
	{
		 get { } //Length: 8
	}

	public Transform controllerRight
	{
		 get { } //Length: 8
	}

	public Player gorillaPlayer
	{
		 get { } //Length: 8
	}

	public Transform handLeft
	{
		 get { } //Length: 8
	}

	public Transform handRight
	{
		 get { } //Length: 8
	}

	public Transform head
	{
		 get { } //Length: 8
	}

	public static PlayerController instance
	{
		 get { } //Length: 88
	}

	public private int playerChannel
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private static Color playerColor
	{
		[CompilerGenerated]
		 get { } //Length: 92
		[CompilerGenerated]
		private set { } //Length: 124
	}

	private bool snapTurnEnabled
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 12
	}

	private static PlayerController() { }

	public PlayerController() { }

	[CompilerGenerated]
	internal static float <UpdateSnapTurn>g__CheckToTurn|110_0(HandSide handSide, ref Vector2 prevValue) { }

	public void AddExternalForce(Vector3 velocity) { }

	public void AddItemContactPoint(Vector3 position, Vector3 prevPosition) { }

	public void AttachToTransform(bool attach, Transform transform, bool moveToTransformImmediately = false, Vector3 offset = null) { }

	private void Awake() { }

	private void FixedUpdate() { }

	public Transform get_backAttachAnchor() { }

	public Transform get_body() { }

	public Transform get_controllerLeft() { }

	public Transform get_controllerRight() { }

	public Player get_gorillaPlayer() { }

	public Transform get_handLeft() { }

	public Transform get_handRight() { }

	public Transform get_head() { }

	public static PlayerController get_instance() { }

	[CompilerGenerated]
	public int get_playerChannel() { }

	[CompilerGenerated]
	public static Color get_playerColor() { }

	[CompilerGenerated]
	private bool get_snapTurnEnabled() { }

	private void HandleHandCollision(Collider collider, Vector3 point, Vector3 moveDelta, HandSide handSide) { }

	private void HandleMenuButtonPressed() { }

	private void MovePlayerDelta(Vector3 moveDelta) { }

	private void MovePlayerTo(Vector3 position) { }

	private void OnDestroy() { }

	private void OnHandColliding(RaycastHit hit, Vector3 moveDelta, HandSide handSide) { }

	private void OnHandCollidingLeft(RaycastHit hit, Vector3 moveDelta) { }

	private void OnHandCollidingRight(RaycastHit hit, Vector3 moveDelta) { }

	public void OnItemCollision(Collision collision, Vector3 velocity, HandSide handSide) { }

	private void OnNetworkInput(NetworkInput input) { }

	public void PlayerDie(RandomSFX killSound, string hitName) { }

	public void PlayerHit(int damage, Vector3 position, Quaternion rotation, string hitSound, string killSound, string hitName) { }

	public void PlayerHit(int damage, Vector3 position, Quaternion rotation, string hitSound, string killSound, Vector3 force, string hitName) { }

	public void PlayerHit(int damage, Vector3 position, Quaternion rotation, string hitSound, string killSound, PrefabType prefabType, string hitName) { }

	private void PlayerHitInternal(int damage, Vector3 position, Quaternion rotation, string hitSound, string killSound, string hitName) { }

	[IteratorStateMachine(typeof(<RegenerationCoroutine>d__94))]
	private IEnumerator RegenerationCoroutine() { }

	public void Respawn(Vector3 targetPosition, Vector3 targetDirection, bool dropItems = false) { }

	public void Respawn(Vector3 targetPosition, bool dropItems = false) { }

	public void Respawn(Transform targetTransform, bool dropItems = false) { }

	[CompilerGenerated]
	private void set_playerChannel(int value) { }

	[CompilerGenerated]
	private static void set_playerColor(Color value) { }

	[CompilerGenerated]
	private void set_snapTurnEnabled(bool value) { }

	public void SetChannel(int channel) { }

	private void SetCurrentHealth(int health) { }

	[IteratorStateMachine(typeof(<SetDeathCoroutine>d__95))]
	private IEnumerator SetDeathCoroutine(string hitName, Vector3 force = null) { }

	public void SetItemWeight(AttachedLocation slot, float weight) { }

	[ContextMenu("Change Color")]
	public void SetRandomColor() { }

	private void Update() { }

	public void UpdateBackpack(bool equipped, float fillAmount) { }

	private void UpdateSnapTurn() { }

}

