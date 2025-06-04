namespace Fusion;

internal static class FusionRealtimeProxy
{
	[CompilerGenerated]
	private sealed class <GetEnabledRegions>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x10
		public AsyncTaskMethodBuilder<List`1<RegionInfo>> <>t__builder; //Field offset: 0x18
		public string appId; //Field offset: 0x30
		public CancellationToken cancellationToken; //Field offset: 0x38
		private PhotonAppSettings <global>5__1; //Field offset: 0x40
		private LoadBalancingClient <client>5__2; //Field offset: 0x48
		private RegionHandler <regionHandler>5__3; //Field offset: 0x50
		private List<RegionInfo> <list>5__4; //Field offset: 0x58
		private List<RegionInfo> <>s__5; //Field offset: 0x60
		private RegionHandler <>s__6; //Field offset: 0x68
		private Enumerator<Region> <>s__7; //Field offset: 0x70
		private Region <region>5__8; //Field offset: 0x88
		private TaskAwaiter<List`1<RegionInfo>> <>u__1; //Field offset: 0x90
		private TaskAwaiter<RegionHandler> <>u__2; //Field offset: 0x98
		private TaskAwaiter <>u__3; //Field offset: 0xA0

		public <GetEnabledRegions>d__3() { }

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const float REGION_INFO_CACHE_TIME = 10; //Field offset: 0x0
	private static float _lastRegionRequestTime; //Field offset: 0x0
	private static List<RegionInfo> _cachedRegionInfo; //Field offset: 0x8

	[AsyncStateMachine(typeof(<GetEnabledRegions>d__3))]
	[DebuggerStepThrough]
	internal static Task<List`1<RegionInfo>> GetEnabledRegions(string appId, CancellationToken cancellationToken) { }

}

