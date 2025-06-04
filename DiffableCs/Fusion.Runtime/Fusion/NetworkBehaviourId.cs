namespace Fusion;

[NetworkStructWeaved(2)]
public struct NetworkBehaviourId : INetworkStruct, IEquatable<NetworkBehaviourId>
{
	public const int SIZE = 8; //Field offset: 0x0
	public NetworkId Object; //Field offset: 0x0
	public int Behaviour; //Field offset: 0x4

	public bool IsValid
	{
		 get { } //Length: 108
	}

	public static NetworkBehaviourId None
	{
		 get { } //Length: 8
	}

	public override bool Equals(NetworkBehaviourId other) { }

	public virtual bool Equals(object obj) { }

	public bool get_IsValid() { }

	public static NetworkBehaviourId get_None() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(NetworkBehaviourId a, NetworkBehaviourId b) { }

	public static bool op_Inequality(NetworkBehaviourId a, NetworkBehaviourId b) { }

	public virtual string ToString() { }

}

