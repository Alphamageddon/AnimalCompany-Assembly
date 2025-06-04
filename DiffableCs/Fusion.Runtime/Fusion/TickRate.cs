namespace Fusion;

[DefaultMember("Item")]
public struct TickRate
{
	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <_rates>e__FixedBuffer
	{
		public int FixedElementField; //Field offset: 0x0

	}

	internal struct Resolved
	{
		public const int SIZE = 16; //Field offset: 0x0
		public const int WORDS = 4; //Field offset: 0x0
		public int Client; //Field offset: 0x0
		public int ClientSend; //Field offset: 0x4
		public int Server; //Field offset: 0x8
		public int ServerSend; //Field offset: 0xC

		public double ClientSendDelta
		{
			 get { } //Length: 32
		}

		public double ClientTickDelta
		{
			 get { } //Length: 32
		}

		public int ClientTickStride
		{
			 get { } //Length: 8
		}

		public double ServerSendDelta
		{
			 get { } //Length: 32
		}

		public double ServerTickDelta
		{
			 get { } //Length: 32
		}

		public int ServerTickStride
		{
			 get { } //Length: 16
		}

		internal Resolved(int client, int clientSend, int server, int serverSend) { }

		public double get_ClientSendDelta() { }

		public double get_ClientTickDelta() { }

		public int get_ClientTickStride() { }

		public double get_ServerSendDelta() { }

		public double get_ServerTickDelta() { }

		public int get_ServerTickStride() { }

		private static double Inverse(int rate) { }

		public virtual string ToString() { }

	}

	internal struct Selection
	{
		public int Client; //Field offset: 0x0
		public int ServerIndex; //Field offset: 0x4
		public int ClientSendIndex; //Field offset: 0x8
		public int ServerSendIndex; //Field offset: 0xC

	}

	internal enum ValidateResult
	{
		Ok = 0,
		Error = 1,
		NotFound = 2,
		InvalidTickRate = 3,
		ServerIndexOutOfRange = 4,
		ClientSendIndexOutOfRange = 5,
		ServerSendIndexOutOfRange = 6,
		ServerSendRateLargerThanTickRate = 7,
	}

	private static TickRate[] _valid; //Field offset: 0x0
	private static ReadOnlyCollection<TickRate> _validReadOnly; //Field offset: 0x8
	private static Dictionary<Int32, TickRate> _lookup; //Field offset: 0x10
	private int _count; //Field offset: 0x0
	[FixedBuffer(typeof(int, 4)]
	private <_rates>e__FixedBuffer _rates; //Field offset: 0x4

	public static IReadOnlyList<TickRate> Available
	{
		 get { } //Length: 92
	}

	public int Client
	{
		 get { } //Length: 8
	}

	public int Count
	{
		 get { } //Length: 8
	}

	internal static Selection Default
	{
		internal get { } //Length: 12
	}

	public int Item
	{
		 get { } //Length: 100
	}

	internal static Selection Shared
	{
		internal get { } //Length: 12
	}

	private static TickRate() { }

	private TickRate(Int32[] rates) { }

	public Selection ClampSelection(Selection selection) { }

	public static TickRate Get(int rate) { }

	public static IReadOnlyList<TickRate> get_Available() { }

	public int get_Client() { }

	public int get_Count() { }

	internal static Selection get_Default() { }

	public int get_Item(int index) { }

	internal static Selection get_Shared() { }

	public int GetDivisor(int index) { }

	public int GetTickRate(int index) { }

	public static void Init() { }

	private static void InitChecked() { }

	public static bool IsValid(TickRate rate) { }

	public static bool IsValid(int rate) { }

	public static Resolved Resolve(Selection selection) { }

	public Int32[] ToArray() { }

	private bool Validate() { }

	public ValidateResult ValidateSelection(Selection selected) { }

}

