namespace Fusion;

public struct SerializableType : IEquatable<SerializableType`1<BaseType>>
{
	public string AssemblyQualifiedName; //Field offset: 0x0

	public bool IsValid
	{
		 get { } //Length: 32
	}

	public Type Value
	{
		 get { } //Length: 360
	}

	public SerializableType`1(Type type) { }

	public SerializableType<BaseType> AsShort() { }

	public override bool Equals(SerializableType<BaseType> other) { }

	public virtual bool Equals(object obj) { }

	public bool get_IsValid() { }

	public Type get_Value() { }

	public virtual int GetHashCode() { }

	public static SerializableType<BaseType> op_Implicit(Type type) { }

	public static Type op_Implicit(SerializableType<BaseType> serializableType) { }

}

