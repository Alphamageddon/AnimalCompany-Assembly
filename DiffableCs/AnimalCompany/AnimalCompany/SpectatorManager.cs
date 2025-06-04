namespace AnimalCompany;

public class SpectatorManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <SetSpectatorCoroutine>d__28 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public bool isSpectator; //Field offset: 0x20
		public SpectatorManager <>4__this; //Field offset: 0x28

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
		public <SetSpectatorCoroutine>d__28(int <>1__state) { }

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

	private static SpectatorManager _instance; //Field offset: 0x0
	private const float CAMERA_ROTATE_ANGLE = 45; //Field offset: 0x0
	private static readonly Single[] CAMERA_DISTANCES; //Field offset: 0x8
	private static readonly Vector3 CAMERA_TO_PLAYER_OFFSET; //Field offset: 0x10
	private int _currentCameraDistanceIndex; //Field offset: 0x20
	private float _currentCameraRotateAngle; //Field offset: 0x24
	private NetPlayer _currentTargetPlayer; //Field offset: 0x28
	private int _currentTargetPlayerIndex; //Field offset: 0x30
	[Header("Camera")]
	[SerializeField]
	private Camera _cameraMain; //Field offset: 0x38
	[SerializeField]
	private Camera _cameraSpectator; //Field offset: 0x40
	[SerializeField]
	private Transform _spectatorRoot; //Field offset: 0x48
	[SerializeField]
	private TrackedPoseDriver _trackedPoseDriverHead; //Field offset: 0x50
	[SerializeField]
	private TrackedPoseDriver _trackedPoseDriverSpectator; //Field offset: 0x58
	[Header("References")]
	[SerializeField]
	private PlayerView _playerView; //Field offset: 0x60
	[SerializeField]
	private Player _gorillaPlayer; //Field offset: 0x68
	[SerializeField]
	private XRController _xrControllerLeft; //Field offset: 0x70
	[SerializeField]
	private XRController _xrControllerRight; //Field offset: 0x78
	private bool _leftJoystickTriggered; //Field offset: 0x80
	private bool _rightJoystickTriggered; //Field offset: 0x81

	private Dictionary<UInt32, NetPlayer> _spawnedPlayers
	{
		private get { } //Length: 136
	}

	private static SpectatorManager() { }

	public SpectatorManager() { }

	private void Awake() { }

	private Dictionary<UInt32, NetPlayer> get__spawnedPlayers() { }

	private uint GetNetPlayerIndex(uint id) { }

	private uint GetNetPlayerIndex(NetPlayer player) { }

	private NetPlayer GetPlayerByID(uint id) { }

	private void OnDestroy() { }

	public static void SetSpectator(bool active) { }

	public static void SetSpectator(bool active, uint id) { }

	private void SetSpectatorCameraToTarget() { }

	public static void SetSpectatorCameraToTargetExternal() { }

	[IteratorStateMachine(typeof(<SetSpectatorCoroutine>d__28))]
	private IEnumerator SetSpectatorCoroutine(bool isSpectator) { }

	private void Update() { }

}

