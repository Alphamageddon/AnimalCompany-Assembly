namespace UnityEngine.Rendering.Universal.LibTessDotNet;

internal class PriorityHeap
{
	internal class HandleElem
	{
		internal TValue _key; //Field offset: 0x0
		internal int _node; //Field offset: 0x0

		public HandleElem() { }

	}

	internal sealed class LessOrEqual : MulticastDelegate
	{

		public LessOrEqual(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(TValue lhs, TValue rhs, AsyncCallback callback, object object) { }

		public override bool EndInvoke(IAsyncResult result) { }

		public override bool Invoke(TValue lhs, TValue rhs) { }

	}

	private LessOrEqual<TValue> _leq; //Field offset: 0x0
	private Int32[] _nodes; //Field offset: 0x0
	private HandleElem<TValue>[] _handles; //Field offset: 0x0
	private int _size; //Field offset: 0x0
	private int _max; //Field offset: 0x0
	private int _freeList; //Field offset: 0x0
	private bool _initialized; //Field offset: 0x0

	public bool Empty
	{
		 get { } //Length: 16
	}

	public PriorityHeap`1(int initialSize, LessOrEqual<TValue> leq) { }

	public TValue ExtractMin() { }

	private void FloatDown(int curr) { }

	private void FloatUp(int curr) { }

	public bool get_Empty() { }

	public void Init() { }

	public PQHandle Insert(TValue value) { }

	public TValue Minimum() { }

	public void Remove(PQHandle handle) { }

}

