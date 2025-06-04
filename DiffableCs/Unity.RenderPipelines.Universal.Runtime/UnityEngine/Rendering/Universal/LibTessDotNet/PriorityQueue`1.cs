namespace UnityEngine.Rendering.Universal.LibTessDotNet;

internal class PriorityQueue
{
	private class StackItem
	{
		internal int p; //Field offset: 0x0
		internal int r; //Field offset: 0x0

		public StackItem() { }

	}

	private LessOrEqual<TValue> _leq; //Field offset: 0x0
	private PriorityHeap<TValue> _heap; //Field offset: 0x0
	private TValue[] _keys; //Field offset: 0x0
	private Int32[] _order; //Field offset: 0x0
	private int _size; //Field offset: 0x0
	private int _max; //Field offset: 0x0
	private bool _initialized; //Field offset: 0x0

	public bool Empty
	{
		 get { } //Length: 52
	}

	public PriorityQueue`1(int initialSize, LessOrEqual<TValue> leq) { }

	public TValue ExtractMin() { }

	public bool get_Empty() { }

	public void Init() { }

	public PQHandle Insert(TValue value) { }

	public TValue Minimum() { }

	public void Remove(PQHandle handle) { }

	private static void Swap(ref int a, ref int b) { }

}

