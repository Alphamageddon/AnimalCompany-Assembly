namespace Fusion;

public class SimulationInput
{
	internal class Buffer
	{
		private NetworkProjectConfig _cfg; //Field offset: 0x10
		private Resolved _rate; //Field offset: 0x18
		private Dictionary<Tick, SimulationInput> _map; //Field offset: 0x28
		private Dictionary<Tick, Double> _time; //Field offset: 0x30
		private SimulationInputHeader _lastUsedInputHeaderData; //Field offset: 0x38

		public int Count
		{
			 get { } //Length: 80
		}

		public bool Full
		{
			 get { } //Length: 96
		}

		public Buffer(NetworkProjectConfig cfg) { }

		public bool Add(SimulationInput input, Nullable<Double> insertTime = null) { }

		public void Clear() { }

		public bool Contains(Tick tick) { }

		public int CopySortedTo(SimulationInput[] array) { }

		public SimulationInput Get(Tick tick) { }

		public int get_Count() { }

		public bool get_Full() { }

		public Nullable<Double> GetInsertTime(Tick tick) { }

		public SimulationInputHeader GetLastUsedInputHeader() { }

		public bool Remove(Tick tick, out SimulationInput removed) { }

	}

	public class Pool
	{
		private Allocator* _allocator; //Field offset: 0x10
		private Stack<SimulationInput> _pool; //Field offset: 0x18
		private List<SimulationInput> _created; //Field offset: 0x20
		private SimulationConfig _config; //Field offset: 0x28
		private bool _disposed; //Field offset: 0x30

		public Pool(SimulationConfig config, Allocator* allocator) { }

		public SimulationInput Acquire() { }

		public void Dispose() { }

		public void Release(SimulationInput input) { }

	}

	private int _sent; //Field offset: 0x10
	private bool _pooled; //Field offset: 0x14
	private PlayerRef _player; //Field offset: 0x18
	internal Int32* _ptr; //Field offset: 0x20
	internal SimulationInput Prev; //Field offset: 0x28
	internal SimulationInput Next; //Field offset: 0x30

	public Int32* Data
	{
		 get { } //Length: 12
	}

	public SimulationInputHeader* Header
	{
		 get { } //Length: 8
	}

	public PlayerRef Player
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public int Sent
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public SimulationInput() { }

	public void Clear(int wordCount) { }

	public void CopyFrom(SimulationInput source, int wordCount) { }

	internal void Dispose(Allocator* allocator) { }

	public Int32* get_Data() { }

	public SimulationInputHeader* get_Header() { }

	public PlayerRef get_Player() { }

	public int get_Sent() { }

	internal void Serialize(SimulationInput previous, SimulationConfig config, NetBitBufferSerializer serializer) { }

	public void set_Player(PlayerRef value) { }

	public void set_Sent(int value) { }

}

