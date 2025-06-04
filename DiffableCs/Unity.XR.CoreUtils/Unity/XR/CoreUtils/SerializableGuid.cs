namespace Unity.XR.CoreUtils;

public struct SerializableGuid : IEquatable<SerializableGuid>
{
	private static readonly SerializableGuid k_Empty; //Field offset: 0x0
	[HideInInspector]
	[SerializeField]
	private ulong m_GuidLow; //Field offset: 0x0
	[HideInInspector]
	[SerializeField]
	private ulong m_GuidHigh; //Field offset: 0x8

	public static SerializableGuid Empty
	{
		 get { } //Length: 88
	}

	public Guid Guid
	{
		 get { } //Length: 12
	}

	private static SerializableGuid() { }

	public SerializableGuid(ulong guidLow, ulong guidHigh) { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(SerializableGuid other) { }

	public static SerializableGuid get_Empty() { }

	public Guid get_Guid() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(SerializableGuid lhs, SerializableGuid rhs) { }

	public static bool op_Inequality(SerializableGuid lhs, SerializableGuid rhs) { }

	public virtual string ToString() { }

	public string ToString(string format) { }

	public string ToString(string format, IFormatProvider provider) { }

}

