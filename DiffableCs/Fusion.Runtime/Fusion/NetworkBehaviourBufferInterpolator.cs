namespace Fusion;

[IsByRefLike]
[IsReadOnly]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
public struct NetworkBehaviourBufferInterpolator
{
	public readonly NetworkBehaviour Behaviour; //Field offset: 0x0
	public readonly NetworkBehaviourBuffer From; //Field offset: 0x8
	public readonly NetworkBehaviourBuffer To; //Field offset: 0x18
	public readonly float Alpha; //Field offset: 0x28
	public readonly bool Valid; //Field offset: 0x2C

	public NetworkBehaviourBufferInterpolator(NetworkBehaviour nb) { }

	public float Angle(string property) { }

	public float Angle(PropertyReader<Angle> property) { }

	public bool Bool(PropertyReader<Boolean> property) { }

	public bool Bool(string property) { }

	public float Float(string property) { }

	public float Float(PropertyReader<Single> property) { }

	public int Int(string property) { }

	public int Int(PropertyReader<Int32> property) { }

	public static bool op_Implicit(NetworkBehaviourBufferInterpolator i) { }

	public Quaternion Quaternion(string property) { }

	public Quaternion Quaternion(PropertyReader<Quaternion> property) { }

	public T Select(PropertyReader<T> property) { }

	public T Select(string property) { }

	public Vector2 Vector2(string property) { }

	public Vector2 Vector2(PropertyReader<Vector2> property) { }

	public Vector3 Vector3(string property) { }

	public Vector3 Vector3(PropertyReader<Vector3> property) { }

	public Vector4 Vector4(string property) { }

	public Vector4 Vector4(PropertyReader<Vector4> property) { }

}

