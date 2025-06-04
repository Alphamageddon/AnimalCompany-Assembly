namespace Fusion.Sockets.Stun;

internal static class StunClient
{
	[CompilerGenerated]
	private struct <QueryReflexiveInfo>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<StunResult> <>t__builder; //Field offset: 0x8
		public NetAddress boundLocalAddress; //Field offset: 0x20
		public Nullable<NetAddress> customPublicAddress; //Field offset: 0x38
		public string customStunServer; //Field offset: 0x58
		public bool extendedAttempts; //Field offset: 0x60
		public Func<Byte[], NetAddress, Boolean> sendDataViaSocket; //Field offset: 0x68
		public Func<Boolean> keepRunning; //Field offset: 0x70
		private AddressFamily <localAddressFamily>5__2; //Field offset: 0x78
		private NetAddress <localAddress>5__3; //Field offset: 0x80
		private NetAddress <publicAddr1>5__4; //Field offset: 0x98
		private NetAddress <publicAddr2>5__5; //Field offset: 0xB0
		private int <stunTimeout>5__6; //Field offset: 0xC8
		private Guid <requestID>5__7; //Field offset: 0xCC
		private Stopwatch <queryWatch>5__8; //Field offset: 0xE0
		private Stopwatch <attemptWatch>5__9; //Field offset: 0xE8
		private TaskAwaiter <>u__1; //Field offset: 0xF0
		private bool <skipNATDiscovery>5__10; //Field offset: 0xF8

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static class TestIPs
	{
		public static readonly IPEndPoint TestNetIpv4; //Field offset: 0x0
		public static readonly IPEndPoint TestNetIpv6; //Field offset: 0x8

		private static TestIPs() { }

	}

	private static readonly ConcurrentDictionary<Guid, ConcurrentDictionary`2<Int32, NetAddress>> PendingRequests; //Field offset: 0x0

	private static StunClient() { }

	private static bool GetLocalAddress(ref AddressFamily addressFamily, out IPAddress localIP) { }

	private static bool QueryLocalAddress(NetAddress boundLocalAddress, out AddressFamily addressFamily, out NetAddress localAddress) { }

	private static bool QueryPublicAddress(Func<Byte[], NetAddress, Boolean> sendAnyData, AddressFamily originalFamily, ref Guid requestID, out bool skipNATDiscovery) { }

	[AsyncStateMachine(typeof(<QueryReflexiveInfo>d__3))]
	public static Task<StunResult> QueryReflexiveInfo(NetAddress boundLocalAddress, Func<Byte[], NetAddress, Boolean> sendDataViaSocket, Nullable<NetAddress> customPublicAddress, string customStunServer = null, bool extendedAttempts = false, Func<Boolean> keepRunning = null) { }

	public static void Reset() { }

	public static bool TryParseAndStoreStunMessage(NetAddress* origin, Byte* buffer, int bufferLength) { }

}

