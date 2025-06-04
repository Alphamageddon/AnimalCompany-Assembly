namespace UnityEngine.ProBuilder.KdTree;

[DefaultMember("Item")]
internal class KdTreeNode
{
	public TKey[] Point; //Field offset: 0x0
	public TValue Value; //Field offset: 0x0
	public List<TValue> Duplicates; //Field offset: 0x0
	internal KdTreeNode<TKey, TValue> LeftChild; //Field offset: 0x0
	internal KdTreeNode<TKey, TValue> RightChild; //Field offset: 0x0

	public bool IsLeaf
	{
		 get { } //Length: 32
	}

	internal KdTreeNode<TKey, TValue> Item
	{
		internal get { } //Length: 24
		internal set { } //Length: 24
	}

	public KdTreeNode`2() { }

	public KdTreeNode`2(TKey[] point, TValue value) { }

	public void AddDuplicate(TValue value) { }

	public bool get_IsLeaf() { }

	internal KdTreeNode<TKey, TValue> get_Item(int compare) { }

	internal void set_Item(int compare, KdTreeNode<TKey, TValue> value) { }

	public virtual string ToString() { }

}

