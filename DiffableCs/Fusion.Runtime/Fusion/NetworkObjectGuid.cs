namespace Fusion;

[NetworkStructWeaved(4)]
public struct NetworkObjectGuid : INetworkStruct, IEquatable<NetworkObjectGuid>, IComparable<NetworkObjectGuid>
{
	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <RawGuidValue>e__FixedBuffer
	{
		public long FixedElementField; //Field offset: 0x0

	}

	internal sealed class EqualityComparer : IEqualityComparer<NetworkObjectGuid>
	{

		public EqualityComparer() { }

		public override bool Equals(NetworkObjectGuid x, NetworkObjectGuid y) { }

		public override int GetHashCode(NetworkObjectGuid obj) { }

	}

	public const int SIZE = 16; //Field offset: 0x0
	public const int ALIGNMENT = 4; //Field offset: 0x0
	[FixedBuffer(typeof(long, 2)]
	public <RawGuidValue>e__FixedBuffer RawGuidValue; //Field offset: 0x0
	private long _data0; //Field offset: 0x0
	private long _data1; //Field offset: 0x8

	public static NetworkObjectGuid Empty
	{
		 get { } //Length: 12
	}

	public bool IsValid
	{
		 get { } //Length: 32
	}

	public NetworkObjectGuid(string guid) { }

	public NetworkObjectGuid(long data0, long data1) { }

	public NetworkObjectGuid(Byte[] guid) { }

	public NetworkObjectGuid(Byte* guid) { }

	public override int CompareTo(NetworkObjectGuid other) { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(NetworkObjectGuid other) { }

	public static NetworkObjectGuid get_Empty() { }

	public bool get_IsValid() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(NetworkObjectGuid a, NetworkObjectGuid b) { }

	public static NetworkPrefabRef op_Explicit(NetworkObjectGuid t) { }

	public static Guid op_Implicit(NetworkObjectGuid guid) { }

	public static NetworkObjectGuid op_Implicit(Guid guid) { }

	public static bool op_Inequality(NetworkObjectGuid a, NetworkObjectGuid b) { }

	public static NetworkObjectGuid Parse(string str) { }

	public virtual string ToString() { }

	public string ToString(string format) { }

	public string ToUnityGuidString() { }

	public static bool TryParse(string str, out NetworkObjectGuid guid) { }

}

