namespace AnimalCompany;

public class FakeGorillaView : MobView
{
	[CompilerGenerated]
	private sealed class <AnimateFaceCoroutine>d__20 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public bool isMad; //Field offset: 0x20
		public FakeGorillaView <>4__this; //Field offset: 0x28
		private float <duration>5__2; //Field offset: 0x30
		private float <targetValue>5__3; //Field offset: 0x34
		private float <targetScale>5__4; //Field offset: 0x38
		private float <currentValue>5__5; //Field offset: 0x3C
		private float <currentScale>5__6; //Field offset: 0x40
		private float <t>5__7; //Field offset: 0x44

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
		public <AnimateFaceCoroutine>d__20(int <>1__state) { }

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

	private static readonly int PROP_BASE_COLOR; //Field offset: 0x0
	private const int BLEND_SHAPE_MAD_INDEX = 1; //Field offset: 0x0
	[Header("References")]
	[SerializeField]
	private AvatarView _avatarView; //Field offset: 0xB0
	[SerializeField]
	private PlayerView _playerView; //Field offset: 0xB8
	[SerializeField]
	private AvatarArmature _armature; //Field offset: 0xC0
	[SerializeField]
	private SkinnedMeshRenderer _fakeGorillaHeadRenderer; //Field offset: 0xC8
	[SerializeField]
	private Renderer _teethRenderer; //Field offset: 0xD0
	[Header("Audio")]
	[SerializeField]
	private AudioSource _audioSourceAggressive; //Field offset: 0xD8
	private bool _isMad; //Field offset: 0xE0
	private IEnumerator _animateFaceCoroutine; //Field offset: 0xE8

	private Transform _eyeLeft
	{
		private get { } //Length: 28
	}

	private Transform _eyeRight
	{
		private get { } //Length: 28
	}

	private SkinnedMeshRenderer _headRenderer
	{
		private get { } //Length: 28
	}

	private static FakeGorillaView() { }

	public FakeGorillaView() { }

	[IteratorStateMachine(typeof(<AnimateFaceCoroutine>d__20))]
	private IEnumerator AnimateFaceCoroutine(bool isMad) { }

	private Transform get__eyeLeft() { }

	private Transform get__eyeRight() { }

	private SkinnedMeshRenderer get__headRenderer() { }

	public void SetDie(Vector3 force) { }

	public void SetMad(bool isMad) { }

	public void SetRevive() { }

	public void SetupAvatar(Color color, bool isMad) { }

}

