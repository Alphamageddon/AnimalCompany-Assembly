namespace Oculus.Platform;

public sealed class Packet : IDisposable
{
	private readonly ulong size; //Field offset: 0x10
	private readonly IntPtr packetHandle; //Field offset: 0x18

	public ulong SenderID
	{
		 get { } //Length: 88
	}

	public ulong Size
	{
		 get { } //Length: 8
	}

	public Packet(IntPtr packetHandle) { }

	public override void Dispose() { }

	protected virtual void Finalize() { }

	public ulong get_SenderID() { }

	public ulong get_Size() { }

	public ulong ReadBytes(Byte[] destination) { }

}

