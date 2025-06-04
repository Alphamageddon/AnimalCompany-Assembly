namespace Fusion;

[NetworkStructWeaved(4)]
public struct NetworkPrefabRef : INetworkStruct, IEquatable<NetworkPrefabRef>, IComparable<NetworkPrefabRef>
{
	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <RawGuidValue>e__FixedBuffer
	{
		public long FixedElementField; //Field offset: 0x0

	}

	internal sealed class EqualityComparer : IEqualityComparer<NetworkPrefabRef>
	{

		public EqualityComparer() { }

		public override bool Equals(NetworkPrefabRef x, NetworkPrefabRef y) { }

		public override int GetHashCode(NetworkPrefabRef obj) { }

	}

	public const int SIZE = 16; //Field offset: 0x0
	public const int ALIGNMENT = 4; //Field offset: 0x0
	[FixedBuffer(typeof(long, 2)]
	public <RawGuidValue>e__FixedBuffer RawGuidValue; //Field offset: 0x0
	private long _data0; //Field offset: 0x0
	private long _data1; //Field offset: 0x8

	public static NetworkPrefabRef Empty
	{
		 get { } //Length: 12
	}

	public bool IsValid
	{
		 get { } //Length: 32
	}

	public NetworkPrefabRef(string guid) { }

	public NetworkPrefabRef(long data0, long data1) { }

	public NetworkPrefabRef(Byte[] guid) { }

	public NetworkPrefabRef(Byte* guid) { }

	public override int CompareTo(NetworkPrefabRef other) { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(NetworkPrefabRef other) { }

	public static NetworkPrefabRef get_Empty() { }

	public bool get_IsValid() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(NetworkPrefabRef a, NetworkPrefabRef b) { }

	public static NetworkObjectGuid op_Explicit(NetworkPrefabRef t) { }

	public static Guid op_Implicit(NetworkPrefabRef guid) { }

	public static NetworkPrefabRef op_Implicit(Guid guid) { }

	public static bool op_Inequality(NetworkPrefabRef a, NetworkPrefabRef b) { }

	public static NetworkPrefabRef Parse(string str) { }

	public virtual string ToString() { }

	public string ToString(string format) { }

	public string ToUnityGuidString() { }

	public static bool TryParse(string str, out NetworkPrefabRef guid) { }

}

