namespace Fusion;

public struct SerializableType : IEquatable<SerializableType>
{
	private static class Cache
	{
		public static Dictionary<String, Object> Types; //Field offset: 0x0

		private static Cache() { }

	}

	private static readonly Regex s_shortNameRegex; //Field offset: 0x0
	public string AssemblyQualifiedName; //Field offset: 0x0

	public bool IsValid
	{
		 get { } //Length: 32
	}

	public Type Value
	{
		 get { } //Length: 1024
	}

	private static SerializableType() { }

	public SerializableType(Type type) { }

	public SerializableType(string type) { }

	public SerializableType AsShort() { }

	public override bool Equals(SerializableType other) { }

	public virtual bool Equals(object obj) { }

	public bool get_IsValid() { }

	public Type get_Value() { }

	public virtual int GetHashCode() { }

	public static string GetShortAssemblyQualifiedName(Type type) { }

	internal static string GetShortAssemblyQualifiedName(string assemblyQualifiedName) { }

	public static SerializableType op_Implicit(Type type) { }

	public static Type op_Implicit(SerializableType serializableType) { }

}

