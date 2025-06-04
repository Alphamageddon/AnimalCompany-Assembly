namespace Fusion;

public sealed class NetworkRunnerUpdaterDefault : INetworkRunnerUpdater
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<NetworkRunner> <>9__11_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <InvokeRender>b__11_0(NetworkRunner x) { }

	}

	internal struct NetworkRunnerRender
	{

	}

	internal struct NetworkRunnerUpdate
	{

	}

	private class PlayerLoopSystemRegistration : IDisposable
	{
		public NetworkRunnerUpdaterDefaultInvokeSettings UpdateSettings; //Field offset: 0x10
		public NetworkRunnerUpdaterDefaultInvokeSettings RenderSettings; //Field offset: 0x20

		public PlayerLoopSystemRegistration(NetworkRunnerUpdaterDefaultInvokeSettings updateSettings, NetworkRunnerUpdaterDefaultInvokeSettings renderSettings) { }

		public override void Dispose() { }

	}

	private static List<NetworkRunner> _instances; //Field offset: 0x0
	private static int _instanceCount; //Field offset: 0x8
	private static PlayerLoopSystemRegistration _registration; //Field offset: 0x10
	public NetworkRunnerUpdaterDefaultInvokeSettings UpdateSettings; //Field offset: 0x10
	public NetworkRunnerUpdaterDefaultInvokeSettings RenderSettings; //Field offset: 0x20

	private static NetworkRunnerUpdaterDefault() { }

	public NetworkRunnerUpdaterDefault() { }

	[RuntimeInitializeOnLoadMethod]
	private static void ClearStatics() { }

	private override void Fusion.INetworkRunnerUpdater.Initialize(NetworkRunner runner) { }

	private override void Fusion.INetworkRunnerUpdater.Shutdown(NetworkRunner runner) { }

	private static void InvokeRender() { }

	private static void InvokeUpdate() { }

	public static bool RegisterInPlayerLoop(NetworkRunnerUpdaterDefaultInvokeSettings updateSettings, NetworkRunnerUpdaterDefaultInvokeSettings renderSettings) { }

	public static bool UnregisterFromPlayerLoop() { }

}

