namespace Fusion.Photon.Realtime.Async;

[Extension]
internal static class LoadBalancingClientAsyncExtensions
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_0
	{
		public OperationHandler handler; //Field offset: 0x10
		public TaskCompletionSource<RegionHandler> result; //Field offset: 0x18
		public CancellationToken externalCancelationToken; //Field offset: 0x20
		public Action<RegionHandler> <>9__2; //Field offset: 0x28

		public <>c__DisplayClass1_0() { }

		internal void <GetRegionsAsync>b__0(DisconnectCause cause) { }

		internal void <GetRegionsAsync>b__1(RegionHandler regionHandler) { }

		internal void <GetRegionsAsync>b__2(RegionHandler regionHandlerWithPing) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public LoadBalancingClient client; //Field offset: 0x10
		public OperationHandler handler; //Field offset: 0x18

		public <>c__DisplayClass11_0() { }

		internal Task <CreateOpHandler>b__0(CancellationToken token) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		public CancellationToken token; //Field offset: 0x10
		public LoadBalancingClient client; //Field offset: 0x18
		public TaskCompletionSource<Int16> completionSource; //Field offset: 0x20

		public <>c__DisplayClass12_0() { }

		internal Task<Boolean> <Service_ClientUpdate>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public OperationHandler handler; //Field offset: 0x10

		public <>c__DisplayClass4_0() { }

		internal void <DisconnectAsync>b__0(DisconnectCause cause) { }

	}

	private const int SERVICE_INTERVAL_MS = 10; //Field offset: 0x0

	[Extension]
	public static Task ConnectUsingSettingsAsync(LoadBalancingClient client, AppSettings appSettings, bool createServiceTask = true, CancellationToken externalCancellationToken = null) { }

	[Extension]
	public static OperationHandler CreateOpHandler(LoadBalancingClient client, bool throwOnErrors = true, bool createServiceTask = true, CancellationToken externalCancellationToken = null) { }

	[Extension]
	public static Task<Int16> CreateOrJoinRoomAsync(LoadBalancingClient client, EnterRoomParams enterRoomParams, bool throwOnError = true, bool createServiceTask = true, CancellationToken externalCancellationToken = null) { }

	[Extension]
	public static Task<Int16> CreateRoomAsync(LoadBalancingClient client, EnterRoomParams enterRoomParams, bool throwOnError = true, bool createServiceTask = true, CancellationToken externalCancellationToken = null) { }

	[Extension]
	public static Task DisconnectAsync(LoadBalancingClient client, bool createServiceTask = true, CancellationToken externalCancellationToken = null) { }

	[Extension]
	public static Task<RegionHandler> GetRegionsAsync(LoadBalancingClient client, bool throwOnError = true, bool createServiceTask = true, CancellationToken externalCancelationToken = null) { }

	[Extension]
	public static Task<Int16> JoinLobbyAsync(LoadBalancingClient client, TypedLobby lobby, bool throwOnError = true, bool createServiceTask = true, CancellationToken externalCancelationToken = null) { }

	[Extension]
	public static Task<Int16> JoinRandomOrCreateRoomAsync(LoadBalancingClient client, OpJoinRandomRoomParams joinRandomRoomParams, EnterRoomParams enterRoomParams, bool throwOnError = true, bool createServiceTask = true, CancellationToken externalCancellationToken = null) { }

	[Extension]
	public static Task<Int16> JoinRandomRoomAsync(LoadBalancingClient client, OpJoinRandomRoomParams joinRandomRoomParams, bool throwOnError = true, bool createServiceTask = true, CancellationToken externalCancellationToken = null) { }

	[Extension]
	public static Task<Int16> JoinRoomAsync(LoadBalancingClient client, EnterRoomParams enterRoomParams, bool throwOnError = true, bool createServiceTask = true, CancellationToken externalCancellationToken = null) { }

	[Extension]
	public static Task ReconnectAndRejoinAsync(LoadBalancingClient client, bool throwOnError = true, bool createServiceTask = true, CancellationToken externalCancellationToken = null) { }

	[Extension]
	public static void Service_ClientUpdate(LoadBalancingClient client, CancellationToken token, TaskCompletionSource<Int16> completionSource) { }

}

