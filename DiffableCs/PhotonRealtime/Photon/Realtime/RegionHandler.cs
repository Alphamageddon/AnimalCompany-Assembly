namespace Photon.Realtime;

public class RegionHandler
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<Region> <>9__8_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <get_BestRegion>b__8_0(Region a, Region b) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass31_0
	{
		public string prevBestRegionCode; //Field offset: 0x10

		public <>c__DisplayClass31_0() { }

		internal bool <PingMinimumOfRegions>b__0(Region r) { }

	}

	public static Type PingImplementation; //Field offset: 0x0
	protected private static ushort PortToPingOverride; //Field offset: 0x8
	[CompilerGenerated]
	private List<Region> <EnabledRegions>k__BackingField; //Field offset: 0x10
	private string availableRegionCodes; //Field offset: 0x18
	private Region bestRegionCache; //Field offset: 0x20
	private readonly List<RegionPinger> pingerList; //Field offset: 0x28
	private Action<RegionHandler> onCompleteCall; //Field offset: 0x30
	private int previousPing; //Field offset: 0x38
	private string previousSummaryProvided; //Field offset: 0x40
	private float rePingFactor; //Field offset: 0x48
	private float pingSimilarityFactor; //Field offset: 0x4C
	public int BestRegionSummaryPingLimit; //Field offset: 0x50
	[CompilerGenerated]
	private bool <IsPinging>k__BackingField; //Field offset: 0x54
	[CompilerGenerated]
	private bool <Aborted>k__BackingField; //Field offset: 0x55
	private MonoBehaviourEmpty emptyMonoBehavior; //Field offset: 0x58

	public private bool Aborted
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public Region BestRegion
	{
		 get { } //Length: 744
	}

	public private List<Region> EnabledRegions
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private bool IsPinging
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public string SummaryToCache
	{
		 get { } //Length: 352
	}

	public RegionHandler(ushort masterServerPortOverride = 0) { }

	public void Abort() { }

	[CompilerGenerated]
	public bool get_Aborted() { }

	public Region get_BestRegion() { }

	[CompilerGenerated]
	public List<Region> get_EnabledRegions() { }

	[CompilerGenerated]
	public bool get_IsPinging() { }

	public string get_SummaryToCache() { }

	public string GetResults() { }

	private void OnPreferredRegionPinged(Region preferredRegion) { }

	private void OnRegionDone(Region region) { }

	private bool PingEnabledRegions() { }

	public bool PingMinimumOfRegions(Action<RegionHandler> onCompleteCallback, string previousSummary) { }

	[CompilerGenerated]
	private void set_Aborted(bool value) { }

	[CompilerGenerated]
	protected private void set_EnabledRegions(List<Region> value) { }

	[CompilerGenerated]
	private void set_IsPinging(bool value) { }

	public void SetRegions(OperationResponse opGetRegions) { }

}

