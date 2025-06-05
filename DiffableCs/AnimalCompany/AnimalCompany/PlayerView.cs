namespace AnimalCompany;

public class PlayerView : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <PlayerHitCoroutine>d__77 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public PlayerView <>4__this; //Field offset: 0x20
		private Renderer[] <renderers>5__2; //Field offset: 0x28

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
		public <PlayerHitCoroutine>d__77(int <>1__state) { }

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

	internal enum Type
	{
		Local = 0,
		Remote = 1,
	}

	private static readonly Vector3 HAND_ROTATION_OFFSET_LEFT; //Field offset: 0x0
	private const float _armFollowDamping = 0.2; //Field offset: 0x0
	private const float _ragdollGravityIntensity = 0.005; //Field offset: 0x0
	private const float _armFollowIntensity = 0.3; //Field offset: 0x0
	private const float _maxArmLength = 0.75; //Field offset: 0x0
	private const string KEYWORD_EMISSION = "_EMISSION"; //Field offset: 0x0
	private static readonly Vector3 HAND_ROTATION_OFFSET_RIGHT; //Field offset: 0xC
	private static readonly Vector3 HINT_OFFSET_LEFT; //Field offset: 0x18
	private static readonly Vector3 HINT_OFFSET_RIGHT; //Field offset: 0x24
	private static readonly int PROP_EMISSION_COLOR; //Field offset: 0x30
	[Header("References")]
	[SerializeField]
	private Transform _cameraTransform; //Field offset: 0x20
	[SerializeField]
	private Transform _handTransformLeft; //Field offset: 0x28
	[SerializeField]
	private Transform _handTransformRight; //Field offset: 0x30
	[SerializeField]
	private Transform _controllerTransformLeft; //Field offset: 0x38
	[SerializeField]
	private Transform _controllerTransformRight; //Field offset: 0x40
	[SerializeField]
	private Transform _backAttachAnchor; //Field offset: 0x48
	[Header("Type")]
	[SerializeField]
	private Type _type; //Field offset: 0x50
	[SerializeField]
	private Renderer[] _rendererLocal; //Field offset: 0x58
	[SerializeField]
	private Renderer[] _rendererRemote; //Field offset: 0x60
	[Header("IK")]
	[SerializeField]
	private Transform _cameraTarget; //Field offset: 0x68
	[SerializeField]
	private Transform _handTargetLeft; //Field offset: 0x70
	[SerializeField]
	private Transform _handTargetRight; //Field offset: 0x78
	[SerializeField]
	private Transform _handHintLeft; //Field offset: 0x80
	[SerializeField]
	private Transform _handHintRight; //Field offset: 0x88
	[Header("Ragdoll")]
	[SerializeField]
	private Mode _mode; //Field offset: 0x90
	[SerializeField]
	private GameObject[] _ragdollGameObjects; //Field offset: 0x98
	[SerializeField]
	private Rigidbody[] _ragdollRigidbodies; //Field offset: 0xA0
	private Vector3 _velocityHandLeft; //Field offset: 0xA8
	private Vector3 _velocityHandRight; //Field offset: 0xB4
	private Vector3 _prevHandPositionLeft; //Field offset: 0xC0
	private Vector3 _prevHandPositionRight; //Field offset: 0xCC
	[Header("Mouse Movement")]
	[SerializeField]
	private float _volumeSmoothStrengh; //Field offset: 0xD8
	[Range(0, 1)]
	[SerializeField]
	private float _volumeSmoothDrag; //Field offset: 0xDC
	[SerializeField]
	private float _volumeTremoloSpeed; //Field offset: 0xE0
	[Range(0, 0.1)]
	[SerializeField]
	private float _volumeTremoloAmplitude; //Field offset: 0xE4
	[SerializeField]
	private Vector2 _tungRotationRange; //Field offset: 0xE8
	[SerializeField]
	private Transform _tungTransform; //Field offset: 0xF0
	[SerializeField]
	private SkinnedMeshRenderer _bodyRenderer; //Field offset: 0xF8
	[SerializeField]
	private float _eyeScaleByVolume; //Field offset: 0x100
	[SerializeField]
	private Transform[] _eyeTransforms; //Field offset: 0x108
	private float _volumeSmooth; //Field offset: 0x110
	private float _volumeSmoothVelocity; //Field offset: 0x114
	private float _tungRotaitonDefault; //Field offset: 0x118
	private float _eyeScaleDefault; //Field offset: 0x11C
	[Header("Elastic Hip")]
	[SerializeField]
	private float _elasticHipStrength; //Field offset: 0x120
	[Range(0, 1)]
	[SerializeField]
	private float _elasticHipDrag; //Field offset: 0x124
	[SerializeField]
	private Transform _hipTipLeft; //Field offset: 0x128
	[SerializeField]
	private Transform _hipTipRight; //Field offset: 0x130
	[SerializeField]
	private Transform _hipBoneLeft; //Field offset: 0x138
	[SerializeField]
	private Transform _hipBoneRight; //Field offset: 0x140
	[SerializeField]
	private Transform _spineBone; //Field offset: 0x148
	private Vector3 _hipTipPositionSpineSpaceLeft; //Field offset: 0x150
	private Vector3 _hipTipPositionSpineSpaceRight; //Field offset: 0x15C
	private Vector3 _hipTipElasticPositionLeft; //Field offset: 0x168
	private Vector3 _hipTipElasticPositionRight; //Field offset: 0x174
	private Vector3 _hipElasticVelocityLeft; //Field offset: 0x180
	private Vector3 _hipElasticVelocityRight; //Field offset: 0x18C
	[Header("Debug")]
	[SerializeField]
	private bool _isTest; //Field offset: 0x198
	[SerializeField]
	private bool _disableTracking; //Field offset: 0x199
	[Range(0, 1)]
	[SerializeField]
	private float _testVoiceVolume; //Field offset: 0x19C
	private IEnumerator _playerHitCoroutine; //Field offset: 0x1A0

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

	public Transform get_backAttachAnchor() { }

	public Mode get_mode() { }

	public Transform get_ragdollHandLeft() { }

	public Transform get_ragdollHandRight() { }

	public Transform get_ragdollHead() { }

	public bool GetIsLocal() { }

	private void OnDrawGizmos() { }

	public void PlayerHit() { }

	[IteratorStateMachine(typeof(<PlayerHitCoroutine>d__77))]
	private IEnumerator PlayerHitCoroutine() { }

	public void SetColor(Color color) { }

	public void SetRagdoll(bool ragdoll, Vector3 force = null) { }

	public void SetRenderType(Type type) { }

	public void Setup(Transform camera, Transform handLeft, Transform handRight, Transform controllerLeft, Transform controllerRight, Type type) { }

	private void Update() { }

	private void UpdateElasticHip() { }

	private void UpdateRagdoll() { }

	public void UpdateTransforms() { }

	public void UpdateVoice(float volume) { }

}

