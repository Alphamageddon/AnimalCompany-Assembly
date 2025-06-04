namespace UnityEngine.XR.Interaction.Toolkit.Utilities;

internal abstract class BaseRegistrationList
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c<T> <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal List<T> <.cctor>b__30_0() { }

		internal void <.cctor>b__30_1(List<T> list) { }

	}

	private static readonly LinkedPool<List`1<T>> s_BufferedListPool; //Field offset: 0x0
	[CompilerGenerated]
	private readonly List<T> <registeredSnapshot>k__BackingField; //Field offset: 0x0
	protected List<T> m_BufferedAdd; //Field offset: 0x0
	protected List<T> m_BufferedRemove; //Field offset: 0x0

	protected int bufferedAddCount
	{
		 get { } //Length: 24
	}

	protected int bufferedRemoveCount
	{
		 get { } //Length: 24
	}

	public int flushedCount
	{
		 get { } //Length: 60
	}

	public List<T> registeredSnapshot
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	private static BaseRegistrationList`1() { }

	protected BaseRegistrationList`1() { }

	protected void AddToBufferedAdd(T item) { }

	protected void AddToBufferedRemove(T item) { }

	protected void ClearBufferedAdd() { }

	protected void ClearBufferedRemove() { }

	protected static void EnsureCapacity(List<T> list, int capacity) { }

	public abstract void Flush() { }

	protected int get_bufferedAddCount() { }

	protected int get_bufferedRemoveCount() { }

	public int get_flushedCount() { }

	[CompilerGenerated]
	public List<T> get_registeredSnapshot() { }

	public abstract T GetRegisteredItemAt(int index) { }

	public abstract void GetRegisteredItems(List<T> results) { }

	public abstract bool IsRegistered(T item) { }

	public abstract bool IsStillRegistered(T item) { }

	public bool MoveItemImmediately(T item, int newIndex) { }

	protected override void OnItemMovedImmediately(T item, int newIndex) { }

	public abstract bool Register(T item) { }

	protected bool RemoveFromBufferedAdd(T item) { }

	protected bool RemoveFromBufferedRemove(T item) { }

	public abstract bool Unregister(T item) { }

	public void UnregisterAll() { }

}

