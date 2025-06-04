namespace Fusion;

[NetworkStructWeaved(1)]
public struct NetworkObjectNestingKey : INetworkStruct, IEquatable<NetworkObjectNestingKey>
{
	internal sealed class EqualityComparer : IEqualityComparer<NetworkObjectNestingKey>
	{

		public EqualityComparer() { }

		public override bool Equals(NetworkObjectNestingKey x, NetworkObjectNestingKey y) { }

		public override int GetHashCode(NetworkObjectNestingKey obj) { }

	}

	public const int SIZE = 4; //Field offset: 0x0
	public const int ALIGNMENT = 4; //Field offset: 0x0
	public int Value; //Field offset: 0x0

	public bool IsNone
	{
		 get { } //Length: 16
	}

	public bool IsValid
	{
		 get { } //Length: 16
	}

	public NetworkObjectNestingKey(int value) { }

	public override bool Equals(NetworkObjectNestingKey other) { }

	public virtual bool Equals(object obj) { }

	public bool get_IsNone() { }

	public bool get_IsValid() { }

	public virtual int GetHashCode() { }

	public virtual string ToString() { }

}

