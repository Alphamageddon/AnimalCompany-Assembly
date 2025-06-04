namespace Fusion.Sockets;

public struct NetAddress : IEquatable<NetAddress>
{
	internal sealed class EqualityComparer : IEqualityComparer<NetAddress>
	{

		public EqualityComparer() { }

		public override bool Equals(NetAddress x, NetAddress y) { }

		public override int GetHashCode(NetAddress obj) { }

	}

	public static class SubnetMask
	{
		[CompilerGenerated]
		private static NetAddress[] <SubnetMasks>k__BackingField; //Field offset: 0x0

		public private static NetAddress[] SubnetMasks
		{
			[CompilerGenerated]
			 get { } //Length: 88
			[CompilerGenerated]
			private set { } //Length: 92
		}

		private static SubnetMask() { }

		[CompilerGenerated]
		public static NetAddress[] get_SubnetMasks() { }

		public static NetAddress GetNetworkAddress(NetAddress netAddress, NetAddress subnetMask) { }

		public static bool IsSameSubNet(NetAddress addressA, NetAddress addressB) { }

		[CompilerGenerated]
		private static void set_SubnetMasks(NetAddress[] value) { }

	}

	internal static NetAddress AnyIPv4Addr; //Field offset: 0x0
	internal static NetAddress AnyIPv6Addr; //Field offset: 0x18
	internal Address NativeAddress; //Field offset: 0x0
	internal ulong Block0; //Field offset: 0x0
	internal ulong Block1; //Field offset: 0x8
	internal ulong Block2; //Field offset: 0x10
	private int _actorId; //Field offset: 0x14

	public int ActorId
	{
		 get { } //Length: 12
	}

	public bool HasAddress
	{
		 get { } //Length: 204
	}

	public bool IsIPv4
	{
		 get { } //Length: 116
	}

	public bool IsIPv6
	{
		 get { } //Length: 132
	}

	public bool IsRelayAddr
	{
		 get { } //Length: 92
	}

	public bool IsValid
	{
		 get { } //Length: 220
	}

	private static NetAddress() { }

	public static NetAddress Any(ushort port = 0) { }

	public static NetAddress AnyIPv6(ushort port = 0) { }

	public static NetAddress CreateFromIpPort(string ip, ushort port) { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(NetAddress other) { }

	public static NetAddress FromActorId(int actorId) { }

	public int get_ActorId() { }

	public bool get_HasAddress() { }

	public bool get_IsIPv4() { }

	public bool get_IsIPv6() { }

	public bool get_IsRelayAddr() { }

	public bool get_IsValid() { }

	public virtual int GetHashCode() { }

	internal static ulong Hash64(NetAddress address) { }

	public static NetAddress LocalhostIPv4(ushort port = 0) { }

	public static NetAddress LocalhostIPv6(ushort port = 0) { }

	internal void Serialize(BitStream stream) { }

	public virtual string ToString() { }

}

