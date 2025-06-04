namespace Fusion.Sockets.Stun;

internal static class StunServers
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<String, String> <>9__6_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <SetupStunServers>b__6_0(string s) { }

	}

	[CompilerGenerated]
	private struct <ResolveStunServerInfo>d__7 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<StunServer> <>t__builder; //Field offset: 0x8
		public string stunServerAddress; //Field offset: 0x20
		private ushort <port>5__2; //Field offset: 0x28
		private StunServer <stunServer>5__3; //Field offset: 0x30
		private TaskAwaiter<IPAddress[]> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SetupStunServers>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string customStunServer; //Field offset: 0x20
		private HashSet<StunServer> <stunServers>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30
		private String[] <>7__wrap2; //Field offset: 0x38
		private int <>7__wrap3; //Field offset: 0x40
		private TaskAwaiter<StunServer> <>u__2; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal class StunServer
	{
		private sealed class Pv4AddrEqualityComparer : IEqualityComparer<StunServer>
		{

			public Pv4AddrEqualityComparer() { }

			public override bool Equals(StunServer x, StunServer y) { }

			public override int GetHashCode(StunServer obj) { }

		}

		[CompilerGenerated]
		private static readonly IEqualityComparer<StunServer> <StunServerEqualityComparer>k__BackingField; //Field offset: 0x0
		public NetAddress IPv4Addr; //Field offset: 0x10
		public NetAddress IPv6Addr; //Field offset: 0x28

		public bool HasIPv4Support
		{
			 get { } //Length: 88
		}

		public bool HasIPv6Support
		{
			 get { } //Length: 88
		}

		public static IEqualityComparer<StunServer> StunServerEqualityComparer
		{
			[CompilerGenerated]
			 get { } //Length: 88
		}

		private static StunServer() { }

		public StunServer() { }

		public bool get_HasIPv4Support() { }

		public bool get_HasIPv6Support() { }

		[CompilerGenerated]
		public static IEqualityComparer<StunServer> get_StunServerEqualityComparer() { }

		public virtual string ToString() { }

	}

	private static readonly String[] DefaultStunServerList; //Field offset: 0x0
	private static StunServer[] _stunServers; //Field offset: 0x8
	private static bool _runningResolution; //Field offset: 0x10

	private static StunServers() { }

	public static List<StunServer> GetStunServer(bool IPv6Support) { }

	[AsyncStateMachine(typeof(<ResolveStunServerInfo>d__7))]
	private static Task<StunServer> ResolveStunServerInfo(string stunServerAddress) { }

	[AsyncStateMachine(typeof(<SetupStunServers>d__6))]
	public static Task SetupStunServers(string customStunServer = null) { }

}

