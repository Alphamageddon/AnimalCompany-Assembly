namespace Fusion.XR.Host.Rig;

public class HardwareRig : MonoBehaviour, INetworkRunnerCallbacks
{
	[CompilerGenerated]
	private sealed class <FadedRotate>d__21 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public HardwareRig <>4__this; //Field offset: 0x20
		public float angle; //Field offset: 0x28

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
		public <FadedRotate>d__21(int <>1__state) { }

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
	private sealed class <FadedTeleport>d__20 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public HardwareRig <>4__this; //Field offset: 0x20
		public Vector3 position; //Field offset: 0x28

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
		public <FadedTeleport>d__20(int <>1__state) { }

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
	private struct <FindRunner>d__14 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<NetworkRunner> <>t__builder; //Field offset: 0x8
		public HardwareRig <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum RunnerExpectations
	{
		NoRunner = 0,
		PresetRunner = 1,
		DetectRunner = 2,
	}

	public HardwareHand leftHand; //Field offset: 0x20
	public HardwareHand rightHand; //Field offset: 0x28
	public HardwareHeadset headset; //Field offset: 0x30
	public NetworkRunner runner; //Field offset: 0x38
	public RunnerExpectations runnerExpectations; //Field offset: 0x40
	private bool searchingForRunner; //Field offset: 0x44
	[Header("Input interpolation")]
	public bool useInputInterpolation; //Field offset: 0x45
	public float interpolationDelay; //Field offset: 0x48
	private XRHeadsetInputDevice headsetInputDevice; //Field offset: 0x50
	private XRControllerInputDevice leftHandInputDevice; //Field offset: 0x58
	private XRControllerInputDevice rightHandInputDevice; //Field offset: 0x60

	public float InterpolationDelay
	{
		 get { } //Length: 8
	}

	public HardwareRig() { }

	protected override void Awake() { }

	[IteratorStateMachine(typeof(<FadedRotate>d__21))]
	public override IEnumerator FadedRotate(float angle) { }

	[IteratorStateMachine(typeof(<FadedTeleport>d__20))]
	public override IEnumerator FadedTeleport(Vector3 position) { }

	[AsyncStateMachine(typeof(<FindRunner>d__14))]
	public Task<NetworkRunner> FindRunner() { }

	public float get_InterpolationDelay() { }

	public override void OnConnectedToServer(NetworkRunner runner) { }

	public override void OnConnectFailed(NetworkRunner runner, NetAddress remoteAddress, NetConnectFailedReason reason) { }

	public override void OnConnectRequest(NetworkRunner runner, ConnectRequest request, Byte[] token) { }

	public override void OnCustomAuthenticationResponse(NetworkRunner runner, Dictionary<String, Object> data) { }

	private void OnDestroy() { }

	public override void OnDisconnectedFromServer(NetworkRunner runner, NetDisconnectReason reason) { }

	public override void OnHostMigration(NetworkRunner runner, HostMigrationToken hostMigrationToken) { }

	public override void OnInput(NetworkRunner runner, NetworkInput input) { }

	public override void OnInputMissing(NetworkRunner runner, PlayerRef player, NetworkInput input) { }

	public override void OnObjectEnterAOI(NetworkRunner runner, NetworkObject obj, PlayerRef player) { }

	public override void OnObjectExitAOI(NetworkRunner runner, NetworkObject obj, PlayerRef player) { }

	public override void OnPlayerJoined(NetworkRunner runner, PlayerRef player) { }

	public override void OnPlayerLeft(NetworkRunner runner, PlayerRef player) { }

	public override void OnReliableDataProgress(NetworkRunner runner, PlayerRef player, ReliableKey key, float progress) { }

	public void OnReliableDataReceived(NetworkRunner runner, PlayerRef player, ArraySegment<Byte> data) { }

	public override void OnReliableDataReceived(NetworkRunner runner, PlayerRef player, ReliableKey key, ArraySegment<Byte> data) { }

	public override void OnSceneLoadDone(NetworkRunner runner) { }

	public override void OnSceneLoadStart(NetworkRunner runner) { }

	public override void OnSessionListUpdated(NetworkRunner runner, List<SessionInfo> sessionList) { }

	public override void OnShutdown(NetworkRunner runner, ShutdownReason shutdownReason) { }

	public override void OnUserSimulationMessage(NetworkRunner runner, SimulationMessagePtr message) { }

	public override void Rotate(float angle) { }

	public void StartWithRunner(NetworkRunner runner) { }

	public override void Teleport(Vector3 position) { }

}

