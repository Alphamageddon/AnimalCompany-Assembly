namespace AnimalCompany;

public class PlayerView : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <PlayerHitCoroutine>d__83 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public PlayerView <>4__this; //Field offset: 0x20

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
		public <PlayerHitCoroutine>d__83(int <>1__state) { }

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

	internal enum Mode
	{
		Tracking = 0,
		Ragdoll = 1,
	}

	private static readonly Quaternion HIP_ROTATION_OFFSET_LEFT; //Field offset: 0x0
	private const float _ragdollGravityIntensity = 0.005; //Field offset: 0x0
	private const float _armFollowDamping = 0.2; //Field offset: 0x0
	private const float _maxArmLength = 0.75; //Field offset: 0x0
	private const string KEYWORD_EMISSION = "_EMISSION"; //Field offset: 0x0
	private const float _armFollowIntensity = 0.3; //Field offset: 0x0
	private static readonly Quaternion HIP_ROTATION_OFFSET_RIGHT; //Field offset: 0x10
	private static readonly Vector3 HAND_ROTATION_OFFSET_LEFT; //Field offset: 0x20
	private static readonly Vector3 HAND_ROTATION_OFFSET_RIGHT; //Field offset: 0x2C
	private static readonly int PROP_EMISSION_COLOR; //Field offset: 0x38
	private static readonly int PROP_PLAYER_VOLUME; //Field offset: 0x3C
	private Quaternion _handRotationOffsetLeft; //Field offset: 0x20
	private Quaternion _handRotationOffsetRight; //Field offset: 0x30
	public Vector3 HAND_POSITION_OFFSET_LEFT; //Field offset: 0x40
	public Vector3 HAND_POSITION_OFFSET_RIGHT; //Field offset: 0x4C
	[Header("References")]
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
	[SerializeField]
	private Transform _backAttachAnchor; //Field offset: 0x80
	[Header("Adjustment")]
	[SerializeField]
	private Transform _lowerArmBoneLeft; //Field offset: 0x88
	[SerializeField]
	private Transform _lowerArmBoneRight; //Field offset: 0x90
	[SerializeField]
	private Transform _handBoneLeft; //Field offset: 0x98
	[SerializeField]
	private Transform _handBoneRight; //Field offset: 0xA0
	[Header("Avatar Body")]
	[SerializeField]
	private AvatarView _avatarView; //Field offset: 0xA8
	[Header("IK")]
	[SerializeField]
	private Transform _cameraTarget; //Field offset: 0xB0
	[SerializeField]
	private Transform _handTargetLeft; //Field offset: 0xB8
	[SerializeField]
	private Transform _handTargetRight; //Field offset: 0xC0
	[SerializeField]
	private Transform _handHintLeft; //Field offset: 0xC8
	[SerializeField]
	private Transform _handHintRight; //Field offset: 0xD0
	[Header("Fingers")]
	[SerializeField]
	private PlayerFingerView[] _fingerViews; //Field offset: 0xD8
	[Header("Ragdoll")]
	[SerializeField]
	private Mode _mode; //Field offset: 0xE0
	[SerializeField]
	private GameObject[] _ragdollGameObjects; //Field offset: 0xE8
	[SerializeField]
	private Rigidbody[] _ragdollRigidbodies; //Field offset: 0xF0
	private Vector3 _velocityHandLeft; //Field offset: 0xF8
	private Vector3 _velocityHandRight; //Field offset: 0x104
	private Vector3 _prevHandPositionLeft; //Field offset: 0x110
	private Vector3 _prevHandPositionRight; //Field offset: 0x11C
	[Header("Mouse Movement")]
	[SerializeField]
	private float _volumeSmoothStrengh; //Field offset: 0x128
	[Range(0, 1)]
	[SerializeField]
	private float _volumeSmoothDrag; //Field offset: 0x12C
	[SerializeField]
	private float _volumeTremoloSpeed; //Field offset: 0x130
	[Range(0, 0.1)]
	[SerializeField]
	private float _volumeTremoloAmplitude; //Field offset: 0x134
	[SerializeField]
	private float _eyeScaleByVolume; //Field offset: 0x138
	private float _volumeSmooth; //Field offset: 0x13C
	private float _volumeSmoothVelocity; //Field offset: 0x140
	private float _eyeScaleDefault; //Field offset: 0x144
	[Header("Elastic Hip")]
	[SerializeField]
	private float _elasticHipStrength; //Field offset: 0x148
	[Range(0, 1)]
	[SerializeField]
	private float _elasticHipDrag; //Field offset: 0x14C
	[SerializeField]
	private Transform _hipTipLeft; //Field offset: 0x150
	[SerializeField]
	private Transform _hipTipRight; //Field offset: 0x158
	[SerializeField]
	private Transform _hipBoneLeft; //Field offset: 0x160
	[SerializeField]
	private Transform _hipBoneRight; //Field offset: 0x168
	[SerializeField]
	private Transform _spineBone; //Field offset: 0x170
	private Vector3 _hipTipPositionSpineSpaceLeft; //Field offset: 0x178
	private Vector3 _hipTipPositionSpineSpaceRight; //Field offset: 0x184
	private Vector3 _hipTipElasticPositionLeft; //Field offset: 0x190
	private Vector3 _hipTipElasticPositionRight; //Field offset: 0x19C
	private Vector3 _hipElasticVelocityLeft; //Field offset: 0x1A8
	private Vector3 _hipElasticVelocityRight; //Field offset: 0x1B4
	[Header("Debug")]
	[SerializeField]
	private bool _isTest; //Field offset: 0x1C0
	[SerializeField]
	private bool _disableTracking; //Field offset: 0x1C1
	[Range(0, 1)]
	[SerializeField]
	private float _testVoiceVolume; //Field offset: 0x1C4
	private bool _isLocalPlayer; //Field offset: 0x1C8
	private IEnumerator _playerHitCoroutine; //Field offset: 0x1D0

	public AvatarView avatarView
	{
		 get { } //Length: 8
	}

	public Transform backAttachAnchor
	{
		 get { } //Length: 8
	}

	public Mode mode
	{
		 get { } //Length: 8
	}

	public Transform ragdollHandLeft
	{
		 get { } //Length: 52
	}

	public Transform ragdollHandRight
	{
		 get { } //Length: 52
	}

	public Transform ragdollHead
	{
		 get { } //Length: 48
	}

	private static PlayerView() { }

	public PlayerView() { }

	private void Awake() { }

	private void FixedUpdate() { }

	public AvatarView get_avatarView() { }

	public Transform get_backAttachAnchor() { }

	public Mode get_mode() { }

	public Transform get_ragdollHandLeft() { }

	public Transform get_ragdollHandRight() { }

	public Transform get_ragdollHead() { }

	private void OnDrawGizmos() { }

	public void PlayerHit() { }

	[IteratorStateMachine(typeof(<PlayerHitCoroutine>d__83))]
	private IEnumerator PlayerHitCoroutine() { }

	public void SetColor(Color color) { }

	public void SetFingerValues(HandSide handSide, float thumbValue, float indexValue, float middleValue) { }

	public void SetIsLocalPlayer(bool isLocalPlayer) { }

	public void SetRagdoll(bool ragdoll, Vector3 force = null) { }

	public void Setup(UserAvatarState avatarState, Transform camera, Transform handLeft, Transform handRight, Transform controllerLeft, Transform controllerRight, bool isLocalPlayer) { }

	private void Update() { }

	public void UpdateAvatar(UserAvatarState avatarState) { }

	private void UpdateElasticHip() { }

	private void UpdateRagdoll() { }

	public void UpdateTransforms() { }

	public void UpdateVoice(float volume) { }

}

