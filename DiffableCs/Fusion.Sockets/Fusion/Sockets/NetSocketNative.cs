namespace Fusion.Sockets;

internal class NetSocketNative : INetSocket
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<Byte> <>9__15_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <SetupEncryption>b__15_0(byte b) { }

	}

	private const int EncryptionBufferLength = 2048; //Field offset: 0x0
	private EncryptionManager<NetAddress, DataEncryptor> _encryptionManager; //Field offset: 0x10
	private EncryptionToken _encryptionToken; //Field offset: 0x18
	private NetAddress _remoteEncryptionHandler; //Field offset: 0x20
	private Byte* _encryptionBuffer; //Field offset: 0x38

	public override bool SupportsMultiThreading
	{
		 get { } //Length: 8
	}

	public NetSocketNative() { }

	public override NetAddress Bind(NetSocket socket, NetConfig config) { }

	public override bool CanFragment(NetAddress address) { }

	public override NetSocket Create(NetConfig config) { }

	public override void DeleteEncryptionKey(NetAddress address) { }

	public override void Destroy(NetSocket netSocket) { }

	public override bool get_SupportsMultiThreading() { }

	private bool HandleEncryptionIngoing(NetAddress* address, ref Byte* buffer, int bufferLength, ref int received) { }

	private bool HandleEncryptionOutgoing(NetAddress* address, ref Byte* buffer, ref int bufferLength) { }

	public override void Initialize(NetConfig config) { }

	public override bool Poll(NetSocket socket, long timeout) { }

	public override int Receive(NetSocket socket, NetAddress* address, Byte* buffer, int bufferLength) { }

	private void ResetEncryption() { }

	public override int Send(NetSocket socket, NetAddress* address, Byte* buffer, int bufferLength) { }

	public override void SetupEncryption(Byte[] key, Byte[] encryptedKey) { }

}

