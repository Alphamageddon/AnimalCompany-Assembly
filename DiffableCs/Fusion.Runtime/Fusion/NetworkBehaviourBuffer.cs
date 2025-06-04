namespace Fusion;

[DefaultMember("Item")]
[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
public struct NetworkBehaviourBuffer
{
	internal Int32* _ptr; //Field offset: 0x0
	internal int _length; //Field offset: 0x8
	internal Tick _tick; //Field offset: 0xC

	public int Item
	{
		 get { } //Length: 12
	}

	public int Length
	{
		 get { } //Length: 8
	}

	public Tick Tick
	{
		 get { } //Length: 8
	}

	public bool Valid
	{
		 get { } //Length: 32
	}

	internal NetworkBehaviourBuffer(Tick tick, Int32* ptr, int length) { }

	public int get_Item(int index) { }

	public int get_Length() { }

	public Tick get_Tick() { }

	public bool get_Valid() { }

	public static bool op_Implicit(NetworkBehaviourBuffer buffer) { }

	public T Read(BehaviourReader<T> reader) { }

	public T Read(PropertyReader<T> reader) { }

	public float Read(PropertyReader<Single> reader) { }

	public Vector2 Read(PropertyReader<Vector2> reader) { }

	public Vector3 Read(PropertyReader<Vector3> reader) { }

	public Vector4 Read(PropertyReader<Vector4> reader) { }

	public Quaternion Read(PropertyReader<Quaternion> reader) { }

	public T ReinterpretState(int offset = 0) { }

}

