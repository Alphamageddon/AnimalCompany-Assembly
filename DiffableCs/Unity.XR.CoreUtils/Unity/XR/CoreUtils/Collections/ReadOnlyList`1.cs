namespace Unity.XR.CoreUtils.Collections;

[DefaultMember("Item")]
public class ReadOnlyList : IReadOnlyList<T>, IEnumerable<T>, IEnumerable, IReadOnlyCollection<T>
{
	private readonly List<T> m_List; //Field offset: 0x0

	public override int Count
	{
		 get { } //Length: 40
	}

	public override T Item
	{
		 get { } //Length: 180
	}

	public ReadOnlyList`1(List<T> list) { }

	public override int get_Count() { }

	public override T get_Item(int index) { }

	public Enumerator<T> GetEnumerator() { }

	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

