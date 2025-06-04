namespace System.Collections.Generic;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(ICollectionDebugView`1))]
public class SortedSet : ISet<T>, ICollection<T>, IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>, ISerializable, IDeserializationCallback
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass52_0
	{
		public int index; //Field offset: 0x0
		public int count; //Field offset: 0x0
		public T[] array; //Field offset: 0x0

		public <>c__DisplayClass52_0() { }

		internal bool <CopyTo>b__0(Node<T> node) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass53_0
	{
		public int index; //Field offset: 0x0
		public Object[] objects; //Field offset: 0x0

		public <>c__DisplayClass53_0() { }

		internal bool <System.Collections.ICollection.CopyTo>b__0(Node<T> node) { }

	}

	internal struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator, ISerializable, IDeserializationCallback
	{
		private static readonly Node<T> s_dummyNode; //Field offset: 0x0
		private SortedSet<T> _tree; //Field offset: 0x0
		private int _version; //Field offset: 0x0
		private Stack<Node<T>> _stack; //Field offset: 0x0
		private Node<T> _current; //Field offset: 0x0
		private bool _reverse; //Field offset: 0x0

		public override T Current
		{
			 get { } //Length: 48
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 112
		}

		private static Enumerator() { }

		internal Enumerator(SortedSet<T> set) { }

		internal Enumerator(SortedSet<T> set, bool reverse) { }

		public override void Dispose() { }

		public override T get_Current() { }

		private void Initialize() { }

		public override bool MoveNext() { }

		internal void Reset() { }

		private override object System.Collections.IEnumerator.get_Current() { }

		private override void System.Collections.IEnumerator.Reset() { }

		private override void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

		private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	}

	public sealed class Node
	{
		[CompilerGenerated]
		private T <Item>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private Node<T> <Left>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private Node<T> <Right>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private NodeColor <Color>k__BackingField; //Field offset: 0x0

		public NodeColor Color
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 8
		}

		public bool Is2Node
		{
			 get { } //Length: 144
		}

		public bool Is4Node
		{
			 get { } //Length: 132
		}

		public bool IsBlack
		{
			 get { } //Length: 16
		}

		public bool IsRed
		{
			 get { } //Length: 16
		}

		public T Item
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 8
		}

		public Node<T> Left
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 8
		}

		public Node<T> Right
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 8
		}

		public Node(T item, NodeColor color) { }

		public void ColorBlack() { }

		public void ColorRed() { }

		[CompilerGenerated]
		public NodeColor get_Color() { }

		public bool get_Is2Node() { }

		public bool get_Is4Node() { }

		public bool get_IsBlack() { }

		public bool get_IsRed() { }

		[CompilerGenerated]
		public T get_Item() { }

		[CompilerGenerated]
		public Node<T> get_Left() { }

		[CompilerGenerated]
		public Node<T> get_Right() { }

		public TreeRotation GetRotation(Node<T> current, Node<T> sibling) { }

		public Node<T> GetSibling(Node<T> node) { }

		public static bool IsNonNullRed(Node<T> node) { }

		public static bool IsNullOrBlack(Node<T> node) { }

		public void Merge2Nodes() { }

		public void ReplaceChild(Node<T> child, Node<T> newChild) { }

		public Node<T> Rotate(TreeRotation rotation) { }

		public Node<T> RotateLeft() { }

		public Node<T> RotateLeftRight() { }

		public Node<T> RotateRight() { }

		public Node<T> RotateRightLeft() { }

		[CompilerGenerated]
		public void set_Color(NodeColor value) { }

		[CompilerGenerated]
		public void set_Item(T value) { }

		[CompilerGenerated]
		public void set_Left(Node<T> value) { }

		[CompilerGenerated]
		public void set_Right(Node<T> value) { }

		public void Split4Node() { }

	}

	private Node<T> root; //Field offset: 0x0
	private IComparer<T> comparer; //Field offset: 0x0
	private int count; //Field offset: 0x0
	private int version; //Field offset: 0x0
	private object _syncRoot; //Field offset: 0x0
	private SerializationInfo siInfo; //Field offset: 0x0

	public override int Count
	{
		 get { } //Length: 36
	}

	private override bool System.Collections.Generic.ICollection<T>.IsReadOnly
	{
		private get { } //Length: 8
	}

	private override bool System.Collections.ICollection.IsSynchronized
	{
		private get { } //Length: 8
	}

	private override object System.Collections.ICollection.SyncRoot
	{
		private get { } //Length: 116
	}

	public SortedSet`1() { }

	public SortedSet`1(IComparer<T> comparer) { }

	protected SortedSet`1(SerializationInfo info, StreamingContext context) { }

	public override bool Add(T item) { }

	internal override bool AddIfNotPresent(T item) { }

	public override void Clear() { }

	public override bool Contains(T item) { }

	public void CopyTo(T[] array, int index, int count) { }

	public override void CopyTo(T[] array, int index) { }

	internal override bool DoRemove(T item) { }

	internal override Node<T> FindNode(T item) { }

	public override int get_Count() { }

	public Enumerator<T> GetEnumerator() { }

	protected override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	internal override bool InOrderTreeWalk(TreeWalkPredicate<T> action) { }

	private void InsertionBalance(Node<T> current, ref Node<T> parent, Node<T> grandParent, Node<T> greatGrandParent) { }

	internal override bool IsWithinRange(T item) { }

	private static int Log2(int value) { }

	protected override void OnDeserialization(object sender) { }

	public override bool Remove(T item) { }

	private void ReplaceChildOrRoot(Node<T> parent, Node<T> child, Node<T> newChild) { }

	private void ReplaceNode(Node<T> match, Node<T> parentOfMatch, Node<T> successor, Node<T> parentOfSuccessor) { }

	private override void System.Collections.Generic.ICollection<T>.Add(T item) { }

	private override bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }

	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	private override object System.Collections.ICollection.get_SyncRoot() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	private override void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	internal override void VersionCheck() { }

}

