namespace Fusion.Photon.Realtime;

internal class ConnectionHandler : MonoBehaviour
{
	public static bool AppQuits; //Field offset: 0x0
	public static bool AppPause; //Field offset: 0x1
	public static bool AppPauseRecent; //Field offset: 0x2
	public static bool AppOutOfFocus; //Field offset: 0x3
	public static bool AppOutOfFocusRecent; //Field offset: 0x4
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private LoadBalancingClient <Client>k__BackingField; //Field offset: 0x20
	public bool DisconnectAfterKeepAlive; //Field offset: 0x28
	public int KeepAliveInBackground; //Field offset: 0x2C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <CountSendAcksOnly>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <FallbackThreadRunning>k__BackingField; //Field offset: 0x34
	public bool ApplyDontDestroyOnLoad; //Field offset: 0x35
	private bool didSendAcks; //Field offset: 0x36
	private readonly Stopwatch backgroundStopwatch; //Field offset: 0x38
	private Timer stateTimer; //Field offset: 0x40

	public LoadBalancingClient Client
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public private int CountSendAcksOnly
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private bool FallbackThreadRunning
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public ConnectionHandler() { }

	protected override void Awake() { }

	[CompilerGenerated]
	public LoadBalancingClient get_Client() { }

	[CompilerGenerated]
	public int get_CountSendAcksOnly() { }

	[CompilerGenerated]
	public bool get_FallbackThreadRunning() { }

	public static bool IsNetworkReachableUnity() { }

	public void OnApplicationFocus(bool focus) { }

	public void OnApplicationPause(bool pause) { }

	public void OnApplicationQuit() { }

	protected override void OnDisable() { }

	public void RealtimeFallback(object state = null) { }

	public void RealtimeFallbackInvoke() { }

	private void ResetAppOutOfFocusRecent() { }

	private void ResetAppPauseRecent() { }

	[CompilerGenerated]
	public void set_Client(LoadBalancingClient value) { }

	[CompilerGenerated]
	private void set_CountSendAcksOnly(int value) { }

	[CompilerGenerated]
	private void set_FallbackThreadRunning(bool value) { }

	public void StartFallbackSendAckThread() { }

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::SubsystemRegistration (4))]
	private static void StaticReset() { }

	public void StopFallbackSendAckThread() { }

}

