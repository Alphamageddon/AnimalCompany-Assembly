namespace ExitGames.Client.Photon;

public abstract class IPhotonSocket
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<IPAddress, String> <>9__59_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <GetIpAddresses>b__59_0(IPAddress x) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static string <ServerIpAddress>k__BackingField; //Field offset: 0x0
	protected private PeerBase peerBase; //Field offset: 0x10
	protected readonly ConnectionProtocol Protocol; //Field offset: 0x18
	public bool PollReceive; //Field offset: 0x19
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private PhotonSocketState <State>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <SocketErrorCode>k__BackingField; //Field offset: 0x20
	public string ConnectAddress; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private string <ServerAddress>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private string <ProxyServerAddress>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <ServerPort>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <AddressResolvedAsIpv6>k__BackingField; //Field offset: 0x44
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private string <UrlProtocol>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private string <UrlPath>k__BackingField; //Field offset: 0x50

	public private bool AddressResolvedAsIpv6
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public bool Connected
	{
		 get { } //Length: 16
	}

	protected IPhotonPeerListener Listener
	{
		 get { } //Length: 36
	}

	protected private int MTU
	{
		private get { } //Length: 36
	}

	public string ProxyServerAddress
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	protected private string SerializationProtocol
	{
		private get { } //Length: 284
	}

	public string ServerAddress
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public static string ServerIpAddress
	{
		[CompilerGenerated]
		 get { } //Length: 72
		[CompilerGenerated]
		 set { } //Length: 76
	}

	public int ServerPort
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public int SocketErrorCode
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public PhotonSocketState State
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public string UrlPath
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public string UrlProtocol
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public IPhotonSocket(PeerBase peerBase) { }

	[CompilerGenerated]
	private void <HandleException>b__56_0() { }

	private int AddressSortComparer(IPAddress x, IPAddress y) { }

	public override bool Connect() { }

	public abstract bool Disconnect() { }

	public void EnqueueDebugReturn(DebugLevel debugLevel, string message) { }

	[CompilerGenerated]
	public bool get_AddressResolvedAsIpv6() { }

	public bool get_Connected() { }

	protected IPhotonPeerListener get_Listener() { }

	protected private int get_MTU() { }

	[CompilerGenerated]
	public string get_ProxyServerAddress() { }

	protected private string get_SerializationProtocol() { }

	[CompilerGenerated]
	public string get_ServerAddress() { }

	[CompilerGenerated]
	public static string get_ServerIpAddress() { }

	[CompilerGenerated]
	public int get_ServerPort() { }

	[CompilerGenerated]
	public int get_SocketErrorCode() { }

	[CompilerGenerated]
	public PhotonSocketState get_State() { }

	[CompilerGenerated]
	public string get_UrlPath() { }

	[CompilerGenerated]
	public string get_UrlProtocol() { }

	[Obsolete("Use GetIpAddresses instead.")]
	protected private static IPAddress GetIpAddress(string address) { }

	protected private IPAddress[] GetIpAddresses(string hostname) { }

	protected private void HandleException(StatusCode statusCode) { }

	public void HandleReceivedDatagram(Byte[] inBuffer, int length, bool willBeReused) { }

	private bool IpAddressTryParse(string strIP, out IPAddress address) { }

	public abstract PhotonSocketError Receive(out Byte[] data) { }

	public bool ReportDebugOfLevel(DebugLevel levelOfMessage) { }

	public abstract PhotonSocketError Send(Byte[] data, int length) { }

	[CompilerGenerated]
	protected private void set_AddressResolvedAsIpv6(bool value) { }

	[CompilerGenerated]
	protected void set_ProxyServerAddress(string value) { }

	[CompilerGenerated]
	protected void set_ServerAddress(string value) { }

	[CompilerGenerated]
	protected static void set_ServerIpAddress(string value) { }

	[CompilerGenerated]
	protected void set_ServerPort(int value) { }

	[CompilerGenerated]
	protected void set_SocketErrorCode(int value) { }

	[CompilerGenerated]
	protected void set_State(PhotonSocketState value) { }

	[CompilerGenerated]
	protected void set_UrlPath(string value) { }

	[CompilerGenerated]
	protected void set_UrlProtocol(string value) { }

	protected private bool TryParseAddress(string url, out string address, out ushort port, out string urlProtocol, out string urlPath) { }

}

