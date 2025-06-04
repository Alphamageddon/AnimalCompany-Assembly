namespace Fusion;

[InlineHelp]
[NetworkStructWeaved(1)]
public struct NetworkPrefabId : INetworkStruct, IEquatable<NetworkPrefabId>, IComparable, IComparable<NetworkPrefabId>
{
	internal sealed class EqualityComparer : IEqualityComparer<NetworkPrefabId>
	{

		public EqualityComparer() { }

		public override bool Equals(NetworkPrefabId x, NetworkPrefabId y) { }

		public override int GetHashCode(NetworkPrefabId obj) { }

	}

	public const int SIZE = 4; //Field offset: 0x0
	public const int ALIGNMENT = 4; //Field offset: 0x0
	public const int MAX_INDEX = 2147483646; //Field offset: 0x0
	[FormerlySerializedAs("Value")]
	public uint RawValue; //Field offset: 0x0

	public int AsIndex
	{
		 get { } //Length: 12
	}

	public bool IsNone
	{
		 get { } //Length: 16
	}

	public bool IsValid
	{
		 get { } //Length: 16
	}

	public override int CompareTo(NetworkPrefabId other) { }

	public override bool Equals(NetworkPrefabId other) { }

	public virtual bool Equals(object obj) { }

	public static NetworkPrefabId FromIndex(int index) { }

	public static NetworkPrefabId FromRaw(uint value) { }

	public int get_AsIndex() { }

	public bool get_IsNone() { }

	public bool get_IsValid() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(NetworkPrefabId a, NetworkPrefabId b) { }

	public static bool op_Inequality(NetworkPrefabId a, NetworkPrefabId b) { }

	private override int System.IComparable.CompareTo(object obj) { }

	public virtual string ToString() { }

	public string ToString(bool brackets, bool prefix) { }

}

