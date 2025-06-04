namespace System.Net.Http.Headers;

public sealed class HttpHeaderValueCollection : ICollection<T>, IEnumerable<T>, IEnumerable
{
	private readonly List<T> list; //Field offset: 0x0
	private readonly HttpHeaders headers; //Field offset: 0x0
	private readonly HeaderInfo headerInfo; //Field offset: 0x0
	private List<String> invalidValues; //Field offset: 0x0

	public override int Count
	{
		 get { } //Length: 28
	}

	internal List<String> InvalidValues
	{
		internal get { } //Length: 8
	}

	public override bool IsReadOnly
	{
		 get { } //Length: 8
	}

	internal HttpHeaderValueCollection`1(HttpHeaders headers, HeaderInfo headerInfo) { }

	public override void Add(T item) { }

	internal void AddInvalidValue(string invalidValue) { }

	internal void AddRange(List<T> values) { }

	public override void Clear() { }

	public override bool Contains(T item) { }

	public override void CopyTo(T[] array, int arrayIndex) { }

	internal T Find(Predicate<T> predicate) { }

	public override int get_Count() { }

	internal List<String> get_InvalidValues() { }

	public override bool get_IsReadOnly() { }

	public override IEnumerator<T> GetEnumerator() { }

	public override bool Remove(T item) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public virtual string ToString() { }

}

