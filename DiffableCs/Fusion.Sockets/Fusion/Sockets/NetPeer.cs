namespace Fusion.Sockets;

public struct NetPeer
{
	public const int DEFAULT_HEADERS = 144; //Field offset: 0x0
	public const int MAX_MTU_BYTES_TOTAL = 1280; //Field offset: 0x0
	public const int MAX_MTU_BYTES_PAYLOAD = 1136; //Field offset: 0x0
	public const int MAX_MTU_BITS_PAYLOAD = 9088; //Field offset: 0x0
	public const int MAX_PACKET_BYTES_PAYLOAD = 44880; //Field offset: 0x0
	public const int MAX_PACKET_BYTES_TOTAL = 51200; //Field offset: 0x0
	internal const int FRAG_MAX_COUNT = 40; //Field offset: 0x0
	internal const byte FRAG_END_BIT = 128; //Field offset: 0x0
	private const int STATE_RUNNING = 0; //Field offset: 0x0
	private const int STATE_SHUTDOWN = 2; //Field offset: 0x0
	private int _state; //Field offset: 0x0
	private NetConfig _config; //Field offset: 0x8
	private Timer _recvTimer; //Field offset: 0x100
	private Byte* _fragmentBuffer; //Field offset: 0x118
	internal NetSocket _socket; //Field offset: 0x120
	private NetAddress _address; //Field offset: 0x128
	private NetBitBufferStack _sendStack; //Field offset: 0x140
	private NetPeerGroup* _groups; //Field offset: 0x158
	private NetPeerGroupMap* _groupsMap; //Field offset: 0x160
	private Int32* _groupsAssigned; //Field offset: 0x168
	private NetCommandRefused* _refusedCommand; //Field offset: 0x170
	private NetBitBuffer* _recv; //Field offset: 0x178
	private NetBitBufferBlock* _recvBlock; //Field offset: 0x180

	public NetAddress Address
	{
		 get { } //Length: 24
	}

	public NetConfig Config
	{
		 get { } //Length: 16
	}

	public int GroupCount
	{
		 get { } //Length: 8
	}

	public bool IsShutdown
	{
		 get { } //Length: 28
	}

	public static void Destroy(NetPeer* p, INetSocket socket, INetPeerGroupCallbacks callbacks) { }

	private static void DestroySocket(NetPeer* p, INetSocket socket, INetPeerGroupCallbacks callbacks) { }

	private static short FindGroupWithLeastAssignedAddresses(NetPeer* p) { }

	public NetAddress get_Address() { }

	public NetConfig get_Config() { }

	public int get_GroupCount() { }

	public bool get_IsShutdown() { }

	public static NetConfig* GetConfigPointer(NetPeer* p) { }

	public static NetPeerGroup* GetGroup(NetPeer* p, int index) { }

	public static NetPeer* Initialize(NetConfig config, INetSocket socket) { }

	public static void Initialize(NetPeer* p, NetConfig config, INetSocket socket) { }

	public static void Recv(NetPeer* p, INetSocket socket, Random rng) { }

	public static void Recv(NetPeer* p, INetSocket socket, Boolean* work, Random rng) { }

	private static bool RecvBufferAvailable(NetPeer* p) { }

	private static void RecvBufferPushToGroup(NetPeer* p, INetSocket socket, Random rng) { }

	private static bool RecvExpired(NetPeer* p) { }

	private static void RecvInternal(NetPeer* p, INetSocket socket, Boolean* work, Random rng) { }

	public static void RemapAddress(NetPeer* p, NetAddress oldAddress, NetAddress newAddress) { }

	public static void Send(NetPeer* p, INetSocket socket, Boolean* work) { }

	public static void Send(NetPeer* p, INetSocket socket) { }

	private static void SendFromStack(NetPeer* p, INetSocket socket, Boolean* work) { }

	private static void SendInternal(NetPeer* p, INetSocket socket, Boolean* work) { }

	public static void Update(NetPeer* p, INetSocket socket, Boolean* work, Random rng) { }

	public static void Update(NetPeer* p, INetSocket socket, Random rng) { }

}

