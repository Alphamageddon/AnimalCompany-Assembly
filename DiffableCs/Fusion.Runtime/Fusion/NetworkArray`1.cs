namespace Fusion;

[DebuggerDisplay("Length = {Length}")]
[DebuggerTypeProxy(typeof(DebuggerProxy))]
[DefaultMember("Item")]
public struct NetworkArray : IEnumerable<T>, IEnumerable, INetworkArray
{
	public class DebuggerProxy
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass0_0
		{
			public NetworkArray<T> array; //Field offset: 0x0

			public <>c__DisplayClass0_0() { }

			internal T[] <.ctor>b__0() { }

		}

		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		public Lazy<T[]> _items; //Field offset: 0x0

		[DebuggerBrowsable(DebuggerBrowsableState::RootHidden (3))]
		public T[] Items
		{
			 get { } //Length: 60
		}

		public DebuggerProxy(NetworkArray<T> array) { }

		public T[] get_Items() { }

	}

	internal struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		private int _index; //Field offset: 0x0
		private NetworkArray<T> _array; //Field offset: 0x0

		public override T Current
		{
			 get { } //Length: 136
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 108
		}

		public Enumerator(NetworkArray<T> array) { }

		public override void Dispose() { }

		public override T get_Current() { }

		public override bool MoveNext() { }

		public override void Reset() { }

		private override object System.Collections.IEnumerator.get_Current() { }

	}

	private static StringBuilder _stringBuilderCached; //Field offset: 0x0
	private Byte* _array; //Field offset: 0x0
	private int _length; //Field offset: 0x0
	private IElementReaderWriter<T> _readerWriter; //Field offset: 0x0

	private override object Fusion.INetworkArray.Item
	{
		private get { } //Length: 124
		private set { } //Length: 184
	}

	public T Item
	{
		 get { } //Length: 232
		 set { } //Length: 252
	}

	public int Length
	{
		 get { } //Length: 8
	}

	public NetworkArray`1(Byte* array, int length, IElementReaderWriter<T> readerWriter) { }

	public void Clear() { }

	public void CopyFrom(List<T> source, int sourceOffset, int sourceCount) { }

	public void CopyFrom(T[] source, int sourceOffset, int sourceCount) { }

	public void CopyTo(List<T> list) { }

	public void CopyTo(T[] array, bool throwIfOverflow = true) { }

	public void CopyTo(NetworkArray<T> array) { }

	private override object Fusion.INetworkArray.get_Item(int index) { }

	private override void Fusion.INetworkArray.set_Item(int index, object value) { }

	public T Get(int index) { }

	public T get_Item(int index) { }

	public int get_Length() { }

	public Enumerator<T> GetEnumerator() { }

	internal T GetRef(int index) { }

	public static NetworkArrayReadOnly<T> op_Implicit(NetworkArray<T> value) { }

	public T Set(int index, T value) { }

	public void set_Item(int index, T value) { }

	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public T[] ToArray() { }

	private string ToListString() { }

	public NetworkArrayReadOnly<T> ToReadOnly() { }

	public virtual string ToString() { }

}

