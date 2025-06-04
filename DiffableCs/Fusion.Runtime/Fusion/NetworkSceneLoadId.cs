namespace Fusion;

[IsReadOnly]
public struct NetworkSceneLoadId : IEquatable<NetworkSceneLoadId>
{
	public readonly byte Value; //Field offset: 0x0

	public NetworkSceneLoadId(byte value) { }

	public override bool Equals(NetworkSceneLoadId other) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

}

