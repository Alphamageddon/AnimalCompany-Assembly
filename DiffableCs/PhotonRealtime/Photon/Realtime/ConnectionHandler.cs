namespace Photon.Realtime;

public class ConnectionHandler : MonoBehaviour
{
	public static bool AppQuits; //Field offset: 0x0
	public static bool AppPause; //Field offset: 0x1
	public static bool AppPauseRecent; //Field offset: 0x2
	public static bool AppOutOfFocus; //Field offset: 0x3
	public static bool AppOutOfFocusRecent; //Field offset: 0x4
	[CompilerGenerated]
	private LoadBalancingClient <Client>k__BackingField; //Field offset: 0x20
	public bool DisconnectAfterKeepAlive; //Field offset: 0x28
	public int KeepAliveInBackground; //Field offset: 0x2C
	[CompilerGenerated]
	private int <CountSendAcksOnly>k__BackingField; //Field offset: 0x30
	public bool ApplyDontDestroyOnLoad; //Field offset: 0x34
	private byte fallbackThreadId; //Field offset: 0x35
	private bool didSendAcks; //Field offset: 0x36
	private readonly Stopwatch backgroundStopwatch; //Field offset: 0x38

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

	public bool FallbackThreadRunning
	{
		 get { } //Length: 16
	}

	public ConnectionHandler() { }

	protected override void Awake() { }

	[CompilerGenerated]
	public LoadBalancingClient get_Client() { }

	[CompilerGenerated]
	public int get_CountSendAcksOnly() { }

	public bool get_FallbackThreadRunning() { }

	public static bool IsNetworkReachableUnity() { }

	public void OnApplicationFocus(bool focus) { }

	public void OnApplicationPause(bool pause) { }

	public void OnApplicationQuit() { }

	protected override void OnDisable() { }

	public bool RealtimeFallbackThread() { }

	private void ResetAppOutOfFocusRecent() { }

	private void ResetAppPauseRecent() { }

	[CompilerGenerated]
	public void set_Client(LoadBalancingClient value) { }

	[CompilerGenerated]
	private void set_CountSendAcksOnly(int value) { }

	public void StartFallbackSendAckThread() { }

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::SubsystemRegistration (4))]
	private static void StaticReset() { }

	public void StopFallbackSendAckThread() { }

}

