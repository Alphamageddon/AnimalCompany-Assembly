namespace Fusion;

[NetworkStructWeaved(1)]
public struct NetworkBool : INetworkStruct, IEquatable<NetworkBool>
{
	[SerializeField]
	private int _value; //Field offset: 0x0

	public NetworkBool(bool value) { }

	public override bool Equals(NetworkBool other) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	public static bool op_Implicit(NetworkBool val) { }

	public static NetworkBool op_Implicit(bool val) { }

	public virtual string ToString() { }

}

