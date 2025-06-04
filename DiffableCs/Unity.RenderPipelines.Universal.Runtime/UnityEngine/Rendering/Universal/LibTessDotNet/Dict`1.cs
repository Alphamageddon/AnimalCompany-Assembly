namespace UnityEngine.Rendering.Universal.LibTessDotNet;

internal class Dict
{
	internal sealed class LessOrEqual : MulticastDelegate
	{

		public LessOrEqual(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(TValue lhs, TValue rhs, AsyncCallback callback, object object) { }

		public override bool EndInvoke(IAsyncResult result) { }

		public override bool Invoke(TValue lhs, TValue rhs) { }

	}

	internal class Node
	{
		internal TValue _key; //Field offset: 0x0
		internal Node<TValue> _prev; //Field offset: 0x0
		internal Node<TValue> _next; //Field offset: 0x0

		public TValue Key
		{
			 get { } //Length: 8
		}

		public Node<TValue> Next
		{
			 get { } //Length: 8
		}

		public Node<TValue> Prev
		{
			 get { } //Length: 8
		}

		public Node() { }

		public TValue get_Key() { }

		public Node<TValue> get_Next() { }

		public Node<TValue> get_Prev() { }

	}

	private LessOrEqual<TValue> _leq; //Field offset: 0x0
	private Node<TValue> _head; //Field offset: 0x0

	public Dict`1(LessOrEqual<TValue> leq) { }

	public Node<TValue> Find(TValue key) { }

	public Node<TValue> Insert(TValue key) { }

	public Node<TValue> InsertBefore(Node<TValue> node, TValue key) { }

	public Node<TValue> Min() { }

	public void Remove(Node<TValue> node) { }

}

