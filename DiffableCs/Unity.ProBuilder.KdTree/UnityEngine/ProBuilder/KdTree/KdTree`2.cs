namespace UnityEngine.ProBuilder.KdTree;

internal class KdTree : IKdTree<TKey, TValue>, IEnumerable<KdTreeNode`2<TKey, TValue>>, IEnumerable
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass33_0
	{
		public Stack<KdTreeNode`2<TKey, TValue>> left; //Field offset: 0x0
		public Stack<KdTreeNode`2<TKey, TValue>> right; //Field offset: 0x0

		public <>c__DisplayClass33_0() { }

		internal void <GetEnumerator>b__0(KdTreeNode<TKey, TValue> node) { }

		internal void <GetEnumerator>b__1(KdTreeNode<TKey, TValue> node) { }

	}

	[CompilerGenerated]
	private sealed class <GetEnumerator>d__33 : IEnumerator<KdTreeNode`2<TKey, TValue>>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private KdTreeNode<TKey, TValue> <>2__current; //Field offset: 0x0
		public KdTree<TKey, TValue> <>4__this; //Field offset: 0x0
		private <>c__DisplayClass33_0<TKey, TValue> <>8__1; //Field offset: 0x0
		private Action<KdTreeNode`2<TKey, TValue>> <addLeft>5__2; //Field offset: 0x0
		private Action<KdTreeNode`2<TKey, TValue>> <addRight>5__3; //Field offset: 0x0

		private override KdTreeNode<TKey, TValue> System.Collections.Generic.IEnumerator<UnityEngine.ProBuilder.KdTree.KdTreeNode<TKey,TValue>>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 8
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 8
		}

		[DebuggerHidden]
		public <GetEnumerator>d__33(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override KdTreeNode<TKey, TValue> System.Collections.Generic.IEnumerator<UnityEngine.ProBuilder.KdTree.KdTreeNode<TKey,TValue>>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private int dimensions; //Field offset: 0x0
	private ITypeMath<TKey> typeMath; //Field offset: 0x0
	private KdTreeNode<TKey, TValue> root; //Field offset: 0x0
	[CompilerGenerated]
	private AddDuplicateBehavior <AddDuplicateBehavior>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private int <Count>k__BackingField; //Field offset: 0x0

	public private AddDuplicateBehavior AddDuplicateBehavior
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private override int Count
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public KdTree`2(int dimensions, ITypeMath<TKey> typeMath) { }

	public KdTree`2(int dimensions, ITypeMath<TKey> typeMath, AddDuplicateBehavior addDuplicateBehavior) { }

	public override bool Add(TKey[] point, TValue value) { }

	private void AddNearestNeighbours(KdTreeNode<TKey, TValue> node, TKey[] target, HyperRect<TKey> rect, int depth, NearestNeighbourList<KdTreeNode`2<TKey, TValue>, TKey> nearestNeighbours, TKey maxSearchRadiusSquared) { }

	private void AddNodesBalanced(KdTreeNode<TKey, TValue>[] nodes, int byDimension, int fromIndex, int toIndex) { }

	private void AddNodesToList(KdTreeNode<TKey, TValue> node, List<KdTreeNode`2<TKey, TValue>> nodes) { }

	private void AddNodeToStringBuilder(KdTreeNode<TKey, TValue> node, StringBuilder sb, int depth) { }

	public void Balance() { }

	public override void Clear() { }

	public override TKey[] FindValue(TValue value) { }

	public override TValue FindValueAt(TKey[] point) { }

	[CompilerGenerated]
	public AddDuplicateBehavior get_AddDuplicateBehavior() { }

	[CompilerGenerated]
	public override int get_Count() { }

	[IteratorStateMachine(typeof(<GetEnumerator>d__33))]
	public override IEnumerator<KdTreeNode`2<TKey, TValue>> GetEnumerator() { }

	public override KdTreeNode<TKey, TValue>[] GetNearestNeighbours(TKey[] point, int count) { }

	public static KdTree<TKey, TValue> LoadFromFile(string filename) { }

	public override KdTreeNode<TKey, TValue>[] RadialSearch(TKey[] center, TKey radius, int count) { }

	private void ReadChildNodes(KdTreeNode<TKey, TValue> removedNode) { }

	public override void RemoveAt(TKey[] point) { }

	private void RemoveChildNodes(KdTreeNode<TKey, TValue> node) { }

	public void SaveToFile(string filename) { }

	[CompilerGenerated]
	private void set_AddDuplicateBehavior(AddDuplicateBehavior value) { }

	[CompilerGenerated]
	private void set_Count(int value) { }

	private void SortNodesArray(KdTreeNode<TKey, TValue>[] nodes, int byDimension, int fromIndex, int toIndex) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public virtual string ToString() { }

	public override bool TryFindValue(TValue value, out TKey[] point) { }

	public override bool TryFindValueAt(TKey[] point, out TValue value) { }

}

