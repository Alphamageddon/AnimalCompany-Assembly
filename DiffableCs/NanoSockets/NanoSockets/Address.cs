namespace NanoSockets;

public struct Address : IEquatable<Address>
{
	public ulong _address0; //Field offset: 0x0
	public ulong _address1; //Field offset: 0x8
	public ushort Port; //Field offset: 0x10

	public static Address Any(ushort port = 0) { }

	public static Address CreateFromIpPort(string ip, ushort port) { }

	public override bool Equals(Address other) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	public static Address LocalhostIPv4(ushort port = 0) { }

	public virtual string ToString() { }

}

