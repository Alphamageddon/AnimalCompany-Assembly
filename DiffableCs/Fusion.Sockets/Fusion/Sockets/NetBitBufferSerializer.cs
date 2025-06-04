namespace Fusion.Sockets;

public struct NetBitBufferSerializer
{
	private bool _write; //Field offset: 0x0
	private NetBitBuffer* _buffer; //Field offset: 0x8

	public NetBitBuffer* Buffer
	{
		 get { } //Length: 8
	}

	public bool Reading
	{
		 get { } //Length: 16
	}

	public bool Writing
	{
		 get { } //Length: 8
	}

	private NetBitBufferSerializer(NetBitBuffer* buffer, bool write) { }

	public bool Check(bool value) { }

	public NetBitBuffer* get_Buffer() { }

	public bool get_Reading() { }

	public bool get_Writing() { }

	public static NetBitBufferSerializer Reader(NetBitBuffer* buffer) { }

	public void Serialize(ref float value) { }

	public void Serialize(ref byte value) { }

	public void Serialize(ref bool value) { }

	public void Serialize(ref int value) { }

	public void Serialize(ref uint value) { }

	public void Serialize(ref ulong value) { }

	public void Serialize(ref string value) { }

	public static NetBitBufferSerializer Writer(NetBitBuffer* buffer) { }

}

