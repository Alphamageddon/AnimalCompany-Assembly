namespace Oculus.Platform.Models;

[DefaultMember("Item")]
public class DeserializableList : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
{
	protected List<T> _Data; //Field offset: 0x0
	protected string _NextUrl; //Field offset: 0x0
	protected string _PreviousUrl; //Field offset: 0x0

	public override int Count
	{
		 get { } //Length: 28
	}

	[Obsolete("Use IList interface on the DeserializableList object instead.", False)]
	public List<T> Data
	{
		 get { } //Length: 8
	}

	public bool HasNextPage
	{
		 get { } //Length: 32
	}

	public bool HasPreviousPage
	{
		 get { } //Length: 32
	}

	public override T Item
	{
		 get { } //Length: 36
		 set { } //Length: 36
	}

	public string NextUrl
	{
		 get { } //Length: 8
	}

	public string PreviousUrl
	{
		 get { } //Length: 8
	}

	private override bool System.Collections.Generic.ICollection<T>.IsReadOnly
	{
		private get { } //Length: 140
	}

	public DeserializableList`1() { }

	public override void Add(T item) { }

	public override void Clear() { }

	public override bool Contains(T item) { }

	public override void CopyTo(T[] array, int arrayIndex) { }

	public override int get_Count() { }

	public List<T> get_Data() { }

	public bool get_HasNextPage() { }

	public bool get_HasPreviousPage() { }

	public override T get_Item(int index) { }

	public string get_NextUrl() { }

	public string get_PreviousUrl() { }

	public override IEnumerator<T> GetEnumerator() { }

	private IEnumerator GetEnumerator1() { }

	public override int IndexOf(T obj) { }

	public override void Insert(int index, T item) { }

	public override bool Remove(T item) { }

	public override void RemoveAt(int index) { }

	public override void set_Item(int index, T value) { }

	private override bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

