namespace Fusion;

public struct NetworkSceneObjectId : IEquatable<NetworkSceneObjectId>
{
	public SceneRef Scene; //Field offset: 0x0
	public int ObjectId; //Field offset: 0x4
	public int SceneLoadId; //Field offset: 0x8

	public bool IsValid
	{
		 get { } //Length: 8
	}

	public override bool Equals(NetworkSceneObjectId other) { }

	public virtual bool Equals(object obj) { }

	public bool get_IsValid() { }

	public virtual int GetHashCode() { }

	public virtual string ToString() { }

}

