namespace Fusion;

[NetworkStructWeaved(1)]
public struct NetworkId : INetworkStruct, IEquatable<NetworkId>, IComparable, IComparable<NetworkId>
{
	internal sealed class EqualityComparer : IEqualityComparer<NetworkId>
	{

		public EqualityComparer() { }

		public override bool Equals(NetworkId a, NetworkId b) { }

		public override int GetHashCode(NetworkId id) { }

	}

	public const int BLOCK_SIZE = 8; //Field offset: 0x0
	public const int SIZE = 4; //Field offset: 0x0
	public const int ALIGNMENT = 4; //Field offset: 0x0
	[CompilerGenerated]
	private static readonly EqualityComparer <Comparer>k__BackingField; //Field offset: 0x0
	internal const int MAX_RESERVED_ID = 1023; //Field offset: 0x0
	private const uint RAW_RUNTIME_CONFIG = 1; //Field offset: 0x0
	private const uint RAW_PLAYER_REF_DATA_ARRAY = 2; //Field offset: 0x0
	private const uint RAW_SCENE_INFO = 3; //Field offset: 0x0
	private const uint RAW_PHYSICS_INFO = 4; //Field offset: 0x0
	public uint Raw; //Field offset: 0x0

	public static EqualityComparer Comparer
	{
		[CompilerGenerated]
		 get { } //Length: 88
	}

	public bool IsReserved
	{
		 get { } //Length: 20
	}

	public bool IsValid
	{
		 get { } //Length: 16
	}

	internal static NetworkId PhysicsInfo
	{
		internal get { } //Length: 8
	}

	internal static NetworkId RuntimeConfig
	{
		internal get { } //Length: 8
	}

	internal static NetworkId SceneInfo
	{
		internal get { } //Length: 8
	}

	private static NetworkId() { }

	internal NetworkId(uint raw) { }

	public override int CompareTo(NetworkId other) { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(NetworkId other) { }

	[CompilerGenerated]
	public static EqualityComparer get_Comparer() { }

	public bool get_IsReserved() { }

	public bool get_IsValid() { }

	internal static NetworkId get_PhysicsInfo() { }

	internal static NetworkId get_RuntimeConfig() { }

	internal static NetworkId get_SceneInfo() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(NetworkId a, NetworkId b) { }

	public static bool op_Implicit(NetworkId id) { }

	public static bool op_Inequality(NetworkId a, NetworkId b) { }

	public static NetworkId Read(NetBitBuffer* buffer) { }

	private override int System.IComparable.CompareTo(object obj) { }

	public string ToNamePrefixString() { }

	public virtual string ToString() { }

	public static void Write(NetBitBuffer* buffer, NetworkId id) { }

	public void Write(NetBitBuffer* buffer) { }

}

