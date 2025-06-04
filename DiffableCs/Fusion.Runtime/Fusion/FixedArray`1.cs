namespace Fusion;

[DebuggerDisplay("Length = {Length}")]
[DefaultMember("Item")]
public struct FixedArray : IEnumerable<T>, IEnumerable
{
	internal struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		private int _index; //Field offset: 0x0
		private FixedArray<T> _array; //Field offset: 0x0

		public override T Current
		{
			 get { } //Length: 144
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 104
		}

		public Enumerator(FixedArray<T> array) { }

		public override void Dispose() { }

		public override T get_Current() { }

		public override bool MoveNext() { }

		public override void Reset() { }

		private override object System.Collections.IEnumerator.get_Current() { }

	}

	private static StringBuilder _stringBuilderCached; //Field offset: 0x0
	private int _length; //Field offset: 0x0
	private T* _array; //Field offset: 0x0

	public T Item
	{
		 get { } //Length: 84
	}

	public int Length
	{
		 get { } //Length: 8
	}

	public FixedArray`1(T* array, int length) { }

	public void Clear() { }

	public void CopyFrom(T[] source, int sourceOffset, int sourceCount) { }

	public void CopyFrom(List<T> source, int sourceOffset, int sourceCount) { }

	public void CopyTo(List<T> list) { }

	public void CopyTo(T[] array, bool throwIfOverflow = true) { }

	public T get_Item(int index) { }

	public int get_Length() { }

	public Enumerator<T> GetEnumerator() { }

	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public T[] ToArray() { }

	private string ToListString() { }

	public virtual string ToString() { }

}

