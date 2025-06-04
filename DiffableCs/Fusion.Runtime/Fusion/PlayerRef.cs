namespace Fusion;

[NetworkStructWeaved(1)]
public struct PlayerRef : INetworkStruct, IEquatable<PlayerRef>
{
	private sealed class IndexEqualityComparer : IEqualityComparer<PlayerRef>
	{

		public IndexEqualityComparer() { }

		public override bool Equals(PlayerRef x, PlayerRef y) { }

		public override int GetHashCode(PlayerRef obj) { }

	}

	[CompilerGenerated]
	private static readonly IEqualityComparer<PlayerRef> <Comparer>k__BackingField; //Field offset: 0x0
	public const int SIZE = 4; //Field offset: 0x0
	private const int MASTER_CLIENT_RAW = -1; //Field offset: 0x0
	private int _index; //Field offset: 0x0

	public int AsIndex
	{
		 get { } //Length: 12
	}

	public static IEqualityComparer<PlayerRef> Comparer
	{
		[CompilerGenerated]
		 get { } //Length: 88
	}

	public bool IsMasterClient
	{
		 get { } //Length: 16
	}

	public bool IsNone
	{
		 get { } //Length: 16
	}

	public bool IsRealPlayer
	{
		 get { } //Length: 16
	}

	public static PlayerRef MasterClient
	{
		 get { } //Length: 8
	}

	public static PlayerRef None
	{
		 get { } //Length: 8
	}

	public int PlayerId
	{
		 get { } //Length: 12
	}

	public int RawEncoded
	{
		 get { } //Length: 8
	}

	private static PlayerRef() { }

	public override bool Equals(PlayerRef other) { }

	public virtual bool Equals(object obj) { }

	public static PlayerRef FromEncoded(int encoded) { }

	public static PlayerRef FromIndex(int index) { }

	public int get_AsIndex() { }

	[CompilerGenerated]
	public static IEqualityComparer<PlayerRef> get_Comparer() { }

	public bool get_IsMasterClient() { }

	public bool get_IsNone() { }

	public bool get_IsRealPlayer() { }

	public static PlayerRef get_MasterClient() { }

	public static PlayerRef get_None() { }

	public int get_PlayerId() { }

	public int get_RawEncoded() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(PlayerRef a, PlayerRef b) { }

	public static bool op_Inequality(PlayerRef a, PlayerRef b) { }

	public static PlayerRef Read(NetBitBuffer* buffer) { }

	public virtual string ToString() { }

	public static void Write(NetBitBuffer* buffer, PlayerRef playerRef) { }

	public static void Write(T* buffer, PlayerRef playerRef) { }

}

