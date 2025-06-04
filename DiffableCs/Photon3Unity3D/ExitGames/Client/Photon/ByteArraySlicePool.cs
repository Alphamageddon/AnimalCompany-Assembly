namespace ExitGames.Client.Photon;

public class ByteArraySlicePool
{
	private int minStackIndex; //Field offset: 0x10
	internal readonly Stack<ByteArraySlice>[] poolTiers; //Field offset: 0x18
	private int allocationCounter; //Field offset: 0x20

	public int AllocationCounter
	{
		 get { } //Length: 8
	}

	public int MinStackIndex
	{
		 get { } //Length: 8
		 set { } //Length: 44
	}

	public ByteArraySlicePool() { }

	public ByteArraySlice Acquire(Byte[] buffer, int offset = 0, int count = 0) { }

	public ByteArraySlice Acquire(int minByteCount) { }

	public void ClearPools(int lower = 0, int upper = 2147483647) { }

	public int get_AllocationCounter() { }

	public int get_MinStackIndex() { }

	private ByteArraySlice PopOrCreate(Stack<ByteArraySlice> stack, int stackIndex) { }

	internal bool Release(ByteArraySlice slice, int stackIndex) { }

	public void set_MinStackIndex(int value) { }

}

