namespace Fusion.Sockets;

public struct NetConnectionId : IEquatable<NetConnectionId>
{
	internal class EqualityComparer : IEqualityComparer<NetConnectionId>
	{

		public EqualityComparer() { }

		public override bool Equals(NetConnectionId x, NetConnectionId y) { }

		public override int GetHashCode(NetConnectionId obj) { }

	}

	internal ulong Raw; //Field offset: 0x0
	public short Group; //Field offset: 0x0
	public short GroupIndex; //Field offset: 0x2
	internal uint Generation; //Field offset: 0x4

	public override bool Equals(NetConnectionId other) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(NetConnectionId a, NetConnectionId b) { }

	public static bool op_Inequality(NetConnectionId a, NetConnectionId b) { }

}

