namespace AnimalCompany;

public class PlayerSpectator : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <SetSpectatorCamera>d__10 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public bool isSpectator; //Field offset: 0x20
		public PlayerSpectator <>4__this; //Field offset: 0x28
		public Vector3 cameraForward; //Field offset: 0x30
		public Vector3 cameraPosition; //Field offset: 0x3C

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
		public <SetSpectatorCamera>d__10(int <>1__state) { }

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

	[Header("References")]
	[SerializeField]
	private PlayerView _playerView; //Field offset: 0x20
	[SerializeField]
	private Player _gorillaPlayer; //Field offset: 0x28
	[SerializeField]
	private XRController _xrControllerLeft; //Field offset: 0x30
	[SerializeField]
	private XRController _xrControllerRight; //Field offset: 0x38
	[SerializeField]
	private Camera _cameraHead; //Field offset: 0x40
	[SerializeField]
	private Camera _cameraSpectator; //Field offset: 0x48
	[SerializeField]
	private Transform _spectatorRoot; //Field offset: 0x50
	[SerializeField]
	private TrackedPoseDriver _trackedPoseDriverHead; //Field offset: 0x58
	[SerializeField]
	private TrackedPoseDriver _trackedPoseDriverSpectator; //Field offset: 0x60

	public PlayerSpectator() { }

	private void Awake() { }

	[IteratorStateMachine(typeof(<SetSpectatorCamera>d__10))]
	public IEnumerator SetSpectatorCamera(bool isSpectator, Vector3 cameraPosition = null, Vector3 cameraForward = null) { }

}

